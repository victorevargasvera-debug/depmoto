using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using custom_exception;
using RegistryAccess;
using resource_handler;

namespace custom_controls
{
	// Token: 0x02000076 RID: 118
	public class CMsgDialog
	{
		// Token: 0x060004D8 RID: 1240
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern global::System.IntPtr GetParent(global::System.IntPtr A_0);

		// Token: 0x060004D9 RID: 1241
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern void DestroyWindow(global::System.IntPtr A_0);

		// Token: 0x060004DA RID: 1242
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern global::System.IntPtr GetDlgItem(global::System.IntPtr A_0, int A_1);

		// Token: 0x060004DB RID: 1243
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int GetWindowRect(global::System.IntPtr A_0, ref global::custom_controls.CMsgDialog.a A_1);

		// Token: 0x060004DC RID: 1244
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int GetClientRect(global::System.IntPtr A_0, ref global::custom_controls.CMsgDialog.a A_1);

		// Token: 0x060004DD RID: 1245
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern void MoveWindow(global::System.IntPtr A_0, int A_1, int A_2, int A_3, int A_4, bool A_5);

		// Token: 0x060004DE RID: 1246
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool ShowWindow(global::System.IntPtr A_0, int A_1);

		// Token: 0x060004DF RID: 1247
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int ScreenToClient(global::System.IntPtr A_0, ref global::custom_controls.CMsgDialog.b A_1);

		// Token: 0x060004E0 RID: 1248
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern global::System.IntPtr SendMessage(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2, global::System.IntPtr A_3);

		// Token: 0x060004E1 RID: 1249
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		private static extern bool SetWindowText(int A_0, string A_1);

		// Token: 0x060004E2 RID: 1250
		[global::System.Runtime.InteropServices.DllImport("user32", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		internal static extern global::System.IntPtr GetActiveWindow();

		// Token: 0x060004E3 RID: 1251
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		private static extern global::System.IntPtr CreateWindowEx(int A_0, string A_1, string A_2, int A_3, int A_4, int A_5, int A_6, int A_7, global::System.IntPtr A_8, global::System.IntPtr A_9, global::System.IntPtr A_10, global::System.IntPtr A_11);

		// Token: 0x060004E4 RID: 1252 RVA: 0x0004BDB4 File Offset: 0x00049FB4
		public CMsgDialog(bool isRightToLeft, global::resource_handler.CResourceHandler resourcemManager, int errorMsgId, string appNameID, string infoToAdd)
		{
			try
			{
				this.e = isRightToLeft;
				this.f = resourcemManager;
				string s = string.Empty;
				string @string = this.f.GetString("FONT_FAMILY");
				s = this.f.GetString("FONT_SIZE");
				float emSize = float.Parse(s, global::System.Globalization.NumberStyles.Float, global::System.Globalization.NumberFormatInfo.InvariantInfo);
				this.j = new global::System.Drawing.Font(@string, emSize);
				this.r = 0.0;
				this.i = infoToAdd;
				this.q = new global::RegistryAccess.CPersistentApplicationSettings();
				this.k = null;
				this.b = global::System.IntPtr.Zero;
				this.c = global::System.IntPtr.Zero;
				this.d = false;
				this.l = false;
				this.p = false;
				this.a = new global::custom_controls.LocalCbtHook();
				this.m = global::System.Windows.Forms.MessageBoxButtons.OK;
				this.n = errorMsgId;
				this.o = global::custom_exception.CCustomException.MapErrorIdToString(errorMsgId);
				string value = string.Empty;
				value = this.f.GetString(appNameID);
				if (!string.IsNullOrEmpty(value))
				{
					this.g = value;
				}
				else
				{
					this.g = appNameID;
				}
				this.h = this.f.GetString(this.o);
				if (infoToAdd != null)
				{
					this.h = this.h.Replace("%1", infoToAdd);
				}
				this.a.WindowCreated -= this.c;
				this.a.WindowCreated += this.c;
				this.a.WindowDestroyed -= this.b;
				this.a.WindowDestroyed += this.b;
				this.a.WindowActivated -= this.a;
				this.a.WindowActivated += this.a;
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0004BFAC File Offset: 0x0004A1AC
		public CMsgDialog(bool isRightToLeft, global::resource_handler.CResourceHandler resourcemManager, int errorMsgId, string appNameID, string infoToAdd, string append)
		{
			try
			{
				this.e = isRightToLeft;
				this.f = resourcemManager;
				string s = string.Empty;
				string @string = this.f.GetString("FONT_FAMILY");
				s = this.f.GetString("FONT_SIZE");
				float emSize = float.Parse(s, global::System.Globalization.NumberStyles.Float, global::System.Globalization.NumberFormatInfo.InvariantInfo);
				this.j = new global::System.Drawing.Font(@string, emSize);
				this.r = 0.0;
				this.i = infoToAdd;
				this.q = new global::RegistryAccess.CPersistentApplicationSettings();
				this.k = null;
				this.b = global::System.IntPtr.Zero;
				this.c = global::System.IntPtr.Zero;
				this.d = false;
				this.l = false;
				this.p = false;
				this.a = new global::custom_controls.LocalCbtHook();
				this.m = global::System.Windows.Forms.MessageBoxButtons.OK;
				this.n = errorMsgId;
				this.o = global::custom_exception.CCustomException.MapErrorIdToString(errorMsgId);
				this.g = this.f.GetString(appNameID);
				this.h = this.f.GetString(this.o);
				if (infoToAdd != null)
				{
					this.h = this.h.Replace("%1", infoToAdd);
				}
				if (append != null)
				{
					this.h += append;
				}
				this.a.WindowCreated -= this.c;
				this.a.WindowCreated += this.c;
				this.a.WindowDestroyed -= this.b;
				this.a.WindowDestroyed += this.b;
				this.a.WindowActivated -= this.a;
				this.a.WindowActivated += this.a;
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0004C1A0 File Offset: 0x0004A3A0
		public global::System.Windows.Forms.DialogResult Show(global::System.Windows.Forms.IWin32Window owner, bool showCheckBox, global::System.Windows.Forms.DialogResult dr, global::System.Windows.Forms.MessageBoxButtons buttons, global::System.Windows.Forms.MessageBoxIcon icon)
		{
			global::System.Windows.Forms.DialogResult result;
			for (;;)
			{
				this.k = owner;
				this.p = showCheckBox;
				this.m = buttons;
				try
				{
					int num = 9;
					for (;;)
					{
						global::System.Collections.ArrayList arrayList;
						global::RegistryAccess.NoShowWarning noShowWarning;
						switch (num)
						{
						case 0:
							goto IL_233;
						case 1:
							goto IL_7B;
						case 2:
							if (arrayList.Count > 0)
							{
								num = 11;
								continue;
							}
							goto IL_FF;
						case 3:
							if (global::System.Convert.ToBoolean(noShowWarning.Value))
							{
								num = 8;
								continue;
							}
							goto IL_FF;
						case 4:
							if (!this.p)
							{
								num = 5;
								continue;
							}
							arrayList = new global::System.Collections.ArrayList();
							noShowWarning = default(global::RegistryAccess.NoShowWarning);
							noShowWarning.ID = string.Empty;
							noShowWarning.Value = -1;
							this.q.GetNoShowWarning(this.o, ref arrayList);
							num = 2;
							continue;
						case 5:
							this.a.Install();
							dr = global::System.Windows.Forms.MessageBox.Show(this.h, this.g, buttons, icon);
							this.a.Uninstall();
							num = 0;
							continue;
						case 6:
							goto IL_23E;
						case 7:
							goto IL_1B7;
						case 8:
							result = dr;
							num = 1;
							continue;
						case 10:
							this.h = this.f.GetString("ERROR_NO") + this.n.ToString() + "\r\r" + this.h;
							if (true)
							{
							}
							num = 7;
							continue;
						case 11:
							noShowWarning = (global::RegistryAccess.NoShowWarning)arrayList[0];
							num = 3;
							continue;
						case 12:
							goto IL_233;
						}
						if (global::System.Windows.Forms.MessageBoxIcon.Hand == icon)
						{
							num = 10;
							continue;
						}
						goto IL_1B7;
						IL_FF:
						this.a.Install();
						dr = global::System.Windows.Forms.MessageBox.Show(this.h, this.g, buttons, icon);
						this.a.Uninstall();
						arrayList.Clear();
						noShowWarning.ID = this.o;
						noShowWarning.Value = (int)global::System.Convert.ToInt16(this.l);
						arrayList.Add(noShowWarning);
						this.q.SetNoShowWarning(arrayList);
						num = 12;
						continue;
						IL_1B7:
						num = 4;
						continue;
						IL_233:
						num = 6;
					}
					IL_7B:
					goto IL_249;
					IL_23E:
					break;
				}
				catch (global::System.Exception)
				{
					break;
				}
				IL_249:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_25F;
				}
			}
			return dr;
			IL_25F:
			if (false)
			{
			}
			return result;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0004C43C File Offset: 0x0004A63C
		public global::System.Windows.Forms.DialogResult Show(global::System.Windows.Forms.IWin32Window owner, global::System.Windows.Forms.MessageBoxButtons buttons, global::System.Windows.Forms.MessageBoxIcon icon)
		{
			this.k = owner;
			this.p = false;
			this.m = buttons;
			global::System.Windows.Forms.DialogResult result = global::System.Windows.Forms.DialogResult.None;
			try
			{
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_9F;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9F;
						default:
							if (false)
							{
							}
							this.h = this.f.GetString("ERROR_NO") + this.n.ToString() + "\r\r" + this.h;
							num = 0;
							continue;
						}
						break;
					case 2:
						goto IL_D4;
					}
					if (global::System.Windows.Forms.MessageBoxIcon.Hand == icon)
					{
						num = 1;
						continue;
					}
					IL_9F:
					this.a.Install();
					result = global::System.Windows.Forms.MessageBox.Show(this.h, this.g, buttons, icon);
					this.a.Uninstall();
					num = 2;
				}
				IL_D4:;
			}
			catch (global::System.Exception)
			{
			}
			if (true)
			{
			}
			return result;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0004C548 File Offset: 0x0004A748
		private void c(object A_0, global::custom_controls.CbtEventArgs A_1)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_54:
				this.d = false;
				this.b = A_1.Handle;
				if (true)
				{
				}
				num = 1;
				break;
			case 1:
				goto IL_20;
			default:
				goto IL_20;
			}
			for (;;)
			{
				IL_30:
				switch (num)
				{
				case 1:
					return;
				case 2:
					goto IL_52;
				}
				if (!A_1.IsDialogWindow)
				{
					return;
				}
				num = 2;
			}
			IL_52:
			goto IL_54;
			IL_20:
			if (false)
			{
			}
			num = 0;
			goto IL_30;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0004C5D0 File Offset: 0x0004A7D0
		private void b(object A_0, global::custom_controls.CbtEventArgs A_1)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (1 == (int)global::custom_controls.CMsgDialog.SendMessage(this.c, 240, global::System.IntPtr.Zero, global::System.IntPtr.Zero))
					{
						num = 2;
						continue;
					}
					return;
				case 1:
					if (true)
					{
					}
					this.d = false;
					this.b = global::System.IntPtr.Zero;
					num = 0;
					continue;
				case 2:
					this.l = true;
					num = 4;
					continue;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						if (false)
						{
						}
						break;
					}
					break;
				case 4:
					return;
				}
				if (!(A_1.Handle == this.b))
				{
					break;
				}
				num = 1;
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0004C6A8 File Offset: 0x0004A8A8
		private void a(object A_0, global::custom_controls.CbtEventArgs A_1)
		{
			try
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
						IL_19B:
						num = 29;
						break;
					default:
						if (false)
						{
						}
						num = 13;
						break;
					}
					for (;;)
					{
						global::System.IntPtr intPtr;
						global::custom_controls.CMsgDialog.a a;
						global::System.Drawing.Rectangle rectangle;
						global::System.IntPtr intPtr2;
						switch (num)
						{
						case 0:
						{
							global::System.Windows.Forms.Form form;
							if (form.WindowState == global::System.Windows.Forms.FormWindowState.Minimized)
							{
								num = 37;
								continue;
							}
							goto IL_3DB;
						}
						case 1:
							num = 25;
							continue;
						case 2:
							goto IL_17C;
						case 3:
							if (intPtr == global::System.IntPtr.Zero)
							{
								num = 30;
								continue;
							}
							goto IL_45E;
						case 4:
							num = 0;
							continue;
						case 5:
							if (a.d == a.b)
							{
								goto IL_19B;
							}
							goto IL_4E9;
						case 6:
							a.c = (a.a = global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 2);
							num = 2;
							continue;
						case 7:
							num = 19;
							continue;
						case 8:
							goto IL_4E9;
						case 9:
							goto IL_3DB;
						case 10:
							num = 21;
							continue;
						case 11:
							if (this.k != null)
							{
								num = 42;
								continue;
							}
							num = 38;
							continue;
						case 12:
							num = 24;
							continue;
						case 14:
						{
							global::System.Windows.Forms.Form form;
							if (form != null)
							{
								num = 26;
								continue;
							}
							goto IL_3DB;
						}
						case 15:
							if (this.p)
							{
								num = 41;
								continue;
							}
							goto IL_154;
						case 16:
						{
							global::System.Windows.Forms.Form form;
							if (form.IsMdiContainer)
							{
								num = 4;
								continue;
							}
							goto IL_488;
						}
						case 17:
							if (this.k is global::System.Windows.Forms.Form)
							{
								num = 20;
								continue;
							}
							goto IL_3DB;
						case 18:
						{
							global::System.Windows.Forms.Form form;
							if (form != null)
							{
								num = 33;
								continue;
							}
							goto IL_488;
						}
						case 19:
						{
							global::System.Windows.Forms.Form form;
							if (form.MdiParent.WindowState == global::System.Windows.Forms.FormWindowState.Minimized)
							{
								num = 34;
								continue;
							}
							goto IL_3DB;
						}
						case 20:
						{
							global::System.Windows.Forms.Form form = (global::System.Windows.Forms.Form)this.k;
							num = 18;
							continue;
						}
						case 21:
							goto IL_326;
						case 22:
							if (a.c == a.a)
							{
								num = 6;
								continue;
							}
							goto IL_17C;
						case 23:
							goto IL_45E;
						case 24:
							goto IL_1B8;
						case 25:
							if (true)
							{
							}
							if (rectangle.Top < 0)
							{
								num = 27;
								continue;
							}
							goto IL_5E2;
						case 26:
							num = 32;
							continue;
						case 27:
							goto IL_29B;
						case 28:
							goto IL_154;
						case 29:
							a.d = (a.b = global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height / 2);
							num = 8;
							continue;
						case 30:
							intPtr = global::custom_controls.CMsgDialog.GetActiveWindow();
							num = 23;
							continue;
						case 31:
							goto IL_3DB;
						case 32:
						{
							global::System.Windows.Forms.Form form;
							if (form.IsMdiChild)
							{
								num = 7;
								continue;
							}
							goto IL_3DB;
						}
						case 33:
							num = 16;
							continue;
						case 34:
							global::custom_controls.CMsgDialog.ShowWindow(global::custom_controls.CMsgDialog.GetParent(this.b), 9);
							num = 9;
							continue;
						case 35:
							goto IL_616;
						case 36:
							if (rectangle.Left >= 0)
							{
								num = 1;
								continue;
							}
							goto IL_29B;
						case 37:
							global::custom_controls.CMsgDialog.ShowWindow(intPtr, 9);
							num = 31;
							continue;
						case 38:
							intPtr2 = global::System.IntPtr.Zero;
							goto IL_374;
						case 39:
							if (this.d)
							{
								num = 12;
								continue;
							}
							this.d = true;
							this.a();
							num = 15;
							continue;
						case 40:
							goto IL_5E2;
						case 41:
							this.b();
							num = 28;
							continue;
						case 42:
							num = 43;
							continue;
						case 43:
							intPtr2 = this.k.Handle;
							goto IL_374;
						}
						if (this.b != A_1.Handle)
						{
							num = 10;
							continue;
						}
						num = 39;
						continue;
						IL_154:
						num = 11;
						continue;
						IL_17C:
						num = 5;
						continue;
						IL_29B:
						int x = (global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - rectangle.Width) / 2;
						int y = (global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - rectangle.Height) / 2;
						rectangle = new global::System.Drawing.Rectangle(x, y, rectangle.Width, rectangle.Height);
						num = 40;
						continue;
						IL_374:
						intPtr = intPtr2;
						num = 3;
						continue;
						IL_3DB:
						global::custom_controls.CMsgDialog.a a2 = default(global::custom_controls.CMsgDialog.a);
						global::custom_controls.CMsgDialog.GetWindowRect(this.b, ref a2);
						a = default(global::custom_controls.CMsgDialog.a);
						global::custom_controls.CMsgDialog.GetWindowRect(intPtr, ref a);
						num = 22;
						continue;
						IL_45E:
						num = 17;
						continue;
						IL_488:
						num = 14;
						continue;
						IL_4E9:
						int num2 = (a2.a + a2.c - (a.a + a.c)) / 2;
						int num3 = (a2.b + a2.d - (a.b + a.d)) / 2;
						rectangle = new global::System.Drawing.Rectangle(a2.a - num2, a2.b - num3, a2.c - a2.a, a2.d - a2.b);
						num = 36;
						continue;
						IL_5E2:
						global::custom_controls.CMsgDialog.MoveWindow(this.b, rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height, true);
						num = 35;
					}
					IL_1B8:
					IL_326:
					IL_616:
					break;
				}
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0004CCF8 File Offset: 0x0004AEF8
		private void b()
		{
			switch (0)
			{
			default:
			{
				global::System.IntPtr intPtr;
				global::System.Drawing.Font font;
				int num;
				for (;;)
				{
					IL_27:
					intPtr = this.j.ToHfont();
					font = global::System.Drawing.Font.FromHfont(intPtr);
					num = 0;
					global::System.IntPtr dlgItem = global::custom_controls.CMsgDialog.GetDlgItem(this.b, 20);
					int num2 = 0;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (dlgItem != global::System.IntPtr.Zero)
							{
								num2 = 3;
								continue;
							}
							num = (int)font.GetHeight();
							num2 = 1;
							continue;
						case 1:
							goto IL_86;
						case 2:
							goto IL_E7;
						case 3:
						{
							global::custom_controls.CMsgDialog.a a = default(global::custom_controls.CMsgDialog.a);
							global::custom_controls.CMsgDialog.GetWindowRect(dlgItem, ref a);
							global::custom_controls.CMsgDialog.b b = default(global::custom_controls.CMsgDialog.b);
							b.a = a.a;
							b.b = a.b;
							global::custom_controls.CMsgDialog.ScreenToClient(this.b, ref b);
							num = b.a;
							num2 = 2;
							continue;
						}
						}
						goto IL_27;
					}
					IL_E7:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_FD;
					}
				}
				IL_86:
				if (true)
				{
				}
				goto IL_105;
				IL_FD:
				if (false)
				{
				}
				IL_105:
				global::custom_controls.CMsgDialog.a a2 = default(global::custom_controls.CMsgDialog.a);
				global::custom_controls.CMsgDialog.GetClientRect(this.b, ref a2);
				int a_ = a2.d - a2.b;
				global::custom_controls.CMsgDialog.GetWindowRect(this.b, ref a2);
				global::custom_controls.CMsgDialog.MoveWindow(this.b, a2.a, a2.b, a2.c - a2.a, a2.d - a2.b + (int)font.GetHeight() * 2, true);
				this.c = global::custom_controls.CMsgDialog.CreateWindowEx(0, "button", "Don't Show this again", 1342242819, num, a_, (int)(this.r * (double)(a2.c - a2.a - num)), (int)font.GetHeight(), this.b, global::System.IntPtr.Zero, global::System.IntPtr.Zero, global::System.IntPtr.Zero);
				global::custom_controls.CMsgDialog.SendMessage(this.c, 48, intPtr, new global::System.IntPtr(1));
				string @string = this.f.GetString("CHECKBOX_NOSHOW");
				global::custom_controls.CMsgDialog.SetWindowText((int)this.c, @string);
				return;
			}
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0004CF10 File Offset: 0x0004B110
		private void a()
		{
			switch (0)
			{
			default:
			{
				global::custom_controls.CMsgDialog.a a;
				for (;;)
				{
					IL_5B:
					global::System.IntPtr intPtr = global::custom_controls.CMsgDialog.SendMessage(this.b, 49, global::System.IntPtr.Zero, global::System.IntPtr.Zero);
					global::System.Drawing.Font font = global::System.Drawing.Font.FromHfont(intPtr);
					intPtr = this.j.ToHfont();
					global::System.Drawing.Font font2 = global::System.Drawing.Font.FromHfont(intPtr);
					this.r = (double)font2.GetHeight() / (double)font.GetHeight();
					string a_ = string.Empty;
					a = default(global::custom_controls.CMsgDialog.a);
					global::custom_controls.CMsgDialog.GetWindowRect(this.b, ref a);
					global::System.IntPtr dlgItem = global::custom_controls.CMsgDialog.GetDlgItem(this.b, 65535);
					global::custom_controls.CMsgDialog.a a2 = default(global::custom_controls.CMsgDialog.a);
					global::custom_controls.CMsgDialog.GetWindowRect(dlgItem, ref a2);
					a2.c = a2.a + (int)(this.r * (double)(a2.c - a2.a)) + font2.Height;
					a2.d = a2.b + (int)(this.r * (double)(a2.d - a2.b)) + font2.Height;
					global::custom_controls.CMsgDialog.b b = default(global::custom_controls.CMsgDialog.b);
					b.a = a2.a;
					b.b = a2.b;
					global::custom_controls.CMsgDialog.ScreenToClient(this.b, ref b);
					global::custom_controls.CMsgDialog.MoveWindow(dlgItem, b.a, b.b, a2.c - a2.a, a2.d - a2.b, true);
					global::custom_controls.CMsgDialog.SendMessage(dlgItem, 48, intPtr, new global::System.IntPtr(1));
					global::custom_controls.CMsgDialog.GetWindowRect(dlgItem, ref a2);
					for (;;)
					{
						IL_1BF:
						int num = 5;
						for (;;)
						{
							global::System.Windows.Forms.MessageBoxButtons messageBoxButtons;
							int num2;
							int num3;
							global::System.IntPtr dlgItem10;
							switch (num)
							{
							case 0:
								switch (messageBoxButtons)
								{
								case global::System.Windows.Forms.MessageBoxButtons.OK:
								{
									global::System.IntPtr dlgItem2 = global::custom_controls.CMsgDialog.GetDlgItem(this.b, 1);
									global::custom_controls.CMsgDialog.a a3 = default(global::custom_controls.CMsgDialog.a);
									global::custom_controls.CMsgDialog.GetWindowRect(dlgItem2, ref a3);
									a3.c = a3.a + (int)(this.r * (double)(a3.c - a3.a));
									a3.d = a3.b + (int)(this.r * (double)(a3.d - a3.b));
									global::custom_controls.CMsgDialog.b b2 = default(global::custom_controls.CMsgDialog.b);
									b2.a = (a.c - a.a) / 2 - (a3.c - a3.a) / 2;
									b2.b = a2.d - a.b + num2;
									global::custom_controls.CMsgDialog.MoveWindow(dlgItem2, b2.a, b2.b, a3.c - a3.a, a3.d - a3.b, true);
									global::custom_controls.CMsgDialog.SendMessage(dlgItem2, 48, intPtr, new global::System.IntPtr(1));
									a_ = this.f.GetString("BUTTON_OK");
									global::custom_controls.CMsgDialog.SetWindowText((int)dlgItem2, a_);
									global::custom_controls.CMsgDialog.GetWindowRect(dlgItem2, ref a3);
									a.d = a3.d + num3;
									num = 1;
									continue;
								}
								case global::System.Windows.Forms.MessageBoxButtons.OKCancel:
								{
									global::System.IntPtr dlgItem3 = global::custom_controls.CMsgDialog.GetDlgItem(this.b, 1);
									global::custom_controls.CMsgDialog.a a4 = default(global::custom_controls.CMsgDialog.a);
									global::custom_controls.CMsgDialog.GetWindowRect(dlgItem3, ref a4);
									global::System.IntPtr dlgItem4 = global::custom_controls.CMsgDialog.GetDlgItem(this.b, 2);
									global::custom_controls.CMsgDialog.a a5 = default(global::custom_controls.CMsgDialog.a);
									global::custom_controls.CMsgDialog.GetWindowRect(dlgItem4, ref a5);
									int num4 = (int)(this.r * (double)(a5.c - a4.a));
									a4.c = a4.a + (int)(this.r * (double)(a4.c - a4.a));
									a4.d = a4.b + (int)(this.r * (double)(a4.d - a4.b));
									a5.c = a5.a + (int)(this.r * (double)(a5.c - a5.a));
									a5.d = a5.b + (int)(this.r * (double)(a5.d - a5.b));
									global::custom_controls.CMsgDialog.b b3 = default(global::custom_controls.CMsgDialog.b);
									b3.a = (a.c - a.a) / 2 - num4 / 2;
									b3.b = a2.d - a.b + num2;
									global::custom_controls.CMsgDialog.MoveWindow(dlgItem3, b3.a, b3.b, a4.c - a4.a, a4.d - a4.b, true);
									global::custom_controls.CMsgDialog.b b4 = default(global::custom_controls.CMsgDialog.b);
									b4.a = (a.c - a.a) / 2 - num4 / 2 + num4 - (a5.c - a5.a);
									b4.b = b3.b;
									global::custom_controls.CMsgDialog.MoveWindow(dlgItem4, b4.a, b4.b, a5.c - a5.a, a5.d - a5.b, true);
									global::custom_controls.CMsgDialog.SendMessage(dlgItem3, 48, intPtr, new global::System.IntPtr(1));
									a_ = this.f.GetString("BUTTON_OK");
									global::custom_controls.CMsgDialog.SetWindowText((int)dlgItem3, a_);
									global::custom_controls.CMsgDialog.SendMessage(dlgItem4, 48, intPtr, new global::System.IntPtr(1));
									a_ = this.f.GetString("BUTTON_CANCEL");
									global::custom_controls.CMsgDialog.SetWindowText((int)dlgItem4, a_);
									global::custom_controls.CMsgDialog.GetWindowRect(dlgItem3, ref a4);
									a.d = a4.d + num3;
									num = 13;
									continue;
								}
								case global::System.Windows.Forms.MessageBoxButtons.AbortRetryIgnore:
									goto IL_B80;
								case global::System.Windows.Forms.MessageBoxButtons.YesNoCancel:
								{
									global::System.IntPtr dlgItem5 = global::custom_controls.CMsgDialog.GetDlgItem(this.b, 6);
									global::custom_controls.CMsgDialog.a a6 = default(global::custom_controls.CMsgDialog.a);
									global::custom_controls.CMsgDialog.GetWindowRect(dlgItem5, ref a6);
									global::System.IntPtr dlgItem6 = global::custom_controls.CMsgDialog.GetDlgItem(this.b, 7);
									global::custom_controls.CMsgDialog.a a7 = default(global::custom_controls.CMsgDialog.a);
									global::custom_controls.CMsgDialog.GetWindowRect(dlgItem6, ref a7);
									global::System.IntPtr dlgItem7 = global::custom_controls.CMsgDialog.GetDlgItem(this.b, 2);
									global::custom_controls.CMsgDialog.a a8 = default(global::custom_controls.CMsgDialog.a);
									global::custom_controls.CMsgDialog.GetWindowRect(dlgItem7, ref a8);
									int num5 = (int)(this.r * (double)(a8.c - a6.a));
									a6.c = a6.a + (int)(this.r * (double)(a6.c - a6.a));
									a6.d = a6.b + (int)(this.r * (double)(a6.d - a6.b));
									a7.c = a7.a + (int)(this.r * (double)(a7.c - a7.a));
									a7.d = a7.b + (int)(this.r * (double)(a7.d - a7.b));
									a8.c = a8.a + (int)(this.r * (double)(a8.c - a8.a));
									a8.d = a8.b + (int)(this.r * (double)(a8.d - a8.b));
									global::custom_controls.CMsgDialog.b b5 = default(global::custom_controls.CMsgDialog.b);
									b5.a = (a.c - a.a) / 2 - num5 / 2;
									b5.b = a2.d - a.b + num2;
									global::custom_controls.CMsgDialog.MoveWindow(dlgItem5, b5.a, b5.b, a6.c - a6.a, a6.d - a6.b, true);
									global::custom_controls.CMsgDialog.b b6 = default(global::custom_controls.CMsgDialog.b);
									b6.a = (a.c - a.a) / 2 - num5 / 2 + num5 / 2 - (a7.c - a7.a) / 2;
									b6.b = b5.b;
									global::custom_controls.CMsgDialog.MoveWindow(dlgItem6, b6.a, b6.b, a7.c - a7.a, a7.d - a7.b, true);
									global::custom_controls.CMsgDialog.b b7 = default(global::custom_controls.CMsgDialog.b);
									b7.a = (a.c - a.a) / 2 - num5 / 2 + num5 - (a8.c - a8.a);
									b7.b = b5.b;
									global::custom_controls.CMsgDialog.MoveWindow(dlgItem7, b7.a, b7.b, a8.c - a8.a, a8.d - a8.b, true);
									global::custom_controls.CMsgDialog.SendMessage(dlgItem5, 48, intPtr, new global::System.IntPtr(1));
									a_ = this.f.GetString("BUTTON_YES");
									global::custom_controls.CMsgDialog.SetWindowText((int)dlgItem5, a_);
									global::custom_controls.CMsgDialog.SendMessage(dlgItem6, 48, intPtr, new global::System.IntPtr(1));
									a_ = this.f.GetString("BUTTON_NO");
									global::custom_controls.CMsgDialog.SetWindowText((int)dlgItem6, a_);
									global::custom_controls.CMsgDialog.SendMessage(dlgItem7, 48, intPtr, new global::System.IntPtr(1));
									a_ = this.f.GetString("BUTTON_CANCEL");
									global::custom_controls.CMsgDialog.SetWindowText((int)dlgItem7, a_);
									global::custom_controls.CMsgDialog.GetWindowRect(dlgItem5, ref a6);
									a.d = a6.d + num3;
									num = 11;
									continue;
								}
								case global::System.Windows.Forms.MessageBoxButtons.YesNo:
								{
									global::System.IntPtr dlgItem8 = global::custom_controls.CMsgDialog.GetDlgItem(this.b, 6);
									global::custom_controls.CMsgDialog.a a9 = default(global::custom_controls.CMsgDialog.a);
									global::custom_controls.CMsgDialog.GetWindowRect(dlgItem8, ref a9);
									global::System.IntPtr dlgItem9 = global::custom_controls.CMsgDialog.GetDlgItem(this.b, 7);
									global::custom_controls.CMsgDialog.a a10 = default(global::custom_controls.CMsgDialog.a);
									global::custom_controls.CMsgDialog.GetWindowRect(dlgItem9, ref a10);
									int num6 = (int)(this.r * (double)(a10.c - a9.a));
									a9.c = a9.a + (int)(this.r * (double)(a9.c - a9.a));
									a9.d = a9.b + (int)(this.r * (double)(a9.d - a9.b));
									a10.c = a10.a + (int)(this.r * (double)(a10.c - a10.a));
									a10.d = a10.b + (int)(this.r * (double)(a10.d - a10.b));
									global::custom_controls.CMsgDialog.b b8 = default(global::custom_controls.CMsgDialog.b);
									b8.a = (a.c - a.a) / 2 - num6 / 2;
									b8.b = a2.d - a.b + num2;
									global::custom_controls.CMsgDialog.MoveWindow(dlgItem8, b8.a, b8.b, a9.c - a9.a, a9.d - a9.b, true);
									global::custom_controls.CMsgDialog.b b9 = default(global::custom_controls.CMsgDialog.b);
									b9.a = (a.c - a.a) / 2 - num6 / 2 + num6 - (a10.c - a10.a);
									b9.b = b8.b;
									global::custom_controls.CMsgDialog.MoveWindow(dlgItem9, b9.a, b9.b, a10.c - a10.a, a10.d - a10.b, true);
									global::custom_controls.CMsgDialog.SendMessage(dlgItem8, 48, intPtr, new global::System.IntPtr(1));
									a_ = this.f.GetString("BUTTON_YES");
									global::custom_controls.CMsgDialog.SetWindowText((int)dlgItem8, a_);
									global::custom_controls.CMsgDialog.SendMessage(dlgItem9, 48, intPtr, new global::System.IntPtr(1));
									a_ = this.f.GetString("BUTTON_NO");
									global::custom_controls.CMsgDialog.SetWindowText((int)dlgItem9, a_);
									global::custom_controls.CMsgDialog.GetWindowRect(dlgItem8, ref a9);
									a.d = a9.d + num3;
									num = 2;
									continue;
								}
								default:
									num = 14;
									continue;
								}
								break;
							case 1:
								goto IL_6EB;
							case 2:
								if (true)
								{
								}
								goto IL_6EB;
							case 3:
								goto IL_B80;
							case 4:
								if (dlgItem10 != global::System.IntPtr.Zero)
								{
									num = 16;
									continue;
								}
								goto IL_E1C;
							case 5:
								if (a.c <= a2.c + 40)
								{
									num = 10;
									continue;
								}
								goto IL_719;
							case 6:
								goto IL_E1C;
							case 7:
								goto IL_B48;
							case 8:
								global::custom_controls.CMsgDialog.MoveWindow(dlgItem10, 0, a2.d - a.b, a.c - a.a, a.d - a2.d, true);
								num = 7;
								continue;
							case 9:
								goto IL_6EB;
							case 10:
								a.c = a2.c + 40;
								num = 12;
								continue;
							case 11:
								goto IL_6EB;
							case 12:
								goto IL_719;
							case 13:
								goto IL_6EB;
							case 14:
								num = 3;
								continue;
							case 15:
								if (dlgItem10 != global::System.IntPtr.Zero)
								{
									num = 8;
									continue;
								}
								goto IL_E5C;
							case 16:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1BF;
								default:
									if (false)
									{
									}
									num2 = 20;
									num = 6;
									continue;
								}
								break;
							}
							goto IL_5B;
							IL_6EB:
							num = 15;
							continue;
							IL_719:
							dlgItem10 = global::custom_controls.CMsgDialog.GetDlgItem(this.b, 51966);
							num2 = 0;
							num3 = 20;
							num = 4;
							continue;
							IL_B80:
							global::System.IntPtr dlgItem11 = global::custom_controls.CMsgDialog.GetDlgItem(this.b, 1);
							global::custom_controls.CMsgDialog.a a11 = default(global::custom_controls.CMsgDialog.a);
							global::custom_controls.CMsgDialog.GetWindowRect(dlgItem11, ref a11);
							a11.c = a11.a + (int)(this.r * (double)(a11.c - a11.a));
							a11.d = a11.b + (int)(this.r * (double)(a11.d - a11.b));
							global::custom_controls.CMsgDialog.b b10 = default(global::custom_controls.CMsgDialog.b);
							b10.a = (a.c - a.a) / 2 - (a11.c - a11.a) / 2;
							b10.b = a2.d - a.b + num2;
							global::custom_controls.CMsgDialog.MoveWindow(dlgItem11, b10.a, b10.b, a11.c - a11.a, a11.d - a11.b, true);
							global::custom_controls.CMsgDialog.SendMessage(dlgItem11, 48, intPtr, new global::System.IntPtr(1));
							a_ = this.f.GetString("BUTTON_OK");
							global::custom_controls.CMsgDialog.SetWindowText((int)dlgItem11, a_);
							global::custom_controls.CMsgDialog.GetWindowRect(dlgItem11, ref a11);
							a.d = a11.d + num3;
							num = 9;
							continue;
							IL_E1C:
							messageBoxButtons = this.m;
							num = 0;
						}
					}
				}
				IL_B48:
				IL_E5C:
				global::custom_controls.CMsgDialog.MoveWindow(this.b, a.a, a.b, a.c - a.a, a.d - a.b, true);
				return;
			}
			}
		}

		// Token: 0x0400034A RID: 842
		private global::custom_controls.LocalCbtHook a;

		// Token: 0x0400034B RID: 843
		private global::System.IntPtr b;

		// Token: 0x0400034C RID: 844
		private global::System.IntPtr c;

		// Token: 0x0400034D RID: 845
		private bool d;

		// Token: 0x0400034E RID: 846
		private bool e;

		// Token: 0x0400034F RID: 847
		private global::resource_handler.CResourceHandler f;

		// Token: 0x04000350 RID: 848
		private string g;

		// Token: 0x04000351 RID: 849
		private string h;

		// Token: 0x04000352 RID: 850
		private string i;

		// Token: 0x04000353 RID: 851
		private global::System.Drawing.Font j;

		// Token: 0x04000354 RID: 852
		private global::System.Windows.Forms.IWin32Window k;

		// Token: 0x04000355 RID: 853
		private bool l;

		// Token: 0x04000356 RID: 854
		private global::System.Windows.Forms.MessageBoxButtons m;

		// Token: 0x04000357 RID: 855
		private int n;

		// Token: 0x04000358 RID: 856
		private string o;

		// Token: 0x04000359 RID: 857
		private bool p;

		// Token: 0x0400035A RID: 858
		private global::RegistryAccess.IPersistentApplicationSettings q;

		// Token: 0x0400035B RID: 859
		private double r;

		// Token: 0x02000077 RID: 119
		private struct a
		{
			// Token: 0x0400035C RID: 860
			public int a;

			// Token: 0x0400035D RID: 861
			public int b;

			// Token: 0x0400035E RID: 862
			public int c;

			// Token: 0x0400035F RID: 863
			public int d;
		}

		// Token: 0x02000078 RID: 120
		private struct b
		{
			// Token: 0x04000360 RID: 864
			public int a;

			// Token: 0x04000361 RID: 865
			public int b;
		}
	}
}
