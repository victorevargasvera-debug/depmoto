using System;
using System.Collections.Generic;

namespace CommunicationController
{
	// Token: 0x02000012 RID: 18
	public class TTSPacks
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000029A4 File Offset: 0x000019A4
		public int NumPacks
		{
			get
			{
				while (this.Packs == null)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (true)
						{
						}
						if (false)
						{
						}
						return 0;
					}
				}
				return this.Packs.Count;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000029F8 File Offset: 0x000019F8
		public TTSPacks()
		{
			this.AvailSpace = 0U;
			this.Packs = new global::System.Collections.Generic.List<global::CommunicationController.SingleTTSPack>();
		}

		// Token: 0x0400003F RID: 63
		public uint AvailSpace;

		// Token: 0x04000040 RID: 64
		public global::System.Collections.Generic.List<global::CommunicationController.SingleTTSPack> Packs;
	}
}
