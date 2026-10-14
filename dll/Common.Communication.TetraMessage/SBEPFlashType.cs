using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000024 RID: 36
	public class SBEPFlashType : global::Motorola.Common.Communication.SBEPBaseRead
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00006F3C File Offset: 0x0000513C
		public SBEPFlashType()
		{
			this._myFlashVID = 0;
			this._myFlashPID = 0;
			base.InternalStartAddress = this.FLAH_TYPE_START_ADDRESS;
			base.ExpectedReadLength = 4;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006F70 File Offset: 0x00005170
		public SBEPFlashType(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			this._myFlashVID = 0;
			this._myFlashPID = 0;
			base.InternalStartAddress = this.FLAH_TYPE_START_ADDRESS;
			base.ExpectedReadLength = 4;
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00006FAB File Offset: 0x000051AB
		public ushort FlashVID
		{
			get
			{
				return this._myFlashVID;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00006FB3 File Offset: 0x000051B3
		public ushort FlashPID
		{
			get
			{
				return this._myFlashPID;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00006FBB File Offset: 0x000051BB
		public uint StartAddress
		{
			get
			{
				return base.InternalStartAddress;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006FC4 File Offset: 0x000051C4
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.FlashType");
			base.ExecuteMessage();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				if (base.ReceivedData.Length == 4)
				{
					this._myFlashVID = (ushort)((int)base.ReceivedData[0] << 8 | (int)base.ReceivedData[1]);
					this._myFlashPID = (ushort)((int)base.ReceivedData[2] << 8 | (int)base.ReceivedData[3]);
				}
				else
				{
					base.OperationResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_ERROR;
				}
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.FlashType", "");
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000704C File Offset: 0x0000524C
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			base.ParseReplyMessage(buffer, uOpCode);
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				this._myReplyMessageBuffer = base.ReceivedData;
				if (base.ReceivedData.Length == 4)
				{
					this._myFlashVID = (ushort)((int)this._myReplyMessageBuffer[0] << 8 | (int)this._myReplyMessageBuffer[1]);
					this._myFlashPID = (ushort)((int)this._myReplyMessageBuffer[2] << 8 | (int)this._myReplyMessageBuffer[3]);
				}
				else
				{
					base.OperationResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_ERROR;
				}
			}
			return base.OperationResult;
		}

		// Token: 0x04000063 RID: 99
		private ushort _myFlashVID;

		// Token: 0x04000064 RID: 100
		private ushort _myFlashPID;

		// Token: 0x04000065 RID: 101
		private readonly uint FLAH_TYPE_START_ADDRESS = 4294967042U;
	}
}
