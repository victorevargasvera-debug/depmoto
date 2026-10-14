using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000093 RID: 147
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("3050F669-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLElementRender
	{
		// Token: 0x06000D0E RID: 3342
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void DrawToDC([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHDC")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hdc);

		// Token: 0x06000D0F RID: 3343
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetDocumentPrinter([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string bstrPrinterName, [global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHDC")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hdc);
	}
}
