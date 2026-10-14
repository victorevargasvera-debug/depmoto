using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000005 RID: 5
	public abstract class PnPDeviceDetectorBase : global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector, global::System.IDisposable
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020D8 File Offset: 0x000002D8
		private protected global::System.Collections.ArrayList _currentExistDevice
		{
			protected get
			{
				return this.currentExistDevice;
			}
			private set
			{
				this.currentExistDevice = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020E1 File Offset: 0x000002E1
		protected global::System.Collections.Generic.List<global::System.Guid> lstValidGuid
		{
			get
			{
				return this._lstValidGuid;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000020E9 File Offset: 0x000002E9
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000020F1 File Offset: 0x000002F1
		protected global::System.Guid _devClass
		{
			get
			{
				return this.devClass;
			}
			set
			{
				this.devClass = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000020FA File Offset: 0x000002FA
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002102 File Offset: 0x00000302
		protected global::System.Guid _radioClass
		{
			get
			{
				return this.radioClass;
			}
			set
			{
				this.radioClass = value;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000210C File Offset: 0x0000030C
		protected PnPDeviceDetectorBase()
		{
			this._deviceNotifyHandle = global::System.IntPtr.Zero;
			this._bThreadEnd = false;
			this._disposed = false;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002165 File Offset: 0x00000365
		public global::System.Collections.Generic.List<string> DeviceGUIDList
		{
			get
			{
				return this._deviceGUIDList;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000216D File Offset: 0x0000036D
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002175 File Offset: 0x00000375
		public global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType DetectorType
		{
			get
			{
				return this._detectorType;
			}
			protected set
			{
				this._detectorType = value;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002180 File Offset: 0x00000380
		public bool Start()
		{
			bool result = true;
			this.InitForWinForm();
			if (global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase._initFailed)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000219F File Offset: 0x0000039F
		public void Stop()
		{
			this._bThreadEnd = true;
			this._myPnPNotifier.Set();
			this.Dispose();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000021BA File Offset: 0x000003BA
		internal void WndProc(ref global::System.Windows.Forms.Message m)
		{
			if (m.Msg == 537)
			{
				this.BaseWndProc(ref m);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000021D0 File Offset: 0x000003D0
		private void BaseWndProc(ref global::System.Windows.Forms.Message m)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg();
			int num = m.WParam.ToInt32();
			if (num != 32768)
			{
				if (num != 32772)
				{
					return;
				}
				if (m.LParam != global::System.IntPtr.Zero)
				{
					if (((global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_HDR)global::System.Runtime.InteropServices.Marshal.PtrToStructure(m.LParam, typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_HDR))).dbcc_devicetype == 2U)
					{
						global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_VOLUME dev_BROADCAST_VOLUME = (global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_VOLUME)global::System.Runtime.InteropServices.Marshal.PtrToStructure(m.LParam, typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_VOLUME));
						if (dev_BROADCAST_VOLUME.dbcv_flags == 0)
						{
							this.DeviceChanged(new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg
							{
								m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached,
								sDeviceName = dev_BROADCAST_VOLUME.dbcv_unitmask.ToString(),
								isVolume = true
							});
							return;
						}
					}
					else
					{
						global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE dev_BROADCAST_DEVICEINTERFACE = (global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE)global::System.Runtime.InteropServices.Marshal.PtrToStructure(m.LParam, typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE));
						if (this.IsValidGuiid(dev_BROADCAST_DEVICEINTERFACE.dbcc_classguid) && dev_BROADCAST_DEVICEINTERFACE.dbcc_classguid == this._devClass)
						{
							originalPnPMsg.m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached;
							originalPnPMsg.sDeviceName = dev_BROADCAST_DEVICEINTERFACE.dbcc_name;
							this.DeviceChanged(originalPnPMsg);
						}
					}
				}
			}
			else if (m.LParam != global::System.IntPtr.Zero)
			{
				if (((global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_HDR)global::System.Runtime.InteropServices.Marshal.PtrToStructure(m.LParam, typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_HDR))).dbcc_devicetype == 2U)
				{
					global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_VOLUME dev_BROADCAST_VOLUME2 = (global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_VOLUME)global::System.Runtime.InteropServices.Marshal.PtrToStructure(m.LParam, typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_VOLUME));
					if (dev_BROADCAST_VOLUME2.dbcv_flags == 0)
					{
						this.DeviceChanged(new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg
						{
							m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached,
							sDeviceName = dev_BROADCAST_VOLUME2.dbcv_unitmask.ToString(),
							isVolume = true
						});
						return;
					}
				}
				else
				{
					global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE dev_BROADCAST_DEVICEINTERFACE = (global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE)global::System.Runtime.InteropServices.Marshal.PtrToStructure(m.LParam, typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE));
					if (this.IsValidGuiid(dev_BROADCAST_DEVICEINTERFACE.dbcc_classguid))
					{
						this._devClass = dev_BROADCAST_DEVICEINTERFACE.dbcc_classguid;
						originalPnPMsg.m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached;
						originalPnPMsg.sDeviceName = dev_BROADCAST_DEVICEINTERFACE.dbcc_name;
						this.DeviceChanged(originalPnPMsg);
						return;
					}
				}
			}
		}

		// Token: 0x06000020 RID: 32
		protected abstract void HandleDeviceAttached(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg);

		// Token: 0x06000021 RID: 33
		protected abstract void HandleDeviceDetached(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg);

		// Token: 0x06000022 RID: 34
		protected abstract bool ExtractRadioInformationHelper(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg, ref global::Motorola.Common.Communication.IRadioProfile radioInfo);

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000023DC File Offset: 0x000005DC
		protected global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper NativeAPISet
		{
			get
			{
				return this._nativeAPISet;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000023E4 File Offset: 0x000005E4
		private void TerminatePnPMsgThread()
		{
			this._bThreadEnd = true;
			if (!global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase._initFailed)
			{
				this._myPnPNotifier.Set();
				this._myPnPThreadEnd.WaitOne(100, false);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002410 File Offset: 0x00000610
		private void ProcessPnPMsgThread()
		{
			try
			{
				global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg();
				this.ScanAlreadyExistDevices(out this._alreadyExistDevSet);
				for (int i = 0; i < this._alreadyExistDevSet.Count; i++)
				{
					this._myDPCPnPMessage.Add(this._alreadyExistDevSet[i]);
				}
				if (this._alreadyExistDevSet.Count > 0)
				{
					this._myPnPNotifier.Set();
				}
				do
				{
					this._myPnPNotifier.WaitOne();
					if (this._bThreadEnd)
					{
						break;
					}
					lock (this._originalPnPMessage.SyncRoot)
					{
						for (int j = 0; j < this._originalPnPMessage.Count; j++)
						{
							this._myDPCPnPMessage.Add(this._originalPnPMessage[j]);
						}
						this._originalPnPMessage.Clear();
					}
					int num = 0;
					while (num < this._myDPCPnPMessage.Count && !this._bThreadEnd)
					{
						originalPnPMsg = (global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg)this._myDPCPnPMessage[num];
						if (originalPnPMsg.m_DeviceAction == global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached)
						{
							global::System.Diagnostics.Trace.WriteLine("Received An Attaching Message!");
							try
							{
								this.HandleDeviceAttached(originalPnPMsg);
								goto IL_16F;
							}
							catch (global::System.Exception arg)
							{
								global::System.Diagnostics.Trace.WriteLine("Exception in DeviceDetectorBase::ProcessPnPMsgThread: " + arg);
								goto IL_16F;
							}
							goto IL_125;
						}
						goto IL_125;
						IL_16F:
						if (!this._bThreadEnd)
						{
							num++;
							continue;
						}
						break;
						IL_125:
						if (originalPnPMsg.m_DeviceAction == global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached)
						{
							global::System.Diagnostics.Trace.WriteLine("Received An Detaching Message!");
							try
							{
								this.HandleDeviceDetached(originalPnPMsg);
								goto IL_16F;
							}
							catch (global::System.Exception arg2)
							{
								global::System.Diagnostics.Trace.WriteLine("Exception in DeviceDetectorBase::ProcessPnPMsgThread: " + arg2);
								goto IL_16F;
							}
						}
						string format = "Received An Unclean PnP Message!";
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(format, new object[0]);
						goto IL_16F;
					}
					this._myDPCPnPMessage.Clear();
				}
				while (!this._bThreadEnd);
				if (this._myPnPThreadEnd != null)
				{
					this._myPnPThreadEnd.Set();
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000263C File Offset: 0x0000083C
		private void InitForWinForm()
		{
			try
			{
				this.winThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.BackgroundWinFormInitThread));
				this.winThread.Start();
				this._initIsFinished.WaitOne(5000, false);
			}
			catch (global::System.TimeoutException ex)
			{
				string text = "Initialization process is timeout";
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception: {0}; Message: {1}", new object[]
				{
					ex,
					text
				});
				global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase._initFailed = true;
			}
			catch (global::System.Exception ex2)
			{
				string text2 = "Initialization process met exception";
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception: {0}; Message: {1}", new object[]
				{
					ex2,
					text2
				});
				global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase._initFailed = true;
			}
		}

		// Token: 0x06000027 RID: 39
		protected abstract void InitDevClassGUIDList();

		// Token: 0x06000028 RID: 40 RVA: 0x00002700 File Offset: 0x00000900
		private void BackgroundWinFormInitThread()
		{
			this._myPnPMsgWnd = new global::Motorola.Common.Communication.DeviceDiscovery.PnPMsgWnd(this);
			this._recipientHandle = this._myPnPMsgWnd.Handle;
			if (this.lstValidGuid.Count == 0)
			{
				this.InitDevClassGUIDList();
			}
			global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.PnPMsgSource source = global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.PnPMsgSource.Window;
			bool flag = this.RegisterPnPMsgFilter(source);
			if (!flag)
			{
				string text = "Failed to register pnp message filter --- ";
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Error Message: {0}", new object[]
				{
					text
				});
				global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase._initFailed = true;
				this._initIsFinished.Set();
			}
			if (flag)
			{
				this.InitMoreResources();
				this._initIsFinished.Set();
				global::System.Windows.Forms.Application.Run(this._myPnPMsgWnd);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000027A0 File Offset: 0x000009A0
		private void InitMoreResources()
		{
			this._originalPnPMessage = new global::System.Collections.ArrayList();
			this._myDPCPnPMessage = new global::System.Collections.ArrayList();
			this._currentExistDevice = new global::System.Collections.ArrayList();
			this._myPnPNotifier = new global::System.Threading.AutoResetEvent(false);
			this._myPnPThreadEnd = new global::System.Threading.AutoResetEvent(false);
			this._pnpProcDelegate = new global::Motorola.Common.Communication.DeviceDiscovery.PnPMessageProcesser(this.ProcessPnPMsgThread);
			this._pnpProcDelegate.BeginInvoke(null, null);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002808 File Offset: 0x00000A08
		private bool RegisterPnPMsgFilter(global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.PnPMsgSource source)
		{
			bool result = true;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE structure = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE);
			int num = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE));
			structure.dbcc_size = (uint)num;
			structure.dbcc_devicetype = 5U;
			structure.dbcc_classguid = this._radioClass;
			structure.dbcc_reserved = 0U;
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			try
			{
				intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(num);
				global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE>(structure, intPtr, false);
				if (source == global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.PnPMsgSource.Window)
				{
					result = this.NativeAPISet.WrapperRegisterDeviceNotification(this._recipientHandle, intPtr, 0U, ref this._deviceNotifyHandle);
				}
				else
				{
					result = this.NativeAPISet.WrapperRegisterDeviceNotification(this._recipientHandle, intPtr, 1U, ref this._deviceNotifyHandle);
				}
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			finally
			{
				if (intPtr != global::System.IntPtr.Zero)
				{
					global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
				}
			}
			return result;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000028DC File Offset: 0x00000ADC
		private bool UnRegisterForReceivePnPMsg()
		{
			bool result = true;
			if (this._deviceNotifyHandle != global::System.IntPtr.Zero)
			{
				result = this.NativeAPISet.WrapperUnregisterDeviceNotification(this._deviceNotifyHandle);
				this._deviceNotifyHandle = global::System.IntPtr.Zero;
			}
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000291C File Offset: 0x00000B1C
		protected static string GetDevCurrentLocationFromDevName(string dbcc_name)
		{
			int num = dbcc_name.IndexOf('#');
			num = dbcc_name.IndexOf('#', num + 1);
			int num2 = dbcc_name.IndexOf('#', num + 1);
			return dbcc_name.Substring(num + 1, num2 - num - 1);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000295C File Offset: 0x00000B5C
		protected static string GetPhysicalLocationFromDeviceInstance(string instance_id)
		{
			int num = instance_id.IndexOf('\\');
			num = instance_id.IndexOf('\\', num + 1);
			return instance_id.Substring(num + 1);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002989 File Offset: 0x00000B89
		private void ScanAlreadyExistDevices(out global::System.Collections.ArrayList alreadyExistDevSet)
		{
			alreadyExistDevSet = new global::System.Collections.ArrayList();
			this.ScanAlreadyExistDevices(alreadyExistDevSet, this._radioClass);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000029A0 File Offset: 0x00000BA0
		private void ScanAlreadyExistDevices(global::System.Collections.ArrayList alreadyExistDevSet, global::System.Guid deviceGuid)
		{
			bool flag = true;
			global::System.IntPtr zero = global::System.IntPtr.Zero;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA devInfoData = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA);
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA sp_DEVICE_INTERFACE_DATA = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA);
			string text = "";
			string text2 = "\\\\?\\";
			string str = "#{" + deviceGuid.ToString() + "}";
			if (!this.NativeAPISet.WrapperSetupDiGetClassDevs(ref zero, ref deviceGuid, global::System.IntPtr.Zero))
			{
				flag = false;
				if (zero != global::System.IntPtr.Zero)
				{
					this.NativeAPISet.WrapperSetupDiDestroyDeviceInfoList(zero);
				}
			}
			if (flag)
			{
				devInfoData.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVINFO_DATA));
				sp_DEVICE_INTERFACE_DATA.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.SP_DEVICE_INTERFACE_DATA));
			}
			if (flag)
			{
				int num = 0;
				while (this.NativeAPISet.WrapperSetupDiEnumDeviceInterfaces(zero, (uint)num, ref sp_DEVICE_INTERFACE_DATA, ref deviceGuid))
				{
					int num2 = 0;
					uint num3 = 0U;
					if (this.NativeAPISet.WrapperSetupDiGetDeviceInterfaceDetail(zero, ref sp_DEVICE_INTERFACE_DATA, global::System.IntPtr.Zero, 0U, out num3, ref devInfoData, out num2) && this.NativeAPISet.WrapperSetupDiGetDeviceInstanceId(zero, devInfoData, ref text, 1024) && this.IsValidGuiid(deviceGuid))
					{
						text = text.Replace('\\', '#');
						string text3 = text2;
						text3 += text;
						text3 += str;
						alreadyExistDevSet.Add(new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg
						{
							sDeviceName = text3,
							m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached,
							isPreAttached = true
						});
					}
					num++;
				}
			}
			this.NativeAPISet.WrapperSetupDiDestroyDeviceInfoList(zero);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002B1B File Offset: 0x00000D1B
		protected virtual bool ExtractRadioInformation(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg, ref global::Motorola.Common.Communication.IRadioProfile radioInfo)
		{
			if (orgPnPMsg.isVolume)
			{
				return false;
			}
			if (!orgPnPMsg.isSimulated)
			{
				return this.ExtractRadioInformationHelper(orgPnPMsg, ref radioInfo);
			}
			if (orgPnPMsg.radioProfile != null)
			{
				radioInfo = orgPnPMsg.radioProfile;
				return true;
			}
			return false;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002B4C File Offset: 0x00000D4C
		public virtual bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg)
		{
			lock (this._originalPnPMessage.SyncRoot)
			{
				this._originalPnPMessage.Add(pnpMsg);
			}
			this._myPnPNotifier.Set();
			return true;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002BA8 File Offset: 0x00000DA8
		private bool IsValidGuiid(global::System.Guid id)
		{
			return this.lstValidGuid.Contains(id);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002BBB File Offset: 0x00000DBB
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002BCC File Offset: 0x00000DCC
		protected virtual void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			try
			{
				if (disposing)
				{
					if (this._myPnPNotifier != null)
					{
						this._myPnPNotifier.Close();
						this._myPnPNotifier = null;
					}
					if (this._myPnPThreadEnd != null)
					{
						this._myPnPThreadEnd.Close();
						this._myPnPThreadEnd = null;
					}
					if (this._initIsFinished != null)
					{
						this._initIsFinished.Close();
						this._initIsFinished = null;
					}
					if (this._myPnPMsgWnd != null)
					{
						this.ClosePnPMsgWnd();
						this._myPnPMsgWnd = null;
					}
				}
			}
			finally
			{
				this._disposed = true;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002C64 File Offset: 0x00000E64
		private void ClosePnPMsgWnd()
		{
			if (this._myPnPMsgWnd.InvokeRequired)
			{
				global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.PnPWndCloseCallback method = new global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.PnPWndCloseCallback(this.ClosePnPMsgWnd);
				this._myPnPMsgWnd.BeginInvoke(method);
				return;
			}
			this._myPnPMsgWnd.Close();
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000036 RID: 54
		// (remove) Token: 0x06000037 RID: 55
		public abstract event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000038 RID: 56
		// (remove) Token: 0x06000039 RID: 57
		public abstract event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached;

		// Token: 0x04000001 RID: 1
		private global::System.Collections.Generic.List<string> _deviceGUIDList = new global::System.Collections.Generic.List<string>();

		// Token: 0x04000002 RID: 2
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType _detectorType;

		// Token: 0x04000003 RID: 3
		private global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper _nativeAPISet = new global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper();

		// Token: 0x04000004 RID: 4
		private global::Motorola.Common.Communication.DeviceDiscovery.PnPMsgWnd _myPnPMsgWnd;

		// Token: 0x04000005 RID: 5
		private global::System.IntPtr _deviceNotifyHandle;

		// Token: 0x04000006 RID: 6
		private global::System.IntPtr _recipientHandle;

		// Token: 0x04000007 RID: 7
		private static bool _initFailed;

		// Token: 0x04000008 RID: 8
		private bool _disposed;

		// Token: 0x04000009 RID: 9
		private global::System.Collections.ArrayList _alreadyExistDevSet;

		// Token: 0x0400000A RID: 10
		private global::System.Collections.ArrayList _originalPnPMessage;

		// Token: 0x0400000B RID: 11
		private global::System.Collections.ArrayList _myDPCPnPMessage;

		// Token: 0x0400000C RID: 12
		private global::System.Collections.ArrayList currentExistDevice;

		// Token: 0x0400000D RID: 13
		private global::System.Collections.Generic.List<global::System.Guid> _lstValidGuid = new global::System.Collections.Generic.List<global::System.Guid>();

		// Token: 0x0400000E RID: 14
		private global::System.Guid devClass;

		// Token: 0x0400000F RID: 15
		private global::System.Guid radioClass;

		// Token: 0x04000010 RID: 16
		private global::System.Threading.AutoResetEvent _myPnPNotifier;

		// Token: 0x04000011 RID: 17
		private global::Motorola.Common.Communication.DeviceDiscovery.PnPMessageProcesser _pnpProcDelegate;

		// Token: 0x04000012 RID: 18
		private bool _bThreadEnd;

		// Token: 0x04000013 RID: 19
		private global::System.Threading.Thread winThread;

		// Token: 0x04000014 RID: 20
		private global::System.Threading.AutoResetEvent _myPnPThreadEnd;

		// Token: 0x04000015 RID: 21
		private global::System.Threading.AutoResetEvent _initIsFinished = new global::System.Threading.AutoResetEvent(false);

		// Token: 0x02000006 RID: 6
		private enum PnPMsgSource
		{
			// Token: 0x04000017 RID: 23
			Window,
			// Token: 0x04000018 RID: 24
			Service
		}

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600003C RID: 60
		private delegate void PnPWndCloseCallback();
	}
}
