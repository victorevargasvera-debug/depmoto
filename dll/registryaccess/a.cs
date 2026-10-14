using System;
using custom_exception;
using Microsoft.Win32;

namespace RegistryAccess
{
	// Token: 0x0200000E RID: 14
	internal class a
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00008BE4 File Offset: 0x00007BE4
		internal static void a(string A_0, string A_1, object A_2, string A_3, uint A_4)
		{
			switch (0)
			{
			default:
			{
				uint num;
				string message;
				for (;;)
				{
					num = 0U;
					int num2 = 0;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (!string.IsNullOrEmpty(A_3))
							{
								num2 = 8;
								continue;
							}
							goto IL_B2;
						case 1:
							goto IL_68;
						case 2:
							try
							{
								global::Microsoft.Win32.RegistryKey registryKey = registryKey.OpenSubKey(A_0, true);
								registryKey.SetValue(A_1, A_2);
								goto IL_92;
							}
							catch (global::System.NullReferenceException)
							{
								num = 1368U;
								message = string.Format("rk is null because the specified registry key path is incorrect.: strRegPath: {0}, strRegName: {1}, strRegSubPath: {2}", A_0, A_1, A_3);
								goto IL_92;
							}
							catch (global::System.ArgumentException)
							{
								num = 1369U;
								message = string.Format("GetValue( ) returns null: strRegPath: {0}, strRegName: {1}, strRegSubPath: {2}", A_0, A_1, A_3);
								goto IL_92;
							}
							catch (global::System.FormatException)
							{
								num = 1370U;
								message = string.Format("can't cast a data type to a uncompatible data type: strRegPath: {0}, strRegName: {1}, strRegSubPath: {2}", A_0, A_1, A_3);
								goto IL_92;
							}
							goto IL_1BE;
							IL_92:
							num2 = 3;
							continue;
						case 3:
							if (num != 0U)
							{
								num2 = 4;
								continue;
							}
							return;
						case 4:
							goto IL_B0;
						case 5:
						{
							global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser;
							num2 = 9;
							continue;
						}
						case 6:
							if (true)
							{
							}
							num2 = 5;
							continue;
						case 7:
							IL_E0:
							switch (A_4)
							{
							case 1U:
							{
								global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.LocalMachine;
								num2 = 11;
								continue;
							}
							case 2U:
							{
								global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser;
								num2 = 1;
								continue;
							}
							default:
								num2 = 6;
								continue;
							}
							break;
						case 8:
							goto IL_1BE;
						case 9:
							goto IL_68;
						case 10:
							goto IL_B2;
						case 11:
							goto IL_68;
						}
						break;
						IL_68:
						message = string.Empty;
						num2 = 2;
						continue;
						IL_B2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E0;
						default:
						{
							if (false)
							{
							}
							global::Microsoft.Win32.RegistryKey registryKey = null;
							num2 = 7;
							continue;
						}
						}
						IL_1BE:
						A_0 = A_0 + "\\" + A_3;
						num2 = 10;
					}
				}
				IL_B0:
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, "RegistryAccess.CRegIO", "SetRegValue", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(message);
				throw ex;
			}
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00008E18 File Offset: 0x00007E18
		internal static void a(string A_0, string A_1, out object A_2, string A_3, uint A_4)
		{
			switch (0)
			{
			default:
			{
				global::custom_exception.CCustomException ex;
				string text;
				for (;;)
				{
					A_2 = null;
					int num = 0;
					for (;;)
					{
						global::Microsoft.Win32.RegistryKey registryKey;
						bool flag;
						switch (num)
						{
						case 0:
							if (!string.IsNullOrEmpty(A_3))
							{
								num = 1;
								continue;
							}
							goto IL_23E;
						case 1:
							goto IL_20B;
						case 2:
						{
							uint num2;
							ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, "RegistryAccess.CRegIO", "GetRegValue", global::System.Environment.StackTrace.ToString());
							num = 12;
							continue;
						}
						case 3:
							try
							{
								for (;;)
								{
									registryKey = global::Microsoft.Win32.Registry.LocalMachine;
									registryKey.OpenSubKey(A_0);
									A_2 = registryKey.GetValue(A_1);
									num = 0;
									for (;;)
									{
										switch (num)
										{
										case 0:
											if (A_2 == null)
											{
												num = 2;
												continue;
											}
											goto IL_2D9;
										case 1:
											goto IL_2E2;
										case 2:
										{
											uint num2 = 1369U;
											text = string.Format("GetValue( ) returns null: strRegPath: {0}, strRegName: {1}, strRegSubPath: {2}", A_0, A_1, A_3);
											num = 3;
											continue;
										}
										case 3:
											goto IL_2D9;
										}
										break;
										IL_2D9:
										num = 1;
									}
								}
								IL_2E2:
								goto IL_9C;
							}
							catch (global::System.NullReferenceException)
							{
								uint num2 = 1368U;
								text = string.Format("rk is null because the specified registry key path is incorrect: strRegPath: {0}, strRegName: {1}, strRegSubPath: {2}", A_0, A_1, A_3);
								goto IL_9C;
							}
							catch (global::System.ArgumentException)
							{
								uint num2 = 1369U;
								text = string.Format("GetValue( ) returns null: strRegPath: {0}, strRegName: {1}, strRegSubPath: {2}", A_0, A_1, A_3);
								goto IL_9C;
							}
							catch (global::System.FormatException)
							{
								uint num2 = 1370U;
								text = string.Format("can't cast a data type to a uncompatible data type: strRegPath: {0}, strRegName: {1}, strRegSubPath: {2}", A_0, A_1, A_3);
								goto IL_9C;
							}
							goto IL_335;
							IL_9C:
							num = 11;
							continue;
						case 4:
							text = string.Format("strRegPath: {0}, strRegName: {1}, strRegSubPath: {2}", A_0, A_1, A_3);
							num = 13;
							continue;
						case 5:
							goto IL_335;
						case 6:
						{
							if (flag)
							{
								num = 17;
								continue;
							}
							uint num2 = 0U;
							text = string.Empty;
							num = 3;
							continue;
						}
						case 7:
							goto IL_335;
						case 8:
							goto IL_23E;
						case 9:
							switch (A_4)
							{
							case 1U:
								registryKey = global::Microsoft.Win32.Registry.LocalMachine;
								num = 10;
								continue;
							case 2U:
								registryKey = global::Microsoft.Win32.Registry.CurrentUser;
								num = 5;
								continue;
							default:
								num = 16;
								continue;
							}
							break;
						case 10:
							goto IL_335;
						case 11:
						{
							uint num2;
							if (num2 != 0U)
							{
								num = 2;
								continue;
							}
							return;
						}
						case 12:
							if (string.IsNullOrEmpty(text))
							{
								num = 4;
								continue;
							}
							goto IL_17F;
						case 13:
							goto IL_F9;
						case 14:
							if (true)
							{
							}
							registryKey = global::Microsoft.Win32.Registry.CurrentUser;
							num = 7;
							continue;
						case 15:
							try
							{
								for (;;)
								{
									registryKey = registryKey.OpenSubKey(A_0);
									A_2 = registryKey.GetValue(A_1);
									num = 3;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_1F5;
										case 1:
											goto IL_1FE;
										case 2:
											flag = false;
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												continue;
											default:
												if (false)
												{
												}
												num = 0;
												continue;
											}
											break;
										case 3:
											if (A_2 == null)
											{
												num = 2;
												continue;
											}
											goto IL_1F5;
										}
										break;
										IL_1F5:
										num = 1;
									}
								}
								IL_1FE:
								goto IL_FE;
							}
							catch (global::System.Exception)
							{
								flag = false;
								goto IL_FE;
							}
							goto IL_20B;
							IL_FE:
							num = 6;
							continue;
						case 16:
							num = 14;
							continue;
						case 17:
							return;
						}
						break;
						IL_20B:
						A_0 = A_0 + "\\" + A_3;
						num = 8;
						continue;
						IL_23E:
						registryKey = null;
						num = 9;
						continue;
						IL_335:
						flag = true;
						num = 15;
					}
				}
				IL_F9:
				IL_17F:
				ex.AddErrorMessage(text);
				throw ex;
			}
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000091BC File Offset: 0x000081BC
		internal static global::Microsoft.Win32.RegistryKey d(string A_0, string A_1)
		{
			switch (0)
			{
			default:
			{
				global::Microsoft.Win32.RegistryKey registryKey;
				uint num;
				string message;
				for (;;)
				{
					registryKey = null;
					num = 0U;
					string text = A_0 + "\\" + A_1;
					message = string.Empty;
					int num2 = 0;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							try
							{
								global::Microsoft.Win32.RegistryKey result;
								for (;;)
								{
									IL_CB:
									registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(text);
									num2 = 0;
									for (;;)
									{
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_117;
										default:
											if (false)
											{
											}
											switch (num2)
											{
											case 0:
												if (registryKey != null)
												{
													num2 = 3;
													continue;
												}
												num = 1374U;
												message = string.Format("objRegKey is null: strKeyPathName: {0}", text);
												num2 = 2;
												continue;
											case 1:
												goto IL_FA;
											case 2:
												goto IL_117;
											case 3:
												result = registryKey;
												num2 = 1;
												continue;
											}
											goto IL_CB;
										}
									}
								}
								IL_FA:
								return result;
								IL_117:
								goto IL_7C;
							}
							catch (global::System.Exception ex)
							{
								num = 1374U;
								message = string.Format("objRegKey is null: strKeyPathName: {0}", text);
								global::custom_exception.CCustomException.AddOtherErrorMessage(message, ex);
								goto IL_7C;
							}
							goto IL_13D;
							IL_7C:
							num2 = 2;
							continue;
						case 1:
							goto IL_94;
						case 2:
							if (num != 0U)
							{
								num2 = 1;
								continue;
							}
							goto IL_13D;
						}
						break;
					}
				}
				IL_94:
				global::custom_exception.CCustomException ex2 = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, "RegistryAccess.CRegIO", "CreateRegKey", global::System.Environment.StackTrace.ToString());
				ex2.AddErrorMessage(message);
				throw ex2;
				IL_13D:
				if (true)
				{
				}
				return registryKey;
			}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00009324 File Offset: 0x00008324
		internal static void c(string A_0, string A_1)
		{
			try
			{
				for (;;)
				{
					switch (0)
					{
					default:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_24;
						}
						break;
					}
				}
				IL_24:
				if (false)
				{
				}
				global::Microsoft.Win32.Registry.CurrentUser.OpenSubKey(A_0, true).CreateSubKey(A_1);
				goto IL_9D;
			}
			catch (global::System.Exception)
			{
				goto IL_9D;
			}
			goto IL_42;
			int num;
			string name;
			string name2;
			int num2;
			string[] array;
			for (;;)
			{
				IL_44:
				bool flag;
				switch (num)
				{
				case 1:
					if (!flag)
					{
						num = 0;
						continue;
					}
					goto IL_CF;
				case 2:
					return;
				case 3:
					try
					{
						for (;;)
						{
							object value = global::Microsoft.Win32.Registry.CurrentUser.OpenSubKey(name).GetValue(name2);
							num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_18B;
								case 1:
									flag = false;
									num = 0;
									continue;
								case 2:
									if (value == null)
									{
										num = 1;
										continue;
									}
									goto IL_18B;
								case 3:
									goto IL_194;
								}
								break;
								IL_18B:
								num = 3;
							}
						}
						IL_194:
						goto IL_ED;
					}
					catch (global::System.Exception)
					{
						flag = false;
						goto IL_ED;
					}
					goto IL_1A2;
					IL_ED:
					num = 1;
					continue;
				case 4:
					if (true)
					{
					}
					if (num2 >= array.Length)
					{
						num = 2;
						continue;
					}
					goto IL_1A2;
				case 5:
					goto IL_CF;
				case 6:
					goto IL_10E;
				case 7:
					goto IL_10E;
				}
				break;
				IL_CF:
				num2++;
				num = 6;
				continue;
				IL_10E:
				num = 4;
				continue;
				IL_1A2:
				name2 = array[num2];
				flag = true;
				num = 3;
			}
			IL_42:
			object value2 = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(name).GetValue(name2);
			global::Microsoft.Win32.Registry.CurrentUser.OpenSubKey(name, true).SetValue(name2, value2);
			num = 5;
			goto IL_44;
			IL_9D:
			name = A_0 + "\\" + A_1;
			string[] valueNames = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(name).GetValueNames();
			array = valueNames;
			num2 = 0;
			num = 7;
			goto IL_44;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00009508 File Offset: 0x00008508
		internal static void b(string A_0, string A_1)
		{
			try
			{
				switch (0)
				{
				default:
					global::Microsoft.Win32.Registry.CurrentUser.OpenSubKey(A_0, true).CreateSubKey(A_1);
					goto IL_44;
				}
			}
			catch (global::System.Exception)
			{
				goto IL_44;
			}
			goto Block_1;
			int num;
			int num2;
			string[] array;
			string text;
			for (;;)
			{
				IL_46:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (num2 >= array.Length)
					{
						num = 0;
						continue;
					}
					text = array[num2];
					num = 4;
					continue;
				case 2:
					goto IL_A1;
				case 3:
					goto IL_A1;
				case 4:
					goto IL_107;
				}
				goto IL_61;
				IL_A1:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_44;
				default:
					if (false)
					{
					}
					num = 1;
					break;
				}
			}
			return;
			IL_107:
			Block_1:
			string text2;
			try
			{
				global::Microsoft.Win32.Registry.CurrentUser.OpenSubKey(text2, true).CreateSubKey(text);
				goto IL_DB;
			}
			catch (global::System.Exception)
			{
				goto IL_DB;
			}
			goto IL_44;
			IL_DB:
			global::RegistryAccess.a.c(text2, text);
			num2++;
			num = 2;
			goto IL_46;
			IL_44:
			IL_61:
			if (true)
			{
			}
			text2 = A_0 + "\\" + A_1;
			string[] subKeyNames = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(text2).GetSubKeyNames();
			array = subKeyNames;
			num2 = 0;
			num = 3;
			goto IL_46;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00009640 File Offset: 0x00008640
		internal static void a(string A_0, string A_1)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					string text = A_0 + "\\" + A_1;
					global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(text);
					global::RegistryAccess.a.c(A_0, A_1);
					string[] subKeyNames = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(text).GetSubKeyNames();
					string[] array = subKeyNames;
					int num = 0;
					if (true)
					{
					}
					int num2 = 2;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
							if (num >= array.Length)
							{
								num2 = 0;
								continue;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								if (false)
								{
								}
								string a_ = array[num];
								global::RegistryAccess.a.a(text, a_);
								num++;
								num2 = 3;
								continue;
							}
							}
							break;
						case 2:
							goto IL_70;
						case 3:
							goto IL_70;
						}
						break;
						IL_70:
						num2 = 1;
					}
				}
				return;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00009734 File Offset: 0x00008734
		// Note: this type is marked as 'beforefieldinit'.
		static a()
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
			global::RegistryAccess.a.a6 = global::RegistryAccess.CRegistryAccess.e + "\\Recent File List";
			global::RegistryAccess.a.a7 = global::RegistryAccess.CRegistryAccess.e + "\\No Show Warning";
			global::RegistryAccess.a.a8 = global::RegistryAccess.CRegistryAccess.e + "\\Settings";
			global::RegistryAccess.a.a9 = global::RegistryAccess.CRegistryAccess.e + "\\Views";
			global::RegistryAccess.a.ba = global::RegistryAccess.CRegistryAccess.e + "\\Language";
			global::RegistryAccess.a.bb = global::RegistryAccess.CRegistryAccess.e + "\\Packages";
		}

		// Token: 0x0400001B RID: 27
		internal const uint a = 1U;

		// Token: 0x0400001C RID: 28
		internal const uint b = 2U;

		// Token: 0x0400001D RID: 29
		internal const string c = "TransmitOffset";

		// Token: 0x0400001E RID: 30
		internal const string d = "CurrentLanguage";

		// Token: 0x0400001F RID: 31
		internal const string e = "CurrentView";

		// Token: 0x04000020 RID: 32
		internal const string f = "MaxEntryMRU";

		// Token: 0x04000021 RID: 33
		internal const int g = 8;

		// Token: 0x04000022 RID: 34
		internal const string h = "ShowContextHelp";

		// Token: 0x04000023 RID: 35
		internal const string i = "DefaultFolderPath";

		// Token: 0x04000024 RID: 36
		internal const string j = "InstallPath";

		// Token: 0x04000025 RID: 37
		internal const string k = "XferFolderPath";

		// Token: 0x04000026 RID: 38
		internal const string l = "ViewFolderPath";

		// Token: 0x04000027 RID: 39
		internal const string m = "PlaySound";

		// Token: 0x04000028 RID: 40
		internal const string n = "views";

		// Token: 0x04000029 RID: 41
		internal const string o = "CloneRadioIdentity";

		// Token: 0x0400002A RID: 42
		internal const string p = "SoftwareSystemKeyLocation";

		// Token: 0x0400002B RID: 43
		internal const string q = "TcpPort";

		// Token: 0x0400002C RID: 44
		internal const string r = "VAWorkerLocation";

		// Token: 0x0400002D RID: 45
		internal const string s = "VAExportLocation";

		// Token: 0x0400002E RID: 46
		internal const string t = "DatabasePath";

		// Token: 0x0400002F RID: 47
		internal const string u = "LogDigitalVoting";

		// Token: 0x04000030 RID: 48
		internal const string v = "EmailNotification";

		// Token: 0x04000031 RID: 49
		internal const string w = "ColumnEnable";

		// Token: 0x04000032 RID: 50
		internal const string x = "Controller";

		// Token: 0x04000033 RID: 51
		internal const string y = "Authentication";

		// Token: 0x04000034 RID: 52
		internal const string z = "SourcePort";

		// Token: 0x04000035 RID: 53
		internal const string aa = "KeepAlive";

		// Token: 0x04000036 RID: 54
		internal const string ab = "AppID";

		// Token: 0x04000037 RID: 55
		internal const string ac = "Connection";

		// Token: 0x04000038 RID: 56
		internal const string ad = "AutoReg";

		// Token: 0x04000039 RID: 57
		internal const string ae = "RetryTimer";

		// Token: 0x0400003A RID: 58
		internal const string af = "HasConfigured";

		// Token: 0x0400003B RID: 59
		internal const string ag = "HidenWhenMinimize";

		// Token: 0x0400003C RID: 60
		internal const string ah = "DiagnosticLogging";

		// Token: 0x0400003D RID: 61
		internal const string ai = "DiagnosticInterval";

		// Token: 0x0400003E RID: 62
		internal const string aj = "ImageResource";

		// Token: 0x0400003F RID: 63
		internal const string ak = "Height";

		// Token: 0x04000040 RID: 64
		internal const string al = "Width";

		// Token: 0x04000041 RID: 65
		internal const string am = "Left";

		// Token: 0x04000042 RID: 66
		internal const string an = "Top";

		// Token: 0x04000043 RID: 67
		internal const string ao = "FormWindowState";

		// Token: 0x04000044 RID: 68
		internal const string ap = "Basic_View";

		// Token: 0x04000045 RID: 69
		internal const string aq = "Expert_View";

		// Token: 0x04000046 RID: 70
		internal const string ar = "ViewName";

		// Token: 0x04000047 RID: 71
		internal const string @as = "ViewResource";

		// Token: 0x04000048 RID: 72
		internal const string at = "DisplayName";

		// Token: 0x04000049 RID: 73
		internal const string au = "GUIResource";

		// Token: 0x0400004A RID: 74
		internal const string av = "HelpFileName";

		// Token: 0x0400004B RID: 75
		internal const string aw = "HelpXMLFileName";

		// Token: 0x0400004C RID: 76
		internal const string ax = "RightToLeftLayout";

		// Token: 0x0400004D RID: 77
		internal const string ay = "DealerInfoLeft";

		// Token: 0x0400004E RID: 78
		internal const string az = "DealerInfoMiddle";

		// Token: 0x0400004F RID: 79
		internal const string a0 = "DealerInfoRight";

		// Token: 0x04000050 RID: 80
		internal const string a1 = "LanguageName";

		// Token: 0x04000051 RID: 81
		internal const string a2 = "Title";

		// Token: 0x04000052 RID: 82
		internal const string a3 = "Type";

		// Token: 0x04000053 RID: 83
		internal const string a4 = "Region";

		// Token: 0x04000054 RID: 84
		internal const string a5 = "Path";

		// Token: 0x04000055 RID: 85
		internal static string a6;

		// Token: 0x04000056 RID: 86
		internal static string a7;

		// Token: 0x04000057 RID: 87
		internal static string a8;

		// Token: 0x04000058 RID: 88
		internal static string a9;

		// Token: 0x04000059 RID: 89
		internal static string ba;

		// Token: 0x0400005A RID: 90
		internal static string bb;
	}
}
