using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000012 RID: 18
	public class TetraFrodoATSeqManager : global::Motorola.Common.Communication.SequenceManager.TetraBMPATSeqManager
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x00011F20 File Offset: 0x00010120
		public TetraFrodoATSeqManager(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe transport, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo) : base(transport, devInfo)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00011F2A File Offset: 0x0001012A
		public override void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			base.SwitchModeNoWait(mode);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00011F34 File Offset: 0x00010134
		public override void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode commandCode, byte[] inputBuffer, out byte[] outputBuffer)
		{
			outputBuffer = null;
			try
			{
				if (commandCode != global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.OPEN_COMMUNICATION_PIPE)
				{
					switch (commandCode)
					{
					case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.AT_RESET_TO_PROGMODE:
					{
						bool rpProg = (bool)base.DeserializeBinary(inputBuffer);
						global::Motorola.Common.Communication.CommonUtil.CommRC commRC = base.ATResetRadioToProgMode(rpProg);
						outputBuffer = base.SerializeBinary(commRC);
						goto IL_6A;
					}
					case global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.CLOSE_COMMUNICATION_PIPE:
						base.ClosePipe();
						goto IL_6A;
					}
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0008_RH_CommErrOperationMode.ToString());
				}
				base.OpenPipe();
				IL_6A:;
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex, (base.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, ex.ErrorID, new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(ex2, (base.Profile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "Generic exception", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(this, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex2, "Generic Error");
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0001_RH_CommErrGeneric.ToString(), "Generic exception", ex2);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00012058 File Offset: 0x00010258
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x000120D0 File Offset: 0x000102D0
		public override string CpuID
		{
			get
			{
				string cpuID;
				lock (base.PropertyLock)
				{
					global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo tetraDeviceInfo = base.DevInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
					if (string.IsNullOrEmpty(tetraDeviceInfo.CpuID))
					{
						tetraDeviceInfo.CpuID = "Fake" + base.Profile.PhysicalLocation;
					}
					cpuID = tetraDeviceInfo.CpuID;
				}
				return cpuID;
			}
			set
			{
				lock (base.PropertyLock)
				{
					global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo tetraDeviceInfo = base.DevInfo as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
					tetraDeviceInfo.CpuID = value;
				}
			}
		}
	}
}
