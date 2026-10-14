using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.GZip
{
	// Token: 0x0200002A RID: 42
	public class GZipOutputStream : global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream
	{
		// Token: 0x06000140 RID: 320 RVA: 0x00008A13 File Offset: 0x00007A13
		public GZipOutputStream(global::System.IO.Stream baseOutputStream) : this(baseOutputStream, 4096)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00008A21 File Offset: 0x00007A21
		public GZipOutputStream(global::System.IO.Stream baseOutputStream, int size) : base(baseOutputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater(-1, true), size)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00008A3D File Offset: 0x00007A3D
		public void SetLevel(int level)
		{
			if (level < 1)
			{
				throw new global::System.ArgumentOutOfRangeException("level");
			}
			this.deflater_.SetLevel(level);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00008A5A File Offset: 0x00007A5A
		public int GetLevel()
		{
			return this.deflater_.GetLevel();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00008A67 File Offset: 0x00007A67
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.state_ == global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Header)
			{
				this.WriteHeader();
			}
			if (this.state_ != global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Footer)
			{
				throw new global::System.InvalidOperationException("Write not permitted in current state");
			}
			this.crc.Update(buffer, offset, count);
			base.Write(buffer, offset, count);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00008AA4 File Offset: 0x00007AA4
		public override void Close()
		{
			try
			{
				this.Finish();
			}
			finally
			{
				if (this.state_ != global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Closed)
				{
					this.state_ = global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Closed;
					if (base.IsStreamOwner)
					{
						this.baseOutputStream_.Close();
					}
				}
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00008AF0 File Offset: 0x00007AF0
		public override void Finish()
		{
			if (this.state_ == global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Header)
			{
				this.WriteHeader();
			}
			if (this.state_ == global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Footer)
			{
				this.state_ = global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Finished;
				base.Finish();
				uint num = (uint)(this.deflater_.TotalIn & (long)((ulong)-1));
				uint num2 = (uint)(this.crc.Value & (long)((ulong)-1));
				byte[] array = new byte[]
				{
					(byte)num2,
					(byte)(num2 >> 8),
					(byte)(num2 >> 16),
					(byte)(num2 >> 24),
					(byte)num,
					(byte)(num >> 8),
					(byte)(num >> 16),
					(byte)(num >> 24)
				};
				this.baseOutputStream_.Write(array, 0, array.Length);
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00008BA4 File Offset: 0x00007BA4
		private void WriteHeader()
		{
			if (this.state_ == global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Header)
			{
				this.state_ = global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState.Footer;
				int num = (int)((global::System.DateTime.Now.Ticks - new global::System.DateTime(1970, 1, 1).Ticks) / 10000000L);
				byte[] array = new byte[]
				{
					31,
					139,
					8,
					0,
					0,
					0,
					0,
					0,
					0,
					byte.MaxValue
				};
				array[4] = (byte)num;
				array[5] = (byte)(num >> 8);
				array[6] = (byte)(num >> 16);
				array[7] = (byte)(num >> 24);
				byte[] array2 = array;
				this.baseOutputStream_.Write(array2, 0, array2.Length);
			}
		}

		// Token: 0x040000A1 RID: 161
		protected global::ICSharpCode.SharpZipLib.Checksums.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksums.Crc32();

		// Token: 0x040000A2 RID: 162
		private global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream.OutputState state_;

		// Token: 0x0200002B RID: 43
		private enum OutputState
		{
			// Token: 0x040000A4 RID: 164
			Header,
			// Token: 0x040000A5 RID: 165
			Footer,
			// Token: 0x040000A6 RID: 166
			Finished,
			// Token: 0x040000A7 RID: 167
			Closed
		}
	}
}
