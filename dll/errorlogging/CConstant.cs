using System;

namespace ErrorLogging
{
	// Token: 0x02000007 RID: 7
	public class CConstant
	{
		// Token: 0x04000007 RID: 7
		public const string STRMATRIXARCHIVEEXTENSION = ".ctb";

		// Token: 0x04000008 RID: 8
		public const string STRMATRIXTUNERARCHIVEEXTENSION = ".ttb";

		// Token: 0x04000009 RID: 9
		public const string STRMATRIXDEVICEUUID = "QUERYRADIOUUID";

		// Token: 0x0400000A RID: 10
		public const string STRCOMPONENTDC = "DatabaseController";

		// Token: 0x0400000B RID: 11
		public const string STREVENTRESOURCENAME = "Trbo CPS";

		// Token: 0x0400000C RID: 12
		public const string STRREGPATHERRORLEVEL = "Software\\Motorola\\Trbo CPS";

		// Token: 0x0400000D RID: 13
		public const string STRREGNAMEERRORLEVEL = "ErrorLogLevel";

		// Token: 0x0400000E RID: 14
		public const string STRGETERRORLOGLEVELFROMREGISTRYFAILED = "Can't get ErrorLogLevel from windows registry";

		// Token: 0x0400000F RID: 15
		public const string STRCOMPONENTCC = "CommunicationController";

		// Token: 0x04000010 RID: 16
		public const string STRFILERCC = "communicationcontroller.cs";

		// Token: 0x04000011 RID: 17
		public const string STRCOMPONENTRCI = "RadioCodeplugInterface";

		// Token: 0x04000012 RID: 18
		public const string STRFILERCI = "radiocodepluginterface.cpp";

		// Token: 0x04000013 RID: 19
		public const string STRCOMPONENTRTI = "RadioTuningInterface";

		// Token: 0x04000014 RID: 20
		public const string STRFILERTI = "radiotuninginterface.cpp";

		// Token: 0x04000015 RID: 21
		public const string STRCOMPONENTST = "SerialTransport";

		// Token: 0x04000016 RID: 22
		public const string STRFILEST = "serialtransport.cpp";

		// Token: 0x04000017 RID: 23
		public const string STRCOMPONENTFU = "FirmwareUpgrade";

		// Token: 0x04000018 RID: 24
		public const string STRFILEFU = "firmwareupgrade.cpp";

		// Token: 0x04000019 RID: 25
		public const int IMAXUSHORT = 65535;

		// Token: 0x0400001A RID: 26
		public const int IMINUSHORT = 0;

		// Token: 0x0400001B RID: 27
		public const string STRCOMPONENTRA = "RegistryAccess";

		// Token: 0x0400001C RID: 28
		public const int I_NOT_ARCHIVE = 0;

		// Token: 0x0400001D RID: 29
		public const int I_LTD_ARCHIVE = 1;

		// Token: 0x0400001E RID: 30
		public const uint UI_MATRIX_DB_TYPE = 1U;

		// Token: 0x0400001F RID: 31
		public const uint UI_UNKNOWN_DB_TYPE = 0U;

		// Token: 0x04000020 RID: 32
		public const uint UI_TRANSPORT = 8002U;

		// Token: 0x04000021 RID: 33
		public const uint UI_PROTOCOL = 0U;

		// Token: 0x04000022 RID: 34
		public const uint UI_TARGETDEVICE = 0U;

		// Token: 0x04000023 RID: 35
		public const uint UI_ATPORTNUMBER = 4064U;

		// Token: 0x04000024 RID: 36
		public const uint UI_PROTOCOL_UDP = 1U;

		// Token: 0x04000025 RID: 37
		public const uint UI_EXCHANGE_PORT = 4070U;

		// Token: 0x04000026 RID: 38
		public const uint UI_PROTOCOL_TLS_CLIENT_1_0_2A = 3U;

		// Token: 0x04000027 RID: 39
		public const bool B_MIRROR = false;

		// Token: 0x04000028 RID: 40
		public const bool B_ERRORLOG = true;

		// Token: 0x04000029 RID: 41
		public const string STRERRORLOGLEVEL = "ErrorLogLevel";
	}
}
