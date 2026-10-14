using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x0200000A RID: 10
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("3050F4AA-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IElementBehaviorRender
	{
		// Token: 0x06000133 RID: 307
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Draw([global::System.Runtime.InteropServices.ComAliasName("mshtml.wireHDC")] [global::System.Runtime.InteropServices.In] ref global::mshtml._RemotableHandle hdc, [global::System.Runtime.InteropServices.In] int lLayer, [global::System.Runtime.InteropServices.In] ref global::mshtml.tagRECT pRect, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pReserved);

		// Token: 0x06000134 RID: 308
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int GetRenderInfo();

		// Token: 0x06000135 RID: 309
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int HitTestPoint([global::System.Runtime.InteropServices.In] ref global::mshtml.tagPOINT pPoint, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object pReserved);
	}
}
