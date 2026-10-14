using System;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200001D RID: 29
	internal class RUDP_PL_SESSION_PARAMS_SECTION : global::Motorola.Common.Communication.RUDP.RUDPPayload
	{
		// Token: 0x0600014D RID: 333 RVA: 0x0000658C File Offset: 0x0000478C
		public override object[] GetObjectList()
		{
			return new object[]
			{
				this.Max_Number_of_Retries,
				this.Time_Between_Retries,
				this.Retry_Curve_Shape,
				this.Max_Time_Between_Retries,
				this.Inactivity_Timeout,
				this.Close_Wait_Timeout
			};
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000065F8 File Offset: 0x000047F8
		public override void SetObjectList(object[] list)
		{
			this.Max_Number_of_Retries = (byte)list[0];
			this.Time_Between_Retries = (byte)list[1];
			this.Retry_Curve_Shape = (byte)list[2];
			this.Max_Time_Between_Retries = (byte)list[3];
			this.Inactivity_Timeout = (byte)list[4];
			this.Close_Wait_Timeout = (byte)list[5];
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00006661 File Offset: 0x00004861
		public void initialize_RUDP_PL_SESSION_PARAMS_SECTION()
		{
			this.PayloadLen = global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_PL_SYN_SECTION_LEN;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000666E File Offset: 0x0000486E
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00006676 File Offset: 0x00004876
		public byte Max_Number_of_Retries { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000667F File Offset: 0x0000487F
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00006687 File Offset: 0x00004887
		public byte Time_Between_Retries { get; set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00006690 File Offset: 0x00004890
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00006698 File Offset: 0x00004898
		public byte Retry_Curve_Shape { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000066A1 File Offset: 0x000048A1
		// (set) Token: 0x06000158 RID: 344 RVA: 0x000066A9 File Offset: 0x000048A9
		public byte Max_Time_Between_Retries { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000066B2 File Offset: 0x000048B2
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000066BA File Offset: 0x000048BA
		public byte Inactivity_Timeout { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000066C3 File Offset: 0x000048C3
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000066CB File Offset: 0x000048CB
		public byte Close_Wait_Timeout { get; set; }
	}
}
