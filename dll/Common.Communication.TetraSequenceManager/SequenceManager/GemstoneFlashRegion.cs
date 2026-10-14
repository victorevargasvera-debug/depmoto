using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200000C RID: 12
	public struct GemstoneFlashRegion
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003758 File Offset: 0x00001958
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00003760 File Offset: 0x00001960
		public global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003769 File Offset: 0x00001969
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00003771 File Offset: 0x00001971
		public uint startAddr
		{
			get
			{
				return this._startAddr;
			}
			set
			{
				this._startAddr = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000377A File Offset: 0x0000197A
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00003782 File Offset: 0x00001982
		public uint endAddr
		{
			get
			{
				return this._endAddr;
			}
			set
			{
				this._endAddr = value;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000378B File Offset: 0x0000198B
		public GemstoneFlashRegion(global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType t, uint start, uint end)
		{
			this._type = t;
			this._startAddr = start;
			this._endAddr = end;
		}

		// Token: 0x0400003F RID: 63
		private global::Motorola.Common.Communication.CommonUtil.GemstoneFlashType _type;

		// Token: 0x04000040 RID: 64
		private uint _startAddr;

		// Token: 0x04000041 RID: 65
		private uint _endAddr;
	}
}
