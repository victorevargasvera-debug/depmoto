using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000082 RID: 130
	public class PieChartControl : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000551 RID: 1361 RVA: 0x00051D10 File Offset: 0x0004FF10
		public PieChartControl()
		{
			this.a();
			base.SizeChanged -= this.PieChatSizeChanged;
			base.SizeChanged += this.PieChatSizeChanged;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00051D50 File Offset: 0x0004FF50
		public global::custom_controls.PieChartPanel Chart
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

		// Token: 0x06000553 RID: 1363 RVA: 0x00051D94 File Offset: 0x0004FF94
		public void MidAdjustLegendPosition()
		{
			switch (0)
			{
			default:
				for (;;)
				{
					int num = global::System.Windows.Forms.SystemInformation.Border3DSize.Width;
					global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)this.c.Rows).GetEnumerator();
					int num2 = 1;
					for (;;)
					{
						int num4;
						switch (num2)
						{
						case 0:
							goto IL_6A;
						case 1:
							try
							{
								num2 = 2;
								for (;;)
								{
									switch (num2)
									{
									case 1:
										num2 = 4;
										continue;
									case 2:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_181;
										default:
											if (false)
											{
											}
											break;
										}
										break;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											goto IL_181;
										}
										global::System.Windows.Forms.DataGridViewRow dataGridViewRow = (global::System.Windows.Forms.DataGridViewRow)enumerator.Current;
										num += dataGridViewRow.Height;
										num2 = 0;
										continue;
									}
									case 4:
										goto IL_1B6;
									}
									IL_16F:
									num2 = 3;
									continue;
									goto IL_16F;
									IL_181:
									num2 = 1;
								}
								IL_1B6:
								goto IL_253;
							}
							finally
							{
								for (;;)
								{
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									num2 = 1;
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_201;
										case 1:
											if (disposable != null)
											{
												num2 = 2;
												continue;
											}
											goto IL_203;
										case 2:
											disposable.Dispose();
											num2 = 0;
											continue;
										}
										break;
									}
								}
								IL_201:
								IL_203:;
							}
							goto IL_204;
							IL_253:
							num += this.c.ColumnHeadersHeight;
							num += global::System.Windows.Forms.SystemInformation.Border3DSize.Width;
							this.c.Height = num;
							num2 = 7;
							continue;
						case 2:
							this.c.Top = this.b.Top / 2;
							num2 = 5;
							continue;
						case 3:
							if (this.c.Top < this.b.Top / 2)
							{
								num2 = 2;
								continue;
							}
							return;
						case 4:
						{
							int num3 = this.b.Height - this.c.Height;
							this.c.Top = this.b.Top + num3 / 2;
							num2 = 0;
							continue;
						}
						case 5:
							return;
						case 6:
							if (true)
							{
							}
							if (num4 > 0)
							{
								num2 = 8;
								continue;
							}
							return;
						case 7:
							if (this.c.Height < this.b.Height)
							{
								num2 = 4;
								continue;
							}
							goto IL_6A;
						case 8:
							goto IL_204;
						}
						break;
						IL_6A:
						num4 = this.c.Top + this.c.Height - base.Height;
						num2 = 6;
						continue;
						IL_204:
						this.c.Top = this.c.Top - num4;
						num2 = 3;
					}
				}
				return;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00052068 File Offset: 0x00050268
		public global::System.Windows.Forms.DataGridView LegendDataGridView
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

		// Token: 0x06000555 RID: 1365 RVA: 0x000520AC File Offset: 0x000502AC
		protected void PieChatSizeChanged(object sender, global::System.EventArgs e)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Drawing.Size size = base.Size;
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.b.Size = new global::System.Drawing.Size(this.b.Size.Width, base.Size.Height);
							this.c.Size = new global::System.Drawing.Size(this.c.Size.Width, base.Size.Height);
							if (true)
							{
							}
							num = 2;
							continue;
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
								if (!size.IsEmpty)
								{
									num = 0;
									continue;
								}
								return;
							}
							break;
						case 2:
							return;
						}
						break;
					}
				}
				return;
			}
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000521A4 File Offset: 0x000503A4
		protected override void Dispose(bool disposing)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_4E;
				case 1:
					if (this.a != null)
					{
						num = 4;
						continue;
					}
					goto IL_91;
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						if (true)
						{
						}
						if (false)
						{
						}
						num = 1;
						continue;
					}
					break;
				case 4:
					this.a.Dispose();
					num = 0;
					continue;
				}
				if (!disposing)
				{
					break;
				}
				num = 2;
			}
			IL_4E:
			IL_91:
			base.Dispose(disposing);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0005224C File Offset: 0x0005044C
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
			this.b = new global::custom_controls.PieChartPanel();
			this.c = new global::System.Windows.Forms.DataGridView();
			((global::System.ComponentModel.ISupportInitialize)this.c).BeginInit();
			base.SuspendLayout();
			this.b.BackColor = global::System.Drawing.SystemColors.Window;
			this.b.Location = new global::System.Drawing.Point(3, 3);
			this.b.Name = "pieChartPanel";
			this.b.Size = new global::System.Drawing.Size(216, 150);
			this.b.TabIndex = 0;
			this.b.ToolTips = null;
			this.c.AllowUserToAddRows = false;
			this.c.AllowUserToDeleteRows = false;
			this.c.AllowUserToResizeColumns = false;
			this.c.AllowUserToResizeRows = false;
			this.c.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.c.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.c.BackgroundColor = global::System.Drawing.SystemColors.Window;
			this.c.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.c.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.c.Location = new global::System.Drawing.Point(225, 3);
			this.c.MultiSelect = false;
			this.c.Name = "legendDataGridView";
			this.c.ReadOnly = true;
			this.c.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.c.Size = new global::System.Drawing.Size(346, 150);
			this.c.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.InactiveCaption;
			base.Controls.Add(this.c);
			base.Controls.Add(this.b);
			base.Name = "PieChartControl";
			base.Size = new global::System.Drawing.Size(577, 150);
			((global::System.ComponentModel.ISupportInitialize)this.c).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000409 RID: 1033
		private global::System.ComponentModel.IContainer a;

		// Token: 0x0400040A RID: 1034
		private global::custom_controls.PieChartPanel b;

		// Token: 0x0400040B RID: 1035
		private global::System.Windows.Forms.DataGridView c;
	}
}
