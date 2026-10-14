using System;
using System.Threading;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000039 RID: 57
	public class DataGridViewCustTextBoxEditingControl : global::custom_controls.CCustomTextBox, global::System.Windows.Forms.IDataGridViewEditingControl
	{
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060002EC RID: 748 RVA: 0x00035A08 File Offset: 0x00033C08
		// (remove) Token: 0x060002ED RID: 749 RVA: 0x00035AA0 File Offset: 0x00033CA0
		public event global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent DisableEnableCellsEdit
		{
			add
			{
				for (;;)
				{
					IL_14:
					global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent controlFocusEvent = this.a;
					if (true)
					{
					}
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent controlFocusEvent2;
							if (controlFocusEvent == controlFocusEvent2)
							{
								num = 2;
								continue;
							}
							goto IL_2D;
						}
						case 1:
							goto IL_2D;
						case 2:
							return;
						}
						break;
						IL_2D:
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
							global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent controlFocusEvent2 = controlFocusEvent;
							global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent value2 = (global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent)global::System.Delegate.Combine(controlFocusEvent2, value);
							controlFocusEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent>(ref this.a, value2, controlFocusEvent2);
							num = 0;
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
					global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent controlFocusEvent = this.a;
					if (true)
					{
					}
					int num = 0;
					for (;;)
					{
						global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent controlFocusEvent2;
						switch (num)
						{
						case 0:
							goto IL_37;
						case 1:
							return;
						case 2:
							if (controlFocusEvent == controlFocusEvent2)
							{
								num = 1;
								continue;
							}
							goto IL_37;
						}
						break;
						IL_37:
						controlFocusEvent2 = controlFocusEvent;
						global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent value2 = (global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent)global::System.Delegate.Remove(controlFocusEvent2, value);
						controlFocusEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent>(ref this.a, value2, controlFocusEvent2);
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
							break;
						}
					}
				}
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00035B34 File Offset: 0x00033D34
		public DataGridViewCustTextBoxEditingControl()
		{
			this.valueChanged = false;
			base.TabStop = false;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00035B58 File Offset: 0x00033D58
		protected override void OnTextChanged(global::System.EventArgs e)
		{
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return;
				case 1:
					this.a(this, new global::System.EventArgs());
					num = 0;
					continue;
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
						base.OnTextChanged(e);
						this.NotifyDataGridViewOfValueChange();
						num = 3;
						continue;
					}
					break;
				case 3:
					if (true)
					{
					}
					if (this.a != null)
					{
						num = 1;
						continue;
					}
					return;
				}
				if (base.FontColor)
				{
					break;
				}
				num = 2;
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00035C14 File Offset: 0x00033E14
		protected virtual void NotifyDataGridViewOfValueChange()
		{
			for (;;)
			{
				IL_14:
				this.valueChanged = true;
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
							goto IL_14;
						}
						if (false)
						{
						}
						if (this.dataGridView != null)
						{
							num = 1;
							continue;
						}
						return;
					case 1:
						this.dataGridView.NotifyCurrentCellDirty(true);
						if (true)
						{
						}
						num = 2;
						continue;
					case 2:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00035C9C File Offset: 0x00033E9C
		public global::System.Windows.Forms.Cursor EditingPanelCursor
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
				return global::System.Windows.Forms.Cursors.IBeam;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00035CDC File Offset: 0x00033EDC
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00035D20 File Offset: 0x00033F20
		public global::System.Windows.Forms.DataGridView EditingControlDataGridView
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
				return this.dataGridView;
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
				this.dataGridView = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00035E04 File Offset: 0x00034004
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00035D64 File Offset: 0x00033F64
		public object EditingControlFormattedValue
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
				for (;;)
				{
					for (;;)
					{
						string text = value.ToString();
						int num = 3;
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
									this.Text = string.Empty;
									num = 1;
									continue;
								}
								break;
							case 1:
								goto IL_81;
							case 2:
								goto IL_6C;
							case 3:
								if (string.IsNullOrEmpty(text))
								{
									num = 0;
									continue;
								}
								if (true)
								{
								}
								base.SetStandardTextToFormat(text);
								num = 2;
								continue;
							}
							break;
						}
					}
				}
				IL_6C:
				IL_81:
				this.NotifyDataGridViewOfValueChange();
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00035E48 File Offset: 0x00034048
		public object GetEditingControlFormattedValue(global::System.Windows.Forms.DataGridViewDataErrorContexts context)
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
			return this.Text;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00035E8C File Offset: 0x0003408C
		public bool EditingControlWantsInputKey(global::System.Windows.Forms.Keys keyData, bool dataGridViewWantsInputKey)
		{
			for (;;)
			{
				if (true)
				{
				}
				global::System.Windows.Forms.Keys keys = keyData & global::System.Windows.Forms.Keys.KeyCode;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch (keys)
						{
						case global::System.Windows.Forms.Keys.Prior:
						case global::System.Windows.Forms.Keys.Next:
							num = 18;
							continue;
						case global::System.Windows.Forms.Keys.End:
						case global::System.Windows.Forms.Keys.Home:
							num = 7;
							continue;
						case global::System.Windows.Forms.Keys.Left:
							num = 20;
							continue;
						case global::System.Windows.Forms.Keys.Up:
							goto IL_24C;
						case global::System.Windows.Forms.Keys.Right:
							num = 5;
							continue;
						default:
							num = 16;
							continue;
						}
						break;
					case 1:
						if (keys != global::System.Windows.Forms.Keys.Delete)
						{
							num = 6;
							continue;
						}
						num = 15;
						continue;
					case 2:
						num = 9;
						continue;
					case 3:
						return true;
					case 4:
						goto IL_1FB;
					case 5:
						if (this.SelectionLength == 0)
						{
							num = 2;
							continue;
						}
						return true;
					case 6:
						num = 19;
						continue;
					case 7:
						if (this.SelectionLength != this.ToString().Length)
						{
							num = 3;
							continue;
						}
						goto IL_24C;
					case 8:
						if (base.SelectionStart != 0)
						{
							num = 14;
							continue;
						}
						goto IL_24C;
					case 9:
						if (base.SelectionStart != this.ToString().Length)
						{
							num = 10;
							continue;
						}
						goto IL_24C;
					case 10:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BE;
						default:
							goto IL_1CA;
						}
						break;
					case 11:
						return true;
					case 12:
						num = 8;
						continue;
					case 13:
						num = 17;
						continue;
					case 14:
						goto IL_183;
					case 15:
						if (this.SelectionLength <= 0)
						{
							num = 13;
							continue;
						}
						return true;
					case 16:
						num = 1;
						continue;
					case 17:
						if (base.SelectionStart < this.ToString().Length)
						{
							num = 4;
							continue;
						}
						goto IL_24C;
					case 18:
						goto IL_BE;
					case 19:
						goto IL_159;
					case 20:
						if (this.SelectionLength == 0)
						{
							num = 12;
							continue;
						}
						return true;
					}
					break;
					IL_BE:
					if (!this.valueChanged)
					{
						goto IL_24C;
					}
					num = 11;
				}
			}
			return true;
			IL_159:
			goto IL_24C;
			IL_183:
			return true;
			IL_1CA:
			if (false)
			{
			}
			return true;
			IL_1FB:
			return true;
			IL_24C:
			return !dataGridViewWantsInputKey;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000360EC File Offset: 0x000342EC
		public void PrepareEditingControlForEdit(bool selectAll)
		{
			if (selectAll)
			{
				for (;;)
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
						goto IL_23;
					}
				}
				IL_23:
				if (false)
				{
				}
				base.SelectAll();
				return;
			}
			base.SelectionStart = this.ToString().Length;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00036144 File Offset: 0x00034344
		public bool RepositionEditingControlOnValueChange
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00036180 File Offset: 0x00034380
		// (set) Token: 0x060002FB RID: 763 RVA: 0x000361C4 File Offset: 0x000343C4
		public int EditingControlRowIndex
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
				return this.rowIndex;
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
				this.rowIndex = value;
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00036208 File Offset: 0x00034408
		public void ApplyCellStyleToEditingControl(global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle)
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
			this.Font = dataGridViewCellStyle.Font;
			this.ForeColor = dataGridViewCellStyle.ForeColor;
			this.BackColor = dataGridViewCellStyle.BackColor;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00036268 File Offset: 0x00034468
		// (set) Token: 0x060002FE RID: 766 RVA: 0x000362AC File Offset: 0x000344AC
		public bool EditingControlValueChanged
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
				return this.valueChanged;
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
				this.valueChanged = value;
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000362F0 File Offset: 0x000344F0
		private static global::System.Windows.Forms.HorizontalAlignment a(global::System.Windows.Forms.DataGridViewContentAlignment A_0)
		{
			for (;;)
			{
				int num = 18;
				for (;;)
				{
					switch (num)
					{
					case 0:
						num = 6;
						continue;
					case 1:
						switch (A_0)
						{
						case global::System.Windows.Forms.DataGridViewContentAlignment.TopLeft:
							return global::System.Windows.Forms.HorizontalAlignment.Left;
						case global::System.Windows.Forms.DataGridViewContentAlignment.TopCenter:
							return global::System.Windows.Forms.HorizontalAlignment.Center;
						case (global::System.Windows.Forms.DataGridViewContentAlignment)3:
							goto IL_1F0;
						case global::System.Windows.Forms.DataGridViewContentAlignment.TopRight:
							return global::System.Windows.Forms.HorizontalAlignment.Right;
						default:
							num = 9;
							continue;
						}
						break;
					case 2:
						goto IL_F5;
					case 3:
						num = 2;
						continue;
					case 4:
						num = 1;
						continue;
					case 5:
						if (A_0 <= global::System.Windows.Forms.DataGridViewContentAlignment.BottomLeft)
						{
							num = 13;
							continue;
						}
						num = 16;
						continue;
					case 6:
						goto IL_146;
					case 7:
						if (A_0 != global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft)
						{
							num = 15;
							continue;
						}
						return global::System.Windows.Forms.HorizontalAlignment.Left;
					case 8:
						if (A_0 != global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter)
						{
							num = 0;
							continue;
						}
						return global::System.Windows.Forms.HorizontalAlignment.Center;
					case 9:
						goto IL_1C8;
					case 10:
						if (A_0 != global::System.Windows.Forms.DataGridViewContentAlignment.BottomRight)
						{
							num = 3;
							continue;
						}
						return global::System.Windows.Forms.HorizontalAlignment.Right;
					case 11:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C8;
						default:
							if (false)
							{
							}
							num = 14;
							continue;
						}
						break;
					case 12:
						num = 19;
						continue;
					case 13:
						num = 20;
						continue;
					case 14:
						goto IL_A6;
					case 15:
						num = 8;
						continue;
					case 16:
						if (A_0 != global::System.Windows.Forms.DataGridViewContentAlignment.BottomCenter)
						{
							num = 17;
							continue;
						}
						return global::System.Windows.Forms.HorizontalAlignment.Center;
					case 17:
						num = 10;
						continue;
					case 18:
						if (A_0 <= global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter)
						{
							num = 4;
							continue;
						}
						num = 5;
						continue;
					case 19:
						if (A_0 != global::System.Windows.Forms.DataGridViewContentAlignment.BottomLeft)
						{
							num = 11;
							continue;
						}
						return global::System.Windows.Forms.HorizontalAlignment.Left;
					case 20:
						if (A_0 != global::System.Windows.Forms.DataGridViewContentAlignment.MiddleRight)
						{
							num = 12;
							continue;
						}
						return global::System.Windows.Forms.HorizontalAlignment.Right;
					}
					break;
					IL_1C8:
					num = 7;
				}
			}
			IL_A6:
			IL_F5:
			IL_146:
			IL_1F0:
			if (true)
			{
			}
			throw new global::System.ArgumentException("Error: Invalid Content Alignment!");
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00036500 File Offset: 0x00034700
		protected override void OnLeave(global::System.EventArgs e)
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
					base.CommitUserChanges();
					this.NotifyDataGridViewOfValueChange();
					num = 1;
					continue;
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_36;
					default:
						goto IL_6A;
					}
					break;
				}
				goto IL_2E;
				IL_36:
				num = 0;
				continue;
				IL_2E:
				if (base.TextModified)
				{
					goto IL_36;
				}
				goto IL_72;
			}
			IL_6A:
			if (false)
			{
			}
			IL_72:
			base.OnLeave(e);
		}

		// Token: 0x040001C9 RID: 457
		protected int rowIndex;

		// Token: 0x040001CA RID: 458
		protected bool valueChanged;

		// Token: 0x040001CB RID: 459
		protected global::System.Windows.Forms.DataGridView dataGridView;

		// Token: 0x040001CC RID: 460
		private global::custom_controls.DataGridViewCustTextBoxEditingControl.ControlFocusEvent a;

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000302 RID: 770
		public delegate void ControlFocusEvent(object sender, global::System.EventArgs e);
	}
}
