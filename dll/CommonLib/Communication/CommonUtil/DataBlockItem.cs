using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000009 RID: 9
	[global::System.Xml.Serialization.XmlType("D")]
	[global::System.Serializable]
	public class DataBlockItem
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002A87 File Offset: 0x00000C87
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002A8F File Offset: 0x00000C8F
		[global::System.Xml.Serialization.XmlAttribute("T")]
		public string TagName { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002A98 File Offset: 0x00000C98
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002AA0 File Offset: 0x00000CA0
		[global::System.Xml.Serialization.XmlAttribute("P")]
		public byte PartitionID { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002AA9 File Offset: 0x00000CA9
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002AB1 File Offset: 0x00000CB1
		[global::System.Xml.Serialization.XmlAttribute("BT")]
		public ushort BlockType { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002ABA File Offset: 0x00000CBA
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002AC2 File Offset: 0x00000CC2
		[global::System.Xml.Serialization.XmlAttribute("BI")]
		public ushort BlockID { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002ACB File Offset: 0x00000CCB
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002AD3 File Offset: 0x00000CD3
		[global::System.Xml.Serialization.XmlAttribute("O")]
		public int Offset { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002ADC File Offset: 0x00000CDC
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002AE4 File Offset: 0x00000CE4
		[global::System.Xml.Serialization.XmlAttribute("L")]
		public int Length { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002AED File Offset: 0x00000CED
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002AF5 File Offset: 0x00000CF5
		[global::System.Xml.Serialization.XmlElement("C")]
		public byte[] Content { get; set; }

		// Token: 0x0600004B RID: 75 RVA: 0x00002AFE File Offset: 0x00000CFE
		public DataBlockItem()
		{
			this.TagName = string.Empty;
			this.PartitionID = 0;
			this.BlockType = 0;
			this.BlockID = 0;
			this.Offset = 0;
			this.Length = 0;
			this.Content = null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002B3B File Offset: 0x00000D3B
		public DataBlockItem(string tag, byte partitionID, ushort blockType, ushort blockID, int offset, int length)
		{
			this.TagName = tag;
			this.PartitionID = partitionID;
			this.BlockType = blockType;
			this.BlockID = blockID;
			this.Offset = offset;
			this.Length = length;
			this.Content = null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002B78 File Offset: 0x00000D78
		public DataBlockItem(global::Motorola.Common.Communication.CommonUtil.DataBlockItem field)
		{
			this.TagName = field.TagName;
			this.PartitionID = field.PartitionID;
			this.BlockType = field.BlockType;
			this.BlockID = field.BlockID;
			this.Offset = field.Offset;
			this.Length = field.Length;
			this.Content = this.Content;
		}
	}
}
