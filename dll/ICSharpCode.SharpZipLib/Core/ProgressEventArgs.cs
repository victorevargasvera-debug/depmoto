using System;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200000E RID: 14
	public class ProgressEventArgs : global::System.EventArgs
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00006CEB File Offset: 0x00005CEB
		public ProgressEventArgs(string name, long processed, long target)
		{
			this.name_ = name;
			this.processed_ = processed;
			this.target_ = target;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00006D0F File Offset: 0x00005D0F
		public string Name
		{
			get
			{
				return this.name_;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00006D17 File Offset: 0x00005D17
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00006D1F File Offset: 0x00005D1F
		public bool ContinueRunning
		{
			get
			{
				return this.continueRunning_;
			}
			set
			{
				this.continueRunning_ = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00006D28 File Offset: 0x00005D28
		public float PercentComplete
		{
			get
			{
				if (this.target_ <= 0L)
				{
					return 0f;
				}
				return (float)this.processed_ / (float)this.target_ * 100f;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00006D4F File Offset: 0x00005D4F
		public long Processed
		{
			get
			{
				return this.processed_;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00006D57 File Offset: 0x00005D57
		public long Target
		{
			get
			{
				return this.target_;
			}
		}

		// Token: 0x0400006F RID: 111
		private string name_;

		// Token: 0x04000070 RID: 112
		private long processed_;

		// Token: 0x04000071 RID: 113
		private long target_;

		// Token: 0x04000072 RID: 114
		private bool continueRunning_ = true;
	}
}
