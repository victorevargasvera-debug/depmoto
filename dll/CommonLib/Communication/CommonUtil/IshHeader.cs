using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000036 RID: 54
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public struct IshHeader : global::System.IComparable<global::Motorola.Common.Communication.CommonUtil.IshHeader>
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000060D3 File Offset: 0x000042D3
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000060DB File Offset: 0x000042DB
		[global::System.Runtime.Serialization.DataMember]
		public byte PartitionNumber
		{
			get
			{
				return this.m_PartitionNumber;
			}
			set
			{
				this.m_PartitionNumber = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000060E4 File Offset: 0x000042E4
		// (set) Token: 0x060001AB RID: 427 RVA: 0x000060EC File Offset: 0x000042EC
		[global::System.Runtime.Serialization.DataMember]
		public ushort IshType
		{
			get
			{
				return this.m_IshType;
			}
			set
			{
				this.m_IshType = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000060F5 File Offset: 0x000042F5
		// (set) Token: 0x060001AD RID: 429 RVA: 0x000060FD File Offset: 0x000042FD
		[global::System.Runtime.Serialization.DataMember]
		public ushort IshID
		{
			get
			{
				return this.m_IshID;
			}
			set
			{
				this.m_IshID = value;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00006106 File Offset: 0x00004306
		public IshHeader(byte partitionNumber, ushort ishType, ushort ishId)
		{
			this.m_PartitionNumber = partitionNumber;
			this.m_IshType = ishType;
			this.m_IshID = ishId;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00006120 File Offset: 0x00004320
		public override int GetHashCode()
		{
			uint num = 2166136261U;
			num = (num ^ (uint)this.m_PartitionNumber) * 16777619U;
			num = (uint)((ulong)num ^ (ulong)((long)(this.m_IshType >> 8 & 255))) * 16777619U;
			num = (uint)((ulong)num ^ (ulong)((long)(this.m_IshType & 255))) * 16777619U;
			num = (uint)((ulong)num ^ (ulong)((long)(this.m_IshID >> 8 & 255))) * 16777619U;
			num = (uint)((ulong)num ^ (ulong)((long)(this.m_IshID & 255))) * 16777619U;
			num += num << 13;
			num ^= num >> 7;
			num += num << 3;
			num ^= num >> 17;
			return (int)(num + (num << 5));
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000061C8 File Offset: 0x000043C8
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Partition={0}, Type={1}, ID={2}", new object[]
			{
				this.PartitionNumber,
				this.IshType,
				this.IshID
			});
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00006218 File Offset: 0x00004418
		public override bool Equals(object obj)
		{
			if (obj is global::Motorola.Common.Communication.CommonUtil.IshHeader)
			{
				global::Motorola.Common.Communication.CommonUtil.IshHeader objB = (global::Motorola.Common.Communication.CommonUtil.IshHeader)obj;
				return this == objB;
			}
			return false;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00006242 File Offset: 0x00004442
		public int CompareTo(global::Motorola.Common.Communication.CommonUtil.IshHeader other)
		{
			return global::System.Math.Sign(this.Int64HeaderID - other.Int64HeaderID);
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00006258 File Offset: 0x00004458
		[global::System.Runtime.Serialization.IgnoreDataMember]
		public long Int64HeaderID
		{
			get
			{
				long num = (long)((long)((ulong)this.PartitionNumber) << 32);
				num |= (long)((long)((ulong)this.IshType) << 16);
				return num | (long)((ulong)this.IshID);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00006288 File Offset: 0x00004488
		public static bool operator ==(global::Motorola.Common.Communication.CommonUtil.IshHeader objA, global::Motorola.Common.Communication.CommonUtil.IshHeader objB)
		{
			return objA.PartitionNumber == objB.PartitionNumber && objA.IshType == objB.IshType && objA.IshID == objB.IshID;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000062BC File Offset: 0x000044BC
		public static bool operator !=(global::Motorola.Common.Communication.CommonUtil.IshHeader objA, global::Motorola.Common.Communication.CommonUtil.IshHeader objB)
		{
			return !(objA == objB);
		}

		// Token: 0x04000181 RID: 385
		private byte m_PartitionNumber;

		// Token: 0x04000182 RID: 386
		private ushort m_IshType;

		// Token: 0x04000183 RID: 387
		private ushort m_IshID;
	}
}
