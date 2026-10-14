using System;

namespace IACustomException
{
	// Token: 0x02000005 RID: 5
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, AllowMultiple = false)]
	public sealed class IAErrorCodeAttributes : global::System.Attribute
	{
		// Token: 0x06000014 RID: 20 RVA: 0x0000228F File Offset: 0x0000048F
		public IAErrorCodeAttributes()
		{
			this.Retriable = false;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000229E File Offset: 0x0000049E
		public IAErrorCodeAttributes(bool retriable)
		{
			this.Retriable = retriable;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000022AD File Offset: 0x000004AD
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000022B5 File Offset: 0x000004B5
		public bool Retriable { get; set; }
	}
}
