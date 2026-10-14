using System;
using System.Collections;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x0200000C RID: 12
	internal class ValidationStringComparator
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00004C4E File Offset: 0x00002E4E
		public ValidationStringComparator(global::System.Collections.IComparer comp)
		{
			this.comparator = comp;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004C5D File Offset: 0x00002E5D
		public int Compare(string x, string y)
		{
			if (this.comparator == null)
			{
				return string.Compare(x, y, global::System.StringComparison.OrdinalIgnoreCase);
			}
			return this.comparator.Compare(x, y);
		}

		// Token: 0x0400000E RID: 14
		private global::System.Collections.IComparer comparator;
	}
}
