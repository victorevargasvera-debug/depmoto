using System;
using System.Diagnostics;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200002B RID: 43
	internal class RUDPHighAccurateTimer
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00007566 File Offset: 0x00005766
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0000756E File Offset: 0x0000576E
		public int Interval
		{
			get
			{
				return this.intervalMs;
			}
			set
			{
				this.intervalMs = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00007577 File Offset: 0x00005777
		private bool Running
		{
			get
			{
				return this.running;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000757F File Offset: 0x0000577F
		public long TriggerCounter
		{
			get
			{
				return this.triggerCounter;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00007587 File Offset: 0x00005787
		public RUDPHighAccurateTimer(string name, int interval, global::Motorola.Common.Communication.RUDP.TimerCallBack cb)
		{
			this.intervalMs = interval;
			this.callback = cb;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000075A4 File Offset: 0x000057A4
		public void Reset()
		{
			this.nextTriggerTick = global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer.CurrentMicroSeconds + (long)this.intervalMs;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000075B9 File Offset: 0x000057B9
		public void CheckForTick(long currentTicks)
		{
			if (this.running && currentTicks >= this.nextTriggerTick)
			{
				this.OnTick(currentTicks);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000075D3 File Offset: 0x000057D3
		public void Start()
		{
			this.running = true;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000075DC File Offset: 0x000057DC
		public void Stop()
		{
			this.running = false;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000075E5 File Offset: 0x000057E5
		public static long CurrentMicroSeconds
		{
			get
			{
				return (long)((double)global::System.Diagnostics.Stopwatch.GetTimestamp() / global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer._frequency);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000075F4 File Offset: 0x000057F4
		private static long CurrentTicks
		{
			get
			{
				return global::System.Diagnostics.Stopwatch.GetTimestamp();
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000075FB File Offset: 0x000057FB
		private void OnTick(long currentTicks)
		{
			if (this.callback != null)
			{
				this.callback(this);
			}
			this.nextTriggerTick = currentTicks;
			this.triggerCounter += 1L;
		}

		// Token: 0x040000E8 RID: 232
		private static double _frequency = (double)global::System.Diagnostics.Stopwatch.Frequency / 1000000.0;

		// Token: 0x040000E9 RID: 233
		private int intervalMs = 1;

		// Token: 0x040000EA RID: 234
		private long nextTriggerTick;

		// Token: 0x040000EB RID: 235
		private long triggerCounter;

		// Token: 0x040000EC RID: 236
		private bool running;

		// Token: 0x040000ED RID: 237
		private global::Motorola.Common.Communication.RUDP.TimerCallBack callback;
	}
}
