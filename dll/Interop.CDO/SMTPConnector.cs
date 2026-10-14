using System;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x02000041 RID: 65
	[global::System.Runtime.InteropServices.Guid("CD000030-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.CoClass(typeof(global::CDO.SMTPConnectorClass))]
	[global::System.Runtime.InteropServices.ComImport]
	public interface SMTPConnector : global::CDO.ISMTPScriptConnector, global::CDO.ISMTPOnArrival_Event
	{
	}
}
