using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CC4 RID: 3268
	[global::System.Runtime.InteropServices.Guid("E4E23071-4D07-11D2-AE76-0080C73BC199")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IXMLGenericParse
	{
		// Token: 0x06016302 RID: 90882
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetGenericParse([global::System.Runtime.InteropServices.In] bool fDoGeneric);
	}
}
