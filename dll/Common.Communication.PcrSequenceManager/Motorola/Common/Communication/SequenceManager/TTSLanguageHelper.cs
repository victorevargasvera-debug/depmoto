using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200004D RID: 77
	internal class TTSLanguageHelper : global::Motorola.Common.Communication.IshHandler.IContentHelper<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>
	{
		// Token: 0x06000279 RID: 633 RVA: 0x0001690D File Offset: 0x00014B0D
		public TTSLanguageHelper(global::Motorola.Common.Communication.IshHandler.IRadioCommand controller, bool isBigEndianForPackID)
		{
			this.ioController = controller;
			this.bigEndianForPackID = isBigEndianForPackID;
			this.deleteComparer = new global::Motorola.Common.Communication.SequenceManager.TTSLanguangPackDeleteComparer();
			this.writeComparer = new global::Motorola.Common.Communication.SequenceManager.TTSLanguangPackWriteComparer();
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0001693C File Offset: 0x00014B3C
		public global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> DeleteComparer
		{
			get
			{
				return this.deleteComparer;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00016954 File Offset: 0x00014B54
		public global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> WriteComparer
		{
			get
			{
				return this.writeComparer;
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0001696C File Offset: 0x00014B6C
		public global::System.Collections.Generic.IList<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> ListCurrent()
		{
			return this.ioController.ReadTTSLanguagePackInfo();
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00016989 File Offset: 0x00014B89
		public void PreSync()
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0001698C File Offset: 0x00014B8C
		public void Delete(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo content)
		{
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Delete TTSLanguagePackInfo [{0}] size [{1}]", new object[]
			{
				content.PackID,
				content.Size
			});
			this.AvailabeSpace += content.Size;
			this.ioController.DeleteTTSLanguagePack(content.PackID, this.bigEndianForPackID);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000169F8 File Offset: 0x00014BF8
		public void Write(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo content, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			this.AvailabeSpace -= content.Size;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Write TTSLanguagePackInfo [{0}] size [{1}]", new object[]
			{
				content.PackID,
				content.Size
			});
			this.ioController.WriteTTSLanguagePack(content, 1000, this.bigEndianForPackID, progressIndicator);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00016A64 File Offset: 0x00014C64
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00016A7B File Offset: 0x00014C7B
		public uint AvailabeSpace { get; private set; }

		// Token: 0x0400018C RID: 396
		private global::Motorola.Common.Communication.IshHandler.IRadioCommand ioController;

		// Token: 0x0400018D RID: 397
		private bool bigEndianForPackID;

		// Token: 0x0400018E RID: 398
		private global::Motorola.Common.Communication.SequenceManager.TTSLanguangPackDeleteComparer deleteComparer;

		// Token: 0x0400018F RID: 399
		private global::Motorola.Common.Communication.SequenceManager.TTSLanguangPackWriteComparer writeComparer;
	}
}
