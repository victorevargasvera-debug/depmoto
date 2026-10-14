using System;
using custom_datatypes;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.PCRRemoteProgramming
{
	// Token: 0x0200000A RID: 10
	public class PCRRemoteDeviceProfile : global::Motorola.Common.Communication.DeviceDiscovery.RadioProfileBase
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002F0C File Offset: 0x0000110C
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002F14 File Offset: 0x00001114
		internal global::custom_datatypes.MLEPeer PEER { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002F20 File Offset: 0x00001120
		public override string RadioIdString
		{
			get
			{
				return this.PEER.ID.ToString();
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002F43 File Offset: 0x00001143
		internal PCRRemoteDeviceProfile(global::custom_datatypes.MLEPeer peer)
		{
			base.PID = global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRemoteDeviceDetector.PCR_REMOTE_REPEATER_PID;
			base.RadioType = global::Motorola.Common.Communication.RadioType.PCR;
			this.PEER = peer;
		}
	}
}
