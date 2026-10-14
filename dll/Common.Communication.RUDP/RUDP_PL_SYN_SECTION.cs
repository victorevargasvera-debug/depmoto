using System;
using Motorola.Common.Communication.RUDP.Helper;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200001C RID: 28
	internal class RUDP_PL_SYN_SECTION : global::Motorola.Common.Communication.RUDP.RUDPPayload
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000646D File Offset: 0x0000466D
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00006480 File Offset: 0x00004680
		public bool SDM
		{
			private get
			{
				return (this.Reserve1 & global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_PL_SYN_SDM_MASK) > 0;
			}
			set
			{
				byte reserve = this.Reserve1;
				global::Motorola.Common.Communication.RUDP.Helper.RUDPUtility.CombindFlag(ref reserve, value, global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_PL_SYN_SDM_MASK);
				this.Reserve1 = reserve;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000064A8 File Offset: 0x000046A8
		public override object[] GetObjectList()
		{
			return new object[]
			{
				this.MUACK,
				this.MSS,
				this.Reserve1,
				this.Reserve2
			};
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000064F7 File Offset: 0x000046F7
		public override void SetObjectList(object[] list)
		{
			this.MUACK = (ushort)list[0];
			this.MSS = (ushort)list[1];
			this.Reserve1 = (byte)list[2];
			this.Reserve2 = (byte)list[3];
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006539 File Offset: 0x00004739
		public void initialize_RUDP_PL_SYN_SECTION()
		{
			this.PayloadLen = global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_PL_SYN_SECTION_LEN;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00006546 File Offset: 0x00004746
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000654E File Offset: 0x0000474E
		public ushort MUACK { private get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00006557 File Offset: 0x00004757
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0000655F File Offset: 0x0000475F
		public ushort MSS { get; set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00006568 File Offset: 0x00004768
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00006570 File Offset: 0x00004770
		private byte Reserve1
		{
			get
			{
				return this._Reserve1;
			}
			set
			{
				this._Reserve1 = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00006579 File Offset: 0x00004779
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00006581 File Offset: 0x00004781
		private byte Reserve2 { get; set; }

		// Token: 0x040000CC RID: 204
		private byte _Reserve1;
	}
}
