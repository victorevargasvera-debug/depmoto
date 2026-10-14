using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000054 RID: 84
	public class RcmpRxBerControl : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600012D RID: 301 RVA: 0x000060D5 File Offset: 0x000042D5
		public RcmpRxBerControl(byte operation, byte? frameCount)
		{
			base.Opcode = 22;
			this.m_Operation = operation;
			this.m_FrameCount = frameCount;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000060F4 File Offset: 0x000042F4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_FrameCount != null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_Operation,
					this.m_FrameCount.Value
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Operation
			});
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006178 File Offset: 0x00004378
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x040001A8 RID: 424
		private byte m_Operation;

		// Token: 0x040001A9 RID: 425
		private byte? m_FrameCount;
	}
}
