using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000025 RID: 37
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PBBDeviceInfo : global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000044ED File Offset: 0x000026ED
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000044F5 File Offset: 0x000026F5
		[global::System.Runtime.Serialization.DataMember]
		public string ProductIdentifier { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000044FE File Offset: 0x000026FE
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00004506 File Offset: 0x00002706
		[global::System.Runtime.Serialization.DataMember]
		public string ManufacturerName { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000450F File Offset: 0x0000270F
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00004517 File Offset: 0x00002717
		[global::System.Runtime.Serialization.DataMember]
		public string FirmwareVersion { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00004520 File Offset: 0x00002720
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00004528 File Offset: 0x00002728
		[global::System.Runtime.Serialization.DataMember]
		public int InactivityTimer { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00004531 File Offset: 0x00002731
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00004539 File Offset: 0x00002739
		[global::System.Runtime.Serialization.DataMember]
		public string Staged { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00004542 File Offset: 0x00002742
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000454A File Offset: 0x0000274A
		[global::System.Runtime.Serialization.DataMember]
		public string RMVersion { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00004553 File Offset: 0x00002753
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000455B File Offset: 0x0000275B
		[global::System.Runtime.Serialization.DataMember]
		public string LastPackage { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00004564 File Offset: 0x00002764
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000456C File Offset: 0x0000276C
		[global::System.Runtime.Serialization.DataMember]
		public string Certificates { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00004575 File Offset: 0x00002775
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000457D File Offset: 0x0000277D
		[global::System.Runtime.Serialization.DataMember]
		public int ResultCode { get; set; }
	}
}
