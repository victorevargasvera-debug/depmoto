using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Xml;
using CommunicationController;
using constants;
using custom_exception;

namespace cpservices
{
	// Token: 0x02000019 RID: 25
	internal class h
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x0002B2C4 File Offset: 0x0002A2C4
		public h(ref global::cpservices.CDeviceInfo A_0, ref string A_1, string A_2)
		{
			try
			{
				this.ak = new global::System.Xml.XmlDocument();
				this.@as = A_1;
				this.al = A_0;
				this.an = new global::System.Xml.XmlDocument();
				this.ar = new global::cpservices.d();
				this.am = new global::System.Xml.XmlDocument();
				this.aq = new global::cpservices.a();
				this.ap = new global::cpservices.e(ref A_0, ref A_1);
				this.aj = new global::cpservices.f(ref A_0);
				this.at = A_2;
				string str = string.Empty;
				string str2 = string.Empty;
				if (A_2 == "PHOENIX")
				{
					str = "\\trunking3600_packunpack.lmx";
				}
				else if (A_2 == "GEMSTONE")
				{
					str = "trbo_packunpack.lmx";
				}
				else
				{
					str = "\\packunpack.lmx";
				}
				if (!global::System.IO.File.Exists(A_1 + str))
				{
					global::custom_exception.CCustomException ex = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.NOTFOUNDINPACKXML, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "CLTDApp", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex;
				}
				try
				{
					string empty = string.Empty;
					global::j.a(A_1 + str, ref empty, false, global::j.b.d);
					global::j.c c = global::j.a(global::j.a.b, ref empty);
					if (c != global::j.c.c)
					{
						global::custom_exception.CCustomException ex2 = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.SIGNATUREVERIFICATIONFAILED, global::System.Globalization.NumberFormatInfo.InvariantInfo), "CLTDApp", "CLTDApp", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
						throw ex2;
					}
					global::System.Xml.XmlTextReader reader = new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(empty));
					this.an.Load(reader);
					this.a(ref this.an);
					goto IL_30F;
				}
				catch
				{
					global::custom_exception.CCustomException ex3 = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.WRONGINPACKXML, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "CLTDApp", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex3;
				}
				goto IL_2F9;
				IL_90:
				if (global::System.IO.File.Exists(A_1 + str2))
				{
					try
					{
						string empty = string.Empty;
						global::j.a(A_1 + str2, ref empty, false, global::j.b.d);
						global::j.c c2 = global::j.a(global::j.a.b, ref empty);
						if (c2 != global::j.c.c)
						{
							global::custom_exception.CCustomException ex4 = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.SIGNATUREVERIFICATIONFAILED, global::System.Globalization.NumberFormatInfo.InvariantInfo), "CLTDApp", "CLTDApp", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
							throw ex4;
						}
						global::System.Xml.XmlTextReader reader = new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(empty));
						this.am.Load(reader);
						this.a(ref this.am);
						goto IL_353;
					}
					catch
					{
						global::custom_exception.CCustomException ex5 = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.WRONGINTYPEXML, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "CLTDApp", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
						throw ex5;
					}
					goto IL_1A6;
					IL_353:
					this.aj = new global::cpservices.f(ref A_0);
					this.ao = new global::cpservices.d();
					return;
				}
				IL_1A6:
				global::custom_exception.CCustomException ex6 = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.NOTFOUNDINTYPEXML, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "CLTDApp", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex6;
				IL_2F9:
				str2 = "\\typeid.lmx";
				goto IL_90;
				IL_30F:
				if (A_2 == "PHOENIX")
				{
					str2 = "\\trunking3600_typeid.lmx";
					goto IL_90;
				}
				if (A_2 == "GEMSTONE")
				{
					str2 = "trbo_typeid.lmx";
					goto IL_90;
				}
				if (A_2 == "Bahama")
				{
					str2 = "\\ngr_typeid.lmx";
					goto IL_90;
				}
				goto IL_2F9;
			}
			catch (global::custom_exception.CCustomException ex7)
			{
				throw ex7;
			}
			catch (global::System.Exception a_)
			{
				global::cpservices.c.a(a_);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0002B6B4 File Offset: 0x0002A6B4
		protected virtual void a()
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
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0002B708 File Offset: 0x0002A708
		public void a(ref global::CommunicationController.IRadioCodeplugController A_0, ref string A_1, ref bool A_2, bool A_3, global::constants.CCPTags.SetProgressBar A_4)
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
						global::System.Xml.XmlDocument xmlDocument;
						global::System.Xml.XmlNode xmlNode;
						string text;
						global::System.Xml.XmlNode xmlNode2;
						string text3;
						global::System.Xml.XmlDocument xmlDocument3;
						global::System.Xml.XmlNode xmlNode3;
						global::System.Xml.XmlNode newChild;
						global::System.Xml.XmlDocument xmlDocument4;
						string empty;
						string empty2;
						string empty3;
						string empty4;
						string empty6;
						string empty7;
						string empty8;
						string empty9;
						string empty10;
						string text5;
						bool flag2;
						string text9;
						string innerText2;
						string empty18;
						string empty19;
						string text10;
						global::System.Xml.XmlDocument xmlDocument5;
						string text11;
						switch (num)
						{
						case 0:
						{
							if (A_3)
							{
								num = 45;
								continue;
							}
							string a_ = "LBL_RXFREQUENCYRANGE";
							this.aj.a(ref xmlDocument, a_, 0, -1, out xmlNode);
							xmlNode.InnerText = text;
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 21;
							continue;
						}
						case 1:
						{
							global::System.Xml.XmlDocument xmlDocument2 = new global::System.Xml.XmlDocument();
							xmlDocument2.LoadXml("<UPDATES></UPDATES>");
							byte a_2 = 129;
							string text2 = string.Empty;
							text2 = "RADIO_SECURITY_INFO_CMP_TYPE";
							global::System.Xml.XmlNode documentElement = xmlDocument2.DocumentElement;
							this.a(ref A_0, a_2, text2, ref A_2, ref documentElement, ref A_3);
							xmlNode2 = documentElement["RADIO_SECURITY_INFO_CMP_TYPE"]["RS_MODELNUM"];
							num = 66;
							continue;
						}
						case 2:
							num = 22;
							continue;
						case 3:
							goto IL_11E0;
						case 4:
							goto IL_372;
						case 5:
							goto IL_372;
						case 6:
							goto IL_A26;
						case 8:
							if (!(text3 == "800"))
							{
								num = 16;
								continue;
							}
							goto IL_B49;
						case 9:
							goto IL_F8D;
						case 10:
						{
							try
							{
								xmlNode3 = xmlDocument3.CreateNode(global::System.Xml.XmlNodeType.Element, "SECURITY_PARTITION", "");
								goto IL_10FD;
							}
							catch
							{
								global::custom_exception.CCustomException ex = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.INVALID_XML_CONTENT, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "ReadCodeplug", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
								throw ex;
							}
							goto IL_130C;
							IL_10FD:
							byte a_3 = 129;
							string text4 = "RADIO_SECURITY_INFO_CMP_TYPE";
							string name = text4 + "_GRP";
							newChild = xmlDocument3.CreateNode(global::System.Xml.XmlNodeType.Element, name, "");
							global::System.Xml.XmlElement documentElement2 = xmlDocument4.DocumentElement;
							bool flag = false;
							this.a(ref A_0, a_3, text4, ref flag, ref newChild, ref A_3);
							xmlNode3.AppendChild(newChild);
							empty = string.Empty;
							empty2 = string.Empty;
							empty3 = string.Empty;
							empty4 = string.Empty;
							string empty5 = string.Empty;
							empty6 = string.Empty;
							empty7 = string.Empty;
							empty8 = string.Empty;
							empty9 = string.Empty;
							empty10 = string.Empty;
							text5 = string.Empty;
							string empty11 = string.Empty;
							string empty12 = string.Empty;
							this.ao.a("RS_RGNID", 0, -1, ref newChild, ref empty);
							num = 59;
							continue;
						}
						case 11:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_11DB;
							default:
								if (false)
								{
								}
								goto IL_680;
							}
							break;
						case 12:
							goto IL_FA5;
						case 13:
							goto IL_ED0;
						case 14:
							goto IL_ED0;
						case 15:
						{
							if (this.at != "PHOENIX")
							{
								num = 24;
								continue;
							}
							global::System.Xml.XmlNode xmlNode4 = xmlNode;
							string text6;
							xmlNode4.InnerText = xmlNode4.InnerText + "\n" + text6 + "\n";
							num = 14;
							continue;
						}
						case 16:
							num = 23;
							continue;
						case 17:
						{
							string text7;
							string empty13;
							xmlNode.InnerText = (flag2 ? (empty3 + "\n" + text7 + "\n") : (empty3 + "-" + empty13));
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 33;
							continue;
						}
						case 18:
						{
							string str;
							string text8;
							string empty14;
							string empty15;
							xmlNode.InnerText = (flag2 ? (str + "\n" + text8 + "\n") : (empty14 + "-" + empty15));
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 43;
							continue;
						}
						case 19:
							goto IL_FC9;
						case 20:
						{
							if (A_3)
							{
								num = 55;
								continue;
							}
							string a_4 = "LBL_RXLASTPROGRAMMEDDATETIME";
							this.aj.a(ref xmlDocument, a_4, 0, -1, out xmlNode);
							xmlNode.InnerText = text5;
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 89;
							continue;
						}
						case 21:
							goto IL_1394;
						case 22:
							if (A_1 == null)
							{
								num = 19;
								continue;
							}
							num = 31;
							continue;
						case 23:
							if (text3 == "900")
							{
								num = 82;
								continue;
							}
							goto IL_F8D;
						case 24:
						{
							global::System.Xml.XmlNode xmlNode5 = xmlNode;
							string innerText = xmlNode5.InnerText;
							string text6;
							xmlNode5.InnerText = string.Concat(new string[]
							{
								innerText,
								" (RX)\n",
								text6,
								" (RX)\n",
								text9
							});
							num = 13;
							continue;
						}
						case 25:
							goto IL_1702;
						case 26:
							goto IL_522;
						case 27:
						{
							string empty16;
							string empty17;
							if (empty16.Equals(empty17))
							{
								num = 57;
								continue;
							}
							goto IL_BF0;
						}
						case 28:
							num = 27;
							continue;
						case 29:
						{
							if (!this.al.ValidateModel(innerText2, out empty18))
							{
								num = 67;
								continue;
							}
							global::System.Xml.XmlDocument xmlDocument2;
							xmlNode2 = xmlDocument2.CreateNode(global::System.Xml.XmlNodeType.Element, "MODEL_TYPE", "");
							xmlNode2.InnerText = empty18;
							global::System.Xml.XmlNode documentElement;
							documentElement.AppendChild(xmlNode2);
							xmlNode2 = documentElement["RADIO_SECURITY_INFO_CMP_TYPE"]["RS_RGNID"];
							num = 37;
							continue;
						}
						case 30:
						{
							if (this.at == "PHOENIX")
							{
								num = 70;
								continue;
							}
							global::System.Xml.XmlNode xmlNode6;
							this.ar.a("RI_LPGYEAR", 0, -1, ref xmlNode6, ref empty6);
							this.ar.a("RI_LPGMONTH", 0, -1, ref xmlNode6, ref empty7);
							this.ar.a("RI_LPGDAY", 0, -1, ref xmlNode6, ref empty8);
							this.ar.a("RI_LPGHOUR", 0, -1, ref xmlNode6, ref empty9);
							this.ar.a("RI_LPGMINUTES", 0, -1, ref xmlNode6, ref empty10);
							num = 11;
							continue;
						}
						case 31:
							if (A_1 == "DeviceInfo")
							{
								num = 1;
								continue;
							}
							goto IL_90D;
						case 32:
							if (text3 == "800")
							{
								num = 48;
								continue;
							}
							goto IL_1423;
						case 33:
							goto IL_F8D;
						case 34:
							if (text3 == "8/900")
							{
								num = 74;
								continue;
							}
							num = 35;
							continue;
						case 35:
							if (this.at == "GEMSTONE")
							{
								num = 78;
								continue;
							}
							goto IL_F8D;
						case 36:
						{
							if (this.at == "PHOENIX")
							{
								num = 40;
								continue;
							}
							global::System.Xml.XmlNode xmlNode6;
							this.ar.a("RI_LPGSOURCE", 0, -1, ref xmlNode6, ref empty19);
							num = 71;
							continue;
						}
						case 37:
						{
							if (xmlNode2 == null)
							{
								num = 61;
								continue;
							}
							string innerText3 = xmlNode2.InnerText;
							this.al.SetRegion(A_3, innerText3);
							byte a_2 = 128;
							string text2 = "RAD_APP_INFO_CMP_TYPE";
							string name2 = string.Empty;
							name2 = text2 + "_GRP";
							global::System.Xml.XmlDocument xmlDocument2;
							xmlNode2 = xmlDocument2.CreateNode(global::System.Xml.XmlNodeType.Element, name2, "");
							this.a(ref A_0, a_2, text2, ref A_2, ref xmlNode2, ref A_3);
							string empty20 = string.Empty;
							this.ar.a("RI_LPGDATE", 0, -1, ref xmlNode2, ref empty20);
							xmlNode2 = xmlDocument2.CreateNode(global::System.Xml.XmlNodeType.Element, "RI_LPGDATE", "");
							xmlNode2.InnerText = empty20;
							global::System.Xml.XmlNode documentElement;
							documentElement.AppendChild(xmlNode2);
							string empty21 = string.Empty;
							this.a(A_0, ref empty21);
							xmlNode2 = xmlDocument2.CreateNode(global::System.Xml.XmlNodeType.Element, "CS_FWVER", "");
							xmlNode2.InnerText = empty21;
							documentElement.AppendChild(xmlNode2);
							A_1 = xmlDocument2.OuterXml;
							num = 88;
							continue;
						}
						case 38:
							if (text10 == "Cypher")
							{
								num = 62;
								continue;
							}
							goto IL_1423;
						case 39:
						{
							string a_5 = "LBL_FREQUENCYRANGE";
							this.aj.a(ref xmlDocument, a_5, 0, -1, out xmlNode);
							num = 52;
							continue;
						}
						case 40:
						{
							global::System.Xml.XmlNode xmlNode6;
							this.ar.a("RAI_LPS", 0, -1, ref xmlNode6, ref empty19);
							num = 3;
							continue;
						}
						case 41:
							goto IL_1676;
						case 42:
							goto IL_F8D;
						case 43:
							goto IL_F8D;
						case 44:
						{
							string empty22 = string.Empty;
							string empty23 = string.Empty;
							string empty13 = string.Empty;
							string empty14 = string.Empty;
							string empty16 = string.Empty;
							string empty17 = string.Empty;
							string empty15 = string.Empty;
							this.ao.a("RS_BANDMINFREQ2", 0, -1, ref newChild, ref empty23);
							this.ao.a("RS_BANDMAXFREQ2", 0, -1, ref newChild, ref empty13);
							string text7 = string.Empty;
							text7 = text7 + empty23 + "-" + empty13;
							this.ao.a("RS_BANDMINFREQ3", 0, -1, ref newChild, ref empty14);
							this.ao.a("RS_BANDMAXFREQ3", 0, -1, ref newChild, ref empty16);
							string str = string.Empty;
							str = str + empty14 + "-" + empty16;
							this.ao.a("RS_BANDMINFREQ4", 0, -1, ref newChild, ref empty17);
							this.ao.a("RS_BANDMAXFREQ4", 0, -1, ref newChild, ref empty15);
							string text8 = string.Empty;
							text8 = text8 + empty17 + "-" + empty15;
							flag2 = false;
							num = 64;
							continue;
						}
						case 45:
						{
							string a_6 = "LBL_FREQUENCYRANGE";
							this.aj.a(ref xmlDocument, a_6, 0, -1, out xmlNode);
							xmlNode.InnerText = text;
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 47;
							continue;
						}
						case 46:
						{
							if (A_3)
							{
								num = 69;
								continue;
							}
							string a_7 = "LBL_RXFREQUENCYRANGE";
							this.aj.a(ref xmlDocument, a_7, 0, -1, out xmlNode);
							num = 17;
							continue;
						}
						case 47:
							goto IL_1394;
						case 48:
						{
							string empty24 = string.Empty;
							string empty25 = string.Empty;
							this.ao.a("RS_BANDMINFREQ3", 0, -1, ref newChild, ref empty24);
							this.ao.a("RS_BANDMAXFREQ3", 0, -1, ref newChild, ref empty25);
							num = 83;
							continue;
						}
						case 49:
							goto IL_F8D;
						case 50:
						{
							if (A_3)
							{
								num = 63;
								continue;
							}
							string a_8 = "LBL_RXDEVICETANAPANUM";
							this.aj.a(ref xmlDocument, a_8, 0, -1, out xmlNode);
							xmlNode.InnerText = empty2.Replace("\0", "");
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 51;
							continue;
						}
						case 51:
							goto IL_AB2;
						case 52:
						{
							if (this.at != "PHOENIX")
							{
								num = 53;
								continue;
							}
							global::System.Xml.XmlNode xmlNode7 = xmlNode;
							string text6;
							xmlNode7.InnerText = xmlNode7.InnerText + "\n" + text6 + "\n";
							num = 73;
							continue;
						}
						case 53:
						{
							global::System.Xml.XmlNode xmlNode8 = xmlNode;
							string innerText = xmlNode8.InnerText;
							string text6;
							xmlNode8.InnerText = string.Concat(new string[]
							{
								innerText,
								" (RX)\n",
								text6,
								" (RX)\n",
								text9
							});
							num = 6;
							continue;
						}
						case 54:
						{
							string a_9 = "LBL_FREQUENCYRANGE";
							this.aj.a(ref xmlDocument, a_9, 0, -1, out xmlNode);
							string empty24;
							string empty25;
							xmlNode.InnerText = empty24 + "-" + empty25;
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 80;
							continue;
						}
						case 55:
						{
							string a_10 = "LBL_LASTPROGRAMMEDDATETIME";
							this.aj.a(ref xmlDocument, a_10, 0, -1, out xmlNode);
							xmlNode.InnerText = text5;
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 77;
							continue;
						}
						case 56:
							if (this.at != "PHOENIX")
							{
								num = 26;
								continue;
							}
							goto IL_1676;
						case 57:
							flag2 = false;
							num = 12;
							continue;
						case 58:
						{
							if (A_3)
							{
								num = 72;
								continue;
							}
							string a_11 = "LBL_RXLASTPROGRAMMEDSOURCE";
							this.aj.a(ref xmlDocument, a_11, 0, -1, out xmlNode);
							xmlNode.InnerText = empty19;
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 84;
							continue;
						}
						case 59:
						{
							if (A_3)
							{
								num = 68;
								continue;
							}
							string a_12 = "LBL_RXREGION";
							this.aj.a(ref xmlDocument, a_12, 0, -1, out xmlNode);
							xmlNode.InnerText = empty;
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 4;
							continue;
						}
						case 60:
						{
							if (A_3)
							{
								num = 39;
								continue;
							}
							string a_13 = "LBL_RXFREQUENCYRANGE";
							this.aj.a(ref xmlDocument, a_13, 0, -1, out xmlNode);
							num = 15;
							continue;
						}
						case 61:
							goto IL_E99;
						case 62:
							num = 32;
							continue;
						case 63:
						{
							string a_14 = "LBL_DEVICETANAPANUM";
							this.aj.a(ref xmlDocument, a_14, 0, -1, out xmlNode);
							xmlNode.InnerText = empty2.Replace("\0", "");
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 90;
							continue;
						}
						case 64:
						{
							string empty23;
							if (empty4.Equals(empty23))
							{
								num = 28;
								continue;
							}
							goto IL_BF0;
						}
						case 65:
							goto IL_16F6;
						case 66:
							if (xmlNode2 == null)
							{
								num = 87;
								continue;
							}
							goto IL_130C;
						case 67:
							goto IL_134E;
						case 68:
							goto IL_11DB;
						case 69:
						{
							string a_15 = "LBL_FREQUENCYRANGE";
							this.aj.a(ref xmlDocument, a_15, 0, -1, out xmlNode);
							num = 18;
							continue;
						}
						case 70:
						{
							global::System.Xml.XmlNode xmlNode6;
							this.ar.a("RAI_LPDY", 0, -1, ref xmlNode6, ref empty6);
							this.ar.a("RAI_LPDM", 0, -1, ref xmlNode6, ref empty7);
							this.ar.a("RAI_LPDD", 0, -1, ref xmlNode6, ref empty8);
							this.ar.a("RAI_LPDH", 0, -1, ref xmlNode6, ref empty9);
							this.ar.a("RAI_LPDMIN", 0, -1, ref xmlNode6, ref empty10);
							num = 85;
							continue;
						}
						case 71:
							goto IL_11E0;
						case 72:
						{
							string a_16 = "LBL_LASTPROGRAMMEDSOURCE";
							this.aj.a(ref xmlDocument, a_16, 0, -1, out xmlNode);
							xmlNode.InnerText = empty19;
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 65;
							continue;
						}
						case 73:
							goto IL_A26;
						case 74:
						{
							text9 = string.Empty;
							this.ao.a("RS_BANDMINFREQ2", 0, -1, ref newChild, ref empty3);
							this.ao.a("RS_BANDMAXFREQ2", 0, -1, ref newChild, ref empty4);
							string text6 = string.Empty;
							text6 = text6 + empty3 + "-" + empty4;
							num = 56;
							continue;
						}
						case 75:
						{
							try
							{
								xmlDocument5.CreateNode(global::System.Xml.XmlNodeType.Element, "APP_PARTITION", "");
								goto IL_CBE;
							}
							catch
							{
								global::custom_exception.CCustomException ex2 = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.INVALID_XML_CONTENT, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "ReadCodeplug", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
								throw ex2;
							}
							goto IL_522;
							IL_CBE:
							byte a_3 = 128;
							string text4 = "RAD_APP_INFO_CMP_TYPE";
							string name = text4 + "_GRP";
							global::System.Xml.XmlNode xmlNode6 = xmlDocument5.CreateNode(global::System.Xml.XmlNodeType.Element, name, "");
							global::System.Xml.XmlElement documentElement3 = xmlDocument4.DocumentElement;
							bool flag3 = false;
							this.a(ref A_0, a_3, text4, ref flag3, ref xmlNode6, ref A_3);
							num = 30;
							continue;
						}
						case 76:
							num = 79;
							continue;
						case 77:
							goto IL_DC5;
						case 78:
							num = 8;
							continue;
						case 79:
							if (text11 == "Bandit")
							{
								num = 44;
								continue;
							}
							goto IL_D97;
						case 80:
							goto IL_F8D;
						case 81:
							if (text10 == "Cypher")
							{
								num = 76;
								continue;
							}
							goto IL_D97;
						case 82:
							goto IL_B49;
						case 83:
						{
							if (A_3)
							{
								num = 54;
								continue;
							}
							string a_17 = "LBL_RXFREQUENCYRANGE";
							this.aj.a(ref xmlDocument, a_17, 0, -1, out xmlNode);
							xmlNode.InnerText = empty3 + "-" + empty4;
							xmlNode.Attributes["Applicable"].Value = "Enabled";
							num = 42;
							continue;
						}
						case 84:
							goto IL_16F6;
						case 85:
							goto IL_680;
						case 86:
							goto IL_F8D;
						case 87:
							goto IL_A21;
						case 88:
							goto IL_16F6;
						case 89:
							goto IL_DC5;
						case 90:
							goto IL_AB2;
						case 91:
							goto IL_FA5;
						}
						if (!(A_1 == string.Empty))
						{
							num = 2;
							continue;
						}
						goto IL_FC9;
						IL_372:
						this.ao.a("RS_TANAPANUM", 0, -1, ref newChild, ref empty2);
						num = 50;
						continue;
						IL_522:
						this.ao.a("RS_BANDMINFREQ3", 0, -1, ref newChild, ref empty3);
						this.ao.a("RS_BANDMAXFREQ3", 0, -1, ref newChild, ref empty4);
						string str2 = string.Empty;
						str2 = str2 + empty3 + "-" + empty4;
						this.ao.a("RS_BANDMINFREQ4", 0, -1, ref newChild, ref empty3);
						this.ao.a("RS_BANDMAXFREQ4", 0, -1, ref newChild, ref empty4);
						string text12 = string.Empty;
						text12 = text12 + empty3 + "-" + empty4;
						text9 = str2 + " (TX)\n" + text12 + " (TX)\n";
						num = 41;
						continue;
						IL_680:
						object obj = text5;
						text5 = string.Concat(new object[]
						{
							obj,
							empty8,
							"/",
							empty7,
							"/",
							empty6,
							' ',
							empty9,
							":",
							empty10
						});
						num = 20;
						continue;
						IL_A26:
						xmlNode.Attributes["Applicable"].Value = "Enabled";
						num = 86;
						continue;
						IL_AB2:
						this.ao.a("RS_BANDMINFREQ", 0, -1, ref newChild, ref empty3);
						this.ao.a("RS_BANDMAXFREQ", 0, -1, ref newChild, ref empty4);
						text = string.Empty;
						text = text + empty3 + "-" + empty4;
						num = 0;
						continue;
						IL_B49:
						this.ao.a("RS_BANDMINFREQ3", 0, -1, ref newChild, ref empty3);
						this.ao.a("RS_BANDMAXFREQ3", 0, -1, ref newChild, ref empty4);
						string text13 = string.Empty;
						text13 = text13 + empty3 + "-" + empty4;
						string a_18 = "LBL_FREQUENCYRANGE";
						this.aj.a(ref xmlDocument, a_18, 0, -1, out xmlNode);
						global::System.Xml.XmlNode xmlNode9 = xmlNode;
						xmlNode9.InnerText = xmlNode9.InnerText + " (RX)\n" + text13 + " (TX)\n";
						xmlNode.Attributes["Applicable"].Value = "Enabled";
						num = 9;
						continue;
						IL_BF0:
						flag2 = true;
						num = 91;
						continue;
						IL_D97:
						num = 38;
						continue;
						IL_DC5:
						empty19 = string.Empty;
						num = 36;
						continue;
						IL_ED0:
						xmlNode.Attributes["Applicable"].Value = "Enabled";
						num = 49;
						continue;
						IL_F8D:
						xmlDocument5 = new global::System.Xml.XmlDocument();
						num = 75;
						continue;
						IL_FA5:
						num = 46;
						continue;
						IL_FC9:
						new global::cpservices.b(ref this.al, ref this.@as, ref this.aj, this.at);
						xmlDocument = this.aj.r;
						xmlNode = null;
						xmlDocument3 = new global::System.Xml.XmlDocument();
						xmlNode3 = null;
						xmlDocument4 = new global::System.Xml.XmlDocument();
						xmlDocument4.LoadXml("<UPDATES></UPDATES>");
						num = 10;
						continue;
						IL_11DB:
						string a_19 = "LBL_REGION";
						this.aj.a(ref xmlDocument, a_19, 0, -1, out xmlNode);
						xmlNode.InnerText = empty;
						xmlNode.Attributes["Applicable"].Value = "Enabled";
						num = 5;
						continue;
						IL_11E0:
						num = 58;
						continue;
						IL_130C:
						innerText2 = xmlNode2.InnerText;
						empty18 = string.Empty;
						string empty26 = string.Empty;
						num = 29;
						continue;
						IL_1394:
						string empty27 = string.Empty;
						this.ao.a("RS_MODELNUM", 0, -1, ref newChild, ref empty27);
						this.al.ValidateModel(empty27, out text10, out text3, out text11);
						num = 81;
						continue;
						IL_1423:
						num = 34;
						continue;
						IL_1676:
						num = 60;
						continue;
						IL_16F6:
						num = 25;
					}
					IL_90D:
					global::custom_exception.CCustomException ex3 = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.INVALID_ARGUMENT, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "ReadDevice", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex3;
					IL_A21:
					global::custom_exception.CCustomException ex4 = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.NODENOTFOUND, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "ReadDevice", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex4;
					IL_E99:
					global::custom_exception.CCustomException ex5 = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.NODENOTFOUND, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "ReadDevice", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex5;
					IL_134E:
					global::custom_exception.CCustomException ex6 = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.INVALID_MODELNUM, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "ReadDevice", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex6;
					IL_1702:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException ex7)
			{
				throw ex7;
			}
			catch (global::System.Exception a_20)
			{
				global::cpservices.c.a(a_20);
			}
			if (true)
			{
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0002CEA0 File Offset: 0x0002BEA0
		public void a(ref global::CommunicationController.IRadioCodeplugController A_0, byte A_1, string A_2, ref bool A_3, ref global::System.Xml.XmlNode A_4, ref bool A_5)
		{
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						IL_4B:
						global::cpservices.h.a a;
						this.a(A_2, out a);
						ushort usTypeID = global::System.Convert.ToUInt16(a.b);
						byte[] a_ = null;
						A_0.ReadISHType(A_1, usTypeID, ref a_);
						global::System.Collections.ArrayList arrayList;
						this.b(a_, out arrayList);
						this.a(arrayList);
						global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList();
						int num = 0;
						int num2;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_163:
							num2 = 10;
							break;
						default:
							if (false)
							{
							}
							num2 = 12;
							break;
						}
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_2A0;
							case 1:
								if (!A_3)
								{
									num2 = 4;
									continue;
								}
								goto IL_294;
							case 2:
							{
								int num3;
								global::System.Xml.XmlNode xmlNode;
								if (num3 >= xmlNode.ChildNodes.Count)
								{
									num2 = 11;
									continue;
								}
								global::System.Xml.XmlNode xmlNode2 = xmlNode.ChildNodes[num3];
								string name = xmlNode2.Name;
								string innerText = xmlNode2.InnerText;
								bool flag = this.ap.a(name, innerText, ref A_5);
								num2 = 3;
								continue;
							}
							case 3:
							{
								bool flag;
								if (!flag)
								{
									num2 = 8;
									continue;
								}
								int num3;
								num3++;
								num2 = 6;
								continue;
							}
							case 4:
							{
								global::System.Xml.XmlNode xmlNode = A_4.SelectSingleNode(A_2);
								int num3 = 0;
								num2 = 5;
								continue;
							}
							case 5:
								goto IL_1A2;
							case 6:
								goto IL_1A2;
							case 7:
								if (num >= arrayList.Count)
								{
									num2 = 9;
									continue;
								}
								goto IL_F0;
							case 8:
								goto IL_28F;
							case 9:
							{
								global::cpservices.b b = new global::cpservices.b(ref this.al, ref this.@as, ref this.aj, this.at);
								b.a(arrayList2, ref A_3, ref A_4, ref A_5);
								num2 = 1;
								continue;
							}
							case 10:
								goto IL_B2;
							case 11:
								goto IL_294;
							case 12:
								goto IL_B2;
							}
							goto IL_4B;
							IL_B2:
							num2 = 7;
							continue;
							IL_1A2:
							num2 = 2;
							continue;
							IL_294:
							num2 = 0;
						}
						IL_F0:
						global::cpservices.ItemData itemData;
						itemData.sTypeID = A_2;
						itemData.iListID = (int)((global::cpservices.CData)arrayList[num]).usISHID;
						itemData.bCPData = new byte[(int)((global::cpservices.CData)arrayList[num]).usDataLength];
						((global::cpservices.CData)arrayList[num]).abtData.CopyTo(itemData.bCPData, 0);
						arrayList2.Add(itemData);
						num++;
						goto IL_163;
					}
					IL_28F:
					global::custom_exception.CCustomException ex = global::cpservices.c.a(1089U, base.GetType().ToString(), "ChkFldAttributeDpd", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex;
					IL_2A0:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException ex2)
			{
				throw ex2;
			}
			catch (global::System.Exception a_2)
			{
				global::cpservices.c.a(a_2);
			}
			if (true)
			{
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0002D1A8 File Offset: 0x0002C1A8
		private void a(global::System.Collections.ArrayList A_0)
		{
			while (A_0.Count == 0)
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
					global::custom_exception.CCustomException ex = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.NULLDATA, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "NoEmptyArrayListAllowed", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex;
				}
				}
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0002D228 File Offset: 0x0002C228
		public void a(global::CommunicationController.IRadioCodeplugController A_0, ref string A_1)
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
			A_1 = A_0.IoControl<string>("QUERYRADIOSOFTWAREVERSION");
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0002D270 File Offset: 0x0002C270
		private void b(ref global::System.Xml.XmlNode A_0, string A_1, int A_2)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				global::System.Xml.XmlDocument ownerDocument = A_0.OwnerDocument;
				global::System.Xml.XmlAttribute xmlAttribute = ownerDocument.CreateAttribute("Applicable");
				xmlAttribute.Value = A_1;
				A_0.Attributes.Append(xmlAttribute);
				global::System.Xml.XmlAttribute xmlAttribute2 = ownerDocument.CreateAttribute("ListID");
				xmlAttribute2.Value = A_2.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo);
				A_0.Attributes.Append(xmlAttribute2);
			}
			catch (global::custom_exception.CCustomException ex)
			{
				throw ex;
			}
			catch (global::System.Exception a_)
			{
				global::cpservices.c.a(a_);
			}
			if (true)
			{
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0002D32C File Offset: 0x0002C32C
		public void b(ref global::System.Xml.XmlDocument A_0)
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
			global::System.Xml.XmlNode xmlNode = A_0.CreateElement("CS_PARTITION");
			A_0.DocumentElement.AppendChild(xmlNode);
			global::System.Xml.XmlNode xmlNode2 = A_0.CreateElement("CS_INFO_TYPE");
			xmlNode.AppendChild(xmlNode2);
			this.a(ref xmlNode2);
			global::System.Xml.XmlNode newChild = A_0.CreateElement("LBL_MODELNUM");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXMODELNUM");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_CPVER");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXCPVER");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_FWVER");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXFWVER");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXDEVICESERIALNUM");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_DEVICESERIALNUM");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXBRICKSERIALNUM");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_TXBRICKSERIALNUM");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_BOOTLOADER");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXBOOTLOADER");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_PSDT");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXPSDT");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_REGION");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXREGION");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_DEVICETANAPANUM");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXDEVICETANAPANUM");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_LASTPROGRAMMEDSOURCE");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXLASTPROGRAMMEDSOURCE");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_LASTPROGRAMMEDDATETIME");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXLASTPROGRAMMEDDATETIME");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_FREQUENCYRANGE");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXFREQUENCYRANGE");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_MODELTYPE");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_SINGLEMODELTYPE");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_TXBOARD");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
			newChild = A_0.CreateElement("LBL_RXBOARD");
			xmlNode2.AppendChild(newChild);
			this.a(ref newChild);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0002D6CC File Offset: 0x0002C6CC
		public void c(ref global::System.Xml.XmlDocument A_0)
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
			global::System.Xml.XmlNode xmlNode = null;
			string a_ = "LBL_REGION";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXREGION";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_MODELTYPE";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_SINGLEMODELTYPE";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_MODELNUM";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXMODELNUM";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_TXBRICKSERIALNUM";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXBRICKSERIALNUM";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_DEVICESERIALNUM";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXDEVICESERIALNUM";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_BOOTLOADER";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXBOOTLOADER";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_PSDT";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXPSDT";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_CPVER";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXCPVER";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_FWVER";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXFWVER";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXFWVER";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_DEVICETANAPANUM";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXDEVICETANAPANUM";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_FREQUENCYRANGE";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXFREQUENCYRANGE";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_LASTPROGRAMMEDDATETIME";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXLASTPROGRAMMEDDATETIME";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_LASTPROGRAMMEDSOURCE";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXLASTPROGRAMMEDSOURCE";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_TXBOARD";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
			a_ = "LBL_RXBOARD";
			this.aj.a(ref A_0, a_, 0, -1, out xmlNode);
			xmlNode.InnerText = string.Empty;
			xmlNode.Attributes["Applicable"].Value = "NA";
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0002DDD8 File Offset: 0x0002CDD8
		private void b(byte[] A_0, out global::System.Collections.ArrayList A_1)
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
			A_1 = null;
			try
			{
				for (;;)
				{
					int num = 0;
					int num2 = 1;
					int num3 = 4;
					int num4 = 2;
					int num5 = 2;
					int num6 = 2;
					byte[] array = new byte[num3];
					byte[] array2 = new byte[num4];
					byte[] array3 = new byte[num5];
					byte[] array4 = new byte[num6];
					num += num2;
					global::System.Array.Copy(A_0, num, array, 0, array.Length);
					int num7 = 0;
					int num8 = 0;
					this.aq.b(ref array, out num8);
					A_1 = new global::System.Collections.ArrayList();
					num += num3;
					int num9 = 0;
					int num10 = 2;
					for (;;)
					{
						switch (num10)
						{
						case 0:
							goto IL_D4;
						case 1:
							num10 = 3;
							continue;
						case 2:
							goto IL_D4;
						case 3:
							goto IL_1E9;
						case 4:
						{
							if (num9 >= num8)
							{
								num10 = 1;
								continue;
							}
							global::System.Array.Copy(A_0, num, array2, 0, array2.Length);
							this.aq.b(ref array2, out num7);
							global::cpservices.CData cdata;
							cdata.usISHType = (ushort)num7;
							num += array2.Length;
							global::System.Array.Copy(A_0, num, array3, 0, array3.Length);
							this.aq.b(ref array3, out num7);
							cdata.usISHID = (ushort)num7;
							num += array3.Length;
							global::System.Array.Copy(A_0, num, array4, 0, array4.Length);
							this.aq.b(ref array4, out num7);
							cdata.usDataLength = (ushort)num7;
							num += array4.Length;
							cdata.abtData = new byte[(int)cdata.usDataLength];
							global::System.Array.Copy(A_0, num, cdata.abtData, 0, (int)cdata.usDataLength);
							A_1.Add(cdata);
							num += (int)cdata.usDataLength;
							num9++;
							num10 = 0;
							continue;
						}
						}
						break;
						IL_D4:
						num10 = 4;
					}
				}
				IL_1E9:;
			}
			catch (global::custom_exception.CCustomException ex)
			{
				throw ex;
			}
			catch (global::System.Exception a_)
			{
				global::cpservices.c.a(a_);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0002E014 File Offset: 0x0002D014
		private void a(ref global::System.Xml.XmlNode A_0)
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
			this.a(ref A_0, "NA");
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0002E05C File Offset: 0x0002D05C
		private void a(ref global::System.Xml.XmlNode A_0, string A_1)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				int a_ = 0;
				this.a(ref A_0, A_1, a_);
			}
			catch (global::custom_exception.CCustomException ex)
			{
				throw ex;
			}
			catch (global::System.Exception a_2)
			{
				global::cpservices.c.a(a_2);
			}
			if (true)
			{
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0002E0CC File Offset: 0x0002D0CC
		private void a(ref global::System.Xml.XmlNode A_0, string A_1, int A_2)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				global::System.Xml.XmlDocument ownerDocument = A_0.OwnerDocument;
				global::System.Xml.XmlAttribute xmlAttribute = ownerDocument.CreateAttribute("Applicable");
				xmlAttribute.Value = A_1;
				A_0.Attributes.Append(xmlAttribute);
				global::System.Xml.XmlAttribute xmlAttribute2 = ownerDocument.CreateAttribute("ListID");
				xmlAttribute2.Value = global::System.Convert.ToString(A_2, 10);
				A_0.Attributes.Append(xmlAttribute2);
				A_0.InnerText = "";
			}
			catch (global::custom_exception.CCustomException ex)
			{
				throw ex;
			}
			catch (global::System.Exception a_)
			{
				global::cpservices.c.a(a_);
			}
			if (true)
			{
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0002E190 File Offset: 0x0002D190
		private void a(string A_0, out global::cpservices.h.a A_1)
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
			A_1 = default(global::cpservices.h.a);
			global::cpservices.c.a(A_1);
			try
			{
				for (;;)
				{
					global::System.Xml.XmlNode documentElement = this.am.DocumentElement;
					global::System.Xml.XmlNode xmlNode = documentElement.SelectSingleNode(A_0);
					int num = 5;
					for (;;)
					{
						switch (num)
						{
						case 0:
							A_1.g = true;
							num = 21;
							continue;
						case 1:
							goto IL_E4;
						case 2:
							if (xmlNode != null)
							{
								num = 20;
								continue;
							}
							goto IL_212;
						case 3:
							num = 6;
							continue;
						case 4:
							goto IL_3AD;
						case 5:
							if (xmlNode == null)
							{
								num = 14;
								continue;
							}
							A_1.a = xmlNode.Name;
							A_1.b = ushort.Parse(xmlNode["CPVAL"].InnerText, global::System.Globalization.NumberFormatInfo.InvariantInfo);
							A_1.c = xmlNode["STRUCTURE"].InnerText;
							num = 9;
							continue;
						case 6:
							if (xmlNode.Attributes["ListLetNeeded"].Value.Equals("1"))
							{
								num = 0;
								continue;
							}
							A_1.g = false;
							num = 12;
							continue;
						case 7:
							goto IL_3E8;
						case 8:
							goto IL_2B4;
						case 9:
							if (xmlNode["ACCESS"].InnerText.Equals("READONLY"))
							{
								num = 17;
								continue;
							}
							A_1.h = false;
							num = 8;
							continue;
						case 10:
							if (!A_1.d.Equals(string.Empty))
							{
								num = 15;
								continue;
							}
							goto IL_3DC;
						case 11:
							if (xmlNode.Attributes["AssociatedType"] != null)
							{
								num = 22;
								continue;
							}
							A_1.d = string.Empty;
							num = 18;
							continue;
						case 12:
							goto IL_E4;
						case 13:
							if (xmlNode.Attributes["ListLetNeeded"] != null)
							{
								num = 3;
								continue;
							}
							A_1.g = false;
							num = 1;
							continue;
						case 14:
							goto IL_DF;
						case 15:
							xmlNode = documentElement.SelectSingleNode(A_1.d);
							num = 2;
							continue;
						case 16:
							goto IL_2B4;
						case 17:
							A_1.h = true;
							num = 16;
							continue;
						case 18:
							goto IL_3AD;
						case 19:
							goto IL_3DC;
						case 20:
							A_1.f = xmlNode["STRUCTURE"].InnerText;
							A_1.e = ushort.Parse(xmlNode["CPVAL"].InnerText, global::System.Globalization.NumberFormatInfo.InvariantInfo);
							num = 19;
							continue;
						case 21:
							goto IL_E4;
						case 22:
							A_1.d = xmlNode.Attributes["AssociatedType"].Value;
							num = 4;
							continue;
						}
						break;
						IL_E4:
						num = 10;
						continue;
						IL_2B4:
						num = 11;
						continue;
						IL_3AD:
						num = 13;
						continue;
						IL_3DC:
						num = 7;
					}
				}
				IL_DF:
				global::custom_exception.CCustomException ex = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.NOTFOUNDINTYPEXML, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "GetStructureInfoByTypeIDString", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex;
				IL_212:
				global::custom_exception.CCustomException ex2 = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.NOTFOUNDINTYPEXML, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "GetStructureInfoByTypeIDString", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex2;
				IL_3E8:;
			}
			catch (global::custom_exception.CCustomException ex3)
			{
				throw ex3;
			}
			catch (global::System.Exception a_)
			{
				global::cpservices.c.a(a_);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0002E5D8 File Offset: 0x0002D5D8
		public void a(global::System.Collections.ArrayList A_0, global::System.Collections.ArrayList A_1, global::System.Collections.ArrayList A_2, out string A_3)
		{
			switch (0)
			{
			default:
				A_3 = null;
				try
				{
					for (;;)
					{
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.LoadXml("<UPDATES></UPDATES>");
						global::System.Xml.XmlDocument xmlDocument2 = new global::System.Xml.XmlDocument();
						int num = 0;
						int num2 = 1;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_113;
							case 1:
								goto IL_68;
							case 2:
								goto IL_113;
							case 3:
								goto IL_68;
							case 4:
								A_3 = xmlDocument.OuterXml;
								num2 = 5;
								continue;
							case 5:
								goto IL_194;
							case 6:
							{
								global::System.Xml.XmlNode xmlNode;
								if (xmlNode.ChildNodes.Count <= 0)
								{
									num2 = 8;
									continue;
								}
								xmlDocument.DocumentElement.AppendChild(xmlNode.ChildNodes[0]);
								num2 = 0;
								continue;
							}
							case 7:
							{
								if (num >= A_0.Count)
								{
									num2 = 4;
									continue;
								}
								xmlDocument.CreateNode(global::System.Xml.XmlNodeType.Element, (string)A_0[num], "");
								this.aj.b(A_0[num].ToString(), global::System.Convert.ToInt32(A_1[num], global::System.Globalization.NumberFormatInfo.InvariantInfo), global::System.Convert.ToInt32(A_2[num], global::System.Globalization.NumberFormatInfo.InvariantInfo), out xmlDocument2);
								global::System.Xml.XmlElement documentElement = xmlDocument2.DocumentElement;
								global::System.Xml.XmlNode xmlNode = xmlDocument.ImportNode(documentElement, true);
								num2 = 2;
								continue;
							}
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
									num++;
									num2 = 3;
									continue;
								}
								break;
							}
							break;
							IL_68:
							num2 = 7;
							continue;
							IL_113:
							num2 = 6;
						}
					}
					IL_194:;
				}
				catch (global::custom_exception.CCustomException ex)
				{
					throw ex;
				}
				catch (global::System.Exception a_)
				{
					global::cpservices.c.a(a_);
				}
				if (true)
				{
				}
				return;
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0002E7D4 File Offset: 0x0002D7D4
		private void a(ref global::System.Xml.XmlDocument A_0)
		{
			switch (0)
			{
			default:
			{
				int num = 6;
				for (;;)
				{
					string value;
					int num2;
					switch (num)
					{
					case 0:
						goto IL_AD;
					case 1:
						goto IL_14D;
					case 2:
						if (global::System.Convert.ToInt32(value) > global::System.Convert.ToInt32("2"))
						{
							num = 0;
							continue;
						}
						return;
					case 3:
						goto IL_B2;
					case 4:
						goto IL_B2;
					case 5:
						num = 2;
						continue;
					case 7:
						if (num2 >= value.Length)
						{
							num = 5;
							continue;
						}
						num = 8;
						continue;
					case 8:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14D;
						default:
							if (false)
							{
							}
							if (!char.IsDigit(value[num2]))
							{
								num = 9;
								continue;
							}
							num2++;
							num = 3;
							continue;
						}
						break;
					case 9:
						goto IL_11A;
					}
					if (true)
					{
					}
					if (A_0.DocumentElement.Attributes["TEMPLATEVERSION"] != null)
					{
						num = 1;
						continue;
					}
					goto IL_11F;
					IL_B2:
					num = 7;
					continue;
					IL_14D:
					value = A_0.DocumentElement.Attributes["TEMPLATEVERSION"].Value;
					num2 = 0;
					num = 4;
				}
				IL_AD:
				global::custom_exception.CCustomException ex = global::cpservices.c.a(1163U, base.GetType().ToString(), "CheckCPVersion", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex;
				IL_11A:
				global::custom_exception.CCustomException ex2 = global::cpservices.c.a(1163U, base.GetType().ToString(), "CheckCPVersion", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex2;
				IL_11F:
				global::custom_exception.CCustomException ex3 = global::cpservices.c.a(1163U, base.GetType().ToString(), "CheckCPVersion", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex3;
			}
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0002E9CC File Offset: 0x0002D9CC
		private global::System.Xml.XmlNode a(global::System.Xml.XmlNodeList A_0, string A_1)
		{
			switch (0)
			{
			default:
			{
				global::System.Xml.XmlNode result = null;
				try
				{
					for (;;)
					{
						string empty = string.Empty;
						int num = 0;
						int num2 = 0;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_58;
							case 1:
								goto IL_58;
							case 2:
								goto IL_FC;
							case 3:
								result = A_0[num];
								num2 = 6;
								continue;
							case 4:
								goto IL_108;
							case 5:
							{
								if (num >= A_0.Count)
								{
									num2 = 2;
									continue;
								}
								string value = A_0[num].Attributes["CPVER"].Value;
								num2 = 7;
								continue;
							}
							case 6:
								goto IL_FC;
							case 7:
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
									string value;
									if (this.a(value, A_1))
									{
										num2 = 3;
										continue;
									}
									break;
								}
								}
								num++;
								num2 = 1;
								continue;
							}
							break;
							IL_58:
							num2 = 5;
							continue;
							IL_FC:
							num2 = 4;
						}
					}
					IL_108:;
				}
				catch (global::custom_exception.CCustomException ex)
				{
					throw ex;
				}
				catch (global::System.Exception a_)
				{
					global::cpservices.c.a(a_);
				}
				if (true)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0002EB18 File Offset: 0x0002DB18
		public bool a(string A_0, string A_1)
		{
			switch (0)
			{
			default:
			{
				bool flag;
				for (;;)
				{
					flag = false;
					int num = 0;
					int num2 = -1;
					string a_ = string.Empty;
					int num3 = 3;
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (!flag)
							{
								num3 = 11;
								continue;
							}
							return flag;
						case 1:
							return flag;
						case 2:
							goto IL_7B;
						case 3:
							goto IL_7B;
						case 4:
							goto IL_5E;
						case 5:
							flag = true;
							num3 = 6;
							continue;
						case 6:
							goto IL_5E;
						case 7:
							if (A_0.IndexOf(',', num) == -1)
							{
								num3 = 4;
								continue;
							}
							num2 = A_0.IndexOf(',', num);
							a_ = A_0.Substring(num, num2 - num).Trim();
							num3 = 9;
							continue;
						case 8:
							flag = true;
							num3 = 1;
							continue;
						case 9:
							if (this.ao.a(a_, A_1))
							{
								num3 = 5;
								continue;
							}
							num = num2 + 1;
							num3 = 2;
							continue;
						case 10:
							goto IL_141;
						case 11:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_141;
							default:
								if (false)
								{
								}
								if (true)
								{
								}
								a_ = A_0.Substring(num).Trim();
								num3 = 10;
								continue;
							}
							break;
						}
						break;
						IL_5E:
						num3 = 0;
						continue;
						IL_7B:
						num3 = 7;
						continue;
						IL_141:
						if (!this.ao.a(a_, A_1))
						{
							return flag;
						}
						num3 = 8;
					}
				}
				return flag;
			}
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0002ECA8 File Offset: 0x0002DCA8
		private void a(byte[] A_0, out global::System.Collections.ArrayList A_1)
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
						goto IL_2E;
					}
					break;
				}
			}
			IL_2E:
			if (false)
			{
			}
			A_1 = null;
			try
			{
				int num = 3;
				for (;;)
				{
					int num2;
					int num3;
					int num4;
					byte[] array;
					int num5;
					int num6;
					switch (num)
					{
					case 0:
						goto IL_7F;
					case 1:
						num = 4;
						continue;
					case 2:
						if (num2 >= num3)
						{
							num = 1;
							continue;
						}
						global::System.Array.Copy(A_0, num4, array, 0, array.Length);
						this.aq.b(ref array, out num5);
						A_1.Add((ushort)num5);
						num4 += num6;
						num2++;
						num = 6;
						continue;
					case 4:
						goto IL_15C;
					case 5:
						goto IL_81;
					case 6:
						goto IL_81;
					}
					if (A_0.Length != A_0.Length / 2 * 2)
					{
						num = 0;
						continue;
					}
					num4 = 0;
					num6 = 2;
					num5 = 0;
					array = new byte[num6];
					A_1 = new global::System.Collections.ArrayList();
					num3 = A_0.Length / 2;
					num2 = 0;
					num = 5;
					continue;
					IL_81:
					num = 2;
				}
				IL_7F:
				global::custom_exception.CCustomException ex = global::cpservices.c.a(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.WRONG_ISH_TYPESET_DATA, global::System.Globalization.NumberFormatInfo.InvariantInfo), base.GetType().ToString(), "CvtISHTypeArray2ArrayList", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex;
				IL_15C:;
			}
			catch (global::custom_exception.CCustomException ex2)
			{
				throw ex2;
			}
			catch (global::System.Exception a_)
			{
				global::cpservices.c.a(a_);
			}
			if (true)
			{
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0002EE60 File Offset: 0x0002DE60
		private void a(string A_0, string A_1, ref bool A_2)
		{
			switch (0)
			{
			default:
			{
				int num = 0;
				for (;;)
				{
					bool flag;
					switch (num)
					{
					case 1:
						goto IL_49;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_49;
						default:
							goto IL_61;
						}
						break;
					case 3:
						if (!flag)
						{
							if (true)
							{
							}
							num = 2;
							continue;
						}
						goto IL_D4;
					}
					if (!A_1.Equals(""))
					{
						num = 1;
						continue;
					}
					goto IL_D4;
					IL_49:
					flag = this.ap.a(A_0, A_1, ref A_2);
					num = 3;
				}
				IL_61:
				if (false)
				{
				}
				global::custom_exception.CCustomException ex = global::cpservices.c.a(1089U, base.GetType().ToString(), "ChkFldAttributeDpd", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex;
				IL_D4:
				this.aj.f();
				global::System.Xml.XmlDocument xmlDocument = this.aj.r;
				global::System.Xml.XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode("//" + A_0);
				xmlNode.InnerXml = A_1;
				string outerXml = xmlNode.OuterXml;
				global::System.Xml.XmlDocument xmlDocument2 = new global::System.Xml.XmlDocument();
				global::System.Xml.XmlNode xmlNode2 = xmlDocument2.CreateElement("element", "UPDATES", string.Empty);
				xmlDocument2.AppendChild(xmlNode2);
				xmlNode2.InnerXml = outerXml;
				outerXml = xmlDocument2.OuterXml;
				return;
			}
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0002EFBC File Offset: 0x0002DFBC
		public void a(global::System.DateTime A_0, ref bool A_1)
		{
			while (this.at == "PHOENIX")
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
					string text = string.Empty;
					string a_ = "RAI_LPDY";
					string text2 = A_0.Year.ToString("D2");
					text += text2;
					this.a(a_, text2, ref A_1);
					a_ = "RAI_LPDM";
					text2 = A_0.Month.ToString("D2");
					text = text + "/" + text2;
					this.a(a_, text2, ref A_1);
					a_ = "RAI_LPDD";
					text2 = A_0.Day.ToString("D2");
					text = text + "/" + text2;
					this.a(a_, text2, ref A_1);
					a_ = "RAI_LPDH";
					text2 = A_0.Hour.ToString("D2");
					text = text + "/" + text2;
					this.a(a_, text2, ref A_1);
					a_ = "RAI_LPDMIN";
					text2 = A_0.Minute.ToString("D2");
					text = text + "/" + text2;
					this.a(a_, text2, ref A_1);
					a_ = "RI_LPGDATE";
					text2 = text;
					this.a(a_, text2, ref A_1);
					a_ = "RAI_LPS";
					text2 = "DEPOTTOOL";
					this.a(a_, text2, ref A_1);
					this.aj.c();
					return;
				}
				}
			}
			string text3 = string.Empty;
			string a_2 = "RI_LPGYEAR";
			string text4 = (A_0.Year - A_0.Year / 100 * 100).ToString("D2");
			text3 += text4;
			this.a(a_2, text4, ref A_1);
			a_2 = "RI_LPGMONTH";
			text4 = A_0.Month.ToString("D2");
			text3 = text3 + "/" + text4;
			this.a(a_2, text4, ref A_1);
			a_2 = "RI_LPGDAY";
			text4 = A_0.Day.ToString("D2");
			text3 = text3 + "/" + text4;
			this.a(a_2, text4, ref A_1);
			a_2 = "RI_LPGHOUR";
			text4 = A_0.Hour.ToString("D2");
			text3 = text3 + "/" + text4;
			this.a(a_2, text4, ref A_1);
			a_2 = "RI_LPGMINUTES";
			text4 = A_0.Minute.ToString("D2");
			text3 = text3 + "/" + text4;
			this.a(a_2, text4, ref A_1);
			a_2 = "RI_LPGDATE";
			text4 = text3;
			this.a(a_2, text4, ref A_1);
			a_2 = "RI_LPGSOURCE";
			text4 = "DEPOTTOOL";
			this.a(a_2, text4, ref A_1);
			this.aj.c();
		}

		// Token: 0x0400015F RID: 351
		private const byte a = 128;

		// Token: 0x04000160 RID: 352
		private const string b = "APP_PARTITION";

		// Token: 0x04000161 RID: 353
		private const string c = "SECURITY_PARTITION";

		// Token: 0x04000162 RID: 354
		private const string d = "CS_PARTITION";

		// Token: 0x04000163 RID: 355
		private const string e = "DeviceInfo";

		// Token: 0x04000164 RID: 356
		private const string f = "ReadDevice";

		// Token: 0x04000165 RID: 357
		private const string g = "<LTD_CODEPLUG></LTD_CODEPLUG>";

		// Token: 0x04000166 RID: 358
		private const string h = "ListID";

		// Token: 0x04000167 RID: 359
		private const string i = "CS_INFO_TYPE";

		// Token: 0x04000168 RID: 360
		private const string j = "RS_FWVER";

		// Token: 0x04000169 RID: 361
		private const string k = "CS_FWVER";

		// Token: 0x0400016A RID: 362
		private const string l = "";

		// Token: 0x0400016B RID: 363
		private const string m = "CPVAL";

		// Token: 0x0400016C RID: 364
		private const string n = "STRUCTURE";

		// Token: 0x0400016D RID: 365
		private const string o = "READONLY";

		// Token: 0x0400016E RID: 366
		private const string p = "AssociatedType";

		// Token: 0x0400016F RID: 367
		private const string q = "ListLetNeeded";

		// Token: 0x04000170 RID: 368
		private const string r = "ACCESS";

		// Token: 0x04000171 RID: 369
		private const string s = "1";

		// Token: 0x04000172 RID: 370
		private const string t = "0";

		// Token: 0x04000173 RID: 371
		private const string u = "D2";

		// Token: 0x04000174 RID: 372
		private const string v = "X2";

		// Token: 0x04000175 RID: 373
		private const string w = "F2_SIGNALS";

		// Token: 0x04000176 RID: 374
		private const string x = "ERRORLOG_DLH_TYPE";

		// Token: 0x04000177 RID: 375
		private const string y = "DEPOTTOOL";

		// Token: 0x04000178 RID: 376
		private const string z = "CheckCPVersion";

		// Token: 0x04000179 RID: 377
		private const int aa = 1;

		// Token: 0x0400017A RID: 378
		private const int ab = 0;

		// Token: 0x0400017B RID: 379
		private const int ac = 0;

		// Token: 0x0400017C RID: 380
		private const string ad = "QUERYRADIOSERIALNUMBER";

		// Token: 0x0400017D RID: 381
		private const string ae = "QUERYREPEATERSERIALNUMBER";

		// Token: 0x0400017E RID: 382
		private const string af = "QUERYRADIOSOFTWAREVERSION";

		// Token: 0x0400017F RID: 383
		private const string ag = "MODEL_TYPE";

		// Token: 0x04000180 RID: 384
		public const string ah = "HAVNCPSLTDTUNERAIRTRACER";

		// Token: 0x04000181 RID: 385
		public const string ai = "VEDKDJSP";

		// Token: 0x04000182 RID: 386
		internal global::cpservices.f aj;

		// Token: 0x04000183 RID: 387
		internal global::System.Xml.XmlDocument ak;

		// Token: 0x04000184 RID: 388
		private global::cpservices.CDeviceInfo al;

		// Token: 0x04000185 RID: 389
		private global::System.Xml.XmlDocument am;

		// Token: 0x04000186 RID: 390
		private global::System.Xml.XmlDocument an;

		// Token: 0x04000187 RID: 391
		private global::cpservices.d ao;

		// Token: 0x04000188 RID: 392
		private global::cpservices.e ap;

		// Token: 0x04000189 RID: 393
		public global::cpservices.a aq;

		// Token: 0x0400018A RID: 394
		private global::cpservices.d ar;

		// Token: 0x0400018B RID: 395
		private string @as;

		// Token: 0x0400018C RID: 396
		private string at;

		// Token: 0x0200001A RID: 26
		public struct a
		{
			// Token: 0x0400018D RID: 397
			public string a;

			// Token: 0x0400018E RID: 398
			public ushort b;

			// Token: 0x0400018F RID: 399
			public string c;

			// Token: 0x04000190 RID: 400
			public string d;

			// Token: 0x04000191 RID: 401
			public ushort e;

			// Token: 0x04000192 RID: 402
			public string f;

			// Token: 0x04000193 RID: 403
			public bool g;

			// Token: 0x04000194 RID: 404
			public bool h;
		}
	}
}
