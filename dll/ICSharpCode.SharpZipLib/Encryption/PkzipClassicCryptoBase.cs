using System;
using ICSharpCode.SharpZipLib.Checksums;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x02000021 RID: 33
	internal class PkzipClassicCryptoBase
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00007BD8 File Offset: 0x00006BD8
		protected byte TransformByte()
		{
			uint num = (this.keys[2] & 65535U) | 2U;
			return (byte)(num * (num ^ 1U) >> 8);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00007C00 File Offset: 0x00006C00
		protected void SetKeys(byte[] keyData)
		{
			if (keyData == null)
			{
				throw new global::System.ArgumentNullException("keyData");
			}
			if (keyData.Length != 12)
			{
				throw new global::System.InvalidOperationException("Key length is not valid");
			}
			this.keys = new uint[3];
			this.keys[0] = (uint)((int)keyData[3] << 24 | (int)keyData[2] << 16 | (int)keyData[1] << 8 | (int)keyData[0]);
			this.keys[1] = (uint)((int)keyData[7] << 24 | (int)keyData[6] << 16 | (int)keyData[5] << 8 | (int)keyData[4]);
			this.keys[2] = (uint)((int)keyData[11] << 24 | (int)keyData[10] << 16 | (int)keyData[9] << 8 | (int)keyData[8]);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00007C9C File Offset: 0x00006C9C
		protected void UpdateKeys(byte ch)
		{
			this.keys[0] = global::ICSharpCode.SharpZipLib.Checksums.Crc32.ComputeCrc32(this.keys[0], ch);
			this.keys[1] = this.keys[1] + (uint)((byte)this.keys[0]);
			this.keys[1] = this.keys[1] * 134775813U + 1U;
			this.keys[2] = global::ICSharpCode.SharpZipLib.Checksums.Crc32.ComputeCrc32(this.keys[2], (byte)(this.keys[1] >> 24));
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00007D12 File Offset: 0x00006D12
		protected void Reset()
		{
			this.keys[0] = 0U;
			this.keys[1] = 0U;
			this.keys[2] = 0U;
		}

		// Token: 0x04000089 RID: 137
		private uint[] keys;
	}
}
