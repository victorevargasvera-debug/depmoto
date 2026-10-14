using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000056 RID: 86
	public class RcmpRxFrequency : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00006294 File Offset: 0x00004494
		public RcmpRxFrequency(uint frequency, byte bandwidth, byte sif)
		{
			base.Opcode = 10;
			this.m_Frequency = frequency;
			this.m_Bandwidth = bandwidth;
			this.m_SIF = sif;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000062BC File Offset: 0x000044BC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Frequency,
				this.m_Bandwidth,
				this.m_SIF
			});
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006310 File Offset: 0x00004510
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x040001AC RID: 428
		private uint m_Frequency;

		// Token: 0x040001AD RID: 429
		private byte m_Bandwidth;

		// Token: 0x040001AE RID: 430
		private byte m_SIF;
	}
}
