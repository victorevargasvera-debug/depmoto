using System;
using System.IO;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200003A RID: 58
	internal class DeviceInfoFetcher
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x00010908 File Offset: 0x0000EB08
		public DeviceInfoFetcher(global::Motorola.Common.Communication.IshHandler.IRadioCommand ioController, global::Motorola.Common.Communication.SequenceManager.PcrProductFamily productFamily)
		{
			this.IOController = ioController;
			this.productFamily = productFamily;
			this.ModelNumber = this.IOController.QueryRadioModelNumber();
			string text = this.IOController.QuerySecurityVersion();
			char[] trimChars = new char[1];
			this.CodeplugVersion = text.TrimEnd(trimChars);
			this.deviceType = this.productFamily.GetDeviceType(this.ModelNumber);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00010974 File Offset: 0x0000EB74
		public DeviceInfoFetcher(global::Motorola.Common.Communication.IshHandler.IRadioCommand ioController, global::Motorola.Common.Communication.SequenceManager.PcrProductFamily productFamily, string modelNumber, string codeplugVersion)
		{
			this.IOController = ioController;
			this.productFamily = productFamily;
			this.ModelNumber = modelNumber;
			this.CodeplugVersion = codeplugVersion;
			this.deviceType = this.productFamily.GetDeviceType(this.ModelNumber);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000109C0 File Offset: 0x0000EBC0
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x000109D7 File Offset: 0x0000EBD7
		public string ModelNumber { get; private set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000109E0 File Offset: 0x0000EBE0
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x000109F7 File Offset: 0x0000EBF7
		public string CodeplugVersion { get; private set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00010A00 File Offset: 0x0000EC00
		public global::Motorola.Common.Communication.CommonUtil.ProductFamily ProductFamily
		{
			get
			{
				global::Motorola.Common.Communication.CommonUtil.ProductFamily productFamily = this.productFamily.Family;
				if (this.IsMatrixRepeater() && productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRadio)
				{
					productFamily = global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRepeaterRadio;
				}
				return productFamily;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00010A3C File Offset: 0x0000EC3C
		private bool IsMatrixRepeater()
		{
			return this.deviceType == global::Motorola.Common.Communication.SequenceManager.DeviceType.BanditRepeater || this.deviceType == global::Motorola.Common.Communication.SequenceManager.DeviceType.Repeater;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00010A6C File Offset: 0x0000EC6C
		public T GetDeviceInfo<T>(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField infoField)
		{
			T result;
			if (this.productFamily.IsInfoSupported(infoField, this.deviceType, this.CodeplugVersion))
			{
				result = (T)((object)this.FetchDeviceInfo(infoField));
			}
			else
			{
				result = default(T);
			}
			return result;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00010AB8 File Offset: 0x0000ECB8
		public byte QueryRadioUpdateStatus()
		{
			return this.IOController.QueryRadioUpdateStatus();
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		public bool IsInfoSupported(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField infoField)
		{
			return this.productFamily.IsInfoSupported(infoField, this.deviceType, this.CodeplugVersion);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00010B04 File Offset: 0x0000ED04
		private object FetchDeviceInfo(global::Motorola.Common.Communication.SequenceManager.DeviceInfoField infoField)
		{
			bool flag = this.IsMatrixRepeater();
			object result = null;
			switch (infoField)
			{
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.SerialNumber:
				if (this.productFamily.IsBahamaModel(this.productFamily.UUID))
				{
					flag = false;
				}
				if (flag)
				{
					string @string = global::System.Text.Encoding.ASCII.GetString(this.IOController.QueryProductSerialNumber());
					char[] trimChars = new char[1];
					result = @string.TrimEnd(trimChars);
				}
				else
				{
					string string2 = global::System.Text.Encoding.ASCII.GetString(this.IOController.QueryRadioSerialNumber());
					char[] trimChars = new char[1];
					result = string2.TrimEnd(trimChars);
				}
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.Is32MPlatform:
				result = this.IOController.Is32MPlatform();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.MacAddress:
				result = this.IOController.QueryRepeaterMacAddress();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.AvailableLPSpace:
				result = (int)this.IOController.GetAvailabeSpaceForLanguagePack();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.AvailableMemory:
				result = (int)this.IOController.QueryRadioAvailableMemory();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.Region:
				result = this.IOController.QueryRadioRegion();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.FpgaInfo:
			{
				global::Motorola.Common.Communication.CommonUtil.FpgaInfo fpgaInfo = new global::Motorola.Common.Communication.CommonUtil.FpgaInfo();
				try
				{
					fpgaInfo.FPGAControllerStatus = this.IOController.QueryFPGAControllerStatus();
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Query FPGA QueryFPGAControllerStatus Failure {0}", new object[]
					{
						ex.ToString()
					});
					fpgaInfo = null;
				}
				if (fpgaInfo != null)
				{
					fpgaInfo.FPGAControllerAlternativeVersion = this.IOController.QueryFPGAControllerAlternativeVersion();
					fpgaInfo.FPGAControllerFactoryVersion = this.IOController.QueryFPGAControllerFactoryVersion();
					fpgaInfo.FPGAControllerActiveVersion = this.IOController.QueryFPGAControllerActiveVersion();
					try
					{
						fpgaInfo.IsWirelineAvailable = this.IOController.IsWirelineAvailable();
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Query FPGA IsWirelineAvailable Failure {0}", new object[]
						{
							ex2.ToString()
						});
						fpgaInfo.IsWirelineAvailable = false;
					}
					if (fpgaInfo.IsWirelineAvailable)
					{
						try
						{
							fpgaInfo.FPGAWirelineStatus = this.IOController.QueryFPGAWirelineStatus();
						}
						catch (global::System.Exception ex2)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Query FPGA FPGAWirelineStatus Failure {0}", new object[]
							{
								ex2.ToString()
							});
							fpgaInfo.FPGAWirelineStatus = global::Motorola.Common.Communication.CommonUtil.FPGAStatus.Empty;
						}
						fpgaInfo.FPGAWirelineAlternativeVersion = this.IOController.QueryFPGAWirelineAlternativeVersion();
						fpgaInfo.FPGAWirelineFactoryVersion = this.IOController.QueryFPGAWirelineFactoryVersion();
						fpgaInfo.FPGAWirelineActiveVersion = this.IOController.QueryFPGAWirelineActiveVersion();
					}
					else
					{
						fpgaInfo.FPGAWirelineStatus = global::Motorola.Common.Communication.CommonUtil.FPGAStatus.Empty;
					}
				}
				result = fpgaInfo;
				break;
			}
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.LanguagePackInfo:
				result = this.IOController.ReadLanguagePackInfo();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.LanguagePackData:
				result = this.IOController.ReadLanguagePackData();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.TTSLanguagePackInfo:
				result = this.IOController.ReadTTSLanguagePackInfo();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.TTSLanguagePackData:
				result = this.IOController.ReadTTSLanguagePackData();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.IsLowBattery:
				result = this.IOController.IsLowBattery();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.BootloaderVersion:
			{
				string text = this.IOController.QueryBootloaderVersion();
				char[] trimChars = new char[1];
				result = text.TrimEnd(trimChars);
				break;
			}
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.WelcomeBitmap:
			{
				string key = global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.WelcomeBitmap.ToString();
				if (this.productFamily.ReadFiles != null && this.productFamily.ReadFiles.ContainsKey(key))
				{
					global::Motorola.Common.Communication.Pba.FileItem fileItem = this.productFamily.ReadFiles[key];
					global::Motorola.Common.Communication.Pba.FileItem fileItem2 = new global::Motorola.Common.Communication.Pba.FileItem(fileItem.PartionID, fileItem.FilePath, 0, null, null, null);
					try
					{
						using (global::System.IO.MemoryStream memoryStream = this.IOController.FileRead(fileItem2.PartionID, fileItem2.FilePath, null))
						{
							fileItem2.FileContent = memoryStream.ToArray();
							fileItem2.FileSize = (int)memoryStream.Length;
						}
						result = fileItem2;
					}
					catch (global::Motorola.Common.CustomException.CommonException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.FileAccessFailure)
						{
							throw;
						}
						result = null;
					}
				}
				else
				{
					result = null;
				}
				break;
			}
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.L3BootloaderVersion:
			{
				string text2 = this.IOController.QueryL3BootloaderVersion();
				char[] trimChars = new char[1];
				result = text2.TrimEnd(trimChars);
				break;
			}
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.ConfigurationVersion:
			{
				string text3 = this.IOController.QueryConfigurationVersion();
				char[] trimChars = new char[1];
				result = text3.TrimEnd(trimChars);
				break;
			}
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.KernelVersion:
			{
				string text4 = this.IOController.QueryKernelVersion();
				char[] trimChars = new char[1];
				result = text4.TrimEnd(trimChars);
				break;
			}
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.IsDualBoard:
				if (flag && this.productFamily.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio)
				{
					result = this.IOController.IsDualBoard();
				}
				else
				{
					result = false;
				}
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.RemoteSerialNumber:
			{
				string string3 = global::System.Text.Encoding.ASCII.GetString(this.IOController.QueryRemoteSerialNumber());
				char[] trimChars = new char[1];
				result = string3.TrimEnd(trimChars);
				break;
			}
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.DSPCapability:
				result = this.IOController.IsDspCapabilityEnabled();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.PasswordStatus:
				result = this.IOController.QueryPasswordStatus();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.DTPCapability:
				result = this.IOController.IsDTPCapabilityEnabled();
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.MacAddressPort1:
				result = this.IOController.GetMacAddressByPort(global::Motorola.Common.Communication.Rcmp.MacAddressPort.PORT1);
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.MacAddressPort2:
				result = this.IOController.GetMacAddressByPort(global::Motorola.Common.Communication.Rcmp.MacAddressPort.PORT2);
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.MacAddressWIFIPort1:
				result = this.IOController.GetWLANMacAddress(global::Motorola.Common.Communication.Rcmp.MacAddressPort.PORT1);
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.MacAddressWIFIPort2:
				result = this.IOController.GetWLANMacAddress(global::Motorola.Common.Communication.Rcmp.MacAddressPort.PORT2);
				break;
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.PhysicalSerialNumber:
			{
				byte[] array = this.IOController.QueryRadioPhysicalSerialNumber();
				if (array != null)
				{
					result = global::System.BitConverter.ToString(this.IOController.QueryRadioPhysicalSerialNumber()).Replace("-", "");
				}
				else
				{
					result = null;
				}
				break;
			}
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.BrickRXSerialNumber:
			case global::Motorola.Common.Communication.SequenceManager.DeviceInfoField.BrickTXSerialNumber:
			{
				string string4 = global::System.Text.Encoding.ASCII.GetString(this.IOController.QueryRadioSerialNumber());
				char[] trimChars = new char[1];
				result = string4.TrimEnd(trimChars);
				break;
			}
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00011170 File Offset: 0x0000F370
		public bool FetchTuningVersionForParadise(string filePath, out string ver)
		{
			ver = string.Empty;
			int num = 17;
			int num2 = 3;
			bool result;
			if (this.ProductFamily != global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio || string.IsNullOrEmpty(filePath))
			{
				result = false;
			}
			else
			{
				try
				{
					using (global::System.IO.MemoryStream memoryStream = this.IOController.FileRead(0, filePath, null))
					{
						byte[] array = memoryStream.ToArray();
						if (array.Length > num + num2)
						{
							for (int i = num; i < num + num2; i++)
							{
								ver += global::System.Convert.ToString(array[i], 16).PadLeft(2, '0');
							}
						}
					}
				}
				catch
				{
					return false;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x04000103 RID: 259
		private global::Motorola.Common.Communication.SequenceManager.PcrProductFamily productFamily;

		// Token: 0x04000104 RID: 260
		private global::Motorola.Common.Communication.IshHandler.IRadioCommand IOController;

		// Token: 0x04000105 RID: 261
		private global::Motorola.Common.Communication.SequenceManager.DeviceType deviceType;
	}
}
