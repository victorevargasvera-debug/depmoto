using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000013 RID: 19
	internal static class ASTRODefinitions
	{
		// Token: 0x04000043 RID: 67
		public const int DefaultWiredDiscoveryCommTimeout = 15000;

		// Token: 0x04000044 RID: 68
		public const int MaxTransportPacketSize = 1400;

		// Token: 0x04000045 RID: 69
		public const int MaxLegacyOTAPTransportPacketSize = 1000;

		// Token: 0x04000046 RID: 70
		public const int MaxFileOTAPTransportPacketSize = 1400;

		// Token: 0x04000047 RID: 71
		public const int MaxFileWiFiTransportPacketSize = 1400;

		// Token: 0x04000048 RID: 72
		public const int EndSingleInstanceItems = 2044;

		// Token: 0x04000049 RID: 73
		public const string MinimumAstroFilePSDT = "06.70.00";

		// Token: 0x0400004A RID: 74
		public const ushort RadAppInfoCmpType = 1025;

		// Token: 0x0400004B RID: 75
		public const ushort constEncryptedPINPSWDCmpType = 1150;

		// Token: 0x0400004C RID: 76
		public const ushort RadAppInfoCmpExtSysRelVerOffset = 72;

		// Token: 0x0400004D RID: 77
		public const ushort FeatDescrCmpType = 901;

		// Token: 0x0400004E RID: 78
		public const ushort constMDFCmpType = 903;

		// Token: 0x0400004F RID: 79
		public const ushort constRadioWidePin = 1028;

		// Token: 0x04000050 RID: 80
		public const ushort DATA_CFG_CDA = 1027;

		// Token: 0x04000051 RID: 81
		public const ushort RadioAliasType = 1026;

		// Token: 0x04000052 RID: 82
		public const byte HOST_VER_TYPE = 0;

		// Token: 0x04000053 RID: 83
		public const byte DSP_VER_TYPE = 16;

		// Token: 0x04000054 RID: 84
		public const byte PSDT_VER_TYPE = 80;

		// Token: 0x04000055 RID: 85
		public const byte MACE_VER_TYPE = 35;

		// Token: 0x04000056 RID: 86
		public const byte NAUT_VER_TYPE = 104;

		// Token: 0x04000057 RID: 87
		public const byte CH_VER_TYPE = 112;

		// Token: 0x04000058 RID: 88
		public const byte CPG_VER_TYPE = 66;

		// Token: 0x04000059 RID: 89
		public const byte CSD_VER_TYPE = 67;

		// Token: 0x0400005A RID: 90
		public const string PSDT_PSDT_A_ID = "PDTA";

		// Token: 0x0400005B RID: 91
		public const string PSDT_PSDT_B_ID = "PDTB";

		// Token: 0x0400005C RID: 92
		public const string PSDT_PSDT_C_ID = "PDTC";

		// Token: 0x0400005D RID: 93
		public const string PSDT_SECURITY_A_ID = "SECA";

		// Token: 0x0400005E RID: 94
		public const string PSDT_SECURITY_B_ID = "SECB";

		// Token: 0x0400005F RID: 95
		public const string PSDT_HOST_FIRMWARE_A_ID = "HFWA";

		// Token: 0x04000060 RID: 96
		public const string PSDT_HOST_FIRMWARE_B_ID = "HFWB";

		// Token: 0x04000061 RID: 97
		public const string PSDT_HOST_FIRMWARE_C_ID = "HFWC";

		// Token: 0x04000062 RID: 98
		public const string PSDT_HOST_FIRMWARE_S_ID = "HFWS";

		// Token: 0x04000063 RID: 99
		public const string PSDT_DSP_FIRMWARE_A_ID = "DFWA";

		// Token: 0x04000064 RID: 100
		public const string PSDT_DSP_FIRMWARE_B_ID = "DFWB";

		// Token: 0x04000065 RID: 101
		public const string PSDT_DSP_FIRMWARE_C_ID = "DFWC";

		// Token: 0x04000066 RID: 102
		public const string PSDT_DSP_FIRMWARE_D_ID = "DFWD";

		// Token: 0x04000067 RID: 103
		public const string PSDT_NAUTILUS_IMAGE_A_ID = "NTLA";

		// Token: 0x04000068 RID: 104
		public const string PSDT_NAUTILUS_IMAGE_B_ID = "NTLB";

		// Token: 0x04000069 RID: 105
		public const string PSDT_MACE_FIRMWARE_ID = "CFWI";

		// Token: 0x0400006A RID: 106
		public const string PSDT_MACE_FIRMWARE_C_ID = "CFWC";

		// Token: 0x0400006B RID: 107
		public const string PSDT_CODEPLUG_A_ID = "CPGA";

		// Token: 0x0400006C RID: 108
		public const string PSDT_CODEPLUG_B_ID = "CPGB";

		// Token: 0x0400006D RID: 109
		public const string PSDT_CPS_SUPP_A_ID = "CPSA";

		// Token: 0x0400006E RID: 110
		public const string PSDT_CPS_SUPP_B_ID = "CPSB";

		// Token: 0x0400006F RID: 111
		public const string PSDT_UCL_A_ID = "UCLA";

		// Token: 0x04000070 RID: 112
		public const string PSDT_UCL_B_ID = "UCLB";

		// Token: 0x04000071 RID: 113
		public const string LANG_PACK_FILE_PATH = "/LANGUAGE/";

		// Token: 0x04000072 RID: 114
		public const string MANIFEST_EXT = ".mnf";

		// Token: 0x04000073 RID: 115
		public const ushort SingleInstanceEndType = 2044;

		// Token: 0x04000074 RID: 116
		public const int IshCheckSumLength = 2;
	}
}
