using System;

namespace System.Data.SQLite
{
	// Token: 0x02000020 RID: 32
	public class UpdateEventArgs : global::System.EventArgs
	{
		// Token: 0x06000242 RID: 578 RVA: 0x00019208 File Offset: 0x00018608
		internal UpdateEventArgs(string database, string table, global::System.Data.SQLite.UpdateEventType eventType, long rowid)
		{
			this.Database = database;
			this.Table = table;
			this.Event = eventType;
			this.RowId = rowid;
		}

		// Token: 0x040000BF RID: 191
		public readonly string Database;

		// Token: 0x040000C0 RID: 192
		public readonly string Table;

		// Token: 0x040000C1 RID: 193
		public readonly global::System.Data.SQLite.UpdateEventType Event;

		// Token: 0x040000C2 RID: 194
		public readonly long RowId;
	}
}
