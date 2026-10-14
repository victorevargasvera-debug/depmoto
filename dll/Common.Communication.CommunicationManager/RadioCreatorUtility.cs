using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.SequenceManager;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000056 RID: 86
	public class RadioCreatorUtility
	{
		// Token: 0x060001DB RID: 475 RVA: 0x000097C8 File Offset: 0x000079C8
		public bool CreateSingleLegacyRadio(global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile, bool bCHRadio, ref global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState state, out bool bStandaloneCH)
		{
			bStandaloneCH = false;
			if (radio == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleLegacyRadio: radio instance is null");
				return false;
			}
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleLegacyRadio: hwProfile is null");
				return false;
			}
			bool flag = false;
			bool flag2 = true;
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			this.InitDeviceInfo(radio.DeviceInfo, hwProfile);
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = global::Motorola.Common.Communication.CommunicationManager.CommunicationPipeFactory.CreateCommunicationPipe(radio.DeviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any);
			if (communicationPipe == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleLegacyRadio: can't create communication pipe");
				return false;
			}
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = communicationPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe;
			if (tetraRadioProfile.PID.Equals("0100", global::System.StringComparison.InvariantCultureIgnoreCase) && global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.IsCPSInTestMode())
			{
				global::System.Threading.Thread.Sleep(6000);
			}
			if (!tetraCommPipe.OpenPort())
			{
				state = global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.IDLE;
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateSingleLegacyRadio: Failed to open the transport");
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleLegacyRadio: Failed to open the transport : {0}", new object[]
				{
					tetraRadioProfile.Path
				});
				flag2 = false;
			}
			if (flag2)
			{
				switch (state)
				{
				case global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.IDLE:
				{
					state = global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.INIT;
					global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
					string text = string.Empty;
					bool flag3;
					if (bCHRadio)
					{
						flag3 = this.GetOmapDevProperties(communicationPipe, hwProfile, out text, out deviceMode);
					}
					else
					{
						flag3 = this.GetPatriotDevProperties(communicationPipe, hwProfile, out text, out deviceMode);
					}
					if (!flag3)
					{
						state = global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.IDLE;
						string message = "RadioCreatorUtility.CreateSingleLegacyRadio: Failed to get the device properties for " + this.GetRadioInfoInDetail(hwProfile);
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateSingleLegacyRadio: Failed to get the device properties");
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message);
					}
					else
					{
						text = global::System.IO.Path.Combine(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CommKernelDir, text);
						hwProfile.DeviceMode = deviceMode;
						if (deviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP)
						{
							global::Motorola.Common.Communication.TetraUtility.SRecord srecord = new global::Motorola.Common.Communication.TetraUtility.SRecord();
							if (!srecord.LoadFromFile(text))
							{
								state = global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.IDLE;
								string message2 = "RadioCreatorUtility.CreateSingleLegacyRadio: Failed to load the kernel file for " + this.GetRadioInfoInDetail(hwProfile);
								global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateSingleLegacyRadio: Failed to load the kernel file of " + text);
								global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message2);
							}
							else if (!new global::Motorola.Common.Communication.Rce
							{
								Transport = communicationPipe
							}.DownloadImage(srecord.Image))
							{
								state = global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.IDLE;
								string message3 = "RadioCreatorUtility.CreateSingleLegacyRadio: Failed to download kernel for " + this.GetRadioInfoInDetail(hwProfile);
								global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateSingleLegacyRadio: Failed to download kernel");
								global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message3);
							}
						}
						else
						{
							if (bCHRadio)
							{
								global::System.Threading.Thread.Sleep(200);
							}
							state = global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.IDLE;
							if (deviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL)
							{
								ushort hwID = 0;
								if (this.GetBaseHwID(communicationPipe, hwProfile, out hwID))
								{
									global::Motorola.Common.Communication.TetraUtility.CPUType cpuTypeViaHwId = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetCpuTypeViaHwId((uint)hwID);
									if (cpuTypeViaHwId != global::Motorola.Common.Communication.TetraUtility.CPUType.FREON)
									{
										flag = true;
										this.SetBaseHwID(tetraCommPipe, hwProfile);
										if (bCHRadio && this.IsStandalone(tetraCommPipe))
										{
											bStandaloneCH = true;
										}
										hwProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL;
									}
								}
							}
							else
							{
								flag = true;
							}
						}
					}
					break;
				}
				case global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.INIT:
					if (bCHRadio)
					{
						global::System.Threading.Thread.Sleep(200);
					}
					if (this.GetRadioACK(tetraCommPipe, false))
					{
						flag = true;
						this.SetBaseHwID(tetraCommPipe, hwProfile);
						if (bCHRadio && this.IsStandalone(communicationPipe))
						{
							bStandaloneCH = true;
						}
					}
					hwProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL;
					state = global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.IDLE;
					break;
				}
				if (flag)
				{
					radio.CommPipe = communicationPipe;
				}
				else
				{
					tetraCommPipe.ClosePort();
				}
			}
			return flag;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00009B00 File Offset: 0x00007D00
		public bool CreateSingleFrodoRadio(global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			if (radio == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleFrodoRadio: radio is null");
				return false;
			}
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleFrodoRadio: hwProfile is null");
				return false;
			}
			bool flag = true;
			bool flag2 = false;
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			this.InitDeviceInfo(radio.DeviceInfo, hwProfile);
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = global::Motorola.Common.Communication.CommunicationManager.CommunicationPipeFactory.CreateCommunicationPipe(radio.DeviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any);
			if (communicationPipe == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleFrodoRadio: can't create communication pipe");
				return false;
			}
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = communicationPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe;
			if (!tetraCommPipe.OpenPort())
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateSingleFrodoRadio: Failed to open the transport");
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleFrodoRadio: Failed to open the transport : {0}", new object[]
				{
					tetraRadioProfile.Path
				});
				flag = false;
			}
			if (flag)
			{
				if (hwProfile.PID.Contains("9011"))
				{
					hwProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL;
					flag2 = true;
				}
				else
				{
					global::Motorola.Common.Communication.SBEPStatus sbepstatus = new global::Motorola.Common.Communication.SBEPStatus(tetraCommPipe);
					sbepstatus.ExecuteMessage();
					global::Motorola.Common.Communication.TetraMsgOpResult operationResult = sbepstatus.OperationResult;
					byte status = sbepstatus.Status;
					if (operationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						if (status == 0)
						{
							global::Motorola.Common.Communication.SBEPGetHwID sbepgetHwID = new global::Motorola.Common.Communication.SBEPGetHwID(tetraCommPipe);
							sbepgetHwID.ExecuteMessage();
							if (sbepgetHwID.OperationResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
							{
								global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleFrodoRadio: Can't Get Radio Hardware ID for " + hwProfile.PhysicalLocation);
							}
							else
							{
								global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType gemstoneRadioType = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetGemstoneRadioType((uint)sbepgetHwID.HwID);
								if (gemstoneRadioType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.ARAGORN || gemstoneRadioType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.BOROMIR)
								{
									tetraCommPipe.ClosePort();
									return false;
								}
								if (gemstoneRadioType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.FRODO)
								{
									tetraRadioProfile.HardwareIdIsValid = true;
								}
								else
								{
									global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "RadioCreatorUtility.CreateSingleFrodoRadio: This radio hardware Id: {0:D} is not valid", new object[]
									{
										(uint)sbepgetHwID.HwID
									});
									global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleFrodoRadio: This radio hardware Id: {0:D} is not valid", new object[]
									{
										(uint)sbepgetHwID.HwID
									});
								}
								hwProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL;
								flag2 = true;
							}
						}
						else
						{
							string format = "RadioCreatorUtility.CreateSingleFrodoRadio: Invalid status code {0} for " + this.GetRadioInfoInDetail(hwProfile);
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, string.Format("RadioCreatorUtility.CreateSingleFrodoRadio: Invalid status code {0}", status));
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(format, new object[]
							{
								status
							});
						}
					}
					else
					{
						string message = "RadioCreatorUtility.CreateSingleFrodoRadio: Failed to get the StatusReplay for " + this.GetRadioInfoInDetail(hwProfile);
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateSingleFrodoRadio: Failed to get the StatusReplay");
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message);
					}
				}
			}
			if (flag2)
			{
				radio.CommPipe = communicationPipe;
			}
			else
			{
				tetraCommPipe.ClosePort();
			}
			return flag2;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00009DD8 File Offset: 0x00007FD8
		public bool CreateSingleGemstoneBMPRadio(global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			if (radio == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleGemstoneBMPRadio: radio is null");
				return false;
			}
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleGemstoneBMPRadio: hwProfile is null");
				return false;
			}
			bool flag = true;
			bool flag2 = false;
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			this.InitDeviceInfo(radio.DeviceInfo, hwProfile);
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = global::Motorola.Common.Communication.CommunicationManager.CommunicationPipeFactory.CreateCommunicationPipe(radio.DeviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any);
			if (communicationPipe == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleGemstoneBMPRadio: can't create communication pipe");
				return false;
			}
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = communicationPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe;
			if (!tetraCommPipe.OpenPort())
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateSingleGemstoneBMPRadio: Failed to open the transport");
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleGemstoneBMPRadio: Failed to open the transport : {0}", new object[]
				{
					tetraRadioProfile.Path
				});
				flag = false;
			}
			if (flag)
			{
				if (hwProfile.PID.Contains("9013") || hwProfile.PID.Contains("9012"))
				{
					if (tetraRadioProfile.TetraRadioType == global::Motorola.Common.Communication.CommonUtil.TetraRadioType.DATABOX_PORT2)
					{
						tetraRadioProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL;
						flag2 = true;
					}
					else
					{
						flag2 = false;
					}
				}
				else
				{
					global::Motorola.Common.Communication.SBEPStatus sbepstatus = new global::Motorola.Common.Communication.SBEPStatus(tetraCommPipe);
					sbepstatus.ExecuteMessage();
					global::Motorola.Common.Communication.TetraMsgOpResult operationResult = sbepstatus.OperationResult;
					byte status = sbepstatus.Status;
					if (operationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						if (status == 0)
						{
							global::Motorola.Common.Communication.SBEPGetHwID sbepgetHwID = new global::Motorola.Common.Communication.SBEPGetHwID(tetraCommPipe);
							sbepgetHwID.ExecuteMessage();
							if (sbepgetHwID.OperationResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
							{
								global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleGemstoneBMPRadio: Can't Get Radio Hardware ID for " + hwProfile.PhysicalLocation);
							}
							else
							{
								global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType gemstoneRadioType = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetGemstoneRadioType((uint)sbepgetHwID.HwID);
								if (gemstoneRadioType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.FRODO)
								{
									tetraCommPipe.ClosePort();
									return false;
								}
								if (gemstoneRadioType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.BOROMIR || gemstoneRadioType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.ARAGORN)
								{
									tetraRadioProfile.HardwareIdIsValid = true;
								}
								else
								{
									global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "RadioCreatorUtility.CreateSingleGemstoneBMPRadio: This radio hardware Id: {0:D} is not valid", new object[]
									{
										(uint)sbepgetHwID.HwID
									});
									global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleFrodoRadio: This radio hardware Id: {0:D} is not valid", new object[]
									{
										(uint)sbepgetHwID.HwID
									});
								}
								hwProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL;
								flag2 = true;
							}
						}
						else
						{
							string format = "RadioCreatorUtility.CreateSingleGemstoneBMPRadio: Invalid status code {0} for " + this.GetRadioInfoInDetail(hwProfile);
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(format, new object[]
							{
								status
							});
						}
					}
					else
					{
						string message = "RadioCreatorUtility.CreateSingleGemstoneBMPRadio: Failed to get the StatusReplay for " + this.GetRadioInfoInDetail(hwProfile);
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message);
					}
				}
			}
			if (flag2)
			{
				radio.CommPipe = communicationPipe;
			}
			else
			{
				tetraCommPipe.ClosePort();
			}
			return flag2;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000A0A0 File Offset: 0x000082A0
		public bool CreateMassStorageRadio(global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			if (radio == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateMassStorageRadio: radio is null");
				return false;
			}
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateMassStorageRadio: hwProfile is null");
				return false;
			}
			hwProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.MASS_STORAGE;
			return true;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000A0F4 File Offset: 0x000082F4
		public bool CreateTransRadioPairedWithCH(global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile, out bool bFrodoRadio)
		{
			bFrodoRadio = false;
			if (radio == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateTransRadioPairedWithCH: radio instance is null");
				return false;
			}
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateTransRadioPairedWithCH: hwProfile is null");
				return false;
			}
			bool flag = false;
			bool flag2 = true;
			string text = string.Empty;
			global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			this.InitDeviceInfo(radio.DeviceInfo, hwProfile);
			global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = global::Motorola.Common.Communication.CommunicationManager.CommunicationPipeFactory.CreateCommunicationPipe(radio.DeviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any);
			if (communicationPipe == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleLegacyRadio: can't create communication pipe");
				return false;
			}
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = communicationPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe;
			if (!tetraCommPipe.OpenPort())
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateTransRadioPairedWithCH: Failed to open the transport");
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateTransRadioPairedWithCH: Failed to open the transport : {0}", new object[]
				{
					tetraRadioProfile.Path
				});
				flag2 = false;
			}
			if (flag2)
			{
				this.GetRadioACK(communicationPipe, true);
				if (!this.GetNewPatriotDevProperties(communicationPipe, hwProfile, out text, out deviceMode))
				{
					string message = "RadioCreatorUtility.CreateTransRadioPairedWithCH: Failed to get the device properties for " + this.GetRadioInfoInDetail(hwProfile);
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateTransRadioPairedWithCH: Failed to get the device properties");
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message);
					flag2 = false;
				}
			}
			if (flag2)
			{
				text = global::System.IO.Path.Combine(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CommKernelDir, text);
				hwProfile.DeviceMode = deviceMode;
			}
			if (flag2 && deviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP)
			{
				global::Motorola.Common.Communication.TetraUtility.SRecord srecord = new global::Motorola.Common.Communication.TetraUtility.SRecord();
				if (!srecord.LoadFromFile(text))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateTransRadioPairedWithCH: Failed to load the kernel file of " + text);
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateTransRadioPairedWithCH: Failed to load the kernel file : {0}", new object[]
					{
						text
					});
					flag2 = false;
				}
				if (flag2 && !new global::Motorola.Common.Communication.Rce
				{
					Transport = communicationPipe
				}.DownloadImage(srecord.Image))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateTransRadioPairedWithCH: Failed to download kernel to the radio");
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateTransRadioPairedWithCH: Failed to download kernel to the radio");
					flag2 = false;
				}
				if (flag2 && !this.GetRadioACK(communicationPipe, false))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateTransRadioPairedWithCH: Failed to get tr kernel ack");
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateTransRadioPairedWithCH: Failed to get tr kernel ack");
					flag2 = false;
				}
				if (flag2)
				{
					this.SetBaseHwID(communicationPipe, hwProfile);
					hwProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL;
				}
			}
			if (flag2)
			{
				if (this.TransceiverIsFrodo(communicationPipe, hwProfile))
				{
					bFrodoRadio = true;
				}
				flag = true;
			}
			if (flag)
			{
				radio.CommPipe = communicationPipe;
			}
			else
			{
				tetraCommPipe.ClosePort();
			}
			return flag;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A380 File Offset: 0x00008580
		public bool CreateUARTRadio(global::Motorola.Common.Communication.CommunicationManager.TetraRS232Device radio, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.IRadioProfile hwProfile, out bool bFrodoRadio, out bool bGemstonePortableRadio)
		{
			bFrodoRadio = false;
			bGemstonePortableRadio = false;
			global::Motorola.Common.Communication.Rce rce = new global::Motorola.Common.Communication.Rce();
			bool result = false;
			bool flag = true;
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = null;
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			try
			{
				this.InitDeviceInfo(devInfo, hwProfile);
				global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe = global::Motorola.Common.Communication.CommunicationManager.CommunicationPipeFactory.CreateCommunicationPipe(devInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any);
				if (communicationPipe == null)
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateSingleLegacyRadio: can't create communication pipe");
					return false;
				}
				tetraCommPipe = (communicationPipe as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe);
				tetraCommPipe.ReadTimeout = 5000;
				tetraCommPipe.WriteTimeout = 3000;
				global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
				string text = global::System.IO.Path.Combine(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CommKernelDir, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.PATRIOT_KERNEL_NAME);
				string filePath = global::System.IO.Path.Combine(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.CommKernelDir, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.PATRIOT_MINI_KERNEL_NAME);
				if (hwProfile == null)
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateUARTRadio: hwProfile is null");
					flag = false;
				}
				if (flag && !tetraCommPipe.OpenPort())
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateUARTRadio: Failed to open the transport");
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.CreateUARTRadio: Failed to open the transport : {0}", new object[]
					{
						tetraRadioProfile.Path
					});
					flag = false;
				}
				if (flag)
				{
					flag = this.GetUartDevProperties(communicationPipe, hwProfile, true, out deviceMode);
					hwProfile.DeviceMode = deviceMode;
				}
				if (!flag)
				{
					string message = "RadioCreatorUtility.CreateUARTRadio: Failed to get the device properties.";
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateUARTRadio: Failed to get the device properties");
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message);
				}
				if (flag)
				{
					rce.Transport = communicationPipe;
					hwProfile.DeviceMode = deviceMode;
				}
				if (flag && deviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP)
				{
					global::Motorola.Common.Communication.TetraUtility.SRecord srecord = new global::Motorola.Common.Communication.TetraUtility.SRecord();
					if (!srecord.LoadFromFile(filePath))
					{
						string message2 = "RadioCreatorUtility.CreateUARTRadio: Failed to load the mini kernel file.";
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateUARTRadio: Failed to load the kernel file of " + text);
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message2);
						flag = false;
					}
					if (flag && !rce.DownloadUartMiniKernelImage(srecord.Image))
					{
						string message3 = "RadioCreatorUtility.CreateUARTRadio: Failed to download mini kernel.";
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateUARTRadio: Failed to download kernel");
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message3);
						flag = false;
					}
					if (flag)
					{
						global::System.Threading.Thread.Sleep(50);
						if (!srecord.LoadFromFile(text))
						{
							string message4 = "RadioCreatorUtility.CreateUARTRadio: Failed to load the kernel file.";
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateUARTRadio: Failed to load the kernel file of " + text);
							global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message4);
							flag = false;
						}
					}
					if (flag && !rce.DownloadUartPatriotKernelImage(srecord.Image))
					{
						string message5 = "RadioCreatorUtility.CreateUARTRadio: Failed to download kernel.";
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, "RadioCreatorUtility.CreateUARTRadio: Failed to download kernel");
						global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message5);
						flag = false;
					}
					if (flag)
					{
						global::System.Threading.Thread.Sleep(3000);
						flag = this.GetUartDevProperties(tetraCommPipe, hwProfile, true, out deviceMode);
						if (flag && deviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL)
						{
							hwProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL;
							result = true;
						}
					}
				}
				else if (flag && deviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL)
				{
					hwProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL;
					ushort hwID = 0;
					flag = this.GetBaseHwID(communicationPipe, hwProfile, out hwID);
					if (flag)
					{
						result = true;
						global::Motorola.Common.Communication.TetraUtility.CPUType cpuTypeViaHwId = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetCpuTypeViaHwId((uint)hwID);
						if (cpuTypeViaHwId == global::Motorola.Common.Communication.TetraUtility.CPUType.FREON)
						{
							global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType gemstoneRadioType = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetGemstoneRadioType((uint)hwID);
							if (gemstoneRadioType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.FRODO)
							{
								bFrodoRadio = true;
							}
							else if (gemstoneRadioType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.BOROMIR || gemstoneRadioType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.ARAGORN)
							{
								bGemstonePortableRadio = true;
							}
							else if (hwProfile.PID.Equals("9010", global::System.StringComparison.InvariantCultureIgnoreCase))
							{
								bFrodoRadio = true;
							}
						}
						if (cpuTypeViaHwId != global::Motorola.Common.Communication.TetraUtility.CPUType.UNKNOWN)
						{
							tetraRadioProfile.HardwareIdIsValid = true;
						}
					}
				}
				if (deviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL && !hwProfile.PID.Equals("9010", global::System.StringComparison.InvariantCultureIgnoreCase))
				{
					this.SetBaseHwID(communicationPipe, hwProfile);
				}
				radio.CommPipe = communicationPipe;
			}
			finally
			{
				radio.Profile = tetraRadioProfile;
				tetraCommPipe.ClosePort();
			}
			return result;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A724 File Offset: 0x00008924
		private bool GetPatriotDevProperties(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.IRadioProfile hwProfile, out string kernelFileName, out global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode)
		{
			kernelFileName = string.Empty;
			deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
			if (transport == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetPatriotDevProperties: The transport is null");
				return false;
			}
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetPatriotDevProperties: The hwProfile is null");
				return false;
			}
			if (string.IsNullOrEmpty(hwProfile.VID) || string.IsNullOrEmpty(hwProfile.PID))
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetPatriotDevProperties: The PID/VID is null");
				return false;
			}
			bool result = true;
			if (hwProfile.PID.Contains("0100"))
			{
				deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL;
				kernelFileName = string.Empty;
			}
			else
			{
				global::Motorola.Common.Communication.SBEPStatus sbepstatus = new global::Motorola.Common.Communication.SBEPStatus(transport, true);
				sbepstatus.ExecuteMessage();
				global::Motorola.Common.Communication.TetraMsgOpResult operationResult = sbepstatus.OperationResult;
				if (operationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL;
					kernelFileName = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.PATRIOT_KERNEL_NAME;
				}
				else
				{
					bool flag = false;
					global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
					bool flag2 = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.IsFlashstrapRadio(tetraRadioProfile.USBHubInstance, tetraRadioProfile.USBHubPortNumber, tetraRadioProfile.Path, out flag);
					if (flag2 && !flag)
					{
						string log = "The radio has been downloaded kernel, no need to download twice!";
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, log);
						deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL;
					}
					else
					{
						deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP;
					}
					kernelFileName = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.PATRIOT_KERNEL_NAME;
				}
			}
			return result;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000A844 File Offset: 0x00008A44
		private bool GetUartDevProperties(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.IRadioProfile hwProfile, bool bQuickCheck, out global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode)
		{
			deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
			if (transport == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetPatriotDevProperties: The transport is null");
				return false;
			}
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetPatriotDevProperties: The hwProfile is null");
				return false;
			}
			bool result = true;
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe;
			tetraCommPipe.BaudRate = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.BAUD_RATE_SBEP;
			global::Motorola.Common.Communication.SBEPStatus sbepstatus = new global::Motorola.Common.Communication.SBEPStatus(transport, bQuickCheck);
			sbepstatus.OperationFlag = 0U;
			sbepstatus.ExecuteMessage();
			if (sbepstatus.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL;
			}
			else
			{
				deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP;
			}
			return result;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000A8C4 File Offset: 0x00008AC4
		private bool GetNewPatriotDevProperties(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.IRadioProfile hwProfile, out string kernelFileName, out global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode)
		{
			kernelFileName = string.Empty;
			deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
			if (transport == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetPatriotDevProperties: The transport is null");
				return false;
			}
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetPatriotDevProperties: The hwProfile is null");
				return false;
			}
			if (string.IsNullOrEmpty(hwProfile.VID) || string.IsNullOrEmpty(hwProfile.PID))
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetPatriotDevProperties: The PID/VID is null");
				return false;
			}
			bool result = true;
			if (hwProfile.DeviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL)
			{
				deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL;
				kernelFileName = string.Empty;
			}
			else
			{
				global::Motorola.Common.Communication.SBEPStatus sbepstatus = new global::Motorola.Common.Communication.SBEPStatus(transport, true);
				sbepstatus.ExecuteMessage();
				if (sbepstatus.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL;
					kernelFileName = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.PATRIOT_RF_KERNEL_NAME;
				}
				else
				{
					deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP;
					kernelFileName = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.PATRIOT_RF_KERNEL_NAME;
				}
			}
			return result;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A98C File Offset: 0x00008B8C
		private bool GetOmapDevProperties(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.IRadioProfile hwProfile, out string kernelFileName, out global::Motorola.Common.Communication.CommonUtil.DeviceMode deviceMode)
		{
			kernelFileName = string.Empty;
			deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
			if (transport == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetOmapDevProperties: The transport is null");
				return false;
			}
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetOmapDevProperties: The hwProfile is null");
				return false;
			}
			if (string.IsNullOrEmpty(hwProfile.VID) || string.IsNullOrEmpty(hwProfile.PID))
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetOmapDevProperties: The PID/VID is null");
				return false;
			}
			bool result = true;
			global::Motorola.Common.Communication.SBEPStatus sbepstatus = new global::Motorola.Common.Communication.SBEPStatus(transport, true);
			sbepstatus.ExecuteMessage();
			if (sbepstatus.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				if (sbepstatus.Status == 225)
				{
					deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP;
					kernelFileName = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.OMAP_KERNEL_NAME;
				}
				else if ((sbepstatus.Status & 128) == 128)
				{
					deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL;
					kernelFileName = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.OMAP_KERNEL_NAME;
				}
				else
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("FrodoDataBox.GetPatriotDevProperties: The StatusReplay is not recognized {0}", new object[]
					{
						sbepstatus.Status
					});
					result = false;
				}
			}
			else
			{
				deviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL;
				kernelFileName = string.Empty;
			}
			return result;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		private void SetBaseHwID(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			if (hwProfile.DeviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL)
			{
				return;
			}
			uint num = 0U;
			global::Motorola.Common.Communication.SBEPGetHwID sbepgetHwID = new global::Motorola.Common.Communication.SBEPGetHwID(transport);
			sbepgetHwID.ExecuteMessage();
			if (sbepgetHwID.OperationResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.SetBaseHwID: Can't Get Radio Hardware ID for " + hwProfile.PhysicalLocation);
				return;
			}
			num = (uint)sbepgetHwID.HwID;
			global::Motorola.Common.Communication.TetraUtility.HwIDRecord hwIDRecord = null;
			foreach (global::Motorola.Common.Communication.TetraUtility.HwIDRecord hwIDRecord2 in global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.HwIDTable.RecordsList)
			{
				if (num == hwIDRecord2.HwID)
				{
					hwIDRecord = hwIDRecord2;
					break;
				}
			}
			if (hwIDRecord == null)
			{
				string text = string.Format("RadioCreatorUtility.SetBaseHwID: Can't Query Radio Hardware ID Record from system hardware table, the hardware Id value is: {0:D}", num);
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, text);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(text);
				return;
			}
			(hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).HardwareIdIsValid = true;
			global::Motorola.Common.Communication.SBEPSetBaseHwID sbepsetBaseHwID = new global::Motorola.Common.Communication.SBEPSetBaseHwID(transport, (ushort)hwIDRecord.BaseHwID);
			sbepsetBaseHwID.ExecuteMessage();
			if (sbepsetBaseHwID.OperationResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				string text2 = string.Format("RadioCreatorUtility.SetBaseHwID: Failed to set base hardware ID to radio, the base hardware id is: {0:D}", hwIDRecord.BaseHwID);
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, text2);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(text2);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000AC00 File Offset: 0x00008E00
		private bool GetBaseHwID(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.IRadioProfile hwProfile, out ushort hwID)
		{
			hwID = 0;
			if (hwProfile.DeviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL)
			{
				return false;
			}
			bool result = true;
			global::Motorola.Common.Communication.SBEPGetHwID sbepgetHwID = new global::Motorola.Common.Communication.SBEPGetHwID(transport);
			sbepgetHwID.ExecuteMessage();
			if (sbepgetHwID.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				hwID = sbepgetHwID.HwID;
			}
			else
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "RadioCreatorUtility.GetBaseHwID: Can't Get Radio Hardware ID");
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("RadioCreatorUtility.GetBaseHwID: Can't Get Radio Hardware ID for " + hwProfile.PhysicalLocation);
				result = false;
			}
			return result;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000AC7C File Offset: 0x00008E7C
		private bool IsStandalone(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport)
		{
			bool result = false;
			int i = 3;
			global::Motorola.Common.Communication.SBEPStatus sbepstatus = new global::Motorola.Common.Communication.SBEPStatus(transport, true);
			while (i > 0)
			{
				sbepstatus.ExecuteMessage();
				if (sbepstatus.OperationResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					break;
				}
				if ((sbepstatus.Status & 113) != 113)
				{
					result = false;
					break;
				}
				result = true;
				if (transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe).PortName, "RadioCreatorUtility.IsStandalone, will retry the GetStatus Command after 500 ms to make sure getting the right connection status between CH and Trans");
				}
				global::System.Threading.Thread.Sleep(500);
				i--;
			}
			return result;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000ACE8 File Offset: 0x00008EE8
		private bool GetRadioACK(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, bool bQuickCheck)
		{
			global::Motorola.Common.Communication.Rce rce = new global::Motorola.Common.Communication.Rce();
			bool result = false;
			global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe tetraCommPipe = transport as global::Motorola.Common.Communication.CommunicationPipe.TetraCommPipe;
			int readTimeout = tetraCommPipe.ReadTimeout;
			if (bQuickCheck)
			{
				tetraCommPipe.ReadTimeout = 1000;
			}
			else
			{
				tetraCommPipe.ReadTimeout = 10000;
			}
			rce.Transport = transport;
			try
			{
				result = rce.GetAcknowledge();
			}
			catch (global::System.Exception e)
			{
				if (transport != null)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, tetraCommPipe.PortName, "Generic Error", new object[0]);
				}
				throw;
			}
			finally
			{
				tetraCommPipe.ReadTimeout = readTimeout;
			}
			return result;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000AD7C File Offset: 0x00008F7C
		private bool TransceiverIsFrodo(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.IRadioProfile profile)
		{
			if (profile.DeviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL)
			{
				return false;
			}
			ushort hwID = 0;
			bool result = false;
			if (this.GetBaseHwID(transport, profile, out hwID))
			{
				global::Motorola.Common.Communication.TetraUtility.CPUTypeRecord cpuTypeConfig = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetCpuTypeConfig((uint)hwID);
				if (cpuTypeConfig == null)
				{
					return false;
				}
				if (cpuTypeConfig.CPUType == global::Motorola.Common.Communication.TetraUtility.CPUType.FREON)
				{
					result = true;
				}
				if (cpuTypeConfig.CPUType != global::Motorola.Common.Communication.TetraUtility.CPUType.UNKNOWN)
				{
					(profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).HardwareIdIsValid = true;
				}
			}
			return result;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		private string GetRadioInfoInDetail(global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			string result = string.Empty;
			if (hwProfile != null)
			{
				result = (hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path + "stands on " + hwProfile.PhysicalLocation;
			}
			return result;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000AE04 File Offset: 0x00009004
		private bool ExtractDevInstanceID(global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper apiWrapper, global::System.Guid devClass, string devName, out string devInstanceID)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA devInfoData = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA);
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA sp_DEVICE_INTERFACE_DATA = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA);
			global::System.IntPtr zero = global::System.IntPtr.Zero;
			devInstanceID = string.Empty;
			global::System.IntPtr zero2 = global::System.IntPtr.Zero;
			if (apiWrapper == null || string.IsNullOrEmpty(devName))
			{
				flag = false;
			}
			if (flag && !apiWrapper.WrapperSetupDiGetClassDevs(ref zero, ref devClass, global::System.IntPtr.Zero))
			{
				flag = false;
				if (zero != global::System.IntPtr.Zero)
				{
					apiWrapper.WrapperSetupDiDestroyDeviceInfoList(zero);
					zero = global::System.IntPtr.Zero;
				}
			}
			if (flag)
			{
				flag = false;
				devInfoData.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA));
				sp_DEVICE_INTERFACE_DATA.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA));
				int num = 0;
				while (apiWrapper.WrapperSetupDiEnumDeviceInterfaces(zero, (uint)num, ref sp_DEVICE_INTERFACE_DATA, ref devClass))
				{
					int num2 = 0;
					uint num3 = 0U;
					if (apiWrapper.WrapperSetupDiGetDeviceInterfaceDetail(zero, ref sp_DEVICE_INTERFACE_DATA, global::System.IntPtr.Zero, 0U, out num3, ref devInfoData, out num2))
					{
						string empty = string.Empty;
						if (apiWrapper.WrapperSetupDiOpenDevRegKey(zero, ref devInfoData, ref zero2))
						{
							if (!apiWrapper.WrapperRegQueryVComName(zero2, ref empty))
							{
								apiWrapper.WrapperRegCloseKey(zero2);
							}
							else
							{
								apiWrapper.WrapperRegCloseKey(zero2);
								if (empty.Contains(devName))
								{
									flag = apiWrapper.WrapperSetupDiGetDeviceInstanceId(zero, devInfoData, ref devInstanceID, 1024);
									break;
								}
							}
						}
					}
					num++;
				}
			}
			if (zero != global::System.IntPtr.Zero)
			{
				apiWrapper.WrapperSetupDiDestroyDeviceInfoList(zero);
				zero = global::System.IntPtr.Zero;
			}
			return flag;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000AF50 File Offset: 0x00009150
		public bool GetRS232PortInstanceID(string comPortName, out string instanceID)
		{
			instanceID = string.Empty;
			bool flag = true;
			global::System.Guid[] array = null;
			global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper winAPIWrapper = new global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper();
			if (string.IsNullOrEmpty(comPortName))
			{
				flag = false;
			}
			if (flag)
			{
				flag = winAPIWrapper.Wrapper_SetupDiClassGuidsFromName("Ports", out array);
			}
			if (flag)
			{
				flag = false;
				for (int i = 0; i < array.Length; i++)
				{
					flag = this.ExtractDevInstanceID(winAPIWrapper, array[i], comPortName, out instanceID);
					if (flag)
					{
						break;
					}
				}
			}
			return flag;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000AFB8 File Offset: 0x000091B8
		private string GetPhysicalLocationFromDeviceInstance(string instance_id)
		{
			int num = instance_id.IndexOf('\\');
			num = instance_id.IndexOf('\\', num + 1);
			return instance_id.Substring(num + 1);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000AFE8 File Offset: 0x000091E8
		private void InitDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.IRadioProfile profile)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo tetraDeviceInfo = devInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
			tetraDeviceInfo.ConnectionInfo.Location = tetraRadioProfile.Path;
			tetraDeviceInfo.Location = tetraRadioProfile.PhysicalLocation;
			tetraDeviceInfo.UsbHubInstance = tetraRadioProfile.USBHubInstance;
			tetraDeviceInfo.UsbHubPortNumber = tetraRadioProfile.USBHubPortNumber;
			tetraDeviceInfo.PID = tetraRadioProfile.PID;
		}
	}
}
