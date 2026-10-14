using System;
using System.Threading;
using Motorola.Common.Communication.RUDP.Helper;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000019 RID: 25
	internal class RUDPPacket : global::Motorola.Common.Communication.RUDP.Helper.ObjectSerializer
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00005E8C File Offset: 0x0000408C
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00005E94 File Offset: 0x00004094
		private int LAST_SENT_TIMES
		{
			get
			{
				return this._LAST_SENT_TIMES;
			}
			set
			{
				this._LAST_SENT_TIMES = value;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00005EA0 File Offset: 0x000040A0
		public RUDPPacket(bool syn)
		{
			this.payloadHandshake.initialize_RUDP_PL_HANDSHAKE_DATA_SECTION(global::Motorola.Common.Communication.RUDP.HandshakeContent.SYN_WITH_SESSION_PARAMS);
			this.IsSYNPacket = syn;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00005EFC File Offset: 0x000040FC
		public override object[] GetObjectList()
		{
			object[] result;
			if (this.payLoad != null)
			{
				result = new object[]
				{
					this.packetHeader,
					this.payLoad
				};
			}
			else
			{
				result = new object[]
				{
					this.packetHeader
				};
			}
			return result;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00005F41 File Offset: 0x00004141
		public override void SetObjectList(object[] list)
		{
			this.packetHeader = (global::Motorola.Common.Communication.RUDP.RUDPPacketHeader)list[0];
			if (list.Length == 2)
			{
				this.payLoad = (global::Motorola.Common.Communication.RUDP.RUDPPayload)list[1];
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00005F68 File Offset: 0x00004168
		public override int Deserialize(byte[] buffer, int start, int len)
		{
			int num = this.packetHeader.Deserialize(buffer, start, len);
			if (this.packetHeader.SYN)
			{
				this.IsSYNPacket = true;
			}
			else if (this.packetHeader.ACK && len > (int)global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_LEN)
			{
				this.IsSYNPacket = false;
			}
			else
			{
				this.ClearPayload();
			}
			if (this.payLoad != null)
			{
				num += this.payLoad.Deserialize(buffer, start + num, len - num);
			}
			return num;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00005FDC File Offset: 0x000041DC
		public global::Motorola.Common.Communication.RUDP.RUDPACKFlags PacketType
		{
			get
			{
				global::Motorola.Common.Communication.RUDP.RUDPACKFlags result = global::Motorola.Common.Communication.RUDP.RUDPACKFlags.ERR;
				if (this.Header.SYN)
				{
					if (this.Header.RST || this.Header.NUL || this.Header.FRG)
					{
						return result;
					}
					if (this.Header.ACK)
					{
						result = global::Motorola.Common.Communication.RUDP.RUDPACKFlags.SYN_ACK;
					}
					else
					{
						result = global::Motorola.Common.Communication.RUDP.RUDPACKFlags.SYN;
					}
				}
				else if (this.Header.RST)
				{
					if (this.Header.SYN || this.Header.NUL || this.Header.FRG)
					{
						return result;
					}
					if (this.Header.ACK)
					{
						result = global::Motorola.Common.Communication.RUDP.RUDPACKFlags.RST_ACK;
					}
					else
					{
						result = global::Motorola.Common.Communication.RUDP.RUDPACKFlags.RST;
					}
				}
				else if (this.Header.NUL)
				{
					if (this.Header.SYN || this.Header.RST || this.Header.FRG)
					{
						return result;
					}
					if (this.Header.ACK)
					{
						result = global::Motorola.Common.Communication.RUDP.RUDPACKFlags.NUL_ACK;
					}
					else
					{
						result = global::Motorola.Common.Communication.RUDP.RUDPACKFlags.NUL;
					}
				}
				else
				{
					if (!this.Header.ACK)
					{
						return result;
					}
					if (this.PacketLength == (ushort)global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_LEN && this.Header.FRG)
					{
						return result;
					}
					if (this.PacketLength == (ushort)global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_LEN)
					{
						result = global::Motorola.Common.Communication.RUDP.RUDPACKFlags.ACK;
					}
					else if (this.PacketLength > (ushort)global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_LEN)
					{
						result = global::Motorola.Common.Communication.RUDP.RUDPACKFlags.DATA;
					}
				}
				return result;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00006124 File Offset: 0x00004324
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000612C File Offset: 0x0000432C
		public global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket UserDataPacket
		{
			private get
			{
				return this.userDataPacket;
			}
			set
			{
				this.userDataPacket = value;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00006135 File Offset: 0x00004335
		public void SetTransmissionFailed()
		{
			this.IsObsoletedPacket = true;
			if (this.userDataPacket != null)
			{
				this.userDataPacket.IsObsoletedPacket = true;
				this.userDataPacket.SetTransmissionFailed();
				return;
			}
			this.blockingSendEvent.Set();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000616A File Offset: 0x0000436A
		public void SetTransmissionCompleted()
		{
			if (this.userDataPacket != null)
			{
				this.userDataPacket.CheckForSendCompleted();
				return;
			}
			this.blockingSendEvent.Set();
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000618C File Offset: 0x0000438C
		// (set) Token: 0x0600011A RID: 282 RVA: 0x000061A8 File Offset: 0x000043A8
		public byte[] Data
		{
			get
			{
				if (this.bSYNPacket)
				{
					return null;
				}
				return (this.payLoad as global::Motorola.Common.Communication.RUDP.RUDP_PL_DATA_SECTION).Data;
			}
			private set
			{
				if (!this.bSYNPacket)
				{
					(this.payLoad as global::Motorola.Common.Communication.RUDP.RUDP_PL_DATA_SECTION).Data = value;
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000061C4 File Offset: 0x000043C4
		public ushort PacketLength
		{
			get
			{
				int num = (int)global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HEADER_LEN;
				if (this.payLoad != null)
				{
					num += (int)this.Payload.PayloadLen;
				}
				return (ushort)num;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000061EF File Offset: 0x000043EF
		public bool IsFragmentEnd
		{
			get
			{
				return !this.Header.FRG;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000061FF File Offset: 0x000043FF
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00006207 File Offset: 0x00004407
		public bool IsACKed
		{
			get
			{
				return this.isACKed;
			}
			set
			{
				this.isACKed = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00006210 File Offset: 0x00004410
		public global::Motorola.Common.Communication.RUDP.RUDPPacketHeader Header
		{
			get
			{
				return this.packetHeader;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00006218 File Offset: 0x00004418
		private global::Motorola.Common.Communication.RUDP.RUDPPayload Payload
		{
			get
			{
				return this.payLoad;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00006220 File Offset: 0x00004420
		public global::Motorola.Common.Communication.RUDP.RUDP_PL_HANDSHAKE_DATA_SECTION PayloadHandshake
		{
			get
			{
				return this.payloadHandshake;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00006228 File Offset: 0x00004428
		public global::Motorola.Common.Communication.RUDP.RUDP_PL_DATA_SECTION PayloadData
		{
			get
			{
				return this.payloadData;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00006230 File Offset: 0x00004430
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00006238 File Offset: 0x00004438
		public bool IsSYNPacket
		{
			private get
			{
				return this.bSYNPacket;
			}
			set
			{
				this.bSYNPacket = value;
				if (this.bSYNPacket)
				{
					this.payLoad = this.payloadHandshake;
					return;
				}
				this.payLoad = this.payloadData;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00006262 File Offset: 0x00004462
		public bool IsACKPacket
		{
			get
			{
				return this.Header.ACK;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000626F File Offset: 0x0000446F
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00006277 File Offset: 0x00004477
		public long InitSendTime
		{
			get
			{
				return this.initSendTime;
			}
			set
			{
				this.initSendTime = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00006280 File Offset: 0x00004480
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00006288 File Offset: 0x00004488
		public long LastSendTime
		{
			get
			{
				return this.lastSendTime;
			}
			set
			{
				this.lastSendTime = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00006291 File Offset: 0x00004491
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00006299 File Offset: 0x00004499
		public int RetriedTimes
		{
			get
			{
				return this.retriedTimes;
			}
			set
			{
				this.retriedTimes = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000062A2 File Offset: 0x000044A2
		// (set) Token: 0x0600012D RID: 301 RVA: 0x000062AA File Offset: 0x000044AA
		public long ReceivedTime
		{
			get
			{
				return this.receivedTime;
			}
			set
			{
				this.receivedTime = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000062B3 File Offset: 0x000044B3
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000062BB File Offset: 0x000044BB
		public bool IsObsoletedPacket
		{
			get
			{
				return this.obsoletedPacket;
			}
			set
			{
				this.obsoletedPacket = value;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000062C4 File Offset: 0x000044C4
		public void WaitACK()
		{
			this.blockingSendEvent.WaitOne();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000062D2 File Offset: 0x000044D2
		public void ClearPayload()
		{
			this.payLoad = null;
		}

		// Token: 0x040000BA RID: 186
		private int _LAST_SENT_TIMES;

		// Token: 0x040000BB RID: 187
		private global::Motorola.Common.Communication.RUDP.RUDPPacketHeader packetHeader = new global::Motorola.Common.Communication.RUDP.RUDPPacketHeader();

		// Token: 0x040000BC RID: 188
		private global::Motorola.Common.Communication.RUDP.RUDPPayload payLoad;

		// Token: 0x040000BD RID: 189
		private global::Motorola.Common.Communication.RUDP.RUDP_PL_HANDSHAKE_DATA_SECTION payloadHandshake = new global::Motorola.Common.Communication.RUDP.RUDP_PL_HANDSHAKE_DATA_SECTION();

		// Token: 0x040000BE RID: 190
		private global::Motorola.Common.Communication.RUDP.RUDP_PL_DATA_SECTION payloadData = new global::Motorola.Common.Communication.RUDP.RUDP_PL_DATA_SECTION();

		// Token: 0x040000BF RID: 191
		private global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket userDataPacket;

		// Token: 0x040000C0 RID: 192
		private bool bSYNPacket = true;

		// Token: 0x040000C1 RID: 193
		private bool isACKed;

		// Token: 0x040000C2 RID: 194
		private int retriedTimes;

		// Token: 0x040000C3 RID: 195
		private long initSendTime;

		// Token: 0x040000C4 RID: 196
		private long lastSendTime;

		// Token: 0x040000C5 RID: 197
		private long receivedTime;

		// Token: 0x040000C6 RID: 198
		private bool obsoletedPacket;

		// Token: 0x040000C7 RID: 199
		private global::System.Threading.ManualResetEvent blockingSendEvent = new global::System.Threading.ManualResetEvent(false);
	}
}
