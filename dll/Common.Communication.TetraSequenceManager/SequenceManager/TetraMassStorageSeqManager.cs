using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using ICSharpCode.SharpZipLib.Zip;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000013 RID: 19
	public class TetraMassStorageSeqManager : global::Motorola.Common.Communication.ICpsSequenceManager, global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation, global::System.IDisposable
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x00012120 File Offset: 0x00010320
		public TetraMassStorageSeqManager(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			this._devInfo = (devInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo);
			this._radioResetEvent = new global::System.Threading.AutoResetEvent(false);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00012152 File Offset: 0x00010352
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00012159 File Offset: 0x00010359
		public byte QueryRadioUpdateStatus()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00012160 File Offset: 0x00010360
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x000121A4 File Offset: 0x000103A4
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000121E8 File Offset: 0x000103E8
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Transport
		{
			get
			{
				global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport;
				lock (this._propertyAccessLock)
				{
					transport = this._transport;
				}
				return transport;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0001222C File Offset: 0x0001042C
		public object PropertyLock
		{
			get
			{
				return this._propertyAccessLock;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00012234 File Offset: 0x00010434
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0001223C File Offset: 0x0001043C
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo DevInfo
		{
			get
			{
				return this._devInfo;
			}
			set
			{
				this._devInfo = (value as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0001224C File Offset: 0x0001044C
		// (set) Token: 0x060001EF RID: 495 RVA: 0x000122E0 File Offset: 0x000104E0
		public string TEI
		{
			get
			{
				string tei;
				lock (this._propertyAccessLock)
				{
					if (string.IsNullOrEmpty(this._devInfo.TEI))
					{
						if (!string.IsNullOrEmpty(this.RadioProfile.DeviceInstanceID))
						{
							this._devInfo.TEI = this.RadioProfile.DeviceInstanceID;
						}
						else
						{
							this._devInfo.TEI = string.Empty;
						}
					}
					tei = this._devInfo.TEI;
				}
				return tei;
			}
			set
			{
				lock (this._propertyAccessLock)
				{
					this._devInfo.TEI = value;
				}
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00012328 File Offset: 0x00010528
		public virtual bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			return true;
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0001232C File Offset: 0x0001052C
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00012370 File Offset: 0x00010570
		public global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator
		{
			get
			{
				global::Motorola.Common.Communication.IProgressIndicator progressIndicator;
				lock (this._propertyAccessLock)
				{
					progressIndicator = this._progressIndicator;
				}
				return progressIndicator;
			}
			set
			{
				lock (this._propertyAccessLock)
				{
					this._progressIndicator = value;
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000123B4 File Offset: 0x000105B4
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x000123BC File Offset: 0x000105BC
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000123C5 File Offset: 0x000105C5
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x000123CD File Offset: 0x000105CD
		public bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x060001F7 RID: 503 RVA: 0x000123D6 File Offset: 0x000105D6
		public void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000123D8 File Offset: 0x000105D8
		public void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000123DA File Offset: 0x000105DA
		public virtual bool DifferentialWriteSupported(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			return false;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000123DD File Offset: 0x000105DD
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000123E4 File Offset: 0x000105E4
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000123EB File Offset: 0x000105EB
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			this.ConstructDeviceInfo();
			return this._devInfo.Clone() as global::Motorola.Common.Communication.CommonUtil.DeviceInfo;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00012404 File Offset: 0x00010604
		private void SwitchMassStorageRadio(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode, string tei)
		{
			if (mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.CHARGING && mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
			}
			if (string.IsNullOrEmpty(this.RadioProfile.Path))
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "Radio profile path is empty");
			}
			global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem massStorageSwitchItem = global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.MsSwitchInfo.FindMassStorageSwitchInfo(this.TEI);
			if (massStorageSwitchItem == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("TetraMassStorageSeqManager.SwitchMassStorageRadio: Cannot find switch mode information");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD6006_MS_CommErrSwitchModeFail.ToString());
			}
			global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.MsSwitchInfo.WaitForMassStorageSwitchTimer();
			string text = this.RadioProfile.Path.Substring(0, 1);
			massStorageSwitchItem.DiskName = text;
			try
			{
				global::Motorola.Common.Communication.TetraUtility.TetraUtil.EjectMassStorageDevice(text, 10);
			}
			catch
			{
				throw;
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000124D8 File Offset: 0x000106D8
		public virtual void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			string text = "TetraMassStorageSeqManager.SwitchMode";
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).USBHubInstance, "TetraMassStorageSeqManager.SwitchMode()");
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).USBHubInstance, "USB Location is " + this.Profile.PhysicalLocation);
			try
			{
				text = string.Format("TetraMassStorageSeqManager.SwitchMode from mode {0} to mode {1}", this.Profile.DeviceMode, mode);
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel(text);
				global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.DeviceAttached += this.Instance_DeviceChanged;
				this._radioResetEvent.Reset();
				string empty = string.Empty;
				global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode = this.Profile.DeviceMode;
				if (deviceMode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.MASS_STORAGE)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
				}
				this.SwitchMassStorageRadio(mode, this.TEI);
				if (mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.RP)
				{
					this.WaitForRadioReset();
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, (this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).USBHubInstance, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, (this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).USBHubInstance, "Generic exception", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.MsSwitchInfo.RemoveRadioForMassStorageSwitch(this.TEI);
				global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.DeviceAttached -= this.Instance_DeviceChanged;
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance(text, "");
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).USBHubInstance, "Leave TetraMassStorageSeqManager.SwitchMode()");
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).USBHubInstance, "USB Location is " + this.Profile.PhysicalLocation);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00012720 File Offset: 0x00010920
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			this.ConstructDeviceInfo();
			return this._devInfo.Clone() as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00012738 File Offset: 0x00010938
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0001273F File Offset: 0x0001093F
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00012746 File Offset: 0x00010946
		public void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0001274D File Offset: 0x0001094D
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00012754 File Offset: 0x00010954
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0001275B File Offset: 0x0001095B
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00012762 File Offset: 0x00010962
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00012769 File Offset: 0x00010969
		public void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00012770 File Offset: 0x00010970
		public void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00012777 File Offset: 0x00010977
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0001277E File Offset: 0x0001097E
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00012785 File Offset: 0x00010985
		public void UpdateMACAddress(byte[] macAddress)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0001278C File Offset: 0x0001098C
		public void WaitForCancelReading()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00012793 File Offset: 0x00010993
		public void SwitchModeNoWait(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0001279C File Offset: 0x0001099C
		public virtual void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode commandCode, byte[] inputBuffer, out byte[] outputBuffer)
		{
			outputBuffer = null;
			try
			{
				if (commandCode <= global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.OPEN_COMMUNICATION_PIPE)
				{
					if (commandCode == global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SWITCH_MODE_NO_WAIT)
					{
						global::Motorola.Common.Communication.CommonUtil.DeviceMode mode = (global::Motorola.Common.Communication.CommonUtil.DeviceMode)this.DeserializeBinary(inputBuffer);
						this.SwitchModeNoWait(mode);
						goto IL_D4;
					}
					if (commandCode == global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.OPEN_COMMUNICATION_PIPE)
					{
						this.OpenPipe();
						goto IL_D4;
					}
				}
				else
				{
					if (commandCode == global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.CLOSE_COMMUNICATION_PIPE)
					{
						this.ClosePipe();
						goto IL_D4;
					}
					switch (commandCode)
					{
					case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.MS_COLLECT_PICTURES:
					{
						global::Motorola.Common.Communication.CommonUtil.PictureParameter pictureParameter = (global::Motorola.Common.Communication.CommonUtil.PictureParameter)this.DeserializeBinary(inputBuffer);
						int num = 0;
						this.CollectPicturesFromRadio(pictureParameter.FolderPath, pictureParameter.ArchiveFile, pictureParameter.bFlag, out num);
						outputBuffer = this.SerializeBinary(num);
						goto IL_D4;
					}
					case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.MS_PUSH_PICTURES:
					{
						global::Motorola.Common.Communication.CommonUtil.PictureParameter pictureParameter2 = (global::Motorola.Common.Communication.CommonUtil.PictureParameter)this.DeserializeBinary(inputBuffer);
						this.PushPicturesToRadio(pictureParameter2.FolderPath, pictureParameter2.ArchiveFile, pictureParameter2.bFlag);
						goto IL_D4;
					}
					}
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
				IL_D4:;
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
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00012928 File Offset: 0x00010B28
		public void WriteSoftware(string swFilePath, bool bResetProgress = true)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0001292F File Offset: 0x00010B2F
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00012936 File Offset: 0x00010B36
		public byte[] ReadCPData(string blockID, uint offset, ushort size)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001293D File Offset: 0x00010B3D
		public bool IsLLPAvailable()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00012944 File Offset: 0x00010B44
		public bool TurnOffRadio()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0001294B File Offset: 0x00010B4B
		public void UpgradeFlashStrap(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool bResetProgress = true)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00012952 File Offset: 0x00010B52
		public void EraseRadioFromTo(uint startAddress, uint size, bool bForceErase = false)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00012959 File Offset: 0x00010B59
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageWithProgressUpdate(string address, uint size)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00012960 File Offset: 0x00010B60
		public void WriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage, bool bResetProgress = false)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00012967 File Offset: 0x00010B67
		public global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00012970 File Offset: 0x00010B70
		// (set) Token: 0x0600021A RID: 538 RVA: 0x000129FC File Offset: 0x00010BFC
		public virtual string CpuID
		{
			get
			{
				string cpuID;
				lock (this._propertyAccessLock)
				{
					if (string.IsNullOrEmpty(this._devInfo.CpuID))
					{
						global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem massStorageSwitchItem = global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.MsSwitchInfo.FindMassStorageSwitchInfo(this.TEI);
						this._devInfo.CpuID = ((massStorageSwitchItem != null) ? massStorageSwitchItem.CpuID : string.Empty);
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00012A44 File Offset: 0x00010C44
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00012A88 File Offset: 0x00010C88
		public global::Motorola.Common.Communication.IRadioProfile Profile
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

		// Token: 0x0600021D RID: 541 RVA: 0x00012AD0 File Offset: 0x00010CD0
		public void Invalidate(bool onlyCPInfo)
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
				this._devInfo.Issi = -1;
				this._devInfo.HomeMCC = -1;
				this._devInfo.HomeMNC = -1;
				this._devInfo.CodeplugVersion = string.Empty;
				this._devInfo.SoftwareVersion = string.Empty;
				this._devInfo.PartionHealthState = -1;
				this._devInfo.RpVerInfo = null;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00012BB4 File Offset: 0x00010DB4
		public void EraseRadio(global::System.Collections.Generic.List<string> sections)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00012BBB File Offset: 0x00010DBB
		protected void OpenPipe()
		{
			if (this._transport != null)
			{
				this._transport.OpenPort();
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00012BD1 File Offset: 0x00010DD1
		protected void ClosePipe()
		{
			if (this._transport != null)
			{
				this._transport.ClosePort();
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00012BE8 File Offset: 0x00010DE8
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

		// Token: 0x06000222 RID: 546 RVA: 0x00012C44 File Offset: 0x00010E44
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

		// Token: 0x06000223 RID: 547 RVA: 0x00012C90 File Offset: 0x00010E90
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00012C9F File Offset: 0x00010E9F
		protected virtual void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			if (this._radioResetEvent != null)
			{
				this._radioResetEvent.Dispose();
				this._radioResetEvent = null;
			}
			this._disposed = true;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00012CD0 File Offset: 0x00010ED0
		~TetraMassStorageSeqManager()
		{
			this.Dispose(false);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00012D00 File Offset: 0x00010F00
		private void Instance_DeviceChanged(object sender, global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs e)
		{
			if (this._disposed)
			{
				return;
			}
			try
			{
				for (int i = 0; i < e.MsgList.Count; i++)
				{
					if (e.MsgList[i].RadioId == this.RadioProfile.RadioIdString)
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
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Exception in TetraMassStorageManager.Instance_DeviceChanged: " + ex.Message);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00012E04 File Offset: 0x00011004
		private void WaitForRadioReset()
		{
			if (!this._radioResetEvent.WaitOne(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_RESET_TIMEOUT, false))
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "TetraMassStorageSeqManager.WaitForRadioReset: reset radio timed out");
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("TetraMassStorageSeqManager.WaitForRadioReset: reset radio timed out");
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00012E44 File Offset: 0x00011044
		private void ConstructDeviceInfo()
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
				this._devInfo.TEI = this.RadioProfile.DeviceInstanceID;
				this._devInfo.UsbHubInstance = this.RadioProfile.USBHubInstance;
				this._devInfo.UsbHubPortNumber = this.RadioProfile.USBHubPortNumber;
				this._devInfo.CodeplugVersion = string.Empty;
				this._devInfo.ModelNumber = string.Empty;
				this._devInfo.SerialNumber = string.Empty;
				this._devInfo.HomeMCC = 0;
				this._devInfo.HomeMNC = 0;
				this._devInfo.Issi = 0;
				this._devInfo.SoftwareVersion = string.Empty;
				this._devInfo.PartionHealthState = 0;
				this._devInfo.HwID = 0U;
				this._devInfo.CpuType = string.Empty;
				this._devInfo.FlashID = 0U;
				this._devInfo.FlashVID = 0U;
				this._devInfo.ModelNumber = string.Empty;
			}
			catch
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Error in constructDeviceInfo().");
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000130AC File Offset: 0x000112AC
		private void UpdateProgress(double percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status)
		{
			if (this._progressIndicator != null)
			{
				this._progressIndicator.UpdateProgress(percent, status);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000130C4 File Offset: 0x000112C4
		private void CollectPicturesFromRadio(string folderPath, string destFile, bool bDelete, out int fileCount)
		{
			string path = this.RadioProfile.Path;
			string path2 = global::System.IO.Path.Combine(path, folderPath.TrimStart(new char[]
			{
				'\\',
				'/'
			}));
			global::System.IO.FileStream fileStream = null;
			long num = 0L;
			fileCount = 0;
			this.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
			if (!global::System.IO.Directory.Exists(path2))
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD6002_MS_CommErrTargetFolderNotExist.ToString());
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			string[] files = global::System.IO.Directory.GetFiles(path2, "*.jpg", global::System.IO.SearchOption.TopDirectoryOnly);
			string[] files2 = global::System.IO.Directory.GetFiles(path2, "*.jpeg", global::System.IO.SearchOption.TopDirectoryOnly);
			list.AddRange(files);
			list.AddRange(files2);
			fileCount = list.Count;
			if (fileCount == 0)
			{
				return;
			}
			foreach (string fileName in list)
			{
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(fileName);
				num += fileInfo.Length;
			}
			if (num > 1073741824L)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD6004_MS_CommErrSizeLargerThanExpected.ToString());
			}
			try
			{
				if (global::System.IO.File.Exists(destFile))
				{
					global::Motorola.Common.Communication.TetraUtility.FileSystem.DeleteFileSafe(destFile, 3);
				}
				string directoryName = global::System.IO.Path.GetDirectoryName(destFile);
				global::Motorola.Common.Communication.TetraUtility.FileSystem.CreateDirectoryIfNotExist(directoryName);
				fileStream = global::System.IO.File.Create(destFile);
				int num2 = 0;
				using (global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipOutputStream = new global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream(fileStream))
				{
					zipOutputStream.SetLevel(5);
					foreach (string path3 in list)
					{
						string fileName2 = global::System.IO.Path.GetFileName(path3);
						global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(fileName2);
						zipEntry.DateTime = global::System.DateTime.Now;
						zipOutputStream.PutNextEntry(zipEntry);
						using (global::System.IO.FileStream fileStream2 = global::System.IO.File.OpenRead(path3))
						{
							zipEntry.Size = fileStream2.Length;
							byte[] array = new byte[2097152];
							int num3;
							do
							{
								num3 = fileStream2.Read(array, 0, array.Length);
								zipOutputStream.Write(array, 0, num3);
							}
							while (num3 > 0);
							fileStream2.Close();
						}
						zipOutputStream.CloseEntry();
						num2++;
						double percent = (double)num2 / (double)fileCount;
						this.UpdateProgress(percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
					}
					this.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
					zipOutputStream.Finish();
					zipOutputStream.Close();
				}
				if (bDelete)
				{
					foreach (string filePath in list)
					{
						global::Motorola.Common.Communication.TetraUtility.FileSystem.DeleteFileSafe(filePath, 3);
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, "Exception when get picture from radio");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD6003_MS_CommErrFileOperationError.ToString(), "Exception when get picture from radio", ex);
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00013434 File Offset: 0x00011634
		public void PushPicturesToRadio(string destFolder, string sourceFile, bool bReplace)
		{
			if (!global::System.IO.File.Exists(sourceFile))
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD6005_MS_CommErrSourceFileNotExist.ToString());
			}
			string path = this.RadioProfile.Path;
			string text = global::System.IO.Path.Combine(path, destFolder);
			global::System.IO.FileStream fileStream = null;
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(sourceFile);
			long length = fileInfo.Length;
			if (length > 1073741824L)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD6004_MS_CommErrSizeLargerThanExpected.ToString());
			}
			global::System.IO.DriveInfo driveInfo = new global::System.IO.DriveInfo(path.Substring(0, 1));
			if (driveInfo.AvailableFreeSpace < length)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD6007_MS_CommErrNotEnoughSpaceForPush.ToString());
			}
			this.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage);
			if (global::System.IO.Directory.Exists(text) && bReplace && !global::Motorola.Common.Communication.TetraUtility.FileSystem.DeleteDirectorySafe(text, true))
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Delete directory failed: {0}", new object[]
				{
					text
				});
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD6003_MS_CommErrFileOperationError.ToString());
			}
			global::Motorola.Common.Communication.TetraUtility.FileSystem.CreateDirectoryIfNotExist(text);
			if (length == 0L)
			{
				this.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage);
				return;
			}
			try
			{
				fileStream = global::System.IO.File.OpenRead(sourceFile);
				using (global::ICSharpCode.SharpZipLib.Zip.ZipInputStream zipInputStream = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream(fileStream))
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipEntry nextEntry;
					while ((nextEntry = zipInputStream.GetNextEntry()) != null)
					{
						string fullPath = global::System.IO.Path.GetFullPath(global::System.IO.Path.Combine(text, global::System.IO.Path.GetDirectoryName(nextEntry.Name)));
						string fullPath2 = global::System.IO.Path.GetFullPath(global::System.IO.Path.Combine(text, nextEntry.Name));
						global::Motorola.Common.Communication.TetraUtility.FileSystem.CreateDirectoryIfNotExist(fullPath);
						if (!nextEntry.IsDirectory && (!global::System.IO.File.Exists(fullPath2) || global::Motorola.Common.Communication.TetraUtility.FileSystem.DeleteFileSafe(fullPath2, 5)))
						{
							using (global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(fullPath2, global::System.IO.FileMode.Create))
							{
								int num = 1048576;
								byte[] array = new byte[num];
								for (;;)
								{
									num = zipInputStream.Read(array, 0, array.Length);
									if (num <= 0)
									{
										break;
									}
									fileStream2.Write(array, 0, num);
								}
							}
							double percent = (double)zipInputStream.Position / (double)length;
							this.UpdateProgress(percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage);
						}
					}
					zipInputStream.Close();
					this.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage);
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, "Exception when push picture file to radio");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD6003_MS_CommErrFileOperationError.ToString(), "Exception when push picture file to radio", ex);
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
			}
		}

		// Token: 0x04000080 RID: 128
		private global::Motorola.Common.Communication.IProgressIndicator _progressIndicator;

		// Token: 0x04000081 RID: 129
		private global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe _transport;

		// Token: 0x04000082 RID: 130
		private global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile _radioProfile;

		// Token: 0x04000083 RID: 131
		private object _propertyAccessLock = new object();

		// Token: 0x04000084 RID: 132
		private global::System.Threading.AutoResetEvent _radioResetEvent;

		// Token: 0x04000085 RID: 133
		private global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo _devInfo;

		// Token: 0x04000086 RID: 134
		private global::Motorola.Common.Communication.CommonUtil.DeviceMode _switchedRadioMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;

		// Token: 0x04000087 RID: 135
		private global::Motorola.Common.Communication.CommonUtil.TetraRadioType _switchedRadioType;

		// Token: 0x04000088 RID: 136
		private bool _disposed;
	}
}
