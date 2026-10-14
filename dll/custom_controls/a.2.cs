using System;
using System.Runtime.InteropServices;
using System.Text;

namespace custom_controls
{
	// Token: 0x0200002A RID: 42
	internal static class a
	{
		// Token: 0x06000164 RID: 356
		[global::System.Runtime.InteropServices.DllImport("USER32.DLL", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		internal static extern short VkKeyScan(char A_0);

		// Token: 0x06000165 RID: 357
		[global::System.Runtime.InteropServices.DllImport("USER32.DLL", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		internal static extern global::System.IntPtr SendMessage(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2, global::System.IntPtr A_3);

		// Token: 0x06000166 RID: 358
		[global::System.Runtime.InteropServices.DllImport("Comdlg32.dll")]
		internal static extern int CommDlgExtendedError();

		// Token: 0x06000167 RID: 359
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern int GetClassName(global::System.IntPtr A_0, global::System.Text.StringBuilder A_1, int A_2);

		// Token: 0x06000168 RID: 360
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern int GetWindowText(global::System.IntPtr A_0, global::System.Text.StringBuilder A_1, int A_2);

		// Token: 0x06000169 RID: 361
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		internal static extern int SendMessage(global::System.IntPtr A_0, int A_1, int A_2, int A_3);
	}
}
