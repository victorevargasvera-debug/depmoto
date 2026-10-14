using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000041 RID: 65
	public class RcmpPreemphasisDeemphasis : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x00004FD8 File Offset: 0x000031D8
		public RcmpPreemphasisDeemphasis(byte control)
		{
			base.Opcode = 7;
			this.m_Control = control;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004FF0 File Offset: 0x000031F0
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Control
			});
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005028 File Offset: 0x00003228
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x04000126 RID: 294
		private byte m_Control;
	}
}
