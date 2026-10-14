using System;
using System.Runtime.InteropServices;

namespace custom_datatypes
{
	// Token: 0x02000010 RID: 16
	public struct MLEPeer
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000015B8 File Offset: 0x000009B8
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000015CC File Offset: 0x000009CC
		public uint ID
		{
			get
			{
				return this.<backing_store>ID;
			}
			set
			{
				this.<backing_store>ID = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000015E0 File Offset: 0x000009E0
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000015F4 File Offset: 0x000009F4
		public string SerialNumber
		{
			get
			{
				return this.<backing_store>SerialNumber;
			}
			set
			{
				this.<backing_store>SerialNumber = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00001608 File Offset: 0x00000A08
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000161C File Offset: 0x00000A1C
		public string IP
		{
			get
			{
				return this.<backing_store>IP;
			}
			set
			{
				this.<backing_store>IP = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00001630 File Offset: 0x00000A30
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00001644 File Offset: 0x00000A44
		public ushort Port
		{
			get
			{
				return this.<backing_store>Port;
			}
			set
			{
				this.<backing_store>Port = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00001658 File Offset: 0x00000A58
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000166C File Offset: 0x00000A6C
		public bool Master
		{
			[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
			get
			{
				return this.<backing_store>Master;
			}
			[param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
			set
			{
				this.<backing_store>Master = value;
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00001680 File Offset: 0x00000A80
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00001694 File Offset: 0x00000A94
		public uint VoterID
		{
			get
			{
				return this.<backing_store>VoterID;
			}
			set
			{
				this.<backing_store>VoterID = value;
			}
		}

		// Token: 0x04000091 RID: 145
		private uint <backing_store>ID;

		// Token: 0x04000092 RID: 146
		private string <backing_store>SerialNumber;

		// Token: 0x04000093 RID: 147
		private string <backing_store>IP;

		// Token: 0x04000094 RID: 148
		private ushort <backing_store>Port;

		// Token: 0x04000095 RID: 149
		private bool <backing_store>Master;

		// Token: 0x04000096 RID: 150
		private uint <backing_store>VoterID;
	}
}
