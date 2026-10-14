using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000018 RID: 24
	public class ModifyItemCounterComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery>
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00002C14 File Offset: 0x00000E14
		public bool Equals(global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery x, global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery y)
		{
			return object.ReferenceEquals(x, y) || (!object.ReferenceEquals(x, null) && !object.ReferenceEquals(y, null) && (x.IshPartition == y.IshPartition && x.IshType == y.IshType && x.IshID == y.IshID && x.Counter == y.Counter) && x.IsModified == y.IsModified);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002C88 File Offset: 0x00000E88
		public int GetHashCode(global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery obj)
		{
			return obj.IshPartition.GetHashCode() ^ obj.IshType.GetHashCode() ^ obj.IshID.GetHashCode() ^ obj.Counter.GetHashCode() ^ obj.IsModified.GetHashCode();
		}
	}
}
