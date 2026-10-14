using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000045 RID: 69
	public class RcmpRadioStatus : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000DA RID: 218 RVA: 0x0000509A File Offset: 0x0000329A
		public RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition condition)
		{
			base.Opcode = 14;
			this.Condition = condition;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000050B1 File Offset: 0x000032B1
		// (set) Token: 0x060000DC RID: 220 RVA: 0x000050B9 File Offset: 0x000032B9
		private global::Motorola.Common.Communication.Rcmp.RadioStatusCondition Condition { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000050C4 File Offset: 0x000032C4
		public byte[] Status
		{
			get
			{
				if (this.m_Status == null)
				{
					return null;
				}
				byte[] array = new byte[this.m_Status.Length];
				global::System.Array.Copy(this.m_Status, array, array.Length);
				return array;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000050FC File Offset: 0x000032FC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.Condition
			});
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005134 File Offset: 0x00003334
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.Condition = (global::Motorola.Common.Communication.Rcmp.RadioStatusCondition)array[0];
				this.m_Status = (byte[])array[1];
			}
		}

		// Token: 0x0400014D RID: 333
		private byte[] m_Status;
	}
}
