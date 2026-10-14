using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000011 RID: 17
	public class TetraBMPATSeqManager : global::Motorola.Common.Communication.ICpsSequenceManager, global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation, global::System.IDisposable
	{
		// Token: 0x0600018B RID: 395 RVA: 0x0000FD68 File Offset: 0x0000DF68
		public TetraBMPATSeqManager(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			this._transport = (transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe);
			this._devInfo = (devInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo);
			this._radioResetEvent = new global::System.Threading.AutoResetEvent(false);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000FDC3 File Offset: 0x0000DFC3
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000FDCA File Offset: 0x0000DFCA
		public byte QueryRadioUpdateStatus()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000FDD4 File Offset: 0x0000DFD4
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0000FE18 File Offset: 0x0000E018
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

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000FE5C File Offset: 0x0000E05C
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		public object PropertyLock
		{
			get
			{
				return this._propertyAccessLock;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000FEA8 File Offset: 0x0000E0A8
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0000FEB0 File Offset: 0x0000E0B0
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

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000FEC0 File Offset: 0x0000E0C0
		// (set) Token: 0x06000195 RID: 405 RVA: 0x0000FF2C File Offset: 0x0000E12C
		public string TEI
		{
			get
			{
				string tei;
				lock (this._propertyAccessLock)
				{
					if (string.IsNullOrEmpty(this._devInfo.TEI))
					{
						this._devInfo.TEI = string.Empty;
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

		// Token: 0x06000196 RID: 406 RVA: 0x0000FF74 File Offset: 0x0000E174
		public virtual bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			return true;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000FF78 File Offset: 0x0000E178
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0000FFBC File Offset: 0x0000E1BC
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00010000 File Offset: 0x0000E200
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00010008 File Offset: 0x0000E208
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00010011 File Offset: 0x0000E211
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00010019 File Offset: 0x0000E219
		public bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x0600019D RID: 413 RVA: 0x00010022 File Offset: 0x0000E222
		public void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			this._transport.OpenPort();
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00010030 File Offset: 0x0000E230
		public void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			this._transport.ClosePort();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001003D File Offset: 0x0000E23D
		public virtual bool DifferentialWriteSupported(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			return false;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00010040 File Offset: 0x0000E240
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00010047 File Offset: 0x0000E247
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001004E File Offset: 0x0000E24E
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			this.ConstructDeviceInfo();
			return this._devInfo.Clone() as global::Motorola.Common.Communication.CommonUtil.DeviceInfo;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00010068 File Offset: 0x0000E268
		public virtual void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			string text = "TetraBMPATSeqManager.SwitchMode";
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "TetraBMPATSeqManager.SwitchMode()");
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "USB Location is " + this.Profile.PhysicalLocation);
			try
			{
				text = string.Format("TetraBMPATSeqManager.SwitchMode from mode {0} to mode {1}", this.Profile.DeviceMode, mode);
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel(text);
				global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.DeviceAttached += this.Instance_DeviceChanged;
				this._radioResetEvent.Reset();
				string empty = string.Empty;
				switch (this.Profile.DeviceMode)
				{
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL:
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.CHARGING:
					if (mode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP || mode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL)
					{
						this.ATResetRadioToProgMode(true);
					}
					else if (mode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.MASS_STORAGE)
					{
						if (string.IsNullOrEmpty(this.TEI))
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "TEI is empty for mass storage switch");
						}
						global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem info = new global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem(this.TEI, this.CpuID, this.RadioProfile.PhysicalLocation, this.RadioProfile.UniqueLocation, this.RadioProfile.Path, "");
						global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.MsSwitchInfo.AddRadioForMassStorageSwitch(info);
						global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.MsSwitchInfo.WaitForMassStorageSwitchTimer();
						global::Motorola.Common.Communication.CommonUtil.CommRC commRC = this.ATResetRadioToMassStorageMode();
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "AT command result: " + commRC.ToString());
						if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD1041_PR_CommErrATDeviceIsBusy)
						{
							int num = 5;
							while (num-- > 0)
							{
								global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "Device is busy for AT switch mass-storage mode, retry");
								global::System.Threading.Thread.Sleep(500);
								commRC = this.ATResetRadioToMassStorageMode();
								if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD1041_PR_CommErrATDeviceIsBusy)
								{
									break;
								}
							}
						}
						if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
						{
							global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.MsSwitchInfo.RemoveRadioForMassStorageSwitch(this.TEI);
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD6006_MS_CommErrSwitchModeFail.ToString(), "Switch mass storage AT command fail: " + commRC.ToString());
						}
					}
					else if (mode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.RP)
					{
					}
					if (mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.RP)
					{
						this.WaitForRadioReset();
					}
					if (mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.RP && this._switchedRadioMode != mode)
					{
						if (this._switchedRadioType != global::Motorola.Common.Communication.CommonUtil.TetraRadioType.NORMAL || mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.CHARGING)
						{
							if (mode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.MASS_STORAGE)
							{
								global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.MsSwitchInfo.RemoveRadioForMassStorageSwitch(this.TEI);
							}
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
						}
						if (this._switchedRadioMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL)
						{
						}
					}
					break;
				default:
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, (this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, (this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "Generic exception", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.DeviceAttached -= this.Instance_DeviceChanged;
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance(text, "");
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "Leave TetraBMPATSeqManager.SwitchMode()");
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "USB Location is " + this.Profile.PhysicalLocation);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00010440 File Offset: 0x0000E640
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			this.ConstructDeviceInfo();
			return this._devInfo.Clone() as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00010458 File Offset: 0x0000E658
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001045F File Offset: 0x0000E65F
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00010466 File Offset: 0x0000E666
		public void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001046D File Offset: 0x0000E66D
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00010474 File Offset: 0x0000E674
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001047B File Offset: 0x0000E67B
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00010482 File Offset: 0x0000E682
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00010489 File Offset: 0x0000E689
		public void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00010490 File Offset: 0x0000E690
		public void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00010497 File Offset: 0x0000E697
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0001049E File Offset: 0x0000E69E
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000104A5 File Offset: 0x0000E6A5
		public void UpdateMACAddress(byte[] macAddress)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000104AC File Offset: 0x0000E6AC
		public void SwitchModeNoWait(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			string text = "TetraBMPATSeqManager.SwitchModeNoWait";
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "TetraBMPATSeqManager.SwitchModeNoWait()");
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "USB Location is " + this.Profile.PhysicalLocation);
			try
			{
				text = string.Format("TetraBMPATSeqManager.SwitchMode from mode {0} to mode {1}", this.RadioProfile.DeviceMode, mode);
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel(text);
				switch (this.RadioProfile.DeviceMode)
				{
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL:
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.CHARGING:
					if (mode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP || mode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL)
					{
						this.ATResetRadioToProgMode(true);
					}
					else if (mode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.RP)
					{
					}
					break;
				default:
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
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
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance(text, "");
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Leave TetraBMPATSeqManager.SwitchModeNoWait()");
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "USB Location is " + this.Profile.PhysicalLocation);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00010670 File Offset: 0x0000E870
		public virtual void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode commandCode, byte[] inputBuffer, out byte[] outputBuffer)
		{
			outputBuffer = null;
			try
			{
				switch (commandCode)
				{
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.RP_GET_INDICATION:
				{
					global::Motorola.Common.Communication.CommonUtil.RPStatusIndicationInfo rpstatusIndicationInfo = new global::Motorola.Common.Communication.CommonUtil.RPStatusIndicationInfo();
					this.GetRPIndication(rpstatusIndicationInfo);
					outputBuffer = this.SerializeBinary(rpstatusIndicationInfo);
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.RP_SEND_VERSION_REPLY:
				{
					global::Motorola.Common.Communication.CommonUtil.CommRC commRC = this.SendVerReqReply();
					outputBuffer = this.SerializeBinary(commRC);
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.RP_GET_TERMINAL_ID:
				{
					global::Motorola.Common.Communication.CommonUtil.RPTerminalIDInfo rpterminalIDInfo = new global::Motorola.Common.Communication.CommonUtil.RPTerminalIDInfo();
					this.RPGetTerminalID(rpterminalIDInfo);
					outputBuffer = this.SerializeBinary(rpterminalIDInfo);
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.RP_GET_VERSION_INFO:
				{
					global::Motorola.Common.Communication.CommonUtil.RPVersionInfo request = new global::Motorola.Common.Communication.CommonUtil.RPVersionInfo();
					this.GetRPVersionInfo(out request);
					outputBuffer = this.SerializeBinary(request);
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SWITCH_MODE_NO_WAIT:
				{
					global::Motorola.Common.Communication.CommonUtil.DeviceMode mode = (global::Motorola.Common.Communication.CommonUtil.DeviceMode)this.DeserializeBinary(inputBuffer);
					this.SwitchModeNoWait(mode);
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.OPEN_COMMUNICATION_PIPE:
					this.OpenPipe();
					goto IL_361;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_CUSTOM_MESSAGE:
				{
					string msg = (string)this.DeserializeBinary(inputBuffer);
					string empty = string.Empty;
					global::Motorola.Common.Communication.CommonUtil.CommRC operationResult = this.ATExecuteCustomMessage(msg, out empty);
					outputBuffer = this.SerializeBinary(new global::Motorola.Common.Communication.CommonUtil.CustomerATMsg
					{
						OperationResult = operationResult,
						CustomerMsg = empty
					});
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_GET_BATTERY_STATUS:
				{
					global::Motorola.Common.Communication.CommonUtil.BatteryStatus batteryStatus = new global::Motorola.Common.Communication.CommonUtil.BatteryStatus();
					int bcl = 0;
					int bcs = 0;
					global::Motorola.Common.Communication.CommonUtil.CommRC operationResult2 = this.ATGetBatteryStatus(out bcs, out bcl);
					batteryStatus.BCL = bcl;
					batteryStatus.BCS = bcs;
					batteryStatus.OperationResult = operationResult2;
					outputBuffer = this.SerializeBinary(batteryStatus);
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_GET_DEVICE_MODE:
				{
					global::Motorola.Common.Communication.CommonUtil.DeviceMode devMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
					global::Motorola.Common.Communication.CommonUtil.CommRC operationResult3 = this.ATGetDeviceMode(out devMode);
					outputBuffer = this.SerializeBinary(new global::Motorola.Common.Communication.CommonUtil.ATDeviceMode
					{
						DevMode = devMode,
						OperationResult = operationResult3
					});
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_GET_EMERGENCY_STATUS:
				{
					bool inEmergency = false;
					global::Motorola.Common.Communication.CommonUtil.CommRC operationResult4 = this.ATReadEmergencyStatus(out inEmergency);
					outputBuffer = this.SerializeBinary(new global::Motorola.Common.Communication.CommonUtil.ATEmergencyStatus
					{
						OperationResult = operationResult4,
						InEmergency = inEmergency
					});
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_GET_RADIO_INFO:
				{
					global::Motorola.Common.Communication.CommonUtil.RadioManuInfo radioATInfo = null;
					global::Motorola.Common.Communication.CommonUtil.CommRC operationResult5 = this.ATGetRadioInfo(out radioATInfo);
					outputBuffer = this.SerializeBinary(new global::Motorola.Common.Communication.CommonUtil.ATRadioManuInfo
					{
						RadioATInfo = radioATInfo,
						OperationResult = operationResult5
					});
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_RESET_TO_PROGMODE:
				{
					bool rpProg = (bool)this.DeserializeBinary(inputBuffer);
					global::Motorola.Common.Communication.CommonUtil.CommRC commRC2 = this.ATResetRadioToProgMode(rpProg);
					outputBuffer = this.SerializeBinary(commRC2);
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_SET_RP_STATE:
				{
					global::Motorola.Common.Communication.CommonUtil.RPDeivceState rpState = (global::Motorola.Common.Communication.CommonUtil.RPDeivceState)this.DeserializeBinary(inputBuffer);
					global::Motorola.Common.Communication.CommonUtil.CommRC commRC3 = this.ATSetRPState(rpState);
					outputBuffer = this.SerializeBinary(commRC3);
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.CLOSE_COMMUNICATION_PIPE:
					this.ClosePipe();
					goto IL_361;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_GET_DMS:
				{
					string accessCode = (string)this.DeserializeBinary(inputBuffer);
					string empty2 = string.Empty;
					global::Motorola.Common.Communication.CommonUtil.CommRC operationResult6 = this.ATGetDMS(accessCode, out empty2);
					outputBuffer = this.SerializeBinary(new global::Motorola.Common.Communication.CommonUtil.CustomerATMsg
					{
						OperationResult = operationResult6,
						CustomerMsg = empty2
					});
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_ERASE_DMS:
				{
					string accessCode2 = (string)this.DeserializeBinary(inputBuffer);
					global::Motorola.Common.Communication.CommonUtil.CommRC commRC4 = this.ATEraseDMS(accessCode2);
					outputBuffer = this.SerializeBinary(commRC4);
					goto IL_361;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_CHANGE_DMS_CODE:
				{
					global::Motorola.Common.Communication.CommonUtil.ATChangeDMSCodeInfo atchangeDMSCodeInfo = (global::Motorola.Common.Communication.CommonUtil.ATChangeDMSCodeInfo)this.DeserializeBinary(inputBuffer);
					global::Motorola.Common.Communication.CommonUtil.CommRC commRC5 = this.ATChangeDMSAccessCode(atchangeDMSCodeInfo.AccessCode, atchangeDMSCodeInfo.DefaultAccessCode);
					outputBuffer = this.SerializeBinary(commRC5);
					goto IL_361;
				}
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
				IL_361:;
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

		// Token: 0x060001B3 RID: 435 RVA: 0x00010AA4 File Offset: 0x0000ECA4
		public void WriteSoftware(string swFilePath, bool bResetProgress = true)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00010AAB File Offset: 0x0000ECAB
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00010AB2 File Offset: 0x0000ECB2
		public byte[] ReadCPData(string blockID, uint offset, ushort size)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00010AB9 File Offset: 0x0000ECB9
		public bool IsLLPAvailable()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00010AC0 File Offset: 0x0000ECC0
		public bool TurnOffRadio()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00010AC7 File Offset: 0x0000ECC7
		public void UpgradeFlashStrap(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool bResetProgress = true)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00010ACE File Offset: 0x0000ECCE
		public void EraseRadioFromTo(uint startAddress, uint size, bool bForceErase = false)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00010AD5 File Offset: 0x0000ECD5
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageWithProgressUpdate(string address, uint size)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00010ADC File Offset: 0x0000ECDC
		public void WriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage, bool bResetProgress = false)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00010AE3 File Offset: 0x0000ECE3
		public global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00010AEC File Offset: 0x0000ECEC
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00010B30 File Offset: 0x0000ED30
		public virtual string CpuID
		{
			get
			{
				string cpuID;
				lock (this._propertyAccessLock)
				{
					cpuID = this.GetCpuID();
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

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00010B78 File Offset: 0x0000ED78
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00010BBC File Offset: 0x0000EDBC
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

		// Token: 0x060001C1 RID: 449 RVA: 0x00010C04 File Offset: 0x0000EE04
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

		// Token: 0x060001C2 RID: 450 RVA: 0x00010CE8 File Offset: 0x0000EEE8
		public void EraseRadio(global::System.Collections.Generic.List<string> sections)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00010CEF File Offset: 0x0000EEEF
		public virtual void WaitForCancelReading()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00010CF6 File Offset: 0x0000EEF6
		protected void OpenPipe()
		{
			if (this._transport != null)
			{
				this._transport.OpenPort();
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00010D0C File Offset: 0x0000EF0C
		protected void ClosePipe()
		{
			if (this._transport != null)
			{
				this._transport.ClosePort();
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00010D24 File Offset: 0x0000EF24
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

		// Token: 0x060001C7 RID: 455 RVA: 0x00010D80 File Offset: 0x0000EF80
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

		// Token: 0x060001C8 RID: 456 RVA: 0x00010DCC File Offset: 0x0000EFCC
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00010DDB File Offset: 0x0000EFDB
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

		// Token: 0x060001CA RID: 458 RVA: 0x00010E0C File Offset: 0x0000F00C
		~TetraBMPATSeqManager()
		{
			this.Dispose(false);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00010E3C File Offset: 0x0000F03C
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
						if (e.MsgList[i].DevMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL || e.MsgList[i].DevMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.CHARGING || e.MsgList[i].DevMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL || e.MsgList[i].DevMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.MASS_STORAGE)
						{
							this._radioResetEvent.Set();
							break;
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Exception in TetraBMPATManager.Instance_DeviceChanged: " + ex.Message);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00010F58 File Offset: 0x0000F158
		private void WaitForRadioReset()
		{
			if (!this._radioResetEvent.WaitOne(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_RESET_TIMEOUT, false))
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "TetraBMPATSeqManager.WaitForRadioReset: reset radio timed out");
				if (this.Transport != null && (this.Transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).Reliable)
				{
					global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS statusCode = global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.NoDeviceConnected;
					if (global::Motorola.Common.Communication.TetraUtility.USBDiagnose.GetUSBPortStatus(this.RadioProfile.USBHubInstance, this.RadioProfile.USBHubPortNumber, this.RadioProfile.Path, out statusCode))
					{
						string str = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.ConnectionStatusCodeToStr(statusCode);
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Connection Status is: " + str);
					}
				}
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("TetraBMPATSeqManager.WaitForRadioReset: reset radio timed out");
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00011010 File Offset: 0x0000F210
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
				this._devInfo.TEI = this.TEI;
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
				int bcs = 0;
				int batteryLevel = 0;
				if (this.ATGetBatteryStatus(out bcs, out batteryLevel) == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					this._devInfo.PowerStatus = this.GetPowerSupplyEnumValue(bcs);
					this._devInfo.BatteryLevel = batteryLevel;
				}
			}
			catch
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Error in constructDeviceInfo().");
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000112A4 File Offset: 0x0000F4A4
		private string GetCpuID()
		{
			try
			{
				if (string.IsNullOrEmpty(this._devInfo.CpuID))
				{
					int num = 5;
					global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
					while (num-- > 0)
					{
						global::Motorola.Common.Communication.CommonUtil.RadioManuInfo radioManuInfo = null;
						commRC = this.ATGetRadioInfo(out radioManuInfo);
						if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
						{
							this._devInfo.CpuID = radioManuInfo.cpuID;
							break;
						}
						global::System.Threading.Thread.Sleep(1000);
					}
					if (string.IsNullOrEmpty(this._devInfo.CpuID))
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString(), "Get CPU ID via AT Command Failed");
					}
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, (this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, ex.ErrorID, new object[0]);
				this._devInfo.CpuID = string.Empty;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex2
				});
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, (this.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "Generic Error", new object[0]);
				this._devInfo.CpuID = string.Empty;
			}
			return this._devInfo.CpuID;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00011408 File Offset: 0x0000F608
		protected global::Motorola.Common.Communication.CommonUtil.CommRC ATResetRadioToProgMode(bool rpProg)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				try
				{
					using (global::Motorola.Common.Communication.ATResetToProgMode atresetToProgMode = new global::Motorola.Common.Communication.ATResetToProgMode(this._transport, rpProg))
					{
						atresetToProgMode.ExecuteMessage();
						commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(atresetToProgMode.OperationResult);
					}
				}
				catch (global::System.OverflowException e)
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "OverflowException in ATResetRadioToMassStorageMode");
				}
			}
			return commRC;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00011488 File Offset: 0x0000F688
		private global::Motorola.Common.Communication.CommonUtil.CommRC ATExecuteCustomMessage(string msg, out string reply)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			reply = string.Empty;
			if (this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.ATCustomMessage atcustomMessage = new global::Motorola.Common.Communication.ATCustomMessage(this._transport, msg))
				{
					atcustomMessage.ExecuteMessage();
					reply = atcustomMessage.ReplyStr;
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(atcustomMessage.OperationResult);
				}
			}
			return commRC;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000114F0 File Offset: 0x0000F6F0
		private global::Motorola.Common.Communication.CommonUtil.CommRC ATReadEmergencyStatus(out bool bInEmergency)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			bInEmergency = false;
			if (this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.ATGetEmergencyStatus atgetEmergencyStatus = new global::Motorola.Common.Communication.ATGetEmergencyStatus(this._transport))
				{
					atgetEmergencyStatus.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(atgetEmergencyStatus.OperationResult);
					bInEmergency = atgetEmergencyStatus.IsEmergencyMode;
				}
			}
			return commRC;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00011554 File Offset: 0x0000F754
		private global::Motorola.Common.Communication.CommonUtil.CommRC ATGetDeviceMode(out global::Motorola.Common.Communication.CommonUtil.DeviceMode devMode)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			devMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
			if (this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.ATGetDeviceMode atgetDeviceMode = new global::Motorola.Common.Communication.ATGetDeviceMode(this._transport))
				{
					atgetDeviceMode.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(atgetDeviceMode.OperationResult);
					devMode = atgetDeviceMode.DevMode;
				}
			}
			return commRC;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000115B8 File Offset: 0x0000F7B8
		private global::Motorola.Common.Communication.CommonUtil.CommRC ATSetRPState(global::Motorola.Common.Communication.CommonUtil.RPDeivceState rpState)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.ATSetRPState atsetRPState = new global::Motorola.Common.Communication.ATSetRPState(this._transport, rpState))
				{
					atsetRPState.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(atsetRPState.OperationResult);
				}
			}
			return commRC;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00011610 File Offset: 0x0000F810
		private global::Motorola.Common.Communication.CommonUtil.CommRC ATGetBatteryStatus(out int bcs, out int bcl)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			bcs = (bcl = 0);
			if (this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.ATGetBatteryStatus atgetBatteryStatus = new global::Motorola.Common.Communication.ATGetBatteryStatus(this._transport))
				{
					atgetBatteryStatus.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(atgetBatteryStatus.OperationResult);
					bcs = atgetBatteryStatus.BCS;
					bcl = atgetBatteryStatus.BCL;
				}
			}
			return commRC;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00011680 File Offset: 0x0000F880
		private global::Motorola.Common.Communication.CommonUtil.CommRC ATGetRadioInfo(out global::Motorola.Common.Communication.CommonUtil.RadioManuInfo radioInfo)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			radioInfo = null;
			if (this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.ATGetRadioInfo atgetRadioInfo = new global::Motorola.Common.Communication.ATGetRadioInfo(this._transport))
				{
					atgetRadioInfo.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(atgetRadioInfo.OperationResult);
					radioInfo = atgetRadioInfo.RadioInfo;
				}
			}
			return commRC;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000116E4 File Offset: 0x0000F8E4
		private global::Motorola.Common.Communication.CommonUtil.CommRC ATResetRadioToMassStorageMode()
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				try
				{
					using (global::Motorola.Common.Communication.ATResetRadioToMassStorage atresetRadioToMassStorage = new global::Motorola.Common.Communication.ATResetRadioToMassStorage(this._transport))
					{
						atresetRadioToMassStorage.ExecuteMessage();
						commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(atresetRadioToMassStorage.OperationResult);
					}
				}
				catch (global::System.OverflowException e)
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "OverflowException in ATResetRadioToMassStorageMode");
				}
			}
			return commRC;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00011764 File Offset: 0x0000F964
		private global::Motorola.Common.Communication.CommonUtil.CommRC ATGetDMS(string accessCode, out string dmsData)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			dmsData = string.Empty;
			if (this._transport == null || accessCode.Length != 8)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.ATGetDMS atgetDMS = new global::Motorola.Common.Communication.ATGetDMS(this._transport, accessCode))
				{
					atgetDMS.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(atgetDMS.OperationResult);
					dmsData = atgetDMS.DMSData;
				}
			}
			return commRC;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000117D4 File Offset: 0x0000F9D4
		private global::Motorola.Common.Communication.CommonUtil.CommRC ATEraseDMS(string accessCode)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (this._transport == null || accessCode.Length != 8)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.ATEraseDMS ateraseDMS = new global::Motorola.Common.Communication.ATEraseDMS(this._transport, accessCode))
				{
					ateraseDMS.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(ateraseDMS.OperationResult);
				}
			}
			return commRC;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00011838 File Offset: 0x0000FA38
		private global::Motorola.Common.Communication.CommonUtil.CommRC ATChangeDMSAccessCode(string accessCode, string defaultAccessCode)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (this._transport == null || accessCode.Length != 8)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.ATChangeDMSAccessCode atchangeDMSAccessCode = new global::Motorola.Common.Communication.ATChangeDMSAccessCode(this._transport, accessCode, defaultAccessCode))
				{
					atchangeDMSAccessCode.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(atchangeDMSAccessCode.OperationResult);
				}
			}
			return commRC;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0001189C File Offset: 0x0000FA9C
		private global::Motorola.Common.Communication.CommonUtil.PowerSupplyStatus GetPowerSupplyEnumValue(int bcs)
		{
			global::Motorola.Common.Communication.CommonUtil.PowerSupplyStatus result;
			switch (bcs)
			{
			case 0:
				result = global::Motorola.Common.Communication.CommonUtil.PowerSupplyStatus.POWERED_BY_BATTERY_AND_NO_CHARGER;
				break;
			case 1:
				result = global::Motorola.Common.Communication.CommonUtil.PowerSupplyStatus.POWERED_BY_DC_AND_BATTERY_IS_CHARGING;
				break;
			case 2:
				result = global::Motorola.Common.Communication.CommonUtil.PowerSupplyStatus.POWERED_BY_DC_ONLY_AND_NO_BATTERY;
				break;
			case 3:
				result = global::Motorola.Common.Communication.CommonUtil.PowerSupplyStatus.RECOGNIZE_FAILED;
				break;
			default:
				result = global::Motorola.Common.Communication.CommonUtil.PowerSupplyStatus.UN_DEFINED;
				break;
			}
			return result;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000118D8 File Offset: 0x0000FAD8
		private void GetRPIndication(global::Motorola.Common.Communication.CommonUtil.RPStatusIndicationInfo statusIndicationInfo)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
			string empty = string.Empty;
			if (statusIndicationInfo == null)
			{
				statusIndicationInfo = new global::Motorola.Common.Communication.CommonUtil.RPStatusIndicationInfo();
			}
			try
			{
				bool flag = true;
				int num = 0;
				int num2 = 0;
				if (this.ATGetBatteryStatus(out num, out num2) == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					switch (num)
					{
					case 0:
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD1055_PR_CommErrATChargerNotConnected;
						flag = false;
						break;
					case 1:
						if (num2 >= 60)
						{
							commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
						}
						else
						{
							commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD1032_PR_CommErrRPRejectBadBattery;
							flag = false;
						}
						break;
					case 2:
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
						break;
					case 3:
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD1032_PR_CommErrRPRejectBadBattery;
						flag = false;
						break;
					default:
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD1029_PR_CommErrRPReadTimeout;
						flag = false;
						break;
					}
				}
				else
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("AT command +CBC failed in GetRPIndication");
					commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD1029_PR_CommErrRPReadTimeout;
					flag = false;
				}
				if (flag && this.RadioProfile.DeviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL)
				{
					bool flag2 = false;
					if (this.ATReadEmergencyStatus(out flag2) == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && flag2)
					{
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD1033_PR_CommErrRPRejectRPEmergency;
						flag = false;
					}
				}
				if (flag)
				{
					global::Motorola.Common.Communication.CommonUtil.RadioManuInfo radioManuInfo = null;
					if (this.ATGetRadioInfo(out radioManuInfo) == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
					{
						statusIndicationInfo.TerminalId = radioManuInfo.TEI;
						if (string.IsNullOrEmpty(statusIndicationInfo.TerminalId))
						{
							commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD1034_PR_CommErrRPInvalidID;
							goto IL_17B;
						}
						global::Motorola.Common.Communication.CommonUtil.CommRC commRC2 = this.ATGetDeviceMode(out deviceMode);
						if (commRC2 != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
						{
							statusIndicationInfo.DevMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL;
						}
						statusIndicationInfo.DevMode = deviceMode;
						try
						{
							statusIndicationInfo.Status = (global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus)deviceMode;
						}
						catch
						{
							statusIndicationInfo.Status = global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus.RP_STATUS_UNKNOWN;
						}
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
						lock (this._propertyAccessLock)
						{
							this._devInfo.TEI = statusIndicationInfo.TerminalId;
							this._rpCpuID = radioManuInfo.cpuID;
							this._rpDevMode = deviceMode;
							if (deviceMode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN)
							{
								this.Profile.DeviceMode = deviceMode;
							}
							goto IL_17B;
						}
					}
					commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD1034_PR_CommErrRPInvalidID;
				}
				IL_17B:;
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex2
				});
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::System.Threading.Thread.Sleep(1000);
			}
			else
			{
				this.ATSetRPState(global::Motorola.Common.Communication.CommonUtil.RPDeivceState.ORANGE_SYNCHRONIZING);
			}
			statusIndicationInfo.OperationResult = commRC;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00011B50 File Offset: 0x0000FD50
		private global::Motorola.Common.Communication.CommonUtil.CommRC RPGetTerminalID(out string cpuID, out string pairedCpuID, out string chSN, out string chDieID, out global::Motorola.Common.Communication.CommonUtil.RPTerminalType terminalType)
		{
			pairedCpuID = string.Empty;
			chSN = string.Empty;
			chDieID = string.Empty;
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC2 = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			if (string.IsNullOrEmpty(this._rpCpuID))
			{
				global::Motorola.Common.Communication.CommonUtil.RadioManuInfo radioManuInfo = null;
				commRC = this.ATGetRadioInfo(out radioManuInfo);
				if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					cpuID = (this._rpCpuID = radioManuInfo.cpuID);
				}
				else
				{
					cpuID = string.Empty;
				}
			}
			else
			{
				cpuID = this._rpCpuID;
			}
			if (this._rpDevMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN)
			{
				commRC2 = this.ATGetDeviceMode(out this._rpDevMode);
				if (commRC2 != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					goto IL_9A;
				}
				try
				{
					terminalType = (global::Motorola.Common.Communication.CommonUtil.RPTerminalType)this._rpDevMode;
					goto IL_9A;
				}
				catch
				{
					terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
					goto IL_9A;
				}
			}
			try
			{
				terminalType = (global::Motorola.Common.Communication.CommonUtil.RPTerminalType)this._rpDevMode;
			}
			catch
			{
				terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			}
			IL_9A:
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess || commRC2 != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric;
			}
			return global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00011C1C File Offset: 0x0000FE1C
		private void RPGetTerminalID(global::Motorola.Common.Communication.CommonUtil.RPTerminalIDInfo terminalIdInfo)
		{
			string empty = string.Empty;
			global::Motorola.Common.Communication.CommonUtil.RPTerminalType termianlType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			string empty2 = string.Empty;
			string empty3 = string.Empty;
			string empty4 = string.Empty;
			byte[] rawData = null;
			if (terminalIdInfo == null)
			{
				terminalIdInfo = new global::Motorola.Common.Communication.CommonUtil.RPTerminalIDInfo();
			}
			try
			{
				if (this.RadioProfile.TetraRadioType == global::Motorola.Common.Communication.CommonUtil.TetraRadioType.TRANSCEIVER)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0020_RH_CommErrNotSupportedOperation.ToString(), "Not supported exception");
				}
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = this.RPGetTerminalID(out empty2, out empty3, out empty, out empty4, out termianlType);
				terminalIdInfo.OperationResult = commRC;
				if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					terminalIdInfo.CpuID = empty2;
					terminalIdInfo.PairedCpuID = empty3;
					terminalIdInfo.ChSN = empty;
					terminalIdInfo.ChDieID = empty4;
					terminalIdInfo.TermianlType = termianlType;
					terminalIdInfo.RawData = rawData;
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
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex2
				});
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00011D88 File Offset: 0x0000FF88
		private void GetRPVersionInfo(out global::Motorola.Common.Communication.CommonUtil.RPVersionInfo versionInfo)
		{
			versionInfo = null;
			try
			{
				global::Motorola.Common.Communication.CommonUtil.RadioManuInfo radioManuInfo = null;
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = this.ATGetRadioInfo(out radioManuInfo);
				versionInfo = new global::Motorola.Common.Communication.CommonUtil.RPVersionInfo();
				versionInfo.OperationResult = commRC;
				if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					versionInfo.ProtocolVersion = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_C;
					versionInfo.TerminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_TERMINAL_TYPE_PORTABLE;
					versionInfo.PortableCPChanged = false;
					versionInfo.PortableFwVersion = global::System.Convert.ToUInt16(radioManuInfo.swVer.Substring(8, 4));
					versionInfo.FlashPacketNumber = 0;
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex2
				});
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00011E74 File Offset: 0x00010074
		private global::Motorola.Common.Communication.CommonUtil.CommRC SendVerReqReply()
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			try
			{
				commRC = this.ATSetRPState(global::Motorola.Common.Communication.CommonUtil.RPDeivceState.GREEN_NO_UPDATE);
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex2
				});
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			return commRC;
		}

		// Token: 0x04000073 RID: 115
		private global::Motorola.Common.Communication.IProgressIndicator _progressIndicator;

		// Token: 0x04000074 RID: 116
		private global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe _transport;

		// Token: 0x04000075 RID: 117
		private global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile _radioProfile;

		// Token: 0x04000076 RID: 118
		private object _propertyAccessLock = new object();

		// Token: 0x04000077 RID: 119
		private global::System.Threading.AutoResetEvent _radioResetEvent;

		// Token: 0x04000078 RID: 120
		private global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo _devInfo;

		// Token: 0x04000079 RID: 121
		private string _rpCpuID = string.Empty;

		// Token: 0x0400007A RID: 122
		private global::Motorola.Common.Communication.CommonUtil.DeviceMode _rpDevMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;

		// Token: 0x0400007B RID: 123
		private global::Motorola.Common.Communication.CommonUtil.DeviceMode _switchedRadioMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;

		// Token: 0x0400007C RID: 124
		private global::Motorola.Common.Communication.CommonUtil.TetraRadioType _switchedRadioType;

		// Token: 0x0400007D RID: 125
		private bool _disposed;
	}
}
