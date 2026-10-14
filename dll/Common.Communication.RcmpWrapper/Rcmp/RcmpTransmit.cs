using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000058 RID: 88
	public class RcmpTransmit : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600013E RID: 318 RVA: 0x00006521 File Offset: 0x00004721
		public RcmpTransmit(byte microphoneSelection)
		{
			base.Opcode = 4;
			this.m_MicSelection = microphoneSelection;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006538 File Offset: 0x00004738
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_MicSelection
			});
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00006570 File Offset: 0x00004770
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x040001B2 RID: 434
		private byte m_MicSelection;
	}
}
