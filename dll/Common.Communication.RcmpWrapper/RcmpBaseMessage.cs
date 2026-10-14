using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000002 RID: 2
	public abstract class RcmpBaseMessage : global::Motorola.Common.Communication.BaseMessage
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		protected ushort Opcode
		{
			get
			{
				return this._opcode;
			}
			set
			{
				this._opcode = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020E1 File Offset: 0x000002E1
		// (set) Token: 0x06000004 RID: 4 RVA: 0x000020E9 File Offset: 0x000002E9
		public global::Motorola.Common.Communication.RcmpReplyResult ReplyResult
		{
			get
			{
				return this.m_ReplyResult;
			}
			protected set
			{
				this.m_ReplyResult = value;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020F2 File Offset: 0x000002F2
		public override int BuildCommandMessage(byte[] sendBuffer)
		{
			return this.BuildCommandMessage(sendBuffer, 0);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020FC File Offset: 0x000002FC
		public virtual int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				this.Opcode
			});
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002126 File Offset: 0x00000326
		public virtual ushort CalculateMessageCRC16(ref uint checksum, byte[] inputData, int start, int length)
		{
			return global::Motorola.Common.Communication.RcmpBaseMessage.CalculateCRC16(ref checksum, inputData, start, length);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002134 File Offset: 0x00000334
		public static ushort CalculateCRC16(ref uint workspace, byte[] inputData, int start, int length)
		{
			for (int i = start; i < start + length; i++)
			{
				workspace = ((uint)global::Motorola.Common.Communication.RcmpBaseMessage.crc16_data_table[(int)((global::System.UIntPtr)((workspace >> 8 ^ (uint)inputData[i]) & 255U))] ^ workspace << 8);
			}
			return (ushort)workspace;
		}

		// Token: 0x04000001 RID: 1
		private ushort _opcode;

		// Token: 0x04000002 RID: 2
		private global::Motorola.Common.Communication.RcmpReplyResult m_ReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Undefined;

		// Token: 0x04000003 RID: 3
		private static readonly ushort[] crc16_data_table = new ushort[]
		{
			0,
			4129,
			8258,
			12387,
			16516,
			20645,
			24774,
			28903,
			33032,
			37161,
			41290,
			45419,
			49548,
			53677,
			57806,
			61935,
			4657,
			528,
			12915,
			8786,
			21173,
			17044,
			29431,
			25302,
			37689,
			33560,
			45947,
			41818,
			54205,
			50076,
			62463,
			58334,
			9314,
			13379,
			1056,
			5121,
			25830,
			29895,
			17572,
			21637,
			42346,
			46411,
			34088,
			38153,
			58862,
			62927,
			50604,
			54669,
			13907,
			9842,
			5649,
			1584,
			30423,
			26358,
			22165,
			18100,
			46939,
			42874,
			38681,
			34616,
			63455,
			59390,
			55197,
			51132,
			18628,
			22757,
			26758,
			30887,
			2112,
			6241,
			10242,
			14371,
			51660,
			55789,
			59790,
			63919,
			35144,
			39273,
			43274,
			47403,
			23285,
			19156,
			31415,
			27286,
			6769,
			2640,
			14899,
			10770,
			56317,
			52188,
			64447,
			60318,
			39801,
			35672,
			47931,
			43802,
			27814,
			31879,
			19684,
			23749,
			11298,
			15363,
			3168,
			7233,
			60846,
			64911,
			52716,
			56781,
			44330,
			48395,
			36200,
			40265,
			32407,
			28342,
			24277,
			20212,
			15891,
			11826,
			7761,
			3696,
			65439,
			61374,
			57309,
			53244,
			48923,
			44858,
			40793,
			36728,
			37256,
			33193,
			45514,
			41451,
			53516,
			49453,
			61774,
			57711,
			4224,
			161,
			12482,
			8419,
			20484,
			16421,
			28742,
			24679,
			33721,
			37784,
			41979,
			46042,
			49981,
			54044,
			58239,
			62302,
			689,
			4752,
			8947,
			13010,
			16949,
			21012,
			25207,
			29270,
			46570,
			42443,
			38312,
			34185,
			62830,
			58703,
			54572,
			50445,
			13538,
			9411,
			5280,
			1153,
			29798,
			25671,
			21540,
			17413,
			42971,
			47098,
			34713,
			38840,
			59231,
			63358,
			50973,
			55100,
			9939,
			14066,
			1681,
			5808,
			26199,
			30326,
			17941,
			22068,
			55628,
			51565,
			63758,
			59695,
			39368,
			35305,
			47498,
			43435,
			22596,
			18533,
			30726,
			26663,
			6336,
			2273,
			14466,
			10403,
			52093,
			56156,
			60223,
			64286,
			35833,
			39896,
			43963,
			48026,
			19061,
			23124,
			27191,
			31254,
			2801,
			6864,
			10931,
			14994,
			64814,
			60687,
			56684,
			52557,
			48554,
			44427,
			40424,
			36297,
			31782,
			27655,
			23652,
			19525,
			15522,
			11395,
			7392,
			3265,
			61215,
			65342,
			53085,
			57212,
			44955,
			49082,
			36825,
			40952,
			28183,
			32310,
			20053,
			24180,
			11923,
			16050,
			3793,
			7920
		};
	}
}
