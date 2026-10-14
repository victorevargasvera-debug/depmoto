using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text.RegularExpressions;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000005 RID: 5
	public class FileAppender : global::Motorola.Common.LogUtility.IAppender, global::System.IDisposable
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000022F8 File Offset: 0x000004F8
		public FileAppender()
		{
			this.LoggingEvent += this.FileAppender_LoggingEvent;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000231D File Offset: 0x0000051D
		private void FileAppender_LoggingEvent(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			if (e.Level == global::Motorola.Common.LogUtility.LoggingLevel.EventInfo || e.Level == global::Motorola.Common.LogUtility.LoggingLevel.EventWarning || e.Level == global::Motorola.Common.LogUtility.LoggingLevel.EventError)
			{
				this.WriteWinEventLog(sender, e);
				return;
			}
			this.WriteFileLog(sender, e);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000234C File Offset: 0x0000054C
		protected void WriteWinEventLog(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			if (this.winEventLog == null)
			{
				try
				{
					if (!global::System.Diagnostics.EventLog.SourceExists(this.EventSource))
					{
						global::System.Diagnostics.EventLog.CreateEventSource(this.EventSource, this.EventLogName);
					}
					this.winEventLog = new global::System.Diagnostics.EventLog();
					this.winEventLog.Source = this.EventSource;
					this.winEventLog.Log = this.EventLogName;
				}
				catch
				{
					this.winEventLog = null;
				}
			}
			if (this.winEventLog != null)
			{
				if (e.Level == global::Motorola.Common.LogUtility.LoggingLevel.EventError)
				{
					this.winEventLog.WriteEntry(e.Message, global::System.Diagnostics.EventLogEntryType.Error);
					return;
				}
				if (e.Level == global::Motorola.Common.LogUtility.LoggingLevel.EventWarning)
				{
					this.winEventLog.WriteEntry(e.Message, global::System.Diagnostics.EventLogEntryType.Warning);
					return;
				}
				this.winEventLog.WriteEntry(e.Message, global::System.Diagnostics.EventLogEntryType.Information);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000241C File Offset: 0x0000061C
		protected void WriteFileLog(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			string text = this.ComposeLogFilePath(this.RootLogFolderPath, this.FileName, e.FileNameSuffix);
			if (!global::System.IO.Directory.Exists(global::System.IO.Path.GetDirectoryName(text)))
			{
				global::System.IO.Directory.CreateDirectory(global::System.IO.Path.GetDirectoryName(text));
				this.WriteEnvLogFile(global::System.IO.Path.GetDirectoryName(text));
			}
			bool flag = !global::System.IO.File.Exists(text);
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(text, true))
			{
				if (flag)
				{
					global::System.Security.AccessControl.FileSecurity accessControl = global::System.IO.File.GetAccessControl(text);
					global::System.Security.Principal.SecurityIdentifier identity = new global::System.Security.Principal.SecurityIdentifier(global::System.Security.Principal.WellKnownSidType.WorldSid, null);
					accessControl.AddAccessRule(new global::System.Security.AccessControl.FileSystemAccessRule(identity, global::System.Security.AccessControl.FileSystemRights.FullControl, global::System.Security.AccessControl.AccessControlType.Allow));
					global::System.IO.File.SetAccessControl(text, accessControl);
				}
				string loggerName = "Unknown Logger";
				global::Motorola.Common.LogUtility.LogImpl logImpl = sender as global::Motorola.Common.LogUtility.LogImpl;
				if (logImpl != null)
				{
					loggerName = logImpl.Name;
				}
				streamWriter.WriteLine(global::Motorola.Common.LogUtility.LoggerUtil.LogTitle(loggerName, e));
				streamWriter.WriteLine(global::Motorola.Common.LogUtility.LoggerUtil.LogBody(e));
				streamWriter.WriteLine("----------------------------------------");
			}
			this.SwitchFile(text);
			this.RemoveBackupFile(text);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002514 File Offset: 0x00000714
		protected void ClearSubscriber()
		{
			this.LoggingEvent -= this.FileAppender_LoggingEvent;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002528 File Offset: 0x00000728
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002530 File Offset: 0x00000730
		public string FileName { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002539 File Offset: 0x00000739
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002541 File Offset: 0x00000741
		public string SubFolderName { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000254A File Offset: 0x0000074A
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002552 File Offset: 0x00000752
		public int MaxSize { private get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000255B File Offset: 0x0000075B
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002563 File Offset: 0x00000763
		public int MaxBackup { private get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0000256C File Offset: 0x0000076C
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002574 File Offset: 0x00000774
		public string EventSource
		{
			get
			{
				return this.eventSource;
			}
			set
			{
				this.eventSource = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000257D File Offset: 0x0000077D
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002585 File Offset: 0x00000785
		public string EventLogName
		{
			get
			{
				return this.eventLog;
			}
			set
			{
				this.eventLog = value;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000258E File Offset: 0x0000078E
		public void Close()
		{
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600002A RID: 42 RVA: 0x00002590 File Offset: 0x00000790
		// (remove) Token: 0x0600002B RID: 43 RVA: 0x000025C8 File Offset: 0x000007C8
		public event global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> LoggingEvent;

		// Token: 0x0600002C RID: 44 RVA: 0x00002600 File Offset: 0x00000800
		public void DoAppend(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			if (this.LoggingEvent != null)
			{
				using (new global::Motorola.Common.LogUtility.FileLocker(this.ComposeLogFilePath(this.RootLogFolderPath, this.FileName, e.FileNameSuffix)))
				{
					this.LoggingEvent(sender, e);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000265C File Offset: 0x0000085C
		public bool IsEnabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000265F File Offset: 0x0000085F
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002667 File Offset: 0x00000867
		public string Name { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002670 File Offset: 0x00000870
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000026BA File Offset: 0x000008BA
		public string RootLogFolderPath
		{
			get
			{
				string text = string.Empty;
				if (!string.IsNullOrEmpty(this.rootLogFolderPath))
				{
					text = this.rootLogFolderPath;
				}
				else
				{
					text = global::Motorola.Common.LogUtility.Configurator.GetLogDirectory();
				}
				if (!string.IsNullOrEmpty(this.SubFolderName))
				{
					text = global::System.IO.Path.Combine(text, this.SubFolderName);
				}
				return text;
			}
			set
			{
				this.rootLogFolderPath = value;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000026C4 File Offset: 0x000008C4
		private void SwitchFile(string currLogFilePath)
		{
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(currLogFilePath);
			if (fileInfo.Length / 1024L / 1024L < (long)this.MaxSize)
			{
				return;
			}
			string backupFileName = this.GetBackupFileName(currLogFilePath);
			string directoryName = global::System.IO.Path.GetDirectoryName(currLogFilePath);
			global::System.IO.File.Move(currLogFilePath, global::System.IO.Path.Combine(directoryName, backupFileName));
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002714 File Offset: 0x00000914
		private void RemoveBackupFile(string currLogFilePath)
		{
			string fileName = global::System.IO.Path.GetFileName(currLogFilePath);
			string directoryName = global::System.IO.Path.GetDirectoryName(currLogFilePath);
			string[] files = global::System.IO.Directory.GetFiles(directoryName, fileName + "*");
			if (files.Length <= this.MaxBackup + 1)
			{
				return;
			}
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			foreach (string value in files)
			{
				arrayList.Add(value);
			}
			arrayList.Sort(new global::Motorola.Common.LogUtility.FileAppender.CompareFileByIndex(fileName));
			global::System.IO.File.Delete(arrayList[0].ToString());
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002798 File Offset: 0x00000998
		private string GetBackupFileName(string currLogFilePath)
		{
			int num = 0;
			string fileName = global::System.IO.Path.GetFileName(currLogFilePath);
			string directoryName = global::System.IO.Path.GetDirectoryName(currLogFilePath);
			string[] files = global::System.IO.Directory.GetFiles(directoryName, fileName + "*");
			foreach (string input in files)
			{
				global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(input, ".(?<index>\\d+)$");
				if (match.Success)
				{
					num = global::System.Math.Max(num, global::System.Convert.ToInt32(match.Groups["index"].Value, global::System.Globalization.CultureInfo.InvariantCulture));
				}
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
			{
				fileName,
				num + 1
			});
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002850 File Offset: 0x00000A50
		private void WriteEnvLogFile(string folderPath)
		{
			if (string.IsNullOrEmpty(folderPath))
			{
				return;
			}
			if (!global::System.IO.Directory.Exists(folderPath))
			{
				global::System.IO.Directory.CreateDirectory(folderPath);
			}
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(global::System.IO.Path.Combine(folderPath, "env.log"), false))
			{
				streamWriter.WriteLine("MachineName: [{0}]", global::System.Environment.MachineName);
				streamWriter.WriteLine("OSVersion: [{0}]", global::System.Environment.OSVersion);
				streamWriter.WriteLine("UserName: [{0}]", global::System.Environment.UserName);
				streamWriter.WriteLine("CLR Version: [{0}]", global::System.Environment.Version);
				streamWriter.WriteLine("CurrentDirectory: [{0}]", global::System.Environment.CurrentDirectory);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000028F4 File Offset: 0x00000AF4
		private string ComposeLogFilePath(string logRootFolder, string logFileName, string suffix)
		{
			string text = logFileName;
			if (!string.IsNullOrEmpty(suffix))
			{
				string directoryName = global::System.IO.Path.GetDirectoryName(logFileName);
				string fileNameWithoutExtension = global::System.IO.Path.GetFileNameWithoutExtension(logFileName);
				string extension = global::System.IO.Path.GetExtension(logFileName);
				text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}.{2}", new object[]
				{
					fileNameWithoutExtension,
					suffix.Replace(".", string.Empty),
					extension.Replace(".", string.Empty)
				});
				text = global::System.IO.Path.Combine(directoryName, text);
			}
			if (global::System.IO.Path.IsPathRooted(text))
			{
				return text;
			}
			if (!string.IsNullOrEmpty(global::System.IO.Path.GetDirectoryName(text)))
			{
				return global::System.IO.Path.GetFullPath(global::System.IO.Path.Combine(logRootFolder, text));
			}
			return global::System.IO.Path.GetFullPath(global::System.IO.Path.Combine(global::Motorola.Common.LogUtility.LoggerUtil.GetCurrentLogFolderPath(logRootFolder), text));
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000029A4 File Offset: 0x00000BA4
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000029B3 File Offset: 0x00000BB3
		protected virtual void Dispose(bool disposing)
		{
			if (this.disposed)
			{
				return;
			}
			if (disposing && this.winEventLog != null)
			{
				this.winEventLog.Dispose();
			}
			this.disposed = true;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000029DC File Offset: 0x00000BDC
		~FileAppender()
		{
			this.Dispose(false);
		}

		// Token: 0x04000007 RID: 7
		private string rootLogFolderPath = string.Empty;

		// Token: 0x04000008 RID: 8
		private global::System.Diagnostics.EventLog winEventLog;

		// Token: 0x04000009 RID: 9
		private string eventSource;

		// Token: 0x0400000A RID: 10
		private string eventLog;

		// Token: 0x0400000C RID: 12
		private bool disposed;

		// Token: 0x02000006 RID: 6
		private class CompareFileByIndex : global::System.Collections.IComparer
		{
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600003A RID: 58 RVA: 0x00002A0C File Offset: 0x00000C0C
			// (set) Token: 0x0600003B RID: 59 RVA: 0x00002A14 File Offset: 0x00000C14
			private string CurrFileName { get; set; }

			// Token: 0x0600003C RID: 60 RVA: 0x00002A1D File Offset: 0x00000C1D
			public CompareFileByIndex(string currFileName)
			{
				this.CurrFileName = currFileName;
			}

			// Token: 0x0600003D RID: 61 RVA: 0x00002A2C File Offset: 0x00000C2C
			public int Compare(object x, object y)
			{
				int num = this.FileName2Index(x.ToString());
				int num2 = this.FileName2Index(y.ToString());
				return num - num2;
			}

			// Token: 0x0600003E RID: 62 RVA: 0x00002A58 File Offset: 0x00000C58
			private int FileName2Index(string fileName)
			{
				int result;
				if (global::System.IO.Path.GetFileName(fileName).Equals(this.CurrFileName))
				{
					result = int.MaxValue;
				}
				else
				{
					string text = global::System.IO.Path.GetExtension(fileName);
					text = text.Remove(0, 1);
					result = int.Parse(text, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				return result;
			}
		}
	}
}
