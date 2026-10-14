using System;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200002F RID: 47
	internal class ProgressInfoObject
	{
		// Token: 0x0600018E RID: 398 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		public ProgressInfoObject()
		{
			this.startScope = 0;
			this.endScope = 0;
			this.percentPerOperation = 0;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000F4D0 File Offset: 0x0000D6D0
		private ProgressInfoObject(int startScope, int endScope, int percentPerOperation)
		{
			this.startScope = startScope;
			this.endScope = endScope;
			this.percentPerOperation = percentPerOperation;
		}

		// Token: 0x040000BB RID: 187
		public int startScope;

		// Token: 0x040000BC RID: 188
		public int endScope;

		// Token: 0x040000BD RID: 189
		public int percentPerOperation;
	}
}
