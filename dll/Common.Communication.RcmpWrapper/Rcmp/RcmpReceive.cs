using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200004E RID: 78
	public class RcmpReceive : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00005EAB File Offset: 0x000040AB
		public RcmpReceive(byte speakerControl)
		{
			base.Opcode = 5;
			this.m_SpeakerControl = speakerControl;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005EC4 File Offset: 0x000040C4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_SpeakerControl
			});
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005EFC File Offset: 0x000040FC
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x04000176 RID: 374
		private byte m_SpeakerControl;
	}
}
