using System;
using System.Globalization;

namespace System.Data.SQLite
{
	// Token: 0x0200004F RID: 79
	internal sealed class SQLiteStatement : global::System.IDisposable
	{
		// Token: 0x060003BC RID: 956 RVA: 0x00020050 File Offset: 0x0001F450
		internal SQLiteStatement(global::System.Data.SQLite.SQLiteBase sqlbase, global::System.Data.SQLite.SQLiteConnectionFlags flags, global::System.Data.SQLite.SQLiteStatementHandle stmt, string strCommand, global::System.Data.SQLite.SQLiteStatement previous)
		{
			this._sql = sqlbase;
			this._sqlite_stmt = stmt;
			this._sqlStatement = strCommand;
			this._flags = flags;
			int num = 0;
			int num2 = this._sql.Bind_ParamCount(this, this._flags);
			if (num2 > 0)
			{
				if (previous != null)
				{
					num = previous._unnamedParameters;
				}
				this._paramNames = new string[num2];
				this._paramValues = new global::System.Data.SQLite.SQLiteParameter[num2];
				for (int i = 0; i < num2; i++)
				{
					string text = this._sql.Bind_ParamName(this, this._flags, i + 1);
					if (string.IsNullOrEmpty(text))
					{
						text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, ";{0}", new object[]
						{
							num
						});
						num++;
						this._unnamedParameters++;
					}
					this._paramNames[i] = text;
					this._paramValues[i] = null;
				}
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00020134 File Offset: 0x0001F534
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00020150 File Offset: 0x0001F550
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new global::System.ObjectDisposedException(typeof(global::System.Data.SQLite.SQLiteStatement).Name);
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0002017C File Offset: 0x0001F57C
		private void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					if (this._sqlite_stmt != null)
					{
						this._sqlite_stmt.Dispose();
						this._sqlite_stmt = null;
					}
					this._paramNames = null;
					this._paramValues = null;
					this._sql = null;
					this._sqlStatement = null;
				}
				this.disposed = true;
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000201D4 File Offset: 0x0001F5D4
		~SQLiteStatement()
		{
			this.Dispose(false);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00020210 File Offset: 0x0001F610
		internal bool TryGetChanges(ref int changes)
		{
			if (this._sql != null && this._sql.IsOpen())
			{
				changes = this._sql.Changes;
				return true;
			}
			return false;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00020244 File Offset: 0x0001F644
		internal bool MapParameter(string s, global::System.Data.SQLite.SQLiteParameter p)
		{
			if (this._paramNames == null)
			{
				return false;
			}
			int num = 0;
			if (s.Length > 0 && ":$@;".IndexOf(s[0]) == -1)
			{
				num = 1;
			}
			int num2 = this._paramNames.Length;
			for (int i = 0; i < num2; i++)
			{
				if (string.Compare(this._paramNames[i], num, s, 0, global::System.Math.Max(this._paramNames[i].Length - num, s.Length), global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					this._paramValues[i] = p;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000202CC File Offset: 0x0001F6CC
		internal void BindParameters()
		{
			if (this._paramNames == null)
			{
				return;
			}
			int num = this._paramNames.Length;
			for (int i = 0; i < num; i++)
			{
				this.BindParameter(i + 1, this._paramValues[i]);
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00020308 File Offset: 0x0001F708
		private static bool ToBoolean(object obj, global::System.IFormatProvider provider)
		{
			if (obj == null)
			{
				return false;
			}
			global::System.TypeCode typeCode = global::System.Type.GetTypeCode(obj.GetType());
			switch (typeCode)
			{
			case global::System.TypeCode.Empty:
			case global::System.TypeCode.DBNull:
				return false;
			case global::System.TypeCode.Boolean:
				return (bool)obj;
			case global::System.TypeCode.Char:
				return (char)obj != '\0';
			case global::System.TypeCode.SByte:
				return (sbyte)obj != 0;
			case global::System.TypeCode.Byte:
				return (byte)obj != 0;
			case global::System.TypeCode.Int16:
				return (short)obj != 0;
			case global::System.TypeCode.UInt16:
				return (ushort)obj != 0;
			case global::System.TypeCode.Int32:
				return (int)obj != 0;
			case global::System.TypeCode.UInt32:
				return (uint)obj != 0U;
			case global::System.TypeCode.Int64:
				return (long)obj != 0L;
			case global::System.TypeCode.UInt64:
				return (ulong)obj != 0UL;
			case global::System.TypeCode.Single:
				return (float)obj != 0f;
			case global::System.TypeCode.Double:
				return (double)obj != 0.0;
			case global::System.TypeCode.Decimal:
				return (decimal)obj != 0m;
			case global::System.TypeCode.String:
				return global::System.Convert.ToBoolean(obj, provider);
			}
			throw new global::System.Data.SQLite.SQLiteException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Cannot convert type {0} to boolean", new object[]
			{
				typeCode
			}));
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00020464 File Offset: 0x0001F864
		private void BindParameter(int index, global::System.Data.SQLite.SQLiteParameter param)
		{
			if (param == null)
			{
				throw new global::System.Data.SQLite.SQLiteException("Insufficient parameters supplied to the command");
			}
			object value = param.Value;
			global::System.Data.DbType dbType = param.DbType;
			if (value != null && dbType == global::System.Data.DbType.Object)
			{
				dbType = global::System.Data.SQLite.SQLiteConvert.TypeToDbType(value.GetType());
			}
			if ((this._flags & global::System.Data.SQLite.SQLiteConnectionFlags.LogPreBind) == global::System.Data.SQLite.SQLiteConnectionFlags.LogPreBind)
			{
				global::System.IntPtr intPtr = this._sqlite_stmt;
				global::System.Data.SQLite.SQLiteLog.LogMessage(string.Format("Binding statement {0} paramter #{1} with database type {2} and raw value {{{3}}}...", new object[]
				{
					intPtr,
					index,
					dbType,
					value
				}));
			}
			if (value == null || global::System.Convert.IsDBNull(value))
			{
				this._sql.Bind_Null(this, this._flags, index);
				return;
			}
			if ((this._flags & global::System.Data.SQLite.SQLiteConnectionFlags.BindAllAsText) != global::System.Data.SQLite.SQLiteConnectionFlags.BindAllAsText)
			{
				switch (dbType)
				{
				case global::System.Data.DbType.Binary:
					this._sql.Bind_Blob(this, this._flags, index, (byte[])value);
					return;
				case global::System.Data.DbType.Byte:
					this._sql.Bind_UInt32(this, this._flags, index, (uint)global::System.Convert.ToByte(value, global::System.Globalization.CultureInfo.CurrentCulture));
					return;
				case global::System.Data.DbType.Boolean:
					this._sql.Bind_Int32(this, this._flags, index, global::System.Data.SQLite.SQLiteStatement.ToBoolean(value, global::System.Globalization.CultureInfo.CurrentCulture) ? 1 : 0);
					return;
				case global::System.Data.DbType.Currency:
				case global::System.Data.DbType.Double:
				case global::System.Data.DbType.Single:
					this._sql.Bind_Double(this, this._flags, index, global::System.Convert.ToDouble(value, global::System.Globalization.CultureInfo.CurrentCulture));
					return;
				case global::System.Data.DbType.Date:
				case global::System.Data.DbType.DateTime:
				case global::System.Data.DbType.Time:
					this._sql.Bind_DateTime(this, this._flags, index, (value is string) ? this._sql.ToDateTime((string)value) : global::System.Convert.ToDateTime(value, global::System.Globalization.CultureInfo.CurrentCulture));
					return;
				case global::System.Data.DbType.Decimal:
					this._sql.Bind_Text(this, this._flags, index, global::System.Convert.ToDecimal(value, global::System.Globalization.CultureInfo.CurrentCulture).ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					return;
				case global::System.Data.DbType.Guid:
					if (this._command.Connection._binaryGuid)
					{
						this._sql.Bind_Blob(this, this._flags, index, ((global::System.Guid)value).ToByteArray());
						return;
					}
					this._sql.Bind_Text(this, this._flags, index, value.ToString());
					return;
				case global::System.Data.DbType.Int16:
					this._sql.Bind_Int32(this, this._flags, index, (int)global::System.Convert.ToInt16(value, global::System.Globalization.CultureInfo.CurrentCulture));
					return;
				case global::System.Data.DbType.Int32:
					this._sql.Bind_Int32(this, this._flags, index, global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.CurrentCulture));
					return;
				case global::System.Data.DbType.Int64:
					this._sql.Bind_Int64(this, this._flags, index, global::System.Convert.ToInt64(value, global::System.Globalization.CultureInfo.CurrentCulture));
					return;
				case global::System.Data.DbType.SByte:
					this._sql.Bind_Int32(this, this._flags, index, (int)global::System.Convert.ToSByte(value, global::System.Globalization.CultureInfo.CurrentCulture));
					return;
				case global::System.Data.DbType.UInt16:
					this._sql.Bind_UInt32(this, this._flags, index, (uint)global::System.Convert.ToUInt16(value, global::System.Globalization.CultureInfo.CurrentCulture));
					return;
				case global::System.Data.DbType.UInt32:
					this._sql.Bind_UInt32(this, this._flags, index, global::System.Convert.ToUInt32(value, global::System.Globalization.CultureInfo.CurrentCulture));
					return;
				case global::System.Data.DbType.UInt64:
					this._sql.Bind_UInt64(this, this._flags, index, global::System.Convert.ToUInt64(value, global::System.Globalization.CultureInfo.CurrentCulture));
					return;
				}
				this._sql.Bind_Text(this, this._flags, index, value.ToString());
				return;
			}
			if (value is global::System.DateTime)
			{
				this._sql.Bind_DateTime(this, this._flags, index, (global::System.DateTime)value);
				return;
			}
			this._sql.Bind_Text(this, this._flags, index, value.ToString());
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x000207E4 File Offset: 0x0001FBE4
		internal string[] TypeDefinitions
		{
			get
			{
				return this._types;
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000207F8 File Offset: 0x0001FBF8
		internal void SetTypes(string typedefs)
		{
			int num = typedefs.IndexOf("TYPES", 0, global::System.StringComparison.OrdinalIgnoreCase);
			if (num == -1)
			{
				throw new global::System.ArgumentOutOfRangeException();
			}
			string[] array = typedefs.Substring(num + 6).Replace(" ", "").Replace(";", "").Replace("\"", "").Replace("[", "").Replace("]", "").Replace("`", "").Split(new char[]
			{
				',',
				'\r',
				'\n',
				'\t'
			});
			for (int i = 0; i < array.Length; i++)
			{
				if (string.IsNullOrEmpty(array[i]))
				{
					array[i] = null;
				}
			}
			this._types = array;
		}

		// Token: 0x040001BB RID: 443
		internal global::System.Data.SQLite.SQLiteBase _sql;

		// Token: 0x040001BC RID: 444
		internal string _sqlStatement;

		// Token: 0x040001BD RID: 445
		internal global::System.Data.SQLite.SQLiteStatementHandle _sqlite_stmt;

		// Token: 0x040001BE RID: 446
		internal int _unnamedParameters;

		// Token: 0x040001BF RID: 447
		internal string[] _paramNames;

		// Token: 0x040001C0 RID: 448
		internal global::System.Data.SQLite.SQLiteParameter[] _paramValues;

		// Token: 0x040001C1 RID: 449
		internal global::System.Data.SQLite.SQLiteCommand _command;

		// Token: 0x040001C2 RID: 450
		private global::System.Data.SQLite.SQLiteConnectionFlags _flags;

		// Token: 0x040001C3 RID: 451
		private string[] _types;

		// Token: 0x040001C4 RID: 452
		private bool disposed;
	}
}
