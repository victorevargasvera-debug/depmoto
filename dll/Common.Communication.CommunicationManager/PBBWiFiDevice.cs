using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200001D RID: 29
	internal class PBBWiFiDevice : global::Motorola.Common.Communication.CommunicationManager.WiFiDevice
	{
		// Token: 0x060000DD RID: 221 RVA: 0x0000554D File Offset: 0x0000374D
		public PBBWiFiDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile) : base(deviceInfo, profile)
		{
			this.deviceTimer = new global::System.Timers.Timer(3600000.0);
			this.InitializeDeviceTimer(this.deviceConnectDurationTimer);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000559C File Offset: 0x0000379C
		private void InitializeDeviceTimer(int duration)
		{
			if (this.deviceTimer != null)
			{
				this.deviceTimer.Stop();
				this.deviceTimer.Close();
			}
			this.deviceTimer = new global::System.Timers.Timer((double)(duration * 60000));
			this.deviceTimer.AutoReset = false;
			this.deviceTimer.Elapsed += delegate(object sender, global::System.Timers.ElapsedEventArgs args)
			{
				this.deviceTimer_Elapsed(sender, duration);
			};
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005618 File Offset: 0x00003818
		private void deviceTimer_Elapsed(object sender, int duration)
		{
			this.deviceTimer.Stop();
			double totalMilliseconds = global::System.DateTime.Now.Subtract(this.startedTime).TotalMilliseconds;
			if (duration * 60000 - (int)totalMilliseconds > 1000)
			{
				this.deviceTimer.Interval -= totalMilliseconds;
				this.deviceTimer.Start();
				return;
			}
			global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector>.Instance().DetachDevice(base.RadioProfile.RadioIdString);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005694 File Offset: 0x00003894
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			if (base.RadioProfile != null)
			{
				base.RefreshIPAddress();
				this.DeviceInfo.ConnectionInfo.AuthInfoList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo>();
				global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo authenticationInfo = new global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo();
				authenticationInfo.AuthType = global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PasswordIndex;
				authenticationInfo.PreSharedKey_ID = (base.RadioProfile as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile).PasswordId;
				authenticationInfo.PreSharedKey_Material = (base.RadioProfile as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile).Password;
				this.DeviceInfo.ConnectionInfo.AuthInfoList.Add(authenticationInfo);
			}
			ushort result = base.OpenSession(operationType, sessionParameter);
			(base.SequenceManager as global::Motorola.Common.Communication.PBBSequenceManager).ReadExtendedDeviceInfo((base.RadioProfile as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile).Password);
			this.deviceTimer.Stop();
			return result;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000574C File Offset: 0x0000394C
		public override void CloseSession(bool pendingDeploy)
		{
			base.ValidateSession();
			try
			{
				base.SequenceManager.CloseSession(base.ActiveSession.ID, base.ActiveSession.OperationType, pendingDeploy);
				if (base.ActiveSession.OperationType == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)
				{
					if (pendingDeploy)
					{
						this.startedTime = global::System.DateTime.Now;
						this.deviceTimer.Start();
					}
					else
					{
						this.Detach();
					}
					try
					{
						(base.SequenceManager as global::Motorola.Common.Communication.PBBSequenceManager).TerminateSession(11, "Session Abort");
						goto IL_C4;
					}
					catch
					{
						goto IL_C4;
					}
				}
				if (base.ActiveSession.OperationType != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
				{
					if (base.ActiveSession.OperationType != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
					{
						goto IL_C4;
					}
				}
				try
				{
					(base.SequenceManager as global::Motorola.Common.Communication.PBBSequenceManager).TerminateSession(10, "Job Complete");
				}
				catch
				{
				}
				this.startedTime = global::System.DateTime.Now;
				this.deviceTimer.Start();
				IL_C4:;
			}
			finally
			{
				base.DisposeSession();
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005850 File Offset: 0x00003A50
		public override void Prefetch()
		{
			if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Attached)
			{
				base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.InitializingDevice);
				new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.PrepareDevice)).Start();
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005878 File Offset: 0x00003A78
		public override void InitDeviceParams()
		{
			this.ReadExtendedDeviceInfo();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005884 File Offset: 0x00003A84
		public override global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = (base.SequenceManager as global::Motorola.Common.Communication.PBBSequenceManager).ReadExtendedDeviceInfo();
			if (extendedDeviceInfo is global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo && this.DeviceInfo is global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo)
			{
				global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo pbbdeviceInfo = extendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).IMEI = pbbdeviceInfo.IMEI;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).ManufacturerName = pbbdeviceInfo.ManufacturerName;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).ProductIdentifier = pbbdeviceInfo.ProductIdentifier;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).InactivityTimer = pbbdeviceInfo.InactivityTimer;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).Staged = pbbdeviceInfo.Staged;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).FirmwareVersion = pbbdeviceInfo.FirmwareVersion;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).ResultCode = pbbdeviceInfo.ResultCode;
				this.DeviceInfo.ModelNumber = pbbdeviceInfo.ModelNumber;
				this.DeviceInfo.SerialNumber = pbbdeviceInfo.SerialNumber;
				this.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.PBBRadio;
				extendedDeviceInfo.Family = this.DeviceInfo.Family;
				extendedDeviceInfo.ConnectionInfo = this.DeviceInfo.ConnectionInfo;
				extendedDeviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			}
			return extendedDeviceInfo;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000059BC File Offset: 0x00003BBC
		private void PrepareDevice()
		{
			base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Connecting);
			bool flag = false;
			while (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Connecting)
			{
				try
				{
					this.OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create, null);
					this.InitDeviceParams();
					flag = true;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Error in InitDeviceParams {0} .", new object[]
					{
						ex.Message
					});
				}
				finally
				{
					try
					{
						if (flag)
						{
							this.SetDeviceConnectDurationTimer();
							this.CloseSession(true);
						}
						else
						{
							this.CloseSession(false);
						}
					}
					catch (global::System.Exception)
					{
					}
				}
				if (flag)
				{
					base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Ready);
					return;
				}
				global::System.Threading.Thread.Sleep(500);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005A74 File Offset: 0x00003C74
		public void SetDeviceConnectDurationTimer()
		{
			string productIdentifier;
			if ((productIdentifier = (this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).ProductIdentifier) != null)
			{
				if (!(productIdentifier == "Si500"))
				{
					return;
				}
				this.InitializeDeviceTimer(3);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005AAA File Offset: 0x00003CAA
		public void Detach()
		{
			this.deviceTimer.Stop();
			global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector>.Instance().DetachDevice(base.RadioProfile.RadioIdString);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005ACC File Offset: 0x00003CCC
		public void StopTimer()
		{
			this.deviceTimer.Stop();
		}

		// Token: 0x0400002E RID: 46
		private const int waitOneTimer = 60000;

		// Token: 0x0400002F RID: 47
		private const int fusionDeviceConnectDurationTimer = 3;

		// Token: 0x04000030 RID: 48
		private global::System.Timers.Timer deviceTimer;

		// Token: 0x04000031 RID: 49
		private int deviceConnectDurationTimer = 60;

		// Token: 0x04000032 RID: 50
		private global::System.DateTime startedTime;
	}
}
