using System;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x02000010 RID: 16
	public class ScanFailureEventArgs : global::System.EventArgs
	{
		// Token: 0x06000091 RID: 145 RVA: 0x00006D77 File Offset: 0x00005D77
		public ScanFailureEventArgs(string name, global::System.Exception e)
		{
			this.name_ = name;
			this.exception_ = e;
			this.continueRunning_ = true;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00006D94 File Offset: 0x00005D94
		public string Name
		{
			get
			{
				return this.name_;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00006D9C File Offset: 0x00005D9C
		public global::System.Exception Exception
		{
			get
			{
				return this.exception_;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00006DA4 File Offset: 0x00005DA4
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00006DAC File Offset: 0x00005DAC
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

		// Token: 0x04000074 RID: 116
		private string name_;

		// Token: 0x04000075 RID: 117
		private global::System.Exception exception_;

		// Token: 0x04000076 RID: 118
		private bool continueRunning_;
	}
}
