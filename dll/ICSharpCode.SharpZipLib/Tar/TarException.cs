using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x0200002C RID: 44
	[global::System.Serializable]
	public class TarException : global::ICSharpCode.SharpZipLib.SharpZipBaseException
	{
		// Token: 0x06000148 RID: 328 RVA: 0x00008C32 File Offset: 0x00007C32
		protected TarException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00008C3C File Offset: 0x00007C3C
		public TarException()
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00008C44 File Offset: 0x00007C44
		public TarException(string message) : base(message)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00008C4D File Offset: 0x00007C4D
		public TarException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
