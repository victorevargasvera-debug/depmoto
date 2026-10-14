using System;
using System.Collections;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x0200004C RID: 76
	internal class RamDataObjectInfo
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00016838 File Offset: 0x00014A38
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00016850 File Offset: 0x00014A50
		public uint RamAddress
		{
			get
			{
				return this.ramAddress;
			}
			private set
			{
				this.ramAddress = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0001685C File Offset: 0x00014A5C
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00016874 File Offset: 0x00014A74
		public int NumBytes
		{
			get
			{
				return this.numBytes;
			}
			private set
			{
				this.numBytes = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00016880 File Offset: 0x00014A80
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00016898 File Offset: 0x00014A98
		public uint FlashAddress
		{
			get
			{
				return this.flashAddress;
			}
			private set
			{
				this.flashAddress = value;
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000168A2 File Offset: 0x00014AA2
		private RamDataObjectInfo()
		{
			this.ramAddress = 0U;
			this.numBytes = 0;
			this.flashAddress = 0U;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000168C2 File Offset: 0x00014AC2
		public RamDataObjectInfo(uint ramAddress, int numOfBytes, uint flashAddress)
		{
			this.ramAddress = ramAddress;
			this.numBytes = numOfBytes;
			this.flashAddress = flashAddress;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000168E4 File Offset: 0x00014AE4
		public static uint[] ConvertToUintArray(global::System.Collections.ArrayList item)
		{
			return item.ToArray(typeof(uint)) as uint[];
		}

		// Token: 0x04000189 RID: 393
		private uint ramAddress;

		// Token: 0x0400018A RID: 394
		private int numBytes;

		// Token: 0x0400018B RID: 395
		private uint flashAddress;
	}
}
