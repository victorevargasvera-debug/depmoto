using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000069 RID: 105
	public class NativeMethodsForOtherNamSpace
	{
		// Token: 0x06000266 RID: 614 RVA: 0x0000BF98 File Offset: 0x0000A198
		public static int CM_Request_Device_Eject(uint dnDevInst, global::System.UIntPtr unknown1, global::System.UIntPtr unknown2, uint unknown3, uint unknown4)
		{
			return global::Motorola.Common.Communication.TetraUtility.NativeMethods.CM_Request_Device_Eject(dnDevInst, unknown1, unknown2, unknown3, unknown4);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000BFA5 File Offset: 0x0000A1A5
		public static global::System.IntPtr GetDC(global::System.IntPtr ptr)
		{
			return global::Motorola.Common.Communication.TetraUtility.NativeMethods.GetDC(ptr);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000BFAD File Offset: 0x0000A1AD
		public static int ReleaseDC(global::System.IntPtr hWnd, global::System.IntPtr hDC)
		{
			return global::Motorola.Common.Communication.TetraUtility.NativeMethods.ReleaseDC(hWnd, hDC);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000BFB6 File Offset: 0x0000A1B6
		public static global::System.IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, global::System.IntPtr lpInitData)
		{
			return global::Motorola.Common.Communication.TetraUtility.NativeMethods.CreateDC(lpszDriver, lpszDevice, lpszOutput, lpInitData);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000BFC1 File Offset: 0x0000A1C1
		public static int GetDeviceCaps(global::System.IntPtr hdc, int nIndex)
		{
			return global::Motorola.Common.Communication.TetraUtility.NativeMethods.GetDeviceCaps(hdc, nIndex);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000BFCA File Offset: 0x0000A1CA
		public static bool SetProcessDPIAware()
		{
			return global::Motorola.Common.Communication.TetraUtility.NativeMethods.SetProcessDPIAware();
		}
	}
}
