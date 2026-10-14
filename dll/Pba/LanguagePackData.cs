using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000019 RID: 25
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class LanguagePackData
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002CE8 File Offset: 0x00000EE8
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002CF0 File Offset: 0x00000EF0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase> LanguagePacks { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002CF9 File Offset: 0x00000EF9
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002D01 File Offset: 0x00000F01
		[global::System.Runtime.Serialization.DataMember]
		public uint AvailableSpace { get; set; }

		// Token: 0x060000B1 RID: 177 RVA: 0x00002D0A File Offset: 0x00000F0A
		public LanguagePackData()
		{
			this.LanguagePacks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>();
			this.AvailableSpace = 0U;
			this.ModelType = global::Motorola.Common.Communication.CommonUtil.ModelType.Portable;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002D2B File Offset: 0x00000F2B
		public LanguagePackData(global::Motorola.Common.Communication.CommonUtil.ModelType type)
		{
			this.LanguagePacks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>();
			this.AvailableSpace = 0U;
			this.ModelType = type;
		}

		// Token: 0x04000081 RID: 129
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Runtime.Serialization.OptionalField]
		public global::Motorola.Common.Communication.CommonUtil.ModelType ModelType;
	}
}
