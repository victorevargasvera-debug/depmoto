using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002A RID: 42
	public class PcrProvisioningSequenceManager : global::Motorola.Common.Communication.ICpsSequenceManager, global::Motorola.Common.Communication.IDepotSequenceManager
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000AD2C File Offset: 0x00008F2C
		protected global::Motorola.Common.Communication.IMessageExecutor Executor
		{
			get
			{
				return this.executor;
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000AD44 File Offset: 0x00008F44
		public PcrProvisioningSequenceManager(global::Motorola.Common.Communication.IMessageExecutor executor)
		{
			this.executor = executor;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000AD58 File Offset: 0x00008F58
		public virtual bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			return true;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000AD6C File Offset: 0x00008F6C
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0000AD83 File Offset: 0x00008F83
		public global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000AD8C File Offset: 0x00008F8C
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000ADA3 File Offset: 0x00008FA3
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000ADAC File Offset: 0x00008FAC
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000ADC3 File Offset: 0x00008FC3
		public bool DifferentialWriteCapableRadio { get; set; }

		// Token: 0x06000120 RID: 288 RVA: 0x0000ADCC File Offset: 0x00008FCC
		public bool DifferentialWriteSupported(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			return true;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000ADDF File Offset: 0x00008FDF
		public void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000ADE2 File Offset: 0x00008FE2
		public void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		public virtual global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			try
			{
				global::Motorola.Common.Communication.HttpProvGetCfs httpProvGetCfs = new global::Motorola.Common.Communication.HttpProvGetCfs();
				this.executor.SendAndReceiveMessage(httpProvGetCfs);
				pbaObject.CSAReadData = new global::Motorola.Common.Communication.Pba.CSAReadData();
				pbaObject.CSAReadData.CFSHardwareId = httpProvGetCfs.CFSHardwareID;
				if (string.IsNullOrWhiteSpace(httpProvGetCfs.CFSHardwareID) || string.Equals(httpProvGetCfs.CFSHardwareID, "0", global::System.StringComparison.Ordinal))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Provisioning_InvalidCFSHardwareID);
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				this.TryHandleBaseSocketException(ex);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Unexpected error while reading CMSS: {0}", new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Provisioning_ReadFailed, ex);
			}
			return pbaObject;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000AEC8 File Offset: 0x000090C8
		private void SendProvFile(global::Motorola.Common.Communication.Pba.FileSet fs)
		{
			if (fs != null && fs.FileItemsList != null)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> fileItemsList = fs.FileItemsList;
				int num = 2;
				bool flag = false;
				int millisecondsTimeout = 5000;
				while (!flag && num >= 0)
				{
					try
					{
						global::System.Collections.Generic.Dictionary<string, global::System.IO.Stream> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.IO.Stream>();
						foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem in fileItemsList)
						{
							dictionary.Add(fileItem.Name, new global::System.IO.MemoryStream(fileItem.FileContent));
						}
						if (dictionary.Count > 0)
						{
							global::Motorola.Common.Communication.HttpProvUploadConfig msg = new global::Motorola.Common.Communication.HttpProvUploadConfig(dictionary);
							this.executor.SendAndReceiveMessage(msg);
						}
						flag = true;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.CustomException.CommonException ex2 = ex as global::Motorola.Common.CustomException.CommonException;
						if (ex2 == null)
						{
							this.TryHandleBaseSocketException(ex);
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Unexpected error during provisioning {0}: {1}\n{2}", new object[]
							{
								fs.Name,
								ex.Message,
								ex.GetBaseException().Message
							});
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Provisioning_WriteFailed, ex);
						}
						switch (ex2.ErrorCode)
						{
						case global::Motorola.Common.CustomException.CommonErrorCode.HttpProvConfigFileRejected:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("CMSS rejected configuration \"{0}\".", new object[]
							{
								fs.Name
							});
							throw;
						case global::Motorola.Common.CustomException.CommonErrorCode.HttpProvConfigServiceBusy:
							if (num <= 0)
							{
								throw;
							}
							break;
						case global::Motorola.Common.CustomException.CommonErrorCode.Http_LICENSE_TC_FAILURE:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("CMSS license Operation failed with configuration \"{0}\".", new object[]
							{
								fs.Name
							});
							throw;
						case global::Motorola.Common.CustomException.CommonErrorCode.Http_CONFIG_TC_FAILURE:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("CMSS config update failed with configuration \"{0}\".", new object[]
							{
								fs.Name
							});
							throw;
						case global::Motorola.Common.CustomException.CommonErrorCode.Http_CONNECT_TC_FAILURE:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Connect to CMSS failure with configuration \"{0}\".", new object[]
							{
								fs.Name
							});
							throw;
						case global::Motorola.Common.CustomException.CommonErrorCode.Http_LICENSE_MNIS_FAILURE:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("MNIS license operation failed with configuration \"{0}\".", new object[]
							{
								fs.Name
							});
							throw;
						case global::Motorola.Common.CustomException.CommonErrorCode.Http_CONFIG_MNIS_FAILURE:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("MNIS config update failed with configuration \"{0}\".", new object[]
							{
								fs.Name
							});
							throw;
						case global::Motorola.Common.CustomException.CommonErrorCode.Http_LICENSE_UEM_FAILURE:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("UEM license operation failed with configuration \"{0}\".", new object[]
							{
								fs.Name
							});
							throw;
						case global::Motorola.Common.CustomException.CommonErrorCode.Http_CONFIG_UEM_FAILURE:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("UEM config update failed (FUTURE) with configuration \"{0}\".", new object[]
							{
								fs.Name
							});
							throw;
						case global::Motorola.Common.CustomException.CommonErrorCode.Http_IP_CHANGE_FAILURE:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("IP address change failed with configuration \"{0}\".", new object[]
							{
								fs.Name
							});
							throw;
						case global::Motorola.Common.CustomException.CommonErrorCode.Http_NTP_CHANGE_FAILURE:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("NTP address change failure with configuration \"{0}\".", new object[]
							{
								fs.Name
							});
							throw;
						default:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Unexpected error while provisioning \"{0}\": {1}", new object[]
							{
								fs.Name,
								ex.Message
							});
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Provisioning_WriteFailed, ex);
						}
					}
					if (!flag && num > 0)
					{
						global::System.Threading.Thread.Sleep(millisecondsTimeout);
					}
					num--;
				}
				if (!flag)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Provisioning_WriteFailed, "Failed provisioning after retries.");
				}
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000B2A8 File Offset: 0x000094A8
		public virtual global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID, string pcrNewPassword)
		{
			global::Motorola.Common.Communication.Pba.PbaObject result;
			if (pbaObject.FileSetList == null)
			{
				result = pbaObject;
			}
			else
			{
				global::Motorola.Common.Communication.Pba.FileSet fileSet = null;
				foreach (global::Motorola.Common.Communication.Pba.FileSet fileSet2 in pbaObject.FileSetList)
				{
					if (this.IsFileSetSupported(fileSet2))
					{
						if (fileSet2.Name == "PCRIPProvFileSet")
						{
							fileSet = fileSet2;
						}
						else
						{
							this.SendProvFile(fileSet2);
						}
					}
				}
				if (fileSet != null)
				{
					this.SendProvFile(fileSet);
				}
				result = pbaObject;
			}
			return result;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000B360 File Offset: 0x00009560
		private bool IsFileSetSupported(global::Motorola.Common.Communication.Pba.FileSet fs)
		{
			string name = fs.Name;
			if (name != null)
			{
				if (name == "PCRIPProvFileSet" || name == "PCRMNISProvFileSet" || name == "PCRTCProvFileSet" || name == "PCRLicenceFileSet")
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000B448 File Offset: 0x00009648
		private bool ValidateSoftwareVersion(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo = pbaObject.ValidationInfos.FirstOrDefault((global::Motorola.Common.Communication.Pba.ValidationInfo f) => f.ID.Equals("TcVersion", global::System.StringComparison.Ordinal));
			global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo2 = pbaObject.ValidationInfos.FirstOrDefault((global::Motorola.Common.Communication.Pba.ValidationInfo f) => f.ID.Equals("configSchemaVersion", global::System.StringComparison.Ordinal));
			global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo3 = pbaObject.ValidationInfos.FirstOrDefault((global::Motorola.Common.Communication.Pba.ValidationInfo f) => f.ID.Equals("SACSchemaVersion", global::System.StringComparison.Ordinal));
			global::Motorola.Common.Communication.Pba.ValidationInfo validationInfo4 = pbaObject.ValidationInfos.FirstOrDefault((global::Motorola.Common.Communication.Pba.ValidationInfo f) => f.ID.Equals("TGSchemaVersion", global::System.StringComparison.Ordinal));
			global::Motorola.Common.Communication.HttpProvGetVersion httpProvGetVersion = new global::Motorola.Common.Communication.HttpProvGetVersion();
			this.executor.SendAndReceiveMessage(httpProvGetVersion);
			global::Motorola.Common.Communication.ProvVersion versionData = httpProvGetVersion.VersionData;
			return (validationInfo == null || string.Equals(validationInfo.Value, versionData.TcVersion, global::System.StringComparison.OrdinalIgnoreCase)) && (validationInfo2 == null || string.Equals(validationInfo2.Value, versionData.configSchemaVersion, global::System.StringComparison.OrdinalIgnoreCase)) && (validationInfo3 == null || string.Equals(validationInfo3.Value, versionData.SACSchemaVersion, global::System.StringComparison.OrdinalIgnoreCase)) && (validationInfo4 == null || string.Equals(validationInfo4.Value, versionData.TGSchemaVersion, global::System.StringComparison.OrdinalIgnoreCase));
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000B59C File Offset: 0x0000979C
		protected virtual void ReadBasicInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			try
			{
				global::Motorola.Common.Communication.HttpProvGetSerialNumber httpProvGetSerialNumber = new global::Motorola.Common.Communication.HttpProvGetSerialNumber();
				this.executor.SendAndReceiveMessage(httpProvGetSerialNumber);
				devInfo.SerialNumber = httpProvGetSerialNumber.SerialNumber;
			}
			catch (global::System.Exception ex)
			{
				this.TryHandleBaseSocketException(ex);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Unexpected error while reading CMSS device info: {0}", new object[]
				{
					ex.Message
				});
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Provisioning_ReadInfoFailed);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000B618 File Offset: 0x00009818
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = new global::Motorola.Common.Communication.CommonUtil.DeviceInfo();
			this.ReadBasicInfo(deviceInfo);
			return deviceInfo;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000B639 File Offset: 0x00009839
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo(string psw)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000B644 File Offset: 0x00009844
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo pcrdeviceInfo = new global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo();
			this.ReadBasicInfo(pcrdeviceInfo);
			return pcrdeviceInfo;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000B665 File Offset: 0x00009865
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000B66D File Offset: 0x0000986D
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000B675 File Offset: 0x00009875
		public void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000B67D File Offset: 0x0000987D
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000B685 File Offset: 0x00009885
		public void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000B68D File Offset: 0x0000988D
		public void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000B695 File Offset: 0x00009895
		public void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000B69D File Offset: 0x0000989D
		public void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000B6A5 File Offset: 0x000098A5
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000B6B0 File Offset: 0x000098B0
		private void TryHandleBaseSocketException(global::System.Exception ex)
		{
			global::System.Exception baseException = ex.GetBaseException();
			if (baseException is global::System.Net.Sockets.SocketException)
			{
				global::System.Net.Sockets.SocketException ex2 = (global::System.Net.Sockets.SocketException)baseException;
				switch (ex2.SocketErrorCode)
				{
				case global::System.Net.Sockets.SocketError.TimedOut:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Provisioning_CannotConnectToDevice, ex);
				case global::System.Net.Sockets.SocketError.ConnectionRefused:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Provisioning_CannotConnectToConfigurationService, ex);
				}
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000B715 File Offset: 0x00009915
		public void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000B71D File Offset: 0x0000991D
		public void UpdateSerialNumber(string serialNumber)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000B725 File Offset: 0x00009925
		public void UnkillRadio(byte[] authenticationValue)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000B72D File Offset: 0x0000992D
		public byte[] ReadUnkillChallengeValue()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000B735 File Offset: 0x00009935
		public void CBIProgramme()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000B73D File Offset: 0x0000993D
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000B745 File Offset: 0x00009945
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000B74D File Offset: 0x0000994D
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000B755 File Offset: 0x00009955
		public void UpdateMACAddress(byte[] macAddress)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000B75D File Offset: 0x0000995D
		public void UpdateIMEType(byte ime)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000B765 File Offset: 0x00009965
		public void UpdateDateCode(byte[] datecode, ushort source)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000B76D File Offset: 0x0000996D
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000B775 File Offset: 0x00009975
		public byte QueryRadioUpdateStatus()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040000A5 RID: 165
		private global::Motorola.Common.Communication.IMessageExecutor executor;
	}
}
