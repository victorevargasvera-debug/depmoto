using System;

namespace Motorola.Common.Communication.TetraSecurity
{
	// Token: 0x02000007 RID: 7
	internal interface ISecure
	{
		// Token: 0x06000041 RID: 65
		void EncryptFile(byte[] bufferIn, ref byte[] bufferOut, byte[] key, byte[] IV);

		// Token: 0x06000042 RID: 66
		void DecryptFile(byte[] bufferIn, ref byte[] bufferOut, byte[] key, byte[] IV);
	}
}
