using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200001D RID: 29
	[global::System.Serializable]
	public class PackedRadioData
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000031C0 File Offset: 0x000013C0
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000031C8 File Offset: 0x000013C8
		[global::System.Xml.Serialization.XmlAttribute("ArchiveSessionID")]
		public ushort ArchiveSessionID { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000031D1 File Offset: 0x000013D1
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000031D9 File Offset: 0x000013D9
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> TypeCounters { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000031E2 File Offset: 0x000013E2
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000031EA File Offset: 0x000013EA
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> IDCounters { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000031F3 File Offset: 0x000013F3
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000031FB File Offset: 0x000013FB
		[global::System.Xml.Serialization.XmlAttribute("Type")]
		public global::Motorola.Common.Communication.Pba.DataType DataType { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00003204 File Offset: 0x00001404
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000320C File Offset: 0x0000140C
		[global::System.Xml.Serialization.XmlAttribute("CPVersion")]
		public string CPVersion { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00003215 File Offset: 0x00001415
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000321D File Offset: 0x0000141D
		[global::System.Xml.Serialization.XmlElement("Partition")]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition> DataPartitions { get; set; }

		// Token: 0x060000DD RID: 221 RVA: 0x00003226 File Offset: 0x00001426
		public PackedRadioData()
		{
			this.ArchiveSessionID = 0;
			this.TypeCounters = null;
			this.IDCounters = null;
			this.DataType = global::Motorola.Common.Communication.Pba.DataType.ISH;
			this.CPVersion = null;
			this.DataPartitions = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000325C File Offset: 0x0000145C
		public void Initialize(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection)
		{
			this.DataPartitions.Clear();
			global::System.Collections.Generic.Dictionary<byte, global::Motorola.Common.Communication.CommonUtil.IshItemCollection> dictionary = new global::System.Collections.Generic.Dictionary<byte, global::Motorola.Common.Communication.CommonUtil.IshItemCollection>();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in ishItemCollection)
			{
				if (!dictionary.ContainsKey(keyValuePair.Key.PartitionNumber))
				{
					dictionary.Add(keyValuePair.Key.PartitionNumber, new global::Motorola.Common.Communication.CommonUtil.IshItemCollection());
				}
				dictionary[keyValuePair.Key.PartitionNumber].Add(keyValuePair.Key, keyValuePair.Value);
			}
			foreach (global::System.Collections.Generic.KeyValuePair<byte, global::Motorola.Common.Communication.CommonUtil.IshItemCollection> keyValuePair2 in dictionary)
			{
				global::Motorola.Common.Communication.Pba.DataPartition dataPartition = new global::Motorola.Common.Communication.Pba.DataPartition();
				dataPartition.Initialize(keyValuePair2.Value);
				this.DataPartitions.Add(dataPartition);
			}
			this.DataType = global::Motorola.Common.Communication.Pba.DataType.ISH;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000336C File Offset: 0x0000156C
		public void Initialize(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList)
		{
			this.DataPartitions.Clear();
			global::Motorola.Common.Communication.Pba.DataPartition dataPartition = new global::Motorola.Common.Communication.Pba.DataPartition();
			dataPartition.Initialize(fdiBlockList);
			this.DataPartitions.Add(dataPartition);
			this.DataType = global::Motorola.Common.Communication.Pba.DataType.FDI;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000033A4 File Offset: 0x000015A4
		public void Initialize(byte[] cpImage)
		{
			this.DataPartitions.Clear();
			global::Motorola.Common.Communication.Pba.DataPartition dataPartition = new global::Motorola.Common.Communication.Pba.DataPartition();
			dataPartition.Initialize(cpImage);
			this.DataPartitions.Add(dataPartition);
			this.DataType = global::Motorola.Common.Communication.Pba.DataType.Image;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000343C File Offset: 0x0000163C
		public void RemoveIDCounterAndDataByTypes(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> typesToRemove)
		{
			if (!typesToRemove.Any<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery>())
			{
				return;
			}
			if (this.IDCounters != null && this.IDCounters.Count > 0)
			{
				this.IDCounters.RemoveAll((global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery x) => typesToRemove.Contains(new global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery(x.IshPartition, x.IshType, 0U, false), new global::Motorola.Common.Communication.Pba.TypeComparer()));
			}
			using (global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> enumerator = typesToRemove.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery typeToRemove = enumerator.Current;
					global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.DataPartition> source = from x in this.DataPartitions
					where x.PartitionID == typeToRemove.IshPartition
					select x;
					if (source.Any<global::Motorola.Common.Communication.Pba.DataPartition>())
					{
						source.Single<global::Motorola.Common.Communication.Pba.DataPartition>().DataBlocks.RemoveAll((global::Motorola.Common.Communication.Pba.DataBlock x) => x.BlockType == typeToRemove.IshType);
					}
				}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000355C File Offset: 0x0000175C
		public void RemoveCounterAndDataByTypes(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> typesToRemove)
		{
			if (!typesToRemove.Any<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery>())
			{
				return;
			}
			if (this.TypeCounters != null && this.TypeCounters.Count > 0)
			{
				this.TypeCounters.RemoveAll((global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery x) => typesToRemove.Contains(x, new global::Motorola.Common.Communication.Pba.TypeComparer()));
			}
			this.RemoveIDCounterAndDataByTypes(typesToRemove);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003628 File Offset: 0x00001828
		public void RemoveItemsAndDataByItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> itemsToRemove)
		{
			if (!itemsToRemove.Any<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery>())
			{
				return;
			}
			if (this.IDCounters != null && this.IDCounters.Count > 0)
			{
				this.IDCounters.RemoveAll((global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery x) => itemsToRemove.Contains(x, new global::Motorola.Common.Communication.Pba.ItemComparer()));
			}
			using (global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> enumerator = itemsToRemove.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery itemToRemove = enumerator.Current;
					global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.DataPartition> source = from x in this.DataPartitions
					where x.PartitionID == itemToRemove.IshPartition
					select x;
					if (source.Any<global::Motorola.Common.Communication.Pba.DataPartition>())
					{
						source.Single<global::Motorola.Common.Communication.Pba.DataPartition>().DataBlocks.RemoveAll((global::Motorola.Common.Communication.Pba.DataBlock x) => x.BlockType == itemToRemove.IshType && x.BlockID == itemToRemove.IshID);
					}
				}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000374C File Offset: 0x0000194C
		public void UpdateWithSubCodeplug(global::Motorola.Common.Communication.Pba.PackedRadioData newSubCodeplug)
		{
			using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator = newSubCodeplug.DataPartitions.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::Motorola.Common.Communication.Pba.DataPartition sourcePartition = enumerator.Current;
					global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.DataPartition> source = from x in this.DataPartitions
					where x.PartitionID == sourcePartition.PartitionID
					select x;
					if (source.Any<global::Motorola.Common.Communication.Pba.DataPartition>())
					{
						source.Single<global::Motorola.Common.Communication.Pba.DataPartition>().UpdateWithSubPartition(sourcePartition);
					}
					else
					{
						this.DataPartitions.Add(sourcePartition);
					}
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00003858 File Offset: 0x00001A58
		public void FilterData(global::System.Collections.Generic.IEnumerable<ushort> partitionsFilter, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> itemsFilter)
		{
			using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator = this.DataPartitions.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::Motorola.Common.Communication.Pba.DataPartition partition = enumerator.Current;
					if (!partitionsFilter.Contains((ushort)partition.PartitionID))
					{
						partition.DataBlocks.RemoveAll((global::Motorola.Common.Communication.Pba.DataBlock x) => !itemsFilter.Contains(new global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery
						{
							IshPartition = partition.PartitionID,
							IshType = x.BlockType,
							IshID = x.BlockID
						}, new global::Motorola.Common.Communication.Pba.ItemComparer()));
					}
				}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000038FC File Offset: 0x00001AFC
		public void SetAllChangeDiscoveryIsModified(bool isModified)
		{
			foreach (global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery typeLevelChangeDiscovery in this.TypeCounters)
			{
				typeLevelChangeDiscovery.IsModified = isModified;
			}
			foreach (global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery itemLevelChangeDiscovery in this.IDCounters)
			{
				itemLevelChangeDiscovery.IsModified = isModified;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003994 File Offset: 0x00001B94
		public void SetTypeCounters(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery> typeCounters)
		{
			this.TypeCounters = typeCounters;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000399D File Offset: 0x00001B9D
		public void SetIDCounters(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery> idCounters)
		{
			this.IDCounters = idCounters;
		}
	}
}
