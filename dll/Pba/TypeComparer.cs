using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000025 RID: 37
	public class TypeComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery>
	{
		// Token: 0x06000187 RID: 391 RVA: 0x00005D45 File Offset: 0x00003F45
		public bool Equals(global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery x, global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery y)
		{
			return object.ReferenceEquals(x, y) || (!object.ReferenceEquals(x, null) && !object.ReferenceEquals(y, null) && x.IshPartition == y.IshPartition && x.IshType == y.IshType);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00005D84 File Offset: 0x00003F84
		public int GetHashCode(global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery obj)
		{
			return obj.IshPartition.GetHashCode() ^ obj.IshType.GetHashCode();
		}
	}
}
