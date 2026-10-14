using System;
using System.Globalization;
using System.Xml;
using custom_exception;
using xml_handler;

namespace custom_controls
{
	// Token: 0x02000094 RID: 148
	public class CSearchEngine
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0005AE58 File Offset: 0x00059058
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x0005AE9C File Offset: 0x0005909C
		public string SearchValue
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
				return this.h;
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
				this.h = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0005AEE0 File Offset: 0x000590E0
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x0005AF24 File Offset: 0x00059124
		public bool SearchExact
		{
			get
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
				return this.i;
			}
			set
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
				this.i = value;
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0005AF68 File Offset: 0x00059168
		public CSearchEngine()
		{
			this.h = string.Empty;
			this.j = new global::System.Xml.XmlDocument();
			this.i = false;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0005AF98 File Offset: 0x00059198
		private void a(string A_0)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.j.LoadXml(A_0);
			}
			catch (global::System.Exception ex)
			{
				ex.Source = 1625U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0005B024 File Offset: 0x00059224
		public global::System.Xml.XmlNodeList FindItem(string searchContentXml, string searchText)
		{
			switch (0)
			{
			default:
			{
				int num = 3;
				string text;
				global::xml_handler.CCustomContext ccustomContext;
				global::System.Xml.XmlNodeList result;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_8A;
					case 1:
						text = "//SEARCH_XML[s:equals(., \"%1\")]";
						num = 2;
						continue;
					case 2:
						goto IL_59;
					case 4:
						goto IL_59;
					}
					if (this.i)
					{
						if (true)
						{
						}
						num = 1;
						continue;
					}
					text = "//SEARCH_XML[s:contains(., \"%1\")]";
					num = 4;
					continue;
					IL_59:
					ccustomContext = new global::xml_handler.CCustomContext((global::System.Xml.NameTable)this.j.NameTable);
					ccustomContext.AddNamespace("s", "http://cps.local/");
					result = null;
					num = 0;
				}
				IL_8A:
				goto IL_B4;
				try
				{
					for (;;)
					{
						IL_B4:
						for (;;)
						{
							this.h = searchText;
							this.a(searchContentXml);
							global::System.Xml.XmlNode documentElement = this.j.DocumentElement;
							num = 5;
							for (;;)
							{
								switch (num)
								{
								case 0:
								{
									string xpath = text.Replace("%1", searchText);
									result = documentElement.SelectNodes(xpath, ccustomContext);
									num = 4;
									continue;
								}
								case 1:
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
										int num2 = searchText.IndexOf("\"", global::System.StringComparison.Ordinal);
										num = 2;
										continue;
									}
									}
									break;
								case 2:
								{
									int num2;
									if (num2 < 0)
									{
										num = 0;
										continue;
									}
									goto IL_172;
								}
								case 3:
									goto IL_17E;
								case 4:
									goto IL_172;
								case 5:
									if (searchText != null)
									{
										num = 1;
										continue;
									}
									goto IL_172;
								}
								break;
								IL_172:
								num = 3;
							}
						}
					}
					IL_17E:;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.Exception ex)
				{
					global::custom_exception.CCustomException.Rethrow(ex);
				}
				return result;
			}
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0005B1DC File Offset: 0x000593DC
		public static string FormatDateTime(string cpDate)
		{
			switch (0)
			{
			default:
			{
				string result;
				for (;;)
				{
					result = string.Empty;
					char[] separator = "/".ToCharArray();
					string[] array = cpDate.Split(separator);
					int num = 2;
					for (;;)
					{
						int num2;
						int num3;
						int num4;
						switch (num)
						{
						case 0:
							goto IL_BE;
						case 1:
							if (num2 == 0)
							{
								num = 9;
								continue;
							}
							goto IL_1B9;
						case 2:
							if (array.Length == 5)
							{
								num = 3;
								continue;
							}
							return result;
						case 3:
						{
							global::System.DateTime now = global::System.DateTime.Now;
							string text = now.Year.ToString("0000", global::System.Globalization.CultureInfo.InvariantCulture);
							num = 6;
							continue;
						}
						case 4:
							goto IL_8E;
						case 5:
							goto IL_1B9;
						case 6:
						{
							string text;
							if (array[0].Length < text.Length)
							{
								num = 7;
								continue;
							}
							goto IL_22B;
						}
						case 7:
						{
							string text;
							array[0] = text.Substring(0, text.Length - array[0].Length) + array[0];
							num = 13;
							continue;
						}
						case 8:
						{
							global::System.DateTime now;
							num3 = now.Month;
							goto IL_1A8;
						}
						case 9:
						{
							global::System.DateTime now;
							num2 = now.Day;
							num = 5;
							continue;
						}
						case 10:
							return result;
						case 11:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1A8;
							default:
								if (false)
								{
								}
								if (num4 == 0)
								{
									num = 14;
									continue;
								}
								goto IL_BE;
							}
							break;
						case 12:
							if (num3 == 0)
							{
								num = 8;
								continue;
							}
							goto IL_8E;
						case 13:
							goto IL_22B;
						case 14:
						{
							global::System.DateTime now;
							num4 = now.Year;
							num = 0;
							continue;
						}
						}
						break;
						IL_8E:
						num2 = global::System.Convert.ToInt32(array[2], global::System.Globalization.CultureInfo.InvariantCulture);
						num = 1;
						continue;
						IL_BE:
						if (true)
						{
						}
						num3 = global::System.Convert.ToInt32(array[1], global::System.Globalization.CultureInfo.InvariantCulture);
						num = 12;
						continue;
						IL_1A8:
						num = 4;
						continue;
						IL_1B9:
						int hour = global::System.Convert.ToInt32(array[3], global::System.Globalization.CultureInfo.InvariantCulture);
						int minute = global::System.Convert.ToInt32(array[4], global::System.Globalization.CultureInfo.InvariantCulture);
						global::System.DateTime dateTime = new global::System.DateTime(num4, num3, num2, hour, minute, 0, 0);
						result = dateTime.ToShortDateString() + " " + dateTime.ToShortTimeString();
						num = 10;
						continue;
						IL_22B:
						num4 = global::System.Convert.ToInt32(array[0], global::System.Globalization.CultureInfo.InvariantCulture);
						num = 11;
					}
				}
				return result;
			}
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0005B464 File Offset: 0x00059664
		public static string FormatOctal(string octVal, string length)
		{
			switch (0)
			{
			default:
			{
				string text;
				for (;;)
				{
					text = octVal;
					int num;
					int.TryParse(length, out num);
					string text2 = null;
					int num2 = 0;
					int num3 = 6;
					for (;;)
					{
						switch (num3)
						{
						case 0:
							text = text.Insert(0, text2);
							num3 = 2;
							continue;
						case 1:
							num3 = 4;
							continue;
						case 2:
							return text;
						case 3:
							if (num2 >= num - text.Length)
							{
								num3 = 1;
								continue;
							}
							if (true)
							{
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								return text;
							default:
								if (false)
								{
								}
								text2 += "0";
								num2++;
								num3 = 5;
								continue;
							}
							break;
						case 4:
							if (text2 != null)
							{
								num3 = 0;
								continue;
							}
							return text;
						case 5:
							goto IL_67;
						case 6:
							goto IL_67;
						}
						break;
						IL_67:
						num3 = 3;
					}
				}
				return text;
			}
			}
		}

		// Token: 0x040004AB RID: 1195
		private const string a = "//SEARCH_XML[s:contains(., \"%1\")]";

		// Token: 0x040004AC RID: 1196
		private const string b = "//SEARCH_XML[s:equals(., \"%1\")]";

		// Token: 0x040004AD RID: 1197
		public const string REPLACE_CHAR = "%1";

		// Token: 0x040004AE RID: 1198
		public const string DOUBLE_QUOTES = "\"";

		// Token: 0x040004AF RID: 1199
		private const string c = "|";

		// Token: 0x040004B0 RID: 1200
		private const string d = "s";

		// Token: 0x040004B1 RID: 1201
		private const string e = "/";

		// Token: 0x040004B2 RID: 1202
		private const string f = "0000";

		// Token: 0x040004B3 RID: 1203
		private const string g = " ";

		// Token: 0x040004B4 RID: 1204
		private string h;

		// Token: 0x040004B5 RID: 1205
		private bool i;

		// Token: 0x040004B6 RID: 1206
		private global::System.Xml.XmlDocument j;
	}
}
