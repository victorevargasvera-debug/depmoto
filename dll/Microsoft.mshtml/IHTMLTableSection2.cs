using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x020009FA RID: 2554
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.Guid("3050F5C7-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLTableSection2
	{
		// Token: 0x060103D3 RID: 66515
		[global::System.Runtime.InteropServices.DispId(1003)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object moveRow([global::System.Runtime.InteropServices.In] int indexFrom = -1, [global::System.Runtime.InteropServices.In] int indexTo = -1);
	}
}
