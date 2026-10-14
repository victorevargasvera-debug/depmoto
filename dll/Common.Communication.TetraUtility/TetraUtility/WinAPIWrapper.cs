using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000088 RID: 136
	public class WinAPIWrapper
	{
		// Token: 0x06000352 RID: 850 RVA: 0x00011C52 File Offset: 0x0000FE52
		public WinAPIWrapper(string logFileName)
		{
			this._logFileName = logFileName;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00011C7E File Offset: 0x0000FE7E
		public WinAPIWrapper()
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00011CA4 File Offset: 0x0000FEA4
		public static bool SetSockOpt(global::System.IntPtr s, int level, int optname, ref int optval)
		{
			int num = global::Motorola.Common.Communication.TetraUtility.NativeMethods.setsockopt(s, level, optname, ref optval, 4);
			if (num != 0)
			{
				int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
				global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("SetSockOpt last win32 error message is: " + ex.Message, new object[0]);
				return false;
			}
			return true;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00011CF0 File Offset: 0x0000FEF0
		public bool WrapperSetupDiGetClassDevs(ref global::System.IntPtr hDevInfo, ref global::System.Guid classGuid, global::System.IntPtr enumerator)
		{
			bool result = true;
			int flags = 2;
			if (enumerator == global::System.IntPtr.Zero)
			{
				flags = 18;
			}
			try
			{
				hDevInfo = global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetupDiGetClassDevs(ref classGuid, enumerator, global::System.IntPtr.Zero, flags);
				int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
				if (hDevInfo.ToInt32() == -1)
				{
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "SetupDiGetClassDevs last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---SetupDiGetClassDevs--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		public bool WrapperSetupDiDestroyDeviceInfoList(global::System.IntPtr hDevInfo)
		{
			bool flag = true;
			try
			{
				flag = global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetupDiDestroyDeviceInfoList(hDevInfo);
				if (!flag)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "SetupDiDestroyDeviceInfoList last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					flag = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---SetupDiDestroyDeviceInfoList--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00011E68 File Offset: 0x00010068
		public bool WrapperSetupDiEnumDeviceInterfaces(global::System.IntPtr hDevInfo, uint index, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA devInterfaceData, ref global::System.Guid classGuid)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetupDiEnumDeviceInterfaces(hDevInfo, global::System.IntPtr.Zero, ref classGuid, index, ref devInterfaceData) == 0U)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					if (lastWin32Error != 259)
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
						this._errorMsg = "SetupDiEnumDeviceInterfaces last win32 error message is: " + ex.Message;
						if (!string.IsNullOrEmpty(this._logFileName))
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
						}
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---SetupDiEnumDeviceInterfaces--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00011F24 File Offset: 0x00010124
		public bool WrapperSetupDiGetDeviceInterfaceDetail(global::System.IntPtr hDevInfo, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA devInterfaceData, global::System.IntPtr deviceInterfaceDetailData, uint deviceInterfaceDetailDataSize, out uint requiredSize, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA devInfoData, out int errorCode)
		{
			bool flag = true;
			errorCode = 0;
			requiredSize = 0U;
			try
			{
				flag = global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetupDiGetDeviceInterfaceDetail(hDevInfo, ref devInterfaceData, deviceInterfaceDetailData, deviceInterfaceDetailDataSize, out requiredSize, ref devInfoData);
				if (!flag)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					errorCode = lastWin32Error;
					if (lastWin32Error != 122)
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
						this._errorMsg = "SetupDiGetDeviceInterfaceDetail last win32 error message is: " + ex.Message;
						if (!string.IsNullOrEmpty(this._logFileName))
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
						}
						flag = false;
					}
					else
					{
						flag = true;
					}
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---SetupDiGetDeviceInterfaceDetail--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				errorCode = 0;
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00011FF0 File Offset: 0x000101F0
		public bool WrapperSetupDiGetDeviceInstanceId(global::System.IntPtr hDevInfo, global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA devInfoData, ref string devIntanceID, int bufferSize)
		{
			bool flag = true;
			int num = 0;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(bufferSize);
			try
			{
				flag = global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetupDiGetDeviceInstanceId(hDevInfo, ref devInfoData, stringBuilder, bufferSize, out num);
				if (!flag)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "SetupDiGetDeviceInstanceId last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					flag = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---SetupDiGetDeviceInstanceId--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				flag = false;
			}
			devIntanceID = stringBuilder.ToString();
			return flag;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000120B8 File Offset: 0x000102B8
		public bool Wrapper_CM_Get_Parent(uint devID, ref uint parentDevID)
		{
			bool result = true;
			try
			{
				int num = global::Motorola.Common.Communication.TetraUtility.NativeMethods.CM_Get_Parent(out parentDevID, devID, 0);
				if (num != 0)
				{
					this._errorMsg = "CM_Get_Parent last win32 error code is: " + num.ToString();
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex)
			{
				this._errorMsg = "Exception found when invoking---CM_Get_Parent--- " + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00012158 File Offset: 0x00010358
		public bool Wrapper_CM_Get_Device_ID(uint devID, ref string instanceID)
		{
			bool flag = true;
			global::System.IntPtr intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(1024);
			instanceID = string.Empty;
			try
			{
				int num = global::Motorola.Common.Communication.TetraUtility.NativeMethods.CM_Get_Device_ID(devID, intPtr, 1024, 0);
				if (num != 0)
				{
					this._errorMsg = "CM_Get_Device_ID last win32 error code is: " + num.ToString();
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					flag = false;
				}
			}
			catch (global::System.Exception ex)
			{
				this._errorMsg = "Exception found when invoking---CM_Get_Device_ID--- " + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				flag = false;
			}
			finally
			{
				if (flag)
				{
					instanceID = global::System.Runtime.InteropServices.Marshal.PtrToStringAuto(intPtr);
				}
				if (intPtr != global::System.IntPtr.Zero)
				{
					global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
				}
			}
			return flag;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0001223C File Offset: 0x0001043C
		public bool WrapperSetupDiOpenDevRegKey(global::System.IntPtr hDevInfo, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA devInfoData, ref global::System.IntPtr regKey)
		{
			bool result = true;
			int samDesired = 131097;
			try
			{
				regKey = global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetupDiOpenDevRegKey(hDevInfo, ref devInfoData, 1, 0, 1, samDesired);
				int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
				if (regKey.ToInt32() == -1)
				{
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "SetupDiOpenDevRegKey last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---SetupDiOpenDevRegKey--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000122FC File Offset: 0x000104FC
		public bool WrapperSetupDiOpenDevRegKey(global::System.IntPtr hDevInfo, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA devInfoData, ref global::System.IntPtr regKey, int valueKind, int flags)
		{
			bool result = true;
			try
			{
				regKey = global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetupDiOpenDevRegKey(hDevInfo, ref devInfoData, 1, 0, valueKind, flags);
				if (regKey.ToInt32() == -1)
				{
					result = false;
				}
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00012344 File Offset: 0x00010544
		public bool WrapperRegQueryVComName(global::System.IntPtr regKey, ref string devName)
		{
			return this.WrapperRegQueryValueEx(regKey, "PortName", ref devName);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00012354 File Offset: 0x00010554
		public bool WrapperRegQueryValueEx(global::System.IntPtr regKey, string valueName, ref string devName)
		{
			bool flag = true;
			uint num = 1024U;
			global::System.IntPtr intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(1024);
			devName = string.Empty;
			try
			{
				int num2 = global::Motorola.Common.Communication.TetraUtility.NativeMethods.RegQueryValueEx(regKey, valueName, global::System.IntPtr.Zero, global::System.IntPtr.Zero, intPtr, ref num);
				if (num2 != 0)
				{
					this._errorMsg = "RegQueryValueEx last error code is: " + num2.ToString();
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					flag = false;
				}
			}
			catch (global::System.Exception ex)
			{
				this._errorMsg = "Exception found when invoking---RegQueryValueEx--- " + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				flag = false;
			}
			finally
			{
				if (flag)
				{
					devName = global::System.Runtime.InteropServices.Marshal.PtrToStringAuto(intPtr);
				}
				if (intPtr != global::System.IntPtr.Zero)
				{
					global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
				}
			}
			return flag;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00012448 File Offset: 0x00010648
		public bool WrapperRegCloseKey(global::System.IntPtr regKey)
		{
			bool result = true;
			try
			{
				int num = global::Motorola.Common.Communication.TetraUtility.NativeMethods.RegCloseKey(regKey);
				if (num != 0)
				{
					this._errorMsg = "RegCloseKey last error code is: " + num.ToString();
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex)
			{
				this._errorMsg = "Exception found when invoking---RegCloseKey--- " + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000124E8 File Offset: 0x000106E8
		public bool WrapperRegisterDeviceNotification(global::System.IntPtr hRecipient, global::System.IntPtr notificationFilter, uint flags, ref global::System.IntPtr notifyHandler)
		{
			bool result = true;
			try
			{
				notifyHandler = global::Motorola.Common.Communication.TetraUtility.NativeMethods.RegisterDeviceNotification(hRecipient, notificationFilter, flags);
				if (notifyHandler == global::System.IntPtr.Zero)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "RegisterDeviceNotification last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---RegisterDeviceNotification--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000125A8 File Offset: 0x000107A8
		public bool WrapperUnregisterDeviceNotification(global::System.IntPtr hHandle)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.UnregisterDeviceNotification(hHandle) == 0U)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "WrapperUnregisterDeviceNotification last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---WrapperUnregisterDeviceNotification--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00012654 File Offset: 0x00010854
		public bool WrapperCloseHandle(global::System.IntPtr hHandle)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.CloseHandle(hHandle) == 0U)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "WrapperCloseHandle last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---WrapperCloseHandle--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00012700 File Offset: 0x00010900
		public bool WrapperRegisterServiceCtrlHandlerEx(string serviceName, global::Motorola.Common.Communication.TetraUtility.NativeMethods.CtrHandleCallback cbex, ref global::System.IntPtr serviceHandler)
		{
			bool result = true;
			serviceHandler = global::System.IntPtr.Zero;
			try
			{
				serviceHandler = global::Motorola.Common.Communication.TetraUtility.NativeMethods.RegisterServiceCtrlHandlerEx(serviceName, cbex, global::System.IntPtr.Zero);
				if (serviceHandler == global::System.IntPtr.Zero)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "RegisterServiceCtrlHandlerEx last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---RegisterServiceCtrlHandlerEx--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000127D0 File Offset: 0x000109D0
		public bool WrapperSetServiceStatus(global::System.IntPtr hServiceStatus, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SERVICE_STATUS lpServiceStatus)
		{
			bool flag = true;
			try
			{
				flag = global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetServiceStatus(hServiceStatus, ref lpServiceStatus);
				if (!flag)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "SetServiceStatus last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---SetServiceStatus--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00012878 File Offset: 0x00010A78
		public bool WrapperOpenSCManager(string machineName, string databaseName, uint accessRight, ref global::System.IntPtr ctrMngDBHandle)
		{
			bool result = true;
			ctrMngDBHandle = global::System.IntPtr.Zero;
			try
			{
				ctrMngDBHandle = global::Motorola.Common.Communication.TetraUtility.NativeMethods.OpenSCManager(machineName, databaseName, accessRight);
				if (ctrMngDBHandle == global::System.IntPtr.Zero)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "OpenSCManager last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---OpenSCManager--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00012944 File Offset: 0x00010B44
		public bool WrapperCloseServiceHandle(global::System.IntPtr hSCObject)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.CloseHandle(hSCObject) == 0U)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "CloseServiceHandle last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---CloseServiceHandle--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000129F0 File Offset: 0x00010BF0
		public bool WrapperGetCurrentProcessId(ref uint processId)
		{
			bool result = true;
			processId = 0U;
			try
			{
				processId = global::Motorola.Common.Communication.TetraUtility.NativeMethods.GetCurrentProcessId();
			}
			catch (global::System.Exception ex)
			{
				this._errorMsg = "Exception found when invoking---GetCurrentProcessId--- " + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00012A58 File Offset: 0x00010C58
		public bool WrapperEnumServicesStatusEx(global::System.IntPtr hSCManager, uint InfoLevel, uint dwServiceType, uint dwServiceState, global::System.IntPtr lpServices, uint cbBufSize, out uint pcbBytesNeeded, out uint lpServicesReturned, ref uint lpResumeHandle, string pszGroupName, out int win32LastError)
		{
			bool flag = true;
			pcbBytesNeeded = 0U;
			lpServicesReturned = 0U;
			lpResumeHandle = 0U;
			win32LastError = 0;
			try
			{
				flag = global::Motorola.Common.Communication.TetraUtility.NativeMethods.EnumServicesStatusEx(hSCManager, InfoLevel, dwServiceType, dwServiceState, lpServices, cbBufSize, out pcbBytesNeeded, out lpServicesReturned, ref lpResumeHandle, pszGroupName);
				if (!flag)
				{
					win32LastError = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(win32LastError);
					this._errorMsg = "EnumServicesStatusEx last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---EnumServicesStatusEx--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00012B24 File Offset: 0x00010D24
		public bool WrapperWaitForSingleObject(global::System.IntPtr hHandle, uint dwMilliseconds, ref bool bTimeout)
		{
			bool result = true;
			bTimeout = false;
			try
			{
				uint num = global::Motorola.Common.Communication.TetraUtility.NativeMethods.WaitForSingleObject(hHandle, dwMilliseconds);
				if (num == 258U)
				{
					bTimeout = true;
					result = false;
				}
				else if (num == 4294967295U)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "WaitForSingleObject last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking --- WaitForSingleObject ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00012BE4 File Offset: 0x00010DE4
		public bool WrapperSetEvent(global::System.IntPtr hEvent)
		{
			bool flag = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetEvent(hEvent) == 0)
				{
					flag = false;
				}
				if (!flag)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "SetEvent last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					flag = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---SetEvent ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00012C94 File Offset: 0x00010E94
		public bool WrapperResetEvent(global::System.IntPtr hEvent)
		{
			bool flag = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetEvent(hEvent) == 0)
				{
					flag = false;
				}
				if (!flag)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "ResetEvent last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					flag = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---ResetEvent ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00012D44 File Offset: 0x00010F44
		public bool WrapperCreateEvent(bool bManualReset, bool bSignaledIniState, ref global::System.IntPtr eventHandle)
		{
			bool result = true;
			eventHandle = global::System.IntPtr.Zero;
			int bManualReset2 = 0;
			int bInitialState = 0;
			if (bManualReset)
			{
				bManualReset2 = 1;
			}
			if (bSignaledIniState)
			{
				bInitialState = 1;
			}
			try
			{
				eventHandle = global::Motorola.Common.Communication.TetraUtility.NativeMethods.CreateEvent(global::System.IntPtr.Zero, bManualReset2, bInitialState, global::System.IntPtr.Zero);
				if (eventHandle == global::System.IntPtr.Zero)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "CreateEvent last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---CreateEvent ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00012E28 File Offset: 0x00011028
		public bool WrapperEscapeCommFunction(global::System.IntPtr hFile, global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommEscapes funcCode)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.EscapeCommFunction(hFile, (uint)funcCode) == 0)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "EscapeCommFunction last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---EscapeCommFunction ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00012ED4 File Offset: 0x000110D4
		public bool WrapperSetCommTimeouts(global::System.IntPtr hFile, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommTimeouts timeouts)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetCommTimeouts(hFile, ref timeouts) == 0)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "SetCommTimeouts last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---SetCommTimeouts ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00012F80 File Offset: 0x00011180
		public bool WrapperGetCommState(global::System.IntPtr hFile, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB dcb)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.GetCommState(hFile, ref dcb) == 0)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "GetCommState last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---GetCommState ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0001302C File Offset: 0x0001122C
		public bool WrapperSetCommState(global::System.IntPtr hFile, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB dcb)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetCommState(hFile, ref dcb) == 0)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "SetCommState last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---SetCommStates ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000130D8 File Offset: 0x000112D8
		public bool WrapperSetupComm(global::System.IntPtr hFile, uint dwInQueue, uint dwOutQueue)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetupComm(hFile, dwInQueue, dwOutQueue) == 0)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "SetupComm last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---SetupComm ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00013184 File Offset: 0x00011384
		private unsafe bool WrapperWriteFile(global::System.IntPtr hFile, byte* lpBuffer, uint offset, uint nNumberOfBytesToWrite, global::System.IntPtr lpOverlapped, ref int lastWin32Error)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.WriteFile(hFile, lpBuffer + offset, nNumberOfBytesToWrite, global::System.IntPtr.Zero, lpOverlapped, ref lastWin32Error) == 0)
				{
					result = false;
				}
			}
			catch (global::System.Exception ex)
			{
				this._errorMsg = "Exception found when invoking ---WriteFile ---" + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000131FC File Offset: 0x000113FC
		public unsafe void WriteFileAsyn(global::System.IntPtr hFile, byte[] lpBuffer, uint offset, uint nNumberOfBytesToWrite, global::System.IntPtr lpOverlapped, global::System.IntPtr writeEvent, uint waitTime)
		{
			bool flag = false;
			int num = 0;
			uint num2 = 0U;
			uint num3 = 0U;
			bool flag2 = false;
			fixed (byte* ptr = lpBuffer)
			{
				if (!this.WrapperWriteFile(hFile, ptr, offset, nNumberOfBytesToWrite, lpOverlapped, ref num) && (long)num != 997L)
				{
					this._errorMsg = "Write operation got failed result, the last win32 error code is :" + global::System.Convert.ToString(num);
					throw new global::System.Exception(this._errorMsg);
				}
				if (!this.WrapperWaitForSingleObject(writeEvent, waitTime, ref flag2))
				{
					if (!flag2)
					{
						string message = "Waiting for write operation completion got failed result";
						throw new global::System.Exception(message);
					}
					this._errorMsg = "Waiting for WaitForSingleObject in write operation got time-out result!";
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					this._errorMsg = "But we still try to get overlapped result";
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
				}
				bool flag3;
				do
				{
					flag3 = this.WrapperGetOverlappedResult(hFile, lpOverlapped, ref num2, false, ref flag);
					if (flag)
					{
						global::System.Threading.Thread.Sleep(10);
						num3 += 10U;
					}
				}
				while (!flag3 && flag && num3 < waitTime);
				if (!flag3)
				{
					if (flag)
					{
						uint purgeFlag = 5U;
						this.WrapperPurgeComm(hFile, purgeFlag);
						this._errorMsg = "Waiting for GetOverlappedResult in write operation got time-out result!";
						throw new global::System.TimeoutException(this._errorMsg);
					}
					this._errorMsg = "Failed to get overlapped result in write operation, the last win32 error code had been logged";
					throw new global::System.Exception(this._errorMsg);
				}
				else
				{
					if (num2 != nNumberOfBytesToWrite)
					{
						this._errorMsg = "the actually written byte size didn't equal with the size of whishing to be written";
						throw new global::System.Exception(this._errorMsg);
					}
					ptr = null;
					return;
				}
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00013378 File Offset: 0x00011578
		private unsafe bool WrapperReadFile(global::System.IntPtr hFile, byte* lpBuffer, uint offset, uint nNumberOfBytesToRead, global::System.IntPtr lpOverlapped, ref int lastWin32Error)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.ReadFile(hFile, lpBuffer + offset, nNumberOfBytesToRead, global::System.IntPtr.Zero, lpOverlapped, ref lastWin32Error) == 0)
				{
					result = false;
				}
			}
			catch (global::System.Exception ex)
			{
				this._errorMsg = "Exception found when invoking ---ReadFile ---" + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000133F0 File Offset: 0x000115F0
		public unsafe int ReadFileAsyn(global::System.IntPtr hFile, byte[] lpBuffer, uint offset, uint nNumberOfBytesToRead, global::System.IntPtr lpOverlapped, uint waitTime)
		{
			bool flag = false;
			int num = 0;
			uint num2 = 0U;
			uint num3 = 0U;
			fixed (byte* ptr = lpBuffer)
			{
				if (!this.WrapperReadFile(hFile, ptr, offset, nNumberOfBytesToRead, lpOverlapped, ref num) && (long)num != 997L)
				{
					this._errorMsg = "Write operation got failed result, the last win32 error code is :" + global::System.Convert.ToString(num);
					throw new global::System.Exception(this._errorMsg);
				}
				bool flag2;
				do
				{
					flag2 = this.WrapperGetOverlappedResult(hFile, lpOverlapped, ref num2, true, ref flag);
					if (flag)
					{
						global::System.Threading.Thread.Sleep(10);
						num3 += 10U;
					}
				}
				while (!flag2 && flag && num3 < waitTime);
				if (!flag2)
				{
					if (flag)
					{
						this._errorMsg = "Waiting for GetOverlappedResult in read operation got time-out result!";
						throw new global::System.TimeoutException(this._errorMsg);
					}
					string message = "Failed to get overlapped result in read operation, the last win32 error code had been logged";
					throw new global::System.Exception(message);
				}
				else
				{
					if (num2 == 0U)
					{
						this._errorMsg = "receive zero length packet after a period of waitting ,treat as time-out occured";
						throw new global::System.TimeoutException(this._errorMsg);
					}
					if (num2 > nNumberOfBytesToRead)
					{
						this._errorMsg = "Read more data than expected, this maybe cause buffer overflow!";
						throw new global::System.Exception(this._errorMsg);
					}
					ptr = null;
					return (int)num2;
				}
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000134F8 File Offset: 0x000116F8
		public bool WrapperSetCommMask(global::System.IntPtr handle, global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommEventFlags dwEvtMask)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetCommMask(handle, (uint)dwEvtMask) == 0)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "SetCommMask last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---SetCommMask ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000135A4 File Offset: 0x000117A4
		public bool WrapperGetCommModemStatus(global::System.IntPtr hFile, ref uint lpModemStat)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.GetCommModemStatus(hFile, ref lpModemStat) == 0)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "GetCommModemStatus last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---GetCommModemStatus ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00013650 File Offset: 0x00011850
		public bool WrapperClearCommError(global::System.IntPtr hFile, ref uint lpErrors, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat lpStat)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.ClearCommError(hFile, ref lpErrors, ref lpStat) == 0)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "ClearCommError last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---ClearCommError ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000136FC File Offset: 0x000118FC
		public bool WrapperCreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, uint dwCreationDisposition, uint dwFlagsAndAttributes, ref global::System.IntPtr fileHandle)
		{
			bool result = true;
			try
			{
				fileHandle = global::Motorola.Common.Communication.TetraUtility.NativeMethods.CreateFile(lpFileName, dwDesiredAccess, dwShareMode, global::System.IntPtr.Zero, dwCreationDisposition, dwFlagsAndAttributes, global::System.IntPtr.Zero);
				int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
				if ((int)fileHandle == -1)
				{
					bool flag = false;
					if (lastWin32Error == this.AccessIsDenied)
					{
						global::System.Threading.Thread.Sleep(1000);
						fileHandle = global::Motorola.Common.Communication.TetraUtility.NativeMethods.CreateFile(lpFileName, dwDesiredAccess, dwShareMode, global::System.IntPtr.Zero, dwCreationDisposition, dwFlagsAndAttributes, global::System.IntPtr.Zero);
						if ((int)fileHandle != -1)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
						this._errorMsg = "CreateFile last win32 error message is: " + ex.Message;
						if (!string.IsNullOrEmpty(this._logFileName))
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
						}
						result = false;
					}
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---CreateFile ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00013814 File Offset: 0x00011A14
		public bool WrapperWaitCommEvent(global::System.IntPtr hFile, ref uint lpEvtMask, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.OVERLAPPED lpOverlapped, ref int lastWin32Error)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.WaitCommEvent(hFile, ref lpEvtMask, ref lpOverlapped) == 0)
				{
					lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					result = false;
				}
			}
			catch (global::System.Exception ex)
			{
				this._errorMsg = "Exception found when invoking ---WaitCommEvent ---" + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00013888 File Offset: 0x00011A88
		public bool WrapperGetCommProperties(global::System.IntPtr hFile, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.COMMPROP commProp)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.GetCommProperties(hFile, ref commProp) == 0)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "GetCommProperties last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---GetCommProperties ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00013934 File Offset: 0x00011B34
		public bool WrapperGetOverlappedResult(global::System.IntPtr hFile, global::System.IntPtr lpOverlapped, ref uint lpNumberOfBytesTransferred, bool bWait, ref bool bPending)
		{
			bool result = true;
			int bWait2 = 0;
			bPending = false;
			if (bWait)
			{
				bWait2 = 1;
			}
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.GetOverlappedResult(hFile, lpOverlapped, ref lpNumberOfBytesTransferred, bWait2) == 0)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					if (lastWin32Error == 996)
					{
						bPending = true;
					}
					else
					{
						global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
						this._errorMsg = "GetOverlappedResult last win32 error message is: " + ex.Message;
						if (!string.IsNullOrEmpty(this._logFileName))
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
						}
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---GetOverlappedResult ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00013A00 File Offset: 0x00011C00
		public bool WrapperPurgeComm(global::System.IntPtr hFile, uint purgeFlag)
		{
			bool result = true;
			try
			{
				if (global::Motorola.Common.Communication.TetraUtility.NativeMethods.PurgeComm(hFile, purgeFlag) == 0)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "PurgeComm last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking ---PurgeComm ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00013AAC File Offset: 0x00011CAC
		public bool WrapperGetFileType(global::System.IntPtr hFile, ref uint fileType)
		{
			bool result = true;
			try
			{
				fileType = global::Motorola.Common.Communication.TetraUtility.NativeMethods.GetFileType(hFile);
			}
			catch (global::System.Exception ex)
			{
				this._errorMsg = "Exception found when invoking ---GetFileType ---" + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00013B10 File Offset: 0x00011D10
		public bool Wrapper_CM_Get_DevNode_Status(uint devID, ref uint status)
		{
			bool result = true;
			uint num = 0U;
			try
			{
				int num2 = global::Motorola.Common.Communication.TetraUtility.NativeMethods.CM_Get_DevNode_Status(ref status, ref num, devID, 0);
				if (num2 != 0)
				{
					this._errorMsg = "CM_Get_Parent last win32 error code is: " + num2.ToString();
					this._errorMsg += " And the problem number is: ";
					this._errorMsg += num.ToString();
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex)
			{
				this._errorMsg = "Exception found when invoking---CM_Get_DevNode_Status--- " + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00013BE4 File Offset: 0x00011DE4
		public bool Wrapper_CM_Request_Device_Eject(uint devID)
		{
			bool result = true;
			try
			{
				int num = global::Motorola.Common.Communication.TetraUtility.NativeMethods.CM_Request_Device_Eject(devID, global::System.UIntPtr.Zero, global::System.UIntPtr.Zero, 0U, 0U);
				if (num != 0)
				{
					this._errorMsg = "CM_Get_Parent last win32 error code is: " + num.ToString();
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex)
			{
				this._errorMsg = "Exception found when invoking---CM_Request_Device_Eject--- " + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00013C90 File Offset: 0x00011E90
		public bool Wrapper_DeviceIoControl(global::System.IntPtr hDevice, uint dwIoControlCode, global::System.IntPtr lpInBuffer, uint nInBufferSize, global::System.IntPtr lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, global::System.IntPtr lpOverlapped)
		{
			bool flag = true;
			lpBytesReturned = 0U;
			if (hDevice == global::System.IntPtr.Zero)
			{
				flag = false;
				string message = "Wrapper_DeviceIoControl: Invalid Device Handle";
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(message);
			}
			if (flag)
			{
				try
				{
					flag = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DeviceIoControl(hDevice, dwIoControlCode, lpInBuffer, nInBufferSize, lpOutBuffer, nOutBufferSize, out lpBytesReturned, lpOverlapped);
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					if (!flag && lpOverlapped != global::System.IntPtr.Zero)
					{
						if ((long)lastWin32Error != 997L)
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
							this._errorMsg = "PurgeComm last win32 error message is: " + ex.Message;
							if (!string.IsNullOrEmpty(this._logFileName))
							{
								global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
							}
							throw ex;
						}
						flag = true;
					}
					else if (!flag && lpOverlapped == global::System.IntPtr.Zero)
					{
						global::System.ComponentModel.Win32Exception ex2 = new global::System.ComponentModel.Win32Exception(lastWin32Error);
						this._errorMsg = "PurgeComm last win32 error message is: " + ex2.Message;
						if (!string.IsNullOrEmpty(this._logFileName))
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
						}
						throw ex2;
					}
					if (flag && lpOverlapped != global::System.IntPtr.Zero)
					{
						bool flag2 = false;
						flag = this.WrapperGetOverlappedResult(hDevice, lpOverlapped, ref lpBytesReturned, true, ref flag2);
						if (!flag)
						{
							if (flag2)
							{
								this._errorMsg = "Waiting for GetOverlappedResult in DeviceIoControl operation got time-out result!";
								throw new global::System.TimeoutException(this._errorMsg);
							}
							this._errorMsg = "Failed to get overlapped result in DeviceIoControl operation, the last win32 error code had been logged";
							throw new global::System.Exception(this._errorMsg);
						}
					}
				}
				catch (global::System.Exception ex3)
				{
					this._errorMsg = "Exception found when invoking ---Wrapper_DeviceIoControl ---" + ex3.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					flag = false;
					throw;
				}
			}
			return flag;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00013E48 File Offset: 0x00012048
		public bool Wrapper_IsWow64Process(out bool bWow64Process)
		{
			bool flag = true;
			bWow64Process = false;
			if (global::System.Environment.OSVersion.Version.Major != 5 || global::System.Environment.OSVersion.Version.Minor < 1)
			{
				if (global::System.Environment.OSVersion.Version.Major <= 5)
				{
					goto IL_D0;
				}
			}
			try
			{
				flag = global::Motorola.Common.Communication.TetraUtility.NativeMethods.IsWow64Process(global::System.Diagnostics.Process.GetCurrentProcess().Handle, out bWow64Process);
				if (!flag)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					this._errorMsg = "IsWow64Process last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
					}
					flag = false;
				}
				return flag;
			}
			catch (global::System.Exception ex2)
			{
				this._errorMsg = "Exception found when invoking---IsWow64Process--- " + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
				return false;
			}
			IL_D0:
			bWow64Process = false;
			flag = true;
			return flag;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00013F40 File Offset: 0x00012140
		public bool Wrapper_SetupDiClassGuidsFromName(string className, out global::System.Guid[] classGuidArray)
		{
			bool flag = true;
			classGuidArray = null;
			int num = 0;
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			if (string.IsNullOrEmpty(className))
			{
				flag = false;
				this._errorMsg = "Wrapper_SetupDiClassGuidsFromName: Input class name is null";
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
				}
			}
			if (flag)
			{
				try
				{
					int num2 = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.My_GUID));
					intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(num2);
					flag = global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetupDiClassGuidsFromName(className, intPtr, 1, out num);
					if (!flag)
					{
						int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						if (lastWin32Error != 122)
						{
							global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
							this._errorMsg = "SetupDiClassGuidsFromName last win32 error message is: " + ex.Message;
							if (!string.IsNullOrEmpty(this._logFileName))
							{
								global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
							}
							throw ex;
						}
						global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
						intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(num2 * num);
						flag = global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetupDiClassGuidsFromName(className, intPtr, num, out num);
					}
					if (!flag)
					{
						int lastWin32Error2 = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						global::System.ComponentModel.Win32Exception ex2 = new global::System.ComponentModel.Win32Exception(lastWin32Error2);
						this._errorMsg = "SetupDiClassGuidsFromName last win32 error message is: " + ex2.Message;
						if (!string.IsNullOrEmpty(this._logFileName))
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
						}
					}
					if (flag && num >= 1)
					{
						int num3 = 0;
						byte[] array = new byte[num2];
						classGuidArray = new global::System.Guid[num];
						for (int i = 0; i < num; i++)
						{
							for (int j = 0; j < num2; j++)
							{
								array[j] = global::System.Runtime.InteropServices.Marshal.ReadByte(intPtr, num3);
								num3++;
							}
							classGuidArray[i] = new global::System.Guid(array);
						}
					}
				}
				catch (global::System.Exception ex3)
				{
					this._errorMsg = "Exception found when invoking ---SetupDiClassGuidsFromName ---" + ex3.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, this._errorMsg);
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

		// Token: 0x06000385 RID: 901 RVA: 0x00014154 File Offset: 0x00012354
		public bool WrapperSetupDiEnumDeviceInfo(global::System.IntPtr hDevInfo, uint memberIndex, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA deviceInfoData)
		{
			bool flag = true;
			try
			{
				flag = global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetupDiEnumDeviceInfo(hDevInfo, memberIndex, ref deviceInfoData);
				if (!flag)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					flag = (lastWin32Error == 122);
				}
			}
			catch (global::System.Exception)
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00014198 File Offset: 0x00012398
		public bool Wrapper_OpenVolume(string driveLetter, ref global::System.IntPtr fileHandle)
		{
			bool result = true;
			try
			{
				string lpRootPathName = string.Format("{0}:\\", driveLetter);
				string lpFileName = string.Format("\\\\.\\{0}:", driveLetter);
				global::Motorola.Common.Communication.TetraUtility.NativeMethods.WinDriveType driveType = (global::Motorola.Common.Communication.TetraUtility.NativeMethods.WinDriveType)global::Motorola.Common.Communication.TetraUtility.NativeMethods.GetDriveType(lpRootPathName);
				global::Motorola.Common.Communication.TetraUtility.NativeMethods.WinDriveType winDriveType = driveType;
				uint dwDesiredAccess;
				if (winDriveType != global::Motorola.Common.Communication.TetraUtility.NativeMethods.WinDriveType.DRIVE_REMOVABLE)
				{
					if (winDriveType != global::Motorola.Common.Communication.TetraUtility.NativeMethods.WinDriveType.DRIVE_CDROM)
					{
						string log = "Wrapper_OpenVolume fail: Invalid drive type.";
						if (!string.IsNullOrEmpty(this._logFileName))
						{
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, log);
						}
						return false;
					}
					dwDesiredAccess = 2147483648U;
				}
				else
				{
					dwDesiredAccess = 3221225472U;
				}
				fileHandle = global::Motorola.Common.Communication.TetraUtility.NativeMethods.CreateFile(lpFileName, dwDesiredAccess, 3U, global::System.IntPtr.Zero, 3U, 0U, global::System.IntPtr.Zero);
				int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
				if ((int)fileHandle == -1)
				{
					global::System.ComponentModel.Win32Exception ex = new global::System.ComponentModel.Win32Exception(lastWin32Error);
					string log2 = "Wrapper_OpenVolume fail, last win32 error message is: " + ex.Message;
					if (!string.IsNullOrEmpty(this._logFileName))
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, log2);
					}
					result = false;
				}
			}
			catch (global::System.Exception ex2)
			{
				string log3 = "Exception found when invoking ---Wrapper_OpenVolume ---" + ex2.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, log3);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000142C0 File Offset: 0x000124C0
		public bool Wrapper_LockVolume(global::System.IntPtr hVolume)
		{
			bool result = true;
			try
			{
				uint ioControlCode = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetIoControlCode(9U, 6U, 0U, 0U);
				uint num;
				result = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DeviceIoControl(hVolume, ioControlCode, global::System.IntPtr.Zero, 0U, global::System.IntPtr.Zero, 0U, out num, global::System.IntPtr.Zero);
			}
			catch (global::System.Exception ex)
			{
				string log = "Exception found when invoking ---Wrapper_LockVolume ---" + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, log);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0001433C File Offset: 0x0001253C
		public bool Wrapper_DismountVolume(global::System.IntPtr hVolume)
		{
			bool result = true;
			try
			{
				uint ioControlCode = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetIoControlCode(9U, 8U, 0U, 0U);
				uint num;
				result = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DeviceIoControl(hVolume, ioControlCode, global::System.IntPtr.Zero, 0U, global::System.IntPtr.Zero, 0U, out num, global::System.IntPtr.Zero);
			}
			catch (global::System.Exception ex)
			{
				string log = "Exception found when invoking ---Wrapper_DismountVolume ---" + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, log);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000143B8 File Offset: 0x000125B8
		public bool Wrapper_PreventRemovalOfVolume(global::System.IntPtr hVolume, bool bPreventRemoval)
		{
			bool result = true;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.PREVENT_MEDIA_REMOVAL structure = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.PREVENT_MEDIA_REMOVAL);
			structure.PreventMediaRemoval = (bPreventRemoval ? 1 : 0);
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			int num = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.PREVENT_MEDIA_REMOVAL));
			intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(num);
			global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.PREVENT_MEDIA_REMOVAL>(structure, intPtr, false);
			try
			{
				uint ioControlCode = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetIoControlCode(45U, 513U, 0U, 1U);
				uint num2;
				result = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DeviceIoControl(hVolume, ioControlCode, intPtr, (uint)num, global::System.IntPtr.Zero, 0U, out num2, global::System.IntPtr.Zero);
			}
			catch (global::System.Exception ex)
			{
				string log = "Exception found when invoking ---Wrapper_PreventRemovalOfVolume ---" + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, log);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00014474 File Offset: 0x00012674
		public bool Wrapper_AutoEjectVolume(global::System.IntPtr hVolume)
		{
			bool result = true;
			try
			{
				uint ioControlCode = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetIoControlCode(45U, 514U, 0U, 1U);
				uint num;
				result = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DeviceIoControl(hVolume, ioControlCode, global::System.IntPtr.Zero, 0U, global::System.IntPtr.Zero, 0U, out num, global::System.IntPtr.Zero);
			}
			catch (global::System.Exception ex)
			{
				string log = "Exception found when invoking ---Wrapper_AutoEjectVolume ---" + ex.Message;
				if (!string.IsNullOrEmpty(this._logFileName))
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this._logFileName, log);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x04000424 RID: 1060
		private string _logFileName = string.Empty;

		// Token: 0x04000425 RID: 1061
		private string _errorMsg = string.Empty;

		// Token: 0x04000426 RID: 1062
		private readonly int AccessIsDenied = 5;
	}
}
