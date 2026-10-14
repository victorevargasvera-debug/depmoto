using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Data.SQLite
{
	// Token: 0x02000052 RID: 82
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	internal static class UnsafeNativeMethods
	{
		// Token: 0x060003D9 RID: 985
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_bind_parameter_name_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003DA RID: 986
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_column_database_name_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003DB RID: 987
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_column_database_name16_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003DC RID: 988
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_column_decltype_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003DD RID: 989
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_column_decltype16_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003DE RID: 990
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_column_name_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003DF RID: 991
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_column_name16_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003E0 RID: 992
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_column_origin_name_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003E1 RID: 993
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_column_origin_name16_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003E2 RID: 994
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_column_table_name_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003E3 RID: 995
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_column_table_name16_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003E4 RID: 996
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_column_text_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003E5 RID: 997
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_column_text16_interop(global::System.IntPtr stmt, int index, out int len);

		// Token: 0x060003E6 RID: 998
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_errmsg_interop(global::System.IntPtr db, out int len);

		// Token: 0x060003E7 RID: 999
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_prepare_interop(global::System.IntPtr db, global::System.IntPtr pSql, int nBytes, out global::System.IntPtr stmt, out global::System.IntPtr ptrRemain, out int nRemain);

		// Token: 0x060003E8 RID: 1000
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_table_column_metadata_interop(global::System.IntPtr db, byte[] dbName, byte[] tblName, byte[] colName, out global::System.IntPtr ptrDataType, out global::System.IntPtr ptrCollSeq, out int notNull, out int primaryKey, out int autoInc, out int dtLen, out int csLen);

		// Token: 0x060003E9 RID: 1001
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_value_text_interop(global::System.IntPtr p, out int len);

		// Token: 0x060003EA RID: 1002
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_value_text16_interop(global::System.IntPtr p, out int len);

		// Token: 0x060003EB RID: 1003
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern int sqlite3_malloc_size_interop(global::System.IntPtr p);

		// Token: 0x060003EC RID: 1004
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_libversion_interop();

		// Token: 0x060003ED RID: 1005
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_sourceid_interop();

		// Token: 0x060003EE RID: 1006
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_close_interop(global::System.IntPtr db);

		// Token: 0x060003EF RID: 1007
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_create_function_interop(global::System.IntPtr db, byte[] strName, int nArgs, int nType, global::System.IntPtr pvUser, global::System.Data.SQLite.SQLiteCallback func, global::System.Data.SQLite.SQLiteCallback fstep, global::System.Data.SQLite.SQLiteFinalCallback ffinal, int needCollSeq);

		// Token: 0x060003F0 RID: 1008
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_finalize_interop(global::System.IntPtr stmt);

		// Token: 0x060003F1 RID: 1009
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_backup_finish_interop(global::System.IntPtr backup);

		// Token: 0x060003F2 RID: 1010
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_open_interop(byte[] utf8Filename, global::System.Data.SQLite.SQLiteOpenFlagsEnum flags, out global::System.IntPtr db);

		// Token: 0x060003F3 RID: 1011
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_open16_interop(byte[] utf8Filename, global::System.Data.SQLite.SQLiteOpenFlagsEnum flags, out global::System.IntPtr db);

		// Token: 0x060003F4 RID: 1012
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_reset_interop(global::System.IntPtr stmt);

		// Token: 0x060003F5 RID: 1013
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern int sqlite3_changes_interop(global::System.IntPtr db);

		// Token: 0x060003F6 RID: 1014
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.IntPtr sqlite3_context_collseq_interop(global::System.IntPtr context, out int type, out int enc, out int len);

		// Token: 0x060003F7 RID: 1015
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern int sqlite3_context_collcompare_interop(global::System.IntPtr context, byte[] p1, int p1len, byte[] p2, int p2len);

		// Token: 0x060003F8 RID: 1016
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_cursor_rowid_interop(global::System.IntPtr stmt, int cursor, out long rowid);

		// Token: 0x060003F9 RID: 1017
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_index_column_info_interop(global::System.IntPtr db, byte[] catalog, byte[] IndexName, byte[] ColumnName, out int sortOrder, out int onError, out global::System.IntPtr Collation, out int colllen);

		// Token: 0x060003FA RID: 1018
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern void sqlite3_resetall_interop(global::System.IntPtr db);

		// Token: 0x060003FB RID: 1019
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll")]
		internal static extern int sqlite3_table_cursor_interop(global::System.IntPtr stmt, int db, int tableRootPage);

		// Token: 0x060003FC RID: 1020
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_enable_load_extension(global::System.IntPtr db, int enable);

		// Token: 0x060003FD RID: 1021
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_load_extension(global::System.IntPtr db, byte[] fileName, byte[] procName, ref global::System.IntPtr pError);

		// Token: 0x060003FE RID: 1022
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_overload_function(global::System.IntPtr db, global::System.IntPtr zName, int nArgs);

		// Token: 0x060003FF RID: 1023
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_win32_set_directory(uint type, string value);

		// Token: 0x06000400 RID: 1024
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_libversion();

		// Token: 0x06000401 RID: 1025
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_libversion_number();

		// Token: 0x06000402 RID: 1026
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_sourceid();

		// Token: 0x06000403 RID: 1027
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_malloc(int n);

		// Token: 0x06000404 RID: 1028
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_realloc(global::System.IntPtr p, int n);

		// Token: 0x06000405 RID: 1029
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_free(global::System.IntPtr p);

		// Token: 0x06000406 RID: 1030
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_open_v2(byte[] utf8Filename, out global::System.IntPtr db, global::System.Data.SQLite.SQLiteOpenFlagsEnum flags, global::System.IntPtr vfs);

		// Token: 0x06000407 RID: 1031
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_open16(string fileName, out global::System.IntPtr db);

		// Token: 0x06000408 RID: 1032
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_interrupt(global::System.IntPtr db);

		// Token: 0x06000409 RID: 1033
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern long sqlite3_last_insert_rowid(global::System.IntPtr db);

		// Token: 0x0600040A RID: 1034
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_changes(global::System.IntPtr db);

		// Token: 0x0600040B RID: 1035
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern long sqlite3_memory_used();

		// Token: 0x0600040C RID: 1036
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern long sqlite3_memory_highwater(int resetFlag);

		// Token: 0x0600040D RID: 1037
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_shutdown();

		// Token: 0x0600040E RID: 1038
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_busy_timeout(global::System.IntPtr db, int ms);

		// Token: 0x0600040F RID: 1039
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_bind_blob(global::System.IntPtr stmt, int index, byte[] value, int nSize, global::System.IntPtr nTransient);

		// Token: 0x06000410 RID: 1040
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_bind_double(global::System.IntPtr stmt, int index, double value);

		// Token: 0x06000411 RID: 1041
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_bind_int(global::System.IntPtr stmt, int index, int value);

		// Token: 0x06000412 RID: 1042
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "sqlite3_bind_int")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_bind_uint(global::System.IntPtr stmt, int index, uint value);

		// Token: 0x06000413 RID: 1043
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_bind_int64(global::System.IntPtr stmt, int index, long value);

		// Token: 0x06000414 RID: 1044
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "sqlite3_bind_int64")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_bind_uint64(global::System.IntPtr stmt, int index, ulong value);

		// Token: 0x06000415 RID: 1045
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_bind_null(global::System.IntPtr stmt, int index);

		// Token: 0x06000416 RID: 1046
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_bind_text(global::System.IntPtr stmt, int index, byte[] value, int nlen, global::System.IntPtr pvReserved);

		// Token: 0x06000417 RID: 1047
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_bind_parameter_count(global::System.IntPtr stmt);

		// Token: 0x06000418 RID: 1048
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_bind_parameter_index(global::System.IntPtr stmt, byte[] strName);

		// Token: 0x06000419 RID: 1049
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_column_count(global::System.IntPtr stmt);

		// Token: 0x0600041A RID: 1050
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_step(global::System.IntPtr stmt);

		// Token: 0x0600041B RID: 1051
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern double sqlite3_column_double(global::System.IntPtr stmt, int index);

		// Token: 0x0600041C RID: 1052
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_column_int(global::System.IntPtr stmt, int index);

		// Token: 0x0600041D RID: 1053
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern long sqlite3_column_int64(global::System.IntPtr stmt, int index);

		// Token: 0x0600041E RID: 1054
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_column_blob(global::System.IntPtr stmt, int index);

		// Token: 0x0600041F RID: 1055
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_column_bytes(global::System.IntPtr stmt, int index);

		// Token: 0x06000420 RID: 1056
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_column_bytes16(global::System.IntPtr stmt, int index);

		// Token: 0x06000421 RID: 1057
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.TypeAffinity sqlite3_column_type(global::System.IntPtr stmt, int index);

		// Token: 0x06000422 RID: 1058
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_create_collation(global::System.IntPtr db, byte[] strName, int nType, global::System.IntPtr pvUser, global::System.Data.SQLite.SQLiteCollation func);

		// Token: 0x06000423 RID: 1059
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_aggregate_count(global::System.IntPtr context);

		// Token: 0x06000424 RID: 1060
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_value_blob(global::System.IntPtr p);

		// Token: 0x06000425 RID: 1061
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_value_bytes(global::System.IntPtr p);

		// Token: 0x06000426 RID: 1062
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_value_bytes16(global::System.IntPtr p);

		// Token: 0x06000427 RID: 1063
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern double sqlite3_value_double(global::System.IntPtr p);

		// Token: 0x06000428 RID: 1064
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_value_int(global::System.IntPtr p);

		// Token: 0x06000429 RID: 1065
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern long sqlite3_value_int64(global::System.IntPtr p);

		// Token: 0x0600042A RID: 1066
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.TypeAffinity sqlite3_value_type(global::System.IntPtr p);

		// Token: 0x0600042B RID: 1067
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_blob(global::System.IntPtr context, byte[] value, int nSize, global::System.IntPtr pvReserved);

		// Token: 0x0600042C RID: 1068
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_double(global::System.IntPtr context, double value);

		// Token: 0x0600042D RID: 1069
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_error(global::System.IntPtr context, byte[] strErr, int nLen);

		// Token: 0x0600042E RID: 1070
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_error_code(global::System.IntPtr context, global::System.Data.SQLite.SQLiteErrorCode value);

		// Token: 0x0600042F RID: 1071
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_error_toobig(global::System.IntPtr context);

		// Token: 0x06000430 RID: 1072
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_error_nomem(global::System.IntPtr context);

		// Token: 0x06000431 RID: 1073
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_value(global::System.IntPtr context, global::System.IntPtr value);

		// Token: 0x06000432 RID: 1074
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_zeroblob(global::System.IntPtr context, int nLen);

		// Token: 0x06000433 RID: 1075
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_int(global::System.IntPtr context, int value);

		// Token: 0x06000434 RID: 1076
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_int64(global::System.IntPtr context, long value);

		// Token: 0x06000435 RID: 1077
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_null(global::System.IntPtr context);

		// Token: 0x06000436 RID: 1078
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_result_text(global::System.IntPtr context, byte[] value, int nLen, global::System.IntPtr pvReserved);

		// Token: 0x06000437 RID: 1079
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_aggregate_context(global::System.IntPtr context, int nBytes);

		// Token: 0x06000438 RID: 1080
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_bind_text16(global::System.IntPtr stmt, int index, string value, int nlen, global::System.IntPtr pvReserved);

		// Token: 0x06000439 RID: 1081
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern void sqlite3_result_error16(global::System.IntPtr context, string strName, int nLen);

		// Token: 0x0600043A RID: 1082
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern void sqlite3_result_text16(global::System.IntPtr context, string strName, int nLen, global::System.IntPtr pvReserved);

		// Token: 0x0600043B RID: 1083
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_key(global::System.IntPtr db, byte[] key, int keylen);

		// Token: 0x0600043C RID: 1084
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_rekey(global::System.IntPtr db, byte[] key, int keylen);

		// Token: 0x0600043D RID: 1085
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_set_authorizer(global::System.IntPtr db, global::System.Data.SQLite.SQLiteAuthorizerCallback func, global::System.IntPtr pvUser);

		// Token: 0x0600043E RID: 1086
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_update_hook(global::System.IntPtr db, global::System.Data.SQLite.SQLiteUpdateCallback func, global::System.IntPtr pvUser);

		// Token: 0x0600043F RID: 1087
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_commit_hook(global::System.IntPtr db, global::System.Data.SQLite.SQLiteCommitCallback func, global::System.IntPtr pvUser);

		// Token: 0x06000440 RID: 1088
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_trace(global::System.IntPtr db, global::System.Data.SQLite.SQLiteTraceCallback func, global::System.IntPtr pvUser);

		// Token: 0x06000441 RID: 1089
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "sqlite3_config")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_config_none(global::System.Data.SQLite.SQLiteConfigOpsEnum op);

		// Token: 0x06000442 RID: 1090
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "sqlite3_config")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_config_int(global::System.Data.SQLite.SQLiteConfigOpsEnum op, int value);

		// Token: 0x06000443 RID: 1091
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "sqlite3_config")]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_config_log(global::System.Data.SQLite.SQLiteConfigOpsEnum op, global::System.Data.SQLite.SQLiteLogCallback func, global::System.IntPtr pvUser);

		// Token: 0x06000444 RID: 1092
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_rollback_hook(global::System.IntPtr db, global::System.Data.SQLite.SQLiteRollbackCallback func, global::System.IntPtr pvUser);

		// Token: 0x06000445 RID: 1093
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_db_handle(global::System.IntPtr stmt);

		// Token: 0x06000446 RID: 1094
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_db_filename(global::System.IntPtr db, global::System.IntPtr dbName);

		// Token: 0x06000447 RID: 1095
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_next_stmt(global::System.IntPtr db, global::System.IntPtr stmt);

		// Token: 0x06000448 RID: 1096
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_exec(global::System.IntPtr db, byte[] strSql, global::System.IntPtr pvCallback, global::System.IntPtr pvParam, out global::System.IntPtr errMsg);

		// Token: 0x06000449 RID: 1097
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_get_autocommit(global::System.IntPtr db);

		// Token: 0x0600044A RID: 1098
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_extended_result_codes(global::System.IntPtr db, int onoff);

		// Token: 0x0600044B RID: 1099
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_errcode(global::System.IntPtr db);

		// Token: 0x0600044C RID: 1100
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_extended_errcode(global::System.IntPtr db);

		// Token: 0x0600044D RID: 1101
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_errstr(global::System.Data.SQLite.SQLiteErrorCode rc);

		// Token: 0x0600044E RID: 1102
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_log(global::System.Data.SQLite.SQLiteErrorCode iErrCode, byte[] zFormat);

		// Token: 0x0600044F RID: 1103
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_file_control(global::System.IntPtr db, byte[] zDbName, int op, global::System.IntPtr pArg);

		// Token: 0x06000450 RID: 1104
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_backup_init(global::System.IntPtr destDb, byte[] zDestName, global::System.IntPtr sourceDb, byte[] zSourceName);

		// Token: 0x06000451 RID: 1105
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_backup_step(global::System.IntPtr backup, int nPage);

		// Token: 0x06000452 RID: 1106
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_backup_remaining(global::System.IntPtr backup);

		// Token: 0x06000453 RID: 1107
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int sqlite3_backup_pagecount(global::System.IntPtr backup);

		// Token: 0x06000454 RID: 1108
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.Data.SQLite.SQLiteErrorCode sqlite3_declare_vtab(global::System.IntPtr db, global::System.IntPtr zSQL);

		// Token: 0x06000455 RID: 1109
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_mprintf(global::System.IntPtr format, __arglist);

		// Token: 0x06000456 RID: 1110
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::System.IntPtr sqlite3_create_disposable_module(global::System.IntPtr db, global::System.IntPtr name, ref global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_module module, global::System.IntPtr pClientData, global::System.Data.SQLite.UnsafeNativeMethods.xDestroyModule xDestroy);

		// Token: 0x06000457 RID: 1111
		[global::System.Runtime.InteropServices.DllImport("System.Data.SQLite.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern void sqlite3_dispose_module(global::System.IntPtr pModule);

		// Token: 0x040001CB RID: 459
		internal const string SQLITE_DLL = "System.Data.SQLite.dll";

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000459 RID: 1113
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xCreate(global::System.IntPtr pDb, global::System.IntPtr pAux, int argc, global::System.IntPtr argv, ref global::System.IntPtr pVtab, ref global::System.IntPtr pError);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x0600045D RID: 1117
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xConnect(global::System.IntPtr pDb, global::System.IntPtr pAux, int argc, global::System.IntPtr argv, ref global::System.IntPtr pVtab, ref global::System.IntPtr pError);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000461 RID: 1121
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xBestIndex(global::System.IntPtr pVtab, global::System.IntPtr pIndex);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x06000465 RID: 1125
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xDisconnect(global::System.IntPtr pVtab);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x06000469 RID: 1129
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xDestroy(global::System.IntPtr pVtab);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x0600046D RID: 1133
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xOpen(global::System.IntPtr pVtab, ref global::System.IntPtr pCursor);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x06000471 RID: 1137
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xClose(global::System.IntPtr pCursor);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x06000475 RID: 1141
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xFilter(global::System.IntPtr pCursor, int idxNum, global::System.IntPtr idxStr, int argc, global::System.IntPtr argv);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000479 RID: 1145
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xNext(global::System.IntPtr pCursor);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x0600047D RID: 1149
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate int xEof(global::System.IntPtr pCursor);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000481 RID: 1153
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xColumn(global::System.IntPtr pCursor, global::System.IntPtr pContext, int index);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000485 RID: 1157
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xRowId(global::System.IntPtr pCursor, ref long rowId);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000489 RID: 1161
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xUpdate(global::System.IntPtr pVtab, int argc, global::System.IntPtr argv, ref long rowId);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x0600048D RID: 1165
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xBegin(global::System.IntPtr pVtab);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x06000491 RID: 1169
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xSync(global::System.IntPtr pVtab);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x06000495 RID: 1173
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xCommit(global::System.IntPtr pVtab);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x06000499 RID: 1177
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xRollback(global::System.IntPtr pVtab);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x0600049D RID: 1181
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate int xFindFunction(global::System.IntPtr pVtab, int nArg, global::System.IntPtr zName, ref global::System.Data.SQLite.SQLiteCallback callback, ref global::System.IntPtr pUserData);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060004A1 RID: 1185
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xRename(global::System.IntPtr pVtab, global::System.IntPtr zNew);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060004A5 RID: 1189
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xSavepoint(global::System.IntPtr pVtab, int iSavepoint);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060004A9 RID: 1193
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xRelease(global::System.IntPtr pVtab, int iSavepoint);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060004AD RID: 1197
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate global::System.Data.SQLite.SQLiteErrorCode xRollbackTo(global::System.IntPtr pVtab, int iSavepoint);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060004B1 RID: 1201
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate void xDestroyModule(global::System.IntPtr pClientData);

		// Token: 0x0200006A RID: 106
		internal struct sqlite3_module
		{
			// Token: 0x040001CC RID: 460
			public int iVersion;

			// Token: 0x040001CD RID: 461
			public global::System.Data.SQLite.UnsafeNativeMethods.xCreate xCreate;

			// Token: 0x040001CE RID: 462
			public global::System.Data.SQLite.UnsafeNativeMethods.xConnect xConnect;

			// Token: 0x040001CF RID: 463
			public global::System.Data.SQLite.UnsafeNativeMethods.xBestIndex xBestIndex;

			// Token: 0x040001D0 RID: 464
			public global::System.Data.SQLite.UnsafeNativeMethods.xDisconnect xDisconnect;

			// Token: 0x040001D1 RID: 465
			public global::System.Data.SQLite.UnsafeNativeMethods.xDestroy xDestroy;

			// Token: 0x040001D2 RID: 466
			public global::System.Data.SQLite.UnsafeNativeMethods.xOpen xOpen;

			// Token: 0x040001D3 RID: 467
			public global::System.Data.SQLite.UnsafeNativeMethods.xClose xClose;

			// Token: 0x040001D4 RID: 468
			public global::System.Data.SQLite.UnsafeNativeMethods.xFilter xFilter;

			// Token: 0x040001D5 RID: 469
			public global::System.Data.SQLite.UnsafeNativeMethods.xNext xNext;

			// Token: 0x040001D6 RID: 470
			public global::System.Data.SQLite.UnsafeNativeMethods.xEof xEof;

			// Token: 0x040001D7 RID: 471
			public global::System.Data.SQLite.UnsafeNativeMethods.xColumn xColumn;

			// Token: 0x040001D8 RID: 472
			public global::System.Data.SQLite.UnsafeNativeMethods.xRowId xRowId;

			// Token: 0x040001D9 RID: 473
			public global::System.Data.SQLite.UnsafeNativeMethods.xUpdate xUpdate;

			// Token: 0x040001DA RID: 474
			public global::System.Data.SQLite.UnsafeNativeMethods.xBegin xBegin;

			// Token: 0x040001DB RID: 475
			public global::System.Data.SQLite.UnsafeNativeMethods.xSync xSync;

			// Token: 0x040001DC RID: 476
			public global::System.Data.SQLite.UnsafeNativeMethods.xCommit xCommit;

			// Token: 0x040001DD RID: 477
			public global::System.Data.SQLite.UnsafeNativeMethods.xRollback xRollback;

			// Token: 0x040001DE RID: 478
			public global::System.Data.SQLite.UnsafeNativeMethods.xFindFunction xFindFunction;

			// Token: 0x040001DF RID: 479
			public global::System.Data.SQLite.UnsafeNativeMethods.xRename xRename;

			// Token: 0x040001E0 RID: 480
			public global::System.Data.SQLite.UnsafeNativeMethods.xSavepoint xSavepoint;

			// Token: 0x040001E1 RID: 481
			public global::System.Data.SQLite.UnsafeNativeMethods.xRelease xRelease;

			// Token: 0x040001E2 RID: 482
			public global::System.Data.SQLite.UnsafeNativeMethods.xRollbackTo xRollbackTo;
		}

		// Token: 0x0200006B RID: 107
		internal struct sqlite3_vtab
		{
			// Token: 0x040001E3 RID: 483
			public global::System.IntPtr pModule;

			// Token: 0x040001E4 RID: 484
			public int nRef;

			// Token: 0x040001E5 RID: 485
			public global::System.IntPtr zErrMsg;
		}

		// Token: 0x0200006C RID: 108
		internal struct sqlite3_vtab_cursor
		{
			// Token: 0x040001E6 RID: 486
			public global::System.IntPtr pVTab;
		}

		// Token: 0x0200006D RID: 109
		internal struct sqlite3_index_constraint
		{
			// Token: 0x060004B4 RID: 1204 RVA: 0x00020D44 File Offset: 0x00020144
			public sqlite3_index_constraint(global::System.Data.SQLite.SQLiteIndexConstraint constraint)
			{
				this = default(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_constraint);
				if (constraint != null)
				{
					this.iColumn = constraint.iColumn;
					this.op = constraint.op;
					this.usable = constraint.usable;
					this.iTermOffset = constraint.iTermOffset;
				}
			}

			// Token: 0x040001E7 RID: 487
			public int iColumn;

			// Token: 0x040001E8 RID: 488
			public global::System.Data.SQLite.SQLiteIndexConstraintOp op;

			// Token: 0x040001E9 RID: 489
			public byte usable;

			// Token: 0x040001EA RID: 490
			public int iTermOffset;
		}

		// Token: 0x0200006E RID: 110
		internal struct sqlite3_index_orderby
		{
			// Token: 0x060004B5 RID: 1205 RVA: 0x00020D8C File Offset: 0x0002018C
			public sqlite3_index_orderby(global::System.Data.SQLite.SQLiteIndexOrderBy orderBy)
			{
				this = default(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_orderby);
				if (orderBy != null)
				{
					this.iColumn = orderBy.iColumn;
					this.desc = orderBy.desc;
				}
			}

			// Token: 0x040001EB RID: 491
			public int iColumn;

			// Token: 0x040001EC RID: 492
			public byte desc;
		}

		// Token: 0x0200006F RID: 111
		internal struct sqlite3_index_constraint_usage
		{
			// Token: 0x060004B6 RID: 1206 RVA: 0x00020DBC File Offset: 0x000201BC
			public sqlite3_index_constraint_usage(global::System.Data.SQLite.SQLiteIndexConstraintUsage constraintUsage)
			{
				this = default(global::System.Data.SQLite.UnsafeNativeMethods.sqlite3_index_constraint_usage);
				if (constraintUsage != null)
				{
					this.argvIndex = constraintUsage.argvIndex;
					this.omit = constraintUsage.omit;
				}
			}

			// Token: 0x040001ED RID: 493
			public int argvIndex;

			// Token: 0x040001EE RID: 494
			public byte omit;
		}
	}
}
