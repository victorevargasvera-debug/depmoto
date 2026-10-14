using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using custom_datatypes;
using Motorola.Common.Communication.CommonUtil;
using msclr;
using std;

namespace LEAdaptor
{
	// Token: 0x02000015 RID: 21
	public class EmeraldRemoteSystem : global::LEAdaptor.RemoteSystemBase
	{
		// Token: 0x06000116 RID: 278 RVA: 0x000016DC File Offset: 0x00000ADC
		private string Uint2IPString(uint ip)
		{
			string text = "";
			int num = 24;
			do
			{
				text += (byte)(ip >> num);
				if (num > 0)
				{
					text += ".";
				}
				num -= 8;
			}
			while (num >= 0);
			return text;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002294 File Offset: 0x00001694
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		private unsafe bool GetPeerMapDataInternal(ref global::custom_datatypes.MLEPeer[] peers)
		{
			global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer> list = new global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer>();
			global::ncm_device_id_iterator_s* ptr = global::<Module>.ncm_device_id_iterator_new(this.context);
			if (global::<Module>.ncm_device_id_iterator_has_next(ptr) == 1)
			{
				do
				{
					global::custom_datatypes.MLEPeer item = default(global::custom_datatypes.MLEPeer);
					uint num = global::<Module>.ncm_device_id_iterator_get_next(ptr);
					global::ncm_device_s* ptr2 = global::<Module>.ncm_device_new(this.context, num);
					if (ptr2 != null)
					{
						if (global::<Module>.ncm_device_get_uint_attribute(ptr2, (sbyte*)(&global::<Module>.??_C@_0M@KJEGLGCO@device_type?$AA@)) == null)
						{
							global::<Module>.ncm_device_delete(ptr2);
						}
						else
						{
							item.IP = this.Uint2IPString(global::<Module>.ncm_device_get_ip(ptr2));
							item.ID = num;
							item.Port = global::<Module>.ncm_device_get_uint_attribute(ptr2, (sbyte*)(&global::<Module>.??_C@_08ECDLIGGO@ncm_port?$AA@));
							byte master = (1 == global::<Module>.ncm_device_get_bool_attribute(ptr2, (sbyte*)(&global::<Module>.??_C@_0BE@HOIBHHNG@active_intermediary?$AA@))) ? 1 : 0;
							item.Master = (master != 0);
							item.SerialNumber = new string(global::<Module>.ncm_device_get_string_attribute(ptr2, (sbyte*)(&global::<Module>.??_C@_0O@GDPEAHKI@serial_number?$AA@)));
							global::<Module>.ncm_device_delete(ptr2);
							list.Add(item);
						}
					}
				}
				while (global::<Module>.ncm_device_id_iterator_has_next(ptr) == 1);
			}
			global::<Module>.ncm_device_id_iterator_delete(ptr);
			peers = list.ToArray();
			return true;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000387C File Offset: 0x00002C7C
		private void OnInternalEvent(uint args1, uint args2, uint args3)
		{
			if (args1 != 0U)
			{
				if (args1 != 1U)
				{
					if (args1 == 3U)
					{
						this.OnProxyConnectionResponse(args2, args3);
					}
				}
				else
				{
					this.OnTCChanged(args2, args3);
				}
			}
			else
			{
				this.OnDeviceChanged(args2, args3);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002380 File Offset: 0x00001780
		private unsafe void OnDeviceChanged(uint status, uint deviceID)
		{
			global::msclr.@lock @lock = null;
			global::System.ValueType valueType = null;
			global::msclr.@lock lock2 = null;
			global::msclr.@lock lock3 = null;
			if (global::<Module>.ncm_context_get_local_device_id(this.context) != deviceID)
			{
				global::ncm_device_s* ptr = global::<Module>.ncm_device_new(this.context, deviceID);
				if (status != 1U)
				{
					if (ptr == null)
					{
						return;
					}
					if (global::<Module>.ncm_device_get_uint_attribute(ptr, (sbyte*)(&global::<Module>.??_C@_0M@KJEGLGCO@device_type?$AA@)) != null)
					{
						global::<Module>.ncm_device_delete(ptr);
						return;
					}
				}
				if (status != 0U)
				{
					if (status != 1U)
					{
						if (status == 2U)
						{
							global::System.ValueType valueType2 = null;
							global::custom_datatypes.MLEPeer mlepeer = default(global::custom_datatypes.MLEPeer);
							bool flag = false;
							global::msclr.@lock lock4 = new global::msclr.@lock(this.lockObj);
							try
							{
								lock3 = lock4;
								if (this.context != null)
								{
									goto IL_9F;
								}
							}
							catch
							{
								((global::System.IDisposable)lock3).Dispose();
								throw;
							}
							((global::System.IDisposable)lock3).Dispose();
							return;
							IL_9F:
							try
							{
								mlepeer.ID = deviceID;
								mlepeer.IP = this.Uint2IPString(global::<Module>.ncm_device_get_ip(ptr));
								mlepeer.Port = global::<Module>.ncm_device_get_uint_attribute(ptr, (sbyte*)(&global::<Module>.??_C@_08ECDLIGGO@ncm_port?$AA@));
								byte master = (1 == global::<Module>.ncm_device_get_bool_attribute(ptr, (sbyte*)(&global::<Module>.??_C@_0BE@HOIBHHNG@active_intermediary?$AA@))) ? 1 : 0;
								mlepeer.Master = (master != 0);
								mlepeer.SerialNumber = new string(global::<Module>.ncm_device_get_string_attribute(ptr, (sbyte*)(&global::<Module>.??_C@_0O@GDPEAHKI@serial_number?$AA@)));
								int num = this.devListCache.Count - 1;
								if (num >= 0)
								{
									while (this.devListCache[num].ID != deviceID)
									{
										num--;
										if (num < 0)
										{
											goto IL_1AA;
										}
									}
									valueType2 = this.devListCache[num];
									if (!((global::custom_datatypes.MLEPeer)valueType2).SerialNumber.Equals(mlepeer.SerialNumber, global::System.StringComparison.Ordinal) || !((global::custom_datatypes.MLEPeer)valueType2).IP.Equals(mlepeer.IP, global::System.StringComparison.Ordinal) || ((global::custom_datatypes.MLEPeer)valueType2).Port != mlepeer.Port)
									{
										flag = true;
										this.devListCache.RemoveAt(num);
									}
								}
								IL_1AA:
								if (valueType2 == null)
								{
									flag = true;
								}
								else if (!flag)
								{
									goto IL_1D0;
								}
								this.devListCache.Add(mlepeer);
							}
							catch
							{
								((global::System.IDisposable)lock3).Dispose();
								throw;
							}
							IL_1D0:
							((global::System.IDisposable)lock3).Dispose();
							if (flag)
							{
								global::LEAdaptor.StatusChangeEventArgs statusChangeEventArgs = new global::LEAdaptor.StatusChangeEventArgs();
								if (valueType2 != null)
								{
									statusChangeEventArgs.eventType = 1U;
									statusChangeEventArgs.peer = valueType2;
									this.raise_OnStatusChange(null, statusChangeEventArgs);
								}
								statusChangeEventArgs.eventType = 0U;
								statusChangeEventArgs.peer = mlepeer;
								this.raise_OnStatusChange(null, statusChangeEventArgs);
							}
						}
					}
					else
					{
						global::System.ValueType valueType3 = null;
						global::msclr.@lock lock5 = new global::msclr.@lock(this.lockObj);
						try
						{
							lock2 = lock5;
							if (this.context != null)
							{
								goto IL_25B;
							}
						}
						catch
						{
							((global::System.IDisposable)lock2).Dispose();
							throw;
						}
						((global::System.IDisposable)lock2).Dispose();
						return;
						IL_25B:
						try
						{
							int num2 = this.devListCache.Count - 1;
							if (num2 >= 0)
							{
								while (this.devListCache[num2].ID != deviceID)
								{
									num2--;
									if (num2 < 0)
									{
										goto IL_2BB;
									}
								}
								valueType3 = this.devListCache[num2];
								this.devListCache.RemoveAt(num2);
							}
						}
						catch
						{
							((global::System.IDisposable)lock2).Dispose();
							throw;
						}
						IL_2BB:
						((global::System.IDisposable)lock2).Dispose();
						if (valueType3 != null)
						{
							this.raise_OnStatusChange(null, new global::LEAdaptor.StatusChangeEventArgs
							{
								peer = valueType3,
								eventType = 1U
							});
						}
					}
				}
				else
				{
					bool flag2 = false;
					global::msclr.@lock lock6 = new global::msclr.@lock(this.lockObj);
					try
					{
						@lock = lock6;
						if (this.context != null)
						{
							goto IL_323;
						}
					}
					catch
					{
						((global::System.IDisposable)@lock).Dispose();
						throw;
					}
					((global::System.IDisposable)@lock).Dispose();
					return;
					IL_323:
					global::System.ValueType valueType4;
					try
					{
						valueType4 = default(global::custom_datatypes.MLEPeer);
						((global::custom_datatypes.MLEPeer)valueType4).ID = deviceID;
						((global::custom_datatypes.MLEPeer)valueType4).IP = this.Uint2IPString(global::<Module>.ncm_device_get_ip(ptr));
						((global::custom_datatypes.MLEPeer)valueType4).Port = global::<Module>.ncm_device_get_uint_attribute(ptr, (sbyte*)(&global::<Module>.??_C@_08ECDLIGGO@ncm_port?$AA@));
						byte master2 = (1 == global::<Module>.ncm_device_get_bool_attribute(ptr, (sbyte*)(&global::<Module>.??_C@_0BE@HOIBHHNG@active_intermediary?$AA@))) ? 1 : 0;
						((global::custom_datatypes.MLEPeer)valueType4).Master = (master2 != 0);
						((global::custom_datatypes.MLEPeer)valueType4).SerialNumber = new string(global::<Module>.ncm_device_get_string_attribute(ptr, (sbyte*)(&global::<Module>.??_C@_0O@GDPEAHKI@serial_number?$AA@)));
						int num3 = this.devListCache.Count - 1;
						if (num3 >= 0)
						{
							do
							{
								global::custom_datatypes.MLEPeer mlepeer2 = this.devListCache[num3];
								if (mlepeer2.ID == deviceID)
								{
									flag2 = true;
								}
								else if (string.Equals(mlepeer2.SerialNumber, ((global::custom_datatypes.MLEPeer)valueType4).SerialNumber))
								{
									valueType = this.devListCache[num3];
									this.devListCache.RemoveAt(num3);
								}
								num3--;
							}
							while (num3 >= 0);
							if (flag2)
							{
								goto IL_43B;
							}
						}
						this.devListCache.Add((global::custom_datatypes.MLEPeer)valueType4);
					}
					catch
					{
						((global::System.IDisposable)@lock).Dispose();
						throw;
					}
					IL_43B:
					((global::System.IDisposable)@lock).Dispose();
					if (valueType != null)
					{
						this.raise_OnStatusChange(null, new global::LEAdaptor.StatusChangeEventArgs
						{
							eventType = 1U,
							peer = valueType
						});
					}
					if (!flag2)
					{
						this.raise_OnStatusChange(null, new global::LEAdaptor.StatusChangeEventArgs
						{
							eventType = 0U,
							peer = valueType4
						});
					}
				}
				if (ptr != null)
				{
					global::<Module>.ncm_device_delete(ptr);
				}
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000028B8 File Offset: 0x00001CB8
		private void OnTCChanged(uint stauts, uint deviceID)
		{
			if (stauts != 0U)
			{
				if (stauts == 1U)
				{
					global::LEAdaptor.StatusChangeEventArgs statusChangeEventArgs = new global::LEAdaptor.StatusChangeEventArgs();
					statusChangeEventArgs.eventType = 2U;
					global::System.ValueType valueType = default(global::custom_datatypes.MLEPeer);
					((global::custom_datatypes.MLEPeer)valueType).ID = deviceID;
					((global::custom_datatypes.MLEPeer)valueType).Master = true;
					statusChangeEventArgs.peer = valueType;
					this.raise_OnStatusChange(null, statusChangeEventArgs);
				}
			}
			else
			{
				global::LEAdaptor.StatusChangeEventArgs statusChangeEventArgs2 = new global::LEAdaptor.StatusChangeEventArgs();
				statusChangeEventArgs2.eventType = 3U;
				global::System.ValueType valueType2 = default(global::custom_datatypes.MLEPeer);
				((global::custom_datatypes.MLEPeer)valueType2).ID = deviceID;
				((global::custom_datatypes.MLEPeer)valueType2).Master = true;
				statusChangeEventArgs2.peer = valueType2;
				this.raise_OnStatusChange(null, statusChangeEventArgs2);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00003550 File Offset: 0x00002950
		private unsafe void OnProxyConnectionResponse(uint peerID, uint response)
		{
			global::msclr.@lock @lock = null;
			global::msclr.@lock lock2 = new global::msclr.@lock(this.proxyMapLockObj);
			try
			{
				@lock = lock2;
				global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>;
				global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>.lower_bound(this.pcHandlerMap, &list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>, ref peerID);
				global::std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>* ptr = this.pcHandlerMap;
				global::std._List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020> list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2 = *ptr;
				if (((((list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> == list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>2) ? 1 : 0) == 0) ? 1 : 0) != 0)
				{
					global::ProxyConnectionHandler* ptr2 = *(list_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020> + 8 + 4);
					*(int*)(ptr2 + 4 / sizeof(global::ProxyConnectionHandler)) = (int)response;
					*(byte*)(ptr2 + 8 / sizeof(global::ProxyConnectionHandler)) = 1;
					if (global::<Module>.SetEvent(*(int*)ptr2) == null)
					{
						object[] args = new object[0];
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Failed to flag event for proxy connection response.", args);
					}
				}
				else
				{
					object[] args2 = new object[0];
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning("No handle found for proxy connection response.", args2);
				}
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00001D64 File Offset: 0x00001164
		private unsafe int StartLinkEstablishment()
		{
			global::msclr.@lock @lock = null;
			global::msclr.@lock lock2 = new global::msclr.@lock(this.lockObj);
			try
			{
				@lock = lock2;
				if (this.launcher != null)
				{
					goto IL_2D4;
				}
				if (this.context != null)
				{
					goto IL_2D4;
				}
				global::System.Net.IPAddress[] hostAddresses = global::System.Net.Dns.GetHostAddresses(this.remoteHostNameOrAddress);
				int num = 0;
				if (0 < hostAddresses.Length)
				{
					global::System.Net.IPAddress ipaddress;
					do
					{
						ipaddress = hostAddresses[num];
						if (ipaddress.AddressFamily == global::System.Net.Sockets.AddressFamily.InterNetwork)
						{
							goto IL_5D;
						}
						num++;
					}
					while (num < hostAddresses.Length);
					goto IL_7D;
					IL_5D:
					byte[] addressBytes = ipaddress.GetAddressBytes();
					global::System.Array.Reverse(addressBytes);
					uint num2 = global::System.BitConverter.ToUInt32(addressBytes, 0);
					if (num2 != 0U)
					{
						goto IL_C0;
					}
				}
				IL_7D:
				object[] args = new object[]
				{
					this.remoteHostNameOrAddress,
					this.remotePort
				};
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("no valid IPv4 address found for dmr3 system [{0}:{1}]!", args);
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			return -1;
			IL_C0:
			try
			{
				global::ncm_launcher_s* ptr = global::<Module>.ncm_launcher_new();
				this.launcher = ptr;
				uint num2;
				global::<Module>.ncm_launcher_set_uint_param(ptr, (sbyte*)(&global::<Module>.??_C@_0BA@HGEGKAKG@intermediary_ip?$AA@), num2);
				global::<Module>.ncm_launcher_set_uint_param(this.launcher, (sbyte*)(&global::<Module>.??_C@_0BC@FHCHHMDH@intermediary_port?$AA@), (uint)this.remotePort);
				global::<Module>.ncm_launcher_set_uint_param(this.launcher, (sbyte*)(&global::<Module>.??_C@_0M@KJEGLGCO@device_type?$AA@), 5U);
				global::<Module>.ncm_launcher_set_uint_param(this.launcher, (sbyte*)(&global::<Module>.??_C@_0P@KBBLMGIL@device_version?$AA@), this.deviceVersion);
				global::<Module>.ncm_launcher_set_uint_param(this.launcher, (sbyte*)(&global::<Module>.??_C@_09ILJBNCDK@system_id?$AA@), (uint)this.systemID);
				global::<Module>.ncm_launcher_set_uint_param(this.launcher, (sbyte*)(&global::<Module>.??_C@_07LCLEEJMB@site_id?$AA@), (uint)this.siteID);
				global::<Module>.ncm_launcher_set_uint_param(this.launcher, (sbyte*)(&global::<Module>.??_C@_0BB@GJPEBHLM@redundancy_group?$AA@), (uint)this.redundancyGrpID);
				global::<Module>.ncm_launcher_set_uint_param(this.launcher, (sbyte*)(&global::<Module>.??_C@_07OBNBLOPK@peer_id?$AA@), this.peerID);
				global::<Module>.ncm_launcher_set_uint_param(this.launcher, (sbyte*)(&global::<Module>.??_C@_09CEHJOGG@base_port?$AA@), (uint)this.basePort);
				global::<Module>.ncm_launcher_set_uint_param(this.launcher, (sbyte*)(&global::<Module>.??_C@_0N@BDFJOGL@device_model?$AA@), 2U);
				global::ncm_context_s* ptr2 = global::<Module>.ncm_context_new(this.launcher);
				this.context = ptr2;
				if (global::<Module>.ncm_context_register_callback(ptr2, (sbyte*)(&global::<Module>.??_C@_0BG@PFOHBEAL@onDeviceStatusChanged?$AA@), this.ncmVersion, global::<Module>.__unep@?onDeviceStatusChanged@?A0x174d99bf@LEAdaptor@@$$FYGXPAXPBX@Z, (void*)this.callBack) != null)
				{
					goto IL_20F;
				}
				object[] args2 = new object[]
				{
					this.remoteHostNameOrAddress,
					this.remotePort
				};
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("register callbacks failed on dmr3 system [{0}:{1}]!", args2);
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			return -1;
			IL_20F:
			try
			{
				if (global::<Module>.ncm_context_register_callback(this.context, (sbyte*)(&global::<Module>.??_C@_0CB@DBMELCLL@onTrunkedControllerStatusChanged@), this.ncmVersion, global::<Module>.__unep@?onTCStautsChanged@?A0x174d99bf@LEAdaptor@@$$FYGXPAXPBX@Z, (void*)this.callBack) != null)
				{
					goto IL_246;
				}
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			return 0;
			IL_246:
			try
			{
				if (global::<Module>.ncm_context_register_callback(this.context, (sbyte*)(&global::<Module>.??_C@_0BB@FGMHEJBE@onRoleAssignment?$AA@), this.ncmVersion, global::<Module>.__unep@?OnRoleAssignment@?A0x174d99bf@LEAdaptor@@$$FYGXPAXPBX@Z, (void*)this.callBack) != null)
				{
					goto IL_27D;
				}
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			return 0;
			IL_27D:
			try
			{
				if (global::<Module>.ncm_context_register_callback(this.context, (sbyte*)(&global::<Module>.??_C@_0BI@EEJJFHEG@onRRPConnectionResponse?$AA@), this.ncmVersion, global::<Module>.__unep@?OnRRPConnectionResponse@?A0x174d99bf@LEAdaptor@@$$FYGXPAXPBX@Z, (void*)this.callBack) != null)
				{
					goto IL_2B4;
				}
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			return 0;
			IL_2B4:
			int result;
			try
			{
				result = global::<Module>.ncm_context_start(this.context);
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			return result;
			IL_2D4:
			try
			{
				object[] args3 = new object[]
				{
					this.remoteHostNameOrAddress,
					this.remotePort
				};
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("open on a not closed dmr3 system [{0}:{1}]!", args3);
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			return -1;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002130 File Offset: 0x00001530
		private unsafe int StopLinkEstablishment()
		{
			global::msclr.@lock @lock = null;
			global::msclr.@lock lock2 = null;
			global::msclr.@lock lock3 = new global::msclr.@lock(this.lockObj);
			try
			{
				@lock = lock3;
				global::ncm_context_s* ptr = this.context;
				if (ptr != null)
				{
					global::<Module>.ncm_context_delete(ptr);
					this.context = null;
				}
				global::ncm_launcher_s* ptr2 = this.launcher;
				if (ptr2 != null)
				{
					global::<Module>.ncm_launcher_delete(ptr2);
					this.launcher = null;
				}
				global::msclr.@lock lock4 = new global::msclr.@lock(this.lockObj);
				try
				{
					lock2 = lock4;
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
					((global::System.IDisposable)lock2).Dispose();
					throw;
				}
				((global::System.IDisposable)lock2).Dispose();
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			return 0;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004234 File Offset: 0x00003634
		public unsafe EmeraldRemoteSystem(string remoteHostNameOrAddress, ushort remotePort, uint deviceVersion, ushort systemID, ushort siteID, byte redundancyGrpID, uint peerID, ushort basePort)
		{
			try
			{
				this.remoteHostNameOrAddress = remoteHostNameOrAddress;
				this.remotePort = remotePort;
				this.deviceVersion = deviceVersion;
				this.systemID = systemID;
				this.siteID = siteID;
				this.redundancyGrpID = redundancyGrpID;
				this.peerID = peerID;
				this.ncmVersion = global::<Module>.ncm_version();
				this.basePort = basePort;
				global::std.unordered_map<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* ptr = global::<Module>.@new(32U);
				global::std.unordered_map<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* ptr2;
				try
				{
					if (ptr != null)
					{
						global::std._Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020> uhash_compare<unsigned_u0020int,std::hash<unsigned_u0020int>,std::equal_to<unsigned_u0020int>_u0020>;
						global::std.allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020> allocator<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>;
						global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>.{ctor}(ptr, ref uhash_compare<unsigned_u0020int,std::hash<unsigned_u0020int>,std::equal_to<unsigned_u0020int>_u0020>, ref allocator<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>);
						ptr2 = ptr;
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
				this.pcHandlerMap = ptr2;
				this.proxyMapLockObj = new object();
				this.lockObj = new object();
				global::CallbackCrossAppdomain* ptr3 = global::<Module>.@new(12U);
				global::CallbackCrossAppdomain* ptr4;
				try
				{
					if (ptr3 != null)
					{
						ptr4 = global::<Module>.CallbackCrossAppdomain.{ctor}(ptr3, new global::CallbackDelegate(this.OnInternalEvent));
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
				this.callBack = ptr4;
			}
			catch
			{
				base.Dispose(true);
				throw;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00003E94 File Offset: 0x00003294
		private unsafe void ~EmeraldRemoteSystem()
		{
			try
			{
				this.Close();
			}
			finally
			{
				global::CallbackCrossAppdomain* ptr = this.callBack;
				if (ptr != null)
				{
					global::CallbackCrossAppdomain* ptr2 = ptr;
					object obj = calli(System.Void* modopt(System.Runtime.CompilerServices.CallConvThiscall)(System.IntPtr,System.UInt32), ptr2, 1, *(*(int*)ptr2));
				}
				global::std.unordered_map<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* ptr3 = this.pcHandlerMap;
				if (ptr3 != null)
				{
					global::<Module>.std.unordered_map<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>.__delDtor(ptr3, 1U);
				}
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000029E4 File Offset: 0x00001DE4
		public override int Open()
		{
			int result;
			int num = result = 0;
			if (1 != this.StartLinkEstablishment())
			{
				result = ~num;
			}
			return result;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000029FC File Offset: 0x00001DFC
		public override int Close()
		{
			return this.StopLinkEstablishment();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000043C8 File Offset: 0x000037C8
		public unsafe override int SendProxyConnectRequest(uint targetPeerID, uint sourceIP, ushort sourcePort, byte connectionType, out ushort response)
		{
			global::msclr.@lock @lock = null;
			global::msclr.@lock lock2 = null;
			int num = 0;
			global::ProxyConnectionHandler proxyConnectionHandler = 0;
			*(ref proxyConnectionHandler + 4) = 0;
			*(ref proxyConnectionHandler + 8) = 0;
			proxyConnectionHandler = global::<Module>.CreateEventW(null, 0, 0, null);
			global::msclr.@lock lock3 = new global::msclr.@lock(this.proxyMapLockObj);
			global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,bool> pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,bool>2;
			try
			{
				@lock = lock3;
				global::ProxyConnectionHandler* ptr = &proxyConnectionHandler;
				global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,bool> pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,bool>;
				global::std.pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>\u0020>,bool>* ptr2 = global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>.emplace<unsigned\u0020int\u0020&,struct\u0020ProxyConnectionHandler\u0020*>(this.pcHandlerMap, &pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,bool>, ref targetPeerID, ref ptr);
				*(ref pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,bool>2 + 4) = *(ptr2 + 4);
			}
			catch
			{
				((global::System.IDisposable)@lock).Dispose();
				throw;
			}
			((global::System.IDisposable)@lock).Dispose();
			if (*(ref pair<std::_List_iterator<std::_List_val<std::_List_simple_types<std::pair<unsigned_u0020int_u0020const_u0020,ProxyConnectionHandler_u0020*>_u0020>_u0020>_u0020>,bool>2 + 4) == 0)
			{
				return 1;
			}
			if (global::<Module>.ncm_context_rrp_connection_request(this.context, targetPeerID, sourcePort) == null)
			{
				num = 1;
			}
			else
			{
				global::<Module>.WaitForSingleObject(proxyConnectionHandler, 60000);
			}
			global::msclr.@lock lock4 = new global::msclr.@lock(this.proxyMapLockObj);
			try
			{
				lock2 = lock4;
				global::<Module>.std._Hash<std::_Umap_traits<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::_Uhash_compare<unsigned\u0020int,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>\u0020>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>,0>\u0020>.erase(this.pcHandlerMap, ref targetPeerID);
			}
			catch
			{
				((global::System.IDisposable)lock2).Dispose();
				throw;
			}
			((global::System.IDisposable)lock2).Dispose();
			global::<Module>.CloseHandle(proxyConnectionHandler);
			if (*(ref proxyConnectionHandler + 8) == 1)
			{
				response = (ushort)(*(ref proxyConnectionHandler + 4));
			}
			else
			{
				num = ((num == 0) ? 1 : num);
			}
			return num;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000223C File Offset: 0x0000163C
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

		// Token: 0x06000124 RID: 292 RVA: 0x00004158 File Offset: 0x00003558
		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool A_0)
		{
			if (A_0)
			{
				try
				{
					this.~EmeraldRemoteSystem();
					return;
				}
				finally
				{
					base.Dispose(true);
				}
			}
			base.Dispose(false);
		}

		// Token: 0x0400009B RID: 155
		private unsafe global::ncm_launcher_s* launcher;

		// Token: 0x0400009C RID: 156
		private unsafe global::ncm_context_s* context;

		// Token: 0x0400009D RID: 157
		private string remoteHostNameOrAddress;

		// Token: 0x0400009E RID: 158
		private ushort remotePort;

		// Token: 0x0400009F RID: 159
		private uint deviceVersion;

		// Token: 0x040000A0 RID: 160
		private ushort systemID;

		// Token: 0x040000A1 RID: 161
		private ushort siteID;

		// Token: 0x040000A2 RID: 162
		private byte redundancyGrpID;

		// Token: 0x040000A3 RID: 163
		private uint peerID;

		// Token: 0x040000A4 RID: 164
		private uint ncmVersion;

		// Token: 0x040000A5 RID: 165
		private ushort basePort;

		// Token: 0x040000A6 RID: 166
		private unsafe global::std.unordered_map<unsigned\u0020int,ProxyConnectionHandler\u0020*,std::hash<unsigned\u0020int>,std::equal_to<unsigned\u0020int>,std::allocator<std::pair<unsigned\u0020int\u0020const\u0020,ProxyConnectionHandler\u0020*>\u0020>\u0020>* pcHandlerMap;

		// Token: 0x040000A7 RID: 167
		private object proxyMapLockObj;

		// Token: 0x040000A8 RID: 168
		private unsafe global::CallbackCrossAppdomain* callBack;

		// Token: 0x040000A9 RID: 169
		private readonly global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer> devListCache = new global::System.Collections.Generic.List<global::custom_datatypes.MLEPeer>();

		// Token: 0x040000AA RID: 170
		private object lockObj;
	}
}
