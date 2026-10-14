using System;
using System.IO;
using System.Text;

namespace SSLMangrComp.Packets
{
	// Token: 0x0200002C RID: 44
	public abstract class PacketBase
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00006FC7 File Offset: 0x000051C7
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00006FCF File Offset: 0x000051CF
		public global::SSLMangrComp.Packets.SubscriptionType Type { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00006FD8 File Offset: 0x000051D8
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00006FE0 File Offset: 0x000051E0
		public bool IsPacketRecived
		{
			get
			{
				return this.m_isPacketRecived;
			}
			set
			{
				this.m_isPacketRecived = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00006FE9 File Offset: 0x000051E9
		public global::System.DateTime PacketDataTime
		{
			get
			{
				return this.m_dateTime;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00006FF1 File Offset: 0x000051F1
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00006FF9 File Offset: 0x000051F9
		public byte MessageID
		{
			get
			{
				return this.m_messageID;
			}
			set
			{
				this.m_messageID = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00007002 File Offset: 0x00005202
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0000700A File Offset: 0x0000520A
		public ushort DialogID
		{
			get
			{
				return this.m_dialogID;
			}
			set
			{
				this.m_dialogID = value;
			}
		}

		// Token: 0x06000157 RID: 343
		public abstract byte[] getData();

		// Token: 0x06000158 RID: 344
		public abstract string getPacketDescription();

		// Token: 0x06000159 RID: 345
		public abstract string[,] GetAllParameters();

		// Token: 0x0600015A RID: 346 RVA: 0x00007013 File Offset: 0x00005213
		protected void EncodeTLV(global::System.IO.MemoryStream msgBuffer, byte tag, byte objValue)
		{
			msgBuffer.WriteByte(tag);
			msgBuffer.WriteByte(1);
			msgBuffer.WriteByte(objValue);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000702A File Offset: 0x0000522A
		protected void EncodeTLV(global::System.IO.MemoryStream msgBuffer, byte tag, byte[] objValue)
		{
			msgBuffer.WriteByte(tag);
			msgBuffer.WriteByte(global::System.Convert.ToByte(objValue.Length));
			msgBuffer.Write(objValue, 0, objValue.Length);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000704C File Offset: 0x0000524C
		protected void EncodeTLV(global::System.IO.MemoryStream msgBuffer, byte tag, string objValue)
		{
			global::System.Text.UnicodeEncoding unicodeEncoding = new global::System.Text.UnicodeEncoding(false, true);
			msgBuffer.WriteByte(tag);
			msgBuffer.WriteByte(global::System.Convert.ToByte(unicodeEncoding.GetByteCount(objValue)));
			byte[] bytes = unicodeEncoding.GetBytes(objValue);
			msgBuffer.Write(bytes, 0, bytes.Length);
		}

		// Token: 0x040000E6 RID: 230
		private bool m_isPacketRecived = true;

		// Token: 0x040000E7 RID: 231
		protected global::System.DateTime m_dateTime = global::System.DateTime.Now;

		// Token: 0x040000E8 RID: 232
		protected byte m_messageID;

		// Token: 0x040000E9 RID: 233
		protected ushort m_dialogID;
	}
}
