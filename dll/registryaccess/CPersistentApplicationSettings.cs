using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using custom_exception;
using Microsoft.Win32;

namespace RegistryAccess
{
	// Token: 0x0200000B RID: 11
	public class CPersistentApplicationSettings : global::RegistryAccess.IPersistentApplicationSettings
	{
		// Token: 0x0600006A RID: 106 RVA: 0x000032F0 File Offset: 0x000022F0
		public CPersistentApplicationSettings()
		{
			if (string.IsNullOrEmpty(global::RegistryAccess.CRegistryAccess.f))
			{
				uint num = 1U;
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, "RegistryAccess.CPersistentApplicationSettings", "CPersistentApplicationSettings", global::System.Environment.StackTrace.ToString());
				throw ex;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003338 File Offset: 0x00002338
		public void SetDefaultFolder(string strPath)
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
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DefaultFolderPath", strPath, null, 2U);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003388 File Offset: 0x00002388
		public void GetDefaultFolder(ref string strDefaultFolderPath)
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
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DefaultFolderPath", out obj, null, 2U);
				try
				{
					strDefaultFolderPath = obj.ToString();
				}
				catch (global::System.Exception innerException)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetDefaultFolder", global::System.Environment.StackTrace.ToString());
					ex.AddErrorMessage(innerException);
					throw ex;
				}
				break;
			}
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000342C File Offset: 0x0000242C
		public void GetCPSInstallPath(ref string strInstallPath)
		{
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
				object obj = null;
				string a_ = "Software\\Motorola\\" + global::RegistryAccess.CRegistryAccess.ProductName.MOTOTRBO_CPS.ToString().Replace("_", " ");
				global::RegistryAccess.a.a(a_, "InstallPath", out obj, null, 1U);
				try
				{
					strInstallPath = obj.ToString();
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetInstallPath", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				break;
			}
			}
			if (true)
			{
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000034EC File Offset: 0x000024EC
		public void GetInstallPath(ref string strInstallPath)
		{
			switch (0)
			{
			default:
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "InstallPath", out obj, null, 1U);
				goto IL_2F;
				try
				{
					for (;;)
					{
						IL_2F:
						for (;;)
						{
							strInstallPath = obj.ToString();
							int num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_B9;
								case 1:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										if (false)
										{
										}
										if (strInstallPath.IndexOf(global::System.IO.Path.DirectorySeparatorChar) < 0)
										{
											num = 3;
											continue;
										}
										goto IL_AD;
									}
									break;
								case 2:
									goto IL_AD;
								case 3:
									strInstallPath += global::System.IO.Path.DirectorySeparatorChar;
									num = 2;
									continue;
								}
								break;
								IL_AD:
								num = 0;
							}
						}
					}
					IL_B9:;
				}
				catch (global::System.Exception innerException)
				{
					uint num2 = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetInstallPath", global::System.Environment.StackTrace.ToString());
					ex.AddErrorMessage(innerException);
					throw ex;
				}
				if (true)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003604 File Offset: 0x00002604
		public void GetXferFolderPath(ref string strXferFolderPath)
		{
			switch (0)
			{
			default:
			{
				int num = 2;
				for (;;)
				{
					object obj;
					switch (num)
					{
					case 0:
						try
						{
							for (;;)
							{
								strXferFolderPath = obj.ToString();
								num = 3;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_ED;
									case 1:
										goto IL_A5;
									case 2:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_A5;
										default:
											if (false)
											{
											}
											goto IL_E1;
										}
										break;
									case 3:
										if (strXferFolderPath.IndexOf(global::System.IO.Path.DirectorySeparatorChar) < 0)
										{
											num = 1;
											continue;
										}
										goto IL_E1;
									}
									break;
									IL_A5:
									strXferFolderPath += global::System.IO.Path.DirectorySeparatorChar;
									num = 2;
									continue;
									IL_E1:
									num = 0;
								}
							}
							IL_ED:
							return;
						}
						catch (global::System.Exception innerException)
						{
							uint num2 = 1370U;
							global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetXferFolderPath", global::System.Environment.StackTrace.ToString());
							ex.AddErrorMessage(innerException);
							throw ex;
						}
						goto IL_12C;
					case 1:
						if (global::System.Convert.ToBoolean(global::System.Configuration.ConfigurationManager.AppSettings["IsCommandLineCPS"]))
						{
							num = 3;
							continue;
						}
						goto IL_12C;
					case 3:
						goto IL_18A;
					case 4:
						num = 1;
						continue;
					}
					if (true)
					{
					}
					if (!string.IsNullOrEmpty(global::System.Configuration.ConfigurationManager.AppSettings["IsCommandLineCPS"]))
					{
						num = 4;
						continue;
					}
					IL_12C:
					obj = null;
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "XferFolderPath", out obj, null, 1U);
					num = 0;
				}
				IL_18A:
				string folderPath = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
				strXferFolderPath = global::System.IO.Path.Combine(folderPath, "Motorola", "CPS_RM");
				global::RegistryAccess.CPersistentApplicationSettings.b(strXferFolderPath);
				strXferFolderPath = global::System.IO.Path.Combine(strXferFolderPath, "XFER");
				global::RegistryAccess.CPersistentApplicationSettings.b(strXferFolderPath);
				return;
			}
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000037E4 File Offset: 0x000027E4
		private static void b(string A_0)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_4A:
				if (true)
				{
				}
				num = 1;
				break;
			default:
				if (false)
				{
				}
				num = 0;
				break;
			}
			for (;;)
			{
				switch (num)
				{
				case 1:
					global::System.IO.Directory.CreateDirectory(A_0);
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
			if (!global::System.IO.Directory.Exists(A_0))
			{
				goto IL_4A;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003860 File Offset: 0x00002860
		public void GetViewFolderPath(ref string strViewFolderPath)
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
			if (true)
			{
			}
			if (false)
			{
			}
			object obj = null;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ViewFolderPath", out obj, null, 1U);
			try
			{
				for (;;)
				{
					strViewFolderPath = obj.ToString();
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_B4;
						case 1:
							strViewFolderPath += global::System.IO.Path.DirectorySeparatorChar;
							num = 2;
							continue;
						case 2:
							goto IL_AB;
						case 3:
							if (strViewFolderPath.IndexOf(global::System.IO.Path.DirectorySeparatorChar) < 0)
							{
								num = 1;
								continue;
							}
							goto IL_AB;
						}
						break;
						IL_AB:
						num = 0;
					}
				}
				IL_B4:;
			}
			catch (global::System.Exception innerException)
			{
				uint num2 = 1370U;
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetViewFolderPath", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(innerException);
				throw ex;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003974 File Offset: 0x00002974
		public void SetShowContextHelp(bool bShowHelp)
		{
			int num;
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
					num = 0;
					break;
				}
				int num2 = 0;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (bShowHelp)
						{
							num2 = 2;
							continue;
						}
						goto IL_65;
					case 1:
						goto IL_59;
					case 2:
						num = 1;
						if (true)
						{
						}
						num2 = 1;
						continue;
					}
					break;
				}
			}
			IL_59:
			IL_65:
			object a_ = num;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ShowContextHelp", a_, null, 2U);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003A00 File Offset: 0x00002A00
		public void GetShowContextHelp(ref bool bShowHelp)
		{
			if (true)
			{
			}
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			}
			if (false)
			{
			}
			switch (0)
			{
			default:
			{
				object value = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ShowContextHelp", out value, null, 2U);
				try
				{
					for (;;)
					{
						bShowHelp = true;
						int num = global::System.Convert.ToInt32(value);
						int num2 = 1;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_A5;
							case 1:
								if (1 != num)
								{
									num2 = 3;
									continue;
								}
								goto IL_9C;
							case 2:
								goto IL_9C;
							case 3:
								bShowHelp = false;
								num2 = 2;
								continue;
							}
							break;
							IL_9C:
							num2 = 0;
						}
					}
					IL_A5:;
				}
				catch (global::System.Exception innerException)
				{
					uint num3 = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "GetShowContextHelp", global::System.Environment.StackTrace.ToString());
					ex.AddErrorMessage(innerException);
					throw ex;
				}
				break;
			}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003B00 File Offset: 0x00002B00
		public void SetPosition(global::System.Windows.Forms.Form objPosition)
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
			object a_ = objPosition.Top;
			global::RegistryAccess.a.a(global::RegistryAccess.a.a8, "Top", a_, null, 2U);
			a_ = objPosition.Left;
			global::RegistryAccess.a.a(global::RegistryAccess.a.a8, "Left", a_, null, 2U);
			a_ = objPosition.Height;
			global::RegistryAccess.a.a(global::RegistryAccess.a.a8, "Height", a_, null, 2U);
			a_ = objPosition.Width;
			global::RegistryAccess.a.a(global::RegistryAccess.a.a8, "Width", a_, null, 2U);
			a_ = objPosition.WindowState;
			global::RegistryAccess.a.a(global::RegistryAccess.a.a8, "FormWindowState", a_, null, 2U);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003BD4 File Offset: 0x00002BD4
		public void GetPosition(ref global::System.Windows.Forms.Form objPosition)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (true)
				{
				}
				if (false)
				{
				}
				switch (0)
				{
				default:
				{
					object obj = null;
					global::RegistryAccess.a.a(global::RegistryAccess.a.a8, "Top", out obj, null, 2U);
					object obj2 = null;
					global::RegistryAccess.a.a(global::RegistryAccess.a.a8, "Left", out obj2, null, 2U);
					object obj3 = null;
					global::RegistryAccess.a.a(global::RegistryAccess.a.a8, "Height", out obj3, null, 2U);
					object obj4 = null;
					global::RegistryAccess.a.a(global::RegistryAccess.a.a8, "Width", out obj4, null, 2U);
					object obj5 = null;
					global::RegistryAccess.a.a(global::RegistryAccess.a.a8, "FormWindowState", out obj5, null, 2U);
					try
					{
						int num = 7;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_360;
							case 1:
								num = 16;
								continue;
							case 2:
								objPosition.WindowState = global::System.Windows.Forms.FormWindowState.Minimized;
								num = 0;
								continue;
							case 3:
								goto IL_2D1;
							case 4:
								goto IL_360;
							case 5:
								objPosition.Height = 300;
								num = 3;
								continue;
							case 6:
								goto IL_307;
							case 8:
								goto IL_36C;
							case 9:
								goto IL_360;
							case 10:
								if (obj2 == null)
								{
									num = 26;
									continue;
								}
								objPosition.Left = global::System.Convert.ToInt32(obj2);
								num = 12;
								continue;
							case 11:
								if (obj4 == null)
								{
									num = 27;
									continue;
								}
								objPosition.Width = global::System.Convert.ToInt32(obj4);
								num = 6;
								continue;
							case 12:
								goto IL_296;
							case 13:
								if ((string)obj5 == "Maximized")
								{
									num = 18;
									continue;
								}
								goto IL_15A;
							case 14:
								goto IL_307;
							case 15:
								if (obj5 != null)
								{
									num = 1;
									continue;
								}
								goto IL_249;
							case 16:
								if ((string)obj5 == "Minimized")
								{
									num = 2;
									continue;
								}
								goto IL_249;
							case 17:
								num = 13;
								continue;
							case 18:
								objPosition.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
								num = 9;
								continue;
							case 19:
								goto IL_2D1;
							case 20:
								objPosition.Top = 0;
								num = 22;
								continue;
							case 21:
								if (obj5 != null)
								{
									num = 17;
									continue;
								}
								goto IL_15A;
							case 22:
								goto IL_17E;
							case 23:
								goto IL_296;
							case 24:
								goto IL_17E;
							case 25:
								if (obj3 == null)
								{
									num = 5;
									continue;
								}
								objPosition.Height = global::System.Convert.ToInt32(obj3);
								num = 19;
								continue;
							case 26:
								objPosition.Left = 0;
								num = 23;
								continue;
							case 27:
								objPosition.Width = 400;
								num = 14;
								continue;
							}
							if (obj == null)
							{
								num = 20;
								continue;
							}
							objPosition.Top = global::System.Convert.ToInt32(obj);
							num = 24;
							continue;
							IL_15A:
							num = 15;
							continue;
							IL_17E:
							num = 10;
							continue;
							IL_249:
							objPosition.WindowState = global::System.Windows.Forms.FormWindowState.Normal;
							num = 4;
							continue;
							IL_296:
							num = 25;
							continue;
							IL_2D1:
							num = 11;
							continue;
							IL_307:
							num = 21;
							continue;
							IL_360:
							num = 8;
						}
						IL_36C:;
					}
					catch (global::System.Exception innerException)
					{
						uint num2 = 1370U;
						global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetPosition", global::System.Environment.StackTrace.ToString());
						ex.AddErrorMessage(innerException);
						throw ex;
					}
					break;
				}
				}
				break;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003FAC File Offset: 0x00002FAC
		public void SetMaximumMRUEntries(int iNumEntries)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_65:
				if (0 <= iNumEntries)
				{
					object a_ = iNumEntries;
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "MaxEntryMRU", a_, null, 2U);
					global::RegistryAccess.CPersistentApplicationSettings.a = iNumEntries;
					return;
				}
				num = 1;
				break;
			default:
				if (false)
				{
				}
				num = 3;
				break;
			}
			for (;;)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 0:
					goto IL_65;
				case 1:
					goto IL_71;
				case 2:
					num = 0;
					continue;
				}
				if (8 < iNumEntries)
				{
					break;
				}
				num = 2;
			}
			return;
			IL_71:;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000404C File Offset: 0x0000304C
		public void GetMaximumMRUEntries(ref int iNumEntries)
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
			if (true)
			{
			}
			if (false)
			{
			}
			object value = null;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "MaxEntryMRU", out value, null, 2U);
			try
			{
				for (;;)
				{
					iNumEntries = global::System.Convert.ToInt32(value);
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (8 < iNumEntries)
							{
								num = 1;
								continue;
							}
							goto IL_D3;
						case 1:
							goto IL_AE;
						case 2:
							goto IL_DF;
						case 3:
							if (0 <= iNumEntries)
							{
								num = 5;
								continue;
							}
							goto IL_AE;
						case 4:
							goto IL_D3;
						case 5:
							num = 0;
							continue;
						}
						break;
						IL_AE:
						global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "MaxEntryMRU", 8, null, 2U);
						iNumEntries = 8;
						num = 4;
						continue;
						IL_D3:
						num = 2;
					}
				}
				IL_DF:;
			}
			catch (global::System.Exception innerException)
			{
				uint num2 = 1370U;
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetMaximumMRUEntries", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(innerException);
				throw ex;
			}
			global::RegistryAccess.CPersistentApplicationSettings.a = iNumEntries;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004188 File Offset: 0x00003188
		public void AddToMRUList(string strFileName)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				uint num;
				string message;
				for (;;)
				{
					IL_2B:
					num = 0U;
					message = string.Empty;
					for (;;)
					{
						int num2 = 1;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_56;
							case 1:
								try
								{
									for (;;)
									{
										global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.OpenSubKey(global::RegistryAccess.a.a6, true);
										string value = string.Empty;
										int num3 = 0;
										num2 = 0;
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_B9;
											case 1:
												if (num3 >= global::RegistryAccess.CPersistentApplicationSettings.a - 1)
												{
													num2 = 4;
													continue;
												}
												try
												{
													value = global::System.Convert.ToString(registryKey.GetValue("File" + (num3 + 1).ToString()));
													registryKey.SetValue("File" + num3.ToString(), value);
												}
												catch (global::System.ArgumentException)
												{
													registryKey.SetValue("File" + num3.ToString(), string.Empty);
												}
												num3++;
												num2 = 3;
												continue;
											case 2:
												goto IL_178;
											case 3:
												goto IL_B9;
											case 4:
												registryKey.SetValue("File" + (global::RegistryAccess.CPersistentApplicationSettings.a - 1).ToString(), strFileName);
												num2 = 2;
												continue;
											}
											break;
											IL_B9:
											num2 = 1;
										}
									}
									IL_178:
									goto IL_3E;
								}
								catch (global::System.NullReferenceException)
								{
									num = 1368U;
									message = string.Format("rk is null because the specified registry key path is incorrect. strFileName: {0}", strFileName);
									goto IL_3E;
								}
								catch (global::System.ArgumentException)
								{
									num = 1369U;
									message = string.Format("return null when call GetValue( ) because the registry value is inexistent. strFileName: {0}", strFileName);
									goto IL_3E;
								}
								catch (global::System.FormatException)
								{
									num = 1370U;
									message = string.Format("can't cast a data type to a uncompatible data type. strFileName: {0}", strFileName);
									goto IL_3E;
								}
								goto IL_1C5;
								IL_3E:
								num2 = 2;
								continue;
							case 2:
								if (num != 0U)
								{
									num2 = 0;
									continue;
								}
								return;
							}
							goto IL_2B;
						}
						IL_56:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_6C;
						}
					}
				}
				IL_6C:
				if (false)
				{
				}
				IL_1C5:
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "AddToMRUList", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(message);
				throw ex;
			}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000043FC File Offset: 0x000033FC
		public void GetMRUList(global::System.Collections.ArrayList arrFileNameList)
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
					message = string.Empty;
					int num2 = 2;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (num != 0U)
							{
								goto IL_61;
							}
							return;
						case 1:
							goto IL_6A;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_61;
							default:
								if (false)
								{
								}
								try
								{
									for (;;)
									{
										global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.OpenSubKey(global::RegistryAccess.a.a6);
										string text = string.Empty;
										int num3 = 0;
										num2 = 7;
										for (;;)
										{
											switch (num2)
											{
											case 0:
												if (num3 >= global::RegistryAccess.CPersistentApplicationSettings.a)
												{
													num2 = 4;
													continue;
												}
												try
												{
													text = (string)registryKey.GetValue("File" + num3.ToString());
													goto IL_D9;
												}
												catch (global::System.ArgumentException)
												{
												}
												goto IL_112;
												IL_D9:
												num2 = 2;
												continue;
											case 1:
												goto IL_112;
											case 2:
												if (text != null)
												{
													num2 = 3;
													continue;
												}
												goto IL_112;
											case 3:
												arrFileNameList.Add(text);
												num2 = 1;
												continue;
											case 4:
												num = 0U;
												num2 = 5;
												continue;
											case 5:
												goto IL_14A;
											case 6:
												goto IL_BC;
											case 7:
												goto IL_BC;
											}
											break;
											IL_BC:
											num2 = 0;
											continue;
											IL_112:
											num3++;
											num2 = 6;
										}
									}
									IL_14A:
									goto IL_52;
								}
								catch (global::System.NullReferenceException)
								{
									num = 1368U;
									message = "rk is null because the specified registry key path is incorrect.";
									goto IL_52;
								}
								catch (global::System.ArgumentException)
								{
									num = 1369U;
									message = "return null when call GetValue( ) because the registry value is inexistent.";
									goto IL_52;
								}
								catch (global::System.FormatException)
								{
									num = 1370U;
									message = "can't cast a data type to a uncompatible data type";
									goto IL_52;
								}
								goto IL_185;
								IL_52:
								num2 = 0;
								continue;
							}
							break;
						}
						break;
						IL_61:
						num2 = 1;
					}
				}
				IL_6A:
				IL_185:
				if (true)
				{
				}
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetMRUList", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(message);
				throw ex;
			}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004608 File Offset: 0x00003608
		public void AddCustomView(string strViewName, string strResourceFile)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (true)
				{
				}
				if (false)
				{
				}
				try
				{
					global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.OpenSubKey(global::RegistryAccess.a.a9, true);
					registryKey.CreateSubKey(strViewName);
				}
				catch (global::System.Exception innerException)
				{
					uint num = 1368U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "AddCustomView", global::System.Environment.StackTrace.ToString());
					ex.AddErrorMessage(innerException);
					throw ex;
				}
				break;
			}
			global::RegistryAccess.a.a(global::RegistryAccess.a.a9, "ViewName", strViewName, strViewName, 2U);
			global::RegistryAccess.a.a(global::RegistryAccess.a.a9, "ViewResource", strResourceFile, strViewName, 2U);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000046D0 File Offset: 0x000036D0
		public void SetViewSelection(string strViewSelection)
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
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentView", strViewSelection, null, 2U);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004720 File Offset: 0x00003720
		public void GetAvailableViews(ref global::System.Collections.ArrayList alAvailableViews)
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
					message = string.Empty;
					int num2 = 1;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_58;
						case 1:
							try
							{
								for (;;)
								{
									IL_7A:
									global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.OpenSubKey(global::RegistryAccess.a.a9);
									string[] subKeyNames = registryKey.GetSubKeyNames();
									string[] array = subKeyNames;
									int num3 = 0;
									for (;;)
									{
										IL_97:
										num2 = 3;
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												if (num3 >= array.Length)
												{
													num2 = 4;
													continue;
												}
												string value = array[num3];
												alAvailableViews.Add(value);
												num3++;
												num2 = 1;
												continue;
											}
											case 1:
												goto IL_BE;
											case 2:
												goto IL_10D;
											case 3:
												switch ((1 == 1) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_97;
												default:
													if (false)
													{
													}
													goto IL_BE;
												}
												break;
											case 4:
												num = 0U;
												num2 = 2;
												continue;
											}
											goto IL_7A;
											IL_BE:
											num2 = 0;
										}
									}
								}
								IL_10D:
								goto IL_36;
							}
							catch (global::System.NullReferenceException)
							{
								num = 1368U;
								message = "rk is null because the specified registry key path is incorrect.";
								goto IL_36;
							}
							catch (global::System.ArgumentException)
							{
								num = 1369U;
								message = "return null when call GetValue( ) because the registry value is unexistent.";
								goto IL_36;
							}
							catch (global::System.FormatException)
							{
								num = 1370U;
								message = "can't cast a data type to a uncompatible data type";
								goto IL_36;
							}
							goto IL_148;
							IL_36:
							num2 = 2;
							continue;
						case 2:
							if (num != 0U)
							{
								num2 = 0;
								continue;
							}
							return;
						}
						break;
					}
				}
				IL_58:
				IL_148:
				if (true)
				{
				}
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetAvailableViews", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(message);
				throw ex;
			}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000048D8 File Offset: 0x000038D8
		public void GetViewSelection(ref string strViewName, ref string strResourceFile)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					object obj = null;
					global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentView", out obj, null, 2U);
					int num = 2;
					for (;;)
					{
						bool flag;
						switch (num)
						{
						case 0:
							goto IL_283;
						case 1:
							global::RegistryAccess.a.a(global::RegistryAccess.a.a9 + "\\Basic_View", "ViewResource", out obj, null, 1U);
							if (true)
							{
							}
							num = 0;
							continue;
						case 2:
							goto IL_1E0;
						case 3:
							goto IL_224;
						case 4:
							goto IL_C0;
						case 5:
							if (string.Equals(strViewName, "Basic_View", global::System.StringComparison.Ordinal))
							{
								num = 1;
								continue;
							}
							num = 7;
							continue;
						case 6:
							goto IL_C0;
						case 7:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_283;
							default:
								if (false)
								{
								}
								if (string.Equals(strViewName, "Expert_View", global::System.StringComparison.Ordinal))
								{
									num = 3;
									continue;
								}
								global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentView", out obj, null, 2U);
								flag = true;
								num = 4;
								continue;
							}
							break;
						}
						break;
						IL_224:
						global::RegistryAccess.a.a(global::RegistryAccess.a.a9 + "\\Expert_View", "ViewResource", out obj, null, 1U);
						num = 6;
						continue;
						Block_3:
						try
						{
							IL_1E0:
							strViewName = obj.ToString();
							goto IL_288;
						}
						catch (global::System.Exception innerException)
						{
							uint num2 = 1370U;
							global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetViewSelection", global::System.Environment.StackTrace.ToString());
							ex.AddErrorMessage(innerException);
							throw ex;
						}
						goto IL_224;
						IL_288:
						flag = false;
						num = 5;
						continue;
						try
						{
							IL_C0:
							for (;;)
							{
								strResourceFile = obj.ToString();
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 0:
									{
										if (!flag)
										{
											num = 6;
											continue;
										}
										string empty = string.Empty;
										this.GetViewFolderPath(ref empty);
										strResourceFile = empty + "\\" + strResourceFile + ".lmx";
										num = 4;
										continue;
									}
									case 1:
									{
										strResourceFile = strResourceFile.Remove(0, 1);
										string empty2;
										strResourceFile = strResourceFile.Insert(0, empty2);
										num = 5;
										continue;
									}
									case 2:
										goto IL_19D;
									case 3:
										if (strResourceFile.IndexOf(".\\", global::System.StringComparison.Ordinal) == 0)
										{
											num = 1;
											continue;
										}
										goto IL_191;
									case 4:
										goto IL_191;
									case 5:
										goto IL_191;
									case 6:
									{
										string empty2 = string.Empty;
										this.GetInstallPath(ref empty2);
										num = 3;
										continue;
									}
									}
									break;
									IL_191:
									num = 2;
								}
							}
							IL_19D:
							return;
						}
						catch (global::System.Exception innerException2)
						{
							uint num3 = 1370U;
							global::custom_exception.CCustomException ex2 = global::RegistryAccess.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "GetViewSelection", global::System.Environment.StackTrace.ToString());
							ex2.AddErrorMessage(innerException2);
							throw ex2;
						}
						goto Block_3;
						IL_283:
						goto IL_C0;
					}
				}
				return;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004BC4 File Offset: 0x00003BC4
		public void SetTransmitOffset(string strTransmitOffset)
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
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "TransmitOffset", strTransmitOffset, null, 2U);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004C14 File Offset: 0x00003C14
		public void GetTransmitOffset(ref string strTransmitOffset)
		{
			for (;;)
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "TransmitOffset", out obj, null, 2U);
				try
				{
					strTransmitOffset = obj.ToString();
				}
				catch (global::System.Exception innerException)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetTransmitOffset", global::System.Environment.StackTrace.ToString());
					string message = string.Format("strTransmitOffset: {0}", strTransmitOffset.ToString());
					ex.AddErrorMessage(message, innerException);
					throw ex;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_83;
				}
			}
			IL_83:
			if (false)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004CCC File Offset: 0x00003CCC
		public void GetSoundStatus(ref bool SoundOn)
		{
			for (;;)
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "PlaySound", out obj, null, 2U);
				try
				{
					if (true)
					{
					}
					SoundOn = global::System.Convert.ToBoolean(global::System.Convert.ToInt32(obj.ToString(), global::System.Globalization.NumberFormatInfo.InvariantInfo), global::System.Globalization.NumberFormatInfo.InvariantInfo);
				}
				catch (global::System.Exception innerException)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetSoundStatus", global::System.Environment.StackTrace.ToString());
					ex.AddErrorMessage(innerException);
					throw ex;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8F;
				}
			}
			IL_8F:
			if (false)
			{
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004D88 File Offset: 0x00003D88
		public void SetSoundStatus(bool SoundOn)
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
			object a_ = global::System.Convert.ToInt32(SoundOn);
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "PlaySound", a_, null, 2U);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004DE4 File Offset: 0x00003DE4
		public void GetCloneRadioIdentity(ref bool bCloneRadioIdentity)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			}
			if (true)
			{
			}
			if (false)
			{
			}
			object obj = null;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CloneRadioIdentity", out obj, null, 2U);
			try
			{
				bCloneRadioIdentity = global::System.Convert.ToBoolean(global::System.Convert.ToInt32(obj.ToString(), global::System.Globalization.NumberFormatInfo.InvariantInfo), global::System.Globalization.NumberFormatInfo.InvariantInfo);
			}
			catch (global::System.Exception innerException)
			{
				uint num = 1370U;
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetCloneRadioIdentity", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(innerException);
				throw ex;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004EA0 File Offset: 0x00003EA0
		public void SetCloneRadioIdentity(bool bCloneRadioIdentity)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			object a_ = global::System.Convert.ToInt32(bCloneRadioIdentity);
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CloneRadioIdentity", a_, null, 2U);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004EFC File Offset: 0x00003EFC
		public void GetNoShowWarning(string id, ref global::System.Collections.ArrayList alNoShowWarning)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 16;
					for (;;)
					{
						global::Microsoft.Win32.RegistryKey registryKey;
						int num2;
						string[] array;
						switch (num)
						{
						case 0:
							goto IL_DC;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_DC;
							default:
								goto IL_23F;
							}
							break;
						case 2:
						{
							if (id == string.Empty)
							{
								num = 8;
								continue;
							}
							global::RegistryAccess.NoShowWarning noShowWarning = default(global::RegistryAccess.NoShowWarning);
							object value = registryKey.GetValue(id);
							num = 9;
							continue;
						}
						case 3:
							alNoShowWarning = new global::System.Collections.ArrayList();
							num = 0;
							continue;
						case 4:
							goto IL_1DA;
						case 5:
							goto IL_21D;
						case 6:
						{
							if (num2 >= array.Length)
							{
								num = 13;
								continue;
							}
							string text = array[num2];
							global::RegistryAccess.NoShowWarning noShowWarning = default(global::RegistryAccess.NoShowWarning);
							noShowWarning.ID = text;
							noShowWarning.Value = global::System.Convert.ToInt32(registryKey.GetValue(text).ToString(), global::System.Globalization.NumberFormatInfo.InvariantInfo);
							alNoShowWarning.Add(noShowWarning);
							num2++;
							num = 4;
							continue;
						}
						case 7:
							goto IL_21D;
						case 8:
							goto IL_202;
						case 9:
						{
							object value;
							if (value != null)
							{
								num = 15;
								continue;
							}
							alNoShowWarning.Clear();
							num = 7;
							continue;
						}
						case 10:
							num = 2;
							continue;
						case 11:
							goto IL_21D;
						case 12:
							goto IL_1DA;
						case 13:
							num = 5;
							continue;
						case 14:
							if (id != null)
							{
								num = 10;
								continue;
							}
							goto IL_202;
						case 15:
						{
							global::RegistryAccess.NoShowWarning noShowWarning;
							noShowWarning.ID = id;
							object value;
							noShowWarning.Value = global::System.Convert.ToInt32(value.ToString(), global::System.Globalization.NumberFormatInfo.InvariantInfo);
							alNoShowWarning.Add(noShowWarning);
							num = 11;
							continue;
						}
						}
						if (alNoShowWarning == null)
						{
							num = 3;
							continue;
						}
						IL_DC:
						registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(global::RegistryAccess.a.a7);
						num = 14;
						continue;
						IL_1DA:
						num = 6;
						continue;
						IL_202:
						string[] valueNames = registryKey.GetValueNames();
						array = valueNames;
						num2 = 0;
						num = 12;
						continue;
						IL_21D:
						num = 1;
					}
					IL_23F:
					if (false)
					{
					}
					break;
				}
				}
			}
			catch (global::System.Security.SecurityException innerException)
			{
				uint num3 = 1116U;
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "GetNoShowWarning", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(innerException);
				throw ex;
			}
			catch (global::System.Exception innerException2)
			{
				uint num4 = 1370U;
				global::custom_exception.CCustomException ex2 = global::RegistryAccess.CCustomExceptionHandler.CreateException(num4 & 65535U, base.GetType().ToString(), "GetNoShowWarning", global::System.Environment.StackTrace.ToString());
				ex2.AddErrorMessage(innerException2);
				throw ex2;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005214 File Offset: 0x00004214
		public void SetNoShowWarning(global::System.Collections.ArrayList alNoShowWarning)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 4;
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						global::Microsoft.Win32.RegistryKey registryKey;
						switch (num)
						{
						case 0:
							goto IL_192;
						case 1:
							if (alNoShowWarning.Count == 0)
							{
								goto IL_88;
							}
							goto IL_15D;
						case 2:
							goto IL_6F;
						case 3:
							goto IL_66;
						case 5:
							num = 1;
							continue;
						case 6:
							try
							{
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
									{
										if (!enumerator.MoveNext())
										{
											num = 2;
											continue;
										}
										global::RegistryAccess.NoShowWarning noShowWarning = (global::RegistryAccess.NoShowWarning)enumerator.Current;
										registryKey.SetValue(noShowWarning.ID, noShowWarning.Value);
										num = 3;
										continue;
									}
									case 2:
										num = 4;
										continue;
									case 4:
										goto IL_112;
									}
									IL_BB:
									num = 0;
									continue;
									goto IL_BB;
								}
								IL_112:
								goto IL_186;
							}
							finally
							{
								for (;;)
								{
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									num = 0;
									for (;;)
									{
										switch (num)
										{
										case 0:
											if (disposable != null)
											{
												num = 2;
												continue;
											}
											goto IL_15C;
										case 1:
											goto IL_15A;
										case 2:
											disposable.Dispose();
											num = 1;
											continue;
										}
										break;
									}
								}
								IL_15A:
								IL_15C:;
							}
							goto IL_15D;
							IL_186:
							num = 0;
							continue;
						}
						if (alNoShowWarning != null)
						{
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_88;
							default:
								if (false)
								{
								}
								num = 5;
								continue;
							}
						}
						IL_66:
						num = 2;
						continue;
						IL_88:
						num = 3;
						continue;
						IL_15D:
						registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey(global::RegistryAccess.a.a7);
						enumerator = alNoShowWarning.GetEnumerator();
						num = 6;
					}
					IL_6F:
					IL_192:
					break;
				}
				}
			}
			catch (global::System.Security.SecurityException innerException)
			{
				uint num2 = 1116U;
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetNoShowWarning", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(innerException);
				throw ex;
			}
			catch (global::System.Exception innerException2)
			{
				uint num3 = 1370U;
				global::custom_exception.CCustomException ex2 = global::RegistryAccess.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "GetNoShowWarning", global::System.Environment.StackTrace.ToString());
				ex2.AddErrorMessage(innerException2);
				throw ex2;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000548C File Offset: 0x0000448C
		public void SetSystemKeyLocation(string sysKeyLocation)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "SoftwareSystemKeyLocation", sysKeyLocation, null, 2U);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000054DC File Offset: 0x000044DC
		public void GetSystemKeyLocation(ref string sysKeyLocation)
		{
			for (;;)
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "SoftwareSystemKeyLocation", out obj, null, 2U);
				try
				{
					sysKeyLocation = obj.ToString();
				}
				catch (global::System.Exception innerException)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetSystemKeyLocation", global::System.Environment.StackTrace.ToString());
					ex.AddErrorMessage(innerException);
					throw ex;
				}
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_76;
				}
			}
			IL_76:
			if (false)
			{
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005580 File Offset: 0x00004580
		public void SetTcpPort(ushort tcpPort)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			object a_ = tcpPort;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "TcpPort", a_, null, 2U);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000055D4 File Offset: 0x000045D4
		public void GetTcpPort(ref ushort tcpPort)
		{
			for (;;)
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "TcpPort", out obj, null, 2U);
				try
				{
					tcpPort = ushort.Parse(obj.ToString());
				}
				catch (global::System.Exception innerException)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetTcpPort", global::System.Environment.StackTrace.ToString());
					ex.AddErrorMessage(innerException);
					throw ex;
				}
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				}
				break;
			}
			if (false)
			{
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000567C File Offset: 0x0000467C
		public void GetDatabasePath(ref string databaseLocation)
		{
			if (true)
			{
			}
			switch (0)
			{
			default:
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DatabasePath", out obj, null, 1U);
				try
				{
					for (;;)
					{
						databaseLocation = obj.ToString();
						int num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_AB;
							case 1:
								goto IL_B7;
							case 2:
								if (databaseLocation.IndexOf(global::System.IO.Path.DirectorySeparatorChar) >= 0)
								{
									goto IL_AB;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									if (false)
									{
									}
									num = 3;
									continue;
								}
								break;
							case 3:
								databaseLocation += global::System.IO.Path.DirectorySeparatorChar;
								num = 0;
								continue;
							}
							break;
							IL_AB:
							num = 1;
						}
					}
					IL_B7:;
				}
				catch (global::System.Exception innerException)
				{
					uint num2 = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetDatabasePath", global::System.Environment.StackTrace.ToString());
					ex.AddErrorMessage(innerException);
					throw ex;
				}
				return;
			}
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00005794 File Offset: 0x00004794
		public void SetVAWorkerLocation(string vaWorkerLocation)
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
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "VAWorkerLocation", vaWorkerLocation, null, 2U);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000057E4 File Offset: 0x000047E4
		public void GetVAWorkeLocation(ref string vaWorkerLocation)
		{
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
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "VAWorkerLocation", out obj, null, 2U);
				try
				{
					if (true)
					{
					}
					vaWorkerLocation = obj.ToString();
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetSystemKeyLocation", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				break;
			}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005880 File Offset: 0x00004880
		public void SetVAExportLocation(string vaExportLocation)
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
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "VAExportLocation", vaExportLocation, null, 2U);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000058D0 File Offset: 0x000048D0
		public void GetVAExportLocation(ref string vaExportLocation)
		{
			for (;;)
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "VAExportLocation", out obj, null, 2U);
				try
				{
					vaExportLocation = obj.ToString();
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetSystemKeyLocation", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				}
				break;
			}
			if (false)
			{
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000596C File Offset: 0x0000496C
		public void GetColumnEnable(ref global::System.Collections.BitArray columnMap)
		{
			for (;;)
			{
				switch (0)
				{
				default:
					if (true)
					{
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_36;
					}
					break;
				}
			}
			IL_36:
			if (false)
			{
			}
			object obj = null;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ColumnEnable", out obj, null, 2U);
			try
			{
				for (;;)
				{
					string text = (string)obj;
					columnMap = new global::System.Collections.BitArray(text.Length);
					int num = 0;
					int num2 = 7;
					for (;;)
					{
						bool flag;
						int num3;
						int num4;
						switch (num2)
						{
						case 0:
							num2 = 11;
							continue;
						case 1:
							flag = true;
							goto IL_14E;
						case 2:
							num3 = 0;
							goto IL_FD;
						case 3:
							if (text[num] != '1')
							{
								num2 = 12;
								continue;
							}
							num2 = 10;
							continue;
						case 4:
							if (num4 != 1)
							{
								num2 = 0;
								continue;
							}
							num2 = 1;
							continue;
						case 5:
							num2 = 6;
							continue;
						case 6:
							goto IL_178;
						case 7:
							goto IL_11C;
						case 8:
							goto IL_11C;
						case 9:
							if (num >= text.Length)
							{
								num2 = 5;
								continue;
							}
							num2 = 3;
							continue;
						case 10:
							num3 = 1;
							goto IL_FD;
						case 11:
							flag = false;
							goto IL_14E;
						case 12:
							num2 = 2;
							continue;
						}
						break;
						IL_FD:
						num4 = num3;
						num2 = 4;
						continue;
						IL_11C:
						num2 = 9;
						continue;
						IL_14E:
						bool value = flag;
						columnMap.Set(num, value);
						num++;
						num2 = 8;
					}
				}
				IL_178:;
			}
			catch (global::System.Exception)
			{
				uint num5 = 1370U;
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num5 & 65535U, base.GetType().ToString(), "GetAlarmEnable", global::System.Environment.StackTrace.ToString());
				throw ex;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005B44 File Offset: 0x00004B44
		public void SetColumnEnable(global::System.Collections.BitArray columnMap)
		{
			switch (0)
			{
			default:
			{
				string text;
				for (;;)
				{
					text = string.Empty;
					int num = 0;
					int num2 = 1;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_83;
						case 1:
							goto IL_3A;
						case 2:
							if (num >= columnMap.Count)
							{
								num2 = 0;
								continue;
							}
							text += global::System.Convert.ToInt16(columnMap.Get(num)).ToString();
							num++;
							num2 = 3;
							continue;
						case 3:
							goto IL_3A;
						}
						break;
						IL_3A:
						if (true)
						{
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						}
						if (false)
						{
						}
						num2 = 2;
					}
				}
				IL_83:
				object a_ = text;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ColumnEnable", a_, null, 2U);
				return;
			}
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00005C18 File Offset: 0x00004C18
		public void GetIntermediaryInfo(ref string ipAddress, ref uint port)
		{
			for (;;)
			{
				string text = string.Empty;
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Controller", out obj, null, 2U);
				try
				{
					text = obj.ToString();
					string[] array = text.Split(new char[]
					{
						':'
					});
					ipAddress = array[0];
					string value = array[1];
					port = global::System.Convert.ToUInt32(value, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetIntermediaryInfo", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_9D;
				}
			}
			IL_9D:
			if (true)
			{
			}
			if (false)
			{
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00005CEC File Offset: 0x00004CEC
		public void SetIntermediaryInfo(string ipAddress, uint port)
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
			string arg = global::System.Convert.ToString(port, global::System.Globalization.CultureInfo.InvariantCulture);
			object a_ = ipAddress + ":" + arg;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Controller", a_, null, 2U);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005D54 File Offset: 0x00004D54
		public void GetKeepAlive(ref uint keepAlive)
		{
			for (;;)
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "KeepAlive", out obj, null, 2U);
				try
				{
					keepAlive = global::System.Convert.ToUInt32(obj.ToString(), global::System.Globalization.CultureInfo.InvariantCulture);
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetKeepAlive", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_79;
				}
			}
			IL_79:
			if (false)
			{
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00005DFC File Offset: 0x00004DFC
		public void SetKeepAlive(uint keepAlive)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			object a_ = keepAlive;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "KeepAlive", a_, null, 2U);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00005E50 File Offset: 0x00004E50
		public void GetSourcePort(ref uint sourcePort)
		{
			for (;;)
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "SourcePort", out obj, null, 2U);
				try
				{
					sourcePort = global::System.Convert.ToUInt32(obj.ToString(), global::System.Globalization.CultureInfo.InvariantCulture);
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetSourcePort", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7B;
				}
			}
			IL_7B:
			if (false)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00005EF8 File Offset: 0x00004EF8
		public void SetSourcePort(uint sourcePort)
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
			object a_ = sourcePort;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "SourcePort", a_, null, 2U);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005F4C File Offset: 0x00004F4C
		public void GetRetryTimer(ref uint timer)
		{
			for (;;)
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "RetryTimer", out obj, null, 2U);
				try
				{
					timer = global::System.Convert.ToUInt32(obj.ToString(), global::System.Globalization.CultureInfo.InvariantCulture);
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetRetryTimer", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_83;
				}
			}
			IL_83:
			if (false)
			{
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00005FF4 File Offset: 0x00004FF4
		public void SetRetryTimer(uint timer)
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
			object a_ = timer;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "RetryTimer", a_, null, 2U);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00006048 File Offset: 0x00005048
		public void GetAppID(ref uint peerID)
		{
			if (true)
			{
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
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "AppID", out obj, null, 2U);
				try
				{
					peerID = global::System.Convert.ToUInt32(obj.ToString(), global::System.Globalization.CultureInfo.InvariantCulture);
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetAppID", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				break;
			}
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000060F0 File Offset: 0x000050F0
		public void SetAppID(uint peerID)
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
			object a_ = peerID;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "AppID", a_, null, 2U);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00006144 File Offset: 0x00005144
		public void GetAuthentication(ref byte[] authKey)
		{
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
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Authentication", out obj, null, 2U);
				try
				{
					authKey = (byte[])obj;
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetAuthentication", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				break;
			}
			}
			if (true)
			{
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000061E0 File Offset: 0x000051E0
		public void SetAuthentication(byte[] authKey)
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
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Authentication", authKey, null, 2U);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00006230 File Offset: 0x00005230
		public void GetAutoReg(ref bool autoReg)
		{
			for (;;)
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "AutoReg", out obj, null, 2U);
				try
				{
					autoReg = global::System.Convert.ToBoolean(global::System.Convert.ToInt32(obj.ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetAutoReg", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_76;
				}
			}
			IL_76:
			if (true)
			{
			}
			if (false)
			{
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000062DC File Offset: 0x000052DC
		public void SetAutoReg(bool autoReg)
		{
			int num;
			for (;;)
			{
				num = 0;
				int num2 = 2;
				for (;;)
				{
					if (true)
					{
					}
					switch (num2)
					{
					case 0:
						num = 1;
						num2 = 1;
						continue;
					case 1:
						goto IL_49;
					case 2:
						IL_26:
						if (autoReg)
						{
							num2 = 0;
							continue;
						}
						goto IL_49;
					}
					break;
					IL_49:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_26;
					default:
						goto IL_5F;
					}
				}
			}
			IL_5F:
			if (false)
			{
			}
			object a_ = num;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "AutoReg", a_, null, 2U);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00006368 File Offset: 0x00005368
		public void GetConnection(ref bool connection)
		{
			for (;;)
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Connection", out obj, null, 2U);
				try
				{
					connection = global::System.Convert.ToBoolean(global::System.Convert.ToInt32(obj.ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetConnection", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_76;
				}
			}
			IL_76:
			if (true)
			{
			}
			if (false)
			{
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00006414 File Offset: 0x00005414
		public void SetConnection(bool connection)
		{
			int num;
			for (;;)
			{
				IL_3A:
				if (true)
				{
				}
				num = 0;
				int num2 = 1;
				for (;;)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					default:
						if (false)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_63;
						case 1:
							if (connection)
							{
								num2 = 2;
								continue;
							}
							goto IL_65;
						case 2:
							num = 1;
							num2 = 0;
							continue;
						}
						goto IL_3A;
					}
				}
			}
			IL_63:
			IL_65:
			object a_ = num;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "Connection", a_, null, 2U);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000064A0 File Offset: 0x000054A0
		public void GetHasConfigured(ref bool isConfigured)
		{
			if (true)
			{
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
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "HasConfigured", out obj, null, 2U);
				try
				{
					isConfigured = global::System.Convert.ToBoolean(global::System.Convert.ToInt32(obj.ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetHasConfigured", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				break;
			}
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000654C File Offset: 0x0000554C
		public void SetHasConfigured(bool isConfigured)
		{
			int num2;
			for (;;)
			{
				IL_14:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				case 1:
					goto IL_34;
				default:
					goto IL_34;
				}
				IL_3C:
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_63;
					case 1:
						if (isConfigured)
						{
							num = 2;
							continue;
						}
						goto IL_65;
					case 2:
						if (true)
						{
						}
						num2 = 1;
						num = 0;
						continue;
					}
					goto IL_14;
				}
				IL_34:
				if (false)
				{
				}
				num2 = 0;
				goto IL_3C;
			}
			IL_63:
			IL_65:
			object a_ = num2;
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "HasConfigured", a_, null, 2U);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000065D8 File Offset: 0x000055D8
		public void GetEmailStatus(ref bool EmailOn)
		{
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
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "EmailNotification", out obj, null, 2U);
				try
				{
					EmailOn = global::System.Convert.ToBoolean(global::System.Convert.ToInt32(obj.ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetEmailStatus", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				break;
			}
			}
			if (true)
			{
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00006684 File Offset: 0x00005684
		public void SetEmailStatus(bool EmailOn)
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
			object a_ = global::System.Convert.ToInt32(EmailOn);
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "EmailNotification", a_, null, 2U);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000066E0 File Offset: 0x000056E0
		public void GetDiagnosticLoggingStatus(ref bool isDiagnosticLoggingOn)
		{
			for (;;)
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DiagnosticLogging", out obj, null, 2U);
				try
				{
					isDiagnosticLoggingOn = global::System.Convert.ToBoolean(global::System.Convert.ToInt32(obj.ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetDiagnosticLoggingStatus", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_76;
				}
			}
			IL_76:
			if (true)
			{
			}
			if (false)
			{
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000678C File Offset: 0x0000578C
		public void SetDiagnosticLoggingStatus(bool isDiagnosticLoggingOn)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			object a_ = global::System.Convert.ToInt32(isDiagnosticLoggingOn);
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DiagnosticLogging", a_, null, 2U);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000067E8 File Offset: 0x000057E8
		public void GetDiagnosticInterval(ref uint diagnosticInterval)
		{
			for (;;)
			{
				if (true)
				{
				}
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DiagnosticInterval", out obj, null, 2U);
				try
				{
					diagnosticInterval = global::System.Convert.ToUInt32(global::System.Convert.ToInt32(obj.ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetDiagnosticInterval", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_88;
				}
			}
			IL_88:
			if (false)
			{
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006894 File Offset: 0x00005894
		public void SetDiagnosticInterval(uint diagnosticInterval)
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
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "DiagnosticInterval", diagnosticInterval, null, 2U);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000068E8 File Offset: 0x000058E8
		public void GetLogDVStatus(ref bool LogDVOn)
		{
			if (true)
			{
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
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "LogDigitalVoting", out obj, null, 2U);
				try
				{
					LogDVOn = global::System.Convert.ToBoolean(global::System.Convert.ToInt32(obj.ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetLogDVStatus", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				break;
			}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00006994 File Offset: 0x00005994
		public void SetLogDVStatus(bool LogDVOn)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			object a_ = global::System.Convert.ToInt32(LogDVOn);
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "LogDigitalVoting", a_, null, 2U);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000069F0 File Offset: 0x000059F0
		public void GetHidenWhenMinimize(ref bool HidenOn)
		{
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
				if (true)
				{
				}
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "HidenWhenMinimize", out obj, null, 2U);
				try
				{
					HidenOn = global::System.Convert.ToBoolean(global::System.Convert.ToInt32(obj.ToString(), global::System.Globalization.CultureInfo.InvariantCulture));
				}
				catch (global::System.Exception)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetHidenWhenMinimize", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				break;
			}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00006A9C File Offset: 0x00005A9C
		public void SetHidenWhenMinimize(bool HidenOn)
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
			object a_ = global::System.Convert.ToInt32(HidenOn);
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "HidenWhenMinimize", a_, null, 2U);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00006AF8 File Offset: 0x00005AF8
		private static string a(uint A_0)
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
			return new global::System.Net.IPAddress((long)((ulong)A_0)).ToString();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00006B40 File Offset: 0x00005B40
		private static uint a(string A_0)
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
			global::System.Net.IPAddress ipaddress = global::System.Net.IPAddress.Parse(A_0);
			byte[] addressBytes = ipaddress.GetAddressBytes();
			uint num = (uint)((uint)addressBytes[3] << 24);
			num += (uint)((uint)addressBytes[2] << 16);
			num += (uint)((uint)addressBytes[1] << 8);
			return num + (uint)addressBytes[0];
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00006BA8 File Offset: 0x00005BA8
		public global::RegistryAccess.UpgradePackageRegInfo[] GetUpgradePackageRegInfo()
		{
			if (true)
			{
			}
			switch (0)
			{
			default:
			{
				global::System.Collections.Generic.List<global::RegistryAccess.UpgradePackageRegInfo> list = new global::System.Collections.Generic.List<global::RegistryAccess.UpgradePackageRegInfo>();
				string bb = global::RegistryAccess.a.bb;
				global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.LocalMachine;
				try
				{
					for (;;)
					{
						IL_5D:
						registryKey = registryKey.OpenSubKey(bb);
						int num;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_AA:
							goto IL_E9;
						default:
							if (false)
							{
							}
							num = 3;
							break;
						}
						for (;;)
						{
							IL_36:
							switch (num)
							{
							case 0:
								goto IL_2C0;
							case 1:
								goto IL_99;
							case 2:
								goto IL_13D;
							case 3:
							{
								if (registryKey == null)
								{
									num = 1;
									continue;
								}
								string[] subKeyNames = registryKey.GetSubKeyNames();
								int num2 = 0;
								num = 2;
								continue;
							}
							case 4:
								goto IL_AA;
							case 5:
							{
								try
								{
									for (;;)
									{
										global::RegistryAccess.UpgradePackageRegInfo upgradePackageRegInfo = new global::RegistryAccess.UpgradePackageRegInfo();
										string text;
										upgradePackageRegInfo.GUID = text;
										global::Microsoft.Win32.RegistryKey registryKey2 = registryKey.OpenSubKey(text);
										string[] valueNames = registryKey2.GetValueNames();
										upgradePackageRegInfo.Title = registryKey2.GetValue("Title").ToString();
										upgradePackageRegInfo.Type = registryKey2.GetValue("Type").ToString();
										upgradePackageRegInfo.Region = registryKey2.GetValue("Region").ToString();
										global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
										global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("^Path[0-9]*$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
										string[] array = valueNames;
										int num3 = 0;
										num = 5;
										for (;;)
										{
											switch (num)
											{
											case 0:
												goto IL_1FF;
											case 1:
											{
												string text2;
												if (regex.IsMatch(text2))
												{
													num = 4;
													continue;
												}
												goto IL_270;
											}
											case 2:
												goto IL_2A9;
											case 3:
												goto IL_270;
											case 4:
											{
												string text2;
												list2.Add(registryKey2.GetValue(text2).ToString());
												num = 3;
												continue;
											}
											case 5:
												goto IL_1FF;
											case 6:
												upgradePackageRegInfo.Path = list2.ToArray();
												list.Add(upgradePackageRegInfo);
												num = 2;
												continue;
											case 7:
											{
												if (num3 >= array.Length)
												{
													num = 6;
													continue;
												}
												string text2 = array[num3];
												num = 1;
												continue;
											}
											}
											break;
											IL_1FF:
											num = 7;
											continue;
											IL_270:
											num3++;
											num = 0;
										}
									}
									IL_2A9:
									goto IL_9B;
								}
								catch (global::System.Exception)
								{
									goto IL_9B;
								}
								goto IL_2B4;
								IL_9B:
								int num2;
								num2++;
								num = 4;
								continue;
							}
							case 6:
								goto IL_2B4;
							case 7:
							{
								string[] subKeyNames;
								int num2;
								if (num2 >= subKeyNames.Length)
								{
									num = 6;
									continue;
								}
								string text = subKeyNames[num2];
								num = 5;
								continue;
							}
							}
							goto IL_5D;
							IL_2B4:
							num = 0;
						}
						IL_13D:
						IL_E9:
						num = 7;
						goto IL_36;
					}
					IL_99:
					uint num4 = 1798U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num4 & 65535U, base.GetType().ToString(), "GetUpgradePackageRegInfo", global::System.Environment.StackTrace.ToString());
					ex.AddErrorMessage("There is no package installed.");
					throw ex;
					IL_2C0:;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.Exception innerException)
				{
					uint num5 = 1798U;
					global::custom_exception.CCustomException ex2 = global::RegistryAccess.CCustomExceptionHandler.CreateException(num5 & 65535U, base.GetType().ToString(), "GetUpgradePackageRegInfo", global::System.Environment.StackTrace.ToString());
					ex2.AddErrorMessage(innerException);
					throw ex2;
				}
				return list.ToArray();
			}
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00006F0C File Offset: 0x00005F0C
		// Note: this type is marked as 'beforefieldinit'.
		static CPersistentApplicationSettings()
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
			global::RegistryAccess.CPersistentApplicationSettings.a = 4;
		}

		// Token: 0x0400000D RID: 13
		private static int a;
	}
}
