using System;
using System.Text;

namespace Motorola.Common.Communication.PCRRemoteProgramming
{
	// Token: 0x0200000B RID: 11
	public static class PCRRPConstants
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002F64 File Offset: 0x00001164
		public static string RetrieveASCIIString(string input)
		{
			byte[] bytes = global::System.Convert.FromBase64String(input);
			return global::System.Text.Encoding.ASCII.GetString(bytes);
		}

		// Token: 0x0400001A RID: 26
		private const byte ENABLE_REMOTE_DUP_SETUP = 1;

		// Token: 0x0400001B RID: 27
		private const byte DISABLE_REMOTE_DUP_SETUP = 2;

		// Token: 0x0400001C RID: 28
		private const ulong VIR_MEM_BASE_ADDRESS = 201326592UL;

		// Token: 0x0400001D RID: 29
		private const long VIR_MEM_OFFSET = 201326592L;

		// Token: 0x0400001E RID: 30
		public const string ACTIVE_PSDT = "PSDX";

		// Token: 0x0400001F RID: 31
		public const string ACTIVE_CPGA = "CPGX";

		// Token: 0x04000020 RID: 32
		public const string ACTIVE_SECA = "SECX";

		// Token: 0x04000021 RID: 33
		public const string ACTIVE_TUNA = "TUNX";

		// Token: 0x04000022 RID: 34
		public const string ACTIVE_UCLA = "UCLX";

		// Token: 0x04000023 RID: 35
		private const string ACTIVE_DSP = "DSPX";

		// Token: 0x04000024 RID: 36
		private const string ACTIVE_HOST = "RAPX";

		// Token: 0x04000025 RID: 37
		private const string RP_WRITE_PSDT = "PSD1";

		// Token: 0x04000026 RID: 38
		private const string RP_WRITE_CPGA = "CPG1";

		// Token: 0x04000027 RID: 39
		private const string RP_WRITE_SECA = "SEC1";

		// Token: 0x04000028 RID: 40
		private const string RP_WRITE_TUNA = "TUN1";

		// Token: 0x04000029 RID: 41
		private const string RP_WRITE_UCLA = "UCL1";

		// Token: 0x0400002A RID: 42
		private const string RP_WRITE_DSP = "DSP1";

		// Token: 0x0400002B RID: 43
		private const string RP_WRITE_HOST = "RAP1";

		// Token: 0x0400002C RID: 44
		public const string WRITE_FILE_ID = "FILE";

		// Token: 0x0400002D RID: 45
		private const int DEFAULT_UH_TIMEOUT = 18000;

		// Token: 0x0400002E RID: 46
		internal static readonly short SYSTEM_ID_APP = 3072;

		// Token: 0x0400002F RID: 47
		public static readonly byte PROXY_TCP = 0;

		// Token: 0x04000030 RID: 48
		public static readonly string SSLCERT = "cmVzb3VyY2VzXFw2MDEzODQxOTAz";

		// Token: 0x04000031 RID: 49
		public static readonly string SSLPSWD = "JVNOPGVxS2c1Um5xIVkvIXNZVDAteilR";

		// Token: 0x04000032 RID: 50
		public static readonly string SSLCERT_FILE = "cmVzb3VyY2VzXG1zaV9wY3IuY3J0";

		// Token: 0x04000033 RID: 51
		public static readonly string SSLKEY_FILE = "cmVzb3VyY2VzXG1zaV9wY3IucGVt";

		// Token: 0x04000034 RID: 52
		public static readonly string SSLKEY_PSWD = "JDEkUEYySGJEalkkOEU0N2ttU2RueW0yV084aWU3Q1paMA==";

		// Token: 0x04000035 RID: 53
		public static readonly string SSLCERTFTX = "cmVzb3VyY2VzXG1zaV9wY3IucGZ4";

		// Token: 0x04000036 RID: 54
		public static readonly string SSLPSWDFTX = "JDEkbFVOV1BFVVgkdEZRemlyci5DYkplSEtURkZvRkpILg==";

		// Token: 0x04000037 RID: 55
		internal static readonly int REMOTE_RETRY_TIMEOUT = 120;

		// Token: 0x04000038 RID: 56
		internal static readonly int SECONDS = 1000;

		// Token: 0x04000039 RID: 57
		public static readonly uint ACCEPT_TIMEOUT = 60000U;

		// Token: 0x0400003A RID: 58
		public static readonly uint ACCEPT_RP_TIMEOUT = 120000U;

		// Token: 0x0400003B RID: 59
		public static readonly int SUCCESS = 0;

		// Token: 0x0400003C RID: 60
		public static readonly int FAILURE = 1;

		// Token: 0x0400003D RID: 61
		public static readonly string REMOTE_USERNAME = "Motorola";

		// Token: 0x0400003E RID: 62
		public static readonly string REMOTE_DEFAULT_PASSWORD = "";

		// Token: 0x0400003F RID: 63
		internal static readonly string NUL_STRING = "\0";

		// Token: 0x04000040 RID: 64
		internal static readonly string AUTHENTICATE_PLAIN = "AUTHENTICATE \"PLAIN\"";

		// Token: 0x04000041 RID: 65
		internal static readonly string OK = "OK";

		// Token: 0x04000042 RID: 66
		internal static readonly int UINT_256 = 256;

		// Token: 0x04000043 RID: 67
		public static readonly int RPOpenPortTimeout = 10000;

		// Token: 0x04000044 RID: 68
		public static readonly int RPReceiveTimeout = 10000;

		// Token: 0x04000045 RID: 69
		public static readonly int RPWriteProgressUpdateTimeout = 120000;

		// Token: 0x0200000C RID: 12
		public enum ProxyResponse
		{
			// Token: 0x04000047 RID: 71
			SUCCESS_TLSv10,
			// Token: 0x04000048 RID: 72
			COMMAND_NOT_SUPPORTED,
			// Token: 0x04000049 RID: 73
			BUSY,
			// Token: 0x0400004A RID: 74
			SERVICE_NOT_SUPPORTED,
			// Token: 0x0400004B RID: 75
			SUCCESS_TLSv12,
			// Token: 0x0400004C RID: 76
			RRP_NOT_ENABLED
		}

		// Token: 0x0200000D RID: 13
		private enum RemoteWriteErrorCode
		{
			// Token: 0x0400004E RID: 78
			None,
			// Token: 0x0400004F RID: 79
			DISABLE_REMOTE_WRITE,
			// Token: 0x04000050 RID: 80
			LE_FIELDS_CHANGED_REMOTE_WRITE,
			// Token: 0x04000051 RID: 81
			DISABLE_AND_LE_FIELDS_CHANGED_REMOTE_WRITE
		}
	}
}
