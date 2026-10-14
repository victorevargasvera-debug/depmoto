using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace msclr
{
	// Token: 0x0200000D RID: 13
	internal class @lock : global::System.IDisposable
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00020A44 File Offset: 0x0001FE44
		public @lock(object _object)
		{
			this.acquire(-1);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00020A98 File Offset: 0x0001FE98
		private void ~lock()
		{
			this.release();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0001FB6C File Offset: 0x0001EF6C
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		public bool is_locked()
		{
			return this.m_locked;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0001FB80 File Offset: 0x0001EF80
		public implicit operator string()
		{
			return (!this.m_locked) ? global::msclr._detail_class._safe_false : global::msclr._detail_class._safe_true;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0001FC1C File Offset: 0x0001F01C
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

		// Token: 0x060000B0 RID: 176 RVA: 0x0001FBE0 File Offset: 0x0001EFE0
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

		// Token: 0x060000B1 RID: 177 RVA: 0x0001FBA4 File Offset: 0x0001EFA4
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

		// Token: 0x060000B2 RID: 178 RVA: 0x0001FC8C File Offset: 0x0001F08C
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

		// Token: 0x060000B3 RID: 179 RVA: 0x0001FC58 File Offset: 0x0001F058
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

		// Token: 0x060000B4 RID: 180 RVA: 0x0001FCC0 File Offset: 0x0001F0C0
		public void release()
		{
			if (this.m_locked)
			{
				global::System.Threading.Monitor.Exit(this.m_object);
				this.m_locked = false;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00020AAC File Offset: 0x0001FEAC
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

		// Token: 0x060000B6 RID: 182 RVA: 0x00020FF8 File Offset: 0x000203F8
		public sealed void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400005E RID: 94
		private object m_object = _object;

		// Token: 0x0400005F RID: 95
		private bool m_locked = false;
	}
}
