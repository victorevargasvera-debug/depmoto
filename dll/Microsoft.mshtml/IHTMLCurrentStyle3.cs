using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000062 RID: 98
	[global::System.Runtime.InteropServices.Guid("3050F818-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLCurrentStyle3
	{
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600098A RID: 2442
		[global::System.Runtime.InteropServices.DispId(-2147412903)]
		string textOverflow { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412903)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600098B RID: 2443
		[global::System.Runtime.InteropServices.DispId(-2147412901)]
		object minHeight { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412901)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600098C RID: 2444
		[global::System.Runtime.InteropServices.DispId(-2147413065)]
		object wordSpacing { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413065)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600098D RID: 2445
		[global::System.Runtime.InteropServices.DispId(-2147413036)]
		string whiteSpace { [global::System.Runtime.InteropServices.DispId(-2147413036)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }
	}
}
