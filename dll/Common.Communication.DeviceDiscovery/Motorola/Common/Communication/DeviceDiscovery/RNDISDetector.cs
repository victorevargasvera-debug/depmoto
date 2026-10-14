using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000021 RID: 33
	public class RNDISDetector : global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase
	{
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060000F9 RID: 249 RVA: 0x0000622C File Offset: 0x0000442C
		// (remove) Token: 0x060000FA RID: 250 RVA: 0x00006264 File Offset: 0x00004464
		public override event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060000FB RID: 251 RVA: 0x0000629C File Offset: 0x0000449C
		// (remove) Token: 0x060000FC RID: 252 RVA: 0x000062D4 File Offset: 0x000044D4
		public override event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached;

		// Token: 0x060000FD RID: 253 RVA: 0x00006309 File Offset: 0x00004509
		public RNDISDetector()
		{
			base.DetectorType = global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType.RNDISDetector;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00006323 File Offset: 0x00004523
		protected override void InitDevClassGUIDList()
		{
			base._radioClass = new global::System.Guid(global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.NETADAPTOR_CLASS_INTERFACE);
			base.lstValidGuid.Add(base._radioClass);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00006348 File Offset: 0x00004548
		protected override void HandleDeviceAttached(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler = this.deviceAttached;
			global::Motorola.Common.Communication.IRadioProfile value = new global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile();
			if (this.ExtractRadioInformation(orgPnPMsg, ref value))
			{
				base._currentExistDevice.Add(value);
				if (deviceEventHandler != null)
				{
					deviceEventHandler(this, new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs
					{
						PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached,
						RadioInfoSet = 
						{
							value
						}
					});
				}
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000063A0 File Offset: 0x000045A0
		protected override void HandleDeviceDetached(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile rndisradioProfile = new global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile();
			bool flag = false;
			int index = 0;
			global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler = this.deviceDetached;
			string text = global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.GetDevCurrentLocationFromDevName(orgPnPMsg.sDeviceName);
			text = text.ToUpperInvariant();
			for (int i = 0; i < base._currentExistDevice.Count; i++)
			{
				rndisradioProfile = (global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile)base._currentExistDevice[i];
				if (rndisradioProfile.DeviceInstanceID.IndexOf(text, global::System.StringComparison.OrdinalIgnoreCase) != -1)
				{
					flag = true;
					index = i;
					break;
				}
			}
			if (flag)
			{
				base._currentExistDevice.RemoveAt(index);
				if (deviceEventHandler != null)
				{
					deviceEventHandler(this, new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs
					{
						PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached,
						RadioInfoSet = 
						{
							rndisradioProfile
						}
					});
				}
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00006454 File Offset: 0x00004654
		protected override bool ExtractRadioInformationHelper(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg, ref global::Motorola.Common.Communication.IRadioProfile radioInfo)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile rndisradioProfile = radioInfo as global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile;
			if (rndisradioProfile == null)
			{
				return false;
			}
			bool result = false;
			bool flag = true;
			global::System.IntPtr zero = global::System.IntPtr.Zero;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA devInfoData = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA);
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA sp_DEVICE_INTERFACE_DATA = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA);
			string text = "";
			string text2 = "";
			orgPnPMsg.sDeviceName = orgPnPMsg.sDeviceName.ToUpperInvariant();
			rndisradioProfile.DeviceName = orgPnPMsg.sDeviceName;
			string sDeviceName = orgPnPMsg.sDeviceName;
			int num = sDeviceName.IndexOf("VID_", global::System.StringComparison.OrdinalIgnoreCase);
			rndisradioProfile.VID = sDeviceName.Substring(num + 4, 4);
			num = sDeviceName.IndexOf("PID_", global::System.StringComparison.OrdinalIgnoreCase);
			rndisradioProfile.PID = sDeviceName.Substring(num + 4, 4);
			if (!rndisradioProfile.VID.ToUpperInvariant().Equals("0CAD"))
			{
				return false;
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Detected a motorola rndis radio - PID : " + rndisradioProfile.PID, new object[0]);
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
				base._devClass = devClass;
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
						if (base.NativeAPISet.WrapperSetupDiGetDeviceInterfaceDetail(zero, ref sp_DEVICE_INTERFACE_DATA, global::System.IntPtr.Zero, 0U, out num4, ref devInfoData, out num3) && base.NativeAPISet.WrapperSetupDiGetDeviceInstanceId(zero, devInfoData, ref text2, 1024) && text2.IndexOf(text, global::System.StringComparison.OrdinalIgnoreCase) != -1)
						{
							rndisradioProfile.DeviceInstanceID = text2;
							uint devID = 0U;
							if (!base.NativeAPISet.Wrapper_CM_Get_Parent(devInfoData.DevInst, ref devID))
							{
								break;
							}
							rndisradioProfile.InstanceId = devInfoData.DevInst;
							string parentDeviceInstanceID = "";
							if (base.NativeAPISet.Wrapper_CM_Get_Device_ID(devID, ref parentDeviceInstanceID))
							{
								rndisradioProfile.ParentDeviceInstanceID = parentDeviceInstanceID;
								rndisradioProfile.PhysicalLocation = global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.GetPhysicalLocationFromDeviceInstance(text2);
								rndisradioProfile.UniqueLocation = rndisradioProfile.PhysicalLocation;
								this.GetRadioIPInformation(ref rndisradioProfile);
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
					base._devClass = devClass2;
				}
				base.NativeAPISet.WrapperSetupDiDestroyDeviceInfoList(zero);
				return result;
			}
			return false;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00006710 File Offset: 0x00004910
		public override bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile rndisradioProfile = pnpMsg.radioProfile as global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile;
			return (!pnpMsg.isSimulated || rndisradioProfile != null) && base.DeviceChanged(pnpMsg);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006740 File Offset: 0x00004940
		private bool GetRadioIPInformation(ref global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile)
		{
			bool flag = false;
			bool flag2 = true;
			global::System.IntPtr zero = global::System.IntPtr.Zero;
			global::System.IntPtr zero2 = global::System.IntPtr.Zero;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA sp_DEVINFO_DATA = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA);
			global::System.Guid guid = new global::System.Guid(global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.USB_NET_CLASS_INTERFACE);
			try
			{
				global::System.IntPtr enumerator = global::System.Runtime.InteropServices.Marshal.StringToHGlobalUni("USB");
				if (!base.NativeAPISet.WrapperSetupDiGetClassDevs(ref zero, ref guid, enumerator))
				{
					flag2 = false;
				}
				sp_DEVINFO_DATA.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA));
				if (flag2)
				{
					int num = 0;
					while (base.NativeAPISet.WrapperSetupDiEnumDeviceInfo(zero, (uint)num, ref sp_DEVINFO_DATA) && !flag)
					{
						string b = "";
						if (!base.NativeAPISet.Wrapper_CM_Get_Device_ID(sp_DEVINFO_DATA.DevInst, ref b))
						{
							break;
						}
						if (!(profile.DeviceInstanceID != b) && base.NativeAPISet.WrapperSetupDiOpenDevRegKey(zero, ref sp_DEVINFO_DATA, ref zero2, 2, 1))
						{
							string empty = string.Empty;
							if (!base.NativeAPISet.WrapperRegQueryValueEx(zero2, this._keyValueName, ref empty))
							{
								base.NativeAPISet.WrapperRegCloseKey(zero2);
								zero2 = global::System.IntPtr.Zero;
							}
							else
							{
								profile.NetCfgInstanceId = empty;
								base.NativeAPISet.WrapperRegCloseKey(zero2);
								zero2 = global::System.IntPtr.Zero;
								flag = true;
							}
						}
						num++;
					}
				}
			}
			catch (global::System.Exception arg)
			{
				global::System.Diagnostics.Trace.WriteLine("Exception in RNDISDetector::GetRadioIPInformation: " + arg);
			}
			finally
			{
				if (zero != global::System.IntPtr.Zero)
				{
					base.NativeAPISet.WrapperSetupDiDestroyDeviceInfoList(zero);
				}
			}
			return true;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000068DC File Offset: 0x00004ADC
		public static bool RetreiveDeviceIPAddress(ref global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile)
		{
			bool result = false;
			global::Motorola.Common.Communication.DeviceDiscovery.NetworkAdapterInfo networkAdapterInfo = global::Motorola.Common.Communication.DeviceDiscovery.RNDISDetector.RetreiveValidIpAddress(profile.NetCfgInstanceId);
			if (networkAdapterInfo != null)
			{
				profile.PortName = "8002";
				profile.DeviceDescription = networkAdapterInfo.Name;
				profile.MacAddress = networkAdapterInfo.MacAddress;
				profile.IPAddress = networkAdapterInfo.IPAddress;
				result = true;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Extract RNDIS device IP Address : {0} DhcpEnabled={1}", new object[]
				{
					profile.IPAddress,
					networkAdapterInfo.IsDhcpEnabled.ToString()
				});
			}
			else
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("RNDIS Device was not UP, waiting...", new object[0]);
				global::System.Threading.Thread.Sleep(1000);
			}
			return result;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00006984 File Offset: 0x00004B84
		private static global::Motorola.Common.Communication.DeviceDiscovery.NetworkAdapterInfo RetreiveValidIpAddress(string NetCfgInstanceId)
		{
			global::System.Net.NetworkInformation.NetworkInterface[] allNetworkInterfaces = global::System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
			foreach (global::System.Net.NetworkInformation.NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (networkInterface.Id == NetCfgInstanceId)
				{
					global::System.Net.NetworkInformation.IPInterfaceProperties ipproperties = networkInterface.GetIPProperties();
					if (networkInterface.Supports(global::System.Net.NetworkInformation.NetworkInterfaceComponent.IPv4))
					{
						global::System.Net.NetworkInformation.IPv4InterfaceProperties ipv4Properties = ipproperties.GetIPv4Properties();
						if (ipv4Properties != null)
						{
							global::Motorola.Common.Communication.DeviceDiscovery.NetworkAdapterInfo result;
							if (ipv4Properties.IsDhcpEnabled)
							{
								global::System.Net.NetworkInformation.IPAddressCollection dhcpServerAddresses = ipproperties.DhcpServerAddresses;
								if (dhcpServerAddresses.Count > 0 && dhcpServerAddresses[0].ToString() != "255.255.255.255" && dhcpServerAddresses[0].ToString() != "0.0.0.0")
								{
									result = new global::Motorola.Common.Communication.DeviceDiscovery.NetworkAdapterInfo(networkInterface.Name, networkInterface.GetPhysicalAddress().ToString(), dhcpServerAddresses[0].ToString(), true);
								}
								else
								{
									result = null;
								}
							}
							else
							{
								global::System.Net.NetworkInformation.GatewayIPAddressInformationCollection gatewayAddresses = ipproperties.GatewayAddresses;
								if (gatewayAddresses.Count > 0 && gatewayAddresses[0].Address.ToString() != "255.255.255.255" && gatewayAddresses[0].Address.ToString() != "0.0.0.0")
								{
									result = new global::Motorola.Common.Communication.DeviceDiscovery.NetworkAdapterInfo(networkInterface.Name, networkInterface.GetPhysicalAddress().ToString(), gatewayAddresses[0].Address.ToString(), false);
								}
								else
								{
									result = null;
								}
							}
							return result;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00006AF0 File Offset: 0x00004CF0
		[global::System.Security.Permissions.RegistryPermission(global::System.Security.Permissions.SecurityAction.Assert, Read = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters\\Interface")]
		private static global::Motorola.Common.Communication.DeviceDiscovery.NetworkAdapterInfo ReadNetworkInfoFromRegistry(string id)
		{
			global::Microsoft.Win32.RegistryKey registryKey = null;
			global::Motorola.Common.Communication.DeviceDiscovery.NetworkAdapterInfo result = null;
			string text = "SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters\\Interfaces\\" + id;
			try
			{
				registryKey = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(text);
				if (registryKey != null)
				{
					string text2 = (string)registryKey.GetValue("DhcpIPAddress");
					string text3 = (string)registryKey.GetValue("DhcpServer");
					if (text3 != null && text3 != "255.255.255.255" && text3 != "0.0.0.0" && text2 != null && text2 != "255.255.255.255" && text2 != "0.0.0.0")
					{
						string name = "";
						string text4 = "";
						global::Microsoft.Win32.RegistryKey registryKey2 = null;
						try
						{
							text4 = "SYSTEM\\CurrentControlSet\\Control\\Network\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\" + id + "\\Connection";
							registryKey2 = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(text4);
							if (registryKey2 != null)
							{
								name = (string)registryKey2.GetValue("Name");
							}
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Open Registry Key Failed: {0}, {1}", new object[]
							{
								text4,
								ex.Message
							});
						}
						finally
						{
							if (registryKey2 != null)
							{
								registryKey2.Close();
							}
						}
						result = new global::Motorola.Common.Communication.DeviceDiscovery.NetworkAdapterInfo(name, string.Empty, text3, true);
					}
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Open Registry Key Failed: {0}", new object[]
					{
						text
					});
				}
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Open Registry Key Failed: {0}, {1}", new object[]
				{
					text,
					ex2.Message
				});
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}

		// Token: 0x04000094 RID: 148
		private static readonly string USB_NET_CLASS_INTERFACE = "4D36E972-E325-11CE-BFC1-08002BE10318";

		// Token: 0x04000095 RID: 149
		private static readonly string NETADAPTOR_CLASS_INTERFACE = "AD498944-762F-11D0-8DCB-00C04FC3358C";

		// Token: 0x04000096 RID: 150
		private string _keyValueName = "NetCfgInstanceId";
	}
}
