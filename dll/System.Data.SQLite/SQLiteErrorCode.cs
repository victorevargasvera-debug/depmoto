using System;

namespace System.Data.SQLite
{
	// Token: 0x02000039 RID: 57
	public enum SQLiteErrorCode
	{
		// Token: 0x04000147 RID: 327
		Unknown = -1,
		// Token: 0x04000148 RID: 328
		Ok,
		// Token: 0x04000149 RID: 329
		Error,
		// Token: 0x0400014A RID: 330
		Internal,
		// Token: 0x0400014B RID: 331
		Perm,
		// Token: 0x0400014C RID: 332
		Abort,
		// Token: 0x0400014D RID: 333
		Busy,
		// Token: 0x0400014E RID: 334
		Locked,
		// Token: 0x0400014F RID: 335
		NoMem,
		// Token: 0x04000150 RID: 336
		ReadOnly,
		// Token: 0x04000151 RID: 337
		Interrupt,
		// Token: 0x04000152 RID: 338
		IoErr,
		// Token: 0x04000153 RID: 339
		Corrupt,
		// Token: 0x04000154 RID: 340
		NotFound,
		// Token: 0x04000155 RID: 341
		Full,
		// Token: 0x04000156 RID: 342
		CantOpen,
		// Token: 0x04000157 RID: 343
		Protocol,
		// Token: 0x04000158 RID: 344
		Empty,
		// Token: 0x04000159 RID: 345
		Schema,
		// Token: 0x0400015A RID: 346
		TooBig,
		// Token: 0x0400015B RID: 347
		Constraint,
		// Token: 0x0400015C RID: 348
		Mismatch,
		// Token: 0x0400015D RID: 349
		Misuse,
		// Token: 0x0400015E RID: 350
		NoLfs,
		// Token: 0x0400015F RID: 351
		Auth,
		// Token: 0x04000160 RID: 352
		Format,
		// Token: 0x04000161 RID: 353
		Range,
		// Token: 0x04000162 RID: 354
		NotADb,
		// Token: 0x04000163 RID: 355
		Notice,
		// Token: 0x04000164 RID: 356
		Warning,
		// Token: 0x04000165 RID: 357
		Row = 100,
		// Token: 0x04000166 RID: 358
		Done
	}
}
