using System;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.RUDP.Helper
{
	// Token: 0x02000002 RID: 2
	internal class AsynchronousResult<T, TResult> : global::System.IAsyncResult, global::System.IDisposable
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public AsynchronousResult(global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<T, TResult>.SynFunc<T, TResult> workToBeDone, T Parameteres, global::System.AsyncCallback cbMethod, object state)
		{
			this._allowExecuteEvent = new global::System.Threading.ManualResetEvent(false);
			this._cbMethod = cbMethod;
			this._state = state;
			this._Parameteres = Parameteres;
			this._workToBeDone = workToBeDone;
			this.QueueWorkOnThreadPool(workToBeDone);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000021C0 File Offset: 0x000003C0
		private void QueueWorkOnThreadPool(global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<T, TResult>.SynFunc<T, TResult> workToBeDone)
		{
			global::System.Threading.ThreadPool.QueueUserWorkItem(delegate(object state)
			{
				this._allowExecuteEvent.WaitOne();
				try
				{
					workToBeDone(this._Parameteres, this);
					if (this._isCompleted && this._firstRun)
					{
						this._completedSynchronously = true;
						this._firstRun = false;
					}
				}
				catch (global::System.Exception exception)
				{
					this._exception = exception;
				}
			});
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021F3 File Offset: 0x000003F3
		public void Execute()
		{
			this.QueueWorkOnThreadPool(this._workToBeDone);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002201 File Offset: 0x00000401
		public void FireExecution()
		{
			this._allowExecuteEvent.Set();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002210 File Offset: 0x00000410
		public TResult FetchResultsFromAsyncOperation(int timeout = 0)
		{
			if (!this._isCompleted)
			{
				if (timeout == 0)
				{
					this.AsyncWaitHandle.WaitOne();
					this.AsyncWaitHandle.Close();
				}
				else if (this.IsCompleted || this.AsyncWaitHandle.WaitOne(timeout))
				{
					this.AsyncWaitHandle.Close();
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning("RUDP Async Call Timeout: {0}ms ", new object[]
					{
						timeout
					});
				}
			}
			if (this._exception != null)
			{
				throw this._exception;
			}
			return this._result;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000229B File Offset: 0x0000049B
		public void SetAsFailed(TResult result)
		{
			this._result = result;
			this.UpdateStatusToComplete();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022AA File Offset: 0x000004AA
		public void SetAsCompleted(TResult result)
		{
			this._result = result;
			this.UpdateStatusToComplete();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000022B9 File Offset: 0x000004B9
		public object AsyncState
		{
			get
			{
				return this._state;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000022C1 File Offset: 0x000004C1
		public global::System.Threading.WaitHandle AsyncWaitHandle
		{
			get
			{
				return this.GetEvtHandle();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CompletedSynchronously
		{
			get
			{
				return this._completedSynchronously;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000022D1 File Offset: 0x000004D1
		public bool IsCompleted
		{
			get
			{
				return this._isCompleted;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000022DB File Offset: 0x000004DB
		private T Parameteres
		{
			get
			{
				return this._Parameteres;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022E4 File Offset: 0x000004E4
		private global::System.Threading.ManualResetEvent GetEvtHandle()
		{
			lock (this._locker)
			{
				if (this._evt == null)
				{
					this._evt = new global::System.Threading.ManualResetEvent(false);
				}
				if (this._isCompleted)
				{
					this._evt.Set();
				}
			}
			return this._evt;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002350 File Offset: 0x00000550
		private void UpdateStatusToComplete()
		{
			this._isCompleted = true;
			lock (this._locker)
			{
				if (this._evt != null)
				{
					this._evt.Set();
				}
			}
			this.NotifyCallbackWhenAvailable();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000023B0 File Offset: 0x000005B0
		private void NotifyCallbackWhenAvailable()
		{
			if (this._cbMethod != null)
			{
				this._cbMethod(this);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000023C6 File Offset: 0x000005C6
		protected virtual void Dispose(bool disposing)
		{
			if (!this.m_IsDisposed)
			{
				if (disposing)
				{
					global::System.Threading.ManualResetEvent evt = this._evt;
				}
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023E1 File Offset: 0x000005E1
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000001 RID: 1
		private volatile bool _isCompleted;

		// Token: 0x04000002 RID: 2
		private global::System.Threading.ManualResetEvent _evt;

		// Token: 0x04000003 RID: 3
		private readonly global::System.AsyncCallback _cbMethod;

		// Token: 0x04000004 RID: 4
		private readonly object _state;

		// Token: 0x04000005 RID: 5
		private TResult _result;

		// Token: 0x04000006 RID: 6
		private global::System.Exception _exception;

		// Token: 0x04000007 RID: 7
		private readonly T _Parameteres;

		// Token: 0x04000008 RID: 8
		private global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<T, TResult>.SynFunc<T, TResult> _workToBeDone;

		// Token: 0x04000009 RID: 9
		private global::System.Threading.ManualResetEvent _allowExecuteEvent;

		// Token: 0x0400000A RID: 10
		private bool _firstRun = true;

		// Token: 0x0400000B RID: 11
		private bool _completedSynchronously;

		// Token: 0x0400000C RID: 12
		private readonly object _locker = new object();

		// Token: 0x0400000D RID: 13
		private bool m_IsDisposed;

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000013 RID: 19
		public delegate TRes SynFunc<in TARG, out TRes>(TARG arg, global::System.IAsyncResult ar);
	}
}
