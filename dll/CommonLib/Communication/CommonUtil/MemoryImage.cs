using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000026 RID: 38
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class MemoryImage : global::System.Collections.IEnumerable
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00004590 File Offset: 0x00002790
		public void AddItem(global::Motorola.Common.Communication.CommonUtil.IMemoryUnit unit)
		{
			lock (this._unitList)
			{
				if (unit != null)
				{
					if (this.IsOverlaped(unit))
					{
						this._isGood = false;
					}
					else
					{
						this._unitList.Add(unit);
						this._needCompact = true;
					}
				}
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000045F4 File Offset: 0x000027F4
		public int DeleteItem(global::Motorola.Common.Communication.CommonUtil.IMemoryUnit unit)
		{
			int result;
			lock (this._unitList)
			{
				int num = 0;
				if (unit == null)
				{
					result = num;
				}
				else
				{
					for (int num2 = this.LookForUnit(unit); num2 != -1; num2 = this.LookForUnit(unit))
					{
						this._unitList.RemoveAt(num2);
						num++;
					}
					this._needCompact = true;
					result = num;
				}
			}
			return result;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000466C File Offset: 0x0000286C
		public void RemoveAt(int index)
		{
			lock (this._unitList)
			{
				this._unitList.RemoveAt(index);
				this._needCompact = false;
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000046BC File Offset: 0x000028BC
		public void RemoveAll()
		{
			lock (this._unitList)
			{
				this._unitList.Clear();
				this._needCompact = false;
			}
		}

		// Token: 0x1700005E RID: 94
		public global::Motorola.Common.Communication.CommonUtil.IMemoryUnit this[int index]
		{
			get
			{
				global::Motorola.Common.Communication.CommonUtil.IMemoryUnit result;
				lock (this._unitList)
				{
					result = this._unitList[index];
				}
				return result;
			}
			set
			{
				lock (this._unitList)
				{
					this._unitList[index] = value;
				}
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004798 File Offset: 0x00002998
		public bool IsGood()
		{
			bool isGood;
			lock (this._unitList)
			{
				isGood = this._isGood;
			}
			return isGood;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000047DC File Offset: 0x000029DC
		public void CompactUnits()
		{
			try
			{
				lock (this._unitList)
				{
					if (this._needCompact)
					{
						if (this.IsGood())
						{
							if (this._unitList.Count > 1)
							{
								if (this._unitList[0] is global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit)
								{
									uint num = uint.MaxValue;
									uint num2 = uint.MaxValue;
									int num3 = 0;
									int num4 = 0;
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit>();
									for (int i = 0; i < this._unitList.Count; i++)
									{
										global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = this._unitList[i] as global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit;
										num4 = i;
										if (num == 4294967295U && num2 == 4294967295U)
										{
											num = global::System.Convert.ToUInt32(flashMemoryUnit.Address, global::System.Globalization.CultureInfo.InvariantCulture);
											num2 = global::System.Convert.ToUInt32(flashMemoryUnit.Address, global::System.Globalization.CultureInfo.InvariantCulture) + flashMemoryUnit.Size - 1U;
											num3 = i;
										}
										else if ((ulong)(num2 + 1U) == (ulong)((long)global::System.Convert.ToInt32(flashMemoryUnit.Address, global::System.Globalization.CultureInfo.InvariantCulture)))
										{
											num2 = global::System.Convert.ToUInt32(flashMemoryUnit.Address, global::System.Globalization.CultureInfo.InvariantCulture) + flashMemoryUnit.Size - 1U;
										}
										else
										{
											byte[] array = new byte[num2 - num + 1U];
											int num5 = 0;
											int num6 = num4 - 1;
											for (int j = num3; j <= num6; j++)
											{
												global::System.Array.Copy(this._unitList[j].Data, 0L, array, (long)num5, (long)((ulong)this._unitList[j].Size));
												num5 += (int)this._unitList[j].Size;
											}
											global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit2 = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
											flashMemoryUnit2.ChargeUnit(num.ToString(global::System.Globalization.CultureInfo.InvariantCulture), array);
											list.Add(flashMemoryUnit2);
											num = global::System.Convert.ToUInt32(flashMemoryUnit.Address, global::System.Globalization.CultureInfo.InvariantCulture);
											num2 = global::System.Convert.ToUInt32(flashMemoryUnit.Address, global::System.Globalization.CultureInfo.InvariantCulture) + flashMemoryUnit.Size - 1U;
											num3 = i;
										}
									}
									if (num != 4294967295U && num2 != 4294967295U)
									{
										byte[] array2 = new byte[num2 - num + 1U];
										int num7 = 0;
										int num8 = num4;
										for (int k = num3; k <= num8; k++)
										{
											global::System.Array.Copy(this._unitList[k].Data, 0L, array2, (long)num7, (long)((ulong)this._unitList[k].Size));
											num7 += (int)this._unitList[k].Size;
										}
										global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit3 = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
										flashMemoryUnit3.ChargeUnit(num.ToString(global::System.Globalization.CultureInfo.InvariantCulture), array2);
										list.Add(flashMemoryUnit3);
									}
									if (list.Count != 0)
									{
										this._unitList.Clear();
										this._unitList = list;
									}
								}
							}
						}
					}
				}
			}
			finally
			{
				this._needCompact = false;
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004ACC File Offset: 0x00002CCC
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.MemoryImage result;
			lock (this._unitList)
			{
				if (!this.IsGood())
				{
					result = null;
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
					foreach (global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit in this._unitList)
					{
						memoryImage.AddItem(memoryUnit.Clone());
					}
					result = memoryImage;
				}
			}
			return result;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004B68 File Offset: 0x00002D68
		public bool GetData(uint addr, uint size, out byte[] buffer)
		{
			bool result;
			lock (this._unitList)
			{
				global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit = null;
				int i;
				for (i = 0; i < this._unitList.Count; i++)
				{
					memoryUnit = this._unitList[i];
					if (addr >= global::System.Convert.ToUInt32(memoryUnit.Address, global::System.Globalization.CultureInfo.InvariantCulture) && addr + size <= global::System.Convert.ToUInt32(memoryUnit.Address, global::System.Globalization.CultureInfo.InvariantCulture) + memoryUnit.Size)
					{
						break;
					}
				}
				if (i < this._unitList.Count)
				{
					result = memoryUnit.GetData(addr, size, out buffer);
				}
				else
				{
					buffer = null;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00004C1C File Offset: 0x00002E1C
		public static global::Motorola.Common.Communication.CommonUtil.MemoryImage Add(global::Motorola.Common.Communication.CommonUtil.MemoryImage x, global::Motorola.Common.Communication.CommonUtil.MemoryImage y)
		{
			global::Motorola.Common.Communication.CommonUtil.MemoryImage memoryImage = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
			if (x != null)
			{
				for (int i = 0; i < x._unitList.Count; i++)
				{
					memoryImage.AddItem(x._unitList[i].Clone());
				}
			}
			if (y != null)
			{
				for (int j = 0; j < y._unitList.Count; j++)
				{
					memoryImage.AddItem(y._unitList[j].Clone());
				}
			}
			if (memoryImage.IsGood())
			{
				return memoryImage;
			}
			return null;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00004C9C File Offset: 0x00002E9C
		public int Count
		{
			get
			{
				int count;
				lock (this._unitList)
				{
					count = this._unitList.Count;
				}
				return count;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00004CE4 File Offset: 0x00002EE4
		public uint Size
		{
			get
			{
				uint result;
				lock (this._unitList)
				{
					uint num = 0U;
					for (int i = 0; i < this._unitList.Count; i++)
					{
						num += this._unitList[i].Size;
					}
					result = num;
				}
				return result;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004D50 File Offset: 0x00002F50
		private int LookForUnit(global::Motorola.Common.Communication.CommonUtil.IMemoryUnit unit)
		{
			int result;
			lock (this._unitList)
			{
				int num = -1;
				if (unit == null)
				{
					result = num;
				}
				else
				{
					for (int i = 0; i < this._unitList.Count; i++)
					{
						global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit = this._unitList[i];
						if (memoryUnit.Address == unit.Address && memoryUnit.Size == memoryUnit.Size)
						{
							num = i;
							break;
						}
					}
					result = num;
				}
			}
			return result;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004DE4 File Offset: 0x00002FE4
		private bool IsOverlaped(global::Motorola.Common.Communication.CommonUtil.IMemoryUnit unit)
		{
			bool result = false;
			for (int i = 0; i < this._unitList.Count - 1; i++)
			{
				global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit = this._unitList[i];
				if (memoryUnit.IsOverlaped(unit))
				{
					result = true;
					break;
				}
			}
			this._needCompact = true;
			return result;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004E2D File Offset: 0x0000302D
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._unitList.GetEnumerator();
		}

		// Token: 0x04000111 RID: 273
		[global::System.Runtime.Serialization.DataMember]
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit> _unitList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IMemoryUnit>();

		// Token: 0x04000112 RID: 274
		[global::System.Runtime.Serialization.DataMember]
		private bool _needCompact = true;

		// Token: 0x04000113 RID: 275
		[global::System.Runtime.Serialization.DataMember]
		private bool _isGood = true;
	}
}
