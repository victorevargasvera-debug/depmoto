using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000075 RID: 117
	internal sealed class DWebBrowserEvents2_EventProvider : global::SHDocVw.DWebBrowserEvents2_Event, global::System.IDisposable
	{
		// Token: 0x0600066A RID: 1642 RVA: 0x00005E0C File Offset: 0x00004E0C
		private void Init()
		{
			global::System.Runtime.InteropServices.UCOMIConnectionPoint ucomiconnectionPoint = null;
			global::System.Guid guid = new global::System.Guid(new byte[]
			{
				160,
				21,
				167,
				52,
				135,
				101,
				208,
				17,
				146,
				74,
				0,
				32,
				175,
				199,
				172,
				77
			});
			this.m_ConnectionPointContainer.FindConnectionPoint(ref guid, out ucomiconnectionPoint);
			this.m_ConnectionPoint = (global::System.Runtime.InteropServices.UCOMIConnectionPoint)ucomiconnectionPoint;
			this.m_aEventSinkHelpers = new global::System.Collections.ArrayList();
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00005F20 File Offset: 0x00004F20
		public void add_PrivacyImpactedStateChange(global::SHDocVw.DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_PrivacyImpactedStateChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00005FB0 File Offset: 0x00004FB0
		public void remove_PrivacyImpactedStateChange(global::SHDocVw.DWebBrowserEvents2_PrivacyImpactedStateChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_PrivacyImpactedStateChangeDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_PrivacyImpactedStateChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x0600066D RID: 1645 RVA: 0x000060B0 File Offset: 0x000050B0
		public void add_UpdatePageStatus(global::SHDocVw.DWebBrowserEvents2_UpdatePageStatusEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_UpdatePageStatusDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00006140 File Offset: 0x00005140
		public void remove_UpdatePageStatus(global::SHDocVw.DWebBrowserEvents2_UpdatePageStatusEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_UpdatePageStatusDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_UpdatePageStatusDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x0600066F RID: 1647 RVA: 0x00006240 File Offset: 0x00005240
		public void add_PrintTemplateTeardown(global::SHDocVw.DWebBrowserEvents2_PrintTemplateTeardownEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_PrintTemplateTeardownDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x000062D0 File Offset: 0x000052D0
		public void remove_PrintTemplateTeardown(global::SHDocVw.DWebBrowserEvents2_PrintTemplateTeardownEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_PrintTemplateTeardownDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_PrintTemplateTeardownDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000671 RID: 1649 RVA: 0x000063D0 File Offset: 0x000053D0
		public void add_PrintTemplateInstantiation(global::SHDocVw.DWebBrowserEvents2_PrintTemplateInstantiationEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_PrintTemplateInstantiationDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00006460 File Offset: 0x00005460
		public void remove_PrintTemplateInstantiation(global::SHDocVw.DWebBrowserEvents2_PrintTemplateInstantiationEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_PrintTemplateInstantiationDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_PrintTemplateInstantiationDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000673 RID: 1651 RVA: 0x00006560 File Offset: 0x00005560
		public void add_NavigateError(global::SHDocVw.DWebBrowserEvents2_NavigateErrorEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_NavigateErrorDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000065F0 File Offset: 0x000055F0
		public void remove_NavigateError(global::SHDocVw.DWebBrowserEvents2_NavigateErrorEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_NavigateErrorDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_NavigateErrorDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000675 RID: 1653 RVA: 0x000066F0 File Offset: 0x000056F0
		public void add_FileDownload(global::SHDocVw.DWebBrowserEvents2_FileDownloadEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_FileDownloadDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00006780 File Offset: 0x00005780
		public void remove_FileDownload(global::SHDocVw.DWebBrowserEvents2_FileDownloadEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_FileDownloadDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_FileDownloadDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000677 RID: 1655 RVA: 0x00006880 File Offset: 0x00005880
		public void add_SetSecureLockIcon(global::SHDocVw.DWebBrowserEvents2_SetSecureLockIconEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_SetSecureLockIconDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00006910 File Offset: 0x00005910
		public void remove_SetSecureLockIcon(global::SHDocVw.DWebBrowserEvents2_SetSecureLockIconEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_SetSecureLockIconDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_SetSecureLockIconDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000679 RID: 1657 RVA: 0x00006A10 File Offset: 0x00005A10
		public void add_ClientToHostWindow(global::SHDocVw.DWebBrowserEvents2_ClientToHostWindowEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_ClientToHostWindowDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00006AA0 File Offset: 0x00005AA0
		public void remove_ClientToHostWindow(global::SHDocVw.DWebBrowserEvents2_ClientToHostWindowEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_ClientToHostWindowDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_ClientToHostWindowDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x0600067B RID: 1659 RVA: 0x00006BA0 File Offset: 0x00005BA0
		public void add_WindowClosing(global::SHDocVw.DWebBrowserEvents2_WindowClosingEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_WindowClosingDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00006C30 File Offset: 0x00005C30
		public void remove_WindowClosing(global::SHDocVw.DWebBrowserEvents2_WindowClosingEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_WindowClosingDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_WindowClosingDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x0600067D RID: 1661 RVA: 0x00006D30 File Offset: 0x00005D30
		public void add_WindowSetHeight(global::SHDocVw.DWebBrowserEvents2_WindowSetHeightEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_WindowSetHeightDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00006DC0 File Offset: 0x00005DC0
		public void remove_WindowSetHeight(global::SHDocVw.DWebBrowserEvents2_WindowSetHeightEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_WindowSetHeightDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_WindowSetHeightDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x0600067F RID: 1663 RVA: 0x00006EC0 File Offset: 0x00005EC0
		public void add_WindowSetWidth(global::SHDocVw.DWebBrowserEvents2_WindowSetWidthEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_WindowSetWidthDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00006F50 File Offset: 0x00005F50
		public void remove_WindowSetWidth(global::SHDocVw.DWebBrowserEvents2_WindowSetWidthEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_WindowSetWidthDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_WindowSetWidthDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000681 RID: 1665 RVA: 0x00007050 File Offset: 0x00006050
		public void add_WindowSetTop(global::SHDocVw.DWebBrowserEvents2_WindowSetTopEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_WindowSetTopDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x000070E0 File Offset: 0x000060E0
		public void remove_WindowSetTop(global::SHDocVw.DWebBrowserEvents2_WindowSetTopEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_WindowSetTopDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_WindowSetTopDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000683 RID: 1667 RVA: 0x000071E0 File Offset: 0x000061E0
		public void add_WindowSetLeft(global::SHDocVw.DWebBrowserEvents2_WindowSetLeftEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_WindowSetLeftDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00007270 File Offset: 0x00006270
		public void remove_WindowSetLeft(global::SHDocVw.DWebBrowserEvents2_WindowSetLeftEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_WindowSetLeftDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_WindowSetLeftDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000685 RID: 1669 RVA: 0x00007370 File Offset: 0x00006370
		public void add_WindowSetResizable(global::SHDocVw.DWebBrowserEvents2_WindowSetResizableEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_WindowSetResizableDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00007400 File Offset: 0x00006400
		public void remove_WindowSetResizable(global::SHDocVw.DWebBrowserEvents2_WindowSetResizableEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_WindowSetResizableDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_WindowSetResizableDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000687 RID: 1671 RVA: 0x00007500 File Offset: 0x00006500
		public void add_OnTheaterMode(global::SHDocVw.DWebBrowserEvents2_OnTheaterModeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_OnTheaterModeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00007590 File Offset: 0x00006590
		public void remove_OnTheaterMode(global::SHDocVw.DWebBrowserEvents2_OnTheaterModeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_OnTheaterModeDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_OnTheaterModeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000689 RID: 1673 RVA: 0x00007690 File Offset: 0x00006690
		public void add_OnFullScreen(global::SHDocVw.DWebBrowserEvents2_OnFullScreenEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_OnFullScreenDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00007720 File Offset: 0x00006720
		public void remove_OnFullScreen(global::SHDocVw.DWebBrowserEvents2_OnFullScreenEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_OnFullScreenDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_OnFullScreenDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x0600068B RID: 1675 RVA: 0x00007820 File Offset: 0x00006820
		public void add_OnStatusBar(global::SHDocVw.DWebBrowserEvents2_OnStatusBarEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_OnStatusBarDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000078B0 File Offset: 0x000068B0
		public void remove_OnStatusBar(global::SHDocVw.DWebBrowserEvents2_OnStatusBarEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_OnStatusBarDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_OnStatusBarDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x0600068D RID: 1677 RVA: 0x000079B0 File Offset: 0x000069B0
		public void add_OnMenuBar(global::SHDocVw.DWebBrowserEvents2_OnMenuBarEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_OnMenuBarDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00007A40 File Offset: 0x00006A40
		public void remove_OnMenuBar(global::SHDocVw.DWebBrowserEvents2_OnMenuBarEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_OnMenuBarDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_OnMenuBarDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x0600068F RID: 1679 RVA: 0x00007B40 File Offset: 0x00006B40
		public void add_OnToolBar(global::SHDocVw.DWebBrowserEvents2_OnToolBarEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_OnToolBarDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00007BD0 File Offset: 0x00006BD0
		public void remove_OnToolBar(global::SHDocVw.DWebBrowserEvents2_OnToolBarEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_OnToolBarDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_OnToolBarDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000691 RID: 1681 RVA: 0x00007CD0 File Offset: 0x00006CD0
		public void add_OnVisible(global::SHDocVw.DWebBrowserEvents2_OnVisibleEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_OnVisibleDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00007D60 File Offset: 0x00006D60
		public void remove_OnVisible(global::SHDocVw.DWebBrowserEvents2_OnVisibleEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_OnVisibleDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_OnVisibleDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000693 RID: 1683 RVA: 0x00007E60 File Offset: 0x00006E60
		public void add_OnQuit(global::SHDocVw.DWebBrowserEvents2_OnQuitEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_OnQuitDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00007EF0 File Offset: 0x00006EF0
		public void remove_OnQuit(global::SHDocVw.DWebBrowserEvents2_OnQuitEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_OnQuitDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_OnQuitDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000695 RID: 1685 RVA: 0x00007FF0 File Offset: 0x00006FF0
		public void add_DocumentComplete(global::SHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_DocumentCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00008080 File Offset: 0x00007080
		public void remove_DocumentComplete(global::SHDocVw.DWebBrowserEvents2_DocumentCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_DocumentCompleteDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_DocumentCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000697 RID: 1687 RVA: 0x00008180 File Offset: 0x00007180
		public void add_NavigateComplete2(global::SHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_NavigateComplete2Delegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00008210 File Offset: 0x00007210
		public void remove_NavigateComplete2(global::SHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_NavigateComplete2Delegate != null && ((dwebBrowserEvents2_SinkHelper.m_NavigateComplete2Delegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x06000699 RID: 1689 RVA: 0x00008310 File Offset: 0x00007310
		public void add_NewWindow2(global::SHDocVw.DWebBrowserEvents2_NewWindow2EventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_NewWindow2Delegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000083A0 File Offset: 0x000073A0
		public void remove_NewWindow2(global::SHDocVw.DWebBrowserEvents2_NewWindow2EventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_NewWindow2Delegate != null && ((dwebBrowserEvents2_SinkHelper.m_NewWindow2Delegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x0600069B RID: 1691 RVA: 0x000084A0 File Offset: 0x000074A0
		public void add_BeforeNavigate2(global::SHDocVw.DWebBrowserEvents2_BeforeNavigate2EventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_BeforeNavigate2Delegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00008530 File Offset: 0x00007530
		public void remove_BeforeNavigate2(global::SHDocVw.DWebBrowserEvents2_BeforeNavigate2EventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_BeforeNavigate2Delegate != null && ((dwebBrowserEvents2_SinkHelper.m_BeforeNavigate2Delegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x0600069D RID: 1693 RVA: 0x00008630 File Offset: 0x00007630
		public void add_PropertyChange(global::SHDocVw.DWebBrowserEvents2_PropertyChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_PropertyChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000086C0 File Offset: 0x000076C0
		public void remove_PropertyChange(global::SHDocVw.DWebBrowserEvents2_PropertyChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_PropertyChangeDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_PropertyChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x0600069F RID: 1695 RVA: 0x000087C0 File Offset: 0x000077C0
		public void add_TitleChange(global::SHDocVw.DWebBrowserEvents2_TitleChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_TitleChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00008850 File Offset: 0x00007850
		public void remove_TitleChange(global::SHDocVw.DWebBrowserEvents2_TitleChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_TitleChangeDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_TitleChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x060006A1 RID: 1697 RVA: 0x00008950 File Offset: 0x00007950
		public void add_DownloadComplete(global::SHDocVw.DWebBrowserEvents2_DownloadCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_DownloadCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000089E0 File Offset: 0x000079E0
		public void remove_DownloadComplete(global::SHDocVw.DWebBrowserEvents2_DownloadCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_DownloadCompleteDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_DownloadCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x060006A3 RID: 1699 RVA: 0x00008AE0 File Offset: 0x00007AE0
		public void add_DownloadBegin(global::SHDocVw.DWebBrowserEvents2_DownloadBeginEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_DownloadBeginDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00008B70 File Offset: 0x00007B70
		public void remove_DownloadBegin(global::SHDocVw.DWebBrowserEvents2_DownloadBeginEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_DownloadBeginDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_DownloadBeginDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x060006A5 RID: 1701 RVA: 0x00008C70 File Offset: 0x00007C70
		public void add_CommandStateChange(global::SHDocVw.DWebBrowserEvents2_CommandStateChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_CommandStateChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00008D00 File Offset: 0x00007D00
		public void remove_CommandStateChange(global::SHDocVw.DWebBrowserEvents2_CommandStateChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_CommandStateChangeDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_CommandStateChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x060006A7 RID: 1703 RVA: 0x00008E00 File Offset: 0x00007E00
		public void add_ProgressChange(global::SHDocVw.DWebBrowserEvents2_ProgressChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_ProgressChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00008E90 File Offset: 0x00007E90
		public void remove_ProgressChange(global::SHDocVw.DWebBrowserEvents2_ProgressChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_ProgressChangeDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_ProgressChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x060006A9 RID: 1705 RVA: 0x00008F90 File Offset: 0x00007F90
		public void add_StatusTextChange(global::SHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = new global::SHDocVw.DWebBrowserEvents2_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dwebBrowserEvents2_SinkHelper, out dwCookie);
				dwebBrowserEvents2_SinkHelper.m_dwCookie = dwCookie;
				dwebBrowserEvents2_SinkHelper.m_StatusTextChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dwebBrowserEvents2_SinkHelper);
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00009020 File Offset: 0x00008020
		public void remove_StatusTextChange(global::SHDocVw.DWebBrowserEvents2_StatusTextChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper;
					for (;;)
					{
						dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dwebBrowserEvents2_SinkHelper.m_StatusTextChangeDelegate != null && ((dwebBrowserEvents2_SinkHelper.m_StatusTextChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x060006AB RID: 1707 RVA: 0x00009120 File Offset: 0x00008120
		public DWebBrowserEvents2_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (global::System.Runtime.InteropServices.UCOMIConnectionPointContainer)A_1;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00009148 File Offset: 0x00008148
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
								global::SHDocVw.DWebBrowserEvents2_SinkHelper dwebBrowserEvents2_SinkHelper = (global::SHDocVw.DWebBrowserEvents2_SinkHelper)this.m_aEventSinkHelpers[num];
								this.m_ConnectionPoint.Unadvise(dwebBrowserEvents2_SinkHelper.m_dwCookie);
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

		// Token: 0x060006AD RID: 1709 RVA: 0x0000920C File Offset: 0x0000820C
		public void Dispose()
		{
			this.Finalize();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040000A7 RID: 167
		private global::System.Runtime.InteropServices.UCOMIConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x040000A8 RID: 168
		private global::System.Collections.ArrayList m_aEventSinkHelpers;

		// Token: 0x040000A9 RID: 169
		private global::System.Runtime.InteropServices.UCOMIConnectionPoint m_ConnectionPoint;
	}
}
