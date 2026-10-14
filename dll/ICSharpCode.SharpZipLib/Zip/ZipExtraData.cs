using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200005C RID: 92
	public sealed class ZipExtraData : global::System.IDisposable
	{
		// Token: 0x0600036F RID: 879 RVA: 0x00011C2F File Offset: 0x00010C2F
		public ZipExtraData()
		{
			this.Clear();
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00011C3D File Offset: 0x00010C3D
		public ZipExtraData(byte[] data)
		{
			if (data == null)
			{
				this.data_ = new byte[0];
				return;
			}
			this.data_ = data;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00011C5C File Offset: 0x00010C5C
		public byte[] GetEntryData()
		{
			if (this.Length > 65535)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Data exceeds maximum length");
			}
			return (byte[])this.data_.Clone();
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00011C86 File Offset: 0x00010C86
		public void Clear()
		{
			if (this.data_ == null || this.data_.Length != 0)
			{
				this.data_ = new byte[0];
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00011CA6 File Offset: 0x00010CA6
		public int Length
		{
			get
			{
				return this.data_.Length;
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00011CB0 File Offset: 0x00010CB0
		public global::System.IO.Stream GetStreamForTag(int tag)
		{
			global::System.IO.Stream result = null;
			if (this.Find(tag))
			{
				result = new global::System.IO.MemoryStream(this.data_, this.index_, this.readValueLength_, false);
			}
			return result;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00011CE4 File Offset: 0x00010CE4
		private global::ICSharpCode.SharpZipLib.Zip.ITaggedData GetData(short tag)
		{
			global::ICSharpCode.SharpZipLib.Zip.ITaggedData result = null;
			if (this.Find((int)tag))
			{
				result = global::ICSharpCode.SharpZipLib.Zip.ZipExtraData.Create(tag, this.data_, this.readValueStart_, this.readValueLength_);
			}
			return result;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00011D18 File Offset: 0x00010D18
		private static global::ICSharpCode.SharpZipLib.Zip.ITaggedData Create(short tag, byte[] data, int offset, int count)
		{
			global::ICSharpCode.SharpZipLib.Zip.ITaggedData taggedData;
			if (tag != 10)
			{
				if (tag != 21589)
				{
					taggedData = new global::ICSharpCode.SharpZipLib.Zip.RawTaggedData(tag);
				}
				else
				{
					taggedData = new global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData();
				}
			}
			else
			{
				taggedData = new global::ICSharpCode.SharpZipLib.Zip.NTTaggedData();
			}
			taggedData.SetData(data, offset, count);
			return taggedData;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00011D59 File Offset: 0x00010D59
		public int ValueLength
		{
			get
			{
				return this.readValueLength_;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00011D61 File Offset: 0x00010D61
		public int CurrentReadIndex
		{
			get
			{
				return this.index_;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00011D69 File Offset: 0x00010D69
		public int UnreadCount
		{
			get
			{
				if (this.readValueStart_ > this.data_.Length || this.readValueStart_ < 4)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Find must be called before calling a Read method");
				}
				return this.readValueStart_ + this.readValueLength_ - this.index_;
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00011DA4 File Offset: 0x00010DA4
		public bool Find(int headerID)
		{
			this.readValueStart_ = this.data_.Length;
			this.readValueLength_ = 0;
			this.index_ = 0;
			int num = this.readValueStart_;
			int num2 = headerID - 1;
			while (num2 != headerID && this.index_ < this.data_.Length - 3)
			{
				num2 = this.ReadShortInternal();
				num = this.ReadShortInternal();
				if (num2 != headerID)
				{
					this.index_ += num;
				}
			}
			bool flag = num2 == headerID && this.index_ + num <= this.data_.Length;
			if (flag)
			{
				this.readValueStart_ = this.index_;
				this.readValueLength_ = num;
			}
			return flag;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00011E44 File Offset: 0x00010E44
		public void AddEntry(global::ICSharpCode.SharpZipLib.Zip.ITaggedData taggedData)
		{
			if (taggedData == null)
			{
				throw new global::System.ArgumentNullException("taggedData");
			}
			this.AddEntry((int)taggedData.TagID, taggedData.GetData());
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00011E68 File Offset: 0x00010E68
		public void AddEntry(int headerID, byte[] fieldData)
		{
			if (headerID > 65535 || headerID < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("headerID");
			}
			int num = (fieldData == null) ? 0 : fieldData.Length;
			if (num > 65535)
			{
				throw new global::System.ArgumentOutOfRangeException("fieldData", "exceeds maximum length");
			}
			int num2 = this.data_.Length + num + 4;
			if (this.Find(headerID))
			{
				num2 -= this.ValueLength + 4;
			}
			if (num2 > 65535)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Data exceeds maximum length");
			}
			this.Delete(headerID);
			byte[] array = new byte[num2];
			this.data_.CopyTo(array, 0);
			int index = this.data_.Length;
			this.data_ = array;
			this.SetShort(ref index, headerID);
			this.SetShort(ref index, num);
			if (fieldData != null)
			{
				fieldData.CopyTo(array, index);
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00011F2B File Offset: 0x00010F2B
		public void StartNewEntry()
		{
			this.newEntry_ = new global::System.IO.MemoryStream();
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00011F38 File Offset: 0x00010F38
		public void AddNewEntry(int headerID)
		{
			byte[] fieldData = this.newEntry_.ToArray();
			this.newEntry_ = null;
			this.AddEntry(headerID, fieldData);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00011F60 File Offset: 0x00010F60
		public void AddData(byte data)
		{
			this.newEntry_.WriteByte(data);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00011F6E File Offset: 0x00010F6E
		public void AddData(byte[] data)
		{
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data");
			}
			this.newEntry_.Write(data, 0, data.Length);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00011F8E File Offset: 0x00010F8E
		public void AddLeShort(int toAdd)
		{
			this.newEntry_.WriteByte((byte)toAdd);
			this.newEntry_.WriteByte((byte)(toAdd >> 8));
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00011FAC File Offset: 0x00010FAC
		public void AddLeInt(int toAdd)
		{
			this.AddLeShort((int)((short)toAdd));
			this.AddLeShort((int)((short)(toAdd >> 16)));
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00011FC1 File Offset: 0x00010FC1
		public void AddLeLong(long toAdd)
		{
			this.AddLeInt((int)(toAdd & (long)((ulong)-1)));
			this.AddLeInt((int)(toAdd >> 32));
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00011FDC File Offset: 0x00010FDC
		public bool Delete(int headerID)
		{
			bool result = false;
			if (this.Find(headerID))
			{
				result = true;
				int num = this.readValueStart_ - 4;
				byte[] destinationArray = new byte[this.data_.Length - (this.ValueLength + 4)];
				global::System.Array.Copy(this.data_, 0, destinationArray, 0, num);
				int num2 = num + this.ValueLength + 4;
				global::System.Array.Copy(this.data_, num2, destinationArray, num, this.data_.Length - num2);
				this.data_ = destinationArray;
			}
			return result;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00012050 File Offset: 0x00011050
		public long ReadLong()
		{
			this.ReadCheck(8);
			return ((long)this.ReadInt() & (long)((ulong)-1)) | (long)this.ReadInt() << 32;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00012070 File Offset: 0x00011070
		public int ReadInt()
		{
			this.ReadCheck(4);
			int result = (int)this.data_[this.index_] + ((int)this.data_[this.index_ + 1] << 8) + ((int)this.data_[this.index_ + 2] << 16) + ((int)this.data_[this.index_ + 3] << 24);
			this.index_ += 4;
			return result;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000120DC File Offset: 0x000110DC
		public int ReadShort()
		{
			this.ReadCheck(2);
			int result = (int)this.data_[this.index_] + ((int)this.data_[this.index_ + 1] << 8);
			this.index_ += 2;
			return result;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00012120 File Offset: 0x00011120
		public int ReadByte()
		{
			int result = -1;
			if (this.index_ < this.data_.Length && this.readValueStart_ + this.readValueLength_ > this.index_)
			{
				result = (int)this.data_[this.index_];
				this.index_++;
			}
			return result;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00012171 File Offset: 0x00011171
		public void Skip(int amount)
		{
			this.ReadCheck(amount);
			this.index_ += amount;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00012188 File Offset: 0x00011188
		private void ReadCheck(int length)
		{
			if (this.readValueStart_ > this.data_.Length || this.readValueStart_ < 4)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Find must be called before calling a Read method");
			}
			if (this.index_ > this.readValueStart_ + this.readValueLength_ - length)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("End of extra data");
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000121DC File Offset: 0x000111DC
		private int ReadShortInternal()
		{
			if (this.index_ > this.data_.Length - 2)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("End of extra data");
			}
			int result = (int)this.data_[this.index_] + ((int)this.data_[this.index_ + 1] << 8);
			this.index_ += 2;
			return result;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00012235 File Offset: 0x00011235
		private void SetShort(ref int index, int source)
		{
			this.data_[index] = (byte)source;
			this.data_[index + 1] = (byte)(source >> 8);
			index += 2;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00012257 File Offset: 0x00011257
		public void Dispose()
		{
			if (this.newEntry_ != null)
			{
				this.newEntry_.Close();
			}
		}

		// Token: 0x0400027F RID: 639
		private int index_;

		// Token: 0x04000280 RID: 640
		private int readValueStart_;

		// Token: 0x04000281 RID: 641
		private int readValueLength_;

		// Token: 0x04000282 RID: 642
		private global::System.IO.MemoryStream newEntry_;

		// Token: 0x04000283 RID: 643
		private byte[] data_;
	}
}
