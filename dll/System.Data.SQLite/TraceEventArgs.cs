using System;

namespace System.Data.SQLite
{
	// Token: 0x02000022 RID: 34
	public class TraceEventArgs : global::System.EventArgs
	{
		// Token: 0x06000244 RID: 580 RVA: 0x0001924C File Offset: 0x0001864C
		internal TraceEventArgs(string statement)
		{
			this.Statement = statement;
		}

		// Token: 0x040000C4 RID: 196
		public readonly string Statement;
	}
}
