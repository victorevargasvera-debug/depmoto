using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000033 RID: 51
	internal class PcrLanguageHelper : global::Motorola.Common.Communication.IshHandler.IContentHelper<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>
	{
		// Token: 0x0600019D RID: 413 RVA: 0x0000FCAF File Offset: 0x0000DEAF
		public PcrLanguageHelper(global::Motorola.Common.Communication.IshHandler.IRadioCommand controller, bool isBigEndianForPackID)
		{
			this.ioController = controller;
			this.bigEndianForPackID = isBigEndianForPackID;
			this.deleteComparer = new global::Motorola.Common.Communication.SequenceManager.PcrLanguangPackDeleteComparer();
			this.writeComparer = new global::Motorola.Common.Communication.SequenceManager.PcrLanguangPackWriteComparer();
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
		public global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> DeleteComparer
		{
			get
			{
				return this.deleteComparer;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000FCF8 File Offset: 0x0000DEF8
		public global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> WriteComparer
		{
			get
			{
				return this.writeComparer;
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000FD10 File Offset: 0x0000DF10
		public global::System.Collections.Generic.IList<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> ListCurrent()
		{
			this.AvailabeSpace = this.ioController.GetAvailabeSpaceForLanguagePack();
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Current AvailabeSpaceForLanguagePack [{0}]", new object[]
			{
				this.AvailabeSpace
			});
			return this.ioController.ReadLanguagePackInfo();
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000FD65 File Offset: 0x0000DF65
		public void PreSync()
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000FD68 File Offset: 0x0000DF68
		public void Delete(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo content)
		{
			if (!global::Motorola.Common.Communication.SequenceManager.PcrLanguageHelper.BypassLanguagePack(content))
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Delete PcrLanguagePackInfo [{0}] size [{1}]", new object[]
				{
					content.PackID,
					content.Size
				});
				this.AvailabeSpace += content.Size;
				this.ioController.DeleteLanguagePack(content.PackID, this.bigEndianForPackID);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000FDE4 File Offset: 0x0000DFE4
		public void Write(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo content, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			if (global::Motorola.Common.Communication.SequenceManager.PcrLanguageHelper.BypassLanguagePack(content))
			{
				if (progressIndicator != null)
				{
					progressIndicator.UpdateProgress(1.0);
				}
			}
			else
			{
				this.AvailabeSpace -= content.Size;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Write PcrLanguagePackInfo [{0}] size [{1}]", new object[]
				{
					content.PackID,
					content.Size
				});
				this.ioController.WriteLanguagePack(content, 1000, this.bigEndianForPackID, progressIndicator);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		private static bool BypassLanguagePack(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo content)
		{
			global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> source = from x in global::Motorola.Common.Communication.SequenceManager.PcrLanguageHelper.BypassLanguangPack
			where string.Equals(x.PackID, content.PackID, global::System.StringComparison.OrdinalIgnoreCase) && string.Equals(x.Name, content.Name, global::System.StringComparison.OrdinalIgnoreCase)
			select x;
			return source.Any<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>();
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000FF04 File Offset: 0x0000E104
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000FF1B File Offset: 0x0000E11B
		public uint AvailabeSpace { get; private set; }

		// Token: 0x040000D9 RID: 217
		private static global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo[] BypassLanguangPack = new global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo[]
		{
			new global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo
			{
				PackID = "en-us",
				Name = "English"
			}
		};

		// Token: 0x040000DA RID: 218
		private global::Motorola.Common.Communication.IshHandler.IRadioCommand ioController;

		// Token: 0x040000DB RID: 219
		private bool bigEndianForPackID;

		// Token: 0x040000DC RID: 220
		private global::Motorola.Common.Communication.SequenceManager.PcrLanguangPackDeleteComparer deleteComparer;

		// Token: 0x040000DD RID: 221
		private global::Motorola.Common.Communication.SequenceManager.PcrLanguangPackWriteComparer writeComparer;
	}
}
