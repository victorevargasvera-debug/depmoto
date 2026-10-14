using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.PCRRemoteProgramming;
using Motorola.Common.Communication.SequenceManager;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200002D RID: 45
	public class PCRRemoteDevice : global::Motorola.Common.Communication.CommunicationManager.MotoDevice
	{
		// Token: 0x06000147 RID: 327 RVA: 0x000072A0 File Offset: 0x000054A0
		internal PCRRemoteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo) : base(deviceInfo, null)
		{
			global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo pcrdeviceInfo = deviceInfo as global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo;
			if (pcrdeviceInfo != null)
			{
				this.IsMasterRepeater = pcrdeviceInfo.Master;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000072CC File Offset: 0x000054CC
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			ushort result = base.OpenSession(operationType, sessionParameter);
			if (!this.AuthenticationIsPass)
			{
				string password = global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.REMOTE_DEFAULT_PASSWORD;
				if (this.DeviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_Material != null && this.DeviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_Material != string.Empty)
				{
					password = this.DeviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_Material;
				}
				this.AuthenticationIsPass = this.ValidateRemotePassword(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.REMOTE_USERNAME, password);
				if (sessionParameter != null && !this.AuthenticationIsPass)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.PasswordValidationFails);
				}
			}
			return result;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00007368 File Offset: 0x00005568
		public override void CloseSession(bool pendingDeploy)
		{
			try
			{
				base.CloseSession(pendingDeploy);
			}
			finally
			{
				this.AuthenticationIsPass = false;
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00007398 File Offset: 0x00005598
		public bool ValidateRemotePassword(string username, string password)
		{
			if (!this.AuthenticationIsPass)
			{
				global::Motorola.Common.Communication.SequenceManager.PCRRPSequenceManager pcrrpsequenceManager = base.SequenceManager as global::Motorola.Common.Communication.SequenceManager.PCRRPSequenceManager;
				if (pcrrpsequenceManager != null)
				{
					this.AuthenticationIsPass = pcrrpsequenceManager.ValidateRemotePassword(username, password);
					if (this.AuthenticationIsPass)
					{
						pcrrpsequenceManager.AssembleRPCommPipeForNormalOps();
					}
				}
				else
				{
					global::Motorola.Common.Communication.SequenceManager.PCRRPFileSequenceManager pcrrpfileSequenceManager = base.SequenceManager as global::Motorola.Common.Communication.SequenceManager.PCRRPFileSequenceManager;
					if (pcrrpfileSequenceManager != null)
					{
						this.AuthenticationIsPass = pcrrpfileSequenceManager.ValidateRemotePassword(username, password);
						if (this.AuthenticationIsPass)
						{
							pcrrpfileSequenceManager.AssembleRPCommPipeForNormalOps();
						}
					}
				}
			}
			return this.AuthenticationIsPass;
		}

		// Token: 0x04000049 RID: 73
		private bool AuthenticationIsPass;

		// Token: 0x0400004A RID: 74
		private bool IsMasterRepeater;
	}
}
