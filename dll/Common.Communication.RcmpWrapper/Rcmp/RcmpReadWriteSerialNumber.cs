using System;
using System.Text;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200004D RID: 77
	public class RcmpReadWriteSerialNumber : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00005C90 File Offset: 0x00003E90
		public RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType operation, string serialNumber)
		{
			base.Opcode = 17;
			this.m_Operation = operation;
			if (serialNumber != null)
			{
				this.m_SerialNumberBuffer = global::System.Text.Encoding.ASCII.GetBytes(serialNumber + '\0');
				if (this.m_SerialNumberBuffer.Length > 11)
				{
					throw new global::System.ArgumentException("serialNumber is longer than " + 11 + " bytes");
				}
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00005CF9 File Offset: 0x00003EF9
		public RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType operation, byte[] rawSerialNumber)
		{
			base.Opcode = 17;
			this.m_Operation = operation;
			if (rawSerialNumber != null)
			{
				this.m_SerialNumberBuffer = new byte[rawSerialNumber.Length];
				rawSerialNumber.CopyTo(this.m_SerialNumberBuffer, 0);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00005D30 File Offset: 0x00003F30
		public string SerialNumber
		{
			get
			{
				if (this.m_SerialNumberBuffer != null)
				{
					int length = 10;
					int offset = 0;
					return global::System.Convert.ToBase64String(this.m_SerialNumberBuffer, offset, length);
				}
				return null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00005D5C File Offset: 0x00003F5C
		public byte[] SerialRawBytes
		{
			get
			{
				if (this.m_SerialNumberBuffer == null)
				{
					return null;
				}
				byte[] array = new byte[this.m_SerialNumberBuffer.Length];
				this.m_SerialNumberBuffer.CopyTo(array, 0);
				return array;
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005D90 File Offset: 0x00003F90
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_Operation % global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadESN == global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadRadioSerialNumber)
			{
				if (this.m_SerialNumberBuffer != null)
				{
					throw new global::System.ArgumentException("SerialNumber", "Argument for serial number is not null for Read Operations");
				}
			}
			else if (this.m_SerialNumberBuffer == null)
			{
				throw new global::System.ArgumentNullException("SerialNumber", "Argument for serial number is null for Write Operations");
			}
			if (this.m_SerialNumberBuffer == null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					(byte)this.m_Operation
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.m_Operation,
				this.m_SerialNumberBuffer
			});
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005E40 File Offset: 0x00004040
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_SerialNumberBuffer = (byte[])array[0];
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00005EA1 File Offset: 0x000040A1
		public int MaxMessageSize
		{
			get
			{
				return global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 11;
			}
		}

		// Token: 0x04000173 RID: 371
		private const int MaxSerialNumberLength = 11;

		// Token: 0x04000174 RID: 372
		private byte[] m_SerialNumberBuffer;

		// Token: 0x04000175 RID: 373
		private global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType m_Operation;
	}
}
