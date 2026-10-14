using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.Compression;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.FDT;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200000E RID: 14
	public abstract class TetraBaseSbepSeqManager : global::Motorola.Common.Communication.ICpsSequenceManager, global::Motorola.Common.Communication.IFlashSequenceManager, global::Motorola.Common.Communication.IDepotSequenceManager, global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation, global::System.IDisposable
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00003DB4 File Offset: 0x00001FB4
		public TetraBaseSbepSeqManager()
		{
			this._radioResetEvent = new global::System.Threading.AutoResetEvent(false);
			this._disposed = false;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003E90 File Offset: 0x00002090
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003E97 File Offset: 0x00002097
		public byte QueryRadioUpdateStatus()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00003EA0 File Offset: 0x000020A0
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00003EE4 File Offset: 0x000020E4
		public global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile RadioProfile
		{
			get
			{
				global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile radioProfile;
				lock (this._propertyAccessLock)
				{
					radioProfile = this._radioProfile;
				}
				return radioProfile;
			}
			set
			{
				lock (this._propertyAccessLock)
				{
					this._radioProfile = value;
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00003F28 File Offset: 0x00002128
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Transport
		{
			get
			{
				return this._transport;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003F30 File Offset: 0x00002130
		public virtual bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			return true;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00003F33 File Offset: 0x00002133
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00003F3B File Offset: 0x0000213B
		public global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator
		{
			get
			{
				return this._progressIndicator;
			}
			set
			{
				this._progressIndicator = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003F44 File Offset: 0x00002144
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00003F4C File Offset: 0x0000214C
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00003F55 File Offset: 0x00002155
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00003F5D File Offset: 0x0000215D
		public bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x06000078 RID: 120 RVA: 0x00003F66 File Offset: 0x00002166
		public void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			this._bCancelIO = false;
			this._transport.OpenPort();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003F7B File Offset: 0x0000217B
		public void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			this._bCancelIO = true;
			this._transport.ClosePort();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003F8F File Offset: 0x0000218F
		public virtual bool DifferentialWriteSupported(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			return false;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003F94 File Offset: 0x00002194
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			byte[] array = null;
			if (global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.IsRadioSupportFP(this.ComposeCommonModelNumber(this.ModelNumber, this.HomeMCC), this.CodeplugVersion) && this.PartionHealthState == 0)
			{
				array = this.ReadRadioLLP();
			}
			if (array != null)
			{
				pbaObject.SetLlp(array);
			}
			this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> codeplug = this.ReadCodeplug();
			pbaObject.SetCodeplug(codeplug);
			this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
			return pbaObject;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004010 File Offset: 0x00002210
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			this._forceWrite = false;
			string text = null;
			if (writePBA.UpdateData.MemoryImages.Count > 0)
			{
				string text2 = null;
				string text3 = null;
				foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in writePBA.UpdateData.MemoryImages)
				{
					if (radioImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TARGET_VERSION)
					{
						global::Motorola.Common.Communication.Pba.TetraMemoryImage tetraMemoryImage = radioImage as global::Motorola.Common.Communication.Pba.TetraMemoryImage;
						if (tetraMemoryImage != null)
						{
							if (tetraMemoryImage.ForceWrite)
							{
								text2 = tetraMemoryImage.TargetModelNumber;
								text = tetraMemoryImage.TargetSerialNumber;
								text3 = tetraMemoryImage.TargetCPVersion;
							}
							else
							{
								text = tetraMemoryImage.TargetSerialNumber;
							}
							this._forceWrite = tetraMemoryImage.ForceWrite;
						}
					}
				}
				if (this._forceWrite)
				{
					if (string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text3))
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Upgrade input parameter are empty");
					}
					this._recoverModelNumbel = text2;
					this._recoverCPversion = text3;
					this._recoverSerialNumber = text;
				}
			}
			global::Motorola.Common.Communication.Pba.PbaObject result = null;
			try
			{
				result = this.doWriteDevice(writePBA, text, 0, 100, true);
			}
			finally
			{
				this._forceWrite = false;
			}
			return result;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004148 File Offset: 0x00002348
		public virtual global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			this.ConstructDeviceInfo();
			return this._devInfo.Clone() as global::Motorola.Common.Communication.CommonUtil.DeviceInfo;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004160 File Offset: 0x00002360
		public void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			string text = "TetraBaseSbepSeqManager.SwitchMode";
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Enter TetraBaseSbepSeqManager.SwitchMode()");
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "USB Location is " + this.Profile.PhysicalLocation);
			try
			{
				text = string.Format("TetraBaseSbepSeqManager.SwitchMode from mode {0} to mode {1}", this.Profile.DeviceMode, mode);
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel(text);
				global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.DeviceAttached += this.Instance_DeviceChanged;
				this._radioResetEvent.Reset();
				global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode = this.Profile.DeviceMode;
				if (deviceMode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
				}
				this.DoResetProgramRadio(mode);
				if (mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.RP)
				{
					this.WaitForRadioReset();
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic exception", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.DeviceAttached -= this.Instance_DeviceChanged;
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance(text, "");
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Leave TetraBaseSbepSeqManager.SwitchMode()");
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "USB Location is " + this.Profile.PhysicalLocation);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004368 File Offset: 0x00002568
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			this.ConstructDeviceInfo();
			return this._devInfo.Clone() as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004380 File Offset: 0x00002580
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004388 File Offset: 0x00002588
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			if (this.PartionHealthState == 0)
			{
				this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingLLP);
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = null;
				this.ReadRadioLPHeader(out list);
				this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadLLPDone);
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(list, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader pack in list)
				{
					global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo tetraLanguagePackInfo = new global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo();
					tetraLanguagePackInfo.Initialize(pack);
					languagePackData.LanguagePacks.Add(tetraLanguagePackInfo);
				}
			}
			return languagePackData;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000442C File Offset: 0x0000262C
		public void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(langPackData, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			string swPath = null;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in langPackData.LanguagePacks)
			{
				global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo tetraLanguagePackInfo = (global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo)languagePackBase;
				if (tetraLanguagePackInfo != null)
				{
					list.Add(new global::Motorola.Common.Communication.CommonUtil.PackHeader
					{
						compareID = (uint)global::System.Convert.ToInt32(tetraLanguagePackInfo.PackID, global::System.Globalization.CultureInfo.InvariantCulture),
						type = tetraLanguagePackInfo.PackType,
						imageName = tetraLanguagePackInfo.PackFilePath
					});
					swPath = tetraLanguagePackInfo.sourceFilePath;
				}
			}
			global::Motorola.Common.Communication.FDT.FDTParams fdtparams = new global::Motorola.Common.Communication.FDT.FDTParams();
			if (!this._forceWrite)
			{
				this.WriteRadioLP(list, swPath, null, 0, 100, true);
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel(this._recoverModelNumbel);
			if (model == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "model type is null!");
			}
			fdtparams.cpVersion = this._recoverCPversion;
			fdtparams.modelType = (ushort)global::System.Convert.ToUInt32(model.ModelType);
			fdtparams.uniqueModelNumber = this._recoverModelNumbel;
			fdtparams.serialNumber = this._recoverSerialNumber;
			this.WriteRadioLP(list, swPath, fdtparams, 0, 100, true);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004568 File Offset: 0x00002768
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000456F File Offset: 0x0000276F
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004576 File Offset: 0x00002776
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000457D File Offset: 0x0000277D
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004584 File Offset: 0x00002784
		public void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000458B File Offset: 0x0000278B
		public void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004592 File Offset: 0x00002792
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004599 File Offset: 0x00002799
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000045A0 File Offset: 0x000027A0
		public void UpdateMACAddress(byte[] macAddress)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600008C RID: 140
		public abstract void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID);

		// Token: 0x0600008D RID: 141 RVA: 0x000045A7 File Offset: 0x000027A7
		public void ValidateUpdate()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000045AE File Offset: 0x000027AE
		public bool WriteRamdownloader(string filepath)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000045B5 File Offset: 0x000027B5
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000045BC File Offset: 0x000027BC
		public void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000045C3 File Offset: 0x000027C3
		public void UpdateSerialNumber(string serialNumber)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000045CA File Offset: 0x000027CA
		public void UnkillRadio(byte[] authenticationValue)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000045D1 File Offset: 0x000027D1
		public byte[] ReadUnkillChallengeValue()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000045D8 File Offset: 0x000027D8
		public void CBIProgramme()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000045E0 File Offset: 0x000027E0
		public void SwitchModeNoWait(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			string text = "TetraBaseSbepSeqManager.SwitchModeNoWait";
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Enter TetraBaseSbepSeqManager.SwitchMode()");
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "USB Location is " + this.Profile.PhysicalLocation);
			try
			{
				text = string.Format("TetraBaseSbepSeqManager.SwitchModeNoWait from mode {0} to mode {1}", this.RadioProfile.DeviceMode, mode);
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel(text);
				global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode = this.RadioProfile.DeviceMode;
				if (deviceMode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
				}
				this.DoResetProgramRadio(mode);
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance(text, "");
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Leave TetraBaseSbepSeqManager.SwitchMode()");
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "USB Location is " + this.Profile.PhysicalLocation);
			}
		}

		// Token: 0x06000096 RID: 150
		public abstract void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode commandCode, byte[] inputBuffer, out byte[] outputBuffer);

		// Token: 0x06000097 RID: 151
		public abstract void WriteSoftware(string swFilePath, bool bResetProgress = true);

		// Token: 0x06000098 RID: 152 RVA: 0x00004750 File Offset: 0x00002950
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks()
		{
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			if (this.PartionHealthState == 0)
			{
				this.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingLLP);
				global::Motorola.Common.Communication.CommonUtil.fp_version_t[] array = null;
				this.GetFPVersion(out array);
				this.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadLLPDone);
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(array, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				foreach (global::Motorola.Common.Communication.CommonUtil.fp_version_t fp_version_t in array)
				{
					global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo tetraLanguagePackInfo = new global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo();
					tetraLanguagePackInfo.PackType = (global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t)fp_version_t.pack_type;
					tetraLanguagePackInfo.ProductPlatform = (int)fp_version_t.fp_product_platform;
					tetraLanguagePackInfo.ReleaseNumber = (int)fp_version_t.fp_release_num;
					tetraLanguagePackInfo.Revision = (int)fp_version_t.fp_revision_num;
					tetraLanguagePackInfo.SubRevision = (int)fp_version_t.fp_sub_revision_num;
					languagePackData.LanguagePacks.Add(tetraLanguagePackInfo);
				}
			}
			return languagePackData;
		}

		// Token: 0x06000099 RID: 153
		public abstract byte[] ReadCPData(string blockID, uint offset, ushort size);

		// Token: 0x0600009A RID: 154
		public abstract bool IsLLPAvailable();

		// Token: 0x0600009B RID: 155 RVA: 0x00004808 File Offset: 0x00002A08
		public virtual bool TurnOffRadio()
		{
			bool result;
			try
			{
				if (!(this.Transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).Reliable)
				{
					(this.Transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).WriteTimeout = 3000;
					(this.Transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).ReadTimeout = 3000;
				}
				result = this.DoTurnOffRadio();
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic Exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			return result;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000048CC File Offset: 0x00002ACC
		public virtual void UpgradeFlashStrap(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool bResetProgress = true)
		{
			if (!this._forceWrite)
			{
				this.UpdateFlashstrap(this.ModelType, this.CodeplugVersion, pbaObject.FlashStrapPath, bResetProgress);
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel(this._recoverModelNumbel);
			if (model != null)
			{
				string recoverCPversion = this._recoverCPversion;
				this.UpdateFlashstrap((ushort)model.ModelType, recoverCPversion, pbaObject.FlashStrapPath, bResetProgress);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004958 File Offset: 0x00002B58
		public virtual void EraseRadioFromTo(uint startAddress, uint size, bool bForceErase = false)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraPhysicalAddressSeqMgr.EraseFromTo");
			try
			{
				this.RetryMethod(delegate
				{
					this.DoEraseFlash(startAddress.ToString(global::System.Globalization.CultureInfo.InvariantCulture), size, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
				});
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("AbsCOMPortRadio.EraseFromTo", "");
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004A64 File Offset: 0x00002C64
		public virtual global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageWithProgressUpdate(string address, uint size)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseSbepSeqManager.ReadImage");
			global::Motorola.Common.Communication.CommonUtil.MemoryImage result;
			try
			{
				this.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
				global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.ReadImage(address, size, true);
				this.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
				result = memoryImage;
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraBaseSbeqSeqManager.ReadImage", "");
			}
			return result;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004CB4 File Offset: 0x00002EB4
		public virtual void WriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage, bool bResetProgress = false)
		{
			this.RetryMethod(delegate
			{
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseSbepSeqManager.WriteImage");
				try
				{
					if (bResetProgress)
					{
						this.ResetProgress();
					}
					this.DoEraseImage(image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
					this.DoWriteImage(image, this._devInfo.UseCompress, true, status);
				}
				catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
					{
						ex
					});
					throw;
				}
				catch (global::System.Exception ex2)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic exception", new object[0]);
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
				}
				finally
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraBaseSbepSeqManager.WriteImage", "");
				}
			});
		}

		// Token: 0x060000A0 RID: 160
		public abstract global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType);

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004CF8 File Offset: 0x00002EF8
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00004EC0 File Offset: 0x000030C0
		public virtual string CpuID
		{
			get
			{
				string cpuID;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (string.IsNullOrEmpty(this._devInfo.CpuID))
						{
							byte[] array = this.DoGetCpuID();
							if (this.RadioProfile.TetraRadioType != global::Motorola.Common.Communication.CommonUtil.TetraRadioType.CONTROL_HEAD)
							{
								global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
								foreach (byte b in array)
								{
									stringBuilder.AppendFormat("{0:X2}", b);
								}
								this._devInfo.CpuID = stringBuilder.ToString();
							}
							else
							{
								global::System.Array.Reverse(array);
								uint num = global::System.BitConverter.ToUInt32(array, 4);
								uint num2 = global::System.BitConverter.ToUInt32(array, 0);
								global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
								stringBuilder2.AppendFormat("{0:X8}", (524287U & num) | (4294443008U & num) >> 1);
								stringBuilder2.AppendFormat("{0:X8}", num2);
								this._devInfo.CpuID = stringBuilder2.ToString();
							}
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
						this._devInfo.CpuID = string.Empty;
					}
					catch (global::System.Exception e)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, this.RadioProfile.Path, "Generic Error", new object[0]);
						this._devInfo.CpuID = string.Empty;
					}
					cpuID = this._devInfo.CpuID;
				}
				return cpuID;
			}
			set
			{
				lock (this._propertyAccessLock)
				{
					this._devInfo.CpuID = value;
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004F08 File Offset: 0x00003108
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00004F4C File Offset: 0x0000314C
		public virtual global::Motorola.Common.Communication.IRadioProfile Profile
		{
			get
			{
				global::Motorola.Common.Communication.IRadioProfile radioProfile;
				lock (this._propertyAccessLock)
				{
					radioProfile = this._radioProfile;
				}
				return radioProfile;
			}
			set
			{
				lock (this._propertyAccessLock)
				{
					this._radioProfile = (value as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile);
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004F94 File Offset: 0x00003194
		public virtual void Invalidate(bool onlyCPInfo)
		{
			lock (this._propertyAccessLock)
			{
				if (!onlyCPInfo)
				{
					this._devInfo.HwID = 0U;
					this._devInfo.CpuID = string.Empty;
					this._devInfo.ARP = null;
				}
				this._devInfo.TEI = string.Empty;
				this._devInfo.ModelNumber = string.Empty;
				this._devInfo.SerialNumber = string.Empty;
				this._devInfo.Issi = -1;
				this._devInfo.HomeMCC = -1;
				this._devInfo.HomeMNC = -1;
				this._devInfo.CodeplugVersion = string.Empty;
				this._devInfo.SoftwareVersion = string.Empty;
				this._devInfo.PartionHealthState = -1;
				this._devInfo.RpVerInfo = null;
				this._rootBlockCache = null;
				this._rootBlockIsBad = false;
				this._byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.UnInitialized;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00005120 File Offset: 0x00003320
		public virtual void EraseRadio(global::System.Collections.Generic.List<string> sections)
		{
			try
			{
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraPhysicalAddressSeqMgr.EraseRadio");
				if (sections == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "no flash section");
				}
				this.RetryMethod(delegate
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit> flashRegionSet = this.GetFlashRegionSet(sections);
					foreach (global::Motorola.Common.Communication.TetraUtility.MemMapUnit memMapUnit in flashRegionSet)
					{
						this.DoEraseFlash(memMapUnit.Address.ToString(), memMapUnit.Size, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
					}
				});
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic exception", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraPhysicalAddressSeqMgr.EraseRadio", "");
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005250 File Offset: 0x00003450
		public virtual void WaitForCancelReading()
		{
			this.CloseSession(0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any, true);
			this.CancelSignal.WaitOne(3000);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00005274 File Offset: 0x00003474
		protected void DoBeginReadImage(bool useCompress)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPSetMemoryType sbepsetMemoryType = new global::Motorola.Common.Communication.SBEPSetMemoryType(this._transport, global::Motorola.Common.Communication.MEMORY_TYPE.MT_FLASH);
				sbepsetMemoryType.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepsetMemoryType.OperationResult);
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPCompressReadData sbepcompressReadData = new global::Motorola.Common.Communication.SBEPCompressReadData(this._transport, useCompress);
				sbepcompressReadData.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepcompressReadData.OperationResult);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000052D8 File Offset: 0x000034D8
		protected void DoEndReadImage(bool useCompress)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			global::Motorola.Common.Communication.SBEPSetMemoryType sbepsetMemoryType = new global::Motorola.Common.Communication.SBEPSetMemoryType(this._transport, global::Motorola.Common.Communication.MEMORY_TYPE.MT_DEFAULT);
			sbepsetMemoryType.ExecuteMessage();
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepsetMemoryType.OperationResult);
			}
			if (useCompress)
			{
				global::Motorola.Common.Communication.SBEPCompressReadData sbepcompressReadData = new global::Motorola.Common.Communication.SBEPCompressReadData(this._transport, false);
				sbepcompressReadData.ExecuteMessage();
				if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepcompressReadData.OperationResult);
				}
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in EndReadImage()");
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005380 File Offset: 0x00003580
		protected global::Motorola.Common.Communication.CommonUtil.MemoryImage DoFastReadImage(string address, uint size, bool useCompress, bool bUpdateProgress, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && (string.IsNullOrEmpty(address) || size == 0U || this._transport == null))
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			double currentProgress = this.CurrentProgress;
			if (bUpdateProgress)
			{
				this.IncreaseProgress(0.0, status);
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				uint num = size;
				uint num2 = global::System.Convert.ToUInt32(address);
				double num3 = num / global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE;
				bool flag = true;
				bool flag2 = num >= global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE;
				while (num > 0U)
				{
					if (this._bCancelIO)
					{
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0018_RH_CommErrIOCanceled;
						this.CancelSignal.Set();
						break;
					}
					uint num4 = (num > global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE) ? global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE : num;
					bool flag3 = false;
					if (flag)
					{
						flag3 = true;
						flag = false;
					}
					if (num4 != global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE)
					{
						flag3 = true;
					}
					if (flag3)
					{
						global::Motorola.Common.Communication.SBEPSetReadDataSize sbepsetReadDataSize = new global::Motorola.Common.Communication.SBEPSetReadDataSize(this._transport, (ushort)num4);
						sbepsetReadDataSize.ExecuteMessage();
						commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepsetReadDataSize.OperationResult);
						if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
						{
							break;
						}
					}
					global::Motorola.Common.Communication.SBEPReadData sbepreadData = new global::Motorola.Common.Communication.SBEPReadData(this._transport, num2, (ushort)num4);
					sbepreadData.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepreadData.OperationResult);
					if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
					{
						break;
					}
					if (sbepreadData.ReceivedData.Length == 0)
					{
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0021_RH_CommErrReadZeroLengthData;
						break;
					}
					uint num5 = (uint)sbepreadData.ReceivedData.Length;
					if (useCompress)
					{
						byte[] array = new byte[num4];
						global::Motorola.Common.Communication.Compression.FastLZWrapper.DataDecompress(sbepreadData.ReceivedData, array, ref num5);
						global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
						flashMemoryUnit.ChargeUnit(num2.ToString(), array, 0, 1U);
						memoryImage.AddItem(flashMemoryUnit);
					}
					else
					{
						global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit2 = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
						flashMemoryUnit2.ChargeUnit(num2.ToString(), sbepreadData.ReceivedData, 0, 1U);
						memoryImage.AddItem(flashMemoryUnit2);
					}
					if (num5 != num4)
					{
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0002_RH_CommErrDataSize;
						break;
					}
					num2 += num5;
					num -= num5;
					if (flag2 && bUpdateProgress)
					{
						this.IncreaseProgress(1.0 / num3, status);
					}
				}
			}
			if (status == global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP && bUpdateProgress)
			{
				this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
			}
			else if (bUpdateProgress)
			{
				this.IncreaseProgress(0.0, status);
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, string.Concat(new string[]
					{
						commRC.ToString(),
						" inFastReadImage, address=",
						address,
						" size=",
						size.ToString()
					}));
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
			}
			return memoryImage;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000055F4 File Offset: 0x000037F4
		protected void DoFastReadImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image, string address, uint size, double startProgress, double endProgress, bool useCompress, bool bUpdateProgress, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && (string.IsNullOrEmpty(address) || size == 0U || this._transport == null))
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (bUpdateProgress)
			{
				this.IncreaseProgress(0.0, status);
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				uint num = size;
				uint num2 = global::System.Convert.ToUInt32(address);
				double num3 = num / global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE;
				bool flag = true;
				if (num3 == 0.0)
				{
					num3 = 1.0;
					flag = false;
				}
				bool flag2 = true;
				while (num > 0U)
				{
					if (this._bCancelIO)
					{
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0018_RH_CommErrIOCanceled;
						this.CancelSignal.Set();
						break;
					}
					uint num4 = (num > global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE) ? global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE : num;
					bool flag3 = false;
					if (flag2)
					{
						flag3 = true;
						flag2 = false;
					}
					if (num4 != global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE)
					{
						flag3 = true;
					}
					if (flag3)
					{
						global::Motorola.Common.Communication.SBEPSetReadDataSize sbepsetReadDataSize = new global::Motorola.Common.Communication.SBEPSetReadDataSize(this._transport, (ushort)num4);
						sbepsetReadDataSize.ExecuteMessage();
						commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepsetReadDataSize.OperationResult);
						if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
						{
							break;
						}
					}
					global::Motorola.Common.Communication.SBEPReadData sbepreadData = new global::Motorola.Common.Communication.SBEPReadData(this._transport, num2, (ushort)num4);
					sbepreadData.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepreadData.OperationResult);
					if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
					{
						break;
					}
					if (sbepreadData.ReceivedData.Length == 0)
					{
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0021_RH_CommErrReadZeroLengthData;
						break;
					}
					uint num5 = (uint)sbepreadData.ReceivedData.Length;
					if (useCompress)
					{
						byte[] array = new byte[num4];
						global::Motorola.Common.Communication.Compression.FastLZWrapper.DataDecompress(sbepreadData.ReceivedData, array, ref num5);
						global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
						flashMemoryUnit.ChargeUnit(num2.ToString(), array, 0, 1U);
						image.AddItem(flashMemoryUnit);
					}
					else
					{
						global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit2 = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
						flashMemoryUnit2.ChargeUnit(num2.ToString(), sbepreadData.ReceivedData, 0, 1U);
						image.AddItem(flashMemoryUnit2);
					}
					if (num5 != num4)
					{
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0002_RH_CommErrDataSize;
						break;
					}
					num2 += num5;
					num -= num5;
					if (bUpdateProgress && flag)
					{
						double increasePercent = 1.0 / num3 * (endProgress - startProgress);
						this.IncreaseProgress(increasePercent, status);
					}
				}
			}
			if (status == global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP && bUpdateProgress)
			{
				this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
			}
			else if (bUpdateProgress)
			{
				this.IncreaseProgress(0.0, status);
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, string.Concat(new string[]
					{
						commRC.ToString(),
						" inFastReadImage, address=",
						address,
						" size=",
						size.ToString()
					}));
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in FastReadImage(MemoryImage image, string address, uint size, double startProgress, double endProgress)");
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005898 File Offset: 0x00003A98
		protected void ReadImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image, string address, uint size, double startProgress, double endProgress, bool bUpdateProgress)
		{
			try
			{
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
				if (image == null)
				{
					commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
				}
				if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && (string.IsNullOrEmpty(address) || size == 0U || this._transport == null))
				{
					commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
				}
				this.DoBeginReadImage(this._devInfo.UseCompress);
				this.DoFastReadImage(image, address, size, startProgress, endProgress, this._devInfo.UseCompress, bUpdateProgress, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					if (this._transport != null)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in ReadImage(MemoryImage image, string address, uint size, double startProgress, double endProgress)");
					}
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
				}
			}
			finally
			{
				this.DoEndReadImage(this._devInfo.UseCompress);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005958 File Offset: 0x00003B58
		protected global::Motorola.Common.Communication.CommonUtil.MemoryImage DoReadImage(string address, uint size, bool useCompress, bool bUpdateProgress = true, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage)
		{
			global::Motorola.Common.Communication.CommonUtil.MemoryImage result;
			try
			{
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
				if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && (string.IsNullOrEmpty(address) || size == 0U || this._transport == null))
				{
					commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
				}
				this.DoBeginReadImage(useCompress);
				global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.DoFastReadImage(address, size, useCompress, bUpdateProgress, status);
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					if (this._transport != null)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in ReadImage(string address, uint size)");
					}
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
				}
				result = memoryImage;
			}
			finally
			{
				this.DoEndReadImage(useCompress);
			}
			return result;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000059F4 File Offset: 0x00003BF4
		protected void DoWriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image, bool useCompress, bool bUpdateProgress = true, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && (image == null || this._transport == null))
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && (!image.IsGood() || image.Count == 0))
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0003_RH_CommErrBadImage;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && !(image[0] is global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit))
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0003_RH_CommErrBadImage;
			}
			if (bUpdateProgress)
			{
				this.IncreaseProgress(0.0, status);
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPDecompressData sbepdecompressData = new global::Motorola.Common.Communication.SBEPDecompressData(this._transport, useCompress);
				sbepdecompressData.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepdecompressData.OperationResult);
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPSetMemoryType sbepsetMemoryType = new global::Motorola.Common.Communication.SBEPSetMemoryType(this._transport, global::Motorola.Common.Communication.MEMORY_TYPE.MT_FLASH);
				sbepsetMemoryType.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepsetMemoryType.OperationResult);
			}
			uint num = 0U;
			for (int i = 0; i < image.Count; i++)
			{
				global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit = image[i];
				num += memoryUnit.Size;
			}
			double num2 = num / global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_WRITE_SIZE;
			uint num3 = uint.MaxValue;
			bool flag = num >= global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_WRITE_SIZE;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				for (int j = 0; j < image.Count; j++)
				{
					global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit2 = image[j];
					uint num4 = memoryUnit2.Size;
					uint num5 = global::System.Convert.ToUInt32(memoryUnit2.Address);
					uint num6 = 0U;
					while (num4 > 0U)
					{
						uint num7 = (num4 > global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_WRITE_SIZE) ? global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_WRITE_SIZE : num4;
						uint num8 = num7;
						num3 = num5 + num8;
						byte[] array = new byte[num7];
						global::System.Array.Copy(memoryUnit2.Data, (long)((ulong)num6), array, 0L, (long)((ulong)num7));
						if (useCompress)
						{
							byte[] array2 = new byte[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_COMPRESS_WRITE_SIZE];
							global::Motorola.Common.Communication.Compression.FastLZWrapper.DataCompress(array, array2, ref num8);
							array = new byte[num8];
							global::System.Array.Copy(array2, array, (long)((ulong)num8));
						}
						global::Motorola.Common.Communication.SBEPWriteData sbepwriteData = new global::Motorola.Common.Communication.SBEPWriteData(this._transport, num5, array);
						sbepwriteData.ExecuteMessage();
						commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepwriteData.OperationResult);
						if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
						}
						num5 += num7;
						num6 += num7;
						num4 -= num7;
						if (bUpdateProgress && flag)
						{
							this.IncreaseProgress(1.0 / num2, status);
						}
					}
				}
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && num3 != 4294967295U)
			{
				global::Motorola.Common.Communication.SBEPWriteData sbepwriteData2 = new global::Motorola.Common.Communication.SBEPWriteData(this._transport, num3, new byte[0]);
				sbepwriteData2.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepwriteData2.OperationResult);
			}
			if (useCompress)
			{
				global::Motorola.Common.Communication.SBEPDecompressData sbepdecompressData2 = new global::Motorola.Common.Communication.SBEPDecompressData(this._transport, false);
				sbepdecompressData2.ExecuteMessage();
				if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepdecompressData2.OperationResult);
				}
			}
			global::Motorola.Common.Communication.SBEPSetMemoryType sbepsetMemoryType2 = new global::Motorola.Common.Communication.SBEPSetMemoryType(this._transport, global::Motorola.Common.Communication.MEMORY_TYPE.MT_DEFAULT);
			sbepsetMemoryType2.ExecuteMessage();
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepsetMemoryType2.OperationResult);
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in WriteImage(MemoryImage image)");
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
			}
			if (bUpdateProgress)
			{
				this.UpdateToFinalStatus(status);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005CD4 File Offset: 0x00003ED4
		protected void DoEraseImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && (image == null || this._transport == null))
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && (!image.IsGood() || image.Count == 0))
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0003_RH_CommErrBadImage;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && !(image[0] is global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit))
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0003_RH_CommErrBadImage;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				for (int i = 0; i < image.Count; i++)
				{
					global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit = image[i];
					this.DoEraseFlash(memoryUnit.Address, memoryUnit.Size, status);
				}
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in EraseImage(MemoryImage image)");
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
			}
			if (status == global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ErasingCP)
			{
				this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseCPDone);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005DA0 File Offset: 0x00003FA0
		protected void DoGetFlashType(out uint venderID, out uint flashID)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			venderID = 0U;
			flashID = 0U;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPFlashType sbepflashType = new global::Motorola.Common.Communication.SBEPFlashType(this._transport);
				sbepflashType.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepflashType.OperationResult);
				if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					venderID = (uint)sbepflashType.FlashVID;
					flashID = (uint)sbepflashType.FlashPID;
				}
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in GetFlashType(out uint venderID, out uint flashID)");
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005E38 File Offset: 0x00004038
		protected global::System.Collections.Generic.IList<global::Motorola.Common.Communication.CommonUtil.HwConfigSection> DoGetHwConfig()
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.HwConfigSection> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.HwConfigSection>();
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPReadHwConfig sbepreadHwConfig = new global::Motorola.Common.Communication.SBEPReadHwConfig(this._transport, 1000);
				sbepreadHwConfig.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepreadHwConfig.OperationResult);
				if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					byte[] array = new byte[sbepreadHwConfig.Data.Length + 2];
					array[array.Length - 1] = 0;
					array[array.Length - 2] = 0;
					global::System.Array.Copy(sbepreadHwConfig.Data, array, sbepreadHwConfig.Data.Length);
					int num = 0;
					while (array[num] != 0 || array[num + 1] != 0)
					{
						global::Motorola.Common.Communication.CommonUtil.HwConfigSection hwConfigSection = new global::Motorola.Common.Communication.CommonUtil.HwConfigSection();
						hwConfigSection.SectionType = (int)array[num];
						int num2 = (int)array[num + 1];
						if (num2 > 8)
						{
							break;
						}
						byte[] array2 = new byte[8];
						hwConfigSection.RawData = new byte[num2];
						global::System.Array.Copy(array, num + 2, array2, 0, num2);
						global::System.Array.Copy(array, num + 2, hwConfigSection.RawData, 0, num2);
						global::System.Array.Reverse(array2, 0, num2);
						hwConfigSection.Value = global::System.BitConverter.ToUInt64(array2, 0).ToString();
						num = num + 2 + num2;
						list.Add(hwConfigSection);
					}
				}
				else
				{
					if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD1015_PR_CommErrSBEPUnsupportReply)
					{
						if (this._transport != null)
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in GetHwConfig()");
						}
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
					}
					global::Motorola.Common.Communication.SBEPGetHwID sbepgetHwID = new global::Motorola.Common.Communication.SBEPGetHwID(this._transport);
					sbepgetHwID.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepgetHwID.OperationResult);
					if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
					}
					list.Add(new global::Motorola.Common.Communication.CommonUtil.HwConfigSection
					{
						SectionType = 0,
						Value = sbepgetHwID.HwID.ToString()
					});
				}
			}
			return list;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000601C File Offset: 0x0000421C
		protected void DoResetProgramRadio(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			byte mode2 = 1;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				switch (mode)
				{
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL:
					mode2 = 0;
					goto IL_3C;
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.CHARGING:
					mode2 = 1;
					goto IL_3C;
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL:
					break;
				default:
					if (mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP)
					{
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
						goto IL_3C;
					}
					break;
				}
				mode2 = 2;
			}
			IL_3C:
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPResetRadio sbepresetRadio = new global::Motorola.Common.Communication.SBEPResetRadio(this._transport, mode2);
				sbepresetRadio.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepresetRadio.OperationResult);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00006088 File Offset: 0x00004288
		protected byte[] DoGetCpuID()
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			byte[] array = null;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPGetUID sbepgetUID = new global::Motorola.Common.Communication.SBEPGetUID(this._transport);
				sbepgetUID.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepgetUID.OperationResult);
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					if (this._transport != null)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in GetCpuID()");
					}
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
				}
				if (sbepgetUID.UID.Length <= 0)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD1005_PR_CommErrSBEPMSGWrongFormat.ToString(), "TetraCommInterface.GetCpuID the cpuId buffer is empty");
				}
				array = new byte[sbepgetUID.UID.Length];
				global::System.Array.Copy(sbepgetUID.UID, array, sbepgetUID.UID.Length);
			}
			return array;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00006154 File Offset: 0x00004354
		protected bool GetTEIRawDataViaSbep(out byte[] teiRawData, out global::Motorola.Common.Communication.CommonUtil.CommRC rc)
		{
			bool result = false;
			teiRawData = null;
			string empty = string.Empty;
			rc = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (rc == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				rc = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (rc == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPGetTEI sbepgetTEI = new global::Motorola.Common.Communication.SBEPGetTEI(this._transport);
				sbepgetTEI.ExecuteMessage();
				rc = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepgetTEI.OperationResult);
				if (rc == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					result = true;
					teiRawData = sbepgetTEI.TEI;
				}
			}
			return result;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000061B0 File Offset: 0x000043B0
		protected bool FetchTEIFromRawData(byte[] teiRawData, out string tei, out global::Motorola.Common.Communication.CommonUtil.CommRC rc)
		{
			bool result = false;
			tei = string.Empty;
			int num = 15;
			rc = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (teiRawData.Length < (num + 1) / 2)
			{
				rc = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0009_RH_CommErrInvalidTEI;
			}
			if (rc == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				byte b = (byte)((teiRawData[0] & 224) >> 4);
				byte b2 = b;
				switch (b2)
				{
				case 0:
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					for (int i = 0; i < (num + 1) / 2; i++)
					{
						stringBuilder.Append(string.Format("{0:X2}", teiRawData[i]));
					}
					stringBuilder.Remove(num, 1);
					tei = stringBuilder.ToString();
					goto IL_33F;
				}
				case 1:
				case 3:
					break;
				case 2:
				{
					global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
					for (int j = 0; j < (num + 1) / 2; j++)
					{
						stringBuilder2.Append(string.Format("{0:X2}", teiRawData[j]));
					}
					stringBuilder2.Remove(0, 1);
					tei = stringBuilder2.ToString();
					goto IL_33F;
				}
				case 4:
				{
					int num2 = (int)teiRawData[0] << 8 | (int)teiRawData[1];
					num2 = (num2 >> 1 & 4095);
					string text = string.Format("{0:X3}", num2);
					int num3 = (int)teiRawData[1] << 8 | (int)teiRawData[2];
					num3 = (num3 >> 2 & 127);
					string text2;
					try
					{
						text2 = global::System.Convert.ToChar(num3).ToString();
					}
					catch
					{
						rc = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0009_RH_CommErrInvalidTEI;
						goto IL_33F;
					}
					int num4 = (int)teiRawData[2] << 8 | (int)teiRawData[3];
					num4 = (num4 >> 3 & 127);
					string text3;
					try
					{
						text3 = global::System.Convert.ToChar(num4).ToString();
					}
					catch
					{
						rc = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0009_RH_CommErrInvalidTEI;
						goto IL_33F;
					}
					int num5 = (int)teiRawData[3] << 8 | (int)teiRawData[4];
					num5 = (num5 >> 4 & 127);
					string text4;
					try
					{
						text4 = global::System.Convert.ToChar(num5).ToString();
					}
					catch
					{
						rc = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0009_RH_CommErrInvalidTEI;
						goto IL_33F;
					}
					string text5 = "";
					int num6 = (int)teiRawData[4] << 8 | (int)teiRawData[5];
					num6 = (num6 >> 5 & 127);
					try
					{
						text5 += global::System.Convert.ToChar(num6).ToString();
					}
					catch
					{
						rc = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0009_RH_CommErrInvalidTEI;
						goto IL_33F;
					}
					num6 = ((int)teiRawData[5] << 8 | (int)teiRawData[6]);
					num6 = (num6 >> 6 & 127);
					try
					{
						text5 += global::System.Convert.ToChar(num6).ToString();
					}
					catch
					{
						rc = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0009_RH_CommErrInvalidTEI;
						goto IL_33F;
					}
					num6 = ((int)teiRawData[6] << 8 | (int)teiRawData[7]);
					num6 = (num6 >> 7 & 127);
					try
					{
						text5 += global::System.Convert.ToChar(num6).ToString();
					}
					catch
					{
						rc = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0009_RH_CommErrInvalidTEI;
						goto IL_33F;
					}
					num6 = (int)teiRawData[7] << 8;
					num6 = (num6 >> 8 & 127);
					try
					{
						text5 += global::System.Convert.ToChar(num6).ToString();
					}
					catch
					{
						rc = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0009_RH_CommErrInvalidTEI;
						goto IL_33F;
					}
					tei = string.Concat(new string[]
					{
						text,
						text2,
						text3,
						text4,
						text5
					});
					goto IL_33F;
				}
				default:
					switch (b2)
					{
					case 8:
					case 10:
					case 12:
					case 14:
					{
						teiRawData[0] = (teiRawData[0] & 127);
						global::System.Text.StringBuilder stringBuilder3 = new global::System.Text.StringBuilder();
						for (int k = 0; k < (num + 1) / 2; k++)
						{
							stringBuilder3.Append(string.Format("{0:X2}", teiRawData[k]));
						}
						tei = stringBuilder3.ToString();
						goto IL_33F;
					}
					}
					break;
				}
				tei = "";
				rc = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0009_RH_CommErrInvalidTEI;
			}
			IL_33F:
			if (rc == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000655C File Offset: 0x0000475C
		protected string DoGetTEI()
		{
			byte[] teiRawData = null;
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			string empty = string.Empty;
			if (this.GetTEIRawDataViaSbep(out teiRawData, out commRC))
			{
				this.FetchTEIFromRawData(teiRawData, out empty, out commRC);
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in GetTEI()");
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
			}
			return empty;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000065D0 File Offset: 0x000047D0
		protected void DoEraseFlash(string address, uint size, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash)
		{
			uint num = global::System.Convert.ToUInt32(address);
			uint num2 = size;
			if (size == 0U)
			{
				this._EraseFlash(num.ToString(), size, status);
				return;
			}
			while (num2 > 0U)
			{
				uint num3 = (num2 > global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_ERASE_SIZE) ? global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_ERASE_SIZE : num2;
				this._EraseFlash(num.ToString(), num3, status);
				num2 -= num3;
				num += num3;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00006628 File Offset: 0x00004828
		protected bool DoTurnOffRadio()
		{
			bool result = true;
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPTurnRadioOff sbepturnRadioOff = new global::Motorola.Common.Communication.SBEPTurnRadioOff(this._transport);
				sbepturnRadioOff.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepturnRadioOff.OperationResult);
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in TurnOffRadio()");
				}
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD1010_PR_CommErrSBEPReceiveMessageError)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0025_RH_PowerOffRadioFailed.ToString(), commRC.ToString() + " in TurnOffRadio()");
				}
			}
			return result;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000066C4 File Offset: 0x000048C4
		protected byte[] DoReadCPData(string blockID, uint offset, ushort size)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPSetReadCPDataParam sbepsetReadCPDataParam = new global::Motorola.Common.Communication.SBEPSetReadCPDataParam(this._transport, offset, blockID);
				sbepsetReadCPDataParam.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepsetReadCPDataParam.OperationResult);
			}
			byte[] result = null;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPReadCPData sbepreadCPData = new global::Motorola.Common.Communication.SBEPReadCPData(this._transport, size);
				sbepreadCPData.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepreadCPData.OperationResult);
				result = sbepreadCPData.Data;
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in ReadCPData(string blockID, uint offset, ushort size)");
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
			}
			return result;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006770 File Offset: 0x00004970
		protected void UpdateProgress(double percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status)
		{
			if (this._progressIndicator != null)
			{
				this._progressIndicator.UpdateProgress(percent, status);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006787 File Offset: 0x00004987
		protected void StartRecordProgress()
		{
			if (this._progressIndicator != null)
			{
				this._progressIndicator.StartRecord();
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000679C File Offset: 0x0000499C
		protected void StopRecordProgress()
		{
			if (this._progressIndicator != null)
			{
				this._progressIndicator.StopRecord();
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000067B1 File Offset: 0x000049B1
		protected void SetCurrentScope(int start, int end)
		{
			if (this._progressIndicator != null)
			{
				this._progressIndicator.SetCurrentScope(start, end);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000067C8 File Offset: 0x000049C8
		protected void IncreaseProgress(double increasePercent)
		{
			if (this._progressIndicator != null)
			{
				this._progressIndicator.IncreaseProcess(increasePercent);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000067DE File Offset: 0x000049DE
		protected void IncreaseProgress(double increasePercent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status)
		{
			if (this._progressIndicator != null)
			{
				this._progressIndicator.IncreaseProcess(increasePercent, status);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000067F5 File Offset: 0x000049F5
		protected double CurrentProgress
		{
			get
			{
				if (this._progressIndicator != null)
				{
					return this._progressIndicator.CurrentProgress;
				}
				return 0.0;
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006814 File Offset: 0x00004A14
		protected void ResetProgress()
		{
			if (this._progressIndicator != null)
			{
				this._progressIndicator.Reset();
			}
		}

		// Token: 0x060000C2 RID: 194
		public abstract global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> ReadCodeplug();

		// Token: 0x060000C3 RID: 195
		public abstract void WriteCodeplug(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList, uint cpSize, string serialNum);

		// Token: 0x060000C4 RID: 196 RVA: 0x0000682C File Offset: 0x00004A2C
		public virtual void GetFlashType(out uint vendorID, out uint flashID)
		{
			try
			{
				this.DoGetFlashType(out vendorID, out flashID);
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006920 File Offset: 0x00004B20
		public virtual global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImage(string address, uint size, bool bUpdateProgress = true)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseSbepSeqManager.ReadImage");
			global::Motorola.Common.Communication.CommonUtil.MemoryImage image2;
			try
			{
				global::Motorola.Common.Communication.CommonUtil.MemoryImage image = null;
				this.RetryMethod(delegate
				{
					image = this.DoReadImage(address, size, this._devInfo.UseCompress, bUpdateProgress, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
				});
				image2 = image;
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("AbsCOMPortRadio.ReadImage", "");
			}
			return image2;
		}

		// Token: 0x060000C6 RID: 198
		public abstract void RestorePDV2Radio();

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00006A4C File Offset: 0x00004C4C
		public virtual uint HwID
		{
			get
			{
				uint hwID;
				lock (this._propertyAccessLock)
				{
					this.ReadHwConfig();
					hwID = this._devInfo.HwID;
				}
				return hwID;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00006A9C File Offset: 0x00004C9C
		public virtual global::System.Collections.Generic.IList<global::Motorola.Common.Communication.CommonUtil.HwConfigSection> HwConfigSections
		{
			get
			{
				global::System.Collections.Generic.IList<global::Motorola.Common.Communication.CommonUtil.HwConfigSection> hwConfigList;
				lock (this._propertyAccessLock)
				{
					this.ReadHwConfig();
					hwConfigList = this._devInfo.HwConfigList;
				}
				return hwConfigList;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00006AEC File Offset: 0x00004CEC
		public virtual string HwConfigString
		{
			get
			{
				string text = string.Empty;
				foreach (global::Motorola.Common.Communication.CommonUtil.HwConfigSection hwConfigSection in this.HwConfigSections)
				{
					text = string.Concat(new string[]
					{
						text,
						global::System.Convert.ToInt32(hwConfigSection.SectionType).ToString(),
						":",
						hwConfigSection.Value.ToString(),
						","
					});
				}
				text = text.Remove(text.Length - 1);
				return text;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00006B90 File Offset: 0x00004D90
		public virtual string TEI
		{
			get
			{
				string tei;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (string.IsNullOrEmpty(this._devInfo.TEI))
						{
							this._devInfo.TEI = this.DoGetTEI();
							if (this._radioProfile.NGCHDevicePart != global::Motorola.Common.Communication.TetraUtility.NGCHDeviceComponent.ControlHead && string.Equals(this._devInfo.TEI, "7FFFFFFFFFFFFFFF", global::System.StringComparison.InvariantCulture))
							{
								global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Got Radio TEI 7FFFFFFFFFFFFFFF! Will Try to re-get it from CP Root Block!!");
								byte[] array = this.ReadCPData(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID, (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_TEI_OFFSET, 8);
								global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
								for (int i = 0; i < array.Length; i++)
								{
									stringBuilder.Append(string.Format("{0:X2}", array[i]));
								}
								stringBuilder.Remove(15, 1);
								this._devInfo.TEI = stringBuilder.ToString();
							}
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						this._devInfo.TEI = string.Empty;
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
					}
					catch (global::System.Exception e)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, this.RadioProfile.Path, "Generic Error", new object[0]);
						this._devInfo.TEI = string.Empty;
					}
					tei = this._devInfo.TEI;
				}
				return tei;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00006D3C File Offset: 0x00004F3C
		public virtual global::Motorola.Common.Communication.TetraUtility.ByteOrder ByteOrder
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.UnInitialized)
						{
							this._byteOrder = this.GetByteOrder();
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
						this._byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.UnknowType;
					}
					catch (global::System.Exception e)
					{
						this._byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.UnknowType;
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, (this.Transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "Generic exception", new object[0]);
					}
					byteOrder = this._byteOrder;
				}
				return byteOrder;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00006E04 File Offset: 0x00005004
		public virtual global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo ModelInfo
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo result;
				lock (this._propertyAccessLock)
				{
					global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo tetraRadioModelInfo = null;
					try
					{
						tetraRadioModelInfo = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel((int)this.ModelType);
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
						{
							ex
						});
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
						tetraRadioModelInfo = null;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
						{
							ex2
						});
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic Error", new object[0]);
						tetraRadioModelInfo = null;
					}
					result = tetraRadioModelInfo;
				}
				return result;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00006F04 File Offset: 0x00005104
		public virtual string CommonModelNumber
		{
			get
			{
				string result;
				lock (this._propertyAccessLock)
				{
					string text = string.Empty;
					try
					{
						text = this.ComposeCommonModelNumber(this.ModelNumber, this.HomeMCC);
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
						text = string.Empty;
					}
					catch (global::System.Exception e)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, this.RadioProfile.Path, "Generic Error", new object[0]);
						text = string.Empty;
					}
					result = text;
				}
				return result;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000CE RID: 206
		public abstract ushort ModelType { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000CF RID: 207
		public abstract uint HomeMCC { get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D0 RID: 208
		public abstract uint HomeMNC { get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D1 RID: 209
		public abstract string CodeplugVersion { get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D2 RID: 210
		public abstract string SerialNumber { get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D3 RID: 211
		public abstract string SoftwareVersion { get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D4 RID: 212
		public abstract uint Issi { get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D5 RID: 213
		public abstract byte[] ARP { get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00006FC4 File Offset: 0x000051C4
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00006FD1 File Offset: 0x000051D1
		public virtual byte[] DUP
		{
			get
			{
				return this._devInfo.DUP;
			}
			set
			{
				this._devInfo.DUP = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00006FE0 File Offset: 0x000051E0
		public bool IsCodeplugAuthenticationEnabled
		{
			get
			{
				bool isCodeplugAuthenticationEnabled;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (this._devInfo.HomeMCC == -1)
						{
							uint homeMCC = this.HomeMCC;
						}
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
						{
							ex
						});
					}
					isCodeplugAuthenticationEnabled = this._devInfo.IsCodeplugAuthenticationEnabled;
				}
				return isCodeplugAuthenticationEnabled;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00007074 File Offset: 0x00005274
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000707C File Offset: 0x0000527C
		public int AuthenticatedTimes
		{
			get
			{
				return this._authRetriy;
			}
			set
			{
				this._authRetriy = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00007088 File Offset: 0x00005288
		public virtual global::Motorola.Common.Communication.TetraUtility.MemMapRecord MemoryMap
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.MemMapRecord result = null;
				try
				{
					if (string.IsNullOrEmpty(this.CodeplugVersion) || string.IsNullOrEmpty(this.ModelNumber))
					{
						return result;
					}
					string codeplugVersion = this.CodeplugVersion;
					string commonModelNumber = this.CommonModelNumber;
					global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord memMapVersionMapRecord = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetMemMapVersionMapRecord(codeplugVersion, commonModelNumber);
					result = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetMemMapConfig(memMapVersionMapRecord.MemMapID);
				}
				catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
				{
					result = new global::Motorola.Common.Communication.TetraUtility.MemMapRecord();
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				}
				catch (global::System.Exception e)
				{
					result = new global::Motorola.Common.Communication.TetraUtility.MemMapRecord();
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, this.RadioProfile.Path, "Generic Error", new object[0]);
				}
				return result;
			}
		}

		// Token: 0x060000DC RID: 220
		public abstract void UpdateFlashstrap(ushort modelType, string cpVersion, string flashstrapFilePath, bool bResetProgress);

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000DD RID: 221
		// (set) Token: 0x060000DE RID: 222
		public abstract int PartionHealthState { get; set; }

		// Token: 0x060000DF RID: 223 RVA: 0x0000714C File Offset: 0x0000534C
		public virtual void GetFPVersion(out global::Motorola.Common.Communication.CommonUtil.fp_version_t[] fpVerInfo)
		{
			this.CreateReleaseID();
			if (this._releaseID.FPInfo != null)
			{
				fpVerInfo = new global::Motorola.Common.Communication.CommonUtil.fp_version_t[this._releaseID.FPInfo.fp_packs.Length];
				this._releaseID.FPInfo.fp_packs.CopyTo(fpVerInfo, 0);
				return;
			}
			fpVerInfo = null;
		}

		// Token: 0x060000E0 RID: 224
		public abstract void ReadRadioLLPHeader(out global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader);

		// Token: 0x060000E1 RID: 225
		public abstract void ReadRadioLPHeader(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packHeader);

		// Token: 0x060000E2 RID: 226
		public abstract byte[] ReadRadioLLP();

		// Token: 0x060000E3 RID: 227
		public abstract void WriteRadioLP(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, string swPath, global::Motorola.Common.Communication.FDT.FDTParams paramters, int startPosition, int endPosition, bool bResetProgress = true);

		// Token: 0x060000E4 RID: 228
		public abstract void WriteRadioLLP(byte[] llp);

		// Token: 0x060000E5 RID: 229 RVA: 0x000071A4 File Offset: 0x000053A4
		public virtual bool CanWriteLanguagePacks(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks, string toFwFilePathName, string swVer, uint modelType)
		{
			bool result;
			if (string.IsNullOrEmpty(toFwFilePathName))
			{
				result = this.VerifyLanguagePacks(packs, allPacks);
			}
			else
			{
				global::Motorola.Common.Communication.TetraUtility.Z19File z19File = global::Motorola.Common.Communication.TetraUtility.FPTools.LoadSoftwareFile(toFwFilePathName);
				if (z19File == null)
				{
					return false;
				}
				global::Motorola.Common.Communication.TetraUtility.ReleaseID releaseID = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.CreateReleaseIDFromSoftwareFile(z19File, modelType, this.ByteOrder, this.HwID);
				if (releaseID == null)
				{
					return false;
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> swPacks = null;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> mandatoryPacks = null;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = null;
				global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.ReadFlashPacksFromFile(toFwFilePathName, out swPacks, swVer, this.ByteOrder, modelType, this.HwID, this.HwConfigString);
				global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.SplitPacksFromFile(swPacks, out mandatoryPacks, out list);
				result = this.VerifyLanguagePacks(packs, allPacks, mandatoryPacks, releaseID.FPInfo.pFPEndAdd - releaseID.FPInfo.pFPStartAdd);
			}
			return result;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00007241 File Offset: 0x00005441
		protected global::System.Threading.AutoResetEvent CancelSignal
		{
			get
			{
				return this._cancelSignal;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000724C File Offset: 0x0000544C
		protected virtual void EraseFromTo(string from, string to)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseSbepSeqManager.EraseFromTo");
			try
			{
				global::System.Convert.ToUInt32(from);
				global::System.Convert.ToUInt32(to);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0016_RH_CommErrInvalidInputAddress.ToString(), "Invalid input address", innerException);
			}
			try
			{
				this.DoEraseFlash(from, global::System.Convert.ToUInt32(to) - global::System.Convert.ToUInt32(from), global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("AbsCOMPortRadio.EraseFromTo", "");
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E8 RID: 232
		protected abstract string ModelNumber { get; }

		// Token: 0x060000E9 RID: 233 RVA: 0x0000736C File Offset: 0x0000556C
		protected virtual global::Motorola.Common.Communication.TetraUtility.ByteOrder GetByteOrder()
		{
			global::Motorola.Common.Communication.TetraUtility.CPUTypeRecord cpuTypeConfig = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetCpuTypeConfig(this.HwID);
			if (cpuTypeConfig == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0024_RH_CommErrInvalidHardwareId.ToString(), string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Hardware ID is invalid and can't get CPU type record, HwID={0}", new object[]
				{
					this.HwID
				}));
			}
			return cpuTypeConfig.ByteOrder;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000073C8 File Offset: 0x000055C8
		protected virtual string ComposeCommonModelNumber(string modelNumber, uint homeMCC)
		{
			global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel(modelNumber, global::Motorola.Common.Communication.TetraUtility.MCCConverter.ToString(homeMCC));
			if (model == null)
			{
				string message = string.Format("Model Number = {0}, HomeMCC= {1:X4}", modelNumber, homeMCC);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message);
			}
			return model.UniqueModelNumber;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00007414 File Offset: 0x00005614
		protected global::Motorola.Common.Communication.Pba.PbaObject doWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, string serialNumber, int startPosition, int endPosition, bool bResetProgress = true)
		{
			if (bResetProgress)
			{
				this.ResetProgress();
			}
			int num = 0;
			byte[] llpData = writePBA.GetLlpData();
			if (startPosition != 0 || endPosition != 0)
			{
				if (llpData != null)
				{
					num = startPosition + (endPosition - startPosition) * 4 / 5;
					this.SetCurrentScope(startPosition, num);
				}
				else
				{
					num = endPosition;
					this.SetCurrentScope(startPosition, num);
				}
			}
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> codeplugInFbiBlockList = writePBA.GetCodeplugInFbiBlockList();
			uint cpSize = global::Motorola.Common.Communication.TetraUtility.TetraUtil.CalculateCpSize(codeplugInFbiBlockList);
			this.WriteCodeplug(codeplugInFbiBlockList, cpSize, serialNumber);
			bool flag;
			if (!this._forceWrite)
			{
				uint homeMCC = global::Motorola.Common.Communication.TetraUtility.MCCConverter.DecrypteHomeMcc(this.HomeMCC);
				flag = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.IsRadioSupportFP(this.ComposeCommonModelNumber(this.ModelNumber, homeMCC), this.CodeplugVersion);
			}
			else
			{
				string recoverCPversion = this._recoverCPversion;
				flag = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.IsRadioSupportFP(this._recoverModelNumbel, recoverCPversion);
			}
			if (llpData != null && flag)
			{
				this.SetCurrentScope(num, endPosition);
				this.WriteRadioLLP(llpData);
			}
			return writePBA;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000074DC File Offset: 0x000056DC
		protected virtual void WaitForRadioReset()
		{
			if (!this._radioResetEvent.WaitOne(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_RESET_TIMEOUT, false))
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "TetraBaseSbepSeqManager.WaitForRadioReset: reset radio timed out");
				if ((this.Transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).Reliable)
				{
					global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS statusCode = global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.NoDeviceConnected;
					if (global::Motorola.Common.Communication.TetraUtility.USBDiagnose.GetUSBPortStatus(this.RadioProfile.USBHubInstance, this.RadioProfile.USBHubPortNumber, this.RadioProfile.Path, out statusCode))
					{
						string str = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.ConnectionStatusCodeToStr(statusCode);
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Connection Status is: " + str);
					}
				}
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("TetraBaseSbepSeqManager.WaitForRadioReset: reset radio timed out");
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000758C File Offset: 0x0000578C
		protected virtual void Instance_DeviceChanged(object sender, global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs e)
		{
			if (this._disposed)
			{
				return;
			}
			try
			{
				for (int i = 0; i < e.MsgList.Count; i++)
				{
					if (e.MsgList[i].PhysicalLocation == this.RadioProfile.PhysicalLocation)
					{
						this._switchedRadioMode = e.MsgList[i].DevMode;
						this._switchedRadioType = e.MsgList[i].RadioType;
						if (e.MsgList[i].DevMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL || e.MsgList[i].DevMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.CHARGING || e.MsgList[i].DevMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL)
						{
							this._radioResetEvent.Set();
							break;
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Exception in TetraBaseSbepSeqManager.Instance_DeviceChanged: " + ex.Message);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00007690 File Offset: 0x00005890
		protected virtual global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord GetFlashTypeConfig()
		{
			global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord flashTypeRecord = null;
			uint num = 0U;
			uint num2 = 0U;
			this.GetFlashType(out num2, out num);
			foreach (global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord flashTypeRecord2 in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.FlashTypeConfigTable.RecordsList)
			{
				if (flashTypeRecord2.FlashID == num && flashTypeRecord2.VenderID == num2)
				{
					flashTypeRecord = flashTypeRecord2;
					break;
				}
			}
			if (flashTypeRecord == null)
			{
				string str = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString();
				string str2 = string.Format("venderID={0},flashID={1}", num2, num);
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, str + " " + str2 + " in GetFlashTypeConfig()");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("venderID={0},flashID={1}", num2, num));
			}
			return flashTypeRecord;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00007780 File Offset: 0x00005980
		protected bool GetFlashAttributes(out global::Motorola.Common.Communication.TetraUtility.FlashAttribute flashAttr)
		{
			flashAttr.startAddr = 0U;
			flashAttr.lastAddr = 0U;
			flashAttr.blockSize = 0U;
			bool result;
			try
			{
				uint num = 0U;
				uint num2 = 0U;
				this.GetFlashType(out num, out num2);
				global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord flashTypeRecord = null;
				foreach (global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord flashTypeRecord2 in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.FlashTypeConfigTable.RecordsList)
				{
					if (flashTypeRecord2.FlashID == num2 && flashTypeRecord2.VenderID == num)
					{
						flashTypeRecord = flashTypeRecord2;
						break;
					}
				}
				if (flashTypeRecord == null)
				{
					result = false;
				}
				else
				{
					global::Motorola.Common.Communication.TetraUtility.HwIDRecord hwIDRecord = null;
					foreach (global::Motorola.Common.Communication.TetraUtility.HwIDRecord hwIDRecord2 in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.HwIDTable.RecordsList)
					{
						if (hwIDRecord2.HwID == this.HwID)
						{
							hwIDRecord = hwIDRecord2;
							break;
						}
					}
					if (hwIDRecord == null)
					{
						result = false;
					}
					else
					{
						global::Motorola.Common.Communication.TetraUtility.CPUTypeRecord cputypeRecord = null;
						foreach (global::Motorola.Common.Communication.TetraUtility.CPUTypeRecord cputypeRecord2 in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.CpuTypeConfigTable.RecordsList)
						{
							if (cputypeRecord2.CPUType == hwIDRecord.CPUType)
							{
								cputypeRecord = cputypeRecord2;
								break;
							}
						}
						if (cputypeRecord == null)
						{
							result = false;
						}
						else
						{
							flashAttr.startAddr = cputypeRecord.StartAddress;
							flashAttr.lastAddr = cputypeRecord.StartAddress + flashTypeRecord.Size;
							flashAttr.blockSize = flashTypeRecord.BlockSize;
							result = true;
						}
					}
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				result = false;
			}
			catch (global::System.Exception e)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "Generic Error");
				result = false;
			}
			return result;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000079B4 File Offset: 0x00005BB4
		protected virtual global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit> GetSWFlashRegionSet()
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit>();
			try
			{
				if (!this.MemoryMap.MapDefinition.ContainsKey(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_FW_SECTION))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("memory map {0} has the wrong codeplug section definition", this.MemoryMap.MemMapID));
				}
				for (int i = 0; i < this.MemoryMap.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_FW_SECTION].Count; i++)
				{
					list.Add(new global::Motorola.Common.Communication.TetraUtility.MemMapUnit
					{
						Address = this.MemoryMap.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_FW_SECTION][i].Address,
						Size = this.MemoryMap.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_FW_SECTION][i].Size
					});
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			return list;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00007ADC File Offset: 0x00005CDC
		protected virtual global::Motorola.Common.Communication.TetraUtility.MemMapUnit GetFlashSingleArea(string areaName)
		{
			global::Motorola.Common.Communication.TetraUtility.MemMapUnit memMapUnit = new global::Motorola.Common.Communication.TetraUtility.MemMapUnit();
			try
			{
				if (!this.MemoryMap.MapDefinition.ContainsKey(areaName) || this.MemoryMap.MapDefinition[areaName].Count != 1)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("memory map {0} has the wrong section definition", this.MemoryMap.MemMapID));
				}
				memMapUnit.Address = this.MemoryMap.MapDefinition[areaName][0].Address;
				memMapUnit.Size = this.MemoryMap.MapDefinition[areaName][0].Size;
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			return memMapUnit;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007BDC File Offset: 0x00005DDC
		protected virtual global::Motorola.Common.Communication.TetraUtility.MemMapUnit GetEntireFlashRegion()
		{
			global::Motorola.Common.Communication.TetraUtility.MemMapUnit memMapUnit = new global::Motorola.Common.Communication.TetraUtility.MemMapUnit();
			global::Motorola.Common.Communication.TetraUtility.CPUTypeRecord cpuTypeConfig = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetCpuTypeConfig(this.HwID);
			if (cpuTypeConfig == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0024_RH_CommErrInvalidHardwareId.ToString(), string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Hardware ID is invalid and can't get CPU type record, HwID={0}", new object[]
				{
					this.HwID
				}));
			}
			memMapUnit.Address = cpuTypeConfig.StartAddress;
			global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord flashTypeConfig = this.GetFlashTypeConfig();
			memMapUnit.Size = flashTypeConfig.Size;
			return memMapUnit;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00007C58 File Offset: 0x00005E58
		protected virtual global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit> GetFlashRegionSet(global::System.Collections.Generic.List<string> flashSectionSet)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit>();
			list.Clear();
			try
			{
				if (flashSectionSet == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "flash section name is empty");
				}
				global::Motorola.Common.Communication.TetraUtility.MemMapRecord memoryMap = this.MemoryMap;
				foreach (string a in flashSectionSet)
				{
					if (a == global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_REGION_CODEPLUG)
					{
						list.Add(this.GetFlashSingleArea(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_CP_SECTION));
					}
					else if (a == global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_REGION_SOFTWARE)
					{
						list = this.GetSWFlashRegionSet();
					}
					else if (a == global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_REGION_ENTIRE)
					{
						list.Clear();
						list.Add(this.GetEntireFlashRegion());
						break;
					}
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			return list;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00007D78 File Offset: 0x00005F78
		protected virtual string GetSwVerFromSwFile(string swFilePath)
		{
			string text = string.Empty;
			if (string.IsNullOrEmpty(swFilePath))
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "software file path is null in GetSwVerFromSwFile");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "software file path is null");
			}
			if (global::System.IO.Path.GetExtension(swFilePath).ToLowerInvariant().Contains(".z19") || global::System.IO.Path.GetExtension(swFilePath).ToLowerInvariant().Contains(".s19"))
			{
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(swFilePath);
				if (fileInfo == null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString() + " in GetSwVerFromSwFile");
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "software path is invalid!");
				}
				text = fileInfo.Name;
				global::Motorola.Common.Communication.TetraUtility.SoftWareName softWareName = global::Motorola.Common.Communication.TetraUtility.SoftWareName.ValidateSoftWareName(text);
				if (softWareName != null)
				{
					text = softWareName.SWVersion;
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, global::Motorola.Common.Communication.CommonUtil.CommRC.RD0023_RH_CommErrInvalidSWFile.ToString() + " in GetSwVerFromSwFile");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0023_RH_CommErrInvalidSWFile.ToString(), "Not supported software file format");
			}
			return text;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00007E90 File Offset: 0x00006090
		protected virtual void PrepareSWImage(string swFilePath, out global::Motorola.Common.Communication.TetraUtility.Z19File z19File, out global::Motorola.Common.Communication.TetraUtility.SRecord swS19File, out global::Motorola.Common.Communication.CommonUtil.MemoryImage swImage, out string swVerStr)
		{
			if (string.IsNullOrEmpty(swFilePath))
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "software file path is null in PrepareSWImage");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "software file path is null");
			}
			z19File = null;
			swS19File = null;
			swImage = null;
			swVerStr = string.Empty;
			if (global::System.IO.Path.GetExtension(swFilePath).ToLowerInvariant().Contains(".z19"))
			{
				z19File = new global::Motorola.Common.Communication.TetraUtility.Z19File(swFilePath);
				swS19File = z19File.FirmwareRecord;
				if (swS19File == null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, global::Motorola.Common.Communication.CommonUtil.CommRC.RD0023_RH_CommErrInvalidSWFile.ToString() + " in PrepareSWImage");
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0023_RH_CommErrInvalidSWFile.ToString(), "Invalid Z19 file");
				}
			}
			else
			{
				if (!global::System.IO.Path.GetExtension(swFilePath).ToLowerInvariant().Contains(".s19"))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, global::Motorola.Common.Communication.CommonUtil.CommRC.RD0023_RH_CommErrInvalidSWFile.ToString() + " in PrepareSWImage");
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0023_RH_CommErrInvalidSWFile.ToString(), "Not supported software file format");
				}
				swS19File = new global::Motorola.Common.Communication.TetraUtility.SRecord();
				swS19File.LoadFromFile(swFilePath);
			}
			swImage = swS19File.Image;
			swVerStr = string.Empty;
			if (z19File != null)
			{
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(swFilePath);
				if (fileInfo == null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString() + " in PrepareSWImage");
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "software path is invalid!");
				}
				global::Motorola.Common.Communication.TetraUtility.SoftWareName softWareName = global::Motorola.Common.Communication.TetraUtility.SoftWareName.ValidateSoftWareName(fileInfo.Name);
				if (softWareName != null)
				{
					swVerStr = softWareName.SWVersion;
				}
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00008028 File Offset: 0x00006228
		protected virtual void PrepareFlashstrap(string flashstrapName, out global::Motorola.Common.Communication.TetraUtility.SRecord flashstrapS19)
		{
			flashstrapS19 = new global::Motorola.Common.Communication.TetraUtility.SRecord();
			if (string.IsNullOrEmpty(flashstrapName))
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "flashstrapName is null");
			}
			try
			{
				flashstrapS19.LoadFromFile(flashstrapName);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "S19 file not exist", innerException);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00008090 File Offset: 0x00006290
		protected void CreateReleaseID()
		{
			this._releaseID = null;
			this._releaseID = new global::Motorola.Common.Communication.TetraUtility.ReleaseID();
			byte[] releaseIDImageData = this.GetReleaseIDImageData();
			if (releaseIDImageData != null)
			{
				if (this.ByteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.UnknowType)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0022_RH_CommErrUnknownCPUByteOrder.ToString());
				}
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
				if (!this._releaseID.Init(this.ByteOrder, (uint)this.ModelType, this.CodeplugVersion, releaseIDImageData, out commRC))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5050_FP_CommErrFPInitError.ToString(), "Internal Error is: " + commRC.ToString());
				}
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00008120 File Offset: 0x00006320
		protected byte[] SerializeBinary(object request)
		{
			byte[] array = null;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				binaryFormatter.Serialize(memoryStream, request);
				byte[] buffer = memoryStream.GetBuffer();
				array = new byte[buffer.Length];
				global::System.Array.Copy(buffer, array, buffer.Length);
			}
			return array;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000817C File Offset: 0x0000637C
		protected object DeserializeBinary(byte[] buf)
		{
			object result = null;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buf))
			{
				memoryStream.Position = 0L;
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				result = binaryFormatter.Deserialize(memoryStream);
			}
			return result;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000081C8 File Offset: 0x000063C8
		protected void OpenPipe()
		{
			if (this._transport != null)
			{
				this._transport.OpenPort();
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000081DE File Offset: 0x000063DE
		protected void ClosePipe()
		{
			if (this._transport != null)
			{
				this._transport.ClosePort();
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000081F4 File Offset: 0x000063F4
		protected void doWriteSoftware(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string cpVer, int startPosition, int endPosition, bool bResetProgress = true)
		{
			try
			{
				if (startPosition != 0 || endPosition != 0)
				{
					this.SetCurrentScope(startPosition, endPosition);
				}
				if (string.IsNullOrEmpty(pbaObject.FWpath))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "software file path is null");
				}
				if (this.IsExtMatch(pbaObject.FWpath, ".z19"))
				{
					this.WriteSoftware(pbaObject.FWpath, bResetProgress);
				}
				else
				{
					string text = global::System.IO.Path.Combine(global::System.Windows.Forms.Application.StartupPath + "/" + global::System.Guid.NewGuid().ToString(), global::System.IO.Path.GetFileNameWithoutExtension(pbaObject.FWpath)) + ".z19";
					if (!global::System.IO.File.Exists(text))
					{
						global::Motorola.Common.Communication.TetraUtility.Z19File.MakeZ19File(pbaObject.FWpath, cpVer, text);
					}
					this.WriteSoftware(text, bResetProgress);
					try
					{
						global::System.IO.File.Delete(text);
						global::System.IO.Directory.Delete(global::System.IO.Path.GetDirectoryName(text));
					}
					catch
					{
					}
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000836C File Offset: 0x0000656C
		protected void ConstructDeviceInfo()
		{
			try
			{
				this._devInfo.ConnectionInfo.Location = this.RadioProfile.Path;
				this._devInfo.Location = this.RadioProfile.PhysicalLocation;
				this._devInfo.DeviceMode = this.RadioProfile.DeviceMode;
				this._devInfo.CompositeDeviceLocation = this.RadioProfile.UniqueLocation;
				this._devInfo.ParentDevInstanceNum = this.RadioProfile.ParentDevInstanceNum;
				this._devInfo.RadioType = this.RadioProfile.TetraRadioType;
				this._devInfo.PID = this.RadioProfile.PID;
				this._devInfo.VID = this.RadioProfile.VID;
				this._devInfo.PreAttached = this.RadioProfile.PreAttached;
				this._devInfo.DevInstanceNum = this.RadioProfile.DevInstanceNum;
				this._devInfo.ParentDevInstanceNum = this.RadioProfile.ParentDevInstanceNum;
				this._devInfo.ActiveTransRadioType = this.RadioProfile.PairedActiveRadioType;
				this._devInfo.CpuID = this.CpuID;
				this.RadioProfile.TetraUID = this.CpuID;
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, "CPU ID is: " + this.CpuID);
				}
				this._devInfo.TEI = this.TEI;
				this._devInfo.UsbHubInstance = this.RadioProfile.USBHubInstance;
				this._devInfo.UsbHubPortNumber = this.RadioProfile.USBHubPortNumber;
				this._devInfo.CodeplugVersion = this.CodeplugVersion;
				this._devInfo.ModelNumber = this.ModelNumber;
				this._devInfo.SerialNumber = this.SerialNumber;
				this._devInfo.HomeMCC = (int)this.HomeMCC;
				this._devInfo.HomeMNC = (int)this.HomeMNC;
				this._devInfo.Issi = (int)this.Issi;
				this._devInfo.SoftwareVersion = this.SoftwareVersion;
				this._devInfo.PartionHealthState = this.PartionHealthState;
				this._devInfo.HwID = this.HwID;
				global::Motorola.Common.Communication.TetraUtility.CPUTypeRecord cpuTypeConfig = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetCpuTypeConfig(this.HwID);
				if (cpuTypeConfig == null)
				{
					this._devInfo.CpuType = global::Motorola.Common.Communication.TetraUtility.CPUType.UNKNOWN.ToString();
				}
				else
				{
					this._devInfo.CpuType = cpuTypeConfig.CPUType.ToString();
				}
				uint flashVID = 0U;
				uint flashID = 0U;
				this.GetFlashType(out flashVID, out flashID);
				this._devInfo.FlashID = flashID;
				this._devInfo.FlashVID = flashVID;
				this._devInfo.ModelNumber = this.ModelNumber;
				this._devInfo.HardwareIdIsValid = this.RadioProfile.HardwareIdIsValid;
			}
			catch
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Error in constructDeviceInfo().");
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000866C File Offset: 0x0000686C
		protected bool IsExtMatch(string filePath, string ext)
		{
			return global::System.IO.Path.GetExtension(filePath).ToLowerInvariant() == ext.ToLowerInvariant();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00008684 File Offset: 0x00006884
		protected virtual void SynchronizeUserPassword()
		{
			if (this.DUP == null)
			{
				return;
			}
			if (this.ARP != null)
			{
				global::System.Array.Copy(this.ARP, 8, this.DUP, 0, 32);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000086AC File Offset: 0x000068AC
		protected virtual void AR(byte[] data)
		{
			if (data != null)
			{
				this._devInfo.DUP = (data.Clone() as byte[]);
				if (!global::Motorola.Common.Communication.TetraUtility.CPAUtil.Vr(this._devInfo.ARP, this._devInfo.DUP))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD9001_AUTHEN_Failed.ToString(), "Codeplug Authenticate failed!");
				}
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00008706 File Offset: 0x00006906
		protected virtual void DR()
		{
			this._devInfo.DUP = null;
			this._devInfo.HomeMCC = -1;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00008720 File Offset: 0x00006920
		protected void RetryMethod(global::System.Action action)
		{
			for (int i = 0; i <= this._retryNum; i++)
			{
				try
				{
					action();
					break;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.TetraUtility.CCustomException ex2 = ex as global::Motorola.Common.Communication.TetraUtility.CCustomException;
					if (ex2 == null || !this.NeedRetryExceptionList.Contains(ex2.ErrorID) || i >= this._retryNum)
					{
						throw;
					}
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, action.ToString() + "\r\n" + ex.Message + this._retryStr);
				}
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000087B0 File Offset: 0x000069B0
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000087C0 File Offset: 0x000069C0
		protected virtual void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			if (disposing)
			{
				if (this._radioResetEvent != null)
				{
					this._radioResetEvent.Dispose();
					this._radioResetEvent = null;
				}
				if (this._cancelSignal != null)
				{
					this._cancelSignal.Dispose();
					this._cancelSignal = null;
				}
			}
			this._disposed = true;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00008814 File Offset: 0x00006A14
		~TetraBaseSbepSeqManager()
		{
			this.Dispose(false);
		}

		// Token: 0x06000106 RID: 262
		protected abstract byte[] GetReleaseIDImageData();

		// Token: 0x06000107 RID: 263
		protected abstract bool VerifyLanguagePacks(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> returnPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks);

		// Token: 0x06000108 RID: 264
		protected abstract bool VerifyLanguagePacks(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> returnPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> mandatoryPacks, uint fpSize);

		// Token: 0x06000109 RID: 265 RVA: 0x00008844 File Offset: 0x00006A44
		protected void ConstructRadioPacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData, string toFwFilePathName, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> constructPacks)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> radioPack = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = null;
			allPacks = null;
			constructPacks = null;
			uint modelType = 0U;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in langPackData.LanguagePacks)
			{
				global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo tetraLanguagePackInfo = (global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo)languagePackBase;
				if (tetraLanguagePackInfo != null)
				{
					list2.Add(new global::Motorola.Common.Communication.CommonUtil.PackHeader
					{
						compareID = (uint)global::System.Convert.ToInt32(tetraLanguagePackInfo.PackID, global::System.Globalization.CultureInfo.InvariantCulture),
						type = tetraLanguagePackInfo.PackType,
						imageName = tetraLanguagePackInfo.PackFilePath
					});
				}
			}
			try
			{
				modelType = (uint)this.ModelType;
			}
			catch (global::System.Exception)
			{
				modelType = 0U;
			}
			if (this.ByteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.UnknowType)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0022_RH_CommErrUnknownCPUByteOrder.ToString());
			}
			global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.ReadFlashPacksFromFile(toFwFilePathName, out list, this.SoftwareVersion, this.ByteOrder, modelType, this.HwID, this.HwConfigString);
			if (list.Count == 0)
			{
				this.ReadRadioLPHeader(out radioPack);
			}
			global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.MergePackHeaders(radioPack, list, out allPacks);
			constructPacks = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.ConstructPackList(list2, allPacks);
			if (constructPacks != null && !this.CanWriteLanguagePacks(constructPacks, allPacks, toFwFilePathName, this.SoftwareVersion, modelType))
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RE0001_LANGUAGE_LPValidFail.ToString());
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000899C File Offset: 0x00006B9C
		protected void doWriteLanguagePacks(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, string toFwPath, int startPosition, int endPosition, bool bResetProgress = true)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(packs, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			global::Motorola.Common.Communication.FDT.FDTParams fdtparams = new global::Motorola.Common.Communication.FDT.FDTParams();
			if (!this._forceWrite)
			{
				this.WriteRadioLP(packs, toFwPath, null, startPosition, endPosition, false);
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel(this._recoverModelNumbel);
			if (model == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "model type is null!");
			}
			fdtparams.cpVersion = this._recoverCPversion;
			fdtparams.modelType = (ushort)global::System.Convert.ToUInt32(model.ModelType);
			fdtparams.uniqueModelNumber = this._recoverModelNumbel;
			fdtparams.serialNumber = this._recoverSerialNumber;
			this.WriteRadioLP(packs, toFwPath, fdtparams, startPosition, endPosition, false);
		}

		// Token: 0x0600010B RID: 267
		protected abstract void TestFdtCmd(global::Motorola.Common.Communication.CommonUtil.TestFDTCmdInfo fdtInfo, out string strResult);

		// Token: 0x0600010C RID: 268 RVA: 0x00008A3C File Offset: 0x00006C3C
		private void _EraseFlash(string address, uint size, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && (string.IsNullOrEmpty(address) || this._transport == null))
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			this.IncreaseProgress(0.0, status);
			uint num = global::System.Convert.ToUInt32(address);
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPSetEraseRange sbepsetEraseRange = new global::Motorola.Common.Communication.SBEPSetEraseRange(this._transport, num, num + size);
				sbepsetEraseRange.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepsetEraseRange.OperationResult);
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPEraseFlash sbeperaseFlash = new global::Motorola.Common.Communication.SBEPEraseFlash(this._transport);
				sbeperaseFlash.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbeperaseFlash.OperationResult);
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in _EraseFlash(string address, uint size)");
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00008B00 File Offset: 0x00006D00
		private bool IsForceHwId()
		{
			string value = global::Motorola.Common.Communication.TetraUtility.OptionsDatabaseSingleton.Instance.GetValue(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.OPTIONS_SERVICE_SECTION, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.OPT_FORCE_HWID);
			return value == true.ToString();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00008B38 File Offset: 0x00006D38
		private uint ForceHwIdValue()
		{
			string value = global::Motorola.Common.Communication.TetraUtility.OptionsDatabaseSingleton.Instance.GetValue(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.OPTIONS_SERVICE_SECTION, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.OPT_HWID_VALUE);
			uint result;
			if (string.IsNullOrEmpty(value))
			{
				result = 0U;
			}
			else
			{
				try
				{
					result = (uint)global::System.Convert.ToUInt16(value, 16);
				}
				catch
				{
					result = 0U;
				}
			}
			return result;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00008B94 File Offset: 0x00006D94
		private void ReadHwConfig()
		{
			try
			{
				if (this._devInfo.HwID == 0U)
				{
					this._devInfo.HwConfigList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.HwConfigSection>(this.DoGetHwConfig());
					global::Motorola.Common.Communication.CommonUtil.HwConfigSection hwConfigSection = this._devInfo.HwConfigList.Find((global::Motorola.Common.Communication.CommonUtil.HwConfigSection it) => it.SectionType == 0);
					if (hwConfigSection == null)
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "can't find hwid section");
					}
					if (this.IsForceHwId())
					{
						uint num = this.ForceHwIdValue();
						if (num != 0U)
						{
							this._devInfo.HwID = this.ForceHwIdValue();
						}
						else
						{
							this._devInfo.HwID = global::System.Convert.ToUInt32(hwConfigSection.Value);
						}
					}
					else
					{
						this._devInfo.HwID = global::System.Convert.ToUInt32(hwConfigSection.Value);
					}
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, this.RadioProfile.Path, ex.ErrorID, new object[0]);
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
					{
						ex
					});
				}
				this._devInfo.HwID = 0U;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, this.RadioProfile.Path, "Generic Error", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex2
				});
				this._devInfo.HwID = 0U;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00008D3C File Offset: 0x00006F3C
		private void UpdateToFinalStatus(global::Motorola.Common.Communication.CommonUtil.ProgressStatus status)
		{
			if (status != global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP)
			{
				switch (status)
				{
				case global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLLP:
					this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteLLPDone);
					return;
				case global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteLLPDone:
					break;
				case global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages:
					this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteLanguagesDone);
					return;
				default:
					if (status == global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingBootData)
					{
						this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingBootDataDone);
						return;
					}
					break;
				}
				this.IncreaseProgress(0.0, status);
				return;
			}
			this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00008DC2 File Offset: 0x00006FC2
		public void UpdateIMEType(byte ime)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00008DC9 File Offset: 0x00006FC9
		public void UpdateDateCode(byte[] datecode, ushort source)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000048 RID: 72
		protected const uint RELESE_ID_POINTER_NGCH_NMM = 201654336U;

		// Token: 0x04000049 RID: 73
		protected const uint RELESE_ID_POINTER_NGCH_VNM = 202506304U;

		// Token: 0x0400004A RID: 74
		protected const uint MAX_NUMBER_FLASH_PACKS_WITHOUT_LLP = 39U;

		// Token: 0x0400004B RID: 75
		protected const uint MAX_NUMBER_LANGUAGE_PACKS = 18U;

		// Token: 0x0400004C RID: 76
		protected global::Motorola.Common.Communication.CommonUtil.DeviceMode _switchedRadioMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;

		// Token: 0x0400004D RID: 77
		protected global::Motorola.Common.Communication.CommonUtil.TetraRadioType _switchedRadioType;

		// Token: 0x0400004E RID: 78
		private global::System.Threading.AutoResetEvent _cancelSignal = new global::System.Threading.AutoResetEvent(false);

		// Token: 0x0400004F RID: 79
		private int _retryNum = 2;

		// Token: 0x04000050 RID: 80
		private int _authRetriy;

		// Token: 0x04000051 RID: 81
		protected bool _disposed;

		// Token: 0x04000052 RID: 82
		protected global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe _transport;

		// Token: 0x04000053 RID: 83
		protected object _propertyAccessLock = new object();

		// Token: 0x04000054 RID: 84
		protected global::System.Threading.AutoResetEvent _radioResetEvent;

		// Token: 0x04000055 RID: 85
		protected readonly uint SERIAL_NUMBER_LENGTH = 12U;

		// Token: 0x04000056 RID: 86
		protected readonly ushort SOFTWARE_NAME_LENGTH = 14;

		// Token: 0x04000057 RID: 87
		protected readonly ushort ROOT_BLOCK_CACHE_SIZE = 1024;

		// Token: 0x04000058 RID: 88
		protected byte[] _rootBlockCache;

		// Token: 0x04000059 RID: 89
		protected bool _rootBlockIsBad;

		// Token: 0x0400005A RID: 90
		protected global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo _devInfo;

		// Token: 0x0400005B RID: 91
		protected global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo _devInfoForForceWrite;

		// Token: 0x0400005C RID: 92
		protected global::Motorola.Common.Communication.CommonUtil.RadioState _radioState;

		// Token: 0x0400005D RID: 93
		protected global::Motorola.Common.Communication.IProgressIndicator _progressIndicator;

		// Token: 0x0400005E RID: 94
		protected global::Motorola.Common.Communication.TetraUtility.ByteOrder _byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.UnInitialized;

		// Token: 0x0400005F RID: 95
		protected global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile _radioProfile;

		// Token: 0x04000060 RID: 96
		protected bool _forceWrite;

		// Token: 0x04000061 RID: 97
		protected string _recoverModelNumbel = string.Empty;

		// Token: 0x04000062 RID: 98
		protected string _recoverCPversion = "00.00";

		// Token: 0x04000063 RID: 99
		protected string _recoverSerialNumber = string.Empty;

		// Token: 0x04000064 RID: 100
		protected global::Motorola.Common.Communication.TetraUtility.ReleaseID _releaseID;

		// Token: 0x04000065 RID: 101
		protected bool _bCancelIO;

		// Token: 0x04000066 RID: 102
		protected global::System.Collections.Generic.List<string> NeedRetryExceptionList = new global::System.Collections.Generic.List<string>
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC.RD1001_PR_CommErrSBEPBadWriteReply.ToString(),
			global::Motorola.Common.Communication.CommonUtil.CommRC.RD1004_PR_CommErrSBEPMSGCheckSumError.ToString(),
			global::Motorola.Common.Communication.CommonUtil.CommRC.RD1005_PR_CommErrSBEPMSGWrongFormat.ToString()
		};

		// Token: 0x04000067 RID: 103
		protected readonly string _retryStr = " Will try it again.";
	}
}
