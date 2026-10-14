using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000BF3 RID: 3059
	[global::System.Runtime.InteropServices.Guid("3050F377-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Reflection.DefaultMember("item")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLFontSizesCollection : global::System.Collections.IEnumerable
	{
		// Token: 0x170073ED RID: 29677
		// (get) Token: 0x06015AFD RID: 88829
		[global::System.Runtime.InteropServices.DispId(1502)]
		int length { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(1502)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06015AFE RID: 88830
		[global::System.Runtime.InteropServices.TypeLibFunc(65)]
		[global::System.Runtime.InteropServices.DispId(-4)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.CustomMarshaler, MarshalTypeRef = System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler)]
		global::System.Collections.IEnumerator GetEnumerator();

		// Token: 0x170073EE RID: 29678
		// (get) Token: 0x06015AFF RID: 88831
		[global::System.Runtime.InteropServices.DispId(1503)]
		string forFont { [global::System.Runtime.InteropServices.DispId(1503)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x06015B00 RID: 88832
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int item([global::System.Runtime.InteropServices.In] int index);
	}
}
