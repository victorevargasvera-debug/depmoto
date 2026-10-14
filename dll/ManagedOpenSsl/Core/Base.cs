using System;

namespace OpenSSL.Core
{
	// Token: 0x02000002 RID: 2
	public abstract class Base : global::System.IDisposable
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		protected Base(global::System.IntPtr ptr, bool takeOwnership)
		{
			this.ptr = ptr;
			this.owner = takeOwnership;
			if (this.ptr != global::System.IntPtr.Zero)
			{
				this.OnNewHandle(this.ptr);
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002104 File Offset: 0x00000304
		~Base()
		{
			this.Dispose();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002130 File Offset: 0x00000330
		public virtual void Print(global::OpenSSL.Core.BIO bio)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002134 File Offset: 0x00000334
		public override string ToString()
		{
			string result;
			try
			{
				if (this.ptr == global::System.IntPtr.Zero)
				{
					result = "(null)";
				}
				else
				{
					using (global::OpenSSL.Core.BIO bio = global::OpenSSL.Core.BIO.MemoryBuffer())
					{
						this.Print(bio);
						result = bio.ReadString();
					}
				}
			}
			catch (global::System.Exception)
			{
				result = "<exception>";
			}
			return result;
		}

		// Token: 0x06000005 RID: 5
		protected abstract void OnDispose();

		// Token: 0x06000006 RID: 6 RVA: 0x000021A4 File Offset: 0x000003A4
		internal virtual void OnNewHandle(global::System.IntPtr ptr)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021A6 File Offset: 0x000003A6
		public void Dispose()
		{
			if (!this.isDisposed && this.owner && this.ptr != global::System.IntPtr.Zero)
			{
				this.OnDispose();
				this.DoAfterDispose();
			}
			this.isDisposed = true;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000021DD File Offset: 0x000003DD
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000021E5 File Offset: 0x000003E5
		public virtual bool IsOwner
		{
			get
			{
				return this.owner;
			}
			internal set
			{
				this.owner = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000021EE File Offset: 0x000003EE
		public virtual global::System.IntPtr Handle
		{
			get
			{
				return this.ptr;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000021F6 File Offset: 0x000003F6
		internal virtual void AddRef()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021FD File Offset: 0x000003FD
		private void DoAfterDispose()
		{
			this.ptr = global::System.IntPtr.Zero;
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000001 RID: 1
		protected global::System.IntPtr ptr;

		// Token: 0x04000002 RID: 2
		protected bool owner;

		// Token: 0x04000003 RID: 3
		protected bool isDisposed;
	}
}
