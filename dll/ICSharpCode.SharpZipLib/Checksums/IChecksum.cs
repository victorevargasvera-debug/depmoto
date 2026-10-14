using System;

namespace ICSharpCode.SharpZipLib.Checksums
{
	// Token: 0x02000009 RID: 9
	public interface IChecksum
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000069 RID: 105
		long Value { get; }

		// Token: 0x0600006A RID: 106
		void Reset();

		// Token: 0x0600006B RID: 107
		void Update(int value);

		// Token: 0x0600006C RID: 108
		void Update(byte[] buffer);

		// Token: 0x0600006D RID: 109
		void Update(byte[] buffer, int offset, int count);
	}
}
