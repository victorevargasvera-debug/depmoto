using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000057 RID: 87
	public class RawTaggedData : global::ICSharpCode.SharpZipLib.Zip.ITaggedData
	{
		// Token: 0x0600034F RID: 847 RVA: 0x000115B8 File Offset: 0x000105B8
		public RawTaggedData(short tag)
		{
			this.tag_ = tag;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000350 RID: 848 RVA: 0x000115C7 File Offset: 0x000105C7
		// (set) Token: 0x06000351 RID: 849 RVA: 0x000115CF File Offset: 0x000105CF
		public short TagID
		{
			get
			{
				return this.tag_;
			}
			set
			{
				this.tag_ = value;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000115D8 File Offset: 0x000105D8
		public void SetData(byte[] data, int offset, int count)
		{
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data");
			}
			this.data_ = new byte[count];
			global::System.Array.Copy(data, offset, this.data_, 0, count);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00011603 File Offset: 0x00010603
		public byte[] GetData()
		{
			return this.data_;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0001160B File Offset: 0x0001060B
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00011613 File Offset: 0x00010613
		public byte[] Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x04000272 RID: 626
		protected short tag_;

		// Token: 0x04000273 RID: 627
		private byte[] data_;
	}
}
