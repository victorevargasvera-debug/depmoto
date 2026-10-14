using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000022 RID: 34
	internal class SchemItemComparer : global::System.Collections.Generic.IComparer<global::Motorola.Common.Communication.TetraUtility.SbepSchemItem>
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00009575 File Offset: 0x00007775
		public int Compare(global::Motorola.Common.Communication.TetraUtility.SbepSchemItem x, global::Motorola.Common.Communication.TetraUtility.SbepSchemItem y)
		{
			return y.Rank - x.Rank;
		}
	}
}
