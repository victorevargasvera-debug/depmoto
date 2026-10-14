using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x0200003A RID: 58
	public class Deflater
	{
		// Token: 0x06000249 RID: 585 RVA: 0x0000C0A2 File Offset: 0x0000B0A2
		public Deflater() : this(-1, false)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000C0AC File Offset: 0x0000B0AC
		public Deflater(int level) : this(level, false)
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000C0B8 File Offset: 0x0000B0B8
		public Deflater(int level, bool noZlibHeaderOrFooter)
		{
			if (level == -1)
			{
				level = 6;
			}
			else if (level < 0 || level > 9)
			{
				throw new global::System.ArgumentOutOfRangeException("level");
			}
			this.pending = new global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending();
			this.engine = new global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterEngine(this.pending);
			this.noZlibHeaderOrFooter = noZlibHeaderOrFooter;
			this.SetStrategy(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy.Default);
			this.SetLevel(level);
			this.Reset();
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000C11F File Offset: 0x0000B11F
		public void Reset()
		{
			this.state = (this.noZlibHeaderOrFooter ? 16 : 0);
			this.totalOut = 0L;
			this.pending.Reset();
			this.engine.Reset();
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000C152 File Offset: 0x0000B152
		public int Adler
		{
			get
			{
				return this.engine.Adler;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0000C15F File Offset: 0x0000B15F
		public long TotalIn
		{
			get
			{
				return this.engine.TotalIn;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000C16C File Offset: 0x0000B16C
		public long TotalOut
		{
			get
			{
				return this.totalOut;
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000C174 File Offset: 0x0000B174
		public void Flush()
		{
			this.state |= 4;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000C184 File Offset: 0x0000B184
		public void Finish()
		{
			this.state |= 12;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000C195 File Offset: 0x0000B195
		public bool IsFinished
		{
			get
			{
				return this.state == 30 && this.pending.IsFlushed;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000C1AE File Offset: 0x0000B1AE
		public bool IsNeedingInput
		{
			get
			{
				return this.engine.NeedsInput();
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000C1BB File Offset: 0x0000B1BB
		public void SetInput(byte[] input)
		{
			this.SetInput(input, 0, input.Length);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000C1C8 File Offset: 0x0000B1C8
		public void SetInput(byte[] input, int offset, int count)
		{
			if ((this.state & 8) != 0)
			{
				throw new global::System.InvalidOperationException("Finish() already called");
			}
			this.engine.SetInput(input, offset, count);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000C1ED File Offset: 0x0000B1ED
		public void SetLevel(int level)
		{
			if (level == -1)
			{
				level = 6;
			}
			else if (level < 0 || level > 9)
			{
				throw new global::System.ArgumentOutOfRangeException("level");
			}
			if (this.level != level)
			{
				this.level = level;
				this.engine.SetLevel(level);
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000C228 File Offset: 0x0000B228
		public int GetLevel()
		{
			return this.level;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000C230 File Offset: 0x0000B230
		public void SetStrategy(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy strategy)
		{
			this.engine.Strategy = strategy;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000C23E File Offset: 0x0000B23E
		public int Deflate(byte[] output)
		{
			return this.Deflate(output, 0, output.Length);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000C24C File Offset: 0x0000B24C
		public int Deflate(byte[] output, int offset, int length)
		{
			int num = length;
			if (this.state == 127)
			{
				throw new global::System.InvalidOperationException("Deflater closed");
			}
			if (this.state < 16)
			{
				int num2 = 30720;
				int num3 = this.level - 1 >> 1;
				if (num3 < 0 || num3 > 3)
				{
					num3 = 3;
				}
				num2 |= num3 << 6;
				if ((this.state & 1) != 0)
				{
					num2 |= 32;
				}
				num2 += 31 - num2 % 31;
				this.pending.WriteShortMSB(num2);
				if ((this.state & 1) != 0)
				{
					int adler = this.engine.Adler;
					this.engine.ResetAdler();
					this.pending.WriteShortMSB(adler >> 16);
					this.pending.WriteShortMSB(adler & 65535);
				}
				this.state = (16 | (this.state & 12));
			}
			for (;;)
			{
				int num4 = this.pending.Flush(output, offset, length);
				offset += num4;
				this.totalOut += (long)num4;
				length -= num4;
				if (length == 0 || this.state == 30)
				{
					goto IL_1DE;
				}
				if (!this.engine.Deflate((this.state & 4) != 0, (this.state & 8) != 0))
				{
					if (this.state == 16)
					{
						break;
					}
					if (this.state == 20)
					{
						if (this.level != 0)
						{
							for (int i = 8 + (-this.pending.BitCount & 7); i > 0; i -= 10)
							{
								this.pending.WriteBits(2, 10);
							}
						}
						this.state = 16;
					}
					else if (this.state == 28)
					{
						this.pending.AlignToByte();
						if (!this.noZlibHeaderOrFooter)
						{
							int adler2 = this.engine.Adler;
							this.pending.WriteShortMSB(adler2 >> 16);
							this.pending.WriteShortMSB(adler2 & 65535);
						}
						this.state = 30;
					}
				}
			}
			return num - length;
			IL_1DE:
			return num - length;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000C43A File Offset: 0x0000B43A
		public void SetDictionary(byte[] dictionary)
		{
			this.SetDictionary(dictionary, 0, dictionary.Length);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000C447 File Offset: 0x0000B447
		public void SetDictionary(byte[] dictionary, int index, int count)
		{
			if (this.state != 0)
			{
				throw new global::System.InvalidOperationException();
			}
			this.state = 1;
			this.engine.SetDictionary(dictionary, index, count);
		}

		// Token: 0x04000121 RID: 289
		public const int BEST_COMPRESSION = 9;

		// Token: 0x04000122 RID: 290
		public const int BEST_SPEED = 1;

		// Token: 0x04000123 RID: 291
		public const int DEFAULT_COMPRESSION = -1;

		// Token: 0x04000124 RID: 292
		public const int NO_COMPRESSION = 0;

		// Token: 0x04000125 RID: 293
		public const int DEFLATED = 8;

		// Token: 0x04000126 RID: 294
		private const int IS_SETDICT = 1;

		// Token: 0x04000127 RID: 295
		private const int IS_FLUSHING = 4;

		// Token: 0x04000128 RID: 296
		private const int IS_FINISHING = 8;

		// Token: 0x04000129 RID: 297
		private const int INIT_STATE = 0;

		// Token: 0x0400012A RID: 298
		private const int SETDICT_STATE = 1;

		// Token: 0x0400012B RID: 299
		private const int BUSY_STATE = 16;

		// Token: 0x0400012C RID: 300
		private const int FLUSHING_STATE = 20;

		// Token: 0x0400012D RID: 301
		private const int FINISHING_STATE = 28;

		// Token: 0x0400012E RID: 302
		private const int FINISHED_STATE = 30;

		// Token: 0x0400012F RID: 303
		private const int CLOSED_STATE = 127;

		// Token: 0x04000130 RID: 304
		private int level;

		// Token: 0x04000131 RID: 305
		private bool noZlibHeaderOrFooter;

		// Token: 0x04000132 RID: 306
		private int state;

		// Token: 0x04000133 RID: 307
		private long totalOut;

		// Token: 0x04000134 RID: 308
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending;

		// Token: 0x04000135 RID: 309
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterEngine engine;
	}
}
