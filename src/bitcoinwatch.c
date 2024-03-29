#include <tizen.h>
#include "bitcoinwatch.h"
#include <curl/curl.h>
#include <net_connection.h>
#include <Ecore.h>
#include <json-glib.h>
#include <pthread.h>


#define TEXT_BUF_SIZE 256
#define AMPM_BUF_SIZE 256
struct MemoryStruct {
	char *memory;
	size_t size;
};


struct MemoryStruct chunk;
static const char* _klongtimer = "_long_timer";

char*
concat(char* first, char* second) {
	char* result = malloc(snprintf(NULL, 0, "%s%s", first, second)+1);
	sprintf(result, "%s%s", first, second);

	return result;
}

static void
update_watch(appdata_s *ad, watch_time_h watch_time, int ambient)
{
	char watch_text[TEXT_BUF_SIZE];
	int hour24, hour, minute, second;
	char ampm[AMPM_BUF_SIZE];

	if (watch_time == NULL)
		return;

	watch_time_get_hour24(watch_time, &hour24);
	watch_time_get_hour(watch_time, &hour);
	watch_time_get_minute(watch_time, &minute);
	watch_time_get_second(watch_time, &second);

	if (hour24>12){
		snprintf(ampm, AMPM_BUF_SIZE, "<font_size=35>PM</font_size></color></align>");

	} else {
		snprintf(ampm, AMPM_BUF_SIZE, "<font_size=35>AM</font_size></color></align>");
	}

		snprintf(watch_text, TEXT_BUF_SIZE, "<align=center><color=#e4e4e4><font_size=95>%d:%02d</font_size>",
				hour, minute);

	elm_object_text_set(ad->label, concat(watch_text,ampm));


}


void static
update_bitcoin(appdata_s *ad, int ambient) //remove if unused
{

	char bitcoin_text[TEXT_BUF_SIZE];
	gdouble bitcoin;

	bitcoin = get_bitcoin(1,ad); //needs callback to update this, so it's async

	if (bitcoin==131){ // add case for ambient with no color
		snprintf(bitcoin_text, TEXT_BUF_SIZE, "<align=center><color=#e4e4e4>...</color></align>");
	} else { //8e7044 dark bitcoin
		snprintf(bitcoin_text, TEXT_BUF_SIZE, "<align=center><color=#e4e4e4><font_size=35>$%g<color=#FF9900><font_size=35> BTC</font_size></color></font_size></color></align>",
				bitcoin);
	}
	dlog_print(DLOG_DEBUG, LOG_TAG, "updated bitcoin");
	elm_object_text_set(ad->label2, bitcoin_text);

}
Eina_Bool
bitcoin_cb(appdata_s *ad) { //void *data EINA_UNUSED
	update_bitcoin(ad,0);
	dlog_print(DLOG_DEBUG, LOG_TAG, "update cb");
	return EINA_TRUE;
}


static size_t
WriteMemoryCallback(void *contents, size_t size, size_t nmemb, void *userp)
{
	size_t realsize = size * nmemb;
	struct MemoryStruct *mem = (struct MemoryStruct *)userp;

	mem->memory = realloc(mem->memory, mem->size + realsize + 1);
	if(mem->memory == NULL) {
		return 0;
	}

	memcpy(&(mem->memory[mem->size]), contents, realsize);
	mem->size += realsize;
	mem->memory[mem->size] = 0;

	return realsize;
}


static void
__proxy_changed_cb(const char* ipv4_address, const char* ipv6_address, appdata_s *ad)
{
	ad->proxy_address = ipv4_address;
    dlog_print(DLOG_INFO, LOG_TAG, "callback, IPv4 address: %s, IPv6 address: %s",
               ipv4_address, (ipv6_address ? ipv6_address : "NULL"));

}

gdouble get_bitcoin(int duh, appdata_s *ad) {
	JsonParser *jsonParser  =  NULL;
	GError *error  =  NULL;
	jsonParser = json_parser_new ();

	CURL *curl;
	CURLcode res;

	chunk.memory = malloc(1);
	chunk.size = 0;

	curl = curl_easy_init();

	if (curl){
		connection_h connection;
		int conn_err;
		conn_err = connection_create(&connection);
		if (conn_err != CONNECTION_ERROR_NONE) {
			/* Error handling */
			dlog_print(DLOG_DEBUG, LOG_TAG, "conenction error");
			return 130;
		}

		//connection_wifi_state_e wifi_state;
		//connection_get_wifi_state(connection, &wifi_state);
		char *proxy_address;
		conn_err = connection_get_proxy(connection, CONNECTION_ADDRESS_FAMILY_IPV4, &ad->proxy_address);

		conn_err = connection_set_proxy_address_changed_cb(connection,
		                                                   __proxy_changed_cb, ad);

		if (conn_err != CONNECTION_ERROR_NONE) {
		    /* Error handling */
			dlog_print(DLOG_ERROR, LOG_TAG, "proxy cb error");
		    return 0;
		}

		//if (wifi_state == CONNECTION_WIFI_STATE_DISCONNECTED ){
		//
		//	if (conn_err == CONNECTION_ERROR_NONE && proxy_address) {

		//		dlog_print(DLOG_DEBUG, LOG_TAG, "wifi disconnected");
				//curl_easy_setopt(curl, CURLOPT_PROXY, proxy_address);
				//dlog_print(DLOG_DEBUG, LOG_TAG, "proxy address %s", proxy_address);
		//	}
		//	if (conn_err != CONNECTION_ERROR_NONE) {
		//		dlog_print(DLOG_DEBUG, LOG_TAG, "proxy error address %s", conn_err);
		//	}
		//} connection state handling, not currently needed

						curl_easy_setopt(curl, CURLOPT_PROXY, ad->proxy_address);//
						dlog_print(DLOG_DEBUG, LOG_TAG, "proxy address %s", ad->proxy_address);




		curl_easy_setopt(curl, CURLOPT_URL, "https://blockchain.info/ticker");
		curl_easy_setopt(curl, CURLOPT_WRITEFUNCTION, WriteMemoryCallback);
		curl_easy_setopt(curl, CURLOPT_WRITEDATA, (void *)&chunk);
		res = curl_easy_perform(curl);
		if (res != CURLE_OK) {
			dlog_print(DLOG_ERROR, LOG_TAG, "curl error");
			return 131;
		}

		curl_easy_cleanup(curl);
		connection_destroy(connection);
		dlog_print(DLOG_DEBUG, LOG_TAG, chunk.memory);


		json_parser_load_from_data(jsonParser, chunk.memory, strlen(chunk.memory),NULL);
		dlog_print(DLOG_DEBUG, LOG_TAG, "response %s", chunk.memory);
		JsonObject *object;
		JsonNode *root;


		root = json_parser_get_root(jsonParser);

		JsonObject *items_obj = json_object_get_object_member(json_node_get_object(root), "USD");
		//JsonObject *usd_obj = json_object_get_object_member(items_obj,"USD");
		dlog_print(DLOG_DEBUG, LOG_TAG, "Size: %d", json_object_get_size(items_obj));
		gdouble bitcoin_rate = json_object_get_double_member(items_obj, "last");
		dlog_print(DLOG_DEBUG, LOG_TAG, "Rate: %g", bitcoin_rate);
		free(chunk.memory);
		//free other memory
		g_object_unref(jsonParser);
		return bitcoin_rate;

	} else {
		dlog_print(DLOG_DEBUG, LOG_TAG, "curl fail");
		return 420;
	}
}

static void
create_base_gui(appdata_s *ad, int width, int height)
{
	int ret;
	watch_time_h watch_time = NULL;
	int err;
	/* Window */
	ret = watch_app_get_elm_win(&ad->win);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "failed to get window. err = %d", ret);
		return;
	}

	evas_object_resize(ad->win, width, height);

	/* Conformant */

	ad->conform = elm_conformant_add(ad->win);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	/* Label*/

	ad->label = elm_label_add(ad->conform);
	evas_object_resize(ad->label, width, height / 3);
	evas_object_move(ad->label, 0, height / 3.7);
	evas_object_show(ad->label);

	/* ampm */
	ad->ampm = elm_label_add(ad->conform);
	evas_object_resize(ad->ampm, width, height / 3);//-20
	evas_object_move(ad->ampm, 0, height / 2.3);
	evas_object_show(ad->ampm);

	/* Label*/

	ad->label2 = elm_label_add(ad->conform);
	evas_object_resize(ad->label2, width, height / 2);
	evas_object_move(ad->label2, 0, height / 1.7);
	evas_object_show(ad->label2);

	ret = watch_time_get_current_time(&watch_time);
	if (ret != APP_ERROR_NONE)
		dlog_print(DLOG_ERROR, LOG_TAG, "failed to get current time. err = %d", ret);

	update_watch(ad, watch_time, 0);
	update_bitcoin(ad,0);
	//

	dlog_print(DLOG_DEBUG, LOG_TAG, "create ui");
	watch_time_delete(watch_time);

	evas_object_show(ad->win);
}

static bool
app_create(int width, int height, void *data)
{
	appdata_s *ad = data;


	create_base_gui(ad, width, height);

	if (ad->timer == NULL) {
		Ecore_Timer *timer = evas_object_data_get(ad, _klongtimer);
		timer = ecore_timer_add(10, bitcoin_cb, ad);
	    if (timer != NULL)
	        ad->timer = timer;
	}

	dlog_print(DLOG_DEBUG, LOG_TAG, "app create");
	return true;
}

static void
app_control(app_control_h app_control, void *data)
{

}

static void
app_pause(void *data)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "app pause");
	//appdata_s *ad = data;
    //if (ad->timer)
    //    ecore_timer_del(ad->timer);
    //	ad->timer = NULL;
}

static void
app_resume(void *data)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "app resume");
	//appdata_s *ad = data;

	//update_bitcoin(ad,0);

	//if (ad->timer==NULL) {
	//	Ecore_Timer *timer = evas_object_data_get(ad, _klongtimer);
	//	timer = ecore_timer_add(10, bitcoin_cb, ad);
	//    if (timer != NULL)
	//        ad->timer = timer;
	//}

}

static void
app_terminate(void *data)
{
	dlog_print(DLOG_ERROR, LOG_TAG, "app terminated");
	/* Release all resources. */
	appdata_s *ad = data;
    if (ad->timer)
        ecore_timer_del(ad->timer);
    	ad->timer = NULL;
}

static void
app_time_tick(watch_time_h watch_time, void *data)
{
	appdata_s *ad = data;
	update_watch(ad, watch_time, 0);
}

static void
app_ambient_tick(watch_time_h watch_time, void *data)
{
	appdata_s *ad = data;
	update_watch(ad, watch_time, 1);
}

static void
app_ambient_changed(bool ambient_mode, void *data)
{
	// destroy old timer
	//start new ambient mode timer
	/* Update your watch UI for ambient mode */
}

static void
watch_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	app_event_get_language(event_info, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
watch_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	watch_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;
	event_callback.time_tick = app_time_tick;
	event_callback.ambient_tick = app_ambient_tick;
	event_callback.ambient_changed = app_ambient_changed;



	watch_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED],
		APP_EVENT_LANGUAGE_CHANGED, watch_app_lang_changed, &ad);
	watch_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED],
		APP_EVENT_REGION_FORMAT_CHANGED, watch_app_region_changed, &ad);

	ret = watch_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "watch_app_main() is failed. err = %d", ret);
	}

	return ret;
}

