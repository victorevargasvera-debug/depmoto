using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace Motorola.Common.Communication.PCRRemoteProgramming
{
	// Token: 0x02000011 RID: 17
	public class TCPPortManager
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000033A5 File Offset: 0x000015A5
		public static global::Motorola.Common.Communication.PCRRemoteProgramming.TCPPortManager Instance
		{
			get
			{
				return global::Motorola.Common.Communication.PCRRemoteProgramming.TCPPortManager.instance;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000033AC File Offset: 0x000015AC
		private TCPPortManager()
		{
			this.MinPortNumber = 0;
			this.MaxPortNumber = 0;
			this.reserved = new global::System.Collections.Generic.List<int>();
			this.inUsed = new global::System.Collections.Generic.List<int>();
			this.syncPort = new object();
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000033E3 File Offset: 0x000015E3
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000033EB File Offset: 0x000015EB
		public int MinPortNumber { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000033F4 File Offset: 0x000015F4
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000033FC File Offset: 0x000015FC
		public int MaxPortNumber { get; set; }

		// Token: 0x06000043 RID: 67 RVA: 0x00003408 File Offset: 0x00001608
		public void Reserve(int port)
		{
			lock (this.syncPort)
			{
				if (!this.reserved.Contains(port))
				{
					this.reserved.Add(port);
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000345C File Offset: 0x0000165C
		public int GetAvailable()
		{
			global::System.Net.NetworkInformation.IPGlobalProperties ipglobalProperties = global::System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties();
			global::System.Net.IPEndPoint[] activeTcpListeners = ipglobalProperties.GetActiveTcpListeners();
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			if (activeTcpListeners != null)
			{
				foreach (global::System.Net.IPEndPoint ipendPoint in activeTcpListeners)
				{
					list.Add(ipendPoint.Port);
				}
			}
			lock (this.syncPort)
			{
				int num = (this.MinPortNumber < 0) ? 0 : this.MinPortNumber;
				int num2 = (this.MaxPortNumber > 65535) ? 65535 : this.MaxPortNumber;
				for (int j = num; j <= num2; j++)
				{
					if (!this.inUsed.Contains(j) && !list.Contains(j) && !this.reserved.Contains(j))
					{
						this.inUsed.Add(j);
						return j;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000355C File Offset: 0x0000175C
		public void Unreserve(int port)
		{
			lock (this.syncPort)
			{
				this.reserved.Remove(port);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000035A4 File Offset: 0x000017A4
		public void Release(int port)
		{
			lock (this.syncPort)
			{
				this.inUsed.Remove(port);
			}
		}

		// Token: 0x04000057 RID: 87
		private static global::Motorola.Common.Communication.PCRRemoteProgramming.TCPPortManager instance = new global::Motorola.Common.Communication.PCRRemoteProgramming.TCPPortManager();

		// Token: 0x04000058 RID: 88
		private global::System.Collections.Generic.List<int> reserved;

		// Token: 0x04000059 RID: 89
		private global::System.Collections.Generic.List<int> inUsed;

		// Token: 0x0400005A RID: 90
		private object syncPort;
	}
}
