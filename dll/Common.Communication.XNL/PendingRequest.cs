using System;
using System.Threading;

namespace Motorola.Common.Communication
{
	// Token: 0x02000002 RID: 2
	internal class PendingRequest : global::System.IDisposable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		public global::System.Threading.AutoResetEvent RequestAckWaitHandle { get; private set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020E1 File Offset: 0x000002E1
		// (set) Token: 0x06000004 RID: 4 RVA: 0x000020E9 File Offset: 0x000002E9
		public global::System.Threading.AutoResetEvent ResponseWaitHandle { get; private set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020F2 File Offset: 0x000002F2
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000020FA File Offset: 0x000002FA
		public global::Motorola.Common.Communication.XnlPacket RequestPacket { get; private set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002103 File Offset: 0x00000303
		// (set) Token: 0x06000008 RID: 8 RVA: 0x0000210B File Offset: 0x0000030B
		public global::Motorola.Common.Communication.XnlPacket RequestAckPacket { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002114 File Offset: 0x00000314
		// (set) Token: 0x0600000A RID: 10 RVA: 0x0000211C File Offset: 0x0000031C
		public global::Motorola.Common.Communication.XnlPacket ResponsePacket { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002125 File Offset: 0x00000325
		public ushort TransactionID
		{
			get
			{
				return this.RequestPacket.transactionID;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002132 File Offset: 0x00000332
		public PendingRequest(global::Motorola.Common.Communication.XnlPacket requestPacket)
		{
			this.RequestAckWaitHandle = new global::System.Threading.AutoResetEvent(false);
			this.ResponseWaitHandle = new global::System.Threading.AutoResetEvent(false);
			this.RequestAckPacket = null;
			this.ResponsePacket = null;
			this.RequestPacket = requestPacket;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002168 File Offset: 0x00000368
		~PendingRequest()
		{
			this.Dispose(false);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002198 File Offset: 0x00000398
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021A7 File Offset: 0x000003A7
		private void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					this.RequestAckWaitHandle.Dispose();
					this.ResponseWaitHandle.Dispose();
				}
				this.disposed = true;
			}
		}

		// Token: 0x04000001 RID: 1
		private bool disposed;
	}
}
