using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000016 RID: 22
	public class LDTDetector : global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase, global::System.IDisposable
	{
		// Token: 0x06000091 RID: 145 RVA: 0x000054D8 File Offset: 0x000036D8
		public LDTDetector()
		{
			this._detectorType = global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType.LTEDetector;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000054F2 File Offset: 0x000036F2
		public override bool Start()
		{
			this._isStopping = false;
			this._receiveThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.BackgroundThread));
			this._receiveThread.Start();
			return true;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000551E File Offset: 0x0000371E
		public override void Stop()
		{
			this._isStopping = true;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00005528 File Offset: 0x00003728
		private void BackgroundThread()
		{
			try
			{
				IL_00:
				if (this._isStopping)
				{
					return;
				}
				this._client = new global::System.Net.Sockets.UdpClient(this.port);
				this._client.Client.ReceiveTimeout = 5000;
			}
			catch
			{
				global::System.Threading.Thread.Sleep(1000);
				goto IL_00;
			}
			global::System.Net.IPEndPoint remote = null;
			while (!this._isStopping)
			{
				try
				{
					this.ReceiveUDP(remote);
				}
				catch (global::System.Exception ex)
				{
					global::System.Net.Sockets.SocketException ex2 = ex as global::System.Net.Sockets.SocketException;
					if (ex2 == null || ex2.SocketErrorCode != global::System.Net.Sockets.SocketError.TimedOut)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, new object[0]);
					}
				}
				finally
				{
					global::System.Threading.Thread.Sleep(1000);
				}
			}
			this._client.Close();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00005674 File Offset: 0x00003874
		private void ReceiveUDP(global::System.Net.IPEndPoint remote)
		{
			byte[] array = this._client.Receive(ref remote);
			if (this._isStopping)
			{
				return;
			}
			if (array != null && array.Length > 0)
			{
				string passwordId = global::System.Text.Encoding.UTF8.GetString(array).Trim();
				if (array.Length == 10)
				{
					global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile = new global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile();
					profile.PID = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase.LTE_REPEATER_PID;
					profile.IPAddress = remote.Address.ToString();
					profile.PasswordId = passwordId;
					profile.ConnectMode = global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode.USB;
					if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords.Count((global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo m) => m.AuthType == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PasswordIndex && m.PreSharedKey_ID == profile.PasswordId) > 0)
					{
						profile.Password = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords.First((global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo m) => m.AuthType == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PasswordIndex && m.PreSharedKey_ID == profile.PasswordId).PreSharedKey_Material;
					}
					else
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(string.Format("Password identifier <{0}> in broadcast messge from IP: <{1}> invalid", profile.PasswordId, profile.IPAddress), new object[0]);
					}
					if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.IPAddress == profile.IPAddress && string.IsNullOrEmpty(m.IMEI)) == 0)
					{
						global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Add(profile);
						base.OnDeviceAdd(profile);
					}
				}
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000057B6 File Offset: 0x000039B6
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000057C5 File Offset: 0x000039C5
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this._client != null)
			{
				this._client.Close();
			}
		}

		// Token: 0x0400005D RID: 93
		private int port = 9998;

		// Token: 0x0400005E RID: 94
		private global::System.Net.Sockets.UdpClient _client;
	}
}
