using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Controller;
using custom_controls;
using custom_exception;
using RegistryAccess;
using resource_handler;

namespace mototrbodepottool
{
	// Token: 0x02000003 RID: 3
	public partial class a : CFormTemplate
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000111C
		public a(string A_0, bool A_1, CResourceHandler A_2, IController A_3, IPersistentApplicationSettings A_4)
		{
			this.b = A_0;
			this.c = A_1;
			this.d = A_2;
			this.e = A_3;
			this.l = false;
			this.f = 0U;
			this.g = A_4;
			this.a();
			this.a(this);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002170 File Offset: 0x00001170
		private void a(object A_0)
		{
			try
			{
				switch (0)
				{
				default:
				{
					CFormTemplate cformTemplate = (CFormTemplate)A_0;
					Control.ControlCollection controls = cformTemplate.Controls;
					IEnumerator enumerator = controls.GetEnumerator();
					try
					{
						int num = 7;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_212;
							case 1:
								this.k.Text = this.d.GetString("LBL_DERIVEDKEY");
								num = 8;
								continue;
							case 2:
							{
								string text;
								if (!text.Equals(typeof(CCustomTextBox).ToString()))
								{
									num = 3;
									continue;
								}
								goto IL_1B5;
							}
							case 3:
								num = 6;
								continue;
							case 6:
							{
								string text;
								if (text.Equals(typeof(TextBox).ToString()))
								{
									num = 10;
									continue;
								}
								num = 14;
								continue;
							}
							case 9:
							{
								if (!enumerator.MoveNext())
								{
									num = 12;
									continue;
								}
								Control control = (Control)enumerator.Current;
								string text = control.GetType().ToString();
								num = 13;
								continue;
							}
							case 10:
								goto IL_1B5;
							case 11:
							{
								Control control;
								control.Text = this.d.GetString(control.Name);
								control.Click -= this.c;
								control.Click += this.c;
								num = 5;
								continue;
							}
							case 12:
								num = 0;
								continue;
							case 13:
							{
								string text;
								if (text.Equals("System.Windows.Forms.Button"))
								{
									num = 11;
									continue;
								}
								num = 2;
								continue;
							}
							case 14:
							{
								string text;
								if (text.Equals("System.Windows.Forms.Label"))
								{
									num = 1;
									continue;
								}
								break;
							}
							}
							IL_EC:
							num = 9;
							continue;
							goto IL_EC;
							IL_1B5:
							this.j.Focus();
							num = 4;
						}
						IL_212:;
					}
					finally
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
									disposable.Dispose();
									num = 2;
									continue;
								case 1:
									if (disposable != null)
									{
										num = 0;
										continue;
									}
									goto IL_25C;
								case 2:
									goto IL_25A;
								}
								break;
							}
						}
						IL_25A:
						IL_25C:;
					}
					break;
				}
				}
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				if (!CCustomException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = 1666U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
					goto IL_2A9;
				}
				IL_271:
				CCustomException.Rethrow(ex2);
				IL_2A9:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_271;
				default:
					if (true)
					{
					}
					if (false)
					{
					}
					break;
				}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000024A4 File Offset: 0x000014A4
		public string b()
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
			return this.j.Text.Trim();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000024F0 File Offset: 0x000014F0
		private void c(object A_0, EventArgs A_1)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						Button button = (Button)A_0;
						int num = 8;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_EC;
							case 1:
							{
								string name;
								if (!(name == "BUTTON_CANCEL"))
								{
									num = 3;
									continue;
								}
								base.Close();
								num = 7;
								continue;
							}
							case 2:
							{
								string name;
								if (!(name == "BUTTON_UNKILL"))
								{
									num = 5;
									continue;
								}
								this.l = true;
								base.Close();
								num = 0;
								continue;
							}
							case 3:
								num = 2;
								continue;
							case 4:
								num = 1;
								continue;
							case 5:
								num = 6;
								continue;
							case 6:
								goto IL_EC;
							case 7:
								goto IL_EC;
							case 8:
							{
								string name;
								if ((name = button.Name) != null)
								{
									num = 4;
									continue;
								}
								goto IL_EC;
							}
							case 9:
								goto IL_F8;
							}
							break;
							IL_EC:
							num = 9;
						}
					}
					IL_F8:
					break;
				}
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				if (CCustomException.CheckErrorIDExsists(ex2))
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
						CCustomException.Rethrow(ex2);
						goto IL_160;
					}
				}
				if (true)
				{
				}
				ex2.Source = 1662U.ToString() + "| " + ex2.Source;
				CCustomException.Rethrow(ex2);
				IL_160:;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002688 File Offset: 0x00001688
		private void b(object A_0, EventArgs A_1)
		{
			try
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_91;
						}
						break;
					case 1:
						this.h.Enabled = true;
						num = 3;
						continue;
					case 3:
						goto IL_73;
					case 4:
						goto IL_73;
					}
					if (this.j.Text.Trim().Length == 32)
					{
						num = 1;
						continue;
					}
					this.h.Enabled = false;
					num = 4;
					continue;
					IL_73:
					num = 0;
				}
				IL_91:
				if (false)
				{
				}
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				if (CCustomException.CheckErrorIDExsists(ex2))
				{
					if (true)
					{
					}
					CCustomException.Rethrow(ex2);
				}
				else
				{
					ex2.Source = 1721U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000027A0 File Offset: 0x000017A0
		private void a()
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
			new ComponentResourceManager(typeof(CMainFrame));
			this.h = new Button();
			this.i = new Button();
			this.j = new CCustomTextBox();
			this.k = new Label();
			base.SuspendLayout();
			this.k.Font = new Font("Arial Unicode MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 177);
			this.k.Location = new Point(20, 16);
			this.k.Name = "LBL_DERIVEDKEY";
			this.k.Size = new Size(100, 22);
			this.k.TabIndex = 1;
			this.j.DetectUrls = false;
			this.j.Location = new Point(120, 16);
			this.j.Maximum = 0L;
			this.j.Minimum = 0L;
			this.j.Multiline = false;
			this.j.Name = "TXTBOX_DERIVEDKEY";
			this.j.PasswordChar = '\0';
			this.j.RestrictedChars = "";
			this.j.Size = new Size(250, 22);
			this.j.TabIndex = 0;
			this.j.Text = "";
			this.j.TextModified = true;
			this.j.ValueType = CCustomTextBox.valueTypes.Alphanumeric;
			this.j.TextChanged += this.b;
			this.h.BackColor = SystemColors.ControlLight;
			this.h.Location = new Point(220, 80);
			this.h.Name = "BUTTON_UNKILL";
			this.h.Size = new Size(72, 24);
			this.h.TabIndex = 2;
			this.i.BackColor = SystemColors.ControlLight;
			this.i.Location = new Point(100, 80);
			this.i.Name = "BUTTON_CANCEL";
			this.i.Size = new Size(72, 24);
			this.i.TabIndex = 3;
			base.TopMost = true;
			base.AcceptButton = this.h;
			this.AutoScaleBaseSize = new Size(5, 15);
			this.BackColor = Color.FloralWhite;
			base.ClientSize = new Size(400, 112);
			base.Controls.Add(this.k);
			base.Controls.Add(this.j);
			base.Controls.Add(this.i);
			base.Controls.Add(this.h);
			this.Font = new Font("Arial Unicode MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Name = "CDerivedKey";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = this.d.GetString("UNKILL_RADIO");
			base.Load += this.a;
			base.ResumeLayout(true);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002AF0 File Offset: 0x00001AF0
		private void a(object A_0, EventArgs A_1)
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
			this.h.Enabled = false;
			base.Activate();
		}

		// Token: 0x04000003 RID: 3
		private const short a = 32;

		// Token: 0x04000004 RID: 4
		private string b;

		// Token: 0x04000005 RID: 5
		private bool c;

		// Token: 0x04000006 RID: 6
		private CResourceHandler d;

		// Token: 0x04000007 RID: 7
		private IController e;

		// Token: 0x04000008 RID: 8
		public uint f;

		// Token: 0x04000009 RID: 9
		public IPersistentApplicationSettings g;

		// Token: 0x0400000A RID: 10
		private Button h;

		// Token: 0x0400000B RID: 11
		private Button i;

		// Token: 0x0400000C RID: 12
		private CCustomTextBox j;

		// Token: 0x0400000D RID: 13
		private Label k;

		// Token: 0x0400000E RID: 14
		public bool l;
	}
}
