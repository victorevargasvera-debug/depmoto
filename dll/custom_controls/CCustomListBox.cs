using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000064 RID: 100
	public class CCustomListBox : global::System.Windows.Forms.ListBox
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00043BEC File Offset: 0x00041DEC
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00043C30 File Offset: 0x00041E30
		public global::System.Windows.Forms.ImageList ImageList
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
				this.a = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00043C74 File Offset: 0x00041E74
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00043CB8 File Offset: 0x00041EB8
		public bool ImageListNeeded
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
				this.c = value;
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00043CFC File Offset: 0x00041EFC
		public CCustomListBox()
		{
			this.a();
			this.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiExtended;
			this.ItemHeight = this.Font.Height;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00043D34 File Offset: 0x00041F34
		protected override void OnFontChanged(global::System.EventArgs e)
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
			base.OnFontChanged(e);
			this.ItemHeight = this.Font.Height;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00043D88 File Offset: 0x00041F88
		protected override void Dispose(bool disposing)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.b.Dispose();
					num = 1;
					continue;
				case 1:
					goto IL_72;
				case 3:
					if (this.b != null)
					{
						num = 0;
						continue;
					}
					goto IL_91;
				case 4:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						if (false)
						{
						}
						num = 3;
						continue;
					}
					break;
				}
				if (!disposing)
				{
					break;
				}
				if (true)
				{
				}
				num = 4;
			}
			IL_72:
			IL_91:
			base.Dispose(disposing);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00043E30 File Offset: 0x00042030
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
			this.b = new global::System.ComponentModel.Container();
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00043E78 File Offset: 0x00042078
		protected override void OnDrawItem(global::System.Windows.Forms.DrawItemEventArgs e)
		{
			switch (0)
			{
			default:
			{
				int num = 2;
				for (;;)
				{
					global::System.Drawing.SolidBrush solidBrush;
					global::System.Drawing.Rectangle bounds;
					global::System.Drawing.Size imageSize;
					switch (num)
					{
					case 0:
						try
						{
							try
							{
								for (;;)
								{
									global::custom_controls.CListBoxItem clistBoxItem = (global::custom_controls.CListBoxItem)base.Items[e.Index];
									num = 0;
									for (;;)
									{
										switch (num)
										{
										case 0:
											if (clistBoxItem.ImageIndex != -1)
											{
												num = 3;
												continue;
											}
											e.Graphics.DrawString(clistBoxItem.Item.Display, e.Font, solidBrush, (float)bounds.Left, (float)bounds.Top);
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
												continue;
											}
											break;
										case 1:
											goto IL_190;
										case 2:
											goto IL_19C;
										case 3:
											e.Graphics.DrawImage(this.ImageList.Images[clistBoxItem.ImageIndex], bounds.Left, bounds.Top, imageSize.Width, global::System.Math.Max(imageSize.Height, this.ItemHeight));
											e.Graphics.DrawString(clistBoxItem.Item.Display, e.Font, solidBrush, (float)(bounds.Left + imageSize.Width), (float)bounds.Top);
											num = 1;
											continue;
										case 4:
											goto IL_190;
										}
										break;
										IL_190:
										num = 2;
									}
								}
								IL_19C:;
							}
							catch
							{
								if (e.Index != -1)
								{
									e.Graphics.DrawString(base.Items[e.Index].ToString(), e.Font, solidBrush, (float)bounds.Left, (float)bounds.Top);
								}
								else
								{
									e.Graphics.DrawString(this.Text, e.Font, solidBrush, (float)bounds.Left, (float)bounds.Top);
								}
								if (true)
								{
								}
							}
							try
							{
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 0:
										if (base.SelectedIndices.Count >= 0)
										{
											num = 5;
											continue;
										}
										goto IL_510;
									case 2:
										goto IL_51C;
									case 3:
										try
										{
											num = 0;
											for (;;)
											{
												switch (num)
												{
												case 1:
												{
													global::System.Collections.IEnumerator enumerator;
													if (!enumerator.MoveNext())
													{
														num = 5;
														continue;
													}
													int num2 = (int)enumerator.Current;
													num = 6;
													continue;
												}
												case 2:
													e.Graphics.FillRectangle(global::System.Drawing.Brushes.Silver, e.Bounds);
													e.DrawFocusRectangle();
													num = 3;
													continue;
												case 3:
													if (((global::custom_controls.CListBoxItem)base.Items[e.Index]).ImageIndex != -1)
													{
														num = 8;
														continue;
													}
													e.Graphics.DrawString(((global::custom_controls.CListBoxItem)base.Items[e.Index]).Item.Display, e.Font, global::System.Drawing.Brushes.Black, e.Bounds);
													num = 9;
													continue;
												case 4:
													goto IL_4C5;
												case 5:
													goto IL_4B9;
												case 6:
												{
													int num2;
													if (e.Index == num2)
													{
														num = 2;
														continue;
													}
													break;
												}
												case 7:
													goto IL_4B9;
												case 8:
													e.Graphics.DrawImage(this.ImageList.Images[((global::custom_controls.CListBoxItem)base.Items[e.Index]).ImageIndex], e.Bounds.Left, e.Bounds.Top, imageSize.Width, global::System.Math.Max(imageSize.Height, this.ItemHeight));
													e.Graphics.DrawString(((global::custom_controls.CListBoxItem)base.Items[e.Index]).Item.Display, e.Font, global::System.Drawing.Brushes.Black, (float)(e.Bounds.Left + imageSize.Width), (float)e.Bounds.Top);
													num = 7;
													continue;
												case 9:
													goto IL_4B9;
												}
												IL_35D:
												num = 1;
												continue;
												goto IL_35D;
												IL_4B9:
												num = 4;
											}
											IL_4C5:;
										}
										finally
										{
											for (;;)
											{
												global::System.Collections.IEnumerator enumerator;
												global::System.IDisposable disposable = enumerator as global::System.IDisposable;
												num = 1;
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
														goto IL_50F;
													case 2:
														goto IL_50D;
													}
													break;
												}
											}
											IL_50D:
											IL_50F:;
										}
										goto IL_510;
									case 4:
										num = 0;
										continue;
									case 5:
									{
										global::System.Collections.IEnumerator enumerator = base.SelectedIndices.GetEnumerator();
										num = 3;
										continue;
									}
									}
									if (!base.ContainsFocus)
									{
										num = 4;
										continue;
									}
									IL_510:
									num = 2;
								}
								IL_51C:;
							}
							catch
							{
								if (e.Index != -1)
								{
									e.Graphics.DrawString(base.Items[e.Index].ToString(), e.Font, solidBrush, (float)bounds.Left, (float)bounds.Top);
								}
								else
								{
									e.Graphics.DrawString(this.Text, e.Font, solidBrush, (float)bounds.Left, (float)bounds.Top);
								}
							}
							goto IL_60C;
						}
						finally
						{
							num = 0;
							for (;;)
							{
								switch (num)
								{
								case 1:
									goto IL_5CD;
								case 2:
									((global::System.IDisposable)solidBrush).Dispose();
									num = 1;
									continue;
								}
								if (solidBrush == null)
								{
									break;
								}
								num = 2;
							}
							IL_5CD:;
						}
						goto IL_5D0;
					case 1:
						goto IL_5D0;
					}
					if (this.a != null)
					{
						num = 1;
						continue;
					}
					break;
					IL_5D0:
					e.DrawBackground();
					e.DrawFocusRectangle();
					bounds = e.Bounds;
					imageSize = this.a.ImageSize;
					solidBrush = new global::System.Drawing.SolidBrush(e.ForeColor);
					num = 0;
				}
				IL_60C:
				base.OnDrawItem(e);
				return;
			}
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000444FC File Offset: 0x000426FC
		protected override void OnLostFocus(global::System.EventArgs e)
		{
			if (true)
			{
			}
			base.OnLostFocus(e);
			global::System.Collections.IEnumerator enumerator = base.SelectedIndices.GetEnumerator();
			try
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = 4;
							continue;
						}
						int index = (int)enumerator.Current;
						base.Invalidate(base.GetItemRectangle(index));
						num = 1;
						continue;
					}
					case 3:
						goto IL_92;
					case 4:
						num = 3;
						continue;
					}
					IL_70:
					num = 2;
					continue;
					goto IL_70;
				}
				IL_92:;
			}
			finally
			{
				for (;;)
				{
					IL_A8:
					global::System.IDisposable disposable = enumerator as global::System.IDisposable;
					for (;;)
					{
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (disposable != null)
								{
									num = 2;
									continue;
								}
								goto IL_D4;
							case 1:
								goto IL_D2;
							case 2:
								disposable.Dispose();
								num = 1;
								continue;
							}
							goto IL_A8;
						}
						IL_D4:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_EA;
						}
						IL_D2:
						goto IL_D4;
					}
				}
				IL_EA:
				if (false)
				{
				}
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0004460C File Offset: 0x0004280C
		protected override void OnGotFocus(global::System.EventArgs e)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			}
			if (true)
			{
			}
			if (false)
			{
			}
			base.OnGotFocus(e);
			global::System.Collections.IEnumerator enumerator = base.SelectedIndices.GetEnumerator();
			try
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = 4;
							continue;
						}
						int index = (int)enumerator.Current;
						base.Invalidate(base.GetItemRectangle(index));
						num = 1;
						continue;
					}
					case 3:
						goto IL_AE;
					case 4:
						num = 3;
						continue;
					}
					IL_8C:
					num = 0;
					continue;
					goto IL_8C;
				}
				IL_AE:;
			}
			finally
			{
				for (;;)
				{
					global::System.IDisposable disposable = enumerator as global::System.IDisposable;
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (disposable != null)
							{
								num = 2;
								continue;
							}
							goto IL_F0;
						case 1:
							goto IL_EE;
						case 2:
							disposable.Dispose();
							num = 1;
							continue;
						}
						break;
					}
				}
				IL_EE:
				IL_F0:;
			}
		}

		// Token: 0x040002D6 RID: 726
		private global::System.Windows.Forms.ImageList a;

		// Token: 0x040002D7 RID: 727
		private global::System.ComponentModel.Container b;

		// Token: 0x040002D8 RID: 728
		private bool c;
	}
}
