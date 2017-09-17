S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.3
Build-Number: R765VVRU1AQF4
Build-Date: 2017.07.17 17:00:49

Crash Information
Process Name: bitcoinwatch
PID: 5597
Date: 2017-09-17 11:22:21-0700
Executable File Path: /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x4073577d
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6e199b8, r5   = 0xf6e199b8
r6   = 0xf6e1916c, r7   = 0xf6e199b8
r8   = 0xf6e199b8, r9   = 0xf7358ff8
r10  = 0xf6e27b10, fp   = 0x0000018f
ip   = 0x00000001, sp   = 0xff989430
lr   = 0xf6e091f9, pc   = 0x00000000
cpsr = 0x60000030

Memory Information
MemTotal:   620380 KB
MemFree:     31632 KB
Buffers:     16956 KB
Cached:     139016 KB
VmPeak:      77552 KB
VmSize:      77552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23960 KB
VmRSS:       23960 KB
VmData:      20220 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       21132 KB
VmPTE:         116 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5597 TID = 5597
5597 5623 5630 

Maps Information
f2a7e000 f327d000 rw-p [stack:5630]
f331a000 f3331000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f333e000 f3349000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3352000 f335d000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f3366000 f3b65000 rw-p [stack:5623]
f3d65000 f3d75000 r-xp /usr/lib/libmdm-common.so.1.1.24
f3d7d000 f3d88000 r-xp /usr/lib/libtbm.so.1.0.0
f3d90000 f3dd9000 r-xp /usr/lib/libmdm.so.1.2.69
f3de1000 f3de7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f3def000 f3df1000 r-xp /usr/lib/libdri2.so.0.0.0
f3df9000 f3e01000 r-xp /usr/lib/libdrm.so.2.4.0
f3e09000 f3e19000 r-xp /usr/lib/libwidget_provider.so.1.0.0
f3e21000 f3e2a000 r-xp /usr/lib/libcom-core.so.0.0.1
f56cc000 f56d1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f56d9000 f56f2000 r-xp /usr/lib/libnetwork.so.0.0.0
f56fa000 f5704000 r-xp /usr/lib/libwidget.so.1.0.0
f570c000 f571f000 r-xp /usr/lib/libwidget_service.so.1.0.0
f5728000 f572f000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
f5738000 f583e000 r-xp /usr/lib/libicuuc.so.57.1
f5854000 f59dc000 r-xp /usr/lib/libicui18n.so.57.1
f59ec000 f59f9000 r-xp /usr/lib/libalarm.so.0.0.0
f5a03000 f5a12000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f5a1b000 f5a2b000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f5a33000 f5a3b000 r-xp /usr/lib/libappcore-watch.so.1.1
f5a4d000 f5a52000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f5bec000 f5bf6000 r-xp /lib/libnss_files-2.13.so
f5bff000 f5cce000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5ce4000 f5d08000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5d11000 f5d17000 r-xp /usr/lib/libappsvc.so.0.1.0
f5d1f000 f5d23000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5d31000 f5d33000 r-xp /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
f5d43000 f5d45000 r-xp /usr/lib/libiniparser.so.0
f5d4e000 f5d53000 r-xp /usr/lib/libappcore-common.so.1.1
f5d5b000 f5d5d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5d66000 f5d6a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5d77000 f5d79000 r-xp /usr/lib/libXau.so.6.0.0
f5d81000 f5d88000 r-xp /lib/libcrypt-2.13.so
f5db8000 f5dba000 r-xp /usr/lib/libiri.so
f5dc3000 f5f6c000 r-xp /usr/lib/libcrypto.so.1.0.0
f5f8c000 f5fd3000 r-xp /usr/lib/libssl.so.1.0.0
f5fdf000 f600d000 r-xp /usr/lib/libidn.so.11.5.44
f6015000 f601e000 r-xp /usr/lib/libcares.so.2.1.0
f6028000 f603b000 r-xp /usr/lib/libxcb.so.1.1.0
f6044000 f6046000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f604e000 f6050000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6059000 f6125000 r-xp /usr/lib/libxml2.so.2.7.8
f6132000 f6134000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f613d000 f6142000 r-xp /usr/lib/libffi.so.5.0.10
f614a000 f614b000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6153000 f6156000 r-xp /lib/libattr.so.1.1.0
f615e000 f61f2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6205000 f6222000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f622c000 f6244000 r-xp /usr/lib/libpng12.so.0.50.0
f624c000 f6262000 r-xp /lib/libexpat.so.1.6.0
f626c000 f62b0000 r-xp /usr/lib/libcurl.so.4.3.0
f62b9000 f62c3000 r-xp /usr/lib/libXext.so.6.4.0
f62cc000 f62d0000 r-xp /usr/lib/libXtst.so.6.1.0
f62d8000 f62de000 r-xp /usr/lib/libXrender.so.1.3.0
f62e6000 f62ec000 r-xp /usr/lib/libXrandr.so.2.2.0
f62f4000 f62f5000 r-xp /usr/lib/libXinerama.so.1.0.0
f62fe000 f6307000 r-xp /usr/lib/libXi.so.6.1.0
f630f000 f6312000 r-xp /usr/lib/libXfixes.so.3.1.0
f631a000 f631c000 r-xp /usr/lib/libXgesture.so.7.0.0
f6324000 f6326000 r-xp /usr/lib/libXcomposite.so.1.0.0
f632e000 f6330000 r-xp /usr/lib/libXdamage.so.1.1.0
f6338000 f633f000 r-xp /usr/lib/libXcursor.so.1.0.2
f6347000 f634a000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f6352000 f6356000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f635f000 f6364000 r-xp /usr/lib/libecore_fb.so.1.7.99
f636d000 f644e000 r-xp /usr/lib/libX11.so.6.3.0
f6459000 f647c000 r-xp /usr/lib/libjpeg.so.8.0.2
f6494000 f64aa000 r-xp /lib/libz.so.1.2.5
f64b2000 f64b4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f64bc000 f6531000 r-xp /usr/lib/libsqlite3.so.0.8.6
f653b000 f6555000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f655d000 f6591000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f659a000 f666d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6678000 f6688000 r-xp /lib/libresolv-2.13.so
f668c000 f66a4000 r-xp /usr/lib/liblzma.so.5.0.3
f66ac000 f66af000 r-xp /lib/libcap.so.2.21
f66b7000 f66e6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66ef000 f66f0000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f66f8000 f66fe000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6706000 f671d000 r-xp /usr/lib/liblua-5.1.so
f6726000 f672d000 r-xp /usr/lib/libembryo.so.1.7.99
f6735000 f673b000 r-xp /lib/librt-2.13.so
f6744000 f679a000 r-xp /usr/lib/libpixman-1.so.0.28.2
f67a7000 f67fd000 r-xp /usr/lib/libfreetype.so.6.11.3
f6809000 f6831000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6832000 f6877000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6880000 f6893000 r-xp /usr/lib/libfribidi.so.0.3.1
f689b000 f68b5000 r-xp /usr/lib/libecore_con.so.1.7.99
f68be000 f68c7000 r-xp /usr/lib/libedbus.so.1.7.99
f68cf000 f691f000 r-xp /usr/lib/libecore_x.so.1.7.99
f6921000 f692a000 r-xp /usr/lib/libvconf.so.0.2.45
f6932000 f6943000 r-xp /usr/lib/libecore_input.so.1.7.99
f694b000 f6950000 r-xp /usr/lib/libecore_file.so.1.7.99
f6958000 f697a000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6983000 f69c4000 r-xp /usr/lib/libeina.so.1.7.99
f69cd000 f69e6000 r-xp /usr/lib/libeet.so.1.7.99
f69f7000 f6a60000 r-xp /lib/libm-2.13.so
f6a69000 f6a6f000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6a78000 f6a79000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a81000 f6aa4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6aac000 f6ab1000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ab9000 f6ae3000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6aec000 f6b03000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b0b000 f6b16000 r-xp /lib/libunwind.so.8.0.1
f6b43000 f6b61000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b6b000 f6c8f000 r-xp /lib/libc-2.13.so
f6c9d000 f6ca5000 r-xp /lib/libgcc_s-4.6.so.1
f6ca6000 f6caa000 r-xp /usr/lib/libsmack.so.1.0.0
f6cb3000 f6cb9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6cc1000 f6d91000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d92000 f6df0000 r-xp /usr/lib/libedje.so.1.7.99
f6dfa000 f6e11000 r-xp /usr/lib/libecore.so.1.7.99
f6e28000 f6ef6000 r-xp /usr/lib/libevas.so.1.7.99
f6f1b000 f7057000 r-xp /usr/lib/libelementary.so.1.7.99
f706e000 f7082000 r-xp /lib/libpthread-2.13.so
f708d000 f708f000 r-xp /usr/lib/libdlog.so.0.0.0
f7097000 f709a000 r-xp /usr/lib/libbundle.so.0.1.22
f70a2000 f70a4000 r-xp /lib/libdl-2.13.so
f70ad000 f70ba000 r-xp /usr/lib/libaul.so.0.1.0
f70cc000 f70d2000 r-xp /usr/lib/libappcore-efl.so.1.1
f70db000 f70df000 r-xp /usr/lib/libsys-assert.so
f70e8000 f7105000 r-xp /lib/ld-2.13.so
f710e000 f7113000 r-xp /usr/bin/launchpad-loader
f7321000 f74f1000 rw-p [heap]
ff96a000 ff98b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5597)
Call Stack Count: 2
 0: (0xf6e091f9) [/usr/lib/libecore.so.1] + 0xf1f9
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
09-17 11:29:04.511-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11055726269741505672526
09-17 11:29:05.871-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 1105597626974150567254
