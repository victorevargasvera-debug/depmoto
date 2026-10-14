using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000034 RID: 52
	public class DataGridViewCustomTextBoxColumn : global::System.Windows.Forms.DataGridViewColumn
	{
		// Token: 0x06000249 RID: 585 RVA: 0x0002A038 File Offset: 0x00028238
		public DataGridViewCustomTextBoxColumn() : base(new global::custom_controls.DataGridViewCustomTextBoxCell())
		{
			this.a = false;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0002A058 File Offset: 0x00028258
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0002A09C File Offset: 0x0002829C
		public override global::System.Windows.Forms.DataGridViewCell CellTemplate
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
				return base.CellTemplate;
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
							break;
						default:
							if (false)
							{
							}
							num = 3;
							continue;
						}
						break;
					case 2:
						return;
					case 3:
						if (!value.GetType().IsAssignableFrom(typeof(global::custom_controls.DataGridViewCustomTextBoxCell)))
						{
							num = 2;
							continue;
						}
						goto IL_85;
					}
					IL_2A:
					if (value != null)
					{
						if (true)
						{
						}
						num = 0;
						continue;
					}
					goto IL_85;
					goto IL_2A;
				}
				return;
				IL_85:
				base.CellTemplate = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0002A138 File Offset: 0x00028338
		private global::custom_controls.DataGridViewCustomTextBoxCell CustomTextBoxCellTemplate
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
				return (global::custom_controls.DataGridViewCustomTextBoxCell)this.CellTemplate;
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0002A180 File Offset: 0x00028380
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
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(100);
			stringBuilder.Append("DataGridViewCustomTextBoxColumn { Name=");
			stringBuilder.Append(base.Name);
			stringBuilder.Append(", Index=");
			stringBuilder.Append(base.Index.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
			stringBuilder.Append(" }");
			return stringBuilder.ToString();
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0002A214 File Offset: 0x00028414
		public void SetColumnProperties(global::System.Windows.Forms.Control ctrl)
		{
			int num = 4;
			for (;;)
			{
				global::custom_controls.CCustomTextBox ccustomTextBox;
				switch (num)
				{
				case 0:
					if (ccustomTextBox.Tag != null)
					{
						num = 10;
						continue;
					}
					return;
				case 1:
					goto IL_5B;
				case 2:
					ccustomTextBox = (global::custom_controls.CCustomTextBox)ctrl;
					base.Name = ctrl.Name;
					num = 12;
					continue;
				case 3:
					goto IL_219;
				case 5:
					return;
				case 6:
					if (ccustomTextBox.IsGridColumnFixed)
					{
						num = 1;
						continue;
					}
					goto IL_219;
				case 7:
					goto IL_6F;
				case 8:
					base.Tag = ccustomTextBox.Alias;
					num = 7;
					continue;
				case 9:
					if (!string.IsNullOrEmpty(ccustomTextBox.Alias))
					{
						num = 8;
						continue;
					}
					goto IL_6F;
				case 10:
					ccustomTextBox.Tag = ccustomTextBox.Tag.ToString();
					num = 5;
					continue;
				case 11:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B;
					default:
						if (false)
						{
						}
						goto IL_258;
					}
					break;
				case 12:
					if (!string.IsNullOrEmpty(ctrl.Tag.ToString()))
					{
						num = 13;
						continue;
					}
					goto IL_258;
				case 13:
					if (true)
					{
					}
					base.HeaderText = ctrl.Tag.ToString();
					num = 11;
					continue;
				}
				if (ctrl != null)
				{
					num = 2;
					continue;
				}
				break;
				IL_5B:
				this.Frozen = true;
				num = 3;
				continue;
				IL_6F:
				base.Width = ctrl.Width;
				this.ReadOnly = ccustomTextBox.ReadOnly;
				this.Maximum = ccustomTextBox.Maximum;
				this.Minimum = ccustomTextBox.Minimum;
				this.MaxLength = ccustomTextBox.MaxLength;
				this.ValueTypeTextBox = ccustomTextBox.ValueType;
				this.IsNegativeNeeded = ccustomTextBox.IsNegativeNeeded;
				this.IsValidChars = ccustomTextBox.IsValidChars;
				this.DecimalPlaces = ccustomTextBox.DecimalPlaces;
				this.IsFNeeded = ccustomTextBox.IsFNeeded;
				this.ConvertToUpperCase = ccustomTextBox.ConvertToUpperCase;
				this.ContextMenuTextBox = ccustomTextBox.ContextMenu;
				this.MultiLine = ccustomTextBox.Multiline;
				this.RestrictedChars = ccustomTextBox.RestrictedChars;
				base.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
				this.XmlRange = ccustomTextBox.XmlRange;
				this.DefaultCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
				this.PasswordChar = ccustomTextBox.PasswordChar;
				num = 6;
				continue;
				IL_219:
				num = 0;
				continue;
				IL_258:
				num = 9;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0002A4A4 File Offset: 0x000286A4
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0002A4E8 File Offset: 0x000286E8
		public override bool ReadOnly
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
				return base.ReadOnly;
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
				base.ReadOnly = value;
				this.a = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0002A534 File Offset: 0x00028734
		public bool ColumnReadOnly
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
				return this.a;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0002A578 File Offset: 0x00028778
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0002A5D4 File Offset: 0x000287D4
		[global::System.ComponentModel.Description("Specifies if the letter F is needed in restricted chars.")]
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IsFNeeded
		{
			get
			{
				if (this.CellTemplate == null)
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
						throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
					}
				}
				return this.CustomTextBoxCellTemplate.IsFNeeded;
			}
			set
			{
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_18C:
					num = 11;
					break;
				case 1:
					goto IL_20;
				default:
					goto IL_20;
				}
				int num2;
				int count;
				global::System.Windows.Forms.DataGridViewRowCollection rows;
				for (;;)
				{
					IL_3F:
					switch (num)
					{
					case 0:
						goto IL_DB;
					case 1:
						goto IL_89;
					case 2:
					{
						global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
						if (dataGridViewCustomTextBoxCell != null)
						{
							num = 5;
							continue;
						}
						goto IL_89;
					}
					case 3:
						base.DataGridView.InvalidateColumn(base.Index);
						num = 10;
						continue;
					case 4:
					{
						if (num2 >= count)
						{
							num = 3;
							continue;
						}
						global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
						global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
						if (true)
						{
						}
						num = 2;
						continue;
					}
					case 5:
					{
						global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
						dataGridViewCustomTextBoxCell.d(num2, value);
						num = 1;
						continue;
					}
					case 7:
						goto IL_10D;
					case 8:
						if (base.DataGridView != null)
						{
							num = 0;
							continue;
						}
						return;
					case 9:
						goto IL_87;
					case 10:
						return;
					case 11:
						goto IL_10D;
					}
					if (this.CustomTextBoxCellTemplate == null)
					{
						num = 9;
						continue;
					}
					this.CustomTextBoxCellTemplate.IsFNeeded = value;
					num = 8;
					continue;
					IL_89:
					num2++;
					num = 7;
					continue;
					IL_10D:
					num = 4;
				}
				IL_87:
				throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				IL_DB:
				rows = base.DataGridView.Rows;
				count = rows.Count;
				num2 = 0;
				goto IL_18C;
				IL_20:
				if (false)
				{
				}
				switch (0)
				{
				default:
					num = 6;
					goto IL_3F;
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0002A780 File Offset: 0x00028980
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0002A7DC File Offset: 0x000289DC
		[global::System.ComponentModel.DefaultValue(global::custom_controls.CCustomTextBox.valueTypes.IntegerDec)]
		[global::System.ComponentModel.Description("Specifies the type of the input value.")]
		[global::System.ComponentModel.Category("Data")]
		public global::custom_controls.CCustomTextBox.valueTypes ValueTypeTextBox
		{
			get
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
					if (this.CellTemplate != null)
					{
						return this.CustomTextBoxCellTemplate.ValueTypeTB;
					}
					break;
				}
				throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 5;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							dataGridViewCustomTextBoxCell.a(num2, value);
							num = 7;
							continue;
						}
						case 1:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 3;
							continue;
						}
						case 2:
						{
							int count;
							if (num2 >= count)
							{
								num = 9;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							num = 6;
							continue;
						}
						case 3:
							goto IL_F2;
						case 4:
							goto IL_F2;
						case 6:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell == null)
							{
								goto IL_66;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_6A;
							default:
								if (false)
								{
								}
								num = 0;
								continue;
							}
							break;
						}
						case 7:
							if (true)
							{
							}
							goto IL_66;
						case 8:
							goto IL_61;
						case 9:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 10;
							continue;
						case 10:
							return;
						case 11:
							if (base.DataGridView != null)
							{
								num = 1;
								continue;
							}
							return;
						}
						if (this.CustomTextBoxCellTemplate == null)
						{
							num = 8;
							continue;
						}
						this.CustomTextBoxCellTemplate.ValueTypeTB = value;
						num = 11;
						continue;
						IL_6A:
						num = 4;
						continue;
						IL_66:
						num2++;
						goto IL_6A;
						IL_F2:
						num = 2;
					}
					IL_61:
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				}
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0002A98C File Offset: 0x00028B8C
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0002A9E8 File Offset: 0x00028BE8
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("Indicates the restrictedChars is for valid chars or invalid chars.")]
		public bool IsValidChars
		{
			get
			{
				while (this.CellTemplate != null)
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
						return this.CustomTextBoxCellTemplate.IsValidChars;
					}
				}
				if (true)
				{
				}
				throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 6;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
						{
							int count;
							if (num2 >= count)
							{
								num = 9;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							num = 5;
							continue;
						}
						case 1:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 2;
							continue;
						}
						case 2:
							goto IL_FF;
						case 3:
							goto IL_FF;
						case 4:
							goto IL_61;
						case 5:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell != null)
							{
								num = 7;
								continue;
							}
							goto IL_66;
						}
						case 7:
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
								global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
								dataGridViewCustomTextBoxCell.b(num2, value);
								break;
							}
							}
							if (true)
							{
							}
							num = 10;
							continue;
						case 8:
							if (base.DataGridView != null)
							{
								num = 1;
								continue;
							}
							return;
						case 9:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 11;
							continue;
						case 10:
							goto IL_66;
						case 11:
							return;
						}
						if (this.CustomTextBoxCellTemplate == null)
						{
							num = 4;
							continue;
						}
						this.CustomTextBoxCellTemplate.IsValidChars = value;
						num = 8;
						continue;
						IL_66:
						num2++;
						num = 3;
						continue;
						IL_FF:
						num = 0;
					}
					IL_61:
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				}
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0002AB98 File Offset: 0x00028D98
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0002ABF4 File Offset: 0x00028DF4
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.Description("used to indicate the nagative sign is needed or not.")]
		public bool IsNegativeNeeded
		{
			get
			{
				if (this.CellTemplate == null)
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
						throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
					}
				}
				return this.CustomTextBoxCellTemplate.IsNegativeNeeded;
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 7;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 8;
							continue;
						case 1:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							dataGridViewCustomTextBoxCell.a(num2, value);
							num = 10;
							continue;
						}
						case 2:
							goto IL_85;
						case 3:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell != null)
							{
								num = 1;
								continue;
							}
							goto IL_8A;
						}
						case 4:
							if (base.DataGridView != null)
							{
								num = 9;
								continue;
							}
							return;
						case 5:
						{
							int count;
							if (num2 >= count)
							{
								num = 0;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							num = 3;
							continue;
						}
						case 6:
							goto IL_11B;
						case 7:
							if (true)
							{
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_97;
							default:
								if (false)
								{
								}
								break;
							}
							break;
						case 8:
							return;
						case 9:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 6;
							continue;
						}
						case 10:
							goto IL_8A;
						case 11:
							goto IL_97;
						}
						if (this.CustomTextBoxCellTemplate == null)
						{
							num = 2;
							continue;
						}
						this.CustomTextBoxCellTemplate.IsNegativeNeeded = value;
						num = 4;
						continue;
						IL_8A:
						num2++;
						num = 11;
						continue;
						IL_11B:
						num = 5;
						continue;
						IL_97:
						goto IL_11B;
					}
					IL_85:
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				}
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0002ADA4 File Offset: 0x00028FA4
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0002AE00 File Offset: 0x00029000
		[global::System.ComponentModel.DefaultValue(0)]
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.Description("Specifies the number of digits after the decimal point.")]
		public int DecimalPlaces
		{
			get
			{
				while (this.CellTemplate == null)
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
						throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
					}
				}
				return this.CustomTextBoxCellTemplate.DecimalPlaces;
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 6;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							dataGridViewCustomTextBoxCell.b(num2, value);
							num = 1;
							continue;
						}
						case 1:
							if (true)
							{
							}
							goto IL_66;
						case 2:
							goto IL_61;
						case 3:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 8;
							continue;
						}
						case 4:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell != null)
							{
								num = 0;
								continue;
							}
							goto IL_66;
						}
						case 5:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 11;
							continue;
						case 7:
							goto IL_FF;
						case 8:
							goto IL_FF;
						case 9:
						{
							int count;
							if (num2 >= count)
							{
								num = 5;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							num = 4;
							continue;
						}
						case 10:
							if (base.DataGridView != null)
							{
								num = 3;
								continue;
							}
							return;
						case 11:
							return;
						}
						if (this.CustomTextBoxCellTemplate == null)
						{
							num = 2;
							continue;
						}
						this.CustomTextBoxCellTemplate.DecimalPlaces = value;
						goto IL_A0;
						IL_66:
						num2++;
						num = 7;
						continue;
						IL_A0:
						num = 10;
						continue;
						IL_FF:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A0;
						default:
							if (false)
							{
							}
							num = 9;
							break;
						}
					}
					IL_61:
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0002AFB0 File Offset: 0x000291B0
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0002B00C File Offset: 0x0002920C
		[global::System.ComponentModel.DefaultValue(0L)]
		[global::System.ComponentModel.Description("Specifies the max value.")]
		[global::System.ComponentModel.Category("Data")]
		public long Maximum
		{
			get
			{
				if (this.CellTemplate != null)
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
						return this.CustomTextBoxCellTemplate.Maximum;
					}
				}
				throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 10;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 4;
							continue;
						}
						case 1:
							if (base.DataGridView != null)
							{
								num = 0;
								continue;
							}
							return;
						case 2:
							goto IL_EF;
						case 3:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 11;
							continue;
						case 4:
							goto IL_EF;
						case 5:
							goto IL_69;
						case 6:
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
								global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
								dataGridViewCustomTextBoxCell.b(num2, value);
								num = 8;
								continue;
							}
							}
							break;
						case 7:
						{
							int count;
							if (num2 >= count)
							{
								num = 3;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							num = 9;
							continue;
						}
						case 8:
							goto IL_6B;
						case 9:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell != null)
							{
								num = 6;
								continue;
							}
							goto IL_6B;
						}
						case 11:
							return;
						}
						IL_50:
						if (true)
						{
						}
						if (this.CustomTextBoxCellTemplate == null)
						{
							num = 5;
							continue;
						}
						this.CustomTextBoxCellTemplate.Maximum = value;
						num = 1;
						continue;
						goto IL_50;
						IL_6B:
						num2++;
						num = 2;
						continue;
						IL_EF:
						num = 7;
					}
					IL_69:
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				}
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0002B1B8 File Offset: 0x000293B8
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0002B214 File Offset: 0x00029414
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.Description("Specifies the min value.")]
		[global::System.ComponentModel.DefaultValue(0L)]
		public long Minimum
		{
			get
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
					if (this.CellTemplate != null)
					{
						return this.CustomTextBoxCellTemplate.Minimum;
					}
					break;
				}
				if (true)
				{
				}
				throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 10;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
						{
							if (true)
							{
							}
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell != null)
							{
								num = 5;
								continue;
							}
							goto IL_7F;
						}
						case 1:
						{
							int count;
							if (num2 >= count)
							{
								num = 7;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							num = 0;
							continue;
						}
						case 2:
							goto IL_106;
						case 3:
							if (base.DataGridView != null)
							{
								num = 8;
								continue;
							}
							return;
						case 4:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_122;
							default:
								goto IL_77;
							}
							break;
						case 5:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							dataGridViewCustomTextBoxCell.a(num2, value);
							num = 9;
							continue;
						}
						case 6:
							goto IL_106;
						case 7:
							goto IL_122;
						case 8:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 6;
							continue;
						}
						case 9:
							goto IL_7F;
						case 11:
							return;
						}
						if (this.CustomTextBoxCellTemplate == null)
						{
							num = 4;
							continue;
						}
						this.CustomTextBoxCellTemplate.Minimum = value;
						num = 3;
						continue;
						IL_7F:
						num2++;
						num = 2;
						continue;
						IL_106:
						num = 1;
						continue;
						IL_122:
						base.DataGridView.InvalidateColumn(base.Index);
						num = 11;
					}
					IL_77:
					if (false)
					{
					}
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				}
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0002B3C4 File Offset: 0x000295C4
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0002B420 File Offset: 0x00029620
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.Description("used to indicate the value load from cp.")]
		public bool ConvertToUpperCase
		{
			get
			{
				if (true)
				{
				}
				if (this.CellTemplate != null)
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
						return this.CustomTextBoxCellTemplate.ConvertToUpperCase;
					}
				}
				throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 7;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							goto IL_61;
						case 1:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 3;
							continue;
						case 2:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 4;
							continue;
						}
						case 3:
							return;
						case 4:
							goto IL_113;
						case 5:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							dataGridViewCustomTextBoxCell.e(num2, value);
							num = 11;
							continue;
						}
						case 6:
							if (base.DataGridView == null)
							{
								return;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_123;
							default:
								if (false)
								{
								}
								num = 2;
								continue;
							}
							break;
						case 8:
							goto IL_113;
						case 9:
						{
							int count;
							if (num2 >= count)
							{
								goto IL_123;
							}
							if (true)
							{
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							num = 10;
							continue;
						}
						case 10:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell != null)
							{
								num = 5;
								continue;
							}
							goto IL_66;
						}
						case 11:
							goto IL_66;
						}
						if (this.CustomTextBoxCellTemplate == null)
						{
							num = 0;
							continue;
						}
						this.CustomTextBoxCellTemplate.ConvertToUpperCase = value;
						num = 6;
						continue;
						IL_66:
						num2++;
						num = 8;
						continue;
						IL_113:
						num = 9;
						continue;
						IL_123:
						num = 1;
					}
					IL_61:
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				}
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0002B5D0 File Offset: 0x000297D0
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0002B62C File Offset: 0x0002982C
		[global::System.ComponentModel.DefaultValue(0)]
		[global::System.ComponentModel.Description("Specifies the max length value.")]
		[global::System.ComponentModel.Category("Data")]
		public int MaxLength
		{
			get
			{
				while (this.CellTemplate == null)
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
						throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
					}
				}
				if (true)
				{
				}
				return this.CustomTextBoxCellTemplate.MaxLength;
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 8;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 9;
							continue;
						case 1:
							goto IL_6B;
						case 2:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell != null)
							{
								num = 7;
								continue;
							}
							goto IL_70;
						}
						case 3:
							goto IL_113;
						case 4:
							goto IL_70;
						case 5:
							goto IL_113;
						case 6:
						{
							int count;
							if (num2 >= count)
							{
								num = 0;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							num = 2;
							continue;
						}
						case 7:
						{
							if (true)
							{
							}
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							dataGridViewCustomTextBoxCell.a(num2, value);
							num = 4;
							continue;
						}
						case 9:
							return;
						case 10:
							if (base.DataGridView != null)
							{
								goto IL_D5;
							}
							return;
						case 11:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 5;
							continue;
						}
						}
						if (this.CustomTextBoxCellTemplate == null)
						{
							num = 1;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D5;
						default:
							if (false)
							{
							}
							this.CustomTextBoxCellTemplate.MaxLength = value;
							num = 10;
							continue;
						}
						IL_70:
						num2++;
						num = 3;
						continue;
						IL_D5:
						num = 11;
						continue;
						IL_113:
						num = 6;
					}
					IL_6B:
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				}
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0002B7DC File Offset: 0x000299DC
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0002B838 File Offset: 0x00029A38
		[global::System.ComponentModel.Category("ContextMenu")]
		[global::System.ComponentModel.Description("Specifies the context menu for the control.")]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Forms.ContextMenu ContextMenuTextBox
		{
			get
			{
				while (this.CellTemplate == null)
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
						throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
					}
				}
				return this.CustomTextBoxCellTemplate.ContextMenuTextBox;
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 10;
					for (;;)
					{
						int num2;
						int count;
						global::System.Windows.Forms.DataGridViewRowCollection rows;
						switch (num)
						{
						case 0:
							if (base.DataGridView != null)
							{
								num = 8;
								continue;
							}
							return;
						case 1:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 4;
							continue;
						case 2:
							goto IL_6D;
						case 3:
							goto IL_F1;
						case 4:
							return;
						case 5:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell != null)
							{
								num = 11;
								continue;
							}
							goto IL_6D;
						}
						case 6:
						{
							if (num2 >= count)
							{
								num = 1;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							if (true)
							{
							}
							num = 5;
							continue;
						}
						case 7:
							goto IL_6B;
						case 8:
							goto IL_177;
						case 9:
							goto IL_F1;
						case 11:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_177;
							default:
							{
								if (false)
								{
								}
								global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
								dataGridViewCustomTextBoxCell.a(num2, value);
								num = 2;
								continue;
							}
							}
							break;
						}
						if (this.CustomTextBoxCellTemplate == null)
						{
							num = 7;
							continue;
						}
						this.CustomTextBoxCellTemplate.ContextMenuTextBox = value;
						num = 0;
						continue;
						IL_6D:
						num2++;
						num = 3;
						continue;
						IL_F1:
						num = 6;
						continue;
						IL_177:
						rows = base.DataGridView.Rows;
						count = rows.Count;
						num2 = 0;
						num = 9;
					}
					IL_6B:
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				}
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0002B9E4 File Offset: 0x00029BE4
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0002BA40 File Offset: 0x00029C40
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.Description("used to indicate if it is multi line column.")]
		public bool MultiLine
		{
			get
			{
				if (this.CellTemplate == null)
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
					if (false)
					{
					}
					if (true)
					{
					}
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				return this.CustomTextBoxCellTemplate.MultiLine;
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 7;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
						{
							int count;
							if (num2 >= count)
							{
								num = 2;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							num = 8;
							continue;
						}
						case 1:
							return;
						case 2:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 1;
							continue;
						case 3:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 9;
							continue;
						}
						case 4:
							goto IL_6E;
						case 5:
							if (base.DataGridView != null)
							{
								num = 3;
								continue;
							}
							return;
						case 6:
							goto IL_69;
						case 8:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell != null)
							{
								num = 10;
								continue;
							}
							goto IL_6E;
						}
						case 9:
							goto IL_11E;
						case 10:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_BF;
							default:
							{
								if (false)
								{
								}
								global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
								dataGridViewCustomTextBoxCell.c(num2, value);
								num = 4;
								continue;
							}
							}
							break;
						case 11:
							goto IL_11E;
						}
						if (this.CustomTextBoxCellTemplate == null)
						{
							if (true)
							{
							}
							num = 6;
							continue;
						}
						this.CustomTextBoxCellTemplate.MultiLine = value;
						goto IL_BF;
						IL_6E:
						num2++;
						num = 11;
						continue;
						IL_BF:
						num = 5;
						continue;
						IL_11E:
						num = 0;
					}
					IL_69:
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				}
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0002BBF4 File Offset: 0x00029DF4
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0002BC50 File Offset: 0x00029E50
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.Description("used to set the restricted chars..")]
		public string RestrictedChars
		{
			get
			{
				if (true)
				{
				}
				if (this.CellTemplate != null)
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
						return this.CustomTextBoxCellTemplate.RestrictedChars;
					}
				}
				throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 9;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 1;
							continue;
						case 1:
							return;
						case 2:
							goto IL_61;
						case 3:
							goto IL_66;
						case 4:
							goto IL_111;
						case 5:
						{
							int count;
							if (num2 >= count)
							{
								num = 0;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							num = 11;
							continue;
						}
						case 6:
							goto IL_111;
						case 7:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							dataGridViewCustomTextBoxCell.c(num2, value);
							num = 3;
							continue;
						}
						case 8:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 6;
							continue;
						}
						case 10:
							if (base.DataGridView == null)
							{
								return;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_16C;
							default:
								if (false)
								{
								}
								num = 8;
								continue;
							}
							break;
						case 11:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell != null)
							{
								goto IL_16C;
							}
							goto IL_66;
						}
						}
						if (this.CustomTextBoxCellTemplate == null)
						{
							num = 2;
							continue;
						}
						this.CustomTextBoxCellTemplate.RestrictedChars = value;
						num = 10;
						continue;
						IL_66:
						num2++;
						num = 4;
						continue;
						IL_111:
						num = 5;
						continue;
						IL_16C:
						num = 7;
					}
					IL_61:
					if (true)
					{
					}
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				}
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0002BE00 File Offset: 0x0002A000
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0002BE5C File Offset: 0x0002A05C
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Description("used to set the range for the decima values")]
		public string XmlRange
		{
			get
			{
				if (this.CellTemplate == null)
				{
					if (true)
					{
					}
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
						return this.CustomTextBoxCellTemplate.XmlRange;
					}
				}
				throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
			}
			set
			{
				int num = 0;
				switch (num)
				{
				default:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						num = 4;
						break;
					}
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							goto IL_82;
						case 1:
							goto IL_11B;
						case 2:
							goto IL_7D;
						case 3:
							goto IL_11B;
						case 5:
							if (true)
							{
							}
							if (base.DataGridView != null)
							{
								num = 9;
								continue;
							}
							return;
						case 6:
						{
							int count;
							if (num2 >= count)
							{
								num = 8;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							num = 7;
							continue;
						}
						case 7:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell != null)
							{
								num = 10;
								continue;
							}
							goto IL_82;
						}
						case 8:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 11;
							continue;
						case 9:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 3;
							continue;
						}
						case 10:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							dataGridViewCustomTextBoxCell.a(num2, value);
							num = 0;
							continue;
						}
						case 11:
							return;
						}
						if (this.CustomTextBoxCellTemplate == null)
						{
							num = 2;
							continue;
						}
						this.CustomTextBoxCellTemplate.XmlRange = value;
						num = 5;
						continue;
						IL_82:
						num2++;
						num = 1;
						continue;
						IL_11B:
						num = 6;
					}
					IL_7D:
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0002C00C File Offset: 0x0002A20C
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0002C068 File Offset: 0x0002A268
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.DefaultValue('\0')]
		[global::System.ComponentModel.Description("A property to mask a character in the textbox control, i.e. for password characters.")]
		public char PasswordChar
		{
			get
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
					if (this.CellTemplate == null)
					{
						throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
					}
					break;
				}
				return this.CustomTextBoxCellTemplate.PasswordChar;
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 11;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 9;
							continue;
						case 1:
							goto IL_61;
						case 2:
						{
							int count;
							if (num2 >= count)
							{
								num = 0;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewCustomTextBoxCell;
							num = 5;
							continue;
						}
						case 3:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								if (false)
								{
								}
								goto IL_EF;
							}
							break;
						case 4:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							dataGridViewCustomTextBoxCell.a(num2, value);
							num = 6;
							continue;
						}
						case 5:
						{
							global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
							if (dataGridViewCustomTextBoxCell != null)
							{
								num = 4;
								continue;
							}
							goto IL_6B;
						}
						case 6:
							goto IL_6B;
						case 7:
							if (base.DataGridView != null)
							{
								num = 8;
								continue;
							}
							return;
						case 8:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 3;
							continue;
						}
						case 9:
							return;
						case 10:
							goto IL_EF;
						}
						IL_50:
						if (this.CustomTextBoxCellTemplate == null)
						{
							num = 1;
							continue;
						}
						this.CustomTextBoxCellTemplate.PasswordChar = value;
						num = 7;
						continue;
						goto IL_50;
						IL_6B:
						num2++;
						num = 10;
						continue;
						IL_EF:
						num = 2;
					}
					IL_61:
					if (true)
					{
					}
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate");
				}
				}
			}
		}

		// Token: 0x0400016F RID: 367
		private bool a;
	}
}
