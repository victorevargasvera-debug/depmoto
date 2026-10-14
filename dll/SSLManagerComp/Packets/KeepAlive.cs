using System;

namespace SSLMangrComp.Packets
{
	// Token: 0x0200002D RID: 45
	public class KeepAlive : global::SSLMangrComp.Packets.PacketBase
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000070A7 File Offset: 0x000052A7
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000070B6 File Offset: 0x000052B6
		public global::SSLMangrComp.Packets.KeepAliveType T
		{
			get
			{
				if (this.m_messageID != 10)
				{
					return global::SSLMangrComp.Packets.KeepAliveType.Ack;
				}
				return global::SSLMangrComp.Packets.KeepAliveType.Request;
			}
			set
			{
				this.m_messageID = ((value == global::SSLMangrComp.Packets.KeepAliveType.Request) ? 10 : 11);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000070C8 File Offset: 0x000052C8
		public override byte[] getData()
		{
			return new byte[]
			{
				this.m_messageID,
				(byte)(this.m_dialogID % 256),
				(byte)((this.m_dialogID - this.m_dialogID % 256) / 256)
			};
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00007113 File Offset: 0x00005313
		public override string getPacketDescription()
		{
			return "KeepAlive " + this.T.ToString();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00007130 File Offset: 0x00005330
		public override string[,] GetAllParameters()
		{
			string[,] array = new string[3, 2];
			int num = 0;
			array[num, 0] = "Message ID";
			array[num++, 1] = this.m_messageID.ToString();
			array[num, 0] = "Dialog ID";
			string[,] array2 = array;
			int num2 = num++;
			int num3 = 1;
			uint dialogID = (uint)this.m_dialogID;
			array2[num2, num3] = dialogID.ToString();
			array[num, 0] = "Type";
			array[num++, 1] = this.T.ToString();
			return array;
		}
	}
}
