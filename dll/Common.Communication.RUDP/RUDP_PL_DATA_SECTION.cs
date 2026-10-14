using System;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200001E RID: 30
	internal class RUDP_PL_DATA_SECTION : global::Motorola.Common.Communication.RUDP.RUDPPayload
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000066D4 File Offset: 0x000048D4
		// (set) Token: 0x0600015E RID: 350 RVA: 0x000066DC File Offset: 0x000048DC
		private byte[] _data
		{
			get
			{
				return this.data;
			}
			set
			{
				this.data = value;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000066E8 File Offset: 0x000048E8
		public override object[] GetObjectList()
		{
			return new object[]
			{
				this._data
			};
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00006708 File Offset: 0x00004908
		public override void SetObjectList(object[] list)
		{
			this._data = (byte[])list[0];
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00006718 File Offset: 0x00004918
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00006720 File Offset: 0x00004920
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00006729 File Offset: 0x00004929
		public override byte PayloadLen
		{
			get
			{
				if (this._data != null)
				{
					base.PayloadLen = (byte)this._data.Length;
				}
				return base.PayloadLen;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00006748 File Offset: 0x00004948
		public RUDP_PL_DATA_SECTION()
		{
			if (this._data != null)
			{
				base.PayloadLen = (byte)this._data.Length;
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00006773 File Offset: 0x00004973
		private RUDP_PL_DATA_SECTION(byte[] data)
		{
			this._data = data;
			base.PayloadLen = (byte)this._data.Length;
		}

		// Token: 0x040000D6 RID: 214
		private byte[] data = new byte[0];
	}
}
