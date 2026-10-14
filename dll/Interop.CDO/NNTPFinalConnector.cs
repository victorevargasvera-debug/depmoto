using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000053 RID: 83
	[global::System.Runtime.InteropServices.CoClass(typeof(global::CDO.NNTPFinalConnectorClass))]
	[global::System.Runtime.InteropServices.Guid("CD000032-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface NNTPFinalConnector : global::CDO.INNTPFinalScriptConnector, global::CDO.INNTPOnPostFinal_Event
	{
	}
}
