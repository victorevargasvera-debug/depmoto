using System;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000002 RID: 2
	public interface IAppender
	{
		// Token: 0x06000001 RID: 1
		void Close();

		// Token: 0x06000002 RID: 2
		void DoAppend(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e);

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3
		// (set) Token: 0x06000004 RID: 4
		string Name { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5
		bool IsEnabled { get; }
	}
}
