using System;
using System.Globalization;
using custom_exception;
using Microsoft.Win32;

namespace RegistryAccess
{
	// Token: 0x0200000C RID: 12
	public class CRegistryAccess : global::RegistryAccess.IRegistryAccess
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00006F50 File Offset: 0x00005F50
		public CRegistryAccess(global::RegistryAccess.CRegistryAccess.ProductName produce)
		{
			global::RegistryAccess.CRegistryAccess.g = produce;
			global::RegistryAccess.CRegistryAccess.f = global::RegistryAccess.CRegistryAccess.g.ToString().Replace("_", " ");
			global::RegistryAccess.CRegistryAccess.e = "Software\\Motorola\\" + global::RegistryAccess.CRegistryAccess.f;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006FA0 File Offset: 0x00005FA0
		public void VerifyUserProfile()
		{
			try
			{
				for (;;)
				{
					global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(global::RegistryAccess.CRegistryAccess.e);
					int num = 11;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_187;
						case 1:
							goto IL_187;
						case 2:
							goto IL_187;
						case 3:
							if (global::RegistryAccess.CRegistryAccess.g == global::RegistryAccess.CRegistryAccess.ProductName.MOTOTRBO_DepotTool)
							{
								num = 10;
								continue;
							}
							num = 13;
							continue;
						case 4:
							this.e();
							num = 14;
							continue;
						case 5:
							IL_CC:
							global::RegistryAccess.CRegistryAccess.d();
							global::RegistryAccess.CRegistryAccess.c();
							global::RegistryAccess.CRegistryAccess.a();
							global::RegistryAccess.CRegistryAccess.b();
							num = 2;
							continue;
						case 6:
							goto IL_1C0;
						case 7:
							this.f();
							this.h();
							num = 1;
							continue;
						case 8:
							goto IL_187;
						case 9:
							if (global::RegistryAccess.CRegistryAccess.g == global::RegistryAccess.CRegistryAccess.ProductName.MOTOTRBO_RDAC)
							{
								num = 5;
								continue;
							}
							num = 12;
							continue;
						case 10:
							this.e();
							num = 0;
							continue;
						case 11:
							if (global::RegistryAccess.CRegistryAccess.g == global::RegistryAccess.CRegistryAccess.ProductName.MOTOTRBO_CPS)
							{
								num = 15;
								continue;
							}
							if (true)
							{
							}
							num = 9;
							continue;
						case 12:
							if (global::RegistryAccess.CRegistryAccess.g == global::RegistryAccess.CRegistryAccess.ProductName.MOTOTRBO_Tuner)
							{
								num = 7;
								continue;
							}
							num = 3;
							continue;
						case 13:
							if (global::RegistryAccess.CRegistryAccess.g == global::RegistryAccess.CRegistryAccess.ProductName.MOTOTRBO_AirTracer)
							{
								num = 4;
								continue;
							}
							goto IL_187;
						case 14:
							goto IL_187;
						case 15:
							this.i();
							this.h();
							num = 8;
							continue;
						}
						break;
						IL_187:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CC;
						default:
							if (false)
							{
							}
							this.k();
							this.l();
							this.g();
							num = 6;
							break;
						}
					}
				}
				IL_1C0:;
			}
			catch (global::System.Exception innerException)
			{
				uint num2 = 1375U;
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "VerifyUserProfile", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(innerException);
				throw ex;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000071CC File Offset: 0x000061CC
		internal void i()
		{
			for (;;)
			{
				object obj = null;
				global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(global::RegistryAccess.CRegistryAccess.e);
				obj = registryKey.GetValue("CurrentLanguage");
				int num = 37;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_15A;
					case 1:
						goto IL_1E3;
					case 2:
						if (obj != null)
						{
							num = 4;
							continue;
						}
						goto IL_455;
					case 3:
						goto IL_125;
					case 4:
						num = 28;
						continue;
					case 5:
						goto IL_3F0;
					case 6:
						goto IL_515;
					case 7:
						if (obj != null)
						{
							num = 24;
							continue;
						}
						goto IL_3F0;
					case 8:
						if (obj == null)
						{
							num = 25;
							continue;
						}
						return;
					case 9:
						goto IL_54A;
					case 10:
						num = 17;
						continue;
					case 11:
						if (obj.ToString() == string.Empty)
						{
							num = 0;
							continue;
						}
						goto IL_26D;
					case 12:
						if (obj.ToString() == string.Empty)
						{
							num = 5;
							continue;
						}
						goto IL_18F;
					case 13:
						global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "VAExportLocation", out obj, null, 1U);
						global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "VAExportLocation", obj, null, 2U);
						num = 33;
						continue;
					case 14:
						goto IL_1B9;
					case 15:
						goto IL_3BB;
					case 16:
						if (obj != null)
						{
							num = 10;
							continue;
						}
						goto IL_F0;
					case 17:
						if (obj.ToString() == string.Empty)
						{
							num = 34;
							continue;
						}
						goto IL_1E3;
					case 18:
						goto IL_18F;
					case 19:
						if (obj.ToString() == string.Empty)
						{
							num = 15;
							continue;
						}
						goto IL_304;
					case 20:
						goto IL_4E8;
					case 21:
						if (obj != null)
						{
							num = 27;
							continue;
						}
						goto IL_3BB;
					case 22:
						goto IL_304;
					case 23:
						if (obj != null)
						{
							num = 38;
							continue;
						}
						goto IL_125;
					case 24:
						num = 12;
						continue;
					case 25:
						global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "VAWorkerLocation", out obj, null, 1U);
						global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "VAWorkerLocation", obj, null, 2U);
						num = 32;
						continue;
					case 26:
						if (obj == null)
						{
							num = 13;
							continue;
						}
						goto IL_210;
					case 27:
						num = 19;
						continue;
					case 28:
						if (obj.ToString() == string.Empty)
						{
							goto IL_4B4;
						}
						goto IL_54A;
					case 29:
						num = 40;
						continue;
					case 30:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4B4;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							goto IL_455;
						}
						break;
					case 31:
						num = 11;
						continue;
					case 32:
						return;
					case 33:
						goto IL_210;
					case 34:
						goto IL_F0;
					case 35:
						if (obj != null)
						{
							num = 31;
							continue;
						}
						goto IL_15A;
					case 36:
						goto IL_26D;
					case 37:
						if (obj != null)
						{
							num = 29;
							continue;
						}
						goto IL_515;
					case 38:
						num = 39;
						continue;
					case 39:
						if (obj.ToString() == string.Empty)
						{
							num = 3;
							continue;
						}
						goto IL_4E8;
					case 40:
						if (obj.ToString() == string.Empty)
						{
							num = 6;
							continue;
						}
						goto IL_1B9;
					}
					break;
					IL_F0:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "SoftwareSystemKeyLocation", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "SoftwareSystemKeyLocation", obj, null, 2U);
					num = 1;
					continue;
					IL_125:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CloneRadioIdentity", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CloneRadioIdentity", obj, null, 2U);
					num = 20;
					continue;
					IL_15A:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentView", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentView", obj, null, 2U);
					num = 36;
					continue;
					IL_18F:
					obj = registryKey.GetValue("VAExportLocation");
					num = 26;
					continue;
					IL_1B9:
					obj = registryKey.GetValue("CurrentView");
					num = 35;
					continue;
					IL_1E3:
					obj = registryKey.GetValue("TcpPort");
					num = 7;
					continue;
					IL_210:
					obj = registryKey.GetValue("VAWorkerLocation");
					num = 8;
					continue;
					IL_26D:
					obj = registryKey.GetValue("ShowContextHelp");
					num = 21;
					continue;
					IL_304:
					obj = registryKey.GetValue("DefaultFolderPath");
					num = 2;
					continue;
					IL_3BB:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ShowContextHelp", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ShowContextHelp", obj, null, 2U);
					num = 22;
					continue;
					IL_3F0:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "TcpPort", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "TcpPort", obj, null, 2U);
					num = 18;
					continue;
					IL_455:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "InstallPath", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DefaultFolderPath", obj, null, 2U);
					num = 9;
					continue;
					IL_4B4:
					num = 30;
					continue;
					IL_4E8:
					obj = registryKey.GetValue("SoftwareSystemKeyLocation");
					num = 16;
					continue;
					IL_515:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentLanguage", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentLanguage", obj, null, 2U);
					num = 14;
					continue;
					IL_54A:
					obj = registryKey.GetValue("CloneRadioIdentity");
					num = 23;
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00007780 File Offset: 0x00006780
		internal static void d()
		{
			for (;;)
			{
				object obj = null;
				global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(global::RegistryAccess.CRegistryAccess.e);
				obj = registryKey.GetValue("CurrentLanguage");
				int num = 28;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_3D5;
					case 1:
						goto IL_66A;
					case 2:
						goto IL_728;
					case 3:
						goto IL_8DB;
					case 4:
						if (obj.ToString().Length == 0)
						{
							num = 73;
							continue;
						}
						goto IL_66A;
					case 5:
						num = 41;
						continue;
					case 6:
						if (obj != null)
						{
							num = 21;
							continue;
						}
						goto IL_93A;
					case 7:
						if (obj != null)
						{
							num = 42;
							continue;
						}
						goto IL_34A;
					case 8:
						if (obj != null)
						{
							num = 5;
							continue;
						}
						goto IL_27E;
					case 9:
						goto IL_8AE;
					case 10:
						if (obj.ToString().Length == 0)
						{
							num = 72;
							continue;
						}
						goto IL_551;
					case 11:
						goto IL_615;
					case 12:
						if (obj != null)
						{
							num = 26;
							continue;
						}
						goto IL_905;
					case 13:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_162;
						default:
							if (false)
							{
							}
							goto IL_4AB;
						}
						break;
					case 14:
						if (obj.ToString().Length == 0)
						{
							num = 36;
							continue;
						}
						goto IL_7DD;
					case 15:
						num = 58;
						continue;
					case 16:
						if (obj.ToString().Length == 0)
						{
							num = 60;
							continue;
						}
						goto IL_3D5;
					case 17:
						goto IL_96F;
					case 18:
						num = 64;
						continue;
					case 19:
						if (obj != null)
						{
							num = 50;
							continue;
						}
						goto IL_6CC;
					case 20:
						num = 49;
						continue;
					case 21:
						num = 31;
						continue;
					case 22:
						if (obj != null)
						{
							num = 61;
							continue;
						}
						goto IL_57E;
					case 23:
						num = 10;
						continue;
					case 24:
						if (obj != null)
						{
							num = 29;
							continue;
						}
						goto IL_2B3;
					case 25:
						if (obj.ToString().Length == 0)
						{
							num = 67;
							continue;
						}
						goto IL_251;
					case 26:
						num = 25;
						continue;
					case 27:
						if (obj.ToString().Length == 0)
						{
							num = 71;
							continue;
						}
						goto IL_8DB;
					case 28:
						goto IL_162;
					case 29:
						num = 27;
						continue;
					case 30:
						goto IL_83A;
					case 31:
						if (obj.ToString().Length == 0)
						{
							num = 70;
							continue;
						}
						goto IL_31D;
					case 32:
						if (obj != null)
						{
							num = 33;
							continue;
						}
						goto IL_2E8;
					case 33:
						num = 54;
						continue;
					case 34:
						if (obj != null)
						{
							num = 20;
							continue;
						}
						goto IL_4D8;
					case 35:
						goto IL_27E;
					case 36:
						goto IL_697;
					case 37:
						goto IL_5B3;
					case 38:
						if (obj.ToString().Length == 0)
						{
							num = 30;
							continue;
						}
						goto IL_701;
					case 39:
						goto IL_7DD;
					case 40:
						num = 55;
						continue;
					case 41:
						if (obj.ToString().Length == 0)
						{
							num = 35;
							continue;
						}
						goto IL_788;
					case 42:
						num = 68;
						continue;
					case 43:
						goto IL_251;
					case 44:
						goto IL_2E8;
					case 45:
						num = 38;
						continue;
					case 46:
						if (obj != null)
						{
							num = 45;
							continue;
						}
						goto IL_83A;
					case 47:
						goto IL_4D8;
					case 48:
						return;
					case 49:
						if (obj.ToString().Length == 0)
						{
							num = 47;
							continue;
						}
						goto IL_4AB;
					case 50:
						num = 4;
						continue;
					case 51:
						goto IL_31D;
					case 52:
						if (obj != null)
						{
							num = 15;
							continue;
						}
						goto IL_879;
					case 53:
						if (obj != null)
						{
							num = 40;
							continue;
						}
						goto IL_96F;
					case 54:
						if (obj.ToString().Length == 0)
						{
							num = 44;
							continue;
						}
						goto IL_615;
					case 55:
						if (obj.ToString().Length == 0)
						{
							num = 17;
							continue;
						}
						goto IL_8AE;
					case 56:
						if (obj != null)
						{
							num = 23;
							continue;
						}
						goto IL_5E0;
					case 57:
						num = 14;
						continue;
					case 58:
						if (obj.ToString().Length == 0)
						{
							num = 59;
							continue;
						}
						goto IL_224;
					case 59:
						goto IL_879;
					case 60:
						goto IL_57E;
					case 61:
						num = 16;
						continue;
					case 62:
						goto IL_34A;
					case 63:
						if (obj != null)
						{
							num = 18;
							continue;
						}
						goto IL_728;
					case 64:
						if (obj.ToString().Length == 0)
						{
							num = 2;
							continue;
						}
						goto IL_5B3;
					case 65:
						goto IL_224;
					case 66:
						goto IL_788;
					case 67:
						goto IL_905;
					case 68:
						if (true)
						{
						}
						if (obj.ToString().Length == 0)
						{
							num = 62;
							continue;
						}
						return;
					case 69:
						goto IL_701;
					case 70:
						goto IL_93A;
					case 71:
						goto IL_2B3;
					case 72:
						goto IL_5E0;
					case 73:
						goto IL_6CC;
					case 74:
						goto IL_551;
					}
					break;
					IL_162:
					if (obj != null)
					{
						num = 57;
						continue;
					}
					goto IL_697;
					IL_224:
					obj = registryKey.GetValue("DefaultFolderPath");
					num = 22;
					continue;
					IL_251:
					obj = registryKey.GetValue("KeepAlive");
					num = 53;
					continue;
					IL_27E:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DiagnosticLogging", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DiagnosticLogging", obj, null, 2U);
					num = 66;
					continue;
					IL_2B3:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Controller", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Controller", obj, null, 2U);
					num = 3;
					continue;
					IL_2E8:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ColumnEnable", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ColumnEnable", obj, null, 2U);
					num = 11;
					continue;
					IL_31D:
					obj = registryKey.GetValue("DiagnosticLogging");
					num = 8;
					continue;
					IL_34A:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DiagnosticInterval", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DiagnosticInterval", obj, null, 2U);
					num = 48;
					continue;
					IL_3D5:
					obj = registryKey.GetValue("ColumnEnable");
					num = 32;
					continue;
					IL_4AB:
					obj = registryKey.GetValue("AutoReg");
					num = 46;
					continue;
					IL_4D8:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Authentication", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Authentication", obj, null, 2U);
					num = 13;
					continue;
					IL_551:
					obj = registryKey.GetValue("Authentication");
					num = 34;
					continue;
					IL_57E:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "InstallPath", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DefaultFolderPath", obj, null, 2U);
					num = 0;
					continue;
					IL_5B3:
					obj = registryKey.GetValue("SourcePort");
					num = 6;
					continue;
					IL_5E0:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "AppID", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "AppID", obj, null, 2U);
					num = 74;
					continue;
					IL_615:
					obj = registryKey.GetValue("AppID");
					num = 56;
					continue;
					IL_66A:
					obj = registryKey.GetValue("Controller");
					num = 24;
					continue;
					IL_697:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentLanguage", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentLanguage", obj, null, 2U);
					num = 39;
					continue;
					IL_6CC:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Connection", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Connection", obj, null, 2U);
					num = 1;
					continue;
					IL_701:
					obj = registryKey.GetValue("Connection");
					num = 19;
					continue;
					IL_728:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "RetryTimer", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "RetryTimer", obj, null, 2U);
					num = 37;
					continue;
					IL_788:
					obj = registryKey.GetValue("DiagnosticInterval");
					num = 7;
					continue;
					IL_7DD:
					obj = registryKey.GetValue("ShowContextHelp");
					num = 52;
					continue;
					IL_83A:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "AutoReg", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "AutoReg", obj, null, 2U);
					num = 69;
					continue;
					IL_879:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ShowContextHelp", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ShowContextHelp", obj, null, 2U);
					num = 65;
					continue;
					IL_8AE:
					obj = registryKey.GetValue("RetryTimer");
					num = 63;
					continue;
					IL_8DB:
					obj = registryKey.GetValue("HasConfigured");
					num = 12;
					continue;
					IL_905:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "HasConfigured", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "HasConfigured", obj, null, 2U);
					num = 43;
					continue;
					IL_93A:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "SourcePort", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "SourcePort", obj, null, 2U);
					num = 51;
					continue;
					IL_96F:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "KeepAlive", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "KeepAlive", obj, null, 2U);
					num = 9;
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00008134 File Offset: 0x00007134
		internal void f()
		{
			for (;;)
			{
				IL_60:
				object obj = null;
				global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(global::RegistryAccess.CRegistryAccess.e);
				obj = registryKey.GetValue("CurrentLanguage");
				int num = 11;
				for (;;)
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
						switch (num)
						{
						case 0:
							if (obj != null)
							{
								num = 14;
								continue;
							}
							goto IL_12F;
						case 1:
							if (obj.ToString() == "")
							{
								num = 8;
								continue;
							}
							goto IL_9E;
						case 2:
							if (obj.ToString() == "")
							{
								num = 6;
								continue;
							}
							return;
						case 3:
							return;
						case 4:
							if (obj != null)
							{
								num = 10;
								continue;
							}
							goto IL_C8;
						case 5:
							num = 9;
							continue;
						case 6:
							goto IL_12F;
						case 7:
							goto IL_FA;
						case 8:
							goto IL_C8;
						case 9:
							if (obj.ToString() == "")
							{
								num = 7;
								continue;
							}
							goto IL_200;
						case 10:
							num = 1;
							continue;
						case 11:
							if (obj != null)
							{
								num = 5;
								continue;
							}
							goto IL_FA;
						case 12:
							goto IL_9E;
						case 13:
							goto IL_200;
						case 14:
							if (true)
							{
							}
							num = 2;
							continue;
						}
						goto IL_60;
						IL_9E:
						obj = registryKey.GetValue("DefaultFolderPath");
						num = 0;
						continue;
						IL_C8:
						global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ShowContextHelp", out obj, null, 1U);
						global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ShowContextHelp", obj, null, 2U);
						num = 12;
						continue;
						IL_FA:
						global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentLanguage", out obj, null, 1U);
						global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentLanguage", obj, null, 2U);
						num = 13;
						continue;
						IL_200:
						obj = registryKey.GetValue("ShowContextHelp");
						num = 4;
						continue;
					}
					IL_12F:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "InstallPath", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DefaultFolderPath", obj, null, 2U);
					num = 3;
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000836C File Offset: 0x0000736C
		internal void h()
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::Microsoft.Win32.RegistryKey registryKey = null;
					object obj = null;
					registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(global::RegistryAccess.a.a6);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "MaxEntryMRU", out obj, null, 1U);
					int num = global::System.Convert.ToInt32(obj.ToString(), global::System.Globalization.NumberFormatInfo.InvariantInfo);
					int num2 = 1;
					if (true)
					{
					}
					int num3 = 1;
					for (;;)
					{
						switch (num3)
						{
						case 0:
							return;
						case 1:
							goto IL_178;
						case 2:
							goto IL_178;
						case 3:
							if (num2 > num)
							{
								num3 = 0;
								continue;
							}
							try
							{
								for (;;)
								{
									IL_AA:
									obj = registryKey.GetValue("File" + num2.ToString());
									num3 = 0;
									for (;;)
									{
										switch (num3)
										{
										case 0:
											if (obj != null)
											{
												num3 = 2;
												continue;
											}
											goto IL_FF;
										case 1:
											goto IL_FF;
										case 2:
											num3 = 4;
											continue;
										case 3:
											goto IL_151;
										case 4:
											if (obj.ToString() == string.Empty)
											{
												num3 = 1;
												continue;
											}
											goto IL_145;
										case 5:
											goto IL_145;
										}
										break;
										IL_FF:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_AA;
										default:
											if (false)
											{
											}
											registryKey.SetValue("File" + num2.ToString(), string.Empty);
											num3 = 5;
											continue;
										}
										IL_145:
										num3 = 3;
									}
								}
								IL_151:
								goto IL_77;
							}
							catch (global::System.ArgumentException)
							{
								registryKey.SetValue("File" + num2.ToString(), string.Empty);
								goto IL_77;
							}
							goto IL_178;
							IL_77:
							num2++;
							num3 = 2;
							continue;
						}
						break;
						IL_178:
						num3 = 3;
					}
				}
				return;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000852C File Offset: 0x0000752C
		internal void e()
		{
			for (;;)
			{
				object obj = null;
				global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(global::RegistryAccess.CRegistryAccess.e);
				obj = registryKey.GetValue("CurrentLanguage");
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (obj != null)
						{
							num = 13;
							continue;
						}
						goto IL_B1;
					case 1:
						if (true)
						{
						}
						num = 8;
						continue;
					case 2:
						if (!(obj.ToString() == ""))
						{
							goto IL_7C;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22B;
						default:
							if (false)
							{
							}
							num = 6;
							continue;
						}
						break;
					case 3:
						if (obj != null)
						{
							num = 14;
							continue;
						}
						goto IL_E3;
					case 4:
						goto IL_203;
					case 5:
						goto IL_118;
					case 6:
						goto IL_B1;
					case 7:
						return;
					case 8:
						if (obj.ToString() == "")
						{
							num = 5;
							continue;
						}
						return;
					case 9:
						if (obj != null)
						{
							num = 1;
							continue;
						}
						goto IL_118;
					case 10:
						if (obj.ToString() == "")
						{
							num = 11;
							continue;
						}
						goto IL_203;
					case 11:
						goto IL_E3;
					case 12:
						goto IL_7C;
					case 13:
						goto IL_22B;
					case 14:
						num = 10;
						continue;
					}
					break;
					IL_7C:
					obj = registryKey.GetValue("ImageResource");
					num = 9;
					continue;
					IL_B1:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "InstallPath", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DefaultFolderPath", obj, null, 2U);
					num = 12;
					continue;
					IL_E3:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentLanguage", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentLanguage", obj, null, 2U);
					num = 4;
					continue;
					IL_118:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ImageResource", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ImageResource", obj, null, 2U);
					num = 7;
					continue;
					IL_203:
					obj = registryKey.GetValue("DefaultFolderPath");
					num = 0;
					continue;
					IL_22B:
					num = 2;
				}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00008768 File Offset: 0x00007768
		internal void k()
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
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Settings");
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000087B4 File Offset: 0x000077B4
		internal void l()
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
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Language");
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00008800 File Offset: 0x00007800
		internal void j()
		{
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			if (true)
			{
			}
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Views");
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000884C File Offset: 0x0000784C
		internal void g()
		{
			for (;;)
			{
				IL_00:
				for (;;)
				{
					object obj = null;
					global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(global::RegistryAccess.CRegistryAccess.e);
					obj = registryKey.GetValue("PlaySound");
					int num = 0;
					for (;;)
					{
						if (true)
						{
						}
						switch (num)
						{
						case 0:
							if (obj != null)
							{
								num = 2;
								continue;
							}
							goto IL_59;
						case 1:
							goto IL_59;
						case 2:
							num = 4;
							continue;
						case 3:
							return;
						case 4:
							if (obj.ToString() == string.Empty)
							{
								num = 1;
								continue;
							}
							return;
						}
						break;
						IL_59:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							if (false)
							{
							}
							global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "PlaySound", out obj, null, 1U);
							global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "PlaySound", obj, null, 2U);
							num = 3;
							break;
						}
					}
				}
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00008938 File Offset: 0x00007938
		internal static void c()
		{
			for (;;)
			{
				IL_00:
				for (;;)
				{
					object obj = null;
					global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(global::RegistryAccess.CRegistryAccess.e);
					obj = registryKey.GetValue("EmailNotification");
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							num = 3;
							continue;
						case 1:
							goto IL_59;
						case 2:
							if (obj != null)
							{
								if (true)
								{
								}
								num = 0;
								continue;
							}
							goto IL_59;
						case 3:
							if (obj.ToString().Length == 0)
							{
								num = 1;
								continue;
							}
							return;
						case 4:
							return;
						}
						break;
						IL_59:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							if (false)
							{
							}
							global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "EmailNotification", out obj, null, 1U);
							global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "EmailNotification", obj, null, 2U);
							num = 4;
							break;
						}
					}
				}
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00008A1C File Offset: 0x00007A1C
		internal static void b()
		{
			for (;;)
			{
				for (;;)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						if (true)
						{
						}
						if (false)
						{
						}
						object obj = null;
						global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(global::RegistryAccess.CRegistryAccess.e);
						obj = registryKey.GetValue("LogDigitalVoting");
						int num = 4;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (obj.ToString().Length == 0)
								{
									num = 1;
									continue;
								}
								return;
							case 1:
								goto IL_75;
							case 2:
								num = 0;
								continue;
							case 3:
								return;
							case 4:
								if (obj != null)
								{
									num = 2;
									continue;
								}
								goto IL_75;
							}
							break;
							IL_75:
							global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "LogDigitalVoting", out obj, null, 1U);
							global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "LogDigitalVoting", obj, null, 2U);
							num = 3;
						}
						break;
					}
					}
				}
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00008B00 File Offset: 0x00007B00
		internal static void a()
		{
			for (;;)
			{
				IL_1C:
				object obj = null;
				global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(global::RegistryAccess.CRegistryAccess.e);
				obj = registryKey.GetValue("HidenWhenMinimize");
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_7D:
					num = 0;
					break;
				case 1:
					goto IL_5C;
				default:
					goto IL_5C;
				}
				for (;;)
				{
					IL_02:
					switch (num)
					{
					case 0:
						if (obj.ToString().Length == 0)
						{
							num = 3;
							continue;
						}
						return;
					case 1:
						goto IL_7D;
					case 2:
						if (obj != null)
						{
							num = 1;
							continue;
						}
						goto IL_7F;
					case 3:
						goto IL_7F;
					case 4:
						return;
					}
					goto IL_1C;
					IL_7F:
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "HidenWhenMinimize", out obj, null, 1U);
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "HidenWhenMinimize", obj, null, 2U);
					num = 4;
				}
				IL_5C:
				if (true)
				{
				}
				if (false)
				{
				}
				num = 2;
				goto IL_02;
			}
		}

		// Token: 0x0400000E RID: 14
		internal const string a = "Software\\Motorola\\";

		// Token: 0x0400000F RID: 15
		private const string b = "Settings";

		// Token: 0x04000010 RID: 16
		private const string c = "Language";

		// Token: 0x04000011 RID: 17
		private const string d = "Views";

		// Token: 0x04000012 RID: 18
		internal static string e;

		// Token: 0x04000013 RID: 19
		internal static string f;

		// Token: 0x04000014 RID: 20
		internal static global::RegistryAccess.CRegistryAccess.ProductName g;

		// Token: 0x0200000D RID: 13
		public enum ProductName
		{
			// Token: 0x04000016 RID: 22
			MOTOTRBO_CPS,
			// Token: 0x04000017 RID: 23
			MOTOTRBO_RDAC,
			// Token: 0x04000018 RID: 24
			MOTOTRBO_Tuner,
			// Token: 0x04000019 RID: 25
			MOTOTRBO_AirTracer,
			// Token: 0x0400001A RID: 26
			MOTOTRBO_DepotTool
		}
	}
}
