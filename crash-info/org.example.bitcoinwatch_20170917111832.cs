S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.3
Build-Number: R765VVRU1AQF4
Build-Date: 2017.07.17 17:00:49

Crash Information
Process Name: bitcoinwatch
PID: 5430
Date: 2017-09-17 11:18:32-0700
Executable File Path: /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x4071bdc6
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6e4b9b8, r5   = 0xf6e4b9b8
r6   = 0xf6e4b16c, r7   = 0xf6e4b9b8
r8   = 0xf6e4b9b8, r9   = 0xf76caff8
r10  = 0xf6e59b10, fp   = 0x0000018f
ip   = 0x00000001, sp   = 0xffc275e0
lr   = 0xf6e3b1f9, pc   = 0x00000000
cpsr = 0x60000030

Memory Information
MemTotal:   620380 KB
MemFree:     16008 KB
Buffers:     15408 KB
Cached:     146220 KB
VmPeak:      77568 KB
VmSize:      77568 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23776 KB
VmRSS:       23776 KB
VmData:      21252 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       21132 KB
VmPTE:         120 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5430 TID = 5430
5430 5448 5454 

Maps Information
f2ab0000 f32af000 rw-p [stack:5454]
f334c000 f3363000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3370000 f337b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3384000 f338f000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f3398000 f3b97000 rw-p [stack:5448]
f3d97000 f3da7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f3daf000 f3dba000 r-xp /usr/lib/libtbm.so.1.0.0
f3dc2000 f3e0b000 r-xp /usr/lib/libmdm.so.1.2.69
f3e13000 f3e19000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f3e21000 f3e23000 r-xp /usr/lib/libdri2.so.0.0.0
f3e2b000 f3e33000 r-xp /usr/lib/libdrm.so.2.4.0
f3e3b000 f3e4b000 r-xp /usr/lib/libwidget_provider.so.1.0.0
f3e53000 f3e5c000 r-xp /usr/lib/libcom-core.so.0.0.1
f56fe000 f5703000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f570b000 f5724000 r-xp /usr/lib/libnetwork.so.0.0.0
f572c000 f5736000 r-xp /usr/lib/libwidget.so.1.0.0
f573e000 f5751000 r-xp /usr/lib/libwidget_service.so.1.0.0
f575a000 f5761000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
f576a000 f5870000 r-xp /usr/lib/libicuuc.so.57.1
f5886000 f5a0e000 r-xp /usr/lib/libicui18n.so.57.1
f5a1e000 f5a2b000 r-xp /usr/lib/libalarm.so.0.0.0
f5a35000 f5a44000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f5a4d000 f5a5d000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f5a65000 f5a6d000 r-xp /usr/lib/libappcore-watch.so.1.1
f5a7f000 f5a84000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f5c1e000 f5c28000 r-xp /lib/libnss_files-2.13.so
f5c31000 f5d00000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5d16000 f5d3a000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5d43000 f5d49000 r-xp /usr/lib/libappsvc.so.0.1.0
f5d51000 f5d55000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5d63000 f5d65000 r-xp /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
f5d75000 f5d77000 r-xp /usr/lib/libiniparser.so.0
f5d80000 f5d85000 r-xp /usr/lib/libappcore-common.so.1.1
f5d8d000 f5d8f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5d98000 f5d9c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5da9000 f5dab000 r-xp /usr/lib/libXau.so.6.0.0
f5db3000 f5dba000 r-xp /lib/libcrypt-2.13.so
f5dea000 f5dec000 r-xp /usr/lib/libiri.so
f5df5000 f5f9e000 r-xp /usr/lib/libcrypto.so.1.0.0
f5fbe000 f6005000 r-xp /usr/lib/libssl.so.1.0.0
f6011000 f603f000 r-xp /usr/lib/libidn.so.11.5.44
f6047000 f6050000 r-xp /usr/lib/libcares.so.2.1.0
f605a000 f606d000 r-xp /usr/lib/libxcb.so.1.1.0
f6076000 f6078000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6080000 f6082000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f608b000 f6157000 r-xp /usr/lib/libxml2.so.2.7.8
f6164000 f6166000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f616f000 f6174000 r-xp /usr/lib/libffi.so.5.0.10
f617c000 f617d000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6185000 f6188000 r-xp /lib/libattr.so.1.1.0
f6190000 f6224000 r-xp /usr/lib/libstdc++.so.6.0.16
f6237000 f6254000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f625e000 f6276000 r-xp /usr/lib/libpng12.so.0.50.0
f627e000 f6294000 r-xp /lib/libexpat.so.1.6.0
f629e000 f62e2000 r-xp /usr/lib/libcurl.so.4.3.0
f62eb000 f62f5000 r-xp /usr/lib/libXext.so.6.4.0
f62fe000 f6302000 r-xp /usr/lib/libXtst.so.6.1.0
f630a000 f6310000 r-xp /usr/lib/libXrender.so.1.3.0
f6318000 f631e000 r-xp /usr/lib/libXrandr.so.2.2.0
f6326000 f6327000 r-xp /usr/lib/libXinerama.so.1.0.0
f6330000 f6339000 r-xp /usr/lib/libXi.so.6.1.0
f6341000 f6344000 r-xp /usr/lib/libXfixes.so.3.1.0
f634c000 f634e000 r-xp /usr/lib/libXgesture.so.7.0.0
f6356000 f6358000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6360000 f6362000 r-xp /usr/lib/libXdamage.so.1.1.0
f636a000 f6371000 r-xp /usr/lib/libXcursor.so.1.0.2
f6379000 f637c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f6384000 f6388000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6391000 f6396000 r-xp /usr/lib/libecore_fb.so.1.7.99
f639f000 f6480000 r-xp /usr/lib/libX11.so.6.3.0
f648b000 f64ae000 r-xp /usr/lib/libjpeg.so.8.0.2
f64c6000 f64dc000 r-xp /lib/libz.so.1.2.5
f64e4000 f64e6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f64ee000 f6563000 r-xp /usr/lib/libsqlite3.so.0.8.6
f656d000 f6587000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f658f000 f65c3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f65cc000 f669f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f66aa000 f66ba000 r-xp /lib/libresolv-2.13.so
f66be000 f66d6000 r-xp /usr/lib/liblzma.so.5.0.3
f66de000 f66e1000 r-xp /lib/libcap.so.2.21
f66e9000 f6718000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6721000 f6722000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f672a000 f6730000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6738000 f674f000 r-xp /usr/lib/liblua-5.1.so
f6758000 f675f000 r-xp /usr/lib/libembryo.so.1.7.99
f6767000 f676d000 r-xp /lib/librt-2.13.so
f6776000 f67cc000 r-xp /usr/lib/libpixman-1.so.0.28.2
f67d9000 f682f000 r-xp /usr/lib/libfreetype.so.6.11.3
f683b000 f6863000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6864000 f68a9000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f68b2000 f68c5000 r-xp /usr/lib/libfribidi.so.0.3.1
f68cd000 f68e7000 r-xp /usr/lib/libecore_con.so.1.7.99
f68f0000 f68f9000 r-xp /usr/lib/libedbus.so.1.7.99
f6901000 f6951000 r-xp /usr/lib/libecore_x.so.1.7.99
f6953000 f695c000 r-xp /usr/lib/libvconf.so.0.2.45
f6964000 f6975000 r-xp /usr/lib/libecore_input.so.1.7.99
f697d000 f6982000 r-xp /usr/lib/libecore_file.so.1.7.99
f698a000 f69ac000 r-xp /usr/lib/libecore_evas.so.1.7.99
f69b5000 f69f6000 r-xp /usr/lib/libeina.so.1.7.99
f69ff000 f6a18000 r-xp /usr/lib/libeet.so.1.7.99
f6a29000 f6a92000 r-xp /lib/libm-2.13.so
f6a9b000 f6aa1000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6aaa000 f6aab000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ab3000 f6ad6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ade000 f6ae3000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6aeb000 f6b15000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b1e000 f6b35000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b3d000 f6b48000 r-xp /lib/libunwind.so.8.0.1
f6b75000 f6b93000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b9d000 f6cc1000 r-xp /lib/libc-2.13.so
f6ccf000 f6cd7000 r-xp /lib/libgcc_s-4.6.so.1
f6cd8000 f6cdc000 r-xp /usr/lib/libsmack.so.1.0.0
f6ce5000 f6ceb000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6cf3000 f6dc3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dc4000 f6e22000 r-xp /usr/lib/libedje.so.1.7.99
f6e2c000 f6e43000 r-xp /usr/lib/libecore.so.1.7.99
f6e5a000 f6f28000 r-xp /usr/lib/libevas.so.1.7.99
f6f4d000 f7089000 r-xp /usr/lib/libelementary.so.1.7.99
f70a0000 f70b4000 r-xp /lib/libpthread-2.13.so
f70bf000 f70c1000 r-xp /usr/lib/libdlog.so.0.0.0
f70c9000 f70cc000 r-xp /usr/lib/libbundle.so.0.1.22
f70d4000 f70d6000 r-xp /lib/libdl-2.13.so
f70df000 f70ec000 r-xp /usr/lib/libaul.so.0.1.0
f70fe000 f7104000 r-xp /usr/lib/libappcore-efl.so.1.1
f710d000 f7111000 r-xp /usr/lib/libsys-assert.so
f711a000 f7137000 r-xp /lib/ld-2.13.so
f7140000 f7145000 r-xp /usr/bin/launchpad-loader
f7693000 f7863000 rw-p [heap]
ffc08000 ffc29000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5430)
Call Stack Count: 2
 0: (0xf6e3b1f9) [/usr/lib/libecore.so.1] + 0xf1f9
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
app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
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
09-17 11:28:38.611-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11053966269741505672307
09-17 11:28:38.681-0700 I/TDM     ( 2006): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [359.330938] dpms[3 -> 3]done
09-17 11:28:38.681-0700 I/TDM     ( 2006): 
09-17 11:28:38.681-0700 W/W_INDICATOR( 2759): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
09-17 11:28:38.681-0700 W/SHealthCommon( 3630): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
09-17 11:28:38.681-0700 W/SHealthService( 3630): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
09-17 11:28:38.701-0700 W/STARTER ( 2758): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
09-17 11:28:38.701-0700 W/STARTER ( 2758): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
09-17 11:28:38.701-0700 W/STARTER ( 2758): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
09-17 11:28:38.701-0700 W/STARTER ( 2758): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
09-17 11:28:38.701-0700 E/ALARM_MANAGER( 2758): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(17-9-2017, 11:28:59), repeat(1), interval(20), type(-1073741822)
09-17 11:28:38.701-0700 W/W_HOME  ( 2907): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
09-17 11:28:38.701-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:38.701-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:38.701-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:38.701-0700 W/W_HOME  ( 2907): win.c: win_back_gesture_disable_set(173) > enable back gesture
09-17 11:28:38.701-0700 W/W_HOME  ( 2907): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
09-17 11:28:38.711-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2758].
09-17 11:28:38.711-0700 W/PROCESSMGR( 2371): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
09-17 11:28:38.721-0700 W/W_HOME  ( 2907): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
09-17 11:28:38.721-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:38.721-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:38.721-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:38.721-0700 W/W_HOME  ( 2907): win.c: win_back_gesture_disable_set(170) > disable back gesture
09-17 11:28:38.721-0700 W/W_HOME  ( 2907): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
09-17 11:28:38.721-0700 I/APP_CORE( 2907): appcore-efl.c: __do_app(453) > [APP 2907] Event: PAUSE State: RUNNING
09-17 11:28:38.721-0700 I/CAPI_APPFW_APPLICATION( 2907): app_main.c: app_appcore_pause(202) > app_appcore_pause
09-17 11:28:38.721-0700 W/W_HOME  ( 2907): main.c: _appcore_pause_cb(488) > appcore pause
09-17 11:28:38.721-0700 W/W_HOME  ( 2907): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
09-17 11:28:38.721-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:38.721-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:38.721-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:38.721-0700 W/W_HOME  ( 2907): rotary.c: rotary_deattach(156) > rotary_deattach:0xf826b998
09-17 11:28:38.721-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
09-17 11:28:38.721-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf826b998, elm_layout, func : 0xf75fb68d
09-17 11:28:38.721-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
09-17 11:28:38.721-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
09-17 11:28:38.721-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
09-17 11:28:38.721-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf819d660, elm_box, _activated_obj : 0xf826b998, activated : 1
09-17 11:28:38.721-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-17 11:28:38.721-0700 E/wnotib  ( 2907): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
09-17 11:28:38.721-0700 I/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_is_key_event_passed(5857) > Return true for 6079, 11244.
09-17 11:28:38.721-0700 I/wnotib  ( 2907): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
09-17 11:28:38.731-0700 W/W_HOME  ( 2907): win.c: win_back_gesture_disable_set(173) > enable back gesture
09-17 11:28:38.731-0700 I/MESSAGE_PORT( 2503): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-17 11:28:38.731-0700 I/MESSAGE_PORT( 2503): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-17 11:28:38.731-0700 I/MESSAGE_PORT( 2503): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-17 11:28:38.731-0700 I/MESSAGE_PORT( 2503): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-17 11:28:38.731-0700 I/MESSAGE_PORT( 2503): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-17 11:28:38.731-0700 I/MESSAGE_PORT( 2503): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-17 11:28:38.731-0700 I/MESSAGE_PORT( 2503): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-17 11:28:38.731-0700 I/MESSAGE_PORT( 2503): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-17 11:28:38.741-0700 I/MESSAGE_PORT( 2503): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-17 11:28:38.741-0700 I/MESSAGE_PORT( 2503): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-17 11:28:38.741-0700 I/MESSAGE_PORT( 2503): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-17 11:28:38.741-0700 I/MESSAGE_PORT( 2503): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
09-17 11:28:38.741-0700 I/MESSAGE_PORT( 2503): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
09-17 11:28:38.741-0700 I/MESSAGE_PORT( 2503): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-17 11:28:38.741-0700 I/MESSAGE_PORT( 2503): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
09-17 11:28:38.741-0700 I/MESSAGE_PORT( 2503): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
09-17 11:28:38.741-0700 I/MESSAGE_PORT( 2503): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
09-17 11:28:38.741-0700 I/MESSAGE_PORT( 2503): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-17 11:28:38.741-0700 E/CAPI_APPFW_APP_CONTROL( 3308): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
09-17 11:28:38.741-0700 E/ALARM_MANAGER( 2514): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 89245482, next duetime: 1505672939
09-17 11:28:38.741-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(89245482)
09-17 11:28:38.741-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1505673452), due_time(1505672939)
09-17 11:28:38.751-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-17 11:28:38.751-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-17 11:28:38.751-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 17-9-2017, 18:28:59 (UTC).
09-17 11:28:38.751-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-17 11:28:38.751-0700 W/MUSIC_CONTROL_SERVICE( 3308): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3308]   [com.samsung.w-home]register msg port [false][0m
09-17 11:28:38.761-0700 W/APPS    ( 2907): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
09-17 11:28:38.761-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-17 11:28:38.791-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:28:38.791-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:28:38.791-0700 W/W_INDICATOR( 2759): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
09-17 11:28:38.791-0700 W/W_INDICATOR( 2759): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
09-17 11:28:38.791-0700 W/W_INDICATOR( 2759): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
09-17 11:28:38.841-0700 W/WATCH_CORE( 6060): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
09-17 11:28:38.841-0700 I/WATCH_CORE( 6060): appcore-watch.c: __signal_process_manager_handler(1273) > Skip the background tick update
09-17 11:28:38.941-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:28:38.941-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:28:39.021-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:28:39.021-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6060
09-17 11:28:39.031-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:28:39.201-0700 I/AUL_PAD ( 6114): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:28:39.241-0700 I/APP_CORE( 2907): appcore-efl.c: __do_app(453) > [APP 2907] Event: MEM_FLUSH State: PAUSED
09-17 11:28:39.961-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 1105430626974150567231
