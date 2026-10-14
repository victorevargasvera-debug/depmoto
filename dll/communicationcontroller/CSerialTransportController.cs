using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using custom_exception;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Service;

namespace CommunicationController
{
	// Token: 0x02000023 RID: 35
	public class CSerialTransportController : global::CommunicationController.ISerialTransportController
	{
		// Token: 0x06000115 RID: 277 RVA: 0x0000CAD8 File Offset: 0x0000BAD8
		public static void AddGlobalVirualLocalDevices(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devinfo)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 0:
					IL_08:
					break;
				case 1:
					goto IL_53;
				case 2:
					global::CommunicationController.CSerialTransportController.d = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
					num = 1;
					continue;
				}
				if (true)
				{
				}
				if (global::CommunicationController.CSerialTransportController.d == null)
				{
					num = 2;
					continue;
				}
				IL_53:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_08;
				default:
					goto IL_69;
				}
			}
			IL_69:
			if (false)
			{
			}
			global::CommunicationController.CSerialTransportController.d.Add(devinfo);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000CB60 File Offset: 0x0000BB60
		public static void CleanGlobalVirtualLocalDevices()
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_4A:
				if (global::CommunicationController.CSerialTransportController.d == null)
				{
					return;
				}
				num = 1;
				break;
			default:
				if (false)
				{
				}
				num = 0;
				break;
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_2E;
				case 1:
					global::CommunicationController.CSerialTransportController.d.Clear();
					num = 2;
					continue;
				case 2:
					return;
				}
				goto IL_4A;
			}
			IL_2E:
			if (true)
			{
			}
			goto IL_4A;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000CBDC File Offset: 0x0000BBDC
		public CSerialTransportController()
		{
			this.b = null;
			this.c = null;
			if (global::CommunicationController.AppStartupMode.AppMode == global::CommunicationController.StartUpMode.Standalone && !global::CommunicationController.AppStartupMode.IsRMCCall)
			{
				global::CommunicationController.DeviceDiscoveryWrapper.GetInstance();
			}
		}

		// Token: 0x1700000F RID: 15
		public global::CommunicationController.CSerialTransportController.STCConnection this[uint uiHandle]
		{
			get
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
				return this.b[uiHandle];
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000CC60 File Offset: 0x0000BC60
		public void OpenController()
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
			this.b = new global::System.Collections.Generic.Dictionary<uint, global::CommunicationController.CSerialTransportController.STCConnection>();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000CCA8 File Offset: 0x0000BCA8
		public void CloseController()
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					goto IL_47;
				case 2:
					goto IL_47;
				case 3:
					goto IL_65;
				case 4:
				{
					if (this.b.Count <= 0)
					{
						num = 3;
						continue;
					}
					uint uiHandle = this.b.Keys.First<uint>();
					this.Close(uiHandle);
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						if (true)
						{
						}
						if (false)
						{
						}
						num = 1;
						continue;
					}
					break;
				}
				case 5:
					num = 2;
					continue;
				}
				if (this.b != null)
				{
					num = 5;
					continue;
				}
				break;
				IL_47:
				num = 4;
			}
			IL_65:
			this.b = null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000CD7C File Offset: 0x0000BD7C
		public global::CommunicationController.ISerialTransportController GetPointer()
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
			return this;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000CDB8 File Offset: 0x0000BDB8
		public static void ListConnectedDevices(out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> infos, global::Motorola.Common.Communication.CommonUtil.ConnectionType connectionType)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					for (;;)
					{
						infos = null;
						int num = 2;
						for (;;)
						{
							int num2;
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>.Enumerator enumerator;
							switch (num)
							{
							case 0:
								if (global::CommunicationController.CSerialTransportController.d.Count == 0)
								{
									num = 3;
									continue;
								}
								infos = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
								num2 = 0;
								if (true)
								{
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									if (false)
									{
									}
									num = 1;
									continue;
								}
								break;
							case 1:
								goto IL_1C8;
							case 2:
								if (global::CommunicationController.CSerialTransportController.d != null)
								{
									num = 6;
									continue;
								}
								goto IL_11D;
							case 3:
								goto IL_11D;
							case 4:
								return;
							case 5:
								try
								{
									num = 0;
									for (;;)
									{
										switch (num)
										{
										case 1:
											num = 2;
											continue;
										case 2:
											goto IL_10A;
										case 3:
										{
											if (!enumerator.MoveNext())
											{
												num = 1;
												continue;
											}
											global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = enumerator.Current;
											deviceInfo.ConnectionInfo.SessionID = 0;
											num = 4;
											continue;
										}
										}
										IL_C5:
										num = 3;
										continue;
										goto IL_C5;
									}
									IL_10A:
									return;
								}
								finally
								{
									((global::System.IDisposable)enumerator).Dispose();
								}
								goto Block_3;
							case 6:
								num = 0;
								continue;
							case 7:
								goto IL_1C8;
							case 8:
								if (num2 >= global::CommunicationController.CSerialTransportController.d.Count)
								{
									num = 4;
									continue;
								}
								goto IL_156;
							}
							break;
							IL_156:
							global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo2 = global::CommunicationController.CRadioCodeplugController.DeSerialize(global::CommunicationController.CRadioCodeplugController.Serialize(global::CommunicationController.CSerialTransportController.d[num2]));
							deviceInfo2.ConnectionInfo.SessionID = 0;
							infos.Add(deviceInfo2);
							num2++;
							num = 7;
							continue;
							Block_3:
							try
							{
								IL_11D:
								infos = global::CommunicationController.DeviceDiscoveryWrapper.GetInstance().ListConnectedDevices((int)connectionType);
								goto IL_1F2;
							}
							catch (global::System.Exception ex)
							{
								global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
								throw global::CommunicationController.CCustomExceptionHandler.CreateException(8242U, "CSerialTransportController", "ListConnectedDevices", ex.StackTrace.ToString());
							}
							goto IL_156;
							IL_1F2:
							enumerator = infos.GetEnumerator();
							num = 5;
							continue;
							IL_1C8:
							num = 8;
						}
					}
				}
				return;
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000CFF0 File Offset: 0x0000BFF0
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, out uint A_1, bool A_2, global::Motorola.Common.Communication.CommonUtil.RadioOperation A_3)
		{
			switch (0)
			{
			default:
			{
				int num = 0;
				global::Motorola.Common.Communication.Service.IDeviceOperation deviceOperation;
				global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo pcrdeviceInfo;
				global::CommunicationController.CSerialTransportController.DeviceServiceHandler deviceServiceHandler;
				for (;;)
				{
					switch (num)
					{
					case 1:
						if (A_2)
						{
							num = 3;
							continue;
						}
						goto IL_316;
					case 2:
						if (true)
						{
						}
						goto IL_114;
					case 3:
						goto IL_172;
					case 4:
					{
						try
						{
							for (;;)
							{
								ushort sessionID = deviceOperation.OpenSession(A_0, A_3, null);
								A_0.ConnectionInfo.SessionID = sessionID;
								num = 3;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_27A;
									case 1:
										pcrdeviceInfo = (deviceOperation.ReadExtendedDeviceInfo(A_0) as global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo);
										pcrdeviceInfo.ConnectionInfo.SessionID = sessionID;
										num = 0;
										continue;
									case 2:
										goto IL_283;
									case 3:
										if (A_2)
										{
											num = 1;
											continue;
										}
										goto IL_27A;
									}
									break;
									IL_27A:
									num = 2;
								}
							}
							IL_283:
							goto IL_192;
						}
						catch (global::System.Exception ex)
						{
							try
							{
								num = 3;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_2E5;
									case 1:
										deviceOperation.CloseSession(A_0, true);
										A_0.ConnectionInfo.SessionID = 0;
										num = 0;
										continue;
									case 2:
										goto IL_2EE;
									}
									if (A_0.ConnectionInfo.SessionID != 0)
									{
										num = 1;
										continue;
									}
									IL_2E5:
									num = 2;
								}
								IL_2EE:;
							}
							catch
							{
							}
							global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
							throw global::CommunicationController.CCustomExceptionHandler.CreateException(595U, string.Empty, string.Empty, ex.StackTrace);
						}
						goto IL_316;
						IL_192:
						A_1 = 0U;
						global::System.Collections.Generic.Dictionary<uint, global::CommunicationController.CSerialTransportController.STCConnection>.KeyCollection.Enumerator enumerator = this.b.Keys.GetEnumerator();
						num = 6;
						continue;
					}
					case 5:
						goto IL_55;
					case 6:
						try
						{
							num = 4;
							for (;;)
							{
								switch (num)
								{
								case 0:
								{
									global::System.Collections.Generic.Dictionary<uint, global::CommunicationController.CSerialTransportController.STCConnection>.KeyCollection.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = 2;
										continue;
									}
									uint num2 = enumerator.Current;
									num = 6;
									continue;
								}
								case 1:
								{
									uint num2;
									A_1 = num2;
									num = 3;
									continue;
								}
								case 2:
									num = 5;
									continue;
								case 5:
									goto IL_104;
								case 6:
								{
									uint num2;
									if (A_1 < num2)
									{
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_104;
										default:
											if (false)
											{
											}
											num = 1;
											continue;
										}
									}
									break;
								}
								}
								IL_D8:
								num = 0;
								continue;
								goto IL_D8;
							}
							IL_104:
							goto IL_14E;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<uint, global::CommunicationController.CSerialTransportController.STCConnection>.KeyCollection.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_3;
					}
					if (A_0 == null)
					{
						num = 5;
						continue;
					}
					deviceServiceHandler = new global::CommunicationController.CSerialTransportController.DeviceServiceHandler();
					deviceOperation = null;
					num = 2;
					continue;
					IL_14E:
					A_1 += 1U;
					num = 1;
					continue;
					Block_3:
					try
					{
						IL_114:
						deviceOperation = global::Motorola.Common.Communication.Service.DeviceServiceManager.Instance().GetDeviceOperationService(deviceServiceHandler);
						goto IL_1CF;
					}
					catch (global::System.Exception ex2)
					{
						global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex2);
						throw global::CommunicationController.CCustomExceptionHandler.CreateException(50U, base.GetType().ToString(), "DeviceDiscoveryWrapper", global::System.Environment.StackTrace.ToString());
					}
					goto IL_14E;
					IL_1CF:
					pcrdeviceInfo = null;
					num = 4;
				}
				IL_55:
				global::custom_exception.CCustomException ex3 = global::CommunicationController.CCustomExceptionHandler.CreateException(595U, base.GetType().ToString(), "InitCommunicationService", global::System.Environment.StackTrace.ToString());
				throw ex3;
				IL_172:
				this.b.Add(A_1, new global::CommunicationController.CSerialTransportController.STCConnection(deviceOperation, deviceServiceHandler, pcrdeviceInfo));
				return;
				IL_316:
				this.b.Add(A_1, new global::CommunicationController.CSerialTransportController.STCConnection(deviceOperation, deviceServiceHandler, A_0));
				return;
			}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000D35C File Offset: 0x0000C35C
		public void Open(string strIPaddress, uint uiProtocolType, uint uiProtocolPortNumber, out uint uiHandle)
		{
			switch (0)
			{
			default:
			{
				uiHandle = 0U;
				try
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list;
					global::CommunicationController.CSerialTransportController.ListConnectedDevices(out list, global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter);
					goto IL_E3;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				goto IL_FE;
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo a_;
				for (;;)
				{
					IL_E3:
					a_ = null;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list;
					using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>.Enumerator enumerator = list.GetEnumerator())
					{
						int num = 2;
						for (;;)
						{
							global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
							switch (num)
							{
							case 0:
								goto IL_C7;
							case 1:
								goto IL_80;
							case 3:
								goto IL_D3;
							case 4:
								if (enumerator.MoveNext())
								{
									deviceInfo = enumerator.Current;
									num = 5;
									continue;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_80;
								default:
									if (false)
									{
									}
									num = 6;
									continue;
								}
								break;
							case 5:
								if (true)
								{
								}
								if (deviceInfo.ConnectionInfo.UniqueAddress == strIPaddress)
								{
									num = 1;
									continue;
								}
								break;
							case 6:
								goto IL_C7;
							}
							IL_47:
							num = 4;
							continue;
							goto IL_47;
							IL_80:
							a_ = deviceInfo;
							num = 0;
							continue;
							IL_C7:
							num = 3;
						}
						IL_D3:
						break;
					}
				}
				IL_FE:
				this.a(a_, out uiHandle, true, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
				return;
			}
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000D49C File Offset: 0x0000C49C
		public void Close(uint uiHandle)
		{
			try
			{
				try
				{
					int num = 6;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (this.b[uiHandle].DevInfo.ConnectionInfo.SessionID != 0)
							{
								num = 7;
								continue;
							}
							goto IL_F7;
						case 1:
							num = 0;
							continue;
						case 2:
							goto IL_102;
						case 3:
							num = 4;
							continue;
						case 4:
							if (this.b.ContainsKey(uiHandle))
							{
								num = 1;
								continue;
							}
							goto IL_F7;
						case 5:
							goto IL_F7;
						case 7:
							this.b[uiHandle].DSC.CloseSession(this.b[uiHandle].DevInfo, true);
							this.b[uiHandle].DevInfo.ConnectionInfo.SessionID = 0;
							num = 5;
							continue;
						}
						if (this.b != null)
						{
							num = 3;
							continue;
						}
						IL_F7:
						num = 2;
					}
					IL_102:;
				}
				catch
				{
				}
				if (true)
				{
				}
			}
			finally
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_15F;
					case 2:
						goto IL_161;
					case 3:
						this.b.Remove(uiHandle);
						num = 0;
						continue;
					case 4:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_161;
						default:
							if (false)
							{
							}
							if (this.b.ContainsKey(uiHandle))
							{
								num = 3;
								continue;
							}
							goto IL_19D;
						}
						break;
					}
					if (this.b != null)
					{
						num = 2;
						continue;
					}
					break;
					IL_161:
					num = 4;
				}
				IL_15F:
				IL_19D:;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000D688 File Offset: 0x0000C688
		public void CloseRemote(uint uiHandle)
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
			this.Close(uiHandle);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000D6CC File Offset: 0x0000C6CC
		public void Listen(uint uiProtocolType, uint uiProtocolPortNumber, string certificate, string pswd)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				global::CommunicationController.CSerialTransportController.ListConnectedDevices(out this.c, global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork);
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000D728 File Offset: 0x0000C728
		public void Accept(out uint uiHandle, uint peerID, uint Timeout, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				if (false)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo a_ = null;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>.Enumerator enumerator = this.c.GetEnumerator();
				for (;;)
				{
					try
					{
						int num = 0;
						for (;;)
						{
							switch (num)
							{
							case 1:
							{
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
								if (global::System.Convert.ToUInt32(deviceInfo.RadioID, global::System.Globalization.NumberFormatInfo.InvariantInfo) == peerID)
								{
									num = 5;
									continue;
								}
								break;
							}
							case 2:
								goto IL_CB;
							case 3:
								goto IL_CB;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = 3;
									continue;
								}
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = enumerator.Current;
								num = 1;
								continue;
							}
							case 5:
							{
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
								a_ = deviceInfo;
								num = 2;
								continue;
							}
							case 6:
								goto IL_D3;
							}
							IL_A4:
							num = 4;
							continue;
							goto IL_A4;
							IL_CB:
							num = 6;
						}
						IL_D3:
						goto IL_36;
					}
					finally
					{
						if (true)
						{
						}
						((global::System.IDisposable)enumerator).Dispose();
					}
					break;
					try
					{
						IL_36:
						this.a(a_, out uiHandle, false, operationType);
						break;
					}
					catch (global::custom_exception.CCustomException)
					{
						throw;
					}
				}
				break;
			}
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000D840 File Offset: 0x0000C840
		public void ListConnectedDevices(out global::System.Collections.ArrayList alDeviceList)
		{
			for (;;)
			{
				alDeviceList = new global::System.Collections.ArrayList();
				try
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list;
					global::CommunicationController.CSerialTransportController.ListConnectedDevices(out list, global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter);
					goto IL_8A;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				goto IL_A3;
				for (;;)
				{
					IL_8A:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list;
					using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>.Enumerator enumerator = list.GetEnumerator())
					{
						int num = 4;
						for (;;)
						{
							switch (num)
							{
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = 3;
									continue;
								}
								global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = enumerator.Current;
								alDeviceList.Add(deviceInfo.ConnectionInfo.UniqueAddress);
								num = 0;
								continue;
							}
							case 2:
								goto IL_7A;
							case 3:
								num = 2;
								continue;
							}
							IL_32:
							num = 1;
							continue;
							goto IL_32;
						}
						IL_7A:
						break;
					}
				}
				IL_A3:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_B9;
				}
			}
			IL_B9:
			if (false)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000D93C File Offset: 0x0000C93C
		public void ReadBlocking(uint uiHandle, byte[] readBuffer, uint bytesRequested, out uint bytesReturned, uint timeout)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			bytesReturned = 0U;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000D97C File Offset: 0x0000C97C
		public void WriteBlocking(uint uiHandle, byte[] writeBuffer, uint numberOfBytes)
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

		// Token: 0x06000126 RID: 294 RVA: 0x0000D9BC File Offset: 0x0000C9BC
		public bool ValidateRemotePassword(uint uiHandle, string userName, string password)
		{
			switch (0)
			{
			default:
			{
				bool flag = false;
				try
				{
					for (;;)
					{
						IL_2B:
						flag = this.b[uiHandle].DSC.ValidateRemotePassword(this.b[uiHandle].DevInfo, userName, password);
						for (;;)
						{
							IL_55:
							int num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_10B;
								case 1:
								{
									global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo pcrdevinfo = this.b[uiHandle].DSC.ReadExtendedDeviceInfo(this.b[uiHandle].DevInfo) as global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo;
									global::Motorola.Common.Communication.Service.IDeviceOperation dsc = this.b[uiHandle].DSC;
									global::CommunicationController.CSerialTransportController.DeviceServiceHandler dsh = this.b[uiHandle].DSH;
									this.b.Remove(uiHandle);
									this.b.Add(uiHandle, new global::CommunicationController.CSerialTransportController.STCConnection(dsc, dsh, pcrdevinfo));
									num = 0;
									continue;
								}
								case 2:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_55;
									default:
										if (false)
										{
										}
										if (flag)
										{
											num = 1;
											continue;
										}
										goto IL_10B;
									}
									break;
								case 3:
									goto IL_117;
								}
								goto IL_2B;
								IL_10B:
								num = 3;
							}
						}
					}
					IL_117:;
				}
				catch (global::System.Exception ex)
				{
					global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
					throw global::CommunicationController.CCustomExceptionHandler.CreateException(1053U, "CSerialTransportController", "ValidateRemotePassword", ex.StackTrace.ToString());
				}
				if (true)
				{
				}
				return flag;
			}
			}
		}

		// Token: 0x0400006D RID: 109
		private const string a = "{8442AEE9-C610-4FEB-8577-2977C98C6DE2}";

		// Token: 0x0400006E RID: 110
		private global::System.Collections.Generic.Dictionary<uint, global::CommunicationController.CSerialTransportController.STCConnection> b;

		// Token: 0x0400006F RID: 111
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> c;

		// Token: 0x04000070 RID: 112
		private static global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> d;

		// Token: 0x02000024 RID: 36
		[global::System.ServiceModel.CallbackBehavior(UseSynchronizationContext = false)]
		public class DeviceServiceHandler : global::Motorola.Common.Communication.Service.IOperationServiceEvent
		{
			// Token: 0x14000002 RID: 2
			// (add) Token: 0x06000127 RID: 295 RVA: 0x0000DB3C File Offset: 0x0000CB3C
			// (remove) Token: 0x06000128 RID: 296 RVA: 0x0000DBD4 File Offset: 0x0000CBD4
			public event global::CommunicationController.CSerialTransportController.DeviceServiceHandler.OnProgressEventHandler OnProgressHandler
			{
				add
				{
					for (;;)
					{
						int num;
						global::CommunicationController.CSerialTransportController.DeviceServiceHandler.OnProgressEventHandler onProgressEventHandler;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_7C:
							num = 2;
							break;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							onProgressEventHandler = this.a;
							num = 1;
							break;
						}
						for (;;)
						{
							global::CommunicationController.CSerialTransportController.DeviceServiceHandler.OnProgressEventHandler onProgressEventHandler2;
							switch (num)
							{
							case 0:
								if (onProgressEventHandler == onProgressEventHandler2)
								{
									goto IL_7C;
								}
								goto IL_49;
							case 1:
								goto IL_49;
							case 2:
								return;
							}
							break;
							IL_49:
							onProgressEventHandler2 = onProgressEventHandler;
							global::CommunicationController.CSerialTransportController.DeviceServiceHandler.OnProgressEventHandler value2 = (global::CommunicationController.CSerialTransportController.DeviceServiceHandler.OnProgressEventHandler)global::System.Delegate.Combine(onProgressEventHandler2, value);
							onProgressEventHandler = global::System.Threading.Interlocked.CompareExchange<global::CommunicationController.CSerialTransportController.DeviceServiceHandler.OnProgressEventHandler>(ref this.a, value2, onProgressEventHandler2);
							num = 0;
						}
					}
				}
				remove
				{
					for (;;)
					{
						int num;
						global::CommunicationController.CSerialTransportController.DeviceServiceHandler.OnProgressEventHandler onProgressEventHandler;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_72:
							num = 2;
							break;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							onProgressEventHandler = this.a;
							num = 0;
							break;
						}
						for (;;)
						{
							global::CommunicationController.CSerialTransportController.DeviceServiceHandler.OnProgressEventHandler onProgressEventHandler2;
							switch (num)
							{
							case 0:
								goto IL_49;
							case 1:
								if (onProgressEventHandler == onProgressEventHandler2)
								{
									goto IL_72;
								}
								goto IL_49;
							case 2:
								return;
							}
							break;
							IL_49:
							onProgressEventHandler2 = onProgressEventHandler;
							global::CommunicationController.CSerialTransportController.DeviceServiceHandler.OnProgressEventHandler value2 = (global::CommunicationController.CSerialTransportController.DeviceServiceHandler.OnProgressEventHandler)global::System.Delegate.Remove(onProgressEventHandler2, value);
							onProgressEventHandler = global::System.Threading.Interlocked.CompareExchange<global::CommunicationController.CSerialTransportController.DeviceServiceHandler.OnProgressEventHandler>(ref this.a, value2, onProgressEventHandler2);
							num = 1;
						}
					}
				}
			}

			// Token: 0x06000129 RID: 297 RVA: 0x0000DC68 File Offset: 0x0000CC68
			public void OnProgress(int percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus)
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 2:
						for (;;)
						{
							this.a(percent, processStatus);
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_5B;
							}
						}
						IL_5B:
						if (false)
						{
						}
						if (true)
						{
						}
						num = 0;
						continue;
					}
					if (this.a == null)
					{
						break;
					}
					num = 2;
				}
			}

			// Token: 0x0600012A RID: 298 RVA: 0x0000DCE8 File Offset: 0x0000CCE8
			public void OnClientStatusCheck()
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

			// Token: 0x04000071 RID: 113
			private global::CommunicationController.CSerialTransportController.DeviceServiceHandler.OnProgressEventHandler a;

			// Token: 0x02000025 RID: 37
			// (Invoke) Token: 0x0600012D RID: 301
			public delegate void OnProgressEventHandler(int percent, global::Motorola.Common.Communication.CommonUtil.ProgressStatus processStatus);
		}

		// Token: 0x02000026 RID: 38
		public class STCConnection
		{
			// Token: 0x06000130 RID: 304 RVA: 0x0000DD38 File Offset: 0x0000CD38
			public STCConnection(global::Motorola.Common.Communication.Service.IDeviceOperation dsc, global::CommunicationController.CSerialTransportController.DeviceServiceHandler dsh, global::Motorola.Common.Communication.CommonUtil.DeviceInfo pcrdevinfo)
			{
				this.a = dsc;
				this.b = dsh;
				this.c = pcrdevinfo;
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000131 RID: 305 RVA: 0x0000DD60 File Offset: 0x0000CD60
			public global::Motorola.Common.Communication.Service.IDeviceOperation DSC
			{
				get
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
					return this.a;
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000132 RID: 306 RVA: 0x0000DDA4 File Offset: 0x0000CDA4
			public global::CommunicationController.CSerialTransportController.DeviceServiceHandler DSH
			{
				get
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
					return this.b;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000133 RID: 307 RVA: 0x0000DDE8 File Offset: 0x0000CDE8
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo DevInfo
			{
				get
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
					return this.c;
				}
			}

			// Token: 0x04000072 RID: 114
			private global::Motorola.Common.Communication.Service.IDeviceOperation a;

			// Token: 0x04000073 RID: 115
			private global::CommunicationController.CSerialTransportController.DeviceServiceHandler b;

			// Token: 0x04000074 RID: 116
			private global::Motorola.Common.Communication.CommonUtil.DeviceInfo c;
		}
	}
}
