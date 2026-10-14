using System;
using System.Text;
using System.Threading;

namespace custom_controls
{
	// Token: 0x02000074 RID: 116
	public class LocalCbtHook : global::custom_controls.LocalWindowsHook
	{
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060004C3 RID: 1219 RVA: 0x0004B570 File Offset: 0x00049770
		// (remove) Token: 0x060004C4 RID: 1220 RVA: 0x0004B608 File Offset: 0x00049808
		public event global::custom_controls.LocalCbtHook.CbtEventHandler WindowCreated
		{
			add
			{
				for (;;)
				{
					global::custom_controls.LocalCbtHook.CbtEventHandler cbtEventHandler = this.a;
					if (true)
					{
					}
					int num = 0;
					for (;;)
					{
						IL_02:
						global::custom_controls.LocalCbtHook.CbtEventHandler cbtEventHandler2;
						switch (num)
						{
						case 0:
							goto IL_2D;
						case 1:
							while (cbtEventHandler == cbtEventHandler2)
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
									num = 2;
									goto IL_02;
								}
							}
							goto IL_2D;
						case 2:
							return;
						}
						break;
						IL_2D:
						cbtEventHandler2 = cbtEventHandler;
						global::custom_controls.LocalCbtHook.CbtEventHandler value2 = (global::custom_controls.LocalCbtHook.CbtEventHandler)global::System.Delegate.Combine(cbtEventHandler2, value);
						cbtEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.LocalCbtHook.CbtEventHandler>(ref this.a, value2, cbtEventHandler2);
						num = 1;
					}
				}
			}
			remove
			{
				for (;;)
				{
					IL_14:
					global::custom_controls.LocalCbtHook.CbtEventHandler cbtEventHandler = this.a;
					if (true)
					{
					}
					int num = 2;
					for (;;)
					{
						global::custom_controls.LocalCbtHook.CbtEventHandler cbtEventHandler2;
						switch (num)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_14;
							}
							if (false)
							{
							}
							if (cbtEventHandler == cbtEventHandler2)
							{
								num = 1;
								continue;
							}
							goto IL_2D;
						case 1:
							return;
						case 2:
							goto IL_2D;
						}
						break;
						IL_2D:
						cbtEventHandler2 = cbtEventHandler;
						global::custom_controls.LocalCbtHook.CbtEventHandler value2 = (global::custom_controls.LocalCbtHook.CbtEventHandler)global::System.Delegate.Remove(cbtEventHandler2, value);
						cbtEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.LocalCbtHook.CbtEventHandler>(ref this.a, value2, cbtEventHandler2);
						num = 0;
					}
				}
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060004C5 RID: 1221 RVA: 0x0004B6A0 File Offset: 0x000498A0
		// (remove) Token: 0x060004C6 RID: 1222 RVA: 0x0004B738 File Offset: 0x00049938
		public event global::custom_controls.LocalCbtHook.CbtEventHandler WindowDestroyed
		{
			add
			{
				for (;;)
				{
					global::custom_controls.LocalCbtHook.CbtEventHandler cbtEventHandler = this.b;
					int num = 0;
					for (;;)
					{
						global::custom_controls.LocalCbtHook.CbtEventHandler cbtEventHandler2;
						switch (num)
						{
						case 0:
							goto IL_25;
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
								if (cbtEventHandler == cbtEventHandler2)
								{
									if (true)
									{
									}
									num = 1;
									continue;
								}
								goto IL_25;
							}
							break;
						}
						break;
						IL_25:
						cbtEventHandler2 = cbtEventHandler;
						global::custom_controls.LocalCbtHook.CbtEventHandler value2 = (global::custom_controls.LocalCbtHook.CbtEventHandler)global::System.Delegate.Combine(cbtEventHandler2, value);
						cbtEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.LocalCbtHook.CbtEventHandler>(ref this.b, value2, cbtEventHandler2);
						num = 2;
					}
				}
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.LocalCbtHook.CbtEventHandler cbtEventHandler = this.b;
					int num = 2;
					for (;;)
					{
						global::custom_controls.LocalCbtHook.CbtEventHandler cbtEventHandler2;
						switch (num)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_23;
							default:
								if (false)
								{
								}
								if (cbtEventHandler == cbtEventHandler2)
								{
									if (true)
									{
									}
									num = 1;
									continue;
								}
								goto IL_25;
							}
							break;
						case 1:
							return;
						case 2:
							goto IL_23;
						}
						break;
						IL_25:
						cbtEventHandler2 = cbtEventHandler;
						global::custom_controls.LocalCbtHook.CbtEventHandler value2 = (global::custom_controls.LocalCbtHook.CbtEventHandler)global::System.Delegate.Remove(cbtEventHandler2, value);
						cbtEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.LocalCbtHook.CbtEventHandler>(ref this.b, value2, cbtEventHandler2);
						num = 0;
						continue;
						IL_23:
						goto IL_25;
					}
				}
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060004C7 RID: 1223 RVA: 0x0004B7D0 File Offset: 0x000499D0
		// (remove) Token: 0x060004C8 RID: 1224 RVA: 0x0004B868 File Offset: 0x00049A68
		public event global::custom_controls.LocalCbtHook.CbtEventHandler WindowActivated
		{
			add
			{
				for (;;)
				{
					global::custom_controls.LocalCbtHook.CbtEventHandler cbtEventHandler = this.c;
					int num = 1;
					for (;;)
					{
						global::custom_controls.LocalCbtHook.CbtEventHandler cbtEventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_2F;
						case 2:
							if (cbtEventHandler != cbtEventHandler2)
							{
								goto IL_2F;
							}
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
								continue;
							}
							break;
						}
						break;
						IL_2F:
						cbtEventHandler2 = cbtEventHandler;
						global::custom_controls.LocalCbtHook.CbtEventHandler value2 = (global::custom_controls.LocalCbtHook.CbtEventHandler)global::System.Delegate.Combine(cbtEventHandler2, value);
						cbtEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.LocalCbtHook.CbtEventHandler>(ref this.c, value2, cbtEventHandler2);
						num = 2;
					}
				}
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.LocalCbtHook.CbtEventHandler cbtEventHandler = this.c;
					if (true)
					{
					}
					int num = 0;
					for (;;)
					{
						global::custom_controls.LocalCbtHook.CbtEventHandler cbtEventHandler2;
						switch (num)
						{
						case 0:
							goto IL_2D;
						case 1:
							if (cbtEventHandler == cbtEventHandler2)
							{
								num = 2;
								continue;
							}
							goto IL_2D;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2D;
							default:
								goto IL_80;
							}
							break;
						}
						break;
						IL_2D:
						cbtEventHandler2 = cbtEventHandler;
						global::custom_controls.LocalCbtHook.CbtEventHandler value2 = (global::custom_controls.LocalCbtHook.CbtEventHandler)global::System.Delegate.Remove(cbtEventHandler2, value);
						cbtEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.LocalCbtHook.CbtEventHandler>(ref this.c, value2, cbtEventHandler2);
						num = 1;
					}
				}
				IL_80:
				if (false)
				{
				}
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0004B8FC File Offset: 0x00049AFC
		public LocalCbtHook() : base(global::custom_controls.HookType.WH_CBT)
		{
			base.HookInvoked += this.a;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0004B944 File Offset: 0x00049B44
		public LocalCbtHook(global::custom_controls.LocalWindowsHook.HookProc func) : base(global::custom_controls.HookType.WH_CBT, func)
		{
			base.HookInvoked += this.a;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0004B98C File Offset: 0x00049B8C
		private void a(object A_0, global::custom_controls.HookEventArgs A_1)
		{
			global::custom_controls.CbtHookAction hookCode = (global::custom_controls.CbtHookAction)A_1.HookCode;
			global::System.IntPtr wparam = A_1.WParam;
			global::System.IntPtr lparam = A_1.LParam;
			switch (hookCode)
			{
			case global::custom_controls.CbtHookAction.HCBT_CREATEWND:
				this.c(wparam, lparam);
				return;
			case global::custom_controls.CbtHookAction.HCBT_DESTROYWND:
				break;
			case global::custom_controls.CbtHookAction.HCBT_ACTIVATE:
				this.a(wparam, lparam);
				return;
			default:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					return;
				}
				break;
			}
			if (true)
			{
			}
			this.b(wparam, lparam);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0004BA10 File Offset: 0x00049C10
		private void c(global::System.IntPtr A_0, global::System.IntPtr A_1)
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
			this.a(A_0);
			this.OnWindowCreated();
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0004BA58 File Offset: 0x00049C58
		private void b(global::System.IntPtr A_0, global::System.IntPtr A_1)
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
			this.a(A_0);
			this.OnWindowDestroyed();
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0004BAA0 File Offset: 0x00049CA0
		private void a(global::System.IntPtr A_0, global::System.IntPtr A_1)
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
			this.a(A_0);
			this.OnWindowActivated();
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0004BAE8 File Offset: 0x00049CE8
		private void a(global::System.IntPtr A_0)
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
			this.d = A_0;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Capacity = 40;
			global::custom_controls.a.GetClassName(this.d, stringBuilder, 40);
			this.m_class = stringBuilder.ToString();
			global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
			stringBuilder2.Capacity = 256;
			global::custom_controls.a.GetWindowText(this.d, stringBuilder2, 256);
			this.m_title = stringBuilder2.ToString();
			this.m_isDialog = (this.m_class == "#32770");
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0004BB98 File Offset: 0x00049D98
		protected virtual void OnWindowCreated()
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
				{
					global::custom_controls.CbtEventArgs cbtEventArgs = new global::custom_controls.CbtEventArgs();
					this.a(cbtEventArgs);
					this.a(this, cbtEventArgs);
					goto IL_5A;
				}
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
						goto IL_78;
					}
					break;
				}
				if (true)
				{
				}
				if (this.a != null)
				{
					num = 1;
					continue;
				}
				return;
				IL_5A:
				num = 2;
			}
			IL_78:
			if (false)
			{
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0004BC28 File Offset: 0x00049E28
		protected virtual void OnWindowDestroyed()
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
				{
					global::custom_controls.CbtEventArgs cbtEventArgs = new global::custom_controls.CbtEventArgs();
					this.a(cbtEventArgs);
					this.b(this, cbtEventArgs);
					goto IL_5A;
				}
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
						goto IL_78;
					}
					break;
				}
				if (true)
				{
				}
				if (this.b != null)
				{
					num = 0;
					continue;
				}
				return;
				IL_5A:
				num = 2;
			}
			IL_78:
			if (false)
			{
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0004BCB8 File Offset: 0x00049EB8
		protected virtual void OnWindowActivated()
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					global::custom_controls.CbtEventArgs cbtEventArgs = new global::custom_controls.CbtEventArgs();
					this.a(cbtEventArgs);
					this.c(this, cbtEventArgs);
					num = 0;
					continue;
				}
				}
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
					if (this.c == null)
					{
						return;
					}
					break;
				}
				num = 1;
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0004BD48 File Offset: 0x00049F48
		private void a(global::custom_controls.CbtEventArgs A_0)
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
			A_0.Handle = this.d;
			A_0.Title = this.m_title;
			A_0.ClassName = this.m_class;
			A_0.IsDialogWindow = this.m_isDialog;
		}

		// Token: 0x04000343 RID: 835
		private global::custom_controls.LocalCbtHook.CbtEventHandler a;

		// Token: 0x04000344 RID: 836
		private global::custom_controls.LocalCbtHook.CbtEventHandler b;

		// Token: 0x04000345 RID: 837
		private global::custom_controls.LocalCbtHook.CbtEventHandler c;

		// Token: 0x04000346 RID: 838
		private global::System.IntPtr d = global::System.IntPtr.Zero;

		// Token: 0x04000347 RID: 839
		protected string m_title = "";

		// Token: 0x04000348 RID: 840
		protected string m_class = "";

		// Token: 0x04000349 RID: 841
		protected bool m_isDialog;

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060004D5 RID: 1237
		public delegate void CbtEventHandler(object sender, global::custom_controls.CbtEventArgs e);
	}
}
