using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000061 RID: 97
	public class RcmpWriteMemory : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x06000166 RID: 358 RVA: 0x00006C70 File Offset: 0x00004E70
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.address,
				this.byteCount,
				this.byteData
			});
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00006CC0 File Offset: 0x00004EC0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (length > global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.uintObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.address = (uint)array[0];
				this.byteCount = (ushort)array[1];
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00006D37 File Offset: 0x00004F37
		public int MaxMessageSize
		{
			get
			{
				return 9;
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00006D3C File Offset: 0x00004F3C
		public RcmpWriteMemory(uint address, ushort byteCount, byte[] byteData)
		{
			base.Opcode = 514;
			if (byteData == null)
			{
				throw new global::System.ArgumentNullException("byteData");
			}
			if ((int)byteCount != byteData.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("byteCount", "data size is not equal to byteCount");
			}
			this.address = address;
			this.byteCount = byteCount;
			this.byteData = byteData;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00006D93 File Offset: 0x00004F93
		private uint Address
		{
			get
			{
				return this.address;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00006D9B File Offset: 0x00004F9B
		private ushort ByteCount
		{
			get
			{
				return this.byteCount;
			}
		}

		// Token: 0x040001E9 RID: 489
		private ushort byteCount;

		// Token: 0x040001EA RID: 490
		private uint address;

		// Token: 0x040001EB RID: 491
		private byte[] byteData;
	}
}
