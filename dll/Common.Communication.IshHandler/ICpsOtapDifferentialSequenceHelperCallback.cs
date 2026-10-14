using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000005 RID: 5
	public interface ICpsOtapDifferentialSequenceHelperCallback
	{
		// Token: 0x0600002A RID: 42
		global::Motorola.Common.Communication.CommonUtil.DeviceInfo GetDeviceInfo();

		// Token: 0x0600002B RID: 43
		bool IsLowBattery();

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002C RID: 44
		global::Motorola.Common.Communication.IProgressIndicator Progress { get; }
	}
}
