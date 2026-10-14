using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000029 RID: 41
	[global::System.Runtime.Serialization.DataContract]
	public class LicenseInventory
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003330 File Offset: 0x00001530
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00003338 File Offset: 0x00001538
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.License> licenseInventory { get; set; }

		// Token: 0x06000097 RID: 151 RVA: 0x00003341 File Offset: 0x00001541
		public LicenseInventory()
		{
			this.licenseInventory = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.License>();
		}
	}
}
