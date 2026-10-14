using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.IshHandler;

namespace Motorola.Common.Communication
{
	// Token: 0x02000010 RID: 16
	public class AstroOtapRcmpMessageExecutor : global::Motorola.Common.Communication.IshHandler.RcmpMessageExecutor
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00008000 File Offset: 0x00006200
		public ushort Checksum
		{
			get
			{
				return (ushort)this.m_OtapChecksum;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00008009 File Offset: 0x00006209
		public void ResetChecksum()
		{
			this.m_OtapChecksum = 0U;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00008012 File Offset: 0x00006212
		public AstroOtapRcmpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, int inactivityTimeout) : base(commPipe)
		{
			this.OtapReceiveTimeout = inactivityTimeout * 1000;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00008044 File Offset: 0x00006244
		protected override void Execute(int sendLength, global::Motorola.Common.Communication.IMessage rcmpMessage)
		{
			lock (base.sendBuffer.SyncRoot)
			{
				base.CommPipe.SendData(base.sendBuffer, 0, sendLength);
				(rcmpMessage as global::Motorola.Common.Communication.RcmpBaseMessage).CalculateMessageCRC16(ref this.m_OtapChecksum, base.sendBuffer, 0, sendLength);
			}
			lock (this.rcvBuf.SyncRoot)
			{
				int length = base.CommPipe.ReceiveData(this.rcvBuf, 0, this.OtapReceiveTimeout);
				rcmpMessage.DecodeReplyMessage(this.rcvBuf, 0, length);
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Rx: {0}", new object[]
			{
				rcmpMessage.ToString()
			});
		}

		// Token: 0x04000039 RID: 57
		private const uint OtapChecksumIV = 0U;

		// Token: 0x0400003A RID: 58
		private uint m_OtapChecksum;

		// Token: 0x0400003B RID: 59
		private int OtapReceiveTimeout = 180000;

		// Token: 0x0400003C RID: 60
		private byte[] rcvBuf = new byte[65535];
	}
}
