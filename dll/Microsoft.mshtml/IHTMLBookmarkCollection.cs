using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020007A7 RID: 1959
	[global::System.Reflection.DefaultMember("item")]
	[global::System.Runtime.InteropServices.Guid("3050F4CE-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLBookmarkCollection : global::System.Collections.IEnumerable
	{
		// Token: 0x17004669 RID: 18025
		// (get) Token: 0x0600D4F6 RID: 54518
		[global::System.Runtime.InteropServices.DispId(1501)]
		int length { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(1501)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600D4F7 RID: 54519
		[global::System.Runtime.InteropServices.DispId(-4)]
		[global::System.Runtime.InteropServices.TypeLibFunc(65)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		global::System.Collections.IEnumerator GetEnumerator();

		// Token: 0x0600D4F8 RID: 54520
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object item([global::System.Runtime.InteropServices.In] int index);
	}
}
