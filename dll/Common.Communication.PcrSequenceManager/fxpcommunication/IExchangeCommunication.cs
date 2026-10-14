using System;

namespace fxpcommunication
{
	// Token: 0x02000005 RID: 5
	internal interface IExchangeCommunication
	{
		// Token: 0x0600000C RID: 12
		void Enable(string fwVersion, string radioSN, byte[] hashInput, byte[] featureCodeID);

		// Token: 0x0600000D RID: 13
		void Disable(string radioSN, byte[] hashInput, byte[] featureCodeID);

		// Token: 0x0600000E RID: 14
		byte[] CreateHashInput(string xmlInputBuffer);
	}
}
