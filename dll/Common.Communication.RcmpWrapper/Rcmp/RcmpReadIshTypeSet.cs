using System;
using System.Globalization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000049 RID: 73
	public class RcmpReadIshTypeSet : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000057CF File Offset: 0x000039CF
		private byte LogicalPartition
		{
			get
			{
				return this.m_LogicalPartition;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000057D7 File Offset: 0x000039D7
		public ushort TotalTypeCount
		{
			get
			{
				return this.m_TotalTypeCount;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000057DF File Offset: 0x000039DF
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000057E7 File Offset: 0x000039E7
		private ushort NumberOfTypes
		{
			get
			{
				return this.m_NumberOfTypes;
			}
			set
			{
				this.m_NumberOfTypes = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000057F0 File Offset: 0x000039F0
		private ushort Offset
		{
			get
			{
				return this.m_Offset;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000057F8 File Offset: 0x000039F8
		public ushort[] Types
		{
			get
			{
				return this.m_Types;
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00005800 File Offset: 0x00003A00
		public RcmpReadIshTypeSet(byte logicalPartition, ushort numberofTypes, ushort offset)
		{
			base.Opcode = 261;
			this.m_LogicalPartition = logicalPartition;
			this.m_NumberOfTypes = numberofTypes;
			this.m_Offset = offset;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005828 File Offset: 0x00003A28
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_LogicalPartition,
				this.m_NumberOfTypes,
				this.m_Offset
			});
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000587C File Offset: 0x00003A7C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning("Read ISH Type Failure: " + base.ReplyResult, new object[0]);
			}
			if (length > global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_LogicalPartition = (byte)array[0];
				this.m_NumberOfTypes = (ushort)array[1];
				this.m_Offset = (ushort)array[2];
				this.m_TotalTypeCount = (ushort)array[3];
				byte[] array2 = (byte[])array[4];
				this.m_Types = new ushort[array2.Length / 2];
				for (int i = 0; i < this.m_Types.Length; i++)
				{
					this.m_Types[i] = (ushort)((int)array2[i * 2] * 256 + (int)array2[i * 2 + 1]);
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000599F File Offset: 0x00003B9F
		public int MaxMessageSize
		{
			get
			{
				return global::Motorola.Common.Communication.Rcmp.RcmpReadIshTypeSet.HeaderSize + (int)(2 * this.m_NumberOfTypes);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000059AF File Offset: 0x00003BAF
		public static int HeaderSize
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000059B4 File Offset: 0x00003BB4
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}(Partition={1},NumberOfTypes={2},Offset={3},TotalTypeCount={4},ReplyResult={5})", new object[]
			{
				base.GetType().Name,
				this.LogicalPartition,
				this.NumberOfTypes,
				this.Offset,
				this.TotalTypeCount,
				base.ReplyResult
			});
		}

		// Token: 0x0400015D RID: 349
		private byte m_LogicalPartition;

		// Token: 0x0400015E RID: 350
		private ushort m_NumberOfTypes;

		// Token: 0x0400015F RID: 351
		private ushort m_Offset;

		// Token: 0x04000160 RID: 352
		private ushort m_TotalTypeCount;

		// Token: 0x04000161 RID: 353
		private ushort[] m_Types;
	}
}
