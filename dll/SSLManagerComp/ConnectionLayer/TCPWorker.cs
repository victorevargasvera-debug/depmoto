using System;
using System.Net.Sockets;
using IACustomException;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x0200000D RID: 13
	public class TCPWorker : global::SSLMangrComp.ConnectionLayer.IServerWorker
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000054 RID: 84 RVA: 0x00003450 File Offset: 0x00001650
		// (remove) Token: 0x06000055 RID: 85 RVA: 0x00003488 File Offset: 0x00001688
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle ReadPacketReceived;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000056 RID: 86 RVA: 0x000034C0 File Offset: 0x000016C0
		// (remove) Token: 0x06000057 RID: 87 RVA: 0x000034F8 File Offset: 0x000016F8
		public event global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle ErrorReceived;

		// Token: 0x06000058 RID: 88 RVA: 0x0000352D File Offset: 0x0000172D
		public TCPWorker(global::System.Net.Sockets.TcpClient client)
		{
			this.tcpClient = client;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000353C File Offset: 0x0000173C
		public void Read()
		{
			global::SSLMangrComp.ErrorReport error = default(global::SSLMangrComp.ErrorReport);
			string str = base.GetType().ToString();
			str += ":Read";
			byte[] array = new byte[1024];
			global::SSLMangrComp.ConnectionLayer.MessageBuffer messageBuffer = new global::SSLMangrComp.ConnectionLayer.MessageBuffer(2048);
			int num = 10000;
			global::System.Net.Sockets.NetworkStream stream = this.tcpClient.GetStream();
			try
			{
				num = 10000;
				while (num > 0 && !this.signalClose)
				{
					try
					{
						num = stream.Read(array, 0, array.Length);
					}
					catch (global::System.Exception)
					{
						break;
					}
					if (num <= 0)
					{
						break;
					}
					messageBuffer.Add(array, num);
					byte[] reliableNotifyMessage;
					while ((reliableNotifyMessage = messageBuffer.GetReliableNotifyMessage()) != null)
					{
						if (this.ReadPacketReceived != null)
						{
							global::SSLMangrComp.Packets.PacketBase packet = global::SSLMangrComp.Packets.PacketFactory.GetPacket(reliableNotifyMessage, 2);
							packet.IsPacketRecived = true;
							this.ReadPacketReceived(packet);
						}
					}
				}
				stream.Close();
				this.tcpClient.Close();
			}
			catch (global::IACustomException.IACommonException)
			{
				error.ErrCat = 300U;
				error.ErrorID = 1070U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
				stream.Close();
				this.tcpClient.Close();
			}
			catch (global::System.Exception)
			{
				error.ErrCat = 300U;
				error.ErrorID = 1070U;
				if (this.ErrorReceived != null)
				{
					this.ErrorReceived(error);
				}
				stream.Close();
				this.tcpClient.Close();
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000036C4 File Offset: 0x000018C4
		public void Close()
		{
			if (this.tcpClient != null)
			{
				if (this.tcpClient.Connected && this.tcpClient.Available > 0)
				{
					this.signalClose = true;
					return;
				}
				if (this.tcpClient.Connected)
				{
					this.tcpClient.GetStream().Close();
				}
			}
		}

		// Token: 0x04000027 RID: 39
		public global::System.Net.Sockets.TcpClient tcpClient;

		// Token: 0x0400002A RID: 42
		private bool signalClose;
	}
}
