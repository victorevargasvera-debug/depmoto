using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
	// Token: 0x02000011 RID: 17
	[global::System.Serializable]
	internal class Exception : global::System.Exception
	{
		// Token: 0x0600006D RID: 109 RVA: 0x0000C9C0 File Offset: 0x0000BDC0
		protected Exception(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000C9A8 File Offset: 0x0000BDA8
		public Exception(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000C994 File Offset: 0x0000BD94
		public Exception(string message) : base(message)
		{
		}
	}
}
