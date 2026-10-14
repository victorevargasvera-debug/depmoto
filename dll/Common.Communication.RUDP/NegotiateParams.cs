using System;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000011 RID: 17
	public class NegotiateParams
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00005CEB File Offset: 0x00003EEB
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00005CF3 File Offset: 0x00003EF3
		public int maximal_number_of_outstanding_unacknowledged_fragment
		{
			get
			{
				return this._maximal_number_of_outstanding_unacknowledged_fragment;
			}
			set
			{
				this._maximal_number_of_outstanding_unacknowledged_fragment = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00005CFC File Offset: 0x00003EFC
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00005D04 File Offset: 0x00003F04
		public int maximal_fragment_size
		{
			get
			{
				return this._maximal_fragment_size;
			}
			set
			{
				this._maximal_fragment_size = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00005D0D File Offset: 0x00003F0D
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00005D15 File Offset: 0x00003F15
		public int sequenced_delivery_mode
		{
			get
			{
				return this._sequenced_delivery_mode;
			}
			set
			{
				this._sequenced_delivery_mode = value;
			}
		}

		// Token: 0x0400007B RID: 123
		private int _maximal_number_of_outstanding_unacknowledged_fragment = 1;

		// Token: 0x0400007C RID: 124
		private int _maximal_fragment_size = 256;

		// Token: 0x0400007D RID: 125
		private int _sequenced_delivery_mode = 1;
	}
}
