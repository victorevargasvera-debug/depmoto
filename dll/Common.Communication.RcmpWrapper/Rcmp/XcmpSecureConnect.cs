using System;
using System.Net;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000075 RID: 117
	public class XcmpSecureConnect : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000812C File Offset: 0x0000632C
		public global::System.Net.IPAddress RadioIP
		{
			get
			{
				if (this.operation == global::Motorola.Common.Communication.Rcmp.FuctionOperation.ReadIpandPort && this.tlsOrIpPortData != null && this.tlsOrIpPortData.Length == 6)
				{
					byte[] array = new byte[4];
					global::System.Array.Copy(this.tlsOrIpPortData, array, 4);
					return new global::System.Net.IPAddress(array);
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00008178 File Offset: 0x00006378
		public ushort RadioPort
		{
			get
			{
				if (this.operation == global::Motorola.Common.Communication.Rcmp.FuctionOperation.ReadIpandPort && this.tlsOrIpPortData != null && this.tlsOrIpPortData.Length == 6)
				{
					byte[] array = new byte[4];
					global::System.Array.Copy(this.tlsOrIpPortData, 4, array, 0, 2);
					return global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUInt16(array, 0);
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000081C4 File Offset: 0x000063C4
		public XcmpSecureConnect(global::Motorola.Common.Communication.Rcmp.FuctionOperation operationType)
		{
			base.Opcode = 61;
			this.operation = operationType;
			this.dataLength = 0;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000081E4 File Offset: 0x000063E4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.operation,
				0
			});
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00008228 File Offset: 0x00006428
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | 32768);
			offset += global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize;
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				this.operation = (global::Motorola.Common.Communication.Rcmp.FuctionOperation)replyBuffer[offset];
				offset++;
				this.dataLength = replyBuffer[offset];
				offset++;
				this.tlsOrIpPortData = new byte[(int)this.dataLength];
				global::System.Buffer.BlockCopy(replyBuffer, offset, this.tlsOrIpPortData, 0, this.tlsOrIpPortData.Length);
			}
		}

		// Token: 0x0400025D RID: 605
		private global::Motorola.Common.Communication.Rcmp.FuctionOperation operation;

		// Token: 0x0400025E RID: 606
		private byte dataLength;

		// Token: 0x0400025F RID: 607
		private byte[] tlsOrIpPortData;
	}
}
