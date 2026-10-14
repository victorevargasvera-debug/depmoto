using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000064 RID: 100
	public class XcmpCodeplugAttribute : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00006DA3 File Offset: 0x00004FA3
		public uint TotalAllowableMemory
		{
			get
			{
				if (this.attribute == global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.TotalAllowableMemory && this.attributeData != null && this.attributeData.Length == 4)
				{
					return global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUInt32(this.attributeData, 0);
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00006DD3 File Offset: 0x00004FD3
		private uint CurrentMemoryUsed
		{
			get
			{
				if (this.attribute == global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.CurrentMemoryUsed && this.attributeData != null && this.attributeData.Length == 4)
				{
					return global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUInt32(this.attributeData, 0);
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00006E04 File Offset: 0x00005004
		private ushort OEMManufacturerID
		{
			get
			{
				if (this.attribute == global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.OEMManufacturerID && this.attributeData != null && this.attributeData.Length == 2)
				{
					return global::Motorola.Common.Communication.RcmpCommon.DecodeBytesToUInt16(this.attributeData, 0);
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00006E35 File Offset: 0x00005035
		public byte RegionalInformation
		{
			get
			{
				if (this.attribute == global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.RegionalInformation && this.attributeData != null && this.attributeData.Length == 1)
				{
					return this.attributeData[0];
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00006E61 File Offset: 0x00005061
		public byte SecurityCapability
		{
			get
			{
				if (this.attribute == global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType.CertificateSupportedID && this.attributeData != null && this.attributeData.Length == 1)
				{
					return this.attributeData[0];
				}
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00006E8E File Offset: 0x0000508E
		public byte[] AttributeData
		{
			get
			{
				return this.attributeData;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00006E96 File Offset: 0x00005096
		public XcmpCodeplugAttribute(global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation operationType, global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType attrType, byte[] attrData = null)
		{
			base.Opcode = 55;
			this.operation = operationType;
			this.attribute = attrType;
			this.attributeData = attrData;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006EBC File Offset: 0x000050BC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.attributeData == null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					(byte)this.operation,
					(byte)this.attribute,
					0
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.operation,
				(byte)this.attribute,
				(byte)this.attributeData.Length,
				this.attributeData
			});
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006F68 File Offset: 0x00005168
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | 32768);
			offset += global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize;
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				this.operation = (global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation)replyBuffer[offset];
				offset++;
				this.attribute = (global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType)replyBuffer[offset];
				offset++;
				byte b = replyBuffer[offset];
				offset++;
				this.attributeData = new byte[(int)b];
				global::System.Buffer.BlockCopy(replyBuffer, offset, this.attributeData, 0, this.attributeData.Length);
			}
		}

		// Token: 0x040001F8 RID: 504
		private global::Motorola.Common.Communication.Rcmp.CodeplugAttributeOperation operation;

		// Token: 0x040001F9 RID: 505
		private global::Motorola.Common.Communication.Rcmp.CodeplugAttributeType attribute;

		// Token: 0x040001FA RID: 506
		private byte[] attributeData;
	}
}
