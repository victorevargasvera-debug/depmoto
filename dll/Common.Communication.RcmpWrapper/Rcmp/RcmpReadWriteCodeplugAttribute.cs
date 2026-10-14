using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200006C RID: 108
	public class RcmpReadWriteCodeplugAttribute : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600018D RID: 397 RVA: 0x0000779C File Offset: 0x0000599C
		public RcmpReadWriteCodeplugAttribute(byte operation, byte attribute, byte[] attributeData)
		{
			base.Opcode = 55;
			this.m_Operation = operation;
			this.m_AttributeType = attribute;
			this.m_AttributeLength = 0;
			if (attributeData != null)
			{
				this.m_AttributeLength = (byte)attributeData.Length;
				this.m_AttributeData = new byte[attributeData.Length];
				attributeData.CopyTo(this.m_AttributeData, 0);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000077F4 File Offset: 0x000059F4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_Operation == 1)
			{
				if (this.m_AttributeData != null)
				{
					throw new global::System.ArgumentException("Attribute Data", "Argument for cp attribute is not null for Read Operations");
				}
			}
			else if (this.m_Operation == 2 && this.m_AttributeData == null)
			{
				throw new global::System.ArgumentNullException("Attribute Data", "Argument for cp attribute is null for Write Operations");
			}
			if (this.m_AttributeData == null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_Operation,
					this.m_AttributeType,
					this.m_AttributeLength
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_Operation,
				this.m_AttributeType,
				this.m_AttributeLength,
				this.m_AttributeData
			});
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000078E4 File Offset: 0x00005AE4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_Operation = (byte)array[0];
				this.m_AttributeType = (byte)array[1];
				this.m_AttributeLength = (byte)array[2];
				this.m_AttributeData = (byte[])array[3];
			}
		}

		// Token: 0x0400021E RID: 542
		private byte m_Operation;

		// Token: 0x0400021F RID: 543
		private byte m_AttributeType;

		// Token: 0x04000220 RID: 544
		private byte m_AttributeLength;

		// Token: 0x04000221 RID: 545
		private byte[] m_AttributeData;
	}
}
