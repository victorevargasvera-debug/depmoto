using System;

namespace System.Data.SQLite
{
	// Token: 0x02000002 RID: 2
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblySourceIdAttribute : global::System.Attribute
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000D7B0 File Offset: 0x0000CBB0
		public AssemblySourceIdAttribute(string value)
		{
			this.sourceId = value;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000D7CC File Offset: 0x0000CBCC
		public string SourceId
		{
			get
			{
				return this.sourceId;
			}
		}

		// Token: 0x04000001 RID: 1
		private string sourceId;
	}
}
