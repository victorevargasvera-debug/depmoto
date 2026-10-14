using System;
using System.Text;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000023 RID: 35
	public static class TransportLogger
	{
		// Token: 0x06000112 RID: 274 RVA: 0x0000958C File Offset: 0x0000778C
		public static void Write(string logFileSuffix, byte[] buffer, int offset, int len, string format, params object[] message)
		{
			if (!global::Motorola.Common.Communication.TetraUtility.TransportLogger.Enable)
			{
				return;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine(global::Motorola.Common.Communication.TetraUtility.TransportLogger.FilterHeader + string.Format(format, message));
			string sbepName = global::Motorola.Common.Communication.TetraUtility.SbepParser.GetSbepName(buffer);
			if (!string.IsNullOrEmpty(sbepName))
			{
				stringBuilder.AppendLine(string.Format("SBEP DESC: [{0}]", sbepName));
			}
			stringBuilder.Append(global::Motorola.Common.Communication.TetraUtility.TransportLogger.FormatBuffer(buffer, offset, len));
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.MyLogger.UserOperationEx(logFileSuffix, stringBuilder.ToString(), new object[0]);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00009608 File Offset: 0x00007808
		public static void WriteInfo(string logFileSuffix, string format, params object[] message)
		{
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.MyLogger.UserOperationEx(logFileSuffix, format, message);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00009617 File Offset: 0x00007817
		public static void WriteInfo(string logFileSuffix, string log)
		{
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.MyLogger.UserOperationEx(logFileSuffix, log, new object[0]);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000962B File Offset: 0x0000782B
		public static void Error(global::System.Exception e, string logFileSuffix, string format, params object[] message)
		{
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.MyLogger.ErrorEx(e, logFileSuffix, format, message);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000963B File Offset: 0x0000783B
		private static global::Motorola.Common.LogUtility.ILog MyLogger
		{
			get
			{
				return global::Motorola.Common.LogUtility.LogManager.GetLogger("Com_Raw_Data_Logger");
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00009648 File Offset: 0x00007848
		private static string FormatBuffer(byte[] buffer, int offset, int len)
		{
			if (buffer == null)
			{
				return string.Empty;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Text.StringBuilder stringBuilder2;
			for (int i = 0; i < len / 16; i++)
			{
				if (global::Motorola.Common.Communication.TetraUtility.TransportLogger.TruncateData && i == 4)
				{
					stringBuilder.AppendLine(global::Motorola.Common.Communication.TetraUtility.TransportLogger.FilterHeader + "...");
					stringBuilder.AppendLine(global::Motorola.Common.Communication.TetraUtility.TransportLogger.FilterHeader + "...");
					stringBuilder.AppendLine(global::Motorola.Common.Communication.TetraUtility.TransportLogger.FilterHeader + "...");
					break;
				}
				stringBuilder.Append(global::Motorola.Common.Communication.TetraUtility.TransportLogger.FilterHeader);
				stringBuilder2 = new global::System.Text.StringBuilder(new string(' ', 10));
				for (int j = 0; j < 16; j++)
				{
					byte b = buffer[offset + i * 16 + j];
					stringBuilder.AppendFormat("{0:X2} ", b);
					stringBuilder2.Append(global::Motorola.Common.Communication.TetraUtility.TransportLogger.Convert2Char(b));
				}
				stringBuilder.Append(stringBuilder2);
				stringBuilder.AppendLine();
			}
			int num = len % 16;
			stringBuilder.Append(global::Motorola.Common.Communication.TetraUtility.TransportLogger.FilterHeader);
			stringBuilder2 = new global::System.Text.StringBuilder(new string(' ', 10 + (16 - num) * 3));
			for (int k = 0; k < num; k++)
			{
				byte b2 = buffer[offset + len / 16 * 16 + k];
				stringBuilder.AppendFormat("{0:X2} ", b2);
				stringBuilder2.Append(global::Motorola.Common.Communication.TetraUtility.TransportLogger.Convert2Char(b2));
			}
			stringBuilder.Append(stringBuilder2);
			stringBuilder.AppendLine();
			return stringBuilder.ToString();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000097AE File Offset: 0x000079AE
		private static char Convert2Char(byte b)
		{
			if (b < 32 || b > 127)
			{
				return '.';
			}
			return global::System.Convert.ToChar(b);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000097C3 File Offset: 0x000079C3
		private static string FilterHeader
		{
			get
			{
				if (global::Motorola.Common.Communication.TetraUtility.TransportLogger.Filter != null)
				{
					return global::Motorola.Common.Communication.TetraUtility.TransportLogger.Filter.Trim();
				}
				return string.Empty;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000097DC File Offset: 0x000079DC
		private static bool Enable
		{
			get
			{
				string value = global::Motorola.Common.Communication.TetraUtility.OptionsDatabaseSingleton.Instance.GetValue("Com_Raw_Data_Log", "Enable");
				return !string.IsNullOrEmpty(value) && global::System.Convert.ToBoolean(value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00009810 File Offset: 0x00007A10
		private static bool TruncateData
		{
			get
			{
				string value = global::Motorola.Common.Communication.TetraUtility.OptionsDatabaseSingleton.Instance.GetValue("Com_Raw_Data_Log", "Truncate");
				return !string.IsNullOrEmpty(value) && global::System.Convert.ToBoolean(value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00009842 File Offset: 0x00007A42
		private static string Filter
		{
			get
			{
				return global::Motorola.Common.Communication.TetraUtility.OptionsDatabaseSingleton.Instance.GetValue("Com_Raw_Data_Log", "Filter");
			}
		}

		// Token: 0x0400007A RID: 122
		private const string OPTIONS_COM_LOG_SECTION = "Com_Raw_Data_Log";

		// Token: 0x0400007B RID: 123
		private const string OPTIONS_COM_LOG_FILTER = "Filter";

		// Token: 0x0400007C RID: 124
		private const string OPTIONS_COM_LOG_ENABLE = "Enable";

		// Token: 0x0400007D RID: 125
		private const string OPTIONS_COM_LOG_TRUNCATE = "Truncate";

		// Token: 0x0400007E RID: 126
		private const int MaxLineLen = 16;

		// Token: 0x0400007F RID: 127
		private const int TruncateThreshold = 64;
	}
}
