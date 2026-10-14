using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000035 RID: 53
	[global::System.Runtime.Serialization.DataContract(Namespace = "http://www.motorola.com/Cps/Acp/Communication")]
	public class IshItemCollection : global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600018F RID: 399 RVA: 0x0000593B File Offset: 0x00003B3B
		public IshItemCollection(int initialCapacity)
		{
			this.m_IshItems = new global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>(initialCapacity);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000594F File Offset: 0x00003B4F
		public IshItemCollection() : this(0)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00005958 File Offset: 0x00003B58
		public global::Motorola.Common.Communication.CommonUtil.IshHeader AddHeader(byte partition, ushort ishType, ushort ishId)
		{
			global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, ishType, ishId);
			global::Motorola.Common.Communication.CommonUtil.IshItem value = default(global::Motorola.Common.Communication.CommonUtil.IshItem);
			value.ItemSize = -1;
			value.Data = null;
			value.Result = global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined;
			this.m_IshItems.Add(ishHeader, value);
			return ishHeader;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000059A4 File Offset: 0x00003BA4
		public global::Motorola.Common.Communication.CommonUtil.IshHeader AddItem(byte partition, ushort ishType, ushort ishId, int itemSize, byte[] data)
		{
			global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, ishType, ishId);
			global::Motorola.Common.Communication.CommonUtil.IshItem value = default(global::Motorola.Common.Communication.CommonUtil.IshItem);
			value.ItemSize = itemSize;
			value.Data = data;
			value.Result = global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined;
			this.m_IshItems.Add(ishHeader, value);
			return ishHeader;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000059EF File Offset: 0x00003BEF
		public void Add(global::Motorola.Common.Communication.CommonUtil.IshHeader headers, global::Motorola.Common.Communication.CommonUtil.IshItem item)
		{
			this.m_IshItems.Add(headers, item);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000059FE File Offset: 0x00003BFE
		public void Update(global::Motorola.Common.Communication.CommonUtil.IshHeader headers, global::Motorola.Common.Communication.CommonUtil.IshItem item)
		{
			this.m_IshItems[headers] = item;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00005A10 File Offset: 0x00003C10
		public void UpdateRange(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> ishPairs)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in ishPairs)
			{
				this.m_IshItems[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00005A6C File Offset: 0x00003C6C
		public void AddRange(global::Motorola.Common.Communication.CommonUtil.IshItemCollection itemCltn)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in itemCltn)
			{
				if (!this.ContainsHeader(keyValuePair.Key))
				{
					this.m_IshItems.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00005AD8 File Offset: 0x00003CD8
		public void RemoveRangeByIshName(global::Motorola.Common.Communication.CommonUtil.IshItemCollection itemCltn)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in itemCltn)
			{
				global::Motorola.Common.Communication.CommonUtil.IshHeader header = new global::Motorola.Common.Communication.CommonUtil.IshHeader(0, keyValuePair.Key.IshType, keyValuePair.Key.IshID);
				if (this.ContainsHeader(header))
				{
					this.Remove(header);
				}
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00005B54 File Offset: 0x00003D54
		public void ReplacePartition(byte originalPartID, byte replacePartID)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in this.m_IshItems)
			{
				if (keyValuePair.Key.PartitionNumber == originalPartID)
				{
					global::Motorola.Common.Communication.CommonUtil.IshHeader headers = new global::Motorola.Common.Communication.CommonUtil.IshHeader(replacePartID, keyValuePair.Key.IshType, keyValuePair.Key.IshID);
					ishItemCollection.Add(headers, keyValuePair.Value);
					list.Add(keyValuePair.Key);
				}
			}
			foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader header in list)
			{
				if (this.ContainsHeader(header))
				{
					this.Remove(header);
				}
			}
			this.AddRange(ishItemCollection);
		}

		// Token: 0x17000089 RID: 137
		public global::Motorola.Common.Communication.CommonUtil.IshItem this[byte partition, ushort ishType, ushort ishId]
		{
			get
			{
				global::Motorola.Common.Communication.CommonUtil.IshHeader key = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, ishType, ishId);
				return this[key];
			}
			set
			{
				global::Motorola.Common.Communication.CommonUtil.IshHeader key = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, ishType, ishId);
				this[key] = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00005C98 File Offset: 0x00003E98
		public int Count
		{
			get
			{
				return this.m_IshItems.Count;
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00005CA5 File Offset: 0x00003EA5
		public bool ContainsHeader(global::Motorola.Common.Communication.CommonUtil.IshHeader header)
		{
			return this.m_IshItems.ContainsKey(header);
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00005CB3 File Offset: 0x00003EB3
		public global::System.Collections.Generic.ICollection<global::Motorola.Common.Communication.CommonUtil.IshHeader> Headers
		{
			get
			{
				return this.m_IshItems.Keys;
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00005CC0 File Offset: 0x00003EC0
		public bool Remove(global::Motorola.Common.Communication.CommonUtil.IshHeader header)
		{
			return this.m_IshItems.Remove(header);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00005CD0 File Offset: 0x00003ED0
		public void RemoveAll(global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>, bool> condition)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in this.m_IshItems.Where(condition).ToList<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>())
			{
				this.m_IshItems.Remove(keyValuePair.Key);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00005D3C File Offset: 0x00003F3C
		public void Clear()
		{
			this.m_IshItems.Clear();
		}

		// Token: 0x1700008C RID: 140
		public global::Motorola.Common.Communication.CommonUtil.IshItem this[global::Motorola.Common.Communication.CommonUtil.IshHeader key]
		{
			get
			{
				return this.m_IshItems[key];
			}
			set
			{
				this.m_IshItems[key] = value;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00005D66 File Offset: 0x00003F66
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
		public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> GetEnumerator()
		{
			return this.m_IshItems.GetEnumerator();
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00005D78 File Offset: 0x00003F78
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_IshItems.GetEnumerator();
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00005D8C File Offset: 0x00003F8C
		public byte[] ToByteArray(bool littleEndian)
		{
			int num = 0;
			int num2 = 0;
			foreach (global::Motorola.Common.Communication.CommonUtil.IshItem ishItem in this.m_IshItems.Values)
			{
				if (ishItem.Result == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
				{
					num++;
					num2 += ishItem.ItemSize;
				}
			}
			if (num2 == 0 || num == 0)
			{
				return null;
			}
			byte[] array = new byte[num * 6 + num2];
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array))
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in this.m_IshItems)
				{
					global::Motorola.Common.Communication.CommonUtil.IshHeader key = keyValuePair.Key;
					global::Motorola.Common.Communication.CommonUtil.IshItem value = keyValuePair.Value;
					if (value.Result == global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
					{
						if (littleEndian)
						{
							memoryStream.WriteByte(key.PartitionNumber);
							memoryStream.WriteByte((byte)(key.IshType & 255));
							memoryStream.WriteByte((byte)(key.IshType >> 8));
							memoryStream.WriteByte((byte)(key.IshID & 255));
							memoryStream.WriteByte((byte)(key.IshID >> 8));
							memoryStream.WriteByte((byte)(value.ItemSize & 255));
							memoryStream.WriteByte((byte)(value.ItemSize >> 8));
							byte b = value.Data[value.Data.Length - 1];
							value.Data[value.Data.Length - 1] = value.Data[value.Data.Length - 2];
							value.Data[value.Data.Length - 2] = b;
							memoryStream.Write(value.Data, 0, value.ItemSize);
						}
						else
						{
							memoryStream.WriteByte(key.PartitionNumber);
							memoryStream.WriteByte((byte)(key.IshType >> 8));
							memoryStream.WriteByte((byte)(key.IshType & 255));
							memoryStream.WriteByte((byte)(key.IshID >> 8));
							memoryStream.WriteByte((byte)(key.IshID & 255));
							memoryStream.WriteByte((byte)(value.ItemSize >> 8));
							memoryStream.WriteByte((byte)(value.ItemSize & 255));
							memoryStream.Write(value.Data, 0, value.ItemSize);
						}
					}
				}
			}
			return array;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000603C File Offset: 0x0000423C
		public global::System.Collections.Generic.List<ushort> GetIshTypeList()
		{
			global::System.Collections.Generic.List<ushort> list = new global::System.Collections.Generic.List<ushort>();
			foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader in this.m_IshItems.Keys)
			{
				if (!list.Contains(ishHeader.IshType))
				{
					list.Add(ishHeader.IshType);
				}
			}
			return list;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000060B0 File Offset: 0x000042B0
		public static int IshPairCompare(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> x, global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> y)
		{
			return x.Key.CompareTo(y.Key);
		}

		// Token: 0x04000180 RID: 384
		[global::System.Runtime.Serialization.DataMember]
		private global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> m_IshItems;
	}
}
