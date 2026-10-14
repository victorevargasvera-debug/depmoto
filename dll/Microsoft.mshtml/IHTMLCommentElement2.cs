using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020009E1 RID: 2529
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F813-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLCommentElement2
	{
		// Token: 0x170050A7 RID: 20647
		// (get) Token: 0x0600F779 RID: 63353
		// (set) Token: 0x0600F778 RID: 63352
		[global::System.Runtime.InteropServices.DispId(1003)]
		string data { [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170050A8 RID: 20648
		// (get) Token: 0x0600F77A RID: 63354
		[global::System.Runtime.InteropServices.DispId(1004)]
		int length { [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600F77B RID: 63355
		[global::System.Runtime.InteropServices.DispId(1005)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string substringData([global::System.Runtime.InteropServices.In] int offset, [global::System.Runtime.InteropServices.In] int Count);

		// Token: 0x0600F77C RID: 63356
		[global::System.Runtime.InteropServices.DispId(1006)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void appendData([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrstring);

		// Token: 0x0600F77D RID: 63357
		[global::System.Runtime.InteropServices.DispId(1007)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void insertData([global::System.Runtime.InteropServices.In] int offset, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrstring);

		// Token: 0x0600F77E RID: 63358
		[global::System.Runtime.InteropServices.DispId(1008)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void deleteData([global::System.Runtime.InteropServices.In] int offset, [global::System.Runtime.InteropServices.In] int Count);

		// Token: 0x0600F77F RID: 63359
		[global::System.Runtime.InteropServices.DispId(1009)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void replaceData([global::System.Runtime.InteropServices.In] int offset, [global::System.Runtime.InteropServices.In] int Count, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrstring);
	}
}
