using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002B RID: 43
	[global::System.Runtime.Serialization.DataContract]
	public class TerminateSession
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00003374 File Offset: 0x00001574
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0000337C File Offset: 0x0000157C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.ReasonClass terminateSession { get; set; }

		// Token: 0x0600009D RID: 157 RVA: 0x00003385 File Offset: 0x00001585
		public TerminateSession(global::Motorola.Common.Communication.ReasonClass reason)
		{
			this.terminateSession = reason;
		}
	}
}
