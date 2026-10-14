using System;
using System.Globalization;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000060 RID: 96
	public class RcmpWriteIshItem : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0000698F File Offset: 0x00004B8F
		private byte LogicalPartition
		{
			get
			{
				return this.m_LogicalPartition;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00006997 File Offset: 0x00004B97
		private ushort IshType
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000699F File Offset: 0x00004B9F
		private ushort IshID
		{
			get
			{
				return this.m_ID;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000069A7 File Offset: 0x00004BA7
		private ushort ItemSize
		{
			get
			{
				return this.m_ItemSize;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000069AF File Offset: 0x00004BAF
		private ushort NumberOfBytes
		{
			get
			{
				return this.m_NumberOfBytes;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000069B7 File Offset: 0x00004BB7
		private ushort Offset
		{
			get
			{
				return this.m_Offset;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000069BF File Offset: 0x00004BBF
		private byte[] Data
		{
			get
			{
				return this.m_Data;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000069C7 File Offset: 0x00004BC7
		private bool WriteToDual
		{
			get
			{
				return this.m_writeToDual;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000069D0 File Offset: 0x00004BD0
		public RcmpWriteIshItem(byte partition, ushort type, ushort id, ushort numberOfBytes, ushort offset, ushort itemSize, byte[] data, bool writeToDual)
		{
			base.Opcode = 257;
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data");
			}
			if ((int)numberOfBytes != data.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("numberOfBytes", "data size is not equal to numberOfBytes");
			}
			this.m_LogicalPartition = partition;
			this.m_writeToDual = writeToDual;
			this.m_Type = type;
			this.m_ID = id;
			this.m_NumberOfBytes = numberOfBytes;
			this.m_Offset = offset;
			this.m_ItemSize = itemSize;
			this.m_Data = data;
			if (this.m_writeToDual)
			{
				this.m_LogicalPartition += 1;
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00006A6C File Offset: 0x00004C6C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_LogicalPartition,
				this.m_Type,
				this.m_ID,
				this.m_NumberOfBytes,
				this.m_Offset,
				this.m_ItemSize,
				this.m_Data
			});
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00006AF4 File Offset: 0x00004CF4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (length > global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_LogicalPartition = (byte)array[0];
				this.m_Type = (ushort)array[1];
				this.m_ID = (ushort)array[2];
				this.m_NumberOfBytes = (ushort)array[3];
				this.m_Offset = (ushort)array[4];
				this.m_ItemSize = (ushort)array[5];
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00006BC6 File Offset: 0x00004DC6
		public int MaxMessageSize
		{
			get
			{
				return global::Motorola.Common.Communication.Rcmp.RcmpWriteIshItem.HeaderSize + this.m_Data.Length;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00006BD6 File Offset: 0x00004DD6
		public static int HeaderSize
		{
			get
			{
				return 14;
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00006BDC File Offset: 0x00004DDC
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}(Partition={1},Type={2},ID={3},NumberOfBytes={4},Offset={5},ItemSize={6},ReplyResult={7})", new object[]
			{
				base.GetType().Name,
				this.LogicalPartition,
				this.IshType,
				this.IshID,
				this.NumberOfBytes,
				this.Offset,
				this.ItemSize,
				base.ReplyResult
			});
		}

		// Token: 0x040001E1 RID: 481
		private byte m_LogicalPartition;

		// Token: 0x040001E2 RID: 482
		private ushort m_Type;

		// Token: 0x040001E3 RID: 483
		private ushort m_ID;

		// Token: 0x040001E4 RID: 484
		private ushort m_NumberOfBytes;

		// Token: 0x040001E5 RID: 485
		private ushort m_Offset;

		// Token: 0x040001E6 RID: 486
		private ushort m_ItemSize;

		// Token: 0x040001E7 RID: 487
		private byte[] m_Data;

		// Token: 0x040001E8 RID: 488
		private bool m_writeToDual;
	}
}
