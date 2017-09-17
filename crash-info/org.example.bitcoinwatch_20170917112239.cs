S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.3
Build-Number: R765VVRU1AQF4
Build-Date: 2017.07.17 17:00:49

Crash Information
Process Name: bitcoinwatch
PID: 5631
Date: 2017-09-17 11:22:39-0700
Executable File Path: /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x40739d06
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6f919b8, r5   = 0xf6f919b8
r6   = 0xf6f9116c, r7   = 0xf6f919b8
r8   = 0xf6f919b8, r9   = 0xf7905ff8
r10  = 0xf6f9fb10, fp   = 0x0000018f
ip   = 0x00000001, sp   = 0xffde1840
lr   = 0xf6f811f9, pc   = 0x00000000
cpsr = 0x60000030

Memory Information
MemTotal:   620380 KB
MemFree:     24748 KB
Buffers:     17020 KB
Cached:     146800 KB
VmPeak:      77552 KB
VmSize:      77552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24060 KB
VmRSS:       24060 KB
VmData:      20220 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       21132 KB
VmPTE:         112 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5631 TID = 5631
5631 5659 5665 

Maps Information
f2bf6000 f33f5000 rw-p [stack:5665]
f3492000 f34a9000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f34b6000 f34c1000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f34ca000 f34d5000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f34de000 f3cdd000 rw-p [stack:5659]
f3edd000 f3eed000 r-xp /usr/lib/libmdm-common.so.1.1.24
f3ef5000 f3f00000 r-xp /usr/lib/libtbm.so.1.0.0
f3f08000 f3f51000 r-xp /usr/lib/libmdm.so.1.2.69
f3f59000 f3f5f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f3f67000 f3f69000 r-xp /usr/lib/libdri2.so.0.0.0
f3f71000 f3f79000 r-xp /usr/lib/libdrm.so.2.4.0
f3f81000 f3f91000 r-xp /usr/lib/libwidget_provider.so.1.0.0
f3f99000 f3fa2000 r-xp /usr/lib/libcom-core.so.0.0.1
f5844000 f5849000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5851000 f586a000 r-xp /usr/lib/libnetwork.so.0.0.0
f5872000 f587c000 r-xp /usr/lib/libwidget.so.1.0.0
f5884000 f5897000 r-xp /usr/lib/libwidget_service.so.1.0.0
f58a0000 f58a7000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
f58b0000 f59b6000 r-xp /usr/lib/libicuuc.so.57.1
f59cc000 f5b54000 r-xp /usr/lib/libicui18n.so.57.1
f5b64000 f5b71000 r-xp /usr/lib/libalarm.so.0.0.0
f5b7b000 f5b8a000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f5b93000 f5ba3000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f5bab000 f5bb3000 r-xp /usr/lib/libappcore-watch.so.1.1
f5bc5000 f5bca000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f5d64000 f5d6e000 r-xp /lib/libnss_files-2.13.so
f5d77000 f5e46000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5e5c000 f5e80000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5e89000 f5e8f000 r-xp /usr/lib/libappsvc.so.0.1.0
f5e97000 f5e9b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5ea9000 f5eab000 r-xp /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
f5ebb000 f5ebd000 r-xp /usr/lib/libiniparser.so.0
f5ec6000 f5ecb000 r-xp /usr/lib/libappcore-common.so.1.1
f5ed3000 f5ed5000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5ede000 f5ee2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5eef000 f5ef1000 r-xp /usr/lib/libXau.so.6.0.0
f5ef9000 f5f00000 r-xp /lib/libcrypt-2.13.so
f5f30000 f5f32000 r-xp /usr/lib/libiri.so
f5f3b000 f60e4000 r-xp /usr/lib/libcrypto.so.1.0.0
f6104000 f614b000 r-xp /usr/lib/libssl.so.1.0.0
f6157000 f6185000 r-xp /usr/lib/libidn.so.11.5.44
f618d000 f6196000 r-xp /usr/lib/libcares.so.2.1.0
f61a0000 f61b3000 r-xp /usr/lib/libxcb.so.1.1.0
f61bc000 f61be000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f61c6000 f61c8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f61d1000 f629d000 r-xp /usr/lib/libxml2.so.2.7.8
f62aa000 f62ac000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f62b5000 f62ba000 r-xp /usr/lib/libffi.so.5.0.10
f62c2000 f62c3000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f62cb000 f62ce000 r-xp /lib/libattr.so.1.1.0
f62d6000 f636a000 r-xp /usr/lib/libstdc++.so.6.0.16
f637d000 f639a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f63a4000 f63bc000 r-xp /usr/lib/libpng12.so.0.50.0
f63c4000 f63da000 r-xp /lib/libexpat.so.1.6.0
f63e4000 f6428000 r-xp /usr/lib/libcurl.so.4.3.0
f6431000 f643b000 r-xp /usr/lib/libXext.so.6.4.0
f6444000 f6448000 r-xp /usr/lib/libXtst.so.6.1.0
f6450000 f6456000 r-xp /usr/lib/libXrender.so.1.3.0
f645e000 f6464000 r-xp /usr/lib/libXrandr.so.2.2.0
f646c000 f646d000 r-xp /usr/lib/libXinerama.so.1.0.0
f6476000 f647f000 r-xp /usr/lib/libXi.so.6.1.0
f6487000 f648a000 r-xp /usr/lib/libXfixes.so.3.1.0
f6492000 f6494000 r-xp /usr/lib/libXgesture.so.7.0.0
f649c000 f649e000 r-xp /usr/lib/libXcomposite.so.1.0.0
f64a6000 f64a8000 r-xp /usr/lib/libXdamage.so.1.1.0
f64b0000 f64b7000 r-xp /usr/lib/libXcursor.so.1.0.2
f64bf000 f64c2000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f64ca000 f64ce000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f64d7000 f64dc000 r-xp /usr/lib/libecore_fb.so.1.7.99
f64e5000 f65c6000 r-xp /usr/lib/libX11.so.6.3.0
f65d1000 f65f4000 r-xp /usr/lib/libjpeg.so.8.0.2
f660c000 f6622000 r-xp /lib/libz.so.1.2.5
f662a000 f662c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6634000 f66a9000 r-xp /usr/lib/libsqlite3.so.0.8.6
f66b3000 f66cd000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66d5000 f6709000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6712000 f67e5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67f0000 f6800000 r-xp /lib/libresolv-2.13.so
f6804000 f681c000 r-xp /usr/lib/liblzma.so.5.0.3
f6824000 f6827000 r-xp /lib/libcap.so.2.21
f682f000 f685e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6867000 f6868000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6870000 f6876000 r-xp /usr/lib/libecore_imf.so.1.7.99
f687e000 f6895000 r-xp /usr/lib/liblua-5.1.so
f689e000 f68a5000 r-xp /usr/lib/libembryo.so.1.7.99
f68ad000 f68b3000 r-xp /lib/librt-2.13.so
f68bc000 f6912000 r-xp /usr/lib/libpixman-1.so.0.28.2
f691f000 f6975000 r-xp /usr/lib/libfreetype.so.6.11.3
f6981000 f69a9000 r-xp /usr/lib/libfontconfig.so.1.8.0
f69aa000 f69ef000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f69f8000 f6a0b000 r-xp /usr/lib/libfribidi.so.0.3.1
f6a13000 f6a2d000 r-xp /usr/lib/libecore_con.so.1.7.99
f6a36000 f6a3f000 r-xp /usr/lib/libedbus.so.1.7.99
f6a47000 f6a97000 r-xp /usr/lib/libecore_x.so.1.7.99
f6a99000 f6aa2000 r-xp /usr/lib/libvconf.so.0.2.45
f6aaa000 f6abb000 r-xp /usr/lib/libecore_input.so.1.7.99
f6ac3000 f6ac8000 r-xp /usr/lib/libecore_file.so.1.7.99
f6ad0000 f6af2000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6afb000 f6b3c000 r-xp /usr/lib/libeina.so.1.7.99
f6b45000 f6b5e000 r-xp /usr/lib/libeet.so.1.7.99
f6b6f000 f6bd8000 r-xp /lib/libm-2.13.so
f6be1000 f6be7000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bf0000 f6bf1000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bf9000 f6c1c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c24000 f6c29000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c31000 f6c5b000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c64000 f6c7b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c83000 f6c8e000 r-xp /lib/libunwind.so.8.0.1
f6cbb000 f6cd9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ce3000 f6e07000 r-xp /lib/libc-2.13.so
f6e15000 f6e1d000 r-xp /lib/libgcc_s-4.6.so.1
f6e1e000 f6e22000 r-xp /usr/lib/libsmack.so.1.0.0
f6e2b000 f6e31000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6e39000 f6f09000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f0a000 f6f68000 r-xp /usr/lib/libedje.so.1.7.99
f6f72000 f6f89000 r-xp /usr/lib/libecore.so.1.7.99
f6fa0000 f706e000 r-xp /usr/lib/libevas.so.1.7.99
f7093000 f71cf000 r-xp /usr/lib/libelementary.so.1.7.99
f71e6000 f71fa000 r-xp /lib/libpthread-2.13.so
f7205000 f7207000 r-xp /usr/lib/libdlog.so.0.0.0
f720f000 f7212000 r-xp /usr/lib/libbundle.so.0.1.22
f721a000 f721c000 r-xp /lib/libdl-2.13.so
f7225000 f7232000 r-xp /usr/lib/libaul.so.0.1.0
f7244000 f724a000 r-xp /usr/lib/libappcore-efl.so.1.1
f7253000 f7257000 r-xp /usr/lib/libsys-assert.so
f7260000 f727d000 r-xp /lib/ld-2.13.so
f7286000 f728b000 r-xp /usr/bin/launchpad-loader
f78ce000 f7a9e000 rw-p [heap]
ffdc2000 ffde3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5631)
Call Stack Count: 2
 0: (0xf6f811f9) [/usr/lib/libecore.so.1] + 0xf1f9
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
4.431-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-3)
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
09-17 11:28:57.541-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11055396269741505672522
09-17 11:28:58.251-0700 E/WMS     ( 2513): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23476) > _wms_event_handler_cb_nomove_detector is called
09-17 11:28:58.341-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(6264)
09-17 11:28:58.341-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:28:58.341-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6264 pgid = 6264
09-17 11:28:58.341-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:28:58.351-0700 E/AUL_AMD ( 2557): amd_request.c: __app_process_by_pid(201) > pid(6264) is dead. cmd(4) is canceled
09-17 11:28:58.351-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-3)
09-17 11:28:58.351-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:28:58.351-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:28:58.361-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:58.361-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:28:58.361-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:28:58.361-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:28:58.421-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:28:58.421-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:28:58.461-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:28:58.461-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:28:58.461-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:28:58.461-0700 W/AUL_PAD ( 6287): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:28:58.461-0700 W/AUL_PAD ( 6287): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:28:58.461-0700 W/AUL_PAD ( 6287): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:28:58.461-0700 W/AUL_PAD ( 6287): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:28:58.491-0700 W/AUL_PAD ( 6287): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:28:58.491-0700 W/AUL_PAD ( 6287): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:28:58.491-0700 I/CAPI_WATCH_APPLICATION( 6287): watch_app_main.c: watch_app_main(399) > watch_app_main
09-17 11:28:58.561-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.bitcoinwatch) pid(6287) type(watchapp) bg(0)
09-17 11:28:58.561-0700 W/AUL_AMD ( 2557): amd_status.c: __socket_monitor_cb(1277) > (6287) was created
09-17 11:28:58.561-0700 E/AUL     ( 2557): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-17 11:28:58.561-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6264
09-17 11:28:58.561-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6264)
09-17 11:28:58.561-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6287]
09-17 11:28:58.561-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6287)
09-17 11:28:58.631-0700 W/WATCH_CORE( 6287): appcore-watch.c: __widget_create(1068) > widget_create
09-17 11:28:58.631-0700 I/CAPI_WATCH_APPLICATION( 6287): watch_app_main.c: watch_app_get_elm_win(663) > watch hwc mode is enabled
09-17 11:28:58.751-0700 D/bitcoinwatch( 6287): 0
09-17 11:28:58.831-0700 I/CAPI_NETWORK_CONNECTION( 6287): connection.c: connection_create(453) > New handle created[0xf77589f0]
09-17 11:28:58.891-0700 I/CAPI_NETWORK_CONNECTION( 6287): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:58.951-0700 D/bitcoinwatch( 6287): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:58.951-0700 D/bitcoinwatch( 6287): Size: 3
09-17 11:28:58.951-0700 D/bitcoinwatch( 6287): Rate: 3731.85
09-17 11:28:58.951-0700 E/bitcoinwatch( 6287): updated bitcoin
09-17 11:28:58.961-0700 I/CAPI_NETWORK_CONNECTION( 6287): connection.c: connection_create(453) > New handle created[0xf7756c58]
09-17 11:28:59.011-0700 I/CAPI_NETWORK_CONNECTION( 6287): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:28:59.071-0700 D/bitcoinwatch( 6287): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:28:59.071-0700 D/bitcoinwatch( 6287): Size: 3
09-17 11:28:59.071-0700 D/bitcoinwatch( 6287): Rate: 3731.85
09-17 11:28:59.071-0700 E/bitcoinwatch( 6287): updated bitcoin
09-17 11:28:59.081-0700 W/WATCH_CORE( 6287): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:28:59.091-0700 E/WIDGET_PROVIDER_APP( 6287): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:28:59.121-0700 I/WATCH_CORE( 6287): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:28:59.121-0700 I/WATCH_CORE( 6287): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:28:59.121-0700 I/WATCH_CORE( 6287): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:28:59.121-0700 I/WATCH_CORE( 6287): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:28:59.561-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:28:59.561-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:28:59.621-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:28:59.631-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6287
09-17 11:28:59.631-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:28:59.921-0700 I/AUL_PAD ( 6362): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:29:00.451-0700 W/APPS    ( 2907): apps_main.c: _time_changed_cb(308) >  date : 17->17
09-17 11:29:01.391-0700 W/WATCH_CORE( 6287): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
09-17 11:29:01.391-0700 I/WATCH_CORE( 6287): appcore-watch.c: __signal_lcd_status_handler(1235) > Skip the background tick update
09-17 11:29:01.391-0700 W/WAKEUP-SERVICE( 3580): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -148096244[0;m
09-17 11:29:01.391-0700 W/WAKEUP-SERVICE( 3580): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
09-17 11:29:01.391-0700 W/WAKEUP-SERVICE( 3580): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
09-17 11:29:01.391-0700 E/WAKEUP-SERVICE( 3580): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
09-17 11:29:01.401-0700 W/W_HOME  ( 2907): dbus.c: _dbus_message_recv_cb(204) > LCD off
09-17 11:29:01.401-0700 W/W_HOME  ( 2907): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
09-17 11:29:01.401-0700 W/W_HOME  ( 2907): gesture.c: _manual_render_disable_timer_del(157) > timer del
09-17 11:29:01.401-0700 W/W_HOME  ( 2907): gesture.c: _manual_render_enable(138) > 1
09-17 11:29:01.401-0700 W/W_HOME  ( 2907): event_manager.c: _lcd_off_cb(729) > lcd state: 0
09-17 11:29:01.401-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:29:01.401-0700 W/STARTER ( 2758): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
09-17 11:29:01.401-0700 W/STARTER ( 2758): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
09-17 11:29:01.401-0700 E/STARTER ( 2758): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
09-17 11:29:01.401-0700 E/STARTER ( 2758): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
09-17 11:29:01.401-0700 W/STARTER ( 2758): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
09-17 11:29:01.401-0700 W/STARTER ( 2758): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
09-17 11:29:01.411-0700 I/TDM     ( 2006): tdm_display.c: tdm_layer_unset_buffer(1602) > [382.063749] layer(0x503338) now usable
09-17 11:29:01.411-0700 I/TDM     ( 2006): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [382.063776] layer[0x502f58]zpos[2]
09-17 11:29:01.411-0700 I/TDM     ( 2006): tdm_display.c: tdm_layer_unset_buffer(1602) > [382.063800] layer(0x5032e8) now usable
09-17 11:29:01.411-0700 I/TDM     ( 2006): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [382.063811] layer[0x502e38]zpos[1]
09-17 11:29:01.411-0700 I/TDM     ( 2006): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [382.063826] dpms[0 -> 3]sync[1]
09-17 11:29:01.411-0700 I/TDM     ( 2006): 
09-17 11:29:01.421-0700 E/WAKEUP-SERVICE( 3580): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
09-17 11:29:01.421-0700 E/WAKEUP-SERVICE( 3580): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
09-17 11:29:01.421-0700 I/TIZEN_N_SOUND_MANAGER( 3580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
09-17 11:29:01.421-0700 I/TIZEN_N_SOUND_MANAGER( 3580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
09-17 11:29:01.431-0700 W/TIZEN_N_SOUND_MANAGER( 3580): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
09-17 11:29:01.431-0700 W/WAKEUP-SERVICE( 3580): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
09-17 11:29:01.431-0700 I/HIGEAR  ( 3580): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
09-17 11:29:01.541-0700 I/TDM     ( 2006): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [382.191110] dpms[3 -> 3]done
09-17 11:29:01.541-0700 I/TDM     ( 2006): 
09-17 11:29:01.541-0700 W/W_INDICATOR( 2759): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
09-17 11:29:01.541-0700 W/SHealthCommon( 3630): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
09-17 11:29:01.541-0700 W/SHealthService( 3630): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
09-17 11:29:01.551-0700 W/STARTER ( 2758): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
09-17 11:29:01.551-0700 W/STARTER ( 2758): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
09-17 11:29:01.551-0700 W/STARTER ( 2758): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
09-17 11:29:01.551-0700 W/STARTER ( 2758): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
09-17 11:29:01.551-0700 E/ALARM_MANAGER( 2758): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(17-9-2017, 11:29:22), repeat(1), interval(20), type(-1073741822)
09-17 11:29:01.551-0700 W/W_INDICATOR( 2759): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
09-17 11:29:01.551-0700 W/W_INDICATOR( 2759): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
09-17 11:29:01.551-0700 W/W_INDICATOR( 2759): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
09-17 11:29:01.561-0700 I/APP_CORE( 3625): appcore-efl.c: __do_app(453) > [APP 3625] Event: PAUSE State: RUNNING
09-17 11:29:01.561-0700 I/CAPI_APPFW_APPLICATION( 3625): app_main.c: app_appcore_pause(202) > app_appcore_pause
09-17 11:29:01.571-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2758].
09-17 11:29:01.591-0700 W/wnotibp ( 3625): wnotiboard-popup-common.c: wnbp_common_get_focus_app(136) > fg_app : 10
09-17 11:29:01.591-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_get_view_lock_state(666) > ::UI:: lock state=0000
09-17 11:29:01.591-0700 W/wnotibp ( 3625): wnotiboard-popup.c: _popup_app_pause(220) > [1, 0, 4, 0000]
09-17 11:29:01.591-0700 W/wnotibp ( 3625): wnotiboard-popup.c: _popup_app_pause(221) > [10, 10]
09-17 11:29:01.591-0700 W/wnotibp ( 3625): wnotiboard-popup.c: _popup_app_pause(222) > [1, 0, 4, 2, f82c45f8]
09-17 11:29:01.601-0700 E/ALARM_MANAGER( 2514): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 605505534, next duetime: 1505672962
09-17 11:29:01.601-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(605505534)
09-17 11:29:01.601-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1505673452), due_time(1505672962)
09-17 11:29:01.601-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
09-17 11:29:01.601-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
09-17 11:29:01.601-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 17-9-2017, 18:29:22 (UTC).
09-17 11:29:01.601-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
09-17 11:29:01.611-0700 E/ALARM_MANAGER( 2514): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
09-17 11:29:02.231-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6287 pgid = 6287
09-17 11:29:02.231-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:29:02.231-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(6287)
09-17 11:29:02.241-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:29:02.241-0700 E/AUL_AMD ( 2557): amd_request.c: __app_process_by_pid(201) > pid(6287) is dead. cmd(4) is canceled
09-17 11:29:02.241-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-3)
09-17 11:29:02.241-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:29:02.241-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:29:02.251-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:29:02.261-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:29:02.261-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:29:02.261-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:29:02.311-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:29:02.321-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:29:02.351-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:29:02.351-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:29:02.361-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:29:02.361-0700 W/AUL_PAD ( 6362): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:29:02.361-0700 W/AUL_PAD ( 6362): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:29:02.361-0700 W/AUL_PAD ( 6362): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:29:02.361-0700 W/AUL_PAD ( 6362): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:29:02.391-0700 W/AUL_PAD ( 6362): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:29:02.391-0700 W/AUL_PAD ( 6362): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:29:02.391-0700 I/CAPI_WATCH_APPLICATION( 6362): watch_app_main.c: watch_app_main(399) > watch_app_main
09-17 11:29:02.461-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.bitcoinwatch) pid(6362) type(watchapp) bg(0)
09-17 11:29:02.461-0700 W/AUL_AMD ( 2557): amd_status.c: __socket_monitor_cb(1277) > (6362) was created
09-17 11:29:02.461-0700 E/AUL     ( 2557): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-17 11:29:02.461-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6287
09-17 11:29:02.461-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6287)
09-17 11:29:02.461-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6362)
09-17 11:29:02.461-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6362]
09-17 11:29:02.491-0700 W/WATCH_CORE( 6362): appcore-watch.c: __widget_create(1068) > widget_create
09-17 11:29:02.491-0700 I/CAPI_WATCH_APPLICATION( 6362): watch_app_main.c: watch_app_get_elm_win(663) > watch hwc mode is enabled
09-17 11:29:02.591-0700 D/bitcoinwatch( 6362): 0
09-17 11:29:02.711-0700 I/CAPI_NETWORK_CONNECTION( 6362): connection.c: connection_create(453) > New handle created[0xf74d5990]
09-17 11:29:02.791-0700 I/CAPI_NETWORK_CONNECTION( 6362): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:29:03.161-0700 W/MUSIC_TRANSFER( 3608): mt-auto-transfer.c: _bettery_capacity_changed_cb(412) > [33m[TID:3608]   battery capacity = 84%[0m
09-17 11:29:03.161-0700 W/WG-CONSUMER( 3607): [34m[F:AutoTransfer.cpp L:   75][_HIGH]battery capacity = 84%, charging = 0[0m
09-17 11:29:03.171-0700 D/bitcoinwatch( 6362): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:29:03.181-0700 D/bitcoinwatch( 6362): Size: 3
09-17 11:29:03.181-0700 D/bitcoinwatch( 6362): Rate: 3731.85
09-17 11:29:03.181-0700 E/bitcoinwatch( 6362): updated bitcoin
09-17 11:29:03.181-0700 I/CAPI_NETWORK_CONNECTION( 6362): connection.c: connection_create(453) > New handle created[0xf7494fd0]
09-17 11:29:03.251-0700 I/CAPI_NETWORK_CONNECTION( 6362): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:29:03.311-0700 D/bitcoinwatch( 6362): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:29:03.311-0700 D/bitcoinwatch( 6362): Size: 3
09-17 11:29:03.311-0700 D/bitcoinwatch( 6362): Rate: 3731.85
09-17 11:29:03.311-0700 E/bitcoinwatch( 6362): updated bitcoin
09-17 11:29:03.321-0700 W/WATCH_CORE( 6362): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:29:03.351-0700 E/WIDGET_PROVIDER_APP( 6362): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:29:03.361-0700 I/WATCH_CORE( 6362): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:29:03.361-0700 I/WATCH_CORE( 6362): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:29:03.361-0700 I/WATCH_CORE( 6362): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:29:03.361-0700 I/WATCH_CORE( 6362): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:29:03.471-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:29:03.471-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:29:03.551-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:29:03.561-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6362
09-17 11:29:03.561-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:29:03.871-0700 I/AUL_PAD ( 6390): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:29:04.511-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11055726269741505672526
09-17 11:29:05.871-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11055976269741505672541
09-17 11:29:06.481-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6362 pgid = 6362
09-17 11:29:06.481-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:29:06.481-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(6362)
09-17 11:29:06.481-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:29:06.491-0700 E/AUL_AMD ( 2557): amd_request.c: __app_process_by_pid(201) > pid(6362) is dead. cmd(4) is canceled
09-17 11:29:06.491-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-3)
09-17 11:29:06.491-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:29:06.491-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:29:06.501-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:29:06.501-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:29:06.501-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:29:06.511-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:29:06.571-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:29:06.581-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:29:06.591-0700 I/APP_CORE( 3625): appcore-efl.c: __do_app(453) > [APP 3625] Event: MEM_FLUSH State: PAUSED
09-17 11:29:06.611-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:29:06.611-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:29:06.611-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:29:06.621-0700 W/AUL_PAD ( 6390): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:29:06.621-0700 W/AUL_PAD ( 6390): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:29:06.621-0700 W/AUL_PAD ( 6390): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:29:06.621-0700 W/AUL_PAD ( 6390): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:29:06.641-0700 W/AUL_PAD ( 6390): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:29:06.641-0700 W/AUL_PAD ( 6390): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:29:06.641-0700 I/CAPI_WATCH_APPLICATION( 6390): watch_app_main.c: watch_app_main(399) > watch_app_main
09-17 11:29:06.711-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.bitcoinwatch) pid(6390) type(watchapp) bg(0)
09-17 11:29:06.721-0700 W/AUL_AMD ( 2557): amd_status.c: __socket_monitor_cb(1277) > (6390) was created
09-17 11:29:06.721-0700 E/AUL     ( 2557): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-17 11:29:06.721-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6362
09-17 11:29:06.721-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6362)
09-17 11:29:06.721-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6390)
09-17 11:29:06.721-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6390]
09-17 11:29:06.761-0700 W/WATCH_CORE( 6390): appcore-watch.c: __widget_create(1068) > widget_create
09-17 11:29:06.761-0700 I/CAPI_WATCH_APPLICATION( 6390): watch_app_main.c: watch_app_get_elm_win(663) > watch hwc mode is enabled
09-17 11:29:06.861-0700 D/bitcoinwatch( 6390): 0
09-17 11:29:06.951-0700 I/CAPI_NETWORK_CONNECTION( 6390): connection.c: connection_create(453) > New handle created[0xf75c3028]
09-17 11:29:07.001-0700 I/CAPI_NETWORK_CONNECTION( 6390): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:29:07.091-0700 D/bitcoinwatch( 6390): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:29:07.091-0700 D/bitcoinwatch( 6390): Size: 3
09-17 11:29:07.091-0700 D/bitcoinwatch( 6390): Rate: 3731.85
09-17 11:29:07.091-0700 E/bitcoinwatch( 6390): updated bitcoin
09-17 11:29:07.091-0700 I/CAPI_NETWORK_CONNECTION( 6390): connection.c: connection_create(453) > New handle created[0xf7581218]
09-17 11:29:07.181-0700 I/CAPI_NETWORK_CONNECTION( 6390): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:29:07.231-0700 D/bitcoinwatch( 6390): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:29:07.231-0700 D/bitcoinwatch( 6390): Size: 3
09-17 11:29:07.231-0700 D/bitcoinwatch( 6390): Rate: 3731.85
09-17 11:29:07.231-0700 E/bitcoinwatch( 6390): updated bitcoin
09-17 11:29:07.241-0700 W/WATCH_CORE( 6390): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:29:07.301-0700 E/WIDGET_PROVIDER_APP( 6390): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:29:07.311-0700 I/WATCH_CORE( 6390): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:29:07.311-0700 I/WATCH_CORE( 6390): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:29:07.311-0700 I/WATCH_CORE( 6390): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:29:07.311-0700 I/WATCH_CORE( 6390): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:29:07.721-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:29:07.721-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:29:07.801-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:29:07.801-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6390
09-17 11:29:07.801-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:29:07.981-0700 I/AUL_PAD ( 6467): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:29:10.391-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6390 pgid = 6390
09-17 11:29:10.391-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:29:10.431-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(6390)
09-17 11:29:10.431-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:29:10.431-0700 E/AUL_AMD ( 2557): amd_request.c: __app_process_by_pid(201) > pid(6390) is dead. cmd(4) is canceled
09-17 11:29:10.431-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-3)
09-17 11:29:10.431-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:29:10.431-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:29:10.441-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:29:10.451-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:29:10.451-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:29:10.451-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:29:10.471-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:29:10.471-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:29:10.501-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:29:10.501-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:29:10.501-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:29:10.501-0700 W/AUL_PAD ( 6467): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:29:10.501-0700 W/AUL_PAD ( 6467): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:29:10.501-0700 W/AUL_PAD ( 6467): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:29:10.501-0700 W/AUL_PAD ( 6467): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:29:10.541-0700 W/AUL_PAD ( 6467): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:29:10.541-0700 W/AUL_PAD ( 6467): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:29:10.541-0700 I/CAPI_WATCH_APPLICATION( 6467): watch_app_main.c: watch_app_main(399) > watch_app_main
09-17 11:29:10.601-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.bitcoinwatch) pid(6467) type(watchapp) bg(0)
09-17 11:29:10.601-0700 W/AUL_AMD ( 2557): amd_status.c: __socket_monitor_cb(1277) > (6467) was created
09-17 11:29:10.601-0700 E/AUL     ( 2557): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
09-17 11:29:10.601-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6390
09-17 11:29:10.601-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6390)
09-17 11:29:10.601-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6467]
09-17 11:29:10.601-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6467)
09-17 11:29:10.701-0700 W/WATCH_CORE( 6467): appcore-watch.c: __widget_create(1068) > widget_create
09-17 11:29:10.701-0700 I/CAPI_WATCH_APPLICATION( 6467): watch_app_main.c: watch_app_get_elm_win(663) > watch hwc mode is enabled
09-17 11:29:10.801-0700 D/bitcoinwatch( 6467): 0
09-17 11:29:10.881-0700 I/CAPI_NETWORK_CONNECTION( 6467): connection.c: connection_create(453) > New handle created[0xf7ad4e08]
09-17 11:29:10.941-0700 I/CAPI_NETWORK_CONNECTION( 6467): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:29:11.031-0700 D/bitcoinwatch( 6467): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:29:11.031-0700 D/bitcoinwatch( 6467): Size: 3
09-17 11:29:11.031-0700 D/bitcoinwatch( 6467): Rate: 3731.85
09-17 11:29:11.031-0700 E/bitcoinwatch( 6467): updated bitcoin
09-17 11:29:11.041-0700 I/CAPI_NETWORK_CONNECTION( 6467): connection.c: connection_create(453) > New handle created[0xf7a9a2f8]
09-17 11:29:11.091-0700 I/CAPI_NETWORK_CONNECTION( 6467): connection.c: connection_get_wifi_state(750) > Wi-Fi state: 2
09-17 11:29:11.151-0700 D/bitcoinwatch( 6467): response {"time":{"updated":"Sep 17, 2017 18:28:00 UTC","updatedISO":"2017-09-17T18:28:00+00:00","updateduk":"Sep 17, 2017 at 19:28 BST"},"disclaimer":"This data was produced from the CoinDesk Bitcoin Price Index (USD). Non-USD currency data converted using hourly conversion rate from openexchangerates.org","chartName":"Bitcoin","bpi":{"USD":{"code":"USD","symbol":"&#36;","rate":"3,731.8500","description":"United States Dollar","rate_float":3731.85},"GBP":{"code":"GBP","symbol":"&pound;","rate":"2,745.3168","description":"British Pound Sterling","rate_float":2745.3168},"EUR":{"code":"EUR","symbol":"&euro;","rate":"3,124.0622","description":"Euro","rate_float":3124.0622}}}
09-17 11:29:11.151-0700 D/bitcoinwatch( 6467): Size: 3
09-17 11:29:11.161-0700 D/bitcoinwatch( 6467): Rate: 3731.85
09-17 11:29:11.161-0700 E/bitcoinwatch( 6467): updated bitcoin
09-17 11:29:11.161-0700 W/WATCH_CORE( 6467): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-17 11:29:11.181-0700 E/WIDGET_PROVIDER_APP( 6467): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-17 11:29:11.201-0700 I/WATCH_CORE( 6467): appcore-watch.c: __watch_core_set_metadata(899) > No metadata info for the tick per second
09-17 11:29:11.211-0700 I/WATCH_CORE( 6467): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-17 11:29:11.211-0700 I/WATCH_CORE( 6467): appcore-watch.c: __watch_core_set_metadata(931) > No metadata info for the background tick update
09-17 11:29:11.211-0700 I/WATCH_CORE( 6467): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:29:11.601-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:29:11.601-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:29:11.691-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:29:11.701-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6467
09-17 11:29:11.701-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:29:11.911-0700 I/AUL_PAD ( 6489): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:29:12.721-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 1105631626974150567255
