using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000080 RID: 128
	internal sealed class ConnectionEvents_EventProvider : global::ADODB.ConnectionEvents_Event, global::System.IDisposable
	{
		// Token: 0x060003FB RID: 1019 RVA: 0x00003D30 File Offset: 0x00002D30
		private void Init()
		{
			global::System.Runtime.InteropServices.UCOMIConnectionPoint ucomiconnectionPoint = null;
			global::System.Guid guid = new global::System.Guid(new byte[]
			{
				0,
				4,
				0,
				0,
				0,
				0,
				16,
				0,
				128,
				0,
				0,
				170,
				0,
				109,
				46,
				164
			});
			this.m_ConnectionPointContainer.FindConnectionPoint(ref guid, out ucomiconnectionPoint);
			this.m_ConnectionPoint = (global::System.Runtime.InteropServices.UCOMIConnectionPoint)ucomiconnectionPoint;
			this.m_aEventSinkHelpers = new global::System.Collections.ArrayList();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00003E44 File Offset: 0x00002E44
		public void add_Disconnect(global::ADODB.ConnectionEvents_DisconnectEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper = new global::ADODB.ConnectionEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)connectionEvents_SinkHelper, out dwCookie);
				connectionEvents_SinkHelper.m_dwCookie = dwCookie;
				connectionEvents_SinkHelper.m_DisconnectDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)connectionEvents_SinkHelper);
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00003ED4 File Offset: 0x00002ED4
		public void remove_Disconnect(global::ADODB.ConnectionEvents_DisconnectEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper;
					for (;;)
					{
						connectionEvents_SinkHelper = (global::ADODB.ConnectionEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (connectionEvents_SinkHelper.m_DisconnectDelegate != null && ((connectionEvents_SinkHelper.m_DisconnectDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(connectionEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x060003FE RID: 1022 RVA: 0x00003FD4 File Offset: 0x00002FD4
		public void add_ConnectComplete(global::ADODB.ConnectionEvents_ConnectCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper = new global::ADODB.ConnectionEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)connectionEvents_SinkHelper, out dwCookie);
				connectionEvents_SinkHelper.m_dwCookie = dwCookie;
				connectionEvents_SinkHelper.m_ConnectCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)connectionEvents_SinkHelper);
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00004064 File Offset: 0x00003064
		public void remove_ConnectComplete(global::ADODB.ConnectionEvents_ConnectCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper;
					for (;;)
					{
						connectionEvents_SinkHelper = (global::ADODB.ConnectionEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (connectionEvents_SinkHelper.m_ConnectCompleteDelegate != null && ((connectionEvents_SinkHelper.m_ConnectCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(connectionEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06000400 RID: 1024 RVA: 0x00004164 File Offset: 0x00003164
		public void add_WillConnect(global::ADODB.ConnectionEvents_WillConnectEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper = new global::ADODB.ConnectionEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)connectionEvents_SinkHelper, out dwCookie);
				connectionEvents_SinkHelper.m_dwCookie = dwCookie;
				connectionEvents_SinkHelper.m_WillConnectDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)connectionEvents_SinkHelper);
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000041F4 File Offset: 0x000031F4
		public void remove_WillConnect(global::ADODB.ConnectionEvents_WillConnectEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper;
					for (;;)
					{
						connectionEvents_SinkHelper = (global::ADODB.ConnectionEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (connectionEvents_SinkHelper.m_WillConnectDelegate != null && ((connectionEvents_SinkHelper.m_WillConnectDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(connectionEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06000402 RID: 1026 RVA: 0x000042F4 File Offset: 0x000032F4
		public void add_ExecuteComplete(global::ADODB.ConnectionEvents_ExecuteCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper = new global::ADODB.ConnectionEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)connectionEvents_SinkHelper, out dwCookie);
				connectionEvents_SinkHelper.m_dwCookie = dwCookie;
				connectionEvents_SinkHelper.m_ExecuteCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)connectionEvents_SinkHelper);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00004384 File Offset: 0x00003384
		public void remove_ExecuteComplete(global::ADODB.ConnectionEvents_ExecuteCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper;
					for (;;)
					{
						connectionEvents_SinkHelper = (global::ADODB.ConnectionEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (connectionEvents_SinkHelper.m_ExecuteCompleteDelegate != null && ((connectionEvents_SinkHelper.m_ExecuteCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(connectionEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06000404 RID: 1028 RVA: 0x00004484 File Offset: 0x00003484
		public void add_WillExecute(global::ADODB.ConnectionEvents_WillExecuteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper = new global::ADODB.ConnectionEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)connectionEvents_SinkHelper, out dwCookie);
				connectionEvents_SinkHelper.m_dwCookie = dwCookie;
				connectionEvents_SinkHelper.m_WillExecuteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)connectionEvents_SinkHelper);
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00004514 File Offset: 0x00003514
		public void remove_WillExecute(global::ADODB.ConnectionEvents_WillExecuteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper;
					for (;;)
					{
						connectionEvents_SinkHelper = (global::ADODB.ConnectionEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (connectionEvents_SinkHelper.m_WillExecuteDelegate != null && ((connectionEvents_SinkHelper.m_WillExecuteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(connectionEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06000406 RID: 1030 RVA: 0x00004614 File Offset: 0x00003614
		public void add_RollbackTransComplete(global::ADODB.ConnectionEvents_RollbackTransCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper = new global::ADODB.ConnectionEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)connectionEvents_SinkHelper, out dwCookie);
				connectionEvents_SinkHelper.m_dwCookie = dwCookie;
				connectionEvents_SinkHelper.m_RollbackTransCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)connectionEvents_SinkHelper);
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000046A4 File Offset: 0x000036A4
		public void remove_RollbackTransComplete(global::ADODB.ConnectionEvents_RollbackTransCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper;
					for (;;)
					{
						connectionEvents_SinkHelper = (global::ADODB.ConnectionEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (connectionEvents_SinkHelper.m_RollbackTransCompleteDelegate != null && ((connectionEvents_SinkHelper.m_RollbackTransCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(connectionEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06000408 RID: 1032 RVA: 0x000047A4 File Offset: 0x000037A4
		public void add_CommitTransComplete(global::ADODB.ConnectionEvents_CommitTransCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper = new global::ADODB.ConnectionEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)connectionEvents_SinkHelper, out dwCookie);
				connectionEvents_SinkHelper.m_dwCookie = dwCookie;
				connectionEvents_SinkHelper.m_CommitTransCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)connectionEvents_SinkHelper);
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00004834 File Offset: 0x00003834
		public void remove_CommitTransComplete(global::ADODB.ConnectionEvents_CommitTransCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper;
					for (;;)
					{
						connectionEvents_SinkHelper = (global::ADODB.ConnectionEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (connectionEvents_SinkHelper.m_CommitTransCompleteDelegate != null && ((connectionEvents_SinkHelper.m_CommitTransCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(connectionEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600040A RID: 1034 RVA: 0x00004934 File Offset: 0x00003934
		public void add_BeginTransComplete(global::ADODB.ConnectionEvents_BeginTransCompleteEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper = new global::ADODB.ConnectionEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)connectionEvents_SinkHelper, out dwCookie);
				connectionEvents_SinkHelper.m_dwCookie = dwCookie;
				connectionEvents_SinkHelper.m_BeginTransCompleteDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)connectionEvents_SinkHelper);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000049C4 File Offset: 0x000039C4
		public void remove_BeginTransComplete(global::ADODB.ConnectionEvents_BeginTransCompleteEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper;
					for (;;)
					{
						connectionEvents_SinkHelper = (global::ADODB.ConnectionEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (connectionEvents_SinkHelper.m_BeginTransCompleteDelegate != null && ((connectionEvents_SinkHelper.m_BeginTransCompleteDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(connectionEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600040C RID: 1036 RVA: 0x00004AC4 File Offset: 0x00003AC4
		public void add_InfoMessage(global::ADODB.ConnectionEvents_InfoMessageEventHandler A_1)
		{
			lock (this)
			{
				if (this.m_ConnectionPoint == null)
				{
					this.Init();
				}
				global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper = new global::ADODB.ConnectionEvents_SinkHelper();
				int dwCookie = 0;
				this.m_ConnectionPoint.Advise((object)connectionEvents_SinkHelper, out dwCookie);
				connectionEvents_SinkHelper.m_dwCookie = dwCookie;
				connectionEvents_SinkHelper.m_InfoMessageDelegate = A_1;
				this.m_aEventSinkHelpers.Add((object)connectionEvents_SinkHelper);
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00004B54 File Offset: 0x00003B54
		public void remove_InfoMessage(global::ADODB.ConnectionEvents_InfoMessageEventHandler A_1)
		{
			lock (this)
			{
				int count = this.m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 < count)
				{
					global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper;
					for (;;)
					{
						connectionEvents_SinkHelper = (global::ADODB.ConnectionEvents_SinkHelper)this.m_aEventSinkHelpers[num];
						if (connectionEvents_SinkHelper.m_InfoMessageDelegate != null && ((connectionEvents_SinkHelper.m_InfoMessageDelegate.Equals((object)A_1) ? 1 : 0) & 255) != 0)
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
					this.m_ConnectionPoint.Unadvise(connectionEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x0600040E RID: 1038 RVA: 0x00004C54 File Offset: 0x00003C54
		public ConnectionEvents_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (global::System.Runtime.InteropServices.UCOMIConnectionPointContainer)A_1;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00004C7C File Offset: 0x00003C7C
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
								global::ADODB.ConnectionEvents_SinkHelper connectionEvents_SinkHelper = (global::ADODB.ConnectionEvents_SinkHelper)this.m_aEventSinkHelpers[num];
								this.m_ConnectionPoint.Unadvise(connectionEvents_SinkHelper.m_dwCookie);
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

		// Token: 0x06000410 RID: 1040 RVA: 0x00004D40 File Offset: 0x00003D40
		public void Dispose()
		{
			this.Finalize();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040001F6 RID: 502
		private global::System.Runtime.InteropServices.UCOMIConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x040001F7 RID: 503
		private global::System.Collections.ArrayList m_aEventSinkHelpers;

		// Token: 0x040001F8 RID: 504
		private global::System.Runtime.InteropServices.UCOMIConnectionPoint m_ConnectionPoint;
	}
}
