using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200005A RID: 90
	public class RcmpTxFrequency : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000144 RID: 324 RVA: 0x00006675 File Offset: 0x00004875
		public RcmpTxFrequency(uint frequency, byte bandwidth, byte deviation)
		{
			base.Opcode = 11;
			this.m_Frequency = frequency;
			this.m_Bandwidth = bandwidth;
			this.m_Deviation = deviation;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000669C File Offset: 0x0000489C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Frequency,
				this.m_Bandwidth,
				this.m_Deviation
			});
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000066F0 File Offset: 0x000048F0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x040001B5 RID: 437
		private uint m_Frequency;

		// Token: 0x040001B6 RID: 438
		private byte m_Bandwidth;

		// Token: 0x040001B7 RID: 439
		private byte m_Deviation;
	}
}
