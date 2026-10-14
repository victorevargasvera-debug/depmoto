using System;
using System.Timers;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000026 RID: 38
	public class UDPRadioProfile : global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile, global::System.IDisposable
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00007458 File Offset: 0x00005658
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00007460 File Offset: 0x00005660
		public string UniqueIndendifier { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00007469 File Offset: 0x00005669
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00007471 File Offset: 0x00005671
		public string PasswordId { get; set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000747A File Offset: 0x0000567A
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00007482 File Offset: 0x00005682
		public string Password { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0000748B File Offset: 0x0000568B
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00007493 File Offset: 0x00005693
		public string DomainName { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0000749C File Offset: 0x0000569C
		// (set) Token: 0x06000175 RID: 373 RVA: 0x000074A4 File Offset: 0x000056A4
		public global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode DeviceConnectionMode { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000074AD File Offset: 0x000056AD
		public override string RadioIdString
		{
			get
			{
				return this.UniqueIndendifier;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000074B5 File Offset: 0x000056B5
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000074BD File Offset: 0x000056BD
		public global::Motorola.Common.Communication.DeviceDiscovery.UDPDetectorBase HostDetector { get; set; }

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000179 RID: 377 RVA: 0x000074C8 File Offset: 0x000056C8
		// (remove) Token: 0x0600017A RID: 378 RVA: 0x00007500 File Offset: 0x00005700
		public event global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.detachDeviceEventHandler detach;

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00007535 File Offset: 0x00005735
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000753D File Offset: 0x0000573D
		public global::System.Timers.Timer TimeToLive
		{
			get
			{
				return this.timeToLive;
			}
			set
			{
				this.timeToLive = value;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00007546 File Offset: 0x00005746
		public void StartTimer()
		{
			this.timeToLive.Elapsed += this.timeToLive_Expired;
			this.timeToLive.Start();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000756A File Offset: 0x0000576A
		private void timeToLive_Expired(object sender, global::System.Timers.ElapsedEventArgs e)
		{
			this.timeToLive.Stop();
			if (this.detach != null)
			{
				this.detach(this, null);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000758C File Offset: 0x0000578C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000759B File Offset: 0x0000579B
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.timeToLive.Close();
			}
		}

		// Token: 0x040000CE RID: 206
		private global::System.Timers.Timer timeToLive = new global::System.Timers.Timer(120000.0);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x06000183 RID: 387
		public delegate void detachDeviceEventHandler(object sender, global::System.EventArgs e);
	}
}
