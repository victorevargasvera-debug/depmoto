using System;
using System.Collections.Generic;
using System.IO;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000053 RID: 83
	internal class VoiceAnnouncementFileReadHelper : global::Motorola.Common.Communication.IshHandler.IContentHelper<global::Motorola.Common.Communication.Pba.FileItem>
	{
		// Token: 0x06000294 RID: 660 RVA: 0x00017189 File Offset: 0x00015389
		public VoiceAnnouncementFileReadHelper(global::Motorola.Common.Communication.ICpsFileSequenceManager sequenceManager, global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> filesInServer, global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> filesInRadio)
		{
			this.filesInServer = filesInServer;
			this.filesInRadio = filesInRadio;
			this.fileSequenceManager = sequenceManager;
			this.comparer = new global::Motorola.Common.Communication.SequenceManager.VoiceAnnouncementFileReadComparer();
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000295 RID: 661 RVA: 0x000171B4 File Offset: 0x000153B4
		public global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.FileItem> DeleteComparer
		{
			get
			{
				return this.comparer;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000296 RID: 662 RVA: 0x000171CC File Offset: 0x000153CC
		public global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.FileItem> WriteComparer
		{
			get
			{
				return this.comparer;
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000171E4 File Offset: 0x000153E4
		public global::System.Collections.Generic.IList<global::Motorola.Common.Communication.Pba.FileItem> ListCurrent()
		{
			return this.filesInServer;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000171FC File Offset: 0x000153FC
		public void PreSync()
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000171FF File Offset: 0x000153FF
		public void Delete(global::Motorola.Common.Communication.Pba.FileItem content)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00017204 File Offset: 0x00015404
		public void Write(global::Motorola.Common.Communication.Pba.FileItem content, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			if (progressIndicator != null)
			{
				progressIndicator.UpdateProgress(0.0);
			}
			try
			{
				global::Motorola.Common.Communication.Pba.FileItem fileItem = this.fileSequenceManager.ReadFile(content);
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem2 in this.filesInRadio)
				{
					if (global::System.IO.Path.GetFileName(fileItem2.FilePath) == global::System.IO.Path.GetFileName(fileItem.FilePath) && fileItem2.PartionID == fileItem.PartionID)
					{
						fileItem2.FileSize = fileItem.FileSize;
						fileItem2.FileContent = fileItem.FileContent;
						return;
					}
				}
				fileItem.FilePath = global::System.IO.Path.GetFileName(fileItem.FilePath);
				this.filesInRadio.Add(fileItem);
			}
			finally
			{
				if (progressIndicator != null)
				{
					progressIndicator.UpdateProgress(1.0);
				}
			}
		}

		// Token: 0x04000194 RID: 404
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> filesInServer;

		// Token: 0x04000195 RID: 405
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> filesInRadio;

		// Token: 0x04000196 RID: 406
		private global::Motorola.Common.Communication.ICpsFileSequenceManager fileSequenceManager;

		// Token: 0x04000197 RID: 407
		private global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.FileItem> comparer;
	}
}
