using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000063 RID: 99
	public enum CodeplugAttributeType : byte
	{
		// Token: 0x040001F1 RID: 497
		None,
		// Token: 0x040001F2 RID: 498
		TotalAllowableMemory,
		// Token: 0x040001F3 RID: 499
		CurrentMemoryUsed,
		// Token: 0x040001F4 RID: 500
		RegionalInformation,
		// Token: 0x040001F5 RID: 501
		OEMManufacturerID,
		// Token: 0x040001F6 RID: 502
		RadioSecurityInfomation = 7,
		// Token: 0x040001F7 RID: 503
		CertificateSupportedID = 9
	}
}
