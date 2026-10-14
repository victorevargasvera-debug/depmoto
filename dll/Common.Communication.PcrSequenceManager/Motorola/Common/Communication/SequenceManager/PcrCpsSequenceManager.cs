using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using fxpcommunication;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.Communication.SequenceManager.PbaFileProcessing;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000024 RID: 36
	public class PcrCpsSequenceManager : global::Motorola.Common.Communication.IshHandler.CpsFileSequenceManagerBase, global::Motorola.Common.Communication.ICpsSequenceManager, global::Motorola.Common.Communication.IDepotSequenceManager
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00005FC0 File Offset: 0x000041C0
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00005FD8 File Offset: 0x000041D8
		protected global::Motorola.Common.Communication.IshHandler.CommonIshHandler IshHandler
		{
			get
			{
				return this._IshHandler;
			}
			set
			{
				this._IshHandler = value;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00005FE4 File Offset: 0x000041E4
		protected bool IsParadiseOrLightFamilies(global::Motorola.Common.Communication.CommonUtil.ProductFamily family)
		{
			return family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio || family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseLightRadio;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00006010 File Offset: 0x00004210
		protected bool IsWiredUpgradableFamily(global::Motorola.Common.Communication.CommonUtil.ProductFamily family)
		{
			return family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio || family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseLightRadio || family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00006040 File Offset: 0x00004240
		public PcrCpsSequenceManager(global::Motorola.Common.Communication.IMessageExecutor messageExecutor, int maxPacketSize)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(messageExecutor, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			this.IshHandler = new global::Motorola.Common.Communication.IshHandler.CommonIshHandler(messageExecutor, maxPacketSize);
			base.IOController = new global::Motorola.Common.Communication.IshHandler.IOController(messageExecutor, maxPacketSize, true);
			this.msgExecutor = messageExecutor;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00006098 File Offset: 0x00004298
		public virtual bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			return true;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000060AB File Offset: 0x000042AB
		public PcrCpsSequenceManager(global::fxpcommunication.FxpCommunication featureExchange)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(featureExchange, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			this.featureEnable = featureExchange;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000060DC File Offset: 0x000042DC
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000060F3 File Offset: 0x000042F3
		public global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000060FC File Offset: 0x000042FC
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00006113 File Offset: 0x00004313
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000611C File Offset: 0x0000431C
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00006133 File Offset: 0x00004333
		public bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x060000B3 RID: 179 RVA: 0x0000613C File Offset: 0x0000433C
		public virtual bool DifferentialWriteSupported(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			return false;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00006150 File Offset: 0x00004350
		public virtual global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = new global::Motorola.Common.Communication.CommonUtil.DeviceInfo();
			this.ReadBasicInfo(deviceInfo);
			return deviceInfo;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006174 File Offset: 0x00004374
		public virtual global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo pcrdeviceInfo = new global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo();
			this.ReadBasicInfo(pcrdeviceInfo);
			this.ReadExtendedDeviceInfo(pcrdeviceInfo);
			return pcrdeviceInfo;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000061A0 File Offset: 0x000043A0
		public virtual global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
			}
			global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.PcrTuningPathFixUpSequencer(this.DeviceInfoFetcher, base.IOController);
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = this.ReadLanguagePacksInfo();
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData2 = null;
			try
			{
				languagePackData2 = this.ReadTTSLanguagePacksInfo();
			}
			catch (global::System.Exception)
			{
			}
			double num = 1.0;
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(0.05, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
				num -= 0.05;
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			this.IshHandler.ReadIshPartions(ishItemCollection, this.ProductFamily.ReadPartitions.ToArray(), new global::Motorola.Common.Communication.IteratedProgressIndicator(this.ProgressIndicator, 0.7), null);
			num -= 0.8;
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			pbaObject.SetCodeplug(ishItemCollection);
			pbaObject.CodeplugData.CPVersion = this.DeviceInfoFetcher.CodeplugVersion;
			pbaObject.LanguagePackData = languagePackData;
			if (languagePackData2 != null)
			{
				pbaObject.TTSLanguagePackData = languagePackData2;
			}
			this.ReadFileItems(pbaObject, referencePba, num);
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
			}
			return pbaObject;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00006314 File Offset: 0x00004514
		public byte QueryRadioUpdateStatus()
		{
			return this.DeviceInfoFetcher.QueryRadioUpdateStatus();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00006334 File Offset: 0x00004534
		protected void ReadFileItems(global::Motorola.Common.Communication.Pba.PbaObject pbaObj, global::Motorola.Common.Communication.Pba.PbaObject referencePba, double subProgressRate)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> readFileLists = this.ProductFamily.ReadFileLists;
			global::Motorola.Common.Communication.Pba.FileSet fileSet = this.ReadVoiceAnnouncementFilesList(readFileLists);
			if (fileSet != null)
			{
				pbaObj.FileSetList.Add(fileSet);
			}
			this.UpdateMaxDataTransferSize();
			global::Motorola.Common.Communication.Pba.FileSet fileSet2 = this.ReadWelcomeBitmap();
			if (fileSet2 != null)
			{
				pbaObj.FileSetList.Add(fileSet2);
			}
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.IncreaseProcess(0.05);
			}
			subProgressRate -= 0.05;
			global::Motorola.Common.Communication.Pba.FileSet fileSet3 = (referencePba == null) ? null : referencePba.GetFileSetBySet("VoiceAnnouncementInServer");
			if (fileSet != null && fileSet3 != null && fileSet3.FileItemsList != null)
			{
				this.SyncVoiceAnnouncementFilesInServer(fileSet.FileItemsList, fileSet3.FileItemsList, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.ProgressIndicator, subProgressRate));
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006418 File Offset: 0x00004618
		protected global::Motorola.Common.Communication.Pba.FileSet ReadVoiceAnnouncementFilesList(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> vaDirs)
		{
			global::Motorola.Common.Communication.Pba.FileSet result;
			if (vaDirs != null && vaDirs.Count > 0)
			{
				global::Motorola.Common.Communication.Pba.FileSet fileSet = new global::Motorola.Common.Communication.Pba.FileSet("VoiceAnnouncement");
				foreach (global::Motorola.Common.Communication.Pba.FileItem dir in vaDirs)
				{
					fileSet.FileItemsList.AddRange(base.ReadFilesListInDir(dir));
				}
				result = fileSet;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000064A8 File Offset: 0x000046A8
		private global::Motorola.Common.Communication.Pba.FileSet ReadWelcomeBitmap()
		{
			global::Motorola.Common.Communication.Pba.FileItem deviceInfo = this.DeviceInfoFetcher.GetDeviceInfo<global::Motorola.Common.Communication.Pba.FileItem>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.WelcomeBitmap);
			global::Motorola.Common.Communication.Pba.FileSet result;
			if (deviceInfo != null)
			{
				result = new global::Motorola.Common.Communication.Pba.FileSet("WelcomeBitmap")
				{
					FileItemsList = 
					{
						deviceInfo
					}
				};
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000064F0 File Offset: 0x000046F0
		private void SyncVoiceAnnouncementFilesInServer(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> vaFilesInRadio, global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> vaFilesInServer, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			if (this.IsParadiseOrLightFamilies(this.ProductFamily.Family))
			{
				global::Motorola.Common.Communication.IshHandler.IContentHelper<global::Motorola.Common.Communication.Pba.FileItem> helper = new global::Motorola.Common.Communication.SequenceManager.VoiceAnnouncementFileReadHelper(this, vaFilesInServer, vaFilesInRadio);
				global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.FileItem> contentSyncer = new global::Motorola.Common.Communication.IshHandler.ContentSyncer<global::Motorola.Common.Communication.Pba.FileItem>(helper);
				contentSyncer.Excute(vaFilesInRadio, subProgress);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00006530 File Offset: 0x00004730
		public virtual global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = this.WritePrecheck(writePBA);
			global::Motorola.Common.Communication.Pba.PackedRadioData codeplug = this.StartWrite(writePBA);
			global::Motorola.Common.Communication.Pba.PbaObject pba = this.WriteCodeplugInIsh(writePBA);
			return this.EndWrite(deviceInfo, pba, sessionID, codeplug);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00006568 File Offset: 0x00004768
		private void WriteConnectPlusOBFiles(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> fileListBySetName = writePBA.GetFileListBySetName("PBBProvisioningPackage");
			if (null != fileListBySetName)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem in fileListBySetName)
				{
					string uri = fileItem.URI;
					if (!string.IsNullOrEmpty(uri) && global::System.IO.File.Exists(uri))
					{
						global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.OBPackage obpackage = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.OBPackage();
						global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.FileItem> flashFiles = obpackage.GetFlashFiles(uri);
						foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem2 in flashFiles)
						{
							if (fileItem2 != null && !string.IsNullOrEmpty(fileItem2.FilePath))
							{
								base.WriteFile(fileItem2, null);
							}
						}
					}
				}
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000667C File Offset: 0x0000487C
		protected global::Motorola.Common.Communication.CommonUtil.DeviceInfo WritePrecheck(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			if (this.DeviceInfoFetcher.GetDeviceInfo<bool>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.IsLowBattery))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_BatteryLevelLow);
			}
			global::Motorola.Common.Communication.SequenceManager.PcrTuningPathFixUpHandler.PcrTuningPathFixUpSequencer(this.DeviceInfoFetcher, base.IOController);
			this.WriteConnectPlusOBFiles(writePBA);
			return this.WriteValidationAndGetDeviceInfo(writePBA);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000066D4 File Offset: 0x000048D4
		protected virtual global::Motorola.Common.Communication.Pba.PackedRadioData StartWrite(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
			}
			base.IOController.EnterProgramMode(0, null);
			return writePBA.CodeplugData;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006720 File Offset: 0x00004920
		protected global::Motorola.Common.Communication.Pba.PbaObject WriteCodeplugInIsh(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			double num = 1.0;
			this.DeleteIshItems(writePBA, this.ProductFamily.WritePartitions, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.ProgressIndicator, 0.2));
			num -= 0.2;
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection writeItems = this.FilterIshItemsToWrite(writePBA, null);
			this.IshHandler.WriteIshItems(writeItems, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.ProgressIndicator, 0.5), false);
			num -= 0.5;
			this.IshHandler.ReorgIshPartition(this.ProductFamily.WritePartitions);
			return writePBA;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000067C0 File Offset: 0x000049C0
		protected virtual global::Motorola.Common.Communication.Pba.PbaObject EndWrite(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pba, ushort sessionID, global::Motorola.Common.Communication.Pba.PackedRadioData codeplug)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> fileListBySetName = pba.GetFileListBySetName("WelcomeBitmap");
			this.WriteWelcomeBitmap(fileListBySetName);
			if (deviceInfo.Family.Equals(global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio))
			{
				int num = 0;
				if (!string.IsNullOrEmpty(deviceInfo.SoftwareVersion) && deviceInfo.SoftwareVersion.Length > 2)
				{
					if (int.TryParse(deviceInfo.SoftwareVersion.Substring(1, 2), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.NumberFormatInfo.InvariantInfo, out num) && num > 1)
					{
						base.IOController.SyncDateTime();
					}
				}
			}
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
			}
			return pba;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00006890 File Offset: 0x00004A90
		private void ValidateSpecialFields(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationSpecialField> validationSpecialFields, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			if (validationSpecialFields != null && validationSpecialFields.Any<global::Motorola.Common.Communication.Pba.ValidationSpecialField>())
			{
				foreach (global::Motorola.Common.Communication.Pba.ValidationSpecialField validationSpecialField in validationSpecialFields)
				{
					switch (validationSpecialField.SpecialValidationMethod)
					{
					case global::Motorola.Common.Communication.Pba.SpecialValidationMethod.PCRCodeplugPassword:
						if (!this.PCRCodeplugPasswordValidation(validationSpecialField.Value, deviceInfo))
						{
							if (((global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)deviceInfo).PasswordStatus.RemainingAttempts <= 0)
							{
								global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationSpecialField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.AstroCruncherPasswordValidationFailsRadioLocked);
							}
							else if (((global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)deviceInfo).PasswordStatus.RemainingAttempts <= 3)
							{
								global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationSpecialField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.AstroCruncherPasswordValidationFailsRemainingAttempt);
							}
							else
							{
								global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationSpecialField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.AstroCruncherPasswordValidationFails);
							}
						}
						break;
					case global::Motorola.Common.Communication.Pba.SpecialValidationMethod.PCRFlashSize:
						this.ValidateFlashSize(deviceInfo, global::System.Convert.ToBoolean(validationSpecialField.Value));
						break;
					case global::Motorola.Common.Communication.Pba.SpecialValidationMethod.PCRDigitalFw:
						this.ValidateDigitalFW(deviceInfo, validationSpecialField);
						break;
					case global::Motorola.Common.Communication.Pba.SpecialValidationMethod.PCRDigitalPhonePatch:
						this.ValidateDigitalPhonePatch(deviceInfo, validationSpecialField);
						break;
					}
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000069CC File Offset: 0x00004BCC
		private void ValidateDigitalFW(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.Pba.ValidationSpecialField specialField)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField>();
			global::Motorola.Common.Communication.Pba.ValidationField validationField = global::Motorola.Common.Communication.Pba.ValidationSpecialField.RetrieveValidationInfoFrinString(specialField.Value);
			if (validationField != null && !((global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)devInfo).IsDSPEnabled)
			{
				list.Add(validationField);
				global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> validateItemsToRead = global::Motorola.Common.Communication.IshHandler.Validator.GetValidateItemsToRead(list);
				if (validateItemsToRead != null && validateItemsToRead.Any<global::Motorola.Common.Communication.CommonUtil.IshHeader>())
				{
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = this.IshHandler.ReadIshItems(validateItemsToRead, null);
					if (ishItemCollection.Count > 0)
					{
						global::Motorola.Common.Communication.CommonUtil.IshItem value = ishItemCollection.First<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>().Value;
						if (!global::Motorola.Common.Communication.IshHandler.Validator.ValidateField(validationField, value))
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ProxyValidationDigitalFWMismatch);
						}
					}
				}
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00006A7C File Offset: 0x00004C7C
		private void ValidateDigitalPhonePatch(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.Pba.ValidationSpecialField specialField)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField>();
			global::Motorola.Common.Communication.Pba.ValidationField validationField = global::Motorola.Common.Communication.Pba.ValidationSpecialField.RetrieveValidationInfoFrinString(specialField.Value);
			if (validationField != null && !((global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)devInfo).IsDTPEnabled)
			{
				list.Add(validationField);
				global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> validateItemsToRead = global::Motorola.Common.Communication.IshHandler.Validator.GetValidateItemsToRead(list);
				if (validateItemsToRead != null && validateItemsToRead.Any<global::Motorola.Common.Communication.CommonUtil.IshHeader>())
				{
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = this.IshHandler.ReadIshItems(validateItemsToRead, null);
					if (ishItemCollection.Count > 0)
					{
						global::Motorola.Common.Communication.CommonUtil.IshItem value = ishItemCollection.First<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>().Value;
						if (!global::Motorola.Common.Communication.IshHandler.Validator.ValidateField(validationField, value))
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ProxyValidationDTPFwMismatch);
						}
					}
				}
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006B2C File Offset: 0x00004D2C
		private void ValidateFlashSize(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, bool is32M)
		{
			if (((global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)devInfo).Is32MPlatform != is32M)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ProxyValidationFlashSizeMismatch);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006B58 File Offset: 0x00004D58
		private bool PCRCodeplugPasswordValidation(string value, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			bool flag = false;
			string password = string.Empty;
			global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo pcrdeviceInfo = deviceInfo as global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo;
			bool result;
			if (pcrdeviceInfo == null)
			{
				result = true;
			}
			else
			{
				global::Motorola.Common.Communication.CommonUtil.PasswordStatus passwordStatus = pcrdeviceInfo.PasswordStatus;
				if (passwordStatus.Policy == global::Motorola.Common.Communication.CommonUtil.PasswordPolicy.Enhanced)
				{
					if (!string.IsNullOrEmpty(value))
					{
						if (passwordStatus.RemainingAttempts > 0)
						{
							password = global::CommonSecurity.ComputeHash(value, passwordStatus.Salt, passwordStatus.AlgorithmID);
							global::Motorola.Common.Communication.CommonUtil.PasswordStatus passwordStatus2 = base.IOController.ValidateLocalPassword(password);
							if (passwordStatus2 != null)
							{
								passwordStatus.RemainingAttempts = passwordStatus2.RemainingAttempts;
								flag = passwordStatus2.IsPasswordValidationSuccess;
							}
						}
					}
				}
				else
				{
					flag = true;
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00006C1D File Offset: 0x00004E1D
		protected void WriteValidation(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			this.WriteValidationAndGetDeviceInfo(pbaObject);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00006C28 File Offset: 0x00004E28
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo WriteValidationAndGetDeviceInfo(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = this.ReadExtendedDeviceInfo();
			if (pbaObject.ValidationSpecialFields != null && pbaObject.ValidationSpecialFields.Count > 0)
			{
				this.ValidateSpecialFields(pbaObject.ValidationSpecialFields, deviceInfo);
			}
			global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> validateItemsToRead = global::Motorola.Common.Communication.IshHandler.Validator.GetValidateItemsToRead(pbaObject.ValidationFields);
			if (validateItemsToRead != null && validateItemsToRead.Any<global::Motorola.Common.Communication.CommonUtil.IshHeader>())
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishInRadio = this.IshHandler.ReadIshItems(validateItemsToRead, null);
				global::Motorola.Common.Communication.IshHandler.Validator.ValidateFields(pbaObject.ValidationFields, ishInRadio);
			}
			if (pbaObject.ValidationInfos != null && pbaObject.ValidationInfos.Count > 0)
			{
				global::Motorola.Common.Communication.IshHandler.Validator.ValidateInfos(pbaObject.ValidationInfos, deviceInfo, null);
			}
			if (pbaObject.LanguagePackData != null && pbaObject.LanguagePackData.LanguagePacks.Count > 0)
			{
				global::Motorola.Common.Communication.IshHandler.Validator.ValidateAvailableSpace(pbaObject.LanguagePackData, this.ReadLanguagePacksInfo());
			}
			return deviceInfo;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006D24 File Offset: 0x00004F24
		public virtual global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			if (blockList != null && blockList.Any<T>())
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>(blockList.Count);
				try
				{
					foreach (T t in blockList)
					{
						object obj = t;
						list.Add((global::Motorola.Common.Communication.CommonUtil.IshHeader)obj);
					}
				}
				catch (global::System.InvalidCastException systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgumentType, systemException);
				}
				if (this.ProgressIndicator != null)
				{
					this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
				}
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
				if (list.Count == 1 && list[0].IshID == 65535 && list[0].IshType == 65535)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list2 = this.IshHandler.ReadIshTypeIdPairSet(list[0].PartitionNumber, this.ProgressIndicator);
					ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
					byte[] data = new byte[0];
					foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader headers in list2)
					{
						ishItemCollection.Add(headers, new global::Motorola.Common.Communication.CommonUtil.IshItem
						{
							Data = data
						});
					}
				}
				else
				{
					ishItemCollection = this.IshHandler.ReadIshItems(list, this.ProgressIndicator);
				}
				if (this.ProgressIndicator != null)
				{
					this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
				}
				pbaObject.SetCodeplug(ishItemCollection);
				return pbaObject;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00006F30 File Offset: 0x00005130
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> deviceInfo = this.DeviceInfoFetcher.GetDeviceInfo<global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.LanguagePackInfo);
			if (deviceInfo != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo in deviceInfo)
				{
					if (pcrLanguagePackInfo.Size > 0U)
					{
						languagePackData.LanguagePacks.Add(pcrLanguagePackInfo);
					}
				}
			}
			languagePackData.AvailableSpace = (uint)this.DeviceInfoFetcher.GetDeviceInfo<int>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.AvailableLPSpace);
			return languagePackData;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00006FF4 File Offset: 0x000051F4
		public void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			bool flag;
			if (langPackData != null)
			{
				flag = !langPackData.LanguagePacks.Any((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => lp == null);
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
			}
			try
			{
				base.IOController.EnterProgramMode(0, null);
				double progressRate = 1.0 / (double)langPackData.LanguagePacks.Count;
				foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in langPackData.LanguagePacks)
				{
					global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pack = languagePackBase as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo;
					this.WriteLanguagePack(pack, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.ProgressIndicator, progressRate));
				}
			}
			finally
			{
				if (this.ProgressIndicator != null)
				{
					this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteLanguagesDone);
				}
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00007144 File Offset: 0x00005344
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			bool flag;
			if (langPackData != null)
			{
				flag = !langPackData.LanguagePacks.Any((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => lp == null);
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
			}
			try
			{
				bool bigEndianForPackID = this.IsParadiseOrLightFamilies(this.ProductFamily.Family);
				base.IOController.EnterProgramMode(0, null);
				double increasePercent = 1.0 / (double)langPackData.LanguagePacks.Count;
				foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in langPackData.LanguagePacks)
				{
					global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo = (global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase;
					base.IOController.DeleteLanguagePack(pcrLanguagePackInfo.PackID, bigEndianForPackID);
					if (this.ProgressIndicator != null)
					{
						this.ProgressIndicator.IncreaseProcess(increasePercent);
					}
				}
			}
			finally
			{
				if (this.ProgressIndicator != null)
				{
					this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteLanguagesDone);
				}
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000072A4 File Offset: 0x000054A4
		private void WriteLanguagePack(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pack, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			try
			{
				if (pack != null)
				{
					global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = this.ReadLanguagePacksInfo();
					if (pack.Size > languagePackData.AvailableSpace)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadLanguagePackInfoFailure);
					}
					bool bigEndianForPackID = this.IsParadiseOrLightFamilies(this.ProductFamily.Family);
					base.IOController.WriteLanguagePack(pack, 1000, bigEndianForPackID, subProgress);
				}
			}
			finally
			{
				if (subProgress != null)
				{
					subProgress.UpdateProgress(1.0);
				}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00007344 File Offset: 0x00005544
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> deviceInfo = this.DeviceInfoFetcher.GetDeviceInfo<global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.TTSLanguagePackInfo);
			if (deviceInfo != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo in deviceInfo)
				{
					if (ttslanguagePackInfo.Size > 0U)
					{
						languagePackData.LanguagePacks.Add(ttslanguagePackInfo);
					}
				}
			}
			languagePackData.AvailableSpace = (uint)this.DeviceInfoFetcher.GetDeviceInfo<int>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.AvailableLPSpace);
			return languagePackData;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00007408 File Offset: 0x00005608
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			bool flag;
			if (langPackData != null)
			{
				flag = !langPackData.LanguagePacks.Any((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => lp == null);
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
			}
			try
			{
				base.IOController.EnterProgramMode(0, null);
				double progressRate = 1.0 / (double)langPackData.LanguagePacks.Count;
				foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in langPackData.LanguagePacks)
				{
					global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo pack = languagePackBase as global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo;
					this.WriteTTSLanguagePack(pack, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.ProgressIndicator, progressRate));
				}
			}
			finally
			{
				if (this.ProgressIndicator != null)
				{
					this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteLanguagesDone);
				}
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00007558 File Offset: 0x00005758
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			bool flag;
			if (langPackData != null)
			{
				flag = !langPackData.LanguagePacks.Any((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => lp == null);
			}
			else
			{
				flag = false;
			}
			if (!flag)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
			}
			try
			{
				bool bigEndianForPackID = this.IsParadiseOrLightFamilies(this.ProductFamily.Family);
				base.IOController.EnterProgramMode(0, null);
				double increasePercent = 1.0 / (double)langPackData.LanguagePacks.Count;
				foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in langPackData.LanguagePacks)
				{
					global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo = (global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo)languagePackBase;
					base.IOController.DeleteTTSLanguagePack(ttslanguagePackInfo.PackID, bigEndianForPackID);
					if (this.ProgressIndicator != null)
					{
						this.ProgressIndicator.IncreaseProcess(increasePercent);
					}
				}
			}
			finally
			{
				if (this.ProgressIndicator != null)
				{
					this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteLanguagesDone);
				}
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000076B8 File Offset: 0x000058B8
		private void WriteTTSLanguagePack(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo pack, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			try
			{
				if (pack != null)
				{
					bool bigEndianForPackID = this.IsParadiseOrLightFamilies(this.ProductFamily.Family);
					base.IOController.WriteTTSLanguagePack(pack, 1000, bigEndianForPackID, subProgress);
				}
			}
			finally
			{
				if (subProgress != null)
				{
					subProgress.UpdateProgress(1.0);
				}
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00007730 File Offset: 0x00005930
		protected void WriteWelcomeBitmap(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> filesList)
		{
			if (filesList != null)
			{
				if (filesList.Count == 0)
				{
					string key = global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.WelcomeBitmap.ToString();
					if (this.ProductFamily.ReadFiles != null && this.ProductFamily.ReadFiles.ContainsKey(key))
					{
						global::Motorola.Common.Communication.Pba.FileItem file = this.ProductFamily.ReadFiles[key];
						try
						{
							base.DeleteFile(file);
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure)
							{
								throw;
							}
						}
					}
				}
				else
				{
					foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem in filesList)
					{
						if (fileItem != null && !string.IsNullOrEmpty(fileItem.FilePath))
						{
							base.WriteFile(fileItem, null);
						}
					}
				}
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000784C File Offset: 0x00005A4C
		public virtual void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			if (mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
			}
			if (this.DeviceInfoFetcher.GetDeviceInfo<bool>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.IsLowBattery))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_BatteryLevelLow);
			}
			base.IOController.EnterBootMode();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000789C File Offset: 0x00005A9C
		public virtual void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID;
			if (fileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CONTROLLER_FPGA)
			{
				fpgaID = global::Motorola.Common.Communication.Rcmp.FpgaOperationID.BanditController;
			}
			else
			{
				if (fileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.WIRELINE_FPGA)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
				fpgaID = global::Motorola.Common.Communication.Rcmp.FpgaOperationID.BanditWireline;
			}
			base.IOController.SendFPGAErase(fpgaID);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000078E4 File Offset: 0x00005AE4
		public virtual void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID;
			if (fileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CONTROLLER_FPGA)
			{
				fpgaID = global::Motorola.Common.Communication.Rcmp.FpgaOperationID.BanditController;
			}
			else
			{
				if (fileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.WIRELINE_FPGA)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
				fpgaID = global::Motorola.Common.Communication.Rcmp.FpgaOperationID.BanditWireline;
			}
			base.IOController.SendFPGAReset(fpgaID);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000792C File Offset: 0x00005B2C
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			byte[] hashInput = this.featureEnable.CreateHashInput(xmlHashInput);
			for (int i = 0; i < featureCodeIDs.Count; i++)
			{
				this.featureEnable.Enable(fwVersion, serialNumber, hashInput, featureCodeIDs[i]);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00007978 File Offset: 0x00005B78
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			if (this.DeviceInfoFetcher.GetDeviceInfo<bool>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.IsLowBattery))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_BatteryLevelLow);
			}
			if (validatePba != null)
			{
				this.WriteValidation(validatePba);
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
			foreach (global::Motorola.Common.Communication.CommonUtil.DataBlockItem dataBlockItem in blockList)
			{
				global::Motorola.Common.Communication.CommonUtil.IshHeader item = new global::Motorola.Common.Communication.CommonUtil.IshHeader
				{
					PartitionNumber = dataBlockItem.PartitionID,
					IshType = dataBlockItem.BlockType,
					IshID = dataBlockItem.BlockID
				};
				if (!list.Contains(item))
				{
					list.Add(item);
				}
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = this.IshHandler.ReadIshItems(list, null);
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.LoadXml("<UPDATES></UPDATES>");
			foreach (global::Motorola.Common.Communication.CommonUtil.DataBlockItem dataBlockItem2 in blockList)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in ishItemCollection)
				{
					if (dataBlockItem2.BlockType == keyValuePair.Key.IshType && dataBlockItem2.BlockID == keyValuePair.Key.IshID && dataBlockItem2.PartitionID == keyValuePair.Key.PartitionNumber)
					{
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
						byte[] array = new byte[dataBlockItem2.Length];
						global::System.Array.Copy(keyValuePair.Value.Data, dataBlockItem2.Offset, array, 0, dataBlockItem2.Length);
						for (int i = 0; i < dataBlockItem2.Length; i++)
						{
							int num = (int)array[i];
							string text = num.ToString("X");
							if (text.Length == 1)
							{
								stringBuilder.Append("0");
							}
							stringBuilder.Append(text);
						}
						global::System.Xml.XmlNode xmlNode = xmlDocument.CreateNode(global::System.Xml.XmlNodeType.Element, dataBlockItem2.TagName, string.Empty);
						xmlNode.InnerText = stringBuilder.ToString();
						xmlDocument.DocumentElement.AppendChild(xmlNode);
						break;
					}
				}
			}
			return xmlDocument.OuterXml;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00007C60 File Offset: 0x00005E60
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			global::Motorola.Common.Communication.CommonUtil.PasswordStatus result = null;
			try
			{
				result = base.IOController.ValidateLocalPassword(password);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, new object[0]);
				result = null;
			}
			return result;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00007CB8 File Offset: 0x00005EB8
		public void UpdateMACAddress(byte[] macAddress)
		{
			global::Motorola.Common.Communication.SequenceManager.PcrBootExecutor pcrBootExecutor = new global::Motorola.Common.Communication.SequenceManager.PcrBootExecutor(this.msgExecutor);
			pcrBootExecutor.Unlock();
			base.IOController.UnlockISHPartition(129);
			base.IOController.UpdateMACAddress(macAddress);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00007CF7 File Offset: 0x00005EF7
		public virtual void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00007CFC File Offset: 0x00005EFC
		public virtual void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (!pendingDeploy)
			{
				if ((operation & global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program) == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
				{
					base.IOController.ResetRadio();
				}
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00007D2E File Offset: 0x00005F2E
		public void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007D34 File Offset: 0x00005F34
		private void UnlockRadioPartition(byte partition)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadRadioKey rcmpReadRadioKey = new global::Motorola.Common.Communication.Rcmp.RcmpReadRadioKey();
			this.msgExecutor.SendAndReceiveMessage(rcmpReadRadioKey);
			if (rcmpReadRadioKey.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadRadioKeyFailure);
			}
			byte[] radioKey = global::Motorola.Common.Communication.SequenceManager.RadioSecurity.EncryptRadioKey(rcmpReadRadioKey.RadioKey);
			global::Motorola.Common.Communication.Rcmp.RcmpUnlockSecurity rcmpUnlockSecurity = new global::Motorola.Common.Communication.Rcmp.RcmpUnlockSecurity(radioKey);
			this.msgExecutor.SendAndReceiveMessage(rcmpUnlockSecurity);
			if (rcmpUnlockSecurity.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SecurityUnlockFailure);
			}
			if (partition > 0 && partition < 255)
			{
				global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition rcmpIshUnlockPartition = new global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition(partition);
				this.msgExecutor.SendAndReceiveMessage(rcmpIshUnlockPartition);
				if (rcmpIshUnlockPartition.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ISHUnlockFailure);
				}
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00007DF8 File Offset: 0x00005FF8
		public void UpdateSerialNumber(string serialNumber)
		{
			if (this.DeviceInfoFetcher.GetDeviceInfo<bool>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.IsLowBattery))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_BatteryLevelLow);
			}
			string modelNumber = this.ReadDeviceInfo().ModelNumber;
			global::Motorola.Common.Communication.SequenceManager.DeviceType deviceType = this.ProductFamily.GetDeviceType(modelNumber);
			bool flag = deviceType == global::Motorola.Common.Communication.SequenceManager.DeviceType.BanditRepeater || deviceType == global::Motorola.Common.Communication.SequenceManager.DeviceType.Repeater;
			if (this.ProductFamily.IsBahamaModel(this.ProductFamily.UUID))
			{
				flag = false;
			}
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(serialNumber + '\0');
			global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe nlcommPipe = this.msgExecutor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe;
			if (nlcommPipe != null)
			{
				if (nlcommPipe.IsDualBoard())
				{
					nlcommPipe.SetTargetBoard(global::Motorola.Common.Communication.TargetBoard.XnlTargetRX);
					try
					{
						this.UnlockRadioPartition(129);
						base.IOController.UpdateProductSerialNumber(bytes);
					}
					finally
					{
						nlcommPipe.SetTargetBoard(global::Motorola.Common.Communication.TargetBoard.XnlTargetTX);
					}
				}
			}
			this.UnlockRadioPartition(129);
			if (flag)
			{
				base.IOController.UpdateProductSerialNumber(bytes);
			}
			else
			{
				base.IOController.UpdateSerialNumber(bytes);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007F3C File Offset: 0x0000613C
		public byte[] ReadUnkillChallengeValue()
		{
			return base.IOController.ReadUnkillChallengeValue();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00007F59 File Offset: 0x00006159
		public void UnkillRadio(byte[] authenticationValue)
		{
			base.IOController.UnkillRadio(authenticationValue);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00007F69 File Offset: 0x00006169
		public void UpdateIMEType(byte ime)
		{
			base.IOController.EnterTestMode();
			base.IOController.UpdateIMEType(ime);
			base.IOController.ResetRadio();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007F94 File Offset: 0x00006194
		public void UpdateDateCode(byte[] datecode, ushort source)
		{
			global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe nlcommPipe = this.msgExecutor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe;
			if (nlcommPipe != null)
			{
				if (nlcommPipe.IsDualBoard())
				{
					nlcommPipe.SetTargetBoard(global::Motorola.Common.Communication.TargetBoard.XnlTargetRX);
					try
					{
						this.UnlockRadioPartition(128);
						base.IOController.UpdateDateCode(datecode, source);
					}
					finally
					{
						nlcommPipe.SetTargetBoard(global::Motorola.Common.Communication.TargetBoard.XnlTargetTX);
					}
				}
			}
			this.UnlockRadioPartition(128);
			base.IOController.UpdateDateCode(datecode, source);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00008028 File Offset: 0x00006228
		public void CBIProgramme()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00008030 File Offset: 0x00006230
		protected override void UpdateMaxDataTransferSize()
		{
			if (this.IsParadiseOrLightFamilies(this.ProductFamily.Family))
			{
				if (string.Compare(this.DeviceInfoFetcher.CodeplugVersion, "020000", global::System.StringComparison.OrdinalIgnoreCase) < 0)
				{
					base.IOController.MaxDataTransferSize = 968;
				}
				else
				{
					base.IOController.MaxDataTransferSize = 1446;
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000080A0 File Offset: 0x000062A0
		protected virtual void ReadBasicInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			deviceInfo.Family = this.DeviceInfoFetcher.ProductFamily;
			deviceInfo.ModelNumber = this.DeviceInfoFetcher.ModelNumber;
			deviceInfo.SerialNumber = this.DeviceInfoFetcher.GetDeviceInfo<string>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.SerialNumber);
			deviceInfo.CodeplugVersion = this.DeviceInfoFetcher.CodeplugVersion;
			string text = base.IOController.QuerySoftwareVersion();
			char[] trimChars = new char[1];
			deviceInfo.SoftwareVersion = text.TrimEnd(trimChars);
			this.CheckSecurityCapability(deviceInfo);
			deviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00008128 File Offset: 0x00006328
		protected void CheckSecurityCapability(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			try
			{
				deviceInfo.SecurityCapability = base.IOController.QuerySecurityCapability();
			}
			catch
			{
			}
			if (deviceInfo.SecurityCapability == 2)
			{
				deviceInfo.secureConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.SecureConnectionInfo();
				deviceInfo.secureConnectionInfo = base.IOController.QueryIPandPort();
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00008194 File Offset: 0x00006394
		private bool IsBanditNotRxOnlyAndEEPRomCorrupted()
		{
			string modelNumber = this.ReadDeviceInfo().ModelNumber;
			global::Motorola.Common.Communication.SequenceManager.DeviceType deviceType = this.ProductFamily.GetDeviceType(modelNumber);
			bool result;
			if (deviceType != global::Motorola.Common.Communication.SequenceManager.DeviceType.BanditRepeater)
			{
				result = false;
			}
			else
			{
				byte b = base.IOController.QueryBanditEEPROMByIsh(128, 110, 0, 1, 106)[0];
				if ((b & 32) != 0)
				{
					result = false;
				}
				else
				{
					byte[] b2 = base.IOController.QueryBanditEEPROMByIsh(129, 4112, 0, 4, 40);
					byte[] b3 = base.IOController.QueryBanditEEPROMByIsh(129, 4112, 0, 4, 44);
					byte[] b4 = base.IOController.QueryBanditEEPROMByIsh(129, 4112, 0, 4, 116);
					byte[] b5 = base.IOController.QueryBanditEEPROMByIsh(129, 4112, 0, 4, 120);
					byte[] b6 = base.IOController.QueryBanditEEPROMByIsh(129, 4112, 0, 4, 124);
					byte[] b7 = base.IOController.QueryBanditEEPROMByIsh(129, 4112, 0, 4, 128);
					byte[] b8 = base.IOController.QueryBanditEEPROMByIsh(129, 4112, 0, 4, 132);
					byte[] b9 = base.IOController.QueryBanditEEPROMByIsh(129, 4112, 0, 4, 136);
					byte[] b10 = base.IOController.QueryBanditEEPROMByIsh(129, 4112, 0, 2, 74);
					byte[] b11 = base.IOController.QueryBanditEEPROMByIsh(129, 4112, 0, 2, 76);
					byte[] b12 = base.IOController.QueryBanditEEPROMByIsh(129, 4112, 0, 2, 110);
					byte[] b13 = base.IOController.QueryBanditEEPROMByIsh(129, 4112, 0, 2, 112);
					result = (this.FourFieldsEqualsInByte(b2, b3, b4, b5) || this.FourFieldsEqualsInByte(b6, b7, b8, b9) || this.FourFieldsEqualsInByte(b10, b11, b12, b13));
				}
			}
			return result;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00008384 File Offset: 0x00006584
		private bool FourFieldsEqualsInByte(byte[] b1, byte[] b2, byte[] b3, byte[] b4)
		{
			return b1.SequenceEqual(b2) && b1.SequenceEqual(b3) && b1.SequenceEqual(b4);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000083B4 File Offset: 0x000065B4
		protected virtual void ReadExtendedDeviceInfo(global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo deviceInfo)
		{
			deviceInfo.UUID = this.ProductFamily.UUID;
			string text = base.IOController.QueryPsdtVersion();
			char[] trimChars = new char[1];
			deviceInfo.PsdtVersion = text.TrimEnd(trimChars);
			deviceInfo.BootloaderVersion = this.DeviceInfoFetcher.GetDeviceInfo<string>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.BootloaderVersion);
			deviceInfo.KernelVersion = this.DeviceInfoFetcher.GetDeviceInfo<string>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.KernelVersion);
			deviceInfo.ConfigurationVersion = this.DeviceInfoFetcher.GetDeviceInfo<string>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.ConfigurationVersion);
			deviceInfo.AvailableMemory = this.DeviceInfoFetcher.GetDeviceInfo<int>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.AvailableMemory);
			deviceInfo.AvailableLPSpace = this.DeviceInfoFetcher.GetDeviceInfo<int>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.AvailableLPSpace);
			deviceInfo.Is32MPlatform = this.DeviceInfoFetcher.GetDeviceInfo<bool>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.Is32MPlatform);
			deviceInfo.MacAddress = this.DeviceInfoFetcher.GetDeviceInfo<string>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.MacAddress);
			deviceInfo.MacAddressPort1 = this.DeviceInfoFetcher.GetDeviceInfo<string>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.MacAddressPort1);
			deviceInfo.MacAddressPort2 = string.Empty;
			deviceInfo.MacAddressWIFIPort1 = string.Empty;
			deviceInfo.MacAddressWIFIPort2 = string.Empty;
			deviceInfo.TanapaNumber = base.IOController.QueryRadioTanapaNumberByIsh(129, 4112, 0, 10, 64);
			if (this.IsBanditNotRxOnlyAndEEPRomCorrupted())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_EEPROM_CORRUPT);
			}
			if (this.DeviceInfoFetcher.IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.DTPCapability))
			{
				try
				{
					deviceInfo.IsDTPEnabled = this.DeviceInfoFetcher.GetDeviceInfo<bool>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.DTPCapability);
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.InvalidRCMPParameter && ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.QueryVersionInfoFailure)
					{
						throw;
					}
				}
			}
			else
			{
				deviceInfo.IsDTPEnabled = true;
			}
			deviceInfo.FpgaInfo = this.DeviceInfoFetcher.GetDeviceInfo<global::Motorola.Common.Communication.CommonUtil.FpgaInfo>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.FpgaInfo);
			if (this.DeviceInfoFetcher.IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.DSPCapability))
			{
				deviceInfo.IsDSPEnabled = this.DeviceInfoFetcher.GetDeviceInfo<bool>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.DSPCapability);
			}
			else
			{
				deviceInfo.IsDSPEnabled = true;
			}
			if (this.DeviceInfoFetcher.IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.Region))
			{
				deviceInfo.Region = this.DeviceInfoFetcher.GetDeviceInfo<byte>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.Region);
			}
			else
			{
				deviceInfo.Region = base.IOController.QueryRadioRegionByIsh(129, 4112, 0, 78);
			}
			try
			{
				deviceInfo.L3BootloaderVersion = this.DeviceInfoFetcher.GetDeviceInfo<string>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.L3BootloaderVersion);
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Query L3 Bootloader version failed.", new object[0]);
				if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.InvalidRCMPParameter)
				{
					throw;
				}
			}
			this.ReadPasswordStatus(deviceInfo);
			global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe nlcommPipe = this.msgExecutor.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.NLCommPipe;
			if (nlcommPipe != null)
			{
				deviceInfo.IsDualBoard = nlcommPipe.IsDualBoard();
				if (deviceInfo.IsDualBoard)
				{
					nlcommPipe.SetTargetBoard(global::Motorola.Common.Communication.TargetBoard.XnlTargetRX);
					try
					{
						deviceInfo.RemoteSerialNumber = this.DeviceInfoFetcher.GetDeviceInfo<string>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.SerialNumber);
						deviceInfo.BrickRXSerialNumber = this.DeviceInfoFetcher.GetDeviceInfo<string>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.BrickRXSerialNumber);
					}
					finally
					{
						nlcommPipe.SetTargetBoard(global::Motorola.Common.Communication.TargetBoard.XnlTargetTX);
					}
				}
			}
			if (this.DeviceInfoFetcher.IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.PhysicalSerialNumber))
			{
				deviceInfo.PhysicalSerialNumber = this.DeviceInfoFetcher.GetDeviceInfo<string>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.PhysicalSerialNumber);
			}
			else
			{
				deviceInfo.PhysicalSerialNumber = null;
			}
			if (this.DeviceInfoFetcher.IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.PhysicalSerialNumber))
			{
				deviceInfo.PhysicalSerialNumber = this.DeviceInfoFetcher.GetDeviceInfo<string>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.PhysicalSerialNumber);
			}
			else
			{
				deviceInfo.PhysicalSerialNumber = null;
			}
			if (this.DeviceInfoFetcher.IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.BrickTXSerialNumber))
			{
				deviceInfo.BrickTXSerialNumber = this.DeviceInfoFetcher.GetDeviceInfo<string>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.BrickTXSerialNumber);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000875C File Offset: 0x0000695C
		protected void ReadPasswordStatus(global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo deviceInfo)
		{
			try
			{
				if (this.DeviceInfoFetcher.IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.PasswordStatus))
				{
					deviceInfo.PasswordStatus = this.DeviceInfoFetcher.GetDeviceInfo<global::Motorola.Common.Communication.CommonUtil.PasswordStatus>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.PasswordStatus);
				}
				else
				{
					deviceInfo.PasswordStatus = new global::Motorola.Common.Communication.CommonUtil.PasswordStatus();
					deviceInfo.PasswordStatus.Policy = global::Motorola.Common.Communication.CommonUtil.PasswordPolicy.NA;
				}
			}
			catch (global::System.Exception systemException)
			{
				string strA = deviceInfo.CodeplugVersion.Substring(0, 6);
				if (deviceInfo.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio || string.Compare(strA, "060000", global::System.StringComparison.OrdinalIgnoreCase) < 0 || string.Compare(strA, "060106", global::System.StringComparison.OrdinalIgnoreCase) > 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_PasswordRetrievalFail, systemException);
				}
				deviceInfo.PasswordStatus = new global::Motorola.Common.Communication.CommonUtil.PasswordStatus();
				deviceInfo.PasswordStatus.Policy = global::Motorola.Common.Communication.CommonUtil.PasswordPolicy.NA;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00008838 File Offset: 0x00006A38
		private void DeleteIshItems(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, global::System.Collections.Generic.List<byte> partitions, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			int count = partitions.Count;
			double num = 1.0 / (double)count;
			foreach (byte partition in partitions)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaderList;
				if (this.ProductFamily.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.PhoenixRadio)
				{
					ishHeaderList = this.GetIshItemsToDeleteForPhoenix(pbaObject, partition, new global::Motorola.Common.Communication.IteratedProgressIndicator(subProgress, num * 0.7));
				}
				else
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishTypeIDPariSetInRadio = this.IshHandler.ReadIshTypeIdPairSet(partition, new global::Motorola.Common.Communication.IteratedProgressIndicator(subProgress, num * 0.7));
					ishHeaderList = this.GetIshItemsToDelete(pbaObject, ishTypeIDPariSetInRadio);
				}
				this.IshHandler.DeleteIshItem(ishHeaderList, new global::Motorola.Common.Communication.IteratedProgressIndicator(subProgress, num * 0.3));
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00008924 File Offset: 0x00006B24
		private global::Motorola.Common.Communication.CommonUtil.IshItemCollection FilterIshItemsToWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, global::System.Collections.Generic.List<byte> WritePartitions = null)
		{
			if (WritePartitions == null)
			{
				WritePartitions = this.ProductFamily.WritePartitions;
			}
			global::Motorola.Common.Communication.IshHandler.IshItemsWriteFilter ishItemsWriteFilter = new global::Motorola.Common.Communication.IshHandler.IshItemsWriteFilter(WritePartitions, pbaObject.InterestTypes);
			return ishItemsWriteFilter.GetCollectionToWrite(pbaObject);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00008968 File Offset: 0x00006B68
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> GetIshItemsToDeleteForPhoenix(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, byte partition, global::Motorola.Common.Communication.IProgressIndicator subProgress)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType> deletableTypes = pbaObject.DeletableTypes;
			global::System.Collections.Generic.List<ushort> list = this.IshHandler.ReadIshTypeSet(partition);
			global::System.Collections.Generic.List<ushort> list2 = new global::System.Collections.Generic.List<ushort>();
			foreach (ushort num in list)
			{
				if (deletableTypes.Contains(new global::Motorola.Common.Communication.Pba.DataBlockType(partition, num)))
				{
					list2.Add(num);
				}
			}
			return this.IshHandler.BundleReadIshTypeIdPairSet(partition, list2, subProgress, null);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00008A0C File Offset: 0x00006C0C
		protected global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> GetIshItemsToDelete(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishTypeIDPariSetInRadio)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType> deletableTypes = pbaObject.DeletableTypes;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType> iddeletableTypes = pbaObject.IDDeletableTypes;
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaObject.GetCodeplugInIshItemCollection();
			global::System.Collections.Generic.List<ushort> ishTypeList = codeplugInIshItemCollection.GetIshTypeList();
			global::System.Collections.Generic.ICollection<global::Motorola.Common.Communication.CommonUtil.IshHeader> headers = codeplugInIshItemCollection.Headers;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
			foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader item in ishTypeIDPariSetInRadio)
			{
				if (!ishTypeList.Contains(item.IshType))
				{
					if (deletableTypes.Contains(new global::Motorola.Common.Communication.Pba.DataBlockType(item.PartitionNumber, item.IshType)))
					{
						list.Add(item);
					}
				}
				else if (!headers.Contains(item) && iddeletableTypes.Contains(new global::Motorola.Common.Communication.Pba.DataBlockType(item.PartitionNumber, item.IshType)))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00008B1C File Offset: 0x00006D1C
		internal global::Motorola.Common.Communication.SequenceManager.PcrProductFamily ProductFamily
		{
			get
			{
				if (this.productFamilyCache == null)
				{
					string uuid = global::System.BitConverter.ToString(base.IOController.QueryRadioUUID()).Replace("-", string.Empty);
					this.productFamilyCache = global::Motorola.Common.Communication.SequenceManager.PcrProductFamily.GetPcrProductFamily(uuid);
				}
				return this.productFamilyCache;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00008B74 File Offset: 0x00006D74
		internal global::Motorola.Common.Communication.SequenceManager.DeviceInfoFetcher DeviceInfoFetcher
		{
			get
			{
				if (this.deviceInfoFetcherCache == null)
				{
					this.deviceInfoFetcherCache = new global::Motorola.Common.Communication.SequenceManager.DeviceInfoFetcher(base.IOController, this.ProductFamily);
				}
				return this.deviceInfoFetcherCache;
			}
		}

		// Token: 0x04000096 RID: 150
		private global::Motorola.Common.Communication.IshHandler.CommonIshHandler _IshHandler;

		// Token: 0x04000097 RID: 151
		internal global::Motorola.Common.Communication.SequenceManager.PcrProductFamily productFamilyCache = null;

		// Token: 0x04000098 RID: 152
		internal global::Motorola.Common.Communication.SequenceManager.DeviceInfoFetcher deviceInfoFetcherCache = null;

		// Token: 0x04000099 RID: 153
		internal global::fxpcommunication.FxpCommunication featureEnable = null;

		// Token: 0x0400009A RID: 154
		private global::Motorola.Common.Communication.IMessageExecutor msgExecutor;
	}
}
