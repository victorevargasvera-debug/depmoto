using System;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x02000018 RID: 24
	public interface INameTransform
	{
		// Token: 0x060000B9 RID: 185
		string TransformFile(string name);

		// Token: 0x060000BA RID: 186
		string TransformDirectory(string name);
	}
}
