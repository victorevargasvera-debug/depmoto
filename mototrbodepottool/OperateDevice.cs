using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using constants;
using Controller;
using custom_controls;
using custom_exception;
using resource_handler;

namespace mototrbodepottool
{
	// Token: 0x0200000F RID: 15
	public class OperateDevice
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00015E70 File Offset: 0x00014E70
		public OperateDevice(ref uint A_0, global::Controller.IController A_1, global::mototrbodepottool.CProgressBar A_2)
		{
			this.d(ref A_0, A_1, A_2, null, "DeviceInfo");
			this.i = null;
			this.b = null;
			this.j = null;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00015EA8 File Offset: 0x00014EA8
		public OperateDevice()
		{
			this.f = null;
			this.g = null;
			this.c = false;
			this.h = null;
			this.r = string.Empty;
			this.m = string.Empty;
			this.n = false;
			this.l = false;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00015EFC File Offset: 0x00014EFC
		public void d(ref uint A_0, global::Controller.IController A_1, global::mototrbodepottool.CProgressBar A_2, global::constants.CCPTags.SetProgressBar A_3, string A_4)
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
			this.d = A_0;
			this.f = A_1;
			this.g = A_2;
			this.r = string.Empty;
			this.c = false;
			this.h = A_3;
			this.n = false;
			this.ac = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00015F7C File Offset: 0x00014F7C
		public void d(ref uint A_0, global::Controller.IController A_1, global::mototrbodepottool.CProgressBar A_2, global::constants.CCPTags.SetProgressBar A_3, string A_4, global::System.Collections.Generic.List<string> A_5, global::System.Collections.Generic.List<global::Controller.DeviceInfo> A_6, bool A_7)
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
			this.d = A_0;
			this.f = A_1;
			this.g = A_2;
			this.r = string.Empty;
			this.c = false;
			this.h = A_3;
			this.n = false;
			this.ac = A_5;
			this.o = A_6;
			this.a = (A_7 ? global::mototrbodepottool.OperateDevice.b.a : global::mototrbodepottool.OperateDevice.b.b);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00016010 File Offset: 0x00015010
		public void d(global::System.Collections.ArrayList A_0)
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
			this.j = A_0;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00016054 File Offset: 0x00015054
		public void e()
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
			this.e.Abort();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0001609C File Offset: 0x0001509C
		public void e(global::mototrbodepottool.OperateDevice.Operatetype A_0)
		{
			for (;;)
			{
				this.c = false;
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_68;
					case 1:
						goto IL_68;
					case 2:
						if (A_0 != global::mototrbodepottool.OperateDevice.Operatetype.c)
						{
							num = 8;
							continue;
						}
						return;
					case 3:
						goto IL_BA;
					case 4:
						switch (A_0)
						{
						case global::mototrbodepottool.OperateDevice.Operatetype.a:
							this.e = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.g));
							num = 3;
							continue;
						case global::mototrbodepottool.OperateDevice.Operatetype.b:
							this.e = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.k));
							num = 0;
							continue;
						case global::mototrbodepottool.OperateDevice.Operatetype.c:
						case global::mototrbodepottool.OperateDevice.Operatetype.d:
							this.d(A_0);
							num = 1;
							continue;
						default:
							num = 10;
							continue;
						}
						break;
					case 5:
						if (A_0 != global::mototrbodepottool.OperateDevice.Operatetype.d)
						{
							num = 7;
							continue;
						}
						return;
					case 6:
						goto IL_68;
					case 7:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BA;
						default:
							if (false)
							{
							}
							this.e.Start();
							num = 9;
							continue;
						}
						break;
					case 8:
						num = 5;
						continue;
					case 9:
						goto IL_EE;
					case 10:
						num = 6;
						continue;
					}
					break;
					IL_68:
					num = 2;
					continue;
					IL_BA:
					goto IL_68;
				}
			}
			IL_EE:
			if (true)
			{
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00016200 File Offset: 0x00015200
		private void d(global::mototrbodepottool.OperateDevice.Operatetype A_0)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
					global::System.Threading.Thread thread = null;
					int num = 0;
					int num2 = 19;
					for (;;)
					{
						global::Controller.DeviceInfo deviceInfo;
						int num3;
						string uuid;
						switch (num2)
						{
						case 0:
							goto IL_1C2;
						case 1:
							num2 = 30;
							continue;
						case 2:
							num2 = 4;
							continue;
						case 3:
							if (!deviceInfo.IsGemstone)
							{
								num2 = 15;
								continue;
							}
							goto IL_22E;
						case 4:
							if (deviceInfo.strSerialNo.Equals(arrayList[num3 + 1].ToString()))
							{
								num2 = 6;
								continue;
							}
							goto IL_45F;
						case 5:
							goto IL_1AB;
						case 6:
							goto IL_F5;
						case 7:
							if (!this.ab)
							{
								num2 = 11;
								continue;
							}
							goto IL_4D1;
						case 8:
							if (this.ab)
							{
								num2 = 27;
								continue;
							}
							goto IL_45F;
						case 9:
							goto IL_22E;
						case 10:
							if (arrayList[num3] != null)
							{
								num2 = 18;
								continue;
							}
							goto IL_1AB;
						case 11:
							goto IL_2A8;
						case 12:
							goto IL_335;
						case 13:
							goto IL_C9;
						case 14:
							return;
						case 15:
							num2 = 35;
							continue;
						case 16:
							goto IL_1AB;
						case 17:
							goto IL_335;
						case 18:
							deviceInfo.strSerialNo = arrayList[num3].ToString();
							num2 = 5;
							continue;
						case 19:
							goto IL_27A;
						case 20:
							goto IL_C9;
						case 21:
							uuid = deviceInfo.pakUUID;
							deviceInfo.SourceIshComp = 0;
							num2 = 12;
							continue;
						case 22:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_307;
							default:
								if (false)
								{
								}
								goto IL_1C2;
							}
							break;
						case 23:
							if (!deviceInfo.IsGemstone)
							{
								num2 = 36;
								continue;
							}
							goto IL_39E;
						case 24:
							switch (A_0)
							{
							case global::mototrbodepottool.OperateDevice.Operatetype.c:
								thread = new global::System.Threading.Thread(new global::System.Threading.ParameterizedThreadStart(this.e));
								num2 = 22;
								continue;
							case global::mototrbodepottool.OperateDevice.Operatetype.d:
								thread = new global::System.Threading.Thread(new global::System.Threading.ParameterizedThreadStart(this.d));
								num2 = 0;
								continue;
							default:
								num2 = 1;
								continue;
							}
							break;
						case 25:
							if (!deviceInfo.strSerialNo.Equals(arrayList[num3].ToString()))
							{
								num2 = 2;
								continue;
							}
							goto IL_F5;
						case 26:
							goto IL_39E;
						case 27:
							num2 = 25;
							continue;
						case 28:
							if (num >= this.o.Count)
							{
								num2 = 14;
								continue;
							}
							deviceInfo = this.o[num];
							uuid = deviceInfo.DeviceUUID;
							goto IL_307;
						case 29:
							if (num3 >= arrayList.Count - 1)
							{
								num2 = 32;
								continue;
							}
							num3++;
							num2 = 8;
							continue;
						case 30:
							goto IL_1C2;
						case 31:
							if (deviceInfo.IsBahama)
							{
								num2 = 26;
								continue;
							}
							goto IL_4D1;
						case 32:
							goto IL_4D1;
						case 33:
							if (string.IsNullOrEmpty(deviceInfo.DeviceUUID))
							{
								num2 = 21;
								continue;
							}
							uuid = deviceInfo.DeviceUUID;
							num2 = 17;
							continue;
						case 34:
							if (true)
							{
							}
							goto IL_27A;
						case 35:
							if (deviceInfo.IsBahama)
							{
								num2 = 9;
								continue;
							}
							goto IL_2A8;
						case 36:
							num2 = 31;
							continue;
						}
						break;
						IL_C9:
						num2 = 29;
						continue;
						IL_F5:
						deviceInfo.Path = arrayList[num3 - 1].ToString();
						deviceInfo.objFZ = arrayList[num3 + 2];
						num2 = 16;
						continue;
						IL_1AB:
						num3 += 3;
						num2 = 13;
						continue;
						IL_1C2:
						thread.Start(deviceInfo);
						num++;
						num2 = 34;
						continue;
						IL_22E:
						num2 = 23;
						continue;
						IL_27A:
						num2 = 28;
						continue;
						IL_2A8:
						arrayList = this.f.EnterBootMode(deviceInfo.RDLFile, deviceInfo.RDLCompressed, this.ac, this.ab, uuid, deviceInfo.IshComp, deviceInfo.SourceIshComp);
						num3 = 0;
						num2 = 20;
						continue;
						IL_307:
						num2 = 33;
						continue;
						IL_335:
						deviceInfo.IsGemstone = global::Controller.DeviceInfo.isGemstoneRadio(uuid);
						deviceInfo.IsBahama = global::Controller.DeviceInfo.isBahamaRadio(uuid);
						num2 = 3;
						continue;
						IL_39E:
						num2 = 7;
						continue;
						IL_45F:
						deviceInfo.Path = arrayList[num3 - 1].ToString();
						deviceInfo.objFZ = arrayList[num3 + 2];
						num2 = 10;
						continue;
						IL_4D1:
						num2 = 24;
					}
				}
				return;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00016710 File Offset: 0x00015710
		public void g()
		{
			try
			{
				for (;;)
				{
					this.f.ReadDevice(ref this.d, ref this.r, ref this.l, this.h);
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_55;
						case 1:
							goto IL_6A;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_55;
							default:
								goto IL_88;
							}
							break;
						case 3:
							if (this.g != null)
							{
								num = 0;
								continue;
							}
							goto IL_6A;
						}
						break;
						IL_55:
						this.g.Close();
						num = 1;
						continue;
						IL_6A:
						num = 2;
					}
				}
				IL_88:
				if (false)
				{
				}
			}
			catch (global::custom_exception.CCustomException ex)
			{
				this.i = ex;
				this.b = null;
				this.d();
			}
			catch (global::System.Exception ex2)
			{
				this.b = ex2;
				this.i = null;
				this.d();
			}
			if (true)
			{
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0001680C File Offset: 0x0001580C
		private void d()
		{
			for (;;)
			{
				IL_30:
				this.c = true;
				int num = 0;
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
							if (this.g != null)
							{
								num = 2;
								continue;
							}
							return;
						case 1:
							return;
						case 2:
							this.g.Close();
							goto IL_66;
						}
						goto IL_30;
					}
					IL_66:
					if (true)
					{
					}
					num = 1;
				}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00016894 File Offset: 0x00015894
		public void k()
		{
			try
			{
				for (;;)
				{
					IL_34:
					if (true)
					{
					}
					this.f.WriteDevice(this.d, this.j, this.h);
					for (;;)
					{
						IL_59:
						int num = 2;
						for (;;)
						{
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_59;
							default:
								if (false)
								{
								}
								switch (num)
								{
								case 0:
									this.g.Close();
									num = 3;
									continue;
								case 1:
									goto IL_96;
								case 2:
									if (this.g != null)
									{
										num = 0;
										continue;
									}
									goto IL_8B;
								case 3:
									goto IL_8B;
								}
								goto IL_34;
								IL_8B:
								num = 1;
								break;
							}
						}
					}
				}
				IL_96:;
			}
			catch (global::custom_exception.CCustomException ex)
			{
				this.i = ex;
				this.b = null;
				this.d();
			}
			catch (global::System.Exception ex2)
			{
				this.b = ex2;
				this.i = null;
				this.d();
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00016990 File Offset: 0x00015990
		public void d(bool A_0)
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
			this.l = A_0;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000169D4 File Offset: 0x000159D4
		public bool h()
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

		// Token: 0x060000A6 RID: 166 RVA: 0x00016A18 File Offset: 0x00015A18
		public bool f()
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
			return this.n;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00016A5C File Offset: 0x00015A5C
		public void e(object A_0)
		{
			if (true)
			{
			}
			switch (0)
			{
			default:
			{
				global::Controller.DeviceInfo deviceInfo = (global::Controller.DeviceInfo)A_0;
				try
				{
					for (;;)
					{
						this.f.UpdateDevice(this.m, this.s, this.t, this.w, this.v, this.x, this.y, this.z, this.aa, this.h, ref deviceInfo, 96);
						this.n = true;
						int num = 20;
						for (;;)
						{
							int num2;
							int num3;
							bool flag;
							switch (num)
							{
							case 0:
								goto IL_1DD;
							case 1:
								goto IL_2A3;
							case 2:
								goto IL_2A3;
							case 3:
								goto IL_2C4;
							case 4:
								if (this.d(this.m))
								{
									num = 21;
									continue;
								}
								num2++;
								num = 2;
								continue;
							case 5:
								goto IL_132;
							case 6:
								if (deviceInfo.IsBahama)
								{
									num = 9;
									continue;
								}
								global::System.Threading.Thread.Sleep(10000);
								num = 16;
								continue;
							case 7:
								num = 6;
								continue;
							case 8:
								if (num3 >= 3)
								{
									num = 3;
									continue;
								}
								num = 19;
								continue;
							case 9:
								goto IL_1FE;
							case 10:
								this.m = "192.168.10.1";
								num = 18;
								continue;
							case 11:
								if (flag)
								{
									num = 15;
									continue;
								}
								goto IL_14F;
							case 12:
								if (num2 >= 2)
								{
									num = 5;
									continue;
								}
								global::System.Threading.Thread.Sleep(3000);
								num = 4;
								continue;
							case 13:
								goto IL_132;
							case 14:
								goto IL_2C4;
							case 15:
								this.h(3 - num3);
								num = 14;
								continue;
							case 16:
								goto IL_14F;
							case 17:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_132;
								default:
									if (false)
									{
									}
									goto IL_1DD;
								}
								break;
							case 18:
								goto IL_11D;
							case 19:
								if (!deviceInfo.IsGemstone)
								{
									num = 7;
									continue;
								}
								goto IL_1FE;
							case 20:
								if (deviceInfo.UpdateCP)
								{
									num = 10;
									continue;
								}
								goto IL_11D;
							case 21:
								flag = true;
								num = 13;
								continue;
							case 22:
								goto IL_2E9;
							}
							break;
							IL_11D:
							flag = false;
							num3 = 0;
							num = 0;
							continue;
							IL_132:
							num = 11;
							continue;
							IL_14F:
							this.h(1);
							num3++;
							num = 17;
							continue;
							IL_1DD:
							num = 8;
							continue;
							IL_1FE:
							global::System.Threading.Thread.Sleep(30000);
							num2 = 0;
							num = 1;
							continue;
							IL_2A3:
							num = 12;
							continue;
							IL_2C4:
							this.n = this.d(3, false);
							this.g.Hide();
							num = 22;
						}
					}
					IL_2E9:;
				}
				catch (global::custom_exception.CCustomException ex)
				{
					this.i = ex;
					this.b = null;
					this.d();
				}
				catch (global::System.Exception ex2)
				{
					this.b = ex2;
					this.i = null;
					this.d();
				}
				return;
			}
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00016DBC File Offset: 0x00015DBC
		public void d(object A_0)
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
						goto IL_2E;
					}
					break;
				}
			}
			IL_2E:
			if (false)
			{
			}
			global::Controller.DeviceInfo deviceInfo = (global::Controller.DeviceInfo)A_0;
			string strSerialNo = deviceInfo.strSerialNo;
			try
			{
				for (;;)
				{
					this.f.ConvertDevice(deviceInfo, this.h, 96);
					this.n = true;
					int num = 0;
					int num2 = 0;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_FA;
						case 1:
						{
							int a_;
							if (!this.d(a_, true))
							{
								num2 = 3;
								continue;
							}
							goto IL_118;
						}
						case 2:
							goto IL_FA;
						case 3:
							this.n = false;
							num2 = 5;
							continue;
						case 4:
							goto IL_12F;
						case 5:
							goto IL_118;
						case 6:
							if (num >= 3)
							{
								num2 = 7;
								continue;
							}
							global::System.Threading.Thread.Sleep(10000);
							this.h(1);
							num++;
							num2 = 2;
							continue;
						case 7:
						{
							global::System.GC.Collect();
							int a_ = 3;
							num2 = 1;
							continue;
						}
						}
						break;
						IL_FA:
						num2 = 6;
						continue;
						IL_118:
						this.g.Hide();
						num2 = 4;
					}
				}
				IL_12F:;
			}
			catch (global::custom_exception.CCustomException ex)
			{
				this.i = ex;
				this.b = null;
				this.d();
			}
			catch (global::System.Exception ex2)
			{
				this.b = ex2;
				this.i = null;
				this.d();
			}
			if (true)
			{
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00016F50 File Offset: 0x00015F50
		public void d(string A_0, string A_1, string A_2, bool A_3, bool A_4, bool A_5, bool A_6, bool A_7, bool A_8, global::mototrbodepottool.CProgressBar A_9, global::constants.CCPTags.SetProgressBar A_10, string A_11, bool A_12)
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
			this.s = A_0;
			this.t = A_1;
			this.u = A_2;
			this.w = A_3;
			this.v = A_4;
			this.x = A_5;
			this.y = A_6;
			this.z = A_7;
			this.aa = A_8;
			this.g = A_9;
			this.h = A_10;
			this.m = A_11;
			this.ab = A_12;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00016FF0 File Offset: 0x00015FF0
		public void d(global::System.Windows.Forms.Form A_0, bool A_1, global::resource_handler.CResourceHandler A_2)
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
			this.q = A_0;
			this.p = A_1;
			this.k = A_2;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00017040 File Offset: 0x00016040
		private bool d(ref string A_0, ref uint A_1, global::constants.CCPTags.SetProgressBar A_2, int A_3)
		{
			switch (0)
			{
			default:
			{
				bool result = false;
				try
				{
					for (;;)
					{
						global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
						this.f.ListConnectedDevices(out arrayList);
						int num = 1;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_E0;
							case 1:
								if (arrayList.Count > 0)
								{
									num = 3;
									continue;
								}
								goto IL_80;
							case 2:
								this.f.OpenConnection(A_0, ref A_1, A_2);
								result = true;
								num = 0;
								continue;
							case 3:
								num = 4;
								continue;
							case 4:
								if (arrayList.Count < 2)
								{
									num = 5;
									continue;
								}
								goto IL_80;
							case 5:
								A_0 = ((global::Controller.DeviceInfo)arrayList[0]).strIp;
								num = 2;
								continue;
							}
							break;
						}
					}
					IL_80:
					global::custom_exception.CCustomException ex = global::mototrbodepottool.CustomExceptionHandler.a(1799U, base.GetType().ToString(), "CanOpenConnection", global::System.Environment.StackTrace);
					throw ex;
					IL_E0:;
				}
				catch (global::System.Exception)
				{
					global::custom_controls.CMsgDialog cmsgDialog = new global::custom_controls.CMsgDialog(this.p, this.k, 1799, "DT_APP_NAME", null);
					if (cmsgDialog == null)
					{
						if (true)
						{
						}
						global::custom_exception.CCustomException ex2 = global::mototrbodepottool.CustomExceptionHandler.a(1646U, base.GetType().ToString(), "CanOpenConnection", global::System.Environment.StackTrace);
						throw ex2;
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
						this.d(cmsgDialog, global::System.Windows.Forms.DialogResult.OK, global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Asterisk);
						A_3--;
						if (A_3 <= 0)
						{
							goto IL_176;
						}
						break;
					}
					result = this.d(ref A_0, ref A_1, A_2, A_3);
					IL_176:;
				}
				return result;
			}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000171E0 File Offset: 0x000161E0
		private void d(global::custom_controls.CMsgDialog A_0, global::System.Windows.Forms.DialogResult A_1, global::System.Windows.Forms.MessageBoxButtons A_2, global::System.Windows.Forms.MessageBoxIcon A_3)
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
				if (!this.q.InvokeRequired)
				{
					A_1 = A_0.Show(this.q, false, A_1, A_2, A_3);
					return;
				}
				break;
			}
			global::mototrbodepottool.OperateDevice.a method = new global::mototrbodepottool.OperateDevice.a(this.d);
			this.q.Invoke(method, new object[]
			{
				A_0,
				A_1,
				A_2,
				A_3
			});
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00017280 File Offset: 0x00016280
		private bool d(string A_0)
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
			return this.f.CanDetectDevice(A_0);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000172CC File Offset: 0x000162CC
		private bool d(int A_0, bool A_1)
		{
			switch (0)
			{
			default:
			{
				bool result = true;
				this.d = 0U;
				bool result2;
				try
				{
					for (;;)
					{
						int a_ = 3;
						string text = this.m;
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (!this.d(ref text, ref this.d, this.h, a_))
								{
									num = 1;
									continue;
								}
								this.f.WriteDevice(this.d, this.j, null);
								this.f.CloseConnection(this.d);
								this.g.a(99);
								num = 2;
								continue;
							case 1:
								goto IL_60;
							case 2:
								goto IL_C6;
							}
							break;
						}
					}
					IL_60:
					global::custom_exception.CCustomException ex = global::mototrbodepottool.CustomExceptionHandler.a(1802U, base.GetType().ToString(), "CanReadWriteDevice", global::System.Environment.StackTrace);
					throw ex;
					IL_C6:;
				}
				catch (global::custom_exception.CCustomException ex2)
				{
					if (this.f == null || this.d <= 0U)
					{
						goto IL_15C;
					}
					IL_DD:
					this.f.CloseConnection(this.d);
					IL_15C:
					uint errorID = ex2.ErrorID;
					if (errorID == 1802U)
					{
						throw ex2;
					}
					if (A_0 <= 0)
					{
						global::custom_exception.CCustomException ex3 = global::mototrbodepottool.CustomExceptionHandler.a(1802U, base.GetType().ToString(), "CanReadWriteDevice", global::System.Environment.StackTrace);
						throw ex3;
					}
					global::custom_controls.CMsgDialog cmsgDialog = new global::custom_controls.CMsgDialog(this.p, this.k, 1803, "DT_APP_NAME", null);
					if (cmsgDialog == null)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_DD;
						default:
						{
							if (false)
							{
							}
							global::custom_exception.CCustomException ex4 = global::mototrbodepottool.CustomExceptionHandler.a(1646U, base.GetType().ToString(), "UpdateDevice", global::System.Environment.StackTrace);
							throw ex4;
						}
						}
					}
					else
					{
						global::System.Windows.Forms.DialogResult dialogResult = global::System.Windows.Forms.DialogResult.Yes;
						this.d(cmsgDialog, dialogResult, global::System.Windows.Forms.MessageBoxButtons.YesNo, global::System.Windows.Forms.MessageBoxIcon.Question);
						if (global::System.Windows.Forms.DialogResult.No == dialogResult)
						{
							result2 = false;
							goto IL_297;
						}
						A_0--;
						this.g.a(99);
						this.d(A_0, A_1);
					}
				}
				catch (global::System.Exception)
				{
					if (this.f != null && this.d > 0U)
					{
						this.f.CloseConnection(this.d);
					}
					if (A_0 <= 0)
					{
						this.g.a(99);
						global::custom_exception.CCustomException ex5 = global::mototrbodepottool.CustomExceptionHandler.a(1802U, base.GetType().ToString(), "CanReadWriteDevice", global::System.Environment.StackTrace);
						throw ex5;
					}
					global::custom_controls.CMsgDialog a_2 = new global::custom_controls.CMsgDialog(this.p, this.k, 1803, "DT_APP_NAME", null);
					global::System.Windows.Forms.DialogResult dialogResult2 = global::System.Windows.Forms.DialogResult.Yes;
					this.d(a_2, dialogResult2, global::System.Windows.Forms.MessageBoxButtons.YesNo, global::System.Windows.Forms.MessageBoxIcon.Question);
					if (global::System.Windows.Forms.DialogResult.No == dialogResult2)
					{
						result2 = false;
						goto IL_297;
					}
					A_0--;
					this.d(A_0, A_1);
				}
				return result;
				IL_297:
				if (true)
				{
				}
				return result2;
			}
			}
		}

		// Token: 0x0400020B RID: 523
		public global::mototrbodepottool.OperateDevice.b a;

		// Token: 0x0400020C RID: 524
		public global::System.Exception b;

		// Token: 0x0400020D RID: 525
		public bool c;

		// Token: 0x0400020E RID: 526
		private uint d;

		// Token: 0x0400020F RID: 527
		private global::System.Threading.Thread e;

		// Token: 0x04000210 RID: 528
		private global::Controller.IController f;

		// Token: 0x04000211 RID: 529
		private global::mototrbodepottool.CProgressBar g;

		// Token: 0x04000212 RID: 530
		private global::constants.CCPTags.SetProgressBar h;

		// Token: 0x04000213 RID: 531
		public global::custom_exception.CCustomException i;

		// Token: 0x04000214 RID: 532
		public global::System.Collections.ArrayList j;

		// Token: 0x04000215 RID: 533
		private global::resource_handler.CResourceHandler k;

		// Token: 0x04000216 RID: 534
		private bool l;

		// Token: 0x04000217 RID: 535
		private string m;

		// Token: 0x04000218 RID: 536
		private bool n;

		// Token: 0x04000219 RID: 537
		private global::System.Collections.Generic.List<global::Controller.DeviceInfo> o;

		// Token: 0x0400021A RID: 538
		private bool p;

		// Token: 0x0400021B RID: 539
		private global::System.Windows.Forms.Form q;

		// Token: 0x0400021C RID: 540
		private string r;

		// Token: 0x0400021D RID: 541
		private string s;

		// Token: 0x0400021E RID: 542
		private string t;

		// Token: 0x0400021F RID: 543
		private string u;

		// Token: 0x04000220 RID: 544
		private bool v;

		// Token: 0x04000221 RID: 545
		private bool w;

		// Token: 0x04000222 RID: 546
		private bool x;

		// Token: 0x04000223 RID: 547
		private bool y;

		// Token: 0x04000224 RID: 548
		private bool z;

		// Token: 0x04000225 RID: 549
		private bool aa;

		// Token: 0x04000226 RID: 550
		private bool ab;

		// Token: 0x04000227 RID: 551
		private global::System.Collections.Generic.List<string> ac;

		// Token: 0x02000010 RID: 16
		public enum b
		{
			// Token: 0x04000229 RID: 553
			a,
			// Token: 0x0400022A RID: 554
			b
		}

		// Token: 0x02000011 RID: 17
		public enum Operatetype
		{
			// Token: 0x0400022C RID: 556
			a,
			// Token: 0x0400022D RID: 557
			b,
			// Token: 0x0400022E RID: 558
			c,
			// Token: 0x0400022F RID: 559
			d
		}

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x060000B0 RID: 176
		public delegate void a(global::custom_controls.CMsgDialog A_0, global::System.Windows.Forms.DialogResult A_1, global::System.Windows.Forms.MessageBoxButtons A_2, global::System.Windows.Forms.MessageBoxIcon A_3);
	}
}
