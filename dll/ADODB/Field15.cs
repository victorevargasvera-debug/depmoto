using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200007A RID: 122
	[global::System.Runtime.InteropServices.Guid("00000505-0000-0010-8000-00AA006D2EA4")]
	[global::System.Reflection.DefaultMember("Value")]
	[global::System.Runtime.InteropServices.TypeLibType(4304)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface Field15 : global::ADODB._ADO
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003AA RID: 938
		[global::System.Runtime.InteropServices.DispId(500)]
		global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003AB RID: 939
		[global::System.Runtime.InteropServices.DispId(1109)]
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		int ActualSize { [global::System.Runtime.InteropServices.DispId(1109)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003AC RID: 940
		[global::System.Runtime.InteropServices.DispId(1114)]
		int Attributes { [global::System.Runtime.InteropServices.DispId(1114)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003AD RID: 941
		[global::System.Runtime.InteropServices.DispId(1103)]
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		int DefinedSize { [global::System.Runtime.InteropServices.DispId(1103)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003AE RID: 942
		[global::System.Runtime.InteropServices.DispId(1100)]
		string Name { [global::System.Runtime.InteropServices.DispId(1100)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003AF RID: 943
		[global::System.Runtime.InteropServices.DispId(1102)]
		global::ADODB.DataTypeEnum Type { [global::System.Runtime.InteropServices.DispId(1102)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003B0 RID: 944
		// (set) Token: 0x060003B1 RID: 945
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Value")]
		object Value { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003B2 RID: 946
		[global::System.Runtime.InteropServices.DispId(1112)]
		byte Precision { [global::System.Runtime.InteropServices.DispId(1112)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003B3 RID: 947
		[global::System.Runtime.InteropServices.DispId(1113)]
		byte NumericScale { [global::System.Runtime.InteropServices.DispId(1113)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060003B4 RID: 948
		[global::System.Runtime.InteropServices.DispId(1107)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void AppendChunk([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Data);

		// Token: 0x060003B5 RID: 949
		[global::System.Runtime.InteropServices.DispId(1108)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object GetChunk([global::System.Runtime.InteropServices.In] int Length);

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003B6 RID: 950
		[global::System.Runtime.InteropServices.DispId(1104)]
		object OriginalValue { [global::System.Runtime.InteropServices.DispId(1104)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003B7 RID: 951
		[global::System.Runtime.InteropServices.DispId(1105)]
		object UnderlyingValue { [global::System.Runtime.InteropServices.DispId(1105)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }
	}
}
