using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x02000027 RID: 39
	public class InflaterInputStream : global::System.IO.Stream
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00007F75 File Offset: 0x00006F75
		public InflaterInputStream(global::System.IO.Stream baseInputStream) : this(baseInputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater(), 4096)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00007F88 File Offset: 0x00006F88
		public InflaterInputStream(global::System.IO.Stream baseInputStream, global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf) : this(baseInputStream, inf, 4096)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00007F98 File Offset: 0x00006F98
		public InflaterInputStream(global::System.IO.Stream baseInputStream, global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater inflater, int bufferSize)
		{
			if (baseInputStream == null)
			{
				throw new global::System.ArgumentNullException("baseInputStream");
			}
			if (inflater == null)
			{
				throw new global::System.ArgumentNullException("inflater");
			}
			if (bufferSize <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("bufferSize");
			}
			this.baseInputStream = baseInputStream;
			this.inf = inflater;
			this.inputBuffer = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputBuffer(baseInputStream, bufferSize);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00007FF8 File Offset: 0x00006FF8
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00008000 File Offset: 0x00007000
		public bool IsStreamOwner
		{
			get
			{
				return this.isStreamOwner;
			}
			set
			{
				this.isStreamOwner = value;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000800C File Offset: 0x0000700C
		public long Skip(long count)
		{
			if (count <= 0L)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			if (this.baseInputStream.CanSeek)
			{
				this.baseInputStream.Seek(count, global::System.IO.SeekOrigin.Current);
				return count;
			}
			int num = 2048;
			if (count < (long)num)
			{
				num = (int)count;
			}
			byte[] buffer = new byte[num];
			int num2 = 1;
			long num3 = count;
			while (num3 > 0L && num2 > 0)
			{
				if (num3 < (long)num)
				{
					num = (int)num3;
				}
				num2 = this.baseInputStream.Read(buffer, 0, num);
				num3 -= (long)num2;
			}
			return count - num3;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00008089 File Offset: 0x00007089
		protected void StopDecrypting()
		{
			this.inputBuffer.CryptoTransform = null;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00008097 File Offset: 0x00007097
		public virtual int Available
		{
			get
			{
				if (!this.inf.IsFinished)
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000080A9 File Offset: 0x000070A9
		protected void Fill()
		{
			this.inputBuffer.Fill();
			this.inputBuffer.SetInflaterInput(this.inf);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000080C7 File Offset: 0x000070C7
		public override bool CanRead
		{
			get
			{
				return this.baseInputStream.CanRead;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000080D4 File Offset: 0x000070D4
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000080D7 File Offset: 0x000070D7
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000114 RID: 276 RVA: 0x000080DA File Offset: 0x000070DA
		public override long Length
		{
			get
			{
				return (long)this.inputBuffer.RawLength;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000080E8 File Offset: 0x000070E8
		// (set) Token: 0x06000116 RID: 278 RVA: 0x000080F5 File Offset: 0x000070F5
		public override long Position
		{
			get
			{
				return this.baseInputStream.Position;
			}
			set
			{
				throw new global::System.NotSupportedException("InflaterInputStream Position not supported");
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00008101 File Offset: 0x00007101
		public override void Flush()
		{
			this.baseInputStream.Flush();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000810E File Offset: 0x0000710E
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException("Seek not supported");
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000811A File Offset: 0x0000711A
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException("InflaterInputStream SetLength not supported");
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008126 File Offset: 0x00007126
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("InflaterInputStream Write not supported");
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00008132 File Offset: 0x00007132
		public override void WriteByte(byte value)
		{
			throw new global::System.NotSupportedException("InflaterInputStream WriteByte not supported");
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000813E File Offset: 0x0000713E
		public override global::System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state)
		{
			throw new global::System.NotSupportedException("InflaterInputStream BeginWrite not supported");
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000814A File Offset: 0x0000714A
		public override void Close()
		{
			if (!this.isClosed)
			{
				this.isClosed = true;
				if (this.isStreamOwner)
				{
					this.baseInputStream.Close();
				}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00008170 File Offset: 0x00007170
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this.inf.IsNeedingDictionary)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Need a dictionary");
			}
			int num = count;
			for (;;)
			{
				int num2 = this.inf.Inflate(buffer, offset, num);
				offset += num2;
				num -= num2;
				if (num == 0 || this.inf.IsFinished)
				{
					goto IL_65;
				}
				if (this.inf.IsNeedingInput)
				{
					this.Fill();
				}
				else if (num2 == 0)
				{
					break;
				}
			}
			throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Dont know what to do");
			IL_65:
			return count - num;
		}

		// Token: 0x04000091 RID: 145
		protected global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf;

		// Token: 0x04000092 RID: 146
		protected global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputBuffer inputBuffer;

		// Token: 0x04000093 RID: 147
		protected global::System.IO.Stream baseInputStream;

		// Token: 0x04000094 RID: 148
		protected long csize;

		// Token: 0x04000095 RID: 149
		private bool isClosed;

		// Token: 0x04000096 RID: 150
		private bool isStreamOwner = true;
	}
}
