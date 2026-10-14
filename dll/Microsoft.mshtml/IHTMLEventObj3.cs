using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020007AD RID: 1965
	[global::System.Runtime.InteropServices.Guid("3050F680-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLEventObj3
	{
		// Token: 0x17004687 RID: 18055
		// (get) Token: 0x0600D538 RID: 54584
		[global::System.Runtime.InteropServices.DispId(1038)]
		bool contentOverflow { [global::System.Runtime.InteropServices.DispId(1038)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004688 RID: 18056
		// (get) Token: 0x0600D53A RID: 54586
		// (set) Token: 0x0600D539 RID: 54585
		[global::System.Runtime.InteropServices.DispId(1039)]
		bool shiftLeft { [global::System.Runtime.InteropServices.DispId(1039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1039)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17004689 RID: 18057
		// (get) Token: 0x0600D53C RID: 54588
		// (set) Token: 0x0600D53B RID: 54587
		[global::System.Runtime.InteropServices.DispId(1040)]
		bool altLeft { [global::System.Runtime.InteropServices.DispId(1040)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1040)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700468A RID: 18058
		// (get) Token: 0x0600D53E RID: 54590
		// (set) Token: 0x0600D53D RID: 54589
		[global::System.Runtime.InteropServices.DispId(1041)]
		bool ctrlLeft { [global::System.Runtime.InteropServices.DispId(1041)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1041)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700468B RID: 18059
		// (get) Token: 0x0600D53F RID: 54591
		[global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")]
		[global::System.Runtime.InteropServices.DispId(1042)]
		int imeCompositionChange { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.InteropServices.DispId(1042)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")] get; }

		// Token: 0x1700468C RID: 18060
		// (get) Token: 0x0600D540 RID: 54592
		[global::System.Runtime.InteropServices.DispId(1043)]
		[global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")]
		int imeNotifyCommand { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.InteropServices.DispId(1043)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")] get; }

		// Token: 0x1700468D RID: 18061
		// (get) Token: 0x0600D541 RID: 54593
		[global::System.Runtime.InteropServices.DispId(1044)]
		[global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")]
		int imeNotifyData { [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.InteropServices.DispId(1044)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")] get; }

		// Token: 0x1700468E RID: 18062
		// (get) Token: 0x0600D542 RID: 54594
		[global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")]
		[global::System.Runtime.InteropServices.DispId(1046)]
		int imeRequest { [global::System.Runtime.InteropServices.DispId(1046)] [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")] get; }

		// Token: 0x1700468F RID: 18063
		// (get) Token: 0x0600D543 RID: 54595
		[global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")]
		[global::System.Runtime.InteropServices.DispId(1047)]
		int imeRequestData { [global::System.Runtime.InteropServices.DispId(1047)] [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")] get; }

		// Token: 0x17004690 RID: 18064
		// (get) Token: 0x0600D544 RID: 54596
		[global::System.Runtime.InteropServices.DispId(1045)]
		[global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")]
		int keyboardLayout { [global::System.Runtime.InteropServices.DispId(1045)] [global::System.Runtime.InteropServices.TypeLibFunc(1089)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.ComAliasName("mshtml.LONG_PTR")] get; }

		// Token: 0x17004691 RID: 18065
		// (get) Token: 0x0600D545 RID: 54597
		[global::System.Runtime.InteropServices.DispId(1048)]
		int behaviorCookie { [global::System.Runtime.InteropServices.DispId(1048)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004692 RID: 18066
		// (get) Token: 0x0600D546 RID: 54598
		[global::System.Runtime.InteropServices.DispId(1049)]
		int behaviorPart { [global::System.Runtime.InteropServices.DispId(1049)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17004693 RID: 18067
		// (get) Token: 0x0600D547 RID: 54599
		[global::System.Runtime.InteropServices.DispId(1050)]
		string nextPage { [global::System.Runtime.InteropServices.DispId(1050)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }
	}
}
