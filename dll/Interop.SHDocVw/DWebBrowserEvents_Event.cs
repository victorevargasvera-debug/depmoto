using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200002F RID: 47
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.Runtime.InteropServices.TypeLibType(16)]
	[global::System.Runtime.InteropServices.ComEventInterface(typeof(global::SHDocVw.DWebBrowserEvents\u0000), typeof(global::SHDocVw.DWebBrowserEvents_EventProvider\u0000))]
	public interface DWebBrowserEvents_Event
	{
		// Token: 0x14000052 RID: 82
		// (add) Token: 0x060001F4 RID: 500
		// (remove) Token: 0x060001F5 RID: 501
		event global::SHDocVw.DWebBrowserEvents_BeforeNavigateEventHandler BeforeNavigate;

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x060001F6 RID: 502
		// (remove) Token: 0x060001F7 RID: 503
		event global::SHDocVw.DWebBrowserEvents_NavigateCompleteEventHandler NavigateComplete;

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x060001F8 RID: 504
		// (remove) Token: 0x060001F9 RID: 505
		event global::SHDocVw.DWebBrowserEvents_StatusTextChangeEventHandler StatusTextChange;

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x060001FA RID: 506
		// (remove) Token: 0x060001FB RID: 507
		event global::SHDocVw.DWebBrowserEvents_ProgressChangeEventHandler ProgressChange;

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x060001FC RID: 508
		// (remove) Token: 0x060001FD RID: 509
		event global::SHDocVw.DWebBrowserEvents_DownloadCompleteEventHandler DownloadComplete;

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x060001FE RID: 510
		// (remove) Token: 0x060001FF RID: 511
		event global::SHDocVw.DWebBrowserEvents_CommandStateChangeEventHandler CommandStateChange;

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06000200 RID: 512
		// (remove) Token: 0x06000201 RID: 513
		event global::SHDocVw.DWebBrowserEvents_DownloadBeginEventHandler DownloadBegin;

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06000202 RID: 514
		// (remove) Token: 0x06000203 RID: 515
		event global::SHDocVw.DWebBrowserEvents_NewWindowEventHandler NewWindow;

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06000204 RID: 516
		// (remove) Token: 0x06000205 RID: 517
		event global::SHDocVw.DWebBrowserEvents_TitleChangeEventHandler TitleChange;

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06000206 RID: 518
		// (remove) Token: 0x06000207 RID: 519
		event global::SHDocVw.DWebBrowserEvents_FrameBeforeNavigateEventHandler FrameBeforeNavigate;

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06000208 RID: 520
		// (remove) Token: 0x06000209 RID: 521
		event global::SHDocVw.DWebBrowserEvents_FrameNavigateCompleteEventHandler FrameNavigateComplete;

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x0600020A RID: 522
		// (remove) Token: 0x0600020B RID: 523
		event global::SHDocVw.DWebBrowserEvents_FrameNewWindowEventHandler FrameNewWindow;

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x0600020C RID: 524
		// (remove) Token: 0x0600020D RID: 525
		event global::SHDocVw.DWebBrowserEvents_QuitEventHandler Quit;

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x0600020E RID: 526
		// (remove) Token: 0x0600020F RID: 527
		event global::SHDocVw.DWebBrowserEvents_WindowMoveEventHandler WindowMove;

		// Token: 0x14000060 RID: 96
		// (add) Token: 0x06000210 RID: 528
		// (remove) Token: 0x06000211 RID: 529
		event global::SHDocVw.DWebBrowserEvents_WindowResizeEventHandler WindowResize;

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x06000212 RID: 530
		// (remove) Token: 0x06000213 RID: 531
		event global::SHDocVw.DWebBrowserEvents_WindowActivateEventHandler WindowActivate;

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x06000214 RID: 532
		// (remove) Token: 0x06000215 RID: 533
		event global::SHDocVw.DWebBrowserEvents_PropertyChangeEventHandler PropertyChange;
	}
}
