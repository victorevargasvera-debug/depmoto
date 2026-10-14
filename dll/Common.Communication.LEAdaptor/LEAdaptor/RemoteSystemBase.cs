using System;
using System.Runtime.InteropServices;
using custom_datatypes;
using msclr;

namespace LEAdaptor
{
	// Token: 0x02000014 RID: 20
	public abstract class RemoteSystemBase : global::LEAdaptor.IMRemoteSystem
	{
		// Token: 0x0600010B RID: 267 RVA: 0x000054DC File Offset: 0x000048DC
		public RemoteSystemBase()
		{
			this.@lock = new object();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000054FC File Offset: 0x000048FC
		private void ~RemoteSystemBase()
		{
		}

		// Token: 0x0600010D RID: 269
		public abstract int Open();

		// Token: 0x0600010E RID: 270
		public abstract int Close();

		// Token: 0x0600010F RID: 271
		public abstract int SendProxyConnectRequest(uint targetPeerID, uint sourceIP, ushort sourcePort, byte connectionType, out ushort response);

		// Token: 0x06000110 RID: 272
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		public abstract bool GetPeerMapData(out global::custom_datatypes.MLEPeer[] peers);

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000111 RID: 273 RVA: 0x00001C2C File Offset: 0x0000102C
		// (remove) Token: 0x06000112 RID: 274 RVA: 0x00001C8C File Offset: 0x0000108C
		public virtual event global::LEAdaptor.StatusChangeHandler OnStatusChange
		{
			add
			{
				global::msclr.@lock @lock = null;
				global::msclr.@lock lock2 = new global::msclr.@lock(this.@lock);
				try
				{
					@lock = lock2;
					this.statusChanged = (global::LEAdaptor.StatusChangeHandler)global::System.Delegate.Combine(this.statusChanged, value);
				}
				catch
				{
					((global::System.IDisposable)@lock).Dispose();
					throw;
				}
				((global::System.IDisposable)@lock).Dispose();
			}
			remove
			{
				global::msclr.@lock @lock = null;
				global::msclr.@lock lock2 = new global::msclr.@lock(this.@lock);
				try
				{
					@lock = lock2;
					this.statusChanged = (global::LEAdaptor.StatusChangeHandler)global::System.Delegate.Remove(this.statusChanged, value);
				}
				catch
				{
					((global::System.IDisposable)@lock).Dispose();
					throw;
				}
				((global::System.IDisposable)@lock).Dispose();
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000016BC File Offset: 0x00000ABC
		protected virtual void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool A_0)
		{
			if (A_0)
			{
				this.~RemoteSystemBase();
			}
			else
			{
				base.Finalize();
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00001D48 File Offset: 0x00001148
		public sealed void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000099 RID: 153
		private object @lock;

		// Token: 0x0400009A RID: 154
		private global::LEAdaptor.StatusChangeHandler statusChanged;
	}
}
