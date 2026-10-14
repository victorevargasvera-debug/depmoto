using System;
using System.Collections.Generic;
using System.Text;

namespace SSLMangrComp.Packets
{
	// Token: 0x0200002F RID: 47
	public class Notify : global::SSLMangrComp.Packets.PacketBase
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000071C4 File Offset: 0x000053C4
		// (set) Token: 0x06000165 RID: 357 RVA: 0x000071CC File Offset: 0x000053CC
		public byte[] Data { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000071D5 File Offset: 0x000053D5
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000071DD File Offset: 0x000053DD
		public ushort MessageLength { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000071E6 File Offset: 0x000053E6
		// (set) Token: 0x06000169 RID: 361 RVA: 0x000071EE File Offset: 0x000053EE
		public uint Expires { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000071F7 File Offset: 0x000053F7
		// (set) Token: 0x0600016B RID: 363 RVA: 0x000071FF File Offset: 0x000053FF
		public global::SSLMangrComp.Packets.SubscriptionState SubscriptionState { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00007208 File Offset: 0x00005408
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00007210 File Offset: 0x00005410
		public global::SSLMangrComp.Packets.EntitiesTypes EntityType { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00007219 File Offset: 0x00005419
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00007221 File Offset: 0x00005421
		public string Entities { get; set; }

		// Token: 0x06000170 RID: 368 RVA: 0x0000722A File Offset: 0x0000542A
		public void AddAtribute(global::SSLMangrComp.Packets.NotifyAttribute a)
		{
			this.attributes.Add(a);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00007238 File Offset: 0x00005438
		public Notify(byte[] data, ushort lengthbytes)
		{
			if (lengthbytes != 0 && lengthbytes != 2)
			{
				throw new global::System.ArgumentException("Invalid lengthbytes!!!");
			}
			if (lengthbytes == 0)
			{
				this.MessageLength = 0;
			}
			else
			{
				this.MessageLength = global::System.BitConverter.ToUInt16(data, 0);
			}
			this.Data = data;
			base.MessageID = data[(int)lengthbytes];
			base.DialogID = global::System.BitConverter.ToUInt16(data, (int)(lengthbytes + 1));
			int i = (int)(lengthbytes + 3);
			bool flag = false;
			while (i < data.Length)
			{
				byte b = data[i];
				switch (b)
				{
				case 1:
				{
					long num = 0L;
					for (int j = 0; j < (int)data[i + 1]; j++)
					{
						num += (long)((ulong)data[i + 2 + j] * (ulong)((long)global::System.Math.Pow(2.0, (double)(j * 8))));
					}
					this.Expires = (uint)num;
					i += (int)(data[i + 1] + 2);
					continue;
				}
				case 2:
				{
					int count = (int)data[i + 1];
					this.Event = global::System.Text.Encoding.Unicode.GetString(data, i + 2, count);
					i += (int)(data[i + 1] + 2);
					continue;
				}
				case 3:
					this.SubscriptionState = (global::SSLMangrComp.Packets.SubscriptionState)data[i + 2];
					i += 3;
					continue;
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
					goto IL_1B8;
				case 10:
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
					break;
				default:
					if (b != 29)
					{
						goto IL_1B8;
					}
					break;
				}
				if (!flag && data[i] != 14)
				{
					this.EntityType = (global::SSLMangrComp.Packets.EntitiesTypes)data[i];
					int count2 = (int)data[i + 1];
					this.Entities = global::System.Text.Encoding.Unicode.GetString(data, i + 2, count2);
					flag = true;
					continue;
				}
				global::SSLMangrComp.Packets.NotifyAttribute notifyAttribute = new global::SSLMangrComp.Packets.NotifyAttribute();
				notifyAttribute.AttributeType = (global::SSLMangrComp.Packets.AttributeTypes)data[i];
				int count3 = (int)data[i + 1];
				notifyAttribute.Attribute = global::System.Text.Encoding.Unicode.GetString(data, i + 2, count3);
				this.AddAtribute(notifyAttribute);
				i += (int)(data[i + 1] + 2);
				continue;
				IL_1B8:
				throw new global::System.ArgumentException("Invalid packet!!!");
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00007411 File Offset: 0x00005611
		// (set) Token: 0x06000173 RID: 371 RVA: 0x0000741C File Offset: 0x0000561C
		public string Event
		{
			get
			{
				return this.ev;
			}
			set
			{
				if (value != null)
				{
					if (value == "0")
					{
						this.ev = "Ack";
						return;
					}
					if (value == "1")
					{
						this.ev = "Present";
						return;
					}
					if (value == "2")
					{
						this.ev = "Absent";
						return;
					}
				}
				this.ev = value;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00007482 File Offset: 0x00005682
		public override byte[] getData()
		{
			return this.Data;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000748A File Offset: 0x0000568A
		public override string getPacketDescription()
		{
			if (this.MessageLength != 0)
			{
				return "Reliable Notify Message";
			}
			return "Unreliable Notify Message";
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000074A0 File Offset: 0x000056A0
		public override string[,] GetAllParameters()
		{
			int num = 5 + (string.IsNullOrEmpty(this.Event) ? 0 : 1) + ((this.EntityType > global::SSLMangrComp.Packets.EntitiesTypes.Unknown) ? 2 : 0) + this.attributes.Count;
			if (this.MessageLength != 0)
			{
				num++;
			}
			string[,] array = new string[num, 2];
			int num2 = 0;
			if (this.MessageLength != 0)
			{
				array[num2, 0] = "Message Length";
				array[num2++, 1] = this.MessageLength.ToString();
			}
			array[num2, 0] = "Message ID";
			array[num2++, 1] = this.m_messageID.ToString();
			array[num2, 0] = "Dialog ID";
			array[num2++, 1] = this.m_dialogID.ToString();
			array[num2, 0] = "Expires (seconds)";
			array[num2++, 1] = this.Expires.ToString();
			array[num2, 0] = "Reliable ";
			array[num2++, 1] = (this.m_messageID != 2).ToString();
			array[num2, 0] = "Subscription State";
			array[num2++, 1] = this.SubscriptionState.ToString();
			if (this.EntityType > global::SSLMangrComp.Packets.EntitiesTypes.Unknown)
			{
				array[num2, 0] = "Entity Type";
				array[num2++, 1] = this.EntityType.ToString();
				array[num2, 0] = "Entity";
				array[num2++, 1] = this.Entities;
			}
			if (!string.IsNullOrEmpty(this.Event))
			{
				array[num2, 0] = "Event";
				array[num2++, 1] = this.Event;
			}
			foreach (global::SSLMangrComp.Packets.NotifyAttribute notifyAttribute in this.attributes)
			{
				array[num2, 0] = "Attribute(" + notifyAttribute.AttributeType.ToString() + ")";
				array[num2++, 1] = notifyAttribute.Attribute;
			}
			return array;
		}

		// Token: 0x040000EE RID: 238
		private global::System.Collections.Generic.List<global::SSLMangrComp.Packets.NotifyAttribute> attributes = new global::System.Collections.Generic.List<global::SSLMangrComp.Packets.NotifyAttribute>();

		// Token: 0x040000EF RID: 239
		public string ev;
	}
}
