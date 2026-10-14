using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000012 RID: 18
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class UpdateDeviceData
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002838 File Offset: 0x00000A38
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002840 File Offset: 0x00000A40
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> MemoryImages { get; set; }

		// Token: 0x06000085 RID: 133 RVA: 0x00002849 File Offset: 0x00000A49
		public UpdateDeviceData()
		{
			this.MemoryImages = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>();
		}
	}
}
