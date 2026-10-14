using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000017 RID: 23
	public class ItemComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery>
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00002B78 File Offset: 0x00000D78
		public bool Equals(global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery x, global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery y)
		{
			return object.ReferenceEquals(x, y) || (!object.ReferenceEquals(x, null) && !object.ReferenceEquals(y, null) && (x.IshPartition == y.IshPartition && x.IshType == y.IshType) && x.IshID == y.IshID);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002BD0 File Offset: 0x00000DD0
		public int GetHashCode(global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery obj)
		{
			return obj.IshPartition.GetHashCode() ^ obj.IshType.GetHashCode() ^ obj.IshID.GetHashCode();
		}
	}
}
