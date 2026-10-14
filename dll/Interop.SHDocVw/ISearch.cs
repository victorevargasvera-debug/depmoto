using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000061 RID: 97
	[global::System.Runtime.InteropServices.TypeLibType(4176)]
	[global::System.Runtime.InteropServices.Guid("BA9239A4-3DD5-11D2-BF8B-00C04FB93661")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ISearch
	{
		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600055F RID: 1375
		[global::System.Runtime.InteropServices.DispId(1610743808)]
		string Title { [global::System.Runtime.InteropServices.DispId(1610743808)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000560 RID: 1376
		[global::System.Runtime.InteropServices.DispId(1610743809)]
		string Id { [global::System.Runtime.InteropServices.DispId(1610743809)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000561 RID: 1377
		[global::System.Runtime.InteropServices.DispId(1610743810)]
		string URL { [global::System.Runtime.InteropServices.DispId(1610743810)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }
	}
}
