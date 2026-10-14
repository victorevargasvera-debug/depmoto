using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using common;
using Controller;
using custom_controls;
using custom_exception;
using resource_handler;

namespace mototrbodepottool
{
	// Token: 0x02000006 RID: 6
	public partial class CDevConList : CFormTemplate
	{
		// Token: 0x0600001D RID: 29 RVA: 0x000036D4 File Offset: 0x000026D4
		public CDevConList(ArrayList A_0, string A_1, bool A_2, CResourceHandler A_3)
		{
			try
			{
				this.c();
				this.m = A_2;
				this.k = A_3;
				this.n = A_1;
				this.o = A_0;
				this.t = null;
				this.u = null;
				this.v = string.Empty;
				this.a(this.p);
				this.b();
				this.Text = this.k.GetString("DLG_CONDEV");
				this.z.Text = this.k.GetString("BUTTON_OK");
				this.y.Text = this.k.GetString("BUTTON_CANCEL");
				this.u.Columns[0].Text = this.k.GetString("IP_ADDRESS");
				this.u.Columns[1].Text = this.k.GetString("SERIAL_NUM");
				this.a();
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				if (CCustomException.CheckErrorIDExsists(ex2))
				{
					CCustomException.Rethrow(ex2);
				}
				else
				{
					ex2.Source = 1700U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003838 File Offset: 0x00002838
		protected virtual void a(bool A_0)
		{
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
					num = 2;
					continue;
				case 1:
					this.aa.Dispose();
					num = 3;
					continue;
				case 2:
					if (this.aa == null)
					{
						goto IL_91;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						if (false)
						{
						}
						num = 1;
						continue;
					}
					break;
				case 3:
					goto IL_4C;
				}
				if (!A_0)
				{
					break;
				}
				if (true)
				{
				}
				num = 0;
			}
			IL_4C:
			IL_91:
			base.Dispose(A_0);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000038E0 File Offset: 0x000028E0
		private void c()
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
			this.p = new Panel();
			this.y = new Button();
			this.z = new Button();
			this.r = new ListViewTemplate();
			this.w = new ColumnHeader();
			this.x = new ColumnHeader();
			this.s = new ColumnHeader();
			this.p.SuspendLayout();
			base.SuspendLayout();
			this.p.Controls.Add(this.y);
			this.p.Controls.Add(this.z);
			this.p.Controls.Add(this.r);
			this.p.Dock = DockStyle.Fill;
			this.p.Location = new Point(0, 0);
			this.p.Name = "panel1";
			this.p.Size = new Size(280, 199);
			this.p.TabIndex = 0;
			this.y.DialogResult = DialogResult.Cancel;
			this.y.Location = new Point(184, 160);
			this.y.Name = "BUTTON_CANCEL";
			this.y.Size = new Size(88, 32);
			this.y.TabIndex = 1;
			this.y.Text = "&Cancel";
			this.z.Location = new Point(88, 160);
			this.z.Name = "BUTTON_OK";
			this.z.Size = new Size(88, 32);
			this.z.TabIndex = 0;
			this.z.Text = "&OK";
			this.r.Columns.AddRange(new ColumnHeader[]
			{
				this.w,
				this.x
			});
			this.r.Dock = DockStyle.Top;
			this.r.FullRowSelect = true;
			this.r.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			this.r.HideSelection = false;
			this.r.Location = new Point(0, 0);
			this.r.MultiSelect = false;
			this.r.Name = "LC_CONNECTEDDEV";
			this.r.Size = new Size(280, 152);
			this.r.Sorting = SortOrder.Ascending;
			this.r.TabIndex = 2;
			this.r.View = View.Details;
			this.w.Text = "IP Address";
			this.w.Width = 140;
			this.x.Text = "Serial Number";
			this.x.Width = 140;
			base.AcceptButton = this.z;
			base.AutoScaleMode = AutoScaleMode.None;
			this.AutoScaleBaseSize = new Size(5, 15);
			base.ClientSize = new Size(280, 199);
			base.Controls.Add(this.p);
			this.Font = new Font("Arial Unicode MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CDevConList";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "deviceconlist";
			this.p.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003C84 File Offset: 0x00002C84
		private void b()
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 3;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							goto IL_77;
						case 1:
							goto IL_140;
						case 2:
						{
							if (num2 >= this.o.Count)
							{
								num = 4;
								continue;
							}
							ListViewItem listViewItem = new ListViewItem(string.Empty, 0);
							listViewItem.Text = ((DeviceInfo)this.o[num2]).strIp;
							listViewItem.SubItems.Add(((DeviceInfo)this.o[num2]).strSerialNo);
							this.u.Items.Add(listViewItem);
							num2++;
							num = 5;
							continue;
						}
						case 4:
							this.u.Items[0].Selected = true;
							num = 1;
							continue;
						case 5:
							goto IL_77;
						case 6:
							goto IL_53;
						}
						if (this.o.Count <= 0)
						{
							num = 6;
							continue;
						}
						num2 = 0;
						num = 0;
						continue;
						IL_77:
						num = 2;
					}
					IL_53:
					CCustomException ex = CustomExceptionHandler.a(1687U, base.GetType().ToString(), "PopulateListview", Environment.StackTrace);
					throw ex;
					IL_140:
					break;
				}
				}
			}
			catch (CCustomException ex2)
			{
				throw ex2;
			}
			catch (Exception ex3)
			{
				if (CCustomException.CheckErrorIDExsists(ex3))
				{
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_197;
						}
					}
					IL_197:
					if (false)
					{
					}
					CCustomException.Rethrow(ex3);
				}
				else
				{
					ex3.Source = 1665U.ToString() + "| " + ex3.Source;
					CCustomException.Rethrow(ex3);
				}
			}
			if (true)
			{
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003E80 File Offset: 0x00002E80
		private void a(object A_0)
		{
			try
			{
				switch (0)
				{
				default:
				{
					Panel panel = (Panel)A_0;
					Control.ControlCollection controls = panel.Controls;
					IEnumerator enumerator = controls.GetEnumerator();
					try
					{
						int num = 5;
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								Control control;
								control.Click -= this.b;
								control.Click += this.b;
								num = 6;
								continue;
							}
							case 2:
							{
								Control control;
								((ListViewTemplate)control).SelectedIndexChanged -= this.a;
								((ListViewTemplate)control).SelectedIndexChanged += this.a;
								this.u = (ListViewTemplate)control;
								num = 7;
								continue;
							}
							case 3:
							{
								Control control;
								this.a(control);
								num = 4;
								continue;
							}
							case 6:
							{
								Control control;
								if (control.Name.Equals("BUTTON_OK"))
								{
									num = 10;
									continue;
								}
								break;
							}
							case 8:
								num = 13;
								continue;
							case 9:
							{
								string text;
								if (text.Equals("panel_template.CPanelTemplate"))
								{
									num = 3;
									continue;
								}
								num = 11;
								continue;
							}
							case 10:
							{
								Control control;
								this.t = (Button)control;
								num = 1;
								continue;
							}
							case 11:
							{
								string text;
								if (text.Equals("System.Windows.Forms.Button"))
								{
									num = 0;
									continue;
								}
								num = 14;
								continue;
							}
							case 12:
							{
								if (!enumerator.MoveNext())
								{
									num = 8;
									continue;
								}
								Control control = (Control)enumerator.Current;
								string text = control.GetType().ToString();
								num = 9;
								continue;
							}
							case 13:
								goto IL_212;
							case 14:
							{
								string text;
								if (text.Equals("mototrbodepottool.ListViewTemplate"))
								{
									num = 2;
									continue;
								}
								break;
							}
							}
							IL_146:
							num = 12;
							continue;
							goto IL_146;
						}
						IL_212:;
					}
					finally
					{
						for (;;)
						{
							for (;;)
							{
								IDisposable disposable = enumerator as IDisposable;
								int num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_276;
									case 1:
										if (disposable != null)
										{
											num = 2;
											continue;
										}
										goto IL_278;
									case 2:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											if (false)
											{
											}
											disposable.Dispose();
											num = 0;
											continue;
										}
										break;
									}
									break;
								}
							}
						}
						IL_276:
						IL_278:;
					}
					break;
				}
				}
			}
			catch (Exception ex)
			{
				if (CCustomException.CheckErrorIDExsists(ex))
				{
					CCustomException.Rethrow(ex);
				}
				else
				{
					ex.Source = 1666U.ToString() + "| " + ex.Source;
					CCustomException.Rethrow(ex);
				}
			}
			if (true)
			{
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004198 File Offset: 0x00003198
		private void b(object A_0, EventArgs A_1)
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
							Button button = (Button)A_0;
							int num = 6;
							for (;;)
							{
								switch (num)
								{
								case 0:
								{
									string name;
									if (!(name == "BUTTON_OK"))
									{
										num = 5;
										continue;
									}
									base.DialogResult = DialogResult.OK;
									ListViewItem listViewItem = this.u.SelectedItems[0];
									this.v = listViewItem.Text;
									num = 3;
									continue;
								}
								case 1:
									num = 0;
									continue;
								case 2:
									goto IL_11A;
								case 3:
									goto IL_10E;
								case 4:
								{
									string name;
									if (!(name == "BUTTON_CANCEL"))
									{
										num = 7;
										continue;
									}
									goto IL_10E;
								}
								case 5:
									num = 4;
									continue;
								case 6:
								{
									string name;
									if ((name = button.Name) != null)
									{
										num = 1;
										continue;
									}
									goto IL_10E;
								}
								case 7:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_00;
									default:
										if (false)
										{
										}
										num = 8;
										continue;
									}
									break;
								case 8:
									goto IL_10E;
								}
								break;
								IL_10E:
								num = 2;
							}
						}
						break;
					}
				}
				IL_11A:;
			}
			catch (Exception ex)
			{
				ex.Source = 1667U.ToString() + "| " + ex.Source;
				CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000431C File Offset: 0x0000331C
		private void a(object A_0, EventArgs A_1)
		{
			ListViewTemplate listViewTemplate = (ListViewTemplate)A_0;
			if (listViewTemplate.SelectedItems.Count > 0)
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
					this.t.Enabled = true;
					return;
				}
			}
			this.t.Enabled = false;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004388 File Offset: 0x00003388
		private void a()
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
			int num = common.b.a(this, 10, true);
			common.b.a(this, 20, true);
			int num2 = common.b.a(this, 40, true);
			common.b.a(this);
			common.b.a(this.u);
			this.u.Columns[0].Width = common.b.a(this.u, this.u.Columns[0].Width, false);
			this.u.Columns[1].Width = common.b.a(this.u, this.u.Columns[1].Width, true);
			common.b.a(this.z);
			common.b.a(this.y);
			common.b.b(this.z);
			common.b.b(this.y);
			base.Width += 4;
			this.p.Width = base.Width;
			this.u.Width = base.Width;
			int num3 = this.u.Bottom + num;
			this.z.Location = new Point(this.z.Location.X + 4, num3);
			this.y.Location = new Point(this.y.Location.X + 4, num3);
			base.Height = this.z.Bottom + num2;
		}

		// Token: 0x04000017 RID: 23
		private const int a = 20;

		// Token: 0x04000018 RID: 24
		private const int b = 10;

		// Token: 0x04000019 RID: 25
		private const int c = 4;

		// Token: 0x0400001A RID: 26
		private const int d = 40;

		// Token: 0x0400001B RID: 27
		private CResourceHandler k;

		// Token: 0x0400001C RID: 28
		private bool m;

		// Token: 0x0400001D RID: 29
		private string n;

		// Token: 0x0400001E RID: 30
		private ArrayList o;

		// Token: 0x0400001F RID: 31
		private Panel p;

		// Token: 0x04000020 RID: 32
		private ListViewTemplate r;

		// Token: 0x04000021 RID: 33
		private ColumnHeader s;

		// Token: 0x04000022 RID: 34
		private Button t;

		// Token: 0x04000023 RID: 35
		private ListViewTemplate u;

		// Token: 0x04000024 RID: 36
		public string v;

		// Token: 0x04000025 RID: 37
		private ColumnHeader w;

		// Token: 0x04000026 RID: 38
		private ColumnHeader x;

		// Token: 0x04000027 RID: 39
		private Button y;

		// Token: 0x04000028 RID: 40
		private Button z;

		// Token: 0x04000029 RID: 41
		private Container aa;
	}
}
