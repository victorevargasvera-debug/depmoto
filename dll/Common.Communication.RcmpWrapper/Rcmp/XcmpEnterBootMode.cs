using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200006E RID: 110
	public class XcmpEnterBootMode : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00007C49 File Offset: 0x00005E49
		public XcmpEnterBootMode()
		{
			base.Opcode = 512;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00007C5C File Offset: 0x00005E5C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00007C86 File Offset: 0x00005E86
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}
	}
}
