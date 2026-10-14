using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000052 RID: 82
	public class RcmpReceiveConfiguration : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00006059 File Offset: 0x00004259
		public RcmpReceiveConfiguration(byte source, params byte[] type)
		{
			base.Opcode = 3;
			this.m_Source = source;
			this.m_Type = type;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006078 File Offset: 0x00004278
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Source,
				this.m_Type
			});
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000060B9 File Offset: 0x000042B9
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag | base.Opcode);
		}

		// Token: 0x04000184 RID: 388
		private byte m_Source;

		// Token: 0x04000185 RID: 389
		private byte[] m_Type;
	}
}
