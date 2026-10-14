using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000048 RID: 72
	[global::System.Runtime.InteropServices.TypeLibType(4288)]
	[global::System.Runtime.InteropServices.Guid("00000569-0000-0010-8000-00AA006D2EA4")]
	[global::System.Reflection.DefaultMember("Value")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface Field : global::ADODB.Field20
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001A2 RID: 418
		[global::System.Runtime.InteropServices.DispId(500)]
		global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001A3 RID: 419
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		[global::System.Runtime.InteropServices.DispId(1109)]
		int ActualSize { [global::System.Runtime.InteropServices.DispId(1109)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001A4 RID: 420
		// (set) Token: 0x060001B6 RID: 438
		[global::System.Runtime.InteropServices.DispId(1114)]
		int Attributes { [global::System.Runtime.InteropServices.DispId(1114)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1114)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001A5 RID: 421
		// (set) Token: 0x060001B5 RID: 437
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		[global::System.Runtime.InteropServices.DispId(1103)]
		int DefinedSize { [global::System.Runtime.InteropServices.DispId(1103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; [global::System.Runtime.InteropServices.DispId(1103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001A6 RID: 422
		[global::System.Runtime.InteropServices.DispId(1100)]
		string Name { [global::System.Runtime.InteropServices.DispId(1100)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001A7 RID: 423
		// (set) Token: 0x060001B4 RID: 436
		[global::System.Runtime.InteropServices.DispId(1102)]
		global::ADODB.DataTypeEnum Type { [global::System.Runtime.InteropServices.DispId(1102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001A8 RID: 424
		// (set) Token: 0x060001A9 RID: 425
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Value")]
		object Value { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001AA RID: 426
		// (set) Token: 0x060001B2 RID: 434
		[global::System.Runtime.InteropServices.DispId(1112)]
		byte Precision { [global::System.Runtime.InteropServices.DispId(1112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001AB RID: 427
		// (set) Token: 0x060001B3 RID: 435
		[global::System.Runtime.InteropServices.DispId(1113)]
		byte NumericScale { [global::System.Runtime.InteropServices.DispId(1113)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1113)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060001AC RID: 428
		[global::System.Runtime.InteropServices.DispId(1107)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void AppendChunk([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Data);

		// Token: 0x060001AD RID: 429
		[global::System.Runtime.InteropServices.DispId(1108)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object GetChunk([global::System.Runtime.InteropServices.In] int Length);

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001AE RID: 430
		[global::System.Runtime.InteropServices.DispId(1104)]
		object OriginalValue { [global::System.Runtime.InteropServices.DispId(1104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001AF RID: 431
		[global::System.Runtime.InteropServices.DispId(1105)]
		object UnderlyingValue { [global::System.Runtime.InteropServices.DispId(1105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001B0 RID: 432
		// (set) Token: 0x060001B1 RID: 433
		[global::System.Runtime.InteropServices.DispId(1115)]
		object DataFormat { [global::System.Runtime.InteropServices.DispId(1115)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; [global::System.Runtime.InteropServices.DispId(1115)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001B7 RID: 439
		[global::System.Runtime.InteropServices.DispId(1116)]
		int Status { [global::System.Runtime.InteropServices.DispId(1116)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
