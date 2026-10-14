using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000051 RID: 81
	public class ZipEntry : global::System.ICloneable
	{
		// Token: 0x060002FE RID: 766 RVA: 0x000107B8 File Offset: 0x0000F7B8
		public ZipEntry(string name) : this(name, 0, 45, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000107C5 File Offset: 0x0000F7C5
		internal ZipEntry(string name, int versionRequiredToExtract) : this(name, versionRequiredToExtract, 45, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000107D4 File Offset: 0x0000F7D4
		internal ZipEntry(string name, int versionRequiredToExtract, int madeByInfo, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod method)
		{
			this.externalFileAttributes = -1;
			this.method = global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated;
			this.zipFileIndex = -1L;
			base..ctor();
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (name.Length > 65535)
			{
				throw new global::System.ArgumentException("Name is too long", "name");
			}
			if (versionRequiredToExtract != 0 && versionRequiredToExtract < 10)
			{
				throw new global::System.ArgumentOutOfRangeException("versionRequiredToExtract");
			}
			this.DateTime = global::System.DateTime.Now;
			this.name = name;
			this.versionMadeBy = (ushort)madeByInfo;
			this.versionToExtract = (ushort)versionRequiredToExtract;
			this.method = method;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00010868 File Offset: 0x0000F868
		[global::System.Obsolete("Use Clone instead")]
		public ZipEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			this.externalFileAttributes = -1;
			this.method = global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated;
			this.zipFileIndex = -1L;
			base..ctor();
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			this.known = entry.known;
			this.name = entry.name;
			this.size = entry.size;
			this.compressedSize = entry.compressedSize;
			this.crc = entry.crc;
			this.dosTime = entry.dosTime;
			this.method = entry.method;
			this.comment = entry.comment;
			this.versionToExtract = entry.versionToExtract;
			this.versionMadeBy = entry.versionMadeBy;
			this.externalFileAttributes = entry.externalFileAttributes;
			this.flags = entry.flags;
			this.zipFileIndex = entry.zipFileIndex;
			this.offset = entry.offset;
			this.forceZip64_ = entry.forceZip64_;
			if (entry.extra != null)
			{
				this.extra = new byte[entry.extra.Length];
				global::System.Array.Copy(entry.extra, 0, this.extra, 0, entry.extra.Length);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00010989 File Offset: 0x0000F989
		public bool HasCrc
		{
			get
			{
				return (byte)(this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Crc) != 0;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0001099A File Offset: 0x0000F99A
		// (set) Token: 0x06000304 RID: 772 RVA: 0x000109AA File Offset: 0x0000F9AA
		public bool IsCrypted
		{
			get
			{
				return (this.flags & 1) != 0;
			}
			set
			{
				if (value)
				{
					this.flags |= 1;
					return;
				}
				this.flags &= -2;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000305 RID: 773 RVA: 0x000109CD File Offset: 0x0000F9CD
		// (set) Token: 0x06000306 RID: 774 RVA: 0x000109E1 File Offset: 0x0000F9E1
		public bool IsUnicodeText
		{
			get
			{
				return (this.flags & 2048) != 0;
			}
			set
			{
				if (value)
				{
					this.flags |= 2048;
					return;
				}
				this.flags &= -2049;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00010A0B File Offset: 0x0000FA0B
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00010A13 File Offset: 0x0000FA13
		internal byte CryptoCheckValue
		{
			get
			{
				return this.cryptoCheckValue_;
			}
			set
			{
				this.cryptoCheckValue_ = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00010A1C File Offset: 0x0000FA1C
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00010A24 File Offset: 0x0000FA24
		public int Flags
		{
			get
			{
				return this.flags;
			}
			set
			{
				this.flags = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00010A2D File Offset: 0x0000FA2D
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00010A35 File Offset: 0x0000FA35
		public long ZipFileIndex
		{
			get
			{
				return this.zipFileIndex;
			}
			set
			{
				this.zipFileIndex = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00010A3E File Offset: 0x0000FA3E
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00010A46 File Offset: 0x0000FA46
		public long Offset
		{
			get
			{
				return this.offset;
			}
			set
			{
				this.offset = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00010A4F File Offset: 0x0000FA4F
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00010A65 File Offset: 0x0000FA65
		public int ExternalFileAttributes
		{
			get
			{
				if ((byte)(this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.ExternalAttributes) == 0)
				{
					return -1;
				}
				return this.externalFileAttributes;
			}
			set
			{
				this.externalFileAttributes = value;
				this.known |= global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.ExternalAttributes;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00010A7E File Offset: 0x0000FA7E
		public int VersionMadeBy
		{
			get
			{
				return (int)(this.versionMadeBy & 255);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00010A8C File Offset: 0x0000FA8C
		public bool IsDOSEntry
		{
			get
			{
				return this.HostSystem == 0 || this.HostSystem == 10;
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00010AA4 File Offset: 0x0000FAA4
		private bool HasDosAttributes(int attributes)
		{
			bool result = false;
			if ((byte)(this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.ExternalAttributes) != 0 && (this.HostSystem == 0 || this.HostSystem == 10) && (this.ExternalFileAttributes & attributes) == attributes)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00010ADF File Offset: 0x0000FADF
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00010AEF File Offset: 0x0000FAEF
		public int HostSystem
		{
			get
			{
				return this.versionMadeBy >> 8 & 255;
			}
			set
			{
				this.versionMadeBy &= 255;
				this.versionMadeBy |= (ushort)((value & 255) << 8);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00010B1C File Offset: 0x0000FB1C
		public int Version
		{
			get
			{
				if (this.versionToExtract != 0)
				{
					return (int)this.versionToExtract;
				}
				int result = 10;
				if (this.CentralHeaderRequiresZip64)
				{
					result = 45;
				}
				else if (global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated == this.method)
				{
					result = 20;
				}
				else if (this.IsDirectory)
				{
					result = 20;
				}
				else if (this.IsCrypted)
				{
					result = 20;
				}
				else if (this.HasDosAttributes(8))
				{
					result = 11;
				}
				return result;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00010B7D File Offset: 0x0000FB7D
		public bool CanDecompress
		{
			get
			{
				return this.Version <= 45 && (this.Version == 10 || this.Version == 11 || this.Version == 20 || this.Version == 45) && this.IsCompressionMethodSupported();
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00010BB9 File Offset: 0x0000FBB9
		public void ForceZip64()
		{
			this.forceZip64_ = true;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00010BC2 File Offset: 0x0000FBC2
		public bool IsZip64Forced()
		{
			return this.forceZip64_;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00010BCC File Offset: 0x0000FBCC
		public bool LocalHeaderRequiresZip64
		{
			get
			{
				bool flag = this.forceZip64_;
				if (!flag)
				{
					ulong num = this.compressedSize;
					if (this.versionToExtract == 0 && this.IsCrypted)
					{
						num += 12UL;
					}
					flag = ((this.size >= (ulong)-1 || num >= (ulong)-1) && (this.versionToExtract == 0 || this.versionToExtract >= 45));
				}
				return flag;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00010C2C File Offset: 0x0000FC2C
		public bool CentralHeaderRequiresZip64
		{
			get
			{
				return this.LocalHeaderRequiresZip64 || this.offset >= (long)((ulong)-1);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00010C45 File Offset: 0x0000FC45
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00010C5C File Offset: 0x0000FC5C
		public long DosTime
		{
			get
			{
				if ((byte)(this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Time) == 0)
				{
					return 0L;
				}
				return (long)((ulong)this.dosTime);
			}
			set
			{
				this.dosTime = (uint)value;
				this.known |= global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Time;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00010C78 File Offset: 0x0000FC78
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00010D1C File Offset: 0x0000FD1C
		public global::System.DateTime DateTime
		{
			get
			{
				uint second = global::System.Math.Min(59U, 2U * (this.dosTime & 31U));
				uint minute = global::System.Math.Min(59U, this.dosTime >> 5 & 63U);
				uint hour = global::System.Math.Min(23U, this.dosTime >> 11 & 31U);
				uint month = global::System.Math.Max(1U, global::System.Math.Min(12U, this.dosTime >> 21 & 15U));
				uint year = (this.dosTime >> 25 & 127U) + 1980U;
				int day = global::System.Math.Max(1, global::System.Math.Min(global::System.DateTime.DaysInMonth((int)year, (int)month), (int)(this.dosTime >> 16 & 31U)));
				return new global::System.DateTime((int)year, (int)month, day, (int)hour, (int)minute, (int)second);
			}
			set
			{
				uint num = (uint)value.Year;
				uint num2 = (uint)value.Month;
				uint num3 = (uint)value.Day;
				uint num4 = (uint)value.Hour;
				uint num5 = (uint)value.Minute;
				uint num6 = (uint)value.Second;
				if (num < 1980U)
				{
					num = 1980U;
					num2 = 1U;
					num3 = 1U;
					num4 = 0U;
					num5 = 0U;
					num6 = 0U;
				}
				else if (num > 2107U)
				{
					num = 2107U;
					num2 = 12U;
					num3 = 31U;
					num4 = 23U;
					num5 = 59U;
					num6 = 59U;
				}
				this.DosTime = (long)((ulong)((num - 1980U & 127U) << 25 | num2 << 21 | num3 << 16 | num4 << 11 | num5 << 5 | num6 >> 1));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00010DC3 File Offset: 0x0000FDC3
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00010DCB File Offset: 0x0000FDCB
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00010DE1 File Offset: 0x0000FDE1
		public long Size
		{
			get
			{
				if ((byte)(this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Size) == 0)
				{
					return -1L;
				}
				return (long)this.size;
			}
			set
			{
				this.size = (ulong)value;
				this.known |= global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Size;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00010DF9 File Offset: 0x0000FDF9
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00010E0F File Offset: 0x0000FE0F
		public long CompressedSize
		{
			get
			{
				if ((byte)(this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.CompressedSize) == 0)
				{
					return -1L;
				}
				return (long)this.compressedSize;
			}
			set
			{
				this.compressedSize = (ulong)value;
				this.known |= global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.CompressedSize;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00010E27 File Offset: 0x0000FE27
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00010E41 File Offset: 0x0000FE41
		public long Crc
		{
			get
			{
				if ((byte)(this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Crc) == 0)
				{
					return -1L;
				}
				return (long)((ulong)this.crc & (ulong)-1);
			}
			set
			{
				if (((ulong)this.crc & 18446744069414584320UL) != 0UL)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.crc = (uint)value;
				this.known |= global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Crc;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00010E7A File Offset: 0x0000FE7A
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00010E82 File Offset: 0x0000FE82
		public global::ICSharpCode.SharpZipLib.Zip.CompressionMethod CompressionMethod
		{
			get
			{
				return this.method;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.ZipEntry.IsCompressionMethodSupported(value))
				{
					throw new global::System.NotSupportedException("Compression method not supported");
				}
				this.method = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00010E9E File Offset: 0x0000FE9E
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00010EA8 File Offset: 0x0000FEA8
		public byte[] ExtraData
		{
			get
			{
				return this.extra;
			}
			set
			{
				if (value == null)
				{
					this.extra = null;
					return;
				}
				if (value.Length > 65535)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.extra = new byte[value.Length];
				global::System.Array.Copy(value, 0, this.extra, 0, value.Length);
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00010EF4 File Offset: 0x0000FEF4
		internal void ProcessExtraData(bool localHeader)
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(this.extra);
			if (zipExtraData.Find(1))
			{
				if ((this.versionToExtract & 255) < 45)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Zip64 Extended information found but version is not valid");
				}
				this.forceZip64_ = true;
				if (zipExtraData.ValueLength < 4)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Extra data extended Zip64 information length is invalid");
				}
				if (localHeader || this.size == (ulong)-1)
				{
					this.size = (ulong)zipExtraData.ReadLong();
				}
				if (localHeader || this.compressedSize == (ulong)-1)
				{
					this.compressedSize = (ulong)zipExtraData.ReadLong();
				}
				if (!localHeader && this.offset == (long)((ulong)-1))
				{
					this.offset = zipExtraData.ReadLong();
				}
			}
			else if ((this.versionToExtract & 255) >= 45 && (this.size == (ulong)-1 || this.compressedSize == (ulong)-1))
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Zip64 Extended information required but is missing.");
			}
			if (zipExtraData.Find(10))
			{
				if (zipExtraData.ValueLength < 8)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("NTFS Extra data invalid");
				}
				zipExtraData.ReadInt();
				while (zipExtraData.UnreadCount >= 4)
				{
					int num = zipExtraData.ReadShort();
					int num2 = zipExtraData.ReadShort();
					if (num == 1)
					{
						if (num2 >= 24)
						{
							long fileTime = zipExtraData.ReadLong();
							zipExtraData.ReadLong();
							zipExtraData.ReadLong();
							this.DateTime = global::System.DateTime.FromFileTime(fileTime);
							return;
						}
						return;
					}
					else
					{
						zipExtraData.Skip(num2);
					}
				}
				return;
			}
			else if (zipExtraData.Find(21589))
			{
				int valueLength = zipExtraData.ValueLength;
				int num3 = zipExtraData.ReadByte();
				if ((num3 & 1) != 0 && valueLength >= 5)
				{
					int seconds = zipExtraData.ReadInt();
					this.DateTime = (new global::System.DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new global::System.TimeSpan(0, 0, 0, seconds, 0)).ToLocalTime();
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600032C RID: 812 RVA: 0x000110A6 File Offset: 0x000100A6
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000110AE File Offset: 0x000100AE
		public string Comment
		{
			get
			{
				return this.comment;
			}
			set
			{
				if (value != null && value.Length > 65535)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "cannot exceed 65535");
				}
				this.comment = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600032E RID: 814 RVA: 0x000110D8 File Offset: 0x000100D8
		public bool IsDirectory
		{
			get
			{
				int length = this.name.Length;
				return (length > 0 && (this.name[length - 1] == '/' || this.name[length - 1] == '\\')) || this.HasDosAttributes(16);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00011126 File Offset: 0x00010126
		public bool IsFile
		{
			get
			{
				return !this.IsDirectory && !this.HasDosAttributes(8);
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0001113C File Offset: 0x0001013C
		public bool IsCompressionMethodSupported()
		{
			return global::ICSharpCode.SharpZipLib.Zip.ZipEntry.IsCompressionMethodSupported(this.CompressionMethod);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0001114C File Offset: 0x0001014C
		public object Clone()
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)base.MemberwiseClone();
			if (this.extra != null)
			{
				zipEntry.extra = new byte[this.extra.Length];
				global::System.Array.Copy(this.extra, 0, zipEntry.extra, 0, this.extra.Length);
			}
			return zipEntry;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0001119C File Offset: 0x0001019C
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000111A4 File Offset: 0x000101A4
		public static bool IsCompressionMethodSupported(global::ICSharpCode.SharpZipLib.Zip.CompressionMethod method)
		{
			return method == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated || method == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000111B0 File Offset: 0x000101B0
		public static string CleanName(string name)
		{
			if (name == null)
			{
				return string.Empty;
			}
			if (global::System.IO.Path.IsPathRooted(name))
			{
				name = name.Substring(global::System.IO.Path.GetPathRoot(name).Length);
			}
			name = name.Replace("\\", "/");
			while (name.Length > 0 && name[0] == '/')
			{
				name = name.Remove(0, 1);
			}
			return name;
		}

		// Token: 0x0400024C RID: 588
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known known;

		// Token: 0x0400024D RID: 589
		private int externalFileAttributes;

		// Token: 0x0400024E RID: 590
		private ushort versionMadeBy;

		// Token: 0x0400024F RID: 591
		private string name;

		// Token: 0x04000250 RID: 592
		private ulong size;

		// Token: 0x04000251 RID: 593
		private ulong compressedSize;

		// Token: 0x04000252 RID: 594
		private ushort versionToExtract;

		// Token: 0x04000253 RID: 595
		private uint crc;

		// Token: 0x04000254 RID: 596
		private uint dosTime;

		// Token: 0x04000255 RID: 597
		private global::ICSharpCode.SharpZipLib.Zip.CompressionMethod method;

		// Token: 0x04000256 RID: 598
		private byte[] extra;

		// Token: 0x04000257 RID: 599
		private string comment;

		// Token: 0x04000258 RID: 600
		private int flags;

		// Token: 0x04000259 RID: 601
		private long zipFileIndex;

		// Token: 0x0400025A RID: 602
		private long offset;

		// Token: 0x0400025B RID: 603
		private bool forceZip64_;

		// Token: 0x0400025C RID: 604
		private byte cryptoCheckValue_;

		// Token: 0x02000052 RID: 82
		[global::System.Flags]
		private enum Known : byte
		{
			// Token: 0x0400025E RID: 606
			None = 0,
			// Token: 0x0400025F RID: 607
			Size = 1,
			// Token: 0x04000260 RID: 608
			CompressedSize = 2,
			// Token: 0x04000261 RID: 609
			Crc = 4,
			// Token: 0x04000262 RID: 610
			Time = 8,
			// Token: 0x04000263 RID: 611
			ExternalAttributes = 16
		}
	}
}
