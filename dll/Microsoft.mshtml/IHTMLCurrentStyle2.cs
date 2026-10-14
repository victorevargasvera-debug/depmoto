using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000061 RID: 97
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F658-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLCurrentStyle2
	{
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000978 RID: 2424
		[global::System.Runtime.InteropServices.DispId(-2147412957)]
		string layoutFlow { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412957)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000979 RID: 2425
		[global::System.Runtime.InteropServices.DispId(-2147412954)]
		string wordWrap { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412954)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600097A RID: 2426
		[global::System.Runtime.InteropServices.DispId(-2147412953)]
		string textUnderlinePosition { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412953)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600097B RID: 2427
		[global::System.Runtime.InteropServices.DispId(-2147412952)]
		bool hasLayout { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412952)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600097C RID: 2428
		[global::System.Runtime.InteropServices.DispId(-2147412932)]
		object scrollbarBaseColor { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412932)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600097D RID: 2429
		[global::System.Runtime.InteropServices.DispId(-2147412931)]
		object scrollbarFaceColor { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412931)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600097E RID: 2430
		[global::System.Runtime.InteropServices.DispId(-2147412930)]
		object scrollbar3dLightColor { [global::System.Runtime.InteropServices.DispId(-2147412930)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x0600097F RID: 2431
		[global::System.Runtime.InteropServices.DispId(-2147412929)]
		object scrollbarShadowColor { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412929)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000980 RID: 2432
		[global::System.Runtime.InteropServices.DispId(-2147412928)]
		object scrollbarHighlightColor { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412928)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000981 RID: 2433
		[global::System.Runtime.InteropServices.DispId(-2147412927)]
		object scrollbarDarkShadowColor { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412927)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000982 RID: 2434
		[global::System.Runtime.InteropServices.DispId(-2147412926)]
		object scrollbarArrowColor { [global::System.Runtime.InteropServices.DispId(-2147412926)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000983 RID: 2435
		[global::System.Runtime.InteropServices.DispId(-2147412916)]
		object scrollbarTrackColor { [global::System.Runtime.InteropServices.DispId(-2147412916)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000984 RID: 2436
		[global::System.Runtime.InteropServices.DispId(-2147412920)]
		string writingMode { [global::System.Runtime.InteropServices.DispId(-2147412920)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000985 RID: 2437
		[global::System.Runtime.InteropServices.DispId(-2147412959)]
		object zoom { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147412959)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000986 RID: 2438
		[global::System.Runtime.InteropServices.DispId(-2147413030)]
		string filter { [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.InteropServices.DispId(-2147413030)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000987 RID: 2439
		[global::System.Runtime.InteropServices.DispId(-2147412909)]
		string textAlignLast { [global::System.Runtime.InteropServices.DispId(-2147412909)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000988 RID: 2440
		[global::System.Runtime.InteropServices.DispId(-2147412908)]
		object textKashidaSpace { [global::System.Runtime.InteropServices.DispId(-2147412908)] [global::System.Runtime.InteropServices.TypeLibFunc(20)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; }

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000989 RID: 2441
		[global::System.Runtime.InteropServices.DispId(-2147412904)]
		bool isBlock { [global::System.Runtime.InteropServices.TypeLibFunc(1109)] [global::System.Runtime.InteropServices.DispId(-2147412904)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
