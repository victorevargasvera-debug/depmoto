using System;
using System.Xml;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000038 RID: 56
	public class TetraRadioModelInfo : global::System.ICloneable
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x0000B81D File Offset: 0x00009A1D
		public TetraRadioModelInfo(global::System.Xml.XmlElement xmlEle)
		{
			global::Motorola.Common.Communication.TetraUtility.TetraProductGroupInfo.SetPropertyFromXmlAttri(this, xmlEle);
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000B82C File Offset: 0x00009A2C
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x0000B834 File Offset: 0x00009A34
		public string BandType { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000B83D File Offset: 0x00009A3D
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0000B845 File Offset: 0x00009A45
		public int Codepage { get; set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000B84E File Offset: 0x00009A4E
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0000B856 File Offset: 0x00009A56
		public string Description { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000B85F File Offset: 0x00009A5F
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0000B867 File Offset: 0x00009A67
		public string FlashPackSupport { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000B870 File Offset: 0x00009A70
		// (set) Token: 0x060001DB RID: 475 RVA: 0x0000B878 File Offset: 0x00009A78
		public string MarketingName { get; set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000B881 File Offset: 0x00009A81
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0000B889 File Offset: 0x00009A89
		public string ModelNumber { get; set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000B892 File Offset: 0x00009A92
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0000B89A File Offset: 0x00009A9A
		public int ModelType { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000B8A3 File Offset: 0x00009AA3
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0000B8AB File Offset: 0x00009AAB
		public string PlatformIDList { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000B8B4 File Offset: 0x00009AB4
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x0000B8BC File Offset: 0x00009ABC
		public string ProductLine { get; set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000B8C5 File Offset: 0x00009AC5
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x0000B8CD File Offset: 0x00009ACD
		public string RegionType { get; set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000B8D6 File Offset: 0x00009AD6
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x0000B8DE File Offset: 0x00009ADE
		public string UniqueModelNumber { get; set; }

		// Token: 0x060001E8 RID: 488 RVA: 0x0000B8E7 File Offset: 0x00009AE7
		public object Clone()
		{
			return base.MemberwiseClone();
		}
	}
}
