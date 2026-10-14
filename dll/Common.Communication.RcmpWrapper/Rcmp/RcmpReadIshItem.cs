using System;
using System.Globalization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000047 RID: 71
	public class RcmpReadIshItem : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000544E File Offset: 0x0000364E
		public byte LogicalPartition
		{
			get
			{
				return this.m_LogicalPartition;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00005456 File Offset: 0x00003656
		public ushort IshType
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000545E File Offset: 0x0000365E
		public ushort IshID
		{
			get
			{
				return this.m_ID;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005466 File Offset: 0x00003666
		public ushort ItemSize
		{
			get
			{
				return this.m_ItemSize;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000546E File Offset: 0x0000366E
		private ushort NumberOfBytes
		{
			get
			{
				return this.m_NumberOfBytes;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005476 File Offset: 0x00003676
		public ushort Offset
		{
			get
			{
				return this.m_Offset;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000547E File Offset: 0x0000367E
		public byte[] Data
		{
			get
			{
				return this.m_Data;
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005486 File Offset: 0x00003686
		public RcmpReadIshItem(byte logicalPartition, ushort type, ushort id, ushort numberOfBytes, ushort offset)
		{
			base.Opcode = 256;
			this.m_LogicalPartition = logicalPartition;
			this.m_Type = type;
			this.m_ID = id;
			this.m_NumberOfBytes = numberOfBytes;
			this.m_Offset = offset;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000054C0 File Offset: 0x000036C0
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_LogicalPartition,
				this.m_Type,
				this.m_ID,
				this.m_NumberOfBytes,
				this.m_Offset
			});
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005530 File Offset: 0x00003730
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning("Read ISH Item Failure: " + base.ReplyResult, new object[0]);
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
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_LogicalPartition = (byte)array[0];
				this.m_Type = (ushort)array[1];
				this.m_ID = (ushort)array[2];
				this.m_NumberOfBytes = (ushort)array[3];
				this.m_Offset = (ushort)array[4];
				this.m_ItemSize = (ushort)array[5];
				this.m_Data = (byte[])array[6];
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00005645 File Offset: 0x00003845
		public int MaxMessageSize
		{
			get
			{
				return global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem.HeaderSize + (int)this.m_NumberOfBytes;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00005653 File Offset: 0x00003853
		public static int HeaderSize
		{
			get
			{
				return 14;
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005658 File Offset: 0x00003858
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}(Partition={1},Type={2},ID={3},NumberOfBytes={4},Offset={5},ItemSize={6},ReplyResult={7})", new object[]
			{
				base.GetType().Name,
				this.LogicalPartition,
				this.IshType,
				this.IshID,
				this.NumberOfBytes,
				this.Offset,
				this.ItemSize,
				base.ReplyResult
			});
		}

		// Token: 0x04000155 RID: 341
		private byte m_LogicalPartition;

		// Token: 0x04000156 RID: 342
		private ushort m_Type;

		// Token: 0x04000157 RID: 343
		private ushort m_ID;

		// Token: 0x04000158 RID: 344
		private ushort m_NumberOfBytes;

		// Token: 0x04000159 RID: 345
		private ushort m_Offset;

		// Token: 0x0400015A RID: 346
		private ushort m_ItemSize;

		// Token: 0x0400015B RID: 347
		private byte[] m_Data;
	}
}
