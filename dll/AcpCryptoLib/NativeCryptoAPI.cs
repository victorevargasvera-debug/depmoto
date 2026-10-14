using System;
using System.Runtime.InteropServices;

namespace AcpCryptoLib
{
	// Token: 0x02000006 RID: 6
	public class NativeCryptoAPI
	{
		// Token: 0x06000011 RID: 17
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError = true)]
		public static extern bool CryptAcquireContext(out global::System.IntPtr hProv, string pszContainer, string pszProvider, uint dwProvType, uint dwFlags);

		// Token: 0x06000012 RID: 18
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError = true)]
		public static extern bool CryptCreateHash(global::System.IntPtr hProv, uint Algid, global::System.IntPtr hKey, uint dwFlags, out global::System.IntPtr phHash);

		// Token: 0x06000013 RID: 19
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError = true)]
		public static extern bool CryptDecrypt(global::System.IntPtr hKey, global::System.IntPtr hHash, bool Final, uint dwFlags, byte[] pbData, ref uint pdwDataLen);

		// Token: 0x06000014 RID: 20
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError = true)]
		public static extern bool CryptDeriveKey(global::System.IntPtr hProv, uint Algid, global::System.IntPtr hBaseData, uint dwFlags, out global::System.IntPtr phKey);

		// Token: 0x06000015 RID: 21
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError = true)]
		public static extern bool CryptDestroyHash(global::System.IntPtr hHash);

		// Token: 0x06000016 RID: 22
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError = true)]
		public static extern bool CryptDestroyKey(global::System.IntPtr hKey);

		// Token: 0x06000017 RID: 23
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError = true)]
		public static extern bool CryptEncrypt(global::System.IntPtr hKey, global::System.IntPtr hHash, bool Final, uint dwFlags, byte[] pbData, ref uint pdwDataLen, uint dwBufLen);

		// Token: 0x06000018 RID: 24
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError = true)]
		public static extern bool CryptHashData(global::System.IntPtr hHash, byte[] pbData, int dwDataLen, uint dwFlags);

		// Token: 0x06000019 RID: 25
		[global::System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError = true)]
		public static extern bool CryptReleaseContext(global::System.IntPtr hProv, uint dwFlags);

		// Token: 0x04000006 RID: 6
		public const string advapi32 = "advapi32.dll";
	}
}
