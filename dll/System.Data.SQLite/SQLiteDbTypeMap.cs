using System;
using System.Collections.Generic;

namespace System.Data.SQLite
{
	// Token: 0x02000030 RID: 48
	internal sealed class SQLiteDbTypeMap : global::System.Collections.Generic.Dictionary<string, global::System.Data.SQLite.SQLiteDbTypeMapping>
	{
		// Token: 0x06000292 RID: 658 RVA: 0x0001A410 File Offset: 0x00019810
		private SQLiteDbTypeMap() : base(new global::System.Data.SQLite.TypeNameStringComparer())
		{
			this.reverse = new global::System.Collections.Generic.Dictionary<global::System.Data.DbType, global::System.Data.SQLite.SQLiteDbTypeMapping>();
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0001A434 File Offset: 0x00019834
		public SQLiteDbTypeMap(global::System.Collections.Generic.IEnumerable<global::System.Data.SQLite.SQLiteDbTypeMapping> collection) : this()
		{
			this.Add(collection);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001A450 File Offset: 0x00019850
		public void Add(global::System.Collections.Generic.IEnumerable<global::System.Data.SQLite.SQLiteDbTypeMapping> collection)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			foreach (global::System.Data.SQLite.SQLiteDbTypeMapping item in collection)
			{
				this.Add(item);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0001A4B4 File Offset: 0x000198B4
		public void Add(global::System.Data.SQLite.SQLiteDbTypeMapping item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			if (item.typeName == null)
			{
				throw new global::System.ArgumentException("item type name cannot be null");
			}
			base.Add(item.typeName, item);
			if (item.primary)
			{
				this.reverse.Add(item.dataType, item);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001A50C File Offset: 0x0001990C
		public bool TryGetValue(global::System.Data.DbType key, out global::System.Data.SQLite.SQLiteDbTypeMapping value)
		{
			if (this.reverse == null)
			{
				value = null;
				return false;
			}
			return this.reverse.TryGetValue(key, out value);
		}

		// Token: 0x0400012A RID: 298
		private global::System.Collections.Generic.Dictionary<global::System.Data.DbType, global::System.Data.SQLite.SQLiteDbTypeMapping> reverse;
	}
}
