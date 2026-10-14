using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200006F RID: 111
	internal sealed class DShellWindowsEvents_EventProvider : global::SHDocVw.DShellWindowsEvents_Event, global::System.IDisposable
	{
		// Token: 0x060005FE RID: 1534 RVA: 0x00002A60 File Offset: 0x00001A60
		private void Init()
		{
			global::System.Runtime.InteropServices.UCOMIConnectionPoint ucomiconnectionPoint = null;
			global::System.Guid guid = new global::System.Guid(new byte[]
			{
				224,
				6,
				65,
				254,
				154,
				57,
				208,
				17,
				164,
				140,
				0,
				160,
				201,
				10,
				143,
				57
			});
			this.m_ConnectionPointContainer.FindConnectionPoint(ref guid, out ucomiconnectionPoint);
			this.m_ConnectionPoint = (global::System.Runtime.InteropServices.UCOMIConnectionPoint)ucomiconnectionPoint;
			this.m_aEventSinkHelpers = new global::System.Collections.ArrayList();
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00002B74 File Offset: 0x00001B74
		public void add_WindowRevoked(global::SHDocVw.DShellWindowsEvents_WindowRevokedEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DShellWindowsEvents_SinkHelper dshellWindowsEvents_SinkHelper = new global::SHDocVw.DShellWindowsEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dshellWindowsEvents_SinkHelper, out dwCookie);
				dshellWindowsEvents_SinkHelper.m_dwCookie = dwCookie;
				dshellWindowsEvents_SinkHelper.m_WindowRevokedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dshellWindowsEvents_SinkHelper);
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002C04 File Offset: 0x00001C04
		public void remove_WindowRevoked(global::SHDocVw.DShellWindowsEvents_WindowRevokedEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DShellWindowsEvents_SinkHelper dshellWindowsEvents_SinkHelper;
					for (;;)
					{
						dshellWindowsEvents_SinkHelper = (global::SHDocVw.DShellWindowsEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dshellWindowsEvents_SinkHelper.m_WindowRevokedDelegate != null && ((dshellWindowsEvents_SinkHelper.m_WindowRevokedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dshellWindowsEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06000601 RID: 1537 RVA: 0x00002D04 File Offset: 0x00001D04
		public void add_WindowRegistered(global::SHDocVw.DShellWindowsEvents_WindowRegisteredEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DShellWindowsEvents_SinkHelper dshellWindowsEvents_SinkHelper = new global::SHDocVw.DShellWindowsEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dshellWindowsEvents_SinkHelper, out dwCookie);
				dshellWindowsEvents_SinkHelper.m_dwCookie = dwCookie;
				dshellWindowsEvents_SinkHelper.m_WindowRegisteredDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dshellWindowsEvents_SinkHelper);
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00002D94 File Offset: 0x00001D94
		public void remove_WindowRegistered(global::SHDocVw.DShellWindowsEvents_WindowRegisteredEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DShellWindowsEvents_SinkHelper dshellWindowsEvents_SinkHelper;
					for (;;)
					{
						dshellWindowsEvents_SinkHelper = (global::SHDocVw.DShellWindowsEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dshellWindowsEvents_SinkHelper.m_WindowRegisteredDelegate != null && ((dshellWindowsEvents_SinkHelper.m_WindowRegisteredDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dshellWindowsEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06000603 RID: 1539 RVA: 0x00002E94 File Offset: 0x00001E94
		public DShellWindowsEvents_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (global::System.Runtime.InteropServices.UCOMIConnectionPointContainer)A_1;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00002EBC File Offset: 0x00001EBC
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
								global::SHDocVw.DShellWindowsEvents_SinkHelper dshellWindowsEvents_SinkHelper = (global::SHDocVw.DShellWindowsEvents_SinkHelper)this.m_aEventSinkHelpers[num];
								this.m_ConnectionPoint.Unadvise(dshellWindowsEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06000605 RID: 1541 RVA: 0x00002F80 File Offset: 0x00001F80
		public void Dispose()
		{
			this.Finalize();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000068 RID: 104
		private global::System.Runtime.InteropServices.UCOMIConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x04000069 RID: 105
		private global::System.Collections.ArrayList m_aEventSinkHelpers;

		// Token: 0x0400006A RID: 106
		private global::System.Runtime.InteropServices.UCOMIConnectionPoint m_ConnectionPoint;
	}
}
