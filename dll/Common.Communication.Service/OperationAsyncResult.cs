using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000004 RID: 4
	internal class OperationAsyncResult : global::Motorola.Common.Communication.Service.IOperationAsyncResult, global::System.IAsyncResult, global::System.IDisposable
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000020D0 File Offset: 0x000002D0
		public OperationAsyncResult(string operationID, global::System.AsyncCallback callback, object state)
		{
			if (string.IsNullOrEmpty(operationID))
			{
				this.OperationId = global::System.Guid.NewGuid().ToString();
			}
			else
			{
				this.OperationId = operationID;
			}
			this.Error = null;
			this.m_AsyncCallback = callback;
			this.AsyncState = state;
			this.m_ManualResentEvent = new global::System.Threading.ManualResetEvent(false);
			global::System.Reflection.MethodBase method = new global::System.Diagnostics.StackTrace().GetFrame(1).GetMethod();
			if (method != null)
			{
				this.m_InterfaceName = method.Name;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000215F File Offset: 0x0000035F
		public string InterfaceName
		{
			get
			{
				return this.m_InterfaceName;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002167 File Offset: 0x00000367
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000216F File Offset: 0x0000036F
		public object Output { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002178 File Offset: 0x00000378
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002180 File Offset: 0x00000380
		public global::System.Exception Error { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002189 File Offset: 0x00000389
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002191 File Offset: 0x00000391
		public string OperationId { get; private set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000219A File Offset: 0x0000039A
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000021A2 File Offset: 0x000003A2
		public global::Motorola.Common.Communication.Service.AsyncStatus AsyncStatus { get; private set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000021AB File Offset: 0x000003AB
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000021B3 File Offset: 0x000003B3
		public object AsyncState { get; private set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000021BC File Offset: 0x000003BC
		public global::System.Threading.WaitHandle AsyncWaitHandle
		{
			get
			{
				return this.m_ManualResentEvent;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000021C4 File Offset: 0x000003C4
		public bool CompletedSynchronously
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000021C7 File Offset: 0x000003C7
		public bool IsCompleted
		{
			get
			{
				return this.m_ManualResentEvent.WaitOne(0, false);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000027 RID: 39 RVA: 0x000021D6 File Offset: 0x000003D6
		// (remove) Token: 0x06000028 RID: 40 RVA: 0x000021EF File Offset: 0x000003EF
		public event global::System.EventHandler Canceled
		{
			add
			{
				this.m_Canceled = (global::System.EventHandler)global::System.Delegate.Combine(this.m_Canceled, value);
			}
			remove
			{
				this.m_Canceled = (global::System.EventHandler)global::System.Delegate.Remove(this.m_Canceled, value);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000029 RID: 41 RVA: 0x00002208 File Offset: 0x00000408
		// (remove) Token: 0x0600002A RID: 42 RVA: 0x00002221 File Offset: 0x00000421
		public event global::System.EventHandler CancelReading
		{
			add
			{
				this.m_CacelReading = (global::System.EventHandler)global::System.Delegate.Combine(this.m_CacelReading, value);
			}
			remove
			{
				this.m_CacelReading = (global::System.EventHandler)global::System.Delegate.Remove(this.m_CacelReading, value);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600002B RID: 43 RVA: 0x0000223A File Offset: 0x0000043A
		// (remove) Token: 0x0600002C RID: 44 RVA: 0x00002253 File Offset: 0x00000453
		public event global::System.EventHandler Started
		{
			add
			{
				this.m_Started = (global::System.EventHandler)global::System.Delegate.Combine(this.m_Started, value);
			}
			remove
			{
				this.m_Started = (global::System.EventHandler)global::System.Delegate.Remove(this.m_Started, value);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600002D RID: 45 RVA: 0x0000226C File Offset: 0x0000046C
		// (remove) Token: 0x0600002E RID: 46 RVA: 0x00002285 File Offset: 0x00000485
		public event global::System.EventHandler Queued
		{
			add
			{
				this.m_Queued = (global::System.EventHandler)global::System.Delegate.Combine(this.m_Queued, value);
			}
			remove
			{
				this.m_Queued = (global::System.EventHandler)global::System.Delegate.Remove(this.m_Queued, value);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600002F RID: 47 RVA: 0x0000229E File Offset: 0x0000049E
		// (remove) Token: 0x06000030 RID: 48 RVA: 0x000022B7 File Offset: 0x000004B7
		public event global::System.EventHandler Operation
		{
			add
			{
				this.m_Operation = (global::System.EventHandler)global::System.Delegate.Combine(this.m_Operation, value);
			}
			remove
			{
				this.m_Operation = (global::System.EventHandler)global::System.Delegate.Remove(this.m_Operation, value);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000022D0 File Offset: 0x000004D0
		public virtual void OnQueued()
		{
			lock (this.m_SyncRoot)
			{
				if (this.AsyncStatus != global::Motorola.Common.Communication.Service.AsyncStatus.Completed && this.AsyncStatus != global::Motorola.Common.Communication.Service.AsyncStatus.Canceled)
				{
					this.AsyncStatus = global::Motorola.Common.Communication.Service.AsyncStatus.Queued;
				}
			}
			if (this.m_Queued != null)
			{
				this.m_Queued(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000233C File Offset: 0x0000053C
		public virtual void OnStarted()
		{
			lock (this.m_SyncRoot)
			{
				if (this.AsyncStatus != global::Motorola.Common.Communication.Service.AsyncStatus.Completed && this.AsyncStatus != global::Motorola.Common.Communication.Service.AsyncStatus.Canceled)
				{
					this.AsyncStatus = global::Motorola.Common.Communication.Service.AsyncStatus.Started;
				}
			}
			if (this.m_Started != null)
			{
				this.m_Started(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000023A8 File Offset: 0x000005A8
		public virtual void OnCanceled()
		{
			lock (this.m_SyncRoot)
			{
				if (this.AsyncStatus != global::Motorola.Common.Communication.Service.AsyncStatus.Completed)
				{
					this.AsyncStatus = global::Motorola.Common.Communication.Service.AsyncStatus.Canceled;
				}
			}
			this.Callback();
			if (this.m_Canceled != null)
			{
				this.m_Canceled(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002414 File Offset: 0x00000614
		public virtual void OnCancelReading()
		{
			if (this.m_CacelReading != null)
			{
				this.m_CacelReading(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002430 File Offset: 0x00000630
		public virtual void OnCompleted()
		{
			lock (this.m_SyncRoot)
			{
				this.AsyncStatus = global::Motorola.Common.Communication.Service.AsyncStatus.Completed;
			}
			this.Callback();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002478 File Offset: 0x00000678
		public virtual void OnOperation()
		{
			if (this.m_Operation != null)
			{
				global::System.Console.ForegroundColor = global::System.ConsoleColor.Green;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Started call the interface <{0}><{1}>", new object[]
				{
					this.m_InterfaceName,
					this.OperationId
				});
				global::System.Console.ResetColor();
				this.m_Operation(this, global::System.EventArgs.Empty);
				global::System.Console.ForegroundColor = global::System.ConsoleColor.Green;
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Ended call the interface <{0}><{1}>", new object[]
				{
					this.m_InterfaceName,
					this.OperationId
				});
				global::System.Console.ResetColor();
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002508 File Offset: 0x00000708
		private void Callback()
		{
			this.m_ManualResentEvent.Set();
			if (this.m_AsyncCallback != null)
			{
				this.m_AsyncCallback(this);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000038 RID: 56 RVA: 0x0000252C File Offset: 0x0000072C
		// (remove) Token: 0x06000039 RID: 57 RVA: 0x00002564 File Offset: 0x00000764
		private event global::System.EventHandler m_Disposed;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600003A RID: 58 RVA: 0x00002599 File Offset: 0x00000799
		// (remove) Token: 0x0600003B RID: 59 RVA: 0x000025A2 File Offset: 0x000007A2
		public event global::System.EventHandler Disposed
		{
			add
			{
				this.m_Disposed += value;
			}
			remove
			{
				this.m_Disposed -= value;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000025AB File Offset: 0x000007AB
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000025BC File Offset: 0x000007BC
		protected virtual void Dispose(bool disposing)
		{
			try
			{
				if (!this.m_IsDisposed && disposing)
				{
					this.m_ManualResentEvent.Close();
					this.m_ManualResentEvent = null;
					this.AsyncState = null;
					if (this.m_Disposed != null)
					{
						this.m_Disposed(this, global::System.EventArgs.Empty);
						this.m_Disposed = null;
					}
					this.m_Started = null;
					this.m_Queued = null;
					this.m_Canceled = null;
					this.m_Operation = null;
					this.m_CacelReading = null;
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, new object[0]);
			}
			finally
			{
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x04000007 RID: 7
		private global::System.AsyncCallback m_AsyncCallback;

		// Token: 0x04000008 RID: 8
		private global::System.Threading.ManualResetEvent m_ManualResentEvent;

		// Token: 0x04000009 RID: 9
		private global::System.EventHandler m_Canceled;

		// Token: 0x0400000A RID: 10
		private global::System.EventHandler m_Queued;

		// Token: 0x0400000B RID: 11
		private global::System.EventHandler m_Started;

		// Token: 0x0400000C RID: 12
		private global::System.EventHandler m_Operation;

		// Token: 0x0400000D RID: 13
		private global::System.EventHandler m_CacelReading;

		// Token: 0x0400000E RID: 14
		private string m_InterfaceName;

		// Token: 0x0400000F RID: 15
		private object m_SyncRoot = new object();

		// Token: 0x04000010 RID: 16
		private bool m_IsDisposed;
	}
}
