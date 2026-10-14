using System;
using System.Collections.Generic;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000052 RID: 82
	internal class VoiceAnnouncementFileComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.FileItem>
	{
		// Token: 0x06000291 RID: 657 RVA: 0x000170D4 File Offset: 0x000152D4
		public bool Equals(global::Motorola.Common.Communication.Pba.FileItem x, global::Motorola.Common.Communication.Pba.FileItem y)
		{
			return object.ReferenceEquals(x, y) || (x != null && y != null && (x.PartionID == y.PartionID && x.FilePath == y.FilePath) && x.FileSize == y.FileSize);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00017144 File Offset: 0x00015344
		public int GetHashCode(global::Motorola.Common.Communication.Pba.FileItem obj)
		{
			return string.Format("{0}_{1}_{2}", obj.FilePath, obj.PartionID, obj.FileSize).GetHashCode();
		}
	}
}
