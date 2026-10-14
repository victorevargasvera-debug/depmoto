using System;
using System.Collections.Generic;
using System.Globalization;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000018 RID: 24
	public class XnlPacket
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00003E05 File Offset: 0x00002005
		internal XnlPacket(global::Motorola.Common.Communication.NLProtocolType nlType)
		{
			this.NLType = nlType;
			this.xnlOpcode = global::Motorola.Common.Communication.XnlOpcodes.Reserved;
			this.rnlOpcode = global::Motorola.Common.Communication.RnlOpcodes.DataMessage;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003E24 File Offset: 0x00002024
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "XnlPacket(opcode={0}, protocolID={1}, xnlFlags={2}, destinationAddr={3}, sourceAddr={4}, transactionID={5}, payloadLength={6})", new object[]
			{
				this.opcode,
				this.protocolID,
				this.xnlFlags,
				this.destinationAddr,
				this.sourceAddress,
				this.transactionID,
				this.payloadLength
			});
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003EAA File Offset: 0x000020AA
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00003EC1 File Offset: 0x000020C1
		internal ushort opcode
		{
			get
			{
				if (this.NLType == global::Motorola.Common.Communication.NLProtocolType.Xnl)
				{
					return (ushort)this.xnlOpcode;
				}
				return (ushort)this.rnlOpcode;
			}
			set
			{
				if (this.NLType == global::Motorola.Common.Communication.NLProtocolType.Xnl)
				{
					this.xnlOpcode = (global::Motorola.Common.Communication.XnlOpcodes)value;
					return;
				}
				this.rnlOpcode = (global::Motorola.Common.Communication.RnlOpcodes)value;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003EDC File Offset: 0x000020DC
		internal byte[] ToBytes()
		{
			global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
			if (this.NLType == global::Motorola.Common.Communication.NLProtocolType.Xnl)
			{
				this.opcode = (ushort)this.xnlOpcode;
				global::Motorola.Common.Communication.XnlPacket.AppendWordToBytes(list, (int)this.opcode);
				global::Motorola.Common.Communication.XnlPacket.AppendByteToBytes(list, (int)this.protocolID);
				global::Motorola.Common.Communication.XnlPacket.AppendByteToBytes(list, (int)this.xnlFlags);
				global::Motorola.Common.Communication.XnlPacket.AppendWordToBytes(list, (int)this.destinationAddr);
				global::Motorola.Common.Communication.XnlPacket.AppendWordToBytes(list, (int)this.sourceAddress);
				global::Motorola.Common.Communication.XnlPacket.AppendWordToBytes(list, (int)this.transactionID);
				global::Motorola.Common.Communication.XnlPacket.AppendWordToBytes(list, (int)this.payloadLength);
			}
			else
			{
				this.opcode = (ushort)this.rnlOpcode;
				global::Motorola.Common.Communication.XnlPacket.AppendByteToBytes(list, (int)this.opcode);
				global::Motorola.Common.Communication.XnlPacket.AppendDwordToBytes(list, (int)this.payloadLength);
			}
			if (this.payloadLength > 0U && this.payload != null)
			{
				list.AddRange(this.payload);
			}
			return list.ToArray();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003FA0 File Offset: 0x000021A0
		internal void ReadFromBytes(byte[] bytes)
		{
			if (this.NLType == global::Motorola.Common.Communication.NLProtocolType.Xnl)
			{
				if (bytes != null || bytes.Length >= 12)
				{
					this.opcode = global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(bytes, 0);
					this.xnlOpcode = (global::Motorola.Common.Communication.XnlOpcodes)this.opcode;
					this.protocolID = (global::Motorola.Common.Communication.XnlProtocol)global::Motorola.Common.Communication.XnlPacket.ReadByteFromBytes(bytes, 2);
					this.xnlFlags = global::Motorola.Common.Communication.XnlPacket.ReadByteFromBytes(bytes, 3);
					this.destinationAddr = global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(bytes, 4);
					this.sourceAddress = global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(bytes, 6);
					this.transactionID = global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(bytes, 8);
					this.payloadLength = (uint)global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(bytes, 10);
					this.payload = new byte[this.payloadLength];
					global::System.Array.Copy(bytes, 12L, this.payload, 0L, (long)((ulong)this.payloadLength));
					return;
				}
			}
			else if (bytes != null || bytes.Length >= 5)
			{
				this.opcode = (ushort)global::Motorola.Common.Communication.XnlPacket.ReadByteFromBytes(bytes, 0);
				this.payloadLength = global::Motorola.Common.Communication.XnlPacket.ReadDwordFromBytes(bytes, 1);
				this.payload = new byte[this.payloadLength];
				global::System.Array.Copy(bytes, 5L, this.payload, 0L, (long)((ulong)this.payloadLength));
				if (this.opcode == 1)
				{
					this.transactionID = ushort.MaxValue;
				}
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000040B8 File Offset: 0x000022B8
		internal void ReadHeaderFromBytes(byte[] bytes)
		{
			if (this.NLType == global::Motorola.Common.Communication.NLProtocolType.Xnl)
			{
				if (bytes != null || bytes.Length >= 12)
				{
					this.opcode = global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(bytes, 0);
					this.xnlOpcode = (global::Motorola.Common.Communication.XnlOpcodes)this.opcode;
					this.protocolID = (global::Motorola.Common.Communication.XnlProtocol)global::Motorola.Common.Communication.XnlPacket.ReadByteFromBytes(bytes, 2);
					this.xnlFlags = global::Motorola.Common.Communication.XnlPacket.ReadByteFromBytes(bytes, 3);
					this.destinationAddr = global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(bytes, 4);
					this.sourceAddress = global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(bytes, 6);
					this.transactionID = global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(bytes, 8);
					this.payloadLength = (uint)global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(bytes, 10);
					return;
				}
			}
			else if (bytes != null || bytes.Length >= 5)
			{
				this.opcode = (ushort)global::Motorola.Common.Communication.XnlPacket.ReadByteFromBytes(bytes, 0);
				this.payloadLength = global::Motorola.Common.Communication.XnlPacket.ReadDwordFromBytes(bytes, 1);
				if (this.opcode == 1)
				{
					this.transactionID = ushort.MaxValue;
					return;
				}
				if (this.opcode == 16)
				{
					this.transactionID = 65534;
				}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004190 File Offset: 0x00002390
		internal void ReadBodyFromBytes(byte[] bytes)
		{
			if ((long)bytes.Length == (long)((ulong)this.payloadLength))
			{
				this.payload = bytes;
				return;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationNLPayloadHasBadData);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000041B4 File Offset: 0x000023B4
		internal static global::Motorola.Common.Communication.XnlPacket GetDeviceMasterQueryPacket()
		{
			return new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Xnl)
			{
				opcode = 3,
				protocolID = global::Motorola.Common.Communication.XnlProtocol.XnlControl,
				xnlFlags = 0,
				destinationAddr = 0,
				sourceAddress = 0,
				transactionID = 0,
				payloadLength = 0U
			};
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000041FC File Offset: 0x000023FC
		internal static global::Motorola.Common.Communication.XnlPacket GetDeviceAuthKeyRequestPacket(ushort masterAddress)
		{
			return new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Xnl)
			{
				opcode = 4,
				protocolID = global::Motorola.Common.Communication.XnlProtocol.XnlControl,
				xnlFlags = 0,
				destinationAddr = masterAddress,
				sourceAddress = 0,
				transactionID = 0,
				payloadLength = 0U
			};
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004244 File Offset: 0x00002444
		internal static global::Motorola.Common.Communication.XnlPacket GetDeviceConnRequestPacket(ushort masterAddress, ushort tempSourceaAddress, int preferredXnlAddress, byte deviceType, byte authenticationLevel, byte[] encryptedAuthenticationValue)
		{
			global::Motorola.Common.Communication.XnlPacket xnlPacket = new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Xnl);
			xnlPacket.opcode = 6;
			xnlPacket.protocolID = global::Motorola.Common.Communication.XnlProtocol.XnlControl;
			xnlPacket.xnlFlags = global::Motorola.Common.Communication.NLConstants.ConnectionRequestNeedAckXnlFlags;
			xnlPacket.destinationAddr = masterAddress;
			xnlPacket.sourceAddress = tempSourceaAddress;
			xnlPacket.transactionID = 0;
			xnlPacket.payloadLength = 12U;
			xnlPacket.payload = new byte[xnlPacket.payloadLength];
			xnlPacket.payload[0] = (byte)(preferredXnlAddress / 256);
			xnlPacket.payload[1] = (byte)(preferredXnlAddress % 256);
			xnlPacket.payload[2] = deviceType;
			xnlPacket.payload[3] = authenticationLevel;
			global::System.Buffer.BlockCopy(encryptedAuthenticationValue, 0, xnlPacket.payload, 4, encryptedAuthenticationValue.Length);
			return xnlPacket;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000042E8 File Offset: 0x000024E8
		internal static void DecodeDeviceConnReplyPacket(global::Motorola.Common.Communication.XnlPacket packet, out byte resultCode, out byte transactionIdBase, out ushort xnlAddress, out ushort logicalAddress, out byte[] encryptedAuthenticationValue)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsTrue(packet == null || packet.payloadLength < 14U, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlReceiveMessageFailure);
			resultCode = packet.payload[0];
			transactionIdBase = packet.payload[1];
			xnlAddress = (ushort)((int)packet.payload[2] * 256 + (int)packet.payload[3]);
			logicalAddress = (ushort)((int)packet.payload[4] * 256 + (int)packet.payload[5]);
			encryptedAuthenticationValue = new byte[8];
			global::System.Buffer.BlockCopy(packet.payload, 6, encryptedAuthenticationValue, 0, encryptedAuthenticationValue.Length);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004378 File Offset: 0x00002578
		internal static global::Motorola.Common.Communication.XnlPacket GetDataAckPacket(global::Motorola.Common.Communication.XnlPacket packet)
		{
			return new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Xnl)
			{
				opcode = 12,
				xnlFlags = packet.xnlFlags,
				sourceAddress = packet.destinationAddr,
				destinationAddr = packet.sourceAddress,
				protocolID = packet.protocolID,
				transactionID = packet.transactionID,
				payloadLength = 0U
			};
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000043D8 File Offset: 0x000025D8
		internal static global::Motorola.Common.Communication.XnlPacket GetDeviceInitStatusBroadcastPacket(ushort masterAddress, ushort sourceAddress, ushort transactionID)
		{
			global::Motorola.Common.Communication.XnlPacket xnlPacket = new global::Motorola.Common.Communication.XnlPacket(global::Motorola.Common.Communication.NLProtocolType.Xnl);
			xnlPacket.opcode = 11;
			xnlPacket.protocolID = global::Motorola.Common.Communication.XnlProtocol.Xcmp;
			xnlPacket.xnlFlags = 0;
			xnlPacket.destinationAddr = masterAddress;
			xnlPacket.sourceAddress = sourceAddress;
			xnlPacket.transactionID = transactionID;
			xnlPacket.payloadLength = 11U;
			xnlPacket.payload = new byte[xnlPacket.payloadLength];
			xnlPacket.payload[0] = 180;
			xnlPacket.payload[1] = 0;
			xnlPacket.payload[2] = 0;
			xnlPacket.payload[3] = 0;
			xnlPacket.payload[4] = 0;
			xnlPacket.payload[5] = 0;
			xnlPacket.payload[6] = 0;
			xnlPacket.payload[7] = 10;
			xnlPacket.payload[8] = 0;
			xnlPacket.payload[9] = 0;
			xnlPacket.payload[10] = 0;
			return xnlPacket;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000449C File Offset: 0x0000269C
		internal static void DecodeDeviceInitStatusBroadcastPacket(global::Motorola.Common.Communication.XnlPacket packet, out global::Motorola.Common.Communication.DeviceInitType deviceInitType, out global::Motorola.Common.Communication.DeviceType deviceType)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsTrue(packet == null || packet.payloadLength < 7U, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationXnlReceiveMessageFailure);
			deviceType = global::Motorola.Common.Communication.DeviceType.UnknownDevice;
			deviceInitType = (global::Motorola.Common.Communication.DeviceInitType)packet.payload[6];
			if (packet.payloadLength > 7U)
			{
				deviceType = (global::Motorola.Common.Communication.DeviceType)packet.payload[7];
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000044D8 File Offset: 0x000026D8
		public static uint ReadDwordFromBytes(byte[] bytes, int startIndex)
		{
			ushort num = global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(bytes, startIndex);
			ushort num2 = global::Motorola.Common.Communication.XnlPacket.ReadWordFromBytes(bytes, startIndex + 2);
			return (uint)(((int)num << 16) + (int)num2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000044FD File Offset: 0x000026FD
		public static ushort ReadWordFromBytes(byte[] bytes, int startIndex)
		{
			return (ushort)((int)bytes[startIndex] * 256 + (int)bytes[startIndex + 1]);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000450F File Offset: 0x0000270F
		private static byte ReadByteFromBytes(byte[] bytes, int startIndex)
		{
			return bytes[startIndex];
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004514 File Offset: 0x00002714
		private static void AppendByteToBytes(global::System.Collections.Generic.List<byte> bytes, int dWord)
		{
			byte[] bytes2 = global::System.BitConverter.GetBytes(dWord);
			bytes.Add(bytes2[0]);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004534 File Offset: 0x00002734
		private static void AppendWordToBytes(global::System.Collections.Generic.List<byte> bytes, int dWord)
		{
			byte[] bytes2 = global::System.BitConverter.GetBytes(dWord);
			bytes.Add(bytes2[1]);
			bytes.Add(bytes2[0]);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000455C File Offset: 0x0000275C
		private static void AppendDwordToBytes(global::System.Collections.Generic.List<byte> bytes, int dWord)
		{
			byte[] bytes2 = global::System.BitConverter.GetBytes(dWord);
			bytes.Add(bytes2[3]);
			bytes.Add(bytes2[2]);
			bytes.Add(bytes2[1]);
			bytes.Add(bytes2[0]);
		}

		// Token: 0x04000078 RID: 120
		internal const int DEVINITSTS_OPCODE = 46080;

		// Token: 0x04000079 RID: 121
		private const int DEVINITSTS_OPCODE_LENGTH = 2;

		// Token: 0x0400007A RID: 122
		private const int DEVINITSTS_XCMP_VERSION_LENGTH = 4;

		// Token: 0x0400007B RID: 123
		private const int DEVINITSTS_INIT_TYPE_FIELD_LENGTH = 1;

		// Token: 0x0400007C RID: 124
		private global::Motorola.Common.Communication.NLProtocolType NLType;

		// Token: 0x0400007D RID: 125
		public uint payloadLength;

		// Token: 0x0400007E RID: 126
		public byte[] payload;

		// Token: 0x0400007F RID: 127
		private global::Motorola.Common.Communication.RnlOpcodes rnlOpcode;

		// Token: 0x04000080 RID: 128
		private global::Motorola.Common.Communication.XnlOpcodes xnlOpcode;

		// Token: 0x04000081 RID: 129
		internal global::Motorola.Common.Communication.XnlProtocol protocolID;

		// Token: 0x04000082 RID: 130
		internal byte xnlFlags;

		// Token: 0x04000083 RID: 131
		internal ushort destinationAddr;

		// Token: 0x04000084 RID: 132
		internal ushort sourceAddress;

		// Token: 0x04000085 RID: 133
		internal ushort transactionID;
	}
}
