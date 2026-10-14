using System;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000089 RID: 137
	internal sealed class SharpZipWrapperInputStream : global::System.IO.Stream
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600038B RID: 907 RVA: 0x000144F4 File Offset: 0x000126F4
		// (set) Token: 0x0600038C RID: 908 RVA: 0x000144FC File Offset: 0x000126FC
		public long CompressedSize { get; private set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00014505 File Offset: 0x00012705
		public override bool CanRead
		{
			get
			{
				return this._baseStream.CanRead;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00014512 File Offset: 0x00012712
		public override bool CanSeek
		{
			get
			{
				return this._baseStream.CanSeek;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0001451F File Offset: 0x0001271F
		public override bool CanWrite
		{
			get
			{
				return this._baseStream.CanWrite;
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0001452C File Offset: 0x0001272C
		public override void Flush()
		{
			this._baseStream.Flush();
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00014539 File Offset: 0x00012739
		public override long Length
		{
			get
			{
				return this._uncompressedSize;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00014541 File Offset: 0x00012741
		// (set) Token: 0x06000393 RID: 915 RVA: 0x0001454E File Offset: 0x0001274E
		public override long Position
		{
			get
			{
				return this._baseStream.Position;
			}
			set
			{
				this._baseStream.Position = value;
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0001455C File Offset: 0x0001275C
		public SharpZipWrapperInputStream(global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream stream, global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream", "stream cannot be null");
			}
			if (zipEntry == null)
			{
				throw new global::System.ArgumentNullException("zipEntry", "zipEntry cannot be null");
			}
			this._baseStream = stream;
			this.CompressedSize = zipEntry.CompressedSize;
			this._uncompressedSize = zipEntry.Size;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000145B4 File Offset: 0x000127B4
		public SharpZipWrapperInputStream(global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile, global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry)
		{
			if (zipFile == null)
			{
				throw new global::System.ArgumentNullException("zipFile", "zipFile cannot be null");
			}
			if (zipEntry == null)
			{
				throw new global::System.ArgumentNullException("zipEntry", "zipEntry cannot be null");
			}
			this._baseStream = zipFile.GetInputStream(zipEntry);
			this._uncompressedSize = zipEntry.Size;
			this.CompressedSize = zipEntry.CompressedSize;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00014612 File Offset: 0x00012812
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this._baseStream.Read(buffer, offset, count);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00014622 File Offset: 0x00012822
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this._baseStream.Seek(offset, origin);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00014631 File Offset: 0x00012831
		public override void SetLength(long value)
		{
			this._baseStream.SetLength(value);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0001463F File Offset: 0x0001283F
		public override void Write(byte[] buffer, int offset, int count)
		{
			this._baseStream.Write(buffer, offset, count);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0001464F File Offset: 0x0001284F
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (disposing)
			{
				this._baseStream.Dispose();
			}
		}

		// Token: 0x04000427 RID: 1063
		private global::System.IO.Stream _baseStream;

		// Token: 0x04000428 RID: 1064
		private long _uncompressedSize;
	}
}
