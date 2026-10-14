using System;

namespace Motorola.Common.Communication.CommonFile
{
	// Token: 0x02000003 RID: 3
	public class CodeplugCommFileHeader
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002564 File Offset: 0x00000764
		// (set) Token: 0x06000004 RID: 4 RVA: 0x0000256C File Offset: 0x0000076C
		public global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug FullDelta { internal get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002575 File Offset: 0x00000775
		// (set) Token: 0x06000006 RID: 6 RVA: 0x0000257D File Offset: 0x0000077D
		public byte HeaderVer { internal get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002586 File Offset: 0x00000786
		// (set) Token: 0x06000008 RID: 8 RVA: 0x0000258E File Offset: 0x0000078E
		public global::Motorola.Common.Communication.CommonFile.InfoLevel Level { internal get; set; }

		// Token: 0x06000009 RID: 9 RVA: 0x00002597 File Offset: 0x00000797
		public CodeplugCommFileHeader()
		{
			this.FullDelta = global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Full;
			this.HeaderVer = 16;
			this.Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.TypeLevelChangeDisc;
		}
	}
}
