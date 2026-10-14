using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000021 RID: 33
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class FlashMemoryUnit : global::Motorola.Common.Communication.CommonUtil.IMemoryUnit
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00003E08 File Offset: 0x00002008
		public string Address
		{
			get
			{
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0:D13}", new object[]
				{
					this._address
				});
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00003E3A File Offset: 0x0000203A
		public uint Size
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00003E42 File Offset: 0x00002042
		public byte[] Data
		{
			get
			{
				return this._data;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003E4C File Offset: 0x0000204C
		public void ChargeUnit(string address, byte[] data, byte stuff, uint alignment)
		{
			this.Reset();
			this._stuff = stuff;
			this._alignment = alignment;
			if (data == null)
			{
				return;
			}
			try
			{
				this._address = (uint)global::System.Convert.ToInt32(address, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			catch
			{
				this.Reset();
				return;
			}
			this._size = (uint)data.Length;
			uint num = 0U;
			if (this._alignment != 0U)
			{
				num = (this._alignment - this._address % this._alignment) % this._alignment;
			}
			this._size += num;
			this._address -= num;
			uint num2 = 0U;
			if (this._alignment != 0U)
			{
				num2 = (this._alignment - this._size % this._alignment) % this._alignment;
			}
			this._size += num2;
			this._data = new byte[this._size];
			int num3 = 0;
			while ((long)num3 < (long)((ulong)num))
			{
				this._data[num3] = this._stuff;
				num3++;
			}
			global::System.Array.Copy(data, 0L, this._data, (long)((ulong)num), (long)data.Length);
			for (uint num4 = this._size - num2; num4 < this._size; num4 += 1U)
			{
				this._data[(int)((global::System.UIntPtr)num4)] = this._stuff;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003F8C File Offset: 0x0000218C
		public void ChargeUnit(string address, byte[] data)
		{
			this.ChargeUnit(address, data, byte.MaxValue, 2U);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003F9C File Offset: 0x0000219C
		public bool IsOverlaped(global::Motorola.Common.Communication.CommonUtil.IMemoryUnit otherUnit)
		{
			bool result = false;
			if (otherUnit == null)
			{
				return result;
			}
			if (otherUnit.GetType() != base.GetType())
			{
				return true;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			return this.IsOverlaped(global::System.Convert.ToInt32(this.Address, global::System.Globalization.CultureInfo.InvariantCulture), (int)this.Size, global::System.Convert.ToInt32(otherUnit.Address, global::System.Globalization.CultureInfo.InvariantCulture), (int)otherUnit.Size, out num, out num2, out num3) && !this.IsDataCanBeOverWritten(this.Data, (long)num, otherUnit.Data, (long)num2, (long)num3);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004028 File Offset: 0x00002228
		public global::Motorola.Common.Communication.CommonUtil.IMemoryUnit Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
			flashMemoryUnit._address = this._address;
			flashMemoryUnit._size = this._size;
			flashMemoryUnit._stuff = this._stuff;
			flashMemoryUnit._alignment = this._alignment;
			flashMemoryUnit._data = new byte[this._data.Length];
			global::System.Array.Copy(this._data, flashMemoryUnit._data, (long)((ulong)flashMemoryUnit._size));
			return flashMemoryUnit;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004098 File Offset: 0x00002298
		public bool GetData(uint addr, uint size, out byte[] buffer)
		{
			if (addr < this._address || addr + size > this._address + this._size)
			{
				buffer = null;
				return false;
			}
			buffer = new byte[size];
			global::System.Array.Copy(this._data, (long)((ulong)(addr - this._address)), buffer, 0L, (long)((ulong)size));
			return true;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000040EC File Offset: 0x000022EC
		private bool IsDataCanBeOverWritten(byte[] srcData, long srcStartIdx, byte[] destData, long destStartIdx, long count)
		{
			int num = 0;
			while ((long)num < count)
			{
				if (!checked(global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit.IsByteCanBeOverWritten(srcData[(int)((global::System.IntPtr)(unchecked(srcStartIdx + (long)num)))], destData[(int)((global::System.IntPtr)(unchecked(destStartIdx + (long)num)))])))
				{
					return false;
				}
				num++;
			}
			return true;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004120 File Offset: 0x00002320
		private static bool IsByteCanBeOverWritten(byte bySrc, byte byDst)
		{
			byte b = 1;
			while ((bySrc & b) != 0 || (byDst & b) == 0)
			{
				if ((b = (byte)(b << 1)) <= 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004145 File Offset: 0x00002345
		private void Reset()
		{
			this._address = 0U;
			this._size = 0U;
			this._data = null;
			this._stuff = byte.MaxValue;
			this._alignment = 2U;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004170 File Offset: 0x00002370
		private bool IsOverlaped(int startAddr1, int size1, int startAddr2, int size2, out int overlappedOffset1, out int overlappedOffset2, out int overlappedSize)
		{
			overlappedOffset1 = 0;
			overlappedOffset2 = 0;
			overlappedSize = 0;
			int val = startAddr1 + size1;
			int val2 = startAddr2 + size2;
			int num = global::System.Math.Max(startAddr1, startAddr2);
			int num2 = global::System.Math.Min(val, val2);
			overlappedOffset1 = global::System.Math.Abs(startAddr1 - num);
			overlappedOffset2 = global::System.Math.Abs(startAddr2 - num);
			overlappedSize = num2 - num;
			return num <= num2;
		}

		// Token: 0x040000EE RID: 238
		[global::System.Runtime.Serialization.DataMember]
		private uint _address;

		// Token: 0x040000EF RID: 239
		[global::System.Runtime.Serialization.DataMember]
		private uint _size;

		// Token: 0x040000F0 RID: 240
		[global::System.Runtime.Serialization.DataMember]
		private byte[] _data;

		// Token: 0x040000F1 RID: 241
		[global::System.Runtime.Serialization.DataMember]
		private byte _stuff = byte.MaxValue;

		// Token: 0x040000F2 RID: 242
		[global::System.Runtime.Serialization.DataMember]
		private uint _alignment = 2U;
	}
}
