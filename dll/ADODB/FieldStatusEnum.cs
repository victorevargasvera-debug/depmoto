using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000027 RID: 39
	[global::System.Runtime.InteropServices.Guid("0000057E-0000-0010-8000-00AA006D2EA4")]
	public enum FieldStatusEnum
	{
		// Token: 0x0400017C RID: 380
		adFieldOK,
		// Token: 0x0400017D RID: 381
		adFieldCantConvertValue = 2,
		// Token: 0x0400017E RID: 382
		adFieldIsNull,
		// Token: 0x0400017F RID: 383
		adFieldTruncated,
		// Token: 0x04000180 RID: 384
		adFieldSignMismatch,
		// Token: 0x04000181 RID: 385
		adFieldDataOverflow,
		// Token: 0x04000182 RID: 386
		adFieldCantCreate,
		// Token: 0x04000183 RID: 387
		adFieldUnavailable,
		// Token: 0x04000184 RID: 388
		adFieldPermissionDenied,
		// Token: 0x04000185 RID: 389
		adFieldIntegrityViolation,
		// Token: 0x04000186 RID: 390
		adFieldSchemaViolation,
		// Token: 0x04000187 RID: 391
		adFieldBadStatus,
		// Token: 0x04000188 RID: 392
		adFieldDefault,
		// Token: 0x04000189 RID: 393
		adFieldIgnore = 15,
		// Token: 0x0400018A RID: 394
		adFieldDoesNotExist,
		// Token: 0x0400018B RID: 395
		adFieldInvalidURL,
		// Token: 0x0400018C RID: 396
		adFieldResourceLocked,
		// Token: 0x0400018D RID: 397
		adFieldResourceExists,
		// Token: 0x0400018E RID: 398
		adFieldCannotComplete,
		// Token: 0x0400018F RID: 399
		adFieldVolumeNotFound,
		// Token: 0x04000190 RID: 400
		adFieldOutOfSpace,
		// Token: 0x04000191 RID: 401
		adFieldCannotDeleteSource,
		// Token: 0x04000192 RID: 402
		adFieldReadOnly,
		// Token: 0x04000193 RID: 403
		adFieldResourceOutOfScope,
		// Token: 0x04000194 RID: 404
		adFieldAlreadyExists,
		// Token: 0x04000195 RID: 405
		adFieldPendingInsert = 65536,
		// Token: 0x04000196 RID: 406
		adFieldPendingDelete = 131072,
		// Token: 0x04000197 RID: 407
		adFieldPendingChange = 262144,
		// Token: 0x04000198 RID: 408
		adFieldPendingUnknown = 524288,
		// Token: 0x04000199 RID: 409
		adFieldPendingUnknownDelete = 1048576
	}
}
