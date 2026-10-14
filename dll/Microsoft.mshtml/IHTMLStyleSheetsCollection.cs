using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000146 RID: 326
	[global::System.Reflection.DefaultMember("item")]
	[global::System.Runtime.InteropServices.Guid("3050F37E-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLStyleSheetsCollection : global::System.Collections.IEnumerable
	{
		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060013CD RID: 5069
		[global::System.Runtime.InteropServices.DispId(1001)]
		int length { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060013CE RID: 5070
		[global::System.Runtime.InteropServices.TypeLibFunc(65)]
		[global::System.Runtime.InteropServices.DispId(-4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		global::System.Collections.IEnumerator GetEnumerator();

		// Token: 0x060013CF RID: 5071
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object item([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object pvarIndex);
	}
}
