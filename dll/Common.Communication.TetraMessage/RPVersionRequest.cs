using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000050 RID: 80
	public class RPVersionRequest : global::Motorola.Common.Communication.RPBaseMessage
	{
		// Token: 0x06000241 RID: 577 RVA: 0x00009EF1 File Offset: 0x000080F1
		public RPVersionRequest()
		{
			this._protocolVer = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_UNKNOWN;
			this._terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			this._portableCPChanged = false;
			this._mobileCHCPChanged = false;
			this._mobileTransCPChanged = false;
			this._portableFwVer = 0;
			this._mobileCHFwVer = 0;
			this._mobileTransFwVer = 0;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00009F34 File Offset: 0x00008134
		public RPVersionRequest(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
			this._protocolVer = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_UNKNOWN;
			this._terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			this._portableCPChanged = false;
			this._mobileCHCPChanged = false;
			this._mobileTransCPChanged = false;
			this._portableFwVer = 0;
			this._mobileCHFwVer = 0;
			this._mobileTransFwVer = 0;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00009F86 File Offset: 0x00008186
		public global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion ProtocolVersion
		{
			get
			{
				return this._protocolVer;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00009F8E File Offset: 0x0000818E
		public global::Motorola.Common.Communication.CommonUtil.RPTerminalType TerminalType
		{
			get
			{
				return this._terminalType;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00009F96 File Offset: 0x00008196
		public bool PortableCPChanged
		{
			get
			{
				return this._portableCPChanged;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00009F9E File Offset: 0x0000819E
		public bool MobileControlHeadCPChanged
		{
			get
			{
				return this._mobileCHCPChanged;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00009FA6 File Offset: 0x000081A6
		public bool MobileTransCPChanged
		{
			get
			{
				return this._mobileTransCPChanged;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00009FAE File Offset: 0x000081AE
		public ushort PortableFwVersion
		{
			get
			{
				return this._portableFwVer;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00009FB6 File Offset: 0x000081B6
		public ushort MobileControlHeadFwVersion
		{
			get
			{
				return this._mobileCHFwVer;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00009FBE File Offset: 0x000081BE
		public ushort MobileTransFwVersion
		{
			get
			{
				return this._mobileTransFwVer;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00009FC6 File Offset: 0x000081C6
		public byte[] FlashPacket
		{
			get
			{
				return this._falshPacket;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00009FCE File Offset: 0x000081CE
		public int FlashPacketNumber
		{
			get
			{
				return this._flashPacketNum;
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00009FD8 File Offset: 0x000081D8
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("RPProtocol.RPVersionRequest");
			bool flag = true;
			this.BuildCommandMessageInternal();
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = base.Executor.SendRequest(base.HasCommand, base.MyCommandBuffer, base.hasReply, out this._myReplyMessageBuffer);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RP_PERFORMANCE_LOGGER_NAME).Performance("RPProtocol.RPVersionRequest", "");
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000A058 File Offset: 0x00008258
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BuildCommandMessageInternal()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			base.MyCommandBuffer = new byte[4];
			base.MyCommandBuffer[0] = 0;
			base.MyCommandBuffer[1] = 0;
			base.MyCommandBuffer[2] = 1;
			base.MyCommandBuffer[3] = 1;
			return result;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000A09C File Offset: 0x0000829C
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			if (buffer == null)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
			}
			if (buffer.Length < 14)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_MSG_WRONG_FORMAT;
			}
			byte[] array = new byte[512];
			global::System.Array.Clear(array, 0, array.Length);
			global::System.Array.Copy(buffer, array, buffer.Length);
			int num = 3;
			if (array[num] != 2)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_INVALID_ID_FORMAT;
			}
			if (flag)
			{
				tetraMsgOpResult = this.GetTerminalType(array, out this._terminalType);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
				{
					flag = false;
				}
			}
			if (flag)
			{
				tetraMsgOpResult = this.GetProtocolVersion(array, out this._protocolVer);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this._terminalType == global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_TERMINAL_TYPE_PORTABLE)
				{
					tetraMsgOpResult = this.GetPortableCPChangedFlag(array, out this._portableCPChanged);
				}
				else
				{
					tetraMsgOpResult = this.GetMobileCPChangedFlag(array, out this._mobileCHCPChanged, out this._mobileTransCPChanged);
				}
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this._terminalType == global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_TERMINAL_TYPE_PORTABLE)
				{
					tetraMsgOpResult = this.GetPortableFwVersion(array, out this._portableFwVer);
				}
				else
				{
					tetraMsgOpResult = this.GetMobileFwVersion(array, out this._mobileCHFwVer, out this._mobileTransFwVer);
				}
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
				{
					flag = false;
				}
			}
			if (flag)
			{
				tetraMsgOpResult = this.GetFlashPacket(array, out this._falshPacket, out this._flashPacketNum);
			}
			return tetraMsgOpResult;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000A1A4 File Offset: 0x000083A4
		private global::Motorola.Common.Communication.TetraMsgOpResult GetProtocolVersion(byte[] data, out global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion protocolVer)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			protocolVer = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_UNKNOWN;
			int num = 12;
			protocolVer = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_UNKNOWN;
			if (data == null)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
			}
			if (num >= data.Length)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
			}
			if (flag)
			{
				try
				{
					protocolVer = (global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion)(data[num] / 2);
				}
				catch
				{
					protocolVer = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_UNKNOWN;
				}
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			}
			return result;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000A1F8 File Offset: 0x000083F8
		private global::Motorola.Common.Communication.TetraMsgOpResult GetTerminalType(byte[] data, out global::Motorola.Common.Communication.CommonUtil.RPTerminalType terminalType)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult result = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			int num = 12;
			terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			if (data == null)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
			}
			if (num >= data.Length)
			{
				flag = false;
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
			}
			if (flag)
			{
				try
				{
					terminalType = (global::Motorola.Common.Communication.CommonUtil.RPTerminalType)(data[num] % 2);
				}
				catch
				{
					terminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
				}
				result = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			}
			return result;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000A24C File Offset: 0x0000844C
		private global::Motorola.Common.Communication.TetraMsgOpResult GetPortableCPChangedFlag(byte[] data, out bool bCPChanged)
		{
			bool flag = true;
			global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion rpprotocolVersion = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_UNKNOWN;
			global::Motorola.Common.Communication.CommonUtil.RPTerminalType rpterminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			int num = 13;
			bCPChanged = false;
			if (data == null)
			{
				flag = false;
			}
			if (num >= data.Length)
			{
				flag = false;
			}
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = this.GetTerminalType(data, out rpterminalType);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (rpterminalType != global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_TERMINAL_TYPE_PORTABLE)
			{
				flag = false;
			}
			tetraMsgOpResult = this.GetProtocolVersion(data, out rpprotocolVersion);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				if (rpprotocolVersion == global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_A)
				{
					bCPChanged = (global::System.BitConverter.ToUInt16(data, num) != 0);
				}
				else
				{
					bCPChanged = (data[num] != 0);
				}
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			}
			return tetraMsgOpResult;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000A2D4 File Offset: 0x000084D4
		private global::Motorola.Common.Communication.TetraMsgOpResult GetMobileCPChangedFlag(byte[] data, out bool bCHCPChanged, out bool bTransChanged)
		{
			bool flag = true;
			global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion rpprotocolVersion = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_UNKNOWN;
			global::Motorola.Common.Communication.CommonUtil.RPTerminalType rpterminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			int num = 13;
			bCHCPChanged = false;
			bTransChanged = false;
			if (data == null)
			{
				flag = false;
			}
			if (num >= data.Length)
			{
				flag = false;
			}
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = this.GetTerminalType(data, out rpterminalType);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (rpterminalType != global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_TERMINAL_TYPE_MOBILE)
			{
				flag = false;
			}
			tetraMsgOpResult = this.GetProtocolVersion(data, out rpprotocolVersion);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				if (rpprotocolVersion == global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_A)
				{
					bTransChanged = (global::System.BitConverter.ToUInt16(data, num) != 0);
					num += 2;
					bCHCPChanged = (global::System.BitConverter.ToUInt16(data, num) != 0);
				}
				else
				{
					bTransChanged = (data[num] != 0);
					num++;
					bCHCPChanged = (data[num] != 0);
				}
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
			}
			return tetraMsgOpResult;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000A38C File Offset: 0x0000858C
		private global::Motorola.Common.Communication.TetraMsgOpResult GetPortableFwVersion(byte[] data, out ushort fwVersion)
		{
			bool flag = true;
			global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion rpprotocolVersion = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_UNKNOWN;
			global::Motorola.Common.Communication.CommonUtil.RPTerminalType rpterminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			int num = 13;
			fwVersion = 0;
			if (data == null)
			{
				flag = false;
			}
			if (num >= data.Length)
			{
				flag = false;
			}
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = this.GetTerminalType(data, out rpterminalType);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (rpterminalType != global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_TERMINAL_TYPE_PORTABLE)
			{
				flag = false;
			}
			tetraMsgOpResult = this.GetProtocolVersion(data, out rpprotocolVersion);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				byte[] array = new byte[2];
				if (rpprotocolVersion == global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_A)
				{
					num += 2;
				}
				else
				{
					num++;
				}
				tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(array, 0, data, num, 2);
				if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					fwVersion = global::System.BitConverter.ToUInt16(array, 0);
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
				}
				else
				{
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
				}
			}
			return tetraMsgOpResult;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000A428 File Offset: 0x00008628
		private global::Motorola.Common.Communication.TetraMsgOpResult GetMobileFwVersion(byte[] data, out ushort chFwVersion, out ushort transFwVersion)
		{
			bool flag = true;
			global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion rpprotocolVersion = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_UNKNOWN;
			global::Motorola.Common.Communication.CommonUtil.RPTerminalType rpterminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			int num = 13;
			chFwVersion = 0;
			transFwVersion = 0;
			if (data == null)
			{
				flag = false;
			}
			if (num >= data.Length)
			{
				flag = false;
			}
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = this.GetTerminalType(data, out rpterminalType);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (rpterminalType != global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_TERMINAL_TYPE_MOBILE)
			{
				flag = false;
			}
			tetraMsgOpResult = this.GetProtocolVersion(data, out rpprotocolVersion);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				byte[] array = new byte[2];
				if (rpprotocolVersion == global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_A)
				{
					num += 4;
				}
				else
				{
					num += 2;
				}
				tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(array, 0, data, num, 2);
				if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					transFwVersion = global::System.BitConverter.ToUInt16(array, 0);
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
				}
				else
				{
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
					flag = false;
				}
				if (flag)
				{
					num += 2;
					tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(array, 0, data, num, 2);
					if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						chFwVersion = global::System.BitConverter.ToUInt16(array, 0);
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
					}
					else
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_WRONG_PARAMETER;
					}
				}
			}
			return tetraMsgOpResult;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000A4F4 File Offset: 0x000086F4
		private global::Motorola.Common.Communication.TetraMsgOpResult GetFlashPacket(byte[] data, out byte[] flashPacket, out int flashPacketNum)
		{
			bool flag = true;
			global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion rpprotocolVersion = global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_UNKNOWN;
			global::Motorola.Common.Communication.CommonUtil.RPTerminalType rpterminalType = global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_UNKNOWN_TYPE;
			int num = 13;
			flashPacket = null;
			flashPacketNum = 0;
			if (data == null)
			{
				flag = false;
			}
			if (num >= data.Length)
			{
				flag = false;
			}
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = this.GetTerminalType(data, out rpterminalType);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			tetraMsgOpResult = this.GetProtocolVersion(data, out rpprotocolVersion);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				if (rpterminalType == global::Motorola.Common.Communication.CommonUtil.RPTerminalType.RP_TERMINAL_TYPE_PORTABLE)
				{
					if (rpprotocolVersion == global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_A)
					{
						num += 4;
					}
					else
					{
						num += 3;
					}
				}
				else if (rpprotocolVersion == global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion.RP_VER_A)
				{
					num += 8;
				}
				else
				{
					num += 6;
				}
				flashPacketNum = (int)data[num];
				if (flashPacketNum > 20)
				{
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_MSG_WRONG_FORMAT;
				}
				else
				{
					int num2 = flashPacketNum * 16;
					if (num2 > 0)
					{
						byte[] array = new byte[num2];
						global::System.Array.Copy(data, num, array, 0, num2);
						flashPacket = array;
					}
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.RP_SUCCESS;
				}
			}
			return tetraMsgOpResult;
		}

		// Token: 0x040000ED RID: 237
		private global::Motorola.Common.Communication.CommonUtil.RPProtocolVersion _protocolVer;

		// Token: 0x040000EE RID: 238
		private global::Motorola.Common.Communication.CommonUtil.RPTerminalType _terminalType;

		// Token: 0x040000EF RID: 239
		private bool _portableCPChanged;

		// Token: 0x040000F0 RID: 240
		private bool _mobileCHCPChanged;

		// Token: 0x040000F1 RID: 241
		private bool _mobileTransCPChanged;

		// Token: 0x040000F2 RID: 242
		private ushort _portableFwVer;

		// Token: 0x040000F3 RID: 243
		private ushort _mobileCHFwVer;

		// Token: 0x040000F4 RID: 244
		private ushort _mobileTransFwVer;

		// Token: 0x040000F5 RID: 245
		private byte[] _falshPacket;

		// Token: 0x040000F6 RID: 246
		private int _flashPacketNum;
	}
}
