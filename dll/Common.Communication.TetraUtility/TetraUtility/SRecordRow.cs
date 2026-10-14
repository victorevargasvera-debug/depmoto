using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000072 RID: 114
	public class SRecordRow
	{
		// Token: 0x060002BB RID: 699 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
		public SRecordRow()
		{
			this._rowType = global::Motorola.Common.Communication.TetraUtility.S19Type.S_DATA;
			this._address = 0U;
			this._length = 0U;
			this._data = null;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000DC00 File Offset: 0x0000BE00
		public global::Motorola.Common.Communication.TetraUtility.S19Type RowType
		{
			get
			{
				return this._rowType;
			}
			set
			{
				this._rowType = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000DC09 File Offset: 0x0000BE09
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000DC11 File Offset: 0x0000BE11
		public uint Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000DC1A File Offset: 0x0000BE1A
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0000DC22 File Offset: 0x0000BE22
		public uint Length
		{
			get
			{
				return this._length;
			}
			set
			{
				this._length = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000DC2B File Offset: 0x0000BE2B
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0000DC33 File Offset: 0x0000BE33
		public byte[] Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}

		// Token: 0x0400031A RID: 794
		public const int Max_SRecord_Len = 256;

		// Token: 0x0400031B RID: 795
		public const uint Default_Max_SRecord_Len = 28U;

		// Token: 0x0400031C RID: 796
		private global::Motorola.Common.Communication.TetraUtility.S19Type _rowType;

		// Token: 0x0400031D RID: 797
		private uint _address;

		// Token: 0x0400031E RID: 798
		private uint _length;

		// Token: 0x0400031F RID: 799
		private byte[] _data;
	}
}
