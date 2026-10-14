using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000028 RID: 40
	[global::System.Runtime.Serialization.DataContract]
	public class License
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00003310 File Offset: 0x00001510
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00003318 File Offset: 0x00001518
		[global::System.Runtime.Serialization.DataMember]
		public string featureName { get; set; }

		// Token: 0x06000094 RID: 148 RVA: 0x00003321 File Offset: 0x00001521
		public License(string name)
		{
			this.featureName = name;
		}
	}
}
