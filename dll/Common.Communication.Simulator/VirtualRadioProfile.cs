using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.Pba;

namespace Common.Communication.Simulator
{
	// Token: 0x02000009 RID: 9
	internal class VirtualRadioProfile : global::Motorola.Common.Communication.DeviceDiscovery.RadioProfileBase
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002DEF File Offset: 0x00000FEF
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002DF7 File Offset: 0x00000FF7
		internal global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject> Device { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002E00 File Offset: 0x00001000
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002E08 File Offset: 0x00001008
		internal string RadioID { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002E11 File Offset: 0x00001011
		public override string RadioIdString
		{
			get
			{
				return this.RadioID;
			}
		}
	}
}
