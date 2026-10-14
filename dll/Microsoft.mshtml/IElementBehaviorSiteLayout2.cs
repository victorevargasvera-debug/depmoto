using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000DBB RID: 3515
	[global::System.Runtime.InteropServices.Guid("3050F847-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IElementBehaviorSiteLayout2
	{
		// Token: 0x060174CC RID: 95436
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetFontInfo(out global::mshtml.tagLOGFONTW plf);
	}
}
