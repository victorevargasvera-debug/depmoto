using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000005 RID: 5
	public class AstroOTAPFileFlashSeqManager : global::Motorola.Common.Communication.AstroFileFlashSequenceManager
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00003ADB File Offset: 0x00001CDB
		public AstroOTAPFileFlashSeqManager(global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor rcmpWrapper, int inactivityTimer, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
			this._OtapInactivityTimer = inactivityTimer;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
			{
				base.UnlockRadioPartition(0);
				this.EnterWriteProgramMode();
				if (base.SessionParam.ArchiveSession)
				{
					if (!base.DifferentialWriteCapableRadio)
					{
						ushort num;
						ushort num2;
						base.IOController.ComponentSession(7, sessionID, out num, out num2);
						return;
					}
				}
				else
				{
					ushort num;
					ushort num2;
					base.IOController.ComponentSession(3, sessionID, out num, out num2);
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003B50 File Offset: 0x00001D50
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

		// Token: 0x06000042 RID: 66 RVA: 0x00003B84 File Offset: 0x00001D84
		protected override void EnterWriteProgramMode()
		{
			byte[] data = new byte[]
			{
				(byte)(this._OtapInactivityTimer / 256),
				(byte)(this._OtapInactivityTimer & 255)
			};
			base.IOController.EnterProgramMode(4, data);
			((global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003BD8 File Offset: 0x00001DD8
		protected override void ExitWriteProgramMode()
		{
			ushort checksum = ((global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor)base.RcmpWrapper).Checksum;
			byte[] data = new byte[]
			{
				(byte)(checksum / 256),
				(byte)(checksum & 255)
			};
			base.IOController.ExitProgramMode(6, data);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003C24 File Offset: 0x00001E24
		public override void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			if (base.ExtendedDeviceInfo == null || base.ExtendedDeviceInfo.ConnectionInfo == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Device_Connnection_Info_Missing);
			}
			if (base.ExtendedDeviceInfo.ConnectionInfo.OtapConnectionType == global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LTE)
			{
				base.UpdateDevice(pbaObject, sessionID);
				return;
			}
			if (base.ExtendedDeviceInfo.ConnectionInfo.OtapConnectionType == global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LMR && base.SessionParam != null && base.SessionParam.ArchiveSession)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_Astro_Firmware_Upgrade_Failed_Radio_Not_In_LTE_Network);
			}
			if (base.SessionParam == null || !base.SessionParam.ArchiveSession)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Standalone_Not_Supported_LMR_OTAP);
			}
			if (base.ExtendedDeviceInfo.ConnectionInfo.OtapConnectionType == global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.NONE)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Not_Supported_Radio_Firmware);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError);
		}

		// Token: 0x0400001F RID: 31
		private int _OtapInactivityTimer = 180;
	}
}
