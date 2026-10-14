using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using custom_exception;

namespace custom_controls
{
	// Token: 0x02000011 RID: 17
	public class CCustomDataGridView : global::System.Windows.Forms.DataGridView
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00007B44 File Offset: 0x00005D44
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00007B88 File Offset: 0x00005D88
		public bool AllowRowMove
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
				return this.d;
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
				this.d = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00007BCC File Offset: 0x00005DCC
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00007C10 File Offset: 0x00005E10
		public bool IsDataLoading
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
				return this.e;
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
				this.e = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00007C54 File Offset: 0x00005E54
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00007C98 File Offset: 0x00005E98
		public bool IsRowEdit
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
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00007CDC File Offset: 0x00005EDC
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00007D20 File Offset: 0x00005F20
		public bool CanEditCells
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
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00007D64 File Offset: 0x00005F64
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00007DA8 File Offset: 0x00005FA8
		public bool CanEditTreeNode
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
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00007DEC File Offset: 0x00005FEC
		public global::System.Collections.ArrayList SelectedRowIndex
		{
			get
			{
				global::System.Collections.ArrayList arrayList;
				for (;;)
				{
					arrayList = new global::System.Collections.ArrayList();
					int num;
					int num2;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_68:
						num = 0;
						num2 = 4;
						break;
					default:
						if (false)
						{
						}
						num2 = 2;
						break;
					}
					for (;;)
					{
						if (true)
						{
						}
						switch (num2)
						{
						case 0:
							if (num >= base.SelectedRows.Count)
							{
								num2 = 3;
								continue;
							}
							arrayList.Add(base.SelectedRows[num].Index);
							num++;
							num2 = 1;
							continue;
						case 1:
							goto IL_6A;
						case 2:
							if (base.SelectedRows.Count >= 0)
							{
								num2 = 5;
								continue;
							}
							return arrayList;
						case 3:
							return arrayList;
						case 4:
							goto IL_6A;
						case 5:
							goto IL_68;
						}
						break;
						IL_6A:
						num2 = 0;
					}
				}
				return arrayList;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00007ED0 File Offset: 0x000060D0
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00007F14 File Offset: 0x00006114
		public bool SortClicked
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
				return this.k;
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
				this.k = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00007F58 File Offset: 0x00006158
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00007F9C File Offset: 0x0000619C
		public bool SequenceDeletionFromBottom
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
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007FE0 File Offset: 0x000061E0
		public CCustomDataGridView()
		{
			this.a();
			this.f = string.Empty;
			this.e = false;
			this.s = 0;
			this.d = false;
			this.h = false;
			this.i = false;
			this.j = false;
			this.k = false;
			this.l = false;
			this.d();
			this.m = new global::System.Collections.ArrayList();
			this.t = false;
			this.u = false;
			this.g = global::System.Windows.Forms.SortOrder.None;
			base.SetStyle(global::System.Windows.Forms.ControlStyles.DoubleBuffer, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.UserPaint, true);
			base.BackgroundColor = global::System.Drawing.SystemColors.Window;
			base.EditingControlShowing -= this.a;
			base.EditingControlShowing += this.a;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000080B4 File Offset: 0x000062B4
		private void d()
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
			base.AllowUserToAddRows = false;
			base.AllowUserToDeleteRows = false;
			base.AllowUserToOrderColumns = false;
			base.AllowUserToResizeColumns = false;
			base.AllowUserToResizeRows = false;
			this.u = false;
			base.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			base.DefaultCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			base.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			base.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000813C File Offset: 0x0000633C
		public void CreateColumns(global::System.Collections.ArrayList ctrlArray, bool isDataFromRMServer = false)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Windows.Forms.Control control = null;
					int num = 0;
					int num2 = 17;
					for (;;)
					{
						global::custom_controls.DataGridViewCustomTextBoxColumn dataGridViewCustomTextBoxColumn;
						global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
						switch (num2)
						{
						case 0:
							if (control is global::System.Windows.Forms.TextBox)
							{
								num2 = 8;
								continue;
							}
							num2 = 23;
							continue;
						case 1:
						{
							global::System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn = new global::System.Windows.Forms.DataGridViewButtonColumn();
							dataGridViewButtonColumn.Name = control.Name;
							dataGridViewButtonColumn.HeaderText = control.Tag.ToString();
							dataGridViewButtonColumn.Width = control.Width;
							dataGridViewButtonColumn.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
							dataGridViewButtonColumn.DefaultCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
							base.Columns.Add(dataGridViewButtonColumn);
							num2 = 7;
							continue;
						}
						case 2:
							if (control is global::custom_controls.CCustomCheckBox)
							{
								num2 = 18;
								continue;
							}
							num2 = 13;
							continue;
						case 3:
							goto IL_226;
						case 4:
							goto IL_470;
						case 5:
							if ("PGK_HEADER" == dataGridViewCustomTextBoxColumn.Name)
							{
								num2 = 14;
								continue;
							}
							goto IL_197;
						case 6:
							if (((global::System.Windows.Forms.ComboBox)control).Sorted)
							{
								num2 = 25;
								continue;
							}
							goto IL_470;
						case 7:
							goto IL_226;
						case 8:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_4EC;
							default:
							{
								if (false)
								{
								}
								global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
								dataGridViewTextBoxColumn.Name = control.Name;
								dataGridViewTextBoxColumn.HeaderText = control.Tag.ToString();
								dataGridViewTextBoxColumn.Width = control.Width;
								dataGridViewTextBoxColumn.ReadOnly = ((global::System.Windows.Forms.TextBox)control).ReadOnly;
								dataGridViewTextBoxColumn.Frozen = true;
								dataGridViewTextBoxColumn.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
								dataGridViewTextBoxColumn.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
								base.Columns.Add(dataGridViewTextBoxColumn);
								dataGridViewTextBoxColumn.DefaultCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
								num2 = 21;
								continue;
							}
							}
							break;
						case 9:
							if (num >= ctrlArray.Count)
							{
								num2 = 15;
								continue;
							}
							control = (global::System.Windows.Forms.Control)ctrlArray[num];
							num2 = 32;
							continue;
						case 10:
							num2 = 2;
							continue;
						case 11:
							dataGridViewCustomTextBoxColumn = new global::custom_controls.DataGridViewCustomTextBoxColumn();
							dataGridViewCustomTextBoxColumn.SetColumnProperties(control);
							num2 = 33;
							continue;
						case 12:
							goto IL_226;
						case 13:
							if (!(control is global::System.Windows.Forms.ComboBox))
							{
								num2 = 22;
								continue;
							}
							goto IL_B7;
						case 14:
							goto IL_395;
						case 15:
							return;
						case 16:
							goto IL_30F;
						case 17:
							goto IL_30F;
						case 18:
							goto IL_12F;
						case 19:
							goto IL_226;
						case 20:
							if (!(control is global::System.Windows.Forms.CheckBox))
							{
								goto IL_4EC;
							}
							goto IL_12F;
						case 21:
							goto IL_226;
						case 22:
							num2 = 29;
							continue;
						case 23:
							if (control is global::custom_controls.CustomNumericUpDown)
							{
								num2 = 26;
								continue;
							}
							num2 = 20;
							continue;
						case 24:
							goto IL_B7;
						case 25:
							dataGridViewComboBoxColumn.Tag = "Sorted";
							num2 = 4;
							continue;
						case 26:
						{
							global::custom_controls.DataGridViewNumericUpDownColumn dataGridViewNumericUpDownColumn = new global::custom_controls.DataGridViewNumericUpDownColumn();
							dataGridViewNumericUpDownColumn.SetColumnProperties(control);
							base.Columns.Add(dataGridViewNumericUpDownColumn);
							num2 = 19;
							continue;
						}
						case 27:
							goto IL_226;
						case 28:
							if (control is global::System.Windows.Forms.Button)
							{
								num2 = 1;
								continue;
							}
							goto IL_226;
						case 29:
							if (true)
							{
							}
							if (control is global::custom_controls.CCustomComBoBox)
							{
								num2 = 24;
								continue;
							}
							num2 = 28;
							continue;
						case 30:
							goto IL_197;
						case 31:
							num2 = 5;
							continue;
						case 32:
							if (control is global::custom_controls.CCustomTextBox)
							{
								num2 = 11;
								continue;
							}
							num2 = 0;
							continue;
						case 33:
							if (!("POSITION" == dataGridViewCustomTextBoxColumn.Name))
							{
								num2 = 31;
								continue;
							}
							goto IL_395;
						}
						break;
						IL_B7:
						dataGridViewComboBoxColumn = new global::System.Windows.Forms.DataGridViewComboBoxColumn();
						dataGridViewComboBoxColumn.Name = control.Name;
						dataGridViewComboBoxColumn.HeaderText = control.Tag.ToString();
						dataGridViewComboBoxColumn.Width = control.Width;
						dataGridViewComboBoxColumn.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
						dataGridViewComboBoxColumn.DisplayStyleForCurrentCellOnly = true;
						dataGridViewComboBoxColumn.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
						num2 = 6;
						continue;
						IL_12F:
						global::System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
						dataGridViewCheckBoxColumn.Name = control.Name;
						dataGridViewCheckBoxColumn.HeaderText = control.Tag.ToString();
						dataGridViewCheckBoxColumn.Width = control.Width;
						dataGridViewCheckBoxColumn.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
						dataGridViewCheckBoxColumn.DefaultCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
						base.Columns.Add(dataGridViewCheckBoxColumn);
						num2 = 3;
						continue;
						IL_197:
						base.Columns.Add(dataGridViewCustomTextBoxColumn);
						num2 = 12;
						continue;
						IL_226:
						num++;
						num2 = 16;
						continue;
						IL_30F:
						num2 = 9;
						continue;
						IL_395:
						global::System.Type typeFromHandle = typeof(int);
						dataGridViewCustomTextBoxColumn.ValueType = typeFromHandle;
						num2 = 30;
						continue;
						IL_470:
						dataGridViewComboBoxColumn.DefaultCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
						dataGridViewComboBoxColumn.Selected = false;
						base.Columns.Add(dataGridViewComboBoxColumn);
						num2 = 27;
						continue;
						IL_4EC:
						num2 = 10;
					}
				}
				return;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000086B8 File Offset: 0x000068B8
		public bool IsColumnExist(string columnName)
		{
			switch (0)
			{
			default:
			{
				bool result;
				global::System.Collections.IEnumerator enumerator;
				for (;;)
				{
					result = false;
					int num = 5;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (columnName != "ALIAS")
							{
								num = 1;
								continue;
							}
							enumerator = base.Columns.GetEnumerator();
							num = 2;
							continue;
						case 1:
						{
							global::System.Collections.IEnumerator enumerator2 = base.Columns.GetEnumerator();
							num = 4;
							continue;
						}
						case 2:
							goto IL_78;
						case 3:
							if (true)
							{
							}
							num = 0;
							continue;
						case 4:
							goto IL_8F;
						case 5:
							if (!string.IsNullOrEmpty(columnName))
							{
								num = 3;
								continue;
							}
							return result;
						}
						break;
					}
				}
				IL_78:
				try
				{
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							num = 6;
							continue;
						case 1:
							goto IL_173;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = 1;
								continue;
							}
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn = (global::System.Windows.Forms.DataGridViewColumn)enumerator.Current;
							num = 8;
							continue;
						}
						case 4:
							goto IL_17F;
						case 5:
							goto IL_173;
						case 6:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							if (columnName.Equals(dataGridViewColumn.Tag.ToString()))
							{
								num = 7;
								continue;
							}
							break;
						}
						case 7:
							result = true;
							num = 5;
							continue;
						case 8:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							if (dataGridViewColumn.Tag != null)
							{
								num = 0;
								continue;
							}
							break;
						}
						}
						IL_129:
						num = 3;
						continue;
						goto IL_129;
						IL_173:
						num = 4;
					}
					IL_17F:
					return result;
				}
				finally
				{
					for (;;)
					{
						global::System.IDisposable disposable = enumerator as global::System.IDisposable;
						int num = 1;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_1CA;
							case 1:
								if (disposable != null)
								{
									num = 2;
									continue;
								}
								goto IL_1CC;
							case 2:
								disposable.Dispose();
								num = 0;
								continue;
							}
							break;
						}
					}
					IL_1CA:
					IL_1CC:;
				}
				IL_8F:
				try
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_254;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_252;
							default:
								goto IL_276;
							}
							break;
						case 3:
							goto IL_252;
						case 4:
						{
							global::System.Collections.IEnumerator enumerator2;
							if (!enumerator2.MoveNext())
							{
								num = 3;
								continue;
							}
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn2 = (global::System.Windows.Forms.DataGridViewColumn)enumerator2.Current;
							num = 6;
							continue;
						}
						case 5:
							result = true;
							num = 1;
							continue;
						case 6:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn2;
							if (columnName.Equals(dataGridViewColumn2.Name))
							{
								num = 5;
								continue;
							}
							break;
						}
						}
						IL_238:
						num = 4;
						continue;
						goto IL_238;
						IL_254:
						num = 2;
						continue;
						IL_252:
						goto IL_254;
					}
					IL_276:
					if (false)
					{
					}
				}
				finally
				{
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator2;
						global::System.IDisposable disposable2 = enumerator2 as global::System.IDisposable;
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (disposable2 != null)
								{
									num = 1;
									continue;
								}
								goto IL_2C5;
							case 1:
								disposable2.Dispose();
								num = 2;
								continue;
							case 2:
								goto IL_2C3;
							}
							break;
						}
					}
					IL_2C3:
					IL_2C5:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000089A8 File Offset: 0x00006BA8
		public void AllowSort(global::System.Windows.Forms.DataGridViewColumnSortMode sortMode)
		{
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
				global::System.Collections.IEnumerator enumerator = base.Columns.GetEnumerator();
				try
				{
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							((global::System.Windows.Forms.DataGridViewTextBoxColumn)dataGridViewColumn).SortMode = sortMode;
							num = 5;
							continue;
						}
						case 2:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							if (dataGridViewColumn is global::custom_controls.DataGridViewCustomTextBoxColumn)
							{
								num = 4;
								continue;
							}
							num = 13;
							continue;
						}
						case 4:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							((global::custom_controls.DataGridViewCustomTextBoxColumn)dataGridViewColumn).SortMode = sortMode;
							num = 6;
							continue;
						}
						case 7:
							num = 14;
							continue;
						case 8:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).SortMode = sortMode;
							num = 1;
							continue;
						}
						case 9:
						{
							if (!enumerator.MoveNext())
							{
								num = 7;
								continue;
							}
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn = (global::System.Windows.Forms.DataGridViewColumn)enumerator.Current;
							num = 2;
							continue;
						}
						case 10:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							if (dataGridViewColumn is global::custom_controls.DataGridViewNumericUpDownColumn)
							{
								num = 8;
								continue;
							}
							break;
						}
						case 11:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							((global::System.Windows.Forms.DataGridViewComboBoxColumn)dataGridViewColumn).SortMode = sortMode;
							num = 15;
							continue;
						}
						case 12:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							if (dataGridViewColumn is global::System.Windows.Forms.DataGridViewComboBoxColumn)
							{
								num = 11;
								continue;
							}
							num = 10;
							continue;
						}
						case 13:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							if (dataGridViewColumn is global::System.Windows.Forms.DataGridViewTextBoxColumn)
							{
								num = 0;
								continue;
							}
							num = 12;
							continue;
						}
						case 14:
							goto IL_19E;
						}
						IL_FE:
						num = 9;
						continue;
						goto IL_FE;
					}
					IL_19E:;
				}
				finally
				{
					for (;;)
					{
						global::System.IDisposable disposable = enumerator as global::System.IDisposable;
						int num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								disposable.Dispose();
								num = 1;
								continue;
							case 1:
								goto IL_1DE;
							case 2:
								if (disposable != null)
								{
									num = 0;
									continue;
								}
								goto IL_1E0;
							}
							break;
						}
					}
					IL_1DE:
					IL_1E0:;
				}
				break;
			}
			}
			if (true)
			{
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00008BBC File Offset: 0x00006DBC
		public int AddRowAtTheEnd()
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
			global::custom_controls.CCustomDataGridViewRow dataGridViewRow = new global::custom_controls.CCustomDataGridViewRow();
			return base.Rows.Add(dataGridViewRow);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00008C0C File Offset: 0x00006E0C
		public void DeleteRowAt(int rowIndex)
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
			base.Rows.RemoveAt(rowIndex);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00008C54 File Offset: 0x00006E54
		public void DeleteRows()
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator = base.SelectedRows.GetEnumerator();
					int num = 7;
					for (;;)
					{
						global::System.Windows.Forms.DataGridViewColumn columnByName;
						switch (num)
						{
						case 0:
							num = 9;
							continue;
						case 1:
						{
							global::System.Windows.Forms.DataGridViewColumn sortedColumn;
							if (sortedColumn == null)
							{
								num = 0;
								continue;
							}
							goto IL_2BE;
						}
						case 2:
							goto IL_144;
						case 3:
							if (columnByName != null)
							{
								num = 13;
								continue;
							}
							goto IL_EF;
						case 4:
							return;
						case 5:
							if (base.CurrentCell != null)
							{
								num = 17;
								continue;
							}
							return;
						case 6:
							goto IL_EF;
						case 7:
						{
							try
							{
								num = 2;
								for (;;)
								{
									switch (num)
									{
									case 1:
										goto IL_268;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = 4;
											continue;
										}
										global::System.Windows.Forms.DataGridViewRow dataGridViewRow = (global::System.Windows.Forms.DataGridViewRow)enumerator.Current;
										base.Rows.Remove(dataGridViewRow);
										num = 0;
										continue;
									}
									case 4:
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
									}
									IL_223:
									num = 3;
									continue;
									IL_1FD:
									goto IL_223;
									goto IL_1FD;
								}
								IL_268:
								goto IL_C8;
							}
							finally
							{
								if (true)
								{
								}
								for (;;)
								{
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									num = 0;
									for (;;)
									{
										switch (num)
										{
										case 0:
											if (disposable != null)
											{
												num = 1;
												continue;
											}
											goto IL_2BD;
										case 1:
											disposable.Dispose();
											num = 2;
											continue;
										case 2:
											goto IL_2BB;
										}
										break;
									}
								}
								IL_2BB:
								IL_2BD:;
							}
							goto IL_2BE;
							IL_C8:
							global::System.Windows.Forms.DataGridViewColumn sortedColumn = base.SortedColumn;
							num = 1;
							continue;
						}
						case 8:
							goto IL_8C;
						case 9:
							if (base.SortOrder == global::System.Windows.Forms.SortOrder.None)
							{
								num = 10;
								continue;
							}
							goto IL_2BE;
						case 10:
							this.ResetPosition();
							num = 6;
							continue;
						case 11:
							if (base.CurrentCell.IsInEditMode)
							{
								num = 12;
								continue;
							}
							return;
						case 12:
							base.CurrentCell.DataGridView.EndEdit();
							num = 2;
							continue;
						case 13:
						{
							this.Sort(columnByName, global::System.ComponentModel.ListSortDirection.Ascending);
							this.ResetPosition();
							global::System.Windows.Forms.DataGridViewColumn sortedColumn;
							global::System.ComponentModel.ListSortDirection direction;
							this.Sort(sortedColumn, direction);
							num = 15;
							continue;
						}
						case 14:
						{
							global::System.ComponentModel.ListSortDirection direction = global::System.ComponentModel.ListSortDirection.Ascending;
							num = 8;
							continue;
						}
						case 15:
							goto IL_EF;
						case 16:
						{
							if (base.SortOrder == global::System.Windows.Forms.SortOrder.Ascending)
							{
								num = 14;
								continue;
							}
							global::System.ComponentModel.ListSortDirection direction = global::System.ComponentModel.ListSortDirection.Descending;
							num = 19;
							continue;
						}
						case 17:
							num = 11;
							continue;
						case 18:
							if (!this.IsColumnExist("POSITION"))
							{
								num = 4;
								continue;
							}
							num = 16;
							continue;
						case 19:
							goto IL_8C;
						}
						break;
						IL_8C:
						columnByName = this.GetColumnByName("POSITION");
						num = 3;
						continue;
						IL_EF:
						num = 5;
						continue;
						IL_2BE:
						num = 18;
					}
				}
				IL_144:
				return;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00008F84 File Offset: 0x00007184
		public void ResizeDataGridView()
		{
			int num = 0;
			for (;;)
			{
				int gridHeight;
				switch (num)
				{
				case 1:
					return;
				case 2:
					goto IL_62;
				case 3:
					if (base.Height != gridHeight)
					{
						num = 4;
						continue;
					}
					return;
				case 4:
					base.Height = gridHeight;
					num = 5;
					continue;
				case 5:
					goto IL_B5;
				case 6:
				{
					int num2;
					base.Width = num2;
					num = 2;
					continue;
				}
				case 7:
				{
					int num2;
					if (base.Width != num2)
					{
						num = 6;
						continue;
					}
					goto IL_62;
				}
				}
				if (global::System.Windows.Forms.DockStyle.Fill != this.Dock)
				{
					int num2 = this.c();
					num = 7;
					continue;
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
					num = 1;
					continue;
				}
				IL_62:
				gridHeight = this.GetGridHeight();
				num = 3;
			}
			return;
			IL_B5:
			if (true)
			{
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00009078 File Offset: 0x00007278
		private int c()
		{
			switch (0)
			{
			default:
			{
				int num;
				for (;;)
				{
					num = 0;
					global::System.Collections.IEnumerator enumerator = base.Columns.GetEnumerator();
					int num2 = 1;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_17B;
						case 1:
							try
							{
								num2 = 3;
								for (;;)
								{
									switch (num2)
									{
									case 1:
										num2 = 2;
										continue;
									case 2:
										goto IL_100;
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num2 = 1;
											continue;
										}
										global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn = (global::System.Windows.Forms.DataGridViewColumn)enumerator.Current;
										num2 = 5;
										continue;
									}
									case 5:
									{
										global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
										if (dataGridViewColumn.Visible)
										{
											num2 = 6;
											continue;
										}
										break;
									}
									case 6:
									{
										global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
										num += dataGridViewColumn.Width;
										num2 = 0;
										continue;
									}
									}
									IL_C4:
									num2 = 4;
									continue;
									goto IL_C4;
								}
								IL_100:
								goto IL_40;
							}
							finally
							{
								for (;;)
								{
									IL_136:
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									num2 = 0;
									for (;;)
									{
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_165;
										default:
											if (false)
											{
											}
											switch (num2)
											{
											case 0:
												if (disposable != null)
												{
													num2 = 1;
													continue;
												}
												goto IL_165;
											case 1:
												disposable.Dispose();
												num2 = 2;
												continue;
											case 2:
												goto IL_163;
											}
											goto IL_136;
										}
									}
								}
								IL_163:
								IL_165:;
							}
							goto IL_166;
							IL_40:
							num2 = 2;
							continue;
						case 2:
							if (base.RowHeadersVisible)
							{
								num2 = 3;
								continue;
							}
							goto IL_17D;
						case 3:
							goto IL_166;
						}
						break;
						IL_166:
						num += base.RowHeadersWidth;
						num2 = 0;
					}
				}
				IL_17B:
				IL_17D:
				if (true)
				{
				}
				num += global::System.Windows.Forms.SystemInformation.Border3DSize.Width;
				return num;
			}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000922C File Offset: 0x0000742C
		public int GetGridHeight()
		{
			switch (0)
			{
			default:
			{
				int num = 0;
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)base.Rows).GetEnumerator();
				try
				{
					int num2 = 4;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							num2 = 3;
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num2 = 1;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = (global::System.Windows.Forms.DataGridViewRow)enumerator.Current;
							num += dataGridViewRow.GetPreferredHeight(dataGridViewRow.Index, global::System.Windows.Forms.DataGridViewAutoSizeRowMode.AllCells, false);
							num2 = 0;
							continue;
						}
						case 3:
							goto IL_93;
						}
						IL_6E:
						num2 = 2;
						continue;
						goto IL_6E;
					}
					IL_93:;
				}
				finally
				{
					for (;;)
					{
						global::System.IDisposable disposable = enumerator as global::System.IDisposable;
						int num2;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_E2:
							disposable.Dispose();
							num2 = 0;
							break;
						default:
							if (false)
							{
							}
							num2 = 1;
							break;
						}
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_F3;
							case 1:
								if (disposable != null)
								{
									num2 = 2;
									continue;
								}
								goto IL_F5;
							case 2:
								goto IL_E2;
							}
							break;
						}
					}
					IL_F3:
					IL_F5:;
				}
				if (true)
				{
				}
				num += base.ColumnHeadersHeight;
				num += global::System.Windows.Forms.SystemInformation.Border3DSize.Width;
				return num;
			}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000936C File Offset: 0x0000756C
		protected override void OnCellFormatting(global::System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
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
				base.OnCellFormatting(e);
				try
				{
					for (;;)
					{
						global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow = (global::custom_controls.CCustomDataGridViewRow)base.Rows[e.RowIndex];
						int num = 4;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_F6;
							case 1:
								goto IL_EB;
							case 2:
								base.Columns[e.ColumnIndex].Selected = false;
								e.CellStyle.BackColor = base.ColumnHeadersDefaultCellStyle.BackColor;
								num = 3;
								continue;
							case 3:
								goto IL_EB;
							case 4:
								if (ccustomDataGridViewRow.Cells[e.ColumnIndex].ReadOnly)
								{
									num = 2;
									continue;
								}
								e.CellStyle.BackColor = global::System.Drawing.SystemColors.Window;
								num = 1;
								continue;
							}
							break;
							IL_EB:
							num = 0;
						}
					}
					IL_F6:;
				}
				catch (global::System.Exception)
				{
				}
				break;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00009484 File Offset: 0x00007684
		protected override void OnRowPostPaint(global::System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_34;
			}
			if (false)
			{
			}
			switch (0)
			{
			default:
				IL_34:
				base.OnRowPostPaint(e);
				try
				{
					for (;;)
					{
						global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow = (global::custom_controls.CCustomDataGridViewRow)base.Rows[e.RowIndex];
						global::System.Drawing.Image rowImage = ccustomDataGridViewRow.RowImage;
						global::System.Drawing.Point point = new global::System.Drawing.Point(e.RowBounds.Location.X + 12, e.RowBounds.Location.Y + 4);
						int num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								e.Graphics.DrawImage(rowImage, point);
								num = 3;
								continue;
							case 1:
								goto IL_F8;
							case 2:
								if (rowImage != null)
								{
									num = 0;
									continue;
								}
								goto IL_EC;
							case 3:
								if (true)
								{
								}
								goto IL_EC;
							}
							break;
							IL_EC:
							num = 1;
						}
					}
					IL_F8:;
				}
				catch (global::System.Exception)
				{
				}
				return;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000095A0 File Offset: 0x000077A0
		protected override void OnCurrentCellDirtyStateChanged(global::System.EventArgs e)
		{
			for (;;)
			{
				if (true)
				{
				}
				base.OnCurrentCellDirtyStateChanged(e);
				global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn = base.Columns[base.CurrentCell.ColumnIndex];
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						num = 1;
						continue;
					case 1:
						if (base.IsCurrentCellDirty)
						{
							num = 3;
							continue;
						}
						return;
					case 2:
						if (dataGridViewColumn is global::System.Windows.Forms.DataGridViewCheckBoxColumn)
						{
							num = 0;
							continue;
						}
						return;
					case 3:
						for (;;)
						{
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_72;
							}
						}
						IL_72:
						if (false)
						{
						}
						base.CommitEdit(global::System.Windows.Forms.DataGridViewDataErrorContexts.Commit);
						num = 4;
						continue;
					case 4:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00009668 File Offset: 0x00007868
		protected override void OnDataError(bool displayErrorDialogIfNoHandler, global::System.Windows.Forms.DataGridViewDataErrorEventArgs e)
		{
			if (true)
			{
			}
			global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn = base.Columns[e.ColumnIndex];
			if (!(dataGridViewColumn is global::System.Windows.Forms.DataGridViewComboBoxColumn))
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
					base.OnDataError(displayErrorDialogIfNoHandler, e);
					return;
				}
			}
			e.Cancel = false;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000096D0 File Offset: 0x000078D0
		protected override void OnCellBeginEdit(global::System.Windows.Forms.DataGridViewCellCancelEventArgs e)
		{
			for (;;)
			{
				base.OnCellBeginEdit(e);
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_7C;
					case 1:
						if (this.ae == null)
						{
							goto IL_7E;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							if (false)
							{
							}
							if (true)
							{
							}
							num = 2;
							continue;
						}
						break;
					case 2:
						this.ae(this, new global::System.EventArgs());
						num = 0;
						continue;
					}
					break;
				}
			}
			IL_7C:
			IL_7E:
			base.ClearSelection();
			base.Invalidate();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00009768 File Offset: 0x00007968
		protected override void OnMouseDown(global::System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						base.OnMouseDown(e);
						global::System.Windows.Forms.DataGridView.HitTestInfo hitTestInfo = base.HitTest(e.X, e.Y);
						int num = 30;
						for (;;)
						{
							global::System.Drawing.Bitmap bitmap;
							int num3;
							int num4;
							int num5;
							int num6;
							int num8;
							int width;
							int height;
							global::System.Drawing.Rectangle rectangle;
							global::System.Drawing.Point a_;
							global::custom_controls.g g;
							switch (num)
							{
							case 0:
							{
								global::System.Drawing.Bitmap bitmap2;
								bitmap = new global::System.Drawing.Bitmap(bitmap2.Width, bitmap2.Height, global::System.Drawing.Imaging.PixelFormat.Format32bppArgb);
								global::System.Drawing.Graphics graphics = global::System.Drawing.Graphics.FromImage(bitmap);
								graphics.DrawImage(bitmap2, 0, 0);
								graphics.Dispose();
								bitmap2.Dispose();
								num = 15;
								continue;
							}
							case 1:
								goto IL_F72;
							case 2:
								goto IL_23D;
							case 3:
								goto IL_471;
							case 4:
								if (base.EditingControl != null)
								{
									num = 35;
									continue;
								}
								goto IL_E89;
							case 5:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_471;
								default:
									if (false)
									{
									}
									num = 7;
									continue;
								}
								break;
							case 6:
								goto IL_20E;
							case 7:
								goto IL_3A1;
							case 8:
								try
								{
									num = 4;
									for (;;)
									{
										int num2;
										switch (num)
										{
										case 0:
										{
											global::System.Windows.Forms.DataGridViewCell currentCell;
											if (currentCell.Value == null)
											{
												num = 6;
												continue;
											}
											goto IL_D88;
										}
										case 1:
											goto IL_E44;
										case 2:
										{
											global::System.Windows.Forms.DataGridViewCell currentCell = base.CurrentCell;
											global::System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows = base.SelectedRows;
											base.CurrentCell = null;
											num = 0;
											continue;
										}
										case 3:
											goto IL_D88;
										case 5:
										{
											if (hitTestInfo.RowIndex > -1)
											{
												num = 10;
												continue;
											}
											global::System.Windows.Forms.DataGridViewCell currentCell;
											base.CurrentCell = base.Rows[currentCell.RowIndex].Cells[currentCell.ColumnIndex];
											num = 7;
											continue;
										}
										case 6:
										{
											global::System.Windows.Forms.DataGridViewCell currentCell;
											currentCell.Value = "";
											num = 3;
											continue;
										}
										case 7:
											goto IL_DDF;
										case 8:
											goto IL_E38;
										case 9:
											goto IL_E13;
										case 10:
										{
											global::System.Windows.Forms.DataGridViewCell currentCell;
											base.CurrentCell = base.Rows[currentCell.RowIndex].Cells[0];
											num = 12;
											continue;
										}
										case 11:
											goto IL_E13;
										case 12:
											goto IL_DDF;
										case 13:
										{
											global::System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows;
											if (num2 >= selectedRows.Count)
											{
												num = 8;
												continue;
											}
											selectedRows[num2].Selected = true;
											num2++;
											num = 9;
											continue;
										}
										}
										if (base.CurrentCell != null)
										{
											num = 2;
											continue;
										}
										goto IL_E38;
										IL_D88:
										num = 5;
										continue;
										IL_DDF:
										num2 = 0;
										num = 11;
										continue;
										IL_E13:
										num = 13;
										continue;
										IL_E38:
										num = 1;
									}
									IL_E44:
									goto IL_280;
								}
								finally
								{
									num = 1;
									for (;;)
									{
										global::custom_controls.CCustomDataGridView.DataLoader dataLoader;
										switch (num)
										{
										case 0:
											goto IL_E86;
										case 2:
											((global::System.IDisposable)dataLoader).Dispose();
											num = 0;
											continue;
										}
										if (dataLoader == null)
										{
											break;
										}
										num = 2;
									}
									IL_E86:;
								}
								goto IL_E89;
								IL_280:
								this.ad(this, e);
								num = 1;
								continue;
							case 9:
								num3 = base.Width - base.VerticalScrollBar.Width - 5;
								num = 34;
								continue;
							case 10:
								goto IL_29E;
							case 11:
								goto IL_F7E;
							case 12:
								if (num4 >= this.m.Count)
								{
									num = 20;
									continue;
								}
								this.m[num4] = null;
								num4++;
								num = 52;
								continue;
							case 13:
							{
								bool flag;
								if (!flag)
								{
									num = 0;
									continue;
								}
								global::System.Drawing.Bitmap bitmap2;
								bitmap = bitmap2;
								if (true)
								{
								}
								num = 10;
								continue;
							}
							case 14:
								if (this.ad != null)
								{
									num = 42;
									continue;
								}
								goto IL_F72;
							case 15:
								goto IL_29E;
							case 16:
								num = 37;
								continue;
							case 17:
								if (this.ad != null)
								{
									num = 19;
									continue;
								}
								goto IL_139;
							case 18:
								goto IL_E89;
							case 19:
								this.ad(this, e);
								num = 3;
								continue;
							case 20:
								this.m.Clear();
								num5 = 0;
								num = 39;
								continue;
							case 21:
								goto IL_3A1;
							case 22:
								if (e.Button == global::System.Windows.Forms.MouseButtons.Left)
								{
									num = 47;
									continue;
								}
								num = 44;
								continue;
							case 23:
							{
								if (num5 >= base.SelectedRows.Count)
								{
									num = 5;
									continue;
								}
								int num7;
								num6 = num7;
								num8 = base.GetCellDisplayRectangle(0, hitTestInfo.RowIndex, false).Y;
								width = num3;
								int height2;
								height = height2;
								int num9 = num8 - base.GetCellDisplayRectangle(0, 0, false).Y;
								rectangle = new global::System.Drawing.Rectangle(num6, num9, width, height);
								a_ = new global::System.Drawing.Point(e.X - num6, e.Y - num8);
								this.s = height;
								global::System.Drawing.Bitmap bitmap2 = null;
								this.a(ref bitmap2);
								bool flag = global::System.Drawing.Image.IsAlphaPixelFormat(bitmap2.PixelFormat);
								num = 13;
								continue;
							}
							case 24:
								base.CurrentCell = null;
								base.CommitEdit(global::System.Windows.Forms.DataGridViewDataErrorContexts.Commit);
								num = 18;
								continue;
							case 25:
								if (!base.EditingControl.Text.Equals(base.CurrentCell.Value))
								{
									num = 24;
									continue;
								}
								goto IL_E89;
							case 26:
							{
								global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow;
								if (ccustomDataGridViewRow.Cells[hitTestInfo.ColumnIndex].ReadOnly)
								{
									num = 40;
									continue;
								}
								ccustomDataGridViewRow.Cells[hitTestInfo.ColumnIndex].Selected = true;
								base.CurrentCell.DataGridView.BeginEdit(false);
								num = 49;
								continue;
							}
							case 27:
							{
								global::System.Windows.Forms.DataGridViewHitTestType type;
								switch (type)
								{
								case global::System.Windows.Forms.DataGridViewHitTestType.Cell:
								{
									base.Rows[hitTestInfo.RowIndex].Selected = true;
									global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow = base.Rows[hitTestInfo.RowIndex] as global::custom_controls.CCustomDataGridViewRow;
									base.CurrentCell = base.Rows[hitTestInfo.RowIndex].Cells[hitTestInfo.ColumnIndex];
									num = 26;
									continue;
								}
								case global::System.Windows.Forms.DataGridViewHitTestType.ColumnHeader:
									this.k = true;
									num = 21;
									continue;
								case global::System.Windows.Forms.DataGridViewHitTestType.RowHeader:
								{
									this.t = true;
									this.u = true;
									int num7 = 2;
									num3 = 0;
									int height2 = base.Rows[hitTestInfo.RowIndex].Height;
									this.n = hitTestInfo.RowIndex;
									num = 32;
									continue;
								}
								default:
									num = 16;
									continue;
								}
								break;
							}
							case 28:
								goto IL_3A1;
							case 29:
								if (bitmap != null)
								{
									num = 31;
									continue;
								}
								goto IL_C4B;
							case 30:
								if (hitTestInfo.Type != global::System.Windows.Forms.DataGridViewHitTestType.Cell)
								{
									num = 46;
									continue;
								}
								goto IL_E89;
							case 31:
							{
								global::System.Drawing.Rectangle rect = new global::System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height);
								global::System.Drawing.Imaging.BitmapData bitmapdata = bitmap.LockBits(rect, global::System.Drawing.Imaging.ImageLockMode.ReadWrite, bitmap.PixelFormat);
								bitmap.UnlockBits(bitmapdata);
								num = 38;
								continue;
							}
							case 32:
								if (base.VerticalScrollBar.Visible)
								{
									num = 9;
									continue;
								}
								num3 = base.Width - 5;
								num = 2;
								continue;
							case 33:
								if (hitTestInfo.Type != global::System.Windows.Forms.DataGridViewHitTestType.Cell)
								{
									num = 51;
									continue;
								}
								goto IL_F72;
							case 34:
								goto IL_23D;
							case 35:
								num = 25;
								continue;
							case 36:
								if (this.AllowDrop)
								{
									num = 41;
									continue;
								}
								goto IL_ED7;
							case 37:
								goto IL_3A1;
							case 38:
								goto IL_C4B;
							case 39:
								goto IL_20E;
							case 40:
							{
								global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow;
								ccustomDataGridViewRow.Cells[hitTestInfo.ColumnIndex].Selected = false;
								ccustomDataGridViewRow.Cells[hitTestInfo.ColumnIndex].Style.BackColor = base.ColumnHeadersDefaultCellStyle.BackColor;
								num = 17;
								continue;
							}
							case 41:
								this.r.Add(g);
								num = 54;
								continue;
							case 42:
							{
								global::custom_controls.CCustomDataGridView.DataLoader dataLoader = new global::custom_controls.CCustomDataGridView.DataLoader(this);
								num = 8;
								continue;
							}
							case 43:
							{
								global::custom_controls.CCustomDataGridView.DataLoader dataLoader2 = new global::custom_controls.CCustomDataGridView.DataLoader(this);
								num = 53;
								continue;
							}
							case 44:
								if (e.Button == global::System.Windows.Forms.MouseButtons.Right)
								{
									num = 43;
									continue;
								}
								goto IL_3A1;
							case 45:
								goto IL_139;
							case 46:
								num = 4;
								continue;
							case 47:
							{
								global::System.Windows.Forms.DataGridViewHitTestType type = hitTestInfo.Type;
								num = 27;
								continue;
							}
							case 48:
								goto IL_372;
							case 49:
								if (this.ae != null)
								{
									num = 50;
									continue;
								}
								goto IL_139;
							case 50:
								this.ae(this, e);
								num = 45;
								continue;
							case 51:
								num = 14;
								continue;
							case 52:
								goto IL_372;
							case 53:
								try
								{
									num = 9;
									for (;;)
									{
										switch (num)
										{
										case 0:
											if (!base.Rows[hitTestInfo.RowIndex].Selected)
											{
												num = 39;
												continue;
											}
											goto IL_AD8;
										case 1:
											num = 25;
											continue;
										case 2:
											base.CurrentCell = base.Rows[hitTestInfo.RowIndex].Cells[0];
											base.Rows[hitTestInfo.RowIndex].Selected = true;
											num = 18;
											continue;
										case 3:
											if (hitTestInfo.Type == global::System.Windows.Forms.DataGridViewHitTestType.TopLeftHeader)
											{
												num = 5;
												continue;
											}
											goto IL_BFA;
										case 4:
											base.CurrentCell = base.Rows[base.CurrentCell.RowIndex].Cells[0];
											base.Rows[base.CurrentCell.RowIndex].Selected = true;
											num = 38;
											continue;
										case 5:
											num = 21;
											continue;
										case 6:
											base.Focus();
											num = 12;
											continue;
										case 7:
											base.CurrentCell = base.Rows[hitTestInfo.RowIndex].Cells[0];
											base.Rows[hitTestInfo.RowIndex].Selected = true;
											num = 24;
											continue;
										case 8:
											if (base.Rows.Count > 0)
											{
												num = 23;
												continue;
											}
											goto IL_845;
										case 10:
											base.Focus();
											num = 26;
											continue;
										case 11:
											num = 16;
											continue;
										case 12:
											goto IL_BFA;
										case 13:
											goto IL_A9F;
										case 14:
											if (base.SelectedRows.Count <= 0)
											{
												num = 4;
												continue;
											}
											base.SelectedRows[0].Selected = false;
											num = 29;
											continue;
										case 15:
											if (!this.Focused)
											{
												num = 6;
												continue;
											}
											goto IL_BFA;
										case 16:
											if (!base.Rows[base.CurrentCell.RowIndex].Selected)
											{
												num = 34;
												continue;
											}
											goto IL_979;
										case 17:
											goto IL_B64;
										case 18:
											goto IL_AD8;
										case 19:
											if (hitTestInfo.Type == global::System.Windows.Forms.DataGridViewHitTestType.Cell)
											{
												num = 1;
												continue;
											}
											num = 3;
											continue;
										case 20:
											goto IL_BFA;
										case 21:
											if (!this.Focused)
											{
												num = 10;
												continue;
											}
											goto IL_BFA;
										case 22:
											if (!this.Focused)
											{
												num = 40;
												continue;
											}
											goto IL_BFA;
										case 23:
											num = 36;
											continue;
										case 24:
											goto IL_917;
										case 25:
											if (hitTestInfo.RowIndex != -1)
											{
												num = 27;
												continue;
											}
											goto IL_917;
										case 26:
											goto IL_BFA;
										case 27:
											num = 32;
											continue;
										case 28:
											goto IL_B64;
										case 29:
											goto IL_A9F;
										case 30:
											num = 8;
											continue;
										case 31:
											num = 0;
											continue;
										case 32:
											if (!base.Rows[hitTestInfo.RowIndex].Selected)
											{
												num = 7;
												continue;
											}
											goto IL_917;
										case 33:
											if (base.CurrentCell != null)
											{
												num = 11;
												continue;
											}
											goto IL_979;
										case 34:
											num = 13;
											continue;
										case 35:
											goto IL_C06;
										case 36:
											if (hitTestInfo.Type == global::System.Windows.Forms.DataGridViewHitTestType.RowHeader)
											{
												num = 31;
												continue;
											}
											goto IL_AD8;
										case 37:
											if (base.SelectedRows.Count <= 0)
											{
												num = 2;
												continue;
											}
											base.SelectedRows[0].Selected = false;
											num = 28;
											continue;
										case 38:
											goto IL_979;
										case 39:
											num = 17;
											continue;
										case 40:
											base.Focus();
											num = 20;
											continue;
										}
										if (hitTestInfo.Type != global::System.Windows.Forms.DataGridViewHitTestType.Cell)
										{
											num = 30;
											continue;
										}
										IL_845:
										num = 19;
										continue;
										IL_917:
										num = 15;
										continue;
										IL_979:
										num = 22;
										continue;
										IL_A9F:
										num = 14;
										continue;
										IL_AD8:
										num = 33;
										continue;
										IL_B64:
										num = 37;
										continue;
										IL_BFA:
										num = 35;
									}
									IL_C06:
									goto IL_3A1;
								}
								finally
								{
									num = 1;
									for (;;)
									{
										global::custom_controls.CCustomDataGridView.DataLoader dataLoader2;
										switch (num)
										{
										case 0:
											goto IL_C48;
										case 2:
											((global::System.IDisposable)dataLoader2).Dispose();
											num = 0;
											continue;
										}
										if (dataLoader2 == null)
										{
											break;
										}
										num = 2;
									}
									IL_C48:;
								}
								goto IL_C4B;
							case 54:
								goto IL_ED7;
							}
							break;
							IL_139:
							base.ClearSelection();
							base.Invalidate();
							num = 28;
							continue;
							IL_471:
							goto IL_139;
							IL_20E:
							num = 23;
							continue;
							IL_23D:
							this.v = num3;
							num4 = 0;
							num = 48;
							continue;
							IL_29E:
							num = 29;
							continue;
							IL_372:
							num = 12;
							continue;
							IL_3A1:
							num = 33;
							continue;
							IL_C4B:
							g = new global::custom_controls.g(hitTestInfo.RowIndex, rectangle, a_, bitmap);
							g.a(rectangle);
							this.r = new global::System.Collections.ArrayList();
							num = 36;
							continue;
							IL_E89:
							num = 22;
							continue;
							IL_ED7:
							g = null;
							global::System.Drawing.Rectangle rc = new global::System.Drawing.Rectangle(num6, num8, width, height);
							base.Invalidate(rc);
							num5++;
							num = 6;
							continue;
							IL_F72:
							num = 11;
						}
					}
					IL_F7E:
					break;
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000A750 File Offset: 0x00008950
		protected override void OnMouseMove(global::System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						global::System.Windows.Forms.DataGridView.HitTestInfo hitTestInfo = base.HitTest(e.X, e.Y);
						int num = 32;
						for (;;)
						{
							int num2;
							switch (num)
							{
							case 0:
								IL_757:
								if (num2 >= base.SelectedRows.Count)
								{
									num = 37;
									continue;
								}
								num = 44;
								continue;
							case 1:
								goto IL_7D7;
							case 2:
								if (this.Dock == global::System.Windows.Forms.DockStyle.Fill)
								{
									num = 26;
									continue;
								}
								goto IL_302;
							case 3:
								goto IL_72F;
							case 4:
								if (base.FirstDisplayedScrollingRowIndex >= hitTestInfo.RowIndex)
								{
									num = 54;
									continue;
								}
								goto IL_302;
							case 5:
								num = 40;
								continue;
							case 6:
								goto IL_302;
							case 7:
								if (base.ColumnCount > 0)
								{
									num = 25;
									continue;
								}
								goto IL_7CB;
							case 8:
							{
								int num3;
								if (e.Y > num3 + 2)
								{
									num = 9;
									continue;
								}
								goto IL_18D;
							}
							case 9:
								goto IL_779;
							case 10:
								num = 18;
								continue;
							case 11:
							{
								int num3;
								if (e.Y >= num3 - 2)
								{
									num = 19;
									continue;
								}
								goto IL_779;
							}
							case 12:
								num = 24;
								continue;
							case 13:
								goto IL_72F;
							case 14:
								if (base.HitTest(e.X, e.Y).Type != global::System.Windows.Forms.DataGridViewHitTestType.RowHeader)
								{
									num = 16;
									continue;
								}
								goto IL_4B7;
							case 15:
								num = 33;
								continue;
							case 16:
								num = 48;
								continue;
							case 17:
								num = 29;
								continue;
							case 18:
								if (this.q <= base.FirstDisplayedScrollingColumnIndex - 1)
								{
									num = 60;
									continue;
								}
								goto IL_18D;
							case 19:
								num = 8;
								continue;
							case 20:
								goto IL_302;
							case 21:
							{
								global::System.Drawing.Rectangle clientRectangle;
								if (clientRectangle.Contains(e.X, e.Y))
								{
									num = 49;
									continue;
								}
								goto IL_7CB;
							}
							case 22:
								num = 14;
								continue;
							case 23:
								goto IL_18D;
							case 24:
								if (this.r.Count > 0)
								{
									num = 27;
									continue;
								}
								goto IL_41B;
							case 25:
								num = 30;
								continue;
							case 26:
								num = 46;
								continue;
							case 27:
								this.m = this.r;
								num = 53;
								continue;
							case 28:
								if (this.p >= 0)
								{
									num = 15;
									continue;
								}
								goto IL_18D;
							case 29:
								if (base.HitTest(e.X, e.Y).Type == global::System.Windows.Forms.DataGridViewHitTestType.Cell)
								{
									num = 47;
									continue;
								}
								this.Cursor = global::System.Windows.Forms.Cursors.Arrow;
								num = 23;
								continue;
							case 30:
								if (base.RowCount > 0)
								{
									num = 17;
									continue;
								}
								goto IL_7CB;
							case 31:
								goto IL_684;
							case 32:
								if (base.SelectedRows.Count > 0)
								{
									num = 55;
									continue;
								}
								goto IL_7CB;
							case 33:
								if (this.p <= base.ColumnCount - 1)
								{
									num = 5;
									continue;
								}
								goto IL_18D;
							case 34:
								if (hitTestInfo.RowIndex > 0)
								{
									num = 56;
									continue;
								}
								goto IL_302;
							case 35:
								goto IL_7CB;
							case 36:
								goto IL_4B7;
							case 37:
								base.Invalidate();
								num = 35;
								continue;
							case 38:
								if (this.u)
								{
									num = 59;
									continue;
								}
								goto IL_41B;
							case 39:
								if (!this.t)
								{
									num = 57;
									continue;
								}
								num = 38;
								continue;
							case 40:
								if (this.q >= 0)
								{
									num = 10;
									continue;
								}
								goto IL_18D;
							case 41:
								if (this.t)
								{
									num = 50;
									continue;
								}
								goto IL_7CB;
							case 42:
								num2 = 0;
								num = 3;
								continue;
							case 43:
							{
								int num4 = e.Y - ((global::custom_controls.g)this.m[num2]).d().Y;
								((global::custom_controls.g)this.m[num2]).a(new global::System.Drawing.Rectangle(((global::custom_controls.g)this.m[num2]).c().X, num4, ((global::custom_controls.g)this.m[num2]).c().Width, ((global::custom_controls.g)this.m[num2]).c().Height));
								num = 51;
								continue;
							}
							case 44:
								if (this.m[num2] != null)
								{
									num = 43;
									continue;
								}
								goto IL_302;
							case 45:
								goto IL_18D;
							case 46:
								if (base.DisplayedRowCount(false) + base.FirstDisplayedScrollingRowIndex <= hitTestInfo.RowIndex)
								{
									num = 61;
									continue;
								}
								num = 4;
								continue;
							case 47:
								num = 28;
								continue;
							case 48:
								if (base.HitTest(e.X, e.Y).Type == global::System.Windows.Forms.DataGridViewHitTestType.RowHeader)
								{
									num = 36;
									continue;
								}
								goto IL_302;
							case 49:
								this.p = hitTestInfo.RowIndex;
								this.q = hitTestInfo.ColumnIndex;
								num = 39;
								continue;
							case 50:
								num = 52;
								continue;
							case 51:
								if (base.HitTest(e.X, e.Y).Type != global::System.Windows.Forms.DataGridViewHitTestType.Cell)
								{
									num = 22;
									continue;
								}
								goto IL_4B7;
							case 52:
								if (this.m.Count > 0)
								{
									num = 42;
									continue;
								}
								goto IL_7CB;
							case 53:
								goto IL_41B;
							case 54:
								num = 34;
								continue;
							case 55:
							{
								global::System.Drawing.Rectangle clientRectangle = base.ClientRectangle;
								num = 21;
								continue;
							}
							case 56:
								this.a(hitTestInfo.RowIndex - 1);
								num = 20;
								continue;
							case 57:
								num = 31;
								continue;
							case 58:
								if (this.r != null)
								{
									num = 12;
									continue;
								}
								goto IL_41B;
							case 59:
								num = 58;
								continue;
							case 60:
							{
								int num3 = base.GetCellDisplayRectangle(this.p, this.q, false).Y + base.GetCellDisplayRectangle(this.p, this.q, false).Height + 1;
								num = 11;
								continue;
							}
							case 61:
								this.a(hitTestInfo.RowIndex);
								num = 6;
								continue;
							}
							break;
							IL_18D:
							num = 41;
							continue;
							IL_302:
							num2++;
							num = 13;
							continue;
							IL_41B:
							num = 7;
							continue;
							IL_4B7:
							num = 2;
							continue;
							IL_72F:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_757;
							default:
								if (false)
								{
								}
								num = 0;
								continue;
							}
							IL_779:
							this.Cursor = global::System.Windows.Forms.Cursors.Arrow;
							num = 45;
							continue;
							IL_7CB:
							num = 1;
						}
					}
					IL_684:
					IL_7D7:
					break;
				}
			}
			catch (global::System.Exception)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000AF68 File Offset: 0x00009168
		protected override void OnMouseUp(global::System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				int num = 44;
				for (;;)
				{
					global::System.Windows.Forms.DataGridView.HitTestInfo hitTestInfo;
					switch (num)
					{
					case 0:
						goto IL_572;
					case 1:
						if (base.CurrentCell != null)
						{
							num = 10;
							continue;
						}
						goto IL_572;
					case 2:
						num = 48;
						continue;
					case 3:
						if (base.SelectedRows.Count > 0)
						{
							num = 24;
							continue;
						}
						num = 1;
						continue;
					case 4:
						if (e.Button == global::System.Windows.Forms.MouseButtons.Left)
						{
							num = 36;
							continue;
						}
						num = 7;
						continue;
					case 5:
						if (!(base.EditingControl is global::custom_controls.DataGridViewCustTextBoxEditingControl))
						{
							num = 29;
							continue;
						}
						goto IL_1BE;
					case 6:
						if (this.ContextMenu.MenuItems.Count > 0)
						{
							num = 11;
							continue;
						}
						goto IL_572;
					case 7:
						if (e.Button == global::System.Windows.Forms.MouseButtons.Right)
						{
							num = 30;
							continue;
						}
						goto IL_572;
					case 8:
						num = 18;
						continue;
					case 9:
						num = 15;
						continue;
					case 10:
						num = 13;
						continue;
					case 11:
						this.ContextMenu.Show(this, new global::System.Drawing.Point(e.X + 5, e.Y));
						num = 52;
						continue;
					case 12:
						num = 20;
						continue;
					case 13:
						if (!base.CurrentCell.ReadOnly)
						{
							num = 23;
							continue;
						}
						goto IL_572;
					case 14:
						num = 46;
						continue;
					case 15:
						if (this.t)
						{
							num = 2;
							continue;
						}
						goto IL_1E4;
					case 16:
						this.ae(this, e);
						num = 33;
						continue;
					case 17:
						num = 6;
						continue;
					case 18:
						if (this.ContextMenu != null)
						{
							num = 17;
							continue;
						}
						goto IL_572;
					case 19:
						if (this.ad != null)
						{
							num = 31;
							continue;
						}
						goto IL_572;
					case 20:
						if (this.AllowDrop)
						{
							num = 9;
							continue;
						}
						goto IL_1E4;
					case 21:
						if (hitTestInfo.Type != global::System.Windows.Forms.DataGridViewHitTestType.RowHeader)
						{
							num = 14;
							continue;
						}
						goto IL_210;
					case 22:
						num = 40;
						continue;
					case 23:
						num = 39;
						continue;
					case 24:
						num = 19;
						continue;
					case 25:
						if (hitTestInfo.Type == global::System.Windows.Forms.DataGridViewHitTestType.RowHeader)
						{
							num = 12;
							continue;
						}
						goto IL_1E4;
					case 26:
						if (this.ae != null)
						{
							num = 22;
							continue;
						}
						goto IL_572;
					case 27:
						this.k = false;
						num = 32;
						continue;
					case 28:
						goto IL_210;
					case 29:
						num = 43;
						continue;
					case 30:
						num = 21;
						continue;
					case 31:
						this.ad(this, e);
						num = 41;
						continue;
					case 32:
						goto IL_4B5;
					case 33:
						goto IL_572;
					case 34:
						num = 51;
						continue;
					case 35:
						goto IL_590;
					case 36:
						num = 25;
						continue;
					case 37:
						num = 5;
						continue;
					case 38:
						goto IL_572;
					case 39:
						if (base.EditingControl != null)
						{
							num = 37;
							continue;
						}
						num = 45;
						continue;
					case 40:
						if (base.EditingControl.Focused)
						{
							num = 34;
							continue;
						}
						goto IL_572;
					case 41:
						goto IL_572;
					case 42:
						this.a(this, this.n, hitTestInfo.RowIndex);
						num = 0;
						continue;
					case 43:
						if (base.EditingControl is global::custom_controls.DataGridViewNumericUpDownEditingControl)
						{
							num = 47;
							continue;
						}
						goto IL_572;
					case 45:
						if (this.ae != null)
						{
							num = 16;
							continue;
						}
						goto IL_572;
					case 46:
						if (hitTestInfo.Type == global::System.Windows.Forms.DataGridViewHitTestType.TopLeftHeader)
						{
							num = 28;
							continue;
						}
						goto IL_572;
					case 47:
						goto IL_1BE;
					case 48:
						if (this.n != this.o)
						{
							num = 42;
							continue;
						}
						goto IL_1E4;
					case 49:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F2;
						default:
							if (false)
							{
							}
							this.ae(this, e);
							num = 38;
							continue;
						}
						break;
					case 50:
						if (this.Focused)
						{
							num = 8;
							continue;
						}
						goto IL_572;
					case 51:
						if (base.EditingControl.Enabled)
						{
							num = 49;
							continue;
						}
						goto IL_572;
					case 52:
						goto IL_572;
					}
					goto IL_E7;
					IL_F2:
					num = 27;
					continue;
					IL_E7:
					if (this.k)
					{
						goto IL_F2;
					}
					goto IL_4B5;
					IL_1BE:
					num = 26;
					continue;
					IL_1E4:
					num = 3;
					continue;
					IL_210:
					num = 50;
					continue;
					IL_4B5:
					hitTestInfo = base.HitTest(e.X, e.Y);
					this.o = hitTestInfo.RowIndex;
					num = 4;
					continue;
					IL_572:
					this.b();
					base.OnMouseUp(e);
					base.Invalidate();
					num = 35;
				}
				IL_590:;
			}
			catch (global::custom_exception.CCustomException)
			{
				this.b();
				base.Invalidate();
				throw;
			}
			catch (global::System.Exception ex)
			{
				this.b();
				base.Invalidate();
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000B574 File Offset: 0x00009774
		private void b()
		{
			for (;;)
			{
				for (;;)
				{
					int num = 0;
					int num2 = 2;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (true)
							{
							}
							goto IL_24;
						case 1:
							if (num >= this.m.Count)
							{
								num2 = 3;
								continue;
							}
							this.m[num] = null;
							num++;
							num2 = 0;
							continue;
						case 2:
							goto IL_24;
						case 3:
							goto IL_42;
						}
						break;
						IL_24:
						num2 = 1;
					}
				}
				IL_42:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_58;
				}
			}
			IL_58:
			if (false)
			{
			}
			this.u = false;
			this.m.Clear();
			this.u = false;
			this.t = false;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000B630 File Offset: 0x00009830
		protected override void OnMouseWheel(global::System.Windows.Forms.MouseEventArgs e)
		{
			switch (0)
			{
			default:
				if (true)
				{
				}
				if (this.t)
				{
					try
					{
						int num = 12;
						for (;;)
						{
							int num2;
							switch (num)
							{
							case 0:
								if (this.m[num2] != null)
								{
									num = 4;
									continue;
								}
								goto IL_9A;
							case 1:
								num = 10;
								continue;
							case 2:
								if (this.r != null)
								{
									num = 1;
									continue;
								}
								goto IL_27E;
							case 3:
								if (this.m.Count > 0)
								{
									num = 7;
									continue;
								}
								goto IL_2A6;
							case 4:
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
									int num3 = e.Y - ((global::custom_controls.g)this.m[num2]).d().Y;
									((global::custom_controls.g)this.m[num2]).a(new global::System.Drawing.Rectangle(((global::custom_controls.g)this.m[num2]).c().X, num3, ((global::custom_controls.g)this.m[num2]).c().Width, ((global::custom_controls.g)this.m[num2]).c().Height));
									num = 15;
									continue;
								}
								}
								break;
							case 5:
								this.m = this.r;
								num = 8;
								continue;
							case 6:
								num = 2;
								continue;
							case 7:
								num2 = 0;
								num = 13;
								continue;
							case 8:
								goto IL_27E;
							case 9:
								num = 3;
								continue;
							case 10:
								if (this.r.Count > 0)
								{
									num = 5;
									continue;
								}
								goto IL_27E;
							case 11:
								goto IL_2A6;
							case 13:
								goto IL_102;
							case 14:
								goto IL_102;
							case 15:
								goto IL_9A;
							case 16:
								if (this.t)
								{
									num = 9;
									continue;
								}
								goto IL_2A6;
							case 17:
								if (num2 >= base.SelectedRows.Count)
								{
									num = 11;
									continue;
								}
								num = 0;
								continue;
							case 18:
								goto IL_2B2;
							}
							IL_81:
							if (this.u)
							{
								num = 6;
								continue;
							}
							goto IL_27E;
							goto IL_81;
							IL_9A:
							num2++;
							num = 14;
							continue;
							IL_102:
							num = 17;
							continue;
							IL_27E:
							num = 16;
							continue;
							IL_2A6:
							num = 18;
						}
						IL_2B2:
						goto IL_2BF;
					}
					catch (global::System.Exception)
					{
						goto IL_2BF;
					}
					goto IL_2B7;
					IL_2BF:
					base.Invalidate();
					base.OnMouseWheel(e);
					return;
				}
				IL_2B7:
				base.OnMouseWheel(e);
				return;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000B930 File Offset: 0x00009B30
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs e)
		{
			switch (0)
			{
			default:
				base.OnPaint(e);
				try
				{
					for (;;)
					{
						this.ResizeDataGridView();
						int num = 8;
						for (;;)
						{
							int num3;
							switch (num)
							{
							case 0:
							{
								int num2 = ((global::custom_controls.g)this.m[num3]).f();
								global::System.Drawing.Graphics graphics = e.Graphics;
								global::System.Drawing.SolidBrush solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.FromArgb(50, 200, 200, 255));
								num = 11;
								continue;
							}
							case 1:
								if (this.m.Count > num3)
								{
									num = 3;
									continue;
								}
								goto IL_B0;
							case 2:
								goto IL_D5;
							case 3:
								num = 6;
								continue;
							case 4:
								goto IL_7C4;
							case 5:
								num3 = 0;
								num = 9;
								continue;
							case 6:
								if (this.m[num3] != null)
								{
									num = 0;
									continue;
								}
								goto IL_B0;
							case 7:
								goto IL_7D0;
							case 8:
								if (base.SelectedRows.Count > 0)
								{
									num = 5;
									continue;
								}
								goto IL_7C4;
							case 9:
								goto IL_D5;
							case 10:
								if (true)
								{
								}
								if (num3 >= base.SelectedRows.Count)
								{
									num = 4;
									continue;
								}
								num = 1;
								continue;
							case 11:
								try
								{
									global::System.Drawing.SolidBrush solidBrush2 = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.FromArgb(100, 200, 200, 230));
									try
									{
										global::System.Drawing.Pen pen = new global::System.Drawing.Pen(solidBrush2, 2f);
										try
										{
											for (;;)
											{
												int width = ((global::custom_controls.g)this.m[num3]).c().Width;
												int height = ((global::custom_controls.g)this.m[num3]).c().Height;
												num = 5;
												for (;;)
												{
													global::System.Drawing.Graphics graphics;
													global::System.Drawing.SolidBrush solidBrush;
													global::System.Drawing.Rectangle rect;
													global::System.Drawing.SolidBrush solidBrush4;
													global::System.Drawing.Rectangle rect2;
													switch (num)
													{
													case 0:
														goto IL_4DB;
													case 1:
													{
														int num2;
														if (num2 > base.FirstDisplayedScrollingRowIndex + base.DisplayedRowCount(false) - 1)
														{
															num = 3;
															continue;
														}
														goto IL_50E;
													}
													case 2:
														goto IL_3B4;
													case 3:
														goto IL_265;
													case 4:
														num = 8;
														continue;
													case 5:
														if (this.Dock == global::System.Windows.Forms.DockStyle.Fill)
														{
															num = 4;
															continue;
														}
														goto IL_50E;
													case 6:
														try
														{
															global::System.Drawing.SolidBrush solidBrush3 = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.FromArgb(150, 50, 50, 50));
															try
															{
																graphics.FillRectangle(solidBrush3, rect);
																global::System.Drawing.Pen pen2 = new global::System.Drawing.Pen(solidBrush4, 2f);
																try
																{
																	graphics.DrawRectangle(pen2, rect2);
																}
																finally
																{
																	num = 2;
																	for (;;)
																	{
																		switch (num)
																		{
																		case 0:
																			((global::System.IDisposable)pen2).Dispose();
																			num = 1;
																			continue;
																		case 1:
																			goto IL_435;
																		}
																		if (pen2 == null)
																		{
																			break;
																		}
																		num = 0;
																	}
																	IL_435:;
																}
															}
															finally
															{
																num = 0;
																for (;;)
																{
																	switch (num)
																	{
																	case 1:
																		goto IL_477;
																	case 2:
																		((global::System.IDisposable)solidBrush3).Dispose();
																		num = 1;
																		continue;
																	}
																	if (solidBrush3 == null)
																	{
																		break;
																	}
																	num = 2;
																}
																IL_477:;
															}
															goto IL_5AE;
														}
														finally
														{
															num = 0;
															for (;;)
															{
																switch (num)
																{
																case 1:
																	goto IL_4C6;
																case 2:
																	goto IL_4D8;
																}
																if (solidBrush4 == null)
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
																IL_4C6:
																((global::System.IDisposable)solidBrush4).Dispose();
																num = 2;
															}
															IL_4D8:;
														}
														goto IL_4DB;
														IL_5AE:
														graphics.DrawImage(((global::custom_controls.g)this.m[num3]).g(), ((global::custom_controls.g)this.m[num3]).b().X, ((global::custom_controls.g)this.m[num3]).b().Y);
														graphics.FillRectangle(solidBrush, ((global::custom_controls.g)this.m[num3]).b().X, ((global::custom_controls.g)this.m[num3]).b().Y, ((global::custom_controls.g)this.m[num3]).b().Width, ((global::custom_controls.g)this.m[num3]).b().Height);
														graphics.DrawRectangle(pen, new global::System.Drawing.Rectangle(((global::custom_controls.g)this.m[num3]).b().X, ((global::custom_controls.g)this.m[num3]).b().Y + (int)global::System.Convert.ToInt16(pen.Width, global::System.Globalization.CultureInfo.InvariantCulture), width, height));
														num = 7;
														continue;
													case 7:
														goto IL_6FD;
													case 8:
													{
														int num2;
														if (num2 >= base.FirstDisplayedScrollingRowIndex)
														{
															num = 0;
															continue;
														}
														goto IL_265;
													}
													}
													break;
													IL_265:
													graphics.DrawImage(((global::custom_controls.g)this.m[num3]).g(), ((global::custom_controls.g)this.m[num3]).b().X, ((global::custom_controls.g)this.m[num3]).b().Y);
													graphics.FillRectangle(solidBrush, ((global::custom_controls.g)this.m[num3]).b().X, ((global::custom_controls.g)this.m[num3]).b().Y, ((global::custom_controls.g)this.m[num3]).b().Width, ((global::custom_controls.g)this.m[num3]).b().Height);
													graphics.DrawRectangle(pen, new global::System.Drawing.Rectangle(((global::custom_controls.g)this.m[num3]).b().X, ((global::custom_controls.g)this.m[num3]).b().Y + (int)global::System.Convert.ToInt16(pen.Width, global::System.Globalization.CultureInfo.InvariantCulture), width, height));
													num = 2;
													continue;
													IL_4DB:
													num = 1;
													continue;
													IL_50E:
													global::System.Drawing.Rectangle cellDisplayRectangle = base.GetCellDisplayRectangle(0, 0, false);
													rect = ((global::custom_controls.g)this.m[num3]).c();
													rect.Location = new global::System.Drawing.Point(rect.X, ((global::custom_controls.g)this.m[num3]).c().Y + cellDisplayRectangle.Y);
													int num4 = rect.X;
													int num5 = rect.Y;
													rect2 = new global::System.Drawing.Rectangle(num4, num5, width, height);
													solidBrush4 = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.FromArgb(100, 0, 0, 0));
													num = 6;
												}
											}
											IL_3B4:
											return;
											IL_6FD:;
										}
										finally
										{
											num = 0;
											for (;;)
											{
												switch (num)
												{
												case 1:
													goto IL_73C;
												case 2:
													((global::System.IDisposable)pen).Dispose();
													num = 1;
													continue;
												}
												if (pen == null)
												{
													break;
												}
												num = 2;
											}
											IL_73C:;
										}
									}
									finally
									{
										num = 2;
										for (;;)
										{
											switch (num)
											{
											case 0:
												goto IL_77E;
											case 1:
												((global::System.IDisposable)solidBrush2).Dispose();
												num = 0;
												continue;
											}
											if (solidBrush2 == null)
											{
												break;
											}
											num = 1;
										}
										IL_77E:;
									}
									goto IL_B0;
								}
								finally
								{
									num = 1;
									for (;;)
									{
										global::System.Drawing.SolidBrush solidBrush;
										switch (num)
										{
										case 0:
											goto IL_7C1;
										case 2:
											((global::System.IDisposable)solidBrush).Dispose();
											num = 0;
											continue;
										}
										if (solidBrush == null)
										{
											break;
										}
										num = 2;
									}
									IL_7C1:;
								}
								goto IL_7C4;
							}
							break;
							IL_B0:
							num3++;
							num = 2;
							continue;
							IL_D5:
							num = 10;
							continue;
							IL_7C4:
							num = 7;
						}
					}
					IL_7D0:;
				}
				catch (global::System.Exception)
				{
				}
				return;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000C1C0 File Offset: 0x0000A3C0
		public void ResetPosition()
		{
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
				num = 2;
				break;
			}
			for (;;)
			{
				global::custom_controls.CCustomDataGridView.DataLoader dataLoader;
				switch (num)
				{
				case 0:
					return;
				case 1:
					try
					{
						for (;;)
						{
							int num2 = 0;
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
								{
									if (num2 >= base.RowCount)
									{
										num = 3;
										continue;
									}
									int num3 = num2 + 1;
									base.Rows[num2].Cells[0].Value = num3;
									num2++;
									if (true)
									{
									}
									num = 2;
									continue;
								}
								case 1:
									goto IL_C3;
								case 2:
									goto IL_C3;
								case 3:
									num = 4;
									continue;
								case 4:
									goto IL_E9;
								}
								break;
								IL_C3:
								num = 0;
							}
						}
						IL_E9:
						return;
					}
					finally
					{
						num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_122;
							case 1:
								((global::System.IDisposable)dataLoader).Dispose();
								num = 0;
								continue;
							}
							if (dataLoader == null)
							{
								break;
							}
							num = 1;
						}
						IL_122:;
					}
					goto IL_125;
				}
				if (!this.IsColumnExist("POSITION"))
				{
					num = 0;
					continue;
				}
				IL_125:
				dataLoader = new global::custom_controls.CCustomDataGridView.DataLoader(this);
				num = 1;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000C31C File Offset: 0x0000A51C
		private void a(int A_0)
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
			base.FirstDisplayedScrollingRowIndex = A_0;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000C360 File Offset: 0x0000A560
		private int a(int A_0, int A_1)
		{
			int num;
			for (;;)
			{
				global::System.Windows.Forms.DataGridView.HitTestInfo hitTestInfo = base.HitTest(A_0, A_1);
				num = A_1;
				int num2 = 1;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (hitTestInfo.Type == global::System.Windows.Forms.DataGridViewHitTestType.RowHeader)
						{
							num2 = 4;
							continue;
						}
						num++;
						num2 = 2;
						continue;
					case 1:
						if (!base.ColumnHeadersVisible)
						{
							num2 = 6;
							continue;
						}
						goto IL_88;
					case 2:
						return num;
					case 3:
						return num;
					case 4:
						num = this.a(A_0, --A_1);
						num2 = 5;
						continue;
					case 5:
						return num;
					case 6:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_88;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							num = 0;
							num2 = 3;
							continue;
						}
						break;
					}
					break;
					IL_88:
					num2 = 0;
				}
			}
			return num;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000C444 File Offset: 0x0000A644
		private void a(ref global::System.Drawing.Bitmap A_0)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(this.v, this.s, global::System.Drawing.Imaging.PixelFormat.Format32bppRgb);
				global::System.Drawing.Graphics graphics = global::System.Drawing.Graphics.FromImage(bitmap);
				global::System.Drawing.SolidBrush solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.White);
				for (;;)
				{
					try
					{
						graphics.FillRectangle(solidBrush, 0, 0, this.v, this.s);
						goto IL_4E;
					}
					finally
					{
						int num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								((global::System.IDisposable)solidBrush).Dispose();
								num = 1;
								continue;
							case 1:
								goto IL_294;
							}
							if (solidBrush == null)
							{
								break;
							}
							num = 0;
						}
						IL_294:;
					}
					break;
					try
					{
						IL_4E:
						for (;;)
						{
							global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow = (global::custom_controls.CCustomDataGridViewRow)base.Rows[this.n];
							string a_ = string.Empty;
							int num = 6;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_21C;
								case 1:
								{
									int num2;
									if (num2 >= base.DisplayedColumnCount(false))
									{
										num = 0;
										continue;
									}
									int num3;
									global::System.Drawing.Rectangle a_2 = new global::System.Drawing.Rectangle(new global::System.Drawing.Point(num3, 0), new global::System.Drawing.Size(base.Columns[num2].Width, this.s));
									a_ = global::System.Convert.ToString(ccustomDataGridViewRow.Cells[num2].Value, global::System.Globalization.CultureInfo.InvariantCulture);
									this.a(a_, base.Columns[num2].Width, base.Columns[num2].DefaultCellStyle.Alignment, ref graphics, a_2);
									num3 += base.Columns[num2].Width;
									num2++;
									num = 9;
									continue;
								}
								case 2:
									goto IL_231;
								case 3:
									goto IL_1BD;
								case 4:
									if (base.Rows.Count > 0)
									{
										num = 8;
										continue;
									}
									goto IL_1BD;
								case 5:
									goto IL_195;
								case 6:
									if (base.ColumnCount > 0)
									{
										num = 7;
										continue;
									}
									goto IL_21C;
								case 7:
								{
									int num3 = 0;
									num = 4;
									continue;
								}
								case 8:
								{
									int num3 = base.Rows[0].HeaderCell.Size.Width;
									num = 3;
									continue;
								}
								case 9:
									goto IL_195;
								}
								break;
								IL_195:
								num = 1;
								continue;
								IL_1BD:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_21C:
									A_0 = bitmap;
									graphics.Dispose();
									num = 2;
									break;
								default:
								{
									if (false)
									{
									}
									int num2 = 0;
									num = 5;
									break;
								}
								}
							}
						}
						IL_231:
						break;
					}
					catch (global::System.Exception)
					{
						A_0 = bitmap;
						graphics.Dispose();
						break;
					}
				}
				return;
			}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000C71C File Offset: 0x0000A91C
		private void a(string A_0, int A_1, global::System.Windows.Forms.DataGridViewContentAlignment A_2, ref global::System.Drawing.Graphics A_3, global::System.Drawing.Rectangle A_4)
		{
			global::System.Drawing.StringFormat stringFormat = new global::System.Drawing.StringFormat();
			try
			{
				int num = 21;
				for (;;)
				{
					global::System.Drawing.SolidBrush solidBrush;
					global::System.Drawing.RectangleF layoutRectangle;
					switch (num)
					{
					case 0:
						if (A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.BottomCenter))
						{
							num = 20;
							continue;
						}
						num = 24;
						continue;
					case 1:
						if (A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.BottomCenter))
						{
							num = 29;
							continue;
						}
						goto IL_2C1;
					case 2:
						goto IL_226;
					case 3:
						num = 7;
						continue;
					case 4:
						if (A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.NotSet))
						{
							num = 25;
							continue;
						}
						num = 5;
						continue;
					case 5:
						if (true)
						{
						}
						if (!A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.MiddleRight))
						{
							num = 17;
							continue;
						}
						goto IL_FA;
					case 6:
						if (!A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.BottomLeft))
						{
							num = 10;
							continue;
						}
						goto IL_40B;
					case 7:
						if (!A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.TopLeft))
						{
							num = 26;
							continue;
						}
						goto IL_40B;
					case 8:
						num = 23;
						continue;
					case 9:
						if (A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.BottomRight))
						{
							num = 28;
							continue;
						}
						goto IL_226;
					case 10:
						goto IL_1C3;
					case 11:
						num = 9;
						continue;
					case 12:
						goto IL_2C1;
					case 13:
						num = 27;
						continue;
					case 14:
						num = 1;
						continue;
					case 15:
						try
						{
							A_3.DrawString(A_0, this.Font, solidBrush, layoutRectangle, stringFormat);
							goto IL_422;
						}
						finally
						{
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									((global::System.IDisposable)solidBrush).Dispose();
									num = 2;
									continue;
								case 1:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1C0;
									default:
										if (false)
										{
										}
										break;
									}
									break;
								case 2:
									goto IL_1C0;
								}
								if (solidBrush == null)
								{
									break;
								}
								num = 0;
							}
							IL_1C0:;
						}
						goto IL_1C3;
						IL_422:
						num = 31;
						continue;
					case 16:
						if (!A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.TopRight))
						{
							num = 11;
							continue;
						}
						goto IL_FA;
					case 17:
						num = 16;
						continue;
					case 18:
						goto IL_226;
					case 19:
						goto IL_226;
					case 20:
						goto IL_2F0;
					case 22:
						if (!A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter))
						{
							num = 13;
							continue;
						}
						goto IL_2F0;
					case 23:
						if (!A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.TopCenter))
						{
							num = 14;
							continue;
						}
						goto IL_111;
					case 24:
						if (!A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft))
						{
							num = 3;
							continue;
						}
						goto IL_40B;
					case 25:
						goto IL_40B;
					case 26:
						num = 6;
						continue;
					case 27:
						if (!A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.TopCenter))
						{
							num = 30;
							continue;
						}
						goto IL_2F0;
					case 28:
						goto IL_FA;
					case 29:
						goto IL_111;
					case 30:
						num = 0;
						continue;
					case 31:
						goto IL_42D;
					}
					if (!A_2.Equals(global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter))
					{
						num = 8;
						continue;
					}
					goto IL_111;
					IL_FA:
					stringFormat.Alignment = global::System.Drawing.StringAlignment.Far;
					num = 2;
					continue;
					IL_111:
					stringFormat.Alignment = global::System.Drawing.StringAlignment.Center;
					num = 12;
					continue;
					IL_1C3:
					num = 4;
					continue;
					IL_226:
					layoutRectangle = new global::System.Drawing.RectangleF((float)A_4.X, (float)A_4.Y, (float)A_1, (float)this.s);
					solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.Black);
					num = 15;
					continue;
					IL_2C1:
					num = 22;
					continue;
					IL_2F0:
					stringFormat.Alignment = global::System.Drawing.StringAlignment.Center;
					num = 18;
					continue;
					IL_40B:
					stringFormat.Alignment = global::System.Drawing.StringAlignment.Near;
					num = 19;
				}
				IL_42D:;
			}
			finally
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_466;
					case 2:
						((global::System.IDisposable)stringFormat).Dispose();
						num = 1;
						continue;
					}
					if (stringFormat == null)
					{
						break;
					}
					num = 2;
				}
				IL_466:;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		public void CreateContextMenu(global::System.Collections.ArrayList menuInfo, string cascdeMenuType)
		{
			for (;;)
			{
				this.DetachContextMenuEvents();
				global::System.Windows.Forms.ContextMenuStrip contextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip();
				new global::custom_controls.CDataGridViewMenu(menuInfo, ref contextMenuStrip, cascdeMenuType);
				this.ContextMenuStrip = contextMenuStrip;
				int num = 0;
				for (;;)
				{
					int num2;
					switch (num)
					{
					case 0:
						if (this.ContextMenuStrip != null)
						{
							num = 10;
							continue;
						}
						return;
					case 1:
						if (this.ContextMenuStrip.Items[num2].Name == "menuItemGoTo")
						{
							num = 13;
							continue;
						}
						goto IL_A0;
					case 2:
						goto IL_14A;
					case 3:
						this.ContextMenuStrip.Opened -= this.c;
						this.ContextMenuStrip.Opened += this.c;
						num = 9;
						continue;
					case 4:
						num = 1;
						continue;
					case 5:
						goto IL_14A;
					case 6:
						if (num2 >= this.ContextMenuStrip.Items.Count)
						{
							num = 3;
							continue;
						}
						goto IL_257;
					case 7:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_257;
						default:
							if (false)
							{
							}
							if (((global::System.Windows.Forms.ToolStripMenuItem)this.ContextMenuStrip.Items[num2]).HasDropDownItems)
							{
								num = 12;
								continue;
							}
							goto IL_8C;
						}
						break;
					case 8:
						if (this.ContextMenuStrip.Items.Count > 0)
						{
							num = 16;
							continue;
						}
						return;
					case 9:
						return;
					case 10:
						num = 8;
						continue;
					case 11:
						if (!(this.ContextMenuStrip.Items[num2].GetType().ToString() == "System.Windows.Forms.ToolStripSeparator"))
						{
							if (true)
							{
							}
							num = 4;
							continue;
						}
						goto IL_8C;
					case 12:
						this.b((global::System.Windows.Forms.ToolStripMenuItem)this.ContextMenuStrip.Items[num2]);
						num = 14;
						continue;
					case 13:
						this.f = this.ContextMenuStrip.Items[num2].Text;
						num = 15;
						continue;
					case 14:
						goto IL_8C;
					case 15:
						goto IL_A0;
					case 16:
						num2 = 0;
						num = 5;
						continue;
					}
					break;
					IL_8C:
					num2++;
					num = 2;
					continue;
					IL_A0:
					this.ContextMenuStrip.Items[num2].Click -= this.d;
					this.ContextMenuStrip.Items[num2].Click += this.d;
					num = 7;
					continue;
					IL_14A:
					num = 6;
					continue;
					IL_257:
					num = 11;
				}
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000CEA8 File Offset: 0x0000B0A8
		private void b(global::System.Windows.Forms.ToolStripMenuItem A_0)
		{
			for (;;)
			{
				global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem = null;
				int num = 0;
				int num2 = 6;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!(A_0.DropDownItems[num].GetType().ToString() == "System.Windows.Forms.ToolStripSeparator"))
						{
							num2 = 8;
							continue;
						}
						goto IL_3A;
					case 1:
						this.b(toolStripMenuItem);
						num2 = 7;
						continue;
					case 2:
						goto IL_B7;
					case 3:
						if (toolStripMenuItem.HasDropDownItems)
						{
							num2 = 1;
							continue;
						}
						goto IL_3A;
					case 4:
						return;
					case 5:
						if (num >= A_0.DropDownItems.Count)
						{
							num2 = 4;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B5;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							num2 = 0;
							continue;
						}
						break;
					case 6:
						goto IL_B7;
					case 7:
						goto IL_3A;
					case 8:
						goto IL_B5;
					}
					break;
					IL_3A:
					num++;
					num2 = 2;
					continue;
					IL_B5:
					toolStripMenuItem = (global::System.Windows.Forms.ToolStripMenuItem)A_0.DropDownItems[num];
					toolStripMenuItem.Click -= this.d;
					toolStripMenuItem.Click += this.d;
					num2 = 3;
					continue;
					IL_B7:
					num2 = 5;
				}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000CFFC File Offset: 0x0000B1FC
		public void DetachContextMenuEvents()
		{
			int num = 9;
			for (;;)
			{
				int num2;
				switch (num)
				{
				case 0:
					this.ContextMenuStrip.Items[num2].Click -= this.d;
					num = 1;
					continue;
				case 1:
					if (((global::System.Windows.Forms.ToolStripMenuItem)this.ContextMenuStrip.Items[num2]).HasDropDownItems)
					{
						num = 8;
						continue;
					}
					goto IL_120;
				case 2:
					goto IL_EC;
				case 3:
					goto IL_120;
				case 4:
					if (num2 >= this.ContextMenuStrip.Items.Count)
					{
						num = 13;
						continue;
					}
					num = 7;
					continue;
				case 5:
					return;
				case 6:
					this.ContextMenuStrip.Items.Clear();
					num = 5;
					continue;
				case 7:
					if (!(this.ContextMenuStrip.Items[num2].GetType().ToString() == "System.Windows.Forms.ToolStripSeparator"))
					{
						num = 0;
						continue;
					}
					goto IL_120;
				case 8:
					this.a((global::System.Windows.Forms.ToolStripMenuItem)this.ContextMenuStrip.Items[num2]);
					num = 3;
					continue;
				case 10:
					if (this.ContextMenuStrip.Items.Count > 0)
					{
						num = 6;
						continue;
					}
					return;
				case 11:
					goto IL_5D;
				case 12:
					return;
				case 13:
					num = 10;
					continue;
				}
				if (this.ContextMenuStrip == null)
				{
					num = 12;
					continue;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_EC;
				}
				if (false)
				{
				}
				num2 = 0;
				num = 2;
				continue;
				IL_5D:
				if (true)
				{
				}
				num = 4;
				continue;
				IL_EC:
				goto IL_5D;
				IL_120:
				num2++;
				num = 11;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000D1FC File Offset: 0x0000B3FC
		private void a(global::System.Windows.Forms.ToolStripMenuItem A_0)
		{
			for (;;)
			{
				global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem = null;
				int num = 0;
				int num2 = 2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_B4;
					case 1:
						if (toolStripMenuItem.HasDropDownItems)
						{
							num2 = 4;
							continue;
						}
						goto IL_3A;
					case 2:
						goto IL_90;
					case 3:
						goto IL_3A;
					case 4:
						this.a(toolStripMenuItem);
						num2 = 3;
						continue;
					case 5:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9B;
						default:
							if (false)
							{
							}
							toolStripMenuItem = (global::System.Windows.Forms.ToolStripMenuItem)A_0.DropDownItems[num];
							toolStripMenuItem.Click -= this.d;
							num2 = 1;
							continue;
						}
						break;
					case 6:
						goto IL_90;
					case 7:
						goto IL_9B;
					case 8:
						if (!(A_0.DropDownItems[num].GetType().ToString() == "System.Windows.Forms.ToolStripSeparator"))
						{
							num2 = 5;
							continue;
						}
						goto IL_3A;
					}
					break;
					IL_3A:
					num++;
					num2 = 6;
					continue;
					IL_9B:
					if (num >= A_0.DropDownItems.Count)
					{
						num2 = 0;
						continue;
					}
					num2 = 8;
					continue;
					IL_90:
					num2 = 7;
				}
			}
			IL_B4:
			if (true)
			{
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000D338 File Offset: 0x0000B538
		private void d(object A_0, global::System.EventArgs A_1)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						bool flag = false;
						global::System.Collections.ArrayList arrayList = null;
						global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem = (global::System.Windows.Forms.ToolStripMenuItem)A_0;
						int num = 74;
						for (;;)
						{
							switch (num)
							{
							case 0:
								global::h.a = new global::System.Collections.Generic.Dictionary<string, int>(10)
								{
									{
										"menuItemGoTo",
										0
									},
									{
										"mnuEditDelete",
										1
									},
									{
										"mnuEditCut",
										2
									},
									{
										"mnuEditCopy",
										3
									},
									{
										"mnuEditPaste",
										4
									},
									{
										"mnuEditSortByName",
										5
									},
									{
										"mnuEditSortByPosition",
										6
									},
									{
										"mnuEditSortByType",
										7
									},
									{
										"mnuEditUndo",
										8
									},
									{
										"mnuEditRedo",
										9
									}
								};
								num = 8;
								continue;
							case 1:
								num = 30;
								continue;
							case 2:
								if (base.CurrentCell.IsInEditMode)
								{
									num = 67;
									continue;
								}
								goto IL_3B6;
							case 3:
								num = 10;
								continue;
							case 4:
								goto IL_B1D;
							case 5:
								this.SortGridRow(this, toolStripMenuItem.Name);
								num = 66;
								continue;
							case 6:
								goto IL_3DA;
							case 7:
								goto IL_3B6;
							case 8:
								goto IL_5D9;
							case 9:
								if (base.CurrentRow != null)
								{
									num = 42;
									continue;
								}
								goto IL_B63;
							case 10:
								goto IL_8F0;
							case 11:
								num = 2;
								continue;
							case 12:
								if (null == base.CurrentCell.EditType)
								{
									num = 95;
									continue;
								}
								goto IL_A93;
							case 13:
								goto IL_3C2;
							case 14:
								if (toolStripMenuItem.Visible)
								{
									num = 87;
									continue;
								}
								goto IL_C13;
							case 15:
								goto IL_C13;
							case 16:
								if (base.CurrentCell.IsInEditMode)
								{
									num = 71;
									continue;
								}
								goto IL_697;
							case 17:
								if (base.SelectedRows.Count == 0)
								{
									num = 62;
									continue;
								}
								goto IL_AEE;
							case 18:
								num = 68;
								continue;
							case 19:
								num = 70;
								continue;
							case 20:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_330;
								default:
									if (false)
									{
									}
									goto IL_C13;
								}
								break;
							case 21:
								if (this.ac != null)
								{
									num = 64;
									continue;
								}
								goto IL_C13;
							case 22:
								if (this.ab != null)
								{
									num = 76;
									continue;
								}
								goto IL_C13;
							case 23:
								if (base.SelectedRows.Count == 0)
								{
									num = 18;
									continue;
								}
								goto IL_80B;
							case 24:
								goto IL_A55;
							case 25:
							{
								int num2;
								if (num2 >= arrayList.Count)
								{
									num = 20;
									continue;
								}
								int index = (int)arrayList[num2];
								base.Rows[index].Selected = true;
								num2++;
								num = 31;
								continue;
							}
							case 26:
								num = 101;
								continue;
							case 27:
							{
								global::System.Windows.Forms.DataGridViewColumn columnByName;
								if (base.CurrentRow.Cells[columnByName.Index].ReadOnly)
								{
									num = 47;
									continue;
								}
								goto IL_B63;
							}
							case 28:
								num = 78;
								continue;
							case 29:
							{
								global::custom_controls.CCustomDataGridViewRow[] array = new global::custom_controls.CCustomDataGridViewRow[base.SelectedRows.Count];
								base.SelectedRows.CopyTo(array, 0);
								this.aa(A_0, A_1, this, array);
								num = 96;
								continue;
							}
							case 30:
								if (global::h.a == null)
								{
									num = 0;
									continue;
								}
								goto IL_5D9;
							case 31:
								goto IL_330;
							case 32:
								num = 90;
								continue;
							case 33:
								if (base.CurrentCell != null)
								{
									num = 58;
									continue;
								}
								goto IL_A93;
							case 34:
								if (base.CurrentCell.IsInEditMode)
								{
									num = 19;
									continue;
								}
								goto IL_A55;
							case 35:
								num = 80;
								continue;
							case 36:
								if (null == base.CurrentCell.EditType)
								{
									num = 7;
									continue;
								}
								goto IL_80B;
							case 37:
								goto IL_C13;
							case 38:
								goto IL_C13;
							case 39:
								goto IL_55A;
							case 40:
								if (base.CurrentCell != null)
								{
									num = 45;
									continue;
								}
								goto IL_291;
							case 41:
								if (base.SelectedRows.Count == 0)
								{
									num = 84;
									continue;
								}
								goto IL_291;
							case 42:
								num = 27;
								continue;
							case 43:
								num = 98;
								continue;
							case 44:
								goto IL_6A3;
							case 45:
								num = 34;
								continue;
							case 46:
								if (this.SortGridRow != null)
								{
									num = 5;
									continue;
								}
								goto IL_C13;
							case 47:
								flag = false;
								num = 82;
								continue;
							case 48:
								goto IL_794;
							case 49:
								goto IL_3DA;
							case 50:
								goto IL_C1F;
							case 51:
								if (flag)
								{
									num = 85;
									continue;
								}
								goto IL_B63;
							case 52:
								goto IL_4FE;
							case 53:
							{
								global::custom_controls.CCustomDataGridViewRow[] array2 = new global::custom_controls.CCustomDataGridViewRow[base.SelectedRows.Count];
								base.SelectedRows.CopyTo(array2, 0);
								this.z(A_0, A_1, this, array2);
								num = 97;
								continue;
							}
							case 54:
								if (base.SelectedRows.Count <= 0)
								{
									num = 65;
									continue;
								}
								goto IL_C13;
							case 55:
								if (arrayList != null)
								{
									num = 32;
									continue;
								}
								goto IL_788;
							case 56:
								num = 33;
								continue;
							case 57:
								if (flag)
								{
									num = 53;
									continue;
								}
								goto IL_C13;
							case 58:
								num = 16;
								continue;
							case 59:
								if (this.aa != null)
								{
									num = 29;
									continue;
								}
								goto IL_C13;
							case 60:
								if (base.SelectedRows.Count > 0)
								{
									num = 79;
									continue;
								}
								this.y(A_0, A_1, this, 0);
								num = 6;
								continue;
							case 61:
								goto IL_C13;
							case 62:
								num = 69;
								continue;
							case 63:
								num = 103;
								continue;
							case 64:
								this.ac(A_0, A_1, this);
								num = 15;
								continue;
							case 65:
								num = 55;
								continue;
							case 66:
								goto IL_C13;
							case 67:
								num = 36;
								continue;
							case 68:
								if (base.CurrentCell != null)
								{
									num = 11;
									continue;
								}
								goto IL_80B;
							case 69:
								if (base.CurrentCell != null)
								{
									num = 63;
									continue;
								}
								goto IL_AEE;
							case 70:
								if (null == base.CurrentCell.EditType)
								{
									num = 24;
									continue;
								}
								goto IL_291;
							case 71:
								num = 12;
								continue;
							case 72:
							{
								string name;
								int num3;
								if (global::h.a.TryGetValue(name, out num3))
								{
									num = 43;
									continue;
								}
								goto IL_8F0;
							}
							case 73:
								flag = true;
								num = 88;
								continue;
							case 74:
							{
								string name;
								if ((name = toolStripMenuItem.Name) != null)
								{
									num = 1;
									continue;
								}
								goto IL_8F0;
							}
							case 75:
								if (base.Name.Equals("ZN_PER_ASGN_DLH_TYPE"))
								{
									num = 100;
									continue;
								}
								goto IL_B63;
							case 76:
							{
								global::custom_controls.CCustomDataGridViewRow[] array3 = new global::custom_controls.CCustomDataGridViewRow[base.SelectedRows.Count];
								base.SelectedRows.CopyTo(array3, 0);
								this.ab(A_0, A_1, this, array3);
								num = 61;
								continue;
							}
							case 77:
								if (this.z != null)
								{
									num = 26;
									continue;
								}
								goto IL_C13;
							case 78:
								if (null == base.CurrentCell.EditType)
								{
									num = 99;
									continue;
								}
								goto IL_AEE;
							case 79:
								this.y(A_0, A_1, this, base.SelectedRows[0].Index);
								num = 49;
								continue;
							case 80:
								if (this.IsValidSequenceDeletionFromBottom())
								{
									num = 73;
									continue;
								}
								flag = false;
								num = 39;
								continue;
							case 81:
								if (this.ah != null)
								{
									num = 93;
									continue;
								}
								goto IL_4FE;
							case 82:
								goto IL_B63;
							case 83:
								goto IL_A61;
							case 84:
								num = 40;
								continue;
							case 85:
								num = 75;
								continue;
							case 86:
								if (base.SelectedRows.Count == 0)
								{
									num = 56;
									continue;
								}
								goto IL_A93;
							case 87:
								toolStripMenuItem.Visible = false;
								num = 38;
								continue;
							case 88:
								goto IL_55A;
							case 89:
								goto IL_55A;
							case 90:
							{
								if (arrayList.Count <= 0)
								{
									num = 102;
									continue;
								}
								int num2 = 0;
								num = 4;
								continue;
							}
							case 91:
								goto IL_269;
							case 92:
								arrayList = this.SelectedRowIndex;
								num = 60;
								continue;
							case 93:
								this.ah(A_0, A_1);
								num = 52;
								continue;
							case 94:
								if (this.y != null)
								{
									num = 92;
									continue;
								}
								goto IL_C13;
							case 95:
								goto IL_697;
							case 96:
								goto IL_C13;
							case 97:
								goto IL_C13;
							case 98:
							{
								int num3;
								switch (num3)
								{
								case 0:
									this.TriggerSelectTarget(A_0, A_1);
									num = 37;
									continue;
								case 1:
									num = 23;
									continue;
								case 2:
									num = 86;
									continue;
								case 3:
									num = 41;
									continue;
								case 4:
									num = 17;
									continue;
								case 5:
								case 6:
								case 7:
									num = 46;
									continue;
								case 8:
								case 9:
									num = 81;
									continue;
								default:
									num = 3;
									continue;
								}
								break;
							}
							case 99:
								goto IL_25D;
							case 100:
							{
								global::System.Windows.Forms.DataGridViewColumn columnByName = this.GetColumnByName("ALIAS");
								num = 9;
								continue;
							}
							case 101:
								if (this.l)
								{
									num = 35;
									continue;
								}
								flag = true;
								num = 89;
								continue;
							case 102:
								goto IL_788;
							case 103:
								if (base.CurrentCell.IsInEditMode)
								{
									num = 28;
									continue;
								}
								goto IL_25D;
							}
							break;
							IL_25D:
							num = 91;
							continue;
							IL_291:
							num = 22;
							continue;
							IL_3B6:
							num = 13;
							continue;
							IL_3DA:
							base.Focus();
							num = 54;
							continue;
							IL_4FE:
							num = 14;
							continue;
							IL_55A:
							num = 51;
							continue;
							IL_5D9:
							num = 72;
							continue;
							IL_697:
							num = 44;
							continue;
							IL_788:
							num = 48;
							continue;
							IL_80B:
							num = 77;
							continue;
							IL_8F0:
							num = 94;
							continue;
							IL_A55:
							num = 83;
							continue;
							IL_A93:
							num = 59;
							continue;
							IL_AEE:
							arrayList = this.SelectedRowIndex;
							num = 21;
							continue;
							IL_B1D:
							num = 25;
							continue;
							IL_330:
							goto IL_B1D;
							IL_B63:
							num = 57;
							continue;
							IL_C13:
							num = 50;
						}
					}
					IL_269:
					IL_3C2:
					IL_6A3:
					IL_794:
					IL_A61:
					IL_C1F:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000DFBC File Offset: 0x0000C1BC
		private void c(object A_0, global::System.EventArgs A_1)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem = null;
					int num = 0;
					int num2 = 68;
					for (;;)
					{
						string text2;
						switch (num2)
						{
						case 0:
							if (base.Name.Equals("ZN_PER_ASGN_DLH_TYPE"))
							{
								num2 = 11;
								continue;
							}
							goto IL_336;
						case 1:
							if (base.SelectedRows.Count > 0)
							{
								num2 = 31;
								continue;
							}
							goto IL_336;
						case 2:
						{
							global::System.Windows.Forms.IDataObject dataObject;
							if (dataObject.GetDataPresent(global::System.Windows.Forms.DataFormats.Text))
							{
								goto IL_47A;
							}
							goto IL_336;
						}
						case 3:
							num2 = 2;
							continue;
						case 4:
						{
							string name;
							if (!(name == "mnuEditPaste"))
							{
								num2 = 62;
								continue;
							}
							global::System.Windows.Forms.IDataObject dataObject = global::System.Windows.Forms.Clipboard.GetDataObject();
							num2 = 50;
							continue;
						}
						case 5:
							if (this.IsValidSequenceDeletionFromBottom())
							{
								num2 = 33;
								continue;
							}
							toolStripMenuItem.Enabled = false;
							num2 = 45;
							continue;
						case 6:
						{
							if (base.SelectedRows.Count > 0)
							{
								num2 = 12;
								continue;
							}
							string text = this.f;
							text = text.Replace("%1", string.Empty);
							toolStripMenuItem.Text = text;
							toolStripMenuItem.Enabled = false;
							num2 = 84;
							continue;
						}
						case 7:
							toolStripMenuItem.Enabled = false;
							num2 = 86;
							continue;
						case 8:
							goto IL_18B;
						case 9:
							goto IL_7A3;
						case 10:
							if (base.SelectedRows.Count > 0)
							{
								num2 = 69;
								continue;
							}
							goto IL_336;
						case 11:
						{
							global::System.Windows.Forms.DataGridViewColumn columnByName = this.GetColumnByName("ALIAS");
							num2 = 81;
							continue;
						}
						case 12:
						{
							global::System.Windows.Forms.DataGridViewColumn columnByName2 = this.GetColumnByName("ALIAS");
							num2 = 28;
							continue;
						}
						case 13:
							goto IL_336;
						case 14:
							num2 = 67;
							continue;
						case 15:
						{
							string name;
							if ((name = toolStripMenuItem.Name) != null)
							{
								num2 = 22;
								continue;
							}
							goto IL_7A3;
						}
						case 16:
							if (base.SelectedRows.Count > 0)
							{
								num2 = 32;
								continue;
							}
							goto IL_336;
						case 17:
							num2 = 0;
							continue;
						case 18:
							if (text2 == "UCL_GLB_PHONE_NUMBER_DLT_TYPE")
							{
								num2 = 77;
								continue;
							}
							goto IL_1D8;
						case 19:
						{
							global::System.Windows.Forms.DataGridViewColumn columnByName;
							if (base.CurrentRow.Cells[columnByName.Index].ReadOnly)
							{
								num2 = 7;
								continue;
							}
							goto IL_336;
						}
						case 20:
						{
							string text = this.f;
							global::System.Windows.Forms.DataGridViewColumn columnByName2;
							text = text.Replace("%1", base.SelectedRows[0].Cells[columnByName2.Index].Value.ToString());
							toolStripMenuItem.Text = text;
							toolStripMenuItem.Enabled = true;
							num2 = 36;
							continue;
						}
						case 21:
							if (num >= this.ContextMenuStrip.Items.Count)
							{
								num2 = 53;
								continue;
							}
							if (true)
							{
							}
							num2 = 26;
							continue;
						case 22:
							num2 = 80;
							continue;
						case 23:
						{
							global::System.Windows.Forms.DataGridViewColumn columnByName2;
							if (columnByName2 != null)
							{
								num2 = 20;
								continue;
							}
							goto IL_336;
						}
						case 24:
							toolStripMenuItem = (global::System.Windows.Forms.ToolStripMenuItem)this.ContextMenuStrip.Items[num];
							toolStripMenuItem.Enabled = false;
							num2 = 15;
							continue;
						case 25:
							goto IL_546;
						case 26:
							if (!(this.ContextMenuStrip.Items[num].GetType().ToString() == "System.Windows.Forms.ToolStripSeparator"))
							{
								num2 = 24;
								continue;
							}
							goto IL_336;
						case 27:
							if (base.Rows.Count > 0)
							{
								num2 = 52;
								continue;
							}
							goto IL_336;
						case 28:
							if (base.SelectedRows[0].Tag.Equals("TRK_PER_CMP_TYPE"))
							{
								num2 = 73;
								continue;
							}
							goto IL_546;
						case 29:
							goto IL_4B9;
						case 30:
							num2 = 56;
							continue;
						case 31:
							toolStripMenuItem.Enabled = true;
							num2 = 13;
							continue;
						case 32:
							num2 = 65;
							continue;
						case 33:
							toolStripMenuItem.Enabled = true;
							num2 = 29;
							continue;
						case 34:
							num2 = 76;
							continue;
						case 35:
						{
							global::System.Windows.Forms.IDataObject dataObject;
							if (dataObject.GetDataPresent((string)base.Tag))
							{
								num2 = 34;
								continue;
							}
							goto IL_4F6;
						}
						case 36:
							goto IL_336;
						case 37:
							num2 = 5;
							continue;
						case 38:
							num2 = 55;
							continue;
						case 39:
							goto IL_336;
						case 40:
							if (text2.Contains("UCL_GLB_PHONE_NUMBER"))
							{
								num2 = 43;
								continue;
							}
							goto IL_336;
						case 41:
							goto IL_4F6;
						case 42:
							goto IL_336;
						case 43:
							num2 = 75;
							continue;
						case 44:
							num2 = 51;
							continue;
						case 45:
							goto IL_4B9;
						case 46:
						{
							string name;
							if (!(name == "mnuEditDelete"))
							{
								num2 = 30;
								continue;
							}
							num2 = 16;
							continue;
						}
						case 47:
							num2 = 27;
							continue;
						case 48:
							num2 = 72;
							continue;
						case 49:
							goto IL_336;
						case 50:
							if (this.CanEditTreeNode)
							{
								num2 = 66;
								continue;
							}
							goto IL_4F6;
						case 51:
							if (base.Rows.Count > 0)
							{
								num2 = 8;
								continue;
							}
							goto IL_86F;
						case 52:
							goto IL_716;
						case 53:
							return;
						case 54:
							goto IL_92E;
						case 55:
						{
							global::System.Windows.Forms.IDataObject dataObject;
							if (dataObject.GetData(text2) == null)
							{
								num2 = 64;
								continue;
							}
							goto IL_716;
						}
						case 56:
						{
							string name;
							if (!(name == "mnuEditCut"))
							{
								num2 = 14;
								continue;
							}
							num2 = 10;
							continue;
						}
						case 57:
							num2 = 46;
							continue;
						case 58:
							num2 = 4;
							continue;
						case 59:
							text2 = "UCL_GLB_PHONE_NUMBER_DLT_TYPE";
							num2 = 61;
							continue;
						case 60:
							goto IL_4B9;
						case 61:
							goto IL_1D8;
						case 62:
							num2 = 9;
							continue;
						case 63:
						{
							global::System.Windows.Forms.IDataObject dataObject;
							if (dataObject.GetDataPresent(text2))
							{
								num2 = 38;
								continue;
							}
							goto IL_311;
						}
						case 64:
							goto IL_311;
						case 65:
							if (this.l)
							{
								num2 = 37;
								continue;
							}
							toolStripMenuItem.Enabled = true;
							num2 = 60;
							continue;
						case 66:
							num2 = 35;
							continue;
						case 67:
						{
							string name;
							if (!(name == "mnuEditCopy"))
							{
								num2 = 58;
								continue;
							}
							num2 = 1;
							continue;
						}
						case 68:
							goto IL_92E;
						case 69:
							toolStripMenuItem.Enabled = true;
							num2 = 71;
							continue;
						case 70:
							if (this.CanEditTreeNode)
							{
								num2 = 83;
								continue;
							}
							goto IL_311;
						case 71:
							goto IL_336;
						case 72:
						{
							global::System.Windows.Forms.IDataObject dataObject;
							if (dataObject.GetDataPresent(global::System.Windows.Forms.DataFormats.Text))
							{
								num2 = 44;
								continue;
							}
							goto IL_86F;
						}
						case 73:
						{
							global::System.Windows.Forms.DataGridViewColumn columnByName2 = this.GetColumnByName("TRKP_TRKPERALIAS");
							num2 = 25;
							continue;
						}
						case 74:
							goto IL_1D8;
						case 75:
							if (text2 == "UCL_GLB_PHONE_NUMBER_DLH_TYPE")
							{
								num2 = 59;
								continue;
							}
							num2 = 18;
							continue;
						case 76:
						{
							global::System.Windows.Forms.IDataObject dataObject;
							if (dataObject.GetData((string)base.Tag) == null)
							{
								num2 = 41;
								continue;
							}
							goto IL_18B;
						}
						case 77:
							text2 = "UCL_GLB_PHONE_NUMBER_DLH_TYPE";
							num2 = 74;
							continue;
						case 78:
							if (!this.CanEditTreeNode)
							{
								num2 = 48;
								continue;
							}
							goto IL_86F;
						case 79:
							num2 = 19;
							continue;
						case 80:
						{
							string name;
							if (!(name == "menuItemGoTo"))
							{
								num2 = 57;
								continue;
							}
							string text = string.Empty;
							num2 = 6;
							continue;
						}
						case 81:
							if (base.CurrentRow != null)
							{
								num2 = 79;
								continue;
							}
							goto IL_336;
						case 82:
							if (toolStripMenuItem.Enabled)
							{
								num2 = 17;
								continue;
							}
							goto IL_336;
						case 83:
							num2 = 63;
							continue;
						case 84:
							goto IL_336;
						case 85:
							if (!this.CanEditTreeNode)
							{
								num2 = 3;
								continue;
							}
							goto IL_336;
						case 86:
							goto IL_336;
						}
						break;
						IL_18B:
						toolStripMenuItem.Enabled = true;
						num2 = 39;
						continue;
						IL_1D8:
						num2 = 70;
						continue;
						IL_311:
						num2 = 85;
						continue;
						IL_336:
						num++;
						num2 = 54;
						continue;
						IL_47A:
						num2 = 47;
						continue;
						IL_716:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_47A;
						default:
							if (false)
							{
							}
							toolStripMenuItem.Enabled = true;
							num2 = 49;
							continue;
						}
						IL_4B9:
						num2 = 82;
						continue;
						IL_4F6:
						num2 = 78;
						continue;
						IL_546:
						num2 = 23;
						continue;
						IL_7A3:
						toolStripMenuItem.Enabled = true;
						num2 = 42;
						continue;
						IL_86F:
						text2 = (string)base.Tag;
						num2 = 40;
						continue;
						IL_92E:
						num2 = 21;
					}
				}
				return;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000E9EC File Offset: 0x0000CBEC
		public bool IsValidSequenceDeletionFromBottom()
		{
			switch (0)
			{
			default:
			{
				bool result;
				for (;;)
				{
					IL_6B:
					result = false;
					int count = base.SelectedRows.Count;
					for (;;)
					{
						IL_79:
						int num = 11;
						for (;;)
						{
							if (true)
							{
							}
							switch (num)
							{
							case 0:
								goto IL_BC;
							case 1:
							{
								int num2;
								int num3;
								if (base.SelectedRows[num2].Index <= num3)
								{
									num = 7;
									continue;
								}
								goto IL_186;
							}
							case 2:
								goto IL_BC;
							case 3:
								result = true;
								num = 14;
								continue;
							case 4:
							{
								int index;
								if (index == base.RowCount - 1)
								{
									num = 3;
									continue;
								}
								result = false;
								num = 16;
								continue;
							}
							case 5:
								num = 13;
								continue;
							case 6:
								if (base.CurrentRow != null)
								{
									num = 9;
									continue;
								}
								return result;
							case 7:
								result = true;
								num = 15;
								continue;
							case 8:
							{
								int num2;
								int num4;
								if (base.SelectedRows[num2].Index >= num4)
								{
									num = 17;
									continue;
								}
								goto IL_186;
							}
							case 9:
							{
								int index = base.CurrentRow.Index;
								num = 4;
								continue;
							}
							case 10:
							{
								int num3 = base.RowCount - 1;
								int num4 = base.RowCount - count;
								int num2 = 0;
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_79;
								default:
									if (false)
									{
									}
									num = 0;
									continue;
								}
								break;
							}
							case 11:
								if (count > 0)
								{
									num = 10;
									continue;
								}
								num = 6;
								continue;
							case 12:
							{
								int num2;
								if (num2 >= count)
								{
									num = 5;
									continue;
								}
								num = 8;
								continue;
							}
							case 13:
								return result;
							case 14:
								return result;
							case 15:
							{
								int num2;
								num2++;
								num = 2;
								continue;
							}
							case 16:
								return result;
							case 17:
								num = 1;
								continue;
							case 18:
								return result;
							}
							goto IL_6B;
							IL_BC:
							num = 12;
							continue;
							IL_186:
							result = false;
							num = 18;
						}
					}
				}
				return result;
			}
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000081 RID: 129 RVA: 0x0000EC38 File Offset: 0x0000CE38
		// (remove) Token: 0x06000082 RID: 130 RVA: 0x0000ECCC File Offset: 0x0000CECC
		public event global::custom_controls.CCustomDataGridView.OnComboBoxCellIndexChanged ComboBoxCellIndexChanged
		{
			add
			{
				for (;;)
				{
					IL_3A:
					global::custom_controls.CCustomDataGridView.OnComboBoxCellIndexChanged onComboBoxCellIndexChanged = this.w;
					int num = 2;
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_70;
						default:
							if (false)
							{
							}
							switch (num)
							{
							case 0:
								goto IL_70;
							case 1:
								goto IL_7C;
							case 2:
								goto IL_4B;
							}
							goto IL_3A;
						}
						IL_4B:
						global::custom_controls.CCustomDataGridView.OnComboBoxCellIndexChanged onComboBoxCellIndexChanged2 = onComboBoxCellIndexChanged;
						global::custom_controls.CCustomDataGridView.OnComboBoxCellIndexChanged value2 = (global::custom_controls.CCustomDataGridView.OnComboBoxCellIndexChanged)global::System.Delegate.Combine(onComboBoxCellIndexChanged2, value);
						onComboBoxCellIndexChanged = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.OnComboBoxCellIndexChanged>(ref this.w, value2, onComboBoxCellIndexChanged2);
						num = 0;
						continue;
						IL_70:
						if (onComboBoxCellIndexChanged != onComboBoxCellIndexChanged2)
						{
							goto IL_4B;
						}
						num = 1;
					}
				}
				IL_7C:
				if (true)
				{
				}
			}
			remove
			{
				for (;;)
				{
					IL_14:
					int num;
					global::custom_controls.CCustomDataGridView.OnComboBoxCellIndexChanged onComboBoxCellIndexChanged;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_68:
						num = 0;
						break;
					default:
						if (false)
						{
						}
						onComboBoxCellIndexChanged = this.w;
						num = 1;
						break;
					}
					global::custom_controls.CCustomDataGridView.OnComboBoxCellIndexChanged onComboBoxCellIndexChanged2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (onComboBoxCellIndexChanged == onComboBoxCellIndexChanged2)
							{
								if (true)
								{
								}
								num = 2;
								continue;
							}
							goto IL_4B;
						case 1:
							goto IL_49;
						case 2:
							return;
						}
						goto IL_14;
					}
					IL_4B:
					onComboBoxCellIndexChanged2 = onComboBoxCellIndexChanged;
					global::custom_controls.CCustomDataGridView.OnComboBoxCellIndexChanged value2 = (global::custom_controls.CCustomDataGridView.OnComboBoxCellIndexChanged)global::System.Delegate.Remove(onComboBoxCellIndexChanged2, value);
					onComboBoxCellIndexChanged = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.OnComboBoxCellIndexChanged>(ref this.w, value2, onComboBoxCellIndexChanged2);
					goto IL_68;
					IL_49:
					goto IL_4B;
				}
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000083 RID: 131 RVA: 0x0000ED64 File Offset: 0x0000CF64
		// (remove) Token: 0x06000084 RID: 132 RVA: 0x0000EDF8 File Offset: 0x0000CFF8
		public event global::custom_controls.CCustomDataGridView.MoveSelectedRow MoveRow
		{
			add
			{
				if (true)
				{
				}
				for (;;)
				{
					IL_1C:
					int num;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_70:
						num = 1;
						break;
					case 1:
						goto IL_3C;
					default:
						goto IL_3C;
					}
					global::custom_controls.CCustomDataGridView.MoveSelectedRow moveSelectedRow;
					global::custom_controls.CCustomDataGridView.MoveSelectedRow moveSelectedRow2;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_51;
						case 1:
							if (moveSelectedRow == moveSelectedRow2)
							{
								num = 2;
								continue;
							}
							goto IL_53;
						case 2:
							return;
						}
						goto IL_1C;
					}
					IL_53:
					moveSelectedRow2 = moveSelectedRow;
					global::custom_controls.CCustomDataGridView.MoveSelectedRow value2 = (global::custom_controls.CCustomDataGridView.MoveSelectedRow)global::System.Delegate.Combine(moveSelectedRow2, value);
					moveSelectedRow = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.MoveSelectedRow>(ref this.x, value2, moveSelectedRow2);
					goto IL_70;
					IL_51:
					goto IL_53;
					IL_3C:
					if (false)
					{
					}
					moveSelectedRow = this.x;
					num = 0;
					goto IL_0A;
				}
			}
			remove
			{
				global::custom_controls.CCustomDataGridView.MoveSelectedRow moveSelectedRow;
				global::custom_controls.CCustomDataGridView.MoveSelectedRow moveSelectedRow2;
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_78:
					if (moveSelectedRow != moveSelectedRow2)
					{
						goto IL_53;
					}
					num = 2;
					break;
				default:
					if (false)
					{
					}
					goto IL_3A;
				}
				IL_28:
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					break;
				case 1:
					goto IL_78;
				case 2:
					return;
				default:
					IL_3A:
					moveSelectedRow = this.x;
					num = 0;
					goto IL_28;
				}
				IL_53:
				moveSelectedRow2 = moveSelectedRow;
				global::custom_controls.CCustomDataGridView.MoveSelectedRow value2 = (global::custom_controls.CCustomDataGridView.MoveSelectedRow)global::System.Delegate.Remove(moveSelectedRow2, value);
				moveSelectedRow = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.MoveSelectedRow>(ref this.x, value2, moveSelectedRow2);
				num = 1;
				goto IL_28;
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000085 RID: 133 RVA: 0x0000EE8C File Offset: 0x0000D08C
		// (remove) Token: 0x06000086 RID: 134 RVA: 0x0000EF20 File Offset: 0x0000D120
		public event global::custom_controls.CCustomDataGridView.AddNewRow AddRow
		{
			add
			{
				global::custom_controls.CCustomDataGridView.AddNewRow addNewRow;
				global::custom_controls.CCustomDataGridView.AddNewRow addNewRow2;
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_70:
					if (true)
					{
					}
					if (addNewRow != addNewRow2)
					{
						goto IL_4B;
					}
					num = 0;
					break;
				default:
					if (false)
					{
					}
					goto IL_3A;
				}
				IL_28:
				switch (num)
				{
				case 0:
					return;
				case 1:
					break;
				case 2:
					goto IL_70;
				default:
					IL_3A:
					addNewRow = this.y;
					num = 1;
					goto IL_28;
				}
				IL_4B:
				addNewRow2 = addNewRow;
				global::custom_controls.CCustomDataGridView.AddNewRow value2 = (global::custom_controls.CCustomDataGridView.AddNewRow)global::System.Delegate.Combine(addNewRow2, value);
				addNewRow = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.AddNewRow>(ref this.y, value2, addNewRow2);
				num = 2;
				goto IL_28;
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.CCustomDataGridView.AddNewRow addNewRow = this.y;
					int num = 2;
					for (;;)
					{
						if (true)
						{
						}
						global::custom_controls.CCustomDataGridView.AddNewRow addNewRow2;
						switch (num)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_35;
							default:
								goto IL_7E;
							}
							break;
						case 1:
							if (addNewRow == addNewRow2)
							{
								num = 0;
								continue;
							}
							goto IL_37;
						case 2:
							goto IL_35;
						}
						break;
						IL_37:
						addNewRow2 = addNewRow;
						global::custom_controls.CCustomDataGridView.AddNewRow value2 = (global::custom_controls.CCustomDataGridView.AddNewRow)global::System.Delegate.Remove(addNewRow2, value);
						addNewRow = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.AddNewRow>(ref this.y, value2, addNewRow2);
						num = 1;
						continue;
						IL_35:
						goto IL_37;
					}
				}
				IL_7E:
				if (false)
				{
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000087 RID: 135 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
		// (remove) Token: 0x06000088 RID: 136 RVA: 0x0000F048 File Offset: 0x0000D248
		public event global::custom_controls.CCustomDataGridView.DeleteSelectedRow DeleteRow
		{
			add
			{
				for (;;)
				{
					global::custom_controls.CCustomDataGridView.DeleteSelectedRow deleteSelectedRow = this.z;
					int num = 1;
					for (;;)
					{
						global::custom_controls.CCustomDataGridView.DeleteSelectedRow deleteSelectedRow2;
						switch (num)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2D;
							default:
								goto IL_76;
							}
							break;
						case 1:
							goto IL_2D;
						case 2:
							if (deleteSelectedRow == deleteSelectedRow2)
							{
								num = 0;
								continue;
							}
							goto IL_2F;
						}
						break;
						IL_2F:
						deleteSelectedRow2 = deleteSelectedRow;
						global::custom_controls.CCustomDataGridView.DeleteSelectedRow value2 = (global::custom_controls.CCustomDataGridView.DeleteSelectedRow)global::System.Delegate.Combine(deleteSelectedRow2, value);
						deleteSelectedRow = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.DeleteSelectedRow>(ref this.z, value2, deleteSelectedRow2);
						num = 2;
						continue;
						IL_2D:
						goto IL_2F;
					}
				}
				IL_76:
				if (true)
				{
				}
				if (false)
				{
				}
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.CCustomDataGridView.DeleteSelectedRow deleteSelectedRow = this.z;
					int num = 2;
					for (;;)
					{
						global::custom_controls.CCustomDataGridView.DeleteSelectedRow deleteSelectedRow2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							if (deleteSelectedRow == deleteSelectedRow2)
							{
								goto IL_72;
							}
							goto IL_49;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_72;
							default:
								if (true)
								{
								}
								if (false)
								{
								}
								goto IL_49;
							}
							break;
						}
						break;
						IL_49:
						deleteSelectedRow2 = deleteSelectedRow;
						global::custom_controls.CCustomDataGridView.DeleteSelectedRow value2 = (global::custom_controls.CCustomDataGridView.DeleteSelectedRow)global::System.Delegate.Remove(deleteSelectedRow2, value);
						deleteSelectedRow = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.DeleteSelectedRow>(ref this.z, value2, deleteSelectedRow2);
						num = 1;
						continue;
						IL_72:
						num = 0;
					}
				}
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000089 RID: 137 RVA: 0x0000F0E0 File Offset: 0x0000D2E0
		// (remove) Token: 0x0600008A RID: 138 RVA: 0x0000F174 File Offset: 0x0000D374
		public event global::custom_controls.CCustomDataGridView.CutSelectedRow CutRow
		{
			add
			{
				if (true)
				{
				}
				for (;;)
				{
					global::custom_controls.CCustomDataGridView.CutSelectedRow cutSelectedRow = this.aa;
					int num = 0;
					for (;;)
					{
						global::custom_controls.CCustomDataGridView.CutSelectedRow cutSelectedRow2;
						switch (num)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_72;
							default:
								if (false)
								{
								}
								goto IL_49;
							}
							break;
						case 1:
							if (cutSelectedRow == cutSelectedRow2)
							{
								goto IL_72;
							}
							goto IL_49;
						case 2:
							return;
						}
						break;
						IL_49:
						cutSelectedRow2 = cutSelectedRow;
						global::custom_controls.CCustomDataGridView.CutSelectedRow value2 = (global::custom_controls.CCustomDataGridView.CutSelectedRow)global::System.Delegate.Combine(cutSelectedRow2, value);
						cutSelectedRow = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.CutSelectedRow>(ref this.aa, value2, cutSelectedRow2);
						num = 1;
						continue;
						IL_72:
						num = 2;
					}
				}
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.CCustomDataGridView.CutSelectedRow cutSelectedRow = this.aa;
					int num = 1;
					for (;;)
					{
						IL_02:
						global::custom_controls.CCustomDataGridView.CutSelectedRow cutSelectedRow2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_25;
						case 2:
							while (cutSelectedRow == cutSelectedRow2)
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
									num = 0;
									goto IL_02;
								}
							}
							goto IL_25;
						}
						break;
						IL_25:
						cutSelectedRow2 = cutSelectedRow;
						global::custom_controls.CCustomDataGridView.CutSelectedRow value2 = (global::custom_controls.CCustomDataGridView.CutSelectedRow)global::System.Delegate.Remove(cutSelectedRow2, value);
						cutSelectedRow = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.CutSelectedRow>(ref this.aa, value2, cutSelectedRow2);
						num = 2;
					}
				}
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600008B RID: 139 RVA: 0x0000F208 File Offset: 0x0000D408
		// (remove) Token: 0x0600008C RID: 140 RVA: 0x0000F29C File Offset: 0x0000D49C
		public event global::custom_controls.CCustomDataGridView.CopySelectedRow CopyRow
		{
			add
			{
				for (;;)
				{
					global::custom_controls.CCustomDataGridView.CopySelectedRow copySelectedRow = this.ab;
					int num = 1;
					for (;;)
					{
						IL_02:
						global::custom_controls.CCustomDataGridView.CopySelectedRow copySelectedRow2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_25;
						case 2:
							while (copySelectedRow == copySelectedRow2)
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
									num = 0;
									goto IL_02;
								}
							}
							goto IL_25;
						}
						break;
						IL_25:
						copySelectedRow2 = copySelectedRow;
						global::custom_controls.CCustomDataGridView.CopySelectedRow value2 = (global::custom_controls.CCustomDataGridView.CopySelectedRow)global::System.Delegate.Combine(copySelectedRow2, value);
						copySelectedRow = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.CopySelectedRow>(ref this.ab, value2, copySelectedRow2);
						num = 2;
					}
				}
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.CCustomDataGridView.CopySelectedRow copySelectedRow = this.ab;
					if (true)
					{
					}
					int num = 0;
					for (;;)
					{
						global::custom_controls.CCustomDataGridView.CopySelectedRow copySelectedRow2;
						switch (num)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_7C;
							default:
								if (false)
								{
								}
								goto IL_53;
							}
							break;
						case 1:
							if (copySelectedRow == copySelectedRow2)
							{
								goto IL_7C;
							}
							goto IL_53;
						case 2:
							return;
						}
						break;
						IL_53:
						copySelectedRow2 = copySelectedRow;
						global::custom_controls.CCustomDataGridView.CopySelectedRow value2 = (global::custom_controls.CCustomDataGridView.CopySelectedRow)global::System.Delegate.Remove(copySelectedRow2, value);
						copySelectedRow = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.CopySelectedRow>(ref this.ab, value2, copySelectedRow2);
						num = 1;
						continue;
						IL_7C:
						num = 2;
					}
				}
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600008D RID: 141 RVA: 0x0000F334 File Offset: 0x0000D534
		// (remove) Token: 0x0600008E RID: 142 RVA: 0x0000F3CC File Offset: 0x0000D5CC
		public event global::custom_controls.CCustomDataGridView.PasteSelectedRow PasteRow
		{
			add
			{
				for (;;)
				{
					global::custom_controls.CCustomDataGridView.PasteSelectedRow pasteSelectedRow = this.ac;
					int num = 0;
					for (;;)
					{
						global::custom_controls.CCustomDataGridView.PasteSelectedRow pasteSelectedRow2;
						switch (num)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_7C;
							default:
								if (false)
								{
								}
								if (true)
								{
								}
								goto IL_53;
							}
							break;
						case 1:
							return;
						case 2:
							if (pasteSelectedRow == pasteSelectedRow2)
							{
								goto IL_7C;
							}
							goto IL_53;
						}
						break;
						IL_53:
						pasteSelectedRow2 = pasteSelectedRow;
						global::custom_controls.CCustomDataGridView.PasteSelectedRow value2 = (global::custom_controls.CCustomDataGridView.PasteSelectedRow)global::System.Delegate.Combine(pasteSelectedRow2, value);
						pasteSelectedRow = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.PasteSelectedRow>(ref this.ac, value2, pasteSelectedRow2);
						num = 2;
						continue;
						IL_7C:
						num = 1;
					}
				}
			}
			remove
			{
				for (;;)
				{
					IL_3A:
					global::custom_controls.CCustomDataGridView.PasteSelectedRow pasteSelectedRow = this.ac;
					int num = 0;
					for (;;)
					{
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
							global::custom_controls.CCustomDataGridView.PasteSelectedRow pasteSelectedRow2;
							switch (num)
							{
							case 0:
								goto IL_4B;
							case 1:
								return;
							case 2:
								if (pasteSelectedRow == pasteSelectedRow2)
								{
									if (true)
									{
									}
									num = 1;
									continue;
								}
								goto IL_4B;
							}
							goto IL_3A;
							IL_4B:
							pasteSelectedRow2 = pasteSelectedRow;
							global::custom_controls.CCustomDataGridView.PasteSelectedRow value2 = (global::custom_controls.CCustomDataGridView.PasteSelectedRow)global::System.Delegate.Remove(pasteSelectedRow2, value);
							pasteSelectedRow = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.PasteSelectedRow>(ref this.ac, value2, pasteSelectedRow2);
							num = 2;
							break;
						}
						}
					}
				}
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600008F RID: 143 RVA: 0x0000F464 File Offset: 0x0000D664
		// (remove) Token: 0x06000090 RID: 144 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		public event global::custom_controls.CCustomDataGridView.ControlFocusEvent DisableEnableRowsEdit
		{
			add
			{
				if (true)
				{
				}
				for (;;)
				{
					IL_38:
					global::custom_controls.CCustomDataGridView.ControlFocusEvent controlFocusEvent = this.ad;
					int num = 2;
					for (;;)
					{
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
							global::custom_controls.CCustomDataGridView.ControlFocusEvent controlFocusEvent2;
							switch (num)
							{
							case 0:
								return;
							case 1:
								if (controlFocusEvent == controlFocusEvent2)
								{
									num = 0;
									continue;
								}
								goto IL_49;
							case 2:
								goto IL_49;
							}
							goto IL_38;
							IL_49:
							controlFocusEvent2 = controlFocusEvent;
							global::custom_controls.CCustomDataGridView.ControlFocusEvent value2 = (global::custom_controls.CCustomDataGridView.ControlFocusEvent)global::System.Delegate.Combine(controlFocusEvent2, value);
							controlFocusEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.ControlFocusEvent>(ref this.ad, value2, controlFocusEvent2);
							num = 1;
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
					global::custom_controls.CCustomDataGridView.ControlFocusEvent controlFocusEvent = this.ad;
					int num = 2;
					for (;;)
					{
						if (true)
						{
						}
						switch (num)
						{
						case 0:
						{
							global::custom_controls.CCustomDataGridView.ControlFocusEvent controlFocusEvent2;
							if (controlFocusEvent == controlFocusEvent2)
							{
								num = 1;
								continue;
							}
							goto IL_2D;
						}
						case 1:
							return;
						case 2:
							goto IL_2D;
						}
						break;
						IL_2D:
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
							global::custom_controls.CCustomDataGridView.ControlFocusEvent controlFocusEvent2 = controlFocusEvent;
							global::custom_controls.CCustomDataGridView.ControlFocusEvent value2 = (global::custom_controls.CCustomDataGridView.ControlFocusEvent)global::System.Delegate.Remove(controlFocusEvent2, value);
							controlFocusEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.ControlFocusEvent>(ref this.ad, value2, controlFocusEvent2);
							break;
						}
						}
						num = 0;
					}
				}
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000091 RID: 145 RVA: 0x0000F590 File Offset: 0x0000D790
		// (remove) Token: 0x06000092 RID: 146 RVA: 0x0000F624 File Offset: 0x0000D824
		public event global::custom_controls.CCustomDataGridView.ControlFocusEvent DisableEnableCellsEdit
		{
			add
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
						global::custom_controls.CCustomDataGridView.ControlFocusEvent controlFocusEvent = this.ae;
						int num = 0;
						for (;;)
						{
							global::custom_controls.CCustomDataGridView.ControlFocusEvent controlFocusEvent2;
							switch (num)
							{
							case 0:
								goto IL_4B;
							case 1:
								if (controlFocusEvent == controlFocusEvent2)
								{
									num = 2;
									continue;
								}
								goto IL_4B;
							case 2:
								goto IL_7C;
							}
							break;
							IL_4B:
							controlFocusEvent2 = controlFocusEvent;
							global::custom_controls.CCustomDataGridView.ControlFocusEvent value2 = (global::custom_controls.CCustomDataGridView.ControlFocusEvent)global::System.Delegate.Combine(controlFocusEvent2, value);
							controlFocusEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.ControlFocusEvent>(ref this.ae, value2, controlFocusEvent2);
							num = 1;
						}
					}
					IL_7C:
					break;
				}
				if (true)
				{
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
					if (true)
					{
					}
					if (false)
					{
					}
					for (;;)
					{
						global::custom_controls.CCustomDataGridView.ControlFocusEvent controlFocusEvent = this.ae;
						int num = 1;
						for (;;)
						{
							global::custom_controls.CCustomDataGridView.ControlFocusEvent controlFocusEvent2;
							switch (num)
							{
							case 0:
								goto IL_84;
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
							global::custom_controls.CCustomDataGridView.ControlFocusEvent value2 = (global::custom_controls.CCustomDataGridView.ControlFocusEvent)global::System.Delegate.Remove(controlFocusEvent2, value);
							controlFocusEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.ControlFocusEvent>(ref this.ae, value2, controlFocusEvent2);
							num = 2;
						}
					}
					IL_84:
					break;
				}
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000093 RID: 147 RVA: 0x0000F6B8 File Offset: 0x0000D8B8
		// (remove) Token: 0x06000094 RID: 148 RVA: 0x0000F74C File Offset: 0x0000D94C
		public event global::custom_controls.CCustomDataGridView.ControlEvent ControlEnter
		{
			add
			{
				for (;;)
				{
					if (true)
					{
					}
					global::custom_controls.CCustomDataGridView.ControlEvent controlEvent = this.af;
					int num = 1;
					for (;;)
					{
						global::custom_controls.CCustomDataGridView.ControlEvent controlEvent2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_2D;
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
								if (controlEvent == controlEvent2)
								{
									num = 0;
									continue;
								}
								goto IL_2D;
							}
							break;
						}
						break;
						IL_2D:
						controlEvent2 = controlEvent;
						global::custom_controls.CCustomDataGridView.ControlEvent value2 = (global::custom_controls.CCustomDataGridView.ControlEvent)global::System.Delegate.Combine(controlEvent2, value);
						controlEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.ControlEvent>(ref this.af, value2, controlEvent2);
						num = 2;
					}
				}
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.CCustomDataGridView.ControlEvent controlEvent = this.af;
					int num = 1;
					for (;;)
					{
						global::custom_controls.CCustomDataGridView.ControlEvent controlEvent2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_25;
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
								if (controlEvent == controlEvent2)
								{
									num = 0;
									continue;
								}
								goto IL_25;
							}
							break;
						}
						break;
						IL_25:
						controlEvent2 = controlEvent;
						global::custom_controls.CCustomDataGridView.ControlEvent value2 = (global::custom_controls.CCustomDataGridView.ControlEvent)global::System.Delegate.Remove(controlEvent2, value);
						controlEvent = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.ControlEvent>(ref this.af, value2, controlEvent2);
						if (true)
						{
						}
						num = 2;
					}
				}
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000095 RID: 149 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		// (remove) Token: 0x06000096 RID: 150 RVA: 0x0000F874 File Offset: 0x0000DA74
		public event global::custom_controls.CCustomDataGridView.GetValueFromResourcefile GetResourceValue
		{
			add
			{
				global::custom_controls.CCustomDataGridView.GetValueFromResourcefile getValueFromResourcefile;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_3F:
					int num = 1;
					for (;;)
					{
						if (true)
						{
						}
						global::custom_controls.CCustomDataGridView.GetValueFromResourcefile getValueFromResourcefile2;
						switch (num)
						{
						case 0:
							if (getValueFromResourcefile == getValueFromResourcefile2)
							{
								num = 2;
								continue;
							}
							goto IL_49;
						case 1:
							goto IL_49;
						case 2:
							return;
						}
						goto IL_38;
						IL_49:
						getValueFromResourcefile2 = getValueFromResourcefile;
						global::custom_controls.CCustomDataGridView.GetValueFromResourcefile value2 = (global::custom_controls.CCustomDataGridView.GetValueFromResourcefile)global::System.Delegate.Combine(getValueFromResourcefile2, value);
						getValueFromResourcefile = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.GetValueFromResourcefile>(ref this.ag, value2, getValueFromResourcefile2);
						num = 0;
					}
					return;
				}
				default:
					if (false)
					{
					}
					break;
				}
				IL_38:
				getValueFromResourcefile = this.ag;
				goto IL_3F;
			}
			remove
			{
				global::custom_controls.CCustomDataGridView.GetValueFromResourcefile getValueFromResourcefile;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_37:
					int num = 2;
					for (;;)
					{
						global::custom_controls.CCustomDataGridView.GetValueFromResourcefile getValueFromResourcefile2;
						switch (num)
						{
						case 0:
							if (getValueFromResourcefile == getValueFromResourcefile2)
							{
								num = 1;
								continue;
							}
							goto IL_49;
						case 1:
							return;
						case 2:
							if (true)
							{
							}
							goto IL_49;
						}
						goto IL_30;
						IL_49:
						getValueFromResourcefile2 = getValueFromResourcefile;
						global::custom_controls.CCustomDataGridView.GetValueFromResourcefile value2 = (global::custom_controls.CCustomDataGridView.GetValueFromResourcefile)global::System.Delegate.Remove(getValueFromResourcefile2, value);
						getValueFromResourcefile = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.GetValueFromResourcefile>(ref this.ag, value2, getValueFromResourcefile2);
						num = 0;
					}
					return;
				}
				default:
					if (false)
					{
					}
					break;
				}
				IL_30:
				getValueFromResourcefile = this.ag;
				goto IL_37;
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000F908 File Offset: 0x0000DB08
		public void TriggerSelectTarget(object sender, global::System.EventArgs e)
		{
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_91;
				case 1:
					this.SelectTargetTreeNode((global::custom_controls.CCustomDataGridViewRow)base.SelectedRows[0]);
					if (true)
					{
					}
					num = 0;
					continue;
				case 2:
					num = 3;
					continue;
				case 3:
					IL_76:
					if (base.SelectedRows.Count > 0)
					{
						num = 1;
						continue;
					}
					goto IL_91;
				}
				if (this.SelectTargetTreeNode != null)
				{
					num = 2;
					continue;
				}
				IL_91:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_76;
				default:
					goto IL_A7;
				}
			}
			IL_A7:
			if (false)
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000098 RID: 152 RVA: 0x0000F9C4 File Offset: 0x0000DBC4
		// (remove) Token: 0x06000099 RID: 153 RVA: 0x0000FA5C File Offset: 0x0000DC5C
		public event global::custom_controls.CCustomDataGridView.UndoRedoMenuClick UndoRedoClick
		{
			add
			{
				for (;;)
				{
					global::custom_controls.CCustomDataGridView.UndoRedoMenuClick undoRedoMenuClick;
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
						undoRedoMenuClick = this.ah;
						num = 1;
						break;
					}
					for (;;)
					{
						if (true)
						{
						}
						global::custom_controls.CCustomDataGridView.UndoRedoMenuClick undoRedoMenuClick2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_53;
						case 2:
							if (undoRedoMenuClick == undoRedoMenuClick2)
							{
								num = 0;
								continue;
							}
							goto IL_53;
						}
						break;
						IL_53:
						undoRedoMenuClick2 = undoRedoMenuClick;
						global::custom_controls.CCustomDataGridView.UndoRedoMenuClick value2 = (global::custom_controls.CCustomDataGridView.UndoRedoMenuClick)global::System.Delegate.Combine(undoRedoMenuClick2, value);
						undoRedoMenuClick = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.UndoRedoMenuClick>(ref this.ah, value2, undoRedoMenuClick2);
						num = 2;
					}
				}
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.CCustomDataGridView.UndoRedoMenuClick undoRedoMenuClick;
					global::custom_controls.CCustomDataGridView.UndoRedoMenuClick undoRedoMenuClick2;
					int num;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_6E:
						if (undoRedoMenuClick != undoRedoMenuClick2)
						{
							goto IL_49;
						}
						num = 2;
						break;
					default:
						if (true)
						{
						}
						if (false)
						{
						}
						undoRedoMenuClick = this.ah;
						num = 0;
						break;
					}
					IL_02:
					switch (num)
					{
					case 0:
						goto IL_49;
					case 1:
						goto IL_6E;
					case 2:
						return;
					}
					continue;
					IL_49:
					undoRedoMenuClick2 = undoRedoMenuClick;
					global::custom_controls.CCustomDataGridView.UndoRedoMenuClick value2 = (global::custom_controls.CCustomDataGridView.UndoRedoMenuClick)global::System.Delegate.Remove(undoRedoMenuClick2, value);
					undoRedoMenuClick = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CCustomDataGridView.UndoRedoMenuClick>(ref this.ah, value2, undoRedoMenuClick2);
					num = 1;
					goto IL_02;
				}
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000FAF4 File Offset: 0x0000DCF4
		private static string b(global::System.Xml.XmlNode A_0, string A_1)
		{
			if (true)
			{
			}
			string text;
			for (;;)
			{
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_8F:
					if (!string.IsNullOrEmpty(text))
					{
						return text;
					}
					num = 3;
					break;
				default:
					if (false)
					{
					}
					text = string.Empty;
					num = 5;
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 0:
						text = A_0.Attributes[A_1].Value;
						num = 2;
						continue;
					case 1:
						goto IL_8F;
					case 2:
						goto IL_84;
					case 3:
						text = "-1";
						num = 4;
						continue;
					case 4:
						return text;
					case 5:
						if (A_0.Attributes[A_1] != null)
						{
							num = 0;
							continue;
						}
						goto IL_84;
					}
					break;
					IL_84:
					num = 1;
				}
			}
			return text;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000FBC8 File Offset: 0x0000DDC8
		private static bool a(global::System.Xml.XmlNode A_0, string A_1)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					goto IL_43;
				case 2:
					if ("POSITION" == A_1)
					{
						return true;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_43;
					default:
						if (false)
						{
						}
						num = 5;
						continue;
					}
					break;
				case 3:
					return true;
				case 4:
					goto IL_92;
				case 5:
					num = 6;
					continue;
				case 6:
					if ("PGK_HEADER" == A_1)
					{
						num = 4;
						continue;
					}
					return false;
				case 7:
					if (A_0.ChildNodes.Count > 0)
					{
						num = 9;
						continue;
					}
					num = 8;
					continue;
				case 8:
					if (A_0.Name == A_1)
					{
						num = 3;
						continue;
					}
					return false;
				case 9:
					return true;
				}
				if (A_0 == null)
				{
					num = 1;
					continue;
				}
				if (true)
				{
				}
				num = 7;
				continue;
				IL_43:
				num = 2;
			}
			return true;
			IL_92:
			return true;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
		private static bool a(global::System.Xml.XmlNode A_0, bool A_1)
		{
			bool result;
			for (;;)
			{
				for (;;)
				{
					result = false;
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (!A_0.Attributes["Applicable"].Value.Equals("NA"))
							{
								num = 6;
								continue;
							}
							goto IL_5D;
						case 1:
							if (!A_0.Attributes["Applicable"].Value.Equals("Disabled"))
							{
								num = 5;
								continue;
							}
							goto IL_5D;
						case 2:
							return result;
						case 3:
							goto IL_67;
						case 4:
							if (A_1)
							{
								num = 7;
								continue;
							}
							result = false;
							num = 2;
							continue;
						case 5:
							num = 0;
							continue;
						case 6:
							if (true)
							{
							}
							num = 4;
							continue;
						case 7:
							goto IL_5D;
						}
						break;
						IL_5D:
						result = true;
						num = 3;
					}
				}
				IL_67:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7D;
				}
			}
			IL_7D:
			if (false)
			{
			}
			return result;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000FDEC File Offset: 0x0000DFEC
		private void a(object A_0, int A_1, int A_2)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					int num = -1;
					int num2 = -1;
					global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow = (global::custom_controls.CCustomDataGridViewRow)base.Rows[A_1];
					global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow2 = (global::custom_controls.CCustomDataGridViewRow)base.Rows[A_2];
					global::System.Windows.Forms.DataGridViewColumn columnByName = this.GetColumnByName("POSITION");
					int num3 = 5;
					for (;;)
					{
						global::System.Windows.Forms.DataGridViewColumn sortedColumn;
						switch (num3)
						{
						case 0:
							if (true)
							{
							}
							this.x(A_0, this, ccustomDataGridViewRow.Tag.ToString(), "0", ccustomDataGridViewRow.LetID, "0", ccustomDataGridViewRow2.LetID);
							num3 = 10;
							continue;
						case 1:
							goto IL_287;
						case 2:
							if (sortedColumn == null)
							{
								num3 = 3;
								continue;
							}
							goto IL_1E3;
						case 3:
							num3 = 9;
							continue;
						case 4:
							goto IL_A5;
						case 5:
							if (columnByName == null)
							{
								num3 = 7;
								continue;
							}
							num = (int)ccustomDataGridViewRow.Cells[columnByName.Index].Value;
							num--;
							num2 = (int)ccustomDataGridViewRow2.Cells[columnByName.Index].Value;
							num2--;
							num3 = 8;
							continue;
						case 6:
							this.ad(this, new global::System.EventArgs());
							num3 = 4;
							continue;
						case 7:
							goto IL_99;
						case 8:
							if (this.x != null)
							{
								num3 = 0;
								continue;
							}
							goto IL_28C;
						case 9:
							if (this.g == global::System.Windows.Forms.SortOrder.None)
							{
								num3 = 1;
								continue;
							}
							goto IL_1E3;
						case 10:
							goto IL_28C;
						case 11:
							goto IL_201;
						case 12:
							if (this.ad != null)
							{
								num3 = 6;
								continue;
							}
							goto IL_A5;
						}
						break;
						IL_A5:
						sortedColumn = base.SortedColumn;
						num3 = 2;
						continue;
						IL_1E3:
						global::custom_controls.CCustomDataGridView.DataLoader dataLoader = new global::custom_controls.CCustomDataGridView.DataLoader(this);
						num3 = 11;
						continue;
						IL_28C:
						base.Rows.RemoveAt(A_1);
						base.Rows.Insert(A_2, ccustomDataGridViewRow);
						base.CurrentCell = null;
						base.CurrentCell = base.Rows[A_2].Cells[0];
						base.Rows[A_2].Selected = true;
						num3 = 12;
					}
				}
				IL_99:
				IL_1DB:
				this.IsDataLoading = false;
				return;
				IL_201:
				try
				{
					int num2;
					global::System.Windows.Forms.DataGridViewColumn columnByName;
					base.Rows[A_2].Cells[columnByName.Index].Value = num2 + 1;
					int num;
					this.a(num + 1, num2 + 1, A_2);
					return;
				}
				finally
				{
					for (;;)
					{
						IL_17F:
						int num3 = 0;
						for (;;)
						{
							global::custom_controls.CCustomDataGridView.DataLoader dataLoader;
							switch (num3)
							{
							case 1:
								goto IL_1D8;
							case 2:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_17F;
								default:
									if (false)
									{
									}
									((global::System.IDisposable)dataLoader).Dispose();
									num3 = 1;
									continue;
								}
								break;
							}
							if (dataLoader == null)
							{
								goto IL_1DA;
							}
							num3 = 2;
						}
					}
					IL_1D8:
					IL_1DA:;
				}
				goto IL_1DB;
				IL_287:
				this.ResetPosition();
				return;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0001010C File Offset: 0x0000E30C
		private void a(int A_0, int A_1, int A_2)
		{
			for (;;)
			{
				int num = -1;
				int num2 = 22;
				for (;;)
				{
					int num3;
					int num4;
					switch (num2)
					{
					case 0:
						if (num3 != A_2)
						{
							num2 = 12;
							continue;
						}
						goto IL_242;
					case 1:
						num2 = 0;
						continue;
					case 2:
						if (num >= A_1)
						{
							num2 = 23;
							continue;
						}
						goto IL_212;
					case 3:
						num4 = 0;
						num2 = 7;
						continue;
					case 4:
						if (num <= A_1)
						{
							num2 = 1;
							continue;
						}
						goto IL_242;
					case 5:
						if (num4 != A_2)
						{
							num2 = 10;
							continue;
						}
						goto IL_212;
					case 6:
						goto IL_293;
					case 7:
						goto IL_1CE;
					case 8:
						if (num4 >= base.RowCount)
						{
							num2 = 9;
							continue;
						}
						num = (int)base.Rows[num4].Cells[0].Value;
						num2 = 20;
						continue;
					case 9:
						goto IL_1ED;
					case 10:
						base.Rows[num4].Cells[0].Value = num + 1;
						num2 = 19;
						continue;
					case 11:
						goto IL_221;
					case 12:
						if (true)
						{
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_221;
						default:
							if (false)
							{
							}
							base.Rows[num3].Cells[0].Value = num - 1;
							num2 = 24;
							continue;
						}
						break;
					case 13:
						return;
					case 14:
						num2 = 4;
						continue;
					case 15:
						if (num3 >= base.RowCount)
						{
							num2 = 13;
							continue;
						}
						num = (int)base.Rows[num3].Cells[0].Value;
						num2 = 18;
						continue;
					case 16:
						num3 = 0;
						num2 = 6;
						continue;
					case 17:
						if (A_0 > A_1)
						{
							num2 = 3;
							continue;
						}
						return;
					case 18:
						if (num >= A_0)
						{
							num2 = 14;
							continue;
						}
						goto IL_242;
					case 19:
						goto IL_212;
					case 20:
						if (num <= A_0)
						{
							num2 = 25;
							continue;
						}
						goto IL_212;
					case 21:
						goto IL_293;
					case 22:
						if (A_0 < A_1)
						{
							num2 = 16;
							continue;
						}
						num2 = 17;
						continue;
					case 23:
						num2 = 5;
						continue;
					case 24:
						goto IL_242;
					case 25:
						num2 = 2;
						continue;
					}
					break;
					IL_1CE:
					num2 = 8;
					continue;
					IL_221:
					goto IL_1CE;
					IL_212:
					num4++;
					num2 = 11;
					continue;
					IL_242:
					num3++;
					num2 = 21;
					continue;
					IL_293:
					num2 = 15;
				}
			}
			IL_1ED:;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000103F0 File Offset: 0x0000E5F0
		public void LoadRangeForUpDownButton()
		{
			switch (0)
			{
			default:
			{
				string empty = string.Empty;
				global::System.Collections.IEnumerator enumerator = base.Columns.GetEnumerator();
				try
				{
					int num = 5;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (this.GetComboColumnChoices != null)
							{
								num = 8;
								continue;
							}
							break;
						case 1:
							if (this.GetUpdownButtonRange != null)
							{
								num = 14;
								continue;
							}
							break;
						case 2:
						{
							global::System.Collections.ArrayList choices = null;
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							this.GetComboColumnChoices(this, ref choices, dataGridViewColumn.Name, -1, -1, false);
							this.LoadComboColumnChoices(choices, dataGridViewColumn.Index);
							num = 4;
							continue;
						}
						case 3:
							goto IL_1DE;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = 15;
								continue;
							}
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn = (global::System.Windows.Forms.DataGridViewColumn)enumerator.Current;
							num = 9;
							continue;
						}
						case 7:
							num = 0;
							continue;
						case 8:
							num = 12;
							continue;
						case 9:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							if (dataGridViewColumn is global::custom_controls.DataGridViewNumericUpDownColumn)
							{
								num = 11;
								continue;
							}
							num = 13;
							continue;
						}
						case 11:
							num = 1;
							continue;
						case 12:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							if (!dataGridViewColumn.Name.Equals("TRKP_TGLSTEN"))
							{
								num = 2;
								continue;
							}
							goto IL_1D2;
						}
						case 13:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							if (dataGridViewColumn is global::System.Windows.Forms.DataGridViewComboBoxColumn)
							{
								num = 7;
								continue;
							}
							break;
						}
						case 14:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							this.GetUpdownButtonRange(this, ref empty, dataGridViewColumn.Name, -1, -1);
							this.SetRangeForUpdownColumn(empty, dataGridViewColumn.Index);
							num = 10;
							continue;
						}
						case 15:
							goto IL_1D2;
						}
						IL_132:
						num = 6;
						continue;
						goto IL_132;
						IL_1D2:
						num = 3;
					}
					IL_1DE:;
				}
				finally
				{
					for (;;)
					{
						global::System.IDisposable disposable = enumerator as global::System.IDisposable;
						int num;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_222:
							if (disposable == null)
							{
								goto IL_243;
							}
							num = 2;
							break;
						default:
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
								goto IL_222;
							case 1:
								goto IL_241;
							case 2:
								disposable.Dispose();
								num = 1;
								continue;
							}
							break;
						}
					}
					IL_241:
					IL_243:;
				}
				if (true)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00010670 File Offset: 0x0000E870
		public void PopulateGridViewRow(global::System.Xml.XmlNode xnlData, global::System.Drawing.Image image, string channelType, string channelId, string letId, string tag, bool isDataFromRMServer = false)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						global::System.Xml.XmlNode xmlNode = null;
						string text = string.Empty;
						string value = string.Empty;
						global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow = new global::custom_controls.CCustomDataGridViewRow();
						int num = base.Rows.Add(ccustomDataGridViewRow);
						ccustomDataGridViewRow = (global::custom_controls.CCustomDataGridViewRow)base.Rows[num];
						ccustomDataGridViewRow.RowImage = image;
						ccustomDataGridViewRow.Tag = tag;
						ccustomDataGridViewRow.HeaderCell.Tag = tag;
						int num2 = 17;
						for (;;)
						{
							int num3;
							string infinity;
							string text2;
							switch (num2)
							{
							case 0:
								if (base.Columns[num3].Name == "AESPRI_PKEY")
								{
									num2 = 95;
									continue;
								}
								goto IL_761;
							case 1:
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].ReadOnly = global::custom_controls.CCustomDataGridView.a(xmlNode, ((global::custom_controls.DataGridViewCustomTextBoxColumn)base.Columns[num3]).ColumnReadOnly);
								num2 = 19;
								continue;
							case 2:
								if (base.Columns[num3].Name == "RASDATA_RASKEY")
								{
									num2 = 7;
									continue;
								}
								goto IL_982;
							case 3:
								if (xmlNode != null)
								{
									num2 = 63;
									continue;
								}
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].ReadOnly = ((global::System.Windows.Forms.DataGridViewTextBoxColumn)base.Columns[num3]).ReadOnly;
								num2 = 56;
								continue;
							case 4:
								goto IL_481;
							case 5:
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].ReadOnly = global::custom_controls.CCustomDataGridView.a(xmlNode, ((global::custom_controls.DataGridViewNumericUpDownColumn)base.Columns[num3]).ReadOnly);
								num2 = 74;
								continue;
							case 6:
								if (isDataFromRMServer)
								{
									num2 = 32;
									continue;
								}
								value = global::custom_controls.CCustomDataGridView.GetSelectItemTextFromComboColumn(base.Columns[num3], xmlNode.InnerText, text);
								num2 = 94;
								continue;
							case 7:
								num2 = 83;
								continue;
							case 8:
								goto IL_481;
							case 9:
								goto IL_909;
							case 10:
								num2 = 104;
								continue;
							case 11:
								if (base.Columns[num3] is global::custom_controls.DataGridViewNumericUpDownColumn)
								{
									num2 = 65;
									continue;
								}
								num2 = 34;
								continue;
							case 12:
								if (xmlNode.InnerText == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
								{
									num2 = 13;
									continue;
								}
								goto IL_761;
							case 13:
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = "⃠";
								num2 = 47;
								continue;
							case 14:
								if (xmlNode != null)
								{
									num2 = 62;
									continue;
								}
								goto IL_56C;
							case 15:
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = "∞";
								num2 = 28;
								continue;
							case 16:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_A98;
								default:
									if (true)
									{
									}
									if (false)
									{
									}
									num2 = 67;
									continue;
								}
								break;
							case 17:
								if (!string.IsNullOrEmpty(channelType))
								{
									num2 = 80;
									continue;
								}
								ccustomDataGridViewRow.ID = global::custom_controls.CCustomDataGridView.b(xnlData, "ListID");
								ccustomDataGridViewRow.SubID = global::custom_controls.CCustomDataGridView.b(xnlData, "ListLetID");
								num2 = 66;
								continue;
							case 18:
								goto IL_7DF;
							case 19:
								goto IL_247;
							case 20:
								if (base.Columns[num3].Name == "ENHPRI_PKEY")
								{
									num2 = 89;
									continue;
								}
								goto IL_849;
							case 21:
							{
								int num4 = num + 1;
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = num4;
								num2 = 48;
								continue;
							}
							case 22:
								goto IL_A8C;
							case 23:
								if (num3 >= base.Columns.Count)
								{
									num2 = 81;
									continue;
								}
								value = string.Empty;
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Tag = string.Empty;
								xmlNode = xnlData.SelectSingleNode(base.Columns[num3].Name);
								num2 = 101;
								continue;
							case 24:
								goto IL_12D3;
							case 25:
								goto IL_CB9;
							case 26:
								goto IL_A8C;
							case 27:
								text = xmlNode.Attributes["TypeID"].Value;
								num2 = 105;
								continue;
							case 28:
								goto IL_A8C;
							case 29:
								goto IL_B6C;
							case 30:
								ccustomDataGridViewRow.LetID = letId;
								num2 = 79;
								continue;
							case 31:
								if (!string.IsNullOrEmpty(letId))
								{
									num2 = 30;
									continue;
								}
								ccustomDataGridViewRow.LetID = "-1";
								num2 = 29;
								continue;
							case 32:
								value = global::custom_controls.CCustomDataGridView.GetSelectItemTextFromComboColumnByField(base.Columns[num3], xmlNode.InnerText);
								num2 = 76;
								continue;
							case 33:
								goto IL_A8C;
							case 34:
								if (base.Columns[num3] is global::System.Windows.Forms.DataGridViewCheckBoxColumn)
								{
									num2 = 87;
									continue;
								}
								num2 = 49;
								continue;
							case 35:
								if (base.Columns[num3] is global::System.Windows.Forms.DataGridViewTextBoxColumn)
								{
									num2 = 91;
									continue;
								}
								num2 = 11;
								continue;
							case 36:
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].ReadOnly = global::custom_controls.CCustomDataGridView.a(xmlNode, ((global::System.Windows.Forms.DataGridViewCheckBoxColumn)base.Columns[num3]).ReadOnly);
								num2 = 73;
								continue;
							case 37:
								goto IL_12D3;
							case 38:
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Tag = "NA";
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].ReadOnly = true;
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Selected = false;
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Style.BackColor = base.ColumnHeadersDefaultCellStyle.BackColor;
								num2 = 90;
								continue;
							case 39:
							{
								global::System.Collections.ArrayList choices = null;
								global::System.Windows.Forms.DataGridViewComboBoxCell dgvcCell = (global::System.Windows.Forms.DataGridViewComboBoxCell)ccustomDataGridViewRow.Cells[base.Columns[num3].Index];
								this.GetComboColumnChoices(this, ref choices, base.Columns[num3].Name, base.Columns[num3].Index, ccustomDataGridViewRow.Index, true);
								this.LoadComboColumnChoices(choices, ref dgvcCell);
								value = global::custom_controls.CCustomDataGridView.GetSelectItemTextFromComboColumn(dgvcCell, xmlNode.InnerText, text);
								num2 = 25;
								continue;
							}
							case 40:
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].ReadOnly = global::custom_controls.CCustomDataGridView.a(xmlNode, ((global::System.Windows.Forms.DataGridViewComboBoxColumn)base.Columns[num3]).ReadOnly);
								num2 = 18;
								continue;
							case 41:
								num2 = 86;
								continue;
							case 42:
								goto IL_A8C;
							case 43:
								if (xmlNode.Attributes["TypeID"] != null)
								{
									num2 = 27;
									continue;
								}
								goto IL_C7B;
							case 44:
								goto IL_247;
							case 45:
								base[base.Columns[num3].Index, ccustomDataGridViewRow.Index].Selected = false;
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Style.BackColor = base.ColumnHeadersDefaultCellStyle.BackColor;
								num2 = 8;
								continue;
							case 46:
								if (base.Columns[num3].Name == "TRKPAGTGFLELH_AGIDNUM")
								{
									num2 = 71;
									continue;
								}
								goto IL_FA7;
							case 47:
								goto IL_A8C;
							case 48:
								goto IL_A8C;
							case 49:
								if (base.Columns[num3] is global::System.Windows.Forms.DataGridViewComboBoxColumn)
								{
									num2 = 10;
									continue;
								}
								goto IL_A8C;
							case 50:
								goto IL_56C;
							case 51:
								if (xmlNode.InnerText == "FFFFFFFFFF")
								{
									num2 = 103;
									continue;
								}
								goto IL_849;
							case 52:
								goto IL_8BC;
							case 53:
								if (xmlNode.ChildNodes.Count > 0)
								{
									num2 = 69;
									continue;
								}
								goto IL_56C;
							case 54:
								if (base.Columns[num3] is global::custom_controls.DataGridViewCustomTextBoxColumn)
								{
									num2 = 57;
									continue;
								}
								num2 = 35;
								continue;
							case 55:
								goto IL_481;
							case 56:
								goto IL_D7D;
							case 57:
								num2 = 96;
								continue;
							case 58:
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = num;
								num2 = 92;
								continue;
							case 59:
								goto IL_A8C;
							case 60:
								if (this.ag != null)
								{
									num2 = 93;
									continue;
								}
								goto IL_5FC;
							case 61:
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = "⃠";
								num2 = 99;
								continue;
							case 62:
								num2 = 53;
								continue;
							case 63:
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].ReadOnly = global::custom_controls.CCustomDataGridView.a(xmlNode, ((global::System.Windows.Forms.DataGridViewTextBoxColumn)base.Columns[num3]).ReadOnly);
								num2 = 107;
								continue;
							case 64:
								if ("POSITION" == base.Columns[num3].Name)
								{
									num2 = 21;
									continue;
								}
								num2 = 20;
								continue;
							case 65:
								num2 = 85;
								continue;
							case 66:
								goto IL_909;
							case 67:
								if (double.Parse(infinity, global::System.Globalization.CultureInfo.InvariantCulture) == double.Parse(value, global::System.Globalization.CultureInfo.InvariantCulture))
								{
									num2 = 15;
									continue;
								}
								goto IL_37B;
							case 68:
								if (xmlNode != null)
								{
									num2 = 36;
									continue;
								}
								goto IL_303;
							case 69:
								base.Columns[num3].DefaultCellStyle = base.Columns[num3].DefaultCellStyle;
								value = xmlNode.InnerText.ToString();
								num2 = 50;
								continue;
							case 70:
								goto IL_A8C;
							case 71:
								num2 = 97;
								continue;
							case 72:
								text2 = "NA";
								num2 = 60;
								continue;
							case 73:
								goto IL_303;
							case 74:
								goto IL_8BC;
							case 75:
								goto IL_5FC;
							case 76:
								goto IL_CB9;
							case 77:
								if (xmlNode.Attributes["Applicable"] != null)
								{
									num2 = 41;
									continue;
								}
								goto IL_10F9;
							case 78:
								goto IL_A8C;
							case 79:
								goto IL_B6C;
							case 80:
								ccustomDataGridViewRow.ID = global::custom_controls.CCustomDataGridView.b(xnlData, "ListID");
								ccustomDataGridViewRow.SubID = "-1";
								ccustomDataGridViewRow.Type = channelType;
								num2 = 9;
								continue;
							case 81:
								num2 = 102;
								continue;
							case 82:
								if ("PGK_HEADER" == base.Columns[num3].Name)
								{
									num2 = 58;
									continue;
								}
								value = ((global::custom_controls.DataGridViewCustomTextBoxCell)ccustomDataGridViewRow.Cells[base.Columns[num3].Index]).GetFormattedText(value);
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = value;
								num2 = 78;
								continue;
							case 83:
								if (xmlNode.InnerText == "0")
								{
									num2 = 61;
									continue;
								}
								goto IL_982;
							case 84:
								if (base.Columns[num3].Name.Equals("TRKP_TGLSTEN"))
								{
									num2 = 39;
									continue;
								}
								num2 = 6;
								continue;
							case 85:
								if (xmlNode != null)
								{
									num2 = 5;
									continue;
								}
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].ReadOnly = ((global::custom_controls.DataGridViewNumericUpDownColumn)base.Columns[num3]).ReadOnly;
								num2 = 52;
								continue;
							case 86:
								if (xmlNode.Attributes["Applicable"].Value == "NA")
								{
									num2 = 72;
									continue;
								}
								goto IL_10F9;
							case 87:
								num2 = 68;
								continue;
							case 88:
								if (infinity != null)
								{
									num2 = 16;
									continue;
								}
								goto IL_37B;
							case 89:
								num2 = 51;
								continue;
							case 90:
								goto IL_481;
							case 91:
								num2 = 3;
								continue;
							case 92:
								goto IL_A8C;
							case 93:
								this.ag("NOT_APPLICABLE", ref text2);
								num2 = 75;
								continue;
							case 94:
								goto IL_CB9;
							case 95:
								num2 = 12;
								continue;
							case 96:
								if (xmlNode != null)
								{
									num2 = 1;
									continue;
								}
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].ReadOnly = ((global::custom_controls.DataGridViewCustomTextBoxColumn)base.Columns[num3]).ColumnReadOnly;
								num2 = 44;
								continue;
							case 97:
								if (value == "FFF")
								{
									num2 = 106;
									continue;
								}
								goto IL_FA7;
							case 98:
								num2 = 77;
								continue;
							case 99:
								goto IL_A8C;
							case 100:
								goto IL_A98;
							case 101:
								if (!global::custom_controls.CCustomDataGridView.a(xmlNode, base.Columns[num3].Name))
								{
									num2 = 38;
									continue;
								}
								num2 = 14;
								continue;
							case 102:
								goto IL_1372;
							case 103:
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = "⃠";
								num2 = 22;
								continue;
							case 104:
								if (xmlNode != null)
								{
									num2 = 98;
									continue;
								}
								goto IL_10F9;
							case 105:
								goto IL_C7B;
							case 106:
							{
								string value2 = null;
								this.ag("NONE", ref value2);
								ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = value2;
								num2 = 70;
								continue;
							}
							case 107:
								goto IL_D7D;
							case 108:
								if (xmlNode != null)
								{
									num2 = 40;
									continue;
								}
								goto IL_7DF;
							}
							break;
							IL_247:
							num2 = 64;
							continue;
							IL_303:
							ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = global::System.Convert.ToBoolean(global::System.Convert.ToInt16(xmlNode.InnerText, global::System.Globalization.CultureInfo.InvariantCulture));
							num2 = 42;
							continue;
							IL_37B:
							num2 = 46;
							continue;
							IL_481:
							num3++;
							num2 = 37;
							continue;
							IL_56C:
							num2 = 54;
							continue;
							IL_5FC:
							global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
							arrayList.Add(new global::custom_controls.CCustomDataGridView.ComboItem(text2, text2, text2));
							((global::System.Windows.Forms.DataGridViewComboBoxCell)ccustomDataGridViewRow.Cells[base.Columns[num3].Index]).DataSource = arrayList;
							ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = text2;
							ccustomDataGridViewRow.Cells[base.Columns[num3].Index].ReadOnly = true;
							num2 = 55;
							continue;
							IL_761:
							num2 = 2;
							continue;
							IL_7DF:
							text = string.Empty;
							num2 = 43;
							continue;
							IL_849:
							num2 = 0;
							continue;
							IL_8BC:
							infinity = ((global::custom_controls.DataGridViewNumericUpDownCell)ccustomDataGridViewRow.Cells[base.Columns[num3].Index]).Infinity;
							num2 = 88;
							continue;
							IL_909:
							num2 = 31;
							continue;
							IL_982:
							num2 = 82;
							continue;
							IL_A8C:
							num2 = 100;
							continue;
							IL_A98:
							if (ccustomDataGridViewRow.Cells[base.Columns[num3].Index].ReadOnly)
							{
								num2 = 45;
								continue;
							}
							ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Style.BackColor = global::System.Drawing.Color.White;
							num2 = 4;
							continue;
							IL_B6C:
							num3 = 0;
							num2 = 24;
							continue;
							IL_C7B:
							num2 = 84;
							continue;
							IL_CB9:
							ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Tag = text;
							ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = value;
							num2 = 59;
							continue;
							IL_D7D:
							ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = xmlNode.InnerText;
							num2 = 33;
							continue;
							IL_FA7:
							value = ((global::custom_controls.DataGridViewNumericUpDownCell)ccustomDataGridViewRow.Cells[base.Columns[num3].Index]).GetFormattedText(value);
							ccustomDataGridViewRow.Cells[base.Columns[num3].Index].Value = value;
							num2 = 26;
							continue;
							IL_10F9:
							num2 = 108;
							continue;
							IL_12D3:
							num2 = 23;
						}
					}
					IL_1372:
					break;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::custom_exception.CCustomException.Rethrow(ex);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00011A40 File Offset: 0x0000FC40
		public void ResetCellValuesInRow(string xmlRowData, int curRowIndex, bool isDataFromRMServer = false)
		{
			try
			{
				switch (0)
				{
				default:
				{
					string value = string.Empty;
					global::System.Xml.XmlNode xmlNode = null;
					global::System.Xml.XmlNodeList xmlNodeList = null;
					global::System.Windows.Forms.DataGridViewComboBoxCell dgvcCell = null;
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.LoadXml(xmlRowData);
					global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow = (global::custom_controls.CCustomDataGridViewRow)base.Rows[curRowIndex];
					global::custom_controls.CCustomDataGridView.DataLoader dataLoader = new global::custom_controls.CCustomDataGridView.DataLoader(this);
					try
					{
						global::System.Collections.IEnumerator enumerator = base.Columns.GetEnumerator();
						try
						{
							int num = 65;
							for (;;)
							{
								global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
								int num2;
								string text;
								string text2;
								switch (num)
								{
								case 0:
									if (xmlNode != null)
									{
										num = 6;
										continue;
									}
									goto IL_39A;
								case 1:
									goto IL_809;
								case 2:
									goto IL_63F;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = 8;
										continue;
									}
									dataGridViewColumn = (global::System.Windows.Forms.DataGridViewColumn)enumerator.Current;
									xmlNodeList = xmlDocument.DocumentElement.SelectNodes("//" + dataGridViewColumn.Name);
									num = 10;
									continue;
								case 4:
									goto IL_E34;
								case 5:
									if (((global::custom_controls.DataGridViewCustomTextBoxColumn)dataGridViewColumn).ColumnReadOnly)
									{
										num = 84;
										continue;
									}
									goto IL_EF8;
								case 6:
									num = 58;
									continue;
								case 7:
									if (dataGridViewColumn.Name == "RASDATA_RASKEY")
									{
										num = 67;
										continue;
									}
									goto IL_ADC;
								case 8:
									num = 61;
									continue;
								case 9:
									if (xmlNode.InnerText == "0")
									{
										num = 50;
										continue;
									}
									goto IL_54A;
								case 10:
									if (xmlNodeList.Count <= 0)
									{
										num = 36;
										continue;
									}
									num2 = 0;
									num = 81;
									continue;
								case 11:
									num = 15;
									continue;
								case 12:
									num = 5;
									continue;
								case 13:
									goto IL_57D;
								case 14:
									if (base[dataGridViewColumn.Index, curRowIndex].IsInEditMode)
									{
										num = 62;
										continue;
									}
									goto IL_809;
								case 15:
									if (xmlNode.InnerText == "FFF")
									{
										num = 52;
										continue;
									}
									goto IL_D93;
								case 16:
									goto IL_E34;
								case 18:
								{
									string infinity;
									if (infinity != null)
									{
										num = 75;
										continue;
									}
									goto IL_312;
								}
								case 19:
									if (dataGridViewColumn is global::System.Windows.Forms.DataGridViewCheckBoxColumn)
									{
										num = 96;
										continue;
									}
									num = 45;
									continue;
								case 20:
								{
									global::System.Windows.Forms.DataGridViewComboBoxEditingControl dataGridViewComboBoxEditingControl = base.EditingControl as global::System.Windows.Forms.DataGridViewComboBoxEditingControl;
									dataGridViewComboBoxEditingControl.EditingControlFormattedValue = base[dataGridViewColumn.Index, curRowIndex].Value;
									num = 28;
									continue;
								}
								case 21:
									if (dataGridViewColumn.Name == "ENHPRI_PKEY")
									{
										num = 88;
										continue;
									}
									goto IL_989;
								case 23:
									if (dataGridViewColumn.Name == "AESPRI_PKEY")
									{
										num = 51;
										continue;
									}
									goto IL_EAF;
								case 24:
									if (dataGridViewColumn.Name == "RASDATA_RASKEY")
									{
										num = 94;
										continue;
									}
									goto IL_54A;
								case 25:
									if (!dataGridViewColumn.Name.Equals("ENHPRI_PKEYALIAS"))
									{
										num = 27;
										continue;
									}
									goto IL_63F;
								case 26:
									if (!xmlNode.Attributes["Applicable"].Value.Equals("Disabled"))
									{
										num = 43;
										continue;
									}
									goto IL_432;
								case 27:
									num = 54;
									continue;
								case 28:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_C08;
									default:
										if (false)
										{
										}
										goto IL_809;
									}
									break;
								case 29:
									base[dataGridViewColumn.Index, curRowIndex].Value = "⃠";
									num = 99;
									continue;
								case 30:
									goto IL_432;
								case 31:
									if (dataGridViewColumn is global::custom_controls.DataGridViewCustomTextBoxColumn)
									{
										num = 71;
										continue;
									}
									base[dataGridViewColumn.Index, curRowIndex].Tag = string.Empty;
									base[dataGridViewColumn.Index, curRowIndex].ReadOnly = global::custom_controls.CCustomDataGridView.a(xmlNode, false);
									num = 21;
									continue;
								case 32:
									num = 25;
									continue;
								case 33:
									if (dataGridViewColumn is global::System.Windows.Forms.DataGridViewComboBoxColumn)
									{
										num = 59;
										continue;
									}
									num = 19;
									continue;
								case 34:
									if (dataGridViewColumn.Name == "TRKPAGTGFLELH_AGIDNUM")
									{
										num = 11;
										continue;
									}
									goto IL_D93;
								case 35:
									if (this.ag != null)
									{
										num = 44;
										continue;
									}
									goto IL_B95;
								case 36:
									num = 55;
									continue;
								case 37:
									goto IL_FA9;
								case 38:
									goto IL_809;
								case 39:
								{
									string infinity;
									if (double.Parse(infinity, global::System.Globalization.CultureInfo.InvariantCulture) == double.Parse(xmlNode.InnerText, global::System.Globalization.CultureInfo.InvariantCulture))
									{
										num = 40;
										continue;
									}
									goto IL_312;
								}
								case 40:
									base[dataGridViewColumn.Index, curRowIndex].Value = "∞";
									num = 53;
									continue;
								case 41:
								{
									text = string.Empty;
									global::System.Collections.ArrayList choices = null;
									this.GetComboColumnChoices(this, ref choices, dataGridViewColumn.Name, dataGridViewColumn.Index, curRowIndex, true);
									this.LoadComboColumnChoices(choices, ref dgvcCell);
									num = 89;
									continue;
								}
								case 42:
									goto IL_809;
								case 43:
									num = 102;
									continue;
								case 44:
									this.ag("NOT_APPLICABLE", ref text2);
									num = 85;
									continue;
								case 45:
									if (dataGridViewColumn is global::custom_controls.DataGridViewNumericUpDownColumn)
									{
										num = 90;
										continue;
									}
									num = 31;
									continue;
								case 46:
									if (dataGridViewColumn is global::custom_controls.DataGridViewCustomTextBoxColumn)
									{
										num = 12;
										continue;
									}
									goto IL_EF8;
								case 47:
									goto IL_E34;
								case 48:
									num = 70;
									continue;
								case 49:
									base[dataGridViewColumn.Index, curRowIndex].Value = "⃠";
									num = 97;
									continue;
								case 50:
									goto IL_C08;
								case 51:
									num = 73;
									continue;
								case 52:
								{
									string value2 = null;
									this.ag("NONE", ref value2);
									base[dataGridViewColumn.Index, curRowIndex].Value = value2;
									num = 95;
									continue;
								}
								case 53:
									goto IL_D5E;
								case 54:
									if (dataGridViewColumn.Name.Equals("AESPRI_PKEYALIAS"))
									{
										num = 2;
										continue;
									}
									goto IL_60C;
								case 55:
									if (!dataGridViewColumn.Name.Equals("POSITION"))
									{
										num = 92;
										continue;
									}
									break;
								case 56:
									if (xmlNode.Attributes["Applicable"].Value == "NA")
									{
										num = 77;
										continue;
									}
									goto IL_39A;
								case 57:
									base[dataGridViewColumn.Index, curRowIndex].Value = "⃠";
									num = 93;
									continue;
								case 58:
									if (xmlNode.Attributes["Applicable"] != null)
									{
										num = 87;
										continue;
									}
									goto IL_39A;
								case 59:
									num = 0;
									continue;
								case 60:
									goto IL_809;
								case 61:
									goto IL_1010;
								case 62:
								{
									global::custom_controls.DataGridViewCustTextBoxEditingControl dataGridViewCustTextBoxEditingControl = base.EditingControl as global::custom_controls.DataGridViewCustTextBoxEditingControl;
									dataGridViewCustTextBoxEditingControl.EditingControlFormattedValue = base[dataGridViewColumn.Index, curRowIndex].Value;
									num = 38;
									continue;
								}
								case 63:
									text = xmlNode.Attributes["TypeID"].Value;
									num = 68;
									continue;
								case 64:
									if (isDataFromRMServer)
									{
										num = 32;
										continue;
									}
									goto IL_60C;
								case 66:
									goto IL_D5E;
								case 67:
									num = 86;
									continue;
								case 68:
									goto IL_26F;
								case 69:
									goto IL_57D;
								case 70:
									if (xmlNode.InnerText == "FFFFFFFFFF")
									{
										num = 49;
										continue;
									}
									goto IL_23C;
								case 71:
									base[dataGridViewColumn.Index, curRowIndex].Tag = string.Empty;
									base[dataGridViewColumn.Index, curRowIndex].ReadOnly = global::custom_controls.CCustomDataGridView.a(xmlNode, false);
									num = 74;
									continue;
								case 72:
									goto IL_2E8;
								case 73:
									if (xmlNode.InnerText == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
									{
										num = 29;
										continue;
									}
									goto IL_EAF;
								case 74:
									if (dataGridViewColumn.Name == "ENHPRI_PKEY")
									{
										num = 48;
										continue;
									}
									goto IL_23C;
								case 75:
									num = 39;
									continue;
								case 76:
									goto IL_809;
								case 77:
									text2 = "NA";
									num = 35;
									continue;
								case 78:
									goto IL_FA9;
								case 79:
									if (xmlNode.InnerText == "FFFFFFFFFF")
									{
										num = 100;
										continue;
									}
									goto IL_989;
								case 80:
								{
									global::custom_controls.DataGridViewNumericUpDownEditingControl dataGridViewNumericUpDownEditingControl = base.EditingControl as global::custom_controls.DataGridViewNumericUpDownEditingControl;
									dataGridViewNumericUpDownEditingControl.EditingControlFormattedValue = base[dataGridViewColumn.Index, curRowIndex].Value;
									num = 42;
									continue;
								}
								case 81:
									goto IL_2E8;
								case 82:
									if (base[dataGridViewColumn.Index, curRowIndex].IsInEditMode)
									{
										num = 20;
										continue;
									}
									goto IL_809;
								case 83:
									if (this.GetComboColumnChoices != null)
									{
										num = 41;
										continue;
									}
									goto IL_809;
								case 84:
									base[dataGridViewColumn.Index, curRowIndex].ReadOnly = true;
									base[dataGridViewColumn.Index, curRowIndex].Style.BackColor = base.ColumnHeadersDefaultCellStyle.BackColor;
									num = 16;
									continue;
								case 85:
									goto IL_B95;
								case 86:
									if (xmlNode.InnerText == "0")
									{
										num = 57;
										continue;
									}
									goto IL_ADC;
								case 87:
									num = 56;
									continue;
								case 88:
									num = 79;
									continue;
								case 89:
									if (xmlNode.Attributes["TypeID"] != null)
									{
										num = 63;
										continue;
									}
									goto IL_26F;
								case 90:
								{
									ccustomDataGridViewRow.Cells[dataGridViewColumn.Index].ReadOnly = global::custom_controls.CCustomDataGridView.a(xmlNode, false);
									base[dataGridViewColumn.Index, curRowIndex].Tag = string.Empty;
									string infinity = ((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).Infinity;
									num = 18;
									continue;
								}
								case 91:
									if (num2 >= xmlNodeList.Count)
									{
										num = 22;
										continue;
									}
									xmlNode = xmlNodeList[num2];
									num = 33;
									continue;
								case 92:
									base[dataGridViewColumn.Index, curRowIndex].ReadOnly = true;
									base[dataGridViewColumn.Index, curRowIndex].Style.BackColor = base.ColumnHeadersDefaultCellStyle.BackColor;
									num = 101;
									continue;
								case 93:
									goto IL_809;
								case 94:
									num = 9;
									continue;
								case 95:
									goto IL_D5E;
								case 96:
									base[dataGridViewColumn.Index, curRowIndex].Tag = string.Empty;
									base[dataGridViewColumn.Index, curRowIndex].ReadOnly = global::custom_controls.CCustomDataGridView.a(xmlNode, false);
									base[dataGridViewColumn.Index, curRowIndex].Value = global::System.Convert.ToBoolean(global::System.Convert.ToInt16(xmlNode.InnerText, global::System.Globalization.CultureInfo.InvariantCulture));
									num = 1;
									continue;
								case 97:
									goto IL_FA9;
								case 98:
									if (base[dataGridViewColumn.Index, curRowIndex].IsInEditMode)
									{
										num = 80;
										continue;
									}
									goto IL_809;
								case 99:
									goto IL_FA9;
								case 100:
									base[dataGridViewColumn.Index, curRowIndex].Value = "⃠";
									num = 60;
									continue;
								case 102:
									if (xmlNode.Attributes["Applicable"].Value.Equals("NA"))
									{
										num = 30;
										continue;
									}
									num = 46;
									continue;
								}
								goto IL_20E;
								IL_23C:
								num = 24;
								continue;
								IL_26F:
								base[dataGridViewColumn.Index, curRowIndex].Tag = text;
								num = 64;
								continue;
								IL_2E8:
								num = 91;
								continue;
								IL_312:
								num = 34;
								continue;
								IL_39A:
								dgvcCell = (global::System.Windows.Forms.DataGridViewComboBoxCell)ccustomDataGridViewRow.Cells[dataGridViewColumn.Index];
								num = 83;
								continue;
								IL_432:
								base[dataGridViewColumn.Index, curRowIndex].ReadOnly = true;
								base[dataGridViewColumn.Index, curRowIndex].Style.BackColor = base.ColumnHeadersDefaultCellStyle.BackColor;
								num = 4;
								continue;
								IL_54A:
								num = 23;
								continue;
								IL_57D:
								num = 82;
								continue;
								IL_60C:
								base[dataGridViewColumn.Index, curRowIndex].Value = global::custom_controls.CCustomDataGridView.GetSelectItemTextFromComboColumn(dgvcCell, xmlNode.InnerText, text);
								num = 13;
								continue;
								IL_63F:
								base[dataGridViewColumn.Index, curRowIndex].Value = global::custom_controls.CCustomDataGridView.GetSelectItemTextFromComboColumnByField(dgvcCell, xmlNode.InnerText);
								num = 69;
								continue;
								IL_809:
								num = 26;
								continue;
								IL_989:
								num = 7;
								continue;
								IL_ADC:
								base[dataGridViewColumn.Index, curRowIndex].Value = xmlNode.InnerText;
								num = 76;
								continue;
								IL_B95:
								global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
								arrayList.Add(new global::custom_controls.CCustomDataGridView.ComboItem(text2, text2, text2));
								((global::System.Windows.Forms.DataGridViewComboBoxCell)base[dataGridViewColumn.Index, curRowIndex]).DataSource = arrayList;
								base[dataGridViewColumn.Index, curRowIndex].Value = text2;
								base[dataGridViewColumn.Index, curRowIndex].ReadOnly = true;
								num = 17;
								continue;
								IL_C08:
								base[dataGridViewColumn.Index, curRowIndex].Value = "⃠";
								num = 37;
								continue;
								IL_D5E:
								num = 98;
								continue;
								IL_D93:
								value = ((global::custom_controls.DataGridViewNumericUpDownCell)ccustomDataGridViewRow.Cells[dataGridViewColumn.Index]).GetFormattedText(xmlNode.InnerText);
								base[dataGridViewColumn.Index, curRowIndex].Value = value;
								num = 66;
								continue;
								IL_E34:
								num2++;
								num = 72;
								continue;
								IL_EAF:
								value = ((global::custom_controls.DataGridViewCustomTextBoxCell)ccustomDataGridViewRow.Cells[dataGridViewColumn.Index]).GetFormattedText(xmlNode.InnerText);
								base[dataGridViewColumn.Index, curRowIndex].Value = value;
								num = 78;
								continue;
								IL_EF8:
								base[dataGridViewColumn.Index, curRowIndex].ReadOnly = false;
								base[dataGridViewColumn.Index, curRowIndex].Style.BackColor = global::System.Drawing.SystemColors.Window;
								num = 47;
								continue;
								IL_FA9:
								num = 14;
								continue;
								IL_FDE:
								num = 3;
								continue;
								IL_20E:
								goto IL_FDE;
							}
							IL_1010:;
						}
						finally
						{
							for (;;)
							{
								global::System.IDisposable disposable = enumerator as global::System.IDisposable;
								int num = 2;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_1058;
									case 1:
										disposable.Dispose();
										num = 0;
										continue;
									case 2:
										if (disposable != null)
										{
											num = 1;
											continue;
										}
										goto IL_105A;
									}
									break;
								}
							}
							IL_1058:
							IL_105A:;
						}
					}
					finally
					{
						int num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								((global::System.IDisposable)dataLoader).Dispose();
								num = 1;
								continue;
							case 1:
								goto IL_109A;
							}
							if (dataLoader == null)
							{
								break;
							}
							num = 0;
						}
						IL_109A:;
					}
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00012B70 File Offset: 0x00010D70
		public void ResetCellValuesInRow(string activeFieldid, string xmlRowData, int columnIndex, int curRowIndex, bool isDataFromRMServer = false)
		{
			try
			{
				for (;;)
				{
					switch (0)
					{
					default:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_24;
						}
						break;
					}
				}
				IL_24:
				if (false)
				{
				}
				int num = -1;
				string value = string.Empty;
				global::System.Xml.XmlNode xmlNode = null;
				global::System.Xml.XmlNodeList xmlNodeList = null;
				global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow = null;
				global::System.Windows.Forms.DataGridViewComboBoxCell dataGridViewComboBoxCell = null;
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.LoadXml(xmlRowData);
				global::custom_controls.CCustomDataGridView.DataLoader dataLoader = new global::custom_controls.CCustomDataGridView.DataLoader(this);
				try
				{
					global::System.Collections.IEnumerator enumerator = base.Columns.GetEnumerator();
					try
					{
						int num2 = 115;
						for (;;)
						{
							string text;
							string value2;
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							string value3;
							int num3;
							string text2;
							switch (num2)
							{
							case 0:
							{
								text = string.Empty;
								global::System.Collections.ArrayList choices = null;
								num2 = 7;
								continue;
							}
							case 1:
								goto IL_2D9;
							case 2:
								if (xmlNode.Attributes["ListLetID"] != null)
								{
									num2 = 112;
									continue;
								}
								value2 = "-1";
								num2 = 59;
								continue;
							case 3:
								goto IL_2D9;
							case 4:
								goto IL_1157;
							case 5:
								num2 = 62;
								continue;
							case 6:
								goto IL_31A;
							case 7:
								if (!activeFieldid.Equals(dataGridViewColumn.Name))
								{
									num2 = 104;
									continue;
								}
								num2 = 56;
								continue;
							case 8:
								if (!enumerator.MoveNext())
								{
									num2 = 105;
									continue;
								}
								dataGridViewColumn = (global::System.Windows.Forms.DataGridViewColumn)enumerator.Current;
								value3 = string.Empty;
								value2 = string.Empty;
								xmlNodeList = xmlDocument.DocumentElement.SelectNodes("//" + dataGridViewColumn.Name);
								num3 = 0;
								num2 = 18;
								continue;
							case 9:
								goto IL_FB3;
							case 10:
								base[dataGridViewColumn.Index, num].Value = "∞";
								num2 = 71;
								continue;
							case 11:
								base[dataGridViewColumn.Index, num].Value = "⃠";
								num2 = 3;
								continue;
							case 12:
								if (xmlNode.InnerText == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
								{
									num2 = 25;
									continue;
								}
								goto IL_E54;
							case 13:
								num2 = 99;
								continue;
							case 14:
								goto IL_594;
							case 15:
								goto IL_10BF;
							case 16:
								goto IL_D36;
							case 17:
								if (dataGridViewColumn is global::System.Windows.Forms.DataGridViewComboBoxColumn)
								{
									num2 = 91;
									continue;
								}
								num2 = 61;
								continue;
							case 18:
								goto IL_31A;
							case 19:
								num2 = 78;
								continue;
							case 20:
								if (xmlNode.Attributes["Applicable"].Value.Equals("NA"))
								{
									num2 = 92;
									continue;
								}
								num2 = 36;
								continue;
							case 21:
								if (xmlNode.Attributes["TypeID"] != null)
								{
									num2 = 74;
									continue;
								}
								goto IL_594;
							case 22:
								if (dataGridViewColumn.Name == "ENHPRI_PKEY")
								{
									num2 = 81;
									continue;
								}
								goto IL_942;
							case 23:
								base[dataGridViewColumn.Index, num].ReadOnly = global::custom_controls.CCustomDataGridView.a(xmlNode, false);
								base[dataGridViewColumn.Index, num].Value = global::System.Convert.ToBoolean(global::System.Convert.ToInt16(xmlNode.InnerText, global::System.Globalization.CultureInfo.InvariantCulture));
								num2 = 28;
								continue;
							case 24:
								text2 = "NA";
								num2 = 103;
								continue;
							case 25:
								base[dataGridViewColumn.Index, num].Value = "⃠";
								num2 = 45;
								continue;
							case 26:
								if (xmlNode != null)
								{
									num2 = 13;
									continue;
								}
								goto IL_5CD;
							case 27:
								goto IL_F67;
							case 28:
								goto IL_2D9;
							case 29:
								if (xmlNode.InnerText == "0")
								{
									num2 = 42;
									continue;
								}
								goto IL_60F;
							case 30:
								if (dataGridViewColumn.Name == "AESPRI_PKEY")
								{
									num2 = 69;
									continue;
								}
								goto IL_826;
							case 31:
								if (dataGridViewColumn is global::custom_controls.DataGridViewCustomTextBoxColumn)
								{
									num2 = 50;
									continue;
								}
								base[dataGridViewColumn.Index, num].ReadOnly = global::custom_controls.CCustomDataGridView.a(xmlNode, false);
								num2 = 22;
								continue;
							case 32:
								goto IL_2D9;
							case 33:
								if (xmlNode.InnerText == "FFFFFFFFFF")
								{
									num2 = 48;
									continue;
								}
								goto IL_CA1;
							case 34:
								base[dataGridViewColumn.Index, num].ReadOnly = true;
								base[dataGridViewColumn.Index, num].Style.BackColor = base.ColumnHeadersDefaultCellStyle.BackColor;
								num2 = 75;
								continue;
							case 36:
								if (dataGridViewColumn is global::custom_controls.DataGridViewCustomTextBoxColumn)
								{
									num2 = 66;
									continue;
								}
								goto IL_D94;
							case 37:
								if (num <= base.Rows.Count - 1)
								{
									num2 = 41;
									continue;
								}
								goto IL_107F;
							case 38:
								this.ag("NOT_APPLICABLE", ref text2);
								num2 = 88;
								continue;
							case 39:
								goto IL_10BF;
							case 40:
								goto IL_2D9;
							case 41:
								ccustomDataGridViewRow = (global::custom_controls.CCustomDataGridViewRow)base.Rows[num];
								num2 = 17;
								continue;
							case 42:
								base[dataGridViewColumn.Index, num].Value = "⃠";
								num2 = 40;
								continue;
							case 43:
								if (base[dataGridViewColumn.Index, num].IsInEditMode)
								{
									num2 = 114;
									continue;
								}
								goto IL_2D9;
							case 44:
								if (!xmlNode.Attributes["Applicable"].Value.Equals("Disabled"))
								{
									num2 = 97;
									continue;
								}
								goto IL_AE0;
							case 45:
								goto IL_10BF;
							case 46:
							{
								string value4 = null;
								this.ag("NONE", ref value4);
								base[dataGridViewColumn.Index, num].Value = value4;
								num2 = 16;
								continue;
							}
							case 47:
								base[dataGridViewColumn.Index, num].Value = "⃠";
								num2 = 15;
								continue;
							case 48:
								base[dataGridViewColumn.Index, num].Value = "⃠";
								num2 = 39;
								continue;
							case 49:
								if (dataGridViewColumn.Name == "ENHPRI_PKEY")
								{
									num2 = 77;
									continue;
								}
								goto IL_CA1;
							case 50:
								base[dataGridViewColumn.Index, num].ReadOnly = global::custom_controls.CCustomDataGridView.a(xmlNode, false);
								num2 = 49;
								continue;
							case 51:
								if (dataGridViewColumn.Name == "AESPRI_PKEY")
								{
									num2 = 109;
									continue;
								}
								goto IL_E54;
							case 52:
								goto IL_2D9;
							case 53:
								goto IL_107F;
							case 54:
								if (dataGridViewColumn is global::custom_controls.DataGridViewNumericUpDownColumn)
								{
									num2 = 90;
									continue;
								}
								num2 = 31;
								continue;
							case 55:
								goto IL_975;
							case 56:
								if (!dataGridViewComboBoxCell.IsInEditMode)
								{
									num2 = 110;
									continue;
								}
								goto IL_8DE;
							case 57:
								num2 = 93;
								continue;
							case 58:
								goto IL_D36;
							case 59:
								goto IL_975;
							case 60:
								if (xmlNode.InnerText == "FFFFFFFFFF")
								{
									num2 = 95;
									continue;
								}
								goto IL_942;
							case 61:
								if (dataGridViewColumn is global::System.Windows.Forms.DataGridViewCheckBoxColumn)
								{
									num2 = 23;
									continue;
								}
								num2 = 54;
								continue;
							case 62:
								if (xmlNode.InnerText == "0")
								{
									num2 = 47;
									continue;
								}
								goto IL_561;
							case 63:
								if (isDataFromRMServer)
								{
									num2 = 106;
									continue;
								}
								base[dataGridViewColumn.Index, num].Value = global::custom_controls.CCustomDataGridView.GetSelectItemTextFromComboColumn(dataGridViewComboBoxCell, xmlNode.InnerText, text);
								num2 = 9;
								continue;
							case 64:
								if (xmlNode.InnerText == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")
								{
									num2 = 11;
									continue;
								}
								goto IL_826;
							case 65:
							{
								string infinity;
								if (infinity != null)
								{
									num2 = 19;
									continue;
								}
								goto IL_D06;
							}
							case 66:
								num2 = 108;
								continue;
							case 67:
								num2 = 85;
								continue;
							case 68:
								if (base[dataGridViewColumn.Index, num].IsInEditMode)
								{
									num2 = 73;
									continue;
								}
								goto IL_2D9;
							case 69:
								num2 = 64;
								continue;
							case 70:
								goto IL_2D9;
							case 71:
								goto IL_D36;
							case 72:
								num2 = 37;
								continue;
							case 73:
							{
								global::System.Windows.Forms.DataGridViewComboBoxEditingControl dataGridViewComboBoxEditingControl = base.EditingControl as global::System.Windows.Forms.DataGridViewComboBoxEditingControl;
								dataGridViewComboBoxEditingControl.EditingControlFormattedValue = base[dataGridViewColumn.Index, num].Value;
								num2 = 32;
								continue;
							}
							case 74:
								text = xmlNode.Attributes["TypeID"].Value;
								num2 = 14;
								continue;
							case 75:
								goto IL_107F;
							case 76:
								if (num3 >= xmlNodeList.Count)
								{
									num2 = 83;
									continue;
								}
								num = -1;
								xmlNode = xmlNodeList[num3];
								num2 = 86;
								continue;
							case 77:
								num2 = 33;
								continue;
							case 78:
							{
								string infinity;
								if (double.Parse(infinity, global::System.Globalization.CultureInfo.InvariantCulture) == double.Parse(xmlNode.InnerText, global::System.Globalization.CultureInfo.InvariantCulture))
								{
									num2 = 10;
									continue;
								}
								goto IL_D06;
							}
							case 79:
								goto IL_10BF;
							case 80:
								if (base[dataGridViewColumn.Index, num].IsInEditMode)
								{
									num2 = 94;
									continue;
								}
								goto IL_2D9;
							case 81:
								num2 = 60;
								continue;
							case 82:
								goto IL_2D9;
							case 84:
								if (dataGridViewColumn.Name == "RASDATA_RASKEY")
								{
									num2 = 101;
									continue;
								}
								goto IL_60F;
							case 85:
								if (xmlNode.InnerText == "FFF")
								{
									num2 = 46;
									continue;
								}
								goto IL_74A;
							case 86:
								if (xmlNode.Attributes["ListID"] != null)
								{
									num2 = 100;
									continue;
								}
								goto IL_F67;
							case 87:
								goto IL_107F;
							case 88:
								goto IL_B3C;
							case 89:
								if (dataGridViewColumn.Name == "TRKPAGTGFLELH_AGIDNUM")
								{
									num2 = 67;
									continue;
								}
								goto IL_74A;
							case 90:
							{
								string infinity = ((global::custom_controls.DataGridViewNumericUpDownCell)ccustomDataGridViewRow.Cells[dataGridViewColumn.Index]).Infinity;
								num2 = 65;
								continue;
							}
							case 91:
								num2 = 26;
								continue;
							case 92:
								goto IL_AE0;
							case 93:
								if (xmlNode.Attributes["Applicable"].Value == "NA")
								{
									num2 = 24;
									continue;
								}
								goto IL_5CD;
							case 94:
							{
								global::custom_controls.DataGridViewNumericUpDownEditingControl dataGridViewNumericUpDownEditingControl = base.EditingControl as global::custom_controls.DataGridViewNumericUpDownEditingControl;
								dataGridViewNumericUpDownEditingControl.EditingControlFormattedValue = base[dataGridViewColumn.Index, num].Value;
								num2 = 82;
								continue;
							}
							case 95:
								base[dataGridViewColumn.Index, num].Value = "⃠";
								num2 = 52;
								continue;
							case 96:
								goto IL_8DE;
							case 97:
								num2 = 20;
								continue;
							case 98:
								if (this.GetComboColumnChoices != null)
								{
									num2 = 0;
									continue;
								}
								goto IL_2D9;
							case 99:
								if (xmlNode.Attributes["Applicable"] != null)
								{
									num2 = 57;
									continue;
								}
								goto IL_5CD;
							case 100:
								value3 = xmlNode.Attributes["ListID"].Value;
								num2 = 2;
								continue;
							case 101:
								num2 = 29;
								continue;
							case 102:
								goto IL_8DE;
							case 103:
								if (this.ag != null)
								{
									num2 = 38;
									continue;
								}
								goto IL_B3C;
							case 104:
							{
								global::System.Collections.ArrayList choices;
								this.GetComboColumnChoices(this, ref choices, dataGridViewColumn.Name, dataGridViewColumn.Index, num, false);
								this.LoadComboColumnChoices(choices, ref dataGridViewComboBoxCell);
								num2 = 96;
								continue;
							}
							case 105:
								num2 = 4;
								continue;
							case 106:
								base[dataGridViewColumn.Index, num].Value = global::custom_controls.CCustomDataGridView.GetSelectItemTextFromComboColumnByField(dataGridViewComboBoxCell, xmlNode.InnerText);
								num2 = 107;
								continue;
							case 107:
								goto IL_FB3;
							case 108:
								if (((global::custom_controls.DataGridViewCustomTextBoxColumn)dataGridViewColumn).ColumnReadOnly)
								{
									num2 = 34;
									continue;
								}
								goto IL_D94;
							case 109:
								num2 = 12;
								continue;
							case 110:
							{
								global::System.Collections.ArrayList choices;
								this.GetComboColumnChoices(this, ref choices, dataGridViewColumn.Name, dataGridViewColumn.Index, num, true);
								this.LoadComboColumnChoices(choices, ref dataGridViewComboBoxCell);
								num2 = 102;
								continue;
							}
							case 111:
								if (num >= 0)
								{
									num2 = 72;
									continue;
								}
								goto IL_107F;
							case 112:
								value2 = xmlNode.Attributes["ListLetID"].Value;
								num2 = 55;
								continue;
							case 113:
								if (dataGridViewColumn.Name == "RASDATA_RASKEY")
								{
									num2 = 5;
									continue;
								}
								goto IL_561;
							case 114:
							{
								global::custom_controls.DataGridViewCustTextBoxEditingControl dataGridViewCustTextBoxEditingControl = base.EditingControl as global::custom_controls.DataGridViewCustTextBoxEditingControl;
								dataGridViewCustTextBoxEditingControl.EditingControlFormattedValue = base[dataGridViewColumn.Index, num].Value;
								num2 = 70;
								continue;
							}
							}
							goto IL_249;
							IL_2D9:
							num2 = 44;
							continue;
							IL_31A:
							num2 = 76;
							continue;
							IL_561:
							num2 = 51;
							continue;
							IL_594:
							base[dataGridViewColumn.Index, num].Tag = text;
							num2 = 63;
							continue;
							IL_5CD:
							dataGridViewComboBoxCell = (global::System.Windows.Forms.DataGridViewComboBoxCell)ccustomDataGridViewRow.Cells[dataGridViewColumn.Index];
							num2 = 98;
							continue;
							IL_60F:
							num2 = 30;
							continue;
							IL_74A:
							value = ((global::custom_controls.DataGridViewNumericUpDownCell)ccustomDataGridViewRow.Cells[dataGridViewColumn.Index]).GetFormattedText(xmlNode.InnerText);
							base[dataGridViewColumn.Index, num].Value = value;
							num2 = 58;
							continue;
							IL_826:
							base[dataGridViewColumn.Index, num].Value = xmlNode.InnerText;
							num2 = 1;
							continue;
							IL_8DE:
							num2 = 21;
							continue;
							IL_942:
							num2 = 84;
							continue;
							IL_975:
							num = this.a(global::System.Convert.ToInt32(value3, global::System.Globalization.CultureInfo.InvariantCulture), global::System.Convert.ToInt32(value2, global::System.Globalization.CultureInfo.InvariantCulture), dataGridViewColumn);
							num2 = 27;
							continue;
							IL_AE0:
							base[dataGridViewColumn.Index, num].ReadOnly = true;
							base[dataGridViewColumn.Index, num].Selected = false;
							base[dataGridViewColumn.Index, num].Style.BackColor = base.ColumnHeadersDefaultCellStyle.BackColor;
							num2 = 53;
							continue;
							IL_B3C:
							global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
							arrayList.Add(new global::custom_controls.CCustomDataGridView.ComboItem(text2, text2, text2));
							((global::System.Windows.Forms.DataGridViewComboBoxCell)base[dataGridViewColumn.Index, num]).DataSource = arrayList;
							base[dataGridViewColumn.Index, num].Value = text2;
							base[dataGridViewColumn.Index, num].ReadOnly = true;
							num2 = 35;
							continue;
							IL_CA1:
							num2 = 113;
							continue;
							IL_D06:
							num2 = 89;
							continue;
							IL_D36:
							num2 = 80;
							continue;
							IL_D94:
							base[dataGridViewColumn.Index, num].ReadOnly = false;
							base[dataGridViewColumn.Index, num].Style.BackColor = global::System.Drawing.SystemColors.Window;
							num2 = 87;
							continue;
							IL_E54:
							value = ((global::custom_controls.DataGridViewCustomTextBoxCell)ccustomDataGridViewRow.Cells[dataGridViewColumn.Index]).GetFormattedText(xmlNode.InnerText);
							base[dataGridViewColumn.Index, num].Value = value;
							num2 = 79;
							continue;
							IL_F67:
							num2 = 111;
							continue;
							IL_FB3:
							num2 = 68;
							continue;
							IL_107F:
							num3++;
							num2 = 6;
							continue;
							IL_10BF:
							num2 = 43;
							continue;
							IL_10F4:
							num2 = 8;
							continue;
							IL_249:
							goto IL_10F4;
						}
						IL_1157:;
					}
					finally
					{
						for (;;)
						{
							global::System.IDisposable disposable = enumerator as global::System.IDisposable;
							int num2 = 0;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num2 = 2;
										continue;
									}
									goto IL_11A1;
								case 1:
									goto IL_119F;
								case 2:
									disposable.Dispose();
									num2 = 1;
									continue;
								}
								break;
							}
						}
						IL_119F:
						IL_11A1:;
					}
				}
				finally
				{
					int num2 = 1;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_11E1;
						case 2:
							((global::System.IDisposable)dataLoader).Dispose();
							num2 = 0;
							continue;
						}
						if (dataLoader == null)
						{
							break;
						}
						num2 = 2;
					}
					IL_11E1:;
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00013DE8 File Offset: 0x00011FE8
		public void UpdateZoneListLetId(string xmlRowsData)
		{
			int num = 0;
			switch (num)
			{
			default:
				num = 4;
				for (;;)
				{
					int num2;
					global::System.Xml.XmlNodeList childNodes;
					switch (num)
					{
					case 0:
						goto IL_2DE;
					case 1:
						return;
					case 2:
					{
						if (true)
						{
						}
						if (num2 >= childNodes.Count)
						{
							num = 1;
							continue;
						}
						global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)base.Rows).GetEnumerator();
						num = 5;
						continue;
					}
					case 3:
						return;
					case 5:
						try
						{
							num = 7;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_242;
								case 1:
									num = 5;
									continue;
								case 2:
									goto IL_236;
								case 3:
									num = 9;
									continue;
								case 4:
								{
									global::System.Windows.Forms.DataGridViewRow dataGridViewRow;
									((global::custom_controls.CCustomDataGridViewRow)dataGridViewRow).LetID = childNodes[num2].Attributes["ListLetID"].Value;
									num = 13;
									continue;
								}
								case 5:
								{
									global::System.Windows.Forms.DataGridViewRow dataGridViewRow;
									if (((global::custom_controls.CCustomDataGridViewRow)dataGridViewRow).Type == childNodes[num2].Attributes["TypeID"].Value)
									{
										num = 10;
										continue;
									}
									break;
								}
								case 6:
									if (childNodes[num2].Attributes["TypeID"] != null)
									{
										num = 3;
										continue;
									}
									num = 8;
									continue;
								case 8:
								{
									global::System.Windows.Forms.DataGridViewRow dataGridViewRow;
									if (((global::custom_controls.CCustomDataGridViewRow)dataGridViewRow).ID == childNodes[num2].InnerText)
									{
										num = 4;
										continue;
									}
									break;
								}
								case 9:
								{
									global::System.Windows.Forms.DataGridViewRow dataGridViewRow;
									if (((global::custom_controls.CCustomDataGridViewRow)dataGridViewRow).ID == childNodes[num2].InnerText)
									{
										num = 1;
										continue;
									}
									break;
								}
								case 10:
								{
									global::System.Windows.Forms.DataGridViewRow dataGridViewRow;
									((global::custom_controls.CCustomDataGridViewRow)dataGridViewRow).LetID = childNodes[num2].Attributes["ListLetID"].Value;
									num = 2;
									continue;
								}
								case 11:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = 12;
										continue;
									}
									global::System.Windows.Forms.DataGridViewRow dataGridViewRow = (global::System.Windows.Forms.DataGridViewRow)enumerator.Current;
									num = 6;
									continue;
								}
								case 12:
									goto IL_236;
								case 13:
									goto IL_236;
								}
								IL_113:
								num = 11;
								continue;
								goto IL_113;
								IL_236:
								num = 0;
							}
							IL_242:
							goto IL_30D;
						}
						finally
						{
							for (;;)
							{
								global::System.Collections.IEnumerator enumerator;
								global::System.IDisposable disposable = enumerator as global::System.IDisposable;
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
										goto IL_2A9;
									case 1:
										if (disposable != null)
										{
											num = 2;
											continue;
										}
										goto IL_2AB;
									case 2:
										disposable.Dispose();
										num = 0;
										continue;
									}
									break;
								}
							}
							IL_2A9:
							IL_2AB:;
						}
						goto IL_2AC;
						IL_30D:
						num2++;
						num = 6;
						continue;
					case 6:
						goto IL_2DE;
					}
					if (xmlRowsData == null)
					{
						num = 3;
						continue;
					}
					IL_2AC:
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.LoadXml(xmlRowsData);
					childNodes = xmlDocument.ChildNodes[0].ChildNodes;
					num2 = 0;
					num = 0;
					continue;
					IL_2DE:
					num = 2;
				}
				return;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00014150 File Offset: 0x00012350
		private int a(int A_0, int A_1, global::System.Windows.Forms.DataGridViewColumn A_2)
		{
			switch (0)
			{
			default:
			{
				int result;
				for (;;)
				{
					result = -1;
					global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow = null;
					int num = 4;
					for (;;)
					{
						int num3;
						switch (num)
						{
						case 0:
							goto IL_F1;
						case 1:
							num = 10;
							continue;
						case 2:
							result = global::System.Convert.ToInt32(ccustomDataGridViewRow.Index, global::System.Globalization.CultureInfo.InvariantCulture);
							num = 17;
							continue;
						case 3:
							return result;
						case 4:
							if (A_1 >= 0)
							{
								int num2 = 0;
								num = 12;
								continue;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_113;
							default:
								if (false)
								{
								}
								num = 8;
								continue;
							}
							break;
						case 5:
							if (A_0 == global::System.Convert.ToInt32(ccustomDataGridViewRow.ID, global::System.Globalization.CultureInfo.InvariantCulture))
							{
								num = 15;
								continue;
							}
							goto IL_1F4;
						case 6:
							if (base.Rows[num3].Cells[A_2.Index].Tag != null)
							{
								num = 13;
								continue;
							}
							goto IL_1F4;
						case 7:
						{
							if (A_1 == global::System.Convert.ToInt32(ccustomDataGridViewRow.SubID, global::System.Globalization.CultureInfo.InvariantCulture))
							{
								num = 2;
								continue;
							}
							int num2;
							num2++;
							num = 18;
							continue;
						}
						case 8:
							num3 = 0;
							num = 0;
							continue;
						case 9:
							result = global::System.Convert.ToInt32(ccustomDataGridViewRow.Index, global::System.Globalization.CultureInfo.InvariantCulture);
							num = 3;
							continue;
						case 10:
							return result;
						case 11:
							if (true)
							{
							}
							if ("NA" != base.Rows[num3].Cells[A_2.Index].Tag.ToString())
							{
								num = 9;
								continue;
							}
							goto IL_1F4;
						case 12:
							goto IL_1CB;
						case 13:
							num = 11;
							continue;
						case 14:
						{
							int num2;
							if (num2 >= base.RowCount)
							{
								num = 19;
								continue;
							}
							ccustomDataGridViewRow = (base.Rows[num2] as global::custom_controls.CCustomDataGridViewRow);
							num = 7;
							continue;
						}
						case 15:
							num = 6;
							continue;
						case 16:
							goto IL_F1;
						case 17:
							return result;
						case 18:
							goto IL_1CB;
						case 19:
							return result;
						case 20:
							if (num3 >= base.RowCount)
							{
								goto IL_113;
							}
							ccustomDataGridViewRow = (base.Rows[num3] as global::custom_controls.CCustomDataGridViewRow);
							num = 5;
							continue;
						}
						break;
						IL_F1:
						num = 20;
						continue;
						IL_113:
						num = 1;
						continue;
						IL_1CB:
						num = 14;
						continue;
						IL_1F4:
						num3++;
						num = 16;
					}
				}
				return result;
			}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00014424 File Offset: 0x00012624
		public static string GetSelectItemTextFromComboColumnByField(global::System.Windows.Forms.DataGridViewComboBoxCell dgvcCell, string fieldValaue)
		{
			switch (0)
			{
			default:
			{
				string result;
				for (;;)
				{
					IL_61:
					result = string.Empty;
					int num = 4;
					for (;;)
					{
						int num2;
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
								return result;
							case 1:
								goto IL_D0;
							case 2:
								if (fieldValaue == ((global::custom_controls.CCustomDataGridView.ComboItem)dgvcCell.Items[num2]).Display)
								{
									num = 6;
									continue;
								}
								goto IL_81;
							case 3:
								num2 = 0;
								num = 1;
								continue;
							case 4:
								if (dgvcCell != null)
								{
									num = 3;
									continue;
								}
								return result;
							case 5:
								if (num2 >= dgvcCell.Items.Count)
								{
									num = 0;
									continue;
								}
								num = 2;
								continue;
							case 6:
								result = ((global::custom_controls.CCustomDataGridView.ComboItem)dgvcCell.Items[num2]).Display;
								num = 7;
								continue;
							case 7:
								return result;
							case 8:
								if (true)
								{
								}
								goto IL_D0;
							}
							goto IL_61;
							IL_D0:
							num = 5;
							continue;
						}
						IL_81:
						num2++;
						num = 8;
					}
				}
				return result;
			}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0001456C File Offset: 0x0001276C
		public static string GetSelectItemTextFromComboColumnByField(global::System.Windows.Forms.DataGridViewColumn column, string fieldValaue)
		{
			switch (0)
			{
			default:
			{
				string result;
				for (;;)
				{
					for (;;)
					{
						result = string.Empty;
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (column != null)
								{
									num = 4;
									continue;
								}
								return result;
							case 1:
								return result;
							case 2:
								goto IL_AA;
							case 3:
							{
								int num2;
								global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
								if (num2 >= dataGridViewComboBoxColumn.Items.Count)
								{
									num = 1;
									continue;
								}
								num = 6;
								continue;
							}
							case 4:
							{
								global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn = (global::System.Windows.Forms.DataGridViewComboBoxColumn)column;
								int num2 = 0;
								num = 7;
								continue;
							}
							case 5:
							{
								int num2;
								global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
								result = ((global::custom_controls.CCustomDataGridView.ComboItem)dataGridViewComboBoxColumn.Items[num2]).Display;
								num = 8;
								continue;
							}
							case 6:
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
									int num2;
									global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
									if (fieldValaue == ((global::custom_controls.CCustomDataGridView.ComboItem)dataGridViewComboBoxColumn.Items[num2]).Tag)
									{
										num = 5;
										continue;
									}
									num2++;
									num = 2;
									continue;
								}
								}
								break;
							case 7:
								goto IL_AA;
							case 8:
								return result;
							}
							break;
							IL_AA:
							num = 3;
						}
					}
				}
				return result;
			}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000146BC File Offset: 0x000128BC
		public static string GetSelectItemTextFromComboColumn(global::System.Windows.Forms.DataGridViewColumn column, string fieldValaue, string typeId)
		{
			switch (0)
			{
			default:
			{
				string result;
				for (;;)
				{
					result = string.Empty;
					int num = 1;
					for (;;)
					{
						if (true)
						{
						}
						int num2;
						switch (num)
						{
						case 0:
							goto IL_CD;
						case 1:
							if (column != null)
							{
								num = 10;
								continue;
							}
							return result;
						case 2:
							return result;
						case 3:
							num = 9;
							continue;
						case 4:
						{
							global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
							if (fieldValaue == ((global::custom_controls.CCustomDataGridView.ComboItem)dataGridViewComboBoxColumn.Items[num2]).Tag)
							{
								num = 3;
								continue;
							}
							goto IL_6B;
						}
						case 5:
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
								global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
								if (num2 >= dataGridViewComboBoxColumn.Items.Count)
								{
									num = 2;
									continue;
								}
								num = 4;
								continue;
							}
							}
							break;
						case 6:
							return result;
						case 7:
							goto IL_CD;
						case 8:
						{
							global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
							result = ((global::custom_controls.CCustomDataGridView.ComboItem)dataGridViewComboBoxColumn.Items[num2]).Display;
							num = 6;
							continue;
						}
						case 9:
						{
							global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
							if (typeId == ((global::custom_controls.CCustomDataGridView.ComboItem)dataGridViewComboBoxColumn.Items[num2]).TypeId)
							{
								num = 8;
								continue;
							}
							goto IL_6B;
						}
						case 10:
						{
							global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn = (global::System.Windows.Forms.DataGridViewComboBoxColumn)column;
							num2 = 0;
							goto IL_BF;
						}
						}
						break;
						IL_6B:
						num2++;
						num = 0;
						continue;
						IL_BF:
						num = 7;
						continue;
						IL_CD:
						num = 5;
					}
				}
				return result;
			}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00014850 File Offset: 0x00012A50
		public static string GetSelectItemTextFromComboColumn(global::System.Windows.Forms.DataGridViewComboBoxCell dgvcCell, string fieldValaue, string typeId)
		{
			string result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				default:
					for (;;)
					{
						result = string.Empty;
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (dgvcCell != null)
								{
									num = 8;
									continue;
								}
								return result;
							case 1:
								return result;
							case 2:
								num = 7;
								continue;
							case 3:
								goto IL_E4;
							case 4:
							{
								int num2;
								if (fieldValaue == ((global::custom_controls.CCustomDataGridView.ComboItem)dgvcCell.Items[num2]).Tag)
								{
									num = 2;
									continue;
								}
								goto IL_63;
							}
							case 5:
								return result;
							case 6:
								goto IL_E4;
							case 7:
							{
								int num2;
								if (typeId == ((global::custom_controls.CCustomDataGridView.ComboItem)dgvcCell.Items[num2]).TypeId)
								{
									num = 10;
									continue;
								}
								goto IL_63;
							}
							case 8:
							{
								int num2 = 0;
								num = 3;
								continue;
							}
							case 9:
							{
								int num2;
								if (num2 >= dgvcCell.Items.Count)
								{
									num = 1;
									continue;
								}
								num = 4;
								continue;
							}
							case 10:
							{
								int num2;
								result = ((global::custom_controls.CCustomDataGridView.ComboItem)dgvcCell.Items[num2]).Display;
								num = 5;
								continue;
							}
							}
							break;
							IL_63:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								if (true)
								{
								}
								if (false)
								{
								}
								int num2;
								num2++;
								num = 6;
								continue;
							}
							}
							IL_E4:
							num = 9;
						}
					}
					break;
				}
			}
			return result;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000149E0 File Offset: 0x00012BE0
		public global::custom_controls.CCustomDataGridView.ComboItem GetSelectedItemFromComBoCol(global::System.Windows.Forms.DataGridViewColumn column, string displaValue, string displaTag)
		{
			switch (0)
			{
			default:
			{
				global::custom_controls.CCustomDataGridView.ComboItem result;
				for (;;)
				{
					result = default(global::custom_controls.CCustomDataGridView.ComboItem);
					int num = 6;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							goto IL_D1;
						case 1:
						{
							global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
							if (displaTag == ((global::custom_controls.CCustomDataGridView.ComboItem)dataGridViewComboBoxColumn.Items[num2]).TypeId)
							{
								num = 8;
								continue;
							}
							goto IL_65;
						}
						case 2:
							return result;
						case 3:
						{
							if (true)
							{
							}
							global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
							if (num2 >= dataGridViewComboBoxColumn.Items.Count)
							{
								num = 2;
								continue;
							}
							num = 7;
							continue;
						}
						case 4:
							return result;
						case 5:
						{
							global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn = (global::System.Windows.Forms.DataGridViewComboBoxColumn)column;
							num2 = 0;
							num = 9;
							continue;
						}
						case 6:
							if (column != null)
							{
								goto IL_5A;
							}
							return result;
						case 7:
						{
							global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
							if (displaValue == ((global::custom_controls.CCustomDataGridView.ComboItem)dataGridViewComboBoxColumn.Items[num2]).Display)
							{
								num = 10;
								continue;
							}
							goto IL_65;
						}
						case 8:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_5A;
							default:
							{
								if (false)
								{
								}
								global::System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
								result = (global::custom_controls.CCustomDataGridView.ComboItem)dataGridViewComboBoxColumn.Items[num2];
								num = 4;
								continue;
							}
							}
							break;
						case 9:
							goto IL_D1;
						case 10:
							num = 1;
							continue;
						}
						break;
						IL_5A:
						num = 5;
						continue;
						IL_65:
						num2++;
						num = 0;
						continue;
						IL_D1:
						num = 3;
					}
				}
				return result;
			}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00014B6C File Offset: 0x00012D6C
		public global::custom_controls.CCustomDataGridView.ComboItem GetSelectedItemFromComBoCol(global::System.Windows.Forms.DataGridViewComboBoxCell dgvcCell, string displaValue, string displaTag)
		{
			switch (0)
			{
			default:
			{
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_DC:
					num = 5;
					break;
				default:
					if (false)
					{
					}
					goto IL_69;
				}
				global::custom_controls.CCustomDataGridView.ComboItem result;
				int num2;
				for (;;)
				{
					IL_36:
					switch (num)
					{
					case 0:
						return result;
					case 1:
						if (num2 >= dgvcCell.Items.Count)
						{
							num = 4;
							continue;
						}
						num = 7;
						continue;
					case 2:
						if (true)
						{
						}
						goto IL_EA;
					case 3:
						if (displaTag == ((global::custom_controls.CCustomDataGridView.ComboItem)dgvcCell.Items[num2]).TypeId)
						{
							num = 6;
							continue;
						}
						goto IL_8B;
					case 4:
						return result;
					case 5:
						goto IL_EA;
					case 6:
						result = (global::custom_controls.CCustomDataGridView.ComboItem)dgvcCell.Items[num2];
						num = 0;
						continue;
					case 7:
						if (displaValue == ((global::custom_controls.CCustomDataGridView.ComboItem)dgvcCell.Items[num2]).Display)
						{
							num = 9;
							continue;
						}
						goto IL_8B;
					case 8:
						goto IL_89;
					case 9:
						num = 3;
						continue;
					case 10:
						if (dgvcCell != null)
						{
							num = 8;
							continue;
						}
						return result;
					}
					goto IL_69;
					IL_8B:
					num2++;
					num = 2;
					continue;
					IL_EA:
					num = 1;
				}
				IL_89:
				num2 = 0;
				goto IL_DC;
				IL_69:
				result = default(global::custom_controls.CCustomDataGridView.ComboItem);
				num = 10;
				goto IL_36;
			}
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00014CF0 File Offset: 0x00012EF0
		private void a(global::System.Windows.Forms.DataGridViewColumn A_0, global::custom_controls.CustomNumericUpDown A_1)
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
			A_1.TabStop = false;
			A_1.EditControl.TabStop = false;
			A_1.DecimalPlaces = ((global::custom_controls.DataGridViewNumericUpDownColumn)A_0).DecimalPlaces;
			A_1.Increment = ((global::custom_controls.DataGridViewNumericUpDownColumn)A_0).Increment;
			A_1.Maximum = ((global::custom_controls.DataGridViewNumericUpDownColumn)A_0).Maximum;
			A_1.Minimum = ((global::custom_controls.DataGridViewNumericUpDownColumn)A_0).Minimum;
			A_1.MaxInputLength = ((global::custom_controls.DataGridViewNumericUpDownColumn)A_0).MaxInputLength;
			A_1.BlankAllowed = ((global::custom_controls.DataGridViewNumericUpDownColumn)A_0).BlankAllowed;
			A_1.Hexadecimal = ((global::custom_controls.DataGridViewNumericUpDownColumn)A_0).Hexadecimal;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00014DB8 File Offset: 0x00012FB8
		public void SetRangeForUpdownColumn(string xmlRange, int columnIndex)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn = base.Columns[columnIndex];
					global::custom_controls.CustomNumericUpDown customNumericUpDown = new global::custom_controls.CustomNumericUpDown();
					this.a(dataGridViewColumn, customNumericUpDown);
					string infinity = string.Empty;
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.LoadXml(xmlRange);
					global::System.Xml.XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode(dataGridViewColumn.Name + "/RANGE");
					global::System.Xml.XmlNodeList childNodes = xmlNode.ChildNodes;
					int num = 0;
					int num2 = 11;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_247;
						case 1:
							goto IL_287;
						case 2:
							if (((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).DecimalPlaces >= 0)
							{
								num2 = 1;
								continue;
							}
							goto IL_247;
						case 3:
							if (num >= childNodes.Count)
							{
								num2 = 7;
								continue;
							}
							num2 = 9;
							continue;
						case 4:
						{
							string name;
							if (!(name == "Max"))
							{
								num2 = 22;
								continue;
							}
							num2 = 16;
							continue;
						}
						case 5:
							goto IL_247;
						case 6:
							num2 = 27;
							continue;
						case 7:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_287;
							default:
								goto IL_43B;
							}
							break;
						case 8:
							goto IL_247;
						case 9:
						{
							string name;
							if ((name = childNodes[num].Name) != null)
							{
								num2 = 13;
								continue;
							}
							goto IL_247;
						}
						case 10:
							num2 = 17;
							continue;
						case 11:
							goto IL_2E5;
						case 12:
							goto IL_247;
						case 13:
							num2 = 14;
							continue;
						case 14:
						{
							string name;
							if (!(name == "Min"))
							{
								num2 = 24;
								continue;
							}
							num2 = 2;
							continue;
						}
						case 15:
						{
							decimal increment = global::System.Convert.ToDecimal(childNodes[num].InnerText, customNumericUpDown.InvariantNumberFormat);
							((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).Increment = increment;
							num2 = 5;
							continue;
						}
						case 16:
							if (((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).DecimalPlaces >= 0)
							{
								num2 = 20;
								continue;
							}
							goto IL_247;
						case 17:
							goto IL_247;
						case 18:
							goto IL_247;
						case 19:
							goto IL_2E5;
						case 20:
						{
							decimal maximum = global::System.Convert.ToDecimal(childNodes[num].InnerText, customNumericUpDown.InvariantNumberFormat);
							((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).Maximum = maximum;
							num2 = 18;
							continue;
						}
						case 21:
							num2 = 26;
							continue;
						case 22:
							if (true)
							{
							}
							num2 = 25;
							continue;
						case 23:
							if (((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).DecimalPlaces >= 0)
							{
								num2 = 15;
								continue;
							}
							goto IL_247;
						case 24:
							num2 = 4;
							continue;
						case 25:
						{
							string name;
							if (!(name == "StepSize"))
							{
								num2 = 6;
								continue;
							}
							num2 = 23;
							continue;
						}
						case 26:
						{
							string name;
							if (!(name == "STR_NONE"))
							{
								num2 = 10;
								continue;
							}
							((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).None = childNodes[num].InnerText;
							string specialDisplayText = null;
							this.ag("NONE", ref specialDisplayText);
							((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).SpecialDisplayText = specialDisplayText;
							num2 = 0;
							continue;
						}
						case 27:
						{
							string name;
							if (!(name == "Infinite"))
							{
								num2 = 21;
								continue;
							}
							infinity = childNodes[num].InnerText;
							((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).Infinity = infinity;
							num2 = 8;
							continue;
						}
						}
						break;
						IL_247:
						num++;
						num2 = 19;
						continue;
						IL_287:
						decimal minimum = global::System.Convert.ToDecimal(childNodes[num].InnerText, customNumericUpDown.InvariantNumberFormat);
						((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).Minimum = minimum;
						num2 = 12;
						continue;
						IL_2E5:
						num2 = 3;
					}
				}
				IL_43B:
				if (false)
				{
				}
				return;
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00015208 File Offset: 0x00013408
		public void SetRangeForUpdownColumn(string xmlRange, int columnIndex, int rowIndex, global::System.Windows.Forms.DataGridViewCell dgvCell)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				default:
				{
					int num = 4;
					for (;;)
					{
						int num2;
						global::System.Xml.XmlNodeList childNodes;
						global::custom_controls.DataGridViewNumericUpDownCell dataGridViewNumericUpDownCell;
						global::System.Windows.Forms.DataGridViewCell dataGridViewCell;
						global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
						string infinity;
						switch (num)
						{
						case 0:
							goto IL_205;
						case 1:
							if (num2 >= childNodes.Count)
							{
								num = 26;
								continue;
							}
							num = 6;
							continue;
						case 2:
							return;
						case 3:
							num = 20;
							continue;
						case 5:
							if (dataGridViewNumericUpDownCell.DecimalPlaces >= 0)
							{
								num = 23;
								continue;
							}
							goto IL_205;
						case 6:
						{
							string name;
							if ((name = childNodes[num2].Name) != null)
							{
								num = 3;
								continue;
							}
							goto IL_205;
						}
						case 7:
							goto IL_205;
						case 8:
							goto IL_205;
						case 9:
							goto IL_205;
						case 10:
							num = 24;
							continue;
						case 11:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								if (false)
								{
								}
								goto IL_205;
							}
							break;
						case 12:
							goto IL_205;
						case 13:
						{
							decimal minimum = global::System.Convert.ToDecimal(childNodes[num2].InnerText, ((global::custom_controls.DataGridViewNumericUpDownCell)dataGridViewCell).InvariantNumberFormat);
							dataGridViewNumericUpDownCell.Minimum = minimum;
							num = 8;
							continue;
						}
						case 14:
							if (dataGridViewNumericUpDownCell.DecimalPlaces >= 0)
							{
								num = 28;
								continue;
							}
							goto IL_205;
						case 15:
						{
							string name;
							if (!(name == "Max"))
							{
								num = 10;
								continue;
							}
							num = 14;
							continue;
						}
						case 16:
							goto IL_2DE;
						case 17:
							num = 15;
							continue;
						case 18:
						{
							string name;
							if (!(name == "STR_NONE"))
							{
								num = 21;
								continue;
							}
							((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).None = childNodes[num2].InnerText;
							dataGridViewNumericUpDownCell.None = childNodes[num2].InnerText;
							string specialDisplayText = null;
							this.ag("NONE", ref specialDisplayText);
							((global::custom_controls.DataGridViewNumericUpDownColumn)dataGridViewColumn).SpecialDisplayText = specialDisplayText;
							dataGridViewNumericUpDownCell.SpecialDisplayText = specialDisplayText;
							num = 0;
							continue;
						}
						case 19:
							if (dataGridViewNumericUpDownCell.DecimalPlaces >= 0)
							{
								num = 13;
								continue;
							}
							goto IL_205;
						case 20:
						{
							string name;
							if (!(name == "Min"))
							{
								num = 17;
								continue;
							}
							num = 19;
							continue;
						}
						case 21:
							num = 12;
							continue;
						case 22:
							num = 25;
							continue;
						case 23:
						{
							decimal increment = global::System.Convert.ToDecimal(childNodes[num2].InnerText, ((global::custom_controls.DataGridViewNumericUpDownCell)dataGridViewCell).InvariantNumberFormat);
							dataGridViewNumericUpDownCell.Increment = increment;
							num = 9;
							continue;
						}
						case 24:
						{
							string name;
							if (!(name == "StepSize"))
							{
								num = 22;
								continue;
							}
							num = 5;
							continue;
						}
						case 25:
						{
							string name;
							if (!(name == "Infinite"))
							{
								num = 27;
								continue;
							}
							infinity = childNodes[num2].InnerText;
							dataGridViewNumericUpDownCell.Infinity = infinity;
							num = 11;
							continue;
						}
						case 26:
							return;
						case 27:
							num = 18;
							continue;
						case 28:
						{
							decimal maximum = global::System.Convert.ToDecimal(childNodes[num2].InnerText, ((global::custom_controls.DataGridViewNumericUpDownCell)dataGridViewCell).InvariantNumberFormat);
							dataGridViewNumericUpDownCell.Maximum = maximum;
							num = 7;
							continue;
						}
						case 29:
							goto IL_2DE;
						}
						if (true)
						{
						}
						if (dgvCell == null)
						{
							num = 2;
							continue;
						}
						dataGridViewColumn = null;
						dataGridViewColumn = base.Columns[columnIndex];
						global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow = (global::custom_controls.CCustomDataGridViewRow)base.Rows[rowIndex];
						dataGridViewCell = ccustomDataGridViewRow.Cells[columnIndex];
						infinity = null;
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.LoadXml(xmlRange);
						global::System.Xml.XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode(dataGridViewColumn.Name + "/RANGE");
						childNodes = xmlNode.ChildNodes;
						dataGridViewNumericUpDownCell = (global::custom_controls.DataGridViewNumericUpDownCell)dgvCell;
						dataGridViewNumericUpDownCell.Infinity = infinity;
						dataGridViewNumericUpDownCell.None = null;
						num2 = 0;
						num = 16;
						continue;
						IL_205:
						num2++;
						num = 29;
						continue;
						IL_2DE:
						num = 1;
					}
					break;
				}
				}
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000156C4 File Offset: 0x000138C4
		public void LoadComboColumnChoices(global::System.Collections.ArrayList choices, int columnIndex)
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
			global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn = base.Columns[columnIndex];
			((global::System.Windows.Forms.DataGridViewComboBoxColumn)dataGridViewColumn).DataSource = choices;
			((global::System.Windows.Forms.DataGridViewComboBoxColumn)dataGridViewColumn).ValueMember = "Display";
			((global::System.Windows.Forms.DataGridViewComboBoxColumn)dataGridViewColumn).DisplayMember = ((global::System.Windows.Forms.DataGridViewComboBoxColumn)dataGridViewColumn).ValueMember;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00015740 File Offset: 0x00013940
		public void LoadComboColumnChoices(global::System.Collections.ArrayList choices, ref global::System.Windows.Forms.DataGridViewComboBoxCell dgvcCell)
		{
			int num = 4;
			for (;;)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 0:
					choices.Sort(0, choices.Count, new global::System.Collections.CaseInsensitiveComparer(global::System.Globalization.CultureInfo.CurrentUICulture));
					num = 6;
					continue;
				case 1:
					num = 2;
					continue;
				case 2:
					if (((global::System.Windows.Forms.DataGridViewComboBoxColumn)base.Columns[dgvcCell.ColumnIndex]).Tag.ToString().Equals("Sorted"))
					{
						num = 0;
						continue;
					}
					goto IL_104;
				case 3:
					num = 7;
					continue;
				case 5:
					return;
				case 6:
					goto IL_104;
				case 7:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						if (((global::System.Windows.Forms.DataGridViewComboBoxColumn)base.Columns[dgvcCell.ColumnIndex]).Tag != null)
						{
							num = 1;
							continue;
						}
						goto IL_104;
					}
					break;
				}
				if (dgvcCell != null)
				{
					num = 3;
					continue;
				}
				break;
				IL_104:
				dgvcCell.DataSource = choices;
				dgvcCell.ValueMember = "Display";
				dgvcCell.DisplayMember = dgvcCell.ValueMember;
				num = 5;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0001588C File Offset: 0x00013A8C
		public void LoadComboColumnChoices(global::System.Xml.XmlNode ndXml, ref global::System.Windows.Forms.DataGridViewComboBoxCell dgvcCell)
		{
			global::System.Collections.ArrayList arrayList;
			string typeIdValue;
			string name;
			for (;;)
			{
				arrayList = new global::System.Collections.ArrayList();
				typeIdValue = string.Empty;
				name = ndXml.Name;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.ag(ndXml.InnerText, ref name);
						num = 1;
						continue;
					case 1:
						goto IL_72;
					case 2:
						goto IL_74;
					case 3:
						if (this.ag == null)
						{
							goto IL_DA;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B7;
						default:
							if (false)
							{
							}
							num = 0;
							continue;
						}
						break;
					case 4:
						goto IL_B7;
					case 5:
						if (ndXml.Attributes["TypeID"] != null)
						{
							num = 4;
							continue;
						}
						goto IL_74;
					}
					break;
					IL_74:
					num = 3;
					continue;
					IL_B7:
					typeIdValue = ndXml.Attributes["TypeID"].Value;
					num = 2;
				}
			}
			IL_72:
			IL_DA:
			if (true)
			{
			}
			arrayList.Add(new global::custom_controls.CCustomDataGridView.ComboItem(name, ndXml.InnerText, typeIdValue));
			dgvcCell.DataSource = arrayList;
			dgvcCell.ValueMember = "Display";
			dgvcCell.DisplayMember = dgvcCell.ValueMember;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000159B8 File Offset: 0x00013BB8
		public void SetRestrictedCharInTextColumn(string xmlRange, int columnIndex)
		{
			switch (0)
			{
			default:
			{
				global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
				for (;;)
				{
					dataGridViewColumn = base.Columns[columnIndex];
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.LoadXml(xmlRange);
					global::System.Xml.XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode(dataGridViewColumn.Name + "/RANGE");
					global::System.Xml.XmlNodeList childNodes = xmlNode.ChildNodes;
					int num = 2;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							goto IL_238;
						case 1:
							return;
						case 2:
							if (childNodes.Count > 0)
							{
								num = 13;
								continue;
							}
							return;
						case 3:
							goto IL_1E0;
						case 4:
							if ("RESTRICTCHAR" == childNodes[num2].Name)
							{
								num = 5;
								continue;
							}
							num2++;
							num = 11;
							continue;
						case 5:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E0;
							default:
								goto IL_CD;
							}
							break;
						case 6:
							goto IL_121;
						case 7:
							num = 10;
							continue;
						case 8:
							if ("ALLOWEDCHAR" == childNodes[num2].Name)
							{
								num = 0;
								continue;
							}
							num = 4;
							continue;
						case 9:
							if (num2 >= childNodes.Count)
							{
								num = 1;
								continue;
							}
							((global::custom_controls.DataGridViewCustomTextBoxColumn)dataGridViewColumn).RestrictedChars = childNodes[0].InnerText;
							num = 8;
							continue;
						case 10:
							if (childNodes[0].InnerText.Equals("All", global::System.StringComparison.Ordinal))
							{
								num = 6;
								continue;
							}
							goto IL_1D1;
						case 11:
							goto IL_1AD;
						case 12:
							if ("ALLOWEDCHAR" == childNodes[0].Name)
							{
								if (true)
								{
								}
								num = 7;
								continue;
							}
							goto IL_1D1;
						case 13:
							num = 12;
							continue;
						}
						break;
						IL_1AD:
						num = 9;
						continue;
						IL_1E0:
						goto IL_1AD;
						IL_1D1:
						num2 = 0;
						num = 3;
					}
				}
				IL_CD:
				if (false)
				{
				}
				((global::custom_controls.DataGridViewCustomTextBoxColumn)dataGridViewColumn).IsValidChars = false;
				return;
				IL_121:
				return;
				IL_238:
				((global::custom_controls.DataGridViewCustomTextBoxColumn)dataGridViewColumn).IsValidChars = true;
				return;
			}
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00015C04 File Offset: 0x00013E04
		public void SetRestrictedCharInTextColumn(string xmlRange, int columnIndex, global::custom_controls.DataGridViewCustomTextBoxCell dgvctCell)
		{
			switch (0)
			{
			default:
			{
				int num = 10;
				for (;;)
				{
					int num2;
					global::System.Xml.XmlNodeList childNodes;
					switch (num)
					{
					case 0:
						goto IL_B7;
					case 1:
						num = 15;
						continue;
					case 2:
						if (num2 >= childNodes.Count)
						{
							num = 13;
							continue;
						}
						dgvctCell.RestrictedChars = childNodes[0].InnerText;
						num = 3;
						continue;
					case 3:
						if ("ALLOWEDCHAR" == childNodes[num2].Name)
						{
							num = 4;
							continue;
						}
						num = 14;
						continue;
					case 4:
						goto IL_FF;
					case 5:
						return;
					case 6:
						if (childNodes.Count > 0)
						{
							num = 9;
							continue;
						}
						return;
					case 7:
						goto IL_253;
					case 8:
						goto IL_1E0;
					case 9:
						num = 11;
						continue;
					case 11:
						if ("ALLOWEDCHAR" == childNodes[0].Name)
						{
							num = 1;
							continue;
						}
						goto IL_211;
					case 12:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A3;
						default:
							if (false)
							{
							}
							goto IL_1E0;
						}
						break;
					case 13:
						return;
					case 14:
						if ("RESTRICTCHAR" == childNodes[num2].Name)
						{
							goto IL_A3;
						}
						num2++;
						num = 12;
						continue;
					case 15:
						if (childNodes[0].InnerText.Equals("All", global::System.StringComparison.Ordinal))
						{
							num = 7;
							continue;
						}
						goto IL_211;
					}
					if (dgvctCell == null)
					{
						num = 5;
						continue;
					}
					global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn = base.Columns[columnIndex];
					dgvctCell.XmlRange = xmlRange;
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.LoadXml(xmlRange);
					global::System.Xml.XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode(dataGridViewColumn.Name + "/RANGE");
					childNodes = xmlNode.ChildNodes;
					num = 6;
					continue;
					IL_A3:
					if (true)
					{
					}
					num = 0;
					continue;
					IL_1E0:
					num = 2;
					continue;
					IL_211:
					num2 = 0;
					num = 8;
				}
				return;
				IL_B7:
				dgvctCell.IsValidChars = false;
				return;
				IL_FF:
				dgvctCell.IsValidChars = true;
				return;
				IL_253:
				return;
			}
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00015E68 File Offset: 0x00014068
		public string GetFormatDplCodeValue(int columnIndex, string value, global::custom_controls.DataGridViewCustomTextBoxCell dgvctCell)
		{
			switch (0)
			{
			default:
			{
				int num = 5;
				string result;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_EE;
					case 1:
					{
						global::System.Text.StringBuilder stringBuilder;
						result = value.Insert(0, stringBuilder.ToString());
						num = 0;
						continue;
					}
					case 2:
						num = 7;
						continue;
					case 3:
						goto IL_12F;
					case 4:
						if (value == null)
						{
							goto IL_1BF;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B7;
						default:
							if (false)
							{
							}
							num = 9;
							continue;
						}
						break;
					case 6:
					{
						result = string.Empty;
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
						global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn = base.Columns[columnIndex];
						int num2 = 0;
						num = 3;
						continue;
					}
					case 7:
					{
						global::System.Text.StringBuilder stringBuilder;
						if (stringBuilder != null)
						{
							num = 1;
							continue;
						}
						goto IL_164;
					}
					case 8:
						num = 4;
						continue;
					case 9:
						num = 13;
						continue;
					case 10:
					{
						global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
						int num2;
						if (num2 >= ((global::custom_controls.DataGridViewCustomTextBoxColumn)dataGridViewColumn).MaxLength - value.Length)
						{
							num = 2;
							continue;
						}
						global::System.Text.StringBuilder stringBuilder;
						stringBuilder.Append("0");
						num2++;
						num = 12;
						continue;
					}
					case 11:
						if (columnIndex > -1)
						{
							num = 6;
							continue;
						}
						goto IL_1BF;
					case 12:
						goto IL_12F;
					case 13:
						goto IL_B7;
					case 14:
						num = 11;
						continue;
					}
					if (dgvctCell != null)
					{
						num = 8;
						continue;
					}
					goto IL_1BF;
					IL_B7:
					if (columnIndex < base.ColumnCount)
					{
						num = 14;
						continue;
					}
					goto IL_1BF;
					IL_12F:
					num = 10;
				}
				IL_EE:
				IL_164:
				if (true)
				{
				}
				return result;
				IL_1BF:
				return string.Empty;
			}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0001603C File Offset: 0x0001423C
		public void CopyRows()
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
						int num = 0;
						int num2 = 15;
						for (;;)
						{
							int num4;
							switch (num2)
							{
							case 0:
							{
								stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "\r\n", new object[0]);
								int num3;
								num3++;
								num2 = 2;
								continue;
							}
							case 1:
								global::System.Windows.Forms.Clipboard.SetDataObject(stringBuilder.ToString(), false);
								num2 = 12;
								continue;
							case 2:
								goto IL_174;
							case 3:
								stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "\t", new object[0]);
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_20E;
								default:
									if (false)
									{
									}
									num2 = 8;
									continue;
								}
								break;
							case 4:
								if (num4 < base.ColumnCount - 1)
								{
									goto IL_20E;
								}
								goto IL_15D;
							case 5:
								goto IL_174;
							case 6:
							{
								if (num4 >= base.ColumnCount)
								{
									num2 = 0;
									continue;
								}
								int rowIndex;
								stringBuilder.Append(base[num4, rowIndex].Value.ToString());
								num2 = 4;
								continue;
							}
							case 7:
							{
								arrayList.Sort();
								int rowIndex = 0;
								int num3 = 0;
								num2 = 5;
								continue;
							}
							case 8:
								goto IL_15D;
							case 9:
								goto IL_70;
							case 10:
								goto IL_D5;
							case 11:
								if (num >= base.SelectedRows.Count)
								{
									num2 = 7;
									continue;
								}
								arrayList.Add(base.SelectedRows[num].Index);
								num++;
								num2 = 10;
								continue;
							case 12:
								goto IL_237;
							case 13:
							{
								int num3;
								if (num3 >= arrayList.Count)
								{
									num2 = 1;
									continue;
								}
								int rowIndex = (int)arrayList[num3];
								num4 = 0;
								num2 = 9;
								continue;
							}
							case 14:
								goto IL_70;
							case 15:
								goto IL_D5;
							}
							break;
							IL_70:
							num2 = 6;
							continue;
							IL_D5:
							num2 = 11;
							continue;
							IL_15D:
							num4++;
							num2 = 14;
							continue;
							IL_174:
							num2 = 13;
							continue;
							IL_20E:
							num2 = 3;
						}
					}
					IL_237:
					break;
				}
			}
			catch (global::System.Exception ex)
			{
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000162BC File Offset: 0x000144BC
		private static void a(ref string[] A_0)
		{
			switch (0)
			{
			default:
			{
				char[] separator;
				string text;
				for (;;)
				{
					separator = new char[]
					{
						'\r',
						'\n'
					};
					text = string.Empty;
					global::System.Windows.Forms.IDataObject dataObject = global::System.Windows.Forms.Clipboard.GetDataObject();
					if (true)
					{
					}
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (dataObject.GetDataPresent(global::System.Windows.Forms.DataFormats.Text))
							{
								goto IL_60;
							}
							goto IL_B0;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_60;
							default:
								if (false)
								{
								}
								text = (string)dataObject.GetData(global::System.Windows.Forms.DataFormats.Text);
								num = 2;
								continue;
							}
							break;
						case 2:
							goto IL_AE;
						}
						break;
						IL_60:
						num = 1;
					}
				}
				IL_AE:
				IL_B0:
				A_0 = text.Split(separator, global::System.StringSplitOptions.RemoveEmptyEntries);
				return;
			}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00016384 File Offset: 0x00014584
		public bool CanPasteAdd(int max)
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
			int num = 0;
			return this.CanPasteAdd(max, out num);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000163CC File Offset: 0x000145CC
		public bool CanPasteAdd(int max, out int iReturn)
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
			iReturn = 0;
			bool result = true;
			bool result2;
			try
			{
				int num = 7;
				for (;;)
				{
					int num2;
					int num4;
					int count;
					int num5;
					switch (num)
					{
					case 0:
					{
						num2++;
						int num3 = num2 + (num4 - count);
						num = 8;
						continue;
					}
					case 1:
						num2 = base.SelectedRows[num5].Index;
						num = 13;
						continue;
					case 2:
						goto IL_115;
					case 3:
						goto IL_18B;
					case 4:
						iReturn = 1;
						result2 = false;
						num = 3;
						continue;
					case 5:
						goto IL_207;
					case 6:
						iReturn = 2;
						result = false;
						num = 10;
						continue;
					case 8:
					{
						int num3;
						if (num3 > max)
						{
							num = 6;
							continue;
						}
						goto IL_1FB;
					}
					case 9:
						goto IL_115;
					case 10:
						goto IL_1FB;
					case 11:
						if (num4 > count)
						{
							num = 0;
							continue;
						}
						goto IL_1FB;
					case 12:
						if (num2 < base.SelectedRows[num5].Index)
						{
							num = 1;
							continue;
						}
						goto IL_1B1;
					case 13:
						goto IL_1B1;
					case 14:
						num = 11;
						continue;
					case 15:
						if (num5 >= base.SelectedRows.Count)
						{
							num = 14;
							continue;
						}
						num = 12;
						continue;
					}
					if (base.SelectedRows.Count <= 0)
					{
						num = 4;
						continue;
					}
					string[] array = null;
					global::custom_controls.CCustomDataGridView.a(ref array);
					num4 = array.Length;
					count = base.SelectedRows.Count;
					num2 = base.SelectedRows[0].Index;
					num5 = 0;
					num = 9;
					continue;
					IL_115:
					num = 15;
					continue;
					IL_1B1:
					num5++;
					num = 2;
					continue;
					IL_1FB:
					num = 5;
				}
				IL_18B:
				goto IL_217;
				IL_207:
				return result;
			}
			catch
			{
				iReturn = 3;
				return false;
			}
			IL_217:
			if (true)
			{
			}
			return result2;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00016618 File Offset: 0x00014818
		public void PasteRows()
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						char[] separator = new char[]
						{
							'\r',
							'\n'
						};
						string[] array = null;
						string[] array2 = null;
						global::custom_controls.CCustomDataGridView.a(ref array);
						global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
						int num = 0;
						int num2 = array.Length;
						int count = base.Rows.Count;
						int num3 = 20;
						for (;;)
						{
							int num4;
							int num7;
							int num8;
							int num9;
							int num10;
							int num12;
							int num15;
							int num16;
							switch (num3)
							{
							case 0:
								if (num4 >= num2)
								{
									num3 = 41;
									continue;
								}
								array2 = array[num4].Split(separator, global::System.StringSplitOptions.None);
								num3 = 29;
								continue;
							case 1:
							{
								int index = (int)arrayList[num4];
								int num5 = 0;
								num3 = 14;
								continue;
							}
							case 2:
								goto IL_494;
							case 3:
							{
								global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow;
								int num6;
								ccustomDataGridViewRow.SubID = global::System.Convert.ToString(num6, global::System.Globalization.CultureInfo.InvariantCulture);
								num3 = 10;
								continue;
							}
							case 4:
								num7 = base.ColumnCount;
								goto IL_587;
							case 5:
								goto IL_6F8;
							case 6:
								goto IL_4F5;
							case 7:
								goto IL_2A9;
							case 8:
								goto IL_3FE;
							case 9:
								if (num8 < base.SelectedRows[num9].Index)
								{
									num3 = 30;
									continue;
								}
								goto IL_1B9;
							case 10:
								goto IL_625;
							case 11:
								goto IL_5EB;
							case 12:
							{
								int num5;
								if (num5 >= num10)
								{
									num3 = 52;
									continue;
								}
								int index;
								base.Rows[index].Cells[num5].Value = array2[num5].ToString();
								num5++;
								num3 = 13;
								continue;
							}
							case 13:
								goto IL_6AC;
							case 14:
								goto IL_6AC;
							case 15:
								num3 = 43;
								continue;
							case 16:
								goto IL_333;
							case 17:
							{
								int num11;
								if (num11 >= num10)
								{
									num3 = 3;
									continue;
								}
								global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow;
								ccustomDataGridViewRow.Cells[num11].Value = array2[num11].ToString();
								num11++;
								num3 = 44;
								continue;
							}
							case 18:
								goto IL_560;
							case 19:
								num7 = array2.Length;
								goto IL_587;
							case 20:
								if (base.SelectedRows.Count >= 0)
								{
									num3 = 23;
									continue;
								}
								goto IL_560;
							case 21:
								base.Rows[num8].Selected = true;
								num3 = 28;
								continue;
							case 22:
								num12 = array2.Length;
								goto IL_470;
							case 23:
								num = base.SelectedRows.Count;
								num3 = 18;
								continue;
							case 24:
							{
								int num13 = 0;
								num3 = 8;
								continue;
							}
							case 25:
							{
								int num14;
								if (num14 >= num10)
								{
									num3 = 21;
									continue;
								}
								base.Rows[num8].Cells[num14].Value = array2[num14];
								num14++;
								num3 = 26;
								continue;
							}
							case 26:
								goto IL_494;
							case 27:
								if (num2 <= num)
								{
									num3 = 24;
									continue;
								}
								num4 = 0;
								num3 = 34;
								continue;
							case 28:
								goto IL_625;
							case 29:
								if (base.ColumnCount > array2.Length)
								{
									num3 = 36;
									continue;
								}
								num3 = 4;
								continue;
							case 30:
								num8 = base.SelectedRows[num9].Index;
								num3 = 46;
								continue;
							case 31:
								goto IL_3FE;
							case 32:
								num12 = base.ColumnCount;
								goto IL_470;
							case 33:
								if (num9 >= base.SelectedRows.Count)
								{
									num3 = 37;
									continue;
								}
								arrayList.Add(base.SelectedRows[num9].Index);
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_4E7;
								default:
									if (false)
									{
									}
									num3 = 9;
									continue;
								}
								break;
							case 34:
								goto IL_2A9;
							case 35:
								goto IL_333;
							case 36:
								num3 = 19;
								continue;
							case 37:
							{
								int index = 0;
								arrayList.Sort();
								num3 = 27;
								continue;
							}
							case 38:
								num3 = 22;
								continue;
							case 39:
							{
								if (num8 + 1 < count)
								{
									num3 = 45;
									continue;
								}
								int num6 = this.AddRowAtTheEnd();
								base.Rows[num6].Selected = true;
								global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow = base.Rows[num6] as global::custom_controls.CCustomDataGridViewRow;
								ccustomDataGridViewRow.ID = "0";
								int num11 = 0;
								num3 = 11;
								continue;
							}
							case 40:
								if (base.ColumnCount > array2.Length)
								{
									num3 = 38;
									continue;
								}
								num3 = 32;
								continue;
							case 41:
								goto IL_6EC;
							case 42:
							{
								int num13;
								if (num13 >= num2)
								{
									num3 = 15;
									continue;
								}
								int index = (int)arrayList[num13];
								array2 = array[num13].Split(separator, global::System.StringSplitOptions.None);
								num3 = 40;
								continue;
							}
							case 43:
								goto IL_6EC;
							case 44:
								goto IL_5EB;
							case 45:
							{
								num8++;
								int num14 = 0;
								num3 = 2;
								continue;
							}
							case 46:
								goto IL_1B9;
							case 47:
								goto IL_4F5;
							case 48:
								goto IL_625;
							case 49:
							{
								int num13;
								num13++;
								num3 = 31;
								continue;
							}
							case 50:
								if (true)
								{
								}
								if (num4 < num)
								{
									num3 = 1;
									continue;
								}
								num3 = 39;
								continue;
							case 51:
							{
								if (num15 >= num16)
								{
									num3 = 49;
									continue;
								}
								int index;
								base.Rows[index].Cells[num15].Value = array2[num15].ToString();
								num15++;
								goto IL_4E7;
							}
							case 52:
								num3 = 48;
								continue;
							}
							break;
							IL_1B9:
							num9++;
							num3 = 16;
							continue;
							IL_2A9:
							num3 = 0;
							continue;
							IL_333:
							num3 = 33;
							continue;
							IL_3FE:
							num3 = 42;
							continue;
							IL_470:
							num16 = num12;
							num15 = 0;
							num3 = 47;
							continue;
							IL_494:
							num3 = 25;
							continue;
							IL_4E7:
							num3 = 6;
							continue;
							IL_4F5:
							num3 = 51;
							continue;
							IL_560:
							num8 = base.SelectedRows[0].Index;
							num9 = 0;
							num3 = 35;
							continue;
							IL_587:
							num10 = num7;
							num3 = 50;
							continue;
							IL_5EB:
							num3 = 17;
							continue;
							IL_625:
							num4++;
							num3 = 7;
							continue;
							IL_6AC:
							num3 = 12;
							continue;
							IL_6EC:
							num3 = 5;
						}
					}
					IL_6F8:
					break;
				}
			}
			catch (global::System.Exception ex)
			{
				global::custom_exception.CCustomException.Rethrow(ex);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00016D50 File Offset: 0x00014F50
		protected override bool ProcessCmdKey(ref global::System.Windows.Forms.Message msg, global::System.Windows.Forms.Keys keyData)
		{
			bool result;
			try
			{
				switch (0)
				{
				default:
				{
					int num = 71;
					for (;;)
					{
						bool flag;
						bool flag2;
						switch (num)
						{
						case 0:
							num = 15;
							continue;
						case 1:
							if (base.CurrentCell.ReadOnly)
							{
								num = 11;
								continue;
							}
							base.CurrentCell.DataGridView.BeginEdit(false);
							num = 77;
							continue;
						case 2:
							goto IL_265;
						case 3:
							goto IL_389;
						case 4:
							if (base.SelectedRows.Count == 0)
							{
								num = 57;
								continue;
							}
							goto IL_4FE;
						case 5:
							goto IL_A89;
						case 6:
							if (this.ae != null)
							{
								num = 80;
								continue;
							}
							goto IL_67C;
						case 7:
						{
							global::System.Windows.Forms.Keys keys;
							switch (keys)
							{
							case global::System.Windows.Forms.Keys.Home:
								num = 39;
								continue;
							case global::System.Windows.Forms.Keys.Left:
							case global::System.Windows.Forms.Keys.Right:
								goto IL_3FF;
							case global::System.Windows.Forms.Keys.Up:
								num = 83;
								continue;
							case global::System.Windows.Forms.Keys.Down:
								num = 43;
								continue;
							default:
								num = 0;
								continue;
							}
							break;
						}
						case 8:
							if (this.d)
							{
								num = 22;
								continue;
							}
							goto IL_699;
						case 9:
							if (base.CurrentCell.ColumnIndex == base.ColumnCount - 1)
							{
								num = 75;
								continue;
							}
							num = 49;
							continue;
						case 10:
							if (base.CurrentCell == null)
							{
								num = 61;
								continue;
							}
							num = 47;
							continue;
						case 11:
							base.CurrentCell.Style.BackColor = base.ColumnHeadersDefaultCellStyle.BackColor;
							num = 50;
							continue;
						case 12:
							num = 8;
							continue;
						case 13:
							num = 33;
							continue;
						case 14:
						{
							global::System.Windows.Forms.Keys keys2;
							global::System.Windows.Forms.Keys keys = keys2;
							num = 7;
							continue;
						}
						case 15:
						{
							global::System.Windows.Forms.Keys keys;
							if (keys != global::System.Windows.Forms.Keys.Delete)
							{
								num = 35;
								continue;
							}
							num = 4;
							continue;
						}
						case 16:
							num = 63;
							continue;
						case 17:
							if (this.d)
							{
								num = 55;
								continue;
							}
							goto IL_265;
						case 18:
							if (base.CurrentCell.ReadOnly)
							{
								num = 27;
								continue;
							}
							base.CurrentCell.DataGridView.BeginEdit(false);
							base.ClearSelection();
							base.Invalidate();
							num = 65;
							continue;
						case 19:
						{
							global::System.Windows.Forms.Keys keys3;
							if (keys3 == global::System.Windows.Forms.Keys.Delete)
							{
								num = 29;
								continue;
							}
							goto IL_568;
						}
						case 20:
							goto IL_67C;
						case 21:
							goto IL_5B0;
						case 22:
							num = 42;
							continue;
						case 23:
							if (!base.StandardTab)
							{
								num = 78;
								continue;
							}
							goto IL_230;
						case 24:
							goto IL_4FE;
						case 25:
							if (!(null == base.CurrentCell.EditType))
							{
								num = 82;
								continue;
							}
							goto IL_481;
						case 26:
							if (base.SelectedRows.Count == 0)
							{
								num = 16;
								continue;
							}
							goto IL_568;
						case 27:
							goto IL_481;
						case 28:
							goto IL_615;
						case 29:
							num = 26;
							continue;
						case 30:
							goto IL_274;
						case 31:
							if (base.CurrentCell.ReadOnly)
							{
								num = 51;
								continue;
							}
							goto IL_9D1;
						case 32:
						{
							global::System.Windows.Forms.Keys keys4;
							if (keys4 == global::System.Windows.Forms.Keys.Control)
							{
								num = 14;
								continue;
							}
							goto IL_4FE;
						}
						case 33:
							if (base.CurrentCell.ReadOnly)
							{
								num = 3;
								continue;
							}
							base.CurrentCell.DataGridView.BeginEdit(false);
							base.ClearSelection();
							base.Invalidate();
							num = 70;
							continue;
						case 34:
							goto IL_78D;
						case 35:
							num = 41;
							continue;
						case 36:
							goto IL_6A8;
						case 37:
							goto IL_490;
						case 38:
							goto IL_2E5;
						case 39:
							if (base.CurrentCell.ReadOnly)
							{
								num = 68;
								continue;
							}
							base.CurrentCell.DataGridView.BeginEdit(false);
							num = 20;
							continue;
						case 40:
							if (!base.Rows[base.CurrentRow.Index].Selected)
							{
								num = 59;
								continue;
							}
							goto IL_5B0;
						case 41:
							goto IL_3FF;
						case 42:
							if (!base.Rows[base.CurrentRow.Index].Selected)
							{
								num = 66;
								continue;
							}
							goto IL_2E5;
						case 43:
							if (base.CurrentRow.Index < base.RowCount - 1)
							{
								num = 62;
								continue;
							}
							goto IL_265;
						case 44:
							goto IL_39D;
						case 45:
							goto IL_67C;
						case 46:
							base.ClearSelection();
							base.Invalidate();
							this.a(keyData, ref flag, ref flag2);
							num = 76;
							continue;
						case 47:
							if (msg.Msg == 256)
							{
								num = 85;
								continue;
							}
							goto IL_4FE;
						case 48:
							goto IL_398;
						case 49:
							if (base.CurrentCell.ColumnIndex == 0)
							{
								num = 67;
								continue;
							}
							goto IL_9D1;
						case 50:
							if (this.ae != null)
							{
								num = 79;
								continue;
							}
							goto IL_39D;
						case 51:
							base.SetSelectedCellCore(base.CurrentCell.ColumnIndex, base.CurrentCell.RowIndex, false);
							num = 23;
							continue;
						case 52:
							goto IL_9E0;
						case 53:
							goto IL_9D1;
						case 54:
							goto IL_415;
						case 55:
							num = 40;
							continue;
						case 56:
							num = 10;
							continue;
						case 57:
							num = 25;
							continue;
						case 58:
						{
							global::System.Windows.Forms.Keys keys3;
							if (keys3 != global::System.Windows.Forms.Keys.Home)
							{
								num = 86;
								continue;
							}
							num = 1;
							continue;
						}
						case 59:
							base.Rows[base.CurrentRow.Index].Selected = true;
							num = 21;
							continue;
						case 60:
							goto IL_568;
						case 61:
							goto IL_5FF;
						case 62:
							num = 17;
							continue;
						case 63:
							if (!(null == base.CurrentCell.EditType))
							{
								num = 13;
								continue;
							}
							goto IL_389;
						case 64:
							goto IL_699;
						case 65:
							goto IL_4FE;
						case 66:
							base.Rows[base.CurrentRow.Index].Selected = true;
							num = 38;
							continue;
						case 67:
							base.SelectNextControl(this, false, true, true, true);
							num = 84;
							continue;
						case 68:
							base.CurrentCell.Style.BackColor = base.ColumnHeadersDefaultCellStyle.BackColor;
							num = 6;
							continue;
						case 69:
							result = true;
							num = 34;
							continue;
						case 70:
							goto IL_568;
						case 72:
							num = 31;
							continue;
						case 73:
							goto IL_230;
						case 74:
							if (!flag)
							{
								num = 72;
								continue;
							}
							goto IL_A7D;
						case 75:
							base.SelectNextControl(this, true, true, true, true);
							num = 53;
							continue;
						case 76:
							if (flag)
							{
								num = 69;
								continue;
							}
							num = 74;
							continue;
						case 77:
							goto IL_39D;
						case 78:
							this.ProcessDialogKey(keyData);
							num = 73;
							continue;
						case 79:
							this.ae(this, new global::System.EventArgs());
							num = 44;
							continue;
						case 80:
							this.ae(this, new global::System.EventArgs());
							num = 45;
							continue;
						case 81:
							if (global::custom_controls.CCustomDataGridView.b(keyData))
							{
								num = 46;
								continue;
							}
							goto IL_A7D;
						case 82:
							num = 18;
							continue;
						case 83:
							if (base.CurrentRow.Index > 0)
							{
								num = 12;
								continue;
							}
							goto IL_699;
						case 84:
							goto IL_9D1;
						case 85:
						{
							global::System.Windows.Forms.Keys keys4 = keyData & global::System.Windows.Forms.Keys.Modifiers;
							global::System.Windows.Forms.Keys keys2 = keyData & global::System.Windows.Forms.Keys.KeyCode;
							global::System.Windows.Forms.Keys keys3 = keys2;
							num = 58;
							continue;
						}
						case 86:
							num = 19;
							continue;
						}
						if (base.RowCount > 0)
						{
							num = 56;
							continue;
						}
						goto IL_5FF;
						IL_230:
						num = 9;
						continue;
						IL_265:
						result = true;
						num = 30;
						continue;
						IL_2E5:
						this.t = true;
						this.n = base.CurrentRow.Index;
						this.o = base.CurrentRow.Index - 1;
						this.a(this, this.n, this.o);
						num = 64;
						continue;
						IL_389:
						result = true;
						num = 48;
						continue;
						IL_39D:
						base.ClearSelection();
						base.Invalidate();
						num = 60;
						continue;
						IL_3FF:
						result = base.ProcessCmdKey(ref msg, keyData);
						num = 54;
						continue;
						IL_481:
						result = true;
						num = 37;
						continue;
						IL_4FE:
						flag = false;
						flag2 = true;
						num = 81;
						continue;
						IL_568:
						num = 32;
						continue;
						IL_5B0:
						this.t = true;
						this.n = base.CurrentRow.Index;
						this.o = base.CurrentRow.Index + 1;
						this.a(this, this.n, this.o);
						num = 2;
						continue;
						IL_5FF:
						result = base.ProcessCmdKey(ref msg, keyData);
						num = 28;
						continue;
						IL_67C:
						base.ClearSelection();
						base.Invalidate();
						num = 24;
						continue;
						IL_699:
						result = true;
						num = 36;
						continue;
						IL_9D1:
						result = false;
						num = 52;
						continue;
						IL_A7D:
						num = 5;
					}
					IL_274:
					IL_398:
					IL_415:
					IL_490:
					IL_615:
					IL_6A8:
					IL_78D:
					IL_9E0:
					return result;
					IL_A89:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
				if (false)
				{
				}
				if (true)
				{
				}
				return base.ProcessCmdKey(ref msg, keyData);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00017864 File Offset: 0x00015A64
		protected override bool ProcessDialogKey(global::System.Windows.Forms.Keys keyData)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 3;
					bool result;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (base.CurrentCell != null)
							{
								num = 8;
								continue;
							}
							goto IL_104;
						case 1:
							if (global::custom_controls.CCustomDataGridView.b(keyData))
							{
								num = 9;
								continue;
							}
							goto IL_104;
						case 2:
							goto IL_6A;
						case 4:
							goto IL_110;
						case 5:
							goto IL_6F;
						case 6:
						{
							bool flag;
							if (flag)
							{
								num = 7;
								continue;
							}
							goto IL_104;
						}
						case 7:
							result = true;
							num = 2;
							continue;
						case 8:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_6F;
							default:
							{
								if (false)
								{
								}
								bool flag = false;
								bool flag2 = true;
								num = 1;
								continue;
							}
							}
							break;
						case 9:
						{
							bool flag;
							bool flag2;
							this.a(keyData, ref flag, ref flag2);
							base.ClearSelection();
							base.Invalidate();
							num = 6;
							continue;
						}
						}
						if (base.RowCount > 0)
						{
							num = 5;
							continue;
						}
						goto IL_104;
						IL_6F:
						num = 0;
						continue;
						IL_104:
						num = 4;
					}
					IL_6A:
					return result;
					IL_110:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
			return base.ProcessDialogKey(keyData);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000179E0 File Offset: 0x00015BE0
		protected override bool ProcessKeyPreview(ref global::System.Windows.Forms.Message m)
		{
			switch (0)
			{
			default:
			{
				int num = 0;
				for (;;)
				{
					global::System.Windows.Forms.Keys keys2;
					switch (num)
					{
					case 1:
						this.ae(this, new global::System.EventArgs());
						num = 35;
						continue;
					case 2:
						num = 32;
						continue;
					case 3:
						if (m.HWnd != base.Handle)
						{
							num = 19;
							continue;
						}
						goto IL_2A5;
					case 4:
					{
						global::System.Windows.Forms.Keys keys;
						switch (keys)
						{
						case global::System.Windows.Forms.Keys.Prior:
						case global::System.Windows.Forms.Keys.Next:
						case global::System.Windows.Forms.Keys.End:
						case global::System.Windows.Forms.Keys.Home:
							goto IL_200;
						default:
							num = 23;
							continue;
						}
						break;
					}
					case 5:
						num = 10;
						continue;
					case 6:
						return true;
					case 7:
						num = 24;
						continue;
					case 8:
						if (base.EditingControl.Focused)
						{
							num = 2;
							continue;
						}
						goto IL_10C;
					case 9:
						goto IL_14F;
					case 10:
						if (m.Msg != 260)
						{
							num = 18;
							continue;
						}
						goto IL_3A2;
					case 11:
						num = 29;
						continue;
					case 12:
						goto IL_160;
					case 13:
					{
						bool flag;
						if (flag)
						{
							num = 6;
							continue;
						}
						num = 25;
						continue;
					}
					case 14:
						return true;
					case 15:
					{
						if (true)
						{
						}
						if (global::custom_controls.CCustomDataGridView.b(keys2))
						{
							num = 11;
							continue;
						}
						global::System.Windows.Forms.Keys keys = keys2;
						num = 4;
						continue;
					}
					case 16:
						goto IL_3A2;
					case 17:
						if (m.Msg == 256)
						{
							num = 16;
							continue;
						}
						goto IL_407;
					case 18:
						num = 17;
						continue;
					case 19:
						return true;
					case 20:
						num = 3;
						continue;
					case 21:
						if (base.RowCount > 0)
						{
							num = 7;
							continue;
						}
						goto IL_407;
					case 22:
						return false;
					case 23:
						num = 33;
						continue;
					case 24:
						if (m.Msg != 256)
						{
							num = 5;
							continue;
						}
						goto IL_3A2;
					case 25:
					{
						bool flag2;
						if (!flag2)
						{
							num = 22;
							continue;
						}
						goto IL_407;
					}
					case 26:
						num = 9;
						continue;
					case 27:
						num = 12;
						continue;
					case 28:
						num = 8;
						continue;
					case 29:
						if (m.Msg != 256)
						{
							return false;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_160;
						default:
							if (false)
							{
							}
							num = 31;
							continue;
						}
						break;
					case 30:
						if (this.Focused)
						{
							num = 14;
							continue;
						}
						return false;
					case 31:
					{
						bool flag = true;
						bool flag2 = true;
						this.a(keys2, ref flag, ref flag2);
						base.ClearSelection();
						base.Invalidate();
						num = 13;
						continue;
					}
					case 32:
						if (base.EditingControl.Enabled)
						{
							num = 27;
							continue;
						}
						goto IL_10C;
					case 33:
					{
						global::System.Windows.Forms.Keys keys;
						switch (keys)
						{
						case global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control:
						case global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Control:
							goto IL_200;
						default:
							num = 26;
							continue;
						}
						break;
					}
					case 34:
						if (keys2 == global::System.Windows.Forms.Keys.Tab)
						{
							num = 20;
							continue;
						}
						goto IL_2A5;
					case 35:
						goto IL_10C;
					}
					if (base.EditingControl != null)
					{
						num = 28;
						continue;
					}
					IL_10C:
					keys2 = (global::System.Windows.Forms.Keys)((int)m.WParam & 65535);
					num = 34;
					continue;
					IL_160:
					if (this.ae != null)
					{
						num = 1;
						continue;
					}
					goto IL_10C;
					IL_200:
					num = 30;
					continue;
					IL_2A5:
					num = 21;
					continue;
					IL_3A2:
					num = 15;
				}
				return true;
				IL_14F:
				IL_407:
				return base.ProcessKeyPreview(ref m);
			}
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00017DFC File Offset: 0x00015FFC
		private static bool b(global::System.Windows.Forms.Keys A_0)
		{
			for (;;)
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_81;
					case 1:
						if (A_0 == (global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Shift))
						{
							if (true)
							{
							}
							num = 0;
							continue;
						}
						return false;
					case 2:
						if (A_0 != global::System.Windows.Forms.Keys.Tab)
						{
							num = 4;
							continue;
						}
						return true;
					case 3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							if (false)
							{
							}
							num = 1;
							continue;
						}
						break;
					case 4:
						num = 5;
						continue;
					case 5:
						switch (A_0)
						{
						case global::System.Windows.Forms.Keys.Left:
						case global::System.Windows.Forms.Keys.Up:
						case global::System.Windows.Forms.Keys.Right:
						case global::System.Windows.Forms.Keys.Down:
							return true;
						default:
							num = 3;
							continue;
						}
						break;
					}
					break;
				}
			}
			return true;
			IL_81:
			return true;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00017EC0 File Offset: 0x000160C0
		private bool a(global::System.Windows.Forms.Keys A_0)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (base.Columns[base.CurrentCell.ColumnIndex] is global::System.Windows.Forms.DataGridViewComboBoxColumn)
					{
						num = 1;
						continue;
					}
					goto IL_D9;
				case 1:
					goto IL_98;
				case 2:
					if (!(base.Columns[base.CurrentCell.ColumnIndex] is global::custom_controls.DataGridViewNumericUpDownColumn))
					{
						num = 4;
						continue;
					}
					return false;
				case 3:
					if (true)
					{
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D9;
					default:
						if (false)
						{
						}
						num = 2;
						continue;
					}
					break;
				case 4:
					num = 0;
					continue;
				}
				if (base.CurrentCell.ReadOnly)
				{
					goto IL_D9;
				}
				num = 3;
			}
			return false;
			IL_98:
			return false;
			IL_D9:
			global::System.Windows.Forms.DataGridViewCell currentCell = this.a(base.CurrentCell.RowIndex, base.CurrentCell.ColumnIndex, A_0 == global::System.Windows.Forms.Keys.Down);
			base.CurrentCell = currentCell;
			base.CurrentCell.Selected = true;
			base.CurrentCell.DataGridView.BeginEdit(false);
			return true;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00017FF0 File Offset: 0x000161F0
		private void a(global::System.Windows.Forms.Keys A_0, ref bool A_1, ref bool A_2)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					bool flag = false;
					bool a_ = true;
					A_2 = true;
					int num = 34;
					for (;;)
					{
						global::System.Windows.Forms.Keys a_2;
						global::System.Windows.Forms.DataGridViewCell dataGridViewCell;
						switch (num)
						{
						case 0:
							a_2 = global::System.Windows.Forms.Keys.Down;
							num = 27;
							continue;
						case 1:
							goto IL_3E4;
						case 2:
							goto IL_FE;
						case 3:
							if (flag)
							{
								num = 0;
								continue;
							}
							a_2 = global::System.Windows.Forms.Keys.Up;
							num = 16;
							continue;
						case 4:
							goto IL_4B4;
						case 5:
							if (A_0 == global::System.Windows.Forms.Keys.Tab)
							{
								num = 41;
								continue;
							}
							num = 42;
							continue;
						case 6:
							if (base.CurrentCell.ReadOnly)
							{
								num = 22;
								continue;
							}
							goto IL_344;
						case 7:
							goto IL_2BD;
						case 8:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_4B4;
							default:
								if (false)
								{
								}
								num = 39;
								continue;
							}
							break;
						case 9:
							if (base.CurrentCell.RowIndex == base.RowCount - 1)
							{
								num = 8;
								continue;
							}
							goto IL_4CD;
						case 10:
							num = 35;
							continue;
						case 11:
							num = 31;
							continue;
						case 12:
							num = 33;
							continue;
						case 13:
							goto IL_331;
						case 14:
							if (A_0 == global::System.Windows.Forms.Keys.Left)
							{
								num = 45;
								continue;
							}
							goto IL_3E4;
						case 15:
							if (A_0 != global::System.Windows.Forms.Keys.Right)
							{
								num = 21;
								continue;
							}
							goto IL_256;
						case 16:
							goto IL_2A8;
						case 17:
							base.CurrentCell = dataGridViewCell;
							num = 32;
							continue;
						case 18:
							num = 5;
							continue;
						case 19:
							goto IL_1A0;
						case 20:
							goto IL_3DF;
						case 21:
							num = 14;
							continue;
						case 22:
							a_ = false;
							num = 1;
							continue;
						case 23:
							num = 44;
							continue;
						case 24:
							goto IL_383;
						case 25:
							num = 9;
							continue;
						case 26:
							num = 30;
							continue;
						case 27:
							goto IL_2A8;
						case 28:
							if (dataGridViewCell.ColumnIndex != -1)
							{
								if (true)
								{
								}
								num = 17;
								continue;
							}
							return;
						case 29:
							goto IL_4CD;
						case 30:
							if (base.Rows[base.CurrentCell.RowIndex].Selected)
							{
								num = 24;
								continue;
							}
							return;
						case 31:
							if (A_0 == (global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Shift))
							{
								num = 13;
								continue;
							}
							goto IL_1A0;
						case 32:
							if (this.CanEditCells)
							{
								num = 23;
								continue;
							}
							return;
						case 33:
							if (A_0 == global::System.Windows.Forms.Keys.Down)
							{
								num = 43;
								continue;
							}
							num = 40;
							continue;
						case 34:
							if (A_0 != global::System.Windows.Forms.Keys.Right)
							{
								num = 18;
								continue;
							}
							goto IL_4A6;
						case 35:
							if (!flag)
							{
								num = 2;
								continue;
							}
							goto IL_283;
						case 36:
							if (base.CurrentCell.RowIndex == 0)
							{
								num = 10;
								continue;
							}
							goto IL_283;
						case 37:
							if (A_0 != global::System.Windows.Forms.Keys.Up)
							{
								num = 12;
								continue;
							}
							goto IL_3B7;
						case 38:
							if (base.CurrentCell.ReadOnly)
							{
								num = 20;
								continue;
							}
							goto IL_49F;
						case 39:
							if (!flag)
							{
								num = 29;
								continue;
							}
							goto IL_FE;
						case 40:
							if (!this.i)
							{
								num = 25;
								continue;
							}
							goto IL_FE;
						case 41:
							goto IL_4A6;
						case 42:
							if (A_0 != global::System.Windows.Forms.Keys.Left)
							{
								num = 11;
								continue;
							}
							goto IL_331;
						case 43:
							goto IL_3B7;
						case 44:
							if (!base.CurrentCell.ReadOnly)
							{
								num = 26;
								continue;
							}
							return;
						case 45:
							goto IL_256;
						}
						break;
						IL_FE:
						dataGridViewCell = this.a(base.CurrentCell.RowIndex, base.CurrentCell.ColumnIndex, flag, a_, ref A_1);
						num = 28;
						continue;
						IL_1A0:
						num = 15;
						continue;
						IL_4B4:
						goto IL_1A0;
						IL_256:
						num = 6;
						continue;
						IL_283:
						a_2 = global::System.Windows.Forms.Keys.None;
						num = 3;
						continue;
						IL_2A8:
						A_1 = this.a(a_2);
						num = 7;
						continue;
						IL_331:
						flag = false;
						num = 19;
						continue;
						IL_3B7:
						num = 38;
						continue;
						IL_3E4:
						num = 37;
						continue;
						IL_4A6:
						flag = true;
						num = 4;
						continue;
						IL_4CD:
						num = 36;
					}
				}
				IL_2BD:
				return;
				IL_344:
				A_1 = false;
				A_2 = false;
				return;
				IL_383:
				base.CurrentCell.DataGridView.BeginEdit(false);
				return;
				IL_3DF:
				A_1 = this.a(A_0);
				A_2 = false;
				return;
				IL_49F:
				A_1 = false;
				A_2 = false;
				return;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000184F8 File Offset: 0x000166F8
		public void FindFirstCell(ref global::System.Windows.Forms.DataGridViewCell startCell)
		{
			for (;;)
			{
				int num = base.RowCount - 1;
				int num2 = base.ColumnCount - 1;
				bool flag = false;
				startCell = base.Rows[0].Cells[0];
				int num3 = 18;
				for (;;)
				{
					bool flag2;
					switch (num3)
					{
					case 0:
						flag2 = (startCell.ColumnIndex == num2);
						goto IL_1C8;
					case 1:
						num3 = 5;
						continue;
					case 2:
						if (startCell.ReadOnly)
						{
							num3 = 8;
							continue;
						}
						goto IL_10A;
					case 3:
						if (flag)
						{
							num3 = 11;
							continue;
						}
						num3 = 19;
						continue;
					case 4:
						if (startCell.RowIndex != num)
						{
							num3 = 21;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22D;
						default:
							if (false)
							{
							}
							num3 = 12;
							continue;
						}
						break;
					case 5:
						if (true)
						{
						}
						if (!this.CanEditCells)
						{
							goto IL_22D;
						}
						num3 = 4;
						continue;
					case 6:
						goto IL_10A;
					case 7:
						startCell = base.Rows[startCell.RowIndex + 1].Cells[0];
						num3 = 14;
						continue;
					case 8:
						num3 = 24;
						continue;
					case 9:
						num3 = 23;
						continue;
					case 10:
						if (startCell.RowIndex <= num)
						{
							num3 = 9;
							continue;
						}
						goto IL_16E;
					case 11:
						startCell = base.Rows[0].Cells[0];
						num3 = 20;
						continue;
					case 12:
						num3 = 0;
						continue;
					case 13:
						num3 = 15;
						continue;
					case 14:
						goto IL_D8;
					case 15:
						if (startCell.ColumnIndex <= num2)
						{
							num3 = 1;
							continue;
						}
						goto IL_10A;
					case 16:
						goto IL_16E;
					case 17:
						return;
					case 18:
						goto IL_D8;
					case 19:
						if (startCell.ColumnIndex == num2)
						{
							num3 = 7;
							continue;
						}
						startCell = base.Rows[startCell.RowIndex].Cells[startCell.ColumnIndex + 1];
						num3 = 22;
						continue;
					case 20:
						goto IL_10A;
					case 21:
						flag2 = false;
						goto IL_1C8;
					case 22:
						goto IL_D8;
					case 23:
						if (startCell.ColumnIndex > num2)
						{
							num3 = 16;
							continue;
						}
						return;
					case 24:
						if (startCell.RowIndex <= num)
						{
							num3 = 13;
							continue;
						}
						goto IL_10A;
					}
					break;
					IL_D8:
					num3 = 2;
					continue;
					IL_10A:
					num3 = 10;
					continue;
					IL_16E:
					startCell = base.Rows[0].Cells[0];
					num3 = 17;
					continue;
					IL_1C8:
					flag = flag2;
					num3 = 3;
					continue;
					IL_22D:
					num3 = 6;
				}
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0001880C File Offset: 0x00016A0C
		private global::System.Windows.Forms.DataGridViewCell a(int A_0, int A_1, bool A_2, bool A_3, ref bool A_4)
		{
			switch (0)
			{
			default:
			{
				global::System.Windows.Forms.DataGridViewCell dataGridViewCell;
				global::System.Windows.Forms.DataGridViewCell result;
				for (;;)
				{
					int num = base.RowCount - 1;
					int num2 = base.ColumnCount - 1;
					bool flag = false;
					bool flag2 = false;
					dataGridViewCell = base.Rows[A_0].Cells[A_1];
					result = dataGridViewCell;
					A_4 = true;
					int num3 = 31;
					for (;;)
					{
						bool flag3;
						bool flag4;
						switch (num3)
						{
						case 0:
							num3 = 17;
							continue;
						case 1:
							dataGridViewCell = base.Rows[dataGridViewCell.RowIndex + 1].Cells[0];
							num3 = 8;
							continue;
						case 2:
							if (!A_2)
							{
								num3 = 4;
								continue;
							}
							goto IL_3CA;
						case 3:
							flag3 = (dataGridViewCell.ColumnIndex == 0);
							goto IL_2D9;
						case 4:
							num3 = 6;
							continue;
						case 5:
							goto IL_252;
						case 6:
							if (flag)
							{
								num3 = 11;
								continue;
							}
							goto IL_3CA;
						case 7:
							num3 = 3;
							continue;
						case 8:
							goto IL_252;
						case 9:
							num3 = 15;
							continue;
						case 10:
							goto IL_252;
						case 11:
							goto IL_1ED;
						case 12:
							goto IL_20C;
						case 13:
							num3 = 21;
							continue;
						case 14:
							if (!A_3)
							{
								num3 = 12;
								continue;
							}
							goto IL_118;
						case 15:
							if (!flag2)
							{
								num3 = 16;
								continue;
							}
							goto IL_1ED;
						case 16:
							goto IL_28D;
						case 17:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_12B;
							default:
								if (false)
								{
								}
								if (dataGridViewCell.ColumnIndex == num2)
								{
									num3 = 1;
									continue;
								}
								dataGridViewCell = base.Rows[dataGridViewCell.RowIndex].Cells[dataGridViewCell.ColumnIndex + 1];
								num3 = 22;
								continue;
							}
							break;
						case 18:
							flag4 = false;
							goto IL_304;
						case 19:
							flag3 = false;
							goto IL_2D9;
						case 20:
							if (A_2)
							{
								num3 = 9;
								continue;
							}
							goto IL_28D;
						case 21:
							if (dataGridViewCell.ColumnIndex == 0)
							{
								num3 = 30;
								continue;
							}
							dataGridViewCell = base.Rows[dataGridViewCell.RowIndex].Cells[dataGridViewCell.ColumnIndex - 1];
							num3 = 10;
							continue;
						case 22:
							goto IL_252;
						case 23:
							return dataGridViewCell;
						case 24:
							if (dataGridViewCell.RowIndex == 0)
							{
								num3 = 7;
								continue;
							}
							num3 = 19;
							continue;
						case 25:
							if (A_2)
							{
								num3 = 0;
								continue;
							}
							num3 = 28;
							continue;
						case 26:
							goto IL_12B;
						case 27:
							num3 = 26;
							continue;
						case 28:
							if (!A_2)
							{
								num3 = 13;
								continue;
							}
							goto IL_252;
						case 29:
							if (true)
							{
							}
							if (!dataGridViewCell.ReadOnly)
							{
								num3 = 23;
								continue;
							}
							goto IL_2B0;
						case 30:
							dataGridViewCell = base.Rows[dataGridViewCell.RowIndex - 1].Cells[num2];
							num3 = 5;
							continue;
						case 31:
							goto IL_2B0;
						case 32:
							if (dataGridViewCell.RowIndex == num)
							{
								num3 = 27;
								continue;
							}
							num3 = 18;
							continue;
						}
						break;
						IL_1ED:
						num3 = 14;
						continue;
						IL_252:
						num3 = 29;
						continue;
						IL_28D:
						num3 = 2;
						continue;
						IL_2B0:
						num3 = 24;
						continue;
						IL_2D9:
						flag = flag3;
						num3 = 32;
						continue;
						IL_304:
						flag2 = flag4;
						num3 = 20;
						continue;
						IL_12B:
						flag4 = (dataGridViewCell.ColumnIndex == num2);
						goto IL_304;
						IL_3CA:
						num3 = 25;
					}
				}
				IL_118:
				A_4 = false;
				return dataGridViewCell;
				IL_20C:
				A_4 = true;
				return result;
			}
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00018C24 File Offset: 0x00016E24
		private global::System.Windows.Forms.DataGridViewCell a(int A_0, int A_1, bool A_2)
		{
			switch (0)
			{
			default:
			{
				global::System.Windows.Forms.DataGridViewCell dataGridViewCell2;
				for (;;)
				{
					int num = base.RowCount - 1;
					bool flag = false;
					bool flag2 = false;
					global::System.Windows.Forms.DataGridViewCell dataGridViewCell = base.Rows[A_0].Cells[A_1];
					dataGridViewCell2 = dataGridViewCell;
					int num2 = 18;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (A_1 == -1)
							{
								num2 = 7;
								continue;
							}
							goto IL_111;
						case 1:
							num2 = 0;
							continue;
						case 2:
							goto IL_111;
						case 3:
							if (flag)
							{
								num2 = 5;
								continue;
							}
							goto IL_1A4;
						case 4:
							if (A_2)
							{
								num2 = 13;
								continue;
							}
							goto IL_1EC;
						case 5:
							goto IL_EA;
						case 6:
							if (!flag2)
							{
								num2 = 11;
								continue;
							}
							goto IL_EA;
						case 7:
							dataGridViewCell = base.Rows[0].Cells[0];
							num2 = 2;
							continue;
						case 8:
							goto IL_1C4;
						case 9:
							if (A_2)
							{
								num2 = 17;
								continue;
							}
							num2 = 19;
							continue;
						case 10:
							num2 = 3;
							continue;
						case 11:
							goto IL_1EC;
						case 12:
							goto IL_1C4;
						case 13:
							num2 = 6;
							continue;
						case 14:
							if (!A_2)
							{
								num2 = 10;
								continue;
							}
							goto IL_1A4;
						case 15:
							return dataGridViewCell;
						case 16:
							if (!dataGridViewCell.ReadOnly)
							{
								num2 = 15;
								continue;
							}
							goto IL_111;
						case 17:
							dataGridViewCell = base.Rows[dataGridViewCell.RowIndex + 1].Cells[dataGridViewCell2.ColumnIndex];
							num2 = 12;
							continue;
						case 18:
							if (A_0 == -1)
							{
								num2 = 1;
								continue;
							}
							goto IL_111;
						case 19:
							if (!A_2)
							{
								num2 = 20;
								continue;
							}
							goto IL_1C4;
						case 20:
							dataGridViewCell = base.Rows[dataGridViewCell.RowIndex - 1].Cells[dataGridViewCell2.ColumnIndex];
							goto IL_16D;
						}
						break;
						IL_111:
						flag = (dataGridViewCell.RowIndex == 0);
						flag2 = (dataGridViewCell.RowIndex == num);
						num2 = 4;
						continue;
						IL_16D:
						num2 = 8;
						continue;
						IL_EA:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16D;
						default:
							goto IL_100;
						}
						IL_1A4:
						num2 = 9;
						continue;
						IL_1C4:
						num2 = 16;
						continue;
						IL_1EC:
						num2 = 14;
					}
				}
				IL_100:
				if (true)
				{
				}
				if (false)
				{
				}
				return dataGridViewCell2;
			}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00018ED0 File Offset: 0x000170D0
		protected override void Select(bool directed, bool forward)
		{
			int num = 1;
			global::System.Windows.Forms.Control nextControl;
			for (;;)
			{
				int num2;
				global::System.Windows.Forms.DataGridViewCell dataGridViewCell;
				switch (num)
				{
				case 0:
					goto IL_4CF;
				case 2:
					if (!(!nextControl.TabStop | !nextControl.Visible | !nextControl.Enabled))
					{
						num = 11;
						continue;
					}
					num = 34;
					continue;
				case 3:
					num2 = 0;
					num = 6;
					continue;
				case 4:
					base.Rows[0].Selected = true;
					num = 18;
					continue;
				case 5:
					base.Rows[0].Selected = true;
					num = 67;
					continue;
				case 6:
					goto IL_287;
				case 7:
					num = 59;
					continue;
				case 8:
					goto IL_7B1;
				case 9:
					nextControl = base.Parent.GetNextControl(this, forward);
					num = 53;
					continue;
				case 10:
					if (nextControl != null)
					{
						num = 68;
						continue;
					}
					goto IL_48F;
				case 11:
					goto IL_4FA;
				case 12:
					goto IL_7AC;
				case 13:
					num = 72;
					continue;
				case 14:
					goto IL_48F;
				case 15:
					num = 24;
					continue;
				case 16:
					if (this.af != null)
					{
						num = 25;
						continue;
					}
					goto IL_25E;
				case 17:
					if (!nextControl.Visible)
					{
						num = 14;
						continue;
					}
					goto IL_4CF;
				case 18:
					goto IL_2B3;
				case 19:
					num = 17;
					continue;
				case 20:
					goto IL_287;
				case 21:
					goto IL_4CF;
				case 22:
					if (nextControl != null)
					{
						num = 36;
						continue;
					}
					goto IL_4CF;
				case 23:
					base.Rows[0].Selected = true;
					num = 12;
					continue;
				case 24:
					if (!this.Focused)
					{
						num = 42;
						continue;
					}
					goto IL_152;
				case 25:
					this.af(this, new global::System.Windows.Forms.DataGridViewCellEventArgs(base.CurrentCell.ColumnIndex, base.CurrentCell.RowIndex));
					num = 27;
					continue;
				case 26:
					num = 69;
					continue;
				case 27:
					goto IL_54D;
				case 28:
					base.Focus();
					num = 39;
					continue;
				case 29:
					if (nextControl.TabStop)
					{
						num = 7;
						continue;
					}
					goto IL_48F;
				case 30:
					if (!base.Rows[0].Selected)
					{
						num = 5;
						continue;
					}
					goto IL_42F;
				case 31:
					if (base.RowCount <= 0)
					{
						num = 47;
						continue;
					}
					num = 35;
					continue;
				case 32:
					if (this.af != null)
					{
						num = 58;
						continue;
					}
					goto IL_7B1;
				case 33:
					if (!dataGridViewCell.ReadOnly)
					{
						num = 38;
						continue;
					}
					num = 63;
					continue;
				case 34:
					if (nextControl.Controls.Count > 0)
					{
						num = 3;
						continue;
					}
					nextControl = base.Parent.GetNextControl(nextControl, forward);
					num = 21;
					continue;
				case 35:
					if (this.CanEditCells)
					{
						num = 40;
						continue;
					}
					num = 45;
					continue;
				case 36:
					num = 10;
					continue;
				case 37:
					if (nextControl != null)
					{
						num = 60;
						continue;
					}
					goto IL_4FA;
				case 38:
					base.CurrentCell = dataGridViewCell;
					num = 16;
					continue;
				case 39:
					goto IL_60A;
				case 40:
					num = 71;
					continue;
				case 41:
					if (nextControl != null)
					{
						num = 49;
						continue;
					}
					goto IL_3EF;
				case 42:
					base.Focus();
					num = 61;
					continue;
				case 43:
					if (base.ContainsFocus)
					{
						num = 26;
						continue;
					}
					goto IL_60A;
				case 44:
					num = 30;
					continue;
				case 45:
					if (base.Rows.Count > 0)
					{
						num = 13;
						continue;
					}
					goto IL_2B3;
				case 46:
					if (!base.Rows[0].Selected)
					{
						num = 23;
						continue;
					}
					goto IL_854;
				case 47:
					goto IL_552;
				case 48:
					base.Rows[0].Selected = true;
					num = 55;
					continue;
				case 49:
					goto IL_516;
				case 50:
					this.af(this, new global::System.Windows.Forms.DataGridViewCellEventArgs(base.CurrentCell.ColumnIndex, base.CurrentCell.RowIndex));
					num = 65;
					continue;
				case 51:
					if (!base.Rows[0].Selected)
					{
						num = 48;
						continue;
					}
					goto IL_5E4;
				case 52:
					if (num2 >= nextControl.Controls.Count)
					{
						num = 56;
						continue;
					}
					nextControl = nextControl.GetNextControl(nextControl.Controls[num2], forward);
					num = 22;
					continue;
				case 53:
					goto IL_4CF;
				case 54:
					num = 31;
					continue;
				case 55:
					goto IL_3EA;
				case 56:
					num = 0;
					continue;
				case 57:
					if (base.ContainsFocus)
					{
						num = 15;
						continue;
					}
					goto IL_152;
				case 58:
					this.af(this, new global::System.Windows.Forms.DataGridViewCellEventArgs(base.CurrentCell.ColumnIndex, base.CurrentCell.RowIndex));
					num = 8;
					continue;
				case 59:
					if (nextControl.Enabled)
					{
						num = 19;
						continue;
					}
					goto IL_48F;
				case 60:
					num = 2;
					continue;
				case 61:
					goto IL_152;
				case 62:
					goto IL_80E;
				case 63:
					if (base.Rows.Count > 0)
					{
						goto IL_194;
					}
					goto IL_42F;
				case 64:
					if (base.ContainsFocus)
					{
						num = 9;
						continue;
					}
					goto IL_310;
				case 65:
					goto IL_2D9;
				case 66:
					if (this.af != null)
					{
						num = 50;
						continue;
					}
					goto IL_2D9;
				case 67:
					goto IL_42F;
				case 68:
					num = 29;
					continue;
				case 69:
					if (!this.Focused)
					{
						num = 28;
						continue;
					}
					goto IL_60A;
				case 70:
					base.Focus();
					num = 62;
					continue;
				case 71:
					if (this.Focused)
					{
						goto IL_80E;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_194;
					default:
						if (false)
						{
						}
						num = 70;
						continue;
					}
					break;
				case 72:
					if (!base.Rows[0].Selected)
					{
						num = 4;
						continue;
					}
					goto IL_2B3;
				}
				if (!base.ContainsFocus)
				{
					num = 54;
					continue;
				}
				goto IL_552;
				IL_152:
				num = 32;
				continue;
				IL_194:
				num = 44;
				continue;
				IL_287:
				num = 52;
				continue;
				IL_2B3:
				num = 43;
				continue;
				IL_2D9:
				base.ClearSelection();
				num = 46;
				continue;
				IL_42F:
				num = 57;
				continue;
				IL_48F:
				num2++;
				num = 20;
				continue;
				IL_4CF:
				num = 37;
				continue;
				IL_4FA:
				num = 41;
				continue;
				IL_552:
				num = 64;
				continue;
				IL_60A:
				num = 66;
				continue;
				IL_7B1:
				base.ClearSelection();
				num = 51;
				continue;
				IL_80E:
				dataGridViewCell = base.Rows[0].Cells[0];
				this.FindFirstCell(ref dataGridViewCell);
				num = 33;
			}
			IL_25E:
			base.CurrentCell.DataGridView.BeginEdit(false);
			base.ClearSelection();
			base.Invalidate();
			return;
			IL_310:
			base.Select(directed, forward);
			return;
			IL_3EA:
			goto IL_5E4;
			IL_3EF:
			if (true)
			{
			}
			base.TopLevelControl.SelectNextControl(this, forward, true, true, true);
			return;
			IL_516:
			nextControl.Focus();
			return;
			IL_54D:
			goto IL_25E;
			IL_5E4:
			base.Invalidate();
			base.Select(directed, forward);
			return;
			IL_7AC:
			IL_854:
			base.Invalidate();
			base.Select(directed, forward);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00019740 File Offset: 0x00017940
		private void b(object A_0, global::System.EventArgs A_1)
		{
			int num = 6;
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
						return;
					default:
						if (false)
						{
						}
						if (this.w != null)
						{
							num = 4;
							continue;
						}
						return;
					}
					break;
				case 2:
				{
					global::custom_controls.CCustomDataGridView.ComboItem item = (global::custom_controls.CCustomDataGridView.ComboItem)((global::System.Windows.Forms.DataGridViewComboBoxEditingControl)A_0).SelectedItem;
					num = 1;
					continue;
				}
				case 3:
					if (((global::System.Windows.Forms.DataGridViewComboBoxEditingControl)A_0).SelectedItem != null)
					{
						num = 2;
						continue;
					}
					return;
				case 4:
				{
					if (true)
					{
					}
					global::custom_controls.CCustomDataGridView.ComboItem item;
					this.w(this, item, new global::System.Windows.Forms.DataGridViewCellEventArgs(base.CurrentCell.ColumnIndex, base.CurrentCell.RowIndex));
					num = 0;
					continue;
				}
				case 5:
					num = 3;
					continue;
				}
				if ((global::System.Windows.Forms.DataGridViewComboBoxEditingControl)A_0 == null)
				{
					break;
				}
				num = 5;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00019850 File Offset: 0x00017A50
		private void a(object A_0, global::System.Windows.Forms.DataGridViewEditingControlShowingEventArgs A_1)
		{
			int num = 9;
			global::custom_controls.DataGridViewCustTextBoxEditingControl dataGridViewCustTextBoxEditingControl;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (A_1.Control is global::custom_controls.DataGridViewCustTextBoxEditingControl)
					{
						num = 5;
						continue;
					}
					num = 14;
					continue;
				case 1:
					num = 18;
					continue;
				case 2:
					if (base.Columns[base.CurrentCell.ColumnIndex].Name == "AESPRI_PKEY")
					{
						num = 10;
						continue;
					}
					goto IL_2EC;
				case 3:
					dataGridViewCustTextBoxEditingControl.IsValidChars = true;
					dataGridViewCustTextBoxEditingControl.ConvertToUpperCase = true;
					dataGridViewCustTextBoxEditingControl.RestrictedChars = "0123456789abcdefABCDEF";
					dataGridViewCustTextBoxEditingControl.HiddenEnabled = true;
					dataGridViewCustTextBoxEditingControl.HiddenSymbol = "⃠";
					dataGridViewCustTextBoxEditingControl.HiddenValue = "FFFFFFFFFF";
					dataGridViewCustTextBoxEditingControl.Text = base.CurrentCell.Value.ToString();
					num = 17;
					continue;
				case 4:
					goto IL_F0;
				case 5:
					dataGridViewCustTextBoxEditingControl = (A_1.Control as global::custom_controls.DataGridViewCustTextBoxEditingControl);
					num = 8;
					continue;
				case 6:
					if (A_1.Control != null)
					{
						num = 1;
						continue;
					}
					return;
				case 7:
					goto IL_357;
				case 8:
					goto IL_396;
				case 10:
					dataGridViewCustTextBoxEditingControl.IsValidChars = true;
					dataGridViewCustTextBoxEditingControl.ConvertToUpperCase = true;
					dataGridViewCustTextBoxEditingControl.RestrictedChars = "0123456789abcdefABCDEF";
					dataGridViewCustTextBoxEditingControl.HiddenEnabled = true;
					dataGridViewCustTextBoxEditingControl.HiddenSymbol = "⃠";
					dataGridViewCustTextBoxEditingControl.HiddenValue = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
					dataGridViewCustTextBoxEditingControl.Text = base.CurrentCell.Value.ToString();
					num = 4;
					continue;
				case 11:
					if (base.Columns[base.CurrentCell.ColumnIndex].Name == "RASDATA_RASKEY")
					{
						num = 12;
						continue;
					}
					num = 2;
					continue;
				case 12:
					dataGridViewCustTextBoxEditingControl.HiddenEnabled = true;
					dataGridViewCustTextBoxEditingControl.HiddenSymbol = "⃠";
					dataGridViewCustTextBoxEditingControl.HiddenValue = "0";
					dataGridViewCustTextBoxEditingControl.Text = base.CurrentCell.Value.ToString();
					num = 7;
					continue;
				case 13:
					goto IL_260;
				case 14:
					if (A_1.Control is global::custom_controls.DataGridViewNumericUpDownEditingControl)
					{
						num = 19;
						continue;
					}
					return;
				case 15:
					goto IL_1CA;
				case 16:
					num = 6;
					continue;
				case 17:
					goto IL_2BC;
				case 18:
					if (A_1.Control is global::System.Windows.Forms.DataGridViewComboBoxEditingControl)
					{
						num = 15;
						continue;
					}
					num = 0;
					continue;
				case 19:
				{
					global::custom_controls.DataGridViewNumericUpDownEditingControl dataGridViewNumericUpDownEditingControl = A_1.Control as global::custom_controls.DataGridViewNumericUpDownEditingControl;
					dataGridViewNumericUpDownEditingControl.EditingControlFormattedValue = base.CurrentCell.Value;
					dataGridViewNumericUpDownEditingControl.DisableEnableCellsEdit -= this.a;
					dataGridViewNumericUpDownEditingControl.DisableEnableCellsEdit += this.a;
					num = 13;
					continue;
				}
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_396:
					if (base.Columns[base.CurrentCell.ColumnIndex].Name == "ENHPRI_PKEY")
					{
						num = 3;
					}
					else
					{
						num = 11;
					}
					break;
				default:
					if (false)
					{
					}
					if (A_1 == null)
					{
						return;
					}
					num = 16;
					break;
				}
			}
			IL_F0:
			goto IL_2EC;
			IL_1CA:
			global::System.Windows.Forms.DataGridViewComboBoxEditingControl dataGridViewComboBoxEditingControl = A_1.Control as global::System.Windows.Forms.DataGridViewComboBoxEditingControl;
			dataGridViewComboBoxEditingControl.EditingControlFormattedValue = base.CurrentCell.Value;
			dataGridViewComboBoxEditingControl.SelectedIndexChanged -= this.b;
			dataGridViewComboBoxEditingControl.SelectedIndexChanged += this.b;
			return;
			IL_260:
			return;
			IL_2BC:
			IL_2EC:
			if (true)
			{
			}
			dataGridViewCustTextBoxEditingControl.DisableEnableCellsEdit -= this.a;
			dataGridViewCustTextBoxEditingControl.DisableEnableCellsEdit += this.a;
			return;
			IL_357:
			goto IL_2EC;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00019C30 File Offset: 0x00017E30
		private void a(object A_0, global::System.EventArgs A_1)
		{
			int num = 8;
			for (;;)
			{
				switch (num)
				{
				case 0:
					num = 1;
					continue;
				case 1:
					if (base.EditingControl.Focused)
					{
						num = 7;
						continue;
					}
					return;
				case 2:
					this.ae(this, new global::System.EventArgs());
					num = 5;
					continue;
				case 3:
					if (base.EditingControl.Enabled)
					{
						if (true)
						{
						}
						num = 6;
						continue;
					}
					return;
				case 4:
					goto IL_6D;
				case 5:
					return;
				case 6:
					num = 4;
					continue;
				case 7:
					num = 3;
					continue;
				case 8:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6D;
					default:
						if (false)
						{
						}
						break;
					}
					break;
				}
				if (base.EditingControl != null)
				{
					num = 0;
					continue;
				}
				break;
				IL_6D:
				if (this.ae == null)
				{
					break;
				}
				num = 2;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00019D38 File Offset: 0x00017F38
		public bool DoesValueMatch(string valueToCompare, int rowIndex, int columnIndex, bool caseSensitive = true)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				bool result = false;
				string text = string.Empty;
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)base.Rows).GetEnumerator();
				try
				{
					int num = 4;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							if (caseSensitive)
							{
								num = 1;
								continue;
							}
							bool flag = text.Equals(valueToCompare, global::System.StringComparison.OrdinalIgnoreCase);
							num = 6;
							continue;
						}
						case 1:
						{
							bool flag = text.Equals(valueToCompare);
							num = 5;
							continue;
						}
						case 2:
							result = true;
							num = 10;
							continue;
						case 3:
						{
							bool flag;
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow;
							if (flag & rowIndex != dataGridViewRow.Index)
							{
								num = 2;
								continue;
							}
							break;
						}
						case 5:
							goto IL_107;
						case 6:
							goto IL_107;
						case 7:
						{
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow;
							text = ((global::custom_controls.CCustomDataGridViewRow)dataGridViewRow).Cells[columnIndex].Value.ToString();
							num = 0;
							continue;
						}
						case 8:
						{
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow;
							if (((global::custom_controls.CCustomDataGridViewRow)dataGridViewRow).Cells[columnIndex].Value != null)
							{
								num = 7;
								continue;
							}
							break;
						}
						case 9:
							goto IL_184;
						case 10:
							goto IL_184;
						case 11:
							goto IL_190;
						case 12:
						{
							if (!enumerator.MoveNext())
							{
								num = 9;
								continue;
							}
							global::System.Windows.Forms.DataGridViewRow dataGridViewRow = (global::System.Windows.Forms.DataGridViewRow)enumerator.Current;
							num = 8;
							continue;
						}
						}
						goto IL_73;
						IL_107:
						num = 3;
						continue;
						IL_131:
						num = 12;
						continue;
						IL_73:
						goto IL_131;
						IL_184:
						num = 11;
					}
					IL_190:;
				}
				finally
				{
					for (;;)
					{
						global::System.IDisposable disposable = enumerator as global::System.IDisposable;
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
									goto IL_1B9;
								default:
									goto IL_1EE;
								}
								break;
							case 1:
								goto IL_1B9;
							case 2:
								disposable.Dispose();
								num = 0;
								continue;
							}
							break;
							IL_1B9:
							if (disposable == null)
							{
								goto IL_1F6;
							}
							num = 2;
						}
					}
					IL_1EE:
					if (false)
					{
					}
					IL_1F6:;
				}
				return result;
			}
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00019F64 File Offset: 0x00018164
		public global::System.Windows.Forms.DataGridViewColumn GetColumnByName(string columnName)
		{
			switch (0)
			{
			default:
			{
				global::System.Windows.Forms.DataGridViewColumn result;
				global::System.Collections.IEnumerator enumerator2;
				for (;;)
				{
					IL_2F:
					result = null;
					if (true)
					{
					}
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_B1;
						case 1:
							num = 5;
							continue;
						case 2:
							if (!string.IsNullOrEmpty(columnName))
							{
								num = 1;
								continue;
							}
							return result;
						case 3:
							goto IL_97;
						case 4:
						{
							global::System.Collections.IEnumerator enumerator = base.Columns.GetEnumerator();
							num = 0;
							continue;
						}
						case 5:
							if (columnName != "ALIAS")
							{
								num = 4;
								continue;
							}
							enumerator2 = base.Columns.GetEnumerator();
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2F;
							}
							if (false)
							{
							}
							num = 3;
							continue;
						}
						break;
					}
				}
				IL_97:
				try
				{
					int num = 8;
					for (;;)
					{
						switch (num)
						{
						case 0:
							num = 7;
							continue;
						case 1:
						{
							if (!enumerator2.MoveNext())
							{
								num = 4;
								continue;
							}
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn = (global::System.Windows.Forms.DataGridViewColumn)enumerator2.Current;
							num = 2;
							continue;
						}
						case 2:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							if (dataGridViewColumn.Tag != null)
							{
								num = 0;
								continue;
							}
							break;
						}
						case 3:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							result = dataGridViewColumn;
							num = 5;
							continue;
						}
						case 4:
							goto IL_195;
						case 5:
							goto IL_195;
						case 6:
							goto IL_1A1;
						case 7:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn;
							if (columnName.Equals(dataGridViewColumn.Tag.ToString()))
							{
								num = 3;
								continue;
							}
							break;
						}
						}
						IL_14B:
						num = 1;
						continue;
						goto IL_14B;
						IL_195:
						num = 6;
					}
					IL_1A1:
					return result;
				}
				finally
				{
					for (;;)
					{
						global::System.IDisposable disposable = enumerator2 as global::System.IDisposable;
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
								goto IL_1EE;
							case 2:
								goto IL_1EC;
							}
							break;
						}
					}
					IL_1EC:
					IL_1EE:;
				}
				IL_B1:
				try
				{
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = 1;
								continue;
							}
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn2 = (global::System.Windows.Forms.DataGridViewColumn)enumerator.Current;
							num = 4;
							continue;
						}
						case 1:
							goto IL_276;
						case 2:
							goto IL_276;
						case 4:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn2;
							if (columnName.Equals(dataGridViewColumn2.Name))
							{
								num = 5;
								continue;
							}
							break;
						}
						case 5:
						{
							global::System.Windows.Forms.DataGridViewColumn dataGridViewColumn2;
							result = dataGridViewColumn2;
							num = 2;
							continue;
						}
						case 6:
							goto IL_282;
						}
						IL_25A:
						num = 0;
						continue;
						goto IL_25A;
						IL_276:
						num = 6;
					}
					IL_282:;
				}
				finally
				{
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						global::System.IDisposable disposable2 = enumerator as global::System.IDisposable;
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (disposable2 != null)
								{
									num = 2;
									continue;
								}
								goto IL_2CB;
							case 1:
								goto IL_2C9;
							case 2:
								disposable2.Dispose();
								num = 1;
								continue;
							}
							break;
						}
					}
					IL_2C9:
					IL_2CB:;
				}
				return result;
			}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0001A25C File Offset: 0x0001845C
		public void SortByColumn(string columnName)
		{
			global::System.Windows.Forms.DataGridViewColumn sortedColumn = base.SortedColumn;
			try
			{
				int num = 3;
				for (;;)
				{
					global::System.Windows.Forms.DataGridViewColumn columnByName;
					global::System.ComponentModel.ListSortDirection listSortDirection;
					switch (num)
					{
					case 0:
						goto IL_17C;
					case 1:
						columnByName.HeaderCell.SortGlyphDirection = ((listSortDirection == global::System.ComponentModel.ListSortDirection.Ascending) ? global::System.Windows.Forms.SortOrder.Ascending : global::System.Windows.Forms.SortOrder.Descending);
						num = 0;
						continue;
					case 2:
						num = 5;
						continue;
					case 4:
						if (!(sortedColumn.Name == columnName))
						{
							goto IL_90;
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
							num = 7;
							continue;
						}
						break;
					case 5:
						if (base.SortOrder == global::System.Windows.Forms.SortOrder.Ascending)
						{
							num = 15;
							continue;
						}
						goto IL_10D;
					case 6:
						if (columnByName != null)
						{
							num = 10;
							continue;
						}
						goto IL_17C;
					case 7:
						num = 14;
						continue;
					case 8:
						listSortDirection = global::System.ComponentModel.ListSortDirection.Descending;
						num = 13;
						continue;
					case 9:
						goto IL_18E;
					case 10:
						this.Sort(columnByName, listSortDirection);
						num = 1;
						continue;
					case 11:
						goto IL_EA;
					case 12:
						goto IL_EA;
					case 13:
						goto IL_EA;
					case 14:
						if (base.SortOrder == global::System.Windows.Forms.SortOrder.Ascending)
						{
							num = 8;
							continue;
						}
						goto IL_90;
					case 15:
						num = 4;
						continue;
					}
					if (sortedColumn != null)
					{
						num = 2;
						continue;
					}
					goto IL_10D;
					IL_90:
					listSortDirection = global::System.ComponentModel.ListSortDirection.Ascending;
					sortedColumn.HeaderCell.SortGlyphDirection = global::System.Windows.Forms.SortOrder.None;
					num = 11;
					continue;
					IL_EA:
					columnByName = this.GetColumnByName(columnName);
					num = 6;
					continue;
					IL_10D:
					listSortDirection = global::System.ComponentModel.ListSortDirection.Ascending;
					num = 12;
					continue;
					IL_17C:
					this.g = global::System.Windows.Forms.SortOrder.None;
					num = 9;
				}
				IL_18E:;
			}
			catch (global::System.Exception)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0001A42C File Offset: 0x0001862C
		public void SortByType()
		{
			for (;;)
			{
				global::System.Windows.Forms.DataGridViewColumn sortedColumn = base.SortedColumn;
				int num = 6;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_E7;
					case 1:
						num = 3;
						continue;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A2;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							this.g = global::System.Windows.Forms.SortOrder.Ascending;
							num = 9;
							continue;
						}
						break;
					case 3:
						if (this.g == global::System.Windows.Forms.SortOrder.None)
						{
							goto IL_A2;
						}
						num = 7;
						continue;
					case 4:
						goto IL_103;
					case 5:
						this.g = global::System.Windows.Forms.SortOrder.Descending;
						num = 10;
						continue;
					case 6:
						if (sortedColumn == null)
						{
							num = 1;
							continue;
						}
						goto IL_E7;
					case 7:
						if (this.g == global::System.Windows.Forms.SortOrder.Ascending)
						{
							num = 5;
							continue;
						}
						num = 8;
						continue;
					case 8:
						if (this.g == global::System.Windows.Forms.SortOrder.Descending)
						{
							num = 2;
							continue;
						}
						goto IL_119;
					case 9:
						goto IL_E5;
					case 10:
						goto IL_117;
					}
					break;
					IL_A2:
					num = 0;
					continue;
					IL_E7:
					this.g = global::System.Windows.Forms.SortOrder.Ascending;
					num = 4;
				}
			}
			IL_E5:
			IL_103:
			IL_117:
			IL_119:
			this.Sort(new global::custom_controls.CDataGridViewRowComparer(this.g));
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0001A564 File Offset: 0x00018764
		protected override void OnEnter(global::System.EventArgs e)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Windows.Forms.ScrollableControl scrollableControl = null;
					global::System.Windows.Forms.Control parent = base.Parent;
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (true)
							{
							}
							goto IL_107;
						case 1:
							goto IL_64;
						case 2:
						{
							global::System.Drawing.Point autoScrollPosition = scrollableControl.AutoScrollPosition;
							global::custom_controls.CCustomDataGridView.a method = new global::custom_controls.CCustomDataGridView.a(this.a);
							object[] args = new object[]
							{
								scrollableControl,
								autoScrollPosition
							};
							base.BeginInvoke(method, args);
							num = 6;
							continue;
						}
						case 3:
							if (!(parent.Parent is global::custom_controls.CPanelTemplate))
							{
								num = 1;
								continue;
							}
							goto IL_AB;
						case 4:
							if (scrollableControl != null)
							{
								num = 2;
								continue;
							}
							goto IL_12F;
						case 5:
							if (parent.Parent != null)
							{
								num = 7;
								continue;
							}
							goto IL_64;
						case 6:
							goto IL_12F;
						case 7:
							num = 3;
							continue;
						case 8:
							goto IL_107;
						}
						break;
						IL_64:
						this.a(parent, ref scrollableControl);
						num = 4;
						continue;
						IL_AB:
						parent = parent.Parent;
						num = 8;
						continue;
						IL_12F:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AB;
						default:
							goto IL_145;
						}
						IL_107:
						num = 5;
					}
				}
				IL_145:
				if (false)
				{
				}
				base.OnEnter(e);
				return;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0001A6C4 File Offset: 0x000188C4
		private void a(object A_0, ref global::System.Windows.Forms.ScrollableControl A_1)
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
					global::System.Type typeFromHandle = typeof(global::System.Windows.Forms.ScrollableControl);
					A_1 = null;
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (A_0.GetType().IsSubclassOf(typeFromHandle))
							{
								num = 1;
								continue;
							}
							return;
						case 1:
							A_1 = (global::System.Windows.Forms.ScrollableControl)A_0;
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
				break;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0001A754 File Offset: 0x00018954
		private void a(global::System.Windows.Forms.ScrollableControl A_0, global::System.Drawing.Point A_1)
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
			A_1.X = global::System.Math.Abs(A_1.X);
			A_1.Y = global::System.Math.Abs(A_1.Y);
			A_0.AutoScrollPosition = A_1;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0001A7BC File Offset: 0x000189BC
		protected override void Dispose(bool disposing)
		{
			if (true)
			{
			}
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_44;
					default:
						if (false)
						{
						}
						num = 3;
						continue;
					}
					break;
				case 1:
					goto IL_4C;
				case 2:
					this.ai.Dispose();
					goto IL_44;
				case 3:
					if (this.ai != null)
					{
						num = 2;
						continue;
					}
					goto IL_8E;
				}
				if (disposing)
				{
					num = 0;
					continue;
				}
				break;
				IL_44:
				num = 1;
			}
			IL_4C:
			IL_8E:
			base.Dispose(disposing);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0001A860 File Offset: 0x00018A60
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
			base.SuspendLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000048 RID: 72
		private const int a = -1;

		// Token: 0x04000049 RID: 73
		private const int b = 5;

		// Token: 0x0400004A RID: 74
		private const string c = "GetCellImage";

		// Token: 0x0400004B RID: 75
		private bool d;

		// Token: 0x0400004C RID: 76
		private bool e;

		// Token: 0x0400004D RID: 77
		private string f;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.SortOrder g;

		// Token: 0x0400004F RID: 79
		private bool h;

		// Token: 0x04000050 RID: 80
		private bool i;

		// Token: 0x04000051 RID: 81
		private bool j;

		// Token: 0x04000052 RID: 82
		private bool k;

		// Token: 0x04000053 RID: 83
		private bool l;

		// Token: 0x04000054 RID: 84
		public int startTickCountNDXMLSEL;

		// Token: 0x04000055 RID: 85
		public int endTickCountNDXMLSEL;

		// Token: 0x04000056 RID: 86
		public int timeTakenNDXMLSEL;

		// Token: 0x04000057 RID: 87
		public int startTickCountTextColumn;

		// Token: 0x04000058 RID: 88
		public int endTickCountTextColumn;

		// Token: 0x04000059 RID: 89
		public int timeTakenTextColumn;

		// Token: 0x0400005A RID: 90
		public int startTickCountSpinColumn;

		// Token: 0x0400005B RID: 91
		public int endTickCountSpintColumn;

		// Token: 0x0400005C RID: 92
		public int timeTakenSpinColumn;

		// Token: 0x0400005D RID: 93
		private global::System.Collections.ArrayList m;

		// Token: 0x0400005E RID: 94
		private int n;

		// Token: 0x0400005F RID: 95
		private int o;

		// Token: 0x04000060 RID: 96
		private int p;

		// Token: 0x04000061 RID: 97
		private int q;

		// Token: 0x04000062 RID: 98
		private global::System.Collections.ArrayList r;

		// Token: 0x04000063 RID: 99
		private int s;

		// Token: 0x04000064 RID: 100
		private bool t;

		// Token: 0x04000065 RID: 101
		private bool u;

		// Token: 0x04000066 RID: 102
		private int v;

		// Token: 0x04000067 RID: 103
		public global::custom_controls.CCustomDataGridView.SelectTargetNode SelectTargetTreeNode;

		// Token: 0x04000068 RID: 104
		private global::custom_controls.CCustomDataGridView.OnComboBoxCellIndexChanged w;

		// Token: 0x04000069 RID: 105
		private global::custom_controls.CCustomDataGridView.MoveSelectedRow x;

		// Token: 0x0400006A RID: 106
		private global::custom_controls.CCustomDataGridView.AddNewRow y;

		// Token: 0x0400006B RID: 107
		private global::custom_controls.CCustomDataGridView.DeleteSelectedRow z;

		// Token: 0x0400006C RID: 108
		private global::custom_controls.CCustomDataGridView.CutSelectedRow aa;

		// Token: 0x0400006D RID: 109
		private global::custom_controls.CCustomDataGridView.CopySelectedRow ab;

		// Token: 0x0400006E RID: 110
		private global::custom_controls.CCustomDataGridView.PasteSelectedRow ac;

		// Token: 0x0400006F RID: 111
		public global::custom_controls.CCustomDataGridView.GetComboBoxColumnChoices GetComboColumnChoices;

		// Token: 0x04000070 RID: 112
		public global::custom_controls.CCustomDataGridView.GetUpdownCtrlRange GetUpdownButtonRange;

		// Token: 0x04000071 RID: 113
		public global::custom_controls.CCustomDataGridView.SortRow SortGridRow;

		// Token: 0x04000072 RID: 114
		private global::custom_controls.CCustomDataGridView.ControlFocusEvent ad;

		// Token: 0x04000073 RID: 115
		private global::custom_controls.CCustomDataGridView.ControlFocusEvent ae;

		// Token: 0x04000074 RID: 116
		private global::custom_controls.CCustomDataGridView.ControlEvent af;

		// Token: 0x04000075 RID: 117
		private global::custom_controls.CCustomDataGridView.GetValueFromResourcefile ag;

		// Token: 0x04000076 RID: 118
		private global::custom_controls.CCustomDataGridView.UndoRedoMenuClick ah;

		// Token: 0x04000077 RID: 119
		private global::System.ComponentModel.IContainer ai;

		// Token: 0x02000012 RID: 18
		public class DataLoader : global::System.IDisposable
		{
			// Token: 0x060000CF RID: 207 RVA: 0x0001A8A8 File Offset: 0x00018AA8
			public DataLoader(global::custom_controls.CCustomDataGridView dgv)
			{
				this.a = dgv;
				if (this.a != null)
				{
					this.a.IsDataLoading = true;
				}
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x0001A8DC File Offset: 0x00018ADC
			protected virtual void Dispose(bool disposing)
			{
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (this.a != null)
						{
							num = 2;
							continue;
						}
						return;
					case 1:
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
							this.a.IsDataLoading = false;
							num = 1;
							continue;
						}
						break;
					case 3:
						num = 0;
						continue;
					}
					if (!disposing)
					{
						break;
					}
					if (true)
					{
					}
					num = 3;
				}
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x0001A978 File Offset: 0x00018B78
			public void Dispose()
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
				this.Dispose(true);
				global::System.GC.SuppressFinalize(this);
			}

			// Token: 0x04000078 RID: 120
			private global::custom_controls.CCustomDataGridView a;
		}

		// Token: 0x02000013 RID: 19
		public struct MenuInfo
		{
			// Token: 0x060000D2 RID: 210 RVA: 0x0001A9C0 File Offset: 0x00018BC0
			public MenuInfo(string mnuText, string mnuId, global::System.Windows.Forms.Shortcut shortcut)
			{
				this.a = mnuText;
				this.b = mnuId;
				this.c = shortcut;
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000D3 RID: 211 RVA: 0x0001A9E4 File Offset: 0x00018BE4
			public string MenuText
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

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x0001AA28 File Offset: 0x00018C28
			public string MenuID
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
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000D5 RID: 213 RVA: 0x0001AA6C File Offset: 0x00018C6C
			public global::System.Windows.Forms.Keys MenuShortCut
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
					return (global::System.Windows.Forms.Keys)this.c;
				}
			}

			// Token: 0x04000079 RID: 121
			private string a;

			// Token: 0x0400007A RID: 122
			private string b;

			// Token: 0x0400007B RID: 123
			private global::System.Windows.Forms.Shortcut c;
		}

		// Token: 0x02000014 RID: 20
		public struct ComboItem : global::System.IComparable
		{
			// Token: 0x060000D6 RID: 214 RVA: 0x0001AAB0 File Offset: 0x00018CB0
			public ComboItem(string choice, string tagValue, string typeIdValue)
			{
				this.a = choice;
				this.b = tagValue;
				this.c = typeIdValue;
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x0001AAD4 File Offset: 0x00018CD4
			public int CompareTo(object obj)
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
				global::custom_controls.CCustomDataGridView.ComboItem comboItem = (global::custom_controls.CCustomDataGridView.ComboItem)obj;
				return string.Compare(this.a, comboItem.Display, global::System.StringComparison.Ordinal);
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000D8 RID: 216 RVA: 0x0001AB2C File Offset: 0x00018D2C
			public string Display
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

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000D9 RID: 217 RVA: 0x0001AB70 File Offset: 0x00018D70
			public string Tag
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
					return this.b;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000DA RID: 218 RVA: 0x0001ABB4 File Offset: 0x00018DB4
			public string TypeId
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
					return this.c;
				}
			}

			// Token: 0x0400007C RID: 124
			private string a;

			// Token: 0x0400007D RID: 125
			private string b;

			// Token: 0x0400007E RID: 126
			private string c;
		}

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000DC RID: 220
		public delegate void SelectTargetNode(global::custom_controls.CCustomDataGridViewRow selectedRow);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x060000E0 RID: 224
		public delegate void OnComboBoxCellIndexChanged(object sender, global::custom_controls.CCustomDataGridView.ComboItem item, global::System.Windows.Forms.DataGridViewCellEventArgs e);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x060000E4 RID: 228
		public delegate void MoveSelectedRow(object dataGridView, object sender, string typeId, string srcRowListId, string srcRowListLetId, string destRowListId, string destRowListLetid);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000E8 RID: 232
		public delegate void AddNewRow(object sender, global::System.EventArgs e, object dataGridView, int rowIndex);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000EC RID: 236
		public delegate void DeleteSelectedRow(object sender, global::System.EventArgs e, object dataGridView, global::custom_controls.CCustomDataGridViewRow[] cdgvRow);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000F0 RID: 240
		public delegate void CutSelectedRow(object sender, global::System.EventArgs e, object dataGridView, global::custom_controls.CCustomDataGridViewRow[] cdgvRow);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000F4 RID: 244
		public delegate void CopySelectedRow(object sender, global::System.EventArgs e, object dataGridView, global::custom_controls.CCustomDataGridViewRow[] cdgvRow);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000F8 RID: 248
		public delegate void PasteSelectedRow(object sender, global::System.EventArgs e, object dataGridView);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000FC RID: 252
		public delegate void GetComboBoxColumnChoices(object dataGridView, ref global::System.Collections.ArrayList choices, string fieldId, int columnIndex, int rowIndex, bool singleChoice);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000100 RID: 256
		public delegate void GetUpdownCtrlRange(object dataGridView, ref string rangeXml, string fieldId, int columnIndex, int rowIndex);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x06000104 RID: 260
		public delegate void SortRow(object dataGridView, string menuId);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x06000108 RID: 264
		public delegate void ControlFocusEvent(object sender, global::System.EventArgs e);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600010C RID: 268
		public delegate void ControlEvent(object sender, global::System.Windows.Forms.DataGridViewCellEventArgs e);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000110 RID: 272
		public delegate void GetValueFromResourcefile(string resTag, ref string resValue);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000114 RID: 276
		private delegate void a(global::System.Windows.Forms.ScrollableControl A_0, global::System.Drawing.Point A_1);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000118 RID: 280
		public delegate void UndoRedoMenuClick(object sender, global::System.EventArgs e);
	}
}
