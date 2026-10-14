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
	// Token: 0x02000015 RID: 21
	public class TetraRPSeqManager : global::Motorola.Common.Communication.ICpsSequenceManager, global::Motorola.Common.Communication.ITetraSeqMgrSpecialOperation, global::System.IDisposable
	{
		// Token: 0x06000273 RID: 627 RVA: 0x00018E86 File Offset: 0x00017086
		public TetraRPSeqManager(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			this._transport = (transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe);
			this._devInfo = (devInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo);
			this._radioResetEvent = new global::System.Threading.AutoResetEvent(false);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00018EC4 File Offset: 0x000170C4
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00018ECB File Offset: 0x000170CB
		public byte QueryRadioUpdateStatus()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00018ED4 File Offset: 0x000170D4
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00018F18 File Offset: 0x00017118
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00018F5C File Offset: 0x0001715C
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Transport
		{
			get
			{
				return this._transport;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00018F64 File Offset: 0x00017164
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00018FD0 File Offset: 0x000171D0
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

		// Token: 0x0600027B RID: 635 RVA: 0x00019018 File Offset: 0x00017218
		public virtual bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			return true;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0001901C File Offset: 0x0001721C
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00019060 File Offset: 0x00017260
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600027E RID: 638 RVA: 0x000190A4 File Offset: 0x000172A4
		// (set) Token: 0x0600027F RID: 639 RVA: 0x000190AC File Offset: 0x000172AC
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000280 RID: 640 RVA: 0x000190B5 File Offset: 0x000172B5
		// (set) Token: 0x06000281 RID: 641 RVA: 0x000190BD File Offset: 0x000172BD
		public bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x06000282 RID: 642 RVA: 0x000190C6 File Offset: 0x000172C6
		public void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000190C8 File Offset: 0x000172C8
		public void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000190CA File Offset: 0x000172CA
		public virtual bool DifferentialWriteSupported(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			return false;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000190CD File Offset: 0x000172CD
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000190D4 File Offset: 0x000172D4
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000190DB File Offset: 0x000172DB
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			this.ConstructDeviceInfo();
			return this._devInfo.Clone() as global::Motorola.Common.Communication.CommonUtil.DeviceInfo;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000190F4 File Offset: 0x000172F4
		public void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			string text = "TetraRPSeqManager.SwitchMode";
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Enter TetraRPSeqManager.SwitchMode()");
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "USB Location is " + this.Profile.PhysicalLocation);
			try
			{
				text = string.Format("TetraRPSeqManager.SwitchMode from mode {0} to mode {1}", this.Profile.DeviceMode, mode);
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel(text);
				global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.DeviceAttached += this.Instance_DeviceChanged;
				this._radioResetEvent.Reset();
				switch (this.Profile.DeviceMode)
				{
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL:
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.CHARGING:
					if (this.RadioProfile.TetraRadioType == global::Motorola.Common.Communication.CommonUtil.TetraRadioType.TRANSCEIVER)
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0020_RH_CommErrNotSupportedOperation.ToString(), "Not supported exception");
					}
					this.ResetNormalModeRadio(mode);
					if (mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.RP)
					{
						this.WaitForRadioReset();
					}
					if (mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.RP && this._switchedRadioMode != mode)
					{
						if (this._switchedRadioType != global::Motorola.Common.Communication.CommonUtil.TetraRadioType.NORMAL || mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.CHARGING)
						{
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
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Leave TetraRPSeqManager.SwitchMode()");
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "USB Location is " + this.Profile.PhysicalLocation);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00019360 File Offset: 0x00017560
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			this.ConstructDeviceInfo();
			return this._devInfo.Clone() as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00019378 File Offset: 0x00017578
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0001937F File Offset: 0x0001757F
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00019386 File Offset: 0x00017586
		public void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0001938D File Offset: 0x0001758D
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00019394 File Offset: 0x00017594
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001939B File Offset: 0x0001759B
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000193A2 File Offset: 0x000175A2
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000193A9 File Offset: 0x000175A9
		public void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000193B0 File Offset: 0x000175B0
		public void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000193B7 File Offset: 0x000175B7
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000193BE File Offset: 0x000175BE
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000193C5 File Offset: 0x000175C5
		public void UpdateMACAddress(byte[] macAddress)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000193CC File Offset: 0x000175CC
		public void SwitchModeNoWait(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			string text = "TetraRPSeqManager.SwitchMode";
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Enter LegacyRadio.SwitchMode()");
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "USB Location is " + this.Profile.PhysicalLocation);
			try
			{
				text = string.Format("TetraRPSeqManager.SwitchMode from mode {0} to mode {1}", this.RadioProfile.DeviceMode, mode);
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel(text);
				switch (this.RadioProfile.DeviceMode)
				{
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL:
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.CHARGING:
					if (this.RadioProfile.TetraRadioType == global::Motorola.Common.Communication.CommonUtil.TetraRadioType.TRANSCEIVER)
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0020_RH_CommErrNotSupportedOperation.ToString(), "Not supported exception");
					}
					this.ResetNormalModeRadio(mode);
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
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Leave TetraRPSeqManager.SwitchMode()");
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "USB Location is " + this.Profile.PhysicalLocation);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000195C0 File Offset: 0x000177C0
		public void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode commandCode, byte[] inputBuffer, out byte[] outputBuffer)
		{
			outputBuffer = null;
			try
			{
				if (commandCode <= global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SWITCH_MODE_NO_WAIT)
				{
					switch (commandCode)
					{
					case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.RP_GET_INDICATION:
					{
						global::Motorola.Common.Communication.CommonUtil.RPStatusIndicationInfo rpstatusIndicationInfo = new global::Motorola.Common.Communication.CommonUtil.RPStatusIndicationInfo();
						this.GetRPIndication(rpstatusIndicationInfo);
						outputBuffer = this.SerializeBinary(rpstatusIndicationInfo);
						goto IL_E2;
					}
					case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.RP_SEND_VERSION_REPLY:
					{
						global::Motorola.Common.Communication.CommonUtil.CommRC commRC = this.SendVerReqReply();
						outputBuffer = this.SerializeBinary(commRC);
						goto IL_E2;
					}
					case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.RP_GET_TERMINAL_ID:
					{
						global::Motorola.Common.Communication.CommonUtil.RPTerminalIDInfo rpterminalIDInfo = new global::Motorola.Common.Communication.CommonUtil.RPTerminalIDInfo();
						this.RPGetTerminalID(rpterminalIDInfo);
						outputBuffer = this.SerializeBinary(rpterminalIDInfo);
						goto IL_E2;
					}
					case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.RP_GET_VERSION_INFO:
					{
						global::Motorola.Common.Communication.CommonUtil.RPVersionInfo rpversionInfo = new global::Motorola.Common.Communication.CommonUtil.RPVersionInfo();
						this.GetRPVersionInfo(rpversionInfo);
						outputBuffer = this.SerializeBinary(rpversionInfo);
						goto IL_E2;
					}
					default:
						if (commandCode == global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SWITCH_MODE_NO_WAIT)
						{
							global::Motorola.Common.Communication.CommonUtil.DeviceMode mode = (global::Motorola.Common.Communication.CommonUtil.DeviceMode)this.DeserializeBinary(inputBuffer);
							this.SwitchModeNoWait(mode);
							goto IL_E2;
						}
						break;
					}
				}
				else
				{
					if (commandCode == global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.OPEN_COMMUNICATION_PIPE)
					{
						this.OpenPipe();
						goto IL_E2;
					}
					if (commandCode == global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.CLOSE_COMMUNICATION_PIPE)
					{
						this.ClosePipe();
						goto IL_E2;
					}
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
				IL_E2:;
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

		// Token: 0x06000298 RID: 664 RVA: 0x0001975C File Offset: 0x0001795C
		public void WriteSoftware(string swFilePath, bool bResetProgress = true)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00019763 File Offset: 0x00017963
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0001976A File Offset: 0x0001796A
		public byte[] ReadCPData(string blockID, uint offset, ushort size)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00019771 File Offset: 0x00017971
		public bool IsLLPAvailable()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00019778 File Offset: 0x00017978
		public bool TurnOffRadio()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001977F File Offset: 0x0001797F
		public void UpgradeFlashStrap(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool bResetProgress = true)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00019786 File Offset: 0x00017986
		public void EraseRadioFromTo(uint startAddress, uint size, bool bForceErase = false)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0001978D File Offset: 0x0001798D
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageWithProgressUpdate(string address, uint size)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00019794 File Offset: 0x00017994
		public void WriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage, bool bResetProgress = false)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0001979B File Offset: 0x0001799B
		public global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x000197A4 File Offset: 0x000179A4
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00019820 File Offset: 0x00017A20
		public string CpuID
		{
			get
			{
				string cpuID;
				lock (this._propertyAccessLock)
				{
					if (string.IsNullOrEmpty(this._devInfo.CpuID))
					{
						this._devInfo.CpuID = "Fake" + this.RadioProfile.PhysicalLocation;
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00019868 File Offset: 0x00017A68
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x000198AC File Offset: 0x00017AAC
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

		// Token: 0x060002A6 RID: 678 RVA: 0x000198F4 File Offset: 0x00017AF4
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

		// Token: 0x060002A7 RID: 679 RVA: 0x000199D8 File Offset: 0x00017BD8
		public void EraseRadio(global::System.Collections.Generic.List<string> sections)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000199DF File Offset: 0x00017BDF
		public void WaitForCancelReading()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000199E6 File Offset: 0x00017BE6
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000199F5 File Offset: 0x00017BF5
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

		// Token: 0x060002AB RID: 683 RVA: 0x00019A24 File Offset: 0x00017C24
		~TetraRPSeqManager()
		{
			this.Dispose(false);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00019A54 File Offset: 0x00017C54
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
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Exception in TetraRPSeqManager.Instance_DeviceChanged: " + ex.Message);
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00019B58 File Offset: 0x00017D58
		private void ResetNormalModeRadio(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			byte toMode = 2;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				switch (mode)
				{
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL:
					break;
				case global::Motorola.Common.Communication.CommonUtil.DeviceMode.RP:
					toMode = 3;
					goto IL_36;
				default:
					if (mode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP)
					{
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
						goto IL_36;
					}
					break;
				}
				toMode = 2;
			}
			IL_36:
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.RPResetRadio rpresetRadio = new global::Motorola.Common.Communication.RPResetRadio(this._transport, toMode))
				{
					rpresetRadio.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(rpresetRadio.OperationResult);
				}
				if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD1029_PR_CommErrRPReadTimeout || commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD1035_PR_CommErrRPReceiveMsgError)
				{
					commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
				}
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in ResetNormalModeRadio(DeviceMode mode)");
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00019C28 File Offset: 0x00017E28
		private void WaitForRadioReset()
		{
			if (!this._radioResetEvent.WaitOne(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_RESET_TIMEOUT, false))
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "TetraRPSeqManager.WaitForRadioReset: reset radio timed out");
				if ((this.Transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).Reliable)
				{
					global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS statusCode = global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.NoDeviceConnected;
					if (global::Motorola.Common.Communication.TetraUtility.USBDiagnose.GetUSBPortStatus(this.RadioProfile.USBHubInstance, this.RadioProfile.USBHubPortNumber, this.RadioProfile.Path, out statusCode))
					{
						string str = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.ConnectionStatusCodeToStr(statusCode);
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Connection Status is: " + str);
					}
				}
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("TetraRPSeqManager.WaitForRadioReset: reset radio timed out");
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00019CD8 File Offset: 0x00017ED8
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
			}
			catch
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.RadioProfile.Path, "Error in constructDeviceInfo().");
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00019F3C File Offset: 0x0001813C
		private global::Motorola.Common.Communication.CommonUtil.CommRC GetTEIRP(out global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode, out string terminalID, out global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus terminalStatus)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			terminalID = string.Empty;
			deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
			terminalStatus = global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus.RP_RESET_MODE_NORMAL;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.RPGetIndication rpgetIndication = new global::Motorola.Common.Communication.RPGetIndication(this._transport))
				{
					rpgetIndication.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(rpgetIndication.OperationResult);
					if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
					{
						terminalID = rpgetIndication.IndicationID;
						global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus terminalStatus2 = rpgetIndication.TerminalStatus;
						try
						{
							deviceMode = (global::Motorola.Common.Communication.CommonUtil.DeviceMode)terminalStatus2;
						}
						catch
						{
							deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
						}
						terminalStatus = rpgetIndication.TerminalStatus;
					}
				}
			}
			return commRC;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00019FD4 File Offset: 0x000181D4
		private void GetRPIndication(global::Motorola.Common.Communication.CommonUtil.RPStatusIndicationInfo statusIndicationInfo)
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
			global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus status = global::Motorola.Common.Communication.CommonUtil.RPTerminalStatus.RP_STATUS_UNKNOWN;
			string empty = string.Empty;
			if (statusIndicationInfo == null)
			{
				statusIndicationInfo = new global::Motorola.Common.Communication.CommonUtil.RPStatusIndicationInfo();
			}
			try
			{
				if (this.RadioProfile.TetraRadioType == global::Motorola.Common.Communication.CommonUtil.TetraRadioType.CONTROL_HEAD)
				{
					this._transport.ClosePort();
					global::System.Threading.Thread.Sleep(100);
					this._transport.OpenPort();
					this.rpIndicationRetryCount = 0;
				}
				if (this.RadioProfile.TetraRadioType == global::Motorola.Common.Communication.CommonUtil.TetraRadioType.TRANSCEIVER)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0020_RH_CommErrNotSupportedOperation.ToString(), "Not supported exception");
				}
				global::Motorola.Common.Communication.CommonUtil.CommRC teirp = this.GetTEIRP(out deviceMode, out empty, out status);
				statusIndicationInfo.OperationResult = teirp;
				if (teirp == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					lock (this._propertyAccessLock)
					{
						if (this.RadioProfile.TetraRadioType != global::Motorola.Common.Communication.CommonUtil.TetraRadioType.CONTROL_HEAD)
						{
							lock (this._propertyAccessLock)
							{
								this._devInfo.TEI = empty;
							}
						}
						if (deviceMode != global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN)
						{
							this.Profile.DeviceMode = deviceMode;
						}
					}
					statusIndicationInfo.DevMode = deviceMode;
					statusIndicationInfo.TerminalId = empty;
					statusIndicationInfo.Status = status;
				}
				else
				{
					this.rpIndicationRetryCount++;
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

		// Token: 0x060002B2 RID: 690 RVA: 0x0001A20C File Offset: 0x0001840C
		private string GetTransRadioCpuIdFromRawData(byte[] rawData)
		{
			string text = string.Empty;
			bool flag = true;
			if (rawData == null)
			{
				flag = false;
			}
			if (flag && rawData.Length < 30)
			{
				flag = false;
			}
			if (flag)
			{
				for (int i = 13; i < 29; i++)
				{
					text += string.Format("{0:X2}", rawData[i]);
				}
			}
			return text;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0001A260 File Offset: 0x00018460
		private global::Motorola.Common.Communication.CommonUtil.CommRC RPGetTerminalID(out string cpuID, out string pairedCpuID, out string chSN, out string chDieID, out global::Motorola.Common.Communication.CommonUtil.RPTerminalType terminalType, out byte[] rawData)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			chSN = string.Empty;
			terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_TERMINAL_TYPE_MOBILE;
			cpuID = string.Empty;
			chDieID = string.Empty;
			pairedCpuID = string.Empty;
			rawData = null;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.RPTerminalIDRequest rpterminalIDRequest = new global::Motorola.Common.Communication.RPTerminalIDRequest(this._transport))
				{
					rpterminalIDRequest.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(rpterminalIDRequest.OperationResult);
					if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
					{
						cpuID = rpterminalIDRequest.ControlHeadDieID;
						pairedCpuID = this.GetTransRadioCpuIdFromRawData(rpterminalIDRequest.RawData);
						chSN = rpterminalIDRequest.ControlHeadSN;
						terminalType = rpterminalIDRequest.TerminalType;
						chDieID = rpterminalIDRequest.ControlHeadDieID;
						rawData = rpterminalIDRequest.RawData;
					}
				}
			}
			return commRC;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0001A31C File Offset: 0x0001851C
		private void RPGetTerminalID(global::Motorola.Common.Communication.CommonUtil.RPTerminalIDInfo terminalIdInfo)
		{
			string empty = string.Empty;
			global::Motorola.Common.Communication.CommonUtil.RPTerminalType termianlType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_TERMINAL_TYPE_MOBILE;
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
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = this.RPGetTerminalID(out empty2, out empty3, out empty, out empty4, out termianlType, out rawData);
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

		// Token: 0x060002B5 RID: 693 RVA: 0x0001A48C File Offset: 0x0001868C
		private void GetRPVersionInfo(global::Motorola.Common.Communication.CommonUtil.RPVersionInfo versionInfo)
		{
			if (versionInfo == null)
			{
				versionInfo = new global::Motorola.Common.Communication.CommonUtil.RPVersionInfo();
			}
			try
			{
				using (global::Motorola.Common.Communication.RPVersionRequest rpversionRequest = new global::Motorola.Common.Communication.RPVersionRequest(this._transport))
				{
					rpversionRequest.ExecuteMessage();
					global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(rpversionRequest.OperationResult);
					versionInfo.OperationResult = commRC;
					if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
					{
						if (rpversionRequest.FlashPacket != null)
						{
							versionInfo.FlashPacket = new byte[rpversionRequest.FlashPacket.Length];
							global::System.Array.Copy(rpversionRequest.FlashPacket, versionInfo.FlashPacket, rpversionRequest.FlashPacket.Length);
						}
						versionInfo.FlashPacketNumber = rpversionRequest.FlashPacketNumber;
						versionInfo.MobileControlHeadCPChanged = rpversionRequest.MobileControlHeadCPChanged;
						versionInfo.MobileControlHeadFwVersion = rpversionRequest.MobileControlHeadFwVersion;
						versionInfo.MobileTransCPChanged = rpversionRequest.MobileTransCPChanged;
						versionInfo.MobileTransFwVersion = rpversionRequest.MobileTransFwVersion;
						versionInfo.PortableCPChanged = rpversionRequest.PortableCPChanged;
						versionInfo.PortableFwVersion = rpversionRequest.PortableFwVersion;
						versionInfo.ProtocolVersion = rpversionRequest.ProtocolVersion;
						versionInfo.TerminalType = rpversionRequest.TerminalType;
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
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex2
				});
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0001A648 File Offset: 0x00018848
		private global::Motorola.Common.Communication.CommonUtil.CommRC SendVerReqReply()
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC result = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			try
			{
				using (global::Motorola.Common.Communication.RPVerReqReply rpverReqReply = new global::Motorola.Common.Communication.RPVerReqReply(this._transport))
				{
					rpverReqReply.ExecuteMessage();
					result = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(rpverReqReply.OperationResult);
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
			return result;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0001A74C File Offset: 0x0001894C
		private void OpenPipe()
		{
			if (this._transport != null)
			{
				this._transport.OpenPort();
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0001A762 File Offset: 0x00018962
		private void ClosePipe()
		{
			if (this._transport != null)
			{
				this._transport.ClosePort();
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0001A778 File Offset: 0x00018978
		private byte[] SerializeBinary(object request)
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

		// Token: 0x060002BA RID: 698 RVA: 0x0001A7D4 File Offset: 0x000189D4
		private object DeserializeBinary(byte[] buf)
		{
			object result = null;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buf))
			{
				memoryStream.Position = 0L;
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				result = binaryFormatter.Deserialize(memoryStream);
				memoryStream.Close();
			}
			return result;
		}

		// Token: 0x0400008B RID: 139
		private global::Motorola.Common.Communication.IProgressIndicator _progressIndicator;

		// Token: 0x0400008C RID: 140
		private global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe _transport;

		// Token: 0x0400008D RID: 141
		private global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile _radioProfile;

		// Token: 0x0400008E RID: 142
		private object _propertyAccessLock = new object();

		// Token: 0x0400008F RID: 143
		private global::System.Threading.AutoResetEvent _radioResetEvent;

		// Token: 0x04000090 RID: 144
		private global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo _devInfo;

		// Token: 0x04000091 RID: 145
		private global::Motorola.Common.Communication.CommonUtil.DeviceMode _switchedRadioMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;

		// Token: 0x04000092 RID: 146
		private global::Motorola.Common.Communication.CommonUtil.TetraRadioType _switchedRadioType;

		// Token: 0x04000093 RID: 147
		private int rpIndicationRetryCount;

		// Token: 0x04000094 RID: 148
		private bool _disposed;
	}
}
