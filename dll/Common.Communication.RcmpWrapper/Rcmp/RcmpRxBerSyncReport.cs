using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000055 RID: 85
	public class RcmpRxBerSyncReport : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00006194 File Offset: 0x00004394
		public RcmpRxBerSyncReport(byte? slot)
		{
			base.Opcode = 23;
			this.m_Slot = slot;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000061AB File Offset: 0x000043AB
		private byte[] Report
		{
			get
			{
				return this.m_Report;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000061B3 File Offset: 0x000043B3
		private byte? Slot
		{
			get
			{
				return this.m_Slot;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000061BC File Offset: 0x000043BC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_Slot != null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_Slot.Value
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006224 File Offset: 0x00004424
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				return;
			}
			if (replyBuffer.Length >= offset + length)
			{
				this.m_Report = new byte[length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize];
				global::System.Buffer.BlockCopy(replyBuffer, 3, this.m_Report, 0, this.m_Report.Length);
				return;
			}
			throw new global::System.ArgumentOutOfRangeException("length", "Incorrect length or offset value (offset + length) > buffer.Length");
		}

		// Token: 0x040001AA RID: 426
		private byte[] m_Report;

		// Token: 0x040001AB RID: 427
		private byte? m_Slot;
	}
}
