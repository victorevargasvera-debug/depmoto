using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000021 RID: 33
	public class RcmpDiscoverRemoteDevice : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000035B9 File Offset: 0x000017B9
		public RcmpDiscoverRemoteDevice()
		{
			base.Opcode = 35;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000035C9 File Offset: 0x000017C9
		public ushort BusID
		{
			get
			{
				return this.busID;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000035D4 File Offset: 0x000017D4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003600 File Offset: 0x00001800
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.ushortObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.busID = (ushort)array[0];
			}
		}

		// Token: 0x0400009F RID: 159
		private ushort busID;
	}
}
