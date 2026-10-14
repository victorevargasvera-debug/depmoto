using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000044 RID: 68
	[global::System.Runtime.InteropServices.Guid("CD000011-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.TypeLibType(18)]
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("CDO.INNTPOnPostEarly\0\0")]
	[global::System.Runtime.InteropServices.ComImport]
	public class NNTPEarlyConnectorClass : global::CDO.INNTPEarlyScriptConnector, global::CDO.NNTPEarlyConnector, global::CDO.INNTPOnPostEarly_Event
	{
		// Token: 0x060000D6 RID: 214
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern NNTPEarlyConnectorClass();

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000D7 RID: 215
		// (remove) Token: 0x060000D8 RID: 216
		public virtual extern event global::CDO.INNTPOnPostEarly_OnPostEarlyEventHandler OnPostEarly;
	}
}
