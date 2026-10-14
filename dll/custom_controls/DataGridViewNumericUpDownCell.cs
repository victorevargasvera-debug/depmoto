using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000029 RID: 41
	public class DataGridViewNumericUpDownCell : global::System.Windows.Forms.DataGridViewTextBoxCell
	{
		// Token: 0x0600012B RID: 299 RVA: 0x0001B1C0 File Offset: 0x000193C0
		public DataGridViewNumericUpDownCell()
		{
			this.w = new global::custom_controls.CustomNumericUpDown();
			this.w.TabStop = false;
			this.w.EditControl.TabStop = false;
			this.m = 0;
			this.n = 1m;
			this.o = 0m;
			this.p = 100m;
			this.q = false;
			this.v = false;
			this.r = false;
			this.s = null;
			this.t = null;
			this.u = null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0001B254 File Offset: 0x00019454
		private void c()
		{
			for (;;)
			{
				this.w.DecimalPlaces = this.DecimalPlaces;
				this.w.Increment = this.Increment;
				this.w.Maximum = this.Maximum;
				this.w.Minimum = this.Minimum;
				this.w.MaxInputLength = this.MaxInputLength;
				this.w.ThousandsSeparator = this.ThousandsSeparator;
				this.w.BlankAllowed = this.BlankAllowed;
				this.w.Hexadecimal = this.Hexadecimal;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_D7;
					case 1:
						if (this.Infinity != null)
						{
							num = 7;
							continue;
						}
						goto IL_178;
					case 2:
						this.w.None = this.None;
						num = 0;
						continue;
					case 3:
						return;
					case 4:
						if (this.None != null)
						{
							num = 2;
							continue;
						}
						goto IL_D7;
					case 5:
						goto IL_178;
					case 6:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D5;
						default:
							if (false)
							{
							}
							this.w.SpecialDisplayText = this.SpecialDisplayText;
							num = 3;
							continue;
						}
						break;
					case 7:
						goto IL_D5;
					case 8:
						if (this.SpecialDisplayText != null)
						{
							num = 6;
							continue;
						}
						return;
					}
					break;
					IL_D5:
					this.w.Infinity = this.Infinity;
					num = 5;
					continue;
					IL_D7:
					if (true)
					{
					}
					num = 8;
					continue;
					IL_178:
					num = 4;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0001B40C File Offset: 0x0001960C
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0001B450 File Offset: 0x00019650
		[global::System.ComponentModel.DefaultValue(0)]
		public int DecimalPlaces
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
				return this.m;
			}
			set
			{
				int num = 6;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (true)
						{
						}
						goto IL_55;
					case 1:
						if (value > 99)
						{
							num = 0;
							continue;
						}
						num = 4;
						continue;
					case 2:
						return;
					case 3:
						this.b(base.RowIndex, value);
						num = 2;
						continue;
					case 4:
						if (this.m != value)
						{
							num = 3;
							continue;
						}
						return;
					case 5:
						num = 1;
						continue;
					}
					goto IL_2C;
					IL_30:
					num = 5;
					continue;
					IL_2C:
					if (value >= 0)
					{
						goto IL_30;
					}
					IL_55:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_30;
					default:
						goto IL_6B;
					}
				}
				IL_6B:
				if (false)
				{
				}
				throw new global::System.ArgumentOutOfRangeException("The DecimalPlaces property cannot be smaller than 0 or larger than 99.");
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0001B524 File Offset: 0x00019724
		private global::custom_controls.DataGridViewNumericUpDownEditingControl EditingNumericUpDown
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
				return base.DataGridView.EditingControl as global::custom_controls.DataGridViewNumericUpDownEditingControl;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0001B570 File Offset: 0x00019770
		public override global::System.Type EditType
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
				return global::custom_controls.DataGridViewNumericUpDownCell.k;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0001B5B0 File Offset: 0x000197B0
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0001B5F4 File Offset: 0x000197F4
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
				return this.n;
			}
			set
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
					if (value < 0m)
					{
						throw new global::System.ArgumentOutOfRangeException("The Increment property cannot be smaller than 0.");
					}
					break;
				}
				this.b(base.RowIndex, value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0001B658 File Offset: 0x00019858
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0001B69C File Offset: 0x0001989C
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
				return this.p;
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
							goto IL_53;
						default:
							goto IL_71;
						}
						break;
					case 2:
						this.c(base.RowIndex, value);
						goto IL_53;
					}
					if (true)
					{
					}
					if (this.p != value)
					{
						num = 2;
						continue;
					}
					return;
					IL_53:
					num = 0;
				}
				IL_71:
				if (false)
				{
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0001B724 File Offset: 0x00019924
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0001B768 File Offset: 0x00019968
		public decimal Minimum
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
				return this.o;
			}
			set
			{
				if (true)
				{
				}
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						goto IL_60;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_60:
						this.a(base.RowIndex, value);
						num = 1;
						break;
					default:
						if (false)
						{
						}
						if (!(this.o != value))
						{
							return;
						}
						num = 2;
						break;
					}
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0001B7F0 File Offset: 0x000199F0
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0001B834 File Offset: 0x00019A34
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ThousandsSeparator
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
				return this.q;
			}
			set
			{
				for (;;)
				{
					IL_00:
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							return;
						case 2:
							this.b(base.RowIndex, value);
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								if (false)
								{
								}
								num = 0;
								continue;
							}
							break;
						}
						if (true)
						{
						}
						if (this.q == value)
						{
							return;
						}
						num = 2;
					}
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0001B8B8 File Offset: 0x00019AB8
		public override global::System.Type ValueType
		{
			get
			{
				global::System.Type valueType;
				for (;;)
				{
					valueType = base.ValueType;
					if (!(valueType != null))
					{
						goto IL_42;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_26;
					}
				}
				IL_26:
				if (true)
				{
				}
				if (false)
				{
				}
				return valueType;
				IL_42:
				return global::custom_controls.DataGridViewNumericUpDownCell.l;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0001B90C File Offset: 0x00019B0C
		// (set) Token: 0x0600013B RID: 315 RVA: 0x0001B950 File Offset: 0x00019B50
		[global::System.ComponentModel.DefaultValue(false)]
		public bool Hexadecimal
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
				return this.v;
			}
			set
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
						return;
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
							this.a(base.RowIndex, value);
							num = 0;
							continue;
						}
						break;
					}
					IL_24:
					if (this.v != value)
					{
						num = 2;
						continue;
					}
					break;
					goto IL_24;
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0001B9D4 File Offset: 0x00019BD4
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0001BA18 File Offset: 0x00019C18
		[global::System.ComponentModel.DefaultValue(false)]
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
				return this.r;
			}
			set
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.c(base.RowIndex, value);
						num = 2;
						continue;
					case 2:
						goto IL_58;
					}
					IL_1C:
					if (true)
					{
					}
					if (this.r != value)
					{
						num = 0;
						continue;
					}
					IL_58:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C;
					default:
						goto IL_6E;
					}
				}
				IL_6E:
				if (false)
				{
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0001BA9C File Offset: 0x00019C9C
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0001BAE0 File Offset: 0x00019CE0
		[global::System.ComponentModel.DefaultValue("")]
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
				return this.s;
			}
			set
			{
				for (;;)
				{
					IL_00:
					int num = 1;
					for (;;)
					{
						if (true)
						{
						}
						switch (num)
						{
						case 0:
							this.c(base.RowIndex, value);
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								if (false)
								{
								}
								num = 2;
								continue;
							}
							break;
						case 2:
							return;
						}
						if (!(this.s != value))
						{
							return;
						}
						num = 0;
					}
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0001BB68 File Offset: 0x00019D68
		// (set) Token: 0x06000141 RID: 321 RVA: 0x0001BBAC File Offset: 0x00019DAC
		[global::System.ComponentModel.DefaultValue("")]
		public string None
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
				return this.t;
			}
			set
			{
				for (;;)
				{
					IL_00:
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							return;
						case 2:
							this.a(base.RowIndex, value);
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
								num = 0;
								continue;
							}
							break;
						}
						if (!(this.t != value))
						{
							return;
						}
						num = 2;
					}
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0001BC34 File Offset: 0x00019E34
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0001BC78 File Offset: 0x00019E78
		[global::System.ComponentModel.DefaultValue("")]
		public string SpecialDisplayText
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
				return this.u;
			}
			set
			{
				int num = 2;
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
						this.b(base.RowIndex, value);
						goto IL_6F;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6F;
						default:
							if (false)
							{
							}
							break;
						}
						break;
					}
					if (this.u != value)
					{
						num = 1;
						continue;
					}
					break;
					IL_6F:
					num = 0;
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0001BD00 File Offset: 0x00019F00
		public global::System.Globalization.NumberFormatInfo InvariantNumberFormat
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
				this.c();
				return this.w.InvariantNumberFormat;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0001BD4C File Offset: 0x00019F4C
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0001BD9C File Offset: 0x00019F9C
		[global::System.ComponentModel.DefaultValue("")]
		public string StandardValue
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
				string empty = string.Empty;
				this.a(base.RowIndex, ref empty);
				return empty;
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
				this.d(base.RowIndex, value);
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0001BDE4 File Offset: 0x00019FE4
		public override object Clone()
		{
			global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
			for (;;)
			{
				dataGridViewNumericUpDownCell = (base.Clone() as global::custom_controls.DataGridViewNumericUpDownCell);
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_52;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_52;
						default:
							if (false)
							{
							}
							if (dataGridViewNumericUpDownCell != null)
							{
								num = 0;
								continue;
							}
							return dataGridViewNumericUpDownCell;
						}
						break;
					case 2:
						return dataGridViewNumericUpDownCell;
					}
					break;
					IL_52:
					if (true)
					{
					}
					dataGridViewNumericUpDownCell.DecimalPlaces = this.DecimalPlaces;
					dataGridViewNumericUpDownCell.Increment = this.Increment;
					dataGridViewNumericUpDownCell.Maximum = this.Maximum;
					dataGridViewNumericUpDownCell.Minimum = this.Minimum;
					dataGridViewNumericUpDownCell.MaxInputLength = this.MaxInputLength;
					dataGridViewNumericUpDownCell.ThousandsSeparator = this.ThousandsSeparator;
					dataGridViewNumericUpDownCell.BlankAllowed = this.BlankAllowed;
					dataGridViewNumericUpDownCell.Hexadecimal = this.Hexadecimal;
					dataGridViewNumericUpDownCell.Infinity = this.Infinity;
					dataGridViewNumericUpDownCell.None = this.None;
					dataGridViewNumericUpDownCell.SpecialDisplayText = this.SpecialDisplayText;
					num = 2;
				}
			}
			return dataGridViewNumericUpDownCell;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0001BEEC File Offset: 0x0001A0EC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public override void DetachEditingControl()
		{
			for (;;)
			{
				global::System.Windows.Forms.DataGridView dataGridView = base.DataGridView;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						num = 4;
						continue;
					case 1:
						goto IL_3B;
					case 2:
					{
						global::custom_controls.CustomNumericUpDown customNumericUpDown;
						customNumericUpDown.CommitUserChanges();
						global::System.Windows.Forms.TextBox textBox;
						base.Value = textBox.Text;
						textBox.ClearUndo();
						num = 3;
						continue;
					}
					case 3:
						goto IL_10D;
					case 4:
					{
						if (dataGridView.EditingControl == null)
						{
							num = 8;
							continue;
						}
						global::custom_controls.CustomNumericUpDown customNumericUpDown = dataGridView.EditingControl as global::custom_controls.CustomNumericUpDown;
						num = 5;
						continue;
					}
					case 5:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3B;
						default:
						{
							if (false)
							{
							}
							global::custom_controls.CustomNumericUpDown customNumericUpDown;
							if (customNumericUpDown != null)
							{
								num = 7;
								continue;
							}
							goto IL_11A;
						}
						}
						break;
					case 6:
					{
						global::System.Windows.Forms.TextBox textBox;
						if (textBox != null)
						{
							num = 2;
							continue;
						}
						goto IL_11A;
					}
					case 7:
					{
						global::custom_controls.CustomNumericUpDown customNumericUpDown;
						global::System.Windows.Forms.TextBox textBox = customNumericUpDown.Controls[1] as global::System.Windows.Forms.TextBox;
						num = 6;
						continue;
					}
					case 8:
						goto IL_E0;
					}
					break;
					IL_3B:
					if (dataGridView == null)
					{
						goto IL_10F;
					}
					num = 0;
				}
			}
			IL_E0:
			if (true)
			{
			}
			goto IL_10F;
			IL_10D:
			goto IL_11A;
			IL_10F:
			throw new global::System.InvalidOperationException("Cell is detached or its grid has no editing control.");
			IL_11A:
			base.DetachEditingControl();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0001C01C File Offset: 0x0001A21C
		private static global::System.Drawing.Rectangle a(global::System.Drawing.Rectangle A_0, global::System.Windows.Forms.DataGridViewCellStyle A_1)
		{
			for (;;)
			{
				A_0.X++;
				A_0.Width = global::System.Math.Max(0, A_0.Width - 2);
				int num = A_1.Font.Height + 3;
				int num2 = 10;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num2 = 17;
						continue;
					case 1:
					{
						global::System.Windows.Forms.DataGridViewContentAlignment alignment;
						if (alignment != global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft)
						{
							num2 = 13;
							continue;
						}
						goto IL_131;
					}
					case 2:
						return A_0;
					case 3:
						num2 = 1;
						continue;
					case 4:
						num2 = 9;
						continue;
					case 5:
						if (true)
						{
						}
						num2 = 6;
						continue;
					case 6:
					{
						global::System.Windows.Forms.DataGridViewContentAlignment alignment;
						if (alignment != global::System.Windows.Forms.DataGridViewContentAlignment.BottomRight)
						{
							num2 = 16;
							continue;
						}
						goto IL_191;
					}
					case 7:
						return A_0;
					case 8:
					{
						global::System.Windows.Forms.DataGridViewContentAlignment alignment = A_1.Alignment;
						num2 = 14;
						continue;
					}
					case 9:
					{
						global::System.Windows.Forms.DataGridViewContentAlignment alignment;
						if (alignment != global::System.Windows.Forms.DataGridViewContentAlignment.MiddleRight)
						{
							num2 = 11;
							continue;
						}
						goto IL_131;
					}
					case 10:
						if (num < A_0.Height)
						{
							num2 = 8;
							continue;
						}
						return A_0;
					case 11:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							num2 = 2;
							continue;
						}
						break;
					case 12:
						return A_0;
					case 13:
						num2 = 19;
						continue;
					case 14:
					{
						global::System.Windows.Forms.DataGridViewContentAlignment alignment;
						if (alignment <= global::System.Windows.Forms.DataGridViewContentAlignment.MiddleRight)
						{
							num2 = 3;
							continue;
						}
						num2 = 15;
						continue;
					}
					case 15:
					{
						global::System.Windows.Forms.DataGridViewContentAlignment alignment;
						if (alignment != global::System.Windows.Forms.DataGridViewContentAlignment.BottomLeft)
						{
							num2 = 0;
							continue;
						}
						goto IL_191;
					}
					case 16:
						num2 = 12;
						continue;
					case 17:
					{
						global::System.Windows.Forms.DataGridViewContentAlignment alignment;
						if (alignment != global::System.Windows.Forms.DataGridViewContentAlignment.BottomCenter)
						{
							num2 = 5;
							continue;
						}
						goto IL_191;
					}
					case 18:
						return A_0;
					case 19:
					{
						global::System.Windows.Forms.DataGridViewContentAlignment alignment;
						if (alignment != global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter)
						{
							num2 = 4;
							continue;
						}
						goto IL_131;
					}
					}
					break;
					IL_131:
					A_0.Y += (A_0.Height - num) / 2;
					num2 = 7;
					continue;
					IL_191:
					A_0.Y += A_0.Height - num;
					num2 = 18;
				}
			}
			return A_0;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0001C274 File Offset: 0x0001A474
		protected override global::System.Drawing.Rectangle GetErrorIconBounds(global::System.Drawing.Graphics graphics, global::System.Windows.Forms.DataGridViewCellStyle cellStyle, int rowIndex)
		{
			if (true)
			{
			}
			global::System.Drawing.Rectangle errorIconBounds;
			for (;;)
			{
				errorIconBounds = base.GetErrorIconBounds(graphics, cellStyle, rowIndex);
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					num = 3;
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 0:
						return errorIconBounds;
					case 1:
						return errorIconBounds;
					case 2:
						errorIconBounds.X = errorIconBounds.Left + 16;
						num = 0;
						continue;
					case 3:
						if (base.DataGridView.RightToLeft == global::System.Windows.Forms.RightToLeft.Yes)
						{
							num = 2;
							continue;
						}
						errorIconBounds.X = errorIconBounds.Left - 16;
						num = 1;
						continue;
					}
					break;
				}
			}
			return errorIconBounds;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001C32C File Offset: 0x0001A52C
		protected override global::System.Drawing.Size GetPreferredSize(global::System.Drawing.Graphics graphics, global::System.Windows.Forms.DataGridViewCellStyle cellStyle, int rowIndex, global::System.Drawing.Size constraintSize)
		{
			int num = 0;
			global::System.Drawing.Size preferredSize;
			for (;;)
			{
				switch (num)
				{
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					default:
						goto IL_4A;
					}
					break;
				case 2:
					goto IL_6A;
				case 3:
					if (constraintSize.Width == 0)
					{
						num = 4;
						continue;
					}
					return preferredSize;
				case 4:
					preferredSize.Width += 24;
					num = 2;
					continue;
				}
				if (base.DataGridView == null)
				{
					num = 1;
					continue;
				}
				preferredSize = base.GetPreferredSize(graphics, cellStyle, rowIndex, constraintSize);
				IL_80:
				num = 3;
			}
			IL_4A:
			if (false)
			{
			}
			return new global::System.Drawing.Size(-1, -1);
			IL_6A:
			if (true)
			{
			}
			return preferredSize;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0001C3EC File Offset: 0x0001A5EC
		public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle)
		{
			for (;;)
			{
				base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
				global::custom_controls.CustomNumericUpDown customNumericUpDown = base.DataGridView.EditingControl as global::custom_controls.CustomNumericUpDown;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
					{
						customNumericUpDown.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
						customNumericUpDown.DecimalPlaces = this.DecimalPlaces;
						customNumericUpDown.Increment = this.Increment;
						customNumericUpDown.Maximum = this.Maximum;
						customNumericUpDown.Minimum = this.Minimum;
						customNumericUpDown.MaxInputLength = this.MaxInputLength;
						customNumericUpDown.ThousandsSeparator = this.ThousandsSeparator;
						customNumericUpDown.BlankAllowed = this.BlankAllowed;
						customNumericUpDown.Hexadecimal = this.Hexadecimal;
						customNumericUpDown.Infinity = this.Infinity;
						customNumericUpDown.None = this.None;
						customNumericUpDown.SpecialDisplayText = this.SpecialDisplayText;
						string text = initialFormattedValue as string;
						num = 1;
						continue;
					}
					case 1:
					{
						string text;
						if (text == null)
						{
							num = 4;
							continue;
						}
						customNumericUpDown.Text = text;
						customNumericUpDown.ControlText = text;
						customNumericUpDown.FormattedValue = customNumericUpDown.ControlText;
						num = 5;
						continue;
					}
					case 2:
						goto IL_42;
					case 3:
						goto IL_BD;
					case 4:
						customNumericUpDown.Text = string.Empty;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_42;
						default:
							if (false)
							{
							}
							num = 3;
							continue;
						}
						break;
					case 5:
						goto IL_7C;
					}
					break;
					IL_42:
					if (customNumericUpDown == null)
					{
						goto IL_175;
					}
					if (true)
					{
					}
					num = 0;
				}
			}
			IL_7C:
			IL_BD:
			IL_175:
			this.c(rowIndex, this.Maximum);
			this.a(rowIndex, this.Minimum);
			this.b(rowIndex, this.Increment);
			this.c(rowIndex, this.Infinity);
			this.a(rowIndex, this.None);
			this.b(rowIndex, this.SpecialDisplayText);
			this.a(rowIndex, this.MaxInputLength);
			this.a(rowIndex, this.Hexadecimal);
			this.c(rowIndex, this.BlankAllowed);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0001C5E4 File Offset: 0x0001A7E4
		public string GetFormattedText(string value)
		{
			if (value != null)
			{
				for (;;)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					}
					break;
				}
				if (true)
				{
				}
				if (false)
				{
				}
				this.c();
				this.w.SetStandardValue(value);
				return this.w.FormattedValue;
			}
			return string.Empty;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0001C648 File Offset: 0x0001A848
		public override bool KeyEntersEditMode(global::System.Windows.Forms.KeyEventArgs e)
		{
			switch (0)
			{
			default:
			{
				global::System.Windows.Forms.Keys keys;
				char c;
				global::System.Windows.Forms.Keys keys3;
				for (;;)
				{
					IL_0E:
					int num = 14;
					for (;;)
					{
						string negativeSign;
						global::System.Windows.Forms.Keys keys2;
						switch (num)
						{
						case 0:
							keys = (global::System.Windows.Forms.Keys)global::custom_controls.a.VkKeyScan(negativeSign[0]);
							num = 25;
							continue;
						case 1:
							num = 42;
							continue;
						case 2:
							num = 36;
							continue;
						case 3:
							goto IL_487;
						case 4:
							if (keys != e.KeyCode)
							{
								num = 46;
								continue;
							}
							goto IL_25E;
						case 5:
							num = 13;
							continue;
						case 6:
							goto IL_14B;
						case 7:
							num = 19;
							continue;
						case 8:
							if (base.Value != null)
							{
								num = 3;
								continue;
							}
							return true;
						case 9:
						{
							bool flag;
							if (flag)
							{
								num = 30;
								continue;
							}
							goto IL_3E6;
						}
						case 10:
							goto IL_22F;
						case 11:
							goto IL_2CF;
						case 12:
							if (!e.Shift)
							{
								num = 7;
								continue;
							}
							return false;
						case 13:
							if (e.KeyCode > global::System.Windows.Forms.Keys.D9)
							{
								num = 6;
								continue;
							}
							return true;
						case 15:
						{
							if (e.KeyCode == keys2)
							{
								num = 38;
								continue;
							}
							bool flag = e.Modifiers == global::System.Windows.Forms.Keys.Shift;
							num = 9;
							continue;
						}
						case 16:
							if (!e.Control)
							{
								num = 31;
								continue;
							}
							return false;
						case 17:
							return false;
						case 18:
							num = 16;
							continue;
						case 19:
							if (!e.Alt)
							{
								num = 18;
								continue;
							}
							return false;
						case 20:
							if (!string.IsNullOrEmpty(negativeSign))
							{
								num = 2;
								continue;
							}
							goto IL_F6;
						case 21:
							goto IL_259;
						case 22:
							num = 43;
							continue;
						case 23:
							if (e.KeyCode >= global::System.Windows.Forms.Keys.NumPad0)
							{
								num = 22;
								continue;
							}
							goto IL_300;
						case 24:
							if (!char.IsDigit((char)e.KeyCode))
							{
								num = 40;
								continue;
							}
							goto IL_25E;
						case 25:
							goto IL_F6;
						case 26:
							if (global::System.Windows.Forms.Keys.Subtract == e.KeyCode)
							{
								num = 32;
								continue;
							}
							return false;
						case 27:
							if (this.Hexadecimal)
							{
								num = 34;
								continue;
							}
							goto IL_300;
						case 28:
							if (e.KeyCode > global::System.Windows.Forms.Keys.NumPad9)
							{
								num = 35;
								continue;
							}
							goto IL_25E;
						case 29:
							num = 44;
							continue;
						case 30:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_0E;
							default:
							{
								if (false)
								{
								}
								c = (char)e.KeyValue;
								char c2 = c;
								num = 37;
								continue;
							}
							}
							break;
						case 31:
							return true;
						case 32:
							if (true)
							{
							}
							goto IL_25E;
						case 33:
							if (e.KeyCode >= global::System.Windows.Forms.Keys.A)
							{
								num = 1;
								continue;
							}
							goto IL_2CF;
						case 34:
							num = 33;
							continue;
						case 35:
							goto IL_175;
						case 36:
							if (negativeSign.Length == 1)
							{
								num = 0;
								continue;
							}
							goto IL_F6;
						case 37:
						{
							char c2;
							if (c2 != '0')
							{
								num = 29;
								continue;
							}
							goto IL_523;
						}
						case 38:
							num = 8;
							continue;
						case 39:
							if (e.KeyCode >= global::System.Windows.Forms.Keys.NumPad0)
							{
								num = 45;
								continue;
							}
							goto IL_175;
						case 40:
							num = 39;
							continue;
						case 41:
							if (e.KeyCode >= global::System.Windows.Forms.Keys.D0)
							{
								num = 5;
								continue;
							}
							goto IL_14B;
						case 42:
							if (e.KeyCode > global::System.Windows.Forms.Keys.F)
							{
								num = 11;
								continue;
							}
							return true;
						case 43:
							if (e.KeyCode <= global::System.Windows.Forms.Keys.NumPad9)
							{
								num = 21;
								continue;
							}
							goto IL_300;
						case 44:
						{
							char c2;
							if (c2 == '9')
							{
								num = 10;
								continue;
							}
							goto IL_3E6;
						}
						case 45:
							num = 28;
							continue;
						case 46:
							num = 26;
							continue;
						}
						if (e == null)
						{
							num = 17;
							continue;
						}
						global::System.Globalization.NumberFormatInfo numberFormat = global::System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
						keys = global::System.Windows.Forms.Keys.None;
						negativeSign = numberFormat.NegativeSign;
						num = 27;
						continue;
						IL_F6:
						num = 24;
						continue;
						IL_14B:
						num = 23;
						continue;
						IL_175:
						num = 4;
						continue;
						IL_25E:
						num = 12;
						continue;
						IL_2CF:
						num = 41;
						continue;
						IL_300:
						keys3 = (e.KeyCode & global::System.Windows.Forms.Keys.Decimal);
						keys2 = (global::System.Windows.Forms.Keys)global::custom_controls.a.VkKeyScan((char)keys3);
						num = 15;
						continue;
						IL_3E6:
						num = 20;
					}
				}
				return false;
				IL_22F:
				keys = (global::System.Windows.Forms.Keys)global::custom_controls.a.VkKeyScan(c);
				bool flag2 = this.w.HasInvalidFormat(0, base.Value.ToString(), '(');
				return !flag2;
				IL_259:
				return true;
				IL_487:
				return this.w.HasInvalidFormat(0, base.Value.ToString(), (char)keys3);
				IL_523:
				flag2 = this.w.HasInvalidFormat(0, base.Value.ToString(), '(');
				return !flag2;
			}
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0001CBC0 File Offset: 0x0001ADC0
		private void a()
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (!base.DataGridView.Disposing)
					{
						num = 6;
						continue;
					}
					goto IL_E5;
				case 2:
					if (base.RowIndex == -1)
					{
						num = 5;
						continue;
					}
					base.DataGridView.UpdateCellValue(base.ColumnIndex, base.RowIndex);
					num = 4;
					continue;
				case 3:
					if (!base.DataGridView.IsDisposed)
					{
						num = 7;
						continue;
					}
					goto IL_E5;
				case 4:
					goto IL_BB;
				case 5:
					return;
				case 6:
					num = 2;
					continue;
				case 7:
					num = 0;
					continue;
				case 8:
					num = 3;
					continue;
				}
				if (base.DataGridView == null)
				{
					goto IL_E5;
				}
				if (true)
				{
				}
				num = 8;
			}
			return;
			IL_BB:
			IL_E5:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
				if (false)
				{
				}
				return;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001CCD0 File Offset: 0x0001AED0
		private bool a(int A_0)
		{
			int num = 1;
			global::custom_controls.DataGridViewNumericUpDownEditingControl dataGridViewNumericUpDownEditingControl;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_A7;
				case 2:
					num = 5;
					continue;
				case 3:
					goto IL_62;
				case 4:
					if (dataGridViewNumericUpDownEditingControl != null)
					{
						if (true)
						{
						}
						num = 3;
						continue;
					}
					return false;
				case 5:
					if (base.DataGridView == null)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A7;
						}
						if (false)
						{
						}
						num = 0;
						continue;
					}
					dataGridViewNumericUpDownEditingControl = (base.DataGridView.EditingControl as global::custom_controls.DataGridViewNumericUpDownEditingControl);
					num = 4;
					continue;
				}
				if (A_0 == -1)
				{
					return false;
				}
				num = 2;
			}
			IL_62:
			return A_0 == ((global::System.Windows.Forms.IDataGridViewEditingControl)dataGridViewNumericUpDownEditingControl).EditingControlRowIndex;
			IL_A7:
			return false;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0001CD94 File Offset: 0x0001AF94
		protected override void Paint(global::System.Drawing.Graphics graphics, global::System.Drawing.Rectangle clipBounds, global::System.Drawing.Rectangle cellBounds, int rowIndex, global::System.Windows.Forms.DataGridViewElementStates cellState, object value, object formattedValue, string errorText, global::System.Windows.Forms.DataGridViewCellStyle cellStyle, global::System.Windows.Forms.DataGridViewAdvancedBorderStyle advancedBorderStyle, global::System.Windows.Forms.DataGridViewPaintParts paintParts)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				int num = 3;
				for (;;)
				{
					bool flag;
					bool flag2;
					bool flag3;
					global::System.Drawing.Rectangle a_;
					global::custom_controls.CustomNumericUpDown customNumericUpDown;
					global::System.Drawing.Point currentCellAddress;
					bool flag5;
					switch (num)
					{
					case 0:
						num = 17;
						continue;
					case 1:
						if (global::custom_controls.DataGridViewNumericUpDownCell.a(paintParts, global::System.Windows.Forms.DataGridViewPaintParts.ContentForeground))
						{
							num = 16;
							continue;
						}
						goto IL_625;
					case 2:
						flag = false;
						goto IL_79C;
					case 4:
						return;
					case 5:
						if (flag2)
						{
							num = 0;
							continue;
						}
						num = 2;
						continue;
					case 6:
						goto IL_5D1;
					case 7:
						goto IL_AF;
					case 8:
						base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, global::System.Windows.Forms.DataGridViewPaintParts.ErrorIcon);
						num = 4;
						continue;
					case 9:
						if (global::custom_controls.DataGridViewNumericUpDownCell.a(paintParts, global::System.Windows.Forms.DataGridViewPaintParts.ErrorIcon))
						{
							num = 8;
							continue;
						}
						return;
					case 10:
						if (!flag3)
						{
							num = 24;
							continue;
						}
						return;
					case 11:
						if (base.DataGridView.RightToLeft == global::System.Windows.Forms.RightToLeft.Yes)
						{
							num = 19;
							continue;
						}
						a_.Offset(cellStyle.Padding.Left, cellStyle.Padding.Top);
						num = 7;
						continue;
					case 12:
						goto IL_AF;
					case 13:
						num = 11;
						continue;
					case 14:
						goto IL_7BD;
					case 15:
						try
						{
							for (;;)
							{
								customNumericUpDown.TabStop = false;
								customNumericUpDown.EditControl.TabStop = false;
								customNumericUpDown.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
								customNumericUpDown.Maximum = 7922816251426433759354395034m;
								customNumericUpDown.Minimum = -7922816251426433759354395034m;
								num = 22;
								for (;;)
								{
									global::System.Drawing.Rectangle rectangle;
									bool flag4;
									global::System.Drawing.Color color;
									switch (num)
									{
									case 0:
										goto IL_46A;
									case 1:
										goto IL_58C;
									case 2:
										if (rectangle.Height > 0)
										{
											num = 4;
											continue;
										}
										goto IL_580;
									case 3:
										if (rectangle.Width > 0)
										{
											num = 16;
											continue;
										}
										goto IL_580;
									case 4:
									{
										global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(rectangle.Width, rectangle.Height);
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_264;
										default:
											if (false)
											{
											}
											num = 15;
											continue;
										}
										break;
									}
									case 5:
										if (flag4)
										{
											num = 19;
											continue;
										}
										goto IL_225;
									case 6:
										num = 17;
										continue;
									case 7:
										goto IL_24D;
									case 8:
										if (global::custom_controls.DataGridViewNumericUpDownCell.a(paintParts, global::System.Windows.Forms.DataGridViewPaintParts.SelectionBackground))
										{
											num = 13;
											continue;
										}
										goto IL_225;
									case 9:
										if (color.A < 255)
										{
											num = 10;
											continue;
										}
										goto IL_488;
									case 10:
										color = global::System.Drawing.Color.FromArgb(255, color);
										num = 11;
										continue;
									case 11:
										goto IL_488;
									case 12:
										goto IL_2B6;
									case 13:
										goto IL_41C;
									case 14:
										if (global::custom_controls.DataGridViewNumericUpDownCell.a(paintParts, global::System.Windows.Forms.DataGridViewPaintParts.Background))
										{
											num = 18;
											continue;
										}
										goto IL_24D;
									case 15:
										try
										{
											global::System.Drawing.Bitmap bitmap;
											customNumericUpDown.DrawToBitmap(bitmap, rectangle);
											graphics.DrawImage(bitmap, new global::System.Drawing.Rectangle(a_.Location, a_.Size), rectangle, global::System.Drawing.GraphicsUnit.Pixel);
											goto IL_580;
										}
										finally
										{
											num = 1;
											for (;;)
											{
												global::System.Drawing.Bitmap bitmap;
												switch (num)
												{
												case 0:
													goto IL_419;
												case 2:
													((global::System.IDisposable)bitmap).Dispose();
													num = 0;
													continue;
												}
												if (bitmap == null)
												{
													break;
												}
												num = 2;
											}
											IL_419:;
										}
										goto IL_41C;
									case 16:
										num = 2;
										continue;
									case 17:
										if (!customNumericUpDown.Parent.Visible)
										{
											num = 0;
											continue;
										}
										goto IL_2B6;
									case 18:
										num = 9;
										continue;
									case 19:
										color = cellStyle.SelectionBackColor;
										customNumericUpDown.ForeColor = cellStyle.SelectionForeColor;
										num = 20;
										continue;
									case 20:
										goto IL_440;
									case 21:
										goto IL_440;
									case 22:
										if (customNumericUpDown.Parent != null)
										{
											num = 6;
											continue;
										}
										goto IL_46A;
									}
									break;
									IL_225:
									color = cellStyle.BackColor;
									customNumericUpDown.ForeColor = cellStyle.ForeColor;
									num = 21;
									continue;
									IL_264:
									num = 3;
									continue;
									IL_24D:
									rectangle = new global::System.Drawing.Rectangle(0, 0, a_.Width, a_.Height);
									goto IL_264;
									IL_2B6:
									customNumericUpDown.TextAlign = global::custom_controls.DataGridViewNumericUpDownCell.a(cellStyle.Alignment);
									customNumericUpDown.DecimalPlaces = this.DecimalPlaces;
									customNumericUpDown.ThousandsSeparator = this.ThousandsSeparator;
									customNumericUpDown.Hexadecimal = this.Hexadecimal;
									customNumericUpDown.BlankAllowed = this.BlankAllowed;
									customNumericUpDown.MaxInputLength = this.MaxInputLength;
									customNumericUpDown.Font = cellStyle.Font;
									customNumericUpDown.Width = a_.Width;
									customNumericUpDown.Height = a_.Height;
									customNumericUpDown.RightToLeft = base.DataGridView.RightToLeft;
									customNumericUpDown.Location = new global::System.Drawing.Point(0, -customNumericUpDown.Height - 100);
									customNumericUpDown.SpecialDisplayText = this.SpecialDisplayText;
									customNumericUpDown.Text = (formattedValue as string);
									flag4 = ((cellState & global::System.Windows.Forms.DataGridViewElementStates.Selected) != global::System.Windows.Forms.DataGridViewElementStates.None);
									num = 8;
									continue;
									IL_41C:
									num = 5;
									continue;
									IL_440:
									num = 14;
									continue;
									IL_46A:
									customNumericUpDown.Parent = base.DataGridView;
									num = 12;
									continue;
									IL_488:
									customNumericUpDown.BackColor = color;
									num = 7;
									continue;
									IL_580:
									num = 1;
								}
							}
							IL_58C:
							goto IL_625;
						}
						finally
						{
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									((global::System.IDisposable)customNumericUpDown).Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_5CE;
								}
								if (customNumericUpDown == null)
								{
									break;
								}
								num = 0;
							}
							IL_5CE:;
						}
						goto IL_5D1;
					case 16:
					{
						global::System.Drawing.Rectangle rectangle2 = this.BorderWidths(advancedBorderStyle);
						a_ = cellBounds;
						a_.Offset(rectangle2.X, rectangle2.Y);
						a_.Width -= rectangle2.Right;
						a_.Height -= rectangle2.Bottom;
						num = 18;
						continue;
					}
					case 17:
						flag = (base.DataGridView.EditingControl != null);
						goto IL_79C;
					case 18:
						if (cellStyle.Padding != global::System.Windows.Forms.Padding.Empty)
						{
							num = 13;
							continue;
						}
						goto IL_7BD;
					case 19:
						a_.Offset(cellStyle.Padding.Right, cellStyle.Padding.Top);
						num = 12;
						continue;
					case 20:
						return;
					case 21:
						flag5 = (currentCellAddress.Y == rowIndex);
						goto IL_6CE;
					case 22:
						flag5 = false;
						goto IL_6CE;
					case 23:
						if (currentCellAddress.X == base.ColumnIndex)
						{
							num = 6;
							continue;
						}
						num = 22;
						continue;
					case 24:
						num = 1;
						continue;
					}
					if (base.DataGridView == null)
					{
						num = 20;
						continue;
					}
					base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts & ~(global::System.Windows.Forms.DataGridViewPaintParts.ContentForeground | global::System.Windows.Forms.DataGridViewPaintParts.ErrorIcon));
					currentCellAddress = base.DataGridView.CurrentCellAddress;
					num = 23;
					continue;
					IL_AF:
					a_.Width -= cellStyle.Padding.Horizontal;
					a_.Height -= cellStyle.Padding.Vertical;
					num = 14;
					continue;
					IL_5D1:
					num = 21;
					continue;
					IL_625:
					num = 9;
					continue;
					IL_6CE:
					flag2 = flag5;
					num = 5;
					continue;
					IL_79C:
					flag3 = flag;
					num = 10;
					continue;
					IL_7BD:
					a_ = global::custom_controls.DataGridViewNumericUpDownCell.a(a_, cellStyle);
					customNumericUpDown = new global::custom_controls.CustomNumericUpDown();
					num = 15;
				}
				return;
			}
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0001D618 File Offset: 0x0001B818
		private static bool a(global::System.Windows.Forms.DataGridViewPaintParts A_0, global::System.Windows.Forms.DataGridViewPaintParts A_1)
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
			return (A_0 & A_1) != global::System.Windows.Forms.DataGridViewPaintParts.None;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0001D65C File Offset: 0x0001B85C
		public override void PositionEditingControl(bool setLocation, bool setSize, global::System.Drawing.Rectangle cellBounds, global::System.Drawing.Rectangle cellClip, global::System.Windows.Forms.DataGridViewCellStyle cellStyle, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow)
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
			global::System.Drawing.Rectangle a_ = this.PositionEditingPanel(cellBounds, cellClip, cellStyle, singleVerticalBorderAdded, singleHorizontalBorderAdded, isFirstDisplayedColumn, isFirstDisplayedRow);
			a_ = global::custom_controls.DataGridViewNumericUpDownCell.a(a_, cellStyle);
			base.DataGridView.EditingControl.Location = new global::System.Drawing.Point(a_.X, a_.Y);
			base.DataGridView.EditingControl.Size = new global::System.Drawing.Size(a_.Width, a_.Height);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0001D6FC File Offset: 0x0001B8FC
		internal void b(int A_0, int A_1)
		{
			for (;;)
			{
				if (true)
				{
				}
				this.m = A_1;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.EditingNumericUpDown.DecimalPlaces = A_1;
						num = 1;
						continue;
					case 1:
						return;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						case 1:
							goto IL_4B;
						default:
							goto IL_4B;
						}
						IL_5A:
						num = 0;
						continue;
						IL_4B:
						if (false)
						{
						}
						if (this.a(A_0))
						{
							goto IL_5A;
						}
						return;
					}
					break;
				}
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0001D784 File Offset: 0x0001B984
		internal void b(int A_0, decimal A_1)
		{
			for (;;)
			{
				this.n = A_1;
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					num = 1;
					break;
				}
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
						if (this.a(A_0))
						{
							num = 2;
							continue;
						}
						return;
					case 2:
						this.EditingNumericUpDown.Increment = A_1;
						num = 0;
						continue;
					}
					break;
				}
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0001D80C File Offset: 0x0001BA0C
		internal void c(int A_0, decimal A_1)
		{
			for (;;)
			{
				IL_20:
				this.p = A_1;
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A7:
					num = 4;
					break;
				default:
					if (false)
					{
					}
					num = 5;
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_93;
					case 2:
						goto IL_9E;
					case 3:
						this.o = this.p;
						num = 1;
						continue;
					case 4:
						this.EditingNumericUpDown.Maximum = A_1;
						if (true)
						{
						}
						num = 0;
						continue;
					case 5:
						if (this.o > this.p)
						{
							num = 3;
							continue;
						}
						goto IL_93;
					}
					goto IL_20;
					IL_93:
					num = 2;
				}
				IL_9E:
				if (this.a(A_0))
				{
					goto IL_A7;
				}
				break;
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0001D8E8 File Offset: 0x0001BAE8
		internal void a(int A_0, decimal A_1)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A1:
				num = 4;
				break;
			default:
				if (false)
				{
				}
				goto IL_46;
			}
			for (;;)
			{
				IL_1E:
				switch (num)
				{
				case 0:
					goto IL_98;
				case 1:
					this.p = A_1;
					num = 3;
					continue;
				case 2:
					goto IL_86;
				case 3:
					goto IL_90;
				case 4:
					this.EditingNumericUpDown.Minimum = A_1;
					num = 2;
					continue;
				case 5:
					if (this.o > this.p)
					{
						num = 1;
						continue;
					}
					goto IL_90;
				}
				goto IL_46;
				IL_90:
				num = 0;
			}
			IL_86:
			if (true)
			{
			}
			return;
			IL_98:
			if (this.a(A_0))
			{
				goto IL_A1;
			}
			return;
			IL_46:
			this.o = A_1;
			num = 5;
			goto IL_1E;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0001D9B8 File Offset: 0x0001BBB8
		internal void b(int A_0, bool A_1)
		{
			for (;;)
			{
				IL_14:
				this.q = A_1;
				for (;;)
				{
					IL_1B:
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.EditingNumericUpDown.ThousandsSeparator = A_1;
							num = 1;
							continue;
						case 1:
							return;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1B;
							default:
								if (true)
								{
								}
								if (false)
								{
								}
								if (this.a(A_0))
								{
									num = 0;
									continue;
								}
								return;
							}
							break;
						}
						goto IL_14;
					}
				}
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0001DA40 File Offset: 0x0001BC40
		internal void a(int A_0, int A_1)
		{
			for (;;)
			{
				IL_14:
				this.MaxInputLength = A_1;
				for (;;)
				{
					IL_1B:
					int num = 1;
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
								goto IL_1B;
							default:
								if (true)
								{
								}
								if (false)
								{
								}
								if (this.a(A_0))
								{
									num = 2;
									continue;
								}
								return;
							}
							break;
						case 2:
							this.EditingNumericUpDown.MaxInputLength = A_1;
							num = 0;
							continue;
						}
						goto IL_14;
					}
				}
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0001DAC8 File Offset: 0x0001BCC8
		internal void c(int A_0, bool A_1)
		{
			for (;;)
			{
				IL_30:
				if (true)
				{
				}
				this.r = A_1;
				for (;;)
				{
					IL_3F:
					int num = 2;
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3F;
						default:
							if (false)
							{
							}
							switch (num)
							{
							case 0:
								this.EditingNumericUpDown.BlankAllowed = A_1;
								num = 1;
								continue;
							case 1:
								return;
							case 2:
								if (this.a(A_0))
								{
									num = 0;
									continue;
								}
								return;
							}
							goto IL_30;
						}
					}
				}
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0001DB50 File Offset: 0x0001BD50
		internal void c(int A_0, string A_1)
		{
			for (;;)
			{
				IL_38:
				this.s = A_1;
				for (;;)
				{
					IL_3F:
					int num = 1;
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3F;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							switch (num)
							{
							case 0:
								this.EditingNumericUpDown.Infinity = A_1;
								num = 2;
								continue;
							case 1:
								if (this.a(A_0))
								{
									num = 0;
									continue;
								}
								return;
							case 2:
								return;
							}
							goto IL_38;
						}
					}
				}
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0001DBD8 File Offset: 0x0001BDD8
		internal void a(int A_0, string A_1)
		{
			for (;;)
			{
				IL_14:
				this.t = A_1;
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_5A:
					num = 1;
					break;
				default:
					if (true)
					{
					}
					if (false)
					{
					}
					num = 0;
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_51;
					case 1:
						this.EditingNumericUpDown.None = A_1;
						num = 2;
						continue;
					case 2:
						return;
					}
					goto IL_14;
				}
				IL_51:
				if (this.a(A_0))
				{
					goto IL_5A;
				}
				break;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0001DC60 File Offset: 0x0001BE60
		internal void b(int A_0, string A_1)
		{
			for (;;)
			{
				IL_14:
				this.u = A_1;
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_52:
					num = 1;
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
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (true)
						{
						}
						this.EditingNumericUpDown.SpecialDisplayText = A_1;
						num = 0;
						continue;
					case 2:
						goto IL_49;
					}
					goto IL_14;
				}
				IL_49:
				if (this.a(A_0))
				{
					goto IL_52;
				}
				break;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0001DCE8 File Offset: 0x0001BEE8
		internal void d(int A_0, string A_1)
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
						return;
					default:
						if (false)
						{
						}
						this.EditingNumericUpDown.StandardValue = A_1;
						num = 2;
						continue;
					}
					break;
				case 2:
					goto IL_69;
				}
				if (!this.a(A_0))
				{
					return;
				}
				num = 0;
			}
			IL_69:
			if (true)
			{
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0001DD68 File Offset: 0x0001BF68
		internal void a(int A_0, bool A_1)
		{
			for (;;)
			{
				this.v = A_1;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (true)
						{
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							if (false)
							{
							}
							this.EditingNumericUpDown.Hexadecimal = A_1;
							num = 1;
							continue;
						}
						break;
					case 1:
						return;
					case 2:
						if (this.a(A_0))
						{
							num = 0;
							continue;
						}
						return;
					}
					break;
				}
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0001DDF0 File Offset: 0x0001BFF0
		internal void a(int A_0, ref string A_1)
		{
			int num = 2;
			for (;;)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 0:
					return;
				case 1:
					A_1 = this.EditingNumericUpDown.StandardValue;
					num = 0;
					continue;
				}
				IL_24:
				if (!this.a(A_0))
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
					num = 1;
					continue;
				}
				goto IL_24;
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0001DE74 File Offset: 0x0001C074
		public override string ToString()
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
			return string.Concat(new string[]
			{
				"DataGridViewNumericUpDownCell { ColumnIndex=",
				base.ColumnIndex.ToString(global::System.Globalization.CultureInfo.CurrentCulture),
				", RowIndex=",
				base.RowIndex.ToString(global::System.Globalization.CultureInfo.CurrentCulture),
				" }"
			});
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0001DF00 File Offset: 0x0001C100
		internal static global::System.Windows.Forms.HorizontalAlignment a(global::System.Windows.Forms.DataGridViewContentAlignment A_0)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_74:
				num = 0;
				break;
			default:
				if (false)
				{
				}
				num = 1;
				break;
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_7C;
				case 2:
					return global::System.Windows.Forms.HorizontalAlignment.Right;
				case 3:
					goto IL_61;
				}
				if ((A_0 & global::custom_controls.DataGridViewNumericUpDownCell.i) != global::System.Windows.Forms.DataGridViewContentAlignment.NotSet)
				{
					num = 2;
				}
				else
				{
					num = 3;
				}
			}
			return global::System.Windows.Forms.HorizontalAlignment.Right;
			IL_61:
			if ((A_0 & global::custom_controls.DataGridViewNumericUpDownCell.j) != global::System.Windows.Forms.DataGridViewContentAlignment.NotSet)
			{
				goto IL_74;
			}
			return global::System.Windows.Forms.HorizontalAlignment.Left;
			IL_7C:
			if (true)
			{
			}
			return global::System.Windows.Forms.HorizontalAlignment.Center;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0001DF90 File Offset: 0x0001C190
		// Note: this type is marked as 'beforefieldinit'.
		static DataGridViewNumericUpDownCell()
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
			global::custom_controls.DataGridViewNumericUpDownCell.i = (global::System.Windows.Forms.DataGridViewContentAlignment)1092;
			global::custom_controls.DataGridViewNumericUpDownCell.j = (global::System.Windows.Forms.DataGridViewContentAlignment)546;
			global::custom_controls.DataGridViewNumericUpDownCell.d = 1m;
			global::custom_controls.DataGridViewNumericUpDownCell.e = 100m;
			global::custom_controls.DataGridViewNumericUpDownCell.f = 0m;
			global::custom_controls.DataGridViewNumericUpDownCell.k = typeof(global::custom_controls.DataGridViewNumericUpDownEditingControl);
			global::custom_controls.DataGridViewNumericUpDownCell.l = typeof(decimal);
		}

		// Token: 0x040000FD RID: 253
		private const int a = 100;

		// Token: 0x040000FE RID: 254
		private const int b = 22;

		// Token: 0x040000FF RID: 255
		internal const int c = 0;

		// Token: 0x04000100 RID: 256
		internal const decimal d = 1m;

		// Token: 0x04000101 RID: 257
		internal const decimal e = 100m;

		// Token: 0x04000102 RID: 258
		internal const decimal f = 0m;

		// Token: 0x04000103 RID: 259
		internal const bool g = false;

		// Token: 0x04000104 RID: 260
		internal const bool h = false;

		// Token: 0x04000105 RID: 261
		private static readonly global::System.Windows.Forms.DataGridViewContentAlignment i;

		// Token: 0x04000106 RID: 262
		private static readonly global::System.Windows.Forms.DataGridViewContentAlignment j;

		// Token: 0x04000107 RID: 263
		private static global::System.Type k;

		// Token: 0x04000108 RID: 264
		private static global::System.Type l;

		// Token: 0x04000109 RID: 265
		private int m;

		// Token: 0x0400010A RID: 266
		private decimal n;

		// Token: 0x0400010B RID: 267
		private decimal o;

		// Token: 0x0400010C RID: 268
		private decimal p;

		// Token: 0x0400010D RID: 269
		private bool q;

		// Token: 0x0400010E RID: 270
		private bool r;

		// Token: 0x0400010F RID: 271
		private string s;

		// Token: 0x04000110 RID: 272
		private string t;

		// Token: 0x04000111 RID: 273
		private string u;

		// Token: 0x04000112 RID: 274
		private bool v;

		// Token: 0x04000113 RID: 275
		private global::custom_controls.CustomNumericUpDown w;
	}
}
