using System;
using System.Runtime.Serialization;

namespace SSLMangrComp
{
	// Token: 0x0200003D RID: 61
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class SecureClientConfiguration
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00008039 File Offset: 0x00006239
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00008041 File Offset: 0x00006241
		[global::System.Runtime.Serialization.DataMember]
		public string CACertificate { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000804A File Offset: 0x0000624A
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00008052 File Offset: 0x00006252
		[global::System.Runtime.Serialization.DataMember]
		public string ClientCertificate { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000805B File Offset: 0x0000625B
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00008063 File Offset: 0x00006263
		[global::System.Runtime.Serialization.DataMember]
		public string ClientKeyPassphrase { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000806C File Offset: 0x0000626C
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00008074 File Offset: 0x00006274
		[global::System.Runtime.Serialization.DataMember]
		public string CipherSuites
		{
			get
			{
				return this.cipherSuite;
			}
			set
			{
				if (value.Length > 3)
				{
					this.cipherSuite = value;
				}
			}
		}

		// Token: 0x0400011E RID: 286
		private string cipherSuite = "AES:3DES:!DSS:SHA:!aNULL:!eNULL:!DES:!MD5:!IDEA:!RC2:!RC4:@STRENGTH";
	}
}
