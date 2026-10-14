using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000053 RID: 83
	public enum RcmpReplyResult : byte
	{
		// Token: 0x04000187 RID: 391
		Success,
		// Token: 0x04000188 RID: 392
		Failure,
		// Token: 0x04000189 RID: 393
		IncorrectMode,
		// Token: 0x0400018A RID: 394
		OpcodeNotSupported,
		// Token: 0x0400018B RID: 395
		InvalidParameter,
		// Token: 0x0400018C RID: 396
		ReplyTooBig,
		// Token: 0x0400018D RID: 397
		SecurityLocked,
		// Token: 0x0400018E RID: 398
		BundledOpcodeNotSupported,
		// Token: 0x0400018F RID: 399
		LockSequenceFailure = 16,
		// Token: 0x04000190 RID: 400
		EraseInProgress = 16,
		// Token: 0x04000191 RID: 401
		Busy = 16,
		// Token: 0x04000192 RID: 402
		PairDeviceFailure = 16,
		// Token: 0x04000193 RID: 403
		BitLocked,
		// Token: 0x04000194 RID: 404
		LanguagePackNotExist = 17,
		// Token: 0x04000195 RID: 405
		PasswordVerificationFailure = 17,
		// Token: 0x04000196 RID: 406
		BitUnlocked,
		// Token: 0x04000197 RID: 407
		RadioIsLocked = 18,
		// Token: 0x04000198 RID: 408
		TTSLanguagePackNotExist = 18,
		// Token: 0x04000199 RID: 409
		VoltageNotStable,
		// Token: 0x0400019A RID: 410
		ProgramFailure,
		// Token: 0x0400019B RID: 411
		TransferComplete = 22,
		// Token: 0x0400019C RID: 412
		RequestNotRXed,
		// Token: 0x0400019D RID: 413
		SoftpotOperationNotSupported = 64,
		// Token: 0x0400019E RID: 414
		SoftpotTypeNotSupported,
		// Token: 0x0400019F RID: 415
		SoftpotValueOutOfRange,
		// Token: 0x040001A0 RID: 416
		FlashWriteFailure = 128,
		// Token: 0x040001A1 RID: 417
		IshItemNotFound,
		// Token: 0x040001A2 RID: 418
		IshOffsetOutOfRange,
		// Token: 0x040001A3 RID: 419
		IshInsufficientPartitionSpace,
		// Token: 0x040001A4 RID: 420
		IshPartitionDoesNotExist,
		// Token: 0x040001A5 RID: 421
		IshPartitionReadOnly,
		// Token: 0x040001A6 RID: 422
		IshReorgNeeded,
		// Token: 0x040001A7 RID: 423
		Undefined
	}
}
