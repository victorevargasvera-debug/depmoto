using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x0200006D RID: 109
	internal sealed class DShellNameSpaceEvents_EventProvider : global::SHDocVw.DShellNameSpaceEvents_Event, global::System.IDisposable
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x00002168 File Offset: 0x00001168
		private void Init()
		{
			global::System.Runtime.InteropServices.UCOMIConnectionPoint ucomiconnectionPoint = null;
			global::System.Guid guid = new global::System.Guid(new byte[]
			{
				6,
				104,
				19,
				85,
				222,
				178,
				209,
				17,
				185,
				242,
				0,
				160,
				201,
				139,
				197,
				71
			});
			this.m_ConnectionPointContainer.FindConnectionPoint(ref guid, out ucomiconnectionPoint);
			this.m_ConnectionPoint = (global::System.Runtime.InteropServices.UCOMIConnectionPoint)ucomiconnectionPoint;
			this.m_aEventSinkHelpers = new global::System.Collections.ArrayList();
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000227C File Offset: 0x0000127C
		public void add_Initialized(global::SHDocVw.DShellNameSpaceEvents_InitializedEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DShellNameSpaceEvents_SinkHelper dshellNameSpaceEvents_SinkHelper = new global::SHDocVw.DShellNameSpaceEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dshellNameSpaceEvents_SinkHelper, out dwCookie);
				dshellNameSpaceEvents_SinkHelper.m_dwCookie = dwCookie;
				dshellNameSpaceEvents_SinkHelper.m_InitializedDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dshellNameSpaceEvents_SinkHelper);
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0000230C File Offset: 0x0000130C
		public void remove_Initialized(global::SHDocVw.DShellNameSpaceEvents_InitializedEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DShellNameSpaceEvents_SinkHelper dshellNameSpaceEvents_SinkHelper;
					for (;;)
					{
						dshellNameSpaceEvents_SinkHelper = (global::SHDocVw.DShellNameSpaceEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dshellNameSpaceEvents_SinkHelper.m_InitializedDelegate != null && ((dshellNameSpaceEvents_SinkHelper.m_InitializedDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dshellNameSpaceEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000240C File Offset: 0x0000140C
		public void add_DoubleClick(global::SHDocVw.DShellNameSpaceEvents_DoubleClickEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DShellNameSpaceEvents_SinkHelper dshellNameSpaceEvents_SinkHelper = new global::SHDocVw.DShellNameSpaceEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dshellNameSpaceEvents_SinkHelper, out dwCookie);
				dshellNameSpaceEvents_SinkHelper.m_dwCookie = dwCookie;
				dshellNameSpaceEvents_SinkHelper.m_DoubleClickDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dshellNameSpaceEvents_SinkHelper);
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0000249C File Offset: 0x0000149C
		public void remove_DoubleClick(global::SHDocVw.DShellNameSpaceEvents_DoubleClickEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DShellNameSpaceEvents_SinkHelper dshellNameSpaceEvents_SinkHelper;
					for (;;)
					{
						dshellNameSpaceEvents_SinkHelper = (global::SHDocVw.DShellNameSpaceEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dshellNameSpaceEvents_SinkHelper.m_DoubleClickDelegate != null && ((dshellNameSpaceEvents_SinkHelper.m_DoubleClickDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dshellNameSpaceEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x060005F4 RID: 1524 RVA: 0x0000259C File Offset: 0x0000159C
		public void add_SelectionChange(global::SHDocVw.DShellNameSpaceEvents_SelectionChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DShellNameSpaceEvents_SinkHelper dshellNameSpaceEvents_SinkHelper = new global::SHDocVw.DShellNameSpaceEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dshellNameSpaceEvents_SinkHelper, out dwCookie);
				dshellNameSpaceEvents_SinkHelper.m_dwCookie = dwCookie;
				dshellNameSpaceEvents_SinkHelper.m_SelectionChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dshellNameSpaceEvents_SinkHelper);
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0000262C File Offset: 0x0000162C
		public void remove_SelectionChange(global::SHDocVw.DShellNameSpaceEvents_SelectionChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DShellNameSpaceEvents_SinkHelper dshellNameSpaceEvents_SinkHelper;
					for (;;)
					{
						dshellNameSpaceEvents_SinkHelper = (global::SHDocVw.DShellNameSpaceEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dshellNameSpaceEvents_SinkHelper.m_SelectionChangeDelegate != null && ((dshellNameSpaceEvents_SinkHelper.m_SelectionChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dshellNameSpaceEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000272C File Offset: 0x0000172C
		public void add_FavoritesSelectionChange(global::SHDocVw.DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::SHDocVw.DShellNameSpaceEvents_SinkHelper dshellNameSpaceEvents_SinkHelper = new global::SHDocVw.DShellNameSpaceEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)dshellNameSpaceEvents_SinkHelper, out dwCookie);
				dshellNameSpaceEvents_SinkHelper.m_dwCookie = dwCookie;
				dshellNameSpaceEvents_SinkHelper.m_FavoritesSelectionChangeDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)dshellNameSpaceEvents_SinkHelper);
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000027BC File Offset: 0x000017BC
		public void remove_FavoritesSelectionChange(global::SHDocVw.DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::SHDocVw.DShellNameSpaceEvents_SinkHelper dshellNameSpaceEvents_SinkHelper;
					for (;;)
					{
						dshellNameSpaceEvents_SinkHelper = (global::SHDocVw.DShellNameSpaceEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (dshellNameSpaceEvents_SinkHelper.m_FavoritesSelectionChangeDelegate != null && ((dshellNameSpaceEvents_SinkHelper.m_FavoritesSelectionChangeDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(dshellNameSpaceEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x060005F8 RID: 1528 RVA: 0x000028BC File Offset: 0x000018BC
		public DShellNameSpaceEvents_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (global::System.Runtime.InteropServices.UCOMIConnectionPointContainer)A_1;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000028E4 File Offset: 0x000018E4
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
								global::SHDocVw.DShellNameSpaceEvents_SinkHelper dshellNameSpaceEvents_SinkHelper = (global::SHDocVw.DShellNameSpaceEvents_SinkHelper)this.m_aEventSinkHelpers[num];
								this.m_ConnectionPoint.Unadvise(dshellNameSpaceEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x060005FA RID: 1530 RVA: 0x000029A8 File Offset: 0x000019A8
		public void Dispose()
		{
			this.Finalize();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000062 RID: 98
		private global::System.Runtime.InteropServices.UCOMIConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x04000063 RID: 99
		private global::System.Collections.ArrayList m_aEventSinkHelpers;

		// Token: 0x04000064 RID: 100
		private global::System.Runtime.InteropServices.UCOMIConnectionPoint m_ConnectionPoint;
	}
}
