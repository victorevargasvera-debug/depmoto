using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using constants;
using custom_exception;
using resource_handler;

namespace custom_controls
{
	// Token: 0x0200003E RID: 62
	public class CDlgFileOpenSave
	{
		// Token: 0x06000313 RID: 787
		[global::System.Runtime.InteropServices.DllImport("Comdlg32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
		private static extern bool GetSaveFileName(ref global::custom_controls.CDlgFileOpenSave.c A_0);

		// Token: 0x06000314 RID: 788
		[global::System.Runtime.InteropServices.DllImport("Comdlg32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
		private static extern bool GetOpenFileName(ref global::custom_controls.CDlgFileOpenSave.c A_0);

		// Token: 0x06000315 RID: 789
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetWindowPos(int A_0, int A_1, int A_2, int A_3, int A_4, int A_5, uint A_6);

		// Token: 0x06000316 RID: 790
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool GetWindowRect(int A_0, ref global::custom_controls.CDlgFileOpenSave.a A_1);

		// Token: 0x06000317 RID: 791
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int GetParent(int A_0);

		// Token: 0x06000318 RID: 792
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		private static extern bool SetWindowText(int A_0, string A_1);

		// Token: 0x06000319 RID: 793
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		private static extern int GetWindowText(int A_0, global::System.Text.StringBuilder A_1, int A_2);

		// Token: 0x0600031A RID: 794
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SendMessage(int A_0, int A_1, int A_2, int A_3);

		// Token: 0x0600031B RID: 795
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		private static extern int SendMessage(int A_0, int A_1, int A_2, string A_3);

		// Token: 0x0600031C RID: 796
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern global::System.IntPtr SendMessage(global::System.IntPtr A_0, uint A_1, global::System.IntPtr A_2, global::System.IntPtr A_3);

		// Token: 0x0600031D RID: 797
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool DestroyWindow(int A_0);

		// Token: 0x0600031E RID: 798
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern int GetDlgItem(int A_0, int A_1);

		// Token: 0x0600031F RID: 799
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		private static extern int CreateWindowEx(int A_0, string A_1, string A_2, uint A_3, int A_4, int A_5, int A_6, int A_7, int A_8, int A_9, int A_10, int A_11);

		// Token: 0x06000320 RID: 800
		[global::System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowLong")]
		private static extern int b(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2);

		// Token: 0x06000321 RID: 801
		[global::System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
		private static extern global::System.IntPtr a(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2);

		// Token: 0x06000322 RID: 802
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		private static extern bool GetDiskFreeSpaceEx(string A_0, out long A_1, out long A_2, out long A_3);

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00036964 File Offset: 0x00034B64
		// (set) Token: 0x06000324 RID: 804 RVA: 0x000369A8 File Offset: 0x00034BA8
		public string DefaultExt
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
				return this.a7;
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
				this.a7 = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000325 RID: 805 RVA: 0x000369EC File Offset: 0x00034BEC
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00036A30 File Offset: 0x00034C30
		public string Filter
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
				return this.a5;
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
				this.a5 = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00036A74 File Offset: 0x00034C74
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00036AB8 File Offset: 0x00034CB8
		public int FilterIndex
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
				return this.bk;
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
				this.bk = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00036AFC File Offset: 0x00034CFC
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00036BB0 File Offset: 0x00034DB0
		public string CurrentFilter
		{
			get
			{
				for (;;)
				{
					IL_00:
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
								goto IL_00;
							default:
								if (false)
								{
								}
								goto IL_48;
							}
							break;
						case 1:
							num = 2;
							continue;
						case 2:
							if (this.a6 == string.Empty)
							{
								num = 0;
								continue;
							}
							goto IL_9F;
						case 3:
							goto IL_5D;
						}
						if (this.a6 != null)
						{
							if (true)
							{
							}
							num = 1;
							continue;
						}
						IL_48:
						this.a6 = this.a(1);
						num = 3;
					}
				}
				IL_5D:
				IL_9F:
				return this.a6;
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
				this.a6 = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00036BF4 File Offset: 0x00034DF4
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00036C38 File Offset: 0x00034E38
		public string FileName
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
				return this.a8;
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
				this.a8 = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00036C7C File Offset: 0x00034E7C
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00036CC0 File Offset: 0x00034EC0
		public string InitDir
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
				return this.a9;
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
				this.a9 = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00036D04 File Offset: 0x00034F04
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00036D48 File Offset: 0x00034F48
		public bool AllowMultipleFileSelection
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
				return this.bl;
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
				this.bl = value;
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00036D8C File Offset: 0x00034F8C
		public CDlgFileOpenSave(string sDailogType, global::resource_handler.CResourceHandler resMgr, bool bMirrored, string sAppId, global::System.IntPtr hwndHandle)
		{
			this.a5 = string.Empty;
			this.a7 = string.Empty;
			this.a8 = string.Empty;
			this.a9 = string.Empty;
			this.ba = sDailogType;
			this.bb = resMgr;
			this.bc = bMirrored;
			this.bd = string.Empty;
			this.m_sCurFileName = string.Empty;
			this.be = 0;
			this.bf = 0;
			this.bg = 0;
			this.bh = 0;
			this.bi = sAppId;
			this.bj = new global::System.IntPtr(0);
			this.bj = hwndHandle;
			this.bk = 1;
			this.bl = false;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00036E3C File Offset: 0x0003503C
		public static global::System.IntPtr SetWindowLongPtr(global::System.IntPtr hWnd, int nIndex, global::System.IntPtr dwNew)
		{
			while (global::System.IntPtr.Size == 8)
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
					return global::custom_controls.CDlgFileOpenSave.a(hWnd, nIndex, dwNew);
				}
			}
			return new global::System.IntPtr(global::custom_controls.CDlgFileOpenSave.b(hWnd, nIndex, dwNew));
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00036E98 File Offset: 0x00035098
		private bool d(string A_0)
		{
			if (true)
			{
			}
			if (string.IsNullOrEmpty(A_0))
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
				return false;
			}
			return global::constants.StringUtility.ValidateExtension(A_0, new string[]
			{
				".ctb",
				".mtb",
				".KEY",
				".ttb"
			});
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00036F14 File Offset: 0x00035114
		private int a(int A_0, int A_1, int A_2, int A_3)
		{
			switch (0)
			{
			default:
			{
				for (;;)
				{
					int num = 4;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_7F9;
						case 1:
							goto IL_CE;
						case 2:
							if (A_1 == 272)
							{
								num = 17;
								continue;
							}
							return 0;
						case 3:
							num = 13;
							continue;
						case 4:
							if (A_1 != 2)
							{
								num = 9;
								continue;
							}
							return 0;
						case 5:
						{
							int num2;
							if (5 == num2)
							{
								num = 0;
								continue;
							}
							global::custom_controls.CDlgFileOpenSave.c c;
							num2 = this.b(c.h);
							num = 8;
							continue;
						}
						case 6:
						{
							global::custom_controls.CDlgFileOpenSave.c c;
							try
							{
								if (true)
								{
								}
								global::custom_controls.CDlgFileOpenSave.d d = default(global::custom_controls.CDlgFileOpenSave.d);
								d = (global::custom_controls.CDlgFileOpenSave.d)global::System.Runtime.InteropServices.Marshal.PtrToStructure(new global::System.IntPtr(A_3), typeof(global::custom_controls.CDlgFileOpenSave.d));
								c = default(global::custom_controls.CDlgFileOpenSave.c);
								c = (global::custom_controls.CDlgFileOpenSave.c)global::System.Runtime.InteropServices.Marshal.PtrToStructure(d.b, typeof(global::custom_controls.CDlgFileOpenSave.c));
							}
							catch (global::System.Exception)
							{
								string @string = this.bb.GetString("NOT_CREATE_INSTANCE");
								global::System.Windows.Forms.MessageBox.Show(@string);
								global::custom_controls.CDlgFileOpenSave.SetWindowLongPtr(new global::System.IntPtr(A_0), 0, new global::System.IntPtr(0));
								return 0;
							}
							string text = c.h;
							num = 22;
							continue;
						}
						case 7:
						{
							if (A_1 != 78)
							{
								num = 10;
								continue;
							}
							global::custom_controls.CDlgFileOpenSave.b b = default(global::custom_controls.CDlgFileOpenSave.b);
							b.a = 0;
							b.b = 0;
							b.c = 0;
							int num3 = ((global::custom_controls.CDlgFileOpenSave.b)global::System.Runtime.InteropServices.Marshal.PtrToStructure(new global::System.IntPtr(A_3), typeof(global::custom_controls.CDlgFileOpenSave.b))).c;
							num = 11;
							continue;
						}
						case 8:
						{
							int num2;
							if (5 == num2)
							{
								num = 14;
								continue;
							}
							return 0;
						}
						case 9:
							num = 7;
							continue;
						case 10:
							num = 2;
							continue;
						case 11:
						{
							int num3;
							switch (num3)
							{
							case -607:
								goto IL_767;
							case -606:
							{
								string empty = string.Empty;
								num = 6;
								continue;
							}
							case -605:
							case -604:
							case -603:
							case -602:
								return 0;
							default:
								num = 12;
								continue;
							}
							break;
						}
						case 12:
							goto IL_756;
						case 13:
						{
							string text;
							if (!this.d(text))
							{
								num = 16;
								continue;
							}
							return 0;
						}
						case 14:
							goto IL_235;
						case 15:
							if (this.ba.Equals("SAVEAS_FILE_DAILOG"))
							{
								num = 20;
								continue;
							}
							return 0;
						case 16:
							goto IL_F8;
						case 17:
						{
							int parent = global::custom_controls.CDlgFileOpenSave.GetParent(A_0);
							global::System.Drawing.Font font = new global::System.Drawing.Font("Arial Unicode MS", 8.25f);
							num = 19;
							continue;
						}
						case 18:
						{
							global::custom_controls.CDlgFileOpenSave.c c;
							string text;
							if (!global::constants.StringUtility.ValidateExtension(text, new string[]
							{
								c.q
							}))
							{
								num = 1;
								continue;
							}
							int num2 = this.c(c.h);
							num = 5;
							continue;
						}
						case 19:
							try
							{
								num = 4;
								int result;
								for (;;)
								{
									int parent;
									switch (num)
									{
									case 0:
										goto IL_2B9;
									case 1:
										result = 0;
										num = 0;
										continue;
									case 2:
										try
										{
											for (;;)
											{
												int dlgItem = global::custom_controls.CDlgFileOpenSave.GetDlgItem(parent, 1148);
												global::System.IntPtr a_;
												global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(dlgItem), 48U, a_, new global::System.IntPtr(1));
												dlgItem = global::custom_controls.CDlgFileOpenSave.GetDlgItem(parent, 1136);
												global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(dlgItem), 48U, a_, new global::System.IntPtr(1));
												num = 0;
												for (;;)
												{
													string a_2;
													switch (num)
													{
													case 0:
														goto IL_3DF;
													case 1:
														goto IL_6AF;
													case 2:
														switch ((1 == 1) ? 1 : 0)
														{
														case 0:
														case 2:
															goto IL_3DF;
														default:
															if (false)
															{
															}
															a_2 = this.bb.GetString("LBL_ID_LOOKIN");
															dlgItem = global::custom_controls.CDlgFileOpenSave.GetDlgItem(parent, 1091);
															global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(dlgItem), 48U, a_, new global::System.IntPtr(1));
															global::custom_controls.CDlgFileOpenSave.SetWindowText(dlgItem, a_2);
															a_2 = this.bb.GetString("LBL_ID_FILENAME");
															dlgItem = global::custom_controls.CDlgFileOpenSave.GetDlgItem(parent, 1090);
															global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(dlgItem), 48U, a_, new global::System.IntPtr(1));
															global::custom_controls.CDlgFileOpenSave.SetWindowText(dlgItem, a_2);
															a_2 = this.bb.GetString("LBL_ID_FILESOFTYPE");
															dlgItem = global::custom_controls.CDlgFileOpenSave.GetDlgItem(parent, 1089);
															global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(dlgItem), 48U, a_, new global::System.IntPtr(1));
															global::custom_controls.CDlgFileOpenSave.SetWindowText(dlgItem, a_2);
															a_2 = this.bb.GetString("LBL_ID_FILE_OPEN");
															dlgItem = global::custom_controls.CDlgFileOpenSave.GetDlgItem(parent, 1);
															global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(dlgItem), 48U, a_, new global::System.IntPtr(1));
															global::custom_controls.CDlgFileOpenSave.SetWindowText(dlgItem, a_2);
															a_2 = this.bb.GetString("BUTTON_CANCEL");
															dlgItem = global::custom_controls.CDlgFileOpenSave.GetDlgItem(parent, 2);
															global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(dlgItem), 48U, a_, new global::System.IntPtr(1));
															global::custom_controls.CDlgFileOpenSave.SetWindowText(dlgItem, a_2);
															num = 3;
															continue;
														}
														break;
													case 3:
														goto IL_6A3;
													case 4:
														goto IL_6A3;
													}
													break;
													IL_3DF:
													if (this.ba.Equals("OPEN_FILE_DAILOG"))
													{
														num = 2;
														continue;
													}
													a_2 = this.bb.GetString("LBL_ID_SAVEIN");
													dlgItem = global::custom_controls.CDlgFileOpenSave.GetDlgItem(parent, 1091);
													global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(dlgItem), 48U, a_, new global::System.IntPtr(1));
													global::custom_controls.CDlgFileOpenSave.SetWindowText(dlgItem, a_2);
													a_2 = this.bb.GetString("LBL_ID_FILENAME");
													dlgItem = global::custom_controls.CDlgFileOpenSave.GetDlgItem(parent, 1090);
													global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(dlgItem), 48U, a_, new global::System.IntPtr(1));
													global::custom_controls.CDlgFileOpenSave.SetWindowText(dlgItem, a_2);
													a_2 = this.bb.GetString("LBL_ID_FILESOFTYPESAVE");
													dlgItem = global::custom_controls.CDlgFileOpenSave.GetDlgItem(parent, 1089);
													global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(dlgItem), 48U, a_, new global::System.IntPtr(1));
													global::custom_controls.CDlgFileOpenSave.SetWindowText(dlgItem, a_2);
													a_2 = this.bb.GetString("LBL_ID_FILE_SAVE");
													dlgItem = global::custom_controls.CDlgFileOpenSave.GetDlgItem(parent, 1);
													global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(dlgItem), 48U, a_, new global::System.IntPtr(1));
													global::custom_controls.CDlgFileOpenSave.SetWindowText(dlgItem, a_2);
													a_2 = this.bb.GetString("BUTTON_CANCEL");
													dlgItem = global::custom_controls.CDlgFileOpenSave.GetDlgItem(parent, 2);
													global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(dlgItem), 48U, a_, new global::System.IntPtr(1));
													global::custom_controls.CDlgFileOpenSave.SetWindowText(dlgItem, a_2);
													num = 4;
													continue;
													IL_6A3:
													num = 1;
												}
											}
											IL_6AF:;
										}
										catch (global::System.Exception)
										{
											int errorMsgId = 2545;
											global::custom_controls.CMsgDialog cmsgDialog = new global::custom_controls.CMsgDialog(this.bc, this.bb, errorMsgId, this.bi, null);
											if (cmsgDialog == null)
											{
												string string2 = this.bb.GetString("Failed to change the control text.");
												global::System.Windows.Forms.MessageBox.Show(string2);
											}
											cmsgDialog.Show(null, false, global::System.Windows.Forms.DialogResult.OK, global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
										}
										num = 3;
										continue;
									case 3:
										goto IL_713;
									}
									global::System.Drawing.Font font;
									if (font == null)
									{
										num = 1;
									}
									else
									{
										global::System.IntPtr a_ = font.ToHfont();
										global::custom_controls.CDlgFileOpenSave.a a = default(global::custom_controls.CDlgFileOpenSave.a);
										global::custom_controls.CDlgFileOpenSave.GetWindowRect(parent, ref a);
										int a_3 = (this.bf + this.be - (a.c - a.a)) / 2;
										int a_4 = (this.bh + this.bg - (a.d - a.b)) / 2;
										global::custom_controls.CDlgFileOpenSave.SetWindowPos(parent, 0, a_3, a_4, a.c - a.a, a.d - a.b + 32, 4U);
										string a_2 = string.Empty;
										global::custom_controls.CDlgFileOpenSave.SendMessage(new global::System.IntPtr(A_0), 48U, a_, new global::System.IntPtr(1));
										num = 2;
									}
								}
								IL_2B9:
								return result;
								IL_713:
								return 0;
							}
							finally
							{
								num = 0;
								for (;;)
								{
									global::System.Drawing.Font font;
									switch (num)
									{
									case 1:
										((global::System.IDisposable)font).Dispose();
										num = 2;
										continue;
									case 2:
										goto IL_753;
									}
									if (font == null)
									{
										break;
									}
									num = 1;
								}
								IL_753:;
							}
							goto IL_756;
						case 20:
							num = 18;
							continue;
						case 21:
							goto IL_762;
						case 22:
							if (this.ba.Equals("OPEN_FILE_DAILOG"))
							{
								num = 3;
								continue;
							}
							num = 15;
							continue;
						}
						break;
						IL_756:
						num = 21;
					}
				}
				IL_CE:
				global::custom_controls.CDlgFileOpenSave.SetWindowLongPtr(new global::System.IntPtr(A_0), 0, new global::System.IntPtr(1));
				return 1;
				IL_F8:
				global::custom_controls.CDlgFileOpenSave.SetWindowLongPtr(new global::System.IntPtr(A_0), 0, new global::System.IntPtr(1));
				return 1;
				IL_235:
				global::custom_controls.CDlgFileOpenSave.SetWindowLongPtr(new global::System.IntPtr(A_0), 0, new global::System.IntPtr(1));
				return 1;
				IL_762:
				return 0;
				IL_767:
				global::custom_controls.CDlgFileOpenSave.d d2 = default(global::custom_controls.CDlgFileOpenSave.d);
				d2 = (global::custom_controls.CDlgFileOpenSave.d)global::System.Runtime.InteropServices.Marshal.PtrToStructure(new global::System.IntPtr(A_3), typeof(global::custom_controls.CDlgFileOpenSave.d));
				global::custom_controls.CDlgFileOpenSave.c c2 = default(global::custom_controls.CDlgFileOpenSave.c);
				int a_5 = ((global::custom_controls.CDlgFileOpenSave.c)global::System.Runtime.InteropServices.Marshal.PtrToStructure(d2.b, typeof(global::custom_controls.CDlgFileOpenSave.c))).g;
				this.CurrentFilter = this.a(a_5);
				return 1;
				IL_7F9:
				global::custom_controls.CDlgFileOpenSave.SetWindowLongPtr(new global::System.IntPtr(A_0), 0, new global::System.IntPtr(1));
				return 1;
			}
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00037890 File Offset: 0x00035A90
		public global::System.Windows.Forms.DialogResult ShowOpenDialog()
		{
			global::System.Windows.Forms.DialogResult result;
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						string currentDirectory = global::System.IO.Directory.GetCurrentDirectory();
						global::custom_controls.CDlgFileOpenSave.c structure = default(global::custom_controls.CDlgFileOpenSave.c);
						structure.a = global::System.Runtime.InteropServices.Marshal.SizeOf<global::custom_controls.CDlgFileOpenSave.c>(structure);
						structure.d = this.a5.Replace('|', '\0') + '\0';
						structure.h = this.a8 + new string(' ', 512);
						structure.l = this.a9 + new string(' ', 512);
						structure.i = structure.h.Length;
						structure.j = global::System.IO.Path.GetFileName(this.a8) + new string(' ', 512);
						structure.k = structure.j.Length;
						structure.m = this.bb.GetString("OPEN_FILE_DAILOG");
						structure.q = this.a7;
						structure.g = this.bk;
						int num = 1;
						for (;;)
						{
							switch (num)
							{
							case 0:
								structure.n = 68134;
								num = 9;
								continue;
							case 1:
								if (this.bj.ToInt64() > 0L)
								{
									num = 11;
									continue;
								}
								num = 5;
								continue;
							case 2:
								goto IL_3C2;
							case 3:
								structure.b = global::System.Windows.Forms.Form.ActiveForm.Handle;
								this.be = global::System.Windows.Forms.Form.ActiveForm.Left;
								this.bf = global::System.Windows.Forms.Form.ActiveForm.Right;
								this.bg = global::System.Windows.Forms.Form.ActiveForm.Top;
								this.bh = global::System.Windows.Forms.Form.ActiveForm.Bottom;
								num = 15;
								continue;
							case 4:
								if (this.bl)
								{
									num = 0;
									continue;
								}
								structure.n = 591910;
								num = 20;
								continue;
							case 5:
								if (global::System.Windows.Forms.Form.ActiveForm != null)
								{
									num = 3;
									continue;
								}
								this.be = global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Left;
								this.bf = global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right;
								this.bg = global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Top;
								this.bh = global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom;
								num = 2;
								continue;
							case 6:
								structure.a -= 12;
								num = 19;
								continue;
							case 7:
								num = 18;
								continue;
							case 8:
							{
								int num2 = global::custom_controls.a.CommDlgExtendedError();
								num = 13;
								continue;
							}
							case 9:
								goto IL_499;
							case 10:
								goto IL_46E;
							case 11:
							{
								structure.b = this.bj;
								global::custom_controls.CDlgFileOpenSave.a a = default(global::custom_controls.CDlgFileOpenSave.a);
								global::custom_controls.CDlgFileOpenSave.GetWindowRect(this.bj.ToInt32(), ref a);
								this.be = a.a;
								this.bf = a.c;
								this.bg = a.b;
								this.bh = a.d;
								num = 16;
								continue;
							}
							case 12:
								if (!global::custom_controls.CDlgFileOpenSave.GetOpenFileName(ref structure))
								{
									num = 8;
									continue;
								}
								this.a8 = structure.h;
								global::System.IO.Directory.SetCurrentDirectory(currentDirectory);
								num = 22;
								continue;
							case 13:
								if (this.bl)
								{
									num = 7;
									continue;
								}
								num = 17;
								continue;
							case 14:
								if (global::System.Environment.OSVersion.Platform != global::System.PlatformID.Win32NT)
								{
									num = 6;
									continue;
								}
								goto IL_473;
							case 15:
								goto IL_3C2;
							case 16:
								goto IL_3C2;
							case 17:
							{
								int num2;
								if (num2 != 0)
								{
									num = 21;
									continue;
								}
								goto IL_324;
							}
							case 18:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_31F;
								default:
								{
									if (false)
									{
									}
									int num2;
									if (num2 != 0)
									{
										num = 10;
										continue;
									}
									goto IL_324;
								}
								}
								break;
							case 19:
								goto IL_473;
							case 20:
								goto IL_499;
							case 21:
								goto IL_31F;
							case 22:
								goto IL_4F5;
							case 23:
								goto IL_333;
							}
							break;
							IL_324:
							result = global::System.Windows.Forms.DialogResult.Cancel;
							num = 23;
							continue;
							IL_3C2:
							structure.n = 591910;
							num = 4;
							continue;
							IL_473:
							num = 12;
							continue;
							IL_499:
							structure.s = new global::custom_controls.CDlgFileOpenSave.e(this.a);
							num = 14;
						}
					}
					IL_31F:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.FAIL_TOSHOW_FILEOPENDLG), "File Dialog", base.GetType().ToString() + ", ShowOpenDialog", global::System.Environment.StackTrace.ToString());
					throw ex;
					IL_333:
					goto IL_5F3;
					IL_46E:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException();
					throw ex2;
					IL_4F5:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException ex3)
			{
				if (this.AllowMultipleFileSelection)
				{
					throw;
				}
				int errorID = (int)ex3.ErrorID;
				global::custom_controls.CMsgDialog cmsgDialog = new global::custom_controls.CMsgDialog(this.bc, this.bb, errorID, this.bi, null);
				if (cmsgDialog == null)
				{
					string @string = this.bb.GetString("Failed to load Dialog.");
					global::System.Windows.Forms.MessageBox.Show(@string);
					result = global::System.Windows.Forms.DialogResult.Cancel;
					goto IL_5F3;
				}
				cmsgDialog.Show(null, false, global::System.Windows.Forms.DialogResult.OK, global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
				result = global::System.Windows.Forms.DialogResult.Cancel;
				goto IL_5F3;
			}
			catch (global::System.Exception ex4)
			{
				uint num3;
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex4))
				{
					num3 = global::custom_exception.CCustomException.GetErrorID(ex4);
				}
				else
				{
					num3 = 2546U;
				}
				int errorMsgId = (int)num3;
				global::custom_controls.CMsgDialog cmsgDialog2 = new global::custom_controls.CMsgDialog(this.bc, this.bb, errorMsgId, this.bi, null);
				if (cmsgDialog2 == null)
				{
					string string2 = this.bb.GetString("Failed to load Dialog.");
					global::System.Windows.Forms.MessageBox.Show(string2);
					result = global::System.Windows.Forms.DialogResult.Cancel;
					goto IL_5F3;
				}
				cmsgDialog2.Show(null, false, global::System.Windows.Forms.DialogResult.OK, global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
				result = global::System.Windows.Forms.DialogResult.Cancel;
				goto IL_5F3;
			}
			return global::System.Windows.Forms.DialogResult.OK;
			IL_5F3:
			if (true)
			{
			}
			return result;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00037ED0 File Offset: 0x000360D0
		public global::System.Windows.Forms.DialogResult ShowSaveAsDialog()
		{
			global::System.Windows.Forms.DialogResult result;
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						for (;;)
						{
							string currentDirectory = global::System.IO.Directory.GetCurrentDirectory();
							global::custom_controls.CDlgFileOpenSave.c structure = default(global::custom_controls.CDlgFileOpenSave.c);
							structure.a = global::System.Runtime.InteropServices.Marshal.SizeOf<global::custom_controls.CDlgFileOpenSave.c>(structure);
							structure.d = this.a5.Replace('|', '\0') + '\0';
							structure.h = this.a8 + new string(' ', 512);
							structure.l = this.a9 + new string(' ', 512);
							structure.i = structure.h.Length;
							structure.j = global::System.IO.Path.GetFileName(this.a8) + new string(' ', 512);
							structure.k = structure.j.Length;
							structure.m = this.bb.GetString("SAVEAS_FILE_DAILOG");
							structure.q = this.a7;
							int num = 11;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_289;
								case 1:
									if (!global::custom_controls.CDlgFileOpenSave.GetSaveFileName(ref structure))
									{
										num = 2;
										continue;
									}
									this.a8 = structure.h;
									global::System.IO.Directory.SetCurrentDirectory(currentDirectory);
									result = global::System.Windows.Forms.DialogResult.OK;
									num = 9;
									continue;
								case 2:
								{
									int num2 = global::custom_controls.a.CommDlgExtendedError();
									num = 13;
									continue;
								}
								case 3:
									structure.b = global::System.Windows.Forms.Form.ActiveForm.Handle;
									this.be = global::System.Windows.Forms.Form.ActiveForm.Left;
									this.bf = global::System.Windows.Forms.Form.ActiveForm.Right;
									this.bg = global::System.Windows.Forms.Form.ActiveForm.Top;
									this.bh = global::System.Windows.Forms.Form.ActiveForm.Bottom;
									num = 0;
									continue;
								case 4:
									goto IL_24C;
								case 5:
									if (global::System.Windows.Forms.Form.ActiveForm != null)
									{
										num = 3;
										continue;
									}
									this.be = global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Left;
									this.bf = global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right;
									this.bg = global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Top;
									this.bh = global::System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom;
									num = 10;
									continue;
								case 6:
									goto IL_289;
								case 7:
									if (global::System.Environment.OSVersion.Platform != global::System.PlatformID.Win32NT)
									{
										num = 8;
										continue;
									}
									goto IL_24C;
								case 8:
									if (true)
									{
									}
									structure.a -= 12;
									num = 4;
									continue;
								case 9:
									goto IL_428;
								case 10:
									goto IL_289;
								case 11:
									if (this.bj.ToInt64() > 0L)
									{
										num = 15;
										continue;
									}
									num = 5;
									continue;
								case 12:
									goto IL_36B;
								case 13:
								{
									int num2;
									if (num2 != 0)
									{
										num = 12;
										continue;
									}
									result = global::System.Windows.Forms.DialogResult.Cancel;
									num = 14;
									continue;
								}
								case 14:
									goto IL_284;
								case 15:
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
										structure.b = this.bj;
										global::custom_controls.CDlgFileOpenSave.a a = default(global::custom_controls.CDlgFileOpenSave.a);
										global::custom_controls.CDlgFileOpenSave.GetWindowRect(this.bj.ToInt32(), ref a);
										this.be = a.a;
										this.bf = a.c;
										this.bg = a.b;
										this.bh = a.d;
										num = 6;
										continue;
									}
									}
									break;
								}
								break;
								IL_24C:
								num = 1;
								continue;
								IL_289:
								structure.n = 608292;
								structure.s = new global::custom_controls.CDlgFileOpenSave.e(this.a);
								num = 7;
							}
						}
					}
					IL_284:
					break;
					IL_36B:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.FAIL_TOSHOW_FILEOPENDLG), "File Dialog", base.GetType().ToString() + ", ShowOpenDialog", global::System.Environment.StackTrace.ToString());
					throw ex;
					IL_428:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException ex2)
			{
				int errorID = (int)ex2.ErrorID;
				global::custom_controls.CMsgDialog cmsgDialog = new global::custom_controls.CMsgDialog(this.bc, this.bb, errorID, this.bi, null);
				if (cmsgDialog == null)
				{
					string @string = this.bb.GetString("Failed to load Dialog.");
					global::System.Windows.Forms.MessageBox.Show(@string);
					result = global::System.Windows.Forms.DialogResult.Cancel;
				}
				else
				{
					cmsgDialog.Show(null, false, global::System.Windows.Forms.DialogResult.OK, global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
					result = global::System.Windows.Forms.DialogResult.Cancel;
				}
			}
			catch (global::System.Exception ex3)
			{
				uint num3;
				if (!global::custom_exception.CCustomException.CheckErrorIDExsists(ex3))
				{
					num3 = global::custom_exception.CCustomException.GetErrorID(ex3);
				}
				else
				{
					num3 = 2547U;
				}
				int errorMsgId = (int)num3;
				global::custom_controls.CMsgDialog cmsgDialog2 = new global::custom_controls.CMsgDialog(this.bc, this.bb, errorMsgId, this.bi, null);
				if (cmsgDialog2 == null)
				{
					string string2 = this.bb.GetString("Failed to load Dialog.");
					global::System.Windows.Forms.MessageBox.Show(string2);
					result = global::System.Windows.Forms.DialogResult.Cancel;
				}
				else
				{
					cmsgDialog2.Show(null, false, global::System.Windows.Forms.DialogResult.OK, global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
					result = global::System.Windows.Forms.DialogResult.Cancel;
				}
			}
			return result;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00038428 File Offset: 0x00036628
		private int c(string A_0)
		{
			switch (0)
			{
			default:
			{
				global::System.IO.FileInfo fileInfo = null;
				int result = 5;
				try
				{
					int num = 6;
					int result2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1A3;
							default:
								if (false)
								{
								}
								if (!fileInfo.Exists)
								{
									num = 4;
									continue;
								}
								fileInfo = null;
								result = 1;
								num = 3;
								continue;
							}
							break;
						case 1:
							goto IL_128;
						case 2:
						{
							global::System.IO.FileAttributes attributes = global::System.IO.File.GetAttributes(A_0);
							num = 8;
							continue;
						}
						case 3:
							goto IL_1A3;
						case 4:
							result2 = 1;
							num = 5;
							continue;
						case 5:
							goto IL_FE;
						case 7:
							if (fileInfo.Exists)
							{
								num = 2;
								continue;
							}
							goto IL_AE;
						case 8:
						{
							global::System.IO.FileAttributes attributes;
							if (global::System.IO.FileAttributes.ReadOnly == (attributes & global::System.IO.FileAttributes.ReadOnly))
							{
								num = 1;
								continue;
							}
							goto IL_AE;
						}
						case 9:
							goto IL_71;
						}
						if (A_0.Length > 240)
						{
							num = 9;
							continue;
						}
						fileInfo = new global::System.IO.FileInfo(A_0);
						num = 7;
						continue;
						IL_AE:
						num = 0;
					}
					IL_71:
					global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.FILE_NAME_TOOLONG), "File Dialog", base.GetType().ToString() + ", IsFileWritable", global::System.Environment.StackTrace.ToString());
					throw ex;
					IL_FE:
					return result2;
					IL_128:
					global::custom_exception.CCustomException ex2 = new global::custom_exception.CCustomException(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.FAIL_READONLY_FILE), "File Dialog", base.GetType().ToString() + ", IsFileWritable", global::System.Environment.StackTrace.ToString());
					throw ex2;
					IL_1A3:;
				}
				catch (global::custom_exception.CCustomException ex3)
				{
					string fileName = global::System.IO.Path.GetFileName(A_0);
					int errorID = (int)ex3.ErrorID;
					global::custom_controls.CMsgDialog cmsgDialog = new global::custom_controls.CMsgDialog(this.bc, this.bb, errorID, this.bi, fileName);
					if (cmsgDialog == null)
					{
						string @string = this.bb.GetString("FAIL_READONLY_FILE");
						global::System.Windows.Forms.MessageBox.Show(@string);
						return result;
					}
					cmsgDialog.Show(null, false, global::System.Windows.Forms.DialogResult.OK, global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
					return result;
				}
				catch (global::System.Exception)
				{
					string fileName2 = global::System.IO.Path.GetFileName(A_0);
					int errorMsgId = 2549;
					global::custom_controls.CMsgDialog cmsgDialog2 = new global::custom_controls.CMsgDialog(this.bc, this.bb, errorMsgId, this.bi, fileName2);
					if (cmsgDialog2 == null)
					{
						string string2 = this.bb.GetString("FAIL_READONLY_FILE");
						global::System.Windows.Forms.MessageBox.Show(string2);
						return result;
					}
					cmsgDialog2.Show(null, false, global::System.Windows.Forms.DialogResult.OK, global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
					return result;
				}
				if (true)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000386F0 File Offset: 0x000368F0
		private int b(string A_0)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					return 5;
				}
				if (false)
				{
				}
				int result;
				for (;;)
				{
					result = 1;
					int num = 5;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							global::System.Windows.Forms.DialogResult dialogResult;
							if (global::System.Windows.Forms.DialogResult.Yes != dialogResult)
							{
								num = 3;
								continue;
							}
							return result;
						}
						case 1:
							goto IL_101;
						case 2:
						{
							global::custom_controls.CMsgDialog cmsgDialog;
							if (cmsgDialog == null)
							{
								num = 1;
								continue;
							}
							global::System.Windows.Forms.DialogResult dialogResult = cmsgDialog.Show(null, false, dialogResult, global::System.Windows.Forms.MessageBoxButtons.YesNo, global::System.Windows.Forms.MessageBoxIcon.Question);
							num = 0;
							continue;
						}
						case 3:
							goto IL_A1;
						case 4:
						{
							string fileName = global::System.IO.Path.GetFileName(A_0);
							global::System.Windows.Forms.DialogResult dialogResult = global::System.Windows.Forms.DialogResult.Yes;
							global::custom_controls.CMsgDialog cmsgDialog = new global::custom_controls.CMsgDialog(this.bc, this.bb, 2550, this.bi, fileName);
							num = 2;
							continue;
						}
						case 5:
							if (global::System.IO.File.Exists(A_0))
							{
								num = 4;
								continue;
							}
							return result;
						}
						break;
					}
				}
				IL_A1:
				return 5;
				IL_101:
				string @string = this.bb.GetString("FAIL_READONLY_FILE");
				global::System.Windows.Forms.MessageBox.Show(@string);
				return result;
			}
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00038804 File Offset: 0x00036A04
		private bool a(string A_0)
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
			bool result = true;
			string text = string.Empty;
			try
			{
				for (;;)
				{
					text = global::System.IO.Path.GetPathRoot(A_0);
					global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(A_0);
					int num = 4;
					for (;;)
					{
						long length;
						long num2;
						switch (num)
						{
						case 0:
							goto IL_151;
						case 1:
							if (this.m_sCurFileName != A_0)
							{
								num = 5;
								continue;
							}
							goto IL_F5;
						case 2:
							goto IL_127;
						case 3:
							num = 1;
							continue;
						case 4:
							if (fileInfo.Exists)
							{
								num = 3;
								continue;
							}
							goto IL_129;
						case 5:
							goto IL_129;
						case 6:
							goto IL_F5;
						case 7:
							if (length > num2)
							{
								num = 2;
								continue;
							}
							num = 0;
							continue;
						}
						break;
						IL_F5:
						length = fileInfo.Length;
						long num3;
						long num4;
						global::custom_controls.CDlgFileOpenSave.GetDiskFreeSpaceEx(text, out num2, out num3, out num4);
						num = 7;
						continue;
						IL_129:
						fileInfo = new global::System.IO.FileInfo(this.m_sCurFileName);
						num = 6;
					}
				}
				IL_127:
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.FAIL_SPACE_NOTENOUGH), "File Dialog", base.GetType().ToString() + ", IsSpaceAvailable", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_151:;
			}
			catch (global::custom_exception.CCustomException ex2)
			{
				int errorID = (int)ex2.ErrorID;
				global::custom_controls.CMsgDialog cmsgDialog = new global::custom_controls.CMsgDialog(this.bc, this.bb, errorID, this.bi, text);
				if (cmsgDialog == null)
				{
					string @string = this.bb.GetString("FAIL_SPACE_NOTENOUGH");
					global::System.Windows.Forms.MessageBox.Show(@string);
					return false;
				}
				cmsgDialog.Show(null, false, global::System.Windows.Forms.DialogResult.OK, global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
				return false;
			}
			catch (global::System.Exception)
			{
				int errorMsgId = 2552;
				global::custom_controls.CMsgDialog cmsgDialog2 = new global::custom_controls.CMsgDialog(this.bc, this.bb, errorMsgId, this.bi, null);
				if (cmsgDialog2 == null)
				{
					string string2 = this.bb.GetString("FAIL_GET_FREESPACE");
					global::System.Windows.Forms.MessageBox.Show(string2);
					return false;
				}
				if (true)
				{
				}
				cmsgDialog2.Show(null, false, global::System.Windows.Forms.DialogResult.OK, global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
				return false;
			}
			return result;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00038A64 File Offset: 0x00036C64
		private string a(int A_0)
		{
			switch (0)
			{
			default:
			{
				string result;
				for (;;)
				{
					IL_67:
					result = string.Empty;
					int num = 10;
					for (;;)
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
							int num3;
							switch (num)
							{
							case 0:
							{
								string text;
								result = text;
								num = 1;
								continue;
							}
							case 1:
								goto IL_148;
							case 2:
								goto IL_FD;
							case 3:
								num = 9;
								continue;
							case 4:
							{
								int num2;
								num2++;
								num = 8;
								continue;
							}
							case 5:
							{
								global::System.Array array;
								if (num3 >= array.Length)
								{
									num = 6;
									continue;
								}
								if (true)
								{
								}
								string text = (string)array.GetValue(num3);
								num = 12;
								continue;
							}
							case 6:
								return result;
							case 7:
								goto IL_158;
							case 8:
							{
								int num2;
								if (num2 == A_0)
								{
									num = 0;
									continue;
								}
								goto IL_148;
							}
							case 9:
								if (this.a5.Length > 0)
								{
									num = 11;
									continue;
								}
								return result;
							case 10:
								if (this.a5 != null)
								{
									num = 3;
									continue;
								}
								return result;
							case 11:
							{
								global::System.Array array = this.a5.Split("|".ToCharArray());
								int num2 = 0;
								num3 = 0;
								num = 2;
								continue;
							}
							case 12:
							{
								string text;
								if (text.IndexOf("*.", global::System.StringComparison.Ordinal) >= 0)
								{
									num = 4;
									continue;
								}
								goto IL_148;
							}
							}
							goto IL_67;
							IL_148:
							num3++;
							num = 7;
							continue;
						}
						}
						IL_FD:
						num = 5;
						continue;
						IL_158:
						goto IL_FD;
					}
				}
				return result;
			}
			}
		}

		// Token: 0x040001EA RID: 490
		private const int a = 32;

		// Token: 0x040001EB RID: 491
		private const int b = 524288;

		// Token: 0x040001EC RID: 492
		private const int c = 4096;

		// Token: 0x040001ED RID: 493
		private const int d = 4;

		// Token: 0x040001EE RID: 494
		private const int e = 8192;

		// Token: 0x040001EF RID: 495
		private const int f = 16384;

		// Token: 0x040001F0 RID: 496
		private const int g = 65536;

		// Token: 0x040001F1 RID: 497
		private const int h = 1;

		// Token: 0x040001F2 RID: 498
		private const int i = 2;

		// Token: 0x040001F3 RID: 499
		private const int j = 2048;

		// Token: 0x040001F4 RID: 500
		private const int k = 1048576;

		// Token: 0x040001F5 RID: 501
		private const int l = 1024;

		// Token: 0x040001F6 RID: 502
		private const int m = 512;

		// Token: 0x040001F7 RID: 503
		private const int n = 1136;

		// Token: 0x040001F8 RID: 504
		private const int o = 1148;

		// Token: 0x040001F9 RID: 505
		private const int p = 1;

		// Token: 0x040001FA RID: 506
		private const int q = 1;

		// Token: 0x040001FB RID: 507
		private const int r = 2;

		// Token: 0x040001FC RID: 508
		private const int s = 4;

		// Token: 0x040001FD RID: 509
		private const int t = 272;

		// Token: 0x040001FE RID: 510
		private const int u = 2;

		// Token: 0x040001FF RID: 511
		private const int v = 48;

		// Token: 0x04000200 RID: 512
		private const int w = 49;

		// Token: 0x04000201 RID: 513
		private const int x = 3;

		// Token: 0x04000202 RID: 514
		private const int y = 512;

		// Token: 0x04000203 RID: 515
		private const int z = 323;

		// Token: 0x04000204 RID: 516
		private const int aa = 334;

		// Token: 0x04000205 RID: 517
		private const int ab = 327;

		// Token: 0x04000206 RID: 518
		private const uint ac = 268435456U;

		// Token: 0x04000207 RID: 519
		private const uint ad = 1073741824U;

		// Token: 0x04000208 RID: 520
		private const uint ae = 65536U;

		// Token: 0x04000209 RID: 521
		private const int af = -602;

		// Token: 0x0400020A RID: 522
		private const int ag = -603;

		// Token: 0x0400020B RID: 523
		private const int ah = -604;

		// Token: 0x0400020C RID: 524
		private const int ai = -606;

		// Token: 0x0400020D RID: 525
		private const int aj = -607;

		// Token: 0x0400020E RID: 526
		private const int ak = 100;

		// Token: 0x0400020F RID: 527
		private const int al = 12;

		// Token: 0x04000210 RID: 528
		private const int am = 78;

		// Token: 0x04000211 RID: 529
		private const int an = 0;

		// Token: 0x04000212 RID: 530
		private const int ao = 1089;

		// Token: 0x04000213 RID: 531
		private const int ap = 1090;

		// Token: 0x04000214 RID: 532
		private const int aq = 1091;

		// Token: 0x04000215 RID: 533
		private const int ar = 1152;

		// Token: 0x04000216 RID: 534
		private const int @as = 1;

		// Token: 0x04000217 RID: 535
		private const int at = 2;

		// Token: 0x04000218 RID: 536
		private const int au = 5;

		// Token: 0x04000219 RID: 537
		private const int av = 6;

		// Token: 0x0400021A RID: 538
		private const int aw = 1;

		// Token: 0x0400021B RID: 539
		private const int ax = 1;

		// Token: 0x0400021C RID: 540
		private const int ay = 512;

		// Token: 0x0400021D RID: 541
		private const int az = 240;

		// Token: 0x0400021E RID: 542
		private const char a0 = '|';

		// Token: 0x0400021F RID: 543
		private const char a1 = ' ';

		// Token: 0x04000220 RID: 544
		private const char a2 = '\0';

		// Token: 0x04000221 RID: 545
		private const int a3 = 8;

		// Token: 0x04000222 RID: 546
		private const string a4 = "File Dialog";

		// Token: 0x04000223 RID: 547
		private string a5;

		// Token: 0x04000224 RID: 548
		private string a6;

		// Token: 0x04000225 RID: 549
		private string a7;

		// Token: 0x04000226 RID: 550
		private string a8;

		// Token: 0x04000227 RID: 551
		private string a9;

		// Token: 0x04000228 RID: 552
		public string m_sCurFileName;

		// Token: 0x04000229 RID: 553
		private string ba;

		// Token: 0x0400022A RID: 554
		private global::resource_handler.CResourceHandler bb;

		// Token: 0x0400022B RID: 555
		private bool bc;

		// Token: 0x0400022C RID: 556
		private string bd;

		// Token: 0x0400022D RID: 557
		private int be;

		// Token: 0x0400022E RID: 558
		private int bf;

		// Token: 0x0400022F RID: 559
		private int bg;

		// Token: 0x04000230 RID: 560
		private int bh;

		// Token: 0x04000231 RID: 561
		private string bi;

		// Token: 0x04000232 RID: 562
		private global::System.IntPtr bj;

		// Token: 0x04000233 RID: 563
		private int bk;

		// Token: 0x04000234 RID: 564
		private bool bl;

		// Token: 0x0200003F RID: 63
		private struct b
		{
			// Token: 0x04000235 RID: 565
			public int a;

			// Token: 0x04000236 RID: 566
			public int b;

			// Token: 0x04000237 RID: 567
			public int c;
		}

		// Token: 0x02000040 RID: 64
		private struct a
		{
			// Token: 0x04000238 RID: 568
			public int a;

			// Token: 0x04000239 RID: 569
			public int b;

			// Token: 0x0400023A RID: 570
			public int c;

			// Token: 0x0400023B RID: 571
			public int d;
		}

		// Token: 0x02000041 RID: 65
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private struct d
		{
			// Token: 0x0400023C RID: 572
			internal global::custom_controls.CDlgFileOpenSave.b a;

			// Token: 0x0400023D RID: 573
			internal global::System.IntPtr b;

			// Token: 0x0400023E RID: 574
			internal global::System.IntPtr c;
		}

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600033C RID: 828
		private delegate int e(int A_0, int A_1, int A_2, int A_3);

		// Token: 0x02000043 RID: 67
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private struct c
		{
			// Token: 0x0400023F RID: 575
			public int a;

			// Token: 0x04000240 RID: 576
			public global::System.IntPtr b;

			// Token: 0x04000241 RID: 577
			public int c;

			// Token: 0x04000242 RID: 578
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPTStr)]
			public string d;

			// Token: 0x04000243 RID: 579
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPTStr)]
			public string e;

			// Token: 0x04000244 RID: 580
			public int f;

			// Token: 0x04000245 RID: 581
			public int g;

			// Token: 0x04000246 RID: 582
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPTStr)]
			public string h;

			// Token: 0x04000247 RID: 583
			public int i;

			// Token: 0x04000248 RID: 584
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPTStr)]
			public string j;

			// Token: 0x04000249 RID: 585
			public int k;

			// Token: 0x0400024A RID: 586
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPTStr)]
			public string l;

			// Token: 0x0400024B RID: 587
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPTStr)]
			public string m;

			// Token: 0x0400024C RID: 588
			public int n;

			// Token: 0x0400024D RID: 589
			public short o;

			// Token: 0x0400024E RID: 590
			public short p;

			// Token: 0x0400024F RID: 591
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPTStr)]
			public string q;

			// Token: 0x04000250 RID: 592
			public int r;

			// Token: 0x04000251 RID: 593
			public global::custom_controls.CDlgFileOpenSave.e s;

			// Token: 0x04000252 RID: 594
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPTStr)]
			public string t;

			// Token: 0x04000253 RID: 595
			public int u;

			// Token: 0x04000254 RID: 596
			public int v;

			// Token: 0x04000255 RID: 597
			public int w;
		}
	}
}
