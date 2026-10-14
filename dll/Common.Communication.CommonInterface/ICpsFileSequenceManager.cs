using System;
using System.Collections.Generic;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000008 RID: 8
	public interface ICpsFileSequenceManager
	{
		// Token: 0x06000037 RID: 55
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.Pba.FileItem dir);

		// Token: 0x06000038 RID: 56
		void DeleteFile(global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x06000039 RID: 57
		global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.Pba.FileItem file);

		// Token: 0x0600003A RID: 58
		void WriteFile(global::Motorola.Common.Communication.Pba.FileItem file, global::Motorola.Common.Communication.IProgressIndicator progressIndicator = null);

		// Token: 0x0600003B RID: 59
		long GetFileOrDirSize(global::Motorola.Common.Communication.Pba.FileItem fileOrDir);
	}
}
