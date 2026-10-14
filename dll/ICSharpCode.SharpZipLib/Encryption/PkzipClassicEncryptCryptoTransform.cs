using System;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x02000022 RID: 34
	internal class PkzipClassicEncryptCryptoTransform : global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicCryptoBase, global::System.Security.Cryptography.ICryptoTransform, global::System.IDisposable
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00007D37 File Offset: 0x00006D37
		internal PkzipClassicEncryptCryptoTransform(byte[] keyBlock)
		{
			base.SetKeys(keyBlock);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00007D48 File Offset: 0x00006D48
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[inputCount];
			this.TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00007D6C File Offset: 0x00006D6C
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			for (int i = inputOffset; i < inputOffset + inputCount; i++)
			{
				byte ch = inputBuffer[i];
				outputBuffer[outputOffset++] = (inputBuffer[i] ^ base.TransformByte());
				base.UpdateKeys(ch);
			}
			return inputCount;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00007DA8 File Offset: 0x00006DA8
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00007DAB File Offset: 0x00006DAB
		public int InputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00007DAE File Offset: 0x00006DAE
		public int OutputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00007DB1 File Offset: 0x00006DB1
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00007DB4 File Offset: 0x00006DB4
		public void Dispose()
		{
			base.Reset();
		}
	}
}
