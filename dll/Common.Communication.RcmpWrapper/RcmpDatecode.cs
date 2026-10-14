using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200003A RID: 58
	public class RcmpDatecode : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x000049C4 File Offset: 0x00002BC4
		public RcmpDatecode(byte operation, byte[] datecode, ushort source)
		{
			base.Opcode = 25;
			this.m_operation = operation;
			if (datecode != null)
			{
				this.m_datecode = new byte[datecode.Length];
				datecode.CopyTo(this.m_datecode, 0);
			}
			byte[] bytes = global::System.BitConverter.GetBytes(source);
			if (bytes != null)
			{
				this.m_source = bytes[0];
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00004A17 File Offset: 0x00002C17
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00004A1F File Offset: 0x00002C1F
		private byte Operation
		{
			get
			{
				return this.m_operation;
			}
			set
			{
				this.m_operation = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004A28 File Offset: 0x00002C28
		private byte[] Datecode
		{
			get
			{
				if (this.m_datecode == null)
				{
					return null;
				}
				byte[] array = new byte[this.m_datecode.Length];
				this.m_datecode.CopyTo(array, 0);
				return array;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00004A5C File Offset: 0x00002C5C
		private ushort Source
		{
			get
			{
				byte[] array = new byte[2];
				byte[] array2 = array;
				array2[0] = this.m_source;
				return global::System.BitConverter.ToUInt16(array2, 0);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004A84 File Offset: 0x00002C84
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_operation == 0)
			{
				if (this.m_datecode != null)
				{
					throw new global::System.ArgumentException("Datecode", "Argument for Datecode is not null for Read Operations");
				}
			}
			else if (this.m_operation == 1 && this.m_datecode == null)
			{
				throw new global::System.ArgumentNullException("Datecode", "Argument for Datecode is null for Write Operations");
			}
			if (this.m_datecode == null)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_operation
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_operation,
				this.m_datecode,
				this.m_source
			});
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004B48 File Offset: 0x00002D48
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
				this.m_datecode = new byte[length - 1 - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize];
				global::System.Array.Copy((byte[])array[0], 0, this.m_datecode, 0, length - 1 - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize);
				this.m_source = ((byte[])array[0])[length - 1 - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize];
			}
		}

		// Token: 0x04000117 RID: 279
		private byte[] m_datecode;

		// Token: 0x04000118 RID: 280
		private byte m_source;

		// Token: 0x04000119 RID: 281
		private byte m_operation;
	}
}
