using System;

namespace Motorola.Common.CustomException
{
	// Token: 0x02000008 RID: 8
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, AllowMultiple = false)]
	public sealed class ErrorCodeAttributes : global::System.Attribute
	{
		// Token: 0x0600001C RID: 28 RVA: 0x0000238E File Offset: 0x0000058E
		public ErrorCodeAttributes()
		{
			this.Retriable = false;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000239D File Offset: 0x0000059D
		public ErrorCodeAttributes(bool retriable)
		{
			this.Retriable = retriable;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000023AC File Offset: 0x000005AC
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000023B4 File Offset: 0x000005B4
		public bool Retriable { get; set; }
	}
}
