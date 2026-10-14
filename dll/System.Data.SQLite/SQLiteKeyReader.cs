using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;

namespace System.Data.SQLite
{
	// Token: 0x02000046 RID: 70
	internal sealed class SQLiteKeyReader : global::System.IDisposable
	{
		// Token: 0x06000335 RID: 821 RVA: 0x0001D978 File Offset: 0x0001CD78
		internal SQLiteKeyReader(global::System.Data.SQLite.SQLiteConnection cnn, global::System.Data.SQLite.SQLiteDataReader reader, global::System.Data.SQLite.SQLiteStatement stmt)
		{
			global::System.Collections.Generic.Dictionary<string, int> dictionary = new global::System.Collections.Generic.Dictionary<string, int>();
			global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> dictionary2 = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>();
			global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteKeyReader.KeyInfo> list = new global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteKeyReader.KeyInfo>();
			this._stmt = stmt;
			using (global::System.Data.DataTable schema = cnn.GetSchema("Catalogs"))
			{
				foreach (object obj in schema.Rows)
				{
					global::System.Data.DataRow dataRow = (global::System.Data.DataRow)obj;
					dictionary.Add((string)dataRow["CATALOG_NAME"], global::System.Convert.ToInt32(dataRow["ID"], global::System.Globalization.CultureInfo.InvariantCulture));
				}
			}
			using (global::System.Data.DataTable schemaTable = reader.GetSchemaTable(false, false))
			{
				foreach (object obj2 in schemaTable.Rows)
				{
					global::System.Data.DataRow dataRow2 = (global::System.Data.DataRow)obj2;
					if (dataRow2[global::System.Data.Common.SchemaTableOptionalColumn.BaseCatalogName] != global::System.DBNull.Value)
					{
						string key = (string)dataRow2[global::System.Data.Common.SchemaTableOptionalColumn.BaseCatalogName];
						string item = (string)dataRow2[global::System.Data.Common.SchemaTableColumn.BaseTableName];
						global::System.Collections.Generic.List<string> list2;
						if (!dictionary2.ContainsKey(key))
						{
							list2 = new global::System.Collections.Generic.List<string>();
							dictionary2.Add(key, list2);
						}
						else
						{
							list2 = dictionary2[key];
						}
						if (!list2.Contains(item))
						{
							list2.Add(item);
						}
					}
				}
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>> keyValuePair in dictionary2)
				{
					for (int i = 0; i < keyValuePair.Value.Count; i++)
					{
						string text = keyValuePair.Value[i];
						global::System.Data.DataRow dataRow3 = null;
						using (global::System.Data.DataTable schema2 = cnn.GetSchema("Indexes", new string[]
						{
							keyValuePair.Key,
							null,
							text
						}))
						{
							int num = 0;
							while (num < 2 && dataRow3 == null)
							{
								foreach (object obj3 in schema2.Rows)
								{
									global::System.Data.DataRow dataRow4 = (global::System.Data.DataRow)obj3;
									if (num == 0 && (bool)dataRow4["PRIMARY_KEY"])
									{
										dataRow3 = dataRow4;
										break;
									}
									if (num == 1 && (bool)dataRow4["UNIQUE"])
									{
										dataRow3 = dataRow4;
										break;
									}
								}
								num++;
							}
							if (dataRow3 == null)
							{
								keyValuePair.Value.RemoveAt(i);
								i--;
							}
							else
							{
								using (global::System.Data.DataTable schema3 = cnn.GetSchema("Tables", new string[]
								{
									keyValuePair.Key,
									null,
									text
								}))
								{
									int database = dictionary[keyValuePair.Key];
									int rootPage = global::System.Convert.ToInt32(schema3.Rows[0]["TABLE_ROOTPAGE"], global::System.Globalization.CultureInfo.InvariantCulture);
									int cursorForTable = stmt._sql.GetCursorForTable(stmt, database, rootPage);
									using (global::System.Data.DataTable schema4 = cnn.GetSchema("IndexColumns", new string[]
									{
										keyValuePair.Key,
										null,
										text,
										(string)dataRow3["INDEX_NAME"]
									}))
									{
										global::System.Data.SQLite.SQLiteKeyReader.KeyQuery query = null;
										global::System.Collections.Generic.List<string> list3 = new global::System.Collections.Generic.List<string>();
										for (int j = 0; j < schema4.Rows.Count; j++)
										{
											bool flag = true;
											foreach (object obj4 in schemaTable.Rows)
											{
												global::System.Data.DataRow dataRow5 = (global::System.Data.DataRow)obj4;
												if (!dataRow5.IsNull(global::System.Data.Common.SchemaTableColumn.BaseColumnName) && (string)dataRow5[global::System.Data.Common.SchemaTableColumn.BaseColumnName] == (string)schema4.Rows[j]["COLUMN_NAME"] && (string)dataRow5[global::System.Data.Common.SchemaTableColumn.BaseTableName] == text && (string)dataRow5[global::System.Data.Common.SchemaTableOptionalColumn.BaseCatalogName] == keyValuePair.Key)
												{
													schema4.Rows.RemoveAt(j);
													j--;
													flag = false;
													break;
												}
											}
											if (flag)
											{
												list3.Add((string)schema4.Rows[j]["COLUMN_NAME"]);
											}
										}
										if ((string)dataRow3["INDEX_NAME"] != "sqlite_master_PK_" + text && list3.Count > 0)
										{
											string[] array = new string[list3.Count];
											list3.CopyTo(array);
											query = new global::System.Data.SQLite.SQLiteKeyReader.KeyQuery(cnn, keyValuePair.Key, text, array);
										}
										for (int k = 0; k < schema4.Rows.Count; k++)
										{
											string columnName = (string)schema4.Rows[k]["COLUMN_NAME"];
											list.Add(new global::System.Data.SQLite.SQLiteKeyReader.KeyInfo
											{
												rootPage = rootPage,
												cursor = cursorForTable,
												database = database,
												databaseName = keyValuePair.Key,
												tableName = text,
												columnName = columnName,
												query = query,
												column = k
											});
										}
									}
								}
							}
						}
					}
				}
			}
			this._keyInfo = new global::System.Data.SQLite.SQLiteKeyReader.KeyInfo[list.Count];
			list.CopyTo(this._keyInfo);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0001E030 File Offset: 0x0001D430
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0001E04C File Offset: 0x0001D44C
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteKeyReader).Name);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0001E078 File Offset: 0x0001D478
		private void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					this._stmt = null;
					if (this._keyInfo != null)
					{
						for (int i = 0; i < this._keyInfo.Length; i++)
						{
							if (this._keyInfo[i].query != null)
							{
								this._keyInfo[i].query.Dispose();
							}
						}
						this._keyInfo = null;
					}
				}
				this.disposed = true;
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0001E0EC File Offset: 0x0001D4EC
		~SQLiteKeyReader()
		{
			this.Dispose(false);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0001E128 File Offset: 0x0001D528
		internal int Count
		{
			get
			{
				if (this._keyInfo != null)
				{
					return this._keyInfo.Length;
				}
				return 0;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0001E148 File Offset: 0x0001D548
		internal void Sync(int i)
		{
			this.Sync();
			if (this._keyInfo[i].cursor == -1)
			{
				throw new global::System.InvalidCastException();
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0001E178 File Offset: 0x0001D578
		internal void Sync()
		{
			if (this._isValid)
			{
				return;
			}
			global::System.Data.SQLite.SQLiteKeyReader.KeyQuery keyQuery = null;
			for (int i = 0; i < this._keyInfo.Length; i++)
			{
				if (this._keyInfo[i].query == null || this._keyInfo[i].query != keyQuery)
				{
					keyQuery = this._keyInfo[i].query;
					if (keyQuery != null)
					{
						keyQuery.Sync(this._stmt._sql.GetRowIdForCursor(this._stmt, this._keyInfo[i].cursor));
					}
				}
			}
			this._isValid = true;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001E214 File Offset: 0x0001D614
		internal void Reset()
		{
			this._isValid = false;
			if (this._keyInfo == null)
			{
				return;
			}
			for (int i = 0; i < this._keyInfo.Length; i++)
			{
				if (this._keyInfo[i].query != null)
				{
					this._keyInfo[i].query.IsValid = false;
				}
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001E270 File Offset: 0x0001D670
		internal string GetDataTypeName(int i)
		{
			this.Sync();
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetDataTypeName(this._keyInfo[i].column);
			}
			return "integer";
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001E2C8 File Offset: 0x0001D6C8
		internal global::System.Type GetFieldType(int i)
		{
			this.Sync();
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetFieldType(this._keyInfo[i].column);
			}
			return typeof(long);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0001E328 File Offset: 0x0001D728
		internal string GetName(int i)
		{
			return this._keyInfo[i].columnName;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0001E348 File Offset: 0x0001D748
		internal int GetOrdinal(string name)
		{
			for (int i = 0; i < this._keyInfo.Length; i++)
			{
				if (string.Compare(name, this._keyInfo[i].columnName, global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0001E388 File Offset: 0x0001D788
		internal bool GetBoolean(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetBoolean(this._keyInfo[i].column);
			}
			throw new global::System.InvalidCastException();
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0001E3E4 File Offset: 0x0001D7E4
		internal byte GetByte(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetByte(this._keyInfo[i].column);
			}
			throw new global::System.InvalidCastException();
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0001E440 File Offset: 0x0001D840
		internal long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetBytes(this._keyInfo[i].column, fieldOffset, buffer, bufferoffset, length);
			}
			throw new global::System.InvalidCastException();
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001E4A0 File Offset: 0x0001D8A0
		internal char GetChar(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetChar(this._keyInfo[i].column);
			}
			throw new global::System.InvalidCastException();
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001E4FC File Offset: 0x0001D8FC
		internal long GetChars(int i, long fieldOffset, char[] buffer, int bufferoffset, int length)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetChars(this._keyInfo[i].column, fieldOffset, buffer, bufferoffset, length);
			}
			throw new global::System.InvalidCastException();
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0001E55C File Offset: 0x0001D95C
		internal global::System.DateTime GetDateTime(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetDateTime(this._keyInfo[i].column);
			}
			throw new global::System.InvalidCastException();
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0001E5B8 File Offset: 0x0001D9B8
		internal decimal GetDecimal(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetDecimal(this._keyInfo[i].column);
			}
			throw new global::System.InvalidCastException();
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0001E614 File Offset: 0x0001DA14
		internal double GetDouble(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetDouble(this._keyInfo[i].column);
			}
			throw new global::System.InvalidCastException();
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0001E670 File Offset: 0x0001DA70
		internal float GetFloat(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetFloat(this._keyInfo[i].column);
			}
			throw new global::System.InvalidCastException();
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0001E6CC File Offset: 0x0001DACC
		internal global::System.Guid GetGuid(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetGuid(this._keyInfo[i].column);
			}
			throw new global::System.InvalidCastException();
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0001E728 File Offset: 0x0001DB28
		internal short GetInt16(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetInt16(this._keyInfo[i].column);
			}
			long rowIdForCursor = this._stmt._sql.GetRowIdForCursor(this._stmt, this._keyInfo[i].cursor);
			if (rowIdForCursor == 0L)
			{
				throw new global::System.InvalidCastException();
			}
			return global::System.Convert.ToInt16(rowIdForCursor);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0001E7B8 File Offset: 0x0001DBB8
		internal int GetInt32(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetInt32(this._keyInfo[i].column);
			}
			long rowIdForCursor = this._stmt._sql.GetRowIdForCursor(this._stmt, this._keyInfo[i].cursor);
			if (rowIdForCursor == 0L)
			{
				throw new global::System.InvalidCastException();
			}
			return global::System.Convert.ToInt32(rowIdForCursor);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0001E848 File Offset: 0x0001DC48
		internal long GetInt64(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetInt64(this._keyInfo[i].column);
			}
			long rowIdForCursor = this._stmt._sql.GetRowIdForCursor(this._stmt, this._keyInfo[i].cursor);
			if (rowIdForCursor == 0L)
			{
				throw new global::System.InvalidCastException();
			}
			return global::System.Convert.ToInt64(rowIdForCursor);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0001E8D8 File Offset: 0x0001DCD8
		internal string GetString(int i)
		{
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetString(this._keyInfo[i].column);
			}
			throw new global::System.InvalidCastException();
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0001E934 File Offset: 0x0001DD34
		internal object GetValue(int i)
		{
			if (this._keyInfo[i].cursor == -1)
			{
				return global::System.DBNull.Value;
			}
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.GetValue(this._keyInfo[i].column);
			}
			if (this.IsDBNull(i))
			{
				return global::System.DBNull.Value;
			}
			return this.GetInt64(i);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0001E9C0 File Offset: 0x0001DDC0
		internal bool IsDBNull(int i)
		{
			if (this._keyInfo[i].cursor == -1)
			{
				return true;
			}
			this.Sync(i);
			if (this._keyInfo[i].query != null)
			{
				return this._keyInfo[i].query._reader.IsDBNull(this._keyInfo[i].column);
			}
			return this._stmt._sql.GetRowIdForCursor(this._stmt, this._keyInfo[i].cursor) == 0L;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0001EA58 File Offset: 0x0001DE58
		internal void AppendSchemaTable(global::System.Data.DataTable tbl)
		{
			global::System.Data.SQLite.SQLiteKeyReader.KeyQuery keyQuery = null;
			for (int i = 0; i < this._keyInfo.Length; i++)
			{
				if (this._keyInfo[i].query == null || this._keyInfo[i].query != keyQuery)
				{
					keyQuery = this._keyInfo[i].query;
					if (keyQuery == null)
					{
						global::System.Data.DataRow dataRow = tbl.NewRow();
						dataRow[global::System.Data.Common.SchemaTableColumn.ColumnName] = this._keyInfo[i].columnName;
						dataRow[global::System.Data.Common.SchemaTableColumn.ColumnOrdinal] = tbl.Rows.Count;
						dataRow[global::System.Data.Common.SchemaTableColumn.ColumnSize] = 8;
						dataRow[global::System.Data.Common.SchemaTableColumn.NumericPrecision] = 255;
						dataRow[global::System.Data.Common.SchemaTableColumn.NumericScale] = 255;
						dataRow[global::System.Data.Common.SchemaTableColumn.ProviderType] = global::System.Data.DbType.Int64;
						dataRow[global::System.Data.Common.SchemaTableColumn.IsLong] = false;
						dataRow[global::System.Data.Common.SchemaTableColumn.AllowDBNull] = false;
						dataRow[global::System.Data.Common.SchemaTableOptionalColumn.IsReadOnly] = false;
						dataRow[global::System.Data.Common.SchemaTableOptionalColumn.IsRowVersion] = false;
						dataRow[global::System.Data.Common.SchemaTableColumn.IsUnique] = false;
						dataRow[global::System.Data.Common.SchemaTableColumn.IsKey] = true;
						dataRow[global::System.Data.Common.SchemaTableColumn.DataType] = typeof(long);
						dataRow[global::System.Data.Common.SchemaTableOptionalColumn.IsHidden] = true;
						dataRow[global::System.Data.Common.SchemaTableColumn.BaseColumnName] = this._keyInfo[i].columnName;
						dataRow[global::System.Data.Common.SchemaTableColumn.IsExpression] = false;
						dataRow[global::System.Data.Common.SchemaTableColumn.IsAliased] = false;
						dataRow[global::System.Data.Common.SchemaTableColumn.BaseTableName] = this._keyInfo[i].tableName;
						dataRow[global::System.Data.Common.SchemaTableOptionalColumn.BaseCatalogName] = this._keyInfo[i].databaseName;
						dataRow[global::System.Data.Common.SchemaTableOptionalColumn.IsAutoIncrement] = true;
						dataRow["DataTypeName"] = "integer";
						tbl.Rows.Add(dataRow);
					}
					else
					{
						keyQuery.Sync(0L);
						using (global::System.Data.DataTable schemaTable = keyQuery._reader.GetSchemaTable())
						{
							foreach (object obj in schemaTable.Rows)
							{
								global::System.Data.DataRow dataRow2 = (global::System.Data.DataRow)obj;
								object[] itemArray = dataRow2.ItemArray;
								global::System.Data.DataRow dataRow3 = tbl.Rows.Add(itemArray);
								dataRow3[global::System.Data.Common.SchemaTableOptionalColumn.IsHidden] = true;
								dataRow3[global::System.Data.Common.SchemaTableColumn.ColumnOrdinal] = tbl.Rows.Count - 1;
							}
						}
					}
				}
			}
		}

		// Token: 0x0400018E RID: 398
		private global::System.Data.SQLite.SQLiteKeyReader.KeyInfo[] _keyInfo;

		// Token: 0x0400018F RID: 399
		private global::System.Data.SQLite.SQLiteStatement _stmt;

		// Token: 0x04000190 RID: 400
		private bool _isValid;

		// Token: 0x04000191 RID: 401
		private bool disposed;

		// Token: 0x02000047 RID: 71
		private struct KeyInfo
		{
			// Token: 0x04000192 RID: 402
			internal string databaseName;

			// Token: 0x04000193 RID: 403
			internal string tableName;

			// Token: 0x04000194 RID: 404
			internal string columnName;

			// Token: 0x04000195 RID: 405
			internal int database;

			// Token: 0x04000196 RID: 406
			internal int rootPage;

			// Token: 0x04000197 RID: 407
			internal int cursor;

			// Token: 0x04000198 RID: 408
			internal global::System.Data.SQLite.SQLiteKeyReader.KeyQuery query;

			// Token: 0x04000199 RID: 409
			internal int column;
		}

		// Token: 0x02000048 RID: 72
		private sealed class KeyQuery : global::System.IDisposable
		{
			// Token: 0x06000353 RID: 851 RVA: 0x0001ED5C File Offset: 0x0001E15C
			internal KeyQuery(global::System.Data.SQLite.SQLiteConnection cnn, string database, string table, params string[] columns)
			{
				using (global::System.Data.SQLite.SQLiteCommandBuilder sqliteCommandBuilder = new global::System.Data.SQLite.SQLiteCommandBuilder())
				{
					this._command = cnn.CreateCommand();
					for (int i = 0; i < columns.Length; i++)
					{
						columns[i] = sqliteCommandBuilder.QuoteIdentifier(columns[i]);
					}
				}
				this._command.CommandText = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "SELECT {0} FROM [{1}].[{2}] WHERE ROWID = ?", new object[]
				{
					string.Join(",", columns),
					database,
					table
				});
				this._command.Parameters.AddWithValue(null, 0L);
			}

			// Token: 0x17000072 RID: 114
			// (set) Token: 0x06000354 RID: 852 RVA: 0x0001EE18 File Offset: 0x0001E218
			internal bool IsValid
			{
				set
				{
					if (value)
					{
						throw new global::System.ArgumentException();
					}
					if (this._reader != null)
					{
						this._reader.Dispose();
						this._reader = null;
					}
				}
			}

			// Token: 0x06000355 RID: 853 RVA: 0x0001EE48 File Offset: 0x0001E248
			internal void Sync(long rowid)
			{
				this.IsValid = false;
				this._command.Parameters[0].Value = rowid;
				this._reader = this._command.ExecuteReader();
				this._reader.Read();
			}

			// Token: 0x06000356 RID: 854 RVA: 0x0001EE98 File Offset: 0x0001E298
			public void Dispose()
			{
				this.Dispose(true);
				global::System.GC.SuppressFinalize(this);
			}

			// Token: 0x06000357 RID: 855 RVA: 0x0001EEB4 File Offset: 0x0001E2B4
			private void CheckDisposed()
			{
				if (this.disposed)
				{
					throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteKeyReader.KeyQuery).Name);
				}
			}

			// Token: 0x06000358 RID: 856 RVA: 0x0001EEE0 File Offset: 0x0001E2E0
			private void Dispose(bool disposing)
			{
				if (!this.disposed)
				{
					if (disposing)
					{
						this.IsValid = false;
						if (this._command != null)
						{
							this._command.Dispose();
						}
						this._command = null;
					}
					this.disposed = true;
				}
			}

			// Token: 0x06000359 RID: 857 RVA: 0x0001EF20 File Offset: 0x0001E320
			~KeyQuery()
			{
				this.Dispose(false);
			}

			// Token: 0x0400019A RID: 410
			private global::System.Data.SQLite.SQLiteCommand _command;

			// Token: 0x0400019B RID: 411
			internal global::System.Data.SQLite.SQLiteDataReader _reader;

			// Token: 0x0400019C RID: 412
			private bool disposed;
		}
	}
}
