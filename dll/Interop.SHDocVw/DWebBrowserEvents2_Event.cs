using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200000E RID: 14
	[global::System.Runtime.InteropServices.ComEventInterface(typeof(global::SHDocVw.DWebBrowserEvents2\u0000), typeof(global::SHDocVw.DWebBrowserEvents2_EventProvider\u0000))]
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public interface DWebBrowserEvents2_Event
	{
		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06000174 RID: 372
		// (remove) Token: 0x06000175 RID: 373
		event global::SHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler StatusTextChange;

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06000176 RID: 374
		// (remove) Token: 0x06000177 RID: 375
		event global::SHDocVw.DWebBrowserEvents2_ProgressChangeEventHandler ProgressChange;

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06000178 RID: 376
		// (remove) Token: 0x06000179 RID: 377
		event global::SHDocVw.DWebBrowserEvents2_CommandStateChangeEventHandler CommandStateChange;

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x0600017A RID: 378
		// (remove) Token: 0x0600017B RID: 379
		event global::SHDocVw.DWebBrowserEvents2_DownloadBeginEventHandler DownloadBegin;

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x0600017C RID: 380
		// (remove) Token: 0x0600017D RID: 381
		event global::SHDocVw.DWebBrowserEvents2_DownloadCompleteEventHandler DownloadComplete;

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x0600017E RID: 382
		// (remove) Token: 0x0600017F RID: 383
		event global::SHDocVw.DWebBrowserEvents2_TitleChangeEventHandler TitleChange;

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06000180 RID: 384
		// (remove) Token: 0x06000181 RID: 385
		event global::SHDocVw.DWebBrowserEvents2_PropertyChangeEventHandler PropertyChange;

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06000182 RID: 386
		// (remove) Token: 0x06000183 RID: 387
		event global::SHDocVw.DWebBrowserEvents2_BeforeNavigate2EventHandler BeforeNavigate2;

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06000184 RID: 388
		// (remove) Token: 0x06000185 RID: 389
		event global::SHDocVw.DWebBrowserEvents2_NewWindow2EventHandler NewWindow2;

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06000186 RID: 390
		// (remove) Token: 0x06000187 RID: 391
		event global::SHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler NavigateComplete2;

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06000188 RID: 392
		// (remove) Token: 0x06000189 RID: 393
		event global::SHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler DocumentComplete;

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x0600018A RID: 394
		// (remove) Token: 0x0600018B RID: 395
		event global::SHDocVw.DWebBrowserEvents2_OnQuitEventHandler OnQuit;

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x0600018C RID: 396
		// (remove) Token: 0x0600018D RID: 397
		event global::SHDocVw.DWebBrowserEvents2_OnVisibleEventHandler OnVisible;

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x0600018E RID: 398
		// (remove) Token: 0x0600018F RID: 399
		event global::SHDocVw.DWebBrowserEvents2_OnToolBarEventHandler OnToolBar;

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06000190 RID: 400
		// (remove) Token: 0x06000191 RID: 401
		event global::SHDocVw.DWebBrowserEvents2_OnMenuBarEventHandler OnMenuBar;

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06000192 RID: 402
		// (remove) Token: 0x06000193 RID: 403
		event global::SHDocVw.DWebBrowserEvents2_OnStatusBarEventHandler OnStatusBar;

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06000194 RID: 404
		// (remove) Token: 0x06000195 RID: 405
		event global::SHDocVw.DWebBrowserEvents2_OnFullScreenEventHandler OnFullScreen;

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06000196 RID: 406
		// (remove) Token: 0x06000197 RID: 407
		event global::SHDocVw.DWebBrowserEvents2_OnTheaterModeEventHandler OnTheaterMode;

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06000198 RID: 408
		// (remove) Token: 0x06000199 RID: 409
		event global::SHDocVw.DWebBrowserEvents2_WindowSetResizableEventHandler WindowSetResizable;

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x0600019A RID: 410
		// (remove) Token: 0x0600019B RID: 411
		event global::SHDocVw.DWebBrowserEvents2_WindowSetLeftEventHandler WindowSetLeft;

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x0600019C RID: 412
		// (remove) Token: 0x0600019D RID: 413
		event global::SHDocVw.DWebBrowserEvents2_WindowSetTopEventHandler WindowSetTop;

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x0600019E RID: 414
		// (remove) Token: 0x0600019F RID: 415
		event global::SHDocVw.DWebBrowserEvents2_WindowSetWidthEventHandler WindowSetWidth;

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x060001A0 RID: 416
		// (remove) Token: 0x060001A1 RID: 417
		event global::SHDocVw.DWebBrowserEvents2_WindowSetHeightEventHandler WindowSetHeight;

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x060001A2 RID: 418
		// (remove) Token: 0x060001A3 RID: 419
		event global::SHDocVw.DWebBrowserEvents2_WindowClosingEventHandler WindowClosing;

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x060001A4 RID: 420
		// (remove) Token: 0x060001A5 RID: 421
		event global::SHDocVw.DWebBrowserEvents2_ClientToHostWindowEventHandler ClientToHostWindow;

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x060001A6 RID: 422
		// (remove) Token: 0x060001A7 RID: 423
		event global::SHDocVw.DWebBrowserEvents2_SetSecureLockIconEventHandler SetSecureLockIcon;

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x060001A8 RID: 424
		// (remove) Token: 0x060001A9 RID: 425
		event global::SHDocVw.DWebBrowserEvents2_FileDownloadEventHandler FileDownload;

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x060001AA RID: 426
		// (remove) Token: 0x060001AB RID: 427
		event global::SHDocVw.DWebBrowserEvents2_NavigateErrorEventHandler NavigateError;

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x060001AC RID: 428
		// (remove) Token: 0x060001AD RID: 429
		event global::SHDocVw.DWebBrowserEvents2_PrintTemplateInstantiationEventHandler PrintTemplateInstantiation;

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x060001AE RID: 430
		// (remove) Token: 0x060001AF RID: 431
		event global::SHDocVw.DWebBrowserEvents2_PrintTemplateTeardownEventHandler PrintTemplateTeardown;

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x060001B0 RID: 432
		// (remove) Token: 0x060001B1 RID: 433
		event global::SHDocVw.DWebBrowserEvents2_UpdatePageStatusEventHandler UpdatePageStatus;

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x060001B2 RID: 434
		// (remove) Token: 0x060001B3 RID: 435
		event global::SHDocVw.DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler PrivacyImpactedStateChange;
	}
}
