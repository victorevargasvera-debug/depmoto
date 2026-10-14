using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200002A RID: 42
	public class RcmpRemoteDisconnect : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00003A64 File Offset: 0x00001C64
		public RcmpRemoteDisconnect()
		{
			base.Opcode = 37;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003A74 File Offset: 0x00001C74
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003A9E File Offset: 0x00001C9E
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}
	}
}
