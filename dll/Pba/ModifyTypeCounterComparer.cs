using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000026 RID: 38
	public class ModifyTypeCounterComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery>
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00005DB8 File Offset: 0x00003FB8
		public bool Equals(global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery x, global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery y)
		{
			return object.ReferenceEquals(x, y) || (!object.ReferenceEquals(x, null) && !object.ReferenceEquals(y, null) && (x.IshPartition == y.IshPartition && x.IshType == y.IshType && x.Counter == y.Counter) && x.IsModified == y.IsModified);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00005E20 File Offset: 0x00004020
		public int GetHashCode(global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery obj)
		{
			return obj.IshPartition.GetHashCode() ^ obj.IshType.GetHashCode() ^ obj.Counter.GetHashCode() ^ obj.IsModified.GetHashCode();
		}
	}
}
