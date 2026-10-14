using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000077 RID: 119
	public class XcmpTransferData : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00008656 File Offset: 0x00006856
		// (set) Token: 0x060001BA RID: 442 RVA: 0x0000865E File Offset: 0x0000685E
		public byte[] Data
		{
			get
			{
				return this.m_xferData;
			}
			private set
			{
				this.m_xferData = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00008667 File Offset: 0x00006867
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0000866F File Offset: 0x0000686F
		public ushort Length
		{
			get
			{
				return this.m_xferDataLength;
			}
			private set
			{
				this.m_xferDataLength = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00008678 File Offset: 0x00006878
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00008680 File Offset: 0x00006880
		private ushort SeqNum
		{
			get
			{
				return this.m_SeqNum;
			}
			set
			{
				this.m_SeqNum = value;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00008689 File Offset: 0x00006889
		public XcmpTransferData(ushort Sequence, byte Type, ushort Length, byte[] Data)
		{
			base.Opcode = 1094;
			this.m_SeqNum = Sequence;
			this.m_dataType = Type;
			this.m_xferDataLength = Length;
			this.m_xferData = Data;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x000086B9 File Offset: 0x000068B9
		public static int RequestHeaderLength
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000086BC File Offset: 0x000068BC
		public static int ReplyHeaderLength
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000086C0 File Offset: 0x000068C0
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_xferData == null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_dataType,
					this.m_SeqNum,
					this.m_xferDataLength
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_dataType,
				this.m_SeqNum,
				this.m_xferDataLength,
				this.m_xferData
			});
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00008770 File Offset: 0x00006970
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if ((base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success || base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.TransferComplete) && length >= global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 4)
			{
				this.m_dataType = replyBuffer[offset + 3];
				this.m_SeqNum = (ushort)((int)replyBuffer[offset + 5] | (int)replyBuffer[offset + 4] << 8);
				this.m_xferDataLength = (ushort)((int)replyBuffer[offset + 7] | (int)replyBuffer[offset + 6] << 8);
				if (this.m_xferData == null)
				{
					this.m_xferData = new byte[(int)this.m_xferDataLength];
				}
				if (length - 8 >= (int)this.m_xferDataLength)
				{
					if (this.m_xferData.Length < length - 8)
					{
						this.m_xferData = new byte[(int)this.m_xferDataLength];
					}
					global::System.Array.Clear(this.m_xferData, 0, this.m_xferData.Length);
					global::System.Array.Copy(replyBuffer, offset + 8, this.m_xferData, 0, (int)this.m_xferDataLength);
				}
			}
		}

		// Token: 0x04000263 RID: 611
		private byte m_dataType;

		// Token: 0x04000264 RID: 612
		private ushort m_SeqNum;

		// Token: 0x04000265 RID: 613
		private ushort m_xferDataLength;

		// Token: 0x04000266 RID: 614
		private byte[] m_xferData;

		// Token: 0x02000078 RID: 120
		public enum DataType : byte
		{
			// Token: 0x04000268 RID: 616
			None,
			// Token: 0x04000269 RID: 617
			Nand,
			// Token: 0x0400026A RID: 618
			FTL,
			// Token: 0x0400026B RID: 619
			File,
			// Token: 0x0400026C RID: 620
			Fxp,
			// Token: 0x0400026D RID: 621
			CompressFile
		}
	}
}
