using System;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x0200001E RID: 30
	internal class MessageBuffer
	{
		// Token: 0x17000016 RID: 22
		private byte this[int i]
		{
			get
			{
				byte result;
				lock (this.buff)
				{
					if (i >= this.Length)
					{
						throw new global::System.ApplicationException("Attempt to reach out outside of the buffer");
					}
					if (i + this.sp < this.maxlen)
					{
						result = this.buff[i + this.sp];
					}
					else
					{
						result = this.buff[i + this.sp - this.maxlen];
					}
				}
				return result;
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000599C File Offset: 0x00003B9C
		public MessageBuffer(int maxlen)
		{
			this.maxlen = maxlen;
			this.buff = new byte[maxlen];
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000059B8 File Offset: 0x00003BB8
		public void Add(byte[] msgPart, int length)
		{
			if (msgPart == null || msgPart.Length < length || length < 1)
			{
				return;
			}
			lock (this.buff)
			{
				if (this.maxlen + this.sp - this.ep < length)
				{
					throw new global::System.ApplicationException("Message won't fit in buffer.");
				}
				global::System.Array.Copy(msgPart, 0, this.buff, this.ep, (this.maxlen - this.ep > length) ? length : (this.maxlen - this.ep));
				if (this.maxlen - this.ep < length)
				{
					global::System.Array.Copy(msgPart, this.maxlen - this.ep, this.buff, 0, length - (this.maxlen - this.ep));
				}
				this.ep = (this.ep + length) % this.maxlen;
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005AA4 File Offset: 0x00003CA4
		public void Add(byte[] msgPart)
		{
			this.Add(msgPart, msgPart.Length);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005AB0 File Offset: 0x00003CB0
		private int Length
		{
			get
			{
				int result;
				lock (this.buff)
				{
					if (this.ep < this.sp)
					{
						result = this.ep + (this.maxlen - this.sp);
					}
					else
					{
						result = this.ep - this.sp;
					}
				}
				return result;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005B20 File Offset: 0x00003D20
		private byte[] Peek(int size)
		{
			byte[] array = null;
			lock (this.buff)
			{
				if (size > this.Length)
				{
					return null;
				}
				array = new byte[size];
				global::System.Array.Copy(this.buff, this.sp, array, 0, (this.sp + size > this.maxlen) ? (this.maxlen - this.sp) : size);
				if (this.sp + size > this.maxlen)
				{
					int length = size - (this.maxlen - this.sp);
					global::System.Array.Copy(this.buff, 0, array, this.maxlen - this.sp, length);
				}
			}
			return array;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005BE8 File Offset: 0x00003DE8
		private byte[] Get(int size)
		{
			byte[] result;
			lock (this.buff)
			{
				if (size > this.Length)
				{
					throw new global::System.ApplicationException("not enough data in the buffer");
				}
				byte[] array = new byte[size];
				global::System.Array.Copy(this.buff, this.sp, array, 0, (this.sp + size > this.maxlen) ? (this.maxlen - this.sp) : size);
				if (this.sp + size > this.maxlen)
				{
					int length = size - (this.maxlen - this.sp);
					global::System.Array.Copy(this.buff, 0, array, this.maxlen - this.sp, length);
					this.sp = length;
				}
				else
				{
					this.sp += size;
					this.sp %= this.maxlen;
				}
				result = array;
			}
			return result;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005CDC File Offset: 0x00003EDC
		public byte[] GetReliableNotifyMessage()
		{
			byte[] result;
			lock (this.buff)
			{
				if (this.Length < 6)
				{
					result = null;
				}
				else
				{
					ushort num = global::System.BitConverter.ToUInt16(this.Peek(2), 0);
					if (this.Length < (int)(num + 2))
					{
						result = null;
					}
					else
					{
						result = this.Get((int)(num + 2));
					}
				}
			}
			return result;
		}

		// Token: 0x04000079 RID: 121
		private int maxlen;

		// Token: 0x0400007A RID: 122
		private int sp;

		// Token: 0x0400007B RID: 123
		private int ep;

		// Token: 0x0400007C RID: 124
		protected byte[] buff;
	}
}
