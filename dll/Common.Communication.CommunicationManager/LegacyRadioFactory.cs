using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.SequenceManager;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000050 RID: 80
	public class LegacyRadioFactory : global::Motorola.Common.Communication.CommunicationManager.SingleRadioFactory
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x00008C28 File Offset: 0x00006E28
		public LegacyRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer)
		{
			this._radioCreatorList = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.CommunicationManager.LegacyRadioFactory.SingleLegacyRadioCreator>();
			base.PIDList = new string[]
			{
				"0100",
				"9003"
			};
			this._observer = observer;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00008C6C File Offset: 0x00006E6C
		protected override bool MyCreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			bool result = false;
			radio = null;
			if (hwProfile == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("LegacyRadioFactory.MyCreateRadio: The hwProfile is empty");
				return false;
			}
			if (!(hwProfile is global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile))
			{
				return false;
			}
			if (!hwProfile.PID.Contains("9003") && !hwProfile.PID.Contains("0100"))
			{
				return false;
			}
			try
			{
				global::Motorola.Common.Communication.CommunicationManager.LegacyRadioFactory.SingleLegacyRadioCreator singleLegacyRadioCreator = null;
				lock (this._radioCreatorList)
				{
					if (!this._radioCreatorList.ContainsKey(hwProfile.PhysicalLocation))
					{
						singleLegacyRadioCreator = new global::Motorola.Common.Communication.CommunicationManager.LegacyRadioFactory.SingleLegacyRadioCreator();
						this._radioCreatorList.Add(hwProfile.PhysicalLocation, singleLegacyRadioCreator);
					}
					else
					{
						singleLegacyRadioCreator = this._radioCreatorList[hwProfile.PhysicalLocation];
					}
				}
				radio = singleLegacyRadioCreator.CreateRadio(hwProfile);
				if (radio != null && global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active)
				{
					radio.SynPrepareDevice();
				}
				result = (radio != null);
			}
			catch (global::System.Exception e)
			{
				radio = null;
				result = false;
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, (hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "LegacyRadioFactory.CreateRadio: Got exception", new object[0]);
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(hwProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "LegacyRadioFactory.CreateRadio: Got exception");
			}
			return result;
		}

		// Token: 0x0400005C RID: 92
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.CommunicationManager.LegacyRadioFactory.SingleLegacyRadioCreator> _radioCreatorList;

		// Token: 0x0400005D RID: 93
		private global::Motorola.Common.Communication.CommonUtil.IObserver _observer;

		// Token: 0x02000051 RID: 81
		private class SingleLegacyRadioCreator : global::System.IDisposable
		{
			// Token: 0x060001C5 RID: 453 RVA: 0x00008DB0 File Offset: 0x00006FB0
			public SingleLegacyRadioCreator()
			{
				this._createUtility = new global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility();
				this._resetTimer = new global::System.Timers.Timer();
				this._resetTimer.Interval = (double)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.DOWNLOAD_KERNEL_RESET_TIMEOUT;
				this._resetTimer.Elapsed += this._resetTimer_Elapsed;
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x00008E0C File Offset: 0x0000700C
			public global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.IRadioProfile hwProfile)
			{
				global::Motorola.Common.Communication.IMotoDevice result = null;
				if (hwProfile == null)
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("SingleLegacyRadioCreator.CreateRadio: The hwProfile is empty");
					return result;
				}
				global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice tetraVComDevice = this.newOneTetraVComDevice();
				this.OnAttach(hwProfile, tetraVComDevice);
				if (this._radioReady)
				{
					hwProfile.RadioId = global::System.Text.Encoding.ASCII.GetBytes(hwProfile.PhysicalLocation);
					tetraVComDevice.Profile = hwProfile;
					tetraVComDevice.DeviceInfo.RadioID = hwProfile.PhysicalLocation;
					tetraVComDevice.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Attached);
					result = tetraVComDevice;
				}
				return result;
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x00008E85 File Offset: 0x00007085
			private void UpdateRadioFamilyAccordingToPid(string pid, global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice radio)
			{
				if (pid.Contains("9003"))
				{
					radio.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyProgRadio;
					return;
				}
				if (pid.Contains("0100"))
				{
					radio.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyAppRadio;
				}
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00008EC4 File Offset: 0x000070C4
			private void OnAttach(global::Motorola.Common.Communication.IRadioProfile hwProfile, global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice radio)
			{
				lock (this._stateLockObj)
				{
					this._resetTimer.Enabled = false;
					this._radioReady = false;
					bool flag2 = false;
					radio.DeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM;
					this.UpdateRadioFamilyAccordingToPid(hwProfile.PID, radio);
					this._radioReady = this._createUtility.CreateSingleLegacyRadio(radio, hwProfile, false, ref this._state, out flag2);
					if (this._state == global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.INIT)
					{
						this._resetTimer.Enabled = true;
					}
				}
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x00008F68 File Offset: 0x00007168
			private void OnTimeout()
			{
				lock (this._stateLockObj)
				{
					this._radioReady = false;
					this._state = global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.IDLE;
				}
			}

			// Token: 0x060001CA RID: 458 RVA: 0x00008FB4 File Offset: 0x000071B4
			private void _resetTimer_Elapsed(object sender, global::System.Timers.ElapsedEventArgs e)
			{
				this._resetTimer.Enabled = false;
				this.OnTimeout();
			}

			// Token: 0x060001CB RID: 459 RVA: 0x00008FC8 File Offset: 0x000071C8
			private global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice newOneTetraVComDevice()
			{
				return new global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice();
			}

			// Token: 0x060001CC RID: 460 RVA: 0x00008FD0 File Offset: 0x000071D0
			protected virtual void Dispose(bool disposing)
			{
				if (this._disposed)
				{
					return;
				}
				try
				{
					if (disposing && this._resetTimer != null)
					{
						this._resetTimer.Close();
						this._resetTimer = null;
					}
				}
				finally
				{
					this._disposed = true;
				}
			}

			// Token: 0x060001CD RID: 461 RVA: 0x00009020 File Offset: 0x00007220
			public void Dispose()
			{
				this.Dispose(true);
				global::System.GC.SuppressFinalize(this);
			}

			// Token: 0x0400005E RID: 94
			private global::System.Timers.Timer _resetTimer;

			// Token: 0x0400005F RID: 95
			private volatile bool _radioReady;

			// Token: 0x04000060 RID: 96
			private global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState _state;

			// Token: 0x04000061 RID: 97
			private object _stateLockObj = new object();

			// Token: 0x04000062 RID: 98
			private global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility _createUtility;

			// Token: 0x04000063 RID: 99
			private bool _disposed;
		}
	}
}
