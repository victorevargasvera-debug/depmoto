using System;
using System.Collections.Generic;

namespace constants
{
	// Token: 0x0200000F RID: 15
	public interface IRadioFileOperations
	{
		// Token: 0x06000019 RID: 25
		void ValidateFiles(string[] filesPath, global::constants.FileOperationCallback operationCallback);

		// Token: 0x0600001A RID: 26
		void DownloadFiles(string[] filesName, global::constants.FileOperationCallback operationCallback, global::constants.CCPTags.SetProgressBar setProgressbar);

		// Token: 0x0600001B RID: 27
		void UploadFiles(string[] filesPath, global::constants.FileOverrideCallback overrideCallback, global::constants.FileOperationCallback operationCallback, global::constants.CCPTags.SetProgressBar setProgressbar);

		// Token: 0x0600001C RID: 28
		void DeleteFiles(string[] filesName, global::constants.FileOperationCallback operationCallback, global::constants.CCPTags.SetProgressBar setProgressbar);

		// Token: 0x0600001D RID: 29
		global::System.Collections.Generic.Dictionary<string, uint> ListFiles();
	}
}
