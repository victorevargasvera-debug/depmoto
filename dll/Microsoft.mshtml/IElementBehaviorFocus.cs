using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000DB7 RID: 3511
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("3050F6B6-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IElementBehaviorFocus
	{
		// Token: 0x060174C3 RID: 95427
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetFocusRect([global::System.Runtime.InteropServices.In] ref global::mshtml.tagRECT pRect);
	}
}
