using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;
using CommunicationController;
using constants;
using custom_exception;
using ErrorLogging;
using IshHandler;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Service;
using Motorola.Common.CustomException;
using RegistryAccess;
using UpdateController;

namespace DeviceUpdate
{
	// Token: 0x0200001C RID: 28
	public class c
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x0001DA20 File Offset: 0x0001CA20
		public bool a()
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
			return this.al;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0001DA64 File Offset: 0x0001CA64
		public void a(bool A_0)
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
			this.al = A_0;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0001DAA8 File Offset: 0x0001CAA8
		public c()
		{
			this.b = new global::UpdateController.a(this.a());
			this.c = new global::IshHandler.f();
			this.c.a(global::IshHandler.i.b);
			if (this.b != null)
			{
				if (this.c != null)
				{
					this.d = string.Empty;
					this.f = string.Empty;
					this.e = string.Empty;
					this.ab = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.a);
					this.ac = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.b);
					this.ad = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.c);
					this.ae = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.d);
					this.g = string.Empty;
					this.h = string.Empty;
					this.j = string.Empty;
					this.k = string.Empty;
					this.i = string.Empty;
					this.af = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.e);
					this.ag = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.f);
					this.ak = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.i);
					this.ai = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.g);
					this.aj = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.h);
					this.n = string.Empty;
					this.l = string.Empty;
					this.u = false;
					this.v = false;
					this.w = false;
					this.x = false;
					this.y = false;
					this.z = false;
					this.aa = false;
					this.q = string.Empty;
					this.r = string.Empty;
					this.s = string.Empty;
					this.t = string.Empty;
					return;
				}
			}
			global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "CDeviceUpdate", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			throw ex;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0001DC84 File Offset: 0x0001CC84
		public c(global::DeviceUpdate.c A_0)
		{
			this.b = A_0.b;
			this.c = new global::IshHandler.f();
			this.c.a(global::IshHandler.i.b);
			if (this.b != null)
			{
				if (this.c != null)
				{
					this.d = string.Empty;
					this.f = string.Empty;
					this.e = string.Empty;
					this.ab = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.a);
					this.ac = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.b);
					this.ad = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.c);
					this.ae = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.d);
					this.g = string.Empty;
					this.h = string.Empty;
					this.j = string.Empty;
					this.k = string.Empty;
					this.i = string.Empty;
					this.af = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.e);
					this.ag = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.f);
					this.ak = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.i);
					this.ai = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.g);
					this.aj = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.h);
					this.n = string.Empty;
					this.l = string.Empty;
					this.u = false;
					this.v = false;
					this.w = false;
					this.x = false;
					this.y = false;
					this.z = false;
					this.aa = false;
					this.q = string.Empty;
					this.r = string.Empty;
					this.s = string.Empty;
					this.t = string.Empty;
					return;
				}
			}
			global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "CDeviceUpdate", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			throw ex;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0001DE58 File Offset: 0x0001CE58
		private void a(string A_0, int A_1)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					num = 7;
					continue;
				case 1:
					goto IL_43;
				case 3:
					goto IL_6F;
				case 4:
					goto IL_14A;
				case 5:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						if (false)
						{
						}
						if (A_0 != null)
						{
							num = 6;
							continue;
						}
						goto IL_14F;
					}
					break;
				case 6:
					num = 3;
					continue;
				case 7:
					if (A_1 <= 1)
					{
						num = 4;
						continue;
					}
					goto IL_B2;
				}
				if (string.IsNullOrEmpty(A_0))
				{
					num = 1;
					continue;
				}
				num = 5;
				continue;
				IL_6F:
				if (!(A_0 == "D105ADD323864E539B513A65076458D3"))
				{
					goto IL_14F;
				}
				num = 0;
			}
			IL_43:
			global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "SetPartitionName", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			throw ex;
			IL_B2:
			this.q = "CPGA";
			this.r = "TUNA";
			this.s = "SECA";
			this.t = string.Empty;
			return;
			IL_14A:
			this.q = "CPLG";
			this.r = "TUNE";
			this.s = "SECP";
			return;
			IL_14F:
			this.q = "CPGA";
			this.r = "TUNA";
			this.s = "SECA";
			this.t = "UCLA";
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0001DFE0 File Offset: 0x0001CFE0
		public c(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5, string A_6, string A_7, string A_8, string A_9, string A_10, string A_11, bool A_12, bool A_13, bool A_14, bool A_15, bool A_16, bool A_17, bool A_18, int A_19, string A_20, int A_21)
		{
			this.b = new global::UpdateController.a(this.a());
			this.c = new global::IshHandler.f(A_14, A_15);
			this.c.a(global::IshHandler.i.b);
			if (this.b != null)
			{
				if (this.c != null)
				{
					this.d = string.Empty;
					this.f = string.Empty;
					this.e = string.Empty;
					this.ab = new global::DeviceUpdate.c.d(A_0, global::DeviceUpdate.c.e.a);
					this.ac = new global::DeviceUpdate.c.d(A_1, global::DeviceUpdate.c.e.b);
					this.ad = new global::DeviceUpdate.c.d(A_2, global::DeviceUpdate.c.e.c);
					if (!string.IsNullOrEmpty(A_3))
					{
						this.ae = new global::DeviceUpdate.c.d(A_3, global::DeviceUpdate.c.e.d);
					}
					this.g = string.Empty;
					this.h = string.Empty;
					this.j = A_10;
					this.k = A_11;
					this.i = string.Empty;
					this.af = new global::DeviceUpdate.c.d(A_4, global::DeviceUpdate.c.e.e);
					this.ag = new global::DeviceUpdate.c.d(A_5, global::DeviceUpdate.c.e.f);
					this.ak = new global::DeviceUpdate.c.d(A_8, global::DeviceUpdate.c.e.i);
					this.ai = new global::DeviceUpdate.c.d(A_6, global::DeviceUpdate.c.e.g);
					this.aj = new global::DeviceUpdate.c.d(A_7, global::DeviceUpdate.c.e.h);
					this.n = A_20;
					this.l = A_9;
					this.u = A_12;
					this.v = A_13;
					this.w = false;
					this.x = A_16;
					this.y = A_17;
					this.z = A_18;
					this.aa = A_15;
					this.o = A_19;
					int num = this.o;
					if (num <= 20)
					{
						if (num != 10)
						{
							if (num == 20)
							{
								this.o = 2;
							}
						}
						else
						{
							this.o = 1;
						}
					}
					else if (num != 23)
					{
						if (num == 30)
						{
							this.o = 3;
						}
					}
					else
					{
						this.o = 2;
					}
					this.p = A_21;
					int num2 = this.p;
					if (num2 <= 20)
					{
						if (num2 != 10)
						{
							if (num2 == 20)
							{
								this.p = 2;
							}
						}
						else
						{
							this.p = 1;
						}
					}
					else if (num2 != 23)
					{
						if (num2 == 30)
						{
							this.p = 3;
						}
					}
					else
					{
						this.p = 2;
					}
					this.a(this.n, this.o);
					return;
				}
			}
			global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "CDeviceUpdate", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			throw ex;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0001E278 File Offset: 0x0001D278
		public c(string A_0, string A_1, string A_2, string A_3, bool A_4, bool A_5)
		{
			this.b = new global::UpdateController.a(this.a());
			if (this.b == null)
			{
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "CDeviceUpdate", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
			}
			this.d = string.Empty;
			this.f = string.Empty;
			this.e = string.Empty;
			this.ab = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.a);
			this.ac = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.b);
			this.ad = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.c);
			this.ae = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.d);
			this.g = string.Empty;
			this.h = string.Empty;
			this.j = string.Empty;
			this.k = string.Empty;
			this.i = string.Empty;
			this.af = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.e);
			this.ag = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.f);
			this.ak = new global::DeviceUpdate.c.d(A_2, global::DeviceUpdate.c.e.i);
			this.ah = new global::DeviceUpdate.c.d(A_3, global::DeviceUpdate.c.e.j);
			this.ai = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.g);
			this.aj = new global::DeviceUpdate.c.d("", global::DeviceUpdate.c.e.h);
			this.n = string.Empty;
			this.l = string.Empty;
			this.u = false;
			this.v = false;
			this.x = false;
			this.y = false;
			this.aa = false;
			this.w = A_5;
			this.z = A_4;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0001E414 File Offset: 0x0001D414
		public void a(object A_0)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.b = (global::UpdateController.a)A_0;
				this.b.i();
			}
			catch
			{
			}
			if (true)
			{
			}
			this.b.d();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0001E488 File Offset: 0x0001D488
		public global::System.Xml.XmlNode a(global::System.Xml.XmlNode A_0, string A_1)
		{
			for (;;)
			{
				global::System.Xml.XmlNode xmlNode = null;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_53;
					case 1:
						goto IL_A4;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_55;
						default:
							if (false)
							{
							}
							if (A_0 == null)
							{
								num = 0;
								continue;
							}
							xmlNode = A_0[A_1];
							if (true)
							{
							}
							num = 3;
							continue;
						}
						break;
					case 3:
						if (xmlNode == null)
						{
							num = 1;
							continue;
						}
						return xmlNode;
					}
					break;
				}
			}
			IL_53:
			global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2928U, "DeviceUpdate", "CDeviceUpdate", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			throw ex;
			IL_55:
			global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2928U, "DeviceUpdate", "CDeviceUpdate", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			throw ex2;
			IL_A4:
			goto IL_55;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0001E564 File Offset: 0x0001D564
		public void a(string A_0, string A_1, string A_2, string A_3, string A_4, bool A_5, ref global::System.Collections.ArrayList A_6)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 24;
					for (;;)
					{
						string text;
						string text6;
						string text7;
						int num8;
						int num9;
						string[] array;
						switch (num)
						{
						case 0:
							if (A_5)
							{
								num = 21;
								continue;
							}
							goto IL_D6E;
						case 1:
						{
							global::System.IO.DirectoryInfo directoryInfo;
							if (directoryInfo != null)
							{
								num = 15;
								continue;
							}
							goto IL_C13;
						}
						case 2:
						{
							global::System.Xml.XmlDocument xmlDocument;
							if (xmlDocument == null)
							{
								num = 37;
								continue;
							}
							string empty = string.Empty;
							text = "*";
							num = 46;
							continue;
						}
						case 3:
							if (A_0.Length != 0)
							{
								num = 5;
								continue;
							}
							goto IL_CA5;
						case 4:
						{
							global::System.IO.FileInfo fileInfo;
							if (fileInfo.Extension.Equals(".pak"))
							{
								num = 27;
								continue;
							}
							goto IL_18CA;
						}
						case 5:
							goto IL_EB2;
						case 6:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_EE4;
							default:
								if (false)
								{
								}
								goto IL_E0B;
							}
							break;
						case 7:
							num = 3;
							continue;
						case 8:
							goto IL_E58;
						case 9:
							num = 47;
							continue;
						case 10:
							num = 31;
							continue;
						case 11:
						{
							if (A_4.Length == 0)
							{
								num = 20;
								continue;
							}
							this.e = A_4;
							global::System.IO.DirectoryInfo directoryInfo = new global::System.IO.DirectoryInfo(A_4);
							A_6 = new global::System.Collections.ArrayList();
							global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
							num = 1;
							continue;
						}
						case 12:
							if (A_1.Length != 0)
							{
								num = 8;
								continue;
							}
							goto IL_CA5;
						case 13:
							goto IL_C84;
						case 14:
							try
							{
								string empty;
								global::System.IO.StringReader stringReader = new global::System.IO.StringReader(empty);
								global::System.Xml.XmlTextReader xmlTextReader2;
								global::System.Xml.XmlTextReader xmlTextReader = xmlTextReader2 = new global::System.Xml.XmlTextReader(stringReader);
								try
								{
									for (;;)
									{
										stringReader = null;
										num = 63;
										for (;;)
										{
											string text2;
											string text3;
											bool flag;
											string text4;
											string value;
											string value2;
											string value3;
											bool flag4;
											bool flag5;
											switch (num)
											{
											case 0:
												goto IL_10C6;
											case 1:
											{
												string name = xmlTextReader.Name;
												num = 26;
												continue;
											}
											case 2:
												goto IL_10C6;
											case 3:
												goto IL_10C6;
											case 4:
											{
												double num2;
												double num3;
												if (num2 <= num3)
												{
													num = 42;
													continue;
												}
												goto IL_10C6;
											}
											case 5:
												if (xmlTextReader.NodeType.Equals(global::System.Xml.XmlNodeType.EndElement))
												{
													num = 1;
													continue;
												}
												goto IL_10C6;
											case 6:
											{
												double num2;
												double num4;
												if (num2 >= num4)
												{
													num = 55;
													continue;
												}
												goto IL_10C6;
											}
											case 7:
												if (text2.Equals(A_1.Substring(0, 9)))
												{
													num = 53;
													continue;
												}
												goto IL_10C6;
											case 8:
												num = 41;
												continue;
											case 9:
												if (A_2 == null)
												{
													num = 29;
													continue;
												}
												goto IL_17F3;
											case 10:
												num = 34;
												continue;
											case 11:
												num = 38;
												continue;
											case 12:
												if (xmlTextReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
												{
													num = 10;
													continue;
												}
												num = 5;
												continue;
											case 13:
												goto IL_17F3;
											case 14:
												goto IL_10C6;
											case 15:
												goto IL_11EF;
											case 16:
												num = 43;
												continue;
											case 17:
												if (text2.Length == 9)
												{
													num = 49;
													continue;
												}
												goto IL_10C6;
											case 18:
												num = 23;
												continue;
											case 19:
												num = 9;
												continue;
											case 20:
												goto IL_1227;
											case 21:
												if (A_1.Length == 10)
												{
													num = 48;
													continue;
												}
												goto IL_10C6;
											case 22:
												num = 35;
												continue;
											case 23:
												if (text3.Equals(A_2))
												{
													num = 20;
													continue;
												}
												goto IL_10C6;
											case 24:
												goto IL_10C6;
											case 25:
												goto IL_17FF;
											case 26:
												goto IL_10C6;
											case 27:
												goto IL_13A5;
											case 28:
											{
												int num5;
												int num6;
												if (num5 >= num6)
												{
													num = 52;
													continue;
												}
												goto IL_10C6;
											}
											case 29:
												goto IL_12CD;
											case 30:
												num = 36;
												continue;
											case 31:
												goto IL_10C6;
											case 32:
												goto IL_10C6;
											case 33:
											{
												if (A_3 == null)
												{
													num = 40;
													continue;
												}
												int num5 = int.Parse(A_3, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
												int num6 = int.Parse(xmlTextReader.Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
												num = 28;
												continue;
											}
											case 34:
											{
												string name2;
												if ((name2 = xmlTextReader.Name) != null)
												{
													num = 70;
													continue;
												}
												goto IL_10C6;
											}
											case 35:
												if (A_1 == null)
												{
													num = 37;
													continue;
												}
												goto IL_17F3;
											case 36:
												if (!flag)
												{
													num = 19;
													continue;
												}
												goto IL_12CD;
											case 37:
												goto IL_149F;
											case 38:
												if (text4.Equals(A_0))
												{
													num = 15;
													continue;
												}
												goto IL_10C6;
											case 39:
												if (global::f.b == null)
												{
													num = 73;
													continue;
												}
												goto IL_1661;
											case 40:
											{
												bool flag2 = true;
												num = 3;
												continue;
											}
											case 41:
											{
												int num7;
												switch (num7)
												{
												case 0:
												{
													value = xmlTextReader.GetAttribute("TEMPLATEVERSION");
													double num2 = double.Parse(value, global::System.Globalization.CultureInfo.InvariantCulture);
													double num3 = 8.0;
													double num4 = 8.0;
													num = 6;
													continue;
												}
												case 1:
													value2 = xmlTextReader.GetAttribute("VERSION");
													num = 14;
													continue;
												case 2:
													value3 = xmlTextReader.GetAttribute("VERSION");
													num = 2;
													continue;
												case 3:
													xmlTextReader.Read();
													text2 = xmlTextReader.Value.Trim();
													num = 45;
													continue;
												case 4:
													xmlTextReader.Read();
													text4 = xmlTextReader.Value;
													num = 69;
													continue;
												case 5:
													xmlTextReader.Read();
													text3 = xmlTextReader.Value;
													num = 71;
													continue;
												case 6:
													xmlTextReader.Read();
													num = 33;
													continue;
												default:
													num = 50;
													continue;
												}
												break;
											}
											case 42:
											{
												bool flag3 = true;
												num = 0;
												continue;
											}
											case 43:
												if (A_0 == null)
												{
													num = 27;
													continue;
												}
												goto IL_17F3;
											case 44:
												goto IL_10C6;
											case 45:
												if (A_1 != null)
												{
													num = 64;
													continue;
												}
												goto IL_13C9;
											case 46:
												goto IL_1079;
											case 47:
												goto IL_10C6;
											case 48:
												num = 7;
												continue;
											case 49:
												num = 21;
												continue;
											case 50:
												num = 47;
												continue;
											case 51:
												goto IL_1661;
											case 52:
											{
												bool flag2 = true;
												num = 24;
												continue;
											}
											case 53:
												flag4 = true;
												num = 31;
												continue;
											case 54:
												num = 12;
												continue;
											case 55:
												num = 4;
												continue;
											case 56:
												if (!flag4)
												{
													num = 22;
													continue;
												}
												goto IL_149F;
											case 57:
												if (!xmlTextReader.Read())
												{
													num = 68;
													continue;
												}
												num = 74;
												continue;
											case 58:
												num = 66;
												continue;
											case 59:
												if (!flag5)
												{
													num = 16;
													continue;
												}
												goto IL_13A5;
											case 60:
												goto IL_10C6;
											case 61:
												goto IL_13C9;
											case 62:
											{
												string name2;
												int num7;
												if (global::f.b.TryGetValue(name2, out num7))
												{
													num = 8;
													continue;
												}
												goto IL_10C6;
											}
											case 63:
											{
												if (xmlTextReader == null)
												{
													num = 46;
													continue;
												}
												value2 = string.Empty;
												value3 = string.Empty;
												value = string.Empty;
												text3 = string.Empty;
												text2 = string.Empty;
												text4 = string.Empty;
												flag5 = false;
												flag = false;
												bool flag2 = false;
												bool flag3 = false;
												flag4 = false;
												num = 67;
												continue;
											}
											case 64:
												num = 65;
												continue;
											case 65:
												if (text2.Equals(A_1))
												{
													num = 61;
													continue;
												}
												num = 17;
												continue;
											case 66:
											{
												bool flag2;
												if (flag2)
												{
													num = 30;
													continue;
												}
												goto IL_17F3;
											}
											case 67:
												goto IL_10C6;
											case 68:
												num = 72;
												continue;
											case 69:
												if (A_0 != null)
												{
													num = 11;
													continue;
												}
												goto IL_11EF;
											case 70:
												num = 39;
												continue;
											case 71:
												if (A_2 != null)
												{
													num = 18;
													continue;
												}
												goto IL_1227;
											case 72:
											{
												bool flag3;
												if (flag3)
												{
													num = 58;
													continue;
												}
												goto IL_17F3;
											}
											case 73:
												global::f.b = new global::System.Collections.Generic.Dictionary<string, int>(7)
												{
													{
														"FLASH_PACK",
														0
													},
													{
														"FIRMWARE",
														1
													},
													{
														"CODEPLUG",
														2
													},
													{
														"TANAPA",
														3
													},
													{
														"MODEL",
														4
													},
													{
														"REGION",
														5
													},
													{
														"CPS_BUILD",
														6
													}
												};
												num = 51;
												continue;
											case 74:
												if (xmlTextReader.Name.Length != 0)
												{
													num = 54;
													continue;
												}
												goto IL_10C6;
											}
											break;
											IL_10C6:
											num = 57;
											continue;
											IL_11EF:
											flag5 = true;
											num = 32;
											continue;
											IL_1227:
											flag = true;
											num = 60;
											continue;
											IL_12CD:
											num = 59;
											continue;
											IL_13A5:
											num = 56;
											continue;
											IL_13C9:
											flag4 = true;
											num = 44;
											continue;
											IL_149F:
											A_6.Add(value2);
											A_6.Add(value3);
											A_6.Add(value);
											string text5;
											A_6.Add(text5);
											A_6.Add(text3);
											A_6.Add(text2);
											A_6.Add(text4);
											num = 13;
											continue;
											IL_1661:
											num = 62;
											continue;
											IL_17F3:
											num = 25;
										}
									}
									IL_1079:
									global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
									throw ex;
									IL_17FF:;
								}
								finally
								{
									num = 2;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_183E;
										case 1:
											((global::System.IDisposable)xmlTextReader2).Dispose();
											num = 0;
											continue;
										}
										if (xmlTextReader2 == null)
										{
											break;
										}
										num = 1;
									}
									IL_183E:;
								}
								goto IL_18CA;
							}
							finally
							{
								num = 1;
								for (;;)
								{
									global::System.IO.StringReader stringReader;
									switch (num)
									{
									case 0:
										goto IL_1883;
									case 2:
										stringReader.Close();
										num = 0;
										continue;
									}
									if (stringReader == null)
									{
										break;
									}
									num = 2;
								}
								IL_1883:;
							}
							goto IL_1886;
						case 15:
							num = 43;
							continue;
						case 16:
							goto IL_E0B;
						case 17:
							if (global::constants.StringUtility.ValidateExtension(text6, new string[]
							{
								text7
							}))
							{
								num = 40;
								continue;
							}
							goto IL_D05;
						case 18:
							text += ".pak";
							num = 34;
							continue;
						case 19:
							goto IL_1886;
						case 20:
							goto IL_E06;
						case 21:
							text7 = ".mig";
							num = 36;
							continue;
						case 22:
						{
							global::System.IO.FileInfo[] files;
							if (num8 >= files.Length)
							{
								num = 44;
								continue;
							}
							global::System.IO.FileInfo fileInfo = files[num8];
							num = 4;
							continue;
						}
						case 23:
							goto IL_B96;
						case 25:
							num = 2;
							continue;
						case 26:
							goto IL_191A;
						case 27:
						{
							global::System.IO.FileInfo fileInfo;
							string text5 = A_4 + fileInfo.Name;
							string empty;
							this.a(text5, ref empty);
							global::System.IO.StringReader stringReader = null;
							num = 14;
							continue;
						}
						case 28:
							if (A_3 != null)
							{
								num = 9;
								continue;
							}
							goto IL_B96;
						case 29:
							num = 11;
							continue;
						case 30:
							if (num9 >= array.Length)
							{
								num = 33;
								continue;
							}
							goto IL_B64;
						case 31:
							if (A_2.Length != 0)
							{
								num = 13;
								continue;
							}
							goto IL_CA5;
						case 32:
							if (A_2 != null)
							{
								num = 10;
								continue;
							}
							goto IL_C84;
						case 33:
						{
							global::System.IO.DirectoryInfo directoryInfo;
							global::System.IO.FileInfo[] files = directoryInfo.GetFiles("*.*");
							num8 = 0;
							num = 38;
							continue;
						}
						case 34:
							goto IL_1886;
						case 35:
							goto IL_BEB;
						case 36:
							goto IL_D6E;
						case 37:
							goto IL_D69;
						case 38:
							goto IL_BEB;
						case 39:
							goto IL_EE4;
						case 40:
						{
							global::System.IO.StringReader stringReader2 = null;
							num = 39;
							continue;
						}
						case 41:
							num = 12;
							continue;
						case 42:
							if (A_4 != null)
							{
								num = 29;
								continue;
							}
							goto IL_CA5;
						case 43:
							if (A_6 != null)
							{
								num = 25;
								continue;
							}
							goto IL_C13;
						case 44:
							global::System.GC.Collect();
							num = 26;
							continue;
						case 45:
							if (A_1 != null)
							{
								num = 41;
								continue;
							}
							goto IL_E58;
						case 46:
							if (!A_5)
							{
								num = 18;
								continue;
							}
							text += ".mig";
							num = 19;
							continue;
						case 47:
							if (A_3.Length != 0)
							{
								num = 23;
								continue;
							}
							goto IL_CA5;
						}
						if (A_0 != null)
						{
							num = 7;
							continue;
						}
						goto IL_EB2;
						IL_B64:
						text6 = array[num9];
						text7 = ".pak";
						num = 0;
						continue;
						IL_EE4:
						try
						{
							try
							{
								string empty;
								this.a(text6, ref empty);
								global::System.IO.StringReader stringReader2 = new global::System.IO.StringReader(empty);
								global::System.Xml.XmlTextReader xmlTextReader3;
								global::System.Xml.XmlTextReader xmlTextReader = xmlTextReader3 = new global::System.Xml.XmlTextReader(stringReader2);
								try
								{
									for (;;)
									{
										stringReader2 = null;
										num = 0;
										for (;;)
										{
											string value4;
											string value5;
											string value6;
											string text8;
											string text9;
											string text10;
											bool flag6;
											bool flag7;
											bool flag10;
											switch (num)
											{
											case 0:
											{
												if (xmlTextReader == null)
												{
													num = 8;
													continue;
												}
												value4 = string.Empty;
												value5 = string.Empty;
												value6 = string.Empty;
												text8 = string.Empty;
												text9 = string.Empty;
												text10 = string.Empty;
												flag6 = false;
												flag7 = false;
												bool flag8 = false;
												bool flag9 = false;
												flag10 = false;
												num = 69;
												continue;
											}
											case 1:
												num = 24;
												continue;
											case 2:
												num = 45;
												continue;
											case 3:
												goto IL_AC9;
											case 4:
												goto IL_822;
											case 5:
												if (global::f.a == null)
												{
													num = 6;
													continue;
												}
												goto IL_2D7;
											case 6:
												global::f.a = new global::System.Collections.Generic.Dictionary<string, int>(7)
												{
													{
														"FLASH_PACK",
														0
													},
													{
														"FIRMWARE",
														1
													},
													{
														"CODEPLUG",
														2
													},
													{
														"TANAPA",
														3
													},
													{
														"MODEL",
														4
													},
													{
														"REGION",
														5
													},
													{
														"CPS_BUILD",
														6
													}
												};
												num = 38;
												continue;
											case 7:
												num = 76;
												continue;
											case 8:
												goto IL_2D2;
											case 9:
												goto IL_822;
											case 10:
												num = 22;
												continue;
											case 11:
											{
												double num10;
												double num11;
												if (num10 <= num11)
												{
													num = 67;
													continue;
												}
												goto IL_822;
											}
											case 12:
												if (text9.Length == 9)
												{
													num = 35;
													continue;
												}
												goto IL_A0E;
											case 13:
												if (A_0 != null)
												{
													num = 10;
													continue;
												}
												goto IL_639;
											case 14:
												goto IL_822;
											case 15:
												if (xmlTextReader.Name.Length != 0)
												{
													num = 55;
													continue;
												}
												goto IL_822;
											case 16:
												goto IL_9BE;
											case 17:
												goto IL_AD5;
											case 18:
												goto IL_6AE;
											case 19:
												num = 5;
												continue;
											case 20:
											{
												bool flag8 = true;
												num = 9;
												continue;
											}
											case 21:
												goto IL_822;
											case 22:
												if (text10.Equals(A_0))
												{
													num = 78;
													continue;
												}
												goto IL_822;
											case 23:
												if (A_1.Length == 10)
												{
													num = 37;
													continue;
												}
												goto IL_A0E;
											case 24:
												if (A_2 == null)
												{
													num = 16;
													continue;
												}
												goto IL_AC9;
											case 25:
												if (!flag6)
												{
													num = 59;
													continue;
												}
												goto IL_8F8;
											case 26:
												goto IL_5FB;
											case 27:
												goto IL_822;
											case 28:
												if (A_1 == null)
												{
													num = 58;
													continue;
												}
												goto IL_AC9;
											case 29:
											{
												string text11;
												string text12;
												if (text11 == text12)
												{
													num = 50;
													continue;
												}
												goto IL_822;
											}
											case 30:
												if (text9.Equals(A_1.Substring(0, 9)))
												{
													num = 33;
													continue;
												}
												goto IL_A0E;
											case 31:
												goto IL_A0E;
											case 32:
											{
												string text11 = A_1.Substring(0, A_1.Length - 1);
												string text12 = text9.Substring(0, A_1.Length - 1);
												num = 29;
												continue;
											}
											case 33:
												flag10 = true;
												num = 31;
												continue;
											case 34:
												if (xmlTextReader.NodeType.Equals(global::System.Xml.XmlNodeType.EndElement))
												{
													num = 53;
													continue;
												}
												goto IL_822;
											case 35:
												num = 23;
												continue;
											case 36:
												num = 27;
												continue;
											case 37:
												num = 30;
												continue;
											case 38:
												goto IL_2D7;
											case 39:
												if (!flag10)
												{
													num = 71;
													continue;
												}
												goto IL_A6E;
											case 40:
												goto IL_822;
											case 41:
												num = 73;
												continue;
											case 42:
												if (!flag7)
												{
													num = 1;
													continue;
												}
												goto IL_9BE;
											case 43:
												goto IL_822;
											case 44:
											{
												int num12;
												int num13;
												if (num12 >= num13)
												{
													num = 20;
													continue;
												}
												goto IL_822;
											}
											case 45:
											{
												string name2;
												if ((name2 = xmlTextReader.Name) != null)
												{
													num = 19;
													continue;
												}
												goto IL_822;
											}
											case 46:
												num = 47;
												continue;
											case 47:
											{
												int num7;
												switch (num7)
												{
												case 0:
												{
													value6 = xmlTextReader.GetAttribute("TEMPLATEVERSION");
													double num10 = double.Parse(value6, global::System.Globalization.CultureInfo.InvariantCulture);
													double num11 = 8.0;
													double num14 = 8.0;
													num = 51;
													continue;
												}
												case 1:
													value4 = xmlTextReader.GetAttribute("VERSION");
													num = 60;
													continue;
												case 2:
													value5 = xmlTextReader.GetAttribute("VERSION");
													num = 63;
													continue;
												case 3:
													xmlTextReader.Read();
													text9 = xmlTextReader.Value.Trim();
													num = 54;
													continue;
												case 4:
													xmlTextReader.Read();
													text10 = xmlTextReader.Value;
													num = 13;
													continue;
												case 5:
													xmlTextReader.Read();
													text8 = xmlTextReader.Value;
													num = 65;
													continue;
												case 6:
													xmlTextReader.Read();
													num = 72;
													continue;
												default:
													num = 36;
													continue;
												}
												break;
											}
											case 48:
												if (!xmlTextReader.Read())
												{
													num = 70;
													continue;
												}
												num = 15;
												continue;
											case 49:
												num = 74;
												continue;
											case 50:
												flag10 = true;
												num = 75;
												continue;
											case 51:
											{
												double num10;
												double num14;
												if (num10 >= num14)
												{
													num = 66;
													continue;
												}
												goto IL_822;
											}
											case 52:
											{
												bool flag8 = true;
												num = 43;
												continue;
											}
											case 53:
											{
												string name3 = xmlTextReader.Name;
												num = 40;
												continue;
											}
											case 54:
												if (A_1 != null)
												{
													num = 41;
													continue;
												}
												goto IL_5FB;
											case 55:
												num = 68;
												continue;
											case 56:
												goto IL_8F8;
											case 57:
											{
												string name2;
												int num7;
												if (global::f.a.TryGetValue(name2, out num7))
												{
													num = 46;
													continue;
												}
												goto IL_822;
											}
											case 58:
												goto IL_A6E;
											case 59:
												num = 62;
												continue;
											case 60:
												goto IL_822;
											case 61:
												num = 42;
												continue;
											case 62:
												if (A_0 == null)
												{
													num = 56;
													continue;
												}
												goto IL_AC9;
											case 63:
												goto IL_822;
											case 64:
												if (A_5)
												{
													num = 32;
													continue;
												}
												goto IL_822;
											case 65:
												if (A_2 != null)
												{
													num = 49;
													continue;
												}
												goto IL_6AE;
											case 66:
												num = 11;
												continue;
											case 67:
											{
												bool flag9 = true;
												num = 77;
												continue;
											}
											case 68:
												if (xmlTextReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
												{
													num = 2;
													continue;
												}
												num = 34;
												continue;
											case 69:
												goto IL_822;
											case 70:
												num = 79;
												continue;
											case 71:
												num = 28;
												continue;
											case 72:
											{
												if (A_3 == null)
												{
													num = 52;
													continue;
												}
												int num12 = int.Parse(A_3, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
												int num13 = int.Parse(xmlTextReader.Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
												num = 44;
												continue;
											}
											case 73:
												if (text9.Equals(A_1))
												{
													num = 26;
													continue;
												}
												num = 12;
												continue;
											case 74:
												if (text8.Equals(A_2))
												{
													num = 18;
													continue;
												}
												goto IL_822;
											case 75:
												goto IL_822;
											case 76:
											{
												bool flag8;
												if (flag8)
												{
													num = 61;
													continue;
												}
												goto IL_AC9;
											}
											case 77:
												goto IL_822;
											case 78:
												goto IL_639;
											case 79:
											{
												bool flag9;
												if (flag9)
												{
													num = 7;
													continue;
												}
												goto IL_AC9;
											}
											}
											break;
											IL_2D7:
											num = 57;
											continue;
											IL_5FB:
											flag10 = true;
											num = 14;
											continue;
											IL_639:
											flag6 = true;
											num = 21;
											continue;
											IL_6AE:
											flag7 = true;
											num = 4;
											continue;
											IL_822:
											num = 48;
											continue;
											IL_8F8:
											num = 39;
											continue;
											IL_9BE:
											num = 25;
											continue;
											IL_A0E:
											num = 64;
											continue;
											IL_A6E:
											A_6.Add(value4);
											A_6.Add(value5);
											A_6.Add(value6);
											A_6.Add(text6);
											A_6.Add(text8);
											A_6.Add(text9);
											A_6.Add(text10);
											num = 3;
											continue;
											IL_AC9:
											num = 17;
										}
									}
									IL_2D2:
									global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
									throw ex2;
									IL_AD5:;
								}
								finally
								{
									num = 2;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_B14;
										case 1:
											((global::System.IDisposable)xmlTextReader3).Dispose();
											num = 0;
											continue;
										}
										if (xmlTextReader3 == null)
										{
											break;
										}
										num = 1;
									}
									IL_B14:;
								}
							}
							catch
							{
							}
							goto IL_D05;
						}
						finally
						{
							num = 1;
							for (;;)
							{
								global::System.IO.StringReader stringReader2;
								switch (num)
								{
								case 0:
									stringReader2.Close();
									num = 2;
									continue;
								case 2:
									goto IL_B61;
								}
								if (stringReader2 == null)
								{
									break;
								}
								num = 0;
							}
							IL_B61:;
						}
						goto IL_B64;
						IL_B96:
						num = 42;
						continue;
						IL_BEB:
						num = 22;
						continue;
						IL_C84:
						num = 28;
						continue;
						IL_D05:
						num9++;
						num = 16;
						continue;
						IL_D6E:
						num = 17;
						continue;
						IL_E0B:
						num = 30;
						continue;
						IL_E58:
						num = 32;
						continue;
						IL_EB2:
						num = 45;
						continue;
						IL_1886:
						string[] files2 = global::System.IO.Directory.GetFiles(this.e, text, global::System.IO.SearchOption.AllDirectories);
						array = files2;
						num9 = 0;
						num = 6;
						continue;
						IL_18CA:
						num8++;
						num = 35;
					}
					IL_C13:
					global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex3;
					IL_CA5:
					global::custom_exception.CCustomException ex4 = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex4;
					IL_D69:
					goto IL_C13;
					IL_E06:
					goto IL_CA5;
					IL_191A:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Xml.XmlException)
			{
				global::custom_exception.CCustomException ex5 = new global::custom_exception.CCustomException(2932U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex5;
			}
			catch (global::System.Exception ex6)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex6))
				{
					if (true)
					{
					}
					ex6.Source = 2914U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex6.Source;
				}
				throw;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0001FFCC File Offset: 0x0001EFCC
		public void a(global::System.Collections.ArrayList A_0, global::System.Collections.ArrayList A_1, global::System.Collections.ArrayList A_2, string A_3, string A_4, string A_5, int A_6, ref global::System.Collections.ArrayList A_7)
		{
			switch (0)
			{
			default:
			{
				global::System.Xml.XmlReader xmlReader = null;
				try
				{
					int num = 21;
					for (;;)
					{
						string str;
						int num9;
						string[] array;
						switch (num)
						{
						case 0:
							goto IL_1BC4;
						case 1:
							goto IL_1BDC;
						case 2:
							num = 39;
							continue;
						case 3:
							if (A_0.Count != 0)
							{
								num = 31;
								continue;
							}
							goto IL_1CDF;
						case 4:
							num = 1;
							continue;
						case 5:
						{
							int num2;
							switch (num2)
							{
							case 1:
							case 2:
								str = ".pak";
								num = 22;
								continue;
							case 3:
								goto IL_1BDC;
							case 4:
								str = ".mig";
								num = 17;
								continue;
							default:
								num = 11;
								continue;
							}
							break;
						}
						case 6:
							goto IL_1DC4;
						case 7:
						{
							if (A_7 == null)
							{
								num = 8;
								continue;
							}
							string empty = string.Empty;
							str = string.Empty;
							bool flag = true;
							int num2 = A_6;
							num = 5;
							continue;
						}
						case 8:
							goto IL_1C2E;
						case 9:
							num = 26;
							continue;
						case 10:
							global::System.GC.Collect();
							num = 6;
							continue;
						case 11:
							num = 23;
							continue;
						case 12:
							try
							{
								try
								{
									string empty;
									string a_;
									this.a(a_, ref empty);
									global::System.IO.StringReader stringReader = new global::System.IO.StringReader(empty);
									try
									{
										for (;;)
										{
											xmlReader = new global::System.Xml.XmlTextReader(stringReader);
											string text = string.Empty;
											string text2 = string.Empty;
											string text3 = string.Empty;
											string text4 = string.Empty;
											string text5 = string.Empty;
											string text6 = string.Empty;
											string text7 = string.Empty;
											string text8 = string.Empty;
											string text9 = string.Empty;
											string text10 = string.Empty;
											string text11 = string.Empty;
											string text12 = string.Empty;
											string text13 = string.Empty;
											string text14 = string.Empty;
											string text15 = string.Empty;
											string text16 = string.Empty;
											string text17 = string.Empty;
											string text18 = string.Empty;
											string text19 = string.Empty;
											string item = string.Empty;
											string text20 = string.Empty;
											string text21 = string.Empty;
											string text22 = string.Empty;
											string item2 = string.Empty;
											bool flag2 = false;
											bool flag3 = false;
											bool flag4 = false;
											bool flag5 = false;
											bool flag6 = false;
											bool flag7 = false;
											bool flag8 = false;
											global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
											num = 28;
											for (;;)
											{
												int num6;
												bool flag9;
												bool flag10;
												switch (num)
												{
												case 0:
													num = 81;
													continue;
												case 1:
													num = 52;
													continue;
												case 2:
													num = 56;
													continue;
												case 3:
													if (A_6 == 8)
													{
														num = 0;
														continue;
													}
													goto IL_1A32;
												case 4:
													if (xmlReader.HasAttributes)
													{
														num = 14;
														continue;
													}
													goto IL_A27;
												case 5:
												{
													double num3;
													if (num3 >= 6.0)
													{
														num = 72;
														continue;
													}
													goto IL_1873;
												}
												case 6:
													goto IL_E70;
												case 7:
													if (flag5)
													{
														num = 180;
														continue;
													}
													goto IL_170D;
												case 8:
													if (A_1.Contains(text19))
													{
														num = 111;
														continue;
													}
													num = 25;
													continue;
												case 9:
													text13 = xmlReader.GetAttribute("TYPE");
													num = 158;
													continue;
												case 10:
													num = 187;
													continue;
												case 11:
													goto IL_627;
												case 12:
													goto IL_16E8;
												case 13:
													if (text5 != null)
													{
														num = 71;
														continue;
													}
													goto IL_AAA;
												case 14:
												{
													string value = xmlReader.GetAttribute("VERSION");
													arrayList.Add(value);
													num = 92;
													continue;
												}
												case 15:
													num = 100;
													continue;
												case 16:
													goto IL_FB3;
												case 17:
													goto IL_CCA;
												case 18:
												{
													string name;
													if (name == "FILE")
													{
														num = 139;
														continue;
													}
													goto IL_D62;
												}
												case 19:
													goto IL_13D4;
												case 20:
													num = 8;
													continue;
												case 21:
												{
													if (A_4 == null)
													{
														num = 127;
														continue;
													}
													int num4 = int.Parse(A_4, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
													int num5 = int.Parse(xmlReader.Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
													num = 68;
													continue;
												}
												case 22:
													num6 = 0;
													num = 17;
													continue;
												case 23:
													num = 89;
													continue;
												case 24:
													goto IL_1A3E;
												case 25:
													if (text19.Length == 9)
													{
														num = 22;
														continue;
													}
													goto IL_16E8;
												case 26:
													goto IL_13D4;
												case 27:
													flag9 = true;
													num = 156;
													continue;
												case 28:
													goto IL_13D4;
												case 29:
													num = 152;
													continue;
												case 30:
												{
													double num3 = double.Parse(text3, global::System.Globalization.CultureInfo.InvariantCulture);
													num = 5;
													continue;
												}
												case 31:
													num = 109;
													continue;
												case 32:
												{
													string name;
													if ((name = xmlReader.Name) != null)
													{
														num = 106;
														continue;
													}
													goto IL_F9B;
												}
												case 33:
													if (A_3 == null)
													{
														num = 75;
														continue;
													}
													goto IL_170D;
												case 34:
													if (text4 != null)
													{
														num = 141;
														continue;
													}
													goto IL_8D5;
												case 35:
													text7 = xmlReader.GetAttribute("VERSION");
													num = 19;
													continue;
												case 36:
													goto IL_13D4;
												case 37:
													goto IL_13D4;
												case 38:
													flag8 = true;
													num = 135;
													continue;
												case 39:
													if (A_0 == null)
													{
														num = 16;
														continue;
													}
													goto IL_170D;
												case 40:
												{
													string attribute = xmlReader.GetAttribute("APPLICABLE");
													num = 176;
													continue;
												}
												case 41:
													num = 179;
													continue;
												case 42:
													goto IL_D62;
												case 43:
													if (!flag3)
													{
														num = 57;
														continue;
													}
													goto IL_FB3;
												case 44:
													if (text18.Equals("All"))
													{
														num = 121;
														continue;
													}
													goto IL_13D4;
												case 45:
													num = 159;
													continue;
												case 46:
													if (xmlReader.HasAttributes)
													{
														num = 40;
														continue;
													}
													goto IL_F9B;
												case 47:
													if (xmlReader.HasAttributes)
													{
														num = 192;
														continue;
													}
													goto IL_A92;
												case 48:
													if (xmlReader.HasAttributes)
													{
														num = 66;
														continue;
													}
													goto IL_D62;
												case 49:
													if (!flag10)
													{
														num = 86;
														continue;
													}
													goto IL_5C4;
												case 50:
													goto IL_B50;
												case 51:
													goto IL_19AF;
												case 52:
													if (A_2 == null)
													{
														num = 160;
														continue;
													}
													goto IL_1A32;
												case 53:
													goto IL_1A32;
												case 54:
												{
													string name;
													if ((name = xmlReader.Name) != null)
													{
														num = 67;
														continue;
													}
													goto IL_A92;
												}
												case 55:
													if (xmlReader.HasAttributes)
													{
														num = 35;
														continue;
													}
													xmlReader.Read();
													num = 171;
													continue;
												case 56:
													if (flag6)
													{
														num = 193;
														continue;
													}
													goto IL_170D;
												case 57:
													num = 39;
													continue;
												case 58:
												{
													string name;
													if (name == "FILE")
													{
														num = 178;
														continue;
													}
													goto IL_A92;
												}
												case 59:
													if (A_3 != null)
													{
														num = 102;
														continue;
													}
													goto IL_BF0;
												case 60:
													if (xmlReader.Name.Equals("STRUCTURE_FILE"))
													{
														num = 123;
														continue;
													}
													num = 4;
													continue;
												case 61:
													goto IL_13D4;
												case 62:
												{
													string name;
													if (name == "FILE")
													{
														num = 90;
														continue;
													}
													goto IL_109C;
												}
												case 63:
													if (flag9)
													{
														num = 168;
														continue;
													}
													goto IL_13D4;
												case 64:
													num = 143;
													continue;
												case 65:
													text14 = xmlReader.GetAttribute("TYPE");
													num = 42;
													continue;
												case 66:
												{
													string attribute2 = xmlReader.GetAttribute("APPLICABLE");
													num = 154;
													continue;
												}
												case 67:
													num = 58;
													continue;
												case 68:
												{
													int num4;
													int num5;
													if (num4 >= num5)
													{
														num = 166;
														continue;
													}
													goto IL_13D4;
												}
												case 69:
													goto IL_109C;
												case 70:
													flag7 = true;
													num = 170;
													continue;
												case 71:
												{
													double num7 = double.Parse(text5, global::System.Globalization.CultureInfo.InvariantCulture);
													num = 76;
													continue;
												}
												case 72:
													flag10 = true;
													num = 91;
													continue;
												case 73:
													goto IL_13D4;
												case 74:
												{
													string name;
													if ((name = xmlReader.Name) != null)
													{
														num = 185;
														continue;
													}
													goto IL_109C;
												}
												case 75:
													goto IL_10B4;
												case 76:
												{
													double num7;
													if (num7 >= 8.0)
													{
														num = 120;
														continue;
													}
													goto IL_AAA;
												}
												case 77:
												{
													if (num6 >= A_1.Count)
													{
														num = 12;
														continue;
													}
													string text23 = A_1[num6].ToString();
													num = 130;
													continue;
												}
												case 78:
													if (xmlReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
													{
														num = 101;
														continue;
													}
													goto IL_109C;
												case 79:
												{
													string attribute3;
													if (!string.IsNullOrEmpty(attribute3))
													{
														num = 118;
														continue;
													}
													goto IL_A92;
												}
												case 80:
													if (!text18.Equals(A_3))
													{
														num = 191;
														continue;
													}
													goto IL_BF0;
												case 81:
													if (!flag8)
													{
														num = 1;
														continue;
													}
													goto IL_11CB;
												case 82:
													if (A_6 != 8)
													{
														num = 41;
														continue;
													}
													goto IL_170D;
												case 83:
													if (xmlReader.Name.Equals("DATA_IMAGE"))
													{
														num = 145;
														continue;
													}
													num = 164;
													continue;
												case 84:
													goto IL_CB6;
												case 85:
													goto IL_627;
												case 86:
													num = 63;
													continue;
												case 87:
													num = 33;
													continue;
												case 88:
													text15 = xmlReader.GetAttribute("BAND");
													num = 107;
													continue;
												case 89:
													if (A_6 == 8)
													{
														num = 84;
														continue;
													}
													goto IL_13D4;
												case 90:
													num = 162;
													continue;
												case 91:
													goto IL_1873;
												case 92:
													goto IL_A27;
												case 93:
													if (xmlReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
													{
														num = 122;
														continue;
													}
													goto IL_F9B;
												case 94:
													goto IL_E70;
												case 95:
												{
													double num8;
													if (num8 <= 1.0)
													{
														num = 27;
														continue;
													}
													goto IL_8D5;
												}
												case 96:
													goto IL_13D4;
												case 97:
													if (xmlReader.Name.Equals("CONTROL_HEAD"))
													{
														num = 174;
														continue;
													}
													num = 93;
													continue;
												case 98:
													goto IL_DE8;
												case 99:
													goto IL_13D4;
												case 100:
												{
													int num2;
													switch (num2)
													{
													case 0:
													{
														bool flag11 = false;
														text5 = xmlReader.GetAttribute("TEMPLATEVERSION");
														num = 13;
														continue;
													}
													case 1:
													case 2:
														text = xmlReader.GetAttribute("VERSION");
														text20 = xmlReader.GetAttribute("FWPRODUCTIONNAME");
														xmlReader.Read();
														num = 11;
														continue;
													case 3:
														item2 = xmlReader.GetAttribute("TYPE");
														text22 = xmlReader.GetAttribute("VERSION");
														num = 186;
														continue;
													case 4:
														text2 = xmlReader.GetAttribute("VERSION");
														num = 103;
														continue;
													case 5:
														xmlReader.Read();
														text9 = xmlReader.Value;
														num = 153;
														continue;
													case 6:
													case 7:
														text6 = xmlReader.GetAttribute("VERSION");
														num = 96;
														continue;
													case 8:
														text8 = xmlReader.GetAttribute("VERSION");
														num = 26;
														continue;
													case 9:
														xmlReader.Read();
														num = 124;
														continue;
													case 10:
														xmlReader.Read();
														text19 = xmlReader.Value.Trim();
														num = 195;
														continue;
													case 11:
														xmlReader.Read();
														item = xmlReader.Value;
														num = 196;
														continue;
													case 12:
														xmlReader.Read();
														text18 = xmlReader.Value;
														num = 59;
														continue;
													case 13:
														xmlReader.Read();
														text21 = xmlReader.Value;
														num = 61;
														continue;
													case 14:
														break;
													case 15:
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
															xmlReader.Read();
															string value = string.Empty;
															num = 149;
															continue;
														}
														}
														break;
													case 16:
														text10 = xmlReader.GetAttribute("VERSION");
														num = 194;
														continue;
													case 17:
														text11 = xmlReader.GetAttribute("VERSION");
														num = 137;
														continue;
													case 18:
														text12 = xmlReader.GetAttribute("VERSION");
														num = 73;
														continue;
													case 19:
														xmlReader.Read();
														num = 50;
														continue;
													case 20:
														xmlReader.Read();
														num = 6;
														continue;
													case 21:
														xmlReader.Read();
														num = 98;
														continue;
													case 22:
														flag2 = bool.Parse(xmlReader.GetAttribute("APPLICABLE"));
														num = 155;
														continue;
													default:
														num = 182;
														continue;
													}
													xmlReader.Read();
													num = 21;
													continue;
												}
												case 101:
													num = 74;
													continue;
												case 102:
													num = 80;
													continue;
												case 103:
													goto IL_13D4;
												case 104:
													goto IL_13D4;
												case 105:
													goto IL_13D4;
												case 106:
													num = 183;
													continue;
												case 107:
													goto IL_A92;
												case 108:
													goto IL_13D4;
												case 109:
												{
													string name;
													if ((name = xmlReader.Name) != null)
													{
														num = 29;
														continue;
													}
													goto IL_13D4;
												}
												case 110:
													if (xmlReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
													{
														num = 161;
														continue;
													}
													goto IL_A92;
												case 111:
													goto IL_950;
												case 112:
													num = 126;
													continue;
												case 113:
													goto IL_CCA;
												case 114:
													if (!xmlReader.Read())
													{
														num = 2;
														continue;
													}
													num = 131;
													continue;
												case 115:
													goto IL_170D;
												case 116:
													num = 18;
													continue;
												case 117:
												{
													int num2;
													string name;
													if (global::f.c.TryGetValue(name, out num2))
													{
														num = 15;
														continue;
													}
													goto IL_13D4;
												}
												case 118:
													num = 132;
													continue;
												case 119:
													if (xmlReader.Name.Equals("PREUPGRADE"))
													{
														num = 181;
														continue;
													}
													num = 78;
													continue;
												case 120:
												{
													bool flag11 = true;
													num = 177;
													continue;
												}
												case 121:
													goto IL_BF0;
												case 122:
													num = 32;
													continue;
												case 123:
													num = 108;
													continue;
												case 124:
													goto IL_581;
												case 125:
													goto IL_13D4;
												case 126:
													if (A_0.Contains(item))
													{
														num = 189;
														continue;
													}
													goto IL_13D4;
												case 127:
													flag5 = true;
													num = 37;
													continue;
												case 128:
													goto IL_DE8;
												case 129:
													if (xmlReader.NodeType.Equals(global::System.Xml.XmlNodeType.EndElement))
													{
														num = 148;
														continue;
													}
													goto IL_13D4;
												case 130:
												{
													string text23;
													if (text19.Equals(text23.Substring(0, 9)))
													{
														num = 70;
														continue;
													}
													goto IL_964;
												}
												case 131:
													if (xmlReader.Name.Length != 0)
													{
														num = 140;
														continue;
													}
													goto IL_13D4;
												case 132:
												{
													string attribute3;
													if (attribute3.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture).Equals("TRUE"))
													{
														num = 88;
														continue;
													}
													goto IL_A92;
												}
												case 133:
													if (xmlReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
													{
														num = 31;
														continue;
													}
													num = 129;
													continue;
												case 134:
													goto IL_B50;
												case 135:
													goto IL_13D4;
												case 136:
													num = 46;
													continue;
												case 137:
													goto IL_13D4;
												case 138:
												{
													bool flag11;
													if (flag11)
													{
														num = 147;
														continue;
													}
													goto IL_13D4;
												}
												case 139:
													num = 48;
													continue;
												case 140:
													num = 133;
													continue;
												case 141:
												{
													double num8 = double.Parse(text4, global::System.Globalization.CultureInfo.InvariantCulture);
													num = 95;
													continue;
												}
												case 142:
													if (xmlReader.Name.Equals("RAMDLOADER"))
													{
														num = 10;
														continue;
													}
													num = 55;
													continue;
												case 143:
												{
													string name;
													if ((name = xmlReader.Name) != null)
													{
														num = 116;
														continue;
													}
													goto IL_D62;
												}
												case 144:
													goto IL_13D4;
												case 145:
													num = 165;
													continue;
												case 146:
													if (xmlReader.Name.Equals("FIRMWARE"))
													{
														num = 45;
														continue;
													}
													num = 110;
													continue;
												case 147:
													num = 49;
													continue;
												case 148:
												{
													string name2 = xmlReader.Name;
													num = 163;
													continue;
												}
												case 149:
													goto IL_833;
												case 150:
													goto IL_833;
												case 151:
													num = 190;
													continue;
												case 152:
													if (global::f.c == null)
													{
														num = 175;
														continue;
													}
													goto IL_19AF;
												case 153:
													goto IL_13D4;
												case 154:
												{
													string attribute2;
													if (attribute2.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture).Equals("TRUE"))
													{
														num = 65;
														continue;
													}
													goto IL_D62;
												}
												case 155:
													goto IL_13D4;
												case 156:
													goto IL_8D5;
												case 157:
													goto IL_13D4;
												case 158:
													goto IL_F9B;
												case 159:
													goto IL_13D4;
												case 160:
													goto IL_11CB;
												case 161:
													num = 54;
													continue;
												case 162:
													if (xmlReader.HasAttributes)
													{
														num = 188;
														continue;
													}
													goto IL_109C;
												case 163:
													goto IL_13D4;
												case 164:
													if (xmlReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
													{
														num = 64;
														continue;
													}
													goto IL_D62;
												case 165:
													goto IL_13D4;
												case 166:
													flag5 = true;
													num = 144;
													continue;
												case 167:
													goto IL_13D4;
												case 168:
													goto IL_5C4;
												case 169:
													if (!flag7)
													{
														num = 151;
														continue;
													}
													goto IL_11CB;
												case 170:
													goto IL_964;
												case 171:
													goto IL_581;
												case 172:
													if (text3 != null)
													{
														num = 30;
														continue;
													}
													goto IL_1873;
												case 173:
													goto IL_13D4;
												case 174:
													num = 167;
													continue;
												case 175:
													global::f.c = new global::System.Collections.Generic.Dictionary<string, int>(23)
													{
														{
															"FLASH_PACK",
															0
														},
														{
															"APP",
															1
														},
														{
															"FIRMWARE",
															2
														},
														{
															"FPGA_IMAGE",
															3
														},
														{
															"CODEPLUG",
															4
														},
														{
															"LAST_IMPORTANT_BOOTLOADER",
															5
														},
														{
															"BOOTLOADER",
															6
														},
														{
															"L2_BOOTLOADER",
															7
														},
														{
															"PSDT",
															8
														},
														{
															"RAMDLOADER",
															9
														},
														{
															"TANAPA",
															10
														},
														{
															"MODEL",
															11
														},
														{
															"REGION",
															12
														},
														{
															"UUID",
															13
														},
														{
															"CPS_BUILD",
															14
														},
														{
															"STRUCTURE_FILE",
															15
														},
														{
															"KERNEL",
															16
														},
														{
															"L3_BOOTLOADER",
															17
														},
														{
															"CONFIGURATION",
															18
														},
														{
															"PREUPGRADE",
															19
														},
														{
															"CONTROL_HEAD",
															20
														},
														{
															"DATA_IMAGE",
															21
														},
														{
															"PSMARKER",
															22
														}
													};
													num = 51;
													continue;
												case 176:
												{
													string attribute;
													if (attribute.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture).Equals("TRUE"))
													{
														num = 9;
														continue;
													}
													goto IL_F9B;
												}
												case 177:
													goto IL_AAA;
												case 178:
													num = 47;
													continue;
												case 179:
													if (!flag4)
													{
														num = 87;
														continue;
													}
													goto IL_10B4;
												case 180:
													num = 43;
													continue;
												case 181:
													num = 105;
													continue;
												case 182:
													num = 99;
													continue;
												case 183:
												{
													string name;
													if (name == "FILE")
													{
														num = 136;
														continue;
													}
													goto IL_F9B;
												}
												case 184:
													if (A_6 != 4)
													{
														num = 23;
														continue;
													}
													goto IL_CB6;
												case 185:
													num = 62;
													continue;
												case 186:
													if (A_2.Contains(item2))
													{
														num = 38;
														continue;
													}
													goto IL_13D4;
												case 187:
													goto IL_13D4;
												case 188:
													text16 = xmlReader.GetAttribute("PARTITION");
													text17 = xmlReader.GetAttribute("VERSION");
													num = 69;
													continue;
												case 189:
													goto IL_D1C;
												case 190:
													if (A_1 != null)
													{
														num = 115;
														continue;
													}
													goto IL_11CB;
												case 191:
													num = 44;
													continue;
												case 192:
												{
													string attribute3 = xmlReader.GetAttribute("APPLICABLE");
													num = 79;
													continue;
												}
												case 193:
													num = 7;
													continue;
												case 194:
													goto IL_13D4;
												case 195:
													if (A_1 != null)
													{
														num = 20;
														continue;
													}
													goto IL_950;
												case 196:
													if (A_0 != null)
													{
														num = 112;
														continue;
													}
													goto IL_D1C;
												}
												break;
												IL_581:
												num = 142;
												continue;
												IL_5C4:
												flag6 = true;
												num = 173;
												continue;
												IL_627:
												num = 146;
												continue;
												IL_833:
												num = 60;
												continue;
												IL_8D5:
												num = 138;
												continue;
												IL_950:
												flag7 = true;
												num = 36;
												continue;
												IL_964:
												num6++;
												num = 113;
												continue;
												IL_A27:
												xmlReader.Read();
												num = 150;
												continue;
												IL_A92:
												xmlReader.Read();
												num = 85;
												continue;
												IL_AAA:
												flag10 = false;
												text3 = xmlReader.GetAttribute("PACKVERSION");
												num = 172;
												continue;
												IL_B50:
												num = 119;
												continue;
												IL_BF0:
												flag4 = true;
												num = 125;
												continue;
												IL_CB6:
												flag7 = true;
												num = 157;
												continue;
												IL_CCA:
												num = 77;
												continue;
												IL_D1C:
												flag3 = true;
												num = 104;
												continue;
												IL_D62:
												xmlReader.Read();
												num = 128;
												continue;
												IL_DE8:
												num = 83;
												continue;
												IL_E70:
												num = 97;
												continue;
												IL_F9B:
												xmlReader.Read();
												num = 94;
												continue;
												IL_FB3:
												num = 82;
												continue;
												IL_109C:
												xmlReader.Read();
												num = 134;
												continue;
												IL_10B4:
												num = 169;
												continue;
												IL_11CB:
												global::DeviceUpdate.e e = default(global::DeviceUpdate.e);
												e.a = text;
												e.b = text2;
												e.c = item2;
												e.d = text22;
												e.e = text3;
												e.f = text4;
												e.g = a_;
												e.h = text18;
												e.i = text19;
												e.j = item;
												e.k = arrayList;
												e.l = text6;
												e.m = text7;
												e.n = text8;
												e.p = text21;
												e.o = text20;
												e.q = text9;
												e.t = text12;
												e.y = text16;
												e.z = text17;
												e.s = text11;
												e.v = text8;
												e.u = text10;
												e.r = text10;
												e.w = text13;
												e.aa = text15;
												e.x = text14;
												e.ab = flag2;
												A_7.Add(e);
												num = 53;
												continue;
												IL_13D4:
												num = 114;
												continue;
												IL_16E8:
												num = 184;
												continue;
												IL_170D:
												num = 3;
												continue;
												IL_1873:
												flag9 = false;
												text4 = xmlReader.GetAttribute("PACKVERSION");
												num = 34;
												continue;
												IL_19AF:
												num = 117;
												continue;
												IL_1A32:
												num = 24;
											}
										}
										IL_1A3E:;
									}
									finally
									{
										num = 0;
										for (;;)
										{
											switch (num)
											{
											case 1:
												goto IL_1A7D;
											case 2:
												((global::System.IDisposable)stringReader).Dispose();
												num = 1;
												continue;
											}
											if (stringReader == null)
											{
												break;
											}
											num = 2;
										}
										IL_1A7D:;
									}
								}
								catch
								{
								}
								goto IL_1D9C;
							}
							finally
							{
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										xmlReader.Close();
										num = 2;
										continue;
									case 2:
										goto IL_1AC8;
									}
									if (xmlReader == null)
									{
										break;
									}
									num = 0;
								}
								IL_1AC8:;
							}
							goto IL_1ACB;
						case 13:
							goto IL_1ACB;
						case 14:
							if (A_1 != null)
							{
								num = 2;
								continue;
							}
							goto IL_E8;
						case 15:
							goto IL_1C6E;
						case 16:
							num = 3;
							continue;
						case 17:
							goto IL_1BDC;
						case 18:
							goto IL_1BDC;
						case 19:
							if (A_3 != null)
							{
								num = 25;
								continue;
							}
							goto IL_1B56;
						case 20:
							goto IL_1ACB;
						case 22:
							goto IL_1BDC;
						case 23:
						{
							int num2;
							if (num2 != 8)
							{
								num = 4;
								continue;
							}
							str = ".fpga";
							num = 18;
							continue;
						}
						case 24:
						{
							if (num9 >= array.Length)
							{
								num = 10;
								continue;
							}
							string a_ = array[num9];
							num = 34;
							continue;
						}
						case 25:
							num = 29;
							continue;
						case 26:
							if (A_4.Length != 0)
							{
								num = 15;
								continue;
							}
							goto IL_1CDF;
						case 27:
							if (A_4 != null)
							{
								num = 9;
								continue;
							}
							goto IL_1C6E;
						case 28:
							num = 32;
							continue;
						case 29:
							if (A_3.Length != 0)
							{
								num = 36;
								continue;
							}
							goto IL_1CDF;
						case 30:
							xmlReader = null;
							num = 12;
							continue;
						case 31:
							goto IL_1D50;
						case 32:
						{
							if (A_5.Length == 0)
							{
								num = 0;
								continue;
							}
							this.e = A_5;
							global::System.IO.DirectoryInfo directoryInfo = new global::System.IO.DirectoryInfo(A_5);
							A_7 = new global::System.Collections.ArrayList();
							num = 35;
							continue;
						}
						case 33:
							goto IL_E8;
						case 34:
						{
							bool flag;
							if (flag)
							{
								num = 30;
								continue;
							}
							goto IL_1D9C;
						}
						case 35:
						{
							global::System.IO.DirectoryInfo directoryInfo;
							if (directoryInfo != null)
							{
								num = 37;
								continue;
							}
							goto IL_1C30;
						}
						case 36:
							goto IL_1B56;
						case 37:
							num = 7;
							continue;
						case 38:
							if (A_5 != null)
							{
								num = 28;
								continue;
							}
							goto IL_1CDF;
						case 39:
							if (A_1.Count != 0)
							{
								num = 33;
								continue;
							}
							goto IL_1CDF;
						}
						if (A_0 != null)
						{
							num = 16;
							continue;
						}
						goto IL_1D50;
						IL_E8:
						num = 19;
						continue;
						IL_1ACB:
						num = 24;
						continue;
						IL_1B56:
						num = 27;
						continue;
						IL_1BDC:
						string[] files = global::System.IO.Directory.GetFiles(this.e, "*" + str, global::System.IO.SearchOption.AllDirectories);
						array = files;
						num9 = 0;
						num = 20;
						continue;
						IL_1C6E:
						num = 38;
						continue;
						IL_1D50:
						num = 14;
						continue;
						IL_1D9C:
						num9++;
						num = 13;
					}
					IL_1BC4:
					goto IL_1CDF;
					IL_1C2E:
					IL_1C30:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_1CDF:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex2;
					IL_1DC4:;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.Xml.XmlException)
				{
					global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(2932U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex3;
				}
				catch (global::System.Exception ex4)
				{
					if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex4))
					{
						if (true)
						{
						}
						ex4.Source = 2914U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex4.Source;
					}
					throw;
				}
				return;
			}
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00021EA4 File Offset: 0x00020EA4
		public void a(string A_0, string A_1, string A_2, string A_3, string A_4, bool A_5, ref global::DeviceUpdate.e[] A_6)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 26;
					for (;;)
					{
						string text;
						int num3;
						string[] array;
						switch (num)
						{
						case 0:
							goto IL_D06;
						case 1:
							if (A_0.Length != 0)
							{
								num = 23;
								continue;
							}
							goto IL_332;
						case 2:
							goto IL_D75;
						case 3:
							goto IL_DA;
						case 4:
						{
							global::System.GC.Collect();
							global::System.Collections.ArrayList arrayList;
							A_6 = new global::DeviceUpdate.e[arrayList.Count];
							int num2 = 0;
							global::System.Collections.IEnumerator enumerator = arrayList.GetEnumerator();
							num = 12;
							continue;
						}
						case 5:
							if (A_1.Length != 0)
							{
								num = 3;
								continue;
							}
							goto IL_332;
						case 6:
							num = 1;
							continue;
						case 7:
							if (A_3 != null)
							{
								num = 32;
								continue;
							}
							goto IL_D06;
						case 8:
							goto IL_EF0;
						case 9:
							text += ".pak";
							num = 24;
							continue;
						case 10:
							if (A_2 != null)
							{
								num = 13;
								continue;
							}
							goto IL_1FF;
						case 11:
						{
							string text2 = ".mig";
							num = 2;
							continue;
						}
						case 12:
							try
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = 3;
											continue;
										}
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_E99;
										default:
										{
											if (false)
											{
											}
											global::DeviceUpdate.e e = (global::DeviceUpdate.e)enumerator.Current;
											int num2;
											A_6[num2] = e;
											num2++;
											num = 2;
											continue;
										}
										}
										break;
									}
									case 3:
										num = 4;
										continue;
									case 4:
										goto IL_E99;
									}
									IL_E6D:
									num = 1;
									continue;
									goto IL_E6D;
								}
								IL_E99:;
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
												num = 1;
												continue;
											}
											goto IL_EE3;
										case 1:
											disposable.Dispose();
											num = 2;
											continue;
										case 2:
											goto IL_EE1;
										}
										break;
									}
								}
								IL_EE1:
								IL_EE3:;
							}
							num = 8;
							continue;
						case 13:
							num = 33;
							continue;
						case 14:
						{
							if (A_4.Length == 0)
							{
								num = 28;
								continue;
							}
							this.e = A_4;
							global::System.IO.DirectoryInfo directoryInfo = new global::System.IO.DirectoryInfo(A_4);
							global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
							global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
							num = 16;
							continue;
						}
						case 15:
							if (A_4 != null)
							{
								num = 37;
								continue;
							}
							goto IL_332;
						case 16:
						{
							global::System.IO.DirectoryInfo directoryInfo;
							if (directoryInfo != null)
							{
								num = 31;
								continue;
							}
							goto IL_29C;
						}
						case 17:
						{
							if (num3 >= array.Length)
							{
								num = 4;
								continue;
							}
							string text3 = array[num3];
							string text2 = ".pak";
							num = 27;
							continue;
						}
						case 18:
							goto IL_1D2;
						case 19:
						{
							global::System.Xml.XmlDocument xmlDocument;
							if (xmlDocument == null)
							{
								num = 18;
								continue;
							}
							string empty = string.Empty;
							text = "*";
							num = 21;
							continue;
						}
						case 20:
							num = 5;
							continue;
						case 21:
							if (!A_5)
							{
								num = 9;
								continue;
							}
							text += ".mig";
							num = 38;
							continue;
						case 22:
						{
							string text2;
							string text3;
							if (global::constants.StringUtility.ValidateExtension(text3, new string[]
							{
								text2
							}))
							{
								num = 36;
								continue;
							}
							goto IL_26E;
						}
						case 23:
							goto IL_DAE;
						case 24:
							goto IL_DD1;
						case 25:
							if (A_1 != null)
							{
								num = 20;
								continue;
							}
							goto IL_DA;
						case 27:
							if (A_5)
							{
								num = 11;
								continue;
							}
							goto IL_D75;
						case 28:
							goto IL_269;
						case 29:
							goto IL_1FF;
						case 30:
							goto IL_18C;
						case 31:
							num = 19;
							continue;
						case 32:
							num = 34;
							continue;
						case 33:
							if (A_2.Length != 0)
							{
								num = 29;
								continue;
							}
							goto IL_332;
						case 34:
							if (A_3.Length != 0)
							{
								num = 0;
								continue;
							}
							goto IL_332;
						case 35:
							try
							{
								try
								{
									string text3;
									string empty;
									this.a(text3, ref empty);
									global::System.IO.StringReader stringReader = new global::System.IO.StringReader(empty);
									global::System.Xml.XmlTextReader xmlTextReader2;
									global::System.Xml.XmlTextReader xmlTextReader = xmlTextReader2 = new global::System.Xml.XmlTextReader(stringReader);
									try
									{
										for (;;)
										{
											stringReader = null;
											num = 37;
											for (;;)
											{
												bool flag;
												string text4;
												string text5;
												string text6;
												string text7;
												string text8;
												string text9;
												bool flag4;
												bool flag5;
												switch (num)
												{
												case 0:
													num = 58;
													continue;
												case 1:
													goto IL_9A4;
												case 2:
													if (xmlTextReader.Name.Length != 0)
													{
														num = 31;
														continue;
													}
													goto IL_9A4;
												case 3:
													if (A_1.Length == 10)
													{
														num = 0;
														continue;
													}
													goto IL_9A4;
												case 4:
													if (!flag)
													{
														num = 60;
														continue;
													}
													goto IL_8E9;
												case 5:
													goto IL_779;
												case 6:
												{
													bool flag2 = true;
													num = 57;
													continue;
												}
												case 7:
													num = 3;
													continue;
												case 8:
													if (A_2 != null)
													{
														num = 12;
														continue;
													}
													goto IL_8D5;
												case 9:
												{
													string name;
													int num4;
													if (global::f.d.TryGetValue(name, out num4))
													{
														num = 30;
														continue;
													}
													goto IL_9A4;
												}
												case 10:
													if (A_0 != null)
													{
														num = 74;
														continue;
													}
													goto IL_779;
												case 11:
													if (global::f.d == null)
													{
														num = 34;
														continue;
													}
													goto IL_51B;
												case 12:
													num = 39;
													continue;
												case 13:
													goto IL_9A4;
												case 14:
													goto IL_9A4;
												case 15:
													goto IL_8E9;
												case 16:
													num = 22;
													continue;
												case 17:
													goto IL_9A4;
												case 18:
													goto IL_8D5;
												case 19:
													if (A_0 == null)
													{
														num = 15;
														continue;
													}
													goto IL_C6B;
												case 20:
												{
													string name2 = xmlTextReader.Name;
													num = 14;
													continue;
												}
												case 21:
													if (A_1 == null)
													{
														num = 68;
														continue;
													}
													goto IL_C6B;
												case 22:
												{
													bool flag3;
													if (flag3)
													{
														num = 62;
														continue;
													}
													goto IL_C6B;
												}
												case 23:
												{
													double num5;
													double num6;
													if (num5 >= num6)
													{
														num = 43;
														continue;
													}
													goto IL_9A4;
												}
												case 24:
													goto IL_9A4;
												case 25:
													num = 46;
													continue;
												case 26:
													goto IL_9A4;
												case 27:
													if (text4.Length == 9)
													{
														num = 7;
														continue;
													}
													goto IL_9A4;
												case 28:
													num = 11;
													continue;
												case 29:
													num = 61;
													continue;
												case 30:
													num = 55;
													continue;
												case 31:
													num = 50;
													continue;
												case 32:
												{
													bool flag3 = true;
													num = 17;
													continue;
												}
												case 33:
													if (!xmlTextReader.Read())
													{
														num = 16;
														continue;
													}
													num = 2;
													continue;
												case 34:
													global::f.d = new global::System.Collections.Generic.Dictionary<string, int>(7)
													{
														{
															"FLASH_PACK",
															0
														},
														{
															"FIRMWARE",
															1
														},
														{
															"CODEPLUG",
															2
														},
														{
															"TANAPA",
															3
														},
														{
															"MODEL",
															4
														},
														{
															"REGION",
															5
														},
														{
															"CPS_BUILD",
															6
														}
													};
													num = 65;
													continue;
												case 35:
												{
													int num7;
													int num8;
													if (num7 >= num8)
													{
														num = 52;
														continue;
													}
													goto IL_9A4;
												}
												case 36:
												{
													double num5;
													double num9;
													if (num5 <= num9)
													{
														num = 32;
														continue;
													}
													goto IL_9A4;
												}
												case 37:
												{
													if (xmlTextReader == null)
													{
														num = 54;
														continue;
													}
													text5 = string.Empty;
													text6 = string.Empty;
													text7 = string.Empty;
													text8 = string.Empty;
													text4 = string.Empty;
													text9 = string.Empty;
													flag = false;
													flag4 = false;
													bool flag2 = false;
													bool flag3 = false;
													flag5 = false;
													num = 13;
													continue;
												}
												case 38:
													num = 49;
													continue;
												case 39:
													if (text8.Equals(A_2))
													{
														num = 18;
														continue;
													}
													goto IL_9A4;
												case 40:
													num = 21;
													continue;
												case 41:
													if (xmlTextReader.NodeType.Equals(global::System.Xml.XmlNodeType.EndElement))
													{
														num = 20;
														continue;
													}
													goto IL_9A4;
												case 42:
													goto IL_572;
												case 43:
													num = 36;
													continue;
												case 44:
													goto IL_9A4;
												case 45:
													if (text4.Equals(A_1))
													{
														num = 48;
														continue;
													}
													num = 27;
													continue;
												case 46:
													goto IL_9A4;
												case 47:
												{
													if (A_3 == null)
													{
														num = 6;
														continue;
													}
													int num7 = int.Parse(A_3, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
													int num8 = int.Parse(xmlTextReader.Value.ToString(global::System.Globalization.CultureInfo.InvariantCulture), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
													num = 35;
													continue;
												}
												case 48:
													goto IL_89A;
												case 49:
													if (!flag4)
													{
														num = 29;
														continue;
													}
													goto IL_572;
												case 50:
													if (xmlTextReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
													{
														num = 73;
														continue;
													}
													num = 41;
													continue;
												case 51:
													goto IL_9A4;
												case 52:
												{
													bool flag2 = true;
													num = 1;
													continue;
												}
												case 53:
													num = 45;
													continue;
												case 54:
													goto IL_4F8;
												case 55:
												{
													int num4;
													switch (num4)
													{
													case 0:
													{
														text7 = xmlTextReader.GetAttribute("TEMPLATEVERSION");
														double num5 = double.Parse(text7, global::System.Globalization.CultureInfo.InvariantCulture);
														double num9 = 8.0;
														double num6 = 8.0;
														num = 23;
														continue;
													}
													case 1:
														text5 = xmlTextReader.GetAttribute("VERSION");
														num = 44;
														continue;
													case 2:
														text6 = xmlTextReader.GetAttribute("VERSION");
														num = 24;
														continue;
													case 3:
														xmlTextReader.Read();
														text4 = xmlTextReader.Value.Trim();
														num = 56;
														continue;
													case 4:
														xmlTextReader.Read();
														text9 = xmlTextReader.Value;
														num = 10;
														continue;
													case 5:
														xmlTextReader.Read();
														text8 = xmlTextReader.Value;
														num = 8;
														continue;
													case 6:
														xmlTextReader.Read();
														num = 47;
														continue;
													default:
														num = 25;
														continue;
													}
													break;
												}
												case 56:
													if (A_1 != null)
													{
														num = 53;
														continue;
													}
													goto IL_89A;
												case 57:
													goto IL_9A4;
												case 58:
													if (text4.Equals(A_1.Substring(0, 9)))
													{
														num = 63;
														continue;
													}
													goto IL_9A4;
												case 59:
													if (text9.Equals(A_0))
													{
														num = 5;
														continue;
													}
													goto IL_9A4;
												case 60:
													num = 19;
													continue;
												case 61:
													if (A_2 == null)
													{
														num = 42;
														continue;
													}
													goto IL_C6B;
												case 62:
													num = 67;
													continue;
												case 63:
													flag5 = true;
													num = 70;
													continue;
												case 64:
													goto IL_9A4;
												case 65:
													goto IL_51B;
												case 66:
													goto IL_C6B;
												case 67:
												{
													bool flag2;
													if (flag2)
													{
														num = 38;
														continue;
													}
													goto IL_C6B;
												}
												case 68:
													goto IL_C08;
												case 69:
													goto IL_C77;
												case 70:
													goto IL_9A4;
												case 71:
												{
													string name;
													if ((name = xmlTextReader.Name) != null)
													{
														num = 28;
														continue;
													}
													goto IL_9A4;
												}
												case 72:
													if (!flag5)
													{
														num = 40;
														continue;
													}
													goto IL_C08;
												case 73:
													num = 71;
													continue;
												case 74:
													num = 59;
													continue;
												}
												break;
												IL_51B:
												num = 9;
												continue;
												IL_572:
												num = 4;
												continue;
												IL_779:
												flag = true;
												num = 64;
												continue;
												IL_89A:
												flag5 = true;
												num = 26;
												continue;
												IL_8D5:
												flag4 = true;
												num = 51;
												continue;
												IL_8E9:
												num = 72;
												continue;
												IL_9A4:
												num = 33;
												continue;
												IL_C08:
												global::System.Collections.ArrayList arrayList;
												arrayList.Add(new global::DeviceUpdate.e
												{
													a = text5,
													b = text6,
													e = text7,
													g = text3,
													h = text8,
													i = text4,
													j = text9
												});
												num = 66;
												continue;
												IL_C6B:
												num = 69;
											}
										}
										IL_4F8:
										global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
										throw ex;
										IL_C77:;
									}
									finally
									{
										num = 1;
										for (;;)
										{
											switch (num)
											{
											case 0:
												((global::System.IDisposable)xmlTextReader2).Dispose();
												num = 2;
												continue;
											case 2:
												goto IL_CB6;
											}
											if (xmlTextReader2 == null)
											{
												break;
											}
											num = 0;
										}
										IL_CB6:;
									}
								}
								catch
								{
								}
								goto IL_26E;
							}
							finally
							{
								num = 0;
								for (;;)
								{
									global::System.IO.StringReader stringReader;
									switch (num)
									{
									case 1:
										stringReader.Close();
										num = 2;
										continue;
									case 2:
										goto IL_D03;
									}
									if (stringReader == null)
									{
										break;
									}
									num = 1;
								}
								IL_D03:;
							}
							goto IL_D06;
						case 36:
						{
							global::System.IO.StringReader stringReader = null;
							num = 35;
							continue;
						}
						case 37:
							num = 14;
							continue;
						case 38:
							goto IL_DD1;
						case 39:
							goto IL_18C;
						}
						if (A_0 != null)
						{
							num = 6;
							continue;
						}
						goto IL_DAE;
						IL_DA:
						num = 10;
						continue;
						IL_18C:
						num = 17;
						continue;
						IL_1FF:
						num = 7;
						continue;
						IL_26E:
						num3++;
						num = 39;
						continue;
						IL_D06:
						num = 15;
						continue;
						IL_D75:
						num = 22;
						continue;
						IL_DAE:
						num = 25;
						continue;
						IL_DD1:
						string[] files = global::System.IO.Directory.GetFiles(this.e, text, global::System.IO.SearchOption.AllDirectories);
						array = files;
						num3 = 0;
						num = 30;
					}
					IL_1D2:
					goto IL_29C;
					IL_269:
					goto IL_332;
					IL_29C:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex2;
					IL_332:
					global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex3;
					IL_EF0:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Xml.XmlException)
			{
				global::custom_exception.CCustomException ex4 = new global::custom_exception.CCustomException(2932U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex4;
			}
			catch (global::System.Exception ex5)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex5))
				{
					if (true)
					{
					}
					ex5.Source = 2914U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex5.Source;
				}
				throw;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00022ECC File Offset: 0x00021ECC
		private void a(string A_0, ref string A_1)
		{
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						global::i.a(A_0, ref A_1, false, global::i.a.c);
						global::i.c c = global::i.a(global::i.b.b, ref A_1);
						int num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_A7;
							case 1:
								goto IL_4A;
							case 2:
								if (c != global::i.c.c)
								{
									num = 1;
									continue;
								}
								for (;;)
								{
									global::System.GC.Collect();
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_8D;
									}
								}
								IL_8D:
								if (true)
								{
								}
								if (false)
								{
								}
								num = 0;
								continue;
							}
							break;
						}
					}
					IL_4A:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1835U, "DeviceUpdate", "RetrieveUpdateInfo", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_A7:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex2)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = 2915U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				throw;
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00022FE4 File Offset: 0x00021FE4
		public static void a(string A_0, string A_1)
		{
			switch (0)
			{
			default:
			{
				string text = string.Empty;
				try
				{
					int num = 4;
					for (;;)
					{
						global::i.c c;
						string empty;
						switch (num)
						{
						case 0:
							goto IL_28E;
						case 1:
							num = 16;
							continue;
						case 2:
							goto IL_237;
						case 3:
							goto IL_20A;
						case 5:
							if (global::System.IO.File.Exists(text))
							{
								num = 14;
								continue;
							}
							goto IL_237;
						case 6:
							if (A_1 != null)
							{
								num = 1;
								continue;
							}
							goto IL_1C1;
						case 7:
							if (global::System.IO.File.Exists(A_0))
							{
								num = 9;
								continue;
							}
							goto IL_1C1;
						case 8:
							num = 7;
							continue;
						case 9:
							num = 6;
							continue;
						case 10:
							num = 11;
							continue;
						case 11:
							if (text.Length == 0)
							{
								num = 3;
								continue;
							}
							goto IL_E8;
						case 12:
							goto IL_312;
						case 13:
							num = 18;
							continue;
						case 14:
							global::System.IO.File.Delete(text);
							num = 2;
							continue;
						case 15:
						{
							if (c != global::i.c.c)
							{
								num = 0;
								continue;
							}
							global::System.IO.TextWriter textWriter = new global::System.IO.StreamWriter(text);
							num = 20;
							continue;
						}
						case 16:
						{
							if (A_1.Length < 1)
							{
								num = 19;
								continue;
							}
							global::CommunicationController.ISirfUpdateController sirfUpdateController = new global::CommunicationController.CSirfUpdateController();
							text = global::System.IO.Path.GetTempFileName();
							num = 17;
							continue;
						}
						case 17:
							if (text != null)
							{
								num = 10;
								continue;
							}
							goto IL_293;
						case 18:
							if (A_0.Length >= 1)
							{
								num = 8;
								continue;
							}
							goto IL_1C1;
						case 19:
							goto IL_131;
						case 20:
						{
							try
							{
								global::System.IO.TextWriter textWriter;
								textWriter.Write(empty);
								goto IL_2F8;
							}
							finally
							{
								num = 1;
								for (;;)
								{
									global::System.IO.TextWriter textWriter;
									switch (num)
									{
									case 0:
										((global::System.IDisposable)textWriter).Dispose();
										num = 2;
										continue;
									case 2:
										goto IL_E5;
									}
									if (textWriter == null)
									{
										break;
									}
									num = 0;
								}
								IL_E5:;
							}
							goto IL_E8;
							IL_2F8:
							global::CommunicationController.ISirfUpdateController sirfUpdateController;
							sirfUpdateController.FlashDeviceWithFile(text, A_1);
							global::System.IO.File.Delete(text);
							num = 12;
							continue;
						}
						}
						if (A_0 != null)
						{
							num = 13;
							continue;
						}
						break;
						IL_E8:
						num = 5;
						continue;
						IL_237:
						text = text.Substring(0, text.Length - 4);
						text += ".srec";
						empty = string.Empty;
						global::i.a(A_0, ref empty, false, global::i.a.c);
						c = global::i.a(global::i.b.b, ref empty);
						num = 15;
					}
					IL_131:
					IL_1C1:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "UpdateGPS", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_20A:
					goto IL_293;
					IL_28E:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(1835U, "DeviceUpdate", "UpdateGPS", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex2;
					IL_293:
					global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "DecryptSRECFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex3;
					IL_312:;
				}
				catch (global::custom_exception.CCustomException)
				{
					if (global::System.IO.File.Exists(text))
					{
						global::System.IO.File.Delete(text);
					}
					if (true)
					{
					}
					throw;
				}
				catch (global::System.Exception ex4)
				{
					if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex4))
					{
						ex4.Source = 2918U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex4.Source;
					}
					if (global::System.IO.File.Exists(text))
					{
						global::System.IO.File.Delete(text);
					}
					throw;
				}
				try
				{
					for (;;)
					{
						global::CommunicationController.ISerialTransportController serialTransportController = new global::CommunicationController.CSerialTransportController();
						serialTransportController.OpenController();
						uint num2 = 0U;
						global::CommunicationController.IRadioCodeplugController radioCodeplugController = new global::CommunicationController.CRadioCodeplugController();
						global::ErrorLogging.ILogApplicationError objLogAppErr = new global::ErrorLogging.CLogApplicationError("MOTOTRBO CPS");
						global::System.Threading.Thread.Sleep(10000);
						serialTransportController.Open(A_1, 0U, 8002U, out num2);
						int num3 = 0;
						int num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (num3 >= 10)
								{
									num = 1;
									continue;
								}
								goto IL_41D;
							case 1:
								goto IL_469;
							case 2:
								goto IL_449;
							case 3:
								goto IL_449;
							case 4:
								goto IL_493;
							case 5:
								try
								{
									radioCodeplugController.Open(serialTransportController.GetPointer(), num2, objLogAppErr, 0U, false, null);
									goto IL_469;
								}
								catch (global::custom_exception.CCustomException)
								{
									if (num3 >= 10)
									{
										throw;
									}
									goto IL_435;
								}
								catch (global::System.Exception)
								{
									if (num3 >= 10)
									{
										throw;
									}
									goto IL_435;
								}
								goto IL_41D;
								IL_435:
								num3++;
								num = 3;
								continue;
							}
							break;
							IL_41D:
							global::System.Threading.Thread.Sleep(10000);
							num = 5;
							continue;
							IL_449:
							num = 0;
							continue;
							IL_469:
							radioCodeplugController.RefreshRadioCodeplug();
							radioCodeplugController.Close();
							serialTransportController.Close(num2);
							serialTransportController.CloseController();
							num = 4;
						}
					}
					IL_493:;
				}
				catch (global::custom_exception.CCustomException ex5)
				{
					ex5.Source = 2918U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "Reset Radio Failed!|" + ex5.Source;
					throw;
				}
				catch (global::System.Exception ex6)
				{
					if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex6))
					{
						for (;;)
						{
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_4EA;
							}
						}
						IL_4EA:
						if (false)
						{
						}
						ex6.Source = 2918U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "Reset Radio Failed!|" + ex6.Source;
					}
					throw;
				}
				return;
			}
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000235BC File Offset: 0x000225BC
		public void a(string A_0, ref global::System.Collections.ArrayList A_1)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 25;
					for (;;)
					{
						int num2;
						global::System.Xml.XmlNode xmlNode;
						global::System.IO.DirectoryInfo directoryInfo;
						int num4;
						global::System.IO.FileInfo fileInfo2;
						string empty;
						global::System.IO.DirectoryInfo directoryInfo2;
						global::System.Xml.XmlDocument xmlDocument2;
						switch (num)
						{
						case 0:
							if (A_1 != null)
							{
								num = 12;
								continue;
							}
							goto IL_23D;
						case 1:
							goto IL_5C0;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_38E;
							default:
								if (false)
								{
								}
								global::System.GC.Collect();
								num = 6;
								continue;
							}
							break;
						case 3:
							if (A_0.Length == 0)
							{
								num = 7;
								continue;
							}
							goto IL_467;
						case 4:
						{
							global::System.IO.FileInfo[] files;
							if (num2 >= files.Length)
							{
								num = 2;
								continue;
							}
							global::System.IO.FileInfo fileInfo = files[num2];
							num = 26;
							continue;
						}
						case 5:
							goto IL_281;
						case 6:
							goto IL_5E8;
						case 7:
							goto IL_238;
						case 8:
							num = 0;
							continue;
						case 9:
						{
							if (xmlNode == null)
							{
								num = 31;
								continue;
							}
							global::System.Xml.XmlNode xmlNode2 = this.a(xmlNode, "FILE");
							string innerText = xmlNode2.Attributes["VERSION"].InnerText;
							string text = xmlNode2.InnerText;
							text = A_0 + directoryInfo.Name + "\\" + text;
							A_1.Add(text);
							A_1.Add(innerText);
							num = 19;
							continue;
						}
						case 10:
							goto IL_598;
						case 11:
						{
							int num3;
							num3++;
							num = 27;
							continue;
						}
						case 12:
							num = 22;
							continue;
						case 13:
						{
							global::System.IO.FileInfo[] files2;
							if (num4 >= files2.Length)
							{
								num = 11;
								continue;
							}
							fileInfo2 = files2[num4];
							num = 20;
							continue;
						}
						case 14:
						{
							global::System.IO.FileInfo fileInfo;
							string a_ = A_0 + fileInfo.Name;
							this.a(a_, ref empty);
							global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
							num = 32;
							continue;
						}
						case 15:
						{
							global::System.IO.FileInfo[] files = directoryInfo2.GetFiles("*.*");
							num2 = 0;
							num = 29;
							continue;
						}
						case 16:
						{
							int num3;
							global::System.IO.DirectoryInfo[] directories;
							if (num3 >= directories.Length)
							{
								num = 15;
								continue;
							}
							directoryInfo = directories[num3];
							global::System.IO.FileInfo[] files2 = directoryInfo.GetFiles("*.*");
							num4 = 0;
							num = 10;
							continue;
						}
						case 17:
							goto IL_2EA;
						case 18:
							goto IL_510;
						case 19:
							goto IL_16F;
						case 20:
							if (fileInfo2.Extension.Equals(".gpak"))
							{
								num = 28;
								continue;
							}
							goto IL_16F;
						case 21:
							goto IL_598;
						case 22:
						{
							if (xmlDocument2 == null)
							{
								num = 5;
								continue;
							}
							empty = string.Empty;
							global::System.IO.DirectoryInfo[] directories = directoryInfo2.GetDirectories();
							int num3 = 0;
							num = 18;
							continue;
						}
						case 23:
							num = 3;
							continue;
						case 24:
							goto IL_1D1;
						case 26:
						{
							global::System.IO.FileInfo fileInfo;
							if (fileInfo.Extension.Equals(".gpak"))
							{
								num = 14;
								continue;
							}
							goto IL_5C0;
						}
						case 27:
							goto IL_510;
						case 28:
							goto IL_38E;
						case 29:
							goto IL_1D1;
						case 30:
							if (directoryInfo2 != null)
							{
								num = 8;
								continue;
							}
							goto IL_23D;
						case 31:
							goto IL_34D;
						case 32:
						{
							global::System.Xml.XmlDocument xmlDocument;
							try
							{
								xmlDocument.LoadXml(empty);
								goto IL_2BD;
							}
							catch
							{
								global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2932U, "DeviceUpdate", "GetAvailGPSPaks", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
								throw ex;
							}
							goto Block_11;
							IL_2BD:
							global::System.Xml.XmlNode xmlNode3 = xmlDocument["FLASH_PACK"];
							num = 34;
							continue;
						}
						case 33:
							goto IL_430;
						case 34:
						{
							global::System.Xml.XmlNode xmlNode3;
							if (xmlNode3 == null)
							{
								num = 17;
								continue;
							}
							global::System.Xml.XmlNode xmlNode4 = this.a(xmlNode3, "FILE");
							string value = xmlNode4.Attributes["VERSION"].ToString();
							string text2 = xmlNode4.InnerText;
							text2 = A_0 + "\\" + text2;
							A_1.Add(text2);
							A_1.Add(value);
							num = 1;
							continue;
						}
						}
						if (A_0 != null)
						{
							num = 23;
							continue;
						}
						break;
						IL_16F:
						num4++;
						num = 21;
						continue;
						IL_1D1:
						num = 4;
						continue;
						Block_11:
						global::System.Xml.XmlDocument xmlDocument3;
						try
						{
							IL_430:
							xmlDocument3.LoadXml(empty);
							goto IL_320;
						}
						catch
						{
							global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2932U, "DeviceUpdate", "GetAvailGPSPaks", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
							throw ex2;
						}
						goto IL_467;
						IL_320:
						xmlNode = xmlDocument3["FLASH_PACK"];
						num = 9;
						continue;
						IL_38E:
						string a_2 = A_0 + directoryInfo.Name + "\\" + fileInfo2.Name;
						this.a(a_2, ref empty);
						xmlDocument3 = new global::System.Xml.XmlDocument();
						if (true)
						{
						}
						num = 33;
						continue;
						IL_467:
						this.e = A_0;
						directoryInfo2 = new global::System.IO.DirectoryInfo(A_0);
						A_1 = new global::System.Collections.ArrayList();
						xmlDocument2 = new global::System.Xml.XmlDocument();
						num = 30;
						continue;
						IL_510:
						num = 16;
						continue;
						IL_598:
						num = 13;
						continue;
						IL_5C0:
						num2++;
						num = 24;
					}
					IL_238:
					goto IL_538;
					IL_23D:
					global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex3;
					IL_281:
					goto IL_23D;
					IL_2EA:
					global::custom_exception.CCustomException ex4 = new global::custom_exception.CCustomException(2928U, "DeviceUpdate", "GetAvailGPSPaks", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex4;
					IL_34D:
					global::custom_exception.CCustomException ex5 = new global::custom_exception.CCustomException(2928U, "DeviceUpdate", "GetAvailGPSPaks", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex5;
					IL_538:
					global::custom_exception.CCustomException ex6 = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex6;
					IL_5E8:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Xml.XmlException)
			{
				global::custom_exception.CCustomException ex7 = new global::custom_exception.CCustomException(2932U, "DeviceUpdate", "GetAvailPackage", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex7;
			}
			catch (global::System.Exception ex8)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex8))
				{
					ex8.Source = 2914U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex8.Source;
				}
				throw;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00023CA4 File Offset: 0x00022CA4
		private global::UpdateController.a b(string A_0)
		{
			switch (0)
			{
			default:
			{
				global::UpdateController.a a;
				for (;;)
				{
					int num;
					global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_213:
						num = 8;
						break;
					default:
						if (false)
						{
						}
						a = new global::UpdateController.a(this.a());
						deviceInfo = global::CommunicationController.CRadioCodeplugController.DeSerialize(A_0);
						num = 3;
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							string text;
							if (!(text == "AF5DAB63F4FC4926BB9000A6F18AF3DC"))
							{
								goto IL_213;
							}
							deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio;
							num = 4;
							continue;
						}
						case 1:
							goto IL_162;
						case 2:
							goto IL_176;
						case 3:
							if (deviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.PCRRadio)
							{
								num = 9;
								continue;
							}
							goto IL_251;
						case 4:
							goto IL_162;
						case 5:
							goto IL_112;
						case 6:
						{
							string text;
							if (!(text == "D105ADD323864E539B513A65076458D3"))
							{
								num = 16;
								continue;
							}
							deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRadio;
							num = 10;
							continue;
						}
						case 7:
						{
							string text;
							if ((text = this.n) != null)
							{
								num = 14;
								continue;
							}
							goto IL_112;
						}
						case 8:
							num = 5;
							continue;
						case 9:
							deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio;
							num = 17;
							continue;
						case 10:
							goto IL_162;
						case 11:
							if (true)
							{
							}
							num = 0;
							continue;
						case 12:
							goto IL_162;
						case 13:
						{
							string text;
							if (!(text == "06CE7B7163C0456A845A6E13421F0AE4"))
							{
								num = 11;
								continue;
							}
							deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.PhoenixRadio;
							num = 1;
							continue;
						}
						case 14:
							num = 6;
							continue;
						case 15:
							goto IL_1D4;
						case 16:
							num = 13;
							continue;
						case 17:
							if (string.IsNullOrEmpty(this.n))
							{
								num = 15;
								continue;
							}
							num = 7;
							continue;
						}
						break;
						IL_112:
						deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio;
						num = 12;
						continue;
						IL_162:
						A_0 = global::CommunicationController.CRadioCodeplugController.Serialize(deviceInfo);
						num = 2;
					}
				}
				IL_176:
				goto IL_251;
				IL_1D4:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2259U, "DeviceUpdate", "NewUpdateController", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
				IL_251:
				a.b(A_0);
				return a;
			}
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00023F0C File Offset: 0x00022F0C
		public void a(string A_0, bool A_1, out global::System.Collections.ArrayList A_2, string A_3, int A_4, int A_5)
		{
			if (true)
			{
			}
			switch (0)
			{
			default:
			{
				this.p = A_5;
				A_2 = null;
				global::System.Collections.ArrayList arrayList = null;
				global::System.Collections.ArrayList arrayList2 = null;
				global::UpdateController.a a = null;
				try
				{
					for (;;)
					{
						arrayList2 = new global::System.Collections.ArrayList();
						this.b.a(out arrayList);
						this.z = A_1;
						this.ak.a(A_0);
						this.a(new global::DeviceUpdate.c.d[]
						{
							this.ak
						});
						int num = 0;
						int num2 = 0;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_E2;
							case 1:
								goto IL_E2;
							case 2:
								try
								{
									this.n = A_3;
									string a_;
									a = this.b(a_);
									goto IL_147;
								}
								catch (global::custom_exception.CCustomException)
								{
									throw;
								}
								catch (global::System.Exception ex)
								{
									global::custom_exception.CCustomException.Rethrow(ex);
									goto IL_147;
								}
								goto IL_E2;
								try
								{
									IL_147:
									for (;;)
									{
										a.a(this.ak.a());
										num2 = 4;
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_21C;
											case 1:
											{
												global::System.Collections.ArrayList arrayList3 = this.a(a, A_3, A_4);
												arrayList2.Add(arrayList[num]);
												arrayList2.Add(arrayList3[0]);
												arrayList2.Add(arrayList3[1]);
												arrayList2.Add(a);
												num2 = 0;
												continue;
											}
											case 2:
												goto IL_228;
											case 3:
												goto IL_21C;
											case 4:
												if (A_4 > 0)
												{
													num2 = 1;
													continue;
												}
												arrayList2.Add(arrayList[num]);
												arrayList2.Add("");
												arrayList2.Add("");
												arrayList2.Add(a);
												num2 = 3;
												continue;
											}
											break;
											IL_21C:
											num2 = 2;
										}
									}
									IL_228:
									goto IL_AE;
								}
								catch (global::custom_exception.CCustomException)
								{
									try
									{
										a.i();
									}
									catch
									{
									}
									a.d();
									goto IL_AE;
								}
								catch (global::System.Exception)
								{
									try
									{
										a.i();
									}
									catch
									{
									}
									a.d();
									goto IL_AE;
								}
								goto IL_25F;
								IL_AE:
								num++;
								num2 = 1;
								continue;
							case 3:
								if (num >= arrayList.Count)
								{
									num2 = 5;
									continue;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_107;
								default:
								{
									if (false)
									{
									}
									string a_ = arrayList[num].ToString();
									num2 = 2;
									continue;
								}
								}
								break;
							case 4:
								goto IL_26B;
							case 5:
								goto IL_107;
							}
							break;
							IL_E2:
							num2 = 3;
							continue;
							IL_25F:
							num2 = 4;
							continue;
							IL_107:
							goto IL_25F;
						}
					}
					IL_26B:;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.Exception ex2)
				{
					global::custom_exception.CCustomException.Rethrow(ex2);
				}
				A_2 = arrayList2;
				return;
			}
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0002425C File Offset: 0x0002325C
		private static void a(params string[] A_0)
		{
			try
			{
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_82:
					num = 5;
					break;
				default:
					if (false)
					{
					}
					goto IL_44;
				}
				int num2;
				for (;;)
				{
					IL_1E:
					switch (num)
					{
					case 0:
						goto IL_82;
					case 1:
						if (num2 >= A_0.Length)
						{
							num = 0;
							continue;
						}
						num = 6;
						continue;
					case 2:
						goto IL_6C;
					case 3:
						goto IL_6C;
					case 4:
						goto IL_96;
					case 5:
						goto IL_B2;
					case 6:
						if (global::System.IO.File.Exists(A_0[num2]))
						{
							num = 7;
							continue;
						}
						goto IL_96;
					case 7:
						global::System.IO.File.Delete(A_0[num2]);
						num = 4;
						continue;
					}
					goto IL_44;
					IL_6C:
					num = 1;
					continue;
					IL_96:
					num2++;
					num = 2;
				}
				IL_B2:
				goto IL_C0;
				IL_44:
				num2 = 0;
				num = 3;
				goto IL_1E;
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			IL_C0:
			if (true)
			{
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00024358 File Offset: 0x00023358
		private void a(params global::DeviceUpdate.c.d[] A_0)
		{
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						global::i.a a_ = global::i.a.c;
						global::System.Text.Encoding encoding = global::System.Text.Encoding.UTF8;
						int num = 0;
						int num2 = 7;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_301;
							case 1:
								goto IL_301;
							case 2:
								goto IL_301;
							case 3:
								goto IL_1EA;
							case 4:
								goto IL_335;
							case 5:
							{
								global::i.c c;
								if (c != global::i.c.c)
								{
									num2 = 17;
									continue;
								}
								string text;
								global::System.IO.FileStream fileStream = new global::System.IO.FileStream(text, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Write);
								num2 = 14;
								continue;
							}
							case 6:
								goto IL_36B;
							case 7:
								goto IL_1EA;
							case 8:
							{
								global::DeviceUpdate.c.e e;
								switch (e)
								{
								case global::DeviceUpdate.c.e.a:
								case global::DeviceUpdate.c.e.b:
								case global::DeviceUpdate.c.e.c:
								case global::DeviceUpdate.c.e.d:
								{
									bool a_2 = this.v;
									num2 = 0;
									continue;
								}
								case global::DeviceUpdate.c.e.e:
								case global::DeviceUpdate.c.e.f:
								{
									bool a_2 = this.u;
									goto IL_29B;
								}
								case global::DeviceUpdate.c.e.g:
								{
									bool a_2 = this.y;
									num2 = 9;
									continue;
								}
								case global::DeviceUpdate.c.e.h:
								{
									bool a_2 = this.x;
									num2 = 16;
									continue;
								}
								case global::DeviceUpdate.c.e.i:
								{
									bool a_2 = this.z;
									num2 = 1;
									continue;
								}
								case global::DeviceUpdate.c.e.j:
								{
									bool a_2 = this.w;
									a_ = global::i.a.e;
									encoding = global::System.Text.Encoding.GetEncoding(1252);
									num2 = 2;
									continue;
								}
								default:
									num2 = 13;
									continue;
								}
								break;
							}
							case 9:
								goto IL_301;
							case 10:
							{
								string empty = string.Empty;
								string text;
								bool a_2;
								global::i.a(text, ref empty, a_2, a_);
								global::i.c c = global::i.a(global::i.b.b, ref empty);
								num2 = 5;
								continue;
							}
							case 11:
								num2 = 6;
								continue;
							case 12:
							{
								string text;
								if (global::System.IO.File.Exists(text))
								{
									num2 = 10;
									continue;
								}
								goto IL_1C2;
							}
							case 13:
								num2 = 4;
								continue;
							case 14:
								try
								{
									string empty;
									byte[] bytes = encoding.GetBytes(empty);
									global::System.IO.FileStream fileStream;
									fileStream.SetLength(0L);
									fileStream.Write(bytes, 0, bytes.Length);
									goto IL_A8;
								}
								finally
								{
									num2 = 2;
									for (;;)
									{
										global::System.IO.FileStream fileStream;
										switch (num2)
										{
										case 0:
											goto IL_134;
										case 1:
											((global::System.IDisposable)fileStream).Dispose();
											num2 = 0;
											continue;
										}
										if (fileStream == null)
										{
											break;
										}
										num2 = 1;
									}
									IL_134:;
								}
								goto IL_137;
								IL_A8:
								global::System.GC.Collect();
								num2 = 19;
								continue;
							case 15:
								goto IL_301;
							case 16:
								goto IL_301;
							case 17:
								goto IL_1A5;
							case 18:
							{
								if (num >= A_0.Length)
								{
									num2 = 11;
									continue;
								}
								string text = A_0[num].a();
								global::DeviceUpdate.c.e e2 = A_0[num].b();
								global::DeviceUpdate.c.e e = e2;
								num2 = 8;
								continue;
							}
							case 19:
								goto IL_137;
							}
							break;
							IL_137:
							num++;
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_29B:
								num2 = 15;
								continue;
							default:
								if (false)
								{
								}
								num2 = 3;
								continue;
							}
							IL_1EA:
							num2 = 18;
							continue;
							IL_301:
							num2 = 12;
						}
					}
					IL_1A5:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1835U, "DeviceUpdate", "DecryptSRECFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_1C2:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2392U, "DeviceUpdate", "DecryptSRECFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex2;
					IL_335:
					global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "DecryptSRECFiles", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex3;
					IL_36B:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex4)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex4))
				{
					ex4.Source = 2390U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex4.Source;
				}
				throw;
			}
			if (true)
			{
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00024770 File Offset: 0x00023770
		private void a(global::UpdateController.a A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5, out string A_6, out string A_7, out string A_8, out string A_9)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 14;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_9DD;
						case 1:
							num = 20;
							continue;
						case 2:
							num = 19;
							continue;
						case 3:
							goto IL_99;
						case 4:
							A_6 = this.ab.a();
							num = 0;
							continue;
						case 5:
							goto IL_A2D;
						case 6:
							goto IL_1A4;
						case 7:
							goto IL_A39;
						case 8:
							if (string.IsNullOrEmpty(this.ak.a()))
							{
								num = 23;
								continue;
							}
							num = 17;
							continue;
						case 9:
							if (this.n.Equals("06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
							{
								num = 2;
								continue;
							}
							goto IL_A2D;
						case 10:
							if (!A_1)
							{
								num = 18;
								continue;
							}
							goto IL_9BA;
						case 11:
							goto IL_9BA;
						case 12:
							goto IL_19F;
						case 13:
							if (!A_3)
							{
								num = 4;
								continue;
							}
							goto IL_9DD;
						case 15:
							A_9 = this.ae.a();
							num = 5;
							continue;
						case 16:
							try
							{
								for (;;)
								{
									object obj;
									bool flag;
									global::System.Threading.Monitor.Enter(obj = global::DeviceUpdate.c.m, ref flag);
									string empty = string.Empty;
									string a_ = string.Empty;
									string empty2 = string.Empty;
									A_6 = string.Empty;
									A_7 = string.Empty;
									A_8 = string.Empty;
									A_9 = string.Empty;
									A_0.a(out empty, A_5);
									ulong num2 = 0UL;
									ulong num3 = 0UL;
									ulong num4 = 0UL;
									ulong num5 = 0UL;
									ulong num6 = 0UL;
									ulong num7 = 0UL;
									ulong num8 = 0UL;
									ulong num9 = 0UL;
									num = 18;
									for (;;)
									{
										switch (num)
										{
										case 0:
										{
											global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings = new global::RegistryAccess.CPersistentApplicationSettings();
											persistentApplicationSettings.GetXferFolderPath(ref A_7);
											num = 13;
											continue;
										}
										case 1:
											if (A_6[A_6.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
											{
												num = 3;
												continue;
											}
											goto IL_398;
										case 2:
											goto IL_74C;
										case 3:
											A_6 += global::System.IO.Path.DirectorySeparatorChar;
											num = 11;
											continue;
										case 4:
											if (A_9[A_9.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
											{
												num = 12;
												continue;
											}
											goto IL_78B;
										case 5:
											A_7 += global::System.IO.Path.DirectorySeparatorChar;
											num = 6;
											continue;
										case 6:
											goto IL_321;
										case 7:
											if (A_3)
											{
												num = 22;
												continue;
											}
											goto IL_4B9;
										case 8:
											goto IL_74C;
										case 9:
											goto IL_4B9;
										case 10:
											if (A_4)
											{
												num = 23;
												continue;
											}
											goto IL_8CF;
										case 11:
											goto IL_398;
										case 12:
											A_9 += global::System.IO.Path.DirectorySeparatorChar;
											num = 24;
											continue;
										case 13:
											if (A_7[A_7.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
											{
												num = 5;
												continue;
											}
											goto IL_321;
										case 14:
											goto IL_89C;
										case 15:
											if (A_2)
											{
												num = 0;
												continue;
											}
											this.c.g(this.s);
											this.c.b(this.s, this.n);
											num = 14;
											continue;
										case 16:
										{
											this.c.a(empty, out num6, out num7, this.r);
											A_0.a((int)num6, (int)num7, A_5, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE, out empty2);
											this.c.a(empty2, this.r, this.p);
											global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings2 = new global::RegistryAccess.CPersistentApplicationSettings();
											persistentApplicationSettings2.GetXferFolderPath(ref A_8);
											num = 29;
											continue;
										}
										case 17:
											if (string.Equals(this.n, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
											{
												num = 25;
												continue;
											}
											goto IL_8CF;
										case 18:
											if (string.IsNullOrEmpty(this.ai.a()))
											{
												num = 30;
												continue;
											}
											a_ = this.ai.a();
											num = 2;
											continue;
										case 19:
											A_8 += global::System.IO.Path.DirectorySeparatorChar;
											num = 26;
											continue;
										case 20:
											goto IL_802;
										case 21:
											goto IL_8DB;
										case 22:
										{
											this.c.a(empty, out num2, out num3, this.q);
											A_0.a((int)num2, (int)num3, A_5, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_APP, out empty2);
											this.c.a(empty2, this.q, this.p);
											global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings3 = new global::RegistryAccess.CPersistentApplicationSettings();
											persistentApplicationSettings3.GetXferFolderPath(ref A_6);
											num = 1;
											continue;
										}
										case 23:
										{
											this.c.a(empty, out num8, out num9, this.t);
											A_0.a((int)num8, (int)num9, A_5, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.UCL, out empty2);
											this.c.a(empty2, this.t, this.p);
											global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings4 = new global::RegistryAccess.CPersistentApplicationSettings();
											persistentApplicationSettings4.GetXferFolderPath(ref A_9);
											num = 4;
											continue;
										}
										case 24:
											goto IL_78B;
										case 25:
											num = 10;
											continue;
										case 26:
											goto IL_607;
										case 27:
											goto IL_89C;
										case 28:
											goto IL_8CF;
										case 29:
											if (A_8[A_8.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
											{
												num = 19;
												continue;
											}
											goto IL_607;
										case 30:
											a_ = empty;
											num = 8;
											continue;
										case 31:
											if (A_1)
											{
												num = 16;
												continue;
											}
											goto IL_802;
										}
										break;
										IL_321:
										A_7 = A_7 + global::System.Guid.NewGuid().ToString("D") + ".srec";
										this.c.a(this.j, this.k, A_7, this.s, empty, a_, this.l, this.h, this.g, this.n, this.o, A_5);
										num = 27;
										continue;
										IL_398:
										A_6 = A_6 + global::System.Guid.NewGuid().ToString("D") + ".srec";
										this.c.a(this.j, this.k, A_6, this.q, empty, a_, this.l, this.h, this.g, this.n, this.o, A_5);
										num = 9;
										continue;
										IL_4B9:
										num = 31;
										continue;
										IL_607:
										A_8 = A_8 + global::System.Guid.NewGuid().ToString("D") + ".srec";
										this.c.a(this.j, this.k, A_8, this.r, empty, a_, this.l, this.h, this.g, this.n, this.o, A_5);
										num = 20;
										continue;
										IL_74C:
										num = 7;
										continue;
										IL_78B:
										A_9 = A_9 + global::System.Guid.NewGuid().ToString("D") + ".srec";
										this.c.a(this.j, this.k, A_9, this.t, empty, a_, this.l, this.h, this.g, this.n, this.o, A_5);
										num = 28;
										continue;
										IL_802:
										this.c.a(empty, out num4, out num5, this.s);
										A_0.a((int)num4, (int)num5, A_5, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC, out empty2);
										this.c.a(empty2, this.s, this.p);
										num = 15;
										continue;
										IL_89C:
										num = 17;
										continue;
										IL_8CF:
										num = 21;
									}
								}
								IL_8DB:
								goto IL_153;
							}
							finally
							{
								num = 2;
								for (;;)
								{
									switch (num)
									{
									case 0:
									{
										object obj;
										global::System.Threading.Monitor.Exit(obj);
										goto IL_930;
									}
									case 1:
										goto IL_939;
									}
									bool flag;
									if (!flag)
									{
										break;
									}
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
									IL_930:
									num = 1;
								}
								IL_939:;
							}
							goto IL_93C;
							IL_153:
							num = 13;
							continue;
						case 17:
							if (global::System.IO.File.Exists(this.j))
							{
								num = 1;
								continue;
							}
							goto IL_962;
						case 18:
							A_8 = this.ac.a();
							num = 11;
							continue;
						case 19:
							if (!A_4)
							{
								num = 15;
								continue;
							}
							goto IL_A2D;
						case 20:
						{
							if (!global::System.IO.File.Exists(this.k))
							{
								num = 12;
								continue;
							}
							bool flag = false;
							num = 16;
							continue;
						}
						case 21:
							A_7 = this.ad.a();
							num = 6;
							continue;
						case 22:
							if (!A_2)
							{
								num = 21;
								continue;
							}
							goto IL_1A4;
						case 23:
							goto IL_9B5;
						}
						if (string.IsNullOrEmpty(this.g))
						{
							num = 3;
							continue;
						}
						num = 8;
						continue;
						IL_1A4:
						num = 9;
						continue;
						IL_9BA:
						num = 22;
						continue;
						IL_9DD:
						num = 10;
						continue;
						IL_A2D:
						num = 7;
					}
					IL_99:
					goto IL_93C;
					IL_19F:
					goto IL_962;
					IL_93C:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "StoreCodeplug", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_962:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2911U, "DeviceUpdate", "StoreCodeplug", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex2;
					IL_9B5:
					global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(2910U, "DeviceUpdate", "StoreCodeplug", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex3;
					IL_A39:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex4)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex4))
				{
					ex4.Source = 2942U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex4.Source;
				}
				throw;
			}
			if (true)
			{
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00025258 File Offset: 0x00024258
		private void a(global::UpdateController.a A_0, bool A_1, bool A_2, bool A_3, bool A_4, string A_5)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType>();
						global::System.Collections.Generic.List<int> list2 = new global::System.Collections.Generic.List<int>();
						global::System.Collections.Generic.List<uint> list3 = new global::System.Collections.Generic.List<uint>();
						global::System.Collections.Generic.List<uint> list4 = new global::System.Collections.Generic.List<uint>();
						global::System.Collections.Generic.List<string> list5 = new global::System.Collections.Generic.List<string>();
						int num = 3;
						for (;;)
						{
							switch (num)
							{
							case 0:
								list.Add(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM);
								list2.Add(51);
								list3.Add(0U);
								list4.Add(0U);
								list5.Add("B:\\activexx\\codeplug\\cfs_cpg.db");
								num = 8;
								continue;
							case 1:
								goto IL_A2;
							case 2:
								list.Add(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM);
								list2.Add(51);
								list3.Add(0U);
								list4.Add(0U);
								list5.Add("B:\\activexx\\codeplug\\sec_cpg.db");
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_8B;
								default:
									if (false)
									{
									}
									num = 1;
									continue;
								}
								break;
							case 3:
								if (A_3)
								{
									num = 5;
									continue;
								}
								goto IL_82;
							case 4:
								goto IL_8B;
							case 5:
								list.Add(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM);
								list2.Add(51);
								list3.Add(0U);
								list4.Add(0U);
								list5.Add("B:\\activexx\\codeplug\\app_cpg.db");
								num = 11;
								continue;
							case 6:
								goto IL_18D;
							case 7:
								if (A_4)
								{
									num = 0;
									continue;
								}
								goto IL_1E8;
							case 8:
								goto IL_1E8;
							case 9:
								goto IL_203;
							case 10:
								if (A_2)
								{
									num = 2;
									continue;
								}
								goto IL_A2;
							case 11:
								goto IL_82;
							case 12:
								list.Add(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM);
								list2.Add(51);
								list3.Add(0U);
								list4.Add(0U);
								list5.Add("B:\\activexx\\codeplug\\tuning_cpg.db");
								num = 6;
								continue;
							}
							break;
							IL_82:
							num = 4;
							continue;
							IL_8B:
							if (A_1)
							{
								num = 12;
								continue;
							}
							goto IL_18D;
							IL_A2:
							num = 7;
							continue;
							IL_18D:
							num = 10;
							continue;
							IL_1E8:
							A_0.a(list, list2, list3, list4, list5, A_5, false);
							num = 9;
						}
					}
					IL_203:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					ex.Source = 2979U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				if (true)
				{
				}
				throw;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000254F0 File Offset: 0x000244F0
		private void a(global::UpdateController.a A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5, bool A_6)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 23;
					for (;;)
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType> list;
						global::System.Collections.Generic.List<int> list2;
						global::System.Collections.Generic.List<uint> list3;
						global::System.Collections.Generic.List<uint> list4;
						global::System.Collections.Generic.List<string> list5;
						string empty;
						ulong num4;
						ulong num5;
						global::System.Collections.Generic.List<int> list6;
						global::System.Collections.Generic.List<int> list7;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType> list8;
						switch (num)
						{
						case 0:
							list.Add(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM);
							list2.Add(51);
							list3.Add(0U);
							list4.Add(0U);
							list5.Add("/opt/pcr/rel/data/codeplug/app_features/");
							num = 14;
							continue;
						case 1:
							goto IL_35E;
						case 2:
							goto IL_412;
						case 3:
							list.Add(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM);
							list2.Add(50);
							list3.Add(0U);
							list4.Add(0U);
							list5.Add("/opt/pcr/rel/data/tuning/app_tuning/");
							num = 27;
							continue;
						case 4:
							if (A_6)
							{
								num = 0;
								continue;
							}
							goto IL_26A;
						case 5:
							goto IL_4CF;
						case 6:
							num = 29;
							continue;
						case 7:
						{
							empty = string.Empty;
							A_0.a(out empty, false);
							ulong num2 = 0UL;
							ulong num3 = 0UL;
							num4 = 0UL;
							num5 = 0UL;
							ulong num6 = 0UL;
							ulong num7 = 0UL;
							ulong num8 = 0UL;
							ulong num9 = 0UL;
							list6 = new global::System.Collections.Generic.List<int>();
							list7 = new global::System.Collections.Generic.List<int>();
							list8 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType>();
							num = 17;
							continue;
						}
						case 8:
						{
							ulong num6;
							ulong num7;
							this.c.a(empty, out num6, out num7, this.r);
							list6.Add((int)num6);
							list7.Add((int)num7);
							list8.Add(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE);
							num = 15;
							continue;
						}
						case 9:
							goto IL_206;
						case 10:
							if (!A_3)
							{
								goto IL_249;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_206;
							default:
								if (false)
								{
								}
								num = 26;
								continue;
							}
							break;
						case 11:
							if (A_4)
							{
								num = 20;
								continue;
							}
							goto IL_412;
						case 12:
							if (string.Equals(this.n, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
							{
								num = 6;
								continue;
							}
							goto IL_432;
						case 13:
							if (A_2)
							{
								num = 8;
								continue;
							}
							goto IL_BE;
						case 14:
							goto IL_26A;
						case 15:
							goto IL_BE;
						case 16:
							if (A_3)
							{
								num = 9;
								continue;
							}
							goto IL_35E;
						case 17:
							if (A_4)
							{
								num = 21;
								continue;
							}
							goto IL_121;
						case 18:
							goto IL_432;
						case 19:
							goto IL_121;
						case 20:
							list.Add(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM);
							list2.Add(51);
							list3.Add(0U);
							list4.Add(0U);
							list5.Add("/opt/pcr/rel/data/codeplug/app_codeplug/");
							num = 2;
							continue;
						case 21:
						{
							ulong num2;
							ulong num3;
							this.c.a(empty, out num2, out num3, this.q);
							list6.Add((int)num2);
							list7.Add((int)num3);
							list8.Add(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_APP);
							num = 19;
							continue;
						}
						case 22:
							goto IL_4CF;
						case 24:
							if (A_2)
							{
								num = 3;
								continue;
							}
							goto IL_3D2;
						case 25:
						{
							ulong num8;
							ulong num9;
							this.c.a(empty, out num8, out num9, this.t);
							list6.Add((int)num8);
							list7.Add((int)num9);
							list8.Add(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.UCL);
							num = 18;
							continue;
						}
						case 26:
							list.Add(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM);
							list2.Add(51);
							list3.Add(0U);
							list4.Add(0U);
							list5.Add("/opt/pcr/rel/data/codeplug/app_security/");
							num = 30;
							continue;
						case 27:
							goto IL_3D2;
						case 28:
							goto IL_4DB;
						case 29:
							if (A_5)
							{
								num = 25;
								continue;
							}
							goto IL_432;
						case 30:
							goto IL_249;
						}
						if (true)
						{
						}
						if (!A_1)
						{
							num = 7;
							continue;
						}
						list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType>();
						list2 = new global::System.Collections.Generic.List<int>();
						list3 = new global::System.Collections.Generic.List<uint>();
						list4 = new global::System.Collections.Generic.List<uint>();
						list5 = new global::System.Collections.Generic.List<string>();
						num = 11;
						continue;
						IL_BE:
						num = 16;
						continue;
						IL_121:
						num = 13;
						continue;
						IL_206:
						this.c.a(empty, out num4, out num5, this.s);
						list6.Add((int)num4);
						list7.Add((int)num5);
						list8.Add(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC);
						num = 1;
						continue;
						IL_249:
						num = 4;
						continue;
						IL_26A:
						A_0.a(list, list2, list3, list4, list5, string.Empty, true);
						num = 22;
						continue;
						IL_35E:
						num = 12;
						continue;
						IL_3D2:
						num = 10;
						continue;
						IL_412:
						num = 24;
						continue;
						IL_432:
						A_0.a(list6, list7, list8);
						num = 5;
						continue;
						IL_4CF:
						num = 28;
					}
					IL_4DB:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					ex.Source = 2979U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				throw;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00025A58 File Offset: 0x00024A58
		private void a(global::UpdateController.a A_0, string A_1, string A_2, string A_3, string A_4, bool A_5, bool A_6, bool A_7)
		{
			try
			{
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_84:
					A_0.a(A_1, A_7, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_APP);
					num = 11;
					break;
				default:
					if (false)
					{
					}
					num = 7;
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_13D;
					case 1:
						if (string.Equals(this.n, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
						{
							num = 14;
							continue;
						}
						goto IL_11A;
					case 2:
						if (!string.IsNullOrEmpty(A_4))
						{
							num = 9;
							continue;
						}
						goto IL_11A;
					case 3:
						num = 17;
						continue;
					case 4:
						goto IL_11A;
					case 5:
						this.c.a(this.k, A_2, A_2, this.s, this.ai.a(), this.l, this.h, this.n, this.o, A_6, this.p);
						num = 0;
						continue;
					case 6:
						goto IL_84;
					case 8:
						goto IL_1FF;
					case 9:
						A_0.a(A_4, A_7, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.UCL);
						num = 4;
						continue;
					case 10:
						if (!string.IsNullOrEmpty(A_2))
						{
							num = 3;
							continue;
						}
						goto IL_1FF;
					case 11:
						goto IL_F3;
					case 12:
						goto IL_20A;
					case 13:
						A_0.a(A_3, A_7, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE);
						num = 16;
						continue;
					case 14:
						num = 2;
						continue;
					case 15:
						if (!string.IsNullOrEmpty(A_3))
						{
							num = 13;
							continue;
						}
						goto IL_1CE;
					case 16:
						goto IL_1CE;
					case 17:
						if (!A_5)
						{
							num = 5;
							continue;
						}
						goto IL_13D;
					}
					if (!string.IsNullOrEmpty(A_1))
					{
						num = 6;
						continue;
					}
					IL_F3:
					num = 15;
					continue;
					IL_11A:
					num = 10;
					continue;
					IL_13D:
					A_0.a(A_2, A_7, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC);
					num = 8;
					continue;
					IL_1CE:
					num = 1;
					continue;
					IL_1FF:
					num = 12;
				}
				IL_20A:;
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					if (true)
					{
					}
					ex.Source = 2912U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				throw;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00025CF4 File Offset: 0x00024CF4
		private void b(global::UpdateController.a A_0)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_FA;
						case 2:
							goto IL_141;
						case 3:
							goto IL_4F;
						case 4:
							if (!global::System.IO.File.Exists(this.ag.a()))
							{
								num = 1;
								continue;
							}
							this.a(new global::DeviceUpdate.c.d[]
							{
								this.ag
							});
							A_0.a(this.ag.a(), false, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST);
							num = 2;
							continue;
						}
						if (!global::System.IO.File.Exists(this.af.a()))
						{
							num = 3;
						}
						else
						{
							this.a(new global::DeviceUpdate.c.d[]
							{
								this.af
							});
							A_0.a(this.af.a(), false, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DSP);
							num = 4;
						}
					}
					IL_4F:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2919U, "DeviceUpdate", "BufferFirmware", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_FA:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2919U, "DeviceUpdate", "BufferFirmware", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex2;
					IL_141:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex3)
			{
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
				{
					goto IL_17C;
				}
				IL_14F:
				ex3.Source = 2913U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
				IL_17C:
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14F;
				default:
					if (false)
					{
					}
					throw;
				}
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00025EE4 File Offset: 0x00024EE4
		private void a(global::UpdateController.a A_0)
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
						switch (num)
						{
						case 0:
							if (!global::System.IO.File.Exists(this.ai.a()))
							{
								num = 2;
								continue;
							}
							A_0.a(this.ai.a(), false, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT);
							num = 5;
							continue;
						case 1:
							goto IL_99;
						case 2:
							goto IL_127;
						case 3:
							goto IL_57;
						case 5:
							goto IL_172;
						case 6:
							if (!global::System.IO.File.Exists(this.aj.a()))
							{
								if (true)
								{
								}
								num = 1;
								continue;
							}
							A_0.a(this.aj.a(), false, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.BOOT);
							num = 0;
							continue;
						}
						if (!global::System.IO.File.Exists(this.ai.a()))
						{
							num = 3;
						}
						else
						{
							A_0.a(this.ai.a(), false, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT);
							num = 6;
						}
					}
					IL_57:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2937U, "DeviceUpdate", "BufferPSDT", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_99:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2938U, "DeviceUpdate", "BufferPSDT", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex2;
					IL_127:
					global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(2937U, "DeviceUpdate", "BufferPSDT", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex3;
					IL_172:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex4)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex4))
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
						ex4.Source = 2940U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex4.Source;
						break;
					}
				}
				throw;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000260FC File Offset: 0x000250FC
		private global::System.Collections.ArrayList a(global::UpdateController.a A_0, string A_1, int A_2)
		{
			if (true)
			{
			}
			global::System.Collections.ArrayList result;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (false)
				{
				}
				result = null;
				try
				{
					string empty = string.Empty;
					this.a(A_1, A_2);
					A_0.a(out empty, false);
					ulong num = 0UL;
					ulong num2 = 0UL;
					this.c.a(empty, out num, out num2, this.s);
					string empty2 = string.Empty;
					A_0.a((int)num, (int)num2, false, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC, out empty2);
					this.c.a(empty2, this.s, this.p);
					result = this.c.j();
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.Exception ex)
				{
					global::custom_exception.CCustomException.Rethrow(ex);
				}
				break;
			}
			return result;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000261D8 File Offset: 0x000251D8
		public void a(string A_0, string A_1, bool A_2, object A_3, bool A_4, bool A_5, bool A_6, bool A_7, global::constants.CCPTags.SetProgressBar A_8, int A_9)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				string empty = string.Empty;
				string empty2 = string.Empty;
				string empty3 = string.Empty;
				string empty4 = string.Empty;
				string empty5 = string.Empty;
				string empty6 = string.Empty;
				string empty7 = string.Empty;
				string empty8 = string.Empty;
				bool flag = A_2;
				try
				{
					for (;;)
					{
						this.g = A_0;
						this.h = A_1;
						this.c.b(false);
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (this.b.g())
								{
									num = 1;
									continue;
								}
								goto IL_1FD;
							case 1:
								this.b.d();
								num = 8;
								continue;
							case 2:
								goto IL_DE;
							case 3:
								goto IL_2DE;
							case 4:
								goto IL_346;
							case 5:
								A_5 = false;
								A_6 = false;
								this.a(this.b, A_4, A_5, A_6, A_7, true, out empty5, out empty6, out empty7, out empty8);
								this.a(this.b, null, empty6, empty7, empty8, A_5, false, true);
								num = 3;
								continue;
							case 6:
								this.a(new global::DeviceUpdate.c.d[]
								{
									this.ab,
									this.ad,
									this.ac,
									this.ae
								});
								num = 2;
								continue;
							case 7:
								if (string.Equals(this.n, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
								{
									num = 6;
									continue;
								}
								this.a(new global::DeviceUpdate.c.d[]
								{
									this.ab,
									this.ad,
									this.ac
								});
								num = 9;
								continue;
							case 8:
								goto IL_1FD;
							case 9:
								goto IL_DE;
							case 10:
								if (flag)
								{
									num = 5;
									continue;
								}
								goto IL_2DE;
							}
							break;
							IL_DE:
							this.a(this.b, false, A_4, true, A_6, A_7, false);
							this.a(this.b, A_4, A_5, A_6, A_7, false, out empty, out empty2, out empty3, out empty4);
							this.a(this.b, empty, empty2, empty3, empty4, A_5, false, false);
							num = 10;
							continue;
							IL_1FD:
							this.b = (global::UpdateController.a)A_3;
							this.b.a(A_8, A_9);
							flag = this.b.a(this.ak.a());
							this.a(new global::DeviceUpdate.c.d[]
							{
								this.ai
							});
							num = 7;
							continue;
							IL_2DE:
							this.a(new global::DeviceUpdate.c.d[]
							{
								this.aj
							});
							this.a(this.b);
							this.b(this.b);
							this.b.h();
							this.b.i();
							this.b.d();
							num = 4;
						}
					}
					IL_346:;
				}
				catch (global::custom_exception.CCustomException)
				{
					this.a(this.b);
					throw;
				}
				catch (global::System.Exception ex)
				{
					this.a(this.b);
					if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
					{
						goto IL_39D;
					}
					IL_370:
					ex.Source = 2916U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
					IL_39D:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_370;
					default:
						if (false)
						{
						}
						throw;
					}
				}
				finally
				{
					global::DeviceUpdate.c.a(new string[]
					{
						empty,
						empty2,
						empty3,
						empty4,
						empty5,
						empty6,
						empty7,
						empty8
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.ab.a(),
						this.ad.a(),
						this.ac.a(),
						this.ae.a(),
						this.j,
						this.k,
						this.l
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.aj.a()
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.af.a(),
						this.ag.a()
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.ai.a()
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.ak.a()
					});
					global::System.GC.Collect();
				}
				return;
			}
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0002672C File Offset: 0x0002572C
		public void a(string A_0, string A_1, object A_2, global::constants.CCPTags.SetProgressBar A_3, int A_4)
		{
			switch (0)
			{
			default:
			{
				string empty = string.Empty;
				string empty2 = string.Empty;
				string empty3 = string.Empty;
				string empty4 = string.Empty;
				bool flag = true;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				try
				{
					for (;;)
					{
						this.g = A_0;
						this.h = A_1;
						this.c.b(true);
						int num = 3;
						for (;;)
						{
							switch (num)
							{
							case 0:
								this.a(new global::DeviceUpdate.c.d[]
								{
									this.ab,
									this.ad,
									this.ac,
									this.ae
								});
								num = 4;
								continue;
							case 1:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_225;
								default:
									if (false)
									{
									}
									if (string.Equals(this.n, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
									{
										num = 0;
										continue;
									}
									this.a(new global::DeviceUpdate.c.d[]
									{
										this.ab,
										this.ad,
										this.ac
									});
									num = 6;
									continue;
								}
								break;
							case 2:
								goto IL_185;
							case 3:
								if (this.b.g())
								{
									num = 5;
									continue;
								}
								goto IL_185;
							case 4:
								goto IL_225;
							case 5:
								this.b.d();
								num = 2;
								continue;
							case 6:
								goto IL_225;
							case 7:
								goto IL_2C7;
							}
							break;
							IL_185:
							this.b = (global::UpdateController.a)A_2;
							this.b.a(A_3, A_4);
							this.a(new global::DeviceUpdate.c.d[]
							{
								this.ai,
								this.aj
							});
							num = 1;
							continue;
							IL_225:
							this.b.a(this.ak.a());
							this.a(this.b, false, flag, true, flag3, flag4, false);
							this.a(this.b, flag, flag2, flag3, flag4, false, out empty, out empty2, out empty3, out empty4);
							this.a(this.b);
							this.b(this.b);
							this.a(this.b, empty, empty2, empty3, empty4, flag2, true, false);
							this.b.h();
							this.b.i();
							this.b.d();
							num = 7;
						}
					}
					IL_2C7:;
				}
				catch (global::custom_exception.CCustomException)
				{
					this.a(this.b);
					throw;
				}
				catch (global::System.Exception ex)
				{
					this.a(this.b);
					if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
					{
						ex.Source = 2916U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
					}
					throw;
				}
				finally
				{
					global::DeviceUpdate.c.a(new string[]
					{
						this.aj.a()
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.af.a(),
						this.ag.a()
					});
					global::DeviceUpdate.c.a(new string[]
					{
						empty,
						empty2,
						empty3,
						empty4
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.ab.a(),
						this.ad.a(),
						this.ac.a(),
						this.ae.a(),
						this.j,
						this.k,
						this.l
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.ai.a()
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.ak.a()
					});
					global::System.GC.Collect();
				}
				if (true)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00026BCC File Offset: 0x00025BCC
		public void b(global::CommunicationController.AutoCorrectionHandler A_0)
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
			this.a = A_0;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00026C10 File Offset: 0x00025C10
		public void a(global::CommunicationController.AutoCorrectionHandler A_0)
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
			this.a = null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00026C54 File Offset: 0x00025C54
		public void a(string A_0, global::System.Collections.ArrayList A_1, global::constants.CCPTags.SetProgressBar A_2, int A_3, string A_4, string A_5)
		{
			switch (0)
			{
			default:
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				}
				if (false)
				{
				}
				this.n = A_4;
				global::UpdateController.a a = this.b(A_5);
				for (;;)
				{
					try
					{
						a.a(A_2, A_3);
						goto IL_4A;
					}
					catch (global::custom_exception.CCustomException)
					{
						throw;
					}
					catch (global::System.Exception)
					{
						throw;
					}
					break;
					try
					{
						try
						{
							IL_4A:
							a.a(A_0);
							int iPercentage = (int)global::System.Math.Floor((double)A_3 / (double)A_1.Count);
							global::System.Collections.IEnumerator enumerator = A_1.GetEnumerator();
							try
							{
								int num = 5;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_150;
									case 1:
										num = 0;
										continue;
									case 2:
									{
										global::DeviceUpdate.c.b a_;
										if (a_.d)
										{
											num = 9;
											continue;
										}
										goto IL_C7;
									}
									case 4:
									{
										global::DeviceUpdate.c.b a_;
										if (!string.IsNullOrEmpty(a_.a))
										{
											num = 7;
											continue;
										}
										goto IL_C7;
									}
									case 7:
									{
										global::DeviceUpdate.c.b a_;
										this.b(a, a_);
										num = 3;
										continue;
									}
									case 8:
									{
										if (!enumerator.MoveNext())
										{
											num = 1;
											continue;
										}
										global::DeviceUpdate.c.b a_ = (global::DeviceUpdate.c.b)enumerator.Current;
										num = 2;
										continue;
									}
									case 9:
										num = 4;
										continue;
									}
									IL_AA:
									num = 8;
									continue;
									goto IL_AA;
									IL_C7:
									A_2(iPercentage);
									num = 6;
								}
								IL_150:;
							}
							finally
							{
								for (;;)
								{
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									int num = 0;
									for (;;)
									{
										switch (num)
										{
										case 0:
											if (disposable != null)
											{
												num = 1;
												continue;
											}
											goto IL_19A;
										case 1:
											disposable.Dispose();
											num = 2;
											continue;
										case 2:
											goto IL_198;
										}
										break;
									}
								}
								IL_198:
								IL_19A:;
							}
							a.h();
							A_2(A_3 % A_1.Count);
						}
						catch (global::custom_exception.CCustomException)
						{
							throw;
						}
						catch (global::System.Exception ex)
						{
							if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
							{
								ex.Source = 2918U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
							}
							throw;
						}
						break;
					}
					finally
					{
						if (true)
						{
						}
						this.a(a);
						global::System.GC.Collect();
					}
				}
				return;
			}
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00026F10 File Offset: 0x00025F10
		public void b(string A_0, bool A_1, global::System.Collections.ArrayList A_2, global::constants.CCPTags.SetProgressBar A_3, int A_4, global::CommunicationController.ISerialTransportController A_5, uint A_6, string A_7)
		{
			switch (0)
			{
			default:
			{
				this.c.a(global::IshHandler.i.c);
				this.l = A_0;
				this.aa = A_1;
				global::UpdateController.a a = new global::UpdateController.a(this.a());
				for (;;)
				{
					try
					{
						a.a(A_6, A_5.GetPointer());
						a.a(A_3, A_4);
						goto IL_39;
					}
					catch (global::custom_exception.CCustomException)
					{
						throw;
					}
					catch (global::System.Exception)
					{
						throw;
					}
					break;
					try
					{
						try
						{
							IL_39:
							string text;
							for (;;)
							{
								bool a_ = false;
								bool a_2 = true;
								bool a_3 = false;
								bool a_4 = false;
								global::System.Collections.IEnumerator enumerator = A_2.GetEnumerator();
								int num = 5;
								for (;;)
								{
									IL_3B:
									switch (num)
									{
									case 0:
										goto IL_E4;
									case 1:
										num = 3;
										continue;
									case 2:
										goto IL_380;
									case 3:
										while (text.Equals(A_7))
										{
											a.h();
											a.d();
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												if (false)
												{
												}
												num = 6;
												goto IL_3B;
											}
										}
										num = 0;
										continue;
									case 4:
										if (!string.IsNullOrEmpty(text))
										{
											num = 1;
											continue;
										}
										goto IL_7D;
									case 5:
									{
										try
										{
											num = 21;
											for (;;)
											{
												switch (num)
												{
												case 0:
												{
													global::DeviceUpdate.c.b b;
													if (b.b == global::DeviceUpdate.c.a.d)
													{
														num = 6;
														continue;
													}
													break;
												}
												case 2:
												{
													global::DeviceUpdate.c.b b;
													if (b.j)
													{
														num = 9;
														continue;
													}
													goto IL_2FC;
												}
												case 3:
													num = 12;
													continue;
												case 4:
												{
													global::DeviceUpdate.c.b b;
													if (b.d)
													{
														num = 14;
														continue;
													}
													break;
												}
												case 6:
													num = 15;
													continue;
												case 7:
													num = 19;
													continue;
												case 9:
													a_ = true;
													num = 1;
													continue;
												case 10:
													a_4 = true;
													num = 8;
													continue;
												case 11:
												{
													global::DeviceUpdate.c.b b;
													if (!string.IsNullOrEmpty(b.a))
													{
														num = 13;
														continue;
													}
													break;
												}
												case 12:
													goto IL_332;
												case 13:
													num = 22;
													continue;
												case 14:
													num = 11;
													continue;
												case 15:
												{
													global::DeviceUpdate.c.b b;
													if (b.j)
													{
														num = 10;
														continue;
													}
													break;
												}
												case 16:
													a_3 = true;
													num = 5;
													continue;
												case 17:
													num = 2;
													continue;
												case 18:
												{
													if (!enumerator.MoveNext())
													{
														num = 3;
														continue;
													}
													global::DeviceUpdate.c.b b = (global::DeviceUpdate.c.b)enumerator.Current;
													num = 4;
													continue;
												}
												case 19:
												{
													global::DeviceUpdate.c.b b;
													if (b.j)
													{
														num = 16;
														continue;
													}
													goto IL_1F1;
												}
												case 20:
												{
													global::DeviceUpdate.c.b b;
													if (b.b == global::DeviceUpdate.c.a.c)
													{
														num = 17;
														continue;
													}
													goto IL_2FC;
												}
												case 22:
												{
													global::DeviceUpdate.c.b b;
													if (b.b == global::DeviceUpdate.c.a.b)
													{
														num = 7;
														continue;
													}
													goto IL_1F1;
												}
												}
												goto IL_17B;
												IL_1F1:
												num = 20;
												continue;
												IL_27C:
												num = 18;
												continue;
												IL_17B:
												goto IL_27C;
												IL_2FC:
												num = 0;
											}
											IL_332:
											goto IL_E6;
										}
										finally
										{
											for (;;)
											{
												global::System.IDisposable disposable = enumerator as global::System.IDisposable;
												num = 2;
												for (;;)
												{
													switch (num)
													{
													case 0:
														goto IL_37D;
													case 1:
														disposable.Dispose();
														num = 0;
														continue;
													case 2:
														if (disposable != null)
														{
															num = 1;
															continue;
														}
														goto IL_37F;
													}
													break;
												}
											}
											IL_37D:
											IL_37F:;
										}
										goto Block_6;
										IL_E6:
										this.a(a, true, a_, a_2, a_3, false, a_4);
										global::System.Collections.IEnumerator enumerator2 = A_2.GetEnumerator();
										num = 2;
										continue;
									}
									case 6:
										goto IL_4FB;
									}
									break;
									Block_6:
									try
									{
										IL_380:
										num = 6;
										for (;;)
										{
											switch (num)
											{
											case 0:
											{
												global::System.Collections.IEnumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = 3;
													continue;
												}
												global::DeviceUpdate.c.b a_5 = (global::DeviceUpdate.c.b)enumerator2.Current;
												num = 2;
												continue;
											}
											case 2:
											{
												global::DeviceUpdate.c.b a_5;
												if (a_5.d)
												{
													num = 7;
													continue;
												}
												break;
											}
											case 3:
												num = 4;
												continue;
											case 4:
												goto IL_44B;
											case 5:
											{
												global::DeviceUpdate.c.b a_5;
												if (!string.IsNullOrEmpty(a_5.a))
												{
													num = 8;
													continue;
												}
												break;
											}
											case 7:
												num = 5;
												continue;
											case 8:
											{
												global::DeviceUpdate.c.b a_5;
												this.b(a, a_5);
												num = 1;
												continue;
											}
											}
											IL_41C:
											num = 0;
											continue;
											goto IL_41C;
										}
										IL_44B:;
									}
									finally
									{
										for (;;)
										{
											global::System.Collections.IEnumerator enumerator2;
											global::System.IDisposable disposable2 = enumerator2 as global::System.IDisposable;
											num = 1;
											for (;;)
											{
												switch (num)
												{
												case 0:
													disposable2.Dispose();
													num = 2;
													continue;
												case 1:
													if (disposable2 != null)
													{
														num = 0;
														continue;
													}
													goto IL_495;
												case 2:
													goto IL_493;
												}
												break;
											}
										}
										IL_493:
										IL_495:;
									}
									text = a.c();
									num = 4;
								}
							}
							IL_7D:
							global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2948U, "DeviceUpdate", "UpdateNANDDevice", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
							string message = string.Format("SN: Previous {0};  Current {1}", A_7, text);
							ex.AddErrorMessage(message);
							throw ex;
							IL_E4:
							goto IL_7D;
							IL_4FB:;
						}
						catch (global::custom_exception.CCustomException)
						{
							this.a(a);
							throw;
						}
						catch (global::System.Exception ex2)
						{
							this.a(a);
							if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
							{
								ex2.Source = 2918U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
							}
							throw;
						}
						break;
					}
					finally
					{
						global::System.Collections.IEnumerator enumerator3 = A_2.GetEnumerator();
						try
						{
							int num = 3;
							for (;;)
							{
								switch (num)
								{
								case 0:
								{
									if (!enumerator3.MoveNext())
									{
										num = 2;
										continue;
									}
									global::DeviceUpdate.c.b b2 = (global::DeviceUpdate.c.b)enumerator3.Current;
									global::DeviceUpdate.c.a(new string[]
									{
										b2.a
									});
									num = 4;
									continue;
								}
								case 1:
									goto IL_5E2;
								case 2:
									num = 1;
									continue;
								}
								IL_581:
								if (true)
								{
								}
								num = 0;
								continue;
								goto IL_581;
							}
							IL_5E2:;
						}
						finally
						{
							for (;;)
							{
								global::System.IDisposable disposable3 = enumerator3 as global::System.IDisposable;
								int num = 0;
								for (;;)
								{
									switch (num)
									{
									case 0:
										if (disposable3 != null)
										{
											num = 1;
											continue;
										}
										goto IL_62C;
									case 1:
										disposable3.Dispose();
										num = 2;
										continue;
									case 2:
										goto IL_62A;
									}
									break;
								}
							}
							IL_62A:
							IL_62C:;
						}
					}
				}
				return;
			}
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00027640 File Offset: 0x00026640
		public void a(string A_0, bool A_1, global::System.Collections.ArrayList A_2, global::constants.CCPTags.SetProgressBar A_3, int A_4, global::CommunicationController.ISerialTransportController A_5, uint A_6, string A_7, string A_8)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				this.c.a(global::IshHandler.i.c);
				this.l = A_0;
				this.aa = A_1;
				global::UpdateController.a a = new global::UpdateController.a(this.a());
				for (;;)
				{
					try
					{
						a.a(A_6, A_5.GetPointer(), global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio);
						a.a(A_3, A_4);
						goto IL_4B;
					}
					catch (global::custom_exception.CCustomException)
					{
						throw;
					}
					catch (global::System.Exception)
					{
						throw;
					}
					break;
					try
					{
						try
						{
							IL_4B:
							string text;
							for (;;)
							{
								bool a_ = false;
								bool a_2 = true;
								bool a_3 = false;
								bool a_4 = false;
								global::System.Collections.IEnumerator enumerator = A_2.GetEnumerator();
								int num = 2;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_392;
									case 1:
										if (!string.IsNullOrEmpty(text))
										{
											num = 5;
											continue;
										}
										goto IL_8F;
									case 2:
									{
										try
										{
											num = 9;
											for (;;)
											{
												switch (num)
												{
												case 0:
												{
													global::DeviceUpdate.c.b b;
													if (b.b == global::DeviceUpdate.c.a.d)
													{
														num = 1;
														continue;
													}
													break;
												}
												case 1:
													num = 11;
													continue;
												case 2:
													a_4 = true;
													num = 13;
													continue;
												case 3:
												{
													global::DeviceUpdate.c.b b;
													if (!string.IsNullOrEmpty(b.a))
													{
														num = 19;
														continue;
													}
													break;
												}
												case 4:
													a_ = true;
													num = 6;
													continue;
												case 5:
													num = 12;
													continue;
												case 7:
												{
													global::DeviceUpdate.c.b b;
													if (b.j)
													{
														num = 17;
														continue;
													}
													goto IL_203;
												}
												case 8:
													num = 3;
													continue;
												case 10:
												{
													if (!enumerator.MoveNext())
													{
														num = 20;
														continue;
													}
													global::DeviceUpdate.c.b b = (global::DeviceUpdate.c.b)enumerator.Current;
													num = 21;
													continue;
												}
												case 11:
												{
													global::DeviceUpdate.c.b b;
													if (b.j)
													{
														num = 2;
														continue;
													}
													break;
												}
												case 12:
												{
													global::DeviceUpdate.c.b b;
													if (b.j)
													{
														num = 4;
														continue;
													}
													goto IL_30E;
												}
												case 14:
													goto IL_344;
												case 15:
													num = 7;
													continue;
												case 16:
												{
													global::DeviceUpdate.c.b b;
													if (b.b == global::DeviceUpdate.c.a.c)
													{
														num = 5;
														continue;
													}
													goto IL_30E;
												}
												case 17:
													a_3 = true;
													num = 22;
													continue;
												case 18:
												{
													global::DeviceUpdate.c.b b;
													if (b.b == global::DeviceUpdate.c.a.b)
													{
														num = 15;
														continue;
													}
													goto IL_203;
												}
												case 19:
													num = 18;
													continue;
												case 20:
													num = 14;
													continue;
												case 21:
												{
													global::DeviceUpdate.c.b b;
													if (b.d)
													{
														num = 8;
														continue;
													}
													break;
												}
												}
												goto IL_18D;
												IL_203:
												num = 16;
												continue;
												IL_28E:
												num = 10;
												continue;
												IL_18D:
												goto IL_28E;
												IL_30E:
												num = 0;
											}
											IL_344:
											goto IL_F8;
										}
										finally
										{
											for (;;)
											{
												global::System.IDisposable disposable = enumerator as global::System.IDisposable;
												num = 1;
												for (;;)
												{
													switch (num)
													{
													case 0:
														goto IL_38F;
													case 1:
														if (disposable != null)
														{
															num = 2;
															continue;
														}
														goto IL_391;
													case 2:
														disposable.Dispose();
														num = 0;
														continue;
													}
													break;
												}
											}
											IL_38F:
											IL_391:;
										}
										goto Block_6;
										IL_F8:
										this.a(a, a_, a_2, a_3, a_4, A_8);
										global::System.Collections.IEnumerator enumerator2 = A_2.GetEnumerator();
										num = 0;
										continue;
									}
									case 3:
										goto IL_4F3;
									case 4:
										if (!text.Equals(A_7))
										{
											num = 6;
											continue;
										}
										a.c(A_8);
										a.d();
										num = 3;
										continue;
									case 5:
										num = 4;
										continue;
									case 6:
										goto IL_F6;
									}
									break;
									Block_6:
									try
									{
										IL_392:
										num = 8;
										for (;;)
										{
											switch (num)
											{
											case 0:
											{
												global::DeviceUpdate.c.b a_5;
												this.b(a, a_5);
												num = 6;
												continue;
											}
											case 1:
												num = 4;
												continue;
											case 2:
												num = 5;
												continue;
											case 3:
											{
												global::DeviceUpdate.c.b a_5;
												if (a_5.d)
												{
													num = 2;
													continue;
												}
												break;
											}
											case 4:
												goto IL_45D;
											case 5:
											{
												global::DeviceUpdate.c.b a_5;
												if (!string.IsNullOrEmpty(a_5.a))
												{
													num = 0;
													continue;
												}
												break;
											}
											case 7:
											{
												global::System.Collections.IEnumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = 1;
													continue;
												}
												global::DeviceUpdate.c.b a_5 = (global::DeviceUpdate.c.b)enumerator2.Current;
												num = 3;
												continue;
											}
											}
											IL_42E:
											num = 7;
											continue;
											goto IL_42E;
										}
										IL_45D:;
									}
									finally
									{
										for (;;)
										{
											global::System.Collections.IEnumerator enumerator2;
											global::System.IDisposable disposable2 = enumerator2 as global::System.IDisposable;
											num = 1;
											for (;;)
											{
												switch (num)
												{
												case 0:
													disposable2.Dispose();
													num = 2;
													continue;
												case 1:
													if (disposable2 != null)
													{
														num = 0;
														continue;
													}
													goto IL_4A7;
												case 2:
													goto IL_4A5;
												}
												break;
											}
										}
										IL_4A5:
										IL_4A7:;
									}
									text = a.c();
									num = 1;
								}
							}
							IL_8F:
							global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2948U, "DeviceUpdate", "UpdateBahamaDevice", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
							string message = string.Format("SN: Previous {0};  Current {1}", A_7, text);
							ex.AddErrorMessage(message);
							throw ex;
							IL_F6:
							goto IL_8F;
							IL_4F3:;
						}
						catch (global::custom_exception.CCustomException)
						{
							this.a(a);
							throw;
						}
						catch (global::System.Exception ex2)
						{
							this.a(a);
							if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
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
									ex2.Source = 2918U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
									break;
								}
							}
							throw;
						}
						break;
					}
					finally
					{
						global::System.Collections.IEnumerator enumerator3 = A_2.GetEnumerator();
						try
						{
							int num = 0;
							for (;;)
							{
								switch (num)
								{
								case 1:
									goto IL_5EE;
								case 3:
								{
									if (!enumerator3.MoveNext())
									{
										num = 4;
										continue;
									}
									global::DeviceUpdate.c.b b2 = (global::DeviceUpdate.c.b)enumerator3.Current;
									global::DeviceUpdate.c.a(new string[]
									{
										b2.a
									});
									num = 2;
									continue;
								}
								case 4:
									num = 1;
									continue;
								}
								IL_595:
								num = 3;
								continue;
								goto IL_595;
							}
							IL_5EE:;
						}
						finally
						{
							for (;;)
							{
								global::System.IDisposable disposable3 = enumerator3 as global::System.IDisposable;
								int num = 2;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_636;
									case 1:
										disposable3.Dispose();
										num = 0;
										continue;
									case 2:
										if (disposable3 != null)
										{
											num = 1;
											continue;
										}
										goto IL_638;
									}
									break;
								}
							}
							IL_636:
							IL_638:;
						}
					}
				}
				return;
			}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00027D74 File Offset: 0x00026D74
		public global::DeviceUpdate.d a(uint A_0, global::CommunicationController.ISerialTransportController A_1)
		{
			global::DeviceUpdate.d result;
			try
			{
				global::Motorola.Common.Communication.Service.IDeviceOperation dsc = A_1[A_0].DSC;
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo = A_1[A_0].DevInfo;
				byte b = dsc.QueryRadioUpdateStatus(devInfo);
				result = (global::DeviceUpdate.d)b;
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.QueryRadioStatusFailure)
				{
					throw ex;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					break;
				}
				if (true)
				{
				}
				result = global::DeviceUpdate.d.g;
			}
			catch (global::System.Exception ex2)
			{
				throw ex2;
			}
			return result;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00027E14 File Offset: 0x00026E14
		public void a(string A_0, bool A_1, global::System.Collections.ArrayList A_2, global::constants.CCPTags.SetProgressBar A_3, int A_4, global::CommunicationController.ISerialTransportController A_5, uint A_6, string A_7)
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
			this.a(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, string.Empty);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00027E68 File Offset: 0x00026E68
		public void a(object A_0, global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo A_1, string A_2, bool A_3, global::System.Collections.ArrayList A_4, global::constants.CCPTags.SetProgressBar A_5, int A_6, string A_7, out object A_8)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					this.c.a(global::IshHandler.i.c);
					A_8 = null;
					this.l = A_2;
					this.aa = A_3;
					global::UpdateController.a a = new global::UpdateController.a(this.a());
					a.a(A_0 as global::Motorola.Common.Communication.Pba.PbaObject, A_1);
					global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
					a.a(pbaObject);
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_5A3;
						case 1:
							if (A_5 != null)
							{
								num = 2;
								continue;
							}
							goto IL_95;
						case 2:
							num = 3;
							continue;
						case 3:
							if (A_6 > 0)
							{
								num = 0;
								continue;
							}
							goto IL_95;
						case 4:
							goto IL_95;
						}
						break;
						IL_5A3:
						a.a(A_5, A_6);
						num = 4;
						continue;
						try
						{
							try
							{
								IL_95:
								for (;;)
								{
									global::System.Collections.IEnumerator enumerator = A_4.GetEnumerator();
									num = 18;
									for (;;)
									{
										bool flag;
										bool flag2;
										global::System.Collections.Hashtable a_2;
										switch (num)
										{
										case 0:
											this.a(ref pbaObject, A_1);
											num = 14;
											continue;
										case 1:
										{
											global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = pbaObject.UpdateData.MemoryImages;
											if (global::DeviceUpdate.c.am == null)
											{
												global::DeviceUpdate.c.am = new global::System.Predicate<global::Motorola.Common.Communication.Pba.RadioImage>(global::DeviceUpdate.c.c);
											}
											if (memoryImages.FindAll(global::DeviceUpdate.c.am).Count <= 0)
											{
												num = 8;
												continue;
											}
											num = 9;
											continue;
										}
										case 2:
											if (flag)
											{
												num = 12;
												continue;
											}
											goto IL_46D;
										case 3:
											flag2 = true;
											goto IL_394;
										case 4:
										{
											global::Motorola.Common.Communication.Pba.FileSet fileSet;
											if (fileSet != null)
											{
												num = 17;
												continue;
											}
											goto IL_2FA;
										}
										case 5:
										{
											global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet> fileSetList = (A_0 as global::Motorola.Common.Communication.Pba.PbaObject).FileSetList;
											if (global::DeviceUpdate.c.an == null)
											{
												global::DeviceUpdate.c.an = new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::DeviceUpdate.c.b);
											}
											global::Motorola.Common.Communication.Pba.FileSet fileSet = fileSetList.Find(global::DeviceUpdate.c.an);
											num = 4;
											continue;
										}
										case 6:
											goto IL_46D;
										case 7:
											goto IL_47D;
										case 8:
											num = 3;
											continue;
										case 9:
											flag2 = false;
											goto IL_394;
										case 10:
											if (!flag)
											{
												num = 11;
												continue;
											}
											goto IL_344;
										case 11:
											num = 5;
											continue;
										case 12:
											pbaObject.CodeplugData = global::CommunicationController.ObjectSerializer.BinaryCloneInstance<global::Motorola.Common.Communication.Pba.PackedRadioData>((A_0 as global::Motorola.Common.Communication.Pba.PbaObject).CodeplugData);
											pbaObject.FileSetList = global::CommunicationController.ObjectSerializer.BinaryCloneInstance<global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet>>((A_0 as global::Motorola.Common.Communication.Pba.PbaObject).FileSetList);
											num = 6;
											continue;
										case 13:
											if (this.a != null)
											{
												num = 0;
												continue;
											}
											goto IL_344;
										case 14:
											goto IL_344;
										case 15:
											goto IL_2FA;
										case 16:
										{
											global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet> fileSetList2 = pbaObject.FileSetList;
											if (global::DeviceUpdate.c.ao == null)
											{
												global::DeviceUpdate.c.ao = new global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet>(global::DeviceUpdate.c.a);
											}
											fileSetList2.RemoveAll(global::DeviceUpdate.c.ao);
											global::Motorola.Common.Communication.Pba.FileSet item;
											pbaObject.FileSetList.Add(item);
											num = 15;
											continue;
										}
										case 17:
										{
											global::Motorola.Common.Communication.Pba.FileSet fileSet;
											global::Motorola.Common.Communication.Pba.FileSet item = global::CommunicationController.ObjectSerializer.BinaryCloneInstance<global::Motorola.Common.Communication.Pba.FileSet>(fileSet);
											num = 16;
											continue;
										}
										case 18:
											try
											{
												num = 7;
												for (;;)
												{
													switch (num)
													{
													case 0:
														num = 5;
														continue;
													case 1:
														num = 4;
														continue;
													case 3:
													{
														global::DeviceUpdate.c.b a_;
														if (a_.d)
														{
															num = 0;
															continue;
														}
														break;
													}
													case 4:
														goto IL_290;
													case 5:
													{
														global::DeviceUpdate.c.b a_;
														if (!string.IsNullOrEmpty(a_.a))
														{
															num = 6;
															continue;
														}
														break;
													}
													case 6:
													{
														global::DeviceUpdate.c.b a_;
														this.b(a, a_);
														num = 2;
														continue;
													}
													case 8:
													{
														if (!enumerator.MoveNext())
														{
															num = 1;
															continue;
														}
														global::DeviceUpdate.c.b a_ = (global::DeviceUpdate.c.b)enumerator.Current;
														num = 3;
														continue;
													}
													}
													IL_24B:
													num = 8;
													continue;
													goto IL_24B;
												}
												IL_290:
												goto IL_18E;
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
															switch ((1 == 1) ? 1 : 0)
															{
															case 0:
															case 2:
																goto IL_2F9;
															default:
																if (false)
																{
																}
																if (disposable != null)
																{
																	num = 1;
																	continue;
																}
																goto IL_2F9;
															}
															break;
														case 1:
															disposable.Dispose();
															num = 2;
															continue;
														case 2:
															goto IL_2F7;
														}
														break;
													}
												}
												IL_2F7:
												IL_2F9:;
											}
											goto IL_2FA;
											IL_18E:
											a_2 = new global::System.Collections.Hashtable();
											this.a(ref pbaObject, ref a_2);
											flag = true;
											num = 1;
											continue;
										}
										break;
										IL_2FA:
										num = 13;
										continue;
										IL_344:
										this.a(ref pbaObject, a_2);
										num = 2;
										continue;
										IL_394:
										flag = flag2;
										num = 10;
										continue;
										IL_46D:
										A_8 = pbaObject;
										num = 7;
									}
								}
								IL_47D:
								if (true)
								{
								}
							}
							catch (global::custom_exception.CCustomException)
							{
								throw;
							}
							catch (global::System.Exception ex)
							{
								if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
								{
									ex.Source = 2918U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
								}
								throw;
							}
							return;
						}
						finally
						{
							global::System.Collections.IEnumerator enumerator2 = A_4.GetEnumerator();
							try
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
										goto IL_557;
									case 2:
									{
										if (!enumerator2.MoveNext())
										{
											num = 3;
											continue;
										}
										global::DeviceUpdate.c.b b = (global::DeviceUpdate.c.b)enumerator2.Current;
										global::DeviceUpdate.c.a(new string[]
										{
											b.a
										});
										num = 4;
										continue;
									}
									case 3:
										num = 1;
										continue;
									}
									IL_4FE:
									num = 2;
									continue;
									goto IL_4FE;
								}
								IL_557:;
							}
							finally
							{
								for (;;)
								{
									global::System.IDisposable disposable2 = enumerator2 as global::System.IDisposable;
									num = 1;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_59F;
										case 1:
											if (disposable2 != null)
											{
												num = 2;
												continue;
											}
											goto IL_5A1;
										case 2:
											disposable2.Dispose();
											num = 0;
											continue;
										}
										break;
									}
								}
								IL_59F:
								IL_5A1:;
							}
						}
						goto IL_5A3;
					}
				}
				return;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000284D4 File Offset: 0x000274D4
		public void a(ref global::Motorola.Common.Communication.Pba.PbaObject A_0, global::System.Collections.Hashtable A_1)
		{
			switch (0)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator;
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>();
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
							num = 2;
							continue;
						case 1:
							goto IL_AA;
						case 2:
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = A_0.UpdateData.MemoryImages;
							if (global::DeviceUpdate.c.ap == null)
							{
								global::DeviceUpdate.c.ap = new global::System.Predicate<global::Motorola.Common.Communication.Pba.RadioImage>(global::DeviceUpdate.c.b);
							}
							list = memoryImages.FindAll(global::DeviceUpdate.c.ap);
							enumerator = list.GetEnumerator();
							if (true)
							{
							}
							num = 1;
							continue;
						}
						case 3:
							if (A_0 != null)
							{
								num = 0;
								continue;
							}
							return;
						}
						break;
					}
				}
				IL_AA:
				try
				{
					int num = 9;
					for (;;)
					{
						global::System.IO.FileStream fileStream;
						string text;
						global::System.Collections.ArrayList arrayList;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
						switch (num)
						{
						case 0:
						{
							global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType;
							if (fileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_APP)
							{
								num = 21;
								continue;
							}
							c.a = 128;
							byte a_ = 1;
							num = 13;
							continue;
						}
						case 1:
							goto IL_16F;
						case 2:
							goto IL_16F;
						case 3:
							goto IL_2F0;
						case 4:
							num = 6;
							continue;
						case 5:
							try
							{
								global::Motorola.Common.Communication.Pba.RadioImage radioImage;
								radioImage.fileData = new byte[fileStream.Length];
								fileStream.Read(radioImage.fileData, 0, radioImage.fileData.Length);
								fileStream.Close();
								goto IL_1B4;
							}
							finally
							{
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_3B3;
										default:
											if (false)
											{
											}
											((global::System.IDisposable)fileStream).Dispose();
											num = 2;
											continue;
										}
										break;
									case 2:
										goto IL_3EA;
									}
									goto IL_3AF;
									IL_3B3:
									num = 0;
									continue;
									IL_3AF:
									if (fileStream != null)
									{
										goto IL_3B3;
									}
									break;
								}
								IL_3EA:;
							}
							break;
							IL_1B4:
							num = 28;
							continue;
						case 6:
							goto IL_16F;
						case 7:
						{
							global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType;
							if (fileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CP_CFS)
							{
								num = 4;
								continue;
							}
							c.a = 135;
							byte a_ = 3;
							num = 2;
							continue;
						}
						case 8:
							goto IL_16F;
						case 10:
							goto IL_5FC;
						case 12:
						{
							global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType;
							switch (fileType)
							{
							case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC:
							{
								c.a = 129;
								byte a_ = 0;
								num = 8;
								continue;
							}
							case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE:
							{
								c.a = 130;
								byte a_ = 2;
								num = 1;
								continue;
							}
							default:
								num = 16;
								continue;
							}
							break;
						}
						case 13:
							goto IL_16F;
						case 14:
							global::System.IO.File.Delete(text);
							num = 11;
							continue;
						case 15:
							goto IL_153;
						case 16:
							num = 7;
							continue;
						case 17:
							if (arrayList.Count > 0)
							{
								num = 22;
								continue;
							}
							break;
						case 18:
						{
							byte a_;
							this.c.a(arrayList, text, (uint)a_);
							num = 19;
							continue;
						}
						case 19:
							goto IL_153;
						case 20:
							try
							{
								num = 3;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_593;
									case 2:
									{
										if (!enumerator2.MoveNext())
										{
											num = 4;
											continue;
										}
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock = enumerator2.Current;
										global::IshHandler.m m = default(global::IshHandler.m);
										m.a = (ushort)((dataBlock.BlockType >> 8 & 255) | ((int)dataBlock.BlockType << 8 & 65280));
										m.b = (ushort)((dataBlock.BlockID >> 8 & 255) | ((int)dataBlock.BlockID << 8 & 65280));
										m.c = new byte[dataBlock.PacketValue.Length];
										global::System.Array.Copy(dataBlock.PacketValue, m.c, dataBlock.PacketValue.Length);
										arrayList.Add(m);
										num = 1;
										continue;
									}
									case 4:
										num = 0;
										continue;
									}
									IL_4B5:
									num = 2;
									continue;
									goto IL_4B5;
								}
								IL_593:
								goto IL_5C7;
							}
							finally
							{
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_5A3;
							IL_5C7:
							num = 17;
							continue;
						case 21:
							num = 12;
							continue;
						case 22:
						{
							global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings = new global::RegistryAccess.CPersistentApplicationSettings();
							text = string.Empty;
							persistentApplicationSettings.GetXferFolderPath(ref text);
							num = 25;
							continue;
						}
						case 23:
							num = 10;
							continue;
						case 24:
							goto IL_5A3;
						case 25:
							if (text[text.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
							{
								num = 24;
								continue;
							}
							goto IL_2F0;
						case 26:
						{
							if (this.n == "AF5DAB63F4FC4926BB9000A6F18AF3DC")
							{
								num = 18;
								continue;
							}
							byte a_;
							this.c.a(arrayList, text, (uint)a_, A_1);
							num = 15;
							continue;
						}
						case 27:
						{
							if (!enumerator.MoveNext())
							{
								num = 23;
								continue;
							}
							global::Motorola.Common.Communication.Pba.RadioImage radioImage = enumerator.Current;
							byte a = 0;
							byte a_ = 0;
							global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType = radioImage.FileType;
							num = 0;
							continue;
						}
						case 28:
							if (global::System.IO.File.Exists(text))
							{
								num = 14;
								continue;
							}
							break;
						}
						goto IL_132;
						IL_153:
						fileStream = new global::System.IO.FileStream(text, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
						num = 5;
						continue;
						IL_16F:
						arrayList = new global::System.Collections.ArrayList();
						global::Motorola.Common.Communication.Pba.DataPartition dataPartition = A_0.CodeplugData.DataPartitions.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.DataPartition>(c.b));
						enumerator2 = dataPartition.DataBlocks.GetEnumerator();
						num = 20;
						continue;
						IL_2F0:
						text += global::System.Guid.NewGuid().ToString("D");
						num = 26;
						continue;
						IL_3ED:
						num = 27;
						continue;
						IL_132:
						goto IL_3ED;
						IL_5A3:
						text += global::System.IO.Path.DirectorySeparatorChar;
						num = 3;
					}
					IL_5FC:;
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
				return;
			}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00028B3C File Offset: 0x00027B3C
		public void a(ref global::Motorola.Common.Communication.Pba.PbaObject A_0, ref global::System.Collections.Hashtable A_1)
		{
			for (;;)
			{
				A_1.Clear();
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> list;
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_4B:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = A_0.UpdateData.MemoryImages;
					if (global::DeviceUpdate.c.aq == null)
					{
						global::DeviceUpdate.c.aq = new global::System.Predicate<global::Motorola.Common.Communication.Pba.RadioImage>(global::DeviceUpdate.c.a);
					}
					list = memoryImages.FindAll(global::DeviceUpdate.c.aq);
					num = 2;
					break;
				}
				default:
					if (false)
					{
					}
					num = 5;
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 0:
						try
						{
							num = 3;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_DF;
								case 1:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = 4;
										continue;
									}
									global::Motorola.Common.Communication.Pba.RadioImage radioImage = enumerator.Current;
									this.a(radioImage.FilePath, radioImage.FileType, ref A_0, ref A_1);
									num = 2;
									continue;
								}
								case 4:
									num = 0;
									continue;
								}
								IL_96:
								num = 1;
								continue;
								goto IL_96;
							}
							IL_DF:
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_F2;
					case 1:
					{
						A_0.CodeplugData.DataPartitions.Clear();
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator = list.GetEnumerator();
						num = 0;
						continue;
					}
					case 2:
						if (list != null)
						{
							num = 4;
							continue;
						}
						return;
					case 3:
						if (list.Count > 0)
						{
							num = 1;
							continue;
						}
						return;
					case 4:
						goto IL_F2;
					case 5:
						goto IL_4B;
					}
					break;
					IL_F2:
					if (true)
					{
					}
					num = 3;
				}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00028CD8 File Offset: 0x00027CD8
		private void a(string A_0, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType A_1, ref global::Motorola.Common.Communication.Pba.PbaObject A_2, ref global::System.Collections.Hashtable A_3)
		{
			switch (0)
			{
			default:
			{
				global::Motorola.Common.Communication.Pba.PackedRadioData codeplugData;
				global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
				for (;;)
				{
					global::System.Collections.ArrayList arrayList = this.c.a(A_0, ref A_3);
					codeplugData = A_2.CodeplugData;
					dataPartition = new global::Motorola.Common.Communication.Pba.DataPartition();
					int num = 10;
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						switch (num)
						{
						case 0:
							goto IL_86;
						case 1:
							goto IL_86;
						case 2:
							goto IL_86;
						case 3:
							switch (A_1)
							{
							case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC:
								dataPartition.PartitionID = 129;
								num = 2;
								continue;
							case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE:
								dataPartition.PartitionID = 130;
								num = 0;
								continue;
							default:
								num = 5;
								continue;
							}
							break;
						case 4:
							try
							{
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_1FD;
									case 3:
										num = 0;
										continue;
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = 3;
											continue;
										}
										global::IshHandler.m m = (global::IshHandler.m)enumerator.Current;
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock = new global::Motorola.Common.Communication.Pba.DataBlock();
										dataBlock.BlockType = (ushort)((m.a >> 8 & 255) | ((int)m.a << 8 & 65280));
										dataBlock.BlockID = (ushort)((m.b >> 8 & 255) | ((int)m.b << 8 & 65280));
										dataBlock.PacketValue = new byte[m.c.Length];
										dataBlock.LegthInBits = m.c.Length * 8;
										global::System.Array.Copy(m.c, dataBlock.PacketValue, m.c.Length);
										dataPartition.DataBlocks.Add(dataBlock);
										num = 2;
										continue;
									}
									}
									IL_10B:
									num = 4;
									continue;
									goto IL_10B;
								}
								IL_1FD:
								goto IL_305;
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
												num = 1;
												continue;
											}
											goto IL_266;
										case 1:
											for (;;)
											{
												disposable.Dispose();
												switch ((1 == 1) ? 1 : 0)
												{
												case 0:
												case 2:
													break;
												default:
													goto IL_255;
												}
											}
											IL_255:
											if (false)
											{
											}
											num = 2;
											continue;
										case 2:
											goto IL_264;
										}
										break;
									}
								}
								IL_264:
								IL_266:;
							}
							goto IL_267;
						case 5:
							num = 9;
							continue;
						case 6:
							num = 7;
							continue;
						case 7:
							goto IL_86;
						case 8:
							goto IL_267;
						case 9:
							if (A_1 != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CP_CFS)
							{
								num = 6;
								continue;
							}
							dataPartition.PartitionID = 135;
							num = 11;
							continue;
						case 10:
							if (A_1 != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_APP)
							{
								num = 8;
								continue;
							}
							dataPartition.PartitionID = 128;
							num = 1;
							continue;
						case 11:
							goto IL_86;
						}
						break;
						IL_86:
						if (true)
						{
						}
						enumerator = arrayList.GetEnumerator();
						num = 4;
						continue;
						IL_267:
						num = 3;
					}
				}
				IL_305:
				codeplugData.DataPartitions.Add(dataPartition);
				return;
			}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00029014 File Offset: 0x00028014
		private void b(global::UpdateController.a A_0, global::DeviceUpdate.c.b A_1)
		{
			try
			{
				try
				{
					switch (0)
					{
					default:
					{
						for (;;)
						{
							IL_DE:
							bool flag = false;
							int num = 31;
							for (;;)
							{
								string text;
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
									global::DeviceUpdate.c.a a;
									global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType a_;
									switch (num)
									{
									case 0:
										try
										{
											global::System.IO.StreamWriter streamWriter;
											string empty;
											streamWriter.Write(empty);
											streamWriter.Flush();
											goto IL_2BC;
										}
										finally
										{
											num = 2;
											for (;;)
											{
												global::System.IO.StreamWriter streamWriter;
												switch (num)
												{
												case 0:
													goto IL_20B;
												case 1:
													((global::System.IDisposable)streamWriter).Dispose();
													num = 0;
													continue;
												}
												if (streamWriter == null)
												{
													break;
												}
												num = 1;
											}
											IL_20B:;
										}
										goto IL_20E;
									case 1:
										goto IL_4B9;
									case 2:
										goto IL_4B9;
									case 3:
										goto IL_4B9;
									case 4:
										goto IL_4B9;
									case 5:
										goto IL_4B9;
									case 6:
										goto IL_4B9;
									case 7:
										switch (a)
										{
										case global::DeviceUpdate.c.a.a:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC;
											this.a(A_0, A_1);
											num = 10;
											continue;
										case global::DeviceUpdate.c.a.b:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_APP;
											this.a(A_0, A_1);
											num = 13;
											continue;
										case global::DeviceUpdate.c.a.c:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE;
											this.a(A_0, A_1);
											num = 34;
											continue;
										case global::DeviceUpdate.c.a.d:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CP_CFS;
											this.a(A_0, A_1);
											num = 4;
											continue;
										case global::DeviceUpdate.c.a.e:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_UDP;
											num = 33;
											continue;
										case global::DeviceUpdate.c.a.f:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CONFIGURATION;
											num = 2;
											continue;
										case global::DeviceUpdate.c.a.g:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT;
											num = 3;
											continue;
										case global::DeviceUpdate.c.a.h:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.KERNEL;
											num = 20;
											continue;
										case global::DeviceUpdate.c.a.i:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.L2;
											num = 16;
											continue;
										case global::DeviceUpdate.c.a.j:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.L3;
											num = 29;
											continue;
										case global::DeviceUpdate.c.a.k:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.RFS;
											num = 39;
											continue;
										case global::DeviceUpdate.c.a.l:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.APP;
											num = 38;
											continue;
										case global::DeviceUpdate.c.a.m:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.APP_UTILITIES;
											num = 5;
											continue;
										case global::DeviceUpdate.c.a.n:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PARTITION_TABLE;
											num = 1;
											continue;
										case global::DeviceUpdate.c.a.o:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CONTROL_HEAD;
											num = 18;
											continue;
										case global::DeviceUpdate.c.a.p:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.BLUETOOTH_GPS;
											num = 22;
											continue;
										case global::DeviceUpdate.c.a.q:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DATA_IMAGE;
											num = 25;
											continue;
										case global::DeviceUpdate.c.a.r:
											goto IL_20E;
										case global::DeviceUpdate.c.a.s:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.GLOBAL_MARKER;
											num = 27;
											continue;
										case global::DeviceUpdate.c.a.t:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FTL_APPSECCFS;
											num = 40;
											continue;
										case global::DeviceUpdate.c.a.u:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FTL_TUNING;
											num = 6;
											continue;
										case global::DeviceUpdate.c.a.v:
										case global::DeviceUpdate.c.a.w:
										case global::DeviceUpdate.c.a.x:
										case global::DeviceUpdate.c.a.y:
										case global::DeviceUpdate.c.a.z:
										case global::DeviceUpdate.c.a.aa:
										case global::DeviceUpdate.c.a.ab:
										case global::DeviceUpdate.c.a.ac:
										case global::DeviceUpdate.c.a.ad:
										case global::DeviceUpdate.c.a.ae:
											goto IL_4B9;
										case global::DeviceUpdate.c.a.af:
											a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSMARKER;
											num = 8;
											continue;
										default:
											num = 26;
											continue;
										}
										break;
									case 8:
										goto IL_4B9;
									case 9:
										goto IL_4EC;
									case 10:
										goto IL_4B9;
									case 11:
										if (flag)
										{
											num = 14;
											continue;
										}
										goto IL_2BC;
									case 12:
										num = 35;
										continue;
									case 13:
										goto IL_4B9;
									case 14:
										goto IL_50C;
									case 15:
										goto IL_5A2;
									case 16:
										goto IL_4B9;
									case 17:
										a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM;
										num = 32;
										continue;
									case 18:
										goto IL_4B9;
									case 19:
									{
										global::i.c c;
										if (c != global::i.c.c)
										{
											num = 41;
											continue;
										}
										global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(text, false);
										num = 0;
										continue;
									}
									case 20:
										goto IL_4B9;
									case 21:
										flag = false;
										num = 24;
										continue;
									case 22:
										goto IL_4B9;
									case 23:
										goto IL_4B9;
									case 24:
										goto IL_4EC;
									case 25:
										goto IL_4B9;
									case 26:
										num = 23;
										continue;
									case 27:
										goto IL_4B9;
									case 28:
										if (text != null)
										{
											num = 12;
											continue;
										}
										goto IL_3EA;
									case 29:
										goto IL_4B9;
									case 30:
										goto IL_4B9;
									case 31:
										if (!global::System.IO.File.Exists(A_1.a))
										{
											num = 21;
											continue;
										}
										flag = true;
										num = 9;
										continue;
									case 32:
										goto IL_586;
									case 33:
										goto IL_4B9;
									case 34:
										goto IL_4B9;
									case 35:
									{
										if (text.Length == 0)
										{
											num = 37;
											continue;
										}
										string empty = string.Empty;
										global::i.a(text, ref empty, A_1.c, global::i.a.c);
										global::i.c c = global::i.a(global::i.b.b, ref empty);
										num = 19;
										continue;
									}
									case 36:
										if (A_1.g == "AF5DAB63F4FC4926BB9000A6F18AF3DC")
										{
											num = 17;
											continue;
										}
										goto IL_586;
									case 37:
										goto IL_16E;
									case 38:
										goto IL_4B9;
									case 39:
										goto IL_4B9;
									case 40:
										goto IL_4B9;
									case 41:
										goto IL_2B7;
									}
									goto IL_DE;
									IL_20E:
									a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM;
									num = 30;
									continue;
									IL_2BC:
									a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.Unknown;
									a = A_1.b;
									num = 7;
									continue;
									IL_4B9:
									num = 36;
									continue;
									IL_4EC:
									num = 11;
									continue;
									IL_586:
									A_0.a(A_1.a, false, a_);
									num = 15;
									continue;
								}
								}
								IL_50C:
								text = A_1.a;
								num = 28;
							}
						}
						IL_16E:
						goto IL_3EA;
						IL_2B7:
						global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1835U, "DeviceUpdate", "UpdateSingleItem", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
						throw ex;
						IL_3EA:
						global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "UpdateSingleItem", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
						throw ex2;
						IL_5A2:
						break;
					}
					}
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.Exception ex3)
				{
					if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
					{
						ex3.Source = 2918U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
					}
					throw;
				}
				if (true)
				{
				}
			}
			finally
			{
				global::System.GC.Collect();
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00029684 File Offset: 0x00028684
		private byte[] a(string A_0)
		{
			switch (0)
			{
			default:
			{
				byte[] array;
				for (;;)
				{
					A_0 = A_0.Replace("\r\n", "");
					A_0 = A_0.Replace("\n", "");
					int num = A_0.Length / 2;
					array = new byte[num];
					int num2 = 0;
					int num3 = 0;
					int num4 = 2;
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (num2 != 0)
							{
								num4 = 6;
								continue;
							}
							return array;
						case 1:
							if (num3 >= num)
							{
								num4 = 5;
								continue;
							}
							array[num3 - num2] = global::System.Convert.ToByte(A_0.Substring(num3 * 2, 2), 16);
							num3++;
							goto IL_EE;
						case 2:
							goto IL_AC;
						case 3:
							if (true)
							{
							}
							goto IL_AC;
						case 4:
							return array;
						case 5:
							num4 = 0;
							continue;
						case 6:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_EE;
							default:
								if (false)
								{
								}
								global::System.Array.Resize<byte>(ref array, num - num2);
								num4 = 4;
								continue;
							}
							break;
						}
						break;
						IL_AC:
						num4 = 1;
						continue;
						IL_EE:
						num4 = 3;
					}
				}
				return array;
			}
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000297B0 File Offset: 0x000287B0
		private void a(global::UpdateController.a A_0, global::DeviceUpdate.c.b A_1)
		{
			switch (0)
			{
			default:
			{
				int num = 6;
				for (;;)
				{
					if (true)
					{
					}
					int a_;
					string a_2;
					global::System.Collections.ArrayList arrayList;
					string empty;
					switch (num)
					{
					case 0:
						if (A_1.b == global::DeviceUpdate.c.a.a)
						{
							num = 23;
							continue;
						}
						return;
					case 1:
						num = 22;
						continue;
					case 2:
					{
						global::DeviceUpdate.c.a a;
						switch (a)
						{
						case global::DeviceUpdate.c.a.a:
							a_ = 51;
							a_2 = "/opt/pcr/rel/data/codeplug/app_security/";
							num = 8;
							continue;
						case global::DeviceUpdate.c.a.b:
							a_ = 51;
							a_2 = "/opt/pcr/rel/data/codeplug/app_codeplug/";
							num = 15;
							continue;
						case global::DeviceUpdate.c.a.c:
							a_ = 50;
							a_2 = "/opt/pcr/rel/data/tuning/app_tuning/";
							num = 11;
							continue;
						case global::DeviceUpdate.c.a.d:
							a_ = 51;
							a_2 = "/opt/pcr/rel/data/codeplug/app_features/";
							num = 10;
							continue;
						default:
							num = 1;
							continue;
						}
						break;
					}
					case 3:
					{
						global::DeviceUpdate.c.a a2;
						switch (a2)
						{
						case global::DeviceUpdate.c.a.a:
							a_ = 51;
							a_2 = "B:\\activexx\\codeplug\\sec_cpg.db";
							num = 7;
							continue;
						case global::DeviceUpdate.c.a.b:
							a_ = 51;
							a_2 = "B:\\activexx\\codeplug\\app_cpg.db";
							num = 12;
							continue;
						case global::DeviceUpdate.c.a.c:
							a_ = 51;
							a_2 = "B:\\activexx\\codeplug\\tuning_cpg.db";
							num = 24;
							continue;
						case global::DeviceUpdate.c.a.d:
							goto IL_727;
						default:
							num = 21;
							continue;
						}
						break;
					}
					case 4:
						goto IL_778;
					case 5:
						try
						{
							num = 17;
							global::System.Collections.ArrayList arrayList2;
							global::System.Collections.ArrayList arrayList3;
							for (;;)
							{
								bool a_5;
								switch (num)
								{
								case 0:
									A_0.a(A_1.b, ref arrayList);
									num = 6;
									continue;
								case 1:
								{
									if (A_1.g == "AF5DAB63F4FC4926BB9000A6F18AF3DC")
									{
										num = 13;
										continue;
									}
									A_0.a(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM, a_, 0U, 0U, a_2, out empty, true);
									global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
									xmlDocument.Load(empty);
									global::System.Xml.XmlNodeList xmlNodeList = xmlDocument.DocumentElement.SelectNodes("//Partition[@Type='FileSystem']/Payload");
									global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
									num = 12;
									continue;
								}
								case 2:
									if (A_1.b == global::DeviceUpdate.c.a.a)
									{
										num = 15;
										continue;
									}
									goto IL_713;
								case 3:
									if (A_1.b == global::DeviceUpdate.c.a.c)
									{
										num = 5;
										continue;
									}
									goto IL_565;
								case 4:
									if (A_1.j)
									{
										num = 24;
										continue;
									}
									num = 7;
									continue;
								case 5:
									this.a(A_1, arrayList);
									num = 29;
									continue;
								case 6:
									if (arrayList.Count < 1)
									{
										num = 23;
										continue;
									}
									goto IL_449;
								case 7:
									if (A_1.b == global::DeviceUpdate.c.a.a)
									{
										num = 9;
										continue;
									}
									goto IL_713;
								case 8:
									if (A_1.g == "AF5DAB63F4FC4926BB9000A6F18AF3DC")
									{
										num = 31;
										continue;
									}
									this.b(A_1.a, arrayList);
									num = 16;
									continue;
								case 9:
									num = 8;
									continue;
								case 10:
									goto IL_71F;
								case 11:
									goto IL_70E;
								case 12:
									try
									{
										num = 4;
										for (;;)
										{
											switch (num)
											{
											case 0:
											{
												global::System.Collections.IEnumerator enumerator;
												if (!enumerator.MoveNext())
												{
													num = 2;
													continue;
												}
												global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
												string value = xmlNode.Attributes["Path"].Value;
												byte[] a_3 = this.a(xmlNode.InnerText);
												string text = global::System.IO.Path.GetFileNameWithoutExtension(value);
												text = text.Substring(2, 2) + text.Substring(0, 2);
												uint a_4 = uint.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
												this.c.a(a_4, a_3, ref arrayList);
												num = 1;
												continue;
											}
											case 2:
												num = 3;
												continue;
											case 3:
												goto IL_3E2;
											}
											IL_3B0:
											num = 0;
											continue;
											goto IL_3B0;
										}
										IL_3E2:;
									}
									finally
									{
										for (;;)
										{
											global::System.Collections.IEnumerator enumerator;
											global::System.IDisposable disposable = enumerator as global::System.IDisposable;
											num = 2;
											for (;;)
											{
												switch (num)
												{
												case 0:
													for (;;)
													{
														switch ((1 == 1) ? 1 : 0)
														{
														case 0:
														case 2:
															break;
														default:
															goto IL_430;
														}
													}
													IL_430:
													if (false)
													{
													}
													disposable.Dispose();
													num = 1;
													continue;
												case 1:
													goto IL_446;
												case 2:
													if (disposable != null)
													{
														num = 0;
														continue;
													}
													goto IL_448;
												}
												break;
											}
										}
										IL_446:
										IL_448:;
									}
									goto IL_449;
								case 13:
									A_0.a(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM, a_, 0U, 0U, a_2, out empty, false);
									this.c.a(empty, ref arrayList);
									num = 21;
									continue;
								case 14:
									arrayList2 = this.c.c(arrayList);
									num = 18;
									continue;
								case 15:
									arrayList3 = this.c.c(arrayList);
									num = 22;
									continue;
								case 16:
									goto IL_713;
								case 18:
									goto IL_565;
								case 19:
									goto IL_63A;
								case 20:
									goto IL_63A;
								case 21:
									goto IL_449;
								case 22:
									if (!arrayList3.Contains(arrayList2[0]))
									{
										num = 11;
										continue;
									}
									goto IL_713;
								case 23:
									num = 26;
									continue;
								case 24:
									num = 30;
									continue;
								case 25:
									a_5 = true;
									num = 20;
									continue;
								case 26:
									goto IL_5EC;
								case 27:
									if (A_1.b == global::DeviceUpdate.c.a.a)
									{
										num = 14;
										continue;
									}
									num = 3;
									continue;
								case 28:
									goto IL_713;
								case 29:
									goto IL_565;
								case 30:
									if (A_1.g == "AF5DAB63F4FC4926BB9000A6F18AF3DC")
									{
										num = 25;
										continue;
									}
									a_5 = false;
									num = 19;
									continue;
								case 31:
									this.a(A_1.a, arrayList);
									num = 28;
									continue;
								}
								if (A_0.f())
								{
									num = 0;
									continue;
								}
								num = 1;
								continue;
								IL_449:
								arrayList2 = null;
								num = 27;
								continue;
								IL_565:
								num = 4;
								continue;
								IL_63A:
								this.c.a(A_1, ref arrayList, this.l, this.aa, a_5);
								arrayList3 = null;
								num = 2;
								continue;
								IL_713:
								num = 10;
							}
							IL_5EC:
							return;
							IL_70E:
							global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2948U, "DeviceUpdate", "PreserveCPItem", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
							string message = string.Format("SN: previously {0}; after preserving {1}", arrayList2.ToArray().ToString(), arrayList3.ToArray().ToString());
							ex.AddErrorMessage(message);
							throw ex;
							IL_71F:
							return;
						}
						catch (global::System.Exception)
						{
							throw;
						}
						goto IL_727;
					case 7:
						goto IL_778;
					case 8:
						goto IL_778;
					case 9:
					{
						if (A_1.g == "AF5DAB63F4FC4926BB9000A6F18AF3DC")
						{
							num = 19;
							continue;
						}
						global::DeviceUpdate.c.a a = A_1.b;
						num = 2;
						continue;
					}
					case 10:
						goto IL_778;
					case 11:
						goto IL_778;
					case 12:
						goto IL_778;
					case 13:
						num = 17;
						continue;
					case 14:
						if (!A_1.j)
						{
							num = 13;
							continue;
						}
						goto IL_10F;
					case 15:
						goto IL_778;
					case 16:
						num = 14;
						continue;
					case 17:
						if (!A_1.j)
						{
							num = 18;
							continue;
						}
						return;
					case 18:
						num = 0;
						continue;
					case 19:
					{
						global::DeviceUpdate.c.a a2 = A_1.b;
						num = 3;
						continue;
					}
					case 20:
						goto IL_778;
					case 21:
						num = 20;
						continue;
					case 22:
						goto IL_778;
					case 23:
						goto IL_10F;
					case 24:
						goto IL_778;
					}
					if (!string.IsNullOrEmpty(A_1.e))
					{
						num = 16;
						continue;
					}
					break;
					IL_10F:
					arrayList = new global::System.Collections.ArrayList();
					a_ = 0;
					a_2 = string.Empty;
					num = 9;
					continue;
					IL_727:
					a_ = 51;
					a_2 = "B:\\activexx\\codeplug\\cfs_cpg.db";
					num = 4;
					continue;
					IL_778:
					empty = string.Empty;
					num = 5;
				}
				return;
			}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0002A054 File Offset: 0x00029054
		private void a(global::DeviceUpdate.c.b A_0, global::System.Collections.ArrayList A_1)
		{
			switch (0)
			{
			default:
			{
				string text2;
				string text3;
				for (;;)
				{
					string text = A_0.g;
					text2 = A_0.e.Replace(".", "");
					int num = 11;
					for (;;)
					{
						bool flag;
						switch (num)
						{
						case 0:
							num = 15;
							continue;
						case 1:
							if (!string.IsNullOrEmpty(text3))
							{
								num = 5;
								continue;
							}
							return;
						case 2:
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
								break;
							}
							num = 13;
							continue;
						case 3:
							num = 4;
							continue;
						case 4:
							if (!text.Equals("0571AFE244664F999A96B020E82DC69C", global::System.StringComparison.OrdinalIgnoreCase))
							{
								num = 2;
								continue;
							}
							goto IL_D9;
						case 5:
							num = 9;
							continue;
						case 6:
							goto IL_1E9;
						case 7:
							if (text.Equals("106F58B631044D63B41F0C0D7720758D", global::System.StringComparison.OrdinalIgnoreCase))
							{
								num = 14;
								continue;
							}
							return;
						case 8:
							text3 = this.c.b(A_1);
							num = 1;
							continue;
						case 9:
							if (!text2.Equals(text3, global::System.StringComparison.Ordinal))
							{
								num = 6;
								continue;
							}
							return;
						case 10:
							num = 7;
							continue;
						case 11:
							if (!string.IsNullOrEmpty(text))
							{
								num = 0;
								continue;
							}
							goto IL_D9;
						case 12:
							if (flag)
							{
								num = 8;
								continue;
							}
							return;
						case 13:
							if (!text.Equals("9F6C2442C375421981A8987115FC9ADE", global::System.StringComparison.OrdinalIgnoreCase))
							{
								num = 10;
								continue;
							}
							goto IL_D9;
						case 14:
							goto IL_D9;
						case 15:
							if (!text.Equals("0C78E1B906C54D3A8F264CE5C4F0B9DF", global::System.StringComparison.OrdinalIgnoreCase))
							{
								num = 3;
								continue;
							}
							goto IL_D9;
						}
						break;
						IL_D9:
						string ver = text2.Substring(0, 4);
						flag = global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParadiseTuningPathFixupVersions(ver);
						num = 12;
					}
				}
				IL_1E9:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2982U, "DeviceUpdate", "PreserveCPItem", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				string message = string.Format("Tuning Version: Expected {0}; Actual {1}", text2, text3);
				ex.AddErrorMessage(message);
				throw ex;
			}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0002A2A8 File Offset: 0x000292A8
		private void b(string A_0, global::System.Collections.ArrayList A_1)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						IL_33:
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(A_0);
						string text = "//*[@Path='%PATH']";
						text = text.Replace("%PATH", "/opt/pcr/rel/data/codeplug/app_security/" + 4112U.ToString("x") + ".cpg");
						global::System.Xml.XmlNode xmlNode = xmlDocument.SelectSingleNode(text);
						for (;;)
						{
							IL_7C:
							int num = 5;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_1C2;
								case 1:
									goto IL_103;
								case 2:
								{
									global::System.Collections.ArrayList arrayList;
									global::IshHandler.m m = (global::IshHandler.m)arrayList[0];
									this.c.b(ref m.c, A_1);
									byte[] array;
									global::System.Array.Copy(m.c, 0, array, array.Length - m.c.Length, m.c.Length);
									string innerText = this.c.a(array);
									string innerText2 = global::System.BitConverter.ToString(array).Replace("-", "");
									xmlNode.InnerText = innerText2;
									xmlNode.Attributes["MD5_CheckSUM"].InnerText = innerText;
									num = 1;
									continue;
								}
								case 3:
								{
									byte[] array = this.a(xmlNode.InnerText);
									global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
									this.c.a(4112U, array, ref arrayList);
									num = 6;
									continue;
								}
								case 4:
									goto IL_1B6;
								case 5:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_7C;
									default:
										if (false)
										{
										}
										if (xmlNode != null)
										{
											num = 3;
											continue;
										}
										goto IL_1B6;
									}
									break;
								case 6:
								{
									global::System.Collections.ArrayList arrayList;
									if (arrayList.Count > 0)
									{
										num = 2;
										continue;
									}
									goto IL_103;
								}
								}
								goto IL_33;
								IL_103:
								xmlDocument.Save(A_0);
								num = 4;
								continue;
								IL_1B6:
								num = 0;
							}
						}
					}
					IL_1C2:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
			}
			catch (global::System.Exception)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0002A4C8 File Offset: 0x000294C8
		private void a(string A_0, global::System.Collections.ArrayList A_1)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(A_0);
						string xpath = "//Payload[@Path]";
						global::System.Xml.XmlNode xmlNode = xmlDocument.SelectSingleNode(xpath);
						int num = 3;
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								try
								{
									num = 4;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_1A2;
										case 1:
										{
											global::IshHandler.m m;
											this.c.a(ref m.c, A_1);
											num = 3;
											continue;
										}
										case 2:
										{
											global::System.Collections.IEnumerator enumerator;
											if (!enumerator.MoveNext())
											{
												num = 6;
												continue;
											}
											global::IshHandler.m m2 = (global::IshHandler.m)enumerator.Current;
											global::IshHandler.m m = m2;
											num = 5;
											continue;
										}
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
												break;
											}
											break;
										case 5:
										{
											global::IshHandler.m m;
											if (m.a == 4112)
											{
												num = 1;
												continue;
											}
											break;
										}
										case 6:
											num = 0;
											continue;
										}
										IL_124:
										num = 2;
										continue;
										goto IL_124;
									}
									IL_1A2:
									goto IL_A9;
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
												goto IL_1EF;
											case 1:
												goto IL_1ED;
											case 2:
												disposable.Dispose();
												num = 1;
												continue;
											}
											break;
										}
									}
									IL_1ED:
									IL_1EF:;
								}
								goto IL_1F0;
								IL_A9:
								global::System.Collections.ArrayList arrayList;
								this.c.a(arrayList, A_0, 0U);
								string tempFileName;
								global::System.IO.File.Delete(tempFileName);
								num = 2;
								continue;
							}
							case 1:
								goto IL_1FC;
							case 2:
								if (true)
								{
								}
								goto IL_1F0;
							case 3:
								if (xmlNode != null)
								{
									num = 4;
									continue;
								}
								goto IL_1F0;
							case 4:
							{
								byte[] bytes = this.a(xmlNode.InnerText);
								string tempFileName = global::System.IO.Path.GetTempFileName();
								global::System.IO.File.WriteAllBytes(tempFileName, bytes);
								global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
								this.c.a(tempFileName, ref arrayList);
								global::System.Collections.IEnumerator enumerator = arrayList.GetEnumerator();
								num = 0;
								continue;
							}
							}
							break;
							IL_1F0:
							num = 1;
						}
					}
					IL_1FC:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0002A730 File Offset: 0x00029730
		public void a(bool A_0, bool A_1, bool A_2, bool A_3, string A_4, string A_5, bool A_6, object A_7, bool A_8, bool A_9, bool A_10, bool A_11, global::constants.CCPTags.SetProgressBar A_12, int A_13)
		{
			switch (0)
			{
			default:
			{
				string empty = string.Empty;
				string empty2 = string.Empty;
				string empty3 = string.Empty;
				string empty4 = string.Empty;
				string empty5 = string.Empty;
				string empty6 = string.Empty;
				string empty7 = string.Empty;
				string empty8 = string.Empty;
				bool flag = A_6;
				try
				{
					for (;;)
					{
						this.g = A_4;
						this.h = A_5;
						int num = 16;
						for (;;)
						{
							bool flag2;
							switch (num)
							{
							case 0:
								if (!A_1)
								{
									num = 27;
									continue;
								}
								num = 24;
								continue;
							case 1:
								if (A_0)
								{
									num = 33;
									continue;
								}
								goto IL_489;
							case 2:
								flag2 = A_0;
								goto IL_296;
							case 3:
								goto IL_489;
							case 4:
								goto IL_365;
							case 5:
								num = 35;
								continue;
							case 6:
								this.b.d();
								num = 31;
								continue;
							case 7:
								if (string.Equals(this.n, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
								{
									num = 18;
									continue;
								}
								this.a(new global::DeviceUpdate.c.d[]
								{
									this.ab,
									this.ad,
									this.ac
								});
								num = 32;
								continue;
							case 8:
								A_9 = false;
								A_10 = false;
								this.a(this.b, A_8, A_9, A_10, A_11, true, out empty5, out empty6, out empty7, out empty8);
								this.a(this.b, null, empty6, empty7, empty8, A_9, false, true);
								num = 14;
								continue;
							case 9:
								goto IL_2EE;
							case 10:
								if (A_0)
								{
									num = 4;
									continue;
								}
								this.a(this.b, false, false, true, false, false, false);
								num = 36;
								continue;
							case 11:
								goto IL_565;
							case 12:
								goto IL_257;
							case 13:
								if (!A_1)
								{
									num = 30;
									continue;
								}
								goto IL_1FA;
							case 14:
								goto IL_345;
							case 15:
								goto IL_3B8;
							case 16:
								if (this.b.g())
								{
									num = 6;
									continue;
								}
								goto IL_44D;
							case 17:
								if (!A_3)
								{
									num = 20;
									continue;
								}
								goto IL_23A;
							case 18:
								this.a(new global::DeviceUpdate.c.d[]
								{
									this.ab,
									this.ad,
									this.ac,
									this.ae
								});
								num = 15;
								continue;
							case 19:
								goto IL_592;
							case 20:
								num = 26;
								continue;
							case 21:
								num = 10;
								continue;
							case 22:
								num = 28;
								continue;
							case 23:
								if (flag)
								{
									num = 8;
									continue;
								}
								goto IL_345;
							case 24:
								flag2 = true;
								goto IL_296;
							case 25:
								goto IL_23A;
							case 26:
								if (A_0)
								{
									num = 25;
									continue;
								}
								goto IL_565;
							case 27:
								num = 2;
								continue;
							case 28:
								if (!A_2)
								{
									num = 5;
									continue;
								}
								goto IL_2EE;
							case 29:
								if (!A_2)
								{
									num = 21;
									continue;
								}
								goto IL_365;
							case 30:
								num = 1;
								continue;
							case 31:
								goto IL_44D;
							case 32:
								goto IL_3B8;
							case 33:
								goto IL_1FA;
							case 34:
								if (!A_1)
								{
									num = 22;
									continue;
								}
								goto IL_2EE;
							case 35:
								if (true)
								{
								}
								if (A_0)
								{
									num = 9;
									continue;
								}
								goto IL_257;
							case 36:
								goto IL_345;
							}
							break;
							IL_1FA:
							this.a(new global::DeviceUpdate.c.d[]
							{
								this.aj
							});
							this.a(this.b);
							num = 3;
							continue;
							IL_23A:
							this.b(this.b);
							num = 11;
							continue;
							IL_257:
							num = 29;
							continue;
							IL_296:
							A_0 = flag2;
							this.b.a(A_12, A_13);
							flag = this.b.a(this.ak.a());
							num = 34;
							continue;
							IL_2EE:
							this.a(new global::DeviceUpdate.c.d[]
							{
								this.ai
							});
							num = 12;
							continue;
							IL_345:
							num = 13;
							continue;
							IL_365:
							num = 7;
							continue;
							IL_3B8:
							this.a(this.b, false, A_8, true, A_10, A_11, false);
							this.a(this.b, A_8, A_9, A_10, A_11, false, out empty, out empty2, out empty3, out empty4);
							this.a(this.b, empty, empty2, empty3, empty4, A_9, false, false);
							num = 23;
							continue;
							IL_44D:
							this.b = (global::UpdateController.a)A_7;
							this.c.b(false);
							num = 0;
							continue;
							IL_489:
							num = 17;
							continue;
							IL_565:
							this.b.h();
							this.b.i();
							this.b.d();
							num = 19;
						}
					}
					IL_592:;
				}
				catch (global::custom_exception.CCustomException)
				{
					global::DeviceUpdate.c.a(new string[]
					{
						empty,
						empty2,
						empty3,
						empty5,
						empty6,
						empty7
					});
					this.a(this.b);
					throw;
				}
				catch (global::System.Exception ex)
				{
					global::DeviceUpdate.c.a(new string[]
					{
						empty,
						empty2,
						empty3,
						empty5,
						empty6,
						empty7
					});
					this.a(this.b);
					if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
					{
						goto IL_64C;
					}
					IL_61D:
					ex.Source = 2918U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
					IL_64C:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_61D;
					default:
						if (false)
						{
						}
						throw;
					}
				}
				finally
				{
					global::DeviceUpdate.c.a(new string[]
					{
						empty,
						empty2,
						empty3,
						empty4,
						empty5,
						empty6,
						empty7,
						empty8
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.ab.a(),
						this.ad.a(),
						this.ac.a(),
						this.ae.a(),
						this.j,
						this.k,
						this.l
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.aj.a()
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.af.a(),
						this.ag.a()
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.ai.a()
					});
					global::DeviceUpdate.c.a(new string[]
					{
						this.ak.a()
					});
					global::System.GC.Collect();
				}
				return;
			}
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0002AF34 File Offset: 0x00029F34
		public void a(string A_0, object A_1, global::constants.CCPTags.SetProgressBar A_2, int A_3)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.b.d();
							num = 1;
							continue;
						case 1:
							goto IL_5E;
						case 3:
							goto IL_BE;
						}
						if (this.b.g())
						{
							num = 0;
							continue;
						}
						IL_5E:
						this.b = (global::UpdateController.a)A_1;
						this.b.a(A_2, A_3);
						this.b.a(this.ak.a());
						this.a(this.b, A_0);
						this.b.h();
						this.b.d();
						num = 3;
					}
					IL_BE:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				this.a(A_1);
				throw;
			}
			catch (global::System.Exception ex)
			{
				this.a(A_1);
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
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
						ex.Source = 2918U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
						break;
					}
				}
				throw;
			}
			finally
			{
				global::DeviceUpdate.c.a(new string[]
				{
					this.ak.a()
				});
				global::DeviceUpdate.c.a(new string[]
				{
					this.ah.a()
				});
				global::System.GC.Collect();
			}
			if (true)
			{
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0002B104 File Offset: 0x0002A104
		private void a(global::UpdateController.a A_0, string A_1)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 0;
					for (;;)
					{
						global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType a_;
						switch (num)
						{
						case 1:
							goto IL_135;
						case 2:
							if (A_1.Equals("Controller"))
							{
								num = 5;
								continue;
							}
							num = 7;
							continue;
						case 3:
							goto IL_5F;
						case 4:
							goto IL_154;
						case 5:
							a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CONTROLLER_FPGA;
							num = 1;
							continue;
						case 6:
							goto IL_135;
						case 7:
							if (A_1.Equals("Wireline"))
							{
								num = 8;
								continue;
							}
							goto IL_135;
						case 8:
							a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.WIRELINE_FPGA;
							goto IL_C9;
						}
						if (!global::System.IO.File.Exists(this.ah.a()))
						{
							num = 3;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							this.a(new global::DeviceUpdate.c.d[]
							{
								this.ah
							});
							a_ = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.Unknown;
							num = 2;
							continue;
						}
						IL_C9:
						num = 6;
						continue;
						IL_135:
						A_0.a(this.ah.a(), false, a_);
						num = 4;
					}
					IL_5F:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2919U, "DeviceUpdate", "UpdateFPGA", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_154:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex2)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = 2961U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				if (true)
				{
				}
				throw;
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0002B2E8 File Offset: 0x0002A2E8
		public void a(bool A_0, bool A_1, bool A_2, bool A_3, string A_4, string A_5, bool A_6, object A_7, bool A_8, bool A_9, bool A_10, bool A_11, global::constants.CCPTags.SetProgressBar A_12, int A_13, global::CommunicationController.ISerialTransportController A_14, uint A_15)
		{
			if (true)
			{
			}
			switch (0)
			{
			default:
			{
				string empty = string.Empty;
				string empty2 = string.Empty;
				string empty3 = string.Empty;
				string empty4 = string.Empty;
				string empty5 = string.Empty;
				string empty6 = string.Empty;
				string empty7 = string.Empty;
				string empty8 = string.Empty;
				bool flag = false;
				global::UpdateController.a a = new global::UpdateController.a(this.a());
				for (;;)
				{
					try
					{
						a.a(A_15, A_14.GetPointer(), global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRadio);
						a.a(A_12, A_13);
						goto IL_5F;
					}
					catch (global::custom_exception.CCustomException)
					{
						throw;
					}
					catch (global::System.Exception)
					{
						throw;
					}
					break;
					try
					{
						try
						{
							IL_5F:
							for (;;)
							{
								this.g = A_4;
								this.h = A_5;
								this.c.b(false);
								int num = 1;
								for (;;)
								{
									bool flag2;
									bool flag3;
									switch (num)
									{
									case 0:
										this.a(new global::DeviceUpdate.c.d[]
										{
											this.ab,
											this.ad,
											this.ac,
											this.ae
										});
										num = 18;
										continue;
									case 1:
										if (!A_2)
										{
											num = 17;
											continue;
										}
										num = 8;
										continue;
									case 2:
										if (A_0)
										{
											num = 34;
											continue;
										}
										goto IL_34F;
									case 3:
										goto IL_13F;
									case 4:
										goto IL_42B;
									case 5:
										flag2 = true;
										goto IL_398;
									case 6:
										if (A_6)
										{
											num = 33;
											continue;
										}
										goto IL_162;
									case 7:
										this.a(a, null, empty6, empty7, empty8, false, false, true);
										num = 9;
										continue;
									case 8:
										flag3 = true;
										goto IL_248;
									case 9:
										goto IL_50D;
									case 10:
										this.a(a, A_8, false, false, A_11, true, out empty5, out empty6, out empty7, out empty8);
										num = 26;
										continue;
									case 11:
										if (A_3)
										{
											num = 24;
											continue;
										}
										goto IL_30D;
									case 12:
										if (!A_3)
										{
											num = 14;
											continue;
										}
										num = 5;
										continue;
									case 13:
										flag3 = A_0;
										goto IL_248;
									case 14:
										num = 29;
										continue;
									case 15:
										if (A_2)
										{
											num = 23;
											continue;
										}
										this.a(a, false, false, true, false, false, false);
										num = 3;
										continue;
									case 16:
										goto IL_527;
									case 17:
										num = 13;
										continue;
									case 18:
										goto IL_28B;
									case 19:
										if (flag)
										{
											num = 7;
											continue;
										}
										goto IL_50D;
									case 20:
										goto IL_162;
									case 21:
										goto IL_28B;
									case 22:
										num = 36;
										continue;
									case 23:
										num = 35;
										continue;
									case 24:
										this.b(a);
										num = 30;
										continue;
									case 25:
										if (!A_2)
										{
											num = 22;
											continue;
										}
										goto IL_2D9;
									case 26:
										goto IL_13F;
									case 27:
										goto IL_2D9;
									case 28:
										if (flag)
										{
											num = 10;
											continue;
										}
										goto IL_13F;
									case 29:
										flag2 = A_0;
										goto IL_398;
									case 30:
										goto IL_30D;
									case 31:
										goto IL_34F;
									case 32:
										if (A_2)
										{
											num = 37;
											continue;
										}
										goto IL_50D;
									case 33:
										flag = a.e();
										num = 20;
										continue;
									case 34:
										a.a(this.ai.a(), false, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT);
										num = 31;
										continue;
									case 35:
										if (string.Equals(this.n, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
										{
											num = 0;
											continue;
										}
										this.a(new global::DeviceUpdate.c.d[]
										{
											this.ab,
											this.ad,
											this.ac
										});
										num = 21;
										continue;
									case 36:
										if (A_0)
										{
											num = 27;
											continue;
										}
										goto IL_42B;
									case 37:
										this.a(a, empty, empty2, empty3, empty4, A_9, false, false);
										num = 19;
										continue;
									}
									break;
									IL_13F:
									num = 2;
									continue;
									IL_162:
									num = 25;
									continue;
									IL_248:
									A_2 = flag3;
									num = 12;
									continue;
									IL_28B:
									this.a(a, false, A_8, true, A_10, A_11, false);
									this.a(a, A_8, A_9, A_10, A_11, false, out empty, out empty2, out empty3, out empty4);
									num = 28;
									continue;
									IL_2D9:
									this.a(new global::DeviceUpdate.c.d[]
									{
										this.ai
									});
									num = 4;
									continue;
									IL_30D:
									num = 32;
									continue;
									IL_34F:
									num = 11;
									continue;
									IL_398:
									A_3 = flag2;
									num = 6;
									continue;
									IL_42B:
									num = 15;
									continue;
									IL_50D:
									a.h();
									a.d();
									num = 16;
								}
							}
							IL_527:;
						}
						catch (global::custom_exception.CCustomException)
						{
							this.a(a);
							throw;
						}
						catch (global::System.Exception ex)
						{
							this.a(a);
							if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
							{
								goto IL_576;
							}
							IL_547:
							ex.Source = 2918U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
							IL_576:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_547;
							default:
								if (false)
								{
								}
								throw;
							}
						}
						break;
					}
					finally
					{
						global::DeviceUpdate.c.a(new string[]
						{
							this.ai.a()
						});
						global::DeviceUpdate.c.a(new string[]
						{
							this.af.a(),
							this.ag.a()
						});
						global::DeviceUpdate.c.a(new string[]
						{
							empty,
							empty2,
							empty3,
							empty4,
							empty5,
							empty6,
							empty7,
							empty8
						});
						global::DeviceUpdate.c.a(new string[]
						{
							this.ab.a(),
							this.ad.a(),
							this.ac.a(),
							this.ae.a(),
							this.j,
							this.k,
							this.l
						});
						global::DeviceUpdate.c.a(new string[]
						{
							this.ak.a()
						});
						global::System.GC.Collect();
					}
				}
				return;
			}
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0002BA50 File Offset: 0x0002AA50
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool c(global::Motorola.Common.Communication.Pba.RadioImage A_0)
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
			return A_0.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_APP;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0002BA94 File Offset: 0x0002AA94
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool b(global::Motorola.Common.Communication.Pba.FileSet A_0)
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
			return A_0.Name.Equals("WelcomeBitmap");
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0002BAE0 File Offset: 0x0002AAE0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool a(global::Motorola.Common.Communication.Pba.FileSet A_0)
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
			return A_0.Name.Equals("WelcomeBitmap");
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0002BB2C File Offset: 0x0002AB2C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool b(global::Motorola.Common.Communication.Pba.RadioImage A_0)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						if (false)
						{
						}
						num = 5;
						continue;
					}
					break;
				case 2:
					goto IL_85;
				case 3:
					if (A_0.FileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE)
					{
						num = 2;
						continue;
					}
					return true;
				case 4:
					num = 3;
					continue;
				case 5:
					if (A_0.FileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_APP)
					{
						num = 4;
						continue;
					}
					return true;
				}
				if (true)
				{
				}
				if (A_0.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CP_CFS)
				{
					return true;
				}
				num = 1;
			}
			IL_85:
			return A_0.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0002BBEC File Offset: 0x0002ABEC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool a(global::Motorola.Common.Communication.Pba.RadioImage A_0)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (A_0.FileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_APP)
					{
						num = 3;
						continue;
					}
					return true;
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						if (false)
						{
						}
						if (true)
						{
						}
						num = 0;
						continue;
					}
					break;
				case 2:
					if (A_0.FileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE)
					{
						num = 4;
						continue;
					}
					return true;
				case 3:
					num = 2;
					continue;
				case 4:
					goto IL_95;
				}
				if (A_0.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CP_CFS)
				{
					return true;
				}
				num = 1;
			}
			IL_95:
			return A_0.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0002BCB4 File Offset: 0x0002ACB4
		// Note: this type is marked as 'beforefieldinit'.
		static c()
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
			global::DeviceUpdate.c.m = new object();
		}

		// Token: 0x040000C8 RID: 200
		private global::CommunicationController.AutoCorrectionHandler a;

		// Token: 0x040000C9 RID: 201
		private global::UpdateController.a b;

		// Token: 0x040000CA RID: 202
		private global::IshHandler.f c;

		// Token: 0x040000CB RID: 203
		private string d;

		// Token: 0x040000CC RID: 204
		private string e;

		// Token: 0x040000CD RID: 205
		private string f;

		// Token: 0x040000CE RID: 206
		private string g;

		// Token: 0x040000CF RID: 207
		private string h;

		// Token: 0x040000D0 RID: 208
		private string i;

		// Token: 0x040000D1 RID: 209
		private string j;

		// Token: 0x040000D2 RID: 210
		private string k;

		// Token: 0x040000D3 RID: 211
		private string l;

		// Token: 0x040000D4 RID: 212
		private static object m;

		// Token: 0x040000D5 RID: 213
		private string n;

		// Token: 0x040000D6 RID: 214
		private int o;

		// Token: 0x040000D7 RID: 215
		private int p;

		// Token: 0x040000D8 RID: 216
		private string q;

		// Token: 0x040000D9 RID: 217
		private string r;

		// Token: 0x040000DA RID: 218
		private string s;

		// Token: 0x040000DB RID: 219
		private string t;

		// Token: 0x040000DC RID: 220
		private bool u;

		// Token: 0x040000DD RID: 221
		private bool v;

		// Token: 0x040000DE RID: 222
		private bool w;

		// Token: 0x040000DF RID: 223
		private bool x;

		// Token: 0x040000E0 RID: 224
		private bool y;

		// Token: 0x040000E1 RID: 225
		private bool z;

		// Token: 0x040000E2 RID: 226
		private bool aa;

		// Token: 0x040000E3 RID: 227
		private global::DeviceUpdate.c.d ab;

		// Token: 0x040000E4 RID: 228
		private global::DeviceUpdate.c.d ac;

		// Token: 0x040000E5 RID: 229
		private global::DeviceUpdate.c.d ad;

		// Token: 0x040000E6 RID: 230
		private global::DeviceUpdate.c.d ae;

		// Token: 0x040000E7 RID: 231
		private global::DeviceUpdate.c.d af;

		// Token: 0x040000E8 RID: 232
		private global::DeviceUpdate.c.d ag;

		// Token: 0x040000E9 RID: 233
		private global::DeviceUpdate.c.d ah;

		// Token: 0x040000EA RID: 234
		private global::DeviceUpdate.c.d ai;

		// Token: 0x040000EB RID: 235
		private global::DeviceUpdate.c.d aj;

		// Token: 0x040000EC RID: 236
		private global::DeviceUpdate.c.d ak;

		// Token: 0x040000ED RID: 237
		private bool al;

		// Token: 0x040000EE RID: 238
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::System.Predicate<global::Motorola.Common.Communication.Pba.RadioImage> am;

		// Token: 0x040000EF RID: 239
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet> an;

		// Token: 0x040000F0 RID: 240
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::System.Predicate<global::Motorola.Common.Communication.Pba.FileSet> ao;

		// Token: 0x040000F1 RID: 241
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::System.Predicate<global::Motorola.Common.Communication.Pba.RadioImage> ap;

		// Token: 0x040000F2 RID: 242
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::System.Predicate<global::Motorola.Common.Communication.Pba.RadioImage> aq;

		// Token: 0x0200001D RID: 29
		private enum e
		{
			// Token: 0x040000F4 RID: 244
			a,
			// Token: 0x040000F5 RID: 245
			b,
			// Token: 0x040000F6 RID: 246
			c,
			// Token: 0x040000F7 RID: 247
			d,
			// Token: 0x040000F8 RID: 248
			e,
			// Token: 0x040000F9 RID: 249
			f,
			// Token: 0x040000FA RID: 250
			g,
			// Token: 0x040000FB RID: 251
			h,
			// Token: 0x040000FC RID: 252
			i,
			// Token: 0x040000FD RID: 253
			j
		}

		// Token: 0x0200001E RID: 30
		private struct d
		{
			// Token: 0x060000F8 RID: 248 RVA: 0x0002BCFC File Offset: 0x0002ACFC
			public string a()
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
				return this.a;
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x0002BD40 File Offset: 0x0002AD40
			public void a(string A_0)
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
				this.a = A_0;
			}

			// Token: 0x060000FA RID: 250 RVA: 0x0002BD84 File Offset: 0x0002AD84
			public global::DeviceUpdate.c.e b()
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
				return this.b;
			}

			// Token: 0x060000FB RID: 251 RVA: 0x0002BDC8 File Offset: 0x0002ADC8
			public void a(global::DeviceUpdate.c.e A_0)
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
				this.b = A_0;
			}

			// Token: 0x060000FC RID: 252 RVA: 0x0002BE0C File Offset: 0x0002AE0C
			public d(string A_0, global::DeviceUpdate.c.e A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x040000FE RID: 254
			private string a;

			// Token: 0x040000FF RID: 255
			private global::DeviceUpdate.c.e b;
		}

		// Token: 0x0200001F RID: 31
		public enum a
		{
			// Token: 0x04000101 RID: 257
			a,
			// Token: 0x04000102 RID: 258
			b,
			// Token: 0x04000103 RID: 259
			c,
			// Token: 0x04000104 RID: 260
			d,
			// Token: 0x04000105 RID: 261
			e,
			// Token: 0x04000106 RID: 262
			f,
			// Token: 0x04000107 RID: 263
			g,
			// Token: 0x04000108 RID: 264
			h,
			// Token: 0x04000109 RID: 265
			i,
			// Token: 0x0400010A RID: 266
			j,
			// Token: 0x0400010B RID: 267
			k,
			// Token: 0x0400010C RID: 268
			l,
			// Token: 0x0400010D RID: 269
			m,
			// Token: 0x0400010E RID: 270
			n,
			// Token: 0x0400010F RID: 271
			o,
			// Token: 0x04000110 RID: 272
			p,
			// Token: 0x04000111 RID: 273
			q,
			// Token: 0x04000112 RID: 274
			r,
			// Token: 0x04000113 RID: 275
			s,
			// Token: 0x04000114 RID: 276
			t,
			// Token: 0x04000115 RID: 277
			u,
			// Token: 0x04000116 RID: 278
			v,
			// Token: 0x04000117 RID: 279
			w,
			// Token: 0x04000118 RID: 280
			x,
			// Token: 0x04000119 RID: 281
			y,
			// Token: 0x0400011A RID: 282
			z,
			// Token: 0x0400011B RID: 283
			aa,
			// Token: 0x0400011C RID: 284
			ab,
			// Token: 0x0400011D RID: 285
			ac,
			// Token: 0x0400011E RID: 286
			ad,
			// Token: 0x0400011F RID: 287
			ae,
			// Token: 0x04000120 RID: 288
			af
		}

		// Token: 0x02000020 RID: 32
		public struct b
		{
			// Token: 0x04000121 RID: 289
			public string a;

			// Token: 0x04000122 RID: 290
			public global::DeviceUpdate.c.a b;

			// Token: 0x04000123 RID: 291
			public bool c;

			// Token: 0x04000124 RID: 292
			public bool d;

			// Token: 0x04000125 RID: 293
			public string e;

			// Token: 0x04000126 RID: 294
			public string f;

			// Token: 0x04000127 RID: 295
			public string g;

			// Token: 0x04000128 RID: 296
			public string h;

			// Token: 0x04000129 RID: 297
			public string i;

			// Token: 0x0400012A RID: 298
			public bool j;

			// Token: 0x0400012B RID: 299
			public bool k;
		}

		// Token: 0x02000021 RID: 33
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x060000FE RID: 254 RVA: 0x0002BE3C File Offset: 0x0002AE3C
			public bool b(global::Motorola.Common.Communication.Pba.DataPartition A_0)
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
				return A_0.PartitionID == this.a;
			}

			// Token: 0x0400012C RID: 300
			public byte a;
		}
	}
}
