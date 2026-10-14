using System;
using System.Collections.Generic;

namespace FDISystem
{
	// Token: 0x02000004 RID: 4
	public interface ICodeplugFDIPack : global::System.IDisposable
	{
		// Token: 0x060001CE RID: 462
		global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> GetCodeplugBlockDataSet();

		// Token: 0x060001CF RID: 463
		void WriteCodeplug(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> cpBlocks, uint codeplugSize);
	}
}
