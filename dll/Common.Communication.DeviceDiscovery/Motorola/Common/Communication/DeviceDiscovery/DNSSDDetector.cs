using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Timers;
using DeviceDiscovery.DNSSDDecoder;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000012 RID: 18
	public class DNSSDDetector : global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase, global::System.IDisposable
	{
		// Token: 0x06000073 RID: 115 RVA: 0x000031A8 File Offset: 0x000013A8
		public DNSSDDetector()
		{
			this._detectorType = global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType.DNSSDDetector;
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config = new global::Motorola.Common.Communication.DnsConfig();
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.LoadConfig(global::Motorola.Common.Communication.DnsConfigConstants.ConfigFilePath);
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.multicastIP = global::System.Net.IPAddress.Parse(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.GroupIP);
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.buffer = new byte[65535];
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.msg = new global::Motorola.Common.Communication.DnsQueryMessage(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.OTAPTCP, 12);
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.length = global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.msg.BuildCommandMessage(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.buffer);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000032AC File Offset: 0x000014AC
		public override bool Start()
		{
			this._isStopping = false;
			if (string.IsNullOrEmpty(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.GroupIP) || string.IsNullOrEmpty(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.OTAPTCP) || string.IsNullOrEmpty(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.PasswordIndex) || global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.Port == 0)
			{
				return false;
			}
			this._deviceHandleThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.DeviceHandleThread));
			this._deviceHandleThread.Start();
			this._receiveThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.ReceiveThread));
			this._receiveThread.Start();
			return true;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003346 File Offset: 0x00001546
		public override void Stop()
		{
			this._isStopping = true;
			this._newMDNSArrived.Set();
			this.deviceDetachTimer.Stop();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003368 File Offset: 0x00001568
		public void JoinMulticastGroupAndRequestServiceRecord(global::System.Net.NetworkInformation.NetworkInterface[] latestNetworkAdapterArray, bool reset)
		{
			if (reset)
			{
				foreach (global::System.Net.NetworkInformation.NetworkInterface networkInterface in this.multicastConnectedAdapterList)
				{
					try
					{
						global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.client.DropMulticastGroup(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.multicastIP);
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.CommonCPS.ResourceRepository.Resources.RM_DP_WiFiConnectionErrorMessage + ex.Message, new object[0]);
					}
				}
				this.multicastConnectedAdapterList.Clear();
				this.multicastDisconnectedAdapterList.Clear();
			}
			foreach (global::System.Net.NetworkInformation.NetworkInterface networkInterface2 in latestNetworkAdapterArray)
			{
				if (networkInterface2.SupportsMulticast && networkInterface2.OperationalStatus == global::System.Net.NetworkInformation.OperationalStatus.Up && networkInterface2.NetworkInterfaceType != global::System.Net.NetworkInformation.NetworkInterfaceType.Loopback)
				{
					try
					{
						global::System.Net.IPAddress ipaddress = null;
						global::System.Net.NetworkInformation.IPInterfaceProperties ipproperties = networkInterface2.GetIPProperties();
						foreach (global::System.Net.NetworkInformation.IPAddressInformation ipaddressInformation in ipproperties.UnicastAddresses)
						{
							if (ipaddressInformation.Address.AddressFamily == global::System.Net.Sockets.AddressFamily.InterNetwork)
							{
								ipaddress = ipaddressInformation.Address;
								break;
							}
						}
						if (ipaddress != null)
						{
							global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.client.JoinMulticastGroup(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.multicastIP, ipaddress);
							this.multicastConnectedAdapterList.Add(networkInterface2);
						}
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.CommonCPS.ResourceRepository.Resources.RM_DP_WiFiConnectionErrorMessage + ex2.Message, new object[0]);
					}
				}
			}
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.QueryDevices(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.multicastIP.ToString());
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000035F0 File Offset: 0x000017F0
		public void ResolveNetworkAddressChangedCallback(object sender, global::System.EventArgs e)
		{
			try
			{
				global::System.Net.NetworkInformation.NetworkInterface[] allNetworkInterfaces = global::System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
				bool flag = false;
				global::System.Net.NetworkInformation.NetworkInterface[] array = allNetworkInterfaces;
				for (int i = 0; i < array.Length; i++)
				{
					global::System.Net.NetworkInformation.NetworkInterface adapterCard = array[i];
					if (adapterCard.SupportsMulticast && adapterCard.OperationalStatus == global::System.Net.NetworkInformation.OperationalStatus.Up && adapterCard.NetworkInterfaceType != global::System.Net.NetworkInformation.NetworkInterfaceType.Loopback)
					{
						if (this.multicastConnectedAdapterList.Count((global::System.Net.NetworkInformation.NetworkInterface m) => m.GetPhysicalAddress().ToString() == adapterCard.GetPhysicalAddress().ToString()) == 0)
						{
							if (this.multicastDisconnectedAdapterList.Count((global::System.Net.NetworkInformation.NetworkInterface m) => m.GetPhysicalAddress().ToString() == adapterCard.GetPhysicalAddress().ToString()) == 0)
							{
								flag = true;
								try
								{
									global::System.Net.IPAddress ipaddress = null;
									global::System.Net.NetworkInformation.IPInterfaceProperties ipproperties = adapterCard.GetIPProperties();
									foreach (global::System.Net.NetworkInformation.IPAddressInformation ipaddressInformation in ipproperties.UnicastAddresses)
									{
										if (ipaddressInformation.Address.AddressFamily == global::System.Net.Sockets.AddressFamily.InterNetwork)
										{
											ipaddress = ipaddressInformation.Address;
											break;
										}
									}
									if (ipaddress != null)
									{
										if (global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.client != null)
										{
											global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.client.JoinMulticastGroup(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.multicastIP, ipaddress);
											this.multicastConnectedAdapterList.Add(adapterCard);
										}
									}
								}
								catch (global::System.Exception ex)
								{
									global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.CommonCPS.ResourceRepository.Resources.RM_DP_WiFiConnectionErrorMessage + ex.Message, new object[0]);
								}
							}
						}
					}
				}
				if (!flag)
				{
					global::System.Net.NetworkInformation.NetworkInterface networkInterface = null;
					using (global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface>.Enumerator enumerator2 = this.multicastConnectedAdapterList.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::System.Net.NetworkInformation.NetworkInterface connectedAdapter = enumerator2.Current;
							bool flag2;
							if (allNetworkInterfaces.Count((global::System.Net.NetworkInformation.NetworkInterface m) => m.GetPhysicalAddress().ToString() == connectedAdapter.GetPhysicalAddress().ToString()) > 0)
							{
								networkInterface = allNetworkInterfaces.First((global::System.Net.NetworkInformation.NetworkInterface m) => m.GetPhysicalAddress().ToString() == connectedAdapter.GetPhysicalAddress().ToString());
								flag2 = (networkInterface.OperationalStatus == global::System.Net.NetworkInformation.OperationalStatus.Down);
							}
							else
							{
								flag2 = true;
							}
							if (flag2)
							{
								if (this.multicastDisconnectedAdapterList.Count((global::System.Net.NetworkInformation.NetworkInterface m) => m.GetPhysicalAddress().ToString() == connectedAdapter.GetPhysicalAddress().ToString()) == 0)
								{
									this.multicastDisconnectedAdapterList.Add(connectedAdapter);
									continue;
								}
							}
							if (networkInterface != null && networkInterface.OperationalStatus != global::System.Net.NetworkInformation.OperationalStatus.Down)
							{
								if (this.multicastDisconnectedAdapterList.Count((global::System.Net.NetworkInformation.NetworkInterface m) => m.GetPhysicalAddress().ToString() == connectedAdapter.GetPhysicalAddress().ToString()) > 0)
								{
									this.JoinMulticastGroupAndRequestServiceRecord(allNetworkInterfaces, true);
									break;
								}
							}
						}
					}
				}
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("DNSSDDetector: " + ex2.Message, new object[0]);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003910 File Offset: 0x00001B10
		private string ResolveAstroSRVRecordName(string srvName)
		{
			string result = srvName;
			string[] array = srvName.Split(new char[]
			{
				'.'
			});
			if (array.Length == 3)
			{
				result = string.Concat(new string[]
				{
					array[2],
					".",
					array[0],
					".",
					array[1],
					".local"
				});
			}
			return result;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003974 File Offset: 0x00001B74
		internal static void QueryDevices(string ip)
		{
			lock (global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.sendingLocker)
			{
				try
				{
					global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.client.Send(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.buffer, global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.length, new global::System.Net.IPEndPoint(global::System.Net.IPAddress.Parse(ip), global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.Port));
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Send DNS-SD Query Packet to " + ip, new object[0]);
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception when send query DNSSD packet: " + ex.Message, new object[0]);
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003A30 File Offset: 0x00001C30
		private void ReceiveThread()
		{
			try
			{
				if (string.IsNullOrEmpty(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.GroupIP) || string.IsNullOrEmpty(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.OTAPTCP) || string.IsNullOrEmpty(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.PasswordIndex) || global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.Port == 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException("DNS Config invalid");
				}
				global::System.Net.NetworkInformation.NetworkChange.NetworkAddressChanged += this.ResolveNetworkAddressChangedCallback;
				global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.client = new global::System.Net.Sockets.UdpClient();
				global::System.Net.IPEndPoint localEP = new global::System.Net.IPEndPoint(global::System.Net.IPAddress.Any, global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.Port);
				global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.client.Client.SetSocketOption(global::System.Net.Sockets.SocketOptionLevel.Socket, global::System.Net.Sockets.SocketOptionName.ReuseAddress, true);
				for (;;)
				{
					try
					{
						if (this._isStopping)
						{
							return;
						}
						global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.client.Client.Bind(localEP);
						global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.client.Client.ReceiveTimeout = 5000;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("DNSSDDetector error: " + ex.Message, new object[0]);
						global::System.Threading.Thread.Sleep(2000);
						continue;
					}
					break;
				}
				try
				{
					this.JoinMulticastGroupAndRequestServiceRecord(this.networkAdapterArray, false);
				}
				catch (global::System.Exception ex2)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("JoinMulticastGroupAndRequestServiceRecord: " + ex2.Message, new object[0]);
				}
				this.deviceDetachTimer.Elapsed += delegate(object sender, global::System.Timers.ElapsedEventArgs args)
				{
					this.deviceTimer_Elapsed(sender);
				};
				this.deviceDetachTimer.Start();
				while (!this._isStopping)
				{
					try
					{
						this.remote = null;
						byte[] array = global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.client.Receive(ref this.remote);
						if (this._isStopping)
						{
							break;
						}
						if (array != null && array.Length != 0 && this.remote != null && this.remote.Port == global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.Port)
						{
							lock (this._UDPRawMessageList.SyncRoot)
							{
								global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage value = new global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage
								{
									Message = array,
									RemotePoint = this.remote
								};
								this._UDPRawMessageList.Add(value);
							}
							this._newUDPMsgArrived.Set();
						}
					}
					catch (global::System.Exception ex3)
					{
						global::System.Net.Sockets.SocketException ex4 = ex3 as global::System.Net.Sockets.SocketException;
						if (ex4 == null || ex4.SocketErrorCode != global::System.Net.Sockets.SocketError.TimedOut)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex3.Message, new object[0]);
						}
						global::System.Threading.Thread.Sleep(1000);
					}
				}
			}
			catch (global::System.Exception ex5)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("DNSSD Detector threading exits: " + ex5.Message, new object[0]);
			}
			finally
			{
				try
				{
					if (global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.client != null)
					{
						global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.client.Close();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003F48 File Offset: 0x00002148
		private global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg DecodeMDNSMessage(global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage rawMsg)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.<>c__DisplayClass34 CS$<>8__locals1 = new global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.<>c__DisplayClass34();
			CS$<>8__locals1.rawMsg = rawMsg;
			global::Motorola.Common.Communication.DnsResponseMessage dnsResponseMessage = new global::Motorola.Common.Communication.DnsResponseMessage();
			try
			{
				dnsResponseMessage.DecodeReplyMessage(CS$<>8__locals1.rawMsg.Message, 0, CS$<>8__locals1.rawMsg.Message.Length);
			}
			catch
			{
				return null;
			}
			using (global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.RecordPTR> enumerator = (from m in dnsResponseMessage.PTRS
			where m.NAME == global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.OTAPTCP
			select m).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.<>c__DisplayClass40 CS$<>8__locals2 = new global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector.<>c__DisplayClass40();
					CS$<>8__locals2.CS$<>8__locals35 = CS$<>8__locals1;
					CS$<>8__locals2.ptr = enumerator.Current;
					global::DeviceDiscovery.DNSSDDecoder.DNSSDDecoderCreator.CreateDNSSDDecoder(CS$<>8__locals2.ptr.DomainName);
					if (CS$<>8__locals2.ptr.TTL <= 0U)
					{
						if (CS$<>8__locals2.ptr.DomainName.Contains("Fusion") || CS$<>8__locals2.ptr.DomainName.Contains("Futon"))
						{
							lock (this.detachFusion)
							{
								if (this.detachFusion.ContainsKey(new global::System.Collections.Generic.KeyValuePair<string, string>(CS$<>8__locals1.rawMsg.RemotePoint.Address.ToString(), CS$<>8__locals2.ptr.DomainName)))
								{
									this.detachFusion[new global::System.Collections.Generic.KeyValuePair<string, string>(CS$<>8__locals1.rawMsg.RemotePoint.Address.ToString(), CS$<>8__locals2.ptr.DomainName)] = true;
								}
								else
								{
									this.detachFusion.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(CS$<>8__locals1.rawMsg.RemotePoint.Address.ToString(), CS$<>8__locals2.ptr.DomainName), true);
								}
								continue;
							}
						}
						return new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg
						{
							m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached,
							sDeviceName = CS$<>8__locals2.ptr.DomainName
						};
					}
					global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile = new global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile();
					profile.DomainName = (profile.DeviceName = CS$<>8__locals2.ptr.DomainName);
					profile.ConnectMode = global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode.WIFI;
					profile.TTL = CS$<>8__locals2.ptr.TTL;
					if (CS$<>8__locals2.ptr.DomainName.Contains("Futon") || CS$<>8__locals2.ptr.DomainName.Contains("Fusion"))
					{
						profile.PID = "WiFi_PBB";
						profile.IMEI = profile.PID + "_" + CS$<>8__locals1.rawMsg.RemotePoint.Address.ToString();
						if (dnsResponseMessage.TXTS.Count((global::Motorola.Common.Communication.RecordTXT m) => m.NAME == CS$<>8__locals2.ptr.DomainName) <= 0)
						{
							continue;
						}
						global::Motorola.Common.Communication.RecordTXT recordTXT = dnsResponseMessage.TXTS.First((global::Motorola.Common.Communication.RecordTXT m) => m.NAME == CS$<>8__locals2.ptr.DomainName);
						if (!recordTXT.Txts.ContainsKey(global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.PasswordIndex))
						{
							continue;
						}
						profile.PasswordId = recordTXT.Txts[global::Motorola.Common.Communication.DeviceDiscovery.DNSSDDetector._config.PasswordIndex];
						if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords.Count((global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo m) => m.AuthType == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PasswordIndex && m.PreSharedKey_ID == profile.PasswordId) <= 0)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(string.Format("Password identifier <{0}> in broadcast messge from IP: <{1}> invalid", profile.PasswordId, profile.IPAddress), new object[0]);
							continue;
						}
						profile.Password = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords.First((global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo m) => m.AuthType == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PasswordIndex && m.PreSharedKey_ID == profile.PasswordId).PreSharedKey_Material;
						lock (this.detachFusion)
						{
							if (this.detachFusion.ContainsKey(new global::System.Collections.Generic.KeyValuePair<string, string>(CS$<>8__locals1.rawMsg.RemotePoint.Address.ToString(), CS$<>8__locals2.ptr.DomainName)))
							{
								this.detachFusion.Remove(new global::System.Collections.Generic.KeyValuePair<string, string>(CS$<>8__locals1.rawMsg.RemotePoint.Address.ToString(), CS$<>8__locals2.ptr.DomainName));
							}
						}
						long num = (long)new global::System.TimeSpan(global::System.DateTime.Now.Ticks).TotalSeconds;
						if (this.iptimeDict.ContainsKey(CS$<>8__locals1.rawMsg.RemotePoint.Address.ToString()))
						{
							if (num - this.iptimeDict[CS$<>8__locals1.rawMsg.RemotePoint.Address.ToString()] < 30L)
							{
								this.iptimeDict[CS$<>8__locals1.rawMsg.RemotePoint.Address.ToString()] = num;
								if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.DomainName == CS$<>8__locals2.ptr.DomainName && m.IPAddress == CS$<>8__locals2.CS$<>8__locals35.rawMsg.RemotePoint.Address.ToString()) > 0)
								{
									continue;
								}
							}
							else
							{
								this.iptimeDict[CS$<>8__locals1.rawMsg.RemotePoint.Address.ToString()] = num;
							}
						}
						else
						{
							this.iptimeDict.Add(CS$<>8__locals1.rawMsg.RemotePoint.Address.ToString(), num);
						}
					}
					else
					{
						if (CS$<>8__locals2.ptr.DomainName.Contains("APX "))
						{
							profile.DeviceName = CS$<>8__locals2.ptr.DomainName.Substring(0, CS$<>8__locals2.ptr.DomainName.IndexOf('_'));
							profile.DeviceName = profile.DeviceName.Remove(profile.DeviceName.IndexOf(' '), 1);
							profile.DeviceDescription = CS$<>8__locals2.ptr.DomainName;
							profile.PID = "WiFi_APX";
							profile.UniqueLocation = "";
							profile.RadioType = global::Motorola.Common.Communication.RadioType.ASTRO;
							profile.InstanceId = 0U;
							profile.NetCfgInstanceId = "WiFi_" + profile.DeviceName;
							if (dnsResponseMessage.TXTS.Count((global::Motorola.Common.Communication.RecordTXT m) => m.NAME == CS$<>8__locals2.ptr.DomainName) <= 0)
							{
								continue;
							}
							global::Motorola.Common.Communication.RecordTXT recordTXT2 = dnsResponseMessage.TXTS.First((global::Motorola.Common.Communication.RecordTXT m) => m.NAME == CS$<>8__locals2.ptr.DomainName);
							if (recordTXT2.Txts.ContainsKey("sn"))
							{
								profile.RadioSerialNumber = recordTXT2.Txts["sn"];
							}
							else
							{
								profile.RadioSerialNumber = CS$<>8__locals2.ptr.DomainName.Substring(CS$<>8__locals2.ptr.DomainName.IndexOf('_') + 1, CS$<>8__locals2.ptr.DomainName.IndexOf('.') - (CS$<>8__locals2.ptr.DomainName.IndexOf('_') + 1));
							}
							profile.UniqueLocation = profile.RadioSerialNumber;
							profile.IMEI = profile.PID + "_" + profile.RadioSerialNumber;
							profile.DeviceInstanceID = profile.PID + "_" + profile.RadioSerialNumber;
							profile.PhysicalLocation = profile.RadioSerialNumber;
							if (dnsResponseMessage.SRVS.Count <= 0)
							{
								goto IL_96F;
							}
							using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV>.Enumerator enumerator2 = dnsResponseMessage.SRVS.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									global::Motorola.Common.Communication.RecordSRV recordSRV = enumerator2.Current;
									recordSRV.NAME = this.ResolveAstroSRVRecordName(recordSRV.NAME);
								}
								goto IL_96F;
							}
						}
						if (CS$<>8__locals2.ptr.DomainName.Contains("MOTOTRBO_"))
						{
							profile.DeviceName = CS$<>8__locals2.ptr.DomainName;
							profile.DeviceDescription = CS$<>8__locals2.ptr.DomainName;
							profile.PID = "WiFi_MotoTrbo";
							profile.UniqueLocation = "";
							profile.RadioType = global::Motorola.Common.Communication.RadioType.PCR;
							profile.InstanceId = 0U;
							profile.NetCfgInstanceId = "WiFi_" + profile.DeviceName;
							if (dnsResponseMessage.TXTS.Count((global::Motorola.Common.Communication.RecordTXT m) => m.NAME == CS$<>8__locals2.ptr.DomainName) <= 0)
							{
								continue;
							}
							global::Motorola.Common.Communication.RecordTXT recordTXT3 = dnsResponseMessage.TXTS.First((global::Motorola.Common.Communication.RecordTXT m) => m.NAME == CS$<>8__locals2.ptr.DomainName);
							if (!recordTXT3.Txts.ContainsKey("sn"))
							{
								continue;
							}
							profile.RadioSerialNumber = recordTXT3.Txts["sn"];
							if (!recordTXT3.Txts.ContainsKey("acctype") || recordTXT3.Txts["acctype"] == "USB")
							{
								continue;
							}
							profile.UniqueLocation = profile.RadioSerialNumber;
							profile.IMEI = profile.PID + "_" + profile.RadioSerialNumber;
							profile.DeviceInstanceID = profile.PID + "_" + profile.RadioSerialNumber;
							profile.PhysicalLocation = profile.RadioSerialNumber;
							if (dnsResponseMessage.SRVS.Count <= 0)
							{
								goto IL_96F;
							}
							using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.RecordSRV>.Enumerator enumerator3 = dnsResponseMessage.SRVS.GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									global::Motorola.Common.Communication.RecordSRV recordSRV2 = enumerator3.Current;
									recordSRV2.NAME = this.ResolveAstroSRVRecordName(recordSRV2.NAME);
								}
								goto IL_96F;
							}
						}
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Unknown MDNS Packet. " + CS$<>8__locals2.ptr.DomainName, new object[0]);
					}
					IL_96F:
					if (dnsResponseMessage.SRVS.Count((global::Motorola.Common.Communication.RecordSRV m) => m.NAME == CS$<>8__locals2.ptr.DomainName) > 0)
					{
						string target = dnsResponseMessage.SRVS.First((global::Motorola.Common.Communication.RecordSRV m) => m.NAME == CS$<>8__locals2.ptr.DomainName).Target;
						if (profile.RadioType != global::Motorola.Common.Communication.RadioType.PCR)
						{
							profile.PortName = dnsResponseMessage.SRVS.First((global::Motorola.Common.Communication.RecordSRV m) => m.NAME == CS$<>8__locals2.ptr.DomainName).Port.ToString();
						}
						else
						{
							profile.PortName = "8002";
						}
						if (!string.IsNullOrEmpty(target))
						{
							if (dnsResponseMessage.AS.Count((global::Motorola.Common.Communication.RecordA m) => m.NAME == target) > 0)
							{
								profile.IPAddress = dnsResponseMessage.AS.First((global::Motorola.Common.Communication.RecordA m) => m.NAME == target).IP;
							}
							else if (CS$<>8__locals2.ptr.DomainName.Contains("MOTOTRBO_"))
							{
								profile.IPAddress = dnsResponseMessage.AS[0].IP;
							}
							else
							{
								if (!CS$<>8__locals2.ptr.DomainName.Contains("Fusion") && !CS$<>8__locals2.ptr.DomainName.Contains("Futon"))
								{
									continue;
								}
								profile.IPAddress = CS$<>8__locals1.rawMsg.RemotePoint.Address.ToString();
							}
							return new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg
							{
								m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached,
								sDeviceName = CS$<>8__locals2.ptr.DomainName,
								radioProfile = profile
							};
						}
					}
				}
			}
			return null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004CC0 File Offset: 0x00002EC0
		private void DeviceHandleThread()
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg>();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage> list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage>();
			while (!this._isStopping)
			{
				try
				{
					this._newUDPMsgArrived.WaitOne(1000);
					lock (this._UDPRawMessageList.SyncRoot)
					{
						list2.Clear();
						for (int i = 0; i < this._UDPRawMessageList.Count; i++)
						{
							list2.Add((global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage)this._UDPRawMessageList[i]);
						}
						this._UDPRawMessageList.Clear();
					}
					list.Clear();
					foreach (global::Motorola.Common.Communication.DeviceDiscovery.RawMDNSMessage rawMsg in list2)
					{
						global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg = this.DecodeMDNSMessage(rawMsg);
						if (originalPnPMsg != null)
						{
							list.Add(originalPnPMsg);
							this.OnMDNSDeviceEvent(originalPnPMsg);
							if (this._isStopping)
							{
								break;
							}
						}
					}
					lock (this.arrivedDeviceListLocker)
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile> list3 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile>();
						using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile>.Enumerator enumerator2 = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile radioProf = enumerator2.Current;
								if (list.Count((global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg s) => s.sDeviceName == radioProf.DomainName) == 0 && !radioProf.CheckTimer())
								{
									list3.Add(radioProf);
								}
							}
						}
						list3.ForEach(delegate(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile s)
						{
							this.DetachWifiDevice(s, null);
						});
					}
					if (this._isStopping)
					{
						break;
					}
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception on DeviceHandleThread:" + ex.Message, new object[0]);
				}
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004F20 File Offset: 0x00003120
		private void OnMDNSDeviceEvent(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg mdnsMsg)
		{
			if (mdnsMsg.m_DeviceAction == global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached)
			{
				try
				{
					this.HandleDeviceAttached(mdnsMsg);
					return;
				}
				catch (global::System.Exception arg)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception in DeviceDetectorBase::ProcessPnPMsgThread: " + arg, new object[0]);
					return;
				}
			}
			if (mdnsMsg.m_DeviceAction == global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached)
			{
				try
				{
					this.HandleDeviceDetached(mdnsMsg);
					return;
				}
				catch (global::System.Exception arg2)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception in DeviceDetectorBase::ProcessPnPMsgThread: " + arg2, new object[0]);
					return;
				}
			}
			string format = "Received An Unclean PnP Message!";
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(format, new object[0]);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004FF8 File Offset: 0x000031F8
		private void HandleDeviceAttached(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg tmpMsg)
		{
			global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile = tmpMsg.radioProfile as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile;
			lock (this.arrivedDeviceListLocker)
			{
				bool flag2 = true;
				if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.DomainName == profile.DomainName) == 0)
				{
					profile.detach += this.DetachWifiDevice;
					profile.StartTimer();
					global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Add(profile);
				}
				else
				{
					global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile ldtradioProfile = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Find((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.RadioSerialNumber == profile.RadioSerialNumber);
					if (ldtradioProfile.IPAddress == profile.IPAddress)
					{
						ldtradioProfile.StartTimer();
						flag2 = false;
					}
					else
					{
						global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Remove(ldtradioProfile);
						base.OnDeviceRemove(ldtradioProfile);
						profile.StartTimer();
						global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Add(profile);
					}
				}
				if (flag2)
				{
					base.OnDeviceAdd(profile);
				}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005164 File Offset: 0x00003364
		private void HandleDeviceDetached(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg tmpMsg)
		{
			lock (this.arrivedDeviceListLocker)
			{
				if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.DomainName == tmpMsg.sDeviceName) > 0)
				{
					global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile sender = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.First((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.DomainName == tmpMsg.sDeviceName);
					this.DetachWifiDevice(sender, null);
				}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000525C File Offset: 0x0000345C
		private void DetachWifiDevice(object sender, global::System.EventArgs e = null)
		{
			if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.RadioSerialNumber == (sender as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile).RadioSerialNumber && m.DomainName == (sender as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile).DomainName) > 0)
			{
				base.OnDeviceRemove(sender as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile);
				global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.RemoveAll((global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile m) => m.RadioSerialNumber == (sender as global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile).RadioSerialNumber);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000052C0 File Offset: 0x000034C0
		private void deviceTimer_Elapsed(object sender)
		{
			lock (this.detachFusion)
			{
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>();
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Collections.Generic.KeyValuePair<string, string>, bool> keyValuePair in this.detachFusion)
				{
					if (keyValuePair.Value)
					{
						list.Add(keyValuePair.Key);
						lock (this._DNSSDMsgList.SyncRoot)
						{
							global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg();
							originalPnPMsg.m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached;
							originalPnPMsg.sDeviceName = keyValuePair.Key.Value;
							this._DNSSDMsgList.Add(originalPnPMsg);
						}
						this.iptimeDict.Remove(keyValuePair.Key.Key);
					}
				}
				foreach (global::System.Collections.Generic.KeyValuePair<string, string> key in list)
				{
					this.detachFusion.Remove(key);
				}
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00005450 File Offset: 0x00003650
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000545F File Offset: 0x0000365F
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.deviceDetachTimer.Close();
				this._newMDNSArrived.Close();
			}
		}

		// Token: 0x04000035 RID: 53
		public const string PCR_WIFI_PID = "WiFi_MotoTrbo";

		// Token: 0x04000036 RID: 54
		public const string ASTRO_WIFI_PID = "WiFi_APX";

		// Token: 0x04000037 RID: 55
		public const string PBB_WIFI_PID = "WiFi_PBB";

		// Token: 0x04000038 RID: 56
		private const string MOTOTRBO_Prefix = "MOTOTRBO_";

		// Token: 0x04000039 RID: 57
		private const string ASTRO_Prefix = "APX ";

		// Token: 0x0400003A RID: 58
		private const string FUTON_Prefix = "Futon";

		// Token: 0x0400003B RID: 59
		private const string FUSION_Prefix = "Fusion";

		// Token: 0x0400003C RID: 60
		private const int WAIT_MDNS_INTERVAL = 1000;

		// Token: 0x0400003D RID: 61
		private static byte[] buffer = null;

		// Token: 0x0400003E RID: 62
		private static global::Motorola.Common.Communication.DnsQueryMessage msg = null;

		// Token: 0x0400003F RID: 63
		private static int length = 0;

		// Token: 0x04000040 RID: 64
		private static global::System.Net.IPAddress multicastIP = global::System.Net.IPAddress.None;

		// Token: 0x04000041 RID: 65
		private static global::Motorola.Common.Communication.DnsConfig _config = null;

		// Token: 0x04000042 RID: 66
		private static object sendingLocker = new object();

		// Token: 0x04000043 RID: 67
		private static global::System.Net.Sockets.UdpClient client = null;

		// Token: 0x04000044 RID: 68
		private global::System.Net.IPEndPoint remote;

		// Token: 0x04000045 RID: 69
		private global::System.Threading.Thread _deviceHandleThread;

		// Token: 0x04000046 RID: 70
		private global::System.Threading.AutoResetEvent _newMDNSArrived = new global::System.Threading.AutoResetEvent(false);

		// Token: 0x04000047 RID: 71
		private global::System.Collections.ArrayList _DNSSDMsgList = new global::System.Collections.ArrayList();

		// Token: 0x04000048 RID: 72
		private global::System.Threading.AutoResetEvent _newUDPMsgArrived = new global::System.Threading.AutoResetEvent(false);

		// Token: 0x04000049 RID: 73
		private global::System.Collections.ArrayList _UDPRawMessageList = new global::System.Collections.ArrayList();

		// Token: 0x0400004A RID: 74
		private object arrivedDeviceListLocker = new object();

		// Token: 0x0400004B RID: 75
		public global::System.Net.NetworkInformation.NetworkInterface[] networkAdapterArray = global::System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();

		// Token: 0x0400004C RID: 76
		public global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface> multicastConnectedAdapterList = new global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface>();

		// Token: 0x0400004D RID: 77
		public global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface> multicastDisconnectedAdapterList = new global::System.Collections.Generic.List<global::System.Net.NetworkInformation.NetworkInterface>();

		// Token: 0x0400004E RID: 78
		private global::System.Timers.Timer deviceDetachTimer = new global::System.Timers.Timer(180000.0);

		// Token: 0x0400004F RID: 79
		private global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.KeyValuePair<string, string>, bool> detachFusion = new global::System.Collections.Generic.Dictionary<global::System.Collections.Generic.KeyValuePair<string, string>, bool>();

		// Token: 0x04000050 RID: 80
		private global::System.Collections.Generic.Dictionary<string, long> iptimeDict = new global::System.Collections.Generic.Dictionary<string, long>();
	}
}
