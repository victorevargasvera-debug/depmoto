using System;
using System.Collections.Generic;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000051 RID: 81
	internal class VoiceAnnouncementFileHelper : global::Motorola.Common.Communication.IshHandler.IContentHelper<global::Motorola.Common.Communication.Pba.FileItem>
	{
		// Token: 0x0600028A RID: 650 RVA: 0x00016F80 File Offset: 0x00015180
		public VoiceAnnouncementFileHelper(global::Motorola.Common.Communication.ICpsFileSequenceManager sequenceManager, global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> vaDir)
		{
			this.fileSequenceManager = sequenceManager;
			this.dirToSync = vaDir;
			this.comparer = new global::Motorola.Common.Communication.SequenceManager.VoiceAnnouncementFileComparer();
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00016FA4 File Offset: 0x000151A4
		public global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.FileItem> DeleteComparer
		{
			get
			{
				return this.comparer;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00016FBC File Offset: 0x000151BC
		public global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.FileItem> WriteComparer
		{
			get
			{
				return this.comparer;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00016FD4 File Offset: 0x000151D4
		public global::System.Collections.Generic.IList<global::Motorola.Common.Communication.Pba.FileItem> ListCurrent()
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>();
			if (this.dirToSync != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileItem dir in this.dirToSync)
				{
					list.AddRange(this.fileSequenceManager.ReadFilesListInDir(dir));
				}
			}
			return list;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00017058 File Offset: 0x00015258
		public void PreSync()
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001705B File Offset: 0x0001525B
		public void Delete(global::Motorola.Common.Communication.Pba.FileItem content)
		{
			this.fileSequenceManager.DeleteFile(content);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001706C File Offset: 0x0001526C
		public void Write(global::Motorola.Common.Communication.Pba.FileItem content, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			if (progressIndicator != null)
			{
				progressIndicator.UpdateProgress(0.0);
			}
			try
			{
				this.fileSequenceManager.WriteFile(content, progressIndicator);
			}
			finally
			{
				if (progressIndicator != null)
				{
					progressIndicator.UpdateProgress(1.0);
				}
			}
		}

		// Token: 0x04000191 RID: 401
		private global::Motorola.Common.Communication.ICpsFileSequenceManager fileSequenceManager;

		// Token: 0x04000192 RID: 402
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> dirToSync;

		// Token: 0x04000193 RID: 403
		private global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.FileItem> comparer;
	}
}
