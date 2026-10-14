using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000074 RID: 116
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public sealed class DWebBrowserEvents2_SinkHelper : global::SHDocVw.DWebBrowserEvents2
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x00005668 File Offset: 0x00004668
		public void PrivacyImpactedStateChange(bool A_1)
		{
			if (this.m_PrivacyImpactedStateChangeDelegate != null)
			{
				this.m_PrivacyImpactedStateChangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00005698 File Offset: 0x00004698
		public void UpdatePageStatus(object A_1, ref object A_2, ref object A_3)
		{
			if (this.m_UpdatePageStatusDelegate != null)
			{
				this.m_UpdatePageStatusDelegate(A_1, ref A_2, ref A_3);
				return;
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x000056D0 File Offset: 0x000046D0
		public void PrintTemplateTeardown(object A_1)
		{
			if (this.m_PrintTemplateTeardownDelegate != null)
			{
				this.m_PrintTemplateTeardownDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00005700 File Offset: 0x00004700
		public void PrintTemplateInstantiation(object A_1)
		{
			if (this.m_PrintTemplateInstantiationDelegate != null)
			{
				this.m_PrintTemplateInstantiationDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00005730 File Offset: 0x00004730
		public void NavigateError(object A_1, ref object A_2, ref object A_3, ref object A_4, ref bool A_5)
		{
			if (this.m_NavigateErrorDelegate != null)
			{
				this.m_NavigateErrorDelegate(A_1, ref A_2, ref A_3, ref A_4, ref A_5);
				return;
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00005770 File Offset: 0x00004770
		public void FileDownload(ref bool A_1)
		{
			if (this.m_FileDownloadDelegate != null)
			{
				this.m_FileDownloadDelegate(ref A_1);
				return;
			}
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000057A0 File Offset: 0x000047A0
		public void SetSecureLockIcon(int A_1)
		{
			if (this.m_SetSecureLockIconDelegate != null)
			{
				this.m_SetSecureLockIconDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000057D0 File Offset: 0x000047D0
		public void ClientToHostWindow(ref int A_1, ref int A_2)
		{
			if (this.m_ClientToHostWindowDelegate != null)
			{
				this.m_ClientToHostWindowDelegate(ref A_1, ref A_2);
				return;
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00005804 File Offset: 0x00004804
		public void WindowClosing(bool A_1, ref bool A_2)
		{
			if (this.m_WindowClosingDelegate != null)
			{
				this.m_WindowClosingDelegate(A_1, ref A_2);
				return;
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00005838 File Offset: 0x00004838
		public void WindowSetHeight(int A_1)
		{
			if (this.m_WindowSetHeightDelegate != null)
			{
				this.m_WindowSetHeightDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00005868 File Offset: 0x00004868
		public void WindowSetWidth(int A_1)
		{
			if (this.m_WindowSetWidthDelegate != null)
			{
				this.m_WindowSetWidthDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00005898 File Offset: 0x00004898
		public void WindowSetTop(int A_1)
		{
			if (this.m_WindowSetTopDelegate != null)
			{
				this.m_WindowSetTopDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x000058C8 File Offset: 0x000048C8
		public void WindowSetLeft(int A_1)
		{
			if (this.m_WindowSetLeftDelegate != null)
			{
				this.m_WindowSetLeftDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000058F8 File Offset: 0x000048F8
		public void WindowSetResizable(bool A_1)
		{
			if (this.m_WindowSetResizableDelegate != null)
			{
				this.m_WindowSetResizableDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00005928 File Offset: 0x00004928
		public void OnTheaterMode(bool A_1)
		{
			if (this.m_OnTheaterModeDelegate != null)
			{
				this.m_OnTheaterModeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00005958 File Offset: 0x00004958
		public void OnFullScreen(bool A_1)
		{
			if (this.m_OnFullScreenDelegate != null)
			{
				this.m_OnFullScreenDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00005988 File Offset: 0x00004988
		public void OnStatusBar(bool A_1)
		{
			if (this.m_OnStatusBarDelegate != null)
			{
				this.m_OnStatusBarDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000059B8 File Offset: 0x000049B8
		public void OnMenuBar(bool A_1)
		{
			if (this.m_OnMenuBarDelegate != null)
			{
				this.m_OnMenuBarDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000059E8 File Offset: 0x000049E8
		public void OnToolBar(bool A_1)
		{
			if (this.m_OnToolBarDelegate != null)
			{
				this.m_OnToolBarDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00005A18 File Offset: 0x00004A18
		public void OnVisible(bool A_1)
		{
			if (this.m_OnVisibleDelegate != null)
			{
				this.m_OnVisibleDelegate(A_1);
				return;
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00005A48 File Offset: 0x00004A48
		public void OnQuit()
		{
			if (this.m_OnQuitDelegate != null)
			{
				this.m_OnQuitDelegate();
				return;
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00005A74 File Offset: 0x00004A74
		public void DocumentComplete(object A_1, ref object A_2)
		{
			if (this.m_DocumentCompleteDelegate != null)
			{
				this.m_DocumentCompleteDelegate(A_1, ref A_2);
				return;
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00005AA8 File Offset: 0x00004AA8
		public void NavigateComplete2(object A_1, ref object A_2)
		{
			if (this.m_NavigateComplete2Delegate != null)
			{
				this.m_NavigateComplete2Delegate(A_1, ref A_2);
				return;
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00005ADC File Offset: 0x00004ADC
		public void NewWindow2(ref object A_1, ref bool A_2)
		{
			if (this.m_NewWindow2Delegate != null)
			{
				this.m_NewWindow2Delegate(ref A_1, ref A_2);
				return;
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00005B10 File Offset: 0x00004B10
		public void BeforeNavigate2(object A_1, ref object A_2, ref object A_3, ref object A_4, ref object A_5, ref object A_6, ref bool A_7)
		{
			if (this.m_BeforeNavigate2Delegate != null)
			{
				this.m_BeforeNavigate2Delegate(A_1, ref A_2, ref A_3, ref A_4, ref A_5, ref A_6, ref A_7);
				return;
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00005B58 File Offset: 0x00004B58
		public void PropertyChange(string A_1)
		{
			if (this.m_PropertyChangeDelegate != null)
			{
				this.m_PropertyChangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00005B88 File Offset: 0x00004B88
		public void TitleChange(string A_1)
		{
			if (this.m_TitleChangeDelegate != null)
			{
				this.m_TitleChangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00005BB8 File Offset: 0x00004BB8
		public void DownloadComplete()
		{
			if (this.m_DownloadCompleteDelegate != null)
			{
				this.m_DownloadCompleteDelegate();
				return;
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00005BE4 File Offset: 0x00004BE4
		public void DownloadBegin()
		{
			if (this.m_DownloadBeginDelegate != null)
			{
				this.m_DownloadBeginDelegate();
				return;
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00005C10 File Offset: 0x00004C10
		public void CommandStateChange(int A_1, bool A_2)
		{
			if (this.m_CommandStateChangeDelegate != null)
			{
				this.m_CommandStateChangeDelegate(A_1, A_2);
				return;
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00005C44 File Offset: 0x00004C44
		public void ProgressChange(int A_1, int A_2)
		{
			if (this.m_ProgressChangeDelegate != null)
			{
				this.m_ProgressChangeDelegate(A_1, A_2);
				return;
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00005C78 File Offset: 0x00004C78
		public void StatusTextChange(string A_1)
		{
			if (this.m_StatusTextChangeDelegate != null)
			{
				this.m_StatusTextChangeDelegate(A_1);
				return;
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00005CA8 File Offset: 0x00004CA8
		internal DWebBrowserEvents2_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_PrivacyImpactedStateChangeDelegate = null;
			this.m_UpdatePageStatusDelegate = null;
			this.m_PrintTemplateTeardownDelegate = null;
			this.m_PrintTemplateInstantiationDelegate = null;
			this.m_NavigateErrorDelegate = null;
			this.m_FileDownloadDelegate = null;
			this.m_SetSecureLockIconDelegate = null;
			this.m_ClientToHostWindowDelegate = null;
			this.m_WindowClosingDelegate = null;
			this.m_WindowSetHeightDelegate = null;
			this.m_WindowSetWidthDelegate = null;
			this.m_WindowSetTopDelegate = null;
			this.m_WindowSetLeftDelegate = null;
			this.m_WindowSetResizableDelegate = null;
			this.m_OnTheaterModeDelegate = null;
			this.m_OnFullScreenDelegate = null;
			this.m_OnStatusBarDelegate = null;
			this.m_OnMenuBarDelegate = null;
			this.m_OnToolBarDelegate = null;
			this.m_OnVisibleDelegate = null;
			this.m_OnQuitDelegate = null;
			this.m_DocumentCompleteDelegate = null;
			this.m_NavigateComplete2Delegate = null;
			this.m_NewWindow2Delegate = null;
			this.m_BeforeNavigate2Delegate = null;
			this.m_PropertyChangeDelegate = null;
			this.m_TitleChangeDelegate = null;
			this.m_DownloadCompleteDelegate = null;
			this.m_DownloadBeginDelegate = null;
			this.m_CommandStateChangeDelegate = null;
			this.m_ProgressChangeDelegate = null;
			this.m_StatusTextChangeDelegate = null;
		}

		// Token: 0x04000086 RID: 134
		public global::SHDocVw.DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler m_PrivacyImpactedStateChangeDelegate;

		// Token: 0x04000087 RID: 135
		public global::SHDocVw.DWebBrowserEvents2_UpdatePageStatusEventHandler m_UpdatePageStatusDelegate;

		// Token: 0x04000088 RID: 136
		public global::SHDocVw.DWebBrowserEvents2_PrintTemplateTeardownEventHandler m_PrintTemplateTeardownDelegate;

		// Token: 0x04000089 RID: 137
		public global::SHDocVw.DWebBrowserEvents2_PrintTemplateInstantiationEventHandler m_PrintTemplateInstantiationDelegate;

		// Token: 0x0400008A RID: 138
		public global::SHDocVw.DWebBrowserEvents2_NavigateErrorEventHandler m_NavigateErrorDelegate;

		// Token: 0x0400008B RID: 139
		public global::SHDocVw.DWebBrowserEvents2_FileDownloadEventHandler m_FileDownloadDelegate;

		// Token: 0x0400008C RID: 140
		public global::SHDocVw.DWebBrowserEvents2_SetSecureLockIconEventHandler m_SetSecureLockIconDelegate;

		// Token: 0x0400008D RID: 141
		public global::SHDocVw.DWebBrowserEvents2_ClientToHostWindowEventHandler m_ClientToHostWindowDelegate;

		// Token: 0x0400008E RID: 142
		public global::SHDocVw.DWebBrowserEvents2_WindowClosingEventHandler m_WindowClosingDelegate;

		// Token: 0x0400008F RID: 143
		public global::SHDocVw.DWebBrowserEvents2_WindowSetHeightEventHandler m_WindowSetHeightDelegate;

		// Token: 0x04000090 RID: 144
		public global::SHDocVw.DWebBrowserEvents2_WindowSetWidthEventHandler m_WindowSetWidthDelegate;

		// Token: 0x04000091 RID: 145
		public global::SHDocVw.DWebBrowserEvents2_WindowSetTopEventHandler m_WindowSetTopDelegate;

		// Token: 0x04000092 RID: 146
		public global::SHDocVw.DWebBrowserEvents2_WindowSetLeftEventHandler m_WindowSetLeftDelegate;

		// Token: 0x04000093 RID: 147
		public global::SHDocVw.DWebBrowserEvents2_WindowSetResizableEventHandler m_WindowSetResizableDelegate;

		// Token: 0x04000094 RID: 148
		public global::SHDocVw.DWebBrowserEvents2_OnTheaterModeEventHandler m_OnTheaterModeDelegate;

		// Token: 0x04000095 RID: 149
		public global::SHDocVw.DWebBrowserEvents2_OnFullScreenEventHandler m_OnFullScreenDelegate;

		// Token: 0x04000096 RID: 150
		public global::SHDocVw.DWebBrowserEvents2_OnStatusBarEventHandler m_OnStatusBarDelegate;

		// Token: 0x04000097 RID: 151
		public global::SHDocVw.DWebBrowserEvents2_OnMenuBarEventHandler m_OnMenuBarDelegate;

		// Token: 0x04000098 RID: 152
		public global::SHDocVw.DWebBrowserEvents2_OnToolBarEventHandler m_OnToolBarDelegate;

		// Token: 0x04000099 RID: 153
		public global::SHDocVw.DWebBrowserEvents2_OnVisibleEventHandler m_OnVisibleDelegate;

		// Token: 0x0400009A RID: 154
		public global::SHDocVw.DWebBrowserEvents2_OnQuitEventHandler m_OnQuitDelegate;

		// Token: 0x0400009B RID: 155
		public global::SHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler m_DocumentCompleteDelegate;

		// Token: 0x0400009C RID: 156
		public global::SHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler m_NavigateComplete2Delegate;

		// Token: 0x0400009D RID: 157
		public global::SHDocVw.DWebBrowserEvents2_NewWindow2EventHandler m_NewWindow2Delegate;

		// Token: 0x0400009E RID: 158
		public global::SHDocVw.DWebBrowserEvents2_BeforeNavigate2EventHandler m_BeforeNavigate2Delegate;

		// Token: 0x0400009F RID: 159
		public global::SHDocVw.DWebBrowserEvents2_PropertyChangeEventHandler m_PropertyChangeDelegate;

		// Token: 0x040000A0 RID: 160
		public global::SHDocVw.DWebBrowserEvents2_TitleChangeEventHandler m_TitleChangeDelegate;

		// Token: 0x040000A1 RID: 161
		public global::SHDocVw.DWebBrowserEvents2_DownloadCompleteEventHandler m_DownloadCompleteDelegate;

		// Token: 0x040000A2 RID: 162
		public global::SHDocVw.DWebBrowserEvents2_DownloadBeginEventHandler m_DownloadBeginDelegate;

		// Token: 0x040000A3 RID: 163
		public global::SHDocVw.DWebBrowserEvents2_CommandStateChangeEventHandler m_CommandStateChangeDelegate;

		// Token: 0x040000A4 RID: 164
		public global::SHDocVw.DWebBrowserEvents2_ProgressChangeEventHandler m_ProgressChangeDelegate;

		// Token: 0x040000A5 RID: 165
		public global::SHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler m_StatusTextChangeDelegate;

		// Token: 0x040000A6 RID: 166
		public int m_dwCookie;
	}
}
