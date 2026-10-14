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
	// Token: 0x02000053 RID: 83
	public class NGCHPairedRadiosFactory : global::Motorola.Common.Communication.CommunicationManager.PairedRadiosFactory
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x000091A8 File Offset: 0x000073A8
		public NGCHPairedRadiosFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer)
		{
			this._radioCreatorList = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.CommunicationManager.NGCHPairedRadiosFactory.NGCHPairedCreator>();
			base.PIDList = new string[]
			{
				"9006"
			};
			this._observer = observer;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000091E4 File Offset: 0x000073E4
		protected override bool MyCreateRadio(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> radioList, global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> profileList)
		{
			bool result = false;
			radioList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>();
			if (profileList == null)
			{
				global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("NGCHPairedRadios.MyCreateRadio: The profileList is empty");
				return false;
			}
			if (!profileList[0].PID.Contains("9006") || !profileList[1].PID.Contains("9006"))
			{
				return false;
			}
			string uniqueLocation = profileList[1].UniqueLocation;
			try
			{
				global::Motorola.Common.Communication.CommunicationManager.NGCHPairedRadiosFactory.NGCHPairedCreator ngchpairedCreator = null;
				lock (this._radioCreatorList)
				{
					if (!this._radioCreatorList.ContainsKey(uniqueLocation))
					{
						ngchpairedCreator = new global::Motorola.Common.Communication.CommunicationManager.NGCHPairedRadiosFactory.NGCHPairedCreator();
						this._radioCreatorList.Add(uniqueLocation, ngchpairedCreator);
					}
					else
					{
						ngchpairedCreator = this._radioCreatorList[uniqueLocation];
					}
				}
				radioList = ngchpairedCreator.CreateRadio(profileList);
				foreach (global::Motorola.Common.Communication.IMotoDevice motoDevice in radioList)
				{
					if (global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass.Instance.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active)
					{
						motoDevice.SynPrepareDevice();
					}
				}
				result = (radioList.Count != 0);
			}
			catch (global::System.Exception e)
			{
				radioList = null;
				result = false;
				foreach (global::Motorola.Common.Communication.IRadioProfile radioProfile in profileList)
				{
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, (radioProfile as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).Path, "NGCHPairedRadios.CreateRadio: Got exception", new object[0]);
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(radioProfile.PhysicalLocation, global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "NGCHPairedRadios.CreateRadio: Got exception");
				}
			}
			return result;
		}

		// Token: 0x04000065 RID: 101
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.CommunicationManager.NGCHPairedRadiosFactory.NGCHPairedCreator> _radioCreatorList;

		// Token: 0x04000066 RID: 102
		private global::Motorola.Common.Communication.CommonUtil.IObserver _observer;

		// Token: 0x02000054 RID: 84
		private class NGCHPairedCreator : global::System.IDisposable
		{
			// Token: 0x060001D3 RID: 467 RVA: 0x000093A4 File Offset: 0x000075A4
			public NGCHPairedCreator()
			{
				this._createUtility = new global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility();
				this._resetTimer = new global::System.Timers.Timer();
				this._resetTimer.Interval = (double)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.DOWNLOAD_KERNEL_RESET_TIMEOUT;
				this._resetTimer.Elapsed += this._resetTimer_Elapsed;
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x00009400 File Offset: 0x00007600
			public global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> CreateRadio(global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> profileList)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.IMotoDevice>();
				if (profileList == null)
				{
					global::Motorola.Common.Communication.SequenceManager.CommLoggerManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error("NGCHPairedCreator.CreateRadio: The profileList is empty");
					return list;
				}
				global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice tetraVComDevice = this.newOneTetraVComDevice();
				global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice tetraVComDevice2 = this.newOneTetraVComDevice();
				this.OnAttach(profileList, tetraVComDevice, tetraVComDevice2);
				if (this._chRadioReady)
				{
					tetraVComDevice.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Attached);
					list.Add(tetraVComDevice);
				}
				if (this._trRadioReady)
				{
					tetraVComDevice2.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Attached);
					list.Add(tetraVComDevice2);
				}
				return list;
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x00009474 File Offset: 0x00007674
			private void OnAttach(global::System.Collections.Generic.List<global::Motorola.Common.Communication.IRadioProfile> hwProfileList, global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice chRadio, global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice trRadio)
			{
				lock (this._stateLockObj)
				{
					chRadio.DeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM;
					trRadio.DeviceInfo.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.VCOM;
					this._resetTimer.Enabled = false;
					this._chRadioReady = false;
					this._trRadioReady = false;
					global::Motorola.Common.Communication.IRadioProfile radioProfile = null;
					global::Motorola.Common.Communication.IRadioProfile radioProfile2 = null;
					for (int i = 0; i < hwProfileList.Count; i++)
					{
						if ((hwProfileList[i] as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).TetraRadioType == global::Motorola.Common.Communication.CommonUtil.TetraRadioType.CONTROL_HEAD)
						{
							radioProfile2 = hwProfileList[i];
						}
						else if ((hwProfileList[i] as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).TetraRadioType == global::Motorola.Common.Communication.CommonUtil.TetraRadioType.TRANSCEIVER)
						{
							radioProfile = hwProfileList[i];
						}
					}
					bool flag2 = false;
					this._chRadioReady = this._createUtility.CreateSingleLegacyRadio(chRadio, radioProfile2, true, ref this._state, out flag2);
					if (this._chRadioReady)
					{
						radioProfile2.RadioId = global::System.Text.Encoding.ASCII.GetBytes(radioProfile2.PhysicalLocation);
						chRadio.Profile = radioProfile2;
						chRadio.DeviceInfo.RadioID = radioProfile2.PhysicalLocation;
						if (chRadio.Profile.DeviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL)
						{
							chRadio.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyAppRadio;
						}
						else if (chRadio.Profile.DeviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL)
						{
							chRadio.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyProgRadio;
						}
					}
					if (flag2)
					{
						(radioProfile2 as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).PairedActiveRadioType = global::Motorola.Common.Communication.CommonUtil.ActiveTransRadioType.NotAvailble;
					}
					if (this._chRadioReady && !flag2)
					{
						if (chRadio.Profile.DeviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL)
						{
							radioProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL;
						}
						else
						{
							radioProfile.DeviceMode = global::Motorola.Common.Communication.CommonUtil.DeviceMode.UNKNOWN;
						}
						bool flag3 = false;
						this._trRadioReady = this._createUtility.CreateTransRadioPairedWithCH(trRadio, radioProfile, out flag3);
						if (this._trRadioReady)
						{
							radioProfile.RadioId = global::System.Text.Encoding.ASCII.GetBytes(radioProfile.PhysicalLocation);
							trRadio.Profile = radioProfile;
							trRadio.DeviceInfo.RadioID = radioProfile.PhysicalLocation;
							if (flag3)
							{
								(radioProfile2 as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).PairedActiveRadioType = global::Motorola.Common.Communication.CommonUtil.ActiveTransRadioType.FrodoRadio;
								trRadio.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.FrodoProgRadio;
							}
							else
							{
								if (trRadio.Profile.DeviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.NORMAL)
								{
									trRadio.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyAppRadio;
								}
								else if (trRadio.Profile.DeviceMode == global::Motorola.Common.Communication.CommonUtil.DeviceMode.KERNEL)
								{
									trRadio.DeviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.LegacyProgRadio;
								}
								(radioProfile2 as global::Motorola.Common.Communication.DeviceDiscovery.TetraRadioProfile).PairedActiveRadioType = global::Motorola.Common.Communication.CommonUtil.ActiveTransRadioType.LegacyRadio;
							}
						}
					}
					if (this._state == global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.INIT)
					{
						this._resetTimer.Enabled = true;
					}
				}
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x000096F8 File Offset: 0x000078F8
			private void OnTimeout()
			{
				lock (this._stateLockObj)
				{
					this._chRadioReady = false;
					this._trRadioReady = false;
					this._state = global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState.IDLE;
				}
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x0000974C File Offset: 0x0000794C
			private void _resetTimer_Elapsed(object sender, global::System.Timers.ElapsedEventArgs e)
			{
				this._resetTimer.Enabled = false;
				this.OnTimeout();
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x00009760 File Offset: 0x00007960
			private global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice newOneTetraVComDevice()
			{
				return new global::Motorola.Common.Communication.CommunicationManager.TetraVComDevice();
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x00009768 File Offset: 0x00007968
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

			// Token: 0x060001DA RID: 474 RVA: 0x000097B8 File Offset: 0x000079B8
			public void Dispose()
			{
				this.Dispose(true);
				global::System.GC.SuppressFinalize(this);
			}

			// Token: 0x04000067 RID: 103
			private global::System.Timers.Timer _resetTimer;

			// Token: 0x04000068 RID: 104
			private volatile bool _chRadioReady;

			// Token: 0x04000069 RID: 105
			private volatile bool _trRadioReady;

			// Token: 0x0400006A RID: 106
			private global::Motorola.Common.Communication.CommunicationManager.RadioCreatorState _state;

			// Token: 0x0400006B RID: 107
			private object _stateLockObj = new object();

			// Token: 0x0400006C RID: 108
			private global::Motorola.Common.Communication.CommunicationManager.RadioCreatorUtility _createUtility;

			// Token: 0x0400006D RID: 109
			private bool _disposed;
		}
	}
}
