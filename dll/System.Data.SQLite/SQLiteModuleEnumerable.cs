using System;
using System.Collections;
using System.Globalization;

namespace System.Data.SQLite
{
	// Token: 0x0200008A RID: 138
	public class SQLiteModuleEnumerable : global::System.Data.SQLite.SQLiteModuleNoop
	{
		// Token: 0x0600060F RID: 1551 RVA: 0x00024D00 File Offset: 0x00024100
		public SQLiteModuleEnumerable(string name, global::System.Collections.IEnumerable enumerable) : base(name)
		{
			if (enumerable == null)
			{
				throw new global::System.ArgumentNullException("enumerable");
			}
			this.enumerable = enumerable;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00024D2C File Offset: 0x0002412C
		protected virtual string GetSqlForDeclareTable()
		{
			return global::System.Data.SQLite.SQLiteModuleEnumerable.declareSql;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00024D40 File Offset: 0x00024140
		protected virtual global::System.Data.SQLite.SQLiteErrorCode CursorTypeMismatchError(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor)
		{
			this.SetCursorError(cursor, "not an \"enumerator\" cursor");
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00024D5C File Offset: 0x0002415C
		protected virtual global::System.Data.SQLite.SQLiteErrorCode CursorEndOfEnumeratorError(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor)
		{
			this.SetCursorError(cursor, "already hit end of enumerator");
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00024D78 File Offset: 0x00024178
		protected virtual string GetStringFromObject(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, object value)
		{
			if (value == null)
			{
				return null;
			}
			if (value is string)
			{
				return (string)value;
			}
			return value.ToString();
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00024DA0 File Offset: 0x000241A0
		protected virtual long MakeRowId(int rowIndex, int hashCode)
		{
			long num = (long)rowIndex;
			num <<= 32;
			return num | (long)((ulong)hashCode);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00024DBC File Offset: 0x000241BC
		protected virtual long GetRowIdFromObject(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, object value)
		{
			if (cursor != null && value != null)
			{
				return this.MakeRowId(cursor.GetRowIndex(), value.GetHashCode());
			}
			if (cursor != null)
			{
				return (long)cursor.GetRowIndex();
			}
			if (value != null)
			{
				return (long)value.GetHashCode();
			}
			return 0L;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00024DFC File Offset: 0x000241FC
		public override global::System.Data.SQLite.SQLiteErrorCode Create(global::System.Data.SQLite.SQLiteConnection connection, global::System.IntPtr pClientData, string[] arguments, ref global::System.Data.SQLite.SQLiteVirtualTable table, ref string error)
		{
			this.CheckDisposed();
			if (this.DeclareTable(connection, this.GetSqlForDeclareTable(), ref error) == global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				table = new global::System.Data.SQLite.SQLiteVirtualTable(arguments);
				return global::System.Data.SQLite.SQLiteErrorCode.Ok;
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00024E2C File Offset: 0x0002422C
		public override global::System.Data.SQLite.SQLiteErrorCode Connect(global::System.Data.SQLite.SQLiteConnection connection, global::System.IntPtr pClientData, string[] arguments, ref global::System.Data.SQLite.SQLiteVirtualTable table, ref string error)
		{
			this.CheckDisposed();
			if (this.DeclareTable(connection, this.GetSqlForDeclareTable(), ref error) == global::System.Data.SQLite.SQLiteErrorCode.Ok)
			{
				table = new global::System.Data.SQLite.SQLiteVirtualTable(arguments);
				return global::System.Data.SQLite.SQLiteErrorCode.Ok;
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00024E5C File Offset: 0x0002425C
		public override global::System.Data.SQLite.SQLiteErrorCode BestIndex(global::System.Data.SQLite.SQLiteVirtualTable table, global::System.Data.SQLite.SQLiteIndex index)
		{
			this.CheckDisposed();
			if (!table.BestIndex(index))
			{
				this.SetTableError(table, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "failed to select best index for virtual table \"{0}\"", new object[]
				{
					table.TableName
				}));
				return global::System.Data.SQLite.SQLiteErrorCode.Error;
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00024EA4 File Offset: 0x000242A4
		public override global::System.Data.SQLite.SQLiteErrorCode Disconnect(global::System.Data.SQLite.SQLiteVirtualTable table)
		{
			this.CheckDisposed();
			table.Dispose();
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00024EC0 File Offset: 0x000242C0
		public override global::System.Data.SQLite.SQLiteErrorCode Destroy(global::System.Data.SQLite.SQLiteVirtualTable table)
		{
			this.CheckDisposed();
			table.Dispose();
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00024EDC File Offset: 0x000242DC
		public override global::System.Data.SQLite.SQLiteErrorCode Open(global::System.Data.SQLite.SQLiteVirtualTable table, ref global::System.Data.SQLite.SQLiteVirtualTableCursor cursor)
		{
			this.CheckDisposed();
			cursor = new global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator(table, this.enumerable.GetEnumerator());
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00024F04 File Offset: 0x00024304
		public override global::System.Data.SQLite.SQLiteErrorCode Close(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor)
		{
			this.CheckDisposed();
			global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator sqliteVirtualTableCursorEnumerator = cursor as global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator;
			if (sqliteVirtualTableCursorEnumerator == null)
			{
				return this.CursorTypeMismatchError(cursor);
			}
			sqliteVirtualTableCursorEnumerator.Close();
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00024F30 File Offset: 0x00024330
		public override global::System.Data.SQLite.SQLiteErrorCode Filter(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, int indexNumber, string indexString, global::System.Data.SQLite.SQLiteValue[] values)
		{
			this.CheckDisposed();
			global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator sqliteVirtualTableCursorEnumerator = cursor as global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator;
			if (sqliteVirtualTableCursorEnumerator == null)
			{
				return this.CursorTypeMismatchError(cursor);
			}
			sqliteVirtualTableCursorEnumerator.Filter(indexNumber, indexString, values);
			sqliteVirtualTableCursorEnumerator.Reset();
			sqliteVirtualTableCursorEnumerator.MoveNext();
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00024F70 File Offset: 0x00024370
		public override global::System.Data.SQLite.SQLiteErrorCode Next(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor)
		{
			this.CheckDisposed();
			global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator sqliteVirtualTableCursorEnumerator = cursor as global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator;
			if (sqliteVirtualTableCursorEnumerator == null)
			{
				return this.CursorTypeMismatchError(cursor);
			}
			if (sqliteVirtualTableCursorEnumerator.EndOfEnumerator)
			{
				return this.CursorEndOfEnumeratorError(cursor);
			}
			sqliteVirtualTableCursorEnumerator.MoveNext();
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00024FB0 File Offset: 0x000243B0
		public override bool Eof(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor)
		{
			this.CheckDisposed();
			global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator sqliteVirtualTableCursorEnumerator = cursor as global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator;
			if (sqliteVirtualTableCursorEnumerator == null)
			{
				return this.ResultCodeToEofResult(this.CursorTypeMismatchError(cursor));
			}
			return sqliteVirtualTableCursorEnumerator.EndOfEnumerator;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00024FE4 File Offset: 0x000243E4
		public override global::System.Data.SQLite.SQLiteErrorCode Column(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, global::System.Data.SQLite.SQLiteContext context, int index)
		{
			this.CheckDisposed();
			global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator sqliteVirtualTableCursorEnumerator = cursor as global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator;
			if (sqliteVirtualTableCursorEnumerator == null)
			{
				return this.CursorTypeMismatchError(cursor);
			}
			if (sqliteVirtualTableCursorEnumerator.EndOfEnumerator)
			{
				return this.CursorEndOfEnumeratorError(cursor);
			}
			object obj = sqliteVirtualTableCursorEnumerator.Current;
			if (obj != null)
			{
				context.SetString(this.GetStringFromObject(cursor, obj));
			}
			else
			{
				context.SetNull();
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0002503C File Offset: 0x0002443C
		public override global::System.Data.SQLite.SQLiteErrorCode RowId(global::System.Data.SQLite.SQLiteVirtualTableCursor cursor, ref long rowId)
		{
			this.CheckDisposed();
			global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator sqliteVirtualTableCursorEnumerator = cursor as global::System.Data.SQLite.SQLiteVirtualTableCursorEnumerator;
			if (sqliteVirtualTableCursorEnumerator == null)
			{
				return this.CursorTypeMismatchError(cursor);
			}
			if (sqliteVirtualTableCursorEnumerator.EndOfEnumerator)
			{
				return this.CursorEndOfEnumeratorError(cursor);
			}
			object value = sqliteVirtualTableCursorEnumerator.Current;
			rowId = this.GetRowIdFromObject(cursor, value);
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00025084 File Offset: 0x00024484
		public override global::System.Data.SQLite.SQLiteErrorCode Update(global::System.Data.SQLite.SQLiteVirtualTable table, global::System.Data.SQLite.SQLiteValue[] values, ref long rowId)
		{
			this.CheckDisposed();
			this.SetTableError(table, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "virtual table \"{0}\" is read-only", new object[]
			{
				table.TableName
			}));
			return global::System.Data.SQLite.SQLiteErrorCode.Error;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000250C0 File Offset: 0x000244C0
		public override global::System.Data.SQLite.SQLiteErrorCode Rename(global::System.Data.SQLite.SQLiteVirtualTable table, string newName)
		{
			this.CheckDisposed();
			if (!table.Rename(newName))
			{
				this.SetTableError(table, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "failed to rename virtual table from \"{0}\" to \"{1}\"", new object[]
				{
					table.TableName,
					newName
				}));
				return global::System.Data.SQLite.SQLiteErrorCode.Error;
			}
			return global::System.Data.SQLite.SQLiteErrorCode.Ok;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0002510C File Offset: 0x0002450C
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteModuleEnumerable).Name);
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00025138 File Offset: 0x00024538
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = this.disposed;
			}
			finally
			{
				base.Dispose(disposing);
				this.disposed = true;
			}
		}

		// Token: 0x0400023A RID: 570
		private static readonly string declareSql = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "CREATE TABLE {0}(x);", new object[]
		{
			typeof(global::System.Data.SQLite.SQLiteModuleEnumerable).Name
		});

		// Token: 0x0400023B RID: 571
		private global::System.Collections.IEnumerable enumerable;

		// Token: 0x0400023C RID: 572
		private bool disposed;
	}
}
