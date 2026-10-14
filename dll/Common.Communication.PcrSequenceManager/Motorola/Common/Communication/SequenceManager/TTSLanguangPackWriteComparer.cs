using System;
using System.Collections.Generic;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200004F RID: 79
	internal class TTSLanguangPackWriteComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>
	{
		// Token: 0x06000285 RID: 645 RVA: 0x00016B58 File Offset: 0x00014D58
		public bool Equals(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo x, global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo y)
		{
			return object.ReferenceEquals(x, y) || (x != null && y != null && (x.Name == y.Name && x.PackID == y.PackID && x.SpeakerName == y.SpeakerName) && x.MajorVersion >= y.MajorVersion && x.MinorVersion >= y.MinorVersion);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00016BF4 File Offset: 0x00014DF4
		public int GetHashCode(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo obj)
		{
			return string.Format("{0}_{1}", obj.Name, obj.PackID).GetHashCode();
		}
	}
}
