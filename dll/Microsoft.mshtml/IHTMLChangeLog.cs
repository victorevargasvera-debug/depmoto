using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000C99 RID: 3225
	[global::System.Runtime.InteropServices.Guid("3050F649-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.InterfaceType(1)]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLChangeLog
	{
		// Token: 0x0601620A RID: 90634
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetNextChange([global::System.Runtime.InteropServices.In] ref byte pbBuffer, [global::System.Runtime.InteropServices.In] int nBufferSize, out int pnRecordLength);
	}
}
