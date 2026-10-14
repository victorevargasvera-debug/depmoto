using System;
using System.Collections.Generic;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000034 RID: 52
	internal class PcrLanguangPackDeleteComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>
	{
		// Token: 0x060001A8 RID: 424 RVA: 0x0000FF60 File Offset: 0x0000E160
		public bool Equals(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo x, global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo y)
		{
			return object.ReferenceEquals(x, y) || (x != null && y != null && (x.Name == y.Name && x.PackID == y.PackID) && x.MajorVersion <= y.MajorVersion && x.MinorVersion <= y.MinorVersion);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000FFEC File Offset: 0x0000E1EC
		public int GetHashCode(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo obj)
		{
			return string.Format("{0}_{1}", obj.Name, obj.PackID).GetHashCode();
		}
	}
}
