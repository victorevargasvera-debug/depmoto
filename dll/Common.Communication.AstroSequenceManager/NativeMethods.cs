using System;
using System.Runtime.InteropServices;

namespace Motorola.Common.Communication
{
	// Token: 0x02000002 RID: 2
	internal static class NativeMethods
	{
		// Token: 0x06000001 RID: 1
		[global::System.Runtime.InteropServices.DllImport("authAES.dll")]
		internal static extern bool encrypt_function(byte[] key, byte[] plainPwd, byte[] encryptedPwd);

		// Token: 0x06000002 RID: 2
		[global::System.Runtime.InteropServices.DllImport("authAES.dll")]
		internal static extern bool encrypt_function_ex(byte[] key, byte[] plainPwd, byte[] encryptedPwd, int block_num);

		// Token: 0x06000003 RID: 3
		[global::System.Runtime.InteropServices.DllImport("authAES.dll")]
		internal static extern bool decrypt_function(byte[] key, byte[] encryptedPwd, byte[] plainPwd);

		// Token: 0x06000004 RID: 4
		[global::System.Runtime.InteropServices.DllImport("authAES.dll")]
		internal static extern bool decrypt_function_ex(byte[] key, byte[] encryptedPwd, byte[] plainPwd, int block_num);
	}
}
