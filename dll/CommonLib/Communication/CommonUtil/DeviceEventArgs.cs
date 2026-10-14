using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000017 RID: 23
	[global::System.Runtime.Serialization.DataContract]
	public class DeviceEventArgs : global::System.EventArgs
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002BDF File Offset: 0x00000DDF
		public DeviceEventArgs(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			this.DeviceInfo = deviceInfo;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002BEE File Offset: 0x00000DEE
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002BF6 File Offset: 0x00000DF6
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo DeviceInfo { get; private set; }
	}
}
