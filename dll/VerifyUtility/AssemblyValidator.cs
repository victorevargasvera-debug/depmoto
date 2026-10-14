using System;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Win32;

namespace VerifyUtility
{
	// Token: 0x02000002 RID: 2
	public static class AssemblyValidator
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public static bool IsCallerAuthorized()
		{
			global::System.Reflection.Assembly entryAssembly = global::System.Reflection.Assembly.GetEntryAssembly();
			return global::VerifyUtility.AssemblyValidator.IsCallerAuthorized(entryAssembly);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020EC File Offset: 0x000002EC
		private static bool IsCallerAuthorized(global::System.Reflection.Assembly caller)
		{
			bool flag = false;
			if (caller != null)
			{
				if (global::VerifyUtility.AssemblyValidator.IsVerifiedAssembly(caller))
				{
					flag = true;
					global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\StrongName\\Verification");
					if (registryKey != null)
					{
						foreach (string text in registryKey.GetSubKeyNames())
						{
							if (text.Contains("d124d6ba4931c72b") || text.Contains("5549ef8a6e130b64") || text.Contains("e3bd7b9d44510c37") || text.Contains("6309a8bd04368eb1"))
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
				global::System.Diagnostics.Trace.WriteLine("ERROR! - Unauthorized access. The application will be shutdown. Exit Code 0xFF.");
				global::System.Environment.Exit(255);
			}
			return flag;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002194 File Offset: 0x00000394
		private static bool IsVerifiedAssembly(global::System.Reflection.Assembly asm)
		{
			bool result = false;
			if (asm != null)
			{
				result = (asm.FullName.ToLowerInvariant().EndsWith("d124d6ba4931c72b", global::System.StringComparison.Ordinal) || asm.FullName.ToLowerInvariant().EndsWith("5549ef8a6e130b64", global::System.StringComparison.Ordinal) || asm.FullName.ToLowerInvariant().EndsWith("e3bd7b9d44510c37", global::System.StringComparison.Ordinal) || asm.FullName.ToLowerInvariant().EndsWith("6309a8bd04368eb1", global::System.StringComparison.Ordinal));
			}
			return result;
		}
	}
}
