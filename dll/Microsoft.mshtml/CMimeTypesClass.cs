using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x0200079D RID: 1949
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.Guid("3050F3FE-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public class CMimeTypesClass : global::mshtml.IHTMLMimeTypesCollection, global::mshtml.CMimeTypes
	{
		// Token: 0x0600D4BD RID: 54461
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern CMimeTypesClass();

		// Token: 0x1700464E RID: 17998
		// (get) Token: 0x0600D4BE RID: 54462
		[global::System.Runtime.InteropServices.DispId(1)]
		public virtual extern int length { [global::System.Runtime.InteropServices.DispId(1)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
