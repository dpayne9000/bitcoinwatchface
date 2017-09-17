S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.3
Build-Number: R765VVRU1AQF4
Build-Date: 2017.07.17 17:00:49

Crash Information
Process Name: bitcoinwatch
PID: 5572
Date: 2017-09-17 11:22:06-0700
Executable File Path: /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x40730eb9
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6ecd9b8, r5   = 0xf6ecd9b8
r6   = 0xf6ecd16c, r7   = 0xf6ecd9b8
r8   = 0xf6ecd9b8, r9   = 0xf7763ff8
r10  = 0xf6edbb10, fp   = 0x0000018f
ip   = 0x00000001, sp   = 0xffc08640
lr   = 0xf6ebd1f9, pc   = 0x00000000
cpsr = 0x60000030

Memory Information
MemTotal:   620380 KB
MemFree:     25984 KB
Buffers:     16476 KB
Cached:     147444 KB
VmPeak:      78076 KB
VmSize:      78076 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24008 KB
VmRSS:       24008 KB
VmData:      21252 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       21132 KB
VmPTE:         120 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5572 TID = 5572
5572 5586 5592 

Maps Information
f2a01000 f3200000 rw-p [stack:5592]
f33ce000 f33e5000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f33f2000 f33fd000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3406000 f3411000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f341a000 f3c19000 rw-p [stack:5586]
f3e19000 f3e29000 r-xp /usr/lib/libmdm-common.so.1.1.24
f3e31000 f3e3c000 r-xp /usr/lib/libtbm.so.1.0.0
f3e44000 f3e8d000 r-xp /usr/lib/libmdm.so.1.2.69
f3e95000 f3e9b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f3ea3000 f3ea5000 r-xp /usr/lib/libdri2.so.0.0.0
f3ead000 f3eb5000 r-xp /usr/lib/libdrm.so.2.4.0
f3ebd000 f3ecd000 r-xp /usr/lib/libwidget_provider.so.1.0.0
f3ed5000 f3ede000 r-xp /usr/lib/libcom-core.so.0.0.1
f5780000 f5785000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f578d000 f57a6000 r-xp /usr/lib/libnetwork.so.0.0.0
f57ae000 f57b8000 r-xp /usr/lib/libwidget.so.1.0.0
f57c0000 f57d3000 r-xp /usr/lib/libwidget_service.so.1.0.0
f57dc000 f57e3000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
f57ec000 f58f2000 r-xp /usr/lib/libicuuc.so.57.1
f5908000 f5a90000 r-xp /usr/lib/libicui18n.so.57.1
f5aa0000 f5aad000 r-xp /usr/lib/libalarm.so.0.0.0
f5ab7000 f5ac6000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f5acf000 f5adf000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f5ae7000 f5aef000 r-xp /usr/lib/libappcore-watch.so.1.1
f5b01000 f5b06000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f5ca0000 f5caa000 r-xp /lib/libnss_files-2.13.so
f5cb3000 f5d82000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5d98000 f5dbc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5dc5000 f5dcb000 r-xp /usr/lib/libappsvc.so.0.1.0
f5dd3000 f5dd7000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5de5000 f5de7000 r-xp /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
f5df7000 f5df9000 r-xp /usr/lib/libiniparser.so.0
f5e02000 f5e07000 r-xp /usr/lib/libappcore-common.so.1.1
f5e0f000 f5e11000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5e1a000 f5e1e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5e2b000 f5e2d000 r-xp /usr/lib/libXau.so.6.0.0
f5e35000 f5e3c000 r-xp /lib/libcrypt-2.13.so
f5e6c000 f5e6e000 r-xp /usr/lib/libiri.so
f5e77000 f6020000 r-xp /usr/lib/libcrypto.so.1.0.0
f6040000 f6087000 r-xp /usr/lib/libssl.so.1.0.0
f6093000 f60c1000 r-xp /usr/lib/libidn.so.11.5.44
f60c9000 f60d2000 r-xp /usr/lib/libcares.so.2.1.0
f60dc000 f60ef000 r-xp /usr/lib/libxcb.so.1.1.0
f60f8000 f60fa000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6102000 f6104000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f610d000 f61d9000 r-xp /usr/lib/libxml2.so.2.7.8
f61e6000 f61e8000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f61f1000 f61f6000 r-xp /usr/lib/libffi.so.5.0.10
f61fe000 f61ff000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6207000 f620a000 r-xp /lib/libattr.so.1.1.0
f6212000 f62a6000 r-xp /usr/lib/libstdc++.so.6.0.16
f62b9000 f62d6000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f62e0000 f62f8000 r-xp /usr/lib/libpng12.so.0.50.0
f6300000 f6316000 r-xp /lib/libexpat.so.1.6.0
f6320000 f6364000 r-xp /usr/lib/libcurl.so.4.3.0
f636d000 f6377000 r-xp /usr/lib/libXext.so.6.4.0
f6380000 f6384000 r-xp /usr/lib/libXtst.so.6.1.0
f638c000 f6392000 r-xp /usr/lib/libXrender.so.1.3.0
f639a000 f63a0000 r-xp /usr/lib/libXrandr.so.2.2.0
f63a8000 f63a9000 r-xp /usr/lib/libXinerama.so.1.0.0
f63b2000 f63bb000 r-xp /usr/lib/libXi.so.6.1.0
f63c3000 f63c6000 r-xp /usr/lib/libXfixes.so.3.1.0
f63ce000 f63d0000 r-xp /usr/lib/libXgesture.so.7.0.0
f63d8000 f63da000 r-xp /usr/lib/libXcomposite.so.1.0.0
f63e2000 f63e4000 r-xp /usr/lib/libXdamage.so.1.1.0
f63ec000 f63f3000 r-xp /usr/lib/libXcursor.so.1.0.2
f63fb000 f63fe000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f6406000 f640a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6413000 f6418000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6421000 f6502000 r-xp /usr/lib/libX11.so.6.3.0
f650d000 f6530000 r-xp /usr/lib/libjpeg.so.8.0.2
f6548000 f655e000 r-xp /lib/libz.so.1.2.5
f6566000 f6568000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6570000 f65e5000 r-xp /usr/lib/libsqlite3.so.0.8.6
f65ef000 f6609000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6611000 f6645000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f664e000 f6721000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f672c000 f673c000 r-xp /lib/libresolv-2.13.so
f6740000 f6758000 r-xp /usr/lib/liblzma.so.5.0.3
f6760000 f6763000 r-xp /lib/libcap.so.2.21
f676b000 f679a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67a3000 f67a4000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f67ac000 f67b2000 r-xp /usr/lib/libecore_imf.so.1.7.99
f67ba000 f67d1000 r-xp /usr/lib/liblua-5.1.so
f67da000 f67e1000 r-xp /usr/lib/libembryo.so.1.7.99
f67e9000 f67ef000 r-xp /lib/librt-2.13.so
f67f8000 f684e000 r-xp /usr/lib/libpixman-1.so.0.28.2
f685b000 f68b1000 r-xp /usr/lib/libfreetype.so.6.11.3
f68bd000 f68e5000 r-xp /usr/lib/libfontconfig.so.1.8.0
f68e6000 f692b000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6934000 f6947000 r-xp /usr/lib/libfribidi.so.0.3.1
f694f000 f6969000 r-xp /usr/lib/libecore_con.so.1.7.99
f6972000 f697b000 r-xp /usr/lib/libedbus.so.1.7.99
f6983000 f69d3000 r-xp /usr/lib/libecore_x.so.1.7.99
f69d5000 f69de000 r-xp /usr/lib/libvconf.so.0.2.45
f69e6000 f69f7000 r-xp /usr/lib/libecore_input.so.1.7.99
f69ff000 f6a04000 r-xp /usr/lib/libecore_file.so.1.7.99
f6a0c000 f6a2e000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6a37000 f6a78000 r-xp /usr/lib/libeina.so.1.7.99
f6a81000 f6a9a000 r-xp /usr/lib/libeet.so.1.7.99
f6aab000 f6b14000 r-xp /lib/libm-2.13.so
f6b1d000 f6b23000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6b2c000 f6b2d000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b35000 f6b58000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b60000 f6b65000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b6d000 f6b97000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ba0000 f6bb7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bbf000 f6bca000 r-xp /lib/libunwind.so.8.0.1
f6bf7000 f6c15000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c1f000 f6d43000 r-xp /lib/libc-2.13.so
f6d51000 f6d59000 r-xp /lib/libgcc_s-4.6.so.1
f6d5a000 f6d5e000 r-xp /usr/lib/libsmack.so.1.0.0
f6d67000 f6d6d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6d75000 f6e45000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e46000 f6ea4000 r-xp /usr/lib/libedje.so.1.7.99
f6eae000 f6ec5000 r-xp /usr/lib/libecore.so.1.7.99
f6edc000 f6faa000 r-xp /usr/lib/libevas.so.1.7.99
f6fcf000 f710b000 r-xp /usr/lib/libelementary.so.1.7.99
f7122000 f7136000 r-xp /lib/libpthread-2.13.so
f7141000 f7143000 r-xp /usr/lib/libdlog.so.0.0.0
f714b000 f714e000 r-xp /usr/lib/libbundle.so.0.1.22
f7156000 f7158000 r-xp /lib/libdl-2.13.so
f7161000 f716e000 r-xp /usr/lib/libaul.so.0.1.0
f7180000 f7186000 r-xp /usr/lib/libappcore-efl.so.1.1
f718f000 f7193000 r-xp /usr/lib/libsys-assert.so
f719c000 f71b9000 r-xp /lib/ld-2.13.so
f71c2000 f71c7000 r-xp /usr/bin/launchpad-loader
f772c000 f78fc000 rw-p [heap]
ffbe9000 ffc0a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5572)
Call Stack Count: 2
 0: (0xf6ebd1f9) [/usr/lib/libecore.so.1] + 0xf1f9
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
ard-basic-panel-common.c: _wnb_bp_expand_basic_gl_group_content_get(2248) > Unhandled part: more.btn
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
09-17 11:29:04.511-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 1105572626974150567252
