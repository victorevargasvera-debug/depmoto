using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200001E RID: 30
	public class RcmpBootJumpExecution : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000049 RID: 73 RVA: 0x000032B3 File Offset: 0x000014B3
		public RcmpBootJumpExecution(uint address)
		{
			base.Opcode = 516;
			this.address = address;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000032D0 File Offset: 0x000014D0
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.address
			});
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003308 File Offset: 0x00001508
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x04000094 RID: 148
		private uint address;
	}
}
