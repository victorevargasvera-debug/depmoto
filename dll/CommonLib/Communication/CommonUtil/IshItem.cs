using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000037 RID: 55
	[global::System.Runtime.Serialization.DataContract(Namespace = "http://www.motorola.com/Cps/Acp/Communication")]
	public struct IshItem
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x000062C8 File Offset: 0x000044C8
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x000062D0 File Offset: 0x000044D0
		public int ItemSize
		{
			get
			{
				return this.m_ItemSize;
			}
			set
			{
				this.m_ItemSize = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x000062D9 File Offset: 0x000044D9
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x000062E1 File Offset: 0x000044E1
		public byte[] Data
		{
			get
			{
				return this.m_Data;
			}
			set
			{
				this.m_Data = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001BA RID: 442 RVA: 0x000062EA File Offset: 0x000044EA
		// (set) Token: 0x060001BB RID: 443 RVA: 0x000062F2 File Offset: 0x000044F2
		public global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult Result
		{
			get
			{
				return this.m_Result;
			}
			set
			{
				this.m_Result = value;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000062FB File Offset: 0x000044FB
		public IshItem(int itemSize, byte[] data, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult result)
		{
			this.m_ItemSize = itemSize;
			this.m_Data = data;
			this.m_Result = result;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00006314 File Offset: 0x00004514
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "ItemSize={0}, Data={1} bytes, Result={2}", new object[]
			{
				this.ItemSize,
				(this.Data == null) ? "null" : (this.Data.Length.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + " bytes"),
				this.Result.ToString()
			});
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000638C File Offset: 0x0000458C
		public override bool Equals(object obj)
		{
			if (obj is global::Motorola.Common.Communication.CommonUtil.IshItem)
			{
				global::Motorola.Common.Communication.CommonUtil.IshItem objB = (global::Motorola.Common.Communication.CommonUtil.IshItem)obj;
				return this == objB;
			}
			return false;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000063B6 File Offset: 0x000045B6
		public override int GetHashCode()
		{
			return this.m_ItemSize.GetHashCode() ^ this.m_Result.GetHashCode() ^ this.m_Data.GetHashCode();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000063E0 File Offset: 0x000045E0
		public static bool operator ==(global::Motorola.Common.Communication.CommonUtil.IshItem objA, global::Motorola.Common.Communication.CommonUtil.IshItem objB)
		{
			return objA.ItemSize == objB.ItemSize && objA.Result == objB.Result && global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CompareBytes(objA.Data, objB.Data) == 0;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000641A File Offset: 0x0000461A
		public static bool operator !=(global::Motorola.Common.Communication.CommonUtil.IshItem objA, global::Motorola.Common.Communication.CommonUtil.IshItem objB)
		{
			return !(objA == objB);
		}

		// Token: 0x04000184 RID: 388
		[global::System.Runtime.Serialization.DataMember]
		private int m_ItemSize;

		// Token: 0x04000185 RID: 389
		[global::System.Runtime.Serialization.DataMember]
		private byte[] m_Data;

		// Token: 0x04000186 RID: 390
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult m_Result;
	}
}
