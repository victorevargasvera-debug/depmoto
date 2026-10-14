using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
	// Token: 0x020000D7 RID: 215
	[global::System.Serializable]
	internal class Exception : global::System.Exception
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00001A30 File Offset: 0x00000E30
		protected Exception(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00001A18 File Offset: 0x00000E18
		public Exception(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00001A04 File Offset: 0x00000E04
		public Exception(string message) : base(message)
		{
		}
	}
}
