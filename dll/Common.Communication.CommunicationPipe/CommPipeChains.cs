using System;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000002 RID: 2
	public class CommPipeChains : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		private protected global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe _lowerTransport
		{
			protected get
			{
				return this.lowerTransport;
			}
			private set
			{
				this.lowerTransport = value;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E1 File Offset: 0x000002E1
		public CommPipeChains(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport)
		{
			this._lowerTransport = transport;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020F0 File Offset: 0x000002F0
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000020F8 File Offset: 0x000002F8
		public int ReceiveTimeout { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002101 File Offset: 0x00000301
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002109 File Offset: 0x00000309
		public bool IsOpen { get; set; }

		// Token: 0x06000008 RID: 8 RVA: 0x00002112 File Offset: 0x00000312
		public virtual void OpenPort(int timeout)
		{
			if (this._lowerTransport != null)
			{
				this._lowerTransport.OpenPort(timeout);
				this.IsOpen = true;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000212F File Offset: 0x0000032F
		public virtual void ClosePort()
		{
			if (this._lowerTransport != null)
			{
				this._lowerTransport.ClosePort();
				this.IsOpen = false;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000214B File Offset: 0x0000034B
		public virtual void SendData(byte[] buffer, int start, int length)
		{
			if (this._lowerTransport != null)
			{
				this._lowerTransport.SendData(buffer, start, length);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002163 File Offset: 0x00000363
		public virtual byte[] ReceiveData()
		{
			if (this._lowerTransport != null)
			{
				return this._lowerTransport.ReceiveData();
			}
			return null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000217A File Offset: 0x0000037A
		public virtual byte[] ReceiveData(int timeout)
		{
			if (this._lowerTransport != null)
			{
				return this._lowerTransport.ReceiveData(timeout);
			}
			return null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002192 File Offset: 0x00000392
		public virtual int ReceiveData(byte[] buffer, int start)
		{
			if (this._lowerTransport != null)
			{
				return this._lowerTransport.ReceiveData(buffer, start);
			}
			return 0;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021AB File Offset: 0x000003AB
		public virtual int ReceiveData(byte[] buffer, int start, int timeout)
		{
			if (this._lowerTransport != null)
			{
				return this._lowerTransport.ReceiveData(buffer, start, timeout);
			}
			return 0;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021C5 File Offset: 0x000003C5
		public virtual int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			if (this._lowerTransport != null)
			{
				return this._lowerTransport.ReceiveData(buffer, start, timeout);
			}
			return 0;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021DF File Offset: 0x000003DF
		public virtual byte[] RequestData(byte[] buffer, int start, int length)
		{
			if (this._lowerTransport != null)
			{
				return this._lowerTransport.RequestData(buffer, start, length);
			}
			return null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021F9 File Offset: 0x000003F9
		public virtual byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			if (this._lowerTransport != null)
			{
				return this._lowerTransport.RequestData(buffer, start, length, timeout);
			}
			return null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002215 File Offset: 0x00000415
		public virtual byte[] PeekData(int length, int timeOut)
		{
			if (this._lowerTransport != null)
			{
				return this._lowerTransport.PeekData(length, timeOut);
			}
			return null;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000222E File Offset: 0x0000042E
		public virtual int AvailableReadBytesCount
		{
			get
			{
				if (this._lowerTransport != null)
				{
					return this._lowerTransport.AvailableReadBytesCount;
				}
				return 0;
			}
		}

		// Token: 0x04000001 RID: 1
		private global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe lowerTransport;
	}
}
