using System;

namespace System.Data.SQLite
{
	// Token: 0x02000021 RID: 33
	public class CommitEventArgs : global::System.EventArgs
	{
		// Token: 0x06000243 RID: 579 RVA: 0x00019238 File Offset: 0x00018638
		internal CommitEventArgs()
		{
		}

		// Token: 0x040000C3 RID: 195
		public bool AbortTransaction;
	}
}
