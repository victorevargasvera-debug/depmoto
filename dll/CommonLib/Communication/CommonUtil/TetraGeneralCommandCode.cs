using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000052 RID: 82
	[global::System.Runtime.Serialization.DataContract]
	public enum TetraGeneralCommandCode
	{
		// Token: 0x04000251 RID: 593
		[global::System.Runtime.Serialization.EnumMember]
		Undefined,
		// Token: 0x04000252 RID: 594
		[global::System.Runtime.Serialization.EnumMember]
		RP_GET_INDICATION,
		// Token: 0x04000253 RID: 595
		[global::System.Runtime.Serialization.EnumMember]
		RP_SEND_VERSION_REPLY,
		// Token: 0x04000254 RID: 596
		[global::System.Runtime.Serialization.EnumMember]
		RP_GET_TERMINAL_ID,
		// Token: 0x04000255 RID: 597
		[global::System.Runtime.Serialization.EnumMember]
		RP_GET_VERSION_INFO,
		// Token: 0x04000256 RID: 598
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_ERASE_KEYS,
		// Token: 0x04000257 RID: 599
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_BEGIN_UPDATE_FDT,
		// Token: 0x04000258 RID: 600
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_END_UPDATE_FDT,
		// Token: 0x04000259 RID: 601
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_RESTORE_PDV2_RADIO,
		// Token: 0x0400025A RID: 602
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_MIGRATE_FDT,
		// Token: 0x0400025B RID: 603
		[global::System.Runtime.Serialization.EnumMember]
		SWITCH_MODE_NO_WAIT,
		// Token: 0x0400025C RID: 604
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_WRITE_KEYS,
		// Token: 0x0400025D RID: 605
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_READ_KEYS,
		// Token: 0x0400025E RID: 606
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_CLEAN_DAMAGE_FLAG,
		// Token: 0x0400025F RID: 607
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_TEST_FDT,
		// Token: 0x04000260 RID: 608
		[global::System.Runtime.Serialization.EnumMember]
		OPEN_COMMUNICATION_PIPE,
		// Token: 0x04000261 RID: 609
		[global::System.Runtime.Serialization.EnumMember]
		AT_CUSTOM_MESSAGE,
		// Token: 0x04000262 RID: 610
		[global::System.Runtime.Serialization.EnumMember]
		AT_GET_BATTERY_STATUS,
		// Token: 0x04000263 RID: 611
		[global::System.Runtime.Serialization.EnumMember]
		AT_GET_DEVICE_MODE,
		// Token: 0x04000264 RID: 612
		[global::System.Runtime.Serialization.EnumMember]
		AT_GET_EMERGENCY_STATUS,
		// Token: 0x04000265 RID: 613
		[global::System.Runtime.Serialization.EnumMember]
		AT_GET_RADIO_INFO,
		// Token: 0x04000266 RID: 614
		[global::System.Runtime.Serialization.EnumMember]
		AT_RESET_TO_PROGMODE,
		// Token: 0x04000267 RID: 615
		[global::System.Runtime.Serialization.EnumMember]
		AT_SET_RP_STATE,
		// Token: 0x04000268 RID: 616
		[global::System.Runtime.Serialization.EnumMember]
		CLOSE_COMMUNICATION_PIPE,
		// Token: 0x04000269 RID: 617
		[global::System.Runtime.Serialization.EnumMember]
		GET_CEMSTONE_RADIO_FP_INFO,
		// Token: 0x0400026A RID: 618
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_GET_PLATFORM_INFO,
		// Token: 0x0400026B RID: 619
		[global::System.Runtime.Serialization.EnumMember]
		VERIFY_RADIO_LANGUAGE_PACK,
		// Token: 0x0400026C RID: 620
		[global::System.Runtime.Serialization.EnumMember]
		REMOVE_RS232_RADIO_FROM_SYSTEM,
		// Token: 0x0400026D RID: 621
		[global::System.Runtime.Serialization.EnumMember]
		AT_GET_DMS,
		// Token: 0x0400026E RID: 622
		[global::System.Runtime.Serialization.EnumMember]
		AT_ERASE_DMS,
		// Token: 0x0400026F RID: 623
		[global::System.Runtime.Serialization.EnumMember]
		AT_CHANGE_DMS_CODE,
		// Token: 0x04000270 RID: 624
		[global::System.Runtime.Serialization.EnumMember]
		MS_COLLECT_PICTURES,
		// Token: 0x04000271 RID: 625
		[global::System.Runtime.Serialization.EnumMember]
		MS_PUSH_PICTURES,
		// Token: 0x04000272 RID: 626
		[global::System.Runtime.Serialization.EnumMember]
		CPA_AUTHENTICATE_RADIO,
		// Token: 0x04000273 RID: 627
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_FLASH_REGION_OPERATION,
		// Token: 0x04000274 RID: 628
		[global::System.Runtime.Serialization.EnumMember]
		CPA_UNAUTHENTICATE_RADIO,
		// Token: 0x04000275 RID: 629
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_GET_STATUS,
		// Token: 0x04000276 RID: 630
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_SET_DAMAGE_FLAG
	}
}
