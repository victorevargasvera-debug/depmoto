using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000018 RID: 24
	public class XcmpModuleInfo : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002E5B File Offset: 0x0000105B
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002E63 File Offset: 0x00001063
		public string MacAddressPort1 { get; private set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002E6C File Offset: 0x0000106C
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002E74 File Offset: 0x00001074
		public string MacAddressPort2 { get; private set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002E7D File Offset: 0x0000107D
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002E85 File Offset: 0x00001085
		public string WIFIMacAddressPort1 { get; private set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002E8E File Offset: 0x0000108E
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002E96 File Offset: 0x00001096
		public string WIFIMacAddressPort2 { get; private set; }

		// Token: 0x06000043 RID: 67 RVA: 0x00002E9F File Offset: 0x0000109F
		public XcmpModuleInfo(global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.FunctionType function, global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.ModuleID modeleID, global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.DataType dataType, byte datasize, byte[] dataValue)
		{
			base.Opcode = 1121;
			this.m_function = (byte)function;
			this.m_moduleID = (byte)modeleID;
			this.m_dataType = (byte)dataType;
			this.m_dataSize = datasize;
			this.m_dataValue = dataValue;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002ED8 File Offset: 0x000010D8
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.m_moduleID == 3)
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					this.m_function,
					this.m_moduleID,
					this.m_dataType
				});
			}
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				this.m_function,
				this.m_moduleID,
				this.m_dataType,
				this.m_dataSize,
				this.m_dataValue
			});
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002F94 File Offset: 0x00001194
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.RcmpCommon.RcmpReplyOpcodeFlag);
			if ((this.m_moduleID == 1 || this.m_moduleID == 6) && base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success && length > global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize)
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset + global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, length - global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize, array);
				if (this.m_function == 0 && this.m_dataSize == 1 && this.m_dataValue[0] == 0)
				{
					int num = 0;
					int.TryParse(array[3].ToString(), out num);
					int num2 = num / 6;
					if (num2 >= 1)
					{
						for (int i = 0; i < num2; i++)
						{
							string text = global::System.BitConverter.ToString(array[4] as byte[], i * 6 + i, 7);
							if (this.m_moduleID == 1)
							{
								if (text.Substring(0, 2) == "01")
								{
									this.MacAddressPort1 = text.Substring(3);
								}
								else if (text.Substring(0, 2) == "02")
								{
									this.MacAddressPort2 = text.Substring(3);
								}
							}
							if (this.m_moduleID == 6)
							{
								if (text.Substring(0, 2) == "01")
								{
									this.WIFIMacAddressPort1 = text.Substring(3);
								}
								else if (text.Substring(0, 2) == "02")
								{
									this.WIFIMacAddressPort2 = text.Substring(3);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x04000064 RID: 100
		private const int MACLENGTH = 6;

		// Token: 0x04000065 RID: 101
		private const string MAC1 = "01";

		// Token: 0x04000066 RID: 102
		private const string MAC2 = "02";

		// Token: 0x04000067 RID: 103
		private byte m_function;

		// Token: 0x04000068 RID: 104
		private byte m_moduleID;

		// Token: 0x04000069 RID: 105
		private byte m_dataType;

		// Token: 0x0400006A RID: 106
		private byte m_dataSize;

		// Token: 0x0400006B RID: 107
		private byte[] m_dataValue;

		// Token: 0x02000019 RID: 25
		public enum FunctionType : byte
		{
			// Token: 0x04000071 RID: 113
			Read,
			// Token: 0x04000072 RID: 114
			Write,
			// Token: 0x04000073 RID: 115
			Lock,
			// Token: 0x04000074 RID: 116
			UnLock
		}

		// Token: 0x0200001A RID: 26
		public enum ModuleID : byte
		{
			// Token: 0x04000076 RID: 118
			Device,
			// Token: 0x04000077 RID: 119
			Modem,
			// Token: 0x04000078 RID: 120
			PowerSupply,
			// Token: 0x04000079 RID: 121
			PowerAmplifier,
			// Token: 0x0400007A RID: 122
			FrontPanel,
			// Token: 0x0400007B RID: 123
			WirelineBoard,
			// Token: 0x0400007C RID: 124
			ExpansionBoard
		}

		// Token: 0x0200001B RID: 27
		public enum DataType : byte
		{
			// Token: 0x0400007E RID: 126
			SerialNumber,
			// Token: 0x0400007F RID: 127
			VendorIdentifier,
			// Token: 0x04000080 RID: 128
			KitNumber,
			// Token: 0x04000081 RID: 129
			RepeaterIdentifier,
			// Token: 0x04000082 RID: 130
			BuildDate,
			// Token: 0x04000083 RID: 131
			LastModifiedDate,
			// Token: 0x04000084 RID: 132
			InUseDate,
			// Token: 0x04000085 RID: 133
			HardwareVersion,
			// Token: 0x04000086 RID: 134
			SoftwareVersion,
			// Token: 0x04000087 RID: 135
			MACAddress,
			// Token: 0x04000088 RID: 136
			DeviceType,
			// Token: 0x04000089 RID: 137
			VendorBuildLocation
		}
	}
}
