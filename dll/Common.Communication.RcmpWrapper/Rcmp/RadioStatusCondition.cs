using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000044 RID: 68
	public enum RadioStatusCondition : byte
	{
		// Token: 0x04000130 RID: 304
		Squelch,
		// Token: 0x04000131 RID: 305
		SynthesizerLockDetect,
		// Token: 0x04000132 RID: 306
		RSSI,
		// Token: 0x04000133 RID: 307
		BatteryValue,
		// Token: 0x04000134 RID: 308
		LowBattery,
		// Token: 0x04000135 RID: 309
		PowerUpStatus,
		// Token: 0x04000136 RID: 310
		AbacusTuningStatus,
		// Token: 0x04000137 RID: 311
		ModelNumber,
		// Token: 0x04000138 RID: 312
		SerialNumber,
		// Token: 0x04000139 RID: 313
		ReadESN,
		// Token: 0x0400013A RID: 314
		IFInputSignalStrength,
		// Token: 0x0400013B RID: 315
		ReadProductSerialNumber,
		// Token: 0x0400013C RID: 316
		FrequencyOffset,
		// Token: 0x0400013D RID: 317
		CurrentSignallingMode,
		// Token: 0x0400013E RID: 318
		RadioID,
		// Token: 0x0400013F RID: 319
		RadioAlias,
		// Token: 0x04000140 RID: 320
		GenericOptionBoardAvailable,
		// Token: 0x04000141 RID: 321
		BanditWirelineBoardAvailable,
		// Token: 0x04000142 RID: 322
		AlternativeImageStatusOfBanditControllerFPGA,
		// Token: 0x04000143 RID: 323
		AlternativeImageStatusOfBanditWirelineFPGA,
		// Token: 0x04000144 RID: 324
		NeptuneFeatureStatus,
		// Token: 0x04000145 RID: 325
		MeterStatusOfBanditFPGA,
		// Token: 0x04000146 RID: 326
		Select5RadioID,
		// Token: 0x04000147 RID: 327
		PrivacyType,
		// Token: 0x04000148 RID: 328
		BluetoothAddress,
		// Token: 0x04000149 RID: 329
		SidebandSuppression,
		// Token: 0x0400014A RID: 330
		RadioUpdateStatus = 45,
		// Token: 0x0400014B RID: 331
		PhysicalSerialNumber = 75,
		// Token: 0x0400014C RID: 332
		DefaultGatewayNetworkAttachment = 78
	}
}
