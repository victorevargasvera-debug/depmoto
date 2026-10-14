using System;
using System.ServiceModel;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Service;

namespace CommunicationController
{
	// Token: 0x02000021 RID: 33
	[global::System.ServiceModel.CallbackBehavior(UseSynchronizationContext = false)]
	public class DeviceDiscoveryHandler : global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600010A RID: 266 RVA: 0x0000C860 File Offset: 0x0000B860
		// (remove) Token: 0x0600010B RID: 267 RVA: 0x0000C8F8 File Offset: 0x0000B8F8
		public event global::CommunicationController.DeviceDiscoveryHandler.OnMasterSystemLostCallback OnMasterSystemLostHandler
		{
			add
			{
				for (;;)
				{
					global::CommunicationController.DeviceDiscoveryHandler.OnMasterSystemLostCallback onMasterSystemLostCallback = this.a;
					if (true)
					{
					}
					int num = 2;
					for (;;)
					{
						global::CommunicationController.DeviceDiscoveryHandler.OnMasterSystemLostCallback onMasterSystemLostCallback2;
						switch (num)
						{
						case 0:
							if (onMasterSystemLostCallback != onMasterSystemLostCallback2)
							{
								goto IL_2D;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2D;
							default:
								if (false)
								{
								}
								num = 1;
								continue;
							}
							break;
						case 1:
							return;
						case 2:
							goto IL_2D;
						}
						break;
						IL_2D:
						onMasterSystemLostCallback2 = onMasterSystemLostCallback;
						global::CommunicationController.DeviceDiscoveryHandler.OnMasterSystemLostCallback value2 = (global::CommunicationController.DeviceDiscoveryHandler.OnMasterSystemLostCallback)global::System.Delegate.Combine(onMasterSystemLostCallback2, value);
						onMasterSystemLostCallback = global::System.Threading.Interlocked.CompareExchange<global::CommunicationController.DeviceDiscoveryHandler.OnMasterSystemLostCallback>(ref this.a, value2, onMasterSystemLostCallback2);
						num = 0;
					}
				}
			}
			remove
			{
				for (;;)
				{
					global::CommunicationController.DeviceDiscoveryHandler.OnMasterSystemLostCallback onMasterSystemLostCallback = this.a;
					if (true)
					{
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						if (false)
						{
						}
						int num = 1;
						for (;;)
						{
							global::CommunicationController.DeviceDiscoveryHandler.OnMasterSystemLostCallback onMasterSystemLostCallback2;
							switch (num)
							{
							case 0:
								return;
							case 1:
								goto IL_53;
							case 2:
								if (onMasterSystemLostCallback == onMasterSystemLostCallback2)
								{
									num = 0;
									continue;
								}
								goto IL_53;
							}
							break;
							IL_53:
							onMasterSystemLostCallback2 = onMasterSystemLostCallback;
							global::CommunicationController.DeviceDiscoveryHandler.OnMasterSystemLostCallback value2 = (global::CommunicationController.DeviceDiscoveryHandler.OnMasterSystemLostCallback)global::System.Delegate.Remove(onMasterSystemLostCallback2, value);
							onMasterSystemLostCallback = global::System.Threading.Interlocked.CompareExchange<global::CommunicationController.DeviceDiscoveryHandler.OnMasterSystemLostCallback>(ref this.a, value2, onMasterSystemLostCallback2);
							num = 2;
						}
						break;
					}
					}
				}
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000C990 File Offset: 0x0000B990
		public void OnDeviceConnected(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args)
		{
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000C9CC File Offset: 0x0000B9CC
		public void OnDeviceLost(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args)
		{
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000CA08 File Offset: 0x0000BA08
		public void OnDeviceSwitchOver(global::Motorola.Common.Communication.CommonUtil.SwitchOverEventArgs args)
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

		// Token: 0x0600010F RID: 271 RVA: 0x0000CA44 File Offset: 0x0000BA44
		public void OnMasterSystemLost(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.a(args);
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						if (false)
						{
						}
						num = 2;
						continue;
					}
					break;
				case 2:
					return;
				}
				if (true)
				{
				}
				if (this.a == null)
				{
					break;
				}
				num = 0;
			}
		}

		// Token: 0x0400006C RID: 108
		private global::CommunicationController.DeviceDiscoveryHandler.OnMasterSystemLostCallback a;

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000112 RID: 274
		public delegate void OnMasterSystemLostCallback(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args);
	}
}
