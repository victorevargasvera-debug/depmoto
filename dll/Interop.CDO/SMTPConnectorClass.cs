using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CDO
{
	// Token: 0x0200003E RID: 62
	[global::System.Runtime.InteropServices.ClassInterface(0)]
	[global::System.Runtime.InteropServices.Guid("CD000008-8B95-11D1-82DB-00C04FB1625D")]
	[global::System.Runtime.InteropServices.TypeLibType(18)]
	[global::System.Runtime.InteropServices.ComSourceInterfaces("CDO.ISMTPOnArrival\0\0")]
	[global::System.Runtime.InteropServices.ComImport]
	public class SMTPConnectorClass : global::CDO.ISMTPScriptConnector, global::CDO.SMTPConnector, global::CDO.ISMTPOnArrival_Event
	{
		// Token: 0x060000CE RID: 206
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		public extern SMTPConnectorClass();

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000CF RID: 207
		// (remove) Token: 0x060000D0 RID: 208
		public virtual extern event global::CDO.ISMTPOnArrival_OnArrivalEventHandler OnArrival;
	}
}
