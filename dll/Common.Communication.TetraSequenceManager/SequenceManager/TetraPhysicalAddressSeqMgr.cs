using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using FDISystem;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.FDT;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000014 RID: 20
	public class TetraPhysicalAddressSeqMgr : global::Motorola.Common.Communication.SequenceManager.TetraBaseSbepSeqManager
	{
		// Token: 0x0600022C RID: 556 RVA: 0x000136E4 File Offset: 0x000118E4
		public TetraPhysicalAddressSeqMgr(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			this._transport = (transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe);
			this._devInfo = (devInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00013704 File Offset: 0x00011904
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
				bool flag = false;
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
				global::Motorola.Common.Communication.CommonUtil.MemoryImage image = null;
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
				if (flag)
				{
					image = this.ReadKeys();
				}
				global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel(text2);
				ushort num = 0;
				if (model != null)
				{
					num = (ushort)model.ModelType;
				}
				this.MigrateFDT(this.ModelType, num, this.CodeplugVersion, text3);
				this.BeginUpdateCodeplugAndSoftwareFdt(text3, num, text4, this.GetSwVerFromSwFile(text5));
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				list.Add(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_REGION_SOFTWARE);
				list.Add(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_REGION_CODEPLUG);
				base.SetCurrentScope(0, 20);
				this.EraseRadio(list);
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
				if (flag)
				{
					this.WriteKeys(image);
				}
				string cpVersion = text3;
				if (global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.IsRadioSupportFP(text2, cpVersion))
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list2 = null;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs = null;
					base.ConstructRadioPacks(pbaObject.LanguagePackData, text5, out list2, out packs);
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
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraPhysicalAddressSeqMgr.UpdateDevice", "");
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00013A98 File Offset: 0x00011C98
		public override void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode commandCode, byte[] inputBuffer, out byte[] outputBuffer)
		{
			outputBuffer = null;
			try
			{
				switch (commandCode)
				{
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_ERASE_KEYS:
					this.EraseKeys();
					goto IL_28A;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_BEGIN_UPDATE_FDT:
				{
					global::Motorola.Common.Communication.CommonUtil.FDTParameters fdtparameters = (global::Motorola.Common.Communication.CommonUtil.FDTParameters)base.DeserializeBinary(inputBuffer);
					this.BeginUpdateFDT(fdtparameters.Type, fdtparameters.Version, fdtparameters.ModelType, fdtparameters.Info, fdtparameters.FixFDTError);
					goto IL_28A;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_END_UPDATE_FDT:
				{
					global::Motorola.Common.Communication.CommonUtil.FDTParameters fdtparameters = (global::Motorola.Common.Communication.CommonUtil.FDTParameters)base.DeserializeBinary(inputBuffer);
					this.EndUpdateFDT(fdtparameters.Type, fdtparameters.Version, fdtparameters.ModelType, fdtparameters.Info);
					goto IL_28A;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_RESTORE_PDV2_RADIO:
					this.RestorePDV2Radio();
					goto IL_28A;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_MIGRATE_FDT:
				{
					global::Motorola.Common.Communication.CommonUtil.MigrateFDTPatrameters migrateFDTPatrameters = (global::Motorola.Common.Communication.CommonUtil.MigrateFDTPatrameters)base.DeserializeBinary(inputBuffer);
					this.MigrateFDT(migrateFDTPatrameters.SrcModelType, migrateFDTPatrameters.DstModelType, migrateFDTPatrameters.SrcCPVersion, migrateFDTPatrameters.DstCPVersion);
					goto IL_28A;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SWITCH_MODE_NO_WAIT:
				{
					global::Motorola.Common.Communication.CommonUtil.DeviceMode mode = (global::Motorola.Common.Communication.CommonUtil.DeviceMode)base.DeserializeBinary(inputBuffer);
					base.SwitchModeNoWait(mode);
					goto IL_28A;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_WRITE_KEYS:
				{
					global::Motorola.Common.Communication.CommonUtil.MemoryImage image = (global::Motorola.Common.Communication.CommonUtil.MemoryImage)base.DeserializeBinary(inputBuffer);
					this.WriteKeys(image);
					goto IL_28A;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_READ_KEYS:
				{
					global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.ReadKeys();
					if (memoryImage != null)
					{
						outputBuffer = base.SerializeBinary(memoryImage);
						goto IL_28A;
					}
					outputBuffer = null;
					goto IL_28A;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_CLEAN_DAMAGE_FLAG:
					goto IL_28A;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_TEST_FDT:
				{
					global::Motorola.Common.Communication.CommonUtil.TestFDTCmdInfo fdtInfo = (global::Motorola.Common.Communication.CommonUtil.TestFDTCmdInfo)base.DeserializeBinary(inputBuffer);
					string empty = string.Empty;
					this.TestFdtCmd(fdtInfo, out empty);
					outputBuffer = base.SerializeBinary(empty);
					goto IL_28A;
				}
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.OPEN_COMMUNICATION_PIPE:
					base.OpenPipe();
					goto IL_28A;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_CUSTOM_MESSAGE:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_GET_BATTERY_STATUS:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_GET_DEVICE_MODE:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_GET_EMERGENCY_STATUS:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_GET_RADIO_INFO:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_RESET_TO_PROGMODE:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_SET_RP_STATE:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.GET_CEMSTONE_RADIO_FP_INFO:
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_GET_PLATFORM_INFO:
					break;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.CLOSE_COMMUNICATION_PIPE:
					base.ClosePipe();
					goto IL_28A;
				case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.VERIFY_RADIO_LANGUAGE_PACK:
				{
					global::Motorola.Common.Communication.CommonUtil.LanguagePackParameters languagePackParameters = (global::Motorola.Common.Communication.CommonUtil.LanguagePackParameters)base.DeserializeBinary(inputBuffer);
					bool flag = this.CanWriteLanguagePacks(languagePackParameters.Packs, languagePackParameters.AllPacks, languagePackParameters.TargetFwFilePath, languagePackParameters.TargetSoftwareVersion, languagePackParameters.TargetModelType);
					outputBuffer = base.SerializeBinary(flag);
					goto IL_28A;
				}
				default:
					switch (commandCode)
					{
					case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.CPA_AUTHENTICATE_RADIO:
					{
						byte[] data = base.DeserializeBinary(inputBuffer) as byte[];
						this.AR(data);
						goto IL_28A;
					}
					case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.CPA_UNAUTHENTICATE_RADIO:
						this.DR();
						goto IL_28A;
					case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.SBEP_GET_STATUS:
					{
						global::Motorola.Common.Communication.SBEPStatus sbepstatus = new global::Motorola.Common.Communication.SBEPStatus(this._transport, true);
						sbepstatus.ExecuteMessage();
						byte b = (sbepstatus.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS) ? sbepstatus.Status : byte.MaxValue;
						outputBuffer = base.SerializeBinary(b);
						goto IL_28A;
					}
					}
					break;
				}
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
				IL_28A:;
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

		// Token: 0x0600022F RID: 559 RVA: 0x00013F4C File Offset: 0x0001214C
		public override void WriteSoftware(string swFilePath, bool bResetProgress = true)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraPhysicalAddressSeqMgr.WriteSoftware");
			if (bResetProgress)
			{
				base.ResetProgress();
			}
			try
			{
				global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo modeInfo = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel(this._recoverModelNumbel);
				global::Motorola.Common.Communication.TetraUtility.Z19File z19File = null;
				global::Motorola.Common.Communication.TetraUtility.SRecord srecord = null;
				global::Motorola.Common.Communication.CommonUtil.MemoryImage swImage = null;
				string swVerStr = string.Empty;
				this.PrepareSWImage(swFilePath, out z19File, out srecord, out swImage, out swVerStr);
				ushort modelType = 0;
				if (this.ModelInfo != null)
				{
					modelType = (ushort)this.ModelInfo.ModelType;
				}
				base.RetryMethod(delegate
				{
					if (z19File != null && !string.IsNullOrEmpty(swVerStr))
					{
						if (!this._forceWrite)
						{
							this.BeginUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE, z19File.CPVer, modelType, swVerStr, true);
						}
						else if (modeInfo != null)
						{
							this.BeginUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE, z19File.CPVer, (ushort)modeInfo.ModelType, swVerStr, true);
						}
					}
					this.DoEraseImage(swImage, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
					this.DoWriteImage(swImage, this._devInfo.UseCompress, true, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingSoftware);
					if (z19File != null && !string.IsNullOrEmpty(swVerStr))
					{
						if (!this._forceWrite)
						{
							this.EndUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE, z19File.CPVer, modelType, swVerStr);
						}
						else if (modeInfo != null)
						{
							this.EndUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE, z19File.CPVer, (ushort)modeInfo.ModelType, swVerStr);
						}
						this.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteSoftwareDone);
					}
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
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("LegacyRadio.WriteSoftware", "");
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000140AC File Offset: 0x000122AC
		public override byte[] ReadCPData(string blockID, uint offset, ushort size)
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraPhysicalAddressSeqMgr.ReadCPData");
			byte[] result;
			try
			{
				if ((this.PartionHealthState & 1) == 1)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "codeplug is missing");
				}
				if (blockID == "RT" && offset + (uint)size - 1U <= (uint)this.ROOT_BLOCK_CACHE_SIZE)
				{
					if (this._rootBlockCache == null && !this._rootBlockIsBad)
					{
						this._rootBlockIsBad = true;
						this._rootBlockCache = base.DoReadCPData(blockID, 0U, this.ROOT_BLOCK_CACHE_SIZE);
						this._rootBlockIsBad = false;
					}
					byte[] array = new byte[(int)size];
					global::System.Array.Copy(this._rootBlockCache, (long)((ulong)offset), array, 0L, (long)((ulong)size));
					result = array;
				}
				else
				{
					result = base.DoReadCPData(blockID, offset, size);
				}
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
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("TetraPhysicalAddressSeqMgr.ReadCPData", "");
			}
			return result;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00014234 File Offset: 0x00012434
		public override bool IsLLPAvailable()
		{
			bool result;
			try
			{
				base.CreateReleaseID();
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = null;
				this.ReadInfo(this._releaseID, out list);
				foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader in list)
				{
					if (packHeader.type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
					{
						return true;
					}
				}
				result = false;
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

		// Token: 0x06000232 RID: 562 RVA: 0x00014300 File Offset: 0x00012500
		public override global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			global::Motorola.Common.Communication.CommonUtil.FDTInfo fdtinfo = new global::Motorola.Common.Communication.CommonUtil.FDTInfo();
			string empty = string.Empty;
			string empty2 = string.Empty;
			bool healthState;
			ushort modelType;
			this.GetFdtInfo(fdtType, out healthState, out empty, out modelType, out empty2);
			fdtinfo.HealthState = healthState;
			fdtinfo.Version = empty;
			fdtinfo.ModelType = modelType;
			fdtinfo.Info = empty2;
			return fdtinfo;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00014350 File Offset: 0x00012550
		public global::Motorola.Common.Communication.CommonUtil.CommRC DoReadFDT(out byte[] fdtRaw)
		{
			fdtRaw = null;
			if (base.Transport == null)
			{
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			global::Motorola.Common.Communication.SBEPReadFDTTable sbepreadFDTTable = new global::Motorola.Common.Communication.SBEPReadFDTTable(base.Transport);
			sbepreadFDTTable.ExecuteMessage();
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepreadFDTTable.OperationResult);
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && sbepreadFDTTable.FDTTable.Length > 0)
			{
				fdtRaw = (byte[])sbepreadFDTTable.FDTTable.Clone();
			}
			return commRC;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000143AC File Offset: 0x000125AC
		public global::Motorola.Common.Communication.CommonUtil.CommRC DoWriteFDT(byte[] fdtRaw)
		{
			if (fdtRaw == null || fdtRaw.Length == 0 || base.Transport == null)
			{
				return global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			global::Motorola.Common.Communication.SBEPWriteFDTTable sbepwriteFDTTable = new global::Motorola.Common.Communication.SBEPWriteFDTTable(base.Transport);
			sbepwriteFDTTable.FDTTableData = (byte[])fdtRaw.Clone();
			sbepwriteFDTTable.ExecuteMessage();
			return global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepwriteFDTTable.OperationResult);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00014400 File Offset: 0x00012600
		public void BeginUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType, string version, ushort modelType, string info, bool fixFDTError)
		{
			this.PartionHealthState = -1;
			if (string.IsNullOrEmpty(version) || modelType == 0)
			{
				return;
			}
			try
			{
				switch (fdtType)
				{
				case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHSTRAP:
				case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE:
				case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG:
				case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS:
					if (global::Motorola.Common.Communication.FDT.FDTBase.IsFDTSupportedbyCPRange(modelType, version))
					{
						global::Motorola.Common.Communication.FDT.FDTBase fdtbase = new global::Motorola.Common.Communication.FDT.FDTBase();
						if (!fdtbase.Init(this, false))
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit.ToString(), "BeginUpdateFDT - Init FDT base failed");
						}
						global::Motorola.Common.Communication.FDT.FDTUnit fdtunit = new global::Motorola.Common.Communication.FDT.FDTUnit();
						fdtunit.ModelType = modelType;
						fdtunit.CPVersion = version;
						global::Motorola.Common.Communication.FDT.FDTTableState fdttableState = global::Motorola.Common.Communication.FDT.FDTTableState.FDTTABLE_CORRUPTED;
						global::Motorola.Common.Communication.CommonUtil.CommRC commRC = fdtbase.GetState(ref fdttableState);
						if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString(), "Begin Update FDT - Get FDT state failed");
						}
						if (fdttableState == global::Motorola.Common.Communication.FDT.FDTTableState.FDTTABLE_CORRUPTED)
						{
							this.EraseFDTArea(version, modelType);
							fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_READY;
							fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT;
							fdtunit.Version = "0001";
							commRC = fdtbase.WriteUnit(fdtunit);
							if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
							{
								throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString(), "Begin Update FDT - Write FDT unit failed");
							}
						}
						global::System.Text.Encoding encoding = global::Motorola.Common.Communication.TetraUtility.CodepageUtil.GetEncoding(1252);
						switch (fdtType)
						{
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHSTRAP:
							fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_UPDATED;
							fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHSTRAP;
							fdtunit.Version = "0001";
							goto IL_203;
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE:
						{
							fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_UPDATED;
							fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE;
							fdtunit.Version = new global::Motorola.Common.Communication.TetraUtility.SoftWareName(info).PureVersionStr;
							byte[] bytes = encoding.GetBytes(info);
							fdtunit.Reserved = bytes;
							goto IL_203;
						}
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG:
						{
							fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_UPDATED;
							fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG;
							fdtunit.Version = version;
							byte[] bytes = encoding.GetBytes(info);
							fdtunit.Reserved = bytes;
							goto IL_203;
						}
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS:
							fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_UPDATED;
							fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS;
							fdtunit.Version = "0001";
							goto IL_203;
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_LOGGING_DATA:
						{
							fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_UPDATED;
							fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_LOGGING_DATA;
							fdtunit.Version = version;
							byte[] bytes = encoding.GetBytes(info);
							fdtunit.Reserved = bytes;
							goto IL_203;
						}
						}
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5004_FDT_CommErrUnknownFDTType.ToString(), "Begin Update FDT - Invalid FDT type");
						IL_203:
						commRC = fdtbase.WriteUnit(fdtunit);
						if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString(), "Begin Update FDT - Update FDT status failed");
						}
					}
					break;
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000146EC File Offset: 0x000128EC
		public void EndUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType, string version, ushort modelType, string info)
		{
			this.PartionHealthState = -1;
			if (string.IsNullOrEmpty(version) || modelType == 0)
			{
				return;
			}
			try
			{
				switch (fdtType)
				{
				case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHSTRAP:
				case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE:
				case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG:
				case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS:
				case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_LOGGING_DATA:
					if (global::Motorola.Common.Communication.FDT.FDTBase.IsFDTSupportedbyCPRange(modelType, version))
					{
						global::Motorola.Common.Communication.FDT.FDTBase fdtbase = new global::Motorola.Common.Communication.FDT.FDTBase();
						if (!fdtbase.Init(this, false))
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit.ToString(), "End Update FDT - Init FDT base failed");
						}
						global::Motorola.Common.Communication.FDT.FDTUnit fdtunit = new global::Motorola.Common.Communication.FDT.FDTUnit();
						fdtunit.ModelType = modelType;
						fdtunit.CPVersion = version;
						global::System.Text.Encoding encoding = global::Motorola.Common.Communication.TetraUtility.CodepageUtil.GetEncoding(1252);
						switch (fdtType)
						{
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHSTRAP:
							fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_READY;
							fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHSTRAP;
							fdtunit.Version = "0001";
							goto IL_184;
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE:
						{
							fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_READY;
							fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE;
							fdtunit.Version = new global::Motorola.Common.Communication.TetraUtility.SoftWareName(info).PureVersionStr;
							byte[] bytes = encoding.GetBytes(info);
							fdtunit.Reserved = bytes;
							goto IL_184;
						}
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG:
						{
							fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_READY;
							fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG;
							fdtunit.Version = version;
							byte[] bytes = encoding.GetBytes(info);
							fdtunit.Reserved = bytes;
							goto IL_184;
						}
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS:
							fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_READY;
							fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS;
							fdtunit.Version = "0001";
							goto IL_184;
						case global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_LOGGING_DATA:
							fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_READY;
							fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_LOGGING_DATA;
							fdtunit.ModelType = modelType;
							fdtunit.Version = version;
							goto IL_184;
						}
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5004_FDT_CommErrUnknownFDTType.ToString(), "End Update FDT - Invalid FDT type");
						IL_184:
						global::Motorola.Common.Communication.CommonUtil.CommRC commRC = fdtbase.WriteUnit(fdtunit);
						if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString(), "End Update FDT - Write FDT unit failed");
						}
					}
					break;
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0001495C File Offset: 0x00012B5C
		public void GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType, out bool healthState, out string version, out ushort modelType, out string info)
		{
			global::Motorola.Common.Communication.FDT.FDTUnit fdtunit = new global::Motorola.Common.Communication.FDT.FDTUnit();
			this.GetFDTUnitData(fdtType, fdtunit);
			if (fdtunit.State != global::Motorola.Common.Communication.FDT.FDTState.FDT_READY && fdtunit.State != global::Motorola.Common.Communication.FDT.FDTState.FDT_UNINITIAL)
			{
				healthState = false;
			}
			else
			{
				healthState = true;
			}
			version = fdtunit.Version;
			modelType = fdtunit.ModelType;
			string @string = global::System.Text.Encoding.ASCII.GetString(fdtunit.Reserved);
			char[] array = new char[2];
			array[0] = ' ';
			info = @string.Trim(array);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000149C8 File Offset: 0x00012BC8
		public void GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType, out bool healthState, out uint startAddress, out uint size)
		{
			global::Motorola.Common.Communication.FDT.FDTUnit fdtunit = new global::Motorola.Common.Communication.FDT.FDTUnit();
			this.GetFDTUnitData(fdtType, fdtunit);
			if (fdtunit.State != global::Motorola.Common.Communication.FDT.FDTState.FDT_READY && fdtunit.State != global::Motorola.Common.Communication.FDT.FDTState.FDT_UNINITIAL)
			{
				healthState = false;
			}
			else
			{
				healthState = true;
			}
			startAddress = fdtunit.StartAddress;
			size = fdtunit.Size;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00014AA0 File Offset: 0x00012CA0
		public override global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> ReadCodeplug()
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> result = null;
			try
			{
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("LegacyRadio.ReadCodeplug");
				global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder = this.GetByteOrder();
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("LegacyRadio.ReadCodeplug.GetCPAddressSize");
				uint cpAddress = 0U;
				uint cpSize = 0U;
				global::Motorola.Common.Communication.TetraUtility.FDIVersion fdiVersion = global::Motorola.Common.Communication.TetraUtility.FDIVersion.V5x;
				global::Motorola.Common.Communication.CommonUtil.MemoryImage image = null;
				base.RetryMethod(delegate
				{
					this.GetCPAddressSize(out cpAddress, out cpSize, out fdiVersion);
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("LegacyRadio.ReadCodeplug.GetCPAddressSize", "");
					global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("LegacyRadio.ReadCodeplug.ReadImage");
					image = this.DoReadImage(cpAddress.ToString(), cpSize, this._devInfo.UseCompress, true, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
				});
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("LegacyRadio.ReadCodeplug.ReadImage", "");
				image.CompactUnits();
				if (image.Count != 1)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0003_RH_CommErrBadImage.ToString());
				}
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("LegacyRadio.ReadCodeplug.UnpackFDI");
				result = global::Motorola.Common.Communication.SequenceManager.FDIUtilImpl.Unpack(image, fdiVersion, byteOrder);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("LegacyRadio.ReadCodeplug.UnpackFDI", "");
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::FDISystem.FDIException ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "FDI Error", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "FDI Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD4002_FDI_CommErrFDIException.ToString(), "FDI exception", ex2);
			}
			catch (global::System.Exception ex3)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex3, base.RadioProfile.Path, "Generic exception", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex3, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex3);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("LegacyRadio.ReadCodeplug", "");
			}
			return result;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00014DFC File Offset: 0x00012FFC
		public override void WriteCodeplug(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList, uint cpSize, string serialNum)
		{
			try
			{
				global::Motorola.Common.Communication.CommonUtil.MemoryImage image = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
				this.Invalidate(true);
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("LegacyRadio.WriteCodeplug");
				if (fdiBlockList == null || fdiBlockList.Count == 0)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "fidBlockList is empty");
				}
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("LegacyRadio.WriteCodeplug.GetConfig");
				byte[] cpBlock = this.GetCpBlock(fdiBlockList, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID);
				this._rootBlockCache = new byte[(int)this.ROOT_BLOCK_CACHE_SIZE];
				global::System.Array.Copy(cpBlock, 0, this._rootBlockCache, 0, (int)this.ROOT_BLOCK_CACHE_SIZE);
				string cpVer = this.GetCPVerFromFDIBlock(fdiBlockList);
				string modelNumberFromFDIBlock = this.GetModelNumberFromFDIBlock(fdiBlockList);
				ushort homeMCCFromFDIBlock = this.GetHomeMCCFromFDIBlock(fdiBlockList);
				string text = this.ComposeCommonModelNumber(modelNumberFromFDIBlock, (uint)homeMCCFromFDIBlock);
				global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel(modelNumberFromFDIBlock, global::Motorola.Common.Communication.TetraUtility.MCCConverter.ToString((uint)homeMCCFromFDIBlock));
				if (model == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "model interface is null!");
				}
				global::Motorola.Common.Communication.TetraUtility.MemMapVersionMapRecord memMapVersionMapRecord = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetMemMapVersionMapRecord(cpVer, text);
				global::Motorola.Common.Communication.TetraUtility.MemMapRecord memMapConfig = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetMemMapConfig(memMapVersionMapRecord.MemMapID);
				if (!memMapConfig.MapDefinition.ContainsKey(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_CP_SECTION) || memMapConfig.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_CP_SECTION].Count != 1)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("memory map {0} has the wrong codeplug section definition", memMapConfig.MemMapID));
				}
				uint cpStartAddress = global::System.Convert.ToUInt32(memMapConfig.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_CP_SECTION][0].Address);
				uint num = global::System.Convert.ToUInt32(memMapConfig.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_CP_SECTION][0].Size);
				global::Motorola.Common.Communication.TetraUtility.FDIVersion fdiversion = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetFDIVersionMapRecordByCPVer(cpVer, text).FDIVersion;
				global::Motorola.Common.Communication.TetraUtility.FlashTypeRecord flashTypeConfig = this.GetFlashTypeConfig();
				uint blockSize = flashTypeConfig.BlockSize;
				if (num % blockSize != 0U)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("fdiSize={0},blockSize={1}", num, blockSize));
				}
				uint blockNumber = num / blockSize;
				global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder = this.GetByteOrder();
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("LegacyRadio.WriteCodeplug.GetConfig", "");
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("LegacyRadio.WriteCodeplug.CreateFDI");
				image = global::Motorola.Common.Communication.SequenceManager.FDIUtilImpl.Pack(fdiBlockList, cpSize, cpStartAddress, blockSize, blockNumber, fdiversion, byteOrder);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("LegacyRadio.WriteCodeplug.CreateFDI", "");
				base.RetryMethod(delegate
				{
					this.BeginUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG, cpVer, (ushort)model.ModelType, serialNum, true);
					global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("LegacyRadio.WriteCodeplug.EraseImage");
					this.DoEraseImage(image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ErasingCP);
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("LegacyRadio.WriteCodeplug.EraseImage", "");
					global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("LegacyRadio.WriteCodeplug.WriteImage");
					this.DoWriteImage(image, this._devInfo.UseCompress, true, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("LegacyRadio.WriteCodeplug.WriteImage", "");
					this.EndUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG, cpVer, (ushort)model.ModelType, serialNum);
				});
				this._devInfo.ARP = null;
				if (this.ARP == null && cpBlock != null)
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("ARP is null, get rootblock fail, cache from fdi");
					this._devInfo.ARP = new byte[(int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_RPP_SIZE];
					int sourceIndex = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_RPP_OFFSET;
					if (global::Motorola.Common.Communication.TetraUtility.TetraUtil.IsMilan2Radio(model))
					{
						sourceIndex = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_RPP_OFFSET_MILAN2;
					}
					global::System.Array.Copy(cpBlock, sourceIndex, this._devInfo.ARP, 0, (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_RPP_SIZE);
				}
				this.SynchronizeUserPassword();
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::FDISystem.FDIException ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "FDI Error", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "FDI Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD4002_FDI_CommErrFDIException.ToString(), "FDI exception", ex2);
			}
			catch (global::System.Exception ex3)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex3, base.RadioProfile.Path, "Generic exception", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex3, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex3);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("LegacyRadio.WriteCodeplug", "");
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001526C File Offset: 0x0001346C
		public override void RestorePDV2Radio()
		{
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.ReadImage(278396928.ToString(), 131072U, false);
			memoryImage.CompactUnits();
			memoryImage[0].Data[512] = byte.MaxValue;
			this.WriteImage(memoryImage, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage, true);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000152BC File Offset: 0x000134BC
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadKeys()
		{
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = null;
			try
			{
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraPhysicalAddressSeqMgr.ReadKeys");
				global::Motorola.Common.Communication.TetraUtility.MemMapRecord memoryMap = this.MemoryMap;
				if (!memoryMap.MapDefinition.ContainsKey(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_KEY_SECTION))
				{
					return memoryImage;
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit> list = memoryMap.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_KEY_SECTION];
				if (list.Count != 1)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0004_RH_CommErrBadMemMap.ToString());
				}
				memoryImage = base.DoReadImage(list[0].Address.ToString(), list[0].Size, this._devInfo.UseCompress, false, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage);
				memoryImage.CompactUnits();
				if (memoryImage.Count != 1)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0003_RH_CommErrBadImage.ToString());
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic Error", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex2
				});
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("AbsCOMPortRadio.ReadKeys", "");
			}
			return memoryImage;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00015530 File Offset: 0x00013730
		public void WriteKeys(global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			try
			{
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("LegacyRadio.WriteKeys");
				image.CompactUnits();
				if (image.Count != 1)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0003_RH_CommErrBadImage.ToString());
				}
				global::Motorola.Common.Communication.TetraUtility.MemMapRecord memoryMap = this.MemoryMap;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit> keyMapUnitList = memoryMap.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_KEY_SECTION];
				if (keyMapUnitList.Count != 1)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0004_RH_CommErrBadMemMap.ToString());
				}
				if (keyMapUnitList[0].Size != image.Size)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0004_RH_CommErrBadMemMap.ToString());
				}
				base.RetryMethod(delegate
				{
					global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
					global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
					flashMemoryUnit.ChargeUnit(keyMapUnitList[0].Address.ToString(), image[0].Data);
					memoryImage.AddItem(flashMemoryUnit);
					this.DoEraseImage(memoryImage, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
					this.DoWriteImage(memoryImage, this._devInfo.UseCompress, false, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage);
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
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("LegacyRadio.WriteKeys", "");
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0001576C File Offset: 0x0001396C
		public virtual void EraseKeys()
		{
			try
			{
				global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("TetraBaseSbepSeqManager.EraseKeys");
				global::Motorola.Common.Communication.TetraUtility.MemMapRecord memoryMap = this.MemoryMap;
				if (memoryMap.MapDefinition.ContainsKey(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_KEY_SECTION))
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit> keyMapUnitList = memoryMap.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_KEY_SECTION];
					if (keyMapUnitList.Count != 1)
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0004_RH_CommErrBadMemMap.ToString());
					}
					base.RetryMethod(delegate
					{
						this.EraseFromTo(keyMapUnitList[0].Address.ToString(), (keyMapUnitList[0].Address + keyMapUnitList[0].Size).ToString());
					});
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic Error", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Generic Error", new object[]
				{
					ex2
				});
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
			finally
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RADIO_OPERATION_PERFORMANCE_LOGGER_NAME).Performance("AbsCOMPortRadio.ReadKeys", "");
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00015900 File Offset: 0x00013B00
		public override ushort ModelType
		{
			get
			{
				ushort modelType;
				lock (this._propertyAccessLock)
				{
					modelType = this.GetModelType();
				}
				return modelType;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00015944 File Offset: 0x00013B44
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
							uint directHomeMcc = this.GetDirectHomeMcc();
							this._devInfo.HomeMCC = (int)directHomeMcc;
							if (global::Motorola.Common.Communication.TetraUtility.MCCConverter.IsHomeMccEncrypted(directHomeMcc))
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
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
						}
						this._devInfo.HomeMCC = -1;
					}
					catch (global::System.Exception e)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, base.RadioProfile.Path, "Generic exception", new object[0]);
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "Generic Error");
						this._devInfo.HomeMCC = -1;
					}
					result = global::Motorola.Common.Communication.TetraUtility.CPAUtil.AMC(this.ARP, this.DUP, this._devInfo.HomeMCC);
				}
				return result;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00015AD8 File Offset: 0x00013CD8
		public override uint HomeMNC
		{
			get
			{
				uint homeMNC2;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (this._devInfo.HomeMNC == -1)
						{
							byte[] array = this.ReadCPData(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID, (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_HOME_MNC_OFFSET, 2);
							global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder = this.GetByteOrder();
							ushort homeMNC;
							if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
							{
								global::System.Array.Reverse(array);
								homeMNC = global::System.BitConverter.ToUInt16(array, 0);
							}
							else
							{
								homeMNC = global::System.BitConverter.ToUInt16(array, 0);
							}
							this._devInfo.HomeMNC = (int)homeMNC;
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
						}
						this._devInfo.HomeMNC = -1;
					}
					catch (global::System.Exception e)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, base.RadioProfile.Path, "Generic exception", new object[0]);
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "Generic Error");
						this._devInfo.HomeMNC = -1;
					}
					homeMNC2 = (uint)this._devInfo.HomeMNC;
				}
				return homeMNC2;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00015C58 File Offset: 0x00013E58
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
							byte[] array = this.ReadCPData(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID, (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_SERIAL_NUM_OFFSET, 11);
							int num = 0;
							global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
							while (array[num] != 0 && num < array.Length)
							{
								stringBuilder.Append((char)array[num]);
								num++;
							}
							this._devInfo.SerialNumber = stringBuilder.ToString();
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
						}
						this._devInfo.SerialNumber = string.Empty;
					}
					catch (global::System.Exception e)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, base.RadioProfile.Path, "Generic exception", new object[0]);
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "Generic Error");
						this._devInfo.SerialNumber = string.Empty;
					}
					result = global::System.Text.RegularExpressions.Regex.Replace(this._devInfo.SerialNumber, "[^\\w]", "");
				}
				return result;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00015DF8 File Offset: 0x00013FF8
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
							byte[] array = this.ReadCPData(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID, (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_ISSI_OFFSET, 4);
							global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder = this.GetByteOrder();
							if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
							{
								global::System.Array.Reverse(array);
							}
							this._devInfo.Issi = (int)global::System.BitConverter.ToUInt32(array, 0);
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
						}
						this._devInfo.Issi = -1;
					}
					catch (global::System.Exception e)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, base.RadioProfile.Path, "Generic exception", new object[0]);
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "Generic Error");
						this._devInfo.Issi = -1;
					}
					issi = (uint)this._devInfo.Issi;
				}
				return issi;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00015F68 File Offset: 0x00014168
		public override string SoftwareVersion
		{
			get
			{
				string result;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (string.IsNullOrEmpty(this._devInfo.SoftwareVersion))
						{
							byte[] array = this.ReadCPData(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID, (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_RADIO_VER_OFFSET, this.SOFTWARE_NAME_LENGTH);
							int num = 0;
							global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
							while (array[num] != 0 && num < array.Length)
							{
								stringBuilder.Append((char)array[num]);
								num++;
							}
							this._devInfo.SoftwareVersion = stringBuilder.ToString();
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
						}
						this._devInfo.SoftwareVersion = string.Empty;
					}
					catch (global::System.Exception e)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, base.RadioProfile.Path, "Generic exception", new object[0]);
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "Generic Error");
						this._devInfo.SoftwareVersion = string.Empty;
					}
					result = global::System.Text.RegularExpressions.Regex.Replace(this._devInfo.SoftwareVersion, "[^\\u0000-\\u007F]", "").Trim();
				}
				return result;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00016110 File Offset: 0x00014310
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
							if ((this.PartionHealthState & 1) == 0)
							{
								global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder = this.GetByteOrder();
								byte[] array = this.ReadCPData(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID, (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_STRUCT_VER_OFFSET, 2);
								byte[] array2 = this.ReadCPData(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID, (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_DEFAULT_VER_OFFSET, 2);
								if (byteOrder != global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
								{
									global::System.Array.Reverse(array);
									global::System.Array.Reverse(array2);
								}
								global::Motorola.Common.Communication.TetraUtility.CPVersion cpversion = new global::Motorola.Common.Communication.TetraUtility.CPVersion(array, array2);
								this._devInfo.CodeplugVersion = cpversion.ToString();
							}
							else
							{
								global::Motorola.Common.Communication.FDT.FDTUnit fdtunit = new global::Motorola.Common.Communication.FDT.FDTUnit();
								this.GetFDTUnitData(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG, fdtunit);
								this._devInfo.CodeplugVersion = fdtunit.Version;
							}
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
						}
						this._devInfo.CodeplugVersion = string.Empty;
					}
					catch (global::System.Exception e)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, base.RadioProfile.Path, "Generic exception", new object[0]);
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "Generic Error");
						this._devInfo.CodeplugVersion = string.Empty;
					}
					codeplugVersion = this._devInfo.CodeplugVersion;
				}
				return codeplugVersion;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00016380 File Offset: 0x00014580
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
					this.BeginUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHSTRAP, cpVersion, modelType, string.Empty, true);
					this.DoEraseImage(srecord.Image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
					this.DoWriteImage(srecord.Image, this._devInfo.UseCompress, true, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingBootData);
					this.EndUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHSTRAP, cpVersion, modelType, string.Empty);
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

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000247 RID: 583 RVA: 0x000164B0 File Offset: 0x000146B0
		// (set) Token: 0x06000248 RID: 584 RVA: 0x000165E0 File Offset: 0x000147E0
		public override int PartionHealthState
		{
			get
			{
				int partionHealthState;
				lock (this._propertyAccessLock)
				{
					if (this._devInfo.PartionHealthState == -1)
					{
						this._devInfo.PartionHealthState = 0;
						try
						{
							global::Motorola.Common.Communication.FDT.FDTUnit fdtunit = new global::Motorola.Common.Communication.FDT.FDTUnit();
							bool flag2 = false;
							this.GetFDTUnitData(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG, fdtunit);
							if (fdtunit.State != global::Motorola.Common.Communication.FDT.FDTState.FDT_READY)
							{
								this._devInfo.PartionHealthState |= 1;
							}
							flag2 = (flag2 || fdtunit.State != global::Motorola.Common.Communication.FDT.FDTState.FDT_UNINITIAL);
							this.GetFDTUnitData(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE, fdtunit);
							if (fdtunit.State != global::Motorola.Common.Communication.FDT.FDTState.FDT_READY)
							{
								this._devInfo.PartionHealthState |= 2;
							}
							flag2 = (flag2 || fdtunit.State != global::Motorola.Common.Communication.FDT.FDTState.FDT_UNINITIAL);
							this.GetFDTUnitData(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS, fdtunit);
							if (fdtunit.State != global::Motorola.Common.Communication.FDT.FDTState.FDT_READY)
							{
								this._devInfo.PartionHealthState |= 4;
							}
							if (!flag2 && fdtunit.State == global::Motorola.Common.Communication.FDT.FDTState.FDT_UNINITIAL)
							{
								this._devInfo.PartionHealthState = 0;
							}
						}
						catch
						{
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00016628 File Offset: 0x00014828
		public override byte[] ARP
		{
			get
			{
				byte[] arp2;
				lock (this._propertyAccessLock)
				{
					try
					{
						if (this._devInfo.ARP == null)
						{
							int offset = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_RPP_OFFSET;
							uint mcc = global::Motorola.Common.Communication.TetraUtility.MCCConverter.DecrypteHomeMcc(this.GetDirectHomeMcc());
							global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel(this.ModelNumber, global::Motorola.Common.Communication.TetraUtility.MCCConverter.ToString(mcc));
							if (model != null && global::Motorola.Common.Communication.TetraUtility.TetraUtil.IsMilan2Radio(model))
							{
								offset = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_RPP_OFFSET_MILAN2;
							}
							byte[] arp = this.ReadCPData(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID, (uint)offset, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CP_RPP_SIZE);
							this._devInfo.ARP = arp;
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
						}
						this._devInfo.ARP = null;
					}
					catch (global::System.Exception e)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, base.RadioProfile.Path, "Generic exception", new object[0]);
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "Generic Error");
						this._devInfo.ARP = null;
					}
					arp2 = this._devInfo.ARP;
				}
				return arp2;
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000167C0 File Offset: 0x000149C0
		private uint GetDirectHomeMcc()
		{
			byte[] array = this.ReadCPData(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID, (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_HOME_MCC_OFFSET, 2);
			global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder = this.GetByteOrder();
			ushort result;
			if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
			{
				global::System.Array.Reverse(array);
				result = global::System.BitConverter.ToUInt16(array, 0);
			}
			else
			{
				result = global::System.BitConverter.ToUInt16(array, 0);
			}
			return (uint)result;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00016840 File Offset: 0x00014A40
		public override void ReadRadioLLPHeader(out global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader)
		{
			try
			{
				packHeader = null;
				global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage llp = null;
				base.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingLLP);
				base.CreateReleaseID();
				base.RetryMethod(delegate
				{
					this.ReadLLP(out llp, this._releaseID);
					this.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadLLPDone);
				});
				if (llp != null)
				{
					packHeader = llp.PackHeader;
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

		// Token: 0x0600024C RID: 588 RVA: 0x00016928 File Offset: 0x00014B28
		public override void ReadRadioLPHeader(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packHeader)
		{
			try
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> tmpPackHeader = null;
				base.CreateReleaseID();
				base.RetryMethod(delegate
				{
					this.ReadInfo(this._releaseID, out tmpPackHeader);
				});
				for (int i = tmpPackHeader.Count - 1; i >= 0; i--)
				{
					tmpPackHeader[i].select = true;
				}
				packHeader = tmpPackHeader;
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

		// Token: 0x0600024D RID: 589 RVA: 0x00016A30 File Offset: 0x00014C30
		public override byte[] ReadRadioLLP()
		{
			byte[] result;
			try
			{
				base.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingLLP);
				global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage llp = null;
				base.CreateReleaseID();
				base.RetryMethod(delegate
				{
					this.ReadLLP(out llp, this._releaseID);
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

		// Token: 0x0600024E RID: 590 RVA: 0x00016B24 File Offset: 0x00014D24
		public override void WriteRadioLP(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, string swPath, global::Motorola.Common.Communication.FDT.FDTParams fdtParams, int startPosition, int endPosition, bool bResetProgress = true)
		{
			try
			{
				if (bResetProgress)
				{
					base.ResetProgress();
				}
				if (startPosition != 0 || endPosition != 0)
				{
					base.SetCurrentScope(startPosition, endPosition);
				}
				base.CreateReleaseID();
				base.RetryMethod(delegate
				{
					this.WriteLP(this._releaseID, packs, swPath, fdtParams);
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

		// Token: 0x0600024F RID: 591 RVA: 0x00016C14 File Offset: 0x00014E14
		public override void WriteRadioLLP(byte[] llp)
		{
			try
			{
				base.CreateReleaseID();
				base.RetryMethod(delegate
				{
					this.WriteLLP(this._releaseID, llp);
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00016CB4 File Offset: 0x00014EB4
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
							byte[] array = this.ReadCPData(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID, (uint)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_MODEL_NUM_OFFSET, 17);
							int num = 0;
							global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
							while (array[num] != 0 && num < array.Length)
							{
								stringBuilder.Append((char)array[num]);
								num++;
							}
							this._devInfo.ModelNumber = stringBuilder.ToString();
						}
					}
					catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
							{
								ex
							});
						}
						this._devInfo.ModelNumber = string.Empty;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic Error", new object[0]);
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

		// Token: 0x06000251 RID: 593 RVA: 0x00016E60 File Offset: 0x00015060
		protected override void TestFdtCmd(global::Motorola.Common.Communication.CommonUtil.TestFDTCmdInfo fdtInfo, out string strResult)
		{
			strResult = "Command not executed";
			switch (fdtInfo._fdtCmd)
			{
			case global::Motorola.Common.Communication.CommonUtil.FDT_CMD.Read_FDT:
				this.ReadFdtData(fdtInfo, out strResult);
				return;
			case global::Motorola.Common.Communication.CommonUtil.FDT_CMD.Write_Updated_State:
			case global::Motorola.Common.Communication.CommonUtil.FDT_CMD.Write_Ready_State:
				this.WriteFdtData(fdtInfo, out strResult);
				return;
			case global::Motorola.Common.Communication.CommonUtil.FDT_CMD.Initialize_FDT:
				this.InitializeFdtData(fdtInfo, out strResult);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00016EB0 File Offset: 0x000150B0
		private byte[] GetCpBlock(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList, string blockID)
		{
			byte[] array = null;
			if (blockID.Length != 2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(base.RadioProfile.Path, global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString() + " in GetCpBlock");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString());
			}
			ushort num = (ushort)((int)global::System.Convert.ToUInt16(blockID[0]) | (int)global::System.Convert.ToUInt16(blockID[1]) << 8);
			foreach (global::System.Collections.Generic.KeyValuePair<ushort, byte[]> keyValuePair in fdiBlockList)
			{
				if (keyValuePair.Key == num)
				{
					array = keyValuePair.Value;
					break;
				}
			}
			if (array == null)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(base.RadioProfile.Path, string.Format("blockID={0}", blockID) + " in GetCpBlock");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("blockID={0}", blockID));
			}
			return array;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00016FB0 File Offset: 0x000151B0
		private void GetCPAddressSize(out uint address, out uint size, out global::Motorola.Common.Communication.TetraUtility.FDIVersion fdiVersion)
		{
			if (string.IsNullOrEmpty(this.CodeplugVersion) || string.IsNullOrEmpty(this.ModelNumber))
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(base.RadioProfile.Path, "can't detect cp area in GetCPAddressSize");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0011_RH_CommErrCannotDetectCPArea.ToString(), "can't detect cp area in GetCPAddressSize");
			}
			string codeplugVersion = this.CodeplugVersion;
			string commonModelNumber = this.CommonModelNumber;
			fdiVersion = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetFDIVersionMapRecordByCPVer(codeplugVersion, commonModelNumber).FDIVersion;
			global::Motorola.Common.Communication.TetraUtility.MemMapRecord memoryMap = this.MemoryMap;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.MemMapUnit> list = memoryMap.MapDefinition[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MEM_MAP_CP_SECTION];
			address = list[0].Address;
			size = list[0].Size;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00017054 File Offset: 0x00015254
		private string GetCPVerFromFDIBlock(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList)
		{
			byte[] cpBlock = this.GetCpBlock(fdiBlockList, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID);
			if (cpBlock.Length < global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_DEFAULT_VER_OFFSET + 2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(base.RadioProfile.Path, global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString() + " in GetCPVerFromFDIBlock");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString());
			}
			global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder = this.GetByteOrder();
			ushort num = global::System.BitConverter.ToUInt16(cpBlock, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_STRUCT_VER_OFFSET);
			ushort num2 = global::System.BitConverter.ToUInt16(cpBlock, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_DEFAULT_VER_OFFSET);
			if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
			{
				byte[] bytes = global::System.BitConverter.GetBytes(num);
				byte[] bytes2 = global::System.BitConverter.GetBytes(num2);
				global::System.Array.Reverse(bytes);
				global::System.Array.Reverse(bytes2);
				num = global::System.BitConverter.ToUInt16(bytes, 0);
				num2 = global::System.BitConverter.ToUInt16(bytes2, 0);
			}
			return new global::Motorola.Common.Communication.TetraUtility.CPVersion((uint)num, (uint)num2).ToString();
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00017110 File Offset: 0x00015310
		private string GetModelNumberFromFDIBlock(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (fdiBlockList == null)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(base.RadioProfile.Path, global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString() + " in GetModelNumberFromFDIBlock");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "fdiBlockList is nll");
			}
			byte[] cpBlock = this.GetCpBlock(fdiBlockList, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID);
			if (cpBlock.Length < global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_MODEL_NUM_OFFSET + 1)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(base.RadioProfile.Path, global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString() + " in GetModelNumberFromFDIBlock");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("rootBlock.Lenght={0}", cpBlock.Length));
			}
			int num = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_MODEL_NUM_OFFSET;
			while (cpBlock[num] != 0)
			{
				stringBuilder.Append((char)cpBlock[num]);
				num++;
			}
			if (stringBuilder.Length <= 0)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(base.RadioProfile.Path, global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString() + " in if (modelNum.Length <= 0) of GetModelNumberFromFDIBlock");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00017224 File Offset: 0x00015424
		private ushort GetHomeMCCFromFDIBlock(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList)
		{
			if (fdiBlockList == null)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(base.RadioProfile.Path, "fdiBlockList is null in GetHomeMCCFromFDIBlock");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "fdiBlockList is nll");
			}
			byte[] cpBlock = this.GetCpBlock(fdiBlockList, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_ROOT_BLOCK_ID);
			if (cpBlock.Length < global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_HOME_MCC_OFFSET + 1)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(base.RadioProfile.Path, string.Format("rootBlock.Lenght={0}", cpBlock.Length) + " in GetHomeMCCFromFDIBlock");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), string.Format("rootBlock.Lenght={0}", cpBlock.Length));
			}
			int fdi_CP_HOME_MCC_OFFSET = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FDI_CP_HOME_MCC_OFFSET;
			global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder = this.GetByteOrder();
			ushort value;
			if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
			{
				value = (ushort)((int)cpBlock[fdi_CP_HOME_MCC_OFFSET + 1] | (int)cpBlock[fdi_CP_HOME_MCC_OFFSET] << 8);
			}
			else
			{
				value = (ushort)((int)cpBlock[fdi_CP_HOME_MCC_OFFSET] | (int)cpBlock[fdi_CP_HOME_MCC_OFFSET + 1] << 8);
			}
			return (ushort)global::Motorola.Common.Communication.TetraUtility.MCCConverter.DecrypteHomeMcc(global::System.Convert.ToUInt32(value));
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00017304 File Offset: 0x00015504
		private void GetFDTUnitData(global::Motorola.Common.Communication.CommonUtil.FDTType eRecordType, global::Motorola.Common.Communication.FDT.FDTUnit fdtUnit)
		{
			try
			{
				if (fdtUnit == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "fdtUnit is null");
				}
				global::Motorola.Common.Communication.FDT.FDTBase fdtbase = new global::Motorola.Common.Communication.FDT.FDTBase();
				if (!fdtbase.Init(this, false))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit.ToString(), "Init FDTBase failed");
				}
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = fdtbase.ReadUnit(eRecordType, fdtUnit);
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString(), "Read FDT Unit failed");
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Communication Error", new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic Error", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001740C File Offset: 0x0001560C
		private void SetFDTUnitData(global::Motorola.Common.Communication.FDT.FDTUnit fdtUnit)
		{
			try
			{
				if (fdtUnit == null)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "fdtUnit is null");
				}
				global::Motorola.Common.Communication.FDT.FDTBase fdtbase = new global::Motorola.Common.Communication.FDT.FDTBase();
				if (!fdtbase.Init(this, false))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit.ToString(), "Init FDTBase failed");
				}
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = fdtbase.WriteUnit(fdtUnit);
				global::System.Threading.Thread.Sleep(100);
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString(), "Write FDT Unit failed");
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Communication Error", new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic Error", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001751C File Offset: 0x0001571C
		private void GetRadioFDTTableState(ref global::Motorola.Common.Communication.FDT.FDTTableState State)
		{
			try
			{
				State = global::Motorola.Common.Communication.FDT.FDTTableState.FDTTABLE_UNSUPPORT;
				global::Motorola.Common.Communication.FDT.FDTBase fdtbase = new global::Motorola.Common.Communication.FDT.FDTBase();
				if (!fdtbase.Init(this, true))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit.ToString(), "Init FDTBase failed");
				}
				global::Motorola.Common.Communication.CommonUtil.CommRC state = fdtbase.GetState(ref State);
				if (state != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(state.ToString(), "Get FDT State failed");
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Communication Error", new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000176AC File Offset: 0x000158AC
		private void EraseFDTArea(string version, ushort modeltype)
		{
			try
			{
				global::Motorola.Common.Communication.FDT.FDTBase fdtTable = new global::Motorola.Common.Communication.FDT.FDTBase();
				if (!fdtTable.Init(this, false))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit.ToString(), "Init FDTBase failed");
				}
				base.RetryMethod(delegate
				{
					uint startAddress = fdtTable.GetStartAddress(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT, modeltype, version);
					uint size = fdtTable.GetSize(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT, modeltype, version);
					if (startAddress == 0U || size == 0U)
					{
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "FDT start address or size is zero.");
					}
					this.DoEraseFlash(startAddress.ToString(), size, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
				});
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Communication Error", new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000177C8 File Offset: 0x000159C8
		private void MigrateFDT(ushort srcModelType, ushort dstModelType, string srcCPVer, string dstCPVer)
		{
			this.PartionHealthState = -1;
			if (srcModelType == 0 || dstModelType == 0 || string.IsNullOrEmpty(srcCPVer) || string.IsNullOrEmpty(dstCPVer))
			{
				return;
			}
			try
			{
				bool flag = global::Motorola.Common.Communication.FDT.FDTBase.IsFDTSupportedbyCPRange(srcModelType, srcCPVer);
				bool flag2 = global::Motorola.Common.Communication.FDT.FDTBase.IsFDTSupportedbyCPRange(dstModelType, dstCPVer);
				if (flag || flag2)
				{
					if (flag && !flag2)
					{
						this.EraseFDTArea(srcCPVer, srcModelType);
					}
					else
					{
						global::Motorola.Common.Communication.FDT.FDTBase fdtbase = new global::Motorola.Common.Communication.FDT.FDTBase();
						if (!fdtbase.Init(this, false))
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit.ToString(), "Migrate FDT - Init FDT base failed");
						}
						global::Motorola.Common.Communication.FDT.FDTUnit fdtunit = new global::Motorola.Common.Communication.FDT.FDTUnit();
						if (!flag && flag2)
						{
							this.EraseFDTArea(dstCPVer, dstModelType);
							fdtunit.ModelType = dstModelType;
							fdtunit.CPVersion = dstCPVer;
							fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_READY;
							fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT;
							fdtunit.Version = "0001";
							global::Motorola.Common.Communication.CommonUtil.CommRC commRC = fdtbase.WriteUnit(fdtunit);
							if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
							{
								throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString(), "Migrate FDT - Write FDT unit failed");
							}
						}
						else
						{
							global::Motorola.Common.Communication.FDT.FDTTableState fdttableState = global::Motorola.Common.Communication.FDT.FDTTableState.FDTTABLE_CORRUPTED;
							if (flag && flag2)
							{
								this.GetRadioFDTTableState(ref fdttableState);
								if (fdttableState == global::Motorola.Common.Communication.FDT.FDTTableState.FDTTABLE_CORRUPTED)
								{
									this.EraseFDTArea(srcCPVer, srcModelType);
									fdtunit.ModelType = srcModelType;
									fdtunit.CPVersion = srcCPVer;
									fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_READY;
									fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT;
									fdtunit.Version = "0001";
									global::Motorola.Common.Communication.CommonUtil.CommRC commRC = fdtbase.WriteUnit(fdtunit);
									if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
									{
										throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString(), "Migrate FDT - Write FDT unit failed");
									}
								}
							}
							if (flag2)
							{
								uint startAddress = fdtbase.GetStartAddress(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_LOGGING_DATA, dstModelType, dstCPVer);
								if (startAddress != 0U)
								{
									this.EndUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_LOGGING_DATA, dstCPVer, dstModelType, string.Empty);
								}
							}
						}
					}
				}
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
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000179E8 File Offset: 0x00015BE8
		private void InitializeFdtData(global::Motorola.Common.Communication.CommonUtil.TestFDTCmdInfo fdtInfo, out string strResult)
		{
			strResult = string.Format("Command: Initialize FDT, Result: ", new object[0]);
			if (this.ModelType == 0 && fdtInfo._modelType == 0)
			{
				strResult += "Could not know the model type, initialize FDT failed";
				return;
			}
			if (string.IsNullOrEmpty(this.CodeplugVersion) && string.IsNullOrEmpty(fdtInfo._forceCpVer))
			{
				strResult += "Could not know the CP version, initialize FDT failed";
				return;
			}
			try
			{
				global::Motorola.Common.Communication.FDT.FDTBase fdtbase = new global::Motorola.Common.Communication.FDT.FDTBase();
				if (!fdtbase.Init(this, false))
				{
					strResult += "Initialize fdtBase failed";
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit.ToString(), "BeginUpdateFDT - Init FDT base failed");
				}
				global::Motorola.Common.Communication.FDT.FDTUnit fdtunit = new global::Motorola.Common.Communication.FDT.FDTUnit();
				if (fdtInfo._modelType == 0)
				{
					fdtunit.ModelType = this.ModelType;
				}
				else
				{
					fdtunit.ModelType = fdtInfo._modelType;
				}
				if (string.IsNullOrEmpty(fdtInfo._forceCpVer))
				{
					fdtunit.CPVersion = this.CodeplugVersion;
				}
				else
				{
					fdtunit.CPVersion = fdtInfo._forceCpVer;
				}
				this.EraseFDTArea(fdtInfo._forceCpVer, fdtunit.ModelType);
				fdtunit.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_READY;
				fdtunit.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT;
				fdtunit.Version = fdtInfo._unitVersion;
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = fdtbase.WriteUnitForTestFdt(fdtunit);
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					strResult += "Write FDT data failed";
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(commRC.ToString(), "Begin Update FDT - Write FDT unit failed");
				}
				strResult = "Success";
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00017BDC File Offset: 0x00015DDC
		private void ReadFdtData(global::Motorola.Common.Communication.CommonUtil.TestFDTCmdInfo fdtInfo, out string strResult)
		{
			strResult = string.Format("Command: Read, FDT Unit: {0}, Result: ", fdtInfo._fdtType);
			try
			{
				global::Motorola.Common.Communication.FDT.FDTBase fdtbase = new global::Motorola.Common.Communication.FDT.FDTBase();
				if (!fdtbase.Init(this, false))
				{
					strResult += "Failed to initialize FDTBase";
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit.ToString(), "Read fdt - Init FDT base failed");
				}
				global::Motorola.Common.Communication.FDT.FDTUnit fdtunit = new global::Motorola.Common.Communication.FDT.FDTUnit();
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = fdtbase.ReadUnit(fdtInfo._fdtType, fdtunit);
				if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					strResult += string.Format("Failed to read unit, error code = {0}", commRC);
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5002_FDT_CommErrCannotReadFDT.ToString(), "Read fdt - Can not read FDT");
				}
				strResult += string.Format("FDT State = {0}, Unit version = {1}", fdtunit.State, fdtunit.Version);
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00017D40 File Offset: 0x00015F40
		private void WriteFdtData(global::Motorola.Common.Communication.CommonUtil.TestFDTCmdInfo fdtInfo, out string strResult)
		{
			global::Motorola.Common.Communication.FDT.FDTState fdtstate;
			if (fdtInfo._fdtCmd == global::Motorola.Common.Communication.CommonUtil.FDT_CMD.Write_Ready_State)
			{
				fdtstate = global::Motorola.Common.Communication.FDT.FDTState.FDT_READY;
			}
			else
			{
				fdtstate = global::Motorola.Common.Communication.FDT.FDTState.FDT_UPDATED;
			}
			strResult = string.Format("Command: Write, FDT State: {0}, FDT Unit: {1}, Result: ", fdtstate, fdtInfo._fdtType);
			try
			{
				global::Motorola.Common.Communication.FDT.FDTBase fdtbase = new global::Motorola.Common.Communication.FDT.FDTBase();
				if (!fdtbase.Init(this, false))
				{
					strResult += "Failed to initialize FDTBase";
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5000_FDT_CommErrFDTNotInit.ToString(), "Read fdt - Init FDT base failed");
				}
				global::Motorola.Common.Communication.FDT.FDTUnit fdtunit = new global::Motorola.Common.Communication.FDT.FDTUnit();
				if (this.ModelType == 0 && fdtInfo._modelType == 0)
				{
					strResult += "Could not know the model type, Can not write FDT unit";
				}
				else if (string.IsNullOrEmpty(this.CodeplugVersion) && string.IsNullOrEmpty(fdtInfo._forceCpVer))
				{
					strResult += "Could not know the CP version, Can not write FDT unit";
				}
				else
				{
					if (fdtInfo._modelType == 0)
					{
						fdtunit.ModelType = this.ModelType;
					}
					else
					{
						fdtunit.ModelType = fdtInfo._modelType;
					}
					if (string.IsNullOrEmpty(fdtInfo._forceCpVer))
					{
						fdtunit.CPVersion = this.CodeplugVersion;
					}
					else
					{
						fdtunit.CPVersion = fdtInfo._forceCpVer;
					}
					fdtunit.FdtType = fdtInfo._fdtType;
					fdtunit.Version = fdtInfo._unitVersion;
					fdtunit.State = fdtstate;
					global::Motorola.Common.Communication.CommonUtil.CommRC commRC = fdtbase.WriteUnitForTestFdt(fdtunit);
					if (commRC != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
					{
						string str = string.Format("Failed to write unit, error code = {0}", commRC);
						strResult += str;
						throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5002_FDT_CommErrCannotReadFDT.ToString(), "write fdt - Can not write FDT");
					}
					strResult += "Success";
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex.ErrorID, new object[]
				{
					ex
				});
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, base.RadioProfile.Path, "Generic exception", new object[0]);
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00017F80 File Offset: 0x00016180
		private ushort GetModelType()
		{
			ushort result;
			try
			{
				if ((this.PartionHealthState & 1) == 0)
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
				else
				{
					global::Motorola.Common.Communication.FDT.FDTUnit fdtunit = new global::Motorola.Common.Communication.FDT.FDTUnit();
					this.GetFDTUnitData(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG, fdtunit);
					result = fdtunit.ModelType;
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				if (ex.ErrorCode != global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString())
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, base.RadioProfile.Path, ex.ErrorID, new object[0]);
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				}
				result = 0;
			}
			catch (global::System.Exception e)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, base.RadioProfile.Path, "Generic exception", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "Generic Error");
				result = 0;
			}
			return result;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000180B4 File Offset: 0x000162B4
		protected bool ReadHeader(uint addr, global::Motorola.Common.Communication.CommonUtil.fp_header_t header)
		{
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.ReadImage(addr.ToString(), 16U, false);
			memoryImage.CompactUnits();
			header.GetHeaderfromRawData(memoryImage[0].Data);
			return true;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000180EC File Offset: 0x000162EC
		protected bool ReadPack(uint addr, uint size, out byte[] buffer)
		{
			buffer = null;
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.ReadImage(addr.ToString(), size, false);
			memoryImage.CompactUnits();
			buffer = memoryImage[0].Data;
			return true;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00018124 File Offset: 0x00016324
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

		// Token: 0x06000263 RID: 611 RVA: 0x000181DC File Offset: 0x000163DC
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

		// Token: 0x06000264 RID: 612 RVA: 0x00018238 File Offset: 0x00016438
		protected global::Motorola.Common.Communication.CommonUtil.PackHeader ReadAnalizeInfo(ref uint addr, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID)
		{
			global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader = null;
			global::Motorola.Common.Communication.TetraUtility.FlashAttribute flashAttribute;
			if (!base.GetFlashAttributes(out flashAttribute))
			{
				addr = 0U;
				return packHeader;
			}
			if (addr < flashAttribute.startAddr || addr >= flashAttribute.lastAddr)
			{
				addr = 0U;
				return packHeader;
			}
			bool flag = true;
			global::Motorola.Common.Communication.CommonUtil.fp_header_t fp_header_t = new global::Motorola.Common.Communication.CommonUtil.fp_header_t();
			byte[] data = null;
			if (flag && !this.ReadHeader(addr, fp_header_t))
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
			if (flag && !this.ReadPack(addr, 48U, out data))
			{
				flag = false;
			}
			if (flag)
			{
				packHeader = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.CreateInfo(fp_header_t, data, resID.ByteOrder);
			}
			if (flag && packHeader != null)
			{
				addr += fp_header_t.pack_size;
			}
			else
			{
				addr = 0U;
				packHeader = null;
			}
			return packHeader;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000182EC File Offset: 0x000164EC
		protected global::Motorola.Common.Communication.TetraUtility.FPBase ReadAnalizePack(ref uint addr, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID)
		{
			global::Motorola.Common.Communication.TetraUtility.FPBase fpbase = null;
			global::Motorola.Common.Communication.TetraUtility.FlashAttribute flashAttribute;
			if (!base.GetFlashAttributes(out flashAttribute))
			{
				addr = 0U;
				return fpbase;
			}
			if (addr < flashAttribute.startAddr || addr >= flashAttribute.lastAddr)
			{
				addr = 0U;
				return fpbase;
			}
			bool flag = true;
			global::Motorola.Common.Communication.CommonUtil.fp_header_t fp_header_t = new global::Motorola.Common.Communication.CommonUtil.fp_header_t();
			byte[] data = null;
			if (flag && !this.ReadHeader(addr, fp_header_t))
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
			if (flag && !this.ReadPack(addr, fp_header_t.pack_size, out data))
			{
				flag = false;
			}
			if (flag)
			{
				fpbase = this.CreatePack(fp_header_t, data);
			}
			if (flag && fpbase != null)
			{
				addr += fp_header_t.pack_size;
			}
			else
			{
				addr = 0U;
				fpbase = null;
			}
			return fpbase;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000183A0 File Offset: 0x000165A0
		protected void ReadLLP(out global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage llpPack, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID)
		{
			llpPack = null;
			if (resID.HasFP)
			{
				uint pFPStartAdd = resID.FPInfo.pFPStartAdd;
				uint num = 0U;
				while (pFPStartAdd > 0U)
				{
					num = pFPStartAdd;
					global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader = this.ReadAnalizeInfo(ref pFPStartAdd, resID);
					if (packHeader != null && packHeader.type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
					{
						llpPack = (global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage)this.ReadAnalizePack(ref num, resID);
						if (llpPack != null)
						{
							return;
						}
					}
				}
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000183FC File Offset: 0x000165FC
		protected void ReadInfo(global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs)
		{
			packs = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			if (resID.HasFP)
			{
				uint pFPStartAdd = resID.FPInfo.pFPStartAdd;
				while (pFPStartAdd > 0U)
				{
					global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader = this.ReadAnalizeInfo(ref pFPStartAdd, resID);
					if (pFPStartAdd != 0U && packHeader != null)
					{
						packs.Add(packHeader);
					}
				}
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00018478 File Offset: 0x00016678
		protected void CheckPackExists(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> packsList)
		{
			global::Motorola.Common.Communication.SequenceManager.TetraPhysicalAddressSeqMgr.<>c__DisplayClass3a CS$<>8__locals1 = new global::Motorola.Common.Communication.SequenceManager.TetraPhysicalAddressSeqMgr.<>c__DisplayClass3a();
			CS$<>8__locals1.packs = packs;
			if (CS$<>8__locals1.packs == null || packsList.Count == 0)
			{
				return;
			}
			if (packsList == null || packsList.Count == 0)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5056", "Invalid flash packs selected.");
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::Motorola.Common.Communication.TetraUtility.FPBase fpbase in packsList)
			{
				list.Add(fpbase.GetImageName());
			}
			int i;
			for (i = 0; i < CS$<>8__locals1.packs.Count; i++)
			{
				if (!list.Exists((string p) => string.Equals(p, CS$<>8__locals1.packs[i].imageName)))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5056", "Invalid flash packs selected.");
				}
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00018574 File Offset: 0x00016774
		protected bool DoReadRadioLP(global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> radioPacks)
		{
			radioPacks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase>();
			bool result = true;
			uint pFPStartAdd = resID.FPInfo.pFPStartAdd;
			while (pFPStartAdd > 0U)
			{
				global::Motorola.Common.Communication.TetraUtility.FPBase fpbase = this.ReadAnalizePack(ref pFPStartAdd, resID);
				if (pFPStartAdd != 0U && fpbase != null)
				{
					radioPacks.Add(fpbase);
				}
			}
			return result;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000185B8 File Offset: 0x000167B8
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
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD0003", "Common error, bad software image");
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

		// Token: 0x0600026B RID: 619 RVA: 0x00018658 File Offset: 0x00016858
		protected void CreateFPImage2Write(uint startAddr, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> packsList, out global::Motorola.Common.Communication.CommonUtil.MemoryImage image, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID)
		{
			image = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
			global::Motorola.Common.Communication.TetraUtility.FPBase fpbase = null;
			uint num = (startAddr > 0U) ? startAddr : resID.FPInfo.pFPStartAdd;
			for (int i = 0; i < packs.Count; i++)
			{
				if (packs[i].type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.FONT_PACK || packs[i].type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LANGUAGE_PACK || packs[i].type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
				{
					global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = null;
					for (int j = 0; j < packsList.Count; j++)
					{
						fpbase = packsList[j];
						if (fpbase != null && string.Equals(fpbase.GetImageName(), packs[i].imageName, global::System.StringComparison.InvariantCulture))
						{
							flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
							flashMemoryUnit.ChargeUnit(num.ToString(), fpbase.Data);
							break;
						}
					}
					if (flashMemoryUnit != null)
					{
						image.AddItem(flashMemoryUnit);
						num += fpbase.PackSize;
					}
				}
			}
			for (int k = 0; k < packsList.Count; k++)
			{
				fpbase = packsList[k];
				if (fpbase is global::Motorola.Common.Communication.TetraUtility.FPMandatoryPack)
				{
					global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
					flashMemoryUnit.ChargeUnit(num.ToString(), fpbase.Data);
					image.AddItem(flashMemoryUnit);
					num += fpbase.PackSize;
				}
			}
			if (image.Size > resID.FPInfo.pFPEndAdd - resID.FPInfo.pFPStartAdd)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("RD5051", "FlashPack area exceeded.");
			}
			image.CompactUnits();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000187C4 File Offset: 0x000169C4
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
					global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = this.ReadImage(num.ToString(), 4U, false);
					memoryImage.CompactUnits();
					if (memoryImage.Count == 1 && memoryImage[0].Data.Length == 4)
					{
						num2 = global::System.BitConverter.ToUInt32(memoryImage[0].Data, 0);
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
							global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage2 = this.ReadImage(num2.ToString(), num3, false);
							memoryImage2.CompactUnits();
							if (memoryImage2.Count == 1 && (long)memoryImage2[0].Data.Length == (long)((ulong)num3))
							{
								result = memoryImage2[0].Data;
								break;
							}
						}
					}
				}
				catch
				{
				}
			}
			return result;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00018950 File Offset: 0x00016B50
		protected override bool VerifyLanguagePacks(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> returnPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks)
		{
			if (returnPacks == null || allPacks == null)
			{
				return false;
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = null;
			this.ReadRadioLPHeader(out list);
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader in list)
			{
				if (global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.IsMandatoryPack(packHeader))
				{
					list2.Add(packHeader);
				}
			}
			bool flag = true;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list3 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader2 in returnPacks)
			{
				list3.Add(global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.FindInfo(packHeader2.imageName, allPacks));
			}
			if ((long)(list3.Count + list2.Count) > 39L)
			{
				flag = false;
			}
			if (flag)
			{
				uint num = 0U;
				for (int i = 0; i < list3.Count; i++)
				{
					global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader3 = list3[i];
					for (int j = i + 1; j < list3.Count; j++)
					{
						global::Motorola.Common.Communication.CommonUtil.PackHeader pack = list3[j];
						if (packHeader3.IsConflict(pack))
						{
							flag = false;
							break;
						}
					}
					if (packHeader3.type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LANGUAGE_PACK)
					{
						num += 1U;
					}
				}
				if (flag && num > 18U)
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00018AAC File Offset: 0x00016CAC
		protected override bool VerifyLanguagePacks(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> returnPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> mandatoryPacks, uint fpSize)
		{
			return global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.VerifyLanguagePacks(returnPacks, allPacks, mandatoryPacks, fpSize);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00018AB8 File Offset: 0x00016CB8
		protected bool DoWriteRadioLP(bool eraseAllPacks, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, global::Motorola.Common.Communication.CommonUtil.MemoryImage imgToWrite, global::Motorola.Common.Communication.FDT.FDTParams fdtParams, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status)
		{
			bool flag = true;
			if (imgToWrite.Size > resID.FPInfo.pFPEndAdd - resID.FPInfo.pFPStartAdd)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5073_FP_CommErrWriteLLPFailed.ToString(), "FlashPack area exceeded,Write llp error");
			}
			if (flag)
			{
				if (fdtParams == null)
				{
					this.BeginUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS, this.CodeplugVersion, this.ModelType, "", true);
				}
				else
				{
					this.BeginUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS, fdtParams.cpVersion, fdtParams.modelType, "", true);
				}
				if (eraseAllPacks)
				{
					this.EraseFromTo(resID.FPInfo.pFPStartAdd.ToString(), resID.FPInfo.pFPEndAdd.ToString());
				}
				try
				{
					if (imgToWrite.Count >= 1)
					{
						this.WriteImage(imgToWrite, status, false);
					}
				}
				catch
				{
					throw;
				}
				if (fdtParams == null)
				{
					this.EndUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS, this.CodeplugVersion, this.ModelType, "");
				}
				else
				{
					this.EndUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FLASHPACKS, fdtParams.cpVersion, fdtParams.modelType, "");
				}
			}
			return flag;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00018BC8 File Offset: 0x00016DC8
		protected void WriteLP(global::Motorola.Common.Communication.TetraUtility.ReleaseID releaseID, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, string swPath, global::Motorola.Common.Communication.FDT.FDTParams fdtParams)
		{
			try
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> list = null;
				if (string.IsNullOrEmpty(swPath))
				{
					this.DoReadRadioLP(releaseID, out list);
					for (int i = list.Count - 1; i >= 0; i--)
					{
						if ((byte)list[i].PackType == 100)
						{
							list.RemoveAt(i);
						}
					}
				}
				else
				{
					global::Motorola.Common.Communication.TetraUtility.Z19File swFile = global::Motorola.Common.Communication.TetraUtility.FPTools.LoadSoftwareFile(swPath);
					this.ScanPacks(swFile, releaseID, out list);
				}
				this.CheckPackExists(packs, list);
				global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage fplocalLanguage = null;
				base.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingLLP);
				this.ReadLLP(out fplocalLanguage, this._releaseID);
				base.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadLLPDone);
				if (fplocalLanguage != null)
				{
					list.Add(fplocalLanguage);
					packs.Add(fplocalLanguage.PackHeader);
				}
				for (int j = 0; j < packs.Count; j++)
				{
					if (packs[j].type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
					{
						global::Motorola.Common.Communication.CommonUtil.PackHeader item = packs[j];
						packs.RemoveAt(j);
						packs.Insert(0, item);
					}
				}
				global::Motorola.Common.Communication.CommonUtil.MemoryImage imgToWrite = null;
				this.CreateFPImage2Write(0U, packs, list, out imgToWrite, releaseID);
				this.DoWriteRadioLP(true, releaseID, imgToWrite, fdtParams, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException)
			{
				throw;
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00018CF8 File Offset: 0x00016EF8
		protected void WriteLLP(global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, byte[] llpData)
		{
			global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage fplocalLanguage = null;
			base.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingLLP);
			this.ReadLLP(out fplocalLanguage, this._releaseID);
			base.IncreaseProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadLLPDone);
			if (fplocalLanguage != null)
			{
				global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
				uint pFPStartAdd = resID.FPInfo.pFPStartAdd;
				global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
				flashMemoryUnit.ChargeUnit(pFPStartAdd.ToString(), llpData);
				memoryImage.AddItem(flashMemoryUnit);
				memoryImage.CompactUnits();
				this.DoWriteRadioLP(false, resID, memoryImage, null, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLLP);
				return;
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.FPBase> list = null;
			if (this.DoReadRadioLP(resID, out list))
			{
				global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage2 = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
				uint num = resID.FPInfo.pFPStartAdd;
				global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit2 = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
				flashMemoryUnit2.ChargeUnit(num.ToString(), llpData);
				memoryImage2.AddItem(flashMemoryUnit2);
				uint num2 = (uint)llpData.Length;
				num += num2;
				foreach (global::Motorola.Common.Communication.TetraUtility.FPBase fpbase in list)
				{
					global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit3 = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
					flashMemoryUnit3.ChargeUnit(num.ToString(), fpbase.Data);
					memoryImage2.AddItem(flashMemoryUnit3);
					num += fpbase.PackSize;
				}
				memoryImage2.CompactUnits();
				if (!this.DoWriteRadioLP(true, resID, memoryImage2, null, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLLP))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5073_FP_CommErrWriteLLPFailed.ToString());
				}
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00018E60 File Offset: 0x00017060
		protected void BeginUpdateCodeplugAndSoftwareFdt(string sCpVer, ushort modelType, string sSerialNumber, string sRadioVersion)
		{
			this.BeginUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_CODEPLUG, sCpVer, modelType, sSerialNumber, true);
			this.BeginUpdateFDT(global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FIRMWARE, sCpVer, modelType, sRadioVersion, true);
		}
	}
}
