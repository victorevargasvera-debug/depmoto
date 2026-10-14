using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200004D RID: 77
	[global::System.Runtime.InteropServices.Guid("CD000031-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.CoClass(typeof(global::CDO.NNTPPostConnectorClass))]
	[global::System.Runtime.InteropServices.ComImport]
	public interface NNTPPostConnector : global::CDO.INNTPPostScriptConnector, global::CDO.INNTPOnPost_Event
	{
	}
}
