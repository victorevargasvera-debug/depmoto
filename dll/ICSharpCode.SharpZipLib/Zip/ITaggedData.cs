using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000056 RID: 86
	public interface ITaggedData
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600034C RID: 844
		short TagID { get; }

		// Token: 0x0600034D RID: 845
		void SetData(byte[] data, int offset, int count);

		// Token: 0x0600034E RID: 846
		byte[] GetData();
	}
}
