using System;
using System.Runtime.Serialization;

namespace SSLMangrComp
{
	// Token: 0x0200003E RID: 62
	[global::System.Runtime.Serialization.KnownType(typeof(global::SSLMangrComp.SecureClientConfiguration))]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class SecureServerConfiguration : global::SSLMangrComp.SecureClientConfiguration
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00008099 File Offset: 0x00006299
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x000080A1 File Offset: 0x000062A1
		[global::System.Runtime.Serialization.DataMember]
		public byte[] DHParameters { get; set; }
	}
}
