using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace msclr
{
	// Token: 0x0200000F RID: 15
	internal class @lock : global::System.IDisposable
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00001B80 File Offset: 0x00000F80
		public @lock(object _object)
		{
			this.acquire(-1);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00001BF8 File Offset: 0x00000FF8
		private void ~lock()
		{
			this.release();
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000013AC File Offset: 0x000007AC
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		public bool is_locked()
		{
			return this.m_locked;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000013C0 File Offset: 0x000007C0
		public implicit operator string()
		{
			return (!this.m_locked) ? global::msclr._detail_class._safe_false : global::msclr._detail_class._safe_true;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000145C File Offset: 0x0000085C
		public void acquire(global::System.TimeSpan _timeout)
		{
			if (!this.m_locked)
			{
				global::System.Threading.Monitor.TryEnter(this.m_object, _timeout, ref this.m_locked);
				if (!this.m_locked)
				{
					throw global::System.Runtime.InteropServices.Marshal.GetExceptionForHR(-2147024638);
				}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00001420 File Offset: 0x00000820
		public void acquire()
		{
			if (!this.m_locked)
			{
				global::System.Threading.Monitor.TryEnter(this.m_object, -1, ref this.m_locked);
				if (!this.m_locked)
				{
					throw global::System.Runtime.InteropServices.Marshal.GetExceptionForHR(-2147024638);
				}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000013E4 File Offset: 0x000007E4
		public void acquire(int _timeout)
		{
			if (!this.m_locked)
			{
				global::System.Threading.Monitor.TryEnter(this.m_object, _timeout, ref this.m_locked);
				if (!this.m_locked)
				{
					throw global::System.Runtime.InteropServices.Marshal.GetExceptionForHR(-2147024638);
				}
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000014CC File Offset: 0x000008CC
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		public bool try_acquire(global::System.TimeSpan _timeout)
		{
			if (!this.m_locked)
			{
				global::System.Threading.Monitor.TryEnter(this.m_object, _timeout, ref this.m_locked);
				if (!this.m_locked)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00001498 File Offset: 0x00000898
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		public bool try_acquire(int _timeout)
		{
			if (!this.m_locked)
			{
				global::System.Threading.Monitor.TryEnter(this.m_object, _timeout, ref this.m_locked);
				if (!this.m_locked)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00001500 File Offset: 0x00000900
		public void release()
		{
			if (this.m_locked)
			{
				global::System.Threading.Monitor.Exit(this.m_object);
				this.m_locked = false;
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00001C0C File Offset: 0x0000100C
		protected virtual void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool A_0)
		{
			if (A_0)
			{
				this.release();
			}
			else
			{
				base.Finalize();
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000029C8 File Offset: 0x00001DC8
		public sealed void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400008F RID: 143
		private object m_object = _object;

		// Token: 0x04000090 RID: 144
		private bool m_locked = false;
	}
}
