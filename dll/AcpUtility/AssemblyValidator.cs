using System;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AcpUtility
{
	// Token: 0x02000003 RID: 3
	public static class AssemblyValidator
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0000212C File Offset: 0x0000032C
		public static bool IsCallerAuthorized()
		{
			global::System.Reflection.Assembly entryAssembly = global::System.Reflection.Assembly.GetEntryAssembly();
			return global::AcpUtility.AssemblyValidator.IsCallerAuthorized(entryAssembly);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002148 File Offset: 0x00000348
		public static bool IsCallerAuthorized(global::System.Reflection.Assembly caller)
		{
			bool flag = false;
			if (caller != null)
			{
				if (global::AcpUtility.AssemblyValidator.IsApxAssembly(caller))
				{
					flag = true;
					global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\StrongName\\Verification");
					if (registryKey != null)
					{
						foreach (string text in registryKey.GetSubKeyNames())
						{
							if (text.Contains("d124d6ba4931c72b") || text.Contains("5549ef8a6e130b64") || text.Contains("6309a8bd04368eb1"))
							{
								flag = false;
								break;
							}
						}
					}
				}
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				global::System.Windows.Forms.MessageBox.Show("Internal Error occurred. The application will be shutdown." + global::System.Environment.NewLine + global::System.Environment.NewLine + "Exit Code 0xFF");
				global::System.Environment.Exit(255);
			}
			return flag;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021F8 File Offset: 0x000003F8
		private static bool IsApxAssembly(global::System.Reflection.Assembly asm)
		{
			bool result = false;
			if (asm != null)
			{
				result = (asm.FullName.ToLower().EndsWith("d124d6ba4931c72b") || asm.FullName.ToLower().EndsWith("5549ef8a6e130b64") || asm.FullName.ToLower().EndsWith("6309a8bd04368eb1"));
			}
			return result;
		}
	}
}
