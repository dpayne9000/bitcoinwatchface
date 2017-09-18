#include <tizen.h>
#include "bitcoinwatch.h"
#include <curl/curl.h>
#include <net_connection.h>
#include <Ecore.h>
#include <json-glib.h>
#include <pthread.h>


#define TEXT_BUF_SIZE 256
struct MemoryStruct {
	char *memory;
	size_t size;
};


struct MemoryStruct chunk;
static const char* _klongtimer = "_long_timer";

static void
update_watch(appdata_s *ad, watch_time_h watch_time, int ambient)
{
	char watch_text[TEXT_BUF_SIZE];
	int hour24, minute, second;

	if (watch_time == NULL)
		return;

	watch_time_get_hour24(watch_time, &hour24);
	watch_time_get_minute(watch_time, &minute);
	watch_time_get_second(watch_time, &second);


	if (!ambient) {//<color=#1ec503>
		snprintf(watch_text, TEXT_BUF_SIZE, "<align=center><color=#9e9e9e><font_size=95>%02d:%02d</font_size></color></align>",
			hour24, minute);
	} else {
		snprintf(watch_text, TEXT_BUF_SIZE, "<align=center><font_size=55>%02d:%02d</font_size></align>",
			hour24, minute);
	}

	elm_object_text_set(ad->label, watch_text);
}


void static
update_bitcoin(appdata_s *ad, int ambient) //remove if unused
{

	char bitcoin_text[TEXT_BUF_SIZE];
	gdouble bitcoin;

	bitcoin = get_bitcoin(1); //needs callback to update this, so it's async
	//bitcoin = get_null(1);
	//get_bitcoin(ad,1);
	if (bitcoin==131){ // add case for ambient with no color
		snprintf(bitcoin_text, TEXT_BUF_SIZE, "<align=center><color=#dfdfdf>...</color></align>");
	} else {
		snprintf(bitcoin_text, TEXT_BUF_SIZE, "<align=center><color=#aaaaaa><font_size=35>$%g<color=#8e7044><font_size=35> BTC</font_size></color></font_size></color></align>",
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
__proxy_changed_cb(const char* ipv4_address, const char* ipv6_address, void* user_data)
{
    dlog_print(DLOG_INFO, LOG_TAG, "%s callback, IPv4 address: %s, IPv6 address: %s",
               (char *)user_data, ipv4_address, (ipv6_address ? ipv6_address : "NULL"));
}

gdouble get_bitcoin(int duh) {
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
		conn_err = connection_get_proxy(connection, CONNECTION_ADDRESS_FAMILY_IPV4, &proxy_address);

		conn_err = connection_set_proxy_address_changed_cb(connection,
		                                                   __proxy_changed_cb, NULL);

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
		//}

						curl_easy_setopt(curl, CURLOPT_PROXY, proxy_address);
						dlog_print(DLOG_DEBUG, LOG_TAG, "proxy address %s", proxy_address);




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
//		JsonObject *usd_obj = json_object_get_object_member(items_obj,"USD");
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

	/* Label*/

	ad->label2 = elm_label_add(ad->conform);
	evas_object_resize(ad->label2, width, height / 2);
	evas_object_move(ad->label2, 0, height / 1.7);
	evas_object_show(ad->label2);

	/* Background */
	/*
	ad->background = evas_object_image_add(ad->conform);
	evas_object_image_file_set(ad->background, "./res/images/background.png", NULL);
	err = evas_object_image_load_error_get(ad->background);
	 if (err != EVAS_LOAD_ERROR_NONE)
	   {
	      dlog_print(DLOG_ERROR, LOG_TAG, "could not load image ./res/images/background.png. error string is \"%s\"\n",
	              evas_load_error_str(err));
	   }


	    /* Set the size and position of the image on the image object area */
		/*
	    evas_object_image_fill_set(ad->background, 0, 0, width, height);

	    evas_object_move(ad->background, 0, 0);
	    evas_object_resize(ad->background, width, height/2);
	    evas_object_show(ad->background);*/

	ret = watch_time_get_current_time(&watch_time);
	if (ret != APP_ERROR_NONE)
		dlog_print(DLOG_ERROR, LOG_TAG, "failed to get current time. err = %d", ret);

	update_watch(ad, watch_time, 0);
	update_bitcoin(ad,0);
	//

	dlog_print(DLOG_DEBUG, LOG_TAG, "create ui");
	watch_time_delete(watch_time);

	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}

static bool
app_create(int width, int height, void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;
	Ecore_Timer *timer = evas_object_data_get(ad, _klongtimer);

	create_base_gui(ad, width, height);
	//ecore_timer_add(3, sendRequest, NULL);
	timer = ecore_timer_add(10, bitcoin_cb, ad);
	evas_object_data_set(NULL, _klongtimer, timer);

	dlog_print(DLOG_DEBUG, LOG_TAG, "app create");
	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "app pause");
	appdata_s *ad = data;
	Ecore_Timer *timer = evas_object_data_get(ad, _klongtimer);
	ecore_timer_del(timer);
	evas_object_data_del(NULL, _klongtimer);
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	dlog_print(DLOG_DEBUG, LOG_TAG, "app resume");
	appdata_s *ad = data;
	Ecore_Timer *timer = evas_object_data_get(ad, _klongtimer);
	timer = ecore_timer_add(10, bitcoin_cb, ad);
	evas_object_data_set(NULL, _klongtimer, timer);
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	dlog_print(DLOG_ERROR, LOG_TAG, "app terminated");
	/* Release all resources. */
}

static void
app_time_tick(watch_time_h watch_time, void *data)
{
	/* Called at each second while your app is visible. Update watch UI. */
	appdata_s *ad = data;
	update_watch(ad, watch_time, 0);
}

static void
app_ambient_tick(watch_time_h watch_time, void *data)
{
	/* Called at each minute while the device is in ambient mode. Update watch UI. */
	appdata_s *ad = data;
	update_watch(ad, watch_time, 1);
}

static void
app_ambient_changed(bool ambient_mode, void *data)
{
	// destroy old timer
	//start new timer with ambient mode enabled, for longer delay between ticks
	/* Update your watch UI to conform to the ambient mode */
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

