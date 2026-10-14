using System;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000085 RID: 133
	public static class USBDiagnose
	{
		// Token: 0x0600032A RID: 810 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		public static bool GetEP1Size(string usbHubInstance, uint usbHubPortNumber, string logFileName, out uint ep1Size)
		{
			bool flag = true;
			ep1Size = 0U;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_NODE_CONNECTION_INFORMATION_EX usb_NODE_CONNECTION_INFORMATION_EX = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_NODE_CONNECTION_INFORMATION_EX);
			string empty = string.Empty;
			if (string.IsNullOrEmpty(usbHubInstance))
			{
				string log = "usb hub instance is null ---GetEP1Size---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log);
				}
				flag = false;
			}
			if (usbHubPortNumber == 0U)
			{
				string log2 = "usb hub portnumber mustn't be zero ---GetEP1Size---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log2);
				}
				flag = false;
			}
			if (flag)
			{
				flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.FindHub(usbHubInstance, logFileName, out empty);
			}
			if (flag)
			{
				flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.GetPortConnectionInformation(empty, usbHubPortNumber, logFileName, ref usb_NODE_CONNECTION_INFORMATION_EX);
			}
			if (flag)
			{
				if (usb_NODE_CONNECTION_INFORMATION_EX.PipeList.Length == 0)
				{
					flag = false;
				}
				else
				{
					ep1Size = (uint)usb_NODE_CONNECTION_INFORMATION_EX.PipeList[0].EndpointDescriptor.wMaxPacketSize;
				}
			}
			return flag;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000FF8C File Offset: 0x0000E18C
		public static bool GetUSBPortStatus(string usbHubInstance, uint usbHubPortNumber, string logFileName, out global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS status)
		{
			bool flag = true;
			string empty = string.Empty;
			status = global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.NoDeviceConnected;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_NODE_CONNECTION_INFORMATION_EX usb_NODE_CONNECTION_INFORMATION_EX = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_NODE_CONNECTION_INFORMATION_EX);
			if (string.IsNullOrEmpty(usbHubInstance))
			{
				string log = "usb hub instance is null ---GetUSBPortStatus---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log);
				}
				flag = false;
			}
			if (usbHubPortNumber == 0U)
			{
				string log2 = "usb hub portnumber mustn't be zero ---GetUSBPortStatus---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log2);
				}
				flag = false;
			}
			if (flag)
			{
				flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.FindHub(usbHubInstance, logFileName, out empty);
			}
			if (flag)
			{
				flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.GetPortConnectionInformation(empty, usbHubPortNumber, logFileName, ref usb_NODE_CONNECTION_INFORMATION_EX);
			}
			if (flag)
			{
				status = usb_NODE_CONNECTION_INFORMATION_EX.ConnectionStatus;
			}
			return flag;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00010010 File Offset: 0x0000E210
		public static bool IsFlashstrapRadio(string usbHubInstance, uint usbHubPortNumber, string logFileName, out bool result)
		{
			bool flag = true;
			string empty = string.Empty;
			string empty2 = string.Empty;
			result = false;
			if (string.IsNullOrEmpty(usbHubInstance))
			{
				string log = "usb hub instance is null ---IsFlashstrapRadio---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log);
				}
				flag = false;
			}
			if (usbHubPortNumber == 0U)
			{
				string log2 = "usb hub portnumber mustn't be zero ---IsFlashstrapRadio---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log2);
				}
				flag = false;
			}
			if (flag)
			{
				flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.FindHub(usbHubInstance, logFileName, out empty);
			}
			if (flag)
			{
				flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.GetUSBProductStringDescriptor(empty, usbHubPortNumber, logFileName, out empty2);
			}
			if (flag && empty2.Contains("TETRA FLASH programming loader"))
			{
				result = true;
			}
			return flag;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00010098 File Offset: 0x0000E298
		public static bool PowerCycleUSBPort(string usbHubInstance, uint usbHubPortNumber, string logFileName, out uint status)
		{
			bool flag = true;
			string empty = string.Empty;
			status = 0U;
			if (string.IsNullOrEmpty(usbHubInstance))
			{
				string log = "usb hub instance is null ---PowerCycleUSBPort---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log);
				}
				flag = false;
			}
			if (usbHubPortNumber == 0U)
			{
				string log2 = "usb hub portnumber mustn't be zero ---PowerCycleUSBPort---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log2);
				}
				flag = false;
			}
			if (flag)
			{
				flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.FindHub(usbHubInstance, logFileName, out empty);
			}
			if (flag)
			{
				flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.CyclePortPower(empty, usbHubPortNumber, logFileName, out status);
			}
			return flag;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00010104 File Offset: 0x0000E304
		public static bool SendUSBCtrlRequest(global::System.IntPtr fileHandle, global::System.IntPtr overlapped, string logFileName, byte[] command, byte[] replyData)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.DC_USB_CTRL_DATA structure = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DC_USB_CTRL_DATA);
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.DC_IOCTRL_DATA structure2 = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DC_IOCTRL_DATA);
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			global::System.IntPtr intPtr2 = global::System.IntPtr.Zero;
			global::System.IntPtr intPtr3 = global::System.IntPtr.Zero;
			if (command == null)
			{
				flag = false;
				string log = "usb command buffer is null ---SendUSBCtrlRequest ---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log);
				}
			}
			if (command.Length != 8)
			{
				flag = false;
				string log2 = "usb command buffer is invalid ---SendUSBCtrlRequest ---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log2);
				}
			}
			if (fileHandle == global::System.IntPtr.Zero)
			{
				flag = false;
				string log3 = "invalid file handler ---SendUSBCtrlRequest ---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log3);
				}
			}
			if (overlapped == global::System.IntPtr.Zero)
			{
				flag = false;
				string log4 = "invalid overlapped structure instance ---SendUSBCtrlRequest ---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log4);
				}
			}
			if (flag)
			{
				try
				{
					if (replyData != null)
					{
						intPtr3 = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(replyData.Length);
						structure.data_to_dev_ptr = (ulong)((long)intPtr3);
						structure.data_to_dev_len = (uint)replyData.Length;
					}
					else
					{
						structure.data_to_dev_len = 0U;
						structure.data_to_dev_ptr = 0UL;
					}
					int num = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DC_USB_CTRL_DATA));
					intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(num);
					global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.DC_USB_CTRL_DATA>(structure, intPtr, false);
					global::System.Runtime.InteropServices.Marshal.Copy(command, 0, intPtr, command.Length);
					structure2.data_in_ptr = (ulong)((long)intPtr);
					structure2.data_in_len = (uint)num;
					structure2.data_out_len = 0U;
					structure2.data_out_ptr = 0UL;
					structure2.status = 0;
					int num2 = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DC_IOCTRL_DATA));
					intPtr2 = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(num2);
					global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.DC_IOCTRL_DATA>(structure2, intPtr2, false);
					uint num3 = 0U;
					flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.Wrapper_DeviceIoControl(fileHandle, 2147492995U, intPtr2, (uint)num2, intPtr2, (uint)num2, out num3, overlapped);
					if (flag)
					{
						global::System.Runtime.InteropServices.Marshal.Copy((global::System.IntPtr)((long)structure.data_to_dev_ptr), replyData, 0, replyData.Length);
					}
					else
					{
						string log5 = "Failed to invoke DeviceIoControl ---SendUSBCtrlRequest ---";
						if (!string.IsNullOrEmpty(logFileName))
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log5);
						}
					}
				}
				catch (global::System.Exception ex)
				{
					string format = "Exception found when invoking ---SendUSBCtrlRequest ---" + ex.Message;
					if (!string.IsNullOrEmpty(logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, logFileName, format, new object[0]);
					}
					flag = false;
				}
				finally
				{
					if (intPtr3 != global::System.IntPtr.Zero)
					{
						global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr3);
					}
					if (intPtr != global::System.IntPtr.Zero)
					{
						global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
					}
					if (intPtr2 != global::System.IntPtr.Zero)
					{
						global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr2);
					}
				}
			}
			return flag;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00010378 File Offset: 0x0000E578
		public static bool ResetUSBPort(global::System.IntPtr fileHandle, global::System.IntPtr overlapped, string logFileName)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.DC_IOCTRL_DATA structure = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DC_IOCTRL_DATA);
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			if (fileHandle == global::System.IntPtr.Zero)
			{
				flag = false;
				string log = "invalid file handler ---ResetUSBPort---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log);
				}
			}
			if (overlapped == global::System.IntPtr.Zero)
			{
				flag = false;
				string log2 = "invalid overlapped structure instance ---ResetUSBPort---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log2);
				}
			}
			if (flag)
			{
				try
				{
					structure.data_in_ptr = 0UL;
					structure.data_in_len = 0U;
					structure.data_out_len = 0U;
					structure.data_out_ptr = 0UL;
					structure.status = 0;
					int num = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DC_IOCTRL_DATA));
					intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(num);
					global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.DC_IOCTRL_DATA>(structure, intPtr, false);
					uint num2 = 0U;
					flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.Wrapper_DeviceIoControl(fileHandle, 2147492899U, intPtr, (uint)num, intPtr, (uint)num, out num2, overlapped);
				}
				catch (global::System.Exception ex)
				{
					string format = "Exception found when invoking ---ResetUSBPort---" + ex.Message;
					if (!string.IsNullOrEmpty(logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, logFileName, format, new object[0]);
					}
					flag = false;
				}
				finally
				{
					if (intPtr != global::System.IntPtr.Zero)
					{
						global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
					}
				}
			}
			return flag;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000104B4 File Offset: 0x0000E6B4
		public static bool GetUSBBusBandwidth(int hcdNumber, string logFileName, out uint totalBusBandwidth, out uint total32secBandwidth)
		{
			bool flag = true;
			totalBusBandwidth = 0U;
			total32secBandwidth = 0U;
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			uint num = 0U;
			global::System.IntPtr intPtr2 = global::System.IntPtr.Zero;
			string lpFileName = string.Format("\\\\.\\HCD{0:d}", hcdNumber);
			try
			{
				flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperCreateFile(lpFileName, 1073741824U, 2U, 3U, 0U, ref intPtr);
				if (flag)
				{
					global::Motorola.Common.Communication.TetraUtility.NativeMethods.USBUSER_REQUEST_GET_USB_BANDWIDTH_INFO structure = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USBUSER_REQUEST_GET_USB_BANDWIDTH_INFO);
					int num2 = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USBUSER_REQUEST_GET_USB_BANDWIDTH_INFO));
					intPtr2 = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(num2);
					structure.UsbUserRequest = 5U;
					structure.RequestBufferLength = (uint)num2;
					global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.USBUSER_REQUEST_GET_USB_BANDWIDTH_INFO>(structure, intPtr2, false);
					flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.Wrapper_DeviceIoControl(intPtr, 2229304U, intPtr2, (uint)num2, intPtr2, (uint)num2, out num, global::System.IntPtr.Zero);
					if (flag)
					{
						global::Motorola.Common.Communication.TetraUtility.NativeMethods.USBUSER_REQUEST_GET_USB_BANDWIDTH_INFO usbuser_REQUEST_GET_USB_BANDWIDTH_INFO = (global::Motorola.Common.Communication.TetraUtility.NativeMethods.USBUSER_REQUEST_GET_USB_BANDWIDTH_INFO)global::System.Runtime.InteropServices.Marshal.PtrToStructure(intPtr2, typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USBUSER_REQUEST_GET_USB_BANDWIDTH_INFO));
						totalBusBandwidth = usbuser_REQUEST_GET_USB_BANDWIDTH_INFO.TotalBusBandwidth;
						total32secBandwidth = usbuser_REQUEST_GET_USB_BANDWIDTH_INFO.Total32secBandwidth;
					}
				}
			}
			catch (global::System.Exception ex)
			{
				string text = "Got exception during the period of getting usb bus bandwidth, the exception is: ";
				text += ex.Message;
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, logFileName, text, new object[0]);
				}
			}
			finally
			{
				if (intPtr2 != global::System.IntPtr.Zero)
				{
					global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr2);
					intPtr2 = global::System.IntPtr.Zero;
				}
				if (intPtr != global::System.IntPtr.Zero)
				{
					global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperCloseHandle(intPtr);
					intPtr = (global::System.IntPtr)(-1);
				}
			}
			return flag;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0001061C File Offset: 0x0000E81C
		public static string ConnectionStatusCodeToStr(global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS statusCode)
		{
			string result = string.Empty;
			switch (statusCode)
			{
			case global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.NoDeviceConnected:
				result = "NoDeviceConnected";
				break;
			case global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.DeviceConnected:
				result = "DeviceConnected";
				break;
			case global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.DeviceFailedEnumeration:
				result = "DeviceFailedEnumeration";
				break;
			case global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.DeviceGeneralFailure:
				result = "DeviceGeneralFailure";
				break;
			case global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.DeviceCausedOvercurrent:
				result = "DeviceCausedOvercurrent";
				break;
			case global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.DeviceNotEnoughPower:
				result = "DeviceNotEnoughPower";
				break;
			case global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.DeviceNotEnoughBandwidth:
				result = "DeviceNotEnoughBandwidth";
				break;
			case global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.DeviceHubNestedTooDeeply:
				result = "DeviceHubNestedTooDeeply";
				break;
			case global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.DeviceInLegacyHub:
				result = "DeviceInLegacyHub";
				break;
			case global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.DeviceEnumerating:
				result = "DeviceEnumerating";
				break;
			case global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.DeviceReset:
				result = "DeviceReset";
				break;
			default:
				result = "UnknowTypeError";
				break;
			}
			return result;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000106C4 File Offset: 0x0000E8C4
		private static bool FindHub(string hubInstance, string logFileName, out string devPath)
		{
			bool flag = true;
			devPath = string.Empty;
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			global::System.IntPtr zero = global::System.IntPtr.Zero;
			string text = string.Empty;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA devInfoData = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA);
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA sp_DEVICE_INTERFACE_DATA = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA);
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X86 structure = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X86);
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X64 structure2 = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X64);
			devInfoData.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA));
			sp_DEVICE_INTERFACE_DATA.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA));
			structure.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X86));
			structure2.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X64));
			if (!global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperSetupDiGetClassDevs(ref zero, ref global::Motorola.Common.Communication.TetraUtility.USBDiagnose._usbHubClass, global::System.IntPtr.Zero))
			{
				flag = false;
				if (zero != global::System.IntPtr.Zero)
				{
					global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperSetupDiDestroyDeviceInfoList(zero);
					zero = global::System.IntPtr.Zero;
				}
				string log = "Failed to invoke SetupDiGetClassDevs---FindHub---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log);
				}
			}
			if (flag)
			{
				flag = false;
				uint num = 0U;
				int num2 = 0;
				try
				{
					int num3 = 0;
					while (global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperSetupDiEnumDeviceInterfaces(zero, (uint)num3, ref sp_DEVICE_INTERFACE_DATA, ref global::Motorola.Common.Communication.TetraUtility.USBDiagnose._usbHubClass))
					{
						if (intPtr != global::System.IntPtr.Zero)
						{
							global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
							intPtr = global::System.IntPtr.Zero;
						}
						if (!global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperSetupDiGetDeviceInterfaceDetail(zero, ref sp_DEVICE_INTERFACE_DATA, global::System.IntPtr.Zero, 0U, out num, ref devInfoData, out num2))
						{
							string log2 = "Failed to get the information of SP_DEVICE_INTERFACE_DETAIL_DATA  in USBDiagnose.FindHub";
							if (!string.IsNullOrEmpty(logFileName))
							{
								global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log2);
							}
						}
						else
						{
							if (global::Motorola.Common.Communication.TetraUtility.USBDiagnose._OsBits == 64U)
							{
								uint cb = (uint)(global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X64)) + (int)num + 64);
								intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal((int)cb);
								global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X64>(structure2, intPtr, false);
							}
							else
							{
								uint cb = (uint)(global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X86)) + (int)num + 64);
								intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal((int)cb);
								global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X86>(structure, intPtr, false);
							}
							if (!global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperSetupDiGetDeviceInterfaceDetail(zero, ref sp_DEVICE_INTERFACE_DATA, intPtr, num + 64U, out num, ref devInfoData, out num2))
							{
								string log3 = "Failed to get the information of SP_DEVICE_INTERFACE_DETAIL_DATA  in USBDiagnose.FindHub";
								if (!string.IsNullOrEmpty(logFileName))
								{
									global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log3);
								}
							}
							else if (!global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperSetupDiGetDeviceInstanceId(zero, devInfoData, ref text, 1024))
							{
								string log4 = "Failed to get device instance ID in USBDiagnose.FindHub";
								if (!string.IsNullOrEmpty(logFileName))
								{
									global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log4);
								}
							}
							else
							{
								text = text.ToUpperInvariant();
								if (!(text != hubInstance))
								{
									devPath = ((global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA)global::System.Runtime.InteropServices.Marshal.PtrToStructure(intPtr, typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DETAIL_DATA))).DevicePath;
									if (!string.IsNullOrEmpty(logFileName))
									{
										global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, "Find The Hub");
									}
									flag = true;
									break;
								}
							}
						}
						num3++;
					}
				}
				catch (global::System.Exception ex)
				{
					string text2 = "Got exception during the period of getting hub path, the exception is: ";
					text2 += ex.Message;
					if (!string.IsNullOrEmpty(logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, logFileName, text2, new object[0]);
					}
				}
				finally
				{
					if (intPtr != global::System.IntPtr.Zero)
					{
						global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
						intPtr = global::System.IntPtr.Zero;
					}
					if (zero != global::System.IntPtr.Zero)
					{
						global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperSetupDiDestroyDeviceInfoList(zero);
						zero = global::System.IntPtr.Zero;
					}
				}
			}
			return flag;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000109EC File Offset: 0x0000EBEC
		private static bool GetPortConnectionInformation(string usbHubPath, uint portNum, string logFileName, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_NODE_CONNECTION_INFORMATION_EX nodeInfoEx)
		{
			bool flag = true;
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			global::System.IntPtr intPtr2 = global::System.IntPtr.Zero;
			uint num = 0U;
			if (string.IsNullOrEmpty(usbHubPath))
			{
				string log = "Radio instance is null ---GetPortConnectionInformation---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log);
				}
				flag = false;
			}
			if (portNum == 0U)
			{
				string log2 = "Hub port number must be >= 1 ---GetPortConnectionInformation---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log2);
				}
				flag = false;
			}
			if (flag)
			{
				try
				{
					nodeInfoEx.ConnectionIndex = portNum;
					intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_NODE_CONNECTION_INFORMATION_EX)));
					global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_NODE_CONNECTION_INFORMATION_EX>(nodeInfoEx, intPtr, false);
					flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperCreateFile(usbHubPath, 1073741824U, 2U, 3U, 0U, ref intPtr2);
					if (flag)
					{
						flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.Wrapper_DeviceIoControl(intPtr2, 2229320U, intPtr, (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_NODE_CONNECTION_INFORMATION_EX)), intPtr, (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_NODE_CONNECTION_INFORMATION_EX)), out num, global::System.IntPtr.Zero);
					}
					else
					{
						string log3 = "Failed to invoke DeviceIoControl---GetPortConnectionInformation---";
						if (!string.IsNullOrEmpty(logFileName))
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log3);
						}
					}
					if (flag)
					{
						nodeInfoEx = (global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_NODE_CONNECTION_INFORMATION_EX)global::System.Runtime.InteropServices.Marshal.PtrToStructure(intPtr, typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_NODE_CONNECTION_INFORMATION_EX));
					}
				}
				catch (global::System.Exception ex)
				{
					string text = "Got exception in ---GetPortConnectionInformation---";
					text += " The exception is: ";
					text += ex.Message;
					if (!string.IsNullOrEmpty(logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, logFileName, text, new object[0]);
					}
					flag = false;
				}
				finally
				{
					if (intPtr != global::System.IntPtr.Zero)
					{
						global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
						intPtr = global::System.IntPtr.Zero;
					}
					if (intPtr2 != global::System.IntPtr.Zero)
					{
						global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperCloseHandle(intPtr2);
						intPtr2 = (global::System.IntPtr)(-1);
					}
				}
			}
			return flag;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00010B9C File Offset: 0x0000ED9C
		private static bool GetUSBProductStringDescriptor(string usbHubPath, uint portNum, string logFileName, out string descriptor)
		{
			bool flag = true;
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			global::System.IntPtr intPtr2 = global::System.IntPtr.Zero;
			uint num = 0U;
			descriptor = string.Empty;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_DESCRIPTOR_REQUEST structure = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_DESCRIPTOR_REQUEST);
			byte[] array = null;
			if (string.IsNullOrEmpty(usbHubPath))
			{
				string log = "Radio instance is null ---GetUSBProductStringDescriptor---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log);
				}
				flag = false;
			}
			if (portNum == 0U)
			{
				string log2 = "Hub port number must be >= 1 ---GetUSBProductStringDescriptor---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log2);
				}
				flag = false;
			}
			if (flag)
			{
				try
				{
					structure.ConnectionIndex = portNum;
					structure.SetupPacket.bmRequest = 128;
					structure.SetupPacket.bRequest = 6;
					structure.SetupPacket.wValue = 770;
					structure.SetupPacket.wIndex = 1033;
					structure.SetupPacket.wLength = 255;
					intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_DESCRIPTOR_REQUEST)));
					global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_DESCRIPTOR_REQUEST>(structure, intPtr, false);
					flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperCreateFile(usbHubPath, 1073741824U, 2U, 3U, 0U, ref intPtr2);
					if (flag)
					{
						flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.Wrapper_DeviceIoControl(intPtr2, 2229264U, intPtr, (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_DESCRIPTOR_REQUEST)), intPtr, (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_DESCRIPTOR_REQUEST)), out num, global::System.IntPtr.Zero);
					}
					if (flag)
					{
						structure = (global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_DESCRIPTOR_REQUEST)global::System.Runtime.InteropServices.Marshal.PtrToStructure(intPtr, typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_DESCRIPTOR_REQUEST));
						if (structure.Data[1] != 3)
						{
							flag = false;
						}
					}
					else
					{
						string log3 = "Failed to invoke DeviceIoControl---GetUSBProductStringDescriptor---";
						if (!string.IsNullOrEmpty(logFileName))
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log3);
						}
					}
					if (flag)
					{
						int num2 = (int)(structure.Data[0] - 2);
						array = new byte[num2];
						global::System.Array.Copy(structure.Data, 2, array, 0, num2);
					}
					if (flag)
					{
						global::System.Text.UnicodeEncoding unicodeEncoding = new global::System.Text.UnicodeEncoding();
						descriptor = unicodeEncoding.GetString(array);
					}
				}
				catch (global::System.Exception ex)
				{
					string text = "Got exception in ---GetPortConnectionInformation---";
					text += " The exception is: ";
					text += ex.Message;
					if (!string.IsNullOrEmpty(logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, logFileName, text, new object[0]);
					}
					flag = false;
				}
				finally
				{
					if (intPtr != global::System.IntPtr.Zero)
					{
						global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
						intPtr = global::System.IntPtr.Zero;
					}
					if (intPtr2 != global::System.IntPtr.Zero)
					{
						global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperCloseHandle(intPtr2);
						intPtr2 = (global::System.IntPtr)(-1);
					}
				}
			}
			return flag;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00010E10 File Offset: 0x0000F010
		private static bool CyclePortPower(string usbHubPath, uint portNum, string logFileName, out uint status)
		{
			bool flag = true;
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			global::System.IntPtr intPtr2 = global::System.IntPtr.Zero;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_CYCLE_PORT_PARAMS structure = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_CYCLE_PORT_PARAMS);
			uint num = 0U;
			status = 0U;
			if (string.IsNullOrEmpty(usbHubPath))
			{
				string log = "Radio instance is null ---CyclePortPower---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log);
				}
				flag = false;
			}
			if (portNum == 0U)
			{
				string log2 = "Hub port number must be >= 1 ---CyclePortPower---";
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log2);
				}
				flag = false;
			}
			if (flag)
			{
				try
				{
					structure.ConnectionIndex = portNum;
					intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_CYCLE_PORT_PARAMS)));
					global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_CYCLE_PORT_PARAMS>(structure, intPtr, false);
					flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperCreateFile(usbHubPath, 1073741824U, 2U, 3U, 0U, ref intPtr2);
					if (flag)
					{
						flag = global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.Wrapper_DeviceIoControl(intPtr2, 2229316U, intPtr, (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_DESCRIPTOR_REQUEST)), intPtr, (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_DESCRIPTOR_REQUEST)), out num, global::System.IntPtr.Zero);
					}
					else
					{
						string log3 = "Failed to invoke DeviceIoControl---CyclePortPower---";
						if (!string.IsNullOrEmpty(logFileName))
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, log3);
						}
					}
					if (flag)
					{
						status = ((global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_CYCLE_PORT_PARAMS)global::System.Runtime.InteropServices.Marshal.PtrToStructure(intPtr, typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_CYCLE_PORT_PARAMS))).StatusReturned;
					}
				}
				catch (global::System.Exception ex)
				{
					string text = "Got exception in ---GetPortConnectionInformation---";
					text += " The exception is: ";
					text += ex.Message;
					if (!string.IsNullOrEmpty(logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, logFileName, text, new object[0]);
					}
					flag = false;
				}
				finally
				{
					if (intPtr != global::System.IntPtr.Zero)
					{
						global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
						intPtr = global::System.IntPtr.Zero;
					}
					if (intPtr2 != global::System.IntPtr.Zero)
					{
						global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.WrapperCloseHandle(intPtr2);
						intPtr2 = (global::System.IntPtr)(-1);
					}
				}
			}
			return flag;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00010FCC File Offset: 0x0000F1CC
		private static uint Distinguish64or32System(string logFileName)
		{
			string value = string.Empty;
			uint num = 0U;
			try
			{
				global::System.Management.ConnectionOptions options = new global::System.Management.ConnectionOptions();
				global::System.Management.ManagementScope scope = new global::System.Management.ManagementScope("\\\\localhost", options);
				global::System.Management.ObjectQuery query = new global::System.Management.ObjectQuery("select AddressWidth from Win32_Processor");
				using (global::System.Management.ManagementObjectSearcher managementObjectSearcher = new global::System.Management.ManagementObjectSearcher(scope, query))
				{
					global::System.Management.ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
					foreach (global::System.Management.ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						global::System.Management.ManagementObject managementObject = (global::System.Management.ManagementObject)managementBaseObject;
						value = managementObject["AddressWidth"].ToString();
					}
					num = global::System.Convert.ToUInt32(value);
				}
			}
			catch (global::System.Exception ex)
			{
				string text = "Got exception in ---Distinguish64or32System---";
				text += " The exception is: ";
				text += ex.Message;
				if (!string.IsNullOrEmpty(logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, logFileName, text, new object[0]);
				}
				value = string.Empty;
				num = 0U;
			}
			if (num == 64U)
			{
				bool flag = false;
				bool flag2 = global::Motorola.Common.Communication.TetraUtility.USBDiagnose._apiWrapper.Wrapper_IsWow64Process(out flag);
				if (flag2 && flag)
				{
					num = 32U;
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(logFileName, "Wow64 is true");
				}
			}
			return num;
		}

		// Token: 0x0400040A RID: 1034
		private static global::System.Guid _usbHubClass = new global::System.Guid("F18A0E88-C30C-11D0-8815-00A0C906BED8");

		// Token: 0x0400040B RID: 1035
		private static global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper _apiWrapper = new global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper();

		// Token: 0x0400040C RID: 1036
		private static uint _OsBits = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.Distinguish64or32System(string.Empty);
	}
}
