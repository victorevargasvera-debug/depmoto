using System;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.SequenceManager;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200004C RID: 76
	public class GemstoneBMPRadioFactory : global::Motorola.Common.Communication.CommunicationManager.SingleRadioFactory
	{
		// Token: 0x060001AF RID: 431 RVA: 0x000081A8 File Offset: 0x000063A8
		public GemstoneBMPRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer)
		{
			this._observer = observer;
			base.PIDList = new string[]
			{
				"9003",
				"9010",
				"9012",
				"9013"
			};
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000081F0 File Offset: 0x000063F0
		protected override bool MyCreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			radio = null;
			bool result = false;
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("GemstoneBMPRadioFactory.MyCreateRadio: The hwProfile is empty");
				return false;
			}
			if (!(hwProfile is global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile))
			{
				return false;
			}
			if (hwProfile.PID.Equals("9003", global::System.StringComparison.InvariantCultureIgnoreCase) && (ulong)(hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).USBDataEPMaxTransSize != (ulong)((long)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FUK_MAX_DATA_TRANS_SIZE))
			{
				return false;
			}
			try
			{
				global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice tetraVComDevice = this.newOneTetraVComDevice();
				tetraVComDevice.DeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM;
				if (hwProfile.PID.Contains("9013") || hwProfile.PID.Contains("9012"))
				{
					tetraVComDevice.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.GemstoneBMPAppRadio;
				}
				else
				{
					tetraVComDevice.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.GemstoneBMPProgRadio;
				}
				global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility radioCreatorUtility = new global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility();
				bool flag = radioCreatorUtility.CreateSingleGemstoneBMPRadio(tetraVComDevice, hwProfile);
				if (flag)
				{
					tetraVComDevice.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Attached);
					tetraVComDevice.Profile = hwProfile;
					string cpuID = tetraVComDevice.CpuID;
					if (string.IsNullOrEmpty(cpuID))
					{
						tetraVComDevice.DeviceInfo.RadioID = hwProfile.PhysicalLocation;
						hwProfile.RadioId = global::System.Text.Encoding.ASCII.GetBytes(hwProfile.PhysicalLocation);
					}
					else
					{
						tetraVComDevice.DeviceInfo.RadioID = tetraVComDevice.CpuID;
						hwProfile.RadioId = global::System.Text.Encoding.ASCII.GetBytes(tetraVComDevice.CpuID);
					}
					radio = tetraVComDevice;
				}
				else
				{
					radio = null;
				}
				if (radio != null && global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active)
				{
					radio.SynPrepareDevice();
				}
				result = (radio != null);
			}
			catch (global::System.Exception e)
			{
				radio = null;
				result = false;
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "GemstoneBMPRadioFactory.CreateRadio: Got exception");
			}
			return result;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000839C File Offset: 0x0000659C
		public bool GetCpuIdViaATCommand(global::Motorola.Common.Communication.IRadioProfile hwProfile, out string cpuID)
		{
			bool flag = true;
			cpuID = string.Empty;
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = null;
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetCpuIdViaATCommand: hwProfile is null");
				flag = false;
			}
			if (flag && !hwProfile.PID.Contains("9013") && !hwProfile.PID.Contains("9012"))
			{
				flag = false;
			}
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = new global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo();
			this.InitDeviceInfo(deviceInfo, hwProfile);
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = global::Motorola.Common.Communication.CommunicationManager.CommunicationPipeFactory.CreateCommunicationPipe(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any);
			if (communicationPipe == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetCpuIdViaATCommand: can't create communication pipe");
				flag = false;
			}
			if (flag)
			{
				tetraCommPipe = (communicationPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe);
				if (!tetraCommPipe.OpenPort())
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.GetCpuIdViaATCommand: Failed to open the transport");
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetCpuIdViaATCommand: Failed to open the transport : {0}", new object[]
					{
						tetraRadioProfile.Path
					});
					flag = false;
				}
			}
			if (flag)
			{
				global::Motorola.Common.Communication.CommonUtil.RadioManuInfo radioManuInfo = null;
				if (this.ATGetRadioInfo(out radioManuInfo, communicationPipe) == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					cpuID = radioManuInfo.cpuID;
				}
				else
				{
					flag = false;
				}
			}
			tetraCommPipe.ClosePort();
			return flag;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000084BC File Offset: 0x000066BC
		private bool GetCpuIdViaSbepCommand(global::Motorola.Common.Communication.IRadioProfile hwProfile, out string cpuID)
		{
			bool flag = true;
			cpuID = string.Empty;
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = null;
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetCpuIdViaATCommand: hwProfile is null");
				flag = false;
			}
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = new global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo();
			this.InitDeviceInfo(deviceInfo, hwProfile);
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = global::Motorola.Common.Communication.CommunicationManager.CommunicationPipeFactory.CreateCommunicationPipe(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any);
			if (communicationPipe == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetCpuIdViaATCommand: can't create communication pipe");
				flag = false;
			}
			if (flag)
			{
				tetraCommPipe = (communicationPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe);
				if (!tetraCommPipe.OpenPort())
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.GetCpuIdViaATCommand: Failed to open the transport");
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetCpuIdViaATCommand: Failed to open the transport : {0}", new object[]
					{
						tetraRadioProfile.Path
					});
					flag = false;
				}
			}
			if (flag)
			{
				cpuID = this.GetCpuID(communicationPipe);
				if (string.IsNullOrEmpty(cpuID))
				{
					flag = false;
				}
			}
			tetraCommPipe.ClosePort();
			return flag;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000085A8 File Offset: 0x000067A8
		private string GetCpuID(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe pipe)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			string result = string.Empty;
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess && pipe == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				global::Motorola.Common.Communication.SBEPGetUID sbepgetUID = new global::Motorola.Common.Communication.SBEPGetUID(pipe);
				sbepgetUID.ExecuteMessage();
				if (global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(sbepgetUID.OperationResult) == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
				{
					if (sbepgetUID.UID.Length > 0)
					{
						byte[] array = new byte[sbepgetUID.UID.Length];
						global::System.Array.Copy(sbepgetUID.UID, array, sbepgetUID.UID.Length);
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
						foreach (byte b in array)
						{
							stringBuilder.AppendFormat("{0:X2}", b);
						}
						result = stringBuilder.ToString();
					}
				}
			}
			return result;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000865C File Offset: 0x0000685C
		private void InitDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.IRadioProfile profile)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo tetraDeviceInfo = devInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
			tetraDeviceInfo.ConnectionInfo.Location = tetraRadioProfile.Path;
			tetraDeviceInfo.Location = tetraRadioProfile.PhysicalLocation;
			tetraDeviceInfo.UsbHubInstance = tetraRadioProfile.USBHubInstance;
			tetraDeviceInfo.UsbHubPortNumber = tetraRadioProfile.USBHubPortNumber;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000086AC File Offset: 0x000068AC
		private global::Motorola.Common.Communication.CommonUtil.CommRC ATGetRadioInfo(out global::Motorola.Common.Communication.CommonUtil.RadioManuInfo radioInfo, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe pipe)
		{
			global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			radioInfo = null;
			if (pipe == null)
			{
				commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
			}
			if (commRC == global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess)
			{
				using (global::Motorola.Common.Communication.ATGetRadioInfo atgetRadioInfo = new global::Motorola.Common.Communication.ATGetRadioInfo(pipe))
				{
					atgetRadioInfo.ExecuteMessage();
					commRC = global::Motorola.Common.Communication.TetraUtility.SbepOpResultToCommRC.Covert(atgetRadioInfo.OperationResult);
					radioInfo = atgetRadioInfo.RadioInfo;
				}
			}
			return commRC;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00008704 File Offset: 0x00006904
		private global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice newOneTetraVComDevice()
		{
			return new global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice();
		}

		// Token: 0x04000057 RID: 87
		private global::Motorola.Common.Communication.CommonUtil.IObserver _observer;
	}
}
