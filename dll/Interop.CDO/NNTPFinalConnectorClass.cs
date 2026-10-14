using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000050 RID: 80
	[global::System.Runtime.InteropServices.ComSourceInterfaces("CDO.INNTPOnPostFinal\0\0")]
	[global::System.Runtime.InteropServices.TypeLibType(18)]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("CD000010-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.ComImport]
	public class NNTPFinalConnectorClass : global::CDO.INNTPFinalScriptConnector, global::CDO.NNTPFinalConnector, global::CDO.INNTPOnPostFinal_Event
	{
		// Token: 0x060000E6 RID: 230
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern NNTPFinalConnectorClass();

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000E7 RID: 231
		// (remove) Token: 0x060000E8 RID: 232
		public virtual extern event global::CDO.INNTPOnPostFinal_OnPostFinalEventHandler OnPostFinal;
	}
}
