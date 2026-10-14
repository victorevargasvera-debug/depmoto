using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.FDT
{
	// Token: 0x02000009 RID: 9
	public class FDTUnit
	{
		// Token: 0x06000042 RID: 66 RVA: 0x0000358C File Offset: 0x0000178C
		public FDTUnit()
		{
			this.FdtType = global::Motorola.Common.Communication.CommonUtil.FDTType.FDT_FDT;
			this.State = global::Motorola.Common.Communication.FDT.FDTState.FDT_UNINITIAL;
			this.ModelType = 0;
			this.CPVersion = "0000";
			this.Version = "0000";
			this._reserved = new byte[32];
			global::System.Array.Clear(this._reserved, 0, this._reserved.Length);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000035EB File Offset: 0x000017EB
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000035F3 File Offset: 0x000017F3
		public global::Motorola.Common.Communication.CommonUtil.FDTType FdtType { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000035FC File Offset: 0x000017FC
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00003604 File Offset: 0x00001804
		public global::Motorola.Common.Communication.FDT.FDTState State { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000360D File Offset: 0x0000180D
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00003615 File Offset: 0x00001815
		public ushort ModelType { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000361E File Offset: 0x0000181E
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00003626 File Offset: 0x00001826
		public string CPVersion { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000362F File Offset: 0x0000182F
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00003637 File Offset: 0x00001837
		public string Version { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003640 File Offset: 0x00001840
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00003648 File Offset: 0x00001848
		public uint StartAddress { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003651 File Offset: 0x00001851
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00003659 File Offset: 0x00001859
		public uint Size { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00003664 File Offset: 0x00001864
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000036A4 File Offset: 0x000018A4
		public byte[] Reserved
		{
			get
			{
				byte[] reserved;
				lock (this)
				{
					reserved = this._reserved;
				}
				return reserved;
			}
			set
			{
				lock (this)
				{
					global::System.Array.Clear(this._reserved, 0, this._reserved.Length);
					global::System.Array.Copy(value, 0, this._reserved, 0, global::System.Math.Min(this._reserved.Length, value.Length));
				}
			}
		}

		// Token: 0x0400002C RID: 44
		public const int FDT_RESERVED_SIZE = 32;

		// Token: 0x0400002D RID: 45
		public const string FDT_DEFAULT_VERSION = "0001";

		// Token: 0x0400002E RID: 46
		private byte[] _reserved;
	}
}
