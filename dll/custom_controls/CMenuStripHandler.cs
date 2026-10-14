using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using custom_exception;
using resource_handler;

namespace custom_controls
{
	// Token: 0x0200006B RID: 107
	public class CMenuStripHandler : global::System.IDisposable
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x000461F4 File Offset: 0x000443F4
		public global::System.Collections.Generic.LinkedList<global::custom_controls.CMenuStripItem> MenuItems
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
				return this.e;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00046238 File Offset: 0x00044438
		public global::System.Collections.Generic.LinkedList<global::custom_controls.CSeparator> MenuSeparators
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
				return this.c;
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0004627C File Offset: 0x0004447C
		public CMenuStripHandler(string menuXmlFile, global::System.Windows.Forms.MenuStrip ms, global::resource_handler.CResourceHandler resHandler)
		{
			if (!string.IsNullOrEmpty(menuXmlFile) && ms != null)
			{
				if (resHandler != null)
				{
					this.d = resHandler;
					this.b(menuXmlFile);
					this.a(ms, 0);
					return;
				}
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000462BC File Offset: 0x000444BC
		public CMenuStripHandler(string menuXmlFile, global::System.Windows.Forms.MenuStrip ms, global::resource_handler.CResourceHandler resHandler, int dbType)
		{
			if (!string.IsNullOrEmpty(menuXmlFile) && ms != null)
			{
				if (resHandler != null)
				{
					this.d = resHandler;
					this.b(menuXmlFile);
					this.a(ms, dbType);
					return;
				}
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000462FC File Offset: 0x000444FC
		public void Dispose()
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
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00046344 File Offset: 0x00044544
		protected virtual void Dispose(bool disposing)
		{
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.CleanUPMembers();
					goto IL_3C;
				case 1:
					goto IL_44;
				case 2:
					if (!disposing)
					{
						goto IL_7F;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3C;
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
				case 3:
					num = 2;
					continue;
				}
				if (!this.g)
				{
					num = 3;
					continue;
				}
				break;
				IL_3C:
				num = 1;
			}
			IL_44:
			IL_7F:
			this.g = true;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000463E4 File Offset: 0x000445E4
		protected override void Finalize()
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				base.Finalize();
			}
			if (true)
			{
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00046440 File Offset: 0x00044640
		public void CleanUPMembers()
		{
			int num = 21;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.commandMgmt.Dictionary.Clear();
					num = 10;
					continue;
				case 1:
					this.e.Clear();
					this.e = null;
					num = 18;
					continue;
				case 2:
					if (this.commandMgmt.Dictionary.Count > 0)
					{
						num = 0;
						continue;
					}
					goto IL_196;
				case 3:
					this.a = null;
					num = 20;
					continue;
				case 4:
					num = 2;
					continue;
				case 5:
					if (this.e != null)
					{
						num = 1;
						continue;
					}
					goto IL_D4;
				case 6:
					goto IL_1E4;
				case 7:
					goto IL_248;
				case 8:
					this.c.Clear();
					this.c = null;
					num = 7;
					continue;
				case 9:
				{
					global::System.Collections.Generic.LinkedList<global::custom_controls.ToolStripIPAddressComboBox>.Enumerator enumerator = this.f.GetEnumerator();
					num = 19;
					continue;
				}
				case 10:
					goto IL_196;
				case 11:
					if (this.c != null)
					{
						num = 8;
						continue;
					}
					goto IL_248;
				case 12:
					goto IL_1DF;
				case 13:
					if (this.b != null)
					{
						num = 14;
						continue;
					}
					goto IL_1E4;
				case 14:
					this.b = null;
					num = 6;
					continue;
				case 15:
					if (this.commandMgmt != null)
					{
						num = 4;
						continue;
					}
					goto IL_80;
				case 16:
					if (this.f != null)
					{
						num = 9;
						continue;
					}
					goto IL_2D5;
				case 17:
					goto IL_80;
				case 18:
					goto IL_D4;
				case 19:
					try
					{
						num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								num = 3;
								continue;
							case 1:
							{
								global::System.Collections.Generic.LinkedList<global::custom_controls.ToolStripIPAddressComboBox>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = 0;
									continue;
								}
								global::custom_controls.ToolStripIPAddressComboBox toolStripIPAddressComboBox = enumerator.Current;
								toolStripIPAddressComboBox.DeleteDataSource();
								num = 4;
								continue;
							}
							case 3:
								goto IL_15B;
							}
							IL_120:
							num = 1;
							continue;
							goto IL_120;
						}
						IL_15B:
						goto IL_1C2;
					}
					finally
					{
						if (true)
						{
						}
						global::System.Collections.Generic.LinkedList<global::custom_controls.ToolStripIPAddressComboBox>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_173;
					IL_1C2:
					this.f.Clear();
					this.f = null;
					num = 12;
					continue;
				case 20:
					goto IL_173;
				}
				if (this.a != null)
				{
					num = 3;
					continue;
				}
				goto IL_173;
				IL_80:
				num = 16;
				continue;
				IL_D4:
				num = 11;
				continue;
				IL_173:
				num = 5;
				continue;
				IL_196:
				this.commandMgmt.Dispose();
				this.commandMgmt = null;
				num = 17;
				continue;
				IL_1E4:
				num = 15;
				continue;
				IL_248:
				num = 13;
			}
			IL_1DF:
			IL_2D5:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_1DF;
			default:
				if (false)
				{
				}
				return;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00046750 File Offset: 0x00044950
		private void b(string A_0)
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
			this.e = new global::System.Collections.Generic.LinkedList<global::custom_controls.CMenuStripItem>();
			this.c = new global::System.Collections.Generic.LinkedList<global::custom_controls.CSeparator>();
			this.b = new global::custom_controls.CShorcutHandler();
			this.commandMgmt = new global::custom_controls.CCommandMgmt();
			this.f = new global::System.Collections.Generic.LinkedList<global::custom_controls.ToolStripIPAddressComboBox>();
			this.a(A_0);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000467CC File Offset: 0x000449CC
		private void a(string A_0)
		{
			try
			{
				switch (0)
				{
				default:
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
						for (;;)
						{
							string empty = string.Empty;
							this.a = new global::System.Xml.XmlDocument();
							int num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_F1;
								case 1:
								{
									if (!global::System.IO.File.Exists(A_0))
									{
										num = 2;
										continue;
									}
									global::a.a(A_0, ref empty, false, global::a.c.d);
									global::a.a a = global::a.a(global::a.b.b, ref empty);
									num = 4;
									continue;
								}
								case 2:
									goto IL_72;
								case 3:
									goto IL_10B;
								case 4:
								{
									global::a.a a;
									if (a != global::a.a.c)
									{
										num = 0;
										continue;
									}
									this.a.LoadXml(empty);
									num = 3;
									continue;
								}
								}
								break;
							}
						}
						IL_F1:
						global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1835U, base.GetType().ToString(), "CreateTopLevelMenu", global::System.Environment.StackTrace.ToString());
						throw ex;
						IL_10B:
						goto IL_146;
					}
					}
					IL_72:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(1754U, base.GetType().ToString(), "CreateTopLevelMenu", global::System.Environment.StackTrace.ToString());
					throw ex2;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex3)
			{
				ex3.Source = 1625U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "| " + ex3.Source;
				global::custom_exception.CCustomException.Rethrow(ex3);
			}
			IL_146:
			if (true)
			{
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00046968 File Offset: 0x00044B68
		private void a(global::System.Windows.Forms.MenuStrip A_0, int A_1)
		{
			for (;;)
			{
				switch (0)
				{
				default:
				{
					global::custom_controls.CMenuStripItem cmenuStripItem = null;
					global::System.Xml.XmlElement documentElement = this.a.DocumentElement;
					try
					{
						for (;;)
						{
							global::System.Xml.XmlNodeList xmlNodeList = this.a.DocumentElement.SelectNodes("/root/TopMenuItem");
							int num = 1;
							for (;;)
							{
								global::System.Collections.IEnumerator enumerator;
								switch (num)
								{
								case 0:
									goto IL_65;
								case 1:
									if (xmlNodeList == null)
									{
										num = 0;
										continue;
									}
									goto IL_274;
								case 2:
									try
									{
										num = 1;
										for (;;)
										{
											global::System.Xml.XmlNode xmlNode;
											switch (num)
											{
											case 0:
												if (xmlNode.Attributes["Type"].Value == "Menu")
												{
													num = 4;
													continue;
												}
												break;
											case 2:
												num = 5;
												continue;
											case 3:
												goto IL_229;
											case 4:
												cmenuStripItem = new global::custom_controls.CMenuStripItem(xmlNode);
												cmenuStripItem.Text = this.d.GetString(cmenuStripItem.Name);
												A_0.Items.Add(cmenuStripItem);
												this.e.AddLast(cmenuStripItem);
												num = 9;
												continue;
											case 5:
												if ("Y".Equals(xmlNode.Attributes["MDILIST"].Value))
												{
													num = 8;
													continue;
												}
												goto IL_17A;
											case 6:
												if (!enumerator.MoveNext())
												{
													num = 7;
													continue;
												}
												xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
												num = 0;
												continue;
											case 7:
												num = 3;
												continue;
											case 8:
												A_0.MdiWindowListItem = cmenuStripItem;
												num = 10;
												continue;
											case 9:
												if (xmlNode.Attributes["MDILIST"] != null)
												{
													num = 2;
													continue;
												}
												goto IL_17A;
											case 10:
												goto IL_17A;
											}
											IL_151:
											num = 6;
											continue;
											goto IL_151;
											IL_17A:
											this.a(xmlNode, cmenuStripItem, A_1);
											num = 11;
										}
										IL_229:
										goto IL_28D;
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
													goto IL_273;
												case 1:
													goto IL_271;
												case 2:
													disposable.Dispose();
													num = 1;
													continue;
												}
												break;
											}
										}
										IL_271:
										IL_273:;
									}
									goto IL_274;
									IL_28D:
									num = 3;
									continue;
								case 3:
									goto IL_299;
								}
								break;
								IL_274:
								enumerator = xmlNodeList.GetEnumerator();
								num = 2;
							}
						}
						IL_65:
						global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(1713U, base.GetType().ToString(), "CreateTopLevelMenu", global::System.Environment.StackTrace.ToString());
						throw ex;
						IL_299:;
					}
					catch (global::custom_exception.CCustomException)
					{
						throw;
					}
					catch (global::System.Exception ex2)
					{
						ex2.Source = 1693U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "| " + ex2.Source;
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
						goto IL_2F2;
					}
					break;
				}
				}
			}
			IL_2F2:
			if (false)
			{
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00046CC4 File Offset: 0x00044EC4
		private void a(global::System.Xml.XmlNode A_0, global::System.Windows.Forms.ToolStripMenuItem A_1, int A_2)
		{
			switch (0)
			{
			default:
			{
				global::custom_controls.CMenuStripItem cmenuStripItem = null;
				try
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
						string text = global::System.Convert.ToString(A_2, global::System.Globalization.CultureInfo.InvariantCulture);
						global::System.Collections.IEnumerator enumerator = A_0.ChildNodes.GetEnumerator();
						try
						{
							int num = 3;
							for (;;)
							{
								global::System.Xml.XmlNode xmlNode;
								switch (num)
								{
								case 0:
									if (xmlNode.Attributes["Type"].Value == "Separator")
									{
										num = 9;
										continue;
									}
									num = 5;
									continue;
								case 1:
									goto IL_26A;
								case 2:
									num = 1;
									continue;
								case 4:
									goto IL_1AD;
								case 5:
									if (xmlNode.Attributes["DBTYPE"] != null)
									{
										num = 10;
										continue;
									}
									goto IL_1E1;
								case 7:
									if (string.IsNullOrEmpty(cmenuStripItem.Text))
									{
										num = 13;
										continue;
									}
									goto IL_1AD;
								case 9:
								{
									global::custom_controls.CSeparator value = new global::custom_controls.CSeparator(xmlNode);
									this.c.AddLast(value);
									A_1.DropDownItems.Add(value);
									num = 6;
									continue;
								}
								case 10:
									num = 14;
									continue;
								case 11:
									goto IL_1E1;
								case 12:
									if (!enumerator.MoveNext())
									{
										num = 2;
										continue;
									}
									xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
									num = 0;
									continue;
								case 13:
									cmenuStripItem.Text = cmenuStripItem.Name;
									num = 4;
									continue;
								case 14:
									if (!(xmlNode.Attributes["DBTYPE"].Value != text))
									{
										num = 11;
										continue;
									}
									break;
								}
								IL_FC:
								num = 12;
								continue;
								goto IL_FC;
								IL_1AD:
								A_1.DropDownItems.Add(cmenuStripItem);
								this.e.AddLast(cmenuStripItem);
								this.a(xmlNode, cmenuStripItem, A_2);
								num = 8;
								continue;
								IL_1E1:
								cmenuStripItem = new global::custom_controls.CMenuStripItem(xmlNode, this.b);
								cmenuStripItem.Text = this.d.GetString(cmenuStripItem.Name);
								num = 7;
							}
							IL_26A:;
						}
						finally
						{
							for (;;)
							{
								global::System.IDisposable disposable = enumerator as global::System.IDisposable;
								int num = 2;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_2B2;
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
										goto IL_2B4;
									}
									break;
								}
							}
							IL_2B2:
							IL_2B4:;
						}
						break;
					}
					}
				}
				catch (global::System.Exception ex)
				{
					ex.Source = 1693U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "| " + ex.Source;
					global::custom_exception.CCustomException.Rethrow(ex);
				}
				return;
			}
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00046FF4 File Offset: 0x000451F4
		public void CreateToolStripButtons(global::System.Windows.Forms.ToolStrip ts, int imageTextRelation)
		{
			switch (0)
			{
			default:
			{
				string fieldId = string.Empty;
				global::System.Xml.XmlAttribute xmlAttribute = null;
				global::System.Windows.Forms.ToolStripButton toolStripButton = null;
				global::System.Xml.XmlElement documentElement = this.a.DocumentElement;
				try
				{
					int num = 0;
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						switch (num)
						{
						case 1:
							try
							{
								num = 20;
								for (;;)
								{
									switch (num)
									{
									case 0:
										num = 7;
										continue;
									case 1:
										num = 19;
										continue;
									case 2:
										num = 14;
										continue;
									case 4:
										num = 12;
										continue;
									case 5:
									{
										global::System.Xml.XmlNode xmlNode;
										string value;
										if ((value = xmlNode.Attributes["Type"].Value) != null)
										{
											num = 4;
											continue;
										}
										break;
									}
									case 7:
									{
										string value;
										if (!(value == "Button"))
										{
											num = 1;
											continue;
										}
										toolStripButton = new global::System.Windows.Forms.ToolStripButton();
										global::System.Xml.XmlNode xmlNode;
										toolStripButton.Name = xmlNode.Attributes["NAME"].Value;
										toolStripButton.Tag = xmlNode.Attributes["Tag"].Value;
										toolStripButton.Text = this.d.GetString(toolStripButton.Name);
										fieldId = xmlNode.Attributes["IMAGEID"].Value;
										toolStripButton.Image = (global::System.Drawing.Image)this.d.GetObject(fieldId);
										toolStripButton.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageAboveText;
										toolStripButton.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
										toolStripButton.ToolTipText = toolStripButton.Text;
										xmlAttribute = xmlNode.Attributes["Toggle"];
										num = 18;
										continue;
									}
									case 10:
									{
										if (!enumerator.MoveNext())
										{
											num = 2;
											continue;
										}
										global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
										num = 5;
										continue;
									}
									case 11:
										num = 16;
										continue;
									case 12:
									{
										string value;
										if (!(value == "Separator"))
										{
											num = 0;
											continue;
										}
										global::System.Windows.Forms.ToolStripSeparator toolStripSeparator = new global::System.Windows.Forms.ToolStripSeparator();
										global::System.Xml.XmlNode xmlNode;
										toolStripSeparator.Name = xmlNode.Attributes["NAME"].Value;
										ts.Items.Add(toolStripSeparator);
										num = 8;
										continue;
									}
									case 13:
										toolStripButton.CheckOnClick = true;
										num = 17;
										continue;
									case 14:
										goto IL_3FE;
									case 15:
										num = 9;
										continue;
									case 16:
										if (xmlAttribute.Value.Equals("Y"))
										{
											num = 13;
											continue;
										}
										goto IL_2E5;
									case 17:
										goto IL_2E5;
									case 18:
										if (xmlAttribute != null)
										{
											num = 11;
											continue;
										}
										goto IL_2E5;
									case 19:
									{
										string value;
										if (!(value == "IPAddressComboBox"))
										{
											num = 15;
											continue;
										}
										global::System.Xml.XmlNode xmlNode;
										global::custom_controls.ToolStripIPAddressComboBox toolStripIPAddressComboBox = new global::custom_controls.ToolStripIPAddressComboBox("192.168.11.1", xmlNode.Attributes["Tag"].Value);
										toolStripIPAddressComboBox.Name = xmlNode.Attributes["NAME"].Value;
										toolStripIPAddressComboBox.ToolTipText = this.d.GetString(toolStripIPAddressComboBox.Name);
										this.MapTSIPAddressComboBoxToMenuItem(toolStripIPAddressComboBox);
										ts.Items.Add(toolStripIPAddressComboBox);
										this.f.AddLast(toolStripIPAddressComboBox);
										num = 6;
										continue;
									}
									}
									IL_1CC:
									num = 10;
									continue;
									goto IL_1CC;
									IL_2E5:
									this.MapTButtonToMenuItem(toolStripButton);
									ts.Items.Add(toolStripButton);
									num = 3;
								}
								IL_3FE:
								goto IL_499;
							}
							finally
							{
								for (;;)
								{
									IL_434:
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									num = 1;
									for (;;)
									{
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_465;
										default:
											if (false)
											{
											}
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
												goto IL_467;
											case 2:
												goto IL_465;
											}
											goto IL_434;
										}
									}
								}
								IL_465:
								IL_467:;
							}
							goto IL_468;
							IL_499:
							num = 4;
							continue;
						case 2:
							goto IL_75;
						case 3:
							num = 2;
							continue;
						case 4:
							goto IL_4A5;
						}
						if (ts == null)
						{
							num = 3;
							continue;
						}
						IL_468:
						global::System.Xml.XmlNodeList xmlNodeList = this.a.DocumentElement.SelectNodes("/root/TopMenuItem/ToolStripButton");
						enumerator = xmlNodeList.GetEnumerator();
						num = 1;
					}
					IL_75:
					IL_4A5:;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.Exception ex)
				{
					ex.Source = 1883U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "| " + ex.Source;
					global::custom_exception.CCustomException.Rethrow(ex);
				}
				if (true)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00047538 File Offset: 0x00045738
		public void ResetImageTextAlignment(global::System.Windows.Forms.ToolStripButton tsb, int imageTextRelation)
		{
			if (imageTextRelation != 0)
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
					tsb.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
					return;
				}
			}
			tsb.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageAboveText;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00047588 File Offset: 0x00045788
		public void ResetImageTextAlignment(global::System.Windows.Forms.ToolStrip ts, int imageTextRelation)
		{
			if (true)
			{
			}
			global::System.Collections.IEnumerator enumerator = ts.Items.GetEnumerator();
			try
			{
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 1:
						num = 5;
						continue;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = 6;
							continue;
						}
						object obj = enumerator.Current;
						num = 9;
						continue;
					}
					case 5:
					{
						if (imageTextRelation == 0)
						{
							num = 7;
							continue;
						}
						object obj;
						((global::System.Windows.Forms.ToolStripButton)obj).TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
						num = 3;
						continue;
					}
					case 6:
						num = 8;
						continue;
					case 7:
					{
						object obj;
						((global::System.Windows.Forms.ToolStripButton)obj).TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageAboveText;
						num = 0;
						continue;
					}
					case 8:
						goto IL_EF;
					case 9:
					{
						object obj;
						if (obj.GetType().ToString() == "System.Windows.Forms.ToolStripButton")
						{
							num = 1;
							continue;
						}
						break;
					}
					}
					IL_65:
					num = 2;
					continue;
					goto IL_65;
				}
				IL_EF:;
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
							goto IL_14D;
						case 1:
							disposable.Dispose();
							goto IL_127;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_127;
							default:
								goto IL_145;
							}
							break;
						}
						break;
						IL_127:
						num = 2;
					}
				}
				IL_145:
				if (false)
				{
				}
				IL_14D:;
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00047700 File Offset: 0x00045900
		public global::custom_controls.CMenuStripItem GetMenuItemById(string id)
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
					switch (num)
					{
					case 0:
						goto IL_4B;
					case 1:
						goto IL_112;
					}
					break;
				}
				if (string.IsNullOrEmpty(id))
				{
					num = 0;
				}
				else
				{
					global::System.Collections.Generic.LinkedList<global::custom_controls.CMenuStripItem>.Enumerator enumerator = this.e.GetEnumerator();
					num = 1;
				}
			}
			IL_4B:
			IL_ED:
			return null;
			IL_112:
			try
			{
				num = 3;
				global::custom_controls.CMenuStripItem result;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_D5;
					case 1:
					{
						global::custom_controls.CMenuStripItem cmenuStripItem;
						result = cmenuStripItem;
						num = 2;
						continue;
					}
					case 2:
						goto IL_A3;
					case 4:
					{
						global::custom_controls.CMenuStripItem cmenuStripItem;
						if (cmenuStripItem.Name.Equals(id))
						{
							num = 1;
							continue;
						}
						break;
					}
					case 5:
					{
						global::System.Collections.Generic.LinkedList<global::custom_controls.CMenuStripItem>.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = 6;
							continue;
						}
						global::custom_controls.CMenuStripItem cmenuStripItem = enumerator.Current;
						num = 4;
						continue;
					}
					case 6:
						num = 0;
						continue;
					}
					IL_7E:
					num = 5;
					continue;
					goto IL_7E;
				}
				IL_A3:
				return result;
				IL_D5:
				goto IL_EF;
			}
			finally
			{
				if (true)
				{
				}
				global::System.Collections.Generic.LinkedList<global::custom_controls.CMenuStripItem>.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_ED;
			IL_EF:
			return null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00047838 File Offset: 0x00045A38
		public global::custom_controls.CSeparator GetMenuSeparatorById(string id)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_37;
				case 1:
					goto IL_11B;
				case 2:
					if (true)
					{
					}
					break;
				}
				if (string.IsNullOrEmpty(id))
				{
					num = 0;
				}
				else
				{
					global::System.Collections.Generic.LinkedList<global::custom_controls.CSeparator>.Enumerator enumerator = this.c.GetEnumerator();
					num = 1;
				}
			}
			IL_37:
			IL_F6:
			return null;
			IL_11B:
			try
			{
				num = 5;
				global::custom_controls.CSeparator result;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_E6;
					case 1:
						num = 0;
						continue;
					case 2:
					{
						global::custom_controls.CSeparator cseparator;
						if (cseparator.Name.Equals(id))
						{
							num = 6;
							continue;
						}
						break;
					}
					case 3:
					{
						global::System.Collections.Generic.LinkedList<global::custom_controls.CSeparator>.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = 1;
							continue;
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
							global::custom_controls.CSeparator cseparator = enumerator.Current;
							num = 2;
							continue;
						}
						}
						break;
					}
					case 4:
						goto IL_8F;
					case 6:
					{
						global::custom_controls.CSeparator cseparator;
						result = cseparator;
						num = 4;
						continue;
					}
					}
					IL_6A:
					num = 3;
					continue;
					goto IL_6A;
				}
				IL_8F:
				return result;
				IL_E6:
				goto IL_F8;
			}
			finally
			{
				global::System.Collections.Generic.LinkedList<global::custom_controls.CSeparator>.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_F6;
			IL_F8:
			return null;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00047978 File Offset: 0x00045B78
		public global::custom_controls.CMenuStripItem GetMenuBarItemFromText(string text)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_2F;
				case 1:
					goto IL_118;
				}
				if (string.IsNullOrEmpty(text))
				{
					num = 0;
				}
				else
				{
					if (true)
					{
					}
					global::System.Collections.Generic.LinkedList<global::custom_controls.CMenuStripItem>.Enumerator enumerator = this.e.GetEnumerator();
					num = 1;
				}
			}
			IL_2F:
			IL_EB:
			return null;
			IL_118:
			try
			{
				num = 0;
				global::custom_controls.CMenuStripItem result;
				for (;;)
				{
					switch (num)
					{
					case 1:
					{
						global::custom_controls.CMenuStripItem cmenuStripItem;
						result = cmenuStripItem;
						num = 6;
						continue;
					}
					case 2:
					{
						global::custom_controls.CMenuStripItem cmenuStripItem;
						if (cmenuStripItem.Text.Equals(text))
						{
							num = 1;
							continue;
						}
						break;
					}
					case 3:
						goto IL_DB;
					case 4:
						goto IL_97;
					case 5:
					{
						global::System.Collections.Generic.LinkedList<global::custom_controls.CMenuStripItem>.Enumerator enumerator;
						if (enumerator.MoveNext())
						{
							global::custom_controls.CMenuStripItem cmenuStripItem = enumerator.Current;
							num = 2;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_97;
						default:
							if (false)
							{
							}
							num = 4;
							continue;
						}
						break;
					}
					case 6:
						goto IL_A3;
					}
					IL_62:
					num = 5;
					continue;
					goto IL_62;
					IL_97:
					num = 3;
				}
				IL_A3:
				return result;
				IL_DB:
				goto IL_ED;
			}
			finally
			{
				global::System.Collections.Generic.LinkedList<global::custom_controls.CMenuStripItem>.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_EB;
			IL_ED:
			return null;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00047AB4 File Offset: 0x00045CB4
		public void MapTSIPAddressComboBoxToMenuItem(global::custom_controls.ToolStripIPAddressComboBox linkToolStripIPAddrComboBox)
		{
			try
			{
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_94;
					case 1:
					{
						global::custom_controls.CMenuStripItem menuItemById;
						menuItemById.LinkedTSIPAddrComboBox = linkToolStripIPAddrComboBox;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B;
						default:
							if (false)
							{
							}
							num = 4;
							continue;
						}
						break;
					}
					case 2:
					{
						global::custom_controls.CMenuStripItem menuItemById = this.GetMenuItemById(linkToolStripIPAddrComboBox.Tag.ToString());
						num = 5;
						continue;
					}
					case 4:
						goto IL_89;
					case 5:
					{
						global::custom_controls.CMenuStripItem menuItemById;
						if (menuItemById != null)
						{
							num = 1;
							continue;
						}
						goto IL_89;
					}
					}
					goto IL_28;
					IL_2B:
					num = 2;
					continue;
					IL_28:
					if (linkToolStripIPAddrComboBox != null)
					{
						goto IL_2B;
					}
					IL_89:
					num = 0;
				}
				IL_94:;
			}
			catch (global::System.Exception ex)
			{
				ex.Source = 1693U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "| " + ex.Source;
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00047BAC File Offset: 0x00045DAC
		public void MapTButtonToMenuItem(global::System.Windows.Forms.ToolStripButton linkToolStripButton)
		{
			try
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_99;
					case 2:
					{
						global::custom_controls.CMenuStripItem menuItemById;
						menuItemById.LinkedTstrpButton = linkToolStripButton;
						this.commandMgmt.MapToolbarClickEvent(linkToolStripButton, menuItemById);
						num = 1;
						continue;
					}
					case 3:
						goto IL_A4;
					case 4:
					{
						global::custom_controls.CMenuStripItem menuItemById;
						if (menuItemById != null)
						{
							num = 2;
							continue;
						}
						goto IL_99;
					}
					case 5:
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
							global::custom_controls.CMenuStripItem menuItemById = this.GetMenuItemById(linkToolStripButton.Tag.ToString());
							num = 4;
							continue;
						}
						}
						break;
					}
					if (linkToolStripButton != null)
					{
						num = 5;
						continue;
					}
					IL_99:
					num = 3;
				}
				IL_A4:;
			}
			catch (global::System.Exception ex)
			{
				ex.Source = 1693U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "| " + ex.Source;
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00047CB4 File Offset: 0x00045EB4
		public void MapTButtonToMenuItem(global::System.Windows.Forms.ToolStrip linkToolBar)
		{
			switch (0)
			{
			default:
				if (true)
				{
				}
				if (linkToolBar != null)
				{
					try
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
							global::System.Collections.IEnumerator enumerator = linkToolBar.Items.GetEnumerator();
							try
							{
								int num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										num = 7;
										continue;
									case 2:
									{
										object obj;
										if (obj is global::System.Windows.Forms.ToolStripButton)
										{
											num = 13;
											continue;
										}
										num = 4;
										continue;
									}
									case 3:
									{
										global::custom_controls.CMenuStripItem menuItemById;
										global::custom_controls.ToolStripIPAddressComboBox toolStripIPAddressComboBox;
										menuItemById.LinkedTSIPAddrComboBox = toolStripIPAddressComboBox;
										menuItemById.Enabled = menuItemById.Enabled;
										num = 5;
										continue;
									}
									case 4:
									{
										object obj;
										if (obj is global::custom_controls.ToolStripIPAddressComboBox)
										{
											num = 12;
											continue;
										}
										break;
									}
									case 6:
									{
										if (!enumerator.MoveNext())
										{
											num = 0;
											continue;
										}
										object obj = enumerator.Current;
										num = 2;
										continue;
									}
									case 7:
										goto IL_1F8;
									case 8:
									{
										global::custom_controls.CMenuStripItem menuItemById;
										if (menuItemById != null)
										{
											num = 3;
											continue;
										}
										break;
									}
									case 9:
									{
										global::custom_controls.CMenuStripItem menuItemById2;
										global::System.Windows.Forms.ToolStripButton toolStripButton;
										menuItemById2.LinkedTstrpButton = toolStripButton;
										menuItemById2.Enabled = menuItemById2.Enabled;
										this.commandMgmt.MapToolbarClickEvent(toolStripButton, menuItemById2);
										num = 11;
										continue;
									}
									case 10:
									{
										global::custom_controls.CMenuStripItem menuItemById2;
										if (menuItemById2 != null)
										{
											num = 9;
											continue;
										}
										break;
									}
									case 12:
									{
										object obj;
										global::custom_controls.ToolStripIPAddressComboBox toolStripIPAddressComboBox = (global::custom_controls.ToolStripIPAddressComboBox)obj;
										string id = toolStripIPAddressComboBox.Tag.ToString();
										global::custom_controls.CMenuStripItem menuItemById = this.GetMenuItemById(id);
										num = 8;
										continue;
									}
									case 13:
									{
										object obj;
										global::System.Windows.Forms.ToolStripButton toolStripButton = (global::System.Windows.Forms.ToolStripButton)obj;
										string id2 = toolStripButton.Tag.ToString();
										global::custom_controls.CMenuStripItem menuItemById2 = this.GetMenuItemById(id2);
										num = 10;
										continue;
									}
									}
									IL_DD:
									num = 6;
									continue;
									goto IL_DD;
								}
								IL_1F8:;
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
												num = 2;
												continue;
											}
											goto IL_242;
										case 1:
											goto IL_240;
										case 2:
											disposable.Dispose();
											num = 1;
											continue;
										}
										break;
									}
								}
								IL_240:
								IL_242:;
							}
							break;
						}
						}
						return;
					}
					catch (global::System.Exception ex)
					{
						ex.Source = 1693U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "| " + ex.Source;
						global::custom_exception.CCustomException.Rethrow(ex);
						return;
					}
					return;
				}
				return;
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00047F74 File Offset: 0x00046174
		public void MenuItemEnableDisable(string menuID, bool isEnable)
		{
			for (;;)
			{
				for (;;)
				{
					global::custom_controls.CMenuStripItem menuItemById = this.GetMenuItemById(menuID);
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (menuItemById != null)
							{
								num = 2;
								continue;
							}
							return;
						case 1:
							goto IL_4A;
						case 2:
							menuItemById.Enabled = isEnable;
							num = 1;
							continue;
						}
						break;
					}
				}
				IL_4A:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_60;
				}
			}
			IL_60:
			if (true)
			{
			}
			if (false)
			{
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00047FF4 File Offset: 0x000461F4
		public void PopulateContextMenu(global::System.Windows.Forms.ContextMenuStrip contextMenu, global::custom_controls.CMenuStripItem sender)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						int num = 0;
						int num2 = 7;
						for (;;)
						{
							global::custom_controls.CSeparator cseparator;
							global::custom_controls.CMenuStripItem cmenuStripItem;
							switch (num2)
							{
							case 0:
								if (sender.DropDownItems[num].MergeAction != global::System.Windows.Forms.MergeAction.MatchOnly)
								{
									num2 = 21;
									continue;
								}
								goto IL_210;
							case 1:
								goto IL_1AF;
							case 2:
								num2 = 19;
								continue;
							case 3:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_87;
								default:
									if (false)
									{
									}
									if (((global::custom_controls.CMenuStripItem)sender.DropDownItems[num]).HasDropDownItems)
									{
										num2 = 22;
										continue;
									}
									goto IL_24A;
								}
								break;
							case 4:
								if (sender.DropDownItems[num] is global::custom_controls.CMenuStripItem)
								{
									num2 = 11;
									continue;
								}
								goto IL_115;
							case 5:
								if (sender.DropDownItems[num].MergeAction == global::System.Windows.Forms.MergeAction.Replace)
								{
									num2 = 23;
									continue;
								}
								goto IL_1DD;
							case 6:
								goto IL_115;
							case 7:
								goto IL_1AF;
							case 8:
								if (num >= sender.DropDownItems.Count)
								{
									num2 = 2;
									continue;
								}
								num2 = 13;
								continue;
							case 9:
								contextMenu.Items.Add(cseparator);
								num2 = 10;
								continue;
							case 10:
								goto IL_115;
							case 11:
								num2 = 15;
								continue;
							case 12:
								if (cseparator != null)
								{
									num2 = 9;
									continue;
								}
								goto IL_115;
							case 13:
								if (sender.DropDownItems[num] is global::custom_controls.CSeparator)
								{
									num2 = 14;
									continue;
								}
								goto IL_1DD;
							case 14:
								num2 = 0;
								continue;
							case 15:
								if (sender.DropDownItems[num].MergeAction == global::System.Windows.Forms.MergeAction.Replace)
								{
									num2 = 16;
									continue;
								}
								goto IL_115;
							case 16:
								cmenuStripItem = (global::custom_controls.CMenuStripItem)((global::custom_controls.CMenuStripItem)sender.DropDownItems[num]).b();
								num2 = 20;
								continue;
							case 17:
								num2 = 3;
								continue;
							case 18:
								goto IL_24A;
							case 19:
								goto IL_304;
							case 20:
								if (cmenuStripItem != null)
								{
									num2 = 17;
									continue;
								}
								goto IL_115;
							case 21:
								num2 = 5;
								continue;
							case 22:
								goto IL_87;
							case 23:
								goto IL_210;
							}
							break;
							IL_87:
							this.a(cmenuStripItem, (global::custom_controls.CMenuStripItem)sender.DropDownItems[num]);
							num2 = 18;
							continue;
							IL_115:
							num++;
							num2 = 1;
							continue;
							IL_1AF:
							num2 = 8;
							continue;
							IL_1DD:
							num2 = 4;
							continue;
							IL_210:
							cseparator = ((global::custom_controls.CSeparator)sender.DropDownItems[num]).a();
							num2 = 12;
							continue;
							IL_24A:
							contextMenu.Items.Add(cmenuStripItem);
							num2 = 6;
						}
					}
					IL_304:
					break;
				}
			}
			catch (global::System.Exception ex)
			{
				ex.Source = 1693U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "| " + ex.Source;
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00048368 File Offset: 0x00046568
		private void a(global::custom_controls.CMenuStripItem A_0, global::custom_controls.CMenuStripItem A_1)
		{
			for (;;)
			{
				IL_4E:
				int num = 0;
				for (;;)
				{
					IL_50:
					int num2 = 2;
					for (;;)
					{
						global::custom_controls.CMenuStripItem cmenuStripItem;
						switch (num2)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_50;
							default:
								if (false)
								{
								}
								if (num >= A_1.DropDownItems.Count)
								{
									num2 = 4;
									continue;
								}
								num2 = 3;
								continue;
							}
							break;
						case 1:
							goto IL_145;
						case 2:
							goto IL_145;
						case 3:
							if (A_1.DropDownItems[num] is global::custom_controls.CSeparator)
							{
								num2 = 12;
								continue;
							}
							cmenuStripItem = (global::custom_controls.CMenuStripItem)((global::custom_controls.CMenuStripItem)A_1.DropDownItems[num]).b();
							num2 = 6;
							continue;
						case 4:
							return;
						case 5:
							goto IL_E1;
						case 6:
							if (cmenuStripItem != null)
							{
								num2 = 13;
								continue;
							}
							goto IL_E1;
						case 7:
						{
							global::custom_controls.CSeparator cseparator;
							cseparator.Visible = true;
							A_0.DropDownItems.Add(cseparator);
							num2 = 9;
							continue;
						}
						case 8:
						{
							global::custom_controls.CSeparator cseparator;
							if (cseparator != null)
							{
								num2 = 7;
								continue;
							}
							goto IL_E1;
						}
						case 9:
							goto IL_E1;
						case 10:
							if (((global::custom_controls.CMenuStripItem)A_1.DropDownItems[num]).HasDropDownItems)
							{
								num2 = 11;
								continue;
							}
							goto IL_5D;
						case 11:
							this.a(cmenuStripItem, (global::custom_controls.CMenuStripItem)A_1.DropDownItems[num]);
							num2 = 14;
							continue;
						case 12:
						{
							global::custom_controls.CSeparator cseparator = ((global::custom_controls.CSeparator)A_1.DropDownItems[num]).a();
							num2 = 8;
							continue;
						}
						case 13:
							num2 = 10;
							continue;
						case 14:
							goto IL_5D;
						}
						goto IL_4E;
						IL_5D:
						A_0.DropDownItems.Add(cmenuStripItem);
						if (true)
						{
						}
						num2 = 5;
						continue;
						IL_E1:
						num++;
						num2 = 1;
						continue;
						IL_145:
						num2 = 0;
					}
				}
			}
		}

		// Token: 0x04000317 RID: 791
		private global::System.Xml.XmlDocument a;

		// Token: 0x04000318 RID: 792
		private global::custom_controls.CShorcutHandler b;

		// Token: 0x04000319 RID: 793
		private global::System.Collections.Generic.LinkedList<global::custom_controls.CSeparator> c;

		// Token: 0x0400031A RID: 794
		public global::custom_controls.CCommandMgmt commandMgmt;

		// Token: 0x0400031B RID: 795
		private global::resource_handler.CResourceHandler d;

		// Token: 0x0400031C RID: 796
		private global::System.Collections.Generic.LinkedList<global::custom_controls.CMenuStripItem> e;

		// Token: 0x0400031D RID: 797
		private global::System.Collections.Generic.LinkedList<global::custom_controls.ToolStripIPAddressComboBox> f;

		// Token: 0x0400031E RID: 798
		private bool g;
	}
}
