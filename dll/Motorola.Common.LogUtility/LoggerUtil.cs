using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using Motorola.Common.CustomException;

namespace Motorola.Common.LogUtility
{
	// Token: 0x0200000C RID: 12
	public static class LoggerUtil
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000364C File Offset: 0x0000184C
		public static string ExportExceptionInfo(global::System.Exception e)
		{
			if (e == null)
			{
				return string.Empty;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendFormat("Exception: {0}\r\n", e.GetType());
			global::Motorola.Common.CustomException.CommonException ex = e as global::Motorola.Common.CustomException.CommonException;
			stringBuilder.AppendFormat("ErrorID: {0}\r\n", (ex != null) ? ex.ErrorCode.ToString() : "Unknown");
			stringBuilder.AppendFormat("Message: {0}\r\n", e.Message);
			stringBuilder.AppendFormat("Source: {0}\r\n", e.Source);
			stringBuilder.Append(e.StackTrace);
			if (e.InnerException != null)
			{
				stringBuilder.AppendLine("\r\n\r\n[InnerException]");
				stringBuilder.Append(global::Motorola.Common.LogUtility.LoggerUtil.ExportExceptionInfo(e.InnerException));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003704 File Offset: 0x00001904
		public static string DateString(global::System.DateTime dt)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}-{1:D2}-{2:D2} {3:D2}:{4:D2}:{5:D2} {6:D3}", new object[]
			{
				dt.Year,
				dt.Month,
				dt.Day,
				dt.Hour,
				dt.Minute,
				dt.Second,
				dt.Millisecond
			});
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003794 File Offset: 0x00001994
		public static string DateStringWithoutMillisecond(global::System.DateTime dt)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}-{1:D2}-{2:D2} {3:D2}:{4:D2}:{5:D2}", new object[]
			{
				dt.Year,
				dt.Month,
				dt.Day,
				dt.Hour,
				dt.Minute,
				dt.Second
			});
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003814 File Offset: 0x00001A14
		public static string LogTitle(string loggerName, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			if (e.Level == global::Motorola.Common.LogUtility.LoggingLevel.Performance)
			{
				global::System.Reflection.MethodBase method = e.StackFrame.GetMethod();
				string text = string.Empty;
				if (method != null)
				{
					string text2 = (method.ReflectedType == null) ? string.Empty : method.ReflectedType.Name;
					text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
					{
						text2,
						method.Name
					});
				}
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "[{0}] [{1}] [{2}] In Method[{3}] StampName[{4}] TimeSpan[{5}]/[{6}] [{7}]", new object[]
				{
					global::Motorola.Common.LogUtility.LoggerUtil.DateString(e.TimeStamp),
					global::System.Threading.Thread.CurrentThread.ManagedThreadId,
					e.Level,
					text,
					e.StampName,
					global::Motorola.Common.LogUtility.LoggerUtil.GetCpuTimeSpan(e.StampName).TotalMilliseconds,
					global::Motorola.Common.LogUtility.LoggerUtil.GetSysTimeSpan(e.StampName).TotalMilliseconds,
					loggerName
				});
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "[{0}] [{1}] [{2}] [{3}]", new object[]
			{
				global::Motorola.Common.LogUtility.LoggerUtil.DateString(e.TimeStamp),
				global::System.Threading.Thread.CurrentThread.ManagedThreadId,
				e.Level,
				loggerName
			});
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003978 File Offset: 0x00001B78
		public static string LogBody(global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine(e.Message);
			if (e.Exception != null)
			{
				stringBuilder.AppendLine();
				stringBuilder.AppendLine(global::Motorola.Common.LogUtility.LoggerUtil.ExportExceptionInfo(e.Exception));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000039C0 File Offset: 0x00001BC0
		public static string GetCurrentLogFolderPath(string rootLogFolder)
		{
			global::System.DateTime now = global::System.DateTime.Now;
			string path = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0:D2}-{1:D2}-{2:D2}", new object[]
			{
				now.Year,
				now.Month,
				now.Day
			});
			return global::System.IO.Path.Combine(rootLogFolder, path);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003A1F File Offset: 0x00001C1F
		public static string GetCurrentLogFolderPath()
		{
			return global::Motorola.Common.LogUtility.LoggerUtil.GetCurrentLogFolderPath(global::Motorola.Common.LogUtility.Configurator.GetLogDirectory());
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003A2C File Offset: 0x00001C2C
		public static void LogInnerException(global::System.Exception e)
		{
			try
			{
				string path = global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), "cps_unknown_fatal_error.log");
				using (new global::Motorola.Common.LogUtility.FileLocker(global::System.IO.Path.GetFileName(path)))
				{
					using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(path, true))
					{
						global::Motorola.Common.LogUtility.LoggingEventArgs e2 = new global::Motorola.Common.LogUtility.LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel.Error, global::System.DateTime.Now, "Fatal inner error", e);
						string value = global::Motorola.Common.LogUtility.LoggerUtil.LogTitle("Inner Error", e2);
						streamWriter.WriteLine(value);
						string value2 = global::Motorola.Common.LogUtility.LoggerUtil.LogBody(e2);
						streamWriter.WriteLine(value2);
						streamWriter.WriteLine("----------------------------------------");
					}
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003AE8 File Offset: 0x00001CE8
		public static void SetTimeStampLabel(string labelName)
		{
			if (string.IsNullOrEmpty(labelName))
			{
				labelName = "__DEFAULT_TIMESTAMP_LABEL_NAME__";
			}
			lock (global::Motorola.Common.LogUtility.LoggerUtil._cpuStampMap)
			{
				global::Motorola.Common.LogUtility.LoggerUtil._cpuStampMap[global::Motorola.Common.LogUtility.LoggerUtil.GenLabelKeyId(labelName)] = global::System.Diagnostics.Process.GetCurrentProcess().TotalProcessorTime;
			}
			lock (global::Motorola.Common.LogUtility.LoggerUtil._sysStampMap)
			{
				global::Motorola.Common.LogUtility.LoggerUtil._sysStampMap[global::Motorola.Common.LogUtility.LoggerUtil.GenLabelKeyId(labelName)] = global::System.DateTime.Now;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003B88 File Offset: 0x00001D88
		private static global::System.TimeSpan GetCpuTimeSpan(string labelName)
		{
			if (string.IsNullOrEmpty(labelName))
			{
				labelName = "__DEFAULT_TIMESTAMP_LABEL_NAME__";
			}
			string key = global::Motorola.Common.LogUtility.LoggerUtil.GenLabelKeyId(labelName);
			if (global::Motorola.Common.LogUtility.LoggerUtil._cpuStampMap.ContainsKey(key))
			{
				lock (global::Motorola.Common.LogUtility.LoggerUtil._cpuStampMap)
				{
					global::System.TimeSpan result = global::System.Diagnostics.Process.GetCurrentProcess().TotalProcessorTime - global::Motorola.Common.LogUtility.LoggerUtil._cpuStampMap[key];
					global::Motorola.Common.LogUtility.LoggerUtil._cpuStampMap.Remove(key);
					return result;
				}
			}
			return default(global::System.TimeSpan);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003C1C File Offset: 0x00001E1C
		private static global::System.TimeSpan GetSysTimeSpan(string labelName)
		{
			if (string.IsNullOrEmpty(labelName))
			{
				labelName = "__DEFAULT_TIMESTAMP_LABEL_NAME__";
			}
			string key = global::Motorola.Common.LogUtility.LoggerUtil.GenLabelKeyId(labelName);
			if (global::Motorola.Common.LogUtility.LoggerUtil._sysStampMap.ContainsKey(key))
			{
				lock (global::Motorola.Common.LogUtility.LoggerUtil._sysStampMap)
				{
					global::System.TimeSpan timeSpan = default(global::System.TimeSpan);
					return global::System.DateTime.Now - global::Motorola.Common.LogUtility.LoggerUtil._sysStampMap[key];
				}
			}
			return default(global::System.TimeSpan);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00003CA8 File Offset: 0x00001EA8
		public static string RootLogFolder
		{
			get
			{
				return global::Motorola.Common.LogUtility.Configurator.GetLogDirectory();
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003CB0 File Offset: 0x00001EB0
		private static string GenLabelKeyId(string labelName)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}_{1}", new object[]
			{
				labelName,
				global::System.Threading.Thread.CurrentThread.ManagedThreadId
			});
		}

		// Token: 0x0400003A RID: 58
		private const string _defaultStampLabel = "__DEFAULT_TIMESTAMP_LABEL_NAME__";

		// Token: 0x0400003B RID: 59
		private static global::System.Collections.Generic.Dictionary<string, global::System.TimeSpan> _cpuStampMap = new global::System.Collections.Generic.Dictionary<string, global::System.TimeSpan>();

		// Token: 0x0400003C RID: 60
		private static global::System.Collections.Generic.Dictionary<string, global::System.DateTime> _sysStampMap = new global::System.Collections.Generic.Dictionary<string, global::System.DateTime>();
	}
}
