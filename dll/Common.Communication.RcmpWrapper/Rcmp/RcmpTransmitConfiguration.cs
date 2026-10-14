using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000059 RID: 89
	public class RcmpTransmitConfiguration : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000141 RID: 321 RVA: 0x0000658C File Offset: 0x0000478C
		public RcmpTransmitConfiguration(byte source, ushort? code)
		{
			base.Opcode = 2;
			this.m_Source = source;
			this.m_Code = code;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000065AC File Offset: 0x000047AC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			ushort? code = this.m_Code;
			int? num = (code != null) ? new int?((int)code.GetValueOrDefault()) : null;
			if (num == null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_Source
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Source,
				this.m_Code.Value
			});
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006659 File Offset: 0x00004859
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag | base.Opcode);
		}

		// Token: 0x040001B3 RID: 435
		private byte m_Source;

		// Token: 0x040001B4 RID: 436
		private ushort? m_Code;
	}
}
