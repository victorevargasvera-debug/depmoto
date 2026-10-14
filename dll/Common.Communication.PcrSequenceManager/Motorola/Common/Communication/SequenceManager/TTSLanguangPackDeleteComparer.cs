using System;
using System.Collections.Generic;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200004E RID: 78
	internal class TTSLanguangPackDeleteComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>
	{
		// Token: 0x06000282 RID: 642 RVA: 0x00016A84 File Offset: 0x00014C84
		public bool Equals(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo x, global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo y)
		{
			return object.ReferenceEquals(x, y) || (x != null && y != null && (x.Name == y.Name && x.PackID == y.PackID && x.SpeakerName == y.SpeakerName) && x.MajorVersion <= y.MajorVersion && x.MinorVersion <= y.MinorVersion);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00016B20 File Offset: 0x00014D20
		public int GetHashCode(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo obj)
		{
			return string.Format("{0}_{1}", obj.Name, obj.PackID).GetHashCode();
		}
	}
}
