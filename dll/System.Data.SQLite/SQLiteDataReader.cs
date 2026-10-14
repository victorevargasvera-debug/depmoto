using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Common;
using System.Globalization;

namespace System.Data.SQLite
{
	// Token: 0x02000034 RID: 52
	public sealed class SQLiteDataReader : global::System.Data.Common.DbDataReader
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x0001A9D0 File Offset: 0x00019DD0
		internal SQLiteDataReader(global::System.Data.SQLite.SQLiteCommand cmd, global::System.Data.CommandBehavior behave)
		{
			this._throwOnDisposed = true;
			this._command = cmd;
			this._version = this._command.Connection._version;
			this._baseSchemaName = this._command.Connection._baseSchemaName;
			this._commandBehavior = behave;
			this._activeStatementIndex = -1;
			this._rowsAffected = -1;
			if (this._command != null)
			{
				global::System.Data.SQLite.SQLiteConnection.OnChanged(this._command.Connection, new global::System.Data.SQLite.ConnectionEventArgs(global::System.Data.SQLite.SQLiteConnectionEventType.NewDataReader, null, null, this._command, this, null, null, new object[]
				{
					behave
				}));
				this.NextResult();
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0001AA74 File Offset: 0x00019E74
		private void CheckDisposed()
		{
			if (this.disposed && this._throwOnDisposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteDataReader).Name);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0001AAA8 File Offset: 0x00019EA8
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this.disposed)
				{
					this._throwOnDisposed = false;
				}
			}
			finally
			{
				base.Dispose(disposing);
				this.disposed = true;
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0001AAF4 File Offset: 0x00019EF4
		internal void Cancel()
		{
			this._version = 0L;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0001AB0C File Offset: 0x00019F0C
		public override void Close()
		{
			this.CheckDisposed();
			try
			{
				if (this._command != null)
				{
					try
					{
						try
						{
							if (this._version != 0L)
							{
								try
								{
									while (this.NextResult())
									{
									}
								}
								catch (global::System.Data.SQLite.SQLiteException)
								{
								}
							}
							this._command.ClearDataReader();
						}
						finally
						{
							if ((this._commandBehavior & global::System.Data.CommandBehavior.CloseConnection) != global::System.Data.CommandBehavior.Default && this._command.Connection != null)
							{
								this._command.Connection.Close();
							}
						}
					}
					finally
					{
						if (this._disposeCommand)
						{
							this._command.Dispose();
						}
					}
				}
				this._command = null;
				this._activeStatement = null;
				this._fieldIndexes = null;
				this._fieldTypeArray = null;
			}
			finally
			{
				if (this._keyInfo != null)
				{
					this._keyInfo.Dispose();
					this._keyInfo = null;
				}
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0001AC28 File Offset: 0x0001A028
		private void CheckClosed()
		{
			if (!this._throwOnDisposed)
			{
				return;
			}
			if (this._command == null)
			{
				throw new global::System.InvalidOperationException("DataReader has been closed");
			}
			if (this._version == 0L)
			{
				throw new global::System.Data.SQLite.SQLiteException("Execution was aborted by the user");
			}
			if (this._command.Connection.State != global::System.Data.ConnectionState.Open || this._command.Connection._version != this._version)
			{
				throw new global::System.InvalidOperationException("Connection was closed, statement was terminated");
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0001AC9C File Offset: 0x0001A09C
		private void CheckValidRow()
		{
			if (this._readingState != 0)
			{
				throw new global::System.InvalidOperationException("No current row");
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0001ACBC File Offset: 0x0001A0BC
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			this.CheckDisposed();
			return new global::System.Data.Common.DbEnumerator(this, (this._commandBehavior & global::System.Data.CommandBehavior.CloseConnection) == global::System.Data.CommandBehavior.CloseConnection);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0001ACE4 File Offset: 0x0001A0E4
		public override int Depth
		{
			get
			{
				this.CheckDisposed();
				this.CheckClosed();
				return 0;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0001AD00 File Offset: 0x0001A100
		public override int FieldCount
		{
			get
			{
				this.CheckDisposed();
				this.CheckClosed();
				if (this._keyInfo == null)
				{
					return this._fieldCount;
				}
				return this._fieldCount + this._keyInfo.Count;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0001AD3C File Offset: 0x0001A13C
		public override int VisibleFieldCount
		{
			get
			{
				this.CheckDisposed();
				this.CheckClosed();
				return this._fieldCount;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0001AD5C File Offset: 0x0001A15C
		private global::System.Data.SQLite.TypeAffinity VerifyType(int i, global::System.Data.DbType typ)
		{
			this.CheckClosed();
			this.CheckValidRow();
			global::System.Data.SQLite.TypeAffinity affinity = this.GetSQLiteType(i).Affinity;
			switch (affinity)
			{
			case global::System.Data.SQLite.TypeAffinity.Int64:
				if (typ == global::System.Data.DbType.Int16)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.Int32)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.Int64)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.Boolean)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.Byte)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.DateTime)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.Single)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.Double)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.Decimal)
				{
					return affinity;
				}
				break;
			case global::System.Data.SQLite.TypeAffinity.Double:
				if (typ == global::System.Data.DbType.Single)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.Double)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.Decimal)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.DateTime)
				{
					return affinity;
				}
				break;
			case global::System.Data.SQLite.TypeAffinity.Text:
				if (typ == global::System.Data.DbType.SByte)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.String)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.SByte)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.Guid)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.DateTime)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.Decimal)
				{
					return affinity;
				}
				break;
			case global::System.Data.SQLite.TypeAffinity.Blob:
				if (typ == global::System.Data.DbType.Guid)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.String)
				{
					return affinity;
				}
				if (typ == global::System.Data.DbType.Binary)
				{
					return affinity;
				}
				break;
			}
			throw new global::System.InvalidCastException();
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0001AE38 File Offset: 0x0001A238
		public override bool GetBoolean(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetBoolean(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, global::System.Data.DbType.Boolean);
			return global::System.Convert.ToBoolean(this.GetValue(i), global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0001AE8C File Offset: 0x0001A28C
		public override byte GetByte(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetByte(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, global::System.Data.DbType.Byte);
			return global::System.Convert.ToByte(this._activeStatement._sql.GetInt32(this._activeStatement, i));
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0001AEEC File Offset: 0x0001A2EC
		public override long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetBytes(i - this.VisibleFieldCount, fieldOffset, buffer, bufferoffset, length);
			}
			this.VerifyType(i, global::System.Data.DbType.Binary);
			return this._activeStatement._sql.GetBytes(this._activeStatement, i, (int)fieldOffset, buffer, bufferoffset, length);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0001AF54 File Offset: 0x0001A354
		public override char GetChar(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetChar(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, global::System.Data.DbType.SByte);
			return global::System.Convert.ToChar(this._activeStatement._sql.GetInt32(this._activeStatement, i));
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0001AFB4 File Offset: 0x0001A3B4
		public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetChars(i - this.VisibleFieldCount, fieldoffset, buffer, bufferoffset, length);
			}
			this.VerifyType(i, global::System.Data.DbType.String);
			return this._activeStatement._sql.GetChars(this._activeStatement, i, (int)fieldoffset, buffer, bufferoffset, length);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0001B01C File Offset: 0x0001A41C
		public override string GetDataTypeName(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetDataTypeName(i - this.VisibleFieldCount);
			}
			global::System.Data.SQLite.SQLiteType sqliteType = this.GetSQLiteType(i);
			if (sqliteType.Type == global::System.Data.DbType.Object)
			{
				return global::System.Data.SQLite.SQLiteConvert.SQLiteTypeToType(sqliteType).Name;
			}
			return this._activeStatement._sql.ColumnType(this._activeStatement, i, out sqliteType.Affinity);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0001B090 File Offset: 0x0001A490
		public override global::System.DateTime GetDateTime(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetDateTime(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, global::System.Data.DbType.DateTime);
			return this._activeStatement._sql.GetDateTime(this._activeStatement, i);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0001B0E8 File Offset: 0x0001A4E8
		public override decimal GetDecimal(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetDecimal(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, global::System.Data.DbType.Decimal);
			return decimal.Parse(this._activeStatement._sql.GetText(this._activeStatement, i), global::System.Globalization.NumberStyles.AllowLeadingSign | global::System.Globalization.NumberStyles.AllowDecimalPoint | global::System.Globalization.NumberStyles.AllowExponent, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0001B150 File Offset: 0x0001A550
		public override double GetDouble(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetDouble(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, global::System.Data.DbType.Double);
			return this._activeStatement._sql.GetDouble(this._activeStatement, i);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0001B1A8 File Offset: 0x0001A5A8
		public override global::System.Type GetFieldType(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetFieldType(i - this.VisibleFieldCount);
			}
			return global::System.Data.SQLite.SQLiteConvert.SQLiteTypeToType(this.GetSQLiteType(i));
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0001B1EC File Offset: 0x0001A5EC
		public override float GetFloat(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetFloat(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, global::System.Data.DbType.Single);
			return global::System.Convert.ToSingle(this._activeStatement._sql.GetDouble(this._activeStatement, i));
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0001B24C File Offset: 0x0001A64C
		public override global::System.Guid GetGuid(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetGuid(i - this.VisibleFieldCount);
			}
			global::System.Data.SQLite.TypeAffinity typeAffinity = this.VerifyType(i, global::System.Data.DbType.Guid);
			if (typeAffinity == global::System.Data.SQLite.TypeAffinity.Blob)
			{
				byte[] array = new byte[16];
				this._activeStatement._sql.GetBytes(this._activeStatement, i, 0, array, 0, 16);
				return new global::System.Guid(array);
			}
			return new global::System.Guid(this._activeStatement._sql.GetText(this._activeStatement, i));
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0001B2DC File Offset: 0x0001A6DC
		public override short GetInt16(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetInt16(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, global::System.Data.DbType.Int16);
			return global::System.Convert.ToInt16(this._activeStatement._sql.GetInt32(this._activeStatement, i));
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0001B33C File Offset: 0x0001A73C
		public override int GetInt32(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetInt32(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, global::System.Data.DbType.Int32);
			return this._activeStatement._sql.GetInt32(this._activeStatement, i);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0001B398 File Offset: 0x0001A798
		public override long GetInt64(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetInt64(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, global::System.Data.DbType.Int64);
			return this._activeStatement._sql.GetInt64(this._activeStatement, i);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0001B3F4 File Offset: 0x0001A7F4
		public override string GetName(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetName(i - this.VisibleFieldCount);
			}
			return this._activeStatement._sql.ColumnName(this._activeStatement, i);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0001B444 File Offset: 0x0001A844
		public override int GetOrdinal(string name)
		{
			this.CheckDisposed();
			this.CheckClosed();
			bool throwOnDisposed = this._throwOnDisposed;
			if (this._fieldIndexes == null)
			{
				this._fieldIndexes = new global::System.Collections.Generic.Dictionary<string, int>(new global::System.Data.SQLite.SQLiteDataReader.ColumnNameComparer());
			}
			int num;
			if (!this._fieldIndexes.TryGetValue(name, out num))
			{
				num = this._activeStatement._sql.ColumnIndex(this._activeStatement, name);
				if (num == -1 && this._keyInfo != null)
				{
					num = this._keyInfo.GetOrdinal(name);
					if (num > -1)
					{
						num += this.VisibleFieldCount;
					}
				}
				this._fieldIndexes.Add(name, num);
			}
			return num;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0001B4D8 File Offset: 0x0001A8D8
		public override global::System.Data.DataTable GetSchemaTable()
		{
			this.CheckDisposed();
			return this.GetSchemaTable(true, false);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0001B4F4 File Offset: 0x0001A8F4
		private static void GetStatementColumnParents(global::System.Data.SQLite.SQLiteBase sql, global::System.Data.SQLite.SQLiteStatement stmt, int fieldCount, ref global::System.Collections.Generic.Dictionary<global::System.Data.SQLite.SQLiteDataReader.ColumnParent, global::System.Collections.Generic.List<int>> parentToColumns, ref global::System.Collections.Generic.Dictionary<int, global::System.Data.SQLite.SQLiteDataReader.ColumnParent> columnToParent)
		{
			if (parentToColumns == null)
			{
				parentToColumns = new global::System.Collections.Generic.Dictionary<global::System.Data.SQLite.SQLiteDataReader.ColumnParent, global::System.Collections.Generic.List<int>>(new global::System.Data.SQLite.SQLiteDataReader.ColumnParent());
			}
			if (columnToParent == null)
			{
				columnToParent = new global::System.Collections.Generic.Dictionary<int, global::System.Data.SQLite.SQLiteDataReader.ColumnParent>();
			}
			for (int i = 0; i < fieldCount; i++)
			{
				string databaseName = sql.ColumnDatabaseName(stmt, i);
				string tableName = sql.ColumnTableName(stmt, i);
				string columnName = sql.ColumnOriginalName(stmt, i);
				global::System.Data.SQLite.SQLiteDataReader.ColumnParent key = new global::System.Data.SQLite.SQLiteDataReader.ColumnParent(databaseName, tableName, null);
				global::System.Data.SQLite.SQLiteDataReader.ColumnParent value = new global::System.Data.SQLite.SQLiteDataReader.ColumnParent(databaseName, tableName, columnName);
				if (!parentToColumns.ContainsKey(key))
				{
					parentToColumns.Add(key, new global::System.Collections.Generic.List<int>(new int[]
					{
						i
					}));
				}
				else
				{
					parentToColumns[key].Add(i);
				}
				columnToParent.Add(i, value);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0001B5A0 File Offset: 0x0001A9A0
		internal global::System.Data.DataTable GetSchemaTable(bool wantUniqueInfo, bool wantDefaultValue)
		{
			this.CheckClosed();
			bool throwOnDisposed = this._throwOnDisposed;
			global::System.Collections.Generic.Dictionary<global::System.Data.SQLite.SQLiteDataReader.ColumnParent, global::System.Collections.Generic.List<int>> dictionary = null;
			global::System.Collections.Generic.Dictionary<int, global::System.Data.SQLite.SQLiteDataReader.ColumnParent> dictionary2 = null;
			global::System.Data.SQLite.SQLiteDataReader.GetStatementColumnParents(this._command.Connection._sql, this._activeStatement, this._fieldCount, ref dictionary, ref dictionary2);
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("SchemaTable");
			global::System.Data.DataTable dataTable2 = null;
			string b = "";
			string b2 = "";
			string text = "";
			dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.ColumnName, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.ColumnOrdinal, typeof(int));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.ColumnSize, typeof(int));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.NumericPrecision, typeof(short));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.NumericScale, typeof(short));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.IsUnique, typeof(bool));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.IsKey, typeof(bool));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableOptionalColumn.BaseServerName, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableOptionalColumn.BaseCatalogName, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.BaseColumnName, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.BaseSchemaName, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.BaseTableName, typeof(string));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.DataType, typeof(global::System.Type));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.AllowDBNull, typeof(bool));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.ProviderType, typeof(int));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.IsAliased, typeof(bool));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.IsExpression, typeof(bool));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableOptionalColumn.IsAutoIncrement, typeof(bool));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableOptionalColumn.IsRowVersion, typeof(bool));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableOptionalColumn.IsHidden, typeof(bool));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableColumn.IsLong, typeof(bool));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableOptionalColumn.IsReadOnly, typeof(bool));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableOptionalColumn.ProviderSpecificDataType, typeof(global::System.Type));
			dataTable.Columns.Add(global::System.Data.Common.SchemaTableOptionalColumn.DefaultValue, typeof(object));
			dataTable.Columns.Add("DataTypeName", typeof(string));
			dataTable.Columns.Add("CollationType", typeof(string));
			dataTable.BeginLoadData();
			for (int i = 0; i < this._fieldCount; i++)
			{
				global::System.Data.SQLite.SQLiteType sqliteType = this.GetSQLiteType(i);
				global::System.Data.DataRow dataRow = dataTable.NewRow();
				global::System.Data.DbType type = sqliteType.Type;
				dataRow[global::System.Data.Common.SchemaTableColumn.ColumnName] = this.GetName(i);
				dataRow[global::System.Data.Common.SchemaTableColumn.ColumnOrdinal] = i;
				dataRow[global::System.Data.Common.SchemaTableColumn.ColumnSize] = global::System.Data.SQLite.SQLiteConvert.DbTypeToColumnSize(type);
				dataRow[global::System.Data.Common.SchemaTableColumn.NumericPrecision] = global::System.Data.SQLite.SQLiteConvert.DbTypeToNumericPrecision(type);
				dataRow[global::System.Data.Common.SchemaTableColumn.NumericScale] = global::System.Data.SQLite.SQLiteConvert.DbTypeToNumericScale(type);
				dataRow[global::System.Data.Common.SchemaTableColumn.ProviderType] = sqliteType.Type;
				dataRow[global::System.Data.Common.SchemaTableColumn.IsLong] = false;
				dataRow[global::System.Data.Common.SchemaTableColumn.AllowDBNull] = true;
				dataRow[global::System.Data.Common.SchemaTableOptionalColumn.IsReadOnly] = false;
				dataRow[global::System.Data.Common.SchemaTableOptionalColumn.IsRowVersion] = false;
				dataRow[global::System.Data.Common.SchemaTableColumn.IsUnique] = false;
				dataRow[global::System.Data.Common.SchemaTableColumn.IsKey] = false;
				dataRow[global::System.Data.Common.SchemaTableOptionalColumn.IsAutoIncrement] = false;
				dataRow[global::System.Data.Common.SchemaTableColumn.DataType] = this.GetFieldType(i);
				dataRow[global::System.Data.Common.SchemaTableOptionalColumn.IsHidden] = false;
				dataRow[global::System.Data.Common.SchemaTableColumn.BaseSchemaName] = this._baseSchemaName;
				text = dictionary2[i].ColumnName;
				if (!string.IsNullOrEmpty(text))
				{
					dataRow[global::System.Data.Common.SchemaTableColumn.BaseColumnName] = text;
				}
				dataRow[global::System.Data.Common.SchemaTableColumn.IsExpression] = string.IsNullOrEmpty(text);
				dataRow[global::System.Data.Common.SchemaTableColumn.IsAliased] = (string.Compare(this.GetName(i), text, global::System.StringComparison.OrdinalIgnoreCase) != 0);
				string value = dictionary2[i].TableName;
				if (!string.IsNullOrEmpty(value))
				{
					dataRow[global::System.Data.Common.SchemaTableColumn.BaseTableName] = value;
				}
				value = dictionary2[i].DatabaseName;
				if (!string.IsNullOrEmpty(value))
				{
					dataRow[global::System.Data.Common.SchemaTableOptionalColumn.BaseCatalogName] = value;
				}
				string text2 = null;
				if (!string.IsNullOrEmpty(text))
				{
					string value2;
					bool flag;
					bool flag2;
					bool flag3;
					this._command.Connection._sql.ColumnMetaData((string)dataRow[global::System.Data.Common.SchemaTableOptionalColumn.BaseCatalogName], (string)dataRow[global::System.Data.Common.SchemaTableColumn.BaseTableName], text, out text2, out value2, out flag, out flag2, out flag3);
					if (flag || flag2)
					{
						dataRow[global::System.Data.Common.SchemaTableColumn.AllowDBNull] = false;
					}
					dataRow[global::System.Data.Common.SchemaTableColumn.IsKey] = flag2;
					dataRow[global::System.Data.Common.SchemaTableOptionalColumn.IsAutoIncrement] = flag3;
					dataRow["CollationType"] = value2;
					string[] array = text2.Split(new char[]
					{
						'('
					});
					if (array.Length > 1)
					{
						text2 = array[0];
						array = array[1].Split(new char[]
						{
							')'
						});
						if (array.Length > 1)
						{
							array = array[0].Split(new char[]
							{
								',',
								'.'
							});
							if (sqliteType.Type == global::System.Data.DbType.Binary || sqliteType.Type == global::System.Data.DbType.String || sqliteType.Type == global::System.Data.DbType.AnsiStringFixedLength || sqliteType.Type == global::System.Data.DbType.StringFixedLength)
							{
								dataRow[global::System.Data.Common.SchemaTableColumn.ColumnSize] = global::System.Convert.ToInt32(array[0], global::System.Globalization.CultureInfo.InvariantCulture);
							}
							else
							{
								dataRow[global::System.Data.Common.SchemaTableColumn.NumericPrecision] = global::System.Convert.ToInt32(array[0], global::System.Globalization.CultureInfo.InvariantCulture);
								if (array.Length > 1)
								{
									dataRow[global::System.Data.Common.SchemaTableColumn.NumericScale] = global::System.Convert.ToInt32(array[1], global::System.Globalization.CultureInfo.InvariantCulture);
								}
							}
						}
					}
					if (wantDefaultValue)
					{
						using (global::System.Data.SQLite.SQLiteCommand sqliteCommand = new global::System.Data.SQLite.SQLiteCommand(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PRAGMA [{0}].TABLE_INFO([{1}])", new object[]
						{
							dataRow[global::System.Data.Common.SchemaTableOptionalColumn.BaseCatalogName],
							dataRow[global::System.Data.Common.SchemaTableColumn.BaseTableName]
						}), this._command.Connection))
						{
							using (global::System.Data.Common.DbDataReader dbDataReader = sqliteCommand.ExecuteReader())
							{
								while (dbDataReader.Read())
								{
									if (string.Compare((string)dataRow[global::System.Data.Common.SchemaTableColumn.BaseColumnName], dbDataReader.GetString(1), global::System.StringComparison.OrdinalIgnoreCase) == 0)
									{
										if (!dbDataReader.IsDBNull(4))
										{
											dataRow[global::System.Data.Common.SchemaTableOptionalColumn.DefaultValue] = dbDataReader[4];
											break;
										}
										break;
									}
								}
							}
						}
					}
					if (wantUniqueInfo)
					{
						if ((string)dataRow[global::System.Data.Common.SchemaTableOptionalColumn.BaseCatalogName] != b || (string)dataRow[global::System.Data.Common.SchemaTableColumn.BaseTableName] != b2)
						{
							b = (string)dataRow[global::System.Data.Common.SchemaTableOptionalColumn.BaseCatalogName];
							b2 = (string)dataRow[global::System.Data.Common.SchemaTableColumn.BaseTableName];
							global::System.Data.Common.DbConnection connection = this._command.Connection;
							string collectionName = "Indexes";
							string[] array2 = new string[4];
							array2[0] = (string)dataRow[global::System.Data.Common.SchemaTableOptionalColumn.BaseCatalogName];
							array2[2] = (string)dataRow[global::System.Data.Common.SchemaTableColumn.BaseTableName];
							dataTable2 = connection.GetSchema(collectionName, array2);
						}
						foreach (object obj in dataTable2.Rows)
						{
							global::System.Data.DataRow dataRow2 = (global::System.Data.DataRow)obj;
							global::System.Data.Common.DbConnection connection2 = this._command.Connection;
							string collectionName2 = "IndexColumns";
							string[] array3 = new string[5];
							array3[0] = (string)dataRow[global::System.Data.Common.SchemaTableOptionalColumn.BaseCatalogName];
							array3[2] = (string)dataRow[global::System.Data.Common.SchemaTableColumn.BaseTableName];
							array3[3] = (string)dataRow2["INDEX_NAME"];
							global::System.Data.DataTable schema = connection2.GetSchema(collectionName2, array3);
							foreach (object obj2 in schema.Rows)
							{
								global::System.Data.DataRow dataRow3 = (global::System.Data.DataRow)obj2;
								if (string.Compare((string)dataRow3["COLUMN_NAME"], text, global::System.StringComparison.OrdinalIgnoreCase) == 0)
								{
									if (dictionary.Count == 1 && schema.Rows.Count == 1 && !(bool)dataRow[global::System.Data.Common.SchemaTableColumn.AllowDBNull])
									{
										dataRow[global::System.Data.Common.SchemaTableColumn.IsUnique] = dataRow2["UNIQUE"];
									}
									if (schema.Rows.Count == 1 && (bool)dataRow2["PRIMARY_KEY"] && !string.IsNullOrEmpty(text2) && string.Compare(text2, "integer", global::System.StringComparison.OrdinalIgnoreCase) == 0)
									{
										break;
									}
									break;
								}
							}
						}
					}
					if (string.IsNullOrEmpty(text2))
					{
						global::System.Data.SQLite.TypeAffinity typeAffinity;
						text2 = this._activeStatement._sql.ColumnType(this._activeStatement, i, out typeAffinity);
					}
					if (!string.IsNullOrEmpty(text2))
					{
						dataRow["DataTypeName"] = text2;
					}
				}
				dataTable.Rows.Add(dataRow);
			}
			if (this._keyInfo != null)
			{
				this._keyInfo.AppendSchemaTable(dataTable);
			}
			dataTable.AcceptChanges();
			dataTable.EndLoadData();
			return dataTable;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0001C010 File Offset: 0x0001B410
		public override string GetString(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetString(i - this.VisibleFieldCount);
			}
			this.VerifyType(i, global::System.Data.DbType.String);
			return this._activeStatement._sql.GetText(this._activeStatement, i);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0001C06C File Offset: 0x0001B46C
		public override object GetValue(int i)
		{
			this.CheckDisposed();
			this.CheckValidRow();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.GetValue(i - this.VisibleFieldCount);
			}
			global::System.Data.SQLite.SQLiteType sqliteType = this.GetSQLiteType(i);
			return this._activeStatement._sql.GetValue(this._activeStatement, global::System.Data.SQLite.SQLiteCommand.GetFlags(this._command), i, sqliteType);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0001C0D8 File Offset: 0x0001B4D8
		public override int GetValues(object[] values)
		{
			this.CheckDisposed();
			int num = this.FieldCount;
			if (values.Length < num)
			{
				num = values.Length;
			}
			for (int i = 0; i < num; i++)
			{
				values[i] = this.GetValue(i);
			}
			return num;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0001C114 File Offset: 0x0001B514
		public global::System.Collections.Specialized.NameValueCollection GetValues()
		{
			this.CheckDisposed();
			if (this._activeStatement == null || this._activeStatement._sql == null)
			{
				throw new global::System.InvalidOperationException();
			}
			int visibleFieldCount = this.VisibleFieldCount;
			global::System.Collections.Specialized.NameValueCollection nameValueCollection = new global::System.Collections.Specialized.NameValueCollection(visibleFieldCount);
			for (int i = 0; i < visibleFieldCount; i++)
			{
				string name = this._activeStatement._sql.ColumnName(this._activeStatement, i);
				string text = this._activeStatement._sql.GetText(this._activeStatement, i);
				nameValueCollection.Add(name, text);
			}
			return nameValueCollection;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0001C198 File Offset: 0x0001B598
		public override bool HasRows
		{
			get
			{
				this.CheckDisposed();
				this.CheckClosed();
				return this._readingState != 1;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0001C1C0 File Offset: 0x0001B5C0
		public override bool IsClosed
		{
			get
			{
				this.CheckDisposed();
				return this._command == null;
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0001C1DC File Offset: 0x0001B5DC
		public override bool IsDBNull(int i)
		{
			this.CheckDisposed();
			if (i >= this.VisibleFieldCount && this._keyInfo != null)
			{
				return this._keyInfo.IsDBNull(i - this.VisibleFieldCount);
			}
			return this._activeStatement._sql.IsNull(this._activeStatement, i);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0001C22C File Offset: 0x0001B62C
		public override bool NextResult()
		{
			this.CheckDisposed();
			this.CheckClosed();
			bool throwOnDisposed = this._throwOnDisposed;
			global::System.Data.SQLite.SQLiteStatement sqliteStatement = null;
			bool flag = (this._commandBehavior & global::System.Data.CommandBehavior.SchemaOnly) != global::System.Data.CommandBehavior.Default;
			int num;
			for (;;)
			{
				if (sqliteStatement == null && this._activeStatement != null && this._activeStatement._sql != null && this._activeStatement._sql.IsOpen())
				{
					if (!flag)
					{
						this._activeStatement._sql.Reset(this._activeStatement);
					}
					if ((this._commandBehavior & global::System.Data.CommandBehavior.SingleResult) != global::System.Data.CommandBehavior.Default)
					{
						break;
					}
				}
				sqliteStatement = this._command.GetStatement(this._activeStatementIndex + 1);
				if (sqliteStatement == null)
				{
					return false;
				}
				if (this._readingState < 1)
				{
					this._readingState = 1;
				}
				this._activeStatementIndex++;
				num = sqliteStatement._sql.ColumnCount(sqliteStatement);
				if (flag && num != 0)
				{
					goto IL_1BF;
				}
				if (!flag && sqliteStatement._sql.Step(sqliteStatement))
				{
					goto Block_16;
				}
				if (num != 0)
				{
					goto IL_1B8;
				}
				if (this._rowsAffected == -1)
				{
					this._rowsAffected = 0;
				}
				int num2 = 0;
				if (!sqliteStatement.TryGetChanges(ref num2))
				{
					return false;
				}
				this._rowsAffected += num2;
				if (!flag)
				{
					sqliteStatement._sql.Reset(sqliteStatement);
				}
			}
			for (;;)
			{
				sqliteStatement = this._command.GetStatement(this._activeStatementIndex + 1);
				if (sqliteStatement == null)
				{
					return false;
				}
				this._activeStatementIndex++;
				if (!flag)
				{
					sqliteStatement._sql.Step(sqliteStatement);
				}
				if (sqliteStatement._sql.ColumnCount(sqliteStatement) == 0)
				{
					if (this._rowsAffected == -1)
					{
						this._rowsAffected = 0;
					}
					int num3 = 0;
					if (!sqliteStatement.TryGetChanges(ref num3))
					{
						break;
					}
					this._rowsAffected += num3;
				}
				if (!flag)
				{
					sqliteStatement._sql.Reset(sqliteStatement);
				}
			}
			return false;
			Block_16:
			this._readingState = -1;
			goto IL_1BF;
			IL_1B8:
			this._readingState = 1;
			IL_1BF:
			this._activeStatement = sqliteStatement;
			this._fieldCount = num;
			this._fieldIndexes = null;
			this._fieldTypeArray = null;
			if ((this._commandBehavior & global::System.Data.CommandBehavior.KeyInfo) != global::System.Data.CommandBehavior.Default)
			{
				this.LoadKeyInfo();
			}
			return true;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001C428 File Offset: 0x0001B828
		private global::System.Data.SQLite.SQLiteType GetSQLiteType(int i)
		{
			if (this._fieldTypeArray == null)
			{
				this._fieldTypeArray = new global::System.Data.SQLite.SQLiteType[this.VisibleFieldCount];
			}
			if (this._fieldTypeArray[i] == null)
			{
				this._fieldTypeArray[i] = new global::System.Data.SQLite.SQLiteType();
			}
			global::System.Data.SQLite.SQLiteType sqliteType = this._fieldTypeArray[i];
			if (sqliteType.Affinity == global::System.Data.SQLite.TypeAffinity.Uninitialized)
			{
				sqliteType.Type = global::System.Data.SQLite.SQLiteConvert.TypeNameToDbType(this._activeStatement._sql.ColumnType(this._activeStatement, i, out sqliteType.Affinity));
			}
			else
			{
				sqliteType.Affinity = this._activeStatement._sql.ColumnAffinity(this._activeStatement, i);
			}
			return sqliteType;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0001C4C0 File Offset: 0x0001B8C0
		public override bool Read()
		{
			this.CheckDisposed();
			this.CheckClosed();
			bool throwOnDisposed = this._throwOnDisposed;
			if ((this._commandBehavior & global::System.Data.CommandBehavior.SchemaOnly) != global::System.Data.CommandBehavior.Default)
			{
				return false;
			}
			if (this._readingState == -1)
			{
				this._readingState = 0;
				return true;
			}
			if (this._readingState == 0)
			{
				if ((this._commandBehavior & global::System.Data.CommandBehavior.SingleRow) == global::System.Data.CommandBehavior.Default && this._activeStatement._sql.Step(this._activeStatement))
				{
					if (this._keyInfo != null)
					{
						this._keyInfo.Reset();
					}
					return true;
				}
				this._readingState = 1;
			}
			return false;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0001C548 File Offset: 0x0001B948
		public override int RecordsAffected
		{
			get
			{
				this.CheckDisposed();
				if (this._rowsAffected >= 0)
				{
					return this._rowsAffected;
				}
				return 0;
			}
		}

		// Token: 0x17000068 RID: 104
		public override object this[string name]
		{
			get
			{
				this.CheckDisposed();
				return this.GetValue(this.GetOrdinal(name));
			}
		}

		// Token: 0x17000069 RID: 105
		public override object this[int i]
		{
			get
			{
				this.CheckDisposed();
				return this.GetValue(i);
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0001C5A8 File Offset: 0x0001B9A8
		private void LoadKeyInfo()
		{
			if (this._keyInfo != null)
			{
				this._keyInfo.Dispose();
				this._keyInfo = null;
			}
			this._keyInfo = new global::System.Data.SQLite.SQLiteKeyReader(this._command.Connection, this, this._activeStatement);
		}

		// Token: 0x04000132 RID: 306
		private global::System.Data.SQLite.SQLiteCommand _command;

		// Token: 0x04000133 RID: 307
		private int _activeStatementIndex;

		// Token: 0x04000134 RID: 308
		private global::System.Data.SQLite.SQLiteStatement _activeStatement;

		// Token: 0x04000135 RID: 309
		private int _readingState;

		// Token: 0x04000136 RID: 310
		private int _rowsAffected;

		// Token: 0x04000137 RID: 311
		private int _fieldCount;

		// Token: 0x04000138 RID: 312
		private global::System.Collections.Generic.Dictionary<string, int> _fieldIndexes;

		// Token: 0x04000139 RID: 313
		private global::System.Data.SQLite.SQLiteType[] _fieldTypeArray;

		// Token: 0x0400013A RID: 314
		private global::System.Data.CommandBehavior _commandBehavior;

		// Token: 0x0400013B RID: 315
		internal bool _disposeCommand;

		// Token: 0x0400013C RID: 316
		internal bool _throwOnDisposed;

		// Token: 0x0400013D RID: 317
		private global::System.Data.SQLite.SQLiteKeyReader _keyInfo;

		// Token: 0x0400013E RID: 318
		internal long _version;

		// Token: 0x0400013F RID: 319
		private string _baseSchemaName;

		// Token: 0x04000140 RID: 320
		private bool disposed;

		// Token: 0x02000035 RID: 53
		private sealed class ColumnNameComparer : global::System.Collections.Generic.IEqualityComparer<string>
		{
			// Token: 0x060002E0 RID: 736 RVA: 0x0001C5EC File Offset: 0x0001B9EC
			public bool Equals(string x, string y)
			{
				return (x == null && y == null) || (x != null && y != null && string.Equals(x, y, global::System.StringComparison.OrdinalIgnoreCase));
			}

			// Token: 0x060002E1 RID: 737 RVA: 0x0001C614 File Offset: 0x0001BA14
			public int GetHashCode(string obj)
			{
				if (obj == null)
				{
					return 0;
				}
				return obj.GetHashCode();
			}
		}

		// Token: 0x02000036 RID: 54
		private sealed class ColumnParent : global::System.Collections.Generic.IEqualityComparer<global::System.Data.SQLite.SQLiteDataReader.ColumnParent>
		{
			// Token: 0x060002E3 RID: 739 RVA: 0x0001C640 File Offset: 0x0001BA40
			public ColumnParent()
			{
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x0001C654 File Offset: 0x0001BA54
			public ColumnParent(string databaseName, string tableName, string columnName) : this()
			{
				this.DatabaseName = databaseName;
				this.TableName = tableName;
				this.ColumnName = columnName;
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x0001C67C File Offset: 0x0001BA7C
			public bool Equals(global::System.Data.SQLite.SQLiteDataReader.ColumnParent x, global::System.Data.SQLite.SQLiteDataReader.ColumnParent y)
			{
				return (x == null && y == null) || (x != null && y != null && string.Equals(x.DatabaseName, y.DatabaseName, global::System.StringComparison.OrdinalIgnoreCase) && string.Equals(x.TableName, y.TableName, global::System.StringComparison.OrdinalIgnoreCase) && string.Equals(x.ColumnName, y.ColumnName, global::System.StringComparison.OrdinalIgnoreCase));
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x0001C6DC File Offset: 0x0001BADC
			public int GetHashCode(global::System.Data.SQLite.SQLiteDataReader.ColumnParent obj)
			{
				int num = 0;
				if (obj != null && obj.DatabaseName != null)
				{
					num ^= obj.DatabaseName.GetHashCode();
				}
				if (obj != null && obj.TableName != null)
				{
					num ^= obj.TableName.GetHashCode();
				}
				if (obj != null && obj.ColumnName != null)
				{
					num ^= obj.ColumnName.GetHashCode();
				}
				return num;
			}

			// Token: 0x04000141 RID: 321
			public string DatabaseName;

			// Token: 0x04000142 RID: 322
			public string TableName;

			// Token: 0x04000143 RID: 323
			public string ColumnName;
		}
	}
}
