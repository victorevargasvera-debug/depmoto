using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using custom_exception;

namespace custom_controls
{
	// Token: 0x02000045 RID: 69
	public class CFrmTitleBarHndl
	{
		// Token: 0x0600034A RID: 842
		[global::System.Runtime.InteropServices.DllImport("User32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern global::System.IntPtr GetSystemMenu(global::System.IntPtr A_0, int A_1);

		// Token: 0x0600034B RID: 843
		[global::System.Runtime.InteropServices.DllImport("User32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern int GetMenuItemCount(global::System.IntPtr A_0);

		// Token: 0x0600034C RID: 844
		[global::System.Runtime.InteropServices.DllImport("User32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern int DrawMenuBar(global::System.IntPtr A_0);

		// Token: 0x0600034D RID: 845
		[global::System.Runtime.InteropServices.DllImport("User32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern int RemoveMenu(global::System.IntPtr A_0, int A_1, int A_2);

		// Token: 0x0600034F RID: 847 RVA: 0x00039264 File Offset: 0x00037464
		public void DisableCloseButton(global::System.Windows.Forms.Form frmForm)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						int num = 0;
						bool visible = frmForm.Visible;
						global::System.IntPtr systemMenu = global::custom_controls.CFrmTitleBarHndl.GetSystemMenu(frmForm.Handle, 0);
						frmForm.Visible = visible;
						int num2 = 5;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_7C;
							case 1:
								if (true)
								{
								}
								num = global::custom_controls.CFrmTitleBarHndl.GetMenuItemCount(systemMenu);
								goto IL_E5;
							case 2:
								goto IL_103;
							case 3:
								global::custom_controls.CFrmTitleBarHndl.RemoveMenu(systemMenu, num - 1, 1024);
								global::custom_controls.CFrmTitleBarHndl.RemoveMenu(systemMenu, num - 2, 1024);
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_E5;
								default:
									if (false)
									{
									}
									num2 = 0;
									continue;
								}
								break;
							case 4:
								goto IL_10F;
							case 5:
								if (!(systemMenu == global::System.IntPtr.Zero))
								{
									num2 = 1;
									continue;
								}
								goto IL_103;
							case 6:
								if (num > 0)
								{
									num2 = 3;
									continue;
								}
								goto IL_7C;
							}
							break;
							IL_7C:
							global::custom_controls.CFrmTitleBarHndl.DrawMenuBar(frmForm.Handle);
							num2 = 2;
							continue;
							IL_E5:
							num2 = 6;
							continue;
							IL_103:
							num2 = 4;
						}
					}
					IL_10F:
					break;
				}
			}
			catch (global::System.Exception ex)
			{
				global::custom_exception.CCustomException.Rethrow(ex);
			}
		}

		// Token: 0x0400025D RID: 605
		private const int a = 1024;

		// Token: 0x0400025E RID: 606
		private const int b = 4096;
	}
}
