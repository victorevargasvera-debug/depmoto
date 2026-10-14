using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200001D RID: 29
	[global::System.Obsolete("Use ExtendedPathFilter instead")]
	public class NameAndSizeFilter : global::ICSharpCode.SharpZipLib.Core.PathFilter
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00007676 File Offset: 0x00006676
		public NameAndSizeFilter(string filter, long minSize, long maxSize) : base(filter)
		{
			this.MinSize = minSize;
			this.MaxSize = maxSize;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000769C File Offset: 0x0000669C
		public override bool IsMatch(string name)
		{
			bool flag = base.IsMatch(name);
			if (flag)
			{
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(name);
				long length = fileInfo.Length;
				flag = (this.MinSize <= length && this.MaxSize >= length);
			}
			return flag;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000076DC File Offset: 0x000066DC
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000076E4 File Offset: 0x000066E4
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

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00007706 File Offset: 0x00006706
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000770E File Offset: 0x0000670E
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

		// Token: 0x04000087 RID: 135
		private long minSize_;

		// Token: 0x04000088 RID: 136
		private long maxSize_ = long.MaxValue;
	}
}
