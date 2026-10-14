using System;
using System.Drawing;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000010 RID: 16
	public class CheckboxColumnHeader : global::System.Windows.Forms.DataGridViewColumnHeaderCell
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000078D8 File Offset: 0x00005AD8
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000791C File Offset: 0x00005B1C
		public bool CheckAll
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
				if (true)
				{
				}
				if (false)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007960 File Offset: 0x00005B60
		protected override void Paint(global::System.Drawing.Graphics graphics, global::System.Drawing.Rectangle clipBounds, global::System.Drawing.Rectangle cellBounds, int rowIndex, global::System.Windows.Forms.DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText, global::System.Windows.Forms.DataGridViewCellStyle cellStyle, global::System.Windows.Forms.DataGridViewAdvancedBorderStyle advancedBorderStyle, global::System.Windows.Forms.DataGridViewPaintParts paintParts)
		{
			try
			{
				for (;;)
				{
					IL_1C:
					int num;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_BC:
						global::System.Windows.Forms.ControlPaint.DrawCheckBox(graphics, this.a, global::System.Windows.Forms.ButtonState.Checked);
						num = 1;
						break;
					default:
						if (false)
						{
						}
						base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
						this.a = new global::System.Drawing.Rectangle(cellBounds.Location.X + 3, cellBounds.Location.Y + 4, 13, 13);
						num = 0;
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (this.b)
							{
								num = 3;
								continue;
							}
							global::System.Windows.Forms.ControlPaint.DrawCheckBox(graphics, this.a, global::System.Windows.Forms.ButtonState.Normal);
							num = 4;
							continue;
						case 1:
							goto IL_DA;
						case 2:
							goto IL_E5;
						case 3:
							goto IL_A0;
						case 4:
							goto IL_DA;
						}
						goto IL_1C;
						IL_DA:
						num = 2;
					}
					IL_A0:
					goto IL_BC;
				}
				IL_E5:;
			}
			catch (global::System.Exception)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00007A7C File Offset: 0x00005C7C
		protected override void OnMouseClick(global::System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_77:
				base.DataGridView.Invalidate();
				if (true)
				{
				}
				num = 2;
				break;
			default:
				if (false)
				{
				}
				goto IL_30;
			}
			global::System.Drawing.Rectangle rectangle;
			for (;;)
			{
				IL_1E:
				switch (num)
				{
				case 0:
					goto IL_77;
				case 1:
					if (rectangle.Contains(e.Location))
					{
						num = 0;
						continue;
					}
					goto IL_96;
				case 2:
					goto IL_94;
				}
				goto IL_30;
			}
			IL_94:
			IL_96:
			base.OnMouseClick(e);
			return;
			IL_30:
			rectangle = new global::System.Drawing.Rectangle(new global::System.Drawing.Point(0, 0), this.a.Size);
			this.b = !this.b;
			num = 1;
			goto IL_1E;
		}

		// Token: 0x04000046 RID: 70
		private global::System.Drawing.Rectangle a;

		// Token: 0x04000047 RID: 71
		private bool b;
	}
}
