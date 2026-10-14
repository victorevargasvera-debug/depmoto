using System;

namespace System.Data.SQLite
{
	// Token: 0x0200002D RID: 45
	public enum SQLiteAuthorizerActionCode
	{
		// Token: 0x04000102 RID: 258
		None = -1,
		// Token: 0x04000103 RID: 259
		Copy,
		// Token: 0x04000104 RID: 260
		CreateIndex,
		// Token: 0x04000105 RID: 261
		CreateTable,
		// Token: 0x04000106 RID: 262
		CreateTempIndex,
		// Token: 0x04000107 RID: 263
		CreateTempTable,
		// Token: 0x04000108 RID: 264
		CreateTempTrigger,
		// Token: 0x04000109 RID: 265
		CreateTempView,
		// Token: 0x0400010A RID: 266
		CreateTrigger,
		// Token: 0x0400010B RID: 267
		CreateView,
		// Token: 0x0400010C RID: 268
		Delete,
		// Token: 0x0400010D RID: 269
		DropIndex,
		// Token: 0x0400010E RID: 270
		DropTable,
		// Token: 0x0400010F RID: 271
		DropTempIndex,
		// Token: 0x04000110 RID: 272
		DropTempTable,
		// Token: 0x04000111 RID: 273
		DropTempTrigger,
		// Token: 0x04000112 RID: 274
		DropTempView,
		// Token: 0x04000113 RID: 275
		DropTrigger,
		// Token: 0x04000114 RID: 276
		DropView,
		// Token: 0x04000115 RID: 277
		Insert,
		// Token: 0x04000116 RID: 278
		Pragma,
		// Token: 0x04000117 RID: 279
		Read,
		// Token: 0x04000118 RID: 280
		Select,
		// Token: 0x04000119 RID: 281
		Transaction,
		// Token: 0x0400011A RID: 282
		Update,
		// Token: 0x0400011B RID: 283
		Attach,
		// Token: 0x0400011C RID: 284
		Detach,
		// Token: 0x0400011D RID: 285
		AlterTable,
		// Token: 0x0400011E RID: 286
		Reindex,
		// Token: 0x0400011F RID: 287
		Analyze,
		// Token: 0x04000120 RID: 288
		CreateVtable,
		// Token: 0x04000121 RID: 289
		DropVtable,
		// Token: 0x04000122 RID: 290
		Function,
		// Token: 0x04000123 RID: 291
		Savepoint
	}
}
