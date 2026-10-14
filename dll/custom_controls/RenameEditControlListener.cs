using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x020000AD RID: 173
	public class RenameEditControlListener : global::System.Windows.Forms.NativeWindow, global::System.IDisposable
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00067608 File Offset: 0x00065808
		public bool IsSubclassed
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

		// Token: 0x0600073A RID: 1850 RVA: 0x0006764C File Offset: 0x0006584C
		public RenameEditControlListener(global::custom_controls.CustomTreeView parent)
		{
			this.d = parent;
			this.c = new global::System.Collections.ArrayList(this.d.RenameContextMenu.MenuItems.Count);
			this.a();
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0006768C File Offset: 0x0006588C
		public void AssignControlHandle(global::System.IntPtr handle)
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
			this.b = true;
			base.AssignHandle(handle);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000676D8 File Offset: 0x000658D8
		public void Dispose()
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
					if (false)
					{
					}
					switch (num)
					{
					case 0:
						return;
					case 2:
						this.Dispose(true);
						if (true)
						{
						}
						num = 0;
						continue;
					}
					if (this.a)
					{
						return;
					}
					break;
				}
				num = 2;
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00067754 File Offset: 0x00065954
		protected virtual void Dispose(bool disposing)
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
					}
					if (false)
					{
					}
					this.a = true;
					global::System.GC.SuppressFinalize(this);
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
					return;
				}
				if (!disposing)
				{
					break;
				}
				num = 0;
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000677D0 File Offset: 0x000659D0
		protected override void Finalize()
		{
			try
			{
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_4C;
					case 1:
						goto IL_5F;
					case 2:
						goto IL_67;
					}
					if (this.a)
					{
						goto IL_5F;
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
						num = 0;
						continue;
					}
					IL_4C:
					this.Dispose(true);
					num = 1;
					continue;
					IL_5F:
					num = 2;
				}
				IL_67:;
			}
			finally
			{
				base.Finalize();
			}
			if (true)
			{
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00067870 File Offset: 0x00065A70
		private void a()
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
						goto IL_36;
					case 1:
					{
						if (num >= this.d.RenameContextMenu.MenuItems.Count)
						{
							num2 = 3;
							continue;
						}
						int num3 = global::custom_controls.r.GetMenuItemID(this.d.RenameContextMenu.Handle, num).ToInt32();
						this.c.Add(num3);
						num++;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							num2 = 0;
							continue;
						}
						break;
					}
					case 2:
						if (true)
						{
						}
						goto IL_36;
					case 3:
						return;
					}
					break;
					IL_36:
					num2 = 1;
				}
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00067940 File Offset: 0x00065B40
		protected override void WndProc(ref global::System.Windows.Forms.Message m)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_5B;
				case 1:
					this.b(ref m);
					num = 0;
					continue;
				case 2:
					goto IL_80;
				case 4:
					this.c(ref m);
					num = 5;
					continue;
				case 5:
					goto IL_82;
				case 6:
					if (m.Msg == 44)
					{
						num = 1;
						continue;
					}
					goto IL_5B;
				case 7:
					goto IL_CA;
				case 8:
					if (m.Msg == 2)
					{
						num = 7;
						continue;
					}
					goto IL_130;
				case 9:
					goto IL_E2;
				case 10:
					if (true)
					{
					}
					if (m.Msg == 123)
					{
						num = 2;
						continue;
					}
					num = 8;
					continue;
				}
				if (m.Msg == 43)
				{
					num = 4;
					continue;
				}
				goto IL_82;
				IL_5B:
				num = 10;
				continue;
				IL_82:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_CA:
					this.ReleaseHandle();
					this.b = false;
					num = 9;
					break;
				default:
					if (false)
					{
					}
					num = 6;
					break;
				}
			}
			IL_80:
			this.a(ref m);
			return;
			IL_E2:
			IL_130:
			base.WndProc(ref m);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00067A84 File Offset: 0x00065C84
		private void c(ref global::System.Windows.Forms.Message A_0)
		{
			switch (0)
			{
			default:
			{
				int num = 0;
				for (;;)
				{
					global::custom_controls.r.b b;
					global::System.Drawing.Graphics graphics;
					switch (num)
					{
					case 1:
						if (true)
						{
						}
						goto IL_26C;
					case 2:
						try
						{
							for (;;)
							{
								global::System.Windows.Forms.DrawItemState state = global::System.Windows.Forms.DrawItemState.Default;
								num = 12;
								for (;;)
								{
									int num2;
									global::System.Windows.Forms.DrawItemEventArgs e;
									switch (num)
									{
									case 0:
										if (num2 >= this.d.RenameContextMenu.MenuItems.Count)
										{
											num = 11;
											continue;
										}
										num = 4;
										continue;
									case 1:
										this.d.OnDrawMenu(this.d.RenameContextMenu.MenuItems[num2], e);
										num = 6;
										continue;
									case 2:
										num = 9;
										continue;
									case 3:
										goto IL_1A9;
									case 4:
										if ((int)this.c[num2] == b.c)
										{
											num = 2;
											continue;
										}
										goto IL_E0;
									case 5:
										goto IL_263;
									case 6:
										goto IL_E0;
									case 7:
										goto IL_138;
									case 8:
										goto IL_138;
									case 9:
										if (this.d.OnDrawMenu != null)
										{
											num = 1;
											continue;
										}
										goto IL_E0;
									case 10:
										state = global::System.Windows.Forms.DrawItemState.Selected;
										num = 3;
										continue;
									case 11:
										num = 5;
										continue;
									case 12:
										if ((b.e & 1) > 0)
										{
											num = 10;
											continue;
										}
										goto IL_1A9;
									}
									break;
									IL_E0:
									num2++;
									num = 7;
									continue;
									IL_138:
									num = 0;
									continue;
									IL_1A9:
									global::System.Drawing.Rectangle rect = new global::System.Drawing.Rectangle(b.h.a, b.h.b, b.h.c - b.h.a, b.h.d - b.h.b);
									e = new global::System.Windows.Forms.DrawItemEventArgs(graphics, this.d.Font, rect, b.c, state);
									num2 = 0;
									num = 8;
								}
							}
							IL_263:
							return;
						}
						finally
						{
							graphics.Dispose();
						}
						goto IL_26C;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					}
					if (false)
					{
					}
					if (this.d.RenameContextMenu.OwnerDraw)
					{
						num = 1;
						continue;
					}
					break;
					IL_26C:
					b = (global::custom_controls.r.b)global::System.Runtime.InteropServices.Marshal.PtrToStructure(A_0.LParam, typeof(global::custom_controls.r.b));
					graphics = global::System.Drawing.Graphics.FromHdc(b.g);
					num = 2;
				}
				return;
			}
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00067D54 File Offset: 0x00065F54
		private void b(ref global::System.Windows.Forms.Message A_0)
		{
			switch (0)
			{
			default:
			{
				int num = 0;
				for (;;)
				{
					if (true)
					{
					}
					global::System.Drawing.Graphics graphics;
					global::custom_controls.r.a structure;
					switch (num)
					{
					case 1:
						goto IL_1E7;
					case 2:
						try
						{
							for (;;)
							{
								global::System.Windows.Forms.MeasureItemEventArgs measureItemEventArgs = new global::System.Windows.Forms.MeasureItemEventArgs(graphics, structure.c);
								int num2 = 0;
								num = 9;
								for (;;)
								{
									switch (num)
									{
									case 0:
										if ((int)this.c[num2] == structure.c)
										{
											num = 5;
											continue;
										}
										goto IL_10C;
									case 1:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											if (false)
											{
											}
											if (this.d.OnMeasureMenu == null)
											{
												goto IL_10C;
											}
											break;
										}
										num = 8;
										continue;
									case 2:
										num = 7;
										continue;
									case 3:
										if (num2 >= this.d.RenameContextMenu.MenuItems.Count)
										{
											num = 2;
											continue;
										}
										num = 0;
										continue;
									case 4:
										goto IL_A6;
									case 5:
										num = 1;
										continue;
									case 6:
										goto IL_184;
									case 7:
										goto IL_1DE;
									case 8:
										this.d.OnMeasureMenu(this.d.RenameContextMenu.MenuItems[num2], measureItemEventArgs);
										structure.e = measureItemEventArgs.ItemHeight;
										structure.d = measureItemEventArgs.ItemWidth;
										global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::custom_controls.r.a>(structure, A_0.LParam, false);
										A_0.Result = (global::System.IntPtr)1;
										num = 6;
										continue;
									case 9:
										goto IL_A6;
									}
									break;
									IL_A6:
									num = 3;
									continue;
									IL_10C:
									num2++;
									num = 4;
								}
							}
							IL_184:
							IL_1DE:
							return;
						}
						finally
						{
							graphics.Dispose();
						}
						goto IL_1E7;
					}
					if (this.d.RenameContextMenu.OwnerDraw)
					{
						num = 1;
						continue;
					}
					break;
					IL_1E7:
					structure = (global::custom_controls.r.a)A_0.GetLParam(typeof(global::custom_controls.r.a));
					graphics = global::System.Drawing.Graphics.FromHwnd(base.Handle);
					num = 2;
				}
				return;
			}
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00067FA4 File Offset: 0x000661A4
		private void a(ref global::System.Windows.Forms.Message A_0)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				default:
					for (;;)
					{
						long num = -1L;
						int a_ = 0;
						int a_2 = 0;
						int num2 = 10;
						for (;;)
						{
							int num3;
							switch (num2)
							{
							case 0:
								goto IL_1F4;
							case 1:
								goto IL_213;
							case 2:
								goto IL_213;
							case 3:
								if (num3 >= this.d.RenameContextMenu.MenuItems.Count)
								{
									num2 = 6;
									continue;
								}
								num2 = 9;
								continue;
							case 4:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_00;
								default:
									if (false)
									{
									}
									this.d.RenameContextMenu.MenuItems[num3].PerformClick();
									num2 = 0;
									continue;
								}
								break;
							case 5:
								goto IL_133;
							case 6:
								return;
							case 7:
								goto IL_133;
							case 8:
							{
								global::custom_controls.r.c c = default(global::custom_controls.r.c);
								global::custom_controls.r.GetWindowRect(base.Handle, ref c);
								a_ = c.a + (int)global::System.Math.Floor((c.c - c.a) / 2m);
								a_2 = c.b + (int)global::System.Math.Floor((c.d - c.b) / 2m);
								num2 = 1;
								continue;
							}
							case 9:
								if ((long)((int)this.c[num3]) == num)
								{
									num2 = 4;
									continue;
								}
								goto IL_1F4;
							case 10:
								if ((int)A_0.LParam == -1)
								{
									num2 = 8;
									continue;
								}
								a_ = global::custom_controls.r.a(A_0.LParam.ToInt32());
								a_2 = global::custom_controls.r.b(A_0.LParam.ToInt32());
								num2 = 2;
								continue;
							}
							break;
							IL_133:
							num2 = 3;
							continue;
							IL_1F4:
							if (true)
							{
							}
							num3++;
							num2 = 5;
							continue;
							IL_213:
							this.d.UpdateRenameMenu();
							num = (long)global::custom_controls.r.TrackPopupMenuEx(this.d.RenameContextMenu.Handle, 256U, a_, a_2, base.Handle, new global::System.IntPtr(0));
							num3 = 0;
							num2 = 7;
						}
					}
					break;
				}
			}
		}

		// Token: 0x0400054E RID: 1358
		private bool a;

		// Token: 0x0400054F RID: 1359
		private bool b;

		// Token: 0x04000550 RID: 1360
		private global::System.Collections.ArrayList c;

		// Token: 0x04000551 RID: 1361
		private global::custom_controls.CustomTreeView d;
	}
}
