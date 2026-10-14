using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200004A RID: 74
	[global::System.Runtime.InteropServices.Guid("CD000009-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.TypeLibType(18)]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("CDO.INNTPOnPost\0\0")]
	[global::System.Runtime.InteropServices.ComImport]
	public class NNTPPostConnectorClass : global::CDO.INNTPPostScriptConnector, global::CDO.NNTPPostConnector, global::CDO.INNTPOnPost_Event
	{
		// Token: 0x060000DE RID: 222
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern NNTPPostConnectorClass();

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000DF RID: 223
		// (remove) Token: 0x060000E0 RID: 224
		public virtual extern event global::CDO.INNTPOnPost_OnPostEventHandler OnPost;
	}
}
