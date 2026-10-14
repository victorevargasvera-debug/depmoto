using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000028 RID: 40
	public class VCOMDetector : global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000186 RID: 390 RVA: 0x000075C7 File Offset: 0x000057C7
		// (remove) Token: 0x06000187 RID: 391 RVA: 0x000075DA File Offset: 0x000057DA
		public override event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached
		{
			add
			{
				this.eventBag.Add("DeviceAttached", value);
			}
			remove
			{
				this.eventBag.Remove("DeviceAttached", value);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000188 RID: 392 RVA: 0x000075ED File Offset: 0x000057ED
		// (remove) Token: 0x06000189 RID: 393 RVA: 0x00007600 File Offset: 0x00005800
		public override event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached
		{
			add
			{
				this.eventBag.Add("DeviceDetached", value);
			}
			remove
			{
				this.eventBag.Remove("DeviceDetached", value);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00007613 File Offset: 0x00005813
		public VCOMDetector()
		{
			base.DetectorType = global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType.VCOMDetector;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00007645 File Offset: 0x00005845
		protected override void InitDevClassGUIDList()
		{
			base._radioClass = new global::System.Guid("9664C324-B905-4A34-B057-D97436E7B565");
			base.lstValidGuid.Add(base._radioClass);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007668 File Offset: 0x00005868
		protected override void HandleDeviceAttached(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg)
		{
			int index = 0;
			global::Motorola.Common.Communication.IRadioProfile radioProfile = new global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile();
			if (orgPnPMsg.isVolume)
			{
				uint mask = global::System.Convert.ToUInt32(orgPnPMsg.sDeviceName);
				global::System.Collections.Generic.List<char> driveNameByUnitMask = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetDriveNameByUnitMask(mask);
				using (global::System.Collections.Generic.List<char>.Enumerator enumerator = driveNameByUnitMask.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						char c = enumerator.Current;
						if (this.GetInfoForMassStorageRadio(c.ToString(), true, ref radioProfile))
						{
							this.DevicePnPHandler(new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs
							{
								PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached,
								RadioInfoSet = 
								{
									radioProfile
								}
							});
						}
					}
					return;
				}
			}
			if (this.ExtractRadioInformation(orgPnPMsg, ref radioProfile))
			{
				global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = radioProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
				tetraRadioProfile.TetraRadioType = this.GetRadioType(tetraRadioProfile);
				if (this.Contains(tetraRadioProfile))
				{
					return;
				}
				if (tetraRadioProfile.PID == "9006" || tetraRadioProfile.PID == "9011" || tetraRadioProfile.PID == "9013" || tetraRadioProfile.PID == "9012")
				{
					if (!this.FindPartner(tetraRadioProfile, ref index))
					{
						base._currentExistDevice.Add(tetraRadioProfile);
						return;
					}
					base._currentExistDevice.Add(tetraRadioProfile);
					tetraRadioProfile.SetPairProfile(base._currentExistDevice[index] as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile);
					global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile2 = base._currentExistDevice[index] as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
					tetraRadioProfile2.SetPairProfile(tetraRadioProfile);
					if (this.IsValidRadioInfo(tetraRadioProfile) && this.IsValidRadioInfo(tetraRadioProfile2))
					{
						string log = "Tetra composite Device attached!" + tetraRadioProfile.Path + ":" + tetraRadioProfile.PhysicalLocation;
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, log);
						string log2 = "Tetra composite Device attached!" + tetraRadioProfile2.Path + ":" + tetraRadioProfile2.PhysicalLocation;
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile2.Path, log2);
						this.DevicePnPHandler(new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs
						{
							PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached,
							RadioInfoSet = 
							{
								base._currentExistDevice[index],
								tetraRadioProfile
							}
						});
						return;
					}
					base._currentExistDevice.Remove(tetraRadioProfile);
					base._currentExistDevice.Remove(tetraRadioProfile2);
					return;
				}
				else if (this.IsValidRadioInfo(tetraRadioProfile))
				{
					base._currentExistDevice.Add(tetraRadioProfile);
					string log3 = "Tetra Portable Device attached!" + tetraRadioProfile.Path + ":" + tetraRadioProfile.PhysicalLocation;
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, log3);
					this.DevicePnPHandler(new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs
					{
						PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached,
						RadioInfoSet = 
						{
							tetraRadioProfile
						}
					});
				}
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00007928 File Offset: 0x00005B28
		protected override void HandleDeviceDetached(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = new global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile();
			if (orgPnPMsg.isVolume)
			{
				global::Motorola.Common.Communication.IRadioProfile value = tetraRadioProfile;
				uint mask = global::System.Convert.ToUInt32(orgPnPMsg.sDeviceName);
				global::System.Collections.Generic.List<char> driveNameByUnitMask = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetDriveNameByUnitMask(mask);
				using (global::System.Collections.Generic.List<char>.Enumerator enumerator = driveNameByUnitMask.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						char c = enumerator.Current;
						if (this.GetInfoForMassStorageRadio(c.ToString(), false, ref value))
						{
							this.DevicePnPHandler(new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs
							{
								PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached,
								RadioInfoSet = 
								{
									value
								}
							});
						}
					}
					return;
				}
			}
			bool flag = false;
			int index = 0;
			int num = 0;
			string text = global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.GetDevCurrentLocationFromDevName(orgPnPMsg.sDeviceName);
			text = text.ToUpperInvariant();
			for (int i = 0; i < base._currentExistDevice.Count; i++)
			{
				tetraRadioProfile = (global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile)base._currentExistDevice[i];
				if (tetraRadioProfile.DeviceInstanceID.IndexOf(text, global::System.StringComparison.OrdinalIgnoreCase) != -1)
				{
					flag = true;
					index = i;
					break;
				}
			}
			if (flag)
			{
				if (tetraRadioProfile.PID == "9006" || tetraRadioProfile.PID == "9011" || tetraRadioProfile.PID == "9013" || tetraRadioProfile.PID == "9012")
				{
					base._currentExistDevice.RemoveAt(index);
					if (this.FindPartner(tetraRadioProfile, ref num))
					{
						this._removedMTM800EPart = tetraRadioProfile;
						return;
					}
					this.DevicePnPHandler(new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs
					{
						PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached,
						RadioInfoSet = 
						{
							tetraRadioProfile,
							this._removedMTM800EPart
						}
					});
					string log = "Tetra composite Device removed!";
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, log);
					if (this._removedMTM800EPart is global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo((this._removedMTM800EPart as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, log);
						return;
					}
				}
				else
				{
					base._currentExistDevice.RemoveAt(index);
					this.DevicePnPHandler(new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs
					{
						PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached,
						RadioInfoSet = 
						{
							tetraRadioProfile
						}
					});
					string log2 = "Tetra Portable Device removed!";
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.Path, log2);
				}
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00007B60 File Offset: 0x00005D60
		private bool GetInfoForMassStorageRadio(string drvName, bool bAttach, ref global::Motorola.Common.Communication.IRadioProfile radioInfo)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = radioInfo as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			bool result = false;
			string text = string.Empty;
			global::Motorola.Common.Communication.TetraUtility.MassStorageSwitchItem massStorageSwitchItem = null;
			global::System.IO.DriveInfo driveInfo = new global::System.IO.DriveInfo(drvName);
			if (driveInfo.DriveType == global::System.IO.DriveType.Removable || driveInfo.DriveType == global::System.IO.DriveType.NoRootDirectory)
			{
				if (bAttach)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Find mass-storage device attach: " + drvName);
				}
				else
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Find mass-storage device remove: " + drvName);
				}
				tetraRadioProfile.PreAttached = false;
				string name = driveInfo.RootDirectory.Name;
				if (bAttach)
				{
					if (!global::Motorola.Common.Communication.TetraUtility.TetraUtil.IsAragornMassStorageDisk(drvName))
					{
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Attached removable device is not a TETRA radio:" + drvName);
						return false;
					}
					try
					{
						string path = global::System.IO.Path.Combine(driveInfo.Name, "tei.txt");
						if (global::System.IO.File.Exists(path))
						{
							using (global::System.IO.StreamReader streamReader = global::System.IO.File.OpenText(path))
							{
								string text2 = streamReader.ReadToEnd();
								if (text2.Length >= 15)
								{
									text = text2.Substring(0, 15);
									massStorageSwitchItem = global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.MsSwitchInfo.FindMassStorageSwitchInfo(text);
									if (massStorageSwitchItem != null)
									{
										massStorageSwitchItem.DiskName = drvName;
									}
								}
								else
								{
									global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Invalid TEI information in tei.txt:" + text2);
								}
								streamReader.Close();
							}
						}
						goto IL_180;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Got exception in GetInfoForMassStorageRadio:" + ex.Message);
						return false;
					}
				}
				massStorageSwitchItem = global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.MsSwitchInfo.FindMassStorageSwitchInfoByDiskName(drvName);
				if (massStorageSwitchItem != null)
				{
					text = massStorageSwitchItem.TEI;
				}
				IL_180:
				if (bAttach && massStorageSwitchItem == null)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Automatically switch mass-storage radio to PEI mode");
					global::Motorola.Common.Communication.TetraUtility.TetraUtil.EjectMassStorageDevice(drvName, 10);
					return false;
				}
				if (string.IsNullOrEmpty(text))
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("No TEI for mass storage device");
					return false;
				}
				tetraRadioProfile.DeviceInstanceID = text;
				if (massStorageSwitchItem == null)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("Cannot find switch mode info for mass storage radio");
					return false;
				}
				tetraRadioProfile.PhysicalLocation = massStorageSwitchItem.PhysicalLocation;
				tetraRadioProfile.RadioId = global::System.Text.Encoding.ASCII.GetBytes(massStorageSwitchItem.CpuID);
				tetraRadioProfile.TetraRadioType = global::Motorola.Common.Communication.CommonUtil.TetraRadioType.NORMAL;
				tetraRadioProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.MASS_STORAGE;
				tetraRadioProfile.Path = driveInfo.Name;
				tetraRadioProfile.DevInstanceNum = 0U;
				tetraRadioProfile.NGCHDevicePart = global::Motorola.Common.Communication.TetraUtility.NGCHDeviceComponent.UnKnown;
				tetraRadioProfile.FrodoDataBoxPart = global::Motorola.Common.Communication.CommonUtil.FrodoDataBoxComponent.UnKnown;
				tetraRadioProfile.ParentDeviceInstanceID = string.Empty;
				tetraRadioProfile.ParentDevInstanceNum = 0U;
				tetraRadioProfile.UniqueLocation = massStorageSwitchItem.UniqueLocation;
				tetraRadioProfile.PID = "MASS_STORAGE_RADIO";
				tetraRadioProfile.VID = "0CAD";
				tetraRadioProfile.USBHubInstance = massStorageSwitchItem.ComPortPath;
				tetraRadioProfile.USBHubPortNumber = 0U;
				result = true;
				string log = string.Empty;
				if (bAttach)
				{
					log = "Mass-storage radio attached, DiskName is: " + tetraRadioProfile.Path + ", location is: " + tetraRadioProfile.UniqueLocation;
				}
				else
				{
					global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.MsSwitchInfo.RemoveRadioForMassStorageSwitch(text);
					log = "Mass-storage radio removed, DiskName is: " + tetraRadioProfile.Path + ", location is: " + tetraRadioProfile.UniqueLocation;
				}
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(tetraRadioProfile.USBHubInstance, log);
			}
			else
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("The drive attached is not a removable device");
			}
			return result;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00007E8C File Offset: 0x0000608C
		protected override bool ExtractRadioInformationHelper(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg, ref global::Motorola.Common.Communication.IRadioProfile radioInfo)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = radioInfo as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			if (tetraRadioProfile == null)
			{
				return false;
			}
			bool result = false;
			bool flag = true;
			global::System.IntPtr zero = global::System.IntPtr.Zero;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA devInfoData = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA);
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA sp_DEVICE_INTERFACE_DATA = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA);
			string text = string.Empty;
			string empty = string.Empty;
			string empty2 = string.Empty;
			uint devID = 0U;
			orgPnPMsg.sDeviceName = orgPnPMsg.sDeviceName.ToUpperInvariant();
			tetraRadioProfile.DeviceName = orgPnPMsg.sDeviceName;
			string sDeviceName = orgPnPMsg.sDeviceName;
			int num = sDeviceName.IndexOf("VID_", global::System.StringComparison.OrdinalIgnoreCase);
			tetraRadioProfile.VID = sDeviceName.Substring(num + 4, 4);
			num = sDeviceName.IndexOf("PID_", global::System.StringComparison.OrdinalIgnoreCase);
			tetraRadioProfile.PID = sDeviceName.Substring(num + 4, 4);
			if (!tetraRadioProfile.VID.ToUpperInvariant().Equals("0CAD"))
			{
				return false;
			}
			global::System.Diagnostics.Trace.WriteLine("Detected a motorola vcom radio - PID : " + tetraRadioProfile.PID);
			if (orgPnPMsg.sDeviceName.Contains(base._radioClass.ToString().ToUpperInvariant()))
			{
				base._devClass = base._radioClass;
				global::System.Guid devClass = base._devClass;
				if (!base.NativeAPISet.WrapperSetupDiGetClassDevs(ref zero, ref devClass, global::System.IntPtr.Zero))
				{
					base._devClass = devClass;
					flag = false;
					if (zero != global::System.IntPtr.Zero)
					{
						base.NativeAPISet.WrapperSetupDiDestroyDeviceInfoList(zero);
					}
				}
				if (flag)
				{
					devInfoData.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA));
					sp_DEVICE_INTERFACE_DATA.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA));
					text = global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.GetDevCurrentLocationFromDevName(orgPnPMsg.sDeviceName);
					text = text.ToUpperInvariant();
				}
				if (flag)
				{
					global::System.Guid devClass2 = base._devClass;
					int num2 = 0;
					while (base.NativeAPISet.WrapperSetupDiEnumDeviceInterfaces(zero, (uint)num2, ref sp_DEVICE_INTERFACE_DATA, ref devClass2))
					{
						base._devClass = devClass2;
						int num3 = 0;
						uint num4 = 0U;
						if (base.NativeAPISet.WrapperSetupDiGetDeviceInterfaceDetail(zero, ref sp_DEVICE_INTERFACE_DATA, global::System.IntPtr.Zero, 0U, out num4, ref devInfoData, out num3) && base.NativeAPISet.WrapperSetupDiGetDeviceInstanceId(zero, devInfoData, ref empty, 1024) && empty.IndexOf(text, global::System.StringComparison.OrdinalIgnoreCase) != -1)
						{
							tetraRadioProfile.DeviceInstanceID = empty;
							uint num5 = 0U;
							if (!base.NativeAPISet.Wrapper_CM_Get_Parent(devInfoData.DevInst, ref num5))
							{
								break;
							}
							tetraRadioProfile.InstanceId = devInfoData.DevInst;
							tetraRadioProfile.DevInstanceNum = devInfoData.DevInst;
							tetraRadioProfile.ParentDevInstanceNum = num5;
							string empty3 = string.Empty;
							if (!base.NativeAPISet.Wrapper_CM_Get_Device_ID(num5, ref empty3))
							{
								break;
							}
							tetraRadioProfile.ParentDeviceInstanceID = empty3;
							tetraRadioProfile.PhysicalLocation = global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.GetPhysicalLocationFromDeviceInstance(empty3);
							if (orgPnPMsg.sDeviceName.IndexOf("PID_9006", global::System.StringComparison.OrdinalIgnoreCase) != -1 || orgPnPMsg.sDeviceName.IndexOf("PID_9011", global::System.StringComparison.OrdinalIgnoreCase) != -1 || orgPnPMsg.sDeviceName.IndexOf("PID_9013", global::System.StringComparison.OrdinalIgnoreCase) != -1 || orgPnPMsg.sDeviceName.IndexOf("PID_9012", global::System.StringComparison.OrdinalIgnoreCase) != -1)
							{
								uint num6 = 0U;
								if (!base.NativeAPISet.Wrapper_CM_Get_Parent(devInfoData.DevInst, ref num6) || !base.NativeAPISet.Wrapper_CM_Get_Parent(num6, ref num6))
								{
									break;
								}
								tetraRadioProfile.CompositeDeviceNumber = num6;
								if (!base.NativeAPISet.Wrapper_CM_Get_Parent(tetraRadioProfile.CompositeDeviceNumber, ref devID))
								{
									break;
								}
								string empty4 = string.Empty;
								if (!base.NativeAPISet.Wrapper_CM_Get_Device_ID(tetraRadioProfile.CompositeDeviceNumber, ref empty4))
								{
									break;
								}
								uint usbhubPortNumber = 0U;
								if (!this.GetUsbHubPortNumberFromeDeviceInstance(empty4, out usbhubPortNumber))
								{
									break;
								}
								tetraRadioProfile.USBHubPortNumber = usbhubPortNumber;
								empty4 = string.Empty;
								if (!base.NativeAPISet.Wrapper_CM_Get_Device_ID(devID, ref empty4))
								{
									break;
								}
								tetraRadioProfile.USBHubInstance = empty4;
							}
							else
							{
								tetraRadioProfile.CompositeDeviceNumber = 0U;
								if (!base.NativeAPISet.Wrapper_CM_Get_Parent(num5, ref devID))
								{
									break;
								}
								string empty5 = string.Empty;
								if (!base.NativeAPISet.Wrapper_CM_Get_Device_ID(devID, ref empty5))
								{
									break;
								}
								tetraRadioProfile.USBHubInstance = empty5;
								uint usbhubPortNumber2 = 0U;
								if (!this.GetUsbHubPortNumberFromeDeviceInstance(tetraRadioProfile.ParentDeviceInstanceID, out usbhubPortNumber2))
								{
									break;
								}
								tetraRadioProfile.USBHubPortNumber = usbhubPortNumber2;
							}
							global::System.IntPtr zero2 = global::System.IntPtr.Zero;
							if (!base.NativeAPISet.WrapperSetupDiOpenDevRegKey(zero, ref devInfoData, ref zero2))
							{
								break;
							}
							string empty6 = string.Empty;
							if (!base.NativeAPISet.WrapperRegQueryVComName(zero2, ref empty6))
							{
								base.NativeAPISet.WrapperRegCloseKey(zero2);
								zero2 = global::System.IntPtr.Zero;
								break;
							}
							tetraRadioProfile.Path = empty6;
							uint usbdataEPMaxTransSize = 0U;
							global::Motorola.Common.Communication.TetraUtility.USBDiagnose.GetEP1Size(tetraRadioProfile.USBHubInstance, tetraRadioProfile.USBHubPortNumber, tetraRadioProfile.Path, out usbdataEPMaxTransSize);
							tetraRadioProfile.USBDataEPMaxTransSize = usbdataEPMaxTransSize;
							base.NativeAPISet.WrapperRegCloseKey(zero2);
							zero2 = global::System.IntPtr.Zero;
							if (tetraRadioProfile.DeviceInstanceID.IndexOf("VID_0CAD", global::System.StringComparison.OrdinalIgnoreCase) == -1)
							{
								break;
							}
							tetraRadioProfile.VID = "0CAD";
							if (tetraRadioProfile.DeviceInstanceID.IndexOf("PID_9006", global::System.StringComparison.OrdinalIgnoreCase) != -1 || tetraRadioProfile.DeviceInstanceID.IndexOf("PID_0100", global::System.StringComparison.OrdinalIgnoreCase) != -1 || tetraRadioProfile.DeviceInstanceID.IndexOf("PID_9003", global::System.StringComparison.OrdinalIgnoreCase) != -1 || tetraRadioProfile.DeviceInstanceID.IndexOf("PID_9010", global::System.StringComparison.OrdinalIgnoreCase) != -1 || tetraRadioProfile.DeviceInstanceID.IndexOf("PID_9011", global::System.StringComparison.OrdinalIgnoreCase) != -1 || tetraRadioProfile.DeviceInstanceID.IndexOf("PID_9013", global::System.StringComparison.OrdinalIgnoreCase) != -1 || tetraRadioProfile.DeviceInstanceID.IndexOf("PID_9012", global::System.StringComparison.OrdinalIgnoreCase) != -1)
							{
								tetraRadioProfile.UniqueLocation = string.Empty;
								if (tetraRadioProfile.DeviceInstanceID.IndexOf("PID_9006", global::System.StringComparison.OrdinalIgnoreCase) != -1)
								{
									tetraRadioProfile.PID = "9006";
									if (tetraRadioProfile.DeviceInstanceID.IndexOf("MI_00", global::System.StringComparison.OrdinalIgnoreCase) != -1)
									{
										tetraRadioProfile.NGCHDevicePart = global::Motorola.Common.Communication.TetraUtility.NGCHDeviceComponent.ControlHead;
									}
									else if (tetraRadioProfile.DeviceInstanceID.IndexOf("MI_01", global::System.StringComparison.OrdinalIgnoreCase) != -1)
									{
										tetraRadioProfile.NGCHDevicePart = global::Motorola.Common.Communication.TetraUtility.NGCHDeviceComponent.Transceiver;
									}
									else
									{
										tetraRadioProfile.NGCHDevicePart = global::Motorola.Common.Communication.TetraUtility.NGCHDeviceComponent.UnKnown;
									}
									if (!base.NativeAPISet.Wrapper_CM_Get_Device_ID(tetraRadioProfile.CompositeDeviceNumber, ref empty2))
									{
										break;
									}
									if (!string.IsNullOrEmpty(empty2))
									{
										tetraRadioProfile.UniqueLocation = global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.GetPhysicalLocationFromDeviceInstance(empty2);
									}
								}
								else if (tetraRadioProfile.DeviceInstanceID.IndexOf("PID_9010", global::System.StringComparison.OrdinalIgnoreCase) != -1)
								{
									tetraRadioProfile.PID = "9010";
								}
								else if (tetraRadioProfile.DeviceInstanceID.IndexOf("PID_0100", global::System.StringComparison.OrdinalIgnoreCase) != -1)
								{
									tetraRadioProfile.PID = "0100";
								}
								else if (tetraRadioProfile.DeviceInstanceID.IndexOf("9011", global::System.StringComparison.OrdinalIgnoreCase) != -1)
								{
									tetraRadioProfile.PID = "9011";
									if (tetraRadioProfile.DeviceInstanceID.IndexOf("MI_00", global::System.StringComparison.OrdinalIgnoreCase) != -1)
									{
										tetraRadioProfile.FrodoDataBoxPart = global::Motorola.Common.Communication.CommonUtil.FrodoDataBoxComponent.Port1;
									}
									else if (tetraRadioProfile.DeviceInstanceID.IndexOf("MI_01", global::System.StringComparison.OrdinalIgnoreCase) != -1)
									{
										tetraRadioProfile.FrodoDataBoxPart = global::Motorola.Common.Communication.CommonUtil.FrodoDataBoxComponent.Port2;
									}
									else
									{
										tetraRadioProfile.FrodoDataBoxPart = global::Motorola.Common.Communication.CommonUtil.FrodoDataBoxComponent.UnKnown;
									}
									if (!base.NativeAPISet.Wrapper_CM_Get_Device_ID(tetraRadioProfile.CompositeDeviceNumber, ref empty2))
									{
										break;
									}
								}
								else if (tetraRadioProfile.DeviceInstanceID.IndexOf("9013", global::System.StringComparison.OrdinalIgnoreCase) != -1 || tetraRadioProfile.DeviceInstanceID.IndexOf("9012", global::System.StringComparison.OrdinalIgnoreCase) != -1)
								{
									if (tetraRadioProfile.DeviceInstanceID.IndexOf("9013", global::System.StringComparison.OrdinalIgnoreCase) != -1)
									{
										tetraRadioProfile.PID = "9013";
									}
									else
									{
										tetraRadioProfile.PID = "9012";
									}
									if (tetraRadioProfile.DeviceInstanceID.IndexOf("MI_00", global::System.StringComparison.OrdinalIgnoreCase) != -1)
									{
										tetraRadioProfile.FrodoDataBoxPart = global::Motorola.Common.Communication.CommonUtil.FrodoDataBoxComponent.Port1;
									}
									else if (tetraRadioProfile.DeviceInstanceID.IndexOf("MI_01", global::System.StringComparison.OrdinalIgnoreCase) != -1)
									{
										tetraRadioProfile.FrodoDataBoxPart = global::Motorola.Common.Communication.CommonUtil.FrodoDataBoxComponent.Port2;
									}
									else
									{
										tetraRadioProfile.FrodoDataBoxPart = global::Motorola.Common.Communication.CommonUtil.FrodoDataBoxComponent.UnKnown;
									}
									if (!base.NativeAPISet.Wrapper_CM_Get_Device_ID(tetraRadioProfile.CompositeDeviceNumber, ref empty2))
									{
										break;
									}
								}
								else
								{
									tetraRadioProfile.PID = "9003";
								}
								if (tetraRadioProfile.DeviceInstanceID.IndexOf("PID_9006", global::System.StringComparison.OrdinalIgnoreCase) == -1 && tetraRadioProfile.DeviceInstanceID.IndexOf("PID_9011", global::System.StringComparison.OrdinalIgnoreCase) == -1 && tetraRadioProfile.DeviceInstanceID.IndexOf("PID_9013", global::System.StringComparison.OrdinalIgnoreCase) == -1 && tetraRadioProfile.DeviceInstanceID.IndexOf("PID_9012", global::System.StringComparison.OrdinalIgnoreCase) == -1)
								{
									tetraRadioProfile.UniqueLocation = tetraRadioProfile.PhysicalLocation;
								}
								else if (!string.IsNullOrEmpty(empty2))
								{
									tetraRadioProfile.UniqueLocation = global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.GetPhysicalLocationFromDeviceInstance(empty2);
								}
								result = true;
								break;
							}
							break;
						}
						else
						{
							num2++;
						}
					}
				}
				base.NativeAPISet.WrapperSetupDiDestroyDeviceInfoList(zero);
				return result;
			}
			return false;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00008675 File Offset: 0x00006875
		protected override bool ExtractRadioInformation(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg, ref global::Motorola.Common.Communication.IRadioProfile radioInfo)
		{
			(radioInfo as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).PreAttached = orgPnPMsg.isPreAttached;
			return this.ExtractRadioInformationHelper(orgPnPMsg, ref radioInfo);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00008694 File Offset: 0x00006894
		public override bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = pnpMsg.radioProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile;
			if (pnpMsg.isSimulated && tetraRadioProfile == null)
			{
				return false;
			}
			base.DeviceChanged(pnpMsg);
			return true;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000086C4 File Offset: 0x000068C4
		private bool FindPartner(global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile radioInfo, ref int findPosition)
		{
			bool result = false;
			global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = new global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile();
			for (int i = 0; i < base._currentExistDevice.Count; i++)
			{
				tetraRadioProfile = (global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile)base._currentExistDevice[i];
				if (radioInfo.CompositeDeviceNumber == tetraRadioProfile.CompositeDeviceNumber && !string.Equals(tetraRadioProfile.DeviceInstanceID, radioInfo.DeviceInstanceID, global::System.StringComparison.OrdinalIgnoreCase))
				{
					result = true;
					findPosition = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000872C File Offset: 0x0000692C
		private bool IsValidRadioInfo(global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile radioInfo)
		{
			bool result = true;
			if (string.IsNullOrEmpty(radioInfo.DeviceInstanceID) || string.IsNullOrEmpty(radioInfo.Path) || string.IsNullOrEmpty(radioInfo.ParentDeviceInstanceID) || string.IsNullOrEmpty(radioInfo.PhysicalLocation) || string.IsNullOrEmpty(radioInfo.PID) || string.IsNullOrEmpty(radioInfo.UniqueLocation) || string.IsNullOrEmpty(radioInfo.USBHubInstance) || string.IsNullOrEmpty(radioInfo.VID))
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000087A8 File Offset: 0x000069A8
		private bool GetUsbHubPortNumberFromeDeviceInstance(string instance_id, out uint portNum)
		{
			bool flag = true;
			portNum = 0U;
			if (string.IsNullOrEmpty(instance_id))
			{
				flag = false;
			}
			if (flag)
			{
				try
				{
					string value = instance_id.Substring(instance_id.LastIndexOf('&') + 1);
					portNum = global::System.Convert.ToUInt32(value);
				}
				catch
				{
					portNum = 0U;
				}
			}
			return flag;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000087FC File Offset: 0x000069FC
		private global::Motorola.Common.Communication.CommonUtil.TetraRadioType GetRadioType(global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile hwProfile)
		{
			global::Motorola.Common.Communication.CommonUtil.TetraRadioType result = global::Motorola.Common.Communication.CommonUtil.TetraRadioType.NORMAL;
			if (hwProfile.FrodoDataBoxPart == global::Motorola.Common.Communication.CommonUtil.FrodoDataBoxComponent.Port1)
			{
				result = global::Motorola.Common.Communication.CommonUtil.TetraRadioType.DATABOX_PORT1;
			}
			else if (hwProfile.FrodoDataBoxPart == global::Motorola.Common.Communication.CommonUtil.FrodoDataBoxComponent.Port2)
			{
				result = global::Motorola.Common.Communication.CommonUtil.TetraRadioType.DATABOX_PORT2;
			}
			else if (hwProfile.NGCHDevicePart == global::Motorola.Common.Communication.TetraUtility.NGCHDeviceComponent.ControlHead)
			{
				result = global::Motorola.Common.Communication.CommonUtil.TetraRadioType.CONTROL_HEAD;
			}
			else if (hwProfile.NGCHDevicePart == global::Motorola.Common.Communication.TetraUtility.NGCHDeviceComponent.Transceiver)
			{
				result = global::Motorola.Common.Communication.CommonUtil.TetraRadioType.TRANSCEIVER;
			}
			return result;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000883C File Offset: 0x00006A3C
		private global::Motorola.Common.Communication.DeviceDiscovery.VCOMDetector.PnPThreadItem GetPnPThreadItem(string location)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.VCOMDetector.PnPThreadItem result;
			lock (this._pnpThreadList)
			{
				if (string.IsNullOrEmpty(location))
				{
					result = null;
				}
				else
				{
					foreach (global::Motorola.Common.Communication.DeviceDiscovery.VCOMDetector.PnPThreadItem pnPThreadItem in this._pnpThreadList)
					{
						if (pnPThreadItem.Location == location)
						{
							return pnPThreadItem;
						}
					}
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000088D4 File Offset: 0x00006AD4
		private void AddPnPThreadEvent(global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs e)
		{
			lock (this._pnpThreadList)
			{
				if (e == null || e.RadioInfoSet.Count == 0)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("DeviceManager::AddPnPThreadEvent: No radio info in PnPMsgEventArgs.");
				}
				else
				{
					foreach (global::Motorola.Common.Communication.DeviceDiscovery.VCOMDetector.PnPThreadItem pnPThreadItem in this._pnpThreadList)
					{
						if (pnPThreadItem.Location == ((global::Motorola.Common.Communication.IRadioProfile)e.RadioInfoSet[0]).UniqueLocation)
						{
							pnPThreadItem.EventList.Enqueue(e);
						}
					}
				}
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000089A0 File Offset: 0x00006BA0
		private void AddPnPThreadinList(global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs e)
		{
			lock (this._pnpThreadList)
			{
				if (e == null || e.RadioInfoSet.Count == 0)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("DeviceManager::AddPnPThreadinList: No radio info in PnPMsgEventArgs.");
				}
				else
				{
					global::Motorola.Common.Communication.DeviceDiscovery.VCOMDetector.PnPThreadItem pnPThreadItem = new global::Motorola.Common.Communication.DeviceDiscovery.VCOMDetector.PnPThreadItem();
					pnPThreadItem.Location = ((global::Motorola.Common.Communication.IRadioProfile)e.RadioInfoSet[0]).UniqueLocation;
					pnPThreadItem.EventList.Enqueue(e);
					pnPThreadItem.IsBusy = false;
					this._pnpThreadList.Add(pnPThreadItem);
				}
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00008A44 File Offset: 0x00006C44
		private void PnPThread(object sender, global::System.ComponentModel.DoWorkEventArgs e)
		{
			for (;;)
			{
				e.Result = e.Argument;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs;
				lock (this._pnpThreadList)
				{
					global::Motorola.Common.Communication.DeviceDiscovery.VCOMDetector.PnPThreadItem pnPThreadItem = this.GetPnPThreadItem((string)e.Argument);
					if (pnPThreadItem == null)
					{
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("DeviceManager::PnPThread: PnPThread is created but can not be found in PnPThreadList.");
						break;
					}
					if (pnPThreadItem.EventList.Count == 0)
					{
						pnPThreadItem.IsBusy = false;
						break;
					}
					deviceMsgEventArgs = pnPThreadItem.EventList.Dequeue();
				}
				if (deviceMsgEventArgs.PnPAction == global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached)
				{
					this.eventBag.Invoke("DeviceAttached", new object[]
					{
						this,
						deviceMsgEventArgs
					});
				}
				else if (deviceMsgEventArgs.PnPAction == global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached)
				{
					this.eventBag.Invoke("DeviceDetached", new object[]
					{
						this,
						deviceMsgEventArgs
					});
				}
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00008B44 File Offset: 0x00006D44
		private void PnPComplete(object sender, global::System.ComponentModel.RunWorkerCompletedEventArgs ev)
		{
			if (ev.Error != null)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("DeviceManager: Radio operation exception happened in backgroundworker: " + (string)ev.Result);
				return;
			}
			if (ev.Cancelled)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("DeviceManager: Radio operation cancelled in backgroundworker: " + (string)ev.Result);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00008BAC File Offset: 0x00006DAC
		private void DevicePnPHandler(global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs e)
		{
			lock (this._pnpThreadList)
			{
				if (e == null || e.RadioInfoSet.Count == 0)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("DeviceManager::DevicePnPHandler: No radio info in PnPMsgEventArgs.");
				}
				else
				{
					global::Motorola.Common.Communication.DeviceDiscovery.VCOMDetector.PnPThreadItem pnPThreadItem = this.GetPnPThreadItem(((global::Motorola.Common.Communication.IRadioProfile)e.RadioInfoSet[0]).UniqueLocation);
					if (pnPThreadItem != null)
					{
						this.AddPnPThreadEvent(e);
					}
					else
					{
						this.AddPnPThreadinList(e);
					}
					pnPThreadItem = this.GetPnPThreadItem(((global::Motorola.Common.Communication.IRadioProfile)e.RadioInfoSet[0]).UniqueLocation);
					if (pnPThreadItem != null && !pnPThreadItem.IsBusy)
					{
						pnPThreadItem.BackgroundWorker = new global::Motorola.Common.Communication.TetraUtility.CultureSafeBackGroundWorker();
						pnPThreadItem.BackgroundWorker.DoWork += this.PnPThread;
						pnPThreadItem.BackgroundWorker.RunWorkerCompleted += this.PnPComplete;
						pnPThreadItem.IsBusy = true;
						pnPThreadItem.BackgroundWorker.RunWorkerAsync(((global::Motorola.Common.Communication.IRadioProfile)e.RadioInfoSet[0]).UniqueLocation);
					}
				}
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00008CC8 File Offset: 0x00006EC8
		private bool Contains(global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile radioInfo)
		{
			bool result = false;
			foreach (object obj in base._currentExistDevice)
			{
				global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile tetraRadioProfile = (global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile)obj;
				if (string.Equals(tetraRadioProfile.DeviceInstanceID, radioInfo.DeviceInstanceID, global::System.StringComparison.InvariantCultureIgnoreCase))
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x040000D6 RID: 214
		private const string EN_DEV_ATTACHED = "DeviceAttached";

		// Token: 0x040000D7 RID: 215
		private const string EN_DEV_DETACHED = "DeviceDetached";

		// Token: 0x040000D8 RID: 216
		private global::Motorola.Common.Communication.IRadioProfile _removedMTM800EPart = new global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile();

		// Token: 0x040000D9 RID: 217
		private global::Motorola.Common.Communication.TetraUtility.ThreadSafeEventHandlerBag eventBag = new global::Motorola.Common.Communication.TetraUtility.ThreadSafeEventHandlerBag(true, false);

		// Token: 0x040000DA RID: 218
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.VCOMDetector.PnPThreadItem> _pnpThreadList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.VCOMDetector.PnPThreadItem>();

		// Token: 0x02000029 RID: 41
		private class PnPThreadItem
		{
			// Token: 0x1700006D RID: 109
			// (get) Token: 0x0600019D RID: 413 RVA: 0x00008D3C File Offset: 0x00006F3C
			// (set) Token: 0x0600019E RID: 414 RVA: 0x00008D44 File Offset: 0x00006F44
			public string Location
			{
				get
				{
					return this._location;
				}
				set
				{
					this._location = value;
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x0600019F RID: 415 RVA: 0x00008D4D File Offset: 0x00006F4D
			public global::System.Collections.Generic.Queue<global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs> EventList
			{
				get
				{
					return this._eventList;
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x060001A0 RID: 416 RVA: 0x00008D55 File Offset: 0x00006F55
			// (set) Token: 0x060001A1 RID: 417 RVA: 0x00008D5D File Offset: 0x00006F5D
			public global::Motorola.Common.Communication.TetraUtility.CultureSafeBackGroundWorker BackgroundWorker
			{
				get
				{
					return this._bw;
				}
				set
				{
					this._bw = value;
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x060001A2 RID: 418 RVA: 0x00008D66 File Offset: 0x00006F66
			// (set) Token: 0x060001A3 RID: 419 RVA: 0x00008D6E File Offset: 0x00006F6E
			public bool IsBusy
			{
				get
				{
					return this._isBusy;
				}
				set
				{
					this._isBusy = value;
				}
			}

			// Token: 0x040000DB RID: 219
			private string _location = string.Empty;

			// Token: 0x040000DC RID: 220
			private global::System.Collections.Generic.Queue<global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs> _eventList = new global::System.Collections.Generic.Queue<global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs>();

			// Token: 0x040000DD RID: 221
			private global::Motorola.Common.Communication.TetraUtility.CultureSafeBackGroundWorker _bw;

			// Token: 0x040000DE RID: 222
			private bool _isBusy;
		}
	}
}
