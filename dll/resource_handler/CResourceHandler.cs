using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;
using custom_exception;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;
using xml_handler;

namespace resource_handler
{
	// Token: 0x02000009 RID: 9
	public class CResourceHandler : global::resource_handler.IResource
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00005664 File Offset: 0x00004664
		public CResourceHandler(string[] resourceFileNames, bool mirrored)
		{
			try
			{
				this.ae = new global::System.Data.DataSet("Resource_DataSet");
				foreach (string text in resourceFileNames)
				{
					if (!global::System.IO.File.Exists(text))
					{
						global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(2627U, "Resource Handler", base.GetType().ToString() + ", CResourceHandler", global::System.Environment.StackTrace.ToString());
						throw ex;
					}
					this.ad = mirrored;
					string empty = string.Empty;
					global::c.a(text, ref empty, false, global::c.c.d);
					global::c.b b = global::c.a(global::c.a.b, ref empty);
					if (b != global::c.b.c)
					{
						global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(1835U, base.GetType().ToString(), "CResourceHandler", global::System.Environment.StackTrace.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
						throw ex2;
					}
					global::System.IO.StringReader stringReader = null;
					try
					{
						stringReader = new global::System.IO.StringReader(empty);
						using (global::System.Xml.XmlTextReader xmlTextReader = new global::System.Xml.XmlTextReader(stringReader))
						{
							stringReader = null;
							this.ae.ReadXml(xmlTextReader);
						}
						goto IL_23;
					}
					finally
					{
						if (stringReader != null)
						{
							stringReader.Dispose();
						}
					}
					continue;
					IL_23:;
				}
				this.af = new global::System.Data.DataView(this.ae.Tables["data"], "", "name", global::System.Data.DataViewRowState.CurrentRows);
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex3)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
				{
					ex3.Source = 2625U.ToString() + "|" + ex3.Source;
				}
				global::custom_exception.CCustomException.Rethrow(ex3);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005864 File Offset: 0x00004864
		public object GetObject(string fieldId)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				object result = null;
				try
				{
					for (;;)
					{
						string text = string.Empty;
						string text2 = string.Empty;
						int num = this.af.Find(fieldId);
						int num2 = 3;
						for (;;)
						{
							global::System.IO.MemoryStream memoryStream;
							switch (num2)
							{
							case 0:
								goto IL_E4;
								try
								{
									for (;;)
									{
										IL_E4:
										num2 = 3;
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_19C;
											case 1:
											{
												new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
												global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap((global::System.Drawing.Bitmap)global::System.Drawing.Image.FromStream(memoryStream));
												result = bitmap;
												num2 = 2;
												continue;
											}
											case 2:
												goto IL_190;
											case 4:
												goto IL_190;
											}
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_E4;
											default:
											{
												if (false)
												{
												}
												if (!text.Equals(string.Empty))
												{
													num2 = 1;
													continue;
												}
												global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
												global::System.Windows.Forms.ImageListStreamer imageListStreamer = (global::System.Windows.Forms.ImageListStreamer)binaryFormatter.Deserialize(memoryStream);
												result = imageListStreamer;
												num2 = 4;
												continue;
											}
											}
											IL_190:
											num2 = 0;
										}
									}
									IL_19C:;
								}
								finally
								{
									num2 = 0;
									for (;;)
									{
										switch (num2)
										{
										case 1:
											goto IL_1DB;
										case 2:
											((global::System.IDisposable)memoryStream).Dispose();
											num2 = 1;
											continue;
										}
										if (memoryStream == null)
										{
											break;
										}
										num2 = 2;
									}
									IL_1DB:;
								}
								num2 = 1;
								continue;
							case 1:
								goto IL_1EA;
							case 2:
								goto IL_B8;
							case 3:
								if (num != -1)
								{
									num2 = 4;
									continue;
								}
								goto IL_B8;
							case 4:
								text = this.af[num]["type"].ToString();
								text2 = this.af[num]["value"].ToString();
								num2 = 2;
								continue;
							}
							break;
							IL_B8:
							byte[] buffer = new byte[text2.Length];
							buffer = global::System.Convert.FromBase64String(text2);
							memoryStream = new global::System.IO.MemoryStream(buffer);
							num2 = 0;
						}
					}
					IL_1EA:;
				}
				catch (global::System.Exception ex)
				{
					if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
					{
						ex.Source = 2626U.ToString() + "|" + ex.Source;
					}
					global::custom_exception.CCustomException.Rethrow(ex);
				}
				return result;
			}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005AD0 File Offset: 0x00004AD0
		public string GetString(string fieldId)
		{
			string result;
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
				result = string.Empty;
				try
				{
					int num = 6;
					for (;;)
					{
						string text;
						int num2;
						switch (num)
						{
						case 0:
							goto IL_13A;
						case 1:
							num = 5;
							continue;
						case 2:
							goto IL_145;
						case 3:
							text = string.Empty;
							goto IL_11A;
						case 4:
							result = this.af[num2]["value"].ToString();
							num = 8;
							continue;
						case 5:
						{
							string commonErrorMessageByID;
							text = commonErrorMessageByID;
							goto IL_11A;
						}
						case 7:
							if (num2 != -1)
							{
								num = 4;
								continue;
							}
							goto IL_13A;
						case 8:
							goto IL_13A;
						case 9:
						{
							string commonErrorMessageByID = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(fieldId, null);
							num = 10;
							continue;
						}
						case 10:
						{
							string commonErrorMessageByID;
							if (!(commonErrorMessageByID == fieldId))
							{
								num = 1;
								continue;
							}
							num = 3;
							continue;
						}
						}
						if (global::System.Enum.IsDefined(typeof(global::Motorola.Common.CustomException.CommonErrorCode), fieldId))
						{
							num = 9;
							continue;
						}
						string empty = string.Empty;
						num2 = this.af.Find(fieldId);
						num = 7;
						continue;
						IL_11A:
						result = text;
						num = 0;
						continue;
						IL_13A:
						num = 2;
					}
					IL_145:;
				}
				catch (global::System.Exception)
				{
					result = string.Empty;
				}
				break;
			}
			return result;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00005C4C File Offset: 0x00004C4C
		public string GetControlWidth(string fieldId)
		{
			string result = string.Empty;
			goto IL_08;
			try
			{
				for (;;)
				{
					IL_08:
					for (;;)
					{
						string empty = string.Empty;
						int num = this.af.Find(fieldId);
						int num2 = 1;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_77;
							case 1:
								if (num != -1)
								{
									num2 = 2;
									continue;
								}
								goto IL_6F;
							case 2:
								result = this.af[num]["controlwidth"].ToString();
								num2 = 3;
								continue;
							case 3:
								goto IL_6F;
							}
							break;
							IL_6F:
							num2 = 0;
						}
					}
					IL_77:
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
				if (false)
				{
				}
			}
			catch (global::System.Exception)
			{
				result = string.Empty;
			}
			if (true)
			{
			}
			return result;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005D1C File Offset: 0x00004D1C
		public string GetControlHeight(string fieldId)
		{
			string result = string.Empty;
			try
			{
				for (;;)
				{
					string empty = string.Empty;
					int num = this.af.Find(fieldId);
					int num2;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						num2 = 2;
						break;
					}
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_8B;
						case 1:
							goto IL_96;
						case 2:
							if (num != -1)
							{
								num2 = 3;
								continue;
							}
							goto IL_8B;
						case 3:
							result = this.af[num]["controlheight"].ToString();
							num2 = 0;
							continue;
						}
						break;
						IL_8B:
						num2 = 1;
					}
				}
				IL_96:;
			}
			catch (global::System.Exception)
			{
				result = string.Empty;
			}
			if (true)
			{
			}
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005DF0 File Offset: 0x00004DF0
		public string GetLabelWidth(string fieldId)
		{
			string result;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (false)
				{
				}
				result = string.Empty;
				try
				{
					for (;;)
					{
						string empty = string.Empty;
						int num = this.af.Find(fieldId);
						if (true)
						{
						}
						int num2 = 2;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								result = this.af[num]["labelwidth"].ToString();
								num2 = 3;
								continue;
							case 1:
								goto IL_A5;
							case 2:
								if (num != -1)
								{
									num2 = 0;
									continue;
								}
								goto IL_9D;
							case 3:
								goto IL_9D;
							}
							break;
							IL_9D:
							num2 = 1;
						}
					}
					IL_A5:;
				}
				catch (global::System.Exception)
				{
					result = string.Empty;
				}
				break;
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005EC0 File Offset: 0x00004EC0
		public string GetLabelHeight(string fieldId)
		{
			string result;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			}
			if (true)
			{
			}
			if (false)
			{
			}
			result = string.Empty;
			try
			{
				for (;;)
				{
					string empty = string.Empty;
					int num = this.af.Find(fieldId);
					int num2 = 0;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (num != -1)
							{
								num2 = 1;
								continue;
							}
							goto IL_9D;
						case 1:
							result = this.af[num]["labelheight"].ToString();
							num2 = 2;
							continue;
						case 2:
							goto IL_9D;
						case 3:
							goto IL_A5;
						}
						break;
						IL_9D:
						num2 = 3;
					}
				}
				IL_A5:;
			}
			catch (global::System.Exception)
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005F90 File Offset: 0x00004F90
		public string GetSpacer(string fieldId)
		{
			string result;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (false)
				{
				}
				result = string.Empty;
				try
				{
					for (;;)
					{
						if (true)
						{
						}
						string empty = string.Empty;
						int num = this.af.Find(fieldId);
						int num2 = 2;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								result = this.af[num]["spacer"].ToString();
								num2 = 3;
								continue;
							case 1:
								goto IL_A5;
							case 2:
								if (num != -1)
								{
									num2 = 0;
									continue;
								}
								goto IL_9D;
							case 3:
								goto IL_9D;
							}
							break;
							IL_9D:
							num2 = 1;
						}
					}
					IL_A5:;
				}
				catch (global::System.Exception)
				{
					result = string.Empty;
				}
				break;
			}
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00006060 File Offset: 0x00005060
		public string GetToolTip(string fieldId)
		{
			string result;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (false)
				{
				}
				result = string.Empty;
				try
				{
					for (;;)
					{
						string empty = string.Empty;
						int num = this.af.Find(fieldId);
						int num2 = 1;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_95;
							case 1:
								if (num != -1)
								{
									num2 = 2;
									continue;
								}
								goto IL_95;
							case 2:
								result = this.af[num]["tooltip"].ToString();
								num2 = 0;
								continue;
							case 3:
								goto IL_9D;
							}
							break;
							IL_95:
							num2 = 3;
						}
					}
					IL_9D:;
				}
				catch (global::System.Exception)
				{
					result = string.Empty;
				}
				break;
			}
			if (true)
			{
			}
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00006130 File Offset: 0x00005130
		public string GetColumnWidth(string fieldId)
		{
			string result = string.Empty;
			try
			{
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_93:
					num = 3;
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
					IL_26:
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						goto IL_91;
					case 1:
						result = this.af[num2]["columnwidth"].ToString();
						num = 0;
						continue;
					case 2:
						if (num2 != -1)
						{
							num = 1;
							continue;
						}
						goto IL_93;
					case 3:
						goto IL_9B;
					}
					goto IL_44;
				}
				IL_91:
				goto IL_93;
				IL_9B:
				return result;
				IL_44:
				string empty = string.Empty;
				num2 = this.af.Find(fieldId);
				num = 2;
				goto IL_26;
			}
			catch (global::System.Exception)
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00006200 File Offset: 0x00005200
		public global::System.Collections.Hashtable SearchResValues(string searchText, bool searchExact)
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
				}
				break;
			}
			global::System.Collections.Hashtable hashtable = new global::System.Collections.Hashtable();
			try
			{
				string xml = this.ae.GetXml();
				global::System.IO.StringReader stringReader = new global::System.IO.StringReader(xml);
				try
				{
					for (;;)
					{
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(stringReader);
						global::xml_handler.CCustomContext ccustomContext = new global::xml_handler.CCustomContext((global::System.Xml.NameTable)xmlDocument.NameTable);
						ccustomContext.AddNamespace("s", "http://cps.local/");
						int num = 4;
						for (;;)
						{
							global::System.Xml.XmlNodeList xmlNodeList;
							int num2;
							string newValue;
							switch (num)
							{
							case 0:
								goto IL_20B;
							case 1:
								if (xmlNodeList[num2].Attributes["type"] != null)
								{
									num = 17;
									continue;
								}
								goto IL_20B;
							case 2:
								num = 5;
								continue;
							case 3:
								if (xmlNodeList[num2].FirstChild.Name.Equals("value"))
								{
									num = 19;
									continue;
								}
								goto IL_20B;
							case 4:
								if (searchExact)
								{
									num = 12;
									continue;
								}
								newValue = "[s:contains(., \"%1\")]";
								num = 9;
								continue;
							case 5:
								if (xmlNodeList[num2].FirstChild.HasChildNodes)
								{
									num = 13;
									continue;
								}
								goto IL_20B;
							case 6:
								goto IL_15C;
							case 7:
								if (xmlNodeList[num2].Attributes["name"].Value != null)
								{
									num = 2;
									continue;
								}
								goto IL_20B;
							case 8:
								num = 1;
								continue;
							case 9:
								goto IL_1C9;
							case 10:
								num = 21;
								continue;
							case 11:
								goto IL_15C;
							case 12:
								newValue = "[s:equals(., \"%1\")]";
								num = 15;
								continue;
							case 13:
								num = 3;
								continue;
							case 14:
								if (xmlNodeList[num2]["tooltip"] != null)
								{
									num = 8;
									continue;
								}
								goto IL_222;
							case 15:
								goto IL_1C9;
							case 16:
								if (num2 >= xmlNodeList.Count)
								{
									num = 10;
									continue;
								}
								num = 7;
								continue;
							case 17:
								goto IL_222;
							case 18:
								if (!hashtable.ContainsKey(xmlNodeList[num2].Attributes["name"].Value))
								{
									num = 20;
									continue;
								}
								goto IL_20B;
							case 19:
								num = 18;
								continue;
							case 20:
								num = 14;
								continue;
							case 21:
								goto IL_375;
							}
							break;
							IL_15C:
							num = 16;
							continue;
							IL_1C9:
							string text = "//data[value%2 and not(@mimetype) and not(controlwidth)]".Replace("%2", newValue);
							text = text.Replace("%1", searchText);
							xmlNodeList = xmlDocument.SelectNodes(text, ccustomContext);
							num2 = 0;
							num = 6;
							continue;
							IL_20B:
							num2++;
							num = 11;
							continue;
							IL_222:
							hashtable.Add(xmlNodeList[num2].Attributes["name"].Value, xmlNodeList[num2].ChildNodes[0].InnerText);
							num = 0;
						}
					}
					IL_375:;
				}
				finally
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_3B2;
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
					IL_3B2:;
				}
			}
			catch (global::System.Exception)
			{
				hashtable = null;
			}
			return hashtable;
		}

		// Token: 0x0400002E RID: 46
		private const string a = "data";

		// Token: 0x0400002F RID: 47
		private const string b = "name";

		// Token: 0x04000030 RID: 48
		private const string c = "[@";

		// Token: 0x04000031 RID: 49
		private const string d = "='";

		// Token: 0x04000032 RID: 50
		private const string e = "']";

		// Token: 0x04000033 RID: 51
		private const string f = "controlwidth";

		// Token: 0x04000034 RID: 52
		private const string g = "controlheight";

		// Token: 0x04000035 RID: 53
		private const string h = "labelwidth";

		// Token: 0x04000036 RID: 54
		private const string i = "labelheight";

		// Token: 0x04000037 RID: 55
		private const string j = "value";

		// Token: 0x04000038 RID: 56
		private const string k = "spacer";

		// Token: 0x04000039 RID: 57
		private const string l = "type";

		// Token: 0x0400003A RID: 58
		private const string m = "tooltip";

		// Token: 0x0400003B RID: 59
		private const string n = "columnwidth";

		// Token: 0x0400003C RID: 60
		private const string o = "ResourceHandler";

		// Token: 0x0400003D RID: 61
		private const string p = "//";

		// Token: 0x0400003E RID: 62
		private const string q = "HAVNCPSLTDTUNERAIRTRACER";

		// Token: 0x0400003F RID: 63
		private const string r = "VEDKDJSP";

		// Token: 0x04000040 RID: 64
		private const string s = "|";

		// Token: 0x04000041 RID: 65
		private const string t = "Resource Handler";

		// Token: 0x04000042 RID: 66
		private const string u = ", ";

		// Token: 0x04000043 RID: 67
		private const string v = "name";

		// Token: 0x04000044 RID: 68
		private const string w = "value";

		// Token: 0x04000045 RID: 69
		private const string x = "[s:contains(., \"%1\")]";

		// Token: 0x04000046 RID: 70
		private const string y = "[s:equals(., \"%1\")]";

		// Token: 0x04000047 RID: 71
		private const string z = "s";

		// Token: 0x04000048 RID: 72
		private const string aa = "%1";

		// Token: 0x04000049 RID: 73
		private const string ab = "%2";

		// Token: 0x0400004A RID: 74
		private const string ac = "//data[value%2 and not(@mimetype) and not(controlwidth)]";

		// Token: 0x0400004B RID: 75
		private bool ad;

		// Token: 0x0400004C RID: 76
		private global::System.Data.DataSet ae;

		// Token: 0x0400004D RID: 77
		private global::System.Data.DataView af;
	}
}
