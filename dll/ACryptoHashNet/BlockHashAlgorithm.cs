using System;
using System.Security.Cryptography;

namespace Home.Andir.Cryptography
{
	// Token: 0x02000002 RID: 2
	public abstract class BlockHashAlgorithm : global::System.Security.Cryptography.HashAlgorithm
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000010D0
		public BlockHashAlgorithm(int blockSize)
		{
			this.BlockSize = blockSize;
			this.lastBlock = new byte[this.BlockSize];
			this.lastBlockLength = 0;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000020F7 File Offset: 0x000010F7
		// (set) Token: 0x06000003 RID: 3 RVA: 0x000020FF File Offset: 0x000010FF
		public int BlockSize { get; private set; }

		// Token: 0x06000004 RID: 4
		protected abstract void ProcessBlock(byte[] array, int offset);

		// Token: 0x06000005 RID: 5
		protected abstract void ProcessFinalBlock(byte[] array, int offset, int length);

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6
		protected abstract byte[] Result { get; }

		// Token: 0x06000007 RID: 7 RVA: 0x00002108 File Offset: 0x00001108
		public override void Initialize()
		{
			global::System.Array.Clear(this.lastBlock, 0, this.lastBlock.Length);
			this.lastBlockLength = 0;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002128 File Offset: 0x00001128
		protected override void HashCore(byte[] array, int offset, int length)
		{
			int num = offset;
			int num2 = length;
			if (this.lastBlockLength > 0)
			{
				global::System.Buffer.BlockCopy(array, num, this.lastBlock, this.lastBlockLength, this.lastBlock.Length - this.lastBlockLength);
				this.ProcessBlock(this.lastBlock, 0);
				num += this.lastBlockLength;
				num2 -= this.lastBlockLength;
				this.lastBlockLength = 0;
			}
			int num3 = num2 / this.BlockSize;
			this.lastBlockLength = num2 % this.BlockSize;
			int i = 0;
			while (i < num3)
			{
				this.ProcessBlock(array, num);
				i++;
				num += this.BlockSize;
			}
			if (this.lastBlockLength != 0)
			{
				global::System.Buffer.BlockCopy(array, num, this.lastBlock, 0, this.lastBlockLength);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021DA File Offset: 0x000011DA
		protected override byte[] HashFinal()
		{
			this.ProcessFinalBlock(this.lastBlock, 0, this.lastBlockLength);
			return this.Result;
		}

		// Token: 0x04000001 RID: 1
		private readonly byte[] lastBlock;

		// Token: 0x04000002 RID: 2
		private int lastBlockLength;
	}
}
