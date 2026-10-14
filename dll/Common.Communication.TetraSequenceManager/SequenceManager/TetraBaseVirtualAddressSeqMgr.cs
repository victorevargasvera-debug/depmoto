using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using FDISystem;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.Compression;
using Motorola.Common.Communication.FDT;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200000F RID: 15
	public class TetraBaseVirtualAddressSeqMgr : global::Motorola.Common.Communication.SequenceManager.TetraBaseSbepSeqManager
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00008DD0 File Offset: 0x00006FD0
		public TetraBaseVirtualAddressSeqMgr(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			this._transport = (transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe);
			this._devInfo = (devInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00008DF0 File Offset: 0x00006FF0
		public override void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			base.ResetProgress();
			if (pbaObject == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Input pba are null");
			}
			if (pbaObject.CodeplugData == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Input codeplug are null");
			}
			if (pbaObject.LanguagePackData == null)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Input language pack are null");
			}
			try
			{
				string text = null;
				string text2 = null;
				string text3 = string.Empty;
				string text4 = null;
				string text5 = null;
				foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in pbaObject.UpdateData.MemoryImages)
				{
					global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType = radioImage.FileType;
					switch (fileType)
					{
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FLASHSTP:
						text = radioImage.FilePath;
						break;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST:
						text5 = radioImage.FilePath;
						break;
					default:
						if (fileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TARGET_VERSION)
						{
							global::Motorola.Common.Communication.Pba.TetraMemoryImage tetraMemoryImage = radioImage as global::Motorola.Common.Communication.Pba.TetraMemoryImage;
							if (tetraMemoryImage != null)
							{
								text2 = tetraMemoryImage.TargetModelNumber;
								text4 = tetraMemoryImage.TargetSerialNumber;
								text3 = tetraMemoryImage.TargetCPVersion;
								this._forceWrite = tetraMemoryImage.ForceWrite;
							}
						}
						break;
					}
				}
				if (string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text4) || string.IsNullOrEmpty(text5) || string.IsNullOrWhiteSpace(text3))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Upgrade input parameter are empty");
				}
				if (this._forceWrite)
				{
					this._recoverModelNumbel = text2;
					this._recoverCPversion = text3;
					this._recoverSerialNumber = text4;
				}
				global::Motorola.Common.Communication.TetraUtility.MemMapRecord memMapRecord;
				if (!this._forceWrite)
				{
					memMapRecord = this.MemoryMap;
				}
				else
				{
					string recoverCPversion = this._recoverCPversion;
					global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord memMapVersionMapRecord = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetMemMapVersionMapRecord(recoverCPversion, this._recoverModelNumbel);
					memMapRecord = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetMemMapConfig(memMapVersionMapRecord.MemMapID);
				}
				if (memMapRecord == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "MemMap is null");
				}
				if (!string.IsNullOrEmpty(text))
				{
					base.SetCurrentScope(0, 10);
					this.UpgradeFlashStrap(new global::Motorola.Common.Communication.Pba.PbaObject
					{
						FlashStrapPath = text
					}, false);
				}
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject2 = new global::Motorola.Common.Communication.Pba.PbaObject();
				pbaObject2.FWpath = text5;
				if (!string.IsNullOrEmpty(text))
				{
					base.doWriteSoftware(pbaObject2, text3, 11, 60, false);
				}
				else
				{
					base.doWriteSoftware(pbaObject2, text3, 0, 60, false);
				}
				base.doWriteDevice(pbaObject, text4, 61, 70, false);
				string cpVersion = text3;
				if (global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.IsRadioSupportFP(text2, cpVersion))
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = null;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs = null;
					base.ConstructRadioPacks(pbaObject.LanguagePackData, text5, out list, out packs);
					base.doWriteLanguagePacks(packs, text5, 71, 100, false);
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex);
			}
			finally
			{
				this._forceWrite = false;
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraBaseVirtualAddressSeqMgr.UpdateDevice", "");
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000090F4 File Offset: 0x000072F4
		public override void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode commandCode, byte[] inputBuffer, out byte[] outputBuffer)
		{
			outputBuffer = null;
			try
			{
				switch (commandCode)
				{
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_ERASE_KEYS:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_BEGIN_UPDATE_FDT:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_END_UPDATE_FDT:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_MIGRATE_FDT:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_WRITE_KEYS:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_READ_KEYS:
					goto IL_27C;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_RESTORE_PDV2_RADIO:
					this.RestorePDV2Radio();
					goto IL_27C;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SWITCH_MODE_NO_WAIT:
				{
					global::Motorola.Common.Communication.CommonUtil.DeviceMode mode = (global::Motorola.Common.Communication.CommonUtil.DeviceMode)base.DeserializeBinary(inputBuffer);
					base.SwitchModeNoWait(mode);
					goto IL_27C;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_CLEAN_DAMAGE_FLAG:
					this.CleanCorruptFlag();
					goto IL_27C;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_TEST_FDT:
				{
					string empty = string.Empty;
					this.TestFdtCmd(default(global::Motorola.Common.Communication.CommonUtil.TestFDTCmdInfo), out empty);
					outputBuffer = base.SerializeBinary(empty);
					goto IL_27C;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.OPEN_COMMUNICATION_PIPE:
					base.OpenPipe();
					goto IL_27C;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.CLOSE_COMMUNICATION_PIPE:
					base.ClosePipe();
					goto IL_27C;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.GET_CEMSTONE_RADIO_FP_INFO:
				{
					global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> radioInfo = new global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader>();
					global::System.Collections.Generic.List<uint> emptySlots = new global::System.Collections.Generic.List<uint>();
					this.ReadRadioInfo(out radioInfo, out emptySlots);
					outputBuffer = base.SerializeBinary(new global::Motorola.Common.Communication.CommonUtil.GemstoneFPInfo
					{
						EmptySlots = emptySlots,
						RadioInfo = radioInfo
					});
					goto IL_27C;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_GET_PLATFORM_INFO:
				{
					global::System.Collections.Generic.Dictionary<string, string> platformInfo = this.GetPlatformInfo();
					outputBuffer = base.SerializeBinary(platformInfo);
					goto IL_27C;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.CPA_AUTHENTICATE_RADIO:
				{
					byte[] data = base.DeserializeBinary(inputBuffer) as byte[];
					this.AR(data);
					goto IL_27C;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_FLASH_REGION_OPERATION:
				{
					global::Motorola.Common.Communication.CommonUtil.FlashRegionOperation flashRegionOperation = (global::Motorola.Common.Communication.CommonUtil.FlashRegionOperation)base.DeserializeBinary(inputBuffer);
					if (flashRegionOperation.OperationType == global::Motorola.Common.Communication.CommonUtil.FlashOperationType.BACKUP)
					{
						global::Motorola.Common.Communication.CommonUtil.CommRC errorReason = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
						string empty2 = string.Empty;
						flashRegionOperation.OperationResult = this.BackupFlashRegion(flashRegionOperation.RegionType, out empty2, out errorReason);
						flashRegionOperation.FilePathForOperation = empty2;
						flashRegionOperation.ErrorReason = errorReason;
						outputBuffer = base.SerializeBinary(flashRegionOperation);
						goto IL_27C;
					}
					if (flashRegionOperation.OperationType == global::Motorola.Common.Communication.CommonUtil.FlashOperationType.RESTORE)
					{
						global::Motorola.Common.Communication.CommonUtil.CommRC errorReason2 = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
						flashRegionOperation.OperationResult = this.WriteFlashRegion(flashRegionOperation.FilePathForOperation, out errorReason2);
						flashRegionOperation.ErrorReason = errorReason2;
						outputBuffer = base.SerializeBinary(flashRegionOperation);
						goto IL_27C;
					}
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.CPA_UNAUTHENTICATE_RADIO:
					this.DR();
					goto IL_27C;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_GET_STATUS:
				{
					global::Motorola.Common.Communication.SBEPStatus sbepstatus = new global::Motorola.Common.Communication.SBEPStatus(this._transport, true);
					sbepstatus.ExecuteMessage();
					byte b = (sbepstatus.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS) ? sbepstatus.Status : byte.MaxValue;
					outputBuffer = base.SerializeBinary(b);
					goto IL_27C;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_SET_DAMAGE_FLAG:
					this.SetCorruptFlag();
					goto IL_27C;
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
				IL_27C:;
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic exception", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000956C File Offset: 0x0000776C
		public override void WriteSoftware(string swFilePath, bool bResetProgress = true)
		{
			base.RetryMethod(delegate
			{
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.WriteSoftware");
				if (bResetProgress)
				{
					this.ResetProgress();
				}
				try
				{
					global::Motorola.Common.Communication.TetraUtility.Z19File z19File = null;
					global::Motorola.Common.Communication.TetraUtility.SRecord srecord = null;
					global::Motorola.Common.Communication.CommonUtil.MemoryImage image = null;
					string empty = string.Empty;
					this.PrepareSWImage(swFilePath, out z19File, out srecord, out image, out empty);
					this.DoEraseImage(image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
					this.DoWriteImage(image, this._devInfo.UseCompress, true, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingSoftware);
				}
				catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
					{
						ex
					});
					throw;
				}
				catch (global::System.Exception innerException)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException);
				}
				finally
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraBaseVirtualAddressSeqMgr.WriteSoftware", "");
					this._devInfo.BMPRadioFPInfo = null;
				}
			});
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000095D0 File Offset: 0x000077D0
		public override byte[] ReadCPData(string blockID, uint offset, ushort size)
		{
			byte[] cpData = null;
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.ReadCPData");
			byte[] cpData2;
			try
			{
				if ((this.PartionHealthState & 1) == 1)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug is missing");
				}
				if (!(blockID == "RT"))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString());
				}
				base.RetryMethod(delegate
				{
					cpData = this.GemstoneReadCPDataFromRootBlock(offset, size);
				});
				cpData2 = cpData;
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("GemstoneBMPRadio.ReadCPData", "");
			}
			return cpData2;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000096F0 File Offset: 0x000078F0
		public override bool IsLLPAvailable()
		{
			bool result;
			try
			{
				base.CreateReleaseID();
				this.CreateFPSlot();
				global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage fplocalLanguage = null;
				this.ReadLLP(this._releaseID, this._devInfo.BMPRadioFPSlots, out fplocalLanguage);
				if (fplocalLanguage != null && fplocalLanguage.PackType == 100U)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD0001", "Generic exception", ex2);
			}
			return result;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00009798 File Offset: 0x00007998
		public override global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			return new global::Motorola.Common.Communication.CommonUtil.FDTInfo
			{
				HealthState = true,
				Version = string.Empty,
				ModelType = 0,
				Info = string.Empty
			};
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00009860 File Offset: 0x00007A60
		public override void EraseRadioFromTo(uint startAddress, uint size, bool bForceErase = false)
		{
			uint endAddr = startAddress + size;
			global::System.Collections.Generic.List<uint> slotsAddrList = new global::System.Collections.Generic.List<uint>();
			if (bForceErase)
			{
				base.EraseRadioFromTo(startAddress, size, bForceErase);
				this._devInfo.BMPRadioFPInfo = null;
				return;
			}
			bool bResult = global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GetFlashpackSlotsInAddress(startAddress, endAddr, slotsAddrList);
			if (!bResult)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0016_RH_CommErrInvalidInputAddress.ToString(), "The address is not valid for erase");
			}
			try
			{
				base.RetryMethod(delegate
				{
					foreach (uint flashAddress in slotsAddrList)
					{
						uint num = 0U;
						global::Motorola.Common.Communication.SequenceManager.ErrorReason errorReason = global::Motorola.Common.Communication.SequenceManager.ErrorReason.Unknown;
						bResult = this.GetVirtualFlashRegionActualSize(flashAddress, out num, out errorReason);
						if (bResult && num != 0U)
						{
							this.DoEraseFlash(flashAddress.ToString(), 0U, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
						}
					}
				});
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("GemstoneBaseRadio.EraseFromTo", "");
			}
			this._devInfo.BMPRadioFPInfo = null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00009A04 File Offset: 0x00007C04
		public override void EraseRadio(global::System.Collections.Generic.List<string> sections)
		{
			try
			{
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.EraseRadio");
				if (sections == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "no flash section");
				}
				base.RetryMethod(delegate
				{
					foreach (string a in sections)
					{
						if (a == global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_REGION_ENTIRE)
						{
							string address = "0";
							uint size = 0U;
							this.DoEraseFlash(address, size, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
							break;
						}
					}
				});
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
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("GemstoneBaseRadio.EraseRadio", "");
			}
			this._devInfo.BMPRadioFPInfo = null;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00009B20 File Offset: 0x00007D20
		public override void Invalidate(bool onlyCPInfo)
		{
			base.Invalidate(onlyCPInfo);
			this._rootHeadOffset = 0U;
			this._devInfo.BMPRadioFPInfo = null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00009C80 File Offset: 0x00007E80
		public override global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImage(string address, uint size, bool bUpdateProgress = true)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.ReadImage");
			global::Motorola.Common.Communication.CommonUtil.MemoryImage image = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
			try
			{
				if (string.IsNullOrEmpty(address))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "address is null");
				}
				if (size == 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "read size is zeros");
				}
				base.RetryMethod(delegate
				{
					uint endAddress = global::System.Convert.ToUInt32(address) + size - 1U;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr.VirtualFlashInfo> list = null;
					this.ParseVirtualFlashRegions(global::System.Convert.ToUInt32(address), endAddress, out list);
					if (list == null)
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "flashInfoList is null");
					}
					uint num = 0U;
					double num2 = 0.0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].SizeNeedToRead;
					}
					for (int j = 0; j < list.Count; j++)
					{
						double startProgress = num2;
						num2 += list[j].SizeNeedToRead / num;
						list[j].StartProgress = startProgress;
						list[j].EndProgress = num2;
						this.ReadImage(image, list[j].StartAddress.ToString(), list[j].SizeNeedToRead, list[j].StartProgress, list[j].EndProgress, bUpdateProgress);
					}
				});
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("GemstoneBMPRadio.ReadImage", "");
			}
			return image;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00009DAC File Offset: 0x00007FAC
		public override global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> ReadCodeplug()
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> list = null;
			try
			{
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.ReadCodeplug");
				this.GetByteOrder();
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.ReadCodeplug.GetCPAddressSize");
				uint num = 0U;
				uint size = 0U;
				global::Motorola.Common.Communication.TetraUtility.FDIVersion fdiversion = global::Motorola.Common.Communication.TetraUtility.FDIVersion.V5x;
				this.GetCPAddressSize(out num, out size, out fdiversion);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraBaseVirtualAddressSeqMgr.ReadCodeplug.GetCPAddressSize", "");
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.ReadCodeplug.ReadImage");
				global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = base.DoReadImage(num.ToString(), size, this._devInfo.UseCompress, true, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraBaseVirtualAddressSeqMgr.ReadCodeplug.ReadImage", "");
				memoryImage.CompactUnits();
				if (memoryImage.Count != 1)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0003_RH_CommErrBadImage.ToString());
				}
				list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>>();
				global::System.Collections.Generic.KeyValuePair<ushort, byte[]> item = new global::System.Collections.Generic.KeyValuePair<ushort, byte[]>(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_BLOCK_ID, memoryImage[0].Data);
				list.Add(item);
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::FDISystem.FDIException ex2)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("FDI Error", new object[]
				{
					ex2
				});
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD4002_FDI_CommErrFDIException.ToString(), "FDI exception", ex2);
			}
			catch (global::System.Exception ex3)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex3
				});
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex3);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraBaseVirtualAddressSeqMgr.ReadCodeplug", "");
			}
			return list;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00009FF0 File Offset: 0x000081F0
		public override void WriteCodeplug(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList, uint cpSize, string serialNum)
		{
			try
			{
				global::Motorola.Common.Communication.CommonUtil.MemoryImage image = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
				byte[] value = fdiBlockList[0].Value;
				this.Invalidate(true);
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.WriteCodeplug");
				if (fdiBlockList == null || fdiBlockList.Count == 0)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "fidBlockList is empty");
				}
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.WriteCodeplug.GetConfig");
				uint rootHeadOffset = this.RootBlockHeadOffset(value);
				string gemstoneCPVersion = this.GetGemstoneCPVersion(value, rootHeadOffset);
				string gemstoneModelNumber = this.GetGemstoneModelNumber(value, rootHeadOffset);
				ushort decrypedGemstoneHomeMCC = this.GetDecrypedGemstoneHomeMCC(value, rootHeadOffset);
				string commonModelNumber = this.ComposeCommonModelNumber(gemstoneModelNumber, (uint)decrypedGemstoneHomeMCC);
				global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel(gemstoneModelNumber, global::Motorola.Common.Communication.TetraUtility.MCCConverter.ToString((uint)decrypedGemstoneHomeMCC));
				if (model == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "model interface is null!");
				}
				global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord memMapVersionMapRecord = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetMemMapVersionMapRecord(gemstoneCPVersion, commonModelNumber);
				global::Motorola.Common.Communication.TetraUtility.MemMapRecord memMapConfig = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetMemMapConfig(memMapVersionMapRecord.MemMapID);
				if (!memMapConfig.MapDefinition.ContainsKey(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_CP_SECTION) || memMapConfig.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_CP_SECTION].Count != 1)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("memory map {0} has the wrong codeplug section definition", memMapConfig.MemMapID));
				}
				uint num = global::System.Convert.ToUInt32(memMapConfig.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_CP_SECTION][0].Address);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraBaseVirtualAddressSeqMgr.WriteCodeplug.GetConfig", "");
				byte[] array = this.InitGemstoneCPHead((uint)value.Length, (ushort)model.ModelType, gemstoneCPVersion);
				byte[] array2 = new byte[array.Length + value.Length];
				global::System.Array.Copy(array, 0, array2, 0, array.Length);
				global::System.Array.Copy(value, 0, array2, array.Length, value.Length);
				global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
				flashMemoryUnit.ChargeUnit(num.ToString(), array2, 0, 1U);
				image.AddItem(flashMemoryUnit);
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.WriteCodeplug.WriteImage");
				base.RetryMethod(delegate
				{
					this.DoWriteImage(image, this._devInfo.UseCompress, true, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
				});
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraBaseVirtualAddressSeqMgr.WriteCodeplug.WriteImage", "");
				this._devInfo.ARP = null;
				this.SynchronizeUserPassword();
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::FDISystem.FDIException ex2)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("FDI Error", new object[]
				{
					ex2
				});
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD4002_FDI_CommErrFDIException.ToString(), "FDI exception", ex2);
			}
			catch (global::System.Exception ex3)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex3
				});
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex3);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("GemstoneBaseRadio.WriteCodeplug", "");
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000A34C File Offset: 0x0000854C
		public override void RestorePDV2Radio()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("GemstoneBaseRadio.RestorePDV2Radio");
			try
			{
				this.DoRestorePDV2Radio();
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("GemstoneBaseRadio.RestorePDV2Radio", "");
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000A3F0 File Offset: 0x000085F0
		private global::System.Collections.Generic.Dictionary<string, string> GetPlatformInfo()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("GemstoneBaseRadio.GetPlatformInfo");
			global::System.Collections.Generic.Dictionary<string, string> result;
			try
			{
				result = this.DoGetPlatformInfo();
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("GemstoneBaseRadio.GetPlatformInfo", "");
			}
			return result;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000A494 File Offset: 0x00008694
		public override ushort ModelType
		{
			get
			{
				ushort radioModelType;
				lock (this._propertyAccessLock)
				{
					radioModelType = this.GetRadioModelType();
				}
				return radioModelType;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000A4D8 File Offset: 0x000086D8
		public override uint HomeMCC
		{
			get
			{
				uint result;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (this._devInfo.HomeMCC == -1)
						{
							this.InitGemstoneCPParameters();
							int gemstoneHomeMCC = (int)this.GetGemstoneHomeMCC(this._rootBlockCache, this._rootHeadOffset);
							this._devInfo.HomeMCC = gemstoneHomeMCC;
							if (global::Motorola.Common.Communication.TetraUtility.MCCConverter.IsHomeMccEncrypted((uint)gemstoneHomeMCC))
							{
								this._devInfo.IsCodeplugAuthenticationEnabled = true;
							}
							else
							{
								if (this.DUP == null)
								{
									this.DUP = new byte[32];
								}
								this._devInfo.IsCodeplugAuthenticationEnabled = false;
							}
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
							{
								ex
							});
						}
						this._devInfo.HomeMCC = -1;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
						{
							ex2
						});
						this._devInfo.HomeMCC = -1;
					}
					result = global::Motorola.Common.Communication.TetraUtility.CPAUtil.AMC(this.ARP, this.DUP, this._devInfo.HomeMCC);
				}
				return result;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000A65C File Offset: 0x0000885C
		public override uint HomeMNC
		{
			get
			{
				uint homeMNC;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (this._devInfo.HomeMNC == -1)
						{
							this.InitGemstoneCPParameters();
							this._devInfo.HomeMNC = this.GetGemstoneHomeMNC(this._rootBlockCache, this._rootHeadOffset);
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
							{
								ex
							});
						}
						this._devInfo.HomeMNC = -1;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
						{
							ex2
						});
						this._devInfo.HomeMNC = -1;
					}
					homeMNC = (uint)this._devInfo.HomeMNC;
				}
				return homeMNC;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000A770 File Offset: 0x00008970
		public override string SerialNumber
		{
			get
			{
				string result;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (string.IsNullOrEmpty(this._devInfo.SerialNumber))
						{
							this.InitGemstoneCPParameters();
							this._devInfo.SerialNumber = this.GetGemstoneSerialNumber(this._rootBlockCache, this._rootHeadOffset);
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
							{
								ex
							});
						}
						this._devInfo.SerialNumber = string.Empty;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
						{
							ex2
						});
						this._devInfo.SerialNumber = string.Empty;
					}
					result = global::System.Text.RegularExpressions.Regex.Replace(this._devInfo.SerialNumber, "[^\\w]", "");
				}
				return result;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000A8A4 File Offset: 0x00008AA4
		public override string TEI
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
							this.InitGemstoneCPParameters();
							this._devInfo.TEI = this.GetGemstoneTEI(this._rootBlockCache, this._rootHeadOffset);
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
						{
							ex
						});
						this._devInfo.TEI = string.Empty;
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
						{
							ex2
						});
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic Error", new object[0]);
						this._devInfo.TEI = string.Empty;
					}
					tei = this._devInfo.TEI;
				}
				return tei;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000AA0C File Offset: 0x00008C0C
		public override uint Issi
		{
			get
			{
				uint issi;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (this._devInfo.Issi == -1)
						{
							this.InitGemstoneCPParameters();
							this._devInfo.Issi = this.GetGemstoneIssi(this._rootBlockCache, this._rootHeadOffset);
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
							{
								ex
							});
						}
						this._devInfo.Issi = -1;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
						{
							ex2
						});
						this._devInfo.Issi = -1;
					}
					issi = (uint)this._devInfo.Issi;
				}
				return issi;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000AB20 File Offset: 0x00008D20
		public override string SoftwareVersion
		{
			get
			{
				string softwareVersion;
				lock (this._propertyAccessLock)
				{
					softwareVersion = this.GetSoftwareVersion();
				}
				return softwareVersion;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000AB64 File Offset: 0x00008D64
		public override string CodeplugVersion
		{
			get
			{
				string codeplugVersion;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (string.IsNullOrEmpty(this._devInfo.CodeplugVersion))
						{
							this.InitGemstoneCPParameters();
							this._devInfo.CodeplugVersion = this.GetGemstoneCPVersion(this._rootBlockCache, this._rootHeadOffset);
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
							{
								ex
							});
						}
						this._devInfo.CodeplugVersion = string.Empty;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
						{
							ex2
						});
						this._devInfo.CodeplugVersion = string.Empty;
					}
					codeplugVersion = this._devInfo.CodeplugVersion;
				}
				return codeplugVersion;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000AC88 File Offset: 0x00008E88
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000AE0C File Offset: 0x0000900C
		public override int PartionHealthState
		{
			get
			{
				int partionHealthState;
				lock (this._propertyAccessLock)
				{
					if (this._devInfo.PartionHealthState == -1)
					{
						try
						{
							this._devInfo.PartionHealthState = this.GetBootReason();
							if (this._devInfo.PartionHealthState == 1)
							{
								this._devInfo.PartionHealthState = 15;
							}
							else if (this._devInfo.PartionHealthState == 2)
							{
								this._devInfo.PartionHealthState = 0;
							}
						}
						catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
						{
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
							{
								ex
							});
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
							this._devInfo.PartionHealthState = -1;
						}
						catch (global::System.Exception ex2)
						{
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
							{
								ex2
							});
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic Error", new object[0]);
							this._devInfo.PartionHealthState = -1;
						}
					}
					partionHealthState = this._devInfo.PartionHealthState;
				}
				return partionHealthState;
			}
			set
			{
				lock (this._propertyAccessLock)
				{
					this._devInfo.PartionHealthState = value;
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000AE54 File Offset: 0x00009054
		public override byte[] ARP
		{
			get
			{
				byte[] arp;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (this._devInfo.ARP == null)
						{
							this.InitGemstoneCPParameters();
							this._devInfo.ARP = this.GetGemstoneRadioPassword(this._rootBlockCache, this._rootHeadOffset);
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
							{
								ex
							});
						}
						this._devInfo.ARP = null;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
						{
							ex2
						});
						this._devInfo.ARP = null;
					}
					arp = this._devInfo.ARP;
				}
				return arp;
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000AFCC File Offset: 0x000091CC
		public override void UpdateFlashstrap(ushort modelType, string cpVersion, string flashstrapFilePath, bool bResetProgress)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("LegacyRadio.UpdateFlashstrap");
			try
			{
				if (bResetProgress)
				{
					base.ResetProgress();
				}
				base.RetryMethod(delegate
				{
					global::Motorola.Common.Communication.TetraUtility.SRecord srecord = null;
					this.PrepareFlashstrap(flashstrapFilePath, out srecord);
					this.DoEraseImage(srecord.Image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
					this.DoWriteImage(srecord.Image, this._devInfo.UseCompress, true, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingBootData);
				});
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic exception", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				this.PartionHealthState = -1;
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("LegacyRadio.UpdateFlashstrap", "");
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000B0EC File Offset: 0x000092EC
		public override void ReadRadioLLPHeader(out global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader)
		{
			try
			{
				packHeader = null;
				global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage fplocalLanguage = null;
				base.CreateReleaseID();
				this.CreateFPSlot();
				this.ReadLLP(this._releaseID, this._devInfo.BMPRadioFPSlots, out fplocalLanguage);
				if (fplocalLanguage != null)
				{
					packHeader = fplocalLanguage.PackHeader;
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD0001", "Generic exception", ex2);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000B18C File Offset: 0x0000938C
		public override void ReadRadioLPHeader(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packHeader)
		{
			try
			{
				packHeader = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
				base.CreateReleaseID();
				this.CreateFPSlot();
				global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> dictionary = null;
				global::System.Collections.Generic.List<uint> list = null;
				this.ReadRadioFPInfo(this._releaseID, this._devInfo.BMPRadioFPSlots, out dictionary, out list);
				foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader item in dictionary.Values)
				{
					packHeader.Add(item);
				}
				for (int i = packHeader.Count - 1; i >= 0; i--)
				{
					packHeader[i].select = true;
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD0001", "Generic exception", ex2);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000B2F0 File Offset: 0x000094F0
		public override byte[] ReadRadioLLP()
		{
			global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage llp = null;
			byte[] result;
			try
			{
				base.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingLLP);
				base.CreateReleaseID();
				this.CreateFPSlot();
				base.RetryMethod(delegate
				{
					this.ReadLLP(this._releaseID, this._devInfo.BMPRadioFPSlots, out llp);
					this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadLLPDone);
				});
				if (llp != null)
				{
					result = llp.Data;
				}
				else
				{
					result = null;
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD0001", "Generic exception", ex2);
			}
			return result;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000B41C File Offset: 0x0000961C
		public override void WriteRadioLP(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, string swPath, global::Motorola.Common.Communication.FDT.FDTParams fdtParams, int startPosition, int endPosition, bool bResetProgress = true)
		{
			try
			{
				base.CreateReleaseID();
				this.CreateFPSlot();
				base.RetryMethod(delegate
				{
					this.WriteLP(this._releaseID, this._devInfo.BMPRadioFPSlots, packs, swPath, startPosition, endPosition, bResetProgress);
				});
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD0001", "Generic exception", ex2);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000B518 File Offset: 0x00009718
		public override void WriteRadioLLP(byte[] llp)
		{
			try
			{
				base.CreateReleaseID();
				this.CreateFPSlot();
				base.RetryMethod(delegate
				{
					this.WriteLLP(this._releaseID, this._devInfo.BMPRadioFPSlots, llp);
				});
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD0001", "Generic exception", ex2);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000B5BC File Offset: 0x000097BC
		protected override void EraseFromTo(string from, string to)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.EraseFromTo");
			uint startAddr = 0U;
			uint endAddr = 0U;
			try
			{
				startAddr = global::System.Convert.ToUInt32(from);
				endAddr = global::System.Convert.ToUInt32(to);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0016_RH_CommErrInvalidInputAddress.ToString(), "Invalid input address", innerException);
			}
			global::System.Collections.Generic.List<uint> list = new global::System.Collections.Generic.List<uint>();
			if (!global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GetFlashpackSlotsInAddress(startAddr, endAddr, list))
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0016_RH_CommErrInvalidInputAddress.ToString(), "The address is not valid for erase");
			}
			try
			{
				foreach (uint flashAddress in list)
				{
					uint num = 0U;
					global::Motorola.Common.Communication.SequenceManager.ErrorReason errorReason = global::Motorola.Common.Communication.SequenceManager.ErrorReason.Unknown;
					bool virtualFlashRegionActualSize = this.GetVirtualFlashRegionActualSize(flashAddress, out num, out errorReason);
					if (virtualFlashRegionActualSize && num != 0U)
					{
						base.DoEraseFlash(flashAddress.ToString(), 0U, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
					}
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
			catch (global::System.Exception innerException2)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException2);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraBaseVirtualAddressSeqMgr.EraseFromTo", "");
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000B728 File Offset: 0x00009928
		protected override void Instance_DeviceChanged(object sender, global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs e)
		{
			if (this._disposed)
			{
				return;
			}
			try
			{
				global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType gemstoneRadioType = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetGemstoneRadioType(this.HwID);
				string b = string.Empty;
				string a = string.Empty;
				for (int i = 0; i < e.MsgList.Count; i++)
				{
					if (gemstoneRadioType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.FRODO)
					{
						a = e.MsgList[i].PhysicalLocation;
						b = base.RadioProfile.PhysicalLocation;
					}
					else
					{
						a = e.MsgList[i].RadioId;
						b = base.RadioProfile.RadioIdString;
					}
					if (a == b)
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
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(base.RadioProfile.Path, "Exception in TetraBaseVirtualAddressSeqManager.Instance_DeviceChanged: " + ex.Message);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000B86C File Offset: 0x00009A6C
		protected global::Motorola.Common.Communication.CommonUtil.MemoryImage FastReadImageFreon(string address, uint size, bool bUpdateProgress)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && (string.IsNullOrEmpty(address) || size == 0U || this._transport == null))
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (bUpdateProgress)
			{
				base.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				uint num = size;
				uint num2 = global::System.Convert.ToUInt32(address);
				double num3 = num / global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE;
				bool flag = num >= global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE;
				while (num > 0U)
				{
					if (this._bCancelIO)
					{
						commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0018_RH_CommErrIOCanceled;
						base.CancelSignal.Set();
						break;
					}
					uint num4 = (num > global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE) ? global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE : num;
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
					if (this._devInfo.UseCompress)
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
					if (bUpdateProgress && flag)
					{
						base.IncreaseProgress(1.0 / num3, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
					}
				}
			}
			if (bUpdateProgress)
			{
				base.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
			}
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " inFastReadImage(string address, uint size)");
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
			}
			return memoryImage;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000BA50 File Offset: 0x00009C50
		protected global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageWithExactAddrSize(string address, uint size)
		{
			global::Motorola.Common.Communication.CommonUtil.MemoryImage result = null;
			if (string.IsNullOrEmpty(address))
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "address is null");
			}
			if (size == 0U)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "read size is zeros");
			}
			try
			{
				result = this.ReadImage(address, size, false);
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				if (!(ex.ErrorID == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0021_RH_CommErrReadZeroLengthData.ToString()))
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
					{
						ex
					});
					throw;
				}
				result = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException);
			}
			return result;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000BB20 File Offset: 0x00009D20
		protected byte[] IgnorImageHeader(byte[] data)
		{
			byte[] array = new byte[(long)data.Length - (long)((ulong)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE)];
			global::System.Array.Copy(data, (long)((ulong)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE), array, 0L, (long)data.Length - (long)((ulong)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE));
			return array;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000BB5C File Offset: 0x00009D5C
		protected virtual void GetCPAddressSize(out uint address, out uint size, out global::Motorola.Common.Communication.TetraUtility.FDIVersion fdiVersion)
		{
			fdiVersion = global::Motorola.Common.Communication.TetraUtility.FDIVersion.V5x;
			address = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_RADIO_CP_START_ADDRESS + global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_IMAGE_HEADER_SIZE;
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = base.DoReadImage(global::System.Convert.ToString(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_RADIO_CP_START_ADDRESS), global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_IMAGE_HEADER_SIZE, this._devInfo.UseCompress, false, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
			memoryImage.CompactUnits();
			size = global::System.BitConverter.ToUInt32(memoryImage[0].Data, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_REGION_LENGTH_OFFSET);
			size -= global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_IMAGE_HEADER_SIZE;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		protected virtual byte[] InitGemstoneCPHead(uint cpBodyLength, ushort extType, string cpVersion)
		{
			byte[] array = new byte[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_CP_HEAD_SIZE];
			byte[] bytes = global::System.BitConverter.GetBytes(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_SECTION_ID);
			global::System.Array.Copy(bytes, 0, array, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_SECTION_ID_OFFSET, bytes.Length);
			bytes = global::System.BitConverter.GetBytes(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_CP_HEAD_SIZE + cpBodyLength);
			global::System.Array.Copy(bytes, 0, array, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_IMAGE_SIZE_OFFSET, bytes.Length);
			bytes = global::Motorola.Common.Communication.TetraUtility.CodepageUtil.GetEncoding(1252).GetBytes(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_HEAD_SIGNATURE);
			global::System.Array.Copy(bytes, 0, array, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_IMAGE_VERSION_ID_OFFSET, bytes.Length);
			bytes = global::System.BitConverter.GetBytes(extType);
			global::System.Array.Copy(bytes, 0, array, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_MODEL_TYPE_OFFSET, bytes.Length);
			bytes = global::System.BitConverter.GetBytes(global::Motorola.Common.Communication.TetraUtility.CPVersion.ToUInt32(cpVersion));
			global::System.Array.Copy(bytes, 0, array, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_VERSION_OFFSET, bytes.Length);
			return array;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000BC74 File Offset: 0x00009E74
		protected virtual byte[] GetGemstoneCPImageHeadData()
		{
			byte[] result = null;
			int i = 3;
			while (i > 0)
			{
				try
				{
					uint addr = 0U;
					uint num = 0U;
					global::Motorola.Common.Communication.TetraUtility.FDIVersion fdiversion = global::Motorola.Common.Communication.TetraUtility.FDIVersion.V5x;
					this.GetCPAddressSize(out addr, out num, out fdiversion);
					global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = base.DoReadImage(addr.ToString(), (uint)this.ROOT_BLOCK_CACHE_SIZE, this._devInfo.UseCompress, false, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
					memoryImage.CompactUnits();
					if (memoryImage.Count != 1)
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0003_RH_CommErrBadImage.ToString());
					}
					memoryImage.GetData(addr, (uint)this.ROOT_BLOCK_CACHE_SIZE, out result);
					break;
				}
				catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
					{
						ex
					});
					if (!(ex.ErrorID == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0021_RH_CommErrReadZeroLengthData.ToString()))
					{
						throw;
					}
					i--;
					if (i == 0)
					{
						throw;
					}
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
			return result;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000BDAC File Offset: 0x00009FAC
		protected virtual uint NumOfSubBlocksPos(byte[] cpRawData)
		{
			uint result = 0U;
			try
			{
				if (cpRawData == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug raw data is null!");
				}
				byte b = global::System.Convert.ToByte('R');
				byte b2 = global::System.Convert.ToByte('T');
				int i = 0;
				while (i < cpRawData.Length)
				{
					if (cpRawData[i] == b && cpRawData[i + 1] == b2)
					{
						if (i == 6)
						{
							result = (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_WORD_SIZE_PTR;
							break;
						}
						result = (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_DWORD_SIZE_PTR;
						break;
					}
					else
					{
						i++;
					}
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
			return result;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000BEA0 File Offset: 0x0000A0A0
		protected virtual uint VersionRatio(uint numOfSubBlockPos)
		{
			uint result = 0U;
			try
			{
				if (numOfSubBlockPos == 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "postion of number of sub blocks is zero!");
				}
				if (numOfSubBlockPos == (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_WORD_SIZE_PTR)
				{
					result = 1U;
				}
				else
				{
					result = 3U;
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
			return result;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000BF58 File Offset: 0x0000A158
		protected virtual uint GeneralBlocksOffset(uint numOfSubBlocksPos, byte[] cpRawData)
		{
			uint result = 0U;
			try
			{
				if (numOfSubBlocksPos == 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "postion of number of sub blocks is zero!");
				}
				if (cpRawData == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug raw data is null!");
				}
				if (numOfSubBlocksPos == (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_WORD_SIZE_PTR)
				{
					result = (uint)(cpRawData[(int)numOfSubBlocksPos] * 2);
				}
				else
				{
					result = (uint)(cpRawData[(int)numOfSubBlocksPos] * 4);
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
			return result;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000C030 File Offset: 0x0000A230
		protected virtual uint RootBlockHeadOffset(byte[] cpRawData)
		{
			uint num = 0U;
			try
			{
				if (cpRawData == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug raw data is null!");
				}
				uint num2 = this.NumOfSubBlocksPos(cpRawData);
				num += num2;
				num += this.VersionRatio(num2);
				num += this.GeneralBlocksOffset(num2, cpRawData);
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
			return num;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000C100 File Offset: 0x0000A300
		protected virtual void InitGemstoneCPParameters()
		{
			try
			{
				if (!this._rootBlockIsBad)
				{
					if (this._rootBlockCache == null)
					{
						this._rootBlockIsBad = true;
						this._rootBlockCache = this.GetGemstoneCPImageHeadData();
						this._rootBlockIsBad = false;
					}
					if (this._rootHeadOffset == 0U)
					{
						this._rootHeadOffset = this.RootBlockHeadOffset(this._rootBlockCache);
					}
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

		// Token: 0x06000141 RID: 321 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		protected virtual byte[] GemstoneReadCPDataFromRootBlock(uint offset, ushort size)
		{
			byte[] array = null;
			try
			{
				this.InitGemstoneCPParameters();
				int sourceIndex = (int)(this._rootHeadOffset + offset);
				if (this._rootBlockCache == null || (int)size > this._rootBlockCache.Length)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0002_RH_CommErrDataSize.ToString());
				}
				array = new byte[(int)size];
				global::System.Array.Copy(this._rootBlockCache, sourceIndex, array, 0, (int)size);
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
			return array;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
		protected virtual string GetGemstoneRadioVersion(byte[] rawCPData, uint rootHeadOffset)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			try
			{
				if (rawCPData == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug raw data is null!");
				}
				if (rootHeadOffset == 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "wrong value of offset of root block head!");
				}
				uint num = rootHeadOffset + (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_RADIO_VER_OFFSET;
				uint num2 = num;
				uint num3 = 0U;
				while (rawCPData[(int)((global::System.UIntPtr)num2)] != 0 && num2 < (uint)rawCPData.Length && num3 < (uint)this.SOFTWARE_NAME_LENGTH)
				{
					stringBuilder.Append((char)rawCPData[(int)((global::System.UIntPtr)num2)]);
					num3 += 1U;
					num2 += 1U;
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
			return stringBuilder.ToString();
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000C3BC File Offset: 0x0000A5BC
		protected virtual string GetGemstoneSerialNumber(byte[] rawCPData, uint rootHeadOffset)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			try
			{
				if (rawCPData == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug raw data is null!");
				}
				if (rootHeadOffset == 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "wrong value of offset of root block head!");
				}
				uint num = rootHeadOffset + (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_SERIAL_NUM_OFFSET;
				uint num2 = num;
				uint num3 = 0U;
				while (rawCPData[(int)((global::System.UIntPtr)num2)] != 0 && num2 < (uint)rawCPData.Length && num3 < this.SERIAL_NUMBER_LENGTH)
				{
					stringBuilder.Append((char)rawCPData[(int)((global::System.UIntPtr)num2)]);
					num3 += 1U;
					num2 += 1U;
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
			return stringBuilder.ToString();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		protected virtual string GetGemstoneCPVersion(byte[] rawCPData, uint rootHeadOffset)
		{
			string result;
			try
			{
				if (rawCPData == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug raw data is null!");
				}
				if (rootHeadOffset == 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "wrong value of offset of root block head!");
				}
				uint num = rootHeadOffset + (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_STRUCT_VER_OFFSET;
				uint num2 = rootHeadOffset + (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_DEFAULT_VER_OFFSET;
				global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder = this.GetByteOrder();
				byte[] array = new byte[]
				{
					rawCPData[(int)((global::System.UIntPtr)num)],
					rawCPData[(int)((global::System.UIntPtr)(num + 1U))]
				};
				byte[] array2 = new byte[]
				{
					rawCPData[(int)((global::System.UIntPtr)num2)],
					rawCPData[(int)((global::System.UIntPtr)(num2 + 1U))]
				};
				if (byteOrder != global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
				{
					global::System.Array.Reverse(array);
					global::System.Array.Reverse(array2);
				}
				result = new global::Motorola.Common.Communication.TetraUtility.CPVersion(array, array2).ToString();
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
			return result;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		protected virtual string GetGemstoneModelNumber(byte[] rawCPData, uint rootHeadOffset)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			try
			{
				if (rawCPData == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug raw data is null!");
				}
				if (rootHeadOffset == 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "wrong value of offset of root block head!");
				}
				uint num = rootHeadOffset + (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_MODEL_NUM_OFFSET;
				uint num2 = num;
				while (rawCPData[(int)((global::System.UIntPtr)num2)] != 0 && num2 < (uint)rawCPData.Length)
				{
					stringBuilder.Append((char)rawCPData[(int)((global::System.UIntPtr)num2)]);
					num2 += 1U;
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
			return stringBuilder.ToString();
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
		protected virtual ushort GetGemstoneHomeMCC(byte[] rawCPData, uint rootHeadOffset)
		{
			ushort result = 0;
			try
			{
				if (rawCPData == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug raw data is null!");
				}
				if (rootHeadOffset == 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "wrong value of offset of root block head!");
				}
				uint num = rootHeadOffset + (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_HOME_MCC_OFFSET;
				byte[] array = new byte[]
				{
					rawCPData[(int)((global::System.UIntPtr)num)],
					rawCPData[(int)((global::System.UIntPtr)(num + 1U))]
				};
				global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder = this.GetByteOrder();
				if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
				{
					global::System.Array.Reverse(array);
					result = global::System.BitConverter.ToUInt16(array, 0);
				}
				else
				{
					result = global::System.BitConverter.ToUInt16(array, 0);
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
			return result;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000C800 File Offset: 0x0000AA00
		protected virtual int GetGemstoneHomeMNC(byte[] rawCPData, uint rootHeadOffset)
		{
			ushort result = 0;
			try
			{
				if (rawCPData == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug raw data is null!");
				}
				if (rootHeadOffset == 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "wrong value of offset of root block head!");
				}
				uint num = rootHeadOffset + (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_HOME_MNC_OFFSET;
				byte[] array = new byte[]
				{
					rawCPData[(int)((global::System.UIntPtr)num)],
					rawCPData[(int)((global::System.UIntPtr)(num + 1U))]
				};
				global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder = this.GetByteOrder();
				if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
				{
					global::System.Array.Reverse(array);
					result = global::System.BitConverter.ToUInt16(array, 0);
				}
				else
				{
					result = global::System.BitConverter.ToUInt16(array, 0);
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
			return (int)result;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000C90C File Offset: 0x0000AB0C
		protected virtual int GetGemstoneIssi(byte[] rawCPData, uint rootHeadOffset)
		{
			int result;
			try
			{
				if (rawCPData == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug raw data is null!");
				}
				if (rootHeadOffset == 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "wrong value of offset of root block head!");
				}
				uint num = rootHeadOffset + (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_ISSI_OFFSET;
				byte[] array = new byte[4];
				global::System.Array.Copy(rawCPData, (long)((ulong)num), array, 0L, (long)array.Length);
				global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder = this.GetByteOrder();
				if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
				{
					global::System.Array.Reverse(array);
				}
				result = (int)global::System.BitConverter.ToUInt32(array, 0);
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
			return result;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000CA0C File Offset: 0x0000AC0C
		protected virtual string GetGemstoneTEI(byte[] rawCPData, uint rootHeadOffset)
		{
			string result;
			try
			{
				if (rawCPData == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug raw data is null!");
				}
				if (rootHeadOffset == 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "wrong value of offset of root block head!");
				}
				uint num = rootHeadOffset + (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_TEI_OFFSET;
				int startIndex = 15;
				byte[] array = new byte[8];
				global::System.Array.Copy(rawCPData, (long)((ulong)num), array, 0L, (long)array.Length);
				string text = string.Empty;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(string.Format("{0:X2}", array[i]));
				}
				stringBuilder.Remove(startIndex, 1);
				text = stringBuilder.ToString();
				result = text;
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
			return result;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000CB48 File Offset: 0x0000AD48
		protected virtual byte[] GetGemstoneRadioPassword(byte[] rawCPData, uint rootHeadOffset)
		{
			byte[] result;
			try
			{
				if (rawCPData == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug raw data is null!");
				}
				if (rootHeadOffset == 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "wrong value of offset of root block head!");
				}
				uint num = rootHeadOffset + (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_RPP_OFFSET;
				byte[] array = new byte[100];
				global::System.Array.Copy(rawCPData, (long)((ulong)num), array, 0L, (long)array.Length);
				result = array;
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
			return result;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000CC30 File Offset: 0x0000AE30
		protected bool AddressValidInVirtualFlashRegion(uint flashAddress, out uint adjAdd)
		{
			bool flag = true;
			adjAdd = 0U;
			try
			{
				uint num;
				global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType gemstoneFlashType;
				flag = global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GetGemstoneFlashRegionInfo(flashAddress, out num, out gemstoneFlashType);
				if (!flag)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "invalid virtual flash address");
				}
				flag = false;
				switch (gemstoneFlashType)
				{
				case global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.BOOT2:
					if (flashAddress < num + global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_BOOT2_REGION_SIZE)
					{
						flag = true;
					}
					else
					{
						adjAdd = num + global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_BOOT2_REGION_SIZE - 1U;
					}
					break;
				case global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.RELINF:
					if (flashAddress < num + global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GetReleaseInfoSize(this.CommonModelNumber, this.CodeplugVersion))
					{
						flag = true;
					}
					else
					{
						adjAdd = num + global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GetReleaseInfoSize(this.CommonModelNumber, this.CodeplugVersion) - 1U;
					}
					break;
				default:
				{
					uint num2 = 0U;
					global::Motorola.Common.Communication.SequenceManager.ErrorReason errorReason = global::Motorola.Common.Communication.SequenceManager.ErrorReason.Unknown;
					flag = this.GetVirtualFlashRegionActualSize(num, out num2, out errorReason);
					if (flag)
					{
						flag = false;
						if (flashAddress < num + num2)
						{
							flag = true;
						}
						else
						{
							adjAdd = num + num2 - 1U;
						}
					}
					else
					{
						adjAdd = num;
					}
					break;
				}
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
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException);
			}
			return flag;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000CD5C File Offset: 0x0000AF5C
		protected bool GetVirtualFlashRegionActualSize(uint flashAddress, out uint actualSize, out global::Motorola.Common.Communication.SequenceManager.ErrorReason reason)
		{
			bool flag = true;
			actualSize = 0U;
			reason = global::Motorola.Common.Communication.SequenceManager.ErrorReason.Unknown;
			uint startAdd = 0U;
			global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType gemstoneFlashType = global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.UNKNOWN;
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = null;
			try
			{
				if (!global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GetGemstoneFlashRegionInfo(flashAddress, out startAdd, out gemstoneFlashType))
				{
					reason = global::Motorola.Common.Communication.SequenceManager.ErrorReason.InvalidAddress;
					flag = false;
				}
				if (flag)
				{
					switch (gemstoneFlashType)
					{
					case global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.BOOT2:
						if (this.ReadVirtualFlashRegionHeader(startAdd, true, out memoryImage, out reason))
						{
							memoryImage.CompactUnits();
							actualSize = global::System.BitConverter.ToUInt32(memoryImage[0].Data, 4);
							actualSize = ((actualSize <= global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_BOOT2_REGION_SIZE) ? actualSize : global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_BOOT2_REGION_SIZE);
						}
						else
						{
							flag = false;
						}
						break;
					case global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType.RELINF:
						if (this.ReadVirtualFlashRegionHeader(startAdd, true, out memoryImage, out reason))
						{
							actualSize = global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GetReleaseInfoSize(this.CommonModelNumber, this.CodeplugVersion);
						}
						else
						{
							flag = false;
						}
						break;
					default:
						if (this.ReadVirtualFlashRegionHeader(startAdd, false, out memoryImage, out reason))
						{
							memoryImage.CompactUnits();
							actualSize = global::System.BitConverter.ToUInt32(memoryImage[0].Data, 4);
						}
						else
						{
							flag = false;
						}
						break;
					}
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
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException);
			}
			return flag;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		protected bool ParseVirtualFlashRegions(uint startAddress, uint endAddress, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr.VirtualFlashInfo> flashInfoList)
		{
			bool flag = true;
			flashInfoList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr.VirtualFlashInfo>();
			uint num = 0U;
			global::Motorola.Common.Communication.SequenceManager.ErrorReason errorReason = global::Motorola.Common.Communication.SequenceManager.ErrorReason.Unknown;
			try
			{
				if (endAddress <= startAddress)
				{
					return false;
				}
				if (!global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.AddressInGemstoneFlashRegion(startAddress) || !global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.AddressInGemstoneFlashRegion(endAddress))
				{
					return false;
				}
				flag = this.AddressValidInVirtualFlashRegion(startAddress, out num);
				if (!flag)
				{
					startAddress = num;
				}
				flag = this.AddressValidInVirtualFlashRegion(endAddress, out num);
				if (!flag)
				{
					endAddress = num;
				}
				flag = true;
				uint actualSize = 0U;
				bool flag2 = true;
				uint num2 = startAddress;
				while (flag)
				{
					flag = this.GetVirtualFlashRegionActualSize(num2, out actualSize, out errorReason);
					if (flag)
					{
						global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr.VirtualFlashInfo virtualFlashInfo = new global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr.VirtualFlashInfo();
						virtualFlashInfo.StartAddress = num2;
						virtualFlashInfo.ActualSize = actualSize;
						if (flag2)
						{
							num2 += virtualFlashInfo.ActualSize - (num2 - global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GetRegionStartAddress(num2)) - 1U;
						}
						else
						{
							num2 += virtualFlashInfo.ActualSize - 1U;
						}
						if (num2 < endAddress)
						{
							if (flag2)
							{
								virtualFlashInfo.SizeNeedToRead = virtualFlashInfo.ActualSize - (virtualFlashInfo.StartAddress - global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GetRegionStartAddress(num2));
								flag2 = false;
							}
							else
							{
								virtualFlashInfo.SizeNeedToRead = virtualFlashInfo.ActualSize;
							}
							flashInfoList.Add(virtualFlashInfo);
							flag = global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.JumpToNextRegionStart(num2, out num2);
							if (num2 > endAddress)
							{
								break;
							}
						}
						else
						{
							if (endAddress != virtualFlashInfo.StartAddress)
							{
								if (endAddress > virtualFlashInfo.StartAddress + virtualFlashInfo.ActualSize)
								{
									virtualFlashInfo.SizeNeedToRead = virtualFlashInfo.ActualSize;
								}
								else
								{
									virtualFlashInfo.SizeNeedToRead = endAddress - virtualFlashInfo.StartAddress + 1U;
								}
								flashInfoList.Add(virtualFlashInfo);
								break;
							}
							break;
						}
					}
					else
					{
						if (flag || errorReason != global::Motorola.Common.Communication.SequenceManager.ErrorReason.NoImageHead)
						{
							break;
						}
						if (flag2)
						{
							flag2 = false;
						}
						flag = true;
						flag = global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.JumpToNextRegionStart(num2, out num2);
						if (num2 > endAddress)
						{
							break;
						}
					}
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
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException);
			}
			return flag;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		protected bool ReadVirtualFlashRegionHeader(uint startAdd, bool bRetry, out global::Motorola.Common.Communication.CommonUtil.MemoryImage headerImage, out global::Motorola.Common.Communication.SequenceManager.ErrorReason reason)
		{
			bool result = true;
			reason = global::Motorola.Common.Communication.SequenceManager.ErrorReason.Unknown;
			headerImage = null;
			int i = 0;
			if (bRetry)
			{
				i = 3;
			}
			else
			{
				i = 1;
			}
			while (i > 0)
			{
				try
				{
					headerImage = base.DoReadImage(startAdd.ToString(), 32U, this._devInfo.UseCompress, false, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
					break;
				}
				catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
				{
					if (!(ex.ErrorID == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0021_RH_CommErrReadZeroLengthData.ToString()))
					{
						result = false;
						reason = global::Motorola.Common.Communication.SequenceManager.ErrorReason.Unknown;
						break;
					}
					i--;
					if (i == 0)
					{
						result = false;
						reason = global::Motorola.Common.Communication.SequenceManager.ErrorReason.NoImageHead;
					}
				}
				catch (global::System.Exception)
				{
					result = false;
					reason = global::Motorola.Common.Communication.SequenceManager.ErrorReason.NoImageHead;
					break;
				}
			}
			return result;
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000D14C File Offset: 0x0000B34C
		protected override string ModelNumber
		{
			get
			{
				string modelNumber;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (string.IsNullOrEmpty(this._devInfo.ModelNumber))
						{
							this.InitGemstoneCPParameters();
							this._devInfo.ModelNumber = this.GetGemstoneModelNumber(this._rootBlockCache, this._rootHeadOffset);
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
							{
								ex
							});
						}
						this._devInfo.ModelNumber = string.Empty;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
						{
							ex2
						});
						this._devInfo.ModelNumber = string.Empty;
					}
					modelNumber = this._devInfo.ModelNumber;
				}
				return modelNumber;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000D270 File Offset: 0x0000B470
		protected void CleanCorruptFlag()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.CleanCorruptFlag");
			try
			{
				global::Motorola.Common.Communication.SBEPCleanCorruptFlag sbepcleanCorruptFlag = new global::Motorola.Common.Communication.SBEPCleanCorruptFlag(base.Transport);
				sbepcleanCorruptFlag.ExecuteMessage();
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepcleanCorruptFlag.OperationResult);
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD1015_PR_CommErrSBEPUnsupportReply)
					{
						if (this._transport != null)
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in GetCpuID()");
						}
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
					}
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
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraBaseVirtualAddressSeqMgr.CleanCorruptFlag", "");
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000D37C File Offset: 0x0000B57C
		protected void SetCorruptFlag()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseVirtualAddressSeqMgr.SetCorruptFlag");
			try
			{
				global::Motorola.Common.Communication.SBEPSetCorruptFlag sbepsetCorruptFlag = new global::Motorola.Common.Communication.SBEPSetCorruptFlag(base.Transport);
				sbepsetCorruptFlag.ExecuteMessage();
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepsetCorruptFlag.OperationResult);
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD1015_PR_CommErrSBEPUnsupportReply)
					{
						if (this._transport != null)
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in GetCpuID()");
						}
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
					}
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
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", innerException);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraBaseVirtualAddressSeqMgr.SetCorruptFlag", "");
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000D488 File Offset: 0x0000B688
		protected override void TestFdtCmd(global::Motorola.Common.Communication.CommonUtil.TestFDTCmdInfo fdtInfo, out string strResult)
		{
			strResult = "This model does not support FDT";
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000D494 File Offset: 0x0000B694
		private ushort GetRadioModelType()
		{
			ushort result;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.MCCConverter.IsHomeMccEncrypted(this.HomeMCC))
				{
					result = 0;
				}
				else
				{
					global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel(this.ModelNumber, global::Motorola.Common.Communication.TetraUtility.MCCConverter.ToString(this.HomeMCC));
					if (model == null)
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "model interface is null!");
					}
					result = (ushort)model.ModelType;
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
					{
						ex
					});
				}
				result = 0;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex2
				});
				result = 0;
			}
			return result;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000D57C File Offset: 0x0000B77C
		private string GetSoftwareVersion()
		{
			try
			{
				if (string.IsNullOrEmpty(this._devInfo.SoftwareVersion))
				{
					this.InitGemstoneCPParameters();
					this._devInfo.SoftwareVersion = this.GetGemstoneRadioVersion(this._rootBlockCache, this._rootHeadOffset);
					if (string.IsNullOrEmpty(this._devInfo.SoftwareVersion))
					{
						global::Motorola.Common.Communication.TetraUtility.ReleaseID releaseID = new global::Motorola.Common.Communication.TetraUtility.ReleaseID();
						byte[] releaseIDImageData = this.GetReleaseIDImageData();
						global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
						if (!releaseID.Init(this.ByteOrder, (uint)this.ModelType, this.CodeplugVersion, releaseIDImageData, out commRC))
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5050_FP_CommErrFPInitError.ToString(), "Internal Error is: " + commRC.ToString());
						}
						string empty = string.Empty;
						if (!releaseID.GetStrSwInfo(out empty))
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5078_FP_NoSoftwareVersionInfoInReleaseID.ToString());
						}
						this._devInfo.SoftwareVersion = empty;
					}
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
					{
						ex
					});
				}
				this._devInfo.SoftwareVersion = string.Empty;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex2
				});
				this._devInfo.SoftwareVersion = string.Empty;
			}
			return global::System.Text.RegularExpressions.Regex.Replace(this._devInfo.SoftwareVersion, "[^\\u0000-\\u007F]", "").Trim();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000D724 File Offset: 0x0000B924
		private void DoRestorePDV2Radio()
		{
			global::Motorola.Common.Communication.SBEPRestorePDV2Radio sbeprestorePDV2Radio = new global::Motorola.Common.Communication.SBEPRestorePDV2Radio(this._transport);
			sbeprestorePDV2Radio.ExecuteMessage();
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbeprestorePDV2Radio.OperationResult);
			if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				if (this._transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in RestorePDV2Radio()");
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000D794 File Offset: 0x0000B994
		private global::System.Collections.Generic.Dictionary<string, string> DoGetPlatformInfo()
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && this._transport == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPGetPlatformInfo sbepgetPlatformInfo = new global::Motorola.Common.Communication.SBEPGetPlatformInfo(this._transport);
				sbepgetPlatformInfo.ExecuteMessage();
				commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepgetPlatformInfo.OperationResult);
				if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					byte[] array = new byte[sbepgetPlatformInfo.Data.Length];
					global::System.Array.Copy(sbepgetPlatformInfo.Data, array, sbepgetPlatformInfo.Data.Length);
					string @string = global::System.Text.Encoding.ASCII.GetString(array);
					char[] trimChars = new char[1];
					string xml = @string.Trim(trimChars);
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.LoadXml(xml);
					using (global::System.Collections.IEnumerator enumerator = xmlDocument.DocumentElement.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							global::System.Xml.XmlElement xmlElement = (global::System.Xml.XmlElement)obj;
							if (xmlElement != null)
							{
								dictionary.Add(xmlElement.Name, xmlElement.InnerText.Trim());
							}
						}
						return dictionary;
					}
				}
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD1015_PR_CommErrSBEPUnsupportReply)
				{
					if (this._transport != null)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in GetPlatformInfo()");
					}
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
				}
			}
			return dictionary;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000D8E0 File Offset: 0x0000BAE0
		private int GetBootReason()
		{
			global::Motorola.Common.Communication.SBEPGetBootModeReason sbepgetBootModeReason = new global::Motorola.Common.Communication.SBEPGetBootModeReason(base.Transport);
			sbepgetBootModeReason.ExecuteMessage();
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepgetBootModeReason.OperationResult);
			int result;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				result = sbepgetBootModeReason.BootReason;
			}
			else
			{
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD1015_PR_CommErrSBEPUnsupportReply)
				{
					if (this._transport != null)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._transport.PortName, commRC.ToString() + " in GetBootReason()");
					}
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString());
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000D964 File Offset: 0x0000BB64
		private void CreateFPSlot()
		{
			uint num = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_START_ADDRESS;
			this._devInfo.BMPRadioFPSlots[0] = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_START_ADDRESS;
			for (int i = 1; i < global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_SLOTS_NUMBER; i++)
			{
				this._devInfo.BMPRadioFPSlots[i] = num + global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_SLOT_SIZE;
				num = this._devInfo.BMPRadioFPSlots[i];
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000D9BB File Offset: 0x0000BBBB
		private ushort GetDecrypedGemstoneHomeMCC(byte[] rawCPData, uint rootHeadOffset)
		{
			return (ushort)global::Motorola.Common.Communication.TetraUtility.MCCConverter.DecrypteHomeMcc(global::System.Convert.ToUInt32(this.GetGemstoneHomeMCC(rawCPData, rootHeadOffset)));
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		private bool BackupFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType regionType, out string backupFilePath, out global::Motorola.Common.Communication.CommonUtil.CommRC errorReason)
		{
			backupFilePath = string.Empty;
			uint num = 0U;
			uint num2 = 0U;
			errorReason = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = null;
			bool flag = global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GetRegionStartEndAddByType(regionType, out num, out num2);
			if (flag)
			{
				base.ResetProgress();
				memoryImage = this.ReadImage(num.ToString(), num2 - num + 1U, true);
			}
			if (memoryImage == null)
			{
				flag = false;
				errorReason = global::Motorola.Common.Communication.CommonUtil.CommRC.RF0001_FlashRegionOperation_FaiedToReadRegion;
			}
			if (flag)
			{
				string fullPath = global::System.IO.Path.GetFullPath(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FlashRegionBackupDir);
				if (!global::System.IO.Directory.Exists(fullPath))
				{
					global::System.IO.Directory.CreateDirectory(fullPath);
					global::System.IO.FileAttributes attributes = global::System.IO.File.GetAttributes(fullPath);
					global::System.IO.File.SetAttributes(fullPath, attributes | global::System.IO.FileAttributes.Hidden);
				}
				string text = fullPath + "\\" + regionType.ToString();
				text = global::System.IO.Path.GetFullPath(text);
				if (!global::System.IO.Directory.Exists(text))
				{
					global::System.IO.Directory.CreateDirectory(text);
					global::System.IO.FileAttributes attributes2 = global::System.IO.File.GetAttributes(text);
					global::System.IO.File.SetAttributes(text, attributes2 | global::System.IO.FileAttributes.Hidden);
				}
				string str = this.CpuID + ".s19";
				string text2 = text + "\\" + str;
				global::Motorola.Common.Communication.TetraUtility.SRecord srecord = new global::Motorola.Common.Communication.TetraUtility.SRecord();
				string text3 = "^s=Flash Report^o=";
				text3 += string.Format("{0:D}", global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.EBO_INTEL);
				flag = srecord.LoadFromImage(memoryImage, text3, 28U);
				if (!flag)
				{
					errorReason = global::Motorola.Common.Communication.CommonUtil.CommRC.RF0005_FlashRegionOperation_FailedToConstructSRecordFromImage;
				}
				if (flag)
				{
					flag = srecord.WriteToS19WithCryptAndCompress(text2);
				}
				if (flag)
				{
					backupFilePath = text2;
				}
			}
			if (!flag && errorReason == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				errorReason = global::Motorola.Common.Communication.CommonUtil.CommRC.RF0002_FlashRegionOperation_FailedToConvertImageToFile;
			}
			return flag;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000DB24 File Offset: 0x0000BD24
		private bool WriteFlashRegion(string regionRecordPath, out global::Motorola.Common.Communication.CommonUtil.CommRC errorReason)
		{
			bool flag = false;
			errorReason = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			string text = global::System.IO.Path.GetExtension(regionRecordPath);
			text = text.ToLower(global::System.Globalization.CultureInfo.CurrentCulture);
			if (text == ".s19")
			{
				global::Motorola.Common.Communication.TetraUtility.SRecord srecord = new global::Motorola.Common.Communication.TetraUtility.SRecord();
				if (!global::System.IO.File.Exists(regionRecordPath))
				{
					errorReason = global::Motorola.Common.Communication.CommonUtil.CommRC.RF0003_FlashRegionOperation_CanNotFindImageBackupFile;
				}
				flag = srecord.LoadFromFile(regionRecordPath);
				if (flag)
				{
					srecord.Image.CompactUnits();
					base.DoEraseImage(srecord.Image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
					base.DoWriteImage(srecord.Image, this._devInfo.UseCompress, false, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage);
				}
				else
				{
					errorReason = global::Motorola.Common.Communication.CommonUtil.CommRC.RF0004_FlashRegionOperation_FailedToLoadImageFromBackupFile;
				}
			}
			else
			{
				errorReason = global::Motorola.Common.Communication.CommonUtil.CommRC.RF0006_FlashRegionOperation_InvalidBackupFileFormat;
			}
			return flag;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		protected override byte[] GetReleaseIDImageData()
		{
			global::Motorola.Common.Communication.TetraUtility.FlashAttribute flashAttribute;
			if (!base.GetFlashAttributes(out flashAttribute))
			{
				return null;
			}
			uint[] array = new uint[]
			{
				global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetReleaseIDPointer(this.CodeplugVersion, this.CommonModelNumber),
				201654336U,
				202506304U
			};
			byte[] result = null;
			foreach (uint num in array)
			{
				try
				{
					uint num2 = 0U;
					num2 = num;
					if (this.ByteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.UnknowType)
					{
						return result;
					}
					if (this.ByteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
					{
						global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref num2);
					}
					bool flag = global::Motorola.Common.Communication.TetraUtility.TetraUtil.CheckFPExisting(this.CommonModelNumber, this.CodeplugVersion);
					uint num3;
					if (flag)
					{
						num3 = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RELEASE_ID_SIZE_WITH_FP;
					}
					else
					{
						num3 = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RELEASE_ID_SIZE_WITHOUT_FP;
					}
					if (flashAttribute.startAddr <= num2 && num2 <= flashAttribute.lastAddr - num3)
					{
						global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.ReadImage(num2.ToString(), num3, false);
						memoryImage.CompactUnits();
						if (memoryImage.Count == 1 && (long)memoryImage[0].Data.Length == (long)((ulong)num3))
						{
							result = memoryImage[0].Data;
							break;
						}
					}
				}
				catch
				{
				}
			}
			return result;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		protected global::Motorola.Common.Communication.TetraUtility.FPBase CreatePack(global::Motorola.Common.Communication.CommonUtil.MemoryImage fpImage, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID)
		{
			if (fpImage == null || fpImage.Size == 0U)
			{
				return null;
			}
			fpImage.CompactUnits();
			global::Motorola.Common.Communication.CommonUtil.fp_header_t fp_header_t = new global::Motorola.Common.Communication.CommonUtil.fp_header_t();
			fp_header_t.GetHeaderfromRawData(fpImage[0].Data);
			if (global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.AnalizeHeader(fp_header_t, resID, this.ByteOrder))
			{
				return this.CreatePack(fp_header_t, fpImage[0].Data);
			}
			return null;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000DD50 File Offset: 0x0000BF50
		protected bool ReadHeader(uint addr, global::Motorola.Common.Communication.CommonUtil.fp_header_t header)
		{
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.ReadImageWithExactAddrSize(addr.ToString(), global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE + 16U);
			memoryImage.CompactUnits();
			if (memoryImage.Count != 0)
			{
				byte[] raw = this.IgnorImageHeader(memoryImage[0].Data);
				header.GetHeaderfromRawData(raw);
				return true;
			}
			return false;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		protected bool ReadPack(uint addr, uint size, out byte[] buffer)
		{
			buffer = null;
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.ReadImageWithExactAddrSize(addr.ToString(), size);
			memoryImage.CompactUnits();
			if (memoryImage.Count != 0)
			{
				byte[] array = new byte[memoryImage.Size];
				int num = 0;
				for (int i = 0; i < memoryImage.Count; i++)
				{
					global::System.Array.Copy(memoryImage[i].Data, 0, array, num, memoryImage[i].Data.Length);
					num += memoryImage[i].Data.Length;
				}
				buffer = this.IgnorImageHeader(array);
				return true;
			}
			return false;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000DE2C File Offset: 0x0000C02C
		protected bool PackIsHealthy(uint startAddr, global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader)
		{
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.ReadImageWithExactAddrSize(startAddr.ToString(), global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE + packHeader.size);
			memoryImage.CompactUnits();
			byte[] array = new byte[memoryImage.Size];
			int num = 0;
			for (int i = 0; i < memoryImage.Count; i++)
			{
				global::System.Array.Copy(memoryImage[i].Data, 0, array, num, memoryImage[i].Data.Length);
				num += memoryImage[i].Data.Length;
			}
			byte[] array2 = this.IgnorImageHeader(array);
			uint num2 = memoryImage.Size - global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE;
			if (num2 == packHeader.size)
			{
				global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t type = packHeader.type;
				global::Motorola.Common.Communication.TetraUtility.FPBase fpbase;
				switch (type)
				{
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LANGUAGE_PACK:
					fpbase = new global::Motorola.Common.Communication.TetraUtility.FPLanguagePack(array2, packHeader.size, this.ByteOrder);
					break;
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.FONT_PACK:
					fpbase = new global::Motorola.Common.Communication.TetraUtility.FPFontPack(array2, packHeader.size, this.ByteOrder);
					break;
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.THEME_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.ICON_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.STATUSAREA_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.PICTURE_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.CONFIG_PACK:
				case global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.PALETTE_PACK:
					fpbase = new global::Motorola.Common.Communication.TetraUtility.FPMandatoryPack(array2, packHeader.size, this.ByteOrder);
					break;
				default:
					if (type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
					{
						return false;
					}
					fpbase = new global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage(array2, packHeader.size, this.ByteOrder);
					break;
				}
				return fpbase != null && fpbase.IsChecksumCorrect();
			}
			return false;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000DF7C File Offset: 0x0000C17C
		protected global::Motorola.Common.Communication.TetraUtility.FPBase CreatePack(global::Motorola.Common.Communication.CommonUtil.fp_header_t header, byte[] data)
		{
			if (data == null || data.Length == 0 || header.pack_size == 0U)
			{
				return null;
			}
			global::Motorola.Common.Communication.TetraUtility.FPBase fpbase = null;
			byte pack_type = header.pack_type;
			switch (pack_type)
			{
			case 1:
				fpbase = new global::Motorola.Common.Communication.TetraUtility.FPLanguagePack(data, header.pack_size, this.ByteOrder);
				break;
			case 2:
				fpbase = new global::Motorola.Common.Communication.TetraUtility.FPFontPack(data, header.pack_size, this.ByteOrder);
				break;
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
				fpbase = new global::Motorola.Common.Communication.TetraUtility.FPMandatoryPack(data, header.pack_size, this.ByteOrder);
				break;
			default:
				if (pack_type == 100)
				{
					fpbase = new global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage(data, header.pack_size, this.ByteOrder);
				}
				break;
			}
			if (fpbase != null && !fpbase.InitData())
			{
				fpbase = null;
			}
			return fpbase;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000E034 File Offset: 0x0000C234
		private static byte[] InitFPImageHeader(byte[] packData)
		{
			byte[] array = new byte[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE];
			byte[] bytes = global::System.BitConverter.GetBytes(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_ID);
			global::System.Array.Copy(bytes, 0, array, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SECTION_ID_OFFSET, bytes.Length);
			bytes = global::System.BitConverter.GetBytes((long)((ulong)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE + (ulong)((long)packData.Length)));
			global::System.Array.Copy(bytes, 0, array, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_SIZE_OFFSET, bytes.Length);
			return array;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000E08C File Offset: 0x0000C28C
		protected global::Motorola.Common.Communication.CommonUtil.PackHeader ReadAnalizellpInfo(uint llpAddr, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID)
		{
			global::Motorola.Common.Communication.CommonUtil.PackHeader result = null;
			global::Motorola.Common.Communication.CommonUtil.fp_header_t fp_header_t = new global::Motorola.Common.Communication.CommonUtil.fp_header_t();
			bool flag = true;
			byte[] array = null;
			byte[] array2 = new byte[16];
			if (!this.ReadPack(llpAddr, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE + 16U + 32U, out array))
			{
				flag = false;
			}
			else if ((long)array.Length >= 16L)
			{
				global::System.Array.Copy(array, 0L, array2, 0L, 16L);
				fp_header_t.GetHeaderfromRawData(array2);
			}
			else
			{
				flag = false;
			}
			if (flag && !global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.AnalizeHeader(fp_header_t, resID, this.ByteOrder))
			{
				flag = false;
			}
			if (flag && fp_header_t.pack_size == 0U)
			{
				flag = false;
			}
			if (flag)
			{
				result = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.CreateInfo(fp_header_t, array, resID.ByteOrder);
			}
			return result;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000E120 File Offset: 0x0000C320
		protected global::Motorola.Common.Communication.CommonUtil.MemoryImage PrepareLLpImage(byte[] llpData, uint llpAddr)
		{
			byte[] array = global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr.InitFPImageHeader(llpData);
			byte[] array2 = new byte[array.Length + llpData.Length];
			global::System.Array.Copy(array, 0, array2, 0, array.Length);
			global::System.Array.Copy(llpData, 0, array2, array.Length, llpData.Length);
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
			global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
			flashMemoryUnit.ChargeUnit(llpAddr.ToString(), array2, 0, 1U);
			memoryImage.AddItem(flashMemoryUnit);
			return memoryImage;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000E180 File Offset: 0x0000C380
		protected void GetMandatoryPacksfromFile(global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> swPacksList, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> swMandatoryPacks)
		{
			swMandatoryPacks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase>();
			if (swPacksList == null || swPacksList.Count == 0)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5062", "Invalide sw flash pack ");
			}
			foreach (global::Motorola.Common.Communication.TetraUtility.FPBase fpbase in swPacksList)
			{
				if (fpbase.PackType != 2U && fpbase.PackType != 1U && fpbase.PackType != 100U)
				{
					swMandatoryPacks.Add(fpbase);
				}
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000E244 File Offset: 0x0000C444
		protected void CheckPacksWithRadio(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> selPacks, global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> packList, out global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> removedPacks, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> needAddedPacks)
		{
			removedPacks = new global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			needAddedPacks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			if (selPacks == null || selPacks.Count == 0)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> keyValuePair in packList)
				{
					if (keyValuePair.Value.type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
					{
						removedPacks.Add(keyValuePair.Key, keyValuePair.Value);
					}
				}
				return;
			}
			if (packList == null || packList.Values.Count == 0)
			{
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>.Enumerator enumerator2 = selPacks.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::Motorola.Common.Communication.CommonUtil.PackHeader item = enumerator2.Current;
						needAddedPacks.Add(item);
					}
					return;
				}
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader in selPacks)
			{
				if (packHeader.imageName != null)
				{
					list2.Add(packHeader.imageName);
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> keyValuePair2 in packList)
			{
				uint addr = keyValuePair2.Key;
				global::Motorola.Common.Communication.CommonUtil.PackHeader value = keyValuePair2.Value;
				if (list2.Exists((string x) => string.Equals(x, packList[addr].imageName)) || packList[addr].type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
				{
					if (this.PackIsHealthy(addr, value) || packList[addr].type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
					{
						list.Add(packList[addr]);
					}
				}
				else
				{
					removedPacks.Add(addr, packList[addr]);
				}
			}
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader2 in selPacks)
			{
				bool flag = true;
				foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader3 in list)
				{
					if (packHeader3.imageName == packHeader2.imageName)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					needAddedPacks.Add(packHeader2);
				}
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000E570 File Offset: 0x0000C770
		protected void CheckPacksWithRadio(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> arrNeedVerify, global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> notMandatoryFP, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> needAddedFP, out global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> needDeletedFP, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> noChangedFP)
		{
			needAddedFP = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			noChangedFP = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			needDeletedFP = new global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			if (arrNeedVerify == null || arrNeedVerify.Count == 0)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> keyValuePair in notMandatoryFP)
				{
					if (keyValuePair.Value.type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
					{
						needDeletedFP.Add(keyValuePair.Key, keyValuePair.Value);
					}
				}
				return;
			}
			if (notMandatoryFP == null || notMandatoryFP.Count == 0)
			{
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>.Enumerator enumerator2 = arrNeedVerify.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::Motorola.Common.Communication.CommonUtil.PackHeader item = enumerator2.Current;
						needAddedFP.Add(item);
					}
					return;
				}
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader in arrNeedVerify)
			{
				if (packHeader.imageName != null)
				{
					list.Add(packHeader.imageName);
				}
			}
			using (global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader>.KeyCollection.Enumerator enumerator4 = notMandatoryFP.Keys.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					uint addr = enumerator4.Current;
					if (list.Exists((string x) => string.Equals(x, notMandatoryFP[addr].imageName)) || notMandatoryFP[addr].type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
					{
						noChangedFP.Add((global::Motorola.Common.Communication.CommonUtil.PackHeader)notMandatoryFP[addr].Clone());
					}
					else
					{
						needDeletedFP.Add(addr, (global::Motorola.Common.Communication.CommonUtil.PackHeader)notMandatoryFP[addr].Clone());
					}
				}
			}
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader2 in arrNeedVerify)
			{
				bool flag = true;
				if (noChangedFP.Count != 0)
				{
					foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader3 in noChangedFP)
					{
						if (packHeader3.imageName == packHeader2.imageName)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						needAddedFP.Add(packHeader2);
					}
				}
				else
				{
					needAddedFP.Add(packHeader2);
				}
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000E860 File Offset: 0x0000CA60
		protected void ErasePackFromSlot(uint startAddr)
		{
			if (startAddr < global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_START_ADDRESS || startAddr > global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_END_ADDRESS)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5068", "Invalide flash Pack slot addr");
			}
			uint num = startAddr + global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_SLOT_SIZE - 1U;
			try
			{
				this.EraseFromTo(startAddr.ToString(), num.ToString());
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5070", "Erase slot failed");
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000E8D0 File Offset: 0x0000CAD0
		protected global::Motorola.Common.Communication.CommonUtil.PackHeader AnalizeInfo(uint startAddr, byte[] packData, global::Motorola.Common.Communication.TetraUtility.ReleaseID releaseID, out uint emptySlot)
		{
			global::Motorola.Common.Communication.CommonUtil.PackHeader result = null;
			emptySlot = 0U;
			global::Motorola.Common.Communication.CommonUtil.fp_header_t fp_header_t = new global::Motorola.Common.Communication.CommonUtil.fp_header_t();
			bool flag = true;
			byte[] array = new byte[16];
			if (packData == null)
			{
				flag = false;
				emptySlot = startAddr;
			}
			else if ((long)packData.Length >= 16L)
			{
				global::System.Array.Copy(packData, 0L, array, 0L, 16L);
				fp_header_t.GetHeaderfromRawData(array);
			}
			else
			{
				flag = false;
				this.ErasePackFromSlot(startAddr);
				emptySlot = startAddr;
			}
			if (flag && !global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.AnalizeHeader(fp_header_t, releaseID, this.ByteOrder))
			{
				flag = false;
				this.ErasePackFromSlot(startAddr);
				emptySlot = startAddr;
			}
			if (flag && fp_header_t.pack_size == 0U)
			{
				flag = false;
				this.ErasePackFromSlot(startAddr);
				emptySlot = startAddr;
			}
			if (flag)
			{
				result = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.CreateInfo(fp_header_t, packData, releaseID.ByteOrder);
			}
			return result;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000E978 File Offset: 0x0000CB78
		protected global::Motorola.Common.Communication.TetraUtility.FPBase ReadAnalizePack(uint startAddr, global::Motorola.Common.Communication.TetraUtility.ReleaseID releaseID)
		{
			global::Motorola.Common.Communication.TetraUtility.FPBase result = null;
			global::Motorola.Common.Communication.CommonUtil.fp_header_t fp_header_t = new global::Motorola.Common.Communication.CommonUtil.fp_header_t();
			byte[] data = null;
			bool flag = true;
			if (flag && !this.ReadHeader(startAddr, fp_header_t))
			{
				flag = false;
			}
			if (flag && !global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.AnalizeHeader(fp_header_t, releaseID, this.ByteOrder))
			{
				flag = false;
			}
			if (flag)
			{
				if (fp_header_t.pack_size == 0U)
				{
					flag = false;
				}
				if (fp_header_t.pack_type != 100)
				{
					flag = false;
				}
			}
			if (flag && !this.ReadPack(startAddr, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE + fp_header_t.pack_size, out data))
			{
				flag = false;
			}
			if (flag)
			{
				result = this.CreatePack(fp_header_t, data);
			}
			return result;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000E9F8 File Offset: 0x0000CBF8
		protected void ReadLLP(global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, uint[] slotAddrArry, out global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage llpPack)
		{
			llpPack = null;
			if (resID.HasFP)
			{
				uint startAddr = slotAddrArry[0];
				llpPack = (global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage)this.ReadAnalizePack(startAddr, resID);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000EA24 File Offset: 0x0000CC24
		protected void ReadRadioFPInfo(global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, uint[] fpSlotAddr, out global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, out global::System.Collections.Generic.List<uint> emptySlots)
		{
			packs = new global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			emptySlots = new global::System.Collections.Generic.List<uint>();
			try
			{
				if (this._devInfo.BMPRadioFPInfo != null)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> keyValuePair in this._devInfo.BMPRadioFPInfo.RadioFlashPack)
					{
						packs.Add(keyValuePair.Key, keyValuePair.Value);
					}
					global::System.Collections.Generic.List<uint> emptySlots2 = this._devInfo.BMPRadioFPInfo.EmptySlots;
					foreach (uint item in emptySlots2)
					{
						emptySlots.Add(item);
					}
					emptySlots.Sort();
				}
				else
				{
					this._devInfo.BMPRadioFPInfo = new global::Motorola.Common.Communication.CommonUtil.RadioFPInfo();
					this.ReadInfo(resID, fpSlotAddr, out packs, out emptySlots);
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException)
			{
				throw;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000EB38 File Offset: 0x0000CD38
		protected global::System.Collections.Generic.Dictionary<uint, byte[]> GetFlashpackSlotsInfo()
		{
			global::System.Collections.Generic.List<uint> list = new global::System.Collections.Generic.List<uint>();
			global::System.Collections.Generic.Dictionary<uint, byte[]> dictionary = new global::System.Collections.Generic.Dictionary<uint, byte[]>();
			global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GetFlashpackSlotsInAddress(global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_REGION_START, global::Motorola.Common.Communication.SequenceManager.GemstoneVMInfo.GEMSTONE_FLASHPACK_REGION_END, list);
			uint size = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE + 16U + 32U;
			try
			{
				base.DoBeginReadImage(this._devInfo.UseCompress);
				foreach (uint key in list)
				{
					byte[] value = null;
					try
					{
						global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.FastReadImageFreon(key.ToString(), size, false);
						value = memoryImage[0].Data;
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (!(ex.ErrorID == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0021_RH_CommErrReadZeroLengthData.ToString()))
						{
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, "Read image fail in GemstoneBMPRadio.GetFlashpackSlotsInfo");
							throw;
						}
						value = null;
					}
					catch (global::System.Exception)
					{
						throw;
					}
					dictionary.Add(key, value);
				}
			}
			finally
			{
				base.DoEndReadImage(this._devInfo.UseCompress);
			}
			return dictionary;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000EC60 File Offset: 0x0000CE60
		protected void ReadInfo(global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, uint[] slotAddrArry, out global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, out global::System.Collections.Generic.List<uint> emptySlots)
		{
			packs = new global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			emptySlots = new global::System.Collections.Generic.List<uint>();
			if (resID.HasFP)
			{
				global::System.Collections.Generic.Dictionary<uint, byte[]> flashpackSlotsInfo = this.GetFlashpackSlotsInfo();
				for (int i = 0; i < slotAddrArry.Length; i++)
				{
					uint num = 0U;
					uint num2 = slotAddrArry[i];
					byte[] array = flashpackSlotsInfo[num2];
					byte[] packData = (array == null) ? null : this.IgnorImageHeader(flashpackSlotsInfo[num2]);
					global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader = this.AnalizeInfo(num2, packData, resID, out num);
					if (packHeader != null)
					{
						packs.Add(slotAddrArry[i], packHeader);
						this._devInfo.BMPRadioFPInfo.AddRadioFPInfo(slotAddrArry[i], packHeader);
					}
					if (num != 0U)
					{
						emptySlots.Add(num);
						this._devInfo.BMPRadioFPInfo.AddSlots(num);
					}
				}
				emptySlots.Sort();
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000ED20 File Offset: 0x0000CF20
		protected void SplitRadioPacks(global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> radioPacksHeader, out global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> mandatoryPacks, out global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> notmandatoryPacks)
		{
			mandatoryPacks = new global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			notmandatoryPacks = new global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			if (radioPacksHeader == null || radioPacksHeader.Values.Count == 0)
			{
				return;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> keyValuePair in radioPacksHeader)
			{
				if (keyValuePair.Value.type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.FONT_PACK || keyValuePair.Value.type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LANGUAGE_PACK || keyValuePair.Value.type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
				{
					notmandatoryPacks.Add(keyValuePair.Key, keyValuePair.Value);
				}
				else
				{
					mandatoryPacks.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		protected void ScanPacks(global::Motorola.Common.Communication.TetraUtility.Z19File swFile, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> packs)
		{
			try
			{
				packs = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase>();
				global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> dictionary = swFile.FlashPacks(this.HwConfigString);
				if (dictionary != null)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<string, global::Motorola.Common.Communication.TetraUtility.SRecord> keyValuePair in dictionary)
					{
						global::Motorola.Common.Communication.TetraUtility.FPBase fpbase = this.CreatePack(keyValuePair.Value.Image, resID);
						if (fpbase == null)
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0003_RH_CommErrBadImage.ToString(), "Bad sw image");
						}
						packs.Add(fpbase);
					}
				}
			}
			catch (global::System.Exception)
			{
				throw;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000EE88 File Offset: 0x0000D088
		protected bool CanWriteMandatoryFPtoRadio(global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> notmandatoryPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> swMandatoryPacks)
		{
			bool result = false;
			if (swMandatoryPacks == null || swMandatoryPacks.Count == 0)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5062", "Invalide sw flash pack");
			}
			if (resID.HasFP)
			{
				uint num = 0U;
				uint num2 = 0U;
				uint num3 = 0U;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				if (notmandatoryPacks != null)
				{
					num6 = notmandatoryPacks.Count;
				}
				num = resID.FPInfo.pFPEndAdd - resID.FPInfo.pFPStartAdd;
				num4 = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_SLOTS_NUMBER - num6;
				num5 = swMandatoryPacks.Count;
				foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader in notmandatoryPacks.Values)
				{
					num2 += packHeader.size + global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE;
				}
				foreach (global::Motorola.Common.Communication.TetraUtility.FPBase fpbase in swMandatoryPacks)
				{
					num3 += fpbase.PackSize + global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE;
				}
				if (num3 + num2 <= num && num5 <= num4)
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000EFAC File Offset: 0x0000D1AC
		protected byte[] PreparePack(global::Motorola.Common.Communication.TetraUtility.FPBase pack)
		{
			byte[] array = global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr.InitFPImageHeader(pack.Data);
			byte[] array2 = new byte[array.Length + pack.Data.Length];
			global::System.Array.Copy(array, 0, array2, 0, array.Length);
			global::System.Array.Copy(pack.Data, 0, array2, array.Length, pack.Data.Length);
			return array2;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000EFFC File Offset: 0x0000D1FC
		protected void CreateFPImage2Write(global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> swMandatoryPacksList, ref global::System.Collections.Generic.List<uint> emptySlots, out global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			image = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
			global::System.Collections.Generic.List<uint> list = new global::System.Collections.Generic.List<uint>();
			for (int i = 0; i < swMandatoryPacksList.Count; i++)
			{
				global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
				global::Motorola.Common.Communication.TetraUtility.FPBase pack = swMandatoryPacksList[i];
				byte[] data = this.PreparePack(pack);
				flashMemoryUnit.ChargeUnit(emptySlots[i].ToString(), data, 0, 1U);
				image.AddItem(flashMemoryUnit);
				list.Add(emptySlots[i]);
			}
			foreach (uint item in list)
			{
				lock (emptySlots)
				{
					emptySlots.Remove(item);
				}
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000F0E4 File Offset: 0x0000D2E4
		protected void RemoveSlotsFromRadio(global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> needRemovedPacks, ref global::System.Collections.Generic.List<uint> emptySlots)
		{
			try
			{
				foreach (uint num in needRemovedPacks.Keys)
				{
					this.ErasePackFromSlot(num);
					emptySlots.Add(num);
				}
				emptySlots.Sort();
			}
			catch
			{
				throw;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000F158 File Offset: 0x0000D358
		protected bool DoWriteRadioFP(global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, global::Motorola.Common.Communication.CommonUtil.MemoryImage imgToWrite, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status)
		{
			bool flag = true;
			if (imgToWrite.Size > resID.FPInfo.pFPEndAdd - resID.FPInfo.pFPStartAdd)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5051", "FlashPack area exceeded!");
			}
			if (flag)
			{
				try
				{
					if (imgToWrite.Count >= 1)
					{
						base.DoWriteImage(imgToWrite, this._devInfo.UseCompress, true, status);
					}
				}
				catch
				{
					throw;
				}
			}
			return flag;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000F1CC File Offset: 0x0000D3CC
		protected void WriteMandatoryFP(global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, string swPath, global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> mandatoryPacks, ref global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> notmandatoryPacks, ref global::System.Collections.Generic.List<uint> emptySlots)
		{
			try
			{
				if (!string.IsNullOrEmpty(swPath))
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> swPacksList = null;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> list = null;
					global::Motorola.Common.Communication.TetraUtility.Z19File swFile = global::Motorola.Common.Communication.TetraUtility.FPTools.LoadSoftwareFile(swPath);
					this.ScanPacks(swFile, resID, out swPacksList);
					this.GetMandatoryPacksfromFile(swPacksList, out list);
					if (list != null && list.Count != 0)
					{
						if (mandatoryPacks != null && mandatoryPacks.Values.Count != 0)
						{
							foreach (uint num in mandatoryPacks.Keys)
							{
								this.ErasePackFromSlot(num);
								emptySlots.Add(num);
								emptySlots.Sort();
							}
						}
						if (this.CanWriteMandatoryFPtoRadio(resID, notmandatoryPacks, list))
						{
							global::Motorola.Common.Communication.CommonUtil.MemoryImage imgToWrite = null;
							this.CreateFPImage2Write(list, ref emptySlots, out imgToWrite);
							this.DoWriteRadioFP(resID, imgToWrite, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
						}
						else
						{
							global::System.Collections.Generic.List<uint> list2 = new global::System.Collections.Generic.List<uint>();
							foreach (global::System.Collections.Generic.KeyValuePair<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> keyValuePair in notmandatoryPacks)
							{
								if (keyValuePair.Value.type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
								{
									list2.Add(keyValuePair.Key);
								}
							}
							foreach (uint num2 in notmandatoryPacks.Keys)
							{
								if (notmandatoryPacks[num2].type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
								{
									this.ErasePackFromSlot(num2);
									emptySlots.Add(num2);
								}
							}
							emptySlots.Sort();
							foreach (uint key in list2)
							{
								if (notmandatoryPacks.ContainsKey(key))
								{
									notmandatoryPacks.Remove(key);
								}
							}
							global::Motorola.Common.Communication.CommonUtil.MemoryImage imgToWrite2 = null;
							this.CreateFPImage2Write(list, ref emptySlots, out imgToWrite2);
							this.DoWriteRadioFP(resID, imgToWrite2, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
						}
					}
				}
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5072", "Write Mandatory FP Failed", innerException);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000F470 File Offset: 0x0000D670
		protected void CheckPacksWithSw(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> packsList, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> addedPacks)
		{
			global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr.<>c__DisplayClass3f CS$<>8__locals1 = new global::Motorola.Common.Communication.SequenceManager.TetraBaseVirtualAddressSeqMgr.<>c__DisplayClass3f();
			CS$<>8__locals1.packsList = packsList;
			addedPacks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase>();
			if (packs == null || packs.Count == 0)
			{
				return;
			}
			if (CS$<>8__locals1.packsList == null || CS$<>8__locals1.packsList.Count == 0)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5071", "No FP in sw file");
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader in packs)
			{
				list.Add(packHeader.imageName);
			}
			int i;
			for (i = 0; i < CS$<>8__locals1.packsList.Count; i++)
			{
				if (list.Exists((string p) => string.Equals(p, CS$<>8__locals1.packsList[i].GetImageName())))
				{
					addedPacks.Add(CS$<>8__locals1.packsList[i]);
				}
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000F580 File Offset: 0x0000D780
		protected void WriteLP(global::Motorola.Common.Communication.TetraUtility.ReleaseID releaseID, uint[] slotAddrArry, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, string swPath, int startPosition, int endPosition, bool bResetProgress)
		{
			try
			{
				int start = 0;
				if (bResetProgress)
				{
					base.ResetProgress();
				}
				if (startPosition != 0 || endPosition != 0)
				{
					int num = (endPosition - startPosition) * 3 / 10 + startPosition;
					start = num + 1;
					base.SetCurrentScope(startPosition, num);
				}
				global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> radioPacksHeader = null;
				global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> mandatoryPacks = null;
				global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> packList = null;
				global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> dictionary = null;
				global::System.Collections.Generic.List<uint> list = null;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list2 = null;
				new global::System.Collections.Generic.List<uint>();
				this.ReadRadioFPInfo(releaseID, slotAddrArry, out radioPacksHeader, out list);
				this.SplitRadioPacks(radioPacksHeader, out mandatoryPacks, out packList);
				this.WriteMandatoryFP(releaseID, swPath, mandatoryPacks, ref packList, ref list);
				if (startPosition != 0 || endPosition != 0)
				{
					base.SetCurrentScope(start, endPosition);
				}
				this.CheckPacksWithRadio(packs, packList, out dictionary, out list2);
				if (string.IsNullOrEmpty(swPath))
				{
					if (list2 != null && list2.Count != 0)
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5056", "Invalide flash pack selected");
					}
					if (dictionary != null && dictionary.Values.Count != 0)
					{
						this.RemoveSlotsFromRadio(dictionary, ref list);
					}
				}
				else
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> packsList = null;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> list3 = null;
					global::Motorola.Common.Communication.TetraUtility.Z19File swFile = global::Motorola.Common.Communication.TetraUtility.FPTools.LoadSoftwareFile(swPath);
					this.ScanPacks(swFile, releaseID, out packsList);
					this.CheckPacksWithSw(list2, packsList, out list3);
					if (dictionary != null && dictionary.Values.Count != 0)
					{
						foreach (uint num2 in dictionary.Keys)
						{
							this.ErasePackFromSlot(num2);
							list.Add(num2);
						}
						list.Sort();
					}
					if (list3 != null && list3.Count != 0)
					{
						if (list3.Count > list.Count)
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5069", "Not enough flash pack slots");
						}
						global::Motorola.Common.Communication.CommonUtil.MemoryImage imgToWrite = null;
						this.CreateFPImage2Write(list3, ref list, out imgToWrite);
						this.DoWriteRadioFP(releaseID, imgToWrite, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
					}
				}
			}
			catch (global::System.Exception)
			{
				throw;
			}
			finally
			{
				this._devInfo.BMPRadioFPInfo = null;
				base.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteLanguagesDone);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000F7A0 File Offset: 0x0000D9A0
		protected void ReadPackfromFirstSlot(global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, uint[] slotAddrArry, out global::Motorola.Common.Communication.CommonUtil.PackHeader pack)
		{
			pack = null;
			if (resID.HasFP)
			{
				uint llpAddr = slotAddrArry[0];
				pack = this.ReadAnalizellpInfo(llpAddr, resID);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		protected uint FindfirstEmptySlots(uint[] slotAddrArry)
		{
			uint result = 0U;
			for (int i = 0; i < slotAddrArry.Length; i++)
			{
				global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.ReadImageWithExactAddrSize(slotAddrArry[i].ToString(), global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_IMAGE_HEADER_SIZE);
				if (memoryImage.Size == 0U)
				{
					result = slotAddrArry[i];
					break;
				}
			}
			return result;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000F80C File Offset: 0x0000DA0C
		protected void MoveSlotData(uint[] slotAddrArry, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID)
		{
			uint num = slotAddrArry[0];
			uint num2 = this.FindfirstEmptySlots(slotAddrArry);
			if (num2 < global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_START_ADDRESS || num2 > global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_END_ADDRESS)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5069", "No enough flash pack slot");
			}
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.ReadImage(num.ToString(), global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FLASHPACK_SLOT_SIZE, true);
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage2 = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
			global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
			byte[] array = new byte[memoryImage.Size];
			int num3 = 0;
			for (int i = 0; i < memoryImage.Count; i++)
			{
				global::System.Array.Copy(memoryImage[i].Data, 0, array, num3, memoryImage[i].Data.Length);
				num3 += memoryImage[i].Data.Length;
			}
			flashMemoryUnit.ChargeUnit(num2.ToString(), array, 0, 1U);
			memoryImage2.AddItem(flashMemoryUnit);
			this.DoWriteRadioFP(resID, memoryImage2, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000F8F0 File Offset: 0x0000DAF0
		protected void WriteLLP(global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, uint[] slotAddrArry, byte[] llpData)
		{
			global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader = null;
			uint llpAddr = slotAddrArry[0];
			global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> dictionary = null;
			global::System.Collections.Generic.List<uint> list = null;
			if (llpData == null || llpData.Length == 0)
			{
				return;
			}
			try
			{
				this.ReadRadioFPInfo(resID, slotAddrArry, out dictionary, out list);
				uint num = (uint)llpData.Length;
				if (dictionary.Count != 0)
				{
					foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader2 in dictionary.Values)
					{
						if (packHeader2.type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
						{
							num += packHeader2.size;
						}
					}
				}
				if (num > resID.FPInfo.pFPEndAdd - resID.FPInfo.pFPStartAdd)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5073_FP_CommErrWriteLLPFailed.ToString(), "flash pack exceed,Write llp error");
				}
				this.ReadPackfromFirstSlot(resID, slotAddrArry, out packHeader);
				if (packHeader != null && packHeader.type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
				{
					global::Motorola.Common.Communication.CommonUtil.MemoryImage imgToWrite = this.PrepareLLpImage(llpData, llpAddr);
					this.DoWriteRadioFP(resID, imgToWrite, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLLP);
				}
				else if (packHeader != null && packHeader.type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
				{
					this.MoveSlotData(slotAddrArry, resID);
					global::Motorola.Common.Communication.CommonUtil.MemoryImage imgToWrite2 = this.PrepareLLpImage(llpData, llpAddr);
					this.DoWriteRadioFP(resID, imgToWrite2, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLLP);
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.MemoryImage imgToWrite3 = this.PrepareLLpImage(llpData, llpAddr);
					this.DoWriteRadioFP(resID, imgToWrite3, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLLP);
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5073", "Write llp failed");
			}
			finally
			{
				this._devInfo.BMPRadioFPInfo = null;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000FAA0 File Offset: 0x0000DCA0
		protected void ReadRadioInfo(out global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> packsHeader, out global::System.Collections.Generic.List<uint> emptySlots)
		{
			packsHeader = new global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			emptySlots = new global::System.Collections.Generic.List<uint>();
			if (this._devInfo.BMPRadioFPInfo != null)
			{
				global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> radioFlashPack = this._devInfo.BMPRadioFPInfo.RadioFlashPack;
				foreach (global::System.Collections.Generic.KeyValuePair<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> keyValuePair in radioFlashPack)
				{
					packsHeader.Add(keyValuePair.Key, keyValuePair.Value);
				}
				global::System.Collections.Generic.List<uint> emptySlots2 = this._devInfo.BMPRadioFPInfo.EmptySlots;
				foreach (uint item in emptySlots2)
				{
					emptySlots.Add(item);
				}
				emptySlots.Sort();
				return;
			}
			base.CreateReleaseID();
			this.CreateFPSlot();
			this._devInfo.BMPRadioFPInfo = new global::Motorola.Common.Communication.CommonUtil.RadioFPInfo();
			this.ReadRadioFPInfo(this._releaseID, this._devInfo.BMPRadioFPSlots, out packsHeader, out emptySlots);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000FBBC File Offset: 0x0000DDBC
		protected override bool VerifyLanguagePacks(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> returnPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks)
		{
			bool flag = true;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader in returnPacks)
			{
				list.Add(global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.FindInfo(packHeader.imageName, allPacks));
			}
			for (int i = 0; i < list.Count; i++)
			{
				global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader2 = list[i];
				for (int j = i + 1; j < list.Count; j++)
				{
					global::Motorola.Common.Communication.CommonUtil.PackHeader pack = list[j];
					if (packHeader2.IsGemstoneBMPFPConflict(pack))
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> radioPacksHeader = null;
				global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> notMandatoryFP = null;
				global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> dictionary = null;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list2 = null;
				global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> dictionary2 = null;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list3 = null;
				global::System.Collections.Generic.List<uint> list4 = null;
				int num = 0;
				int num2 = 0;
				this.ReadRadioInfo(out radioPacksHeader, out list4);
				this.SplitRadioPacks(radioPacksHeader, out notMandatoryFP, out dictionary);
				this.CheckPacksWithRadio(list, notMandatoryFP, out list2, out dictionary2, out list3);
				if (list4 != null)
				{
					num2 = list4.Count;
				}
				if (dictionary2 != null)
				{
					num = dictionary2.Count;
				}
				int num3 = num2 + num;
				if (list2 != null && list2.Count != 0)
				{
					flag = (list2.Count <= num3);
				}
			}
			return flag;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000FCFC File Offset: 0x0000DEFC
		protected override bool VerifyLanguagePacks(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> returnPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> mandatoryPacks, uint fpSize)
		{
			return global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.VerifyGemstoneBMPLanguagePacks(returnPacks, allPacks, mandatoryPacks, fpSize);
		}

		// Token: 0x0400006B RID: 107
		private const int FLASHPACK_SLOTS_NUMBER = 128;

		// Token: 0x0400006C RID: 108
		private const uint FLASHPACK_IMAGE_HEADER_SIZE = 32U;

		// Token: 0x0400006D RID: 109
		protected uint _rootHeadOffset;

		// Token: 0x02000010 RID: 16
		protected class VirtualFlashInfo
		{
			// Token: 0x17000041 RID: 65
			// (get) Token: 0x06000180 RID: 384 RVA: 0x0000FD08 File Offset: 0x0000DF08
			// (set) Token: 0x06000181 RID: 385 RVA: 0x0000FD10 File Offset: 0x0000DF10
			public uint StartAddress
			{
				get
				{
					return this._startAddress;
				}
				set
				{
					this._startAddress = value;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000182 RID: 386 RVA: 0x0000FD19 File Offset: 0x0000DF19
			// (set) Token: 0x06000183 RID: 387 RVA: 0x0000FD21 File Offset: 0x0000DF21
			public uint ActualSize
			{
				get
				{
					return this._actualSize;
				}
				set
				{
					this._actualSize = value;
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000184 RID: 388 RVA: 0x0000FD2A File Offset: 0x0000DF2A
			// (set) Token: 0x06000185 RID: 389 RVA: 0x0000FD32 File Offset: 0x0000DF32
			public uint SizeNeedToRead
			{
				get
				{
					return this._sizeNeedToRead;
				}
				set
				{
					this._sizeNeedToRead = value;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000186 RID: 390 RVA: 0x0000FD3B File Offset: 0x0000DF3B
			// (set) Token: 0x06000187 RID: 391 RVA: 0x0000FD43 File Offset: 0x0000DF43
			public double StartProgress
			{
				get
				{
					return this._startProgress;
				}
				set
				{
					this._startProgress = value;
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000188 RID: 392 RVA: 0x0000FD4C File Offset: 0x0000DF4C
			// (set) Token: 0x06000189 RID: 393 RVA: 0x0000FD54 File Offset: 0x0000DF54
			public double EndProgress
			{
				get
				{
					return this._endProgress;
				}
				set
				{
					this._endProgress = value;
				}
			}

			// Token: 0x0400006E RID: 110
			private uint _startAddress;

			// Token: 0x0400006F RID: 111
			private uint _actualSize;

			// Token: 0x04000070 RID: 112
			private uint _sizeNeedToRead;

			// Token: 0x04000071 RID: 113
			private double _startProgress;

			// Token: 0x04000072 RID: 114
			private double _endProgress;
		}
	}
}
