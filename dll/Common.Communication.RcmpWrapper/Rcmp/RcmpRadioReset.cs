using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000042 RID: 66
	public class RcmpRadioReset : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00005044 File Offset: 0x00003244
		public RcmpRadioReset()
		{
			base.Opcode = 13;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005054 File Offset: 0x00003254
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000507E File Offset: 0x0000327E
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}
	}
}
