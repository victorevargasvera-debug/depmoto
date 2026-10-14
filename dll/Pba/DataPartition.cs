using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200001C RID: 28
	[global::System.Serializable]
	public class DataPartition
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002F67 File Offset: 0x00001167
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002F6F File Offset: 0x0000116F
		[global::System.Xml.Serialization.XmlAttribute("ID")]
		public byte PartitionID { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002F78 File Offset: 0x00001178
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002F80 File Offset: 0x00001180
		[global::System.Xml.Serialization.XmlAttribute("Name")]
		public string PartitionName { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002F89 File Offset: 0x00001189
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002F91 File Offset: 0x00001191
		[global::System.Xml.Serialization.XmlElement("Block")]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock> DataBlocks { get; set; }

		// Token: 0x060000CC RID: 204 RVA: 0x00002F9A File Offset: 0x0000119A
		public DataPartition()
		{
			this.PartitionID = 0;
			this.PartitionName = string.Empty;
			this.DataBlocks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002FC0 File Offset: 0x000011C0
		public void Initialize(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishitemCollection)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> block in ishitemCollection)
			{
				global::Motorola.Common.Communication.Pba.DataBlock dataBlock = new global::Motorola.Common.Communication.Pba.DataBlock();
				dataBlock.Initialize(block);
				this.DataBlocks.Add(dataBlock);
				this.PartitionID = block.Key.PartitionNumber;
				this.PartitionName = "NoDefined";
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000303C File Offset: 0x0000123C
		public void Initialize(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<ushort, byte[]> fdiBlock in fdiBlockList)
			{
				global::Motorola.Common.Communication.Pba.DataBlock dataBlock = new global::Motorola.Common.Communication.Pba.DataBlock();
				dataBlock.Initialize(fdiBlock);
				this.DataBlocks.Add(dataBlock);
			}
			this.PartitionID = 0;
			this.PartitionName = "NoDefined";
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000030B0 File Offset: 0x000012B0
		public void Initialize(byte[] cpImage)
		{
			global::Motorola.Common.Communication.Pba.DataBlock dataBlock = new global::Motorola.Common.Communication.Pba.DataBlock();
			dataBlock.Initialize(cpImage);
			this.DataBlocks.Add(dataBlock);
			this.PartitionID = 0;
			this.PartitionName = "NoDefined";
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000311C File Offset: 0x0000131C
		public void UpdateWithSubPartition(global::Motorola.Common.Communication.Pba.DataPartition newSubPartition)
		{
			using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator = newSubPartition.DataBlocks.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::Motorola.Common.Communication.Pba.DataBlock sourceBlock = enumerator.Current;
					global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.DataBlock> source = from x in this.DataBlocks
					where x.BlockType == sourceBlock.BlockType && x.BlockID == sourceBlock.BlockID
					select x;
					if (source.Any<global::Motorola.Common.Communication.Pba.DataBlock>())
					{
						source.Single<global::Motorola.Common.Communication.Pba.DataBlock>().UpdateWithNewData(sourceBlock);
					}
					else
					{
						this.DataBlocks.Add(sourceBlock);
					}
				}
			}
		}
	}
}
