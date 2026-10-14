using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000048 RID: 72
	public class RcmpReadRadioKey : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000056EC File Offset: 0x000038EC
		public byte[] RadioKey
		{
			get
			{
				return this.m_RadioKey;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000056F4 File Offset: 0x000038F4
		private void ClearKey()
		{
			if (this.m_RadioKey != null)
			{
				for (int i = 0; i < this.m_RadioKey.Length; i++)
				{
					this.m_RadioKey[i] = 0;
				}
			}
			this.m_RadioKey = null;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000572C File Offset: 0x0000392C
		public RcmpReadRadioKey()
		{
			base.Opcode = 768;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005740 File Offset: 0x00003940
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000576C File Offset: 0x0000396C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | 32768);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				object[] array = new object[]
				{
					new byte[32]
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_RadioKey = (byte[])array[0];
			}
		}

		// Token: 0x0400015C RID: 348
		private byte[] m_RadioKey;
	}
}
