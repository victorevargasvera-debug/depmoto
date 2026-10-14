using System;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x02000023 RID: 35
	internal class PkzipClassicDecryptCryptoTransform : global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicCryptoBase, global::System.Security.Cryptography.ICryptoTransform, global::System.IDisposable
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00007DBC File Offset: 0x00006DBC
		internal PkzipClassicDecryptCryptoTransform(byte[] keyBlock)
		{
			base.SetKeys(keyBlock);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00007DCC File Offset: 0x00006DCC
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[inputCount];
			this.TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007DF0 File Offset: 0x00006DF0
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			for (int i = inputOffset; i < inputOffset + inputCount; i++)
			{
				byte b = inputBuffer[i] ^ base.TransformByte();
				outputBuffer[outputOffset++] = b;
				base.UpdateKeys(b);
			}
			return inputCount;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00007E2A File Offset: 0x00006E2A
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00007E2D File Offset: 0x00006E2D
		public int InputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00007E30 File Offset: 0x00006E30
		public int OutputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00007E33 File Offset: 0x00006E33
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00007E36 File Offset: 0x00006E36
		public void Dispose()
		{
			base.Reset();
		}
	}
}
