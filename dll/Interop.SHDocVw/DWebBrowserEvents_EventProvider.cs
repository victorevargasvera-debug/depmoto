using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000071 RID: 113
	internal sealed class DWebBrowserEvents_EventProvider : global::SHDocVw.DWebBrowserEvents_Event, global::System.IDisposable
	{
		// Token: 0x06000618 RID: 1560 RVA: 0x000033E4 File Offset: 0x000023E4
		private void Init()
		{
			global::System.Runtime.InteropServices.UCOMIConnectionPoint ucomiconnectionPoint = null;
			global::System.Guid guid = new global::System.Guid(new byte[]
			{
				194,
				42,
				178,
				234,
				193,
				48,
				207,
				17,
				167,
				235,
				0,
				0,
				192,
				91,
				174,
				11
			});
			this.m_ConnectionPointContainer.FindConnectionPoint(ref guid, out ucomiconnectionPoint);
			this.m_ConnectionPoint = (global::System.Runtime.InteropServices.UCOMIConnectionPoint)ucomiconnectionPoint;
			this.m_aEventSinkHelpers = new global::System.Collections.ArrayList();
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000034F8 File Offset: 0x000024F8
		public void add_PropertyChange(global::SHDocVw.DWebBrowserEvents_PropertyChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_PropertyChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00003588 File Offset: 0x00002588
		public void remove_PropertyChange(global::SHDocVw.DWebBrowserEvents_PropertyChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_PropertyChangeDelegate != null && ((dwebBrowserEvents_SinkHelper.m_PropertyChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00003688 File Offset: 0x00002688
		public void add_WindowActivate(global::SHDocVw.DWebBrowserEvents_WindowActivateEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_WindowActivateDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00003718 File Offset: 0x00002718
		public void remove_WindowActivate(global::SHDocVw.DWebBrowserEvents_WindowActivateEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_WindowActivateDelegate != null && ((dwebBrowserEvents_SinkHelper.m_WindowActivateDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00003818 File Offset: 0x00002818
		public void add_WindowResize(global::SHDocVw.DWebBrowserEvents_WindowResizeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_WindowResizeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000038A8 File Offset: 0x000028A8
		public void remove_WindowResize(global::SHDocVw.DWebBrowserEvents_WindowResizeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_WindowResizeDelegate != null && ((dwebBrowserEvents_SinkHelper.m_WindowResizeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000039A8 File Offset: 0x000029A8
		public void add_WindowMove(global::SHDocVw.DWebBrowserEvents_WindowMoveEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_WindowMoveDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00003A38 File Offset: 0x00002A38
		public void remove_WindowMove(global::SHDocVw.DWebBrowserEvents_WindowMoveEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_WindowMoveDelegate != null && ((dwebBrowserEvents_SinkHelper.m_WindowMoveDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00003B38 File Offset: 0x00002B38
		public void add_Quit(global::SHDocVw.DWebBrowserEvents_QuitEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_QuitDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00003BC8 File Offset: 0x00002BC8
		public void remove_Quit(global::SHDocVw.DWebBrowserEvents_QuitEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_QuitDelegate != null && ((dwebBrowserEvents_SinkHelper.m_QuitDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00003CC8 File Offset: 0x00002CC8
		public void add_FrameNewWindow(global::SHDocVw.DWebBrowserEvents_FrameNewWindowEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_FrameNewWindowDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00003D58 File Offset: 0x00002D58
		public void remove_FrameNewWindow(global::SHDocVw.DWebBrowserEvents_FrameNewWindowEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_FrameNewWindowDelegate != null && ((dwebBrowserEvents_SinkHelper.m_FrameNewWindowDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00003E58 File Offset: 0x00002E58
		public void add_FrameNavigateComplete(global::SHDocVw.DWebBrowserEvents_FrameNavigateCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_FrameNavigateCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00003EE8 File Offset: 0x00002EE8
		public void remove_FrameNavigateComplete(global::SHDocVw.DWebBrowserEvents_FrameNavigateCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_FrameNavigateCompleteDelegate != null && ((dwebBrowserEvents_SinkHelper.m_FrameNavigateCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00003FE8 File Offset: 0x00002FE8
		public void add_FrameBeforeNavigate(global::SHDocVw.DWebBrowserEvents_FrameBeforeNavigateEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_FrameBeforeNavigateDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00004078 File Offset: 0x00003078
		public void remove_FrameBeforeNavigate(global::SHDocVw.DWebBrowserEvents_FrameBeforeNavigateEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_FrameBeforeNavigateDelegate != null && ((dwebBrowserEvents_SinkHelper.m_FrameBeforeNavigateDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00004178 File Offset: 0x00003178
		public void add_TitleChange(global::SHDocVw.DWebBrowserEvents_TitleChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_TitleChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00004208 File Offset: 0x00003208
		public void remove_TitleChange(global::SHDocVw.DWebBrowserEvents_TitleChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_TitleChangeDelegate != null && ((dwebBrowserEvents_SinkHelper.m_TitleChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00004308 File Offset: 0x00003308
		public void add_NewWindow(global::SHDocVw.DWebBrowserEvents_NewWindowEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_NewWindowDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00004398 File Offset: 0x00003398
		public void remove_NewWindow(global::SHDocVw.DWebBrowserEvents_NewWindowEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_NewWindowDelegate != null && ((dwebBrowserEvents_SinkHelper.m_NewWindowDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00004498 File Offset: 0x00003498
		public void add_DownloadBegin(global::SHDocVw.DWebBrowserEvents_DownloadBeginEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_DownloadBeginDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00004528 File Offset: 0x00003528
		public void remove_DownloadBegin(global::SHDocVw.DWebBrowserEvents_DownloadBeginEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_DownloadBeginDelegate != null && ((dwebBrowserEvents_SinkHelper.m_DownloadBeginDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00004628 File Offset: 0x00003628
		public void add_CommandStateChange(global::SHDocVw.DWebBrowserEvents_CommandStateChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_CommandStateChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000046B8 File Offset: 0x000036B8
		public void remove_CommandStateChange(global::SHDocVw.DWebBrowserEvents_CommandStateChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_CommandStateChangeDelegate != null && ((dwebBrowserEvents_SinkHelper.m_CommandStateChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x000047B8 File Offset: 0x000037B8
		public void add_DownloadComplete(global::SHDocVw.DWebBrowserEvents_DownloadCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_DownloadCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00004848 File Offset: 0x00003848
		public void remove_DownloadComplete(global::SHDocVw.DWebBrowserEvents_DownloadCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_DownloadCompleteDelegate != null && ((dwebBrowserEvents_SinkHelper.m_DownloadCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00004948 File Offset: 0x00003948
		public void add_ProgressChange(global::SHDocVw.DWebBrowserEvents_ProgressChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_ProgressChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000049D8 File Offset: 0x000039D8
		public void remove_ProgressChange(global::SHDocVw.DWebBrowserEvents_ProgressChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_ProgressChangeDelegate != null && ((dwebBrowserEvents_SinkHelper.m_ProgressChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00004AD8 File Offset: 0x00003AD8
		public void add_StatusTextChange(global::SHDocVw.DWebBrowserEvents_StatusTextChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_StatusTextChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00004B68 File Offset: 0x00003B68
		public void remove_StatusTextChange(global::SHDocVw.DWebBrowserEvents_StatusTextChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_StatusTextChangeDelegate != null && ((dwebBrowserEvents_SinkHelper.m_StatusTextChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00004C68 File Offset: 0x00003C68
		public void add_NavigateComplete(global::SHDocVw.DWebBrowserEvents_NavigateCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_NavigateCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00004CF8 File Offset: 0x00003CF8
		public void remove_NavigateComplete(global::SHDocVw.DWebBrowserEvents_NavigateCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_NavigateCompleteDelegate != null && ((dwebBrowserEvents_SinkHelper.m_NavigateCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00004DF8 File Offset: 0x00003DF8
		public void add_BeforeNavigate(global::SHDocVw.DWebBrowserEvents_BeforeNavigateEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = new global::SHDocVw.DWebBrowserEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents_SinkHelper, out dwCookie);
				dwebBrowserEvents_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents_SinkHelper.m_BeforeNavigateDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents_SinkHelper);
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00004E88 File Offset: 0x00003E88
		public void remove_BeforeNavigate(global::SHDocVw.DWebBrowserEvents_BeforeNavigateEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents_SinkHelper.m_BeforeNavigateDelegate != null && ((dwebBrowserEvents_SinkHelper.m_BeforeNavigateDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
						{
							break;
						}
						num++;
						if (num >= count)
						{
							goto IL_D3;
						}
					}
					this.m_aEventSinkHelpers.RemoveAt(num);
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
						this.m_ConnectionPoint = null;
						this.m_aEventSinkHelpers = null;
					}
				}
				IL_D3:;
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00004F88 File Offset: 0x00003F88
		public DWebBrowserEvents_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (global::System.Runtime.InteropServices.UCOMIConnectionPointContainer)A_1;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00004FB0 File Offset: 0x00003FB0
		public override void Finalize()
		{
			lock (this)
			{
				try
				{
					if (this.m_ConnectionPoint != null)
					{
						int count = this.m_aEventSinkHelpers.Count;
						int num = 0;
						if (0 < count)
						{
							do
							{
								global::SHDocVw.DWebBrowserEvents_SinkHelper dwebBrowserEvents_SinkHelper = (global::SHDocVw.DWebBrowserEvents_SinkHelper)this.m_aEventSinkHelpers[num];
								this.m_ConnectionPoint.Unadvise(dwebBrowserEvents_SinkHelper.m_dwCookie);
								num++;
							}
							while (num < count);
						}
						global::System.Runtime.InteropServices.Marshal.ReleaseComObject(this.m_ConnectionPoint);
					}
				}
				catch (global::System.Exception)
				{
				}
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00005074 File Offset: 0x00004074
		public void Dispose()
		{
			this.Finalize();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400007D RID: 125
		private global::System.Runtime.InteropServices.UCOMIConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x0400007E RID: 126
		private global::System.Collections.ArrayList m_aEventSinkHelpers;

		// Token: 0x0400007F RID: 127
		private global::System.Runtime.InteropServices.UCOMIConnectionPoint m_ConnectionPoint;
	}
}
