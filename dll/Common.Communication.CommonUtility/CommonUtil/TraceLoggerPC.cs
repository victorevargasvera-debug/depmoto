using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Security;
using System.Threading;
using Motorola.Common.Communication.CommonUtility;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000018 RID: 24
	public class TraceLoggerPC : global::Motorola.Common.Communication.CommonUtil.TraceLogger, global::System.IDisposable
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00003688 File Offset: 0x00001888
		public override global::System.Diagnostics.TraceLevel Level
		{
			get
			{
				return global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.m_TraceSwitch.Level;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000036A4 File Offset: 0x000018A4
		internal TraceLoggerPC()
		{
			if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.m_TraceSwitch.Level != global::System.Diagnostics.TraceLevel.Off)
			{
				this.logFilePath = global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.LogFilePath;
				if (!global::System.IO.Directory.Exists(this.logFilePath))
				{
					try
					{
						global::System.IO.Directory.CreateDirectory(this.logFilePath);
					}
					catch
					{
						global::System.Console.WriteLine("Create the log folder {0} failed", this.logFilePath);
					}
				}
				string text = global::System.Diagnostics.Process.GetCurrentProcess().ProcessName;
				string text2 = text + "_CommonCommunication.log";
				this.LogFileName = global::System.IO.Path.Combine(this.logFilePath, text2);
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(this.LogFileName);
				try
				{
					global::System.IO.FileStream fileStream = fileInfo.Open(global::System.IO.FileMode.Append, global::System.IO.FileAccess.Write);
					fileStream.Close();
				}
				catch (global::System.Security.SecurityException ex)
				{
					global::System.Console.WriteLine("No permission to output the log to {0} {1}", text2, ex.Message);
					this.logFilePath = global::System.Environment.GetEnvironmentVariable("temp");
					text2 = global::System.IO.Path.Combine(this.logFilePath, text2);
					fileInfo = new global::System.IO.FileInfo(text2);
					global::System.Console.WriteLine("Redirect the log to {0}", text2);
				}
				catch (global::System.Exception ex2)
				{
					global::System.Console.WriteLine("Unexpected exception for outputting the log to {0} {1}", text2, ex2.Message);
					this.logFilePath = global::System.Environment.GetEnvironmentVariable("temp");
					text2 = global::System.IO.Path.Combine(this.logFilePath, text2);
					fileInfo = new global::System.IO.FileInfo(text2);
				}
				finally
				{
				}
				this.PreCheckForLogContent();
				try
				{
					global::System.Diagnostics.EventLog.WriteEntry("Motorola Device Communication", string.Format("The log of Motorola Device Communication was output to \"{0}\"", fileInfo.FullName), global::System.Diagnostics.EventLogEntryType.Information, 49161);
				}
				catch
				{
				}
				if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.m_TraceSwitch.Level != global::System.Diagnostics.TraceLevel.Off)
				{
					if (!text.Contains(".vshost"))
					{
					}
					this.listener = new global::System.Diagnostics.TextWriterTraceListener(fileInfo.FullName);
					global::System.Diagnostics.Trace.Listeners.Add(this.listener);
					global::System.Diagnostics.Trace.AutoFlush = true;
					global::System.Console.WriteLine(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0},+++Common Communication Log+++", new object[]
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.GetCurrentTimeString()
					}));
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003914 File Offset: 0x00001B14
		~TraceLoggerPC()
		{
			this.Dispose(false);
			this.finalizerLog();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003950 File Offset: 0x00001B50
		private void finalizerLog()
		{
			try
			{
				global::System.Diagnostics.Trace.WriteLine(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0},---Common Communication Log---", new object[]
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.GetCurrentTimeString()
				}));
				global::System.Diagnostics.Trace.Flush();
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000039A4 File Offset: 0x00001BA4
		private void PreCheckForLogContent()
		{
			try
			{
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(this.LogFileName);
				string str = global::System.Diagnostics.Process.GetCurrentProcess().ProcessName;
				if (fileInfo.Exists && fileInfo.Length > 52428800L)
				{
					string text = str + "_CommonCommunication" + global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.GetCurrentTimeStringForFileName() + ".log";
					try
					{
						if (this.listener != null)
						{
							global::System.Diagnostics.Trace.Listeners.Remove(this.listener);
							this.listener.Close();
						}
						global::System.IO.File.Move(fileInfo.FullName, global::System.IO.Path.Combine(this.logFilePath, text));
						if (this.listener != null)
						{
							this.listener = new global::System.Diagnostics.TextWriterTraceListener(fileInfo.FullName);
							global::System.Diagnostics.Trace.Listeners.Add(this.listener);
							global::System.Diagnostics.Trace.AutoFlush = true;
						}
					}
					catch (global::System.Exception ex)
					{
						global::System.Console.WriteLine("Can't rename the log file from {0} to {1} : {2}", fileInfo.FullName, text, ex.Message);
					}
				}
			}
			catch (global::System.Exception ex)
			{
				this.WriteLine("INTERNAL", ex.Message);
				this.WriteLine("INTERNAL", ex.StackTrace);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003AF4 File Offset: 0x00001CF4
		public override void WriteError(string format, params object[] args)
		{
			try
			{
				if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.m_TraceSwitch.TraceError && !string.IsNullOrEmpty(format))
				{
					this.WriteLine("ERROR", string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, args));
				}
			}
			catch (global::System.Exception ex)
			{
				this.WriteLine("INTERNAL", ex.Message);
				this.WriteLine("INTERNAL", format);
				this.WriteLine("INTERNAL", ex.StackTrace);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003B84 File Offset: 0x00001D84
		public override void WriteWarning(string format, params object[] args)
		{
			try
			{
				if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.m_TraceSwitch.TraceWarning && !string.IsNullOrEmpty(format))
				{
					this.WriteLine("WARNING", string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, args));
				}
			}
			catch (global::System.Exception ex)
			{
				this.WriteLine("INTERNAL", ex.Message);
				this.WriteLine("INTERNAL", format);
				this.WriteLine("INTERNAL", ex.StackTrace);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003C14 File Offset: 0x00001E14
		public override void WriteInfo(string format, params object[] args)
		{
			try
			{
				if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.m_TraceSwitch.TraceInfo && !string.IsNullOrEmpty(format))
				{
					this.WriteLine("INFO", string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, args));
				}
			}
			catch (global::System.Exception ex)
			{
				this.WriteLine("INTERNAL", ex.Message);
				this.WriteLine("INTERNAL", format);
				this.WriteLine("INTERNAL", ex.StackTrace);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003CA4 File Offset: 0x00001EA4
		public override void WriteVerbose(global::Motorola.Common.Communication.CommonUtil.TraceLogger.TraceLoggerStringBuilder errorBuilder)
		{
			try
			{
				if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.m_TraceSwitch.TraceVerbose && errorBuilder != null)
				{
					this.WriteLine("VERBOSE", errorBuilder());
				}
			}
			catch (global::System.Exception ex)
			{
				this.WriteLine("INTERNAL", ex.Message);
				this.WriteLine("INTERNAL", ex.StackTrace);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003D1C File Offset: 0x00001F1C
		public override void WriteVerbose(string format, params object[] args)
		{
			try
			{
				if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.m_TraceSwitch.TraceVerbose && !string.IsNullOrEmpty(format))
				{
					this.WriteLine("VERBOSE", string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, args));
				}
			}
			catch (global::System.Exception ex)
			{
				this.WriteLine("INTERNAL", ex.Message);
				this.WriteLine("INTERNAL", format);
				this.WriteLine("INTERNAL", ex.StackTrace);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003DAC File Offset: 0x00001FAC
		public override void WriteSensitive(string format, params object[] args)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003DB0 File Offset: 0x00001FB0
		private void WriteLine(string type, string msg)
		{
			lock (this.writeLock)
			{
				if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.m_TraceSwitch.Level != global::System.Diagnostics.TraceLevel.Off)
				{
					this.PreCheckForLogContent();
					string[] array = global::System.Environment.StackTrace.Split(new string[]
					{
						global::System.Environment.NewLine
					}, global::System.StringSplitOptions.RemoveEmptyEntries);
					if (array.Length >= 5)
					{
						global::System.Diagnostics.Trace.WriteLine(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0},[{1}],{2},\"{3}\",{4}", new object[]
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.GetCurrentTimeString(),
							global::System.Threading.Thread.CurrentThread.ManagedThreadId,
							type,
							msg,
							array[4]
						}));
					}
					else
					{
						global::System.Diagnostics.Trace.WriteLine(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0},[{1}],{2},\"{3}\",{4}", new object[]
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.GetCurrentTimeString(),
							global::System.Threading.Thread.CurrentThread.ManagedThreadId,
							type,
							type,
							msg
						}));
					}
				}
				if (type == "ERROR")
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.winEventLog.WriteError(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0},[{1}],{2},{3}\n {4}", new object[]
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.GetCurrentTimeString(),
						global::System.Threading.Thread.CurrentThread.ManagedThreadId,
						type,
						global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.processName,
						msg
					}));
				}
				else if (type == "WARNING")
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.winEventLog.WriteWarning(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0},[{1}],{2},{3}\n {4}", new object[]
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.GetCurrentTimeString(),
						global::System.Threading.Thread.CurrentThread.ManagedThreadId,
						type,
						global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.processName,
						msg
					}));
				}
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003FB0 File Offset: 0x000021B0
		private static string GetCurrentTimeString()
		{
			return global::System.DateTime.Now.ToString("[MM/dd/yy HH:mm:ss.fff]", global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003FDC File Offset: 0x000021DC
		private static string GetCurrentTimeStringForFileName()
		{
			return global::System.DateTime.Now.ToString("_MM_dd_yy_HH_mm_ss", global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004008 File Offset: 0x00002208
		protected virtual void Dispose(bool disposing)
		{
			lock (this.disposeLock)
			{
				if (disposing)
				{
				}
				if (this.listener != null)
				{
					global::System.Diagnostics.Trace.Listeners.Remove(this.listener);
					this.listener.Close();
					this.listener.Dispose();
					this.listener = null;
				}
				if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.winEventLog != null)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.winEventLog.Dispose();
					global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.winEventLog = null;
				}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000040B8 File Offset: 0x000022B8
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000049 RID: 73
		private const int LOG_FILE_MAX_SIZE = 52428800;

		// Token: 0x0400004A RID: 74
		private const int eventID = 49161;

		// Token: 0x0400004B RID: 75
		private static readonly global::System.Diagnostics.TraceSwitch m_TraceSwitch = new global::System.Diagnostics.TraceSwitch("CommonCommunicationTraceSwitch", "Common Communication Trace", "Off");

		// Token: 0x0400004C RID: 76
		private static global::Motorola.Common.Communication.CommonUtil.EventLogger winEventLog = new global::Motorola.Common.Communication.CommonUtil.EventLogger("Motorola Device Communication");

		// Token: 0x0400004D RID: 77
		private static string processName = global::System.Diagnostics.Process.GetCurrentProcess().ProcessName;

		// Token: 0x0400004E RID: 78
		private string LogFileName = string.Empty;

		// Token: 0x0400004F RID: 79
		private string logFilePath = string.Empty;

		// Token: 0x04000050 RID: 80
		private global::System.Diagnostics.TextWriterTraceListener listener = null;

		// Token: 0x04000051 RID: 81
		private object writeLock = new object();

		// Token: 0x04000052 RID: 82
		private object disposeLock = new object();
	}
}
