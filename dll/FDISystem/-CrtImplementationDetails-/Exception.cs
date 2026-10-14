using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
	// Token: 0x020000BE RID: 190
	[global::System.Serializable]
	internal class Exception : global::System.Exception
	{
		// Token: 0x06000261 RID: 609 RVA: 0x0000D8F8 File Offset: 0x0000CCF8
		protected Exception(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000D8E0 File Offset: 0x0000CCE0
		public Exception(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000D8CC File Offset: 0x0000CCCC
		public Exception(string message) : base(message)
		{
		}
	}
}
