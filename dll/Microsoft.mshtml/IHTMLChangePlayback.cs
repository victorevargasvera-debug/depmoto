using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000CC1 RID: 3265
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.Guid("3050F6E0-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLChangePlayback
	{
		// Token: 0x060162E1 RID: 90849
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ExecChange([global::System.Runtime.InteropServices.In] ref byte pbRecord, [global::System.Runtime.InteropServices.In] int fForward);
	}
}
