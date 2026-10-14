using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000040 RID: 64
	public class RcmpIshUnlockPartition : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x00004F67 File Offset: 0x00003167
		public RcmpIshUnlockPartition(byte partition)
		{
			base.Opcode = 264;
			this.m_Partition = partition;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004F84 File Offset: 0x00003184
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Partition
			});
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004FBC File Offset: 0x000031BC
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x04000125 RID: 293
		private byte m_Partition;
	}
}
