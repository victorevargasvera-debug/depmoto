using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020007BE RID: 1982
	[global::System.Runtime.InteropServices.InterfaceType(2)]
	[global::System.Runtime.InteropServices.Guid("3050F591-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4112)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface DispHTMLScreen
	{
		// Token: 0x170047A5 RID: 18341
		// (get) Token: 0x0600D747 RID: 55111
		[global::System.Runtime.InteropServices.DispId(1001)]
		int colorDepth { [global::System.Runtime.InteropServices.DispId(1001)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047A6 RID: 18342
		// (get) Token: 0x0600D749 RID: 55113
		// (set) Token: 0x0600D748 RID: 55112
		[global::System.Runtime.InteropServices.DispId(1002)]
		int bufferDepth { [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1002)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170047A7 RID: 18343
		// (get) Token: 0x0600D74A RID: 55114
		[global::System.Runtime.InteropServices.DispId(1003)]
		int width { [global::System.Runtime.InteropServices.DispId(1003)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047A8 RID: 18344
		// (get) Token: 0x0600D74B RID: 55115
		[global::System.Runtime.InteropServices.DispId(1004)]
		int height { [global::System.Runtime.InteropServices.DispId(1004)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047A9 RID: 18345
		// (get) Token: 0x0600D74D RID: 55117
		// (set) Token: 0x0600D74C RID: 55116
		[global::System.Runtime.InteropServices.DispId(1005)]
		int updateInterval { [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1005)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] set; }

		// Token: 0x170047AA RID: 18346
		// (get) Token: 0x0600D74E RID: 55118
		[global::System.Runtime.InteropServices.DispId(1006)]
		int availHeight { [global::System.Runtime.InteropServices.DispId(1006)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047AB RID: 18347
		// (get) Token: 0x0600D74F RID: 55119
		[global::System.Runtime.InteropServices.DispId(1007)]
		int availWidth { [global::System.Runtime.InteropServices.DispId(1007)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047AC RID: 18348
		// (get) Token: 0x0600D750 RID: 55120
		[global::System.Runtime.InteropServices.DispId(1008)]
		bool fontSmoothingEnabled { [global::System.Runtime.InteropServices.DispId(1008)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047AD RID: 18349
		// (get) Token: 0x0600D751 RID: 55121
		[global::System.Runtime.InteropServices.DispId(1009)]
		int logicalXDPI { [global::System.Runtime.InteropServices.DispId(1009)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047AE RID: 18350
		// (get) Token: 0x0600D752 RID: 55122
		[global::System.Runtime.InteropServices.DispId(1010)]
		int logicalYDPI { [global::System.Runtime.InteropServices.DispId(1010)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047AF RID: 18351
		// (get) Token: 0x0600D753 RID: 55123
		[global::System.Runtime.InteropServices.DispId(1011)]
		int deviceXDPI { [global::System.Runtime.InteropServices.DispId(1011)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170047B0 RID: 18352
		// (get) Token: 0x0600D754 RID: 55124
		[global::System.Runtime.InteropServices.DispId(1012)]
		int deviceYDPI { [global::System.Runtime.InteropServices.DispId(1012)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig | global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
