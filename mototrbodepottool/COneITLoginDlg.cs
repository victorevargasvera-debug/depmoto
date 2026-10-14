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
	// Token: 0x0200000C RID: 12
	public partial class COneITLoginDlg : CFormTemplate
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00004D14 File Offset: 0x00003D14
		public COneITLoginDlg(string A_0, bool A_1, CResourceHandler A_2, IController A_3, bool A_4, IPersistentApplicationSettings A_5)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
			this.d = A_3;
			this.h = false;
			this.e = 0U;
			this.i = A_4;
			this.j = A_5;
			this.a();
			this.a(this);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004D70 File Offset: 0x00003D70
		protected virtual void a(bool A_0)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_7C:
				if (this.r == null)
				{
					goto IL_8E;
				}
				num = 0;
				break;
			default:
				if (false)
				{
				}
				num = 2;
				break;
			}
			for (;;)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 0:
					this.r.Dispose();
					num = 3;
					continue;
				case 1:
					num = 4;
					continue;
				case 3:
					goto IL_72;
				case 4:
					goto IL_7C;
				}
				if (!A_0)
				{
					break;
				}
				num = 1;
			}
			IL_72:
			IL_8E:
			base.Dispose(A_0);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004E14 File Offset: 0x00003E14
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CMainFrame));
			this.k = new Button();
			this.m = new Button();
			this.n = new CCustomTextBox();
			this.q = new CCustomTextBox();
			this.o = new Label();
			this.p = new Label();
			base.SuspendLayout();
			this.k.BackColor = SystemColors.ControlLight;
			this.k.Location = new Point(53, 80);
			this.k.Name = "BUTTON_OK";
			this.k.Size = new Size(72, 24);
			this.k.TabIndex = 2;
			this.m.BackColor = SystemColors.ControlLight;
			this.m.Location = new Point(141, 80);
			this.m.Name = "BUTTON_CANCEL";
			this.m.Size = new Size(72, 24);
			this.m.TabIndex = 3;
			this.n.DetectUrls = false;
			this.n.Location = new Point(120, 16);
			this.n.Maximum = 0L;
			this.n.Minimum = 0L;
			this.n.Multiline = false;
			this.n.Name = "TXTBOX_USERID";
			this.n.PasswordChar = '\0';
			this.n.RestrictedChars = "";
			this.n.Size = new Size(136, 22);
			this.n.TabIndex = 0;
			this.n.Text = "";
			this.n.TextModified = true;
			this.n.ValueType = CCustomTextBox.valueTypes.Alphanumeric;
			this.n.TextChanged += this.a;
			this.q.DetectUrls = false;
			this.q.Location = new Point(120, 48);
			this.q.Maximum = 0L;
			this.q.Minimum = 0L;
			this.q.Multiline = false;
			this.q.Name = "TXTBOX_PASSWORD";
			this.q.PasswordChar = '●';
			this.q.Size = new Size(136, 22);
			this.q.TabIndex = 1;
			this.q.Text = "";
			this.q.TextModified = true;
			this.q.ValueType = CCustomTextBox.valueTypes.Alphanumeric;
			this.q.TextChanged += this.b;
			this.o.Font = new Font("Arial Unicode MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 177);
			this.o.Location = new Point(24, 16);
			this.o.Name = "LBL_USERID";
			this.o.Size = new Size(80, 22);
			this.o.TabIndex = 1;
			this.p.Font = new Font("Arial Unicode MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 177);
			this.p.Location = new Point(24, 48);
			this.p.Name = "LBL_PASSWORD";
			this.p.Size = new Size(80, 22);
			this.p.TabIndex = 3;
			base.TopMost = true;
			base.AcceptButton = this.k;
			this.AutoScaleBaseSize = new Size(5, 15);
			this.BackColor = Color.FloralWhite;
			base.ClientSize = new Size(300, 112);
			base.Controls.Add(this.p);
			base.Controls.Add(this.o);
			base.Controls.Add(this.m);
			base.Controls.Add(this.k);
			base.Controls.Add(this.q);
			base.Controls.Add(this.n);
			this.Font = new Font("Arial Unicode MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Name = "COneITLoginDlg";
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Motorola Applications Directory Login";
			base.Load += this.c;
			base.ResumeLayout(true);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000052D0 File Offset: 0x000042D0
		private void a(object A_0)
		{
			try
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
					switch (0)
					{
					}
					break;
				}
				CFormTemplate cformTemplate = (CFormTemplate)A_0;
				Control.ControlCollection controls = cformTemplate.Controls;
				IEnumerator enumerator = controls.GetEnumerator();
				try
				{
					int num = 10;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.p.Text = this.c.GetString("LBL_PASSWORD");
							this.o.Text = this.c.GetString("LBL_USERID");
							num = 8;
							continue;
						case 2:
						{
							string text;
							if (text.Equals("System.Windows.Forms.Label"))
							{
								num = 0;
								continue;
							}
							break;
						}
						case 3:
						{
							string text;
							if (text.Equals("System.Windows.Forms.Button"))
							{
								num = 4;
								continue;
							}
							num = 12;
							continue;
						}
						case 4:
						{
							Control control;
							control.Text = this.c.GetString(control.Name);
							control.Click -= this.d;
							control.Click += this.d;
							num = 13;
							continue;
						}
						case 5:
							goto IL_1EF;
						case 6:
							num = 14;
							continue;
						case 7:
						{
							string text;
							if (text.Equals(typeof(TextBox).ToString()))
							{
								num = 5;
								continue;
							}
							num = 2;
							continue;
						}
						case 9:
						{
							if (!enumerator.MoveNext())
							{
								num = 6;
								continue;
							}
							Control control = (Control)enumerator.Current;
							string text = control.GetType().ToString();
							num = 3;
							continue;
						}
						case 11:
							num = 7;
							continue;
						case 12:
						{
							string text;
							if (!text.Equals(typeof(CCustomTextBox).ToString()))
							{
								num = 11;
								continue;
							}
							goto IL_1EF;
						}
						case 14:
							goto IL_24C;
						}
						IL_108:
						num = 9;
						continue;
						goto IL_108;
						IL_1EF:
						this.n.Focus();
						num = 1;
					}
					IL_24C:;
				}
				finally
				{
					for (;;)
					{
						IDisposable disposable = enumerator as IDisposable;
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
								goto IL_296;
							case 1:
								disposable.Dispose();
								num = 2;
								continue;
							case 2:
								goto IL_294;
							}
							break;
						}
					}
					IL_294:
					IL_296:;
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
					CCustomException.Rethrow(ex2);
				}
				else
				{
					ex2.Source = 1666U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
			if (true)
			{
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005620 File Offset: 0x00004620
		private void d(object A_0, EventArgs A_1)
		{
			try
			{
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
								goto IL_24B;
							case 1:
							{
								string name;
								if (!(name == "BUTTON_CANCEL"))
								{
									num = 5;
									continue;
								}
								goto IL_223;
							}
							case 2:
								goto IL_24B;
							case 3:
								num = 1;
								continue;
							case 4:
								num = 0;
								continue;
							case 5:
								num = 7;
								continue;
							case 6:
							{
								string name;
								if ((name = button.Name) != null)
								{
									num = 3;
									continue;
								}
								goto IL_24B;
							}
							case 7:
							{
								string name;
								if (!(name == "BUTTON_OK"))
								{
									num = 4;
									continue;
								}
								try
								{
									this.d.VerifyUserLogin(this.n.Text, this.q.Text);
									this.h = true;
									base.Close();
									goto IL_24B;
								}
								catch (CCustomException ex)
								{
									if (this.i)
									{
										CPlaySound cplaySound = new CPlaySound(this.b, this.j, this.c);
										cplaySound.b(CPlaySound.SoundType.b);
									}
									CMsgDialog cmsgDialog;
									for (;;)
									{
										cmsgDialog = new CMsgDialog(true, this.c, (int)ex.ErrorID, "DT_APP_NAME", null);
										if (cmsgDialog == null)
										{
											break;
										}
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_16B;
										}
									}
									CCustomException ex2 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "Control_Clicked", Environment.StackTrace);
									throw ex2;
									IL_16B:
									if (false)
									{
									}
									cmsgDialog.Show(this, false, DialogResult.OK, MessageBoxButtons.OK, MessageBoxIcon.Hand);
									this.n.Text = string.Empty;
									this.q.Text = string.Empty;
									this.n.Focus();
									goto IL_24B;
								}
								catch (Exception ex3)
								{
									if (this.i)
									{
										CPlaySound cplaySound2 = new CPlaySound(this.b, this.j, this.c);
										cplaySound2.b(CPlaySound.SoundType.b);
									}
									if (CCustomException.CheckErrorIDExsists(ex3))
									{
										CCustomException.Rethrow(ex3);
									}
									else
									{
										ex3.Source = 1662U.ToString() + "| " + ex3.Source;
										CCustomException.Rethrow(ex3);
									}
									goto IL_24B;
								}
								goto IL_223;
							}
							case 8:
								goto IL_257;
							}
							break;
							IL_223:
							base.Close();
							num = 2;
							continue;
							IL_24B:
							num = 8;
						}
					}
					IL_257:
					break;
				}
			}
			catch (CCustomException ex4)
			{
				throw ex4;
			}
			catch (Exception ex5)
			{
				if (CCustomException.CheckErrorIDExsists(ex5))
				{
					CCustomException.Rethrow(ex5);
				}
				else
				{
					ex5.Source = 1662U.ToString() + "| " + ex5.Source;
					CCustomException.Rethrow(ex5);
				}
			}
			if (true)
			{
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005948 File Offset: 0x00004948
		private void c(object A_0, EventArgs A_1)
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
			this.k.Enabled = false;
			base.Activate();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005998 File Offset: 0x00004998
		private void b(object A_0, EventArgs A_1)
		{
			try
			{
				int num = 6;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (this.q.Text.Trim().Length == 0)
						{
							num = 1;
							continue;
						}
						this.k.Enabled = true;
						num = 5;
						continue;
					case 1:
						goto IL_AE;
					case 2:
						goto IL_D2;
					case 3:
						goto IL_C7;
					case 4:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AC;
						default:
							if (false)
							{
							}
							num = 0;
							continue;
						}
						break;
					case 5:
						goto IL_AC;
					}
					if (this.n.Text.Trim().Length != 0)
					{
						num = 4;
						continue;
					}
					IL_AE:
					this.k.Enabled = false;
					num = 3;
					continue;
					IL_C7:
					num = 2;
					continue;
					IL_AC:
					goto IL_C7;
				}
				IL_D2:;
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

		// Token: 0x0600003B RID: 59 RVA: 0x00005AEC File Offset: 0x00004AEC
		private void a(object A_0, EventArgs A_1)
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
			this.b(A_0, A_1);
		}

		// Token: 0x04000102 RID: 258
		private string a;

		// Token: 0x04000103 RID: 259
		private bool b;

		// Token: 0x04000104 RID: 260
		private CResourceHandler c;

		// Token: 0x04000105 RID: 261
		private IController d;

		// Token: 0x04000106 RID: 262
		public uint e;

		// Token: 0x04000107 RID: 263
		public bool h;

		// Token: 0x04000108 RID: 264
		public bool i;

		// Token: 0x04000109 RID: 265
		public IPersistentApplicationSettings j;

		// Token: 0x0400010A RID: 266
		private Button k;

		// Token: 0x0400010B RID: 267
		private Button m;

		// Token: 0x0400010C RID: 268
		private CCustomTextBox n;

		// Token: 0x0400010D RID: 269
		private Label o;

		// Token: 0x0400010E RID: 270
		private Label p;

		// Token: 0x0400010F RID: 271
		public CCustomTextBox q;

		// Token: 0x04000110 RID: 272
		private Container r;
	}
}
