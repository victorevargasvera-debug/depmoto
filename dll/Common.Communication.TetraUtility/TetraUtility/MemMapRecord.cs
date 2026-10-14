using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000030 RID: 48
	[global::System.Serializable]
	public class MemMapRecord
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000B4A6 File Offset: 0x000096A6
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000B4AE File Offset: 0x000096AE
		[global::System.Xml.Serialization.XmlAttribute("MemMapID")]
		public string MemMapID
		{
			get
			{
				return this._memMapID;
			}
			set
			{
				this._memMapID = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000B4B7 File Offset: 0x000096B7
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x0000B4BF File Offset: 0x000096BF
		public global::Motorola.Common.Communication.TetraUtility.SerializableDictionary<string, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit>> MapDefinition
		{
			get
			{
				return this._mapDefinition;
			}
			set
			{
				this._mapDefinition = value;
			}
		}

		// Token: 0x040000BE RID: 190
		private string _memMapID = string.Empty;

		// Token: 0x040000BF RID: 191
		private global::Motorola.Common.Communication.TetraUtility.SerializableDictionary<string, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit>> _mapDefinition;
	}
}
