using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Motorola.Common.Communication.CommunicationPipe.Fudally
{
	// Token: 0x02000008 RID: 8
	internal static class NativeMethods
	{
		// Token: 0x06000031 RID: 49
		[global::System.Runtime.InteropServices.DllImport("fudally_usb.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int fudallyUSB_getFilename(int index, global::System.Text.StringBuilder devPath);

		// Token: 0x06000032 RID: 50
		[global::System.Runtime.InteropServices.DllImport("fudally_usb.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::Microsoft.Win32.SafeHandles.SafeFileHandle fudallyUSB_openRead(global::System.Text.StringBuilder devPath, global::System.Text.StringBuilder outPipe);

		// Token: 0x06000033 RID: 51
		[global::System.Runtime.InteropServices.DllImport("fudally_usb.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern global::Microsoft.Win32.SafeHandles.SafeFileHandle fudallyUSB_openWrite(global::System.Text.StringBuilder devPath, global::System.Text.StringBuilder inPipe);

		// Token: 0x06000034 RID: 52
		[global::System.Runtime.InteropServices.DllImport("fudally_usb.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int fudallyUSB_getDevDescriptor(global::Microsoft.Win32.SafeHandles.SafeFileHandle handle, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] ref global::Motorola.Common.Communication.CommunicationPipe.Fudally.fudallyUSB_DEVICE_DESCRIPTOR descriptor);

		// Token: 0x06000035 RID: 53
		[global::System.Runtime.InteropServices.DllImport("fudally_usb.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int fudallyUSB_read(global::Microsoft.Win32.SafeHandles.SafeFileHandle handle, byte[] data, uint length, uint timeout);

		// Token: 0x06000036 RID: 54
		[global::System.Runtime.InteropServices.DllImport("fudally_usb.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal static extern int fudallyUSB_write(global::Microsoft.Win32.SafeHandles.SafeFileHandle handle, byte[] data, uint length, uint timeout);
	}
}
