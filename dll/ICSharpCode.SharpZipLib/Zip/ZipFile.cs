using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Encryption;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000063 RID: 99
	public class ZipFile : global::System.Collections.IEnumerable, global::System.IDisposable
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x0001232C File Offset: 0x0001132C
		private void OnKeysRequired(string fileName)
		{
			if (this.KeysRequired != null)
			{
				global::ICSharpCode.SharpZipLib.Zip.KeysRequiredEventArgs keysRequiredEventArgs = new global::ICSharpCode.SharpZipLib.Zip.KeysRequiredEventArgs(fileName, this.key);
				this.KeysRequired(this, keysRequiredEventArgs);
				this.key = keysRequiredEventArgs.Key;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00012367 File Offset: 0x00011367
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x0001236F File Offset: 0x0001136F
		private byte[] Key
		{
			get
			{
				return this.key;
			}
			set
			{
				this.key = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00012378 File Offset: 0x00011378
		public string Password
		{
			set
			{
				if (value == null || value.Length == 0)
				{
					this.key = null;
					return;
				}
				this.key = global::ICSharpCode.SharpZipLib.Encryption.PkzipClassic.GenerateKeys(global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0001239E File Offset: 0x0001139E
		private bool HaveKeys
		{
			get
			{
				return this.key != null;
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000123AC File Offset: 0x000113AC
		public ZipFile(string name)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			this.name_ = name;
			this.baseStream_ = global::System.IO.File.OpenRead(name);
			this.isStreamOwner = true;
			try
			{
				this.ReadEntries();
			}
			catch
			{
				this.DisposeInternal(true);
				throw;
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00012428 File Offset: 0x00011428
		public ZipFile(global::System.IO.FileStream file)
		{
			if (file == null)
			{
				throw new global::System.ArgumentNullException("file");
			}
			if (!file.CanSeek)
			{
				throw new global::System.ArgumentException("Stream is not seekable", "file");
			}
			this.baseStream_ = file;
			this.name_ = file.Name;
			this.isStreamOwner = true;
			try
			{
				this.ReadEntries();
			}
			catch
			{
				this.DisposeInternal(true);
				throw;
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000124BC File Offset: 0x000114BC
		public ZipFile(global::System.IO.Stream stream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			if (!stream.CanSeek)
			{
				throw new global::System.ArgumentException("Stream is not seekable", "stream");
			}
			this.baseStream_ = stream;
			this.isStreamOwner = true;
			if (this.baseStream_.Length > 0L)
			{
				try
				{
					this.ReadEntries();
					return;
				}
				catch
				{
					this.DisposeInternal(true);
					throw;
				}
			}
			this.entries_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry[0];
			this.isNewArchive_ = true;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00012564 File Offset: 0x00011564
		internal ZipFile()
		{
			this.entries_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry[0];
			this.isNewArchive_ = true;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0001259C File Offset: 0x0001159C
		~ZipFile()
		{
			this.Dispose(false);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000125CC File Offset: 0x000115CC
		public void Close()
		{
			this.DisposeInternal(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000125DC File Offset: 0x000115DC
		public static global::ICSharpCode.SharpZipLib.Zip.ZipFile Create(string fileName)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			global::System.IO.FileStream fileStream = global::System.IO.File.Create(fileName);
			return new global::ICSharpCode.SharpZipLib.Zip.ZipFile
			{
				name_ = fileName,
				baseStream_ = fileStream,
				isStreamOwner = true
			};
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0001261C File Offset: 0x0001161C
		public static global::ICSharpCode.SharpZipLib.Zip.ZipFile Create(global::System.IO.Stream outStream)
		{
			if (outStream == null)
			{
				throw new global::System.ArgumentNullException("outStream");
			}
			if (!outStream.CanWrite)
			{
				throw new global::System.ArgumentException("Stream is not writeable", "outStream");
			}
			if (!outStream.CanSeek)
			{
				throw new global::System.ArgumentException("Stream is not seekable", "outStream");
			}
			return new global::ICSharpCode.SharpZipLib.Zip.ZipFile
			{
				baseStream_ = outStream
			};
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00012675 File Offset: 0x00011675
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x0001267D File Offset: 0x0001167D
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

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00012686 File Offset: 0x00011686
		public bool IsEmbeddedArchive
		{
			get
			{
				return this.offsetOfFirstEntry > 0L;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00012692 File Offset: 0x00011692
		public bool IsNewArchive
		{
			get
			{
				return this.isNewArchive_;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0001269A File Offset: 0x0001169A
		public string ZipFileComment
		{
			get
			{
				return this.comment_;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x000126A2 File Offset: 0x000116A2
		public string Name
		{
			get
			{
				return this.name_;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x000126AA File Offset: 0x000116AA
		[global::System.Obsolete("Use the Count property instead")]
		public int Size
		{
			get
			{
				return this.entries_.Length;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x000126B4 File Offset: 0x000116B4
		public long Count
		{
			get
			{
				return (long)this.entries_.Length;
			}
		}

		// Token: 0x170000DD RID: 221
		[global::System.Runtime.CompilerServices.IndexerName("EntryByIndex")]
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry this[int index]
		{
			get
			{
				return (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)this.entries_[index].Clone();
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000126D3 File Offset: 0x000116D3
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			return new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipEntryEnumerator(this.entries_);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000126F4 File Offset: 0x000116F4
		public int FindEntry(string name, bool ignoreCase)
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			for (int i = 0; i < this.entries_.Length; i++)
			{
				if (string.Compare(name, this.entries_[i].Name, ignoreCase, global::System.Globalization.CultureInfo.InvariantCulture) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00012748 File Offset: 0x00011748
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry GetEntry(string name)
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			int num = this.FindEntry(name, true);
			if (num < 0)
			{
				return null;
			}
			return (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)this.entries_[num].Clone();
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0001278C File Offset: 0x0001178C
		public global::System.IO.Stream GetInputStream(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			long num = entry.ZipFileIndex;
			if (num < 0L || num >= (long)this.entries_.Length || this.entries_[(int)(checked((global::System.IntPtr)num))].Name != entry.Name)
			{
				num = (long)this.FindEntry(entry.Name, true);
				if (num < 0L)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry cannot be found");
				}
			}
			return this.GetInputStream(num);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00012814 File Offset: 0x00011814
		public global::System.IO.Stream GetInputStream(long entryIndex)
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			checked
			{
				long start = this.LocateEntry(this.entries_[(int)((global::System.IntPtr)entryIndex)]);
				global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod = this.entries_[(int)((global::System.IntPtr)entryIndex)].CompressionMethod;
				global::System.IO.Stream stream = new global::ICSharpCode.SharpZipLib.Zip.ZipFile.PartialInputStream(this, start, this.entries_[(int)((global::System.IntPtr)entryIndex)].CompressedSize);
				if (this.entries_[(int)((global::System.IntPtr)entryIndex)].IsCrypted)
				{
					stream = this.CreateAndInitDecryptionStream(stream, this.entries_[(int)((global::System.IntPtr)entryIndex)]);
					if (stream == null)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unable to decrypt this entry");
					}
				}
				global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod2 = compressionMethod;
				if (compressionMethod2 != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
				{
					if (compressionMethod2 != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unsupported compression method " + compressionMethod);
					}
					stream = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream(stream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater(true));
				}
				return stream;
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000128C8 File Offset: 0x000118C8
		public bool TestArchive(bool testData)
		{
			return this.TestArchive(testData, global::ICSharpCode.SharpZipLib.Zip.TestStrategy.FindFirstError, null);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000128D4 File Offset: 0x000118D4
		public bool TestArchive(bool testData, global::ICSharpCode.SharpZipLib.Zip.TestStrategy strategy, global::ICSharpCode.SharpZipLib.Zip.ZipTestResultHandler resultHandler)
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			global::ICSharpCode.SharpZipLib.Zip.TestStatus testStatus = new global::ICSharpCode.SharpZipLib.Zip.TestStatus(this);
			if (resultHandler != null)
			{
				resultHandler(testStatus, null);
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest tests = testData ? (global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest.Extract | global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest.Header) : global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest.Header;
			bool flag = true;
			try
			{
				int num = 0;
				while (flag && (long)num < this.Count)
				{
					if (resultHandler != null)
					{
						testStatus.SetEntry(this[num]);
						testStatus.SetOperation(global::ICSharpCode.SharpZipLib.Zip.TestOperation.EntryHeader);
						resultHandler(testStatus, null);
					}
					try
					{
						this.TestLocalHeader(this[num], tests);
					}
					catch (global::ICSharpCode.SharpZipLib.Zip.ZipException ex)
					{
						testStatus.AddError();
						if (resultHandler != null)
						{
							resultHandler(testStatus, string.Format("Exception during test - '{0}'", ex.Message));
						}
						if (strategy == global::ICSharpCode.SharpZipLib.Zip.TestStrategy.FindFirstError)
						{
							flag = false;
						}
					}
					if (flag && testData && this[num].IsFile)
					{
						if (resultHandler != null)
						{
							testStatus.SetOperation(global::ICSharpCode.SharpZipLib.Zip.TestOperation.EntryData);
							resultHandler(testStatus, null);
						}
						global::ICSharpCode.SharpZipLib.Checksums.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksums.Crc32();
						using (global::System.IO.Stream inputStream = this.GetInputStream(this[num]))
						{
							byte[] array = new byte[4096];
							long num2 = 0L;
							int num3;
							while ((num3 = inputStream.Read(array, 0, array.Length)) > 0)
							{
								crc.Update(array, 0, num3);
								if (resultHandler != null)
								{
									num2 += (long)num3;
									testStatus.SetBytesTested(num2);
									resultHandler(testStatus, null);
								}
							}
						}
						if (this[num].Crc != crc.Value)
						{
							testStatus.AddError();
							if (resultHandler != null)
							{
								resultHandler(testStatus, "CRC mismatch");
							}
							if (strategy == global::ICSharpCode.SharpZipLib.Zip.TestStrategy.FindFirstError)
							{
								flag = false;
							}
						}
						if ((this[num].Flags & 8) != 0)
						{
							global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.baseStream_);
							global::ICSharpCode.SharpZipLib.Zip.DescriptorData descriptorData = new global::ICSharpCode.SharpZipLib.Zip.DescriptorData();
							zipHelperStream.ReadDataDescriptor(this[num].LocalHeaderRequiresZip64, descriptorData);
							if (this[num].Crc != descriptorData.Crc)
							{
								testStatus.AddError();
							}
							if (this[num].CompressedSize != descriptorData.CompressedSize)
							{
								testStatus.AddError();
							}
							if (this[num].Size != descriptorData.Size)
							{
								testStatus.AddError();
							}
						}
					}
					if (resultHandler != null)
					{
						testStatus.SetOperation(global::ICSharpCode.SharpZipLib.Zip.TestOperation.EntryComplete);
						resultHandler(testStatus, null);
					}
					num++;
				}
				if (resultHandler != null)
				{
					testStatus.SetOperation(global::ICSharpCode.SharpZipLib.Zip.TestOperation.MiscellaneousTests);
					resultHandler(testStatus, null);
				}
			}
			catch (global::System.Exception ex2)
			{
				testStatus.AddError();
				if (resultHandler != null)
				{
					resultHandler(testStatus, string.Format("Exception during test - '{0}'", ex2.Message));
				}
			}
			if (resultHandler != null)
			{
				testStatus.SetOperation(global::ICSharpCode.SharpZipLib.Zip.TestOperation.Complete);
				testStatus.SetEntry(null);
				resultHandler(testStatus, null);
			}
			return testStatus.ErrorCount == 0;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00012B98 File Offset: 0x00011B98
		private long TestLocalHeader(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest tests)
		{
			long result;
			lock (this.baseStream_)
			{
				bool flag = (tests & global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest.Header) != (global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest)0;
				bool flag2 = (tests & global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest.Extract) != (global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest)0;
				this.baseStream_.Seek(this.offsetOfFirstEntry + entry.Offset, global::System.IO.SeekOrigin.Begin);
				if (this.ReadLEUint() != 67324752U)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Wrong local header signature @{0:X}", this.offsetOfFirstEntry + entry.Offset));
				}
				short num = (short)this.ReadLEUshort();
				short num2 = (short)this.ReadLEUshort();
				short num3 = (short)this.ReadLEUshort();
				short num4 = (short)this.ReadLEUshort();
				short num5 = (short)this.ReadLEUshort();
				uint num6 = this.ReadLEUint();
				long num7 = (long)((ulong)this.ReadLEUint());
				long num8 = (long)((ulong)this.ReadLEUint());
				int num9 = (int)this.ReadLEUshort();
				int num10 = (int)this.ReadLEUshort();
				byte[] array = new byte[num9];
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(this.baseStream_, array);
				byte[] array2 = new byte[num10];
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(this.baseStream_, array2);
				global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(array2);
				if (zipExtraData.Find(1))
				{
					if (num < 45)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Extra data contains Zip64 information but version {0}.{1} is not high enough", (int)(num / 10), (int)(num % 10)));
					}
					if ((uint)num8 != 4294967295U && (uint)num7 != 4294967295U)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry sizes not correct for Zip64");
					}
					num8 = zipExtraData.ReadLong();
					num7 = zipExtraData.ReadLong();
					if ((num2 & 8) != 0)
					{
						if (num8 != -1L && num8 != entry.Size)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Size invalid for descriptor");
						}
						if (num7 != -1L && num7 != entry.CompressedSize)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Compressed size invalid for descriptor");
						}
					}
				}
				else if (num >= 45 && ((uint)num8 == 4294967295U || (uint)num7 == 4294967295U))
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Required Zip64 extended information missing");
				}
				if (flag2 && entry.IsFile)
				{
					if (!entry.IsCompressionMethodSupported())
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Compression method not supported");
					}
					if (num > 45 || (num > 20 && num < 45))
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Version required to extract this entry not supported ({0})", num));
					}
					if ((num2 & 12384) != 0)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("The library does not support the zip version required to extract this entry");
					}
				}
				if (flag)
				{
					if (num <= 63 && num != 10 && num != 11 && num != 20 && num != 21 && num != 25 && num != 27 && num != 45 && num != 46 && num != 50 && num != 51 && num != 52 && num != 61 && num != 62 && num != 63)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Version required to extract this entry is invalid ({0})", num));
					}
					if (((int)num2 & 49168) != 0)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Reserved bit flags cannot be set.");
					}
					if ((num2 & 1) != 0 && num < 20)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Version required to extract this entry is too low for encryption ({0})", num));
					}
					if ((num2 & 64) != 0)
					{
						if ((num2 & 1) == 0)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Strong encryption flag set but encryption flag is not set");
						}
						if (num < 50)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Version required to extract this entry is too low for encryption ({0})", num));
						}
					}
					if ((num2 & 32) != 0 && num < 27)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Patched data requires higher version than ({0})", num));
					}
					if ((int)num2 != entry.Flags)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Central header/local header flags mismatch");
					}
					if (entry.CompressionMethod != (global::ICSharpCode.SharpZipLib.Zip.CompressionMethod)num3)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Central header/local header compression method mismatch");
					}
					if (entry.Version != (int)num)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Extract version mismatch");
					}
					if ((num2 & 64) != 0 && num < 62)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Strong encryption flag set but version not high enough");
					}
					if ((num2 & 8192) != 0 && (num4 != 0 || num5 != 0))
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Header masked set but date/time values non-zero");
					}
					if ((num2 & 8) == 0 && num6 != (uint)entry.Crc)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Central header/local header crc mismatch");
					}
					if (num8 == 0L && num7 == 0L && num6 != 0U)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Invalid CRC for empty entry");
					}
					if (entry.Name.Length > num9)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("File name length mismatch");
					}
					string text = global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToStringExt((int)num2, array);
					if (text != entry.Name)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Central header and local header file name mismatch");
					}
					if (entry.IsDirectory)
					{
						if (num8 > 0L)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Directory cannot have size");
						}
						if (entry.IsCrypted)
						{
							if (num7 > 14L)
							{
								throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Directory compressed size invalid");
							}
						}
						else if (num7 > 2L)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Directory compressed size invalid");
						}
					}
					if (!global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.IsValidName(text, true))
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Name is invalid");
					}
				}
				if ((num2 & 8) == 0 || num8 > 0L || num7 > 0L)
				{
					if (num8 != entry.Size)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Size mismatch between central header({0}) and local header({1})", entry.Size, num8));
					}
					if (num7 != entry.CompressedSize)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Compressed size mismatch between central header({0}) and local header({1})", entry.CompressedSize, num7));
					}
				}
				int num11 = num9 + num10;
				result = this.offsetOfFirstEntry + entry.Offset + 30L + (long)num11;
			}
			return result;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00013080 File Offset: 0x00012080
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x0001308D File Offset: 0x0001208D
		public global::ICSharpCode.SharpZipLib.Core.INameTransform NameTransform
		{
			get
			{
				return this.updateEntryFactory_.NameTransform;
			}
			set
			{
				this.updateEntryFactory_.NameTransform = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0001309B File Offset: 0x0001209B
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x000130A3 File Offset: 0x000120A3
		public global::ICSharpCode.SharpZipLib.Zip.IEntryFactory EntryFactory
		{
			get
			{
				return this.updateEntryFactory_;
			}
			set
			{
				if (value == null)
				{
					this.updateEntryFactory_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory();
					return;
				}
				this.updateEntryFactory_ = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000130BB File Offset: 0x000120BB
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000130C3 File Offset: 0x000120C3
		public int BufferSize
		{
			get
			{
				return this.bufferSize_;
			}
			set
			{
				if (value < 1024)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "cannot be below 1024");
				}
				if (this.bufferSize_ != value)
				{
					this.bufferSize_ = value;
					this.copyBuffer_ = null;
				}
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x000130F4 File Offset: 0x000120F4
		public bool IsUpdating
		{
			get
			{
				return this.updates_ != null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00013102 File Offset: 0x00012102
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x0001310A File Offset: 0x0001210A
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

		// Token: 0x060003C9 RID: 969 RVA: 0x00013114 File Offset: 0x00012114
		public void BeginUpdate(global::ICSharpCode.SharpZipLib.Zip.IArchiveStorage archiveStorage, global::ICSharpCode.SharpZipLib.Zip.IDynamicDataSource dataSource)
		{
			if (archiveStorage == null)
			{
				throw new global::System.ArgumentNullException("archiveStorage");
			}
			if (dataSource == null)
			{
				throw new global::System.ArgumentNullException("dataSource");
			}
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			if (this.IsEmbeddedArchive)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot update embedded/SFX archives");
			}
			this.archiveStorage_ = archiveStorage;
			this.updateDataSource_ = dataSource;
			this.updateIndex_ = new global::System.Collections.Hashtable();
			this.updates_ = new global::System.Collections.ArrayList(this.entries_.Length);
			foreach (global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry in this.entries_)
			{
				int num = this.updates_.Add(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(zipEntry));
				this.updateIndex_.Add(zipEntry.Name, num);
			}
			this.updateCount_ = (long)this.updates_.Count;
			this.contentsEdited_ = false;
			this.commentEdited_ = false;
			this.newComment_ = null;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000131F8 File Offset: 0x000121F8
		public void BeginUpdate(global::ICSharpCode.SharpZipLib.Zip.IArchiveStorage archiveStorage)
		{
			this.BeginUpdate(archiveStorage, new global::ICSharpCode.SharpZipLib.Zip.DynamicDiskDataSource());
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00013206 File Offset: 0x00012206
		public void BeginUpdate()
		{
			if (this.Name == null)
			{
				this.BeginUpdate(new global::ICSharpCode.SharpZipLib.Zip.MemoryArchiveStorage(), new global::ICSharpCode.SharpZipLib.Zip.DynamicDiskDataSource());
				return;
			}
			this.BeginUpdate(new global::ICSharpCode.SharpZipLib.Zip.DiskArchiveStorage(this), new global::ICSharpCode.SharpZipLib.Zip.DynamicDiskDataSource());
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00013234 File Offset: 0x00012234
		public void CommitUpdate()
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			this.CheckUpdating();
			try
			{
				this.updateIndex_.Clear();
				this.updateIndex_ = null;
				if (this.contentsEdited_)
				{
					this.RunUpdates();
				}
				else if (this.commentEdited_)
				{
					this.UpdateCommentOnly();
				}
				else if (this.entries_.Length == 0)
				{
					byte[] comment = (this.newComment_ != null) ? this.newComment_.RawComment : global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(this.comment_);
					using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.baseStream_))
					{
						zipHelperStream.WriteEndOfCentralDirectory(0L, 0L, 0L, comment);
					}
				}
			}
			finally
			{
				this.PostUpdateCleanup();
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00013304 File Offset: 0x00012304
		public void AbortUpdate()
		{
			this.PostUpdateCleanup();
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0001330C File Offset: 0x0001230C
		public void SetComment(string comment)
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			this.CheckUpdating();
			this.newComment_ = new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipString(comment);
			if (this.newComment_.RawLength > 65535)
			{
				this.newComment_ = null;
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Comment length exceeds maximum - 65535");
			}
			this.commentEdited_ = true;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0001336C File Offset: 0x0001236C
		private void AddUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update)
		{
			this.contentsEdited_ = true;
			int num = this.FindExistingUpdate(update.Entry.Name);
			if (num >= 0)
			{
				if (this.updates_[num] == null)
				{
					this.updateCount_ += 1L;
				}
				this.updates_[num] = update;
				return;
			}
			num = this.updates_.Add(update);
			this.updateCount_ += 1L;
			this.updateIndex_.Add(update.Entry.Name, num);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000133FC File Offset: 0x000123FC
		public void Add(string fileName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod, bool useUnicodeText)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			if (!global::ICSharpCode.SharpZipLib.Zip.ZipEntry.IsCompressionMethodSupported(compressionMethod))
			{
				throw new global::System.ArgumentOutOfRangeException("compressionMethod");
			}
			this.CheckUpdating();
			this.contentsEdited_ = true;
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = this.EntryFactory.MakeFileEntry(fileName);
			zipEntry.IsUnicodeText = useUnicodeText;
			zipEntry.CompressionMethod = compressionMethod;
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(fileName, zipEntry));
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00013474 File Offset: 0x00012474
		public void Add(string fileName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			if (!global::ICSharpCode.SharpZipLib.Zip.ZipEntry.IsCompressionMethodSupported(compressionMethod))
			{
				throw new global::System.ArgumentOutOfRangeException("compressionMethod");
			}
			this.CheckUpdating();
			this.contentsEdited_ = true;
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = this.EntryFactory.MakeFileEntry(fileName);
			zipEntry.CompressionMethod = compressionMethod;
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(fileName, zipEntry));
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000134D0 File Offset: 0x000124D0
		public void Add(string fileName)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			this.CheckUpdating();
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(fileName, this.EntryFactory.MakeFileEntry(fileName)));
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000134FE File Offset: 0x000124FE
		public void Add(string fileName, string entryName)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			if (entryName == null)
			{
				throw new global::System.ArgumentNullException("entryName");
			}
			this.CheckUpdating();
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(fileName, this.EntryFactory.MakeFileEntry(entryName)));
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0001353A File Offset: 0x0001253A
		public void Add(global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource, string entryName)
		{
			if (dataSource == null)
			{
				throw new global::System.ArgumentNullException("dataSource");
			}
			if (entryName == null)
			{
				throw new global::System.ArgumentNullException("entryName");
			}
			this.CheckUpdating();
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(dataSource, this.EntryFactory.MakeFileEntry(entryName, false)));
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00013578 File Offset: 0x00012578
		public void Add(global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource, string entryName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod)
		{
			if (dataSource == null)
			{
				throw new global::System.ArgumentNullException("dataSource");
			}
			if (entryName == null)
			{
				throw new global::System.ArgumentNullException("entryName");
			}
			this.CheckUpdating();
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = this.EntryFactory.MakeFileEntry(entryName, false);
			zipEntry.CompressionMethod = compressionMethod;
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(dataSource, zipEntry));
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000135CC File Offset: 0x000125CC
		public void Add(global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource, string entryName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod, bool useUnicodeText)
		{
			if (dataSource == null)
			{
				throw new global::System.ArgumentNullException("dataSource");
			}
			if (entryName == null)
			{
				throw new global::System.ArgumentNullException("entryName");
			}
			this.CheckUpdating();
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = this.EntryFactory.MakeFileEntry(entryName, false);
			zipEntry.IsUnicodeText = useUnicodeText;
			zipEntry.CompressionMethod = compressionMethod;
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(dataSource, zipEntry));
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00013628 File Offset: 0x00012628
		public void Add(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			this.CheckUpdating();
			if (entry.Size != 0L || entry.CompressedSize != 0L)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry cannot have any data");
			}
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add, entry));
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00013678 File Offset: 0x00012678
		public void AddDirectory(string directoryName)
		{
			if (directoryName == null)
			{
				throw new global::System.ArgumentNullException("directoryName");
			}
			this.CheckUpdating();
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = this.EntryFactory.MakeDirectoryEntry(directoryName);
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add, entry));
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000136B4 File Offset: 0x000126B4
		public bool Delete(string fileName)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			this.CheckUpdating();
			int num = this.FindExistingUpdate(fileName);
			if (num >= 0 && this.updates_[num] != null)
			{
				bool result = true;
				this.contentsEdited_ = true;
				this.updates_[num] = null;
				this.updateCount_ -= 1L;
				return result;
			}
			throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot find entry to delete");
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00013724 File Offset: 0x00012724
		public void Delete(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			this.CheckUpdating();
			int num = this.FindExistingUpdate(entry);
			if (num >= 0)
			{
				this.contentsEdited_ = true;
				this.updates_[num] = null;
				this.updateCount_ -= 1L;
				return;
			}
			throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot find entry to delete");
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0001377F File Offset: 0x0001277F
		private void WriteLEShort(int value)
		{
			this.baseStream_.WriteByte((byte)(value & 255));
			this.baseStream_.WriteByte((byte)(value >> 8 & 255));
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000137A9 File Offset: 0x000127A9
		private void WriteLEUshort(ushort value)
		{
			this.baseStream_.WriteByte((byte)(value & 255));
			this.baseStream_.WriteByte((byte)(value >> 8));
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000137CD File Offset: 0x000127CD
		private void WriteLEInt(int value)
		{
			this.WriteLEShort(value & 65535);
			this.WriteLEShort(value >> 16);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000137E6 File Offset: 0x000127E6
		private void WriteLEUint(uint value)
		{
			this.WriteLEUshort((ushort)(value & 65535U));
			this.WriteLEUshort((ushort)(value >> 16));
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00013801 File Offset: 0x00012801
		private void WriteLeLong(long value)
		{
			this.WriteLEInt((int)(value & (long)((ulong)-1)));
			this.WriteLEInt((int)(value >> 32));
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00013819 File Offset: 0x00012819
		private void WriteLEUlong(ulong value)
		{
			this.WriteLEUint((uint)(value & (ulong)-1));
			this.WriteLEUint((uint)(value >> 32));
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00013834 File Offset: 0x00012834
		private void WriteLocalEntryHeader(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update)
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry outEntry = update.OutEntry;
			outEntry.Offset = this.baseStream_.Position;
			if (update.Command != global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Copy)
			{
				if (outEntry.CompressionMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
				{
					if (outEntry.Size == 0L)
					{
						outEntry.CompressedSize = outEntry.Size;
						outEntry.Crc = 0L;
						outEntry.CompressionMethod = global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored;
					}
				}
				else if (outEntry.CompressionMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
				{
					outEntry.Flags &= -9;
				}
				if (this.HaveKeys)
				{
					outEntry.IsCrypted = true;
					if (outEntry.Crc < 0L)
					{
						outEntry.Flags |= 8;
					}
				}
				else
				{
					outEntry.IsCrypted = false;
				}
				switch (this.useZip64_)
				{
				case global::ICSharpCode.SharpZipLib.Zip.UseZip64.On:
					outEntry.ForceZip64();
					break;
				case global::ICSharpCode.SharpZipLib.Zip.UseZip64.Dynamic:
					if (outEntry.Size < 0L)
					{
						outEntry.ForceZip64();
					}
					break;
				}
			}
			this.WriteLEInt(67324752);
			this.WriteLEShort(outEntry.Version);
			this.WriteLEShort(outEntry.Flags);
			this.WriteLEShort((int)((byte)outEntry.CompressionMethod));
			this.WriteLEInt((int)outEntry.DosTime);
			if (!outEntry.HasCrc)
			{
				update.CrcPatchOffset = this.baseStream_.Position;
				this.WriteLEInt(0);
			}
			else
			{
				this.WriteLEInt((int)outEntry.Crc);
			}
			if (outEntry.LocalHeaderRequiresZip64)
			{
				this.WriteLEInt(-1);
				this.WriteLEInt(-1);
			}
			else
			{
				if (outEntry.CompressedSize < 0L || outEntry.Size < 0L)
				{
					update.SizePatchOffset = this.baseStream_.Position;
				}
				this.WriteLEInt((int)outEntry.CompressedSize);
				this.WriteLEInt((int)outEntry.Size);
			}
			byte[] array = global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(outEntry.Flags, outEntry.Name);
			if (array.Length > 65535)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry name too long.");
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(outEntry.ExtraData);
			if (outEntry.LocalHeaderRequiresZip64)
			{
				zipExtraData.StartNewEntry();
				zipExtraData.AddLeLong(outEntry.Size);
				zipExtraData.AddLeLong(outEntry.CompressedSize);
				zipExtraData.AddNewEntry(1);
			}
			else
			{
				zipExtraData.Delete(1);
			}
			outEntry.ExtraData = zipExtraData.GetEntryData();
			this.WriteLEShort(array.Length);
			this.WriteLEShort(outEntry.ExtraData.Length);
			if (array.Length > 0)
			{
				this.baseStream_.Write(array, 0, array.Length);
			}
			if (outEntry.LocalHeaderRequiresZip64)
			{
				if (!zipExtraData.Find(1))
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Internal error cannot find extra data");
				}
				update.SizePatchOffset = this.baseStream_.Position + (long)zipExtraData.CurrentReadIndex;
			}
			if (outEntry.ExtraData.Length > 0)
			{
				this.baseStream_.Write(outEntry.ExtraData, 0, outEntry.ExtraData.Length);
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00013AD0 File Offset: 0x00012AD0
		private int WriteCentralDirectoryHeader(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry.CompressedSize < 0L)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Attempt to write central directory entry with unknown csize");
			}
			if (entry.Size < 0L)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Attempt to write central directory entry with unknown size");
			}
			if (entry.Crc < 0L)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Attempt to write central directory entry with unknown crc");
			}
			this.WriteLEInt(33639248);
			this.WriteLEShort(45);
			this.WriteLEShort(entry.Version);
			this.WriteLEShort(entry.Flags);
			this.WriteLEShort((int)((byte)entry.CompressionMethod));
			this.WriteLEInt((int)entry.DosTime);
			this.WriteLEInt((int)entry.Crc);
			if (entry.IsZip64Forced() || entry.CompressedSize >= (long)((ulong)-1))
			{
				this.WriteLEInt(-1);
			}
			else
			{
				this.WriteLEInt((int)(entry.CompressedSize & (long)((ulong)-1)));
			}
			if (entry.IsZip64Forced() || entry.Size >= (long)((ulong)-1))
			{
				this.WriteLEInt(-1);
			}
			else
			{
				this.WriteLEInt((int)entry.Size);
			}
			byte[] array = global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(entry.Flags, entry.Name);
			if (array.Length > 65535)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry name is too long.");
			}
			this.WriteLEShort(array.Length);
			global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(entry.ExtraData);
			if (entry.CentralHeaderRequiresZip64)
			{
				zipExtraData.StartNewEntry();
				if (entry.Size >= (long)((ulong)-1) || this.useZip64_ == global::ICSharpCode.SharpZipLib.Zip.UseZip64.On)
				{
					zipExtraData.AddLeLong(entry.Size);
				}
				if (entry.CompressedSize >= (long)((ulong)-1) || this.useZip64_ == global::ICSharpCode.SharpZipLib.Zip.UseZip64.On)
				{
					zipExtraData.AddLeLong(entry.CompressedSize);
				}
				if (entry.Offset >= (long)((ulong)-1))
				{
					zipExtraData.AddLeLong(entry.Offset);
				}
				zipExtraData.AddNewEntry(1);
			}
			else
			{
				zipExtraData.Delete(1);
			}
			byte[] entryData = zipExtraData.GetEntryData();
			this.WriteLEShort(entryData.Length);
			this.WriteLEShort((entry.Comment != null) ? entry.Comment.Length : 0);
			this.WriteLEShort(0);
			this.WriteLEShort(0);
			if (entry.ExternalFileAttributes != -1)
			{
				this.WriteLEInt(entry.ExternalFileAttributes);
			}
			else if (entry.IsDirectory)
			{
				this.WriteLEUint(16U);
			}
			else
			{
				this.WriteLEUint(0U);
			}
			if (entry.Offset >= (long)((ulong)-1))
			{
				this.WriteLEUint(uint.MaxValue);
			}
			else
			{
				this.WriteLEUint((uint)((int)entry.Offset));
			}
			if (array.Length > 0)
			{
				this.baseStream_.Write(array, 0, array.Length);
			}
			if (entryData.Length > 0)
			{
				this.baseStream_.Write(entryData, 0, entryData.Length);
			}
			byte[] array2 = (entry.Comment != null) ? global::System.Text.Encoding.ASCII.GetBytes(entry.Comment) : new byte[0];
			if (array2.Length > 0)
			{
				this.baseStream_.Write(array2, 0, array2.Length);
			}
			return 46 + array.Length + entryData.Length + array2.Length;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00013D6B File Offset: 0x00012D6B
		private void PostUpdateCleanup()
		{
			if (this.archiveStorage_ != null)
			{
				this.archiveStorage_.Dispose();
				this.archiveStorage_ = null;
			}
			this.updateDataSource_ = null;
			this.updates_ = null;
			this.updateIndex_ = null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00013D9C File Offset: 0x00012D9C
		private string GetTransformedFileName(string name)
		{
			if (this.NameTransform == null)
			{
				return name;
			}
			return this.NameTransform.TransformFile(name);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00013DB4 File Offset: 0x00012DB4
		private string GetTransformedDirectoryName(string name)
		{
			if (this.NameTransform == null)
			{
				return name;
			}
			return this.NameTransform.TransformDirectory(name);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00013DCC File Offset: 0x00012DCC
		private byte[] GetBuffer()
		{
			if (this.copyBuffer_ == null)
			{
				this.copyBuffer_ = new byte[this.bufferSize_];
			}
			return this.copyBuffer_;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00013DF0 File Offset: 0x00012DF0
		private void CopyDescriptorBytes(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update, global::System.IO.Stream dest, global::System.IO.Stream source)
		{
			int i = this.GetDescriptorSize(update);
			if (i > 0)
			{
				byte[] buffer = this.GetBuffer();
				while (i > 0)
				{
					int count = global::System.Math.Min(buffer.Length, i);
					int num = source.Read(buffer, 0, count);
					if (num <= 0)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unxpected end of stream");
					}
					dest.Write(buffer, 0, num);
					i -= num;
				}
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00013E48 File Offset: 0x00012E48
		private void CopyBytes(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update, global::System.IO.Stream destination, global::System.IO.Stream source, long bytesToCopy, bool updateCrc)
		{
			if (destination == source)
			{
				throw new global::System.InvalidOperationException("Destination and source are the same");
			}
			global::ICSharpCode.SharpZipLib.Checksums.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksums.Crc32();
			byte[] buffer = this.GetBuffer();
			long num = bytesToCopy;
			long num2 = 0L;
			int num4;
			do
			{
				int num3 = buffer.Length;
				if (bytesToCopy < (long)num3)
				{
					num3 = (int)bytesToCopy;
				}
				num4 = source.Read(buffer, 0, num3);
				if (num4 > 0)
				{
					if (updateCrc)
					{
						crc.Update(buffer, 0, num4);
					}
					destination.Write(buffer, 0, num4);
					bytesToCopy -= (long)num4;
					num2 += (long)num4;
				}
			}
			while (num4 > 0 && bytesToCopy > 0L);
			if (num2 != num)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Failed to copy bytes expected {0} read {1}", num, num2));
			}
			if (updateCrc)
			{
				update.OutEntry.Crc = crc.Value;
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00013F00 File Offset: 0x00012F00
		private int GetDescriptorSize(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update)
		{
			int result = 0;
			if ((update.Entry.Flags & 8) != 0)
			{
				result = 12;
				if (update.Entry.LocalHeaderRequiresZip64)
				{
					result = 20;
				}
			}
			return result;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00013F34 File Offset: 0x00012F34
		private void CopyDescriptorBytesDirect(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update, global::System.IO.Stream stream, ref long destinationPosition, long sourcePosition)
		{
			int i = this.GetDescriptorSize(update);
			while (i > 0)
			{
				int count = i;
				byte[] buffer = this.GetBuffer();
				stream.Position = sourcePosition;
				int num = stream.Read(buffer, 0, count);
				if (num <= 0)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unxpected end of stream");
				}
				stream.Position = destinationPosition;
				stream.Write(buffer, 0, num);
				i -= num;
				destinationPosition += (long)num;
				sourcePosition += (long)num;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00013FA0 File Offset: 0x00012FA0
		private void CopyEntryDataDirect(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update, global::System.IO.Stream stream, bool updateCrc, ref long destinationPosition, ref long sourcePosition)
		{
			long num = update.Entry.CompressedSize;
			global::ICSharpCode.SharpZipLib.Checksums.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksums.Crc32();
			byte[] buffer = this.GetBuffer();
			long num2 = num;
			long num3 = 0L;
			int num5;
			do
			{
				int num4 = buffer.Length;
				if (num < (long)num4)
				{
					num4 = (int)num;
				}
				stream.Position = sourcePosition;
				num5 = stream.Read(buffer, 0, num4);
				if (num5 > 0)
				{
					if (updateCrc)
					{
						crc.Update(buffer, 0, num5);
					}
					stream.Position = destinationPosition;
					stream.Write(buffer, 0, num5);
					destinationPosition += (long)num5;
					sourcePosition += (long)num5;
					num -= (long)num5;
					num3 += (long)num5;
				}
			}
			while (num5 > 0 && num > 0L);
			if (num3 != num2)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Failed to copy bytes expected {0} read {1}", num2, num3));
			}
			if (updateCrc)
			{
				update.OutEntry.Crc = crc.Value;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00014078 File Offset: 0x00013078
		private int FindExistingUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			int result = -1;
			string transformedFileName = this.GetTransformedFileName(entry.Name);
			if (this.updateIndex_.ContainsKey(transformedFileName))
			{
				result = (int)this.updateIndex_[transformedFileName];
			}
			return result;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000140B8 File Offset: 0x000130B8
		private int FindExistingUpdate(string fileName)
		{
			int result = -1;
			string transformedFileName = this.GetTransformedFileName(fileName);
			if (this.updateIndex_.ContainsKey(transformedFileName))
			{
				result = (int)this.updateIndex_[transformedFileName];
			}
			return result;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000140F0 File Offset: 0x000130F0
		private global::System.IO.Stream GetOutputStream(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			global::System.IO.Stream stream = this.baseStream_;
			if (entry.IsCrypted)
			{
				stream = this.CreateAndInitEncryptionStream(stream, entry);
			}
			global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod = entry.CompressionMethod;
			if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
			{
				if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unknown compression method " + entry.CompressionMethod);
				}
				stream = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream(stream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater(9, true))
				{
					IsStreamOwner = false
				};
			}
			else
			{
				stream = new global::ICSharpCode.SharpZipLib.Zip.ZipFile.UncompressedStream(stream);
			}
			return stream;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00014168 File Offset: 0x00013168
		private void AddEntry(global::ICSharpCode.SharpZipLib.Zip.ZipFile workFile, global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update)
		{
			global::System.IO.Stream stream = null;
			if (update.Entry.IsFile)
			{
				stream = update.GetSource();
				if (stream == null)
				{
					stream = this.updateDataSource_.GetSource(update.Entry, update.Filename);
				}
			}
			if (stream != null)
			{
				using (stream)
				{
					long length = stream.Length;
					if (update.OutEntry.Size < 0L)
					{
						update.OutEntry.Size = length;
					}
					else if (update.OutEntry.Size != length)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry size/stream size mismatch");
					}
					workFile.WriteLocalEntryHeader(update);
					long position = workFile.baseStream_.Position;
					using (global::System.IO.Stream outputStream = workFile.GetOutputStream(update.OutEntry))
					{
						this.CopyBytes(update, outputStream, stream, length, true);
					}
					long position2 = workFile.baseStream_.Position;
					update.OutEntry.CompressedSize = position2 - position;
					if ((update.OutEntry.Flags & 8) == 8)
					{
						global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(workFile.baseStream_);
						zipHelperStream.WriteDataDescriptor(update.OutEntry);
					}
					return;
				}
			}
			workFile.WriteLocalEntryHeader(update);
			update.OutEntry.CompressedSize = 0L;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000142A8 File Offset: 0x000132A8
		private void ModifyEntry(global::ICSharpCode.SharpZipLib.Zip.ZipFile workFile, global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update)
		{
			workFile.WriteLocalEntryHeader(update);
			long position = workFile.baseStream_.Position;
			if (update.Entry.IsFile && update.Filename != null)
			{
				using (global::System.IO.Stream outputStream = workFile.GetOutputStream(update.OutEntry))
				{
					using (global::System.IO.Stream inputStream = this.GetInputStream(update.Entry))
					{
						this.CopyBytes(update, outputStream, inputStream, inputStream.Length, true);
					}
				}
			}
			long position2 = workFile.baseStream_.Position;
			update.Entry.CompressedSize = position2 - position;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00014358 File Offset: 0x00013358
		private void CopyEntryDirect(global::ICSharpCode.SharpZipLib.Zip.ZipFile workFile, global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update, ref long destinationPosition)
		{
			bool flag = false;
			if (update.Entry.Offset == destinationPosition)
			{
				flag = true;
			}
			if (!flag)
			{
				this.baseStream_.Position = destinationPosition;
				workFile.WriteLocalEntryHeader(update);
				destinationPosition = this.baseStream_.Position;
			}
			long num = 0L;
			long num2 = update.Entry.Offset + 26L;
			this.baseStream_.Seek(num2, global::System.IO.SeekOrigin.Begin);
			uint num3 = (uint)this.ReadLEUshort();
			uint num4 = (uint)this.ReadLEUshort();
			num = this.baseStream_.Position + (long)((ulong)num3) + (long)((ulong)num4);
			if (flag)
			{
				destinationPosition += num - num2 + 26L + update.Entry.CompressedSize + (long)this.GetDescriptorSize(update);
				return;
			}
			if (update.Entry.CompressedSize > 0L)
			{
				this.CopyEntryDataDirect(update, this.baseStream_, false, ref destinationPosition, ref num);
			}
			this.CopyDescriptorBytesDirect(update, this.baseStream_, ref destinationPosition, num);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00014434 File Offset: 0x00013434
		private void CopyEntry(global::ICSharpCode.SharpZipLib.Zip.ZipFile workFile, global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update)
		{
			workFile.WriteLocalEntryHeader(update);
			if (update.Entry.CompressedSize > 0L)
			{
				long offset = update.Entry.Offset + 26L;
				this.baseStream_.Seek(offset, global::System.IO.SeekOrigin.Begin);
				uint num = (uint)this.ReadLEUshort();
				uint num2 = (uint)this.ReadLEUshort();
				this.baseStream_.Seek((long)((ulong)(num + num2)), global::System.IO.SeekOrigin.Current);
				this.CopyBytes(update, workFile.baseStream_, this.baseStream_, update.Entry.CompressedSize, false);
			}
			this.CopyDescriptorBytes(update, workFile.baseStream_, this.baseStream_);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000144C6 File Offset: 0x000134C6
		private void Reopen(global::System.IO.Stream source)
		{
			if (source == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Failed to reopen archive - no source");
			}
			this.isNewArchive_ = false;
			this.baseStream_ = source;
			this.ReadEntries();
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000144EA File Offset: 0x000134EA
		private void Reopen()
		{
			if (this.Name == null)
			{
				throw new global::System.InvalidOperationException("Name is not known cannot Reopen");
			}
			this.Reopen(global::System.IO.File.OpenRead(this.Name));
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00014510 File Offset: 0x00013510
		private void UpdateCommentOnly()
		{
			long length = this.baseStream_.Length;
			global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream;
			if (this.archiveStorage_.UpdateMode == global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode.Safe)
			{
				global::System.IO.Stream stream = this.archiveStorage_.MakeTemporaryCopy(this.baseStream_);
				zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(stream);
				zipHelperStream.IsStreamOwner = true;
				this.baseStream_.Close();
				this.baseStream_ = null;
			}
			else if (this.archiveStorage_.UpdateMode == global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode.Direct)
			{
				this.baseStream_ = this.archiveStorage_.OpenForDirectUpdate(this.baseStream_);
				zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.baseStream_);
			}
			else
			{
				this.baseStream_.Close();
				this.baseStream_ = null;
				zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.Name);
			}
			using (zipHelperStream)
			{
				long num = zipHelperStream.LocateBlockWithSignature(101010256, length, 22, 65535);
				if (num < 0L)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot find central directory");
				}
				zipHelperStream.Position += 16L;
				byte[] rawComment = this.newComment_.RawComment;
				zipHelperStream.WriteLEShort(rawComment.Length);
				zipHelperStream.Write(rawComment, 0, rawComment.Length);
				zipHelperStream.SetLength(zipHelperStream.Position);
			}
			if (this.archiveStorage_.UpdateMode == global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode.Safe)
			{
				this.Reopen(this.archiveStorage_.ConvertTemporaryToFinal());
				return;
			}
			this.ReadEntries();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00014668 File Offset: 0x00013668
		private void RunUpdates()
		{
			long num = 0L;
			long length = 0L;
			bool flag = true;
			bool flag2 = false;
			long position = 0L;
			global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile;
			if (this.IsNewArchive)
			{
				zipFile = this;
				zipFile.baseStream_.Position = 0L;
				flag2 = true;
			}
			else if (this.archiveStorage_.UpdateMode == global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode.Direct)
			{
				zipFile = this;
				zipFile.baseStream_.Position = 0L;
				flag2 = true;
				this.updates_.Sort(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateComparer());
			}
			else
			{
				zipFile = global::ICSharpCode.SharpZipLib.Zip.ZipFile.Create(this.archiveStorage_.GetTemporaryOutput());
				zipFile.UseZip64 = this.UseZip64;
				if (this.key != null)
				{
					zipFile.key = (byte[])this.key.Clone();
				}
			}
			try
			{
				foreach (object obj in this.updates_)
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate zipUpdate = (global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate)obj;
					if (zipUpdate != null)
					{
						switch (zipUpdate.Command)
						{
						case global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Copy:
							if (flag2)
							{
								this.CopyEntryDirect(zipFile, zipUpdate, ref position);
							}
							else
							{
								this.CopyEntry(zipFile, zipUpdate);
							}
							break;
						case global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Modify:
							this.ModifyEntry(zipFile, zipUpdate);
							break;
						case global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add:
							if (!this.IsNewArchive && flag2)
							{
								zipFile.baseStream_.Position = position;
							}
							this.AddEntry(zipFile, zipUpdate);
							if (flag2)
							{
								position = zipFile.baseStream_.Position;
							}
							break;
						}
					}
				}
				if (!this.IsNewArchive && flag2)
				{
					zipFile.baseStream_.Position = position;
				}
				long position2 = zipFile.baseStream_.Position;
				foreach (object obj2 in this.updates_)
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate zipUpdate2 = (global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate)obj2;
					if (zipUpdate2 != null)
					{
						num += (long)zipFile.WriteCentralDirectoryHeader(zipUpdate2.OutEntry);
					}
				}
				byte[] comment = (this.newComment_ != null) ? this.newComment_.RawComment : global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(this.comment_);
				using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(zipFile.baseStream_))
				{
					zipHelperStream.WriteEndOfCentralDirectory(this.updateCount_, num, position2, comment);
				}
				length = zipFile.baseStream_.Position;
				foreach (object obj3 in this.updates_)
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate zipUpdate3 = (global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate)obj3;
					if (zipUpdate3 != null)
					{
						if (zipUpdate3.CrcPatchOffset > 0L && zipUpdate3.OutEntry.CompressedSize > 0L)
						{
							zipFile.baseStream_.Position = zipUpdate3.CrcPatchOffset;
							zipFile.WriteLEInt((int)zipUpdate3.OutEntry.Crc);
						}
						if (zipUpdate3.SizePatchOffset > 0L)
						{
							zipFile.baseStream_.Position = zipUpdate3.SizePatchOffset;
							if (zipUpdate3.OutEntry.LocalHeaderRequiresZip64)
							{
								zipFile.WriteLeLong(zipUpdate3.OutEntry.Size);
								zipFile.WriteLeLong(zipUpdate3.OutEntry.CompressedSize);
							}
							else
							{
								zipFile.WriteLEInt((int)zipUpdate3.OutEntry.CompressedSize);
								zipFile.WriteLEInt((int)zipUpdate3.OutEntry.Size);
							}
						}
					}
				}
			}
			catch (global::System.Exception)
			{
				flag = false;
			}
			finally
			{
				if (flag2)
				{
					if (flag)
					{
						zipFile.baseStream_.Flush();
						zipFile.baseStream_.SetLength(length);
					}
				}
				else
				{
					zipFile.Close();
				}
			}
			if (!flag)
			{
				zipFile.Close();
				if (!flag2 && zipFile.Name != null)
				{
					global::System.IO.File.Delete(zipFile.Name);
				}
				return;
			}
			if (flag2)
			{
				this.isNewArchive_ = false;
				zipFile.baseStream_.Flush();
				this.ReadEntries();
				return;
			}
			this.baseStream_.Close();
			this.Reopen(this.archiveStorage_.ConvertTemporaryToFinal());
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00014AD4 File Offset: 0x00013AD4
		private void CheckUpdating()
		{
			if (this.updates_ == null)
			{
				throw new global::System.InvalidOperationException("BeginUpdate has not been called");
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00014AE9 File Offset: 0x00013AE9
		void global::System.IDisposable.Dispose()
		{
			this.Close();
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00014AF4 File Offset: 0x00013AF4
		private void DisposeInternal(bool disposing)
		{
			if (!this.isDisposed_)
			{
				this.isDisposed_ = true;
				this.entries_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry[0];
				if (this.IsStreamOwner && this.baseStream_ != null)
				{
					lock (this.baseStream_)
					{
						this.baseStream_.Close();
					}
				}
				this.PostUpdateCleanup();
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00014B64 File Offset: 0x00013B64
		protected virtual void Dispose(bool disposing)
		{
			this.DisposeInternal(disposing);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00014B70 File Offset: 0x00013B70
		private ushort ReadLEUshort()
		{
			int num = this.baseStream_.ReadByte();
			if (num < 0)
			{
				throw new global::System.IO.EndOfStreamException("End of stream");
			}
			int num2 = this.baseStream_.ReadByte();
			if (num2 < 0)
			{
				throw new global::System.IO.EndOfStreamException("End of stream");
			}
			return (ushort)num | (ushort)(num2 << 8);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00014BBB File Offset: 0x00013BBB
		private uint ReadLEUint()
		{
			return (uint)((int)this.ReadLEUshort() | (int)this.ReadLEUshort() << 16);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00014BCD File Offset: 0x00013BCD
		private ulong ReadLEUlong()
		{
			return (ulong)this.ReadLEUint() | (ulong)this.ReadLEUint() << 32;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00014BE4 File Offset: 0x00013BE4
		private long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
		{
			long result;
			using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.baseStream_))
			{
				result = zipHelperStream.LocateBlockWithSignature(signature, endLocation, minimumBlockSize, maximumVariableData);
			}
			return result;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00014C28 File Offset: 0x00013C28
		private void ReadEntries()
		{
			if (!this.baseStream_.CanSeek)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("ZipFile stream must be seekable");
			}
			long num = this.LocateBlockWithSignature(101010256, this.baseStream_.Length, 22, 65535);
			if (num < 0L)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot find central directory");
			}
			ushort num2 = this.ReadLEUshort();
			ushort num3 = this.ReadLEUshort();
			ulong num4 = (ulong)this.ReadLEUshort();
			ulong num5 = (ulong)this.ReadLEUshort();
			ulong num6 = (ulong)this.ReadLEUint();
			long num7 = (long)((ulong)this.ReadLEUint());
			uint num8 = (uint)this.ReadLEUshort();
			if (num8 > 0U)
			{
				byte[] array = new byte[num8];
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(this.baseStream_, array);
				this.comment_ = global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToString(array);
			}
			else
			{
				this.comment_ = string.Empty;
			}
			bool flag = false;
			if (num2 == 65535 || num3 == 65535 || num4 == 65535UL || num5 == 65535UL || num6 == (ulong)-1 || num7 == (long)((ulong)-1))
			{
				flag = true;
				long num9 = this.LocateBlockWithSignature(117853008, num, 0, 4096);
				if (num9 < 0L)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot find Zip64 locator");
				}
				this.ReadLEUint();
				ulong num10 = this.ReadLEUlong();
				this.ReadLEUint();
				this.baseStream_.Position = (long)num10;
				long num11 = (long)((ulong)this.ReadLEUint());
				if (num11 != 101075792L)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Invalid Zip64 Central directory signature at {0:X}", num10));
				}
				this.ReadLEUlong();
				this.ReadLEUshort();
				this.ReadLEUshort();
				this.ReadLEUint();
				this.ReadLEUint();
				num4 = this.ReadLEUlong();
				num5 = this.ReadLEUlong();
				num6 = this.ReadLEUlong();
				num7 = (long)this.ReadLEUlong();
			}
			this.entries_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry[num4];
			if (!flag && num7 < num - (long)(4UL + num6))
			{
				this.offsetOfFirstEntry = num - (long)(4UL + num6 + (ulong)num7);
				if (this.offsetOfFirstEntry <= 0L)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Invalid embedded zip archive");
				}
			}
			this.baseStream_.Seek(this.offsetOfFirstEntry + num7, global::System.IO.SeekOrigin.Begin);
			for (ulong num12 = 0UL; num12 < num4; num12 += 1UL)
			{
				if (this.ReadLEUint() != 33639248U)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Wrong Central Directory signature");
				}
				int madeByInfo = (int)this.ReadLEUshort();
				int versionRequiredToExtract = (int)this.ReadLEUshort();
				int num13 = (int)this.ReadLEUshort();
				int method = (int)this.ReadLEUshort();
				uint num14 = this.ReadLEUint();
				uint num15 = this.ReadLEUint();
				long num16 = (long)((ulong)this.ReadLEUint());
				long num17 = (long)((ulong)this.ReadLEUint());
				int num18 = (int)this.ReadLEUshort();
				int num19 = (int)this.ReadLEUshort();
				int num20 = (int)this.ReadLEUshort();
				this.ReadLEUshort();
				this.ReadLEUshort();
				uint externalFileAttributes = this.ReadLEUint();
				long offset = (long)((ulong)this.ReadLEUint());
				byte[] array2 = new byte[global::System.Math.Max(num18, num20)];
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(this.baseStream_, array2, 0, num18);
				string name = global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToStringExt(num13, array2, num18);
				global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(name, versionRequiredToExtract, madeByInfo, (global::ICSharpCode.SharpZipLib.Zip.CompressionMethod)method);
				zipEntry.Crc = (long)((ulong)num15 & (ulong)-1);
				zipEntry.Size = (num17 & (long)((ulong)-1));
				zipEntry.CompressedSize = (num16 & (long)((ulong)-1));
				zipEntry.Flags = num13;
				zipEntry.DosTime = (long)((ulong)num14);
				zipEntry.ZipFileIndex = (long)num12;
				zipEntry.Offset = offset;
				zipEntry.ExternalFileAttributes = (int)externalFileAttributes;
				if ((num13 & 8) == 0)
				{
					zipEntry.CryptoCheckValue = (byte)(num15 >> 24);
				}
				else
				{
					zipEntry.CryptoCheckValue = (byte)(num14 >> 8 & 255U);
				}
				if (num19 > 0)
				{
					byte[] array3 = new byte[num19];
					global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(this.baseStream_, array3);
					zipEntry.ExtraData = array3;
				}
				zipEntry.ProcessExtraData(false);
				if (num20 > 0)
				{
					global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(this.baseStream_, array2, 0, num20);
					zipEntry.Comment = global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToStringExt(num13, array2, num20);
				}
				this.entries_[(int)(checked((global::System.IntPtr)num12))] = zipEntry;
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00014FEB File Offset: 0x00013FEB
		private long LocateEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			return this.TestLocalHeader(entry, global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest.Extract);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00014FF8 File Offset: 0x00013FF8
		private global::System.IO.Stream CreateAndInitDecryptionStream(global::System.IO.Stream baseStream, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry.Version >= 50 && (entry.Flags & 64) != 0)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Decryption method not supported");
			}
			global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged pkzipClassicManaged = new global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged();
			this.OnKeysRequired(entry.Name);
			if (!this.HaveKeys)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("No password available for encrypted stream");
			}
			global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(baseStream, pkzipClassicManaged.CreateDecryptor(this.key, null), global::System.Security.Cryptography.CryptoStreamMode.Read);
			global::ICSharpCode.SharpZipLib.Zip.ZipFile.CheckClassicPassword(cryptoStream, entry);
			return cryptoStream;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0001506C File Offset: 0x0001406C
		private global::System.IO.Stream CreateAndInitEncryptionStream(global::System.IO.Stream baseStream, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			global::System.Security.Cryptography.CryptoStream cryptoStream = null;
			if (entry.Version < 50 || (entry.Flags & 64) == 0)
			{
				global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged pkzipClassicManaged = new global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged();
				this.OnKeysRequired(entry.Name);
				if (!this.HaveKeys)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("No password available for encrypted stream");
				}
				cryptoStream = new global::System.Security.Cryptography.CryptoStream(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.UncompressedStream(baseStream), pkzipClassicManaged.CreateEncryptor(this.key, null), global::System.Security.Cryptography.CryptoStreamMode.Write);
				if (entry.Crc < 0L || (entry.Flags & 8) != 0)
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipFile.WriteEncryptionHeader(cryptoStream, entry.DosTime << 16);
				}
				else
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipFile.WriteEncryptionHeader(cryptoStream, entry.Crc);
				}
			}
			return cryptoStream;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00015104 File Offset: 0x00014104
		private static void CheckClassicPassword(global::System.Security.Cryptography.CryptoStream classicCryptoStream, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			byte[] array = new byte[12];
			global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(classicCryptoStream, array);
			if (array[11] != entry.CryptoCheckValue)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Invalid password");
			}
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00015138 File Offset: 0x00014138
		private static void WriteEncryptionHeader(global::System.IO.Stream stream, long crcValue)
		{
			byte[] array = new byte[12];
			global::System.Random random = new global::System.Random();
			random.NextBytes(array);
			array[11] = (byte)(crcValue >> 24);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x04000299 RID: 665
		private const int DefaultBufferSize = 4096;

		// Token: 0x0400029A RID: 666
		public global::ICSharpCode.SharpZipLib.Zip.ZipFile.KeysRequiredEventHandler KeysRequired;

		// Token: 0x0400029B RID: 667
		private bool isDisposed_;

		// Token: 0x0400029C RID: 668
		private string name_;

		// Token: 0x0400029D RID: 669
		private string comment_;

		// Token: 0x0400029E RID: 670
		private global::System.IO.Stream baseStream_;

		// Token: 0x0400029F RID: 671
		private bool isStreamOwner;

		// Token: 0x040002A0 RID: 672
		private long offsetOfFirstEntry;

		// Token: 0x040002A1 RID: 673
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntry[] entries_;

		// Token: 0x040002A2 RID: 674
		private byte[] key;

		// Token: 0x040002A3 RID: 675
		private bool isNewArchive_;

		// Token: 0x040002A4 RID: 676
		private global::ICSharpCode.SharpZipLib.Zip.UseZip64 useZip64_ = global::ICSharpCode.SharpZipLib.Zip.UseZip64.Dynamic;

		// Token: 0x040002A5 RID: 677
		private global::System.Collections.ArrayList updates_;

		// Token: 0x040002A6 RID: 678
		private long updateCount_;

		// Token: 0x040002A7 RID: 679
		private global::System.Collections.Hashtable updateIndex_;

		// Token: 0x040002A8 RID: 680
		private global::ICSharpCode.SharpZipLib.Zip.IArchiveStorage archiveStorage_;

		// Token: 0x040002A9 RID: 681
		private global::ICSharpCode.SharpZipLib.Zip.IDynamicDataSource updateDataSource_;

		// Token: 0x040002AA RID: 682
		private bool contentsEdited_;

		// Token: 0x040002AB RID: 683
		private int bufferSize_ = 4096;

		// Token: 0x040002AC RID: 684
		private byte[] copyBuffer_;

		// Token: 0x040002AD RID: 685
		private global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipString newComment_;

		// Token: 0x040002AE RID: 686
		private bool commentEdited_;

		// Token: 0x040002AF RID: 687
		private global::ICSharpCode.SharpZipLib.Zip.IEntryFactory updateEntryFactory_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory();

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000406 RID: 1030
		public delegate void KeysRequiredEventHandler(object sender, global::ICSharpCode.SharpZipLib.Zip.KeysRequiredEventArgs e);

		// Token: 0x02000065 RID: 101
		[global::System.Flags]
		private enum HeaderTest
		{
			// Token: 0x040002B1 RID: 689
			Extract = 1,
			// Token: 0x040002B2 RID: 690
			Header = 2
		}

		// Token: 0x02000066 RID: 102
		private enum UpdateCommand
		{
			// Token: 0x040002B4 RID: 692
			Copy,
			// Token: 0x040002B5 RID: 693
			Modify,
			// Token: 0x040002B6 RID: 694
			Add
		}

		// Token: 0x02000067 RID: 103
		private class UpdateComparer : global::System.Collections.IComparer
		{
			// Token: 0x06000409 RID: 1033 RVA: 0x00015170 File Offset: 0x00014170
			public int Compare(object x, object y)
			{
				global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate zipUpdate = x as global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate;
				global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate zipUpdate2 = y as global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate;
				int num;
				if (zipUpdate == null)
				{
					if (zipUpdate2 == null)
					{
						num = 0;
					}
					else
					{
						num = -1;
					}
				}
				else if (zipUpdate2 == null)
				{
					num = 1;
				}
				else
				{
					int num2 = (zipUpdate.Command == global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Copy || zipUpdate.Command == global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Modify) ? 0 : 1;
					int num3 = (zipUpdate2.Command == global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Copy || zipUpdate2.Command == global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Modify) ? 0 : 1;
					num = num2 - num3;
					if (num == 0)
					{
						long num4 = zipUpdate.Entry.Offset - zipUpdate2.Entry.Offset;
						if (num4 < 0L)
						{
							num = -1;
						}
						else if (num4 == 0L)
						{
							num = 0;
						}
						else
						{
							num = 1;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x02000068 RID: 104
		private class ZipUpdate
		{
			// Token: 0x0600040B RID: 1035 RVA: 0x0001520D File Offset: 0x0001420D
			public ZipUpdate(string fileName, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
			{
				this.command_ = global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add;
				this.entry_ = entry;
				this.filename_ = fileName;
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x0001523A File Offset: 0x0001423A
			[global::System.Obsolete]
			public ZipUpdate(string fileName, string entryName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod)
			{
				this.command_ = global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add;
				this.entry_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(entryName);
				this.entry_.CompressionMethod = compressionMethod;
				this.filename_ = fileName;
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x00015278 File Offset: 0x00014278
			[global::System.Obsolete]
			public ZipUpdate(string fileName, string entryName) : this(fileName, entryName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
			{
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x00015283 File Offset: 0x00014283
			[global::System.Obsolete]
			public ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource, string entryName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod)
			{
				this.command_ = global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add;
				this.entry_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(entryName);
				this.entry_.CompressionMethod = compressionMethod;
				this.dataSource_ = dataSource;
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x000152C1 File Offset: 0x000142C1
			public ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
			{
				this.command_ = global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add;
				this.entry_ = entry;
				this.dataSource_ = dataSource;
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x000152EE File Offset: 0x000142EE
			public ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipEntry original, global::ICSharpCode.SharpZipLib.Zip.ZipEntry updated)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Modify not currently supported");
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x00015310 File Offset: 0x00014310
			public ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand command, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
			{
				this.command_ = command;
				this.entry_ = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)entry.Clone();
			}

			// Token: 0x06000412 RID: 1042 RVA: 0x00015340 File Offset: 0x00014340
			public ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry) : this(global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Copy, entry)
			{
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x06000413 RID: 1043 RVA: 0x0001534A File Offset: 0x0001434A
			public global::ICSharpCode.SharpZipLib.Zip.ZipEntry Entry
			{
				get
				{
					return this.entry_;
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x06000414 RID: 1044 RVA: 0x00015352 File Offset: 0x00014352
			public global::ICSharpCode.SharpZipLib.Zip.ZipEntry OutEntry
			{
				get
				{
					if (this.outEntry_ == null)
					{
						this.outEntry_ = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)this.entry_.Clone();
					}
					return this.outEntry_;
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x06000415 RID: 1045 RVA: 0x00015378 File Offset: 0x00014378
			public global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand Command
			{
				get
				{
					return this.command_;
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x06000416 RID: 1046 RVA: 0x00015380 File Offset: 0x00014380
			public string Filename
			{
				get
				{
					return this.filename_;
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x06000417 RID: 1047 RVA: 0x00015388 File Offset: 0x00014388
			// (set) Token: 0x06000418 RID: 1048 RVA: 0x00015390 File Offset: 0x00014390
			public long SizePatchOffset
			{
				get
				{
					return this.sizePatchOffset_;
				}
				set
				{
					this.sizePatchOffset_ = value;
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x06000419 RID: 1049 RVA: 0x00015399 File Offset: 0x00014399
			// (set) Token: 0x0600041A RID: 1050 RVA: 0x000153A1 File Offset: 0x000143A1
			public long CrcPatchOffset
			{
				get
				{
					return this.crcPatchOffset_;
				}
				set
				{
					this.crcPatchOffset_ = value;
				}
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x000153AC File Offset: 0x000143AC
			public global::System.IO.Stream GetSource()
			{
				global::System.IO.Stream result = null;
				if (this.dataSource_ != null)
				{
					result = this.dataSource_.GetSource();
				}
				return result;
			}

			// Token: 0x040002B7 RID: 695
			private global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry_;

			// Token: 0x040002B8 RID: 696
			private global::ICSharpCode.SharpZipLib.Zip.ZipEntry outEntry_;

			// Token: 0x040002B9 RID: 697
			private global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand command_;

			// Token: 0x040002BA RID: 698
			private global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource_;

			// Token: 0x040002BB RID: 699
			private string filename_;

			// Token: 0x040002BC RID: 700
			private long sizePatchOffset_ = -1L;

			// Token: 0x040002BD RID: 701
			private long crcPatchOffset_ = -1L;
		}

		// Token: 0x02000069 RID: 105
		private class ZipString
		{
			// Token: 0x0600041C RID: 1052 RVA: 0x000153D0 File Offset: 0x000143D0
			public ZipString(string comment)
			{
				this.comment_ = comment;
				this.isSourceString_ = true;
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x000153E6 File Offset: 0x000143E6
			public ZipString(byte[] rawString)
			{
				this.rawComment_ = rawString;
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x0600041E RID: 1054 RVA: 0x000153F5 File Offset: 0x000143F5
			public bool IsSourceString
			{
				get
				{
					return this.isSourceString_;
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x0600041F RID: 1055 RVA: 0x000153FD File Offset: 0x000143FD
			public int RawLength
			{
				get
				{
					this.MakeBytesAvailable();
					return this.rawComment_.Length;
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x06000420 RID: 1056 RVA: 0x0001540D File Offset: 0x0001440D
			public byte[] RawComment
			{
				get
				{
					this.MakeBytesAvailable();
					return (byte[])this.rawComment_.Clone();
				}
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00015425 File Offset: 0x00014425
			public void Reset()
			{
				if (this.isSourceString_)
				{
					this.rawComment_ = null;
					return;
				}
				this.comment_ = null;
			}

			// Token: 0x06000422 RID: 1058 RVA: 0x0001543E File Offset: 0x0001443E
			private void MakeTextAvailable()
			{
				if (this.comment_ == null)
				{
					this.comment_ = global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToString(this.rawComment_);
				}
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x00015459 File Offset: 0x00014459
			private void MakeBytesAvailable()
			{
				if (this.rawComment_ == null)
				{
					this.rawComment_ = global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(this.comment_);
				}
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x00015474 File Offset: 0x00014474
			public static implicit operator string(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipString zipString)
			{
				zipString.MakeTextAvailable();
				return zipString.comment_;
			}

			// Token: 0x040002BE RID: 702
			private string comment_;

			// Token: 0x040002BF RID: 703
			private byte[] rawComment_;

			// Token: 0x040002C0 RID: 704
			private bool isSourceString_;
		}

		// Token: 0x0200006A RID: 106
		private class ZipEntryEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06000425 RID: 1061 RVA: 0x00015482 File Offset: 0x00014482
			public ZipEntryEnumerator(global::ICSharpCode.SharpZipLib.Zip.ZipEntry[] entries)
			{
				this.array = entries;
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x06000426 RID: 1062 RVA: 0x00015498 File Offset: 0x00014498
			public object Current
			{
				get
				{
					return this.array[this.index];
				}
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x000154A7 File Offset: 0x000144A7
			public void Reset()
			{
				this.index = -1;
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x000154B0 File Offset: 0x000144B0
			public bool MoveNext()
			{
				return ++this.index < this.array.Length;
			}

			// Token: 0x040002C1 RID: 705
			private global::ICSharpCode.SharpZipLib.Zip.ZipEntry[] array;

			// Token: 0x040002C2 RID: 706
			private int index = -1;
		}

		// Token: 0x0200006B RID: 107
		private class UncompressedStream : global::System.IO.Stream
		{
			// Token: 0x06000429 RID: 1065 RVA: 0x000154D8 File Offset: 0x000144D8
			public UncompressedStream(global::System.IO.Stream baseStream)
			{
				this.baseStream_ = baseStream;
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x000154E7 File Offset: 0x000144E7
			public override void Close()
			{
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x0600042B RID: 1067 RVA: 0x000154E9 File Offset: 0x000144E9
			public override bool CanRead
			{
				get
				{
					return false;
				}
			}

			// Token: 0x0600042C RID: 1068 RVA: 0x000154EC File Offset: 0x000144EC
			public override void Flush()
			{
				this.baseStream_.Flush();
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x0600042D RID: 1069 RVA: 0x000154F9 File Offset: 0x000144F9
			public override bool CanWrite
			{
				get
				{
					return this.baseStream_.CanWrite;
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x0600042E RID: 1070 RVA: 0x00015506 File Offset: 0x00014506
			public override bool CanSeek
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x0600042F RID: 1071 RVA: 0x00015509 File Offset: 0x00014509
			public override long Length
			{
				get
				{
					return 0L;
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000430 RID: 1072 RVA: 0x0001550D File Offset: 0x0001450D
			// (set) Token: 0x06000431 RID: 1073 RVA: 0x0001551A File Offset: 0x0001451A
			public override long Position
			{
				get
				{
					return this.baseStream_.Position;
				}
				set
				{
				}
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x0001551C File Offset: 0x0001451C
			public override int Read(byte[] buffer, int offset, int count)
			{
				return 0;
			}

			// Token: 0x06000433 RID: 1075 RVA: 0x0001551F File Offset: 0x0001451F
			public override long Seek(long offset, global::System.IO.SeekOrigin origin)
			{
				return 0L;
			}

			// Token: 0x06000434 RID: 1076 RVA: 0x00015523 File Offset: 0x00014523
			public override void SetLength(long value)
			{
			}

			// Token: 0x06000435 RID: 1077 RVA: 0x00015525 File Offset: 0x00014525
			public override void Write(byte[] buffer, int offset, int count)
			{
				this.baseStream_.Write(buffer, offset, count);
			}

			// Token: 0x040002C3 RID: 707
			private global::System.IO.Stream baseStream_;
		}

		// Token: 0x0200006C RID: 108
		private class PartialInputStream : global::System.IO.Stream
		{
			// Token: 0x06000436 RID: 1078 RVA: 0x00015535 File Offset: 0x00014535
			public PartialInputStream(global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile, long start, long length)
			{
				this.start_ = start;
				this.length_ = length;
				this.zipFile_ = zipFile;
				this.baseStream_ = this.zipFile_.baseStream_;
				this.readPos_ = start;
				this.end_ = start + length;
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x00015574 File Offset: 0x00014574
			public override int ReadByte()
			{
				if (this.readPos_ >= this.end_)
				{
					return -1;
				}
				int result;
				lock (this.baseStream_)
				{
					global::System.IO.Stream stream = this.baseStream_;
					long offset;
					this.readPos_ = (offset = this.readPos_) + 1L;
					stream.Seek(offset, global::System.IO.SeekOrigin.Begin);
					result = this.baseStream_.ReadByte();
				}
				return result;
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x000155E4 File Offset: 0x000145E4
			public override void Close()
			{
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x000155E8 File Offset: 0x000145E8
			public override int Read(byte[] buffer, int offset, int count)
			{
				int result;
				lock (this.baseStream_)
				{
					if ((long)count > this.end_ - this.readPos_)
					{
						count = (int)(this.end_ - this.readPos_);
						if (count == 0)
						{
							return 0;
						}
					}
					this.baseStream_.Seek(this.readPos_, global::System.IO.SeekOrigin.Begin);
					int num = this.baseStream_.Read(buffer, offset, count);
					if (num > 0)
					{
						this.readPos_ += (long)num;
					}
					result = num;
				}
				return result;
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x0001567C File Offset: 0x0001467C
			public override void Write(byte[] buffer, int offset, int count)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x00015683 File Offset: 0x00014683
			public override void SetLength(long value)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x0001568C File Offset: 0x0001468C
			public override long Seek(long offset, global::System.IO.SeekOrigin origin)
			{
				long num = this.readPos_;
				switch (origin)
				{
				case global::System.IO.SeekOrigin.Begin:
					num = this.start_ + offset;
					break;
				case global::System.IO.SeekOrigin.Current:
					num = this.readPos_ + offset;
					break;
				case global::System.IO.SeekOrigin.End:
					num = this.end_ + offset;
					break;
				}
				if (num < this.start_)
				{
					throw new global::System.ArgumentException("Negative position is invalid");
				}
				if (num >= this.end_)
				{
					throw new global::System.IO.IOException("Cannot seek past end");
				}
				this.readPos_ = num;
				return this.readPos_;
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x0001570A File Offset: 0x0001470A
			public override void Flush()
			{
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x0600043E RID: 1086 RVA: 0x0001570C File Offset: 0x0001470C
			// (set) Token: 0x0600043F RID: 1087 RVA: 0x0001571C File Offset: 0x0001471C
			public override long Position
			{
				get
				{
					return this.readPos_ - this.start_;
				}
				set
				{
					long num = this.start_ + value;
					if (num < this.start_)
					{
						throw new global::System.ArgumentException("Negative position is invalid");
					}
					if (num >= this.end_)
					{
						throw new global::System.InvalidOperationException("Cannot seek past end");
					}
					this.readPos_ = num;
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x06000440 RID: 1088 RVA: 0x00015761 File Offset: 0x00014761
			public override long Length
			{
				get
				{
					return this.length_;
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x06000441 RID: 1089 RVA: 0x00015769 File Offset: 0x00014769
			public override bool CanWrite
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x0001576C File Offset: 0x0001476C
			public override bool CanSeek
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x06000443 RID: 1091 RVA: 0x0001576F File Offset: 0x0001476F
			public override bool CanRead
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000444 RID: 1092 RVA: 0x00015772 File Offset: 0x00014772
			public override bool CanTimeout
			{
				get
				{
					return this.baseStream_.CanTimeout;
				}
			}

			// Token: 0x040002C4 RID: 708
			private global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile_;

			// Token: 0x040002C5 RID: 709
			private global::System.IO.Stream baseStream_;

			// Token: 0x040002C6 RID: 710
			private long start_;

			// Token: 0x040002C7 RID: 711
			private long length_;

			// Token: 0x040002C8 RID: 712
			private long readPos_;

			// Token: 0x040002C9 RID: 713
			private long end_;
		}
	}
}
