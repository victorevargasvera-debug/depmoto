using System;
using System.Text;
using AcpUtility;

namespace AcpCryptoLib
{
	// Token: 0x0200000A RID: 10
	public class AcpIBtnEncyptDecrpt
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000029E7 File Offset: 0x00000BE7
		static AcpIBtnEncyptDecrpt()
		{
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002A18 File Offset: 0x00000C18
		private void Init()
		{
			if (!global::AcpCryptoLib.NativeCryptoAPI.CryptAcquireContext(out this.m_hCryptProv, null, "Microsoft Base Cryptographic Provider v1.0", 1U, 4026531840U))
			{
				throw new global::System.SystemException("Failed to acquire cryptography handle.");
			}
			if (!global::AcpCryptoLib.NativeCryptoAPI.CryptCreateHash(this.m_hCryptProv, 32771U, global::System.IntPtr.Zero, 0U, out this.m_hHash))
			{
				throw new global::System.SystemException("unable to create hash object.");
			}
			string s = "81CF0B1A72F34E3095D807D76CE18CB20B15724FF86";
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(s);
			if (!global::AcpCryptoLib.NativeCryptoAPI.CryptHashData(this.m_hHash, bytes, bytes.Length, 0U))
			{
				throw new global::System.SystemException("unable to hash data.");
			}
			if (!global::AcpCryptoLib.NativeCryptoAPI.CryptDeriveKey(this.m_hCryptProv, 26625U, this.m_hHash, 0U, out this.m_hKey))
			{
				throw new global::System.SystemException("unable to derive key.");
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002ACC File Offset: 0x00000CCC
		public void Encrypt(byte[] pDecrypted, out byte[] pEncrypted)
		{
			pEncrypted = null;
			if (pDecrypted == null)
			{
				throw new global::System.SystemException("Invalid argument");
			}
			this.Init();
			uint num = (uint)pDecrypted.Length;
			uint num2 = num;
			if (global::AcpCryptoLib.NativeCryptoAPI.CryptEncrypt(this.m_hKey, global::System.IntPtr.Zero, true, 0U, null, ref num2, 0U))
			{
				pEncrypted = new byte[num2];
				global::System.Array.Copy(pDecrypted, 0, pEncrypted, 0, pDecrypted.Length);
				if (!global::AcpCryptoLib.NativeCryptoAPI.CryptEncrypt(this.m_hKey, global::System.IntPtr.Zero, true, 0U, pEncrypted, ref num, num))
				{
					throw new global::System.SystemException("CryptEncrypt failed");
				}
			}
			this.Cleanup();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002B50 File Offset: 0x00000D50
		public void Decrypt(byte[] pEncrypted, out byte[] pDecrypted)
		{
			pDecrypted = null;
			if (pEncrypted == null)
			{
				throw new global::System.SystemException("Invalid argument");
			}
			this.Init();
			uint num = (uint)pEncrypted.Length;
			uint num2 = num;
			byte[] array = new byte[num2];
			global::System.Array.Copy(pEncrypted, 0, array, 0, pEncrypted.Length);
			if (global::AcpCryptoLib.NativeCryptoAPI.CryptDecrypt(this.m_hKey, global::System.IntPtr.Zero, true, 0U, array, ref num2))
			{
				pDecrypted = new byte[num2];
				global::System.Array.Copy(array, 0L, pDecrypted, 0L, (long)((ulong)num2));
				this.Cleanup();
				return;
			}
			throw new global::System.SystemException("CryptDecrypt failed");
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002BD0 File Offset: 0x00000DD0
		private void Cleanup()
		{
			if (this.m_hKey != global::System.IntPtr.Zero)
			{
				global::AcpCryptoLib.NativeCryptoAPI.CryptDestroyKey(this.m_hKey);
				this.m_hKey = global::System.IntPtr.Zero;
			}
			if (this.m_hHash != global::System.IntPtr.Zero)
			{
				global::AcpCryptoLib.NativeCryptoAPI.CryptDestroyHash(this.m_hHash);
				this.m_hHash = global::System.IntPtr.Zero;
			}
			if (this.m_hCryptProv != global::System.IntPtr.Zero)
			{
				global::AcpCryptoLib.NativeCryptoAPI.CryptReleaseContext(this.m_hCryptProv, 0U);
				this.m_hCryptProv = global::System.IntPtr.Zero;
			}
		}

		// Token: 0x04000009 RID: 9
		private global::System.IntPtr m_hCryptProv = global::System.IntPtr.Zero;

		// Token: 0x0400000A RID: 10
		private global::System.IntPtr m_hHash = global::System.IntPtr.Zero;

		// Token: 0x0400000B RID: 11
		private global::System.IntPtr m_hKey = global::System.IntPtr.Zero;
	}
}
