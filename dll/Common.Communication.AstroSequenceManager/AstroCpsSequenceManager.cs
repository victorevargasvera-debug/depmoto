using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Xml;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000005 RID: 5
	public class AstroCpsSequenceManager : global::Motorola.Common.Communication.ICpsSequenceManager, global::Motorola.Common.Communication.IDepotSequenceManager
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001B RID: 27 RVA: 0x0000290C File Offset: 0x00000B0C
		protected global::Motorola.Common.Communication.IMessageExecutor RcmpWrapper
		{
			get
			{
				return this.m_RcmpWrapper;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002914 File Offset: 0x00000B14
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000292B File Offset: 0x00000B2B
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo
		{
			get
			{
				if (this.m_currExDeviceInfo == null)
				{
					this.ReadExtendedDeviceInfo();
				}
				return this.m_currExDeviceInfo;
			}
			set
			{
				this.m_currExDeviceInfo = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002934 File Offset: 0x00000B34
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000293C File Offset: 0x00000B3C
		public bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002945 File Offset: 0x00000B45
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000294D File Offset: 0x00000B4D
		protected global::Motorola.Common.Communication.RadioParams ExtendedRadioParam
		{
			get
			{
				return this.m_ExtendedRadioParams;
			}
			set
			{
				this.m_ExtendedRadioParams = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002956 File Offset: 0x00000B56
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000295E File Offset: 0x00000B5E
		public global::Motorola.Common.Communication.Rcmp.XcmpComponentSession SessionCommandReply
		{
			get
			{
				return this.sessionCommandReply;
			}
			set
			{
				this.sessionCommandReply = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002967 File Offset: 0x00000B67
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000296F File Offset: 0x00000B6F
		public global::Motorola.Common.Communication.CommonUtil.SessionParameter SessionParam
		{
			get
			{
				return this.m_SessionParameter;
			}
			set
			{
				this.m_SessionParameter = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002978 File Offset: 0x00000B78
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002980 File Offset: 0x00000B80
		private global::Motorola.Common.Communication.IshHandler.CommonIshHandler IshHandler
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002989 File Offset: 0x00000B89
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002991 File Offset: 0x00000B91
		private protected global::Motorola.Common.Communication.IshHandler.IOController IOController
		{
			protected get
			{
				return this._IOController;
			}
			private set
			{
				this._IOController = value;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000299C File Offset: 0x00000B9C
		public AstroCpsSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParam)
		{
			this.m_RcmpWrapper = rcmpWrapper;
			this.m_ExtendedRadioParams = new global::Motorola.Common.Communication.RadioParams();
			if (rcmpWrapper is global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor)
			{
				this.m_MaxTransportPacketSize = 1368;
			}
			else if (rcmpWrapper is global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor)
			{
				if (this is global::Motorola.Common.Communication.AstroOtapFileSeqManager)
				{
					this.m_MaxTransportPacketSize = 1368;
				}
				else
				{
					this.m_MaxTransportPacketSize = 968;
				}
			}
			else
			{
				this.m_MaxTransportPacketSize = 1368;
			}
			if (sessionParam != null)
			{
				this.m_SessionParameter = sessionParam;
			}
			else
			{
				this.m_SessionParameter = new global::Motorola.Common.Communication.CommonUtil.SessionParameter(0, false);
			}
			this.IshHandler = new global::Motorola.Common.Communication.IshHandler.CommonIshHandler(rcmpWrapper, this.m_MaxTransportPacketSize);
			this.IOController = new global::Motorola.Common.Communication.IshHandler.IOController(rcmpWrapper, this.m_MaxTransportPacketSize, false);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002A49 File Offset: 0x00000C49
		public virtual bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			return true;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002A4C File Offset: 0x00000C4C
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002A54 File Offset: 0x00000C54
		public global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator { get; set; }

		// Token: 0x0600002E RID: 46 RVA: 0x00002A5D File Offset: 0x00000C5D
		public virtual void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)
			{
				this.UnlockRadioPartition(212);
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
				{
					this.EnterReadProgramMode();
					return;
				}
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
				{
					this.EnterWriteProgramMode();
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002A88 File Offset: 0x00000C88
		public virtual void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
			{
				this.ExitReadProgramMode();
				return;
			}
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
			{
				if (!pendingDeploy)
				{
					uint num = 0U;
					this.CodeplugUpdate(global::Motorola.Common.Communication.UpdateControlAction.RadioValidateCodeplug, out num);
				}
				this.ExitWriteProgramMode();
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002ABC File Offset: 0x00000CBC
		public bool DifferentialWriteSupported(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			bool result = false;
			if (this.SessionParam.PreviousSessionID > 0 && this.SessionParam.ArchiveSession && (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program || operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash))
			{
				ushort num;
				ushort num2;
				this.IOController.ComponentSession(7, sessionID, this.SessionParam.PreviousSessionID, out num, out num2);
				if (this.IOController.SessionCommandReply.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					this.DifferentialWriteCapableRadio = true;
					return true;
				}
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002B28 File Offset: 0x00000D28
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = new global::Motorola.Common.Communication.CommonUtil.DeviceInfo();
			deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
			global::Motorola.Common.Communication.RadioParams radioData = this.ReadBasicRadioIdentity();
			global::Motorola.Common.Communication.AstroCpsSequenceManager.ParseBasicInfo(deviceInfo, radioData);
			return deviceInfo;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002B54 File Offset: 0x00000D54
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo astroDeviceInfo = new global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo();
			astroDeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
			global::Motorola.Common.Communication.RadioParams radioData = this.ReadExtendedRadioIdentity();
			global::Motorola.Common.Communication.AstroCpsSequenceManager.ParseBasicInfo(astroDeviceInfo, radioData);
			global::Motorola.Common.Communication.AstroCpsSequenceManager.ParseExtendedInfo(astroDeviceInfo, radioData);
			this.m_currExDeviceInfo = astroDeviceInfo;
			return astroDeviceInfo;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002B8C File Offset: 0x00000D8C
		public virtual global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = this.ReadRadioCodeplug();
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
			}
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			pbaObject.SetCodeplug(codeplug);
			global::Motorola.Common.Communication.RadioParams radioParams = this.ReadExtendedRadioIdentity();
			pbaObject.CodeplugData.CPVersion = radioParams.CodeplugVersion;
			this.UpdateWiFiPasswordAfterRead(pbaObject);
			this.UpdateExternalDataModemPasswordAfterRead(pbaObject);
			return pbaObject;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002C10 File Offset: 0x00000E10
		public virtual global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			byte[] buffer = writePBA.SerializeToBytes();
			this.ValidateCodeplugVersion(writePBA);
			this.WriteValidation(writePBA);
			this.WriteRadioCodeplug(writePBA, false);
			pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(buffer, false);
			pbaObject.CodeplugData.ArchiveSessionID = sessionID;
			return pbaObject;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002C58 File Offset: 0x00000E58
		protected void ValidateCodeplugVersion(global::Motorola.Common.Communication.Pba.PbaObject writePBA)
		{
			string cpversion = writePBA.CodeplugData.CPVersion;
			if (!writePBA.IsRetoreJob && cpversion.StartsWith("R", global::System.StringComparison.Ordinal))
			{
				string text = this.IOController.QueryCodeplugVersion();
				int num = (int)global::System.Convert.ToInt16(text.Substring(1, 2), 10);
				int num2 = (int)global::System.Convert.ToInt16(cpversion.Substring(1, 2), 10);
				int num3 = (int)global::System.Convert.ToInt16(text.Substring(4, 2), 10);
				int num4 = (int)global::System.Convert.ToInt16(cpversion.Substring(4, 2), 10);
				if (num2 < num || (num2 == num && num4 < num3))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CPVersionVerifyFailed);
				}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public virtual void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
			}
			this.WriteRadioCodeplug(writePBA, true);
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002D40 File Offset: 0x00000F40
		public void UpdateSerialNumber(string serialNumber)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(serialNumber + '\0');
			this.IOController.UpdateSerialNumber(bytes);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002D70 File Offset: 0x00000F70
		public void UpdateMACAddress(byte[] macAddress)
		{
			this.IOController.UpdateMACAddress(macAddress);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002D7E File Offset: 0x00000F7E
		public void UpdateIMEType(byte ime)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002D86 File Offset: 0x00000F86
		public void UpdateDateCode(byte[] datecode, ushort source)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002D8E File Offset: 0x00000F8E
		public void UnkillRadio(byte[] authenticationValue)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002D96 File Offset: 0x00000F96
		public byte[] ReadUnkillChallengeValue()
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002DAC File Offset: 0x00000FAC
		public void CBIProgramme()
		{
			byte[] serailNumber = new byte[]
			{
				200,
				212,
				221,
				157,
				162,
				204,
				132,
				209,
				157,
				175,
				0
			};
			this.IOController.UpdateSerialNumber(serailNumber);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002DD8 File Offset: 0x00000FD8
		protected void WriteValidation(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> validateItemsToRead = global::Motorola.Common.Communication.IshHandler.Validator.GetValidateItemsToRead(pbaObject.ValidationFields);
			if (validateItemsToRead != null && validateItemsToRead.Any<global::Motorola.Common.Communication.CommonUtil.IshHeader>())
			{
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = this.ReadIshItems(validateItemsToRead);
				ishItemCollection = this.RemoveChecksumBytes(ishItemCollection);
				global::Motorola.Common.Communication.IshHandler.Validator.ValidateFields(pbaObject.ValidationFields, ishItemCollection);
			}
			if (pbaObject.ValidationInfos != null && pbaObject.ValidationInfos.Count > 0)
			{
				global::Motorola.Common.Communication.IshHandler.Validator.ValidateInfos(pbaObject.ValidationInfos, this.ReadExtendedDeviceInfo(), new global::Motorola.Common.Communication.VersionComparator());
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002E44 File Offset: 0x00001044
		private global::Motorola.Common.Communication.CommonUtil.IshItemCollection RemoveChecksumBytes(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishCollection)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in ishCollection)
			{
				global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
				if (value.Data.Length > 2)
				{
					value.Data = value.Data.Take(value.Data.Length - 2).ToArray<byte>();
					ishItemCollection.Add(keyValuePair.Key, value);
				}
			}
			return ishItemCollection;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002ED4 File Offset: 0x000010D4
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
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = this.IshHandler.ReadIshItems(list, this.ProgressIndicator);
				if (this.ProgressIndicator != null)
				{
					this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
				}
				pbaObject.SetCodeplug(codeplug);
				this.UpdateWiFiPasswordAfterRead(pbaObject);
				return pbaObject;
			}
			throw new global::System.ArgumentNullException();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002FCC File Offset: 0x000011CC
		public virtual global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002FD4 File Offset: 0x000011D4
		public virtual void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002FDC File Offset: 0x000011DC
		public virtual void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002FE4 File Offset: 0x000011E4
		public virtual global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002FEC File Offset: 0x000011EC
		public virtual void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002FF4 File Offset: 0x000011F4
		public virtual void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002FFC File Offset: 0x000011FC
		public void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003004 File Offset: 0x00001204
		public void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000300B File Offset: 0x0000120B
		public void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003012 File Offset: 0x00001212
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003019 File Offset: 0x00001219
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003020 File Offset: 0x00001220
		protected virtual global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadIshItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders)
		{
			return this.IshHandler.ReadIshItems(ishHeaders, null);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003030 File Offset: 0x00001230
		private static void ParseBasicInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.RadioParams radioData)
		{
			deviceInfo.CodeplugVersion = radioData.CodeplugVersion;
			deviceInfo.ModelNumber = radioData.ModelNumber;
			deviceInfo.SerialNumber = radioData.SerialNumber;
			deviceInfo.SoftwareVersion = radioData.HostVersion;
			if (deviceInfo.ConnectionInfo == null)
			{
				deviceInfo.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
			}
			if (!string.IsNullOrEmpty(radioData.DefaultGatewayNetworkAttachmentValue))
			{
				global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue networkAttachmentValue = (global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue)global::System.Convert.ToByte(radioData.DefaultGatewayNetworkAttachmentValue);
				global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue networkAttachmentValue2 = networkAttachmentValue;
				switch (networkAttachmentValue2)
				{
				case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.NoDefaultGateway:
				case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.OneG:
				case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.TwoG:
				case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.ThreeG:
				case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.WiFi:
					break;
				case global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.FourG:
					deviceInfo.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LTE;
					goto IL_BC;
				default:
					if (networkAttachmentValue2 == global::Motorola.Common.Communication.Rcmp.NetworkAttachmentValue.LMR)
					{
						deviceInfo.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LMR;
						goto IL_BC;
					}
					break;
				}
				deviceInfo.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.NONE;
			}
			else
			{
				deviceInfo.ConnectionInfo.OtapConnectionType = global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.NONE;
			}
			IL_BC:
			if (radioData.PsdtVersion.Length > 0)
			{
				global::System.Version version = new global::System.Version(radioData.PsdtVersion.Remove(0, 1));
				deviceInfo.RadioStorage = ((version.CompareTo(new global::System.Version("06.70.00")) >= 0) ? global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem : global::Motorola.Common.Communication.CommonUtil.RadioStorage.Raw);
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_InvalidPSDT);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003144 File Offset: 0x00001344
		private static void ParseExtendedInfo(global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo deviceInfo, global::Motorola.Common.Communication.RadioParams radioData)
		{
			deviceInfo.UUID = radioData.Uuid.ToString();
			deviceInfo.RadioBBFSuiteVersion = radioData.BBFBundleVersion;
			deviceInfo.TuneVersion = radioData.TuneVersion;
			deviceInfo.PsdtVersion = radioData.PsdtVersion;
			deviceInfo.MaceFlashVersion = radioData.MaceFlashVersion;
			deviceInfo.DspVersion = radioData.DspVersion;
			deviceInfo.BootloaderVersion = radioData.BootAppVersion;
			deviceInfo.OptionBoardFlashImageType = radioData.OptBrdFlashImageType;
			deviceInfo.OptionBoardFlashImageVersion = radioData.OptBrdFlashImageVersion;
			deviceInfo.OptionBoardHardwareHostVersion = radioData.OptBrdHwHostVersion;
			deviceInfo.OptionBoardHardwareNotPresentFlag = radioData.OptBrdHwNotPresentFlag;
			deviceInfo.OptionBoardHardwareType = radioData.OptBrdHardwareType;
			deviceInfo.OptionBoardName = radioData.OptBoardName;
			deviceInfo.ConsoletteBoardHardwareType = radioData.ConBrdHardwareType;
			deviceInfo.ConsoletteBoardHardwareHostVersion = radioData.ConBrdHwHostVersion;
			deviceInfo.MaceSecureHardwareType = radioData.MaceHardwareType;
			deviceInfo.MaceSecureHardwareVersion = radioData.MaceHardwareVersion;
			if (radioData.ESerialNumber != null && radioData.ESerialNumber.Length > 0)
			{
				deviceInfo.ESN = new byte[radioData.ESerialNumber.Length];
				radioData.ESerialNumber.CopyTo(deviceInfo.ESN, 0);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003274 File Offset: 0x00001474
		protected virtual void WriteRadioCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePBA, bool forceWrite)
		{
			if (!forceWrite)
			{
				writePBA.CodeplugData.DataPartitions.RemoveAll((global::Motorola.Common.Communication.Pba.DataPartition x) => x.PartitionID == 212);
				this.UpdatePINPasswordBeforeWrite(writePBA);
				this.UpdateWiFiPasswordBeforeWrite(writePBA);
				this.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = writePBA.GetCodeplugInIshItemCollection();
			if (codeplugInIshItemCollection.Count <= 0)
			{
				return;
			}
			uint num = 255U;
			uint num2 = 255U;
			int num3 = 0;
			int num4;
			for (;;)
			{
				num4 = this.CodeplugUpdate(global::Motorola.Common.Communication.UpdateControlAction.RadioUpdateCodeplug, out num);
				uint num5 = num;
				if (num4 == 0 && num == 100U)
				{
					num4 = this.CodeplugUpdate(global::Motorola.Common.Communication.UpdateControlAction.RadioCodeplugActive, out num);
					num2 = num;
					if (this.ProgressIndicator != null && this.ProgressIndicator.CurrentStatus == global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ErasingCP)
					{
						this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ErasingCP);
					}
				}
				else
				{
					if (this.ProgressIndicator != null)
					{
						this.ProgressIndicator.UpdateProgress(num5 / 100.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ErasingCP);
					}
					num3++;
					if (num3 > 65)
					{
						break;
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Radio background eraser running", new object[0]);
					if (num5 < 50U)
					{
						global::System.Threading.Thread.Sleep(5000);
					}
					else
					{
						global::System.Threading.Thread.Sleep(1000);
					}
				}
				if (num5 == 100U)
				{
					goto Block_11;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_BackgroundEraseTimeout);
			Block_11:
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
			}
			uint csdAddress = this.CodeplugAddress(num2);
			num4 = this.CopyCodeplugCSDToRadio(csdAddress);
			if (!forceWrite)
			{
				num4 = this.CopyRadioSecToInactive(num2);
			}
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(0.2, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
			}
			this.IshHandler.WriteIshItems(codeplugInIshItemCollection, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.ProgressIndicator, 0.8), true);
			if (this.ProgressIndicator != null)
			{
				this.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003450 File Offset: 0x00001650
		private int CodeplugUpdate(global::Motorola.Common.Communication.UpdateControlAction action, out uint Value)
		{
			int result = 0;
			global::Motorola.Common.Communication.XcmpRadioUpdateControl xcmpRadioUpdateControl = new global::Motorola.Common.Communication.XcmpRadioUpdateControl(action);
			this.RcmpWrapper.SendAndReceiveMessage(xcmpRadioUpdateControl);
			if (xcmpRadioUpdateControl.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				uint value = (uint)xcmpRadioUpdateControl.Value;
				Value = value;
				return result;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_IshStatusBad);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003498 File Offset: 0x00001698
		protected void UnlockRadioPartition(byte partition)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadRadioKey rcmpReadRadioKey = new global::Motorola.Common.Communication.Rcmp.RcmpReadRadioKey();
			this.RcmpWrapper.SendAndReceiveMessage(rcmpReadRadioKey);
			if (rcmpReadRadioKey.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_UnlockRadioPartitionFailure);
			}
			byte[] array = global::Motorola.Common.Communication.RadioSecurity.EncryptRadioKey(rcmpReadRadioKey.RadioKey);
			if (array.Length > this.m_MaxTransportPacketSize)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_TooLongRadioKey);
			}
			global::Motorola.Common.Communication.Rcmp.RcmpUnlockSecurity rcmpUnlockSecurity = new global::Motorola.Common.Communication.Rcmp.RcmpUnlockSecurity(array);
			this.RcmpWrapper.SendAndReceiveMessage(rcmpUnlockSecurity);
			if (rcmpUnlockSecurity.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_UnlockRadioPartitionFailure);
			}
			if (partition > 0 && partition < 255)
			{
				global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition rcmpIshUnlockPartition = new global::Motorola.Common.Communication.Rcmp.RcmpIshUnlockPartition(partition);
				this.RcmpWrapper.SendAndReceiveMessage(rcmpIshUnlockPartition);
				if (rcmpIshUnlockPartition.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_UnlockRadioPartitionFailure);
				}
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003544 File Offset: 0x00001744
		protected virtual void EnterReadProgramMode()
		{
			this.IOController.EnterProgramMode(0, null);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003553 File Offset: 0x00001753
		protected virtual void ExitReadProgramMode()
		{
			this.IOController.ExitProgramMode(1, null);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003562 File Offset: 0x00001762
		protected virtual void EnterWriteProgramMode()
		{
			this.IOController.EnterProgramMode(0, null);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003571 File Offset: 0x00001771
		protected virtual void ExitWriteProgramMode()
		{
			this.IOController.ExitProgramMode(1, null);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003580 File Offset: 0x00001780
		protected void EnterProgramMode()
		{
			this.IOController.EnterProgramMode(0, null);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000358F File Offset: 0x0000178F
		protected void ExitProgramMode()
		{
			this.IOController.ExitProgramMode(1, null);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000035A0 File Offset: 0x000017A0
		private global::Motorola.Common.Communication.RadioParams ReadBasicRadioIdentity()
		{
			global::Motorola.Common.Communication.RadioParams result = this.ReadBasicRadioParams();
			if (!this.CheckRadioUuid())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_InvalidUUID);
			}
			return result;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000035C8 File Offset: 0x000017C8
		private global::Motorola.Common.Communication.RadioParams ReadExtendedRadioIdentity()
		{
			global::Motorola.Common.Communication.RadioParams radioParams = this.ReadExtendedRadioParams();
			if (this.DifferentialWriteCapableRadio)
			{
				this.ExtendedRadioParam = radioParams;
				if (!this.CheckUuidFromRadioParam(radioParams.Uuid))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_InvalidUUID);
				}
			}
			else if (!this.CheckRadioUuid())
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_InvalidUUID);
			}
			return radioParams;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003618 File Offset: 0x00001818
		protected global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadRadioCodeplug()
		{
			byte b = 208;
			global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
			while (b < 214)
			{
				list.Add(b);
				b += 2;
			}
			global::System.Collections.Generic.List<ushort> list2 = new global::System.Collections.Generic.List<ushort>();
			for (ushort num = 0; num < 2044; num += 1)
			{
				list2.Add(num);
			}
			return this.IshHandler.ReadCodeplug(list.ToArray(), this.ProgressIndicator, list2);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003680 File Offset: 0x00001880
		private void LoadSupportedUuidList()
		{
			if (global::Motorola.Common.Communication.AstroCpsSequenceManager.m_SupportedUuids != null)
			{
				return;
			}
			lock (this)
			{
				if (global::Motorola.Common.Communication.AstroCpsSequenceManager.m_SupportedUuids == null)
				{
					global::Motorola.Common.Communication.AstroCpsSequenceManager.m_SupportedUuids = new global::System.Collections.Generic.Dictionary<global::System.Guid, string>();
					using (global::System.IO.Stream manifestResourceStream = global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Motorola.Common.Communication.CpsSequenceManagerData.xml"))
					{
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(manifestResourceStream);
						global::System.Xml.XmlNodeList xmlNodeList = xmlDocument.SelectNodes("CpsSequenceManagerData/SupportedUuidList/Uuid");
						if (xmlNodeList != null)
						{
							foreach (object obj in xmlNodeList)
							{
								global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
								global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes["Value"];
								global::System.Xml.XmlAttribute xmlAttribute2 = xmlNode.Attributes["Description"];
								if (xmlAttribute != null)
								{
									string value = string.Empty;
									if (xmlAttribute2 != null)
									{
										value = xmlAttribute2.Value;
									}
									global::Motorola.Common.Communication.AstroCpsSequenceManager.m_SupportedUuids.Add(new global::System.Guid(xmlAttribute.Value), value);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000037C0 File Offset: 0x000019C0
		private global::Motorola.Common.Communication.RadioParams ReadBasicRadioParams()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle = new global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle(true);
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber rcmpReadWriteModelNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber(0, null);
			xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteModelNumber);
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadRadioSerialNumber, null);
			xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteSerialNumber);
			global::Motorola.Common.Communication.Rcmp.RcmpReadUUID rcmpReadUUID = new global::Motorola.Common.Communication.Rcmp.RcmpReadUUID();
			xcmpSuperBundle.AddRcmpMessage(rcmpReadUUID);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.CodeplugVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation2 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.PsdtVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation2);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation3 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.HostSoftwareVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation3);
			xcmpSuperBundle.ReadTimeout = 15000;
			this.RcmpWrapper.SendAndReceiveMessage(xcmpSuperBundle);
			global::Motorola.Common.Communication.RadioParams radioParams = new global::Motorola.Common.Communication.RadioParams();
			char[] trimChars = new char[]
			{
				'\0',
				' ',
				'\r',
				'\n'
			};
			if (rcmpReadWriteSerialNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
			}
			radioParams.SerialNumber = rcmpReadWriteSerialNumber.SerialNumber;
			if (rcmpReadWriteModelNumber.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
			}
			radioParams.ModelNumber = rcmpReadWriteModelNumber.ModelNumber;
			if (rcmpReadUUID.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
			}
			radioParams.Uuid = new global::System.Guid(rcmpReadUUID.UUID);
			if (rcmpVersionInformation.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
			}
			radioParams.CodeplugVersion = rcmpVersionInformation.VersionInformation.TrimEnd(trimChars);
			if (rcmpVersionInformation2.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
			}
			radioParams.PsdtVersion = rcmpVersionInformation2.VersionInformation.TrimEnd(trimChars);
			if (rcmpVersionInformation3.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				radioParams.HostVersion = rcmpVersionInformation3.VersionInformation.TrimEnd(trimChars);
				return radioParams;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerReadBasicDeviceInfoFailure);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003960 File Offset: 0x00001B60
		private global::Motorola.Common.Communication.RadioParams ReadExtendedRadioParams()
		{
			global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle = new global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle(true);
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber rcmpReadWriteModelNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteModelNumber(0, null);
			xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteModelNumber);
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadRadioSerialNumber, null);
			xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteSerialNumber);
			global::Motorola.Common.Communication.Rcmp.RcmpReadUUID rcmpReadUUID = new global::Motorola.Common.Communication.Rcmp.RcmpReadUUID();
			xcmpSuperBundle.AddRcmpMessage(rcmpReadUUID);
			global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus rcmpRadioStatus = new global::Motorola.Common.Communication.Rcmp.RcmpRadioStatus(global::Motorola.Common.Communication.Rcmp.RadioStatusCondition.DefaultGatewayNetworkAttachment);
			xcmpSuperBundle.AddRcmpMessage(rcmpRadioStatus);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.CodeplugVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation2 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.HostSoftwareVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation2);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation3 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.BBFBundleVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation3);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation4 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.TuneVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation4);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation5 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.FlashBootAppVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation5);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation6 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.DspSoftwareVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation6);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation7 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.MaceFlashVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation7);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation8 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.PsdtVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation8);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation9 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardName);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation9);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation10 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardHardwareType);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation10);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation11 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardMainAppVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation11);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation12 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardFlashImageVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation12);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation13 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.OptionBoardFlashImageType);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation13);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation14 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.ConsoletteBrdHwType);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation14);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation15 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.ConsoletteBrdHostVer);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation15);
			global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber rcmpReadWriteSerialNumber2 = new global::Motorola.Common.Communication.Rcmp.RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadESN, null);
			xcmpSuperBundle.AddRcmpMessage(rcmpReadWriteSerialNumber2);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation16 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.MaceHardwareType);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation16);
			global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation rcmpVersionInformation17 = new global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType.MaceHardwareVersion);
			xcmpSuperBundle.AddRcmpMessage(rcmpVersionInformation17);
			xcmpSuperBundle.ReadTimeout = 15000;
			this.RcmpWrapper.SendAndReceiveMessage(xcmpSuperBundle);
			global::Motorola.Common.Communication.RadioParams radioParams = new global::Motorola.Common.Communication.RadioParams();
			char[] trimChars = new char[]
			{
				'\0',
				' ',
				'\r',
				'\n'
			};
			radioParams.SerialNumber = rcmpReadWriteSerialNumber.SerialNumber;
			radioParams.ModelNumber = rcmpReadWriteModelNumber.ModelNumber;
			radioParams.Uuid = new global::System.Guid(rcmpReadUUID.UUID);
			radioParams.CodeplugVersion = rcmpVersionInformation.VersionInformation.TrimEnd(trimChars);
			radioParams.HostVersion = rcmpVersionInformation2.VersionInformation.TrimEnd(trimChars);
			radioParams.TuneVersion = rcmpVersionInformation4.VersionInformation.TrimEnd(trimChars);
			radioParams.BootAppVersion = rcmpVersionInformation5.VersionInformation.TrimEnd(trimChars);
			radioParams.DspVersion = rcmpVersionInformation6.VersionInformation.TrimEnd(trimChars);
			radioParams.MaceFlashVersion = rcmpVersionInformation7.VersionInformation.TrimEnd(trimChars);
			radioParams.PsdtVersion = rcmpVersionInformation8.VersionInformation.TrimEnd(trimChars);
			if (rcmpVersionInformation3.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				radioParams.BBFBundleVersion = rcmpVersionInformation3.VersionInformation.TrimEnd(trimChars);
			}
			if (rcmpVersionInformation10.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				radioParams.OptBrdHardwareType = rcmpVersionInformation10.VersionInformation.TrimEnd(trimChars);
				if (string.IsNullOrEmpty(radioParams.OptBrdHardwareType))
				{
					radioParams.OptBrdHwNotPresentFlag = true;
				}
			}
			if (rcmpVersionInformation9.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				radioParams.OptBoardName = rcmpVersionInformation9.VersionInformation.TrimEnd(trimChars);
			}
			if (rcmpVersionInformation11.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				radioParams.OptBrdHwHostVersion = rcmpVersionInformation11.VersionInformation.TrimEnd(trimChars);
			}
			if (rcmpVersionInformation13.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				radioParams.OptBrdFlashImageType = rcmpVersionInformation13.VersionInformation.TrimEnd(trimChars);
				radioParams.OptBrdHwHostVersion = rcmpVersionInformation12.VersionInformation.TrimEnd(trimChars);
			}
			if (rcmpVersionInformation14.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				radioParams.ConBrdHardwareType = rcmpVersionInformation14.VersionInformation.TrimEnd(trimChars);
			}
			if (rcmpVersionInformation15.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				radioParams.ConBrdHwHostVersion = rcmpVersionInformation15.VersionInformation.TrimEnd(trimChars);
			}
			if (rcmpReadWriteSerialNumber2.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				radioParams.ESerialNumber = rcmpReadWriteSerialNumber2.SerialRawBytes;
			}
			if (rcmpVersionInformation16.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				radioParams.MaceHardwareType = rcmpVersionInformation16.VersionInformation.TrimEnd(trimChars);
			}
			if (rcmpVersionInformation17.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				radioParams.MaceHardwareVersion = rcmpVersionInformation17.VersionInformation.TrimEnd(trimChars);
			}
			if (rcmpRadioStatus.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				radioParams.DefaultGatewayNetworkAttachmentValue = rcmpRadioStatus.Status[0].ToString();
			}
			return radioParams;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003D5C File Offset: 0x00001F5C
		private bool CheckRadioUuid()
		{
			byte[] b = this.IOController.QueryRadioUUID();
			global::System.Guid b2 = new global::System.Guid(b);
			if (global::Motorola.Common.Communication.AstroCpsSequenceManager.m_SupportedUuids == null)
			{
				this.LoadSupportedUuidList();
			}
			foreach (global::System.Guid a in global::Motorola.Common.Communication.AstroCpsSequenceManager.m_SupportedUuids.Keys)
			{
				if (a == b2)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003DE0 File Offset: 0x00001FE0
		private bool CheckUuidFromRadioParam(global::System.Guid radioParamUuid)
		{
			if (global::Motorola.Common.Communication.AstroCpsSequenceManager.m_SupportedUuids == null)
			{
				this.LoadSupportedUuidList();
			}
			foreach (global::System.Guid a in global::Motorola.Common.Communication.AstroCpsSequenceManager.m_SupportedUuids.Keys)
			{
				if (a == radioParamUuid)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003E50 File Offset: 0x00002050
		internal string GetRadioProductName()
		{
			byte[] b = this.IOController.QueryRadioUUID();
			global::System.Guid b2 = new global::System.Guid(b);
			if (global::Motorola.Common.Communication.AstroCpsSequenceManager.m_SupportedUuids == null)
			{
				this.LoadSupportedUuidList();
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Guid, string> keyValuePair in global::Motorola.Common.Communication.AstroCpsSequenceManager.m_SupportedUuids)
			{
				if (keyValuePair.Key == b2)
				{
					return keyValuePair.Value;
				}
			}
			return string.Empty;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003EE0 File Offset: 0x000020E0
		private uint CodeplugAddress(uint ActiveRegion)
		{
			string psdtSrcSectionId = "NONE";
			string psdtTgtSectionId = "NONE";
			if (ActiveRegion == 2U)
			{
				psdtSrcSectionId = "CPSA";
				psdtTgtSectionId = "CPSA";
			}
			else if (ActiveRegion == 1U)
			{
				psdtSrcSectionId = "CPSB";
				psdtTgtSectionId = "CPSB";
			}
			global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.GetStartAddress, psdtSrcSectionId, psdtTgtSectionId);
			this.RcmpWrapper.SendAndReceiveMessage(xcmpPsdtAccess);
			if (xcmpPsdtAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_IshStatusBad);
			}
			return xcmpPsdtAccess.PsdtAddress;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003F4C File Offset: 0x0000214C
		private int CopyCodeplugCSDToRadio(uint CsdAddress)
		{
			if (CsdAddress < 1U)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			if (CsdAddress > 33554432U)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			byte[] array = new byte[1024];
			array = global::Motorola.Common.Communication.AstroCpsSequenceManager.DdiltMsg;
			byte[] bytes = global::System.BitConverter.GetBytes(CsdAddress);
			array[2] = bytes[3];
			array[3] = bytes[2];
			global::Motorola.Common.Communication.Rcmp.CustomRcmpMessage customRcmpMessage = new global::Motorola.Common.Communication.Rcmp.CustomRcmpMessage(array);
			this.RcmpWrapper.SendAndReceiveMessage(customRcmpMessage);
			byte[] replyBuffer = customRcmpMessage.ReplyBuffer;
			if (replyBuffer[0] == 130 && replyBuffer[7] == array[6] && replyBuffer[8] == array[7])
			{
				return 1;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_IshStatusBad);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003FE4 File Offset: 0x000021E4
		private int CopyRadioSecToInactive(uint RadioActive)
		{
			string psdtSrcSectionId = "SECA";
			string psdtTgtSectionId = "SECB";
			if (RadioActive == 2U)
			{
				psdtSrcSectionId = "SECB";
				psdtTgtSectionId = "SECA";
			}
			global::Motorola.Common.Communication.XcmpPsdtAccess xcmpPsdtAccess = new global::Motorola.Common.Communication.XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction.Copy, psdtSrcSectionId, psdtTgtSectionId);
			this.RcmpWrapper.SendAndReceiveMessage(xcmpPsdtAccess);
			if (xcmpPsdtAccess.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_IshStatusBad);
			}
			return (int)xcmpPsdtAccess.ReplyResult;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000403C File Offset: 0x0000223C
		private static byte[] BuidDDILTMsg()
		{
			string directoryName = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
			string filePath = global::System.IO.Path.Combine(directoryName, "Metadata", "ASTRO", "Mackinaw_DDILT.srec");
			byte[] array;
			using (global::Motorola.Common.Communication.Srecord srecord = new global::Motorola.Common.Communication.Srecord())
			{
				srecord.LoadSrecordData(filePath, global::Motorola.Common.Communication.AstroCpsSequenceManager.DDILT_SIZE_LIMIT, true);
				int num = 0;
				foreach (global::Motorola.Common.Communication.SrecData srecData in srecord.DataRecords)
				{
					num += (int)srecData.DataLen;
				}
				array = new byte[num + global::Motorola.Common.Communication.AstroCpsSequenceManager.DdiltMsgHeader.Length + 2];
				global::System.Array.Copy(global::Motorola.Common.Communication.AstroCpsSequenceManager.DdiltMsgHeader, array, global::Motorola.Common.Communication.AstroCpsSequenceManager.DdiltMsgHeader.Length);
				array[global::Motorola.Common.Communication.AstroCpsSequenceManager.DdiltMsgHeader.Length] = (byte)(num >> 8);
				array[global::Motorola.Common.Communication.AstroCpsSequenceManager.DdiltMsgHeader.Length + 1] = (byte)(num & 255);
				int num2 = global::Motorola.Common.Communication.AstroCpsSequenceManager.DdiltMsgHeader.Length + 2;
				foreach (global::Motorola.Common.Communication.SrecData srecData2 in srecord.DataRecords)
				{
					global::System.Array.Copy(srecData2.GetData(), 0L, array, (long)num2, (long)((ulong)srecData2.DataLen));
					num2 += (int)srecData2.DataLen;
				}
			}
			return array;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000419C File Offset: 0x0000239C
		protected void UpdatePINPasswordBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite)
		{
			try
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
				list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(212, 903, 0));
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = this.IshHandler.ReadIshItems(list, this.ProgressIndicator);
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
				pbaObject.SetCodeplug(codeplug);
				if (!global::Motorola.Common.Communication.CodeplugParseHelper.IsPINPSWBlockExist(pbaToWrite))
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("UpdatePINPasswordBeforeWrite check the block fail, it looks be a differcial Write path", new object[0]);
				}
				else
				{
					string text = global::Motorola.Common.Communication.CodeplugParseHelper.ReadEncryptPassword(pbaToWrite);
					bool flag = global::Motorola.Common.Communication.CodeplugParseHelper.ReadEncryptPasswordFlag(pbaObject);
					if (flag)
					{
						if (!this.IsFirmwareSupport_ESN_Encryption_Decryption())
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("New Security Partition with the old firmware, THIS IS A INVALID RADIO.", new object[0]);
						}
						string plainPwd = global::Motorola.Common.Communication.AESCryptoUtil.AESDecryptWithDefKey(text);
						string encryptedPwd = global::Motorola.Common.Communication.AESCryptoUtil.AESEncrypt(plainPwd, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN);
						global::Motorola.Common.Communication.CodeplugParseHelper.WriteEncryptPassword(pbaToWrite, encryptedPwd);
					}
					else
					{
						string targetPwdHead = string.Empty;
						string targetPwdTail = string.Empty;
						if (text != "000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000")
						{
							string text2 = global::Motorola.Common.Communication.AESCryptoUtil.AESDecryptWithDefKey(text);
							if (text2.Length > 4)
							{
								targetPwdHead = text2.Substring(0, 4);
								targetPwdTail = text2.Substring(4);
							}
							else
							{
								targetPwdHead = text2;
							}
							global::Motorola.Common.Communication.CodeplugParseHelper.WriteClearPassword(pbaToWrite, targetPwdHead, targetPwdTail);
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("UpdatePINPasswordBeforeWrite failed with: {0}", new object[]
				{
					ex.Message
				});
				throw;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000042FC File Offset: 0x000024FC
		protected void UpdatePINPasswordAfterRead(global::Motorola.Common.Communication.Pba.PbaObject pbaForRead)
		{
			try
			{
				string encryptedPwd = global::Motorola.Common.Communication.CodeplugParseHelper.ReadEncryptPassword(pbaForRead);
				bool flag = global::Motorola.Common.Communication.CodeplugParseHelper.ReadEncryptPasswordFlag(pbaForRead);
				if (flag)
				{
					if (global::Motorola.Common.Communication.CodeplugParseHelper.IsPINPSWBlockExist(pbaForRead))
					{
						if (!this.IsFirmwareSupport_ESN_Encryption_Decryption())
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("New Security Partition with the old firmware, THIS IS A INVALID RADIO.", new object[0]);
						}
						string plainPwd = global::Motorola.Common.Communication.AESCryptoUtil.AESDecrypt(encryptedPwd, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN);
						string encryptedPwd2 = global::Motorola.Common.Communication.AESCryptoUtil.AESEncryptWithDefKey(plainPwd);
						global::Motorola.Common.Communication.CodeplugParseHelper.WriteEncryptPassword(pbaForRead, encryptedPwd2);
					}
					else
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Communication_SequenceManager_Astro_Invalid_Encryption_Password_Flag, should fail the job!!", new object[0]);
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("UpdatePINPasswordAfterRead failed with: {0}", new object[]
				{
					ex.Message
				});
				throw;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000043B8 File Offset: 0x000025B8
		protected void UpdateWiFiPasswordBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite)
		{
			try
			{
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateWiFiEncryptPassword(pbaToWrite, global::Motorola.Common.Communication.AESCryptoUtil.CIPHER_DEF_KEY, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("UpdateWiFiPasswordBeforeWrite failed with: {0}", new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Decrypt_WiFi_Password_Fail);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004420 File Offset: 0x00002620
		protected void UpdateWiFiPasswordAfterRead(global::Motorola.Common.Communication.Pba.PbaObject pbaForRead)
		{
			try
			{
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateWiFiEncryptPassword(pbaForRead, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN, global::Motorola.Common.Communication.AESCryptoUtil.CIPHER_DEF_KEY);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("UpdateWiFiPasswordAfterRead failed with: {0}", new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Encrypt_WiFi_Password_Fail);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004488 File Offset: 0x00002688
		protected void UpdateExternalDataModemPasswordBeforeWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaToWrite)
		{
			try
			{
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateExternalDataModemEncryptPassword(pbaToWrite, global::Motorola.Common.Communication.AESCryptoUtil.CIPHER_DEF_KEY, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("UpdateExternalDataModemPasswordBeforeWrite failed with: {0}", new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Decrypt_External_Data_Modem_Password_Fail);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000044F0 File Offset: 0x000026F0
		protected void UpdateExternalDataModemPasswordAfterRead(global::Motorola.Common.Communication.Pba.PbaObject pbaForRead)
		{
			try
			{
				global::Motorola.Common.Communication.CodeplugParseHelper.UpdateExternalDataModemEncryptPassword(pbaForRead, (this.ExtendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo).ESN, global::Motorola.Common.Communication.AESCryptoUtil.CIPHER_DEF_KEY);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("UpdateExternalDataModemPasswordAfterRead failed with: {0}", new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Encrypt_External_Data_Modem_Password_Fail);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004558 File Offset: 0x00002758
		private bool IsFirmwareSupport_ESN_Encryption_Decryption()
		{
			return global::Motorola.Common.Communication.VersionComparator.CompareVersions(this.ExtendedDeviceInfo.SoftwareVersion, "D08.85.00") > 0;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000457F File Offset: 0x0000277F
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004586 File Offset: 0x00002786
		public byte QueryRadioUpdateStatus()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000007 RID: 7
		private const int constCodeplugActiveA = 1;

		// Token: 0x04000008 RID: 8
		private const int constCodeplugActiveB = 2;

		// Token: 0x04000009 RID: 9
		private global::Motorola.Common.Communication.IMessageExecutor m_RcmpWrapper;

		// Token: 0x0400000A RID: 10
		private global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo m_currExDeviceInfo;

		// Token: 0x0400000B RID: 11
		private global::Motorola.Common.Communication.Rcmp.XcmpComponentSession sessionCommandReply;

		// Token: 0x0400000C RID: 12
		private global::Motorola.Common.Communication.CommonUtil.SessionParameter m_SessionParameter;

		// Token: 0x0400000D RID: 13
		private global::Motorola.Common.Communication.RadioParams m_ExtendedRadioParams;

		// Token: 0x0400000E RID: 14
		private global::Motorola.Common.Communication.IshHandler.CommonIshHandler _IshHandler;

		// Token: 0x0400000F RID: 15
		private global::Motorola.Common.Communication.IshHandler.IOController _IOController;

		// Token: 0x04000010 RID: 16
		private int m_MaxTransportPacketSize;

		// Token: 0x04000011 RID: 17
		private static global::System.Collections.Generic.Dictionary<global::System.Guid, string> m_SupportedUuids;

		// Token: 0x04000012 RID: 18
		private static readonly int DDILT_SIZE_LIMIT = 65536;

		// Token: 0x04000013 RID: 19
		private static readonly byte[] DdiltMsgHeader = new byte[]
		{
			2,
			2,
			0,
			158,
			0,
			0
		};

		// Token: 0x04000014 RID: 20
		private static readonly byte[] DdiltMsg = new byte[]
		{
			2,
			2,
			0,
			158,
			0,
			0,
			4,
			44,
			67,
			83,
			68,
			88,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			0,
			0,
			64,
			0,
			byte.MaxValue,
			195,
			161,
			209,
			0,
			0,
			0,
			3,
			82,
			8,
			0,
			17,
			67,
			80,
			71,
			88,
			0,
			0,
			0,
			48,
			85,
			67,
			76,
			88,
			0,
			0,
			3,
			212,
			83,
			69,
			67,
			88,
			0,
			0,
			4,
			32,
			0,
			232,
			byte.MaxValue,
			byte.MaxValue,
			3,
			232,
			4,
			137,
			15,
			159,
			0,
			0,
			15,
			158,
			0,
			0,
			15,
			157,
			0,
			0,
			15,
			156,
			0,
			0,
			15,
			155,
			0,
			0,
			15,
			154,
			0,
			0,
			15,
			153,
			0,
			0,
			15,
			152,
			0,
			0,
			15,
			151,
			0,
			0,
			15,
			150,
			0,
			0,
			15,
			149,
			0,
			0,
			15,
			148,
			0,
			0,
			15,
			147,
			0,
			0,
			15,
			146,
			0,
			0,
			15,
			145,
			0,
			0,
			15,
			144,
			0,
			0,
			15,
			143,
			0,
			0,
			15,
			142,
			0,
			0,
			15,
			141,
			0,
			0,
			15,
			140,
			0,
			0,
			15,
			139,
			0,
			0,
			15,
			138,
			0,
			0,
			15,
			137,
			0,
			0,
			15,
			136,
			0,
			0,
			15,
			135,
			0,
			0,
			15,
			134,
			7,
			209,
			15,
			133,
			7,
			209,
			15,
			132,
			7,
			209,
			15,
			131,
			7,
			209,
			15,
			130,
			7,
			209,
			15,
			129,
			7,
			209,
			15,
			128,
			7,
			209,
			15,
			127,
			7,
			209,
			15,
			109,
			0,
			0,
			15,
			108,
			0,
			0,
			15,
			107,
			0,
			0,
			15,
			106,
			0,
			0,
			15,
			105,
			0,
			0,
			15,
			104,
			0,
			0,
			15,
			103,
			0,
			0,
			15,
			102,
			0,
			0,
			15,
			84,
			0,
			36,
			15,
			83,
			0,
			50,
			15,
			82,
			0,
			byte.MaxValue,
			15,
			81,
			0,
			byte.MaxValue,
			15,
			80,
			0,
			0,
			15,
			79,
			0,
			0,
			15,
			78,
			0,
			0,
			15,
			77,
			0,
			0,
			15,
			76,
			0,
			0,
			15,
			75,
			0,
			0,
			15,
			74,
			0,
			0,
			15,
			73,
			0,
			0,
			15,
			72,
			0,
			0,
			15,
			71,
			0,
			0,
			15,
			70,
			0,
			0,
			15,
			69,
			0,
			0,
			15,
			68,
			0,
			0,
			15,
			67,
			0,
			0,
			15,
			66,
			0,
			0,
			15,
			65,
			0,
			0,
			15,
			64,
			0,
			0,
			15,
			63,
			0,
			3,
			15,
			62,
			0,
			0,
			15,
			61,
			0,
			0,
			15,
			60,
			0,
			0,
			15,
			59,
			0,
			8,
			15,
			58,
			0,
			0,
			15,
			57,
			0,
			0,
			15,
			56,
			0,
			0,
			15,
			55,
			1,
			244,
			15,
			54,
			2,
			158,
			15,
			53,
			0,
			0,
			15,
			52,
			0,
			0,
			15,
			51,
			0,
			0,
			15,
			50,
			0,
			1,
			15,
			49,
			0,
			1,
			15,
			48,
			0,
			5,
			15,
			47,
			0,
			5,
			15,
			46,
			0,
			2,
			15,
			45,
			0,
			5,
			15,
			44,
			0,
			9,
			15,
			43,
			0,
			0,
			15,
			42,
			0,
			4,
			15,
			41,
			0,
			5,
			15,
			40,
			0,
			2,
			15,
			39,
			0,
			6,
			15,
			38,
			0,
			1,
			15,
			37,
			0,
			byte.MaxValue,
			15,
			36,
			1,
			169,
			15,
			35,
			0,
			byte.MaxValue,
			15,
			34,
			0,
			0,
			15,
			33,
			0,
			byte.MaxValue,
			15,
			32,
			0,
			byte.MaxValue,
			15,
			31,
			0,
			0,
			15,
			30,
			0,
			byte.MaxValue,
			15,
			29,
			1,
			149,
			15,
			28,
			0,
			96,
			15,
			27,
			0,
			96,
			15,
			26,
			0,
			0,
			15,
			25,
			0,
			96,
			15,
			24,
			0,
			96,
			15,
			23,
			0,
			96,
			15,
			22,
			0,
			0,
			15,
			21,
			1,
			44,
			15,
			20,
			0,
			0,
			15,
			19,
			0,
			50,
			15,
			18,
			0,
			0,
			15,
			17,
			1,
			244,
			15,
			16,
			1,
			244,
			15,
			15,
			2,
			117,
			15,
			14,
			1,
			244,
			15,
			13,
			0,
			0,
			15,
			12,
			0,
			200,
			15,
			11,
			0,
			200,
			15,
			10,
			0,
			0,
			15,
			9,
			0,
			200,
			15,
			8,
			1,
			144,
			15,
			7,
			0,
			200,
			15,
			6,
			0,
			0,
			15,
			5,
			0,
			200,
			15,
			4,
			0,
			0,
			15,
			3,
			0,
			200,
			15,
			2,
			0,
			0,
			15,
			1,
			0,
			200,
			15,
			0,
			0,
			0,
			14,
			byte.MaxValue,
			0,
			200,
			14,
			254,
			2,
			88,
			14,
			253,
			0,
			200,
			14,
			252,
			0,
			0,
			14,
			251,
			0,
			200,
			14,
			250,
			0,
			0,
			14,
			249,
			0,
			200,
			14,
			248,
			0,
			0,
			14,
			247,
			1,
			44,
			14,
			246,
			1,
			144,
			14,
			245,
			1,
			44,
			14,
			244,
			1,
			214,
			14,
			243,
			1,
			44,
			14,
			242,
			1,
			133,
			14,
			241,
			0,
			byte.MaxValue,
			14,
			240,
			1,
			169,
			14,
			239,
			0,
			1,
			14,
			238,
			1,
			144,
			14,
			237,
			1,
			144,
			14,
			236,
			1,
			144,
			14,
			235,
			1,
			144,
			14,
			234,
			1,
			144,
			14,
			233,
			1,
			144,
			14,
			215,
			0,
			36,
			14,
			214,
			0,
			1,
			14,
			213,
			7,
			208,
			14,
			212,
			10,
			234,
			14,
			211,
			0,
			0,
			14,
			210,
			0,
			0,
			14,
			209,
			0,
			7,
			14,
			208,
			0,
			7,
			14,
			207,
			0,
			7,
			14,
			206,
			0,
			7,
			14,
			205,
			0,
			7,
			14,
			204,
			0,
			7,
			14,
			186,
			0,
			0,
			14,
			185,
			0,
			1,
			14,
			184,
			0,
			1,
			14,
			183,
			0,
			0,
			14,
			182,
			0,
			0,
			14,
			181,
			0,
			9,
			14,
			180,
			0,
			0,
			14,
			179,
			0,
			0,
			14,
			178,
			0,
			10,
			14,
			177,
			0,
			0,
			14,
			176,
			0,
			0,
			14,
			175,
			0,
			0,
			14,
			174,
			0,
			0,
			14,
			173,
			0,
			0,
			14,
			172,
			0,
			0,
			14,
			171,
			0,
			0,
			14,
			170,
			0,
			0,
			14,
			152,
			0,
			50,
			14,
			151,
			0,
			0,
			14,
			150,
			0,
			50,
			14,
			149,
			0,
			0,
			14,
			148,
			0,
			1,
			14,
			146,
			0,
			50,
			14,
			145,
			0,
			16,
			14,
			144,
			0,
			0,
			14,
			143,
			0,
			0,
			14,
			142,
			0,
			0,
			14,
			141,
			0,
			0,
			14,
			140,
			0,
			0,
			14,
			139,
			0,
			0,
			14,
			138,
			0,
			0,
			14,
			137,
			0,
			0,
			14,
			136,
			0,
			0,
			14,
			135,
			0,
			0,
			14,
			134,
			0,
			0,
			14,
			133,
			0,
			0,
			14,
			132,
			0,
			0,
			14,
			131,
			0,
			0,
			14,
			130,
			0,
			0,
			14,
			129,
			0,
			0,
			14,
			128,
			0,
			30,
			14,
			127,
			0,
			0,
			14,
			126,
			0,
			0,
			14,
			125,
			0,
			0,
			14,
			124,
			0,
			0,
			14,
			123,
			0,
			0,
			14,
			122,
			0,
			0,
			14,
			121,
			0,
			0,
			14,
			120,
			0,
			0,
			14,
			119,
			0,
			0,
			14,
			118,
			0,
			0,
			14,
			117,
			0,
			0,
			14,
			116,
			2,
			243,
			14,
			115,
			0,
			13,
			14,
			114,
			0,
			0,
			14,
			113,
			0,
			50,
			14,
			112,
			0,
			0,
			14,
			111,
			0,
			0,
			14,
			110,
			0,
			4,
			14,
			109,
			0,
			0,
			14,
			108,
			0,
			4,
			14,
			107,
			0,
			0,
			14,
			106,
			0,
			0,
			14,
			105,
			0,
			byte.MaxValue,
			14,
			104,
			0,
			0,
			14,
			103,
			0,
			byte.MaxValue,
			14,
			102,
			0,
			0,
			14,
			98,
			0,
			5,
			14,
			99,
			0,
			50,
			14,
			91,
			0,
			0,
			0,
			18,
			byte.MaxValue,
			byte.MaxValue,
			0,
			0,
			0,
			0,
			19,
			135,
			39,
			17,
			19,
			134,
			39,
			17,
			19,
			133,
			39,
			17,
			19,
			132,
			39,
			17,
			19,
			131,
			39,
			17,
			19,
			130,
			39,
			17,
			19,
			129,
			39,
			17,
			19,
			128,
			39,
			17,
			19,
			110,
			39,
			17,
			19,
			109,
			39,
			17,
			19,
			108,
			39,
			17,
			19,
			107,
			39,
			17,
			19,
			106,
			39,
			17,
			19,
			105,
			39,
			17,
			19,
			104,
			39,
			17,
			19,
			103,
			39,
			17,
			19,
			85,
			0,
			10,
			0,
			2,
			byte.MaxValue,
			byte.MaxValue,
			3,
			132,
			3,
			135,
			3,
			231,
			0,
			10
		};

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000071 RID: 113
		private delegate void ProgressCallback(double progress);
	}
}
