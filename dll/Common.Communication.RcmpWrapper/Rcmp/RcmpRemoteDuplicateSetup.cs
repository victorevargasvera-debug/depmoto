using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200002C RID: 44
	public class RcmpRemoteDuplicateSetup : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00003ABA File Offset: 0x00001CBA
		public RcmpRemoteDuplicateSetup(global::Motorola.Common.Communication.Rcmp.RemoteDuplicateFunctionType function)
		{
			base.Opcode = 519;
			this.function = (byte)function;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.function
			});
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003B0C File Offset: 0x00001D0C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x040000BA RID: 186
		private byte function;
	}
}
