using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000070 RID: 112
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public sealed class DWebBrowserEvents_SinkHelper : global::SHDocVw.DWebBrowserEvents
	{
		// Token: 0x06000606 RID: 1542 RVA: 0x00002FA0 File Offset: 0x00001FA0
		public void PropertyChange(string A_1)
		{
			if (this.m_PropertyChangeDelegate != null)
			{
				this.m_PropertyChangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002FD0 File Offset: 0x00001FD0
		public void WindowActivate()
		{
			if (this.m_WindowActivateDelegate != null)
			{
				this.m_WindowActivateDelegate();
				return;
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002FFC File Offset: 0x00001FFC
		public void WindowResize()
		{
			if (this.m_WindowResizeDelegate != null)
			{
				this.m_WindowResizeDelegate();
				return;
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00003028 File Offset: 0x00002028
		public void WindowMove()
		{
			if (this.m_WindowMoveDelegate != null)
			{
				this.m_WindowMoveDelegate();
				return;
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00003054 File Offset: 0x00002054
		public void Quit(ref bool A_1)
		{
			if (this.m_QuitDelegate != null)
			{
				this.m_QuitDelegate(ref A_1);
				return;
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00003084 File Offset: 0x00002084
		public void FrameNewWindow(string A_1, int A_2, string A_3, ref object A_4, string A_5, ref bool A_6)
		{
			if (this.m_FrameNewWindowDelegate != null)
			{
				this.m_FrameNewWindowDelegate(A_1, A_2, A_3, ref A_4, A_5, ref A_6);
				return;
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000030C8 File Offset: 0x000020C8
		public void FrameNavigateComplete(string A_1)
		{
			if (this.m_FrameNavigateCompleteDelegate != null)
			{
				this.m_FrameNavigateCompleteDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000030F8 File Offset: 0x000020F8
		public void FrameBeforeNavigate(string A_1, int A_2, string A_3, ref object A_4, string A_5, ref bool A_6)
		{
			if (this.m_FrameBeforeNavigateDelegate != null)
			{
				this.m_FrameBeforeNavigateDelegate(A_1, A_2, A_3, ref A_4, A_5, ref A_6);
				return;
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0000313C File Offset: 0x0000213C
		public void TitleChange(string A_1)
		{
			if (this.m_TitleChangeDelegate != null)
			{
				this.m_TitleChangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0000316C File Offset: 0x0000216C
		public void NewWindow(string A_1, int A_2, string A_3, ref object A_4, string A_5, ref bool A_6)
		{
			if (this.m_NewWindowDelegate != null)
			{
				this.m_NewWindowDelegate(A_1, A_2, A_3, ref A_4, A_5, ref A_6);
				return;
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000031B0 File Offset: 0x000021B0
		public void DownloadBegin()
		{
			if (this.m_DownloadBeginDelegate != null)
			{
				this.m_DownloadBeginDelegate();
				return;
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000031DC File Offset: 0x000021DC
		public void CommandStateChange(int A_1, bool A_2)
		{
			if (this.m_CommandStateChangeDelegate != null)
			{
				this.m_CommandStateChangeDelegate(A_1, A_2);
				return;
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00003210 File Offset: 0x00002210
		public void DownloadComplete()
		{
			if (this.m_DownloadCompleteDelegate != null)
			{
				this.m_DownloadCompleteDelegate();
				return;
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0000323C File Offset: 0x0000223C
		public void ProgressChange(int A_1, int A_2)
		{
			if (this.m_ProgressChangeDelegate != null)
			{
				this.m_ProgressChangeDelegate(A_1, A_2);
				return;
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00003270 File Offset: 0x00002270
		public void StatusTextChange(string A_1)
		{
			if (this.m_StatusTextChangeDelegate != null)
			{
				this.m_StatusTextChangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000032A0 File Offset: 0x000022A0
		public void NavigateComplete(string A_1)
		{
			if (this.m_NavigateCompleteDelegate != null)
			{
				this.m_NavigateCompleteDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000032D0 File Offset: 0x000022D0
		public void BeforeNavigate(string A_1, int A_2, string A_3, ref object A_4, string A_5, ref bool A_6)
		{
			if (this.m_BeforeNavigateDelegate != null)
			{
				this.m_BeforeNavigateDelegate(A_1, A_2, A_3, ref A_4, A_5, ref A_6);
				return;
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00003314 File Offset: 0x00002314
		internal DWebBrowserEvents_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_PropertyChangeDelegate = null;
			this.m_WindowActivateDelegate = null;
			this.m_WindowResizeDelegate = null;
			this.m_WindowMoveDelegate = null;
			this.m_QuitDelegate = null;
			this.m_FrameNewWindowDelegate = null;
			this.m_FrameNavigateCompleteDelegate = null;
			this.m_FrameBeforeNavigateDelegate = null;
			this.m_TitleChangeDelegate = null;
			this.m_NewWindowDelegate = null;
			this.m_DownloadBeginDelegate = null;
			this.m_CommandStateChangeDelegate = null;
			this.m_DownloadCompleteDelegate = null;
			this.m_ProgressChangeDelegate = null;
			this.m_StatusTextChangeDelegate = null;
			this.m_NavigateCompleteDelegate = null;
			this.m_BeforeNavigateDelegate = null;
		}

		// Token: 0x0400006B RID: 107
		public global::SHDocVw.DWebBrowserEvents_PropertyChangeEventHandler m_PropertyChangeDelegate;

		// Token: 0x0400006C RID: 108
		public global::SHDocVw.DWebBrowserEvents_WindowActivateEventHandler m_WindowActivateDelegate;

		// Token: 0x0400006D RID: 109
		public global::SHDocVw.DWebBrowserEvents_WindowResizeEventHandler m_WindowResizeDelegate;

		// Token: 0x0400006E RID: 110
		public global::SHDocVw.DWebBrowserEvents_WindowMoveEventHandler m_WindowMoveDelegate;

		// Token: 0x0400006F RID: 111
		public global::SHDocVw.DWebBrowserEvents_QuitEventHandler m_QuitDelegate;

		// Token: 0x04000070 RID: 112
		public global::SHDocVw.DWebBrowserEvents_FrameNewWindowEventHandler m_FrameNewWindowDelegate;

		// Token: 0x04000071 RID: 113
		public global::SHDocVw.DWebBrowserEvents_FrameNavigateCompleteEventHandler m_FrameNavigateCompleteDelegate;

		// Token: 0x04000072 RID: 114
		public global::SHDocVw.DWebBrowserEvents_FrameBeforeNavigateEventHandler m_FrameBeforeNavigateDelegate;

		// Token: 0x04000073 RID: 115
		public global::SHDocVw.DWebBrowserEvents_TitleChangeEventHandler m_TitleChangeDelegate;

		// Token: 0x04000074 RID: 116
		public global::SHDocVw.DWebBrowserEvents_NewWindowEventHandler m_NewWindowDelegate;

		// Token: 0x04000075 RID: 117
		public global::SHDocVw.DWebBrowserEvents_DownloadBeginEventHandler m_DownloadBeginDelegate;

		// Token: 0x04000076 RID: 118
		public global::SHDocVw.DWebBrowserEvents_CommandStateChangeEventHandler m_CommandStateChangeDelegate;

		// Token: 0x04000077 RID: 119
		public global::SHDocVw.DWebBrowserEvents_DownloadCompleteEventHandler m_DownloadCompleteDelegate;

		// Token: 0x04000078 RID: 120
		public global::SHDocVw.DWebBrowserEvents_ProgressChangeEventHandler m_ProgressChangeDelegate;

		// Token: 0x04000079 RID: 121
		public global::SHDocVw.DWebBrowserEvents_StatusTextChangeEventHandler m_StatusTextChangeDelegate;

		// Token: 0x0400007A RID: 122
		public global::SHDocVw.DWebBrowserEvents_NavigateCompleteEventHandler m_NavigateCompleteDelegate;

		// Token: 0x0400007B RID: 123
		public global::SHDocVw.DWebBrowserEvents_BeforeNavigateEventHandler m_BeforeNavigateDelegate;

		// Token: 0x0400007C RID: 124
		public int m_dwCookie;
	}
}
