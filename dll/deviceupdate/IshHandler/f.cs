using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using custom_exception;
using DeviceUpdate;
using Motorola.Common.Communication.CommonUtil;

namespace IshHandler
{
	// Token: 0x0200000F RID: 15
	public class f : global::System.IDisposable
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002C04 File Offset: 0x00001C04
		public f()
		{
			this.s = new global::System.Collections.ArrayList();
			this.y = new global::System.Collections.ArrayList();
			if (this.s == null)
			{
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "CIshHandler", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
			}
			this.ab = false;
			this.ac = false;
			this.ad = false;
			this.b(false);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002C7C File Offset: 0x00001C7C
		public f(bool A_0, bool A_1)
		{
			this.s = new global::System.Collections.ArrayList();
			this.y = new global::System.Collections.ArrayList();
			if (this.s == null)
			{
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "CIshHandler", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
			}
			this.ab = A_0;
			this.ac = A_1;
			this.ad = false;
			this.b(false);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002CF4 File Offset: 0x00001CF4
		public bool k()
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
			return this.ah;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002D38 File Offset: 0x00001D38
		public void b(bool A_0)
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
			this.ah = A_0;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002D7C File Offset: 0x00001D7C
		public global::IshHandler.i l()
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
			return this.ai;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002DC0 File Offset: 0x00001DC0
		public void a(global::IshHandler.i A_0)
		{
			this.ai = A_0;
			switch (this.ai)
			{
			case global::IshHandler.i.b:
				this.ag = null;
				return;
			case global::IshHandler.i.c:
				break;
			default:
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
				break;
			}
			this.ag = new global::IshHandler.d(this.a);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002E38 File Offset: 0x00001E38
		public void a(uint A_0, uint A_1, ref uint A_2)
		{
			switch (0)
			{
			default:
			{
				uint num2;
				for (;;)
				{
					int num = 0;
					num2 = 0U;
					int num3 = (int)(4U - A_1);
					int num4 = 1;
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_5C;
						case 1:
							if (num3 >= 0)
							{
								num4 = 2;
								continue;
							}
							goto IL_D9;
						case 2:
							goto IL_5A;
						case 3:
							goto IL_5C;
						case 4:
							goto IL_96;
						case 5:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_5A;
							default:
							{
								if (false)
								{
								}
								if ((long)num >= (long)((ulong)A_1 + (ulong)((long)num3)))
								{
									num4 = 4;
									continue;
								}
								uint num5 = A_0 >> (num - num3) * 8 & 255U;
								num2 = (num2 << 8) + num5;
								num++;
								num4 = 3;
								continue;
							}
							}
							break;
						}
						break;
						IL_5A:
						num = num3;
						num4 = 0;
						continue;
						IL_5C:
						num4 = 5;
					}
				}
				IL_96:
				if (true)
				{
				}
				IL_D9:
				A_2 = num2;
				return;
			}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002F24 File Offset: 0x00001F24
		public global::IshHandler.j a(string A_0, bool A_1)
		{
			switch (0)
			{
			default:
			{
				global::System.Xml.XmlTextReader xmlTextReader = null;
				global::IshHandler.j result;
				try
				{
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							global::i.c c;
							if (c != global::i.c.c)
							{
								num = 6;
								continue;
							}
							global::IshHandler.j j = default(global::IshHandler.j);
							string empty;
							global::System.IO.StringReader stringReader = new global::System.IO.StringReader(empty);
							num = 2;
							continue;
						}
						case 2:
						{
							global::IshHandler.j j;
							try
							{
								for (;;)
								{
									global::System.IO.StringReader stringReader;
									xmlTextReader = new global::System.Xml.XmlTextReader(stringReader);
									num = 4;
									for (;;)
									{
										global::IshHandler.g g;
										switch (num)
										{
										case 0:
										{
											string name;
											if (!(name == "BLOCK"))
											{
												num = 24;
												continue;
											}
											g = default(global::IshHandler.g);
											g.e = false;
											g.f = false;
											g.g = new global::System.Collections.ArrayList();
											g.d = new global::System.Collections.ArrayList();
											bool flag = this.a(ref xmlTextReader, ref g, A_1);
											num = 9;
											continue;
										}
										case 1:
										{
											string name;
											if (!(name == "BIT_FIELD"))
											{
												num = 3;
												continue;
											}
											goto IL_36A;
										}
										case 2:
											if (this.y.Contains(g.b))
											{
												num = 16;
												continue;
											}
											goto IL_36A;
										case 3:
											num = 11;
											continue;
										case 4:
											if (xmlTextReader == null)
											{
												num = 25;
												continue;
											}
											j.a = new global::System.Collections.ArrayList();
											num = 17;
											continue;
										case 5:
										{
											string name;
											if (!(name == "FIELD"))
											{
												num = 26;
												continue;
											}
											goto IL_36A;
										}
										case 6:
											num = 13;
											continue;
										case 7:
											num = 2;
											continue;
										case 8:
										{
											string name;
											if ((name = xmlTextReader.Name) != null)
											{
												num = 12;
												continue;
											}
											goto IL_36A;
										}
										case 9:
										{
											bool flag;
											if (!flag)
											{
												num = 14;
												continue;
											}
											goto IL_210;
										}
										case 10:
											if (xmlTextReader.Name.Length != 0)
											{
												num = 6;
												continue;
											}
											goto IL_36A;
										case 11:
											goto IL_36A;
										case 12:
											num = 0;
											continue;
										case 13:
											if (xmlTextReader.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
											{
												num = 23;
												continue;
											}
											goto IL_36A;
										case 14:
											num = 27;
											continue;
										case 15:
										{
											string name;
											if (!(name == "GROUP"))
											{
												num = 19;
												continue;
											}
											goto IL_36A;
										}
										case 16:
											goto IL_210;
										case 17:
											goto IL_36A;
										case 18:
											goto IL_36A;
										case 19:
											num = 5;
											continue;
										case 20:
											goto IL_3CE;
										case 21:
											if (!xmlTextReader.Read())
											{
												num = 22;
												continue;
											}
											num = 10;
											continue;
										case 22:
											num = 20;
											continue;
										case 23:
											num = 8;
											continue;
										case 24:
											num = 15;
											continue;
										case 25:
											goto IL_128;
										case 26:
											num = 1;
											continue;
										case 27:
											if (this.y != null)
											{
												num = 7;
												continue;
											}
											goto IL_36A;
										}
										break;
										IL_210:
										j.a.Add(g);
										num = 18;
										continue;
										IL_36A:
										num = 21;
									}
								}
								IL_128:
								global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(601U, "DeviceUpdate", "CreateCodeplugStructure", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
								throw ex;
								IL_3CE:
								goto IL_4C1;
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
										goto IL_410;
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
								IL_410:;
							}
							goto IL_413;
							IL_4C1:
							xmlTextReader.Close();
							result = j;
							num = 7;
							continue;
						}
						case 3:
							if (true)
							{
							}
							num = 4;
							continue;
						case 4:
						{
							if (A_0.Length == 0)
							{
								num = 5;
								continue;
							}
							string empty = string.Empty;
							global::i.a(A_0, ref empty, this.ab, global::i.a.c);
							global::i.c c = global::i.a(global::i.b.b, ref empty);
							num = 0;
							continue;
						}
						case 5:
							goto IL_84;
						case 6:
							goto IL_4BC;
						case 7:
							goto IL_4D7;
						}
						if (A_0 == null)
						{
							break;
						}
						num = 3;
					}
					IL_84:
					goto IL_43B;
					IL_413:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(1835U, "DeviceUpdate", "CreateCodeplugStructure", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex2;
					IL_43B:
					global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "CreateCodeplugStructure", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex3;
					IL_4BC:
					goto IL_413;
					IL_4D7:;
				}
				catch (global::System.Xml.XmlException)
				{
					if (xmlTextReader != null)
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
							xmlTextReader.Close();
							break;
						}
					}
					global::custom_exception.CCustomException ex4 = new global::custom_exception.CCustomException(2933U, "DeviceUpdate", "CreateCodeplugStructure", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex4;
				}
				catch (global::custom_exception.CCustomException)
				{
					if (xmlTextReader != null)
					{
						xmlTextReader.Close();
					}
					global::System.GC.Collect();
					throw;
				}
				catch (global::System.Exception ex5)
				{
					if (xmlTextReader != null)
					{
						xmlTextReader.Close();
					}
					global::System.GC.Collect();
					if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex5))
					{
						ex5.Source = 2920U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex5.Source;
					}
					throw;
				}
				return result;
			}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003528 File Offset: 0x00002528
		private bool a(ref global::System.Xml.XmlTextReader A_0, ref global::IshHandler.g A_1, bool A_2)
		{
			bool result;
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						bool flag = true;
						bool flag2 = false;
						int num = 39;
						for (;;)
						{
							switch (num)
							{
							case 0:
								num = 38;
								continue;
							case 1:
							{
								int num2;
								switch (num2)
								{
								case 0:
									A_1.a = A_0.ReadInnerXml();
									num = 34;
									continue;
								case 1:
									A_1.b = uint.Parse(A_0.ReadInnerXml(), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
									num = 9;
									continue;
								case 2:
									A_1.c = uint.Parse(A_0.ReadInnerXml(), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
									num = 3;
									continue;
								case 3:
									this.a(ref A_0, ref A_1, string.Empty);
									num = 10;
									continue;
								case 4:
								{
									global::IshHandler.k k = default(global::IshHandler.k);
									k.h = new global::System.Collections.ArrayList();
									k.g = string.Empty;
									this.a(ref A_0, ref k);
									A_1.d.Add(k);
									num = 2;
									continue;
								}
								case 5:
								{
									string text = A_0.ReadInnerXml();
									num = 18;
									continue;
								}
								default:
									num = 0;
									continue;
								}
								break;
							}
							case 2:
								goto IL_268;
							case 3:
								if (A_1.c != 0U)
								{
									num = 6;
									continue;
								}
								goto IL_268;
							case 4:
								if (!flag2)
								{
									num = 27;
									continue;
								}
								goto IL_516;
							case 5:
								goto IL_268;
							case 6:
								flag = false;
								num = 35;
								continue;
							case 7:
								result = false;
								num = 17;
								continue;
							case 8:
								num = 26;
								continue;
							case 9:
								goto IL_268;
							case 10:
								goto IL_268;
							case 11:
							{
								int num2;
								string name;
								if (global::f.e.TryGetValue(name, out num2))
								{
									num = 24;
									continue;
								}
								goto IL_268;
							}
							case 12:
								goto IL_525;
							case 13:
								if (!A_0.Read())
								{
									num = 30;
									continue;
								}
								num = 15;
								continue;
							case 14:
								goto IL_386;
							case 15:
								if (A_0.Name.Length != 0)
								{
									num = 28;
									continue;
								}
								goto IL_268;
							case 16:
								goto IL_268;
							case 17:
								goto IL_152;
							case 18:
							{
								if (A_2)
								{
									num = 37;
									continue;
								}
								string text;
								A_1.h = text.Equals("1", global::System.StringComparison.Ordinal);
								num = 19;
								continue;
							}
							case 19:
								goto IL_333;
							case 20:
							{
								string name;
								if ((name = A_0.Name) != null)
								{
									num = 31;
									continue;
								}
								goto IL_268;
							}
							case 21:
								if (A_0.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
								{
									num = 32;
									continue;
								}
								num = 36;
								continue;
							case 22:
								if (global::f.e == null)
								{
									num = 23;
									continue;
								}
								goto IL_386;
							case 23:
								global::f.e = new global::System.Collections.Generic.Dictionary<string, int>(6)
								{
									{
										"NAME",
										0
									},
									{
										"ISH_TYPE",
										1
									},
									{
										"ISH_ID",
										2
									},
									{
										"GROUP",
										3
									},
									{
										"FIELD",
										4
									},
									{
										"EXIST",
										5
									}
								};
								num = 14;
								continue;
							case 24:
								num = 1;
								continue;
							case 25:
								goto IL_516;
							case 26:
								if (!(A_0.Name == "BLOCK"))
								{
									num = 16;
									continue;
								}
								goto IL_310;
							case 27:
								num = 33;
								continue;
							case 28:
								num = 21;
								continue;
							case 29:
								goto IL_333;
							case 30:
								goto IL_310;
							case 31:
								num = 22;
								continue;
							case 32:
								num = 20;
								continue;
							case 33:
								A_1.h = !A_2;
								num = 25;
								continue;
							case 34:
								if (A_1.a.ToLowerInvariant().Equals("codeplug"))
								{
									num = 7;
									continue;
								}
								goto IL_268;
							case 35:
								goto IL_268;
							case 36:
								if (A_0.NodeType.Equals(global::System.Xml.XmlNodeType.EndElement))
								{
									num = 8;
									continue;
								}
								goto IL_268;
							case 37:
								A_1.h = false;
								num = 29;
								continue;
							case 38:
								goto IL_268;
							case 39:
								goto IL_268;
							}
							break;
							IL_268:
							num = 13;
							continue;
							IL_310:
							num = 4;
							continue;
							IL_333:
							flag2 = true;
							num = 5;
							continue;
							IL_386:
							num = 11;
							continue;
							IL_516:
							result = flag;
							num = 12;
						}
					}
					IL_152:
					IL_525:
					break;
				}
			}
			catch (global::System.Xml.XmlException)
			{
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2933U, "DeviceUpdate", "ReadBlock", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::System.GC.Collect();
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
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
						if (false)
						{
						}
						ex2.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
						break;
					}
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003B50 File Offset: 0x00002B50
		private void a(ref global::System.Xml.XmlTextReader A_0, ref global::IshHandler.g A_1, string A_2)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						string text = A_2;
						int num = 14;
						for (;;)
						{
							string name;
							switch (num)
							{
							case 0:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_26A;
								default:
									if (false)
									{
									}
									num = 7;
									continue;
								}
								break;
							case 1:
								if (!A_0.Read())
								{
									num = 6;
									continue;
								}
								num = 17;
								continue;
							case 2:
								goto IL_2E7;
							case 3:
								goto IL_108;
							case 4:
								num = 10;
								continue;
							case 5:
								if (A_0.NodeType.Equals(global::System.Xml.XmlNodeType.EndElement))
								{
									num = 4;
									continue;
								}
								goto IL_108;
							case 6:
								goto IL_2DB;
							case 7:
								if (A_0.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
								{
									num = 9;
									continue;
								}
								num = 5;
								continue;
							case 8:
								goto IL_108;
							case 9:
								num = 22;
								continue;
							case 10:
								if (!(A_0.Name == "GROUP"))
								{
									num = 8;
									continue;
								}
								goto IL_2DB;
							case 11:
								goto IL_108;
							case 12:
								goto IL_26A;
							case 13:
								goto IL_108;
							case 14:
								goto IL_108;
							case 15:
								num = 21;
								continue;
							case 16:
								num = 20;
								continue;
							case 17:
								if (A_0.Name.Length != 0)
								{
									num = 0;
									continue;
								}
								goto IL_108;
							case 18:
								num = 12;
								continue;
							case 19:
								goto IL_108;
							case 20:
								if (!(name == "GROUP"))
								{
									num = 15;
									continue;
								}
								this.a(ref A_0, ref A_1, text);
								num = 11;
								continue;
							case 21:
							{
								if (!(name == "FIELD"))
								{
									num = 23;
									continue;
								}
								global::IshHandler.k k = default(global::IshHandler.k);
								k.h = new global::System.Collections.ArrayList();
								k.g = text;
								this.a(ref A_0, ref k);
								A_1.d.Add(k);
								num = 13;
								continue;
							}
							case 22:
								if ((name = A_0.Name) != null)
								{
									num = 18;
									continue;
								}
								goto IL_108;
							case 23:
								num = 19;
								continue;
							}
							break;
							IL_108:
							num = 1;
							continue;
							IL_26A:
							if (!(name == "NAME"))
							{
								num = 16;
								continue;
							}
							text = text + "\\" + A_0.ReadInnerXml();
							num = 3;
							continue;
							IL_2DB:
							num = 2;
						}
					}
					IL_2E7:
					break;
				}
			}
			catch (global::System.Xml.XmlException)
			{
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2933U, "DeviceUpdate", "ReadGroup", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::System.GC.Collect();
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				throw;
			}
			if (true)
			{
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003F10 File Offset: 0x00002F10
		private void a(ref global::System.Xml.XmlTextReader A_0, ref global::IshHandler.k A_1)
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
						goto IL_CC;
					default:
						if (false)
						{
						}
						num = 17;
						break;
					}
					for (;;)
					{
						IL_38:
						switch (num)
						{
						case 0:
						{
							int num2;
							string text = A_1.e.PadLeft(num2 * 2, '0');
							A_1.e = text;
							A_1.j = text;
							A_1.i = text;
							num = 9;
							continue;
						}
						case 1:
							if (true)
							{
							}
							global::f.f = new global::System.Collections.Generic.Dictionary<string, int>(7)
							{
								{
									"NAME",
									0
								},
								{
									"BIT_LENGTH",
									1
								},
								{
									"MIN",
									2
								},
								{
									"MAX",
									3
								},
								{
									"VALUE",
									4
								},
								{
									"PRESERVE",
									5
								},
								{
									"BIT_FIELD",
									6
								}
							};
							num = 8;
							continue;
						case 2:
							goto IL_4CB;
						case 3:
						{
							int num2;
							if (A_1.e.Length < num2 * 2)
							{
								num = 0;
								continue;
							}
							goto IL_4BF;
						}
						case 5:
							num = 7;
							continue;
						case 6:
							num = 32;
							continue;
						case 8:
							goto IL_2D6;
						case 9:
							goto IL_4BF;
						case 10:
							if (!A_0.Read())
							{
								num = 28;
								continue;
							}
							num = 15;
							continue;
						case 11:
							if (A_0.NodeType.Equals(global::System.Xml.XmlNodeType.EndElement))
							{
								num = 6;
								continue;
							}
							break;
						case 12:
						{
							string name;
							int num3;
							if (global::f.f.TryGetValue(name, out num3))
							{
								num = 33;
								continue;
							}
							break;
						}
						case 13:
						{
							int num2 = int.Parse(A_1.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
							num2 /= 8;
							num = 3;
							continue;
						}
						case 14:
							if (global::f.f == null)
							{
								num = 1;
								continue;
							}
							goto IL_2D6;
						case 15:
							if (A_0.Name.Length != 0)
							{
								num = 25;
								continue;
							}
							break;
						case 16:
							if (A_0.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
							{
								num = 26;
								continue;
							}
							num = 11;
							continue;
						case 20:
						{
							string name;
							if ((name = A_0.Name) != null)
							{
								num = 31;
								continue;
							}
							break;
						}
						case 24:
							if (!string.IsNullOrEmpty(A_1.b))
							{
								num = 13;
								continue;
							}
							goto IL_4BF;
						case 25:
							num = 16;
							continue;
						case 26:
							num = 20;
							continue;
						case 28:
							goto IL_233;
						case 29:
						{
							int num3;
							switch (num3)
							{
							case 0:
								A_1.a = A_0.ReadInnerXml();
								num = 27;
								continue;
							case 1:
								A_1.b = A_0.ReadInnerXml();
								num = 18;
								continue;
							case 2:
								A_1.c = A_0.ReadInnerXml();
								num = 30;
								continue;
							case 3:
								A_1.d = A_0.ReadInnerXml();
								num = 23;
								continue;
							case 4:
								A_1.e = A_0.ReadInnerXml();
								A_1.i = A_1.e;
								A_1.j = A_1.e;
								num = 4;
								continue;
							case 5:
								A_1.f = A_0.ReadInnerXml();
								num = 19;
								continue;
							case 6:
							{
								global::IshHandler.b b = default(global::IshHandler.b);
								this.a(ref A_0, ref b);
								A_1.h.Add(b);
								num = 22;
								continue;
							}
							default:
								num = 5;
								continue;
							}
							break;
						}
						case 31:
							num = 14;
							continue;
						case 32:
							if (!(A_0.Name == "FIELD"))
							{
								num = 21;
								continue;
							}
							goto IL_233;
						case 33:
							num = 29;
							continue;
						}
						break;
						IL_233:
						num = 24;
						continue;
						IL_2D6:
						num = 12;
						continue;
						IL_4BF:
						num = 2;
					}
					goto IL_CC;
					IL_4CB:
					break;
					IL_CC:
					num = 10;
					goto IL_38;
				}
				}
			}
			catch (global::System.Xml.XmlException)
			{
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2933U, "DeviceUpdate", "ReadField", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::System.GC.Collect();
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				throw;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000044B0 File Offset: 0x000034B0
		private void a(ref global::System.Xml.XmlTextReader A_0, ref global::IshHandler.b A_1)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 29;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							string name;
							if (!(name == "BIT_NUMBER"))
							{
								num = 22;
								continue;
							}
							A_1.b = A_0.ReadInnerXml();
							num = 4;
							continue;
						}
						case 1:
						{
							string name;
							if ((name = A_0.Name) != null)
							{
								num = 17;
								continue;
							}
							goto IL_1C2;
						}
						case 2:
							num = 0;
							continue;
						case 3:
							goto IL_1C2;
						case 4:
							goto IL_1C2;
						case 5:
							num = 10;
							continue;
						case 6:
							goto IL_1C2;
						case 7:
							num = 14;
							continue;
						case 8:
							goto IL_1C2;
						case 9:
							num = 21;
							continue;
						case 10:
							if (A_0.NodeType.Equals(global::System.Xml.XmlNodeType.Element))
							{
								num = 15;
								continue;
							}
							num = 24;
							continue;
						case 11:
							if (A_0.Name.Length != 0)
							{
								num = 5;
								continue;
							}
							goto IL_1C2;
						case 12:
						{
							string name;
							if (!(name == "NAME"))
							{
								num = 2;
								continue;
							}
							A_1.a = A_0.ReadInnerXml();
							num = 8;
							continue;
						}
						case 13:
						{
							string name;
							if (!(name == "PRESERVE"))
							{
								num = 9;
								continue;
							}
							A_1.f = A_0.ReadInnerXml();
							num = 3;
							continue;
						}
						case 14:
							if (!(A_0.Name == "BIT_FIELD"))
							{
								num = 16;
								continue;
							}
							goto IL_35D;
						case 15:
							num = 1;
							continue;
						case 16:
							goto IL_1C2;
						case 17:
							num = 12;
							continue;
						case 18:
						{
							string name;
							if (!(name == "BIT_MAX"))
							{
								num = 26;
								continue;
							}
							A_1.e = A_0.ReadInnerXml();
							num = 27;
							continue;
						}
						case 19:
							if (!A_0.Read())
							{
								num = 28;
								continue;
							}
							num = 11;
							continue;
						case 20:
							num = 18;
							continue;
						case 21:
							goto IL_15C;
						case 22:
							num = 23;
							continue;
						case 23:
						{
							string name;
							if (!(name == "BIT_MIN"))
							{
								num = 20;
								continue;
							}
							A_1.d = A_0.ReadInnerXml();
							num = 6;
							continue;
						}
						case 24:
							if (A_0.NodeType.Equals(global::System.Xml.XmlNodeType.EndElement))
							{
								num = 7;
								continue;
							}
							goto IL_1C2;
						case 25:
							goto IL_369;
						case 26:
							num = 13;
							continue;
						case 27:
							goto IL_1C2;
						case 28:
							goto IL_35D;
						}
						goto IL_9B;
						IL_1C2:
						num = 19;
						continue;
						IL_15C:
						goto IL_1C2;
						IL_9B:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15C;
						default:
							if (false)
							{
							}
							goto IL_1C2;
						}
						IL_35D:
						num = 25;
					}
					IL_369:
					break;
				}
				}
			}
			catch (global::System.Xml.XmlException)
			{
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2933U, "DeviceUpdate", "ReadBitField", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::System.GC.Collect();
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
				{
					if (true)
					{
					}
					ex2.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				throw;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000048F4 File Offset: 0x000038F4
		private global::IshHandler.h a(global::System.Xml.XmlNode A_0)
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
			return new global::IshHandler.h
			{
				c = new global::System.Collections.ArrayList(),
				e = new global::System.Collections.ArrayList(),
				b = A_0.Attributes["PATH"].Value,
				h = uint.Parse(A_0.Attributes["ISH_TYPE"].Value, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture),
				i = uint.Parse(A_0.Attributes["TARGET_ISH_TYPE"].Value, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture),
				a = A_0.Attributes["OPERATION"].Value
			};
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000049E0 File Offset: 0x000039E0
		private void a(string A_0, string A_1, string A_2)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 6;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							global::System.Xml.XmlDocument xmlDocument;
							try
							{
								string empty;
								xmlDocument.LoadXml(empty);
								goto IL_1AA8;
							}
							catch
							{
								global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2932U, "DeviceUpdate", "BuildFieldChanges", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
								throw ex;
							}
							goto IL_1B03;
							IL_1AA8:
							global::System.Xml.XmlNodeList xmlNodeList = xmlDocument.SelectNodes("//FIELD");
							global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
							num = 5;
							continue;
						}
						case 1:
							goto IL_1A14;
						case 2:
							goto IL_1B03;
						case 3:
							if (A_0.Length != 0)
							{
								num = 1;
								continue;
							}
							goto IL_5D;
						case 4:
						{
							if (!global::System.IO.File.Exists(A_0))
							{
								num = 10;
								continue;
							}
							string empty = string.Empty;
							global::i.a(A_0, ref empty, this.ac, global::i.a.c);
							global::i.c c = global::i.a(global::i.b.b, ref empty);
							num = 7;
							continue;
						}
						case 5:
						{
							global::IshHandler.c c2;
							try
							{
								num = 38;
								for (;;)
								{
									global::System.Xml.XmlNode xmlNode;
									global::IshHandler.h h;
									bool flag;
									string text2;
									string value;
									global::IshHandler.k k;
									global::System.Xml.XmlNode xmlNode3;
									string strA2;
									string strB;
									string strA3;
									global::System.Xml.XmlNode xmlNode4;
									string text3;
									bool flag2;
									global::System.Collections.IEnumerator enumerator2;
									global::System.Xml.XmlNodeList xmlNodeList2;
									global::System.Collections.IEnumerator enumerator4;
									string xpath;
									string xpath2;
									global::System.Collections.IEnumerator enumerator6;
									switch (num)
									{
									case 0:
									{
										string text = xmlNode.Attributes["THRESHOLD"].Value;
										num = 4;
										continue;
									}
									case 1:
									{
										global::System.Xml.XmlNode xmlNode2;
										if (xmlNode2 != null)
										{
											num = 116;
											continue;
										}
										goto IL_AE1;
									}
									case 2:
									{
										string key;
										if ((key = h.a) != null)
										{
											num = 3;
											continue;
										}
										goto IL_1943;
									}
									case 3:
										num = 86;
										continue;
									case 4:
										goto IL_15AC;
									case 5:
										goto IL_1954;
									case 6:
										if (xmlNode.Attributes["UPGRADEONLY"] != null)
										{
											num = 100;
											continue;
										}
										goto IL_478;
									case 7:
										h.n = xmlNode.Attributes["RATIO"].Value;
										num = 70;
										continue;
									case 8:
										flag = false;
										num = 90;
										continue;
									case 9:
										num = 98;
										continue;
									case 10:
										goto IL_41E;
									case 11:
										goto IL_722;
									case 12:
										h.f = true;
										num = 93;
										continue;
									case 13:
										if (text2.Equals("BITFIELD"))
										{
											num = 26;
											continue;
										}
										goto IL_111B;
									case 14:
										if (text2.Equals("BITFIELD"))
										{
											num = 35;
											continue;
										}
										goto IL_866;
									case 15:
										num = 92;
										continue;
									case 16:
										goto IL_12EC;
									case 17:
										goto IL_1766;
									case 18:
										num = 82;
										continue;
									case 19:
										if (xmlNode.Attributes["UPGRADEONLY"] != null)
										{
											num = 76;
											continue;
										}
										goto IL_1606;
									case 20:
										goto IL_1954;
									case 21:
										if (xmlNode.Attributes["THRESHOLD"] != null)
										{
											num = 110;
											continue;
										}
										goto IL_41E;
									case 22:
										if (value.Equals("Y"))
										{
											num = 64;
											continue;
										}
										h.g = false;
										num = 77;
										continue;
									case 23:
									{
										string text;
										string strA;
										if (string.Compare(strA, text, global::System.StringComparison.Ordinal) >= 0)
										{
											num = 108;
											continue;
										}
										goto IL_16D6;
									}
									case 24:
										h.m = "UPGRADE";
										num = 27;
										continue;
									case 25:
										goto IL_12EC;
									case 26:
									{
										k.h = new global::System.Collections.ArrayList();
										global::IshHandler.b b = default(global::IshHandler.b);
										global::System.Xml.XmlNode xmlNode2 = xmlNode3.SelectSingleNode("BITFIELD");
										b.c = xmlNode2.Attributes["BITLOC"].Value;
										b.b = xmlNode2.Attributes["BITNUM"].Value;
										b.a = xmlNode2.InnerXml;
										k.h.Add(b);
										num = 45;
										continue;
									}
									case 27:
										goto IL_12EC;
									case 28:
										goto IL_478;
									case 29:
										if (string.Compare(strA2, strB, global::System.StringComparison.Ordinal) < 0)
										{
											num = 83;
											continue;
										}
										goto IL_12D2;
									case 30:
										if (flag)
										{
											num = 101;
											continue;
										}
										goto IL_66B;
									case 31:
										if (this.k())
										{
											num = 91;
											continue;
										}
										goto IL_1328;
									case 32:
										if (!flag)
										{
											num = 117;
											continue;
										}
										goto IL_9B5;
									case 33:
										if (string.Compare(strA3, strB, global::System.StringComparison.Ordinal) < 0)
										{
											num = 24;
											continue;
										}
										goto IL_126A;
									case 34:
										c2.a.Add(h);
										num = 89;
										continue;
									case 35:
									{
										global::System.Xml.XmlNode xmlNode2 = xmlNode4.SelectSingleNode("BITFIELD");
										num = 104;
										continue;
									}
									case 36:
										goto IL_1954;
									case 37:
									{
										string text;
										if (!string.IsNullOrEmpty(text))
										{
											num = 44;
											continue;
										}
										goto IL_1766;
									}
									case 39:
									{
										string text;
										string strA4;
										if (string.Compare(strA4, text, global::System.StringComparison.Ordinal) < 0)
										{
											num = 79;
											continue;
										}
										goto IL_548;
									}
									case 40:
									{
										k.h = new global::System.Collections.ArrayList();
										global::IshHandler.b b = default(global::IshHandler.b);
										global::System.Xml.XmlNode xmlNode2;
										b.c = xmlNode2.Attributes["BITLOC"].Value;
										b.b = xmlNode2.Attributes["BITNUM"].Value;
										b.a = xmlNode2.InnerXml;
										k.h.Add(b);
										num = 102;
										continue;
									}
									case 41:
										h.f = true;
										h.g = true;
										num = 80;
										continue;
									case 42:
										h.m = "DOWNGRADE";
										num = 25;
										continue;
									case 43:
										num = 103;
										continue;
									case 44:
									{
										string strA = A_1.Substring(0, 5).Replace(".", "");
										string strA5 = A_2.Substring(0, 5).Replace(".", "");
										string text = text.Replace(".", "");
										num = 23;
										continue;
									}
									case 45:
										goto IL_111B;
									case 46:
										global::f.g = new global::System.Collections.Generic.Dictionary<string, int>(6)
										{
											{
												"MOVE",
												0
											},
											{
												"SPLIT",
												1
											},
											{
												"MERGE",
												2
											},
											{
												"RECALC",
												3
											},
											{
												"CONSTANT_NUMBER",
												4
											},
											{
												"HASH_PASSWORD",
												5
											}
										};
										num = 96;
										continue;
									case 47:
										goto IL_5D8;
									case 48:
										h.d = (flag ? xmlNode.Attributes["PATH"].Value : xmlNode3.Attributes["PATH"].Value);
										value = xmlNode.Attributes["MULTI"].Value;
										num = 32;
										continue;
									case 49:
										goto IL_A09;
									case 50:
									{
										string key;
										int num2;
										if (global::f.g.TryGetValue(key, out num2))
										{
											num = 107;
											continue;
										}
										goto IL_1943;
									}
									case 51:
									{
										string text;
										string strA6;
										if (string.Compare(strA6, text, global::System.StringComparison.Ordinal) >= 0)
										{
											num = 57;
											continue;
										}
										goto IL_548;
									}
									case 52:
										if (!text3.Equals("Y"))
										{
											num = 105;
											continue;
										}
										break;
									case 53:
									{
										string text;
										string strA5;
										if (string.Compare(strA5, text, global::System.StringComparison.Ordinal) < 0)
										{
											num = 8;
											continue;
										}
										goto IL_16D6;
									}
									case 54:
									{
										string text;
										string strA6;
										if (string.Compare(strA6, text, global::System.StringComparison.Ordinal) < 0)
										{
											num = 113;
											continue;
										}
										break;
									}
									case 55:
										if (string.Compare(strA3, strB, global::System.StringComparison.Ordinal) >= 0)
										{
											num = 42;
											continue;
										}
										goto IL_12D2;
									case 56:
										goto IL_9B5;
									case 57:
										num = 39;
										continue;
									case 58:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = 9;
											continue;
										}
										xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
										h = default(global::IshHandler.h);
										h = this.a(xmlNode);
										flag2 = true;
										num = 2;
										continue;
									}
									case 59:
										if (xmlNode.Attributes["MULTI"].Value.Equals("Y"))
										{
											num = 41;
											continue;
										}
										h.f = false;
										h.g = false;
										num = 109;
										continue;
									case 60:
										goto IL_5D8;
									case 61:
										goto IL_1954;
									case 62:
									{
										string text;
										string strA4;
										if (string.Compare(strA4, text, global::System.StringComparison.Ordinal) >= 0)
										{
											num = 43;
											continue;
										}
										break;
									}
									case 63:
										num = 52;
										continue;
									case 64:
										h.g = true;
										num = 49;
										continue;
									case 65:
										if (string.Compare(strA2, strB, global::System.StringComparison.Ordinal) >= 0)
										{
											num = 106;
											continue;
										}
										goto IL_126A;
									case 66:
										goto IL_776;
									case 67:
										goto IL_66B;
									case 68:
										try
										{
											num = 2;
											for (;;)
											{
												switch (num)
												{
												case 0:
													goto IL_18F8;
												case 1:
												{
													if (!enumerator2.MoveNext())
													{
														num = 4;
														continue;
													}
													global::System.Xml.XmlNode xmlNode5 = (global::System.Xml.XmlNode)enumerator2.Current;
													k = default(global::IshHandler.k);
													k.g = xmlNode5.Attributes["PATH"].Value;
													k.a = xmlNode5.Attributes["NAME"].Value;
													k.b = xmlNode5.Attributes["SIZE"].Value;
													h.e.Add(k);
													num = 3;
													continue;
												}
												case 4:
													num = 0;
													continue;
												}
												IL_18C6:
												num = 1;
												continue;
												goto IL_18C6;
											}
											IL_18F8:
											goto IL_1954;
										}
										finally
										{
											for (;;)
											{
												global::System.IDisposable disposable = enumerator2 as global::System.IDisposable;
												num = 2;
												for (;;)
												{
													switch (num)
													{
													case 0:
														goto IL_1940;
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
														goto IL_1942;
													}
													break;
												}
											}
											IL_1940:
											IL_1942:;
										}
										goto IL_1943;
									case 69:
										k.g = (flag ? xmlNode.Attributes["PATH"].Value : xmlNode3.Attributes["PATH"].Value);
										k.a = xmlNode3.Attributes["NAME"].Value;
										k.b = xmlNode3.Attributes["SIZE"].Value;
										num = 48;
										continue;
									case 70:
										goto IL_11B5;
									case 71:
										if (value.Equals("Y"))
										{
											num = 12;
											continue;
										}
										h.f = false;
										num = 66;
										continue;
									case 72:
									{
										int num2;
										switch (num2)
										{
										case 0:
										{
											string text = string.Empty;
											num = 21;
											continue;
										}
										case 1:
										{
											xmlNode4 = xmlNode.SelectSingleNode("SOURCEFIELD");
											k = default(global::IshHandler.k);
											k.g = h.b;
											k.a = xmlNode4.Attributes["NAME"].Value;
											k.b = xmlNode4.Attributes["SIZE"].Value;
											h.c.Add(k);
											xmlNodeList2 = xmlNode.SelectNodes("TARGET");
											global::System.Collections.IEnumerator enumerator3 = xmlNodeList2.GetEnumerator();
											num = 95;
											continue;
										}
										case 2:
											goto IL_E9B;
										case 3:
											h.l = xmlNode.Attributes["THRESHOLD"].Value;
											num = 97;
											continue;
										case 4:
											this.y.Add(h.h);
											flag2 = false;
											num = 20;
											continue;
										case 5:
										{
											string text = string.Empty;
											num = 84;
											continue;
										}
										default:
											num = 15;
											continue;
										}
										break;
									}
									case 73:
										if (text2.Equals("BITFIELD"))
										{
											num = 111;
											continue;
										}
										goto IL_AE1;
									case 74:
										value = xmlNode4.Attributes["MULTI"].Value;
										num = 11;
										continue;
									case 75:
										if (flag2)
										{
											num = 34;
											continue;
										}
										break;
									case 76:
										text3 = xmlNode.Attributes["UPGRADEONLY"].Value;
										num = 112;
										continue;
									case 77:
										goto IL_A09;
									case 78:
										goto IL_1954;
									case 79:
										flag = false;
										num = 60;
										continue;
									case 80:
										goto IL_13A0;
									case 81:
										try
										{
											num = 4;
											for (;;)
											{
												switch (num)
												{
												case 1:
													num = 3;
													continue;
												case 2:
												{
													if (!enumerator4.MoveNext())
													{
														num = 1;
														continue;
													}
													global::System.Xml.XmlNode xmlNode6 = (global::System.Xml.XmlNode)enumerator4.Current;
													k = default(global::IshHandler.k);
													k.g = xmlNode6.Attributes["PATH"].Value;
													k.a = xmlNode6.Attributes["NAME"].Value;
													k.b = xmlNode6.Attributes["SIZE"].Value;
													h.c.Add(k);
													num = 0;
													continue;
												}
												case 3:
													goto IL_FAC;
												}
												IL_EEB:
												num = 2;
												continue;
												goto IL_EEB;
											}
											IL_FAC:;
										}
										finally
										{
											for (;;)
											{
												global::System.IDisposable disposable2 = enumerator4 as global::System.IDisposable;
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
														goto IL_FF6;
													case 2:
														goto IL_FF4;
													}
													break;
												}
											}
											IL_FF4:
											IL_FF6:;
										}
										xmlNode3 = xmlNode.SelectSingleNode("TARGET");
										k = default(global::IshHandler.k);
										k.g = xmlNode3.Attributes["PATH"].Value;
										k.a = xmlNode3.Attributes["NAME"].Value;
										k.b = xmlNode3.Attributes["SIZE"].Value;
										num = 13;
										continue;
									case 82:
									{
										string text;
										string strA5;
										if (string.Compare(strA5, text, global::System.StringComparison.Ordinal) >= 0)
										{
											num = 63;
											continue;
										}
										break;
									}
									case 83:
										num = 55;
										continue;
									case 84:
										if (xmlNode.Attributes["THRESHOLD"] != null)
										{
											num = 0;
											continue;
										}
										goto IL_15AC;
									case 85:
										goto IL_AE1;
									case 86:
										if (global::f.g == null)
										{
											num = 46;
											continue;
										}
										goto IL_34B;
									case 87:
									{
										string strA6 = A_1.Substring(0, 5).Replace(".", "");
										string strA4 = A_2.Substring(0, 5).Replace(".", "");
										string text = text.Replace(".", "");
										num = 51;
										continue;
									}
									case 88:
									{
										string text;
										if (!string.IsNullOrEmpty(text))
										{
											num = 87;
											continue;
										}
										goto IL_5D8;
									}
									case 90:
										goto IL_1766;
									case 91:
										h.m = "NONE";
										num = 99;
										continue;
									case 92:
										goto IL_1943;
									case 93:
										goto IL_776;
									case 94:
									{
										string text;
										string strA;
										if (string.Compare(strA, text, global::System.StringComparison.Ordinal) < 0)
										{
											num = 18;
											continue;
										}
										break;
									}
									case 95:
										try
										{
											num = 6;
											for (;;)
											{
												switch (num)
												{
												case 0:
													num = 3;
													continue;
												case 1:
												{
													global::System.Collections.IEnumerator enumerator3;
													if (!enumerator3.MoveNext())
													{
														num = 0;
														continue;
													}
													global::System.Xml.XmlNode xmlNode7 = (global::System.Xml.XmlNode)enumerator3.Current;
													k = default(global::IshHandler.k);
													k.g = xmlNode7.Attributes["PATH"].Value;
													k.a = xmlNode7.Attributes["NAME"].Value;
													k.b = xmlNode7.Attributes["SIZE"].Value;
													text2 = xmlNode7.Attributes["TYPE"].Value;
													num = 2;
													continue;
												}
												case 2:
													if (text2.Equals("BITFIELD"))
													{
														num = 4;
														continue;
													}
													goto IL_DA9;
												case 3:
													goto IL_E31;
												case 4:
												{
													k.h = new global::System.Collections.ArrayList();
													global::System.Xml.XmlNode xmlNode7;
													global::System.Xml.XmlNodeList xmlNodeList3 = xmlNode7.SelectNodes("BITFIELD");
													global::System.Collections.IEnumerator enumerator5 = xmlNodeList3.GetEnumerator();
													num = 5;
													continue;
												}
												case 5:
													try
													{
														num = 0;
														for (;;)
														{
															switch (num)
															{
															case 1:
																num = 2;
																continue;
															case 2:
																goto IL_D5E;
															case 3:
															{
																global::System.Collections.IEnumerator enumerator5;
																if (!enumerator5.MoveNext())
																{
																	num = 1;
																	continue;
																}
																global::System.Xml.XmlNode xmlNode8 = (global::System.Xml.XmlNode)enumerator5.Current;
																global::IshHandler.b b = default(global::IshHandler.b);
																b.c = xmlNode8.Attributes["BITLOC"].Value;
																b.b = xmlNode8.Attributes["BITNUM"].Value;
																b.a = xmlNode8.InnerXml;
																k.h.Add(b);
																num = 4;
																continue;
															}
															}
															IL_CAF:
															num = 3;
															continue;
															goto IL_CAF;
														}
														IL_D5E:;
													}
													finally
													{
														for (;;)
														{
															global::System.Collections.IEnumerator enumerator5;
															global::System.IDisposable disposable3 = enumerator5 as global::System.IDisposable;
															num = 1;
															for (;;)
															{
																switch (num)
																{
																case 0:
																	disposable3.Dispose();
																	num = 2;
																	continue;
																case 1:
																	if (disposable3 != null)
																	{
																		num = 0;
																		continue;
																	}
																	goto IL_DA8;
																case 2:
																	goto IL_DA6;
																}
																break;
															}
														}
														IL_DA6:
														IL_DA8:;
													}
													goto IL_DA9;
												}
												goto IL_BCF;
												IL_DA9:
												h.e.Add(k);
												num = 7;
												continue;
												IL_DFF:
												num = 1;
												continue;
												IL_BCF:
												goto IL_DFF;
											}
											IL_E31:
											goto IL_1954;
										}
										finally
										{
											for (;;)
											{
												global::System.Collections.IEnumerator enumerator3;
												global::System.IDisposable disposable4 = enumerator3 as global::System.IDisposable;
												num = 1;
												for (;;)
												{
													switch (num)
													{
													case 0:
														goto IL_E98;
													case 1:
														if (disposable4 != null)
														{
															num = 2;
															continue;
														}
														goto IL_E9A;
													case 2:
														for (;;)
														{
															disposable4.Dispose();
															switch ((1 == 1) ? 1 : 0)
															{
															case 0:
															case 2:
																break;
															default:
																goto IL_E89;
															}
														}
														IL_E89:
														if (false)
														{
														}
														num = 0;
														continue;
													}
													break;
												}
											}
											IL_E98:
											IL_E9A:;
										}
										goto IL_E9B;
									case 96:
										goto IL_34B;
									case 97:
										if (xmlNode.Attributes["RATIO"] != null)
										{
											num = 7;
											continue;
										}
										goto IL_11B5;
									case 98:
										goto IL_19C6;
									case 99:
										goto IL_1328;
									case 100:
										text3 = xmlNode.Attributes["UPGRADEONLY"].Value;
										num = 28;
										continue;
									case 101:
									{
										uint num3 = h.h;
										h.h = h.i;
										h.i = num3;
										xpath = "TARGET";
										xpath2 = "SOURCEFIELD";
										xmlNode3 = xmlNode.SelectSingleNode("TARGET");
										h.b = xmlNode3.Attributes["PATH"].Value;
										num = 67;
										continue;
									}
									case 102:
										goto IL_866;
									case 103:
										if (!text3.Equals("Y"))
										{
											num = 114;
											continue;
										}
										break;
									case 104:
									{
										global::System.Xml.XmlNode xmlNode2;
										if (xmlNode2 != null)
										{
											num = 40;
											continue;
										}
										goto IL_866;
									}
									case 105:
										flag = true;
										num = 17;
										continue;
									case 106:
										num = 33;
										continue;
									case 107:
										num = 72;
										continue;
									case 108:
										num = 53;
										continue;
									case 109:
										goto IL_13A0;
									case 110:
									{
										string text = xmlNode.Attributes["THRESHOLD"].Value;
										num = 10;
										continue;
									}
									case 111:
									{
										global::System.Xml.XmlNode xmlNode2 = xmlNode3.SelectSingleNode("BITFIELD");
										num = 1;
										continue;
									}
									case 112:
										goto IL_1606;
									case 113:
										num = 62;
										continue;
									case 114:
										flag = true;
										num = 47;
										continue;
									case 115:
										if (flag)
										{
											num = 74;
											continue;
										}
										goto IL_722;
									case 116:
									{
										k.h = new global::System.Collections.ArrayList();
										global::IshHandler.b b = default(global::IshHandler.b);
										global::System.Xml.XmlNode xmlNode2;
										b.c = xmlNode2.Attributes["BITLOC"].Value;
										b.b = xmlNode2.Attributes["BITNUM"].Value;
										b.a = xmlNode2.InnerXml;
										k.h.Add(b);
										num = 85;
										continue;
									}
									case 117:
										value = xmlNode3.Attributes["MULTI"].Value;
										num = 56;
										continue;
									case 118:
										try
										{
											num = 1;
											for (;;)
											{
												switch (num)
												{
												case 0:
													num = 2;
													continue;
												case 2:
													goto IL_14BC;
												case 4:
												{
													if (!enumerator6.MoveNext())
													{
														num = 0;
														continue;
													}
													global::System.Xml.XmlNode xmlNode9 = (global::System.Xml.XmlNode)enumerator6.Current;
													k = default(global::IshHandler.k);
													k.g = h.b;
													k.a = xmlNode9.Attributes["NAME"].Value;
													k.h = new global::System.Collections.ArrayList();
													h.c.Add(k);
													h.e.Add(k);
													num = 3;
													continue;
												}
												}
												IL_140A:
												num = 4;
												continue;
												goto IL_140A;
											}
											IL_14BC:;
										}
										finally
										{
											for (;;)
											{
												global::System.IDisposable disposable5 = enumerator6 as global::System.IDisposable;
												num = 2;
												for (;;)
												{
													switch (num)
													{
													case 0:
														disposable5.Dispose();
														num = 1;
														continue;
													case 1:
														goto IL_1504;
													case 2:
														if (disposable5 != null)
														{
															num = 0;
															continue;
														}
														goto IL_1506;
													}
													break;
												}
											}
											IL_1504:
											IL_1506:;
										}
										h.d = h.b;
										num = 78;
										continue;
									}
									goto IL_274;
									IL_34B:
									num = 50;
									continue;
									IL_41E:
									text3 = string.Empty;
									num = 6;
									continue;
									IL_478:
									flag = false;
									num = 88;
									continue;
									IL_548:
									num = 54;
									continue;
									IL_5D8:
									xpath = "SOURCEFIELD";
									xpath2 = "TARGET";
									num = 30;
									continue;
									IL_66B:
									xmlNode4 = xmlNode.SelectSingleNode(xpath);
									k = default(global::IshHandler.k);
									k.g = h.b;
									k.a = xmlNode4.Attributes["NAME"].Value;
									k.b = xmlNode4.Attributes["SIZE"].Value;
									value = xmlNode.Attributes["MULTI"].Value;
									num = 115;
									continue;
									IL_722:
									num = 71;
									continue;
									IL_776:
									text2 = xmlNode.Attributes["TYPE"].Value;
									num = 14;
									continue;
									IL_866:
									h.c.Add(k);
									xmlNode3 = xmlNode.SelectSingleNode(xpath2);
									k = default(global::IshHandler.k);
									num = 69;
									continue;
									IL_9B5:
									num = 22;
									continue;
									IL_A09:
									num = 73;
									continue;
									IL_AE1:
									h.e.Add(k);
									num = 5;
									continue;
									IL_E9B:
									global::System.Xml.XmlNodeList xmlNodeList4 = xmlNode.SelectNodes("SOURCEFIELD");
									enumerator4 = xmlNodeList4.GetEnumerator();
									num = 81;
									continue;
									IL_111B:
									h.e.Add(k);
									num = 36;
									continue;
									IL_11B5:
									strA2 = A_1.Substring(0, 5).Replace(".", "");
									strA3 = A_2.Substring(0, 5).Replace(".", "");
									strB = h.l.Replace(".", "");
									num = 65;
									continue;
									IL_126A:
									num = 29;
									continue;
									IL_12D2:
									h.m = "NONE";
									num = 16;
									continue;
									IL_12EC:
									num = 31;
									continue;
									IL_1328:
									num = 59;
									continue;
									IL_13A0:
									h.k = xmlNode.Attributes["TYPE"].Value;
									xmlNodeList4 = xmlNode.SelectNodes("SOURCEFIELD");
									enumerator6 = xmlNodeList4.GetEnumerator();
									num = 118;
									continue;
									IL_15AC:
									text3 = string.Empty;
									num = 19;
									continue;
									IL_1606:
									flag = false;
									num = 37;
									continue;
									IL_16D6:
									num = 94;
									continue;
									IL_1766:
									xmlNode4 = xmlNode.SelectSingleNode("SOURCEFIELD");
									k = default(global::IshHandler.k);
									k.g = xmlNode4.Attributes["PATH"].Value;
									k.a = xmlNode4.Attributes["NAME"].Value;
									k.b = xmlNode4.Attributes["SIZE"].Value;
									h.c.Add(k);
									xmlNodeList2 = xmlNode.SelectNodes("TARGET");
									enumerator2 = xmlNodeList2.GetEnumerator();
									num = 68;
									continue;
									IL_1943:
									flag2 = false;
									num = 61;
									continue;
									IL_1954:
									num = 75;
									continue;
									IL_1994:
									num = 58;
									continue;
									IL_274:
									goto IL_1994;
								}
								IL_19C6:
								goto IL_1B51;
							}
							finally
							{
								for (;;)
								{
									global::System.Collections.IEnumerator enumerator;
									global::System.IDisposable disposable6 = enumerator as global::System.IDisposable;
									num = 2;
									for (;;)
									{
										switch (num)
										{
										case 0:
											disposable6.Dispose();
											num = 1;
											continue;
										case 1:
											goto IL_1A11;
										case 2:
											if (disposable6 != null)
											{
												num = 0;
												continue;
											}
											goto IL_1A13;
										}
										break;
									}
								}
								IL_1A11:
								IL_1A13:;
							}
							goto IL_1A14;
							IL_1B51:
							this.v = c2;
							num = 8;
							continue;
						}
						case 7:
						{
							global::i.c c;
							if (c != global::i.c.c)
							{
								num = 9;
								continue;
							}
							global::IshHandler.c c2 = default(global::IshHandler.c);
							c2.a = new global::System.Collections.ArrayList();
							string text2 = string.Empty;
							global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
							num = 0;
							continue;
						}
						case 8:
							goto IL_1B65;
						case 9:
							goto IL_1AA3;
						case 10:
							goto IL_1A34;
						}
						if (A_0 != null)
						{
							num = 2;
							continue;
						}
						break;
						IL_1A14:
						num = 4;
						continue;
						IL_1B03:
						num = 3;
					}
					IL_5D:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2932U, "DeviceUpdate", "ChangeFieldStruct", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex2;
					IL_1A34:
					goto IL_5D;
					IL_1AA3:
					global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(1835U, "DeviceUpdate", "BuildFieldChanges", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex3;
					IL_1B65:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex4)
			{
				global::System.GC.Collect();
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex4))
				{
					if (true)
					{
					}
					ex4.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex4.Source;
				}
				throw;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000668C File Offset: 0x0000568C
		private global::IshHandler.h g(global::IshHandler.h A_0)
		{
			switch (0)
			{
			default:
			{
				global::IshHandler.h result;
				for (;;)
				{
					for (;;)
					{
						result = default(global::IshHandler.h);
						result.a = A_0.a;
						result.h = A_0.h;
						result.f = A_0.f;
						result.b = A_0.b;
						result.i = A_0.i;
						result.g = A_0.f;
						result.d = A_0.b;
						result.l = A_0.l;
						result.m = A_0.m;
						result.k = A_0.k;
						result.c = new global::System.Collections.ArrayList();
						result.e = new global::System.Collections.ArrayList();
						int num = 0;
						int num2 = 8;
						for (;;)
						{
							int num3;
							global::IshHandler.k k;
							switch (num2)
							{
							case 0:
								goto IL_292;
							case 1:
								return result;
							case 2:
							{
								if (num3 >= A_0.e.Count)
								{
									num2 = 1;
									continue;
								}
								k = (global::IshHandler.k)A_0.e[num3];
								global::IshHandler.k k2 = default(global::IshHandler.k);
								k2.h = new global::System.Collections.ArrayList();
								k2.g = k.g;
								k2.a = k.a;
								num2 = 13;
								continue;
							}
							case 3:
								goto IL_431;
							case 4:
								goto IL_32A;
							case 5:
							{
								int num4 = 0;
								num2 = 19;
								continue;
							}
							case 6:
								goto IL_21D;
							case 7:
								goto IL_32A;
							case 8:
								goto IL_2C2;
							case 9:
								goto IL_2F2;
							case 10:
								if (k.h != null)
								{
									num2 = 5;
									continue;
								}
								goto IL_431;
							case 11:
							{
								int num5;
								if (num5 >= k.h.Count)
								{
									num2 = 6;
									continue;
								}
								global::IshHandler.b b = (global::IshHandler.b)k.h[num5];
								global::IshHandler.b b2 = default(global::IshHandler.b);
								b2.a = b.a;
								b2.c = b.c;
								b2.b = b.b;
								global::IshHandler.k k2;
								k2.h.Add(b2);
								num5++;
								num2 = 4;
								continue;
							}
							case 12:
								num3 = 0;
								num2 = 14;
								continue;
							case 13:
								if (k.h != null)
								{
									num2 = 15;
									continue;
								}
								goto IL_21D;
							case 14:
								goto IL_292;
							case 15:
							{
								int num5 = 0;
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									if (false)
									{
									}
									num2 = 7;
									continue;
								}
								break;
							}
							case 16:
							{
								if (true)
								{
								}
								int num4;
								if (num4 >= k.h.Count)
								{
									num2 = 3;
									continue;
								}
								global::IshHandler.b b = (global::IshHandler.b)k.h[num4];
								global::IshHandler.b b2 = default(global::IshHandler.b);
								b2.a = b.a;
								b2.c = b.c;
								b2.b = b.b;
								global::IshHandler.k k2;
								k2.h.Add(b2);
								num4++;
								num2 = 9;
								continue;
							}
							case 17:
							{
								if (num >= A_0.c.Count)
								{
									num2 = 12;
									continue;
								}
								k = (global::IshHandler.k)A_0.c[num];
								global::IshHandler.k k2 = default(global::IshHandler.k);
								k2.h = new global::System.Collections.ArrayList();
								k2.g = k.g;
								k2.a = k.a;
								num2 = 10;
								continue;
							}
							case 18:
								goto IL_2C2;
							case 19:
								goto IL_2F2;
							}
							break;
							IL_21D:
							result.c.Add(k);
							num3++;
							num2 = 0;
							continue;
							IL_292:
							num2 = 2;
							continue;
							IL_2C2:
							num2 = 17;
							continue;
							IL_2F2:
							num2 = 16;
							continue;
							IL_32A:
							num2 = 11;
							continue;
							IL_431:
							result.c.Add(k);
							num++;
							num2 = 18;
						}
					}
				}
				return result;
			}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00006AF8 File Offset: 0x00005AF8
		private void g()
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						string empty = string.Empty;
						string empty2 = string.Empty;
						string empty3 = string.Empty;
						string empty4 = string.Empty;
						uint num = 0U;
						uint num2 = 0U;
						bool flag = false;
						bool flag2 = false;
						bool flag3 = true;
						global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
						global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
						int num3 = 0;
						int num4 = 37;
						for (;;)
						{
							string text;
							int num5;
							global::IshHandler.h a_;
							global::IshHandler.g g;
							int num6;
							global::IshHandler.k k;
							global::IshHandler.k k2;
							global::IshHandler.k k3;
							int num9;
							string text5;
							int num11;
							int num12;
							int num14;
							string text9;
							int num15;
							int num16;
							string text10;
							int num17;
							int num18;
							int num19;
							int num24;
							int num26;
							int num30;
							int num31;
							int num36;
							int num37;
							int num38;
							switch (num4)
							{
							case 0:
								num4 = 177;
								continue;
							case 1:
								if (text.Length < num5)
								{
									num4 = 231;
									continue;
								}
								goto IL_D18;
							case 2:
								if (a_.k.Equals("INCREMENT"))
								{
									num4 = 150;
									continue;
								}
								goto IL_541;
							case 3:
							{
								string text2;
								if (text2 != null)
								{
									num4 = 128;
									continue;
								}
								goto IL_1B84;
							}
							case 4:
								if (flag2)
								{
									num4 = 201;
									continue;
								}
								k = (global::IshHandler.k)g.d[num6];
								num4 = 141;
								continue;
							case 5:
								num4 = 216;
								continue;
							case 6:
								num4 = 61;
								continue;
							case 7:
								goto IL_1C41;
							case 8:
								goto IL_1194;
							case 9:
								num4 = 149;
								continue;
							case 10:
								if (g.b == num2)
								{
									num4 = 153;
									continue;
								}
								goto IL_E49;
							case 11:
								goto IL_17CE;
							case 12:
							{
								global::IshHandler.b b = (global::IshHandler.b)k2.h[0];
								string text3 = b.g;
								int num7 = int.Parse(b.c, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								int num8 = int.Parse(b.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								text3 = text3.PadLeft(num7 + num8, '0');
								num4 = 69;
								continue;
							}
							case 13:
								if (a_.f)
								{
									num4 = 235;
									continue;
								}
								goto IL_1BDA;
							case 14:
								if (a_.f)
								{
									num4 = 178;
									continue;
								}
								goto IL_D91;
							case 15:
								if (k.f.Equals("PRESERVE_YES"))
								{
									num4 = 112;
									continue;
								}
								goto IL_148E;
							case 16:
								goto IL_1E9A;
							case 17:
								if (k2.h.Count > 0)
								{
									num4 = 0;
									continue;
								}
								goto IL_1154;
							case 18:
							{
								string text2 = this.e(a_);
								num4 = 3;
								continue;
							}
							case 19:
								if (k2.h.Count > 0)
								{
									num4 = 155;
									continue;
								}
								goto IL_1B60;
							case 20:
								goto IL_1BDA;
							case 21:
								num4 = 58;
								continue;
							case 22:
								goto IL_1BF7;
							case 23:
							{
								string a_2;
								k.e = a_2;
								k.i = k3.i;
								num4 = 189;
								continue;
							}
							case 24:
								k3.e = this.c(a_);
								num4 = 114;
								continue;
							case 25:
								num4 = 223;
								continue;
							case 26:
								if (text.Length > num5)
								{
									num4 = 36;
									continue;
								}
								goto IL_15C0;
							case 27:
								goto IL_10FE;
							case 28:
								num4 = 199;
								continue;
							case 29:
								if (flag)
								{
									num4 = 173;
									continue;
								}
								goto IL_1BB4;
							case 30:
								goto IL_A73;
							case 31:
							{
								global::IshHandler.g g2;
								g2.f = true;
								string text4;
								g2.g.Add(text4);
								this.t.a[num9] = g2;
								num4 = 77;
								continue;
							}
							case 32:
								if (k2.h != null)
								{
									num4 = 28;
									continue;
								}
								goto IL_14D0;
							case 33:
								goto IL_541;
							case 34:
								goto IL_2300;
							case 35:
								goto IL_5E6;
							case 36:
								text = text.Substring(text.Length - num5, num5);
								num4 = 175;
								continue;
							case 37:
								goto IL_1E66;
							case 38:
								this.f(a_);
								num4 = 218;
								continue;
							case 39:
								num4 = 133;
								continue;
							case 40:
								goto IL_148E;
							case 41:
								goto IL_1BB4;
							case 42:
								goto IL_5E6;
							case 43:
							{
								int a_3 = this.a(text5, 2);
								k2.e = this.a((uint)a_3);
								num4 = 86;
								continue;
							}
							case 44:
								if (flag3)
								{
									num4 = 94;
									continue;
								}
								goto IL_14D0;
							case 45:
								goto IL_17CE;
							case 46:
								goto IL_1328;
							case 47:
							{
								if (k3.h.Count > 0)
								{
									num4 = 233;
									continue;
								}
								int num10 = int.Parse(k3.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num10 /= 8;
								num4 = 213;
								continue;
							}
							case 48:
							{
								if (k2.h.Count > 0)
								{
									num4 = 176;
									continue;
								}
								string str = k2.e.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + str;
								num4 = 75;
								continue;
							}
							case 49:
								goto IL_1B60;
							case 50:
								num4 = 88;
								continue;
							case 51:
								goto IL_138C;
							case 52:
								goto IL_929;
							case 53:
							{
								if (num9 >= this.t.a.Count)
								{
									num4 = 20;
									continue;
								}
								global::IshHandler.g g2 = (global::IshHandler.g)this.t.a[num9];
								num4 = 124;
								continue;
							}
							case 54:
								num4 = 154;
								continue;
							case 55:
								if (k3.h != null)
								{
									num4 = 186;
									continue;
								}
								goto IL_EE8;
							case 56:
								if (k3.h.Count > 0)
								{
									num4 = 135;
									continue;
								}
								goto IL_EE8;
							case 57:
								goto IL_1D9C;
							case 58:
							{
								global::IshHandler.k k4;
								if (empty2.Equals(k4.a))
								{
									num4 = 221;
									continue;
								}
								goto IL_14D0;
							}
							case 59:
								if (a_.k.Equals("MCP1"))
								{
									num4 = 18;
									continue;
								}
								goto IL_1B84;
							case 60:
							{
								global::IshHandler.g g2;
								string text2 = this.b(a_, g2);
								num4 = 134;
								continue;
							}
							case 61:
							{
								string text6;
								if (!(text6 == "MERGE"))
								{
									num4 = 95;
									continue;
								}
								string str = string.Empty;
								string text7 = string.Empty;
								num11 = 0;
								num4 = 136;
								continue;
							}
							case 62:
								if (a_.k.Equals("CB_HIGH_SLOPE"))
								{
									num4 = 68;
									continue;
								}
								goto IL_1DFC;
							case 63:
								if (num11 >= a_.c.Count)
								{
									num4 = 140;
									continue;
								}
								k2 = (global::IshHandler.k)a_.c[num11];
								num4 = 48;
								continue;
							case 64:
								if (a_.a == "HASH_PASSWORD")
								{
									num4 = 38;
									continue;
								}
								num9 = 0;
								num4 = 52;
								continue;
							case 65:
								goto IL_B2A;
							case 66:
								goto IL_479;
							case 67:
								if (num12 != 0)
								{
									num4 = 172;
									continue;
								}
								num4 = 87;
								continue;
							case 68:
								k3.e = this.a(a_);
								num4 = 198;
								continue;
							case 69:
								goto IL_1F40;
							case 70:
								goto IL_1B84;
							case 71:
								goto IL_1194;
							case 72:
							{
								global::IshHandler.b b;
								global::IshHandler.b b2;
								b2.g = b.g;
								int num13;
								k.h[num13] = b2;
								num4 = 122;
								continue;
							}
							case 73:
							{
								string text6;
								if ((text6 = a_.a) != null)
								{
									num4 = 208;
									continue;
								}
								goto IL_1194;
							}
							case 74:
								goto IL_1DCC;
							case 75:
								goto IL_1BF7;
							case 76:
								if (a_.k.Equals("CB"))
								{
									num4 = 24;
									continue;
								}
								goto IL_95D;
							case 77:
								if (a_.f)
								{
									num4 = 194;
									continue;
								}
								goto IL_1C41;
							case 78:
							{
								string text6;
								if (!(text6 == "MOVE"))
								{
									num4 = 6;
									continue;
								}
								k2 = (global::IshHandler.k)a_.c[0];
								k3 = (global::IshHandler.k)a_.e[0];
								num4 = 151;
								continue;
							}
							case 79:
								goto IL_EE8;
							case 80:
								goto IL_A1A;
							case 81:
								num4 = 165;
								continue;
							case 82:
								if (a_.a == "MOVE")
								{
									num4 = 222;
									continue;
								}
								goto IL_1B60;
							case 83:
							{
								global::IshHandler.b b;
								global::IshHandler.b b2;
								if (b2.a.Equals(b.a))
								{
									num4 = 72;
									continue;
								}
								int num13;
								num13++;
								num4 = 11;
								continue;
							}
							case 84:
								goto IL_229C;
							case 85:
								goto IL_541;
							case 86:
								goto IL_EE8;
							case 87:
								num14 = 0;
								goto IL_186A;
							case 88:
								goto IL_1194;
							case 89:
							{
								string text8 = k.e.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								int a_4 = int.Parse(text8, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
								text9 = this.a(a_4, 2);
								int totalWidth = int.Parse(k.b.ToString(global::System.Globalization.CultureInfo.InvariantCulture), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								text9 = text9.PadLeft(totalWidth, '0');
								num15 = 0;
								num16 = 0;
								text10 = string.Empty;
								num4 = 166;
								continue;
							}
							case 90:
								num17 = 0;
								num4 = 167;
								continue;
							case 91:
								if (num18 <= num19)
								{
									num4 = 81;
									continue;
								}
								goto IL_120A;
							case 92:
							{
								global::IshHandler.b b2;
								num19 = int.Parse(b2.e, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
								num4 = 187;
								continue;
							}
							case 93:
							{
								string text6;
								if (!(text6 == "SPLIT"))
								{
									num4 = 5;
									continue;
								}
								k2 = (global::IshHandler.k)a_.c[0];
								string text3 = string.Empty;
								num4 = 163;
								continue;
							}
							case 94:
							{
								k2.i = k2.e;
								global::IshHandler.k k4;
								k2.e = k4.e;
								num4 = 32;
								continue;
							}
							case 95:
								num4 = 93;
								continue;
							case 96:
							{
								global::IshHandler.g g2;
								k3.e = this.a(a_, g2);
								num4 = 180;
								continue;
							}
							case 97:
							{
								if (num3 >= this.v.a.Count)
								{
									num4 = 192;
									continue;
								}
								a_ = (global::IshHandler.h)this.v.a[num3];
								empty = a_.b;
								num = a_.h;
								num2 = a_.i;
								global::IshHandler.k k5 = (global::IshHandler.k)a_.c[0];
								string text4 = k5.g + k5.a;
								num4 = 14;
								continue;
							}
							case 98:
								goto IL_1DCC;
							case 99:
								goto IL_479;
							case 100:
								goto IL_8F9;
							case 101:
								goto IL_22CC;
							case 102:
								goto IL_14D0;
							case 103:
							{
								global::IshHandler.g g2;
								string text4;
								if (!g2.g.Contains(text4))
								{
									num4 = 31;
									continue;
								}
								goto IL_10A5;
							}
							case 104:
								if (a_.k.Equals("PCP"))
								{
									num4 = 108;
									continue;
								}
								goto IL_1C0E;
							case 105:
								num4 = 146;
								continue;
							case 106:
								if (a_.f)
								{
									num4 = 25;
									continue;
								}
								goto IL_E60;
							case 107:
								num4 = 17;
								continue;
							case 108:
								k3.e = this.d(a_);
								num4 = 139;
								continue;
							case 109:
							{
								bool flag4;
								if (flag4)
								{
									num4 = 23;
									continue;
								}
								goto IL_148E;
							}
							case 110:
								num4 = 19;
								continue;
							case 111:
							{
								int num20;
								if (num20 >= k3.h.Count)
								{
									num4 = 105;
									continue;
								}
								global::IshHandler.b b = (global::IshHandler.b)k3.h[num20];
								int num21 = int.Parse(b.c, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								int num22 = int.Parse(b.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								string text3;
								string text11 = text3.Substring(text3.Length - (num21 + num22), num22);
								b.g = text11;
								num20++;
								num4 = 84;
								continue;
							}
							case 112:
							{
								string a_2 = k3.e;
								int num23 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num23 /= 8;
								a_2 = this.b(a_2, num23);
								uint a_5 = this.b(k.d);
								uint a_6 = this.b(k.c);
								uint a_7 = this.b(a_2);
								bool flag4 = this.a(a_7, a_6, a_5, (uint)num23);
								num4 = 109;
								continue;
							}
							case 113:
							{
								global::IshHandler.b b2;
								if (b2.f.Equals("PRESERVE_YES"))
								{
									num4 = 207;
									continue;
								}
								text = text9.Substring(text9.Length - num15 - num5, num5);
								num4 = 204;
								continue;
							}
							case 114:
								goto IL_95D;
							case 115:
								goto IL_1A38;
							case 116:
							{
								global::IshHandler.b b2;
								if (b2.g != null)
								{
									num4 = 242;
									continue;
								}
								text = text9.Substring(text9.Length - num15 - num5, num5);
								num4 = 123;
								continue;
							}
							case 117:
								num4 = 132;
								continue;
							case 118:
								if (a_.k.Equals("PC_ATTEN"))
								{
									num4 = 96;
									continue;
								}
								goto IL_11D7;
							case 119:
								goto IL_1194;
							case 120:
								goto IL_229C;
							case 121:
								if (k2.h != null)
								{
									num4 = 110;
									continue;
								}
								goto IL_1B60;
							case 122:
								goto IL_10BC;
							case 123:
								goto IL_144A;
							case 124:
							{
								global::IshHandler.g g2;
								if (g2.b == num)
								{
									num4 = 188;
									continue;
								}
								goto IL_10A5;
							}
							case 125:
								goto IL_144A;
							case 126:
								goto IL_1E66;
							case 127:
								goto IL_6DF;
							case 128:
							{
								k3.i = k2.e;
								string text2;
								k3.e = text2;
								num4 = 70;
								continue;
							}
							case 129:
								if (k3.h.Count > 0)
								{
									num4 = 182;
									continue;
								}
								goto IL_E1D;
							case 130:
								goto IL_138C;
							case 131:
							{
								int a_8 = this.a(text10, 2);
								k.i = k.e;
								k.e = this.a((uint)a_8);
								num4 = 40;
								continue;
							}
							case 132:
							{
								if (flag)
								{
									num4 = 200;
									continue;
								}
								global::IshHandler.g g2;
								global::IshHandler.k k4 = (global::IshHandler.k)g2.d[num24];
								num4 = 239;
								continue;
							}
							case 133:
							{
								global::IshHandler.b b3;
								global::IshHandler.b b4;
								if (b3.a == b4.a)
								{
									num4 = 160;
									continue;
								}
								goto IL_B13;
							}
							case 134:
							{
								string text2;
								if (text2 != null)
								{
									num4 = 238;
									continue;
								}
								goto IL_B2A;
							}
							case 135:
							{
								string text12 = k2.e.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								int a_9 = int.Parse(text12, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
								string text13 = this.a(a_9, 2);
								int totalWidth2 = int.Parse(k2.b.ToString(global::System.Globalization.CultureInfo.InvariantCulture), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								text13 = text13.PadLeft(totalWidth2, '0');
								int num25 = 0;
								string empty5 = string.Empty;
								num4 = 191;
								continue;
							}
							case 136:
								goto IL_990;
							case 137:
								goto IL_D91;
							case 138:
								goto IL_1194;
							case 139:
								goto IL_1C0E;
							case 140:
								k3 = (global::IshHandler.k)a_.e[0];
								num4 = 237;
								continue;
							case 141:
								if (empty3.Equals(k.g))
								{
									num4 = 9;
									continue;
								}
								goto IL_15A9;
							case 142:
								num4 = 129;
								continue;
							case 143:
							{
								if (num17 >= k3.h.Count)
								{
									num4 = 89;
									continue;
								}
								global::IshHandler.b b = (global::IshHandler.b)k3.h[num17];
								int num13 = 0;
								num4 = 45;
								continue;
							}
							case 144:
								if (a_.g)
								{
									num4 = 137;
									continue;
								}
								goto IL_1BDA;
							case 145:
								if (num26 >= a_.e.Count)
								{
									num4 = 50;
									continue;
								}
								k3 = (global::IshHandler.k)a_.e[num26];
								num4 = 47;
								continue;
							case 146:
								goto IL_22CC;
							case 147:
								num4 = 193;
								continue;
							case 148:
							{
								int num13;
								if (num13 >= k.h.Count)
								{
									num4 = 183;
									continue;
								}
								global::IshHandler.b b2 = (global::IshHandler.b)k.h[num13];
								num4 = 83;
								continue;
							}
							case 149:
								if (empty4.Equals(k.a))
								{
									num4 = 54;
									continue;
								}
								goto IL_15A9;
							case 150:
								k3.e = this.b(a_);
								num4 = 85;
								continue;
							case 151:
								if (k2.h != null)
								{
									num4 = 107;
									continue;
								}
								goto IL_1154;
							case 152:
							{
								int num27;
								if (num27 >= k2.h.Count)
								{
									num4 = 226;
									continue;
								}
								global::IshHandler.b b = (global::IshHandler.b)k2.h[num27];
								string text7 = b.g.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + text7;
								num27++;
								num4 = 197;
								continue;
							}
							case 153:
								num4 = 106;
								continue;
							case 154:
								if (k3.h != null)
								{
									num4 = 147;
									continue;
								}
								goto IL_63C;
							case 155:
							{
								flag3 = false;
								arrayList2.Clear();
								arrayList.Clear();
								global::IshHandler.b b4 = (global::IshHandler.b)k2.h[0];
								int num28 = 0;
								num28 = int.Parse(b4.c, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num12 = 0;
								num4 = 66;
								continue;
							}
							case 156:
								num14 = (int)arrayList2[num12 - 1] + (int)arrayList[num12 - 1];
								goto IL_186A;
							case 157:
							{
								int num10;
								string text3 = text3.Substring(0, text3.Length - num10);
								num4 = 101;
								continue;
							}
							case 158:
							{
								global::IshHandler.g g2;
								if (num24 < g2.d.Count)
								{
									num4 = 117;
									continue;
								}
								goto IL_78A;
							}
							case 159:
								goto IL_990;
							case 160:
								flag3 = true;
								num4 = 49;
								continue;
							case 161:
								num4 = 119;
								continue;
							case 162:
								num4 = 29;
								continue;
							case 163:
							{
								if (k2.h.Count > 0)
								{
									num4 = 12;
									continue;
								}
								string text3 = k2.e;
								int num29 = int.Parse(k2.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num29 /= 8;
								text3 = text3.PadLeft(num29, '0');
								num4 = 236;
								continue;
							}
							case 164:
								goto IL_120A;
							case 165:
								if (num18 < num30)
								{
									num4 = 164;
									continue;
								}
								goto IL_6DF;
							case 166:
								goto IL_437;
							case 167:
								goto IL_1D9C;
							case 168:
								goto IL_1E9A;
							case 169:
								if (num31 >= a_.c.Count)
								{
									num4 = 162;
									continue;
								}
								k2 = (global::IshHandler.k)a_.c[num31];
								empty2 = k2.a;
								num24 = 0;
								num4 = 74;
								continue;
							case 170:
							{
								int num25;
								if (num25 >= k3.h.Count)
								{
									num4 = 79;
									continue;
								}
								global::IshHandler.b b5 = (global::IshHandler.b)k3.h[num25];
								int num32 = int.Parse(b5.c.ToString(global::System.Globalization.CultureInfo.InvariantCulture), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								int num33 = int.Parse(b5.b.ToString(global::System.Globalization.CultureInfo.InvariantCulture), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								string text13;
								b5.g = text13.Substring(text13.Length - num33 - num32, num33);
								k3.h[num25] = b5;
								num25++;
								num4 = 80;
								continue;
							}
							case 171:
								if (num6 < g.d.Count)
								{
									num4 = 210;
									continue;
								}
								goto IL_1C9A;
							case 172:
								num4 = 156;
								continue;
							case 173:
								flag = false;
								num4 = 73;
								continue;
							case 174:
								goto IL_929;
							case 175:
								goto IL_15C0;
							case 176:
							{
								int num27 = 0;
								num4 = 100;
								continue;
							}
							case 177:
								if (k3.h != null)
								{
									num4 = 142;
									continue;
								}
								goto IL_E1D;
							case 178:
								num4 = 144;
								continue;
							case 179:
								goto IL_D18;
							case 180:
								goto IL_11D7;
							case 181:
								goto IL_10FE;
							case 182:
							{
								global::IshHandler.b b = (global::IshHandler.b)k2.h[0];
								global::IshHandler.b b2 = (global::IshHandler.b)k3.h[0];
								b2.g = b.g;
								k3.h[0] = b2;
								num4 = 209;
								continue;
							}
							case 183:
								goto IL_10BC;
							case 184:
							{
								global::IshHandler.b b = (global::IshHandler.b)k3.h[0];
								string str;
								int a_10 = int.Parse(str, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
								b.g = this.a(a_10, 2);
								num4 = 71;
								continue;
							}
							case 185:
								goto IL_A73;
							case 186:
								num4 = 56;
								continue;
							case 187:
								goto IL_1D07;
							case 188:
								num4 = 103;
								continue;
							case 189:
								goto IL_148E;
							case 190:
							{
								global::IshHandler.k k4;
								if (num12 >= k4.h.Count)
								{
									num4 = 227;
									continue;
								}
								global::IshHandler.b b3 = (global::IshHandler.b)k4.h[num12];
								int num34 = int.Parse(b3.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								arrayList.Add(num34);
								num4 = 67;
								continue;
							}
							case 191:
								goto IL_A1A;
							case 192:
								num4 = 34;
								continue;
							case 193:
								if (k3.h.Count > 0)
								{
									num4 = 90;
									continue;
								}
								goto IL_63C;
							case 194:
							{
								global::IshHandler.g g2;
								a_.j = g2.c;
								global::IshHandler.h h = default(global::IshHandler.h);
								h = this.g(a_);
								this.v.a.Add(h);
								num4 = 7;
								continue;
							}
							case 195:
							{
								string text14 = k2.e.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								int a_11 = int.Parse(text14, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
								string text15 = this.a(a_11, 2);
								int num35 = 0;
								num4 = 16;
								continue;
							}
							case 196:
								goto IL_E49;
							case 197:
								goto IL_8F9;
							case 198:
								goto IL_1DFC;
							case 199:
								if (k2.h.Count > 0)
								{
									num4 = 195;
									continue;
								}
								goto IL_14D0;
							case 200:
								goto IL_78A;
							case 201:
								goto IL_1C9A;
							case 202:
								if (num36 >= a_.e.Count)
								{
									num4 = 115;
									continue;
								}
								k3 = (global::IshHandler.k)a_.e[num36];
								empty3 = a_.d;
								empty4 = k3.a;
								num6 = 0;
								flag2 = false;
								num4 = 185;
								continue;
							case 203:
								goto IL_15A9;
							case 204:
								goto IL_6DF;
							case 205:
								goto IL_E60;
							case 206:
							{
								global::IshHandler.b b2;
								if (b2.d.Length > 0)
								{
									num4 = 219;
									continue;
								}
								goto IL_11A8;
							}
							case 207:
								num4 = 116;
								continue;
							case 208:
								num4 = 78;
								continue;
							case 209:
								goto IL_EE8;
							case 210:
								num4 = 4;
								continue;
							case 211:
							{
								int num28;
								if ((int)arrayList2[num12] == num28)
								{
									num4 = 39;
									continue;
								}
								goto IL_B13;
							}
							case 212:
								goto IL_1194;
							case 213:
							{
								string text3;
								int num10;
								if (text3.Length - num10 > 0)
								{
									num4 = 157;
									continue;
								}
								goto IL_22CC;
							}
							case 214:
								if (a_.g)
								{
									num4 = 196;
									continue;
								}
								goto IL_1BB4;
							case 215:
								goto IL_11A8;
							case 216:
							{
								string text6;
								if (!(text6 == "RECALC"))
								{
									num4 = 161;
									continue;
								}
								k2 = (global::IshHandler.k)a_.c[0];
								k3 = (global::IshHandler.k)a_.e[0];
								num4 = 230;
								continue;
							}
							case 217:
								goto IL_8C9;
							case 218:
								goto IL_1BDA;
							case 219:
							{
								global::IshHandler.b b2;
								num30 = int.Parse(b2.d, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
								num4 = 215;
								continue;
							}
							case 220:
								k3.i = k2.e;
								k3.e = k2.e;
								num4 = 33;
								continue;
							case 221:
								flag = true;
								flag3 = true;
								num4 = 82;
								continue;
							case 222:
								num4 = 121;
								continue;
							case 223:
								if (g.c == a_.j)
								{
									num4 = 205;
									continue;
								}
								goto IL_1A38;
							case 224:
								goto IL_1328;
							case 225:
								goto IL_437;
							case 226:
							{
								string text7;
								int a_12 = this.a(text7, 2);
								string str = this.a((uint)a_12) + str;
								num4 = 22;
								continue;
							}
							case 227:
								goto IL_1B60;
							case 228:
								goto IL_8C9;
							case 229:
							{
								global::IshHandler.b b2;
								if (b2.e.Length > 0)
								{
									num4 = 92;
									continue;
								}
								goto IL_1D07;
							}
							case 230:
							{
								if (a_.m.Equals("NONE"))
								{
									num4 = 220;
									continue;
								}
								string text2 = string.Empty;
								num4 = 243;
								continue;
							}
							case 231:
								text = text.PadLeft(num5, '0');
								num4 = 179;
								continue;
							case 232:
								if (num37 >= k2.h.Count)
								{
									num4 = 43;
									continue;
								}
								text5 = ((global::IshHandler.b)k2.h[num37]).g + text5;
								num37++;
								num4 = 46;
								continue;
							case 233:
							{
								int num20 = 0;
								num4 = 120;
								continue;
							}
							case 234:
								if (num38 >= this.u.a.Count)
								{
									num4 = 41;
									continue;
								}
								g = (global::IshHandler.g)this.u.a[num38];
								num4 = 10;
								continue;
							case 235:
								goto IL_10A5;
							case 236:
								goto IL_1F40;
							case 237:
							{
								if (k3.h.Count > 0)
								{
									num4 = 184;
									continue;
								}
								k3.i = k3.e;
								string str;
								k3.e = str;
								num4 = 138;
								continue;
							}
							case 238:
							{
								string text2;
								k3.e = text2;
								num4 = 65;
								continue;
							}
							case 239:
							{
								global::IshHandler.k k4;
								if (empty.Equals(k4.g))
								{
									num4 = 21;
									continue;
								}
								goto IL_14D0;
							}
							case 240:
							{
								int num35;
								if (num35 >= k2.h.Count)
								{
									num4 = 102;
									continue;
								}
								global::IshHandler.b b = (global::IshHandler.b)k2.h[num35];
								int num39 = int.Parse(b.c, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								int num40 = int.Parse(b.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								string text15 = text15.PadLeft(num39 + num40, '0');
								string text16 = text15.Substring(text15.Length - (num39 + num40), num40);
								b.g = text16;
								k2.h[num35] = b;
								num35++;
								num4 = 168;
								continue;
							}
							case 241:
							{
								if (num16 >= k.h.Count)
								{
									num4 = 131;
									continue;
								}
								global::IshHandler.b b2 = (global::IshHandler.b)k.h[num16];
								num5 = int.Parse(b2.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								text = string.Empty;
								num4 = 113;
								continue;
							}
							case 242:
							{
								global::IshHandler.b b2;
								text = b2.g;
								num4 = 125;
								continue;
							}
							case 243:
								if (a_.k.Equals("KCP1"))
								{
									num4 = 60;
									continue;
								}
								goto IL_B2A;
							}
							break;
							IL_437:
							num4 = 241;
							continue;
							IL_479:
							num4 = 190;
							continue;
							IL_541:
							a_.e[0] = k3;
							num4 = 212;
							continue;
							IL_5E6:
							num4 = 169;
							continue;
							IL_63C:
							num4 = 15;
							continue;
							IL_6DF:
							num15 += num5;
							num16++;
							num4 = 1;
							continue;
							IL_78A:
							a_.c[num31] = k2;
							num31++;
							num4 = 35;
							continue;
							IL_8C9:
							num4 = 145;
							continue;
							IL_8F9:
							num4 = 152;
							continue;
							IL_929:
							num4 = 53;
							continue;
							IL_95D:
							num4 = 62;
							continue;
							IL_990:
							num4 = 63;
							continue;
							IL_A1A:
							num4 = 170;
							continue;
							IL_A73:
							num4 = 171;
							continue;
							IL_B13:
							num12++;
							num4 = 99;
							continue;
							IL_B2A:
							num4 = 59;
							continue;
							IL_D18:
							num4 = 26;
							continue;
							IL_D91:
							num4 = 64;
							continue;
							IL_E1D:
							num37 = 0;
							text5 = string.Empty;
							num4 = 224;
							continue;
							IL_E49:
							num38++;
							num4 = 130;
							continue;
							IL_E60:
							num36 = 0;
							num4 = 27;
							continue;
							IL_EE8:
							k3.i = k3.e;
							k3.e = k2.e;
							a_.e[0] = k3;
							num4 = 8;
							continue;
							IL_10A5:
							num9++;
							num4 = 174;
							continue;
							IL_10BC:
							num17++;
							num4 = 57;
							continue;
							IL_10FE:
							num4 = 202;
							continue;
							IL_1154:
							num4 = 55;
							continue;
							IL_1194:
							num38 = 0;
							num4 = 51;
							continue;
							IL_11A8:
							num4 = 229;
							continue;
							IL_11D7:
							num4 = 2;
							continue;
							IL_120A:
							text = text9.Substring(text9.Length - num15 - num5, num5);
							num4 = 127;
							continue;
							IL_1328:
							num4 = 232;
							continue;
							IL_138C:
							num4 = 234;
							continue;
							IL_144A:
							num18 = this.a(text, 2);
							num30 = 0;
							num19 = 255;
							num4 = 206;
							continue;
							IL_148E:
							flag2 = true;
							g.d[num6] = k;
							this.u.a[num38] = g;
							num4 = 203;
							continue;
							IL_14D0:
							num24++;
							num4 = 98;
							continue;
							IL_15A9:
							num6++;
							num4 = 30;
							continue;
							IL_15C0:
							text10 = text + text10;
							num4 = 225;
							continue;
							IL_17CE:
							num4 = 148;
							continue;
							IL_186A:
							int num41 = num14;
							arrayList2.Add(num41);
							num4 = 211;
							continue;
							IL_1A38:
							num4 = 214;
							continue;
							IL_1B60:
							num4 = 44;
							continue;
							IL_1B84:
							num4 = 104;
							continue;
							IL_1BB4:
							num4 = 13;
							continue;
							IL_1BDA:
							flag = false;
							flag2 = false;
							num3++;
							num4 = 126;
							continue;
							IL_1BF7:
							num11++;
							num4 = 159;
							continue;
							IL_1C0E:
							num4 = 76;
							continue;
							IL_1C41:
							num31 = 0;
							num4 = 42;
							continue;
							IL_1C9A:
							num36++;
							num4 = 181;
							continue;
							IL_1D07:
							num4 = 91;
							continue;
							IL_1D9C:
							num4 = 143;
							continue;
							IL_1DCC:
							num4 = 158;
							continue;
							IL_1DFC:
							num4 = 118;
							continue;
							IL_1E66:
							num4 = 97;
							continue;
							IL_1E9A:
							num4 = 240;
							continue;
							IL_1F40:
							num26 = 0;
							num4 = 228;
							continue;
							IL_229C:
							num4 = 111;
							continue;
							IL_22CC:
							num26++;
							num4 = 217;
						}
					}
					IL_2300:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.Collect();
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
						ex.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
						break;
					}
				}
				throw;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00008EB4 File Offset: 0x00007EB4
		private void f(global::IshHandler.h A_0)
		{
			switch (0)
			{
			default:
			{
				global::IshHandler.g g2;
				int num6;
				for (;;)
				{
					global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
					int num = 0;
					int num2 = 29;
					for (;;)
					{
						int num3;
						int num4;
						string text2;
						switch (num2)
						{
						case 0:
							goto IL_162;
						case 1:
						{
							global::IshHandler.k k = (global::IshHandler.k)A_0.c[0];
							num3 = 0;
							num2 = 21;
							continue;
						}
						case 2:
							goto IL_21A;
						case 3:
						{
							global::IshHandler.g g;
							if (num3 >= g.d.Count)
							{
								goto IL_239;
							}
							global::IshHandler.k k2 = (global::IshHandler.k)g.d[num3];
							num2 = 28;
							continue;
						}
						case 4:
							goto IL_162;
						case 5:
							goto IL_329;
						case 6:
							goto IL_27A;
						case 7:
						{
							if (num4 >= g2.d.Count)
							{
								num2 = 34;
								continue;
							}
							global::IshHandler.k k3 = (global::IshHandler.k)g2.d[num4];
							num2 = 14;
							continue;
						}
						case 8:
						{
							global::IshHandler.g g;
							if (g.b == A_0.h)
							{
								num2 = 1;
								continue;
							}
							num++;
							num2 = 33;
							continue;
						}
						case 9:
						{
							global::IshHandler.k k = (global::IshHandler.k)A_0.c[0];
							global::IshHandler.k k4 = (global::IshHandler.k)A_0.e[0];
							global::IshHandler.k k5 = (global::IshHandler.k)A_0.e[1];
							string text = global::b.a(text2, null, 1U);
							int num5 = 0;
							string empty = string.Empty;
							num4 = 0;
							num2 = 23;
							continue;
						}
						case 10:
							goto IL_2AE;
						case 11:
						{
							global::IshHandler.k k3;
							k3.e = "01";
							g2.d[num4] = k3;
							num2 = 22;
							continue;
						}
						case 12:
							return;
						case 13:
							goto IL_2AE;
						case 14:
						{
							global::IshHandler.k k3;
							global::IshHandler.k k5;
							if (k5.a.Equals(k3.a))
							{
								num2 = 11;
								continue;
							}
							if (true)
							{
							}
							num2 = 39;
							continue;
						}
						case 15:
							if (!string.IsNullOrEmpty(text2))
							{
								num6 = 0;
								num2 = 35;
								continue;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_239;
							default:
								if (false)
								{
								}
								num2 = 18;
								continue;
							}
							break;
						case 16:
						{
							global::IshHandler.k k2;
							string text3 = k2.e;
							int num7 = 0;
							num2 = 4;
							continue;
						}
						case 17:
							goto IL_24A;
						case 18:
							return;
						case 19:
						{
							if (num >= this.t.a.Count)
							{
								num2 = 13;
								continue;
							}
							global::IshHandler.g g = (global::IshHandler.g)this.t.a[num];
							num2 = 8;
							continue;
						}
						case 20:
							arrayList.Reverse();
							num2 = 31;
							continue;
						case 21:
							goto IL_21A;
						case 22:
							goto IL_18D;
						case 23:
							goto IL_24A;
						case 24:
							goto IL_18D;
						case 25:
						{
							string text;
							int num5;
							if (num5 <= text.Length - 2)
							{
								num2 = 27;
								continue;
							}
							goto IL_18D;
						}
						case 26:
							if (this.ai == global::IshHandler.i.c)
							{
								num2 = 20;
								continue;
							}
							goto IL_52D;
						case 27:
						{
							global::IshHandler.k k3;
							string text;
							int num5;
							k3.e = text.Substring(num5, 2);
							num5 += 2;
							g2.d[num4] = k3;
							num2 = 24;
							continue;
						}
						case 28:
						{
							global::IshHandler.k k;
							global::IshHandler.k k2;
							if (k.g.Equals(k2.g))
							{
								num2 = 16;
								continue;
							}
							goto IL_329;
						}
						case 29:
							goto IL_40F;
						case 30:
							num2 = 25;
							continue;
						case 31:
							goto IL_52D;
						case 32:
							if (g2.b == A_0.i)
							{
								num2 = 9;
								continue;
							}
							num6++;
							num2 = 6;
							continue;
						case 33:
							goto IL_40F;
						case 34:
							goto IL_275;
						case 35:
							goto IL_27A;
						case 36:
							if (num6 >= this.u.a.Count)
							{
								num2 = 12;
								continue;
							}
							g2 = (global::IshHandler.g)this.u.a[num6];
							num2 = 32;
							continue;
						case 37:
							num2 = 10;
							continue;
						case 38:
							num2 = 41;
							continue;
						case 39:
						{
							global::IshHandler.k k3;
							global::IshHandler.k k4;
							if (k4.g.Equals(k3.g))
							{
								num2 = 38;
								continue;
							}
							goto IL_18D;
						}
						case 40:
						{
							string text3;
							int num7;
							if (num7 >= text3.Length)
							{
								num2 = 5;
								continue;
							}
							string text4 = text3.Substring(num7, 2);
							arrayList.Add(byte.Parse(text4, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture));
							num7 += 2;
							num2 = 0;
							continue;
						}
						case 41:
						{
							int num5;
							if (num5 >= 0)
							{
								num2 = 30;
								continue;
							}
							goto IL_18D;
						}
						}
						break;
						IL_162:
						num2 = 40;
						continue;
						IL_18D:
						num4++;
						num2 = 17;
						continue;
						IL_21A:
						num2 = 3;
						continue;
						IL_239:
						num2 = 37;
						continue;
						IL_24A:
						num2 = 7;
						continue;
						IL_27A:
						num2 = 36;
						continue;
						IL_2AE:
						num2 = 26;
						continue;
						IL_329:
						num3++;
						num2 = 2;
						continue;
						IL_40F:
						num2 = 19;
						continue;
						IL_52D:
						global::System.Collections.Generic.List<uint> a_ = global::IshHandler.f.a(arrayList, 16, this.ai == global::IshHandler.i.b);
						text2 = global::IshHandler.f.a(a_);
						num2 = 15;
					}
				}
				IL_275:
				this.u.a[num6] = g2;
				return;
			}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000094D8 File Offset: 0x000084D8
		private static global::System.Collections.Generic.List<uint> a(global::System.Collections.ArrayList A_0, int A_1, bool A_2)
		{
			switch (0)
			{
			default:
			{
				global::System.Collections.Generic.List<uint> list = new global::System.Collections.Generic.List<uint>();
				int num = A_1 / 8;
				try
				{
					int num2 = 7;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_168;
						case 1:
							if (A_1 <= 8)
							{
								num2 = 17;
								continue;
							}
							num2 = 29;
							continue;
						case 2:
							num2 = 3;
							continue;
						case 3:
						{
							if (A_1 != 8)
							{
								num2 = 32;
								continue;
							}
							global::System.Collections.IEnumerator enumerator = A_0.GetEnumerator();
							num2 = 15;
							continue;
						}
						case 4:
							goto IL_11E;
						case 5:
							goto IL_11E;
						case 6:
							goto IL_F4;
						case 8:
						{
							int num3;
							if (num3 >= A_0.Count)
							{
								num2 = 16;
								continue;
							}
							uint num4 = (global::System.Convert.ToUInt32(A_0[num3]) << 24) + (global::System.Convert.ToUInt32(A_0[num3 + 1]) << 16) + (global::System.Convert.ToUInt32(A_0[num3 + 2]) << 8) + global::System.Convert.ToUInt32(A_0[num3 + 3]);
							list.Add(num4);
							num3 += num;
							num2 = 0;
							continue;
						}
						case 9:
						{
							if (A_1 != 4)
							{
								num2 = 2;
								continue;
							}
							global::System.Collections.IEnumerator enumerator2 = A_0.GetEnumerator();
							num2 = 25;
							continue;
						}
						case 10:
							num2 = 5;
							continue;
						case 11:
							goto IL_3BF;
						case 12:
							goto IL_290;
						case 13:
							goto IL_4D3;
						case 14:
							if (A_1 >= 8)
							{
								num2 = 24;
								continue;
							}
							goto IL_548;
						case 15:
							try
							{
								num2 = 2;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num2 = 1;
										continue;
									case 1:
										goto IL_485;
									case 4:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num2 = 0;
											continue;
										}
										byte value = (byte)enumerator.Current;
										list.Add(global::System.Convert.ToUInt32(value));
										num2 = 3;
										continue;
									}
									}
									IL_439:
									num2 = 4;
									continue;
									goto IL_439;
								}
								IL_485:
								goto IL_11E;
							}
							finally
							{
								for (;;)
								{
									global::System.Collections.IEnumerator enumerator;
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									num2 = 1;
									for (;;)
									{
										switch (num2)
										{
										case 0:
											disposable.Dispose();
											num2 = 2;
											continue;
										case 1:
											if (disposable != null)
											{
												num2 = 0;
												continue;
											}
											goto IL_4D2;
										case 2:
											goto IL_4D0;
										}
										break;
									}
								}
								IL_4D0:
								IL_4D2:;
							}
							goto IL_4D3;
						case 16:
							goto IL_11E;
						case 17:
							num2 = 9;
							continue;
						case 18:
							goto IL_F4;
						case 19:
							num2 = 4;
							continue;
						case 20:
							num2 = 31;
							continue;
						case 21:
							if (!A_2)
							{
								num2 = 30;
								continue;
							}
							goto IL_548;
						case 22:
							goto IL_548;
						case 23:
							if (!A_2)
							{
								num2 = 13;
								continue;
							}
							goto IL_3BF;
						case 24:
							num2 = 21;
							continue;
						case 25:
							try
							{
								num2 = 2;
								for (;;)
								{
									global::System.Collections.IEnumerator enumerator2;
									switch (num2)
									{
									case 0:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1CE;
										default:
											goto IL_23C;
										}
										break;
									case 1:
										num2 = 0;
										continue;
									case 3:
										if (!enumerator2.MoveNext())
										{
											num2 = 1;
											continue;
										}
										goto IL_1CE;
									}
									goto IL_1CC;
									IL_1CE:
									byte value2 = (byte)enumerator2.Current;
									uint num4 = global::System.Convert.ToUInt32(value2);
									list.Add(num4 >> 4);
									list.Add(num4 & 15U);
									num2 = 4;
									continue;
									IL_200:
									num2 = 3;
									continue;
									IL_1CC:
									goto IL_200;
								}
								IL_23C:
								if (false)
								{
								}
								goto IL_11E;
							}
							finally
							{
								for (;;)
								{
									global::System.Collections.IEnumerator enumerator2;
									global::System.IDisposable disposable2 = enumerator2 as global::System.IDisposable;
									num2 = 2;
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_28D;
										case 1:
											disposable2.Dispose();
											num2 = 0;
											continue;
										case 2:
											if (disposable2 != null)
											{
												num2 = 1;
												continue;
											}
											goto IL_28F;
										}
										break;
									}
								}
								IL_28D:
								IL_28F:;
							}
							goto IL_290;
						case 26:
						{
							int num5;
							if (num5 >= A_0.Count)
							{
								num2 = 10;
								continue;
							}
							uint num4 = (global::System.Convert.ToUInt32(A_0[num5]) << 8) + global::System.Convert.ToUInt32(A_0[num5 + 1]);
							list.Add(num4);
							num5 += num;
							num2 = 18;
							continue;
						}
						case 27:
							goto IL_554;
						case 28:
							goto IL_168;
						case 29:
						{
							if (A_1 != 16)
							{
								num2 = 20;
								continue;
							}
							int num5 = 0;
							num2 = 6;
							continue;
						}
						case 30:
							list.Reverse();
							num2 = 22;
							continue;
						case 31:
						{
							if (A_1 != 32)
							{
								num2 = 19;
								continue;
							}
							int num3 = 0;
							num2 = 28;
							continue;
						}
						case 32:
							num2 = 33;
							continue;
						case 33:
							goto IL_11E;
						}
						if (A_1 < 8)
						{
							num2 = 12;
							continue;
						}
						goto IL_3BF;
						IL_F4:
						num2 = 26;
						continue;
						IL_11E:
						num2 = 14;
						continue;
						IL_168:
						num2 = 8;
						continue;
						IL_290:
						num2 = 23;
						continue;
						IL_3BF:
						num2 = 1;
						continue;
						IL_4D3:
						A_0.Reverse();
						num2 = 11;
						continue;
						IL_548:
						num2 = 27;
					}
					IL_554:;
				}
				catch (global::System.OverflowException)
				{
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1089U, "CDataConvert", "CvtByteArray2CodeSequence", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.Exception ex2)
				{
					global::custom_exception.CCustomException.Rethrow(ex2);
				}
				if (true)
				{
				}
				return list;
			}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00009B04 File Offset: 0x00008B04
		private static string a(global::System.Collections.Generic.List<uint> A_0)
		{
			switch (0)
			{
			default:
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				try
				{
					using (global::System.Collections.Generic.List<uint>.Enumerator enumerator = A_0.GetEnumerator())
					{
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 1:
								goto IL_E2;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = 3;
									continue;
								}
								uint value = enumerator.Current;
								char value2 = global::System.Convert.ToChar(value);
								goto IL_99;
							}
							case 3:
								goto IL_D6;
							case 4:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_99;
								default:
								{
									if (false)
									{
									}
									char value2;
									if (!value2.Equals('\0'))
									{
										num = 6;
										continue;
									}
									goto IL_D6;
								}
								}
								break;
							case 6:
							{
								char value2;
								stringBuilder.Append(value2);
								num = 5;
								continue;
							}
							}
							IL_5A:
							num = 2;
							continue;
							goto IL_5A;
							IL_99:
							num = 4;
							continue;
							IL_D6:
							num = 1;
						}
						IL_E2:;
					}
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.OverflowException)
				{
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1089U, "CDataConvert", "CodeSequence2String", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex;
				}
				catch (global::System.Exception ex2)
				{
					global::custom_exception.CCustomException.Rethrow(ex2);
				}
				if (true)
				{
				}
				return stringBuilder.ToString();
			}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00009C7C File Offset: 0x00008C7C
		private string b(global::IshHandler.h A_0, global::IshHandler.g A_1)
		{
			string result;
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						string text = string.Empty;
						int num = 0;
						int num2 = 0;
						for (;;)
						{
							double num3;
							global::IshHandler.k k;
							double num4;
							switch (num2)
							{
							case 0:
								goto IL_2E0;
							case 1:
								text = this.a("LINEAR", A_0.m);
								num2 = 7;
								continue;
							case 2:
								if (num3 > 32768.0)
								{
									num2 = 14;
									continue;
								}
								goto IL_473;
							case 3:
								num2 = 39;
								continue;
							case 4:
								num2 = 12;
								continue;
							case 5:
								if (num3 < 0.0)
								{
									num2 = 15;
									continue;
								}
								result = this.a((uint)global::System.Math.Abs(num3));
								num2 = 16;
								continue;
							case 6:
								if (this.d(k.e, 16))
								{
									num2 = 11;
									continue;
								}
								num4 = (double)int.Parse(k.e, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
								num2 = 20;
								continue;
							case 7:
								goto IL_23C;
							case 8:
								goto IL_1B8;
							case 9:
								if (num3 >= 0.0)
								{
									num2 = 24;
									continue;
								}
								goto IL_473;
							case 10:
							{
								global::IshHandler.k k2;
								if (k2.a.Equals("Tx Pa Characterization Parameter Mcp1"))
								{
									num2 = 19;
									continue;
								}
								goto IL_1DF;
							}
							case 11:
								num4 = (double)this.c(k.e, 16);
								num4 = -num4;
								num2 = 35;
								continue;
							case 12:
								if (num3 <= 32768.0)
								{
									num2 = 32;
									continue;
								}
								goto IL_1A9;
							case 13:
								goto IL_3E9;
							case 14:
								goto IL_1A9;
							case 15:
								result = this.a((long)num3, 16);
								num2 = 33;
								continue;
							case 16:
								goto IL_570;
							case 17:
								num2 = 21;
								continue;
							case 18:
								goto IL_51F;
							case 19:
								goto IL_121;
							case 20:
								goto IL_4A0;
							case 21:
							{
								global::IshHandler.k k2;
								if (!k2.a.Equals("Tx Pa Characterization Parameter Mcp"))
								{
									num2 = 22;
									continue;
								}
								goto IL_121;
							}
							case 22:
								num2 = 10;
								continue;
							case 23:
							{
								if (num >= A_1.d.Count)
								{
									num2 = 3;
									continue;
								}
								global::IshHandler.k k2 = (global::IshHandler.k)A_1.d[num];
								num2 = 37;
								continue;
							}
							case 24:
								num2 = 2;
								continue;
							case 25:
							{
								if (this.d(text, 16))
								{
									num2 = 28;
									continue;
								}
								double num5 = (double)int.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
								num2 = 36;
								continue;
							}
							case 26:
							{
								num4 *= 100.0;
								num4 *= global::System.Math.Pow(-2.0, 3.0);
								double num5;
								num4 /= num5;
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_473;
								default:
									if (false)
									{
									}
									num2 = 18;
									continue;
								}
								break;
							}
							case 27:
								goto IL_51F;
							case 28:
							{
								double num5 = (double)this.c(text, 16);
								num5 = -num5;
								num2 = 13;
								continue;
							}
							case 29:
								goto IL_2E0;
							case 30:
							{
								if (A_0.m.Equals("UPGRADE"))
								{
									num2 = 26;
									continue;
								}
								double num5;
								num4 *= num5;
								num4 /= global::System.Math.Pow(-2.0, 3.0) * 100.0;
								num2 = 27;
								continue;
							}
							case 31:
							{
								global::IshHandler.k k2;
								text = k2.i;
								num2 = 41;
								continue;
							}
							case 32:
								goto IL_F4;
							case 33:
								goto IL_237;
							case 34:
							{
								if (A_0.m.Equals("UPGRADE"))
								{
									num2 = 31;
									continue;
								}
								global::IshHandler.k k2;
								text = k2.j;
								num2 = 40;
								continue;
							}
							case 35:
								goto IL_4A0;
							case 36:
								goto IL_3E9;
							case 37:
							{
								global::IshHandler.k k2;
								if (k2.g.Equals("\\Composite Data"))
								{
									num2 = 17;
									continue;
								}
								goto IL_1DF;
							}
							case 38:
								if (num3 < 0.0)
								{
									num2 = 4;
									continue;
								}
								goto IL_F4;
							case 39:
								if (text.Length == 0)
								{
									num2 = 1;
									continue;
								}
								goto IL_23C;
							case 40:
								goto IL_1DF;
							case 41:
								goto IL_1DF;
							}
							break;
							IL_F4:
							num2 = 9;
							continue;
							IL_121:
							num2 = 34;
							continue;
							IL_1A9:
							result = null;
							num2 = 8;
							continue;
							IL_1DF:
							num++;
							num2 = 29;
							continue;
							IL_23C:
							k = (global::IshHandler.k)A_0.c[0];
							num2 = 6;
							continue;
							IL_2E0:
							num2 = 23;
							continue;
							IL_3E9:
							num2 = 30;
							continue;
							IL_473:
							num2 = 5;
							continue;
							IL_4A0:
							num2 = 25;
							continue;
							IL_51F:
							num3 = global::System.Math.Round(num4);
							num2 = 38;
						}
					}
					IL_1B8:
					IL_237:
					IL_570:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.Collect();
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					ex.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				if (true)
				{
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000A28C File Offset: 0x0000928C
		private string e(global::IshHandler.h A_0)
		{
			string result;
			try
			{
				switch (0)
				{
				default:
					if (true)
					{
					}
					for (;;)
					{
						global::IshHandler.k k = (global::IshHandler.k)A_0.c[0];
						double num = 0.0;
						int num2 = 4;
						for (;;)
						{
							double num3;
							double value;
							switch (num2)
							{
							case 0:
								goto IL_17D;
							case 1:
								goto IL_DF;
							case 2:
								if (num3 < 0.0)
								{
									num2 = 5;
									continue;
								}
								result = this.a((uint)global::System.Math.Abs(value));
								num2 = 0;
								continue;
							case 3:
								goto IL_C0;
							case 4:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_C0;
								default:
									if (false)
									{
									}
									if (this.d(k.e, 16))
									{
										num2 = 7;
										continue;
									}
									num = (double)int.Parse(k.e, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
									num2 = 6;
									continue;
								}
								break;
							case 5:
								result = this.a((long)global::System.Math.Abs(num3), 16);
								num2 = 1;
								continue;
							case 6:
								goto IL_10A;
							case 7:
								num = (double)this.c(k.e, 16);
								num = -num;
								num2 = 3;
								continue;
							}
							break;
							IL_10A:
							num3 = global::System.Math.Pow(2.0, 7.0);
							num3 *= 10000.0;
							num3 /= num;
							value = global::System.Math.Round(num3);
							num2 = 2;
							continue;
							IL_C0:
							goto IL_10A;
						}
					}
					IL_DF:
					IL_17D:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.Collect();
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					ex.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000A4A4 File Offset: 0x000094A4
		private string d(global::IshHandler.h A_0)
		{
			string result;
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
						IL_101:
						num = 4;
						break;
					default:
						if (false)
						{
						}
						goto IL_47;
					}
					double num2;
					double num3;
					for (;;)
					{
						IL_2C:
						switch (num)
						{
						case 0:
							if (A_0.m.Equals("UPGRADE"))
							{
								num = 1;
								continue;
							}
							goto IL_D9;
						case 1:
							num2 = global::System.Math.Pow(2.0, 7.0);
							num2 /= 100.0;
							num2 *= num3;
							num = 2;
							continue;
						case 2:
							goto IL_10F;
						case 3:
							goto IL_131;
						case 4:
							goto IL_10F;
						}
						goto IL_47;
						IL_10F:
						double value = global::System.Math.Round(num2);
						result = this.a((uint)global::System.Math.Abs(value));
						num = 3;
					}
					IL_D9:
					num2 = 100.0;
					num2 /= global::System.Math.Pow(2.0, 7.0);
					num2 *= num3;
					goto IL_101;
					IL_131:
					break;
					IL_47:
					num3 = (double)int.Parse(((global::IshHandler.k)A_0.c[0]).e, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
					num2 = 0.0;
					num = 0;
					goto IL_2C;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.Collect();
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					if (true)
					{
					}
					ex.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000A678 File Offset: 0x00009678
		private string a(string A_0, string A_1)
		{
			string result;
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						global::IshHandler.j j = this.u;
						string empty = string.Empty;
						int num = 0;
						int num2 = 23;
						for (;;)
						{
							global::IshHandler.k k;
							int num3;
							switch (num2)
							{
							case 0:
								goto IL_15E;
							case 1:
								num2 = 10;
								continue;
							case 2:
								goto IL_163;
							case 3:
								if (A_0.Equals("NEW"))
								{
									num2 = 28;
									continue;
								}
								goto IL_163;
							case 4:
								num2 = 20;
								continue;
							case 5:
								goto IL_1C0;
							case 6:
								goto IL_2F8;
							case 7:
								goto IL_341;
							case 8:
								if (k.g.Equals("\\Composite Data"))
								{
									num2 = 25;
									continue;
								}
								goto IL_124;
							case 9:
								goto IL_3AF;
							case 10:
								if (k.a.Equals("Tx Pa Characterization Parameter Mcp1"))
								{
									num2 = 7;
									continue;
								}
								goto IL_124;
							case 11:
								num3 = 0;
								num2 = 19;
								continue;
							case 12:
								if (A_0.Equals("LINEAR"))
								{
									num2 = 26;
									continue;
								}
								goto IL_124;
							case 13:
								empty = k.e;
								num2 = 15;
								continue;
							case 14:
								goto IL_FB;
							case 15:
								goto IL_124;
							case 16:
							{
								if (num >= j.a.Count)
								{
									num2 = 18;
									continue;
								}
								global::IshHandler.g g = (global::IshHandler.g)j.a[num];
								num2 = 30;
								continue;
							}
							case 17:
								empty = k.e;
								num2 = 2;
								continue;
							case 18:
								num2 = 29;
								continue;
							case 19:
								goto IL_2F8;
							case 20:
							{
								global::IshHandler.g g;
								if (g.c == 6U)
								{
									num2 = 11;
									continue;
								}
								goto IL_FB;
							}
							case 21:
								if (A_1.Equals("DOWNGRADE"))
								{
									num2 = 13;
									continue;
								}
								goto IL_124;
							case 22:
							{
								global::IshHandler.g g;
								if (num3 >= g.d.Count)
								{
									num2 = 14;
									continue;
								}
								k = (global::IshHandler.k)g.d[num3];
								num2 = 8;
								continue;
							}
							case 23:
								goto IL_1C0;
							case 24:
								if (!k.a.Equals("Tx Pa Characterization Parameter Mcp"))
								{
									num2 = 1;
									continue;
								}
								goto IL_341;
							case 25:
								num2 = 24;
								continue;
							case 26:
								num2 = 21;
								continue;
							case 27:
								if (A_1.Equals("UPGRADE"))
								{
									num2 = 17;
									continue;
								}
								goto IL_163;
							case 28:
								num2 = 27;
								continue;
							case 29:
								if (empty.Length == 0)
								{
									num2 = 0;
									continue;
								}
								result = empty;
								num2 = 9;
								continue;
							case 30:
							{
								global::IshHandler.g g;
								if (g.b == 4399U)
								{
									num2 = 4;
									continue;
								}
								goto IL_FB;
							}
							}
							break;
							IL_FB:
							num++;
							num2 = 5;
							continue;
							IL_124:
							num3++;
							num2 = 6;
							continue;
							IL_163:
							num2 = 12;
							continue;
							IL_1C0:
							num2 = 16;
							continue;
							IL_2F8:
							num2 = 22;
							continue;
							IL_341:
							empty = k.i;
							num2 = 3;
						}
					}
					IL_15E:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "RcalcPCAtten", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_3AF:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::System.GC.Collect();
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
				{
					goto IL_3F8;
				}
				IL_3CB:
				ex2.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				IL_3F8:
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3CB;
				default:
					if (false)
					{
					}
					throw;
				}
			}
			return result;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000AAE4 File Offset: 0x00009AE4
		private string c(global::IshHandler.h A_0)
		{
			string result;
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						string text = this.a("LINEAR", A_0.m);
						double num = (double)int.Parse(((global::IshHandler.k)A_0.c[0]).e, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
						double num2 = (double)int.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
						int num3 = 1;
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_10D;
							case 1:
								if (A_0.m.Equals("UPGRADE"))
								{
									num3 = 4;
									continue;
								}
								num *= num2;
								num /= 100.0;
								num3 = 2;
								continue;
							case 2:
								goto IL_E9;
							case 3:
								goto IL_E9;
							case 4:
								if (true)
								{
								}
								num *= 100.0;
								num /= num2;
								num3 = 3;
								continue;
							}
							break;
							IL_E9:
							double value = global::System.Math.Round(num);
							result = this.a((uint)global::System.Math.Abs(value));
							num3 = 0;
						}
					}
					IL_10D:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.Collect();
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					goto IL_156;
				}
				IL_129:
				ex.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				IL_156:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_129;
				default:
					if (false)
					{
					}
					throw;
				}
			}
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000ACA8 File Offset: 0x00009CA8
		private string b(global::IshHandler.h A_0)
		{
			string result;
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						global::IshHandler.k k = (global::IshHandler.k)A_0.c[0];
						double num = double.Parse(A_0.n, global::System.Globalization.NumberStyles.Float, global::System.Globalization.CultureInfo.InvariantCulture);
						double num2 = (double)int.Parse(k.e, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
						int num3 = 3;
						for (;;)
						{
							switch (num3)
							{
							case 0:
								num2 *= num;
								num3 = 4;
								continue;
							case 1:
								goto IL_DF;
							case 2:
								goto IL_101;
							case 3:
								if (A_0.m.Equals("UPGRADE"))
								{
									if (true)
									{
									}
									num3 = 0;
									continue;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_F5;
								default:
									if (false)
									{
									}
									num2 /= num;
									num3 = 1;
									continue;
								}
								break;
							case 4:
								goto IL_DF;
							}
							break;
							IL_F5:
							num3 = 2;
							continue;
							IL_DF:
							double value = global::System.Math.Round(num2);
							result = this.a((uint)global::System.Math.Abs(value));
							goto IL_F5;
						}
					}
					IL_101:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.Collect();
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					ex.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000AE44 File Offset: 0x00009E44
		private string a(global::IshHandler.h A_0, global::IshHandler.g A_1)
		{
			string result;
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						string text = string.Empty;
						int num = 0;
						int num2 = 17;
						for (;;)
						{
							double num3;
							double num4;
							switch (num2)
							{
							case 0:
								num3 *= 100.0;
								num3 /= num4;
								num2 = 6;
								continue;
							case 1:
								num2 = 3;
								continue;
							case 2:
								text = this.a("LINEAR", A_0.m);
								num2 = 4;
								continue;
							case 3:
							{
								global::IshHandler.k k;
								if (!k.a.Equals("Tx Pa Characterization Parameter Mcp"))
								{
									num2 = 5;
									continue;
								}
								goto IL_1B7;
							}
							case 4:
								goto IL_B5;
							case 5:
								num2 = 12;
								continue;
							case 6:
								goto IL_2D8;
							case 7:
							{
								global::IshHandler.k k;
								if (k.g.Equals("\\Composite Data"))
								{
									num2 = 1;
									continue;
								}
								goto IL_1A2;
							}
							case 8:
								goto IL_2D8;
							case 9:
								goto IL_1A2;
							case 10:
								goto IL_2FD;
							case 11:
								if (text.Length == 0)
								{
									num2 = 2;
									continue;
								}
								goto IL_B5;
							case 12:
							{
								global::IshHandler.k k;
								if (k.a.Equals("Tx Pa Characterization Parameter Mcp1"))
								{
									num2 = 21;
									continue;
								}
								goto IL_1A2;
							}
							case 13:
							{
								if (A_0.m.Equals("UPGRADE"))
								{
									num2 = 16;
									continue;
								}
								global::IshHandler.k k;
								text = k.j;
								num2 = 14;
								continue;
							}
							case 14:
								goto IL_1A2;
							case 15:
								if (A_0.m.Equals("UPGRADE"))
								{
									num2 = 0;
									continue;
								}
								num3 *= num4;
								num3 /= 100.0;
								num2 = 8;
								continue;
							case 16:
							{
								global::IshHandler.k k;
								text = k.i;
								num2 = 9;
								continue;
							}
							case 17:
								goto IL_2A9;
							case 18:
								goto IL_2A9;
							case 19:
							{
								if (num >= A_1.d.Count)
								{
									num2 = 20;
									continue;
								}
								global::IshHandler.k k = (global::IshHandler.k)A_1.d[num];
								num2 = 7;
								continue;
							}
							case 20:
								num2 = 11;
								continue;
							case 21:
								goto IL_1B7;
							}
							break;
							IL_B5:
							num3 = (double)int.Parse(((global::IshHandler.k)A_0.c[0]).e, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
							num4 = (double)int.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
							num2 = 15;
							continue;
							IL_1A2:
							num++;
							num2 = 18;
							continue;
							IL_1B7:
							num2 = 13;
							continue;
							IL_2A9:
							num2 = 19;
							continue;
							IL_2D8:
							double value = global::System.Math.Round(num3);
							result = this.a((uint)global::System.Math.Abs(value));
							num2 = 10;
						}
					}
					IL_2FD:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.Collect();
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					goto IL_346;
				}
				IL_319:
				ex.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				IL_346:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_319;
				default:
					if (false)
					{
					}
					throw;
				}
			}
			if (true)
			{
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000B200 File Offset: 0x0000A200
		private string a(global::IshHandler.h A_0)
		{
			string result;
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						string text = this.a("NEW", A_0.m);
						double num = (double)int.Parse(((global::IshHandler.k)A_0.c[0]).e, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
						double num2 = 0.0;
						double num3 = (double)int.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
						int num4 = 4;
						for (;;)
						{
							switch (num4)
							{
							case 0:
								goto IL_B0;
							case 1:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_B0;
								default:
									if (false)
									{
									}
									goto IL_148;
								}
								break;
							case 2:
								if (true)
								{
								}
								goto IL_148;
							case 3:
								goto IL_16C;
							case 4:
								if (A_0.m.Equals("UPGRADE"))
								{
									num4 = 0;
									continue;
								}
								num2 = 5000.0;
								num2 *= num;
								num2 /= global::System.Math.Pow(2.0, 3.0) * num3;
								num4 = 1;
								continue;
							}
							break;
							IL_B0:
							num2 = global::System.Math.Pow(2.0, 3.0);
							num2 /= 5000.0;
							num2 *= num3;
							num2 *= num;
							num4 = 2;
							continue;
							IL_148:
							double value = global::System.Math.Round(num2);
							result = this.a((uint)global::System.Math.Abs(value));
							num4 = 3;
						}
					}
					IL_16C:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.Collect();
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					ex.Source = 2933U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000B404 File Offset: 0x0000A404
		public void a(global::DeviceUpdate.c.b A_0, ref global::System.Collections.ArrayList A_1, string A_2, bool A_3, bool A_4)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						this.ac = A_3;
						this.ab = A_0.k;
						this.ae = A_4;
						string a_ = A_0.h;
						string a_2 = A_0.i;
						string a_3 = A_0.a;
						string a_4 = A_0.f;
						string text = A_0.e;
						string a_5 = A_0.g;
						uint a_6 = global::System.Convert.ToUInt32(A_0.b, global::System.Globalization.CultureInfo.InvariantCulture);
						int num = 0;
						this.y.Clear();
						this.t = this.a(a_, true);
						global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(this.t.a.Count);
						int index = 0;
						int num2 = 14;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (A_2.Length > 0)
								{
									num2 = 7;
									continue;
								}
								goto IL_7AF;
							case 1:
								arrayList.Clear();
								global::System.GC.Collect();
								num2 = 19;
								continue;
							case 2:
								num2 = 20;
								continue;
							case 3:
								try
								{
									for (;;)
									{
										global::IshHandler.m m;
										ulong num3 = (ulong)((long)m.c.Length);
										byte[] array = m.c;
										num2 = 2;
										for (;;)
										{
											global::IshHandler.g g;
											int num10;
											uint num13;
											global::IshHandler.g g2;
											switch (num2)
											{
											case 0:
												goto IL_1D2;
											case 1:
											{
												uint num4;
												int num5;
												if ((ulong)num4 == (ulong)((long)num5))
												{
													num2 = 7;
													continue;
												}
												int num6;
												num6++;
												num2 = 16;
												continue;
											}
											case 2:
											{
												if (array == null)
												{
													num2 = 14;
													continue;
												}
												int num7 = 0;
												int num8 = 0;
												uint num9;
												int num5 = (int)num9;
												int num6 = 0;
												num2 = 17;
												continue;
											}
											case 3:
												try
												{
													for (;;)
													{
														global::IshHandler.k k = (global::IshHandler.k)g.d[num10];
														int num11 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
														num11 /= 8;
														num2 = 6;
														for (;;)
														{
															string text2;
															string str;
															int num12;
															switch (num2)
															{
															case 0:
																text2 = text2.PadLeft(2, '0');
																num2 = 4;
																continue;
															case 1:
															{
																int num7;
																if (num7 > (int)num3)
																{
																	num2 = 11;
																	continue;
																}
																num2 = 14;
																continue;
															}
															case 2:
																goto IL_4A0;
															case 3:
																k.e = str;
																k.i = str;
																k.j = str;
																g.d[num10] = k;
																num2 = 2;
																continue;
															case 4:
																goto IL_545;
															case 5:
																goto IL_540;
															case 6:
															{
																if (!k.e.Equals("eqn(sum)"))
																{
																	num2 = 7;
																	continue;
																}
																int num7;
																num7 += num11;
																num2 = 13;
																continue;
															}
															case 7:
																num12 = 0;
																str = string.Empty;
																num2 = 9;
																continue;
															case 8:
																if (text2.Length < 2)
																{
																	num2 = 0;
																	continue;
																}
																goto IL_545;
															case 9:
																goto IL_596;
															case 10:
															{
																if (num12 >= num11)
																{
																	num2 = 3;
																	continue;
																}
																int num7;
																byte b = array[num7];
																num7++;
																string text3 = b.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
																int a_7 = int.Parse(text3, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
																text2 = this.a((uint)a_7);
																num2 = 8;
																continue;
															}
															case 11:
																num2 = 5;
																continue;
															case 12:
																goto IL_596;
															case 13:
																goto IL_4A0;
															case 14:
																goto IL_606;
															}
															break;
															IL_4A0:
															num2 = 1;
															continue;
															IL_545:
															str += text2;
															num12++;
															num2 = 12;
															continue;
															IL_596:
															num2 = 10;
														}
													}
													IL_540:
													goto IL_702;
													IL_606:
													goto IL_3C0;
												}
												catch (global::custom_exception.CCustomException)
												{
													throw;
												}
												catch (global::System.Exception ex)
												{
													global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2954U, ex.Source, "PreservePartition", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
													global::IshHandler.k k2 = (global::IshHandler.k)g.d[num10];
													int num8;
													uint num9;
													string message = string.Format("Failed while processing field (name={0},group={1},index={2},startByte={3}).\r\nishblock: type={4},id={5}\r\nPartition: {6}", new object[]
													{
														k2.a,
														k2.g,
														num10,
														num8,
														num9.ToString(global::System.Globalization.CultureInfo.InvariantCulture),
														num13.ToString(global::System.Globalization.CultureInfo.InvariantCulture),
														A_0.b.ToString()
													});
													ex2.AddErrorMessage(message, ex);
													throw ex2;
												}
												goto IL_6D1;
												IL_3C0:
												num10++;
												num2 = 0;
												continue;
											case 4:
												goto IL_258;
											case 5:
												goto IL_702;
											case 6:
												goto IL_305;
											case 7:
												num2 = 15;
												continue;
											case 8:
												goto IL_729;
											case 9:
												goto IL_1D2;
											case 10:
												goto IL_258;
											case 11:
											{
												if (num10 >= g.d.Count)
												{
													num2 = 5;
													continue;
												}
												int num7;
												int num8 = num7;
												num2 = 3;
												continue;
											}
											case 12:
												goto IL_73B;
											case 13:
											{
												int num6;
												if (num6 >= this.t.a.Count)
												{
													num2 = 18;
													continue;
												}
												g2 = (global::IshHandler.g)this.t.a[num6];
												uint num4 = g2.b;
												num2 = 1;
												continue;
											}
											case 14:
												goto IL_1CD;
											case 15:
											{
												uint num9;
												if (arrayList.Contains(num9.ToString(global::System.Globalization.CultureInfo.InvariantCulture)))
												{
													num2 = 6;
													continue;
												}
												switch ((1 == 1) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_305;
												default:
												{
													if (false)
													{
													}
													g = g2;
													g.e = true;
													g.h = true;
													int num6;
													index = num6;
													arrayList.Add(num9.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
													num2 = 4;
													continue;
												}
												}
												break;
											}
											case 16:
												goto IL_6D1;
											case 17:
												goto IL_6D1;
											case 18:
												goto IL_729;
											}
											break;
											IL_1D2:
											num2 = 11;
											continue;
											IL_258:
											g.c = num13;
											num10 = 0;
											num2 = 9;
											continue;
											IL_305:
											g = default(global::IshHandler.g);
											g.d = (global::System.Collections.ArrayList)g2.d.Clone();
											g.e = true;
											g.b = g2.b;
											g.g = new global::System.Collections.ArrayList();
											g.a = g2.a;
											g.c = num13;
											g.h = true;
											index = this.t.a.Add(g);
											num2 = 10;
											continue;
											IL_6D1:
											num2 = 13;
											continue;
											IL_702:
											this.t.a[index] = g;
											num2 = 8;
											continue;
											IL_729:
											num++;
											num2 = 12;
										}
									}
									IL_1CD:
									global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "PreserveCodeplug", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
									throw ex3;
									IL_73B:
									goto IL_85D;
								}
								catch (global::custom_exception.CCustomException)
								{
									throw;
								}
								catch (global::System.Exception ex4)
								{
									global::custom_exception.CCustomException ex5 = new global::custom_exception.CCustomException(2954U, ex4.Source, "PreservePartition", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
									uint num9;
									uint num13;
									string message2 = string.Format("Failed to preserve ishblock (type={0},id={1})\r\nPartition: {2}", num9.ToString(global::System.Globalization.CultureInfo.InvariantCulture), num13.ToString(global::System.Globalization.CultureInfo.InvariantCulture), A_0.b.ToString());
									ex5.AddErrorMessage(message2, ex4);
									throw ex5;
								}
								goto IL_7AF;
							case 4:
								if (A_2.Length > 0)
								{
									num2 = 22;
									continue;
								}
								goto IL_991;
							case 5:
								num2 = 4;
								continue;
							case 6:
								num2 = 11;
								continue;
							case 7:
								this.a(A_2, a_4, text);
								num2 = 9;
								continue;
							case 8:
								goto IL_9AE;
							case 9:
								goto IL_7AF;
							case 10:
								if (text != null)
								{
									num2 = 12;
									continue;
								}
								goto IL_991;
							case 11:
								if (text.Length > 0)
								{
									num2 = 18;
									continue;
								}
								goto IL_7AF;
							case 12:
								num2 = 21;
								continue;
							case 13:
								num2 = 0;
								continue;
							case 14:
								goto IL_85D;
							case 15:
							{
								if (num >= A_1.Count)
								{
									num2 = 1;
									continue;
								}
								global::IshHandler.m m = (global::IshHandler.m)A_1[num];
								uint num9 = (uint)m.a;
								uint num13 = (uint)m.b;
								num2 = 3;
								continue;
							}
							case 16:
								goto IL_991;
							case 17:
								if (A_2 != null)
								{
									num2 = 13;
									continue;
								}
								goto IL_7AF;
							case 18:
								num2 = 17;
								continue;
							case 19:
								if (text != null)
								{
									num2 = 6;
									continue;
								}
								goto IL_7AF;
							case 20:
								if (A_2 != null)
								{
									num2 = 5;
									continue;
								}
								goto IL_991;
							case 21:
								if (text.Length > 0)
								{
									num2 = 2;
									continue;
								}
								goto IL_991;
							case 22:
								this.g();
								num2 = 16;
								continue;
							}
							break;
							IL_7AF:
							this.u = this.a(a_2, false);
							global::System.Collections.Hashtable a_8 = new global::System.Collections.Hashtable();
							this.a(this.u, ref a_8);
							this.a(ref this.t, ref this.u);
							this.a(a_2, a_5, this.s);
							num2 = 10;
							continue;
							IL_85D:
							num2 = 15;
							continue;
							IL_991:
							this.a(a_3, a_6, a_8, ref A_1);
							global::System.GC.Collect();
							num2 = 8;
						}
					}
					IL_9AE:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				throw;
			}
			catch (global::System.Exception ex6)
			{
				global::System.GC.Collect();
				global::custom_exception.CCustomException ex7 = new global::custom_exception.CCustomException(2954U, ex6.Source, "PreservePartition", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				string message3 = string.Format("Failed to preserve \"{0}\" partition.", A_0.b.ToString());
				ex7.AddErrorMessage(message3, ex6);
				throw ex7;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000BEC8 File Offset: 0x0000AEC8
		public void a(global::IshHandler.j A_0, ref global::System.Collections.Hashtable A_1)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					A_1.Clear();
					int num = 2;
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						switch (num)
						{
						case 0:
							goto IL_283;
						case 1:
							try
							{
								num = 7;
								for (;;)
								{
									int num3;
									switch (num)
									{
									case 0:
										goto IL_AF;
									case 1:
										goto IL_102;
									case 2:
										num = 8;
										continue;
									case 3:
									{
										uint num2;
										if (num2 > 1U)
										{
											num = 6;
											continue;
										}
										goto IL_102;
									}
									case 4:
									{
										global::IshHandler.g g;
										int count = g.d.Count;
										num3 = 0;
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_BF;
										default:
											if (false)
											{
											}
											num = 10;
											continue;
										}
										break;
									}
									case 6:
									{
										uint num2;
										ushort num4;
										A_1.Add(num4, num2);
										num = 1;
										continue;
									}
									case 8:
										goto IL_238;
									case 9:
									{
										int count;
										if (num3 >= count)
										{
											goto IL_BF;
										}
										global::IshHandler.g g;
										string value = ((global::IshHandler.k)g.d[num3]).e;
										ushort num4 = global::System.Convert.ToUInt16(value, 16);
										string value2 = ((global::IshHandler.k)g.d[num3 + 1]).e;
										uint num2 = (uint)global::System.Convert.ToUInt16(value2, 16);
										num2 = ((num2 >> 8 & 255U) | (num2 << 8 & 65280U));
										num = 3;
										continue;
									}
									case 10:
										goto IL_AF;
									case 11:
									{
										if (!enumerator.MoveNext())
										{
											num = 2;
											continue;
										}
										global::IshHandler.g g = (global::IshHandler.g)enumerator.Current;
										num = 12;
										continue;
									}
									case 12:
									{
										global::IshHandler.g g;
										if (g.b == 5392U)
										{
											num = 4;
											continue;
										}
										break;
									}
									}
									goto IL_AA;
									IL_AF:
									num = 9;
									continue;
									IL_BF:
									num = 5;
									continue;
									IL_102:
									num3++;
									num3++;
									num = 0;
									continue;
									IL_118:
									num = 11;
									continue;
									IL_AA:
									goto IL_118;
								}
								IL_238:
								return;
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
											goto IL_282;
										case 1:
											goto IL_280;
										case 2:
											disposable.Dispose();
											num = 1;
											continue;
										}
										break;
									}
								}
								IL_280:
								IL_282:;
							}
							goto IL_283;
						case 2:
							if (A_0.a.Count != 0)
							{
								if (true)
								{
								}
								num = 0;
								continue;
							}
							return;
						}
						break;
						IL_283:
						enumerator = A_0.a.GetEnumerator();
						num = 1;
					}
				}
				return;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000C194 File Offset: 0x0000B194
		public void a(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5, string A_6, string A_7, string A_8, string A_9, int A_10, bool A_11)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 19;
					for (;;)
					{
						string a_;
						uint a_2;
						ulong a_7;
						ulong num32;
						switch (num)
						{
						case 0:
							if (A_0.Length != 0)
							{
								num = 61;
								continue;
							}
							goto IL_168;
						case 1:
							a_ = "";
							num = 40;
							continue;
						case 2:
							num = 21;
							continue;
						case 3:
							if (!A_11)
							{
								num = 37;
								continue;
							}
							goto IL_44D;
						case 4:
							num = 36;
							continue;
						case 5:
						{
							int num2;
							if (num2 >= 501)
							{
								num = 18;
								continue;
							}
							goto IL_44D;
						}
						case 6:
							a_2 = 0U;
							num = 58;
							continue;
						case 7:
							if (A_6 != null)
							{
								num = 24;
								continue;
							}
							goto IL_1755;
						case 8:
							if (this.s.Contains(4116U))
							{
								num = 63;
								continue;
							}
							goto IL_2C7;
						case 9:
							goto IL_44D;
						case 10:
							a_2 = 81U;
							num = 11;
							continue;
						case 11:
							goto IL_1694;
						case 12:
							if (A_1.Length != 0)
							{
								num = 35;
								continue;
							}
							goto IL_168;
						case 13:
							num = 0;
							continue;
						case 14:
						{
							int num3;
							if (num3 == 5)
							{
								num = 55;
								continue;
							}
							goto IL_496;
						}
						case 15:
							try
							{
								for (;;)
								{
									uint num4;
									uint num5;
									global::System.IntPtr source;
									ulong num6;
									global::IshHandler.e.ReadISH(this.z, (ushort)num4, (ushort)num5, out source, out num6);
									int num7 = global::System.Convert.ToInt32(num6);
									byte[] array = new byte[num7];
									num = 11;
									for (;;)
									{
										global::IshHandler.g g;
										global::IshHandler.g g2;
										int num15;
										int index;
										switch (num)
										{
										case 0:
											num = 27;
											continue;
										case 1:
										{
											global::IshHandler.k k = (global::IshHandler.k)g.d[0];
											num = 30;
											continue;
										}
										case 2:
										{
											int num8;
											if (num8 >= this.t.a.Count)
											{
												num = 8;
												continue;
											}
											g2 = (global::IshHandler.g)this.t.a[num8];
											bool flag = true;
											uint num9 = g2.b;
											num = 20;
											continue;
										}
										case 3:
											goto IL_1074;
										case 4:
											goto IL_E86;
										case 5:
											if (string.Equals(A_9, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
											{
												num = 1;
												continue;
											}
											goto IL_1324;
										case 6:
											goto IL_1324;
										case 7:
										{
											bool flag = true;
											num = 6;
											continue;
										}
										case 8:
											goto IL_1369;
										case 9:
											goto IL_5CD;
										case 10:
											goto IL_1338;
										case 11:
										{
											if (array == null)
											{
												num = 9;
												continue;
											}
											global::System.Runtime.InteropServices.Marshal.Copy(source, array, 0, num7);
											int num10 = 0;
											int num11 = 0;
											uint num12 = num4;
											int num8 = 0;
											num = 10;
											continue;
										}
										case 12:
										{
											uint num12;
											global::IshHandler.j a_3;
											g2 = this.a(a_3, num12);
											num = 34;
											continue;
										}
										case 13:
											goto IL_1338;
										case 14:
										{
											bool flag = false;
											num = 32;
											continue;
										}
										case 15:
											try
											{
												num = 60;
												for (;;)
												{
													global::IshHandler.k k;
													bool flag;
													int num16;
													string str;
													uint num19;
													uint num20;
													int num23;
													global::System.Collections.ArrayList arrayList;
													string text;
													switch (num)
													{
													case 0:
													{
														uint num13;
														if (num13 != 0U)
														{
															num = 6;
															continue;
														}
														goto IL_DAA;
													}
													case 1:
													{
														int num10;
														if (num10 > (int)num6)
														{
															num = 46;
															continue;
														}
														goto IL_DAA;
													}
													case 2:
													{
														int num10;
														uint num14;
														if ((ulong)num14 == (ulong)((long)num10))
														{
															num = 42;
															continue;
														}
														goto IL_89A;
													}
													case 3:
														k = (global::IshHandler.k)g.d[num15];
														num = 51;
														continue;
													case 4:
														goto IL_CE4;
													case 5:
														num16 = 0;
														str = string.Empty;
														num = 54;
														continue;
													case 6:
														num = 45;
														continue;
													case 7:
													{
														int num17;
														if (num17 != 1)
														{
															num = 50;
															continue;
														}
														num = 25;
														continue;
													}
													case 8:
													{
														uint num18;
														if (num18 == 1U)
														{
															num = 33;
															continue;
														}
														goto IL_A20;
													}
													case 9:
														if (!flag)
														{
															num = 24;
															continue;
														}
														goto IL_A20;
													case 10:
														k.e = str;
														k.i = str;
														k.j = str;
														g.d[num15] = k;
														num = 9;
														continue;
													case 11:
														num = 19;
														continue;
													case 12:
														goto IL_A20;
													case 13:
														if (num19 < num20)
														{
															num = 14;
															continue;
														}
														goto IL_B8A;
													case 14:
														num = 38;
														continue;
													case 15:
													{
														int num21 = num15;
														int num22 = 0;
														k = (global::IshHandler.k)g.d[num21];
														num23 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
														num22 = num23 / 8;
														arrayList.Add((global::IshHandler.k)g.d[num21]);
														num = 26;
														continue;
													}
													case 16:
														num = 20;
														continue;
													case 17:
														goto IL_8C0;
													case 18:
														num = 0;
														continue;
													case 19:
														goto IL_A20;
													case 20:
														if (num20 != 0U)
														{
															num = 55;
															continue;
														}
														goto IL_89A;
													case 21:
														num = 2;
														continue;
													case 22:
														goto IL_B57;
													case 23:
														text = text.PadLeft(2, '0');
														num = 17;
														continue;
													case 24:
														num = 62;
														continue;
													case 25:
													{
														uint num18;
														if (num18 == 2U)
														{
															num = 57;
															continue;
														}
														goto IL_A20;
													}
													case 26:
														goto IL_CE4;
													case 27:
														goto IL_DB6;
													case 28:
														if (num19 > num20)
														{
															num = 16;
															continue;
														}
														goto IL_89A;
													case 29:
													{
														uint num13;
														if (num13 != 0U)
														{
															num = 36;
															continue;
														}
														goto IL_B8A;
													}
													case 30:
														if (text.Length < 2)
														{
															num = 23;
															continue;
														}
														goto IL_8C0;
													case 31:
													{
														int num17;
														if (num17 != 6)
														{
															num = 11;
															continue;
														}
														num = 8;
														continue;
													}
													case 32:
														goto IL_89A;
													case 33:
													{
														num19 = this.b(k.e);
														uint num25;
														uint num24 = num25 * num19;
														uint num14;
														uint num13 = num24 + num14;
														num = 43;
														continue;
													}
													case 34:
													{
														int num17 = num15;
														num = 7;
														continue;
													}
													case 35:
													{
														int num22;
														uint num25;
														if ((long)num22 >= (long)((ulong)num25))
														{
															num = 37;
															continue;
														}
														int num21;
														num21++;
														k = (global::IshHandler.k)g.d[num21];
														arrayList.Add((global::IshHandler.k)g.d[num21]);
														num23 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
														num23 /= 8;
														num22 += num23;
														num = 4;
														continue;
													}
													case 36:
														num = 53;
														continue;
													case 37:
														goto IL_975;
													case 38:
													{
														int num10;
														uint num13;
														if ((ulong)num13 == (ulong)((long)num10))
														{
															num = 3;
															continue;
														}
														goto IL_B8A;
													}
													case 39:
														if (!flag)
														{
															num = 18;
															continue;
														}
														goto IL_DAA;
													case 40:
													{
														if (!k.e.Equals("eqn(sum)"))
														{
															num = 5;
															continue;
														}
														int num10;
														num10 += num23;
														num = 12;
														continue;
													}
													case 41:
													{
														int num26 = g.d.Count - 1;
														int count = num26 - num15;
														g.d.RemoveRange(num15, count);
														num = 47;
														continue;
													}
													case 42:
														num = 28;
														continue;
													case 43:
														goto IL_A20;
													case 44:
													{
														uint num18;
														if (num18 == 1U)
														{
															num = 15;
															continue;
														}
														goto IL_975;
													}
													case 45:
													{
														int num10;
														uint num13;
														if ((long)num10 >= (long)((ulong)(num13 + 2U)))
														{
															num = 52;
															continue;
														}
														goto IL_DAA;
													}
													case 46:
														num = 63;
														continue;
													case 47:
														goto IL_B8A;
													case 48:
													{
														if (num16 >= num23)
														{
															num = 10;
															continue;
														}
														int num10;
														byte b = array[num10];
														num10++;
														string text2 = b.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
														int a_4 = int.Parse(text2, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
														text = this.a((uint)a_4);
														num = 30;
														continue;
													}
													case 49:
														num = 39;
														continue;
													case 50:
														num = 31;
														continue;
													case 51:
														if (k.e != "eqn(sum)")
														{
															num = 41;
															continue;
														}
														goto IL_B8A;
													case 52:
														num = 22;
														continue;
													case 53:
														if (string.Equals(A_9, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
														{
															num = 21;
															continue;
														}
														goto IL_B8A;
													case 54:
														goto IL_9FA;
													case 55:
														num = 44;
														continue;
													case 56:
														num = 29;
														continue;
													case 57:
													{
														num19 = this.b(k.e);
														uint num25;
														uint num24 = num25 * num19;
														uint num14;
														uint num13 = num24 + num14;
														num = 61;
														continue;
													}
													case 58:
														if (string.Equals(A_9, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
														{
															num = 49;
															continue;
														}
														num = 1;
														continue;
													case 59:
														goto IL_9FA;
													case 61:
														goto IL_A20;
													case 62:
														if (string.Equals(A_9, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
														{
															num = 34;
															continue;
														}
														goto IL_A20;
													case 63:
														goto IL_D18;
													}
													if (!flag)
													{
														num = 56;
														continue;
													}
													goto IL_B8A;
													IL_89A:
													num = 13;
													continue;
													IL_8C0:
													str += text;
													num16++;
													num = 59;
													continue;
													IL_975:
													uint a_5 = num19 - num20;
													int a_6 = num15 + (int)(num20 * (uint)arrayList.Count);
													global::IshHandler.f.a(ref g, arrayList, a_5, a_6, num20);
													num = 32;
													continue;
													IL_9FA:
													num = 48;
													continue;
													IL_A20:
													num = 58;
													continue;
													IL_B8A:
													k = (global::IshHandler.k)g.d[num15];
													num23 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
													num23 /= 8;
													num = 40;
													continue;
													IL_CE4:
													num = 35;
													continue;
													IL_DAA:
													num = 27;
												}
												IL_B57:
												IL_D18:
												goto IL_11D5;
												IL_DB6:;
											}
											catch (global::custom_exception.CCustomException)
											{
												throw;
											}
											catch (global::System.Exception ex)
											{
												global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2954U, ex.Source, "PreservePartition", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
												global::IshHandler.k k2 = (global::IshHandler.k)g.d[num15];
												int num11;
												string message = string.Format("Failed while processing field (name={0},group={1},index={2},startByte={3}).\r\nishblock: type={4},id={5}\r\nPartition: {6}", new object[]
												{
													k2.a,
													k2.g,
													num15,
													num11,
													num4.ToString(global::System.Globalization.CultureInfo.InvariantCulture),
													num5.ToString(global::System.Globalization.CultureInfo.InvariantCulture),
													A_3
												});
												ex2.AddErrorMessage(message, ex);
												throw ex2;
											}
											goto IL_E72;
										case 16:
										{
											global::System.Collections.ArrayList arrayList2;
											if (arrayList2.Contains(num4.ToString(global::System.Globalization.CultureInfo.InvariantCulture)))
											{
												num = 0;
												continue;
											}
											g = g2;
											g.e = true;
											g.h = true;
											int num8;
											index = num8;
											arrayList2.Add(num4.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
											num = 31;
											continue;
										}
										case 17:
											goto IL_1324;
										case 18:
											num = 16;
											continue;
										case 19:
											goto IL_137B;
										case 20:
										{
											uint num9;
											uint num12;
											if (num9 == num12)
											{
												num = 18;
												continue;
											}
											int num8;
											num8++;
											num = 13;
											continue;
										}
										case 21:
											goto IL_FFE;
										case 22:
											num = 7;
											continue;
										case 23:
										{
											int num27;
											if (num27 >= g.d.Count - 1)
											{
												num = 14;
												continue;
											}
											global::IshHandler.k k = (global::IshHandler.k)g.d[num27];
											global::System.Collections.ArrayList arrayList;
											arrayList.Add((global::IshHandler.k)g.d[num27]);
											int num23 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
											num23 /= 8;
											uint num25;
											num25 += (uint)num23;
											num27++;
											num = 35;
											continue;
										}
										case 24:
										{
											uint num28;
											switch (num28)
											{
											case 1U:
											{
												uint num20 = this.b(this.a(g, 6));
												uint num25 = this.b(this.a(g, 1));
												uint num29 = this.b(this.a(g, 9));
												uint num14 = 19U + num29;
												bool flag = false;
												num = 17;
												continue;
											}
											case 2U:
											{
												uint num20 = this.b(this.a(g, 1));
												uint num14 = 7U;
												int num27 = 4;
												num = 21;
												continue;
											}
											default:
												num = 22;
												continue;
											}
											break;
										}
										case 25:
											goto IL_11D5;
										case 26:
											goto IL_1369;
										case 27:
											if (string.Equals(A_9, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
											{
												num = 12;
												continue;
											}
											goto IL_1136;
										case 28:
										{
											uint num25 = 0U;
											uint num19 = 0U;
											uint num13 = 0U;
											global::System.Collections.ArrayList arrayList;
											arrayList.Clear();
											global::IshHandler.k k;
											uint num18 = this.b(k.e);
											uint num28 = num18;
											num = 24;
											continue;
										}
										case 29:
										{
											if (num15 >= g.d.Count)
											{
												num = 25;
												continue;
											}
											int num10;
											int num11 = num10;
											num = 15;
											continue;
										}
										case 30:
										{
											global::IshHandler.k k;
											if (k.a == "Item Structure Indicator")
											{
												num = 28;
												continue;
											}
											goto IL_1324;
										}
										case 31:
											goto IL_1074;
										case 32:
											goto IL_1324;
										case 33:
											goto IL_E86;
										case 34:
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_E72;
											default:
												if (false)
												{
												}
												goto IL_1136;
											}
											break;
										case 35:
											goto IL_FFE;
										}
										break;
										IL_E72:
										num15++;
										num = 33;
										continue;
										IL_E86:
										num = 29;
										continue;
										IL_FFE:
										num = 23;
										continue;
										IL_1074:
										g.c = num5;
										num = 5;
										continue;
										IL_1136:
										g = default(global::IshHandler.g);
										g.d = (global::System.Collections.ArrayList)g2.d.Clone();
										g.e = true;
										g.b = g2.b;
										g.g = new global::System.Collections.ArrayList();
										g.a = g2.a;
										g.h = true;
										g.c = num5;
										index = this.t.a.Add(g);
										num = 3;
										continue;
										IL_11D5:
										this.t.a[index] = g;
										num = 26;
										continue;
										IL_1324:
										num15 = 0;
										num = 4;
										continue;
										IL_1338:
										num = 2;
										continue;
										IL_1369:
										int num30;
										num30 += 2;
										num = 19;
									}
								}
								IL_5CD:
								global::custom_exception.CCustomException ex3 = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "PreserveCodeplug", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
								throw ex3;
								IL_137B:
								goto IL_496;
							}
							catch (global::custom_exception.CCustomException)
							{
								throw;
							}
							catch (global::System.Exception ex4)
							{
								global::custom_exception.CCustomException ex5 = new global::custom_exception.CCustomException(2954U, ex4.Source, "PreservePartition", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
								uint num4;
								uint num5;
								string message2 = string.Format("Failed to preserve ishblock (type={0},id={1})\r\nPartition: {2}", num4.ToString(global::System.Globalization.CultureInfo.InvariantCulture), num5.ToString(global::System.Globalization.CultureInfo.InvariantCulture), A_3);
								ex5.AddErrorMessage(message2, ex4);
								throw ex5;
							}
							goto IL_13E0;
						case 16:
							goto IL_1474;
						case 17:
							if (A_8 != null)
							{
								num = 39;
								continue;
							}
							goto IL_14AB;
						case 18:
						{
							bool flag2 = this.a(4113U, 0U, "Byte02", 128U, 128U);
							num = 60;
							continue;
						}
						case 20:
							num = 7;
							continue;
						case 21:
						{
							int num31;
							if (num31 < 500)
							{
								num = 6;
								continue;
							}
							goto IL_471;
						}
						case 22:
							num = 53;
							continue;
						case 23:
							num = 12;
							continue;
						case 24:
							num = 43;
							continue;
						case 25:
							goto IL_22F;
						case 26:
							goto IL_2C7;
						case 27:
							goto IL_496;
						case 28:
						{
							global::System.Collections.ArrayList arrayList2;
							arrayList2.Clear();
							global::System.GC.Collect();
							num = 17;
							continue;
						}
						case 29:
						{
							if (!this.s.Contains(16387U))
							{
								num = 44;
								continue;
							}
							int index2 = this.s.IndexOf(16387U);
							this.s.RemoveRange(index2, 2);
							num = 16;
							continue;
						}
						case 30:
						{
							if (A_2.Length == 0)
							{
								num = 31;
								continue;
							}
							a_7 = 0UL;
							num32 = 0UL;
							this.s.Clear();
							global::IshHandler.a a_8 = new global::IshHandler.a(this.a);
							global::IshHandler.e.read_partition(this.z, a_8, out a_7, out num32, A_3, 201326592UL);
							int num30 = 0;
							string text3 = A_8.Replace(".", "").Substring(0, 4);
							string text4 = A_7.Replace(".", "").Substring(0, 4);
							string text5 = A_8.Replace(".", "").Substring(0, 2);
							int num31 = int.Parse(text3, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
							int num2 = int.Parse(text4, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
							int num3 = int.Parse(text5, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
							this.y.Clear();
							this.t = this.a(A_0, true);
							global::IshHandler.j a_3 = this.a(A_0, true);
							global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList(this.t.a.Count);
							int index = 0;
							bool flag = true;
							uint num18 = 0U;
							uint num25 = 0U;
							uint num19 = 0U;
							uint num13 = 0U;
							uint num14 = 0U;
							uint num20 = 0U;
							int num23 = 0;
							global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
							num = 8;
							continue;
						}
						case 31:
							goto IL_168F;
						case 32:
							if (A_8 != null)
							{
								num = 49;
								continue;
							}
							goto IL_1755;
						case 33:
							num = 30;
							continue;
						case 34:
							goto IL_1694;
						case 35:
							num = 52;
							continue;
						case 36:
							if (A_6.Length > 0)
							{
								num = 38;
								continue;
							}
							goto IL_14AB;
						case 37:
						{
							bool flag2 = false;
							num = 5;
							continue;
						}
						case 38:
							this.a(A_6, A_7, A_8);
							num = 50;
							continue;
						case 39:
							num = 42;
							continue;
						case 40:
						{
							bool flag2;
							if (flag2)
							{
								num = 57;
								continue;
							}
							a_ = "15";
							num = 48;
							continue;
						}
						case 41:
							if (!this.ad)
							{
								num = 22;
								continue;
							}
							goto IL_44D;
						case 42:
							if (A_8.Length > 0)
							{
								num = 46;
								continue;
							}
							goto IL_14AB;
						case 43:
							if (A_6.Length > 0)
							{
								num = 45;
								continue;
							}
							goto IL_1755;
						case 44:
							num = 27;
							continue;
						case 45:
							this.g();
							num = 51;
							continue;
						case 46:
							num = 65;
							continue;
						case 47:
							goto IL_1474;
						case 48:
							goto IL_22F;
						case 49:
							num = 64;
							continue;
						case 50:
							goto IL_14AB;
						case 51:
							goto IL_1755;
						case 52:
							if (A_2 != null)
							{
								num = 33;
								continue;
							}
							goto IL_168;
						case 53:
						{
							int num31;
							if (num31 == 500)
							{
								num = 1;
								continue;
							}
							goto IL_44D;
						}
						case 54:
							goto IL_17BE;
						case 55:
							num = 47;
							continue;
						case 56:
							if (A_1 != null)
							{
								num = 23;
								continue;
							}
							goto IL_168;
						case 57:
							a_ = "55";
							num = 25;
							continue;
						case 58:
						{
							bool flag2;
							if (flag2)
							{
								num = 10;
								continue;
							}
							a_2 = 17U;
							num = 34;
							continue;
						}
						case 59:
							goto IL_471;
						case 60:
							if (!this.ad)
							{
								num = 2;
								continue;
							}
							goto IL_471;
						case 61:
							num = 56;
							continue;
						case 62:
						{
							int num30;
							if (num30 >= this.s.Count)
							{
								num = 28;
								continue;
							}
							uint num4 = uint.Parse(this.s[num30].ToString(), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
							uint num5 = uint.Parse(this.s[num30 + 1].ToString(), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
							num = 15;
							continue;
						}
						case 63:
							goto IL_13E0;
						case 64:
							if (A_8.Length > 0)
							{
								num = 20;
								continue;
							}
							goto IL_1755;
						case 65:
							if (A_6 != null)
							{
								num = 4;
								continue;
							}
							goto IL_14AB;
						}
						if (A_0 != null)
						{
							num = 13;
							continue;
						}
						break;
						IL_22F:
						this.a(4116U, 0U, a_, "\\Feature Bits", "Byte08");
						num = 9;
						continue;
						IL_2C7:
						num = 14;
						continue;
						IL_44D:
						num = 32;
						continue;
						IL_471:
						num = 41;
						continue;
						IL_496:
						num = 62;
						continue;
						IL_13E0:
						this.ad = true;
						num = 26;
						continue;
						IL_1474:
						num = 29;
						continue;
						IL_14AB:
						this.u = this.a(A_1, false);
						this.a(ref this.t, ref this.u);
						this.a(A_1, A_9, this.s);
						num = 3;
						continue;
						IL_1694:
						this.a(4116U, 0U, a_2, "\\Feature Bits", "Byte08", 12U);
						num = 59;
						continue;
						IL_1755:
						this.a(A_5, out a_7, out num32, A_3);
						this.s.Clear();
						global::IshHandler.e.SetBlockISHVersion(this.z, a_7, 201326592UL, A_10);
						global::IshHandler.e.EraseCodeplugVirtualMemory(this.z);
						global::IshHandler.e.BuildDefaultISHHeaders(this.z);
						this.a();
						global::IshHandler.e.WriteIshToSrec(this.z, A_2, A_3);
						global::System.GC.Collect();
						num = 54;
					}
					IL_168:
					global::custom_exception.CCustomException ex6 = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "shouldPreserveCodeplug", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex6;
					IL_168F:
					goto IL_168;
					IL_17BE:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				try
				{
					if (true)
					{
					}
					global::IshHandler.e.TerminateISH(this.z);
				}
				catch (global::custom_exception.CCustomException)
				{
				}
				catch (global::System.Exception)
				{
				}
				throw;
			}
			catch (global::System.Exception ex7)
			{
				global::System.GC.Collect();
				try
				{
					global::IshHandler.e.TerminateISH(this.z);
				}
				catch (global::custom_exception.CCustomException)
				{
				}
				catch (global::System.Exception)
				{
				}
				global::custom_exception.CCustomException ex8 = new global::custom_exception.CCustomException(2954U, ex7.Source, "PreservePartition", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				string message3 = string.Format("Failed to preserve \"{0}\" partition.", A_3);
				ex8.AddErrorMessage(message3, ex7);
				throw ex8;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000DAE8 File Offset: 0x0000CAE8
		private void a(ref global::IshHandler.j A_0, ref global::IshHandler.j A_1)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Collections.Generic.Dictionary<uint, global::IshHandler.l> dictionary = new global::System.Collections.Generic.Dictionary<uint, global::IshHandler.l>();
					int num = 0;
					int num2 = 8;
					for (;;)
					{
						global::IshHandler.g a_;
						uint key;
						int num3;
						switch (num2)
						{
						case 0:
							goto IL_B2;
						case 1:
							try
							{
								num2 = 1;
								for (;;)
								{
									switch (num2)
									{
									case 2:
										num2 = 6;
										continue;
									case 3:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_11D;
										default:
											if (false)
											{
											}
											num2 = 7;
											continue;
										}
										break;
									case 4:
									{
										global::IshHandler.l l;
										if (!l.b)
										{
											goto IL_11D;
										}
										break;
									}
									case 5:
									{
										global::System.Collections.Generic.Dictionary<uint, global::IshHandler.l>.ValueCollection.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num2 = 3;
											continue;
										}
										global::IshHandler.l l = enumerator.Current;
										num2 = 4;
										continue;
									}
									case 6:
									{
										global::IshHandler.l l;
										if (!this.y.Contains(l.a.b))
										{
											num2 = 8;
											continue;
										}
										break;
									}
									case 7:
										goto IL_1D0;
									case 8:
									{
										global::IshHandler.l l;
										A_1.a.Remove(l.a);
										num2 = 0;
										continue;
									}
									}
									goto IL_FD;
									IL_11D:
									num2 = 2;
									continue;
									IL_182:
									num2 = 5;
									continue;
									IL_FD:
									goto IL_182;
								}
								IL_1D0:
								return;
							}
							finally
							{
								if (true)
								{
								}
								global::System.Collections.Generic.Dictionary<uint, global::IshHandler.l>.ValueCollection.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_1EB;
						case 2:
							if (num >= A_1.a.Count)
							{
								num2 = 6;
								continue;
							}
							a_ = (global::IshHandler.g)A_1.a[num];
							key = a_.b;
							num2 = 7;
							continue;
						case 3:
						{
							global::System.Collections.Generic.Dictionary<uint, global::IshHandler.l>.ValueCollection.Enumerator enumerator = dictionary.Values.GetEnumerator();
							num2 = 1;
							continue;
						}
						case 4:
						{
							if (num3 >= A_0.a.Count)
							{
								num2 = 3;
								continue;
							}
							global::IshHandler.g g = (global::IshHandler.g)A_0.a[num3];
							uint key2 = g.b;
							bool flag = g.h;
							num2 = 5;
							continue;
						}
						case 5:
						{
							uint key2;
							if (dictionary.ContainsKey(key2))
							{
								num2 = 13;
								continue;
							}
							goto IL_210;
						}
						case 6:
							num3 = 0;
							num2 = 14;
							continue;
						case 7:
							if (!dictionary.ContainsKey(key))
							{
								num2 = 11;
								continue;
							}
							goto IL_B2;
						case 8:
							goto IL_2F6;
						case 9:
							goto IL_210;
						case 10:
							goto IL_2F6;
						case 11:
							goto IL_1EB;
						case 12:
							goto IL_69;
						case 13:
						{
							uint key2;
							bool flag;
							dictionary[key2].b = flag;
							num2 = 9;
							continue;
						}
						case 14:
							goto IL_69;
						}
						break;
						IL_69:
						num2 = 4;
						continue;
						IL_B2:
						num++;
						num2 = 10;
						continue;
						IL_1EB:
						dictionary[key] = new global::IshHandler.l(a_, a_.h);
						num2 = 0;
						continue;
						IL_210:
						num3++;
						num2 = 12;
						continue;
						IL_2F6:
						num2 = 2;
					}
				}
				return;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000DE38 File Offset: 0x0000CE38
		private static void a(ref global::IshHandler.g A_0, global::System.Collections.ArrayList A_1, uint A_2, int A_3, uint A_4)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					IL_37:
					string newValue = string.Empty;
					global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
					arrayList = (global::System.Collections.ArrayList)A_1.Clone();
					global::IshHandler.k k = (global::IshHandler.k)arrayList[0];
					int num = (int)A_4;
					int num2 = 0;
					for (;;)
					{
						IL_64:
						int num3 = 6;
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								if ((long)num2 >= (long)((ulong)A_2))
								{
									num3 = 1;
									continue;
								}
								arrayList.Clear();
								arrayList = (global::System.Collections.ArrayList)A_1.Clone();
								newValue = "\\List Entry Data " + num.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								int num4 = 0;
								num3 = 4;
								continue;
							}
							case 1:
								return;
							case 2:
							{
								int num4;
								if (num4 >= arrayList.Count)
								{
									num3 = 5;
									continue;
								}
								if (true)
								{
								}
								k = (global::IshHandler.k)arrayList[num4];
								string text = k.g;
								text = text.Replace("\\List Entry Data", newValue);
								k.g = text;
								arrayList[num4] = k;
								num4++;
								num3 = 3;
								continue;
							}
							case 3:
								goto IL_A1;
							case 4:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_64;
								default:
									if (false)
									{
									}
									goto IL_A1;
								}
								break;
							case 5:
								A_0.d.InsertRange(A_3, arrayList);
								A_3 += A_1.Count;
								num++;
								num2++;
								num3 = 7;
								continue;
							case 6:
								goto IL_11E;
							case 7:
								goto IL_11E;
							}
							goto IL_37;
							IL_A1:
							num3 = 2;
							continue;
							IL_11E:
							num3 = 0;
						}
					}
				}
				return;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000DFF0 File Offset: 0x0000CFF0
		private static string c(string A_0)
		{
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
						goto IL_46;
					default:
						if (false)
						{
						}
						goto IL_50;
					}
					break;
				case 2:
					if (A_0.Length == 1)
					{
						num = 5;
						continue;
					}
					return A_0;
				case 3:
					A_0 = A_0.PadLeft(4, '0');
					num = 0;
					continue;
				case 4:
					return A_0;
				case 5:
					A_0 = A_0.PadLeft(2, '0');
					goto IL_46;
				}
				if (A_0.Length == 3)
				{
					num = 3;
					continue;
				}
				goto IL_50;
				IL_46:
				num = 4;
				continue;
				IL_50:
				if (true)
				{
				}
				num = 2;
			}
			return A_0;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000E0B0 File Offset: 0x0000D0B0
		private global::IshHandler.g a(global::IshHandler.j A_0, uint A_1)
		{
			global::IshHandler.g result;
			for (;;)
			{
				int num = 0;
				result = (global::IshHandler.g)A_0.a[0];
				uint num2 = 0U;
				if (true)
				{
				}
				int num3 = 4;
				for (;;)
				{
					switch (num3)
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
							num++;
							break;
						}
						num3 = 3;
						continue;
					case 1:
						if (num >= A_0.a.Count)
						{
							num3 = 5;
							continue;
						}
						result = (global::IshHandler.g)A_0.a[num];
						num2 = result.b;
						num3 = 2;
						continue;
					case 2:
						if (num2 != A_1)
						{
							num3 = 0;
							continue;
						}
						return result;
					case 3:
						goto IL_53;
					case 4:
						goto IL_53;
					case 5:
						return result;
					}
					break;
					IL_53:
					num3 = 1;
				}
			}
			return result;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000E194 File Offset: 0x0000D194
		private string a(global::IshHandler.g A_0, int A_1)
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
			return ((global::IshHandler.k)A_0.d[A_1]).e;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000E1EC File Offset: 0x0000D1EC
		public void a(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5, string A_6, string A_7, int A_8, bool A_9, int A_10)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 37;
					for (;;)
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
							int num2;
							global::IshHandler.g g;
							uint num3;
							int index;
							int num9;
							string text2;
							int num11;
							string str;
							ulong a_2;
							ulong num12;
							switch (num)
							{
							case 0:
								num2++;
								goto IL_75D;
							case 1:
								this.b();
								num = 40;
								continue;
							case 2:
								if (string.Equals(A_7, "D105ADD323864E539B513A65076458D3", global::System.StringComparison.Ordinal))
								{
									num = 44;
									continue;
								}
								goto IL_849;
							case 3:
								if (!A_9)
								{
									num = 1;
									continue;
								}
								goto IL_227;
							case 4:
								goto IL_76E;
							case 5:
							{
								g = default(global::IshHandler.g);
								global::IshHandler.g g2;
								g.d = (global::System.Collections.ArrayList)g2.d.Clone();
								g.e = true;
								g.b = g2.b;
								g.g = new global::System.Collections.ArrayList();
								g.a = g2.a;
								g.c = num3;
								g.h = true;
								index = this.t.a.Add(g);
								num = 20;
								continue;
							}
							case 6:
								goto IL_1F7;
							case 7:
								num = 38;
								continue;
							case 8:
							{
								int num4;
								ulong num5;
								if (num4 <= (int)num5)
								{
									num = 0;
									continue;
								}
								goto IL_81F;
							}
							case 9:
								if (!string.IsNullOrEmpty(A_1))
								{
									num = 47;
									continue;
								}
								goto IL_6D9;
							case 10:
							{
								int num6;
								if (num6 >= this.t.a.Count)
								{
									num = 43;
									continue;
								}
								global::IshHandler.g g2 = (global::IshHandler.g)this.t.a[num6];
								num = 13;
								continue;
							}
							case 11:
							{
								global::System.Collections.ArrayList arrayList;
								arrayList.Clear();
								global::System.GC.Collect();
								this.a(A_5, A_6, A_6);
								this.u = this.a(A_0, false);
								this.a(ref this.t, ref this.u);
								this.a(A_0, A_7, this.s);
								this.c();
								num = 3;
								continue;
							}
							case 12:
								goto IL_1F7;
							case 13:
							{
								global::IshHandler.g g2;
								uint num7;
								if (g2.b == num7)
								{
									num = 7;
									continue;
								}
								int num6;
								num6++;
								num = 36;
								continue;
							}
							case 14:
							{
								byte[] array;
								if (array == null)
								{
									num = 50;
									continue;
								}
								global::System.IntPtr source;
								int num8;
								global::System.Runtime.InteropServices.Marshal.Copy(source, array, 0, num8);
								int num4 = 0;
								int num6 = 0;
								num = 32;
								continue;
							}
							case 15:
								goto IL_14A;
							case 16:
								goto IL_849;
							case 17:
								goto IL_5F5;
							case 18:
								if (!string.IsNullOrEmpty(A_4))
								{
									num = 48;
									continue;
								}
								goto IL_6D9;
							case 19:
								goto IL_81F;
							case 20:
								goto IL_6BC;
							case 21:
							{
								int num10;
								if (num9 >= num10)
								{
									num = 31;
									continue;
								}
								int num4;
								byte[] array;
								byte b = array[num4];
								num4++;
								string text = b.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								int a_ = int.Parse(text, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								text2 = this.a((uint)a_);
								num = 34;
								continue;
							}
							case 22:
								goto IL_7A4;
							case 23:
								num = 9;
								continue;
							case 24:
								num = 2;
								continue;
							case 25:
							{
								global::IshHandler.k k;
								if (!k.e.Equals("eqn(sum)"))
								{
									num = 42;
									continue;
								}
								int num4;
								int num10;
								num4 += num10;
								num = 17;
								continue;
							}
							case 26:
								goto IL_4EF;
							case 27:
							{
								if (num11 >= this.s.Count)
								{
									num = 11;
									continue;
								}
								uint num7 = uint.Parse(this.s[num11].ToString(), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num3 = uint.Parse(this.s[num11 + 1].ToString(), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								ulong num5;
								global::System.IntPtr source;
								global::IshHandler.e.ReadISH(this.z, (ushort)num7, (ushort)num3, out source, out num5);
								int num8 = global::System.Convert.ToInt32(num5);
								byte[] array = new byte[num8];
								num = 14;
								continue;
							}
							case 28:
								text2 = text2.PadLeft(2, '0');
								num = 4;
								continue;
							case 29:
								goto IL_81A;
							case 30:
								goto IL_4EF;
							case 31:
							{
								global::IshHandler.k k;
								k.e = str;
								k.i = str;
								k.j = str;
								g.d[num2] = k;
								num = 45;
								continue;
							}
							case 32:
								goto IL_688;
							case 33:
							{
								if (num2 >= g.d.Count)
								{
									num = 19;
									continue;
								}
								global::IshHandler.k k = (global::IshHandler.k)g.d[num2];
								int num10 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num10 /= 8;
								num = 25;
								continue;
							}
							case 34:
								if (text2.Length < 2)
								{
									num = 28;
									continue;
								}
								goto IL_76E;
							case 35:
								goto IL_8B8;
							case 36:
								goto IL_688;
							case 38:
							{
								global::System.Collections.ArrayList arrayList;
								uint num7;
								if (arrayList.Contains(num7.ToString(global::System.Globalization.CultureInfo.InvariantCulture)))
								{
									num = 5;
									continue;
								}
								global::IshHandler.g g2;
								g = g2;
								g.e = true;
								g.h = true;
								int num6;
								index = num6;
								arrayList.Add(num7.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
								num = 39;
								continue;
							}
							case 39:
								goto IL_6BC;
							case 40:
								goto IL_227;
							case 41:
								if (A_9)
								{
									num = 24;
									continue;
								}
								goto IL_849;
							case 42:
								num9 = 0;
								str = string.Empty;
								num = 22;
								continue;
							case 43:
								goto IL_14A;
							case 44:
								this.a(4116U, 0U, 0U, "\\Feature Bits", "Byte08", 207U);
								num = 16;
								continue;
							case 45:
								goto IL_5F5;
							case 46:
							{
								if (string.IsNullOrEmpty(A_5))
								{
									num = 29;
									continue;
								}
								a_2 = 0UL;
								num12 = 0UL;
								this.s.Clear();
								this.a(A_4, out a_2, out num12, A_3);
								this.a(A_1, A_3, A_10);
								global::IshHandler.a a_3 = new global::IshHandler.a(this.a);
								global::IshHandler.e.read_partition(this.z, a_3, out a_2, out num12, A_3, 201326592UL);
								num11 = 0;
								this.y.Clear();
								this.t = this.a(A_0, true);
								global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(this.t.a.Count);
								index = 0;
								num = 26;
								continue;
							}
							case 47:
								num = 18;
								continue;
							case 48:
								num = 46;
								continue;
							case 49:
								goto IL_7A4;
							case 50:
								goto IL_45F;
							}
							if (!string.IsNullOrEmpty(A_0))
							{
								num = 23;
								continue;
							}
							goto IL_6D9;
							IL_14A:
							num11 += 2;
							num = 30;
							continue;
							IL_1F7:
							num = 33;
							continue;
							IL_227:
							num = 41;
							continue;
							IL_4EF:
							num = 27;
							continue;
							IL_5F5:
							num = 8;
							continue;
							IL_688:
							num = 10;
							continue;
							IL_6BC:
							g.c = num3;
							num2 = 0;
							num = 12;
							continue;
							IL_76E:
							str += text2;
							num9++;
							num = 49;
							continue;
							IL_7A4:
							num = 21;
							continue;
							IL_81F:
							this.t.a[index] = g;
							num = 15;
							continue;
							IL_849:
							this.g();
							this.a(A_4, out a_2, out num12, A_3);
							this.s.Clear();
							global::IshHandler.e.SetBlockISHVersion(this.z, a_2, 201326592UL, A_8);
							global::IshHandler.e.EraseCodeplugVirtualMemory(this.z);
							global::IshHandler.e.BuildDefaultISHHeaders(this.z);
							this.a();
							global::IshHandler.e.WriteIshToSrec(this.z, A_2, A_3);
							global::System.GC.Collect();
							num = 35;
							continue;
						}
						}
						IL_75D:
						num = 6;
					}
					IL_45F:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "UpdateSerialNumber", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_6D9:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "UpdateSerialNumber", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex2;
					IL_81A:
					goto IL_6D9;
					IL_8B8:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				global::System.GC.Collect();
				try
				{
					global::IshHandler.e.TerminateISH(this.z);
				}
				catch (global::custom_exception.CCustomException)
				{
				}
				catch (global::System.Exception)
				{
				}
				throw;
			}
			catch (global::System.Exception ex3)
			{
				global::System.GC.Collect();
				try
				{
					if (true)
					{
					}
					global::IshHandler.e.TerminateISH(this.z);
					goto IL_8E1;
				}
				catch (global::custom_exception.CCustomException)
				{
					goto IL_8E1;
				}
				catch (global::System.Exception)
				{
					goto IL_8E1;
				}
				goto IL_908;
				IL_8E1:
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
				{
					goto IL_935;
				}
				IL_908:
				ex3.Source = 2952U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex3.Source;
				IL_935:
				throw;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000EBD0 File Offset: 0x0000DBD0
		private bool d(string A_0, int A_1)
		{
			if (true)
			{
			}
			int a_ = int.Parse(A_0, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
			string text = this.a(a_, 2);
			if (text.Length == A_1)
			{
				for (;;)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_45;
					}
				}
				IL_45:
				if (false)
				{
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000EC38 File Offset: 0x0000DC38
		private long c(string A_0, int A_1)
		{
			switch (0)
			{
			default:
			{
				string text2;
				for (;;)
				{
					int a_ = int.Parse(A_0, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
					string text = this.a(a_, 2);
					text = text.PadLeft(A_1, '0');
					text2 = string.Empty;
					bool flag = false;
					bool flag2 = false;
					int num = A_1 - 1;
					int num2 = 10;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							text2 = "0" + text2;
							num2 = 5;
							continue;
						case 1:
							if (true)
							{
							}
							goto IL_AD;
						case 2:
							goto IL_AD;
						case 3:
							if (num < 0)
							{
								num2 = 4;
								continue;
							}
							num2 = 14;
							continue;
						case 4:
							goto IL_183;
						case 5:
							goto IL_AD;
						case 6:
							if (flag2)
							{
								num2 = 0;
								continue;
							}
							text2 = "1" + text2;
							num2 = 2;
							continue;
						case 7:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_147;
							default:
								if (false)
								{
								}
								goto IL_1A5;
							}
							break;
						case 8:
							flag2 = true;
							num2 = 7;
							continue;
						case 9:
							num2 = 6;
							continue;
						case 10:
							goto IL_166;
						case 11:
							goto IL_118;
						case 12:
							if (flag2)
							{
								num2 = 15;
								continue;
							}
							goto IL_118;
						case 13:
							if (flag)
							{
								num2 = 9;
								continue;
							}
							text2 = text[num].ToString(global::System.Globalization.CultureInfo.InvariantCulture) + text2;
							num2 = 1;
							continue;
						case 14:
							if (text[num] == '1')
							{
								goto IL_147;
							}
							goto IL_1A5;
						case 15:
							flag = true;
							num2 = 11;
							continue;
						case 16:
							goto IL_166;
						}
						break;
						IL_AD:
						num2 = 12;
						continue;
						IL_118:
						flag2 = false;
						num--;
						num2 = 16;
						continue;
						IL_147:
						num2 = 8;
						continue;
						IL_166:
						num2 = 3;
						continue;
						IL_1A5:
						num2 = 13;
					}
				}
				IL_183:
				int num3 = this.a(text2, 2);
				return (long)num3;
			}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000EE70 File Offset: 0x0000DE70
		private string a(long A_0, int A_1)
		{
			switch (0)
			{
			default:
			{
				string text2;
				for (;;)
				{
					long num = global::System.Math.Abs(A_0);
					string text = this.a((int)num, 2);
					text = text.PadLeft(A_1, '0');
					text2 = string.Empty;
					bool flag = false;
					bool flag2 = false;
					int num2 = A_1 - 1;
					int num3 = 8;
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (true)
							{
							}
							num3 = 15;
							continue;
						case 1:
							goto IL_156;
						case 2:
							if (flag)
							{
								num3 = 0;
								continue;
							}
							text2 = text[num2].ToString(global::System.Globalization.CultureInfo.InvariantCulture) + text2;
							num3 = 7;
							continue;
						case 3:
							flag = true;
							num3 = 9;
							continue;
						case 4:
							goto IL_94;
						case 5:
							if (num2 < 0)
							{
								num3 = 16;
								continue;
							}
							num3 = 11;
							continue;
						case 6:
							goto IL_195;
						case 7:
							goto IL_94;
						case 8:
							goto IL_156;
						case 9:
							goto IL_ED;
						case 10:
							if (flag2)
							{
								num3 = 3;
								continue;
							}
							goto IL_ED;
						case 11:
							if (text[num2] != '1')
							{
								goto IL_195;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_94;
							default:
								if (false)
								{
								}
								num3 = 12;
								continue;
							}
							break;
						case 12:
							flag2 = true;
							num3 = 6;
							continue;
						case 13:
							text2 = "0" + text2;
							num3 = 4;
							continue;
						case 14:
							goto IL_94;
						case 15:
							if (flag2)
							{
								num3 = 13;
								continue;
							}
							text2 = "1" + text2;
							num3 = 14;
							continue;
						case 16:
							goto IL_173;
						}
						break;
						IL_94:
						num3 = 10;
						continue;
						IL_ED:
						flag2 = false;
						num2--;
						num3 = 1;
						continue;
						IL_156:
						num3 = 5;
						continue;
						IL_195:
						num3 = 2;
					}
				}
				IL_173:
				int a_ = this.a(text2, 2);
				return this.a(a_, 16);
			}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000F0A0 File Offset: 0x0000E0A0
		private global::IshHandler.k f()
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
			return new global::IshHandler.k
			{
				b = "8",
				f = "PRESERVE_YES",
				e = "30",
				g = "\\Serial Number",
				a = "Serial Number Character",
				c = "30",
				d = "5A"
			};
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000F138 File Offset: 0x0000E138
		private global::IshHandler.k e()
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
			return new global::IshHandler.k
			{
				b = "8",
				f = "PRESERVE_YES",
				e = "00",
				g = "\\MAC Address",
				a = "MAC Address",
				c = "00",
				d = "FF"
			};
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000F1D0 File Offset: 0x0000E1D0
		private global::IshHandler.k d()
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
			return new global::IshHandler.k
			{
				b = "8",
				f = "PRESERVE_YES",
				e = "30",
				g = "\\Cypher Unit Serial Number",
				a = "Cypher Unit Serial Number Character",
				c = "30",
				d = "5A"
			};
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000F268 File Offset: 0x0000E268
		public void g(string A_0)
		{
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						int num;
						int num2;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_1F4:
							num = 12;
							break;
						default:
							if (false)
							{
							}
							this.w = default(global::IshHandler.g);
							this.w.d = new global::System.Collections.ArrayList();
							this.w.g = new global::System.Collections.ArrayList();
							this.w.e = false;
							this.w.c = 0U;
							this.w.b = 4112U;
							this.w.f = false;
							this.w.a = "Radio Security Information Composite Data Block";
							num2 = 0;
							num = 24;
							break;
						}
						for (;;)
						{
							int num4;
							int num5;
							global::IshHandler.k k2;
							string text3;
							string text4;
							int num8;
							switch (num)
							{
							case 0:
							{
								int num3 = 0;
								num = 9;
								continue;
							}
							case 1:
							{
								if (num2 >= 10)
								{
									if (true)
									{
									}
									num = 0;
									continue;
								}
								global::IshHandler.k k = this.f();
								string text = (num2 + 1).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								text = text.PadLeft(2, '0');
								k.a = k.a + " " + text;
								this.w.d.Add(k);
								num2++;
								num = 18;
								continue;
							}
							case 2:
								goto IL_479;
							case 3:
							{
								int num3;
								if (num3 >= 10)
								{
									num = 16;
									continue;
								}
								global::IshHandler.k k = this.d();
								string str = (num3 + 1).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								k.a = k.a + " " + str;
								this.w.d.Add(k);
								num3++;
								num = 5;
								continue;
							}
							case 4:
							{
								if (num4 >= 94)
								{
									num = 10;
									continue;
								}
								k2 = (global::IshHandler.k)this.w.d[num5];
								int num6 = int.Parse(k2.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num6 /= 8;
								byte[] array;
								byte b = array[num4];
								string text2 = b.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								int a_ = int.Parse(text2, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								text3 = this.a((uint)a_);
								num = 17;
								continue;
							}
							case 5:
								goto IL_298;
							case 6:
								text4 = text4.PadLeft(2, '0');
								num = 2;
								continue;
							case 7:
								goto IL_219;
							case 8:
								if (text4.Length < 2)
								{
									num = 6;
									continue;
								}
								goto IL_479;
							case 9:
								goto IL_298;
							case 10:
								num = 19;
								continue;
							case 11:
								goto IL_23F;
							case 12:
								text3 = text3.PadLeft(2, '0');
								num = 11;
								continue;
							case 13:
							{
								byte[] array;
								if (array == null)
								{
									num = 22;
									continue;
								}
								global::System.IntPtr source;
								int num7;
								global::System.Runtime.InteropServices.Marshal.Copy(source, array, 0, num7);
								num5 = 0;
								num8 = 0;
								num = 23;
								continue;
							}
							case 14:
							{
								if (num8 >= 10)
								{
									num = 20;
									continue;
								}
								k2 = (global::IshHandler.k)this.w.d[num5];
								int num6 = int.Parse(k2.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num6 /= 8;
								byte[] array;
								byte b = array[num8];
								string text5 = b.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								int a_2 = int.Parse(text5, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								text4 = this.a((uint)a_2);
								num = 8;
								continue;
							}
							case 15:
								goto IL_2DB;
							case 16:
							{
								ulong num9 = 0UL;
								ulong num10 = 0UL;
								this.s.Clear();
								global::IshHandler.a a_3 = new global::IshHandler.a(this.a);
								global::IshHandler.e.read_partition(this.z, a_3, out num9, out num10, A_0, 201326592UL);
								global::System.IntPtr source;
								ulong value;
								global::IshHandler.e.ReadISH(this.z, 4112, 0, out source, out value);
								int num7 = global::System.Convert.ToInt32(value);
								byte[] array = new byte[num7];
								num = 13;
								continue;
							}
							case 17:
								if (text3.Length < 2)
								{
									goto IL_1F4;
								}
								goto IL_23F;
							case 18:
								goto IL_411;
							case 19:
								goto IL_54F;
							case 20:
								num4 = 84;
								num = 15;
								continue;
							case 21:
								goto IL_2DB;
							case 22:
								goto IL_40C;
							case 23:
								goto IL_219;
							case 24:
								goto IL_411;
							}
							break;
							IL_219:
							num = 14;
							continue;
							IL_23F:
							k2.e = text3;
							this.w.d[num5] = k2;
							num5++;
							num4++;
							num = 21;
							continue;
							IL_298:
							num = 3;
							continue;
							IL_2DB:
							num = 4;
							continue;
							IL_411:
							num = 1;
							continue;
							IL_479:
							k2.e = text4;
							this.w.d[num5] = k2;
							num5++;
							num8++;
							num = 7;
						}
					}
					IL_40C:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "PreserveCodeplug", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_54F:
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
					ex2.Source = 2952U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				throw;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000F844 File Offset: 0x0000E844
		public void b(string A_0, string A_1)
		{
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						this.x.d = null;
						int num = 17;
						for (;;)
						{
							int num2;
							int num3;
							int num4;
							global::IshHandler.k k;
							string text2;
							switch (num)
							{
							case 0:
								num = 12;
								continue;
							case 1:
								goto IL_9F;
							case 2:
								goto IL_9F;
							case 3:
								goto IL_405;
							case 4:
							{
								byte[] array = new byte[num2];
								num = 11;
								continue;
							}
							case 5:
							{
								if (num3 >= 110)
								{
									num = 0;
									continue;
								}
								k = (global::IshHandler.k)this.x.d[num4];
								int num5 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num5 /= 8;
								string empty = string.Empty;
								byte[] array;
								byte b = array[num3];
								string text = b.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								int a_ = int.Parse(text, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								text2 = this.a((uint)a_);
								num = 13;
								continue;
							}
							case 6:
								goto IL_C3;
							case 7:
								goto IL_29E;
							case 8:
								num = 18;
								continue;
							case 9:
								goto IL_C3;
							case 10:
								goto IL_237;
							case 11:
							{
								byte[] array;
								if (array == null)
								{
									num = 7;
									continue;
								}
								global::System.IntPtr source;
								global::System.Runtime.InteropServices.Marshal.Copy(source, array, 0, num2);
								num4 = 0;
								num3 = 104;
								num = 6;
								continue;
							}
							case 12:
								goto IL_405;
							case 13:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_316;
								default:
									if (false)
									{
									}
									if (text2.Length < 2)
									{
										num = 15;
										continue;
									}
									goto IL_237;
								}
								break;
							case 14:
								goto IL_411;
							case 15:
								text2 = text2.PadLeft(2, '0');
								num = 10;
								continue;
							case 16:
							{
								ulong num6 = 0UL;
								ulong num7 = 0UL;
								this.s.Clear();
								global::IshHandler.a a_2 = new global::IshHandler.a(this.a);
								global::IshHandler.e.read_partition(this.z, a_2, out num6, out num7, A_0, 201326592UL);
								global::System.IntPtr source;
								ulong value;
								global::IshHandler.e.ReadISH(this.z, 4112, 0, out source, out value);
								num2 = global::System.Convert.ToInt32(value);
								num = 19;
								continue;
							}
							case 17:
							{
								if (!string.Equals(A_1, "D105ADD323864E539B513A65076458D3", global::System.StringComparison.Ordinal))
								{
									num = 8;
									continue;
								}
								this.x = default(global::IshHandler.g);
								this.x.d = new global::System.Collections.ArrayList();
								this.x.g = new global::System.Collections.ArrayList();
								this.x.e = false;
								this.x.c = 0U;
								this.x.b = 4112U;
								this.x.f = false;
								this.x.a = "Radio Security Information Composite Data Block";
								int num8 = 0;
								num = 2;
								continue;
							}
							case 18:
								goto IL_2AF;
							case 19:
								goto IL_316;
							case 20:
							{
								int num8;
								if (num8 >= 6)
								{
									num = 16;
									continue;
								}
								global::IshHandler.k k2 = this.e();
								string str = num8.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								k2.a = k2.a + " " + str;
								this.x.d.Add(k2);
								num8++;
								num = 1;
								continue;
							}
							}
							break;
							IL_9F:
							num = 20;
							continue;
							IL_C3:
							num = 5;
							continue;
							IL_316:
							if (num2 > 109)
							{
								num = 4;
								continue;
							}
							this.x.d = null;
							num = 3;
							continue;
							IL_237:
							k.e = text2;
							this.x.d[num4] = k;
							num4++;
							num3++;
							num = 9;
							continue;
							IL_405:
							num = 14;
						}
					}
					IL_29E:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "PreserveCodeplug", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_2AF:
					IL_411:
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
					ex2.Source = 2952U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				if (true)
				{
				}
				throw;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000FCEC File Offset: 0x0000ECEC
		public void b(ref byte[] A_0, global::System.Collections.ArrayList A_1)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_95:
				num = 14;
				break;
			default:
				if (false)
				{
				}
				switch (0)
				{
				default:
					goto IL_6F;
				}
				break;
			}
			byte[] array;
			global::System.Collections.IEnumerator enumerator;
			for (;;)
			{
				IL_2C:
				int num2;
				switch (num)
				{
				case 0:
					goto IL_87;
				case 1:
					goto IL_262;
				case 2:
					if (num2 >= 110)
					{
						num = 10;
						continue;
					}
					A_0[num2] = array[num2];
					num2++;
					num = 11;
					continue;
				case 3:
				{
					int num3;
					if (num3 >= 94)
					{
						goto IL_95;
					}
					A_0[num3] = array[num3];
					num3++;
					num = 0;
					continue;
				}
				case 4:
					goto IL_87;
				case 5:
					goto IL_262;
				case 6:
					goto IL_110;
				case 7:
				{
					int num4;
					if (num4 >= 10)
					{
						num = 12;
						continue;
					}
					A_0[num4] = array[num4];
					num4++;
					num = 1;
					continue;
				}
				case 8:
					if (array != null)
					{
						num = 9;
						continue;
					}
					return;
				case 9:
				{
					int num4 = 0;
					num = 5;
					continue;
				}
				case 10:
					return;
				case 11:
					goto IL_110;
				case 12:
				{
					int num3 = 84;
					num = 4;
					continue;
				}
				case 13:
					try
					{
						num = 3;
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								global::IshHandler.m m;
								array = m.c;
								num = 1;
								continue;
							}
							case 1:
								goto IL_1E1;
							case 2:
							{
								global::IshHandler.m m;
								if (m.a == 4112)
								{
									num = 0;
									continue;
								}
								break;
							}
							case 4:
								goto IL_1E1;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = 4;
									continue;
								}
								global::IshHandler.m m = (global::IshHandler.m)enumerator.Current;
								num = 2;
								continue;
							}
							case 6:
								goto IL_1ED;
							}
							IL_1C1:
							num = 5;
							continue;
							goto IL_1C1;
							IL_1E1:
							num = 6;
						}
						IL_1ED:
						goto IL_B4;
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
									goto IL_238;
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
									goto IL_23A;
								}
								break;
							}
						}
						IL_238:
						IL_23A:;
					}
					goto IL_23B;
					IL_B4:
					num = 8;
					continue;
				case 14:
					goto IL_23B;
				}
				goto IL_6F;
				IL_87:
				num = 3;
				continue;
				IL_110:
				num = 2;
				continue;
				IL_23B:
				if (true)
				{
				}
				num2 = 104;
				num = 6;
				continue;
				IL_262:
				num = 7;
			}
			return;
			IL_6F:
			array = null;
			enumerator = A_1.GetEnumerator();
			num = 13;
			goto IL_2C;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000FFA0 File Offset: 0x0000EFA0
		public void a(ref byte[] A_0, global::System.Collections.ArrayList A_1)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					byte[] array = null;
					global::System.Collections.IEnumerator enumerator = A_1.GetEnumerator();
					int num = 6;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_1B1;
						case 1:
						{
							int num2 = 104;
							num = 10;
							continue;
						}
						case 2:
						{
							int num2;
							if (num2 >= 110)
							{
								num = 3;
								continue;
							}
							A_0[num2] = array[num2];
							num2++;
							num = 4;
							continue;
						}
						case 3:
							return;
						case 4:
							goto IL_1D6;
						case 5:
							goto IL_1B1;
						case 6:
							try
							{
								num = 4;
								for (;;)
								{
									global::IshHandler.m m;
									switch (num)
									{
									case 0:
										goto IL_163;
									case 1:
										goto IL_157;
									case 2:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_122;
										default:
											if (false)
											{
											}
											goto IL_157;
										}
										break;
									case 3:
										if (m.a == 4112)
										{
											num = 6;
											continue;
										}
										break;
									case 5:
										if (!enumerator.MoveNext())
										{
											num = 2;
											continue;
										}
										goto IL_122;
									case 6:
										array = m.c;
										num = 1;
										continue;
									}
									IL_D6:
									num = 5;
									continue;
									goto IL_D6;
									IL_122:
									m = (global::IshHandler.m)enumerator.Current;
									num = 3;
									continue;
									IL_157:
									num = 0;
								}
								IL_163:
								goto IL_212;
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
											disposable.Dispose();
											num = 2;
											continue;
										case 1:
											if (disposable != null)
											{
												num = 0;
												continue;
											}
											goto IL_1B0;
										case 2:
											goto IL_1AE;
										}
										break;
									}
								}
								IL_1AE:
								IL_1B0:;
							}
							goto IL_1B1;
							IL_212:
							num = 8;
							continue;
						case 7:
						{
							int num3 = 0;
							num = 0;
							continue;
						}
						case 8:
							if (array != null)
							{
								num = 7;
								continue;
							}
							return;
						case 9:
						{
							int num3;
							if (num3 >= 10)
							{
								num = 1;
								continue;
							}
							A_0[num3] = array[num3];
							num3++;
							num = 5;
							continue;
						}
						case 10:
							if (true)
							{
							}
							goto IL_1D6;
						}
						break;
						IL_1B1:
						num = 9;
						continue;
						IL_1D6:
						num = 2;
					}
				}
				return;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000101EC File Offset: 0x0000F1EC
		public global::System.Collections.ArrayList a(global::System.Collections.ArrayList A_0)
		{
			global::System.Collections.ArrayList result;
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						this.w = default(global::IshHandler.g);
						this.w.d = new global::System.Collections.ArrayList();
						this.w.g = new global::System.Collections.ArrayList();
						this.w.e = false;
						this.w.c = 0U;
						this.w.f = false;
						this.w.a = "Radio Security Information Composite Data Block";
						int num = 0;
						int num2 = 15;
						for (;;)
						{
							int num5;
							global::IshHandler.k k2;
							switch (num2)
							{
							case 0:
								try
								{
									num2 = 3;
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::System.Collections.IEnumerator enumerator;
											if (!enumerator.MoveNext())
											{
												num2 = 6;
												continue;
											}
											global::IshHandler.m m = (global::IshHandler.m)enumerator.Current;
											num2 = 4;
											continue;
										}
										case 1:
											goto IL_205;
										case 2:
										{
											global::IshHandler.m m;
											byte[] array = m.c;
											num2 = 5;
											continue;
										}
										case 4:
										{
											global::IshHandler.m m;
											if (m.a == 4112)
											{
												num2 = 2;
												continue;
											}
											break;
										}
										case 5:
											goto IL_1F9;
										case 6:
											goto IL_1F9;
										}
										IL_1C5:
										num2 = 0;
										continue;
										goto IL_1C5;
										IL_1F9:
										num2 = 1;
									}
									IL_205:
									goto IL_11E;
								}
								finally
								{
									for (;;)
									{
										global::System.Collections.IEnumerator enumerator;
										global::System.IDisposable disposable = enumerator as global::System.IDisposable;
										num2 = 1;
										for (;;)
										{
											switch (num2)
											{
											case 0:
												disposable.Dispose();
												num2 = 2;
												continue;
											case 1:
												if (disposable != null)
												{
													num2 = 0;
													continue;
												}
												goto IL_252;
											case 2:
												goto IL_250;
											}
											break;
										}
									}
									IL_250:
									IL_252:;
								}
								goto IL_253;
								IL_11E:
								num2 = 2;
								continue;
							case 1:
								goto IL_384;
							case 2:
							{
								byte[] array;
								if (array == null)
								{
									num2 = 8;
									continue;
								}
								int num3 = 0;
								string text = string.Empty;
								int num4 = 0;
								num2 = 13;
								continue;
							}
							case 3:
								num5 = 0;
								num2 = 4;
								continue;
							case 4:
								goto IL_384;
							case 5:
							{
								int num4;
								if (num4 >= 10)
								{
									num2 = 6;
									continue;
								}
								int num3;
								global::IshHandler.k k = (global::IshHandler.k)this.w.d[num3];
								int num6 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num6 /= 8;
								byte[] array;
								byte b = array[num4];
								k.e = b.ToString("X2", global::System.Globalization.CultureInfo.InvariantCulture);
								this.w.d[num3] = k;
								string str = ((char)b).ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo);
								string text;
								text += str;
								num3++;
								num4++;
								num2 = 12;
								continue;
							}
							case 6:
							{
								string text;
								result = new global::System.Collections.ArrayList(1)
								{
									text
								};
								num2 = 9;
								continue;
							}
							case 7:
								goto IL_FC;
							case 8:
								goto IL_13A;
							case 9:
								goto IL_44C;
							case 10:
								if (num5 >= 10)
								{
									num2 = 11;
									continue;
								}
								goto IL_253;
							case 11:
							{
								byte[] array = null;
								global::System.Collections.IEnumerator enumerator = A_0.GetEnumerator();
								num2 = 0;
								continue;
							}
							case 12:
								goto IL_13F;
							case 13:
								goto IL_13F;
							case 14:
							{
								if (num >= 10)
								{
									num2 = 3;
									continue;
								}
								k2 = this.f();
								string text2 = (num + 1).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								text2 = text2.PadLeft(2, '0');
								k2.a = k2.a + " " + text2;
								this.w.d.Add(k2);
								num++;
								num2 = 7;
								continue;
							}
							case 15:
								goto IL_FC;
							}
							break;
							IL_FC:
							num2 = 14;
							continue;
							IL_13F:
							num2 = 5;
							continue;
							IL_253:
							k2 = this.d();
							string str2 = (num5 + 1).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
							k2.a = k2.a + " " + str2;
							this.w.d.Add(k2);
							num5++;
							num2 = 1;
							continue;
							IL_384:
							num2 = 10;
						}
					}
					IL_13A:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "ReadGemstoneSerialNumber", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_44C:
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
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
				{
					goto IL_48B;
				}
				IL_45C:
				ex2.Source = 2949U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				IL_48B:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_45C;
				default:
					if (true)
					{
					}
					if (false)
					{
					}
					throw;
				}
			}
			return result;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00010704 File Offset: 0x0000F704
		public string b(global::System.Collections.ArrayList A_0)
		{
			string result;
			for (;;)
			{
				if (true)
				{
				}
				switch (0)
				{
				default:
					result = string.Empty;
					try
					{
						global::System.Collections.IEnumerator enumerator = A_0.GetEnumerator();
						try
						{
							int num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = 3;
										continue;
									}
									global::IshHandler.m m = (global::IshHandler.m)enumerator.Current;
									num = 6;
									continue;
								}
								case 2:
									goto IL_CC;
								case 3:
									goto IL_C0;
								case 4:
								{
									global::IshHandler.m m;
									byte[] itemdata = m.c;
									result = global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ReadTuningVersionForParadise(itemdata);
									num = 5;
									continue;
								}
								case 5:
									goto IL_C0;
								case 6:
								{
									global::IshHandler.m m;
									if (m.a == 26896)
									{
										num = 4;
										continue;
									}
									break;
								}
								}
								IL_87:
								num = 0;
								continue;
								goto IL_87;
								IL_C0:
								num = 2;
							}
							IL_CC:;
						}
						finally
						{
							for (;;)
							{
								global::System.IDisposable disposable = enumerator as global::System.IDisposable;
								int num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										disposable.Dispose();
										num = 2;
										continue;
									case 1:
										if (disposable != null)
										{
											num = 0;
											continue;
										}
										goto IL_115;
									case 2:
										goto IL_113;
									}
									break;
								}
							}
							IL_113:
							IL_115:;
						}
					}
					catch
					{
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_131;
					}
					break;
				}
			}
			IL_131:
			if (false)
			{
			}
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00010870 File Offset: 0x0000F870
		public global::System.Collections.ArrayList c(global::System.Collections.ArrayList A_0)
		{
			global::System.Collections.ArrayList result;
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						this.w = default(global::IshHandler.g);
						this.w.d = new global::System.Collections.ArrayList();
						this.w.g = new global::System.Collections.ArrayList();
						this.w.e = false;
						this.w.c = 0U;
						this.w.f = false;
						this.w.a = "Radio Security Information Composite Data Block";
						int num = 0;
						int num2 = 10;
						for (;;)
						{
							string text2;
							switch (num2)
							{
							case 0:
							{
								if (num >= 10)
								{
									num2 = 3;
									continue;
								}
								global::IshHandler.k k = this.f();
								string text = (num + 1).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								text = text.PadLeft(2, '0');
								k.a = k.a + " " + text;
								this.w.d.Add(k);
								num++;
								num2 = 9;
								continue;
							}
							case 1:
								goto IL_3C8;
							case 2:
								goto IL_3A6;
							case 3:
							{
								byte[] array = null;
								global::System.Collections.IEnumerator enumerator = A_0.GetEnumerator();
								num2 = 6;
								continue;
							}
							case 4:
							{
								byte[] array;
								if (array == null)
								{
									num2 = 11;
									continue;
								}
								int num3 = 0;
								text2 = string.Empty;
								int num4 = 0;
								int num5 = 9;
								int num6 = num4;
								num2 = 8;
								continue;
							}
							case 5:
								goto IL_1C3;
							case 6:
								try
								{
									num2 = 5;
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_33C;
										case 1:
										{
											global::System.Collections.IEnumerator enumerator;
											if (!enumerator.MoveNext())
											{
												num2 = 6;
												continue;
											}
											global::IshHandler.m m = (global::IshHandler.m)enumerator.Current;
											num2 = 3;
											continue;
										}
										case 2:
										{
											global::IshHandler.m m;
											byte[] array = m.c;
											num2 = 4;
											continue;
										}
										case 3:
										{
											global::IshHandler.m m;
											if (m.a == 4112)
											{
												num2 = 2;
												continue;
											}
											break;
										}
										case 4:
											goto IL_330;
										case 6:
											goto IL_330;
										}
										IL_310:
										num2 = 1;
										continue;
										goto IL_310;
										IL_330:
										num2 = 0;
									}
									IL_33C:
									goto IL_27B;
								}
								finally
								{
									for (;;)
									{
										global::System.Collections.IEnumerator enumerator;
										global::System.IDisposable disposable = enumerator as global::System.IDisposable;
										num2 = 2;
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_3A3;
											case 1:
												disposable.Dispose();
												num2 = 0;
												continue;
											case 2:
												switch ((1 == 1) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_3A3;
												default:
													if (false)
													{
													}
													if (disposable != null)
													{
														num2 = 1;
														continue;
													}
													goto IL_3A5;
												}
												break;
											}
											break;
										}
									}
									IL_3A3:
									IL_3A5:;
								}
								goto IL_3A6;
								IL_27B:
								num2 = 4;
								continue;
							case 7:
							{
								int num5;
								int num6;
								if (num6 >= num5 + 1)
								{
									num2 = 2;
									continue;
								}
								int num3;
								global::IshHandler.k k2 = (global::IshHandler.k)this.w.d[num3];
								int num7 = int.Parse(k2.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num7 /= 8;
								byte[] array;
								byte b = array[num6];
								k2.e = b.ToString("X2", global::System.Globalization.CultureInfo.InvariantCulture);
								this.w.d[num3] = k2;
								string str = ((char)b).ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo);
								text2 += str;
								num3++;
								num6++;
								num2 = 5;
								continue;
							}
							case 8:
								goto IL_1C3;
							case 9:
								goto IL_179;
							case 10:
								goto IL_179;
							case 11:
								goto IL_297;
							}
							break;
							IL_179:
							num2 = 0;
							continue;
							IL_1C3:
							num2 = 7;
							continue;
							IL_3A6:
							result = new global::System.Collections.ArrayList(1)
							{
								text2
							};
							num2 = 1;
						}
					}
					IL_297:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "ReadSerialNumber", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_3C8:
					if (true)
					{
					}
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
					ex2.Source = 2949U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00010CE8 File Offset: 0x0000FCE8
		public global::System.Collections.ArrayList j()
		{
			global::System.Collections.ArrayList result;
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						this.w = default(global::IshHandler.g);
						this.w.d = new global::System.Collections.ArrayList();
						this.w.g = new global::System.Collections.ArrayList();
						this.w.e = false;
						this.w.c = 0U;
						this.w.f = false;
						this.w.a = "Radio Security Information Composite Data Block";
						int num = 0;
						int num2 = 3;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_432;
							case 1:
								goto IL_497;
							case 2:
							{
								int num3;
								if (num3 >= 10)
								{
									num2 = 12;
									continue;
								}
								global::IshHandler.k k = this.d();
								string str = (num3 + 1).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								k.a = k.a + " " + str;
								this.w.d.Add(k);
								num3++;
								num2 = 4;
								continue;
							}
							case 3:
								goto IL_D1;
							case 4:
								goto IL_349;
							case 5:
								goto IL_1CC;
							case 6:
							{
								if (num >= 10)
								{
									num2 = 10;
									continue;
								}
								global::IshHandler.k k = this.f();
								string text = (num + 1).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
								text = text.PadLeft(2, '0');
								k.a = k.a + " " + text;
								this.w.d.Add(k);
								num++;
								num2 = 11;
								continue;
							}
							case 7:
							{
								int num4;
								if (num4 >= 94)
								{
									num2 = 17;
									continue;
								}
								int num5;
								global::IshHandler.k k2 = (global::IshHandler.k)this.w.d[num5];
								int num6 = int.Parse(k2.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num6 /= 8;
								byte[] array;
								byte b = array[num4];
								k2.e = b.ToString("X2", global::System.Globalization.CultureInfo.InvariantCulture);
								this.w.d[num5] = k2;
								string str2 = ((char)b).ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo);
								string text2;
								text2 += str2;
								num5++;
								num4++;
								num2 = 9;
								continue;
							}
							case 8:
								goto IL_323;
							case 9:
								goto IL_1CC;
							case 10:
							{
								int num3 = 0;
								num2 = 14;
								continue;
							}
							case 11:
								goto IL_FC;
							case 12:
							{
								global::System.IntPtr source;
								ulong value;
								global::IshHandler.e.ReadISH(this.z, 4112, 0, out source, out value);
								int num7 = global::System.Convert.ToInt32(value);
								byte[] array = new byte[num7];
								num2 = 16;
								continue;
							}
							case 13:
							{
								int num4 = 84;
								num2 = 5;
								continue;
							}
							case 14:
								goto IL_349;
							case 15:
								goto IL_323;
							case 16:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_D1;
								default:
								{
									if (false)
									{
									}
									byte[] array;
									if (array == null)
									{
										num2 = 0;
										continue;
									}
									global::System.IntPtr source;
									int num7;
									global::System.Runtime.InteropServices.Marshal.Copy(source, array, 0, num7);
									int num5 = 0;
									string text3 = string.Empty;
									string text2 = string.Empty;
									int num8 = 0;
									num2 = 15;
									continue;
								}
								}
								break;
							case 17:
							{
								string text2;
								string text3;
								result = new global::System.Collections.ArrayList(2)
								{
									text3,
									text2
								};
								num2 = 1;
								continue;
							}
							case 18:
							{
								int num8;
								if (num8 >= 10)
								{
									num2 = 13;
									continue;
								}
								int num5;
								global::IshHandler.k k2 = (global::IshHandler.k)this.w.d[num5];
								int num6 = int.Parse(k2.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num6 /= 8;
								byte[] array;
								byte b = array[num8];
								k2.e = b.ToString("X2", global::System.Globalization.CultureInfo.InvariantCulture);
								this.w.d[num5] = k2;
								string str3 = ((char)b).ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo);
								string text3;
								text3 += str3;
								num5++;
								num8++;
								num2 = 8;
								continue;
							}
							}
							break;
							IL_FC:
							if (true)
							{
							}
							num2 = 6;
							continue;
							IL_D1:
							goto IL_FC;
							IL_1CC:
							num2 = 7;
							continue;
							IL_323:
							num2 = 18;
							continue;
							IL_349:
							num2 = 2;
						}
					}
					IL_432:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "ReadSerialNumber", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_497:
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
					ex2.Source = 2949U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00011210 File Offset: 0x00010210
		private void c()
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						int num = 0;
						int num2 = 14;
						for (;;)
						{
							int num4;
							switch (num2)
							{
							case 0:
								goto IL_2C6;
							case 1:
								goto IL_2D2;
							case 2:
							{
								if (num >= this.u.a.Count)
								{
									num2 = 18;
									continue;
								}
								global::IshHandler.g g = (global::IshHandler.g)this.u.a[num];
								num2 = 19;
								continue;
							}
							case 3:
								goto IL_FA;
							case 4:
								goto IL_12D;
							case 5:
								num2 = 13;
								continue;
							case 6:
							{
								int num3 = 0;
								num2 = 11;
								continue;
							}
							case 7:
								goto IL_296;
							case 8:
								goto IL_19C;
							case 9:
							{
								int num3;
								if (num3 >= this.w.d.Count)
								{
									num2 = 20;
									continue;
								}
								global::IshHandler.k k = (global::IshHandler.k)this.w.d[num3];
								num4 = 0;
								num2 = 7;
								continue;
							}
							case 10:
								goto IL_296;
							case 11:
								goto IL_19C;
							case 12:
							{
								global::IshHandler.k k;
								global::IshHandler.k k2;
								if (k2.g.Equals(k.g))
								{
									num2 = 5;
									continue;
								}
								goto IL_12D;
							}
							case 13:
							{
								global::IshHandler.k k;
								global::IshHandler.k k2;
								if (k2.a.Equals(k.a))
								{
									num2 = 17;
									continue;
								}
								goto IL_12D;
							}
							case 14:
								goto IL_76;
							case 15:
							{
								global::IshHandler.g g;
								if (num4 >= g.d.Count)
								{
									num2 = 16;
									continue;
								}
								global::IshHandler.k k2 = (global::IshHandler.k)g.d[num4];
								num2 = 12;
								continue;
							}
							case 16:
							{
								int num3;
								num3++;
								num2 = 8;
								continue;
							}
							case 17:
							{
								global::IshHandler.k k;
								global::IshHandler.k k2;
								k2.e = k.e;
								global::IshHandler.g g;
								g.d[num4] = k2;
								num2 = 4;
								continue;
							}
							case 18:
								goto IL_2C6;
							case 19:
							{
								global::IshHandler.g g;
								if (g.b == 4112U)
								{
									num2 = 6;
									continue;
								}
								num++;
								num2 = 3;
								continue;
							}
							case 20:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_76;
								default:
								{
									if (false)
									{
									}
									global::IshHandler.g g;
									this.u.a[num] = g;
									num2 = 0;
									continue;
								}
								}
								break;
							}
							break;
							IL_FA:
							num2 = 2;
							continue;
							IL_76:
							goto IL_FA;
							IL_12D:
							num4++;
							num2 = 10;
							continue;
							IL_19C:
							num2 = 9;
							continue;
							IL_296:
							num2 = 15;
							continue;
							IL_2C6:
							num2 = 1;
						}
					}
					IL_2D2:
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
					if (true)
					{
					}
					ex.Source = 2912U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				throw;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00011578 File Offset: 0x00010578
		private void b()
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
						global::IshHandler.k k;
						global::IshHandler.g g;
						int num2;
						int num4;
						switch (num)
						{
						case 0:
							goto IL_247;
						case 1:
						{
							global::IshHandler.k k2;
							k.e = k2.e;
							g.d[num2] = k;
							num = 20;
							continue;
						}
						case 2:
							goto IL_307;
						case 3:
							goto IL_1C2;
						case 4:
							goto IL_1C2;
						case 5:
						{
							int num3;
							num3++;
							num = 19;
							continue;
						}
						case 6:
							num = 8;
							continue;
						case 7:
							if (g.b == 4112U)
							{
								num = 14;
								continue;
							}
							num4++;
							num = 3;
							continue;
						case 8:
						{
							global::IshHandler.k k2;
							if (k.a.Equals(k2.a))
							{
								num = 1;
								continue;
							}
							goto IL_2C3;
						}
						case 9:
							this.u.a[num4] = g;
							num = 2;
							continue;
						case 10:
							num = 0;
							continue;
						case 11:
							if (num4 >= this.u.a.Count)
							{
								num = 13;
								continue;
							}
							g = (global::IshHandler.g)this.u.a[num4];
							num = 7;
							continue;
						case 12:
						{
							global::IshHandler.k k2;
							if (k.g.Equals(k2.g))
							{
								num = 6;
								continue;
							}
							goto IL_2C3;
						}
						case 13:
							goto IL_307;
						case 14:
						{
							int num3 = 0;
							num = 18;
							continue;
						}
						case 15:
							goto IL_313;
						case 17:
							goto IL_2D7;
						case 18:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1F5;
							default:
								if (false)
								{
								}
								goto IL_18E;
							}
							break;
						case 19:
							goto IL_18E;
						case 20:
							goto IL_2C3;
						case 21:
						{
							int num3;
							if (num3 >= this.x.d.Count)
							{
								num = 9;
								continue;
							}
							global::IshHandler.k k2 = (global::IshHandler.k)this.x.d[num3];
							num2 = 0;
							num = 23;
							continue;
						}
						case 22:
							if (num2 >= g.d.Count)
							{
								num = 5;
								continue;
							}
							goto IL_1F5;
						case 23:
							goto IL_2D7;
						}
						if (this.x.d == null)
						{
							num = 10;
							continue;
						}
						num4 = 0;
						num = 4;
						continue;
						IL_18E:
						num = 21;
						continue;
						IL_1C2:
						num = 11;
						continue;
						IL_1F5:
						k = (global::IshHandler.k)g.d[num2];
						num = 12;
						continue;
						IL_2C3:
						num2++;
						num = 17;
						continue;
						IL_2D7:
						num = 22;
						continue;
						IL_307:
						num = 15;
					}
					IL_247:
					IL_313:
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
					if (true)
					{
					}
					ex.Source = 2912U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				throw;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00011920 File Offset: 0x00010920
		private void a(uint A_0, uint A_1, string A_2, string A_3, string A_4)
		{
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						bool flag = false;
						int num = 0;
						int num2 = 23;
						for (;;)
						{
							int num4;
							global::IshHandler.g g;
							switch (num2)
							{
							case 0:
							{
								int num3;
								if (num3 == A_2.Length)
								{
									num2 = 10;
									continue;
								}
								goto IL_360;
							}
							case 1:
								num4 = 0;
								num2 = 20;
								continue;
							case 2:
								goto IL_147;
							case 3:
							{
								global::IshHandler.k k;
								if (!k.a.Equals(A_4))
								{
									goto IL_128;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_10A;
								default:
									if (false)
									{
									}
									num2 = 12;
									continue;
								}
								break;
							}
							case 4:
								goto IL_1F7;
							case 5:
							{
								uint num5;
								uint num6;
								if (num5 <= num6)
								{
									num2 = 6;
									continue;
								}
								goto IL_360;
							}
							case 6:
							{
								global::IshHandler.k k;
								k.e = A_2;
								g.d[num4] = k;
								flag = true;
								num2 = 19;
								continue;
							}
							case 7:
								if (g.b == A_0)
								{
									num2 = 17;
									continue;
								}
								goto IL_147;
							case 8:
								goto IL_330;
							case 9:
							{
								global::IshHandler.k k;
								if (k.g.Equals(A_3))
								{
									num2 = 25;
									continue;
								}
								goto IL_128;
							}
							case 10:
								num2 = 15;
								continue;
							case 11:
								goto IL_394;
							case 12:
							{
								global::IshHandler.k k;
								int num3 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num3 /= 4;
								uint num6 = this.b(k.d);
								uint num7 = this.b(k.c);
								uint num5 = this.b(A_2);
								num2 = 0;
								continue;
							}
							case 13:
								goto IL_10A;
							case 14:
								goto IL_D9;
							case 15:
							{
								uint num5;
								uint num7;
								if (num5 >= num7)
								{
									num2 = 26;
									continue;
								}
								goto IL_360;
							}
							case 16:
								num2 = 11;
								continue;
							case 17:
								num2 = 13;
								continue;
							case 18:
								if (num >= this.u.a.Count)
								{
									num2 = 16;
									continue;
								}
								g = (global::IshHandler.g)this.u.a[num];
								num2 = 7;
								continue;
							case 19:
								goto IL_128;
							case 20:
								goto IL_330;
							case 21:
								num2 = 22;
								continue;
							case 22:
							{
								if (flag)
								{
									num2 = 14;
									continue;
								}
								global::IshHandler.k k = (global::IshHandler.k)g.d[num4];
								num2 = 9;
								continue;
							}
							case 23:
								goto IL_1F7;
							case 24:
								if (num4 < g.d.Count)
								{
									num2 = 21;
									continue;
								}
								goto IL_D9;
							case 25:
								num2 = 3;
								continue;
							case 26:
								num2 = 5;
								continue;
							}
							break;
							IL_D9:
							this.u.a[num] = g;
							num2 = 2;
							continue;
							IL_10A:
							if (g.c == A_1)
							{
								num2 = 1;
								continue;
							}
							goto IL_147;
							IL_128:
							num4++;
							if (true)
							{
							}
							num2 = 8;
							continue;
							IL_147:
							num++;
							num2 = 4;
							continue;
							IL_1F7:
							num2 = 18;
							continue;
							IL_330:
							num2 = 24;
						}
					}
					IL_360:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "UpdateTargetStructValue", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_394:
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
					ex2.Source = 2950U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				throw;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00011D40 File Offset: 0x00010D40
		private void a(uint A_0, uint A_1, uint A_2, string A_3, string A_4, uint A_5)
		{
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						bool flag = false;
						int num = 0;
						int num2 = 3;
						for (;;)
						{
							global::IshHandler.g g;
							int num4;
							switch (num2)
							{
							case 0:
								goto IL_396;
							case 1:
								num2 = 17;
								continue;
							case 2:
							{
								uint num3;
								if (A_2 <= num3)
								{
									num2 = 8;
									continue;
								}
								goto IL_362;
							}
							case 3:
								goto IL_1D4;
							case 4:
								goto IL_332;
							case 5:
								if (g.b == A_0)
								{
									num2 = 1;
									continue;
								}
								goto IL_13F;
							case 6:
								num2 = 2;
								continue;
							case 7:
								num2 = 9;
								continue;
							case 8:
							{
								global::IshHandler.k k;
								string text;
								k.e = text;
								g.d[num4] = k;
								flag = true;
								num2 = 11;
								continue;
							}
							case 9:
							{
								global::IshHandler.k k;
								if (k.a.Equals(A_4))
								{
									num2 = 26;
									continue;
								}
								goto IL_128;
							}
							case 10:
								if (num4 < g.d.Count)
								{
									num2 = 21;
									continue;
								}
								goto IL_D9;
							case 11:
								goto IL_128;
							case 12:
								goto IL_D9;
							case 13:
								if (num >= this.u.a.Count)
								{
									num2 = 18;
									continue;
								}
								g = (global::IshHandler.g)this.u.a[num];
								num2 = 5;
								continue;
							case 14:
							{
								global::IshHandler.k k;
								if (k.g.Equals(A_3))
								{
									num2 = 7;
									continue;
								}
								goto IL_128;
							}
							case 15:
								goto IL_332;
							case 16:
								goto IL_13F;
							case 17:
								if (g.c == A_1)
								{
									num2 = 20;
									continue;
								}
								goto IL_13F;
							case 18:
								num2 = 0;
								continue;
							case 19:
							{
								string text;
								int num5;
								if (num5 == text.Length)
								{
									num2 = 23;
									continue;
								}
								goto IL_362;
							}
							case 20:
								num4 = 0;
								num2 = 4;
								continue;
							case 21:
								num2 = 25;
								continue;
							case 22:
							{
								uint num6;
								if (A_2 >= num6)
								{
									num2 = 6;
									continue;
								}
								goto IL_362;
							}
							case 23:
								num2 = 22;
								continue;
							case 24:
								goto IL_1D4;
							case 25:
							{
								if (flag)
								{
									num2 = 12;
									continue;
								}
								global::IshHandler.k k = (global::IshHandler.k)g.d[num4];
								num2 = 14;
								continue;
							}
							case 26:
							{
								global::IshHandler.k k;
								int num5 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num5 /= 4;
								uint num3 = this.b(k.d);
								uint num6 = this.b(k.c);
								uint num7 = this.b(k.e);
								uint num8 = num7 & A_5;
								A_2 = (num8 | A_2);
								string text = A_2.ToString("X2", global::System.Globalization.CultureInfo.InvariantCulture);
								num2 = 19;
								continue;
							}
							}
							break;
							IL_D9:
							this.u.a[num] = g;
							num2 = 16;
							continue;
							IL_128:
							num4++;
							num2 = 15;
							continue;
							IL_13F:
							num++;
							num2 = 24;
							continue;
							IL_1D4:
							num2 = 13;
							continue;
							IL_332:
							num2 = 10;
						}
					}
					IL_362:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "UpdateCFSLegacyBits", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_396:
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
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
				{
					goto IL_3D5;
				}
				IL_3A8:
				ex2.Source = 2951U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				IL_3D5:
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3A8;
				default:
					if (false)
					{
					}
					throw;
				}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00012188 File Offset: 0x00011188
		private bool a(uint A_0, uint A_1, string A_2, uint A_3, uint A_4)
		{
			bool result;
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						bool flag = false;
						bool flag2 = false;
						int num = 0;
						int num2 = 19;
						for (;;)
						{
							global::IshHandler.g g;
							int num3;
							switch (num2)
							{
							case 0:
								flag = true;
								num2 = 12;
								continue;
							case 1:
								num2 = 4;
								continue;
							case 2:
								result = flag;
								num2 = 9;
								continue;
							case 3:
								goto IL_E2;
							case 4:
							{
								if (flag2)
								{
									num2 = 11;
									continue;
								}
								global::IshHandler.k k = (global::IshHandler.k)g.d[num3];
								num2 = 16;
								continue;
							}
							case 5:
								goto IL_10F;
							case 6:
								if (num >= this.u.a.Count)
								{
									num2 = 2;
									continue;
								}
								g = (global::IshHandler.g)this.u.a[num];
								num2 = 8;
								continue;
							case 7:
							{
								uint num4;
								if (num4 == A_4)
								{
									num2 = 0;
									continue;
								}
								goto IL_143;
							}
							case 8:
								if (g.b == A_0)
								{
									num2 = 14;
									continue;
								}
								goto IL_196;
							case 9:
								goto IL_281;
							case 10:
								num3 = 0;
								num2 = 3;
								continue;
							case 11:
								goto IL_92;
							case 12:
								goto IL_143;
							case 13:
							{
								global::IshHandler.k k;
								uint num5 = this.b(k.e);
								uint num4 = num5 & A_3;
								num2 = 7;
								continue;
							}
							case 14:
								num2 = 15;
								continue;
							case 15:
								if (g.c == A_1)
								{
									num2 = 10;
									continue;
								}
								goto IL_196;
							case 16:
							{
								global::IshHandler.k k;
								if (k.a.Equals(A_2))
								{
									num2 = 13;
									continue;
								}
								goto IL_25B;
							}
							case 17:
								goto IL_E2;
							case 18:
								if (num3 < g.d.Count)
								{
									num2 = 1;
									continue;
								}
								goto IL_92;
							case 19:
								goto IL_10F;
							case 20:
								goto IL_196;
							case 21:
								goto IL_25B;
							}
							break;
							IL_92:
							this.u.a[num] = g;
							num2 = 20;
							continue;
							IL_E2:
							num2 = 18;
							continue;
							IL_10F:
							num2 = 6;
							continue;
							IL_143:
							flag2 = true;
							num2 = 21;
							continue;
							IL_196:
							num++;
							num2 = 5;
							continue;
							IL_25B:
							num3++;
							num2 = 17;
						}
					}
					IL_281:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					goto IL_2C8;
				}
				if (true)
				{
				}
				IL_29B:
				ex.Source = 2951U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				IL_2C8:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_29B;
				default:
					if (false)
					{
					}
					throw;
				}
			}
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000124BC File Offset: 0x000114BC
		public void a(string A_0, string A_1, int A_2)
		{
			try
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (A_0.Length == 0)
						{
							goto IL_41;
						}
						global::IshHandler.e.PutCodeplugInMemory(this.z, A_0, A_1, A_2);
						num = 3;
						continue;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_41;
						default:
							goto IL_5F;
						}
						break;
					case 3:
						goto IL_A6;
					case 4:
						num = 0;
						continue;
					}
					if (A_0 != null)
					{
						num = 4;
						continue;
					}
					goto IL_67;
					IL_41:
					num = 1;
				}
				IL_5F:
				if (false)
				{
				}
				IL_67:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "PutFileIntoISH", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
				IL_A6:;
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex2)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = 2921U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				throw;
			}
			if (true)
			{
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000125DC File Offset: 0x000115DC
		public void a(string A_0, out ulong A_1, out ulong A_2, out ulong A_3, out ulong A_4, out ulong A_5, out ulong A_6, out ulong A_7, out ulong A_8)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 7;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_68;
						case 1:
							if (this.z != global::System.IntPtr.Zero)
							{
								num = 2;
								continue;
							}
							goto IL_DE;
						case 2:
							global::IshHandler.e.Close_Ish(this.z);
							this.z = global::System.IntPtr.Zero;
							num = 5;
							continue;
						case 3:
							goto IL_19D;
						case 4:
							if (A_0.Length == 0)
							{
								num = 0;
								continue;
							}
							num = 1;
							continue;
						case 5:
							goto IL_DE;
						case 6:
							num = 4;
							continue;
						}
						if (A_0 != null)
						{
							num = 6;
							continue;
						}
						break;
						IL_DE:
						this.z = global::IshHandler.e.OpenIsh();
						this.aa = global::IshHandler.e.a();
						string empty = string.Empty;
						global::IshHandler.e.initVirtualFlashMemory(this.z);
						global::IshHandler.e.EraseCodeplugVirtualMemory(this.z);
						global::IshHandler.e.PutPSDTInMemory(this.z, A_0, 201326592U);
						ulong num2 = 0UL;
						ulong num3 = 0UL;
						ulong num4 = 0UL;
						ulong num5 = 0UL;
						ulong num6 = 0UL;
						ulong num7 = 0UL;
						ulong num8 = 0UL;
						ulong num9 = 0UL;
						new global::IshHandler.a(this.a);
						global::IshHandler.e.read_psdt(this.z, null, out num2, out num3, out num4, out num5, out num6, out num7, out num8, out num9, 201326592UL);
						A_1 = num2;
						A_2 = num3;
						A_3 = num4;
						A_4 = num5;
						A_5 = num6;
						A_6 = num7;
						A_7 = num8;
						A_8 = num9;
						num = 3;
					}
					IL_68:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "ProcessPSDTSection", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_19D:
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
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex2))
				{
					goto IL_1DC;
				}
				IL_1AF:
				ex2.Source = 2922U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				IL_1DC:
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1AF;
				default:
					if (false)
					{
					}
					throw;
				}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0001282C File Offset: 0x0001182C
		public void a(string A_0, out ulong A_1, out ulong A_2, string A_3)
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
							num = 1;
							continue;
						case 1:
							if (A_0.Length == 0)
							{
								num = 7;
								continue;
							}
							num = 3;
							continue;
						case 2:
							goto IL_FA;
						case 3:
							if (this.z != global::System.IntPtr.Zero)
							{
								num = 6;
								continue;
							}
							goto IL_FA;
						case 4:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_86;
							default:
								if (false)
								{
								}
								break;
							}
							break;
						case 5:
							goto IL_151;
						case 6:
							goto IL_86;
						case 7:
							goto IL_84;
						}
						if (A_0 != null)
						{
							num = 0;
							continue;
						}
						break;
						IL_86:
						global::IshHandler.e.Close_Ish(this.z);
						this.z = global::System.IntPtr.Zero;
						num = 2;
						continue;
						IL_FA:
						this.z = global::IshHandler.e.OpenIsh();
						this.aa = global::IshHandler.e.a();
						global::IshHandler.e.PutPSDTInMemory(this.z, A_0, 201326592U);
						ulong num2 = 0UL;
						ulong num3 = 0UL;
						global::IshHandler.e.read_partition(this.z, null, out num2, out num3, A_3, 201326592UL);
						A_1 = num2;
						A_2 = num3;
						num = 5;
					}
					IL_84:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "ProcessPSDTSection", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_151:
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
					ex2.Source = 2955U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				throw;
			}
			if (true)
			{
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00012A10 File Offset: 0x00011A10
		private void a(ushort A_0)
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
			this.s.Add(A_0.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00012A64 File Offset: 0x00011A64
		private void a(string A_0, string A_1, global::System.Collections.ArrayList A_2)
		{
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
						global::IshHandler.j a_ = this.a(A_0, false);
						bool flag = false;
						bool flag2 = true;
						uint num = 0U;
						uint num2 = 0U;
						uint num3 = 0U;
						uint num4 = 0U;
						uint num5 = 0U;
						string text = string.Empty;
						string text2 = string.Empty;
						global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
						global::System.Collections.ArrayList arrayList3 = new global::System.Collections.ArrayList();
						int num6 = 0;
						int num7 = 40;
						for (;;)
						{
							int num8;
							global::IshHandler.g g2;
							global::IshHandler.g a_3;
							global::IshHandler.g g3;
							int num9;
							int num12;
							switch (num7)
							{
							case 0:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_A2B;
								default:
									if (false)
									{
									}
									num7 = 39;
									continue;
								}
								break;
							case 1:
							{
								global::IshHandler.g a_2;
								global::IshHandler.f.a(a_2, num3, ref arrayList3, 10);
								num7 = 63;
								continue;
							}
							case 2:
								num7 = 28;
								continue;
							case 3:
								if (!flag2)
								{
									num7 = 25;
									continue;
								}
								goto IL_4BD;
							case 4:
								num7 = 51;
								continue;
							case 5:
							{
								if (num8 >= this.u.a.Count)
								{
									num7 = 54;
									continue;
								}
								global::IshHandler.g g = (global::IshHandler.g)this.u.a[num8];
								num5 = this.b(((global::IshHandler.k)g.d[0]).e);
								num7 = 15;
								continue;
							}
							case 6:
								goto IL_4BD;
							case 7:
								goto IL_376;
							case 8:
							{
								global::IshHandler.g a_2;
								global::IshHandler.f.a(a_2, num4, ref arrayList2, num6);
								num7 = 61;
								continue;
							}
							case 9:
								goto IL_482;
							case 10:
								if (g2.b == a_3.b)
								{
									num7 = 23;
									continue;
								}
								goto IL_2D7;
							case 11:
								if (num5 == 2U)
								{
									num7 = 49;
									continue;
								}
								goto IL_8D6;
							case 12:
								goto IL_376;
							case 13:
							{
								int index;
								this.u.a[index] = g3;
								num7 = 26;
								continue;
							}
							case 14:
								if (string.Equals(A_1, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
								{
									num7 = 56;
									continue;
								}
								goto IL_4BD;
							case 15:
							{
								global::IshHandler.g g;
								if (!this.s.Contains(g.b.ToString(global::System.Globalization.CultureInfo.InvariantCulture)))
								{
									num7 = 30;
									continue;
								}
								goto IL_8D6;
							}
							case 16:
								goto IL_586;
							case 17:
								goto IL_586;
							case 18:
								num7 = 64;
								continue;
							case 19:
								goto IL_8D6;
							case 20:
								if (a_3.e)
								{
									num7 = 62;
									continue;
								}
								goto IL_376;
							case 21:
								if (num3 != 0U)
								{
									num7 = 1;
									continue;
								}
								goto IL_554;
							case 22:
								goto IL_27D;
							case 23:
								num7 = 36;
								continue;
							case 24:
								if (flag)
								{
									num7 = 13;
									continue;
								}
								this.u.a[num9] = g3;
								num7 = 12;
								continue;
							case 25:
								num7 = 29;
								continue;
							case 26:
								goto IL_376;
							case 27:
							{
								global::IshHandler.k k;
								if (k.a == "Item Structure Indicator")
								{
									num7 = 2;
									continue;
								}
								goto IL_4BD;
							}
							case 28:
							{
								global::IshHandler.k k2;
								if (k2.a == "Item Structure Indicator")
								{
									num7 = 50;
									continue;
								}
								goto IL_4BD;
							}
							case 29:
								if (num != num2)
								{
									num7 = 18;
									continue;
								}
								goto IL_4BD;
							case 30:
								num7 = 11;
								continue;
							case 31:
								goto IL_27D;
							case 32:
							{
								g3 = default(global::IshHandler.g);
								g3.d = (global::System.Collections.ArrayList)g2.d.Clone();
								g3.e = true;
								g3.g = new global::System.Collections.ArrayList();
								g3.b = g2.b;
								g3.a = g2.a;
								g3.c = a_3.c;
								int index = this.u.a.Add(g3);
								flag = true;
								num7 = 33;
								continue;
							}
							case 33:
								goto IL_482;
							case 34:
								if (num2 != 0U)
								{
									num7 = 8;
									continue;
								}
								goto IL_899;
							case 35:
							{
								uint num10;
								switch (num10)
								{
								case 1U:
								{
									num = this.b(this.a(a_3, 6));
									global::IshHandler.g a_2;
									num2 = this.b(this.a(a_2, 6));
									num3 = this.b(this.a(a_2, 9));
									num4 = this.b(this.a(a_2, 1));
									num7 = 21;
									continue;
								}
								case 2U:
								{
									num = this.b(this.a(a_3, 1));
									global::IshHandler.g a_2;
									num2 = this.b(this.a(a_2, 1));
									num6 = 4;
									int num11 = 4;
									num7 = 69;
									continue;
								}
								default:
									num7 = 48;
									continue;
								}
								break;
							}
							case 36:
								if (this.y.Contains(a_3.b))
								{
									num7 = 42;
									continue;
								}
								goto IL_693;
							case 37:
								flag2 = false;
								num7 = 17;
								continue;
							case 38:
								goto IL_A3C;
							case 39:
								goto IL_AFD;
							case 40:
								if (string.Equals(A_1, "06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
								{
									num7 = 68;
									continue;
								}
								goto IL_954;
							case 41:
							{
								uint a_4 = num - num2;
								num6 += (int)(num2 * (uint)arrayList2.Count);
								global::IshHandler.f.a(ref g2, arrayList2, a_4, num6, num2);
								num7 = 6;
								continue;
							}
							case 42:
								num7 = 65;
								continue;
							case 43:
							{
								if (num12 >= this.t.a.Count)
								{
									num7 = 0;
									continue;
								}
								a_3 = (global::IshHandler.g)this.t.a[num12];
								int index = 0;
								num9 = 0;
								num7 = 20;
								continue;
							}
							case 44:
								goto IL_586;
							case 45:
								goto IL_4BD;
							case 46:
							{
								global::IshHandler.k k;
								num5 = this.b(k.e);
								global::IshHandler.g a_2 = this.a(a_, g2.b);
								g2 = default(global::IshHandler.g);
								g2.d = (global::System.Collections.ArrayList)a_2.d.Clone();
								g2.b = a_2.b;
								g2.a = a_2.a;
								g2.c = a_3.c;
								uint num10 = num5;
								num7 = 35;
								continue;
							}
							case 47:
								if (text == text2)
								{
									num7 = 46;
									continue;
								}
								goto IL_871;
							case 48:
								num7 = 55;
								continue;
							case 49:
								this.u.a.RemoveAt(num8);
								num8--;
								num7 = 19;
								continue;
							case 50:
							{
								global::IshHandler.k k;
								text = global::IshHandler.f.c(k.e);
								global::IshHandler.k k2;
								text2 = global::IshHandler.f.c(k2.e);
								num7 = 47;
								continue;
							}
							case 51:
								if (!this.y.Contains(a_3.b))
								{
									num7 = 32;
									continue;
								}
								goto IL_968;
							case 52:
							{
								global::IshHandler.g a_2;
								int num11;
								if (num11 >= a_2.d.Count - 1)
								{
									num7 = 37;
									continue;
								}
								global::IshHandler.k k2 = (global::IshHandler.k)a_2.d[num11];
								arrayList2.Add((global::IshHandler.k)a_2.d[num11]);
								int num13 = int.Parse(k2.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num13 /= 8;
								num4 += (uint)num13;
								num11++;
								num7 = 53;
								continue;
							}
							case 53:
								goto IL_2EE;
							case 54:
								goto IL_954;
							case 55:
								flag2 = true;
								goto IL_A2B;
							case 56:
							{
								flag2 = true;
								arrayList2.Clear();
								arrayList3.Clear();
								num4 = 0U;
								global::IshHandler.k k = (global::IshHandler.k)a_3.d[0];
								global::IshHandler.k k2 = (global::IshHandler.k)g2.d[0];
								num7 = 27;
								continue;
							}
							case 57:
								goto IL_90F;
							case 58:
								goto IL_90F;
							case 59:
								if (arrayList.Contains(a_3.b))
								{
									num7 = 4;
									continue;
								}
								goto IL_968;
							case 60:
								goto IL_A3C;
							case 61:
								goto IL_899;
							case 62:
								num7 = 57;
								continue;
							case 63:
								goto IL_554;
							case 64:
								if (num > num2)
								{
									num7 = 41;
									continue;
								}
								num6 += (int)((long)arrayList2.Count * (long)((ulong)num));
								g2.d.RemoveRange(num6, g2.d.Count - num6 - 1);
								num7 = 45;
								continue;
							case 65:
								if (g2.c == a_3.c)
								{
									num7 = 67;
									continue;
								}
								goto IL_2D7;
							case 66:
								if (num9 >= this.u.a.Count)
								{
									num7 = 7;
									continue;
								}
								g2 = (global::IshHandler.g)this.u.a[num9];
								num7 = 10;
								continue;
							case 67:
								goto IL_693;
							case 68:
								num8 = 0;
								num7 = 22;
								continue;
							case 69:
								goto IL_2EE;
							}
							break;
							IL_27D:
							num7 = 5;
							continue;
							IL_2D7:
							num9++;
							num7 = 58;
							continue;
							IL_2EE:
							num7 = 52;
							continue;
							IL_376:
							num12++;
							num7 = 38;
							continue;
							IL_482:
							g3.c = a_3.c;
							this.a(a_3, ref g3);
							num7 = 24;
							continue;
							IL_4BD:
							num7 = 59;
							continue;
							IL_554:
							num6 = 9 + arrayList3.Count + 1;
							num7 = 34;
							continue;
							IL_586:
							num7 = 3;
							continue;
							IL_693:
							num7 = 14;
							continue;
							IL_899:
							flag2 = false;
							num7 = 16;
							continue;
							IL_8D6:
							num8++;
							num7 = 31;
							continue;
							IL_90F:
							num7 = 66;
							continue;
							IL_954:
							num12 = 0;
							num7 = 60;
							continue;
							IL_968:
							g3 = g2;
							arrayList.Add(a_3.b);
							flag = false;
							num7 = 9;
							continue;
							IL_A2B:
							num7 = 44;
							continue;
							IL_A3C:
							num7 = 43;
						}
					}
					IL_871:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2908U, "DeviceUpdate", "UpdateCPStruct", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					throw ex;
					IL_AFD:
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
					ex2.Source = 2929U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex2.Source;
				}
				throw;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000135F8 File Offset: 0x000125F8
		private static void a(global::IshHandler.g A_0, uint A_1, ref global::System.Collections.ArrayList A_2, int A_3)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					int num = A_3;
					int num2 = int.Parse(((global::IshHandler.k)A_0.d[num]).b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
					int num3 = num2 / 8;
					A_2.Add((global::IshHandler.k)A_0.d[num]);
					int num4 = 0;
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_120;
							default:
								if (true)
								{
								}
								if (false)
								{
								}
								goto IL_AF;
							}
							break;
						case 1:
							return;
						case 2:
							goto IL_AF;
						case 3:
						{
							if ((long)num3 >= (long)((ulong)A_1))
							{
								num4 = 1;
								continue;
							}
							num++;
							global::IshHandler.k k = (global::IshHandler.k)A_0.d[num];
							A_2.Add((global::IshHandler.k)A_0.d[num]);
							num2 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
							num2 /= 8;
							num3 += num2;
							goto IL_120;
						}
						}
						break;
						IL_AF:
						num4 = 3;
						continue;
						IL_120:
						num4 = 2;
					}
				}
				return;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00013734 File Offset: 0x00012734
		private void a(global::IshHandler.g A_0, ref global::IshHandler.g A_1)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num;
					int num2;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_BF:
						num++;
						num2 = 10;
						break;
					default:
						if (false)
						{
						}
						goto IL_6B;
					}
					for (;;)
					{
						IL_2C:
						int num3;
						switch (num2)
						{
						case 0:
							goto IL_1CE;
						case 1:
							goto IL_F4;
						case 2:
							goto IL_172;
						case 3:
							A_1.e = true;
							num2 = 0;
							continue;
						case 4:
							goto IL_F4;
						case 5:
							num2 = 6;
							continue;
						case 6:
						{
							global::IshHandler.k k;
							global::IshHandler.k a_;
							if (k.g.Equals(a_.g))
							{
								num2 = 7;
								continue;
							}
							goto IL_1A6;
						}
						case 7:
						{
							global::IshHandler.k k;
							global::IshHandler.k a_;
							this.a(a_, ref k);
							A_1.d[num3] = k;
							num2 = 2;
							continue;
						}
						case 8:
						{
							if (num3 >= A_1.d.Count)
							{
								num2 = 11;
								continue;
							}
							global::IshHandler.k k = (global::IshHandler.k)A_1.d[num3];
							num2 = 13;
							continue;
						}
						case 9:
							goto IL_11F;
						case 10:
							goto IL_11F;
						case 11:
							goto IL_11D;
						case 12:
						{
							if (num >= A_0.d.Count)
							{
								num2 = 3;
								continue;
							}
							global::IshHandler.k a_ = (global::IshHandler.k)A_0.d[num];
							num3 = 0;
							num2 = 1;
							continue;
						}
						case 13:
						{
							global::IshHandler.k k;
							global::IshHandler.k a_;
							if (k.a.Equals(a_.a))
							{
								num2 = 5;
								continue;
							}
							goto IL_1A6;
						}
						}
						goto IL_6B;
						IL_F4:
						num2 = 8;
						continue;
						IL_11F:
						num2 = 12;
						continue;
						IL_1A6:
						num3++;
						num2 = 4;
					}
					IL_11D:
					IL_172:
					goto IL_BF;
					IL_1CE:
					break;
					IL_6B:
					num = 0;
					num2 = 9;
					goto IL_2C;
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
					ex.Source = 2930U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				throw;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00013998 File Offset: 0x00012998
		private void a(global::IshHandler.k A_0, ref global::IshHandler.k A_1)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 46;
					for (;;)
					{
						string text2;
						int num2;
						int num3;
						string text;
						int num4;
						int num5;
						int num6;
						bool flag;
						string text3;
						uint num8;
						uint a_;
						uint a_2;
						int num12;
						int num13;
						switch (num)
						{
						case 0:
							goto IL_4FE;
						case 1:
							goto IL_3C6;
						case 2:
							num = 10;
							continue;
						case 3:
							goto IL_22B;
						case 4:
							goto IL_4FE;
						case 5:
							goto IL_556;
						case 6:
							goto IL_2B0;
						case 7:
							goto IL_7F9;
						case 8:
							goto IL_3C6;
						case 9:
						{
							global::IshHandler.b b;
							if (b.f.Equals("PRESERVE_YES"))
							{
								num = 35;
								continue;
							}
							text = text2.Substring(text2.Length - num2 - num3, num3);
							num = 49;
							continue;
						}
						case 10:
							if (num4 < num5)
							{
								num = 26;
								continue;
							}
							goto IL_57C;
						case 11:
							if (num4 <= num6)
							{
								num = 2;
								continue;
							}
							goto IL_6D1;
						case 12:
							if (A_1.f.Equals("PRESERVE_YES"))
							{
								num = 29;
								continue;
							}
							goto IL_7ED;
						case 13:
						{
							global::IshHandler.b b;
							if (b.e.Length > 0)
							{
								num = 47;
								continue;
							}
							goto IL_556;
						}
						case 14:
							text = text.PadLeft(num3, '0');
							num = 39;
							continue;
						case 15:
							if (flag)
							{
								num = 23;
								continue;
							}
							goto IL_7ED;
						case 16:
							goto IL_7ED;
						case 17:
						{
							int num7 = 0;
							num = 34;
							continue;
						}
						case 18:
						{
							global::IshHandler.b b;
							if (b.d.Length > 0)
							{
								num = 41;
								continue;
							}
							goto IL_2B0;
						}
						case 19:
							goto IL_4A7;
						case 20:
						{
							num8 = (uint)this.a(text3, 2);
							string text4 = string.Empty;
							num = 48;
							continue;
						}
						case 21:
						{
							bool flag2;
							if (flag2)
							{
								goto IL_4B7;
							}
							text = text2.Substring(text2.Length - num2 - num3, num3);
							num = 0;
							continue;
						}
						case 22:
						{
							bool flag2 = true;
							num = 19;
							continue;
						}
						case 23:
						{
							string text4;
							A_1.e = text4;
							num = 30;
							continue;
						}
						case 24:
							a_ = this.b(A_1.d);
							a_2 = this.b(A_1.c);
							num = 44;
							continue;
						case 25:
						{
							global::IshHandler.b b;
							global::IshHandler.b b2;
							if (b2.a.Equals(b.a))
							{
								num = 22;
								continue;
							}
							int num9;
							int num10;
							num9 += num10;
							int num7;
							num7++;
							num = 43;
							continue;
						}
						case 26:
							goto IL_6D1;
						case 27:
							goto IL_57C;
						case 28:
							goto IL_25B;
						case 29:
						{
							string a_3 = A_0.e;
							int num11 = int.Parse(A_1.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
							num11 /= 8;
							a_3 = this.b(a_3, num11);
							uint a_4 = this.b(a_3);
							bool flag3 = this.a(a_4, a_2, a_, (uint)num11);
							num = 31;
							continue;
						}
						case 30:
							goto IL_7ED;
						case 31:
						{
							bool flag3;
							if (flag3)
							{
								num = 40;
								continue;
							}
							goto IL_7ED;
						}
						case 32:
							goto IL_25B;
						case 33:
						{
							int num7;
							if (num7 >= A_0.h.Count)
							{
								num = 51;
								continue;
							}
							global::IshHandler.b b2 = (global::IshHandler.b)A_0.h[num7];
							int num10 = int.Parse(b2.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
							num = 25;
							continue;
						}
						case 34:
							goto IL_22B;
						case 35:
						{
							int num7 = 0;
							num = 3;
							continue;
						}
						case 36:
						{
							int num9;
							int num10;
							string text5;
							text = text5.Substring(text5.Length - num9 - num10, num10);
							num = 4;
							continue;
						}
						case 37:
						{
							if (true)
							{
							}
							text3 = "";
							num12 = 0;
							string text6 = A_0.e.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
							int a_5 = int.Parse(text6, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
							string text5 = this.a(a_5, 2);
							string text7 = A_1.e.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
							int a_6 = int.Parse(text7, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
							text2 = this.a(a_6, 2);
							num13 = int.Parse(A_1.b.ToString(global::System.Globalization.CultureInfo.InvariantCulture), global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
							text5 = text5.PadLeft(num13, '0');
							text2 = text2.PadLeft(num13, '0');
							num2 = 0;
							num = 8;
							continue;
						}
						case 38:
						{
							string text4 = "0";
							num = 28;
							continue;
						}
						case 39:
							goto IL_66A;
						case 40:
						{
							string a_3;
							A_1.e = a_3;
							A_1.i = a_3;
							num = 16;
							continue;
						}
						case 41:
						{
							global::IshHandler.b b;
							num5 = int.Parse(b.d, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_4B7;
							default:
								if (false)
								{
								}
								num = 6;
								continue;
							}
							break;
						}
						case 42:
							text = text.Substring(text.Length - num3, num3);
							num = 45;
							continue;
						case 43:
						{
							int num7;
							if (num7 > A_0.h.Count)
							{
								num = 17;
								continue;
							}
							goto IL_22B;
						}
						case 44:
							if (A_1.h.Count > 0)
							{
								num = 37;
								continue;
							}
							num = 12;
							continue;
						case 45:
							goto IL_7D1;
						case 47:
						{
							global::IshHandler.b b;
							num6 = int.Parse(b.e, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
							num = 5;
							continue;
						}
						case 48:
						{
							if (num8 == 0U)
							{
								num = 38;
								continue;
							}
							string text4 = this.a((int)num8, 16);
							num = 32;
							continue;
						}
						case 49:
							goto IL_57C;
						case 50:
						{
							if (num12 >= A_1.h.Count)
							{
								num = 20;
								continue;
							}
							global::IshHandler.b b = (global::IshHandler.b)A_1.h[num12];
							num3 = int.Parse(b.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
							int num7 = 0;
							bool flag2 = false;
							int num9 = 0;
							int num10 = 0;
							text = string.Empty;
							num = 9;
							continue;
						}
						case 51:
							goto IL_4A7;
						case 52:
							if (text.Length < num3)
							{
								num = 14;
								continue;
							}
							goto IL_66A;
						case 53:
							if (text.Length > num3)
							{
								num = 42;
								continue;
							}
							goto IL_7D1;
						}
						if (!A_1.e.Equals("eqn(sum)"))
						{
							num = 24;
							continue;
						}
						goto IL_7ED;
						IL_22B:
						num = 33;
						continue;
						IL_25B:
						flag = this.a(num8, a_2, a_, (uint)(num13 / 8));
						num = 15;
						continue;
						IL_2B0:
						num = 13;
						continue;
						IL_3C6:
						num = 50;
						continue;
						IL_4A7:
						num = 21;
						continue;
						IL_4B7:
						num = 36;
						continue;
						IL_4FE:
						num4 = this.a(text, 2);
						num5 = 0;
						num6 = 255;
						num = 18;
						continue;
						IL_556:
						num = 11;
						continue;
						IL_57C:
						num2 += num3;
						num12++;
						num = 52;
						continue;
						IL_66A:
						num = 53;
						continue;
						IL_6D1:
						text = text2.Substring(text2.Length - num2 - num3, num3);
						num = 27;
						continue;
						IL_7D1:
						text3 = text + text3;
						num = 1;
						continue;
						IL_7ED:
						num = 7;
					}
					IL_7F9:
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
					ex.Source = 2931U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				throw;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00014220 File Offset: 0x00013220
		private bool a(uint A_0, uint A_1, uint A_2, uint A_3)
		{
			switch (0)
			{
			default:
			{
				bool result;
				for (;;)
				{
					result = false;
					uint num = A_0;
					uint num2 = A_1;
					uint num3 = A_2;
					int num4 = 0;
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (A_3 > 1U)
							{
								num4 = 5;
								continue;
							}
							goto IL_172;
						case 1:
							this.ag(A_0, A_3, ref num);
							this.ag(A_1, A_3, ref num2);
							this.ag(A_2, A_3, ref num3);
							num4 = 3;
							continue;
						case 2:
							goto IL_191;
						case 3:
							goto IL_172;
						case 4:
							if (num >= num2)
							{
								num4 = 9;
								continue;
							}
							return result;
						case 5:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_172;
							default:
								if (false)
								{
								}
								num4 = 11;
								continue;
							}
							break;
						case 6:
							num4 = 4;
							continue;
						case 7:
							goto IL_128;
						case 8:
							if (num2 > num3)
							{
								num4 = 2;
								continue;
							}
							num4 = 10;
							continue;
						case 9:
							result = true;
							num4 = 7;
							continue;
						case 10:
							if (num <= num3)
							{
								num4 = 6;
								continue;
							}
							return result;
						case 11:
							if (this.ag != null)
							{
								num4 = 1;
								continue;
							}
							goto IL_172;
						}
						break;
						IL_172:
						num4 = 8;
					}
				}
				IL_128:
				if (true)
				{
				}
				return result;
				IL_191:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2933U, base.GetType().ToString(), "ValueIsInRange", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				throw ex;
			}
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000143D0 File Offset: 0x000133D0
		private void a(string A_0, uint A_1, global::System.Collections.Hashtable A_2, ref global::System.Collections.ArrayList A_3)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						int num = 0;
						global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
						this.aa = global::IshHandler.e.a();
						global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
						int num2 = 4;
						for (;;)
						{
							int num3;
							int num4;
							int num7;
							switch (num2)
							{
							case 0:
								goto IL_3CC;
							case 1:
								goto IL_419;
							case 2:
								goto IL_42D;
							case 3:
								goto IL_5E8;
							case 4:
								goto IL_2AB;
							case 5:
								num2 = 2;
								continue;
							case 6:
							{
								string text;
								if (text.Length > 0)
								{
									num2 = 25;
									continue;
								}
								goto IL_419;
							}
							case 7:
								num2 = 36;
								continue;
							case 8:
							{
								string text2;
								byte b = this.a(text2);
								global::IshHandler.e.copyByteToBuff(this.aa, ref b, num3);
								num3++;
								num2 = 35;
								continue;
							}
							case 9:
							{
								if (num >= this.u.a.Count)
								{
									num2 = 16;
									continue;
								}
								arrayList.Clear();
								global::IshHandler.g g = (global::IshHandler.g)this.u.a[num];
								num4 = 0;
								int num5 = 0;
								num2 = 27;
								continue;
							}
							case 10:
								goto IL_42D;
							case 11:
							{
								string text;
								if (text.Length <= 2)
								{
									num2 = 19;
									continue;
								}
								string a_ = text.Substring(0, 2);
								byte b2 = this.a(a_);
								global::IshHandler.e.copyByteToBuff(this.aa, ref b2, num3);
								text = text.Substring(2, text.Length - 2);
								num3++;
								num2 = 17;
								continue;
							}
							case 12:
							{
								byte[] destination = new byte[num4];
								global::System.Runtime.InteropServices.Marshal.Copy(global::IshHandler.e.GetIshMemoryData(this.aa), destination, 0, num4);
								global::IshHandler.g g;
								arrayList2.Add(new global::IshHandler.m
								{
									c = destination,
									a = (ushort)g.b,
									b = (ushort)g.c
								});
								num++;
								num2 = 22;
								continue;
							}
							case 13:
							{
								int num6;
								if (num6 >= 4)
								{
									num2 = 5;
									continue;
								}
								string str = "0";
								string text2 = str + text2;
								num6++;
								num2 = 33;
								continue;
							}
							case 14:
								if (arrayList[num7].ToString().Equals("eqn(sum)"))
								{
									num2 = 20;
									continue;
								}
								goto IL_47E;
							case 15:
							{
								int num5;
								num5++;
								num2 = 18;
								continue;
							}
							case 16:
								A_3 = arrayList2;
								num2 = 37;
								continue;
							case 17:
								goto IL_47E;
							case 18:
								goto IL_4BA;
							case 19:
								num2 = 6;
								continue;
							case 20:
							{
								uint a_2 = 0U;
								int num8 = 0;
								global::IshHandler.e.GetCheckSum(this.aa, out a_2, (ulong)((long)num3));
								string text2 = this.a(a_2);
								int num6 = text2.Length;
								num2 = 0;
								continue;
							}
							case 21:
								goto IL_3EE;
							case 22:
								goto IL_2AB;
							case 23:
								this.a(arrayList2, A_0, A_1);
								num2 = 3;
								continue;
							case 24:
							{
								global::IshHandler.k k;
								if (!k.e.Equals("eqn(sum)"))
								{
									num2 = 15;
									continue;
								}
								goto IL_382;
							}
							case 25:
							{
								string text;
								byte b3 = this.a(text);
								global::IshHandler.e.copyByteToBuff(this.aa, ref b3, num3);
								num3++;
								num2 = 1;
								continue;
							}
							case 26:
								goto IL_3EE;
							case 27:
								goto IL_197;
							case 28:
							{
								global::IshHandler.g g;
								int num5;
								if (num5 >= g.d.Count)
								{
									num2 = 31;
									continue;
								}
								global::IshHandler.k k = (global::IshHandler.k)g.d[num5];
								string text3 = k.e;
								int num9 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num9 /= 8;
								num4 += num9;
								text3 = this.b(text3, num9);
								arrayList.Add(text3);
								num2 = 24;
								continue;
							}
							case 29:
								goto IL_5E8;
							case 30:
							{
								if (num7 >= arrayList.Count)
								{
									num2 = 12;
									continue;
								}
								string text = arrayList[num7].ToString();
								num2 = 14;
								continue;
							}
							case 31:
								goto IL_382;
							case 32:
								goto IL_5F4;
							case 33:
								goto IL_3CC;
							case 34:
							{
								string text2;
								if (text2.Length <= 2)
								{
									num2 = 7;
									continue;
								}
								string a_3 = text2.Substring(0, 2);
								byte b4 = this.a(a_3);
								int num8;
								num8++;
								global::IshHandler.e.copyByteToBuff(this.aa, ref b4, num3);
								text2 = text2.Substring(2, text2.Length - 2);
								num3++;
								num2 = 10;
								continue;
							}
							case 35:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_4BA;
								default:
									if (false)
									{
									}
									goto IL_419;
								}
								break;
							case 36:
							{
								string text2;
								if (text2.Length > 0)
								{
									num2 = 8;
									continue;
								}
								goto IL_419;
							}
							case 37:
								if (this.ae)
								{
									num2 = 23;
									continue;
								}
								this.a(arrayList2, A_0, A_1, A_2);
								num2 = 29;
								continue;
							}
							break;
							IL_197:
							num2 = 28;
							continue;
							IL_4BA:
							goto IL_197;
							IL_2AB:
							num2 = 9;
							continue;
							IL_382:
							num3 = 0;
							global::IshHandler.e.initByteToWrite(this.aa, (ulong)((long)num4));
							num7 = 0;
							num2 = 21;
							continue;
							IL_3CC:
							num2 = 13;
							continue;
							IL_3EE:
							num2 = 30;
							continue;
							IL_419:
							num7++;
							num2 = 26;
							continue;
							IL_42D:
							num2 = 34;
							continue;
							IL_47E:
							num2 = 11;
							continue;
							IL_5E8:
							num2 = 32;
						}
					}
					IL_5F4:
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
					ex.Source = 2926U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				throw;
			}
			finally
			{
				if (true)
				{
				}
				global::IshHandler.e.ReleaseIshMemory(this.aa);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00014A80 File Offset: 0x00013A80
		private string b(string A_0, int A_1)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return A_0;
				case 1:
					A_0 = A_0.PadRight(A_1 * 2, '0');
					num = 10;
					continue;
				case 2:
					A_0 = A_0.PadLeft(A_0.Length + 1, '0');
					num = 13;
					continue;
				case 3:
					return A_0;
				case 4:
					if (A_0.Length > A_1 * 2)
					{
						num = 18;
						continue;
					}
					return A_0;
				case 6:
					if (global::IshHandler.i.c == this.ai)
					{
						num = 11;
						continue;
					}
					A_0 = A_0.Substring(A_0.Length - A_1 * 2);
					num = 0;
					continue;
				case 7:
					if (A_0.Length % 2 != 0)
					{
						num = 2;
						continue;
					}
					goto IL_EA;
				case 8:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						if (global::IshHandler.i.c == this.ai)
						{
							num = 16;
							continue;
						}
						A_0 = A_0.PadLeft(A_1 * 2, '0');
						num = 3;
						continue;
					}
					break;
				case 9:
					return A_0;
				case 10:
					return A_0;
				case 11:
					num = 7;
					continue;
				case 12:
					if (A_0.Length < A_1 * 2)
					{
						num = 1;
						continue;
					}
					return A_0;
				case 13:
					goto IL_EA;
				case 14:
					A_0 = A_0.PadLeft(A_0.Length + 1, '0');
					num = 15;
					continue;
				case 15:
					goto IL_214;
				case 16:
					num = 17;
					continue;
				case 17:
					if (A_0.Length % 2 != 0)
					{
						num = 14;
						continue;
					}
					goto IL_214;
				case 18:
					num = 6;
					continue;
				case 19:
					num = 8;
					continue;
				}
				IL_60:
				if (A_0.Length < A_1 * 2)
				{
					num = 19;
					continue;
				}
				if (true)
				{
				}
				num = 4;
				continue;
				goto IL_60;
				IL_EA:
				A_0 = A_0.Substring(0, A_1 * 2);
				num = 9;
				continue;
				IL_214:
				num = 12;
			}
			return A_0;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00014CC8 File Offset: 0x00013CC8
		public void a(global::System.Collections.ArrayList A_0, string A_1, uint A_2, global::System.Collections.Hashtable A_3)
		{
			switch (0)
			{
			default:
				if (true)
				{
				}
				for (;;)
				{
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					global::System.Xml.XmlNode newChild = xmlDocument.CreateNode(global::System.Xml.XmlNodeType.XmlDeclaration, "", "");
					xmlDocument.AppendChild(newChild);
					global::System.Xml.XmlElement xmlElement = xmlDocument.CreateElement("", "root", "");
					global::System.Xml.XmlNode xmlNode = xmlDocument.CreateNode(global::System.Xml.XmlNodeType.Element, "Partition", "");
					global::System.Xml.XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("Type");
					xmlAttribute.Value = "FileSystem";
					xmlNode.Attributes.Append(xmlAttribute);
					string empty = string.Empty;
					ushort num = 0;
					ushort num2 = 0;
					int num3 = 0;
					this.b(A_2, out num3, out num, out num2, out empty);
					global::System.Collections.Hashtable hashtable = new global::System.Collections.Hashtable();
					global::System.Collections.IEnumerator enumerator = A_0.GetEnumerator();
					int num4 = 2;
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_2ED;
						case 1:
							goto IL_2DE;
						case 2:
							try
							{
								num4 = 6;
								for (;;)
								{
									switch (num4)
									{
									case 0:
										num4 = 3;
										continue;
									case 1:
										num4 = 4;
										continue;
									case 3:
									{
										global::IshHandler.m m;
										if (hashtable.Contains(m.a))
										{
											num4 = 11;
											continue;
										}
										global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
										arrayList.Add(m);
										hashtable.Add(m.a, arrayList);
										num4 = 10;
										continue;
									}
									case 4:
									{
										ushort num5;
										if (num5 <= num2)
										{
											num4 = 0;
											continue;
										}
										break;
									}
									case 5:
									{
										ushort num5;
										if (num5 >= num)
										{
											num4 = 1;
											continue;
										}
										break;
									}
									case 7:
										num4 = 9;
										continue;
									case 8:
									{
										if (!enumerator.MoveNext())
										{
											num4 = 7;
											continue;
										}
										global::IshHandler.m m = (global::IshHandler.m)enumerator.Current;
										ushort num5 = m.a;
										num5 = (ushort)((num5 >> 8 & 255) | ((int)num5 << 8 & 65280));
										num4 = 5;
										continue;
									}
									case 9:
										goto IL_290;
									case 11:
									{
										global::IshHandler.m m;
										global::System.Collections.ArrayList arrayList2 = (global::System.Collections.ArrayList)hashtable[m.a];
										arrayList2.Add(m);
										num4 = 2;
										continue;
									}
									}
									IL_16A:
									num4 = 8;
									continue;
									goto IL_16A;
								}
								IL_290:
								goto IL_878;
							}
							finally
							{
								for (;;)
								{
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									num4 = 0;
									for (;;)
									{
										switch (num4)
										{
										case 0:
											if (disposable != null)
											{
												num4 = 1;
												continue;
											}
											goto IL_2DD;
										case 1:
											disposable.Dispose();
											num4 = 2;
											continue;
										case 2:
											goto IL_2DB;
										}
										break;
									}
								}
								IL_2DB:
								IL_2DD:;
							}
							goto Block_2;
						}
						break;
						Block_3:
						global::System.Collections.IDictionaryEnumerator enumerator2;
						try
						{
							IL_2ED:
							num4 = 12;
							for (;;)
							{
								global::System.Collections.ArrayList arrayList3;
								string text2;
								global::System.Collections.IEnumerator enumerator3;
								int num7;
								int num10;
								switch (num4)
								{
								case 0:
									goto IL_7E5;
								case 1:
									goto IL_3A6;
								case 2:
								{
									bool flag = true;
									num4 = 9;
									continue;
								}
								case 3:
									goto IL_3A6;
								case 4:
								{
									if (!enumerator2.MoveNext())
									{
										num4 = 11;
										continue;
									}
									global::System.Collections.DictionaryEntry dictionaryEntry = (global::System.Collections.DictionaryEntry)enumerator2.Current;
									arrayList3 = (global::System.Collections.ArrayList)dictionaryEntry.Value;
									ushort num6 = (ushort)dictionaryEntry.Key;
									global::System.Xml.XmlNode xmlNode2 = xmlDocument.CreateNode(global::System.Xml.XmlNodeType.Element, "Payload", "");
									xmlAttribute = xmlDocument.CreateAttribute("ID");
									xmlAttribute.Value = num3.ToString("X2", global::System.Globalization.CultureInfo.InvariantCulture);
									xmlNode2.Attributes.Append(xmlAttribute);
									xmlAttribute = xmlDocument.CreateAttribute("OptionFlags");
									xmlAttribute.Value = 1.ToString("X8", global::System.Globalization.CultureInfo.InvariantCulture);
									xmlNode2.Attributes.Append(xmlAttribute);
									xmlAttribute = xmlDocument.CreateAttribute("Path");
									string text = num6.ToString("X4", global::System.Globalization.CultureInfo.InvariantCulture);
									text = text.Substring(2, 2) + text.Substring(0, 2);
									xmlAttribute.Value = empty + text + ".cpg";
									xmlNode2.Attributes.Append(xmlAttribute);
									text2 = string.Empty;
									text2 += 0.ToString("X8", global::System.Globalization.CultureInfo.InvariantCulture);
									bool flag = false;
									num4 = 6;
									continue;
								}
								case 5:
								{
									try
									{
										num4 = 4;
										for (;;)
										{
											global::IshHandler.m m2;
											switch (num4)
											{
											case 1:
											{
												if (!enumerator3.MoveNext())
												{
													num4 = 3;
													continue;
												}
												m2 = (global::IshHandler.m)enumerator3.Current;
												num7++;
												string str = text2;
												ushort num8 = m2.b;
												text2 = str + num8.ToString("X4", global::System.Globalization.CultureInfo.InvariantCulture);
												int num9 = (int)m2.b;
												num9 = ((num9 >> 8 & 255) | (num9 << 8 & 65280));
												num4 = 7;
												continue;
											}
											case 2:
												goto IL_528;
											case 3:
												num4 = 5;
												continue;
											case 5:
												goto IL_5BE;
											case 6:
											{
												int num9;
												this.a(ref text2, num9, num7);
												num4 = 2;
												continue;
											}
											case 7:
											{
												bool flag;
												if (flag)
												{
													num4 = 6;
													continue;
												}
												goto IL_528;
											}
											}
											IL_4FF:
											num4 = 1;
											continue;
											goto IL_4FF;
											IL_528:
											string text3 = m2.c.Length.ToString("X4", global::System.Globalization.CultureInfo.InvariantCulture);
											text3 = text3.Substring(2, 2) + text3.Substring(0, 2);
											text2 += text3;
											text2 += 0.ToString("X8", global::System.Globalization.CultureInfo.InvariantCulture);
											string str2 = this.b(m2.c);
											text2 += str2;
											num4 = 0;
										}
										IL_5BE:
										goto IL_78D;
									}
									finally
									{
										for (;;)
										{
											global::System.IDisposable disposable2 = enumerator3 as global::System.IDisposable;
											num4 = 0;
											for (;;)
											{
												switch (num4)
												{
												case 0:
													if (disposable2 != null)
													{
														num4 = 1;
														continue;
													}
													goto IL_60B;
												case 1:
													disposable2.Dispose();
													num4 = 2;
													continue;
												case 2:
													goto IL_609;
												}
												break;
											}
										}
										IL_609:
										IL_60B:;
									}
									goto IL_60C;
									IL_78D:
									global::System.Xml.XmlNode xmlNode2;
									xmlNode2.InnerText = text2;
									xmlAttribute = xmlDocument.CreateAttribute("MD5_CheckSUM");
									byte[] a_ = this.d(text2);
									xmlAttribute.Value = this.a(a_);
									xmlNode2.Attributes.Append(xmlAttribute);
									xmlNode.AppendChild(xmlNode2);
									num4 = 8;
									continue;
								}
								case 6:
								{
									ushort num6;
									if (A_3.ContainsKey(num6))
									{
										num4 = 13;
										continue;
									}
									text2 += "0000";
									text2 += "0100";
									bool flag = false;
									num4 = 0;
									continue;
								}
								case 7:
									goto IL_80E;
								case 9:
									goto IL_7E5;
								case 10:
								{
									int num11;
									if (num10 >= num11)
									{
										num4 = 2;
										continue;
									}
									goto IL_60C;
								}
								case 11:
									num4 = 7;
									continue;
								case 13:
								{
									text2 += "0100";
									ushort num6;
									int num11 = (int)global::System.Convert.ToInt16(A_3[num6], global::System.Globalization.CultureInfo.InvariantCulture);
									int num12 = (num11 >> 8 & 255) | (num11 << 8 & 65280);
									text2 += num12.ToString("X4", global::System.Globalization.CultureInfo.InvariantCulture);
									num10 = 0;
									num4 = 1;
									continue;
								}
								}
								goto IL_337;
								IL_3A6:
								num4 = 10;
								continue;
								IL_3C9:
								num4 = 4;
								continue;
								IL_337:
								goto IL_3C9;
								IL_60C:
								text2 += "0000";
								num10++;
								num4 = 3;
								continue;
								IL_7E5:
								num7 = 0;
								enumerator3 = arrayList3.GetEnumerator();
								num4 = 5;
							}
							IL_80E:
							goto IL_E1;
						}
						finally
						{
							for (;;)
							{
								global::System.IDisposable disposable3 = enumerator2 as global::System.IDisposable;
								num4 = 1;
								for (;;)
								{
									switch (num4)
									{
									case 0:
										goto IL_85B;
									case 1:
										if (disposable3 != null)
										{
											num4 = 2;
											continue;
										}
										goto IL_85B;
									case 2:
										disposable3.Dispose();
										num4 = 0;
										continue;
									}
									break;
									IL_85B:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_871;
									}
								}
							}
							IL_871:
							if (false)
							{
							}
						}
						goto IL_878;
						IL_E1:
						xmlElement.AppendChild(xmlNode);
						xmlDocument.AppendChild(xmlElement);
						hashtable.Clear();
						num4 = 1;
						continue;
						Block_2:
						try
						{
							IL_2DE:
							xmlDocument.Save(A_1);
							return;
						}
						catch (global::System.Exception)
						{
							throw;
						}
						goto Block_3;
						IL_878:
						enumerator2 = hashtable.GetEnumerator();
						num4 = 0;
					}
				}
				return;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000155CC File Offset: 0x000145CC
		public void a(global::System.Collections.ArrayList A_0, string A_1, uint A_2)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					global::System.Xml.XmlNode newChild = xmlDocument.CreateNode(global::System.Xml.XmlNodeType.XmlDeclaration, "", "");
					xmlDocument.AppendChild(newChild);
					global::System.Xml.XmlElement xmlElement = xmlDocument.CreateElement("", "root", "");
					global::System.Xml.XmlNode xmlNode = xmlDocument.CreateNode(global::System.Xml.XmlNodeType.Element, "Partition", "");
					global::System.Xml.XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("Type");
					xmlAttribute.Value = "FileSystem";
					xmlNode.Attributes.Append(xmlAttribute);
					string empty = string.Empty;
					ushort num = 0;
					ushort num2 = 0;
					int num3 = 0;
					this.a(A_2, out num3, out num, out num2, out empty);
					string tempFileName = global::System.IO.Path.GetTempFileName();
					string text = tempFileName;
					int num4 = 1;
					for (;;)
					{
						global::System.Data.SQLite.SQLiteConnection sqliteConnection;
						byte[] array;
						switch (num4)
						{
						case 0:
							if (global::System.IO.File.Exists(tempFileName))
							{
								num4 = 5;
								continue;
							}
							goto IL_492;
						case 1:
							try
							{
								global::System.Data.SQLite.SQLiteConnection.CreateFile(text);
								goto IL_160;
							}
							catch (global::System.Exception)
							{
								throw;
							}
							return;
						case 2:
							goto IL_492;
						case 3:
						{
							try
							{
								sqliteConnection.ConnectionString = new global::System.Data.SQLite.SQLiteConnectionStringBuilder
								{
									DataSource = text
								}.ToString();
								sqliteConnection.Open();
								global::System.Data.SQLite.SQLiteCommand sqliteCommand = new global::System.Data.SQLite.SQLiteCommand();
								try
								{
									string commandText = "CREATE TABLE CPTABLE (ITEMNAME BLOB, ITEMVALUE BLOB);";
									sqliteCommand.CommandText = commandText;
									sqliteCommand.Connection = sqliteConnection;
									sqliteCommand.ExecuteNonQuery();
									global::System.Collections.IEnumerator enumerator = A_0.GetEnumerator();
									try
									{
										num4 = 0;
										for (;;)
										{
											switch (num4)
											{
											case 1:
											{
												ushort num5;
												if (num5 <= num2)
												{
													num4 = 4;
													continue;
												}
												break;
											}
											case 2:
											{
												ushort num5;
												if (num5 >= num)
												{
													switch ((1 == 1) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_3C0;
													default:
														if (false)
														{
														}
														num4 = 8;
														continue;
													}
												}
												break;
											}
											case 3:
												num4 = 7;
												continue;
											case 4:
											{
												global::IshHandler.m m;
												int num6 = ((int)m.a << 16) + (int)m.b;
												commandText = "INSERT INTO CPTABLE (ITEMNAME, ITEMVALUE) VALUES (@ITEMNAME, @ITEMVALUE)";
												sqliteCommand.Parameters.Add("ITEMNAME", global::System.Data.DbType.Int32).Value = num6;
												sqliteCommand.Parameters.Add("ITEMVALUE", global::System.Data.DbType.Binary).Value = m.c;
												sqliteCommand.CommandText = commandText;
												sqliteCommand.ExecuteNonQuery();
												num4 = 5;
												continue;
											}
											case 6:
											{
												if (!enumerator.MoveNext())
												{
													num4 = 3;
													continue;
												}
												global::IshHandler.m m = (global::IshHandler.m)enumerator.Current;
												ushort num5 = m.a;
												ushort num7 = m.b;
												num5 = (ushort)((int)(num5 & 255) << 8 | (num5 & 65280) >> 8);
												num7 = (ushort)((int)(num7 & 255) << 8 | (num7 & 65280) >> 8);
												num4 = 2;
												continue;
											}
											case 7:
												goto IL_3C0;
											case 8:
												num4 = 1;
												continue;
											}
											IL_268:
											num4 = 6;
											continue;
											goto IL_268;
										}
										IL_3C0:;
									}
									finally
									{
										for (;;)
										{
											global::System.IDisposable disposable = enumerator as global::System.IDisposable;
											num4 = 2;
											for (;;)
											{
												switch (num4)
												{
												case 0:
													disposable.Dispose();
													num4 = 1;
													continue;
												case 1:
													goto IL_408;
												case 2:
													if (disposable != null)
													{
														num4 = 0;
														continue;
													}
													goto IL_40A;
												}
												break;
											}
										}
										IL_408:
										IL_40A:;
									}
								}
								finally
								{
									num4 = 2;
									for (;;)
									{
										switch (num4)
										{
										case 0:
											goto IL_44A;
										case 1:
											((global::System.IDisposable)sqliteCommand).Dispose();
											num4 = 0;
											continue;
										}
										if (sqliteCommand == null)
										{
											break;
										}
										num4 = 1;
									}
									IL_44A:;
								}
								goto IL_1B5;
							}
							finally
							{
								num4 = 0;
								for (;;)
								{
									switch (num4)
									{
									case 1:
										((global::System.IDisposable)sqliteConnection).Dispose();
										num4 = 2;
										continue;
									case 2:
										goto IL_48F;
									}
									if (sqliteConnection == null)
									{
										break;
									}
									num4 = 1;
								}
								IL_48F:;
							}
							goto IL_492;
							IL_1B5:
							array = null;
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(tempFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
							num4 = 4;
							continue;
						}
						case 4:
							try
							{
								global::System.IO.FileStream fileStream;
								array = new byte[fileStream.Length];
								fileStream.Read(array, 0, array.Length);
								goto IL_184;
							}
							finally
							{
								num4 = 0;
								for (;;)
								{
									global::System.IO.FileStream fileStream;
									switch (num4)
									{
									case 1:
										goto IL_15D;
									case 2:
										((global::System.IDisposable)fileStream).Dispose();
										num4 = 1;
										continue;
									}
									if (fileStream == null)
									{
										break;
									}
									num4 = 2;
								}
								IL_15D:;
							}
							goto IL_160;
						case 5:
							global::System.IO.File.Delete(tempFileName);
							num4 = 2;
							continue;
						case 6:
							try
							{
								xmlDocument.Save(A_1);
								return;
							}
							catch (global::System.Exception)
							{
								throw;
							}
							goto IL_184;
						}
						break;
						IL_160:
						sqliteConnection = new global::System.Data.SQLite.SQLiteConnection();
						num4 = 3;
						continue;
						IL_184:
						if (true)
						{
						}
						num4 = 0;
						continue;
						IL_492:
						string text2 = this.b(array);
						global::System.Xml.XmlNode xmlNode2 = xmlDocument.CreateNode(global::System.Xml.XmlNodeType.Element, "Payload", "");
						xmlAttribute = xmlDocument.CreateAttribute("ID");
						xmlAttribute.Value = num3.ToString("X2", global::System.Globalization.CultureInfo.InvariantCulture);
						xmlNode2.Attributes.Append(xmlAttribute);
						xmlAttribute = xmlDocument.CreateAttribute("OptionFlags");
						xmlAttribute.Value = 1.ToString("X8", global::System.Globalization.CultureInfo.InvariantCulture);
						xmlNode2.Attributes.Append(xmlAttribute);
						xmlAttribute = xmlDocument.CreateAttribute("Path");
						xmlAttribute.Value = global::System.IO.Path.Combine("C:\\upgrade\\codeplug\\", global::System.IO.Path.GetFileName(empty));
						xmlNode2.Attributes.Append(xmlAttribute);
						xmlNode2.InnerText = text2;
						xmlAttribute = xmlDocument.CreateAttribute("MD5_CheckSUM");
						byte[] a_ = this.d(text2);
						xmlAttribute.Value = this.a(a_);
						xmlNode2.Attributes.Append(xmlAttribute);
						xmlNode.AppendChild(xmlNode2);
						xmlElement.AppendChild(xmlNode);
						xmlDocument.AppendChild(xmlElement);
						num4 = 6;
					}
				}
				return;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00015C34 File Offset: 0x00014C34
		private void a(ref string A_0, int A_1, int A_2)
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
			int num = 0;
			num += 8;
			num += 4;
			num += 4;
			num += A_1 * 4;
			A_2 = ((A_2 >> 8 & 255) | (A_2 << 8 & 65280));
			string text = A_2.ToString("X4", global::System.Globalization.CultureInfo.InvariantCulture);
			A_0 = A_0.Substring(0, num) + text + A_0.Substring(num + text.Length);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00015CCC File Offset: 0x00014CCC
		public void a(uint A_0, byte[] A_1, ref global::System.Collections.ArrayList A_2)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Collections.ArrayList arrayList = A_2;
					int num = A_1.Length;
					int i = 0;
					i += 4;
					uint num2 = (uint)((int)A_1[i] | (int)A_1[i + 1] << 8);
					short num3 = global::System.Convert.ToInt16("0100", 16);
					num3 = (short)(((int)num3 << 8 & 65280) | (num3 >> 8 & 255));
					i += 2;
					int num4 = 5;
					for (;;)
					{
						IL_10:
						switch (num4)
						{
						case 0:
							return;
						case 1:
							goto IL_184;
						case 2:
							goto IL_184;
						case 3:
							goto IL_184;
						case 4:
							while (i < num)
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
									uint num5 = (uint)((int)A_1[i] << 8 | (int)A_1[i + 1]);
									i += 2;
									global::IshHandler.m m = default(global::IshHandler.m);
									m.b = (ushort)num5;
									m.a = (ushort)A_0;
									uint num6 = (uint)((int)A_1[i] | (int)A_1[i + 1] << 8);
									i += 2;
									i += 4;
									byte[] destinationArray = new byte[num6];
									global::System.Array.Copy(A_1, (long)i, destinationArray, 0L, (long)((ulong)num6));
									m.c = destinationArray;
									i += (int)num6;
									arrayList.Add(m);
									if (true)
									{
									}
									num4 = 2;
									goto IL_10;
								}
								}
							}
							num4 = 0;
							continue;
						case 5:
							if ((ulong)num2 == (ulong)((long)num3))
							{
								num4 = 6;
								continue;
							}
							i += 2;
							num4 = 3;
							continue;
						case 6:
						{
							uint num7 = (uint)((int)A_1[i] | (int)A_1[i + 1] << 8);
							i += 2;
							i += (int)(num7 * 2U);
							num4 = 1;
							continue;
						}
						}
						break;
						IL_184:
						num4 = 4;
					}
				}
				return;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00015E80 File Offset: 0x00014E80
		public void a(string A_0, ref global::System.Collections.ArrayList A_1)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				global::System.Data.DataTable dataTable = new global::System.Data.DataTable();
				try
				{
					try
					{
						global::System.Data.SQLite.SQLiteConnection sqliteConnection = new global::System.Data.SQLite.SQLiteConnection("Data Source=" + A_0 + ";Version=3;");
						try
						{
							sqliteConnection.Open();
							global::System.Data.SQLite.SQLiteCommand sqliteCommand = sqliteConnection.CreateCommand();
							sqliteCommand.CommandText = "select * from CPTABLE";
							global::System.Data.SQLite.SQLiteDataAdapter sqliteDataAdapter = new global::System.Data.SQLite.SQLiteDataAdapter(sqliteCommand);
							sqliteDataAdapter.Fill(dataTable);
						}
						finally
						{
							int num = 0;
							for (;;)
							{
								switch (num)
								{
								case 1:
									((global::System.IDisposable)sqliteConnection).Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_9A;
								}
								if (sqliteConnection == null)
								{
									break;
								}
								num = 1;
							}
							IL_9A:;
						}
					}
					catch
					{
						global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1048U, base.GetType().ToString(), "FormatISHSqliteData", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
						throw ex;
					}
					global::System.Collections.IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					try
					{
						int num = 3;
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = 4;
									continue;
								}
								global::System.Data.DataRow dataRow = (global::System.Data.DataRow)enumerator.Current;
								global::IshHandler.m m = default(global::IshHandler.m);
								m.c = (byte[])dataRow["ITEMVALUE"];
								long num2 = long.Parse(global::System.Text.Encoding.UTF8.GetString((byte[])dataRow["ITEMNAME"]));
								num2 &= (long)((ulong)-1);
								m.a = (ushort)(num2 >> 16);
								m.b = (ushort)(num2 & 65535L);
								A_1.Add(m);
								num = 1;
								continue;
							}
							case 2:
								goto IL_1CC;
							case 4:
								num = 2;
								continue;
							}
							IL_19A:
							num = 0;
							continue;
							goto IL_19A;
						}
						IL_1CC:;
					}
					finally
					{
						for (;;)
						{
							global::System.IDisposable disposable;
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								if (false)
								{
								}
								disposable = (enumerator as global::System.IDisposable);
								break;
							}
							int num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_230;
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
									goto IL_232;
								}
								break;
							}
						}
						IL_230:
						IL_232:;
					}
				}
				finally
				{
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							((global::System.IDisposable)dataTable).Dispose();
							num = 1;
							continue;
						case 1:
							goto IL_270;
						}
						if (dataTable == null)
						{
							break;
						}
						num = 0;
					}
					IL_270:;
				}
				return;
			}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00016170 File Offset: 0x00015170
		private void b(uint A_0, out int A_1, out ushort A_2, out ushort A_3, out string A_4)
		{
			switch (0)
			{
			default:
			{
				ushort num;
				ushort num2;
				string text;
				int num3;
				for (;;)
				{
					num = 0;
					num2 = 0;
					text = string.Empty;
					num3 = 0;
					int num4 = 1;
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num4 = 3;
							continue;
						case 1:
							switch (A_0)
							{
							case 0U:
								num3 = 51;
								num = 4100;
								num2 = 4199;
								text = "/opt/pcr/rel/data/codeplug/app_security/";
								num4 = 2;
								continue;
							case 1U:
								num3 = 51;
								num = 1;
								num2 = 4099;
								text = "/opt/pcr/rel/data/codeplug/app_codeplug/";
								num4 = 4;
								continue;
							case 2U:
								num3 = 50;
								num = 4200;
								num2 = 4399;
								text = "/opt/pcr/rel/data/tuning/app_tuning/";
								if (true)
								{
								}
								num4 = 6;
								continue;
							case 3U:
								num3 = 51;
								num = 4400;
								num2 = 4499;
								text = "/opt/pcr/rel/data/codeplug/app_features/";
								num4 = 5;
								continue;
							default:
								num4 = 0;
								continue;
							}
							break;
						case 2:
							goto IL_8F;
						case 3:
							goto IL_E6;
						case 4:
							goto IL_130;
						case 5:
							goto IL_D8;
						case 6:
							goto IL_111;
						}
						break;
					}
				}
				IL_8F:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_111:
					break;
				default:
					if (false)
					{
					}
					break;
				}
				IL_D8:
				IL_E6:
				IL_130:
				A_2 = num;
				A_3 = num2;
				A_4 = text;
				A_1 = num3;
				return;
			}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000162C0 File Offset: 0x000152C0
		private void a(uint A_0, out int A_1, out ushort A_2, out ushort A_3, out string A_4)
		{
			switch (0)
			{
			default:
			{
				ushort num;
				ushort num2;
				string text;
				int num3;
				for (;;)
				{
					num = 0;
					num2 = 0;
					text = string.Empty;
					num3 = 0;
					int num4 = 5;
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num4 = 4;
							continue;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_10B;
							default:
								goto IL_D8;
							}
							break;
						case 2:
							goto IL_117;
						case 3:
							goto IL_9C;
						case 4:
							goto IL_EC;
						case 5:
							switch (A_0)
							{
							case 0U:
								num3 = 51;
								num = 4100;
								num2 = 4199;
								text = "B:\\activexx\\codeplug\\sec_cpg.db";
								num4 = 3;
								continue;
							case 1U:
								num3 = 51;
								num = 1;
								num2 = 4099;
								text = "B:\\activexx\\codeplug\\app_cpg.db";
								num4 = 6;
								continue;
							case 2U:
								if (true)
								{
								}
								num3 = 51;
								num = 4200;
								num2 = 4399;
								text = "B:\\activexx\\codeplug\\tuning_cpg.db";
								goto IL_10B;
							case 3U:
								num3 = 51;
								num = 4400;
								num2 = 4499;
								text = "B:\\activexx\\codeplug\\cfs_cpg.db";
								num4 = 1;
								continue;
							default:
								num4 = 0;
								continue;
							}
							break;
						case 6:
							goto IL_136;
						}
						break;
						IL_10B:
						num4 = 2;
					}
				}
				IL_9C:
				goto IL_138;
				IL_D8:
				if (false)
				{
				}
				IL_EC:
				IL_117:
				IL_136:
				IL_138:
				A_2 = num;
				A_3 = num2;
				A_4 = text;
				A_1 = num3;
				return;
			}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00016414 File Offset: 0x00015414
		public string e(string A_0)
		{
			string result;
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
				global::System.Security.Cryptography.MD5CryptoServiceProvider md5CryptoServiceProvider = new global::System.Security.Cryptography.MD5CryptoServiceProvider();
				try
				{
					string text = global::System.BitConverter.ToString(md5CryptoServiceProvider.ComputeHash(global::System.Text.Encoding.UTF8.GetBytes(A_0)));
					text = text.Replace("-", "");
					result = text.ToLowerInvariant();
				}
				finally
				{
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							((global::System.IDisposable)md5CryptoServiceProvider).Dispose();
							num = 1;
							continue;
						case 1:
							goto IL_9E;
						}
						if (md5CryptoServiceProvider == null)
						{
							break;
						}
						num = 0;
					}
					IL_9E:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000164D4 File Offset: 0x000154D4
		public string a(byte[] A_0)
		{
			global::System.Security.Cryptography.MD5CryptoServiceProvider md5CryptoServiceProvider = new global::System.Security.Cryptography.MD5CryptoServiceProvider();
			string result;
			try
			{
				if (true)
				{
				}
				string text = global::System.BitConverter.ToString(md5CryptoServiceProvider.ComputeHash(A_0));
				text = text.Replace("-", "");
				result = text.ToLowerInvariant();
			}
			finally
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						((global::System.IDisposable)md5CryptoServiceProvider).Dispose();
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8A;
						default:
							if (false)
							{
							}
							num = 2;
							continue;
						}
						break;
					case 2:
						goto IL_8A;
					}
					if (md5CryptoServiceProvider == null)
					{
						break;
					}
					num = 1;
				}
				IL_8A:;
			}
			return result;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0001658C File Offset: 0x0001558C
		public global::System.Collections.ArrayList a(string A_0, ref global::System.Collections.Hashtable A_1)
		{
			global::System.Collections.ArrayList result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				default:
					for (;;)
					{
						if (true)
						{
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						}
						if (false)
						{
						}
						result = new global::System.Collections.ArrayList();
						int num = 1;
						for (;;)
						{
							global::System.Collections.IEnumerator enumerator;
							switch (num)
							{
							case 0:
								A_1 = new global::System.Collections.Hashtable();
								num = 2;
								continue;
							case 1:
								if (A_1 == null)
								{
									num = 0;
									continue;
								}
								goto IL_263;
							case 2:
								goto IL_263;
							case 3:
								try
								{
									num = 4;
									for (;;)
									{
										byte[] array;
										ushort num4;
										switch (num)
										{
										case 0:
										{
											int num3;
											uint num2 = (uint)((int)array[num3] | (int)array[num3 + 1] << 8);
											A_1.Add(num4, num2);
											num = 3;
											continue;
										}
										case 1:
										{
											if (!enumerator.MoveNext())
											{
												num = 5;
												continue;
											}
											global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
											string value = xmlNode.Attributes.GetNamedItem("Path").Value;
											string text = xmlNode.InnerText;
											text = text.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
											array = this.d(text);
											string value2 = this.f(value);
											num4 = (ushort)global::System.Convert.ToInt16(value2, 16);
											int num3 = 0;
											num3 += 4;
											uint num5 = (uint)((int)array[num3] | (int)array[num3 + 1] << 8);
											short num6 = global::System.Convert.ToInt16("0100", 16);
											num6 = (short)(((int)num6 << 8 & 65280) | (num6 >> 8 & 255));
											num3 += 2;
											num = 6;
											continue;
										}
										case 2:
											goto IL_215;
										case 3:
											goto IL_1BB;
										case 5:
											num = 2;
											continue;
										case 6:
										{
											uint num5;
											short num6;
											if ((ulong)num5 == (ulong)((long)num6))
											{
												num = 0;
												continue;
											}
											goto IL_1BB;
										}
										}
										IL_195:
										num = 1;
										continue;
										goto IL_195;
										IL_1BB:
										this.a((uint)num4, array, ref result);
										num = 7;
									}
									IL_215:
									return result;
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
												goto IL_260;
											case 1:
												if (disposable != null)
												{
													num = 2;
													continue;
												}
												goto IL_262;
											case 2:
												disposable.Dispose();
												num = 0;
												continue;
											}
											break;
										}
									}
									IL_260:
									IL_262:;
								}
								goto IL_263;
							}
							break;
							IL_263:
							global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
							xmlDocument.Load(A_0);
							global::System.Xml.XmlNodeList xmlNodeList = xmlDocument.DocumentElement.SelectNodes("//Partition[@Type='FileSystem']/Payload");
							enumerator = xmlNodeList.GetEnumerator();
							num = 3;
						}
					}
					break;
				}
			}
			return result;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00016868 File Offset: 0x00015868
		public byte[] d(string A_0)
		{
			byte[] array;
			for (;;)
			{
				int num = A_0.Length / 2;
				array = new byte[num];
				int i = 0;
				int num2 = 1;
				for (;;)
				{
					IL_02:
					switch (num2)
					{
					case 0:
						while (i < num)
						{
							array[i] = global::System.Convert.ToByte(A_0.Substring(i * 2, 2), 16);
							i++;
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
								num2 = 2;
								goto IL_02;
							}
						}
						num2 = 3;
						continue;
					case 1:
						goto IL_34;
					case 2:
						goto IL_34;
					case 3:
						return array;
					}
					break;
					IL_34:
					num2 = 0;
				}
			}
			return array;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00016914 File Offset: 0x00015914
		public string b(byte[] A_0)
		{
			string text;
			for (;;)
			{
				text = string.Empty;
				int num = A_0.Length;
				int num2 = 0;
				int num3 = 2;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_2E;
					case 1:
						if (true)
						{
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2E;
						default:
							goto IL_97;
						}
						break;
					case 2:
						goto IL_2E;
					case 3:
						if (num2 >= num)
						{
							num3 = 1;
							continue;
						}
						text += A_0[num2].ToString("X2", global::System.Globalization.CultureInfo.InvariantCulture);
						num2++;
						num3 = 0;
						continue;
					}
					break;
					IL_2E:
					num3 = 3;
				}
			}
			IL_97:
			if (false)
			{
			}
			return text;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000169C0 File Offset: 0x000159C0
		public string f(string A_0)
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
			string text = string.Empty;
			int num = A_0.LastIndexOf('.');
			int num2 = A_0.LastIndexOf('/');
			text = A_0.Substring(num2 + 1, num - (num2 + 1));
			return text.Substring(2, 2) + text.Substring(0, 2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00016A3C File Offset: 0x00015A3C
		private void a()
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						int num = 0;
						global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
						int num2 = 19;
						for (;;)
						{
							int num3;
							int num7;
							int num8;
							string text3;
							switch (num2)
							{
							case 0:
								num2 = 30;
								continue;
							case 1:
								goto IL_373;
							case 2:
								num2 = 33;
								continue;
							case 3:
							{
								string text;
								byte b = this.a(text);
								global::IshHandler.e.copyByteToBuff(this.aa, ref b, num3);
								num3++;
								num2 = 18;
								continue;
							}
							case 4:
							{
								int num4;
								num4++;
								num2 = 17;
								continue;
							}
							case 5:
							{
								uint a_ = 0U;
								int num5 = 0;
								global::IshHandler.e.GetCheckSum(this.aa, out a_, (ulong)((long)num3));
								string text = this.a(a_);
								int num6 = text.Length;
								num2 = 35;
								continue;
							}
							case 6:
							{
								if (num >= this.u.a.Count)
								{
									num2 = 0;
									continue;
								}
								arrayList.Clear();
								global::IshHandler.g g = (global::IshHandler.g)this.u.a[num];
								num7 = 0;
								int num4 = 0;
								num2 = 27;
								continue;
							}
							case 7:
							{
								string text2;
								if (text2.Length > 0)
								{
									num2 = 8;
									continue;
								}
								goto IL_219;
							}
							case 8:
							{
								string text2;
								byte b2 = this.a(text2);
								global::IshHandler.e.copyByteToBuff(this.aa, ref b2, num3);
								num3++;
								num2 = 16;
								continue;
							}
							case 9:
							{
								string text;
								if (text.Length <= 2)
								{
									num2 = 26;
									continue;
								}
								string a_2 = text.Substring(0, 2);
								byte b3 = this.a(a_2);
								int num5;
								num5++;
								global::IshHandler.e.copyByteToBuff(this.aa, ref b3, num3);
								text = text.Substring(2, text.Length - 2);
								num3++;
								num2 = 15;
								continue;
							}
							case 10:
								goto IL_4AA;
							case 11:
							{
								if (num8 >= arrayList.Count)
								{
									num2 = 20;
									continue;
								}
								string text2 = arrayList[num8].ToString();
								num2 = 36;
								continue;
							}
							case 12:
							{
								int num9;
								if (text3.Length < num9 * 2)
								{
									num2 = 21;
									continue;
								}
								goto IL_2D7;
							}
							case 13:
							{
								string text2;
								if (text2.Length <= 2)
								{
									num2 = 25;
									continue;
								}
								string a_3 = text2.Substring(0, 2);
								byte b4 = this.a(a_3);
								global::IshHandler.e.copyByteToBuff(this.aa, ref b4, num3);
								text2 = text2.Substring(2, text2.Length - 2);
								num3++;
								num2 = 1;
								continue;
							}
							case 14:
								goto IL_1F5;
							case 15:
								goto IL_1CB;
							case 16:
								goto IL_219;
							case 17:
								goto IL_C8;
							case 18:
								goto IL_219;
							case 19:
								goto IL_230;
							case 20:
							{
								global::IshHandler.g g;
								global::IshHandler.e.WriteISH(this.z, this.aa, (ushort)g.b, (ushort)g.c, (ulong)((long)num7));
								num++;
								num2 = 34;
								continue;
							}
							case 21:
							{
								int num9;
								text3 = text3.PadLeft(num9 * 2, '0');
								num2 = 24;
								continue;
							}
							case 22:
							{
								int num4;
								global::IshHandler.g g;
								if (num4 >= g.d.Count)
								{
									num2 = 14;
									continue;
								}
								global::IshHandler.k k = (global::IshHandler.k)g.d[num4];
								text3 = k.e;
								int num9 = int.Parse(k.b, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture);
								num9 /= 8;
								num7 += num9;
								num2 = 12;
								continue;
							}
							case 23:
							{
								string text;
								if (text.Length > 0)
								{
									num2 = 3;
									continue;
								}
								goto IL_219;
							}
							case 24:
								goto IL_2D7;
							case 25:
								num2 = 7;
								continue;
							case 26:
								num2 = 23;
								continue;
							case 27:
								goto IL_C8;
							case 28:
								goto IL_3AB;
							case 29:
							{
								global::IshHandler.k k;
								if (!k.e.Equals("eqn(sum)"))
								{
									num2 = 4;
									continue;
								}
								goto IL_1F5;
							}
							case 30:
								goto IL_565;
							case 31:
								goto IL_4AA;
							case 32:
							{
								int num6;
								if (num6 >= 4)
								{
									num2 = 2;
									continue;
								}
								string str = "0";
								string text = str + text;
								num6++;
								num2 = 28;
								continue;
							}
							case 33:
								goto IL_1CB;
							case 34:
								goto IL_230;
							case 35:
								goto IL_3AB;
							case 36:
								if (arrayList[num8].ToString().Equals("eqn(sum)"))
								{
									num2 = 5;
									continue;
								}
								goto IL_373;
							}
							break;
							IL_C8:
							num2 = 22;
							continue;
							IL_1CB:
							num2 = 9;
							continue;
							IL_1F5:
							num3 = 0;
							global::IshHandler.e.initByteToWrite(this.aa, (ulong)((long)num7));
							num8 = 0;
							num2 = 31;
							continue;
							IL_219:
							num8++;
							num2 = 10;
							continue;
							IL_230:
							num2 = 6;
							continue;
							IL_2D7:
							arrayList.Add(text3);
							num2 = 29;
							continue;
							IL_373:
							num2 = 13;
							continue;
							IL_3AB:
							num2 = 32;
							continue;
							IL_4AA:
							num2 = 11;
						}
					}
					IL_565:
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
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						ex.Source = 2926U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
						break;
					}
				}
				throw;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00017054 File Offset: 0x00016054
		private string a(int A_0, int A_1)
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
			return global::System.Convert.ToString(A_0, A_1).ToUpperInvariant();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0001709C File Offset: 0x0001609C
		private int a(string A_0, int A_1)
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
			return global::System.Convert.ToInt32(A_0, A_1);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000170E0 File Offset: 0x000160E0
		private string a(uint A_0)
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
			return global::System.Convert.ToString((long)((ulong)A_0), 16).ToUpperInvariant();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0001712C File Offset: 0x0001612C
		private uint b(string A_0)
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
			return global::System.Convert.ToUInt32(A_0.ToUpperInvariant(), 16);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00017174 File Offset: 0x00016174
		private byte a(string A_0)
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
			return global::System.Convert.ToByte(A_0, 16);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000171B8 File Offset: 0x000161B8
		public void h()
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
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00017200 File Offset: 0x00016200
		protected virtual void a(bool A_0)
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
					this.z = global::System.IntPtr.Zero;
					this.aa = global::System.IntPtr.Zero;
					this.af = true;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						if (false)
						{
						}
						num = 1;
						continue;
					}
					break;
				case 1:
					return;
				}
				if (this.af)
				{
					break;
				}
				num = 0;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00017294 File Offset: 0x00016294
		protected virtual void i()
		{
			try
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
				this.a(false);
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x04000037 RID: 55
		private const uint a = 4116U;

		// Token: 0x04000038 RID: 56
		private const uint b = 0U;

		// Token: 0x04000039 RID: 57
		private const string c = "\\Feature Bits";

		// Token: 0x0400003A RID: 58
		private const string d = "Byte08";

		// Token: 0x0400003B RID: 59
		private const uint e = 81U;

		// Token: 0x0400003C RID: 60
		private const uint f = 0U;

		// Token: 0x0400003D RID: 61
		private const uint g = 207U;

		// Token: 0x0400003E RID: 62
		private const string h = "55";

		// Token: 0x0400003F RID: 63
		private const int i = 500;

		// Token: 0x04000040 RID: 64
		private const int j = 501;

		// Token: 0x04000041 RID: 65
		private const uint k = 12U;

		// Token: 0x04000042 RID: 66
		private const uint l = 4113U;

		// Token: 0x04000043 RID: 67
		private const uint m = 0U;

		// Token: 0x04000044 RID: 68
		private const string n = "Byte02";

		// Token: 0x04000045 RID: 69
		private const uint o = 204U;

		// Token: 0x04000046 RID: 70
		private const uint p = 128U;

		// Token: 0x04000047 RID: 71
		private const uint q = 17U;

		// Token: 0x04000048 RID: 72
		private const string r = "15";

		// Token: 0x04000049 RID: 73
		private global::System.Collections.ArrayList s;

		// Token: 0x0400004A RID: 74
		private global::IshHandler.j t;

		// Token: 0x0400004B RID: 75
		private global::IshHandler.j u;

		// Token: 0x0400004C RID: 76
		private global::IshHandler.c v;

		// Token: 0x0400004D RID: 77
		private global::IshHandler.g w;

		// Token: 0x0400004E RID: 78
		private global::IshHandler.g x;

		// Token: 0x0400004F RID: 79
		private global::System.Collections.ArrayList y;

		// Token: 0x04000050 RID: 80
		private global::System.IntPtr z;

		// Token: 0x04000051 RID: 81
		private global::System.IntPtr aa;

		// Token: 0x04000052 RID: 82
		private bool ab;

		// Token: 0x04000053 RID: 83
		private bool ac;

		// Token: 0x04000054 RID: 84
		private bool ad;

		// Token: 0x04000055 RID: 85
		private bool ae;

		// Token: 0x04000056 RID: 86
		private bool af;

		// Token: 0x04000057 RID: 87
		private global::IshHandler.d ag;

		// Token: 0x04000058 RID: 88
		private bool ah;

		// Token: 0x04000059 RID: 89
		private global::IshHandler.i ai;
	}
}
