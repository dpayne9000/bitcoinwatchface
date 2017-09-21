#ifndef __bitcoinwatch_H__
#define __bitcoinwatch_H__
#include <tizen.h>
#include <watch_app.h>
#include <watch_app_efl.h>
#include <Elementary.h>
#include <dlog.h>
#include <json-glib.h>
#include <Ecore.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "bitcoinwatch"

#if !defined(PACKAGE)
#define PACKAGE "org.example.bitcoinwatch"
#endif
#define G_TYPE_INTEGER 40

#endif /* __bitcoinwatch_H__ */

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *label2;
	Evas_Object *background;
	Evas_Object *ampm;
	Ecore_Timer *timer;
} appdata_s;

gdouble get_bitcoin(int);
Eina_Bool bitcoin_cb(appdata_s *);
