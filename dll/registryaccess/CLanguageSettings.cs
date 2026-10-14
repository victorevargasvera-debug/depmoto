using System;
using System.Collections;
using System.IO;
using custom_exception;
using Microsoft.Win32;

namespace RegistryAccess
{
	// Token: 0x0200000A RID: 10
	public class CLanguageSettings : global::RegistryAccess.ILanguageSettings
	{
		// Token: 0x0600005E RID: 94 RVA: 0x000024D4 File Offset: 0x000014D4
		public CLanguageSettings()
		{
			if (string.IsNullOrEmpty(global::RegistryAccess.CRegistryAccess.f))
			{
				uint num = 1U;
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, "RegistryAccess.CLanguageSettings", "CLanguageSettings", global::System.Environment.StackTrace.ToString());
				throw ex;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000251C File Offset: 0x0000151C
		private void a(string A_0, ref string A_1)
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
						continue;
					}
					goto Block_0;
				}
			}
			Block_0:
			if (true)
			{
			}
			if (false)
			{
			}
			object obj = null;
			global::RegistryAccess.a.a(global::RegistryAccess.a.ba, A_1, out obj, A_0, 1U);
			try
			{
				for (;;)
				{
					A_1 = obj.ToString();
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_CF;
						case 1:
						{
							A_1 = A_1.Remove(0, 2);
							string empty = string.Empty;
							new global::RegistryAccess.CPersistentApplicationSettings().GetInstallPath(ref empty);
							A_1 = global::System.IO.Path.Combine(empty, A_1);
							num = 3;
							continue;
						}
						case 2:
							if (A_1.IndexOf(".\\", global::System.StringComparison.Ordinal) == 0)
							{
								num = 1;
								continue;
							}
							goto IL_C6;
						case 3:
							goto IL_C6;
						}
						break;
						IL_C6:
						num = 0;
					}
				}
				IL_CF:;
			}
			catch (global::System.Exception innerException)
			{
				uint num2 = 1370U;
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetResourceFile", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(innerException);
				throw ex;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002644 File Offset: 0x00001644
		public void GetGUIResourceFile(string languageID, ref string GUIPathAndName)
		{
			try
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
				GUIPathAndName = "GUIResource";
				this.a(languageID, ref GUIPathAndName);
			}
			catch (global::System.Exception)
			{
				throw;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000026A4 File Offset: 0x000016A4
		public void GetImageResourceFile(ref string strImagePathAndName)
		{
			switch (0)
			{
			default:
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "ImageResource", out obj, null, 2U);
				try
				{
					for (;;)
					{
						strImagePathAndName = obj.ToString();
						string value = "";
						new global::RegistryAccess.CPersistentApplicationSettings().GetInstallPath(ref value);
						int num = 1;
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									if (false)
									{
									}
									goto IL_B8;
								}
								break;
							case 1:
								if (strImagePathAndName.IndexOf(".\\", global::System.StringComparison.Ordinal) == 0)
								{
									num = 3;
									continue;
								}
								goto IL_B8;
							case 2:
								goto IL_C4;
							case 3:
								strImagePathAndName = strImagePathAndName.Remove(0, 1);
								strImagePathAndName = strImagePathAndName.Insert(0, value);
								num = 0;
								continue;
							}
							break;
							IL_B8:
							num = 2;
						}
					}
					IL_C4:;
				}
				catch (global::System.Exception)
				{
					uint num2 = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetImageResourceFile", global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				if (true)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000027CC File Offset: 0x000017CC
		public void GetHelpFile(string strLanguageID, ref string strHelpFilePathAndName)
		{
			switch (0)
			{
			default:
			{
				object obj = null;
				global::RegistryAccess.a.a(global::RegistryAccess.a.ba, "HelpFileName", out obj, strLanguageID, 1U);
				try
				{
					for (;;)
					{
						strHelpFilePathAndName = obj.ToString();
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_BA;
								default:
									if (false)
									{
									}
									if (strHelpFilePathAndName.IndexOf(".\\", global::System.StringComparison.Ordinal) == 0)
									{
										num = 3;
										continue;
									}
									goto IL_BA;
								}
								break;
							case 1:
								goto IL_C6;
							case 2:
								goto IL_BA;
							case 3:
							{
								strHelpFilePathAndName = strHelpFilePathAndName.Remove(0, 2);
								string empty = string.Empty;
								new global::RegistryAccess.CPersistentApplicationSettings().GetInstallPath(ref empty);
								strHelpFilePathAndName = global::System.IO.Path.Combine(empty, strHelpFilePathAndName);
								num = 2;
								continue;
							}
							}
							break;
							IL_BA:
							num = 1;
						}
					}
					IL_C6:;
				}
				catch (global::System.Exception innerException)
				{
					uint num2 = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetHelpFile", global::System.Environment.StackTrace.ToString());
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

		// Token: 0x06000063 RID: 99 RVA: 0x00002900 File Offset: 0x00001900
		public void GetXMLHelpFile(string LanguageID, ref string XMLHelpFilePathAndName)
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
			global::RegistryAccess.a.a(global::RegistryAccess.a.ba, "HelpXMLFileName", out obj, LanguageID, 1U);
			try
			{
				for (;;)
				{
					XMLHelpFilePathAndName = obj.ToString();
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_D2;
						case 1:
							if (XMLHelpFilePathAndName.IndexOf(".\\", global::System.StringComparison.Ordinal) == 0)
							{
								num = 3;
								continue;
							}
							goto IL_C9;
						case 2:
							goto IL_C9;
						case 3:
						{
							XMLHelpFilePathAndName = XMLHelpFilePathAndName.Remove(0, 2);
							string empty = string.Empty;
							new global::RegistryAccess.CPersistentApplicationSettings().GetInstallPath(ref empty);
							XMLHelpFilePathAndName = global::System.IO.Path.Combine(empty, XMLHelpFilePathAndName);
							num = 2;
							continue;
						}
						}
						break;
						IL_C9:
						num = 0;
					}
				}
				IL_D2:;
			}
			catch (global::System.Exception innerException)
			{
				uint num2 = 1370U;
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetXMLHelpFile", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(innerException);
				throw ex;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002A2C File Offset: 0x00001A2C
		public void IsRightToLeftLayout(string strLanguageID, ref bool bRightToLeft)
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
				switch (0)
				{
				default:
				{
					if (true)
					{
					}
					object value = null;
					global::RegistryAccess.a.a(global::RegistryAccess.a.ba, "RightToLeftLayout", out value, strLanguageID, 2U);
					bRightToLeft = true;
					try
					{
						for (;;)
						{
							int num = global::System.Convert.ToInt32(value);
							int num2 = 2;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_9B;
								case 1:
									goto IL_A4;
								case 2:
									if (num == 0)
									{
										num2 = 3;
										continue;
									}
									goto IL_9B;
								case 3:
									bRightToLeft = false;
									num2 = 0;
									continue;
								}
								break;
								IL_9B:
								num2 = 1;
							}
						}
						IL_A4:;
					}
					catch (global::System.Exception innerException)
					{
						uint num3 = 1370U;
						global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "IsRightToLeftLayout", global::System.Environment.StackTrace.ToString());
						ex.AddErrorMessage(innerException);
						throw ex;
					}
					break;
				}
				}
				break;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002B2C File Offset: 0x00001B2C
		public void GetLanguageChoices(ref global::System.Collections.ArrayList alLanguagesID, ref global::System.Collections.ArrayList alLanguageName)
		{
			switch (0)
			{
			default:
			{
				uint num;
				string message;
				for (;;)
				{
					if (true)
					{
					}
					alLanguagesID.Clear();
					alLanguageName.Clear();
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
								num2 = 1;
								continue;
							}
							return;
						case 1:
							goto IL_6E;
						case 2:
							try
							{
								for (;;)
								{
									global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(global::RegistryAccess.a.ba);
									string[] subKeyNames = registryKey.GetSubKeyNames();
									string[] array = subKeyNames;
									int num3 = 0;
									num2 = 1;
									for (;;)
									{
										switch (num2)
										{
										case 0:
											num = 0U;
											num2 = 3;
											continue;
										case 1:
											goto IL_B8;
										case 2:
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
												if (num3 >= array.Length)
												{
													num2 = 0;
													continue;
												}
												break;
											}
											string text = array[num3];
											alLanguagesID.Add(text);
											registryKey = global::Microsoft.Win32.Registry.LocalMachine.OpenSubKey(global::RegistryAccess.a.ba + "\\" + text);
											alLanguageName.Add(registryKey.GetValue("DisplayName"));
											num3++;
											num2 = 4;
											continue;
										}
										case 3:
											goto IL_155;
										case 4:
											goto IL_B8;
										}
										break;
										IL_B8:
										num2 = 2;
									}
								}
								IL_155:
								goto IL_56;
							}
							catch (global::System.NullReferenceException)
							{
								num = 1368U;
								message = "rk is null because the specified registry key path is incorrect.";
								goto IL_56;
							}
							catch (global::System.ArgumentException)
							{
								num = 1369U;
								message = "return null when call GetValue( ) because the registry value is unexistent.";
								goto IL_56;
							}
							catch (global::System.FormatException)
							{
								num = 1370U;
								message = "can't cast a data type to a uncompatible data type";
								goto IL_56;
							}
							goto IL_190;
							IL_56:
							num2 = 0;
							continue;
						}
						break;
					}
				}
				IL_6E:
				IL_190:
				global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetLanguageChoices", global::System.Environment.StackTrace.ToString());
				ex.AddErrorMessage(message);
				throw ex;
			}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002D24 File Offset: 0x00001D24
		public void SetLanguageSelection(string strLanguage)
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
			global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentLanguage", strLanguage, null, 2U);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002D74 File Offset: 0x00001D74
		public void GetLanguageSelection(ref string strSelectedLanguage)
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
				global::RegistryAccess.a.a(global::RegistryAccess.CRegistryAccess.e, "CurrentLanguage", out obj, null, 2U);
				try
				{
					strSelectedLanguage = obj.ToString();
				}
				catch (global::System.Exception innerException)
				{
					uint num = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "GetLanguageSelection", global::System.Environment.StackTrace.ToString());
					ex.AddErrorMessage(innerException);
					throw ex;
				}
				break;
			}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002E18 File Offset: 0x00001E18
		public void GetDealerInfo(string strLangID, ref string DealerInfoLeft, ref string DealerInfoMiddle, ref string DealerInfoRight)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				object obj = null;
				object obj2 = null;
				object obj3 = null;
				global::RegistryAccess.a.a(global::RegistryAccess.a.ba, "DealerInfoLeft", out obj, strLangID, 2U);
				global::RegistryAccess.a.a(global::RegistryAccess.a.ba, "DealerInfoMiddle", out obj2, strLangID, 2U);
				global::RegistryAccess.a.a(global::RegistryAccess.a.ba, "DealerInfoRight", out obj3, strLangID, 2U);
				try
				{
					for (;;)
					{
						string[] array = obj as string[];
						string[] array2 = obj2 as string[];
						string[] array3 = obj3 as string[];
						DealerInfoLeft.Remove(0, DealerInfoLeft.Length);
						DealerInfoMiddle.Remove(0, DealerInfoMiddle.Length);
						DealerInfoRight.Remove(0, DealerInfoRight.Length);
						int num = 0;
						int num2 = 0;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (array != null)
								{
									num2 = 10;
									continue;
								}
								goto IL_2B1;
							case 1:
								goto IL_395;
							case 2:
								DealerInfoLeft += "\n";
								num2 = 6;
								continue;
							case 3:
								goto IL_3A1;
							case 4:
								if (num >= array2.Length)
								{
									num2 = 26;
									continue;
								}
								DealerInfoMiddle += array2[num];
								goto IL_316;
							case 5:
								DealerInfoRight += "\n";
								num2 = 14;
								continue;
							case 6:
								goto IL_149;
							case 7:
								num = 0;
								num2 = 19;
								continue;
							case 8:
								if (num < array.Length)
								{
									DealerInfoLeft += array[num];
									num2 = 21;
									continue;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_316;
								default:
									if (false)
									{
									}
									num2 = 20;
									continue;
								}
								break;
							case 9:
								if (num < array2.Length - 1)
								{
									num2 = 17;
									continue;
								}
								goto IL_1EA;
							case 10:
								num = 0;
								num2 = 24;
								continue;
							case 11:
								goto IL_201;
							case 12:
								goto IL_261;
							case 13:
								if (array3 != null)
								{
									num2 = 7;
									continue;
								}
								goto IL_395;
							case 14:
								goto IL_1D6;
							case 15:
								if (array2 != null)
								{
									num2 = 27;
									continue;
								}
								goto IL_1B2;
							case 16:
								goto IL_1EA;
							case 17:
								DealerInfoMiddle += "\n";
								num2 = 16;
								continue;
							case 18:
								if (num >= array3.Length)
								{
									num2 = 1;
									continue;
								}
								DealerInfoRight += array3[num];
								num2 = 22;
								continue;
							case 19:
								goto IL_261;
							case 20:
								goto IL_2B1;
							case 21:
								if (num < array.Length - 1)
								{
									num2 = 2;
									continue;
								}
								goto IL_149;
							case 22:
								if (num < array3.Length - 1)
								{
									num2 = 5;
									continue;
								}
								goto IL_1D6;
							case 23:
								goto IL_351;
							case 24:
								goto IL_201;
							case 25:
								goto IL_351;
							case 26:
								goto IL_1B2;
							case 27:
								num = 0;
								num2 = 23;
								continue;
							}
							break;
							IL_149:
							num++;
							num2 = 11;
							continue;
							IL_1B2:
							num2 = 13;
							continue;
							IL_1D6:
							num++;
							num2 = 12;
							continue;
							IL_1EA:
							num++;
							num2 = 25;
							continue;
							IL_201:
							num2 = 8;
							continue;
							IL_261:
							num2 = 18;
							continue;
							IL_2B1:
							num2 = 15;
							continue;
							IL_316:
							num2 = 9;
							continue;
							IL_351:
							num2 = 4;
							continue;
							IL_395:
							num2 = 3;
						}
					}
					IL_3A1:;
				}
				catch (global::System.Exception innerException)
				{
					uint num3 = 1370U;
					global::custom_exception.CCustomException ex = global::RegistryAccess.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "GetDealerInfo", global::System.Environment.StackTrace.ToString());
					ex.AddErrorMessage(innerException);
					throw ex;
				}
				return;
			}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003224 File Offset: 0x00002224
		public void SetDealerInfo(string strLangID, string DealerInfoLeft, string DealerInfoMiddle, string DealerInfoRight)
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
			global::System.Array a_ = new string[0];
			global::System.Array a_2 = new string[0];
			global::System.Array a_3 = new string[0];
			a_ = DealerInfoLeft.Split(new char[]
			{
				'\n'
			});
			a_2 = DealerInfoMiddle.Split(new char[]
			{
				'\n'
			});
			a_3 = DealerInfoRight.Split(new char[]
			{
				'\n'
			});
			global::RegistryAccess.a.a(global::RegistryAccess.a.ba, "DealerInfoLeft", a_, strLangID, 2U);
			global::RegistryAccess.a.a(global::RegistryAccess.a.ba, "DealerInfoMiddle", a_2, strLangID, 2U);
			global::RegistryAccess.a.a(global::RegistryAccess.a.ba, "DealerInfoRight", a_3, strLangID, 2U);
		}
	}
}
