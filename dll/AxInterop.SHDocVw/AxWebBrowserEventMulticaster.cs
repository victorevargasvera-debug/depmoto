using System;
using SHDocVw;

namespace AxSHDocVw
{
	// Token: 0x0200003D RID: 61
	public class AxWebBrowserEventMulticaster : global::SHDocVw.DWebBrowserEvents2
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00004014 File Offset: 0x00003014
		public AxWebBrowserEventMulticaster(global::AxSHDocVw.AxWebBrowser parent)
		{
			this.parent = parent;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00004030 File Offset: 0x00003030
		public virtual void PrivacyImpactedStateChange(bool bImpacted)
		{
			global::AxSHDocVw.DWebBrowserEvents2_PrivacyImpactedStateChangeEvent e = new global::AxSHDocVw.DWebBrowserEvents2_PrivacyImpactedStateChangeEvent(bImpacted);
			this.parent.RaiseOnPrivacyImpactedStateChange(this.parent, e);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004058 File Offset: 0x00003058
		public virtual void UpdatePageStatus(object pDisp, ref object nPage, ref object fDone)
		{
			global::AxSHDocVw.DWebBrowserEvents2_UpdatePageStatusEvent dwebBrowserEvents2_UpdatePageStatusEvent = new global::AxSHDocVw.DWebBrowserEvents2_UpdatePageStatusEvent(pDisp, nPage, fDone);
			this.parent.RaiseOnUpdatePageStatus(this.parent, dwebBrowserEvents2_UpdatePageStatusEvent);
			nPage = dwebBrowserEvents2_UpdatePageStatusEvent.nPage;
			fDone = dwebBrowserEvents2_UpdatePageStatusEvent.fDone;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00004094 File Offset: 0x00003094
		public virtual void PrintTemplateTeardown(object pDisp)
		{
			global::AxSHDocVw.DWebBrowserEvents2_PrintTemplateTeardownEvent e = new global::AxSHDocVw.DWebBrowserEvents2_PrintTemplateTeardownEvent(pDisp);
			this.parent.RaiseOnPrintTemplateTeardown(this.parent, e);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000040BC File Offset: 0x000030BC
		public virtual void PrintTemplateInstantiation(object pDisp)
		{
			global::AxSHDocVw.DWebBrowserEvents2_PrintTemplateInstantiationEvent e = new global::AxSHDocVw.DWebBrowserEvents2_PrintTemplateInstantiationEvent(pDisp);
			this.parent.RaiseOnPrintTemplateInstantiation(this.parent, e);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000040E4 File Offset: 0x000030E4
		public virtual void NavigateError(object pDisp, ref object uRL, ref object frame, ref object statusCode, ref bool cancel)
		{
			global::AxSHDocVw.DWebBrowserEvents2_NavigateErrorEvent dwebBrowserEvents2_NavigateErrorEvent = new global::AxSHDocVw.DWebBrowserEvents2_NavigateErrorEvent(pDisp, uRL, frame, statusCode, cancel);
			this.parent.RaiseOnNavigateError(this.parent, dwebBrowserEvents2_NavigateErrorEvent);
			uRL = dwebBrowserEvents2_NavigateErrorEvent.uRL;
			frame = dwebBrowserEvents2_NavigateErrorEvent.frame;
			statusCode = dwebBrowserEvents2_NavigateErrorEvent.statusCode;
			cancel = dwebBrowserEvents2_NavigateErrorEvent.cancel;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00004138 File Offset: 0x00003138
		public virtual void FileDownload(ref bool cancel)
		{
			global::AxSHDocVw.DWebBrowserEvents2_FileDownloadEvent dwebBrowserEvents2_FileDownloadEvent = new global::AxSHDocVw.DWebBrowserEvents2_FileDownloadEvent(cancel);
			this.parent.RaiseOnFileDownload(this.parent, dwebBrowserEvents2_FileDownloadEvent);
			cancel = dwebBrowserEvents2_FileDownloadEvent.cancel;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004168 File Offset: 0x00003168
		public virtual void SetSecureLockIcon(int secureLockIcon)
		{
			global::AxSHDocVw.DWebBrowserEvents2_SetSecureLockIconEvent e = new global::AxSHDocVw.DWebBrowserEvents2_SetSecureLockIconEvent(secureLockIcon);
			this.parent.RaiseOnSetSecureLockIcon(this.parent, e);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00004190 File Offset: 0x00003190
		public virtual void ClientToHostWindow(ref int cX, ref int cY)
		{
			global::AxSHDocVw.DWebBrowserEvents2_ClientToHostWindowEvent dwebBrowserEvents2_ClientToHostWindowEvent = new global::AxSHDocVw.DWebBrowserEvents2_ClientToHostWindowEvent(cX, cY);
			this.parent.RaiseOnClientToHostWindow(this.parent, dwebBrowserEvents2_ClientToHostWindowEvent);
			cX = dwebBrowserEvents2_ClientToHostWindowEvent.cX;
			cY = dwebBrowserEvents2_ClientToHostWindowEvent.cY;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000041CC File Offset: 0x000031CC
		public virtual void WindowClosing(bool isChildWindow, ref bool cancel)
		{
			global::AxSHDocVw.DWebBrowserEvents2_WindowClosingEvent dwebBrowserEvents2_WindowClosingEvent = new global::AxSHDocVw.DWebBrowserEvents2_WindowClosingEvent(isChildWindow, cancel);
			this.parent.RaiseOnWindowClosing(this.parent, dwebBrowserEvents2_WindowClosingEvent);
			cancel = dwebBrowserEvents2_WindowClosingEvent.cancel;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000041FC File Offset: 0x000031FC
		public virtual void WindowSetHeight(int height)
		{
			global::AxSHDocVw.DWebBrowserEvents2_WindowSetHeightEvent e = new global::AxSHDocVw.DWebBrowserEvents2_WindowSetHeightEvent(height);
			this.parent.RaiseOnWindowSetHeight(this.parent, e);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00004224 File Offset: 0x00003224
		public virtual void WindowSetWidth(int width)
		{
			global::AxSHDocVw.DWebBrowserEvents2_WindowSetWidthEvent e = new global::AxSHDocVw.DWebBrowserEvents2_WindowSetWidthEvent(width);
			this.parent.RaiseOnWindowSetWidth(this.parent, e);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000424C File Offset: 0x0000324C
		public virtual void WindowSetTop(int top)
		{
			global::AxSHDocVw.DWebBrowserEvents2_WindowSetTopEvent e = new global::AxSHDocVw.DWebBrowserEvents2_WindowSetTopEvent(top);
			this.parent.RaiseOnWindowSetTop(this.parent, e);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00004274 File Offset: 0x00003274
		public virtual void WindowSetLeft(int left)
		{
			global::AxSHDocVw.DWebBrowserEvents2_WindowSetLeftEvent e = new global::AxSHDocVw.DWebBrowserEvents2_WindowSetLeftEvent(left);
			this.parent.RaiseOnWindowSetLeft(this.parent, e);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000429C File Offset: 0x0000329C
		public virtual void WindowSetResizable(bool resizable)
		{
			global::AxSHDocVw.DWebBrowserEvents2_WindowSetResizableEvent e = new global::AxSHDocVw.DWebBrowserEvents2_WindowSetResizableEvent(resizable);
			this.parent.RaiseOnWindowSetResizable(this.parent, e);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000042C4 File Offset: 0x000032C4
		public virtual void OnTheaterMode(bool theaterMode)
		{
			global::AxSHDocVw.DWebBrowserEvents2_OnTheaterModeEvent e = new global::AxSHDocVw.DWebBrowserEvents2_OnTheaterModeEvent(theaterMode);
			this.parent.RaiseOnOnTheaterMode(this.parent, e);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000042EC File Offset: 0x000032EC
		public virtual void OnFullScreen(bool fullScreen)
		{
			global::AxSHDocVw.DWebBrowserEvents2_OnFullScreenEvent e = new global::AxSHDocVw.DWebBrowserEvents2_OnFullScreenEvent(fullScreen);
			this.parent.RaiseOnOnFullScreen(this.parent, e);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00004314 File Offset: 0x00003314
		public virtual void OnStatusBar(bool statusBar)
		{
			global::AxSHDocVw.DWebBrowserEvents2_OnStatusBarEvent e = new global::AxSHDocVw.DWebBrowserEvents2_OnStatusBarEvent(statusBar);
			this.parent.RaiseOnOnStatusBar(this.parent, e);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000433C File Offset: 0x0000333C
		public virtual void OnMenuBar(bool menuBar)
		{
			global::AxSHDocVw.DWebBrowserEvents2_OnMenuBarEvent e = new global::AxSHDocVw.DWebBrowserEvents2_OnMenuBarEvent(menuBar);
			this.parent.RaiseOnOnMenuBar(this.parent, e);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00004364 File Offset: 0x00003364
		public virtual void OnToolBar(bool toolBar)
		{
			global::AxSHDocVw.DWebBrowserEvents2_OnToolBarEvent e = new global::AxSHDocVw.DWebBrowserEvents2_OnToolBarEvent(toolBar);
			this.parent.RaiseOnOnToolBar(this.parent, e);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000438C File Offset: 0x0000338C
		public virtual void OnVisible(bool visible)
		{
			global::AxSHDocVw.DWebBrowserEvents2_OnVisibleEvent e = new global::AxSHDocVw.DWebBrowserEvents2_OnVisibleEvent(visible);
			this.parent.RaiseOnOnVisible(this.parent, e);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000043B4 File Offset: 0x000033B4
		public virtual void OnQuit()
		{
			global::System.EventArgs e = new global::System.EventArgs();
			this.parent.RaiseOnOnQuit(this.parent, e);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000043DC File Offset: 0x000033DC
		public virtual void DocumentComplete(object pDisp, ref object uRL)
		{
			global::AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent dwebBrowserEvents2_DocumentCompleteEvent = new global::AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent(pDisp, uRL);
			this.parent.RaiseOnDocumentComplete(this.parent, dwebBrowserEvents2_DocumentCompleteEvent);
			uRL = dwebBrowserEvents2_DocumentCompleteEvent.uRL;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000440C File Offset: 0x0000340C
		public virtual void NavigateComplete2(object pDisp, ref object uRL)
		{
			global::AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event dwebBrowserEvents2_NavigateComplete2Event = new global::AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event(pDisp, uRL);
			this.parent.RaiseOnNavigateComplete2(this.parent, dwebBrowserEvents2_NavigateComplete2Event);
			uRL = dwebBrowserEvents2_NavigateComplete2Event.uRL;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000443C File Offset: 0x0000343C
		public virtual void NewWindow2(ref object ppDisp, ref bool cancel)
		{
			global::AxSHDocVw.DWebBrowserEvents2_NewWindow2Event dwebBrowserEvents2_NewWindow2Event = new global::AxSHDocVw.DWebBrowserEvents2_NewWindow2Event(ppDisp, cancel);
			this.parent.RaiseOnNewWindow2(this.parent, dwebBrowserEvents2_NewWindow2Event);
			ppDisp = dwebBrowserEvents2_NewWindow2Event.ppDisp;
			cancel = dwebBrowserEvents2_NewWindow2Event.cancel;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00004478 File Offset: 0x00003478
		public virtual void BeforeNavigate2(object pDisp, ref object uRL, ref object flags, ref object targetFrameName, ref object postData, ref object headers, ref bool cancel)
		{
			global::AxSHDocVw.DWebBrowserEvents2_BeforeNavigate2Event dwebBrowserEvents2_BeforeNavigate2Event = new global::AxSHDocVw.DWebBrowserEvents2_BeforeNavigate2Event(pDisp, uRL, flags, targetFrameName, postData, headers, cancel);
			this.parent.RaiseOnBeforeNavigate2(this.parent, dwebBrowserEvents2_BeforeNavigate2Event);
			uRL = dwebBrowserEvents2_BeforeNavigate2Event.uRL;
			flags = dwebBrowserEvents2_BeforeNavigate2Event.flags;
			targetFrameName = dwebBrowserEvents2_BeforeNavigate2Event.targetFrameName;
			postData = dwebBrowserEvents2_BeforeNavigate2Event.postData;
			headers = dwebBrowserEvents2_BeforeNavigate2Event.headers;
			cancel = dwebBrowserEvents2_BeforeNavigate2Event.cancel;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000044E4 File Offset: 0x000034E4
		public virtual void PropertyChange(string szProperty)
		{
			global::AxSHDocVw.DWebBrowserEvents2_PropertyChangeEvent e = new global::AxSHDocVw.DWebBrowserEvents2_PropertyChangeEvent(szProperty);
			this.parent.RaiseOnPropertyChange(this.parent, e);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000450C File Offset: 0x0000350C
		public virtual void TitleChange(string text)
		{
			global::AxSHDocVw.DWebBrowserEvents2_TitleChangeEvent e = new global::AxSHDocVw.DWebBrowserEvents2_TitleChangeEvent(text);
			this.parent.RaiseOnTitleChange(this.parent, e);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00004534 File Offset: 0x00003534
		public virtual void DownloadComplete()
		{
			global::System.EventArgs e = new global::System.EventArgs();
			this.parent.RaiseOnDownloadComplete(this.parent, e);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000455C File Offset: 0x0000355C
		public virtual void DownloadBegin()
		{
			global::System.EventArgs e = new global::System.EventArgs();
			this.parent.RaiseOnDownloadBegin(this.parent, e);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00004584 File Offset: 0x00003584
		public virtual void CommandStateChange(int command, bool enable)
		{
			global::AxSHDocVw.DWebBrowserEvents2_CommandStateChangeEvent e = new global::AxSHDocVw.DWebBrowserEvents2_CommandStateChangeEvent(command, enable);
			this.parent.RaiseOnCommandStateChange(this.parent, e);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000045AC File Offset: 0x000035AC
		public virtual void ProgressChange(int progress, int progressMax)
		{
			global::AxSHDocVw.DWebBrowserEvents2_ProgressChangeEvent e = new global::AxSHDocVw.DWebBrowserEvents2_ProgressChangeEvent(progress, progressMax);
			this.parent.RaiseOnProgressChange(this.parent, e);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000045D4 File Offset: 0x000035D4
		public virtual void StatusTextChange(string text)
		{
			global::AxSHDocVw.DWebBrowserEvents2_StatusTextChangeEvent e = new global::AxSHDocVw.DWebBrowserEvents2_StatusTextChangeEvent(text);
			this.parent.RaiseOnStatusTextChange(this.parent, e);
		}

		// Token: 0x04000054 RID: 84
		private global::AxSHDocVw.AxWebBrowser parent;
	}
}
