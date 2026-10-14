using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000016 RID: 22
	[global::System.Serializable]
	public class ItemLevelChangeDiscovery
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002A59 File Offset: 0x00000C59
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002A61 File Offset: 0x00000C61
		[global::System.Xml.Serialization.XmlAttribute("Partition")]
		public byte IshPartition { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002A6A File Offset: 0x00000C6A
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002A72 File Offset: 0x00000C72
		[global::System.Xml.Serialization.XmlAttribute("Type")]
		public ushort IshType { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00002A7B File Offset: 0x00000C7B
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002A83 File Offset: 0x00000C83
		[global::System.Xml.Serialization.XmlAttribute("ID")]
		public ushort IshID { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002A8C File Offset: 0x00000C8C
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002A94 File Offset: 0x00000C94
		[global::System.Xml.Serialization.XmlAttribute("Counter")]
		public uint Counter { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002A9D File Offset: 0x00000C9D
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002AA5 File Offset: 0x00000CA5
		[global::System.Xml.Serialization.XmlAttribute("IsModified")]
		public bool IsModified { get; set; }

		// Token: 0x060000A4 RID: 164 RVA: 0x00002AAE File Offset: 0x00000CAE
		public ItemLevelChangeDiscovery()
		{
			this.IshPartition = 0;
			this.IshType = 0;
			this.IshID = 0;
			this.Counter = 0U;
			this.IsModified = false;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002ADC File Offset: 0x00000CDC
		public override bool Equals(object obj)
		{
			global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery itemLevelChangeDiscovery = obj as global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery;
			return itemLevelChangeDiscovery != null && (this.IshPartition == itemLevelChangeDiscovery.IshPartition && this.IshType == itemLevelChangeDiscovery.IshType && this.IshID == itemLevelChangeDiscovery.IshID) && this.Counter == itemLevelChangeDiscovery.Counter;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002B30 File Offset: 0x00000D30
		public override int GetHashCode()
		{
			return this.IshPartition.GetHashCode() ^ this.IshType.GetHashCode() ^ this.IshID.GetHashCode() ^ this.Counter.GetHashCode();
		}
	}
}
