using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000014 RID: 20
	[global::System.Serializable]
	public class FPMandatoryPack : global::Motorola.Common.Communication.TetraUtility.FPBase
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00006C84 File Offset: 0x00004E84
		public override uint CompareID
		{
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00006C87 File Offset: 0x00004E87
		public override string Description
		{
			get
			{
				return "icon,config,picture,statusarea,palette,theme";
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00006C8E File Offset: 0x00004E8E
		public override uint LanguageFontID
		{
			get
			{
				return 0U;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006C91 File Offset: 0x00004E91
		public FPMandatoryPack(byte[] fpData, uint fpSize, global::Motorola.Common.Communication.TetraUtility.ByteOrder order) : base(fpData, fpSize, order)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006C9C File Offset: 0x00004E9C
		public override string GetImageName()
		{
			return global::Motorola.Common.Communication.TetraUtility.FPMandatoryPack.GetImageName(this._header);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00006CAC File Offset: 0x00004EAC
		public static string GetImageName(global::Motorola.Common.Communication.CommonUtil.fp_header_t header)
		{
			if (header == null)
			{
				return "";
			}
			return string.Format("FM{0:X2}{1:X2}{2:X2}{3:X2}", new object[]
			{
				header.pack_product_platform,
				header.pack_release_number,
				header.pack_revision_number,
				header.pack_sub_revision_num
			});
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00006D0E File Offset: 0x00004F0E
		public override bool InitData()
		{
			return this._data != null && this._size != 0U && this.IsCorrectType() && base.IsChecksumCorrect();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006D38 File Offset: 0x00004F38
		public override bool IsCorrectType()
		{
			return this._header.pack_type == 7 || this._header.pack_type == 4 || this._header.pack_type == 8 || this._header.pack_type == 6 || this._header.pack_type == 5 || this._header.pack_type == 3;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00006D9C File Offset: 0x00004F9C
		public override bool IsConflict(global::Motorola.Common.Communication.TetraUtility.FPBase pack)
		{
			if (pack == null)
			{
				return true;
			}
			bool result = false;
			if ((uint)this._header.pack_type == pack.PackType)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00006DC6 File Offset: 0x00004FC6
		protected override bool InfoByteReverse()
		{
			return true;
		}

		// Token: 0x04000042 RID: 66
		protected const string _mandatoryPackName = "icon,config,picture,statusarea,palette,theme";
	}
}
