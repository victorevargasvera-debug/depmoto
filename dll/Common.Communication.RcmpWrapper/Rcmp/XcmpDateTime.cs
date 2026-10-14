using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200006D RID: 109
	public class XcmpDateTime : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00007988 File Offset: 0x00005B88
		public XcmpDateTime(global::System.DateTime dt)
		{
			base.Opcode = 1074;
			global::System.TimeZone currentTimeZone = global::System.TimeZone.CurrentTimeZone;
			double totalMinutes = currentTimeZone.GetUtcOffset(dt).TotalMinutes;
			this.m_Function = 1;
			this.m_TimeSource = 0;
			this.m_TimeZoneOffset = (byte)(totalMinutes / 15.0);
			this.m_DateYearDay = (ushort)dt.DayOfYear;
			this.m_DateWeekDay = (byte)dt.DayOfWeek;
			int num = dt.Year - 1900;
			this.m_DateYear = (byte)num;
			this.m_DateMonth = (byte)dt.Month;
			this.m_DateMonth -= 1;
			this.m_DateDay = (byte)dt.Day;
			this.m_TimeHour = (byte)dt.Hour;
			this.m_TimeMin = (byte)dt.Minute;
			this.m_TimeSec = (byte)dt.Second;
			this.m_TimeMsec = (ushort)((byte)dt.Millisecond);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00007A74 File Offset: 0x00005C74
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Function,
				this.m_PeriodicUpdateTime,
				this.m_TimeSource,
				this.m_TimeMsec,
				this.m_TimeSec,
				this.m_TimeMin,
				this.m_TimeHour,
				this.m_DateDay,
				this.m_DateMonth,
				this.m_DateYear,
				this.m_DateDst,
				this.m_DateWeekDay,
				this.m_DateYearDay,
				this.m_TimeZoneOffset
			});
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00007B6C File Offset: 0x00005D6C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			this.m_Function = replyBuffer[offset + 3];
			this.m_PeriodicUpdateTime = replyBuffer[offset + 4];
			this.m_TimeSource = replyBuffer[offset + 5];
			this.m_TimeMsec = (ushort)((int)replyBuffer[offset + 6] | (int)replyBuffer[offset + 7] << 8);
			this.m_TimeSec = replyBuffer[offset + 8];
			this.m_TimeMin = replyBuffer[offset + 9];
			this.m_TimeHour = replyBuffer[offset + 10];
			this.m_DateDay = replyBuffer[offset + 11];
			this.m_DateMonth = replyBuffer[offset + 12];
			this.m_DateYear = replyBuffer[offset + 13];
			this.m_DateDst = replyBuffer[offset + 14];
			this.m_DateWeekDay = replyBuffer[offset + 15];
			this.m_DateYearDay = (ushort)((int)replyBuffer[offset + 16] | (int)replyBuffer[offset + 17] << 8);
			this.m_TimeZoneOffset = replyBuffer[offset + 18];
		}

		// Token: 0x04000222 RID: 546
		private byte m_Function;

		// Token: 0x04000223 RID: 547
		private byte m_PeriodicUpdateTime;

		// Token: 0x04000224 RID: 548
		private byte m_TimeSource;

		// Token: 0x04000225 RID: 549
		private ushort m_TimeMsec;

		// Token: 0x04000226 RID: 550
		private byte m_TimeSec;

		// Token: 0x04000227 RID: 551
		private byte m_TimeMin;

		// Token: 0x04000228 RID: 552
		private byte m_TimeHour;

		// Token: 0x04000229 RID: 553
		private byte m_DateDay;

		// Token: 0x0400022A RID: 554
		private byte m_DateMonth;

		// Token: 0x0400022B RID: 555
		private byte m_DateYear;

		// Token: 0x0400022C RID: 556
		private byte m_DateDst;

		// Token: 0x0400022D RID: 557
		private byte m_DateWeekDay;

		// Token: 0x0400022E RID: 558
		private ushort m_DateYearDay;

		// Token: 0x0400022F RID: 559
		private byte m_TimeZoneOffset;
	}
}
