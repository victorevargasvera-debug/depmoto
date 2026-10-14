using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using custom_datatypes;
using Motorola.Common.Communication.CommonUtil;
using msclr;

namespace LEAdaptor
{
	// Token: 0x0200005A RID: 90
	public class MRemoteSystem : global::LEAdaptor.RemoteSystemBase
	{
		// Token: 0x06000127 RID: 295 RVA: 0x000051B0 File Offset: 0x000045B0
		private void OnPeerMapUpdated()
		{
			global::custom_datatypes.MLEPeer[] array = null;
			global::msclr.@lock @lock = null;
			this.GetPeerMapDataInternal(ref array);
			global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer> list = new global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer>();
			global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer> list2 = new global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer>();
			global::msclr.@lock lock2 = new global::msclr.@lock(this.lockObj);
			try
			{
				@lock = lock2;
				global::custom_datatypes.MLEPeer[] array2 = array;
				int num = 0;
				if (0 < array.Length)
				{
					do
					{
						global::custom_datatypes.MLEPeer item = array2[num];
						global::System.ValueType valueType = null;
						global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer>.Enumerator enumerator = this.devListCache.GetEnumerator();
						if (enumerator.MoveNext())
						{
							global::custom_datatypes.MLEPeer mlepeer;
							do
							{
								mlepeer = enumerator.Current;
								if (mlepeer.ID == item.ID)
								{
									goto IL_88;
								}
							}
							while (enumerator.MoveNext());
							goto IL_90;
							IL_88:
							valueType = mlepeer;
						}
						IL_90:
						if (valueType == null)
						{
							list.Add(item);
						}
						else
						{
							this.devListCache.Remove((global::custom_datatypes.MLEPeer)valueType);
							if (((global::custom_datatypes.MLEPeer)valueType).IP != item.IP || ((global::custom_datatypes.MLEPeer)valueType).Port != item.Port)
							{
								list.Add(item);
								list2.Add((global::custom_datatypes.MLEPeer)valueType);
							}
						}
						num++;
					}
					while (num < array2.Length);
				}
				if (this.devListCache.Count > 0)
				{
					list2.AddRange(this.devListCache.ToArray());
				}
				this.devListCache.Clear();
				this.devListCache.AddRange(array);
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer>.Enumerator enumerator2 = list2.GetEnumerator();
			if (enumerator2.MoveNext())
			{
				do
				{
					global::custom_datatypes.MLEPeer mlepeer2 = enumerator2.Current;
					this.raise_OnStatusChange(null, new global::LEAdaptor.StatusChangeEventArgs
					{
						eventType = 1U,
						peer = mlepeer2
					});
				}
				while (enumerator2.MoveNext());
			}
			global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer>.Enumerator enumerator3 = list.GetEnumerator();
			if (enumerator3.MoveNext())
			{
				do
				{
					global::custom_datatypes.MLEPeer mlepeer3 = enumerator3.Current;
					this.raise_OnStatusChange(null, new global::LEAdaptor.StatusChangeEventArgs
					{
						eventType = 0U,
						peer = mlepeer3
					});
				}
				while (enumerator3.MoveNext());
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00005124 File Offset: 0x00004524
		private unsafe void OnLinkRemoved(uint peerID)
		{
			global::custom_datatypes.MLEPeer mlepeer = default(global::custom_datatypes.MLEPeer);
			uint id;
			uint num;
			ushort port;
			global::<Module>.PeerManager.GetIntermediaryData(this.manager, &id, &num, &port, null, null);
			mlepeer.ID = id;
			mlepeer.Port = port;
			global::in_addr in_addr = num;
			mlepeer.IP = new string(global::<Module>.inet_ntoa(in_addr));
			mlepeer.Master = true;
			if (mlepeer.ID == peerID)
			{
				this.CleanDevList();
				this.raise_OnStatusChange(null, new global::LEAdaptor.StatusChangeEventArgs
				{
					eventType = 2U,
					peer = mlepeer
				});
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004D2C File Offset: 0x0000412C
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		private unsafe bool GetPeerMapDataInternal(ref global::custom_datatypes.MLEPeer[] peers)
		{
			global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer> list = new global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer>();
			uint num = 0U;
			uint num2 = 0U;
			ushort num3 = 0;
			ushort num4 = 0;
			uint num5 = 0U;
			byte b = 0;
			byte b2 = 0;
			uint num6 = 0U;
			byte* ptr = global::<Module>.PeerManager.GetPeerMapData(this.manager, &num6, &b, &b2);
			global::<Module>.PeerManager.GetIntermediaryData(this.manager, &num, &num2, &num3, &num4, &num5);
			global::sockaddr_in sockaddr_in;
			initblk(ref sockaddr_in, 0, 16);
			bool flag = false;
			if (b == 2)
			{
				if ((num4 & 4096) != 0)
				{
					flag = true;
				}
			}
			else if (b == 1)
			{
				flag = ((num5 & 131072U) != 0U || flag);
			}
			global::custom_datatypes.MLEPeer item = default(global::custom_datatypes.MLEPeer);
			if (flag)
			{
				item.ID = num;
				*(ref sockaddr_in + 4) = (int)num2;
				item.IP = new string(global::<Module>.inet_ntoa(*(ref sockaddr_in + 4)));
				item.Port = num3;
				item.Master = true;
				item.VoterID = item.ID;
				list.Add(item);
			}
			uint num7 = 0U;
			if (0U < num6)
			{
				byte* ptr2 = ptr;
				for (;;)
				{
					flag = false;
					cpblk(ref num, ptr2, 4);
					num7 += 4U;
					ptr2 += 4;
					cpblk(ref num2, ptr2, 4);
					num7 += 4U;
					ptr2 += 4;
					cpblk(ref num3, ptr2, 2);
					num7 += 2U;
					ptr2 += 2;
					if (b == 2)
					{
						cpblk(ref num4, ptr2, 2);
						num7 += 2U;
						ptr2 += 2;
						num4 = global::<Module>.ntohs(num4);
						flag = ((num4 & 4096) != 0 || flag);
						num7 += 1U;
						ptr2++;
						if (flag)
						{
							goto IL_182;
						}
					}
					else
					{
						num7 += 1U;
						ptr2++;
						if (b == 1)
						{
							cpblk(ref num5, ptr2, 4);
							num7 += 4U;
							ptr2 += 4;
							num5 = global::<Module>.ntohl(num5);
							if ((num5 & 131072U) != 0U)
							{
								goto IL_182;
							}
						}
					}
					IL_1DE:
					if (num7 >= num6)
					{
						break;
					}
					continue;
					IL_182:
					item.ID = global::<Module>.ntohl(num);
					*(ref sockaddr_in + 4) = (int)num2;
					item.IP = new string(global::<Module>.inet_ntoa(*(ref sockaddr_in + 4)));
					item.Port = global::<Module>.ntohs(num3);
					item.Master = false;
					item.VoterID = item.ID;
					list.Add(item);
					goto IL_1DE;
				}
			}
			byte* ptr3 = global::<Module>.PeerManager.GetSatelliteMapData(this.manager, &num6);
			uint num8 = 0U;
			if (0U < num6)
			{
				do
				{
					uint num9;
					cpblk(ref num9, num8 + ptr3, 4);
					num8 += 4U;
					byte b3;
					cpblk(ref b3, num8 + ptr3, 1);
					num8 += 1U;
					byte b4 = 0;
					if (0 < b3)
					{
						int num10 = num8 + ptr3;
						do
						{
							cpblk(ref num, num10, 4);
							num8 += 4U;
							num10 += 4;
							item.ID = global::<Module>.ntohl(num);
							item.IP = "0.0.0.0";
							item.Port = 0;
							item.Master = false;
							item.VoterID = global::<Module>.ntohl(num9);
							list.Add(item);
							b4 += 1;
						}
						while (b4 < b3);
					}
				}
				while (num8 < num6);
			}
			peers = list.ToArray();
			return true;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00005004 File Offset: 0x00004404
		private void CleanDevList()
		{
			global::msclr.@lock @lock = null;
			global::msclr.@lock lock2 = new global::msclr.@lock(this.lockObj);
			try
			{
				@lock = lock2;
				global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer>.Enumerator enumerator = this.devListCache.GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						global::custom_datatypes.MLEPeer mlepeer = enumerator.Current;
						this.raise_OnStatusChange(null, new global::LEAdaptor.StatusChangeEventArgs
						{
							eventType = 1U,
							peer = mlepeer
						});
					}
					while (enumerator.MoveNext());
				}
				this.devListCache.Clear();
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00004CD4 File Offset: 0x000040D4
		private int StartLinkEstablishment()
		{
			return global::<Module>.PeerManager.StartLinkEstablishment(this.manager);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00004CEC File Offset: 0x000040EC
		private int StopLinkEstablishment()
		{
			return global::<Module>.PeerManager.StopLinkEstablishment(this.manager);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000053B8 File Offset: 0x000047B8
		internal unsafe virtual void OnInternalEvent(uint eventType, uint eventID, uint peerID)
		{
			int num = (int)stackalloc byte[global::<Module>.__CxxQueryExceptionSize()];
			uint exceptionCode;
			try
			{
				if (peerID != 0U)
				{
					if (eventType == 4096U)
					{
						this.OnPeerMapUpdated();
					}
					else if (eventType == 4119U && eventID == 4U)
					{
						this.OnLinkRemoved(peerID);
					}
				}
			}
			catch (global::System.Exception ex)
			{
				object[] args = new object[0];
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.StackTrace, args);
			}
			catch when (delegate
			{
				// Failed to create a 'catch-when' expression
				exceptionCode = (uint)global::System.Runtime.InteropServices.Marshal.GetExceptionCode();
				endfilter(global::<Module>.__CxxExceptionFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), null, 0, null) != null);
			})
			{
				uint num2 = 0U;
				global::<Module>.__CxxRegisterExceptionObject(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers(), num);
				try
				{
					try
					{
						object[] args2 = new object[0];
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Error occurs!", args2);
						return;
					}
					catch when (delegate
					{
						// Failed to create a 'catch-when' expression
						num2 = global::<Module>.__CxxDetectRethrow(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers());
						endfilter(num2 != 0U);
					})
					{
					}
					if (num2 != 0U)
					{
						throw;
					}
				}
				finally
				{
					global::<Module>.__CxxUnregisterExceptionObject(num, (int)num2);
				}
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004A94 File Offset: 0x00003E94
		public unsafe MRemoteSystem(byte localType, uint localID, ushort localPort, string remoteHostNameOrAddress, ushort remotePort, ushort systemType, byte[] authKey)
		{
			try
			{
				this.localType = localType;
				this.localID = localID;
				this.localPort = localPort;
				this.remoteHostNameOrAddress = remoteHostNameOrAddress;
				this.remotePort = remotePort;
				this.systemType = systemType;
				this.authKey = authKey;
				global::MCallBack* ptr = global::<Module>.@new(8U);
				global::MCallBack* ptr2;
				try
				{
					if (ptr != null)
					{
						ptr2 = global::<Module>.MCallBack.{ctor}(ptr, this);
					}
					else
					{
						ptr2 = 0;
					}
				}
				catch
				{
					global::<Module>.delete((void*)ptr);
					throw;
				}
				this.commFeedBack = ptr2;
				global::PeerManager* ptr3 = global::<Module>.@new(480U);
				global::PeerManager* ptr4;
				try
				{
					if (ptr3 != null)
					{
						ptr4 = global::<Module>.PeerManager.{ctor}(ptr3, this.commFeedBack);
					}
					else
					{
						ptr4 = 0;
					}
				}
				catch
				{
					global::<Module>.delete((void*)ptr3);
					throw;
				}
				this.manager = ptr4;
				this.lockObj = new object();
			}
			catch
			{
				base.Dispose(true);
				throw;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004FD4 File Offset: 0x000043D4
		private unsafe void ~MRemoteSystem()
		{
			global::PeerManager* ptr = this.manager;
			if (ptr != null)
			{
				global::<Module>.PeerManager.{dtor}(ptr);
				global::<Module>.delete((void*)ptr);
			}
			global::<Module>.delete((void*)this.commFeedBack);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004BA0 File Offset: 0x00003FA0
		public unsafe override int Open()
		{
			bool flag = false;
			byte[] array = this.authKey;
			byte* ptr;
			if (array != null)
			{
				flag = true;
				ptr = global::<Module>.new[]((uint)array.Length);
				int num = 0;
				array = this.authKey;
				if (0 < array.Length)
				{
					do
					{
						num[ptr] = array[num];
						num++;
						array = this.authKey;
					}
					while (num < array.Length);
				}
			}
			uint num2 = 0U;
			try
			{
				foreach (global::System.Net.IPAddress ipaddress in global::System.Net.Dns.GetHostAddresses(this.remoteHostNameOrAddress))
				{
					if (ipaddress.AddressFamily == global::System.Net.Sockets.AddressFamily.InterNetwork)
					{
						num2 = global::System.BitConverter.ToUInt32(ipaddress.GetAddressBytes(), 0);
						break;
					}
				}
			}
			catch (global::System.Exception)
			{
				num2 = 0U;
			}
			if (num2 == 0U)
			{
				object[] args = new object[]
				{
					this.remoteHostNameOrAddress,
					this.remotePort
				};
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("no valid IPv4 address found for LE system [{0}:{1}]!", args);
			}
			int num3 = global::<Module>.PeerManager.InitPeer(this.manager, this.localType, this.localID, this.localPort, num2, this.remotePort, this.systemType, flag, ptr);
			if (flag)
			{
				global::<Module>.delete[]((void*)ptr);
			}
			if (num3 != null)
			{
				return num3;
			}
			return global::<Module>.PeerManager.StartLinkEstablishment(this.manager);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000050A0 File Offset: 0x000044A0
		public override int Close()
		{
			this.CleanDevList();
			global::<Module>.PeerManager.SendDeregistrationToAll(this.manager);
			return global::<Module>.PeerManager.StopLinkEstablishment(this.manager);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004D04 File Offset: 0x00004104
		public unsafe override int SendProxyConnectRequest(uint targetPeerID, uint sourceIP, ushort sourcePort, byte connectionType, out ushort response)
		{
			ushort num2;
			int num = global::<Module>.PeerManager.SendProxyConnectRequest(this.manager, targetPeerID, sourceIP, sourcePort, connectionType, &num2);
			if (num == null)
			{
				response = num2;
			}
			return num;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000050CC File Offset: 0x000044CC
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		public override bool GetPeerMapData(out global::custom_datatypes.MLEPeer[] peers)
		{
			global::msclr.@lock @lock = null;
			global::msclr.@lock lock2 = new global::msclr.@lock(this.lockObj);
			try
			{
				@lock = lock2;
				peers = this.devListCache.ToArray();
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			return true;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000049AC File Offset: 0x00003DAC
		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool A_0)
		{
			if (A_0)
			{
				try
				{
					this.~MRemoteSystem();
					return;
				}
				finally
				{
					base.Dispose(true);
				}
			}
			base.Dispose(false);
		}

		// Token: 0x040000B0 RID: 176
		private unsafe global::PeerManager* manager;

		// Token: 0x040000B1 RID: 177
		private unsafe global::CommFeedBack* commFeedBack;

		// Token: 0x040000B2 RID: 178
		private byte localType;

		// Token: 0x040000B3 RID: 179
		private uint localID;

		// Token: 0x040000B4 RID: 180
		private ushort localPort;

		// Token: 0x040000B5 RID: 181
		private string remoteHostNameOrAddress;

		// Token: 0x040000B6 RID: 182
		private ushort remotePort;

		// Token: 0x040000B7 RID: 183
		private ushort systemType;

		// Token: 0x040000B8 RID: 184
		private byte[] authKey;

		// Token: 0x040000B9 RID: 185
		private readonly global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer> devListCache = new global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer>();

		// Token: 0x040000BA RID: 186
		private object lockObj;
	}
}
