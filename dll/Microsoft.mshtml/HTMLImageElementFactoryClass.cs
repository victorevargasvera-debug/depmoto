using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000306 RID: 774
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("3050F38F-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Reflection.DefaultMember("create")]
	[global::System.Runtime.InteropServices.ComImport]
	public class HTMLImageElementFactoryClass : global::mshtml.IHTMLImageElementFactory, global::mshtml.HTMLImageElementFactory
	{
		// Token: 0x06002F31 RID: 12081
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern HTMLImageElementFactoryClass();

		// Token: 0x06002F32 RID: 12082
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		public virtual extern global::mshtml.IHTMLImgElement create([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object width, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object height);
	}
}
