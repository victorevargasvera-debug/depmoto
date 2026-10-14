using System;
using System.Collections.Generic;

namespace System.Data.SQLite
{
	// Token: 0x02000032 RID: 50
	internal sealed class TypeNameStringComparer : global::System.Collections.Generic.IEqualityComparer<string>
	{
		// Token: 0x06000298 RID: 664 RVA: 0x0001A55C File Offset: 0x0001995C
		public bool Equals(string left, string right)
		{
			return string.Equals(left, right, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001A574 File Offset: 0x00019974
		public int GetHashCode(string value)
		{
			if (value != null)
			{
				return value.ToLowerInvariant().GetHashCode();
			}
			throw new global::System.ArgumentNullException("value");
		}
	}
}
