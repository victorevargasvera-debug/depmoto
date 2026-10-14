using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000029 RID: 41
	public class RcmpRemoteConnect : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000063 RID: 99 RVA: 0x000039F9 File Offset: 0x00001BF9
		public RcmpRemoteConnect(ushort deviceID)
		{
			base.Opcode = 36;
			this.deviceID = deviceID;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003A10 File Offset: 0x00001C10
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.deviceID
			});
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003A48 File Offset: 0x00001C48
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
		}

		// Token: 0x040000B5 RID: 181
		private ushort deviceID;
	}
}
