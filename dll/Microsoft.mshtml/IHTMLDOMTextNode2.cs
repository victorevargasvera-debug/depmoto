using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x0200006D RID: 109
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F809-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLDOMTextNode2
	{
		// Token: 0x06000B1E RID: 2846
		[global::System.Runtime.InteropServices.DispId(1004)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string substringData([global::System.Runtime.InteropServices.In] int offset, [global::System.Runtime.InteropServices.In] int Count);

		// Token: 0x06000B1F RID: 2847
		[global::System.Runtime.InteropServices.DispId(1005)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void appendData([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrstring);

		// Token: 0x06000B20 RID: 2848
		[global::System.Runtime.InteropServices.DispId(1006)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void insertData([global::System.Runtime.InteropServices.In] int offset, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrstring);

		// Token: 0x06000B21 RID: 2849
		[global::System.Runtime.InteropServices.DispId(1007)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void deleteData([global::System.Runtime.InteropServices.In] int offset, [global::System.Runtime.InteropServices.In] int Count);

		// Token: 0x06000B22 RID: 2850
		[global::System.Runtime.InteropServices.DispId(1008)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void replaceData([global::System.Runtime.InteropServices.In] int offset, [global::System.Runtime.InteropServices.In] int Count, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrstring);
	}
}
