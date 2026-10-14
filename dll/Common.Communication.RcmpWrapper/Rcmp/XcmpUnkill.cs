using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000079 RID: 121
	public class XcmpUnkill : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00008858 File Offset: 0x00006A58
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00008860 File Offset: 0x00006A60
		public byte Function
		{
			get
			{
				return this.m_Function;
			}
			set
			{
				this.m_Function = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00008869 File Offset: 0x00006A69
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00008871 File Offset: 0x00006A71
		public ushort Size
		{
			get
			{
				return this.m_Size;
			}
			set
			{
				this.m_Size = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000887C File Offset: 0x00006A7C
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x000088B4 File Offset: 0x00006AB4
		public byte[] Values
		{
			get
			{
				if (this.m_Values != null)
				{
					byte[] array = new byte[(int)this.Size];
					global::System.Buffer.BlockCopy(this.m_Values, 0, array, 0, (int)this.Size);
					return array;
				}
				return null;
			}
			set
			{
				if (value != null)
				{
					this.Size = (ushort)value.Length;
					this.m_Values = new byte[(int)this.Size];
					global::System.Buffer.BlockCopy(value, 0, this.m_Values, 0, (int)this.Size);
				}
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000088E8 File Offset: 0x00006AE8
		public XcmpUnkill(global::Motorola.Common.Communication.Rcmp.UnkillFunction function, byte[] values)
		{
			base.Opcode = 1132;
			this.Function = (byte)function;
			this.Size = 0;
			this.Values = values;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00008910 File Offset: 0x00006B10
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.Function == 0)
			{
				if (this.Size != 0)
				{
					throw new global::System.ArgumentException("Values", "For request for un-kill radio, Values must be null");
				}
			}
			else if (this.Function == 1 && this.Size == 0)
			{
				throw new global::System.ArgumentNullException("Values", "For unkill operations, Values must not be null");
			}
			if (this.m_Values == null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.Function,
					this.Size
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.Function,
				this.Size,
				this.Values
			});
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000089E4 File Offset: 0x00006BE4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success && this.m_Function == 0)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.ushortObj,
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.Size = (ushort)array[1];
				this.m_Values = (byte[])array[2];
				if ((int)this.Size != this.m_Values.Length)
				{
					throw new global::System.ArgumentNullException("Values", "For unkill operations, Returned size does not match challenge value's length");
				}
			}
		}

		// Token: 0x0400026E RID: 622
		private byte m_Function;

		// Token: 0x0400026F RID: 623
		private ushort m_Size;

		// Token: 0x04000270 RID: 624
		private byte[] m_Values;
	}
}
