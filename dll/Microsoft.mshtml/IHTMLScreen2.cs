using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020007BA RID: 1978
	[global::System.Runtime.InteropServices.Guid("3050F84A-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLScreen2
	{
		// Token: 0x1700479F RID: 18335
		// (get) Token: 0x0600D73E RID: 55102
		[global::System.Runtime.InteropServices.DispId(1009)]
		int logicalXDPI { [global::System.Runtime.InteropServices.DispId(1009)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047A0 RID: 18336
		// (get) Token: 0x0600D73F RID: 55103
		[global::System.Runtime.InteropServices.DispId(1010)]
		int logicalYDPI { [global::System.Runtime.InteropServices.DispId(1010)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047A1 RID: 18337
		// (get) Token: 0x0600D740 RID: 55104
		[global::System.Runtime.InteropServices.DispId(1011)]
		int deviceXDPI { [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047A2 RID: 18338
		// (get) Token: 0x0600D741 RID: 55105
		[global::System.Runtime.InteropServices.DispId(1012)]
		int deviceYDPI { [global::System.Runtime.InteropServices.DispId(1012)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
