using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200003C RID: 60
	public class RcmpEnterTestMode : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x00004D4F File Offset: 0x00002F4F
		public RcmpEnterTestMode()
		{
			base.Opcode = 12;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004D60 File Offset: 0x00002F60
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004D8A File Offset: 0x00002F8A
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}
	}
}
