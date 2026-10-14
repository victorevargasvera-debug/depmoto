using System;
using System.Diagnostics;
using System.Globalization;

namespace System.Data.SQLite
{
	// Token: 0x0200004B RID: 75
	public static class SQLiteLog
	{
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600035F RID: 863 RVA: 0x0001EF88 File Offset: 0x0001E388
		// (remove) Token: 0x06000360 RID: 864 RVA: 0x0001EFBC File Offset: 0x0001E3BC
		private static event global::System.Data.SQLite.SQLiteLogEventHandler _handlers;

		// Token: 0x06000361 RID: 865 RVA: 0x0001EFF0 File Offset: 0x0001E3F0
		public static void Initialize()
		{
			if (global::System.Data.SQLite.SQLite3.StaticIsInitialized())
			{
				return;
			}
			if (!global::System.AppDomain.CurrentDomain.IsDefaultAppDomain() && global::System.Environment.GetEnvironmentVariable("Force_SQLiteLog") == null)
			{
				return;
			}
			lock (global::System.Data.SQLite.SQLiteLog.syncRoot)
			{
				if (global::System.Data.SQLite.SQLiteLog._domainUnload == null)
				{
					global::System.Data.SQLite.SQLiteLog._domainUnload = new global::System.EventHandler(global::System.Data.SQLite.SQLiteLog.DomainUnload);
					global::System.AppDomain.CurrentDomain.DomainUnload += global::System.Data.SQLite.SQLiteLog._domainUnload;
				}
				if (global::System.Data.SQLite.SQLiteLog._sql == null)
				{
					global::System.Data.SQLite.SQLiteLog._sql = new global::System.Data.SQLite.SQLite3(global::System.Data.SQLite.SQLiteDateFormats.ISO8601, global::System.DateTimeKind.Unspecified, null, global::System.IntPtr.Zero, null, false);
				}
				if (global::System.Data.SQLite.SQLiteLog._callback == null)
				{
					global::System.Data.SQLite.SQLiteLog._callback = new global::System.Data.SQLite.SQLiteLogCallback(global::System.Data.SQLite.SQLiteLog.LogCallback);
					global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.SQLiteLog._sql.SetLogCallback(global::System.Data.SQLite.SQLiteLog._callback);
					if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
					{
						throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, "Failed to initialize logging.");
					}
				}
				global::System.Data.SQLite.SQLiteLog._enabled = true;
				global::System.Data.SQLite.SQLiteLog.AddDefaultHandler();
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0001F0DC File Offset: 0x0001E4DC
		private static void DomainUnload(object sender, global::System.EventArgs e)
		{
			lock (global::System.Data.SQLite.SQLiteLog.syncRoot)
			{
				global::System.Data.SQLite.SQLiteLog.RemoveDefaultHandler();
				global::System.Data.SQLite.SQLiteLog._enabled = false;
				if (global::System.Data.SQLite.SQLiteLog._sql != null)
				{
					global::System.Data.SQLite.SQLiteErrorCode sqliteErrorCode = global::System.Data.SQLite.SQLiteLog._sql.Shutdown();
					if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
					{
						throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, "Failed to shutdown interface.");
					}
					sqliteErrorCode = global::System.Data.SQLite.SQLiteLog._sql.SetLogCallback(null);
					if (sqliteErrorCode != global::System.Data.SQLite.SQLiteErrorCode.Ok)
					{
						throw new global::System.Data.SQLite.SQLiteException(sqliteErrorCode, "Failed to shutdown logging.");
					}
				}
				if (global::System.Data.SQLite.SQLiteLog._callback != null)
				{
					global::System.Data.SQLite.SQLiteLog._callback = null;
				}
				if (global::System.Data.SQLite.SQLiteLog._domainUnload != null)
				{
					global::System.AppDomain.CurrentDomain.DomainUnload -= global::System.Data.SQLite.SQLiteLog._domainUnload;
					global::System.Data.SQLite.SQLiteLog._domainUnload = null;
				}
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000363 RID: 867 RVA: 0x0001F194 File Offset: 0x0001E594
		// (remove) Token: 0x06000364 RID: 868 RVA: 0x0001F1E8 File Offset: 0x0001E5E8
		public static event global::System.Data.SQLite.SQLiteLogEventHandler Log
		{
			add
			{
				lock (global::System.Data.SQLite.SQLiteLog.syncRoot)
				{
					global::System.Data.SQLite.SQLiteLog._handlers -= value;
					global::System.Data.SQLite.SQLiteLog._handlers += value;
				}
			}
			remove
			{
				lock (global::System.Data.SQLite.SQLiteLog.syncRoot)
				{
					global::System.Data.SQLite.SQLiteLog._handlers -= value;
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0001F234 File Offset: 0x0001E634
		// (set) Token: 0x06000366 RID: 870 RVA: 0x0001F280 File Offset: 0x0001E680
		public static bool Enabled
		{
			get
			{
				bool enabled;
				lock (global::System.Data.SQLite.SQLiteLog.syncRoot)
				{
					enabled = global::System.Data.SQLite.SQLiteLog._enabled;
				}
				return enabled;
			}
			set
			{
				lock (global::System.Data.SQLite.SQLiteLog.syncRoot)
				{
					global::System.Data.SQLite.SQLiteLog._enabled = value;
				}
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0001F2CC File Offset: 0x0001E6CC
		public static void LogMessage(string message)
		{
			global::System.Data.SQLite.SQLiteLog.LogMessage(null, message);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0001F2E0 File Offset: 0x0001E6E0
		public static void LogMessage(global::System.Data.SQLite.SQLiteErrorCode errorCode, string message)
		{
			global::System.Data.SQLite.SQLiteLog.LogMessage(errorCode, message);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0001F2FC File Offset: 0x0001E6FC
		public static void LogMessage(int errorCode, string message)
		{
			global::System.Data.SQLite.SQLiteLog.LogMessage(errorCode, message);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0001F318 File Offset: 0x0001E718
		private static void LogMessage(object errorCode, string message)
		{
			bool enabled;
			global::System.Data.SQLite.SQLiteLogEventHandler sqliteLogEventHandler;
			lock (global::System.Data.SQLite.SQLiteLog.syncRoot)
			{
				enabled = global::System.Data.SQLite.SQLiteLog._enabled;
				if (global::System.Data.SQLite.SQLiteLog._handlers != null)
				{
					sqliteLogEventHandler = (global::System.Data.SQLite.SQLiteLog._handlers.Clone() as global::System.Data.SQLite.SQLiteLogEventHandler);
				}
				else
				{
					sqliteLogEventHandler = null;
				}
			}
			if (enabled && sqliteLogEventHandler != null)
			{
				sqliteLogEventHandler(null, new global::System.Data.SQLite.LogEventArgs(global::System.IntPtr.Zero, errorCode, message, null));
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0001F398 File Offset: 0x0001E798
		private static void InitializeDefaultHandler()
		{
			lock (global::System.Data.SQLite.SQLiteLog.syncRoot)
			{
				if (global::System.Data.SQLite.SQLiteLog._defaultHandler == null)
				{
					global::System.Data.SQLite.SQLiteLog._defaultHandler = new global::System.Data.SQLite.SQLiteLogEventHandler(global::System.Data.SQLite.SQLiteLog.LogEventHandler);
				}
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0001F3F8 File Offset: 0x0001E7F8
		public static void AddDefaultHandler()
		{
			global::System.Data.SQLite.SQLiteLog.InitializeDefaultHandler();
			global::System.Data.SQLite.SQLiteLog.Log += global::System.Data.SQLite.SQLiteLog._defaultHandler;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0001F414 File Offset: 0x0001E814
		public static void RemoveDefaultHandler()
		{
			global::System.Data.SQLite.SQLiteLog.InitializeDefaultHandler();
			global::System.Data.SQLite.SQLiteLog.Log -= global::System.Data.SQLite.SQLiteLog._defaultHandler;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0001F430 File Offset: 0x0001E830
		private static void LogCallback(global::System.IntPtr pUserData, int errorCode, global::System.IntPtr pMessage)
		{
			bool enabled;
			global::System.Data.SQLite.SQLiteLogEventHandler sqliteLogEventHandler;
			lock (global::System.Data.SQLite.SQLiteLog.syncRoot)
			{
				enabled = global::System.Data.SQLite.SQLiteLog._enabled;
				if (global::System.Data.SQLite.SQLiteLog._handlers != null)
				{
					sqliteLogEventHandler = (global::System.Data.SQLite.SQLiteLog._handlers.Clone() as global::System.Data.SQLite.SQLiteLogEventHandler);
				}
				else
				{
					sqliteLogEventHandler = null;
				}
			}
			if (enabled && sqliteLogEventHandler != null)
			{
				sqliteLogEventHandler(null, new global::System.Data.SQLite.LogEventArgs(pUserData, errorCode, global::System.Data.SQLite.SQLiteConvert.UTF8ToString(pMessage, -1), null));
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0001F4B8 File Offset: 0x0001E8B8
		private static void LogEventHandler(object sender, global::System.Data.SQLite.LogEventArgs e)
		{
			if (e == null)
			{
				return;
			}
			string text = e.Message;
			if (text == null)
			{
				text = "<null>";
			}
			else
			{
				text = text.Trim();
				if (text.Length == 0)
				{
					text = "<empty>";
				}
			}
			object errorCode = e.ErrorCode;
			bool flag = false;
			if (errorCode is global::System.Data.SQLite.SQLiteErrorCode)
			{
				flag = ((global::System.Data.SQLite.SQLiteErrorCode)errorCode == global::System.Data.SQLite.SQLiteErrorCode.Ok);
			}
			else if (errorCode is int)
			{
				flag = ((int)errorCode == 0);
			}
			global::System.Diagnostics.Trace.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "SQLite {0} ({1}): {2}", new object[]
			{
				flag ? "message" : "error",
				errorCode,
				text
			}));
		}

		// Token: 0x040001A0 RID: 416
		private static object syncRoot = new object();

		// Token: 0x040001A1 RID: 417
		private static global::System.EventHandler _domainUnload;

		// Token: 0x040001A3 RID: 419
		private static global::System.Data.SQLite.SQLiteLogEventHandler _defaultHandler;

		// Token: 0x040001A4 RID: 420
		private static global::System.Data.SQLite.SQLiteLogCallback _callback;

		// Token: 0x040001A5 RID: 421
		private static global::System.Data.SQLite.SQLiteBase _sql;

		// Token: 0x040001A6 RID: 422
		private static bool _enabled;
	}
}
