using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000BF4 RID: 3060
	[global::System.Runtime.InteropServices.Guid("3050F378-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLOptionsHolder
	{
		// Token: 0x170073EF RID: 29679
		// (get) Token: 0x06015B01 RID: 88833
		[global::System.Runtime.InteropServices.DispId(1503)]
		global::mshtml.IHTMLDocument2 document { [global::System.Runtime.InteropServices.DispId(1503)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170073F0 RID: 29680
		// (get) Token: 0x06015B02 RID: 88834
		[global::System.Runtime.InteropServices.DispId(1504)]
		global::mshtml.IHTMLFontNamesCollection fonts { [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.InteropServices.DispId(1504)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170073F1 RID: 29681
		// (get) Token: 0x06015B04 RID: 88836
		// (set) Token: 0x06015B03 RID: 88835
		[global::System.Runtime.InteropServices.DispId(1505)]
		object execArg { [global::System.Runtime.InteropServices.DispId(1505)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] get; [global::System.Runtime.InteropServices.DispId(1505)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170073F2 RID: 29682
		// (get) Token: 0x06015B06 RID: 88838
		// (set) Token: 0x06015B05 RID: 88837
		[global::System.Runtime.InteropServices.DispId(1506)]
		int errorLine { [global::System.Runtime.InteropServices.DispId(1506)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1506)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170073F3 RID: 29683
		// (get) Token: 0x06015B08 RID: 88840
		// (set) Token: 0x06015B07 RID: 88839
		[global::System.Runtime.InteropServices.DispId(1507)]
		int errorCharacter { [global::System.Runtime.InteropServices.DispId(1507)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1507)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170073F4 RID: 29684
		// (get) Token: 0x06015B0A RID: 88842
		// (set) Token: 0x06015B09 RID: 88841
		[global::System.Runtime.InteropServices.DispId(1508)]
		int errorCode { [global::System.Runtime.InteropServices.DispId(1508)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1508)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170073F5 RID: 29685
		// (get) Token: 0x06015B0C RID: 88844
		// (set) Token: 0x06015B0B RID: 88843
		[global::System.Runtime.InteropServices.DispId(1509)]
		string errorMessage { [global::System.Runtime.InteropServices.DispId(1509)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1509)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170073F6 RID: 29686
		// (get) Token: 0x06015B0E RID: 88846
		// (set) Token: 0x06015B0D RID: 88845
		[global::System.Runtime.InteropServices.DispId(1510)]
		bool errorDebug { [global::System.Runtime.InteropServices.DispId(1510)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1510)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170073F7 RID: 29687
		// (get) Token: 0x06015B0F RID: 88847
		[global::System.Runtime.InteropServices.DispId(1511)]
		global::mshtml.IHTMLWindow2 unsecuredWindowOfDocument { [global::System.Runtime.InteropServices.DispId(1511)] [global::System.Runtime.InteropServices.TypeLibFunc(64)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170073F8 RID: 29688
		// (get) Token: 0x06015B11 RID: 88849
		// (set) Token: 0x06015B10 RID: 88848
		[global::System.Runtime.InteropServices.DispId(1512)]
		string findText { [global::System.Runtime.InteropServices.DispId(1512)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; [global::System.Runtime.InteropServices.DispId(1512)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x170073F9 RID: 29689
		// (get) Token: 0x06015B13 RID: 88851
		// (set) Token: 0x06015B12 RID: 88850
		[global::System.Runtime.InteropServices.DispId(1513)]
		bool anythingAfterFrameset { [global::System.Runtime.InteropServices.DispId(1513)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.InteropServices.DispId(1513)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06015B14 RID: 88852
		[global::System.Runtime.InteropServices.DispId(1514)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::mshtml.IHTMLFontSizesCollection sizes([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string fontName);

		// Token: 0x06015B15 RID: 88853
		[global::System.Runtime.InteropServices.DispId(1515)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string openfiledlg([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object initFile, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object initDir, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object filter, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object title);

		// Token: 0x06015B16 RID: 88854
		[global::System.Runtime.InteropServices.DispId(1516)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)]
		string savefiledlg([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object initFile, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object initDir, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object filter, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object title);

		// Token: 0x06015B17 RID: 88855
		[global::System.Runtime.InteropServices.DispId(1517)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int choosecolordlg([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object initColor);

		// Token: 0x06015B18 RID: 88856
		[global::System.Runtime.InteropServices.DispId(1518)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void showSecurityInfo();

		// Token: 0x06015B19 RID: 88857
		[global::System.Runtime.InteropServices.DispId(1519)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		bool isApartmentModel([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLObjectElement @object);

		// Token: 0x06015B1A RID: 88858
		[global::System.Runtime.InteropServices.DispId(1520)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int getCharset([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string fontName);

		// Token: 0x170073FA RID: 29690
		// (get) Token: 0x06015B1B RID: 88859
		[global::System.Runtime.InteropServices.DispId(1521)]
		string secureConnectionInfo { [global::System.Runtime.InteropServices.DispId(1521)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] get; }
	}
}
