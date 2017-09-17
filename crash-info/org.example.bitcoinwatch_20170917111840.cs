S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.3
Build-Number: R765VVRU1AQF4
Build-Date: 2017.07.17 17:00:49

Crash Information
Process Name: bitcoinwatch
PID: 5458
Date: 2017-09-17 11:18:40-0700
Executable File Path: /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x407203d8
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71bb9b8, r5   = 0xf71bb9b8
r6   = 0xf71bb16c, r7   = 0xf71bb9b8
r8   = 0xf71bb9b8, r9   = 0xf785fff8
r10  = 0xf71c9b10, fp   = 0x0000018f
ip   = 0x00000001, sp   = 0xfff08dd0
lr   = 0xf71ab1f9, pc   = 0x00000000
cpsr = 0x60000030

Memory Information
MemTotal:   620380 KB
MemFree:     15448 KB
Buffers:     15492 KB
Cached:     139812 KB
VmPeak:      76536 KB
VmSize:      76536 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23668 KB
VmRSS:       23668 KB
VmData:      20220 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       21132 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5458 TID = 5458
5458 5478 5486 

Maps Information
f2e20000 f361f000 rw-p [stack:5486]
f36bc000 f36d3000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f36e0000 f36eb000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f36f4000 f36ff000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f3708000 f3f07000 rw-p [stack:5478]
f4107000 f4117000 r-xp /usr/lib/libmdm-common.so.1.1.24
f411f000 f412a000 r-xp /usr/lib/libtbm.so.1.0.0
f4132000 f417b000 r-xp /usr/lib/libmdm.so.1.2.69
f4183000 f4189000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f4191000 f4193000 r-xp /usr/lib/libdri2.so.0.0.0
f419b000 f41a3000 r-xp /usr/lib/libdrm.so.2.4.0
f41ab000 f41bb000 r-xp /usr/lib/libwidget_provider.so.1.0.0
f41c3000 f41cc000 r-xp /usr/lib/libcom-core.so.0.0.1
f5a6e000 f5a73000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5a7b000 f5a94000 r-xp /usr/lib/libnetwork.so.0.0.0
f5a9c000 f5aa6000 r-xp /usr/lib/libwidget.so.1.0.0
f5aae000 f5ac1000 r-xp /usr/lib/libwidget_service.so.1.0.0
f5aca000 f5ad1000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
f5ada000 f5be0000 r-xp /usr/lib/libicuuc.so.57.1
f5bf6000 f5d7e000 r-xp /usr/lib/libicui18n.so.57.1
f5d8e000 f5d9b000 r-xp /usr/lib/libalarm.so.0.0.0
f5da5000 f5db4000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f5dbd000 f5dcd000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f5dd5000 f5ddd000 r-xp /usr/lib/libappcore-watch.so.1.1
f5def000 f5df4000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f5f8e000 f5f98000 r-xp /lib/libnss_files-2.13.so
f5fa1000 f6070000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f6086000 f60aa000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f60b3000 f60b9000 r-xp /usr/lib/libappsvc.so.0.1.0
f60c1000 f60c5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f60d3000 f60d5000 r-xp /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
f60e5000 f60e7000 r-xp /usr/lib/libiniparser.so.0
f60f0000 f60f5000 r-xp /usr/lib/libappcore-common.so.1.1
f60fd000 f60ff000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f6108000 f610c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f6119000 f611b000 r-xp /usr/lib/libXau.so.6.0.0
f6123000 f612a000 r-xp /lib/libcrypt-2.13.so
f615a000 f615c000 r-xp /usr/lib/libiri.so
f6165000 f630e000 r-xp /usr/lib/libcrypto.so.1.0.0
f632e000 f6375000 r-xp /usr/lib/libssl.so.1.0.0
f6381000 f63af000 r-xp /usr/lib/libidn.so.11.5.44
f63b7000 f63c0000 r-xp /usr/lib/libcares.so.2.1.0
f63ca000 f63dd000 r-xp /usr/lib/libxcb.so.1.1.0
f63e6000 f63e8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f63f0000 f63f2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f63fb000 f64c7000 r-xp /usr/lib/libxml2.so.2.7.8
f64d4000 f64d6000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f64df000 f64e4000 r-xp /usr/lib/libffi.so.5.0.10
f64ec000 f64ed000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f64f5000 f64f8000 r-xp /lib/libattr.so.1.1.0
f6500000 f6594000 r-xp /usr/lib/libstdc++.so.6.0.16
f65a7000 f65c4000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65ce000 f65e6000 r-xp /usr/lib/libpng12.so.0.50.0
f65ee000 f6604000 r-xp /lib/libexpat.so.1.6.0
f660e000 f6652000 r-xp /usr/lib/libcurl.so.4.3.0
f665b000 f6665000 r-xp /usr/lib/libXext.so.6.4.0
f666e000 f6672000 r-xp /usr/lib/libXtst.so.6.1.0
f667a000 f6680000 r-xp /usr/lib/libXrender.so.1.3.0
f6688000 f668e000 r-xp /usr/lib/libXrandr.so.2.2.0
f6696000 f6697000 r-xp /usr/lib/libXinerama.so.1.0.0
f66a0000 f66a9000 r-xp /usr/lib/libXi.so.6.1.0
f66b1000 f66b4000 r-xp /usr/lib/libXfixes.so.3.1.0
f66bc000 f66be000 r-xp /usr/lib/libXgesture.so.7.0.0
f66c6000 f66c8000 r-xp /usr/lib/libXcomposite.so.1.0.0
f66d0000 f66d2000 r-xp /usr/lib/libXdamage.so.1.1.0
f66da000 f66e1000 r-xp /usr/lib/libXcursor.so.1.0.2
f66e9000 f66ec000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f66f4000 f66f8000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6701000 f6706000 r-xp /usr/lib/libecore_fb.so.1.7.99
f670f000 f67f0000 r-xp /usr/lib/libX11.so.6.3.0
f67fb000 f681e000 r-xp /usr/lib/libjpeg.so.8.0.2
f6836000 f684c000 r-xp /lib/libz.so.1.2.5
f6854000 f6856000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f685e000 f68d3000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68dd000 f68f7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68ff000 f6933000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f693c000 f6a0f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a1a000 f6a2a000 r-xp /lib/libresolv-2.13.so
f6a2e000 f6a46000 r-xp /usr/lib/liblzma.so.5.0.3
f6a4e000 f6a51000 r-xp /lib/libcap.so.2.21
f6a59000 f6a88000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a91000 f6a92000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6a9a000 f6aa0000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6aa8000 f6abf000 r-xp /usr/lib/liblua-5.1.so
f6ac8000 f6acf000 r-xp /usr/lib/libembryo.so.1.7.99
f6ad7000 f6add000 r-xp /lib/librt-2.13.so
f6ae6000 f6b3c000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6b49000 f6b9f000 r-xp /usr/lib/libfreetype.so.6.11.3
f6bab000 f6bd3000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6bd4000 f6c19000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6c22000 f6c35000 r-xp /usr/lib/libfribidi.so.0.3.1
f6c3d000 f6c57000 r-xp /usr/lib/libecore_con.so.1.7.99
f6c60000 f6c69000 r-xp /usr/lib/libedbus.so.1.7.99
f6c71000 f6cc1000 r-xp /usr/lib/libecore_x.so.1.7.99
f6cc3000 f6ccc000 r-xp /usr/lib/libvconf.so.0.2.45
f6cd4000 f6ce5000 r-xp /usr/lib/libecore_input.so.1.7.99
f6ced000 f6cf2000 r-xp /usr/lib/libecore_file.so.1.7.99
f6cfa000 f6d1c000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6d25000 f6d66000 r-xp /usr/lib/libeina.so.1.7.99
f6d6f000 f6d88000 r-xp /usr/lib/libeet.so.1.7.99
f6d99000 f6e02000 r-xp /lib/libm-2.13.so
f6e0b000 f6e11000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e1a000 f6e1b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e23000 f6e46000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e4e000 f6e53000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e5b000 f6e85000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e8e000 f6ea5000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ead000 f6eb8000 r-xp /lib/libunwind.so.8.0.1
f6ee5000 f6f03000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f0d000 f7031000 r-xp /lib/libc-2.13.so
f703f000 f7047000 r-xp /lib/libgcc_s-4.6.so.1
f7048000 f704c000 r-xp /usr/lib/libsmack.so.1.0.0
f7055000 f705b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f7063000 f7133000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7134000 f7192000 r-xp /usr/lib/libedje.so.1.7.99
f719c000 f71b3000 r-xp /usr/lib/libecore.so.1.7.99
f71ca000 f7298000 r-xp /usr/lib/libevas.so.1.7.99
f72bd000 f73f9000 r-xp /usr/lib/libelementary.so.1.7.99
f7410000 f7424000 r-xp /lib/libpthread-2.13.so
f742f000 f7431000 r-xp /usr/lib/libdlog.so.0.0.0
f7439000 f743c000 r-xp /usr/lib/libbundle.so.0.1.22
f7444000 f7446000 r-xp /lib/libdl-2.13.so
f744f000 f745c000 r-xp /usr/lib/libaul.so.0.1.0
f746e000 f7474000 r-xp /usr/lib/libappcore-efl.so.1.1
f747d000 f7481000 r-xp /usr/lib/libsys-assert.so
f748a000 f74a7000 r-xp /lib/ld-2.13.so
f74b0000 f74b5000 r-xp /usr/bin/launchpad-loader
f7828000 f79f8000 rw-p [heap]
ffee9000 fff0a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5458)
Call Stack Count: 2
 0: (0xf71ab1f9) [/usr/lib/libecore.so.1] + 0xf1f9
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
ata info for the background tick update
09-17 11:28:42.801-0700 I/WATCH_CORE( 6114): appcore-watch.c: __watch_core_set_metadata(943) > No metadata info for the watchface
09-17 11:28:42.851-0700 W/W_HOME  ( 2907): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
09-17 11:28:42.851-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:42.851-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:42.851-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:42.851-0700 W/W_HOME  ( 2907): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
09-17 11:28:42.851-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:28:42.851-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:28:42.871-0700 W/W_HOME  ( 2907): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
09-17 11:28:42.871-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:42.871-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:42.871-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:42.871-0700 W/W_HOME  ( 2907): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
09-17 11:28:42.871-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:28:42.871-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:28:43.251-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:28:43.251-0700 W/AUL_AMD ( 2557): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-17 11:28:43.331-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:28:43.341-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6114
09-17 11:28:43.341-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 12
09-17 11:28:43.671-0700 I/AUL_PAD ( 6164): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-17 11:28:43.741-0700 I/APP_CORE( 2907): appcore-efl.c: __do_app(453) > [APP 2907] Event: MEM_FLUSH State: PAUSED
09-17 11:28:44.561-0700 E/wnoti-service( 3235): wnoti-consumer.c: on_receive(462) > on receive called. noti(1), handle(1) payloadLength(538)
09-17 11:28:44.561-0700 E/wnoti-service( 3235): wnoti-sap-client.c: _parse_received_noti(2660) > application_id : 11244
09-17 11:28:44.571-0700 E/wnoti-service( 3235): wnoti-db-utility.c: lock_pm(599) > >> lock_pm status : 2
09-17 11:28:44.571-0700 E/wnoti-service( 3235): wnoti-db-server.c: insert_panel_asset(3618) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/6139
09-17 11:28:44.571-0700 E/wnoti-service( 3235): wnoti-json-parser.c: wnoti_parse_android_wear_action(314) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/5954
09-17 11:28:44.571-0700 E/wnoti-service( 3235): wnoti-json-parser.c: wnoti_parse_android_wear_action(356) > noti_info->action_type : 0
09-17 11:28:44.571-0700 E/wnoti-service( 3235): wnoti-sap-client.c: _parse_normal_attribute(1171) > ATTR_ANDROID_WEARABLE, len : 143
09-17 11:28:44.571-0700 E/wnoti-service( 3235): wnoti-db-server.c: check_asset_images(3891) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/6139
09-17 11:28:44.571-0700 E/wnoti-service( 3235): wnoti-db-server.c: check_asset_images(3891) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/5954
09-17 11:28:44.571-0700 E/wnoti-service( 3235): wnoti-utility.c: is_check_image_size(1447) > src_w [63] src_h [63]
09-17 11:28:44.571-0700 E/wnoti-service( 3235): wnoti-db-server.c: check_asset_images(3928) > summary_bg_image : /opt/usr/data/wnoti/.12361.png
09-17 11:28:44.611-0700 E/wnoti-service( 3235): wnoti-db-server.c: wnoti_is_check_notification_update(4238) > 0/233285
09-17 11:28:44.611-0700 E/wnoti-service( 3235): wnoti-sap-client.c: _add_exception_handling(622) > type : 0, application_id : 11244
09-17 11:28:44.611-0700 E/wnoti-service( 3235): wnoti-sap-client.c: publish_received_noti(1924) > type : 0, category : 0, source : 0, feedback : 2, popup_type(RICH) : 0, application_id : 11244, seq_num : 233286, noti_flag : 1048592, g_span_version : 1, update_summary_icons : 0, latest_child_time : 0.000000, latest_summary_time : 0.000000, android_time : 1505672923995.000000
09-17 11:28:44.611-0700 E/wnoti-service( 3235): wnoti-db-utility.c: lock_pm(599) > >> lock_pm status : 2
09-17 11:28:44.631-0700 I/wnoti-service( 3235): wnoti-sap-client.c: launch_alert_view(431) > timer_id : 0, emergency_cb_mode : 0, blocking_mode : 0  
09-17 11:28:44.631-0700 E/wnoti-service( 3235): wnoti-db-utility.c: set_pm_lock(583) > >> set_pm_lock status : 1
09-17 11:28:44.631-0700 E/wnoti-service( 3235): wnoti-db-server.c: set_global_noti_count(1609) > pre_count : 1, count : 1
09-17 11:28:44.631-0700 E/wnoti-service( 3235): wnoti-db-utility.c: unlock_pm(614) > >> unlock_pm status : 1
09-17 11:28:44.631-0700 W/AUL     ( 3235): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.wnotiboard-popup)
09-17 11:28:44.631-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:28:44.641-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
09-17 11:28:44.651-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
09-17 11:28:44.651-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:28:44.651-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 3235
09-17 11:28:44.661-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.wnotiboard-popup) pid(3625) type(uiapp) bg(0)
09-17 11:28:44.661-0700 W/AUL_AMD ( 2557): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3625
09-17 11:28:44.661-0700 I/APP_CORE( 3625): appcore-efl.c: __do_app(453) > [APP 3625] Event: RESET State: PAUSED
09-17 11:28:44.661-0700 I/CAPI_APPFW_APPLICATION( 3625): app_main.c: app_appcore_reset(245) > app_appcore_reset
09-17 11:28:44.661-0700 I/wnotibp ( 3625): wnotiboard-popup.c: _popup_app_control(170) > popup launch-type: alert
09-17 11:28:44.661-0700 I/APP_CORE( 3625): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
09-17 11:28:44.661-0700 W/STARTER ( 2758): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [3625]
09-17 11:28:44.661-0700 W/AUL_AMD ( 2557): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(3625), cmd(0)
09-17 11:28:44.661-0700 W/AUL     ( 3235): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3625)
09-17 11:28:44.661-0700 E/wnoti-service( 3235): wnoti-sap-client.c: on_timer(280) > >> launching notification popup
09-17 11:28:44.661-0700 E/wnoti-service( 3235): wnoti-sap-client.c: on_timer(313) > is_exist_alert_list : 0, g_launch_popup_time : 1505672924, g_use_aul_launch : 1505672924
09-17 11:28:45.131-0700 E/wnoti-service( 3235): wnoti-msg-builder.c: _publish_notification(1565) > operation_type : 0, source : 0, application_id : 0, display_count : 0, 
09-17 11:28:45.131-0700 E/wnoti-proxy( 3625): wnoti-client.c: on_wnoti_event(1026) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 3625, caller_id : 0, listener_type : 0
09-17 11:28:45.131-0700 E/wnoti-proxy( 2907): wnoti-client.c: on_wnoti_event(1026) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2907, caller_id : 0, listener_type : 0
09-17 11:28:45.281-0700 I/wnotibp ( 3625): wnotiboard-popup-control.c: _ctrl_service_changed_cb(242) > Handle this change type in idler.
09-17 11:28:45.281-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(787) > Change type : 0, op_type: 0, category_id: 0, display count: 0
09-17 11:28:45.281-0700 I/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(821) > Handle this change type in idler.
09-17 11:28:45.281-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(825) > Postpone notiboard update.
09-17 11:28:45.291-0700 E/wnoti-service( 3235): wnoti-db-client.c: wnoti_get_alert_categories(1142) > !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! application_id : 11244, db_id : 46871, is_duplicated : 0
09-17 11:28:45.291-0700 E/wnoti-service( 3235): wnoti-db-client.c: wnoti_get_alert_categories(1290) > view_type : 0, turn_screen_on : 0, allow_gesture : 1, is_used_popup : 0, feedback : 2
09-17 11:28:45.301-0700 I/wnoti-proxy( 3625): wnoti-client.c: is_mini_app(1795) > is_mini_app : 0
09-17 11:28:45.301-0700 I/wnotibp ( 3625): wnotiboard-popup-data.c: _data_get_alert_list(219) > application_name: Blockfolio, application_id: 11244, category_id: 6079, time: 1505672923, launch_app_id: (null), bg_image: /opt/usr/data/wnoti/.app_icon_11244.png, icon_color: -12171706, disble_block_app_action: 0, support_large_icon 0
09-17 11:28:45.301-0700 I/wnotibp ( 3625): wnotiboard-popup-data.c: _data_get_alert_list(229) > noti_type: 1
09-17 11:28:45.301-0700 I/wnotibp ( 3625): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(60) > db_id: 46871, noti_type: 1
09-17 11:28:45.301-0700 I/wnotibp ( 3625): w-notification-board-noti-manager-common.c: wnb_nm_fill_common_detail_fields(86) > is_source_companion: 1, content_id: 0, notification_id: 0
09-17 11:28:45.301-0700 W/wnotibp ( 3625): wnotiboard-popup-data.c: _data_convert_alert_data(65) > alert_type: 1, app_feedback_type: 2, popup_view_style: 0, feedback_pattern_app: -1
09-17 11:28:45.301-0700 W/wnotibp ( 3625): wnotiboard-popup-data.c: _data_get_alert_list(307) > ::DATA:: read alert list : 0, new_list count : 1
09-17 11:28:45.301-0700 W/wnotibp ( 3625): wnotiboard-popup-control.c: _ctrl_notification_change_cb(605) > [1,46871]
09-17 11:28:45.311-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 14
09-17 11:28:45.311-0700 W/AUL_AMD ( 2557): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
09-17 11:28:45.311-0700 I/wnotibp ( 3625): wnotiboard-popup-common.c: _common_app_id_from_win(152) > 2907
09-17 11:28:45.321-0700 I/wnotibp ( 3625): wnotiboard-popup-control.c: _ctrl_check_env_condition(442) > focus app is com.samsung.w-home, 0
09-17 11:28:45.321-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_add_notification(991) > Add noti_queue [46871, 0]
09-17 11:28:45.321-0700 I/wnotibp ( 3625): wnotiboard-popup-data.c: wnbp_data_free_alert_data_by_db_id(664) > ::DATA:: remove notification data, 46870
09-17 11:28:45.321-0700 I/wnotibp ( 3625): wnotiboard-popup-data.c: wnbp_data_free_alert_data_by_db_id(683) > ::DATA:: CHECK DATA : 1
09-17 11:28:45.321-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: _mgr_popup_draw_idler_cb(73) > ::APP:: CHECK STATE : 7, 0, (null)
09-17 11:28:45.321-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: wnbp_mgr_get_view_lock_state(666) > ::UI:: lock state=0000
09-17 11:28:45.321-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: _mgr_popup_draw_idler_cb(79) > ::APP:: CHECK DATA : 1 1 0000
09-17 11:28:45.321-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: _mgr_popup_draw_idler_cb(136) > Set pending noti db_id(46871) 0xf3080ae8
09-17 11:28:45.321-0700 I/wnotibp ( 3625): wnotiboard-popup-common.c: wnbp_common_get_block_mode(531) > Returning false.
09-17 11:28:45.321-0700 I/wnotibp ( 3625): wnotiboard-popup-control.c: _ctrl_play_feedback(283) > alert_type : 1, is_source_companion: 1, is_do_not_disturb: 0
09-17 11:28:45.321-0700 W/TIZEN_N_RECORDER( 3625): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
09-17 11:28:45.321-0700 W/wnotibp ( 3625): wnotiboard-popup-control.c: _ctrl_play_feedback(297) > ::APP:: application_id: 11244, is_disaster: 0, disaster_info: (null), app_feedback_type: 2, feedback_pattern_app: -1, is_recording: 0
09-17 11:28:45.331-0700 I/wnotibp ( 3625): wnotiboard-popup-control.c: _ctrl_play_feedback(306) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
09-17 11:28:45.331-0700 W/wnotibp ( 3625): wnotiboard-popup-control.c: _ctrl_play_feedback(340) > ::APP:: Determined feedback: sound 0, vibration: 1
09-17 11:28:45.331-0700 I/wnotib  ( 3625): w-notification-board-common-logging.c: wnotib_common_send_logging_data(147) > Log for type: 13, ret: 0, request_id: 5
09-17 11:28:45.331-0700 W/wnotibp ( 3625): wnotiboard-popup-control.c: _ctrl_set_smart_relay(506) > Set the smart relay for 1, 6079, 11244, Blockfolio
09-17 11:28:45.331-0700 E/wnoti-proxy( 3625): wnoti.c: wnoti_set_smart_relay(1150) > smart_relay setting : 0
09-17 11:28:45.331-0700 I/wnotibp ( 3625): wnotiboard-popup-common.c: wnbp_common_get_block_mode(531) > Returning false.
09-17 11:28:45.331-0700 W/wnotibp ( 3625): wnotiboard-popup-control.c: _ctrl_turn_on_lcd(539) > [1, 0, 0, 0]
09-17 11:28:45.351-0700 W/APP_CORE( 3625): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:360000a
09-17 11:28:45.361-0700 W/W_HOME  ( 2907): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
09-17 11:28:45.361-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:45.361-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:45.361-0700 W/W_INDICATOR( 2759): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-17 11:28:45.361-0700 W/W_INDICATOR( 2759): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-17 11:28:45.371-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:45.371-0700 W/W_HOME  ( 2907): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
09-17 11:28:45.381-0700 W/STARTER ( 2758): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2907] goes to (4)
09-17 11:28:45.381-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2907) status(bg) type(uiapp)
09-17 11:28:45.381-0700 E/STARTER ( 2758): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2907)'s state(4)
09-17 11:28:45.391-0700 W/AUL_AMD ( 2557): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-17 11:28:45.391-0700 W/AUL_AMD ( 2557): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
09-17 11:28:45.391-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.wnotiboard-popup) pid(3625) status(fg) type(uiapp)
09-17 11:28:45.391-0700 W/STARTER ( 2758): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[3625] goes to (3)
09-17 11:28:45.391-0700 W/W_HOME  ( 2907): event_manager.c: _window_visibility_cb(466) > Window [0x2200003] is now visible(1)
09-17 11:28:45.391-0700 W/W_HOME  ( 2907): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
09-17 11:28:45.391-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:45.391-0700 W/W_HOME  ( 2907): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
09-17 11:28:45.391-0700 W/W_HOME  ( 2907): main.c: _window_visibility_cb(964) > Window [0x2200003] is now visible(1)
09-17 11:28:45.391-0700 I/APP_CORE( 2907): appcore-efl.c: __do_app(453) > [APP 2907] Event: PAUSE State: PAUSED
09-17 11:28:45.391-0700 I/APP_CORE( 2907): appcore-efl.c: __visibility_cb(949) > LCD status is off, skip the AE_RESUME event
09-17 11:28:45.391-0700 I/wnotib  ( 2907): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
09-17 11:28:45.391-0700 E/wnotib  ( 2907): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
09-17 11:28:45.391-0700 W/wnotib  ( 2907): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [6], notiboard card appending count [60].
09-17 11:28:45.401-0700 W/wnotibp ( 3625): wnotiboard-popup-manager.c: _mgr_x_event_visibility_changed_cb(263) > fully_obscured: 0, 0
09-17 11:28:45.401-0700 I/wnotibp ( 3625): wnotiboard-popup-manager.c: _mgr_x_event_visibility_changed_cb(264) > [0x360000a 0x360000a 0x3600008]
09-17 11:28:45.401-0700 I/APP_CORE( 3625): appcore-efl.c: __visibility_cb(937) > LCD status is off, skip the AE_RESUME event
09-17 11:28:45.741-0700 E/wnoti-service( 3235): wnoti-db-client.c: wnoti_get_alert_categories(997) > _query_step failed(NO ROW)
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
09-17 11:28:47.891-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 1105458626974150567232
