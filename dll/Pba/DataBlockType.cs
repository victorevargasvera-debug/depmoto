using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000009 RID: 9
	[global::System.Serializable]
	public class DataBlockType
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002293 File Offset: 0x00000493
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000229B File Offset: 0x0000049B
		[global::System.Xml.Serialization.XmlAttribute("PartitionID")]
		public byte PartitionID { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000022A4 File Offset: 0x000004A4
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000022AC File Offset: 0x000004AC
		[global::System.Xml.Serialization.XmlAttribute("TypeID")]
		public ushort TypeID { get; set; }

		// Token: 0x06000022 RID: 34 RVA: 0x000022B5 File Offset: 0x000004B5
		public DataBlockType()
		{
			this.PartitionID = 0;
			this.TypeID = 0;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000022CB File Offset: 0x000004CB
		public DataBlockType(byte partitionID, ushort typeID)
		{
			this.PartitionID = partitionID;
			this.TypeID = typeID;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000022E4 File Offset: 0x000004E4
		public override bool Equals(object obj)
		{
			if (object.ReferenceEquals(this, obj))
			{
				return true;
			}
			if (obj is global::Motorola.Common.Communication.Pba.DataBlockType)
			{
				global::Motorola.Common.Communication.Pba.DataBlockType dataBlockType = (global::Motorola.Common.Communication.Pba.DataBlockType)obj;
				return this.PartitionID == dataBlockType.PartitionID && this.TypeID == dataBlockType.TypeID;
			}
			return false;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000232B File Offset: 0x0000052B
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
