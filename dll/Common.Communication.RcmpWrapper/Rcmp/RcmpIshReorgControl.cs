using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200003E RID: 62
	public class RcmpIshReorgControl : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00004E9C File Offset: 0x0000309C
		private byte Action
		{
			get
			{
				return this.m_Action;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00004EA4 File Offset: 0x000030A4
		private byte LogicalPartition
		{
			get
			{
				return this.m_Partition;
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004EAC File Offset: 0x000030AC
		public RcmpIshReorgControl(byte partition, byte action)
		{
			base.Opcode = 263;
			this.m_Partition = partition;
			this.m_Action = action;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004ED0 File Offset: 0x000030D0
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Partition,
				this.m_Action
			});
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004F18 File Offset: 0x00003118
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (length > global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize)
			{
				this.m_Partition = replyBuffer[offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize];
				this.m_Action = replyBuffer[offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 1];
			}
		}

		// Token: 0x04000120 RID: 288
		private byte m_Action;

		// Token: 0x04000121 RID: 289
		private byte m_Partition;

		// Token: 0x0200003F RID: 63
		public enum Actions
		{
			// Token: 0x04000123 RID: 291
			Deep,
			// Token: 0x04000124 RID: 292
			Normal
		}
	}
}
