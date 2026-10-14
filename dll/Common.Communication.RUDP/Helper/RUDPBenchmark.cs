using System;
using System.Globalization;

namespace Motorola.Common.Communication.RUDP.Helper
{
	// Token: 0x02000006 RID: 6
	internal class RUDPBenchmark
	{
		// Token: 0x0600001F RID: 31 RVA: 0x0000243C File Offset: 0x0000063C
		public void StartWatch()
		{
			this.APP_SENT_BYTES = 0;
			this.APP_RCVD_BYTES = 0;
			this.APP_SENT_PACKETS = 0;
			this.APP_RCVD_PACKETS = 0;
			this.RUDP_SENT_BYTES = 0;
			this.RUDP_RCVD_BYTES = 0;
			this.RUDP_SENT_PACKETS = 0;
			this.RUDP_RCVD_PACKETS = 0;
			this.RUDP_TOTAL_RESEND_BYTES = 0;
			this.RUDP_TOTAL_RESEND_PACKETS = 0;
			this.RUDP_TOTAL_RESEND_TIMES = 0;
			this.RUDP_TOTAL_REACK_TIMES = 0;
			this.RUDP_MAX_RESEND_TIMES = 0;
			this.RUDP_MAX_SENT_PACKET_TIME = 0L;
			this.RUDP_TOTAL_SENT_PACKET_TIME = 0L;
			this.RUDP_RCVD_DUPLICATED_PACKET_TIMES = 0;
			this.StartTick = global::System.DateTime.Now.Ticks;
			this.EndTick = 0L;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000024D8 File Offset: 0x000006D8
		public void StopWatch()
		{
			this.EndTick = global::System.DateTime.Now.Ticks;
			this.PrintStatistic();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002500 File Offset: 0x00000700
		private void PrintStatistic()
		{
			long num = (this.EndTick - this.StartTick) / 1000L * 1000L * 1000L * 1000L;
			new global::System.DateTime(this.StartTick).ToString("[MM/dd/yy HH:mm:ss.fff]", global::System.Globalization.CultureInfo.InvariantCulture);
			long num2 = (long)this.APP_SENT_BYTES / num;
			long num3 = (long)this.RUDP_SENT_BYTES / num;
			long num4 = (long)this.APP_RCVD_BYTES / num;
			long num5 = (long)this.RUDP_RCVD_BYTES / num;
			new global::System.DateTime(this.EndTick).ToString("[MM/dd/yy HH:mm:ss.fff]", global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x0400000E RID: 14
		public int APP_SENT_BYTES;

		// Token: 0x0400000F RID: 15
		public int APP_RCVD_BYTES;

		// Token: 0x04000010 RID: 16
		public int APP_SENT_PACKETS;

		// Token: 0x04000011 RID: 17
		public int APP_RCVD_PACKETS;

		// Token: 0x04000012 RID: 18
		public int RUDP_SENT_BYTES;

		// Token: 0x04000013 RID: 19
		public int RUDP_RCVD_BYTES;

		// Token: 0x04000014 RID: 20
		public int RUDP_SENT_PACKETS;

		// Token: 0x04000015 RID: 21
		public int RUDP_RCVD_PACKETS;

		// Token: 0x04000016 RID: 22
		public int RUDP_TOTAL_RESEND_BYTES;

		// Token: 0x04000017 RID: 23
		public int RUDP_TOTAL_RESEND_PACKETS;

		// Token: 0x04000018 RID: 24
		public int RUDP_TOTAL_RESEND_TIMES;

		// Token: 0x04000019 RID: 25
		public int RUDP_TOTAL_REACK_TIMES;

		// Token: 0x0400001A RID: 26
		public int RUDP_MAX_RESEND_TIMES;

		// Token: 0x0400001B RID: 27
		public long RUDP_MAX_SENT_PACKET_TIME;

		// Token: 0x0400001C RID: 28
		public long RUDP_TOTAL_SENT_PACKET_TIME;

		// Token: 0x0400001D RID: 29
		public int RUDP_RCVD_DUPLICATED_PACKET_TIMES;

		// Token: 0x0400001E RID: 30
		private long StartTick;

		// Token: 0x0400001F RID: 31
		private long EndTick;
	}
}
