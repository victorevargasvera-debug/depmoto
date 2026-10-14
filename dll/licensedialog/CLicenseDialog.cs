using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using custom_controls;
using custom_exception;
using flex_licensing;
using resource_handler;

namespace licensing
{
	// Token: 0x02000006 RID: 6
	public partial class CLicenseDialog : CFormTemplate
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002228 File Offset: 0x00001228
		public CLicenseDialog(CResourceHandler resHandler, string feature, string version, string path)
		{
			this.a();
			if (path != null && path.Length != 0 && version != null && version.Length != 0 && Directory.Exists(path))
			{
				while (resHandler != null)
				{
					try
					{
						this.c = Path.GetDirectoryName(path);
						this.e = resHandler;
						this.Text = this.e.GetString("LICENSE_DIALOG");
						this.a(base.Controls);
						this.a(0);
						this.d = new CLicenseManager(feature, version);
						this.d.SetLicenseDir(this.c);
						base.StartPosition = FormStartPosition.CenterScreen;
						return;
					}
					catch (CCustomException ex)
					{
						throw ex;
					}
					catch (Exception ex2)
					{
						if (!CCustomException.CheckErrorIDExsists(ex2))
						{
							ex2.Source = 3456U.ToString() + "|" + ex2.Source;
						}
						CCustomException.Rethrow(ex2);
						return;
					}
				}
			}
			CCustomException ex3 = CCustomExceptionHandler.CreateException(3454U, base.GetType().ToString(), "CLicenseDialog", Environment.StackTrace);
			throw ex3;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000235C File Offset: 0x0000135C
		public CLicenseDialog(CResourceHandler resHandler, ArrayList featureList, string version, string path)
		{
			this.a();
			if (path != null && path.Length != 0 && version != null && version.Length != 0 && Directory.Exists(path))
			{
				while (resHandler != null)
				{
					try
					{
						this.c = Path.GetDirectoryName(path);
						this.e = resHandler;
						this.Text = this.e.GetString("LICENSE_DIALOG");
						this.a(base.Controls);
						this.a(0);
						this.d = new CLicenseManager(featureList, version);
						this.d.SetLicenseDir(this.c);
						base.StartPosition = FormStartPosition.CenterScreen;
						return;
					}
					catch (CCustomException ex)
					{
						throw ex;
					}
					catch (Exception ex2)
					{
						if (!CCustomException.CheckErrorIDExsists(ex2))
						{
							ex2.Source = 3456U.ToString() + "|" + ex2.Source;
						}
						CCustomException.Rethrow(ex2);
						return;
					}
				}
			}
			CCustomException ex3 = CCustomExceptionHandler.CreateException(3454U, base.GetType().ToString(), "CLicenseDialog", Environment.StackTrace);
			throw ex3;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002490 File Offset: 0x00001490
		private void a(Control.ControlCollection A_0)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				IEnumerator enumerator = A_0.GetEnumerator();
				try
				{
					int num = 6;
					for (;;)
					{
						switch (num)
						{
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = 14;
								continue;
							}
							Control control = (Control)enumerator.Current;
							string text = control.GetType().ToString();
							num = 5;
							continue;
						}
						case 4:
						{
							string text2;
							if (!(text2 == "System.Windows.Forms.Button"))
							{
								num = 12;
								continue;
							}
							Control control;
							control.TabStop = true;
							control.Text = this.e.GetString(control.Name);
							control.Click -= this.a;
							control.Click += this.a;
							num = 15;
							continue;
						}
						case 5:
						{
							string text;
							string text2;
							if ((text2 = text) != null)
							{
								num = 13;
								continue;
							}
							break;
						}
						case 7:
						{
							string text2;
							if (!(text2 == "System.Windows.Forms.Label"))
							{
								num = 17;
								continue;
							}
							Control control;
							control.TabStop = false;
							control.Text = this.e.GetString(control.Name);
							num = 2;
							continue;
						}
						case 8:
							num = 7;
							continue;
						case 9:
						{
							string text2;
							if (!(text2 == "CustomTextBox.CCustomTextBox"))
							{
								num = 8;
								continue;
							}
							Control control;
							control.TabStop = false;
							this.n.ReadOnly = true;
							this.n.ValueType = CCustomTextBox.valueTypes.Alphanumeric;
							this.n.BorderStyle = BorderStyle.None;
							this.n.BackColor = this.l.BackColor;
							string @string = this.e.GetString("LIC_MENU_COPY");
							this.n.LoadMenuText(string.Empty, @string, string.Empty, string.Empty, string.Empty);
							this.n.ContextMenuStrip.Items.Remove(this.n.MenuCut);
							this.n.ContextMenuStrip.Items.Remove(this.n.MenuPaste);
							this.n.ContextMenuStrip.Items.Remove(this.n.MenuDelete);
							this.n.ContextMenuStrip.Opening -= new CancelEventHandler(this.b);
							this.n.ContextMenuStrip.Opening += new CancelEventHandler(this.b);
							num = 0;
							continue;
						}
						case 11:
							num = 4;
							continue;
						case 12:
							num = 9;
							continue;
						case 13:
							num = 16;
							continue;
						case 14:
							num = 18;
							continue;
						case 16:
						{
							string text2;
							if (!(text2 == "System.Windows.Forms.Panel"))
							{
								num = 11;
								continue;
							}
							Control control;
							Panel panel = (Panel)control;
							Control.ControlCollection controls = panel.Controls;
							this.a(controls);
							num = 1;
							continue;
						}
						case 17:
							num = 10;
							continue;
						case 18:
							goto IL_376;
						}
						IL_155:
						num = 3;
						continue;
						goto IL_155;
					}
					IL_376:;
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
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_3B5;
								default:
									goto IL_3D4;
								}
								break;
							case 1:
								if (disposable != null)
								{
									num = 2;
									continue;
								}
								goto IL_3DC;
							case 2:
								disposable.Dispose();
								goto IL_3B5;
							}
							break;
							IL_3B5:
							num = 0;
						}
					}
					IL_3D4:
					if (false)
					{
					}
					IL_3DC:;
				}
				return;
			}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000028A0 File Offset: 0x000018A0
		public bool VerifyLicense(int featureID)
		{
			bool result;
			try
			{
				this.d.ValidateFeature(featureID);
				result = true;
			}
			catch (CCustomException ex)
			{
				uint errorID = ex.ErrorID;
				if (errorID != 3290U)
				{
					if (errorID != 3368U)
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
							this.f.Text = ex.ErrorID.ToString(CultureInfo.InvariantCulture);
							this.h.Text = this.e.GetString("LIC_INVALID_GENERAL");
							string text = this.e.GetString("LIC_INVALID_GENERAL_INFO");
							string @string = this.e.GetString("LIC_CONTACT");
							text = text.Replace("%1", @string);
							this.g.Text = text;
							return false;
						}
						}
					}
					this.f.Text = 3368U.ToString(CultureInfo.InvariantCulture);
					this.h.Text = this.e.GetString("LIC_LM_BADSYSDATE");
					this.g.Text = this.e.GetString("LIC_LM_BADSYSDATE_INFO");
					this.b();
					result = false;
				}
				else
				{
					this.f.Text = ex.ErrorID.ToString(CultureInfo.InvariantCulture);
					this.h.Text = this.e.GetString("LIC_LONGGONE");
					string text2 = this.e.GetString("LIC_LONGGONE_INFO");
					string string2 = this.e.GetString("LIC_CONTACT");
					text2 = text2.Replace("%1", string2);
					this.g.Text = text2;
					this.b();
					result = false;
				}
			}
			catch (Exception ex2)
			{
				if (!CCustomException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = ex2.Source + "| " + ex2.Message;
					CCustomException ex3 = new CCustomException(3459U, ex2.Source, "VerifyLicense", ex2.Source + ex2.StackTrace);
					throw ex3;
				}
				CCustomException.Rethrow(ex2);
				result = false;
			}
			return result;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002B14 File Offset: 0x00001B14
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
			this.i.Hide();
			this.j.Location = new Point(this.j.Parent.Width / 2 - this.j.Width / 2, this.j.Location.Y);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002BA0 File Offset: 0x00001BA0
		private void a(int A_0)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_79;
				case 1:
					goto IL_B2;
				case 3:
					num = 1;
					continue;
				case 4:
					goto IL_D4;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_B2:
					if (this.l.Visible)
					{
						return;
					}
					num = 4;
					break;
				default:
					if (false)
					{
					}
					if (A_0 == 1)
					{
						num = 3;
					}
					else
					{
						this.l.Hide();
						base.Height -= this.l.Height;
						num = 0;
					}
					break;
				}
			}
			IL_79:
			return;
			IL_D4:
			if (true)
			{
			}
			this.l.Show();
			base.Height += this.l.Height;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002C84 File Offset: 0x00001C84
		public void Generate()
		{
			try
			{
				int num = 0;
				string text = null;
				this.d.GetAuthCode(ref text, ref num);
				this.n.Clear();
				this.n.Text = text;
				this.a(1);
				this.i.Enabled = false;
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				if (!CCustomException.CheckErrorIDExsists(ex2))
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
						ex2.Source = 3457U.ToString() + "|" + ex2.Source;
						break;
					}
				}
				throw ex2;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002D50 File Offset: 0x00001D50
		public void Copy()
		{
			try
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_8A;
					case 2:
						if (true)
						{
						}
						goto IL_82;
					case 3:
					{
						DataObject dataObject = new DataObject();
						dataObject.SetData(DataFormats.UnicodeText, this.n.Text);
						Clipboard.SetDataObject(dataObject);
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							num = 2;
							continue;
						}
						break;
					}
					}
					if (this.n != null)
					{
						num = 3;
						continue;
					}
					IL_82:
					num = 1;
				}
				IL_8A:;
			}
			catch (Exception ex)
			{
				ex.Source = 3458U.ToString() + "|" + ex.Source;
				CCustomException.Rethrow(ex);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002E30 File Offset: 0x00001E30
		private void b(object A_0, EventArgs A_1)
		{
			if (true)
			{
			}
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
						break;
					default:
						if (false)
						{
						}
						this.n.SelectAll();
						this.n.MenuCopy.Enabled = true;
						num = 2;
						continue;
					}
					break;
				case 2:
					return;
				}
				if (this.n.MenuCopy == null)
				{
					break;
				}
				num = 0;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002EC4 File Offset: 0x00001EC4
		private void a(object A_0, EventArgs A_1)
		{
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
						if (!(name == "BTN_LICENSEEXIT"))
						{
							num = 8;
							continue;
						}
						goto IL_52;
					}
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B3;
						default:
							goto IL_6F;
						}
						break;
					case 2:
						num = 0;
						continue;
					case 3:
					{
						string name;
						if (!(name == "BTN_GENERATEAUTHCODE"))
						{
							num = 7;
							continue;
						}
						goto IL_E8;
					}
					case 4:
					{
						string name;
						if (!(name == "BTN_LICENSECOPY"))
						{
							num = 1;
							continue;
						}
						this.Copy();
						goto IL_B3;
					}
					case 5:
						goto IL_BE;
					case 6:
					{
						string name;
						if ((name = button.Name) != null)
						{
							num = 2;
							continue;
						}
						return;
					}
					case 7:
						num = 4;
						continue;
					case 8:
						num = 3;
						continue;
					}
					break;
					IL_B3:
					num = 5;
				}
			}
			IL_52:
			base.Close();
			return;
			IL_6F:
			if (true)
			{
			}
			if (false)
			{
			}
			return;
			IL_BE:
			return;
			IL_E8:
			this.Generate();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003090 File Offset: 0x00002090
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
			this.p = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CLicenseDialog));
			this.l = new Panel();
			this.n = new CCustomTextBox();
			this.o = new Button();
			this.k = new Label();
			this.g = new Label();
			this.i = new Button();
			this.j = new Button();
			this.m = new Panel();
			this.f = new Label();
			this.h = new Label();
			this.l.SuspendLayout();
			this.m.SuspendLayout();
			base.SuspendLayout();
			this.l.BackColor = SystemColors.ControlLight;
			this.l.Controls.Add(this.n);
			this.l.Controls.Add(this.o);
			this.l.Controls.Add(this.k);
			this.l.Dock = DockStyle.Bottom;
			this.l.Location = new Point(0, 224);
			this.l.Name = "panelAuth";
			this.l.Size = new Size(430, 65);
			this.l.TabIndex = 2;
			this.n.Alias = "";
			this.n.BorderStyle = BorderStyle.None;
			this.n.DetectUrls = false;
			this.n.Font = new Font("Arial Unicode MS", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.n.FontColor = false;
			this.n.HiddenEnabled = false;
			this.n.HiddenSymbol = "";
			this.n.HiddenValue = "";
			this.n.IsGridColumnFixed = false;
			this.n.IsRangePerChar = false;
			this.n.IsValidChars = true;
			this.n.Location = new Point(168, 23);
			this.n.Maximum = 0L;
			this.n.MenuSeparator1 = null;
			this.n.MenuUndo = null;
			this.n.Minimum = 0L;
			this.n.Multiline = false;
			this.n.Name = "TXT_AUTHCODEVAL";
			this.n.PasswordChar = '\0';
			this.n.ResourceId = "";
			this.n.RestrictedChars = "0123456789";
			this.n.Size = new Size(96, 28);
			this.n.StandardValue = "0";
			this.n.TabIndex = 4;
			this.n.Text = "0";
			this.n.TextModified = true;
			this.n.XmlRange = null;
			this.n.ValueType = CCustomTextBox.valueTypes.IntegerHex;
			this.n.Enabled = false;
			this.o.BackColor = SystemColors.ControlLight;
			this.o.Font = new Font("Arial Unicode MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.o.Location = new Point(272, 18);
			this.o.Name = "BTN_LICENSECOPY";
			this.o.Size = new Size(128, 28);
			this.o.TabIndex = 2;
			this.o.Text = "Copy Me";
			this.o.UseVisualStyleBackColor = false;
			this.k.Font = new Font("Arial Unicode MS", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.k.Location = new Point(40, 18);
			this.k.Name = "LBL_AUTHCODE";
			this.k.Size = new Size(120, 28);
			this.k.TabIndex = 1;
			this.k.Text = "Auth";
			this.k.TextAlign = ContentAlignment.MiddleRight;
			this.g.Anchor = AnchorStyles.None;
			this.g.BackColor = Color.FloralWhite;
			this.g.Font = new Font("Arial Unicode MS", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.g.Location = new Point(43, 37);
			this.g.Name = "LBL_INSTRUCTION_MESSAGE";
			this.g.Size = new Size(384, 83);
			this.g.TabIndex = 3;
			this.g.Text = "This is what you should do";
			this.i.BackColor = SystemColors.Control;
			this.i.Font = new Font("Arial Unicode MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.i.Location = new Point(127, 169);
			this.i.Name = "BTN_GENERATEAUTHCODE";
			this.i.Size = new Size(80, 37);
			this.i.TabIndex = 0;
			this.i.Text = "Gen";
			this.i.UseVisualStyleBackColor = false;
			this.j.BackColor = SystemColors.Control;
			this.j.Font = new Font("Arial Unicode MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.j.Location = new Point(215, 169);
			this.j.Name = "BTN_LICENSEEXIT";
			this.j.Size = new Size(80, 37);
			this.j.TabIndex = 1;
			this.j.Text = "Ex";
			this.j.UseVisualStyleBackColor = false;
			this.m.BackColor = Color.FloralWhite;
			this.m.Controls.Add(this.f);
			this.m.Controls.Add(this.h);
			this.m.Controls.Add(this.i);
			this.m.Controls.Add(this.j);
			this.m.Controls.Add(this.g);
			this.m.Dock = DockStyle.Top;
			this.m.Location = new Point(0, 0);
			this.m.Name = "panelButtons";
			this.m.Size = new Size(430, 224);
			this.m.TabIndex = 6;
			this.f.BackColor = Color.FloralWhite;
			this.f.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.f.Location = new Point(0, 9);
			this.f.Name = "LBL_ERROR_NUMBER";
			this.f.Size = new Size(40, 28);
			this.f.TabIndex = 7;
			this.f.Text = "Err No.";
			this.f.TextAlign = ContentAlignment.MiddleRight;
			this.h.Anchor = AnchorStyles.None;
			this.h.BackColor = Color.FloralWhite;
			this.h.Font = new Font("Arial Unicode MS", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.h.ImageAlign = ContentAlignment.BottomLeft;
			this.h.Location = new Point(43, 9);
			this.h.Name = "LBL_ERROR_MESSAGE";
			this.h.Size = new Size(384, 28);
			this.h.TabIndex = 6;
			this.h.Text = "This is the error message.";
			this.h.TextAlign = ContentAlignment.MiddleLeft;
			this.AutoScaleBaseSize = new Size(5, 15);
			base.ClientSize = new Size(430, 289);
			base.Controls.Add(this.m);
			base.Controls.Add(this.l);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "CLicenseDialog";
			this.Text = "Title bar text";
			this.l.ResumeLayout(false);
			this.m.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000019 RID: 25
		private const int a = 1;

		// Token: 0x0400001A RID: 26
		private const int b = 0;

		// Token: 0x0400001B RID: 27
		private string c;

		// Token: 0x0400001C RID: 28
		private CLicenseManager d;

		// Token: 0x0400001D RID: 29
		private CResourceHandler e;

		// Token: 0x0400001E RID: 30
		private Label f;

		// Token: 0x0400001F RID: 31
		private Label g;

		// Token: 0x04000020 RID: 32
		private Label h;

		// Token: 0x04000021 RID: 33
		private Button i;

		// Token: 0x04000022 RID: 34
		private Button j;

		// Token: 0x04000023 RID: 35
		private Label k;

		// Token: 0x04000024 RID: 36
		private Panel l;

		// Token: 0x04000025 RID: 37
		private Panel m;

		// Token: 0x04000026 RID: 38
		private CCustomTextBox n;

		// Token: 0x04000027 RID: 39
		private Button o;
	}
}
