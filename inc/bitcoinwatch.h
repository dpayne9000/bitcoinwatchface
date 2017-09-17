#ifndef __bitcoinwatch_H__
#define __bitcoinwatch_H__

#include <watch_app.h>
#include <watch_app_efl.h>
#include <Elementary.h>
#include <dlog.h>
#include <json-glib.h>
#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "bitcoinwatch"

#if !defined(PACKAGE)
#define PACKAGE "org.example.bitcoinwatch"
#endif
#define G_TYPE_INTEGER 40

#endif /* __bitcoinwatch_H__ */

gdouble get_bitcoin(int);
