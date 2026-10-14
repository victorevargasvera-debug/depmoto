using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Encryption;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000078 RID: 120
	public class ZipInputStream : global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream
	{
		// Token: 0x06000494 RID: 1172 RVA: 0x00016292 File Offset: 0x00015292
		public ZipInputStream(global::System.IO.Stream baseInputStream) : base(baseInputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater(true))
		{
			this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.ReadingNotAvailable);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x000162BE File Offset: 0x000152BE
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x000162C6 File Offset: 0x000152C6
		public string Password
		{
			get
			{
				return this.password;
			}
			set
			{
				this.password = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x000162CF File Offset: 0x000152CF
		public bool CanDecompressEntry
		{
			get
			{
				return this.entry != null && this.entry.CanDecompress;
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000162E8 File Offset: 0x000152E8
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry GetNextEntry()
		{
			if (this.crc == null)
			{
				throw new global::System.InvalidOperationException("Closed.");
			}
			if (this.entry != null)
			{
				this.CloseEntry();
			}
			int num = this.inputBuffer.ReadLeInt();
			if (num == 33639248 || num == 101010256 || num == 84233040 || num == 117853008 || num == 101075792)
			{
				this.Close();
				return null;
			}
			if (num == 808471376 || num == 134695760)
			{
				num = this.inputBuffer.ReadLeInt();
			}
			if (num != 67324752)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Wrong Local header signature: 0x" + string.Format("{0:X}", num));
			}
			short versionRequiredToExtract = (short)this.inputBuffer.ReadLeShort();
			this.flags = this.inputBuffer.ReadLeShort();
			this.method = this.inputBuffer.ReadLeShort();
			uint num2 = (uint)this.inputBuffer.ReadLeInt();
			int num3 = this.inputBuffer.ReadLeInt();
			this.csize = (long)this.inputBuffer.ReadLeInt();
			this.size = (long)this.inputBuffer.ReadLeInt();
			int num4 = this.inputBuffer.ReadLeShort();
			int num5 = this.inputBuffer.ReadLeShort();
			bool flag = (this.flags & 1) == 1;
			byte[] array = new byte[num4];
			this.inputBuffer.ReadRawBuffer(array);
			string name = global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToStringExt(this.flags, array);
			this.entry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(name, (int)versionRequiredToExtract);
			this.entry.Flags = this.flags;
			this.entry.CompressionMethod = (global::ICSharpCode.SharpZipLib.Zip.CompressionMethod)this.method;
			if ((this.flags & 8) == 0)
			{
				this.entry.Crc = ((long)num3 & (long)((ulong)-1));
				this.entry.Size = (this.size & (long)((ulong)-1));
				this.entry.CompressedSize = (this.csize & (long)((ulong)-1));
				this.entry.CryptoCheckValue = (byte)(num3 >> 24 & 255);
			}
			else
			{
				if (num3 != 0)
				{
					this.entry.Crc = ((long)num3 & (long)((ulong)-1));
				}
				if (this.size != 0L)
				{
					this.entry.Size = (this.size & (long)((ulong)-1));
				}
				if (this.csize != 0L)
				{
					this.entry.CompressedSize = (this.csize & (long)((ulong)-1));
				}
				this.entry.CryptoCheckValue = (byte)(num2 >> 8 & 255U);
			}
			this.entry.DosTime = (long)((ulong)num2);
			if (num5 > 0)
			{
				byte[] array2 = new byte[num5];
				this.inputBuffer.ReadRawBuffer(array2);
				this.entry.ExtraData = array2;
			}
			this.entry.ProcessExtraData(true);
			if (this.entry.CompressedSize >= 0L)
			{
				this.csize = this.entry.CompressedSize;
			}
			if (this.entry.Size >= 0L)
			{
				this.size = this.entry.Size;
			}
			if (this.method == 0 && ((!flag && this.csize != this.size) || (flag && this.csize - 12L != this.size)))
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Stored, but compressed != uncompressed");
			}
			if (this.entry.IsCompressionMethodSupported())
			{
				this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.InitialRead);
			}
			else
			{
				this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.ReadingNotSupported);
			}
			return this.entry;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00016634 File Offset: 0x00015634
		private void ReadDataDescriptor()
		{
			if (this.inputBuffer.ReadLeInt() != 134695760)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Data descriptor signature not found");
			}
			this.entry.Crc = ((long)this.inputBuffer.ReadLeInt() & (long)((ulong)-1));
			if (this.entry.LocalHeaderRequiresZip64)
			{
				this.csize = this.inputBuffer.ReadLeLong();
				this.size = this.inputBuffer.ReadLeLong();
			}
			else
			{
				this.csize = (long)this.inputBuffer.ReadLeInt();
				this.size = (long)this.inputBuffer.ReadLeInt();
			}
			this.entry.CompressedSize = this.csize;
			this.entry.Size = this.size;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000166F0 File Offset: 0x000156F0
		private void CompleteCloseEntry(bool testCrc)
		{
			base.StopDecrypting();
			if ((this.flags & 8) != 0)
			{
				this.ReadDataDescriptor();
			}
			this.size = 0L;
			if (testCrc && (this.crc.Value & (long)((ulong)-1)) != this.entry.Crc && this.entry.Crc != -1L)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("CRC mismatch");
			}
			this.crc.Reset();
			if (this.method == 8)
			{
				this.inf.Reset();
			}
			this.entry = null;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0001677C File Offset: 0x0001577C
		public void CloseEntry()
		{
			if (this.crc == null)
			{
				throw new global::System.InvalidOperationException("Closed");
			}
			if (this.entry == null)
			{
				return;
			}
			if (this.method == 8)
			{
				if ((this.flags & 8) != 0)
				{
					byte[] array = new byte[4096];
					while (this.Read(array, 0, array.Length) > 0)
					{
					}
					return;
				}
				this.csize -= this.inf.TotalIn;
				this.inputBuffer.Available += this.inf.RemainingInput;
			}
			if ((long)this.inputBuffer.Available > this.csize && this.csize >= 0L)
			{
				this.inputBuffer.Available = (int)((long)this.inputBuffer.Available - this.csize);
			}
			else
			{
				this.csize -= (long)this.inputBuffer.Available;
				this.inputBuffer.Available = 0;
				while (this.csize != 0L)
				{
					long num = base.Skip(this.csize);
					if (num <= 0L)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Zip archive ends early.");
					}
					this.csize -= num;
				}
			}
			this.CompleteCloseEntry(false);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x000168A9 File Offset: 0x000158A9
		public override int Available
		{
			get
			{
				if (this.entry == null)
				{
					return 0;
				}
				return 1;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000168B6 File Offset: 0x000158B6
		public override long Length
		{
			get
			{
				if (this.entry == null)
				{
					throw new global::System.InvalidOperationException("No current entry");
				}
				if (this.entry.Size >= 0L)
				{
					return this.entry.Size;
				}
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Length not available for the current entry");
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000168F0 File Offset: 0x000158F0
		public override int ReadByte()
		{
			byte[] array = new byte[1];
			if (this.Read(array, 0, 1) <= 0)
			{
				return -1;
			}
			return (int)(array[0] & byte.MaxValue);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0001691B File Offset: 0x0001591B
		private int ReadingNotAvailable(byte[] destination, int offset, int count)
		{
			throw new global::System.InvalidOperationException("Unable to read from this stream");
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00016927 File Offset: 0x00015927
		private int ReadingNotSupported(byte[] destination, int offset, int count)
		{
			throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("The compression method for this entry is not supported");
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00016934 File Offset: 0x00015934
		private int InitialRead(byte[] destination, int offset, int count)
		{
			if (!this.CanDecompressEntry)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Library cannot extract this entry. Version required is (" + this.entry.Version.ToString() + ")");
			}
			if (this.entry.IsCrypted)
			{
				if (this.password == null)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("No password set.");
				}
				global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged pkzipClassicManaged = new global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged();
				byte[] rgbKey = global::ICSharpCode.SharpZipLib.Encryption.PkzipClassic.GenerateKeys(global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(this.password));
				this.inputBuffer.CryptoTransform = pkzipClassicManaged.CreateDecryptor(rgbKey, null);
				byte[] array = new byte[12];
				this.inputBuffer.ReadClearTextBuffer(array, 0, 12);
				if (array[11] != this.entry.CryptoCheckValue)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Invalid password");
				}
				if (this.csize >= 12L)
				{
					this.csize -= 12L;
				}
				else if ((this.entry.Flags & 8) == 0)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Entry compressed size {0} too small for encryption", this.csize));
				}
			}
			else
			{
				this.inputBuffer.CryptoTransform = null;
			}
			if (this.csize > 0L || (this.flags & 8) != 0)
			{
				if (this.method == 8 && this.inputBuffer.Available > 0)
				{
					this.inputBuffer.SetInflaterInput(this.inf);
				}
				this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.BodyRead);
				return this.BodyRead(destination, offset, count);
			}
			this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.ReadingNotAvailable);
			return 0;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00016AB0 File Offset: 0x00015AB0
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "Cannot be negative");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "Cannot be negative");
			}
			if (buffer.Length - offset < count)
			{
				throw new global::System.ArgumentException("Invalid offset/count combination");
			}
			return this.internalReader(buffer, offset, count);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00016B14 File Offset: 0x00015B14
		private int BodyRead(byte[] buffer, int offset, int count)
		{
			if (this.crc == null)
			{
				throw new global::System.InvalidOperationException("Closed");
			}
			if (this.entry == null || count <= 0)
			{
				return 0;
			}
			if (offset + count > buffer.Length)
			{
				throw new global::System.ArgumentException("Offset + count exceeds buffer size");
			}
			bool flag = false;
			int num = this.method;
			if (num != 0)
			{
				if (num == 8)
				{
					count = base.Read(buffer, offset, count);
					if (count <= 0)
					{
						if (!this.inf.IsFinished)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Inflater not finished!");
						}
						this.inputBuffer.Available = this.inf.RemainingInput;
						if ((this.flags & 8) == 0 && (this.inf.TotalIn != this.csize || this.inf.TotalOut != this.size))
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Concat(new object[]
							{
								"Size mismatch: ",
								this.csize,
								";",
								this.size,
								" <-> ",
								this.inf.TotalIn,
								";",
								this.inf.TotalOut
							}));
						}
						this.inf.Reset();
						flag = true;
					}
				}
			}
			else
			{
				if ((long)count > this.csize && this.csize >= 0L)
				{
					count = (int)this.csize;
				}
				if (count > 0)
				{
					count = this.inputBuffer.ReadClearTextBuffer(buffer, offset, count);
					if (count > 0)
					{
						this.csize -= (long)count;
						this.size -= (long)count;
					}
				}
				if (this.csize == 0L)
				{
					flag = true;
				}
				else if (count < 0)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("EOF in stored block");
				}
			}
			if (count > 0)
			{
				this.crc.Update(buffer, offset, count);
			}
			if (flag)
			{
				this.CompleteCloseEntry(true);
			}
			return count;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00016CF0 File Offset: 0x00015CF0
		public override void Close()
		{
			this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.ReadingNotAvailable);
			this.crc = null;
			this.entry = null;
			base.Close();
		}

		// Token: 0x040002D8 RID: 728
		private global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler internalReader;

		// Token: 0x040002D9 RID: 729
		private global::ICSharpCode.SharpZipLib.Checksums.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksums.Crc32();

		// Token: 0x040002DA RID: 730
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry;

		// Token: 0x040002DB RID: 731
		private long size;

		// Token: 0x040002DC RID: 732
		private int method;

		// Token: 0x040002DD RID: 733
		private int flags;

		// Token: 0x040002DE RID: 734
		private string password;

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060004A6 RID: 1190
		private delegate int ReadDataHandler(byte[] b, int offset, int length);
	}
}
