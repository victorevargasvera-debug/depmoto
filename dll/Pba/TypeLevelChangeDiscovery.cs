using System;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000024 RID: 36
	[global::System.Serializable]
	public class TypeLevelChangeDiscovery
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00005C35 File Offset: 0x00003E35
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00005C3D File Offset: 0x00003E3D
		[global::System.Xml.Serialization.XmlAttribute("Partition")]
		public byte IshPartition { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00005C46 File Offset: 0x00003E46
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00005C4E File Offset: 0x00003E4E
		[global::System.Xml.Serialization.XmlAttribute("Type")]
		public ushort IshType { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00005C57 File Offset: 0x00003E57
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00005C5F File Offset: 0x00003E5F
		[global::System.Xml.Serialization.XmlAttribute("Counter")]
		public uint Counter { get; set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00005C68 File Offset: 0x00003E68
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00005C70 File Offset: 0x00003E70
		[global::System.Xml.Serialization.XmlAttribute("IsModified")]
		public bool IsModified { get; set; }

		// Token: 0x06000183 RID: 387 RVA: 0x00005C79 File Offset: 0x00003E79
		public TypeLevelChangeDiscovery()
		{
			this.IshPartition = 0;
			this.IshType = 0;
			this.Counter = 0U;
			this.IsModified = false;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00005C9D File Offset: 0x00003E9D
		public TypeLevelChangeDiscovery(byte partition, ushort ishType, uint counter = 0U, bool isModified = false)
		{
			this.IshPartition = partition;
			this.IshType = ishType;
			this.Counter = counter;
			this.IsModified = isModified;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00005CC4 File Offset: 0x00003EC4
		public override bool Equals(object obj)
		{
			global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery typeLevelChangeDiscovery = obj as global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery;
			return typeLevelChangeDiscovery != null && (this.IshPartition == typeLevelChangeDiscovery.IshPartition && this.IshType == typeLevelChangeDiscovery.IshType) && this.Counter == typeLevelChangeDiscovery.Counter;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00005D0C File Offset: 0x00003F0C
		public override int GetHashCode()
		{
			return this.IshPartition.GetHashCode() ^ this.IshType.GetHashCode() ^ this.Counter.GetHashCode();
		}
	}
}
