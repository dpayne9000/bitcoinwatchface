S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.3
Build-Number: R765VVRU1AQF4
Build-Date: 2017.07.17 17:00:49

Crash Information
Process Name: bitcoinwatch
PID: 5731
Date: 2017-09-17 11:28:07-0700
Executable File Path: /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x40747e3e
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71019b8, r5   = 0xf71019b8
r6   = 0xf710116c, r7   = 0xf71019b8
r8   = 0xf71019b8, r9   = 0xf788cff8
r10  = 0xf710fb10, fp   = 0x0000018f
ip   = 0x00000001, sp   = 0xff839230
lr   = 0xf70f11f9, pc   = 0x00000000
cpsr = 0x60000030

Memory Information
MemTotal:   620380 KB
MemFree:     39056 KB
Buffers:     17716 KB
Cached:     141364 KB
VmPeak:      77944 KB
VmSize:      77944 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24108 KB
VmRSS:       24108 KB
VmData:      21120 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       21132 KB
VmPTE:         116 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5731 TID = 5731
5731 5748 5754 

Maps Information
f2d66000 f3565000 rw-p [stack:5754]
f3602000 f3619000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3626000 f3631000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f363a000 f3645000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f364e000 f3e4d000 rw-p [stack:5748]
f404d000 f405d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4065000 f4070000 r-xp /usr/lib/libtbm.so.1.0.0
f4078000 f40c1000 r-xp /usr/lib/libmdm.so.1.2.69
f40c9000 f40cf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f40d7000 f40d9000 r-xp /usr/lib/libdri2.so.0.0.0
f40e1000 f40e9000 r-xp /usr/lib/libdrm.so.2.4.0
f40f1000 f4101000 r-xp /usr/lib/libwidget_provider.so.1.0.0
f4109000 f4112000 r-xp /usr/lib/libcom-core.so.0.0.1
f59b4000 f59b9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f59c1000 f59da000 r-xp /usr/lib/libnetwork.so.0.0.0
f59e2000 f59ec000 r-xp /usr/lib/libwidget.so.1.0.0
f59f4000 f5a07000 r-xp /usr/lib/libwidget_service.so.1.0.0
f5a10000 f5a17000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
f5a20000 f5b26000 r-xp /usr/lib/libicuuc.so.57.1
f5b3c000 f5cc4000 r-xp /usr/lib/libicui18n.so.57.1
f5cd4000 f5ce1000 r-xp /usr/lib/libalarm.so.0.0.0
f5ceb000 f5cfa000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f5d03000 f5d13000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f5d1b000 f5d23000 r-xp /usr/lib/libappcore-watch.so.1.1
f5d35000 f5d3a000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f5ed4000 f5ede000 r-xp /lib/libnss_files-2.13.so
f5ee7000 f5fb6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5fcc000 f5ff0000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5ff9000 f5fff000 r-xp /usr/lib/libappsvc.so.0.1.0
f6007000 f600b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6019000 f601b000 r-xp /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
f602b000 f602d000 r-xp /usr/lib/libiniparser.so.0
f6036000 f603b000 r-xp /usr/lib/libappcore-common.so.1.1
f6043000 f6045000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f604e000 f6052000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f605f000 f6061000 r-xp /usr/lib/libXau.so.6.0.0
f6069000 f6070000 r-xp /lib/libcrypt-2.13.so
f60a0000 f60a2000 r-xp /usr/lib/libiri.so
f60ab000 f6254000 r-xp /usr/lib/libcrypto.so.1.0.0
f6274000 f62bb000 r-xp /usr/lib/libssl.so.1.0.0
f62c7000 f62f5000 r-xp /usr/lib/libidn.so.11.5.44
f62fd000 f6306000 r-xp /usr/lib/libcares.so.2.1.0
f6310000 f6323000 r-xp /usr/lib/libxcb.so.1.1.0
f632c000 f632e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6336000 f6338000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6341000 f640d000 r-xp /usr/lib/libxml2.so.2.7.8
f641a000 f641c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6425000 f642a000 r-xp /usr/lib/libffi.so.5.0.10
f6432000 f6433000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f643b000 f643e000 r-xp /lib/libattr.so.1.1.0
f6446000 f64da000 r-xp /usr/lib/libstdc++.so.6.0.16
f64ed000 f650a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6514000 f652c000 r-xp /usr/lib/libpng12.so.0.50.0
f6534000 f654a000 r-xp /lib/libexpat.so.1.6.0
f6554000 f6598000 r-xp /usr/lib/libcurl.so.4.3.0
f65a1000 f65ab000 r-xp /usr/lib/libXext.so.6.4.0
f65b4000 f65b8000 r-xp /usr/lib/libXtst.so.6.1.0
f65c0000 f65c6000 r-xp /usr/lib/libXrender.so.1.3.0
f65ce000 f65d4000 r-xp /usr/lib/libXrandr.so.2.2.0
f65dc000 f65dd000 r-xp /usr/lib/libXinerama.so.1.0.0
f65e6000 f65ef000 r-xp /usr/lib/libXi.so.6.1.0
f65f7000 f65fa000 r-xp /usr/lib/libXfixes.so.3.1.0
f6602000 f6604000 r-xp /usr/lib/libXgesture.so.7.0.0
f660c000 f660e000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6616000 f6618000 r-xp /usr/lib/libXdamage.so.1.1.0
f6620000 f6627000 r-xp /usr/lib/libXcursor.so.1.0.2
f662f000 f6632000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f663a000 f663e000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6647000 f664c000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6655000 f6736000 r-xp /usr/lib/libX11.so.6.3.0
f6741000 f6764000 r-xp /usr/lib/libjpeg.so.8.0.2
f677c000 f6792000 r-xp /lib/libz.so.1.2.5
f679a000 f679c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67a4000 f6819000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6823000 f683d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6845000 f6879000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6882000 f6955000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6960000 f6970000 r-xp /lib/libresolv-2.13.so
f6974000 f698c000 r-xp /usr/lib/liblzma.so.5.0.3
f6994000 f6997000 r-xp /lib/libcap.so.2.21
f699f000 f69ce000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69d7000 f69d8000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f69e0000 f69e6000 r-xp /usr/lib/libecore_imf.so.1.7.99
f69ee000 f6a05000 r-xp /usr/lib/liblua-5.1.so
f6a0e000 f6a15000 r-xp /usr/lib/libembryo.so.1.7.99
f6a1d000 f6a23000 r-xp /lib/librt-2.13.so
f6a2c000 f6a82000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6a8f000 f6ae5000 r-xp /usr/lib/libfreetype.so.6.11.3
f6af1000 f6b19000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6b1a000 f6b5f000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6b68000 f6b7b000 r-xp /usr/lib/libfribidi.so.0.3.1
f6b83000 f6b9d000 r-xp /usr/lib/libecore_con.so.1.7.99
f6ba6000 f6baf000 r-xp /usr/lib/libedbus.so.1.7.99
f6bb7000 f6c07000 r-xp /usr/lib/libecore_x.so.1.7.99
f6c09000 f6c12000 r-xp /usr/lib/libvconf.so.0.2.45
f6c1a000 f6c2b000 r-xp /usr/lib/libecore_input.so.1.7.99
f6c33000 f6c38000 r-xp /usr/lib/libecore_file.so.1.7.99
f6c40000 f6c62000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6c6b000 f6cac000 r-xp /usr/lib/libeina.so.1.7.99
f6cb5000 f6cce000 r-xp /usr/lib/libeet.so.1.7.99
f6cdf000 f6d48000 r-xp /lib/libm-2.13.so
f6d51000 f6d57000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d60000 f6d61000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d69000 f6d8c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d94000 f6d99000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6da1000 f6dcb000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6dd4000 f6deb000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6df3000 f6dfe000 r-xp /lib/libunwind.so.8.0.1
f6e2b000 f6e49000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e53000 f6f77000 r-xp /lib/libc-2.13.so
f6f85000 f6f8d000 r-xp /lib/libgcc_s-4.6.so.1
f6f8e000 f6f92000 r-xp /usr/lib/libsmack.so.1.0.0
f6f9b000 f6fa1000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6fa9000 f7079000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f707a000 f70d8000 r-xp /usr/lib/libedje.so.1.7.99
f70e2000 f70f9000 r-xp /usr/lib/libecore.so.1.7.99
f7110000 f71de000 r-xp /usr/lib/libevas.so.1.7.99
f7203000 f733f000 r-xp /usr/lib/libelementary.so.1.7.99
f7356000 f736a000 r-xp /lib/libpthread-2.13.so
f7375000 f7377000 r-xp /usr/lib/libdlog.so.0.0.0
f737f000 f7382000 r-xp /usr/lib/libbundle.so.0.1.22
f738a000 f738c000 r-xp /lib/libdl-2.13.so
f7395000 f73a2000 r-xp /usr/lib/libaul.so.0.1.0
f73b4000 f73ba000 r-xp /usr/lib/libappcore-efl.so.1.1
f73c3000 f73c7000 r-xp /usr/lib/libsys-assert.so
f73d0000 f73ed000 r-xp /lib/ld-2.13.so
f73f6000 f73fb000 r-xp /usr/bin/launchpad-loader
f7855000 f7a04000 rw-p [heap]
ff819000 ff83a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5731)
Call Stack Count: 2
 0: (0xf70f11f9) [/usr/lib/libecore.so.1] + 0xf1f9
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
09-17 11:29:14.981-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.bitcoinwatch) pid(6489) type(watchapp) bg(0)
09-17 11:29:14.981-0700 W/AUL_AMD ( 2557): amd_status.c: __socket_monitor_cb(1277) > (6489) was created
09-17 11:29:14.981-0700 E/AUL     ( 2557): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-17 11:29:14.981-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6489)
09-17 11:29:14.981-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6489]
09-17 11:29:15.011-0700 W/WATCH_CORE( 6489): appcore-watch.c: __widget_create(1068) > widget_create
09-17 11:29:15.011-0700 I/CAPI_WATCH_APPLICATION( 6489): watch_app_main.c: watch_app_get_elm_win(663) > watch hwc mode is enabled
09-17 11:29:15.111-0700 D/bitcoinwatch( 6489): 0
09-17 11:29:15.221-0700 I/CAPI_NETWORK_CONNECTION( 6489): connection.c: connection_create(453) > New handle created[0xf78a6200]
09-17 11:29:15.271-0700 I/CAPI_NETWORK_CONNECTION( 6489): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:29:15.371-0700 D/bitcoinwatch( 6489): response {"time":{"updated":"Sep 17, 2017 18:29:00 UTC","updatedISO":"2017-09-17T18:29:00+00:00","updateduk":"Sep 17, 2017 at 19:29 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,733.2200","description":"United States Dollar","rate_float":3733.22},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,746.3246","description":"British Pound Sterling","rate_float":2746.3246},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,125.2091","description":"Euro","rate_float":3125.2091}}}
09-17 11:29:15.371-0700 D/bitcoinwatch( 6489): Size: 3
09-17 11:29:15.371-0700 D/bitcoinwatch( 6489): Rate: 3733.22
09-17 11:29:15.371-0700 E/bitcoinwatch( 6489): updated bitcoin
09-17 11:29:15.381-0700 I/CAPI_NETWORK_CONNECTION( 6489): connection.c: connection_create(453) > New handle created[0xf78a2d00]
09-17 11:29:15.471-0700 I/CAPI_NETWORK_CONNECTION( 6489): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:29:15.561-0700 D/bitcoinwatch( 6489): response {"time":{"updated":"Sep 17, 2017 18:29:00 UTC","updatedISO":"2017-09-17T18:29:00+00:00","updateduk":"Sep 17, 2017 at 19:29 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,733.2200","description":"United States Dollar","rate_float":3733.22},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,746.3246","description":"British Pound Sterling","rate_float":2746.3246},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,125.2091","description":"Euro","rate_float":3125.2091}}}
09-17 11:29:15.561-0700 D/bitcoinwatch( 6489): Size: 3
09-17 11:29:15.561-0700 D/bitcoinwatch( 6489): Rate: 3733.22
09-17 11:29:15.561-0700 E/bitcoinwatch( 6489): updated bitcoin
09-17 11:29:15.561-0700 W/WATCH_CORE( 6489): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:29:15.611-0700 E/WIDGET_PROVIDER_APP( 6489): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:29:15.621-0700 I/WATCH_CORE( 6489): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:29:15.621-0700 I/WATCH_CORE( 6489): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:29:15.621-0700 I/WATCH_CORE( 6489): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:29:15.621-0700 I/WATCH_CORE( 6489): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:29:15.711-0700 W/MUSIC_TRANSFER( 3608): mt-controller.c: _exit_timeout_cb(178) > [36m[TID:3608]   [MUSIC_PLAYER_EVENT]exit[0m
09-17 11:29:15.711-0700 I/CAPI_APPFW_APPLICATION( 3608): service_app_main.c: service_app_exit(441) > service_app_exit
09-17 11:29:15.711-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 22
09-17 11:29:15.711-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(999) > app status : 4
09-17 11:29:15.721-0700 W/MUSIC_TRANSFER( 3608): mt-service.c: _service_app_terminate(104) > [33m[TID:3608]   [0m
09-17 11:29:15.731-0700 I/CAPI_CONTENT_MEDIA_CONTENT( 3608): media_content.c: media_content_disconnect(969) > [32m[3608]ref count changed to: 1
09-17 11:29:15.731-0700 I/CAPI_CONTENT_MEDIA_CONTENT( 3608): media_content.c: media_content_disconnect(958) > [32m[3608]ref count changed to: 0
09-17 11:29:15.731-0700 W/MUSIC_PLAYER( 3608): mp-log-manager.c: mp_log_mgr_destroy(138) > [36m[TID:3608]   [MUSIC_PLAYER_EVENT][0m
09-17 11:29:15.741-0700 W/CAPI_NETWORK_WECONN( 3608): <weconn_destroy:616> } ...weconn handle destoried
09-17 11:29:15.901-0700 W/AUL     ( 6567): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
09-17 11:29:15.901-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 23
09-17 11:29:15.901-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
09-17 11:29:15.901-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 3608
09-17 11:29:15.901-0700 W/AUL_AMD ( 2557): amd_request.c: __send_app_termination_signal(528) > send dead signal done
09-17 11:29:15.901-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3608
09-17 11:29:15.901-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3608)
09-17 11:29:15.981-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:29:15.981-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:29:16.051-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:29:16.061-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6489
09-17 11:29:16.061-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:29:16.581-0700 I/AUL_PAD ( 6568): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:29:17.711-0700 W/AUL_AMD ( 2557): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
09-17 11:29:18.701-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(6489)
09-17 11:29:18.701-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:29:18.701-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6489 pgid = 6489
09-17 11:29:18.701-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:29:18.711-0700 E/AUL_AMD ( 2557): amd_request.c: __app_process_by_pid(201) > pid(6489) is dead. cmd(4) is canceled
09-17 11:29:18.711-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-3)
09-17 11:29:18.711-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:29:18.711-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:29:18.731-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:29:18.741-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:29:18.741-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:29:18.741-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:29:18.791-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:29:18.791-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:29:18.821-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:29:18.821-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:29:18.821-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:29:18.821-0700 W/AUL_PAD ( 6568): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:29:18.821-0700 W/AUL_PAD ( 6568): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:29:18.821-0700 W/AUL_PAD ( 6568): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:29:18.821-0700 W/AUL_PAD ( 6568): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:29:18.851-0700 W/AUL_PAD ( 6568): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:29:18.851-0700 W/AUL_PAD ( 6568): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:29:18.851-0700 I/CAPI_WATCH_APPLICATION( 6568): watch_app_main.c: watch_app_main(399) > watch_app_main
09-17 11:29:18.921-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.bitcoinwatch) pid(6568) type(watchapp) bg(0)
09-17 11:29:18.921-0700 W/AUL_AMD ( 2557): amd_status.c: __socket_monitor_cb(1277) > (6568) was created
09-17 11:29:18.921-0700 E/AUL     ( 2557): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-17 11:29:18.921-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6489
09-17 11:29:18.921-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6489)
09-17 11:29:18.931-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6568]
09-17 11:29:18.931-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6568)
09-17 11:29:18.961-0700 W/WATCH_CORE( 6568): appcore-watch.c: __widget_create(1068) > widget_create
09-17 11:29:18.961-0700 I/CAPI_WATCH_APPLICATION( 6568): watch_app_main.c: watch_app_get_elm_win(663) > watch hwc mode is enabled
09-17 11:29:19.081-0700 D/bitcoinwatch( 6568): 0
09-17 11:29:19.161-0700 I/CAPI_NETWORK_CONNECTION( 6568): connection.c: connection_create(453) > New handle created[0xf76224e0]
09-17 11:29:19.271-0700 I/CAPI_NETWORK_CONNECTION( 6568): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:29:19.341-0700 D/bitcoinwatch( 6568): response {"time":{"updated":"Sep 17, 2017 18:29:00 UTC","updatedISO":"2017-09-17T18:29:00+00:00","updateduk":"Sep 17, 2017 at 19:29 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,733.2200","description":"United States Dollar","rate_float":3733.22},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,746.3246","description":"British Pound Sterling","rate_float":2746.3246},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,125.2091","description":"Euro","rate_float":3125.2091}}}
09-17 11:29:19.341-0700 D/bitcoinwatch( 6568): Size: 3
09-17 11:29:19.341-0700 D/bitcoinwatch( 6568): Rate: 3733.22
09-17 11:29:19.341-0700 E/bitcoinwatch( 6568): updated bitcoin
09-17 11:29:19.341-0700 I/CAPI_NETWORK_CONNECTION( 6568): connection.c: connection_create(453) > New handle created[0xf761d5b0]
09-17 11:29:19.431-0700 I/CAPI_NETWORK_CONNECTION( 6568): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:29:19.521-0700 D/bitcoinwatch( 6568): response {"time":{"updated":"Sep 17, 2017 18:29:00 UTC","updatedISO":"2017-09-17T18:29:00+00:00","updateduk":"Sep 17, 2017 at 19:29 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,733.2200","description":"United States Dollar","rate_float":3733.22},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,746.3246","description":"British Pound Sterling","rate_float":2746.3246},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,125.2091","description":"Euro","rate_float":3125.2091}}}
09-17 11:29:19.521-0700 D/bitcoinwatch( 6568): Size: 3
09-17 11:29:19.521-0700 D/bitcoinwatch( 6568): Rate: 3733.22
09-17 11:29:19.521-0700 E/bitcoinwatch( 6568): updated bitcoin
09-17 11:29:19.521-0700 W/WATCH_CORE( 6568): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:29:19.551-0700 E/WIDGET_PROVIDER_APP( 6568): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:29:19.571-0700 I/WATCH_CORE( 6568): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:29:19.571-0700 I/WATCH_CORE( 6568): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:29:19.571-0700 I/WATCH_CORE( 6568): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:29:19.571-0700 I/WATCH_CORE( 6568): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:29:19.931-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:29:19.931-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:29:20.001-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:29:20.001-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6568
09-17 11:29:20.001-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:29:20.301-0700 I/AUL_PAD ( 6593): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:29:20.861-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11056956269741505672838
09-17 11:29:21.991-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_handler_idle(1486) > Lock the display not to enter LCD OFF
09-17 11:29:22.001-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-17 11:29:22.021-0700 W/AUL     ( 2514): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(2758) type(wakeup)
09-17 11:29:22.021-0700 E/RESOURCED( 2702): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 2758
09-17 11:29:22.021-0700 E/ALARM_MANAGER( 2758): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [605505534]
09-17 11:29:22.021-0700 W/STARTER ( 2758): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(979) > [__starter_clock_mgr_homescreen_alarm_cb:979] homescreen alarm timer expired [605505534]
09-17 11:29:22.021-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_expired(1447) > alarm_id[605505534] is expired.
09-17 11:29:22.021-0700 E/ALARM_MANAGER( 2514): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 605505534, next duetime: 1505672982
09-17 11:29:22.021-0700 E/ALARM_MANAGER( 2514): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(727368127) is OVER.
09-17 11:29:22.021-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-17 11:29:22.021-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 17-9-2017, 18:29:42 (UTC).
09-17 11:29:22.021-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-17 11:29:22.021-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_handler_idle(1512) > Unlock the display from LCD OFF
09-17 11:29:22.031-0700 W/AUL     ( 2758): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
09-17 11:29:22.031-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:29:22.031-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2758
09-17 11:29:22.041-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(2907) type(uiapp) bg(0)
09-17 11:29:22.041-0700 W/AUL_AMD ( 2557): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2907
09-17 11:29:22.041-0700 W/AUL_AMD ( 2557): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(2907), cmd(0)
09-17 11:29:22.041-0700 I/APP_CORE( 2907): appcore-efl.c: __do_app(453) > [APP 2907] Event: RESET State: PAUSED
09-17 11:29:22.041-0700 I/CAPI_APPFW_APPLICATION( 2907): app_main.c: app_appcore_reset(245) > app_appcore_reset
09-17 11:29:22.041-0700 W/CAPI_APPFW_APP_CONTROL( 2907): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
09-17 11:29:22.041-0700 W/W_HOME  ( 2907): main.c: _app_control_progress(1571) > Service value : show_clock
09-17 11:29:22.041-0700 W/W_HOME  ( 2907): main.c: _app_control_progress(1588) > Show clock operation
09-17 11:29:22.041-0700 W/W_HOME  ( 2907): gesture.c: _clock_show(242) > clock show
09-17 11:29:22.041-0700 W/AUL     ( 2758): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2907)
09-17 11:29:22.041-0700 W/W_HOME  ( 2907): gesture.c: _clock_show(257) > home raise
09-17 11:29:22.041-0700 E/W_HOME  ( 2907): gesture.c: gesture_win_aux_set(402) > wm.policy.win.do.not.use.deiconify.approve:-1
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): dbus_util.c: home_dbus_home_raise_signal_send(298) > Sending HOME RAISE signal, result:0
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): gesture.c: _clock_show(260) > home raise done
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): gesture.c: _clock_show(267) > show clock
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): index.c: index_hide(337) > hide VI:0 visibility:0 vi:(nil)
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): move.c: move_back_to_home_no_anim(274) > back to home no anim
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): rotary.c: rotary_attach(138) > rotary_attach:0xf8424c60
09-17 11:29:22.051-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf8424c60, elm_layout, _activated_obj : 0xf819d660, activated : 1
09-17 11:29:22.051-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): event_manager.c: _move_module_anim_start_cb(666) > state: 0 -> 1
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:3, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:29:22.051-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-17 11:29:22.051-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2758].
09-17 11:29:22.051-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(605505534)
09-17 11:29:22.051-0700 E/ALARM_MANAGER( 2514): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(727368127) is OVER.
09-17 11:29:22.051-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): event_manager.c: _move_module_anim_end_cb(680) > state: 1 -> 0
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:3, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): rotary.c: rotary_deattach(156) > rotary_deattach:0xf8424c60
09-17 11:29:22.051-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
09-17 11:29:22.051-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf8424c60, elm_layout, func : 0xf75fb68d
09-17 11:29:22.051-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
09-17 11:29:22.051-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
09-17 11:29:22.051-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
09-17 11:29:22.051-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf819d660, elm_box, _activated_obj : 0xf8424c60, activated : 1
09-17 11:29:22.051-0700 I/efl-extension( 2907): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
09-17 11:29:22.051-0700 E/wnotib  ( 2907): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
09-17 11:29:22.051-0700 I/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_is_key_event_passed(5857) > Return true for 6079, 11244.
09-17 11:29:22.051-0700 I/wnotib  ( 2907): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
09-17 11:29:22.051-0700 W/W_HOME  ( 2907): gesture.c: _manual_render(182) > 
09-17 11:29:22.051-0700 I/efl-extension( 3625): efl_extension_more_option.c: eext_more_option_opened_get(653) > called!!
09-17 11:29:22.051-0700 W/wnotibp ( 3625): wnotiboard-popup-control.c: _ctrl_home_raise_cb(163) > [4, 2, 1]
09-17 11:29:22.051-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: wnbp_view_goto_pause(1447) > state : (7, 1, 4)
09-17 11:29:22.051-0700 I/wnotibp ( 3625): wnotiboard-popup-view.c: wnbp_view_goto_pause(1460) > simple popup=f82c45f8, view_state=4
09-17 11:29:22.051-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_get_view_lock_state(666) > ::UI:: lock state=0000
09-17 11:29:22.051-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_reset_view_lock(703) > ::UI:: lock state = 0000
09-17 11:29:22.061-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: wnbp_view_goto_pause(1522) > device_power_release_lock CPU>>>>>>>
09-17 11:29:22.061-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:29:22.061-0700 W/W_INDICATOR( 2759): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
09-17 11:29:22.061-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:29:22.061-0700 W/AUL_AMD ( 2557): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
09-17 11:29:22.061-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2907) status(fg) type(uiapp)
09-17 11:29:22.071-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-17 11:29:22.071-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-17 11:29:22.071-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 17-9-2017, 18:37:32 (UTC).
09-17 11:29:22.071-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-17 11:29:22.081-0700 I/wnotibp ( 3625): w-notification-board-action.c: _wnb_action_terminate_input_selector(5171) > No need to close w-input-selector.
09-17 11:29:22.081-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:29:22.091-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
09-17 11:29:22.091-0700 I/wnotibp ( 3625): w-notification-board-action.c: _wnb_action_terminate_noti_composer(5206) > ret : 0, is_running : 0
09-17 11:29:22.091-0700 I/efl-extension( 3625): efl_extension_more_option.c: eext_more_option_opened_get(653) > called!!
09-17 11:29:22.091-0700 I/wnotibp ( 3625): w-notification-board-action.c: wnb_action_hide_drawer(4840) > Panel open state: 0 for 6079, 11244
09-17 11:29:22.091-0700 I/efl-extension( 3625): efl_extension_more_option.c: eext_more_option_opened_get(653) > called!!
09-17 11:29:22.091-0700 I/wnotibp ( 3625): w-notification-board-action.c: wnb_action_deinitialize(5286) > Deinit drawer.
09-17 11:29:22.091-0700 I/wnotibp ( 3625): w-notification-board-action.c: _wnb_action_terminate_input_selector(5171) > No need to close w-input-selector.
09-17 11:29:22.091-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:29:22.101-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
09-17 11:29:22.101-0700 I/wnotibp ( 3625): w-notification-board-action.c: _wnb_action_terminate_noti_composer(5206) > ret : 0, is_running : 0
09-17 11:29:22.101-0700 I/wnotibp ( 3625): w-notification-board-action.c: _wnb_action_sending_popup_del_cb(696) > 0xf30bfe38, g_sending_popup_state: 0
09-17 11:29:22.101-0700 I/efl-extension( 3625): efl_extension_more_option.c: eext_more_option_items_clear(570) > called!!
09-17 11:29:22.101-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_items_clear(2288) > called!!
09-17 11:29:22.101-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _item_del_cb(1099) > called!!
09-17 11:29:22.111-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _item_del_cb(1099) > called!!
09-17 11:29:22.111-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _item_del_cb(1099) > called!!
09-17 11:29:22.111-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-17 11:29:22.111-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[605505534] is removed.
09-17 11:29:22.121-0700 I/APP_CORE( 2907): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
09-17 11:29:22.121-0700 W/W_HOME  ( 2907): event_manager.c: _apptray_visibility_cb(604) > apps,hide,start
09-17 11:29:22.121-0700 W/W_HOME  ( 2907): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 0
09-17 11:29:22.121-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.121-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.121-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:29:22.121-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [2907]
09-17 11:29:22.131-0700 I/efl-extension( 3625): efl_extension_more_option.c: _more_option_del_cb(266) > called!!
09-17 11:29:22.131-0700 I/efl-extension( 3625): efl_extension_more_option.c: _panel_del_cb(171) > called!!
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:5, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): clock_manager.c: _compositing_set(205) > hwc:1
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): noti_broker.c: _apptray_visibility_cb(793) > apps,hide,start
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): noti_broker.c: noti_broker_event_fire_to_plugin(1010) > source:1 event:80002
09-17 11:29:22.131-0700 W/wnotib  ( 2907): w-notification-board-broker-main.c: _wnb_handle_view_event(1289) > Home view event: 0x80002
09-17 11:29:22.131-0700 I/wnotib  ( 2907): w-notification-board-broker-main.c: _wnb_handle_view_event(1396) > Unhandled type: 0x80002
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): event_manager.c: _apptray_visibility_cb(604) > apps,hide
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 0
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:5, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): noti_broker.c: _apptray_visibility_cb(793) > apps,hide
09-17 11:29:22.131-0700 W/W_HOME  ( 2907): noti_broker.c: noti_broker_event_fire_to_plugin(1010) > source:1 event:80001
09-17 11:29:22.131-0700 W/wnotib  ( 2907): w-notification-board-broker-main.c: _wnb_handle_view_event(1289) > Home view event: 0x80001
09-17 11:29:22.131-0700 I/wnotib  ( 2907): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 0
09-17 11:29:22.131-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(946) > Do the postponed update job with is_for_VI: 0, postponed_for_VI: 0.
09-17 11:29:22.131-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(434) > idler for type: 0
09-17 11:29:22.131-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _rotary_selector_del_cb(821) > called!!
09-17 11:29:22.131-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
09-17 11:29:22.131-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf30ef8a8, elm_layout, func : 0xf73427b1
09-17 11:29:22.131-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
09-17 11:29:22.131-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
09-17 11:29:22.131-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
09-17 11:29:22.131-0700 I/efl-extension( 3625): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0xf30ef8a8, obj: 0xf30ef8a8
09-17 11:29:22.131-0700 I/efl-extension( 3625): efl_extension_rotary.c: _object_deleted_cb(618) > done
09-17 11:29:22.131-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _event_area_del_cb(489) > called!!
09-17 11:29:22.141-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:29:22.141-0700 W/STARTER ( 2758): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2907] goes to (3)
09-17 11:29:22.141-0700 I/wnoti-proxy( 2907): wnoti-client.c: is_mini_app(1795) > is_mini_app : 0
09-17 11:29:22.151-0700 E/STARTER ( 2758): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2907)'s state(3)
09-17 11:29:22.151-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:29:22.151-0700 I/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(482) > unread_count: 1
09-17 11:29:22.151-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_add_category_data(184) > category_id: 6079, application_id: 11244, application_name: Blockfolio, time_stamp: 1505672923, content_id: 0, spannable_string_version: 1, disble_block_app_action: 0, support_large_icon: 0, android_app_color: 0
09-17 11:29:22.151-0700 I/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(520) > noti_type [1]
09-17 11:29:22.151-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: wnb_nm_add_detail_data(85) > noti_type: 1, application_id: 11244, application_name: Blockfolio, category_id: 6079, spannable_string_version: 1
09-17 11:29:22.151-0700 I/wnotib  ( 2907): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(60) > db_id: 46871, noti_type: 1
09-17 11:29:22.151-0700 I/wnotib  ( 2907): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(86) > is_source_companion: 1, content_id: 0, notification_id: 0
09-17 11:29:22.151-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:29:22.151-0700 I/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(667) > New noti is here. Add it on panel  6079, Blockfolio.
09-17 11:29:22.151-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_add_card(331) > db_id: 46871, application_id: 11244, application_name: Blockfolio
09-17 11:29:22.141-0700 I/wnotibp ( 3625): w-notification-board-action.c: wnb_action_deinitialize(5331) > g_wnb_action_data is freed.
09-17 11:29:22.151-0700 I/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_message_receive(4772) > New event with category_id: 6079, application_id: 11244, type: 1
09-17 11:29:22.151-0700 I/wnotibp ( 3625): wnotiboard-popup-view.c: wnbp_view_goto_pause(1557) > ::INFO:: call lower
09-17 11:29:22.151-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: _view_simple_popup_del_cb(388) > ::UI:: (2, f82c45f8, f82c45f8, 0)
09-17 11:29:22.151-0700 I/wnotibp ( 3625): wnotiboard-popup-data.c: wnbp_data_free_alert_data_by_db_id(664) > ::DATA:: remove notification data, 46871
09-17 11:29:22.151-0700 W/wnotibp ( 3625): wnotiboard-popup-data.c: wnbp_data_free_alert_data_by_db_id(679) > Call wnbp_free_noti_detail..
09-17 11:29:22.151-0700 W/wnotibp ( 3625): wnotiboard-popup-common.c: wnbp_free_noti_detail(583) > Do free noti [0xf3080ae8] / db id [46871]
09-17 11:29:22.151-0700 I/wnotibp ( 3625): wnotiboard-popup-data.c: wnbp_data_free_alert_data_by_db_id(683) > ::DATA:: CHECK DATA : 0
09-17 11:29:22.151-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_get_view_lock_state(666) > ::UI:: lock state=0000
09-17 11:29:22.151-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_reset_view_lock(703) > ::UI:: lock state = 0000
09-17 11:29:22.151-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: _view_simple_popup_del_cb(458) > ::UI:: drawer is NULL
09-17 11:29:22.151-0700 I/efl-extension( 3625): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
09-17 11:29:22.161-0700 I/efl-extension( 3625): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0xf301a890
09-17 11:29:22.161-0700 I/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_message_receive(5089) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
09-17 11:29:22.161-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf301a890, elm_genlist, _activated_obj : 0x0, activated : 0
09-17 11:29:22.161-0700 I/efl-extension( 3625): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0xf301a890, obj: 0xf301a890
09-17 11:29:22.171-0700 I/efl-extension( 3625): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
09-17 11:29:22.171-0700 I/efl-extension( 3625): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
09-17 11:29:22.171-0700 I/efl-extension( 3625): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
09-17 11:29:22.171-0700 I/efl-extension( 3625): efl_extension_rotary.c: _object_deleted_cb(618) > done
09-17 11:29:22.171-0700 I/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_message_receive(4772) > New event with category_id: 6079, application_id: 11244, type: 10
09-17 11:29:22.171-0700 W/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_message_receive(5160) > notiboard panel creation count [6], notiboard card appending count [61].
09-17 11:29:22.171-0700 I/wnotib  ( 2907): w-notification-board-common.c: wnb_common_get_application_icon(1704) > application_id: 11244, thumbnail path: /opt/usr/data/wnoti/.app_icon_11244.png, summary_large_image path: (null), width: 58, height: 58
09-17 11:29:22.181-0700 I/wnotib  ( 2907): w-notification-board-common.c: wnb_common_add_badge(1930) > badge is unused.
09-17 11:29:22.181-0700 I/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_message_receive(5301) > Home window is in background, fully_obscured [1]
09-17 11:29:22.181-0700 E/EFL     ( 3625): elementary<3625> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
09-17 11:29:22.181-0700 I/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(702) > This noti will be removed from panel: 6079, Blockfolio.
09-17 11:29:22.181-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_remove_card(409) > db_id: 46870, application_id: 11244, application_name: Blockfolio
09-17 11:29:22.181-0700 I/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_message_receive(4772) > New event with category_id: 6079, application_id: 11244, type: 2
09-17 11:29:22.181-0700 I/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_delete_card(3253) > db_id: 46870, is_request_from_noti_service: 1
09-17 11:29:22.181-0700 I/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_delete_card(3407) > We don't need to delete the item for second_depth_type: 0.
09-17 11:29:22.181-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
09-17 11:29:22.181-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf301a890, elm_genlist, func : 0xf7338f19
09-17 11:29:22.181-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
09-17 11:29:22.181-0700 E/EFL     ( 2907): elementary<2907> elm_genlist.c:6333 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
09-17 11:29:22.181-0700 I/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_message_receive(4772) > New event with category_id: 6079, application_id: 11244, type: 9
09-17 11:29:22.191-0700 I/wnotib  ( 2907): w-notification-board-common.c: wnb_common_get_application_icon(1704) > application_id: 11244, thumbnail path: /opt/usr/data/wnoti/.app_icon_11244.png, summary_large_image path: (null), width: 58, height: 58
09-17 11:29:22.191-0700 I/wnotib  ( 2907): w-notification-board-common.c: wnb_common_add_badge(1930) > badge is unused.
09-17 11:29:22.191-0700 I/wnotib  ( 2907): w-notification-board-basic-panel.c: _wnb_bp_message_receive(5148) > Home window is in background, fully_obscured [1]
09-17 11:29:22.191-0700 W/APP_CORE( 3625): appcore-efl.c: __hide_cb(882) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:360000a
09-17 11:29:22.191-0700 I/APP_CORE( 3625): appcore-efl.c: __do_app(453) > [APP 3625] Event: PAUSE State: PAUSED
09-17 11:29:22.191-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(712) > Num categories: 1, num total noti: 1
09-17 11:29:22.191-0700 I/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_free_data(240) > Free noti manager data.
09-17 11:29:22.201-0700 I/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_free_data(245) > Free previous notifications.
09-17 11:29:22.201-0700 I/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_free_data(266) > Free previous categories.
09-17 11:29:22.201-0700 I/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(735) > before_rpanel_count: 1, after_rpanel_count: 1.
09-17 11:29:22.201-0700 W/W_HOME  ( 2907): noti_broker.c: _handler_indicator_update(560) > 0x1
09-17 11:29:22.221-0700 E/APPS    ( 2907): apps_main.c: apps_main_pause(984) >  paused already
09-17 11:29:22.321-0700 W/W_HOME  ( 2907): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
09-17 11:29:22.321-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.321-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.321-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.321-0700 W/W_HOME  ( 2907): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
09-17 11:29:22.321-0700 W/W_HOME  ( 2907): clock_manager.c: _hwc_enabled_success_cb(153) > hwc enabled
09-17 11:29:22.321-0700 W/W_HOME  ( 2907): event_manager.c: _window_visibility_cb(466) > Window [0x2200003] is now visible(0)
09-17 11:29:22.321-0700 W/W_HOME  ( 2907): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
09-17 11:29:22.321-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.321-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-17 11:29:22.321-0700 W/W_HOME  ( 2907): main.c: _window_visibility_cb(964) > Window [0x2200003] is now visible(0)
09-17 11:29:22.321-0700 I/APP_CORE( 2907): appcore-efl.c: __visibility_cb(937) > LCD status is off, skip the AE_RESUME event
09-17 11:29:22.321-0700 I/wnotib  ( 2907): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
09-17 11:29:22.321-0700 E/wnotib  ( 2907): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
09-17 11:29:22.321-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 0.
09-17 11:29:22.331-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:29:22.331-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:29:22.681-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6568 pgid = 6568
09-17 11:29:22.681-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:29:22.681-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(6568)
09-17 11:29:22.681-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:29:22.691-0700 E/AUL_AMD ( 2557): amd_request.c: __app_process_by_pid(201) > pid(6568) is dead. cmd(4) is canceled
09-17 11:29:22.691-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-3)
09-17 11:29:22.691-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:29:22.691-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:29:22.701-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:29:22.711-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:29:22.711-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:29:22.711-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:29:22.761-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:29:22.761-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:29:22.811-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:29:22.811-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:29:22.811-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:29:22.811-0700 W/AUL_PAD ( 6593): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:29:22.811-0700 W/AUL_PAD ( 6593): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:29:22.811-0700 W/AUL_PAD ( 6593): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:29:22.811-0700 W/AUL_PAD ( 6593): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:29:22.881-0700 W/AUL_PAD ( 6593): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:29:22.881-0700 W/AUL_PAD ( 6593): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:29:22.881-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 1105731626974150567288
