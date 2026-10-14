using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib
{
	// Token: 0x02000004 RID: 4
	[global::System.Serializable]
	public class SharpZipBaseException : global::System.ApplicationException
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002A04 File Offset: 0x00001A04
		protected SharpZipBaseException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002A0E File Offset: 0x00001A0E
		public SharpZipBaseException()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002A16 File Offset: 0x00001A16
		public SharpZipBaseException(string message) : base(message)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002A1F File Offset: 0x00001A1F
		public SharpZipBaseException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}
	}
}
