using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000039 RID: 57
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PackHeader : global::System.ICloneable
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00006426 File Offset: 0x00004626
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0000642E File Offset: 0x0000462E
		[global::System.Runtime.Serialization.DataMember]
		public string packid { get; set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00006437 File Offset: 0x00004637
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0000643F File Offset: 0x0000463F
		[global::System.Runtime.Serialization.DataMember]
		public string imageName { get; set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00006448 File Offset: 0x00004648
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00006450 File Offset: 0x00004650
		[global::System.Runtime.Serialization.DataMember]
		public uint productPlatform { get; set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00006459 File Offset: 0x00004659
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00006461 File Offset: 0x00004661
		[global::System.Runtime.Serialization.DataMember]
		public uint releaseNumber { get; set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000646A File Offset: 0x0000466A
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00006472 File Offset: 0x00004672
		[global::System.Runtime.Serialization.DataMember]
		public uint revision { get; set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000647B File Offset: 0x0000467B
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00006483 File Offset: 0x00004683
		[global::System.Runtime.Serialization.DataMember]
		public uint subRevision { get; set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000648C File Offset: 0x0000468C
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00006494 File Offset: 0x00004694
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t type { get; set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000649D File Offset: 0x0000469D
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x000064A5 File Offset: 0x000046A5
		[global::System.Runtime.Serialization.DataMember]
		public uint size { get; set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000064AE File Offset: 0x000046AE
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x000064B6 File Offset: 0x000046B6
		[global::System.Runtime.Serialization.DataMember]
		public uint compareID { get; set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000064BF File Offset: 0x000046BF
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x000064C7 File Offset: 0x000046C7
		[global::System.Runtime.Serialization.DataMember]
		public uint languageFontID { get; set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000064D0 File Offset: 0x000046D0
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x000064D8 File Offset: 0x000046D8
		[global::System.Runtime.Serialization.DataMember]
		public bool select { get; set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000064E1 File Offset: 0x000046E1
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x000064E9 File Offset: 0x000046E9
		[global::System.Runtime.Serialization.DataMember]
		public bool enable { get; set; }

		// Token: 0x060001DA RID: 474 RVA: 0x000064F2 File Offset: 0x000046F2
		public PackHeader()
		{
			this.Reset();
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00006500 File Offset: 0x00004700
		public void Reset()
		{
			this.packid = "";
			this.imageName = "";
			this.productPlatform = 0U;
			this.releaseNumber = 0U;
			this.type = global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.NONE;
			this.size = 0U;
			this.revision = 0U;
			this.subRevision = 0U;
			this.compareID = 0U;
			this.languageFontID = 0U;
			this.select = false;
			this.enable = true;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000656C File Offset: 0x0000476C
		public object Clone()
		{
			return new global::Motorola.Common.Communication.CommonUtil.PackHeader
			{
				packid = this.packid,
				imageName = this.imageName,
				productPlatform = this.productPlatform,
				releaseNumber = this.releaseNumber,
				type = this.type,
				size = this.size,
				revision = this.revision,
				subRevision = this.subRevision,
				compareID = this.compareID,
				languageFontID = this.languageFontID,
				select = this.select,
				enable = this.enable
			};
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00006610 File Offset: 0x00004810
		public global::Motorola.Common.Communication.CommonUtil.FP_DEPENDENCE_E GetDependence(global::Motorola.Common.Communication.CommonUtil.PackHeader pack, bool selected)
		{
			if (pack == null)
			{
				return global::Motorola.Common.Communication.CommonUtil.FP_DEPENDENCE_E.NONE;
			}
			if (this.type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LANGUAGE_PACK)
			{
				return global::Motorola.Common.Communication.CommonUtil.FP_DEPENDENCE_E.NONE;
			}
			global::Motorola.Common.Communication.CommonUtil.FP_DEPENDENCE_E result = global::Motorola.Common.Communication.CommonUtil.FP_DEPENDENCE_E.NONE;
			bool flag = false;
			if (this.packid == "L25" && pack.type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.FONT_PACK)
			{
				if (pack.languageFontID == 8U)
				{
					flag = true;
				}
			}
			else if (pack.type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.FONT_PACK && pack.languageFontID == this.languageFontID)
			{
				flag = true;
			}
			if (flag)
			{
				if (selected)
				{
					result = global::Motorola.Common.Communication.CommonUtil.FP_DEPENDENCE_E.SELECT_DISABLE;
				}
				else
				{
					result = global::Motorola.Common.Communication.CommonUtil.FP_DEPENDENCE_E.UNSELECT_ENABLE;
				}
			}
			return result;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00006680 File Offset: 0x00004880
		public bool IsConflict(global::Motorola.Common.Communication.CommonUtil.PackHeader pack)
		{
			if (pack == null)
			{
				return true;
			}
			bool result = false;
			if (this.type == pack.type)
			{
				global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t type = this.type;
				switch (type)
				{
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LANGUAGE_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.FONT_PACK:
					if (this.compareID == pack.compareID)
					{
						result = true;
					}
					break;
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.THEME_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.ICON_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.STATUSAREA_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.PICTURE_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.CONFIG_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.PALETTE_PACK:
					result = true;
					break;
				default:
					result = (type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK);
					break;
				}
			}
			return result;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000066F8 File Offset: 0x000048F8
		public bool IsGemstoneBMPFPConflict(global::Motorola.Common.Communication.CommonUtil.PackHeader pack)
		{
			if (pack == null)
			{
				return true;
			}
			bool result = false;
			if (this.type == pack.type)
			{
				global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t type = this.type;
				switch (type)
				{
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LANGUAGE_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.FONT_PACK:
					if (this.compareID == pack.compareID)
					{
						result = true;
					}
					break;
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.THEME_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.ICON_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.STATUSAREA_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.PICTURE_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.CONFIG_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.PALETTE_PACK:
					result = true;
					break;
				default:
					result = (type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK);
					break;
				}
			}
			return result;
		}
	}
}
