using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000069 RID: 105
	public class XcmpNetworkInfConfig : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600017F RID: 383 RVA: 0x000072F8 File Offset: 0x000054F8
		public XcmpNetworkInfConfig(global::Motorola.Common.Communication.IPFunction function, byte ifIndex, string IPAddr, string SubnetMask, string GatewayIP)
		{
			base.Opcode = 1076;
			this._function = function;
			this._interfaceIndex = ifIndex;
			if (string.IsNullOrEmpty(IPAddr) || string.IsNullOrEmpty(SubnetMask) || string.IsNullOrEmpty(GatewayIP))
			{
				throw new global::System.ArgumentException("ip is null");
			}
			this._ipAddress = this.ConvertIPString2Int(IPAddr);
			this._subNetMask = this.ConvertIPString2Int(SubnetMask);
			this._gatewayIPAddress = this.ConvertIPString2Int(GatewayIP);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00007374 File Offset: 0x00005574
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this._function,
				this._interfaceIndex,
				this._ipAddress,
				this._subNetMask,
				this._gatewayIPAddress
			});
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000073E4 File Offset: 0x000055E4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success && length >= global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 3)
			{
				this._function = (global::Motorola.Common.Communication.IPFunction)replyBuffer[offset + 3];
				this._interfaceIndex = replyBuffer[offset + 4];
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00007434 File Offset: 0x00005634
		private uint ConvertIPString2Int(string IPAddr)
		{
			string[] array = IPAddr.Split(new char[]
			{
				'.'
			});
			if (array.Length != 4)
			{
				throw new global::System.ArgumentException("Ip value is not 4 sections.");
			}
			uint num = 0U;
			foreach (string value in array)
			{
				num = (num << 8) + global::System.Convert.ToUInt32(value, 10);
			}
			return num;
		}

		// Token: 0x04000210 RID: 528
		private global::Motorola.Common.Communication.IPFunction _function;

		// Token: 0x04000211 RID: 529
		private byte _interfaceIndex;

		// Token: 0x04000212 RID: 530
		private uint _ipAddress;

		// Token: 0x04000213 RID: 531
		private uint _subNetMask;

		// Token: 0x04000214 RID: 532
		private uint _gatewayIPAddress;
	}
}
