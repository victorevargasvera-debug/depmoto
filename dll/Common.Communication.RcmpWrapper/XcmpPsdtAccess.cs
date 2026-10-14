using System;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x02000070 RID: 112
	public class XcmpPsdtAccess : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600019C RID: 412 RVA: 0x00007DC5 File Offset: 0x00005FC5
		private XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction action)
		{
			base.Opcode = 267;
			this.m_Action = action;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00007DE0 File Offset: 0x00005FE0
		public XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction action, string psdtSrcSectionId, string psdtTgtSectionId) : this(action)
		{
			this.m_psdtSrcSectionId = global::System.Text.Encoding.ASCII.GetBytes(psdtSrcSectionId);
			this.m_psdtTgtSectionId = global::System.Text.Encoding.ASCII.GetBytes(psdtTgtSectionId);
			if (this.m_psdtSrcSectionId.Length > 4 || this.m_psdtTgtSectionId.Length > 4)
			{
				throw new global::System.ArgumentException("PSDT is longer than " + 4 + " bytes");
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00007E47 File Offset: 0x00006047
		public uint PsdtAddress
		{
			get
			{
				return this.m_psdtAddress;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00007E50 File Offset: 0x00006050
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.m_Action,
				this.m_psdtSrcSectionId,
				this.m_psdtTgtSectionId
			});
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00007E9C File Offset: 0x0000609C
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
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				this.m_Action = (global::Motorola.Common.Communication.PsdtAccessAction)array[0];
				for (int i = 0; i < 4; i++)
				{
					this.m_psdtSrcSectionId[i] = (byte)array[i + 1];
				}
				for (int j = 0; j < 4; j++)
				{
					this.m_psdtTgtSectionId[j] = (byte)array[j + 5];
				}
				if (this.m_Action == global::Motorola.Common.Communication.PsdtAccessAction.GetStartAddress || this.m_Action == global::Motorola.Common.Communication.PsdtAccessAction.GetEndAddress)
				{
					int num = global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 9;
					array = new object[]
					{
						global::Motorola.Common.Communication.RcmpCommon.uintObj
					};
					global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + num, length - num, array);
					this.m_psdtAddress = (uint)array[0];
				}
			}
		}

		// Token: 0x04000233 RID: 563
		private const uint getStartAddr = 1U;

		// Token: 0x04000234 RID: 564
		private const uint getEndAddr = 2U;

		// Token: 0x04000235 RID: 565
		private const int MaxPSDTIDLength = 4;

		// Token: 0x04000236 RID: 566
		private global::Motorola.Common.Communication.PsdtAccessAction m_Action;

		// Token: 0x04000237 RID: 567
		private byte[] m_psdtSrcSectionId;

		// Token: 0x04000238 RID: 568
		private byte[] m_psdtTgtSectionId;

		// Token: 0x04000239 RID: 569
		private uint m_psdtAddress;
	}
}
