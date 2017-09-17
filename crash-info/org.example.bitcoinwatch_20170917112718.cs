S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.3
Build-Number: R765VVRU1AQF4
Build-Date: 2017.07.17 17:00:49

Crash Information
Process Name: bitcoinwatch
PID: 5695
Date: 2017-09-17 11:27:18-0700
Executable File Path: /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x40742f59
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72019b8, r5   = 0xf72019b8
r6   = 0xf720116c, r7   = 0xf72019b8
r8   = 0xf72019b8, r9   = 0xf7612ff8
r10  = 0xf720fb10, fp   = 0x0000018f
ip   = 0x00000001, sp   = 0xffee37e0
lr   = 0xf71f11f9, pc   = 0x00000000
cpsr = 0x60000030

Memory Information
MemTotal:   620380 KB
MemFree:     26172 KB
Buffers:     17332 KB
Cached:     145684 KB
VmPeak:      77568 KB
VmSize:      77568 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24064 KB
VmRSS:       24064 KB
VmData:      21252 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       21132 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5695 TID = 5695
5695 5721 5730 

Maps Information
f2d64000 f3563000 rw-p [stack:5730]
f3702000 f3719000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f3726000 f3731000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f373a000 f3745000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f374e000 f3f4d000 rw-p [stack:5721]
f414d000 f415d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4165000 f4170000 r-xp /usr/lib/libtbm.so.1.0.0
f4178000 f41c1000 r-xp /usr/lib/libmdm.so.1.2.69
f41c9000 f41cf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f41d7000 f41d9000 r-xp /usr/lib/libdri2.so.0.0.0
f41e1000 f41e9000 r-xp /usr/lib/libdrm.so.2.4.0
f41f1000 f4201000 r-xp /usr/lib/libwidget_provider.so.1.0.0
f4209000 f4212000 r-xp /usr/lib/libcom-core.so.0.0.1
f5ab4000 f5ab9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5ac1000 f5ada000 r-xp /usr/lib/libnetwork.so.0.0.0
f5ae2000 f5aec000 r-xp /usr/lib/libwidget.so.1.0.0
f5af4000 f5b07000 r-xp /usr/lib/libwidget_service.so.1.0.0
f5b10000 f5b17000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
f5b20000 f5c26000 r-xp /usr/lib/libicuuc.so.57.1
f5c3c000 f5dc4000 r-xp /usr/lib/libicui18n.so.57.1
f5dd4000 f5de1000 r-xp /usr/lib/libalarm.so.0.0.0
f5deb000 f5dfa000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f5e03000 f5e13000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f5e1b000 f5e23000 r-xp /usr/lib/libappcore-watch.so.1.1
f5e35000 f5e3a000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f5fd4000 f5fde000 r-xp /lib/libnss_files-2.13.so
f5fe7000 f60b6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f60cc000 f60f0000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f60f9000 f60ff000 r-xp /usr/lib/libappsvc.so.0.1.0
f6107000 f610b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6119000 f611b000 r-xp /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
f612b000 f612d000 r-xp /usr/lib/libiniparser.so.0
f6136000 f613b000 r-xp /usr/lib/libappcore-common.so.1.1
f6143000 f6145000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f614e000 f6152000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f615f000 f6161000 r-xp /usr/lib/libXau.so.6.0.0
f6169000 f6170000 r-xp /lib/libcrypt-2.13.so
f61a0000 f61a2000 r-xp /usr/lib/libiri.so
f61ab000 f6354000 r-xp /usr/lib/libcrypto.so.1.0.0
f6374000 f63bb000 r-xp /usr/lib/libssl.so.1.0.0
f63c7000 f63f5000 r-xp /usr/lib/libidn.so.11.5.44
f63fd000 f6406000 r-xp /usr/lib/libcares.so.2.1.0
f6410000 f6423000 r-xp /usr/lib/libxcb.so.1.1.0
f642c000 f642e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6436000 f6438000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6441000 f650d000 r-xp /usr/lib/libxml2.so.2.7.8
f651a000 f651c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6525000 f652a000 r-xp /usr/lib/libffi.so.5.0.10
f6532000 f6533000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f653b000 f653e000 r-xp /lib/libattr.so.1.1.0
f6546000 f65da000 r-xp /usr/lib/libstdc++.so.6.0.16
f65ed000 f660a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6614000 f662c000 r-xp /usr/lib/libpng12.so.0.50.0
f6634000 f664a000 r-xp /lib/libexpat.so.1.6.0
f6654000 f6698000 r-xp /usr/lib/libcurl.so.4.3.0
f66a1000 f66ab000 r-xp /usr/lib/libXext.so.6.4.0
f66b4000 f66b8000 r-xp /usr/lib/libXtst.so.6.1.0
f66c0000 f66c6000 r-xp /usr/lib/libXrender.so.1.3.0
f66ce000 f66d4000 r-xp /usr/lib/libXrandr.so.2.2.0
f66dc000 f66dd000 r-xp /usr/lib/libXinerama.so.1.0.0
f66e6000 f66ef000 r-xp /usr/lib/libXi.so.6.1.0
f66f7000 f66fa000 r-xp /usr/lib/libXfixes.so.3.1.0
f6702000 f6704000 r-xp /usr/lib/libXgesture.so.7.0.0
f670c000 f670e000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6716000 f6718000 r-xp /usr/lib/libXdamage.so.1.1.0
f6720000 f6727000 r-xp /usr/lib/libXcursor.so.1.0.2
f672f000 f6732000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f673a000 f673e000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6747000 f674c000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6755000 f6836000 r-xp /usr/lib/libX11.so.6.3.0
f6841000 f6864000 r-xp /usr/lib/libjpeg.so.8.0.2
f687c000 f6892000 r-xp /lib/libz.so.1.2.5
f689a000 f689c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68a4000 f6919000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6923000 f693d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6945000 f6979000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6982000 f6a55000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a60000 f6a70000 r-xp /lib/libresolv-2.13.so
f6a74000 f6a8c000 r-xp /usr/lib/liblzma.so.5.0.3
f6a94000 f6a97000 r-xp /lib/libcap.so.2.21
f6a9f000 f6ace000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ad7000 f6ad8000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6ae0000 f6ae6000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6aee000 f6b05000 r-xp /usr/lib/liblua-5.1.so
f6b0e000 f6b15000 r-xp /usr/lib/libembryo.so.1.7.99
f6b1d000 f6b23000 r-xp /lib/librt-2.13.so
f6b2c000 f6b82000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6b8f000 f6be5000 r-xp /usr/lib/libfreetype.so.6.11.3
f6bf1000 f6c19000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6c1a000 f6c5f000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6c68000 f6c7b000 r-xp /usr/lib/libfribidi.so.0.3.1
f6c83000 f6c9d000 r-xp /usr/lib/libecore_con.so.1.7.99
f6ca6000 f6caf000 r-xp /usr/lib/libedbus.so.1.7.99
f6cb7000 f6d07000 r-xp /usr/lib/libecore_x.so.1.7.99
f6d09000 f6d12000 r-xp /usr/lib/libvconf.so.0.2.45
f6d1a000 f6d2b000 r-xp /usr/lib/libecore_input.so.1.7.99
f6d33000 f6d38000 r-xp /usr/lib/libecore_file.so.1.7.99
f6d40000 f6d62000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6d6b000 f6dac000 r-xp /usr/lib/libeina.so.1.7.99
f6db5000 f6dce000 r-xp /usr/lib/libeet.so.1.7.99
f6ddf000 f6e48000 r-xp /lib/libm-2.13.so
f6e51000 f6e57000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e60000 f6e61000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e69000 f6e8c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e94000 f6e99000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ea1000 f6ecb000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ed4000 f6eeb000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ef3000 f6efe000 r-xp /lib/libunwind.so.8.0.1
f6f2b000 f6f49000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f53000 f7077000 r-xp /lib/libc-2.13.so
f7085000 f708d000 r-xp /lib/libgcc_s-4.6.so.1
f708e000 f7092000 r-xp /usr/lib/libsmack.so.1.0.0
f709b000 f70a1000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f70a9000 f7179000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f717a000 f71d8000 r-xp /usr/lib/libedje.so.1.7.99
f71e2000 f71f9000 r-xp /usr/lib/libecore.so.1.7.99
f7210000 f72de000 r-xp /usr/lib/libevas.so.1.7.99
f7303000 f743f000 r-xp /usr/lib/libelementary.so.1.7.99
f7456000 f746a000 r-xp /lib/libpthread-2.13.so
f7475000 f7477000 r-xp /usr/lib/libdlog.so.0.0.0
f747f000 f7482000 r-xp /usr/lib/libbundle.so.0.1.22
f748a000 f748c000 r-xp /lib/libdl-2.13.so
f7495000 f74a2000 r-xp /usr/lib/libaul.so.0.1.0
f74b4000 f74ba000 r-xp /usr/lib/libappcore-efl.so.1.1
f74c3000 f74c7000 r-xp /usr/lib/libsys-assert.so
f74d0000 f74ed000 r-xp /lib/ld-2.13.so
f74f6000 f74fb000 r-xp /usr/bin/launchpad-loader
f75db000 f77ab000 rw-p [heap]
ffec4000 ffee5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5695)
Call Stack Count: 2
 0: (0xf71f11f9) [/usr/lib/libecore.so.1] + 0xf1f9
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
heck_lock_type:46] current lock state :[0],testmode[0]
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
09-17 11:29:12.721-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11056316269741505672559
09-17 11:29:14.131-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 11056666269741505672657
09-17 11:29:14.431-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(4) to(6467)
09-17 11:29:14.431-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 4
09-17 11:29:14.441-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(org.example.bitcoinwatch) pid(6467) type(watchapp)
09-17 11:29:14.441-0700 E/AUL     ( 2557): app_sock.c: __connect_client_sock(196) > connect error: 111
09-17 11:29:14.441-0700 E/AUL     ( 2557): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-17 11:29:14.481-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6467 pgid = 6467
09-17 11:29:14.481-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
09-17 11:29:14.531-0700 W/AUL_PAD ( 3495): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
09-17 11:29:14.541-0700 E/AUL     ( 2557): app_sock.c: __connect_client_sock(196) > connect error: 111
09-17 11:29:14.541-0700 E/AUL     ( 2557): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-17 11:29:14.841-0700 E/AUL     ( 2557): app_sock.c: __connect_client_sock(196) > connect error: 111
09-17 11:29:14.841-0700 E/AUL     ( 2557): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
09-17 11:29:14.841-0700 E/AUL_AMD ( 2557): amd_launch.c: _term_app(1106) > fail to killing - 6467
09-17 11:29:14.841-0700 I/AUL_AMD ( 2557): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6467
09-17 11:29:14.841-0700 W/AUL     ( 2557): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6467)
09-17 11:29:14.841-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(298) > request cmd(4) result(-1)
09-17 11:29:14.841-0700 W/AUL     ( 2764): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.bitcoinwatch)
09-17 11:29:14.841-0700 W/AUL_AMD ( 2557): amd_request.c: __request_handler(669) > __request_handler: 0
09-17 11:29:14.841-0700 E/RESOURCED( 2702): proc-main.c: proc_app_list_remove_app_info(669) > Failed to remove appinfo 'org.example.bitcoinwatch': Not a directory
09-17 11:29:14.851-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:29:14.861-0700 I/AUL_AMD ( 2557): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
09-17 11:29:14.861-0700 E/AUL_AMD ( 2557): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
09-17 11:29:14.861-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(1782) > caller pid : 2764
09-17 11:29:14.871-0700 E/RESOURCED( 2702): block.c: block_prelaunch_state(138) > insert data org.example.bitcoinwatch, table num : 2
09-17 11:29:14.871-0700 W/AUL_AMD ( 2557): amd_launch.c: _start_app(2218) > pad pid(-5)
09-17 11:29:14.871-0700 W/AUL_PAD ( 3495): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
09-17 11:29:14.871-0700 W/AUL_PAD ( 3495): launchpad.c: __send_result_to_caller(272) > Check app launching
09-17 11:29:14.881-0700 W/AUL_PAD ( 6489): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
09-17 11:29:14.881-0700 W/AUL_PAD ( 6489): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
09-17 11:29:14.881-0700 W/AUL_PAD ( 6489): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
09-17 11:29:14.881-0700 W/AUL_PAD ( 6489): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.bitcoinwatch)
09-17 11:29:14.901-0700 W/AUL_PAD ( 6489): launchpad_loader.c: main(690) > [candidate] dlsym
09-17 11:29:14.901-0700 W/AUL_PAD ( 6489): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.bitcoinwatch)
09-17 11:29:14.901-0700 I/CAPI_WATCH_APPLICATION( 6489): watch_app_main.c: watch_app_main(399) > watch_app_main
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
09-17 11:29:20.861-0700 W/CRASH_MANAGER( 3220): worker.c: worker_job(1205) > 1105695626974150567283
