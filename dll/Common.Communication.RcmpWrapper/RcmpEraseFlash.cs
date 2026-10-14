using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200003D RID: 61
	public class RcmpEraseFlash : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00004DA8 File Offset: 0x00002FA8
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.startAddress,
				this.endAddress
			});
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004DF0 File Offset: 0x00002FF0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (length > global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.uintObj,
					global::Motorola.Common.Communication.RcmpCommon.uintObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.startAddress = (uint)array[0];
				this.endAddress = (uint)array[1];
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00004E67 File Offset: 0x00003067
		public int MaxMessageSize
		{
			get
			{
				return 11;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004E6B File Offset: 0x0000306B
		public RcmpEraseFlash(uint startAddress, uint endAddress)
		{
			base.Opcode = 515;
			this.startAddress = startAddress;
			this.endAddress = endAddress;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00004E8C File Offset: 0x0000308C
		private uint EndAddress
		{
			get
			{
				return this.endAddress;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00004E94 File Offset: 0x00003094
		private uint StartAddress
		{
			get
			{
				return this.startAddress;
			}
		}

		// Token: 0x0400011E RID: 286
		private uint endAddress;

		// Token: 0x0400011F RID: 287
		private uint startAddress;
	}
}
