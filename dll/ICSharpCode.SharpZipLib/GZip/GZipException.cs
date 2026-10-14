using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.GZip
{
	// Token: 0x02000026 RID: 38
	[global::System.Serializable]
	public class GZipException : global::ICSharpCode.SharpZipLib.SharpZipBaseException
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00007F50 File Offset: 0x00006F50
		protected GZipException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00007F5A File Offset: 0x00006F5A
		public GZipException()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00007F62 File Offset: 0x00006F62
		public GZipException(string message) : base(message)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00007F6B File Offset: 0x00006F6B
		public GZipException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
