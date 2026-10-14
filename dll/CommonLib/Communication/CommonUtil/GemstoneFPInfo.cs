using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000060 RID: 96
	[global::System.Serializable]
	public class GemstoneFPInfo
	{
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00007888 File Offset: 0x00005A88
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00007890 File Offset: 0x00005A90
		public global::System.Collections.Generic.List<uint> EmptySlots
		{
			get
			{
				return this._emptySlots;
			}
			set
			{
				this._emptySlots = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00007899 File Offset: 0x00005A99
		// (set) Token: 0x060002CA RID: 714 RVA: 0x000078A1 File Offset: 0x00005AA1
		public global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> RadioInfo
		{
			get
			{
				return this._radioInfo;
			}
			set
			{
				this._radioInfo = value;
			}
		}

		// Token: 0x04000351 RID: 849
		private global::System.Collections.Generic.List<uint> _emptySlots;

		// Token: 0x04000352 RID: 850
		private global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> _radioInfo;
	}
}
