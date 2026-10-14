using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200001B RID: 27
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroDeviceInfo : global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002D6F File Offset: 0x00000F6F
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002D77 File Offset: 0x00000F77
		[global::System.Runtime.Serialization.DataMember]
		public string UUID { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002D80 File Offset: 0x00000F80
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002D88 File Offset: 0x00000F88
		[global::System.Runtime.Serialization.DataMember]
		public string RadioBBFSuiteVersion { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002D91 File Offset: 0x00000F91
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002D99 File Offset: 0x00000F99
		[global::System.Runtime.Serialization.DataMember]
		public string TuneVersion { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002DA2 File Offset: 0x00000FA2
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002DAA File Offset: 0x00000FAA
		[global::System.Runtime.Serialization.DataMember]
		public string PsdtVersion { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002DB3 File Offset: 0x00000FB3
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002DBB File Offset: 0x00000FBB
		[global::System.Runtime.Serialization.DataMember]
		public string MaceFlashVersion { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002DC4 File Offset: 0x00000FC4
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002DCC File Offset: 0x00000FCC
		[global::System.Runtime.Serialization.DataMember]
		public string DspVersion { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002DD5 File Offset: 0x00000FD5
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002DDD File Offset: 0x00000FDD
		[global::System.Runtime.Serialization.DataMember]
		public string BootloaderVersion { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002DE6 File Offset: 0x00000FE6
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002DEE File Offset: 0x00000FEE
		[global::System.Runtime.Serialization.DataMember]
		public string OptionBoardFlashImageType { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002DF7 File Offset: 0x00000FF7
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002DFF File Offset: 0x00000FFF
		[global::System.Runtime.Serialization.DataMember]
		public string OptionBoardFlashImageVersion { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002E08 File Offset: 0x00001008
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002E10 File Offset: 0x00001010
		[global::System.Runtime.Serialization.DataMember]
		public string OptionBoardHardwareHostVersion { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002E19 File Offset: 0x00001019
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002E21 File Offset: 0x00001021
		[global::System.Runtime.Serialization.DataMember]
		public string LTEOptionBoardHardwareHostVersion { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002E2A File Offset: 0x0000102A
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002E32 File Offset: 0x00001032
		[global::System.Runtime.Serialization.DataMember]
		public bool OptionBoardHardwareNotPresentFlag { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002E3B File Offset: 0x0000103B
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002E43 File Offset: 0x00001043
		[global::System.Runtime.Serialization.DataMember]
		public string OptionBoardHardwareType { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002E4C File Offset: 0x0000104C
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002E54 File Offset: 0x00001054
		[global::System.Runtime.Serialization.DataMember]
		public string OptionBoardName { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002E5D File Offset: 0x0000105D
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002E65 File Offset: 0x00001065
		[global::System.Runtime.Serialization.DataMember]
		public string ConsoletteBoardHardwareHostVersion { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002E6E File Offset: 0x0000106E
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002E76 File Offset: 0x00001076
		[global::System.Runtime.Serialization.DataMember]
		public string ConsoletteBoardHardwareType { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002E7F File Offset: 0x0000107F
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002E87 File Offset: 0x00001087
		[global::System.Runtime.Serialization.DataMember]
		public string MaceSecureHardwareType { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002E90 File Offset: 0x00001090
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002E98 File Offset: 0x00001098
		[global::System.Runtime.Serialization.DataMember]
		public string MaceSecureHardwareVersion { get; set; }

		// Token: 0x040000BF RID: 191
		[global::System.Runtime.Serialization.OptionalField]
		[global::System.Runtime.Serialization.DataMember]
		public byte[] ESN;
	}
}
