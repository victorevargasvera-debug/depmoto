using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Data.SQLite
{
	// Token: 0x02000005 RID: 5
	public abstract class SQLiteConvert
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000D810 File Offset: 0x0000CC10
		internal SQLiteConvert(global::System.Data.SQLite.SQLiteDateFormats fmt, global::System.DateTimeKind kind, string fmtString)
		{
			this._datetimeFormat = fmt;
			this._datetimeKind = kind;
			this._datetimeFormatString = fmtString;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000D838 File Offset: 0x0000CC38
		public static byte[] ToUTF8(string sourceText)
		{
			int num = global::System.Data.SQLite.SQLiteConvert._utf8.GetByteCount(sourceText) + 1;
			byte[] array = new byte[num];
			num = global::System.Data.SQLite.SQLiteConvert._utf8.GetBytes(sourceText, 0, sourceText.Length, array, 0);
			array[num] = 0;
			return array;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000D874 File Offset: 0x0000CC74
		public byte[] ToUTF8(global::System.DateTime dateTimeValue)
		{
			return global::System.Data.SQLite.SQLiteConvert.ToUTF8(this.ToString(dateTimeValue));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000D890 File Offset: 0x0000CC90
		public virtual string ToString(global::System.IntPtr nativestring, int nativestringlen)
		{
			return global::System.Data.SQLite.SQLiteConvert.UTF8ToString(nativestring, nativestringlen);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000D8A4 File Offset: 0x0000CCA4
		public static string UTF8ToString(global::System.IntPtr nativestring, int nativestringlen)
		{
			if (nativestring == global::System.IntPtr.Zero || nativestringlen == 0)
			{
				return string.Empty;
			}
			if (nativestringlen < 0)
			{
				nativestringlen = 0;
				while (global::System.Runtime.InteropServices.Marshal.ReadByte(nativestring, nativestringlen) != 0)
				{
					nativestringlen++;
				}
				if (nativestringlen == 0)
				{
					return string.Empty;
				}
			}
			byte[] array = new byte[nativestringlen];
			global::System.Runtime.InteropServices.Marshal.Copy(nativestring, array, 0, nativestringlen);
			return global::System.Data.SQLite.SQLiteConvert._utf8.GetString(array, 0, nativestringlen);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000D904 File Offset: 0x0000CD04
		public global::System.DateTime ToDateTime(string dateText)
		{
			return global::System.Data.SQLite.SQLiteConvert.ToDateTime(dateText, this._datetimeFormat, this._datetimeKind, this._datetimeFormatString);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000D92C File Offset: 0x0000CD2C
		public static global::System.DateTime ToDateTime(string dateText, global::System.Data.SQLite.SQLiteDateFormats format, global::System.DateTimeKind kind, string formatString)
		{
			switch (format)
			{
			case global::System.Data.SQLite.SQLiteDateFormats.Ticks:
				return global::System.Data.SQLite.SQLiteConvert.ToDateTime(global::System.Convert.ToInt64(dateText, global::System.Globalization.CultureInfo.InvariantCulture), kind);
			case global::System.Data.SQLite.SQLiteDateFormats.JulianDay:
				return global::System.Data.SQLite.SQLiteConvert.ToDateTime(global::System.Convert.ToDouble(dateText, global::System.Globalization.CultureInfo.InvariantCulture), kind);
			case global::System.Data.SQLite.SQLiteDateFormats.UnixEpoch:
				return global::System.Data.SQLite.SQLiteConvert.ToDateTime(global::System.Convert.ToInt32(dateText, global::System.Globalization.CultureInfo.InvariantCulture), kind);
			case global::System.Data.SQLite.SQLiteDateFormats.InvariantCulture:
				if (formatString != null)
				{
					return global::System.DateTime.SpecifyKind(global::System.DateTime.ParseExact(dateText, formatString, global::System.Globalization.DateTimeFormatInfo.InvariantInfo, (kind == global::System.DateTimeKind.Utc) ? global::System.Globalization.DateTimeStyles.AdjustToUniversal : global::System.Globalization.DateTimeStyles.None), kind);
				}
				return global::System.DateTime.SpecifyKind(global::System.DateTime.Parse(dateText, global::System.Globalization.DateTimeFormatInfo.InvariantInfo, (kind == global::System.DateTimeKind.Utc) ? global::System.Globalization.DateTimeStyles.AdjustToUniversal : global::System.Globalization.DateTimeStyles.None), kind);
			case global::System.Data.SQLite.SQLiteDateFormats.CurrentCulture:
				if (formatString != null)
				{
					return global::System.DateTime.SpecifyKind(global::System.DateTime.ParseExact(dateText, formatString, global::System.Globalization.DateTimeFormatInfo.CurrentInfo, (kind == global::System.DateTimeKind.Utc) ? global::System.Globalization.DateTimeStyles.AdjustToUniversal : global::System.Globalization.DateTimeStyles.None), kind);
				}
				return global::System.DateTime.SpecifyKind(global::System.DateTime.Parse(dateText, global::System.Globalization.DateTimeFormatInfo.CurrentInfo, (kind == global::System.DateTimeKind.Utc) ? global::System.Globalization.DateTimeStyles.AdjustToUniversal : global::System.Globalization.DateTimeStyles.None), kind);
			}
			if (formatString != null)
			{
				return global::System.DateTime.SpecifyKind(global::System.DateTime.ParseExact(dateText, formatString, global::System.Globalization.DateTimeFormatInfo.InvariantInfo, (kind == global::System.DateTimeKind.Utc) ? global::System.Globalization.DateTimeStyles.AdjustToUniversal : global::System.Globalization.DateTimeStyles.None), kind);
			}
			return global::System.DateTime.SpecifyKind(global::System.DateTime.ParseExact(dateText, global::System.Data.SQLite.SQLiteConvert._datetimeFormats, global::System.Globalization.DateTimeFormatInfo.InvariantInfo, (kind == global::System.DateTimeKind.Utc) ? global::System.Globalization.DateTimeStyles.AdjustToUniversal : global::System.Globalization.DateTimeStyles.None), kind);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000DA48 File Offset: 0x0000CE48
		public global::System.DateTime ToDateTime(double julianDay)
		{
			return global::System.Data.SQLite.SQLiteConvert.ToDateTime(julianDay, this._datetimeKind);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000DA64 File Offset: 0x0000CE64
		public static global::System.DateTime ToDateTime(double julianDay, global::System.DateTimeKind kind)
		{
			return global::System.DateTime.SpecifyKind(global::System.DateTime.FromOADate(julianDay - global::System.Data.SQLite.SQLiteConvert.OleAutomationEpochAsJulianDay), kind);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000DA84 File Offset: 0x0000CE84
		internal static global::System.DateTime ToDateTime(int seconds, global::System.DateTimeKind kind)
		{
			return global::System.DateTime.SpecifyKind(global::System.Data.SQLite.SQLiteConvert.UnixEpoch.AddSeconds((double)seconds), kind);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000DAA8 File Offset: 0x0000CEA8
		internal static global::System.DateTime ToDateTime(long ticks, global::System.DateTimeKind kind)
		{
			return new global::System.DateTime(ticks, kind);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000DABC File Offset: 0x0000CEBC
		public static double ToJulianDay(global::System.DateTime value)
		{
			return value.ToOADate() + global::System.Data.SQLite.SQLiteConvert.OleAutomationEpochAsJulianDay;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000DAD8 File Offset: 0x0000CED8
		public static long ToUnixEpoch(global::System.DateTime value)
		{
			return value.Subtract(global::System.Data.SQLite.SQLiteConvert.UnixEpoch).Ticks / 10000000L;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000DB00 File Offset: 0x0000CF00
		private static string GetDateTimeKindFormat(global::System.DateTimeKind kind, string formatString)
		{
			if (formatString != null)
			{
				return formatString;
			}
			if (kind != global::System.DateTimeKind.Utc)
			{
				return global::System.Data.SQLite.SQLiteConvert._datetimeFormatLocal;
			}
			return global::System.Data.SQLite.SQLiteConvert._datetimeFormatUtc;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000DB24 File Offset: 0x0000CF24
		public string ToString(global::System.DateTime dateValue)
		{
			switch (this._datetimeFormat)
			{
			case global::System.Data.SQLite.SQLiteDateFormats.Ticks:
				return dateValue.Ticks.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			case global::System.Data.SQLite.SQLiteDateFormats.JulianDay:
				return global::System.Data.SQLite.SQLiteConvert.ToJulianDay(dateValue).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			case global::System.Data.SQLite.SQLiteDateFormats.UnixEpoch:
				return (dateValue.Subtract(global::System.Data.SQLite.SQLiteConvert.UnixEpoch).Ticks / 10000000L).ToString();
			case global::System.Data.SQLite.SQLiteDateFormats.InvariantCulture:
				return dateValue.ToString((this._datetimeFormatString != null) ? this._datetimeFormatString : "yyyy-MM-ddTHH:mm:ss.fffffffK", global::System.Globalization.CultureInfo.InvariantCulture);
			case global::System.Data.SQLite.SQLiteDateFormats.CurrentCulture:
				return dateValue.ToString((this._datetimeFormatString != null) ? this._datetimeFormatString : "yyyy-MM-ddTHH:mm:ss.fffffffK", global::System.Globalization.CultureInfo.CurrentCulture);
			}
			if (dateValue.Kind != global::System.DateTimeKind.Unspecified)
			{
				return dateValue.ToString(global::System.Data.SQLite.SQLiteConvert.GetDateTimeKindFormat(dateValue.Kind, this._datetimeFormatString), global::System.Globalization.CultureInfo.InvariantCulture);
			}
			return global::System.DateTime.SpecifyKind(dateValue, this._datetimeKind).ToString(global::System.Data.SQLite.SQLiteConvert.GetDateTimeKindFormat(this._datetimeKind, this._datetimeFormatString), global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000DC40 File Offset: 0x0000D040
		internal global::System.DateTime ToDateTime(global::System.IntPtr ptr, int len)
		{
			return this.ToDateTime(this.ToString(ptr, len));
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000DC5C File Offset: 0x0000D05C
		public static string[] Split(string source, char separator)
		{
			char[] array = new char[]
			{
				'"',
				separator
			};
			char[] array2 = new char[]
			{
				'"'
			};
			int num = 0;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			while (source.Length > 0)
			{
				num = source.IndexOfAny(array, num);
				if (num == -1)
				{
					break;
				}
				if (source[num] == array[0])
				{
					num = source.IndexOfAny(array2, num + 1);
					if (num == -1)
					{
						break;
					}
					num++;
				}
				else
				{
					string text = source.Substring(0, num).Trim();
					if (text.Length > 1 && text[0] == array2[0] && text[text.Length - 1] == text[0])
					{
						text = text.Substring(1, text.Length - 2);
					}
					source = source.Substring(num + 1).Trim();
					if (text.Length > 0)
					{
						list.Add(text);
					}
					num = 0;
				}
			}
			if (source.Length > 0)
			{
				string text = source.Trim();
				if (text.Length > 1 && text[0] == array2[0] && text[text.Length - 1] == text[0])
				{
					text = text.Substring(1, text.Length - 2);
				}
				list.Add(text);
			}
			string[] array3 = new string[list.Count];
			list.CopyTo(array3, 0);
			return array3;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000DDB8 File Offset: 0x0000D1B8
		internal static string[] NewSplit(string value, char separator, bool keepQuote, ref string error)
		{
			if (separator == '\\' || separator == '"')
			{
				error = "separator character cannot be the escape or quote characters";
				return null;
			}
			if (value == null)
			{
				error = "string value to split cannot be null";
				return null;
			}
			int length = value.Length;
			if (length == 0)
			{
				return new string[0];
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int i = 0;
			bool flag = false;
			bool flag2 = false;
			while (i < length)
			{
				char c = value[i++];
				if (flag)
				{
					if (c != '\\' && c != '"' && c != separator)
					{
						stringBuilder.Append('\\');
					}
					stringBuilder.Append(c);
					flag = false;
				}
				else if (c == '\\')
				{
					flag = true;
				}
				else if (c == '"')
				{
					if (keepQuote)
					{
						stringBuilder.Append(c);
					}
					flag2 = !flag2;
				}
				else if (c == separator)
				{
					if (flag2)
					{
						stringBuilder.Append(c);
					}
					else
					{
						list.Add(stringBuilder.ToString());
						stringBuilder.Length = 0;
					}
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			if (flag || flag2)
			{
				error = "unbalanced escape or quote character found";
				return null;
			}
			if (stringBuilder.Length > 0)
			{
				list.Add(stringBuilder.ToString());
			}
			return list.ToArray();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000DEC8 File Offset: 0x0000D2C8
		public static bool ToBoolean(object source)
		{
			if (source is bool)
			{
				return (bool)source;
			}
			return global::System.Data.SQLite.SQLiteConvert.ToBoolean(source.ToString());
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000DEF0 File Offset: 0x0000D2F0
		public static bool ToBoolean(string source)
		{
			if (string.Compare(source, bool.TrueString, global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
			if (string.Compare(source, bool.FalseString, global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				return false;
			}
			string key;
			switch (key = source.ToLower(global::System.Globalization.CultureInfo.InvariantCulture))
			{
			case "yes":
			case "y":
			case "1":
			case "on":
				return true;
			case "no":
			case "n":
			case "0":
			case "off":
				return false;
			}
			throw new global::System.ArgumentException("source");
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000DFEC File Offset: 0x0000D3EC
		internal static void ColumnToType(global::System.Data.SQLite.SQLiteStatement stmt, int i, global::System.Data.SQLite.SQLiteType typ)
		{
			typ.Type = global::System.Data.SQLite.SQLiteConvert.TypeNameToDbType(stmt._sql.ColumnType(stmt, i, out typ.Affinity));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000E018 File Offset: 0x0000D418
		internal static global::System.Type SQLiteTypeToType(global::System.Data.SQLite.SQLiteType t)
		{
			if (t.Type == global::System.Data.DbType.Object)
			{
				return global::System.Data.SQLite.SQLiteConvert._affinitytotype[(int)t.Affinity];
			}
			return global::System.Data.SQLite.SQLiteConvert.DbTypeToType(t.Type);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000E048 File Offset: 0x0000D448
		internal static global::System.Data.DbType TypeToDbType(global::System.Type typ)
		{
			global::System.TypeCode typeCode = global::System.Type.GetTypeCode(typ);
			if (typeCode != global::System.TypeCode.Object)
			{
				return global::System.Data.SQLite.SQLiteConvert._typetodbtype[(int)typeCode];
			}
			if (typ == typeof(byte[]))
			{
				return global::System.Data.DbType.Binary;
			}
			if (typ == typeof(global::System.Guid))
			{
				return global::System.Data.DbType.Guid;
			}
			return global::System.Data.DbType.String;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000E094 File Offset: 0x0000D494
		internal static int DbTypeToColumnSize(global::System.Data.DbType typ)
		{
			return global::System.Data.SQLite.SQLiteConvert._dbtypetocolumnsize[(int)typ];
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000E0A8 File Offset: 0x0000D4A8
		internal static object DbTypeToNumericPrecision(global::System.Data.DbType typ)
		{
			return global::System.Data.SQLite.SQLiteConvert._dbtypetonumericprecision[(int)typ];
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000E0BC File Offset: 0x0000D4BC
		internal static object DbTypeToNumericScale(global::System.Data.DbType typ)
		{
			return global::System.Data.SQLite.SQLiteConvert._dbtypetonumericscale[(int)typ];
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000E0D0 File Offset: 0x0000D4D0
		internal static string DbTypeToTypeName(global::System.Data.DbType typ)
		{
			lock (global::System.Data.SQLite.SQLiteConvert._syncRoot)
			{
				if (global::System.Data.SQLite.SQLiteConvert._typeNames == null)
				{
					global::System.Data.SQLite.SQLiteConvert._typeNames = global::System.Data.SQLite.SQLiteConvert.GetSQLiteDbTypeMap();
				}
				global::System.Data.SQLite.SQLiteDbTypeMapping sqliteDbTypeMapping;
				if (global::System.Data.SQLite.SQLiteConvert._typeNames.TryGetValue(typ, out sqliteDbTypeMapping))
				{
					return sqliteDbTypeMapping.typeName;
				}
			}
			string empty = string.Empty;
			global::System.Diagnostics.Trace.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "WARNING: Type mapping failed, returning default name \"{0}\" for type {1}.", new object[]
			{
				empty,
				typ
			}));
			return empty;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000E174 File Offset: 0x0000D574
		internal static global::System.Type DbTypeToType(global::System.Data.DbType typ)
		{
			return global::System.Data.SQLite.SQLiteConvert._dbtypeToType[(int)typ];
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000E188 File Offset: 0x0000D588
		internal static global::System.Data.SQLite.TypeAffinity TypeToAffinity(global::System.Type typ)
		{
			global::System.TypeCode typeCode = global::System.Type.GetTypeCode(typ);
			if (typeCode != global::System.TypeCode.Object)
			{
				return global::System.Data.SQLite.SQLiteConvert._typecodeAffinities[(int)typeCode];
			}
			if (typ == typeof(byte[]) || typ == typeof(global::System.Guid))
			{
				return global::System.Data.SQLite.TypeAffinity.Blob;
			}
			return global::System.Data.SQLite.TypeAffinity.Text;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000E1D0 File Offset: 0x0000D5D0
		private static global::System.Data.SQLite.SQLiteDbTypeMap GetSQLiteDbTypeMap()
		{
			return new global::System.Data.SQLite.SQLiteDbTypeMap(new global::System.Data.SQLite.SQLiteDbTypeMapping[]
			{
				new global::System.Data.SQLite.SQLiteDbTypeMapping("BIGINT", global::System.Data.DbType.Int64, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("BIGUINT", global::System.Data.DbType.UInt64, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("BINARY", global::System.Data.DbType.Binary, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("BIT", global::System.Data.DbType.Boolean, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("BLOB", global::System.Data.DbType.Binary, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("BOOL", global::System.Data.DbType.Boolean, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("BOOLEAN", global::System.Data.DbType.Boolean, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("CHAR", global::System.Data.DbType.AnsiStringFixedLength, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("CLOB", global::System.Data.DbType.String, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("COUNTER", global::System.Data.DbType.Int64, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("CURRENCY", global::System.Data.DbType.Decimal, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("DATE", global::System.Data.DbType.DateTime, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("DATETIME", global::System.Data.DbType.DateTime, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("DECIMAL", global::System.Data.DbType.Decimal, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("DOUBLE", global::System.Data.DbType.Double, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("FLOAT", global::System.Data.DbType.Double, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("GENERAL", global::System.Data.DbType.Binary, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("GUID", global::System.Data.DbType.Guid, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("IDENTITY", global::System.Data.DbType.Int64, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("IMAGE", global::System.Data.DbType.Binary, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("INT", global::System.Data.DbType.Int32, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("INT8", global::System.Data.DbType.SByte, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("INT16", global::System.Data.DbType.Int16, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("INT32", global::System.Data.DbType.Int32, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("INT64", global::System.Data.DbType.Int64, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("INTEGER", global::System.Data.DbType.Int64, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("INTEGER8", global::System.Data.DbType.SByte, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("INTEGER16", global::System.Data.DbType.Int16, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("INTEGER32", global::System.Data.DbType.Int32, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("INTEGER64", global::System.Data.DbType.Int64, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("LOGICAL", global::System.Data.DbType.Boolean, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("LONG", global::System.Data.DbType.Int64, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("LONGCHAR", global::System.Data.DbType.String, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("LONGTEXT", global::System.Data.DbType.String, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("LONGVARCHAR", global::System.Data.DbType.String, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("MEMO", global::System.Data.DbType.String, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("MONEY", global::System.Data.DbType.Decimal, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("NCHAR", global::System.Data.DbType.StringFixedLength, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("NOTE", global::System.Data.DbType.String, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("NTEXT", global::System.Data.DbType.String, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("NUMBER", global::System.Data.DbType.Decimal, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("NUMERIC", global::System.Data.DbType.Decimal, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("NVARCHAR", global::System.Data.DbType.String, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("OLEOBJECT", global::System.Data.DbType.Binary, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("RAW", global::System.Data.DbType.Binary, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("REAL", global::System.Data.DbType.Double, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("SINGLE", global::System.Data.DbType.Single, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("SMALLDATE", global::System.Data.DbType.DateTime, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("SMALLINT", global::System.Data.DbType.Int16, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("SMALLUINT", global::System.Data.DbType.UInt16, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("STRING", global::System.Data.DbType.String, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("TEXT", global::System.Data.DbType.String, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("TIME", global::System.Data.DbType.DateTime, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("TIMESTAMP", global::System.Data.DbType.DateTime, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("TINYINT", global::System.Data.DbType.Byte, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("TINYSINT", global::System.Data.DbType.SByte, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("UINT", global::System.Data.DbType.UInt32, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("UINT8", global::System.Data.DbType.Byte, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("UINT16", global::System.Data.DbType.UInt16, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("UINT32", global::System.Data.DbType.UInt32, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("UINT64", global::System.Data.DbType.UInt64, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("ULONG", global::System.Data.DbType.UInt64, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("UNIQUEIDENTIFIER", global::System.Data.DbType.Guid, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("UNSIGNEDINTEGER", global::System.Data.DbType.UInt64, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("UNSIGNEDINTEGER8", global::System.Data.DbType.Byte, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("UNSIGNEDINTEGER16", global::System.Data.DbType.UInt16, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("UNSIGNEDINTEGER32", global::System.Data.DbType.UInt32, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("UNSIGNEDINTEGER64", global::System.Data.DbType.UInt64, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("VARBINARY", global::System.Data.DbType.Binary, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("VARCHAR", global::System.Data.DbType.AnsiString, true),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("VARCHAR2", global::System.Data.DbType.AnsiString, false),
				new global::System.Data.SQLite.SQLiteDbTypeMapping("YESNO", global::System.Data.DbType.Boolean, false)
			});
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000E68C File Offset: 0x0000DA8C
		internal static global::System.Data.DbType TypeNameToDbType(string Name)
		{
			lock (global::System.Data.SQLite.SQLiteConvert._syncRoot)
			{
				if (global::System.Data.SQLite.SQLiteConvert._typeNames == null)
				{
					global::System.Data.SQLite.SQLiteConvert._typeNames = global::System.Data.SQLite.SQLiteConvert.GetSQLiteDbTypeMap();
				}
				if (string.IsNullOrEmpty(Name))
				{
					return global::System.Data.DbType.Object;
				}
				global::System.Data.SQLite.SQLiteDbTypeMapping sqliteDbTypeMapping;
				if (global::System.Data.SQLite.SQLiteConvert._typeNames.TryGetValue(Name, out sqliteDbTypeMapping))
				{
					return sqliteDbTypeMapping.dataType;
				}
				int num = Name.IndexOf('(');
				if (num > 0 && global::System.Data.SQLite.SQLiteConvert._typeNames.TryGetValue(Name.Substring(0, num).TrimEnd(new char[0]), out sqliteDbTypeMapping))
				{
					return sqliteDbTypeMapping.dataType;
				}
			}
			global::System.Data.DbType dbType = global::System.Data.DbType.Object;
			global::System.Diagnostics.Trace.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "WARNING: Type mapping failed, returning default type {0} for name \"{1}\".", new object[]
			{
				dbType,
				Name
			}));
			return dbType;
		}

		// Token: 0x04000003 RID: 3
		private const string FullFormat = "yyyy-MM-ddTHH:mm:ss.fffffffK";

		// Token: 0x04000004 RID: 4
		protected static readonly global::System.DateTime UnixEpoch = new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc);

		// Token: 0x04000005 RID: 5
		private static readonly double OleAutomationEpochAsJulianDay = 2415018.5;

		// Token: 0x04000006 RID: 6
		private static string[] _datetimeFormats = new string[]
		{
			"THHmmssK",
			"THHmmK",
			"HH:mm:ss.FFFFFFFK",
			"HH:mm:ssK",
			"HH:mmK",
			"yyyy-MM-dd HH:mm:ss.FFFFFFFK",
			"yyyy-MM-dd HH:mm:ssK",
			"yyyy-MM-dd HH:mmK",
			"yyyy-MM-ddTHH:mm:ss.FFFFFFFK",
			"yyyy-MM-ddTHH:mmK",
			"yyyy-MM-ddTHH:mm:ssK",
			"yyyyMMddHHmmssK",
			"yyyyMMddHHmmK",
			"yyyyMMddTHHmmssFFFFFFFK",
			"THHmmss",
			"THHmm",
			"HH:mm:ss.FFFFFFF",
			"HH:mm:ss",
			"HH:mm",
			"yyyy-MM-dd HH:mm:ss.FFFFFFF",
			"yyyy-MM-dd HH:mm:ss",
			"yyyy-MM-dd HH:mm",
			"yyyy-MM-ddTHH:mm:ss.FFFFFFF",
			"yyyy-MM-ddTHH:mm",
			"yyyy-MM-ddTHH:mm:ss",
			"yyyyMMddHHmmss",
			"yyyyMMddHHmm",
			"yyyyMMddTHHmmssFFFFFFF",
			"yyyy-MM-dd",
			"yyyyMMdd",
			"yy-MM-dd"
		};

		// Token: 0x04000007 RID: 7
		private static readonly string _datetimeFormatUtc = global::System.Data.SQLite.SQLiteConvert._datetimeFormats[5];

		// Token: 0x04000008 RID: 8
		private static readonly string _datetimeFormatLocal = global::System.Data.SQLite.SQLiteConvert._datetimeFormats[19];

		// Token: 0x04000009 RID: 9
		private static global::System.Text.Encoding _utf8 = new global::System.Text.UTF8Encoding();

		// Token: 0x0400000A RID: 10
		internal global::System.Data.SQLite.SQLiteDateFormats _datetimeFormat;

		// Token: 0x0400000B RID: 11
		internal global::System.DateTimeKind _datetimeKind;

		// Token: 0x0400000C RID: 12
		internal string _datetimeFormatString;

		// Token: 0x0400000D RID: 13
		private static global::System.Type[] _affinitytotype = new global::System.Type[]
		{
			typeof(object),
			typeof(long),
			typeof(double),
			typeof(string),
			typeof(byte[]),
			typeof(object),
			typeof(global::System.DateTime),
			typeof(object)
		};

		// Token: 0x0400000E RID: 14
		private static global::System.Data.DbType[] _typetodbtype = new global::System.Data.DbType[]
		{
			global::System.Data.DbType.Object,
			global::System.Data.DbType.Binary,
			global::System.Data.DbType.Object,
			global::System.Data.DbType.Boolean,
			global::System.Data.DbType.SByte,
			global::System.Data.DbType.SByte,
			global::System.Data.DbType.Byte,
			global::System.Data.DbType.Int16,
			global::System.Data.DbType.UInt16,
			global::System.Data.DbType.Int32,
			global::System.Data.DbType.UInt32,
			global::System.Data.DbType.Int64,
			global::System.Data.DbType.UInt64,
			global::System.Data.DbType.Single,
			global::System.Data.DbType.Double,
			global::System.Data.DbType.Decimal,
			global::System.Data.DbType.DateTime,
			global::System.Data.DbType.Object,
			global::System.Data.DbType.String
		};

		// Token: 0x0400000F RID: 15
		private static int[] _dbtypetocolumnsize = new int[]
		{
			int.MaxValue,
			int.MaxValue,
			1,
			1,
			8,
			8,
			8,
			8,
			8,
			16,
			2,
			4,
			8,
			int.MaxValue,
			1,
			4,
			int.MaxValue,
			8,
			2,
			4,
			8,
			8,
			int.MaxValue,
			int.MaxValue,
			int.MaxValue,
			int.MaxValue
		};

		// Token: 0x04000010 RID: 16
		private static object[] _dbtypetonumericprecision = new object[]
		{
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			3,
			global::System.DBNull.Value,
			19,
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			53,
			53,
			global::System.DBNull.Value,
			5,
			10,
			19,
			global::System.DBNull.Value,
			3,
			24,
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			5,
			10,
			19,
			53,
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			global::System.DBNull.Value
		};

		// Token: 0x04000011 RID: 17
		private static object[] _dbtypetonumericscale = new object[]
		{
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			0,
			global::System.DBNull.Value,
			4,
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			0,
			0,
			0,
			global::System.DBNull.Value,
			0,
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			0,
			0,
			0,
			0,
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			global::System.DBNull.Value,
			global::System.DBNull.Value
		};

		// Token: 0x04000012 RID: 18
		private static global::System.Type[] _dbtypeToType = new global::System.Type[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(byte),
			typeof(bool),
			typeof(decimal),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(decimal),
			typeof(double),
			typeof(global::System.Guid),
			typeof(short),
			typeof(int),
			typeof(long),
			typeof(object),
			typeof(sbyte),
			typeof(float),
			typeof(string),
			typeof(global::System.DateTime),
			typeof(ushort),
			typeof(uint),
			typeof(ulong),
			typeof(double),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		};

		// Token: 0x04000013 RID: 19
		private static global::System.Data.SQLite.TypeAffinity[] _typecodeAffinities = new global::System.Data.SQLite.TypeAffinity[]
		{
			global::System.Data.SQLite.TypeAffinity.Null,
			global::System.Data.SQLite.TypeAffinity.Blob,
			global::System.Data.SQLite.TypeAffinity.Null,
			global::System.Data.SQLite.TypeAffinity.Int64,
			global::System.Data.SQLite.TypeAffinity.Int64,
			global::System.Data.SQLite.TypeAffinity.Int64,
			global::System.Data.SQLite.TypeAffinity.Int64,
			global::System.Data.SQLite.TypeAffinity.Int64,
			global::System.Data.SQLite.TypeAffinity.Int64,
			global::System.Data.SQLite.TypeAffinity.Int64,
			global::System.Data.SQLite.TypeAffinity.Int64,
			global::System.Data.SQLite.TypeAffinity.Int64,
			global::System.Data.SQLite.TypeAffinity.Int64,
			global::System.Data.SQLite.TypeAffinity.Double,
			global::System.Data.SQLite.TypeAffinity.Double,
			global::System.Data.SQLite.TypeAffinity.Double,
			global::System.Data.SQLite.TypeAffinity.DateTime,
			global::System.Data.SQLite.TypeAffinity.Null,
			global::System.Data.SQLite.TypeAffinity.Text
		};

		// Token: 0x04000014 RID: 20
		private static object _syncRoot = new object();

		// Token: 0x04000015 RID: 21
		private static global::System.Data.SQLite.SQLiteDbTypeMap _typeNames = null;
	}
}
