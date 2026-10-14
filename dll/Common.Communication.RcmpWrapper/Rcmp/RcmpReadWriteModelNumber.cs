using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200004B RID: 75
	public class RcmpReadWriteModelNumber : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00005B12 File Offset: 0x00003D12
		public string ModelNumber
		{
			get
			{
				return this.m_ModelNumber;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00005B1C File Offset: 0x00003D1C
		public RcmpReadWriteModelNumber(byte operation, string modelNumber)
		{
			if (modelNumber != null && modelNumber.Length > 17)
			{
				throw new global::System.ArgumentException("modelNumber is longer than " + 17);
			}
			base.Opcode = 16;
			this.m_ModelNumber = modelNumber;
			this.m_Operation = operation;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00005B6C File Offset: 0x00003D6C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_Operation == 0)
			{
				if (this.m_ModelNumber != null)
				{
					throw new global::System.ArgumentException("ModelNumber", "Argument for model number is not null for Read Operations");
				}
			}
			else if (this.m_Operation == 1 && this.m_ModelNumber == null)
			{
				throw new global::System.ArgumentNullException("ModelNumber", "Argument for model number is null for Write Operations");
			}
			if (this.m_ModelNumber == null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_Operation
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Operation,
				this.m_ModelNumber
			});
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00005C24 File Offset: 0x00003E24
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				object[] array = new object[]
				{
					string.Empty
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_ModelNumber = (string)array[0];
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00005C85 File Offset: 0x00003E85
		public int MaxMessageSize
		{
			get
			{
				return global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 17;
			}
		}

		// Token: 0x04000163 RID: 355
		private const int MaxModelNumberLength = 17;

		// Token: 0x04000164 RID: 356
		private string m_ModelNumber;

		// Token: 0x04000165 RID: 357
		private byte m_Operation;
	}
}
