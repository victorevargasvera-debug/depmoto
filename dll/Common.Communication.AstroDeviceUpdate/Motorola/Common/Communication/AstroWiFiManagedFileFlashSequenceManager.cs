using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000007 RID: 7
	public class AstroWiFiManagedFileFlashSequenceManager : global::Motorola.Common.Communication.AstroManagedFileFlashSequenceManager
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00003D2B File Offset: 0x00001F2B
		public AstroWiFiManagedFileFlashSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int inactivityTimer, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
			this._WifiInactivityTimer = inactivityTimer;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003D44 File Offset: 0x00001F44
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
			{
				base.UnlockRadioPartition(0);
				this._sessionID = sessionID;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003D5C File Offset: 0x00001F5C
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
			{
				if (!pendingDeploy)
				{
					ushort num;
					ushort num2;
					base.IOController.ComponentSession(32, sessionID, out num, out num2);
					base.ValidateUpdate();
				}
				this.ExitWriteProgramMode();
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003D90 File Offset: 0x00001F90
		protected override void EnterWriteProgramMode()
		{
			byte[] data = new byte[]
			{
				(byte)(this._WifiInactivityTimer / 256),
				(byte)(this._WifiInactivityTimer & 255)
			};
			base.IOController.EnterProgramMode(4, data);
			((global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
			this._isEnterProgramMode = true;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003DEC File Offset: 0x00001FEC
		protected override void ExitWriteProgramMode()
		{
			ushort checksum = ((global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor)base.RcmpWrapper).Checksum;
			byte[] data = new byte[]
			{
				(byte)(checksum / 256),
				(byte)(checksum & 255)
			};
			base.IOController.ExitProgramMode(6, data);
			this._isEnterProgramMode = false;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003E40 File Offset: 0x00002040
		public override void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			if (!this._isEnterProgramMode)
			{
				this.EnterWriteProgramMode();
				if (base.SessionParam.ArchiveSession)
				{
					if (!base.DifferentialWriteCapableRadio)
					{
						ushort num;
						ushort num2;
						base.IOController.ComponentSession(7, this._sessionID, out num, out num2);
					}
				}
				else
				{
					ushort num;
					ushort num2;
					base.IOController.ComponentSession(3, this._sessionID, out num, out num2);
				}
			}
			base.UpdateDevice(pbaObject, sessionID);
		}

		// Token: 0x04000020 RID: 32
		private int _WifiInactivityTimer = 60;

		// Token: 0x04000021 RID: 33
		private ushort _sessionID;

		// Token: 0x04000022 RID: 34
		private bool _isEnterProgramMode;
	}
}
