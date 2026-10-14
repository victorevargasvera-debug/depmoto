using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x0200002D RID: 45
	[global::System.Serializable]
	public class InvalidHeaderException : global::ICSharpCode.SharpZipLib.Tar.TarException
	{
		// Token: 0x0600014C RID: 332 RVA: 0x00008C57 File Offset: 0x00007C57
		protected InvalidHeaderException(global::System.Runtime.Serialization.SerializationInfo information, global::System.Runtime.Serialization.StreamingContext context) : base(information, context)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00008C61 File Offset: 0x00007C61
		public InvalidHeaderException()
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00008C69 File Offset: 0x00007C69
		public InvalidHeaderException(string message) : base(message)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00008C72 File Offset: 0x00007C72
		public InvalidHeaderException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
