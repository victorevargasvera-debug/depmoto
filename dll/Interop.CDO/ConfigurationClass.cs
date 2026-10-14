using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ADODB;

namespace CDO
{
	// Token: 0x02000039 RID: 57
	[global::System.Runtime.InteropServices.Guid("CD000002-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Reflection.DefaultMember("Fields")]
	[global::System.Runtime.InteropServices.TypeLibType(2)]
	[global::System.Runtime.InteropServices.ComImport]
	public class ConfigurationClass : global::CDO.IConfiguration, global::CDO.Configuration
	{
		// Token: 0x060000C7 RID: 199
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern ConfigurationClass();

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000C8 RID: 200
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Fields")]
		public virtual extern global::ADODB.Fields Fields { [global::System.Runtime.InteropServices.DispId(0)] [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x060000C9 RID: 201
		[global::System.Runtime.InteropServices.DispId(50)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public virtual extern void Load([global::System.Runtime.InteropServices.In] global::CDO.CdoConfigSource LoadFrom, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] string URL);

		// Token: 0x060000CA RID: 202
		[global::System.Runtime.InteropServices.DispId(160)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		public virtual extern object GetInterface([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string Interface);
	}
}
