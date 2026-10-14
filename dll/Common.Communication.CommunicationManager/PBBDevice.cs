using System;
using System.Threading;
using System.Timers;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000021 RID: 33
	public class PBBDevice : global::Motorola.Common.Communication.CommunicationManager.MotoDevice
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00005E96 File Offset: 0x00004096
		public PBBDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile profile) : base(deviceInfo, profile)
		{
			this.instanceID = profile.InstanceId;
			this.deviceTimer = new global::System.Timers.Timer(3600000.0);
			this.InitializeDeviceTimer(this.deviceConnectDurationTimer);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00005EF0 File Offset: 0x000040F0
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

		// Token: 0x06000102 RID: 258 RVA: 0x00005F6C File Offset: 0x0000416C
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
			global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.Instance.DetachDevice(base.RadioProfile as global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00005FE8 File Offset: 0x000041E8
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			ushort result = base.OpenSession(operationType, sessionParameter);
			global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo pbbdeviceInfo = (base.SequenceManager as global::Motorola.Common.Communication.PBBSequenceManager).ReadExtendedDeviceInfo((base.RadioProfile as global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile).Password) as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo;
			if (operationType == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read || operationType == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
			{
				this.deviceTimer.Stop();
				if (pbbdeviceInfo.SerialNumber != (base.RadioProfile as global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile).UniqueIndendifier)
				{
					this.Detach();
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceInvalid, string.Format("Same ip adress:{0}, but serial number changed to {1}", base.RadioProfile.IPAddress, pbbdeviceInfo.SerialNumber));
				}
			}
			return result;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00006084 File Offset: 0x00004284
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
						goto IL_B9;
					}
					catch
					{
						goto IL_B9;
					}
				}
				if (base.ActiveSession.OperationType != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
				{
					if (base.ActiveSession.OperationType != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
					{
						goto IL_B9;
					}
				}
				try
				{
					(base.SequenceManager as global::Motorola.Common.Communication.PBBSequenceManager).TerminateSession(10, "Job Complete");
				}
				catch
				{
				}
				this.deviceTimer.Start();
				IL_B9:;
			}
			finally
			{
				base.DisposeSession();
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000617C File Offset: 0x0000437C
		public override void Prefetch()
		{
			if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Attached)
			{
				base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.InitializingDevice);
				if (string.IsNullOrEmpty((base.RadioProfile as global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile).UniqueIndendifier))
				{
					new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.PrepareDevice)).Start();
					return;
				}
				base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Ready);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000061CE File Offset: 0x000043CE
		public override void InitDeviceParams()
		{
			this.ReadExtendedDeviceInfo();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000061D8 File Offset: 0x000043D8
		private void PrepareDevice()
		{
			base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Connecting);
			bool flag = false;
			if (this.radioState == global::Motorola.Common.Communication.CommonUtil.RadioState.Connecting)
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
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00006284 File Offset: 0x00004484
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

		// Token: 0x06000109 RID: 265 RVA: 0x000062BC File Offset: 0x000044BC
		public override global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = (base.SequenceManager as global::Motorola.Common.Communication.PBBSequenceManager).ReadExtendedDeviceInfo();
			if (extendedDeviceInfo is global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo && this.DeviceInfo is global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo)
			{
				global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo pbbdeviceInfo = extendedDeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).IMEI = pbbdeviceInfo.IMEI;
				(base.RadioProfile as global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile).UniqueIndendifier = pbbdeviceInfo.SerialNumber;
				this.DeviceInfo.RadioID = pbbdeviceInfo.SerialNumber;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).ManufacturerName = pbbdeviceInfo.ManufacturerName;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).ProductIdentifier = pbbdeviceInfo.ProductIdentifier;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).InactivityTimer = pbbdeviceInfo.InactivityTimer;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).Staged = pbbdeviceInfo.Staged;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).FirmwareVersion = pbbdeviceInfo.FirmwareVersion;
				(this.DeviceInfo as global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo).ResultCode = pbbdeviceInfo.ResultCode;
				this.DeviceInfo.SerialNumber = pbbdeviceInfo.SerialNumber;
				this.DeviceInfo.Family = this.GetProductFamilyFromModelNumber(pbbdeviceInfo.ProductIdentifier);
				extendedDeviceInfo.Family = this.DeviceInfo.Family;
				extendedDeviceInfo.ConnectionInfo = this.DeviceInfo.ConnectionInfo;
				extendedDeviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
			}
			return extendedDeviceInfo;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000640F File Offset: 0x0000460F
		public void RemoveFromCacheCollection()
		{
			this.deviceTimer.Stop();
			global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.Instance.Remove(base.RadioProfile as global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006431 File Offset: 0x00004631
		public void Detach()
		{
			this.deviceTimer.Stop();
			global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.Instance.DetachDevice(base.RadioProfile as global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00006454 File Offset: 0x00004654
		private global::Motorola.Common.Communication.CommonUtil.ProductFamily GetProductFamilyFromModelNumber(string modelNumber)
		{
			switch (modelNumber)
			{
			case "LEX755":
			case "LEX L10":
			case "LEX L10g":
			case "LEX M20":
			case "LEX L10i":
			case "LEX L10ig":
			case "TML M30":
			case "Si300":
			case "Si500":
			case "LTTS-TAB16-CAS":
				return global::Motorola.Common.Communication.CommonUtil.ProductFamily.PBBRadio;
			case "LRX L30":
				return global::Motorola.Common.Communication.CommonUtil.ProductFamily.DenaliRadio;
			}
			throw new global::System.NotSupportedException("Not supported Product Identifier");
		}

		// Token: 0x0400003C RID: 60
		private const int waitOneTimer = 60000;

		// Token: 0x0400003D RID: 61
		private const int fusionDeviceConnectDurationTimer = 3;

		// Token: 0x0400003E RID: 62
		private uint instanceID;

		// Token: 0x0400003F RID: 63
		private global::System.Timers.Timer deviceTimer;

		// Token: 0x04000040 RID: 64
		private int deviceConnectDurationTimer = 60;

		// Token: 0x04000041 RID: 65
		private global::System.DateTime startedTime;
	}
}
