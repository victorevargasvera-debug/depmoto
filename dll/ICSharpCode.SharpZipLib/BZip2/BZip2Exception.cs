using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.BZip2
{
	// Token: 0x02000005 RID: 5
	[global::System.Serializable]
	public class BZip2Exception : global::ICSharpCode.SharpZipLib.SharpZipBaseException
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002A29 File Offset: 0x00001A29
		protected BZip2Exception(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002A33 File Offset: 0x00001A33
		public BZip2Exception()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002A3B File Offset: 0x00001A3B
		public BZip2Exception(string message) : base(message)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002A44 File Offset: 0x00001A44
		public BZip2Exception(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
