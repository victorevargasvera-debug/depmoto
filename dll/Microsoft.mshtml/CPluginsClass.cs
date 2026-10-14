using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x0200079F RID: 1951
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("3050F3FF-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public class CPluginsClass : global::mshtml.IHTMLPluginsCollection, global::mshtml.CPlugins
	{
		// Token: 0x0600D4BF RID: 54463
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern CPluginsClass();

		// Token: 0x1700464F RID: 17999
		// (get) Token: 0x0600D4C0 RID: 54464
		[global::System.Runtime.InteropServices.DispId(1)]
		public virtual extern int length { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600D4C1 RID: 54465
		[global::System.Runtime.InteropServices.DispId(2)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void refresh([global::System.Runtime.InteropServices.In] bool reload = false);
	}
}
