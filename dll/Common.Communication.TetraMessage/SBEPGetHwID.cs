using System;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication
{
	// Token: 0x02000026 RID: 38
	public class SBEPGetHwID : global::Motorola.Common.Communication.SBEPBaseRead
	{
		// Token: 0x06000148 RID: 328 RVA: 0x000071BD File Offset: 0x000053BD
		public SBEPGetHwID()
		{
			this.Init();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000071DD File Offset: 0x000053DD
		public SBEPGetHwID(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transPipe)
		{
			base.TransportPipe = transPipe;
			this.Init();
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00007204 File Offset: 0x00005404
		public ushort HwID
		{
			get
			{
				if (this._forceHwId)
				{
					return this._forceHwIdValue;
				}
				return this._myHwID;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000721C File Offset: 0x0000541C
		public override void ExecuteMessage()
		{
			if (this._forceHwId)
			{
				base.OperationResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
				return;
			}
			global::Motorola.Common.LogUtility.LoggerUtil.SetTimeStampLabel("SBEPProtocol.GetHwID");
			base.ExecuteMessage();
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				byte[] receivedData = base.ReceivedData;
				this._myHwID = (ushort)((int)receivedData[0] << 8 | (int)receivedData[1]);
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.SBEP_PERFORMANCE_LOGGER_NAME).Performance("SBEPProtocol.GetHwID", "");
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00007284 File Offset: 0x00005484
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			base.ParseReplyMessage(buffer, uOpCode);
			if (base.OperationResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				byte[] receivedData = base.ReceivedData;
				this._myHwID = (ushort)((int)receivedData[0] << 8 | (int)receivedData[1]);
			}
			return base.OperationResult;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000072C0 File Offset: 0x000054C0
		private void Init()
		{
			base.InternalStartAddress = this.HW_ID_ADDRESS;
			base.ExpectedReadLength = this.HW_ID_LENGTH;
			this._myHwID = 0;
			string value = global::Motorola.Common.Communication.TetraUtility.OptionsDatabaseSingleton.Instance.GetValue(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.OPTIONS_SERVICE_SECTION, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.OPT_HWID_VALUE);
			string value2 = global::Motorola.Common.Communication.TetraUtility.OptionsDatabaseSingleton.Instance.GetValue(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.OPTIONS_SERVICE_SECTION, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.OPT_FORCE_HWID);
			if (!string.IsNullOrEmpty(value2))
			{
				this._forceHwId = (value2 == true.ToString());
			}
			else
			{
				this._forceHwId = false;
			}
			if (this._forceHwId)
			{
				if (string.IsNullOrEmpty(value))
				{
					this._forceHwId = false;
					this._forceHwIdValue = 0;
					return;
				}
				try
				{
					this._forceHwIdValue = global::System.Convert.ToUInt16(value, 16);
					return;
				}
				catch
				{
					this._forceHwId = false;
					this._forceHwIdValue = 0;
					return;
				}
			}
			this._forceHwIdValue = 0;
		}

		// Token: 0x04000069 RID: 105
		private readonly uint HW_ID_ADDRESS = 4294967041U;

		// Token: 0x0400006A RID: 106
		private readonly ushort HW_ID_LENGTH = 2;

		// Token: 0x0400006B RID: 107
		private ushort _myHwID;

		// Token: 0x0400006C RID: 108
		private bool _forceHwId;

		// Token: 0x0400006D RID: 109
		private ushort _forceHwIdValue;
	}
}
