using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200004C RID: 76
	[global::System.Runtime.InteropServices.Guid("0000054E-0000-0010-8000-00AA006D2EA4")]
	[global::System.Reflection.DefaultMember("Parameters")]
	[global::System.Runtime.InteropServices.TypeLibType(4304)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface Command25 : global::ADODB.Command15
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001E5 RID: 485
		[global::System.Runtime.InteropServices.DispId(500)]
		global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001E6 RID: 486
		// (set) Token: 0x060001E7 RID: 487
		[global::System.Runtime.InteropServices.DispId(1)]
		global::ADODB.Connection ActiveConnection { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001E9 RID: 489
		// (set) Token: 0x060001EA RID: 490
		[global::System.Runtime.InteropServices.DispId(2)]
		string CommandText { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001EB RID: 491
		// (set) Token: 0x060001EC RID: 492
		[global::System.Runtime.InteropServices.DispId(3)]
		int CommandTimeout { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001ED RID: 493
		// (set) Token: 0x060001EE RID: 494
		[global::System.Runtime.InteropServices.DispId(4)]
		bool Prepared { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060001EF RID: 495
		[global::System.Runtime.InteropServices.DispId(5)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::ADODB.Recordset Execute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.Optional] out object RecordsAffected, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Parameters, [global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x060001F0 RID: 496
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.ParameterToInternalParameterMarshaler)]
		global::ADODB.Parameter CreateParameter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Name = "", [global::System.Runtime.InteropServices.In] global::ADODB.DataTypeEnum Type = global::ADODB.DataTypeEnum.adEmpty, [global::System.Runtime.InteropServices.In] global::ADODB.ParameterDirectionEnum Direction = global::ADODB.ParameterDirectionEnum.adParamInput, [global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [global::System.Runtime.InteropServices.In] int Size = 0, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Value);

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001F1 RID: 497
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Parameters")]
		global::ADODB.Parameters Parameters { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.ParametersToInternalParametersMarshaler)] get; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001F3 RID: 499
		// (set) Token: 0x060001F2 RID: 498
		[global::System.Runtime.InteropServices.DispId(7)]
		global::ADODB.CommandTypeEnum CommandType { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001F4 RID: 500
		// (set) Token: 0x060001F5 RID: 501
		[global::System.Runtime.InteropServices.DispId(8)]
		string Name { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001F6 RID: 502
		[global::System.Runtime.InteropServices.DispId(9)]
		int State { [global::System.Runtime.InteropServices.DispId(9)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060001F7 RID: 503
		[global::System.Runtime.InteropServices.DispId(10)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Cancel();
	}
}
