using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace ErrorLogging
{
	// Token: 0x02000006 RID: 6
	public class CLogApplicationError : global::ErrorLogging.ILogApplicationError
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000021BC File Offset: 0x000011BC
		public CLogApplicationError(string strProductName)
		{
			try
			{
				if (!global::System.Diagnostics.EventLog.SourceExists(strProductName))
				{
					global::System.Diagnostics.EventLog.CreateEventSource(strProductName, "");
					this.a = new global::System.Diagnostics.EventLog();
					this.a.Source = strProductName;
				}
				else
				{
					this.a = new global::System.Diagnostics.EventLog();
					this.a.Source = strProductName;
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000222C File Offset: 0x0000122C
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U4)]
		public uint LogApplicationError(uint uiError, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPTStr)] string strSource, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPTStr)] string strMessage, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPTStr)] string strStackTrace)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (false)
				{
				}
				if (true)
				{
				}
				switch (0)
				{
				}
				break;
			}
			if (this.a != null)
			{
				try
				{
					global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Motorola\\Trbo CPS");
					object value = registryKey.GetValue("ErrorLogLevel");
					uint num = (uint)((int)value);
					goto IL_4C;
				}
				catch (global::System.Exception)
				{
					uint num = 1U;
					goto IL_4C;
				}
				return 0U;
				try
				{
					IL_4C:
					for (;;)
					{
						uint num;
						uint num2 = num;
						int num3 = 7;
						for (;;)
						{
							global::System.Diagnostics.EventLogEntryType type;
							switch (num3)
							{
							case 0:
								goto IL_11A;
							case 1:
								type = global::System.Diagnostics.EventLogEntryType.Warning;
								num3 = 5;
								continue;
							case 2:
								goto IL_11A;
							case 3:
								goto IL_11A;
							case 4:
								goto IL_181;
							case 5:
								goto IL_11A;
							case 6:
								num3 = 1;
								continue;
							case 7:
								switch (num2)
								{
								case 1U:
									type = global::System.Diagnostics.EventLogEntryType.Error;
									num3 = 3;
									continue;
								case 2U:
									type = global::System.Diagnostics.EventLogEntryType.FailureAudit;
									num3 = 9;
									continue;
								case 3U:
									type = global::System.Diagnostics.EventLogEntryType.Information;
									num3 = 2;
									continue;
								case 4U:
									type = global::System.Diagnostics.EventLogEntryType.SuccessAudit;
									num3 = 0;
									continue;
								case 5U:
									type = global::System.Diagnostics.EventLogEntryType.Warning;
									num3 = 8;
									continue;
								default:
									num3 = 6;
									continue;
								}
								break;
							case 8:
								goto IL_11A;
							case 9:
								goto IL_11A;
							}
							break;
							IL_11A:
							string message = string.Concat(new string[]
							{
								uiError.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo),
								", ",
								strSource,
								", ",
								strMessage,
								", ",
								strStackTrace
							});
							this.a.WriteEntry(message, type, (int)uiError);
							num3 = 4;
						}
					}
					IL_181:
					return 0U;
				}
				catch (global::System.Exception)
				{
					return 0U;
				}
				return 1367U;
			}
			return 1367U;
		}

		// Token: 0x04000006 RID: 6
		private global::System.Diagnostics.EventLog a;
	}
}
