using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace custom_controls
{
	// Token: 0x02000071 RID: 113
	public class LocalWindowsHook : global::System.IDisposable
	{
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060004AD RID: 1197 RVA: 0x0004B10C File Offset: 0x0004930C
		// (remove) Token: 0x060004AE RID: 1198 RVA: 0x0004B1A4 File Offset: 0x000493A4
		public event global::custom_controls.LocalWindowsHook.HookEventHandler HookInvoked
		{
			add
			{
				for (;;)
				{
					global::custom_controls.LocalWindowsHook.HookEventHandler hookEventHandler = this.c;
					if (true)
					{
					}
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_2D;
						case 1:
						{
							global::custom_controls.LocalWindowsHook.HookEventHandler hookEventHandler2;
							if (hookEventHandler == hookEventHandler2)
							{
								num = 2;
								continue;
							}
							goto IL_2D;
						}
						case 2:
							return;
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
							global::custom_controls.LocalWindowsHook.HookEventHandler hookEventHandler2 = hookEventHandler;
							global::custom_controls.LocalWindowsHook.HookEventHandler value2 = (global::custom_controls.LocalWindowsHook.HookEventHandler)global::System.Delegate.Combine(hookEventHandler2, value);
							hookEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.LocalWindowsHook.HookEventHandler>(ref this.c, value2, hookEventHandler2);
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
					global::custom_controls.LocalWindowsHook.HookEventHandler hookEventHandler = this.c;
					if (true)
					{
					}
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
						num = 1;
						break;
					}
					for (;;)
					{
						global::custom_controls.LocalWindowsHook.HookEventHandler hookEventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_49;
						case 2:
							if (hookEventHandler == hookEventHandler2)
							{
								num = 0;
								continue;
							}
							goto IL_49;
						}
						break;
						IL_49:
						hookEventHandler2 = hookEventHandler;
						global::custom_controls.LocalWindowsHook.HookEventHandler value2 = (global::custom_controls.LocalWindowsHook.HookEventHandler)global::System.Delegate.Remove(hookEventHandler2, value);
						hookEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.LocalWindowsHook.HookEventHandler>(ref this.c, value2, hookEventHandler2);
						num = 2;
					}
				}
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0004B23C File Offset: 0x0004943C
		protected void OnHookInvoked(global::custom_controls.HookEventArgs e)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						this.c(this, e);
						if (true)
						{
						}
						num = 1;
						continue;
					}
					break;
				case 1:
					return;
				}
				if (this.c == null)
				{
					break;
				}
				num = 0;
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0004B2BC File Offset: 0x000494BC
		public LocalWindowsHook(global::custom_controls.HookType hook)
		{
			this.m_hookType = hook;
			this.m_filterFunc = new global::custom_controls.LocalWindowsHook.HookProc(this.CoreHookProc);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0004B2F4 File Offset: 0x000494F4
		public LocalWindowsHook(global::custom_controls.HookType hook, global::custom_controls.LocalWindowsHook.HookProc func)
		{
			this.m_hookType = hook;
			this.m_filterFunc = func;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0004B320 File Offset: 0x00049520
		protected int CoreHookProc(int code, global::System.IntPtr wParam, global::System.IntPtr lParam)
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
				if (code < 0)
				{
					if (true)
					{
					}
					return global::custom_controls.LocalWindowsHook.CallNextHookEx(this.a, code, wParam, lParam);
				}
				break;
			}
			this.OnHookInvoked(new global::custom_controls.HookEventArgs
			{
				HookCode = code,
				WParam = wParam,
				LParam = lParam
			});
			return global::custom_controls.LocalWindowsHook.CallNextHookEx(this.a, code, wParam, lParam);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0004B3A0 File Offset: 0x000495A0
		public void Install()
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
			this.a = global::custom_controls.LocalWindowsHook.SetWindowsHookEx(this.m_hookType, this.m_filterFunc, global::System.IntPtr.Zero, global::System.AppDomain.GetCurrentThreadId());
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0004B3FC File Offset: 0x000495FC
		public void Uninstall()
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
			global::custom_controls.LocalWindowsHook.UnhookWindowsHookEx(this.a);
		}

		// Token: 0x060004B5 RID: 1205
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern global::System.IntPtr SetWindowsHookEx(global::custom_controls.HookType A_0, global::custom_controls.LocalWindowsHook.HookProc A_1, global::System.IntPtr A_2, int A_3);

		// Token: 0x060004B6 RID: 1206
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int UnhookWindowsHookEx(global::System.IntPtr A_0);

		// Token: 0x060004B7 RID: 1207
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int CallNextHookEx(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2, global::System.IntPtr A_3);

		// Token: 0x060004B8 RID: 1208 RVA: 0x0004B444 File Offset: 0x00049644
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

		// Token: 0x060004B9 RID: 1209 RVA: 0x0004B48C File Offset: 0x0004968C
		protected virtual void Dispose(bool disposing)
		{
			int num = 2;
			for (;;)
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					if (false)
					{
					}
					switch (num)
					{
					case 0:
						return;
					case 1:
						this.a = global::System.IntPtr.Zero;
						this.b = true;
						num = 0;
						continue;
					}
					if (this.b)
					{
						return;
					}
					if (true)
					{
					}
					num = 1;
					break;
				}
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0004B514 File Offset: 0x00049714
		~LocalWindowsHook()
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
			this.Dispose(false);
		}

		// Token: 0x0400033E RID: 830
		private global::System.IntPtr a = global::System.IntPtr.Zero;

		// Token: 0x0400033F RID: 831
		protected global::custom_controls.LocalWindowsHook.HookProc m_filterFunc;

		// Token: 0x04000340 RID: 832
		protected global::custom_controls.HookType m_hookType;

		// Token: 0x04000341 RID: 833
		private bool b;

		// Token: 0x04000342 RID: 834
		private global::custom_controls.LocalWindowsHook.HookEventHandler c;

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060004BC RID: 1212
		public delegate int HookProc(int code, global::System.IntPtr wParam, global::System.IntPtr lParam);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060004C0 RID: 1216
		public delegate void HookEventHandler(object sender, global::custom_controls.HookEventArgs e);
	}
}
