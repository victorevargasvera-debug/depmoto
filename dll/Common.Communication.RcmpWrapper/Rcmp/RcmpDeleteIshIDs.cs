using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200003B RID: 59
	public class RcmpDeleteIshIDs : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00004BE5 File Offset: 0x00002DE5
		private byte LogicalPartition
		{
			get
			{
				return this.m_LogicalPartition;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00004BED File Offset: 0x00002DED
		public ushort IshType
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00004BF5 File Offset: 0x00002DF5
		private ushort StartID
		{
			get
			{
				return this.m_StartID;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00004BFD File Offset: 0x00002DFD
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00004C05 File Offset: 0x00002E05
		public ushort EndID
		{
			get
			{
				return this.m_EndID;
			}
			set
			{
				this.m_EndID = value;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004C0E File Offset: 0x00002E0E
		public RcmpDeleteIshIDs(byte partition, ushort type, ushort startID, ushort endID)
		{
			base.Opcode = 258;
			this.m_LogicalPartition = partition;
			this.m_Type = type;
			this.m_StartID = startID;
			this.m_EndID = endID;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004C40 File Offset: 0x00002E40
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_LogicalPartition,
				this.m_Type,
				this.m_StartID,
				this.m_EndID
			});
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004CA4 File Offset: 0x00002EA4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (length > global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_LogicalPartition = (byte)array[0];
				this.m_Type = (ushort)array[1];
				this.m_StartID = (ushort)array[2];
				this.m_EndID = (ushort)array[3];
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00004D47 File Offset: 0x00002F47
		public int MaxMessageSize
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004D4B File Offset: 0x00002F4B
		private static int RcmpDeleteIshIDsHeaderSize
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x0400011A RID: 282
		private byte m_LogicalPartition;

		// Token: 0x0400011B RID: 283
		private ushort m_Type;

		// Token: 0x0400011C RID: 284
		private ushort m_StartID;

		// Token: 0x0400011D RID: 285
		private ushort m_EndID;
	}
}
