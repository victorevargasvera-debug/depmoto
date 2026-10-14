using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CC5 RID: 3269
	[global::System.Runtime.InteropServices.Guid("3050F6A0-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLEditHost
	{
		// Token: 0x06016303 RID: 90883
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SnapRect([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::mshtml.IHTMLElement pIElement, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::mshtml.tagRECT prcNew, [global::System.Runtime.InteropServices.In] global::mshtml._ELEMENT_CORNER eHandle);
	}
}
