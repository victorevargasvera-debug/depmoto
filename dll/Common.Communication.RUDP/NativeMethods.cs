using System;
using System.Runtime.InteropServices;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000020 RID: 32
	internal static class NativeMethods
	{
		// Token: 0x0600017C RID: 380
		[global::System.Runtime.InteropServices.DllImport("Kernel32.dll")]
		internal static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

		// Token: 0x0600017D RID: 381
		[global::System.Runtime.InteropServices.DllImport("Kernel32.dll")]
		internal static extern bool QueryPerformanceFrequency(out long lpFrequency);
	}
}
