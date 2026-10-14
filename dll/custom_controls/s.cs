using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000091 RID: 145
	internal class s : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x0005A63C File Offset: 0x0005883C
		public s(global::System.Windows.Forms.Control A_0)
		{
			this.e = A_0;
			base.Controls.Add(this.e);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.DoubleBuffer, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
			base.TabStop = false;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0005A690 File Offset: 0x00058890
		protected virtual void a(global::System.EventArgs A_0)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						base.SuspendLayout();
						this.e.SuspendLayout();
						global::System.Windows.Forms.Control.ControlCollection controls = this.e.Controls;
						if (true)
						{
						}
						int num = 2;
						for (;;)
						{
							global::System.Collections.IEnumerator enumerator;
							switch (num)
							{
							case 0:
								try
								{
									num = 1;
									for (;;)
									{
										switch (num)
										{
										case 0:
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_FC;
											default:
												if (false)
												{
												}
												num = 2;
												continue;
											}
											break;
										case 2:
											goto IL_217;
										case 3:
											goto IL_10D;
										case 5:
										{
											int num2;
											int count;
											if (num2 >= count - 2)
											{
												num = 10;
												continue;
											}
											global::System.Windows.Forms.Control control;
											((global::custom_controls.ListViewTemplate)control).Columns[num2].Width = ((global::custom_controls.ListViewTemplate)control).Columns[0].Width;
											num2++;
											num = 3;
											continue;
										}
										case 6:
										{
											if (!enumerator.MoveNext())
											{
												num = 0;
												continue;
											}
											global::System.Windows.Forms.Control control = (global::System.Windows.Forms.Control)enumerator.Current;
											num = 9;
											continue;
										}
										case 7:
										{
											int count;
											global::System.Windows.Forms.Control control;
											int num3 = control.Width / (count + 1);
											int num2 = 0;
											num = 11;
											continue;
										}
										case 8:
										{
											global::System.Windows.Forms.Control control;
											int count = ((global::custom_controls.ListViewTemplate)control).Columns.Count;
											num = 12;
											continue;
										}
										case 9:
										{
											global::System.Windows.Forms.Control control;
											if (control.GetType().ToString().Equals("mototrbocps.ListViewTemplate"))
											{
												goto IL_FC;
											}
											break;
										}
										case 10:
										{
											global::System.Windows.Forms.Control control;
											((global::custom_controls.ListViewTemplate)control).Invalidate();
											num = 4;
											continue;
										}
										case 11:
											goto IL_10D;
										case 12:
										{
											int count;
											if (count > 0)
											{
												num = 7;
												continue;
											}
											break;
										}
										}
										goto IL_B4;
										IL_FC:
										num = 8;
										continue;
										IL_10D:
										num = 5;
										continue;
										IL_131:
										num = 6;
										continue;
										IL_B4:
										goto IL_131;
									}
									IL_217:
									goto IL_2C3;
								}
								finally
								{
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
												goto IL_264;
											case 1:
												disposable.Dispose();
												num = 2;
												continue;
											case 2:
												goto IL_262;
											}
											break;
										}
									}
									IL_262:
									IL_264:;
								}
								goto IL_265;
							case 1:
								goto IL_2E7;
							case 2:
								if (this.e != null)
								{
									num = 3;
									continue;
								}
								goto IL_2C3;
							case 3:
								goto IL_265;
							}
							break;
							IL_265:
							global::System.Drawing.Size size = base.Size;
							this.e.Location = new global::System.Drawing.Point(3, 3);
							this.e.Size = new global::System.Drawing.Size(size.Width - this.d, size.Height - this.d);
							enumerator = controls.GetEnumerator();
							num = 0;
							continue;
							IL_2C3:
							base.OnResize(A_0);
							this.e.ResumeLayout();
							base.ResumeLayout();
							num = 1;
						}
					}
					IL_2E7:
					break;
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x0400049D RID: 1181
		private const string a = "mototrbocps.ListViewTemplate";

		// Token: 0x0400049E RID: 1182
		private const int b = 3;

		// Token: 0x0400049F RID: 1183
		private const int c = 250;

		// Token: 0x040004A0 RID: 1184
		private int d = 6;

		// Token: 0x040004A1 RID: 1185
		private global::System.Windows.Forms.Control e;
	}
}
