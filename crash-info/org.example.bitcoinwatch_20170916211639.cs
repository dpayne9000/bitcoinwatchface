S/W Version Information
Model: SM-R765V
Tizen-Version: 2.3.2.3
Build-Number: R765VVRU1AQF4
Build-Date: 2017.07.17 17:00:49

Crash Information
Process Name: bitcoinwatch
PID: 4965
Date: 2017-09-16 21:16:39-0700
Executable File Path: /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x50

Register Information
r0   = 0x00000050, r1   = 0x00000050
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xffa516c8
r6   = 0xf75bc86c, r7   = 0x00000050
r8   = 0x00000000, r9   = 0x00000000
r10  = 0xf75bc86b, fp   = 0xffa516bc
ip   = 0xffa51bfc, sp   = 0xffa51150
lr   = 0xf71a4e8c, pc   = 0xf71da0b4
cpsr = 0x60000010

Memory Information
MemTotal:   620380 KB
MemFree:     11160 KB
Buffers:     17540 KB
Cached:     163880 KB
VmPeak:     132964 KB
VmSize:     132960 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29916 KB
VmRSS:       29912 KB
VmData:      73064 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       25208 KB
VmPTE:         152 KB
VmSwap:          0 KB

Threads Information
Threads: 9
PID = 4965 TID = 4965
4965 4968 4974 4975 4976 4977 4978 4979 4984 

Maps Information
efa3b000 f023a000 rw-p [stack:4984]
f02d7000 f02ee000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f0541000 f0d40000 rw-p [stack:4979]
f0d41000 f1540000 rw-p [stack:4978]
f1541000 f1d40000 rw-p [stack:4977]
f1d41000 f2540000 rw-p [stack:4976]
f2541000 f2d40000 rw-p [stack:4975]
f2d41000 f3540000 rw-p [stack:4974]
f3540000 f3544000 r-xp /usr/lib/libxcb-xfixes.so.0.0.0
f354c000 f354f000 r-xp /usr/lib/libxcb-dri2.so.0.0.0
f3557000 f3558000 r-xp /usr/lib/libX11-xcb.so.1.0.0
f3577000 f390b000 r-xp /usr/lib/egl/libmali.so
f3938000 f3a2a000 r-xp /usr/lib/libCOREGL.so.4.0
f3a43000 f3a45000 r-xp /usr/lib/libttrace.so.1.1
f3a4d000 f3a51000 r-xp /usr/lib/libEGL.so.1.4
f3a61000 f3a72000 r-xp /usr/lib/libGLESv2.so.2.0
f3a85000 f3a90000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f3a99000 f3b0e000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
f3b1f000 f431e000 rw-p [stack:4968]
f4526000 f4529000 r-xp /lib/libattr.so.1.1.0
f4531000 f4533000 r-xp /usr/lib/libXau.so.6.0.0
f453b000 f4542000 r-xp /lib/libcrypt-2.13.so
f4573000 f4576000 r-xp /lib/libcap.so.2.21
f457e000 f4580000 r-xp /usr/lib/libiri.so
f4588000 f4598000 r-xp /usr/lib/libmdm-common.so.1.1.24
f45a1000 f45b4000 r-xp /usr/lib/libxcb.so.1.1.0
f45bd000 f45c8000 r-xp /usr/lib/libtbm.so.1.0.0
f45d0000 f45d2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f45da000 f45f7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f4601000 f4605000 r-xp /usr/lib/libsmack.so.1.0.0
f460e000 f4610000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f4618000 f4628000 r-xp /lib/libresolv-2.13.so
f462c000 f4644000 r-xp /usr/lib/liblzma.so.5.0.3
f464c000 f464e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f4657000 f466f000 r-xp /usr/lib/libpng12.so.0.50.0
f4677000 f468d000 r-xp /lib/libexpat.so.1.6.0
f4697000 f46a1000 r-xp /usr/lib/libXext.so.6.4.0
f46aa000 f46ae000 r-xp /usr/lib/libXtst.so.6.1.0
f46b6000 f46bc000 r-xp /usr/lib/libXrender.so.1.3.0
f46c5000 f46cb000 r-xp /usr/lib/libXrandr.so.2.2.0
f46d3000 f46d4000 r-xp /usr/lib/libXinerama.so.1.0.0
f46dd000 f46e6000 r-xp /usr/lib/libXi.so.6.1.0
f46ee000 f46f1000 r-xp /usr/lib/libXfixes.so.3.1.0
f46f9000 f46fb000 r-xp /usr/lib/libXgesture.so.7.0.0
f4703000 f4705000 r-xp /usr/lib/libXcomposite.so.1.0.0
f470e000 f4710000 r-xp /usr/lib/libXdamage.so.1.1.0
f4718000 f471f000 r-xp /usr/lib/libXcursor.so.1.0.2
f4727000 f4728000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f4730000 f4736000 r-xp /usr/lib/libecore_imf.so.1.7.99
f473e000 f4755000 r-xp /usr/lib/liblua-5.1.so
f475f000 f4766000 r-xp /usr/lib/libembryo.so.1.7.99
f476e000 f4771000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f4779000 f477d000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f4786000 f478b000 r-xp /usr/lib/libecore_fb.so.1.7.99
f4794000 f47b7000 r-xp /usr/lib/libjpeg.so.8.0.2
f47d0000 f489c000 r-xp /usr/lib/libxml2.so.2.7.8
f48a9000 f48ab000 r-xp /usr/lib/libiniparser.so.0
f48b4000 f48fd000 r-xp /usr/lib/libmdm.so.1.2.69
f4905000 f490b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f4913000 f4915000 r-xp /usr/lib/libdri2.so.0.0.0
f491e000 f49ff000 r-xp /usr/lib/libX11.so.6.3.0
f4a0a000 f4a12000 r-xp /usr/lib/libdrm.so.2.4.0
f4a1a000 f4a1c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f4a25000 f4a35000 r-xp /usr/lib/libwidget_provider.so.1.0.0
f4a3d000 f4a43000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f4a4d000 f4a56000 r-xp /usr/lib/libcom-core.so.0.0.1
f62f8000 f638c000 r-xp /usr/lib/libstdc++.so.6.0.16
f639f000 f6414000 r-xp /usr/lib/libsqlite3.so.0.8.6
f641e000 f6438000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6441000 f6446000 r-xp /usr/lib/libffi.so.5.0.10
f644e000 f6454000 r-xp /lib/librt-2.13.so
f645d000 f645e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6466000 f646c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6474000 f64a3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f64ad000 f6580000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f658b000 f65a9000 r-xp /usr/lib/libsystemd.so.0.4.0
f65b3000 f65b4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f65bc000 f65c1000 r-xp /usr/lib/libxdgmime.so.1.1.0
f65c9000 f65cc000 r-xp /usr/lib/libbundle.so.0.1.22
f65d5000 f662b000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6638000 f668e000 r-xp /usr/lib/libfreetype.so.6.11.3
f669a000 f66c2000 r-xp /usr/lib/libfontconfig.so.1.8.0
f66c3000 f6708000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6711000 f6724000 r-xp /usr/lib/libfribidi.so.0.3.1
f672d000 f6747000 r-xp /usr/lib/libecore_con.so.1.7.99
f6750000 f6759000 r-xp /usr/lib/libedbus.so.1.7.99
f6761000 f67b1000 r-xp /usr/lib/libecore_x.so.1.7.99
f67b3000 f6811000 r-xp /usr/lib/libedje.so.1.7.99
f681b000 f682c000 r-xp /usr/lib/libecore_input.so.1.7.99
f6834000 f6839000 r-xp /usr/lib/libecore_file.so.1.7.99
f6841000 f6863000 r-xp /usr/lib/libecore_evas.so.1.7.99
f686c000 f6885000 r-xp /usr/lib/libeet.so.1.7.99
f6896000 f68ff000 r-xp /lib/libm-2.13.so
f6908000 f691e000 r-xp /lib/libz.so.1.2.5
f6926000 f6acf000 r-xp /usr/lib/libcrypto.so.1.0.0
f6aef000 f6b36000 r-xp /usr/lib/libssl.so.1.0.0
f6b42000 f6b70000 r-xp /usr/lib/libidn.so.11.5.44
f6b78000 f6b81000 r-xp /usr/lib/libcares.so.2.1.0
f6b8a000 f6b8f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6b97000 f6bb0000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bb8000 f6bc2000 r-xp /usr/lib/libwidget.so.1.0.0
f6bca000 f6bdd000 r-xp /usr/lib/libwidget_service.so.1.0.0
f6be6000 f6bed000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
f6bf6000 f6c20000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c29000 f6cf9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cfa000 f6d03000 r-xp /usr/lib/libvconf.so.0.2.45
f6d0b000 f6e11000 r-xp /usr/lib/libicuuc.so.57.1
f6e27000 f6faf000 r-xp /usr/lib/libicui18n.so.57.1
f6fbf000 f7000000 r-xp /usr/lib/libeina.so.1.7.99
f7009000 f7020000 r-xp /usr/lib/libecore.so.1.7.99
f7037000 f705a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7062000 f7066000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f706f000 f7083000 r-xp /lib/libpthread-2.13.so
f708e000 f70c2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f70cb000 f70d8000 r-xp /usr/lib/libalarm.so.0.0.0
f70e2000 f70f9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7101000 f710e000 r-xp /usr/lib/libaul.so.0.1.0
f7118000 f711a000 r-xp /lib/libdl-2.13.so
f7123000 f712e000 r-xp /lib/libunwind.so.8.0.1
f715b000 f7163000 r-xp /lib/libgcc_s-4.6.so.1
f7164000 f7288000 r-xp /lib/libc-2.13.so
f7296000 f72a5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f72ae000 f737c000 r-xp /usr/lib/libevas.so.1.7.99
f73a1000 f74dd000 r-xp /usr/lib/libelementary.so.1.7.99
f74f4000 f74f6000 r-xp /usr/lib/libdlog.so.0.0.0
f74fe000 f7542000 r-xp /usr/lib/libcurl.so.4.3.0
f754b000 f755b000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f7563000 f7565000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f756e000 f7576000 r-xp /usr/lib/libappcore-watch.so.1.1
f7587000 f758c000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f7595000 f75b2000 r-xp /lib/ld-2.13.so
f75bb000 f75bd000 r-xp /opt/usr/apps/org.example.bitcoinwatch/bin/bitcoinwatch
f75bd000 f75c1000 r-xp /usr/lib/libsys-assert.so
f7811000 f7cdd000 rw-p [heap]
ffa33000 ffa54000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4965)
Call Stack Count: 1
 0: strlen + 0x4 (0xf71da0b4) [/lib/libc.so.6] + 0x760b4
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
CommonUtilSystemSettingsCallback(167) > registerd 2 callbacks for key[12]
09-16 21:16:41.739-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: UpdateLocale(540) > mCountry[en_US]
09-16 21:16:41.739-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddListener(1209) > added listener[0xec402c28] for [28]
09-16 21:16:41.739-0700 I/watchface-viewer( 4960): viewer-util.cpp: GetCountry(626) > country[en_US]
09-16 21:16:41.739-0700 I/watchface-viewer( 4960): viewer-util.cpp: GetCountry(626) > country[en_US]
09-16 21:16:41.739-0700 I/watchface-viewer( 4960): viewer-util.cpp: GetSystemLocale(755) > mLocale[en_US]
09-16 21:16:41.749-0700 I/watchface-viewer( 4960): viewer-part-resource.cpp: ThreadCallback(2402) > thread[0xec401668]
09-16 21:16:41.769-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: FromUTF8(703) > empty string!!
09-16 21:16:41.769-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: UpdateAmPmString(1638) > skeleton[h:mm a] locale[en_US] showAmpmFirst[0]
09-16 21:16:41.769-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: FromUTF8(703) > empty string!!
09-16 21:16:41.769-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: FromUTF8(703) > empty string!!
09-16 21:16:41.769-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [3] to pending list
09-16 21:16:41.769-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: UpdateLocale(527) > mLocale[en_US]
09-16 21:16:41.769-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: UpdateLocale(540) > mCountry[en_US]
09-16 21:16:41.779-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: Create(318) > created locale[en_US] impl[0xec418e18] refcount[1]
09-16 21:16:41.779-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: UpdateAmPmString(1651) > hourString[10] hour[10]
09-16 21:16:41.779-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: FromUTF8(703) > empty string!!
09-16 21:16:41.779-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: FromUTF8(703) > empty string!!
09-16 21:16:41.779-0700 I/watchface-viewer( 4960): viewer-util.cpp: GetAmpmShortStringCutLength(1120) > en-GB ampmString[a.m.] length[4] cutLength[5]
09-16 21:16:41.789-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: Destroy(338) > reference decreased locale[en_US] impl[0xec418e18] refcount[0]
09-16 21:16:41.789-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: Destroy(342) > removed CommonUtilI18NStringUtilityImpl[0xec418e18]
09-16 21:16:41.789-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: UpdateAmPmString(1700) > mAm[AM] mPm[PM]
09-16 21:16:41.799-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: CreateEvasBuffer(80) > created mEvas[0xec40a6c8] size(360x256)
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddListener(1209) > added listener[0xf779f0e0] for [14]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddListener(1209) > added listener[0xf779f770] for [7]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddListener(1209) > added listener[0xf779f7b8] for [4]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-group-manager.cpp: AddGroupInitialPosition(158) > added predefined position [ambient-bg] at (0,0)
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-group.cpp: Group(97) > Group[0xf779fda8][ambient-bg]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-part.cpp: Part(49) > Part[0xf77a0268]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-part-resource.cpp: PartResource(57) > PartResource[0xf77a0970]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-part-resource.cpp: SetUpdateImage(2282) > new mThread[0xf77a1078]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-group-manager.cpp: AddGroupInitialPosition(158) > added predefined position [ambient-time] at (0,0)
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-group.cpp: Group(97) > Group[0xf77a1320][ambient-time]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-part.cpp: Part(49) > Part[0xf77a17e8]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-part-resource.cpp: PartResource(57) > PartResource[0xf77acd08]
09-16 21:16:41.809-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: UpdateLocale(527) > mLocale[en_US]
09-16 21:16:41.809-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: UpdateLocale(540) > mCountry[en_US]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddListener(1209) > added listener[0xf77a1a48] for [28]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-util.cpp: GetCountry(626) > country[en_US]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-util.cpp: GetCountry(626) > country[en_US]
09-16 21:16:41.809-0700 I/watchface-viewer( 4960): viewer-util.cpp: GetSystemLocale(755) > mLocale[en_US]
09-16 21:16:41.819-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: FromUTF8(703) > empty string!!
09-16 21:16:41.829-0700 I/watchface-viewer( 4960): viewer-part-resource.cpp: ThreadCallback(2402) > thread[0xf77a1078]
09-16 21:16:41.829-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: UpdateAmPmString(1638) > skeleton[h:mm a] locale[en_US] showAmpmFirst[0]
09-16 21:16:41.829-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: FromUTF8(703) > empty string!!
09-16 21:16:41.829-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: FromUTF8(703) > empty string!!
09-16 21:16:41.829-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: UpdateLocale(527) > mLocale[en_US]
09-16 21:16:41.829-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: UpdateLocale(540) > mCountry[en_US]
09-16 21:16:41.829-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: Create(318) > created locale[en_US] impl[0xf77bc030] refcount[1]
09-16 21:16:41.829-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: UpdateAmPmString(1651) > hourString[10] hour[10]
09-16 21:16:41.829-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: FromUTF8(703) > empty string!!
09-16 21:16:41.829-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: Destroy(338) > reference decreased locale[en_US] impl[0xf77bc030] refcount[0]
09-16 21:16:41.829-0700 I/watchface-common-util( 4960): common-util-i18n.cpp: Destroy(342) > removed CommonUtilI18NStringUtilityImpl[0xf77bc030]
09-16 21:16:41.829-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: UpdateAmPmString(1700) > mAm[AM] mPm[PM]
09-16 21:16:41.829-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: CreateEvasBuffer(80) > created mEvas[0xf77bc258] size(360x256)
09-16 21:16:41.829-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddListener(1209) > added listener[0xf77bc8a0] for [14]
09-16 21:16:41.829-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddListener(1209) > added listener[0xf77ad2f0] for [7]
09-16 21:16:41.829-0700 E/watchface-viewer( 4960): viewer-part-resource-evas.cpp: ApplyAutoRefreshAodColon(1263) > colon moved from (2147483647,2147483647) to (0,0)
09-16 21:16:41.829-0700 E/watchface-viewer( 4960): viewer-auto-refresh-aod.cpp: ApplyConfig(269) > aod type config[2] applied[2]
09-16 21:16:41.829-0700 I/watchface-viewer( 4960): viewer-impl.cpp: LoadWatchfaceData(497) > preview path set and cleared!!
09-16 21:16:41.829-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: ConnectModels(445) > first resume not received yet!! connect system models only!!
09-16 21:16:41.839-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAmbientUpdatePeriodTypeChangeRequested(395) > AmbientUpdatePeriodType[0] applied
09-16 21:16:41.839-0700 I/watchface-viewer( 4960): viewer-auto-refresh-aod.cpp: SetApplyConfigMode(184) > ApplyConfigMode changed [1] -> [0]
09-16 21:16:41.839-0700 I/watchface-viewer( 4960): viewer-parser.cpp: ~ParserWatchfaceData(878) > 
09-16 21:16:41.839-0700 W/WATCH_CORE( 4960): appcore-watch.c: __widget_create(1088) > widget_create done, widgh: 360, height: 360
09-16 21:16:41.919-0700 E/WIDGET_PROVIDER_APP( 4960): client.c: client_init_sync(1380) > widget_provider_init return [0]
09-16 21:16:41.969-0700 I/WATCH_CORE( 4960): appcore-watch.c: __watch_core_set_metadata(910) > Tick per second: 5
09-16 21:16:41.969-0700 I/WATCH_CORE( 4960): appcore-watch.c: __watch_core_set_metadata(918) > No metadata info for the minute tick
09-16 21:16:41.969-0700 I/WATCH_CORE( 4960): appcore-watch.c: __watch_core_set_metadata(935) > Background tick update feature
09-16 21:16:41.969-0700 W/WATCH_CORE( 4960): appcore-watch.c: __watch_core_set_metadata(949) > Watchface type
09-16 21:16:42.029-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppControl(509) > 
09-16 21:16:42.029-0700 W/CAPI_APPFW_APP_CONTROL( 4960): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
09-16 21:16:42.039-0700 I/watchface-common-util( 4960): common-util-app-main.cpp: GetExtraData(56) > app_control_get_extra_data(__AOD_OP_TYPE__) returns -126(ffffff82)
09-16 21:16:42.039-0700 I/watchface-viewer( 4960): viewer-part-resource.cpp: ThreadNotifyCallback(2464) > thread[0xec401668]
09-16 21:16:42.039-0700 I/watchface-viewer( 4960): viewer-part-resource.cpp: ThreadEndCallback(2500) > thread[0xec401668]
09-16 21:16:42.039-0700 I/watchface-viewer( 4960): viewer-part-resource.cpp: ThreadNotifyCallback(2464) > thread[0xf77a1078]
09-16 21:16:42.049-0700 I/watchface-viewer( 4960): viewer-part-resource.cpp: ThreadEndCallback(2500) > thread[0xf77a1078]
09-16 21:16:42.049-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [28] to pending list
09-16 21:16:42.049-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [14] to pending list
09-16 21:16:42.049-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [7] to pending list
09-16 21:16:42.049-0700 I/watchface-viewer( 4960): viewer-util.cpp: GetAppId(70) > appId[com.samsung.watchface]
09-16 21:16:42.069-0700 W/W_HOME  ( 2872): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
09-16 21:16:42.069-0700 W/W_HOME  ( 2872): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-16 21:16:42.069-0700 W/W_HOME  ( 2872): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-16 21:16:42.069-0700 W/W_HOME  ( 2872): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-16 21:16:42.069-0700 W/W_HOME  ( 2872): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
09-16 21:16:42.069-0700 W/W_INDICATOR( 2796): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-16 21:16:42.079-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-16 21:16:42.079-0700 W/PROCESSMGR( 2368): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
09-16 21:16:42.099-0700 W/AUL_AMD ( 2558): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
09-16 21:16:42.099-0700 W/AUL_AMD ( 2558): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
09-16 21:16:42.099-0700 W/W_HOME  ( 2872): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
09-16 21:16:42.099-0700 W/W_HOME  ( 2872): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-16 21:16:42.099-0700 W/W_HOME  ( 2872): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-16 21:16:42.099-0700 W/W_HOME  ( 2872): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-16 21:16:42.099-0700 W/W_HOME  ( 2872): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
09-16 21:16:42.109-0700 W/W_INDICATOR( 2796): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
09-16 21:16:42.119-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
09-16 21:16:42.119-0700 W/W_INDICATOR( 2796): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
09-16 21:16:42.159-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(96), length(2)
09-16 21:16:42.169-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 96%
09-16 21:16:42.169-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 96, isCharging: 0
09-16 21:16:42.169-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_100
09-16 21:16:42.169-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_icon_update(348) > [windicator_battery_icon_update:348] [Verizon] Battery level : 100
09-16 21:16:42.169-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
09-16 21:16:42.189-0700 W/AUL_AMD ( 2558): amd_request.c: __request_handler(669) > __request_handler: 14
09-16 21:16:42.199-0700 E/EFL     ( 4960): elementary<4960> elm_layout.c:2216 elm_layout_add() could not add 0xf77a5bd8 as sub object of 0xf77a58e8
09-16 21:16:42.199-0700 W/AUL_AMD ( 2558): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4960
09-16 21:16:42.199-0700 W/AUL_AMD ( 2558): amd_request.c: __request_handler(669) > __request_handler: 12
09-16 21:16:42.239-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: CreateImage(133) > resized 360x256 -> 330x257
09-16 21:16:42.239-0700 E/EFL     ( 4960): edje<4960> edje_util.c:3785 edje_object_size_min_restricted_calc() group digital-clock/12/10-12/last has a non-fixed part 'hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-16 21:16:42.249-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: UpdateLayout(1547) > colon 30x140 at (151,42)
09-16 21:16:42.259-0700 E/EFL     ( 4960): elementary<4960> elm_layout.c:2216 elm_layout_add() could not add 0xf77a6620 as sub object of 0xf77a5a60
09-16 21:16:42.259-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: CreateImage(133) > resized 360x256 -> 330x257
09-16 21:16:42.259-0700 E/EFL     ( 4960): edje<4960> edje_util.c:3785 edje_object_size_min_restricted_calc() group digital-clock/12/10-12/last has a non-fixed part 'hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-16 21:16:42.259-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: UpdateLayout(1547) > colon 30x140 at (151,42)
09-16 21:16:42.259-0700 E/watchface-viewer( 4960): viewer-part-resource-evas.cpp: ApplyAutoRefreshAodColon(1263) > colon moved from (0,0) to (151,42)
09-16 21:16:42.269-0700 E/watchface-viewer( 4960): viewer-auto-refresh-aod.cpp: ApplyConfig(269) > aod type config[2] applied[2]
09-16 21:16:42.299-0700 W/WATCH_CORE( 4960): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
09-16 21:16:42.299-0700 I/WATCH_CORE( 4960): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
09-16 21:16:42.299-0700 I/CAPI_WATCH_APPLICATION( 4960): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-16 21:16:42.299-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppTimeTick(579) > 
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [1]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [1] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [2]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [2] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [3]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [5]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [5] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [2]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [4]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [4] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [6]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [6] to pending list
09-16 21:16:42.299-0700 W/WATCH_CORE( 4960): appcore-watch.c: __widget_resume(1124) > widget_resume
09-16 21:16:42.299-0700 W/AUL     ( 4960): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(4960) status(fg) type(watchapp)
09-16 21:16:42.299-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppResume(560) > 
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [30]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [30]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [30] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [31]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [31]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [31] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [29]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [29]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [29] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [32]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [32]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [32] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [35]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [35]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [35] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [36]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [36]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [36] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [37]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [37]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [37] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [38]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [38]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [38] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [88]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [88]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [88] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [90]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [90]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [90] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [3]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [3]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [3] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [28]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [28]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [28] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [14]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [14]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [14] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [7]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [7]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [7] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [1]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [1]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [1] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [2]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [2]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [2] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [5]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [5]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [5] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [4]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [4]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [4] to pending list
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [6]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [6]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: AddPendingChanges(2306) > added [6] to pending list
09-16 21:16:42.299-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppResume(567) > mFirstResumeDone
09-16 21:16:42.299-0700 I/CAPI_WATCH_APPLICATION( 4960): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-16 21:16:42.299-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppTimeTick(579) > 
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [1]
09-16 21:16:42.299-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [2]
09-16 21:16:42.339-0700 I/watchface-viewer( 4960): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(561) > ImagesLoadingDoneSignal().Emit()
09-16 21:16:42.339-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnLoadingDone(629) > 
09-16 21:16:42.339-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnLoadingDone(632) > idle_watch = [com.samsung.watchface]
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.watchface-editor:watch-face-editor::localport]
09-16 21:16:42.339-0700 E/MESSAGE_PORT( 2473): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-16 21:16:42.339-0700 E/MESSAGE_PORT( 4960): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (watch-face-editor::localport) is not found.
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.clocksetting.clock:clocksetting::localport]
09-16 21:16:42.339-0700 E/MESSAGE_PORT( 2473): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-16 21:16:42.339-0700 E/MESSAGE_PORT( 4960): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (clocksetting::localport) is not found.
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:w-home::localport]
09-16 21:16:42.339-0700 E/MESSAGE_PORT( 2473): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
09-16 21:16:42.339-0700 I/MESSAGE_PORT( 2473): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
09-16 21:16:42.339-0700 E/MESSAGE_PORT( 4960): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (w-home::localport) is not found.
09-16 21:16:42.339-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnLoadingDone(671) > mFirstLoadingDone
09-16 21:16:42.339-0700 I/watchface-viewer( 4960): viewer-view.cpp: RemovePreview(1013) > previewActor removed!!
09-16 21:16:42.389-0700 I/CAPI_WATCH_APPLICATION( 4960): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-16 21:16:42.389-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppTimeTick(579) > 
09-16 21:16:42.389-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [1]
09-16 21:16:42.389-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [2]
09-16 21:16:42.589-0700 I/CAPI_WATCH_APPLICATION( 4960): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-16 21:16:42.589-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppTimeTick(579) > 
09-16 21:16:42.589-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [1]
09-16 21:16:42.589-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: NotifyListeners(1273) > dummy mode!! ignored!! [2]
09-16 21:16:42.669-0700 E/TIZEN_N_SYSTEM_SETTINGS( 4960): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
09-16 21:16:42.669-0700 E/TIZEN_N_SYSTEM_SETTINGS( 4960): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
09-16 21:16:42.669-0700 E/TIZEN_N_SYSTEM_SETTINGS( 4960): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=28
09-16 21:16:42.669-0700 E/TIZEN_N_SYSTEM_SETTINGS( 4960): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 25, key = 28, type = 1
09-16 21:16:42.669-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnDummyModeOffTimerExpired(294) > disable dummy mode
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-impl.cpp: SetDummyMode(118) > dummyMode[0]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [30]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [31]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [29]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [32]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [35]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [36]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [37]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [38]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [88]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [90]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [3]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [28]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [14]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [7]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [1]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [2]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [5]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [4]
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: Notify(1236) > skip first tick after resume!!
09-16 21:16:42.669-0700 I/watchface-viewer( 4960): viewer-data-provider.cpp: FlushPendingChanges(2317) > notify pending [6]
09-16 21:16:42.679-0700 E/EFL     ( 4960): elementary<4960> elm_layout.c:2216 elm_layout_add() could not add 0xf77a7068 as sub object of 0xf77a58e8
09-16 21:16:42.679-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: CreateImage(133) > resized 330x257 -> 254x257
09-16 21:16:42.679-0700 E/EFL     ( 4960): edje<4960> edje_util.c:3785 edje_object_size_min_restricted_calc() group digital-clock/12/1-9/last has a non-fixed part 'minute'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-16 21:16:42.689-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: UpdateLayout(1547) > colon 30x140 at (76,42)
09-16 21:16:42.689-0700 E/EFL     ( 4960): elementary<4960> elm_layout.c:2216 elm_layout_add() could not add 0xf77a7ab0 as sub object of 0xf77a5a60
09-16 21:16:42.689-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: CreateImage(133) > resized 330x257 -> 254x257
09-16 21:16:42.689-0700 E/EFL     ( 4960): edje<4960> edje_util.c:3785 edje_object_size_min_restricted_calc() group digital-clock/12/1-9/last has a non-fixed part 'minute'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
09-16 21:16:42.699-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: UpdateLayout(1547) > colon 30x140 at (76,42)
09-16 21:16:42.699-0700 E/watchface-viewer( 4960): viewer-part-resource-evas.cpp: ApplyAutoRefreshAodColon(1263) > colon moved from (151,42) to (76,42)
09-16 21:16:42.699-0700 E/watchface-viewer( 4960): viewer-auto-refresh-aod.cpp: ApplyConfig(269) > aod type config[2] applied[2]
09-16 21:16:42.699-0700 I/watchface-viewer( 4960): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(561) > ImagesLoadingDoneSignal().Emit()
09-16 21:16:42.759-0700 E/W_HOME  ( 2872): clock_service.c: _del_waiting_timer(397) > clock waiting timer is deleted
09-16 21:16:42.769-0700 W/W_HOME  ( 2872): clock_manager.c: clock_manager_view_attach(343) > need_compositing:0
09-16 21:16:42.769-0700 W/W_HOME  ( 2872): clock_view.c: clock_view_attach(617) > changed pause/resume option -> manual
09-16 21:16:42.779-0700 W/W_HOME  ( 2872): event_manager.c: _clock_view_obscured_cb(651) > state: 1 -> 0
09-16 21:16:42.779-0700 W/W_HOME  ( 2872): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-16 21:16:42.779-0700 W/W_INDICATOR( 2796): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
09-16 21:16:42.779-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
09-16 21:16:42.779-0700 W/W_HOME  ( 2872): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-16 21:16:42.789-0700 E/EFL     ( 2872): elementary<2872> elm_interface_scrollable.c:1962 _elm_scroll_content_region_show_internal() [0xf7e13c80 : elm_scroller] x(2160), y(0), nx(2160), px(2160), ny(0) py(0)
09-16 21:16:42.789-0700 W/W_HOME  ( 2872): event_manager.c: _clock_view_visible_cb(637) > state: 0 -> 1
09-16 21:16:42.789-0700 W/W_HOME  ( 2872): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-16 21:16:42.789-0700 W/W_HOME  ( 2872): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
09-16 21:16:42.789-0700 W/W_HOME  ( 2872): clock_manager.c: _compositing_set(205) > hwc:1
09-16 21:16:42.789-0700 I/CAPI_WATCH_APPLICATION( 4960): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-16 21:16:42.789-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppTimeTick(579) > 
09-16 21:16:42.799-0700 W/W_INDICATOR( 2796): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
09-16 21:16:42.799-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
09-16 21:16:42.799-0700 W/W_INDICATOR( 2796): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
09-16 21:16:42.799-0700 E/EFL     ( 2872): elementary<2872> elm_interface_scrollable.c:1962 _elm_scroll_content_region_show_internal() [0xf7e13c80 : elm_scroller] x(2160), y(0), nx(2160), px(2160), ny(0) py(0)
09-16 21:16:42.799-0700 W/W_HOME  ( 2872): clock_view.c: clock_view_attach(634) > changed pause/resume option -> automatic
09-16 21:16:42.799-0700 W/W_HOME  ( 2872): clock_manager.c: clock_manager_clock_set(412) > attached clock isn't cleaned-up, yet
09-16 21:16:42.799-0700 E/W_HOME  ( 2872): page.c: _page_clip_del(241) > (!page_info) -> _page_clip_del() return
09-16 21:16:42.799-0700 E/W_HOME  ( 2872): page.c: _destroy_page_line(219) > (!box) -> _destroy_page_line() return
09-16 21:16:42.799-0700 W/W_HOME  ( 2872): clock_inf_dbox.c: del_cleanup_cb(385) > deleted
09-16 21:16:42.799-0700 E/W_HOME  ( 2872): dbox.c: _instance_list_del(1657) > Failed to delete widget instance node of org.example.bitcoinwatch
09-16 21:16:42.799-0700 E/W_HOME  ( 2872): dbox.c: del_cb(270) > Add viewer has no info: org.example.bitcoinwatch
09-16 21:16:42.809-0700 W/W_HOME  ( 2872): clock_manager.c: _compositing_set(205) > hwc:1
09-16 21:16:42.829-0700 W/W_HOME  ( 2872): util.c: _app_companion_validation_check(1452) > appid:com.samsung.watchface companion_type:0 companion_only:0 valid:1
09-16 21:16:42.839-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(96), length(2)
09-16 21:16:42.839-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 96%
09-16 21:16:42.839-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 96, isCharging: 0
09-16 21:16:42.839-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_100
09-16 21:16:42.839-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_icon_update(348) > [windicator_battery_icon_update:348] [Verizon] Battery level : 100
09-16 21:16:42.839-0700 W/W_INDICATOR( 2796): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): clock_service.c: clock_service_event_handler(903) > scroller freeze off
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): scroller.c: scroller_unfreeze(1875) > unfreezed:f74d1731
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): clock_service.c: _clock_service_heartbeat_pump(583) > clock service pump: com.samsung.watchface 1 0 0 0
09-16 21:16:42.839-0700 E/W_HOME  ( 2872): clock_service.c: _clock_service_heartbeat_pump(619) > com.samsung.watchface is already attached to home
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): cfwd.c: cfwd_get_icon_status(362) > 
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): ============================
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): multi_sim_category:0
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): multi_sim_model:0
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): support_callforward_auto:0
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): conn_status:1
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): remote_call_forward_auto:0
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): auto_call_forward_status:0
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): support_callforward_reverse:0
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): reverse_call_forward_auto:0
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): fwd_type:ARS
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): ============================
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): 
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): clock_view_indicator.c: _view_call_fw_icon(136) > call fwd status:0
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): clock_event.c: _wmanager_connectivity_get(397) > network status : 0
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): clock_event.c: _wmanager_connectivity_get(402) > sap_connected : 1
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): clock_event.c: _wmanager_connectivity_get(408) > sap connectivity type : 1
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): clock_event.c: _wmanager_connectivity_get(414) > network status : 3
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): clock_event.c: _wmanager_connectivity_get(421) > svc type : 1
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): clock_event.c: _wmanager_connectivity_get(428) > scs login : 0
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): clock_event.c: _wmanager_connectivity_get(470) > connected via bluetooth
09-16 21:16:42.839-0700 E/W_HOME  ( 2872): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): noti_broker.c: _clock_attached_cb(809) > 1
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): safety_assist.c: _clock_event_cb(46) > state:0
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): cs_broker.c: _clock_view_attached_cb(236) > 
09-16 21:16:42.839-0700 W/W_HOME  ( 2872): safety_assist.c: _clock_event_cb(46) > state:0
09-16 21:16:42.849-0700 I/TDM     ( 1906): tdm_display.c: tdm_layer_set_info(1442) > [739.631876] layer(0x55b278) not usable
09-16 21:16:42.849-0700 I/TDM     ( 1906): tdm_display.c: tdm_layer_set_info(1459) > [739.631907] layer(0x55b278) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
09-16 21:16:42.849-0700 I/TDM     ( 1906): tdm_exynos_display.c: exynos_layer_set_info(1578) > [739.631923] layer[0x55ad18]zpos[0]
09-16 21:16:42.859-0700 W/W_HOME  ( 2872): clock_manager.c: _hwc_enabled_success_cb(153) > hwc enabled
09-16 21:16:42.939-0700 E/W_HOME  ( 2872): page_indicator.c: page_indicator_item_at(292) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
09-16 21:16:42.969-0700 I/AUL_PAD ( 5020): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
09-16 21:16:42.989-0700 I/CAPI_WATCH_APPLICATION( 4960): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-16 21:16:42.989-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppTimeTick(579) > 
09-16 21:16:42.989-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: StartColonAnimation(1820) > 
09-16 21:16:42.989-0700 I/watchface-viewer( 4960): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(561) > ImagesLoadingDoneSignal().Emit()
09-16 21:16:43.189-0700 I/CAPI_WATCH_APPLICATION( 4960): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-16 21:16:43.189-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppTimeTick(579) > 
09-16 21:16:43.199-0700 W/CRASH_MANAGER( 4917): worker.c: worker_job(1205) > 11049396269741505621795
09-16 21:16:43.229-0700 I/watchface-viewer( 4960): viewer-view.cpp: DummyModeAnimationFinished(468) > 
09-16 21:16:43.389-0700 I/CAPI_WATCH_APPLICATION( 4960): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-16 21:16:43.389-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppTimeTick(579) > 
09-16 21:16:43.449-0700 I/watchface-viewer( 4960): viewer-part-resource-evas.cpp: ColonAnimationTimerExpired(1888) > 
09-16 21:16:43.589-0700 I/CAPI_WATCH_APPLICATION( 4960): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-16 21:16:43.589-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppTimeTick(579) > 
09-16 21:16:43.789-0700 I/CAPI_WATCH_APPLICATION( 4960): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-16 21:16:43.789-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppTimeTick(579) > 
09-16 21:16:43.989-0700 I/CAPI_WATCH_APPLICATION( 4960): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-16 21:16:43.989-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppTimeTick(579) > 
09-16 21:16:43.989-0700 I/watchface-viewer( 4960): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(561) > ImagesLoadingDoneSignal().Emit()
09-16 21:16:44.189-0700 I/CAPI_WATCH_APPLICATION( 4960): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
09-16 21:16:44.189-0700 E/watchface-loader( 4960): watchface-loader.cpp: OnAppTimeTick(579) > 
09-16 21:16:44.309-0700 W/CRASH_MANAGER( 4917): worker.c: worker_job(1205) > 1104965626974150562179
