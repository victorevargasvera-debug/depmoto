using System;
using System.IO;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x02000037 RID: 55
	public class InflaterInputBuffer
	{
		// Token: 0x06000222 RID: 546 RVA: 0x0000B679 File Offset: 0x0000A679
		public InflaterInputBuffer(global::System.IO.Stream stream) : this(stream, 4096)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000B687 File Offset: 0x0000A687
		public InflaterInputBuffer(global::System.IO.Stream stream, int bufferSize)
		{
			this.inputStream = stream;
			if (bufferSize < 1024)
			{
				bufferSize = 1024;
			}
			this.rawData = new byte[bufferSize];
			this.clearText = this.rawData;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000B6BD File Offset: 0x0000A6BD
		public int RawLength
		{
			get
			{
				return this.rawLength;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000B6C5 File Offset: 0x0000A6C5
		public byte[] RawData
		{
			get
			{
				return this.rawData;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000B6CD File Offset: 0x0000A6CD
		public int ClearTextLength
		{
			get
			{
				return this.clearTextLength;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000B6D5 File Offset: 0x0000A6D5
		public byte[] ClearText
		{
			get
			{
				return this.clearText;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000B6DD File Offset: 0x0000A6DD
		// (set) Token: 0x06000229 RID: 553 RVA: 0x0000B6E5 File Offset: 0x0000A6E5
		public int Available
		{
			get
			{
				return this.available;
			}
			set
			{
				this.available = value;
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000B6EE File Offset: 0x0000A6EE
		public void SetInflaterInput(global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater inflater)
		{
			if (this.available > 0)
			{
				inflater.SetInput(this.clearText, this.clearTextLength - this.available, this.available);
				this.available = 0;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000B720 File Offset: 0x0000A720
		public void Fill()
		{
			this.rawLength = 0;
			int i = this.rawData.Length;
			while (i > 0)
			{
				int num = this.inputStream.Read(this.rawData, this.rawLength, i);
				if (num <= 0)
				{
					if (this.rawLength == 0)
					{
						throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Unexpected EOF");
					}
					break;
				}
				else
				{
					this.rawLength += num;
					i -= num;
				}
			}
			if (this.cryptoTransform != null)
			{
				this.clearTextLength = this.cryptoTransform.TransformBlock(this.rawData, 0, this.rawLength, this.clearText, 0);
			}
			else
			{
				this.clearTextLength = this.rawLength;
			}
			this.available = this.clearTextLength;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000B7CC File Offset: 0x0000A7CC
		public int ReadRawBuffer(byte[] buffer)
		{
			return this.ReadRawBuffer(buffer, 0, buffer.Length);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000B7DC File Offset: 0x0000A7DC
		public int ReadRawBuffer(byte[] outBuffer, int offset, int length)
		{
			if (length < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("length");
			}
			int num = offset;
			int i = length;
			while (i > 0)
			{
				if (this.available <= 0)
				{
					this.Fill();
					if (this.available <= 0)
					{
						return 0;
					}
				}
				int num2 = global::System.Math.Min(i, this.available);
				global::System.Array.Copy(this.rawData, this.rawLength - this.available, outBuffer, num, num2);
				num += num2;
				i -= num2;
				this.available -= num2;
			}
			return length;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000B85C File Offset: 0x0000A85C
		public int ReadClearTextBuffer(byte[] outBuffer, int offset, int length)
		{
			if (length < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("length");
			}
			int num = offset;
			int i = length;
			while (i > 0)
			{
				if (this.available <= 0)
				{
					this.Fill();
					if (this.available <= 0)
					{
						return 0;
					}
				}
				int num2 = global::System.Math.Min(i, this.available);
				global::System.Array.Copy(this.clearText, this.clearTextLength - this.available, outBuffer, num, num2);
				num += num2;
				i -= num2;
				this.available -= num2;
			}
			return length;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000B8DC File Offset: 0x0000A8DC
		public int ReadLeByte()
		{
			if (this.available <= 0)
			{
				this.Fill();
				if (this.available <= 0)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("EOF in header");
				}
			}
			byte result = this.rawData[this.rawLength - this.available];
			this.available--;
			return (int)result;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000B930 File Offset: 0x0000A930
		public int ReadLeShort()
		{
			return this.ReadLeByte() | this.ReadLeByte() << 8;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000B941 File Offset: 0x0000A941
		public int ReadLeInt()
		{
			return this.ReadLeShort() | this.ReadLeShort() << 16;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000B953 File Offset: 0x0000A953
		public long ReadLeLong()
		{
			return (long)((ulong)this.ReadLeInt() | (ulong)((ulong)((long)this.ReadLeInt()) << 32));
		}

		// Token: 0x17000079 RID: 121
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0000B968 File Offset: 0x0000A968
		public global::System.Security.Cryptography.ICryptoTransform CryptoTransform
		{
			set
			{
				this.cryptoTransform = value;
				if (this.cryptoTransform != null)
				{
					if (this.rawData == this.clearText)
					{
						if (this.internalClearText == null)
						{
							this.internalClearText = new byte[this.rawData.Length];
						}
						this.clearText = this.internalClearText;
					}
					this.clearTextLength = this.rawLength;
					if (this.available > 0)
					{
						this.cryptoTransform.TransformBlock(this.rawData, this.rawLength - this.available, this.available, this.clearText, this.rawLength - this.available);
						return;
					}
				}
				else
				{
					this.clearText = this.rawData;
					this.clearTextLength = this.rawLength;
				}
			}
		}

		// Token: 0x0400010F RID: 271
		private int rawLength;

		// Token: 0x04000110 RID: 272
		private byte[] rawData;

		// Token: 0x04000111 RID: 273
		private int clearTextLength;

		// Token: 0x04000112 RID: 274
		private byte[] clearText;

		// Token: 0x04000113 RID: 275
		private byte[] internalClearText;

		// Token: 0x04000114 RID: 276
		private int available;

		// Token: 0x04000115 RID: 277
		private global::System.Security.Cryptography.ICryptoTransform cryptoTransform;

		// Token: 0x04000116 RID: 278
		private global::System.IO.Stream inputStream;
	}
}
