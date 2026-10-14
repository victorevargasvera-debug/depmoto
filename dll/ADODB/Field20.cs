using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000049 RID: 73
	[global::System.Runtime.InteropServices.Guid("0000054C-0000-0010-8000-00AA006D2EA4")]
	[global::System.Reflection.DefaultMember("Value")]
	[global::System.Runtime.InteropServices.TypeLibType(4304)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface Field20 : global::ADODB._ADO
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001B8 RID: 440
		[global::System.Runtime.InteropServices.DispId(500)]
		global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001B9 RID: 441
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		[global::System.Runtime.InteropServices.DispId(1109)]
		int ActualSize { [global::System.Runtime.InteropServices.DispId(1109)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001BA RID: 442
		// (set) Token: 0x060001CC RID: 460
		[global::System.Runtime.InteropServices.DispId(1114)]
		int Attributes { [global::System.Runtime.InteropServices.DispId(1114)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1114)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001BB RID: 443
		// (set) Token: 0x060001CB RID: 459
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		[global::System.Runtime.InteropServices.DispId(1103)]
		int DefinedSize { [global::System.Runtime.InteropServices.DispId(1103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; [global::System.Runtime.InteropServices.DispId(1103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001BC RID: 444
		[global::System.Runtime.InteropServices.DispId(1100)]
		string Name { [global::System.Runtime.InteropServices.DispId(1100)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001BD RID: 445
		// (set) Token: 0x060001CA RID: 458
		[global::System.Runtime.InteropServices.DispId(1102)]
		global::ADODB.DataTypeEnum Type { [global::System.Runtime.InteropServices.DispId(1102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001BE RID: 446
		// (set) Token: 0x060001BF RID: 447
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Value")]
		object Value { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001C0 RID: 448
		// (set) Token: 0x060001C8 RID: 456
		[global::System.Runtime.InteropServices.DispId(1112)]
		byte Precision { [global::System.Runtime.InteropServices.DispId(1112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001C1 RID: 449
		// (set) Token: 0x060001C9 RID: 457
		[global::System.Runtime.InteropServices.DispId(1113)]
		byte NumericScale { [global::System.Runtime.InteropServices.DispId(1113)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1113)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060001C2 RID: 450
		[global::System.Runtime.InteropServices.DispId(1107)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void AppendChunk([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Data);

		// Token: 0x060001C3 RID: 451
		[global::System.Runtime.InteropServices.DispId(1108)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object GetChunk([global::System.Runtime.InteropServices.In] int Length);

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001C4 RID: 452
		[global::System.Runtime.InteropServices.DispId(1104)]
		object OriginalValue { [global::System.Runtime.InteropServices.DispId(1104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001C5 RID: 453
		[global::System.Runtime.InteropServices.DispId(1105)]
		object UnderlyingValue { [global::System.Runtime.InteropServices.DispId(1105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001C6 RID: 454
		// (set) Token: 0x060001C7 RID: 455
		[global::System.Runtime.InteropServices.DispId(1115)]
		object DataFormat { [global::System.Runtime.InteropServices.DispId(1115)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; [global::System.Runtime.InteropServices.DispId(1115)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
