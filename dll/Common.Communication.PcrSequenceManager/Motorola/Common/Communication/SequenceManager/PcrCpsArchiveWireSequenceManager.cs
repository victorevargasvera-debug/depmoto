using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200002B RID: 43
	public class PcrCpsArchiveWireSequenceManager : global::Motorola.Common.Communication.SequenceManager.PcrCpsSequenceManager
	{
		// Token: 0x06000147 RID: 327 RVA: 0x0000B77D File Offset: 0x0000997D
		public PcrCpsArchiveWireSequenceManager(global::Motorola.Common.Communication.IMessageExecutor messageExecutor, int maxPacketSize) : base(messageExecutor, maxPacketSize)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000B78C File Offset: 0x0000998C
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			if (this.IsParadise21Radio())
			{
				base.IOController.EnterProgramMode(0, null);
			}
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = base.ReadDevice(referencePba, sessionID);
			if (this.IsParadise21Radio())
			{
				base.IOController.CreateArchiveSession(sessionID);
				pbaObject.CodeplugData.ArchiveSessionID = sessionID;
			}
			return pbaObject;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000B7F0 File Offset: 0x000099F0
		protected override global::Motorola.Common.Communication.Pba.PackedRadioData StartWrite(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			base.StartWrite(writePBA);
			global::Motorola.Common.Communication.Pba.PackedRadioData result = null;
			if (base.IsWiredUpgradableFamily(base.ProductFamily.Family))
			{
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.SetCurrentScope(0, 40);
				}
				result = this.SyncCodeplug(writePBA);
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.SetCurrentScope(41, 100);
				}
			}
			return result;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000B86C File Offset: 0x00009A6C
		protected override global::Motorola.Common.Communication.Pba.PbaObject EndWrite(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pba, ushort sessionID, global::Motorola.Common.Communication.Pba.PackedRadioData codeplug)
		{
			if (codeplug != null)
			{
				pba.CodeplugData = codeplug;
			}
			base.EndWrite(deviceInfo, pba, sessionID, codeplug);
			double num = base.ProgressIndicator.CurrentProgress;
			this.SyncLanguangePack(pba, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, 0.12));
			num -= 0.12;
			this.SyncVoiceAnnouncementFiles(pba, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, 0.08));
			num -= 0.08;
			this.SyncTTSLanguangePack(pba, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, 0.05));
			num -= 0.05;
			if (this.IsParadise21Radio())
			{
				base.IOController.CreateArchiveSession(sessionID);
				pba.CodeplugData.ArchiveSessionID = sessionID;
			}
			return pba;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000B94C File Offset: 0x00009B4C
		private void SyncLanguangePack(global::Motorola.Common.Communication.Pba.PbaObject writePBA, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			if (base.DeviceInfoFetcher.IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.LanguagePackInfo))
			{
				global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = writePBA.LanguagePackData;
				if (languagePackData == null || languagePackData.LanguagePacks == null)
				{
					writePBA.LanguagePackData = base.ReadLanguagePacksInfo();
				}
				else
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>();
					foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in languagePackData.LanguagePacks)
					{
						global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo = languagePackBase as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo;
						if (pcrLanguagePackInfo != null)
						{
							list.Add(pcrLanguagePackInfo);
						}
					}
					bool isBigEndianForPackID = base.IsParadiseOrLightFamilies(base.ProductFamily.Family);
					global::Motorola.Common.Communication.SequenceManager.PcrLanguageHelper pcrLanguageHelper = new global::Motorola.Common.Communication.SequenceManager.PcrLanguageHelper(base.IOController, isBigEndianForPackID);
					global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> contentSyncer = new global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>(pcrLanguageHelper);
					contentSyncer.Excute(list, subProgress);
					writePBA.LanguagePackData.AvailableSpace = pcrLanguageHelper.AvailabeSpace;
				}
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000BA58 File Offset: 0x00009C58
		private void SyncVoiceAnnouncementFiles(global::Motorola.Common.Communication.Pba.PbaObject writePBA, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			if (base.IsParadiseOrLightFamilies(base.ProductFamily.Family))
			{
				global::Motorola.Common.Communication.Pba.FileSet fileSetBySet = writePBA.GetFileSetBySet("VoiceAnnouncement");
				if (fileSetBySet == null || fileSetBySet.FileItemsList == null)
				{
					if (fileSetBySet != null)
					{
						writePBA.FileSetList.Remove(fileSetBySet);
					}
					global::Motorola.Common.Communication.Pba.FileSet fileSet = base.ReadVoiceAnnouncementFilesList(base.ProductFamily.ReadFileLists);
					if (fileSet != null)
					{
						writePBA.FileSetList.Add(fileSet);
					}
				}
				else
				{
					global::Motorola.Common.Communication.IshHandler.IContentHelper<global::Motorola.Common.Communication.Pba.FileItem> helper = new global::Motorola.Common.Communication.SequenceManager.VoiceAnnouncementFileHelper(this, base.ProductFamily.ReadFileLists);
					global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.FileItem> contentSyncer = new global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.FileItem>(helper);
					contentSyncer.Excute(fileSetBySet.FileItemsList, subProgress);
				}
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000BB1C File Offset: 0x00009D1C
		private void SyncTTSLanguangePack(global::Motorola.Common.Communication.Pba.PbaObject writePBA, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			if (base.DeviceInfoFetcher.IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.TTSLanguagePackInfo))
			{
				global::Motorola.Common.Communication.Pba.LanguagePackData ttslanguagePackData = writePBA.TTSLanguagePackData;
				if (ttslanguagePackData == null || ttslanguagePackData.LanguagePacks == null)
				{
					writePBA.TTSLanguagePackData = base.ReadTTSLanguagePacksInfo();
				}
				else
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>();
					foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in ttslanguagePackData.LanguagePacks)
					{
						global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo = languagePackBase as global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo;
						if (ttslanguagePackInfo != null)
						{
							list.Add(ttslanguagePackInfo);
						}
					}
					bool isBigEndianForPackID = base.IsParadiseOrLightFamilies(base.ProductFamily.Family);
					global::Motorola.Common.Communication.SequenceManager.TTSLanguageHelper ttslanguageHelper = new global::Motorola.Common.Communication.SequenceManager.TTSLanguageHelper(base.IOController, isBigEndianForPackID);
					global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> contentSyncer = new global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>(ttslanguageHelper);
					contentSyncer.Excute(list, subProgress);
					writePBA.TTSLanguagePackData.AvailableSpace = ttslanguageHelper.AvailabeSpace;
				}
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000BC74 File Offset: 0x00009E74
		private global::Motorola.Common.Communication.Pba.PackedRadioData SyncCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePba)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection radioIshItems = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			base.IshHandler.ReadIshPartions(radioIshItems, base.ProductFamily.ReadPartitions.ToArray(), base.ProgressIndicator, null);
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = writePba.GetCodeplugInIshItemCollection();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishTypeIDPariSetInRadio = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
			radioIshItems.Headers.ToList<global::Motorola.Common.Communication.CommonUtil.IshHeader>().ForEach(delegate(global::Motorola.Common.Communication.CommonUtil.IshHeader header)
			{
				if (header.PartitionNumber == 128)
				{
					ishTypeIDPariSetInRadio.Add(header);
				}
			});
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishItemsToDelete = base.GetIshItemsToDelete(writePba, ishTypeIDPariSetInRadio);
			ishItemsToDelete.ForEach(delegate(global::Motorola.Common.Communication.CommonUtil.IshHeader s)
			{
				radioIshItems.Remove(s);
			});
			foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader in codeplugInIshItemCollection.Headers)
			{
				if (ishHeader.PartitionNumber == 128)
				{
					global::Motorola.Common.Communication.CommonUtil.IshItem item = codeplugInIshItemCollection[ishHeader];
					if (radioIshItems.ContainsHeader(ishHeader))
					{
						radioIshItems.Update(ishHeader, item);
					}
					else
					{
						radioIshItems.Add(ishHeader, item);
					}
				}
			}
			global::Motorola.Common.Communication.Pba.PackedRadioData packedRadioData = new global::Motorola.Common.Communication.Pba.PackedRadioData();
			packedRadioData.Initialize(radioIshItems);
			packedRadioData.CPVersion = base.DeviceInfoFetcher.CodeplugVersion;
			return packedRadioData;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000BDF4 File Offset: 0x00009FF4
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (!pendingDeploy && (operation & global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read) == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
			{
				if (this.IsParadise21Radio())
				{
					base.IOController.ResetRadio();
				}
			}
			base.CloseSession(sessionID, operation, pendingDeploy);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000BE40 File Offset: 0x0000A040
		private bool IsParadise21Radio()
		{
			return base.IsParadiseOrLightFamilies(base.ProductFamily.Family) && string.Compare(base.DeviceInfoFetcher.CodeplugVersion, "030000", global::System.StringComparison.OrdinalIgnoreCase) >= 0;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000BE88 File Offset: 0x0000A088
		public override bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			return base.IOController.UpdateProgrammingStatus(status, sessionID);
		}
	}
}
