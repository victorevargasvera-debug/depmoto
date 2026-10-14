using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000069 RID: 105
	[global::System.Runtime.InteropServices.Guid("00000507-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.TypeLibType(6)]
	[global::System.Reflection.DefaultMember("Parameters")]
	[global::System.Runtime.InteropServices.ComImport]
	public class CommandClass : global::ADODB._Command, global::ADODB.Command
	{
		// Token: 0x060002F9 RID: 761
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern CommandClass();

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002FA RID: 762
		[global::System.Runtime.InteropServices.DispId(500)]
		public virtual extern global::ADODB.Properties Properties { [global::System.Runtime.InteropServices.DispId(500)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.PropertiesToInternalPropertiesMarshaler)] get; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002FB RID: 763
		// (set) Token: 0x060002FC RID: 764
		[global::System.Runtime.InteropServices.DispId(1)]
		public virtual extern global::ADODB.Connection ActiveConnection { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002FE RID: 766
		// (set) Token: 0x060002FF RID: 767
		[global::System.Runtime.InteropServices.DispId(2)]
		public virtual extern string CommandText { [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(2)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000300 RID: 768
		// (set) Token: 0x06000301 RID: 769
		[global::System.Runtime.InteropServices.DispId(3)]
		public virtual extern int CommandTimeout { [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(3)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000302 RID: 770
		// (set) Token: 0x06000303 RID: 771
		[global::System.Runtime.InteropServices.DispId(4)]
		public virtual extern bool Prepared { [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(4)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000304 RID: 772
		[global::System.Runtime.InteropServices.DispId(5)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::ADODB.Recordset Execute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.Optional] out object RecordsAffected, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] ref object Parameters, [global::System.Runtime.InteropServices.In] int Options = -1);

		// Token: 0x06000305 RID: 773
		[global::System.Runtime.InteropServices.DispId(6)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.ParameterToInternalParameterMarshaler)]
		public virtual extern global::ADODB.Parameter CreateParameter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Name = "", [global::System.Runtime.InteropServices.In] global::ADODB.DataTypeEnum Type = global::ADODB.DataTypeEnum.adEmpty, [global::System.Runtime.InteropServices.In] global::ADODB.ParameterDirectionEnum Direction = global::ADODB.ParameterDirectionEnum.adParamInput, [global::System.Runtime.InteropServices.ComAliasName("ADODB.ADO_LONGPTR")] [global::System.Runtime.InteropServices.In] int Size = 0, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object Value);

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000306 RID: 774
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Parameters")]
		public virtual extern global::ADODB.Parameters Parameters { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = ADODB.ParametersToInternalParametersMarshaler)] get; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000308 RID: 776
		// (set) Token: 0x06000307 RID: 775
		[global::System.Runtime.InteropServices.DispId(7)]
		public virtual extern global::ADODB.CommandTypeEnum CommandType { [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(7)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000309 RID: 777
		// (set) Token: 0x0600030A RID: 778
		[global::System.Runtime.InteropServices.DispId(8)]
		public virtual extern string Name { [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(8)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600030B RID: 779
		[global::System.Runtime.InteropServices.DispId(9)]
		public virtual extern int State { [global::System.Runtime.InteropServices.DispId(9)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600030C RID: 780
		[global::System.Runtime.InteropServices.DispId(10)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Cancel();

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600030E RID: 782
		// (set) Token: 0x0600030D RID: 781
		[global::System.Runtime.InteropServices.DispId(11)]
		public virtual extern object CommandStream { [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(11)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000310 RID: 784
		// (set) Token: 0x0600030F RID: 783
		[global::System.Runtime.InteropServices.DispId(12)]
		public virtual extern string Dialect { [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(12)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000312 RID: 786
		// (set) Token: 0x06000311 RID: 785
		[global::System.Runtime.InteropServices.DispId(13)]
		public virtual extern bool NamedParameters { [global::System.Runtime.InteropServices.DispId(13)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(13)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
