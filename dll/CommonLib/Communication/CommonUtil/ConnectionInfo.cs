using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000006 RID: 6
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ConnectionInfo
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x0000279B File Offset: 0x0000099B
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000027A3 File Offset: 0x000009A3
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.ConnectionType ConnectionType { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000027AC File Offset: 0x000009AC
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000027B4 File Offset: 0x000009B4
		[global::System.Runtime.Serialization.DataMember]
		public string Location { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000027BD File Offset: 0x000009BD
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000027C5 File Offset: 0x000009C5
		[global::System.Runtime.Serialization.DataMember]
		public string UniqueAddress { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000027CE File Offset: 0x000009CE
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000027D6 File Offset: 0x000009D6
		[global::System.Runtime.Serialization.DataMember]
		public ushort SessionID { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000027DF File Offset: 0x000009DF
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000027E7 File Offset: 0x000009E7
		[global::System.Runtime.Serialization.DataMember]
		public int InactivityTimeout { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000027F0 File Offset: 0x000009F0
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000027F8 File Offset: 0x000009F8
		public global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo AuthInfo { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002801 File Offset: 0x00000A01
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002809 File Offset: 0x00000A09
		[global::System.Runtime.Serialization.DataMember]
		public string DeviceInstance { get; set; }

		// Token: 0x06000029 RID: 41 RVA: 0x00002814 File Offset: 0x00000A14
		public bool Match(global::Motorola.Common.Communication.CommonUtil.ConnectionInfo other)
		{
			return other != null && this.ConnectionType == other.ConnectionType && !(this.Location != other.Location) && !(this.UniqueAddress != other.UniqueAddress);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002861 File Offset: 0x00000A61
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002869 File Offset: 0x00000A69
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType OtapConnectionType { get; set; }

		// Token: 0x04000011 RID: 17
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Runtime.Serialization.OptionalField]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> AuthInfoList;
	}
}
