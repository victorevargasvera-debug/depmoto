using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CB8 RID: 3256
	[global::System.Reflection.DefaultMember("item")]
	[global::System.Runtime.InteropServices.Guid("3050F830-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4096)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IBlockFormats : global::System.Collections.IEnumerable
	{
		// Token: 0x060162AD RID: 90797
		[global::System.Runtime.InteropServices.TypeLibFunc(1)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		global::System.Collections.IEnumerator GetEnumerator();

		// Token: 0x170075B3 RID: 30131
		// (get) Token: 0x060162AE RID: 90798
		[global::System.Runtime.InteropServices.DispId(1)]
		int Count { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060162AF RID: 90799
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string item([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarIndex);
	}
}
