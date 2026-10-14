using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x0200001E RID: 30
	public class PBBDetector : global::Motorola.Common.Communication.DeviceDiscovery.UDPDetectorBase, global::System.IDisposable
	{
		// Token: 0x060000EE RID: 238 RVA: 0x00005DDC File Offset: 0x00003FDC
		public PBBDetector()
		{
			this._detectorType = global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType.PBBDeviceDetector;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00005DF8 File Offset: 0x00003FF8
		protected override void BackgroundThread()
		{
			while (!this._isStopping)
			{
				try
				{
					this._client = new global::System.Net.Sockets.UdpClient(this.port);
					this._client.Client.ReceiveTimeout = 5000;
					break;
				}
				catch
				{
					global::System.Threading.Thread.Sleep(1000);
				}
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
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00005F10 File Offset: 0x00004110
		private void ReceiveUDP(global::System.Net.IPEndPoint remote)
		{
			byte[] array = this._client.Receive(ref remote);
			if (array != null && array.Length > 0)
			{
				string passwordId = global::System.Text.Encoding.UTF8.GetString(array).Trim();
				if (array.Length == 10)
				{
					global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile profile = new global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile();
					profile.PID = global::Motorola.Common.Communication.DeviceDiscovery.PBBDetector.PBB_PID;
					profile.IPAddress = remote.Address.ToString();
					profile.PasswordId = passwordId;
					profile.DeviceConnectionMode = global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceConnectionMode.Wired;
					profile.HostDetector = this;
					if (global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.Instance.Passwords.Count((global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo m) => m.AuthType == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PasswordIndex && m.PreSharedKey_ID == profile.PasswordId) > 0)
					{
						profile.Password = global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.Instance.Passwords.First((global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo m) => m.AuthType == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PasswordIndex && m.PreSharedKey_ID == profile.PasswordId).PreSharedKey_Material;
					}
					else
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(string.Format("Password identifier <{0}> in broadcast messge from IP: <{1}> invalid", profile.PasswordId, profile.IPAddress), new object[0]);
					}
					if (global::Motorola.Common.Communication.DeviceDiscovery.UDPDeviceManager.Instance.AddProfile(profile))
					{
						base.OnDeviceAdd(profile);
					}
				}
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00006049 File Offset: 0x00004249
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00006058 File Offset: 0x00004258
		protected virtual void Dispose(bool disposing)
		{
			if (this._client != null)
			{
				this._client.Close();
				this._client = null;
			}
		}

		// Token: 0x04000087 RID: 135
		public static readonly string PBB_PID = "_PBB_Device";

		// Token: 0x04000088 RID: 136
		private int port = 9998;

		// Token: 0x04000089 RID: 137
		private global::System.Net.Sockets.UdpClient _client;
	}
}
