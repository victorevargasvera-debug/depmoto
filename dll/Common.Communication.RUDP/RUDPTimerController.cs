using System;
using System.Collections.Generic;
using System.Threading;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000021 RID: 33
	internal class RUDPTimerController : global::System.IDisposable
	{
		// Token: 0x0600017E RID: 382 RVA: 0x00006A2C File Offset: 0x00004C2C
		public RUDPTimerController()
		{
			if (global::Motorola.Common.Communication.RUDP.NativeMethods.QueryPerformanceFrequency(out this.clockFrequency))
			{
				this._timerThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.ThreadProc));
				this._timerThread.Name = "RUDPHighAccurateTimer";
				this._timerThread.Priority = global::System.Threading.ThreadPriority.Highest;
				return;
			}
			this._timer = new global::System.Threading.Timer(new global::System.Threading.TimerCallback(this.TimerProc), this, 0, 100);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00006AB8 File Offset: 0x00004CB8
		public void RegisterTimer(global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer timer)
		{
			this._rudpTimerLock.EnterWriteLock();
			try
			{
				this._rudpTimerList.Add(timer);
			}
			finally
			{
				this._rudpTimerLock.ExitWriteLock();
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00006AFC File Offset: 0x00004CFC
		private void UnregisterTimer(global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer timer)
		{
			this._rudpTimerLock.EnterWriteLock();
			try
			{
				this._rudpTimerList.Remove(timer);
			}
			finally
			{
				this._rudpTimerLock.ExitWriteLock();
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00006B40 File Offset: 0x00004D40
		public void Start()
		{
			this.running = true;
			if (this._timer != null)
			{
				this._timer.Change(0, 100);
				return;
			}
			this._timerThread.Start();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00006B6C File Offset: 0x00004D6C
		private void Pause()
		{
			this.running = false;
			if (this._timer != null)
			{
				this._timer.Change(-1, 100);
				this._timer.Dispose();
				this._timer = null;
				return;
			}
			try
			{
				bool isAlive = this._timerThread.IsAlive;
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00006BD4 File Offset: 0x00004DD4
		public void Stop()
		{
			this.Pause();
			this._rudpTimerList.ForEach(delegate(global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer tt)
			{
				tt.Stop();
			});
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00006C04 File Offset: 0x00004E04
		private void ThreadProc()
		{
			while (this.running)
			{
				long currentMicroSeconds = global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer.CurrentMicroSeconds;
				this.TimerProc(this);
				long num = global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer.CurrentMicroSeconds - currentMicroSeconds;
				if (100L > num)
				{
					global::System.Threading.Thread.Sleep((int)(100L - num));
				}
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00006C44 File Offset: 0x00004E44
		private void TimerProc(object state)
		{
			if (this.running)
			{
				long currentMicroSeconds = global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer.CurrentMicroSeconds;
				this._rudpTimerLock.EnterReadLock();
				try
				{
					foreach (global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer rudphighAccurateTimer in this._rudpTimerList)
					{
						rudphighAccurateTimer.CheckForTick(currentMicroSeconds);
					}
				}
				catch (global::System.Exception)
				{
				}
				finally
				{
					this._rudpTimerLock.ExitReadLock();
				}
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00006CDC File Offset: 0x00004EDC
		private static bool GetTick(out long currentTickCount)
		{
			if (!global::Motorola.Common.Communication.RUDP.NativeMethods.QueryPerformanceCounter(out currentTickCount))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_HighAccurateTimer_QueryPerformanceCounterFailed);
			}
			return true;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00006CF2 File Offset: 0x00004EF2
		protected virtual void Dispose(bool disposing)
		{
			if (!this.m_IsDisposed)
			{
				if (disposing)
				{
					this._timer.Dispose();
					this._rudpTimerLock.Dispose();
				}
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00006D1C File Offset: 0x00004F1C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040000D9 RID: 217
		private const int RUDP_TIMER_BASE_UNIT_IN_MS = 100;

		// Token: 0x040000DA RID: 218
		private long clockFrequency;

		// Token: 0x040000DB RID: 219
		private bool running = true;

		// Token: 0x040000DC RID: 220
		private global::System.Threading.Thread _timerThread;

		// Token: 0x040000DD RID: 221
		private global::System.Threading.Timer _timer;

		// Token: 0x040000DE RID: 222
		private global::System.Threading.ReaderWriterLockSlim _rudpTimerLock = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x040000DF RID: 223
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer> _rudpTimerList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer>();

		// Token: 0x040000E0 RID: 224
		private bool m_IsDisposed;
	}
}
