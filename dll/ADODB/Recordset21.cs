using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000042 RID: 66
	[global::System.Runtime.InteropServices.TypeLibType(4304)]
	[global::System.Reflection.DefaultMember("Fields")]
	[global::System.Runtime.InteropServices.Guid("00000555-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface Recordset21 : global::ADODB.Recordset20
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000BA RID: 186
		[global::System.Runtime.InteropServices.DispId(500)]
		global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000BB RID: 187
		// (set) Token: 0x060000BC RID: 188
		[global::System.Runtime.InteropServices.DispId(1000)]
		global::ADODB.PositionEnum AbsolutePosition { [global::System.Runtime.InteropServices.DispId(1000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000BF RID: 191
		// (set) Token: 0x060000BD RID: 189
		[global::System.Runtime.InteropServices.DispId(1001)]
		object ActiveConnection { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000C0 RID: 192
		[global::System.Runtime.InteropServices.DispId(1002)]
		bool BOF { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000C1 RID: 193
		// (set) Token: 0x060000C2 RID: 194
		[global::System.Runtime.InteropServices.DispId(1003)]
		object Bookmark { [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000C3 RID: 195
		// (set) Token: 0x060000C4 RID: 196
		[global::System.Runtime.InteropServices.DispId(1004)]
		int CacheSize { [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000C5 RID: 197
		// (set) Token: 0x060000C6 RID: 198
		[global::System.Runtime.InteropServices.DispId(1005)]
		global::ADODB.CursorTypeEnum CursorType { [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000C7 RID: 199
		[global::System.Runtime.InteropServices.DispId(1006)]
		bool EOF { [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000C8 RID: 200
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Fields")]
		global::ADODB.Fields Fields { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.FieldsToInternalFieldsMarshaler)] get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000C9 RID: 201
		// (set) Token: 0x060000CA RID: 202
		[global::System.Runtime.InteropServices.DispId(1008)]
		global::ADODB.LockTypeEnum LockType { [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000CB RID: 203
		// (set) Token: 0x060000CC RID: 204
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		[global::System.Runtime.InteropServices.DispId(1009)]
		int MaxRecords { [global::System.Runtime.InteropServices.DispId(1009)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; [global::System.Runtime.InteropServices.DispId(1009)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000CD RID: 205
		[global::System.Runtime.InteropServices.DispId(1010)]
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		int RecordCount { [global::System.Runtime.InteropServices.DispId(1010)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000D0 RID: 208
		// (set) Token: 0x060000CE RID: 206
		[global::System.Runtime.InteropServices.DispId(1011)]
		object Source { [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060000D1 RID: 209
		[global::System.Runtime.InteropServices.DispId(1012)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void AddNew([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object FieldList, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Values);

		// Token: 0x060000D2 RID: 210
		[global::System.Runtime.InteropServices.DispId(1013)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CancelUpdate();

		// Token: 0x060000D3 RID: 211
		[global::System.Runtime.InteropServices.DispId(1014)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Close();

		// Token: 0x060000D4 RID: 212
		[global::System.Runtime.InteropServices.DispId(1015)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Delete([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectCurrent);

		// Token: 0x060000D5 RID: 213
		[global::System.Runtime.InteropServices.DispId(1016)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object GetRows([global::System.Runtime.InteropServices.In] int Rows = -1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Start, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Fields);

		// Token: 0x060000D6 RID: 214
		[global::System.Runtime.InteropServices.DispId(1017)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Move([global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [global::System.Runtime.InteropServices.In] int NumRecords, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Start);

		// Token: 0x060000D7 RID: 215
		[global::System.Runtime.InteropServices.DispId(1018)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveNext();

		// Token: 0x060000D8 RID: 216
		[global::System.Runtime.InteropServices.DispId(1019)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MovePrevious();

		// Token: 0x060000D9 RID: 217
		[global::System.Runtime.InteropServices.DispId(1020)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveFirst();

		// Token: 0x060000DA RID: 218
		[global::System.Runtime.InteropServices.DispId(1021)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveLast();

		// Token: 0x060000DB RID: 219
		[global::System.Runtime.InteropServices.DispId(1022)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Open([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Source, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object ActiveConnection, [global::System.Runtime.InteropServices.In] global::ADODB.CursorTypeEnum CursorType = global::ADODB.CursorTypeEnum.adOpenUnspecified, [global::System.Runtime.InteropServices.In] global::ADODB.LockTypeEnum LockType = global::ADODB.LockTypeEnum.adLockUnspecified, [global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x060000DC RID: 220
		[global::System.Runtime.InteropServices.DispId(1023)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Requery([global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x060000DD RID: 221
		[global::System.Runtime.InteropServices.DispId(1610809378)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void _xResync([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectAll);

		// Token: 0x060000DE RID: 222
		[global::System.Runtime.InteropServices.DispId(1025)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Update([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Fields, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Values);

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000DF RID: 223
		// (set) Token: 0x060000E0 RID: 224
		[global::System.Runtime.InteropServices.DispId(1047)]
		global::ADODB.PositionEnum AbsolutePage { [global::System.Runtime.InteropServices.DispId(1047)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1047)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000E1 RID: 225
		[global::System.Runtime.InteropServices.DispId(1026)]
		global::ADODB.EditModeEnum EditMode { [global::System.Runtime.InteropServices.DispId(1026)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000E2 RID: 226
		// (set) Token: 0x060000E3 RID: 227
		[global::System.Runtime.InteropServices.DispId(1030)]
		object Filter { [global::System.Runtime.InteropServices.DispId(1030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000E4 RID: 228
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		[global::System.Runtime.InteropServices.DispId(1050)]
		int PageCount { [global::System.Runtime.InteropServices.DispId(1050)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000E5 RID: 229
		// (set) Token: 0x060000E6 RID: 230
		[global::System.Runtime.InteropServices.DispId(1048)]
		int PageSize { [global::System.Runtime.InteropServices.DispId(1048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000E7 RID: 231
		// (set) Token: 0x060000E8 RID: 232
		[global::System.Runtime.InteropServices.DispId(1031)]
		string Sort { [global::System.Runtime.InteropServices.DispId(1031)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1031)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000E9 RID: 233
		[global::System.Runtime.InteropServices.DispId(1029)]
		int Status { [global::System.Runtime.InteropServices.DispId(1029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000EA RID: 234
		[global::System.Runtime.InteropServices.DispId(1054)]
		int State { [global::System.Runtime.InteropServices.DispId(1054)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060000EB RID: 235
		[global::System.Runtime.InteropServices.DispId(1610809392)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::ADODB.Recordset _xClone();

		// Token: 0x060000EC RID: 236
		[global::System.Runtime.InteropServices.DispId(1035)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void UpdateBatch([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectAll);

		// Token: 0x060000ED RID: 237
		[global::System.Runtime.InteropServices.DispId(1049)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CancelBatch([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectAll);

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000EE RID: 238
		// (set) Token: 0x060000EF RID: 239
		[global::System.Runtime.InteropServices.DispId(1051)]
		global::ADODB.CursorLocationEnum CursorLocation { [global::System.Runtime.InteropServices.DispId(1051)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1051)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060000F0 RID: 240
		[global::System.Runtime.InteropServices.DispId(1052)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::ADODB.Recordset NextRecordset([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.Optional] out object RecordsAffected);

		// Token: 0x060000F1 RID: 241
		[global::System.Runtime.InteropServices.DispId(1036)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool Supports([global::System.Runtime.InteropServices.In] global::ADODB.CursorOptionEnum CursorOptions);

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000F2 RID: 242
		// (set) Token: 0x060000F3 RID: 243
		[global::System.Runtime.InteropServices.DispId(-8)]
		object Collect { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(-8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-8)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000F4 RID: 244
		// (set) Token: 0x060000F5 RID: 245
		[global::System.Runtime.InteropServices.DispId(1053)]
		global::ADODB.MarshalOptionsEnum MarshalOptions { [global::System.Runtime.InteropServices.DispId(1053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060000F6 RID: 246
		[global::System.Runtime.InteropServices.DispId(1058)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Find([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Criteria, [global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [global::System.Runtime.InteropServices.In] int SkipRecords = 0, [global::System.Runtime.InteropServices.In] global::ADODB.SearchDirectionEnum SearchDirection = global::ADODB.SearchDirectionEnum.adSearchForward, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Start);

		// Token: 0x060000F7 RID: 247
		[global::System.Runtime.InteropServices.DispId(1055)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Cancel();

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000F8 RID: 248
		// (set) Token: 0x060000F9 RID: 249
		[global::System.Runtime.InteropServices.DispId(1056)]
		object DataSource { [global::System.Runtime.InteropServices.DispId(1056)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; [global::System.Runtime.InteropServices.DispId(1056)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060000FA RID: 250
		[global::System.Runtime.InteropServices.DispId(1610874883)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void _xSave([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string FileName = "", [global::System.Runtime.InteropServices.In] global::ADODB.PersistFormatEnum PersistFormat = global::ADODB.PersistFormatEnum.adPersistADTG);

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000FB RID: 251
		[global::System.Runtime.InteropServices.DispId(1061)]
		object ActiveCommand { [global::System.Runtime.InteropServices.DispId(1061)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000FD RID: 253
		// (set) Token: 0x060000FC RID: 252
		[global::System.Runtime.InteropServices.DispId(1063)]
		bool StayInSync { [global::System.Runtime.InteropServices.DispId(1063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060000FE RID: 254
		[global::System.Runtime.InteropServices.DispId(1062)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string GetString([global::System.Runtime.InteropServices.In] global::ADODB.StringFormatEnum StringFormat = global::ADODB.StringFormatEnum.adClipString, [global::System.Runtime.InteropServices.In] int NumRows = -1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string ColumnDelimeter = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string RowDelimeter = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string NullExpr = "");

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000FF RID: 255
		// (set) Token: 0x06000100 RID: 256
		[global::System.Runtime.InteropServices.DispId(1064)]
		string DataMember { [global::System.Runtime.InteropServices.DispId(1064)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1064)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000101 RID: 257
		[global::System.Runtime.InteropServices.DispId(1065)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		global::ADODB.CompareEnum CompareBookmarks([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Bookmark1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Bookmark2);

		// Token: 0x06000102 RID: 258
		[global::System.Runtime.InteropServices.DispId(1034)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::ADODB.Recordset Clone([global::System.Runtime.InteropServices.In] global::ADODB.LockTypeEnum LockType = global::ADODB.LockTypeEnum.adLockUnspecified);

		// Token: 0x06000103 RID: 259
		[global::System.Runtime.InteropServices.DispId(1024)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Resync([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectAll, [global::System.Runtime.InteropServices.In] global::ADODB.ResyncEnum ResyncValues = global::ADODB.ResyncEnum.adResyncAllValues);

		// Token: 0x06000104 RID: 260
		[global::System.Runtime.InteropServices.DispId(1066)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Seek([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object KeyValues, [global::System.Runtime.InteropServices.In] global::ADODB.SeekEnum SeekOption = global::ADODB.SeekEnum.adSeekFirstEQ);

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000106 RID: 262
		// (set) Token: 0x06000105 RID: 261
		[global::System.Runtime.InteropServices.DispId(1067)]
		string Index { [global::System.Runtime.InteropServices.DispId(1067)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1067)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
