using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000018 RID: 24
	[global::System.Runtime.Serialization.DataContract]
	public class SwitchOverEventArgs : global::System.EventArgs
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00002BFF File Offset: 0x00000DFF
		public SwitchOverEventArgs(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, ushort sessionID, global::Motorola.Common.Communication.CommonUtil.SwitchOverStatus status)
		{
			this.DeviceInfo = deviceInfo;
			this.SessionID = sessionID;
			this.Status = status;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002C1C File Offset: 0x00000E1C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002C24 File Offset: 0x00000E24
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo DeviceInfo { get; private set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002C2D File Offset: 0x00000E2D
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002C35 File Offset: 0x00000E35
		[global::System.Runtime.Serialization.DataMember]
		public ushort SessionID { get; private set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002C3E File Offset: 0x00000E3E
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002C46 File Offset: 0x00000E46
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.SwitchOverStatus Status { get; private set; }
	}
}
