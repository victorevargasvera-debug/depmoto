using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using CommunicationController;
using constants;
using cpservices;
using custom_exception;
using DeviceUpdate;
using ErrorLogging;
using LdapAuthenticationInterfaceController;
using Motorola.Common.Communication.CommonUtil;

namespace Controller
{
	// Token: 0x02000007 RID: 7
	public class CController : global::Controller.IController
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000055E8 File Offset: 0x000045E8
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0000562C File Offset: 0x0000462C
		public bool IsLocalNormalSTOpen
		{
			get
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
				return this.k;
			}
			set
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
				this.k = value;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005670 File Offset: 0x00004670
		public CController(ref string sInstallPath)
		{
			this.a = new global::System.Collections.ArrayList();
			this.b = false;
			this.c = null;
			this.d = null;
			this.e = null;
			this.h = null;
			this.f = null;
			this.g = sInstallPath;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000056C0 File Offset: 0x000046C0
		public void OpenController()
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (this.c != null)
					{
						num = 4;
						continue;
					}
					goto IL_10D;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
						goto IL_6E;
					}
					break;
				case 4:
					if (true)
					{
					}
					goto IL_3D;
				case 5:
					if (this.e == null)
					{
						num = 3;
						continue;
					}
					goto IL_158;
				}
				if (this.b)
				{
					num = 0;
					continue;
				}
				this.f = new global::LdapAuthenticationInterfaceController.CLdapAuthenticationInterfaceController();
				this.f.Open();
				this.c = new global::Controller.a();
				this.e = new global::ErrorLogging.CLogApplicationError("MOTOTRBO Depot Tool");
				this.d = new global::CommunicationController.CSerialTransportController();
				this.d.OpenController();
				this.h = new global::DeviceUpdate.c();
				this.h.a(true);
				num = 1;
				continue;
				IL_3D:
				num = 5;
			}
			return;
			IL_6E:
			if (false)
			{
			}
			IL_10D:
			this.c = null;
			this.d = null;
			this.e = null;
			this.f = null;
			uint num2 = 1366U;
			global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "OpenController", global::System.Environment.StackTrace.ToString());
			throw ex;
			IL_158:
			this.b = true;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000582C File Offset: 0x0000482C
		public void ReadDevice(ref uint uiHandleToDatabase, string strCommand, global::System.Collections.ArrayList strParameters)
		{
			switch (0)
			{
			default:
			{
				int num = 2;
				global::cpservices.IDatabase database;
				object obj;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_1A4;
					case 1:
						if (database != null)
						{
							this.c.a(uiHandleToDatabase, out obj);
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								if (false)
								{
								}
								num = 3;
								continue;
							}
						}
						num = 0;
						continue;
					case 3:
						if (obj != null)
						{
							num = 7;
							continue;
						}
						goto IL_F2;
					case 4:
						if (uiHandleToDatabase != 0U)
						{
							num = 6;
							continue;
						}
						goto IL_1A9;
					case 5:
						goto IL_54;
					case 6:
						this.a(uiHandleToDatabase, out database);
						if (true)
						{
						}
						num = 1;
						continue;
					case 7:
						goto IL_9D;
					}
					if (!this.b)
					{
						num = 5;
					}
					else
					{
						num = 4;
					}
				}
				IL_54:
				uint num2 = 1361U;
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "ReadDevice", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_9D:
				global::CommunicationController.IRadioCodeplugController interfaceRCCtrl = (global::CommunicationController.IRadioCodeplugController)obj;
				global::cpservices.IDatabase database2 = database;
				database2.ReadDevice(interfaceRCCtrl, strCommand, strParameters);
				return;
				IL_F2:
				num2 = 1371U;
				global::custom_exception.CCustomException ex2 = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "ReadDevice", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_1A4:
				num2 = 1364U;
				global::custom_exception.CCustomException ex3 = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "ReadDevice", global::System.Environment.StackTrace.ToString());
				throw ex3;
				IL_1A9:
				num2 = 1364U;
				global::custom_exception.CCustomException ex4 = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "ReadDevice", global::System.Environment.StackTrace.ToString());
				throw ex4;
			}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005A14 File Offset: 0x00004A14
		public void CloseController()
		{
			if (!this.b)
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
					return;
				}
			}
			this.b = false;
			this.c = null;
			this.d.CloseController();
			this.d = null;
			this.e = null;
			this.h = null;
			this.f.Close();
			this.f = null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005A9C File Offset: 0x00004A9C
		public void OpenConnection(string strIP, ref uint uiHandleToDatabase, global::constants.CCPTags.SetProgressBar pfSetProgressBar)
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
			this.a(strIP, ref uiHandleToDatabase, pfSetProgressBar);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005AE0 File Offset: 0x00004AE0
		public void OpenConnection(string strIP, string strSerialNo, ref uint uiHandleToDatabase, global::constants.CCPTags.SetProgressBar pfSetProgressBar)
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
			this.a(strIP, strSerialNo, ref uiHandleToDatabase, pfSetProgressBar);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005B28 File Offset: 0x00004B28
		public void CloseConnection(uint uiHandleToDatabase)
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
			this.a(uiHandleToDatabase);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005B6C File Offset: 0x00004B6C
		public void GetGemstoneAdditionalVersions(global::CommunicationController.IRadioCodeplugController objRcpController, out string L3, out string config, out string kernel)
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
			string text = string.Empty;
			text = objRcpController.IoControl<string>(global::CommunicationController.enumCommand.QUERYL3BOOTLOADERVERSION.ToString());
			L3 = text;
			text = objRcpController.IoControl<string>(global::CommunicationController.enumCommand.QUERYCONFIGURATIONVERSION.ToString());
			config = text;
			text = objRcpController.IoControl<string>(global::CommunicationController.enumCommand.QUERYKERNELVERSION.ToString());
			kernel = text;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005BF0 File Offset: 0x00004BF0
		private static void a(global::CommunicationController.IRadioCodeplugController A_0, out bool A_1)
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
			bool flag = A_0.IoControl<bool>(global::CommunicationController.enumCommand.QUERYDSPCAPABILITY.ToString());
			A_1 = flag;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005C44 File Offset: 0x00004C44
		private void a(global::CommunicationController.IRadioCodeplugController A_0, out string A_1)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					byte[] array = new byte[]
					{
						40
					};
					byte[] array2 = new byte[]
					{
						44
					};
					double[] array3 = new double[1];
					double[] array4 = new double[1];
					byte[] sourceArray = new byte[1];
					A_0.ReadISHType(129, 4112, ref sourceArray);
					int num = 0;
					if (true)
					{
					}
					int num2 = 31;
					for (;;)
					{
						double num9;
						switch (num2)
						{
						case 0:
							goto IL_292;
						case 1:
							goto IL_1C3;
						case 2:
						{
							int num3;
							if (num3 >= array2.Length)
							{
								num2 = 4;
								continue;
							}
							byte[] array5 = new byte[4];
							global::System.Array.Copy(sourceArray, (int)(array2[num3] + 11), array5, 0, 4);
							int num4 = 0;
							int num5 = 3;
							num2 = 20;
							continue;
						}
						case 3:
						{
							if (num >= array.Length)
							{
								num2 = 17;
								continue;
							}
							byte[] array6 = new byte[4];
							global::System.Array.Copy(sourceArray, (int)(array[num] + 11), array6, 0, 4);
							int num6 = 0;
							int num7 = 3;
							num2 = 26;
							continue;
						}
						case 4:
						{
							A_1 = string.Empty;
							double num8 = array3[0];
							num9 = array4[0];
							num2 = 10;
							continue;
						}
						case 5:
							goto IL_165;
						case 6:
							goto IL_1B2;
						case 7:
						{
							int num6;
							double num10 = (double)(num6 / 200000);
							array3[num] = num10;
							num++;
							num2 = 14;
							continue;
						}
						case 8:
							goto IL_391;
						case 9:
							if (num9 <= 470.0)
							{
								num2 = 8;
								continue;
							}
							goto IL_236;
						case 10:
						{
							double num8;
							if (num8 >= 136.0)
							{
								num2 = 30;
								continue;
							}
							goto IL_396;
						}
						case 11:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1C3;
							default:
							{
								if (false)
								{
								}
								double num8;
								if (num8 >= 450.0)
								{
									num2 = 21;
									continue;
								}
								return;
							}
							}
							break;
						case 12:
						{
							double num8;
							if (num8 >= 400.0)
							{
								num2 = 15;
								continue;
							}
							goto IL_236;
						}
						case 13:
						{
							int num4;
							double num11 = (double)(num4 / 200000);
							int num3;
							array4[num3] = num11;
							num3++;
							num2 = 22;
							continue;
						}
						case 14:
							goto IL_136;
						case 15:
							num2 = 9;
							continue;
						case 16:
							A_1 = "UHF-B2";
							num2 = 0;
							continue;
						case 17:
						{
							int num3 = 0;
							num2 = 18;
							continue;
						}
						case 18:
							goto IL_3E8;
						case 19:
							goto IL_131;
						case 20:
							goto IL_297;
						case 21:
							num2 = 1;
							continue;
						case 22:
							goto IL_3E8;
						case 23:
						{
							double num8;
							if (num8 >= 350.0)
							{
								num2 = 32;
								continue;
							}
							goto IL_43A;
						}
						case 24:
							if (num9 <= 174.0)
							{
								num2 = 19;
								continue;
							}
							goto IL_396;
						case 25:
						{
							int num7;
							if (num7 < 0)
							{
								num2 = 7;
								continue;
							}
							byte[] array6;
							int num6 = (num6 << 8) + (int)array6[num7];
							num7--;
							num2 = 5;
							continue;
						}
						case 26:
							goto IL_165;
						case 27:
						{
							int num5;
							if (num5 < 0)
							{
								num2 = 13;
								continue;
							}
							byte[] array5;
							int num4 = (num4 << 8) + (int)array5[num5];
							num5--;
							num2 = 28;
							continue;
						}
						case 28:
							goto IL_297;
						case 29:
							if (num9 <= 400.0)
							{
								num2 = 6;
								continue;
							}
							goto IL_43A;
						case 30:
							num2 = 24;
							continue;
						case 31:
							goto IL_136;
						case 32:
							num2 = 29;
							continue;
						}
						break;
						IL_136:
						num2 = 3;
						continue;
						IL_165:
						num2 = 25;
						continue;
						IL_1C3:
						if (num9 <= 527.0)
						{
							num2 = 16;
							continue;
						}
						return;
						IL_236:
						num2 = 11;
						continue;
						IL_297:
						num2 = 27;
						continue;
						IL_396:
						num2 = 23;
						continue;
						IL_3E8:
						num2 = 2;
						continue;
						IL_43A:
						num2 = 12;
					}
				}
				IL_131:
				A_1 = "VHF";
				return;
				IL_1B2:
				A_1 = "350";
				return;
				IL_292:
				return;
				IL_391:
				A_1 = "UHF-B1";
				return;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000060C4 File Offset: 0x000050C4
		public bool CanDetectDevice(string ipAddres)
		{
			bool result;
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
				result = true;
				try
				{
					for (;;)
					{
						global::CommunicationController.ISerialTransportController serialTransportController = this.d;
						int num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								global::System.Collections.ArrayList arrayList;
								if (arrayList.Contains(ipAddres))
								{
									num = 7;
									continue;
								}
								result = false;
								num = 4;
								continue;
							}
							case 1:
								goto IL_D1;
							case 2:
								if (serialTransportController != null)
								{
									num = 3;
									continue;
								}
								result = false;
								num = 1;
								continue;
							case 3:
							{
								serialTransportController.OpenController();
								global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
								serialTransportController.ListConnectedDevices(out arrayList);
								num = 0;
								continue;
							}
							case 4:
								goto IL_D1;
							case 5:
								goto IL_DC;
							case 6:
								goto IL_D1;
							case 7:
								result = true;
								num = 6;
								continue;
							}
							break;
							IL_D1:
							num = 5;
						}
					}
					IL_DC:;
				}
				catch (global::custom_exception.CCustomException)
				{
					result = false;
				}
				catch (global::System.Exception)
				{
					result = false;
				}
				break;
			}
			return result;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000061D8 File Offset: 0x000051D8
		public void ListConnectedDevices(out global::System.Collections.ArrayList alDeviceList)
		{
			switch (0)
			{
			default:
			{
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						try
						{
							num = 6;
							for (;;)
							{
								global::CommunicationController.IRadioCodeplugController radioCodeplugController;
								switch (num)
								{
								case 0:
									goto IL_58C;
								case 1:
									goto IL_53D;
								case 2:
								{
									bool isDualBoard;
									string text;
									string strModelNo;
									string psdtversion;
									string text2;
									string bootLoader;
									bool isBahama;
									string empty;
									string empty2;
									string empty3;
									bool isGemstone;
									bool isDspCapability;
									uint num2;
									try
									{
										for (;;)
										{
											radioCodeplugController.XNLIsDualBoard(ref isDualBoard);
											string strCommand;
											text = radioCodeplugController.IoControl<string>(strCommand);
											strModelNo = text;
											string strCommand2;
											psdtversion = radioCodeplugController.IoControl<string>(strCommand2);
											string strCommand3;
											text2 = radioCodeplugController.IoControl<string>(strCommand3);
											string strCommand4;
											bootLoader = radioCodeplugController.IoControl<string>(strCommand4);
											num = 15;
											for (;;)
											{
												string strCommand5;
												switch (num)
												{
												case 0:
													if (text2.Equals("AF5DAB63F4FC4926BB9000A6F18AF3DC"))
													{
														num = 4;
														continue;
													}
													goto IL_4E5;
												case 1:
													goto IL_4A9;
												case 2:
													goto IL_370;
												case 3:
													goto IL_370;
												case 4:
													isBahama = true;
													num = 12;
													continue;
												case 5:
													num = 11;
													continue;
												case 6:
													if (global::Controller.DeviceInfo.isParadiseLightRadio(text2))
													{
														num = 8;
														continue;
													}
													goto IL_4A9;
												case 7:
													goto IL_4F1;
												case 8:
													num = 14;
													continue;
												case 9:
													this.GetGemstoneAdditionalVersions(radioCodeplugController, out empty, out empty2, out empty3);
													isGemstone = true;
													num = 6;
													continue;
												case 10:
													goto IL_492;
												case 11:
													if (text2 == "EBCCE9BF33B14896B5C2E7E3AA19AF0F")
													{
														num = 10;
														continue;
													}
													goto IL_4E5;
												case 12:
													goto IL_4E5;
												case 13:
													goto IL_4E5;
												case 14:
													if (text2 == "1EC82E1A4AE2B4F1A8AC27E8039CB7E4")
													{
														num = 1;
														continue;
													}
													goto IL_492;
												case 15:
													if (this.a(text))
													{
														num = 17;
														continue;
													}
													strCommand5 = global::CommunicationController.enumCommand.QUERYRADIOSERIALNUMBER.ToString();
													num = 3;
													continue;
												case 16:
													if (!(text2 == "TahitiPlus"))
													{
														num = 5;
														continue;
													}
													goto IL_492;
												case 17:
													strCommand5 = global::CommunicationController.enumCommand.QUERYREPEATERSERIALNUMBER.ToString();
													num = 2;
													continue;
												case 18:
													if (global::Controller.DeviceInfo.isGemstoneRadio(text2))
													{
														num = 9;
														continue;
													}
													num = 0;
													continue;
												}
												break;
												IL_370:
												text = radioCodeplugController.IoControl<string>(strCommand5);
												num = 18;
												continue;
												IL_492:
												global::Controller.CController.a(radioCodeplugController, out isDspCapability);
												num = 13;
												continue;
												IL_4A9:
												num = 16;
												continue;
												IL_4E5:
												num = 7;
											}
										}
										IL_4F1:
										goto IL_E2;
									}
									catch (global::custom_exception.CCustomException ex)
									{
										alDeviceList.Clear();
										this.d.Close(num2);
										radioCodeplugController.Close();
										throw ex;
									}
									catch (global::System.Exception ex2)
									{
										alDeviceList.Clear();
										this.d.Close(num2);
										radioCodeplugController.Close();
										global::custom_exception.CCustomException.Rethrow(ex2);
										goto IL_E2;
									}
									goto Block_8;
									IL_E2:
									this.d.Close(num2);
									radioCodeplugController.Close();
									global::Controller.DeviceInfo deviceInfo = new global::Controller.DeviceInfo();
									string text3;
									deviceInfo.strIp = text3;
									deviceInfo.strSerialNo = text;
									deviceInfo.strModelNo = strModelNo;
									deviceInfo.PSDTVersion = psdtversion;
									deviceInfo.BootLoader = bootLoader;
									deviceInfo.isDualBoard = isDualBoard;
									deviceInfo.DeviceUUID = text2;
									deviceInfo.L3BootloaderVersion = empty;
									deviceInfo.ConfigVersion = empty2;
									deviceInfo.KernelVersion = empty3;
									deviceInfo.IsGemstone = isGemstone;
									deviceInfo.IsBahama = isBahama;
									deviceInfo.IsDspCapability = isDspCapability;
									this.a.Add(deviceInfo);
									num = 3;
									continue;
								}
								case 4:
									goto IL_580;
								case 5:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = 4;
										continue;
									}
									string text3 = (string)enumerator.Current;
									num = 1;
									continue;
								}
								case 7:
								{
									try
									{
										uint num2;
										radioCodeplugController.Open(this.d.GetPointer(), num2, new global::ErrorLogging.CLogApplicationError("MOTOTRBO Depot Tool"), 0U, false, null);
									}
									catch (global::custom_exception.CCustomException ex3)
									{
										alDeviceList.Clear();
										uint num2;
										this.d.Close(num2);
										throw ex3;
									}
									catch (global::System.Exception ex4)
									{
										alDeviceList.Clear();
										uint num2;
										this.d.Close(num2);
										global::custom_exception.CCustomException.Rethrow(ex4);
									}
									string strCommand = global::CommunicationController.enumCommand.QUERYRADIOMODELNUMBER.ToString();
									string text = "";
									string strModelNo = string.Empty;
									string strCommand5 = "";
									bool isDualBoard = false;
									string psdtversion = "";
									string strCommand2 = "QUERYRADIOPSDTVERSION";
									string strCommand4 = "QUERYRADIOBOOTLOADERVERSION";
									string strCommand3 = "QUERYRADIOUUID";
									string bootLoader = "";
									string text2 = string.Empty;
									bool isGemstone = false;
									bool isBahama = false;
									bool isDspCapability = true;
									string empty = string.Empty;
									string empty2 = string.Empty;
									string empty4 = string.Empty;
									string empty3 = string.Empty;
									string empty5 = string.Empty;
									num = 2;
									continue;
								}
								}
								IL_17D:
								num = 5;
								continue;
								goto IL_17D;
								Block_8:
								try
								{
									IL_53D:
									this.d.OpenController();
									uint num2;
									string text3;
									this.d.Open(text3, 0U, 8002U, out num2);
									goto IL_1C4;
								}
								catch (global::custom_exception.CCustomException ex5)
								{
									alDeviceList.Clear();
									throw ex5;
								}
								catch (global::System.Exception ex6)
								{
									alDeviceList.Clear();
									global::custom_exception.CCustomException.Rethrow(ex6);
									goto IL_1C4;
								}
								goto IL_580;
								IL_1C4:
								radioCodeplugController = new global::CommunicationController.CRadioCodeplugController();
								num = 7;
								continue;
								IL_580:
								num = 0;
							}
							IL_58C:
							goto IL_657;
						}
						finally
						{
							for (;;)
							{
								global::System.Collections.IEnumerator enumerator;
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
										goto IL_5F5;
									case 1:
										goto IL_5F3;
									case 2:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_5F3;
										default:
											if (false)
											{
											}
											disposable.Dispose();
											num = 1;
											continue;
										}
										break;
									}
									break;
								}
							}
							IL_5F3:
							IL_5F5:;
						}
						goto IL_5F6;
					case 1:
						goto IL_620;
					case 2:
						goto IL_620;
					case 4:
						if (alDeviceList != null)
						{
							num = 7;
							continue;
						}
						return;
					case 5:
						this.a = new global::System.Collections.ArrayList();
						num = 2;
						continue;
					case 6:
						goto IL_61B;
					case 7:
						goto IL_5F6;
					case 8:
					{
						if (alDeviceList.Count <= 0)
						{
							num = 6;
							continue;
						}
						if (true)
						{
						}
						uint num2 = 0U;
						global::System.Collections.IEnumerator enumerator = alDeviceList.GetEnumerator();
						num = 0;
						continue;
					}
					}
					if (this.a == null)
					{
						num = 5;
						continue;
					}
					this.a.Clear();
					num = 1;
					continue;
					IL_5F6:
					num = 8;
					continue;
					IL_620:
					this.d.ListConnectedDevices(out alDeviceList);
					num = 4;
				}
				return;
				IL_61B:
				return;
				IL_657:
				alDeviceList = this.a;
				return;
			}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000068F0 File Offset: 0x000058F0
		public void ListConnectedBootmodeDevices(ref global::System.Collections.ArrayList alDeviceList)
		{
			try
			{
				switch (0)
				{
				default:
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list;
					global::CommunicationController.CSerialTransportController.ListConnectedDevices(out list, global::Motorola.Common.Communication.CommonUtil.ConnectionType.Fudally);
					using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>.Enumerator enumerator = list.GetEnumerator())
					{
						int num;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_9F:
							if (!enumerator.MoveNext())
							{
								num = 1;
							}
							else
							{
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo devinfo = enumerator.Current;
								global::Controller.DeviceInfo deviceInfo = new global::Controller.DeviceInfo();
								deviceInfo.Path = global::CommunicationController.CRadioCodeplugController.Serialize(devinfo);
								alDeviceList.Add(deviceInfo);
								num = 4;
							}
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
								num = 3;
								continue;
							case 2:
								goto IL_9F;
							case 3:
								goto IL_BC;
							}
							IL_96:
							num = 2;
							continue;
							goto IL_96;
						}
						IL_BC:;
					}
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException ex)
			{
				throw ex;
			}
			catch (global::System.Exception ex2)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
				{
					if (true)
					{
					}
					ex2.Source = 1053U.ToString() + "|" + ex2.Source;
				}
				throw ex2;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006A40 File Offset: 0x00005A40
		private void a(global::CommunicationController.ISerialTransportController A_0, uint A_1, string A_2, bool A_3)
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
			global::CommunicationController.IRadioCodeplugController a_ = new global::CommunicationController.CRadioCodeplugController();
			this.a(a_, A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006A90 File Offset: 0x00005A90
		private void a(global::CommunicationController.IRadioCodeplugController A_0, global::CommunicationController.ISerialTransportController A_1, uint A_2, string A_3, bool A_4)
		{
			try
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
					}
					break;
				}
				A_0.Open(A_1.GetPointer(), A_2, new global::ErrorLogging.CLogApplicationError("MOTOTRBO Depot Tool"), 0U, A_4, null);
				goto IL_174;
			}
			catch (global::custom_exception.CCustomException)
			{
				A_1.Close(A_2);
				throw;
			}
			catch (global::System.Exception ex)
			{
				A_1.Close(A_2);
				global::custom_exception.CCustomException.Rethrow(ex);
				goto IL_174;
			}
			goto IL_67;
			int num;
			string strCommand;
			string strModelNo;
			string strCommand2;
			string psdtversion;
			string strCommand3;
			string bootLoader;
			string strCommand4;
			string text;
			bool isDualBoard;
			string empty;
			bool isBahama;
			string empty2;
			bool isGemstone;
			string empty3;
			string empty4;
			string empty5;
			for (;;)
			{
				IL_75:
				int num2;
				switch (num)
				{
				case 0:
					try
					{
						for (;;)
						{
							strModelNo = A_0.IoControl<string>(strCommand);
							psdtversion = A_0.IoControl<string>(strCommand2);
							bootLoader = A_0.IoControl<string>(strCommand3);
							text = A_0.IoControl<string>(strCommand4);
							A_0.XNLIsDualBoard(ref isDualBoard);
							A_0.GetDeviceInstance(ref empty);
							num = 17;
							for (;;)
							{
								switch (num)
								{
								case 0:
									if (text.Equals("EBCCE9BF33B14896B5C2E7E3AA19AF0F"))
									{
										num = 5;
										continue;
									}
									num = 16;
									continue;
								case 1:
									if (!text.Equals("0571AFE244664F999A96B020E82DC69C"))
									{
										num = 8;
										continue;
									}
									goto IL_4C3;
								case 2:
									goto IL_649;
								case 3:
									goto IL_655;
								case 4:
									if (!text.Equals("0C78E1B906C54D3A8F264CE5C4F0B9DF"))
									{
										num = 11;
										continue;
									}
									goto IL_4C3;
								case 5:
									goto IL_4C3;
								case 6:
									isBahama = true;
									this.a(A_0, out empty2);
									num = 19;
									continue;
								case 7:
									goto IL_649;
								case 8:
									num = 0;
									continue;
								case 9:
									num = 4;
									continue;
								case 10:
									isGemstone = true;
									this.GetGemstoneAdditionalVersions(A_0, out empty3, out empty4, out empty5);
									num = 7;
									continue;
								case 11:
									num = 1;
									continue;
								case 12:
									if (text.Equals("AF5DAB63F4FC4926BB9000A6F18AF3DC"))
									{
										num = 6;
										continue;
									}
									goto IL_5C7;
								case 13:
									if (text.Equals("106F58B631044D63B41F0C0D7720758D"))
									{
										num = 20;
										continue;
									}
									num = 12;
									continue;
								case 14:
									goto IL_649;
								case 15:
									num = 18;
									continue;
								case 16:
									if (text.Equals("9F6C2442C375421981A8987115FC9ADE"))
									{
										num = 10;
										continue;
									}
									num = 13;
									continue;
								case 17:
									if (!text.Equals("D105ADD323864E539B513A65076458D3"))
									{
										num = 15;
										continue;
									}
									goto IL_649;
								case 18:
									if (!text.Equals("06CE7B7163C0456A845A6E13421F0AE4"))
									{
										num = 9;
										continue;
									}
									goto IL_649;
								case 19:
									goto IL_649;
								case 20:
									isGemstone = true;
									this.GetGemstoneAdditionalVersions(A_0, out empty3, out empty4, out empty5);
									num = 14;
									continue;
								}
								break;
								IL_4C3:
								isGemstone = true;
								this.GetGemstoneAdditionalVersions(A_0, out empty3, out empty4, out empty5);
								num = 2;
								continue;
								IL_649:
								num = 3;
							}
						}
						IL_5C7:
						global::custom_exception.CCustomException ex2 = global::Controller.CCustomExceptionHandler.CreateException(1380U, base.GetType().ToString(), "RetrieveDeviceInfo", global::System.Environment.StackTrace.ToString());
						throw ex2;
						IL_655:
						goto IL_381;
					}
					catch (global::custom_exception.CCustomException)
					{
						A_0.Close();
						A_1.Close(A_2);
						throw;
					}
					catch (global::System.Exception ex3)
					{
						A_0.Close();
						A_1.Close(A_2);
						global::custom_exception.CCustomException.Rethrow(ex3);
						goto IL_381;
					}
					goto IL_685;
					IL_381:
					num = 1;
					continue;
				case 1:
					if (!text.Equals("D105ADD323864E539B513A65076458D3"))
					{
						num = 23;
						continue;
					}
					goto IL_7CA;
				case 2:
					if (!text.Equals("C52A3D4953FE469D8E11F05B143E8C56"))
					{
						num = 9;
						continue;
					}
					goto IL_7CA;
				case 3:
					goto IL_7CA;
				case 4:
					this.a.RemoveAt(num2);
					num = 28;
					continue;
				case 5:
					num = 2;
					continue;
				case 6:
					if (text == "EBCCE9BF33B14896B5C2E7E3AA19AF0F")
					{
						num = 3;
						continue;
					}
					goto IL_7DE;
				case 7:
					if (!text.Equals("06CE7B7163C0456A845A6E13421F0AE4"))
					{
						num = 26;
						continue;
					}
					goto IL_7CA;
				case 8:
					if (num2 >= this.a.Count)
					{
						num = 18;
						continue;
					}
					num = 27;
					continue;
				case 9:
					num = 17;
					continue;
				case 10:
					if (!text.Equals("0571AFE244664F999A96B020E82DC69C"))
					{
						num = 29;
						continue;
					}
					goto IL_7CA;
				case 11:
					if (!text.Equals("0C0D6EE58204FBDEBB8860C631AB465A"))
					{
						num = 22;
						continue;
					}
					goto IL_7CA;
				case 12:
					if (true)
					{
					}
					num = 11;
					continue;
				case 13:
					num = 10;
					continue;
				case 14:
					if (!text.Equals("C4FC39D8DEF24B779D1CB719AF26A269"))
					{
						num = 5;
						continue;
					}
					goto IL_7CA;
				case 15:
					num = 30;
					continue;
				case 16:
					if (!text.Equals("0C78E1B906C54D3A8F264CE5C4F0B9DF"))
					{
						num = 13;
						continue;
					}
					goto IL_7CA;
				case 17:
					if (!text.Equals("AF5DAB63F4FC4926BB9000A6F18AF3DC"))
					{
						num = 19;
						continue;
					}
					goto IL_7CA;
				case 18:
					goto IL_274;
				case 19:
					goto IL_71C;
				case 21:
					goto IL_24A;
				case 22:
					num = 14;
					continue;
				case 23:
					goto IL_685;
				case 24:
					if (!text.Equals("9F6C2442C375421981A8987115FC9ADE"))
					{
						num = 15;
						continue;
					}
					goto IL_7CA;
				case 25:
					num = 6;
					continue;
				case 26:
					num = 16;
					continue;
				case 27:
					if (((global::Controller.DeviceInfo)this.a[num2]).strIp == A_3)
					{
						num = 4;
						continue;
					}
					num2++;
					num = 21;
					continue;
				case 28:
					goto IL_16F;
				case 29:
					num = 24;
					continue;
				case 30:
					if (!text.Equals("106F58B631044D63B41F0C0D7720758D"))
					{
						num = 12;
						continue;
					}
					goto IL_7CA;
				case 31:
					goto IL_24A;
				}
				if (!(text == "1EC82E1A4AE2B4F1A8AC27E8039CB7E4"))
				{
					num = 25;
					continue;
				}
				goto IL_7CA;
				IL_24A:
				num = 8;
				continue;
				IL_685:
				num = 7;
				continue;
				IL_7CA:
				num2 = 0;
				num = 31;
			}
			IL_16F:
			IL_274:
			global::Controller.DeviceInfo deviceInfo = new global::Controller.DeviceInfo();
			deviceInfo.strIp = A_3;
			deviceInfo.strModelNo = strModelNo;
			string strSerialNo;
			deviceInfo.strSerialNo = strSerialNo;
			deviceInfo.DeviceUUID = text;
			deviceInfo.isDualBoard = isDualBoard;
			deviceInfo.PSDTVersion = psdtversion;
			deviceInfo.BootLoader = bootLoader;
			string radioType;
			deviceInfo.RadioType = radioType;
			deviceInfo.ProductType = text;
			deviceInfo.IsGemstone = isGemstone;
			deviceInfo.IsBahama = isBahama;
			bool isDspCapability;
			deviceInfo.IsDspCapability = isDspCapability;
			deviceInfo.FreqType = empty2;
			deviceInfo.L3BootloaderVersion = empty3;
			deviceInfo.ConfigVersion = empty4;
			deviceInfo.KernelVersion = empty5;
			this.a.Add(deviceInfo);
			return;
			IL_71C:
			goto IL_67;
			IL_7DE:
			A_0.Close();
			A_1.Close(A_2);
			return;
			IL_67:
			num = 20;
			goto IL_75;
			IL_174:
			strCommand = global::CommunicationController.enumCommand.QUERYRADIOMODELNUMBER.ToString();
			strModelNo = "";
			radioType = "";
			strSerialNo = "";
			strCommand4 = global::CommunicationController.enumCommand.QUERYRADIOUUID.ToString();
			text = "";
			strCommand2 = "QUERYRADIOPSDTVERSION";
			psdtversion = "";
			strCommand3 = "QUERYRADIOBOOTLOADERVERSION";
			bootLoader = "";
			isGemstone = false;
			isBahama = false;
			isDspCapability = false;
			empty2 = string.Empty;
			isDualBoard = false;
			empty = string.Empty;
			string empty6 = string.Empty;
			empty3 = string.Empty;
			empty4 = string.Empty;
			string empty7 = string.Empty;
			empty5 = string.Empty;
			string empty8 = string.Empty;
			string empty9 = string.Empty;
			num = 0;
			goto IL_75;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000072EC File Offset: 0x000062EC
		public void OpenLocalNormlST(string strIPaddress, out uint HandleToSerial)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_AA;
			}
			if (false)
			{
			}
			this.i = this.d;
			this.i.OpenController();
			this.i.Open(strIPaddress, 0U, 8002U, out HandleToSerial);
			this.j = new global::CommunicationController.CRadioCodeplugController();
			try
			{
				this.j.Open(this.i.GetPointer(), HandleToSerial, new global::ErrorLogging.CLogApplicationError("MOTOTRBO Depot Tool"), 0U, false, null);
			}
			catch (global::custom_exception.CCustomException ex)
			{
				this.i.Close(HandleToSerial);
				throw ex;
			}
			catch (global::System.Exception ex2)
			{
				this.i.Close(HandleToSerial);
				global::custom_exception.CCustomException.Rethrow(ex2);
			}
			IL_AA:
			if (true)
			{
			}
			this.k = true;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000073D0 File Offset: 0x000063D0
		public void CloseLocalNormlST(uint HandleToSerial)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.j.Close();
					num = 5;
					continue;
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A3;
					default:
						if (true)
						{
						}
						if (false)
						{
						}
						break;
					}
					break;
				case 2:
					if (this.j != null)
					{
						num = 0;
						continue;
					}
					goto IL_AD;
				case 3:
					goto IL_7D;
				case 4:
					this.i.Close(HandleToSerial);
					goto IL_A3;
				case 5:
					goto IL_7B;
				}
				if (this.i != null)
				{
					num = 4;
					continue;
				}
				IL_7D:
				num = 2;
				continue;
				IL_A3:
				num = 3;
			}
			IL_7B:
			IL_AD:
			this.i = null;
			this.k = false;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00007498 File Offset: 0x00006498
		public void ConvertDeviceInfo2GemstoneUpdateItem(global::Controller.DeviceInfo dev, bool isRecover, ref global::System.Collections.ArrayList updateItem, bool PreserveTuning, bool PreserveSecurity, bool PreserveApp, bool preUpgrade)
		{
			switch (0)
			{
			default:
			{
				int num = 24;
				global::DeviceUpdate.c.b b;
				for (;;)
				{
					int num2;
					bool flag;
					global::System.Version version2;
					global::System.Version value;
					switch (num)
					{
					case 0:
						goto IL_EA5;
					case 1:
						b.d = (isRecover || dev.UpdateCP);
						b.j = PreserveTuning;
						b.h = dev.SourceStructFile;
						b.i = dev.TargetStructFile;
						b.k = dev.StructFileCompressed;
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.CfsSrec;
						b.b = global::DeviceUpdate.c.a.d;
						b.e = dev.CPVersion;
						b.f = dev.TargetCPVer;
						b.g = dev.DeviceUUID;
						b.c = dev.CPCompressed;
						num = 2;
						continue;
					case 2:
						b.d = (isRecover || dev.UpdateCP);
						b.j = PreserveSecurity;
						b.h = dev.SourceStructFile;
						b.i = dev.TargetStructFile;
						b.k = dev.StructFileCompressed;
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.UdpSrec;
						b.b = global::DeviceUpdate.c.a.e;
						b.e = dev.CPVersion;
						b.f = dev.TargetCPVer;
						b.g = dev.DeviceUUID;
						b.c = dev.CPCompressed;
						b.d = false;
						num = 21;
						continue;
					case 3:
						b.d = (isRecover || dev.UpdateL3Bootloader);
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.App_UtilitiesFile;
						b.b = global::DeviceUpdate.c.a.m;
						b.e = dev.FWVersion;
						b.f = dev.FWVersion;
						b.g = dev.DeviceUUID;
						b.c = dev.App_UtilitiesCompressed;
						num = 26;
						continue;
					case 4:
						goto IL_D91;
					case 5:
						b.d = (isRecover || dev.UpdateCP);
						b.j = PreserveApp;
						b.h = dev.SourceStructFile;
						b.i = dev.TargetStructFile;
						b.k = dev.StructFileCompressed;
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.SecSrec;
						b.b = global::DeviceUpdate.c.a.a;
						b.e = dev.CPVersion;
						b.f = dev.TargetCPVer;
						b.g = dev.DeviceUUID;
						b.c = dev.CPCompressed;
						num = 41;
						continue;
					case 6:
						goto IL_6F3;
					case 7:
						num = 39;
						continue;
					case 8:
						b.d = (isRecover || dev.UpdatePSDT);
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.ConfigurationFile;
						b.b = global::DeviceUpdate.c.a.f;
						b.e = dev.ConfigVersion;
						b.f = dev.ConfigVersion;
						b.g = dev.DeviceUUID;
						b.c = dev.ConfigurationCompressed;
						num = 42;
						continue;
					case 9:
						if (dev.UpdatePSMarker)
						{
							num = 18;
							continue;
						}
						b.d = false;
						num = 20;
						continue;
					case 10:
						switch (num2)
						{
						case -1:
							flag = false;
							num = 30;
							continue;
						case 0:
						case 1:
							goto IL_6DD;
						default:
							num = 7;
							continue;
						}
						break;
					case 11:
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.File_Change_ListFile;
						b.b = global::DeviceUpdate.c.a.r;
						b.e = dev.FWVersion;
						b.f = dev.FWVersion;
						b.g = dev.DeviceUUID;
						b.c = dev.File_Change_ListCompressed;
						num = 46;
						continue;
					case 12:
						b.d = (isRecover || dev.UpdateFW);
						num = 4;
						continue;
					case 13:
						goto IL_73E;
					case 14:
						b = default(global::DeviceUpdate.c.b);
						b.g = dev.DeviceUUID;
						b.a = dev.PreUpgradeFile;
						b.b = dev.PreUpgradeFileType;
						b.c = dev.PreUpgradeCompressed;
						b.d = true;
						num = 17;
						continue;
					case 15:
					{
						flag = true;
						global::System.Version version = new global::System.Version(dev.CPVersion);
						version2 = new global::System.Version(dev.TargetCPVer);
						value = new global::System.Version("06.01.00");
						int num3 = version.CompareTo(value);
						num = 19;
						continue;
					}
					case 16:
						b.d = (isRecover || dev.UpdateFW);
						updateItem.Add(b);
						num = 38;
						continue;
					case 17:
						if (dev.PreUpgradeFileType == global::DeviceUpdate.c.a.f)
						{
							num = 31;
							continue;
						}
						goto IL_183;
					case 18:
						num = 12;
						continue;
					case 19:
					{
						int num3;
						switch (num3)
						{
						case -1:
							flag = false;
							num = 40;
							continue;
						case 0:
						case 1:
							goto IL_686;
						default:
							num = 32;
							continue;
						}
						break;
					}
					case 20:
						goto IL_D91;
					case 21:
						if (!isRecover)
						{
							num = 15;
							continue;
						}
						goto IL_6F3;
					case 22:
					{
						if (true)
						{
						}
						bool flag2 = true;
						num = 33;
						continue;
					}
					case 23:
						if (isRecover)
						{
							num = 11;
							continue;
						}
						goto IL_F08;
					case 25:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C92;
						default:
							if (false)
							{
							}
							b.d = (isRecover || dev.UpdateKernel);
							updateItem.Add(b);
							b = default(global::DeviceUpdate.c.b);
							b.a = dev.RfsFile;
							b.b = global::DeviceUpdate.c.a.k;
							b.e = dev.KernelVersion;
							b.f = dev.KernelVersion;
							b.g = dev.DeviceUUID;
							b.c = dev.RFSCompressed;
							num = 27;
							continue;
						}
						break;
					case 26:
						b.d = (isRecover || dev.UpdateFW);
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.PartitionTableFile;
						b.b = global::DeviceUpdate.c.a.n;
						b.e = dev.PSDTVersion;
						b.f = dev.PSDTVersion;
						b.g = dev.DeviceUUID;
						b.c = dev.PartitionTableCompressed;
						num = 28;
						continue;
					case 27:
					{
						b.d = (isRecover || dev.UpdateKernel);
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.BLFile;
						b.b = global::DeviceUpdate.c.a.i;
						b.e = dev.BootLoader;
						b.f = dev.BootLoader;
						b.g = dev.DeviceUUID;
						b.c = dev.BLCompressed;
						bool flag2 = false;
						num = 44;
						continue;
					}
					case 28:
						b.d = (isRecover || dev.UpdatePSDT);
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.Control_HeadFile;
						b.b = global::DeviceUpdate.c.a.o;
						b.e = dev.FWVersion;
						b.f = dev.FWVersion;
						b.g = dev.DeviceUUID;
						b.c = dev.Control_HeadCompressed;
						goto IL_C92;
					case 29:
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.FtlAppSecCfsSrec;
						b.b = global::DeviceUpdate.c.a.t;
						b.g = dev.DeviceUUID;
						b.c = dev.CPCompressed;
						b.d = true;
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.FtlTunSrec;
						b.b = global::DeviceUpdate.c.a.u;
						b.g = dev.DeviceUUID;
						b.c = dev.CPCompressed;
						b.d = true;
						updateItem.Add(b);
						num = 13;
						continue;
					case 30:
						goto IL_6DD;
					case 31:
						b.e = dev.ConfigVersion;
						b.f = dev.ConfigVersion;
						num = 36;
						continue;
					case 32:
						num = 37;
						continue;
					case 33:
						goto IL_A85;
					case 34:
						b.d = (isRecover || dev.UpdateFW);
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.PSDTFile;
						b.b = global::DeviceUpdate.c.a.g;
						b.e = dev.PSDTVersion;
						b.f = dev.PSDTVersion;
						b.g = dev.DeviceUUID;
						b.c = dev.PSDTCompressed;
						num = 8;
						continue;
					case 35:
						goto IL_73E;
					case 36:
						goto IL_181;
					case 37:
						goto IL_686;
					case 38:
						if (isRecover)
						{
							num = 29;
							continue;
						}
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.AppSrec;
						b.b = global::DeviceUpdate.c.a.b;
						b.e = dev.CPVersion;
						b.f = dev.TargetCPVer;
						b.g = dev.DeviceUUID;
						b.c = dev.CPCompressed;
						num = 5;
						continue;
					case 39:
						goto IL_6DD;
					case 40:
						goto IL_686;
					case 41:
						b.d = (isRecover || dev.UpdateCP);
						b.j = PreserveSecurity;
						b.h = dev.SourceStructFile;
						b.i = dev.TargetStructFile;
						b.k = dev.StructFileCompressed;
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.TuneSrec;
						b.b = global::DeviceUpdate.c.a.c;
						b.e = dev.CPVersion;
						b.f = dev.TargetCPVer;
						b.g = dev.DeviceUUID;
						b.c = dev.CPCompressed;
						num = 1;
						continue;
					case 42:
						b.d = (isRecover || dev.UpdateConfiguration);
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.KernelFile;
						b.b = global::DeviceUpdate.c.a.h;
						b.e = dev.KernelVersion;
						b.f = dev.KernelVersion;
						b.g = dev.DeviceUUID;
						b.c = dev.KernelCompressed;
						num = 25;
						continue;
					case 43:
						b.d = (isRecover ? (!string.IsNullOrEmpty(b.a)) : dev.UpdateFW);
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.PSMarkerFile;
						b.b = global::DeviceUpdate.c.a.af;
						b.e = dev.FWVersion;
						b.f = dev.FWVersion;
						b.g = dev.DeviceUUID;
						b.c = dev.PSMarkerCompressed;
						num = 9;
						continue;
					case 44:
						if (global::System.IO.File.Exists(b.a))
						{
							num = 22;
							continue;
						}
						goto IL_A85;
					case 45:
					{
						bool flag2;
						b.d = (isRecover ? flag2 : dev.UpdateBL);
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.L3BootloaderFile;
						b.b = global::DeviceUpdate.c.a.j;
						b.e = dev.L3BootloaderVersion;
						b.f = dev.L3BootloaderVersion;
						b.g = dev.DeviceUUID;
						b.c = dev.L3BootloaderCompressed;
						num = 3;
						continue;
					}
					case 46:
						b.d = !string.IsNullOrEmpty(dev.Control_HeadFile);
						updateItem.Add(b);
						b = default(global::DeviceUpdate.c.b);
						b.a = dev.Global_MarkerFile;
						b.b = global::DeviceUpdate.c.a.s;
						b.e = dev.FWVersion;
						b.f = dev.FWVersion;
						b.g = dev.DeviceUUID;
						b.c = dev.Global_MarkerCompressed;
						num = 0;
						continue;
					}
					if (preUpgrade)
					{
						num = 14;
						continue;
					}
					b = default(global::DeviceUpdate.c.b);
					b.a = dev.Data_ImageFile;
					b.b = global::DeviceUpdate.c.a.q;
					b.g = dev.DeviceUUID;
					b.c = dev.Data_ImageCompressed;
					num = 16;
					continue;
					IL_686:
					num2 = version2.CompareTo(value);
					num = 10;
					continue;
					IL_6DD:
					b.d = flag;
					num = 6;
					continue;
					IL_6F3:
					b.j = false;
					b.h = dev.SourceStructFile;
					b.i = dev.TargetStructFile;
					b.k = dev.StructFileCompressed;
					updateItem.Add(b);
					num = 35;
					continue;
					IL_73E:
					b = default(global::DeviceUpdate.c.b);
					b.a = dev.FWFile1;
					b.b = global::DeviceUpdate.c.a.l;
					b.e = dev.FWVersion;
					b.f = dev.FWVersion;
					b.g = dev.DeviceUUID;
					b.c = dev.FWCompressed;
					num = 34;
					continue;
					IL_A85:
					num = 45;
					continue;
					IL_C92:
					num = 43;
					continue;
					IL_D91:
					updateItem.Add(b);
					num = 23;
				}
				IL_181:
				IL_183:
				updateItem.Add(b);
				return;
				IL_EA5:
				b.d = !string.IsNullOrEmpty(dev.Control_HeadFile);
				updateItem.Add(b);
				this.a(new string[]
				{
					dev.AppSrec,
					dev.SecSrec,
					dev.TuneSrec,
					dev.CfsSrec
				});
				return;
				IL_F08:
				this.a(new string[]
				{
					dev.File_Change_ListFile,
					dev.Global_MarkerFile,
					dev.FtlTunSrec,
					dev.FtlAppSecCfsSrec
				});
				return;
			}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000083E8 File Offset: 0x000073E8
		private void a(params string[] A_0)
		{
			try
			{
				for (;;)
				{
					for (;;)
					{
						int num = 0;
						int num2 = 9;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num2 = 6;
								continue;
							case 1:
								goto IL_58;
							case 2:
								if (global::System.IO.File.Exists(A_0[num]))
								{
									num2 = 8;
									continue;
								}
								goto IL_AB;
							case 3:
								if (num >= A_0.Length)
								{
									num2 = 0;
									continue;
								}
								num2 = 4;
								continue;
							case 4:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									if (false)
									{
									}
									if (!string.IsNullOrEmpty(A_0[num]))
									{
										num2 = 7;
										continue;
									}
									goto IL_AB;
								}
								break;
							case 5:
								goto IL_AB;
							case 6:
								goto IL_DC;
							case 7:
								num2 = 2;
								continue;
							case 8:
								global::System.IO.File.Delete(A_0[num]);
								num2 = 5;
								continue;
							case 9:
								goto IL_58;
							}
							break;
							IL_58:
							num2 = 3;
							continue;
							IL_AB:
							num++;
							num2 = 1;
						}
					}
				}
				IL_DC:;
			}
			catch (global::custom_exception.CCustomException ex)
			{
				throw ex;
			}
			catch (global::System.Exception ex2)
			{
				global::custom_exception.CCustomException.Rethrow(ex2);
			}
			if (true)
			{
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00008510 File Offset: 0x00007510
		public void UpdateDevice(string IPAddress, string CurrentCodeplugVersion, string SelPackage, bool FWUpdateReq, bool CPUpdateReq, bool PreserveTuning, bool PreserveSecurity, bool PreserveApp, bool PreserveUcl, global::constants.CCPTags.SetProgressBar pfSetProgressBar, ref global::Controller.DeviceInfo dev, int progressBarLength)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						bool flag = false;
						string a_ = CurrentCodeplugVersion;
						int num = 27;
						for (;;)
						{
							int num2;
							global::DeviceUpdate.c c2;
							bool flag2;
							int num7;
							int num8;
							global::System.Collections.ArrayList arrayList3;
							uint num9;
							switch (num)
							{
							case 0:
								if (!dev.UpdateL3Bootloader)
								{
									num = 4;
									continue;
								}
								goto IL_5FB;
							case 1:
								goto IL_157;
							case 2:
							{
								if (dev.IsBahama)
								{
									num = 15;
									continue;
								}
								global::DeviceUpdate.c c = new global::DeviceUpdate.c(dev.AppSrec, dev.TuneSrec, dev.SecSrec, dev.UclSrec, dev.FWFile1, dev.FWFile2, dev.PSDTFile, dev.BLFile, dev.RDLFile, dev.FieldMoveFile, dev.SourceStructFile, dev.TargetStructFile, dev.FWCompressed, dev.CPCompressed, dev.StructFileCompressed, dev.FieldMoveCompressed, dev.BLCompressed, dev.PSDTCompressed, dev.RDLCompressed, dev.IshComp, dev.DeviceUUID, dev.SourceIshComp);
								c.a(true);
								c.a(dev.UpdatePSDT, dev.UpdateBL, dev.UpdateCP, dev.UpdateFW, a_, dev.TargetCPVer, dev.isDualBoard, dev.objFZ, PreserveTuning, PreserveSecurity, PreserveApp, PreserveUcl, pfSetProgressBar, progressBarLength);
								num = 44;
								continue;
							}
							case 3:
								goto IL_5FB;
							case 4:
								goto IL_333;
							case 5:
								flag = true;
								a_ = dev.TargetCPVer;
								num = 43;
								continue;
							case 6:
								goto IL_66F;
							case 7:
								if (!dev.UpdatePSDT)
								{
									num = 1;
									continue;
								}
								goto IL_5FB;
							case 8:
								if (dev.NeedPreUpgrade)
								{
									num = 14;
									continue;
								}
								goto IL_479;
							case 9:
								if (!flag)
								{
									num = 25;
									continue;
								}
								goto IL_479;
							case 10:
								num = 24;
								continue;
							case 11:
								if (num2 <= 0)
								{
									num = 10;
									continue;
								}
								num = 20;
								continue;
							case 12:
								num = 38;
								continue;
							case 13:
								goto IL_6B3;
							case 14:
								num = 9;
								continue;
							case 15:
							{
								int num3 = 0;
								num3 = progressBarLength;
								uint num4 = 0U;
								global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
								num = 39;
								continue;
							}
							case 16:
								if (!dev.UpdateBL)
								{
									num = 36;
									continue;
								}
								goto IL_5FB;
							case 17:
								try
								{
									try
									{
										num = 1;
										for (;;)
										{
											int num3;
											uint num4;
											global::System.Collections.ArrayList arrayList;
											switch (num)
											{
											case 0:
												goto IL_901;
											case 2:
												goto IL_90D;
											case 3:
											{
												c2.a(dev.RDLFile, arrayList, pfSetProgressBar, num3, dev.DeviceUUID, dev.Path);
												global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
												int num5 = 0;
												num = 9;
												continue;
											}
											case 4:
												goto IL_901;
											case 5:
											{
												global::System.Collections.ArrayList arrayList2;
												dev = (global::Controller.DeviceInfo)arrayList2[0];
												this.OpenLocalNormlST(dev.strIp, out num4);
												this.b(dev, c2, this.i, false, 0U);
												num = 0;
												continue;
											}
											case 6:
											{
												int num5;
												if (num5 >= 50)
												{
													num = 11;
													continue;
												}
												global::System.Collections.ArrayList arrayList2;
												this.ListConnectedDevices(out arrayList2);
												num = 10;
												continue;
											}
											case 7:
											{
												global::System.Collections.ArrayList arrayList2;
												if (arrayList2.Count > 0)
												{
													num = 5;
													continue;
												}
												goto IL_901;
											}
											case 8:
												goto IL_78E;
											case 9:
												goto IL_78E;
											case 10:
											{
												global::System.Collections.ArrayList arrayList2;
												if (arrayList2.Count <= 0)
												{
													num = 12;
													continue;
												}
												goto IL_82F;
											}
											case 11:
												goto IL_82F;
											case 12:
											{
												global::System.Threading.Thread.Sleep(2000);
												int num5;
												num5++;
												num = 8;
												continue;
											}
											}
											if (flag)
											{
												num = 3;
												continue;
											}
											this.OpenLocalNormlST(dev.strIp, out num4);
											c2.a(dev.FieldMoveFile, dev.FieldMoveCompressed, arrayList, pfSetProgressBar, num3, this.i, num4, dev.strSerialNo);
											this.b(dev, c2, this.i, false, 0U);
											num = 4;
											continue;
											IL_78E:
											num = 6;
											continue;
											IL_82F:
											num = 7;
											continue;
											IL_901:
											num = 2;
										}
										IL_90D:;
									}
									catch (global::custom_exception.CCustomException)
									{
										throw;
									}
									catch (global::System.Exception ex)
									{
										global::custom_exception.CCustomException.Rethrow(ex);
									}
									goto IL_9C9;
								}
								finally
								{
									uint num4;
									this.CloseLocalNormlST(num4);
								}
								goto IL_92B;
							case 18:
								if (dev.IsGemstone)
								{
									num = 19;
									continue;
								}
								num = 2;
								continue;
							case 19:
							{
								num2 = 0;
								flag2 = false;
								int num6 = 0;
								num7 = 0;
								num8 = 0;
								num = 8;
								continue;
							}
							case 20:
								if (2 == num2)
								{
									num = 37;
									continue;
								}
								num = 30;
								continue;
							case 21:
								global::System.Threading.Thread.Sleep(2500);
								num = 6;
								continue;
							case 22:
								goto IL_9A5;
							case 23:
							{
								try
								{
									this.ConvertDeviceInfo2GemstoneUpdateItem(dev, flag, ref arrayList3, PreserveTuning, PreserveSecurity, PreserveApp, flag2);
									goto IL_985;
								}
								catch (global::custom_exception.CCustomException ex2)
								{
									throw ex2;
								}
								catch (global::System.Exception ex3)
								{
									global::custom_exception.CCustomException.Rethrow(ex3);
									goto IL_985;
								}
								goto IL_333;
								IL_985:
								global::DeviceUpdate.c c3 = new global::DeviceUpdate.c();
								c3.a(true);
								num = 40;
								continue;
							}
							case 24:
								goto IL_9C9;
							case 25:
							{
								num2 = 2;
								int num6 = global::System.Convert.ToInt32((double)progressBarLength * 0.01);
								num7 = progressBarLength - num6;
								num = 28;
								continue;
							}
							case 26:
								if (!dev.UpdateKernel)
								{
									num = 34;
									continue;
								}
								goto IL_5FB;
							case 27:
								if (!IPAddress.Equals(string.Empty))
								{
									num = 21;
									continue;
								}
								goto IL_66F;
							case 28:
								goto IL_9A5;
							case 29:
								if (!dev.UpdateFW)
								{
									num = 12;
									continue;
								}
								goto IL_5FB;
							case 30:
								if (1 == num2)
								{
									if (true)
									{
									}
									num = 35;
									continue;
								}
								goto IL_6B3;
							case 31:
								if (!dev.UpdateConfiguration)
								{
									num = 42;
									continue;
								}
								goto IL_5FB;
							case 32:
								num = 0;
								continue;
							case 33:
								if (string.IsNullOrEmpty(CurrentCodeplugVersion))
								{
									num = 5;
									continue;
								}
								goto IL_92B;
							case 34:
								num = 31;
								continue;
							case 35:
								goto IL_720;
							case 36:
								num = 45;
								continue;
							case 37:
							{
								flag2 = true;
								int num6;
								num8 = num6;
								num = 47;
								continue;
							}
							case 38:
								if (dev.IsGemstone)
								{
									num = 32;
									continue;
								}
								goto IL_4F9;
							case 39:
								try
								{
									global::System.Collections.ArrayList arrayList;
									this.ConvertDeviceInfo2FileSystemUpdateItem(dev, false, ref arrayList, PreserveTuning, PreserveSecurity, PreserveApp);
									goto IL_2E8;
								}
								catch (global::custom_exception.CCustomException)
								{
									throw;
								}
								catch (global::System.Exception ex4)
								{
									global::custom_exception.CCustomException.Rethrow(ex4);
									goto IL_2E8;
								}
								goto IL_720;
							case 40:
								try
								{
									try
									{
										num = 0;
										for (;;)
										{
											global::DeviceUpdate.c c3;
											switch (num)
											{
											case 1:
												goto IL_229;
											case 2:
												goto IL_229;
											case 3:
												c3.a(dev.RDLFile, arrayList3, pfSetProgressBar, num8, dev.DeviceUUID, dev.Path);
												num = 2;
												continue;
											case 4:
												goto IL_235;
											}
											if (flag)
											{
												num = 3;
												continue;
											}
											this.OpenLocalNormlST(IPAddress, out num9);
											c3.b(dev.FieldMoveFile, dev.FieldMoveCompressed, arrayList3, pfSetProgressBar, num8, this.i, num9, dev.strSerialNo);
											num = 1;
											continue;
											IL_229:
											num = 4;
										}
										IL_235:;
									}
									catch (global::custom_exception.CCustomException ex5)
									{
										throw ex5;
									}
									catch (global::System.Exception ex6)
									{
										global::custom_exception.CCustomException.Rethrow(ex6);
									}
									goto IL_9A5;
								}
								finally
								{
									num = 4;
									for (;;)
									{
										switch (num)
										{
										case 0:
											if (this.k)
											{
												num = 3;
												continue;
											}
											goto IL_28C;
										case 1:
											num = 0;
											continue;
										case 2:
											if (flag2)
											{
												num = 7;
												continue;
											}
											goto IL_2E7;
										case 3:
											this.CloseLocalNormlST(num9);
											num = 6;
											continue;
										case 5:
											goto IL_2B3;
										case 6:
											goto IL_28C;
										case 7:
											this.c(IPAddress);
											num = 5;
											continue;
										}
										if (!flag)
										{
											num = 1;
											continue;
										}
										IL_28C:
										num = 2;
									}
									IL_2B3:
									IL_2E7:;
								}
								goto IL_2E8;
							case 41:
								num = 29;
								continue;
							case 42:
								goto IL_4F9;
							case 43:
								goto IL_92B;
							case 44:
								goto IL_9C9;
							case 45:
								if (!dev.UpdateCP)
								{
									num = 41;
									continue;
								}
								goto IL_5FB;
							case 46:
								goto IL_9D5;
							case 47:
								goto IL_6B3;
							}
							break;
							IL_157:
							num = 16;
							continue;
							IL_66F:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_157;
							default:
								if (false)
								{
								}
								num = 33;
								continue;
							}
							IL_2E8:
							c2 = new global::DeviceUpdate.c();
							c2.a(true);
							num = 17;
							continue;
							IL_333:
							num = 26;
							continue;
							IL_479:
							num2 = 1;
							num7 = progressBarLength;
							num = 22;
							continue;
							IL_4F9:
							dev.UpdateCP = true;
							num = 3;
							continue;
							IL_5FB:
							num = 18;
							continue;
							IL_6B3:
							num2--;
							num9 = 0U;
							arrayList3 = new global::System.Collections.ArrayList();
							num = 23;
							continue;
							IL_720:
							flag2 = false;
							num8 = num7;
							num = 13;
							continue;
							IL_92B:
							num = 7;
							continue;
							IL_9A5:
							num = 11;
							continue;
							IL_9C9:
							num = 46;
						}
					}
					IL_9D5:
					break;
				}
			}
			catch (global::custom_exception.CCustomException ex7)
			{
				throw ex7;
			}
			catch (global::System.Exception ex8)
			{
				global::custom_exception.CCustomException.Rethrow(ex8);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00009034 File Offset: 0x00008034
		public void ConvertDeviceInfo2FileSystemUpdateItem(global::Controller.DeviceInfo dev, bool isRecover, ref global::System.Collections.ArrayList updateItem, bool PreserveTuning, bool PreserveSecurity, bool PreserveApp)
		{
			switch (0)
			{
			default:
			{
				global::System.Collections.Generic.Dictionary<global::DeviceUpdate.c.a, global::DeviceUpdate.c.b> dictionary;
				global::System.Collections.Generic.List<global::DeviceUpdate.c.a>.Enumerator enumerator;
				for (;;)
				{
					dictionary = new global::System.Collections.Generic.Dictionary<global::DeviceUpdate.c.a, global::DeviceUpdate.c.b>();
					global::DeviceUpdate.c.b value = default(global::DeviceUpdate.c.b);
					value.a = dev.AppSrec;
					value.b = global::DeviceUpdate.c.a.b;
					value.e = dev.CPVersion;
					value.f = dev.TargetCPVer;
					value.g = dev.DeviceUUID;
					value.c = dev.CPCompressed;
					int num = 21;
					for (;;)
					{
						global::System.Collections.Generic.List<global::DeviceUpdate.c.a> list2;
						int num3;
						global::System.Collections.Generic.List<global::DeviceUpdate.c.a> list3;
						switch (num)
						{
						case 0:
							goto IL_88F;
						case 1:
							goto IL_D70;
						case 2:
							num = 11;
							continue;
						case 3:
							value.d = (isRecover || dev.UpdateFW);
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.PartitionTableFile;
							value.b = global::DeviceUpdate.c.a.n;
							value.e = dev.PSDTVersion;
							value.f = dev.PSDTVersion;
							value.g = dev.DeviceUUID;
							value.c = dev.PartitionTableCompressed;
							num = 22;
							continue;
						case 4:
							if (global::System.IO.File.Exists(value.a))
							{
								num = 37;
								continue;
							}
							goto IL_88F;
						case 5:
							if (dictionary.ContainsKey(global::DeviceUpdate.c.a.i))
							{
								num = 2;
								continue;
							}
							goto IL_D70;
						case 6:
							goto IL_C26;
						case 7:
							value.d = (isRecover || dev.UpdateCP);
							value.j = PreserveSecurity;
							value.h = dev.SourceStructFile;
							value.i = dev.TargetStructFile;
							value.k = dev.StructFileCompressed;
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.FWFile1;
							value.b = global::DeviceUpdate.c.a.l;
							value.e = dev.FWVersion;
							value.f = dev.FWVersion;
							value.g = dev.DeviceUUID;
							value.c = dev.FWCompressed;
							num = 18;
							continue;
						case 8:
							if (dev.UpdateFW)
							{
								num = 16;
								continue;
							}
							goto IL_576;
						case 9:
						{
							int num2;
							if (num2 >= dev.ScriptFiles.Count)
							{
								num = 29;
								continue;
							}
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.ScriptFiles[num2];
							global::System.Collections.Generic.List<global::DeviceUpdate.c.a> list;
							value.b = list[num2];
							value.e = dev.FWVersion;
							value.f = dev.FWVersion;
							value.g = dev.DeviceUUID;
							value.c = dev.ScriptCompressed;
							value.d = true;
							dictionary.Add(value.b, value);
							num2++;
							num = 6;
							continue;
						}
						case 10:
							value.d = (isRecover || dev.UpdateCP);
							value.j = PreserveSecurity;
							value.h = dev.SourceStructFile;
							value.i = dev.TargetStructFile;
							value.k = dev.StructFileCompressed;
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.TuneSrec;
							value.b = global::DeviceUpdate.c.a.c;
							value.e = dev.CPVersion;
							value.f = dev.TargetCPVer;
							value.g = dev.DeviceUUID;
							value.c = dev.CPCompressed;
							num = 19;
							continue;
						case 11:
							if (dictionary[global::DeviceUpdate.c.a.i].d)
							{
								num = 34;
								continue;
							}
							goto IL_D70;
						case 12:
							value.d = (isRecover || dev.UpdateKernel);
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.RfsFile;
							value.b = global::DeviceUpdate.c.a.k;
							value.e = dev.KernelVersion;
							value.f = dev.KernelVersion;
							value.g = dev.DeviceUUID;
							value.c = dev.RFSCompressed;
							num = 38;
							continue;
						case 13:
						{
							value.d = (isRecover || dev.UpdateFW);
							dictionary.Add(value.b, value);
							global::System.Collections.Generic.List<global::DeviceUpdate.c.a> list = new global::System.Collections.Generic.List<global::DeviceUpdate.c.a>
							{
								global::DeviceUpdate.c.a.x,
								global::DeviceUpdate.c.a.w,
								global::DeviceUpdate.c.a.y,
								global::DeviceUpdate.c.a.z,
								global::DeviceUpdate.c.a.ae
							};
							int num2 = 0;
							num = 27;
							continue;
						}
						case 14:
							goto IL_576;
						case 15:
							goto IL_54B;
						case 16:
							goto IL_473;
						case 17:
							goto IL_54B;
						case 18:
							value.d = (isRecover || dev.UpdateFW);
							dictionary.Add(value.b, value);
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_C50;
							default:
								if (false)
								{
								}
								num = 32;
								continue;
							}
							break;
						case 19:
							value.d = (isRecover || dev.UpdateCP);
							value.j = PreserveTuning;
							value.h = dev.SourceStructFile;
							value.i = dev.TargetStructFile;
							value.k = dev.StructFileCompressed;
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.CfsSrec;
							value.b = global::DeviceUpdate.c.a.d;
							value.e = dev.CPVersion;
							value.f = dev.TargetCPVer;
							value.g = dev.DeviceUUID;
							value.c = dev.CPCompressed;
							num = 7;
							continue;
						case 20:
							value.d = (isRecover || dev.UpdateFW);
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.PSDTFile;
							value.b = global::DeviceUpdate.c.a.g;
							value.e = dev.PSDTVersion;
							value.f = dev.PSDTVersion;
							value.g = dev.DeviceUUID;
							value.c = dev.PSDTCompressed;
							num = 31;
							continue;
						case 21:
							value.d = (isRecover || dev.UpdateCP);
							value.j = PreserveApp;
							value.h = dev.SourceStructFile;
							value.i = dev.TargetStructFile;
							value.k = dev.StructFileCompressed;
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.SecSrec;
							value.b = global::DeviceUpdate.c.a.a;
							value.e = dev.CPVersion;
							value.f = dev.TargetCPVer;
							value.g = dev.DeviceUUID;
							value.c = dev.CPCompressed;
							num = 10;
							continue;
						case 22:
							value.d = (isRecover || dev.UpdatePSDT);
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.Control_HeadFile;
							value.b = global::DeviceUpdate.c.a.o;
							value.e = dev.FWVersion;
							value.f = dev.FWVersion;
							value.g = dev.DeviceUUID;
							value.c = dev.Control_HeadCompressed;
							num = 26;
							continue;
						case 23:
							value.d = (isRecover || dev.UpdateL3Bootloader);
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.App_UtilitiesFile;
							value.b = global::DeviceUpdate.c.a.m;
							value.e = dev.FWVersion;
							value.f = dev.FWVersion;
							value.g = dev.DeviceUUID;
							value.c = dev.App_UtilitiesCompressed;
							num = 3;
							continue;
						case 24:
							goto IL_D8D;
						case 25:
							list2.Clear();
							list2.AddRange(new global::DeviceUpdate.c.a[]
							{
								global::DeviceUpdate.c.a.b,
								global::DeviceUpdate.c.a.d,
								global::DeviceUpdate.c.a.a,
								global::DeviceUpdate.c.a.c,
								global::DeviceUpdate.c.a.l,
								global::DeviceUpdate.c.a.j,
								global::DeviceUpdate.c.a.g,
								global::DeviceUpdate.c.a.n,
								global::DeviceUpdate.c.a.v
							});
							list2.AddRange(new global::DeviceUpdate.c.a[]
							{
								global::DeviceUpdate.c.a.x,
								global::DeviceUpdate.c.a.w,
								global::DeviceUpdate.c.a.y,
								global::DeviceUpdate.c.a.z
							});
							list2.AddRange(new global::DeviceUpdate.c.a[]
							{
								global::DeviceUpdate.c.a.ad,
								global::DeviceUpdate.c.a.ab,
								global::DeviceUpdate.c.a.ac
							});
							num = 5;
							continue;
						case 26:
							value.d = (isRecover || dev.UpdateFW);
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.Data_ImageFile;
							value.b = global::DeviceUpdate.c.a.q;
							value.e = dev.FWVersion;
							value.f = dev.FWVersion;
							value.g = dev.DeviceUUID;
							value.c = dev.Data_ImageCompressed;
							num = 13;
							continue;
						case 27:
							goto IL_C26;
						case 28:
							value.d = (isRecover || dev.UpdateFW);
							dictionary.Add(value.b, value);
							num3++;
							num = 17;
							continue;
						case 29:
							goto IL_C50;
						case 30:
							if (dev.IsBahama)
							{
								num = 25;
								continue;
							}
							goto IL_D70;
						case 31:
							value.d = (isRecover || dev.UpdatePSDT);
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.ConfigurationFile;
							value.b = global::DeviceUpdate.c.a.f;
							value.e = dev.ConfigVersion;
							value.f = dev.ConfigVersion;
							value.g = dev.DeviceUUID;
							value.c = dev.ConfigurationCompressed;
							num = 33;
							continue;
						case 32:
							if (!isRecover)
							{
								num = 39;
								continue;
							}
							goto IL_473;
						case 33:
							value.d = (isRecover || dev.UpdateConfiguration);
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.KernelFile;
							value.b = global::DeviceUpdate.c.a.h;
							value.e = dev.KernelVersion;
							value.f = dev.KernelVersion;
							value.g = dev.DeviceUUID;
							value.c = dev.KernelCompressed;
							num = 12;
							continue;
						case 34:
							list2.Add(global::DeviceUpdate.c.a.i);
							num = 1;
							continue;
						case 35:
						{
							bool flag;
							value.d = (isRecover ? flag : dev.UpdateBL);
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.L3BootloaderFile;
							value.b = global::DeviceUpdate.c.a.j;
							value.e = dev.L3BootloaderVersion;
							value.f = dev.L3BootloaderVersion;
							value.g = dev.DeviceUUID;
							value.c = dev.L3BootloaderCompressed;
							num = 23;
							continue;
						}
						case 36:
							if (num3 >= dev.FruFiles.Count)
							{
								num = 14;
								continue;
							}
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.FruFiles[num3];
							value.b = list3[num3];
							value.e = dev.FWVersion;
							value.f = dev.FWVersion;
							value.g = dev.DeviceUUID;
							value.c = dev.FWCompressed;
							num = 28;
							continue;
						case 37:
						{
							bool flag = true;
							num = 0;
							continue;
						}
						case 38:
						{
							value.d = (isRecover || dev.UpdateKernel);
							dictionary.Add(value.b, value);
							value = default(global::DeviceUpdate.c.b);
							value.a = dev.BLFile;
							value.b = global::DeviceUpdate.c.a.i;
							value.e = dev.BootLoader;
							value.f = dev.BootLoader;
							value.g = dev.DeviceUUID;
							value.c = dev.BLCompressed;
							bool flag = false;
							num = 4;
							continue;
						}
						case 39:
							num = 8;
							continue;
						}
						break;
						IL_473:
						list3 = new global::System.Collections.Generic.List<global::DeviceUpdate.c.a>
						{
							global::DeviceUpdate.c.a.ab,
							global::DeviceUpdate.c.a.ac,
							global::DeviceUpdate.c.a.ad
						};
						num3 = 0;
						num = 15;
						continue;
						IL_54B:
						num = 36;
						continue;
						IL_576:
						value = default(global::DeviceUpdate.c.b);
						value.a = dev.FWFile2;
						value.b = global::DeviceUpdate.c.a.v;
						value.e = dev.FWVersion;
						value.f = dev.FWVersion;
						value.g = dev.DeviceUUID;
						value.c = dev.FWCompressed;
						num = 20;
						continue;
						IL_88F:
						num = 35;
						continue;
						IL_C26:
						num = 9;
						continue;
						IL_C50:
						list2 = new global::System.Collections.Generic.List<global::DeviceUpdate.c.a>();
						num = 30;
						continue;
						IL_D70:
						if (true)
						{
						}
						enumerator = list2.GetEnumerator();
						num = 24;
					}
				}
				IL_D8D:
				try
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
						{
							global::DeviceUpdate.c.a key;
							updateItem.Add(dictionary[key]);
							num = 2;
							continue;
						}
						case 3:
						{
							global::DeviceUpdate.c.a key;
							if (dictionary.ContainsKey(key))
							{
								num = 1;
								continue;
							}
							break;
						}
						case 4:
							num = 5;
							continue;
						case 5:
							goto IL_E32;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = 4;
								continue;
							}
							global::DeviceUpdate.c.a key = enumerator.Current;
							num = 3;
							continue;
						}
						}
						IL_E06:
						num = 6;
						continue;
						goto IL_E06;
					}
					IL_E32:;
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
				return;
			}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00009E94 File Offset: 0x00008E94
		private void b(global::Controller.DeviceInfo A_0, global::DeviceUpdate.c A_1, global::CommunicationController.ISerialTransportController A_2, bool A_3, uint A_4)
		{
			for (;;)
			{
				global::System.DateTime now = global::System.DateTime.Now;
				int num = 9;
				for (;;)
				{
					global::DeviceUpdate.d d;
					global::System.TimeSpan timeSpan;
					switch (num)
					{
					case 0:
						this.c(A_0.strIp);
						num = 14;
						continue;
					case 1:
						goto IL_17B;
					case 2:
						goto IL_180;
					case 3:
						if (d == global::DeviceUpdate.d.a)
						{
							num = 20;
							continue;
						}
						num = 8;
						continue;
					case 4:
						num = 10;
						continue;
					case 5:
						if (d != global::DeviceUpdate.d.c)
						{
							num = 4;
							continue;
						}
						goto IL_180;
					case 6:
						if (d == global::DeviceUpdate.d.e)
						{
							goto IL_180;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_125;
						default:
							if (false)
							{
							}
							num = 15;
							continue;
						}
						break;
					case 7:
						goto IL_A2;
					case 8:
						goto IL_125;
					case 9:
						goto IL_1FA;
					case 10:
						if (d != global::DeviceUpdate.d.f)
						{
							num = 11;
							continue;
						}
						goto IL_180;
					case 11:
						num = 6;
						continue;
					case 12:
						if (d == global::DeviceUpdate.d.d)
						{
							num = 2;
							continue;
						}
						num = 3;
						continue;
					case 13:
						goto IL_144;
					case 14:
						if (!this.CanDetectDevice(A_0.strIp))
						{
							num = 7;
							continue;
						}
						goto IL_144;
					case 15:
						num = 12;
						continue;
					case 16:
						goto IL_144;
					case 17:
						if (timeSpan.TotalMinutes > 30.0)
						{
							num = 1;
							continue;
						}
						goto IL_1FA;
					case 18:
						if (true)
						{
						}
						if (d != global::DeviceUpdate.d.b)
						{
							num = 19;
							continue;
						}
						goto IL_180;
					case 19:
						num = 5;
						continue;
					case 20:
						return;
					}
					break;
					IL_125:
					if (d == global::DeviceUpdate.d.g)
					{
						num = 0;
						continue;
					}
					global::System.Threading.Thread.Sleep(10000);
					num = 16;
					continue;
					IL_144:
					timeSpan = global::System.DateTime.Now - now;
					num = 17;
					continue;
					IL_180:
					global::System.Threading.Thread.Sleep(10000);
					num = 13;
					continue;
					IL_1FA:
					d = this.a(A_0, A_1, A_2, A_3, A_4);
					num = 18;
				}
			}
			IL_A2:
			throw new global::custom_exception.CCustomException(1907U, base.GetType().ToString(), "WaitBahamaUpdateComponent", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			IL_17B:
			throw new global::custom_exception.CCustomException(1905U, base.GetType().ToString(), "WaitBahamaUpdateComponent", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000A120 File Offset: 0x00009120
		private global::DeviceUpdate.d a(global::Controller.DeviceInfo A_0, global::DeviceUpdate.c A_1, global::CommunicationController.ISerialTransportController A_2, bool A_3, uint A_4)
		{
			global::DeviceUpdate.d result;
			for (;;)
			{
				uint num = 0U;
				try
				{
					if (true)
					{
					}
					A_2.Open(A_0.strIp, 0U, 8002U, out num);
					result = A_1.a(num, A_2);
				}
				catch (global::custom_exception.CCustomException)
				{
					result = global::DeviceUpdate.d.g;
				}
				catch (global::System.Exception)
				{
					result = global::DeviceUpdate.d.g;
				}
				finally
				{
					A_2.Close(num);
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_55;
				}
			}
			IL_55:
			if (false)
			{
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000A1BC File Offset: 0x000091BC
		private void c(string A_0)
		{
			switch (0)
			{
			default:
			{
				int num = 20;
				for (;;)
				{
					if (true)
					{
					}
					bool flag;
					bool flag2;
					int num3;
					int num4;
					switch (num)
					{
					case 0:
						flag = false;
						num = 5;
						continue;
					case 1:
						goto IL_C3;
					case 2:
						goto IL_194;
					case 3:
						return;
					case 4:
					{
						if (!this.CanDetectDevice(A_0))
						{
							num = 0;
							continue;
						}
						int num2;
						num2++;
						num = 1;
						continue;
					}
					case 5:
						goto IL_256;
					case 6:
					{
						int num2;
						if (num2 >= 3)
						{
							num = 18;
							continue;
						}
						global::System.Threading.Thread.Sleep(1000);
						num = 4;
						continue;
					}
					case 7:
						if (!flag2)
						{
							num = 15;
							continue;
						}
						return;
					case 8:
						goto IL_10E;
					case 9:
					{
						flag = true;
						int num2 = 0;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_262;
						default:
							if (false)
							{
							}
							num = 21;
							continue;
						}
						break;
					}
					case 10:
						if (this.CanDetectDevice(A_0))
						{
							num = 9;
							continue;
						}
						goto IL_A4;
					case 11:
						flag2 = true;
						num = 8;
						continue;
					case 12:
						goto IL_1B4;
					case 13:
						if (num3 >= 50)
						{
							num = 22;
							continue;
						}
						num = 10;
						continue;
					case 14:
						goto IL_1B4;
					case 15:
						num = 17;
						continue;
					case 16:
						goto IL_194;
					case 17:
						if (num4 >= 3)
						{
							num = 23;
							continue;
						}
						num3 = 0;
						num = 14;
						continue;
					case 18:
						goto IL_256;
					case 19:
						goto IL_262;
					case 21:
						goto IL_C3;
					case 22:
						goto IL_10E;
					case 23:
						return;
					}
					if (string.IsNullOrEmpty(A_0))
					{
						num = 3;
						continue;
					}
					flag2 = false;
					global::System.Threading.Thread.Sleep(3000);
					num4 = 0;
					num = 16;
					continue;
					IL_A4:
					global::System.Threading.Thread.Sleep(1000);
					num3++;
					num = 12;
					continue;
					IL_262:
					if (flag)
					{
						num = 11;
						continue;
					}
					goto IL_A4;
					IL_C3:
					num = 6;
					continue;
					IL_10E:
					num4++;
					num = 2;
					continue;
					IL_194:
					num = 7;
					continue;
					IL_1B4:
					num = 13;
					continue;
					IL_256:
					num = 19;
				}
				return;
			}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000A444 File Offset: 0x00009444
		public void SendUpdateIMEType(byte ime)
		{
			switch (0)
			{
			default:
			{
				for (;;)
				{
					uint num = 0U;
					global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
					this.d.ListConnectedDevices(out arrayList);
					int num2 = 1;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_249;
						case 1:
							if (arrayList.Count <= 0)
							{
								num2 = 3;
								continue;
							}
							if (true)
							{
							}
							num2 = 4;
							continue;
						case 2:
							goto IL_269;
						case 3:
							goto IL_5E;
						case 4:
						{
							if (arrayList.Count > 1)
							{
								num2 = 0;
								continue;
							}
							global::System.Collections.IEnumerator enumerator = arrayList.GetEnumerator();
							num2 = 2;
							continue;
						}
						}
						break;
					}
				}
				IL_5E:
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(1687U, base.GetType().ToString(), "FlashDevice", global::System.Environment.StackTrace);
				throw ex;
				IL_1DC:
				global::custom_exception.CCustomException ex2 = global::Controller.CCustomExceptionHandler.CreateException(3841U, base.GetType().ToString(), "FlashDevice", global::System.Environment.StackTrace);
				throw ex2;
				IL_249:
				goto IL_1DC;
				IL_269:
				try
				{
					int num2 = 1;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num2 = 5;
							continue;
						case 2:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num2 = 0;
								continue;
							}
							string strIP = (string)enumerator.Current;
							uint num = 0U;
							this.OpenConnection(strIP, ref num, null);
							object obj;
							this.c.a(num, out obj);
							goto IL_115;
						}
						case 4:
						{
							object obj;
							if (obj == null)
							{
								num2 = 6;
								continue;
							}
							global::CommunicationController.IRadioCodeplugController radioCodeplugController = (global::CommunicationController.IRadioCodeplugController)obj;
							radioCodeplugController.SendUpdateIMEType(ime);
							uint num;
							this.CloseConnection(num);
							global::System.Threading.Thread.Sleep(5000);
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_115;
							default:
								if (false)
								{
								}
								num2 = 3;
								continue;
							}
							break;
						}
						case 5:
							goto IL_18E;
						case 6:
							goto IL_131;
						}
						IL_96:
						num2 = 2;
						continue;
						goto IL_96;
						IL_115:
						num2 = 4;
					}
					IL_131:
					uint num3 = 1371U;
					global::custom_exception.CCustomException ex3 = global::Controller.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "SendUpdateIMEType", global::System.Environment.StackTrace.ToString());
					throw ex3;
					IL_18E:
					return;
				}
				finally
				{
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						global::System.IDisposable disposable = enumerator as global::System.IDisposable;
						int num2 = 2;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num2 = 1;
								continue;
							case 1:
								goto IL_1D9;
							case 2:
								if (disposable != null)
								{
									num2 = 0;
									continue;
								}
								goto IL_1DB;
							}
							break;
						}
					}
					IL_1D9:
					IL_1DB:;
				}
				goto IL_1DC;
			}
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000A6DC File Offset: 0x000096DC
		public void ConvertDevice(global::Controller.DeviceInfo dev, global::constants.CCPTags.SetProgressBar pfSetProgressBar, int progressBarLength)
		{
			for (;;)
			{
				switch (0)
				{
				default:
				{
					string pakUUID = dev.pakUUID;
					global::DeviceUpdate.c c = new global::DeviceUpdate.c(dev.AppSrec, dev.TuneSrec, dev.SecSrec, dev.UclSrec, dev.FWFile1, dev.FWFile2, dev.PSDTFile, dev.BLFile, dev.RDLFile, dev.FieldMoveFile, dev.SourceStructFile, dev.TargetStructFile, dev.FWCompressed, dev.CPCompressed, dev.StructFileCompressed, dev.FieldMoveCompressed, dev.BLCompressed, dev.PSDTCompressed, dev.RDLCompressed, dev.IshComp, pakUUID, dev.SourceIshComp);
					c.a(true);
					try
					{
						int num = 0;
						for (;;)
						{
							string text;
							switch (num)
							{
							case 1:
								text = dev.TargetCPVer;
								goto IL_10B;
							case 2:
								goto IL_12A;
							case 3:
								num = 4;
								continue;
							case 4:
								text = dev.CPVersion;
								goto IL_10B;
							}
							if (!string.IsNullOrEmpty(dev.CPVersion))
							{
								num = 3;
								continue;
							}
							if (true)
							{
							}
							num = 1;
							continue;
							IL_10B:
							string a_ = text;
							c.a(a_, dev.TargetCPVer, dev.objFZ, pfSetProgressBar, progressBarLength);
							num = 2;
						}
						IL_12A:;
					}
					catch (global::custom_exception.CCustomException ex)
					{
						throw ex;
					}
					catch (global::System.Exception ex2)
					{
						global::custom_exception.CCustomException.Rethrow(ex2);
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_150;
					}
					break;
				}
				}
			}
			IL_150:
			if (false)
			{
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000A868 File Offset: 0x00009868
		public void GetAvailPackage(string Model, string tanapa, string Region, string CPSBuildVer, string PackagePath, int upgradeType, ref global::System.Collections.ArrayList alPackages)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						global::System.Collections.ArrayList arrayList = null;
						global::System.Collections.ArrayList arrayList2 = null;
						global::System.Collections.ArrayList a_ = null;
						int num = 3;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (!string.IsNullOrEmpty(tanapa))
								{
									num = 2;
									continue;
								}
								goto IL_C5;
							case 1:
								arrayList = new global::System.Collections.ArrayList();
								arrayList.Add(Model);
								num = 5;
								continue;
							case 2:
								arrayList2 = new global::System.Collections.ArrayList();
								arrayList2.Add(tanapa);
								num = 6;
								continue;
							case 3:
								if (!string.IsNullOrEmpty(Model))
								{
									num = 1;
									continue;
								}
								goto IL_87;
							case 4:
								goto IL_E8;
							case 5:
								goto IL_87;
							case 6:
								goto IL_C5;
							}
							break;
							IL_87:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_E8;
							default:
								if (false)
								{
								}
								num = 0;
								continue;
							}
							IL_C5:
							this.h.a(arrayList, arrayList2, a_, Region, CPSBuildVer, PackagePath, upgradeType, ref alPackages);
							num = 4;
						}
					}
					IL_E8:
					break;
				}
			}
			catch (global::custom_exception.CCustomException ex)
			{
				throw ex;
			}
			catch (global::System.Exception ex2)
			{
				global::custom_exception.CCustomException.Rethrow(ex2);
			}
			if (true)
			{
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000A99C File Offset: 0x0000999C
		public void ModifyItem(uint uiHandleToDatabase, ref string strXMLBuffer)
		{
			switch (0)
			{
			default:
			{
				global::cpservices.IDatabase database;
				for (;;)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C8;
					default:
					{
						if (false)
						{
						}
						int num = 3;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_C6;
							case 1:
								if (database == null)
								{
									num = 0;
									continue;
								}
								goto IL_F7;
							case 2:
								goto IL_67;
							case 3:
								if (true)
								{
								}
								if (!this.b)
								{
									num = 2;
									continue;
								}
								this.a(uiHandleToDatabase, out database);
								num = 1;
								continue;
							}
							break;
						}
						break;
					}
					}
				}
				IL_67:
				goto IL_C8;
				IL_C6:
				uint num2 = 1364U;
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "ModifyItem", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_C8:
				num2 = 1361U;
				global::custom_exception.CCustomException ex2 = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "ModifyItem", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_F7:
				database.ModifyItem(ref strXMLBuffer);
				return;
			}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000AAA8 File Offset: 0x00009AA8
		public void SendEnterFZMode(uint uiHandle)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_5E:
						object obj;
						if (obj == null)
						{
							num = 2;
						}
						else
						{
							global::CommunicationController.IRadioCodeplugController radioCodeplugController = (global::CommunicationController.IRadioCodeplugController)obj;
							radioCodeplugController.SendEnterFZMode();
							num = 1;
						}
						break;
					}
					default:
						if (false)
						{
						}
						goto IL_47;
					}
					IL_2C:
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						goto IL_5E;
					case 1:
						break;
					case 2:
					{
						uint num2 = 1371U;
						global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "SendEnterFZMode", global::System.Environment.StackTrace.ToString());
						throw ex;
					}
					default:
					{
						IL_47:
						object obj;
						this.c.a(uiHandle, out obj);
						num = 0;
						goto IL_2C;
					}
					}
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException ex2)
			{
				throw ex2;
			}
			catch (global::System.Exception ex3)
			{
				global::custom_exception.CCustomException.Rethrow(ex3);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000ABA4 File Offset: 0x00009BA4
		public global::System.Collections.ArrayList EnterBootMode(string RDLFile, bool compressed, global::System.Collections.Generic.List<string> IPs, bool deviceMode, string uuid, int ishversion, int srcIshVersion)
		{
			for (;;)
			{
				uint num = 0U;
				int num2 = 4;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						int num3;
						if (num3 >= IPs.Count)
						{
							num2 = 2;
							continue;
						}
						num = 0U;
						this.OpenConnection(IPs[num3].ToString(), ref num, null);
						this.SendEnterFZMode(num);
						this.CloseConnection(num);
						global::System.Threading.Thread.Sleep(5000);
						num3++;
						num2 = 5;
						continue;
					}
					case 1:
						goto IL_3F;
					case 2:
						global::System.Threading.Thread.Sleep(15000);
						num2 = 3;
						continue;
					case 3:
						goto IL_CA;
					case 4:
						if (deviceMode)
						{
							num2 = 6;
							continue;
						}
						goto IL_CA;
					case 5:
						IL_98:
						goto IL_3F;
					case 6:
					{
						int num3 = 0;
						num2 = 1;
						continue;
					}
					}
					break;
					IL_3F:
					num2 = 0;
					continue;
					IL_CA:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_98;
					default:
						goto IL_E0;
					}
				}
			}
			IL_E0:
			if (true)
			{
			}
			if (false)
			{
			}
			global::System.Collections.ArrayList result = new global::System.Collections.ArrayList();
			this.ListBootModeDevices(RDLFile, compressed, out result, uuid, ishversion, srcIshVersion);
			return result;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000ACB8 File Offset: 0x00009CB8
		private void b(string A_0)
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
			this.a.Add(A_0);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000AD00 File Offset: 0x00009D00
		public void ListBootModeDevices(string RDLFile, bool compressed, out global::System.Collections.ArrayList alDevs, string uuid, int ishversion, int srcIshVersion)
		{
			for (;;)
			{
				alDevs = null;
				try
				{
					global::System.Collections.ArrayList arrayList = null;
					int a_ = global::DeviceUpdate.a.a(ishversion);
					srcIshVersion = global::DeviceUpdate.a.a(srcIshVersion);
					this.h.a(RDLFile, compressed, out arrayList, uuid, a_, srcIshVersion);
					alDevs = arrayList;
				}
				catch (global::custom_exception.CCustomException ex)
				{
					throw ex;
				}
				catch (global::System.Exception ex2)
				{
					global::custom_exception.CCustomException.Rethrow(ex2);
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
					goto IL_5B;
				}
			}
			IL_5B:
			if (false)
			{
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000AD94 File Offset: 0x00009D94
		public bool IsOpen()
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
			return this.b;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000ADD8 File Offset: 0x00009DD8
		private void a(uint A_0, out global::cpservices.IDatabase A_1)
		{
			switch (0)
			{
			default:
			{
				object obj;
				for (;;)
				{
					A_1 = null;
					uint num;
					this.c.a(A_0, out obj, out num);
					int num2 = 0;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (obj == null)
							{
								num2 = 3;
								continue;
							}
							num2 = 1;
							continue;
						case 1:
							if (true)
							{
							}
							if (1U != num)
							{
								goto IL_A3;
							}
							goto IL_FC;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_A3;
							default:
								goto IL_C5;
							}
							break;
						case 3:
							goto IL_59;
						}
						break;
						IL_A3:
						num2 = 2;
					}
				}
				IL_59:
				uint num3 = 1364U;
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "GetMatrixDB", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_C5:
				if (false)
				{
				}
				uint num4 = 1365U;
				global::custom_exception.CCustomException ex2 = global::Controller.CCustomExceptionHandler.CreateException(num4 & 65535U, base.GetType().ToString(), "GetMatrixDB", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_FC:
				A_1 = (global::cpservices.IDatabase)obj;
				return;
			}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000AEEC File Offset: 0x00009EEC
		public bool IsValidHandleToDB(uint uiHandleToDatabase)
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
				object obj;
				uint num;
				this.c.a(uiHandleToDatabase, out obj, out num);
				if (obj != null)
				{
					return true;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000AF40 File Offset: 0x00009F40
		public void Close(uint uiHandleToDatabase)
		{
			switch (0)
			{
			default:
			{
				for (;;)
				{
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							object obj;
							global::CommunicationController.IRadioCodeplugController radioCodeplugController = (global::CommunicationController.IRadioCodeplugController)obj;
							if (true)
							{
							}
							num = 1;
							continue;
						}
						case 1:
							goto IL_61;
						case 2:
							goto IL_47;
						case 3:
						{
							if (!this.b)
							{
								goto IL_3E;
							}
							object obj;
							this.c.a(uiHandleToDatabase, out obj);
							num = 4;
							continue;
						}
						case 4:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3E;
							default:
							{
								if (false)
								{
								}
								object obj;
								if (obj != null)
								{
									num = 0;
									continue;
								}
								goto IL_142;
							}
							}
							break;
						}
						break;
						IL_3E:
						num = 2;
					}
				}
				IL_47:
				uint num2 = 1361U;
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "Close", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_61:
				try
				{
					global::CommunicationController.IRadioCodeplugController radioCodeplugController;
					radioCodeplugController.Close();
					this.d.Close(radioCodeplugController.GetSerialHandle());
				}
				catch (global::custom_exception.CCustomException ex2)
				{
					this.c.a(uiHandleToDatabase);
					this.c.b(uiHandleToDatabase);
					throw ex2;
				}
				catch (global::System.Exception ex3)
				{
					this.c.a(uiHandleToDatabase);
					this.c.b(uiHandleToDatabase);
					global::custom_exception.CCustomException.Rethrow(ex3);
				}
				IL_142:
				this.c.b(uiHandleToDatabase);
				return;
			}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000B0B8 File Offset: 0x0000A0B8
		private string a(global::CommunicationController.IRadioCodeplugController A_0)
		{
			switch (0)
			{
			default:
			{
				string result;
				for (;;)
				{
					for (;;)
					{
						string strCommand = global::CommunicationController.enumCommand.QUERYRADIOUUID.ToString();
						string text = "";
						int num = 9;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_C6;
							case 1:
								goto IL_115;
							case 2:
								goto IL_ED;
							case 3:
								if (true)
								{
								}
								result = "Bahama";
								num = 0;
								continue;
							case 4:
								if (text.Equals("06CE7B7163C0456A845A6E13421F0AE4"))
								{
									num = 10;
									continue;
								}
								num = 5;
								continue;
							case 5:
								if (global::Controller.DeviceInfo.isGemstoneRadio(text))
								{
									num = 2;
									continue;
								}
								num = 8;
								continue;
							case 6:
								goto IL_100;
							case 7:
								goto IL_15B;
							case 8:
								if (global::Controller.DeviceInfo.isBahamaRadio(text))
								{
									num = 3;
									continue;
								}
								result = "MATRIX";
								num = 1;
								continue;
							case 9:
								try
								{
									text = A_0.IoControl<string>(strCommand);
									goto IL_117;
								}
								catch (global::custom_exception.CCustomException ex)
								{
									A_0.Close();
									throw ex;
								}
								catch (global::System.Exception ex2)
								{
									A_0.Close();
									global::custom_exception.CCustomException.Rethrow(ex2);
									goto IL_117;
								}
								goto IL_ED;
								IL_117:
								result = string.Empty;
								num = 4;
								continue;
							case 10:
								result = "PHOENIX";
								num = 7;
								continue;
							}
							break;
							IL_ED:
							result = "GEMSTONE";
							num = 6;
						}
					}
					IL_15B:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_171;
					}
				}
				IL_C6:
				IL_100:
				IL_115:
				return result;
				IL_171:
				if (false)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000B25C File Offset: 0x0000A25C
		private void a(string A_0, ref uint A_1, global::constants.CCPTags.SetProgressBar A_2)
		{
			switch (0)
			{
			default:
			{
				global::CommunicationController.IRadioCodeplugController radioCodeplugController;
				uint num;
				string text;
				int num2;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_21C:
					try
					{
						radioCodeplugController.Open(this.d.GetPointer(), num, this.e, 0U, false, null);
						goto IL_1BB;
					}
					catch (global::custom_exception.CCustomException ex)
					{
						this.d.Close(num);
						throw ex;
					}
					catch (global::System.Exception ex2)
					{
						this.d.Close(num);
						global::custom_exception.CCustomException.Rethrow(ex2);
						goto IL_1BB;
					}
					return;
					IL_1BB:
					text = this.a(radioCodeplugController);
					num2 = 8;
					break;
				default:
					if (false)
					{
					}
					goto IL_5F;
				}
				for (;;)
				{
					IL_2C:
					switch (num2)
					{
					case 0:
						this.Close(A_1);
						num2 = 5;
						continue;
					case 1:
						try
						{
							global::cpservices.IDatabase database;
							object obj = database;
							uint a_ = 1U;
							this.c.a(ref obj, a_, out A_1);
							this.c.a(A_1, radioCodeplugController);
							return;
						}
						catch (global::custom_exception.CCustomException ex3)
						{
							radioCodeplugController.Close();
							this.d.Close(num);
							throw ex3;
						}
						catch (global::System.Exception ex4)
						{
							radioCodeplugController.Close();
							this.d.Close(num);
							global::custom_exception.CCustomException.Rethrow(ex4);
							return;
						}
						goto IL_15C;
					case 2:
						goto IL_21C;
					case 3:
						goto IL_86;
					case 4:
						if (A_1 != 0U)
						{
							num2 = 6;
							continue;
						}
						goto IL_1F5;
					case 5:
						goto IL_1F5;
					case 6:
						num2 = 7;
						continue;
					case 7:
						if (this.IsValidHandleToDB(A_1))
						{
							num2 = 0;
							continue;
						}
						goto IL_1F5;
					case 8:
					{
						if (string.IsNullOrEmpty(text))
						{
							num2 = 10;
							continue;
						}
						global::cpservices.IDatabase database = new global::cpservices.CCPServices(ref this.g, this.e, text);
						num2 = 1;
						continue;
					}
					case 9:
						if (!this.b)
						{
							num2 = 3;
							continue;
						}
						goto IL_15C;
					case 10:
						goto IL_1F0;
					}
					goto IL_5F;
					IL_15C:
					num2 = 4;
					continue;
					IL_1F5:
					this.d.Open(A_0, 0U, 8002U, out num);
					radioCodeplugController = new global::CommunicationController.CRadioCodeplugController();
					num2 = 2;
				}
				IL_86:
				uint num3 = 1361U;
				global::custom_exception.CCustomException ex5 = global::Controller.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "AddCommPath", global::System.Environment.StackTrace.ToString());
				throw ex5;
				IL_1F0:
				this.d.Close(num);
				radioCodeplugController.Close();
				num3 = 1365U;
				global::custom_exception.CCustomException ex6 = global::Controller.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "AddCommPath", global::System.Environment.StackTrace.ToString());
				throw ex6;
				IL_5F:
				if (true)
				{
				}
				num2 = 9;
				goto IL_2C;
			}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000B538 File Offset: 0x0000A538
		private void a(string A_0, string A_1, ref uint A_2, global::constants.CCPTags.SetProgressBar A_3)
		{
			switch (0)
			{
			default:
			{
				global::CommunicationController.IRadioCodeplugController radioCodeplugController;
				uint num2;
				for (;;)
				{
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_D0;
						case 1:
							if (!this.b)
							{
								num = 7;
								continue;
							}
							goto IL_138;
						case 2:
							goto IL_1CC;
						case 3:
							goto IL_1C7;
						case 4:
							if (A_2 != 0U)
							{
								num = 5;
								continue;
							}
							goto IL_1CC;
						case 5:
							num = 6;
							continue;
						case 6:
							if (this.IsValidHandleToDB(A_2))
							{
								num = 0;
								continue;
							}
							goto IL_1CC;
						case 7:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_D0;
							default:
								goto IL_20B;
							}
							break;
						case 8:
						{
							try
							{
								radioCodeplugController.Open(this.d.GetPointer(), num2, this.e, 0U, false, A_3);
								goto IL_19C;
							}
							catch (global::custom_exception.CCustomException ex)
							{
								this.d.Close(num2);
								throw ex;
							}
							catch (global::System.Exception ex2)
							{
								this.d.Close(num2);
								global::custom_exception.CCustomException.Rethrow(ex2);
								goto IL_19C;
							}
							return;
							IL_19C:
							string text = this.a(radioCodeplugController);
							num = 10;
							continue;
						}
						case 9:
							try
							{
								global::cpservices.IDatabase database;
								object obj = database;
								uint a_ = 1U;
								this.c.a(ref obj, a_, out A_2);
								this.c.a(A_2, radioCodeplugController);
								return;
							}
							catch (global::custom_exception.CCustomException ex3)
							{
								radioCodeplugController.Close();
								this.d.Close(num2);
								throw ex3;
							}
							catch (global::System.Exception ex4)
							{
								radioCodeplugController.Close();
								this.d.Close(num2);
								global::custom_exception.CCustomException.Rethrow(ex4);
								return;
							}
							goto IL_138;
						case 10:
						{
							string text;
							if (string.IsNullOrEmpty(text))
							{
								num = 3;
								continue;
							}
							global::cpservices.IDatabase database = new global::cpservices.CCPServices(ref this.g, this.e, text);
							num = 9;
							continue;
						}
						}
						break;
						IL_D0:
						this.Close(A_2);
						num = 2;
						continue;
						IL_138:
						if (true)
						{
						}
						num = 4;
						continue;
						IL_1CC:
						this.d.Open(A_0, 0U, 8002U, out num2);
						radioCodeplugController = new global::CommunicationController.CRadioCodeplugController();
						num = 8;
					}
				}
				IL_1C7:
				this.d.Close(num2);
				radioCodeplugController.Close();
				uint num3 = 1365U;
				global::custom_exception.CCustomException ex5 = global::Controller.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "AddCommPath", global::System.Environment.StackTrace.ToString());
				throw ex5;
				IL_20B:
				if (false)
				{
				}
				num3 = 1361U;
				global::custom_exception.CCustomException ex6 = global::Controller.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "AddCommPath", global::System.Environment.StackTrace.ToString());
				throw ex6;
			}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000B810 File Offset: 0x0000A810
		private void a(uint A_0)
		{
			switch (0)
			{
			default:
			{
				int num = 1;
				for (;;)
				{
					object obj;
					switch (num)
					{
					case 0:
						goto IL_79;
					case 2:
						if (obj != null)
						{
							if (true)
							{
							}
							num = 3;
							continue;
						}
						return;
					case 3:
					{
						global::CommunicationController.IRadioCodeplugController radioCodeplugController = (global::CommunicationController.IRadioCodeplugController)obj;
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
							continue;
						}
						break;
					}
					case 4:
						return;
					}
					IL_34:
					if (A_0 <= 0U)
					{
						num = 4;
						continue;
					}
					this.c.a(A_0, out obj);
					num = 2;
					continue;
					goto IL_34;
				}
				return;
				IL_79:
				try
				{
					global::CommunicationController.IRadioCodeplugController radioCodeplugController;
					radioCodeplugController.GetSerialHandle();
					this.d.Close(radioCodeplugController.GetSerialHandle());
					radioCodeplugController.Close();
					this.c.a(A_0);
				}
				catch (global::custom_exception.CCustomException ex)
				{
					this.c.a(A_0);
					throw ex;
				}
				catch (global::System.Exception ex2)
				{
					this.c.a(A_0);
					global::custom_exception.CCustomException.Rethrow(ex2);
				}
				return;
			}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000B938 File Offset: 0x0000A938
		public void WriteDevice(uint uiHandleToDatabase, global::System.Collections.ArrayList alDataList, global::constants.CCPTags.SetProgressBar pfSetProgressBar)
		{
			switch (0)
			{
			default:
			{
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
					{
						object obj;
						if (obj != null)
						{
							if (true)
							{
							}
							num = 5;
							continue;
						}
						goto IL_FD;
					}
					case 1:
					{
						global::cpservices.IDatabase database;
						if (database == null)
						{
							num = 2;
							continue;
						}
						object obj;
						this.c.a(uiHandleToDatabase, out obj);
						num = 0;
						continue;
					}
					case 2:
						goto IL_A6;
					case 3:
						goto IL_4D;
					case 5:
					{
						object obj;
						global::CommunicationController.IRadioCodeplugController interfaceRCCtrl = (global::CommunicationController.IRadioCodeplugController)obj;
						global::cpservices.IDatabase database;
						global::cpservices.IDatabase database2 = database;
						num = 6;
						continue;
					}
					case 6:
						goto IL_64;
					}
					if (!this.b)
					{
						num = 3;
					}
					else
					{
						global::cpservices.IDatabase database;
						this.a(uiHandleToDatabase, out database);
						num = 1;
					}
				}
				IL_4D:
				uint num2 = 1361U;
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "WriteDevice", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_64:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					try
					{
						global::CommunicationController.IRadioCodeplugController interfaceRCCtrl;
						global::cpservices.IDatabase database2;
						database2.WriteDevice(interfaceRCCtrl, alDataList, pfSetProgressBar);
						break;
					}
					catch (global::custom_exception.CCustomException ex2)
					{
						throw ex2;
					}
					catch (global::System.Exception ex3)
					{
						global::custom_exception.CCustomException.Rethrow(ex3);
						break;
					}
					goto IL_FD;
				}
				return;
				IL_A6:
				uint num3 = 1364U;
				global::custom_exception.CCustomException ex4 = global::Controller.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "WriteDevice", global::System.Environment.StackTrace.ToString());
				throw ex4;
				IL_FD:
				uint num4 = 1371U;
				global::custom_exception.CCustomException ex5 = global::Controller.CCustomExceptionHandler.CreateException(num4 & 65535U, base.GetType().ToString(), "WriteDevice", global::System.Environment.StackTrace.ToString());
				throw ex5;
			}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000BB04 File Offset: 0x0000AB04
		private bool a(string A_0)
		{
			int num = 8;
			for (;;)
			{
				char c;
				switch (num)
				{
				case 0:
					goto IL_F3;
				case 1:
					if (!(A_0 == "T3000A"))
					{
						num = 5;
						continue;
					}
					return true;
				case 2:
					if (A_0.Length == 6)
					{
						if (true)
						{
						}
						num = 6;
						continue;
					}
					goto IL_146;
				case 3:
					if (A_0.Length != 7)
					{
						num = 10;
						continue;
					}
					goto IL_116;
				case 4:
					if (c.Equals('R'))
					{
						num = 7;
						continue;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F3;
					default:
						goto IL_E1;
					}
					break;
				case 5:
					num = 11;
					continue;
				case 6:
					goto IL_116;
				case 7:
					goto IL_75;
				case 9:
					num = 4;
					continue;
				case 10:
					num = 2;
					continue;
				case 11:
					if (!(A_0 == "T2003A"))
					{
						num = 9;
						continue;
					}
					return true;
				}
				if (A_0.Length != 12)
				{
					num = 0;
					continue;
				}
				goto IL_116;
				IL_F3:
				num = 3;
				continue;
				IL_116:
				c = A_0[5];
				num = 1;
			}
			IL_75:
			return true;
			IL_E1:
			if (false)
			{
			}
			return false;
			IL_146:
			global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(1026U, base.GetType().ToString(), "IsRepeater", global::System.Environment.StackTrace.ToString());
			throw ex;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000BC80 File Offset: 0x0000AC80
		public void ReadDevice(ref uint uiHandleToDatabase, ref string RetrievedXML, ref bool AutoCorrectionReq, global::constants.CCPTags.SetProgressBar pfSetProgressBar)
		{
			switch (0)
			{
			default:
			{
				global::cpservices.IDatabase database;
				object obj;
				for (;;)
				{
					IL_0E:
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_59;
						case 1:
							if (database == null)
							{
								num = 3;
								continue;
							}
							this.c.a(uiHandleToDatabase, out obj);
							num = 5;
							continue;
						case 3:
							goto IL_1A0;
						case 4:
							this.a(uiHandleToDatabase, out database);
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_0E;
							default:
								if (false)
								{
								}
								num = 1;
								continue;
							}
							break;
						case 5:
							if (obj != null)
							{
								num = 7;
								continue;
							}
							goto IL_D8;
						case 6:
							if (uiHandleToDatabase != 0U)
							{
								num = 4;
								continue;
							}
							goto IL_1A5;
						case 7:
							goto IL_83;
						}
						if (true)
						{
						}
						if (!this.b)
						{
							num = 0;
						}
						else
						{
							num = 6;
						}
					}
				}
				IL_59:
				uint num2 = 1361U;
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "WriteDevice", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_83:
				global::CommunicationController.IRadioCodeplugController interfaceRCCtrl = (global::CommunicationController.IRadioCodeplugController)obj;
				global::cpservices.IDatabase database2 = database;
				database2.ReadDevice(interfaceRCCtrl, ref RetrievedXML, ref AutoCorrectionReq, pfSetProgressBar);
				return;
				IL_D8:
				num2 = 1371U;
				global::custom_exception.CCustomException ex2 = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "ReadDevice", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_1A0:
				num2 = 1364U;
				global::custom_exception.CCustomException ex3 = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "ReadDevice", global::System.Environment.StackTrace.ToString());
				throw ex3;
				IL_1A5:
				num2 = 1364U;
				global::custom_exception.CCustomException ex4 = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "ReadDevice", global::System.Environment.StackTrace.ToString());
				throw ex4;
			}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000BE64 File Offset: 0x0000AE64
		public void RetrieveItem(uint uiHandleToDatabase, global::System.Collections.ArrayList alTagName, global::System.Collections.ArrayList alListID, global::System.Collections.ArrayList alListLetID, ref string strXMLBuffer)
		{
			switch (0)
			{
			default:
			{
				global::cpservices.IDatabase database;
				for (;;)
				{
					IL_27:
					for (;;)
					{
						int num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_B4;
							case 1:
								goto IL_43;
							case 2:
								if (!this.b)
								{
									num = 1;
									continue;
								}
								this.a(uiHandleToDatabase, out database);
								num = 3;
								continue;
							case 3:
								if (database == null)
								{
									num = 0;
									continue;
								}
								goto IL_EF;
							}
							goto IL_27;
						}
						IL_43:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_59;
						}
					}
				}
				IL_59:
				if (false)
				{
				}
				uint num2 = 1361U;
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "RetrieveItem", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_B4:
				num2 = 1364U;
				global::custom_exception.CCustomException ex2 = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "RetrieveItem", global::System.Environment.StackTrace.ToString());
				throw ex2;
				IL_EF:
				if (true)
				{
				}
				database.RetrieveItem(alTagName, alListID, alListLetID, ref strXMLBuffer);
				return;
			}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000BF74 File Offset: 0x0000AF74
		public void VerifyUserLogin(string strUserName, string strPassword)
		{
			if (this.b)
			{
				try
				{
					this.f.VerifyUserLogin(strUserName, strPassword);
					goto IL_56;
				}
				catch (global::custom_exception.CCustomException ex)
				{
					throw ex;
				}
				catch (global::System.Exception ex2)
				{
					global::custom_exception.CCustomException.Rethrow(ex2);
					goto IL_56;
				}
				goto IL_27;
				IL_56:
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0A;
				}
				if (false)
				{
				}
				return;
			}
			IL_0A:
			IL_27:
			uint num = 1361U;
			global::custom_exception.CCustomException ex3 = global::Controller.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "VerifyUserLogin", global::System.Environment.StackTrace.ToString());
			throw ex3;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000C024 File Offset: 0x0000B024
		public void IsUserConnected()
		{
			if (this.b)
			{
				try
				{
					this.f.IsUserConnected();
					goto IL_66;
				}
				catch (global::custom_exception.CCustomException ex)
				{
					throw ex;
				}
				catch (global::System.Exception ex2)
				{
					global::custom_exception.CCustomException.Rethrow(ex2);
					goto IL_66;
				}
				goto IL_2F;
				IL_66:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					return;
				}
			}
			IL_2F:
			if (true)
			{
			}
			uint num = 1361U;
			global::custom_exception.CCustomException ex3 = global::Controller.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "IsUserConnected", global::System.Environment.StackTrace.ToString());
			throw ex3;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000C0D0 File Offset: 0x0000B0D0
		public void IsMotorolaUser()
		{
			for (;;)
			{
				if (true)
				{
				}
				if (this.b)
				{
					try
					{
						this.f.IsMotorolaUser();
						return;
					}
					catch (global::custom_exception.CCustomException ex)
					{
						throw ex;
					}
					catch (global::System.Exception ex2)
					{
						global::custom_exception.CCustomException.Rethrow(ex2);
						return;
					}
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_4D;
				}
			}
			IL_4D:
			if (false)
			{
			}
			uint num = 1361U;
			global::custom_exception.CCustomException ex3 = global::Controller.CCustomExceptionHandler.CreateException(num & 65535U, base.GetType().ToString(), "IsMotorolaUser", global::System.Environment.StackTrace.ToString());
			throw ex3;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000C17C File Offset: 0x0000B17C
		public void GetModelType(uint uiHandleToDatabase, string sModel, out string sRadioType)
		{
			switch (0)
			{
			default:
			{
				for (;;)
				{
					sRadioType = string.Empty;
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (!this.b)
							{
								num = 2;
								continue;
							}
							num = 4;
							continue;
						case 1:
							goto IL_147;
						case 2:
							goto IL_50;
						case 3:
							goto IL_E7;
						case 4:
						{
							if (uiHandleToDatabase == 0U)
							{
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_121;
								}
								if (false)
								{
								}
								num = 3;
								continue;
							}
							global::cpservices.IDatabase database;
							this.a(uiHandleToDatabase, out database);
							IL_121:
							num = 5;
							continue;
						}
						case 5:
						{
							global::cpservices.IDatabase database;
							if (database == null)
							{
								if (true)
								{
								}
								num = 1;
								continue;
							}
							goto IL_55;
						}
						}
						break;
					}
				}
				IL_50:
				uint num2 = 1361U;
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetModelType", global::System.Environment.StackTrace.ToString());
				throw ex;
				try
				{
					IL_55:
					global::cpservices.IDatabase database;
					database.GetModelType(sModel, ref sRadioType);
					return;
				}
				catch (global::custom_exception.CCustomException ex2)
				{
					throw ex2;
				}
				catch (global::System.Exception ex3)
				{
					global::custom_exception.CCustomException.Rethrow(ex3);
					return;
				}
				IL_75:
				num2 = 1364U;
				global::custom_exception.CCustomException ex4 = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetModelType", global::System.Environment.StackTrace.ToString());
				throw ex4;
				IL_E7:
				num2 = 1364U;
				global::custom_exception.CCustomException ex5 = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetModelType", global::System.Environment.StackTrace.ToString());
				throw ex5;
				IL_147:
				goto IL_75;
			}
			}
		}

		// Token: 0x04000028 RID: 40
		private global::System.Collections.ArrayList a;

		// Token: 0x04000029 RID: 41
		private bool b;

		// Token: 0x0400002A RID: 42
		private global::Controller.a c;

		// Token: 0x0400002B RID: 43
		private global::CommunicationController.ISerialTransportController d;

		// Token: 0x0400002C RID: 44
		private global::ErrorLogging.ILogApplicationError e;

		// Token: 0x0400002D RID: 45
		private global::LdapAuthenticationInterfaceController.ILdapAuthenticationInterfaceController f;

		// Token: 0x0400002E RID: 46
		private string g;

		// Token: 0x0400002F RID: 47
		private global::DeviceUpdate.c h;

		// Token: 0x04000030 RID: 48
		private global::CommunicationController.ISerialTransportController i;

		// Token: 0x04000031 RID: 49
		private global::CommunicationController.IRadioCodeplugController j;

		// Token: 0x04000032 RID: 50
		private bool k;
	}
}
