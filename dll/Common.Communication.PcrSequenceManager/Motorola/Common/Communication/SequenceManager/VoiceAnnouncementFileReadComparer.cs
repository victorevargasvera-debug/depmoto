using System;
using System.Collections.Generic;
using System.IO;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000054 RID: 84
	internal class VoiceAnnouncementFileReadComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.FileItem>
	{
		// Token: 0x0600029B RID: 667 RVA: 0x00017320 File Offset: 0x00015520
		public bool Equals(global::Motorola.Common.Communication.Pba.FileItem x, global::Motorola.Common.Communication.Pba.FileItem y)
		{
			return object.ReferenceEquals(x, y) || (x != null && y != null && (x.PartionID == y.PartionID && global::System.IO.Path.GetFileName(x.FilePath) == global::System.IO.Path.GetFileName(y.FilePath)) && x.FileSize != 0);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00017398 File Offset: 0x00015598
		public int GetHashCode(global::Motorola.Common.Communication.Pba.FileItem obj)
		{
			return string.Format("{0}_{1}", global::System.IO.Path.GetFileName(obj.FilePath), obj.PartionID).GetHashCode();
		}
	}
}
