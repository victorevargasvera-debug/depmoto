using System;
using System.Runtime.Serialization;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000003 RID: 3
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroFilePackInfo : global::Motorola.Common.Communication.Pba.LanguagePackBase
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020E9 File Offset: 0x000002E9
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000020F1 File Offset: 0x000002F1
		[global::System.Runtime.Serialization.DataMember]
		public string radioFilePath { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020FA File Offset: 0x000002FA
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002102 File Offset: 0x00000302
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType fileType { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000210B File Offset: 0x0000030B
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002113 File Offset: 0x00000313
		[global::System.Runtime.Serialization.DataMember]
		public int radioFileSize { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000211C File Offset: 0x0000031C
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002124 File Offset: 0x00000324
		[global::System.Runtime.Serialization.DataMember]
		public string encFileName { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000212D File Offset: 0x0000032D
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002135 File Offset: 0x00000335
		[global::System.Runtime.Serialization.DataMember]
		public string sourceFileId { get; set; }

		// Token: 0x0600000E RID: 14 RVA: 0x0000213E File Offset: 0x0000033E
		public AstroFilePackInfo()
		{
			this.encFileName = null;
			this.sourceFileId = null;
			this.radioFilePath = null;
			base.sourceFilePath = null;
			this.fileType = global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Unknown;
			this.radioFileSize = 0;
			this.languageUpgradeType = 0;
			this.isFlashPortUpgradeLP = false;
		}

		// Token: 0x04000002 RID: 2
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Runtime.Serialization.DataMember]
		public int languageUpgradeType;

		// Token: 0x04000003 RID: 3
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.CustomException.CommonErrorCode warningOTAPErrorCode;

		// Token: 0x04000004 RID: 4
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Runtime.Serialization.OptionalField]
		public bool isFlashPortUpgradeLP;

		// Token: 0x02000004 RID: 4
		[global::System.Runtime.Serialization.DataContract]
		public enum LanguagePackType
		{
			// Token: 0x0400000B RID: 11
			[global::System.Runtime.Serialization.EnumMember]
			Unknown,
			// Token: 0x0400000C RID: 12
			[global::System.Runtime.Serialization.EnumMember]
			LanguagePack,
			// Token: 0x0400000D RID: 13
			[global::System.Runtime.Serialization.EnumMember]
			Manifest
		}
	}
}
