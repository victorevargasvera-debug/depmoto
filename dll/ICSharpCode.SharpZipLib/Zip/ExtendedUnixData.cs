using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000058 RID: 88
	public class ExtendedUnixData : global::ICSharpCode.SharpZipLib.Zip.ITaggedData
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0001161C File Offset: 0x0001061C
		public short TagID
		{
			get
			{
				return 21589;
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00011624 File Offset: 0x00010624
		public void SetData(byte[] data, int index, int count)
		{
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(data, index, count, false))
			{
				using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(memoryStream))
				{
					this.flags_ = (global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags)zipHelperStream.ReadByte();
					if ((byte)(this.flags_ & global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.ModificationTime) != 0 && count >= 5)
					{
						int seconds = zipHelperStream.ReadLEInt();
						this.modificationTime_ = (new global::System.DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new global::System.TimeSpan(0, 0, 0, seconds, 0)).ToLocalTime();
					}
					if ((byte)(this.flags_ & global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.AccessTime) != 0)
					{
						int seconds2 = zipHelperStream.ReadLEInt();
						this.lastAccessTime_ = (new global::System.DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new global::System.TimeSpan(0, 0, 0, seconds2, 0)).ToLocalTime();
					}
					if ((byte)(this.flags_ & global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.CreateTime) != 0)
					{
						int seconds3 = zipHelperStream.ReadLEInt();
						this.createTime_ = (new global::System.DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new global::System.TimeSpan(0, 0, 0, seconds3, 0)).ToLocalTime();
					}
				}
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0001177C File Offset: 0x0001077C
		public byte[] GetData()
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(memoryStream))
				{
					zipHelperStream.IsStreamOwner = false;
					zipHelperStream.WriteByte((byte)this.flags_);
					if ((byte)(this.flags_ & global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.ModificationTime) != 0)
					{
						int value = (int)(this.modificationTime_.ToUniversalTime() - new global::System.DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime()).TotalSeconds;
						zipHelperStream.WriteLEInt(value);
					}
					if ((byte)(this.flags_ & global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.AccessTime) != 0)
					{
						int value2 = (int)(this.lastAccessTime_.ToUniversalTime() - new global::System.DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime()).TotalSeconds;
						zipHelperStream.WriteLEInt(value2);
					}
					if ((byte)(this.flags_ & global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.CreateTime) != 0)
					{
						int value3 = (int)(this.createTime_.ToUniversalTime() - new global::System.DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime()).TotalSeconds;
						zipHelperStream.WriteLEInt(value3);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000118D0 File Offset: 0x000108D0
		public static bool IsValidValue(global::System.DateTime value)
		{
			return value >= new global::System.DateTime(1901, 12, 13, 20, 45, 52) || value <= new global::System.DateTime(2038, 1, 19, 3, 14, 7);
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00011907 File Offset: 0x00010907
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0001190F File Offset: 0x0001090F
		public global::System.DateTime ModificationTime
		{
			get
			{
				return this.modificationTime_;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.IsValidValue(value))
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.flags_ |= global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.ModificationTime;
				this.modificationTime_ = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0001193A File Offset: 0x0001093A
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00011942 File Offset: 0x00010942
		public global::System.DateTime AccessTime
		{
			get
			{
				return this.lastAccessTime_;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.IsValidValue(value))
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.flags_ |= global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.AccessTime;
				this.lastAccessTime_ = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0001196D File Offset: 0x0001096D
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00011975 File Offset: 0x00010975
		public global::System.DateTime CreateTime
		{
			get
			{
				return this.createTime_;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.IsValidValue(value))
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.flags_ |= global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.CreateTime;
				this.createTime_ = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000360 RID: 864 RVA: 0x000119A0 File Offset: 0x000109A0
		// (set) Token: 0x06000361 RID: 865 RVA: 0x000119A8 File Offset: 0x000109A8
		private global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags Include
		{
			get
			{
				return this.flags_;
			}
			set
			{
				this.flags_ = value;
			}
		}

		// Token: 0x04000274 RID: 628
		private global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags flags_;

		// Token: 0x04000275 RID: 629
		private global::System.DateTime modificationTime_ = new global::System.DateTime(1970, 1, 1);

		// Token: 0x04000276 RID: 630
		private global::System.DateTime lastAccessTime_ = new global::System.DateTime(1970, 1, 1);

		// Token: 0x04000277 RID: 631
		private global::System.DateTime createTime_ = new global::System.DateTime(1970, 1, 1);

		// Token: 0x02000059 RID: 89
		[global::System.Flags]
		public enum Flags : byte
		{
			// Token: 0x04000279 RID: 633
			ModificationTime = 1,
			// Token: 0x0400027A RID: 634
			AccessTime = 2,
			// Token: 0x0400027B RID: 635
			CreateTime = 4
		}
	}
}
