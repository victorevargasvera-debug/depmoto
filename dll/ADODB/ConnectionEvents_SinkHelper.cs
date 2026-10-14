using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200007F RID: 127
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public sealed class ConnectionEvents_SinkHelper : global::ADODB.ConnectionEvents
	{
		// Token: 0x060003F1 RID: 1009 RVA: 0x00003A8C File Offset: 0x00002A8C
		public void Disconnect(ref global::ADODB.EventStatusEnum A_1, global::ADODB.Connection A_2)
		{
			if (this.m_DisconnectDelegate != null)
			{
				this.m_DisconnectDelegate(ref A_1, A_2);
				return;
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00003AC0 File Offset: 0x00002AC0
		public void ConnectComplete(global::ADODB.Error A_1, ref global::ADODB.EventStatusEnum A_2, global::ADODB.Connection A_3)
		{
			if (this.m_ConnectCompleteDelegate != null)
			{
				this.m_ConnectCompleteDelegate(A_1, ref A_2, A_3);
				return;
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00003AF8 File Offset: 0x00002AF8
		public void WillConnect(ref string A_1, ref string A_2, ref string A_3, ref int A_4, ref global::ADODB.EventStatusEnum A_5, global::ADODB.Connection A_6)
		{
			if (this.m_WillConnectDelegate != null)
			{
				this.m_WillConnectDelegate(ref A_1, ref A_2, ref A_3, ref A_4, ref A_5, A_6);
				return;
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00003B3C File Offset: 0x00002B3C
		public void ExecuteComplete(int A_1, global::ADODB.Error A_2, ref global::ADODB.EventStatusEnum A_3, global::ADODB.Command A_4, global::ADODB.Recordset A_5, global::ADODB.Connection A_6)
		{
			if (this.m_ExecuteCompleteDelegate != null)
			{
				this.m_ExecuteCompleteDelegate(A_1, A_2, ref A_3, A_4, A_5, A_6);
				return;
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00003B80 File Offset: 0x00002B80
		public void WillExecute(ref string A_1, ref global::ADODB.CursorTypeEnum A_2, ref global::ADODB.LockTypeEnum A_3, ref int A_4, ref global::ADODB.EventStatusEnum A_5, global::ADODB.Command A_6, global::ADODB.Recordset A_7, global::ADODB.Connection A_8)
		{
			if (this.m_WillExecuteDelegate != null)
			{
				this.m_WillExecuteDelegate(ref A_1, ref A_2, ref A_3, ref A_4, ref A_5, A_6, A_7, A_8);
				return;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00003BCC File Offset: 0x00002BCC
		public void RollbackTransComplete(global::ADODB.Error A_1, ref global::ADODB.EventStatusEnum A_2, global::ADODB.Connection A_3)
		{
			if (this.m_RollbackTransCompleteDelegate != null)
			{
				this.m_RollbackTransCompleteDelegate(A_1, ref A_2, A_3);
				return;
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003C04 File Offset: 0x00002C04
		public void CommitTransComplete(global::ADODB.Error A_1, ref global::ADODB.EventStatusEnum A_2, global::ADODB.Connection A_3)
		{
			if (this.m_CommitTransCompleteDelegate != null)
			{
				this.m_CommitTransCompleteDelegate(A_1, ref A_2, A_3);
				return;
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00003C3C File Offset: 0x00002C3C
		public void BeginTransComplete(int A_1, global::ADODB.Error A_2, ref global::ADODB.EventStatusEnum A_3, global::ADODB.Connection A_4)
		{
			if (this.m_BeginTransCompleteDelegate != null)
			{
				this.m_BeginTransCompleteDelegate(A_1, A_2, ref A_3, A_4);
				return;
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00003C78 File Offset: 0x00002C78
		public void InfoMessage(global::ADODB.Error A_1, ref global::ADODB.EventStatusEnum A_2, global::ADODB.Connection A_3)
		{
			if (this.m_InfoMessageDelegate != null)
			{
				this.m_InfoMessageDelegate(A_1, ref A_2, A_3);
				return;
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00003CB0 File Offset: 0x00002CB0
		internal ConnectionEvents_SinkHelper()
		{
			this.m_dwCookie = 0;
			this.m_DisconnectDelegate = null;
			this.m_ConnectCompleteDelegate = null;
			this.m_WillConnectDelegate = null;
			this.m_ExecuteCompleteDelegate = null;
			this.m_WillExecuteDelegate = null;
			this.m_RollbackTransCompleteDelegate = null;
			this.m_CommitTransCompleteDelegate = null;
			this.m_BeginTransCompleteDelegate = null;
			this.m_InfoMessageDelegate = null;
		}

		// Token: 0x040001EC RID: 492
		public global::ADODB.ConnectionEvents_DisconnectEventHandler m_DisconnectDelegate;

		// Token: 0x040001ED RID: 493
		public global::ADODB.ConnectionEvents_ConnectCompleteEventHandler m_ConnectCompleteDelegate;

		// Token: 0x040001EE RID: 494
		public global::ADODB.ConnectionEvents_WillConnectEventHandler m_WillConnectDelegate;

		// Token: 0x040001EF RID: 495
		public global::ADODB.ConnectionEvents_ExecuteCompleteEventHandler m_ExecuteCompleteDelegate;

		// Token: 0x040001F0 RID: 496
		public global::ADODB.ConnectionEvents_WillExecuteEventHandler m_WillExecuteDelegate;

		// Token: 0x040001F1 RID: 497
		public global::ADODB.ConnectionEvents_RollbackTransCompleteEventHandler m_RollbackTransCompleteDelegate;

		// Token: 0x040001F2 RID: 498
		public global::ADODB.ConnectionEvents_CommitTransCompleteEventHandler m_CommitTransCompleteDelegate;

		// Token: 0x040001F3 RID: 499
		public global::ADODB.ConnectionEvents_BeginTransCompleteEventHandler m_BeginTransCompleteDelegate;

		// Token: 0x040001F4 RID: 500
		public global::ADODB.ConnectionEvents_InfoMessageEventHandler m_InfoMessageDelegate;

		// Token: 0x040001F5 RID: 501
		public int m_dwCookie;
	}
}
