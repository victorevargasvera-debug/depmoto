using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.GZip
{
	// Token: 0x02000028 RID: 40
	public class GZipInputStream : global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream
	{
		// Token: 0x0600011F RID: 287 RVA: 0x000081E5 File Offset: 0x000071E5
		public GZipInputStream(global::System.IO.Stream baseInputStream) : this(baseInputStream, 4096)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000081F3 File Offset: 0x000071F3
		public GZipInputStream(global::System.IO.Stream baseInputStream, int size) : base(baseInputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater(true), size)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00008210 File Offset: 0x00007210
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (!this.readGZIPHeader)
			{
				this.ReadHeader();
			}
			if (this.eos)
			{
				return 0;
			}
			int num = base.Read(buffer, offset, count);
			if (num > 0)
			{
				this.crc.Update(buffer, offset, num);
			}
			if (this.inf.IsFinished)
			{
				this.ReadFooter();
			}
			return num;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00008268 File Offset: 0x00007268
		private void ReadHeader()
		{
			global::ICSharpCode.SharpZipLib.Checksums.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksums.Crc32();
			int num = this.baseInputStream.ReadByte();
			if (num < 0)
			{
				throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
			}
			crc.Update(num);
			if (num != 31)
			{
				throw new global::ICSharpCode.SharpZipLib.GZip.GZipException("Error GZIP header, first magic byte doesn't match");
			}
			num = this.baseInputStream.ReadByte();
			if (num < 0)
			{
				throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
			}
			if (num != 139)
			{
				throw new global::ICSharpCode.SharpZipLib.GZip.GZipException("Error GZIP header,  second magic byte doesn't match");
			}
			crc.Update(num);
			int num2 = this.baseInputStream.ReadByte();
			if (num2 < 0)
			{
				throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
			}
			if (num2 != 8)
			{
				throw new global::ICSharpCode.SharpZipLib.GZip.GZipException("Error GZIP header, data not in deflate format");
			}
			crc.Update(num2);
			int num3 = this.baseInputStream.ReadByte();
			if (num3 < 0)
			{
				throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
			}
			crc.Update(num3);
			if ((num3 & 224) != 0)
			{
				throw new global::ICSharpCode.SharpZipLib.GZip.GZipException("Reserved flag bits in GZIP header != 0");
			}
			for (int i = 0; i < 6; i++)
			{
				int num4 = this.baseInputStream.ReadByte();
				if (num4 < 0)
				{
					throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
				}
				crc.Update(num4);
			}
			if ((num3 & 4) != 0)
			{
				for (int j = 0; j < 2; j++)
				{
					int num5 = this.baseInputStream.ReadByte();
					if (num5 < 0)
					{
						throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
					}
					crc.Update(num5);
				}
				if (this.baseInputStream.ReadByte() < 0 || this.baseInputStream.ReadByte() < 0)
				{
					throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
				}
				int num6 = this.baseInputStream.ReadByte();
				int num7 = this.baseInputStream.ReadByte();
				if (num6 < 0 || num7 < 0)
				{
					throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
				}
				crc.Update(num6);
				crc.Update(num7);
				int num8 = num6 << 8 | num7;
				for (int k = 0; k < num8; k++)
				{
					int num9 = this.baseInputStream.ReadByte();
					if (num9 < 0)
					{
						throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
					}
					crc.Update(num9);
				}
			}
			if ((num3 & 8) != 0)
			{
				int num10;
				while ((num10 = this.baseInputStream.ReadByte()) > 0)
				{
					crc.Update(num10);
				}
				if (num10 < 0)
				{
					throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
				}
				crc.Update(num10);
			}
			if ((num3 & 16) != 0)
			{
				int num11;
				while ((num11 = this.baseInputStream.ReadByte()) > 0)
				{
					crc.Update(num11);
				}
				if (num11 < 0)
				{
					throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
				}
				crc.Update(num11);
			}
			if ((num3 & 2) != 0)
			{
				int num12 = this.baseInputStream.ReadByte();
				if (num12 < 0)
				{
					throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
				}
				int num13 = this.baseInputStream.ReadByte();
				if (num13 < 0)
				{
					throw new global::System.IO.EndOfStreamException("EOS reading GZIP header");
				}
				num12 = (num12 << 8 | num13);
				if (num12 != ((int)crc.Value & 65535))
				{
					throw new global::ICSharpCode.SharpZipLib.GZip.GZipException("Header CRC value mismatch");
				}
			}
			this.readGZIPHeader = true;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000853C File Offset: 0x0000753C
		private void ReadFooter()
		{
			byte[] array = new byte[8];
			int num = this.inf.RemainingInput;
			if (num > 8)
			{
				num = 8;
			}
			global::System.Array.Copy(this.inputBuffer.RawData, this.inputBuffer.RawLength - this.inf.RemainingInput, array, 0, num);
			int num2;
			for (int i = 8 - num; i > 0; i -= num2)
			{
				num2 = this.baseInputStream.Read(array, 8 - i, i);
				if (num2 <= 0)
				{
					throw new global::System.IO.EndOfStreamException("EOS reading GZIP footer");
				}
			}
			int num3 = (int)(array[0] & byte.MaxValue) | (int)(array[1] & byte.MaxValue) << 8 | (int)(array[2] & byte.MaxValue) << 16 | (int)array[3] << 24;
			if (num3 != (int)this.crc.Value)
			{
				throw new global::ICSharpCode.SharpZipLib.GZip.GZipException(string.Concat(new object[]
				{
					"GZIP crc sum mismatch, theirs \"",
					num3,
					"\" and ours \"",
					(int)this.crc.Value
				}));
			}
			uint num4 = (uint)((int)(array[4] & byte.MaxValue) | (int)(array[5] & byte.MaxValue) << 8 | (int)(array[6] & byte.MaxValue) << 16 | (int)array[7] << 24);
			if ((this.inf.TotalOut & (long)((ulong)-1)) != (long)((ulong)num4))
			{
				throw new global::ICSharpCode.SharpZipLib.GZip.GZipException("Number of bytes mismatch in footer");
			}
			this.eos = true;
		}

		// Token: 0x04000097 RID: 151
		protected global::ICSharpCode.SharpZipLib.Checksums.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksums.Crc32();

		// Token: 0x04000098 RID: 152
		protected bool eos;

		// Token: 0x04000099 RID: 153
		private bool readGZIPHeader;
	}
}
