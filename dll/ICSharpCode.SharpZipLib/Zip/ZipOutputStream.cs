using System;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200007B RID: 123
	public class ZipOutputStream : global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream
	{
		// Token: 0x060004B3 RID: 1203 RVA: 0x00017008 File Offset: 0x00016008
		public ZipOutputStream(global::System.IO.Stream baseOutputStream) : base(baseOutputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater(-1, true))
		{
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0001706A File Offset: 0x0001606A
		public bool IsFinished
		{
			get
			{
				return this.entries == null;
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00017078 File Offset: 0x00016078
		public void SetComment(string comment)
		{
			byte[] array = global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(comment);
			if (array.Length > 65535)
			{
				throw new global::System.ArgumentOutOfRangeException("comment");
			}
			this.zipComment = array;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000170A8 File Offset: 0x000160A8
		public void SetLevel(int level)
		{
			this.deflater_.SetLevel(level);
			this.defaultCompressionLevel = level;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000170BD File Offset: 0x000160BD
		public int GetLevel()
		{
			return this.deflater_.GetLevel();
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x000170CA File Offset: 0x000160CA
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x000170D2 File Offset: 0x000160D2
		public global::ICSharpCode.SharpZipLib.Zip.UseZip64 UseZip64
		{
			get
			{
				return this.useZip64_;
			}
			set
			{
				this.useZip64_ = value;
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000170DB File Offset: 0x000160DB
		private void WriteLeShort(int value)
		{
			this.baseOutputStream_.WriteByte((byte)(value & 255));
			this.baseOutputStream_.WriteByte((byte)(value >> 8 & 255));
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00017105 File Offset: 0x00016105
		private void WriteLeInt(int value)
		{
			this.WriteLeShort(value);
			this.WriteLeShort(value >> 16);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00017118 File Offset: 0x00016118
		private void WriteLeLong(long value)
		{
			this.WriteLeInt((int)value);
			this.WriteLeInt((int)(value >> 32));
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00017130 File Offset: 0x00016130
		public void PutNextEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			if (this.entries == null)
			{
				throw new global::System.InvalidOperationException("ZipOutputStream was finished");
			}
			if (this.curEntry != null)
			{
				this.CloseEntry();
			}
			if (this.entries.Count == 2147483647)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Too many entries for Zip file");
			}
			global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod = entry.CompressionMethod;
			int level = this.defaultCompressionLevel;
			entry.Flags &= 2048;
			this.patchEntryHeader = false;
			bool flag;
			if (entry.Size == 0L)
			{
				entry.CompressedSize = entry.Size;
				entry.Crc = 0L;
				compressionMethod = global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored;
				flag = true;
			}
			else
			{
				flag = (entry.Size >= 0L && entry.HasCrc);
				if (compressionMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
				{
					if (!flag)
					{
						if (!base.CanPatchEntries)
						{
							compressionMethod = global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated;
							level = 0;
						}
					}
					else
					{
						entry.CompressedSize = entry.Size;
						flag = entry.HasCrc;
					}
				}
			}
			if (!flag)
			{
				if (!base.CanPatchEntries)
				{
					entry.Flags |= 8;
				}
				else
				{
					this.patchEntryHeader = true;
				}
			}
			if (base.Password != null)
			{
				entry.IsCrypted = true;
				if (entry.Crc < 0L)
				{
					entry.Flags |= 8;
				}
			}
			entry.Offset = this.offset;
			entry.CompressionMethod = compressionMethod;
			this.curMethod = compressionMethod;
			this.sizePatchPos = -1L;
			if (this.useZip64_ == global::ICSharpCode.SharpZipLib.Zip.UseZip64.On || (entry.Size < 0L && this.useZip64_ == global::ICSharpCode.SharpZipLib.Zip.UseZip64.Dynamic))
			{
				entry.ForceZip64();
			}
			this.WriteLeInt(67324752);
			this.WriteLeShort(entry.Version);
			this.WriteLeShort(entry.Flags);
			this.WriteLeShort((int)((byte)compressionMethod));
			this.WriteLeInt((int)entry.DosTime);
			if (flag)
			{
				this.WriteLeInt((int)entry.Crc);
				if (entry.LocalHeaderRequiresZip64)
				{
					this.WriteLeInt(-1);
					this.WriteLeInt(-1);
				}
				else
				{
					this.WriteLeInt(entry.IsCrypted ? ((int)entry.CompressedSize + 12) : ((int)entry.CompressedSize));
					this.WriteLeInt((int)entry.Size);
				}
			}
			else
			{
				if (this.patchEntryHeader)
				{
					this.crcPatchPos = this.baseOutputStream_.Position;
				}
				this.WriteLeInt(0);
				if (this.patchEntryHeader)
				{
					this.sizePatchPos = this.baseOutputStream_.Position;
				}
				if (entry.LocalHeaderRequiresZip64 || this.patchEntryHeader)
				{
					this.WriteLeInt(-1);
					this.WriteLeInt(-1);
				}
				else
				{
					this.WriteLeInt(0);
					this.WriteLeInt(0);
				}
			}
			byte[] array = global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(entry.Flags, entry.Name);
			if (array.Length > 65535)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry name too long.");
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(entry.ExtraData);
			if (entry.LocalHeaderRequiresZip64)
			{
				zipExtraData.StartNewEntry();
				if (flag)
				{
					zipExtraData.AddLeLong(entry.Size);
					zipExtraData.AddLeLong(entry.CompressedSize);
				}
				else
				{
					zipExtraData.AddLeLong(-1L);
					zipExtraData.AddLeLong(-1L);
				}
				zipExtraData.AddNewEntry(1);
				if (!zipExtraData.Find(1))
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Internal error cant find extra data");
				}
				if (this.patchEntryHeader)
				{
					this.sizePatchPos = (long)zipExtraData.CurrentReadIndex;
				}
			}
			else
			{
				zipExtraData.Delete(1);
			}
			byte[] entryData = zipExtraData.GetEntryData();
			this.WriteLeShort(array.Length);
			this.WriteLeShort(entryData.Length);
			if (array.Length > 0)
			{
				this.baseOutputStream_.Write(array, 0, array.Length);
			}
			if (entry.LocalHeaderRequiresZip64 && this.patchEntryHeader)
			{
				this.sizePatchPos += this.baseOutputStream_.Position;
			}
			if (entryData.Length > 0)
			{
				this.baseOutputStream_.Write(entryData, 0, entryData.Length);
			}
			this.offset += (long)(30 + array.Length + entryData.Length);
			this.curEntry = entry;
			this.crc.Reset();
			if (compressionMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
			{
				this.deflater_.Reset();
				this.deflater_.SetLevel(level);
			}
			this.size = 0L;
			if (entry.IsCrypted)
			{
				if (entry.Crc < 0L)
				{
					this.WriteEncryptionHeader(entry.DosTime << 16);
					return;
				}
				this.WriteEncryptionHeader(entry.Crc);
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00017538 File Offset: 0x00016538
		public void CloseEntry()
		{
			if (this.curEntry == null)
			{
				throw new global::System.InvalidOperationException("No open entry");
			}
			long totalOut = this.size;
			if (this.curMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
			{
				if (this.size > 0L)
				{
					base.Finish();
					totalOut = this.deflater_.TotalOut;
				}
				else
				{
					this.deflater_.Reset();
				}
			}
			if (this.curEntry.Size < 0L)
			{
				this.curEntry.Size = this.size;
			}
			else if (this.curEntry.Size != this.size)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Concat(new object[]
				{
					"size was ",
					this.size,
					", but I expected ",
					this.curEntry.Size
				}));
			}
			if (this.curEntry.CompressedSize < 0L)
			{
				this.curEntry.CompressedSize = totalOut;
			}
			else if (this.curEntry.CompressedSize != totalOut)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Concat(new object[]
				{
					"compressed size was ",
					totalOut,
					", but I expected ",
					this.curEntry.CompressedSize
				}));
			}
			if (this.curEntry.Crc < 0L)
			{
				this.curEntry.Crc = this.crc.Value;
			}
			else if (this.curEntry.Crc != this.crc.Value)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Concat(new object[]
				{
					"crc was ",
					this.crc.Value,
					", but I expected ",
					this.curEntry.Crc
				}));
			}
			this.offset += totalOut;
			if (this.curEntry.IsCrypted)
			{
				this.curEntry.CompressedSize += 12L;
			}
			if (this.patchEntryHeader)
			{
				this.patchEntryHeader = false;
				long position = this.baseOutputStream_.Position;
				this.baseOutputStream_.Seek(this.crcPatchPos, global::System.IO.SeekOrigin.Begin);
				this.WriteLeInt((int)this.curEntry.Crc);
				if (this.curEntry.LocalHeaderRequiresZip64)
				{
					if (this.sizePatchPos == -1L)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry requires zip64 but this has been turned off");
					}
					this.baseOutputStream_.Seek(this.sizePatchPos, global::System.IO.SeekOrigin.Begin);
					this.WriteLeLong(this.curEntry.Size);
					this.WriteLeLong(this.curEntry.CompressedSize);
				}
				else
				{
					this.WriteLeInt((int)this.curEntry.CompressedSize);
					this.WriteLeInt((int)this.curEntry.Size);
				}
				this.baseOutputStream_.Seek(position, global::System.IO.SeekOrigin.Begin);
			}
			if ((this.curEntry.Flags & 8) != 0)
			{
				this.WriteLeInt(134695760);
				this.WriteLeInt((int)this.curEntry.Crc);
				if (this.curEntry.LocalHeaderRequiresZip64)
				{
					this.WriteLeLong(this.curEntry.CompressedSize);
					this.WriteLeLong(this.curEntry.Size);
					this.offset += 24L;
				}
				else
				{
					this.WriteLeInt((int)this.curEntry.CompressedSize);
					this.WriteLeInt((int)this.curEntry.Size);
					this.offset += 16L;
				}
			}
			this.entries.Add(this.curEntry);
			this.curEntry = null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000178C0 File Offset: 0x000168C0
		private void WriteEncryptionHeader(long crcValue)
		{
			this.offset += 12L;
			base.InitializePassword(base.Password);
			byte[] array = new byte[12];
			global::System.Random random = new global::System.Random();
			random.NextBytes(array);
			array[11] = (byte)(crcValue >> 24);
			base.EncryptBlock(array, 0, array.Length);
			this.baseOutputStream_.Write(array, 0, array.Length);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00017924 File Offset: 0x00016924
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.curEntry == null)
			{
				throw new global::System.InvalidOperationException("No open entry.");
			}
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
			this.crc.Update(buffer, offset, count);
			this.size += (long)count;
			global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod = this.curMethod;
			if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
			{
				if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
				{
					return;
				}
				base.Write(buffer, offset, count);
				return;
			}
			else
			{
				if (base.Password != null)
				{
					this.CopyAndEncrypt(buffer, offset, count);
					return;
				}
				this.baseOutputStream_.Write(buffer, offset, count);
				return;
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000179E4 File Offset: 0x000169E4
		private void CopyAndEncrypt(byte[] buffer, int offset, int count)
		{
			byte[] array = new byte[4096];
			while (count > 0)
			{
				int num = (count < 4096) ? count : 4096;
				global::System.Array.Copy(buffer, offset, array, 0, num);
				base.EncryptBlock(array, 0, num);
				this.baseOutputStream_.Write(array, 0, num);
				count -= num;
				offset += num;
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00017A40 File Offset: 0x00016A40
		public override void Finish()
		{
			if (this.entries == null)
			{
				return;
			}
			if (this.curEntry != null)
			{
				this.CloseEntry();
			}
			long noOfEntries = (long)this.entries.Count;
			long num = 0L;
			foreach (object obj in this.entries)
			{
				global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)obj;
				this.WriteLeInt(33639248);
				this.WriteLeShort(45);
				this.WriteLeShort(zipEntry.Version);
				this.WriteLeShort(zipEntry.Flags);
				this.WriteLeShort((int)((short)zipEntry.CompressionMethod));
				this.WriteLeInt((int)zipEntry.DosTime);
				this.WriteLeInt((int)zipEntry.Crc);
				if (zipEntry.IsZip64Forced() || zipEntry.CompressedSize >= (long)((ulong)-1))
				{
					this.WriteLeInt(-1);
				}
				else
				{
					this.WriteLeInt((int)zipEntry.CompressedSize);
				}
				if (zipEntry.IsZip64Forced() || zipEntry.Size >= (long)((ulong)-1))
				{
					this.WriteLeInt(-1);
				}
				else
				{
					this.WriteLeInt((int)zipEntry.Size);
				}
				byte[] array = global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(zipEntry.Flags, zipEntry.Name);
				if (array.Length > 65535)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Name too long.");
				}
				global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(zipEntry.ExtraData);
				if (zipEntry.CentralHeaderRequiresZip64)
				{
					zipExtraData.StartNewEntry();
					if (zipEntry.IsZip64Forced() || zipEntry.Size >= (long)((ulong)-1))
					{
						zipExtraData.AddLeLong(zipEntry.Size);
					}
					if (zipEntry.IsZip64Forced() || zipEntry.CompressedSize >= (long)((ulong)-1))
					{
						zipExtraData.AddLeLong(zipEntry.CompressedSize);
					}
					if (zipEntry.Offset >= (long)((ulong)-1))
					{
						zipExtraData.AddLeLong(zipEntry.Offset);
					}
					zipExtraData.AddNewEntry(1);
				}
				else
				{
					zipExtraData.Delete(1);
				}
				byte[] entryData = zipExtraData.GetEntryData();
				byte[] array2 = (zipEntry.Comment != null) ? global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(zipEntry.Flags, zipEntry.Comment) : new byte[0];
				if (array2.Length > 65535)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Comment too long.");
				}
				this.WriteLeShort(array.Length);
				this.WriteLeShort(entryData.Length);
				this.WriteLeShort(array2.Length);
				this.WriteLeShort(0);
				this.WriteLeShort(0);
				if (zipEntry.ExternalFileAttributes != -1)
				{
					this.WriteLeInt(zipEntry.ExternalFileAttributes);
				}
				else if (zipEntry.IsDirectory)
				{
					this.WriteLeInt(16);
				}
				else
				{
					this.WriteLeInt(0);
				}
				if (zipEntry.Offset >= (long)((ulong)-1))
				{
					this.WriteLeInt(-1);
				}
				else
				{
					this.WriteLeInt((int)zipEntry.Offset);
				}
				if (array.Length > 0)
				{
					this.baseOutputStream_.Write(array, 0, array.Length);
				}
				if (entryData.Length > 0)
				{
					this.baseOutputStream_.Write(entryData, 0, entryData.Length);
				}
				if (array2.Length > 0)
				{
					this.baseOutputStream_.Write(array2, 0, array2.Length);
				}
				num += (long)(46 + array.Length + entryData.Length + array2.Length);
			}
			using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.baseOutputStream_))
			{
				zipHelperStream.WriteEndOfCentralDirectory(noOfEntries, num, this.offset, this.zipComment);
			}
			this.entries = null;
		}

		// Token: 0x040002E2 RID: 738
		private global::System.Collections.ArrayList entries = new global::System.Collections.ArrayList();

		// Token: 0x040002E3 RID: 739
		private global::ICSharpCode.SharpZipLib.Checksums.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksums.Crc32();

		// Token: 0x040002E4 RID: 740
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntry curEntry;

		// Token: 0x040002E5 RID: 741
		private int defaultCompressionLevel = -1;

		// Token: 0x040002E6 RID: 742
		private global::ICSharpCode.SharpZipLib.Zip.CompressionMethod curMethod = global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated;

		// Token: 0x040002E7 RID: 743
		private long size;

		// Token: 0x040002E8 RID: 744
		private long offset;

		// Token: 0x040002E9 RID: 745
		private byte[] zipComment = new byte[0];

		// Token: 0x040002EA RID: 746
		private bool patchEntryHeader;

		// Token: 0x040002EB RID: 747
		private long crcPatchPos = -1L;

		// Token: 0x040002EC RID: 748
		private long sizePatchPos = -1L;

		// Token: 0x040002ED RID: 749
		private global::ICSharpCode.SharpZipLib.Zip.UseZip64 useZip64_ = global::ICSharpCode.SharpZipLib.Zip.UseZip64.Dynamic;
	}
}
