using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000047 RID: 71
	[global::System.Runtime.InteropServices.Guid("CD000034-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.CoClass(typeof(global::CDO.NNTPEarlyConnectorClass))]
	[global::System.Runtime.InteropServices.ComImport]
	public interface NNTPEarlyConnector : global::CDO.INNTPEarlyScriptConnector, global::CDO.INNTPOnPostEarly_Event
	{
	}
}
