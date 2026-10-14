using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200005C RID: 92
	public class RcmpUnlockSecurity : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00006778 File Offset: 0x00004978
		public RcmpUnlockSecurity(byte[] radioKey)
		{
			if (radioKey == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			base.Opcode = 769;
			this.m_radioKey = radioKey;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000679C File Offset: 0x0000499C
		private byte[] RadioKey
		{
			get
			{
				return this.m_radioKey;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000067A4 File Offset: 0x000049A4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_radioKey == null)
			{
				throw new global::System.ArgumentNullException("RadioKey");
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_radioKey
			});
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000067EA File Offset: 0x000049EA
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | 32768);
		}

		// Token: 0x040001B9 RID: 441
		private byte[] m_radioKey;
	}
}
