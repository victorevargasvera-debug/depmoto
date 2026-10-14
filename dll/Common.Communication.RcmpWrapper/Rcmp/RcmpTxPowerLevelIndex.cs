using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200005B RID: 91
	public class RcmpTxPowerLevelIndex : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000147 RID: 327 RVA: 0x0000670C File Offset: 0x0000490C
		public RcmpTxPowerLevelIndex(byte level)
		{
			base.Opcode = 6;
			this.m_Level = level;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00006724 File Offset: 0x00004924
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Level
			});
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000675C File Offset: 0x0000495C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x040001B8 RID: 440
		private byte m_Level;
	}
}
