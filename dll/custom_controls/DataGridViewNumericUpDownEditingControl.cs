using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000030 RID: 48
	public class DataGridViewNumericUpDownEditingControl : global::custom_controls.CustomNumericUpDown, global::System.Windows.Forms.IDataGridViewEditingControl
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060001F5 RID: 501 RVA: 0x00027068 File Offset: 0x00025268
		// (remove) Token: 0x060001F6 RID: 502 RVA: 0x000270FC File Offset: 0x000252FC
		public event global::custom_controls.DataGridViewNumericUpDownEditingControl.ControlFocusEvent DisableEnableCellsEdit
		{
			add
			{
				for (;;)
				{
					IL_38:
					global::custom_controls.DataGridViewNumericUpDownEditingControl.ControlFocusEvent controlFocusEvent = this.d;
					int num = 0;
					for (;;)
					{
						global::custom_controls.DataGridViewNumericUpDownEditingControl.ControlFocusEvent controlFocusEvent2;
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
							switch (num)
							{
							case 0:
								goto IL_47;
							case 1:
								return;
							case 2:
								if (controlFocusEvent == controlFocusEvent2)
								{
									num = 1;
									continue;
								}
								goto IL_49;
							}
							goto IL_38;
						}
						IL_49:
						controlFocusEvent2 = controlFocusEvent;
						global::custom_controls.DataGridViewNumericUpDownEditingControl.ControlFocusEvent value2 = (global::custom_controls.DataGridViewNumericUpDownEditingControl.ControlFocusEvent)global::System.Delegate.Combine(controlFocusEvent2, value);
						controlFocusEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.DataGridViewNumericUpDownEditingControl.ControlFocusEvent>(ref this.d, value2, controlFocusEvent2);
						num = 2;
						continue;
						IL_47:
						goto IL_49;
					}
				}
			}
			remove
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
					break;
				}
				for (;;)
				{
					global::custom_controls.DataGridViewNumericUpDownEditingControl.ControlFocusEvent controlFocusEvent = this.d;
					int num = 1;
					for (;;)
					{
						if (true)
						{
						}
						global::custom_controls.DataGridViewNumericUpDownEditingControl.ControlFocusEvent controlFocusEvent2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_53;
						case 2:
							if (controlFocusEvent == controlFocusEvent2)
							{
								num = 0;
								continue;
							}
							goto IL_53;
						}
						break;
						IL_53:
						controlFocusEvent2 = controlFocusEvent;
						global::custom_controls.DataGridViewNumericUpDownEditingControl.ControlFocusEvent value2 = (global::custom_controls.DataGridViewNumericUpDownEditingControl.ControlFocusEvent)global::System.Delegate.Remove(controlFocusEvent2, value);
						controlFocusEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.DataGridViewNumericUpDownEditingControl.ControlFocusEvent>(ref this.d, value2, controlFocusEvent2);
						num = 2;
					}
				}
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00027190 File Offset: 0x00025390
		public DataGridViewNumericUpDownEditingControl()
		{
			base.TabStop = false;
			base.EditControl.TextChanged -= this.a;
			base.EditControl.TextChanged += this.a;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x000271D8 File Offset: 0x000253D8
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0002721C File Offset: 0x0002541C
		public virtual global::System.Windows.Forms.DataGridView EditingControlDataGridView
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
				return this.a;
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
				this.a = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00027260 File Offset: 0x00025460
		// (set) Token: 0x060001FB RID: 507 RVA: 0x000272A4 File Offset: 0x000254A4
		public virtual object EditingControlFormattedValue
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
				return this.GetEditingControlFormattedValue(global::System.Windows.Forms.DataGridViewDataErrorContexts.Formatting);
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
				this.Text = (string)value;
				this.a();
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001FC RID: 508 RVA: 0x000272F4 File Offset: 0x000254F4
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00027338 File Offset: 0x00025538
		public virtual int EditingControlRowIndex
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
				this.c = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0002737C File Offset: 0x0002557C
		// (set) Token: 0x060001FF RID: 511 RVA: 0x000273C0 File Offset: 0x000255C0
		public virtual bool EditingControlValueChanged
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
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00027404 File Offset: 0x00025604
		public virtual global::System.Windows.Forms.Cursor EditingPanelCursor
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
				return global::System.Windows.Forms.Cursors.Default;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00027444 File Offset: 0x00025644
		public virtual bool RepositionEditingControlOnValueChange
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
				return false;
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00027480 File Offset: 0x00025680
		public virtual void ApplyCellStyleToEditingControl(global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle)
		{
			for (;;)
			{
				this.Font = dataGridViewCellStyle.Font;
				global::System.Drawing.Color backColor = dataGridViewCellStyle.BackColor;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (true)
						{
						}
						if (backColor.A >= 255)
						{
							this.BackColor = dataGridViewCellStyle.BackColor;
							num = 3;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_90;
						default:
							if (false)
							{
							}
							num = 2;
							continue;
						}
						break;
					case 1:
						goto IL_C6;
					case 2:
					{
						global::System.Drawing.Color backColor2 = global::System.Drawing.Color.FromArgb(255, dataGridViewCellStyle.BackColor);
						this.BackColor = backColor2;
						this.a.EditingPanel.BackColor = backColor2;
						num = 1;
						continue;
					}
					case 3:
						goto IL_90;
					}
					break;
				}
			}
			IL_90:
			IL_C6:
			this.ForeColor = dataGridViewCellStyle.ForeColor;
			base.TextAlign = global::custom_controls.DataGridViewNumericUpDownCell.a(dataGridViewCellStyle.Alignment);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00027574 File Offset: 0x00025774
		public virtual bool EditingControlWantsInputKey(global::System.Windows.Forms.Keys keyData, bool dataGridViewWantsInputKey)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Windows.Forms.Keys keys = keyData & global::System.Windows.Forms.Keys.KeyCode;
					int num = 9;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							global::System.Windows.Forms.TextBox textBox;
							if (textBox.SelectionStart != 0)
							{
								num = 24;
								continue;
							}
							goto IL_52B;
						}
						case 1:
						{
							global::System.Windows.Forms.TextBox textBox;
							if (textBox.SelectionLength == 0)
							{
								num = 16;
								continue;
							}
							return true;
						}
						case 2:
						{
							global::System.Windows.Forms.TextBox textBox;
							if (textBox != null)
							{
								num = 36;
								continue;
							}
							goto IL_52B;
						}
						case 3:
						{
							global::System.Windows.Forms.TextBox textBox2;
							if (textBox2.SelectionLength != textBox2.Text.Length)
							{
								num = 35;
								continue;
							}
							goto IL_52B;
						}
						case 4:
							goto IL_2DC;
						case 5:
						{
							global::System.Windows.Forms.TextBox textBox3;
							if (textBox3 != null)
							{
								num = 15;
								continue;
							}
							goto IL_52B;
						}
						case 6:
						{
							global::System.Windows.Forms.TextBox textBox4;
							if (textBox4 != null)
							{
								num = 12;
								continue;
							}
							goto IL_52B;
						}
						case 7:
							if (this.RightToLeft == global::System.Windows.Forms.RightToLeft.Yes)
							{
								num = 20;
								continue;
							}
							goto IL_52B;
						case 8:
							num = 13;
							continue;
						case 9:
							switch (keys)
							{
							case global::System.Windows.Forms.Keys.End:
							case global::System.Windows.Forms.Keys.Home:
							{
								global::System.Windows.Forms.TextBox textBox2 = base.Controls[1] as global::System.Windows.Forms.TextBox;
								num = 17;
								continue;
							}
							case global::System.Windows.Forms.Keys.Left:
							{
								global::System.Windows.Forms.TextBox textBox4 = base.Controls[1] as global::System.Windows.Forms.TextBox;
								num = 6;
								continue;
							}
							case global::System.Windows.Forms.Keys.Up:
								break;
							case global::System.Windows.Forms.Keys.Right:
							{
								global::System.Windows.Forms.TextBox textBox = base.Controls[1] as global::System.Windows.Forms.TextBox;
								num = 2;
								continue;
							}
							case global::System.Windows.Forms.Keys.Down:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									if (false)
									{
									}
									num = 29;
									continue;
								}
								break;
							case global::System.Windows.Forms.Keys.Select:
							case global::System.Windows.Forms.Keys.Print:
							case global::System.Windows.Forms.Keys.Execute:
							case global::System.Windows.Forms.Keys.Snapshot:
							case global::System.Windows.Forms.Keys.Insert:
								goto IL_52B;
							case global::System.Windows.Forms.Keys.Delete:
							{
								global::System.Windows.Forms.TextBox textBox3 = base.Controls[1] as global::System.Windows.Forms.TextBox;
								num = 5;
								continue;
							}
							default:
								num = 32;
								continue;
							}
							num = 27;
							continue;
						case 10:
							num = 30;
							continue;
						case 11:
							goto IL_499;
						case 12:
							num = 28;
							continue;
						case 13:
						{
							global::System.Windows.Forms.TextBox textBox4;
							if (textBox4.SelectionStart != textBox4.Text.Length)
							{
								num = 39;
								continue;
							}
							goto IL_52B;
						}
						case 14:
							num = 26;
							continue;
						case 15:
							num = 38;
							continue;
						case 16:
							num = 40;
							continue;
						case 17:
						{
							global::System.Windows.Forms.TextBox textBox2;
							if (textBox2 != null)
							{
								num = 19;
								continue;
							}
							goto IL_52B;
						}
						case 18:
						{
							global::System.Windows.Forms.TextBox textBox4;
							if (textBox4.SelectionLength == 0)
							{
								num = 10;
								continue;
							}
							return true;
						}
						case 19:
							num = 3;
							continue;
						case 20:
							if (true)
							{
							}
							num = 42;
							continue;
						case 21:
							return true;
						case 22:
							goto IL_19E;
						case 23:
							goto IL_494;
						case 24:
							return true;
						case 25:
						{
							global::System.Windows.Forms.TextBox textBox3;
							if (textBox3.SelectionStart < textBox3.Text.Length)
							{
								num = 23;
								continue;
							}
							goto IL_52B;
						}
						case 26:
						{
							global::System.Windows.Forms.TextBox textBox4;
							if (textBox4.SelectionLength == 0)
							{
								num = 8;
								continue;
							}
							return true;
						}
						case 27:
							if (base.Value < base.Maximum)
							{
								num = 34;
								continue;
							}
							goto IL_52B;
						case 28:
							if (this.RightToLeft == global::System.Windows.Forms.RightToLeft.No)
							{
								num = 41;
								continue;
							}
							goto IL_499;
						case 29:
							if (base.Value > base.Minimum)
							{
								num = 21;
								continue;
							}
							goto IL_52B;
						case 30:
						{
							global::System.Windows.Forms.TextBox textBox4;
							if (textBox4.SelectionStart == 0)
							{
								num = 11;
								continue;
							}
							return true;
						}
						case 31:
							num = 25;
							continue;
						case 32:
							num = 4;
							continue;
						case 33:
							num = 1;
							continue;
						case 34:
							return true;
						case 35:
							return true;
						case 36:
							num = 37;
							continue;
						case 37:
							if (this.RightToLeft == global::System.Windows.Forms.RightToLeft.No)
							{
								num = 33;
								continue;
							}
							goto IL_19E;
						case 38:
						{
							global::System.Windows.Forms.TextBox textBox3;
							if (textBox3.SelectionLength <= 0)
							{
								num = 31;
								continue;
							}
							return true;
						}
						case 39:
							goto IL_199;
						case 40:
						{
							global::System.Windows.Forms.TextBox textBox;
							if (textBox.SelectionStart == textBox.Text.Length)
							{
								num = 22;
								continue;
							}
							return true;
						}
						case 41:
							num = 18;
							continue;
						case 42:
						{
							global::System.Windows.Forms.TextBox textBox;
							if (textBox.SelectionLength == 0)
							{
								num = 43;
								continue;
							}
							return true;
						}
						case 43:
							num = 0;
							continue;
						case 44:
							if (this.RightToLeft == global::System.Windows.Forms.RightToLeft.Yes)
							{
								num = 14;
								continue;
							}
							goto IL_52B;
						}
						break;
						IL_19E:
						num = 7;
						continue;
						IL_499:
						num = 44;
					}
				}
				return true;
				IL_199:
				return true;
				IL_2DC:
				goto IL_52B;
				IL_494:
				return true;
				IL_52B:
				return !dataGridViewWantsInputKey;
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00027AB0 File Offset: 0x00025CB0
		public virtual object GetEditingControlFormattedValue(global::System.Windows.Forms.DataGridViewDataErrorContexts context)
		{
			object text;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return text;
			}
			if (false)
			{
			}
			if (true)
			{
			}
			bool userEdit = base.UserEdit;
			try
			{
				base.UserEdit = ((context & global::System.Windows.Forms.DataGridViewDataErrorContexts.Display) == (global::System.Windows.Forms.DataGridViewDataErrorContexts)0);
				base.CommitUserChanges();
				text = base.Controls[1].Text;
			}
			finally
			{
				base.UserEdit = userEdit;
			}
			return text;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00027B34 File Offset: 0x00025D34
		public virtual void PrepareEditingControlForEdit(bool selectAll)
		{
			global::System.Windows.Forms.TextBox textBox;
			for (;;)
			{
				textBox = (base.Controls[1] as global::System.Windows.Forms.TextBox);
				int num = 3;
				for (;;)
				{
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						num = 2;
						continue;
					case 1:
						goto IL_AF;
					case 2:
						if (selectAll)
						{
							num = 1;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8F;
						default:
							if (false)
							{
							}
							textBox.SelectionStart = textBox.Text.Length;
							num = 4;
							continue;
						}
						break;
					case 3:
						if (textBox != null)
						{
							num = 0;
							continue;
						}
						return;
					case 4:
						goto IL_8D;
					}
					break;
				}
			}
			IL_8D:
			return;
			IL_8F:
			textBox.SelectAll();
			return;
			IL_AF:
			goto IL_8F;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00027BF4 File Offset: 0x00025DF4
		private void a()
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return;
				case 1:
					this.b = true;
					this.a.NotifyCurrentCellDirty(true);
					if (true)
					{
					}
					num = 0;
					continue;
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
						break;
					}
					break;
				}
				if (this.b)
				{
					break;
				}
				num = 1;
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00027C7C File Offset: 0x00025E7C
		protected override void OnKeyPress(global::System.Windows.Forms.KeyPressEventArgs e)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					base.OnKeyPress(e);
					int selectionStart = 0;
					bool flag = false;
					int num = 9;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							string negativeSign;
							if (negativeSign.Length == 1)
							{
								num = 33;
								continue;
							}
							goto IL_1BE;
						}
						case 1:
							flag = true;
							num = 4;
							continue;
						case 2:
							num = 12;
							continue;
						case 3:
						{
							string numberDecimalSeparator;
							if (numberDecimalSeparator.Length == 1)
							{
								num = 19;
								continue;
							}
							goto IL_100;
						}
						case 4:
							goto IL_1BE;
						case 5:
							return;
						case 6:
							goto IL_100;
						case 7:
							this.a();
							num = 5;
							continue;
						case 8:
							num = 25;
							continue;
						case 9:
						{
							if (char.IsDigit(e.KeyChar))
							{
								num = 1;
								continue;
							}
							char keyChar = e.KeyChar;
							num = 13;
							continue;
						}
						case 10:
							if (!flag)
							{
								num = 34;
								continue;
							}
							goto IL_1BE;
						case 11:
							goto IL_1BE;
						case 12:
							num = 17;
							continue;
						case 13:
						{
							char keyChar;
							if (keyChar != ' ')
							{
								num = 27;
								continue;
							}
							goto IL_207;
						}
						case 14:
							goto IL_19E;
						case 15:
						{
							char keyChar;
							switch (keyChar)
							{
							case '(':
								flag = base.HasInvalidFormat(selectionStart, base.ControlText, e.KeyChar);
								num = 21;
								continue;
							case ')':
								goto IL_207;
							default:
								num = 2;
								continue;
							}
							break;
						}
						case 16:
						{
							string numberGroupSeparator;
							if (!string.IsNullOrEmpty(numberGroupSeparator))
							{
								num = 8;
								continue;
							}
							goto IL_19E;
						}
						case 17:
							if (base.Hexadecimal)
							{
								num = 18;
								continue;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_249;
							default:
							{
								if (false)
								{
								}
								global::System.Globalization.NumberFormatInfo numberFormat = global::System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
								string numberDecimalSeparator = numberFormat.NumberDecimalSeparator;
								string numberGroupSeparator = numberFormat.NumberGroupSeparator;
								string negativeSign = numberFormat.NegativeSign;
								num = 26;
								continue;
							}
							}
							break;
						case 18:
							flag = base.HasInvalidFormat(selectionStart, base.ControlText, e.KeyChar);
							num = 11;
							continue;
						case 19:
						{
							string numberDecimalSeparator;
							flag = (numberDecimalSeparator[0] == e.KeyChar);
							num = 6;
							continue;
						}
						case 20:
							goto IL_249;
						case 21:
							goto IL_1BE;
						case 22:
							num = 16;
							continue;
						case 23:
							num = 0;
							continue;
						case 24:
							if (!flag)
							{
								num = 22;
								continue;
							}
							goto IL_19E;
						case 25:
						{
							string numberGroupSeparator;
							if (numberGroupSeparator.Length == 1)
							{
								num = 29;
								continue;
							}
							goto IL_19E;
						}
						case 26:
						{
							string numberDecimalSeparator;
							if (!string.IsNullOrEmpty(numberDecimalSeparator))
							{
								num = 28;
								continue;
							}
							goto IL_100;
						}
						case 27:
							num = 15;
							continue;
						case 28:
							num = 3;
							continue;
						case 29:
						{
							string numberGroupSeparator;
							flag = (numberGroupSeparator[0] == e.KeyChar);
							num = 14;
							continue;
						}
						case 30:
							goto IL_1BE;
						case 31:
							if (flag)
							{
								num = 7;
								continue;
							}
							return;
						case 32:
						{
							string negativeSign;
							if (!string.IsNullOrEmpty(negativeSign))
							{
								num = 23;
								continue;
							}
							goto IL_1BE;
						}
						case 33:
						{
							string negativeSign;
							flag = (negativeSign[0] == e.KeyChar);
							num = 20;
							continue;
						}
						case 34:
							num = 32;
							continue;
						}
						break;
						IL_100:
						num = 24;
						continue;
						IL_19E:
						num = 10;
						continue;
						IL_1BE:
						if (true)
						{
						}
						num = 31;
						continue;
						IL_249:
						goto IL_1BE;
						IL_207:
						flag = base.HasInvalidFormat(selectionStart, base.ControlText, e.KeyChar);
						num = 30;
					}
				}
				return;
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00028098 File Offset: 0x00026298
		private void a(object A_0, global::System.EventArgs A_1)
		{
			int num = 0;
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
					case 1:
						goto IL_63;
					case 2:
						this.d(this, new global::System.EventArgs());
						num = 1;
						continue;
					}
					if (this.d == null)
					{
						goto IL_6F;
					}
					break;
				}
				num = 2;
			}
			IL_63:
			IL_6F:
			if (true)
			{
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0002811C File Offset: 0x0002631C
		protected override void OnValueChanged(global::System.EventArgs e)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					IL_4F:
					int num;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_1B0:
						num = 3;
						break;
					default:
						if (true)
						{
						}
						if (false)
						{
						}
						base.OnValueChanged(e);
						num = 5;
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							decimal minimum;
							base.Minimum = minimum;
							num = 4;
							continue;
						}
						case 1:
						{
							decimal minimum = base.Minimum;
							decimal maximum = base.Maximum;
							decimal increment = base.Increment;
							string infinity = base.Infinity;
							this.a();
							this.a.CommitEdit(global::System.Windows.Forms.DataGridViewDataErrorContexts.Commit);
							num = 6;
							continue;
						}
						case 2:
						{
							decimal maximum;
							base.Maximum = maximum;
							num = 7;
							continue;
						}
						case 3:
						{
							decimal maximum;
							if (maximum != base.Maximum)
							{
								num = 2;
								continue;
							}
							goto IL_B4;
						}
						case 4:
							goto IL_F2;
						case 5:
							if (this.Focused)
							{
								num = 1;
								continue;
							}
							return;
						case 6:
						{
							decimal minimum;
							if (minimum != base.Minimum)
							{
								num = 0;
								continue;
							}
							goto IL_1B0;
						}
						case 7:
							goto IL_B4;
						case 8:
						{
							string infinity;
							if (infinity != base.Infinity)
							{
								num = 10;
								continue;
							}
							return;
						}
						case 9:
							return;
						case 10:
						{
							string infinity;
							base.Infinity = infinity;
							num = 9;
							continue;
						}
						case 11:
						{
							decimal increment;
							if (increment != base.Increment)
							{
								num = 13;
								continue;
							}
							goto IL_16D;
						}
						case 12:
							goto IL_16D;
						case 13:
						{
							decimal increment;
							base.Increment = increment;
							num = 12;
							continue;
						}
						}
						goto IL_4F;
						IL_B4:
						num = 11;
						continue;
						IL_16D:
						num = 8;
					}
					IL_F2:
					goto IL_1B0;
				}
				return;
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00028310 File Offset: 0x00026510
		protected override bool ProcessKeyEventArgs(ref global::System.Windows.Forms.Message m)
		{
			global::System.Windows.Forms.TextBox textBox;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (false)
				{
				}
				textBox = (base.Controls[1] as global::System.Windows.Forms.TextBox);
				if (textBox == null)
				{
					return base.ProcessKeyEventArgs(ref m);
				}
				break;
			}
			if (true)
			{
			}
			global::custom_controls.a.SendMessage(textBox.Handle, m.Msg, m.WParam, m.LParam);
			return true;
		}

		// Token: 0x04000154 RID: 340
		private global::System.Windows.Forms.DataGridView a;

		// Token: 0x04000155 RID: 341
		private bool b;

		// Token: 0x04000156 RID: 342
		private int c;

		// Token: 0x04000157 RID: 343
		private global::custom_controls.DataGridViewNumericUpDownEditingControl.ControlFocusEvent d;

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600020C RID: 524
		public delegate void ControlFocusEvent(object sender, global::System.EventArgs e);
	}
}
