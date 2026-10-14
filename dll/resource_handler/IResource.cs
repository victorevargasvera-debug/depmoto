using System;
using System.Collections;

namespace resource_handler
{
	// Token: 0x02000008 RID: 8
	public interface IResource
	{
		// Token: 0x0600001D RID: 29
		object GetObject(string fieldId);

		// Token: 0x0600001E RID: 30
		string GetString(string fieldId);

		// Token: 0x0600001F RID: 31
		string GetControlWidth(string fieldId);

		// Token: 0x06000020 RID: 32
		string GetControlHeight(string fieldId);

		// Token: 0x06000021 RID: 33
		string GetLabelWidth(string fieldId);

		// Token: 0x06000022 RID: 34
		string GetLabelHeight(string fieldId);

		// Token: 0x06000023 RID: 35
		string GetSpacer(string fieldId);

		// Token: 0x06000024 RID: 36
		string GetToolTip(string fieldId);

		// Token: 0x06000025 RID: 37
		string GetColumnWidth(string fieldId);

		// Token: 0x06000026 RID: 38
		global::System.Collections.Hashtable SearchResValues(string searchText, bool searchExact);
	}
}
