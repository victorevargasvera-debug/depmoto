using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000044 RID: 68
	public partial class CFormTemplate : Form
	{
		// Token: 0x0600033F RID: 831
		[DllImport("User32", CharSet = CharSet.Auto)]
		private static extern int GetWindowLong(IntPtr A_0, int A_1);

		// Token: 0x06000340 RID: 832
		[DllImport("User32", CharSet = CharSet.Auto)]
		private static extern int SetWindowLong(IntPtr A_0, int A_1, int A_2);

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00038C10 File Offset: 0x00036E10
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00038C54 File Offset: 0x00036E54
		[Browsable(true)]
		[DefaultValue(false)]
		[Description("Indicates whether the form should be mirrored or not.")]
		[Localizable(true)]
		[Category("Appearance")]
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
				return this.b;
			}
			set
			{
				for (;;)
				{
					IL_00:
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_6C;
						case 1:
							this.b = value;
							num = 0;
							continue;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								if (false)
								{
								}
								if (true)
								{
								}
								break;
							}
							break;
						}
						if (this.b == value)
						{
							goto IL_6E;
						}
						num = 1;
					}
				}
				IL_6C:
				IL_6E:
				base.OnRightToLeftChanged(EventArgs.Empty);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00038CDC File Offset: 0x00036EDC
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams;
				for (;;)
				{
					createParams = base.CreateParams;
					int num = 6;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (base.IsMdiChild)
							{
								num = 12;
								continue;
							}
							goto IL_16E;
						case 1:
							goto IL_16E;
						case 2:
							CFormTemplate.SetWindowLong(createParams.Parent, -20, CFormTemplate.GetWindowLong(createParams.Parent, -20) | 4194304 | 1048576);
							num = 1;
							continue;
						case 3:
							goto IL_199;
						case 4:
							if (!base.DesignMode)
							{
								if (true)
								{
								}
								num = 5;
								continue;
							}
							return createParams;
						case 5:
							createParams.ExStyle = (createParams.ExStyle | 4194304 | 1048576);
							num = 8;
							continue;
						case 6:
							goto IL_4B;
						case 7:
						{
							IntPtr parent;
							if (!parent.Equals(IntPtr.Zero))
							{
								num = 2;
								continue;
							}
							goto IL_16E;
						}
						case 8:
							return createParams;
						case 9:
							num = 10;
							continue;
						case 10:
							if (!base.DesignMode)
							{
								num = 11;
								continue;
							}
							goto IL_199;
						case 11:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_4B;
							default:
								if (false)
								{
								}
								createParams.ExStyle = (createParams.ExStyle | 4194304 | 1048576);
								num = 3;
								continue;
							}
							break;
						case 12:
						{
							IntPtr parent = createParams.Parent;
							num = 7;
							continue;
						}
						}
						break;
						IL_4B:
						if (this.Mirrored)
						{
							num = 9;
							continue;
						}
						return createParams;
						IL_16E:
						num = 4;
						continue;
						IL_199:
						num = 0;
					}
				}
				return createParams;
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00038EA8 File Offset: 0x000370A8
		public CFormTemplate()
		{
			this.a();
			this.SetFont();
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00038F70 File Offset: 0x00037170
		protected override bool ProcessDialogKey(Keys keyData)
		{
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_64;
				case 1:
				{
					CreateParams createParams = this.CreateParams;
					num = 3;
					continue;
				}
				case 2:
					if (!base.Name.Equals("CProgressBar"))
					{
						num = 0;
						continue;
					}
					goto IL_BF;
				case 3:
					if (true)
					{
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_42;
					default:
					{
						if (false)
						{
						}
						CreateParams createParams;
						if (CFormTemplate.GetWindowLong(createParams.Parent, -20) == 0)
						{
							num = 5;
							continue;
						}
						goto IL_BF;
					}
					}
					break;
				case 5:
					goto IL_42;
				}
				if (keyData == Keys.Escape)
				{
					num = 1;
					continue;
				}
				goto IL_BF;
				IL_42:
				num = 2;
			}
			IL_64:
			base.Close();
			return true;
			IL_BF:
			return base.ProcessDialogKey(keyData);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00039044 File Offset: 0x00037244
		protected void SetFont()
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return;
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B;
					}
					if (false)
					{
					}
					this.Font = new Font(CFormTemplate.FONT_FAMILY, CFormTemplate.FONT_SIZE);
					num = 0;
					continue;
				case 3:
					if (0f != CFormTemplate.FONT_SIZE)
					{
						num = 1;
						continue;
					}
					return;
				case 4:
					goto IL_3B;
				}
				if (CFormTemplate.FONT_FAMILY != null)
				{
					if (true)
					{
					}
					num = 4;
					continue;
				}
				break;
				IL_3B:
				num = 3;
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000390F4 File Offset: 0x000372F4
		public static void SetFontProperties(string fontFamily, float fontSize)
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
						if (false)
						{
						}
						num = 3;
						continue;
					}
					break;
				case 2:
					if (true)
					{
					}
					num = 5;
					continue;
				case 3:
					if (0f != fontSize)
					{
						num = 6;
						continue;
					}
					return;
				case 4:
					return;
				case 5:
					if (!fontFamily.Equals(string.Empty))
					{
						num = 0;
						continue;
					}
					return;
				case 6:
					CFormTemplate.FONT_FAMILY = fontFamily;
					CFormTemplate.FONT_SIZE = fontSize;
					num = 4;
					continue;
				}
				if (fontFamily == null)
				{
					break;
				}
				num = 2;
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000391C4 File Offset: 0x000373C4
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
			this.AutoScaleBaseSize = new Size(5, 13);
			base.ClientSize = new Size(292, 273);
			this.Font = new Font("Arial Unicode MS", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Name = "CFormTemplate";
			this.Text = "formtemplate";
		}

		// Token: 0x04000256 RID: 598
		private const int a = -20;

		// Token: 0x04000257 RID: 599
		public const int WS_EX_LAYOUTRTL = 4194304;

		// Token: 0x04000258 RID: 600
		public const int WS_EX_NOINHERITLAYOUT = 1048576;

		// Token: 0x04000259 RID: 601
		private bool b;

		// Token: 0x0400025B RID: 603
		public static string FONT_FAMILY;

		// Token: 0x0400025C RID: 604
		public static float FONT_SIZE;
	}
}
