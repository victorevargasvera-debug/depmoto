using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
	// Token: 0x0200022C RID: 556
	[global::System.Serializable]
	internal class Exception : global::System.Exception
	{
		// Token: 0x0600022F RID: 559 RVA: 0x00006D58 File Offset: 0x00006158
		protected Exception(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00006D40 File Offset: 0x00006140
		public Exception(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00006D2C File Offset: 0x0000612C
		public Exception(string message) : base(message)
		{
		}
	}
}
