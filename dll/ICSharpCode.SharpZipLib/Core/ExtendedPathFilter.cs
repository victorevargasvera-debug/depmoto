using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200001C RID: 28
	public class ExtendedPathFilter : global::ICSharpCode.SharpZipLib.Core.PathFilter
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x0000748F File Offset: 0x0000648F
		public ExtendedPathFilter(string filter, long minSize, long maxSize) : base(filter)
		{
			this.MinSize = minSize;
			this.MaxSize = maxSize;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000074CB File Offset: 0x000064CB
		public ExtendedPathFilter(string filter, global::System.DateTime minDate, global::System.DateTime maxDate) : base(filter)
		{
			this.MinDate = minDate;
			this.MaxDate = maxDate;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00007508 File Offset: 0x00006508
		public ExtendedPathFilter(string filter, long minSize, long maxSize, global::System.DateTime minDate, global::System.DateTime maxDate) : base(filter)
		{
			this.MinSize = minSize;
			this.MaxSize = maxSize;
			this.MinDate = minDate;
			this.MaxDate = maxDate;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00007560 File Offset: 0x00006560
		public override bool IsMatch(string name)
		{
			bool flag = base.IsMatch(name);
			if (flag)
			{
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(name);
				flag = (this.MinSize <= fileInfo.Length && this.MaxSize >= fileInfo.Length && this.MinDate <= fileInfo.LastWriteTime && this.MaxDate >= fileInfo.LastWriteTime);
			}
			return flag;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000075C4 File Offset: 0x000065C4
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000075CC File Offset: 0x000065CC
		public long MinSize
		{
			get
			{
				return this.minSize_;
			}
			set
			{
				if (value < 0L || this.maxSize_ < value)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.minSize_ = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000075EE File Offset: 0x000065EE
		// (set) Token: 0x060000CE RID: 206 RVA: 0x000075F6 File Offset: 0x000065F6
		public long MaxSize
		{
			get
			{
				return this.maxSize_;
			}
			set
			{
				if (value < 0L || this.minSize_ > value)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.maxSize_ = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00007618 File Offset: 0x00006618
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00007620 File Offset: 0x00006620
		public global::System.DateTime MinDate
		{
			get
			{
				return this.minDate_;
			}
			set
			{
				if (value > this.maxDate_)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "Exceeds MaxDate");
				}
				this.minDate_ = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00007647 File Offset: 0x00006647
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000764F File Offset: 0x0000664F
		public global::System.DateTime MaxDate
		{
			get
			{
				return this.maxDate_;
			}
			set
			{
				if (this.minDate_ > value)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "Exceeds MinDate");
				}
				this.maxDate_ = value;
			}
		}

		// Token: 0x04000083 RID: 131
		private long minSize_;

		// Token: 0x04000084 RID: 132
		private long maxSize_ = long.MaxValue;

		// Token: 0x04000085 RID: 133
		private global::System.DateTime minDate_ = global::System.DateTime.MinValue;

		// Token: 0x04000086 RID: 134
		private global::System.DateTime maxDate_ = global::System.DateTime.MaxValue;
	}
}
