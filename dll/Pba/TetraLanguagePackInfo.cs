using System;
using System.Runtime.Serialization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000023 RID: 35
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class TetraLanguagePackInfo : global::Motorola.Common.Communication.Pba.LanguagePackBase
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00005A78 File Offset: 0x00003C78
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00005A80 File Offset: 0x00003C80
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t PackType { get; set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00005A89 File Offset: 0x00003C89
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00005A91 File Offset: 0x00003C91
		[global::System.Runtime.Serialization.DataMember]
		public int LanguageFontID { get; set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00005A9A File Offset: 0x00003C9A
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00005AA2 File Offset: 0x00003CA2
		[global::System.Runtime.Serialization.DataMember]
		public int ProductPlatform { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00005AAB File Offset: 0x00003CAB
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00005AB3 File Offset: 0x00003CB3
		[global::System.Runtime.Serialization.DataMember]
		public int ReleaseNumber { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00005ABC File Offset: 0x00003CBC
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00005AC4 File Offset: 0x00003CC4
		[global::System.Runtime.Serialization.DataMember]
		public int Revision { get; set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00005ACD File Offset: 0x00003CCD
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00005AD5 File Offset: 0x00003CD5
		[global::System.Runtime.Serialization.DataMember]
		public int SubRevision { get; set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00005ADE File Offset: 0x00003CDE
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00005AE6 File Offset: 0x00003CE6
		[global::System.Runtime.Serialization.DataMember]
		public string PackFilePath { get; set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00005AEF File Offset: 0x00003CEF
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00005AF7 File Offset: 0x00003CF7
		[global::System.Runtime.Serialization.DataMember]
		public string PackID { get; set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00005B00 File Offset: 0x00003D00
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00005B08 File Offset: 0x00003D08
		[global::System.Runtime.Serialization.DataMember]
		public uint Size { get; set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00005B11 File Offset: 0x00003D11
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00005B19 File Offset: 0x00003D19
		[global::System.Runtime.Serialization.DataMember]
		public bool Selected { get; set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00005B22 File Offset: 0x00003D22
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00005B2A File Offset: 0x00003D2A
		[global::System.Runtime.Serialization.DataMember]
		public bool Enable { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00005B33 File Offset: 0x00003D33
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00005B3B File Offset: 0x00003D3B
		[global::System.Runtime.Serialization.DataMember]
		public uint CompareID { get; set; }

		// Token: 0x06000179 RID: 377 RVA: 0x00005B44 File Offset: 0x00003D44
		public TetraLanguagePackInfo()
		{
			this.PackID = null;
			this.PackType = global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LANGUAGE_PACK;
			this.PackFilePath = null;
			this.LanguageFontID = 0;
			this.ProductPlatform = 0;
			this.ReleaseNumber = 0;
			this.Revision = 0;
			this.SubRevision = 0;
			base.sourceFilePath = null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00005B98 File Offset: 0x00003D98
		public void Initialize(global::Motorola.Common.Communication.CommonUtil.PackHeader pack)
		{
			this.PackID = pack.packid;
			this.PackType = pack.type;
			this.PackFilePath = pack.imageName;
			this.LanguageFontID = (int)pack.languageFontID;
			this.ProductPlatform = (int)pack.productPlatform;
			this.ReleaseNumber = (int)pack.releaseNumber;
			this.Revision = (int)pack.revision;
			this.SubRevision = (int)pack.subRevision;
			this.Size = pack.size;
			this.Selected = pack.select;
			this.Enable = pack.enable;
			this.CompareID = pack.compareID;
		}
	}
}
