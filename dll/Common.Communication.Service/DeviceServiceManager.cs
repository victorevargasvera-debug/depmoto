using System;
using System.IO;
using Common.Communication.Simulator;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommonUtility;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x0200000C RID: 12
	public class DeviceServiceManager : global::System.IDisposable
	{
		// Token: 0x060001FE RID: 510 RVA: 0x00007310 File Offset: 0x00005510
		private DeviceServiceManager()
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00007318 File Offset: 0x00005518
		public static global::Motorola.Common.Communication.Service.DeviceServiceManager Instance()
		{
			return global::Motorola.Common.Communication.Service.DeviceServiceManager._instance;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00007320 File Offset: 0x00005520
		public global::Motorola.Common.Communication.Service.IDeviceDiscovery GetDeviceDiscoveryService(int deviceFamilySet, global::Motorola.Common.Communication.CommonUtil.WorkMode workMode, global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent discoveryServiceEventCallback)
		{
			if (this._deviceDiscoveryService == null)
			{
				try
				{
					this._deviceDiscoveryService = new global::Motorola.Common.Communication.Service.DeviceDiscovery(deviceFamilySet, workMode, discoveryServiceEventCallback);
					this._deviceFamilySet = deviceFamilySet;
					this._workMode = workMode;
					this._discoveryServiceEventCallback = discoveryServiceEventCallback;
				}
				catch (global::System.Exception systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceNotAvailabe, systemException);
				}
				return this._deviceDiscoveryService;
			}
			if (this._deviceFamilySet != deviceFamilySet || this._workMode != workMode || this._discoveryServiceEventCallback != discoveryServiceEventCallback)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceDeviceDiscoveryParametersMismatched);
			}
			return this._deviceDiscoveryService;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000073A4 File Offset: 0x000055A4
		public global::Motorola.Common.Communication.Service.IDeviceDiscovery GetDeviceDiscoveryService(global::Motorola.Common.Communication.Service.InitializedParameters parameters, global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent discoveryServiceEventCallback)
		{
			if (!string.IsNullOrEmpty(parameters.VRFolder) && global::System.IO.Directory.Exists(parameters.VRFolder))
			{
				global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolder = parameters.VRFolder;
			}
			if (!string.IsNullOrEmpty(parameters.LogFolder) && global::System.IO.Directory.Exists(parameters.LogFolder))
			{
				global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.LogFilePath = parameters.LogFolder;
			}
			if (!global::System.IO.Directory.Exists(global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.StorageFolder))
			{
				global::System.IO.Directory.CreateDirectory(global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.StorageFolder);
			}
			return this.GetDeviceDiscoveryService(parameters.deviceFamilySet, parameters.workMode, discoveryServiceEventCallback);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00007425 File Offset: 0x00005625
		public global::Motorola.Common.Communication.Service.IDeviceDiscovery GetDeviceDiscoveryService()
		{
			if (this._deviceDiscoveryService == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceNotAvailabe);
			}
			return this._deviceDiscoveryService;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00007440 File Offset: 0x00005640
		public global::Motorola.Common.Communication.Service.IDeviceOperation GetDeviceOperationService(global::Motorola.Common.Communication.Service.IOperationServiceEvent deviceOperationCallback)
		{
			global::Motorola.Common.Communication.Service.IDeviceOperation result = null;
			try
			{
				result = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation(deviceOperationCallback);
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceNotAvailabe, systemException);
			}
			return result;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00007474 File Offset: 0x00005674
		protected virtual void Dispose(bool disposing)
		{
			if (!this.m_IsDisposed)
			{
				if (disposing && this._deviceDiscoveryService != null)
				{
					this._deviceDiscoveryService.Dispose();
				}
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000749B File Offset: 0x0000569B
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000028 RID: 40
		private global::Motorola.Common.Communication.Service.IDeviceDiscovery _deviceDiscoveryService;

		// Token: 0x04000029 RID: 41
		private static global::Motorola.Common.Communication.Service.DeviceServiceManager _instance = new global::Motorola.Common.Communication.Service.DeviceServiceManager();

		// Token: 0x0400002A RID: 42
		private int _deviceFamilySet;

		// Token: 0x0400002B RID: 43
		private global::Motorola.Common.Communication.CommonUtil.WorkMode _workMode;

		// Token: 0x0400002C RID: 44
		private global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent _discoveryServiceEventCallback;

		// Token: 0x0400002D RID: 45
		private bool m_IsDisposed;
	}
}
