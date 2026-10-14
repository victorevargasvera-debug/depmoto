using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000047 RID: 71
	[global::System.Runtime.InteropServices.TypeLibType(4304)]
	[global::System.Runtime.InteropServices.Guid("00000506-0000-0010-8000-00AA006D2EA4")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface Fields15 : global::ADODB._Collection
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600019E RID: 414
		[global::System.Runtime.InteropServices.DispId(1)]
		int Count { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600019F RID: 415
		[global::System.Runtime.InteropServices.DispId(-4)]
		[global::System.Runtime.InteropServices.TypeLibFunc(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		global::System.Collections.IEnumerator GetEnumerator();

		// Token: 0x060001A0 RID: 416
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Refresh();

		// Token: 0x170000A8 RID: 168
		[global::System.Runtime.InteropServices.DispId(0)]
		global::ADODB.Field this[[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] object Index]
		{
			[global::System.Runtime.InteropServices.DispId(0)]
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
			[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
			get;
		}
	}
}
