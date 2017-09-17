S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.3
Build-Number: R765VVRU1AQF4
Build-Date: 2017.07.17 17:00:49

Crash Information
Process Name: bitcoinwatch
PID: 5396
Date: 2017-09-17 11:18:27-0700
Executable File Path: /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x407178bc
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6e999b8, r5   = 0xf6e999b8
r6   = 0xf6e9916c, r7   = 0xf6e999b8
r8   = 0xf6e999b8, r9   = 0xf74f8ff8
r10  = 0xf6ea7b10, fp   = 0x0000018f
ip   = 0x00000001, sp   = 0xff7f8230
lr   = 0xf6e891f9, pc   = 0x00000000
cpsr = 0x60000030

Memory Information
MemTotal:   620380 KB
MemFree:     20604 KB
Buffers:     15500 KB
Cached:     144280 KB
VmPeak:      77568 KB
VmSize:      77568 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23984 KB
VmRSS:       23984 KB
VmData:      21252 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       21132 KB
VmPTE:         116 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5396 TID = 5396
5396 5420 5426 

Maps Information
f2afe000 f32fd000 rw-p [stack:5426]
f339a000 f33b1000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f33be000 f33c9000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f33d2000 f33dd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f33e6000 f3be5000 rw-p [stack:5420]
f3de5000 f3df5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f3dfd000 f3e08000 r-xp /usr/lib/libtbm.so.1.0.0
f3e10000 f3e59000 r-xp /usr/lib/libmdm.so.1.2.69
f3e61000 f3e67000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f3e6f000 f3e71000 r-xp /usr/lib/libdri2.so.0.0.0
f3e79000 f3e81000 r-xp /usr/lib/libdrm.so.2.4.0
f3e89000 f3e99000 r-xp /usr/lib/libwidget_provider.so.1.0.0
f3ea1000 f3eaa000 r-xp /usr/lib/libcom-core.so.0.0.1
f574c000 f5751000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5759000 f5772000 r-xp /usr/lib/libnetwork.so.0.0.0
f577a000 f5784000 r-xp /usr/lib/libwidget.so.1.0.0
f578c000 f579f000 r-xp /usr/lib/libwidget_service.so.1.0.0
f57a8000 f57af000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
f57b8000 f58be000 r-xp /usr/lib/libicuuc.so.57.1
f58d4000 f5a5c000 r-xp /usr/lib/libicui18n.so.57.1
f5a6c000 f5a79000 r-xp /usr/lib/libalarm.so.0.0.0
f5a83000 f5a92000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f5a9b000 f5aab000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f5ab3000 f5abb000 r-xp /usr/lib/libappcore-watch.so.1.1
f5acd000 f5ad2000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f5c6c000 f5c76000 r-xp /lib/libnss_files-2.13.so
f5c7f000 f5d4e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5d64000 f5d88000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5d91000 f5d97000 r-xp /usr/lib/libappsvc.so.0.1.0
f5d9f000 f5da3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5db1000 f5db3000 r-xp /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
f5dc3000 f5dc5000 r-xp /usr/lib/libiniparser.so.0
f5dce000 f5dd3000 r-xp /usr/lib/libappcore-common.so.1.1
f5ddb000 f5ddd000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5de6000 f5dea000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5df7000 f5df9000 r-xp /usr/lib/libXau.so.6.0.0
f5e01000 f5e08000 r-xp /lib/libcrypt-2.13.so
f5e38000 f5e3a000 r-xp /usr/lib/libiri.so
f5e43000 f5fec000 r-xp /usr/lib/libcrypto.so.1.0.0
f600c000 f6053000 r-xp /usr/lib/libssl.so.1.0.0
f605f000 f608d000 r-xp /usr/lib/libidn.so.11.5.44
f6095000 f609e000 r-xp /usr/lib/libcares.so.2.1.0
f60a8000 f60bb000 r-xp /usr/lib/libxcb.so.1.1.0
f60c4000 f60c6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f60ce000 f60d0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f60d9000 f61a5000 r-xp /usr/lib/libxml2.so.2.7.8
f61b2000 f61b4000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f61bd000 f61c2000 r-xp /usr/lib/libffi.so.5.0.10
f61ca000 f61cb000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f61d3000 f61d6000 r-xp /lib/libattr.so.1.1.0
f61de000 f6272000 r-xp /usr/lib/libstdc++.so.6.0.16
f6285000 f62a2000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f62ac000 f62c4000 r-xp /usr/lib/libpng12.so.0.50.0
f62cc000 f62e2000 r-xp /lib/libexpat.so.1.6.0
f62ec000 f6330000 r-xp /usr/lib/libcurl.so.4.3.0
f6339000 f6343000 r-xp /usr/lib/libXext.so.6.4.0
f634c000 f6350000 r-xp /usr/lib/libXtst.so.6.1.0
f6358000 f635e000 r-xp /usr/lib/libXrender.so.1.3.0
f6366000 f636c000 r-xp /usr/lib/libXrandr.so.2.2.0
f6374000 f6375000 r-xp /usr/lib/libXinerama.so.1.0.0
f637e000 f6387000 r-xp /usr/lib/libXi.so.6.1.0
f638f000 f6392000 r-xp /usr/lib/libXfixes.so.3.1.0
f639a000 f639c000 r-xp /usr/lib/libXgesture.so.7.0.0
f63a4000 f63a6000 r-xp /usr/lib/libXcomposite.so.1.0.0
f63ae000 f63b0000 r-xp /usr/lib/libXdamage.so.1.1.0
f63b8000 f63bf000 r-xp /usr/lib/libXcursor.so.1.0.2
f63c7000 f63ca000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f63d2000 f63d6000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f63df000 f63e4000 r-xp /usr/lib/libecore_fb.so.1.7.99
f63ed000 f64ce000 r-xp /usr/lib/libX11.so.6.3.0
f64d9000 f64fc000 r-xp /usr/lib/libjpeg.so.8.0.2
f6514000 f652a000 r-xp /lib/libz.so.1.2.5
f6532000 f6534000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f653c000 f65b1000 r-xp /usr/lib/libsqlite3.so.0.8.6
f65bb000 f65d5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f65dd000 f6611000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f661a000 f66ed000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f66f8000 f6708000 r-xp /lib/libresolv-2.13.so
f670c000 f6724000 r-xp /usr/lib/liblzma.so.5.0.3
f672c000 f672f000 r-xp /lib/libcap.so.2.21
f6737000 f6766000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f676f000 f6770000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6778000 f677e000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6786000 f679d000 r-xp /usr/lib/liblua-5.1.so
f67a6000 f67ad000 r-xp /usr/lib/libembryo.so.1.7.99
f67b5000 f67bb000 r-xp /lib/librt-2.13.so
f67c4000 f681a000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6827000 f687d000 r-xp /usr/lib/libfreetype.so.6.11.3
f6889000 f68b1000 r-xp /usr/lib/libfontconfig.so.1.8.0
f68b2000 f68f7000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6900000 f6913000 r-xp /usr/lib/libfribidi.so.0.3.1
f691b000 f6935000 r-xp /usr/lib/libecore_con.so.1.7.99
f693e000 f6947000 r-xp /usr/lib/libedbus.so.1.7.99
f694f000 f699f000 r-xp /usr/lib/libecore_x.so.1.7.99
f69a1000 f69aa000 r-xp /usr/lib/libvconf.so.0.2.45
f69b2000 f69c3000 r-xp /usr/lib/libecore_input.so.1.7.99
f69cb000 f69d0000 r-xp /usr/lib/libecore_file.so.1.7.99
f69d8000 f69fa000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6a03000 f6a44000 r-xp /usr/lib/libeina.so.1.7.99
f6a4d000 f6a66000 r-xp /usr/lib/libeet.so.1.7.99
f6a77000 f6ae0000 r-xp /lib/libm-2.13.so
f6ae9000 f6aef000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6af8000 f6af9000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b01000 f6b24000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b2c000 f6b31000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b39000 f6b63000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b6c000 f6b83000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b8b000 f6b96000 r-xp /lib/libunwind.so.8.0.1
f6bc3000 f6be1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6beb000 f6d0f000 r-xp /lib/libc-2.13.so
f6d1d000 f6d25000 r-xp /lib/libgcc_s-4.6.so.1
f6d26000 f6d2a000 r-xp /usr/lib/libsmack.so.1.0.0
f6d33000 f6d39000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6d41000 f6e11000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e12000 f6e70000 r-xp /usr/lib/libedje.so.1.7.99
f6e7a000 f6e91000 r-xp /usr/lib/libecore.so.1.7.99
f6ea8000 f6f76000 r-xp /usr/lib/libevas.so.1.7.99
f6f9b000 f70d7000 r-xp /usr/lib/libelementary.so.1.7.99
f70ee000 f7102000 r-xp /lib/libpthread-2.13.so
f710d000 f710f000 r-xp /usr/lib/libdlog.so.0.0.0
f7117000 f711a000 r-xp /usr/lib/libbundle.so.0.1.22
f7122000 f7124000 r-xp /lib/libdl-2.13.so
f712d000 f713a000 r-xp /usr/lib/libaul.so.0.1.0
f714c000 f7152000 r-xp /usr/lib/libappcore-efl.so.1.1
f715b000 f715f000 r-xp /usr/lib/libsys-assert.so
f7168000 f7185000 r-xp /lib/ld-2.13.so
f718e000 f7193000 r-xp /usr/bin/launchpad-loader
f74c1000 f7691000 rw-p [heap]
ff7d8000 ff7f9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5396)
Call Stack Count: 2
 0: (0xf6e891f9) [/usr/lib/libecore.so.1] + 0xf1f9
 1: ((nil)) (null)
End of Call Stack

Package Information
Package Name: org.example.bitcoinwatch
Package ID : org.example.bitcoinwatch
Version: 1.0.0
Package Type: rpm
App Name: bitcoinwatch
App ID: org.example.bitcoinwatch
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
l-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf826b998, elm_layout, _activated_obj : 0xf819d660, activated : 1
09-17 11:28:25.461-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-17 11:28:25.461-0700 W/W_HOME  ( 2907): win.c: win_back_gesture_disable_set(170) > disable back gesture
09-17 11:28:25.461-0700 W/W_HOME  ( 2907): win.c: win_back_gesture_disable_set(170) > disable back gesture
09-17 11:28:25.461-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:25.461-0700 W/W_HOME  ( 2907): noti_broker.c: _apptray_visibility_cb(793) > apps,show
09-17 11:28:25.461-0700 W/W_HOME  ( 2907): noti_broker.c: noti_broker_event_fire_to_plugin(1010) > source:1 event:80000
09-17 11:28:25.461-0700 W/wnotib  ( 2907): w-notification-board-broker-main.c: _wnb_handle_view_event(1289) > Home view event: 0x80000
09-17 11:28:25.461-0700 E/wnotib  ( 2907): w-notification-board-action.c: wnb_action_is_event_receivable(5137) > [NULL==g_wnb_action_data] msg Drawer not initialized.
09-17 11:28:25.461-0700 I/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_close_second_depth_view(5936) > wnotib_action_drawer_is_event_receivable: 0, third_depth_genlist: (nil), _wnb_bp_is_third_depth_thread_view: 0, wnotib_common_is_toast_popup_displayed: 0
09-17 11:28:25.461-0700 E/wnotib  ( 2907): w-notification-board-action.c: wnb_action_is_event_receivable(5137) > [NULL==g_wnb_action_data] msg Drawer not initialized.
09-17 11:28:25.461-0700 I/wnotib  ( 2907): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 1
09-17 11:28:25.461-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [6], notiboard card appending count [60].
09-17 11:28:25.461-0700 E/APPS    ( 2907): apps_main.c: apps_main_resume(1022) >  resumed already
09-17 11:28:25.461-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:28:25.461-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:28:25.501-0700 I/CAPI_NETWORK_CONNECTION( 5879): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:25.571-0700 D/bitcoinwatch( 5879): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:25.571-0700 D/bitcoinwatch( 5879): Size: 3
09-17 11:28:25.571-0700 D/bitcoinwatch( 5879): Rate: 3731.85
09-17 11:28:25.571-0700 E/bitcoinwatch( 5879): updated bitcoin
09-17 11:28:25.611-0700 I/CAPI_NETWORK_CONNECTION( 5879): connection.c: connection_create(453) > New handle created[0xf763d8b0]
09-17 11:28:25.671-0700 I/CAPI_NETWORK_CONNECTION( 5879): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:25.731-0700 D/bitcoinwatch( 5879): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:25.741-0700 D/bitcoinwatch( 5879): Size: 3
09-17 11:28:25.741-0700 D/bitcoinwatch( 5879): Rate: 3731.85
09-17 11:28:25.741-0700 E/bitcoinwatch( 5879): updated bitcoin
09-17 11:28:25.741-0700 W/WATCH_CORE( 5879): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:28:25.751-0700 E/WIDGET_PROVIDER_APP( 5879): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:28:25.771-0700 I/WATCH_CORE( 5879): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:28:25.771-0700 I/WATCH_CORE( 5879): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:28:25.771-0700 I/WATCH_CORE( 5879): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:28:25.771-0700 I/WATCH_CORE( 5879): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:28:25.831-0700 W/W_HOME  ( 2907): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
09-17 11:28:25.831-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:25.831-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:25.831-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:25.831-0700 W/W_HOME  ( 2907): win.c: win_back_gesture_disable_set(173) > enable back gesture
09-17 11:28:25.831-0700 W/W_HOME  ( 2907): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
09-17 11:28:25.841-0700 W/PROCESSMGR( 2371): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
09-17 11:28:25.851-0700 W/W_HOME  ( 2907): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
09-17 11:28:25.851-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:25.851-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:25.851-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:25.851-0700 W/W_HOME  ( 2907): win.c: win_back_gesture_disable_set(170) > disable back gesture
09-17 11:28:25.851-0700 W/W_HOME  ( 2907): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
09-17 11:28:25.851-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:28:25.851-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:28:25.891-0700 W/WATCH_CORE( 5879): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
09-17 11:28:25.891-0700 I/WATCH_CORE( 5879): appcore-watch.c: __signal_process_manager_handler(1273) > Skip the background tick update
09-17 11:28:25.891-0700 W/WATCH_CORE( 5879): appcore-watch.c: __widget_resume(1124) > widget_resume
09-17 11:28:25.931-0700 W/AUL     ( 5879): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.bitcoinwatch) pid(5879) status(fg) type(watchapp)
09-17 11:28:25.931-0700 I/CAPI_WATCH_APPLICATION( 5879): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-17 11:28:25.931-0700 D/bitcoinwatch( 5879): 8.79175e-283
09-17 11:28:25.941-0700 W/WATCH_CORE( 5879): appcore-watch.c: __widget_pause(1113) > widget_pause
09-17 11:28:25.941-0700 W/AUL     ( 5879): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.bitcoinwatch) pid(5879) status(bg) type(watchapp)
09-17 11:28:26.011-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:28:26.011-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:28:26.081-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:28:26.091-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5879
09-17 11:28:26.091-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:28:26.151-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:28:26.151-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:28:26.431-0700 I/AUL_PAD ( 5907): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:28:28.101-0700 I/APP_CORE( 3171): appcore-efl.c: __do_app(453) > [APP 3171] Event: MEM_FLUSH State: PAUSED
09-17 11:28:28.871-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(5879)
09-17 11:28:28.871-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:28:28.871-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(org.example.bitcoinwatch) pid(5879) type(watchapp)
09-17 11:28:28.871-0700 E/AUL     ( 2557): app_sock.c: __connect_client_sock(196) > connect error: 111
09-17 11:28:28.871-0700 E/AUL     ( 2557): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-17 11:28:28.871-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 5879 pgid = 5879
09-17 11:28:28.871-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:28:28.951-0700 E/RESOURCED( 2702): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/5879/oom_score_adj failed
09-17 11:28:28.951-0700 E/RESOURCED( 2702): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 5879
09-17 11:28:28.971-0700 E/AUL     ( 2557): app_sock.c: __connect_client_sock(196) > connect error: 111
09-17 11:28:28.971-0700 E/AUL     ( 2557): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-17 11:28:28.981-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:28:29.031-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11053326269741505672192
09-17 11:28:29.271-0700 E/AUL     ( 2557): app_sock.c: __connect_client_sock(196) > connect error: 111
09-17 11:28:29.271-0700 E/AUL     ( 2557): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-17 11:28:29.271-0700 E/AUL_AMD ( 2557): amd_launch.c: _term_app(1106) > fail to killing - 5879
09-17 11:28:29.271-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5879
09-17 11:28:29.271-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5879)
09-17 11:28:29.271-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-1)
09-17 11:28:29.271-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:28:29.271-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:28:29.271-0700 E/RESOURCED( 2702): proc-main.c: proc_app_list_remove_app_info(669) > Failed to remove appinfo 'org.example.bitcoinwatch': Not a directory
09-17 11:28:29.281-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:29.291-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:29.291-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:28:29.291-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:28:29.301-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:28:29.301-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:28:29.301-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:28:29.301-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:28:29.301-0700 W/AUL_PAD ( 5907): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:28:29.301-0700 W/AUL_PAD ( 5907): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:28:29.301-0700 W/AUL_PAD ( 5907): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:28:29.301-0700 W/AUL_PAD ( 5907): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:28:29.321-0700 W/AUL_PAD ( 5907): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:28:29.321-0700 W/AUL_PAD ( 5907): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:28:29.321-0700 I/CAPI_WATCH_APPLICATION( 5907): watch_app_main.c: watch_app_main(399) > watch_app_main
09-17 11:28:29.401-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.bitcoinwatch) pid(5907) type(watchapp) bg(0)
09-17 11:28:29.401-0700 W/AUL_AMD ( 2557): amd_status.c: __socket_monitor_cb(1277) > (5907) was created
09-17 11:28:29.401-0700 E/AUL     ( 2557): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-17 11:28:29.401-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5907)
09-17 11:28:29.401-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5907]
09-17 11:28:29.441-0700 W/WATCH_CORE( 5907): appcore-watch.c: __widget_create(1068) > widget_create
09-17 11:28:29.441-0700 I/CAPI_WATCH_APPLICATION( 5907): watch_app_main.c: watch_app_get_elm_win(663) > watch hwc mode is enabled
09-17 11:28:29.471-0700 I/APP_CORE( 4283): appcore-efl.c: __do_app(453) > [APP 4283] Event: MEM_FLUSH State: PAUSED
09-17 11:28:29.511-0700 I/BUSACTD ( 2501): busact.c: busact_method_control_unit(158) > Controlling(StartUnit) unit(debug-launchpad.service) with mode(no-block)
09-17 11:28:29.531-0700 I/BUSACTD ( 2501): busact.c: busact_method_control_unit(170) > Successed to control unit: method(StartUnit), unit(debug-launchpad.service), mode(no-block)
09-17 11:28:29.581-0700 D/bitcoinwatch( 5907): 0
09-17 11:28:29.711-0700 I/CAPI_NETWORK_CONNECTION( 5907): connection.c: connection_create(453) > New handle created[0xf792bac0]
09-17 11:28:29.901-0700 I/CAPI_NETWORK_CONNECTION( 5907): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:30.091-0700 D/bitcoinwatch( 5907): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:30.091-0700 D/bitcoinwatch( 5907): Size: 3
09-17 11:28:30.091-0700 D/bitcoinwatch( 5907): Rate: 3731.85
09-17 11:28:30.091-0700 E/bitcoinwatch( 5907): updated bitcoin
09-17 11:28:30.091-0700 I/CAPI_NETWORK_CONNECTION( 5907): connection.c: connection_create(453) > New handle created[0xf7932368]
09-17 11:28:30.141-0700 I/CAPI_NETWORK_CONNECTION( 5907): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:30.201-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11053726269741505672197
09-17 11:28:30.201-0700 D/bitcoinwatch( 5907): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:30.201-0700 D/bitcoinwatch( 5907): Size: 3
09-17 11:28:30.201-0700 D/bitcoinwatch( 5907): Rate: 3731.85
09-17 11:28:30.201-0700 E/bitcoinwatch( 5907): updated bitcoin
09-17 11:28:30.201-0700 W/WATCH_CORE( 5907): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:28:30.231-0700 E/WIDGET_PROVIDER_APP( 5907): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:28:30.261-0700 I/WATCH_CORE( 5907): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:28:30.261-0700 I/WATCH_CORE( 5907): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:28:30.261-0700 I/WATCH_CORE( 5907): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:28:30.261-0700 I/WATCH_CORE( 5907): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:28:30.311-0700 W/W_HOME  ( 2907): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
09-17 11:28:30.311-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:30.311-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:30.311-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:30.311-0700 W/W_HOME  ( 2907): win.c: win_back_gesture_disable_set(173) > enable back gesture
09-17 11:28:30.311-0700 W/W_HOME  ( 2907): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
09-17 11:28:30.311-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:28:30.311-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:28:30.331-0700 W/PROCESSMGR( 2371): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
09-17 11:28:30.331-0700 W/W_HOME  ( 2907): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
09-17 11:28:30.331-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:30.331-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:30.331-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:30.331-0700 W/W_HOME  ( 2907): win.c: win_back_gesture_disable_set(170) > disable back gesture
09-17 11:28:30.331-0700 W/W_HOME  ( 2907): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
09-17 11:28:30.341-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:28:30.341-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:28:30.381-0700 W/WATCH_CORE( 5907): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
09-17 11:28:30.381-0700 I/WATCH_CORE( 5907): appcore-watch.c: __signal_process_manager_handler(1273) > Skip the background tick update
09-17 11:28:30.401-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:28:30.401-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:28:30.471-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:28:30.481-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5907
09-17 11:28:30.481-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:28:30.731-0700 I/AUL_PAD ( 5967): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:28:31.651-0700 E/CAPI_SYSTEM_INFO( 5946): system_info_parse.c: system_info_get_value_from_config_xml(279) > cannot find tizen.org/feature/container field from /etc/config/model-config.xml file!!!
09-17 11:28:31.651-0700 E/CAPI_SYSTEM_INFO( 5946): system_info.c: system_info_get_platform_bool(293) > cannot get tizen.org/feature/container
09-17 11:28:33.411-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(5907)
09-17 11:28:33.411-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 5907 pgid = 5907
09-17 11:28:33.411-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:28:33.421-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:28:33.421-0700 E/AUL_AMD ( 2557): amd_request.c: __app_process_by_pid(201) > pid(5907) is dead. cmd(4) is canceled
09-17 11:28:33.421-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-3)
09-17 11:28:33.421-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:28:33.421-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:28:33.431-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:33.451-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:33.451-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:28:33.451-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:28:33.471-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:28:33.481-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:28:33.501-0700 W/SHealthService( 3630): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
09-17 11:28:33.521-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:28:33.521-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:28:33.521-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:28:33.521-0700 W/AUL_PAD ( 5967): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:28:33.521-0700 W/AUL_PAD ( 5967): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:28:33.521-0700 W/AUL_PAD ( 5967): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:28:33.521-0700 W/AUL_PAD ( 5967): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:28:33.561-0700 W/AUL_PAD ( 5967): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:28:33.561-0700 W/AUL_PAD ( 5967): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:28:33.561-0700 I/CAPI_WATCH_APPLICATION( 5967): watch_app_main.c: watch_app_main(399) > watch_app_main
09-17 11:28:33.601-0700 W/SHealthService( 3630): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
09-17 11:28:33.611-0700 W/SHealthService( 3630): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
09-17 11:28:33.621-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.bitcoinwatch) pid(5967) type(watchapp) bg(0)
09-17 11:28:33.621-0700 W/AUL_AMD ( 2557): amd_status.c: __socket_monitor_cb(1277) > (5967) was created
09-17 11:28:33.621-0700 E/AUL     ( 2557): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-17 11:28:33.621-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5907
09-17 11:28:33.621-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5907)
09-17 11:28:33.621-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5967)
09-17 11:28:33.621-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5967]
09-17 11:28:33.681-0700 W/WATCH_CORE( 5967): appcore-watch.c: __widget_create(1068) > widget_create
09-17 11:28:33.681-0700 I/CAPI_WATCH_APPLICATION( 5967): watch_app_main.c: watch_app_get_elm_win(663) > watch hwc mode is enabled
09-17 11:28:33.801-0700 D/bitcoinwatch( 5967): 0
09-17 11:28:33.901-0700 I/CAPI_NETWORK_CONNECTION( 5967): connection.c: connection_create(453) > New handle created[0xf7acb270]
09-17 11:28:33.971-0700 I/CAPI_NETWORK_CONNECTION( 5967): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:34.041-0700 D/bitcoinwatch( 5967): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:34.041-0700 D/bitcoinwatch( 5967): Size: 3
09-17 11:28:34.041-0700 D/bitcoinwatch( 5967): Rate: 3731.85
09-17 11:28:34.041-0700 E/bitcoinwatch( 5967): updated bitcoin
09-17 11:28:34.061-0700 I/CAPI_NETWORK_CONNECTION( 5967): connection.c: connection_create(453) > New handle created[0xf7a86000]
09-17 11:28:34.131-0700 I/CAPI_NETWORK_CONNECTION( 5967): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:34.221-0700 D/bitcoinwatch( 5967): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:34.221-0700 D/bitcoinwatch( 5967): Size: 3
09-17 11:28:34.221-0700 D/bitcoinwatch( 5967): Rate: 3731.85
09-17 11:28:34.221-0700 E/bitcoinwatch( 5967): updated bitcoin
09-17 11:28:34.231-0700 W/WATCH_CORE( 5967): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:28:34.261-0700 E/WIDGET_PROVIDER_APP( 5967): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:28:34.301-0700 I/WATCH_CORE( 5967): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:28:34.301-0700 I/WATCH_CORE( 5967): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:28:34.301-0700 I/WATCH_CORE( 5967): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:28:34.301-0700 I/WATCH_CORE( 5967): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:28:34.401-0700 W/W_HOME  ( 2907): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
09-17 11:28:34.401-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:34.401-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:34.401-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:34.401-0700 W/W_HOME  ( 2907): win.c: win_back_gesture_disable_set(173) > enable back gesture
09-17 11:28:34.401-0700 W/W_HOME  ( 2907): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
09-17 11:28:34.401-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:28:34.401-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:28:34.421-0700 W/PROCESSMGR( 2371): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
09-17 11:28:34.421-0700 W/W_HOME  ( 2907): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
09-17 11:28:34.421-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:34.421-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:34.421-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:34.421-0700 W/W_HOME  ( 2907): win.c: win_back_gesture_disable_set(170) > disable back gesture
09-17 11:28:34.421-0700 W/W_HOME  ( 2907): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
09-17 11:28:34.441-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:28:34.461-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:28:34.491-0700 W/WATCH_CORE( 5967): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
09-17 11:28:34.491-0700 I/WATCH_CORE( 5967): appcore-watch.c: __signal_process_manager_handler(1273) > Skip the background tick update
09-17 11:28:34.621-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:28:34.621-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:28:34.741-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:28:34.751-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5967
09-17 11:28:34.761-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:28:34.971-0700 E/WMS     ( 2513): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23476) > _wms_event_handler_cb_nomove_detector is called
09-17 11:28:35.021-0700 I/AUL_PAD ( 6060): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:28:37.401-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(5967)
09-17 11:28:37.401-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:28:37.401-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(org.example.bitcoinwatch) pid(5967) type(watchapp)
09-17 11:28:37.401-0700 E/AUL     ( 2557): app_sock.c: __connect_client_sock(196) > connect error: 111
09-17 11:28:37.401-0700 E/AUL     ( 2557): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-17 11:28:37.401-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 5967 pgid = 5967
09-17 11:28:37.401-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:28:37.411-0700 E/RESOURCED( 2702): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/5967/oom_score_adj failed
09-17 11:28:37.411-0700 E/RESOURCED( 2702): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 5967
09-17 11:28:37.491-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:28:37.501-0700 E/AUL     ( 2557): app_sock.c: __connect_client_sock(196) > connect error: 111
09-17 11:28:37.501-0700 E/AUL     ( 2557): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-17 11:28:37.801-0700 E/AUL     ( 2557): app_sock.c: __connect_client_sock(196) > connect error: 111
09-17 11:28:37.801-0700 E/AUL     ( 2557): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-17 11:28:37.801-0700 E/AUL_AMD ( 2557): amd_launch.c: _term_app(1106) > fail to killing - 5967
09-17 11:28:37.801-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5967
09-17 11:28:37.801-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5967)
09-17 11:28:37.801-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-1)
09-17 11:28:37.801-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:28:37.801-0700 E/RESOURCED( 2702): proc-main.c: proc_app_list_remove_app_info(669) > Failed to remove appinfo 'org.example.bitcoinwatch': Not a directory
09-17 11:28:37.801-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:28:37.811-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:37.821-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:37.821-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:28:37.821-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:28:37.831-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:28:37.841-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:28:37.841-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:28:37.841-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:28:37.841-0700 W/AUL_PAD ( 6060): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:28:37.841-0700 W/AUL_PAD ( 6060): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:28:37.841-0700 W/AUL_PAD ( 6060): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:28:37.841-0700 W/AUL_PAD ( 6060): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:28:37.861-0700 W/AUL_PAD ( 6060): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:28:37.861-0700 W/AUL_PAD ( 6060): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:28:37.861-0700 I/CAPI_WATCH_APPLICATION( 6060): watch_app_main.c: watch_app_main(399) > watch_app_main
09-17 11:28:37.941-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.bitcoinwatch) pid(6060) type(watchapp) bg(0)
09-17 11:28:37.941-0700 W/AUL_AMD ( 2557): amd_status.c: __socket_monitor_cb(1277) > (6060) was created
09-17 11:28:37.941-0700 E/AUL     ( 2557): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-17 11:28:37.941-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6060)
09-17 11:28:37.941-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6060]
09-17 11:28:37.991-0700 W/WATCH_CORE( 6060): appcore-watch.c: __widget_create(1068) > widget_create
09-17 11:28:37.991-0700 I/CAPI_WATCH_APPLICATION( 6060): watch_app_main.c: watch_app_get_elm_win(663) > watch hwc mode is enabled
09-17 11:28:38.101-0700 D/bitcoinwatch( 6060): 0
09-17 11:28:38.211-0700 I/CAPI_NETWORK_CONNECTION( 6060): connection.c: connection_create(453) > New handle created[0xf2d039c8]
09-17 11:28:38.331-0700 I/CAPI_NETWORK_CONNECTION( 6060): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:38.401-0700 D/bitcoinwatch( 6060): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:38.401-0700 D/bitcoinwatch( 6060): Size: 3
09-17 11:28:38.401-0700 D/bitcoinwatch( 6060): Rate: 3731.85
09-17 11:28:38.401-0700 E/bitcoinwatch( 6060): updated bitcoin
09-17 11:28:38.411-0700 I/CAPI_NETWORK_CONNECTION( 6060): connection.c: connection_create(453) > New handle created[0xf7cf68d8]
09-17 11:28:38.451-0700 I/CAPI_NETWORK_CONNECTION( 6060): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:38.511-0700 D/bitcoinwatch( 6060): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:38.511-0700 D/bitcoinwatch( 6060): Size: 3
09-17 11:28:38.511-0700 D/bitcoinwatch( 6060): Rate: 3731.85
09-17 11:28:38.511-0700 E/bitcoinwatch( 6060): updated bitcoin
09-17 11:28:38.511-0700 W/WATCH_CORE( 6060): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:28:38.551-0700 I/TDM     ( 2006): tdm_display.c: tdm_layer_unset_buffer(1602) > [359.200221] layer(0x503338) now usable
09-17 11:28:38.551-0700 I/TDM     ( 2006): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [359.200250] layer[0x502f58]zpos[2]
09-17 11:28:38.551-0700 I/TDM     ( 2006): tdm_display.c: tdm_layer_unset_buffer(1602) > [359.200275] layer(0x5032e8) now usable
09-17 11:28:38.551-0700 I/TDM     ( 2006): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [359.200286] layer[0x502e38]zpos[1]
09-17 11:28:38.551-0700 I/TDM     ( 2006): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [359.200301] dpms[0 -> 3]sync[1]
09-17 11:28:38.551-0700 I/TDM     ( 2006): 
09-17 11:28:38.551-0700 W/WAKEUP-SERVICE( 3580): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -148096244[0;m
09-17 11:28:38.551-0700 W/WAKEUP-SERVICE( 3580): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
09-17 11:28:38.551-0700 W/WAKEUP-SERVICE( 3580): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
09-17 11:28:38.561-0700 E/WAKEUP-SERVICE( 3580): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
09-17 11:28:38.561-0700 W/W_HOME  ( 2907): dbus.c: _dbus_message_recv_cb(204) > LCD off
09-17 11:28:38.561-0700 W/W_HOME  ( 2907): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
09-17 11:28:38.561-0700 W/W_HOME  ( 2907): gesture.c: _manual_render_disable_timer_del(157) > timer del
09-17 11:28:38.561-0700 W/W_HOME  ( 2907): gesture.c: _manual_render_enable(138) > 1
09-17 11:28:38.561-0700 W/W_HOME  ( 2907): event_manager.c: _lcd_off_cb(729) > lcd state: 0
09-17 11:28:38.561-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:38.561-0700 W/STARTER ( 2758): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
09-17 11:28:38.561-0700 W/STARTER ( 2758): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
09-17 11:28:38.561-0700 E/STARTER ( 2758): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
09-17 11:28:38.561-0700 E/STARTER ( 2758): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
09-17 11:28:38.561-0700 W/STARTER ( 2758): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
09-17 11:28:38.561-0700 W/STARTER ( 2758): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
09-17 11:28:38.561-0700 E/WAKEUP-SERVICE( 3580): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
09-17 11:28:38.561-0700 E/WAKEUP-SERVICE( 3580): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
09-17 11:28:38.561-0700 I/TIZEN_N_SOUND_MANAGER( 3580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
09-17 11:28:38.571-0700 I/TIZEN_N_SOUND_MANAGER( 3580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
09-17 11:28:38.571-0700 W/TIZEN_N_SOUND_MANAGER( 3580): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
09-17 11:28:38.571-0700 W/WAKEUP-SERVICE( 3580): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
09-17 11:28:38.571-0700 I/HIGEAR  ( 3580): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
09-17 11:28:38.581-0700 E/WIDGET_PROVIDER_APP( 6060): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:28:38.591-0700 I/WATCH_CORE( 6060): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:28:38.591-0700 I/WATCH_CORE( 6060): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:28:38.591-0700 I/WATCH_CORE( 6060): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:28:38.591-0700 I/WATCH_CORE( 6060): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:28:38.611-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 1105396626974150567230
