using System;
using System.Collections.Generic;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000035 RID: 53
	internal class PcrLanguangPackWriteComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>
	{
		// Token: 0x060001AB RID: 427 RVA: 0x00010024 File Offset: 0x0000E224
		public bool Equals(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo x, global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo y)
		{
			return object.ReferenceEquals(x, y) || (x != null && y != null && (x.Name == y.Name && x.PackID == y.PackID) && x.MajorVersion >= y.MajorVersion && x.MinorVersion >= y.MinorVersion);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000100B0 File Offset: 0x0000E2B0
		public int GetHashCode(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo obj)
		{
			return string.Format("{0}_{1}", obj.Name, obj.PackID).GetHashCode();
		}
	}
}
