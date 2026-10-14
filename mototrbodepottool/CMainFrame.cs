using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using constants;
using Controller;
using custom_controls;
using custom_exception;
using DeviceUpdate;
using licensing;
using Motorola.Common.CustomException;
using RegistryAccess;
using resource_handler;

namespace mototrbodepottool
{
	// Token: 0x0200000D RID: 13
	public partial class CMainFrame : Form
	{
		// Token: 0x0600003C RID: 60
		[DllImport("user32.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool ShowWindow(IntPtr A_0, uint A_1);

		// Token: 0x0600003D RID: 61
		[DllImport("user32.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool SetForegroundWindow(IntPtr A_0);

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00005B30 File Offset: 0x00004B30
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00005B74 File Offset: 0x00004B74
		[DefaultValue(false)]
		[Category("Appearance")]
		[Localizable(true)]
		[Description("Indicates whether the form should be mirrored or not.")]
		[Browsable(true)]
		public bool Mirrored
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
				return this.x;
			}
			set
			{
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
							continue;
						default:
							goto IL_66;
						}
						break;
					case 2:
						this.x = value;
						num = 0;
						continue;
					}
					if (true)
					{
					}
					if (this.x == value)
					{
						goto IL_6E;
					}
					num = 2;
				}
				IL_66:
				if (false)
				{
				}
				IL_6E:
				base.OnRightToLeftChanged(EventArgs.Empty);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005BFC File Offset: 0x00004BFC
		public CMainFrame(string A_0, bool A_1, CResourceHandler A_2, CResourceHandler A_3, ILanguageSettings A_4, IPersistentApplicationSettings A_5, IController A_6, string A_7)
		{
			try
			{
				this.w = A_6;
				this.x = A_1;
				this.u = A_2;
				this.v = A_3;
				this.ad = string.Empty;
				this.t = A_5;
				this.y = A_0;
				this.x = A_1;
				this.z = A_4;
				this.er = false;
				this.aa = false;
				this.ab = string.Empty;
				this.de = true;
				this.df = true;
				this.af = null;
				this.ah = string.Empty;
				this.ai = false;
				this.av = false;
				this.ad = A_7;
				this.dn = false;
				this.@do = false;
				this.dp = false;
				this.dq = false;
				this.dr = false;
				this.ds = false;
				this.dt = false;
				this.du = false;
				this.dv = false;
				this.dw = false;
				this.dx = false;
				this.dy = false;
				this.dz = false;
				this.d0 = false;
				this.d1 = false;
				this.d2 = false;
				this.d3 = false;
				this.d4 = false;
				this.d5 = false;
				this.d6 = false;
				this.d7 = false;
				this.d8 = false;
				this.d9 = false;
				this.ea = false;
				this.eb = false;
				this.ec = false;
				this.ed = false;
				this.ee = false;
				this.ef = false;
				this.eg = false;
				this.eh = false;
				this.ei = false;
				this.ej = false;
				this.ek = false;
				this.el = false;
				this.em = false;
				this.en = false;
				this.eo = false;
				this.ep = false;
				this.eq = false;
				this.ax = new Point(0, 0);
				this.b8 = new Point(15, 316);
				this.az = new Point(665, 66);
				this.b9 = new Point(664, 540);
				this.ay = new Point(665, 316);
				this.a1 = new Point(488, 335);
				this.a0 = new Point(300, 0);
				this.cg = new Point(665, 391);
				this.ch = new Point(665, 466);
				this.bq = new Point(42, 91);
				this.a7 = new Point(42, 115);
				this.a4 = new Point(42, 130);
				this.a2 = new Point(42, 145);
				this.a8 = new Point(42, 160);
				this.a6 = new Point(42, 175);
				this.a5 = new Point(42, 190);
				this.ba = new Point(42, 205);
				this.bb = new Point(42, 220);
				this.a9 = new Point(42, 235);
				this.bc = new Point(42, 250);
				this.bd = new Point(42, 265);
				this.a3 = new Point(42, 280);
				this.br = new Point(292, 91);
				this.by = new Point(292, 115);
				this.bv = new Point(292, 130);
				this.bt = new Point(292, 145);
				this.bz = new Point(292, 160);
				this.bx = new Point(292, 175);
				this.bw = new Point(292, 190);
				this.b1 = new Point(292, 205);
				this.b2 = new Point(292, 220);
				this.b0 = new Point(292, 235);
				this.b3 = new Point(292, 250);
				this.b4 = new Point(292, 265);
				this.bu = new Point(292, 280);
				this.bs = new Point(485, 91);
				this.bj = new Point(485, 115);
				this.bg = new Point(485, 130);
				this.be = new Point(485, 145);
				this.bk = new Point(485, 160);
				this.bi = new Point(485, 175);
				this.bh = new Point(485, 190);
				this.bm = new Point(485, 205);
				this.bn = new Point(485, 220);
				this.bl = new Point(485, 235);
				this.bo = new Point(485, 250);
				this.bp = new Point(485, 265);
				this.bf = new Point(485, 280);
				this.ca = new Point(615, 18);
				this.cc = new Point(641, 18);
				this.cd = new Point(641, 17);
				this.b7 = new Point(691, 18);
				this.cb = new Point(715, 18);
				this.b6 = new Point(740, 18);
				this.ce = new Point(0, 0);
				this.cf = new Point(185, 85);
				this.b5 = new Point(666, 18);
				this.ci = (Bitmap)A_3.GetObject("DT05_MAIN");
				this.cj = (Bitmap)this.v.GetObject("READ_NOM");
				this.ck = (Bitmap)this.v.GetObject("READ_CLK");
				this.cl = (Bitmap)this.v.GetObject("READ_OVR");
				this.cm = (Bitmap)this.v.GetObject("READ_DIS");
				this.cn = (Bitmap)this.v.GetObject("WRITE_NOM");
				this.co = (Bitmap)this.v.GetObject("WRITE_CLK");
				this.cp = (Bitmap)this.v.GetObject("WRITE_OVR");
				this.cq = (Bitmap)this.v.GetObject("WRITE_DIS");
				this.cr = (Bitmap)this.v.GetObject("BLANK_NOM");
				this.cs = (Bitmap)this.v.GetObject("BLANK_CLK");
				this.ct = (Bitmap)this.v.GetObject("BLANK_OVR");
				this.cu = (Bitmap)this.v.GetObject("BLANK_DIS");
				this.cv = (Bitmap)this.v.GetObject("FLASH_NOM");
				this.cw = (Bitmap)this.v.GetObject("FLASH_CLK");
				this.cx = (Bitmap)this.v.GetObject("FLASH_OVR");
				this.cy = (Bitmap)this.v.GetObject("FLASH_DIS");
				this.cz = (Bitmap)this.v.GetObject("CLOSE_NOM");
				this.c0 = (Bitmap)this.v.GetObject("CLOSE_CLK");
				this.c1 = (Bitmap)this.v.GetObject("UNKILL_NOM");
				this.c2 = (Bitmap)this.v.GetObject("UNKILL_CLK");
				this.c3 = (Bitmap)this.v.GetObject("SHRINK_NOM");
				this.c4 = (Bitmap)this.v.GetObject("SHRINK_CLK");
				this.c5 = (Bitmap)this.v.GetObject("REFRESH2_NOM");
				this.c6 = (Bitmap)this.v.GetObject("REFRESH2_CLK");
				this.c7 = (Bitmap)this.v.GetObject("HELP_NOM");
				this.c8 = (Bitmap)this.v.GetObject("HELP_CLK");
				this.c9 = (Bitmap)this.v.GetObject("DT05_DEPOT_TOOL_NOM");
				this.da = (Bitmap)this.v.GetObject("DT05_DEPOT_TOOL_OVR");
				this.db = (Bitmap)this.v.GetObject("SOUND_ON");
				this.dc = (Bitmap)this.v.GetObject("SOUND_OFF");
				Application.ThreadException += this.a;
				Control.CheckForIllegalCrossThreadCalls = false;
				this.i();
				this.f3 = new b();
				this.f1.ListViewItemSorter = this.f3;
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
					ex2.Source = 1646U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000065F4 File Offset: 0x000055F4
		protected virtual void a(bool A_0)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_44;
				case 1:
					if (this.ge != null)
					{
						num = 2;
						continue;
					}
					goto IL_8E;
				case 2:
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
						break;
					}
					this.ge.Dispose();
					num = 0;
					continue;
				case 4:
					num = 1;
					continue;
				}
				if (!A_0)
				{
					break;
				}
				num = 4;
			}
			IL_44:
			IL_8E:
			base.Dispose(A_0);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006698 File Offset: 0x00005698
		private void i()
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
			this.ge = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CMainFrame));
			this.fn = new Label();
			this.fm = new Label();
			this.es = new Label();
			this.et = new Label();
			this.eu = new Label();
			this.ev = new Label();
			this.ex = new Label();
			this.ey = new Label();
			this.fv = new Label();
			this.ez = new Label();
			this.e0 = new Label();
			this.ew = new Label();
			this.fo = new Button();
			this.fq = new Button();
			this.fp = new Button();
			this.fr = new Button();
			this.e3 = new Label();
			this.fy = new Label();
			this.fb = new Label();
			this.e4 = new Label();
			this.fa = new Label();
			this.e9 = new ListBox();
			this.ft = new Label();
			this.e6 = new Label();
			this.e5 = new Label();
			this.fc = new Label();
			this.fz = new Label();
			this.fd = new Label();
			this.fe = new Label();
			this.fk = new Label();
			this.fl = new Label();
			this.ff = new ListBox();
			this.fu = new Label();
			this.fg = new Label();
			this.fh = new Label();
			this.e2 = new Label();
			this.e7 = new Label();
			this.fi = new Label();
			this.fs = new Label();
			this.fw = new TextBox();
			this.fx = new Panel();
			this.f1 = new ListView();
			this.ga = new ColumnHeader();
			this.gb = new ColumnHeader();
			this.f4 = new ColumnHeader();
			this.f5 = new ColumnHeader();
			this.f6 = new ColumnHeader();
			this.f7 = new ColumnHeader();
			this.f8 = new ColumnHeader();
			this.f0 = new Label();
			this.f9 = new Label();
			this.gc = new PictureBox();
			this.gd = new PictureBox();
			this.ae = new Label();
			this.ag = new ToolTip(this.ge);
			this.aj = new PictureBox();
			this.ak = new PictureBox();
			this.al = new PictureBox();
			this.ao = new PictureBox();
			this.an = new PictureBox();
			this.am = new PictureBox();
			this.ap = new RichTextBox();
			this.e1 = new Label();
			this.e8 = new Label();
			this.fj = new Label();
			this.aq = new Button();
			this.ar = new ComboBox();
			this.@as = new Label();
			this.at = new TextBox();
			this.au = new Button();
			this.fx.SuspendLayout();
			((ISupportInitialize)this.gc).BeginInit();
			((ISupportInitialize)this.gd).BeginInit();
			((ISupportInitialize)this.aj).BeginInit();
			((ISupportInitialize)this.ak).BeginInit();
			((ISupportInitialize)this.al).BeginInit();
			((ISupportInitialize)this.ao).BeginInit();
			((ISupportInitialize)this.an).BeginInit();
			((ISupportInitialize)this.am).BeginInit();
			base.SuspendLayout();
			this.fn.BackColor = Color.Black;
			this.fn.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.fn.ForeColor = Color.DarkSeaGreen;
			this.fn.Location = new Point(32, 80);
			this.fn.Name = "LBL_TXBOARD";
			this.fn.Size = new Size(176, 15);
			this.fn.TabIndex = 2;
			this.fn.Visible = false;
			this.fm.BackColor = Color.Black;
			this.fm.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.fm.ForeColor = Color.DarkSeaGreen;
			this.fm.Location = new Point(440, 64);
			this.fm.Name = "LBL_RXBOARD";
			this.fm.Size = new Size(100, 23);
			this.fm.TabIndex = 2;
			this.fm.Visible = false;
			this.es.BackColor = Color.Black;
			this.es.ForeColor = Color.DarkSeaGreen;
			this.es.Location = new Point(32, 96);
			this.es.Name = "RS_MODELNUM";
			this.es.Size = new Size(176, 15);
			this.es.TabIndex = 4;
			this.es.TextAlign = ContentAlignment.TopRight;
			this.es.Visible = false;
			this.et.BackColor = Color.Black;
			this.et.ForeColor = Color.DarkSeaGreen;
			this.et.Location = new Point(32, 112);
			this.et.Name = "RS_DEVICESERIALNUM";
			this.et.Size = new Size(176, 15);
			this.et.TabIndex = 5;
			this.et.TextAlign = ContentAlignment.TopRight;
			this.et.Visible = false;
			this.eu.BackColor = Color.Black;
			this.eu.ForeColor = Color.DarkSeaGreen;
			this.eu.Location = new Point(32, 256);
			this.eu.Name = "RS_BRICKSERIALNUM";
			this.eu.Size = new Size(176, 15);
			this.eu.TabIndex = 6;
			this.eu.TextAlign = ContentAlignment.TopRight;
			this.eu.Visible = false;
			this.ev.BackColor = Color.Black;
			this.ev.ForeColor = Color.DarkSeaGreen;
			this.ev.Location = new Point(32, 128);
			this.ev.Name = "RS_DEVICETANAPANUM";
			this.ev.Size = new Size(176, 15);
			this.ev.TabIndex = 7;
			this.ev.TextAlign = ContentAlignment.TopRight;
			this.ev.Visible = false;
			this.ex.BackColor = Color.Black;
			this.ex.ForeColor = Color.DarkSeaGreen;
			this.ex.Location = new Point(32, 160);
			this.ex.Name = "RS_SECVERS";
			this.ex.Size = new Size(176, 15);
			this.ex.TabIndex = 9;
			this.ex.TextAlign = ContentAlignment.TopRight;
			this.ex.Visible = false;
			this.ey.BackColor = Color.Black;
			this.ey.ForeColor = Color.DarkSeaGreen;
			this.ey.Location = new Point(32, 176);
			this.ey.Name = "RS_BANDFREQRGN";
			this.ey.Size = new Size(176, 15);
			this.ey.TabIndex = 10;
			this.ey.TextAlign = ContentAlignment.TopRight;
			this.ey.Visible = false;
			this.fv.BackColor = Color.Black;
			this.fv.ForeColor = Color.DarkSeaGreen;
			this.fv.Location = new Point(32, 192);
			this.fv.Name = "RI_LPGDATE";
			this.fv.Size = new Size(176, 15);
			this.fv.TabIndex = 11;
			this.fv.TextAlign = ContentAlignment.TopRight;
			this.fv.Visible = false;
			this.ez.BackColor = Color.Black;
			this.ez.ForeColor = Color.DarkSeaGreen;
			this.ez.Location = new Point(32, 224);
			this.ez.Name = "RS_REGION";
			this.ez.Size = new Size(176, 15);
			this.ez.TabIndex = 12;
			this.ez.TextAlign = ContentAlignment.TopRight;
			this.ez.Visible = false;
			this.e0.BackColor = Color.Black;
			this.e0.ForeColor = Color.DarkSeaGreen;
			this.e0.Location = new Point(32, 240);
			this.e0.Name = "RS_BOOTLOADER";
			this.e0.Size = new Size(176, 15);
			this.e0.TabIndex = 13;
			this.e0.TextAlign = ContentAlignment.TopRight;
			this.e0.Visible = false;
			this.ew.BackColor = Color.Black;
			this.ew.ForeColor = Color.DarkSeaGreen;
			this.ew.Location = new Point(32, 144);
			this.ew.Name = "CS_FWVER";
			this.ew.Size = new Size(176, 15);
			this.ew.TabIndex = 12;
			this.ew.TextAlign = ContentAlignment.TopRight;
			this.ew.Visible = false;
			this.fo.BackColor = Color.MintCream;
			this.fo.Cursor = Cursors.Hand;
			this.fo.Font = new Font("Arial Unicode MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.fo.Location = new Point(680, 32);
			this.fo.Name = "BTN_DT_READ";
			this.fo.Size = new Size(104, 312);
			this.fo.TabIndex = 0;
			this.fo.UseVisualStyleBackColor = false;
			this.fo.Visible = false;
			this.fo.Click += this.al;
			this.fo.Enter += this.ak;
			this.fo.Leave += this.aj;
			this.fo.MouseLeave += this.@as;
			this.fo.MouseHover += this.at;
			this.fq.BackColor = Color.MintCream;
			this.fq.Cursor = Cursors.Hand;
			this.fq.Font = new Font("Arial Unicode MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.fq.Location = new Point(360, 344);
			this.fq.Name = "BTN_DT_BLANK";
			this.fq.Size = new Size(120, 24);
			this.fq.TabIndex = 1;
			this.fq.UseVisualStyleBackColor = false;
			this.fq.Visible = false;
			this.fq.Click += this.af;
			this.fq.Enter += this.ae;
			this.fq.Leave += this.ad;
			this.fq.MouseLeave += this.aq;
			this.fq.MouseHover += this.ar;
			this.fp.BackColor = Color.MintCream;
			this.fp.Cursor = Cursors.Hand;
			this.fp.Enabled = false;
			this.fp.Font = new Font("Arial Unicode MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.fp.Location = new Point(688, 368);
			this.fp.Name = "BTN_DT_WRITE";
			this.fp.Size = new Size(104, 24);
			this.fp.TabIndex = 3;
			this.fp.UseVisualStyleBackColor = false;
			this.fp.Visible = false;
			this.fp.Click += this.z;
			this.fp.Enter += this.y;
			this.fp.Leave += this.x;
			this.fp.MouseLeave += this.v;
			this.fp.MouseHover += this.w;
			this.fr.BackColor = Color.MintCream;
			this.fr.Cursor = Cursors.Hand;
			this.fr.Font = new Font("Arial Unicode MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.fr.Location = new Point(688, 392);
			this.fr.Name = "BTN_DT_FLASH";
			this.fr.Size = new Size(104, 136);
			this.fr.TabIndex = 5;
			this.fr.UseVisualStyleBackColor = false;
			this.fr.Visible = false;
			this.fr.Click += this.az;
			this.fr.Enter += this.am;
			this.fr.Leave += this.an;
			this.fr.MouseLeave += this.ap;
			this.fr.MouseHover += this.ao;
			this.e3.BackColor = Color.Black;
			this.e3.ForeColor = Color.LawnGreen;
			this.e3.Location = new Point(216, 96);
			this.e3.Name = "LBL_MODELNUM";
			this.e3.Size = new Size(184, 15);
			this.e3.TabIndex = 27;
			this.e3.Visible = false;
			this.fy.BackColor = Color.Black;
			this.fy.ForeColor = Color.LawnGreen;
			this.fy.Location = new Point(216, 256);
			this.fy.Name = "LBL_TXBRICKSERIALNUM";
			this.fy.Size = new Size(184, 15);
			this.fy.TabIndex = 28;
			this.fy.Visible = false;
			this.fb.BackColor = Color.Black;
			this.fb.ForeColor = Color.LawnGreen;
			this.fb.Location = new Point(216, 128);
			this.fb.Name = "LBL_DEVICETANAPANUM";
			this.fb.Size = new Size(184, 15);
			this.fb.TabIndex = 30;
			this.fb.Visible = false;
			this.e4.BackColor = Color.Black;
			this.e4.ForeColor = Color.LawnGreen;
			this.e4.Location = new Point(216, 144);
			this.e4.Name = "LBL_FWVER";
			this.e4.Size = new Size(184, 15);
			this.e4.TabIndex = 31;
			this.e4.Visible = false;
			this.fa.BackColor = Color.Black;
			this.fa.ForeColor = Color.LawnGreen;
			this.fa.Location = new Point(216, 160);
			this.fa.Name = "LBL_CPVER";
			this.fa.Size = new Size(184, 15);
			this.fa.TabIndex = 32;
			this.fa.Visible = false;
			this.e9.BackColor = Color.Black;
			this.e9.BorderStyle = BorderStyle.None;
			this.e9.ForeColor = Color.LawnGreen;
			this.e9.Location = new Point(216, 176);
			this.e9.Name = "LBL_FREQUENCYRANGE";
			this.e9.ScrollAlwaysVisible = true;
			this.e9.SelectionMode = SelectionMode.None;
			this.e9.Size = new Size(160, 13);
			this.e9.TabIndex = 33;
			this.e9.Visible = false;
			this.e9.GotFocus += this.ac;
			this.ft.BackColor = Color.Black;
			this.ft.ForeColor = Color.LawnGreen;
			this.ft.Location = new Point(216, 192);
			this.ft.Name = "LBL_LASTPROGRAMMEDDATETIME";
			this.ft.Size = new Size(184, 15);
			this.ft.TabIndex = 34;
			this.ft.Visible = false;
			this.e6.BackColor = Color.Black;
			this.e6.ForeColor = Color.LawnGreen;
			this.e6.Location = new Point(216, 208);
			this.e6.Name = "LBL_LASTPROGRAMMEDSOURCE";
			this.e6.Size = new Size(184, 15);
			this.e6.TabIndex = 35;
			this.e6.Visible = false;
			this.e5.BackColor = Color.Black;
			this.e5.ForeColor = Color.LawnGreen;
			this.e5.Location = new Point(216, 224);
			this.e5.Name = "LBL_REGION";
			this.e5.Size = new Size(184, 15);
			this.e5.TabIndex = 36;
			this.e5.Visible = false;
			this.fc.BackColor = Color.Black;
			this.fc.ForeColor = Color.LawnGreen;
			this.fc.Location = new Point(432, 96);
			this.fc.Name = "LBL_RXMODELNUM";
			this.fc.Size = new Size(200, 15);
			this.fc.TabIndex = 37;
			this.fc.Visible = false;
			this.fz.BackColor = Color.Black;
			this.fz.ForeColor = Color.LawnGreen;
			this.fz.Location = new Point(432, 112);
			this.fz.Name = "LBL_RXDEVICESERIALNUM";
			this.fz.Size = new Size(200, 15);
			this.fz.TabIndex = 38;
			this.fz.Visible = false;
			this.fd.BackColor = Color.Black;
			this.fd.ForeColor = Color.LawnGreen;
			this.fd.Location = new Point(432, 256);
			this.fd.Name = "LBL_RXBRICKSERIALNUM";
			this.fd.Size = new Size(200, 15);
			this.fd.TabIndex = 39;
			this.fd.Visible = false;
			this.fe.BackColor = Color.Black;
			this.fe.ForeColor = Color.LawnGreen;
			this.fe.Location = new Point(432, 128);
			this.fe.Name = "LBL_RXDEVICETANAPANUM";
			this.fe.Size = new Size(200, 15);
			this.fe.TabIndex = 40;
			this.fe.Visible = false;
			this.fk.BackColor = Color.Black;
			this.fk.ForeColor = Color.LawnGreen;
			this.fk.Location = new Point(432, 144);
			this.fk.Name = "LBL_RXFWVER";
			this.fk.Size = new Size(200, 15);
			this.fk.TabIndex = 41;
			this.fk.Visible = false;
			this.fl.BackColor = Color.Black;
			this.fl.ForeColor = Color.LawnGreen;
			this.fl.Location = new Point(432, 160);
			this.fl.Name = "LBL_RXCPVER";
			this.fl.Size = new Size(200, 15);
			this.fl.TabIndex = 42;
			this.fl.Visible = false;
			this.ff.BackColor = Color.Black;
			this.ff.BorderStyle = BorderStyle.None;
			this.ff.ForeColor = Color.LawnGreen;
			this.ff.Location = new Point(432, 176);
			this.ff.Name = "LBL_RXFREQUENCYRANGE";
			this.ff.ScrollAlwaysVisible = true;
			this.ff.SelectionMode = SelectionMode.None;
			this.ff.Size = new Size(160, 13);
			this.ff.TabIndex = 43;
			this.ff.Visible = false;
			this.ff.GotFocus += this.ac;
			this.fu.BackColor = Color.Black;
			this.fu.ForeColor = Color.LawnGreen;
			this.fu.Location = new Point(432, 192);
			this.fu.Name = "LBL_RXLASTPROGRAMMEDDATETIME";
			this.fu.Size = new Size(200, 15);
			this.fu.TabIndex = 44;
			this.fu.Visible = false;
			this.fg.BackColor = Color.Black;
			this.fg.ForeColor = Color.LawnGreen;
			this.fg.Location = new Point(432, 208);
			this.fg.Name = "LBL_RXLASTPROGRAMMEDSOURCE";
			this.fg.Size = new Size(200, 15);
			this.fg.TabIndex = 45;
			this.fg.Visible = false;
			this.fh.BackColor = Color.Black;
			this.fh.ForeColor = Color.LawnGreen;
			this.fh.Location = new Point(432, 224);
			this.fh.Name = "LBL_RXREGION";
			this.fh.Size = new Size(200, 15);
			this.fh.TabIndex = 46;
			this.fh.Visible = false;
			this.e2.BackColor = Color.Black;
			this.e2.ForeColor = Color.DarkSeaGreen;
			this.e2.Location = new Point(32, 208);
			this.e2.Name = "RI_LPGSOURCE";
			this.e2.Size = new Size(176, 15);
			this.e2.TabIndex = 47;
			this.e2.TextAlign = ContentAlignment.TopRight;
			this.e2.Visible = false;
			this.e7.BackColor = Color.Black;
			this.e7.ForeColor = Color.LawnGreen;
			this.e7.Location = new Point(216, 240);
			this.e7.Name = "LBL_BOOTLOADER";
			this.e7.Size = new Size(184, 15);
			this.e7.TabIndex = 48;
			this.e7.Visible = false;
			this.fi.BackColor = Color.Black;
			this.fi.ForeColor = Color.LawnGreen;
			this.fi.Location = new Point(432, 240);
			this.fi.Name = "LBL_RXBOOTLOADER";
			this.fi.Size = new Size(200, 15);
			this.fi.TabIndex = 49;
			this.fi.Visible = false;
			this.fs.BackColor = Color.Transparent;
			this.fs.Font = new Font("Arial Unicode MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.fs.ForeColor = Color.DarkSeaGreen;
			this.fs.Location = new Point(288, 335);
			this.fs.Name = "LBL_SETSERIALNUM";
			this.fs.Size = new Size(192, 33);
			this.fs.TabIndex = 52;
			this.fs.TextAlign = ContentAlignment.TopRight;
			this.fs.Visible = false;
			this.fw.BackColor = Color.Black;
			this.fw.CharacterCasing = CharacterCasing.Upper;
			this.fw.Font = new Font("Arial Unicode MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.fw.ForeColor = Color.Yellow;
			this.fw.Location = new Point(488, 335);
			this.fw.MaxLength = 10;
			this.fw.Name = "LBL_SETSERIALNUMVAL";
			this.fw.Size = new Size(176, 33);
			this.fw.TabIndex = 2;
			this.fw.Visible = false;
			this.fw.TextChanged += this.k;
			this.fx.BackColor = Color.Black;
			this.fx.Controls.Add(this.f1);
			this.fx.ForeColor = Color.Yellow;
			this.fx.Location = new Point(25, 549);
			this.fx.Name = "panel1";
			this.fx.Size = new Size(650, 150);
			this.fx.TabIndex = 1;
			this.f1.BackColor = Color.Black;
			this.f1.BorderStyle = BorderStyle.None;
			this.f1.Columns.AddRange(new ColumnHeader[]
			{
				this.ga,
				this.gb,
				this.f4,
				this.f5,
				this.f6,
				this.f7,
				this.f8
			});
			this.f1.Dock = DockStyle.Top;
			this.f1.Font = new Font("Arial Unicode MS", 8.25f);
			this.f1.ForeColor = Color.Yellow;
			this.f1.FullRowSelect = true;
			this.f1.HideSelection = false;
			this.f1.Location = new Point(0, 0);
			this.f1.MultiSelect = false;
			this.f1.Name = "LV_AVAILPAKGLIST";
			this.f1.Size = new Size(650, 150);
			this.f1.TabIndex = 4;
			this.f1.UseCompatibleStateImageBehavior = false;
			this.f1.View = View.Details;
			this.f1.Visible = false;
			this.f1.ColumnClick += this.a;
			this.f1.SelectedIndexChanged += this.i;
			this.ga.Text = "Item";
			this.ga.Width = 50;
			this.gb.Text = "";
			this.gb.Width = 131;
			this.f4.Text = "";
			this.f4.Width = 76;
			this.f5.Text = "";
			this.f5.Width = 131;
			this.f6.Text = "";
			this.f6.Width = 131;
			this.f7.Text = "";
			this.f7.Width = 131;
			this.f8.Text = "";
			this.f8.Width = 131;
			this.f0.BackColor = Color.Black;
			this.f0.ForeColor = Color.LawnGreen;
			this.f0.Location = new Point(216, 112);
			this.f0.Name = "LBL_DEVICESERIALNUM";
			this.f0.Size = new Size(184, 15);
			this.f0.TabIndex = 60;
			this.f0.Visible = false;
			this.f9.BackColor = Color.Black;
			this.f9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.f9.ForeColor = Color.DarkSeaGreen;
			this.f9.Location = new Point(32, 64);
			this.f9.Name = "LBL_MODELTYPE";
			this.f9.Size = new Size(240, 15);
			this.f9.TabIndex = 1;
			this.f9.Visible = false;
			this.gc.Location = new Point(8, 8);
			this.gc.Name = "PICBOX_DT_SPLASH";
			this.gc.Size = new Size(32, 16);
			this.gc.TabIndex = 65;
			this.gc.TabStop = false;
			this.gc.Visible = false;
			this.gd.BackColor = Color.Transparent;
			this.gd.Location = new Point(48, 0);
			this.gd.Name = "PICBOX_DT_NAME";
			this.gd.Size = new Size(40, 24);
			this.gd.TabIndex = 73;
			this.gd.TabStop = false;
			this.gd.Visible = false;
			this.gd.MouseLeave += this.ax;
			this.gd.MouseHover += this.av;
			this.ae.BackColor = Color.Black;
			this.ae.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ae.ForeColor = Color.DarkSeaGreen;
			this.ae.Location = new Point(40, 289);
			this.ae.Name = "LBL_SINGLEMODELTYPE";
			this.ae.Size = new Size(240, 15);
			this.ae.TabIndex = 75;
			this.ae.Visible = false;
			this.aj.BackColor = Color.Silver;
			this.aj.Location = new Point(208, 8);
			this.aj.Name = "PICBOX_DT_UNKILL";
			this.aj.Size = new Size(40, 24);
			this.aj.TabIndex = 76;
			this.aj.TabStop = false;
			this.aj.Visible = false;
			this.aj.Click += this.ag;
			this.aj.MouseHover += this.q;
			this.ak.BackColor = Color.Silver;
			this.ak.Location = new Point(160, 8);
			this.ak.Name = "PICBOX_DT_RELOAD";
			this.ak.Size = new Size(40, 24);
			this.ak.TabIndex = 77;
			this.ak.TabStop = false;
			this.ak.Visible = false;
			this.ak.Click += this.ai;
			this.ak.MouseHover += this.ah;
			this.al.BackColor = Color.Silver;
			this.al.Location = new Point(256, 8);
			this.al.Name = "PICBOX_DT_ABOUT";
			this.al.Size = new Size(40, 24);
			this.al.TabIndex = 78;
			this.al.TabStop = false;
			this.al.Visible = false;
			this.al.Click += this.j;
			this.al.MouseHover += this.h;
			this.ao.BackColor = Color.Silver;
			this.ao.Location = new Point(208, 8);
			this.ao.Name = "PICBOX_DT_SOUND";
			this.ao.Size = new Size(40, 24);
			this.ao.TabIndex = 79;
			this.ao.TabStop = false;
			this.ao.Visible = false;
			this.ao.Click += this.n;
			this.ao.MouseHover += this.m;
			this.an.BackColor = Color.Silver;
			this.an.Location = new Point(352, 8);
			this.an.Name = "PICBOX_DT_EXIT";
			this.an.Size = new Size(40, 24);
			this.an.TabIndex = 80;
			this.an.TabStop = false;
			this.an.Visible = false;
			this.an.Click += this.t;
			this.an.MouseHover += this.r;
			this.am.BackColor = Color.Silver;
			this.am.Location = new Point(304, 8);
			this.am.Name = "PICBOX_DT_MIN";
			this.am.Size = new Size(40, 24);
			this.am.TabIndex = 81;
			this.am.TabStop = false;
			this.am.Visible = false;
			this.am.MouseDown += this.b;
			this.am.MouseHover += this.u;
			this.am.MouseUp += this.a;
			this.ap.BackColor = Color.Black;
			this.ap.BorderStyle = BorderStyle.None;
			this.ap.ForeColor = Color.DarkSeaGreen;
			this.ap.Location = new Point(352, 289);
			this.ap.Name = "RCT_APPABOUT";
			this.ap.Size = new Size(100, 24);
			this.ap.TabIndex = 83;
			this.ap.Text = "";
			this.ap.Visible = false;
			this.e1.BackColor = Color.Black;
			this.e1.ForeColor = Color.DarkSeaGreen;
			this.e1.Location = new Point(32, 271);
			this.e1.Name = "RS_PSDT";
			this.e1.Size = new Size(176, 15);
			this.e1.TabIndex = 84;
			this.e1.TextAlign = ContentAlignment.TopRight;
			this.e1.Visible = false;
			this.e8.BackColor = Color.Black;
			this.e8.ForeColor = Color.LawnGreen;
			this.e8.Location = new Point(216, 271);
			this.e8.Name = "LBL_PSDT";
			this.e8.Size = new Size(184, 15);
			this.e8.TabIndex = 85;
			this.e8.Visible = false;
			this.fj.BackColor = Color.Black;
			this.fj.ForeColor = Color.LawnGreen;
			this.fj.Location = new Point(432, 271);
			this.fj.Name = "LBL_RXPSDT";
			this.fj.Size = new Size(200, 15);
			this.fj.TabIndex = 86;
			this.fj.Visible = false;
			this.aq.BackColor = Color.MintCream;
			this.aq.Cursor = Cursors.Hand;
			this.aq.Font = new Font("Arial Unicode MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.aq.Location = new Point(24, 395);
			this.aq.Name = "BTN_DT_IME";
			this.aq.Size = new Size(104, 60);
			this.aq.TabIndex = 87;
			this.aq.UseVisualStyleBackColor = false;
			this.aq.Visible = false;
			this.aq.Click += this.g;
			this.aq.MouseLeave += this.e;
			this.aq.MouseHover += this.f;
			this.ar.BackColor = Color.Black;
			this.ar.DropDownStyle = ComboBoxStyle.DropDownList;
			this.ar.Font = new Font("Arial Unicode MS", 14.25f);
			this.ar.ForeColor = Color.Yellow;
			this.ar.FormattingEnabled = true;
			this.ar.Items.AddRange(new object[]
			{
				"English (Latin) , Chinese PinYin",
				"Cyrillic",
				"Arabic",
				"Simplified Chinese (Stroke)",
				"Traditional Chinese (ZhuYin)",
				"Korean"
			});
			this.ar.Location = new Point(360, 410);
			this.ar.Name = "CB_IME";
			this.ar.Size = new Size(304, 33);
			this.ar.TabIndex = 88;
			this.ar.Visible = false;
			this.@as.BackColor = Color.Transparent;
			this.@as.Font = new Font("Arial Unicode MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.@as.ForeColor = Color.DarkSeaGreen;
			this.@as.Location = new Point(180, 410);
			this.@as.Name = "LBL_IME";
			this.@as.Size = new Size(174, 33);
			this.@as.TabIndex = 89;
			this.@as.TextAlign = ContentAlignment.TopRight;
			this.@as.Visible = false;
			this.at.BackColor = Color.Black;
			this.at.CharacterCasing = CharacterCasing.Upper;
			this.at.Font = new Font("Arial Unicode MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.at.ForeColor = Color.Yellow;
			this.at.Location = new Point(35, 485);
			this.at.Name = "searchTextBox";
			this.at.Size = new Size(629, 33);
			this.at.TabIndex = 91;
			this.at.Visible = false;
			this.at.KeyPress += this.a;
			this.at.MouseHover += this.a;
			this.au.BackColor = Color.MintCream;
			this.au.Cursor = Cursors.Hand;
			this.au.Font = new Font("Arial Unicode MS", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.au.Location = new Point(185, 10);
			this.au.Name = "searchButton";
			this.au.Size = new Size(104, 60);
			this.au.TabIndex = 90;
			this.au.UseVisualStyleBackColor = false;
			this.au.Visible = false;
			this.au.Click += this.d;
			this.au.MouseLeave += this.b;
			this.au.MouseHover += this.c;
			this.AutoScaleBaseSize = new Size(5, 13);
			this.BackColor = Color.Black;
			base.ClientSize = new Size(808, 720);
			base.Controls.Add(this.au);
			base.Controls.Add(this.at);
			base.Controls.Add(this.@as);
			base.Controls.Add(this.ar);
			base.Controls.Add(this.aq);
			base.Controls.Add(this.e1);
			base.Controls.Add(this.ap);
			base.Controls.Add(this.am);
			base.Controls.Add(this.an);
			base.Controls.Add(this.ao);
			base.Controls.Add(this.al);
			base.Controls.Add(this.aj);
			base.Controls.Add(this.ak);
			base.Controls.Add(this.ae);
			base.Controls.Add(this.gd);
			base.Controls.Add(this.gc);
			base.Controls.Add(this.f9);
			base.Controls.Add(this.f0);
			base.Controls.Add(this.fx);
			base.Controls.Add(this.fq);
			base.Controls.Add(this.fo);
			base.Controls.Add(this.fi);
			base.Controls.Add(this.e7);
			base.Controls.Add(this.fh);
			base.Controls.Add(this.fg);
			base.Controls.Add(this.fu);
			base.Controls.Add(this.ff);
			base.Controls.Add(this.fa);
			base.Controls.Add(this.fl);
			base.Controls.Add(this.fk);
			base.Controls.Add(this.fe);
			base.Controls.Add(this.fd);
			base.Controls.Add(this.fz);
			base.Controls.Add(this.fc);
			base.Controls.Add(this.e5);
			base.Controls.Add(this.e6);
			base.Controls.Add(this.ft);
			base.Controls.Add(this.e9);
			base.Controls.Add(this.e4);
			base.Controls.Add(this.fb);
			base.Controls.Add(this.fy);
			base.Controls.Add(this.e3);
			base.Controls.Add(this.fm);
			base.Controls.Add(this.fn);
			base.Controls.Add(this.e0);
			base.Controls.Add(this.ez);
			base.Controls.Add(this.ew);
			base.Controls.Add(this.fv);
			base.Controls.Add(this.e2);
			base.Controls.Add(this.ey);
			base.Controls.Add(this.ex);
			base.Controls.Add(this.ev);
			base.Controls.Add(this.eu);
			base.Controls.Add(this.et);
			base.Controls.Add(this.es);
			base.Controls.Add(this.fp);
			base.Controls.Add(this.fs);
			base.Controls.Add(this.fw);
			base.Controls.Add(this.fr);
			base.Controls.Add(this.fj);
			base.Controls.Add(this.e8);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CMainFrame";
			this.Text = "MOTOTRBO Depot Tool";
			base.Activated += this.l;
			base.Load += this.ay;
			base.MouseDown += this.d;
			base.MouseMove += this.c;
			this.fx.ResumeLayout(false);
			((ISupportInitialize)this.gc).EndInit();
			((ISupportInitialize)this.gd).EndInit();
			((ISupportInitialize)this.aj).EndInit();
			((ISupportInitialize)this.ak).EndInit();
			((ISupportInitialize)this.al).EndInit();
			((ISupportInitialize)this.ao).EndInit();
			((ISupportInitialize)this.an).EndInit();
			((ISupportInitialize)this.am).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00009630 File Offset: 0x00008630
		[STAThread]
		private static void a(string[] A_0)
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
				default:
				{
					COneITLoginDlg coneITLoginDlg = null;
					CMainFrame mainForm = null;
					CResourceHandler cresourceHandler = null;
					CResourceHandler cresourceHandler2 = null;
					IPersistentApplicationSettings persistentApplicationSettings = null;
					ILanguageSettings languageSettings = null;
					bool flag = false;
					string empty = string.Empty;
					string empty2 = string.Empty;
					string text = string.Empty;
					if (A_0.Length <= 1)
					{
						try
						{
							try
							{
								IRegistryAccess registryAccess = new CRegistryAccess(CRegistryAccess.ProductName.MOTOTRBO_DepotTool);
								registryAccess.VerifyUserProfile();
								goto IL_5D7;
							}
							catch
							{
								MessageBox.Show("Registry verification failed.", "DepotTool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return;
							}
							goto Block_3;
							int num;
							string empty3;
							IController controller;
							bool flag2;
							for (;;)
							{
								IL_13A:
								string empty4;
								switch (num)
								{
								case 0:
									try
									{
										languageSettings = new CLanguageSettings();
										languageSettings.GetGUIResourceFile("EN-US", ref empty3);
										goto IL_1B8;
									}
									catch
									{
										MessageBox.Show("Unable to get resource file from registry.  Please re-install the application.", "Depottool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
										return;
									}
									goto IL_3E8;
									IL_1B8:
									CMainFrame.a(ref cresourceHandler, empty3, flag);
									num = 2;
									continue;
								case 1:
									MessageBox.Show("Unable to load resource file.  Please re-install the application.", "DepotTool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									num = 12;
									continue;
								case 2:
									if (cresourceHandler == null)
									{
										num = 1;
										continue;
									}
									goto IL_8A;
								case 3:
									if (cresourceHandler2 == null)
									{
										num = 9;
										continue;
									}
									try
									{
										Cursor.Current = Cursors.Hand;
										Cursor.Show();
										mainForm = new CMainFrame("EN-US", flag, cresourceHandler, cresourceHandler2, languageSettings, persistentApplicationSettings, controller, text);
										goto IL_5F6;
									}
									catch (CCustomException ex)
									{
										uint errorID = ex.ErrorID;
										CustomExceptionHandler customExceptionHandler = new CustomExceptionHandler(cresourceHandler, "EN-US");
										customExceptionHandler.a(errorID, true, ex);
										return;
									}
									catch (Exception a_)
									{
										if (CCustomException.CheckErrorIDExsists(a_))
										{
											uint errorID2 = CCustomException.GetErrorID(a_);
											CustomExceptionHandler customExceptionHandler2 = new CustomExceptionHandler(cresourceHandler, "EN-US");
											customExceptionHandler2.a(errorID2, true, a_);
											return;
										}
										uint a_2 = 1643U;
										CustomExceptionHandler customExceptionHandler3 = new CustomExceptionHandler(cresourceHandler, "EN-US");
										customExceptionHandler3.a(a_2, true, a_);
										return;
									}
									goto IL_2BE;
									IL_5F6:
									Application.DoEvents();
									num = 6;
									continue;
								case 4:
									goto IL_643;
								case 5:
									goto IL_407;
								case 6:
									if (flag2)
									{
										num = 11;
										continue;
									}
									goto IL_643;
								case 7:
									try
									{
										languageSettings.GetImageResourceFile(ref empty4);
										goto IL_2BE;
									}
									catch
									{
										MessageBox.Show("Unable to get resource file from registry.  Please re-install the application.", "DepotTool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
										return;
									}
									goto IL_643;
								case 8:
									goto IL_655;
								case 9:
									goto IL_3E8;
								case 10:
									try
									{
										persistentApplicationSettings.GetInstallPath(ref empty);
										Directory.SetCurrentDirectory(empty);
										persistentApplicationSettings.GetSoundStatus(ref flag2);
										controller = new CController(ref empty);
										controller.OpenController();
										goto IL_40C;
									}
									catch (CCustomException ex2)
									{
										uint errorID3 = ex2.ErrorID;
										CustomExceptionHandler customExceptionHandler4 = new CustomExceptionHandler(cresourceHandler, string.Empty);
										customExceptionHandler4.a(errorID3, true, ex2);
										return;
									}
									catch (Exception a_3)
									{
										if (CCustomException.CheckErrorIDExsists(a_3))
										{
											uint errorID4 = CCustomException.GetErrorID(a_3);
											CustomExceptionHandler customExceptionHandler5 = new CustomExceptionHandler(cresourceHandler, string.Empty);
											customExceptionHandler5.a(errorID4, true, a_3);
											return;
										}
										MessageBox.Show("Application has encountered an error. If you continue to get this message, please contact Customer Service.", "DepotTool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
										return;
									}
									IL_38E:
									Cursor.Current = Cursors.Hand;
									Cursor.Show();
									empty4 = string.Empty;
									num = 7;
									continue;
									try
									{
										IL_40C:
										for (;;)
										{
											CLicenseDialog clicenseDialog = new CLicenseDialog(cresourceHandler, "MOTOTRBO_DEPOT", "1.0", empty);
											num = 5;
											for (;;)
											{
												switch (num)
												{
												case 0:
													if (coneITLoginDlg == null)
													{
														num = 7;
														continue;
													}
													coneITLoginDlg.Text = cresourceHandler.GetString("MOTAPPDIR_DLG_TITLE");
													coneITLoginDlg.ShowDialog();
													num = 3;
													continue;
												case 1:
													controller.CloseController();
													Application.Exit();
													num = 2;
													continue;
												case 2:
													goto IL_4C3;
												case 3:
													if (!coneITLoginDlg.h)
													{
														num = 1;
														continue;
													}
													goto IL_544;
												case 4:
													goto IL_550;
												case 5:
													if (clicenseDialog.VerifyLicense(0))
													{
														num = 6;
														continue;
													}
													goto IL_544;
												case 6:
													try
													{
														controller.IsMotorolaUser();
													}
													catch
													{
														clicenseDialog.ShowDialog();
														controller.CloseController();
														return;
													}
													coneITLoginDlg = new COneITLoginDlg("EN-US", flag, cresourceHandler, controller, flag2, persistentApplicationSettings);
													num = 0;
													continue;
												case 7:
													MessageBox.Show(cresourceHandler.GetString("LOGINFORM_FAILED"), "DepotTool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
													num = 8;
													continue;
												case 8:
													goto IL_53F;
												}
												break;
												IL_544:
												num = 4;
											}
										}
										IL_4C3:
										IL_53F:
										return;
										IL_550:
										goto IL_38E;
									}
									catch (CCustomException ex3)
									{
										uint errorID5 = ex3.ErrorID;
										CustomExceptionHandler customExceptionHandler6 = new CustomExceptionHandler(cresourceHandler, "EN-US");
										customExceptionHandler6.a(errorID5, true, ex3);
										return;
									}
									catch (Exception a_4)
									{
										if (CCustomException.CheckErrorIDExsists(a_4))
										{
											uint errorID6 = CCustomException.GetErrorID(a_4);
											CustomExceptionHandler customExceptionHandler7 = new CustomExceptionHandler(cresourceHandler, "EN-US");
											customExceptionHandler7.a(errorID6, true, a_4);
											return;
										}
										uint a_5 = 1643U;
										CustomExceptionHandler customExceptionHandler8 = new CustomExceptionHandler(cresourceHandler, "EN-US");
										customExceptionHandler8.a(a_5, true, a_4);
										return;
									}
									goto IL_5D7;
								case 12:
									goto IL_1B3;
								}
								goto IL_175;
								IL_2BE:
								CMainFrame.a(ref cresourceHandler2, empty4, false);
								num = 3;
								continue;
								IL_3E8:
								MessageBox.Show("Unable to load resource file.  Please re-install the application.", "DepotTool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								num = 5;
								continue;
								IL_643:
								Application.Run(mainForm);
								num = 8;
							}
							IL_1B3:
							IL_407:
							return;
							goto IL_138;
							IL_655:
							return;
							Block_3:
							try
							{
								IL_8A:
								for (;;)
								{
									languageSettings.GetHelpFile("EN-US", ref text);
									int num2 = text.IndexOf("\\\\", 0);
									num = 4;
									for (;;)
									{
										switch (num)
										{
										case 0:
											if (num2 < 0)
											{
												num = 2;
												continue;
											}
											text = text.Remove(num2, 1);
											num2 = text.IndexOf("\\\\", 0);
											num = 3;
											continue;
										case 1:
											goto IL_11A;
										case 2:
											num = 1;
											continue;
										case 3:
											goto IL_F5;
										case 4:
											goto IL_F5;
										}
										break;
										IL_F5:
										num = 0;
									}
								}
								IL_11A:
								goto IL_1E3;
							}
							catch
							{
								MessageBox.Show("Unable to get help file from registry.  Please re-install the application.", "Depottool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return;
							}
							goto IL_138;
							IL_1E3:
							flag = Convert.ToBoolean(Convert.ToInt16(cresourceHandler.GetString("MIRRORED")));
							flag2 = false;
							controller = null;
							num = 10;
							goto IL_13A;
							IL_138:
							IL_175:
							CPlaySound cplaySound = new CPlaySound(flag, persistentApplicationSettings, cresourceHandler);
							cplaySound.b(CPlaySound.SoundType.c);
							num = 4;
							goto IL_13A;
							IL_5D7:
							persistentApplicationSettings = new CPersistentApplicationSettings();
							empty3 = string.Empty;
							num = 0;
							goto IL_13A;
						}
						catch (CCustomException ex4)
						{
							throw ex4;
						}
						catch (Exception ex5)
						{
							if (CCustomException.CheckErrorIDExsists(ex5))
							{
								if (true)
								{
								}
								CCustomException.Rethrow(ex5);
							}
							else
							{
								ex5.Source = "1872| " + ex5.Source;
								CCustomException.Rethrow(ex5);
							}
							return;
						}
						break;
					}
					break;
				}
				}
				break;
			}
			MessageBox.Show("Execution in the main failed.", "DepotTool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00009E34 File Offset: 0x00008E34
		public void j()
		{
			switch (0)
			{
			default:
				for (;;)
				{
					this.f1.Items.Clear();
					string empty = string.Empty;
					int num = 0;
					for (;;)
					{
						string text;
						int num2;
						switch (num)
						{
						case 0:
						{
							try
							{
								this.t.GetCPSInstallPath(ref empty);
								goto IL_44F;
							}
							catch
							{
								this.fr.Enabled = false;
								this.av = false;
								this.a(this.fr, this.cy, this.b9);
								this.fr.Text = this.u.GetString("BTN_DT_FLASH");
								this.ak.Enabled = true;
								this.a(this.ak, this.c5, this.ca);
								return;
							}
							goto IL_426;
							IL_44F:
							ArrayList arrayList = new ArrayList();
							ArrayList arrayList2 = new ArrayList();
							text = empty + "\\deviceupdate\\";
							num2 = text.IndexOf("\\\\", 0);
							num = 3;
							continue;
						}
						case 1:
							if (num2 < 0)
							{
								num = 4;
								continue;
							}
							goto IL_426;
						case 2:
							goto IL_2F2;
						case 3:
							goto IL_2F2;
						case 4:
							try
							{
								for (;;)
								{
									ArrayList arrayList;
									this.w.GetAvailPackage(null, null, null, null, text, 1, ref arrayList);
									ArrayList arrayList2;
									this.w.GetAvailPackage(null, null, null, null, text, 4, ref arrayList2);
									num = 10;
									for (;;)
									{
										switch (num)
										{
										case 0:
											this.a(arrayList2, true, arrayList.Count);
											num = 13;
											continue;
										case 1:
											goto IL_15E;
										case 2:
											if (arrayList2.Count > 0)
											{
												num = 0;
												continue;
											}
											goto IL_271;
										case 3:
											num = 2;
											continue;
										case 4:
											goto IL_27D;
										case 5:
											this.a(arrayList, false, 0);
											num = 6;
											continue;
										case 6:
											goto IL_235;
										case 7:
											this.fr.Enabled = false;
											this.av = false;
											this.a(this.fr, this.cy, this.b9);
											this.fr.Text = this.u.GetString("BTN_DT_FLASH");
											this.ak.Enabled = true;
											this.a(this.ak, this.c5, this.ca);
											num = 1;
											continue;
										case 8:
											if (arrayList != null)
											{
												num = 11;
												continue;
											}
											goto IL_235;
										case 9:
											num = 14;
											continue;
										case 10:
											if (arrayList.Count <= 0)
											{
												num = 9;
												continue;
											}
											goto IL_1F1;
										case 11:
											IL_21C:
											num = 12;
											continue;
										case 12:
											if (arrayList.Count > 0)
											{
												num = 5;
												continue;
											}
											goto IL_235;
										case 13:
											goto IL_271;
										case 14:
											if (arrayList2.Count <= 0)
											{
												num = 7;
												continue;
											}
											goto IL_1F1;
										case 15:
											if (arrayList2 != null)
											{
												num = 3;
												continue;
											}
											goto IL_271;
										}
										break;
										IL_1F1:
										this.f1.Items.Clear();
										num = 8;
										continue;
										IL_235:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_21C;
										default:
											if (false)
											{
											}
											num = 15;
											continue;
										}
										IL_271:
										num = 4;
									}
								}
								IL_15E:
								return;
								IL_27D:
								goto IL_317;
							}
							catch
							{
								this.fr.Enabled = false;
								this.av = false;
								this.a(this.fr, this.cy, this.b9);
								this.fr.Text = this.u.GetString("BTN_DT_FLASH");
								this.ak.Enabled = true;
								this.a(this.ak, this.c5, this.ca);
								return;
							}
							goto IL_2F2;
							IL_317:
							this.fr.Enabled = true;
							this.av = true;
							this.a(this.fr, this.cv, this.b9);
							this.fr.Text = this.u.GetString("BTN_DT_FLASH");
							this.ak.Enabled = true;
							this.a(this.ak, this.c5, this.ca);
							num = 5;
							continue;
						case 5:
							goto IL_397;
						}
						break;
						IL_2F2:
						num = 1;
						continue;
						IL_426:
						text = text.Remove(num2, 1);
						num2 = text.IndexOf("\\\\", 0);
						num = 2;
					}
				}
				IL_397:
				if (true)
				{
				}
				return;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000A2FC File Offset: 0x000092FC
		public void l()
		{
			switch (0)
			{
			default:
				for (;;)
				{
					Cursor.Current = Cursors.WaitCursor;
					Cursor.Show();
					this.f1.Items.Clear();
					string empty = string.Empty;
					int num = 1;
					for (;;)
					{
						string text;
						int num2;
						switch (num)
						{
						case 0:
							goto IL_41F;
						case 1:
						{
							if (true)
							{
							}
							try
							{
								this.t.GetCPSInstallPath(ref empty);
								goto IL_4D4;
							}
							catch
							{
								if (this.er)
								{
									CPlaySound cplaySound = new CPlaySound(this.Mirrored, this.t, this.u);
									cplaySound.b(CPlaySound.SoundType.b);
								}
								CCustomException ex = CustomExceptionHandler.a(3843U, base.GetType().ToString(), "ReloadUpgradePackages", Environment.StackTrace);
								throw ex;
							}
							goto IL_4A8;
							IL_4D4:
							ArrayList arrayList = new ArrayList();
							ArrayList arrayList2 = new ArrayList();
							text = empty + "\\deviceupdate\\";
							num2 = text.IndexOf("\\\\", 0);
							num = 0;
							continue;
						}
						case 2:
							goto IL_41F;
						case 3:
							try
							{
								for (;;)
								{
									ArrayList arrayList;
									this.w.GetAvailPackage(null, null, null, null, text, 1, ref arrayList);
									ArrayList arrayList2;
									this.w.GetAvailPackage(null, null, null, null, text, 4, ref arrayList2);
									num = 11;
									for (;;)
									{
										switch (num)
										{
										case 0:
											num = 5;
											continue;
										case 1:
											if (arrayList2.Count > 0)
											{
												num = 2;
												continue;
											}
											goto IL_235;
										case 2:
											this.a(arrayList2, true, arrayList.Count);
											num = 10;
											continue;
										case 3:
											goto IL_214;
										case 4:
											goto IL_2AB;
										case 5:
											if (arrayList.Count > 0)
											{
												num = 8;
												continue;
											}
											goto IL_214;
										case 6:
											num = 12;
											continue;
										case 7:
											if (arrayList2 != null)
											{
												num = 9;
												continue;
											}
											goto IL_235;
										case 8:
											goto IL_1FD;
										case 9:
											num = 1;
											continue;
										case 10:
											goto IL_235;
										case 11:
											if (arrayList.Count <= 0)
											{
												num = 6;
												continue;
											}
											goto IL_1CD;
										case 12:
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_1FD;
											default:
												if (false)
												{
												}
												if (arrayList2.Count <= 0)
												{
													num = 13;
													continue;
												}
												goto IL_1CD;
											}
											break;
										case 13:
											goto IL_1C8;
										case 14:
											if (arrayList != null)
											{
												num = 0;
												continue;
											}
											goto IL_214;
										}
										break;
										IL_1CD:
										this.f1.Items.Clear();
										num = 14;
										continue;
										IL_1FD:
										this.a(arrayList, false, 0);
										num = 3;
										continue;
										IL_214:
										num = 7;
										continue;
										IL_235:
										this.fr.Enabled = true;
										this.av = true;
										this.a(this.fr, this.cv, this.b9);
										this.fr.Text = this.u.GetString("BTN_DT_FLASH");
										this.ak.Enabled = true;
										this.a(this.ak, this.c5, this.ca);
										num = 4;
									}
								}
								IL_1C8:
								CCustomException ex2 = CustomExceptionHandler.a(2914U, base.GetType().ToString(), "ReloadUpgradePackages", Environment.StackTrace);
								throw ex2;
								IL_2AB:
								goto IL_50E;
							}
							catch (CCustomException ex3)
							{
								this.a(this.fr, this.cy, this.b9);
								this.fr.Text = this.u.GetString("BTN_DT_FLASH");
								this.fr.Enabled = false;
								this.av = false;
								this.ak.Enabled = true;
								this.a(this.ak, this.c5, this.ca);
								if (this.er)
								{
									CPlaySound cplaySound2 = new CPlaySound(this.Mirrored, this.t, this.u);
									cplaySound2.b(CPlaySound.SoundType.b);
								}
								throw ex3;
							}
							catch (Exception ex4)
							{
								this.a(this.fr, this.cy, this.b9);
								this.fr.Enabled = false;
								this.av = false;
								this.fr.Text = this.u.GetString("BTN_DT_FLASH");
								this.ak.Enabled = true;
								this.a(this.ak, this.c5, this.ca);
								if (this.er)
								{
									CPlaySound cplaySound3 = new CPlaySound(this.Mirrored, this.t, this.u);
									cplaySound3.b(CPlaySound.SoundType.b);
								}
								if (CCustomException.CheckErrorIDExsists(ex4))
								{
									CCustomException.Rethrow(ex4);
								}
								else
								{
									ex4.Source = "1872| " + ex4.Source;
									CCustomException.Rethrow(ex4);
								}
								goto IL_50E;
							}
							goto IL_41F;
						case 4:
							if (num2 < 0)
							{
								num = 3;
								continue;
							}
							goto IL_4A8;
						}
						break;
						IL_41F:
						num = 4;
						continue;
						IL_4A8:
						text = text.Remove(num2, 1);
						num2 = text.IndexOf("\\\\", 0);
						num = 2;
					}
				}
				IL_50E:
				Cursor.Current = Cursors.Default;
				Cursor.Show();
				return;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000A874 File Offset: 0x00009874
		private void a(ArrayList A_0, bool A_1, int A_2)
		{
			switch (0)
			{
			default:
			{
				int num = 0;
				int num2 = A_2;
				string text = string.Empty;
				string text2 = string.Empty;
				string text3 = string.Empty;
				string text4 = string.Empty;
				string text5 = string.Empty;
				string text6 = string.Empty;
				string empty = string.Empty;
				string empty2 = string.Empty;
				string empty3 = string.Empty;
				try
				{
					int num3 = 17;
					for (;;)
					{
						ListViewItem listViewItem;
						IEnumerator enumerator;
						switch (num3)
						{
						case 0:
							goto IL_4BB;
						case 1:
							text2 = this.u.GetString("NOT_AVAILABLE");
							num3 = 12;
							continue;
						case 2:
						{
							listViewItem.SubItems.Add(A_1 ? "Migration" : "Upgrade");
							listViewItem.SubItems.Add(text2);
							listViewItem.SubItems.Add(text4);
							listViewItem.SubItems.Add(text3);
							listViewItem.SubItems.Add(text5);
							listViewItem.SubItems.Add(text6);
							e e;
							listViewItem.SubItems.Add(e.e);
							listViewItem.SubItems.Add(empty3);
							this.f1.Items.Add(listViewItem);
							this.f1.Items[num2].Tag = e;
							num2++;
							num++;
							num3 = 4;
							continue;
						}
						case 3:
							goto IL_165;
						case 5:
							goto IL_13D;
						case 6:
							goto IL_29D;
						case 7:
							if (text2.Equals(string.Empty))
							{
								num3 = 1;
								continue;
							}
							goto IL_4E9;
						case 8:
							num3 = 24;
							continue;
						case 9:
							this.f1.Items[0].Selected = true;
							this.f1.Focus();
							num3 = 6;
							continue;
						case 10:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_512;
							default:
								if (false)
								{
								}
								text6 = this.u.GetString("NOT_AVAILABLE");
								num3 = 22;
								continue;
							}
							break;
						case 11:
							if (text6.Equals(string.Empty))
							{
								num3 = 10;
								continue;
							}
							goto IL_3F7;
						case 12:
							goto IL_4E9;
						case 13:
							goto IL_512;
						case 14:
							text3 = this.u.GetString("NOT_AVAILABLE");
							num3 = 3;
							continue;
						case 15:
							if (text3.Equals(string.Empty))
							{
								num3 = 14;
								continue;
							}
							goto IL_165;
						case 16:
						{
							if (num >= A_0.Count)
							{
								num3 = 8;
								continue;
							}
							e e = (e)A_0[num];
							text = (num2 + 1).ToString();
							text5 = e.a;
							text6 = e.b;
							text2 = e.h;
							text4 = e.i;
							text3 = e.j;
							empty3 = e.w;
							num3 = 20;
							continue;
						}
						case 18:
							if (text4.Equals(string.Empty))
							{
								num3 = 13;
								continue;
							}
							goto IL_13D;
						case 19:
							goto IL_557;
						case 20:
							if (text5.Equals(string.Empty))
							{
								num3 = 23;
								continue;
							}
							goto IL_4BB;
						case 21:
							try
							{
								num3 = 0;
								for (;;)
								{
									switch (num3)
									{
									case 1:
										num3 = 2;
										continue;
									case 2:
										goto IL_24F;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num3 = 1;
											continue;
										}
										ListViewItem listViewItem2 = (ListViewItem)enumerator.Current;
										this.f2.Items.Add((ListViewItem)listViewItem2.Clone());
										num3 = 4;
										continue;
									}
									}
									IL_229:
									num3 = 3;
									continue;
									goto IL_229;
								}
								IL_24F:
								goto IL_54B;
							}
							finally
							{
								for (;;)
								{
									IDisposable disposable = enumerator as IDisposable;
									num3 = 0;
									for (;;)
									{
										switch (num3)
										{
										case 0:
											if (disposable != null)
											{
												num3 = 1;
												continue;
											}
											goto IL_29C;
										case 1:
											disposable.Dispose();
											num3 = 2;
											continue;
										case 2:
											goto IL_29A;
										}
										break;
									}
								}
								IL_29A:
								IL_29C:;
							}
							goto IL_29D;
							IL_54B:
							num3 = 19;
							continue;
						case 22:
							goto IL_3F7;
						case 23:
							text5 = this.u.GetString("NOT_AVAILABLE");
							num3 = 0;
							continue;
						case 24:
							if (this.f1.Items.Count > 0)
							{
								num3 = 9;
								continue;
							}
							goto IL_29D;
						}
						IL_117:
						num3 = 16;
						continue;
						goto IL_117;
						IL_13D:
						num3 = 15;
						continue;
						IL_165:
						listViewItem = new ListViewItem(string.Empty, 0);
						listViewItem.Text = text;
						num3 = 2;
						continue;
						IL_29D:
						this.f2 = new ListView();
						enumerator = this.f1.Items.GetEnumerator();
						num3 = 21;
						continue;
						IL_3F7:
						num3 = 7;
						continue;
						IL_4BB:
						num3 = 11;
						continue;
						IL_4E9:
						num3 = 18;
						continue;
						IL_512:
						text4 = this.u.GetString("NOT_AVAILABLE");
						num3 = 5;
					}
					IL_557:;
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
						throw ex2;
					}
					ex2.Source = 1665U.ToString() + "| " + ex2.Source;
					throw ex2;
				}
				return;
			}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000AE6C File Offset: 0x00009E6C
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
						int num = 11;
						for (;;)
						{
							switch (num)
							{
							case 1:
								goto IL_234;
							case 2:
							{
								Control control;
								control.Click -= this.az;
								control.Click += this.az;
								num = 10;
								continue;
							}
							case 3:
							{
								Control control;
								((ListViewTemplate)control).SelectedIndexChanged -= this.au;
								((ListViewTemplate)control).SelectedIndexChanged += this.au;
								this.f1 = (ListViewTemplate)control;
								num = 13;
								continue;
							}
							case 4:
							{
								Control control;
								this.a(control);
								num = 0;
								continue;
							}
							case 5:
							{
								Control control;
								this.fr = (Button)control;
								num = 6;
								continue;
							}
							case 6:
								goto IL_11F;
							case 7:
							{
								string text;
								if (text.Equals("System.Windows.Forms.Button"))
								{
									num = 2;
									continue;
								}
								goto IL_11F;
							}
							case 8:
							{
								string text;
								if (text.Equals("panel_template.CPanelTemplate"))
								{
									num = 4;
									continue;
								}
								num = 7;
								continue;
							}
							case 9:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_F2;
								default:
								{
									if (false)
									{
									}
									string text;
									if (text.Equals("mototrbodepottool.ListViewTemplate"))
									{
										num = 3;
										continue;
									}
									break;
								}
								}
								break;
							case 10:
							{
								Control control;
								if (control.Name.Equals("BTN_DT_FLASH"))
								{
									num = 5;
									continue;
								}
								goto IL_11F;
							}
							case 12:
							{
								if (!enumerator.MoveNext())
								{
									num = 14;
									continue;
								}
								Control control = (Control)enumerator.Current;
								string text = control.GetType().ToString();
								goto IL_F2;
							}
							case 14:
								num = 1;
								continue;
							}
							goto IL_74;
							IL_F2:
							num = 8;
							continue;
							IL_11F:
							num = 9;
							continue;
							IL_165:
							num = 12;
							continue;
							IL_74:
							goto IL_165;
						}
						IL_234:;
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
									goto IL_27E;
								case 2:
									goto IL_27C;
								}
								break;
							}
						}
						IL_27C:
						IL_27E:;
					}
					break;
				}
				}
			}
			catch (Exception ex)
			{
				if (CCustomException.CheckErrorIDExsists(ex))
				{
					if (true)
					{
					}
					throw ex;
				}
				ex.Source = 1666U.ToString() + "| " + ex.Source;
				throw ex;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000B17C File Offset: 0x0000A17C
		private void az(object A_0, EventArgs A_1)
		{
			try
			{
				switch (0)
				{
				default:
					this.a(this.fr, this.cw, this.b9);
					this.fr.Text = this.u.GetString("BTN_DT_FLASH");
					goto IL_11F0;
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
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
				goto IL_11F0;
			}
			goto Block_1;
			int num;
			bool flag;
			string text;
			ListViewItem listViewItem;
			int num2;
			string text5;
			string empty;
			string text8;
			e avPak;
			string value;
			for (;;)
			{
				IL_10D4:
				if (true)
				{
				}
				switch (num)
				{
				case 0:
					goto IL_1105;
				case 1:
					flag = false;
					num = 0;
					continue;
				case 2:
					goto IL_11D7;
				case 3:
					goto IL_1105;
				case 4:
					if (text.Contains("Migration"))
					{
						num = 1;
						continue;
					}
					break;
				}
				goto IL_10F7;
				IL_1105:
				string text2 = listViewItem.SubItems[num2].Text;
				string text3 = listViewItem.SubItems[num2 + 1].Text;
				string text4 = listViewItem.SubItems[num2 + 2].Text;
				text5 = text4;
				string text6 = listViewItem.SubItems[num2 + 3].Text;
				string text7 = listViewItem.SubItems[num2 + 4].Text;
				e e = (e)listViewItem.Tag;
				empty = e.g;
				text8 = listViewItem.SubItems[num2 + 5].Text;
				string text9 = listViewItem.SubItems[num2 + 6].Text;
				avPak = e;
				value = this.fr.Name;
				num = 2;
			}
			IL_11D7:
			Block_1:
			ArrayList arrayList;
			ArrayList arrayList2;
			bool flag2;
			string empty2;
			string empty3;
			bool isDTPCfsEnable;
			bool isDTACfsEnable;
			OperateDevice operateDevice;
			string empty4;
			string empty5;
			ArrayList arrayList3;
			string empty6;
			string empty7;
			string empty8;
			string empty9;
			bool flag3;
			bool flag4;
			CProgressBar cprogressBar;
			CCPTags.SetProgressBar setProgressBar;
			string text10;
			bool flag5;
			bool a_2;
			bool a_3;
			bool a_4;
			bool a_5;
			try
			{
				for (;;)
				{
					this.a(3);
					this.f();
					Cursor.Current = Cursors.WaitCursor;
					this.w.ListConnectedDevices(out arrayList);
					this.w.ListConnectedBootmodeDevices(ref arrayList2);
					num = 40;
					for (;;)
					{
						DeviceInfo deviceInfo;
						CMsgDialog cmsgDialog3;
						CMsgDialog cmsgDialog7;
						List<DeviceInfo> list;
						List<string> list2;
						switch (num)
						{
						case 0:
							if (arrayList2.Count > 0)
							{
								num = 14;
								continue;
							}
							goto IL_B24;
						case 1:
						{
							if (flag2)
							{
								num = 3;
								continue;
							}
							decimal num3 = decimal.Parse(text8, NumberStyles.AllowDecimalPoint);
							num = 84;
							continue;
						}
						case 2:
							goto IL_C8C;
						case 3:
							deviceInfo = (DeviceInfo)arrayList[0];
							deviceInfo.SelectedPak = empty;
							deviceInfo.CPVersion = empty2;
							deviceInfo.FWVersion = empty3;
							deviceInfo.IsDTPCfsEnable = isDTPCfsEnable;
							deviceInfo.IsDTACfsEnable = isDTACfsEnable;
							deviceInfo.IsBootmode = false;
							deviceInfo.CheckUpdateInfo(null, !flag, avPak);
							num = 9;
							continue;
						case 4:
							if (arrayList2.Count >= 1)
							{
								num = 32;
								continue;
							}
							goto IL_7C3;
						case 5:
						{
							CMsgDialog cmsgDialog;
							if (cmsgDialog == null)
							{
								num = 85;
								continue;
							}
							cmsgDialog.Show(this, false, DialogResult.Yes, MessageBoxButtons.OK, MessageBoxIcon.Hand);
							this.e();
							this.a(0);
							num = 44;
							continue;
						}
						case 6:
							goto IL_ECC;
						case 7:
						{
							CMsgDialog cmsgDialog2;
							if (cmsgDialog2 == null)
							{
								num = 48;
								continue;
							}
							DialogResult dialogResult = DialogResult.Yes;
							dialogResult = cmsgDialog2.Show(this, false, dialogResult, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							num = 66;
							continue;
						}
						case 8:
							goto IL_C8C;
						case 9:
							if (deviceInfo.pakUUID == deviceInfo.DeviceUUID)
							{
								num = 37;
								continue;
							}
							goto IL_B89;
						case 10:
							cmsgDialog3 = new CMsgDialog(this.Mirrored, this.u, 3845, "DT_APP_NAME", null);
							num = 27;
							continue;
						case 11:
							if (flag)
							{
								num = 69;
								continue;
							}
							operateDevice.e(OperateDevice.Operatetype.d);
							num = 2;
							continue;
						case 12:
							if (empty4 != empty5)
							{
								num = 10;
								continue;
							}
							goto IL_8AB;
						case 13:
							if (arrayList2.Count <= 0)
							{
								num = 75;
								continue;
							}
							goto IL_5CB;
						case 14:
							num = 80;
							continue;
						case 15:
							num = 57;
							continue;
						case 16:
							if (this.er)
							{
								num = 53;
								continue;
							}
							goto IL_D6B;
						case 17:
							num = 4;
							continue;
						case 18:
							goto IL_8A6;
						case 19:
							if (!text5.Equals(this.u.GetString("NOT_AVAILABLE")))
							{
								num = 77;
								continue;
							}
							goto IL_2EB;
						case 20:
							goto IL_6F0;
						case 21:
							num = 12;
							continue;
						case 22:
							if (operateDevice.b != null)
							{
								num = 70;
								continue;
							}
							num = 58;
							continue;
						case 23:
							goto IL_519;
						case 24:
							goto IL_B24;
						case 25:
							goto IL_D92;
						case 26:
						{
							CMsgDialog cmsgDialog4;
							if (cmsgDialog4 == null)
							{
								num = 63;
								continue;
							}
							cmsgDialog4.Show(this, false, DialogResult.Yes, MessageBoxButtons.OK, MessageBoxIcon.Hand);
							this.e();
							this.a(0);
							num = 83;
							continue;
						}
						case 27:
							if (cmsgDialog3 == null)
							{
								num = 23;
								continue;
							}
							num = 16;
							continue;
						case 28:
							num = 22;
							continue;
						case 29:
							num = 64;
							continue;
						case 30:
							goto IL_8D0;
						case 31:
							goto IL_98A;
						case 32:
							goto IL_D3F;
						case 33:
							goto IL_E9F;
						case 34:
							if (!text5.Equals(this.u.GetString("NOT_AVAILABLE")))
							{
								num = 21;
								continue;
							}
							goto IL_8AB;
						case 35:
							this.e();
							this.a(0);
							num = 43;
							continue;
						case 36:
							goto IL_C87;
						case 37:
							num = 82;
							continue;
						case 38:
							if (arrayList3 == null)
							{
								num = 76;
								continue;
							}
							arrayList3.Add(value);
							operateDevice.d(arrayList3);
							operateDevice.d(false);
							operateDevice.d(this, this.Mirrored, this.u);
							num = 11;
							continue;
						case 39:
						{
							DialogResult dialogResult2;
							if (DialogResult.No == dialogResult2)
							{
								num = 65;
								continue;
							}
							this.Refresh();
							num = 56;
							continue;
						}
						case 40:
							if (arrayList.Count <= 0)
							{
								num = 47;
								continue;
							}
							goto IL_5CB;
						case 41:
						{
							CMsgDialog cmsgDialog = new CMsgDialog(true, this.u, 3847, "DT_APP_NAME", null);
							num = 5;
							continue;
						}
						case 42:
						{
							CMsgDialog cmsgDialog5 = new CMsgDialog(true, this.u, 3849, "DT_APP_NAME", null);
							num = 79;
							continue;
						}
						case 43:
							goto IL_AEA;
						case 44:
							goto IL_270;
						case 45:
							goto IL_D6B;
						case 46:
							goto IL_9C4;
						case 47:
							num = 13;
							continue;
						case 48:
							goto IL_C31;
						case 49:
						{
							CMsgDialog cmsgDialog6 = new CMsgDialog(true, this.u, 3844, "DT_APP_NAME", null);
							num = 50;
							continue;
						}
						case 50:
						{
							CMsgDialog cmsgDialog6;
							if (cmsgDialog6 == null)
							{
								num = 20;
								continue;
							}
							DialogResult dialogResult2 = DialogResult.Yes;
							dialogResult2 = cmsgDialog6.Show(this, false, dialogResult2, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							num = 39;
							continue;
						}
						case 51:
							if (this.er)
							{
								num = 61;
								continue;
							}
							goto IL_E9F;
						case 52:
							if (arrayList.Count >= 1)
							{
								num = 17;
								continue;
							}
							goto IL_7C3;
						case 53:
						{
							CPlaySound cplaySound = new CPlaySound(this.Mirrored, this.t, this.u);
							cplaySound.b(CPlaySound.SoundType.b);
							num = 45;
							continue;
						}
						case 54:
							if (arrayList.Count < 2)
							{
								num = 15;
								continue;
							}
							goto IL_60F;
						case 55:
							if (arrayList.Count > 0)
							{
								num = 78;
								continue;
							}
							goto IL_60F;
						case 56:
							goto IL_7ED;
						case 57:
							if (text5.Equals(this.u.GetString("NOT_AVAILABLE")))
							{
								num = 49;
								continue;
							}
							goto IL_7ED;
						case 58:
							if (operateDevice.i != null)
							{
								num = 73;
								continue;
							}
							goto IL_353;
						case 59:
							if (!operateDevice.f())
							{
								num = 68;
								continue;
							}
							cmsgDialog7 = null;
							cmsgDialog7 = new CMsgDialog(this.Mirrored, this.u, 3842, "DT_APP_NAME", null);
							num = 67;
							continue;
						case 60:
						{
							CMsgDialog cmsgDialog4 = new CMsgDialog(true, this.u, 3848, "DT_APP_NAME", null);
							num = 26;
							continue;
						}
						case 61:
						{
							CPlaySound cplaySound2 = new CPlaySound(this.Mirrored, this.t, this.u);
							cplaySound2.b(CPlaySound.SoundType.a);
							num = 33;
							continue;
						}
						case 62:
							goto IL_8D0;
						case 63:
							goto IL_A4E;
						case 64:
						{
							if (!flag)
							{
								num = 41;
								continue;
							}
							CMsgDialog cmsgDialog2 = new CMsgDialog(true, this.u, 3846, "DT_APP_NAME", null);
							num = 7;
							continue;
						}
						case 65:
							this.e();
							this.a(0);
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_D6B;
							default:
								if (false)
								{
								}
								num = 46;
								continue;
							}
							break;
						case 66:
						{
							DialogResult dialogResult;
							if (DialogResult.No == dialogResult)
							{
								num = 35;
								continue;
							}
							this.Refresh();
							flag2 = false;
							num = 71;
							continue;
						}
						case 67:
							if (cmsgDialog7 == null)
							{
								num = 81;
								continue;
							}
							num = 51;
							continue;
						case 68:
							Cursor.Current = Cursors.Default;
							this.a(0);
							num = 31;
							continue;
						case 69:
							operateDevice.e(OperateDevice.Operatetype.c);
							num = 8;
							continue;
						case 70:
							goto IL_4B3;
						case 71:
							goto IL_B24;
						case 72:
							goto IL_2EB;
						case 73:
							goto IL_968;
						case 74:
							if (operateDevice.c)
							{
								num = 28;
								continue;
							}
							goto IL_353;
						case 75:
							goto IL_29A;
						case 76:
							goto IL_93F;
						case 77:
							this.w.GetModelType(this.ac, text5, out empty4);
							num = 72;
							continue;
						case 78:
							num = 54;
							continue;
						case 79:
						{
							CMsgDialog cmsgDialog5;
							if (cmsgDialog5 == null)
							{
								num = 18;
								continue;
							}
							cmsgDialog5.Show(this, false, DialogResult.Yes, MessageBoxButtons.OK, MessageBoxIcon.Hand);
							this.e();
							this.a(0);
							num = 36;
							continue;
						}
						case 80:
							if (arrayList2.Count < 2)
							{
								num = 29;
								continue;
							}
							goto IL_B24;
						case 81:
							goto IL_759;
						case 82:
							if (!flag)
							{
								num = 60;
								continue;
							}
							goto IL_B89;
						case 83:
							goto IL_9F0;
						case 84:
						{
							decimal num3;
							if (num3 == 6m)
							{
								num = 42;
								continue;
							}
							deviceInfo = (DeviceInfo)arrayList2[0];
							deviceInfo.SelectedPak = empty;
							deviceInfo.CPVersion = empty2;
							deviceInfo.FWVersion = empty3;
							deviceInfo.IsBootmode = true;
							deviceInfo.CheckUpdateInfo(null, !flag, avPak);
							deviceInfo.isDualBoard = true;
							arrayList2[0] = deviceInfo;
							list.Add((DeviceInfo)arrayList2[0]);
							list2.Add(((DeviceInfo)arrayList2[0]).strIp);
							num = 30;
							continue;
						}
						case 85:
							goto IL_3F8;
						}
						break;
						IL_2EB:
						this.w.CloseConnection(this.ac);
						string a_;
						this.a(a_, ref empty6, ref empty7, ref empty8, ref empty3, ref empty2, ref empty5, ref empty9, ref flag3, ref flag4, ref isDTPCfsEnable, ref isDTACfsEnable);
						num = 34;
						continue;
						IL_353:
						cprogressBar.Close();
						setProgressBar = null;
						cprogressBar = null;
						num = 59;
						continue;
						IL_5CB:
						num = 52;
						continue;
						IL_60F:
						num = 0;
						continue;
						IL_7C3:
						num = 55;
						continue;
						IL_7ED:
						text10 = ((DeviceInfo)arrayList[0]).strIp;
						this.w.OpenConnection(text10, ref this.ac, setProgressBar);
						a_ = "DeviceInfo";
						flag5 = false;
						this.w.ReadDevice(ref this.ac, ref a_, ref flag5, setProgressBar);
						num = 19;
						continue;
						IL_8AB:
						a_2 = true;
						a_3 = false;
						a_4 = false;
						a_5 = false;
						num = 24;
						continue;
						IL_8D0:
						operateDevice.d(ref this.ac, this.w, cprogressBar, setProgressBar, "DeviceInfo", list2, list, flag);
						operateDevice.d(empty2, empty, empty6, deviceInfo.UpdateFW, deviceInfo.UpdateCP, a_2, a_3, a_4, a_5, cprogressBar, setProgressBar, text10, flag2);
						arrayList3 = new ArrayList();
						num = 38;
						continue;
						IL_B24:
						cprogressBar = new CProgressBar(this.u, this.Mirrored, 99);
						setProgressBar = new CCPTags.SetProgressBar(cprogressBar.a);
						cprogressBar.a(0);
						cprogressBar.a("LBL_PROGFLASHING");
						list = new List<DeviceInfo>();
						list2 = new List<string>();
						num = 1;
						continue;
						IL_B89:
						arrayList[0] = deviceInfo;
						list.Add((DeviceInfo)arrayList[0]);
						list2.Add(((DeviceInfo)arrayList[0]).strIp);
						num = 62;
						continue;
						IL_C8C:
						Cursor.Current = Cursors.WaitCursor;
						Cursor.Show();
						cprogressBar.StartPosition = FormStartPosition.CenterParent;
						cprogressBar.ShowDialog();
						num = 74;
						continue;
						IL_D6B:
						cmsgDialog3.Show(this, false, DialogResult.OK, MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.e();
						this.a(0);
						num = 25;
						continue;
						IL_E9F:
						cmsgDialog7.Show(this, false, DialogResult.OK, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						this.e();
						this.d();
						this.a(0);
						num = 6;
					}
				}
				IL_270:
				return;
				IL_29A:
				CCustomException ex3 = CustomExceptionHandler.a(1687U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex3;
				IL_3F8:
				CCustomException ex4 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex4;
				IL_4B3:
				throw operateDevice.b;
				IL_519:
				CCustomException ex5 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex5;
				IL_6F0:
				CCustomException ex6 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex6;
				IL_759:
				CCustomException ex7 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "UpdateDevice", Environment.StackTrace);
				throw ex7;
				IL_8A6:
				CCustomException ex8 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex8;
				IL_93F:
				CCustomException ex9 = CustomExceptionHandler.a(1622U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex9;
				IL_968:
				throw operateDevice.i;
				IL_98A:
				IL_9C4:
				IL_9F0:
				return;
				IL_A4E:
				CCustomException ex10 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex10;
				IL_AEA:
				return;
				IL_C31:
				CCustomException ex11 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex11;
				IL_C87:
				return;
				IL_D3F:
				CCustomException ex12 = CustomExceptionHandler.a(3841U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex12;
				IL_D92:
				IL_ECC:
				return;
			}
			catch (CCustomException ex13)
			{
				this.e();
				this.a(0);
				this.fr.Focus();
				Cursor.Current = Cursors.Default;
				if (cprogressBar != null)
				{
					cprogressBar.Close();
				}
				cprogressBar = null;
				if (this.w != null && this.ac > 0U)
				{
					this.w.CloseConnection(this.ac);
				}
				if (this.er)
				{
					CPlaySound cplaySound3 = new CPlaySound(this.Mirrored, this.t, this.u);
					cplaySound3.b(CPlaySound.SoundType.b);
				}
				if (flag2)
				{
					if (arrayList.Count > 0)
					{
						((DeviceInfo)arrayList[0]).CleanUpTempFiles();
					}
				}
				else if (arrayList2.Count > 0)
				{
					((DeviceInfo)arrayList2[0]).CleanUpTempFiles();
				}
				throw ex13;
			}
			catch (Exception ex14)
			{
				this.e();
				this.a(0);
				this.fr.Focus();
				Cursor.Current = Cursors.Default;
				if (cprogressBar != null)
				{
					cprogressBar.Close();
				}
				cprogressBar = null;
				if (this.w != null && this.ac > 0U)
				{
					this.w.CloseConnection(this.ac);
				}
				if (this.er)
				{
					CPlaySound cplaySound4 = new CPlaySound(this.Mirrored, this.t, this.u);
					cplaySound4.b(CPlaySound.SoundType.b);
				}
				if (flag2)
				{
					if (arrayList.Count > 0)
					{
						((DeviceInfo)arrayList[0]).CleanUpTempFiles();
					}
				}
				else if (arrayList2.Count > 0)
				{
					((DeviceInfo)arrayList2[0]).CleanUpTempFiles();
				}
				if (CCustomException.CheckErrorIDExsists(ex14))
				{
					throw ex14;
				}
				ex14.Source = 1788U.ToString() + "| " + ex14.Source;
				CCustomException.Rethrow(ex14);
				return;
			}
			IL_10F7:
			flag = true;
			num = 3;
			goto IL_10D4;
			IL_11F0:
			cprogressBar = null;
			setProgressBar = null;
			arrayList = new ArrayList();
			arrayList2 = new ArrayList();
			operateDevice = new OperateDevice();
			text10 = string.Empty;
			value = string.Empty;
			arrayList3 = null;
			empty6 = string.Empty;
			empty7 = string.Empty;
			empty8 = string.Empty;
			empty3 = string.Empty;
			empty2 = string.Empty;
			string empty10 = string.Empty;
			text5 = string.Empty;
			string empty11 = string.Empty;
			string empty12 = string.Empty;
			string empty13 = string.Empty;
			empty = string.Empty;
			empty5 = string.Empty;
			empty4 = string.Empty;
			empty9 = string.Empty;
			text8 = string.Empty;
			string empty14 = string.Empty;
			flag3 = false;
			flag4 = false;
			isDTPCfsEnable = false;
			isDTACfsEnable = false;
			flag5 = false;
			a_2 = false;
			a_3 = false;
			a_4 = false;
			a_5 = false;
			flag2 = true;
			listViewItem = this.f1.SelectedItems[0];
			flag = true;
			num2 = 2;
			text = listViewItem.SubItems[num2 - 1].Text;
			num = 4;
			goto IL_10D4;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000C4F4 File Offset: 0x0000B4F4
		public void a(object A_0, ThreadExceptionEventArgs A_1)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						CustomExceptionHandler customExceptionHandler = new CustomExceptionHandler(this.u, string.Empty);
						customExceptionHandler.a(this);
						uint a_ = 0U;
						CommonException ex = A_1.Exception as CommonException;
						int num = 3;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (A_1.Exception.GetType().FullName.Equals("custom_exception.CCustomException"))
								{
									num = 10;
									continue;
								}
								num = 8;
								continue;
							case 1:
								goto IL_14A;
							case 2:
								goto IL_1B1;
							case 3:
								if (ex != null)
								{
									num = 7;
									continue;
								}
								num = 0;
								continue;
							case 4:
								goto IL_1B1;
							case 5:
								a_ = CCustomException.GetErrorID(A_1.Exception);
								num = 9;
								continue;
							case 6:
								goto IL_1BD;
							case 7:
								a_ = CCustomException.GetErrorID(ex);
								customExceptionHandler.a(a_, true, new CCustomException((uint)(8192 + ex.ErrorCode), ex.Source, ex.Message, ex.StackTrace));
								num = 2;
								continue;
							case 8:
								if (CCustomException.CheckErrorIDExsists(A_1.Exception))
								{
									num = 5;
									continue;
								}
								a_ = 2689U;
								num = 11;
								continue;
							case 9:
								goto IL_148;
							case 10:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_148;
								default:
								{
									if (false)
									{
									}
									CCustomException ex2 = (CCustomException)A_1.Exception;
									a_ = ex2.ErrorID;
									num = 1;
									continue;
								}
								}
								break;
							case 11:
								goto IL_14A;
							}
							break;
							IL_14A:
							customExceptionHandler.a(a_, false, A_1.Exception);
							num = 4;
							continue;
							IL_148:
							goto IL_14A;
							IL_1B1:
							num = 6;
						}
					}
					IL_1BD:
					break;
				}
			}
			catch (CCustomException ex3)
			{
				throw ex3;
			}
			catch (Exception ex4)
			{
				CCustomException.Rethrow(ex4);
			}
			if (true)
			{
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000C718 File Offset: 0x0000B718
		public static void a(ref CResourceHandler A_0, string A_1, bool A_2)
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
				A_0 = null;
				try
				{
					A_0 = new CResourceHandler(new string[]
					{
						A_1
					}, A_2);
				}
				catch
				{
					A_0 = null;
				}
				break;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000C784 File Offset: 0x0000B784
		public string a(string A_0, string A_1, string A_2)
		{
			switch (0)
			{
			default:
			{
				XmlNodeList xmlNodeList;
				for (;;)
				{
					string empty = string.Empty;
					string empty2 = string.Empty;
					ArrayList arrayList = new ArrayList();
					ArrayList arrayList2 = new ArrayList();
					ArrayList arrayList3 = new ArrayList();
					int num = 11;
					for (;;)
					{
						switch (num)
						{
						case 0:
							num = 6;
							continue;
						case 1:
							if (xmlNodeList != null)
							{
								num = 0;
								continue;
							}
							goto IL_1A5;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_146;
							default:
								if (false)
								{
								}
								num = 3;
								continue;
							}
							break;
						case 3:
							if (arrayList != null)
							{
								num = 10;
								continue;
							}
							goto IL_23A;
						case 4:
						{
							if (string.Empty == empty)
							{
								num = 7;
								continue;
							}
							XmlDocument xmlDocument = this.a(empty);
							xmlNodeList = xmlDocument.SelectNodes("//" + A_0);
							num = 1;
							continue;
						}
						case 5:
							num = 4;
							continue;
						case 6:
							goto IL_146;
						case 7:
							goto IL_114;
						case 8:
							goto IL_15F;
						case 9:
							if (arrayList3 == null)
							{
								num = 13;
								continue;
							}
							arrayList.Add(A_0);
							arrayList2.Add(int.Parse(A_1, NumberFormatInfo.InvariantInfo));
							arrayList3.Add(int.Parse(A_2, NumberFormatInfo.InvariantInfo));
							this.w.RetrieveItem(this.ac, arrayList, arrayList2, arrayList3, ref empty);
							num = 12;
							continue;
						case 10:
							num = 9;
							continue;
						case 11:
							if (arrayList2 != null)
							{
								num = 2;
								continue;
							}
							goto IL_23A;
						case 12:
							if (empty != null)
							{
								num = 5;
								continue;
							}
							goto IL_181;
						case 13:
							goto IL_135;
						}
						break;
						IL_146:
						if (xmlNodeList.Count > 0)
						{
							goto IL_25E;
						}
						num = 8;
					}
				}
				IL_114:
				goto IL_181;
				IL_135:
				goto IL_23A;
				IL_15F:
				goto IL_1A5;
				IL_181:
				CCustomException ex = CustomExceptionHandler.a(1618U, base.GetType().ToString(), "RetrieveItemFromCP", Environment.StackTrace);
				throw ex;
				IL_1A5:
				CCustomException ex2 = CustomExceptionHandler.a(1623U, base.GetType().ToString(), "RetrieveItemFromCP", Environment.StackTrace);
				throw ex2;
				IL_23A:
				CCustomException ex3 = CustomExceptionHandler.a(1622U, base.GetType().ToString(), "RetrieveItemFromCP", Environment.StackTrace);
				throw ex3;
				IL_25E:
				if (true)
				{
				}
				return xmlNodeList[0].InnerText;
			}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000CA08 File Offset: 0x0000BA08
		public string a(string A_0, string A_1, string A_2, ref string A_3)
		{
			switch (0)
			{
			default:
			{
				string result;
				XmlNodeList xmlNodeList;
				for (;;)
				{
					string empty = string.Empty;
					result = string.Empty;
					ArrayList arrayList = new ArrayList();
					ArrayList arrayList2 = new ArrayList();
					ArrayList arrayList3 = new ArrayList();
					int num = 10;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_140;
						case 1:
							if (xmlNodeList != null)
							{
								num = 7;
								continue;
							}
							goto IL_1B3;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_231;
							default:
								if (false)
								{
								}
								if (arrayList3 == null)
								{
									num = 0;
									continue;
								}
								arrayList.Add(A_0);
								arrayList2.Add(int.Parse(A_1, NumberFormatInfo.InvariantInfo));
								arrayList3.Add(int.Parse(A_2, NumberFormatInfo.InvariantInfo));
								this.w.RetrieveItem(this.ac, arrayList, arrayList2, arrayList3, ref empty);
								num = 6;
								continue;
							}
							break;
						case 3:
							if (xmlNodeList.Count <= 0)
							{
								num = 8;
								continue;
							}
							goto IL_26C;
						case 4:
							num = 2;
							continue;
						case 5:
							if (arrayList != null)
							{
								num = 4;
								continue;
							}
							goto IL_248;
						case 6:
							goto IL_231;
						case 7:
							num = 3;
							continue;
						case 8:
							goto IL_16A;
						case 9:
							num = 5;
							continue;
						case 10:
							if (true)
							{
							}
							if (arrayList2 != null)
							{
								num = 9;
								continue;
							}
							goto IL_248;
						case 11:
							num = 12;
							continue;
						case 12:
						{
							if (string.Empty == empty)
							{
								num = 13;
								continue;
							}
							XmlDocument xmlDocument = this.a(empty);
							xmlNodeList = xmlDocument.SelectNodes("//" + A_0);
							num = 1;
							continue;
						}
						case 13:
							goto IL_100;
						}
						break;
						IL_231:
						if (empty == null)
						{
							goto IL_18F;
						}
						num = 11;
					}
				}
				IL_100:
				goto IL_18F;
				IL_140:
				goto IL_248;
				IL_16A:
				goto IL_1B3;
				IL_18F:
				CCustomException ex = CustomExceptionHandler.a(1618U, base.GetType().ToString(), "RetrieveItemFromCP", Environment.StackTrace);
				throw ex;
				IL_1B3:
				CCustomException ex2 = CustomExceptionHandler.a(1623U, base.GetType().ToString(), "RetrieveItemFromCP", Environment.StackTrace);
				throw ex2;
				IL_248:
				CCustomException ex3 = CustomExceptionHandler.a(1622U, base.GetType().ToString(), "RetrieveItemFromCP", Environment.StackTrace);
				throw ex3;
				IL_26C:
				result = xmlNodeList[0].InnerText;
				A_3 = xmlNodeList[0].Attributes["Applicable"].Value;
				return result;
			}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000CCB0 File Offset: 0x0000BCB0
		protected XmlDocument a(string A_0)
		{
			XmlDocument xmlDocument;
			for (;;)
			{
				xmlDocument = new XmlDocument();
				try
				{
					StringReader txtReader = new StringReader(A_0);
					xmlDocument.Load(txtReader);
				}
				catch (Exception ex)
				{
					ex.Source = 1625U.ToString() + "| " + ex.Source;
					CCustomException.Rethrow(ex);
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_5A;
				}
			}
			IL_5A:
			if (true)
			{
			}
			if (false)
			{
			}
			return xmlDocument;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000CD40 File Offset: 0x0000BD40
		private void ay(object A_0, EventArgs A_1)
		{
			switch (0)
			{
			default:
			{
				Form form = new Form();
				form = this;
				for (;;)
				{
					try
					{
						this.t.GetPosition(ref form);
						base.Location = form.Location;
						base.WindowState = form.WindowState;
						goto IL_958;
					}
					catch
					{
						base.StartPosition = FormStartPosition.CenterScreen;
						base.WindowState = FormWindowState.Normal;
						goto IL_958;
					}
					goto Block_3;
					Block_4:
					try
					{
						IL_958:
						for (;;)
						{
							this.gc.Location = this.ce;
							this.gc.Width = 800;
							this.gc.Height = 725;
							Image image = (Bitmap)this.v.GetObject("SPLASH01");
							Image image2 = (Bitmap)this.v.GetObject("SPLASH03");
							Image image3 = (Bitmap)this.v.GetObject("SPLASH05");
							Image image4 = (Bitmap)this.v.GetObject("SPLASH07");
							Image image5 = (Bitmap)this.v.GetObject("SPLASH10");
							Image image6 = (Bitmap)this.v.GetObject("SPLASH12");
							Image image7 = (Bitmap)this.v.GetObject("SPLASH14");
							Image image8 = (Bitmap)this.v.GetObject("SPLASH16");
							Image image9 = (Bitmap)this.v.GetObject("SPLASH17");
							Image[] array = new Image[]
							{
								image,
								image2,
								image3,
								image4,
								image5,
								image6,
								image7,
								image8,
								image9
							};
							int num = 9;
							int[] array2 = new int[num];
							int num2 = 0;
							int num3 = 3;
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_BEA;
								case 1:
									goto IL_BEA;
								case 2:
									if (num2 == num - 1)
									{
										num3 = 10;
										continue;
									}
									array2[num2] = 10;
									num3 = 5;
									continue;
								case 3:
									goto IL_B8D;
								case 4:
									goto IL_C2B;
								case 5:
									goto IL_C2B;
								case 6:
									goto IL_C77;
								case 7:
									if (num2 >= num)
									{
										num3 = 8;
										continue;
									}
									num3 = 12;
									continue;
								case 8:
								{
									int num4 = 0;
									num3 = 0;
									continue;
								}
								case 9:
									this.gc.Enabled = false;
									this.gc.Visible = false;
									num3 = 6;
									continue;
								case 10:
									array2[num2] = 200;
									num3 = 4;
									continue;
								case 11:
									goto IL_C2B;
								case 12:
									if (num2 == 0)
									{
										num3 = 15;
										continue;
									}
									num3 = 2;
									continue;
								case 13:
								{
									int num4;
									if (num4 >= num)
									{
										num3 = 9;
										continue;
									}
									MemoryStream stream = new MemoryStream();
									array[num4].Save(stream, ImageFormat.Bmp);
									this.gc.Image = Image.FromStream(stream);
									this.gc.Visible = true;
									Application.DoEvents();
									Thread.Sleep(array2[num4] * 10);
									num4++;
									num3 = 1;
									continue;
								}
								case 14:
									goto IL_B8D;
								case 15:
									array2[num2] = 100;
									num3 = 11;
									continue;
								}
								break;
								IL_B8D:
								num3 = 7;
								continue;
								IL_BEA:
								num3 = 13;
								continue;
								IL_C2B:
								num2++;
								num3 = 14;
							}
						}
						IL_C77:
						goto IL_25;
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
								if (true)
								{
								}
								CCustomException.Rethrow(ex2);
								goto IL_CEA;
							}
						}
						ex2.Source = 3154U.ToString() + "| " + ex2.Source;
						CCustomException.Rethrow(ex2);
						IL_CEA:
						goto IL_25;
					}
					break;
					try
					{
						IL_25:
						for (;;)
						{
							this.a(this, this.ci, base.Location);
							this.a(this.an, this.cz, this.b6);
							this.a(this.aj, this.c1, this.b5);
							this.a(this.fo, this.cj, this.az);
							this.a(this.fp, this.cq, this.ay);
							this.a(this.fq, this.cr, this.b8);
							this.a(this.aq, this.cr, this.cg);
							this.a(this.au, this.cr, this.ch);
							this.a(this.fr, this.cv, this.b9);
							this.a(this.am, this.c3, this.cb);
							this.a(this.ak, this.c5, this.ca);
							this.a(this.al, this.c7, this.b7);
							this.a(this.gd, this.c9, this.a0);
							this.t.GetSoundStatus(ref this.er);
							int num3 = 2;
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_1F4;
								case 1:
									goto IL_200;
								case 2:
									if (this.er)
									{
										num3 = 3;
										continue;
									}
									this.a(this.ao, this.dc, this.cd);
									num3 = 4;
									continue;
								case 3:
									this.a(this.ao, this.db, this.cc);
									num3 = 0;
									continue;
								case 4:
									goto IL_1F4;
								}
								break;
								IL_1F4:
								num3 = 1;
							}
						}
						IL_200:
						goto IL_28F;
					}
					catch (CCustomException ex3)
					{
						throw ex3;
					}
					catch (Exception ex4)
					{
						if (CCustomException.CheckErrorIDExsists(ex4))
						{
							CCustomException.Rethrow(ex4);
						}
						else
						{
							ex4.Source = 3153U.ToString() + "| " + ex4.Source;
							CCustomException.Rethrow(ex4);
						}
						goto IL_28F;
					}
					continue;
					Block_3:
					try
					{
						IL_28F:
						this.Text = this.u.GetString("DT_APP_TITLE");
						this.fo.Text = this.u.GetString("BTN_DT_READ");
						this.fq.Text = this.u.GetString("BTN_DT_BLANK");
						this.aq.Text = this.u.GetString("BTN_DT_IME");
						this.au.Text = this.u.GetString("searchButton");
						this.fp.Text = this.u.GetString("BTN_DT_WRITE");
						this.fr.Text = this.u.GetString("BTN_DT_FLASH");
						this.fs.Text = this.u.GetString("RS_DEVICESERIALNUM");
						this.@as.Text = this.u.GetString("RS_IMETYPE");
						this.f4.Text = this.u.GetString("RS_REGION");
						this.f5.Text = this.u.GetString("RS_DEVICETANAPANUM");
						this.f6.Text = this.u.GetString("RS_MODELNUM");
						this.f7.Text = this.u.GetString("CS_FWVER");
						this.f8.Text = this.u.GetString("RS_SECVERS");
						this.gb.Text = this.u.GetString("RS_PACKAGETYPE");
						this.et.Text = this.u.GetString("RS_DEVICESERIALNUM");
						this.eu.Text = this.u.GetString("RS_BRICKSERIALNUM");
						this.es.Text = this.u.GetString("RS_MODELNUM");
						this.ew.Text = this.u.GetString("CS_FWVER");
						this.ex.Text = this.u.GetString("RS_SECVERS");
						this.ev.Text = this.u.GetString("RS_DEVICETANAPANUM");
						this.ez.Text = this.u.GetString("RS_REGION");
						this.ey.Text = this.u.GetString("RS_BANDFREQRGN");
						this.e0.Text = this.u.GetString("RS_BOOTLOADER");
						this.e1.Text = this.u.GetString("RS_PSDT");
						this.e2.Text = this.u.GetString("RI_LPGSOURCE");
						this.fv.Text = this.u.GetString("RI_LPGDATE");
						this.fn.Text = this.u.GetString("LBL_TXBOARD");
						this.fm.Text = this.u.GetString("LBL_RXBOARD");
						this.et.Location = this.a2;
						this.eu.Location = this.a3;
						this.es.Location = this.a4;
						this.ex.Location = this.a5;
						this.ew.Location = this.a6;
						this.ey.Location = this.a9;
						this.ev.Location = this.a8;
						this.e0.Location = this.ba;
						this.e1.Location = this.bb;
						this.ez.Location = this.a7;
						this.fv.Location = this.bc;
						this.e2.Location = this.bd;
						this.e3.Location = this.bv;
						this.fa.Location = this.bw;
						this.e4.Location = this.bx;
						this.e7.Location = this.b1;
						this.e8.Location = this.b2;
						this.e5.Location = this.by;
						this.fb.Location = this.bz;
						this.e9.Location = this.b0;
						this.ft.Location = this.b3;
						this.e6.Location = this.b4;
						this.f0.Location = this.bt;
						this.f9.Location = this.bq;
						this.ae.Location = this.bq;
						this.fn.Location = this.br;
						this.fm.Location = this.bs;
						this.fc.Location = this.bg;
						this.fl.Location = this.bh;
						this.fk.Location = this.bi;
						this.fi.Location = this.bm;
						this.fj.Location = this.bn;
						this.fh.Location = this.bj;
						this.fe.Location = this.bk;
						this.ff.Location = this.bl;
						this.fu.Location = this.bo;
						this.fg.Location = this.bp;
						this.fz.Location = this.be;
						this.fy.Location = this.bu;
						this.fd.Location = this.bf;
						this.ap.Location = this.cf;
						this.fo.TabIndex = 0;
						this.fq.TabIndex = 1;
						this.fs.TabIndex = 2;
						this.fp.TabIndex = 3;
						this.aq.TabIndex = 4;
						this.fs.TabIndex = 5;
						this.ar.TabIndex = 6;
						this.au.TabIndex = 7;
						this.at.TabIndex = 8;
						this.f1.TabIndex = 9;
						this.fr.TabIndex = 10;
						this.ap.Width = 350;
						this.ap.Height = 150;
						this.ar.SelectedIndex = 0;
						break;
					}
					catch (CCustomException ex5)
					{
						throw ex5;
					}
					catch (Exception ex6)
					{
						if (CCustomException.CheckErrorIDExsists(ex6))
						{
							CCustomException.Rethrow(ex6);
						}
						else
						{
							ex6.Source = 1628U.ToString() + "| " + ex6.Source;
							CCustomException.Rethrow(ex6);
						}
						break;
					}
					goto Block_4;
				}
				this.fo.Enabled = true;
				this.fr.Enabled = false;
				this.fq.Enabled = true;
				this.fp.Enabled = false;
				this.aq.Enabled = true;
				this.au.Enabled = true;
				this.ak.Enabled = true;
				this.ao.Enabled = true;
				this.al.Enabled = true;
				this.am.Enabled = true;
				this.an.Enabled = true;
				this.aj.Enabled = true;
				this.fr.Visible = true;
				this.fo.Visible = true;
				this.fq.Visible = true;
				this.fp.Visible = true;
				this.aq.Visible = true;
				this.au.Visible = true;
				this.an.Visible = true;
				this.aj.Visible = true;
				this.ak.Visible = true;
				this.fs.Visible = true;
				this.@as.Visible = true;
				this.am.Visible = true;
				this.ao.Visible = true;
				this.al.Visible = true;
				this.gd.Visible = true;
				this.f1.Visible = true;
				this.fw.Visible = true;
				this.ar.Visible = true;
				this.at.Visible = true;
				this.j();
				this.a(0);
				base.ShowInTaskbar = true;
				this.fw.Focus();
				this.at.MaxLength = 80;
				return;
			}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000DC8C File Offset: 0x0000CC8C
		private void ax(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.gd, this.c9, this.a0);
				this.b();
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
						break;
					}
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
			if (true)
			{
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000DD4C File Offset: 0x0000CD4C
		private void av(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.gd, this.da, this.a0);
				this.c();
				this.d();
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
					goto IL_67;
				}
				IL_3C:
				ex2.Source = 3153U.ToString() + "| " + ex2.Source;
				CCustomException.Rethrow(ex2);
				IL_67:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3C;
				default:
					if (false)
					{
					}
					break;
				}
			}
			if (true)
			{
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000DE0C File Offset: 0x0000CE0C
		private void a(Control A_0, Bitmap A_1, Point A_2)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							Form form = (Form)A_0;
							form.FormBorderStyle = FormBorderStyle.None;
							form.BackgroundImage = A_1;
							form.Location = A_2;
							GraphicsPath path = this.a(A_1);
							form.Region = new Region(path);
							num = 2;
							continue;
						}
						case 2:
							goto IL_147;
						case 3:
							goto IL_147;
						case 4:
							goto IL_153;
						case 5:
							goto IL_56;
						case 6:
						{
							if (A_0 is Form)
							{
								num = 0;
								continue;
							}
							A_0.Text = "";
							A_0.Cursor = Cursors.Hand;
							A_0.BackgroundImage = A_1;
							A_0.Location = A_2;
							GraphicsPath path2 = this.a(A_1);
							A_0.Region = new Region(path2);
							num = 3;
							continue;
						}
						case 7:
							num = 8;
							continue;
						case 8:
							if (A_1 == null)
							{
								num = 5;
								continue;
							}
							A_0.Width = A_1.Width;
							A_0.Height = A_1.Height;
							num = 6;
							continue;
						case 9:
							goto IL_5F;
						}
						if (A_0 != null)
						{
							num = 7;
							continue;
						}
						IL_56:
						num = 9;
						continue;
						IL_147:
						num = 4;
					}
					IL_5F:
					IL_153:
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
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
					goto IL_19F;
				}
				IL_196:
				CCustomException.Rethrow(ex2);
				IL_19F:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_196;
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

		// Token: 0x06000052 RID: 82 RVA: 0x0000E01C File Offset: 0x0000D01C
		private GraphicsPath a(Bitmap A_0)
		{
			GraphicsPath result;
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						GraphicsPath graphicsPath = new GraphicsPath();
						Color pixel = A_0.GetPixel(0, 0);
						int num = 0;
						int num2 = 0;
						int num3 = 7;
						for (;;)
						{
							if (true)
							{
							}
							int num4;
							int num5;
							switch (num3)
							{
							case 0:
								goto IL_1AF;
							case 1:
								if (num4 >= A_0.Width)
								{
									goto IL_14C;
								}
								num3 = 12;
								continue;
							case 2:
								goto IL_136;
							case 3:
								goto IL_10D;
							case 4:
								goto IL_136;
							case 5:
								goto IL_20F;
							case 6:
								result = graphicsPath;
								num3 = 5;
								continue;
							case 7:
								goto IL_10D;
							case 8:
								num = num5;
								num4 = num5;
								num4 = num;
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_14C;
								default:
									if (false)
									{
									}
									num3 = 4;
									continue;
								}
								break;
							case 9:
								if (num5 >= A_0.Width)
								{
									num3 = 16;
									continue;
								}
								num3 = 10;
								continue;
							case 10:
								if (A_0.GetPixel(num5, num2) != pixel)
								{
									num3 = 8;
									continue;
								}
								goto IL_F9;
							case 11:
								num4++;
								num3 = 2;
								continue;
							case 12:
								if (!(A_0.GetPixel(num4, num2) == pixel))
								{
									num3 = 11;
									continue;
								}
								goto IL_1AF;
							case 13:
								if (num2 >= A_0.Height)
								{
									num3 = 6;
									continue;
								}
								num = 0;
								num5 = 0;
								num3 = 14;
								continue;
							case 14:
								goto IL_185;
							case 15:
								goto IL_185;
							case 16:
								num2++;
								num3 = 3;
								continue;
							case 17:
								goto IL_F9;
							}
							break;
							IL_F9:
							num5++;
							num3 = 15;
							continue;
							IL_10D:
							num3 = 13;
							continue;
							IL_136:
							num3 = 1;
							continue;
							IL_14C:
							num3 = 0;
							continue;
							IL_185:
							num3 = 9;
							continue;
							IL_1AF:
							graphicsPath.AddRectangle(new Rectangle(num, num2, num4 - num, 1));
							num5 = num4;
							num3 = 17;
						}
					}
					IL_20F:
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
					CCustomException.Rethrow(ex2);
					result = null;
				}
				else
				{
					ex2.Source = 3155U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000E2CC File Offset: 0x0000D2CC
		private void d(object A_0, MouseEventArgs A_1)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					goto IL_68;
				case 1:
					this.ax = new Point(-A_1.X, -A_1.Y);
					num = 0;
					continue;
				}
				IL_1C:
				if (A_1.Button == MouseButtons.Left)
				{
					num = 1;
					continue;
				}
				IL_68:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1C;
				default:
					goto IL_7E;
				}
			}
			IL_7E:
			if (false)
			{
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000E360 File Offset: 0x0000D360
		private void c(object A_0, MouseEventArgs A_1)
		{
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
					base.Location = new Point(base.Location.X + A_1.X - this.dd.X, base.Location.Y + A_1.Y - this.dd.Y);
					num = 2;
					continue;
				case 1:
					goto IL_102;
				case 2:
					goto IL_A6;
				case 3:
					if (!this.df)
					{
						num = 0;
						continue;
					}
					goto IL_104;
				case 5:
					if (true)
					{
					}
					num = 6;
					continue;
				case 6:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_104;
					default:
						if (false)
						{
						}
						if (this.de)
						{
							num = 1;
							continue;
						}
						num = 3;
						continue;
					}
					break;
				}
				if (A_1.Button != MouseButtons.Left)
				{
					goto IL_14A;
				}
				num = 5;
			}
			IL_A6:
			goto IL_104;
			IL_102:
			this.dd = new Point(A_1.X, A_1.Y);
			this.de = false;
			return;
			IL_104:
			this.dd = new Point(A_1.X, A_1.Y);
			this.df = !this.df;
			return;
			IL_14A:
			this.de = true;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000E4C8 File Offset: 0x0000D4C8
		private void au(object A_0, EventArgs A_1)
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

		// Token: 0x06000056 RID: 86 RVA: 0x0000E504 File Offset: 0x0000D504
		private void at(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.fo, this.cl, this.az);
				this.fo.Text = this.u.GetString("BTN_DT_READ");
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
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						break;
					}
					CCustomException.Rethrow(ex2);
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000E5D4 File Offset: 0x0000D5D4
		private void @as(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.fo, this.cj, this.az);
				this.fo.Text = this.u.GetString("BTN_DT_READ");
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
						if (false)
						{
						}
						ex2.Source = 3153U.ToString() + "| " + ex2.Source;
						CCustomException.Rethrow(ex2);
						goto IL_9A;
					}
				}
				if (true)
				{
				}
				CCustomException.Rethrow(ex2);
				IL_9A:;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000E6A4 File Offset: 0x0000D6A4
		private void ar(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.fq, this.ct, this.b8);
				this.fq.Text = this.u.GetString("BTN_DT_BLANK");
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
						if (false)
						{
						}
						ex2.Source = 3153U.ToString() + "| " + ex2.Source;
						CCustomException.Rethrow(ex2);
						goto IL_92;
					}
				}
				CCustomException.Rethrow(ex2);
				IL_92:;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000E774 File Offset: 0x0000D774
		private void aq(object A_0, EventArgs A_1)
		{
			try
			{
				if (true)
				{
				}
				this.a(this.fq, this.cr, this.b8);
				this.fq.Text = this.u.GetString("BTN_DT_BLANK");
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
						break;
					}
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000E844 File Offset: 0x0000D844
		private void ap(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.fr, this.cv, this.b9);
				this.fr.Text = this.u.GetString("BTN_DT_FLASH");
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
						if (true)
						{
						}
						CCustomException.Rethrow(ex2);
						goto IL_9A;
					}
				}
				ex2.Source = 3153U.ToString() + "| " + ex2.Source;
				CCustomException.Rethrow(ex2);
				IL_9A:;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000E914 File Offset: 0x0000D914
		private void ao(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.fr, this.cx, this.b9);
				this.fr.Text = this.u.GetString("BTN_DT_FLASH");
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				if (CCustomException.CheckErrorIDExsists(ex2))
				{
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_59;
						}
					}
					IL_59:
					if (true)
					{
					}
					if (false)
					{
					}
					CCustomException.Rethrow(ex2);
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000E9E4 File Offset: 0x0000D9E4
		private void an(object A_0, EventArgs A_1)
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
			this.ap(A_0, A_1);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000EA28 File Offset: 0x0000DA28
		private void am(object A_0, EventArgs A_1)
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
			this.ao(A_0, A_1);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000EA6C File Offset: 0x0000DA6C
		private void al(object A_0, EventArgs A_1)
		{
			try
			{
				switch (0)
				{
				default:
					this.a(this.fo, this.ck, this.az);
					this.fo.Text = this.u.GetString("BTN_DT_READ");
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
					CCustomException.Rethrow(ex2);
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
			ArrayList arrayList = new ArrayList();
			OperateDevice operateDevice = new OperateDevice();
			string strIP = string.Empty;
			CProgressBar cprogressBar = null;
			CCPTags.SetProgressBar setProgressBar = null;
			try
			{
				for (;;)
				{
					this.a(1);
					this.f();
					Cursor.Current = Cursors.WaitCursor;
					Cursor.Show();
					this.w.ListConnectedDevices(out arrayList);
					int num = 118;
					for (;;)
					{
						string empty;
						ArrayList arrayList2;
						string text;
						int num3;
						string value;
						switch (num)
						{
						case 0:
							this.fn.Visible = true;
							this.fn.Text = this.u.GetString("LBL_TXBOARD");
							num = 147;
							continue;
						case 1:
							goto IL_97B;
						case 2:
							goto IL_C83;
						case 3:
							goto IL_13C0;
						case 4:
							if ("Enabled" == empty)
							{
								num = 0;
								continue;
							}
							this.fn.Visible = false;
							num = 96;
							continue;
						case 5:
							goto IL_1CC9;
						case 6:
							if ("Enabled" == empty)
							{
								num = 116;
								continue;
							}
							this.fc.Visible = false;
							num = 122;
							continue;
						case 7:
							if ("Enabled" == empty)
							{
								num = 61;
								continue;
							}
							this.e8.Visible = false;
							num = 142;
							continue;
						case 8:
							if ("Enabled" == empty)
							{
								num = 113;
								continue;
							}
							goto IL_177C;
						case 9:
							if ("Enabled" == empty)
							{
								num = 105;
								continue;
							}
							this.ff.Visible = false;
							num = 50;
							continue;
						case 10:
						{
							int num2;
							if (num2 >= arrayList2.Count)
							{
								num = 107;
								continue;
							}
							this.ff.Items.Add(arrayList2[num2]);
							num2++;
							num = 16;
							continue;
						}
						case 11:
							goto IL_1BD4;
						case 12:
							goto IL_AD7;
						case 13:
							goto IL_39C;
						case 14:
							goto IL_1CC4;
						case 15:
							this.ff.ScrollAlwaysVisible = true;
							num = 74;
							continue;
						case 16:
							goto IL_1650;
						case 17:
							goto IL_1B47;
						case 18:
							goto IL_D50;
						case 19:
							goto IL_E61;
						case 20:
						{
							CPlaySound cplaySound = new CPlaySound(this.Mirrored, this.t, this.u);
							cplaySound.b(CPlaySound.SoundType.a);
							num = 114;
							continue;
						}
						case 21:
							if ("Enabled" == empty)
							{
								num = 138;
								continue;
							}
							this.fe.Visible = false;
							num = 98;
							continue;
						case 22:
							goto IL_EEF;
						case 23:
							this.f9.Visible = true;
							this.f9.Text = this.u.GetString("LBL_MODELTYPE");
							num = 13;
							continue;
						case 24:
							this.fd.Visible = true;
							this.fd.Text = text;
							num = 83;
							continue;
						case 25:
							this.fj.Visible = true;
							this.fj.Text = text;
							num = 40;
							continue;
						case 26:
							goto IL_75B;
						case 27:
							if ("Enabled" == empty)
							{
								num = 144;
								continue;
							}
							this.fl.Visible = false;
							num = 95;
							continue;
						case 28:
							this.ez.Visible = true;
							this.e5.Visible = true;
							this.e5.Text = text;
							num = 110;
							continue;
						case 29:
							this.ew.Visible = true;
							this.e4.Visible = true;
							this.e4.Text = text;
							num = 18;
							continue;
						case 30:
							goto IL_1561;
						case 31:
							if (arrayList.Count > 1)
							{
								num = 14;
								continue;
							}
							goto IL_1AA9;
						case 32:
							goto IL_C83;
						case 33:
							num = 56;
							continue;
						case 34:
							this.ae.Visible = true;
							this.ae.Text = this.u.GetString("LBL_SINGLEMODELTYPE");
							num = 82;
							continue;
						case 35:
							goto IL_1BD4;
						case 36:
							goto IL_1D3E;
						case 37:
							goto IL_410;
						case 38:
							goto IL_410;
						case 39:
							goto IL_17B6;
						case 40:
							goto IL_5B0;
						case 41:
							this.e2.Visible = true;
							this.e6.Visible = true;
							this.e6.Text = text;
							num = 30;
							continue;
						case 42:
							if ("Enabled" == empty)
							{
								num = 126;
								continue;
							}
							this.fg.Visible = false;
							num = 39;
							continue;
						case 43:
							goto IL_85D;
						case 44:
							if ("Enabled" == empty)
							{
								num = 24;
								continue;
							}
							this.fd.Visible = false;
							num = 99;
							continue;
						case 45:
							this.ex.Visible = true;
							this.fa.Visible = true;
							this.fa.Text = text;
							num = 32;
							continue;
						case 46:
							this.fh.Visible = true;
							this.fh.Text = text;
							num = 70;
							continue;
						case 47:
							try
							{
								num = 4;
								for (;;)
								{
									switch (num)
									{
									case 1:
										if (num3 == -1)
										{
											num = 6;
											continue;
										}
										value = text.Substring(0, num3);
										arrayList2.Add(value);
										text = text.Substring(num3 + 1);
										num = 0;
										continue;
									case 2:
										goto IL_152B;
									case 3:
										if (text.Length <= 0)
										{
											num = 2;
											continue;
										}
										num3 = text.IndexOf("\n");
										num = 1;
										continue;
									case 5:
										goto IL_152B;
									case 6:
										arrayList2.Add(text);
										num = 5;
										continue;
									case 7:
										goto IL_1537;
									}
									IL_14AC:
									num = 3;
									continue;
									goto IL_14AC;
									IL_152B:
									num = 7;
								}
								IL_1537:
								goto IL_A0E;
							}
							catch (Exception)
							{
								CCustomException ex3 = CustomExceptionHandler.a(1698U, base.GetType().ToString(), "ReadDevice", Environment.StackTrace);
								throw ex3;
							}
							goto IL_1561;
							IL_A0E:
							num = 9;
							continue;
						case 48:
							goto IL_6C8;
						case 49:
							if ("Enabled" == empty)
							{
								num = 46;
								continue;
							}
							this.fh.Visible = false;
							num = 19;
							continue;
						case 50:
							goto IL_1841;
						case 51:
							if (!string.IsNullOrEmpty(text))
							{
								num = 101;
								continue;
							}
							goto IL_BD0;
						case 52:
							goto IL_B1E;
						case 53:
							this.e9.ScrollAlwaysVisible = true;
							num = 148;
							continue;
						case 54:
							this.ev.Visible = true;
							this.fb.Visible = true;
							this.fb.Text = text;
							num = 108;
							continue;
						case 55:
							if ("Enabled" == empty)
							{
								num = 34;
								continue;
							}
							this.ae.Visible = false;
							num = 63;
							continue;
						case 56:
							if (this.e9.Items.Count > 1)
							{
								num = 53;
								continue;
							}
							this.e9.ScrollAlwaysVisible = false;
							num = 52;
							continue;
						case 57:
							this.e0.Visible = true;
							this.e7.Visible = true;
							this.e7.Text = text;
							num = 135;
							continue;
						case 58:
							if ("Enabled" == empty)
							{
								num = 141;
								continue;
							}
							this.e3.Visible = false;
							num = 117;
							continue;
						case 59:
							num = 51;
							continue;
						case 60:
							goto IL_97B;
						case 61:
							this.e1.Visible = true;
							this.e8.Visible = true;
							this.e8.Text = text;
							num = 43;
							continue;
						case 62:
							this.fk.Visible = true;
							this.fk.Text = text;
							num = 38;
							continue;
						case 63:
							goto IL_1368;
						case 64:
							goto IL_A3C;
						case 65:
							if ("Enabled" == empty)
							{
								num = 25;
								continue;
							}
							this.fj.Visible = false;
							num = 137;
							continue;
						case 66:
							if ("Enabled" == empty)
							{
								num = 62;
								continue;
							}
							this.fk.Visible = false;
							num = 37;
							continue;
						case 67:
							if ("Enabled" == empty)
							{
								num = 86;
								continue;
							}
							this.fz.Visible = false;
							num = 48;
							continue;
						case 68:
						{
							int num4;
							if (num4 >= arrayList2.Count)
							{
								num = 33;
								continue;
							}
							this.e9.Items.Add(arrayList2[num4]);
							num4++;
							num = 3;
							continue;
						}
						case 69:
							if ("Enabled" == empty)
							{
								num = 87;
								continue;
							}
							this.ft.Visible = false;
							num = 90;
							continue;
						case 70:
							goto IL_E61;
						case 71:
							if (arrayList.Count < 2)
							{
								num = 139;
								continue;
							}
							goto IL_1CA0;
						case 72:
							if ("Enabled" == empty)
							{
								num = 75;
								continue;
							}
							this.fy.Visible = false;
							this.eu.Visible = false;
							num = 60;
							continue;
						case 73:
							if ("Enabled" == empty)
							{
								num = 23;
								continue;
							}
							this.f9.Visible = false;
							num = 78;
							continue;
						case 74:
							goto IL_1841;
						case 75:
							this.eu.Visible = true;
							this.fy.Visible = true;
							this.fy.Text = text;
							num = 1;
							continue;
						case 76:
							if (operateDevice.b != null)
							{
								num = 102;
								continue;
							}
							num = 103;
							continue;
						case 77:
							goto IL_7E8;
						case 78:
							goto IL_39C;
						case 79:
							if ("Enabled" == empty)
							{
								num = 123;
								continue;
							}
							this.fu.Visible = false;
							num = 150;
							continue;
						case 80:
							if ("Enabled" == empty)
							{
								num = 88;
								continue;
							}
							this.e9.Visible = false;
							num = 104;
							continue;
						case 81:
							if (this.er)
							{
								num = 20;
								continue;
							}
							goto IL_3F4;
						case 82:
							goto IL_1368;
						case 83:
							goto IL_1926;
						case 84:
							text = text;
							num = 12;
							continue;
						case 85:
							goto IL_1052;
						case 86:
							num = 130;
							continue;
						case 87:
							this.fv.Visible = true;
							this.ft.Visible = true;
							this.ft.Text = text;
							num = 22;
							continue;
						case 88:
						{
							this.ey.Visible = true;
							this.e9.Visible = true;
							this.e9.Items.Clear();
							int num4 = 0;
							num = 143;
							continue;
						}
						case 89:
							goto IL_17B6;
						case 90:
							goto IL_EEF;
						case 91:
							goto IL_1276;
						case 92:
							goto IL_197E;
						case 93:
							if (this.ff.Items.Count > 1)
							{
								num = 15;
								continue;
							}
							this.ff.ScrollAlwaysVisible = false;
							num = 132;
							continue;
						case 94:
							num = 71;
							continue;
						case 95:
							goto IL_4AE;
						case 96:
							goto IL_E09;
						case 97:
							goto IL_1650;
						case 98:
							goto IL_1C2B;
						case 99:
							goto IL_1926;
						case 100:
							goto IL_D50;
						case 101:
							text = text;
							num = 119;
							continue;
						case 102:
							goto IL_93E;
						case 103:
							if (operateDevice.i != null)
							{
								num = 85;
								continue;
							}
							goto IL_18CB;
						case 104:
							goto IL_B1E;
						case 105:
						{
							this.ff.Visible = true;
							this.ff.Items.Clear();
							int num2 = 0;
							num = 97;
							continue;
						}
						case 106:
							if ("Enabled" == empty)
							{
								num = 134;
								continue;
							}
							this.fi.Visible = false;
							num = 77;
							continue;
						case 107:
							num = 93;
							continue;
						case 108:
							goto IL_75B;
						case 109:
							goto IL_6C8;
						case 110:
							goto IL_1276;
						case 111:
							if ("Enabled" == empty)
							{
								num = 57;
								continue;
							}
							this.e7.Visible = false;
							num = 127;
							continue;
						case 112:
							num = 76;
							continue;
						case 113:
							this.fm.Visible = true;
							this.fm.Text = this.u.GetString("LBL_RXBOARD");
							num = 11;
							continue;
						case 114:
							goto IL_3F4;
						case 115:
							goto IL_1C2B;
						case 116:
							this.fc.Visible = true;
							this.fc.Text = text;
							num = 17;
							continue;
						case 117:
							goto IL_A3C;
						case 118:
							if (arrayList.Count > 0)
							{
								num = 94;
								continue;
							}
							goto IL_1CA0;
						case 119:
							goto IL_BD0;
						case 120:
							goto IL_4AE;
						case 121:
							goto IL_7E8;
						case 122:
							goto IL_1B47;
						case 123:
							this.fu.Visible = true;
							this.fu.Text = text;
							num = 92;
							continue;
						case 124:
							if ("Enabled" == empty)
							{
								num = 41;
								continue;
							}
							this.e6.Visible = false;
							num = 146;
							continue;
						case 125:
							if ("Enabled" == empty)
							{
								num = 54;
								continue;
							}
							this.fb.Visible = false;
							num = 26;
							continue;
						case 126:
							this.fg.Visible = true;
							this.fg.Text = text;
							num = 89;
							continue;
						case 127:
							goto IL_625;
						case 128:
							if ("Enabled" == empty)
							{
								num = 45;
								continue;
							}
							this.fa.Visible = false;
							num = 2;
							continue;
						case 129:
							if ("Enabled" == empty)
							{
								num = 28;
								continue;
							}
							this.e5.Visible = false;
							num = 91;
							continue;
						case 130:
							if (!string.IsNullOrEmpty(text))
							{
								num = 84;
								continue;
							}
							goto IL_AD7;
						case 131:
							goto IL_1CC9;
						case 132:
							goto IL_1841;
						case 133:
							try
							{
								num = 3;
								for (;;)
								{
									switch (num)
									{
									case 0:
										if (num3 == -1)
										{
											num = 1;
											continue;
										}
										value = text.Substring(0, num3);
										arrayList2.Add(value);
										text = text.Substring(num3 + 1);
										num = 4;
										continue;
									case 1:
										arrayList2.Add(text);
										num = 7;
										continue;
									case 2:
										if (text.Length <= 0)
										{
											num = 6;
											continue;
										}
										num3 = text.IndexOf("\n");
										num = 0;
										continue;
									case 5:
										goto IL_1752;
									case 6:
										goto IL_1746;
									case 7:
										goto IL_1746;
									}
									IL_16F5:
									num = 2;
									continue;
									goto IL_16F5;
									IL_1746:
									num = 5;
								}
								IL_1752:
								goto IL_13EB;
							}
							catch (Exception)
							{
								CCustomException ex4 = CustomExceptionHandler.a(1698U, base.GetType().ToString(), "ReadDevice", Environment.StackTrace);
								throw ex4;
							}
							goto IL_177C;
							IL_13EB:
							num = 80;
							continue;
						case 134:
							this.fi.Visible = true;
							this.fi.Text = text;
							num = 121;
							continue;
						case 135:
							goto IL_625;
						case 136:
							if ("Enabled" == empty)
							{
								num = 59;
								continue;
							}
							this.f0.Visible = false;
							num = 5;
							continue;
						case 137:
							goto IL_5B0;
						case 138:
							this.fe.Visible = true;
							this.fe.Text = text;
							num = 115;
							continue;
						case 139:
							strIP = ((DeviceInfo)arrayList[0]).strIp;
							this.w.OpenConnection(strIP, ref this.ac, setProgressBar);
							cprogressBar = new CProgressBar(this.u, false, 100);
							setProgressBar = new CCPTags.SetProgressBar(cprogressBar.a);
							cprogressBar.a(0);
							cprogressBar.a("LBL_PROGREADING");
							operateDevice.d(ref this.ac, this.w, cprogressBar, setProgressBar, string.Empty);
							operateDevice.d(this, this.Mirrored, this.u);
							operateDevice.e(OperateDevice.Operatetype.a);
							Cursor.Current = Cursors.WaitCursor;
							Cursor.Show();
							cprogressBar.StartPosition = FormStartPosition.CenterParent;
							cprogressBar.ShowDialog();
							num = 140;
							continue;
						case 140:
							if (operateDevice.c)
							{
								num = 112;
								continue;
							}
							goto IL_18CB;
						case 141:
							this.es.Visible = true;
							this.e3.Visible = true;
							this.e3.Text = text;
							num = 64;
							continue;
						case 142:
							goto IL_85D;
						case 143:
							goto IL_13C0;
						case 144:
							this.fl.Visible = true;
							this.fl.Text = text;
							num = 120;
							continue;
						case 145:
							if ("Enabled" == empty)
							{
								num = 29;
								continue;
							}
							this.e4.Visible = false;
							num = 100;
							continue;
						case 146:
							goto IL_1561;
						case 147:
							goto IL_E09;
						case 148:
							goto IL_B1E;
						case 149:
							num = 36;
							continue;
						case 150:
							goto IL_197E;
						}
						break;
						IL_39C:
						this.eb = this.f9.Visible;
						text = this.a("LBL_SINGLEMODELTYPE", "0", "-1", ref empty);
						num = 55;
						continue;
						IL_3F4:
						this.Cursor = Cursors.Default;
						num = 149;
						continue;
						IL_410:
						this.d0 = this.fk.Visible;
						text = this.a("LBL_REGION", "0", "-1", ref empty);
						num = 129;
						continue;
						IL_4AE:
						this.dq = this.fl.Visible;
						text = this.a("LBL_DEVICESERIALNUM", "0", "-1", ref empty);
						num = 136;
						continue;
						IL_5B0:
						this.dy = this.fj.Visible;
						text = this.a("LBL_FWVER", "0", "-1", ref empty);
						num = 145;
						continue;
						IL_625:
						this.ej = this.e0.Visible;
						this.dv = this.e7.Visible;
						text = this.a("LBL_RXBOOTLOADER", "0", "-1", ref empty);
						num = 106;
						continue;
						IL_6C8:
						this.du = this.fz.Visible;
						text = this.a("LBL_BOOTLOADER", "0", "-1", ref empty);
						num = 111;
						continue;
						IL_75B:
						this.en = this.ev.Visible;
						this.d3 = this.fb.Visible;
						text = this.a("LBL_RXDEVICETANAPANUM", "0", "-1", ref empty);
						num = 21;
						continue;
						IL_7E8:
						this.dw = this.fi.Visible;
						text = this.a("LBL_PSDT", "0", "-1", ref empty);
						num = 7;
						continue;
						IL_85D:
						this.ek = this.e1.Visible;
						this.dx = this.e8.Visible;
						text = this.a("LBL_RXPSDT", "0", "-1", ref empty);
						num = 65;
						continue;
						IL_97B:
						this.ei = this.eu.Visible;
						this.dt = this.fy.Visible;
						text = this.a("LBL_RXDEVICESERIALNUM", "0", "-1", ref empty);
						num = 67;
						continue;
						IL_A3C:
						this.ef = this.es.Visible;
						this.dn = this.e3.Visible;
						text = this.a("LBL_RXMODELNUM", "0", "-1", ref empty);
						num = 6;
						continue;
						IL_AD7:
						this.fz.Visible = true;
						this.fz.Text = text;
						num = 109;
						continue;
						IL_B1E:
						this.eq = this.ey.Visible;
						this.d9 = this.e9.Visible;
						text = this.a("LBL_RXFREQUENCYRANGE", "0", "-1", ref empty);
						arrayList2.Clear();
						value = string.Empty;
						num3 = 0;
						num = 47;
						continue;
						IL_BD0:
						this.et.Visible = true;
						this.f0.Visible = true;
						this.f0.Text = text;
						num = 131;
						continue;
						IL_C83:
						this.eg = this.ex.Visible;
						this.dp = this.fa.Visible;
						text = this.a("LBL_RXCPVER", "0", "-1", ref empty);
						num = 27;
						continue;
						IL_D50:
						this.el = this.ew.Visible;
						this.dz = this.e4.Visible;
						text = this.a("LBL_RXFWVER", "0", "-1", ref empty);
						num = 66;
						continue;
						IL_E09:
						this.ed = this.fn.Visible;
						text = this.a("LBL_RXBOARD", "0", "-1", ref empty);
						num = 8;
						continue;
						IL_E61:
						this.d2 = this.fh.Visible;
						text = this.a("LBL_DEVICETANAPANUM", "0", "-1", ref empty);
						num = 125;
						continue;
						IL_EEF:
						this.ep = this.fv.Visible;
						this.d7 = this.ft.Visible;
						text = this.a("LBL_RXLASTPROGRAMMEDDATETIME", "0", "-1", ref empty);
						num = 79;
						continue;
						IL_1276:
						this.em = this.ez.Visible;
						this.d1 = this.e5.Visible;
						text = this.a("LBL_RXREGION", "0", "-1", ref empty);
						num = 49;
						continue;
						IL_1368:
						this.ec = this.ae.Visible;
						text = this.a("LBL_TXBOARD", "0", "-1", ref empty);
						num = 4;
						continue;
						IL_13C0:
						num = 68;
						continue;
						IL_1561:
						this.eo = this.e2.Visible;
						this.d5 = this.e6.Visible;
						text = this.a("LBL_RXLASTPROGRAMMEDSOURCE", "0", "-1", ref empty);
						num = 42;
						continue;
						IL_1650:
						num = 10;
						continue;
						IL_177C:
						this.fm.Visible = false;
						num = 35;
						continue;
						IL_17B6:
						this.d6 = this.fg.Visible;
						text = this.a("LBL_LASTPROGRAMMEDDATETIME", "0", "-1", ref empty);
						num = 69;
						continue;
						IL_1841:
						this.ea = this.ff.Visible;
						text = this.a("LBL_MODELTYPE", "0", "-1", ref empty);
						num = 73;
						continue;
						IL_18CB:
						cprogressBar.Close();
						setProgressBar = null;
						cprogressBar = null;
						empty = string.Empty;
						text = this.a("LBL_MODELNUM", "0", "-1", ref empty);
						num = 58;
						continue;
						IL_1926:
						this.ds = this.fd.Visible;
						text = this.a("LBL_TXBRICKSERIALNUM", "0", "-1", ref empty);
						num = 72;
						continue;
						IL_197E:
						this.d8 = this.fu.Visible;
						text = this.a("LBL_FREQUENCYRANGE", "0", "-1", ref empty);
						arrayList2 = new ArrayList();
						value = string.Empty;
						num3 = 0;
						num = 133;
						continue;
						IL_1B47:
						this.@do = this.fc.Visible;
						text = this.a("LBL_CPVER", "0", "-1", ref empty);
						num = 128;
						continue;
						IL_1BD4:
						this.ee = this.fm.Visible;
						this.w.CloseConnection(this.ac);
						this.a(0);
						this.e();
						num = 81;
						continue;
						IL_1C2B:
						this.d4 = this.fe.Visible;
						text = this.a("LBL_LASTPROGRAMMEDSOURCE", "0", "-1", ref empty);
						num = 124;
						continue;
						IL_1CA0:
						num = 31;
						continue;
						IL_1CC9:
						this.eh = this.et.Visible;
						this.dr = this.f0.Visible;
						text = this.a("LBL_RXBRICKSERIALNUM", "0", "-1", ref empty);
						num = 44;
					}
				}
				IL_93E:
				throw operateDevice.b;
				IL_1052:
				throw operateDevice.i;
				IL_1AA9:
				CCustomException ex5 = CustomExceptionHandler.a(1687U, base.GetType().ToString(), "ReadDevice", Environment.StackTrace);
				throw ex5;
				IL_1CC4:
				CCustomException ex6 = CustomExceptionHandler.a(3841U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex6;
				IL_1D3E:;
			}
			catch (CCustomException ex7)
			{
				cprogressBar = null;
				setProgressBar = null;
				this.Cursor = Cursors.Default;
				if (this.er)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D75;
					default:
					{
						if (false)
						{
						}
						CPlaySound cplaySound2 = new CPlaySound(this.Mirrored, this.t, this.u);
						cplaySound2.b(CPlaySound.SoundType.b);
						break;
					}
					}
				}
				if (this.w == null || this.ac <= 0U)
				{
					goto IL_1DC7;
				}
				IL_1D75:
				this.w.CloseConnection(this.ac);
				IL_1DC7:
				this.a(0);
				this.e();
				throw ex7;
			}
			catch (Exception ex8)
			{
				cprogressBar.Close();
				cprogressBar = null;
				setProgressBar = null;
				this.Cursor = Cursors.Default;
				if (this.er)
				{
					CPlaySound cplaySound3 = new CPlaySound(this.Mirrored, this.t, this.u);
					cplaySound3.b(CPlaySound.SoundType.b);
				}
				if (this.w != null && this.ac > 0U)
				{
					this.w.CloseConnection(this.ac);
				}
				this.a(0);
				this.e();
				if (CCustomException.CheckErrorIDExsists(ex8))
				{
					if (true)
					{
					}
					CCustomException.Rethrow(ex8);
				}
				else
				{
					ex8.Source = 1698U.ToString() + "| " + ex8.Source;
					CCustomException.Rethrow(ex8);
				}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000109B0 File Offset: 0x0000F9B0
		private void ak(object A_0, EventArgs A_1)
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
			this.at(A_0, A_1);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000109F4 File Offset: 0x0000F9F4
		private void aj(object A_0, EventArgs A_1)
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
			this.@as(A_0, A_1);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00010A38 File Offset: 0x0000FA38
		private void ai(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.ak, this.c6, this.ca);
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
						if (false)
						{
						}
						ex2.Source = 3153U.ToString() + "| " + ex2.Source;
						CCustomException.Rethrow(ex2);
						goto IL_77;
					}
				}
				CCustomException.Rethrow(ex2);
				IL_77:;
			}
			if (true)
			{
			}
			this.l();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00010AF4 File Offset: 0x0000FAF4
		private void ah(object A_0, EventArgs A_1)
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
			this.ag.SetToolTip(this.ak, this.u.GetString("BTN_DT_RELOAD_HELP"));
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00010B50 File Offset: 0x0000FB50
		private void ag(object A_0, EventArgs A_1)
		{
			try
			{
				switch (0)
				{
				default:
					this.a(this.aj, this.c2, this.b5);
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
					CCustomException.Rethrow(ex2);
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
			for (;;)
			{
				ArrayList arrayList = new ArrayList();
				OperateDevice operateDevice = new OperateDevice();
				string strIP = string.Empty;
				CProgressBar cprogressBar = null;
				ArrayList arrayList2 = null;
				string value = string.Empty;
				CCPTags.SetProgressBar setProgressBar = null;
				try
				{
					for (;;)
					{
						this.w.ListConnectedDevices(out arrayList);
						int num = 24;
						for (;;)
						{
							CMsgDialog cmsgDialog;
							switch (num)
							{
							case 0:
								goto IL_4E1;
							case 1:
								goto IL_1CE;
							case 2:
								if (operateDevice.i != null)
								{
									num = 3;
									continue;
								}
								goto IL_473;
							case 3:
								goto IL_578;
							case 4:
								goto IL_249;
							case 5:
								num = 0;
								continue;
							case 6:
								if (operateDevice.b != null)
								{
									num = 18;
									continue;
								}
								num = 2;
								continue;
							case 7:
								num = 6;
								continue;
							case 8:
								if (!cprogressBar.IsDisposed)
								{
									num = 17;
									continue;
								}
								goto IL_1CE;
							case 9:
								num = 22;
								continue;
							case 10:
								MessageBox.Show(this.u.GetString("UNKILLFORM_FAILED"), "DepotTool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								num = 4;
								continue;
							case 11:
								num = 13;
								continue;
							case 12:
								goto IL_4D0;
							case 13:
								goto IL_600;
							case 14:
								if (operateDevice.c)
								{
									num = 7;
									continue;
								}
								goto IL_473;
							case 15:
								goto IL_5A0;
							case 16:
							{
								CPlaySound cplaySound = new CPlaySound(this.Mirrored, this.t, this.u);
								cplaySound.b(CPlaySound.SoundType.a);
								num = 26;
								continue;
							}
							case 17:
								cprogressBar.ShowDialog();
								num = 1;
								continue;
							case 18:
								goto IL_46A;
							case 19:
								if (arrayList.Count > 1)
								{
									num = 23;
									continue;
								}
								goto IL_1AA;
							case 20:
								if (this.er)
								{
									num = 16;
									continue;
								}
								goto IL_3EC;
							case 21:
								arrayList2 = new ArrayList();
								num = 28;
								continue;
							case 22:
								if (arrayList.Count < 2)
								{
									num = 21;
									continue;
								}
								goto IL_184;
							case 23:
								goto IL_1A5;
							case 24:
								if (arrayList.Count > 0)
								{
									num = 9;
									continue;
								}
								goto IL_184;
							case 25:
								if (!this.aw.l)
								{
									num = 5;
									continue;
								}
								arrayList2.Add(this.aw.b());
								this.a(2);
								this.f();
								operateDevice.d(ref this.ac, this.w, cprogressBar, setProgressBar, string.Empty);
								this.Refresh();
								Cursor.Current = Cursors.WaitCursor;
								Cursor.Show();
								operateDevice.d(arrayList2);
								operateDevice.d(false);
								operateDevice.d(this, this.Mirrored, this.u);
								operateDevice.e(OperateDevice.Operatetype.b);
								Cursor.Current = Cursors.WaitCursor;
								Cursor.Show();
								cprogressBar.StartPosition = FormStartPosition.CenterParent;
								num = 8;
								continue;
							case 26:
								goto IL_3EC;
							case 27:
								if (this.aw == null)
								{
									num = 10;
									continue;
								}
								this.aw.ShowDialog();
								num = 25;
								continue;
							case 28:
								if (arrayList2 == null)
								{
									num = 15;
									continue;
								}
								value = this.aj.Name;
								arrayList2.Add(value);
								strIP = ((DeviceInfo)arrayList[0]).strIp;
								this.w.OpenConnection(strIP, ref this.ac, setProgressBar);
								this.w.ReadDevice(ref this.ac, "QueryChangeValueForUnkill", arrayList2);
								cprogressBar = new CProgressBar(this.u, false, 100);
								setProgressBar = new CCPTags.SetProgressBar(cprogressBar.a);
								cprogressBar.a(0);
								cprogressBar.a(this.u.GetString("UNKILL_RADIO"));
								this.aw = new a("EN-US", this.x, this.u, this.w, this.t);
								num = 27;
								continue;
							case 29:
								if (cmsgDialog == null)
								{
									num = 12;
									continue;
								}
								num = 20;
								continue;
							}
							break;
							IL_184:
							num = 19;
							continue;
							IL_1CE:
							num = 14;
							continue;
							IL_3EC:
							cmsgDialog.Show(this, false, DialogResult.OK, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							this.e();
							this.d();
							this.Cursor = Cursors.Default;
							num = 11;
							continue;
							IL_473:
							cprogressBar.Close();
							setProgressBar = null;
							cprogressBar = null;
							this.w.CloseConnection(this.ac);
							this.a(0);
							cmsgDialog = new CMsgDialog(true, this.u, 4611, "DT_APP_NAME", null);
							num = 29;
						}
					}
					IL_1A5:
					CCustomException ex3 = CustomExceptionHandler.a(3841U, base.GetType().ToString(), "Unkill_Click", Environment.StackTrace);
					throw ex3;
					IL_1AA:
					CCustomException ex4 = CustomExceptionHandler.a(1687U, base.GetType().ToString(), "Unkill_Click", Environment.StackTrace);
					throw ex4;
					IL_249:
					goto IL_73F;
					IL_46A:
					throw operateDevice.b;
					IL_4D0:
					CCustomException ex5 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "Unkill_Click", Environment.StackTrace);
					throw ex5;
					IL_4E1:
					goto IL_73F;
					IL_578:
					throw operateDevice.i;
					IL_5A0:
					CCustomException ex6 = CustomExceptionHandler.a(1622U, base.GetType().ToString(), "Unkill_Click", Environment.StackTrace);
					throw ex6;
					IL_600:;
				}
				catch (CCustomException ex7)
				{
					this.Cursor = Cursors.Default;
					if (this.er)
					{
						CPlaySound cplaySound2 = new CPlaySound(this.Mirrored, this.t, this.u);
						cplaySound2.b(CPlaySound.SoundType.b);
					}
					if (true)
					{
					}
					if (this.w != null && this.ac > 0U)
					{
						this.w.CloseConnection(this.ac);
					}
					this.a(0);
					this.e();
					throw ex7;
				}
				catch (Exception ex8)
				{
					this.Cursor = Cursors.Default;
					if (this.er)
					{
						CPlaySound cplaySound3 = new CPlaySound(this.Mirrored, this.t, this.u);
						cplaySound3.b(CPlaySound.SoundType.b);
					}
					if (this.w != null && this.ac > 0U)
					{
						this.w.CloseConnection(this.ac);
					}
					this.a(0);
					this.e();
					if (CCustomException.CheckErrorIDExsists(ex8))
					{
						CCustomException.Rethrow(ex8);
					}
					else
					{
						ex8.Source = 2318U.ToString() + "| " + ex8.Source;
						CCustomException.Rethrow(ex8);
					}
				}
				IL_73F:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_755;
				}
			}
			IL_755:
			if (false)
			{
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00011328 File Offset: 0x00010328
		private void af(object A_0, EventArgs A_1)
		{
			try
			{
				switch (0)
				{
				default:
					if (true)
					{
					}
					this.a(this.fq, this.cs, this.b8);
					this.fq.Text = this.u.GetString("BTN_DT_BLANK");
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
					CCustomException.Rethrow(ex2);
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
			ArrayList arrayList = new ArrayList();
			OperateDevice operateDevice = new OperateDevice();
			string strIP = string.Empty;
			CProgressBar cprogressBar = null;
			ArrayList arrayList2 = null;
			string value = string.Empty;
			CCPTags.SetProgressBar setProgressBar = null;
			value = this.fq.Name;
			try
			{
				for (;;)
				{
					CMsgDialog cmsgDialog = new CMsgDialog(true, this.u, 4609, "DT_APP_NAME", null);
					int num = 3;
					for (;;)
					{
						CMsgDialog cmsgDialog2;
						switch (num)
						{
						case 0:
							goto IL_1B1;
						case 1:
							goto IL_1AC;
						case 2:
							goto IL_52A;
						case 3:
						{
							if (cmsgDialog == null)
							{
								num = 5;
								continue;
							}
							DialogResult dialogResult = DialogResult.Yes;
							dialogResult = cmsgDialog.Show(this, false, dialogResult, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							num = 18;
							continue;
						}
						case 4:
							goto IL_3FE;
						case 5:
							goto IL_181;
						case 6:
							this.Refresh();
							Cursor.Current = Cursors.WaitCursor;
							Cursor.Show();
							this.a(2);
							this.f();
							this.w.ListConnectedDevices(out arrayList);
							num = 7;
							continue;
						case 7:
							if (arrayList.Count > 0)
							{
								num = 17;
								continue;
							}
							goto IL_347;
						case 8:
							if (arrayList.Count < 2)
							{
								num = 29;
								continue;
							}
							goto IL_347;
						case 9:
							num = 24;
							continue;
						case 10:
							cprogressBar.ShowDialog();
							num = 2;
							continue;
						case 11:
							if (arrayList.Count > 1)
							{
								num = 14;
								continue;
							}
							goto IL_1E7;
						case 12:
						{
							CPlaySound cplaySound = new CPlaySound(this.Mirrored, this.t, this.u);
							cplaySound.b(CPlaySound.SoundType.a);
							num = 0;
							continue;
						}
						case 13:
							if (operateDevice.c)
							{
								num = 9;
								continue;
							}
							goto IL_5EC;
						case 14:
							goto IL_36B;
						case 15:
							if (!cprogressBar.IsDisposed)
							{
								num = 10;
								continue;
							}
							goto IL_52A;
						case 16:
							goto IL_649;
						case 17:
							goto IL_4B5;
						case 18:
						{
							DialogResult dialogResult;
							if (DialogResult.Yes == dialogResult)
							{
								num = 6;
								continue;
							}
							goto IL_6CA;
						}
						case 19:
							goto IL_6CA;
						case 20:
							goto IL_6D6;
						case 21:
							if (arrayList2 == null)
							{
								num = 30;
								continue;
							}
							arrayList2 = new ArrayList();
							num = 25;
							continue;
						case 22:
							goto IL_5B8;
						case 23:
							if (operateDevice.i != null)
							{
								num = 4;
								continue;
							}
							goto IL_5EC;
						case 24:
							if (operateDevice.b != null)
							{
								num = 22;
								continue;
							}
							num = 23;
							continue;
						case 25:
							if (arrayList2 == null)
							{
								num = 1;
								continue;
							}
							arrayList2.Add(value);
							operateDevice.d(arrayList2);
							operateDevice.d(false);
							operateDevice.d(this, this.Mirrored, this.u);
							operateDevice.e(OperateDevice.Operatetype.b);
							Cursor.Current = Cursors.WaitCursor;
							Cursor.Show();
							num = 27;
							continue;
						case 26:
							if (this.er)
							{
								num = 12;
								continue;
							}
							goto IL_1B1;
						case 27:
							try
							{
								this.a(this.fq, (Bitmap)this.v.GetObject("BLANK_NOM"), this.b8);
								this.fq.Text = this.u.GetString("BTN_DT_BLANK");
								goto IL_394;
							}
							catch (CCustomException ex3)
							{
								throw ex3;
							}
							catch (Exception ex4)
							{
								if (CCustomException.CheckErrorIDExsists(ex4))
								{
									CCustomException.Rethrow(ex4);
								}
								else
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
										ex4.Source = 3153U.ToString() + "| " + ex4.Source;
										CCustomException.Rethrow(ex4);
										break;
									}
								}
								goto IL_394;
							}
							goto IL_4B5;
							IL_394:
							cprogressBar.StartPosition = FormStartPosition.CenterParent;
							num = 15;
							continue;
						case 28:
							if (cmsgDialog2 == null)
							{
								num = 16;
								continue;
							}
							num = 26;
							continue;
						case 29:
							strIP = ((DeviceInfo)arrayList[0]).strIp;
							this.w.OpenConnection(strIP, ref this.ac, setProgressBar);
							cprogressBar = new CProgressBar(this.u, false, 100);
							setProgressBar = new CCPTags.SetProgressBar(cprogressBar.a);
							cprogressBar.a(0);
							cprogressBar.a("LBL_PROGBLANKING");
							operateDevice.d(ref this.ac, this.w, cprogressBar, setProgressBar, string.Empty);
							arrayList2 = new ArrayList();
							num = 21;
							continue;
						case 30:
							goto IL_2EF;
						}
						break;
						IL_1B1:
						cmsgDialog2.Show(this, false, DialogResult.OK, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						this.e();
						this.d();
						this.Cursor = Cursors.Default;
						num = 19;
						continue;
						IL_347:
						num = 11;
						continue;
						IL_4B5:
						num = 8;
						continue;
						IL_52A:
						num = 13;
						continue;
						IL_5EC:
						cprogressBar.Close();
						setProgressBar = null;
						cprogressBar = null;
						this.w.CloseConnection(this.ac);
						this.a(0);
						cmsgDialog2 = new CMsgDialog(true, this.u, 4610, "DT_APP_NAME", null);
						num = 28;
						continue;
						IL_6CA:
						num = 20;
					}
				}
				IL_181:
				CCustomException ex5 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "WriteDevice", Environment.StackTrace);
				throw ex5;
				IL_1AC:
				CCustomException ex6 = CustomExceptionHandler.a(1622U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex6;
				IL_1E7:
				CCustomException ex7 = CustomExceptionHandler.a(1687U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex7;
				IL_2EF:
				CCustomException ex8 = CustomExceptionHandler.a(1622U, base.GetType().ToString(), "BlankDevice", Environment.StackTrace);
				throw ex8;
				IL_36B:
				CCustomException ex9 = CustomExceptionHandler.a(3841U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex9;
				IL_3FE:
				throw operateDevice.i;
				IL_5B8:
				throw operateDevice.b;
				IL_649:
				CCustomException ex10 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "BlankDevice", Environment.StackTrace);
				throw ex10;
				IL_6D6:;
			}
			catch (CCustomException ex11)
			{
				cprogressBar = null;
				setProgressBar = null;
				this.Cursor = Cursors.Default;
				if (this.er)
				{
					CPlaySound cplaySound2 = new CPlaySound(this.Mirrored, this.t, this.u);
					cplaySound2.b(CPlaySound.SoundType.b);
				}
				if (this.w != null && this.ac > 0U)
				{
					this.w.CloseConnection(this.ac);
				}
				this.a(0);
				this.e();
				throw ex11;
			}
			catch (Exception ex12)
			{
				cprogressBar = null;
				setProgressBar = null;
				this.Cursor = Cursors.Default;
				if (this.er)
				{
					CPlaySound cplaySound3 = new CPlaySound(this.Mirrored, this.t, this.u);
					cplaySound3.b(CPlaySound.SoundType.b);
				}
				if (this.w != null && this.ac > 0U)
				{
					this.w.CloseConnection(this.ac);
				}
				this.a(0);
				this.e();
				if (CCustomException.CheckErrorIDExsists(ex12))
				{
					CCustomException.Rethrow(ex12);
				}
				else
				{
					ex12.Source = 2318U.ToString() + "| " + ex12.Source;
					CCustomException.Rethrow(ex12);
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00011BE4 File Offset: 0x00010BE4
		private void ae(object A_0, EventArgs A_1)
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
			this.ar(A_0, A_1);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00011C28 File Offset: 0x00010C28
		private void ad(object A_0, EventArgs A_1)
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
			this.aq(A_0, A_1);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00011C6C File Offset: 0x00010C6C
		private void b(object A_0, MouseEventArgs A_1)
		{
			try
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_75;
					case 1:
						this.a(this.am, this.c4, this.cb);
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							if (false)
							{
							}
							num = 0;
							continue;
						}
						break;
					case 3:
						goto IL_7D;
					}
					if (A_1.Button == MouseButtons.Left)
					{
						num = 1;
						continue;
					}
					IL_75:
					num = 3;
				}
				IL_7D:;
			}
			catch (Exception ex)
			{
				if (CCustomException.CheckErrorIDExsists(ex))
				{
					if (true)
					{
					}
					CCustomException.Rethrow(ex);
				}
				else
				{
					ex.Source = 3153U.ToString() + "| " + ex.Source;
					CCustomException.Rethrow(ex);
				}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00011D5C File Offset: 0x00010D5C
		private void ac(object A_0, EventArgs A_1)
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
			this.fa.Focus();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00011DA4 File Offset: 0x00010DA4
		private void z(object A_0, EventArgs A_1)
		{
			try
			{
				switch (0)
				{
				default:
					this.a(this.fp, this.co, this.ay);
					this.fp.Text = this.u.GetString("BTN_DT_WRITE");
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
					CCustomException.Rethrow(ex2);
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
			ArrayList arrayList = new ArrayList();
			OperateDevice operateDevice = new OperateDevice();
			string strIP = string.Empty;
			string value = string.Empty;
			string a_ = string.Empty;
			CProgressBar cprogressBar = null;
			ArrayList arrayList2 = null;
			CCPTags.SetProgressBar setProgressBar = null;
			value = this.fp.Name;
			try
			{
				for (;;)
				{
					this.w.ListConnectedDevices(out arrayList);
					int num = 4;
					for (;;)
					{
						CMsgDialog cmsgDialog;
						switch (num)
						{
						case 0:
							if (cmsgDialog == null)
							{
								num = 19;
								continue;
							}
							num = 16;
							continue;
						case 1:
							if (operateDevice.c)
							{
								num = 17;
								continue;
							}
							goto IL_30B;
						case 2:
							goto IL_4CC;
						case 3:
							goto IL_235;
						case 4:
							if (arrayList.Count > 0)
							{
								num = 14;
								continue;
							}
							goto IL_2B0;
						case 5:
							if (arrayList2 == null)
							{
								num = 8;
								continue;
							}
							arrayList2.Add(value);
							operateDevice.d(arrayList2);
							operateDevice.d(false);
							operateDevice.d(this, this.Mirrored, this.u);
							operateDevice.e(OperateDevice.Operatetype.b);
							Cursor.Current = Cursors.WaitCursor;
							Cursor.Show();
							cprogressBar.StartPosition = FormStartPosition.CenterParent;
							cprogressBar.ShowDialog();
							num = 1;
							continue;
						case 6:
							if (arrayList.Count > 1)
							{
								num = 18;
								continue;
							}
							goto IL_1EE;
						case 7:
							if (operateDevice.i != null)
							{
								num = 3;
								continue;
							}
							goto IL_30B;
						case 8:
							goto IL_464;
						case 9:
							if (arrayList.Count < 2)
							{
								num = 11;
								continue;
							}
							goto IL_2B0;
						case 10:
							num = 2;
							continue;
						case 11:
							strIP = ((DeviceInfo)arrayList[0]).strIp;
							this.w.OpenConnection(strIP, ref this.ac, setProgressBar);
							a_ = this.fw.Text;
							this.a("LBL_DEVICESERIALNUM", string.Empty, string.Empty, a_, string.Empty);
							cprogressBar = new CProgressBar(this.u, false, 100);
							setProgressBar = new CCPTags.SetProgressBar(cprogressBar.a);
							cprogressBar.a(0);
							cprogressBar.a("LBL_PROGWRITING");
							this.f();
							operateDevice.d(ref this.ac, this.w, cprogressBar, setProgressBar, string.Empty);
							arrayList2 = new ArrayList();
							num = 5;
							continue;
						case 12:
							if (operateDevice.b != null)
							{
								num = 20;
								continue;
							}
							num = 7;
							continue;
						case 13:
							goto IL_48D;
						case 14:
							num = 9;
							continue;
						case 15:
						{
							CPlaySound cplaySound = new CPlaySound(this.Mirrored, this.t, this.u);
							cplaySound.b(CPlaySound.SoundType.a);
							num = 13;
							continue;
						}
						case 16:
							if (this.er)
							{
								num = 15;
								continue;
							}
							goto IL_48D;
						case 17:
							num = 12;
							continue;
						case 18:
							goto IL_2D4;
						case 19:
							goto IL_365;
						case 20:
							goto IL_283;
						}
						break;
						IL_2B0:
						num = 6;
						continue;
						IL_30B:
						cprogressBar.Close();
						setProgressBar = null;
						cprogressBar = null;
						this.w.CloseConnection(this.ac);
						this.a(0);
						cmsgDialog = new CMsgDialog(true, this.u, 1670, "DT_APP_NAME", null);
						num = 0;
						continue;
						IL_48D:
						cmsgDialog.Show(this, false, DialogResult.OK, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						this.e();
						this.d();
						this.Cursor = Cursors.Default;
						num = 10;
					}
				}
				IL_1EE:
				CCustomException ex3 = CustomExceptionHandler.a(1687U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex3;
				IL_235:
				throw operateDevice.i;
				IL_283:
				throw operateDevice.b;
				IL_2D4:
				CCustomException ex4 = CustomExceptionHandler.a(3841U, base.GetType().ToString(), "FlashDevice", Environment.StackTrace);
				throw ex4;
				IL_365:
				CCustomException ex5 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "WriteDevice", Environment.StackTrace);
				throw ex5;
				IL_464:
				CCustomException ex6 = CustomExceptionHandler.a(1622U, base.GetType().ToString(), "WriteDevice", Environment.StackTrace);
				throw ex6;
				IL_4CC:;
			}
			catch (CCustomException ex7)
			{
				this.Cursor = Cursors.Default;
				if (this.er)
				{
					CPlaySound cplaySound2 = new CPlaySound(this.Mirrored, this.t, this.u);
					cplaySound2.b(CPlaySound.SoundType.b);
				}
				if (this.w != null)
				{
					while (this.ac > 0U)
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
							this.w.CloseConnection(this.ac);
							goto IL_555;
						}
					}
				}
				IL_555:
				this.a(0);
				this.e();
				throw ex7;
			}
			catch (Exception ex8)
			{
				this.Cursor = Cursors.Default;
				if (this.er)
				{
					CPlaySound cplaySound3 = new CPlaySound(this.Mirrored, this.t, this.u);
					cplaySound3.b(CPlaySound.SoundType.b);
				}
				if (this.w != null && this.ac > 0U)
				{
					if (true)
					{
					}
					this.w.CloseConnection(this.ac);
				}
				this.a(0);
				this.e();
				if (CCustomException.CheckErrorIDExsists(ex8))
				{
					CCustomException.Rethrow(ex8);
				}
				else
				{
					ex8.Source = 2318U.ToString() + "| " + ex8.Source;
					CCustomException.Rethrow(ex8);
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0001244C File Offset: 0x0001144C
		public void a(string A_0, string A_1, string A_2, string A_3, string A_4)
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
				string text = this.a(A_0, A_1, A_2, A_3, A_4, "Enabled");
				if (text != null)
				{
					try
					{
						this.w.ModifyItem(this.ac, ref text);
						return;
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
							ex2.Source = 1719U.ToString() + "| " + ex2.Source;
							CCustomException.Rethrow(ex2);
						}
						return;
					}
					break;
				}
				break;
			}
			}
			CCustomException ex3 = CustomExceptionHandler.a(1620U, base.GetType().ToString(), "ModifyItem", Environment.StackTrace);
			throw ex3;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00012538 File Offset: 0x00011538
		private string a(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5)
		{
			switch (0)
			{
			default:
			{
				string result = null;
				try
				{
					for (;;)
					{
						XmlDocument xmlDocument = new XmlDocument();
						int num = 2;
						for (;;)
						{
							XmlNode xmlNode;
							switch (num)
							{
							case 0:
								((XmlElement)xmlNode).SetAttribute("ListLetID", string.Empty, A_2);
								num = 4;
								continue;
							case 1:
								goto IL_AA;
							case 2:
								if (xmlDocument != null)
								{
									XmlNode newChild = xmlDocument.CreateElement("element", "UPDATES", string.Empty);
									xmlDocument.AppendChild(newChild);
									xmlNode = xmlDocument.CreateElement("element", A_0, string.Empty);
									((XmlElement)xmlNode).SetAttribute("Applicable", string.Empty, A_5);
									((XmlElement)xmlNode).SetAttribute("ListID", string.Empty, A_1);
									num = 3;
									continue;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_AA;
								default:
									if (false)
									{
									}
									num = 7;
									continue;
								}
								break;
							case 3:
								if (!A_2.Equals("-1"))
								{
									num = 0;
									continue;
								}
								goto IL_D1;
							case 4:
								goto IL_D1;
							case 5:
								if (!A_4.Equals(string.Empty))
								{
									num = 8;
									continue;
								}
								goto IL_1B1;
							case 6:
								goto IL_1DB;
							case 7:
								goto IL_83;
							case 8:
								((XmlElement)xmlNode).SetAttribute("TypeID", string.Empty, A_4);
								num = 1;
								continue;
							}
							break;
							IL_D1:
							num = 5;
							continue;
							IL_1B1:
							xmlNode.InnerText = A_3;
							xmlDocument.DocumentElement.AppendChild(xmlNode);
							result = xmlDocument.OuterXml;
							num = 6;
							continue;
							IL_AA:
							goto IL_1B1;
						}
					}
					IL_83:
					CCustomException ex = CustomExceptionHandler.a(1626U, base.GetType().ToString(), "FormatToXml", Environment.StackTrace);
					throw ex;
					IL_1DB:;
				}
				catch (CCustomException ex2)
				{
					throw ex2;
				}
				catch (Exception ex3)
				{
					ex3.Source = 1620U.ToString() + "| " + ex3.Source;
					CCustomException.Rethrow(ex3);
				}
				if (true)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00012798 File Offset: 0x00011798
		private void y(object A_0, EventArgs A_1)
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
			this.w(A_0, A_1);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000127DC File Offset: 0x000117DC
		private void x(object A_0, EventArgs A_1)
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
			this.v(A_0, A_1);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00012820 File Offset: 0x00011820
		private void w(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.fp, this.cp, this.ay);
				this.fp.Text = this.u.GetString("BTN_DT_WRITE");
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				if (CCustomException.CheckErrorIDExsists(ex2))
				{
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_59;
						}
					}
					IL_59:
					if (false)
					{
					}
					CCustomException.Rethrow(ex2);
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
			if (true)
			{
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000128F0 File Offset: 0x000118F0
		private void v(object A_0, EventArgs A_1)
		{
			try
			{
				if (true)
				{
				}
				this.a(this.fp, this.cn, this.ay);
				this.fp.Text = this.u.GetString("BTN_DT_WRITE");
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				if (CCustomException.CheckErrorIDExsists(ex2))
				{
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_61;
						}
					}
					IL_61:
					if (false)
					{
					}
					CCustomException.Rethrow(ex2);
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000129C0 File Offset: 0x000119C0
		private void a(object A_0, MouseEventArgs A_1)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					base.WindowState = FormWindowState.Minimized;
					num = 2;
					continue;
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_62;
					}
					break;
				}
				IL_26:
				if (A_1.Button == MouseButtons.Left)
				{
					num = 0;
					continue;
				}
				goto IL_6A;
				goto IL_26;
			}
			IL_62:
			if (false)
			{
			}
			IL_6A:
			if (true)
			{
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00012A40 File Offset: 0x00011A40
		private void u(object A_0, EventArgs A_1)
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
			this.ag.SetToolTip(this.am, this.u.GetString("BTN_DT_MIN_HELP"));
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00012A9C File Offset: 0x00011A9C
		private void t(object A_0, EventArgs A_1)
		{
			try
			{
				if (true)
				{
				}
				this.a(this.an, this.c0, this.b6);
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				if (!CCustomException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
					goto IL_63;
				}
				IL_2E:
				CCustomException.Rethrow(ex2);
				IL_63:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2E;
				default:
					if (false)
					{
					}
					break;
				}
			}
			this.h();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00012B58 File Offset: 0x00011B58
		private void s(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.an, this.cz, this.b6);
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				if (!CCustomException.CheckErrorIDExsists(ex2))
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
						if (false)
						{
						}
						ex2.Source = 3153U.ToString() + "| " + ex2.Source;
						CCustomException.Rethrow(ex2);
						goto IL_7F;
					}
				}
				CCustomException.Rethrow(ex2);
				IL_7F:;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00012C0C File Offset: 0x00011C0C
		private void r(object A_0, EventArgs A_1)
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
			this.ag.SetToolTip(this.an, this.u.GetString("BTN_DT_EXIT_HELP"));
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00012C68 File Offset: 0x00011C68
		private void q(object A_0, EventArgs A_1)
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
			this.ag.SetToolTip(this.aj, this.u.GetString("BTN_DT_UNKILL_HELP"));
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00012CC4 File Offset: 0x00011CC4
		private void p(object A_0, EventArgs A_1)
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
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00012D00 File Offset: 0x00011D00
		private void o(object A_0, EventArgs A_1)
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
			this.s(A_0, A_1);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00012D44 File Offset: 0x00011D44
		protected virtual bool a(ref Message A_0, Keys A_1)
		{
			int num = 33;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_485;
				case 1:
					goto IL_4A3;
				case 2:
					goto IL_485;
				case 3:
					if (A_1 != (Keys)131159)
					{
						num = 7;
						continue;
					}
					num = 18;
					continue;
				case 4:
					if (this.g() == 0)
					{
						num = 1;
						continue;
					}
					return true;
				case 5:
					if (A_1 <= (Keys)131142)
					{
						num = 19;
						continue;
					}
					num = 29;
					continue;
				case 6:
					num = 37;
					continue;
				case 7:
					num = 2;
					continue;
				case 8:
					this.az(null, null);
					num = 41;
					continue;
				case 9:
					goto IL_485;
				case 10:
					goto IL_485;
				case 11:
					goto IL_485;
				case 12:
					this.ai(null, null);
					num = 10;
					continue;
				case 13:
					if (A_1 != Keys.F9)
					{
						num = 24;
						continue;
					}
					num = 21;
					continue;
				case 14:
					if (this.al.Enabled)
					{
						num = 17;
						continue;
					}
					goto IL_485;
				case 15:
					if (this.fo.Enabled)
					{
						num = 31;
						continue;
					}
					goto IL_485;
				case 16:
					goto IL_485;
				case 17:
					this.j(null, null);
					num = 47;
					continue;
				case 18:
					if (this.fp.Enabled)
					{
						num = 26;
						continue;
					}
					goto IL_485;
				case 19:
					num = 20;
					continue;
				case 20:
					if (A_1 != (Keys)131138)
					{
						num = 6;
						continue;
					}
					num = 27;
					continue;
				case 21:
					if (this.ao.Enabled)
					{
						num = 28;
						continue;
					}
					goto IL_485;
				case 22:
					num = 43;
					continue;
				case 23:
					if (A_1 != Keys.F1)
					{
						num = 42;
						continue;
					}
					num = 14;
					continue;
				case 24:
					if (true)
					{
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11E;
					default:
						if (false)
						{
						}
						num = 16;
						continue;
					}
					break;
				case 25:
					num = 23;
					continue;
				case 26:
					this.z(null, null);
					num = 39;
					continue;
				case 27:
					if (this.fq.Enabled)
					{
						num = 36;
						continue;
					}
					goto IL_485;
				case 28:
					this.n(null, null);
					num = 0;
					continue;
				case 29:
					if (A_1 != (Keys)131154)
					{
						num = 38;
						continue;
					}
					num = 15;
					continue;
				case 30:
					goto IL_460;
				case 31:
					this.al(null, null);
					num = 45;
					continue;
				case 32:
					num = 13;
					continue;
				case 34:
					if (this.ak.Enabled)
					{
						num = 12;
						continue;
					}
					goto IL_485;
				case 35:
					if (this.fr.Enabled)
					{
						num = 8;
						continue;
					}
					goto IL_485;
				case 36:
					this.af(null, null);
					num = 11;
					continue;
				case 37:
					if (A_1 != (Keys)131142)
					{
						num = 46;
						continue;
					}
					num = 35;
					continue;
				case 38:
					num = 3;
					continue;
				case 39:
					goto IL_485;
				case 40:
					if (A_1 <= Keys.F9)
					{
						num = 25;
						continue;
					}
					num = 5;
					continue;
				case 41:
					goto IL_485;
				case 42:
					num = 44;
					continue;
				case 43:
					if (A_0.Msg == 260)
					{
						num = 30;
						continue;
					}
					goto IL_485;
				case 44:
					if (A_1 != Keys.F5)
					{
						num = 32;
						continue;
					}
					num = 34;
					continue;
				case 45:
					goto IL_11E;
				case 46:
					num = 9;
					continue;
				case 47:
					goto IL_485;
				}
				if (A_0.Msg != 256)
				{
					num = 22;
					continue;
				}
				IL_460:
				num = 40;
				continue;
				IL_485:
				num = 4;
				continue;
				IL_11E:
				goto IL_485;
			}
			IL_4A3:
			return base.ProcessCmdKey(ref A_0, A_1);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00013210 File Offset: 0x00012210
		private void n(object A_0, EventArgs A_1)
		{
			try
			{
				for (;;)
				{
					Cursor.Current = Cursors.WaitCursor;
					Cursor.Show();
					this.er = !this.er;
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.a(this.ao, this.db, this.cc);
							num = 3;
							continue;
						case 1:
							goto IL_BA;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								if (false)
								{
								}
								if (this.er)
								{
									num = 0;
									continue;
								}
								this.a(this.ao, this.dc, this.cd);
								num = 1;
								continue;
							}
							break;
						case 3:
							goto IL_BA;
						case 4:
							goto IL_E5;
						}
						break;
						IL_BA:
						this.t.SetSoundStatus(this.er);
						Cursor.Current = Cursors.Default;
						Cursor.Show();
						num = 4;
					}
				}
				IL_E5:;
			}
			catch (Exception ex)
			{
				if (CCustomException.CheckErrorIDExsists(ex))
				{
					if (true)
					{
					}
					CCustomException.Rethrow(ex);
				}
				else
				{
					ex.Source = 3153U.ToString() + "| " + ex.Source;
					CCustomException.Rethrow(ex);
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00013368 File Offset: 0x00012368
		private void m(object A_0, EventArgs A_1)
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
			this.ag.SetToolTip(this.ao, this.u.GetString("BTN_DT_SOUND_HELP"));
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000133C4 File Offset: 0x000123C4
		private void h()
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.t.SetPosition(this);
					num = 6;
					continue;
				case 1:
					this.af.CloseMainWindow();
					this.af.Close();
					this.af = null;
					num = 11;
					continue;
				case 3:
					num = 5;
					continue;
				case 4:
					if (!this.af.HasExited)
					{
						goto IL_10B;
					}
					goto IL_1D3;
				case 5:
					if (this.ac > 0U)
					{
						num = 15;
						continue;
					}
					goto IL_6E;
				case 6:
					goto IL_C8;
				case 7:
					goto IL_13B;
				case 8:
					this.w.Close(this.ac);
					num = 7;
					continue;
				case 9:
					if (this.w.IsOpen())
					{
						num = 3;
						continue;
					}
					goto IL_6E;
				case 10:
					num = 4;
					continue;
				case 11:
					goto IL_17F;
				case 12:
					if (this.af == null)
					{
						goto IL_1D3;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10B;
					default:
						if (false)
						{
						}
						num = 10;
						continue;
					}
					break;
				case 13:
					if (this.w.IsValidHandleToDB(this.ac))
					{
						num = 8;
						continue;
					}
					goto IL_13B;
				case 14:
					goto IL_6E;
				case 15:
					num = 13;
					continue;
				}
				if (true)
				{
				}
				if (base.WindowState != FormWindowState.Minimized)
				{
					num = 0;
					continue;
				}
				goto IL_C8;
				IL_6E:
				num = 12;
				continue;
				IL_C8:
				num = 9;
				continue;
				IL_10B:
				num = 1;
				continue;
				IL_13B:
				this.w.CloseController();
				num = 14;
			}
			IL_17F:
			IL_1D3:
			Application.Exit();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000135AC File Offset: 0x000125AC
		private void l(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.am, this.c3, this.cb);
			}
			catch (Exception ex)
			{
				if (CCustomException.CheckErrorIDExsists(ex))
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
						CCustomException.Rethrow(ex);
						goto IL_74;
					}
				}
				ex.Source = 3153U.ToString() + "| " + ex.Source;
				CCustomException.Rethrow(ex);
				IL_74:;
			}
			if (true)
			{
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00013654 File Offset: 0x00012654
		private int g()
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
			return this.dg;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00013698 File Offset: 0x00012698
		private void a(int A_0)
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
			this.dg = A_0;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000136DC File Offset: 0x000126DC
		private void f()
		{
			this.fo.Enabled = false;
			this.fr.Enabled = false;
			this.fq.Enabled = false;
			this.aq.Enabled = false;
			this.au.Enabled = false;
			this.fp.Enabled = false;
			this.an.Enabled = false;
			this.aj.Enabled = false;
			this.ak.Enabled = false;
			this.ao.Enabled = false;
			this.al.Enabled = false;
			this.am.Enabled = false;
			this.an.Enabled = false;
			this.aj.Enabled = false;
			try
			{
				this.a(this.fo, this.cm, this.az);
				this.fo.Text = this.u.GetString("BTN_DT_READ");
				this.a(this.fr, this.cy, this.b9);
				this.fr.Text = this.u.GetString("BTN_DT_FLASH");
				this.a(this.fq, this.cu, this.b8);
				this.fq.Text = this.u.GetString("BTN_DT_BLANK");
				this.a(this.aq, this.cu, this.cg);
				this.aq.Text = this.u.GetString("BTN_DT_IME");
				this.a(this.au, this.cu, this.ch);
				this.au.Text = this.u.GetString("searchButton");
				this.a(this.fp, this.cq, this.ay);
				this.fp.Text = this.u.GetString("BTN_DT_WRITE");
			}
			catch (Exception ex)
			{
				if (CCustomException.CheckErrorIDExsists(ex))
				{
					CCustomException.Rethrow(ex);
				}
				else
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
						ex.Source = 3153U.ToString() + "| " + ex.Source;
						CCustomException.Rethrow(ex);
						break;
					}
				}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00013954 File Offset: 0x00012954
		private void e()
		{
			this.fo.Enabled = true;
			this.fr.Enabled = this.av;
			this.fq.Enabled = true;
			this.aq.Enabled = true;
			this.au.Enabled = true;
			this.an.Enabled = true;
			this.fp.Enabled = this.ai;
			this.aj.Enabled = true;
			this.ak.Enabled = true;
			this.al.Enabled = true;
			this.am.Enabled = true;
			this.ao.Enabled = true;
			this.an.Enabled = true;
			try
			{
				for (;;)
				{
					this.a(this.fo, this.cj, this.az);
					this.fo.Text = this.u.GetString("BTN_DT_READ");
					int num = 6;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.a(this.fr, this.cv, this.b9);
							this.fr.Text = this.u.GetString("BTN_DT_FLASH");
							num = 3;
							continue;
						case 1:
							goto IL_253;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_302;
							default:
								if (false)
								{
								}
								goto IL_312;
							}
							break;
						case 3:
							goto IL_253;
						case 4:
							this.a(this.fp, this.cn, this.ay);
							this.fp.Text = this.u.GetString("BTN_DT_WRITE");
							num = 2;
							continue;
						case 5:
							goto IL_312;
						case 6:
							if (this.av)
							{
								num = 0;
								continue;
							}
							this.a(this.fr, this.cy, this.b9);
							this.fr.Text = this.u.GetString("BTN_DT_FLASH");
							num = 1;
							continue;
						case 7:
							goto IL_31D;
						case 8:
							if (this.ai)
							{
								goto IL_302;
							}
							this.a(this.fp, this.cq, this.ay);
							this.fp.Text = this.u.GetString("BTN_DT_WRITE");
							num = 5;
							continue;
						}
						break;
						IL_253:
						this.a(this.fq, this.cr, this.b8);
						this.fq.Text = this.u.GetString("BTN_DT_BLANK");
						this.a(this.aq, this.cr, this.cg);
						this.aq.Text = this.u.GetString("BTN_DT_IME");
						this.a(this.au, this.cu, this.ch);
						this.au.Text = this.u.GetString("searchButton");
						num = 8;
						continue;
						IL_302:
						num = 4;
						continue;
						IL_312:
						num = 7;
					}
				}
				IL_31D:;
			}
			catch (Exception ex)
			{
				if (CCustomException.CheckErrorIDExsists(ex))
				{
					if (true)
					{
					}
					CCustomException.Rethrow(ex);
				}
				else
				{
					ex.Source = 3153U.ToString() + "| " + ex.Source;
					CCustomException.Rethrow(ex);
				}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00013CE4 File Offset: 0x00012CE4
		private void a(string A_0, ref string A_1, ref string A_2, ref string A_3, ref string A_4, ref string A_5, ref string A_6, ref string A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11)
		{
			try
			{
				switch (0)
				{
				default:
				{
					XmlDocument xmlDocument = new XmlDocument();
					StringReader stringReader = new StringReader(A_0);
					try
					{
						for (;;)
						{
							xmlDocument.Load(stringReader);
							string text = string.Empty;
							XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode("RADIO_SECURITY_INFO_CMP_TYPE");
							XmlNodeList childNodes = xmlNode.ChildNodes;
							int num = 0;
							int num2 = 24;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num2 = 35;
									continue;
								case 1:
									num2 = 14;
									continue;
								case 2:
									goto IL_634;
								case 3:
									goto IL_576;
								case 4:
									num2 = 11;
									continue;
								case 5:
									if (text == "RS_TANAPANUM")
									{
										num2 = 8;
										continue;
									}
									num2 = 44;
									continue;
								case 6:
									num2 = 41;
									continue;
								case 7:
									goto IL_5AA;
								case 8:
									A_2 = childNodes[num].InnerText;
									num2 = 13;
									continue;
								case 9:
									if (xmlNode.InnerText != "CFS_ENABLED")
									{
										num2 = 42;
										continue;
									}
									goto IL_273;
								case 10:
									if (!(xmlNode.InnerText == "FREE"))
									{
										num2 = 36;
										continue;
									}
									goto IL_4E1;
								case 11:
									if (xmlNode.InnerText != "FREE")
									{
										num2 = 6;
										continue;
									}
									goto IL_160;
								case 12:
									if (xmlNode != null)
									{
										num2 = 49;
										continue;
									}
									goto IL_273;
								case 13:
									goto IL_334;
								case 14:
									if (xmlNode.InnerText != "CFS_ENABLED")
									{
										num2 = 48;
										continue;
									}
									goto IL_19F;
								case 15:
									if (xmlNode != null)
									{
										num2 = 39;
										continue;
									}
									goto IL_5F0;
								case 16:
									A_7 = childNodes[num].InnerText;
									num2 = 47;
									continue;
								case 17:
									if (text == "RS_MODELNUM")
									{
										num2 = 16;
										continue;
									}
									goto IL_334;
								case 18:
									if (xmlNode != null)
									{
										num2 = 4;
										continue;
									}
									goto IL_160;
								case 19:
									if (text == "RS_DEVICESERIALNUM")
									{
										num2 = 45;
										continue;
									}
									num2 = 5;
									continue;
								case 20:
									goto IL_242;
								case 21:
									goto IL_634;
								case 22:
									if (text == "RS_SECVERS")
									{
										num2 = 34;
										continue;
									}
									num2 = 17;
									continue;
								case 23:
									if (xmlNode.InnerText == "CFS_ENABLED")
									{
										num2 = 46;
										continue;
									}
									goto IL_5F0;
								case 24:
									goto IL_45E;
								case 25:
									A_10 = false;
									num2 = 30;
									continue;
								case 26:
									goto IL_45E;
								case 27:
									goto IL_334;
								case 28:
									xmlNode = xmlDocument.DocumentElement.SelectSingleNode("CS_FWVER");
									A_4 = xmlNode.InnerText;
									xmlNode = xmlDocument.DocumentElement.SelectSingleNode("MODEL_TYPE");
									A_6 = xmlNode.InnerText;
									xmlNode = xmlDocument.DocumentElement.SelectSingleNode("LTD_CFS_CMP_TYPE/CFS_MTRTOPHNFWCVT");
									num2 = 15;
									continue;
								case 29:
									goto IL_640;
								case 30:
									goto IL_242;
								case 31:
									goto IL_576;
								case 32:
									goto IL_5AA;
								case 33:
									goto IL_334;
								case 34:
									A_5 = childNodes[num].InnerText;
									num2 = 33;
									continue;
								case 35:
									if (xmlNode.InnerText != "FREE")
									{
										num2 = 1;
										continue;
									}
									goto IL_19F;
								case 36:
									num2 = 23;
									continue;
								case 37:
									if (xmlNode != null)
									{
										num2 = 0;
										continue;
									}
									goto IL_19F;
								case 38:
									if (xmlNode.InnerText != "FREE")
									{
										num2 = 51;
										continue;
									}
									goto IL_273;
								case 39:
									num2 = 10;
									continue;
								case 40:
									A_3 = childNodes[num].InnerText;
									num2 = 43;
									continue;
								case 41:
									if (xmlNode.InnerText != "CFS_ENABLED")
									{
										num2 = 25;
										continue;
									}
									goto IL_160;
								case 42:
									A_11 = false;
									num2 = 2;
									continue;
								case 43:
									goto IL_334;
								case 44:
									if (text == "RS_RGNID")
									{
										num2 = 40;
										continue;
									}
									num2 = 22;
									continue;
								case 45:
									A_1 = childNodes[num].InnerText;
									num2 = 27;
									continue;
								case 46:
									goto IL_4E1;
								case 47:
									goto IL_334;
								case 48:
									A_9 = false;
									num2 = 3;
									continue;
								case 49:
									num2 = 38;
									continue;
								case 50:
									if (num >= childNodes.Count)
									{
										num2 = 28;
										continue;
									}
									text = childNodes[num].Name;
									num2 = 19;
									continue;
								case 51:
									num2 = 9;
									continue;
								}
								break;
								IL_160:
								A_10 = true;
								num2 = 20;
								continue;
								IL_19F:
								A_9 = true;
								num2 = 31;
								continue;
								IL_242:
								xmlNode = xmlDocument.DocumentElement.SelectSingleNode("LTD_CFS_CMP_TYPE/CFS_DIGITALAUDIO");
								num2 = 12;
								continue;
								IL_273:
								A_11 = true;
								num2 = 21;
								continue;
								IL_334:
								num++;
								num2 = 26;
								continue;
								IL_45E:
								num2 = 50;
								continue;
								IL_4E1:
								A_8 = true;
								num2 = 32;
								continue;
								IL_576:
								xmlNode = xmlDocument.DocumentElement.SelectSingleNode("LTD_CFS_CMP_TYPE/CFS_DGTLPHNPTC");
								num2 = 18;
								continue;
								IL_5AA:
								xmlNode = xmlDocument.DocumentElement.SelectSingleNode("LTD_CFS_CMP_TYPE/CFS_DIGITAL");
								num2 = 37;
								continue;
								IL_5F0:
								A_8 = false;
								num2 = 7;
								continue;
								IL_634:
								num2 = 29;
							}
						}
						IL_640:;
					}
					finally
					{
						int num2 = 1;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((IDisposable)stringReader).Dispose();
								num2 = 2;
								continue;
							case 2:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_663;
								default:
									goto IL_693;
								}
								break;
							}
							goto IL_660;
							IL_663:
							num2 = 0;
							continue;
							IL_660:
							if (stringReader != null)
							{
								goto IL_663;
							}
							goto IL_69B;
						}
						IL_693:
						if (false)
						{
						}
						IL_69B:;
					}
					break;
				}
				}
			}
			catch (Exception)
			{
				CCustomException ex = CustomExceptionHandler.a(1625U, base.GetType().ToString(), "GetDevInfo", Environment.StackTrace);
				throw ex;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000143FC File Offset: 0x000133FC
		private void k(object A_0, EventArgs A_1)
		{
			try
			{
				for (;;)
				{
					string text;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						text = "0000000000";
						break;
					}
					int num = 4;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (!(this.fw.Text == text))
							{
								num = 8;
								continue;
							}
							goto IL_83;
						case 1:
							goto IL_83;
						case 2:
							if (this.fw.Text.Trim().Length == 0)
							{
								num = 1;
								continue;
							}
							this.fp.Enabled = true;
							this.ai = true;
							this.a(this.fp, this.cn, this.ay);
							this.fp.Text = this.u.GetString("BTN_DT_WRITE");
							num = 3;
							continue;
						case 3:
							goto IL_18C;
						case 4:
							if (this.fw.Text.Length >= text.Length)
							{
								if (true)
								{
								}
								num = 5;
								continue;
							}
							goto IL_83;
						case 5:
							num = 0;
							continue;
						case 6:
							goto IL_18C;
						case 7:
							goto IL_197;
						case 8:
							num = 2;
							continue;
						}
						break;
						IL_83:
						this.fp.Enabled = false;
						this.ai = false;
						this.a(this.fp, this.cq, this.ay);
						this.fp.Text = this.u.GetString("BTN_DT_WRITE");
						num = 6;
						continue;
						IL_18C:
						num = 7;
					}
				}
				IL_197:;
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000145CC File Offset: 0x000135CC
		private void j(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.al, this.c8, this.b7);
				goto IL_EF;
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				if (CCustomException.CheckErrorIDExsists(ex2))
				{
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_6D;
						}
					}
					IL_6D:
					if (false)
					{
					}
					CCustomException.Rethrow(ex2);
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
				goto IL_EF;
			}
			try
			{
				IL_7D:
				this.a(this.al, this.c7, this.b7);
				return;
			}
			catch (CCustomException ex3)
			{
				throw ex3;
			}
			catch (Exception ex4)
			{
				if (CCustomException.CheckErrorIDExsists(ex4))
				{
					CCustomException.Rethrow(ex4);
				}
				else
				{
					if (true)
					{
					}
					ex4.Source = 3153U.ToString() + "| " + ex4.Source;
					CCustomException.Rethrow(ex4);
				}
				return;
			}
			try
			{
				IL_EF:
				Cursor.Current = Cursors.WaitCursor;
				Cursor.Show();
				this.af = Process.Start("IExplore.exe", this.ad);
				Cursor.Current = Cursors.Default;
				Cursor.Show();
				goto IL_7D;
			}
			catch (Exception ex5)
			{
				this.a(this.al, this.c7, this.b7);
				ex5.Source = 1808U.ToString() + "| " + ex5.Source;
				CCustomException.Rethrow(ex5);
				goto IL_7D;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00014794 File Offset: 0x00013794
		private void i(object A_0, EventArgs A_1)
		{
			if (true)
			{
			}
			if (this.f1.SelectedIndices.Count <= 0)
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
					this.a(this.fr, this.cy, this.b9);
					this.fr.Text = this.u.GetString("BTN_DT_FLASH");
					this.fr.Enabled = false;
					this.av = false;
					return;
				}
			}
			this.a(this.fr, this.cv, this.b9);
			this.fr.Text = this.u.GetString("BTN_DT_FLASH");
			this.fr.Enabled = true;
			this.av = true;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00014874 File Offset: 0x00013874
		private void a(object A_0, ColumnClickEventArgs A_1)
		{
			for (;;)
			{
				int num = 0;
				int num2 = 1;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1B8;
					case 1:
						goto IL_2BF;
					case 2:
						goto IL_2BF;
					case 3:
						this.f3.a(SortOrder.Descending);
						this.f1.Columns[A_1.Column].Text = this.f1.Columns[A_1.Column].Text + " " + '▲';
						num2 = 13;
						continue;
					case 4:
						num2 = 6;
						continue;
					case 5:
						if (num > this.f1.Columns.Count - 1)
						{
							num2 = 11;
							continue;
						}
						num2 = 10;
						continue;
					case 6:
						if (this.f3.b() == SortOrder.Ascending)
						{
							num2 = 3;
							continue;
						}
						this.f3.a(SortOrder.Ascending);
						this.f1.Columns[A_1.Column].Text = this.f1.Columns[A_1.Column].Text + " " + '▼';
						num2 = 0;
						continue;
					case 7:
						goto IL_30E;
					case 8:
						if (A_1.Column == this.f3.a())
						{
							num2 = 4;
							continue;
						}
						this.f3.a(A_1.Column);
						this.f3.a(SortOrder.Ascending);
						this.f1.Columns[A_1.Column].Text = this.f1.Columns[A_1.Column].Text + " " + '▼';
						num2 = 9;
						continue;
					case 9:
						goto IL_2BD;
					case 10:
						if (this.f1.Columns[num].Text.IndexOf('▼') + this.f1.Columns[num].Text.IndexOf('▲') > 0)
						{
							num2 = 12;
							continue;
						}
						goto IL_30E;
					case 11:
						IL_309:
						if (true)
						{
						}
						num2 = 8;
						continue;
					case 12:
						this.f1.Columns[num].Text = this.f1.Columns[num].Text.Substring(0, this.f1.Columns[num].Text.Length - 2);
						num2 = 7;
						continue;
					case 13:
						goto IL_B0;
					}
					break;
					IL_30E:
					num++;
					num2 = 2;
					continue;
					IL_2BF:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_309;
					default:
						if (false)
						{
						}
						num2 = 5;
						break;
					}
				}
			}
			IL_B0:
			IL_1B8:
			IL_2BD:
			this.f1.Sort();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00014BAC File Offset: 0x00013BAC
		private void h(object A_0, EventArgs A_1)
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
			this.ag.SetToolTip(this.al, this.u.GetString("BTN_DT_ABOUT_HELP"));
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00014C08 File Offset: 0x00013C08
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
			this.es.Visible = false;
			this.e3.Visible = false;
			this.fc.Visible = false;
			this.ex.Visible = false;
			this.fa.Visible = false;
			this.fl.Visible = false;
			this.et.Visible = false;
			this.f0.Visible = false;
			this.fz.Visible = false;
			this.eu.Visible = false;
			this.fy.Visible = false;
			this.fd.Visible = false;
			this.e0.Visible = false;
			this.e7.Visible = false;
			this.fi.Visible = false;
			this.e1.Visible = false;
			this.e8.Visible = false;
			this.fj.Visible = false;
			this.ew.Visible = false;
			this.e4.Visible = false;
			this.fk.Visible = false;
			this.ez.Visible = false;
			this.e5.Visible = false;
			this.fh.Visible = false;
			this.ev.Visible = false;
			this.fb.Visible = false;
			this.fe.Visible = false;
			this.e2.Visible = false;
			this.e6.Visible = false;
			this.fg.Visible = false;
			this.fv.Visible = false;
			this.ft.Visible = false;
			this.fu.Visible = false;
			this.ey.Visible = false;
			this.e9.Visible = false;
			this.ff.Visible = false;
			this.f9.Visible = false;
			this.ae.Visible = false;
			this.fn.Visible = false;
			this.fm.Visible = false;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00014E24 File Offset: 0x00013E24
		private void c()
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
			string text = this.u.GetString("APPABOUTTEXT_DEPOTTOOL");
			text = text.Replace("%1", this.u.GetString("LBL_VERSION_NUM_DEPOTTOOL"));
			text = text.Replace("%2", this.u.GetString("LBL_BUILD_NUM_DEPOTTOOL"));
			this.ap.Text = text;
			this.ap.SelectAll();
			this.ap.SelectionAlignment = HorizontalAlignment.Center;
			int length = this.ap.Text.Length;
			this.ap.AppendText(this.u.GetString("LBL_WARNING"));
			this.ap.Select(length, this.ap.Text.Length - length);
			this.ap.SelectionAlignment = HorizontalAlignment.Left;
			this.ap.Select(0, 0);
			this.ap.Visible = true;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00014F3C File Offset: 0x00013F3C
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
			this.ap.Visible = false;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00014F84 File Offset: 0x00013F84
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
			this.e3.Visible = this.dn;
			this.fc.Visible = this.@do;
			this.fa.Visible = this.dp;
			this.fl.Visible = this.dq;
			this.f0.Visible = this.dr;
			this.fd.Visible = this.ds;
			this.fy.Visible = this.dt;
			this.fz.Visible = this.du;
			this.e7.Visible = this.dv;
			this.fi.Visible = this.dw;
			this.e8.Visible = this.dx;
			this.fj.Visible = this.dy;
			this.e4.Visible = this.dz;
			this.fk.Visible = this.d0;
			this.e5.Visible = this.d1;
			this.fh.Visible = this.d2;
			this.fb.Visible = this.d3;
			this.fe.Visible = this.d4;
			this.e6.Visible = this.d5;
			this.fg.Visible = this.d6;
			this.ft.Visible = this.d7;
			this.fu.Visible = this.d8;
			this.e9.Visible = this.d9;
			this.ff.Visible = this.ea;
			this.f9.Visible = this.eb;
			this.ae.Visible = this.ec;
			this.fn.Visible = this.ed;
			this.fm.Visible = this.ee;
			this.es.Visible = this.ef;
			this.ex.Visible = this.eg;
			this.et.Visible = this.eh;
			this.eu.Visible = this.ei;
			this.e0.Visible = this.ej;
			this.e1.Visible = this.ek;
			this.ew.Visible = this.el;
			this.ez.Visible = this.em;
			this.ev.Visible = this.en;
			this.e2.Visible = this.eo;
			this.fv.Visible = this.ep;
			this.ey.Visible = this.eq;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00015268 File Offset: 0x00014268
		private void g(object A_0, EventArgs A_1)
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
				this.a(this.aq, this.cs, this.cg);
				this.aq.Text = this.u.GetString("BTN_DT_IME");
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
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
			try
			{
				for (;;)
				{
					this.f();
					this.Cursor = Cursors.WaitCursor;
					this.w.SendUpdateIMEType((byte)this.ar.SelectedIndex);
					CMsgDialog cmsgDialog = new CMsgDialog(true, this.u, 3156, "DT_APP_NAME", null);
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_121;
						case 1:
							if (cmsgDialog == null)
							{
								num = 0;
								continue;
							}
							num = 3;
							continue;
						case 2:
						{
							CPlaySound cplaySound = new CPlaySound(this.Mirrored, this.t, this.u);
							cplaySound.b(CPlaySound.SoundType.a);
							num = 4;
							continue;
						}
						case 3:
							if (this.er)
							{
								num = 2;
								continue;
							}
							goto IL_193;
						case 4:
							goto IL_193;
						case 5:
							goto IL_1C3;
						}
						break;
						IL_193:
						cmsgDialog.Show(this, false, DialogResult.OK, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						this.e();
						this.d();
						this.Cursor = Cursors.Default;
						num = 5;
					}
				}
				IL_121:
				CCustomException ex3 = CustomExceptionHandler.a(1646U, base.GetType().ToString(), "WriteDevice", Environment.StackTrace);
				throw ex3;
				IL_1C3:;
			}
			catch (CCustomException ex4)
			{
				this.e();
				this.Cursor = Cursors.Default;
				throw ex4;
			}
			catch (Exception ex5)
			{
				this.e();
				this.Cursor = Cursors.Default;
				CCustomException.Rethrow(ex5);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000154DC File Offset: 0x000144DC
		private void f(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.aq, this.ct, this.cg);
				this.aq.Text = this.u.GetString("BTN_DT_IME");
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
						break;
					}
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
				if (true)
				{
				}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000155AC File Offset: 0x000145AC
		private void e(object A_0, EventArgs A_1)
		{
			try
			{
				if (true)
				{
				}
				this.a(this.aq, this.cr, this.cg);
				this.aq.Text = this.u.GetString("BTN_DT_IME");
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
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						ex2.Source = 3153U.ToString() + "| " + ex2.Source;
						CCustomException.Rethrow(ex2);
						break;
					}
				}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0001567C File Offset: 0x0001467C
		private void d(object A_0, EventArgs A_1)
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
				this.a(this.au, this.cs, this.ch);
				this.au.Text = this.u.GetString("searchButton");
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
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
			try
			{
				for (;;)
				{
					this.f();
					this.Cursor = Cursors.WaitCursor;
					c c = new c();
					c.a(this.f1, this.f2, this.at.Text);
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							CPlaySound cplaySound = new CPlaySound(this.Mirrored, this.t, this.u);
							cplaySound.b(CPlaySound.SoundType.a);
							num = 3;
							continue;
						}
						case 1:
							if (this.er)
							{
								num = 0;
								continue;
							}
							goto IL_139;
						case 2:
							goto IL_156;
						case 3:
							goto IL_139;
						}
						break;
						IL_139:
						this.e();
						this.Cursor = Cursors.Default;
						num = 2;
					}
				}
				IL_156:;
			}
			catch (CCustomException ex3)
			{
				this.e();
				this.Cursor = Cursors.Default;
				throw ex3;
			}
			catch (Exception ex4)
			{
				this.e();
				this.Cursor = Cursors.Default;
				CCustomException.Rethrow(ex4);
			}
			if (true)
			{
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0001585C File Offset: 0x0001485C
		private void c(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.au, this.ct, this.ch);
				this.au.Text = this.u.GetString("searchButton");
			}
			catch (CCustomException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				if (!CCustomException.CheckErrorIDExsists(ex2))
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
					goto IL_76;
				}
				IL_41:
				CCustomException.Rethrow(ex2);
				IL_76:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_41;
				default:
					if (false)
					{
					}
					break;
				}
			}
			if (true)
			{
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0001592C File Offset: 0x0001492C
		private void b(object A_0, EventArgs A_1)
		{
			try
			{
				this.a(this.au, this.cr, this.ch);
				this.au.Text = this.u.GetString("searchButton");
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
						break;
					}
				}
				else
				{
					ex2.Source = 3153U.ToString() + "| " + ex2.Source;
					CCustomException.Rethrow(ex2);
				}
			}
			if (true)
			{
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000159FC File Offset: 0x000149FC
		private void a(object A_0, EventArgs A_1)
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
			this.ag.SetToolTip(this.at, this.u.GetString("searchTextBox_Help"));
			this.ag.ToolTipTitle = "How to Use";
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00015A68 File Offset: 0x00014A68
		private void a(object A_0, KeyPressEventArgs A_1)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
					if (true)
					{
					}
					this.d(null, null);
					this.b(null, null);
					goto IL_6E;
				}
				if (A_1.KeyChar != '\r')
				{
					break;
				}
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
				IL_6E:
				num = 1;
			}
		}

		// Token: 0x04000111 RID: 273
		private const int a = 4194304;

		// Token: 0x04000112 RID: 274
		private const string b = "SOFTWARE\\Motorola\\MOTOTRBO DepotTool\\DepotTool";

		// Token: 0x04000113 RID: 275
		private const string c = "Application Failed";

		// Token: 0x04000114 RID: 276
		private const int d = 164;

		// Token: 0x04000115 RID: 277
		private const int e = 1;

		// Token: 0x04000116 RID: 278
		private const int f = 2;

		// Token: 0x04000117 RID: 279
		private const uint g = 9U;

		// Token: 0x04000118 RID: 280
		private const int h = -16;

		// Token: 0x04000119 RID: 281
		private const long i = 134217728L;

		// Token: 0x0400011A RID: 282
		private const string j = "IExplore.exe";

		// Token: 0x0400011B RID: 283
		private const int k = 4;

		// Token: 0x0400011C RID: 284
		private const int l = 256;

		// Token: 0x0400011D RID: 285
		private const int m = 260;

		// Token: 0x0400011E RID: 286
		private const int n = 0;

		// Token: 0x0400011F RID: 287
		private const int o = 1;

		// Token: 0x04000120 RID: 288
		private const int p = 2;

		// Token: 0x04000121 RID: 289
		private const int q = 3;

		// Token: 0x04000122 RID: 290
		private const int r = 7;

		// Token: 0x04000123 RID: 291
		private const int s = 5;

		// Token: 0x04000124 RID: 292
		protected IPersistentApplicationSettings t;

		// Token: 0x04000125 RID: 293
		private CResourceHandler u;

		// Token: 0x04000126 RID: 294
		private CResourceHandler v;

		// Token: 0x04000127 RID: 295
		private IController w;

		// Token: 0x04000128 RID: 296
		private bool x;

		// Token: 0x04000129 RID: 297
		private string y;

		// Token: 0x0400012A RID: 298
		private ILanguageSettings z;

		// Token: 0x0400012B RID: 299
		public bool aa;

		// Token: 0x0400012C RID: 300
		public string ab;

		// Token: 0x0400012D RID: 301
		private uint ac;

		// Token: 0x0400012E RID: 302
		private string ad;

		// Token: 0x0400012F RID: 303
		private Label ae;

		// Token: 0x04000130 RID: 304
		private Process af;

		// Token: 0x04000131 RID: 305
		private ToolTip ag;

		// Token: 0x04000132 RID: 306
		private string ah;

		// Token: 0x04000133 RID: 307
		private bool ai;

		// Token: 0x04000134 RID: 308
		private PictureBox aj;

		// Token: 0x04000135 RID: 309
		private PictureBox ak;

		// Token: 0x04000136 RID: 310
		private PictureBox al;

		// Token: 0x04000137 RID: 311
		private PictureBox am;

		// Token: 0x04000138 RID: 312
		private PictureBox an;

		// Token: 0x04000139 RID: 313
		private PictureBox ao;

		// Token: 0x0400013A RID: 314
		private RichTextBox ap;

		// Token: 0x0400013B RID: 315
		private Button aq;

		// Token: 0x0400013C RID: 316
		private ComboBox ar;

		// Token: 0x0400013D RID: 317
		private Label @as;

		// Token: 0x0400013E RID: 318
		private TextBox at;

		// Token: 0x0400013F RID: 319
		private Button au;

		// Token: 0x04000140 RID: 320
		private bool av;

		// Token: 0x04000141 RID: 321
		public a aw;

		// Token: 0x04000142 RID: 322
		private Point ax;

		// Token: 0x04000143 RID: 323
		private Point ay;

		// Token: 0x04000144 RID: 324
		private Point az;

		// Token: 0x04000145 RID: 325
		private Point a0;

		// Token: 0x04000146 RID: 326
		private Point a1;

		// Token: 0x04000147 RID: 327
		private Point a2;

		// Token: 0x04000148 RID: 328
		private Point a3;

		// Token: 0x04000149 RID: 329
		private Point a4;

		// Token: 0x0400014A RID: 330
		private Point a5;

		// Token: 0x0400014B RID: 331
		private Point a6;

		// Token: 0x0400014C RID: 332
		private Point a7;

		// Token: 0x0400014D RID: 333
		private Point a8;

		// Token: 0x0400014E RID: 334
		private Point a9;

		// Token: 0x0400014F RID: 335
		private Point ba;

		// Token: 0x04000150 RID: 336
		private Point bb;

		// Token: 0x04000151 RID: 337
		private Point bc;

		// Token: 0x04000152 RID: 338
		private Point bd;

		// Token: 0x04000153 RID: 339
		private Point be;

		// Token: 0x04000154 RID: 340
		private Point bf;

		// Token: 0x04000155 RID: 341
		private Point bg;

		// Token: 0x04000156 RID: 342
		private Point bh;

		// Token: 0x04000157 RID: 343
		private Point bi;

		// Token: 0x04000158 RID: 344
		private Point bj;

		// Token: 0x04000159 RID: 345
		private Point bk;

		// Token: 0x0400015A RID: 346
		private Point bl;

		// Token: 0x0400015B RID: 347
		private Point bm;

		// Token: 0x0400015C RID: 348
		private Point bn;

		// Token: 0x0400015D RID: 349
		private Point bo;

		// Token: 0x0400015E RID: 350
		private Point bp;

		// Token: 0x0400015F RID: 351
		private Point bq;

		// Token: 0x04000160 RID: 352
		private Point br;

		// Token: 0x04000161 RID: 353
		private Point bs;

		// Token: 0x04000162 RID: 354
		private Point bt;

		// Token: 0x04000163 RID: 355
		private Point bu;

		// Token: 0x04000164 RID: 356
		private Point bv;

		// Token: 0x04000165 RID: 357
		private Point bw;

		// Token: 0x04000166 RID: 358
		private Point bx;

		// Token: 0x04000167 RID: 359
		private Point by;

		// Token: 0x04000168 RID: 360
		private Point bz;

		// Token: 0x04000169 RID: 361
		private Point b0;

		// Token: 0x0400016A RID: 362
		private Point b1;

		// Token: 0x0400016B RID: 363
		private Point b2;

		// Token: 0x0400016C RID: 364
		private Point b3;

		// Token: 0x0400016D RID: 365
		private Point b4;

		// Token: 0x0400016E RID: 366
		private Point b5;

		// Token: 0x0400016F RID: 367
		private Point b6;

		// Token: 0x04000170 RID: 368
		private Point b7;

		// Token: 0x04000171 RID: 369
		private Point b8;

		// Token: 0x04000172 RID: 370
		private Point b9;

		// Token: 0x04000173 RID: 371
		private Point ca;

		// Token: 0x04000174 RID: 372
		private Point cb;

		// Token: 0x04000175 RID: 373
		private Point cc;

		// Token: 0x04000176 RID: 374
		private Point cd;

		// Token: 0x04000177 RID: 375
		private Point ce;

		// Token: 0x04000178 RID: 376
		private Point cf;

		// Token: 0x04000179 RID: 377
		private Point cg;

		// Token: 0x0400017A RID: 378
		private Point ch;

		// Token: 0x0400017B RID: 379
		private Bitmap ci;

		// Token: 0x0400017C RID: 380
		private Bitmap cj;

		// Token: 0x0400017D RID: 381
		private Bitmap ck;

		// Token: 0x0400017E RID: 382
		private Bitmap cl;

		// Token: 0x0400017F RID: 383
		private Bitmap cm;

		// Token: 0x04000180 RID: 384
		private Bitmap cn;

		// Token: 0x04000181 RID: 385
		private Bitmap co;

		// Token: 0x04000182 RID: 386
		private Bitmap cp;

		// Token: 0x04000183 RID: 387
		private Bitmap cq;

		// Token: 0x04000184 RID: 388
		private Bitmap cr;

		// Token: 0x04000185 RID: 389
		private Bitmap cs;

		// Token: 0x04000186 RID: 390
		private Bitmap ct;

		// Token: 0x04000187 RID: 391
		private Bitmap cu;

		// Token: 0x04000188 RID: 392
		private Bitmap cv;

		// Token: 0x04000189 RID: 393
		private Bitmap cw;

		// Token: 0x0400018A RID: 394
		private Bitmap cx;

		// Token: 0x0400018B RID: 395
		private Bitmap cy;

		// Token: 0x0400018C RID: 396
		private Bitmap cz;

		// Token: 0x0400018D RID: 397
		private Bitmap c0;

		// Token: 0x0400018E RID: 398
		private Bitmap c1;

		// Token: 0x0400018F RID: 399
		private Bitmap c2;

		// Token: 0x04000190 RID: 400
		private Bitmap c3;

		// Token: 0x04000191 RID: 401
		private Bitmap c4;

		// Token: 0x04000192 RID: 402
		private Bitmap c5;

		// Token: 0x04000193 RID: 403
		private Bitmap c6;

		// Token: 0x04000194 RID: 404
		private Bitmap c7;

		// Token: 0x04000195 RID: 405
		private Bitmap c8;

		// Token: 0x04000196 RID: 406
		private Bitmap c9;

		// Token: 0x04000197 RID: 407
		private Bitmap da;

		// Token: 0x04000198 RID: 408
		private Bitmap db;

		// Token: 0x04000199 RID: 409
		private Bitmap dc;

		// Token: 0x0400019A RID: 410
		private Point dd;

		// Token: 0x0400019B RID: 411
		private bool de;

		// Token: 0x0400019C RID: 412
		private bool df;

		// Token: 0x0400019D RID: 413
		private int dg;

		// Token: 0x0400019E RID: 414
		public string dh;

		// Token: 0x0400019F RID: 415
		public string di;

		// Token: 0x040001A0 RID: 416
		public string dj;

		// Token: 0x040001A1 RID: 417
		public string dk;

		// Token: 0x040001A2 RID: 418
		public string dl;

		// Token: 0x040001A3 RID: 419
		public string dm;

		// Token: 0x040001A4 RID: 420
		private bool dn;

		// Token: 0x040001A5 RID: 421
		private bool @do;

		// Token: 0x040001A6 RID: 422
		private bool dp;

		// Token: 0x040001A7 RID: 423
		private bool dq;

		// Token: 0x040001A8 RID: 424
		private bool dr;

		// Token: 0x040001A9 RID: 425
		private bool ds;

		// Token: 0x040001AA RID: 426
		private bool dt;

		// Token: 0x040001AB RID: 427
		private bool du;

		// Token: 0x040001AC RID: 428
		private bool dv;

		// Token: 0x040001AD RID: 429
		private bool dw;

		// Token: 0x040001AE RID: 430
		private bool dx;

		// Token: 0x040001AF RID: 431
		private bool dy;

		// Token: 0x040001B0 RID: 432
		private bool dz;

		// Token: 0x040001B1 RID: 433
		private bool d0;

		// Token: 0x040001B2 RID: 434
		private bool d1;

		// Token: 0x040001B3 RID: 435
		private bool d2;

		// Token: 0x040001B4 RID: 436
		private bool d3;

		// Token: 0x040001B5 RID: 437
		private bool d4;

		// Token: 0x040001B6 RID: 438
		private bool d5;

		// Token: 0x040001B7 RID: 439
		private bool d6;

		// Token: 0x040001B8 RID: 440
		private bool d7;

		// Token: 0x040001B9 RID: 441
		private bool d8;

		// Token: 0x040001BA RID: 442
		private bool d9;

		// Token: 0x040001BB RID: 443
		private bool ea;

		// Token: 0x040001BC RID: 444
		private bool eb;

		// Token: 0x040001BD RID: 445
		private bool ec;

		// Token: 0x040001BE RID: 446
		private bool ed;

		// Token: 0x040001BF RID: 447
		private bool ee;

		// Token: 0x040001C0 RID: 448
		private bool ef;

		// Token: 0x040001C1 RID: 449
		private bool eg;

		// Token: 0x040001C2 RID: 450
		private bool eh;

		// Token: 0x040001C3 RID: 451
		private bool ei;

		// Token: 0x040001C4 RID: 452
		private bool ej;

		// Token: 0x040001C5 RID: 453
		private bool ek;

		// Token: 0x040001C6 RID: 454
		private bool el;

		// Token: 0x040001C7 RID: 455
		private bool em;

		// Token: 0x040001C8 RID: 456
		private bool en;

		// Token: 0x040001C9 RID: 457
		private bool eo;

		// Token: 0x040001CA RID: 458
		private bool ep;

		// Token: 0x040001CB RID: 459
		private bool eq;

		// Token: 0x040001CC RID: 460
		private bool er;

		// Token: 0x040001CD RID: 461
		private Label es;

		// Token: 0x040001CE RID: 462
		private Label et;

		// Token: 0x040001CF RID: 463
		private Label eu;

		// Token: 0x040001D0 RID: 464
		private Label ev;

		// Token: 0x040001D1 RID: 465
		private Label ew;

		// Token: 0x040001D2 RID: 466
		private Label ex;

		// Token: 0x040001D3 RID: 467
		private Label ey;

		// Token: 0x040001D4 RID: 468
		private Label ez;

		// Token: 0x040001D5 RID: 469
		private Label e0;

		// Token: 0x040001D6 RID: 470
		private Label e1;

		// Token: 0x040001D7 RID: 471
		private Label e2;

		// Token: 0x040001D8 RID: 472
		private Label e3;

		// Token: 0x040001D9 RID: 473
		private Label e4;

		// Token: 0x040001DA RID: 474
		private Label e5;

		// Token: 0x040001DB RID: 475
		private Label e6;

		// Token: 0x040001DC RID: 476
		private Label e7;

		// Token: 0x040001DD RID: 477
		private Label e8;

		// Token: 0x040001DE RID: 478
		private ListBox e9;

		// Token: 0x040001DF RID: 479
		private Label fa;

		// Token: 0x040001E0 RID: 480
		private Label fb;

		// Token: 0x040001E1 RID: 481
		private Label fc;

		// Token: 0x040001E2 RID: 482
		private Label fd;

		// Token: 0x040001E3 RID: 483
		private Label fe;

		// Token: 0x040001E4 RID: 484
		private ListBox ff;

		// Token: 0x040001E5 RID: 485
		private Label fg;

		// Token: 0x040001E6 RID: 486
		private Label fh;

		// Token: 0x040001E7 RID: 487
		private Label fi;

		// Token: 0x040001E8 RID: 488
		private Label fj;

		// Token: 0x040001E9 RID: 489
		private Label fk;

		// Token: 0x040001EA RID: 490
		private Label fl;

		// Token: 0x040001EB RID: 491
		private Label fm;

		// Token: 0x040001EC RID: 492
		private Label fn;

		// Token: 0x040001ED RID: 493
		private Button fo;

		// Token: 0x040001EE RID: 494
		private Button fp;

		// Token: 0x040001EF RID: 495
		private Button fq;

		// Token: 0x040001F0 RID: 496
		private Button fr;

		// Token: 0x040001F1 RID: 497
		private Label fs;

		// Token: 0x040001F2 RID: 498
		private Label ft;

		// Token: 0x040001F3 RID: 499
		private Label fu;

		// Token: 0x040001F4 RID: 500
		private Label fv;

		// Token: 0x040001F5 RID: 501
		private TextBox fw;

		// Token: 0x040001F6 RID: 502
		private Panel fx;

		// Token: 0x040001F7 RID: 503
		private Label fy;

		// Token: 0x040001F8 RID: 504
		private Label fz;

		// Token: 0x040001F9 RID: 505
		private Label f0;

		// Token: 0x040001FA RID: 506
		private ListView f1;

		// Token: 0x040001FB RID: 507
		private ListView f2;

		// Token: 0x040001FC RID: 508
		private b f3;

		// Token: 0x040001FD RID: 509
		private ColumnHeader f4;

		// Token: 0x040001FE RID: 510
		private ColumnHeader f5;

		// Token: 0x040001FF RID: 511
		private ColumnHeader f6;

		// Token: 0x04000200 RID: 512
		private ColumnHeader f7;

		// Token: 0x04000201 RID: 513
		private ColumnHeader f8;

		// Token: 0x04000202 RID: 514
		private Label f9;

		// Token: 0x04000203 RID: 515
		private ColumnHeader ga;

		// Token: 0x04000204 RID: 516
		private ColumnHeader gb;

		// Token: 0x04000205 RID: 517
		private PictureBox gc;

		// Token: 0x04000206 RID: 518
		private PictureBox gd;

		// Token: 0x04000207 RID: 519
		private IContainer ge;
	}
}
