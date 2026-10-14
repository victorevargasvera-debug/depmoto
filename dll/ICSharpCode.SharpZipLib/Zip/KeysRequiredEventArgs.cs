using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200005D RID: 93
	public class KeysRequiredEventArgs : global::System.EventArgs
	{
		// Token: 0x0600038E RID: 910 RVA: 0x0001226C File Offset: 0x0001126C
		public KeysRequiredEventArgs(string name)
		{
			this.fileName = name;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0001227B File Offset: 0x0001127B
		public KeysRequiredEventArgs(string name, byte[] keyValue)
		{
			this.fileName = name;
			this.key = keyValue;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00012291 File Offset: 0x00011291
		public string FileName
		{
			get
			{
				return this.fileName;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00012299 File Offset: 0x00011299
		// (set) Token: 0x06000392 RID: 914 RVA: 0x000122A1 File Offset: 0x000112A1
		public byte[] Key
		{
			get
			{
				return this.key;
			}
			set
			{
				this.key = value;
			}
		}

		// Token: 0x04000284 RID: 644
		private string fileName;

		// Token: 0x04000285 RID: 645
		private byte[] key;
	}
}
