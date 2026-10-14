using System;
using Motorola.Common.Communication.RUDP.Helper;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000009 RID: 9
	internal class RUDPPacketHeader : global::Motorola.Common.Communication.RUDP.Helper.ObjectSerializer
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000386E File Offset: 0x00001A6E
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000387F File Offset: 0x00001A7F
		public bool SYN
		{
			get
			{
				return (this.PacketFlags & global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_SYN_MASK) > 0;
			}
			set
			{
				this.SetFlagBit(value, global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_SYN_MASK);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000388D File Offset: 0x00001A8D
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0000389E File Offset: 0x00001A9E
		public bool ACK
		{
			get
			{
				return (this.PacketFlags & global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_ACK_MASK) > 0;
			}
			set
			{
				this.SetFlagBit(value, global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_ACK_MASK);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000038AC File Offset: 0x00001AAC
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000038BD File Offset: 0x00001ABD
		public bool EAK
		{
			private get
			{
				return (this.PacketFlags & global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_EAK_MASK) > 0;
			}
			set
			{
				this.SetFlagBit(value, global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_EAK_MASK);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000038CB File Offset: 0x00001ACB
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000038DC File Offset: 0x00001ADC
		public bool RST
		{
			get
			{
				return (this.PacketFlags & global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_RST_MASK) > 0;
			}
			set
			{
				this.SetFlagBit(value, global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_RST_MASK);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000038EA File Offset: 0x00001AEA
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000038FB File Offset: 0x00001AFB
		public bool NUL
		{
			get
			{
				return (this.PacketFlags & global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_NUL_MASK) > 0;
			}
			set
			{
				this.SetFlagBit(value, global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_NUL_MASK);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00003909 File Offset: 0x00001B09
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000391A File Offset: 0x00001B1A
		public bool FRG
		{
			get
			{
				return (this.PacketFlags & global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_FRG_MASK) > 0;
			}
			set
			{
				this.SetFlagBit(value, global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_FRG_MASK);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003928 File Offset: 0x00001B28
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00003938 File Offset: 0x00001B38
		public byte VER
		{
			private get
			{
				return this.PacketFlags & global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_VER_MASK;
			}
			set
			{
				byte b = ~global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_HD_VER_MASK;
				this.PacketFlags &= b;
				this.PacketFlags += value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000396B File Offset: 0x00001B6B
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00003973 File Offset: 0x00001B73
		private byte PacketFlags
		{
			get
			{
				return this._PacketFlags;
			}
			set
			{
				this._PacketFlags = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000397C File Offset: 0x00001B7C
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00003984 File Offset: 0x00001B84
		public byte HeaderLength { private get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000398D File Offset: 0x00001B8D
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00003995 File Offset: 0x00001B95
		public ushort SequenceNumber { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000399E File Offset: 0x00001B9E
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000039A6 File Offset: 0x00001BA6
		public ushort AcknowledgementNumber { get; set; }

		// Token: 0x06000091 RID: 145 RVA: 0x000039B0 File Offset: 0x00001BB0
		public override object[] GetObjectList()
		{
			return new object[]
			{
				this.PacketFlags,
				this.HeaderLength,
				this.SequenceNumber,
				this.AcknowledgementNumber
			};
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000039FF File Offset: 0x00001BFF
		public override void SetObjectList(object[] list)
		{
			this.PacketFlags = (byte)list[0];
			this.HeaderLength = (byte)list[1];
			this.SequenceNumber = (ushort)list[2];
			this.AcknowledgementNumber = (ushort)list[3];
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003A3C File Offset: 0x00001C3C
		private void SetFlagBit(bool value, byte mask)
		{
			byte packetFlags = this.PacketFlags;
			global::Motorola.Common.Communication.RUDP.Helper.RUDPUtility.CombindFlag(ref packetFlags, value, mask);
			this.PacketFlags = packetFlags;
		}

		// Token: 0x04000043 RID: 67
		private byte _PacketFlags;
	}
}
