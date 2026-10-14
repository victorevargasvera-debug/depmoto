using System;
using System.Collections.Generic;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Service;

namespace CommunicationController
{
	// Token: 0x02000027 RID: 39
	public class DeviceDiscoveryWrapper
	{
		// Token: 0x06000134 RID: 308 RVA: 0x0000DE2C File Offset: 0x0000CE2C
		private DeviceDiscoveryWrapper()
		{
			try
			{
				this.b = new global::CommunicationController.DeviceDiscoveryHandler();
				this.b.OnMasterSystemLostHandler += this.a;
				this.c = global::Motorola.Common.Communication.Service.DeviceServiceManager.Instance().GetDeviceDiscoveryService(196734, global::Motorola.Common.Communication.CommonUtil.WorkMode.Lazy, this.b);
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::CommunicationController.CCustomExceptionHandler.CreateException(50U, base.GetType().ToString(), "DeviceDiscoveryWrapper", global::System.Environment.StackTrace.ToString());
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000DEBC File Offset: 0x0000CEBC
		public static global::CommunicationController.DeviceDiscoveryWrapper GetInstance()
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_6D;
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						if (true)
						{
						}
						break;
					}
					break;
				case 2:
					global::CommunicationController.DeviceDiscoveryWrapper.a = new global::CommunicationController.DeviceDiscoveryWrapper();
					num = 0;
					continue;
				}
				if (global::CommunicationController.DeviceDiscoveryWrapper.a != null)
				{
					break;
				}
				num = 2;
			}
			IL_6D:
			return global::CommunicationController.DeviceDiscoveryWrapper.a;
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000136 RID: 310 RVA: 0x0000DF40 File Offset: 0x0000CF40
		// (remove) Token: 0x06000137 RID: 311 RVA: 0x0000DFD4 File Offset: 0x0000CFD4
		public event global::CommunicationController.DeviceDiscoveryWrapper.OnMasterSystemLostCallback OnMasterLost
		{
			add
			{
				for (;;)
				{
					IL_00:
					for (;;)
					{
						global::CommunicationController.DeviceDiscoveryWrapper.OnMasterSystemLostCallback onMasterSystemLostCallback = this.d;
						if (true)
						{
						}
						int num = 2;
						for (;;)
						{
							global::CommunicationController.DeviceDiscoveryWrapper.OnMasterSystemLostCallback onMasterSystemLostCallback2;
							switch (num)
							{
							case 0:
								if (onMasterSystemLostCallback == onMasterSystemLostCallback2)
								{
									num = 1;
									continue;
								}
								goto IL_2D;
							case 1:
								return;
							case 2:
								goto IL_2D;
							}
							break;
							IL_2D:
							onMasterSystemLostCallback2 = onMasterSystemLostCallback;
							global::CommunicationController.DeviceDiscoveryWrapper.OnMasterSystemLostCallback value2 = (global::CommunicationController.DeviceDiscoveryWrapper.OnMasterSystemLostCallback)global::System.Delegate.Combine(onMasterSystemLostCallback2, value);
							onMasterSystemLostCallback = global::System.Threading.Interlocked.CompareExchange<global::CommunicationController.DeviceDiscoveryWrapper.OnMasterSystemLostCallback>(ref this.d, value2, onMasterSystemLostCallback2);
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								if (false)
								{
								}
								num = 0;
								break;
							}
						}
					}
				}
			}
			remove
			{
				for (;;)
				{
					global::CommunicationController.DeviceDiscoveryWrapper.OnMasterSystemLostCallback onMasterSystemLostCallback;
					global::CommunicationController.DeviceDiscoveryWrapper.OnMasterSystemLostCallback onMasterSystemLostCallback2;
					int num;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_66:
						if (onMasterSystemLostCallback != onMasterSystemLostCallback2)
						{
							goto IL_41;
						}
						if (true)
						{
						}
						num = 2;
						break;
					default:
						if (false)
						{
						}
						onMasterSystemLostCallback = this.d;
						num = 1;
						break;
					}
					IL_02:
					switch (num)
					{
					case 0:
						goto IL_66;
					case 1:
						goto IL_41;
					case 2:
						return;
					}
					continue;
					IL_41:
					onMasterSystemLostCallback2 = onMasterSystemLostCallback;
					global::CommunicationController.DeviceDiscoveryWrapper.OnMasterSystemLostCallback value2 = (global::CommunicationController.DeviceDiscoveryWrapper.OnMasterSystemLostCallback)global::System.Delegate.Remove(onMasterSystemLostCallback2, value);
					onMasterSystemLostCallback = global::System.Threading.Interlocked.CompareExchange<global::CommunicationController.DeviceDiscoveryWrapper.OnMasterSystemLostCallback>(ref this.d, value2, onMasterSystemLostCallback2);
					num = 0;
					goto IL_02;
				}
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000E06C File Offset: 0x0000D06C
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs A_0)
		{
			for (;;)
			{
				IL_00:
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							if (false)
							{
							}
							this.d(A_0);
							if (true)
							{
							}
							num = 0;
							continue;
						}
						break;
					}
					if (this.d == null)
					{
						return;
					}
					num = 1;
				}
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000E0EC File Offset: 0x0000D0EC
		public bool Connect2PCRIPSystem(global::Motorola.Common.Communication.CommonUtil.PCRIPSystemInfo info)
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
			return this.c.Connect2PCRIPSystem(info);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000E134 File Offset: 0x0000D134
		public void DisconnectFromPCRIPSystem()
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
			this.c.DisconnectFromPCRIPSystem();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000E17C File Offset: 0x0000D17C
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ListConnectedDevices(int connectionType)
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
			return this.c.ListConnectedDevices(connectionType);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000E1C4 File Offset: 0x0000D1C4
		// Note: this type is marked as 'beforefieldinit'.
		static DeviceDiscoveryWrapper()
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
		}

		// Token: 0x04000075 RID: 117
		private static global::CommunicationController.DeviceDiscoveryWrapper a;

		// Token: 0x04000076 RID: 118
		private global::CommunicationController.DeviceDiscoveryHandler b;

		// Token: 0x04000077 RID: 119
		private global::Motorola.Common.Communication.Service.IDeviceDiscovery c;

		// Token: 0x04000078 RID: 120
		private global::CommunicationController.DeviceDiscoveryWrapper.OnMasterSystemLostCallback d;

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x0600013E RID: 318
		public delegate void OnMasterSystemLostCallback(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args);
	}
}
