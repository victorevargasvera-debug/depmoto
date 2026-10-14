using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace AcpCryptoLib
{
	// Token: 0x0200000E RID: 14
	public class AcpAssemblyIdentityValidator
	{
		// Token: 0x06000041 RID: 65
		[global::System.Runtime.InteropServices.DllImport("mscoree.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		private static extern bool StrongNameSignatureVerificationEx(string wszFilePath, bool fForceVerification, ref bool pfWasVerified);

		// Token: 0x06000042 RID: 66 RVA: 0x00003034 File Offset: 0x00001234
		public void Write(string Input_str)
		{
			global::System.Reflection.Assembly callingAssembly = global::System.Reflection.Assembly.GetCallingAssembly();
			global::System.Reflection.Assembly executingAssembly = global::System.Reflection.Assembly.GetExecutingAssembly();
			global::System.Console.WriteLine(callingAssembly.FullName);
			if (this.ValidateAssemblyIdentities(executingAssembly, callingAssembly))
			{
				global::System.Console.WriteLine("Caller validated successfully");
				return;
			}
			global::System.Console.WriteLine("Caller has no strong Name");
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003078 File Offset: 0x00001278
		public bool ValidateAssemblyIdentities(global::System.Reflection.Assembly execAssm, global::System.Reflection.Assembly caller)
		{
			bool result = false;
			global::System.Security.Policy.StrongName strongName = null;
			global::System.Security.Policy.StrongName strongName2 = null;
			if (this.IsAssemblySigned(execAssm, out strongName) && this.IsAssemblySigned(caller, out strongName2))
			{
				bool flag = false;
				if (global::AcpCryptoLib.AcpAssemblyIdentityValidator.StrongNameSignatureVerificationEx(caller.Location, true, ref flag) && this.ArePublicKeyTokensEqual(execAssm, caller))
				{
					result = this.ArePublicKeysEqual(execAssm, caller);
				}
			}
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000030C8 File Offset: 0x000012C8
		private bool IsAssemblySigned(global::System.Reflection.Assembly assm, out global::System.Security.Policy.StrongName sn)
		{
			sn = null;
			bool result = false;
			if (assm != null)
			{
				global::System.Collections.IEnumerator hostEnumerator = assm.Evidence.GetHostEnumerator();
				while (hostEnumerator.MoveNext())
				{
					if (hostEnumerator.Current.GetType().FullName == "System.Security.Policy.StrongName")
					{
						sn = (global::System.Security.Policy.StrongName)hostEnumerator.Current;
						result = true;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003128 File Offset: 0x00001328
		private bool ArePublicKeyTokensEqual(global::System.Reflection.Assembly execAssm, global::System.Reflection.Assembly caller)
		{
			byte[] publicKeyToken = execAssm.GetName().GetPublicKeyToken();
			byte[] publicKeyToken2 = caller.GetName().GetPublicKeyToken();
			bool result = true;
			if (publicKeyToken.Length == publicKeyToken2.Length)
			{
				for (int i = 0; i < publicKeyToken.Length; i++)
				{
					if (publicKeyToken[i] != publicKeyToken2[i])
					{
						result = false;
						break;
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003178 File Offset: 0x00001378
		private bool ArePublicKeysEqual(global::System.Reflection.Assembly execAssm, global::System.Reflection.Assembly caller)
		{
			byte[] publicKey = execAssm.GetName().GetPublicKey();
			byte[] publicKey2 = caller.GetName().GetPublicKey();
			bool result = true;
			if (publicKey.Length == publicKey2.Length)
			{
				for (int i = 0; i < publicKey.Length; i++)
				{
					if (publicKey[i] != publicKey2[i])
					{
						result = false;
						break;
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}
	}
}
