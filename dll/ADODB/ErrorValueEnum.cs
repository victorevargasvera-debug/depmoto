using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000020 RID: 32
	[global::System.Runtime.InteropServices.Guid("0000052A-0000-0010-8000-00AA006D2EA4")]
	public enum ErrorValueEnum
	{
		// Token: 0x040000E5 RID: 229
		adErrProviderFailed = 3000,
		// Token: 0x040000E6 RID: 230
		adErrInvalidArgument,
		// Token: 0x040000E7 RID: 231
		adErrOpeningFile,
		// Token: 0x040000E8 RID: 232
		adErrReadFile,
		// Token: 0x040000E9 RID: 233
		adErrWriteFile,
		// Token: 0x040000EA RID: 234
		adErrNoCurrentRecord = 3021,
		// Token: 0x040000EB RID: 235
		adErrIllegalOperation = 3219,
		// Token: 0x040000EC RID: 236
		adErrCantChangeProvider,
		// Token: 0x040000ED RID: 237
		adErrInTransaction = 3246,
		// Token: 0x040000EE RID: 238
		adErrFeatureNotAvailable = 3251,
		// Token: 0x040000EF RID: 239
		adErrItemNotFound = 3265,
		// Token: 0x040000F0 RID: 240
		adErrObjectInCollection = 3367,
		// Token: 0x040000F1 RID: 241
		adErrObjectNotSet = 3420,
		// Token: 0x040000F2 RID: 242
		adErrDataConversion,
		// Token: 0x040000F3 RID: 243
		adErrObjectClosed = 3704,
		// Token: 0x040000F4 RID: 244
		adErrObjectOpen,
		// Token: 0x040000F5 RID: 245
		adErrProviderNotFound,
		// Token: 0x040000F6 RID: 246
		adErrBoundToCommand,
		// Token: 0x040000F7 RID: 247
		adErrInvalidParamInfo,
		// Token: 0x040000F8 RID: 248
		adErrInvalidConnection,
		// Token: 0x040000F9 RID: 249
		adErrNotReentrant,
		// Token: 0x040000FA RID: 250
		adErrStillExecuting,
		// Token: 0x040000FB RID: 251
		adErrOperationCancelled,
		// Token: 0x040000FC RID: 252
		adErrStillConnecting,
		// Token: 0x040000FD RID: 253
		adErrInvalidTransaction,
		// Token: 0x040000FE RID: 254
		[global::System.Runtime.InteropServices.TypeLibVar(64)]
		adErrNotExecuting,
		// Token: 0x040000FF RID: 255
		adErrUnsafeOperation,
		// Token: 0x04000100 RID: 256
		adwrnSecurityDialog,
		// Token: 0x04000101 RID: 257
		adwrnSecurityDialogHeader,
		// Token: 0x04000102 RID: 258
		adErrIntegrityViolation,
		// Token: 0x04000103 RID: 259
		adErrPermissionDenied,
		// Token: 0x04000104 RID: 260
		adErrDataOverflow,
		// Token: 0x04000105 RID: 261
		adErrSchemaViolation,
		// Token: 0x04000106 RID: 262
		adErrSignMismatch,
		// Token: 0x04000107 RID: 263
		adErrCantConvertvalue,
		// Token: 0x04000108 RID: 264
		adErrCantCreate,
		// Token: 0x04000109 RID: 265
		adErrColumnNotOnThisRow,
		// Token: 0x0400010A RID: 266
		adErrURLDoesNotExist,
		// Token: 0x0400010B RID: 267
		adErrTreePermissionDenied,
		// Token: 0x0400010C RID: 268
		adErrInvalidURL,
		// Token: 0x0400010D RID: 269
		adErrResourceLocked,
		// Token: 0x0400010E RID: 270
		adErrResourceExists,
		// Token: 0x0400010F RID: 271
		adErrCannotComplete,
		// Token: 0x04000110 RID: 272
		adErrVolumeNotFound,
		// Token: 0x04000111 RID: 273
		adErrOutOfSpace,
		// Token: 0x04000112 RID: 274
		adErrResourceOutOfScope,
		// Token: 0x04000113 RID: 275
		adErrUnavailable,
		// Token: 0x04000114 RID: 276
		adErrURLNamedRowDoesNotExist,
		// Token: 0x04000115 RID: 277
		adErrDelResOutOfScope,
		// Token: 0x04000116 RID: 278
		adErrPropInvalidColumn,
		// Token: 0x04000117 RID: 279
		adErrPropInvalidOption,
		// Token: 0x04000118 RID: 280
		adErrPropInvalidValue,
		// Token: 0x04000119 RID: 281
		adErrPropConflicting,
		// Token: 0x0400011A RID: 282
		adErrPropNotAllSettable,
		// Token: 0x0400011B RID: 283
		adErrPropNotSet,
		// Token: 0x0400011C RID: 284
		adErrPropNotSettable,
		// Token: 0x0400011D RID: 285
		adErrPropNotSupported,
		// Token: 0x0400011E RID: 286
		adErrCatalogNotSet,
		// Token: 0x0400011F RID: 287
		adErrCantChangeConnection,
		// Token: 0x04000120 RID: 288
		adErrFieldsUpdateFailed,
		// Token: 0x04000121 RID: 289
		adErrDenyNotSupported,
		// Token: 0x04000122 RID: 290
		adErrDenyTypeNotSupported,
		// Token: 0x04000123 RID: 291
		adErrProviderNotSpecified = 3753
	}
}
