using System;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000012 RID: 18
	public class ConnectivityParams
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00005D3F File Offset: 0x00003F3F
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00005D47 File Offset: 0x00003F47
		public int OpenTimeout
		{
			get
			{
				return this.open_timeout;
			}
			set
			{
				this.open_timeout = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00005D50 File Offset: 0x00003F50
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00005D58 File Offset: 0x00003F58
		public int CloseTimeout
		{
			get
			{
				return this.close_timeout;
			}
			set
			{
				this.close_timeout = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00005D61 File Offset: 0x00003F61
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00005D69 File Offset: 0x00003F69
		public int SendTimeout
		{
			get
			{
				return this.send_timeout;
			}
			set
			{
				this.send_timeout = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00005D72 File Offset: 0x00003F72
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00005D7A File Offset: 0x00003F7A
		public int ReceiveTimeout
		{
			get
			{
				return this.receive_timeout;
			}
			set
			{
				this.receive_timeout = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00005D83 File Offset: 0x00003F83
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00005D8B File Offset: 0x00003F8B
		public int MaxBufferPoolSize
		{
			get
			{
				return this.max_buffer_pool_size;
			}
			set
			{
				this.max_buffer_pool_size = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00005D94 File Offset: 0x00003F94
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00005D9C File Offset: 0x00003F9C
		public int MaxBufferSize
		{
			get
			{
				return this.max_buffer_size;
			}
			set
			{
				this.max_buffer_size = value;
			}
		}

		// Token: 0x0400007E RID: 126
		private int open_timeout;

		// Token: 0x0400007F RID: 127
		private int close_timeout;

		// Token: 0x04000080 RID: 128
		private int send_timeout;

		// Token: 0x04000081 RID: 129
		private int receive_timeout;

		// Token: 0x04000082 RID: 130
		private int max_buffer_pool_size;

		// Token: 0x04000083 RID: 131
		private int max_buffer_size;
	}
}
