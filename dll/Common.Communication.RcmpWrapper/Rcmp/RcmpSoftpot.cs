using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000057 RID: 87
	public class RcmpSoftpot : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000632C File Offset: 0x0000452C
		private byte Operation
		{
			get
			{
				return this.m_Operation;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00006334 File Offset: 0x00004534
		private byte Type
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000633C File Offset: 0x0000453C
		private byte[] Values
		{
			get
			{
				byte[] array = null;
				if (this.m_Values != null)
				{
					array = new byte[this.m_Values.Length];
					global::System.Buffer.BlockCopy(this.m_Values, 0, array, 0, this.m_Values.Length);
				}
				return array;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00006378 File Offset: 0x00004578
		public RcmpSoftpot(byte operation, byte type, byte[] values)
		{
			base.Opcode = 1;
			this.m_Operation = operation;
			this.m_Type = type;
			this.m_Values = values;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000639C File Offset: 0x0000459C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_Operation == 0 || this.m_Operation == 3 || this.m_Operation == 6 || this.m_Operation == 7)
			{
				if (this.m_Values != null)
				{
					throw new global::System.ArgumentException("Values", "For read operations, Values must be null");
				}
			}
			else if ((this.m_Operation == 1 || this.m_Operation == 4) && this.m_Values == null)
			{
				throw new global::System.ArgumentNullException("Values", "For write operations, Values must not be null");
			}
			if (this.m_Values != null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_Operation,
					this.m_Type,
					this.m_Values
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Operation,
				this.m_Type
			});
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006494 File Offset: 0x00004694
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_Operation = (byte)array[0];
				this.m_Type = (byte)array[1];
				this.m_Values = (byte[])array[2];
			}
		}

		// Token: 0x040001AF RID: 431
		private byte m_Operation;

		// Token: 0x040001B0 RID: 432
		private byte m_Type;

		// Token: 0x040001B1 RID: 433
		private byte[] m_Values;
	}
}
