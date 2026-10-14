using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020007B7 RID: 1975
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F35C-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLScreen
	{
		// Token: 0x17004789 RID: 18313
		// (get) Token: 0x0600D715 RID: 55061
		[global::System.Runtime.InteropServices.DispId(1001)]
		int colorDepth { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700478A RID: 18314
		// (get) Token: 0x0600D717 RID: 55063
		// (set) Token: 0x0600D716 RID: 55062
		[global::System.Runtime.InteropServices.DispId(1002)]
		int bufferDepth { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700478B RID: 18315
		// (get) Token: 0x0600D718 RID: 55064
		[global::System.Runtime.InteropServices.DispId(1003)]
		int width { [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700478C RID: 18316
		// (get) Token: 0x0600D719 RID: 55065
		[global::System.Runtime.InteropServices.DispId(1004)]
		int height { [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700478D RID: 18317
		// (get) Token: 0x0600D71B RID: 55067
		// (set) Token: 0x0600D71A RID: 55066
		[global::System.Runtime.InteropServices.DispId(1005)]
		int updateInterval { [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700478E RID: 18318
		// (get) Token: 0x0600D71C RID: 55068
		[global::System.Runtime.InteropServices.DispId(1006)]
		int availHeight { [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700478F RID: 18319
		// (get) Token: 0x0600D71D RID: 55069
		[global::System.Runtime.InteropServices.DispId(1007)]
		int availWidth { [global::System.Runtime.InteropServices.DispId(1007)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004790 RID: 18320
		// (get) Token: 0x0600D71E RID: 55070
		[global::System.Runtime.InteropServices.DispId(1008)]
		bool fontSmoothingEnabled { [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
