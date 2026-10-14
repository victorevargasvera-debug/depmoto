using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200003E RID: 62
	[global::System.Runtime.InteropServices.Guid("00000508-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.TypeLibType(4304)]
	[global::System.Reflection.DefaultMember("Parameters")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface Command15 : global::ADODB._ADO
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000020 RID: 32
		[global::System.Runtime.InteropServices.DispId(500)]
		global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000021 RID: 33
		// (set) Token: 0x06000022 RID: 34
		[global::System.Runtime.InteropServices.DispId(1)]
		global::ADODB.Connection ActiveConnection { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000024 RID: 36
		// (set) Token: 0x06000025 RID: 37
		[global::System.Runtime.InteropServices.DispId(2)]
		string CommandText { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000026 RID: 38
		// (set) Token: 0x06000027 RID: 39
		[global::System.Runtime.InteropServices.DispId(3)]
		int CommandTimeout { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000028 RID: 40
		// (set) Token: 0x06000029 RID: 41
		[global::System.Runtime.InteropServices.DispId(4)]
		bool Prepared { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600002A RID: 42
		[global::System.Runtime.InteropServices.DispId(5)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::ADODB.Recordset Execute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.Optional] out object RecordsAffected, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Parameters, [global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x0600002B RID: 43
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.ParameterToInternalParameterMarshaler)]
		global::ADODB.Parameter CreateParameter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Name = "", [global::System.Runtime.InteropServices.In] global::ADODB.DataTypeEnum Type = global::ADODB.DataTypeEnum.adEmpty, [global::System.Runtime.InteropServices.In] global::ADODB.ParameterDirectionEnum Direction = global::ADODB.ParameterDirectionEnum.adParamInput, [global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [global::System.Runtime.InteropServices.In] int Size = 0, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Value);

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002C RID: 44
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Parameters")]
		global::ADODB.Parameters Parameters { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.ParametersToInternalParametersMarshaler)] get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002E RID: 46
		// (set) Token: 0x0600002D RID: 45
		[global::System.Runtime.InteropServices.DispId(7)]
		global::ADODB.CommandTypeEnum CommandType { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002F RID: 47
		// (set) Token: 0x06000030 RID: 48
		[global::System.Runtime.InteropServices.DispId(8)]
		string Name { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
