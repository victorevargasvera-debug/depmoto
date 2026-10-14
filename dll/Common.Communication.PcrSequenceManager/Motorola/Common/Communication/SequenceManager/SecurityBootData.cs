using System;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000030 RID: 48
	internal class SecurityBootData
	{
		// Token: 0x06000190 RID: 400 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
		private SecurityBootData()
		{
			this.SecurityImage = null;
			this.MD5CheckSum = string.Empty;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000F50D File Offset: 0x0000D70D
		public SecurityBootData(global::Motorola.Common.Communication.Pba.PcrMemoryImage securityImage)
		{
			this.SecurityImage = securityImage;
			this.MD5CheckSum = string.Empty;
		}

		// Token: 0x040000BE RID: 190
		public global::Motorola.Common.Communication.Pba.PcrMemoryImage SecurityImage;

		// Token: 0x040000BF RID: 191
		public string MD5CheckSum;
	}
}
