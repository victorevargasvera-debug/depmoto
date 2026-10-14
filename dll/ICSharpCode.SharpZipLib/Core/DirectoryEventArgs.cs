using System;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200000F RID: 15
	public class DirectoryEventArgs : global::ICSharpCode.SharpZipLib.Core.ScanEventArgs
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00006D5F File Offset: 0x00005D5F
		public DirectoryEventArgs(string name, bool hasMatchingFiles) : base(name)
		{
			this.hasMatchingFiles_ = hasMatchingFiles;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00006D6F File Offset: 0x00005D6F
		public bool HasMatchingFiles
		{
			get
			{
				return this.hasMatchingFiles_;
			}
		}

		// Token: 0x04000073 RID: 115
		private bool hasMatchingFiles_;
	}
}
