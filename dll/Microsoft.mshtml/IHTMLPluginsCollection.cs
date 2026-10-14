using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000797 RID: 1943
	[global::System.Runtime.InteropServices.Guid("3050F3FD-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(4160)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLPluginsCollection
	{
		// Token: 0x17004633 RID: 17971
		// (get) Token: 0x0600D485 RID: 54405
		[global::System.Runtime.InteropServices.DispId(1)]
		int length { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600D486 RID: 54406
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void refresh([global::System.Runtime.InteropServices.In] bool reload = false);
	}
}
