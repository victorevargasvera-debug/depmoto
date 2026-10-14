using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000022 RID: 34
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PcrLanguagePackInfo : global::Motorola.Common.Communication.Pba.LanguagePackBase
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00005998 File Offset: 0x00003B98
		// (set) Token: 0x06000154 RID: 340 RVA: 0x000059A0 File Offset: 0x00003BA0
		[global::System.Runtime.Serialization.DataMember]
		public uint MajorVersion { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000155 RID: 341 RVA: 0x000059A9 File Offset: 0x00003BA9
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000059B1 File Offset: 0x00003BB1
		[global::System.Runtime.Serialization.DataMember]
		public uint MinorVersion { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000059BA File Offset: 0x00003BBA
		// (set) Token: 0x06000158 RID: 344 RVA: 0x000059C2 File Offset: 0x00003BC2
		[global::System.Runtime.Serialization.DataMember]
		public uint Size { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000059CB File Offset: 0x00003BCB
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000059D3 File Offset: 0x00003BD3
		[global::System.Runtime.Serialization.DataMember]
		public string Name { get; set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000059DC File Offset: 0x00003BDC
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000059E4 File Offset: 0x00003BE4
		[global::System.Runtime.Serialization.DataMember]
		public string PackID { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000059ED File Offset: 0x00003BED
		// (set) Token: 0x0600015E RID: 350 RVA: 0x000059F5 File Offset: 0x00003BF5
		[global::System.Runtime.Serialization.DataMember]
		public string PackFilePath { get; set; }

		// Token: 0x0600015F RID: 351 RVA: 0x000059FE File Offset: 0x00003BFE
		public PcrLanguagePackInfo()
		{
			this.PackFilePath = null;
			this.MajorVersion = 0U;
			this.MinorVersion = 0U;
			this.Size = 0U;
			this.PackID = null;
			this.Name = null;
			base.sourceFilePath = null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005A38 File Offset: 0x00003C38
		public string GetVersionString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
			{
				this.MajorVersion,
				this.MinorVersion
			});
		}
	}
}
