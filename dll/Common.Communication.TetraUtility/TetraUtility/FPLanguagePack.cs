using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000011 RID: 17
	[global::System.Serializable]
	public class FPLanguagePack : global::Motorola.Common.Communication.TetraUtility.FPBase
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00005E21 File Offset: 0x00004021
		public override uint CompareID
		{
			get
			{
				return (uint)this._lpInfo.language_id;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00005E2E File Offset: 0x0000402E
		public override string Description
		{
			get
			{
				return this._lpDesc;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00005E36 File Offset: 0x00004036
		public uint LanguageID
		{
			get
			{
				return (uint)this._lpInfo.language_id;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00005E43 File Offset: 0x00004043
		public override uint LanguageFontID
		{
			get
			{
				return this._lpInfo.lang_font_id;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005E50 File Offset: 0x00004050
		public FPLanguagePack(byte[] lpData, uint lpSize, global::Motorola.Common.Communication.TetraUtility.ByteOrder order) : base(lpData, lpSize, order)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00005E68 File Offset: 0x00004068
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
			this._lpInfo.GetDatafromRaw(this._data, byteAlignedAddress);
			if (this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
			{
				this.InfoByteReverse();
			}
			string lpDesc = string.Format("L{0:D}", this._lpInfo.language_id);
			this._lpDesc = lpDesc;
			return true;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005EE8 File Offset: 0x000040E8
		public override bool IsCorrectType()
		{
			return this._header.pack_type == 1;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005EFB File Offset: 0x000040FB
		public override string GetImageName()
		{
			return global::Motorola.Common.Communication.TetraUtility.FPLanguagePack.GetImageName(this._header, this._lpInfo);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00005F10 File Offset: 0x00004110
		public override bool IsConflict(global::Motorola.Common.Communication.TetraUtility.FPBase pack)
		{
			if (pack == null)
			{
				return true;
			}
			bool result = false;
			if ((uint)this._header.pack_type == pack.PackType && this._lpInfo.language_id == ((global::Motorola.Common.Communication.TetraUtility.FPLanguagePack)pack)._lpInfo.language_id)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00005F57 File Offset: 0x00004157
		public static void InfoByteReverse(global::Motorola.Common.Communication.CommonUtil.fp_language_pack_info_t infoHeader)
		{
			if (infoHeader == null)
			{
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.size_prompt_data);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.size_decode_table);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.size_prompt_table);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.checksum);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.lang_font_id);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005F94 File Offset: 0x00004194
		public static string GetImageName(global::Motorola.Common.Communication.CommonUtil.fp_header_t header, global::Motorola.Common.Communication.CommonUtil.fp_language_pack_info_t lpInfo)
		{
			if (header == null || lpInfo == null)
			{
				return "";
			}
			return string.Format("FL{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}", new object[]
			{
				header.pack_product_platform,
				header.pack_release_number,
				lpInfo.language_id,
				header.pack_revision_number,
				header.pack_sub_revision_num
			});
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00006007 File Offset: 0x00004207
		protected override bool InfoByteReverse()
		{
			global::Motorola.Common.Communication.TetraUtility.FPLanguagePack.InfoByteReverse(this._lpInfo);
			return true;
		}

		// Token: 0x0400002D RID: 45
		protected global::Motorola.Common.Communication.CommonUtil.fp_language_pack_info_t _lpInfo = new global::Motorola.Common.Communication.CommonUtil.fp_language_pack_info_t();

		// Token: 0x0400002E RID: 46
		protected string _lpDesc;
	}
}
