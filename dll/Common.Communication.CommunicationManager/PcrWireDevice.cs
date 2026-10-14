using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000040 RID: 64
	internal class PcrWireDevice : global::Motorola.Common.Communication.CommunicationManager.MotoDevice
	{
		// Token: 0x06000181 RID: 385 RVA: 0x0000792A File Offset: 0x00005B2A
		public PcrWireDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile) : base(deviceInfo, profile)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00007934 File Offset: 0x00005B34
		public override void CloseSession(bool pendingDeploy)
		{
			base.ValidateSession();
			global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType = base.ActiveSession.OperationType;
			base.CloseSession(pendingDeploy);
			if (!pendingDeploy && (operationType & global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program) == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
			{
				base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Removing);
			}
		}
	}
}
