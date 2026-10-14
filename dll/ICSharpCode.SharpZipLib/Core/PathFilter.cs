using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200001B RID: 27
	public class PathFilter : global::ICSharpCode.SharpZipLib.Core.IScanFilter
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00007444 File Offset: 0x00006444
		public PathFilter(string filter)
		{
			this.nameFilter_ = new global::ICSharpCode.SharpZipLib.Core.NameFilter(filter);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00007458 File Offset: 0x00006458
		public virtual bool IsMatch(string name)
		{
			bool result = false;
			if (name != null)
			{
				string name2 = (name.Length > 0) ? global::System.IO.Path.GetFullPath(name) : "";
				result = this.nameFilter_.IsMatch(name2);
			}
			return result;
		}

		// Token: 0x04000082 RID: 130
		private global::ICSharpCode.SharpZipLib.Core.NameFilter nameFilter_;
	}
}
