S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.3
Build-Number: R765VVRU1AQF4
Build-Date: 2017.07.17 17:00:49

Crash Information
Process Name: bitcoinwatch
PID: 5539
Date: 2017-09-17 11:22:02-0700
Executable File Path: /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x4072ccd9
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71959b8, r5   = 0xf71959b8
r6   = 0xf719516c, r7   = 0xf71959b8
r8   = 0xf71959b8, r9   = 0xf7ab0ff8
r10  = 0xf71a3b10, fp   = 0x0000018f
ip   = 0x00000001, sp   = 0xffb19430
lr   = 0xf71851f9, pc   = 0x00000000
cpsr = 0x60000030

Memory Information
MemTotal:   620380 KB
MemFree:     34836 KB
Buffers:     16236 KB
Cached:     139320 KB
VmPeak:      77552 KB
VmSize:      77552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23976 KB
VmRSS:       23976 KB
VmData:      20220 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       21132 KB
VmPTE:         112 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5539 TID = 5539
5539 5557 5564 

Maps Information
f2dfa000 f35f9000 rw-p [stack:5564]
f3696000 f36ad000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f36ba000 f36c5000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f36ce000 f36d9000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f36e2000 f3ee1000 rw-p [stack:5557]
f40e1000 f40f1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f40f9000 f4104000 r-xp /usr/lib/libtbm.so.1.0.0
f410c000 f4155000 r-xp /usr/lib/libmdm.so.1.2.69
f415d000 f4163000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f416b000 f416d000 r-xp /usr/lib/libdri2.so.0.0.0
f4175000 f417d000 r-xp /usr/lib/libdrm.so.2.4.0
f4185000 f4195000 r-xp /usr/lib/libwidget_provider.so.1.0.0
f419d000 f41a6000 r-xp /usr/lib/libcom-core.so.0.0.1
f5a48000 f5a4d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5a55000 f5a6e000 r-xp /usr/lib/libnetwork.so.0.0.0
f5a76000 f5a80000 r-xp /usr/lib/libwidget.so.1.0.0
f5a88000 f5a9b000 r-xp /usr/lib/libwidget_service.so.1.0.0
f5aa4000 f5aab000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
f5ab4000 f5bba000 r-xp /usr/lib/libicuuc.so.57.1
f5bd0000 f5d58000 r-xp /usr/lib/libicui18n.so.57.1
f5d68000 f5d75000 r-xp /usr/lib/libalarm.so.0.0.0
f5d7f000 f5d8e000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f5d97000 f5da7000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f5daf000 f5db7000 r-xp /usr/lib/libappcore-watch.so.1.1
f5dc9000 f5dce000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f5f68000 f5f72000 r-xp /lib/libnss_files-2.13.so
f5f7b000 f604a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f6060000 f6084000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f608d000 f6093000 r-xp /usr/lib/libappsvc.so.0.1.0
f609b000 f609f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f60ad000 f60af000 r-xp /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
f60bf000 f60c1000 r-xp /usr/lib/libiniparser.so.0
f60ca000 f60cf000 r-xp /usr/lib/libappcore-common.so.1.1
f60d7000 f60d9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f60e2000 f60e6000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f60f3000 f60f5000 r-xp /usr/lib/libXau.so.6.0.0
f60fd000 f6104000 r-xp /lib/libcrypt-2.13.so
f6134000 f6136000 r-xp /usr/lib/libiri.so
f613f000 f62e8000 r-xp /usr/lib/libcrypto.so.1.0.0
f6308000 f634f000 r-xp /usr/lib/libssl.so.1.0.0
f635b000 f6389000 r-xp /usr/lib/libidn.so.11.5.44
f6391000 f639a000 r-xp /usr/lib/libcares.so.2.1.0
f63a4000 f63b7000 r-xp /usr/lib/libxcb.so.1.1.0
f63c0000 f63c2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f63ca000 f63cc000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f63d5000 f64a1000 r-xp /usr/lib/libxml2.so.2.7.8
f64ae000 f64b0000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f64b9000 f64be000 r-xp /usr/lib/libffi.so.5.0.10
f64c6000 f64c7000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f64cf000 f64d2000 r-xp /lib/libattr.so.1.1.0
f64da000 f656e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6581000 f659e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65a8000 f65c0000 r-xp /usr/lib/libpng12.so.0.50.0
f65c8000 f65de000 r-xp /lib/libexpat.so.1.6.0
f65e8000 f662c000 r-xp /usr/lib/libcurl.so.4.3.0
f6635000 f663f000 r-xp /usr/lib/libXext.so.6.4.0
f6648000 f664c000 r-xp /usr/lib/libXtst.so.6.1.0
f6654000 f665a000 r-xp /usr/lib/libXrender.so.1.3.0
f6662000 f6668000 r-xp /usr/lib/libXrandr.so.2.2.0
f6670000 f6671000 r-xp /usr/lib/libXinerama.so.1.0.0
f667a000 f6683000 r-xp /usr/lib/libXi.so.6.1.0
f668b000 f668e000 r-xp /usr/lib/libXfixes.so.3.1.0
f6696000 f6698000 r-xp /usr/lib/libXgesture.so.7.0.0
f66a0000 f66a2000 r-xp /usr/lib/libXcomposite.so.1.0.0
f66aa000 f66ac000 r-xp /usr/lib/libXdamage.so.1.1.0
f66b4000 f66bb000 r-xp /usr/lib/libXcursor.so.1.0.2
f66c3000 f66c6000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f66ce000 f66d2000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f66db000 f66e0000 r-xp /usr/lib/libecore_fb.so.1.7.99
f66e9000 f67ca000 r-xp /usr/lib/libX11.so.6.3.0
f67d5000 f67f8000 r-xp /usr/lib/libjpeg.so.8.0.2
f6810000 f6826000 r-xp /lib/libz.so.1.2.5
f682e000 f6830000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6838000 f68ad000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68b7000 f68d1000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68d9000 f690d000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6916000 f69e9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69f4000 f6a04000 r-xp /lib/libresolv-2.13.so
f6a08000 f6a20000 r-xp /usr/lib/liblzma.so.5.0.3
f6a28000 f6a2b000 r-xp /lib/libcap.so.2.21
f6a33000 f6a62000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a6b000 f6a6c000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6a74000 f6a7a000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6a82000 f6a99000 r-xp /usr/lib/liblua-5.1.so
f6aa2000 f6aa9000 r-xp /usr/lib/libembryo.so.1.7.99
f6ab1000 f6ab7000 r-xp /lib/librt-2.13.so
f6ac0000 f6b16000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6b23000 f6b79000 r-xp /usr/lib/libfreetype.so.6.11.3
f6b85000 f6bad000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6bae000 f6bf3000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6bfc000 f6c0f000 r-xp /usr/lib/libfribidi.so.0.3.1
f6c17000 f6c31000 r-xp /usr/lib/libecore_con.so.1.7.99
f6c3a000 f6c43000 r-xp /usr/lib/libedbus.so.1.7.99
f6c4b000 f6c9b000 r-xp /usr/lib/libecore_x.so.1.7.99
f6c9d000 f6ca6000 r-xp /usr/lib/libvconf.so.0.2.45
f6cae000 f6cbf000 r-xp /usr/lib/libecore_input.so.1.7.99
f6cc7000 f6ccc000 r-xp /usr/lib/libecore_file.so.1.7.99
f6cd4000 f6cf6000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6cff000 f6d40000 r-xp /usr/lib/libeina.so.1.7.99
f6d49000 f6d62000 r-xp /usr/lib/libeet.so.1.7.99
f6d73000 f6ddc000 r-xp /lib/libm-2.13.so
f6de5000 f6deb000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6df4000 f6df5000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6dfd000 f6e20000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e28000 f6e2d000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e35000 f6e5f000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e68000 f6e7f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e87000 f6e92000 r-xp /lib/libunwind.so.8.0.1
f6ebf000 f6edd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ee7000 f700b000 r-xp /lib/libc-2.13.so
f7019000 f7021000 r-xp /lib/libgcc_s-4.6.so.1
f7022000 f7026000 r-xp /usr/lib/libsmack.so.1.0.0
f702f000 f7035000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f703d000 f710d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f710e000 f716c000 r-xp /usr/lib/libedje.so.1.7.99
f7176000 f718d000 r-xp /usr/lib/libecore.so.1.7.99
f71a4000 f7272000 r-xp /usr/lib/libevas.so.1.7.99
f7297000 f73d3000 r-xp /usr/lib/libelementary.so.1.7.99
f73ea000 f73fe000 r-xp /lib/libpthread-2.13.so
f7409000 f740b000 r-xp /usr/lib/libdlog.so.0.0.0
f7413000 f7416000 r-xp /usr/lib/libbundle.so.0.1.22
f741e000 f7420000 r-xp /lib/libdl-2.13.so
f7429000 f7436000 r-xp /usr/lib/libaul.so.0.1.0
f7448000 f744e000 r-xp /usr/lib/libappcore-efl.so.1.1
f7457000 f745b000 r-xp /usr/lib/libsys-assert.so
f7464000 f7481000 r-xp /lib/ld-2.13.so
f748a000 f748f000 r-xp /usr/bin/launchpad-loader
f7a79000 f7c49000 rw-p [heap]
ffafa000 ffb1b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5539)
Call Stack Count: 2
 0: (0xf71851f9) [/usr/lib/libecore.so.1] + 0xf1f9
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
ient.c: wnoti_get_alert_categories(997) > _query_step failed(NO ROW)
09-17 11:28:45.751-0700 E/wnoti-service( 3235): wnoti-db-utility.c: set_pm_lock(583) > >> set_pm_lock status : 2
09-17 11:28:45.751-0700 E/wnoti-service( 3235): wnoti-db-utility.c: unlock_pm(614) > >> unlock_pm status : 0
09-17 11:28:45.751-0700 E/wnoti-proxy( 3625): wnoti.c: _wnoti_get_categories(1268) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
09-17 11:28:45.751-0700 E/wnotibp ( 3625): wnotiboard-popup-data.c: _data_get_alert_list(304) > ::DATA:: No categories available.
09-17 11:28:45.751-0700 W/wnotibp ( 3625): wnotiboard-popup-data.c: _data_get_alert_list(307) > ::DATA:: read alert list : 1, new_list count : 0
09-17 11:28:45.911-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(6114)
09-17 11:28:45.911-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:28:45.911-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(org.example.bitcoinwatch) pid(6114) type(watchapp)
09-17 11:28:45.911-0700 E/AUL     ( 2557): app_sock.c: __connect_client_sock(196) > connect error: 111
09-17 11:28:45.911-0700 E/AUL     ( 2557): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-17 11:28:45.931-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6114 pgid = 6114
09-17 11:28:45.931-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:28:45.981-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:28:46.011-0700 E/AUL     ( 2557): app_sock.c: __connect_client_sock(196) > connect error: 111
09-17 11:28:46.011-0700 E/AUL     ( 2557): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-17 11:28:46.311-0700 E/AUL     ( 2557): app_sock.c: __connect_client_sock(196) > connect error: 111
09-17 11:28:46.311-0700 E/AUL     ( 2557): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-17 11:28:46.311-0700 E/AUL_AMD ( 2557): amd_launch.c: _term_app(1106) > fail to killing - 6114
09-17 11:28:46.311-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-1)
09-17 11:28:46.311-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:28:46.321-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:28:46.331-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:46.341-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:46.341-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:28:46.341-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:28:46.351-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:28:46.351-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:28:46.351-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:28:46.351-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:28:46.351-0700 W/AUL_PAD ( 6164): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:28:46.351-0700 W/AUL_PAD ( 6164): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:28:46.351-0700 W/AUL_PAD ( 6164): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:28:46.361-0700 W/AUL_PAD ( 6164): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:28:46.381-0700 W/AUL_PAD ( 6164): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:28:46.381-0700 W/AUL_PAD ( 6164): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:28:46.381-0700 I/CAPI_WATCH_APPLICATION( 6164): watch_app_main.c: watch_app_main(399) > watch_app_main
09-17 11:28:46.451-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.bitcoinwatch) pid(6164) type(watchapp) bg(0)
09-17 11:28:46.451-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6114
09-17 11:28:46.451-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6114)
09-17 11:28:46.461-0700 W/AUL_AMD ( 2557): amd_status.c: __socket_monitor_cb(1277) > (6164) was created
09-17 11:28:46.461-0700 E/AUL     ( 2557): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-17 11:28:46.461-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6164)
09-17 11:28:46.461-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6164]
09-17 11:28:46.491-0700 W/WATCH_CORE( 6164): appcore-watch.c: __widget_create(1068) > widget_create
09-17 11:28:46.491-0700 I/CAPI_WATCH_APPLICATION( 6164): watch_app_main.c: watch_app_get_elm_win(663) > watch hwc mode is enabled
09-17 11:28:46.601-0700 D/bitcoinwatch( 6164): 0
09-17 11:28:46.691-0700 I/CAPI_NETWORK_CONNECTION( 6164): connection.c: connection_create(453) > New handle created[0xf76b6308]
09-17 11:28:46.741-0700 I/CAPI_NETWORK_CONNECTION( 6164): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:46.831-0700 D/bitcoinwatch( 6164): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:46.831-0700 D/bitcoinwatch( 6164): Size: 3
09-17 11:28:46.831-0700 D/bitcoinwatch( 6164): Rate: 3731.85
09-17 11:28:46.831-0700 E/bitcoinwatch( 6164): updated bitcoin
09-17 11:28:46.841-0700 I/CAPI_NETWORK_CONNECTION( 6164): connection.c: connection_create(453) > New handle created[0xf7677050]
09-17 11:28:46.871-0700 I/TDM     ( 2006): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [367.529623] dpms[3 -> 0]sync[0]
09-17 11:28:46.871-0700 I/TDM     ( 2006): 
09-17 11:28:46.871-0700 I/TDM     ( 2006): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [367.529748] dpms[0 -> 0]done
09-17 11:28:46.871-0700 I/TDM     ( 2006): 
09-17 11:28:46.901-0700 W/wnotibp ( 3625): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=1, 2, 0
09-17 11:28:46.901-0700 W/wnotibp ( 3625): wnotiboard-popup-common.c: wnbp_popup_check_expired_popup(552) > [1505672926, 1505672925, 1, 6]
09-17 11:28:46.901-0700 W/wnotibp ( 3625): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(119) > timeout:6
09-17 11:28:46.901-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_get_view_lock_state(666) > ::UI:: lock state=0000
09-17 11:28:46.901-0700 W/WAKEUP-SERVICE( 3580): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -148096244[0;m
09-17 11:28:46.901-0700 W/WAKEUP-SERVICE( 3580): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
09-17 11:28:46.901-0700 W/WAKEUP-SERVICE( 3580): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
09-17 11:28:46.901-0700 I/TIZEN_N_SOUND_MANAGER( 3580): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
09-17 11:28:46.911-0700 W/STARTER ( 2758): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [powerkey] after screen off time [8336]ms
09-17 11:28:46.911-0700 W/STARTER ( 2758): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
09-17 11:28:46.911-0700 W/W_HOME  ( 2907): dbus.c: _dbus_message_recv_cb(186) > LCD on
09-17 11:28:46.911-0700 W/W_HOME  ( 2907): gesture.c: _manual_render_disable_timer_set(167) > timer set
09-17 11:28:46.911-0700 W/W_HOME  ( 2907): gesture.c: _manual_render_disable_timer_del(157) > timer del
09-17 11:28:46.911-0700 W/W_HOME  ( 2907): gesture.c: _apps_status_get(128) > apps status:0
09-17 11:28:46.911-0700 W/W_HOME  ( 2907): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:8336
09-17 11:28:46.911-0700 W/W_HOME  ( 2907): gesture.c: _manual_render_schedule(209) > schedule, manual render
09-17 11:28:46.911-0700 W/W_HOME  ( 2907): event_manager.c: _lcd_on_cb(721) > lcd state: 1
09-17 11:28:46.911-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:46.911-0700 W/TIZEN_N_SOUND_MANAGER( 3580): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
09-17 11:28:46.911-0700 W/W_INDICATOR( 2759): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
09-17 11:28:46.911-0700 W/W_INDICATOR( 2759): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[powerkey],charge : 0, connected : 0
09-17 11:28:46.921-0700 E/WAKEUP-SERVICE( 3580): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
09-17 11:28:46.921-0700 E/WAKEUP-SERVICE( 3580): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
09-17 11:28:46.921-0700 E/WAKEUP-SERVICE( 3580): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
09-17 11:28:46.921-0700 I/TIZEN_N_SOUND_MANAGER( 3580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
09-17 11:28:46.921-0700 W/wnotibp ( 3625): wnotiboard-popup-common.c: wnbp_common_get_focus_app(136) > fg_app : 10
09-17 11:28:46.931-0700 I/TIZEN_N_SOUND_MANAGER( 3580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
09-17 11:28:46.931-0700 I/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_get_active_app_id(1010) > [3625]
09-17 11:28:46.931-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2758].
09-17 11:28:46.931-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(89245482)
09-17 11:28:46.931-0700 E/ALARM_MANAGER( 2514): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(727368127) is OVER.
09-17 11:28:46.941-0700 I/TDM     ( 2006): tdm_display.c: tdm_layer_set_info(1442) > [367.590885] layer(0x5032e8) not usable
09-17 11:28:46.941-0700 I/TDM     ( 2006): tdm_display.c: tdm_layer_set_info(1459) > [367.590924] layer(0x5032e8) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
09-17 11:28:46.941-0700 I/TDM     ( 2006): tdm_exynos_display.c: exynos_layer_set_info(1578) > [367.590942] layer[0x502e38]zpos[1]
09-17 11:28:46.941-0700 I/TDM     ( 2006): tdm_display.c: tdm_layer_set_info(1442) > [367.591019] layer(0x503338) not usable
09-17 11:28:46.941-0700 I/TDM     ( 2006): tdm_display.c: tdm_layer_set_info(1459) > [367.591031] layer(0x503338) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
09-17 11:28:46.941-0700 I/TDM     ( 2006): tdm_exynos_display.c: exynos_layer_set_info(1578) > [367.591045] layer[0x502f58]zpos[2]
09-17 11:28:46.941-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_get_view_lock_state(666) > ::UI:: lock state=0000
09-17 11:28:46.941-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_draw_noti_view(1178) > [46871, 1, 0, 4, 0000]
09-17 11:28:46.941-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_draw_noti_view(1179) > [0, 1, 0]
09-17 11:28:46.941-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_draw_noti_view(1180) > [10, 0, 1, 0]
09-17 11:28:46.971-0700 W/TIZEN_N_SOUND_MANAGER( 3580): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
09-17 11:28:46.991-0700 W/WAKEUP-SERVICE( 3580): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
09-17 11:28:46.991-0700 I/HIGEAR  ( 3580): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
09-17 11:28:46.991-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_view_lock(588) > ::UI:: [[[ ===> [simple popup] is LOCK, 0001 ]]]
09-17 11:28:46.991-0700 I/wnotibp ( 3625): wnotiboard-popup-view.c: _view_create_detail_layout(3596) > wnotiboard_popup_vi_type: 1
09-17 11:28:46.991-0700 I/wnotibp ( 3625): wnotiboard-popup-view.c: _view_create_detail_layout(3601) > (46871, 46871)
09-17 11:28:47.001-0700 I/efl-extension( 3625): efl_extension_circle_surface.c: eext_circle_surface_layout_add(1290) > Put the surface[0xf304b3b8]'s widget[0xed85ac40] to layout widget[0xed85a4e8]
09-17 11:28:47.021-0700 I/wnotibp ( 3625): wnotiboard-popup-view.c: _view_create_genlist(3530) > (46871, 46871)
09-17 11:28:47.031-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
09-17 11:28:47.031-0700 W/SHealthService( 3630): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
09-17 11:28:47.041-0700 I/wnotibp ( 3625): wnotiboard-popup-view.c: _view_create_card_data(3034) > 0xf8089f58, 0xf8089de0, 0xf8089f58
09-17 11:28:47.051-0700 I/wnotibp ( 3625): wnotiboard-popup-view.c: wnbp_view_draw_simple_popup(3807) > alert_type : 1, is_source_companion: 1
09-17 11:28:47.061-0700 I/CAPI_NETWORK_CONNECTION( 6164): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:47.111-0700 W/W_HOME  ( 2907): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
09-17 11:28:47.111-0700 W/W_HOME  ( 2907): gesture.c: _manual_render_enable(138) > 0
09-17 11:28:47.111-0700 W/W_HOME  ( 2907): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
09-17 11:28:47.171-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-17 11:28:47.171-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-17 11:28:47.171-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 17-9-2017, 18:37:32 (UTC).
09-17 11:28:47.171-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-17 11:28:47.171-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: wnbp_view_draw_simple_popup(3813) > Manually lock the display.
09-17 11:28:47.171-0700 I/wnotibp ( 3625): wnotiboard-popup-common.c: wnbp_common_change_win_level(629) > current : 8, 0, 1, 0
09-17 11:28:47.181-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-17 11:28:47.191-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[89245482] is removed.
09-17 11:28:47.191-0700 W/STARTER ( 2758): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [powerkey]
09-17 11:28:47.191-0700 W/STARTER ( 2758): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
09-17 11:28:47.201-0700 E/EFL     ( 3625): elementary<3625> elm_genlist.c:7233 elm_genlist_item_item_class_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
09-17 11:28:47.201-0700 W/wnotibp ( 3625): w-notification-board-basic-panel-common.c: _wnb_bp_expand_basic_gl_group_content_get(2248) > Unhandled part: stack.separator
09-17 11:28:47.201-0700 I/wnotibp ( 3625): w-notification-board-common.c: wnb_common_get_application_icon(1704) > application_id: 11244, thumbnail path: /opt/usr/data/wnoti/.app_icon_11244.png, summary_large_image path: (null), width: 58, height: 58
09-17 11:28:47.211-0700 I/wnotibp ( 3625): w-notification-board-common.c: wnb_common_get_application_icon(1704) > application_id: 11244, thumbnail path: /opt/usr/data/wnoti/.app_icon_11244.png, summary_large_image path: (null), width: 130, height: 130
09-17 11:28:47.211-0700 W/wnotibp ( 3625): w-notification-board-basic-panel-common.c: _wnb_bp_expand_basic_gl_group_content_get(2248) > Unhandled part: more.btn
09-17 11:28:47.221-0700 I/efl-extension( 3625): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
09-17 11:28:47.231-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: _view_create_drawer(3497) > ::APP:: current id is 46871
09-17 11:28:47.231-0700 D/bitcoinwatch( 6164): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:47.231-0700 I/wnotibp ( 3625): wnotiboard-popup-view.c: _view_create_drawer(3500) > Initialize the action drawer and set the default item id.
09-17 11:28:47.231-0700 I/wnotibp ( 3625): w-notification-board-action.c: wnb_action_initialize(5222) > Init drawer.
09-17 11:28:47.231-0700 I/efl-extension( 3625): efl_extension_more_option.c: eext_more_option_add(323) > called!!
09-17 11:28:47.231-0700 I/efl-extension( 3625): efl_extension_more_option.c: _drawer_layout_create(183) > called!!
09-17 11:28:47.231-0700 I/efl-extension( 3625): efl_extension_more_option.c: _more_option_data_init(246) > mold is initialized!!
09-17 11:28:47.231-0700 I/efl-extension( 3625): efl_extension_more_option.c: _panel_create(202) > called!!
09-17 11:28:47.241-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_add(1990) > called!!
09-17 11:28:47.241-0700 D/bitcoinwatch( 6164): Size: 3
09-17 11:28:47.241-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _eext_rotary_selector_data_init(586) > rsd is initialized!!
09-17 11:28:47.241-0700 D/bitcoinwatch( 6164): Rate: 3731.85
09-17 11:28:47.241-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
09-17 11:28:47.241-0700 E/bitcoinwatch( 6164): updated bitcoin
09-17 11:28:47.241-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _event_area_callback_add(500) > called!!
09-17 11:28:47.251-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _rotary_selector_show_cb(805) > called!!
09-17 11:28:47.251-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _items_invalidate(919) > item_count is zero!!
09-17 11:28:47.251-0700 I/wnotibp ( 3625): w-notification-board-common.c: wnb_common_create_sending_popup(6262) > progress_start: 0, use_requesting: 0.
09-17 11:28:47.271-0700 W/WATCH_CORE( 6164): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:28:47.271-0700 W/SHealthService( 3630): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
09-17 11:28:47.281-0700 E/WIDGET_PROVIDER_APP( 6164): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:28:47.281-0700 W/wnotibp ( 3625): w-notification-board-action.c: wnb_action_set_item_info(4870) > db_id: 46871, category_id: 6079, application_id: 11244, clear_all_items: 0
09-17 11:28:47.281-0700 I/wnotibp ( 3625): w-notification-board-action.c: _wnb_action_create_pages(3896) > Create drawer pages for 6079, 11244
09-17 11:28:47.281-0700 I/efl-extension( 3625): efl_extension_more_option.c: eext_more_option_item_append(456) > called!!
09-17 11:28:47.281-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
09-17 11:28:47.291-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2394) > called!!
09-17 11:28:47.291-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
09-17 11:28:47.291-0700 I/efl-extension( 3625): efl_extension_more_option.c: eext_more_option_item_append(456) > called!!
09-17 11:28:47.291-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
09-17 11:28:47.291-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2394) > called!!
09-17 11:28:47.291-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
09-17 11:28:47.291-0700 I/wnotibp ( 3625): w-notification-board-action.c: _wnb_action_create_pages(4659) > csc_sales_code is VZW.
09-17 11:28:47.291-0700 I/efl-extension( 3625): efl_extension_more_option.c: eext_more_option_item_append(456) > called!!
09-17 11:28:47.291-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
09-17 11:28:47.301-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2394) > called!!
09-17 11:28:47.301-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
09-17 11:28:47.301-0700 I/wnotibp ( 3625): w-notification-board-action.c: _wnb_action_create_pages(4681) > Number of pages: 3 for 11244
09-17 11:28:47.321-0700 I/WATCH_CORE( 6164): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:28:47.321-0700 W/SHealthService( 3630): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
09-17 11:28:47.321-0700 I/WATCH_CORE( 6164): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:28:47.321-0700 I/WATCH_CORE( 6164): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:28:47.321-0700 I/WATCH_CORE( 6164): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:28:47.341-0700 E/EFL     ( 3625): evas_main<3625> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
09-17 11:28:47.341-0700 E/EFL     ( 3625): evas_main<3625> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
09-17 11:28:47.341-0700 E/EFL     ( 3625): evas_main<3625> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
09-17 11:28:47.341-0700 I/wnotibp ( 3625): w-notification-board-common.c: wnb_common_get_application_icon(1704) > application_id: 11244, thumbnail path: /opt/usr/data/wnoti/.app_icon_11244.png, summary_large_image path: (null), width: 58, height: 58
09-17 11:28:47.341-0700 I/wnotibp ( 3625): w-notification-board-common.c: wnb_common_get_application_icon(1704) > application_id: 11244, thumbnail path: /opt/usr/data/wnoti/.app_icon_11244.png, summary_large_image path: (null), width: 130, height: 130
09-17 11:28:47.341-0700 W/wnotibp ( 3625): w-notification-board-basic-panel-common.c: _wnb_bp_expand_basic_gl_group_content_get(2248) > Unhandled part: more.btn
09-17 11:28:47.371-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
09-17 11:28:47.371-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
09-17 11:28:47.401-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
09-17 11:28:47.421-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: wnbp_view_show_detail_view(1399) > ::APP:: Start VI by watch-face
09-17 11:28:47.421-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_view_lock(588) > ::UI:: [[[ ===> [detail view in simple popup] is LOCK, 0101 ]]]
09-17 11:28:47.421-0700 I/wnotibp ( 3625): wnotiboard-popup-view.c: _view_display_lock(1353) > is_display_locked: 1
09-17 11:28:47.421-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: _view_display_lock(1373) > lock lcd
09-17 11:28:47.431-0700 I/efl-extension( 3625): efl_extension_more_option.c: _cue_hide_cb(283) > called!!
09-17 11:28:47.431-0700 I/APP_CORE( 3625): appcore-efl.c: __do_app(453) > [APP 3625] Event: RESUME State: RUNNING
09-17 11:28:47.461-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _item_update_animator_cb(1414) > called
09-17 11:28:47.461-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: _item_update_animator_cb(1423) > item_list(0x-129554160), count(3)
09-17 11:28:47.461-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:28:47.461-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:28:47.461-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: _view_vi_setup_idler_cb(2771) > ::UI:: VI TYPE : 1
09-17 11:28:47.461-0700 I/wnotibp ( 3625): wnotiboard-popup-common.c: wnbp_common_get_block_mode(531) > Returning false.
09-17 11:28:47.461-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: _view_vi_setup_idler_cb(2778) > alert_type : 1, is_source_companion: 1, is_do_not_disturb: 0
09-17 11:28:47.461-0700 I/efl-extension( 3625): efl_extension_more_option.c: _panel_inactive_cb(97) > more_option is closed!!
09-17 11:28:47.461-0700 I/wnotibp ( 3625): w-notification-board-action.c: _wnb_action_closed(5050) > More option closed!
09-17 11:28:47.461-0700 I/wnotibp ( 3625): w-notification-board-action.c: _wnb_action_closed(5053) > Set the rotary focus to the parent of drawer: 0xf301a890
09-17 11:28:47.461-0700 W/wnotibp ( 3625): w-notification-board-common.c: wnb_common_pass_rotary_focus_to_top_object(6660) > _wnb_common_rotary_focus_owner_list cnt [0], you can't pass rotray focus.
09-17 11:28:47.461-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf30ef8a8, elm_layout, _activated_obj : 0x0, activated : 0
09-17 11:28:47.461-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_selected_item_get(2961) > called!!
09-17 11:28:47.461-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_selected_item_set(2922) > called!!
09-17 11:28:47.461-0700 I/efl-extension( 3625): efl_extension_rotary_selector.c: eext_rotary_selector_selected_item_set(2955) > selected item index(0)
09-17 11:28:47.461-0700 W/efl-extension( 3625): efl_extension_events.c: eext_object_event_callback_del(325) > This object(0xf30ee128) hasn't been registered before
09-17 11:28:47.461-0700 W/SHealthCommon( 3630): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
09-17 11:28:47.601-0700 W/SHealthService( 3630): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
09-17 11:28:47.631-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:28:47.641-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6164
09-17 11:28:47.641-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:28:47.851-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: _view_simple_popup_show_finished_cb(1104) > ::UI:: popup effect is finished (46871, f82c45f8)
09-17 11:28:47.851-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_view_unlock(638) > ::UI:: [[[ [simple popup] is UNLOCK , 0100 <=== ]]]
09-17 11:28:47.851-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_view_unlock(655) > ::UI:: wating unlock.
09-17 11:28:47.891-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11054586269741505672320
09-17 11:28:48.121-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: wnbp_view_detail_view_by_timer_cb(1295) > ::APP:: view state=2, f82c45f8
09-17 11:28:48.121-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: _view_vi_start(953) > ::APP:: view_state=3
09-17 11:28:48.121-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_view_lock(585) > ::UI:: [[[ ===> already [detail view in simple popup] is LOCK, 0100 ]]]
09-17 11:28:48.131-0700 I/AUL_PAD ( 6190): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:28:48.721-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_view_unlock(638) > ::UI:: [[[ [detail view in simple popup] is UNLOCK , 0000 <=== ]]]
09-17 11:28:48.721-0700 I/efl-extension( 3625): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf301a890, elm_genlist, _activated_obj : 0x0, activated : 1
09-17 11:28:48.721-0700 I/wnotibp ( 3625): wnotiboard-popup-view.c: _view_simple_vi_end_idler_cb(677) > Set the drawer 0xed831838 again.
09-17 11:28:48.721-0700 W/wnotibp ( 3625): wnotiboard-popup-view.c: _view_simple_vi_end_idler_cb(681) > ::UI:: SIMPLE_POPUP_TAP (-131316232)
09-17 11:28:48.731-0700 E/wnoti-service( 3235): wnoti-server-mgr-stub.c: __wnoti_change_new_flag_stub(3101) > change_type : 1, value : 46871
09-17 11:28:48.731-0700 E/wnoti-service( 3235): wnoti-utility.c: wnoti_get_new_flag_count(908) > >> count : 0
09-17 11:28:48.731-0700 E/wnoti-service( 3235): wnoti-msg-builder.c: _publish_notification(1565) > operation_type : 9, source : 0, application_id : 0, display_count : 0, 
09-17 11:28:48.731-0700 E/wnoti-proxy( 2907): wnoti-client.c: on_wnoti_event(1026) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2907, caller_id : 0, listener_type : 9
09-17 11:28:48.741-0700 I/wnotibp ( 3625): wnotiboard-popup-common.c: wnbp_common_change_win_level(629) > current : 12, 1, 2, 1
09-17 11:28:48.741-0700 I/efl-extension( 3625): efl_extension_more_option.c: _cue_show_cb(293) > called!!
09-17 11:28:48.761-0700 E/wnoti-proxy( 3625): wnoti-client.c: on_wnoti_event(1026) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 3625, caller_id : 0, listener_type : 9
09-17 11:28:48.881-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(787) > Change type : 9, op_type: 0, category_id: 0, display count: 0
09-17 11:28:48.881-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: wnb_nm_control_home_indicator(59) > Hide home indicator.
09-17 11:28:48.881-0700 W/W_HOME  ( 2907): noti_broker.c: _handler_noti_indicator_hide(496) > 
09-17 11:28:48.891-0700 E/wnoti-service( 3235): wnoti-server-mgr-stub.c: __wnoti_change_new_flag_stub(3101) > change_type : 0, value : 0
09-17 11:28:48.951-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11054876269741505672325
09-17 11:28:50.381-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6164 pgid = 6164
09-17 11:28:50.381-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:28:50.381-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(6164)
09-17 11:28:50.381-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:28:50.381-0700 E/AUL_AMD ( 2557): amd_request.c: __app_process_by_pid(201) > pid(6164) is dead. cmd(4) is canceled
09-17 11:28:50.381-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-3)
09-17 11:28:50.391-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:28:50.391-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:28:50.401-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:50.421-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:50.421-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:28:50.421-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:28:50.441-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:28:50.451-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:28:50.481-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:28:50.491-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:28:50.491-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:28:50.491-0700 W/AUL_PAD ( 6190): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:28:50.491-0700 W/AUL_PAD ( 6190): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:28:50.491-0700 W/AUL_PAD ( 6190): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:28:50.491-0700 W/AUL_PAD ( 6190): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:28:50.521-0700 W/AUL_PAD ( 6190): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:28:50.521-0700 W/AUL_PAD ( 6190): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:28:50.521-0700 I/CAPI_WATCH_APPLICATION( 6190): watch_app_main.c: watch_app_main(399) > watch_app_main
09-17 11:28:50.591-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.bitcoinwatch) pid(6190) type(watchapp) bg(0)
09-17 11:28:50.591-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6190)
09-17 11:28:50.591-0700 W/AUL_AMD ( 2557): amd_status.c: __socket_monitor_cb(1277) > (6190) was created
09-17 11:28:50.591-0700 E/AUL     ( 2557): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-17 11:28:50.591-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6164
09-17 11:28:50.591-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6164)
09-17 11:28:50.591-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6190]
09-17 11:28:50.641-0700 W/WATCH_CORE( 6190): appcore-watch.c: __widget_create(1068) > widget_create
09-17 11:28:50.641-0700 I/CAPI_WATCH_APPLICATION( 6190): watch_app_main.c: watch_app_get_elm_win(663) > watch hwc mode is enabled
09-17 11:28:50.751-0700 D/bitcoinwatch( 6190): 0
09-17 11:28:50.901-0700 I/CAPI_NETWORK_CONNECTION( 6190): connection.c: connection_create(453) > New handle created[0xf2d00518]
09-17 11:28:51.001-0700 I/CAPI_NETWORK_CONNECTION( 6190): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:51.081-0700 D/bitcoinwatch( 6190): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:51.081-0700 D/bitcoinwatch( 6190): Size: 3
09-17 11:28:51.081-0700 D/bitcoinwatch( 6190): Rate: 3731.85
09-17 11:28:51.081-0700 E/bitcoinwatch( 6190): updated bitcoin
09-17 11:28:51.081-0700 I/CAPI_NETWORK_CONNECTION( 6190): connection.c: connection_create(453) > New handle created[0xf7d67160]
09-17 11:28:51.151-0700 I/CAPI_NETWORK_CONNECTION( 6190): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:51.231-0700 D/bitcoinwatch( 6190): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:51.231-0700 D/bitcoinwatch( 6190): Size: 3
09-17 11:28:51.231-0700 D/bitcoinwatch( 6190): Rate: 3731.85
09-17 11:28:51.231-0700 E/bitcoinwatch( 6190): updated bitcoin
09-17 11:28:51.241-0700 W/WATCH_CORE( 6190): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:28:51.281-0700 E/WIDGET_PROVIDER_APP( 6190): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:28:51.291-0700 I/WATCH_CORE( 6190): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:28:51.291-0700 I/WATCH_CORE( 6190): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:28:51.291-0700 I/WATCH_CORE( 6190): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:28:51.301-0700 I/WATCH_CORE( 6190): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:28:51.591-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:28:51.591-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:28:51.661-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:28:51.661-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6190
09-17 11:28:51.671-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:28:52.411-0700 I/AUL_PAD ( 6264): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:28:54.421-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(6190)
09-17 11:28:54.421-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:28:54.421-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6190 pgid = 6190
09-17 11:28:54.421-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:28:54.431-0700 E/AUL_AMD ( 2557): amd_request.c: __app_process_by_pid(201) > pid(6190) is dead. cmd(4) is canceled
09-17 11:28:54.431-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-3)
09-17 11:28:54.431-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:28:54.431-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:28:54.441-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:54.451-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:54.451-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:28:54.451-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:28:54.501-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:28:54.501-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:28:54.531-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:28:54.531-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:28:54.531-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:28:54.541-0700 W/AUL_PAD ( 6264): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:28:54.541-0700 W/AUL_PAD ( 6264): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:28:54.541-0700 W/AUL_PAD ( 6264): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:28:54.541-0700 W/AUL_PAD ( 6264): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:28:54.561-0700 W/AUL_PAD ( 6264): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:28:54.561-0700 W/AUL_PAD ( 6264): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:28:54.561-0700 I/CAPI_WATCH_APPLICATION( 6264): watch_app_main.c: watch_app_main(399) > watch_app_main
09-17 11:28:54.631-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.bitcoinwatch) pid(6264) type(watchapp) bg(0)
09-17 11:28:54.641-0700 W/AUL_AMD ( 2557): amd_status.c: __socket_monitor_cb(1277) > (6264) was created
09-17 11:28:54.641-0700 E/AUL     ( 2557): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-17 11:28:54.641-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6190
09-17 11:28:54.641-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6190)
09-17 11:28:54.641-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6264)
09-17 11:28:54.641-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6264]
09-17 11:28:54.681-0700 W/WATCH_CORE( 6264): appcore-watch.c: __widget_create(1068) > widget_create
09-17 11:28:54.681-0700 I/CAPI_WATCH_APPLICATION( 6264): watch_app_main.c: watch_app_get_elm_win(663) > watch hwc mode is enabled
09-17 11:28:54.771-0700 D/bitcoinwatch( 6264): 0
09-17 11:28:54.871-0700 I/CAPI_NETWORK_CONNECTION( 6264): connection.c: connection_create(453) > New handle created[0xf7795478]
09-17 11:28:54.951-0700 I/CAPI_NETWORK_CONNECTION( 6264): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:55.031-0700 D/bitcoinwatch( 6264): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:55.031-0700 D/bitcoinwatch( 6264): Size: 3
09-17 11:28:55.031-0700 D/bitcoinwatch( 6264): Rate: 3731.85
09-17 11:28:55.031-0700 E/bitcoinwatch( 6264): updated bitcoin
09-17 11:28:55.041-0700 I/CAPI_NETWORK_CONNECTION( 6264): connection.c: connection_create(453) > New handle created[0xf7790800]
09-17 11:28:55.091-0700 I/CAPI_NETWORK_CONNECTION( 6264): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:55.161-0700 D/bitcoinwatch( 6264): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:55.161-0700 D/bitcoinwatch( 6264): Size: 3
09-17 11:28:55.161-0700 D/bitcoinwatch( 6264): Rate: 3731.85
09-17 11:28:55.161-0700 E/bitcoinwatch( 6264): updated bitcoin
09-17 11:28:55.171-0700 W/WATCH_CORE( 6264): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:28:55.191-0700 E/WIDGET_PROVIDER_APP( 6264): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:28:55.211-0700 I/WATCH_CORE( 6264): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:28:55.211-0700 I/WATCH_CORE( 6264): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:28:55.211-0700 I/WATCH_CORE( 6264): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:28:55.211-0700 I/WATCH_CORE( 6264): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:28:55.641-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:28:55.641-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:28:55.691-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:28:55.701-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6264
09-17 11:28:55.701-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:28:56.021-0700 I/AUL_PAD ( 6287): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:28:56.201-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11055146269741505672365
09-17 11:28:57.061-0700 W/SHealthService( 3630): CpuLock.cpp: CheckAndReset(167) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
09-17 11:28:57.071-0700 W/SHealthService( 3630): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
09-17 11:28:57.071-0700 W/SHealthService( 3630): CpuLock.cpp: CheckAndReset(174) > [1;40;33mRELEASE POWER LOCK CPU[0;m
09-17 11:28:57.151-0700 W/WG-CONSUMER( 3607): [34m[F:consumer-app.cpp L:  347][_HIGH]Checking consumer's state.[0m
09-17 11:28:57.151-0700 W/WG-CONSUMER( 3607): [34m[F:SAPProxy.cpp     L:  603][_HIGH]Device Connected. Cur type=BT|[0m
09-17 11:28:57.151-0700 W/WG-CONSUMER( 3607): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
09-17 11:28:57.151-0700 W/WG-CONSUMER( 3607): [34m[F:SAPProxy.cpp     L:  603][_HIGH]Device Connected. Cur type=BT|[0m
09-17 11:28:57.151-0700 W/WG-CONSUMER( 3607): [34m[F:SAPProxy.cpp     L:  186][_HIGH]Device connected. WMS=1 BT=1 [0m
09-17 11:28:57.151-0700 W/WG-CONSUMER( 3607): [34m[F:AutoTransfer.cpp L:  173][_HIGH]IsAutoTransferWaiting. bWaiting state=0[0m
09-17 11:28:57.151-0700 W/WG-CONSUMER( 3607): [34m[F:consumer-app.cpp L:  361][_HIGH]Receiver can be exit[0m
09-17 11:28:57.151-0700 W/WG-CONSUMER( 3607): [34m[F:consumer-app.cpp L:  364][_HIGH]Exit Condition. Tx=0 Rx=1[0m
09-17 11:28:57.541-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 1105539626974150567252
