using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200007B RID: 123
	[global::System.Runtime.InteropServices.TypeLibType(6)]
	[global::System.Reflection.DefaultMember("Value")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("0000050B-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.ComImport]
	public class ParameterClass : global::ADODB._Parameter, global::ADODB.Parameter
	{
		// Token: 0x060003B8 RID: 952
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern ParameterClass();

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003B9 RID: 953
		[global::System.Runtime.InteropServices.DispId(500)]
		public virtual extern global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003BA RID: 954
		// (set) Token: 0x060003BB RID: 955
		[global::System.Runtime.InteropServices.DispId(1)]
		public virtual extern string Name { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003BC RID: 956
		// (set) Token: 0x060003BD RID: 957
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Value")]
		public virtual extern object Value { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003BE RID: 958
		// (set) Token: 0x060003BF RID: 959
		[global::System.Runtime.InteropServices.DispId(2)]
		public virtual extern global::ADODB.DataTypeEnum Type { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003C1 RID: 961
		// (set) Token: 0x060003C0 RID: 960
		[global::System.Runtime.InteropServices.DispId(3)]
		public virtual extern global::ADODB.ParameterDirectionEnum Direction { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003C3 RID: 963
		// (set) Token: 0x060003C2 RID: 962
		[global::System.Runtime.InteropServices.DispId(4)]
		public virtual extern byte Precision { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003C5 RID: 965
		// (set) Token: 0x060003C4 RID: 964
		[global::System.Runtime.InteropServices.DispId(5)]
		public virtual extern byte NumericScale { [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(5)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003C7 RID: 967
		// (set) Token: 0x060003C6 RID: 966
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")]
		public virtual extern int Size { [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] get; [global::System.Runtime.InteropServices.DispId(6)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060003C8 RID: 968
		[global::System.Runtime.InteropServices.DispId(7)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void AppendChunk([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Val);

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003C9 RID: 969
		// (set) Token: 0x060003CA RID: 970
		[global::System.Runtime.InteropServices.DispId(8)]
		public virtual extern int Attributes { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
