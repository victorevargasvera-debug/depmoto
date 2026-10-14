using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200005D RID: 93
	public enum VersionInfoType : byte
	{
		// Token: 0x040001BB RID: 443
		HostSoftwareVersion,
		// Token: 0x040001BC RID: 444
		BBFBundleVersion = 2,
		// Token: 0x040001BD RID: 445
		DspSoftwareVersion = 16,
		// Token: 0x040001BE RID: 446
		DspCapability,
		// Token: 0x040001BF RID: 447
		DTPCapability = 19,
		// Token: 0x040001C0 RID: 448
		MaceFlashVersion = 34,
		// Token: 0x040001C1 RID: 449
		MaceHardwareVersion = 36,
		// Token: 0x040001C2 RID: 450
		MaceHardwareType,
		// Token: 0x040001C3 RID: 451
		FlashBootAppVersion = 48,
		// Token: 0x040001C4 RID: 452
		RamdownloaderVersion = 50,
		// Token: 0x040001C5 RID: 453
		L3BootloaderVersion = 53,
		// Token: 0x040001C6 RID: 454
		TuneVersion = 64,
		// Token: 0x040001C7 RID: 455
		SecurityVersion,
		// Token: 0x040001C8 RID: 456
		CodeplugVersion,
		// Token: 0x040001C9 RID: 457
		PsdtVersion = 80,
		// Token: 0x040001CA RID: 458
		ConfigurationVersion,
		// Token: 0x040001CB RID: 459
		KernelVersion,
		// Token: 0x040001CC RID: 460
		FlashSize = 109,
		// Token: 0x040001CD RID: 461
		OptionBoardName = 130,
		// Token: 0x040001CE RID: 462
		OptionBoardHardwareType = 132,
		// Token: 0x040001CF RID: 463
		OptionBoardMainAppVersion,
		// Token: 0x040001D0 RID: 464
		OptionBoardFlashImageType = 135,
		// Token: 0x040001D1 RID: 465
		OptionBoardFlashImageVersion,
		// Token: 0x040001D2 RID: 466
		ConsoletteBrdHwType = 164,
		// Token: 0x040001D3 RID: 467
		ConsoletteBrdHostVer,
		// Token: 0x040001D4 RID: 468
		FPGAControllerAlternativeVersion = 176,
		// Token: 0x040001D5 RID: 469
		FPGAControllerFactoryVersion,
		// Token: 0x040001D6 RID: 470
		FPGAControllerActiveVersion,
		// Token: 0x040001D7 RID: 471
		FPGAWirelineAlternativeVersion,
		// Token: 0x040001D8 RID: 472
		FPGAWirelineFactoryVersion,
		// Token: 0x040001D9 RID: 473
		FPGAWirelineActiveVersion
	}
}
