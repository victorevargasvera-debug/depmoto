using System;
using System.Globalization;
using System.Xml;
using custom_exception;

namespace cpservices
{
	// Token: 0x0200001B RID: 27
	internal class d
	{
		// Token: 0x0600010E RID: 270 RVA: 0x0002F2B8 File Offset: 0x0002E2B8
		public string a(ref global::System.Xml.XmlNode A_0, string A_1)
		{
			int num = 2;
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
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						goto IL_91;
					case 1:
						if (A_0.Attributes[A_1] != null)
						{
							num = 0;
							continue;
						}
						goto IL_BF;
					case 3:
						goto IL_5A;
					}
					if (A_0 != null)
					{
						num = 1;
						continue;
					}
					break;
				}
				num = 3;
			}
			IL_5A:
			global::custom_exception.CCustomException ex = global::cpservices.c.a(1042U, base.GetType().ToString(), "GetAttribute", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
			throw ex;
			IL_91:
			return A_0.Attributes[A_1].Value;
			IL_BF:
			return null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0002F388 File Offset: 0x0002E388
		public void a(ref global::System.Xml.XmlNode A_0, string A_1, string A_2)
		{
			int num = 2;
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
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						goto IL_5A;
					case 1:
						if (A_0.Attributes[A_1] != null)
						{
							num = 3;
							continue;
						}
						goto IL_C0;
					case 3:
						goto IL_92;
					}
					if (A_0 != null)
					{
						num = 1;
						continue;
					}
					break;
				}
				num = 0;
			}
			IL_5A:
			global::custom_exception.CCustomException ex = global::cpservices.c.a(1042U, base.GetType().ToString(), "SetAttribute", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
			throw ex;
			IL_92:
			A_0.Attributes[A_1].Value = A_2;
			return;
			IL_C0:
			global::custom_exception.CCustomException ex2 = global::cpservices.c.a(1061U, base.GetType().ToString(), "SetAttribute", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
			throw ex2;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0002F480 File Offset: 0x0002E480
		public void a(string A_0, int A_1, int A_2, string A_3, ref global::System.Xml.XmlNode A_4)
		{
			switch (0)
			{
			default:
			{
				for (;;)
				{
					global::System.Xml.XmlNodeList xmlNodeList = A_4.SelectNodes("//" + A_0);
					bool flag = false;
					int num = 0;
					int num2 = 0;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_218;
						case 1:
							goto IL_11B;
						case 2:
							num2 = 9;
							continue;
						case 3:
							num2 = 13;
							continue;
						case 4:
							goto IL_218;
						case 5:
						{
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes["ListID"].Value.Equals(A_1.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo)))
							{
								num2 = 16;
								continue;
							}
							goto IL_8D;
						}
						case 6:
						{
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes["ListLetID"] == null)
							{
								num2 = 12;
								continue;
							}
							goto IL_8D;
						}
						case 7:
							if (!flag)
							{
								num2 = 18;
								continue;
							}
							return;
						case 8:
						{
							global::System.Xml.XmlNode xmlNode;
							xmlNode.InnerText = A_3;
							flag = true;
							num2 = 11;
							continue;
						}
						case 9:
						{
							IL_1BB:
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes["ListLetID"].Value.Equals(A_2.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo)))
							{
								num2 = 8;
								continue;
							}
							goto IL_8D;
						}
						case 10:
							goto IL_2B0;
						case 11:
							goto IL_11B;
						case 12:
						{
							global::System.Xml.XmlNode xmlNode;
							xmlNode.InnerText = A_3;
							flag = true;
							num2 = 1;
							continue;
						}
						case 13:
						{
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes["ListLetID"] != null)
							{
								num2 = 2;
								continue;
							}
							goto IL_8D;
						}
						case 14:
						{
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes["ListID"] == null)
							{
								num2 = 10;
								continue;
							}
							num2 = 5;
							continue;
						}
						case 15:
						{
							if (num >= xmlNodeList.Count)
							{
								num2 = 17;
								continue;
							}
							if (true)
							{
							}
							global::System.Xml.XmlNode xmlNode = xmlNodeList[num];
							num2 = 14;
							continue;
						}
						case 16:
							num2 = 19;
							continue;
						case 17:
							goto IL_11B;
						case 18:
							goto IL_139;
						case 19:
							if (A_2 != -1)
							{
								num2 = 3;
								continue;
							}
							num2 = 6;
							continue;
						}
						break;
						IL_8D:
						num++;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1BB;
						default:
							if (false)
							{
							}
							num2 = 4;
							continue;
						}
						IL_11B:
						num2 = 7;
						continue;
						IL_218:
						num2 = 15;
					}
				}
				IL_139:
				global::custom_exception.CCustomException ex = global::cpservices.c.a(1060U, base.GetType().ToString(), "SetFieldValue", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex;
				IL_2B0:
				global::custom_exception.CCustomException ex2 = global::cpservices.c.a(1082U, base.GetType().ToString(), "SetFieldValue", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex2;
			}
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0002F780 File Offset: 0x0002E780
		public void a(string A_0, int A_1, int A_2, ref global::System.Xml.XmlNode A_3, ref string A_4)
		{
			switch (0)
			{
			default:
			{
				for (;;)
				{
					global::System.Xml.XmlNodeList xmlNodeList = A_3.SelectNodes("//" + A_0);
					bool flag = false;
					int num = 0;
					int num2 = 7;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_2BC;
						case 1:
							goto IL_224;
						case 2:
						{
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes["ListLetID"].Value.Equals(A_2.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo)))
							{
								num2 = 17;
								continue;
							}
							goto IL_8D;
						}
						case 3:
							goto IL_11C;
						case 4:
							goto IL_144;
						case 5:
						{
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes["ListLetID"] != null)
							{
								num2 = 18;
								continue;
							}
							goto IL_8D;
						}
						case 6:
							if (A_2 != -1)
							{
								num2 = 9;
								continue;
							}
							num2 = 12;
							continue;
						case 7:
							goto IL_224;
						case 8:
						{
							if (num >= xmlNodeList.Count)
							{
								num2 = 13;
								continue;
							}
							global::System.Xml.XmlNode xmlNode = xmlNodeList[num];
							if (true)
							{
							}
							num2 = 19;
							continue;
						}
						case 9:
							num2 = 5;
							continue;
						case 10:
						{
							global::System.Xml.XmlNode xmlNode;
							A_4 = xmlNode.InnerText;
							flag = true;
							num2 = 11;
							continue;
						}
						case 11:
							goto IL_11C;
						case 12:
						{
							IL_259:
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes["ListLetID"] == null)
							{
								num2 = 10;
								continue;
							}
							goto IL_8D;
						}
						case 13:
							goto IL_11C;
						case 14:
						{
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes["ListID"].Value.Equals(A_1.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo)))
							{
								num2 = 16;
								continue;
							}
							goto IL_8D;
						}
						case 15:
							if (!flag)
							{
								num2 = 4;
								continue;
							}
							return;
						case 16:
							num2 = 6;
							continue;
						case 17:
						{
							global::System.Xml.XmlNode xmlNode;
							A_4 = xmlNode.InnerText;
							flag = true;
							num2 = 3;
							continue;
						}
						case 18:
							num2 = 2;
							continue;
						case 19:
						{
							global::System.Xml.XmlNode xmlNode;
							if (xmlNode.Attributes["ListID"] == null)
							{
								num2 = 0;
								continue;
							}
							num2 = 14;
							continue;
						}
						}
						break;
						IL_8D:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_259;
						default:
							if (false)
							{
							}
							num++;
							num2 = 1;
							continue;
						}
						IL_11C:
						num2 = 15;
						continue;
						IL_224:
						num2 = 8;
					}
				}
				IL_144:
				global::custom_exception.CCustomException ex = global::cpservices.c.a(1060U, base.GetType().ToString(), "GetFieldValue", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex;
				IL_2BC:
				global::custom_exception.CCustomException ex2 = global::cpservices.c.a(1082U, base.GetType().ToString(), "GetFieldValue", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex2;
			}
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0002FA80 File Offset: 0x0002EA80
		public bool a(string A_0, string A_1)
		{
			switch (0)
			{
			default:
			{
				bool result;
				for (;;)
				{
					result = false;
					int num = 52;
					for (;;)
					{
						int length;
						int num2;
						int length3;
						switch (num)
						{
						case 0:
							result = true;
							num = 20;
							continue;
						case 1:
							return result;
						case 2:
							result = true;
							num = 18;
							continue;
						case 3:
						{
							bool flag;
							if (!flag)
							{
								num = 22;
								continue;
							}
							num = 40;
							continue;
						}
						case 4:
							if (A_1.CompareTo(A_0.Substring(0, 4)) <= 0)
							{
								num = 12;
								continue;
							}
							return result;
						case 5:
							goto IL_1A9;
						case 6:
							result = false;
							num = 15;
							continue;
						case 7:
							goto IL_431;
						case 8:
							return result;
						case 9:
							result = true;
							num = 1;
							continue;
						case 10:
						{
							bool flag2;
							if (!flag2)
							{
								num = 6;
								continue;
							}
							goto IL_331;
						}
						case 11:
							if (true)
							{
							}
							goto IL_172;
						case 12:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1A9;
							default:
								if (false)
								{
								}
								result = true;
								num = 8;
								continue;
							}
							break;
						case 13:
							result = true;
							num = 28;
							continue;
						case 14:
							if (A_1.CompareTo(A_0.Substring(0, 4)) >= 0)
							{
								num = 0;
								continue;
							}
							return result;
						case 15:
							goto IL_331;
						case 16:
						{
							bool flag2 = false;
							num = 27;
							continue;
						}
						case 17:
							if (length.Equals(9))
							{
								num = 19;
								continue;
							}
							result = false;
							num = 31;
							continue;
						case 18:
							return result;
						case 19:
						{
							bool flag2 = true;
							num2 = 0;
							num = 51;
							continue;
						}
						case 20:
							return result;
						case 21:
							if (A_0.Equals(A_1))
							{
								num = 9;
								continue;
							}
							return result;
						case 22:
							result = false;
							num = 53;
							continue;
						case 23:
							goto IL_406;
						case 24:
							goto IL_311;
						case 25:
						{
							bool flag = false;
							num = 41;
							continue;
						}
						case 26:
							if (num2 == 4)
							{
								num = 32;
								continue;
							}
							num = 30;
							continue;
						case 27:
							goto IL_172;
						case 28:
							return result;
						case 29:
							num = 4;
							continue;
						case 30:
							if (!char.IsDigit(A_0[num2]))
							{
								num = 16;
								continue;
							}
							goto IL_592;
						case 31:
							return result;
						case 32:
							num = 42;
							continue;
						case 33:
							goto IL_172;
						case 34:
							if (A_1.CompareTo(A_0.Substring(0, 4)) >= 0)
							{
								num = 50;
								continue;
							}
							return result;
						case 35:
						{
							int num3;
							if (num3 >= 4)
							{
								num = 24;
								continue;
							}
							num = 39;
							continue;
						}
						case 36:
							num = 21;
							continue;
						case 37:
							if (num2 >= 9)
							{
								num = 11;
								continue;
							}
							num = 26;
							continue;
						case 38:
							goto IL_431;
						case 39:
						{
							int num3;
							if (!char.IsDigit(A_0[num3]))
							{
								num = 25;
								continue;
							}
							num3++;
							num = 7;
							continue;
						}
						case 40:
							if (A_0.Substring(4).Equals("+"))
							{
								num = 46;
								continue;
							}
							num = 47;
							continue;
						case 41:
							goto IL_311;
						case 42:
							if (!object.Equals(A_0[num2], '~'))
							{
								num = 48;
								continue;
							}
							goto IL_592;
						case 43:
							if (A_1.CompareTo(A_0.Substring(5, 4)) <= 0)
							{
								num = 13;
								continue;
							}
							return result;
						case 44:
						{
							int length2;
							if (length2.Equals(4))
							{
								num = 36;
								continue;
							}
							length3 = A_0.Length;
							num = 5;
							continue;
						}
						case 45:
							return result;
						case 46:
							num = 14;
							continue;
						case 47:
							if (A_0.Substring(4).Equals("-"))
							{
								num = 29;
								continue;
							}
							result = false;
							num = 45;
							continue;
						case 48:
						{
							bool flag2 = false;
							num = 33;
							continue;
						}
						case 49:
						{
							bool flag = true;
							int num3 = 0;
							num = 38;
							continue;
						}
						case 50:
							num = 43;
							continue;
						case 51:
							goto IL_406;
						case 52:
						{
							if (A_0.Equals("All"))
							{
								num = 2;
								continue;
							}
							int length2 = A_0.Length;
							num = 44;
							continue;
						}
						case 53:
							return result;
						}
						break;
						IL_172:
						num = 10;
						continue;
						IL_1A9:
						if (length3.Equals(5))
						{
							num = 49;
							continue;
						}
						length = A_0.Length;
						num = 17;
						continue;
						IL_311:
						num = 3;
						continue;
						IL_331:
						num = 34;
						continue;
						IL_406:
						num = 37;
						continue;
						IL_431:
						num = 35;
						continue;
						IL_592:
						num2++;
						num = 23;
					}
				}
				return result;
			}
			}
		}
	}
}
