using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x0200009A RID: 154
	public class SliderSpinEdit : global::System.Windows.Forms.Control
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x0005D870 File Offset: 0x0005BA70
		public SliderSpinEdit()
		{
			this.a();
			this.e = false;
			this.f = false;
			this.g = false;
			this.h = false;
			base.TabStop = false;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0005D8AC File Offset: 0x0005BAAC
		protected override void Dispose(bool disposing)
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
				if (!this.c)
				{
					try
					{
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 1:
								goto IL_AE;
							case 2:
								this.d.Dispose();
								num = 4;
								continue;
							case 3:
								if (this.d != null)
								{
									num = 2;
									continue;
								}
								goto IL_9F;
							case 4:
								goto IL_9F;
							case 5:
								num = 3;
								continue;
							}
							if (disposing)
							{
								num = 5;
								continue;
							}
							IL_9F:
							this.c = true;
							num = 1;
						}
						IL_AE:;
					}
					finally
					{
						base.Dispose(disposing);
					}
				}
				break;
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0005D984 File Offset: 0x0005BB84
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
			this.a = new global::custom_controls.SliderBarControl();
			this.b = new global::custom_controls.CustomNumericUpDown();
			((global::System.ComponentModel.ISupportInitialize)this.b).BeginInit();
			base.SuspendLayout();
			this.a.Maximum = decimal.MaxValue;
			this.a.MaximumValueSide = global::custom_controls.Poles.Right;
			this.a.Minimum = decimal.MinValue;
			this.a.Name = "m_sliderBarControl";
			this.a.StepSize = 1m;
			this.a.TabIndex = 0;
			this.a.Value = decimal.MinValue;
			this.a.ValueChanged += this.b;
			this.b.Name = "m_customNumericUpDown";
			this.b.Minimum = decimal.MinValue;
			this.b.Maximum = decimal.MaxValue;
			this.b.Value = decimal.MinValue;
			this.b.TabIndex = 1;
			this.b.ValueChanged += this.a;
			base.Controls.Add(this.b);
			base.Controls.Add(this.a);
			base.Name = "UserControl1";
			this.Size = new global::System.Drawing.Size(285, 20);
			((global::System.ComponentModel.ISupportInitialize)this.b).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x0005DB48 File Offset: 0x0005BD48
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x0005DB8C File Offset: 0x0005BD8C
		public new int Width
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
				return base.Width;
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
				this.a.Width = (int)((double)value * 0.75);
				string empty = string.Empty;
				this.b.Location = new global::System.Drawing.Point((int)((double)value * 0.78), 0);
				this.b.Width = (int)((double)value * 0.21);
				base.Width = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x0005DC24 File Offset: 0x0005BE24
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x0005DC6C File Offset: 0x0005BE6C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("used to indicate the value load from cp.")]
		public bool LoadingValue
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
				return this.b.LoadingValue;
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
				this.b.LoadingValue = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0005DCB4 File Offset: 0x0005BEB4
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x0005DCF8 File Offset: 0x0005BEF8
		public new global::System.Drawing.Size Size
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
				return base.Size;
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
				value.Height = this.b.Height;
				this.a.Height = value.Height;
				this.Width = value.Width;
				base.Size = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0005DDC0 File Offset: 0x0005BFC0
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x0005DD6C File Offset: 0x0005BF6C
		public new bool Enabled
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
				return this.b.Enabled;
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
				this.b.Enabled = value;
				this.a.Enabled = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x0005DE08 File Offset: 0x0005C008
		public new global::System.Drawing.Font Font
		{
			set
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
				this.b.Font = value;
				this.a.Font = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0005DE5C File Offset: 0x0005C05C
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x0005DEAC File Offset: 0x0005C0AC
		public new global::System.Windows.Forms.RightToLeft RightToLeft
		{
			get
			{
				if (this.a.MaximumValueSide == global::custom_controls.Poles.Right)
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
						return global::System.Windows.Forms.RightToLeft.No;
					}
				}
				return global::System.Windows.Forms.RightToLeft.Yes;
			}
			set
			{
				if (value == global::System.Windows.Forms.RightToLeft.Yes)
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
						this.a.MaximumValueSide = global::custom_controls.Poles.Left;
						return;
					}
				}
				this.a.MaximumValueSide = global::custom_controls.Poles.Right;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0005DF08 File Offset: 0x0005C108
		public global::System.Globalization.NumberFormatInfo NumberFormatInfo
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
				return this.b.NumberFormatInfo;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0005DF50 File Offset: 0x0005C150
		public global::System.Globalization.NumberFormatInfo InvariantNumberFormat
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
				return this.b.InvariantNumberFormat;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0005DF98 File Offset: 0x0005C198
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x0005DFE0 File Offset: 0x0005C1E0
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("Specifies the max  length for input chars.")]
		[global::System.ComponentModel.DefaultValue(1)]
		[global::System.ComponentModel.Bindable(true)]
		public int MaxInputLength
		{
			get
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
				return this.b.MaxInputLength;
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
				this.b.MaxInputLength = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0005E028 File Offset: 0x0005C228
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x0005E070 File Offset: 0x0005C270
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("used to indicate the  text is modified or not.")]
		[global::System.ComponentModel.Category("Customization")]
		public bool TextModified
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
				return this.b.TextModified;
			}
			set
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.b.TextModified = value;
						this.b.Invalidate();
						goto IL_71;
					case 2:
						goto IL_79;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_71:
						num = 2;
						break;
					default:
						if (false)
						{
						}
						if (this.b.TextModified == value)
						{
							goto IL_7B;
						}
						num = 1;
						break;
					}
				}
				IL_79:
				IL_7B:
				if (true)
				{
				}
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0005E100 File Offset: 0x0005C300
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x0005E148 File Offset: 0x0005C348
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Description("used to indicate min/max is loaded or not.")]
		public bool LoadingRange
		{
			get
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
				return this.b.LoadingRange;
			}
			set
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.b.LoadingRange = value;
						this.b.Invalidate();
						goto IL_79;
					case 1:
						return;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_79:
						num = 1;
						break;
					default:
						if (false)
						{
						}
						if (this.b.LoadingRange == value)
						{
							return;
						}
						if (true)
						{
						}
						num = 0;
						break;
					}
				}
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0005E1D8 File Offset: 0x0005C3D8
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x0005E220 File Offset: 0x0005C420
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("used to indicate if blank is allowed in the control.")]
		[global::System.ComponentModel.Category("Customization")]
		public bool BlankAllowed
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
				return this.b.BlankAllowed;
			}
			set
			{
				if (true)
				{
				}
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_5D;
					case 1:
						IL_3A:
						this.b.BlankAllowed = value;
						this.b.Invalidate();
						num = 0;
						continue;
					}
					if (this.b.BlankAllowed != value)
					{
						num = 1;
						continue;
					}
					IL_5D:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					}
					break;
				}
				if (false)
				{
				}
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0005E2B0 File Offset: 0x0005C4B0
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x0005E2F8 File Offset: 0x0005C4F8
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("used to indicate if blank is allowed in the control.")]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Bindable(true)]
		public string Infinity
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
				return this.b.Infinity;
			}
			set
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_7E;
					case 1:
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
						this.b.Infinity = value;
						this.b.Invalidate();
						num = 0;
						continue;
					}
					if (!(this.b.Infinity != value))
					{
						break;
					}
					num = 1;
				}
				IL_7E:
				if (true)
				{
				}
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0005E390 File Offset: 0x0005C590
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x0005E3D8 File Offset: 0x0005C5D8
		public int DecimalPlaces
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
				return this.b.DecimalPlaces;
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
				this.b.DecimalPlaces = value;
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0005E420 File Offset: 0x0005C620
		public void LoadMenuText(string sCut, string sCopy, string sPaste, string sDelete, string sUndo)
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
			this.b.LoadMenuText(sCut, sCopy, sPaste, sDelete, sUndo);
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0005E470 File Offset: 0x0005C670
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x0005E4B8 File Offset: 0x0005C6B8
		public bool Hexadecimal
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
				return this.b.Hexadecimal;
			}
			set
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
				this.b.Hexadecimal = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x0005E548 File Offset: 0x0005C748
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x0005E500 File Offset: 0x0005C700
		public bool ReadOnly
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
				return this.b.ReadOnly;
			}
			set
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
				this.b.ReadOnly = value;
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0005E590 File Offset: 0x0005C790
		public void SetStandardValue(string valueText)
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
			this.b.SetStandardValue(valueText);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0005E5D8 File Offset: 0x0005C7D8
		public void GetStandardValue(ref string standardText)
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
			this.b.GetStandardValue(ref standardText);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0005E620 File Offset: 0x0005C820
		public void CommitUserChanges()
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
			this.b.CommitUserChanges();
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0005E6BC File Offset: 0x0005C8BC
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x0005E668 File Offset: 0x0005C868
		public decimal Increment
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
				return this.b.Increment;
			}
			set
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
				this.b.Increment = value;
				this.a.StepSize = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0005E758 File Offset: 0x0005C958
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x0005E704 File Offset: 0x0005C904
		public decimal Maximum
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
				return this.b.Maximum;
			}
			set
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
				this.a.Maximum = value;
				this.b.Maximum = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0005E7F4 File Offset: 0x0005C9F4
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x0005E7A0 File Offset: 0x0005C9A0
		public decimal Minimum
		{
			get
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
				return this.b.Minimum;
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
				this.a.Minimum = value;
				this.b.Minimum = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0005E890 File Offset: 0x0005CA90
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x0005E83C File Offset: 0x0005CA3C
		public decimal Value
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
				return this.b.Value;
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
				this.b.Value = value;
				this.a.Value = value;
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0005E8D8 File Offset: 0x0005CAD8
		private void b(object A_0, global::System.EventArgs A_1)
		{
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_34;
				case 1:
					if (!this.g)
					{
						num = 2;
						continue;
					}
					return;
				case 2:
					this.OnValueChanged();
					this.g = true;
					goto IL_46;
				case 3:
					return;
				}
				if (this.e)
				{
					num = 0;
					continue;
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
					this.f = true;
					this.g = false;
					this.b.Value = this.a.Value;
					this.b.UpdateText(this.b.Value);
					num = 1;
					continue;
				}
				IL_46:
				num = 3;
			}
			IL_34:
			this.b.Value = this.a.Value;
			this.b.UpdateText(this.b.Value);
			this.e = false;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0005E9F8 File Offset: 0x0005CBF8
		private void a(object A_0, global::System.EventArgs A_1)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (this.LoadingValue)
					{
						num = 3;
						continue;
					}
					num = 4;
					continue;
				case 1:
					goto IL_D5;
				case 2:
					goto IL_6B;
				case 3:
					goto IL_83;
				case 4:
					if (!this.a.MouseDragged)
					{
						num = 6;
						continue;
					}
					goto IL_121;
				case 6:
					goto IL_69;
				case 7:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69;
					default:
						if (false)
						{
						}
						goto IL_6B;
					}
					break;
				case 8:
					this.f = false;
					this.a.Value = this.b.Value;
					num = 2;
					continue;
				}
				if (this.f)
				{
					num = 8;
					continue;
				}
				this.e = true;
				this.a.Value = this.b.Value;
				num = 7;
				continue;
				IL_69:
				this.OnValueChanged();
				num = 1;
				continue;
				IL_6B:
				num = 0;
			}
			IL_83:
			if (true)
			{
			}
			return;
			IL_D5:
			IL_121:
			this.g = true;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0005EB30 File Offset: 0x0005CD30
		protected override void OnGotFocus(global::System.EventArgs e)
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
			this.a.Focus();
			this.a.Invalidate();
			base.OnGotFocus(e);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0005EB8C File Offset: 0x0005CD8C
		protected override void OnEnter(global::System.EventArgs e)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					this.h = true;
					base.OnEnter(e);
					num = 2;
					continue;
				case 2:
					goto IL_56;
				}
				if (this.h)
				{
					break;
				}
				if (true)
				{
				}
				num = 1;
			}
			IL_56:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_56;
			default:
				if (false)
				{
				}
				return;
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0005EC10 File Offset: 0x0005CE10
		protected override void OnLeave(global::System.EventArgs e)
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
			this.h = false;
			this.a.m_bHighlightControl = false;
			this.a.Invalidate();
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000675 RID: 1653 RVA: 0x0005EC6C File Offset: 0x0005CE6C
		// (remove) Token: 0x06000676 RID: 1654 RVA: 0x0005ED04 File Offset: 0x0005CF04
		[global::System.ComponentModel.Description("Event fires when the Value property changes")]
		[global::System.ComponentModel.Category("Action")]
		public event global::custom_controls.SliderSpinEdit.ValueChangedEventHandler ValueChanged
		{
			add
			{
				for (;;)
				{
					IL_1E:
					global::custom_controls.SliderSpinEdit.ValueChangedEventHandler valueChangedEventHandler = this.i;
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							return;
						case 1:
							if (true)
							{
							}
							goto IL_37;
						case 2:
						{
							global::custom_controls.SliderSpinEdit.ValueChangedEventHandler valueChangedEventHandler2;
							if (valueChangedEventHandler == valueChangedEventHandler2)
							{
								num = 0;
								continue;
							}
							goto IL_37;
						}
						}
						break;
						IL_37:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E;
						default:
						{
							if (false)
							{
							}
							global::custom_controls.SliderSpinEdit.ValueChangedEventHandler valueChangedEventHandler2 = valueChangedEventHandler;
							global::custom_controls.SliderSpinEdit.ValueChangedEventHandler value2 = (global::custom_controls.SliderSpinEdit.ValueChangedEventHandler)global::System.Delegate.Combine(valueChangedEventHandler2, value);
							valueChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.SliderSpinEdit.ValueChangedEventHandler>(ref this.i, value2, valueChangedEventHandler2);
							num = 2;
							break;
						}
						}
					}
				}
			}
			remove
			{
				for (;;)
				{
					IL_14:
					global::custom_controls.SliderSpinEdit.ValueChangedEventHandler valueChangedEventHandler = this.i;
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_25;
						case 1:
						{
							if (true)
							{
							}
							global::custom_controls.SliderSpinEdit.ValueChangedEventHandler valueChangedEventHandler2;
							if (valueChangedEventHandler == valueChangedEventHandler2)
							{
								num = 2;
								continue;
							}
							goto IL_25;
						}
						case 2:
							return;
						}
						break;
						IL_25:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
						{
							if (false)
							{
							}
							global::custom_controls.SliderSpinEdit.ValueChangedEventHandler valueChangedEventHandler2 = valueChangedEventHandler;
							global::custom_controls.SliderSpinEdit.ValueChangedEventHandler value2 = (global::custom_controls.SliderSpinEdit.ValueChangedEventHandler)global::System.Delegate.Remove(valueChangedEventHandler2, value);
							valueChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.SliderSpinEdit.ValueChangedEventHandler>(ref this.i, value2, valueChangedEventHandler2);
							num = 1;
							break;
						}
						}
					}
				}
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0005ED9C File Offset: 0x0005CF9C
		protected virtual void OnValueChanged()
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					goto IL_2E;
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2E;
					}
					goto Block_2;
				}
				if (this.i != null)
				{
					num = 1;
					continue;
				}
				return;
				IL_2E:
				this.i(this, new global::System.EventArgs());
				num = 2;
			}
			Block_2:
			if (false)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x040004DB RID: 1243
		private global::custom_controls.SliderBarControl a;

		// Token: 0x040004DC RID: 1244
		private global::custom_controls.CustomNumericUpDown b;

		// Token: 0x040004DD RID: 1245
		private bool c;

		// Token: 0x040004DE RID: 1246
		private global::System.ComponentModel.Container d;

		// Token: 0x040004DF RID: 1247
		private bool e;

		// Token: 0x040004E0 RID: 1248
		private bool f;

		// Token: 0x040004E1 RID: 1249
		private bool g;

		// Token: 0x040004E2 RID: 1250
		private bool h;

		// Token: 0x040004E3 RID: 1251
		private global::custom_controls.SliderSpinEdit.ValueChangedEventHandler i;

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000679 RID: 1657
		public delegate void ValueChangedEventHandler(object sender, global::System.EventArgs e);
	}
}
