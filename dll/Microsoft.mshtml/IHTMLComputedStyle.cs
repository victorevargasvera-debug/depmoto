using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CB6 RID: 3254
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("3050F6C3-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLComputedStyle
	{
		// Token: 0x1700759F RID: 30111
		// (get) Token: 0x06016296 RID: 90774
		[global::System.Runtime.InteropServices.DispId(1001)]
		bool bold { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075A0 RID: 30112
		// (get) Token: 0x06016297 RID: 90775
		[global::System.Runtime.InteropServices.DispId(1002)]
		bool italic { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075A1 RID: 30113
		// (get) Token: 0x06016298 RID: 90776
		[global::System.Runtime.InteropServices.DispId(1003)]
		bool underline { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075A2 RID: 30114
		// (get) Token: 0x06016299 RID: 90777
		[global::System.Runtime.InteropServices.DispId(1004)]
		bool overline { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075A3 RID: 30115
		// (get) Token: 0x0601629A RID: 90778
		[global::System.Runtime.InteropServices.DispId(1005)]
		bool strikeOut { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075A4 RID: 30116
		// (get) Token: 0x0601629B RID: 90779
		[global::System.Runtime.InteropServices.DispId(1006)]
		bool subScript { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075A5 RID: 30117
		// (get) Token: 0x0601629C RID: 90780
		[global::System.Runtime.InteropServices.DispId(1007)]
		bool superScript { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075A6 RID: 30118
		// (get) Token: 0x0601629D RID: 90781
		[global::System.Runtime.InteropServices.DispId(1008)]
		bool explicitFace { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075A7 RID: 30119
		// (get) Token: 0x0601629E RID: 90782
		[global::System.Runtime.InteropServices.DispId(1009)]
		int fontWeight { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075A8 RID: 30120
		// (get) Token: 0x0601629F RID: 90783
		[global::System.Runtime.InteropServices.DispId(1010)]
		int fontSize { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075A9 RID: 30121
		// (get) Token: 0x060162A0 RID: 90784
		[global::System.Runtime.InteropServices.DispId(1011)]
		ushort fontName { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075AA RID: 30122
		// (get) Token: 0x060162A1 RID: 90785
		[global::System.Runtime.InteropServices.DispId(1012)]
		bool hasBgColor { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075AB RID: 30123
		// (get) Token: 0x060162A2 RID: 90786
		[global::System.Runtime.InteropServices.DispId(1013)]
		uint textColor { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075AC RID: 30124
		// (get) Token: 0x060162A3 RID: 90787
		[global::System.Runtime.InteropServices.DispId(1014)]
		uint backgroundColor { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075AD RID: 30125
		// (get) Token: 0x060162A4 RID: 90788
		[global::System.Runtime.InteropServices.DispId(1015)]
		bool preFormatted { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075AE RID: 30126
		// (get) Token: 0x060162A5 RID: 90789
		[global::System.Runtime.InteropServices.DispId(1016)]
		bool direction { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075AF RID: 30127
		// (get) Token: 0x060162A6 RID: 90790
		[global::System.Runtime.InteropServices.DispId(1017)]
		bool blockDirection { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170075B0 RID: 30128
		// (get) Token: 0x060162A7 RID: 90791
		[global::System.Runtime.InteropServices.DispId(1018)]
		bool OL { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060162A8 RID: 90792
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void isEqual([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLComputedStyle pComputedStyle, out bool pfEqual);
	}
}
