using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000003 RID: 3
	public interface IContentHelper<T>
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001B RID: 27
		global::System.Collections.Generic.IEqualityComparer<T> DeleteComparer { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001C RID: 28
		global::System.Collections.Generic.IEqualityComparer<T> WriteComparer { get; }

		// Token: 0x0600001D RID: 29
		global::System.Collections.Generic.IList<T> ListCurrent();

		// Token: 0x0600001E RID: 30
		void PreSync();

		// Token: 0x0600001F RID: 31
		void Delete(T content);

		// Token: 0x06000020 RID: 32
		void Write(T content, global::Motorola.Common.Communication.IProgressIndicator progressIndicator);
	}
}
