using System;
using System.Diagnostics.CodeAnalysis;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200003F RID: 63
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1027:MarkEnumsWithFlags")]
	public enum SequenceManagerResult
	{
		// Token: 0x040001AF RID: 431
		Success,
		// Token: 0x040001B0 RID: 432
		Failure,
		// Token: 0x040001B1 RID: 433
		RcmpIncorrectMode,
		// Token: 0x040001B2 RID: 434
		RcmpOpcodeNotSupported,
		// Token: 0x040001B3 RID: 435
		RcmpInvalidParameter,
		// Token: 0x040001B4 RID: 436
		RcmpReplyTooBig,
		// Token: 0x040001B5 RID: 437
		RcmpSecurityLocked,
		// Token: 0x040001B6 RID: 438
		RcmpBundledOpcodeNotSupported,
		// Token: 0x040001B7 RID: 439
		RcmpSoftpotOperationNotSupported = 64,
		// Token: 0x040001B8 RID: 440
		RcmpSoftpotTypeNotSupported,
		// Token: 0x040001B9 RID: 441
		RcmpSoftpotValueOutOfRange,
		// Token: 0x040001BA RID: 442
		RcmpFlashWriteFailure = 128,
		// Token: 0x040001BB RID: 443
		RcmpIshItemNotFound,
		// Token: 0x040001BC RID: 444
		RcmpIshOffsetOutOfRange,
		// Token: 0x040001BD RID: 445
		RcmpIshInsufficientPartitionSpace,
		// Token: 0x040001BE RID: 446
		RcmpIshPartitionDoesNotExist,
		// Token: 0x040001BF RID: 447
		RcmpIshPartitionReadOnly,
		// Token: 0x040001C0 RID: 448
		RcmpIshReorgNeeded,
		// Token: 0x040001C1 RID: 449
		Undefined,
		// Token: 0x040001C2 RID: 450
		FlashNotNeeded = 144,
		// Token: 0x040001C3 RID: 451
		InvalidUpgradeFileContents,
		// Token: 0x040001C4 RID: 452
		InvalidSerialNumber,
		// Token: 0x040001C5 RID: 453
		InvalidUpgradeFile,
		// Token: 0x040001C6 RID: 454
		RadioStillErasingInactive,
		// Token: 0x040001C7 RID: 455
		FlashDowngrade,
		// Token: 0x040001C8 RID: 456
		ComponentNotFoundInUpgradeFile
	}
}
