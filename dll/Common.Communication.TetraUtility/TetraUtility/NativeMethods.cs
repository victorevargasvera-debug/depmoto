using System;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200003B RID: 59
	public static class NativeMethods
	{
		// Token: 0x060001ED RID: 493
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern global::System.IntPtr RegisterDeviceNotification(global::System.IntPtr hRecipient, global::System.IntPtr notificationFilter, uint flags);

		// Token: 0x060001EE RID: 494
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern uint UnregisterDeviceNotification(global::System.IntPtr hHandle);

		// Token: 0x060001EF RID: 495
		[global::System.Runtime.InteropServices.DllImport("kernel32", SetLastError = true)]
		internal static extern uint CloseHandle(global::System.IntPtr hHandle);

		// Token: 0x060001F0 RID: 496
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern global::System.IntPtr SetupDiGetClassDevs(ref global::System.Guid ClassGuid, global::System.IntPtr Enumerator, global::System.IntPtr hwndParent, int Flags);

		// Token: 0x060001F1 RID: 497
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern uint SetupDiEnumDeviceInterfaces(global::System.IntPtr hDevInfo, global::System.IntPtr devInfo, ref global::System.Guid interfaceClassGuid, uint memberIndex, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA deviceInterfaceData);

		// Token: 0x060001F2 RID: 498
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiDestroyDeviceInfoList(global::System.IntPtr hDevInfo);

		// Token: 0x060001F3 RID: 499
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiGetDeviceInterfaceDetail(global::System.IntPtr hDevInfo, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA deviceInterfaceData, global::System.IntPtr deviceInterfaceDetailData, uint deviceInterfaceDetailDataSize, out uint requiredSize, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA deviceInfoData);

		// Token: 0x060001F4 RID: 500
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiGetDeviceInstanceId(global::System.IntPtr DeviceInfoSet, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA DeviceInfoData, global::System.Text.StringBuilder DeviceInstanceId, int DeviceInstanceIdSize, out int RequiredSize);

		// Token: 0x060001F5 RID: 501
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern int CM_Get_Device_ID(uint dnDevInst, global::System.IntPtr Buffer, int BufferLen, int ulFlags);

		// Token: 0x060001F6 RID: 502
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern int CM_Get_Parent(out uint pdnDevInst, uint dnDevInst, int ulFlags);

		// Token: 0x060001F7 RID: 503
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiGetDeviceRegistryProperty(global::System.IntPtr DeviceInfoSet, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA DeviceInfoData, uint Property, out uint PropertyRegDataType, byte[] PropertyBuffer, uint PropertyBufferSize, out uint RequiredSize);

		// Token: 0x060001F8 RID: 504
		[global::System.Runtime.InteropServices.DllImport("Setupapi", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern global::System.IntPtr SetupDiOpenDevRegKey(global::System.IntPtr hDeviceInfoSet, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA deviceInfoData, int scope, int hwProfile, int parameterRegistryValueKind, int samDesired);

		// Token: 0x060001F9 RID: 505
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern int RegOpenKeyEx(global::System.UIntPtr hKey, string subKey, int ulOptions, int samDesired, out global::System.UIntPtr hkResult);

		// Token: 0x060001FA RID: 506
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern int RegQueryValueEx(global::System.IntPtr hKey, string lpValueName, global::System.IntPtr lpReserved, global::System.IntPtr lpType, global::System.IntPtr lpData, ref uint lpcbData);

		// Token: 0x060001FB RID: 507
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern int RegCloseKey(global::System.IntPtr hKey);

		// Token: 0x060001FC RID: 508
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetServiceStatus(global::System.IntPtr hServiceStatus, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SERVICE_STATUS lpServiceStatus);

		// Token: 0x060001FD RID: 509
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern global::System.IntPtr RegisterServiceCtrlHandlerEx(string lpServiceName, global::Motorola.Common.Communication.TetraUtility.NativeMethods.CtrHandleCallback cbex, global::System.IntPtr context);

		// Token: 0x060001FE RID: 510
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern global::System.IntPtr OpenSCManager(string machineName, string databaseName, uint accessRight);

		// Token: 0x060001FF RID: 511
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool EnumServicesStatusEx(global::System.IntPtr hSCManager, uint InfoLevel, uint dwServiceType, uint dwServiceState, global::System.IntPtr lpServices, uint cbBufSize, out uint pcbBytesNeeded, out uint lpServicesReturned, ref uint lpResumeHandle, string pszGroupName);

		// Token: 0x06000200 RID: 512
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool CloseServiceHandle(global::System.IntPtr hSCObject);

		// Token: 0x06000201 RID: 513
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern uint GetCurrentProcessId();

		// Token: 0x06000202 RID: 514
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern uint WaitForSingleObject(global::System.IntPtr hHandle, uint dwMilliseconds);

		// Token: 0x06000203 RID: 515
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int SetEvent(global::System.IntPtr hEvent);

		// Token: 0x06000204 RID: 516
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int ResetEvent(global::System.IntPtr hEvent);

		// Token: 0x06000205 RID: 517
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern global::System.IntPtr CreateEvent(global::System.IntPtr lpEventAttributes, int bManualReset, int bInitialState, global::System.IntPtr lpName);

		// Token: 0x06000206 RID: 518
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int EscapeCommFunction(global::System.IntPtr hFile, uint dwFunc);

		// Token: 0x06000207 RID: 519
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int SetCommTimeouts(global::System.IntPtr hFile, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommTimeouts timeouts);

		// Token: 0x06000208 RID: 520
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int GetCommState(global::System.IntPtr hFile, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB dcb);

		// Token: 0x06000209 RID: 521
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int SetCommState(global::System.IntPtr hFile, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB dcb);

		// Token: 0x0600020A RID: 522
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int SetupComm(global::System.IntPtr hFile, uint dwInQueue, uint dwOutQueue);

		// Token: 0x0600020B RID: 523 RVA: 0x0000B9B4 File Offset: 0x00009BB4
		internal unsafe static int WriteFile(global::System.IntPtr hFile, byte* lpBuffer, uint nNumberOfBytesToWrite, global::System.IntPtr lpNumberOfBytesWritten, global::System.IntPtr lpOverlapped, ref int lastError)
		{
			int result = global::Motorola.Common.Communication.TetraUtility.NativeMethods.WriteFile(hFile, lpBuffer, nNumberOfBytesToWrite, lpNumberOfBytesWritten, (global::System.Threading.NativeOverlapped*)((void*)lpOverlapped));
			lastError = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
			return result;
		}

		// Token: 0x0600020C RID: 524
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		private unsafe static extern int WriteFile(global::System.IntPtr hFile, byte* lpBuffer, uint nNumberOfBytesToWrite, global::System.IntPtr lpNumberOfBytesWritten, global::System.Threading.NativeOverlapped* lpOverlapped);

		// Token: 0x0600020D RID: 525 RVA: 0x0000B9DC File Offset: 0x00009BDC
		internal unsafe static int ReadFile(global::System.IntPtr hFile, byte* lpBuffer, uint nNumberOfBytesToRead, global::System.IntPtr lpNumberOfBytesRead, global::System.IntPtr lpOverlapped, ref int lastError)
		{
			int result = global::Motorola.Common.Communication.TetraUtility.NativeMethods.ReadFile(hFile, lpBuffer, nNumberOfBytesToRead, lpNumberOfBytesRead, (global::System.Threading.NativeOverlapped*)((void*)lpOverlapped));
			lastError = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
			return result;
		}

		// Token: 0x0600020E RID: 526
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		private unsafe static extern int ReadFile(global::System.IntPtr hFile, byte* lpBuffer, uint nNumberOfBytesToRead, global::System.IntPtr lpNumberOfBytesRead, global::System.Threading.NativeOverlapped* lpOverlapped);

		// Token: 0x0600020F RID: 527
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int SetCommMask(global::System.IntPtr handle, uint dwEvtMask);

		// Token: 0x06000210 RID: 528
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int GetCommModemStatus(global::System.IntPtr hFile, ref uint lpModemStat);

		// Token: 0x06000211 RID: 529
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int ClearCommError(global::System.IntPtr hFile, ref uint lpErrors, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat lpStat);

		// Token: 0x06000212 RID: 530
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern global::System.IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, global::System.IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, global::System.IntPtr hTemplateFile);

		// Token: 0x06000213 RID: 531
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int WaitCommEvent(global::System.IntPtr hFile, ref uint lpEvtMask, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.OVERLAPPED lpOverlapped);

		// Token: 0x06000214 RID: 532
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int GetCommProperties(global::System.IntPtr hFile, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.COMMPROP commProp);

		// Token: 0x06000215 RID: 533
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int GetOverlappedResult(global::System.IntPtr hFile, global::System.IntPtr lpOverlapped, ref uint lpNumberOfBytesTransferred, int bWait);

		// Token: 0x06000216 RID: 534
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int PurgeComm(global::System.IntPtr hFile, uint purgeFlag);

		// Token: 0x06000217 RID: 535
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		internal static extern uint GetFileType(global::System.IntPtr hFile);

		// Token: 0x06000218 RID: 536
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern uint GetDriveType(string lpRootPathName);

		// Token: 0x06000219 RID: 537
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern int CM_Request_Device_Eject(uint dnDevInst, global::System.UIntPtr unknown1, global::System.UIntPtr unknown2, uint unknown3, uint unknown4);

		// Token: 0x0600021A RID: 538
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern int CM_Query_And_Remove_SubTree(uint dnDevInst, out global::Motorola.Common.Communication.TetraUtility.NativeMethods.PNP_VETO_TYPE vetoType, global::System.Text.StringBuilder vetoName, uint vetoNameLength, uint flags);

		// Token: 0x0600021B RID: 539
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", SetLastError = true)]
		internal static extern int CM_Get_DevNode_Status(ref uint pulStatus, ref uint pulProblemNumber, uint dnDevInst, int ulFlags);

		// Token: 0x0600021C RID: 540
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern bool DeviceIoControl(global::System.IntPtr hDevice, uint dwIoControlCode, global::System.IntPtr lpInBuffer, uint nInBufferSize, global::System.IntPtr lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, global::System.IntPtr lpOverlapped);

		// Token: 0x0600021D RID: 541
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool IsWow64Process(global::System.IntPtr hProcess, out bool bWow64Process);

		// Token: 0x0600021E RID: 542
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool SetupDiClassGuidsFromName(string className, global::System.IntPtr pGuidArray, int classGuidArraySize, out int requiredSize);

		// Token: 0x0600021F RID: 543
		[global::System.Runtime.InteropServices.DllImport("setupapi.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		internal static extern bool SetupDiEnumDeviceInfo(global::System.IntPtr hDevInfo, uint memberIndex, ref global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA deviceInfoData);

		// Token: 0x06000220 RID: 544
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr GetDC(global::System.IntPtr ptr);

		// Token: 0x06000221 RID: 545
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern int ReleaseDC(global::System.IntPtr hWnd, global::System.IntPtr hDc);

		// Token: 0x06000222 RID: 546
		[global::System.Runtime.InteropServices.DllImport("gdi32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern global::System.IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, global::System.IntPtr lpInitData);

		// Token: 0x06000223 RID: 547
		[global::System.Runtime.InteropServices.DllImport("gdi32.dll")]
		internal static extern int GetDeviceCaps(global::System.IntPtr hdc, int nIndex);

		// Token: 0x06000224 RID: 548
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool SetProcessDPIAware();

		// Token: 0x06000225 RID: 549
		[global::System.Runtime.InteropServices.DllImport("Ws2_32.dll")]
		internal static extern int setsockopt(global::System.IntPtr s, int level, int optname, ref int optval, int optlen);

		// Token: 0x0400011B RID: 283
		public const uint OS_64_BIT = 64U;

		// Token: 0x0400011C RID: 284
		public const uint OS_32_BIT = 32U;

		// Token: 0x0400011D RID: 285
		public const string MOTO_GEMS_DEVICE = "VID_0CAD";

		// Token: 0x0400011E RID: 286
		public const string PORTABLE_DEVICE_IN_NORMAL_MODE = "PID_0100";

		// Token: 0x0400011F RID: 287
		public const string PORTABLE_DEVICE_IN_PROGRAM_MODE = "PID_9003";

		// Token: 0x04000120 RID: 288
		public const string MTM800E_DEVICE = "PID_9006";

		// Token: 0x04000121 RID: 289
		public const string PAIRED_DEVICE_INTERFACE_0 = "MI_00";

		// Token: 0x04000122 RID: 290
		public const string PAIRED_DEVICE_INTERFACE_1 = "MI_01";

		// Token: 0x04000123 RID: 291
		public const string GEMSTONE_BMP_DEVICE = "PID_9010";

		// Token: 0x04000124 RID: 292
		public const string MTM5400_DATABOX_DEVICE = "PID_9011";

		// Token: 0x04000125 RID: 293
		public const string ARAGORN_DEVICE_NORMAL = "PID_9012";

		// Token: 0x04000126 RID: 294
		public const string BOROMIR_DEVICE_NORMAL = "PID_9013";

		// Token: 0x04000127 RID: 295
		public const string MOTO_GEMS_DEVICE_ID = "0CAD";

		// Token: 0x04000128 RID: 296
		public const string PORTABLE_DEVICE_IN_NORMAL_MODE_ID = "0100";

		// Token: 0x04000129 RID: 297
		public const string PORTABLE_DEVICE_IN_PROGRAM_MODE_ID = "9003";

		// Token: 0x0400012A RID: 298
		public const string MTM800E_DEVICE_ID = "9006";

		// Token: 0x0400012B RID: 299
		public const string GEMSTONE_BMP_DEVICE_ID = "9010";

		// Token: 0x0400012C RID: 300
		public const string MTM5400_DEVICE_DATABOX_MODE_ID = "9011";

		// Token: 0x0400012D RID: 301
		public const string ARAGON_DEVICE_NORMAL_ID = "9012";

		// Token: 0x0400012E RID: 302
		public const string BOROMIR_DEVICE_NORMAL_ID = "9013";

		// Token: 0x0400012F RID: 303
		public const string MASS_STORAGE_DEVICE_ID = "MASS_STORAGE_RADIO";

		// Token: 0x04000130 RID: 304
		public const string RADIO_FLASHSTRAP_DESCRIPTOR = "Motorola TETRA FLASH programming loader";

		// Token: 0x04000131 RID: 305
		public const string RADIO_FLASHSTRAP_DESCRIPTOR_PART_ONE = "TETRA FLASH programming loader";

		// Token: 0x04000132 RID: 306
		public const int NOT_FOUND = -1;

		// Token: 0x04000133 RID: 307
		public const int IS_EQUAL = 0;

		// Token: 0x04000134 RID: 308
		public const int ERROR_SUCCESS = 0;

		// Token: 0x04000135 RID: 309
		public const int DEVICE_NOTIFY_ALL_INTERFACE_CLASSES = 4;

		// Token: 0x04000136 RID: 310
		public const int DBT_DEVTYP_VOLUME = 2;

		// Token: 0x04000137 RID: 311
		public const int DBT_DEVTYP_DEVICEINTERFACE = 5;

		// Token: 0x04000138 RID: 312
		public const int DBT_DEVTYP_HANDLE = 6;

		// Token: 0x04000139 RID: 313
		public const int WM_DEVICECHANGE = 537;

		// Token: 0x0400013A RID: 314
		public const int DBT_DEVICEARRIVAL = 32768;

		// Token: 0x0400013B RID: 315
		public const int DBT_DEVICEREMOVECOMPLETE = 32772;

		// Token: 0x0400013C RID: 316
		public const uint DEVICE_NOTIFY_WINDOW_HANDLE = 0U;

		// Token: 0x0400013D RID: 317
		public const uint DEVICE_NOTIFY_SERVICE_HANDLE = 1U;

		// Token: 0x0400013E RID: 318
		public const string VCOM_CLASS_INTERFACE = "9664C324-B905-4A34-B057-D97436E7B565";

		// Token: 0x0400013F RID: 319
		public const int DIGCF_PRESENT = 2;

		// Token: 0x04000140 RID: 320
		public const int DIGCF_DEVICEINTERFACE = 16;

		// Token: 0x04000141 RID: 321
		public const int INVALID_HANDLE_VALUE = -1;

		// Token: 0x04000142 RID: 322
		public const int ERROR_INSUFFICIENT_BUFFER = 122;

		// Token: 0x04000143 RID: 323
		public const int CR_SUCCESS = 0;

		// Token: 0x04000144 RID: 324
		public const int DICS_FLAG_GLOBAL = 1;

		// Token: 0x04000145 RID: 325
		public const int DIREG_DEV = 1;

		// Token: 0x04000146 RID: 326
		public const int STANDARD_RIGHTS_READ = 131072;

		// Token: 0x04000147 RID: 327
		public const int KEY_QUERY_VALUE = 1;

		// Token: 0x04000148 RID: 328
		public const int KEY_ENUMERATE_SUB_KEYS = 8;

		// Token: 0x04000149 RID: 329
		public const int KEY_NOTIFY = 16;

		// Token: 0x0400014A RID: 330
		public const int SYNCHRONIZE = 1048576;

		// Token: 0x0400014B RID: 331
		public const uint SERVICE_CONTROL_STOP = 1U;

		// Token: 0x0400014C RID: 332
		public const uint SERVICE_CONTROL_PAUSE = 2U;

		// Token: 0x0400014D RID: 333
		public const uint SERVICE_CONTROL_CONTINUE = 3U;

		// Token: 0x0400014E RID: 334
		public const uint SERVICE_CONTROL_INTERROGATE = 4U;

		// Token: 0x0400014F RID: 335
		public const uint SERVICE_CONTROL_SHUTDOWN = 5U;

		// Token: 0x04000150 RID: 336
		public const uint SERVICE_CONTROL_DEVICEEVENT = 11U;

		// Token: 0x04000151 RID: 337
		public const uint NO_ERROR = 0U;

		// Token: 0x04000152 RID: 338
		public const uint WAIT_ABANDONED = 128U;

		// Token: 0x04000153 RID: 339
		public const uint WAIT_OBJECT_0 = 0U;

		// Token: 0x04000154 RID: 340
		public const uint WAIT_TIMEOUT = 258U;

		// Token: 0x04000155 RID: 341
		public const uint WAIT_FAILED = 4294967295U;

		// Token: 0x04000156 RID: 342
		public const uint STANDARD_RIGHTS_REQUIRED = 983040U;

		// Token: 0x04000157 RID: 343
		public const uint SC_ENUM_PROCESS_INFO = 0U;

		// Token: 0x04000158 RID: 344
		public const int ERROR_MORE_DATA = 234;

		// Token: 0x04000159 RID: 345
		public const int DEVICE_NAME_LENGTH = 1024;

		// Token: 0x0400015A RID: 346
		public const int BUFFER_SIZE = 1024;

		// Token: 0x0400015B RID: 347
		public const uint GENERIC_READ = 2147483648U;

		// Token: 0x0400015C RID: 348
		public const uint GENERIC_WRITE = 1073741824U;

		// Token: 0x0400015D RID: 349
		public const uint OPEN_EXISTING = 3U;

		// Token: 0x0400015E RID: 350
		public const uint FILE_FLAG_OVERLAPPED = 1073741824U;

		// Token: 0x0400015F RID: 351
		public const uint FILE_ANY_ACCESS = 0U;

		// Token: 0x04000160 RID: 352
		public const uint FILE_SHARE_READ = 1U;

		// Token: 0x04000161 RID: 353
		public const uint FILE_SHARE_WRITE = 2U;

		// Token: 0x04000162 RID: 354
		public const uint FILE_TYPE_UNKNOWN = 0U;

		// Token: 0x04000163 RID: 355
		public const uint FILE_TYPE_DISK = 1U;

		// Token: 0x04000164 RID: 356
		public const uint FILE_TYPE_CHAR = 2U;

		// Token: 0x04000165 RID: 357
		public const uint FILE_TYPE_PIPE = 3U;

		// Token: 0x04000166 RID: 358
		public const uint FILE_TYPE_REMOTE = 32768U;

		// Token: 0x04000167 RID: 359
		public const uint PURGE_TXABORT = 1U;

		// Token: 0x04000168 RID: 360
		public const uint PURGE_RXABORT = 2U;

		// Token: 0x04000169 RID: 361
		public const uint PURGE_TXCLEAR = 4U;

		// Token: 0x0400016A RID: 362
		public const uint PURGE_RXCLEAR = 8U;

		// Token: 0x0400016B RID: 363
		public const uint ERROR_OPERATION_ABORTED = 995U;

		// Token: 0x0400016C RID: 364
		public const uint ERROR_IO_INCOMPLETE = 996U;

		// Token: 0x0400016D RID: 365
		public const uint ERROR_IO_PENDING = 997U;

		// Token: 0x0400016E RID: 366
		public const uint ERROR_INVALID_USER_BUFFER = 1784U;

		// Token: 0x0400016F RID: 367
		public const int ERROR_NO_MORE_ITEMS = 259;

		// Token: 0x04000170 RID: 368
		public const uint DN_DISABLEABLE = 8192U;

		// Token: 0x04000171 RID: 369
		public const uint DN_REMOVABLE = 16384U;

		// Token: 0x04000172 RID: 370
		public const int USB_CTRL_COMMAND_SIZE = 8;

		// Token: 0x04000173 RID: 371
		public const uint IO_USB_CTRL_REQUEST_CODE = 2147492995U;

		// Token: 0x04000174 RID: 372
		public const uint IO_USB_CTRL_RESET_PORT = 2147492899U;

		// Token: 0x04000175 RID: 373
		public const string USB_HUB_CLASS_INTERFACE = "F18A0E88-C30C-11D0-8815-00A0C906BED8";

		// Token: 0x04000176 RID: 374
		public const int DIREG_DRV = 2;

		// Token: 0x04000177 RID: 375
		public const int USB_PIPE_LIST_SIZE = 330;

		// Token: 0x04000178 RID: 376
		public const int MAX_DESCRIPTOR_SIZE = 512;

		// Token: 0x04000179 RID: 377
		public const byte STRING_DESCRIPTOR_TYPE = 3;

		// Token: 0x0400017A RID: 378
		public const uint IOCTL_USB_GET_NODE_CONNECTION_INFORMATION_EX = 2229320U;

		// Token: 0x0400017B RID: 379
		public const uint IOCTL_USB_GET_DESCRIPTOR_FROM_NODE_CONNECTION = 2229264U;

		// Token: 0x0400017C RID: 380
		public const uint IOCTL_USB_HUB_CYCLE_PORT = 2229316U;

		// Token: 0x0400017D RID: 381
		public const uint IOCTL_USB_USER_REQUEST = 2229304U;

		// Token: 0x0400017E RID: 382
		public const uint USBUSER_GET_BANDWIDTH_INFORMATION = 5U;

		// Token: 0x0400017F RID: 383
		public const uint METHOD_BUFFERED = 0U;

		// Token: 0x04000180 RID: 384
		public const uint METHOD_IN_DIRECT = 1U;

		// Token: 0x04000181 RID: 385
		public const uint METHOD_OUT_DIRECT = 2U;

		// Token: 0x04000182 RID: 386
		public const uint METHOD_NEITHER = 3U;

		// Token: 0x04000183 RID: 387
		public const uint FILE_DEVICE_FILE_SYSTEM = 9U;

		// Token: 0x04000184 RID: 388
		public const uint FILE_DEVICE_MASS_STORAGE = 45U;

		// Token: 0x04000185 RID: 389
		public const int SCSI_COMMAND_SIZE = 16;

		// Token: 0x04000186 RID: 390
		public const int SPT_SENSE_LENGTH = 32;

		// Token: 0x04000187 RID: 391
		public const byte SCSI_IOCTL_DATA_OUT = 0;

		// Token: 0x04000188 RID: 392
		public const byte SCSI_IOCTL_DATA_IN = 1;

		// Token: 0x04000189 RID: 393
		public const byte SCSI_IOCTL_DATA_UNSPECIFIED = 2;

		// Token: 0x0400018A RID: 394
		public const int DRIVERVERSION = 0;

		// Token: 0x0400018B RID: 395
		public const int TECHNOLOGY = 2;

		// Token: 0x0400018C RID: 396
		public const int HORZSIZE = 4;

		// Token: 0x0400018D RID: 397
		public const int VERTSIZE = 6;

		// Token: 0x0400018E RID: 398
		public const int HORZRES = 8;

		// Token: 0x0400018F RID: 399
		public const int VERTRES = 10;

		// Token: 0x04000190 RID: 400
		public const int BITSPIXEL = 12;

		// Token: 0x04000191 RID: 401
		public const int PLANES = 14;

		// Token: 0x04000192 RID: 402
		public const int NUMBRUSHES = 16;

		// Token: 0x04000193 RID: 403
		public const int NUMPENS = 18;

		// Token: 0x04000194 RID: 404
		public const int NUMMARKERS = 20;

		// Token: 0x04000195 RID: 405
		public const int NUMFONTS = 22;

		// Token: 0x04000196 RID: 406
		public const int NUMCOLORS = 24;

		// Token: 0x04000197 RID: 407
		public const int PDEVICESIZE = 26;

		// Token: 0x04000198 RID: 408
		public const int CURVECAPS = 28;

		// Token: 0x04000199 RID: 409
		public const int LINECAPS = 30;

		// Token: 0x0400019A RID: 410
		public const int POLYGONALCAPS = 32;

		// Token: 0x0400019B RID: 411
		public const int TEXTCAPS = 34;

		// Token: 0x0400019C RID: 412
		public const int CLIPCAPS = 36;

		// Token: 0x0400019D RID: 413
		public const int RASTERCAPS = 38;

		// Token: 0x0400019E RID: 414
		public const int ASPECTX = 40;

		// Token: 0x0400019F RID: 415
		public const int ASPECTY = 42;

		// Token: 0x040001A0 RID: 416
		public const int ASPECTXY = 44;

		// Token: 0x040001A1 RID: 417
		public const int SHADEBLENDCAPS = 45;

		// Token: 0x040001A2 RID: 418
		public const int LOGPIXELSX = 88;

		// Token: 0x040001A3 RID: 419
		public const int LOGPIXELSY = 90;

		// Token: 0x040001A4 RID: 420
		public const int SIZEPALETTE = 104;

		// Token: 0x040001A5 RID: 421
		public const int NUMRESERVED = 106;

		// Token: 0x040001A6 RID: 422
		public const int COLORRES = 108;

		// Token: 0x040001A7 RID: 423
		public const int PHYSICALWIDTH = 110;

		// Token: 0x040001A8 RID: 424
		public const int PHYSICALHEIGHT = 111;

		// Token: 0x040001A9 RID: 425
		public const int PHYSICALOFFSETX = 112;

		// Token: 0x040001AA RID: 426
		public const int PHYSICALOFFSETY = 113;

		// Token: 0x040001AB RID: 427
		public const int SCALINGFACTORX = 114;

		// Token: 0x040001AC RID: 428
		public const int SCALINGFACTORY = 115;

		// Token: 0x040001AD RID: 429
		public const int VREFRESH = 116;

		// Token: 0x040001AE RID: 430
		public const int DESKTOPVERTRES = 117;

		// Token: 0x040001AF RID: 431
		public const int DESKTOPHORZRES = 118;

		// Token: 0x040001B0 RID: 432
		public const int BLTALIGNMENT = 119;

		// Token: 0x040001B1 RID: 433
		public const int SERVICE_NO_CHANGE = -1;

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000227 RID: 551
		public delegate uint CtrHandleCallback(uint control, uint eventType, global::System.IntPtr eventData, global::System.IntPtr context);

		// Token: 0x0200003D RID: 61
		public enum State : uint
		{
			// Token: 0x040001B3 RID: 435
			SERVICE_NONE,
			// Token: 0x040001B4 RID: 436
			SERVICE_STOPPED,
			// Token: 0x040001B5 RID: 437
			SERVICE_START_PENDING,
			// Token: 0x040001B6 RID: 438
			SERVICE_STOP_PENDING,
			// Token: 0x040001B7 RID: 439
			SERVICE_RUNNING,
			// Token: 0x040001B8 RID: 440
			SERVICE_CONTINUE_PENDING,
			// Token: 0x040001B9 RID: 441
			SERVICE_PAUSE_PENDING,
			// Token: 0x040001BA RID: 442
			SERVICE_PAUSED
		}

		// Token: 0x0200003E RID: 62
		public enum ServiceControlManagerType : uint
		{
			// Token: 0x040001BC RID: 444
			SC_MANAGER_NONE,
			// Token: 0x040001BD RID: 445
			SC_MANAGER_CONNECT,
			// Token: 0x040001BE RID: 446
			SC_MANAGER_CREATE_SERVICE,
			// Token: 0x040001BF RID: 447
			SC_MANAGER_ENUMERATE_SERVICE = 4U,
			// Token: 0x040001C0 RID: 448
			SC_MANAGER_LOCK = 8U,
			// Token: 0x040001C1 RID: 449
			SC_MANAGER_QUERY_LOCK_STATUS = 16U,
			// Token: 0x040001C2 RID: 450
			SC_MANAGER_MODIFY_BOOT_CONFIG = 32U,
			// Token: 0x040001C3 RID: 451
			SC_MANAGER_ALL_ACCESS = 983103U
		}

		// Token: 0x0200003F RID: 63
		public enum ServiceType
		{
			// Token: 0x040001C5 RID: 453
			SERVICE_NONE,
			// Token: 0x040001C6 RID: 454
			SERVICE_KERNEL_DRIVER,
			// Token: 0x040001C7 RID: 455
			SERVICE_FILE_SYSTEM_DRIVER,
			// Token: 0x040001C8 RID: 456
			SERVICE_WIN32_OWN_PROCESS = 16,
			// Token: 0x040001C9 RID: 457
			SERVICE_WIN32_SHARE_PROCESS = 32,
			// Token: 0x040001CA RID: 458
			SERVICE_INTERACTIVE_PROCESS = 256,
			// Token: 0x040001CB RID: 459
			SERVICETYPE_NO_CHANGE = -1,
			// Token: 0x040001CC RID: 460
			SERVICE_WIN32 = 48
		}

		// Token: 0x02000040 RID: 64
		public enum ServiceStateRequest : uint
		{
			// Token: 0x040001CE RID: 462
			SERVICE_NONE,
			// Token: 0x040001CF RID: 463
			SERVICE_ACTIVE,
			// Token: 0x040001D0 RID: 464
			SERVICE_INACTIVE,
			// Token: 0x040001D1 RID: 465
			SERVICE_STATE_ALL
		}

		// Token: 0x02000041 RID: 65
		public enum WinDriveType : uint
		{
			// Token: 0x040001D3 RID: 467
			DRIVE_UNKNOWN,
			// Token: 0x040001D4 RID: 468
			DRIVE_NO_ROOT_DIR,
			// Token: 0x040001D5 RID: 469
			DRIVE_REMOVABLE,
			// Token: 0x040001D6 RID: 470
			DRIVE_FIXED,
			// Token: 0x040001D7 RID: 471
			DRIVE_REMOTE,
			// Token: 0x040001D8 RID: 472
			DRIVE_CDROM,
			// Token: 0x040001D9 RID: 473
			DRIVE_RAMDISK
		}

		// Token: 0x02000042 RID: 66
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct SERVICE_STATUS
		{
			// Token: 0x040001DA RID: 474
			public static readonly int SizeOf = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SERVICE_STATUS));

			// Token: 0x040001DB RID: 475
			public uint serviceType;

			// Token: 0x040001DC RID: 476
			public uint currentState;

			// Token: 0x040001DD RID: 477
			public uint controlsAccepted;

			// Token: 0x040001DE RID: 478
			public uint win32ExitCode;

			// Token: 0x040001DF RID: 479
			public uint serviceSpecificExitCode;

			// Token: 0x040001E0 RID: 480
			public uint checkPoint;

			// Token: 0x040001E1 RID: 481
			public uint waitHint;
		}

		// Token: 0x02000043 RID: 67
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public struct DEV_BROADCAST_HDR
		{
			// Token: 0x040001E2 RID: 482
			public uint dbcc_size;

			// Token: 0x040001E3 RID: 483
			public uint dbcc_devicetype;

			// Token: 0x040001E4 RID: 484
			public uint dbcc_reserved;
		}

		// Token: 0x02000044 RID: 68
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public struct DEV_BROADCAST_VOLUME
		{
			// Token: 0x040001E5 RID: 485
			public uint dbcc_size;

			// Token: 0x040001E6 RID: 486
			public uint dbcc_devicetype;

			// Token: 0x040001E7 RID: 487
			public uint dbcc_reserved;

			// Token: 0x040001E8 RID: 488
			public uint dbcv_unitmask;

			// Token: 0x040001E9 RID: 489
			public ushort dbcv_flags;
		}

		// Token: 0x02000045 RID: 69
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public struct DEV_BROADCAST_DEVICEINTERFACE
		{
			// Token: 0x040001EA RID: 490
			public uint dbcc_size;

			// Token: 0x040001EB RID: 491
			public uint dbcc_devicetype;

			// Token: 0x040001EC RID: 492
			public uint dbcc_reserved;

			// Token: 0x040001ED RID: 493
			public global::System.Guid dbcc_classguid;

			// Token: 0x040001EE RID: 494
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1024)]
			public string dbcc_name;
		}

		// Token: 0x02000046 RID: 70
		public struct SP_DEVICE_INTERFACE_DATA
		{
			// Token: 0x040001EF RID: 495
			public uint cbSize;

			// Token: 0x040001F0 RID: 496
			public global::System.Guid InterfaceClassGuid;

			// Token: 0x040001F1 RID: 497
			public uint Flags;

			// Token: 0x040001F2 RID: 498
			internal global::System.IntPtr Reserved;
		}

		// Token: 0x02000047 RID: 71
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public struct SP_DEVICE_INTERFACE_DETAIL_DATA
		{
			// Token: 0x040001F3 RID: 499
			public uint cbSize;

			// Token: 0x040001F4 RID: 500
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1024)]
			public string DevicePath;
		}

		// Token: 0x02000048 RID: 72
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, Pack = 1)]
		public struct SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X86
		{
			// Token: 0x040001F5 RID: 501
			public uint cbSize;

			// Token: 0x040001F6 RID: 502
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1)]
			public string DevicePath;
		}

		// Token: 0x02000049 RID: 73
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public struct SP_DEVICE_INTERFACE_DETAIL_DATA_V2_X64
		{
			// Token: 0x040001F7 RID: 503
			public uint cbSize;

			// Token: 0x040001F8 RID: 504
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 1)]
			public string DevicePath;
		}

		// Token: 0x0200004A RID: 74
		public struct SP_DEVINFO_DATA
		{
			// Token: 0x040001F9 RID: 505
			public uint cbSize;

			// Token: 0x040001FA RID: 506
			public global::System.Guid ClassGuid;

			// Token: 0x040001FB RID: 507
			public uint DevInst;

			// Token: 0x040001FC RID: 508
			internal global::System.IntPtr Reserved;
		}

		// Token: 0x0200004B RID: 75
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct SERVICE_STATUS_PROCESS
		{
			// Token: 0x040001FD RID: 509
			public static readonly int SizeOf = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SERVICE_STATUS_PROCESS));

			// Token: 0x040001FE RID: 510
			public uint dwServiceType;

			// Token: 0x040001FF RID: 511
			public uint dwCurrentState;

			// Token: 0x04000200 RID: 512
			public uint dwControlsAccepted;

			// Token: 0x04000201 RID: 513
			public uint dwWin32ExitCode;

			// Token: 0x04000202 RID: 514
			public uint dwServiceSpecificExitCode;

			// Token: 0x04000203 RID: 515
			public uint dwCheckPoint;

			// Token: 0x04000204 RID: 516
			public uint dwWaitHint;

			// Token: 0x04000205 RID: 517
			public uint dwProcessId;

			// Token: 0x04000206 RID: 518
			public uint dwServiceFlags;
		}

		// Token: 0x0200004C RID: 76
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct ENUM_SERVICE_STATUS_PROCESS
		{
			// Token: 0x04000207 RID: 519
			public static readonly int SizeOf = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.ENUM_SERVICE_STATUS_PROCESS));

			// Token: 0x04000208 RID: 520
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]
			public string pServiceName;

			// Token: 0x04000209 RID: 521
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)]
			public string pDisplayName;

			// Token: 0x0400020A RID: 522
			public global::Motorola.Common.Communication.TetraUtility.NativeMethods.SERVICE_STATUS_PROCESS ServiceStatus;
		}

		// Token: 0x0200004D RID: 77
		public enum DtrControl
		{
			// Token: 0x0400020C RID: 524
			Disable,
			// Token: 0x0400020D RID: 525
			Enable,
			// Token: 0x0400020E RID: 526
			Handshake
		}

		// Token: 0x0200004E RID: 78
		public enum RtsControl
		{
			// Token: 0x04000210 RID: 528
			Disable,
			// Token: 0x04000211 RID: 529
			Enable,
			// Token: 0x04000212 RID: 530
			Handshake,
			// Token: 0x04000213 RID: 531
			Toggle
		}

		// Token: 0x0200004F RID: 79
		public struct DCB
		{
			// Token: 0x0600022D RID: 557 RVA: 0x0000BA45 File Offset: 0x00009C45
			private static int IniFBinary()
			{
				return global::System.Collections.Specialized.BitVector32.CreateMask();
			}

			// Token: 0x0600022E RID: 558 RVA: 0x0000BA4C File Offset: 0x00009C4C
			private static int IniFParity()
			{
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFBinary());
			}

			// Token: 0x0600022F RID: 559 RVA: 0x0000BA58 File Offset: 0x00009C58
			private static int IniFOutxCtsFlow()
			{
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFParity());
			}

			// Token: 0x06000230 RID: 560 RVA: 0x0000BA64 File Offset: 0x00009C64
			private static int IniFOutxDsrFlow()
			{
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFOutxCtsFlow());
			}

			// Token: 0x06000231 RID: 561 RVA: 0x0000BA70 File Offset: 0x00009C70
			private static int IniFDsrSensitivity()
			{
				int previous = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFOutxDsrFlow());
				previous = global::System.Collections.Specialized.BitVector32.CreateMask(previous);
				return global::System.Collections.Specialized.BitVector32.CreateMask(previous);
			}

			// Token: 0x06000232 RID: 562 RVA: 0x0000BA95 File Offset: 0x00009C95
			private static int IniFTXContinueOnXoff()
			{
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFDsrSensitivity());
			}

			// Token: 0x06000233 RID: 563 RVA: 0x0000BAA1 File Offset: 0x00009CA1
			private static int IniFOutX()
			{
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFTXContinueOnXoff());
			}

			// Token: 0x06000234 RID: 564 RVA: 0x0000BAAD File Offset: 0x00009CAD
			private static int IniFInX()
			{
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFOutX());
			}

			// Token: 0x06000235 RID: 565 RVA: 0x0000BAB9 File Offset: 0x00009CB9
			private static int IniFErrorChar()
			{
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFInX());
			}

			// Token: 0x06000236 RID: 566 RVA: 0x0000BAC5 File Offset: 0x00009CC5
			private static int IniFNull()
			{
				return global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFErrorChar());
			}

			// Token: 0x06000237 RID: 567 RVA: 0x0000BAD4 File Offset: 0x00009CD4
			private static int IniFAbortOnError()
			{
				int previous = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFNull());
				previous = global::System.Collections.Specialized.BitVector32.CreateMask(previous);
				return global::System.Collections.Specialized.BitVector32.CreateMask(previous);
			}

			// Token: 0x06000238 RID: 568 RVA: 0x0000BAFC File Offset: 0x00009CFC
			private static global::System.Collections.Specialized.BitVector32.Section IniFDtrControl()
			{
				global::System.Collections.Specialized.BitVector32.Section previous = global::System.Collections.Specialized.BitVector32.CreateSection(1);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				return global::System.Collections.Specialized.BitVector32.CreateSection(2, previous);
			}

			// Token: 0x06000239 RID: 569 RVA: 0x0000BB30 File Offset: 0x00009D30
			private static global::System.Collections.Specialized.BitVector32.Section IniFRtsControl()
			{
				global::System.Collections.Specialized.BitVector32.Section previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFDtrControl());
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, previous);
				global::System.Collections.Specialized.BitVector32.Section section = global::System.Collections.Specialized.BitVector32.CreateSection(3, previous);
				previous = global::System.Collections.Specialized.BitVector32.CreateSection(1, section);
				return section;
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x0600023A RID: 570 RVA: 0x0000BB82 File Offset: 0x00009D82
			// (set) Token: 0x0600023B RID: 571 RVA: 0x0000BB94 File Offset: 0x00009D94
			public bool Binary
			{
				get
				{
					return this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fBinary];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fBinary] = value;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x0600023C RID: 572 RVA: 0x0000BBA7 File Offset: 0x00009DA7
			// (set) Token: 0x0600023D RID: 573 RVA: 0x0000BBB9 File Offset: 0x00009DB9
			public bool CheckParity
			{
				get
				{
					return this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fParity];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fParity] = value;
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x0600023E RID: 574 RVA: 0x0000BBCC File Offset: 0x00009DCC
			// (set) Token: 0x0600023F RID: 575 RVA: 0x0000BBDE File Offset: 0x00009DDE
			public bool OutxCtsFlow
			{
				get
				{
					return this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fOutxCtsFlow];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fOutxCtsFlow] = value;
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x06000240 RID: 576 RVA: 0x0000BBF1 File Offset: 0x00009DF1
			// (set) Token: 0x06000241 RID: 577 RVA: 0x0000BC03 File Offset: 0x00009E03
			public bool OutxDsrFlow
			{
				get
				{
					return this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fOutxDsrFlow];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fOutxDsrFlow] = value;
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000242 RID: 578 RVA: 0x0000BC16 File Offset: 0x00009E16
			// (set) Token: 0x06000243 RID: 579 RVA: 0x0000BC28 File Offset: 0x00009E28
			public global::Motorola.Common.Communication.TetraUtility.NativeMethods.DtrControl DtrControl
			{
				get
				{
					return (global::Motorola.Common.Communication.TetraUtility.NativeMethods.DtrControl)this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fDtrControl];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fDtrControl] = (int)value;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x06000244 RID: 580 RVA: 0x0000BC3B File Offset: 0x00009E3B
			// (set) Token: 0x06000245 RID: 581 RVA: 0x0000BC4D File Offset: 0x00009E4D
			public bool DsrSensitivity
			{
				get
				{
					return this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fDsrSensitivity];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fDsrSensitivity] = value;
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000246 RID: 582 RVA: 0x0000BC60 File Offset: 0x00009E60
			// (set) Token: 0x06000247 RID: 583 RVA: 0x0000BC72 File Offset: 0x00009E72
			public bool TxContinueOnXoff
			{
				get
				{
					return this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fTXContinueOnXoff];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fTXContinueOnXoff] = value;
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000248 RID: 584 RVA: 0x0000BC85 File Offset: 0x00009E85
			// (set) Token: 0x06000249 RID: 585 RVA: 0x0000BC97 File Offset: 0x00009E97
			public bool OutX
			{
				get
				{
					return this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fOutX];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fOutX] = value;
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x0600024A RID: 586 RVA: 0x0000BCAA File Offset: 0x00009EAA
			// (set) Token: 0x0600024B RID: 587 RVA: 0x0000BCBC File Offset: 0x00009EBC
			public bool InX
			{
				get
				{
					return this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fInX];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fInX] = value;
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x0600024C RID: 588 RVA: 0x0000BCCF File Offset: 0x00009ECF
			// (set) Token: 0x0600024D RID: 589 RVA: 0x0000BCE1 File Offset: 0x00009EE1
			public bool ReplaceErrorChar
			{
				get
				{
					return this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fErrorChar];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fErrorChar] = value;
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x0600024E RID: 590 RVA: 0x0000BCF4 File Offset: 0x00009EF4
			// (set) Token: 0x0600024F RID: 591 RVA: 0x0000BD06 File Offset: 0x00009F06
			public bool Null
			{
				get
				{
					return this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fNull];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fNull] = value;
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x06000250 RID: 592 RVA: 0x0000BD19 File Offset: 0x00009F19
			// (set) Token: 0x06000251 RID: 593 RVA: 0x0000BD2B File Offset: 0x00009F2B
			public global::Motorola.Common.Communication.TetraUtility.NativeMethods.RtsControl RtsControl
			{
				get
				{
					return (global::Motorola.Common.Communication.TetraUtility.NativeMethods.RtsControl)this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fRtsControl];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fRtsControl] = (int)value;
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x06000252 RID: 594 RVA: 0x0000BD3E File Offset: 0x00009F3E
			// (set) Token: 0x06000253 RID: 595 RVA: 0x0000BD50 File Offset: 0x00009F50
			public bool AbortOnError
			{
				get
				{
					return this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fAbortOnError];
				}
				set
				{
					this.Flags[global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.fAbortOnError] = value;
				}
			}

			// Token: 0x04000214 RID: 532
			public uint DCBLength;

			// Token: 0x04000215 RID: 533
			public uint BaudRate;

			// Token: 0x04000216 RID: 534
			private global::System.Collections.Specialized.BitVector32 Flags;

			// Token: 0x04000217 RID: 535
			private ushort wReserved;

			// Token: 0x04000218 RID: 536
			public ushort XonLim;

			// Token: 0x04000219 RID: 537
			public ushort XoffLim;

			// Token: 0x0400021A RID: 538
			public byte ByteSize;

			// Token: 0x0400021B RID: 539
			public byte Parity;

			// Token: 0x0400021C RID: 540
			public byte StopBits;

			// Token: 0x0400021D RID: 541
			public char XonChar;

			// Token: 0x0400021E RID: 542
			public char XoffChar;

			// Token: 0x0400021F RID: 543
			public char ErrorChar;

			// Token: 0x04000220 RID: 544
			public char EofChar;

			// Token: 0x04000221 RID: 545
			public char EvtChar;

			// Token: 0x04000222 RID: 546
			private ushort wReserved1;

			// Token: 0x04000223 RID: 547
			private static readonly int fBinary = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFBinary();

			// Token: 0x04000224 RID: 548
			private static readonly int fParity = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFParity();

			// Token: 0x04000225 RID: 549
			private static readonly int fOutxCtsFlow = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFOutxCtsFlow();

			// Token: 0x04000226 RID: 550
			private static readonly int fOutxDsrFlow = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFOutxDsrFlow();

			// Token: 0x04000227 RID: 551
			private static readonly global::System.Collections.Specialized.BitVector32.Section fDtrControl = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFDtrControl();

			// Token: 0x04000228 RID: 552
			private static readonly int fDsrSensitivity = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFDsrSensitivity();

			// Token: 0x04000229 RID: 553
			private static readonly int fTXContinueOnXoff = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFTXContinueOnXoff();

			// Token: 0x0400022A RID: 554
			private static readonly int fOutX = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFOutX();

			// Token: 0x0400022B RID: 555
			private static readonly int fInX = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFInX();

			// Token: 0x0400022C RID: 556
			private static readonly int fErrorChar = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFErrorChar();

			// Token: 0x0400022D RID: 557
			private static readonly int fNull = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFNull();

			// Token: 0x0400022E RID: 558
			private static readonly global::System.Collections.Specialized.BitVector32.Section fRtsControl = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFRtsControl();

			// Token: 0x0400022F RID: 559
			private static readonly int fAbortOnError = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB.IniFAbortOnError();
		}

		// Token: 0x02000050 RID: 80
		public struct CommTimeouts
		{
			// Token: 0x04000230 RID: 560
			public uint ReadIntervalTimeout;

			// Token: 0x04000231 RID: 561
			public uint ReadTotalTimeoutMultiplier;

			// Token: 0x04000232 RID: 562
			public uint ReadTotalTimeoutConstant;

			// Token: 0x04000233 RID: 563
			public uint WriteTotalTimeoutMultiplier;

			// Token: 0x04000234 RID: 564
			public uint WriteTotalTimeoutConstant;
		}

		// Token: 0x02000051 RID: 81
		public struct OVERLAPPED
		{
			// Token: 0x06000255 RID: 597 RVA: 0x0000BDF3 File Offset: 0x00009FF3
			public OVERLAPPED(global::System.UIntPtr uInternal, global::System.UIntPtr uInernalHigh, uint offset, uint offsetHigh, global::System.IntPtr cEvent)
			{
				this.Internal = uInternal;
				this.InternalHigh = uInernalHigh;
				this.Offset = offset;
				this.OffsetHigh = offsetHigh;
				this.hEvent = cEvent;
			}

			// Token: 0x04000235 RID: 565
			internal global::System.UIntPtr Internal;

			// Token: 0x04000236 RID: 566
			internal global::System.UIntPtr InternalHigh;

			// Token: 0x04000237 RID: 567
			public uint Offset;

			// Token: 0x04000238 RID: 568
			public uint OffsetHigh;

			// Token: 0x04000239 RID: 569
			internal global::System.IntPtr hEvent;
		}

		// Token: 0x02000052 RID: 82
		public enum CommEventFlags : uint
		{
			// Token: 0x0400023B RID: 571
			NONE,
			// Token: 0x0400023C RID: 572
			RXCHAR,
			// Token: 0x0400023D RID: 573
			RXFLAG,
			// Token: 0x0400023E RID: 574
			TXEMPTY = 4U,
			// Token: 0x0400023F RID: 575
			CTS = 8U,
			// Token: 0x04000240 RID: 576
			DSR = 16U,
			// Token: 0x04000241 RID: 577
			RLSD = 32U,
			// Token: 0x04000242 RID: 578
			BREAK = 64U,
			// Token: 0x04000243 RID: 579
			ERR = 128U,
			// Token: 0x04000244 RID: 580
			RING = 256U,
			// Token: 0x04000245 RID: 581
			PERR = 512U,
			// Token: 0x04000246 RID: 582
			RX80FULL = 1024U,
			// Token: 0x04000247 RID: 583
			EVENT1 = 2048U,
			// Token: 0x04000248 RID: 584
			EVENT2 = 4096U,
			// Token: 0x04000249 RID: 585
			POWER = 8192U,
			// Token: 0x0400024A RID: 586
			ALLCE = 16383U,
			// Token: 0x0400024B RID: 587
			ALLCE_2 = 507U,
			// Token: 0x0400024C RID: 588
			ALLPC = 511U
		}

		// Token: 0x02000053 RID: 83
		public enum EventFlags
		{
			// Token: 0x0400024E RID: 590
			EVENT_NONE,
			// Token: 0x0400024F RID: 591
			EVENT_PULSE,
			// Token: 0x04000250 RID: 592
			EVENT_RESET,
			// Token: 0x04000251 RID: 593
			EVENT_SET
		}

		// Token: 0x02000054 RID: 84
		public enum CommErrorFlags : uint
		{
			// Token: 0x04000253 RID: 595
			RXOVER = 1U,
			// Token: 0x04000254 RID: 596
			OVERRUN,
			// Token: 0x04000255 RID: 597
			RXPARITY = 4U,
			// Token: 0x04000256 RID: 598
			FRAME = 8U,
			// Token: 0x04000257 RID: 599
			BREAK = 16U,
			// Token: 0x04000258 RID: 600
			TXFULL = 256U,
			// Token: 0x04000259 RID: 601
			IOE = 1024U,
			// Token: 0x0400025A RID: 602
			MODE = 32768U
		}

		// Token: 0x02000055 RID: 85
		public enum CommModemStatusFlags
		{
			// Token: 0x0400025C RID: 604
			MS_CTS_ON = 16,
			// Token: 0x0400025D RID: 605
			MS_DSR_ON = 32,
			// Token: 0x0400025E RID: 606
			MS_RING_ON = 64,
			// Token: 0x0400025F RID: 607
			MS_RLSD_ON = 128
		}

		// Token: 0x02000056 RID: 86
		public enum CommEscapes : uint
		{
			// Token: 0x04000261 RID: 609
			NONE,
			// Token: 0x04000262 RID: 610
			SETXOFF,
			// Token: 0x04000263 RID: 611
			SETXON,
			// Token: 0x04000264 RID: 612
			SETRTS,
			// Token: 0x04000265 RID: 613
			CLRRTS,
			// Token: 0x04000266 RID: 614
			SETDTR,
			// Token: 0x04000267 RID: 615
			CLRDTR,
			// Token: 0x04000268 RID: 616
			SETBREAK = 8U,
			// Token: 0x04000269 RID: 617
			CLRBREAK,
			// Token: 0x0400026A RID: 618
			SETIR,
			// Token: 0x0400026B RID: 619
			CLRIR
		}

		// Token: 0x02000057 RID: 87
		public enum APIErrors
		{
			// Token: 0x0400026D RID: 621
			ERROR_NONE,
			// Token: 0x0400026E RID: 622
			ERROR_FILE_NOT_FOUND = 2,
			// Token: 0x0400026F RID: 623
			ERROR_INVALID_NAME = 123,
			// Token: 0x04000270 RID: 624
			ERROR_ACCESS_DENIED = 5,
			// Token: 0x04000271 RID: 625
			ERROR_INVALID_HANDLE,
			// Token: 0x04000272 RID: 626
			ERROR_IO_PENDING = 997
		}

		// Token: 0x02000058 RID: 88
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential)]
		public class CommStat
		{
			// Token: 0x1700009A RID: 154
			// (get) Token: 0x06000257 RID: 599 RVA: 0x0000BE8D File Offset: 0x0000A08D
			// (set) Token: 0x06000258 RID: 600 RVA: 0x0000BE9F File Offset: 0x0000A09F
			public bool CtsHold
			{
				get
				{
					return this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fCtsHold];
				}
				set
				{
					this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fCtsHold] = value;
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x06000259 RID: 601 RVA: 0x0000BEB2 File Offset: 0x0000A0B2
			// (set) Token: 0x0600025A RID: 602 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
			public bool DsrHold
			{
				get
				{
					return this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fDsrHold];
				}
				set
				{
					this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fDsrHold] = value;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x0600025B RID: 603 RVA: 0x0000BED7 File Offset: 0x0000A0D7
			// (set) Token: 0x0600025C RID: 604 RVA: 0x0000BEE9 File Offset: 0x0000A0E9
			public bool RlsHold
			{
				get
				{
					return this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fRlsHold];
				}
				set
				{
					this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fRlsHold] = value;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x0600025D RID: 605 RVA: 0x0000BEFC File Offset: 0x0000A0FC
			// (set) Token: 0x0600025E RID: 606 RVA: 0x0000BF0E File Offset: 0x0000A10E
			public bool XoffHold
			{
				get
				{
					return this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fXoffHold];
				}
				set
				{
					this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fXoffHold] = value;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x0600025F RID: 607 RVA: 0x0000BF21 File Offset: 0x0000A121
			// (set) Token: 0x06000260 RID: 608 RVA: 0x0000BF33 File Offset: 0x0000A133
			public bool XoffSent
			{
				get
				{
					return this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fXoffSent];
				}
				set
				{
					this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fXoffSent] = value;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x06000261 RID: 609 RVA: 0x0000BF46 File Offset: 0x0000A146
			// (set) Token: 0x06000262 RID: 610 RVA: 0x0000BF58 File Offset: 0x0000A158
			public bool Eof
			{
				get
				{
					return this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fEof];
				}
				set
				{
					this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fEof] = value;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x06000263 RID: 611 RVA: 0x0000BF6B File Offset: 0x0000A16B
			// (set) Token: 0x06000264 RID: 612 RVA: 0x0000BF7D File Offset: 0x0000A17D
			public bool Txim
			{
				get
				{
					return this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fTxim];
				}
				set
				{
					this.bitField[global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fTxim] = value;
				}
			}

			// Token: 0x04000273 RID: 627
			private global::System.Collections.Specialized.BitVector32 bitField;

			// Token: 0x04000274 RID: 628
			public uint cbInQue;

			// Token: 0x04000275 RID: 629
			public uint cbOutQue;

			// Token: 0x04000276 RID: 630
			private static readonly int fCtsHold = global::System.Collections.Specialized.BitVector32.CreateMask();

			// Token: 0x04000277 RID: 631
			private static readonly int fDsrHold = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fCtsHold);

			// Token: 0x04000278 RID: 632
			private static readonly int fRlsHold = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fDsrHold);

			// Token: 0x04000279 RID: 633
			private static readonly int fXoffHold = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fRlsHold);

			// Token: 0x0400027A RID: 634
			private static readonly int fXoffSent = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fXoffHold);

			// Token: 0x0400027B RID: 635
			private static readonly int fEof = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fXoffSent);

			// Token: 0x0400027C RID: 636
			private static readonly int fTxim = global::System.Collections.Specialized.BitVector32.CreateMask(global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommStat.fEof);
		}

		// Token: 0x02000059 RID: 89
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		public struct COMMPROP
		{
			// Token: 0x0400027D RID: 637
			private ushort wPacketLength;

			// Token: 0x0400027E RID: 638
			private ushort wPacketVersion;

			// Token: 0x0400027F RID: 639
			private uint dwServiceMask;

			// Token: 0x04000280 RID: 640
			private uint dwReserved1;

			// Token: 0x04000281 RID: 641
			private uint dwMaxTxQueue;

			// Token: 0x04000282 RID: 642
			private uint dwMaxRxQueue;

			// Token: 0x04000283 RID: 643
			private uint dwMaxBaud;

			// Token: 0x04000284 RID: 644
			private uint dwProvSubType;

			// Token: 0x04000285 RID: 645
			private uint dwProvCapabilities;

			// Token: 0x04000286 RID: 646
			private uint dwSettableParams;

			// Token: 0x04000287 RID: 647
			private uint dwSettableBaud;

			// Token: 0x04000288 RID: 648
			private ushort wSettableData;

			// Token: 0x04000289 RID: 649
			private ushort wSettableStopParity;

			// Token: 0x0400028A RID: 650
			private uint dwCurrentTxQueue;

			// Token: 0x0400028B RID: 651
			private uint dwCurrentRxQueue;

			// Token: 0x0400028C RID: 652
			private uint dwProvSpec1;

			// Token: 0x0400028D RID: 653
			private uint dwProvSpec2;

			// Token: 0x0400028E RID: 654
			private string wcProvChar;
		}

		// Token: 0x0200005A RID: 90
		public enum PNP_VETO_TYPE
		{
			// Token: 0x04000290 RID: 656
			PNP_VetoTypeUnknown,
			// Token: 0x04000291 RID: 657
			PNP_VetoLegacyDevice,
			// Token: 0x04000292 RID: 658
			PNP_VetoPendingClose,
			// Token: 0x04000293 RID: 659
			PNP_VetoWindowsApp,
			// Token: 0x04000294 RID: 660
			PNP_VetoWindowsService,
			// Token: 0x04000295 RID: 661
			PNP_VetoOutstandingOpen,
			// Token: 0x04000296 RID: 662
			PNP_VetoDevice,
			// Token: 0x04000297 RID: 663
			PNP_VetoDriver,
			// Token: 0x04000298 RID: 664
			PNP_VetoIllegalDeviceRequest,
			// Token: 0x04000299 RID: 665
			PNP_VetoInsufficientPower,
			// Token: 0x0400029A RID: 666
			PNP_VetoNonDisableable,
			// Token: 0x0400029B RID: 667
			PNP_VetoLegacyDriver,
			// Token: 0x0400029C RID: 668
			PNP_VetoInsufficientRights
		}

		// Token: 0x0200005B RID: 91
		public struct DC_USB_CTRL_DATA
		{
			// Token: 0x0400029D RID: 669
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8)]
			public byte[] setup_packet;

			// Token: 0x0400029E RID: 670
			public ulong data_to_dev_ptr;

			// Token: 0x0400029F RID: 671
			public uint data_to_dev_len;
		}

		// Token: 0x0200005C RID: 92
		public struct DC_IOCTRL_DATA
		{
			// Token: 0x040002A0 RID: 672
			public ulong data_in_ptr;

			// Token: 0x040002A1 RID: 673
			public ulong data_out_ptr;

			// Token: 0x040002A2 RID: 674
			public uint data_in_len;

			// Token: 0x040002A3 RID: 675
			public uint data_out_len;

			// Token: 0x040002A4 RID: 676
			public int status;
		}

		// Token: 0x0200005D RID: 93
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_DEVICE_DESCRIPTOR
		{
			// Token: 0x040002A5 RID: 677
			public byte bLength;

			// Token: 0x040002A6 RID: 678
			public byte bDescriptorType;

			// Token: 0x040002A7 RID: 679
			public ushort bcdUSB;

			// Token: 0x040002A8 RID: 680
			public byte bDeviceClass;

			// Token: 0x040002A9 RID: 681
			public byte bDeviceSubClass;

			// Token: 0x040002AA RID: 682
			public byte bDeviceProtocol;

			// Token: 0x040002AB RID: 683
			public byte bMaxPacketSize0;

			// Token: 0x040002AC RID: 684
			public ushort idVendor;

			// Token: 0x040002AD RID: 685
			public ushort idProduct;

			// Token: 0x040002AE RID: 686
			public ushort bcdDevice;

			// Token: 0x040002AF RID: 687
			public byte iManufacturer;

			// Token: 0x040002B0 RID: 688
			public byte iProduct;

			// Token: 0x040002B1 RID: 689
			public byte iSerialNumber;

			// Token: 0x040002B2 RID: 690
			public byte bNumConfigurations;
		}

		// Token: 0x0200005E RID: 94
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_ENDPOINT_DESCRIPTOR
		{
			// Token: 0x040002B3 RID: 691
			public byte bLength;

			// Token: 0x040002B4 RID: 692
			public byte bDescriptorType;

			// Token: 0x040002B5 RID: 693
			public byte bEndpointAddress;

			// Token: 0x040002B6 RID: 694
			public byte bmAttributes;

			// Token: 0x040002B7 RID: 695
			public ushort wMaxPacketSize;

			// Token: 0x040002B8 RID: 696
			public byte bInterval;
		}

		// Token: 0x0200005F RID: 95
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_PIPE_INFO
		{
			// Token: 0x040002B9 RID: 697
			public global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_ENDPOINT_DESCRIPTOR EndpointDescriptor;

			// Token: 0x040002BA RID: 698
			public uint ScheduleOffset;
		}

		// Token: 0x02000060 RID: 96
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_NODE_CONNECTION_INFORMATION_EX
		{
			// Token: 0x040002BB RID: 699
			public uint ConnectionIndex;

			// Token: 0x040002BC RID: 700
			public global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_DEVICE_DESCRIPTOR DeviceDescriptor;

			// Token: 0x040002BD RID: 701
			public byte CurrentConfigurationValue;

			// Token: 0x040002BE RID: 702
			public byte Speed;

			// Token: 0x040002BF RID: 703
			public byte DeviceIsHub;

			// Token: 0x040002C0 RID: 704
			public ushort DeviceAddress;

			// Token: 0x040002C1 RID: 705
			public uint NumberOfOpenPipes;

			// Token: 0x040002C2 RID: 706
			public global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS ConnectionStatus;

			// Token: 0x040002C3 RID: 707
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 330)]
			public global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_PIPE_INFO[] PipeList;
		}

		// Token: 0x02000061 RID: 97
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_SETUP_PACKET
		{
			// Token: 0x040002C4 RID: 708
			public byte bmRequest;

			// Token: 0x040002C5 RID: 709
			public byte bRequest;

			// Token: 0x040002C6 RID: 710
			public ushort wValue;

			// Token: 0x040002C7 RID: 711
			public ushort wIndex;

			// Token: 0x040002C8 RID: 712
			public ushort wLength;
		}

		// Token: 0x02000062 RID: 98
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_DESCRIPTOR_REQUEST
		{
			// Token: 0x040002C9 RID: 713
			public uint ConnectionIndex;

			// Token: 0x040002CA RID: 714
			public global::Motorola.Common.Communication.TetraUtility.NativeMethods.USB_SETUP_PACKET SetupPacket;

			// Token: 0x040002CB RID: 715
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 512)]
			public byte[] Data;
		}

		// Token: 0x02000063 RID: 99
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
		public struct USB_CYCLE_PORT_PARAMS
		{
			// Token: 0x040002CC RID: 716
			public uint ConnectionIndex;

			// Token: 0x040002CD RID: 717
			public uint StatusReturned;
		}

		// Token: 0x02000064 RID: 100
		public struct USBUSER_REQUEST_GET_USB_BANDWIDTH_INFO
		{
			// Token: 0x040002CE RID: 718
			public uint UsbUserRequest;

			// Token: 0x040002CF RID: 719
			public global::Motorola.Common.Communication.TetraUtility.USB_USER_ERROR_CODE UsbUserStatusCode;

			// Token: 0x040002D0 RID: 720
			public uint RequestBufferLength;

			// Token: 0x040002D1 RID: 721
			public uint ActualBufferLength;

			// Token: 0x040002D2 RID: 722
			public uint DeviceCount;

			// Token: 0x040002D3 RID: 723
			public uint TotalBusBandwidth;

			// Token: 0x040002D4 RID: 724
			public uint Total32secBandwidth;

			// Token: 0x040002D5 RID: 725
			public uint AllocedBulkAndControl;

			// Token: 0x040002D6 RID: 726
			public uint AllocedIso;

			// Token: 0x040002D7 RID: 727
			public uint AllocedInterrupt_1ms;

			// Token: 0x040002D8 RID: 728
			public uint AllocedInterrupt_2ms;

			// Token: 0x040002D9 RID: 729
			public uint AllocedInterrupt_4ms;

			// Token: 0x040002DA RID: 730
			public uint AllocedInterrupt_8ms;

			// Token: 0x040002DB RID: 731
			public uint AllocedInterrupt_16ms;

			// Token: 0x040002DC RID: 732
			public uint AllocedInterrupt_32ms;
		}

		// Token: 0x02000065 RID: 101
		public struct SCSI_PASS_THROUGH_DIRECT
		{
			// Token: 0x040002DD RID: 733
			public ushort Length;

			// Token: 0x040002DE RID: 734
			public byte ScsiStatus;

			// Token: 0x040002DF RID: 735
			public byte PathId;

			// Token: 0x040002E0 RID: 736
			public byte TargetId;

			// Token: 0x040002E1 RID: 737
			public byte Lun;

			// Token: 0x040002E2 RID: 738
			public byte CdbLength;

			// Token: 0x040002E3 RID: 739
			public byte SenseInfoLength;

			// Token: 0x040002E4 RID: 740
			public byte DataIn;

			// Token: 0x040002E5 RID: 741
			public uint DataTransferLength;

			// Token: 0x040002E6 RID: 742
			public uint TimeOutValue;

			// Token: 0x040002E7 RID: 743
			internal global::System.IntPtr DataBuffer;

			// Token: 0x040002E8 RID: 744
			public uint SenseInfoOffset;

			// Token: 0x040002E9 RID: 745
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
			public byte[] Cdb;
		}

		// Token: 0x02000066 RID: 102
		public struct SCSI_PASS_THROUGH_DIRECT_WITH_BUFFER
		{
			// Token: 0x040002EA RID: 746
			public global::Motorola.Common.Communication.TetraUtility.NativeMethods.SCSI_PASS_THROUGH_DIRECT sptd;

			// Token: 0x040002EB RID: 747
			public uint Filler;

			// Token: 0x040002EC RID: 748
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
			public byte[] ucSenseBuf;
		}

		// Token: 0x02000067 RID: 103
		public struct My_GUID
		{
			// Token: 0x040002ED RID: 749
			public int a;

			// Token: 0x040002EE RID: 750
			public short b;

			// Token: 0x040002EF RID: 751
			public short c;

			// Token: 0x040002F0 RID: 752
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 8)]
			public byte[] d;
		}

		// Token: 0x02000068 RID: 104
		public struct PREVENT_MEDIA_REMOVAL
		{
			// Token: 0x040002F1 RID: 753
			public byte PreventMediaRemoval;
		}
	}
}
