using System;

namespace Motorola.Common.Communication.CommonFile
{
	// Token: 0x02000008 RID: 8
	internal class CompressFrangment
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002610 File Offset: 0x00000810
		public byte headVersion
		{
			private get
			{
				return this._headVersion;
			}
			set
			{
				this._headVersion = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002619 File Offset: 0x00000819
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002621 File Offset: 0x00000821
		public byte algorithmAndLevel
		{
			get
			{
				return this._algorithmAndLevel;
			}
			set
			{
				this._algorithmAndLevel = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000262A File Offset: 0x0000082A
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002632 File Offset: 0x00000832
		public int compressSize
		{
			get
			{
				return this._compressSize;
			}
			set
			{
				this._compressSize = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000263B File Offset: 0x0000083B
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002643 File Offset: 0x00000843
		public int uncompressSize
		{
			get
			{
				return this._uncompressSize;
			}
			set
			{
				this._uncompressSize = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000264C File Offset: 0x0000084C
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002654 File Offset: 0x00000854
		public byte[] compressData
		{
			get
			{
				return this._compressData;
			}
			set
			{
				this._compressData = value;
			}
		}

		// Token: 0x04000019 RID: 25
		private byte _headVersion;

		// Token: 0x0400001A RID: 26
		private byte _algorithmAndLevel;

		// Token: 0x0400001B RID: 27
		private int _compressSize;

		// Token: 0x0400001C RID: 28
		private int _uncompressSize;

		// Token: 0x0400001D RID: 29
		private byte[] _compressData;
	}
}
