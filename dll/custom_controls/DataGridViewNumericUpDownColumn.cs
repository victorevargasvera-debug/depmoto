using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x0200002B RID: 43
	public class DataGridViewNumericUpDownColumn : global::System.Windows.Forms.DataGridViewColumn
	{
		// Token: 0x0600016A RID: 362 RVA: 0x0001E020 File Offset: 0x0001C220
		public DataGridViewNumericUpDownColumn() : base(new global::custom_controls.DataGridViewNumericUpDownCell())
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0001E038 File Offset: 0x0001C238
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0001E07C File Offset: 0x0001C27C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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
				for (;;)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7B;
					default:
					{
						if (true)
						{
						}
						if (false)
						{
						}
						global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell = value as global::custom_controls.DataGridViewNumericUpDownCell;
						int num = 1;
						for (;;)
						{
							switch (num)
							{
							case 0:
								num = 2;
								continue;
							case 1:
								if (value != null)
								{
									num = 0;
									continue;
								}
								goto IL_7D;
							case 2:
								if (dataGridViewNumericUpDownCell == null)
								{
									num = 3;
									continue;
								}
								goto IL_7D;
							case 3:
								goto IL_7B;
							}
							break;
						}
						break;
					}
					}
				}
				IL_7B:
				throw new global::System.InvalidCastException();
				IL_7D:
				base.CellTemplate = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0001E110 File Offset: 0x0001C310
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0001E168 File Offset: 0x0001C368
		[global::System.ComponentModel.DefaultValue(0)]
		[global::System.ComponentModel.Description("Indicates the number of decimal places to display.")]
		[global::System.ComponentModel.Category("Appearance")]
		public int DecimalPlaces
		{
			get
			{
				if (this.NumericUpDownCellTemplate == null)
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
						throw new global::System.InvalidOperationException();
					}
				}
				return this.NumericUpDownCellTemplate.DecimalPlaces;
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
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							dataGridViewNumericUpDownCell.b(num2, value);
							num = 7;
							continue;
						}
						case 1:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 9;
							continue;
						case 2:
							if (base.DataGridView != null)
							{
								num = 5;
								continue;
							}
							return;
						case 3:
						{
							int count;
							if (num2 >= count)
							{
								num = 1;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewNumericUpDownCell;
							num = 6;
							continue;
						}
						case 4:
							goto IL_61;
						case 5:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 11;
							continue;
						}
						case 6:
						{
							if (true)
							{
							}
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							if (dataGridViewNumericUpDownCell != null)
							{
								num = 0;
								continue;
							}
							goto IL_66;
						}
						case 7:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_61;
							}
							if (false)
							{
							}
							goto IL_66;
						case 8:
							goto IL_10E;
						case 9:
							return;
						case 11:
							goto IL_10E;
						}
						if (this.NumericUpDownCellTemplate == null)
						{
							num = 4;
							continue;
						}
						this.NumericUpDownCellTemplate.DecimalPlaces = value;
						num = 2;
						continue;
						IL_66:
						num2++;
						num = 8;
						continue;
						IL_10E:
						num = 3;
					}
					IL_61:
					throw new global::System.InvalidOperationException();
				}
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0001E314 File Offset: 0x0001C514
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0001E36C File Offset: 0x0001C56C
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.Description("Indicates the amount to increment or decrement on each button click.")]
		public decimal Increment
		{
			get
			{
				while (this.NumericUpDownCellTemplate != null)
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
						return this.NumericUpDownCellTemplate.Increment;
					}
				}
				throw new global::System.InvalidOperationException();
			}
			set
			{
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_15E:
					num = 1;
					break;
				default:
					if (false)
					{
					}
					switch (0)
					{
					default:
						num = 4;
						break;
					}
					break;
				}
				int num2;
				int count;
				global::System.Windows.Forms.DataGridViewRowCollection rows;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_113;
					case 2:
					{
						if (true)
						{
						}
						global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
						dataGridViewNumericUpDownCell.b(num2, value);
						num = 10;
						continue;
					}
					case 3:
						goto IL_79;
					case 5:
						goto IL_111;
					case 6:
						goto IL_113;
					case 7:
						if (base.DataGridView != null)
						{
							num = 5;
							continue;
						}
						return;
					case 8:
					{
						global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
						if (dataGridViewNumericUpDownCell != null)
						{
							num = 2;
							continue;
						}
						goto IL_137;
					}
					case 9:
					{
						if (num2 >= count)
						{
							num = 0;
							continue;
						}
						global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
						global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewNumericUpDownCell;
						num = 8;
						continue;
					}
					case 10:
						goto IL_137;
					}
					if (this.NumericUpDownCellTemplate == null)
					{
						num = 3;
						continue;
					}
					this.NumericUpDownCellTemplate.Increment = value;
					num = 7;
					continue;
					IL_113:
					num = 9;
					continue;
					IL_137:
					num2++;
					num = 6;
				}
				IL_79:
				throw new global::System.InvalidOperationException();
				IL_111:
				rows = base.DataGridView.Rows;
				count = rows.Count;
				num2 = 0;
				goto IL_15E;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0001E4E8 File Offset: 0x0001C6E8
		private bool d()
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
			return !this.Increment.Equals(1m);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0001E53C File Offset: 0x0001C73C
		// (set) Token: 0x06000173 RID: 371 RVA: 0x0001E594 File Offset: 0x0001C794
		[global::System.ComponentModel.Description("Indicates the maximum value for the numeric up-down cells.")]
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		[global::System.ComponentModel.Category("Data")]
		public decimal Maximum
		{
			get
			{
				if (this.NumericUpDownCellTemplate == null)
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
						throw new global::System.InvalidOperationException();
					}
				}
				return this.NumericUpDownCellTemplate.Maximum;
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
							goto IL_113;
						case 1:
						{
							int count;
							if (num2 >= count)
							{
								num = 0;
								continue;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_113;
							default:
							{
								if (false)
								{
								}
								global::System.Windows.Forms.DataGridViewRowCollection rows;
								global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
								global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewNumericUpDownCell;
								num = 3;
								continue;
							}
							}
							break;
						}
						case 2:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 7;
							continue;
						}
						case 3:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							if (dataGridViewNumericUpDownCell != null)
							{
								num = 10;
								continue;
							}
							goto IL_66;
						}
						case 4:
							goto IL_61;
						case 5:
							goto IL_66;
						case 6:
							return;
						case 7:
							goto IL_F7;
						case 8:
							if (base.DataGridView != null)
							{
								num = 2;
								continue;
							}
							return;
						case 10:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							dataGridViewNumericUpDownCell.c(num2, value);
							num = 5;
							continue;
						}
						case 11:
							if (true)
							{
							}
							goto IL_F7;
						}
						if (this.NumericUpDownCellTemplate == null)
						{
							num = 4;
							continue;
						}
						this.NumericUpDownCellTemplate.Maximum = value;
						num = 8;
						continue;
						IL_66:
						num2++;
						num = 11;
						continue;
						IL_F7:
						num = 1;
						continue;
						IL_113:
						base.DataGridView.InvalidateColumn(base.Index);
						num = 6;
					}
					IL_61:
					throw new global::System.InvalidOperationException();
				}
				}
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0001E73C File Offset: 0x0001C93C
		private bool c()
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
			return !this.Maximum.Equals(100m);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0001E790 File Offset: 0x0001C990
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0001E7E8 File Offset: 0x0001C9E8
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.Description("Indicates the minimum value for the numeric up-down cells.")]
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		public decimal Minimum
		{
			get
			{
				for (;;)
				{
					if (true)
					{
					}
					if (this.NumericUpDownCellTemplate == null)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						}
						break;
					}
					goto IL_3E;
				}
				if (false)
				{
				}
				throw new global::System.InvalidOperationException();
				IL_3E:
				return this.NumericUpDownCellTemplate.Minimum;
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 3;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							goto IL_FA;
						case 1:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							dataGridViewNumericUpDownCell.a(num2, value);
							num = 11;
							continue;
						}
						case 2:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 0;
							continue;
						}
						case 4:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							if (dataGridViewNumericUpDownCell != null)
							{
								num = 1;
								continue;
							}
							goto IL_66;
						}
						case 5:
							goto IL_61;
						case 6:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 10;
							continue;
						case 7:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_73;
							default:
							{
								if (false)
								{
								}
								int count;
								if (num2 >= count)
								{
									num = 6;
									continue;
								}
								global::System.Windows.Forms.DataGridViewRowCollection rows;
								global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
								global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewNumericUpDownCell;
								num = 4;
								continue;
							}
							}
							break;
						case 8:
							goto IL_73;
						case 9:
							if (base.DataGridView != null)
							{
								num = 2;
								continue;
							}
							return;
						case 10:
							return;
						case 11:
							if (true)
							{
							}
							goto IL_66;
						}
						if (this.NumericUpDownCellTemplate == null)
						{
							num = 5;
							continue;
						}
						this.NumericUpDownCellTemplate.Minimum = value;
						num = 9;
						continue;
						IL_66:
						num2++;
						num = 8;
						continue;
						IL_FA:
						num = 7;
						continue;
						IL_73:
						goto IL_FA;
					}
					IL_61:
					throw new global::System.InvalidOperationException();
				}
				}
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0001E994 File Offset: 0x0001CB94
		private bool b()
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
			return !this.Minimum.Equals(0m);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0001E9E8 File Offset: 0x0001CBE8
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0001EA40 File Offset: 0x0001CC40
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.Description("Indicates whether the thousands separator will be inserted between every three decimal digits.")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ThousandsSeparator
		{
			get
			{
				if (this.NumericUpDownCellTemplate == null)
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
						break;
					}
					throw new global::System.InvalidOperationException();
				}
				return this.NumericUpDownCellTemplate.ThousandsSeparator;
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 1;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							goto IL_19C;
						case 2:
							if (base.DataGridView != null)
							{
								num = 6;
								continue;
							}
							return;
						case 3:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 5;
							continue;
						case 4:
							goto IL_7D;
						case 5:
							return;
						case 6:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 0;
							continue;
						}
						case 7:
							goto IL_119;
						case 8:
							goto IL_82;
						case 9:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							if (dataGridViewNumericUpDownCell != null)
							{
								num = 11;
								continue;
							}
							goto IL_82;
						}
						case 10:
						{
							int count;
							if (num2 >= count)
							{
								num = 3;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewNumericUpDownCell;
							num = 9;
							continue;
						}
						case 11:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							dataGridViewNumericUpDownCell.b(num2, value);
							num = 8;
							continue;
						}
						}
						if (this.NumericUpDownCellTemplate != null)
						{
							this.NumericUpDownCellTemplate.ThousandsSeparator = value;
							if (true)
							{
							}
							num = 2;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_19C;
						default:
							if (false)
							{
							}
							num = 4;
							continue;
						}
						IL_82:
						num2++;
						num = 7;
						continue;
						IL_119:
						num = 10;
						continue;
						IL_19C:
						goto IL_119;
					}
					IL_7D:
					throw new global::System.InvalidOperationException();
				}
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0001EC48 File Offset: 0x0001CE48
		[global::System.ComponentModel.Description("Indicates the maixum input length of the editing control.")]
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.DefaultValue(0)]
		public int MaxInputLength
		{
			get
			{
				if (true)
				{
				}
				if (this.NumericUpDownCellTemplate != null)
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
						return this.NumericUpDownCellTemplate.MaxInputLength;
					}
				}
				throw new global::System.InvalidOperationException();
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 2;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							goto IL_63;
						case 1:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							if (dataGridViewNumericUpDownCell != null)
							{
								num = 4;
								continue;
							}
							goto IL_63;
						}
						case 3:
							goto IL_61;
						case 4:
						{
							if (true)
							{
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_F2;
							}
							if (false)
							{
							}
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							dataGridViewNumericUpDownCell.a(num2, value);
							num = 0;
							continue;
						}
						case 5:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 10;
							continue;
						case 6:
							goto IL_E2;
						case 7:
							if (base.DataGridView != null)
							{
								num = 11;
								continue;
							}
							return;
						case 8:
							goto IL_E2;
						case 9:
						{
							int count;
							if (num2 >= count)
							{
								goto IL_F2;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewNumericUpDownCell;
							num = 1;
							continue;
						}
						case 10:
							return;
						case 11:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 6;
							continue;
						}
						}
						if (this.NumericUpDownCellTemplate == null)
						{
							num = 3;
							continue;
						}
						this.NumericUpDownCellTemplate.MaxInputLength = value;
						num = 7;
						continue;
						IL_63:
						num2++;
						num = 8;
						continue;
						IL_E2:
						num = 9;
						continue;
						IL_F2:
						num = 5;
					}
					IL_61:
					throw new global::System.InvalidOperationException();
				}
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0001EDF0 File Offset: 0x0001CFF0
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0001EE48 File Offset: 0x0001D048
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("Indicates whether the blank value is allowed or not.")]
		[global::System.ComponentModel.Category("Data")]
		public bool BlankAllowed
		{
			get
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
					if (this.NumericUpDownCellTemplate != null)
					{
						return this.NumericUpDownCellTemplate.BlankAllowed;
					}
					break;
				}
				throw new global::System.InvalidOperationException();
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 4;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							goto IL_EF;
						case 1:
							goto IL_177;
						case 2:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 1;
							continue;
						case 3:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 5;
							continue;
						}
						case 5:
							IL_172:
							goto IL_EF;
						case 6:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							if (dataGridViewNumericUpDownCell != null)
							{
								num = 11;
								continue;
							}
							goto IL_66;
						}
						case 7:
							goto IL_61;
						case 8:
							if (base.DataGridView != null)
							{
								num = 3;
								continue;
							}
							goto IL_177;
						case 9:
						{
							int count;
							if (num2 >= count)
							{
								num = 2;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewNumericUpDownCell;
							num = 6;
							continue;
						}
						case 10:
							goto IL_66;
						case 11:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							dataGridViewNumericUpDownCell.c(num2, value);
							num = 10;
							continue;
						}
						}
						if (this.NumericUpDownCellTemplate == null)
						{
							num = 7;
							continue;
						}
						this.NumericUpDownCellTemplate.BlankAllowed = value;
						num = 8;
						continue;
						IL_66:
						num2++;
						num = 0;
						continue;
						IL_EF:
						num = 9;
						continue;
						IL_177:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_172;
						default:
							goto IL_18D;
						}
					}
					IL_61:
					throw new global::System.InvalidOperationException();
					IL_18D:
					if (false)
					{
					}
					if (true)
					{
					}
					return;
				}
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0001EFF0 File Offset: 0x0001D1F0
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0001F048 File Offset: 0x0001D248
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("Indicates if the value is infinity symbol.")]
		[global::System.ComponentModel.Category("Data")]
		public string Infinity
		{
			get
			{
				while (this.NumericUpDownCellTemplate != null)
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
						return this.NumericUpDownCellTemplate.Infinity;
					}
				}
				if (true)
				{
				}
				throw new global::System.InvalidOperationException();
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
							if (base.DataGridView != null)
							{
								num = 3;
								continue;
							}
							return;
						case 1:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 10;
							continue;
						case 2:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							dataGridViewNumericUpDownCell.c(num2, value);
							num = 9;
							continue;
						}
						case 3:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 7;
							continue;
						}
						case 4:
							goto IL_E2;
						case 5:
							goto IL_61;
						case 6:
						{
							int count;
							if (num2 >= count)
							{
								num = 1;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewNumericUpDownCell;
							num = 11;
							continue;
						}
						case 7:
							goto IL_E2;
						case 9:
							goto IL_63;
						case 10:
							return;
						case 11:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							if (dataGridViewNumericUpDownCell != null)
							{
								num = 2;
								continue;
							}
							goto IL_63;
						}
						}
						if (this.NumericUpDownCellTemplate == null)
						{
							num = 5;
							continue;
						}
						this.NumericUpDownCellTemplate.Infinity = value;
						num = 0;
						continue;
						IL_63:
						num2++;
						num = 4;
						continue;
						IL_E2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_61;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							num = 6;
							break;
						}
					}
					IL_61:
					throw new global::System.InvalidOperationException();
				}
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0001F1F0 File Offset: 0x0001D3F0
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0001F248 File Offset: 0x0001D448
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("Indicates if the value represents none.")]
		public string None
		{
			get
			{
				while (this.NumericUpDownCellTemplate == null)
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
						throw new global::System.InvalidOperationException();
					}
				}
				return this.NumericUpDownCellTemplate.None;
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 0;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							if (true)
							{
							}
							break;
						case 1:
							goto IL_F4;
						case 2:
							goto IL_75;
						case 3:
							if (base.DataGridView != null)
							{
								num = 9;
								continue;
							}
							goto IL_17C;
						case 4:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							dataGridViewNumericUpDownCell.a(num2, value);
							num = 2;
							continue;
						}
						case 5:
							goto IL_17C;
						case 6:
							goto IL_F4;
						case 7:
						{
							int count;
							if (num2 >= count)
							{
								num = 10;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewNumericUpDownCell;
							num = 11;
							continue;
						}
						case 8:
							goto IL_73;
						case 9:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 6;
							continue;
						}
						case 10:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 5;
							continue;
						case 11:
						{
							global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
							if (dataGridViewNumericUpDownCell != null)
							{
								num = 4;
								continue;
							}
							goto IL_75;
						}
						}
						if (this.NumericUpDownCellTemplate == null)
						{
							num = 8;
							continue;
						}
						this.NumericUpDownCellTemplate.None = value;
						num = 3;
						continue;
						IL_75:
						num2++;
						num = 1;
						continue;
						IL_F4:
						num = 7;
						continue;
						IL_17C:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_75;
						default:
							goto IL_192;
						}
					}
					IL_73:
					throw new global::System.InvalidOperationException();
					IL_192:
					if (false)
					{
					}
					return;
				}
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0001F448 File Offset: 0x0001D648
		[global::System.ComponentModel.Category("Data")]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("Indicates how to display the special display value.")]
		public string SpecialDisplayText
		{
			get
			{
				if (this.NumericUpDownCellTemplate == null)
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
					throw new global::System.InvalidOperationException();
				}
				return this.NumericUpDownCellTemplate.SpecialDisplayText;
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 2;
					for (;;)
					{
						int num2;
						global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
						switch (num)
						{
						case 0:
							goto IL_61;
						case 1:
						{
							int count;
							if (num2 >= count)
							{
								num = 8;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRowCollection rows;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
							dataGridViewNumericUpDownCell = (dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewNumericUpDownCell);
							num = 3;
							continue;
						}
						case 3:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_15B;
							default:
								if (false)
								{
								}
								if (dataGridViewNumericUpDownCell != null)
								{
									num = 6;
									continue;
								}
								goto IL_63;
							}
							break;
						case 4:
							goto IL_E2;
						case 5:
							goto IL_63;
						case 6:
							goto IL_15B;
						case 7:
							if (base.DataGridView != null)
							{
								num = 9;
								continue;
							}
							return;
						case 8:
							base.DataGridView.InvalidateColumn(base.Index);
							num = 11;
							continue;
						case 9:
						{
							global::System.Windows.Forms.DataGridViewRowCollection rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 10;
							continue;
						}
						case 10:
							if (true)
							{
							}
							goto IL_E2;
						case 11:
							return;
						}
						if (this.NumericUpDownCellTemplate == null)
						{
							num = 0;
							continue;
						}
						this.NumericUpDownCellTemplate.SpecialDisplayText = value;
						num = 7;
						continue;
						IL_63:
						num2++;
						num = 4;
						continue;
						IL_E2:
						num = 1;
						continue;
						IL_15B:
						dataGridViewNumericUpDownCell.b(num2, value);
						num = 5;
					}
					IL_61:
					throw new global::System.InvalidOperationException();
				}
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0001F5F0 File Offset: 0x0001D7F0
		[global::System.ComponentModel.Description("Contains localization Information.")]
		public global::System.Globalization.NumberFormatInfo InvariantNumberFormat
		{
			get
			{
				if (this.NumericUpDownCellTemplate == null)
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
					throw new global::System.InvalidOperationException();
				}
				if (true)
				{
				}
				return this.NumericUpDownCellTemplate.InvariantNumberFormat;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0001F648 File Offset: 0x0001D848
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0001F6A0 File Offset: 0x0001D8A0
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("Formats the cell value.")]
		[global::System.ComponentModel.Category("Data")]
		public string StandardValue
		{
			get
			{
				if (this.NumericUpDownCellTemplate == null)
				{
					if (true)
					{
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_38;
					}
					if (false)
					{
					}
					IL_38:
					throw new global::System.InvalidOperationException();
				}
				return this.NumericUpDownCellTemplate.StandardValue;
			}
			set
			{
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_18C:
					num = 1;
					break;
				default:
					if (false)
					{
					}
					switch (0)
					{
					default:
						num = 10;
						break;
					}
					break;
				}
				int num2;
				int count;
				global::System.Windows.Forms.DataGridViewRowCollection rows;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (base.DataGridView != null)
						{
							num = 4;
							continue;
						}
						return;
					case 1:
						goto IL_10D;
					case 2:
					{
						global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
						dataGridViewNumericUpDownCell.d(num2, value);
						num = 7;
						continue;
					}
					case 3:
						base.DataGridView.InvalidateColumn(base.Index);
						num = 9;
						continue;
					case 4:
						goto IL_DB;
					case 5:
						goto IL_87;
					case 6:
						goto IL_10D;
					case 7:
						goto IL_89;
					case 8:
					{
						global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
						if (dataGridViewNumericUpDownCell != null)
						{
							num = 2;
							continue;
						}
						goto IL_89;
					}
					case 9:
						return;
					case 11:
					{
						if (num2 >= count)
						{
							if (true)
							{
							}
							num = 3;
							continue;
						}
						global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
						global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell = dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewNumericUpDownCell;
						num = 8;
						continue;
					}
					}
					if (this.NumericUpDownCellTemplate == null)
					{
						num = 5;
						continue;
					}
					this.NumericUpDownCellTemplate.StandardValue = value;
					num = 0;
					continue;
					IL_89:
					num2++;
					num = 6;
					continue;
					IL_10D:
					num = 11;
				}
				IL_87:
				throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate.");
				IL_DB:
				rows = base.DataGridView.Rows;
				count = rows.Count;
				num2 = 0;
				goto IL_18C;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0001F84C File Offset: 0x0001DA4C
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0001F8A8 File Offset: 0x0001DAA8
		[global::System.ComponentModel.Description("Indicates whether the hexa decimal will be set or not.")]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Category("Data")]
		public bool Hexadecimal
		{
			get
			{
				if (this.NumericUpDownCellTemplate != null)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_0A;
					}
					if (true)
					{
					}
					if (false)
					{
					}
					return this.NumericUpDownCellTemplate.Hexadecimal;
				}
				IL_0A:
				throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate.");
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 2;
					for (;;)
					{
						int num2;
						global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
						global::System.Windows.Forms.DataGridViewRowCollection rows;
						switch (num)
						{
						case 0:
							if (base.DataGridView != null)
							{
								num = 7;
								continue;
							}
							return;
						case 1:
						{
							int count;
							if (num2 >= count)
							{
								num = 4;
								continue;
							}
							goto IL_139;
						}
						case 3:
							if (dataGridViewNumericUpDownCell != null)
							{
								num = 5;
								continue;
							}
							goto IL_6E;
						case 4:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_139;
							default:
								if (false)
								{
								}
								base.DataGridView.InvalidateColumn(base.Index);
								num = 6;
								continue;
							}
							break;
						case 5:
							dataGridViewNumericUpDownCell.a(num2, value);
							num = 11;
							continue;
						case 6:
							return;
						case 7:
						{
							rows = base.DataGridView.Rows;
							int count = rows.Count;
							num2 = 0;
							num = 8;
							continue;
						}
						case 8:
							goto IL_11B;
						case 9:
							goto IL_69;
						case 10:
							goto IL_11B;
						case 11:
							goto IL_6E;
						}
						if (this.NumericUpDownCellTemplate == null)
						{
							if (true)
							{
							}
							num = 9;
							continue;
						}
						this.NumericUpDownCellTemplate.Hexadecimal = value;
						num = 0;
						continue;
						IL_6E:
						num2++;
						num = 10;
						continue;
						IL_11B:
						num = 1;
						continue;
						IL_139:
						global::System.Windows.Forms.DataGridViewRow dataGridViewRow = rows.SharedRow(num2);
						dataGridViewNumericUpDownCell = (dataGridViewRow.Cells[base.Index] as global::custom_controls.DataGridViewNumericUpDownCell);
						num = 3;
					}
					IL_69:
					throw new global::System.InvalidOperationException("Operation cannot be completed because this DataGridViewColumn does not have a CellTemplate.");
				}
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0001FA58 File Offset: 0x0001DC58
		private global::custom_controls.DataGridViewNumericUpDownCell NumericUpDownCellTemplate
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
				return (global::custom_controls.DataGridViewNumericUpDownCell)this.CellTemplate;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		public override string ToString()
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
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(100);
			stringBuilder.Append("DataGridViewNumericUpDownColumn { Name=");
			stringBuilder.Append(base.Name);
			stringBuilder.Append(", Index=");
			stringBuilder.Append(base.Index.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
			stringBuilder.Append(" }");
			return stringBuilder.ToString();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0001FB34 File Offset: 0x0001DD34
		public void SetColumnProperties(global::System.Windows.Forms.Control ctrl)
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
					{
						if (false)
						{
						}
						global::custom_controls.CustomNumericUpDown customNumericUpDown = (global::custom_controls.CustomNumericUpDown)ctrl;
						base.Name = ctrl.Name;
						base.HeaderText = ctrl.Tag.ToString();
						base.Width = ctrl.Width + 6;
						this.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
						base.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
						this.DecimalPlaces = customNumericUpDown.DecimalPlaces;
						this.Minimum = customNumericUpDown.Minimum;
						this.Maximum = customNumericUpDown.Maximum;
						this.Increment = customNumericUpDown.Increment;
						this.MaxInputLength = customNumericUpDown.MaxInputLength;
						this.BlankAllowed = customNumericUpDown.BlankAllowed;
						this.Infinity = customNumericUpDown.Infinity;
						this.None = customNumericUpDown.None;
						this.SpecialDisplayText = customNumericUpDown.SpecialDisplayText;
						this.Hexadecimal = customNumericUpDown.Hexadecimal;
						this.DefaultCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
						num = 2;
						continue;
					}
					}
					break;
				case 2:
					return;
				}
				if (true)
				{
				}
				if (ctrl == null)
				{
					break;
				}
				num = 0;
			}
		}
	}
}
