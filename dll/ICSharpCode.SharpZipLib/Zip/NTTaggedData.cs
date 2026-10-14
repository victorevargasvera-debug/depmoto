using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200005A RID: 90
	public class NTTaggedData : global::ICSharpCode.SharpZipLib.Zip.ITaggedData
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000363 RID: 867 RVA: 0x000119EF File Offset: 0x000109EF
		public short TagID
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000119F4 File Offset: 0x000109F4
		public void SetData(byte[] data, int index, int count)
		{
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(data, index, count, false))
			{
				using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(memoryStream))
				{
					zipHelperStream.ReadLEInt();
					while (zipHelperStream.Position < zipHelperStream.Length)
					{
						int num = zipHelperStream.ReadLEShort();
						int num2 = zipHelperStream.ReadLEShort();
						if (num == 1)
						{
							if (num2 >= 24)
							{
								long fileTime = zipHelperStream.ReadLELong();
								this.lastModificationTime_ = global::System.DateTime.FromFileTime(fileTime);
								long fileTime2 = zipHelperStream.ReadLELong();
								this.lastAccessTime_ = global::System.DateTime.FromFileTime(fileTime2);
								long fileTime3 = zipHelperStream.ReadLELong();
								this.createTime_ = global::System.DateTime.FromFileTime(fileTime3);
								break;
							}
							break;
						}
						else
						{
							zipHelperStream.Seek((long)num2, global::System.IO.SeekOrigin.Current);
						}
					}
				}
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00011AC0 File Offset: 0x00010AC0
		public byte[] GetData()
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(memoryStream))
				{
					zipHelperStream.IsStreamOwner = false;
					zipHelperStream.WriteLEInt(0);
					zipHelperStream.WriteLEShort(1);
					zipHelperStream.WriteLEShort(24);
					zipHelperStream.WriteLELong(this.lastModificationTime_.ToFileTime());
					zipHelperStream.WriteLELong(this.lastAccessTime_.ToFileTime());
					zipHelperStream.WriteLELong(this.createTime_.ToFileTime());
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00011B64 File Offset: 0x00010B64
		public static bool IsValidValue(global::System.DateTime value)
		{
			bool result = true;
			try
			{
				value.ToFileTimeUtc();
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00011B94 File Offset: 0x00010B94
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00011B9C File Offset: 0x00010B9C
		public global::System.DateTime LastModificationTime
		{
			get
			{
				return this.lastModificationTime_;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.NTTaggedData.IsValidValue(value))
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.lastModificationTime_ = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00011BB8 File Offset: 0x00010BB8
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00011BC0 File Offset: 0x00010BC0
		public global::System.DateTime CreateTime
		{
			get
			{
				return this.createTime_;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.NTTaggedData.IsValidValue(value))
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.createTime_ = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00011BDC File Offset: 0x00010BDC
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00011BE4 File Offset: 0x00010BE4
		public global::System.DateTime LastAccessTime
		{
			get
			{
				return this.lastAccessTime_;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.NTTaggedData.IsValidValue(value))
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.lastAccessTime_ = value;
			}
		}

		// Token: 0x0400027C RID: 636
		private global::System.DateTime lastAccessTime_ = global::System.DateTime.FromFileTime(0L);

		// Token: 0x0400027D RID: 637
		private global::System.DateTime lastModificationTime_ = global::System.DateTime.FromFileTime(0L);

		// Token: 0x0400027E RID: 638
		private global::System.DateTime createTime_ = global::System.DateTime.FromFileTime(0L);
	}
}
