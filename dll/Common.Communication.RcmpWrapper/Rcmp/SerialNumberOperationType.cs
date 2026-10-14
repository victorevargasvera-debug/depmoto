using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200004C RID: 76
	public enum SerialNumberOperationType : byte
	{
		// Token: 0x04000167 RID: 359
		ReadRadioSerialNumber,
		// Token: 0x04000168 RID: 360
		WriteRadioSerialNumber,
		// Token: 0x04000169 RID: 361
		ReadESN,
		// Token: 0x0400016A RID: 362
		WriteESN,
		// Token: 0x0400016B RID: 363
		ReadMACAddress,
		// Token: 0x0400016C RID: 364
		WriteMACAddress,
		// Token: 0x0400016D RID: 365
		ReadProductSerialNumber,
		// Token: 0x0400016E RID: 366
		WriteProductSerialNumber,
		// Token: 0x0400016F RID: 367
		ReadOptionBoardSerialNumber,
		// Token: 0x04000170 RID: 368
		WriteOptionBoardSerialNumber,
		// Token: 0x04000171 RID: 369
		ReadWiFiMACAddress,
		// Token: 0x04000172 RID: 370
		WriteWiFiMACAddress
	}
}
