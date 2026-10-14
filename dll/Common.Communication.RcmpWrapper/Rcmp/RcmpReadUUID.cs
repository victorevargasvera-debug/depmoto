using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200004A RID: 74
	public class RcmpReadUUID : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00005A2C File Offset: 0x00003C2C
		public byte[] UUID
		{
			get
			{
				if (this.m_UUID != null)
				{
					byte[] array = new byte[this.m_UUID.Length];
					global::System.Buffer.BlockCopy(this.m_UUID, 0, array, 0, this.m_UUID.Length);
					return array;
				}
				return null;
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00005A68 File Offset: 0x00003C68
		public RcmpReadUUID()
		{
			base.Opcode = 18;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00005A78 File Offset: 0x00003C78
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00005AA4 File Offset: 0x00003CA4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success && length == global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 16)
			{
				object[] array = new object[]
				{
					new byte[16]
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_UUID = (byte[])array[0];
			}
		}

		// Token: 0x04000162 RID: 354
		private byte[] m_UUID;
	}
}
