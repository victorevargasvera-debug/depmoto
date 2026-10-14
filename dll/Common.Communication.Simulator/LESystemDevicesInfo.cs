using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Motorola.Common.Communication.CommonUtil;

namespace Common.Communication.Simulator
{
	// Token: 0x02000002 RID: 2
	[global::System.Serializable]
	public class LESystemDevicesInfo
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public LESystemDevicesInfo()
		{
			this.LESystem = new global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo();
			this.DeviceIdList = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x04000001 RID: 1
		[global::System.Xml.Serialization.XmlAttribute("LE System")]
		public global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo LESystem;

		// Token: 0x04000002 RID: 2
		[global::System.Xml.Serialization.XmlAttribute("Device ID List")]
		public global::System.Collections.Generic.List<string> DeviceIdList;
	}
}
