using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000055 RID: 85
	[global::System.Serializable]
	public class ZipException : global::ICSharpCode.SharpZipLib.SharpZipBaseException
	{
		// Token: 0x06000348 RID: 840 RVA: 0x00011593 File Offset: 0x00010593
		protected ZipException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0001159D File Offset: 0x0001059D
		public ZipException()
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000115A5 File Offset: 0x000105A5
		public ZipException(string message) : base(message)
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000115AE File Offset: 0x000105AE
		public ZipException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
