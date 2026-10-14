using System;

namespace AcpCryptoLib
{
	// Token: 0x02000012 RID: 18
	public interface IAcpEncryptDecrypt
	{
		// Token: 0x06000049 RID: 73
		byte[] Encrypt(byte[] plainData);

		// Token: 0x0600004A RID: 74
		byte[] Decrypt(byte[] encryptedData);
	}
}
