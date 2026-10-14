using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000019 RID: 25
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo))]
	[global::System.Serializable]
	public class DeviceInfo
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002C4F File Offset: 0x00000E4F
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002C57 File Offset: 0x00000E57
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.ConnectionInfo ConnectionInfo { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002C60 File Offset: 0x00000E60
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002C68 File Offset: 0x00000E68
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.ProductFamily Family { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002C71 File Offset: 0x00000E71
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002C79 File Offset: 0x00000E79
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.RadioState RadioState { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002C82 File Offset: 0x00000E82
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002C8A File Offset: 0x00000E8A
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.RadioStorage RadioStorage { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002C93 File Offset: 0x00000E93
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002C9B File Offset: 0x00000E9B
		[global::System.Runtime.Serialization.DataMember]
		public virtual string RadioID { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002CA4 File Offset: 0x00000EA4
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002CAC File Offset: 0x00000EAC
		[global::System.Runtime.Serialization.DataMember]
		public string MasterHostNameOrAddress { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002CB5 File Offset: 0x00000EB5
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002CBD File Offset: 0x00000EBD
		[global::System.Runtime.Serialization.DataMember]
		public string ModelNumber { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002CC6 File Offset: 0x00000EC6
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002CCE File Offset: 0x00000ECE
		[global::System.Runtime.Serialization.DataMember]
		public string IMEI { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002CD7 File Offset: 0x00000ED7
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002CDF File Offset: 0x00000EDF
		[global::System.Runtime.Serialization.DataMember]
		public string SerialNumber { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002CE8 File Offset: 0x00000EE8
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002CF0 File Offset: 0x00000EF0
		[global::System.Runtime.Serialization.DataMember]
		public string CodeplugVersion { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002CF9 File Offset: 0x00000EF9
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002D01 File Offset: 0x00000F01
		[global::System.Runtime.Serialization.DataMember]
		public string SoftwareVersion { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002D0A File Offset: 0x00000F0A
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002D12 File Offset: 0x00000F12
		[global::System.Runtime.Serialization.DataMember]
		public bool UseCompress { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002D1B File Offset: 0x00000F1B
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002D23 File Offset: 0x00000F23
		[global::System.Runtime.Serialization.DataMember]
		public string OperationId { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002D2C File Offset: 0x00000F2C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002D34 File Offset: 0x00000F34
		[global::System.Runtime.Serialization.DataMember]
		public string TanapaNumber { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002D3D File Offset: 0x00000F3D
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002D45 File Offset: 0x00000F45
		[global::System.Runtime.Serialization.DataMember]
		public byte SecurityCapability { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002D4E File Offset: 0x00000F4E
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002D56 File Offset: 0x00000F56
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.SecureConnectionInfo secureConnectionInfo { get; set; }
	}
}
