using System;

namespace OpenSSL.Core
{
	// Token: 0x02000004 RID: 4
	public abstract class BaseValueType : global::OpenSSL.Core.Base
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002340 File Offset: 0x00000540
		internal BaseValueType(global::System.IntPtr ptr, bool takeOwnership) : base(ptr, takeOwnership)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000234A File Offset: 0x0000054A
		internal override void AddRef()
		{
			this.ptr = this.DuplicateHandle();
			this.owner = true;
			if (this.ptr != global::System.IntPtr.Zero)
			{
				this.OnNewHandle(this.ptr);
			}
		}

		// Token: 0x06000018 RID: 24
		internal abstract global::System.IntPtr DuplicateHandle();
	}
}
