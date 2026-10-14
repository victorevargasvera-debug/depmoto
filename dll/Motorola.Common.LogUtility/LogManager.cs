using System;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000010 RID: 16
	public static class LogManager
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00004320 File Offset: 0x00002520
		public static global::Motorola.Common.LogUtility.ILog GetLogger(string loggerName)
		{
			global::Motorola.Common.LogUtility.ILog log = global::Motorola.Common.LogUtility.Configurator.GetLogger(loggerName);
			if (log == null)
			{
				log = global::Motorola.Common.LogUtility.LogManager.GetDefaultLogger();
			}
			return log;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000433E File Offset: 0x0000253E
		public static string DefaultLoggerName
		{
			get
			{
				return "Default Logger";
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00004345 File Offset: 0x00002545
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000434C File Offset: 0x0000254C
		public static string LogDirectory
		{
			get
			{
				return global::Motorola.Common.LogUtility.Configurator.GetLogDirectory();
			}
			set
			{
				global::Motorola.Common.LogUtility.Configurator.SetLogDirectory(value);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004354 File Offset: 0x00002554
		public static void UpdateLogDirectoryInMemory(string path)
		{
			global::Motorola.Common.LogUtility.Configurator.UpdateLogDirectoryInMemory(path);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000435C File Offset: 0x0000255C
		public static global::System.DateTime LoggerLaunchTime
		{
			get
			{
				return global::Motorola.Common.LogUtility.LogManager.loggerLaunchTime;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00004363 File Offset: 0x00002563
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000436A File Offset: 0x0000256A
		public static string ConfigFilePath
		{
			get
			{
				return global::Motorola.Common.LogUtility.Configurator.ConfigFilePath;
			}
			set
			{
				global::Motorola.Common.LogUtility.Configurator.ConfigFilePath = value;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004374 File Offset: 0x00002574
		private static global::Motorola.Common.LogUtility.ILog GetDefaultLogger()
		{
			global::Motorola.Common.LogUtility.ILog defalutLogger;
			lock (global::Motorola.Common.LogUtility.LogManager.padLock)
			{
				if (global::Motorola.Common.LogUtility.LogManager.DefalutLogger != null)
				{
					defalutLogger = global::Motorola.Common.LogUtility.LogManager.DefalutLogger;
				}
				else
				{
					global::Motorola.Common.LogUtility.LogManager.DefalutLogger = new global::Motorola.Common.LogUtility.LogImpl();
					global::Motorola.Common.LogUtility.LogManager.DefalutLogger.Name = global::Motorola.Common.LogUtility.LogManager.DefaultLoggerName;
					global::Motorola.Common.LogUtility.LogManager.DefalutLogger.Level = global::Motorola.Common.LogUtility.LoggingLevel.Error;
					global::Motorola.Common.LogUtility.LogManager.DefalutLogger.AddAppender(global::Motorola.Common.LogUtility.Configurator.GetDefaultAppender());
					defalutLogger = global::Motorola.Common.LogUtility.LogManager.DefalutLogger;
				}
			}
			return defalutLogger;
		}

		// Token: 0x04000049 RID: 73
		private const string defaultLoggerName = "Default Logger";

		// Token: 0x0400004A RID: 74
		private static global::Motorola.Common.LogUtility.LogImpl DefalutLogger = null;

		// Token: 0x0400004B RID: 75
		private static readonly object padLock = new object();

		// Token: 0x0400004C RID: 76
		private static global::System.DateTime loggerLaunchTime = global::System.DateTime.Now;
	}
}
