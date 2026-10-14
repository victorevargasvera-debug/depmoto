using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000033 RID: 51
	public class DataGridViewCustomTextBoxCell : global::System.Windows.Forms.DataGridViewTextBoxCell
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00028490 File Offset: 0x00026690
		// (set) Token: 0x06000213 RID: 531 RVA: 0x000284D4 File Offset: 0x000266D4
		[global::System.ComponentModel.DefaultValue(null)]
		public string XmlRange
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
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_46;
						default:
							goto IL_71;
						}
						break;
					case 1:
						goto IL_46;
					}
					if (true)
					{
					}
					if (this.t != value)
					{
						num = 1;
						continue;
					}
					return;
					IL_46:
					this.a(base.RowIndex, value);
					num = 0;
				}
				IL_71:
				if (false)
				{
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0002855C File Offset: 0x0002675C
		// (set) Token: 0x06000215 RID: 533 RVA: 0x000285A0 File Offset: 0x000267A0
		[global::System.ComponentModel.DefaultValue('\0')]
		public char PasswordChar
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
				return this.u;
			}
			set
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.a(base.RowIndex, value);
						if (true)
						{
						}
						num = 2;
						continue;
					case 2:
						return;
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
						if (this.u == value)
						{
							return;
						}
						break;
					}
					num = 1;
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00028624 File Offset: 0x00026824
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00028668 File Offset: 0x00026868
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IsFNeeded
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
				return this.h;
			}
			set
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 2:
						this.d(base.RowIndex, value);
						num = 0;
						continue;
					}
					if (true)
					{
					}
					if (this.h == value)
					{
						break;
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
						num = 2;
						break;
					}
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000218 RID: 536 RVA: 0x000286EC File Offset: 0x000268EC
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00028730 File Offset: 0x00026930
		[global::System.ComponentModel.DefaultValue(global::custom_controls.CCustomTextBox.valueTypes.IntegerDec)]
		public global::custom_controls.CCustomTextBox.valueTypes ValueTypeTB
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
				return this.i;
			}
			set
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_6C;
						}
						break;
					case 2:
						this.a(base.RowIndex, value);
						if (true)
						{
						}
						num = 1;
						continue;
					}
					if (this.i == value)
					{
						return;
					}
					num = 2;
				}
				IL_6C:
				if (false)
				{
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600021A RID: 538 RVA: 0x000287B4 File Offset: 0x000269B4
		// (set) Token: 0x0600021B RID: 539 RVA: 0x000287F8 File Offset: 0x000269F8
		[global::System.ComponentModel.DefaultValue(null)]
		public string RestrictedChars
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
				return this.j;
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
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_69;
						}
						break;
					}
					if (!(this.j != value))
					{
						return;
					}
					num = 0;
				}
				IL_69:
				if (true)
				{
				}
				if (false)
				{
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00028880 File Offset: 0x00026A80
		// (set) Token: 0x0600021D RID: 541 RVA: 0x000288C4 File Offset: 0x00026AC4
		[global::System.ComponentModel.DefaultValue(false)]
		public bool IsValidChars
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
				return this.k;
			}
			set
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.b(base.RowIndex, value);
						num = 1;
						continue;
					case 1:
						return;
					}
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
						if (this.k == value)
						{
							return;
						}
						num = 0;
						break;
					}
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00028948 File Offset: 0x00026B48
		// (set) Token: 0x0600021F RID: 543 RVA: 0x0002898C File Offset: 0x00026B8C
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
				return this.l;
			}
			set
			{
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.b(base.RowIndex, value);
						num = 2;
						continue;
					case 1:
						goto IL_7D;
					case 2:
						goto IL_A1;
					case 3:
						num = 5;
						continue;
					case 5:
						if (value > 99)
						{
							num = 1;
							continue;
						}
						if (true)
						{
						}
						num = 6;
						continue;
					case 6:
						if (this.l != value)
						{
							num = 0;
							continue;
						}
						return;
					}
					if (value < 0)
					{
						break;
					}
					num = 3;
				}
				IL_5D:
				throw new global::System.ArgumentOutOfRangeException("The DecimalPlaces property cannot be smaller than 0 or larger than 99.");
				IL_7D:
				goto IL_5D;
				IL_A1:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_7D;
				default:
					if (false)
					{
					}
					break;
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00028A58 File Offset: 0x00026C58
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00028A9C File Offset: 0x00026C9C
		[global::System.ComponentModel.DefaultValue(0)]
		public int MaxLength
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
				if (true)
				{
				}
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_5B;
					case 2:
						return;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_5B:
						this.a(base.RowIndex, value);
						num = 2;
						break;
					default:
						if (false)
						{
						}
						if (this.q == value)
						{
							return;
						}
						num = 1;
						break;
					}
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00028B20 File Offset: 0x00026D20
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00028B64 File Offset: 0x00026D64
		[global::System.ComponentModel.DefaultValue(false)]
		public bool IsNegativeNeeded
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
				return this.m;
			}
			set
			{
				int num = 1;
				for (;;)
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
						switch (num)
						{
						case 0:
							return;
						case 2:
							this.a(base.RowIndex, value);
							num = 0;
							continue;
						}
						if (this.m == value)
						{
							return;
						}
						break;
					}
					num = 2;
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00028BE8 File Offset: 0x00026DE8
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00028C2C File Offset: 0x00026E2C
		[global::System.ComponentModel.DefaultValue(0L)]
		public long Maximum
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
				return this.n;
			}
			set
			{
				int num = 1;
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
						if (false)
						{
						}
						switch (num)
						{
						case 0:
							this.b(base.RowIndex, value);
							num = 2;
							continue;
						case 2:
							return;
						}
						if (this.n == value)
						{
							return;
						}
						break;
					}
					num = 0;
				}
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00028CB0 File Offset: 0x00026EB0
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00028CF4 File Offset: 0x00026EF4
		[global::System.ComponentModel.DefaultValue(0L)]
		public long Minimum
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
				return this.o;
			}
			set
			{
				int num = 2;
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
						case 0:
							return;
						case 1:
							this.a(base.RowIndex, value);
							goto IL_62;
						}
						if (this.o != value)
						{
							num = 1;
							continue;
						}
						return;
					}
					IL_62:
					if (true)
					{
					}
					num = 0;
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00028D78 File Offset: 0x00026F78
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00028DBC File Offset: 0x00026FBC
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ConvertToUpperCase
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
				return this.p;
			}
			set
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.e(base.RowIndex, value);
						num = 2;
						continue;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_64;
						}
						break;
					}
					if (this.p == value)
					{
						return;
					}
					num = 1;
				}
				IL_64:
				if (true)
				{
				}
				if (false)
				{
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00028E40 File Offset: 0x00027040
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00028E84 File Offset: 0x00027084
		[global::System.ComponentModel.DefaultValue(false)]
		public bool MultiLine
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
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_6A;
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
							this.c(base.RowIndex, value);
							num = 1;
							continue;
						}
						break;
					}
					IL_1C:
					if (this.s != value)
					{
						num = 2;
						continue;
					}
					return;
					goto IL_1C;
				}
				IL_6A:
				if (true)
				{
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00028F08 File Offset: 0x00027108
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00028F4C File Offset: 0x0002714C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Forms.ContextMenu ContextMenuTextBox
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
				return this.r;
			}
			set
			{
				int num = 2;
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
							if (true)
							{
							}
							this.a(base.RowIndex, value);
							num = 1;
							continue;
						}
						break;
					case 1:
						return;
					}
					IL_1C:
					if (this.r != value)
					{
						num = 0;
						continue;
					}
					break;
					goto IL_1C;
				}
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00028FD0 File Offset: 0x000271D0
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00029020 File Offset: 0x00027220
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
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.b(base.RowIndex, value);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00029068 File Offset: 0x00027268
		public DataGridViewCustomTextBoxCell()
		{
			this.v = new global::custom_controls.CCustomTextBox();
			this.v.TabStop = false;
			this.h = true;
			this.j = null;
			this.l = 0;
			this.m = false;
			this.p = false;
			this.q = 0;
			this.n = 0L;
			this.o = 0L;
			this.p = false;
			this.q = 0;
			this.r = null;
			this.s = false;
			this.j = null;
			this.k = false;
			this.t = null;
			this.u = '\0';
			this.i = global::custom_controls.CCustomTextBox.valueTypes.IntegerDec;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0002910C File Offset: 0x0002730C
		public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle)
		{
			global::custom_controls.DataGridViewCustTextBoxEditingControl dataGridViewCustTextBoxEditingControl;
			for (;;)
			{
				base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
				dataGridViewCustTextBoxEditingControl = (base.DataGridView.EditingControl as global::custom_controls.DataGridViewCustTextBoxEditingControl);
				int num = 3;
				for (;;)
				{
					if (true)
					{
					}
					string value;
					switch (num)
					{
					case 0:
						num = 2;
						continue;
					case 1:
						dataGridViewCustTextBoxEditingControl.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
						dataGridViewCustTextBoxEditingControl.MaxLength = this.MaxLength;
						dataGridViewCustTextBoxEditingControl.Maximum = this.n;
						dataGridViewCustTextBoxEditingControl.Minimum = this.Minimum;
						dataGridViewCustTextBoxEditingControl.ValueType = this.ValueTypeTB;
						dataGridViewCustTextBoxEditingControl.IsValidChars = this.k;
						dataGridViewCustTextBoxEditingControl.IsNegativeNeeded = this.IsNegativeNeeded;
						dataGridViewCustTextBoxEditingControl.IsFNeeded = this.h;
						dataGridViewCustTextBoxEditingControl.RestrictedChars = this.RestrictedChars;
						dataGridViewCustTextBoxEditingControl.ConvertToUpperCase = this.ConvertToUpperCase;
						dataGridViewCustTextBoxEditingControl.XmlRange = this.t;
						dataGridViewCustTextBoxEditingControl.DecimalPlaces = this.l;
						dataGridViewCustTextBoxEditingControl.PasswordChar = this.u;
						value = (initialFormattedValue as string);
						num = 5;
						continue;
					case 2:
						if (!string.IsNullOrEmpty((string)base.Value))
						{
							dataGridViewCustTextBoxEditingControl.SetStandardTextToFormat((string)base.Value);
							num = 4;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_163;
						default:
							if (false)
							{
							}
							num = 6;
							continue;
						}
						break;
					case 3:
						if (dataGridViewCustTextBoxEditingControl != null)
						{
							num = 1;
							continue;
						}
						return;
					case 4:
						return;
					case 5:
						goto IL_163;
					case 6:
						goto IL_B8;
					}
					break;
					IL_163:
					if (string.IsNullOrEmpty(value))
					{
						goto IL_68;
					}
					num = 0;
				}
			}
			IL_68:
			dataGridViewCustTextBoxEditingControl.Text = string.Empty;
			return;
			IL_B8:
			goto IL_68;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000292B8 File Offset: 0x000274B8
		public override object Clone()
		{
			global::custom_controls.DataGridViewCustomTextBoxCell dataGridViewCustomTextBoxCell;
			for (;;)
			{
				dataGridViewCustomTextBoxCell = (base.Clone() as global::custom_controls.DataGridViewCustomTextBoxCell);
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (dataGridViewCustomTextBoxCell != null)
						{
							num = 1;
							continue;
						}
						return dataGridViewCustomTextBoxCell;
					case 1:
						goto IL_38;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_38;
						}
						goto Block_2;
					}
					break;
					IL_38:
					dataGridViewCustomTextBoxCell.IsFNeeded = this.IsFNeeded;
					dataGridViewCustomTextBoxCell.RestrictedChars = this.RestrictedChars;
					dataGridViewCustomTextBoxCell.m = this.IsNegativeNeeded;
					dataGridViewCustomTextBoxCell.ConvertToUpperCase = this.ConvertToUpperCase;
					dataGridViewCustomTextBoxCell.MaxLength = this.MaxLength;
					dataGridViewCustomTextBoxCell.DecimalPlaces = this.DecimalPlaces;
					dataGridViewCustomTextBoxCell.Maximum = this.Maximum;
					dataGridViewCustomTextBoxCell.Minimum = this.Minimum;
					dataGridViewCustomTextBoxCell.ContextMenuTextBox = this.ContextMenuTextBox;
					dataGridViewCustomTextBoxCell.MultiLine = this.MultiLine;
					dataGridViewCustomTextBoxCell.IsValidChars = this.IsValidChars;
					dataGridViewCustomTextBoxCell.ValueTypeTB = this.ValueTypeTB;
					dataGridViewCustomTextBoxCell.ReadOnly = this.ReadOnly;
					dataGridViewCustomTextBoxCell.XmlRange = this.t;
					dataGridViewCustomTextBoxCell.PasswordChar = this.u;
					if (true)
					{
					}
					num = 2;
				}
			}
			Block_2:
			if (false)
			{
			}
			return dataGridViewCustomTextBoxCell;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000233 RID: 563 RVA: 0x000293F0 File Offset: 0x000275F0
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
				return typeof(global::custom_controls.DataGridViewCustTextBoxEditingControl);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00029438 File Offset: 0x00027638
		private global::custom_controls.DataGridViewCustTextBoxEditingControl EditingTextBox
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
				return base.DataGridView.EditingControl as global::custom_controls.DataGridViewCustTextBoxEditingControl;
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00029484 File Offset: 0x00027684
		private bool a(int A_0)
		{
			int num = 4;
			global::custom_controls.DataGridViewCustTextBoxEditingControl dataGridViewCustTextBoxEditingControl;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_AA;
				case 1:
					if (true)
					{
					}
					if (dataGridViewCustTextBoxEditingControl != null)
					{
						num = 3;
						continue;
					}
					return false;
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5C;
					default:
						if (false)
						{
						}
						num = 5;
						continue;
					}
					break;
				case 3:
					goto IL_88;
				case 5:
					if (base.DataGridView == null)
					{
						num = 0;
						continue;
					}
					goto IL_5C;
				}
				if (A_0 != -1)
				{
					num = 2;
					continue;
				}
				return false;
				IL_5C:
				dataGridViewCustTextBoxEditingControl = (base.DataGridView.EditingControl as global::custom_controls.DataGridViewCustTextBoxEditingControl);
				num = 1;
			}
			IL_88:
			return A_0 == ((global::System.Windows.Forms.IDataGridViewEditingControl)dataGridViewCustTextBoxEditingControl).EditingControlRowIndex;
			IL_AA:
			return false;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00029548 File Offset: 0x00027748
		private void a()
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_9D;
				case 1:
					if (!base.DataGridView.IsDisposed)
					{
						num = 6;
						continue;
					}
					return;
				case 2:
					goto IL_9B;
				case 4:
					return;
				case 5:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9D;
					default:
						if (false)
						{
						}
						if (base.RowIndex == -1)
						{
							num = 2;
							continue;
						}
						base.DataGridView.UpdateCellValue(base.ColumnIndex, base.RowIndex);
						num = 4;
						continue;
					}
					break;
				case 6:
					num = 7;
					continue;
				case 7:
					if (!base.DataGridView.Disposing)
					{
						num = 8;
						continue;
					}
					return;
				case 8:
					num = 5;
					continue;
				}
				if (base.DataGridView != null)
				{
					if (true)
					{
					}
					num = 0;
					continue;
				}
				return;
				IL_9D:
				num = 1;
			}
			IL_9B:
			base.DataGridView.InvalidateColumn(base.ColumnIndex);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00029670 File Offset: 0x00027870
		internal void d(int A_0, bool A_1)
		{
			for (;;)
			{
				this.h = A_1;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_52;
					case 1:
						if (true)
						{
						}
						this.EditingTextBox.IsFNeeded = A_1;
						num = 0;
						continue;
					case 2:
						if (this.a(A_0))
						{
							num = 1;
							continue;
						}
						goto IL_54;
					}
					break;
				}
			}
			IL_52:
			IL_54:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_52;
			default:
				if (false)
				{
				}
				return;
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000296F8 File Offset: 0x000278F8
		internal void a(int A_0, global::custom_controls.CCustomTextBox.valueTypes A_1)
		{
			if (true)
			{
			}
			for (;;)
			{
				this.i = A_1;
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
							this.EditingTextBox.ValueType = A_1;
							num = 2;
							continue;
						}
						break;
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
					break;
				}
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00029780 File Offset: 0x00027980
		internal void c(int A_0, string A_1)
		{
			for (;;)
			{
				this.j = A_1;
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
							this.EditingTextBox.RestrictedChars = A_1;
							num = 2;
							continue;
						}
						break;
					case 1:
						if (true)
						{
						}
						if (this.a(A_0))
						{
							num = 0;
							continue;
						}
						return;
					case 2:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00029808 File Offset: 0x00027A08
		internal void b(int A_0, bool A_1)
		{
			for (;;)
			{
				this.k = A_1;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_70;
					case 1:
						if (this.a(A_0))
						{
							num = 2;
							continue;
						}
						return;
					case 2:
						this.EditingTextBox.IsValidChars = A_1;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							num = 0;
							continue;
						}
						break;
					}
					break;
				}
			}
			IL_70:
			if (true)
			{
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00029890 File Offset: 0x00027A90
		internal void b(int A_0, int A_1)
		{
			for (;;)
			{
				if (true)
				{
				}
				this.l = A_1;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.EditingTextBox.DecimalPlaces = A_1;
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

		// Token: 0x0600023C RID: 572 RVA: 0x00029918 File Offset: 0x00027B18
		internal void a(int A_0, bool A_1)
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
				this.m = A_1;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (true)
						{
						}
						if (this.a(A_0))
						{
							num = 1;
							continue;
						}
						return;
					case 1:
						this.EditingTextBox.IsNegativeNeeded = A_1;
						num = 2;
						continue;
					case 2:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000299A0 File Offset: 0x00027BA0
		internal void b(int A_0, long A_1)
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
				this.n = A_1;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.EditingTextBox.Maximum = A_1;
						num = 2;
						continue;
					case 1:
						if (true)
						{
						}
						if (this.a(A_0))
						{
							num = 0;
							continue;
						}
						return;
					case 2:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00029A28 File Offset: 0x00027C28
		internal void a(int A_0, long A_1)
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
				for (;;)
				{
					this.o = A_1;
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
							if (this.a(A_0))
							{
								num = 2;
								continue;
							}
							return;
						case 2:
							this.EditingTextBox.Minimum = A_1;
							num = 0;
							continue;
						}
						break;
					}
				}
				break;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00029AB0 File Offset: 0x00027CB0
		internal void e(int A_0, bool A_1)
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
				for (;;)
				{
					this.p = A_1;
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
						case 1:
							if (this.a(A_0))
							{
								num = 2;
								continue;
							}
							return;
						case 2:
							this.EditingTextBox.ConvertToUpperCase = A_1;
							num = 0;
							continue;
						}
						break;
					}
				}
				break;
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00029B38 File Offset: 0x00027D38
		internal void a(int A_0, int A_1)
		{
			for (;;)
			{
				this.q = A_1;
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_51:
					if (!this.a(A_0))
					{
						return;
					}
					num = 0;
					break;
				default:
					if (true)
					{
					}
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
						this.EditingTextBox.MaxLength = A_1;
						num = 2;
						continue;
					case 1:
						goto IL_51;
					case 2:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00029BC0 File Offset: 0x00027DC0
		internal void a(int A_0, global::System.Windows.Forms.ContextMenu A_1)
		{
			for (;;)
			{
				this.r = A_1;
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_47:
					if (!this.a(A_0))
					{
						return;
					}
					num = 1;
					break;
				default:
					if (true)
					{
					}
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
						this.EditingTextBox.ContextMenu = A_1;
						num = 0;
						continue;
					case 2:
						goto IL_47;
					}
					break;
				}
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00029C48 File Offset: 0x00027E48
		internal void c(int A_0, bool A_1)
		{
			for (;;)
			{
				IL_14:
				if (true)
				{
				}
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_66:
					num = 0;
					break;
				default:
					if (false)
					{
					}
					this.s = A_1;
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
						goto IL_58;
					case 2:
						if (this.a(A_0))
						{
							num = 1;
							continue;
						}
						return;
					}
					goto IL_14;
				}
				IL_58:
				this.EditingTextBox.Multiline = A_1;
				goto IL_66;
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00029CD0 File Offset: 0x00027ED0
		internal void a(int A_0, ref string A_1)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					goto IL_4E;
				case 2:
					A_1 = this.EditingTextBox.StandardValue;
					num = 1;
					continue;
				}
				goto IL_1C;
				IL_25:
				if (true)
				{
				}
				num = 2;
				continue;
				IL_1C:
				if (this.a(A_0))
				{
					goto IL_25;
				}
				IL_4E:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_25;
				default:
					goto IL_64;
				}
			}
			IL_64:
			if (false)
			{
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00029D54 File Offset: 0x00027F54
		internal void b(int A_0, string A_1)
		{
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
						return;
					default:
						if (false)
						{
						}
						if (true)
						{
						}
						this.EditingTextBox.StandardValue = A_1;
						num = 0;
						continue;
					}
					break;
				}
				if (!this.a(A_0))
				{
					break;
				}
				num = 2;
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00029DD4 File Offset: 0x00027FD4
		public string GetFormattedText(string value)
		{
			if (!string.IsNullOrEmpty(value))
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
					this.v.DecimalPlaces = this.DecimalPlaces;
					this.v.ValueType = this.ValueTypeTB;
					this.v.SetStandardTextToFormat(value);
					return this.v.Text;
				}
			}
			if (true)
			{
			}
			return string.Empty;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00029E58 File Offset: 0x00028058
		protected override object GetFormattedValue(object value, int rowIndex, ref global::System.Windows.Forms.DataGridViewCellStyle cellStyle, global::System.ComponentModel.TypeConverter valueTypeConverter, global::System.ComponentModel.TypeConverter formattedValueTypeConverter, global::System.Windows.Forms.DataGridViewDataErrorContexts context)
		{
			int num = 0;
			string value2;
			for (;;)
			{
				switch (num)
				{
				case 1:
					goto IL_2F;
				case 2:
					goto IL_74;
				case 3:
					if (this.u != '\0')
					{
						num = 4;
						continue;
					}
					goto IL_B4;
				case 4:
					value2 = new string(this.u, value.ToString().Length);
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A4;
					default:
						if (true)
						{
						}
						if (false)
						{
						}
						num = 2;
						continue;
					}
					break;
				}
				if (value == null)
				{
					num = 1;
				}
				else
				{
					value2 = value.ToString();
					num = 3;
				}
			}
			IL_2F:
			goto IL_A4;
			IL_74:
			goto IL_B4;
			IL_A4:
			return base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
			IL_B4:
			return base.GetFormattedValue(value2, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00029F28 File Offset: 0x00028128
		internal void a(int A_0, string A_1)
		{
			for (;;)
			{
				if (true)
				{
				}
				this.t = A_1;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					if (false)
					{
					}
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.EditingTextBox.XmlRange = A_1;
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
						break;
					}
					break;
				}
				}
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00029FB0 File Offset: 0x000281B0
		internal void a(int A_0, char A_1)
		{
			for (;;)
			{
				this.u = A_1;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_72;
				default:
				{
					if (false)
					{
					}
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.EditingTextBox.PasswordChar = A_1;
							num = 2;
							continue;
						case 1:
							if (this.a(A_0))
							{
								num = 0;
								continue;
							}
							goto IL_72;
						case 2:
							goto IL_70;
						}
						break;
					}
					break;
				}
				}
			}
			IL_70:
			IL_72:
			if (true)
			{
			}
		}

		// Token: 0x04000159 RID: 345
		internal const long a = 0L;

		// Token: 0x0400015A RID: 346
		internal const long b = 0L;

		// Token: 0x0400015B RID: 347
		internal const int c = 0;

		// Token: 0x0400015C RID: 348
		internal const int d = 0;

		// Token: 0x0400015D RID: 349
		internal const char e = '\0';

		// Token: 0x0400015E RID: 350
		internal const int f = 204;

		// Token: 0x0400015F RID: 351
		internal const int g = 210;

		// Token: 0x04000160 RID: 352
		private bool h;

		// Token: 0x04000161 RID: 353
		private global::custom_controls.CCustomTextBox.valueTypes i;

		// Token: 0x04000162 RID: 354
		private string j;

		// Token: 0x04000163 RID: 355
		private bool k;

		// Token: 0x04000164 RID: 356
		private int l;

		// Token: 0x04000165 RID: 357
		private bool m;

		// Token: 0x04000166 RID: 358
		private long n;

		// Token: 0x04000167 RID: 359
		private long o;

		// Token: 0x04000168 RID: 360
		private bool p;

		// Token: 0x04000169 RID: 361
		private int q;

		// Token: 0x0400016A RID: 362
		private global::System.Windows.Forms.ContextMenu r;

		// Token: 0x0400016B RID: 363
		private bool s;

		// Token: 0x0400016C RID: 364
		private string t;

		// Token: 0x0400016D RID: 365
		private char u;

		// Token: 0x0400016E RID: 366
		private global::custom_controls.CCustomTextBox v;
	}
}
