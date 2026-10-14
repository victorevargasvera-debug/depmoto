using System;
using Motorola.Common.Communication.CommonUtil;

namespace Common.Communication.Simulator
{
	// Token: 0x0200000A RID: 10
	[global::System.Serializable]
	public class DeviceIDInfo
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00002E21 File Offset: 0x00001021
		public DeviceIDInfo(global::Motorola.Common.Communication.CommonUtil.ConnectionType connType, string radioId)
		{
			this.ConnType = connType;
			this.RadioID = radioId;
		}

		// Token: 0x04000015 RID: 21
		public global::Motorola.Common.Communication.CommonUtil.ConnectionType ConnType;

		// Token: 0x04000016 RID: 22
		public string RadioID;
	}
}
