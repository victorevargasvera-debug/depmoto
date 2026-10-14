using System;

namespace System.Data.SQLite
{
	// Token: 0x0200007C RID: 124
	public sealed class SQLiteIndexOutputs
	{
		// Token: 0x060004F7 RID: 1271 RVA: 0x00021AA0 File Offset: 0x00020EA0
		internal SQLiteIndexOutputs(int nConstraint)
		{
			this.constraintUsages = new global::System.Data.SQLite.SQLiteIndexConstraintUsage[nConstraint];
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00021AC0 File Offset: 0x00020EC0
		public global::System.Data.SQLite.SQLiteIndexConstraintUsage[] ConstraintUsages
		{
			get
			{
				return this.constraintUsages;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00021AD4 File Offset: 0x00020ED4
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00021AE8 File Offset: 0x00020EE8
		public int IndexNumber
		{
			get
			{
				return this.indexNumber;
			}
			set
			{
				this.indexNumber = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00021AFC File Offset: 0x00020EFC
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00021B10 File Offset: 0x00020F10
		public string IndexString
		{
			get
			{
				return this.indexString;
			}
			set
			{
				this.indexString = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00021B24 File Offset: 0x00020F24
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00021B38 File Offset: 0x00020F38
		public int NeedToFreeIndexString
		{
			get
			{
				return this.needToFreeIndexString;
			}
			set
			{
				this.needToFreeIndexString = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00021B4C File Offset: 0x00020F4C
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00021B60 File Offset: 0x00020F60
		public int OrderByConsumed
		{
			get
			{
				return this.orderByConsumed;
			}
			set
			{
				this.orderByConsumed = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00021B74 File Offset: 0x00020F74
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00021B88 File Offset: 0x00020F88
		public double? EstimatedCost
		{
			get
			{
				return this.estimatedCost;
			}
			set
			{
				this.estimatedCost = value;
			}
		}

		// Token: 0x0400020B RID: 523
		private global::System.Data.SQLite.SQLiteIndexConstraintUsage[] constraintUsages;

		// Token: 0x0400020C RID: 524
		private int indexNumber;

		// Token: 0x0400020D RID: 525
		private string indexString;

		// Token: 0x0400020E RID: 526
		private int needToFreeIndexString;

		// Token: 0x0400020F RID: 527
		private int orderByConsumed;

		// Token: 0x04000210 RID: 528
		private double? estimatedCost;
	}
}
