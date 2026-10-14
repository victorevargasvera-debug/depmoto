using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000014 RID: 20
	public class XcmpConnectivityTest : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002A84 File Offset: 0x00000C84
		public XcmpConnectivityTest(global::Motorola.Common.Communication.ConnectFunction function, ushort length, byte[] data) : this((byte)function, length, data)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002A8F File Offset: 0x00000C8F
		private XcmpConnectivityTest(byte function, ushort length, byte[] data)
		{
			base.Opcode = 48;
			this.m_connectFunction = function;
			this.m_functionDataLength = length;
			this.m_functionData = data;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002AB4 File Offset: 0x00000CB4
		public byte ConnectFunction
		{
			get
			{
				return this.m_connectFunction;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002ABC File Offset: 0x00000CBC
		public ushort FunctionDataLength
		{
			get
			{
				return this.m_functionDataLength;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002AC4 File Offset: 0x00000CC4
		private byte[] FunctionData
		{
			get
			{
				return this.m_functionData;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002ACC File Offset: 0x00000CCC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_functionData == null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_connectFunction,
					this.m_functionDataLength
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_connectFunction,
				this.m_functionDataLength,
				this.m_functionData
			});
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002B60 File Offset: 0x00000D60
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success && length >= global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 3)
			{
				this.m_connectFunction = replyBuffer[offset + 3];
				this.m_functionDataLength = (ushort)((int)replyBuffer[offset + 5] | (int)replyBuffer[offset + 4] << 8);
				if (this.m_functionData == null)
				{
					this.m_functionData = new byte[(int)this.m_functionDataLength];
				}
				if (length - 6 >= (int)this.m_functionDataLength)
				{
					if (this.m_functionData.Length != (int)this.m_functionDataLength)
					{
						this.m_functionData = new byte[(int)this.m_functionDataLength];
					}
					global::System.Array.Clear(this.m_functionData, 0, this.m_functionData.Length);
					global::System.Array.Copy(replyBuffer, offset + 6, this.m_functionData, 0, (int)this.m_functionDataLength);
				}
			}
		}

		// Token: 0x04000056 RID: 86
		private byte m_connectFunction;

		// Token: 0x04000057 RID: 87
		private ushort m_functionDataLength;

		// Token: 0x04000058 RID: 88
		private byte[] m_functionData;
	}
}
