using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200000F RID: 15
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class TetraMemoryImage : global::Motorola.Common.Communication.Pba.RadioImage
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000025E4 File Offset: 0x000007E4
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000025EC File Offset: 0x000007EC
		[global::System.Runtime.Serialization.DataMember]
		public uint Address { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000025F5 File Offset: 0x000007F5
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000025FD File Offset: 0x000007FD
		[global::System.Runtime.Serialization.DataMember]
		public uint Size { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002606 File Offset: 0x00000806
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0000260E File Offset: 0x0000080E
		[global::System.Runtime.Serialization.DataMember]
		public string TargetModelNumber { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002617 File Offset: 0x00000817
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000261F File Offset: 0x0000081F
		[global::System.Runtime.Serialization.DataMember]
		public string TargetSerialNumber { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002628 File Offset: 0x00000828
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002630 File Offset: 0x00000830
		[global::System.Runtime.Serialization.DataMember]
		public string TargetCPVersion { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002639 File Offset: 0x00000839
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002641 File Offset: 0x00000841
		[global::System.Runtime.Serialization.DataMember]
		public bool ForceWrite { get; set; }

		// Token: 0x06000065 RID: 101 RVA: 0x0000264A File Offset: 0x0000084A
		public TetraMemoryImage()
		{
			base.FilePath = null;
			base.FileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.Unknown;
			this.ForceWrite = false;
			this.Address = 0U;
			this.Size = 0U;
			this.TargetModelNumber = null;
			this.TargetSerialNumber = null;
			this.TargetCPVersion = null;
		}
	}
}
