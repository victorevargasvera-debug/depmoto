using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000567 RID: 1383
	[global::System.Runtime.InteropServices.Guid("3050F25A-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLSelectionObject
	{
		// Token: 0x060085FB RID: 34299
		[global::System.Runtime.InteropServices.DispId(1001)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object createRange();

		// Token: 0x060085FC RID: 34300
		[global::System.Runtime.InteropServices.DispId(1002)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void empty();

		// Token: 0x060085FD RID: 34301
		[global::System.Runtime.InteropServices.DispId(1003)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void clear();

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x060085FE RID: 34302
		[global::System.Runtime.InteropServices.DispId(1004)]
		string type { [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }
	}
}
