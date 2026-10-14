using System;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	// Token: 0x02000050 RID: 80
	[global::System.Runtime.InteropServices.Guid("85CB6900-4D95-11CF-960C-0080C7F4EE85")]
	[global::System.Runtime.InteropServices.CoClass(typeof(global::SHDocVw.ShellWindowsClass))]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ShellWindows : global::SHDocVw.IShellWindows, global::SHDocVw.DShellWindowsEvents_Event
	{
	}
}
