using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;
using custom_exception;
using resource_handler;

namespace custom_controls
{
	// Token: 0x0200008B RID: 139
	public class CSearch : global::System.Windows.Forms.UserControl
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00056E00 File Offset: 0x00055000
		public static global::System.Drawing.Pen LightPen
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
				return global::custom_controls.CSearch.ac;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00056E40 File Offset: 0x00055040
		public static global::System.Drawing.Pen DarkPen
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
				return global::custom_controls.CSearch.ad;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00056E80 File Offset: 0x00055080
		public static global::System.Drawing.Brush PlainBrush
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
				return global::custom_controls.CSearch.ae;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00056EC0 File Offset: 0x000550C0
		public global::custom_controls.CSearchEngine SearchEngine
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
				return this.ai;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00056F04 File Offset: 0x00055104
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00056F48 File Offset: 0x00055148
		public override global::System.Drawing.Font Font
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
				return base.Font;
			}
			set
			{
				for (;;)
				{
					base.Font = value;
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.am.Font = value;
							num = 7;
							continue;
						case 1:
							if (this.am != null)
							{
								num = 0;
								continue;
							}
							goto IL_97;
						case 2:
							this.at.Font = value;
							num = 9;
							continue;
						case 3:
							if (this.ar != null)
							{
								num = 5;
								continue;
							}
							goto IL_72;
						case 4:
							goto IL_72;
						case 5:
							this.ar.Font = value;
							num = 4;
							continue;
						case 6:
							this.@as.Font = value;
							num = 8;
							continue;
						case 7:
							goto IL_97;
						case 8:
							goto IL_6D;
						case 9:
							return;
						case 10:
							if (this.@as != null)
							{
								num = 6;
								continue;
							}
							goto IL_F3;
						case 11:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_6D;
							default:
								if (false)
								{
								}
								if (this.at != null)
								{
									num = 2;
									continue;
								}
								return;
							}
							break;
						}
						break;
						IL_72:
						if (true)
						{
						}
						num = 10;
						continue;
						IL_97:
						num = 3;
						continue;
						IL_F3:
						num = 11;
						continue;
						IL_6D:
						goto IL_F3;
					}
				}
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000570A0 File Offset: 0x000552A0
		public CSearch()
		{
			try
			{
				this.b();
				this.Font = base.Parent.Font;
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x000570E4 File Offset: 0x000552E4
		public CSearch(global::resource_handler.CResourceHandler resourceMgr, bool rightToLeft, global::System.Windows.Forms.DockStyle ds)
		{
			try
			{
				this.b();
				this.ai = new global::custom_controls.CSearchEngine();
				this.aj = true;
				this.ak = false;
				this.ah = null;
				this.ag = rightToLeft;
				this.af = resourceMgr;
				this.aq = new global::custom_controls.CPanelTemplate();
				this.e();
				this.am = new global::custom_controls.ListViewTemplate();
				this.an = new global::System.Windows.Forms.ColumnHeader();
				this.ao = new global::System.Windows.Forms.ColumnHeader();
				this.ap = new global::System.Windows.Forms.ColumnHeader();
				this.aq.Controls.AddRange(new global::System.Windows.Forms.Control[]
				{
					this.am,
					this.ar
				});
				this.ar.Dock = global::System.Windows.Forms.DockStyle.Top;
				this.am.Dock = global::System.Windows.Forms.DockStyle.Fill;
				this.av = new global::custom_controls.c(global::System.Windows.Forms.DockStyle.Bottom);
				this.au = new global::custom_controls.s(this.aq);
				this.au.Dock = global::System.Windows.Forms.DockStyle.Fill;
				base.Controls.AddRange(new global::System.Windows.Forms.Control[]
				{
					this.au,
					this.av
				});
				this.am.DoubleClick -= this.a;
				this.am.DoubleClick += this.a;
				this.am.KeyPress -= this.a;
				this.am.KeyPress += this.a;
				this.am.ColumnClick -= new global::System.Windows.Forms.ColumnClickEventHandler(this.c);
				this.am.ColumnClick += new global::System.Windows.Forms.ColumnClickEventHandler(this.c);
				base.SetStyle(global::System.Windows.Forms.ControlStyles.DoubleBuffer, true);
				base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000572C0 File Offset: 0x000554C0
		private void e()
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
			this.ar = new global::custom_controls.CPanelTemplate();
			this.ar.Height = 20;
			this.ar.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.ar.TabStop = false;
			this.@as = new global::System.Windows.Forms.Label();
			this.@as.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			global::System.Windows.Forms.Panel panel = new global::System.Windows.Forms.Panel();
			panel.Width = 20;
			panel.Height = 20;
			panel.TabStop = false;
			this.at = new global::System.Windows.Forms.Button();
			this.at.Height = 13;
			this.at.Width = 13;
			panel.Controls.Add(this.at);
			this.at.Top = (panel.Height - this.at.Height) / 2;
			this.at.Left = panel.Right - this.at.Width - 3;
			this.at.Image = (global::System.Drawing.Image)this.af.GetObject("X_ICON");
			this.at.TabStop = false;
			this.ar.Controls.AddRange(new global::System.Windows.Forms.Control[]
			{
				this.@as,
				panel
			});
			panel.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.@as.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.at.Click -= this.b;
			this.at.Click += this.b;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00057468 File Offset: 0x00055668
		private void d()
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
			this.am.View = global::System.Windows.Forms.View.List;
			this.am.FullRowSelect = true;
			global::System.Windows.Forms.ListViewItem listViewItem = new global::System.Windows.Forms.ListViewItem(string.Empty, 0);
			string @string = this.af.GetString("NO_MATCH_FOUND");
			listViewItem.Text = @string;
			this.am.Items.Add(listViewItem);
			global::System.Windows.Forms.Label label = this.@as;
			label.Text += "0";
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0005750C File Offset: 0x0005570C
		private void c()
		{
			for (;;)
			{
				this.an.Width = 150;
				this.ao.Width = 150;
				this.ap.Width = 150;
				this.am.IsLastColumAutoSize = true;
				if (true)
				{
				}
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.am.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
						{
							this.an,
							this.ao,
							this.ap
						});
						this.an.Text = this.af.GetString("COLUMN_HEADER_TREE");
						this.ao.Text = this.af.GetString("COLUMN_HEADER_FIELD");
						this.ap.Text = this.af.GetString("COLUMN_HEADER_VALUE");
						num = 1;
						continue;
					case 1:
						goto IL_1A1;
					case 2:
						if (!this.ak)
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
								this.am.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
								{
									this.an,
									this.ao
								});
								this.an.Text = this.af.GetString("COLUMN_HEADER_TREE");
								this.ao.Text = this.af.GetString("COLUMN_HEADER_FIELD");
								num = 3;
								continue;
							}
						}
						num = 0;
						continue;
					case 3:
						goto IL_10D;
					}
					break;
				}
			}
			IL_10D:
			IL_1A1:
			this.am.View = global::System.Windows.Forms.View.Details;
			this.am.MultiSelect = false;
			this.am.FullRowSelect = true;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x000576E0 File Offset: 0x000558E0
		public void PopulateListView(global::custom_controls.CFormTemplate currentArchive, global::System.Xml.XmlNodeList findResult, string viewName)
		{
			try
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					default:
						for (;;)
						{
							this.al = new global::custom_controls.CListViewSorter();
							this.am.Clear();
							this.ah = currentArchive;
							string text = this.af.GetString("LBL_CONTROL_TITLE");
							string newValue = this.SearchEngine.SearchValue.Replace("&amp;", "&&");
							text = text.Replace("%1", newValue);
							text = text.Replace("%2", viewName);
							text = text.Replace("%3", currentArchive.Text);
							this.@as.Text = text;
							int num = 6;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_1D7;
								case 1:
								{
									if (findResult.Count <= 0)
									{
										num = 9;
										continue;
									}
									this.c();
									int num2 = 0;
									num = 0;
									continue;
								}
								case 2:
								{
									int num2;
									if (num2 >= findResult.Count)
									{
										num = 8;
										continue;
									}
									global::custom_controls.CListViewItem clistViewItem = new global::custom_controls.CListViewItem();
									clistViewItem.Text = currentArchive.Text;
									string value = findResult[num2].Attributes["TREE_NODE"].Value;
									string value2 = findResult[num2].Attributes["FIELD_ID"].Value;
									clistViewItem.SubItems.Add(value);
									clistViewItem.TreeNodeTag = value;
									clistViewItem.SubItems.Add(value2);
									clistViewItem.ControlId = value2;
									this.am.Items.Add(clistViewItem);
									num2++;
									num = 4;
									continue;
								}
								case 3:
									goto IL_215;
								case 4:
									goto IL_1D7;
								case 5:
									num = 1;
									continue;
								case 6:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_00;
									default:
										if (false)
										{
										}
										if (findResult != null)
										{
											num = 5;
											continue;
										}
										goto IL_1FD;
									}
									break;
								case 7:
									goto IL_226;
								case 8:
									num = 7;
									continue;
								case 9:
									goto IL_1FD;
								}
								break;
								IL_1D7:
								num = 2;
								continue;
								IL_1FD:
								this.c();
								this.d();
								num = 3;
							}
						}
						break;
					}
				}
				IL_215:
				IL_226:;
			}
			catch (global::System.Exception ex)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					ex.Source = 1665U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00057988 File Offset: 0x00055B88
		public void SetListColumWidth()
		{
			for (;;)
			{
				int num;
				int num2;
				int count;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_94:
					this.am.Columns[num].Width = 150;
					num++;
					num2 = 5;
					break;
				default:
					if (false)
					{
					}
					count = this.am.Columns.Count;
					num2 = 6;
					break;
				}
				for (;;)
				{
					if (true)
					{
					}
					switch (num2)
					{
					case 0:
						this.am.Invalidate();
						num2 = 2;
						continue;
					case 1:
						if (num >= count - 2)
						{
							num2 = 0;
							continue;
						}
						goto IL_94;
					case 2:
						return;
					case 3:
						goto IL_79;
					case 4:
						num = 0;
						num2 = 3;
						continue;
					case 5:
						goto IL_79;
					case 6:
						if (count > 0)
						{
							num2 = 4;
							continue;
						}
						return;
					}
					break;
					IL_79:
					num2 = 1;
				}
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00057A7C File Offset: 0x00055C7C
		private static void a(ref global::custom_controls.CSearch.a A_0)
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
			A_0.b = string.Empty;
			A_0.a = string.Empty;
			A_0.c = string.Empty;
			A_0.d = string.Empty;
			A_0.e = string.Empty;
			A_0.f = string.Empty;
			A_0.g = string.Empty;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00057B04 File Offset: 0x00055D04
		public void PopulateListView(global::custom_controls.CFormTemplate currentArchive, global::System.Xml.XmlNodeList findResult, object sender, string viewName)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						this.al = new global::custom_controls.CListViewSorter();
						this.am.SuspendLayout();
						this.ak = false;
						this.aj = true;
						global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)sender;
						this.am.Clear();
						global::custom_controls.CSearch.a a_;
						a_.b = string.Empty;
						a_.a = string.Empty;
						a_.c = string.Empty;
						a_.d = string.Empty;
						a_.e = string.Empty;
						a_.f = string.Empty;
						a_.g = string.Empty;
						this.ah = currentArchive;
						string text = this.af.GetString("LBL_CONTROL_TITLE");
						string newValue = this.SearchEngine.SearchValue.Replace("&", "&&");
						text = text.Replace("%1", newValue);
						text = text.Replace("%2", viewName);
						text = text.Replace("%3", currentArchive.Text);
						this.@as.Text = text;
						int num = 13;
						for (;;)
						{
							int num2;
							switch (num)
							{
							case 0:
								a_.b = findResult[num2].Attributes["GRID_NAME"].Value;
								num = 5;
								continue;
							case 1:
								num = 6;
								continue;
							case 2:
								goto IL_543;
							case 3:
								goto IL_3A5;
							case 4:
								goto IL_543;
							case 5:
								goto IL_338;
							case 6:
								if (findResult.Count <= 0)
								{
									num = 10;
									continue;
								}
								this.c();
								num2 = 0;
								num = 23;
								continue;
							case 7:
								goto IL_1EC;
							case 8:
								this.d();
								num = 3;
								continue;
							case 9:
								if (findResult[num2].Attributes["GRID_NAME"] != null)
								{
									num = 0;
									continue;
								}
								a_.b = findResult[num2].Attributes["FIELD_ID"].Value;
								num = 21;
								continue;
							case 10:
								goto IL_2E4;
							case 11:
							{
								if (this.am.Items.Count <= 0)
								{
									num = 8;
									continue;
								}
								global::System.Windows.Forms.Label label = this.@as;
								label.Text += this.am.Items.Count;
								base.ResumeLayout();
								num = 24;
								continue;
							}
							case 12:
								if (findResult[num2].Attributes["FIELD_LIST_ID"] != null)
								{
									num = 19;
									continue;
								}
								goto IL_1EC;
							case 13:
								if (findResult != null)
								{
									num = 1;
									continue;
								}
								goto IL_2E4;
							case 14:
								this.d();
								num = 2;
								continue;
							case 15:
								num = 12;
								continue;
							case 16:
								goto IL_555;
							case 17:
								if (num2 >= findResult.Count)
								{
									num = 25;
									continue;
								}
								global::custom_controls.CSearch.a(ref a_);
								a_.c = findResult[num2].Attributes["FIELD_NAME"].Value;
								num = 22;
								continue;
							case 18:
								goto IL_3B6;
							case 19:
								a_.c = this.af.GetString(findResult[num2].Attributes["FIELD_LIST_ID"].Value);
								num = 7;
								continue;
							case 20:
								goto IL_3B1;
							case 21:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_3A5;
								default:
									if (false)
									{
									}
									goto IL_338;
								}
								break;
							case 22:
								if ("" == a_.c)
								{
									num = 15;
									continue;
								}
								goto IL_1EC;
							case 23:
								goto IL_3B6;
							case 24:
								goto IL_3A5;
							case 25:
								global::custom_controls.CSearch.a(ref a_);
								a_.a = customTreeNode.Tag.ToString();
								this.a(a_, customTreeNode, false);
								if (true)
								{
								}
								num = 26;
								continue;
							case 26:
							{
								if (this.am.Items.Count < 1)
								{
									num = 14;
									continue;
								}
								global::System.Windows.Forms.Label label2 = this.@as;
								label2.Text += this.am.Items.Count;
								num = 4;
								continue;
							}
							}
							break;
							IL_1EC:
							a_.a = findResult[num2].Attributes["TREE_NODE"].Value;
							num = 9;
							continue;
							IL_2E4:
							this.c();
							a_.a = customTreeNode.Tag.ToString();
							this.a(a_, customTreeNode, false);
							num = 11;
							continue;
							IL_338:
							this.a(a_, customTreeNode, true);
							num2++;
							num = 18;
							continue;
							IL_3A5:
							num = 20;
							continue;
							IL_3B6:
							num = 17;
							continue;
							IL_543:
							base.ResumeLayout();
							num = 16;
						}
					}
					IL_3B1:
					IL_555:
					break;
				}
			}
			catch (global::System.Exception ex)
			{
				base.ResumeLayout();
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					ex.Source = 1665U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				global::custom_exception.CCustomException.Rethrow(ex);
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000580D8 File Offset: 0x000562D8
		public void PopulateListView(global::custom_controls.CFormTemplate currentArchive, global::System.Xml.XmlNodeList findResult, object sender, string viewName, bool includeLabels)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						this.al = new global::custom_controls.CListViewSorter();
						this.aj = includeLabels;
						this.ak = true;
						this.am.SuspendLayout();
						this.am.Sorting = global::System.Windows.Forms.SortOrder.None;
						global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)sender;
						this.am.Clear();
						global::custom_controls.CSearch.a a_;
						a_.b = string.Empty;
						a_.a = string.Empty;
						a_.c = string.Empty;
						a_.a = string.Empty;
						a_.d = string.Empty;
						a_.e = string.Empty;
						a_.f = string.Empty;
						a_.g = string.Empty;
						this.ah = currentArchive;
						string text = this.af.GetString("LBL_CONTROL_TITLE");
						string newValue = this.SearchEngine.SearchValue.Replace("&", "&&");
						text = text.Replace("%1", newValue);
						text = text.Replace("%2", viewName);
						text = text.Replace("%3", currentArchive.Text);
						this.@as.Text = text;
						int num = 0;
						for (;;)
						{
							int num2;
							switch (num)
							{
							case 0:
								if (findResult != null)
								{
									num = 19;
									continue;
								}
								goto IL_661;
							case 1:
								if ("" == a_.c)
								{
									num = 31;
									continue;
								}
								goto IL_51E;
							case 2:
								goto IL_409;
							case 3:
								this.d();
								num = 18;
								continue;
							case 4:
								if (num2 >= findResult.Count)
								{
									num = 20;
									continue;
								}
								global::custom_controls.CSearch.a(ref a_);
								num = 14;
								continue;
							case 5:
								goto IL_5A3;
							case 6:
								if (findResult[num2].Attributes["GRID_NAME"] != null)
								{
									num = 16;
									continue;
								}
								a_.b = findResult[num2].Attributes["FIELD_ID"].Value;
								num = 27;
								continue;
							case 7:
								goto IL_6F4;
							case 8:
								goto IL_706;
							case 9:
								if (findResult[num2].Attributes["FIELD_LIST_ID"] != null)
								{
									num = 10;
									continue;
								}
								goto IL_51E;
							case 10:
								a_.c = this.af.GetString(findResult[num2].Attributes["FIELD_LIST_ID"].Value);
								num = 26;
								continue;
							case 11:
							{
								if (this.am.Items.Count < 1)
								{
									num = 24;
									continue;
								}
								global::System.Windows.Forms.Label label = this.@as;
								label.Text += this.am.Items.Count;
								num = 25;
								continue;
							}
							case 12:
								a_.d = findResult[num2].Attributes["ListID"].Value;
								num = 2;
								continue;
							case 13:
								if (findResult[num2].Attributes["ListLetID"] != null)
								{
									num = 15;
									continue;
								}
								goto IL_5A3;
							case 14:
								if (findResult[num2].Attributes["ListID"] != null)
								{
									num = 12;
									continue;
								}
								goto IL_409;
							case 15:
								a_.e = findResult[num2].Attributes["ListLetID"].Value;
								num = 5;
								continue;
							case 16:
								a_.b = findResult[num2].Attributes["GRID_NAME"].Value;
								a_.g = findResult[num2].Attributes["FIELD_NAME"].Value;
								a_.c = this.af.GetString(findResult[num2].Attributes["FIELD_ID"].Value);
								num = 34;
								continue;
							case 17:
								a_.f = findResult[num2].Attributes["FIELD_VALUE"].Value;
								num = 28;
								continue;
							case 18:
								goto IL_294;
							case 19:
								num = 35;
								continue;
							case 20:
								global::custom_controls.CSearch.a(ref a_);
								a_.a = customTreeNode.Tag.ToString();
								this.a(a_, customTreeNode, false);
								num = 11;
								continue;
							case 21:
								goto IL_661;
							case 22:
								goto IL_2A5;
							case 23:
							{
								if (this.am.Items.Count <= 0)
								{
									num = 3;
									continue;
								}
								global::System.Windows.Forms.Label label2 = this.@as;
								label2.Text += this.am.Items.Count;
								base.ResumeLayout();
								num = 32;
								continue;
							}
							case 24:
								this.d();
								num = 7;
								continue;
							case 25:
								goto IL_6F4;
							case 26:
								goto IL_51E;
							case 27:
								goto IL_2E3;
							case 28:
								goto IL_215;
							case 29:
								goto IL_2A5;
							case 30:
								goto IL_2A0;
							case 31:
								num = 9;
								continue;
							case 32:
								goto IL_294;
							case 33:
								if (findResult[num2].Attributes["FIELD_VALUE"] != null)
								{
									num = 17;
									continue;
								}
								goto IL_215;
							case 34:
								goto IL_2E3;
							case 35:
								if (findResult.Count <= 0)
								{
									num = 21;
									continue;
								}
								this.c();
								num2 = 0;
								num = 22;
								continue;
							}
							break;
							IL_215:
							a_.c = findResult[num2].Attributes["FIELD_NAME"].Value;
							a_.a = findResult[num2].Attributes["TREE_NODE"].Value;
							num = 6;
							continue;
							IL_294:
							num = 30;
							continue;
							IL_2A5:
							num = 4;
							continue;
							IL_2E3:
							num = 1;
							continue;
							IL_409:
							num = 13;
							continue;
							IL_51E:
							this.a(a_, customTreeNode, true);
							num2++;
							num = 29;
							continue;
							IL_5A3:
							num = 33;
							continue;
							IL_661:
							this.c();
							a_.a = customTreeNode.Tag.ToString();
							this.a(a_, customTreeNode, false);
							num = 23;
							continue;
							IL_6F4:
							base.ResumeLayout();
							num = 8;
						}
					}
					IL_2A0:
					IL_706:
					break;
				}
			}
			catch (global::System.Exception ex)
			{
				base.ResumeLayout();
				if (global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					goto IL_750;
				}
				if (true)
				{
				}
				IL_723:
				ex.Source = 1665U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				IL_750:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_723;
				default:
					if (false)
					{
					}
					global::custom_exception.CCustomException.Rethrow(ex);
					break;
				}
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00058880 File Offset: 0x00056A80
		private void a(global::custom_controls.CSearch.a A_0, global::custom_controls.CustomTreeNode A_1, bool A_2)
		{
			for (;;)
			{
				string searchValue = this.ai.SearchValue;
				int num = 7;
				for (;;)
				{
					switch (num)
					{
					case 0:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						global::custom_controls.CustomTreeNode customTreeNode2;
						if (customTreeNode != customTreeNode2.LastNode)
						{
							num = 22;
							continue;
						}
						num = 43;
						continue;
					}
					case 1:
						num = 16;
						continue;
					case 2:
						goto IL_2F9;
					case 3:
						goto IL_5D1;
					case 4:
						goto IL_124;
					case 5:
						goto IL_124;
					case 6:
					{
						global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)customTreeNode.NextNode;
						num = 31;
						continue;
					}
					case 7:
						if (A_2)
						{
							num = 40;
							continue;
						}
						goto IL_5EF;
					case 8:
						num = 32;
						continue;
					case 9:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						if (customTreeNode != null)
						{
							num = 17;
							continue;
						}
						return;
					}
					case 10:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						global::custom_controls.CustomTreeNode customTreeNode2;
						if (customTreeNode == customTreeNode2)
						{
							num = 33;
							continue;
						}
						goto IL_124;
					}
					case 11:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						if (customTreeNode.Tag.ToString() == A_0.a)
						{
							num = 48;
							continue;
						}
						goto IL_2A6;
					}
					case 12:
					{
						global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)customTreeNode.NextNode;
						num = 13;
						continue;
					}
					case 13:
						goto IL_124;
					case 14:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						global::custom_controls.CustomTreeNode customTreeNode2;
						if (customTreeNode != customTreeNode2.LastNode)
						{
							num = 12;
							continue;
						}
						goto IL_36D;
					}
					case 15:
						num = 41;
						continue;
					case 16:
						goto IL_36D;
					case 17:
						num = 10;
						continue;
					case 18:
						if (A_1.Tag.ToString() == A_0.a)
						{
							num = 2;
							continue;
						}
						goto IL_5EF;
					case 19:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						global::custom_controls.CustomTreeNode customTreeNode2;
						if (customTreeNode != customTreeNode2.LastNode)
						{
							num = 24;
							continue;
						}
						goto IL_36D;
					}
					case 20:
						if (A_2)
						{
							num = 54;
							continue;
						}
						goto IL_2A6;
					case 21:
					{
						global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)customTreeNode.NextNode;
						num = 3;
						continue;
					}
					case 22:
						goto IL_594;
					case 23:
						goto IL_124;
					case 24:
					{
						global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)customTreeNode.NextNode;
						num = 28;
						continue;
					}
					case 25:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						global::custom_controls.CustomTreeNode customTreeNode2;
						if (customTreeNode != customTreeNode2)
						{
							num = 21;
							continue;
						}
						goto IL_5D1;
					}
					case 26:
						if (this.aj)
						{
							num = 44;
							continue;
						}
						goto IL_4F1;
					case 27:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						global::custom_controls.CustomTreeNode customTreeNode2;
						if (customTreeNode != customTreeNode2)
						{
							num = 37;
							continue;
						}
						goto IL_594;
					}
					case 28:
						goto IL_124;
					case 29:
						if (!A_2)
						{
							num = 38;
							continue;
						}
						goto IL_4F1;
					case 30:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						global::custom_controls.CustomTreeNode customTreeNode2 = customTreeNode;
						customTreeNode = (global::custom_controls.CustomTreeNode)customTreeNode.FirstNode;
						num = 5;
						continue;
					}
					case 31:
						goto IL_124;
					case 32:
						if (A_1.Tag.ToString() == A_0.a)
						{
							num = 51;
							continue;
						}
						goto IL_15E;
					case 33:
						goto IL_2A1;
					case 34:
						if (this.IsMatch(A_1.Text, searchValue))
						{
							num = 15;
							continue;
						}
						goto IL_15E;
					case 35:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						if (customTreeNode.Nodes.Count > 0)
						{
							num = 47;
							continue;
						}
						num = 14;
						continue;
					}
					case 36:
						this.a(A_0, A_1);
						num = 58;
						continue;
					case 37:
						num = 0;
						continue;
					case 38:
						num = 56;
						continue;
					case 39:
						goto IL_36D;
					case 40:
						num = 18;
						continue;
					case 41:
						if (this.aj)
						{
							num = 36;
							continue;
						}
						goto IL_15E;
					case 42:
						return;
					case 43:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						if (customTreeNode == A_1.LastNode)
						{
							num = 42;
							continue;
						}
						global::custom_controls.CustomTreeNode customTreeNode2;
						customTreeNode = customTreeNode2;
						customTreeNode2 = (global::custom_controls.CustomTreeNode)customTreeNode2.Parent;
						num = 39;
						continue;
					}
					case 44:
					{
						global::custom_controls.CSearch.a(ref A_0);
						global::custom_controls.CustomTreeNode customTreeNode;
						this.a(A_0, customTreeNode);
						num = 35;
						continue;
					}
					case 45:
						if (!A_2)
						{
							num = 8;
							continue;
						}
						goto IL_15E;
					case 46:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						if (customTreeNode == null)
						{
							num = 1;
							continue;
						}
						num = 20;
						continue;
					}
					case 47:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						global::custom_controls.CustomTreeNode customTreeNode2 = customTreeNode;
						customTreeNode = (global::custom_controls.CustomTreeNode)customTreeNode.FirstNode;
						num = 23;
						continue;
					}
					case 48:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						this.a(A_0, customTreeNode);
						num = 49;
						continue;
					}
					case 49:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						if (customTreeNode.Nodes.Count > 0)
						{
							num = 30;
							continue;
						}
						num = 19;
						continue;
					}
					case 50:
						goto IL_5D1;
					case 51:
						num = 34;
						continue;
					case 52:
					{
						IL_4FC:
						global::custom_controls.CustomTreeNode customTreeNode;
						if (customTreeNode.Nodes.Count > 0)
						{
							num = 57;
							continue;
						}
						num = 53;
						continue;
					}
					case 53:
					{
						if (true)
						{
						}
						global::custom_controls.CustomTreeNode customTreeNode;
						global::custom_controls.CustomTreeNode customTreeNode2;
						if (customTreeNode != customTreeNode2.LastNode)
						{
							num = 6;
							continue;
						}
						goto IL_36D;
					}
					case 54:
						num = 11;
						continue;
					case 55:
						num = 26;
						continue;
					case 56:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						if (this.IsMatch(customTreeNode.Text, searchValue))
						{
							num = 55;
							continue;
						}
						goto IL_4F1;
					}
					case 57:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						global::custom_controls.CustomTreeNode customTreeNode2 = customTreeNode;
						customTreeNode = (global::custom_controls.CustomTreeNode)customTreeNode.FirstNode;
						num = 4;
						continue;
					}
					case 58:
						goto IL_15E;
					}
					break;
					IL_124:
					num = 46;
					continue;
					IL_15E:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4FC;
					default:
					{
						if (false)
						{
						}
						global::custom_controls.CustomTreeNode customTreeNode2 = A_1;
						global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)A_1.FirstNode;
						num = 50;
						continue;
					}
					}
					IL_2A6:
					num = 29;
					continue;
					IL_36D:
					num = 27;
					continue;
					IL_4F1:
					num = 52;
					continue;
					IL_594:
					num = 25;
					continue;
					IL_5D1:
					num = 9;
					continue;
					IL_5EF:
					num = 45;
				}
			}
			IL_2A1:
			return;
			IL_2F9:
			this.a(A_0, A_1);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00058EB0 File Offset: 0x000570B0
		private void a(global::custom_controls.CSearch.a A_0, global::custom_controls.CustomTreeNode A_1)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_146;
				case 1:
					if (A_0.d == A_1.ID)
					{
						num = 3;
						continue;
					}
					return;
				case 2:
					A_0.d = A_1.ID;
					num = 0;
					continue;
				case 3:
					goto IL_6A;
				case 4:
					return;
				}
				if (A_0.d.Length != 0)
				{
					goto IL_146;
				}
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
					num = 2;
					continue;
				}
				IL_6A:
				string text = A_0.c;
				text = text.Replace("&amp;", "&");
				text = text.Replace("&lt;", "<");
				text = text.Replace("&gt;", ">");
				global::custom_controls.CListViewItem clistViewItem = new global::custom_controls.CListViewItem();
				clistViewItem.Text = A_1.Text;
				clistViewItem.SubItems.Add(text);
				clistViewItem.ControlId = A_0.b;
				clistViewItem.TreeNodeTag = A_1.Tag.ToString();
				clistViewItem.Tag = A_1.ID;
				clistViewItem.SubItems.Add(A_0.f);
				clistViewItem.SubItems.Add(A_0.g);
				clistViewItem.SubItems.Add(A_0.e);
				this.am.Items.Add(clistViewItem);
				num = 4;
				continue;
				IL_146:
				num = 1;
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0005905C File Offset: 0x0005725C
		private void c(object A_0, global::System.EventArgs A_1)
		{
			global::System.Windows.Forms.ColumnClickEventArgs columnClickEventArgs;
			for (;;)
			{
				columnClickEventArgs = (A_1 as global::System.Windows.Forms.ColumnClickEventArgs);
				this.am.ListViewItemSorter = this.al;
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_12B;
					case 1:
						if (this.al.LastSort == columnClickEventArgs.Column)
						{
							num = 3;
							continue;
						}
						this.am.Sorting = global::System.Windows.Forms.SortOrder.Descending;
						num = 8;
						continue;
					case 2:
						if (this.am.Sorting == global::System.Windows.Forms.SortOrder.Ascending)
						{
							num = 7;
							continue;
						}
						this.am.Sorting = global::System.Windows.Forms.SortOrder.Ascending;
						num = 0;
						continue;
					case 3:
						num = 2;
						continue;
					case 4:
						if (!(this.am.ListViewItemSorter is global::custom_controls.CListViewSorter))
						{
							num = 5;
							continue;
						}
						this.al = (global::custom_controls.CListViewSorter)this.am.ListViewItemSorter;
						num = 1;
						continue;
					case 5:
						return;
					case 6:
						goto IL_12B;
					case 7:
						goto IL_112;
					case 8:
						goto IL_12B;
					}
					break;
					IL_112:
					this.am.Sorting = global::System.Windows.Forms.SortOrder.Descending;
					num = 6;
					continue;
					IL_12B:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_112;
					default:
						goto IL_141;
					}
				}
			}
			return;
			IL_141:
			if (false)
			{
			}
			if (true)
			{
			}
			this.al.ByColumn = columnClickEventArgs.Column;
			this.am.Sort();
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000591D4 File Offset: 0x000573D4
		public bool IsMatch(string argA, string argB)
		{
			bool result;
			for (;;)
			{
				if (true)
				{
				}
				result = false;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (this.ai.SearchExact)
						{
							num = 2;
							continue;
						}
						result = (argA.IndexOf(argB, global::System.StringComparison.InvariantCultureIgnoreCase) >= 0);
						num = 3;
						continue;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_81;
						}
						break;
					case 2:
						result = string.Equals(argA, argB, global::System.StringComparison.InvariantCultureIgnoreCase);
						num = 1;
						continue;
					case 3:
						goto IL_58;
					}
					break;
				}
			}
			IL_58:
			return result;
			IL_81:
			if (false)
			{
			}
			return result;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00059278 File Offset: 0x00057478
		protected override void Dispose(bool disposing)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					num = 4;
					continue;
				case 2:
					this.aw.Dispose();
					num = 3;
					continue;
				case 3:
					goto IL_72;
				case 4:
					if (true)
					{
					}
					if (this.aw != null)
					{
						num = 2;
						continue;
					}
					goto IL_72;
				}
				goto IL_2E;
				IL_31:
				num = 0;
				continue;
				IL_2E:
				if (disposing)
				{
					goto IL_31;
				}
				IL_72:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_31;
				default:
					goto IL_88;
				}
			}
			IL_88:
			if (false)
			{
			}
			base.Dispose(disposing);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0005931C File Offset: 0x0005751C
		private void b()
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
			this.Font = new global::System.Drawing.Font("Arial Unicode MS", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Name = "CSearch";
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0005937C File Offset: 0x0005757C
		public static global::System.Windows.Forms.DockStyle GetControlDockStyle(global::System.Windows.Forms.DockStyle ds)
		{
			for (;;)
			{
				int num = 0;
				for (;;)
				{
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						goto IL_30;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_30;
						default:
							if (false)
							{
							}
							num = 2;
							continue;
						}
						break;
					case 2:
						return ds;
					}
					break;
					IL_30:
					switch (ds)
					{
					case global::System.Windows.Forms.DockStyle.Top:
						return global::System.Windows.Forms.DockStyle.Bottom;
					case global::System.Windows.Forms.DockStyle.Bottom:
						return global::System.Windows.Forms.DockStyle.Top;
					case global::System.Windows.Forms.DockStyle.Left:
						return global::System.Windows.Forms.DockStyle.Right;
					case global::System.Windows.Forms.DockStyle.Right:
						return global::System.Windows.Forms.DockStyle.Left;
					default:
						num = 1;
						break;
					}
				}
			}
			return global::System.Windows.Forms.DockStyle.Left;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0005940C File Offset: 0x0005760C
		private void b(object A_0, global::System.EventArgs A_1)
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
			base.Hide();
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00059450 File Offset: 0x00057650
		private void a(object A_0, global::System.EventArgs A_1)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 0:
					IL_08:
					break;
				case 1:
					goto IL_4E;
				case 2:
					this.a();
					num = 1;
					continue;
				}
				if (this.am.View == global::System.Windows.Forms.View.Details)
				{
					num = 2;
					continue;
				}
				IL_4E:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_08;
				default:
					goto IL_64;
				}
			}
			IL_64:
			if (false)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000594D0 File Offset: 0x000576D0
		private void a(object A_0, global::System.Windows.Forms.KeyPressEventArgs A_1)
		{
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
						return;
					default:
						if (false)
						{
						}
						break;
					}
					break;
				case 1:
					if (A_1.KeyChar == '\r')
					{
						if (true)
						{
						}
						num = 4;
						continue;
					}
					return;
				case 2:
					return;
				case 3:
					num = 1;
					continue;
				case 4:
					this.a();
					num = 2;
					continue;
				}
				if (this.am.View != global::System.Windows.Forms.View.Details)
				{
					break;
				}
				num = 3;
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00059574 File Offset: 0x00057774
		private void a()
		{
			try
			{
				int num = 10;
				for (;;)
				{
					global::custom_controls.CListViewItem clistViewItem;
					switch (num)
					{
					case 0:
						num = 7;
						continue;
					case 1:
						if (clistViewItem.SubItems[2].Text.Length > 0)
						{
							num = 5;
							continue;
						}
						goto IL_62;
					case 2:
						num = 1;
						continue;
					case 3:
						if (this.ak)
						{
							num = 2;
							continue;
						}
						goto IL_62;
					case 4:
						goto IL_5D;
					case 5:
						IL_18D:
						this.OnListViewRowDblClickValues(this.ah, clistViewItem.Text, clistViewItem.TreeNodeTag, clistViewItem.Tag.ToString(), clistViewItem.ControlId, clistViewItem.SubItems[2].Text, clistViewItem.SubItems[3].Text, clistViewItem.SubItems[4].Text);
						num = 8;
						continue;
					case 6:
						goto IL_1CC;
					case 7:
						if (this.am.SelectedItems.Count <= 0)
						{
							num = 11;
							continue;
						}
						clistViewItem = (global::custom_controls.CListViewItem)this.am.SelectedItems[0];
						num = 3;
						continue;
					case 8:
						goto IL_1CC;
					case 9:
						goto IL_1D7;
					case 11:
						num = 4;
						continue;
					}
					if (this.OnListViewRowDblClick != null)
					{
						num = 0;
						continue;
					}
					goto IL_1CC;
					IL_62:
					this.OnListViewRowDblClick(this.ah, clistViewItem.Text, clistViewItem.TreeNodeTag, clistViewItem.Tag.ToString(), clistViewItem.ControlId);
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18D;
					default:
						if (false)
						{
						}
						num = 6;
						continue;
					}
					IL_1CC:
					num = 9;
				}
				IL_5D:
				IL_1D7:;
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex))
				{
					ex.Source = 1637U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "|" + ex.Source;
				}
				if (true)
				{
				}
				global::custom_exception.CCustomException.Rethrow(ex);
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000597E0 File Offset: 0x000579E0
		// Note: this type is marked as 'beforefieldinit'.
		static CSearch()
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
			global::custom_controls.CSearch.ac = new global::System.Drawing.Pen(global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.ControlLightLight));
			global::custom_controls.CSearch.ad = new global::System.Drawing.Pen(global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.ControlDark));
			global::custom_controls.CSearch.ae = global::System.Drawing.Brushes.LightGray;
		}

		// Token: 0x04000454 RID: 1108
		private const int a = 13;

		// Token: 0x04000455 RID: 1109
		private const string b = "X_ICON";

		// Token: 0x04000456 RID: 1110
		private const string c = "|";

		// Token: 0x04000457 RID: 1111
		private const string d = "&amp;";

		// Token: 0x04000458 RID: 1112
		private const string e = "&";

		// Token: 0x04000459 RID: 1113
		private const string f = "&lt;";

		// Token: 0x0400045A RID: 1114
		private const string g = "&gt;";

		// Token: 0x0400045B RID: 1115
		private const string h = ">";

		// Token: 0x0400045C RID: 1116
		private const string i = "<";

		// Token: 0x0400045D RID: 1117
		private const int j = 400;

		// Token: 0x0400045E RID: 1118
		private const int k = 150;

		// Token: 0x0400045F RID: 1119
		private const int l = 13;

		// Token: 0x04000460 RID: 1120
		private const int m = 20;

		// Token: 0x04000461 RID: 1121
		private const int n = 3;

		// Token: 0x04000462 RID: 1122
		private const string o = "LBL_CONTROL_TITLE";

		// Token: 0x04000463 RID: 1123
		private const string p = "COLUMN_HEADER_FILE";

		// Token: 0x04000464 RID: 1124
		private const string q = "COLUMN_HEADER_TREE";

		// Token: 0x04000465 RID: 1125
		private const string r = "COLUMN_HEADER_FIELD";

		// Token: 0x04000466 RID: 1126
		private const string s = "COLUMN_HEADER_VALUE";

		// Token: 0x04000467 RID: 1127
		private const string t = "NO_MATCH_FOUND";

		// Token: 0x04000468 RID: 1128
		private const string u = "TREE_NODE";

		// Token: 0x04000469 RID: 1129
		private const string v = "FIELD_ID";

		// Token: 0x0400046A RID: 1130
		private const string w = "FIELD_LIST_ID";

		// Token: 0x0400046B RID: 1131
		private const string x = "FIELD_NAME";

		// Token: 0x0400046C RID: 1132
		private const string y = "FIELD_VALUE";

		// Token: 0x0400046D RID: 1133
		private const string z = "GRID_NAME";

		// Token: 0x0400046E RID: 1134
		private const string aa = "ListID";

		// Token: 0x0400046F RID: 1135
		private const string ab = "ListLetID";

		// Token: 0x04000470 RID: 1136
		public const string REPLACE_CHAR1 = "%1";

		// Token: 0x04000471 RID: 1137
		public const string REPLACE_CHAR2 = "%2";

		// Token: 0x04000472 RID: 1138
		public const string REPLACE_CHAR3 = "%3";

		// Token: 0x04000473 RID: 1139
		public const string ZERO_STR = "0";

		// Token: 0x04000474 RID: 1140
		private static global::System.Drawing.Pen ac;

		// Token: 0x04000475 RID: 1141
		private static global::System.Drawing.Pen ad;

		// Token: 0x04000476 RID: 1142
		private static global::System.Drawing.Brush ae;

		// Token: 0x04000477 RID: 1143
		private global::resource_handler.CResourceHandler af;

		// Token: 0x04000478 RID: 1144
		private bool ag;

		// Token: 0x04000479 RID: 1145
		private global::custom_controls.CFormTemplate ah;

		// Token: 0x0400047A RID: 1146
		private global::custom_controls.CSearchEngine ai;

		// Token: 0x0400047B RID: 1147
		private bool aj;

		// Token: 0x0400047C RID: 1148
		private bool ak;

		// Token: 0x0400047D RID: 1149
		private global::custom_controls.CListViewSorter al;

		// Token: 0x0400047E RID: 1150
		private global::custom_controls.ListViewTemplate am;

		// Token: 0x0400047F RID: 1151
		private global::System.Windows.Forms.ColumnHeader an;

		// Token: 0x04000480 RID: 1152
		private global::System.Windows.Forms.ColumnHeader ao;

		// Token: 0x04000481 RID: 1153
		private global::System.Windows.Forms.ColumnHeader ap;

		// Token: 0x04000482 RID: 1154
		private global::custom_controls.CPanelTemplate aq;

		// Token: 0x04000483 RID: 1155
		private global::custom_controls.CPanelTemplate ar;

		// Token: 0x04000484 RID: 1156
		private global::System.Windows.Forms.Label @as;

		// Token: 0x04000485 RID: 1157
		private global::System.Windows.Forms.Button at;

		// Token: 0x04000486 RID: 1158
		private global::custom_controls.s au;

		// Token: 0x04000487 RID: 1159
		private global::custom_controls.c av;

		// Token: 0x04000488 RID: 1160
		public static int TopPosition;

		// Token: 0x04000489 RID: 1161
		public global::custom_controls.CSearch.ListViewRowDblClick OnListViewRowDblClick;

		// Token: 0x0400048A RID: 1162
		public global::custom_controls.CSearch.ListViewRowDblClickValues OnListViewRowDblClickValues;

		// Token: 0x0400048B RID: 1163
		private global::System.ComponentModel.Container aw;

		// Token: 0x0200008C RID: 140
		private struct a
		{
			// Token: 0x0400048C RID: 1164
			public string a;

			// Token: 0x0400048D RID: 1165
			public string b;

			// Token: 0x0400048E RID: 1166
			public string c;

			// Token: 0x0400048F RID: 1167
			public string d;

			// Token: 0x04000490 RID: 1168
			public string e;

			// Token: 0x04000491 RID: 1169
			public string f;

			// Token: 0x04000492 RID: 1170
			public string g;
		}

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060005E7 RID: 1511
		public delegate void ListViewRowDblClick(global::custom_controls.CFormTemplate sender, string nodeText, string nodeTage, string nodeId, string controlId);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060005EB RID: 1515
		public delegate void ListViewRowDblClickValues(global::custom_controls.CFormTemplate sender, string nodeText, string nodeTage, string nodeId, string controlId, string fieldValue, string gridColumn, string listLetID);
	}
}
