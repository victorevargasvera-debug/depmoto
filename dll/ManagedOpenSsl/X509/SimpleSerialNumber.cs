using System;

namespace OpenSSL.X509
{
	// Token: 0x0200007E RID: 126
	public class SimpleSerialNumber : global::OpenSSL.X509.ISequenceNumber
	{
		// Token: 0x0600052E RID: 1326 RVA: 0x00009A18 File Offset: 0x00007C18
		public SimpleSerialNumber()
		{
			this.seq = 0;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00009A27 File Offset: 0x00007C27
		public SimpleSerialNumber(int seed)
		{
			this.seq = seed;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00009A38 File Offset: 0x00007C38
		public int Next()
		{
			return ++this.seq;
		}

		// Token: 0x040003E8 RID: 1000
		private int seq;
	}
}
