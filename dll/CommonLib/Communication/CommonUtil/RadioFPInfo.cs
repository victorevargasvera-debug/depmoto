using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200003D RID: 61
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class RadioFPInfo
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00006859 File Offset: 0x00004A59
		public RadioFPInfo()
		{
			this._emptySlots = new global::System.Collections.Generic.List<uint>();
			this._radioInfo = new global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader>();
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00006877 File Offset: 0x00004A77
		public bool AddSlots(uint emptyslot)
		{
			if (emptyslot == 0U)
			{
				return false;
			}
			if (!this._emptySlots.Contains(emptyslot))
			{
				this._emptySlots.Add(emptyslot);
				this._emptySlots.Sort();
				return true;
			}
			return false;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000068A8 File Offset: 0x00004AA8
		public bool AddRadioFPInfo(uint address, global::Motorola.Common.Communication.CommonUtil.PackHeader pack)
		{
			if (address == 0U || pack == null)
			{
				return false;
			}
			bool result;
			lock (this._radioInfo)
			{
				if (!this._radioInfo.ContainsKey(address))
				{
					this._radioInfo.Add(address, pack);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000690C File Offset: 0x00004B0C
		public void UpdateRadioFPInfo(uint oldAddr, uint newAddress, global::Motorola.Common.Communication.CommonUtil.PackHeader pack)
		{
			lock (this._radioInfo)
			{
				if (this._radioInfo.ContainsKey(oldAddr))
				{
					this._radioInfo.Remove(oldAddr);
				}
				if (!this._radioInfo.ContainsKey(newAddress) && newAddress != 0U)
				{
					this._radioInfo.Add(newAddress, pack);
				}
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00006980 File Offset: 0x00004B80
		public void DeleteRadioFPInfo(uint address)
		{
			lock (this._radioInfo)
			{
				if (this._radioInfo.ContainsKey(address))
				{
					this._radioInfo.Remove(address);
				}
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000069D8 File Offset: 0x00004BD8
		public void DeleteEmptySlot(uint addr)
		{
			lock (this._emptySlots)
			{
				if (this._emptySlots.Contains(addr))
				{
					this._emptySlots.Remove(addr);
				}
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00006A30 File Offset: 0x00004C30
		public global::System.Collections.Generic.List<uint> EmptySlots
		{
			get
			{
				return this._emptySlots;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00006A38 File Offset: 0x00004C38
		public global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> RadioFlashPack
		{
			get
			{
				return this._radioInfo;
			}
		}

		// Token: 0x040001AA RID: 426
		private global::System.Collections.Generic.List<uint> _emptySlots;

		// Token: 0x040001AB RID: 427
		private global::System.Collections.Generic.Dictionary<uint, global::Motorola.Common.Communication.CommonUtil.PackHeader> _radioInfo;
	}
}
