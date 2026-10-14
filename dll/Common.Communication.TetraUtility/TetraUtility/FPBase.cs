using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200000F RID: 15
	[global::System.Serializable]
	public abstract class FPBase
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00005858 File Offset: 0x00003A58
		public virtual byte[] Data
		{
			get
			{
				if ((long)this._data.Length != (long)((ulong)this._size))
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Debug("FP size and data not match! size:{0},data size:{1},description:{2}", new object[]
					{
						this._size,
						this._data,
						this.Description
					});
					byte[] data = this._data;
					this._data = new byte[this._size];
					global::System.Array.Copy(data, 0, this._data, 0, global::System.Math.Min(data.Length, this._data.Length));
				}
				return this._data;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000058F0 File Offset: 0x00003AF0
		public global::Motorola.Common.Communication.TetraUtility.ByteOrder ByteOrder
		{
			get
			{
				return this._byteOrder;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000058F8 File Offset: 0x00003AF8
		public uint HeaderSize
		{
			get
			{
				return 16U;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000058FC File Offset: 0x00003AFC
		public uint RevisionNumber
		{
			get
			{
				return (uint)this._header.pack_revision_number;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00005909 File Offset: 0x00003B09
		public uint SubRevisionNumber
		{
			get
			{
				return (uint)this._header.pack_sub_revision_num;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00005916 File Offset: 0x00003B16
		public uint ReleaseNumber
		{
			get
			{
				return (uint)this._header.pack_release_number;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00005923 File Offset: 0x00003B23
		public uint HeaderVersion
		{
			get
			{
				return (uint)this._header.header_version;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00005930 File Offset: 0x00003B30
		public uint ProductPlatform
		{
			get
			{
				return (uint)this._header.pack_product_platform;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000593D File Offset: 0x00003B3D
		public uint PackType
		{
			get
			{
				return (uint)this._header.pack_type;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000594A File Offset: 0x00003B4A
		public uint PackSize
		{
			get
			{
				return this._header.pack_size;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005957 File Offset: 0x00003B57
		protected FPBase(byte[] fpData, uint fpSize, global::Motorola.Common.Communication.TetraUtility.ByteOrder order)
		{
			this._data = fpData;
			this._size = fpSize;
			this._byteOrder = order;
			this.HeaderByteReverse();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000598D File Offset: 0x00003B8D
		public bool IsChecksumCorrect()
		{
			return this._header.checksum == this.ComputePackChecksum(this._data);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000059AC File Offset: 0x00003BAC
		public bool UpdateImageChecksum(byte[] rawData)
		{
			if (rawData == null || rawData.Length == 0)
			{
				return false;
			}
			uint value = this.ComputePackChecksum(rawData);
			if (this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
			{
				global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref value);
			}
			byte[] bytes = global::System.BitConverter.GetBytes(value);
			global::System.Array.Copy(bytes, rawData, bytes.Length);
			return true;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000059F0 File Offset: 0x00003BF0
		public bool IsSameBuild(global::Motorola.Common.Communication.TetraUtility.FPBase pack)
		{
			return pack != null && this._header != null && (this._header.pack_release_number == pack._header.pack_release_number && this._header.pack_product_platform == pack._header.pack_product_platform && this._header.header_version == pack._header.header_version && this._header.pack_revision_number == pack._header.pack_revision_number && this._header.pack_sub_revision_num == pack._header.pack_sub_revision_num);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005A85 File Offset: 0x00003C85
		public static void HeaderByteReverse(global::Motorola.Common.Communication.CommonUtil.fp_header_t headerData, global::Motorola.Common.Communication.TetraUtility.ByteOrder order)
		{
			if (headerData == null)
			{
				return;
			}
			if (order == global::Motorola.Common.Communication.TetraUtility.ByteOrder.LittleEndian)
			{
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref headerData.checksum);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref headerData.pack_size);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005AA8 File Offset: 0x00003CA8
		public static string GetPackDescription(string packKey)
		{
			foreach (global::Motorola.Common.Communication.TetraUtility.FlashPackNamesRecord flashPackNamesRecord in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.FlashPackNamesTable.RecordsList)
			{
				if (string.Equals(flashPackNamesRecord.PackID, packKey, global::System.StringComparison.Ordinal))
				{
					return flashPackNamesRecord.PackName;
				}
			}
			return "";
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005B1C File Offset: 0x00003D1C
		public static uint GetByteAlignedAddress(uint currentPtr, uint structSize, byte byteAlignment)
		{
			byte b = (byte)((currentPtr + structSize) % (uint)byteAlignment);
			byte b2;
			if (b == 0)
			{
				b2 = 0;
			}
			else
			{
				b2 = byteAlignment - b;
			}
			return currentPtr + structSize + (uint)b2;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005B48 File Offset: 0x00003D48
		protected uint ComputePackChecksum(byte[] rawData)
		{
			uint num = 0U;
			uint num2 = 0U;
			if (rawData != null && rawData.Length != 0)
			{
				int num3 = 0;
				while ((long)num3 < (long)((ulong)this._size))
				{
					num += (uint)rawData[num3];
					num3++;
				}
				uint checksum = this._header.checksum;
				for (int i = 0; i < 4; i++)
				{
					num2 += (checksum >> i * 8 & 255U);
				}
				num -= num2;
			}
			return num;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005BB0 File Offset: 0x00003DB0
		public bool HeaderByteReverse()
		{
			if (this._data == null || this._data.Length == 0)
			{
				return false;
			}
			this._header.GetHeaderfromRawData(this._data);
			if (this._header.pack_product_platform == 20)
			{
				this._byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.LittleEndian;
			}
			global::Motorola.Common.Communication.TetraUtility.FPBase.HeaderByteReverse(this._header, this._byteOrder);
			return true;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000072 RID: 114
		public abstract uint CompareID { get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000073 RID: 115
		public abstract string Description { get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000074 RID: 116
		public abstract uint LanguageFontID { get; }

		// Token: 0x06000075 RID: 117
		public abstract bool InitData();

		// Token: 0x06000076 RID: 118
		public abstract bool IsCorrectType();

		// Token: 0x06000077 RID: 119
		public abstract string GetImageName();

		// Token: 0x06000078 RID: 120
		public abstract bool IsConflict(global::Motorola.Common.Communication.TetraUtility.FPBase pack);

		// Token: 0x06000079 RID: 121
		protected abstract bool InfoByteReverse();

		// Token: 0x04000021 RID: 33
		public const byte ALIGN_4 = 4;

		// Token: 0x04000022 RID: 34
		public const byte ALIGN_2 = 2;

		// Token: 0x04000023 RID: 35
		public const byte ALIGN_1 = 1;

		// Token: 0x04000024 RID: 36
		public const byte NGCH_PLATFORM_NUMBER = 20;

		// Token: 0x04000025 RID: 37
		public const byte BOROMIR_PLATFORM_NUMBER = 52;

		// Token: 0x04000026 RID: 38
		public const byte ALIGN_4_PATFORM_NUMBER = 66;

		// Token: 0x04000027 RID: 39
		protected byte[] _data;

		// Token: 0x04000028 RID: 40
		protected uint _size;

		// Token: 0x04000029 RID: 41
		protected global::Motorola.Common.Communication.CommonUtil.fp_header_t _header = new global::Motorola.Common.Communication.CommonUtil.fp_header_t();

		// Token: 0x0400002A RID: 42
		protected global::Motorola.Common.Communication.TetraUtility.ByteOrder _byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian;
	}
}
