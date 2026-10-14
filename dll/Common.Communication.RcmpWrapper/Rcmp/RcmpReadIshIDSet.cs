using System;
using System.Globalization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000046 RID: 70
	public class RcmpReadIshIDSet : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000051AB File Offset: 0x000033AB
		public byte LogicalPartition
		{
			get
			{
				return this.m_LogicalPartition;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000051B3 File Offset: 0x000033B3
		public ushort IshType
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000051BB File Offset: 0x000033BB
		public ushort TotalIdCount
		{
			get
			{
				return this.m_TotalIdCount;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000051C3 File Offset: 0x000033C3
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000051CB File Offset: 0x000033CB
		private ushort NumberOfIDs
		{
			get
			{
				return this.m_NumberOfIDs;
			}
			set
			{
				this.m_NumberOfIDs = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000051D4 File Offset: 0x000033D4
		private ushort Offset
		{
			get
			{
				return this.m_Offset;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000051DC File Offset: 0x000033DC
		public ushort[] IDs
		{
			get
			{
				return this.m_IDs;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000051E4 File Offset: 0x000033E4
		public RcmpReadIshIDSet(byte logicalPartition, ushort type, ushort numberOfIDs, ushort offset)
		{
			base.Opcode = 260;
			this.m_LogicalPartition = logicalPartition;
			this.m_Type = type;
			this.m_NumberOfIDs = numberOfIDs;
			this.m_Offset = offset;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005214 File Offset: 0x00003414
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_LogicalPartition,
				this.m_Type,
				this.m_NumberOfIDs,
				this.m_Offset
			});
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005278 File Offset: 0x00003478
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning("Read ISH ID Failure: " + base.ReplyResult, new object[0]);
			}
			if (length > global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_LogicalPartition = (byte)array[0];
				this.m_Type = (ushort)array[1];
				this.m_NumberOfIDs = (ushort)array[2];
				this.m_Offset = (ushort)array[3];
				this.m_TotalIdCount = (ushort)array[4];
				byte[] array2 = (byte[])array[5];
				this.m_IDs = new ushort[array2.Length / 2];
				for (int i = 0; i < this.m_IDs.Length; i++)
				{
					this.m_IDs[i] = (ushort)((int)array2[i * 2] * 256 + (int)array2[i * 2 + 1]);
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000053B1 File Offset: 0x000035B1
		public int MaxMessageSize
		{
			get
			{
				return global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet.HeaderSize + (int)(2 * this.m_NumberOfIDs);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000053C1 File Offset: 0x000035C1
		public static int HeaderSize
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000053C8 File Offset: 0x000035C8
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}(Partition={1},Type={2},NumberOfIDs={3},Offset={4},TotalIdCount={5},ReplyResult={6})", new object[]
			{
				base.GetType().Name,
				this.LogicalPartition,
				this.IshType,
				this.NumberOfIDs,
				this.Offset,
				this.TotalIdCount,
				base.ReplyResult
			});
		}

		// Token: 0x0400014F RID: 335
		private byte m_LogicalPartition;

		// Token: 0x04000150 RID: 336
		private ushort m_Type;

		// Token: 0x04000151 RID: 337
		private ushort m_NumberOfIDs;

		// Token: 0x04000152 RID: 338
		private ushort m_Offset;

		// Token: 0x04000153 RID: 339
		private ushort m_TotalIdCount;

		// Token: 0x04000154 RID: 340
		private ushort[] m_IDs;
	}
}
