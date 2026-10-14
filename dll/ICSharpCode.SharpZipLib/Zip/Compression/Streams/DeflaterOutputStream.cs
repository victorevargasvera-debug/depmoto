using System;
using System.IO;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.Encryption;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x02000029 RID: 41
	public class DeflaterOutputStream : global::System.IO.Stream
	{
		// Token: 0x06000124 RID: 292 RVA: 0x0000868C File Offset: 0x0000768C
		public DeflaterOutputStream(global::System.IO.Stream baseOutputStream) : this(baseOutputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater(), 512)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000869F File Offset: 0x0000769F
		public DeflaterOutputStream(global::System.IO.Stream baseOutputStream, global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater deflater) : this(baseOutputStream, deflater, 512)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000086B0 File Offset: 0x000076B0
		public DeflaterOutputStream(global::System.IO.Stream baseOutputStream, global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater deflater, int bufferSize)
		{
			if (baseOutputStream == null)
			{
				throw new global::System.ArgumentNullException("baseOutputStream");
			}
			if (!baseOutputStream.CanWrite)
			{
				throw new global::System.ArgumentException("Must support writing", "baseOutputStream");
			}
			if (deflater == null)
			{
				throw new global::System.ArgumentNullException("deflater");
			}
			if (bufferSize <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("bufferSize");
			}
			this.baseOutputStream_ = baseOutputStream;
			this.buffer_ = new byte[bufferSize];
			this.deflater_ = deflater;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00008728 File Offset: 0x00007728
		public virtual void Finish()
		{
			this.deflater_.Finish();
			while (!this.deflater_.IsFinished)
			{
				int num = this.deflater_.Deflate(this.buffer_, 0, this.buffer_.Length);
				if (num <= 0)
				{
					break;
				}
				if (this.cryptoTransform_ != null)
				{
					this.EncryptBlock(this.buffer_, 0, num);
				}
				this.baseOutputStream_.Write(this.buffer_, 0, num);
			}
			if (!this.deflater_.IsFinished)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Can't deflate all input?");
			}
			this.baseOutputStream_.Flush();
			if (this.cryptoTransform_ != null)
			{
				this.cryptoTransform_.Dispose();
				this.cryptoTransform_ = null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000087D4 File Offset: 0x000077D4
		// (set) Token: 0x06000129 RID: 297 RVA: 0x000087DC File Offset: 0x000077DC
		public bool IsStreamOwner
		{
			get
			{
				return this.isStreamOwner_;
			}
			set
			{
				this.isStreamOwner_ = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000087E5 File Offset: 0x000077E5
		public bool CanPatchEntries
		{
			get
			{
				return this.baseOutputStream_.CanSeek;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000087F2 File Offset: 0x000077F2
		// (set) Token: 0x0600012C RID: 300 RVA: 0x000087FA File Offset: 0x000077FA
		public string Password
		{
			get
			{
				return this.password;
			}
			set
			{
				if (value != null && value.Length == 0)
				{
					this.password = null;
					return;
				}
				this.password = value;
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00008816 File Offset: 0x00007816
		protected void EncryptBlock(byte[] buffer, int offset, int length)
		{
			this.cryptoTransform_.TransformBlock(buffer, 0, length, buffer, 0);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000882C File Offset: 0x0000782C
		protected void InitializePassword(string password)
		{
			global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged pkzipClassicManaged = new global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged();
			byte[] rgbKey = global::ICSharpCode.SharpZipLib.Encryption.PkzipClassic.GenerateKeys(global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(password));
			this.cryptoTransform_ = pkzipClassicManaged.CreateEncryptor(rgbKey, null);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000885C File Offset: 0x0000785C
		protected void Deflate()
		{
			while (!this.deflater_.IsNeedingInput)
			{
				int num = this.deflater_.Deflate(this.buffer_, 0, this.buffer_.Length);
				if (num <= 0)
				{
					break;
				}
				if (this.cryptoTransform_ != null)
				{
					this.EncryptBlock(this.buffer_, 0, num);
				}
				this.baseOutputStream_.Write(this.buffer_, 0, num);
			}
			if (!this.deflater_.IsNeedingInput)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("DeflaterOutputStream can't deflate all input?");
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000088D8 File Offset: 0x000078D8
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000088DB File Offset: 0x000078DB
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000088DE File Offset: 0x000078DE
		public override bool CanWrite
		{
			get
			{
				return this.baseOutputStream_.CanWrite;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000088EB File Offset: 0x000078EB
		public override long Length
		{
			get
			{
				return this.baseOutputStream_.Length;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000088F8 File Offset: 0x000078F8
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00008905 File Offset: 0x00007905
		public override long Position
		{
			get
			{
				return this.baseOutputStream_.Position;
			}
			set
			{
				throw new global::System.NotSupportedException("Position property not supported");
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00008911 File Offset: 0x00007911
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException("DeflaterOutputStream Seek not supported");
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000891D File Offset: 0x0000791D
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException("DeflaterOutputStream SetLength not supported");
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00008929 File Offset: 0x00007929
		public override int ReadByte()
		{
			throw new global::System.NotSupportedException("DeflaterOutputStream ReadByte not supported");
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00008935 File Offset: 0x00007935
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("DeflaterOutputStream Read not supported");
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00008941 File Offset: 0x00007941
		public override global::System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state)
		{
			throw new global::System.NotSupportedException("DeflaterOutputStream BeginRead not currently supported");
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000894D File Offset: 0x0000794D
		public override global::System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, global::System.AsyncCallback callback, object state)
		{
			throw new global::System.NotSupportedException("BeginWrite is not supported");
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008959 File Offset: 0x00007959
		public override void Flush()
		{
			this.deflater_.Flush();
			this.Deflate();
			this.baseOutputStream_.Flush();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00008978 File Offset: 0x00007978
		public override void Close()
		{
			if (!this.isClosed_)
			{
				this.isClosed_ = true;
				try
				{
					this.Finish();
					if (this.cryptoTransform_ != null)
					{
						this.cryptoTransform_.Dispose();
						this.cryptoTransform_ = null;
					}
				}
				finally
				{
					if (this.isStreamOwner_)
					{
						this.baseOutputStream_.Close();
					}
				}
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000089DC File Offset: 0x000079DC
		public override void WriteByte(byte value)
		{
			this.Write(new byte[]
			{
				value
			}, 0, 1);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000089FD File Offset: 0x000079FD
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.deflater_.SetInput(buffer, offset, count);
			this.Deflate();
		}

		// Token: 0x0400009A RID: 154
		private string password;

		// Token: 0x0400009B RID: 155
		private global::System.Security.Cryptography.ICryptoTransform cryptoTransform_;

		// Token: 0x0400009C RID: 156
		private byte[] buffer_;

		// Token: 0x0400009D RID: 157
		protected global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater deflater_;

		// Token: 0x0400009E RID: 158
		protected global::System.IO.Stream baseOutputStream_;

		// Token: 0x0400009F RID: 159
		private bool isClosed_;

		// Token: 0x040000A0 RID: 160
		private bool isStreamOwner_ = true;
	}
}
