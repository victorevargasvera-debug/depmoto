using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002A RID: 42
	public class SBEPGetUID : global::Motorola.Common.Communication.SBEPBaseRead
	{
		// Token: 0x0600015B RID: 347 RVA: 0x000076AF File Offset: 0x000058AF
		public SBEPGetUID()
		{
			base.InternalStartAddress = this.UID_START_ADDRESS;
			base.ExpectedReadLength = this.UID_LENGTH;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000076E2 File Offset: 0x000058E2
		public SBEPGetUID(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.InternalStartAddress = this.UID_START_ADDRESS;
			base.ExpectedReadLength = this.UID_LENGTH;
			base.TransportPipe = transPipe;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000771C File Offset: 0x0000591C
		public byte[] UID
		{
			get
			{
				return this._myUID;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00007724 File Offset: 0x00005924
		public override void ExecuteMessage()
		{
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.GetUID");
			base.ExecuteMessage();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				this._myUID = base.ReceivedData;
				if (this._myUID.Length != (int)this.UID_LENGTH)
				{
					base.OperationResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_ERROR;
				}
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.GetUID", "");
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00007786 File Offset: 0x00005986
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			base.ParseReplyMessage(buffer, uOpCode);
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				this._myUID = base.ReceivedData;
				if (this._myUID.Length != (int)this.UID_LENGTH)
				{
					base.OperationResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_ERROR;
				}
			}
			return base.OperationResult;
		}

		// Token: 0x04000076 RID: 118
		private readonly ushort UID_LENGTH = 16;

		// Token: 0x04000077 RID: 119
		private readonly uint UID_START_ADDRESS = 4043308807U;

		// Token: 0x04000078 RID: 120
		private byte[] _myUID;
	}
}
