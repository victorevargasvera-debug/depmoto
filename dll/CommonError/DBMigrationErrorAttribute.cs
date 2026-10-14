using System;
using System.Runtime.Serialization;

namespace Motorola.Common.CustomException
{
	// Token: 0x02000003 RID: 3
	[global::System.Serializable]
	public sealed class DBMigrationErrorAttribute : global::System.Attribute
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002307 File Offset: 0x00000507
		// (set) Token: 0x06000011 RID: 17 RVA: 0x0000230F File Offset: 0x0000050F
		[global::System.Runtime.Serialization.DataMember]
		public bool IsFatal { get; set; }

		// Token: 0x06000012 RID: 18 RVA: 0x00002318 File Offset: 0x00000518
		public DBMigrationErrorAttribute(bool isFatal)
		{
			this.IsFatal = isFatal;
		}
	}
}
