using System;

namespace System.Data.SQLite
{
	// Token: 0x02000003 RID: 3
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblySourceTimeStampAttribute : global::System.Attribute
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000D7E0 File Offset: 0x0000CBE0
		public AssemblySourceTimeStampAttribute(string value)
		{
			this.sourceTimeStamp = value;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000D7FC File Offset: 0x0000CBFC
		public string SourceTimeStamp
		{
			get
			{
				return this.sourceTimeStamp;
			}
		}

		// Token: 0x04000002 RID: 2
		private string sourceTimeStamp;
	}
}
