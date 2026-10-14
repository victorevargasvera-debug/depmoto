using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000005 RID: 5
	[global::System.Flags]
	public enum DeviceControlOperationType
	{
		// Token: 0x04000005 RID: 5
		None = 0,
		// Token: 0x04000006 RID: 6
		TurnOffRadio = 1,
		// Token: 0x04000007 RID: 7
		LLPIsAvailable = 2,
		// Token: 0x04000008 RID: 8
		SwitchModeToNormal = 4,
		// Token: 0x04000009 RID: 9
		SwitchModeToKernel = 8,
		// Token: 0x0400000A RID: 10
		RemoveRadio = 16
	}
}
