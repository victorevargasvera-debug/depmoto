using System;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200000D RID: 13
	public class ScanEventArgs : global::System.EventArgs
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00006CBC File Offset: 0x00005CBC
		public ScanEventArgs(string name)
		{
			this.name_ = name;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00006CD2 File Offset: 0x00005CD2
		public string Name
		{
			get
			{
				return this.name_;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00006CDA File Offset: 0x00005CDA
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00006CE2 File Offset: 0x00005CE2
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

		// Token: 0x0400006D RID: 109
		private string name_;

		// Token: 0x0400006E RID: 110
		private bool continueRunning_ = true;
	}
}
