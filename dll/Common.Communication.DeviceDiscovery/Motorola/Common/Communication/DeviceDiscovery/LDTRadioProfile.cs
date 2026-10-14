using System;
using System.Timers;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x0200001B RID: 27
	public class LDTRadioProfile : global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile, global::System.IDisposable
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00005954 File Offset: 0x00003B54
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000595C File Offset: 0x00003B5C
		public string IMEI { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00005965 File Offset: 0x00003B65
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000596D File Offset: 0x00003B6D
		public string PasswordId { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00005976 File Offset: 0x00003B76
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000597E File Offset: 0x00003B7E
		public string Password { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00005987 File Offset: 0x00003B87
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000598F File Offset: 0x00003B8F
		public string DomainName { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00005998 File Offset: 0x00003B98
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000059A0 File Offset: 0x00003BA0
		public global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode ConnectMode { get; set; }

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000CB RID: 203 RVA: 0x000059AC File Offset: 0x00003BAC
		// (remove) Token: 0x060000CC RID: 204 RVA: 0x000059E4 File Offset: 0x00003BE4
		public event global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile.detachDeviceEventHandler detach;

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00005A19 File Offset: 0x00003C19
		public override string RadioIdString
		{
			get
			{
				return this.IMEI;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00005A21 File Offset: 0x00003C21
		public string AstroRadioIdString
		{
			get
			{
				return this.RadioIdString;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00005A29 File Offset: 0x00003C29
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00005A31 File Offset: 0x00003C31
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00005A3A File Offset: 0x00003C3A
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00005A42 File Offset: 0x00003C42
		public uint TTL { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00005A4B File Offset: 0x00003C4B
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00005A53 File Offset: 0x00003C53
		public long LastRenewSeconds { get; set; }

		// Token: 0x060000D5 RID: 213 RVA: 0x00005A5C File Offset: 0x00003C5C
		public void StartTimer()
		{
			this.LastRenewSeconds = this.DateTime2Seconds(global::System.DateTime.Now);
			this.status = global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Attached;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005A76 File Offset: 0x00003C76
		public void StopTimer()
		{
			this.LastRenewSeconds = -1L;
			this.status = global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Detached;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005A88 File Offset: 0x00003C88
		private long DateTime2Seconds(global::System.DateTime dt)
		{
			return (long)new global::System.TimeSpan(dt.Ticks).TotalSeconds;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005AAC File Offset: 0x00003CAC
		private void timeToLive_Expired(object sender, global::System.Timers.ElapsedEventArgs e)
		{
			try
			{
				if (this.status == global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Attached)
				{
					this.status = global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Detaching;
					global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.QueryDevices(base.IPAddress);
				}
				else if (this.status == global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Detaching)
				{
					this.timeToLive.Stop();
					this.status = global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Detached;
					if (this.detach != null)
					{
						this.detach(this, null);
					}
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Unexpected error on wifi device detach.", new object[0]);
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("timeToLive_Expired: " + ex.Message, new object[0]);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005B54 File Offset: 0x00003D54
		internal bool CheckTimer()
		{
			long num = this.DateTime2Seconds(global::System.DateTime.Now);
			if (num - this.LastRenewSeconds > (long)((ulong)this.TTL) && this.status == global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Attached)
			{
				this.status = global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus.Detaching;
				global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.QueryDevices(base.IPAddress);
			}
			else if (num - this.LastRenewSeconds > (long)((ulong)(this.TTL + this.TTL / 2U)))
			{
				this.StopTimer();
				return false;
			}
			return true;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005BBD File Offset: 0x00003DBD
		public void SetIPAddress(string address)
		{
			base.IPAddress = address;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005BC6 File Offset: 0x00003DC6
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00005BD5 File Offset: 0x00003DD5
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.timeToLive.Close();
			}
		}

		// Token: 0x04000077 RID: 119
		internal const long STOP = -1L;

		// Token: 0x04000078 RID: 120
		private global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioStatus status;

		// Token: 0x04000079 RID: 121
		private global::System.Timers.Timer timeToLive = new global::System.Timers.Timer(120000.0);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000DF RID: 223
		public delegate void detachDeviceEventHandler(object sender, global::System.EventArgs e);
	}
}
