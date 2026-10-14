using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000041 RID: 65
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Reflection.DefaultMember("Fields")]
	[global::System.Runtime.InteropServices.Guid("00000556-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface _Recordset : global::ADODB.Recordset21
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600006C RID: 108
		[global::System.Runtime.InteropServices.DispId(500)]
		global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600006D RID: 109
		// (set) Token: 0x0600006E RID: 110
		[global::System.Runtime.InteropServices.DispId(1000)]
		global::ADODB.PositionEnum AbsolutePosition { [global::System.Runtime.InteropServices.DispId(1000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1000)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000071 RID: 113
		// (set) Token: 0x0600006F RID: 111
		[global::System.Runtime.InteropServices.DispId(1001)]
		object ActiveConnection { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000072 RID: 114
		[global::System.Runtime.InteropServices.DispId(1002)]
		bool BOF { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000073 RID: 115
		// (set) Token: 0x06000074 RID: 116
		[global::System.Runtime.InteropServices.DispId(1003)]
		object Bookmark { [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000075 RID: 117
		// (set) Token: 0x06000076 RID: 118
		[global::System.Runtime.InteropServices.DispId(1004)]
		int CacheSize { [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000077 RID: 119
		// (set) Token: 0x06000078 RID: 120
		[global::System.Runtime.InteropServices.DispId(1005)]
		global::ADODB.CursorTypeEnum CursorType { [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000079 RID: 121
		[global::System.Runtime.InteropServices.DispId(1006)]
		bool EOF { [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600007A RID: 122
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Fields")]
		global::ADODB.Fields Fields { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.FieldsToInternalFieldsMarshaler)] get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600007B RID: 123
		// (set) Token: 0x0600007C RID: 124
		[global::System.Runtime.InteropServices.DispId(1008)]
		global::ADODB.LockTypeEnum LockType { [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600007D RID: 125
		// (set) Token: 0x0600007E RID: 126
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		[global::System.Runtime.InteropServices.DispId(1009)]
		int MaxRecords { [global::System.Runtime.InteropServices.DispId(1009)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; [global::System.Runtime.InteropServices.DispId(1009)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600007F RID: 127
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		[global::System.Runtime.InteropServices.DispId(1010)]
		int RecordCount { [global::System.Runtime.InteropServices.DispId(1010)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000082 RID: 130
		// (set) Token: 0x06000080 RID: 128
		[global::System.Runtime.InteropServices.DispId(1011)]
		object Source { [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000083 RID: 131
		[global::System.Runtime.InteropServices.DispId(1012)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void AddNew([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object FieldList, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Values);

		// Token: 0x06000084 RID: 132
		[global::System.Runtime.InteropServices.DispId(1013)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CancelUpdate();

		// Token: 0x06000085 RID: 133
		[global::System.Runtime.InteropServices.DispId(1014)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Close();

		// Token: 0x06000086 RID: 134
		[global::System.Runtime.InteropServices.DispId(1015)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Delete([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectCurrent);

		// Token: 0x06000087 RID: 135
		[global::System.Runtime.InteropServices.DispId(1016)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object GetRows([global::System.Runtime.InteropServices.In] int Rows = -1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Start, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Fields);

		// Token: 0x06000088 RID: 136
		[global::System.Runtime.InteropServices.DispId(1017)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Move([global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [global::System.Runtime.InteropServices.In] int NumRecords, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Start);

		// Token: 0x06000089 RID: 137
		[global::System.Runtime.InteropServices.DispId(1018)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveNext();

		// Token: 0x0600008A RID: 138
		[global::System.Runtime.InteropServices.DispId(1019)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MovePrevious();

		// Token: 0x0600008B RID: 139
		[global::System.Runtime.InteropServices.DispId(1020)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveFirst();

		// Token: 0x0600008C RID: 140
		[global::System.Runtime.InteropServices.DispId(1021)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void MoveLast();

		// Token: 0x0600008D RID: 141
		[global::System.Runtime.InteropServices.DispId(1022)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Open([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Source, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object ActiveConnection, [global::System.Runtime.InteropServices.In] global::ADODB.CursorTypeEnum CursorType = global::ADODB.CursorTypeEnum.adOpenUnspecified, [global::System.Runtime.InteropServices.In] global::ADODB.LockTypeEnum LockType = global::ADODB.LockTypeEnum.adLockUnspecified, [global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x0600008E RID: 142
		[global::System.Runtime.InteropServices.DispId(1023)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Requery([global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x0600008F RID: 143
		[global::System.Runtime.InteropServices.DispId(1610809378)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void _xResync([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectAll);

		// Token: 0x06000090 RID: 144
		[global::System.Runtime.InteropServices.DispId(1025)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Update([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Fields, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Values);

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000091 RID: 145
		// (set) Token: 0x06000092 RID: 146
		[global::System.Runtime.InteropServices.DispId(1047)]
		global::ADODB.PositionEnum AbsolutePage { [global::System.Runtime.InteropServices.DispId(1047)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1047)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000093 RID: 147
		[global::System.Runtime.InteropServices.DispId(1026)]
		global::ADODB.EditModeEnum EditMode { [global::System.Runtime.InteropServices.DispId(1026)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000094 RID: 148
		// (set) Token: 0x06000095 RID: 149
		[global::System.Runtime.InteropServices.DispId(1030)]
		object Filter { [global::System.Runtime.InteropServices.DispId(1030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000096 RID: 150
		[global::System.Runtime.InteropServices.DispId(1050)]
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		int PageCount { [global::System.Runtime.InteropServices.DispId(1050)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000097 RID: 151
		// (set) Token: 0x06000098 RID: 152
		[global::System.Runtime.InteropServices.DispId(1048)]
		int PageSize { [global::System.Runtime.InteropServices.DispId(1048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000099 RID: 153
		// (set) Token: 0x0600009A RID: 154
		[global::System.Runtime.InteropServices.DispId(1031)]
		string Sort { [global::System.Runtime.InteropServices.DispId(1031)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1031)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600009B RID: 155
		[global::System.Runtime.InteropServices.DispId(1029)]
		int Status { [global::System.Runtime.InteropServices.DispId(1029)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600009C RID: 156
		[global::System.Runtime.InteropServices.DispId(1054)]
		int State { [global::System.Runtime.InteropServices.DispId(1054)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600009D RID: 157
		[global::System.Runtime.InteropServices.DispId(1610809392)]
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::ADODB.Recordset _xClone();

		// Token: 0x0600009E RID: 158
		[global::System.Runtime.InteropServices.DispId(1035)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void UpdateBatch([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectAll);

		// Token: 0x0600009F RID: 159
		[global::System.Runtime.InteropServices.DispId(1049)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CancelBatch([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectAll);

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000A0 RID: 160
		// (set) Token: 0x060000A1 RID: 161
		[global::System.Runtime.InteropServices.DispId(1051)]
		global::ADODB.CursorLocationEnum CursorLocation { [global::System.Runtime.InteropServices.DispId(1051)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1051)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060000A2 RID: 162
		[global::System.Runtime.InteropServices.DispId(1052)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::ADODB.Recordset NextRecordset([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.Optional] out object RecordsAffected);

		// Token: 0x060000A3 RID: 163
		[global::System.Runtime.InteropServices.DispId(1036)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool Supports([global::System.Runtime.InteropServices.In] global::ADODB.CursorOptionEnum CursorOptions);

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000A4 RID: 164
		// (set) Token: 0x060000A5 RID: 165
		[global::System.Runtime.InteropServices.DispId(-8)]
		object Collect { [global::System.Runtime.InteropServices.DispId(-8)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(-8)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000A6 RID: 166
		// (set) Token: 0x060000A7 RID: 167
		[global::System.Runtime.InteropServices.DispId(1053)]
		global::ADODB.MarshalOptionsEnum MarshalOptions { [global::System.Runtime.InteropServices.DispId(1053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1053)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060000A8 RID: 168
		[global::System.Runtime.InteropServices.DispId(1058)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Find([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Criteria, [global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [global::System.Runtime.InteropServices.In] int SkipRecords = 0, [global::System.Runtime.InteropServices.In] global::ADODB.SearchDirectionEnum SearchDirection = global::ADODB.SearchDirectionEnum.adSearchForward, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Start);

		// Token: 0x060000A9 RID: 169
		[global::System.Runtime.InteropServices.DispId(1055)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Cancel();

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000AA RID: 170
		// (set) Token: 0x060000AB RID: 171
		[global::System.Runtime.InteropServices.DispId(1056)]
		object DataSource { [global::System.Runtime.InteropServices.DispId(1056)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; [global::System.Runtime.InteropServices.DispId(1056)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060000AC RID: 172
		[global::System.Runtime.InteropServices.TypeLibFunc(64)]
		[global::System.Runtime.InteropServices.DispId(1610874883)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void _xSave([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string FileName = "", [global::System.Runtime.InteropServices.In] global::ADODB.PersistFormatEnum PersistFormat = global::ADODB.PersistFormatEnum.adPersistADTG);

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000AD RID: 173
		[global::System.Runtime.InteropServices.DispId(1061)]
		object ActiveCommand { [global::System.Runtime.InteropServices.DispId(1061)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)] get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000AF RID: 175
		// (set) Token: 0x060000AE RID: 174
		[global::System.Runtime.InteropServices.DispId(1063)]
		bool StayInSync { [global::System.Runtime.InteropServices.DispId(1063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1063)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060000B0 RID: 176
		[global::System.Runtime.InteropServices.DispId(1062)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string GetString([global::System.Runtime.InteropServices.In] global::ADODB.StringFormatEnum StringFormat = global::ADODB.StringFormatEnum.adClipString, [global::System.Runtime.InteropServices.In] int NumRows = -1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string ColumnDelimeter = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string RowDelimeter = "", [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string NullExpr = "");

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000B1 RID: 177
		// (set) Token: 0x060000B2 RID: 178
		[global::System.Runtime.InteropServices.DispId(1064)]
		string DataMember { [global::System.Runtime.InteropServices.DispId(1064)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1064)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060000B3 RID: 179
		[global::System.Runtime.InteropServices.DispId(1065)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		global::ADODB.CompareEnum CompareBookmarks([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Bookmark1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Bookmark2);

		// Token: 0x060000B4 RID: 180
		[global::System.Runtime.InteropServices.DispId(1034)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::ADODB.Recordset Clone([global::System.Runtime.InteropServices.In] global::ADODB.LockTypeEnum LockType = global::ADODB.LockTypeEnum.adLockUnspecified);

		// Token: 0x060000B5 RID: 181
		[global::System.Runtime.InteropServices.DispId(1024)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Resync([global::System.Runtime.InteropServices.In] global::ADODB.AffectEnum AffectRecords = global::ADODB.AffectEnum.adAffectAll, [global::System.Runtime.InteropServices.In] global::ADODB.ResyncEnum ResyncValues = global::ADODB.ResyncEnum.adResyncAllValues);

		// Token: 0x060000B6 RID: 182
		[global::System.Runtime.InteropServices.DispId(1066)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Seek([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object KeyValues, [global::System.Runtime.InteropServices.In] global::ADODB.SeekEnum SeekOption = global::ADODB.SeekEnum.adSeekFirstEQ);

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000B8 RID: 184
		// (set) Token: 0x060000B7 RID: 183
		[global::System.Runtime.InteropServices.DispId(1067)]
		string Index { [global::System.Runtime.InteropServices.DispId(1067)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1067)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060000B9 RID: 185
		[global::System.Runtime.InteropServices.DispId(1057)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Save([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Destination, [global::System.Runtime.InteropServices.In] global::ADODB.PersistFormatEnum PersistFormat = global::ADODB.PersistFormatEnum.adPersistADTG);
	}
}
