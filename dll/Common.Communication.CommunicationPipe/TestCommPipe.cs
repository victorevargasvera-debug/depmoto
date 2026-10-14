using System;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x0200000F RID: 15
	public class TestCommPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00004012 File Offset: 0x00002212
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00004016 File Offset: 0x00002216
		public int ReceiveTimeout
		{
			get
			{
				return 10;
			}
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00004018 File Offset: 0x00002218
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00004020 File Offset: 0x00002220
		public bool IsOpen
		{
			get
			{
				return this.isOpen;
			}
			set
			{
				this.isOpen = value;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004029 File Offset: 0x00002229
		public void OpenPort(int timeout)
		{
			this.isOpen = true;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004032 File Offset: 0x00002232
		public void ClosePort()
		{
			this.isOpen = false;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000403B File Offset: 0x0000223B
		public void SendData(byte[] buffer, int start, int length)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000403D File Offset: 0x0000223D
		public byte[] ReceiveData()
		{
			return null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004040 File Offset: 0x00002240
		public byte[] ReceiveData(int timeout)
		{
			return null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004043 File Offset: 0x00002243
		public int ReceiveData(byte[] buffer, int start)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000404A File Offset: 0x0000224A
		public int ReceiveData(byte[] buffer, int start, int timeout)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004051 File Offset: 0x00002251
		public int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004058 File Offset: 0x00002258
		public byte[] RequestData(byte[] buffer, int start, int length)
		{
			return null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000405B File Offset: 0x0000225B
		public byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			return null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000405E File Offset: 0x0000225E
		public byte[] PeekData(int length, int timeOut)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00004065 File Offset: 0x00002265
		public int AvailableReadBytesCount
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x04000063 RID: 99
		private bool isOpen;
	}
}
