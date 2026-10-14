using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000030 RID: 48
	public class TarBuffer
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00009650 File Offset: 0x00008650
		public int RecordSize
		{
			get
			{
				return this.recordSize;
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00009658 File Offset: 0x00008658
		[global::System.Obsolete("Use RecordSize property instead")]
		public int GetRecordSize()
		{
			return this.recordSize;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00009660 File Offset: 0x00008660
		public int BlockFactor
		{
			get
			{
				return this.blockFactor;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00009668 File Offset: 0x00008668
		[global::System.Obsolete("Use BlockFactor property instead")]
		public int GetBlockFactor()
		{
			return this.blockFactor;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00009670 File Offset: 0x00008670
		protected TarBuffer()
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000968B File Offset: 0x0000868B
		public static global::ICSharpCode.SharpZipLib.Tar.TarBuffer CreateInputTarBuffer(global::System.IO.Stream inputStream)
		{
			if (inputStream == null)
			{
				throw new global::System.ArgumentNullException("inputStream");
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarBuffer.CreateInputTarBuffer(inputStream, 20);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000096A4 File Offset: 0x000086A4
		public static global::ICSharpCode.SharpZipLib.Tar.TarBuffer CreateInputTarBuffer(global::System.IO.Stream inputStream, int blockFactor)
		{
			if (inputStream == null)
			{
				throw new global::System.ArgumentNullException("inputStream");
			}
			if (blockFactor <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("blockFactor", "Factor cannot be negative");
			}
			global::ICSharpCode.SharpZipLib.Tar.TarBuffer tarBuffer = new global::ICSharpCode.SharpZipLib.Tar.TarBuffer();
			tarBuffer.inputStream = inputStream;
			tarBuffer.outputStream = null;
			tarBuffer.Initialize(blockFactor);
			return tarBuffer;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000096EF File Offset: 0x000086EF
		public static global::ICSharpCode.SharpZipLib.Tar.TarBuffer CreateOutputTarBuffer(global::System.IO.Stream outputStream)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarBuffer.CreateOutputTarBuffer(outputStream, 20);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00009708 File Offset: 0x00008708
		public static global::ICSharpCode.SharpZipLib.Tar.TarBuffer CreateOutputTarBuffer(global::System.IO.Stream outputStream, int blockFactor)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			if (blockFactor <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("blockFactor", "Factor cannot be negative");
			}
			global::ICSharpCode.SharpZipLib.Tar.TarBuffer tarBuffer = new global::ICSharpCode.SharpZipLib.Tar.TarBuffer();
			tarBuffer.inputStream = null;
			tarBuffer.outputStream = outputStream;
			tarBuffer.Initialize(blockFactor);
			return tarBuffer;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00009754 File Offset: 0x00008754
		private void Initialize(int blockFactor)
		{
			this.blockFactor = blockFactor;
			this.recordSize = blockFactor * 512;
			this.recordBuffer = new byte[this.RecordSize];
			if (this.inputStream != null)
			{
				this.currentRecordIndex = -1;
				this.currentBlockIndex = this.BlockFactor;
				return;
			}
			this.currentRecordIndex = 0;
			this.currentBlockIndex = 0;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000097B0 File Offset: 0x000087B0
		[global::System.Obsolete("Use IsEndOfArchiveBlock instead")]
		public bool IsEOFBlock(byte[] block)
		{
			if (block == null)
			{
				throw new global::System.ArgumentNullException("block");
			}
			if (block.Length != 512)
			{
				throw new global::System.ArgumentException("block length is invalid");
			}
			for (int i = 0; i < 512; i++)
			{
				if (block[i] != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000097F8 File Offset: 0x000087F8
		public static bool IsEndOfArchiveBlock(byte[] block)
		{
			if (block == null)
			{
				throw new global::System.ArgumentNullException("block");
			}
			if (block.Length != 512)
			{
				throw new global::System.ArgumentException("block length is invalid");
			}
			for (int i = 0; i < 512; i++)
			{
				if (block[i] != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00009840 File Offset: 0x00008840
		public void SkipBlock()
		{
			if (this.inputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("no input stream defined");
			}
			if (this.currentBlockIndex >= this.BlockFactor && !this.ReadRecord())
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("Failed to read a record");
			}
			this.currentBlockIndex++;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00009890 File Offset: 0x00008890
		public byte[] ReadBlock()
		{
			if (this.inputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("TarBuffer.ReadBlock - no input stream defined");
			}
			if (this.currentBlockIndex >= this.BlockFactor && !this.ReadRecord())
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("Failed to read a record");
			}
			byte[] array = new byte[512];
			global::System.Array.Copy(this.recordBuffer, this.currentBlockIndex * 512, array, 0, 512);
			this.currentBlockIndex++;
			return array;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000990C File Offset: 0x0000890C
		private bool ReadRecord()
		{
			if (this.inputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("no input stream stream defined");
			}
			this.currentBlockIndex = 0;
			int num = 0;
			long num2;
			for (int i = this.RecordSize; i > 0; i -= (int)num2)
			{
				num2 = (long)this.inputStream.Read(this.recordBuffer, num, i);
				if (num2 <= 0L)
				{
					break;
				}
				num += (int)num2;
			}
			this.currentRecordIndex++;
			return true;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00009975 File Offset: 0x00008975
		public int CurrentBlock
		{
			get
			{
				return this.currentBlockIndex;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000997D File Offset: 0x0000897D
		[global::System.Obsolete("Use CurrentBlock property instead")]
		public int GetCurrentBlockNum()
		{
			return this.currentBlockIndex;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00009985 File Offset: 0x00008985
		public int CurrentRecord
		{
			get
			{
				return this.currentRecordIndex;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000998D File Offset: 0x0000898D
		[global::System.Obsolete("Use CurrentRecord property instead")]
		public int GetCurrentRecordNum()
		{
			return this.currentRecordIndex;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00009998 File Offset: 0x00008998
		public void WriteBlock(byte[] block)
		{
			if (block == null)
			{
				throw new global::System.ArgumentNullException("block");
			}
			if (this.outputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("TarBuffer.WriteBlock - no output stream defined");
			}
			if (block.Length != 512)
			{
				string message = string.Format("TarBuffer.WriteBlock - block to write has length '{0}' which is not the block size of '{1}'", block.Length, 512);
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException(message);
			}
			if (this.currentBlockIndex >= this.BlockFactor)
			{
				this.WriteRecord();
			}
			global::System.Array.Copy(block, 0, this.recordBuffer, this.currentBlockIndex * 512, 512);
			this.currentBlockIndex++;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00009A34 File Offset: 0x00008A34
		public void WriteBlock(byte[] buffer, int offset)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (this.outputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("TarBuffer.WriteBlock - no output stream stream defined");
			}
			if (offset < 0 || offset >= buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			if (offset + 512 > buffer.Length)
			{
				string message = string.Format("TarBuffer.WriteBlock - record has length '{0}' with offset '{1}' which is less than the record size of '{2}'", buffer.Length, offset, this.recordSize);
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException(message);
			}
			if (this.currentBlockIndex >= this.BlockFactor)
			{
				this.WriteRecord();
			}
			global::System.Array.Copy(buffer, offset, this.recordBuffer, this.currentBlockIndex * 512, 512);
			this.currentBlockIndex++;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00009AF0 File Offset: 0x00008AF0
		private void WriteRecord()
		{
			if (this.outputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("TarBuffer.WriteRecord no output stream defined");
			}
			this.outputStream.Write(this.recordBuffer, 0, this.RecordSize);
			this.outputStream.Flush();
			this.currentBlockIndex = 0;
			this.currentRecordIndex++;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00009B48 File Offset: 0x00008B48
		private void Flush()
		{
			if (this.outputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("TarBuffer.Flush no output stream defined");
			}
			if (this.currentBlockIndex > 0)
			{
				int num = this.currentBlockIndex * 512;
				global::System.Array.Clear(this.recordBuffer, num, this.RecordSize - num);
				this.WriteRecord();
			}
			this.outputStream.Flush();
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00009BA3 File Offset: 0x00008BA3
		public void Close()
		{
			if (this.outputStream != null)
			{
				this.Flush();
				this.outputStream.Close();
				this.outputStream = null;
				return;
			}
			if (this.inputStream != null)
			{
				this.inputStream.Close();
				this.inputStream = null;
			}
		}

		// Token: 0x040000B5 RID: 181
		public const int BlockSize = 512;

		// Token: 0x040000B6 RID: 182
		public const int DefaultBlockFactor = 20;

		// Token: 0x040000B7 RID: 183
		public const int DefaultRecordSize = 10240;

		// Token: 0x040000B8 RID: 184
		private global::System.IO.Stream inputStream;

		// Token: 0x040000B9 RID: 185
		private global::System.IO.Stream outputStream;

		// Token: 0x040000BA RID: 186
		private byte[] recordBuffer;

		// Token: 0x040000BB RID: 187
		private int currentBlockIndex;

		// Token: 0x040000BC RID: 188
		private int currentRecordIndex;

		// Token: 0x040000BD RID: 189
		private int recordSize = 10240;

		// Token: 0x040000BE RID: 190
		private int blockFactor = 20;
	}
}
