using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000020 RID: 32
	public class RcmpBootWriteCommit : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003324 File Offset: 0x00001524
		public byte Status
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000332C File Offset: 0x0000152C
		public RcmpBootWriteCommit(global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType function, uint[] ramAddress, uint[] flashAddress, uint[] payloadSize)
		{
			base.Opcode = 518;
			this.function = (byte)function;
			if (function != global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType.QueryStatus)
			{
				if (ramAddress.Length != flashAddress.Length && ramAddress.Length != payloadSize.Length)
				{
					throw new global::System.ArgumentException("Incorrect Size");
				}
				int num = ramAddress.Length * 4 * 3;
				this.dataBlocks = new byte[num];
				this.numOfDataBlocks = (byte)ramAddress.Length;
				int num2 = 0;
				for (int i = 0; i < ramAddress.Length; i++)
				{
					this.dataBlocks[num2++] = (byte)(ramAddress[i] >> 24 & 255U);
					this.dataBlocks[num2++] = (byte)(ramAddress[i] >> 16 & 255U);
					this.dataBlocks[num2++] = (byte)(ramAddress[i] >> 8 & 255U);
					this.dataBlocks[num2++] = (byte)(ramAddress[i] & 255U);
					this.dataBlocks[num2++] = (byte)(flashAddress[i] >> 24 & 255U);
					this.dataBlocks[num2++] = (byte)(flashAddress[i] >> 16 & 255U);
					this.dataBlocks[num2++] = (byte)(flashAddress[i] >> 8 & 255U);
					this.dataBlocks[num2++] = (byte)(flashAddress[i] & 255U);
					this.dataBlocks[num2++] = (byte)(payloadSize[i] >> 24 & 255U);
					this.dataBlocks[num2++] = (byte)(payloadSize[i] >> 16 & 255U);
					this.dataBlocks[num2++] = (byte)(payloadSize[i] >> 8 & 255U);
					this.dataBlocks[num2++] = (byte)(payloadSize[i] & 255U);
				}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000034CC File Offset: 0x000016CC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.function == 1)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.function
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.function,
				this.numOfDataBlocks,
				this.dataBlocks
			});
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003550 File Offset: 0x00001750
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.status = (byte)array[1];
			}
		}

		// Token: 0x0400009B RID: 155
		private byte function;

		// Token: 0x0400009C RID: 156
		private byte numOfDataBlocks;

		// Token: 0x0400009D RID: 157
		private byte[] dataBlocks;

		// Token: 0x0400009E RID: 158
		private byte status;
	}
}
