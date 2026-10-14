using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200007D RID: 125
	public class TetraPnPMsgEventArgs : global::System.EventArgs
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000E85D File Offset: 0x0000CA5D
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0000E865 File Offset: 0x0000CA65
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg> MsgList
		{
			get
			{
				return this._msgList;
			}
			set
			{
				this._msgList = value;
			}
		}

		// Token: 0x040003DD RID: 989
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg> _msgList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.TetraPnPMsg>();
	}
}
