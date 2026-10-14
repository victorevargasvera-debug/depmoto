using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000010 RID: 16
	[global::System.Serializable]
	public class FPFontPack : global::Motorola.Common.Communication.TetraUtility.FPBase
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00005C0A File Offset: 0x00003E0A
		public override uint CompareID
		{
			get
			{
				return this._fpInfo.font_id;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00005C17 File Offset: 0x00003E17
		public override string Description
		{
			get
			{
				return this._fpDesc;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00005C1F File Offset: 0x00003E1F
		public uint FontID
		{
			get
			{
				return this._fpInfo.font_id;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00005C2C File Offset: 0x00003E2C
		public override uint LanguageFontID
		{
			get
			{
				return this._fpInfo.lang_font_id;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005C39 File Offset: 0x00003E39
		public FPFontPack(byte[] fpData, uint fpSize, global::Motorola.Common.Communication.TetraUtility.ByteOrder order) : base(fpData, fpSize, order)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005C50 File Offset: 0x00003E50
		public override bool InitData()
		{
			if (this._data == null || this._size == 0U)
			{
				return false;
			}
			if (!this.IsCorrectType() || !base.IsChecksumCorrect())
			{
				return false;
			}
			uint byteAlignedAddress = global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(0U, 16U, 4);
			this._fpInfo.GetDatafromRaw(this._data, byteAlignedAddress);
			if (this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
			{
				this.InfoByteReverse();
			}
			string fpDesc = string.Format("F{0:D}", this._fpInfo.font_id);
			this._fpDesc = fpDesc;
			return true;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005CD0 File Offset: 0x00003ED0
		public override bool IsCorrectType()
		{
			return this._header.pack_type == 2;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00005CE3 File Offset: 0x00003EE3
		public override string GetImageName()
		{
			return global::Motorola.Common.Communication.TetraUtility.FPFontPack.GetImageName(this._header, this._fpInfo);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public override bool IsConflict(global::Motorola.Common.Communication.TetraUtility.FPBase pack)
		{
			if (pack == null)
			{
				return true;
			}
			bool result = false;
			if ((uint)this._header.pack_type == pack.PackType && this._fpInfo.font_id == ((global::Motorola.Common.Communication.TetraUtility.FPFontPack)pack)._fpInfo.font_id)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00005D40 File Offset: 0x00003F40
		public static void InfoByteReverse(global::Motorola.Common.Communication.CommonUtil.fp_font_pack_info_t infoHeader)
		{
			if (infoHeader == null)
			{
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.font_id);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.font_height);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.blk_char_width);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.unicode_to_glyph_data_size);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.glyph_data_size);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.lang_font_id);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.device_id);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00005DA0 File Offset: 0x00003FA0
		public static string GetImageName(global::Motorola.Common.Communication.CommonUtil.fp_header_t header, global::Motorola.Common.Communication.CommonUtil.fp_font_pack_info_t fpInfo)
		{
			if (header == null || fpInfo == null)
			{
				return "";
			}
			return string.Format("FF{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}", new object[]
			{
				header.pack_product_platform,
				header.pack_release_number,
				fpInfo.font_id,
				header.pack_revision_number,
				header.pack_sub_revision_num
			});
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005E13 File Offset: 0x00004013
		protected override bool InfoByteReverse()
		{
			global::Motorola.Common.Communication.TetraUtility.FPFontPack.InfoByteReverse(this._fpInfo);
			return true;
		}

		// Token: 0x0400002B RID: 43
		protected global::Motorola.Common.Communication.CommonUtil.fp_font_pack_info_t _fpInfo = new global::Motorola.Common.Communication.CommonUtil.fp_font_pack_info_t();

		// Token: 0x0400002C RID: 44
		protected string _fpDesc;
	}
}
