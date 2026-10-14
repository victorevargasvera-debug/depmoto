using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using CommunicationController;
using constants;
using custom_exception;
using DeviceUpdate;
using IshHandler;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Service;
using Motorola.Common.CustomException;
using RegistryAccess;

namespace UpdateController
{
	// Token: 0x02000017 RID: 23
	public class a
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x0001A868 File Offset: 0x00019868
		public bool f()
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
			return this.l;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0001A8AC File Offset: 0x000198AC
		public void a(bool A_0)
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
			this.l = A_0;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0001A8F0 File Offset: 0x000198F0
		public bool e()
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
			return this.o;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0001A934 File Offset: 0x00019934
		private void a(int A_0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus A_1)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				default:
					for (;;)
					{
						int num = 0;
						int num2 = this.k / 8;
						int num3 = 9;
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (A_1)
								{
								case global::Motorola.Common.Communication.CommonUtil.ProgressStatus.BootCommitting:
									num3 = 3;
									continue;
								case global::Motorola.Common.Communication.CommonUtil.ProgressStatus.BootCommittingDone:
								case global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingBootDataDone:
									goto IL_1C9;
								case global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingBootData:
									num = num2;
									this.p = true;
									num3 = 2;
									continue;
								case global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingBootData:
									num = num2 * 2;
									num3 = 12;
									continue;
								default:
									num3 = 6;
									continue;
								}
								break;
							case 1:
								num = num2 * ((this.q == global::UpdateController.a.b.c) ? 2 : 1);
								this.p = true;
								num3 = 18;
								continue;
							case 2:
								goto IL_1C9;
							case 3:
								num = num2 * (this.p ? 4 : 6);
								num3 = 8;
								continue;
							case 4:
								goto IL_243;
							case 5:
								num = num2 * (this.p ? 6 : 8);
								num3 = 19;
								continue;
							case 6:
								num3 = 20;
								continue;
							case 7:
							{
								if (true)
								{
								}
								int num4;
								this.j(num4);
								this.i = A_0;
								num3 = 4;
								continue;
							}
							case 8:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_00;
								default:
									if (false)
									{
									}
									goto IL_1C9;
								}
								break;
							case 9:
								switch (A_1)
								{
								case global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage:
									num3 = 1;
									continue;
								case global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage:
									num3 = 5;
									continue;
								default:
									num3 = 13;
									continue;
								}
								break;
							case 10:
							{
								int num4 = (A_0 - this.i) * num / 100;
								num3 = 15;
								continue;
							}
							case 11:
								return;
							case 12:
								goto IL_1C9;
							case 13:
								num3 = 0;
								continue;
							case 14:
								this.i = 0;
								num3 = 11;
								continue;
							case 15:
							{
								int num4;
								if (num4 >= 1)
								{
									num3 = 7;
									continue;
								}
								goto IL_243;
							}
							case 16:
								if (A_0 == 100)
								{
									num3 = 14;
									continue;
								}
								return;
							case 17:
								if (this.j != null)
								{
									num3 = 10;
									continue;
								}
								return;
							case 18:
								goto IL_1C9;
							case 19:
								goto IL_1C9;
							case 20:
								goto IL_1C9;
							}
							break;
							IL_1C9:
							num3 = 17;
							continue;
							IL_243:
							num3 = 16;
						}
					}
					break;
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0001ABB8 File Offset: 0x00019BB8
		public a()
		{
			this.d = null;
			this.c = null;
			this.m = false;
			this.b = null;
			this.i = 0;
			this.j = null;
			this.e = null;
			this.f = null;
			this.n = false;
			this.o = false;
			this.q = global::UpdateController.a.b.c;
			this.p = false;
			this.l = false;
			this.r = global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0001AC38 File Offset: 0x00019C38
		public a(bool A_0) : this()
		{
			this.r = (A_0 ? global::Motorola.Common.Communication.CommonUtil.RadioOperation.DepotFlash : global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0001AC64 File Offset: 0x00019C64
		public void a(ref string A_0)
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
			string[] array = this.b.ConnectionInfo.DeviceInstance.Split(new char[]
			{
				'#'
			});
			A_0 = array[2].ToLowerInvariant();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0001ACCC File Offset: 0x00019CCC
		public void a(uint A_0, global::CommunicationController.ISerialTransportController A_1, global::Motorola.Common.Communication.CommonUtil.ProductFamily A_2)
		{
			if (this.m)
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (true)
					{
					}
					if (false)
					{
					}
					break;
				}
				return;
			}
			A_1[A_0].DevInfo.Family = A_2;
			this.a(A_0, A_1);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0001AD2C File Offset: 0x00019D2C
		public void a(uint A_0, global::CommunicationController.ISerialTransportController A_1)
		{
			int num = 7;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					if (this.b.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRadio)
					{
						num = 4;
						continue;
					}
					goto IL_18B;
				case 1:
					if (this.b.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio)
					{
						num = 2;
						continue;
					}
					num = 0;
					continue;
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						if (false)
						{
						}
						this.q = global::UpdateController.a.b.c;
						num = 3;
						continue;
					}
					break;
				case 3:
					goto IL_A8;
				case 4:
					this.q = global::UpdateController.a.b.b;
					num = 5;
					continue;
				case 5:
					goto IL_C0;
				case 6:
					return;
				}
				if (this.m)
				{
					num = 6;
				}
				else
				{
					this.i = 0;
					this.d = A_1[A_0].DSH;
					this.c = A_1[A_0].DSC;
					this.b = A_1[A_0].DevInfo;
					this.c.ReadDeviceInfo(this.b);
					this.d.OnProgressHandler += this.a;
					this.e = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
					this.f = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
					this.m = true;
					this.o = ((global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)this.b).IsDualBoard;
					num = 1;
				}
			}
			return;
			IL_A8:
			IL_C0:
			IL_18B:
			this.p = false;
			this.l = false;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0001AED4 File Offset: 0x00019ED4
		public void a(global::Motorola.Common.Communication.Pba.PbaObject A_0, global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo A_1)
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
			this.b = A_1;
			this.g = A_0;
			this.l = true;
			this.q = global::UpdateController.a.b.c;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0001AF2C File Offset: 0x00019F2C
		public global::Motorola.Common.Communication.Pba.PbaObject b()
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
			return this.h;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0001AF70 File Offset: 0x00019F70
		public void a(global::Motorola.Common.Communication.Pba.PbaObject A_0)
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
			this.h = A_0;
			this.f = this.h.UpdateData;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0001AFC4 File Offset: 0x00019FC4
		public void a(global::DeviceUpdate.c.a A_0, ref global::System.Collections.ArrayList A_1)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::UpdateController.a.a a = new global::UpdateController.a.a();
					a.a = (global::constants.CCPTags.PcrPartition)0;
					int num = 5;
					for (;;)
					{
						if (true)
						{
						}
						global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
						switch (num)
						{
						case 0:
							try
							{
								num = 4;
								for (;;)
								{
									switch (num)
									{
									case 0:
										num = 1;
										continue;
									case 1:
										goto IL_21B;
									case 3:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = 0;
											continue;
										}
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock = enumerator.Current;
										global::IshHandler.m m = default(global::IshHandler.m);
										m.a = (ushort)((dataBlock.BlockType >> 8 & 255) | ((int)dataBlock.BlockType << 8 & 65280));
										m.b = (ushort)((dataBlock.BlockID >> 8 & 255) | ((int)dataBlock.BlockID << 8 & 65280));
										m.c = new byte[dataBlock.PacketValue.Length];
										global::System.Array.Copy(dataBlock.PacketValue, m.c, dataBlock.PacketValue.Length);
										A_1.Add(m);
										num = 2;
										continue;
									}
									}
									IL_1E9:
									num = 3;
									continue;
									goto IL_1E9;
								}
								IL_21B:
								return;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_22E;
						case 1:
							goto IL_D6;
						case 2:
							goto IL_D6;
						case 3:
							goto IL_22E;
						case 4:
							goto IL_BF;
						case 5:
							switch (A_0)
							{
							case global::DeviceUpdate.c.a.a:
								a.a = global::constants.CCPTags.PcrPartition.Security;
								num = 2;
								continue;
							case global::DeviceUpdate.c.a.b:
								a.a = global::constants.CCPTags.PcrPartition.Application;
								num = 11;
								continue;
							case global::DeviceUpdate.c.a.c:
								a.a = global::constants.CCPTags.PcrPartition.Tune;
								num = 8;
								continue;
							case global::DeviceUpdate.c.a.d:
								a.a = global::constants.CCPTags.PcrPartition.Cfs;
								num = 1;
								continue;
							default:
								num = 3;
								continue;
							}
							break;
						case 6:
							if (A_1 == null)
							{
								num = 12;
								continue;
							}
							goto IL_91;
						case 7:
							goto IL_D6;
						case 8:
							goto IL_D6;
						case 9:
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator = dataPartition.DataBlocks.GetEnumerator();
							num = 0;
							continue;
						}
						case 10:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_BF;
							default:
								if (false)
								{
								}
								goto IL_91;
							}
							break;
						case 11:
							goto IL_D6;
						case 12:
							A_1 = new global::System.Collections.ArrayList();
							num = 10;
							continue;
						}
						break;
						IL_91:
						dataPartition = this.g.CodeplugData.DataPartitions.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.DataPartition>(a.b));
						num = 4;
						continue;
						IL_BF:
						if (dataPartition != null)
						{
							num = 9;
							continue;
						}
						return;
						IL_D6:
						num = 6;
						continue;
						IL_22E:
						num = 7;
					}
				}
				return;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0001B2D4 File Offset: 0x0001A2D4
		public string c()
		{
			string result;
			for (;;)
			{
				result = string.Empty;
				try
				{
					result = this.c.ReadDeviceInfo(this.b).SerialNumber;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.Exception ex)
				{
					global::custom_exception.CCustomException.Rethrow(ex);
				}
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_55;
				}
			}
			IL_55:
			if (false)
			{
			}
			return result;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0001B35C File Offset: 0x0001A35C
		public void b(string A_0)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					try
					{
						ushort sessionID = this.c.OpenSession(this.b, this.r, null);
						this.b.ConnectionInfo.SessionID = sessionID;
						goto IL_1BD;
					}
					catch (global::System.Exception ex)
					{
						try
						{
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_139;
								case 1:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_12F;
									default:
										if (false)
										{
										}
										break;
									}
									break;
								case 2:
									this.c.CloseSession(this.b, true);
									this.b.ConnectionInfo.SessionID = 0;
									goto IL_12F;
								case 3:
									goto IL_141;
								}
								if (this.b.ConnectionInfo.SessionID != 0)
								{
									num = 2;
									continue;
								}
								goto IL_139;
								IL_12F:
								num = 0;
								continue;
								IL_139:
								num = 3;
							}
							IL_141:;
						}
						catch
						{
						}
						this.b = null;
						global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
						throw global::UpdateController.CCustomExceptionHandler.a(595U, base.GetType().ToString(), "Open", ex.StackTrace.ToString());
					}
					goto Block_3;
				case 2:
					return;
				case 3:
					goto IL_179;
				}
				if (this.m)
				{
					num = 2;
					continue;
				}
				this.d = new global::CommunicationController.CSerialTransportController.DeviceServiceHandler();
				this.d.OnProgressHandler += this.a;
				num = 3;
				continue;
				Block_3:
				try
				{
					IL_179:
					this.c = global::Motorola.Common.Communication.Service.DeviceServiceManager.Instance().GetDeviceOperationService(this.d);
					goto IL_32;
				}
				catch (global::System.Exception ex2)
				{
					global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex2);
					throw global::UpdateController.CCustomExceptionHandler.a(50U, base.GetType().ToString(), "DeviceDiscoveryWrapper", global::System.Environment.StackTrace.ToString());
				}
				goto IL_1BD;
				IL_32:
				this.b = global::CommunicationController.CRadioCodeplugController.DeSerialize(A_0);
				if (true)
				{
				}
				num = 0;
			}
			return;
			IL_1BD:
			this.i = 0;
			this.e = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
			this.f = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
			this.m = true;
			this.n = false;
			this.o = false;
			this.q = global::UpdateController.a.b.a;
			this.p = false;
			this.l = false;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0001B5A0 File Offset: 0x0001A5A0
		protected virtual void a()
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 1;
					for (;;)
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator;
						switch (num)
						{
						case 0:
						{
							try
							{
								num = 2;
								for (;;)
								{
									switch (num)
									{
									case 0:
									{
										if (!enumerator.MoveNext())
										{
											num = 3;
											continue;
										}
										global::Motorola.Common.Communication.Pba.RadioImage radioImage = enumerator.Current;
										global::System.IO.File.Delete(radioImage.FilePath);
										num = 1;
										continue;
									}
									case 3:
										num = 4;
										continue;
									case 4:
										goto IL_271;
									}
									IL_24B:
									num = 0;
									continue;
									goto IL_24B;
								}
								IL_271:
								goto IL_194;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_284;
							IL_194:
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator2 = this.f.MemoryImages.GetEnumerator();
							num = 2;
							continue;
						}
						case 2:
							try
							{
								num = 1;
								for (;;)
								{
									switch (num)
									{
									case 2:
										goto IL_E1;
									case 3:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator2;
										if (enumerator2.MoveNext())
										{
											global::Motorola.Common.Communication.Pba.RadioImage radioImage2 = enumerator2.Current;
											global::System.IO.File.Delete(radioImage2.FilePath);
											num = 0;
											continue;
										}
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_E1;
										default:
											if (false)
											{
											}
											num = 4;
											continue;
										}
										break;
									}
									case 4:
										num = 2;
										continue;
									}
									IL_81:
									num = 3;
									continue;
									goto IL_81;
								}
								IL_E1:
								goto IL_1B6;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto Block_4;
							IL_1B6:
							this.d.OnProgressHandler -= this.a;
							num = 3;
							continue;
						case 3:
							goto IL_284;
						case 4:
							goto IL_F4;
						case 5:
							goto IL_290;
						case 6:
							if (this.q == global::UpdateController.a.b.a)
							{
								num = 4;
								continue;
							}
							goto IL_1DE;
						case 7:
							goto IL_16F;
						}
						if (this.m)
						{
							num = 7;
							continue;
						}
						goto IL_284;
						IL_16F:
						num = 6;
						continue;
						Block_4:
						try
						{
							IL_F4:
							num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									this.c.CloseSession(this.b, true);
									this.b.ConnectionInfo.SessionID = 0;
									num = 1;
									continue;
								case 1:
									goto IL_161;
								case 3:
									goto IL_16A;
								}
								if (this.b.ConnectionInfo.SessionID != 0)
								{
									num = 0;
									continue;
								}
								IL_161:
								num = 3;
							}
							IL_16A:
							goto IL_1DE;
						}
						catch
						{
							goto IL_1DE;
						}
						goto IL_16F;
						IL_1DE:
						enumerator = this.e.MemoryImages.GetEnumerator();
						if (true)
						{
						}
						num = 0;
						continue;
						IL_284:
						num = 5;
					}
					IL_290:
					break;
				}
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0001B8B4 File Offset: 0x0001A8B4
		public void d()
		{
			switch (0)
			{
			default:
			{
				int num = 0;
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator;
					switch (num)
					{
					case 1:
						return;
					case 2:
						goto IL_176;
					case 3:
						goto IL_DC;
					case 4:
						if (this.q == global::UpdateController.a.b.a)
						{
							num = 3;
							continue;
						}
						goto IL_1EC;
					case 5:
					{
						try
						{
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_281;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = 4;
										continue;
									}
									global::Motorola.Common.Communication.Pba.RadioImage radioImage = enumerator.Current;
									global::System.IO.File.Delete(radioImage.FilePath);
									num = 3;
									continue;
								}
								case 4:
									num = 0;
									continue;
								}
								IL_25B:
								num = 2;
								continue;
								goto IL_25B;
							}
							IL_281:
							goto IL_19B;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						return;
						IL_19B:
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator2 = this.f.MemoryImages.GetEnumerator();
						num = 6;
						continue;
					}
					case 6:
						try
						{
							num = 3;
							for (;;)
							{
								switch (num)
								{
								case 0:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = 2;
										continue;
									}
									global::Motorola.Common.Communication.Pba.RadioImage radioImage2 = enumerator2.Current;
									global::System.IO.File.Delete(radioImage2.FilePath);
									num = 1;
									continue;
								}
								case 2:
									num = 4;
									continue;
								case 4:
									goto IL_C1;
								}
								IL_7D:
								num = 0;
								continue;
								goto IL_7D;
							}
							IL_C1:
							goto IL_1BD;
						}
						finally
						{
							if (true)
							{
							}
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto Block_3;
						IL_1BD:
						this.d.OnProgressHandler -= this.a;
						this.m = false;
						num = 1;
						continue;
					}
					if (this.m)
					{
						num = 2;
						continue;
					}
					break;
					IL_176:
					num = 4;
					continue;
					Block_3:
					try
					{
						IL_DC:
						num = 1;
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									if (false)
									{
									}
									break;
								}
								this.c.CloseSession(this.b, true);
								this.b.ConnectionInfo.SessionID = 0;
								num = 2;
								continue;
							case 2:
								goto IL_165;
							case 3:
								goto IL_171;
							}
							if (this.b.ConnectionInfo.SessionID != 0)
							{
								num = 0;
								continue;
							}
							IL_165:
							num = 3;
						}
						IL_171:
						goto IL_1EC;
					}
					catch
					{
						goto IL_1EC;
					}
					goto IL_176;
					IL_1EC:
					enumerator = this.e.MemoryImages.GetEnumerator();
					num = 5;
				}
				return;
			}
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0001BB80 File Offset: 0x0001AB80
		public void a(out global::System.Collections.ArrayList A_0)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (true)
				{
				}
				if (false)
				{
				}
				A_0 = new global::System.Collections.ArrayList();
				list = null;
				try
				{
					global::CommunicationController.CSerialTransportController.ListConnectedDevices(out list, global::Motorola.Common.Communication.CommonUtil.ConnectionType.Fudally);
					break;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				return;
			}
			for (;;)
			{
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>.Enumerator enumerator = list.GetEnumerator())
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_A5;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = 4;
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.DeviceInfo devinfo = enumerator.Current;
							A_0.Add(global::CommunicationController.CRadioCodeplugController.Serialize(devinfo));
							num = 3;
							continue;
						}
						case 4:
							num = 1;
							continue;
						}
						IL_62:
						num = 2;
						continue;
						goto IL_62;
					}
					IL_A5:
					break;
				}
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0001BC7C File Offset: 0x0001AC7C
		public bool g()
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
			return this.m;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0001BCC0 File Offset: 0x0001ACC0
		public bool a(string A_0)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_4A:
				num = 2;
				break;
			default:
				if (false)
				{
				}
				num = 1;
				break;
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_63;
				case 2:
					try
					{
						if (true)
						{
						}
						this.o = this.c.WriteRamdownloader(this.b, A_0);
						goto IL_54;
					}
					catch (global::System.Exception ex)
					{
						global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
						throw global::UpdateController.CCustomExceptionHandler.a(2946U, base.GetType().ToString(), "WriteRamdloader", ex.StackTrace.ToString());
					}
					goto IL_B4;
					IL_54:
					this.n = true;
					num = 0;
					continue;
				}
				break;
			}
			if (!this.n)
			{
				goto IL_4A;
			}
			IL_63:
			IL_B4:
			return this.o;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0001BD98 File Offset: 0x0001AD98
		public void a(string A_0, bool A_1, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType A_2)
		{
			global::Motorola.Common.Communication.Pba.RadioImage radioImage;
			for (;;)
			{
				radioImage = null;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_6C;
					case 1:
						if (this.b.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.PhoenixRadio)
						{
							num = 5;
							continue;
						}
						radioImage = new global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage();
						num = 4;
						continue;
					case 2:
						if (this.b.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRadio)
						{
							num = 3;
							continue;
						}
						goto IL_52;
					case 3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_50;
						default:
							if (false)
							{
							}
							if (true)
							{
							}
							num = 1;
							continue;
						}
						break;
					case 4:
						goto IL_50;
					case 5:
						goto IL_52;
					}
					break;
					IL_52:
					radioImage = new global::Motorola.Common.Communication.Pba.PcrMemoryImage();
					((global::Motorola.Common.Communication.Pba.PcrMemoryImage)radioImage).RemoteImage = A_1;
					num = 0;
				}
			}
			IL_50:
			IL_6C:
			radioImage.FilePath = A_0;
			radioImage.FileType = A_2;
			this.f.MemoryImages.Add(radioImage);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0001BE88 File Offset: 0x0001AE88
		public void a(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType A_0, int A_1, uint A_2, uint A_3, string A_4, out string A_5, bool A_6 = true)
		{
			switch (0)
			{
			default:
			{
				global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage;
				for (;;)
				{
					pcrFileSystemMemoryImage = null;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator = this.e.MemoryImages.GetEnumerator();
					int num = 5;
					for (;;)
					{
						string text;
						global::Motorola.Common.Communication.Pba.UpdateDeviceData updateDeviceData;
						switch (num)
						{
						case 0:
							goto IL_15E;
						case 1:
							if (pcrFileSystemMemoryImage == null)
							{
								num = 7;
								continue;
							}
							goto IL_3D5;
						case 2:
							if (text[text.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
							{
								num = 0;
								continue;
							}
							goto IL_2BF;
						case 3:
							goto IL_2BF;
						case 4:
							try
							{
								num = 3;
								for (;;)
								{
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										if (false)
										{
										}
										switch (num)
										{
										case 0:
											goto IL_E2;
										case 1:
											this.c.CloseSession(this.b, true);
											this.b.ConnectionInfo.SessionID = 0;
											num = 0;
											continue;
										case 2:
											goto IL_129;
										}
										break;
									}
									IL_97:
									if (this.b.ConnectionInfo.SessionID != 0)
									{
										num = 1;
										continue;
									}
									goto IL_E2;
									goto IL_97;
									IL_E2:
									this.b.ConnectionInfo.SessionID = this.c.OpenSession(this.b, this.r, null);
									this.c.ReadImage(this.b, updateDeviceData);
									num = 2;
								}
								IL_129:
								goto IL_30B;
							}
							catch (global::System.Exception ex)
							{
								global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
								throw global::UpdateController.CCustomExceptionHandler.a(2902U, base.GetType().ToString(), "ReadMemory", ex.StackTrace.ToString());
							}
							goto IL_15E;
							IL_30B:
							this.e.MemoryImages.Add(pcrFileSystemMemoryImage);
							num = 6;
							continue;
						case 5:
							try
							{
								num = 4;
								for (;;)
								{
									switch (num)
									{
									case 0:
									{
										global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage2;
										if (A_2 == pcrFileSystemMemoryImage2.StartId)
										{
											num = 8;
											continue;
										}
										break;
									}
									case 1:
										goto IL_2A0;
									case 2:
									{
										global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage2;
										pcrFileSystemMemoryImage = pcrFileSystemMemoryImage2;
										num = 10;
										continue;
									}
									case 3:
										num = 12;
										continue;
									case 5:
										num = 0;
										continue;
									case 6:
										goto IL_2AC;
									case 7:
									{
										global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage2;
										if (A_3 == pcrFileSystemMemoryImage2.EndId)
										{
											num = 3;
											continue;
										}
										break;
									}
									case 8:
										num = 7;
										continue;
									case 9:
									{
										global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage2;
										if (A_1 == pcrFileSystemMemoryImage2.PartitionId)
										{
											num = 5;
											continue;
										}
										break;
									}
									case 10:
										goto IL_2A0;
									case 11:
									{
										if (!enumerator.MoveNext())
										{
											num = 1;
											continue;
										}
										global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage2 = (global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage)enumerator.Current;
										num = 9;
										continue;
									}
									case 12:
									{
										global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage2;
										if (A_4 == pcrFileSystemMemoryImage2.RadioPathName)
										{
											num = 2;
											continue;
										}
										break;
									}
									}
									IL_1CA:
									num = 11;
									continue;
									goto IL_1CA;
									IL_2A0:
									num = 6;
								}
								IL_2AC:
								goto IL_3B2;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_2BF;
							IL_3B2:
							num = 1;
							continue;
						case 6:
							goto IL_328;
						case 7:
						{
							updateDeviceData = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
							pcrFileSystemMemoryImage = new global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage();
							pcrFileSystemMemoryImage.FileType = A_0;
							pcrFileSystemMemoryImage.PartitionId = A_1;
							pcrFileSystemMemoryImage.StartId = A_2;
							pcrFileSystemMemoryImage.EndId = A_3;
							pcrFileSystemMemoryImage.RadioPathName = A_4;
							pcrFileSystemMemoryImage.IsDirectory = A_6;
							global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings = new global::RegistryAccess.CPersistentApplicationSettings();
							text = string.Empty;
							persistentApplicationSettings.GetXferFolderPath(ref text);
							num = 2;
							continue;
						}
						}
						break;
						IL_15E:
						text += global::System.IO.Path.DirectorySeparatorChar;
						num = 3;
						continue;
						IL_2BF:
						pcrFileSystemMemoryImage.FilePath = text + global::System.Guid.NewGuid().ToString("D") + ".xml";
						updateDeviceData.MemoryImages.Add(pcrFileSystemMemoryImage);
						num = 4;
					}
				}
				IL_328:
				IL_3D5:
				if (true)
				{
				}
				A_5 = pcrFileSystemMemoryImage.FilePath;
				return;
			}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0001C2B0 File Offset: 0x0001B2B0
		public void a(int A_0, int A_1, bool A_2, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType A_3, out string A_4)
		{
			switch (0)
			{
			default:
			{
				global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage;
				for (;;)
				{
					int startAddress = 201326592 + A_0;
					int endAddress = 201326592 + A_1;
					pcrMemoryImage = null;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator = this.e.MemoryImages.GetEnumerator();
					int num = 4;
					for (;;)
					{
						global::Motorola.Common.Communication.Pba.UpdateDeviceData updateDeviceData;
						string text;
						switch (num)
						{
						case 0:
							goto IL_AF;
						case 1:
							try
							{
								this.c.ReadImage(this.b, updateDeviceData);
								goto IL_208;
							}
							catch (global::System.Exception ex)
							{
								global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
								throw global::UpdateController.CCustomExceptionHandler.a(2902U, base.GetType().ToString(), "ReadMemory", ex.StackTrace.ToString());
							}
							goto IL_AF;
							IL_208:
							this.e.MemoryImages.Add(pcrMemoryImage);
							num = 2;
							continue;
						case 2:
							goto IL_225;
						case 3:
							if (text[text.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
							{
								num = 0;
								continue;
							}
							goto IL_1BE;
						case 4:
							try
							{
								num = 4;
								for (;;)
								{
									switch (num)
									{
									case 0:
									{
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2;
										if (pcrMemoryImage2.FileType == A_3)
										{
											num = 6;
											continue;
										}
										break;
									}
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = 7;
											continue;
										}
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2 = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)enumerator.Current;
										num = 0;
										continue;
									}
									case 2:
									{
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2;
										if (pcrMemoryImage2.RemoteImage == A_2)
										{
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												if (false)
												{
												}
												num = 3;
												continue;
											}
										}
										break;
									}
									case 3:
									{
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2;
										pcrMemoryImage = pcrMemoryImage2;
										num = 5;
										continue;
									}
									case 5:
										goto IL_19F;
									case 6:
										num = 2;
										continue;
									case 7:
										goto IL_19F;
									case 8:
										goto IL_1AB;
									}
									IL_10B:
									num = 1;
									continue;
									IL_109:
									goto IL_10B;
									goto IL_109;
									IL_19F:
									num = 8;
								}
								IL_1AB:
								goto IL_2A5;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_1BE;
							IL_2A5:
							num = 5;
							continue;
						case 5:
							if (true)
							{
							}
							if (pcrMemoryImage == null)
							{
								num = 6;
								continue;
							}
							goto IL_2D0;
						case 6:
						{
							pcrMemoryImage = new global::Motorola.Common.Communication.Pba.PcrMemoryImage();
							pcrMemoryImage.StartAddress = startAddress;
							pcrMemoryImage.EndAddress = endAddress;
							pcrMemoryImage.FileType = A_3;
							pcrMemoryImage.RemoteImage = A_2;
							global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings = new global::RegistryAccess.CPersistentApplicationSettings();
							text = string.Empty;
							persistentApplicationSettings.GetXferFolderPath(ref text);
							num = 3;
							continue;
						}
						case 7:
							goto IL_1BE;
						}
						break;
						IL_AF:
						text += global::System.IO.Path.DirectorySeparatorChar;
						num = 7;
						continue;
						IL_1BE:
						pcrMemoryImage.FilePath = text + global::System.Guid.NewGuid().ToString("D") + ".srec";
						updateDeviceData = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
						updateDeviceData.MemoryImages.Add(pcrMemoryImage);
						num = 1;
					}
				}
				IL_225:
				IL_2D0:
				A_4 = pcrMemoryImage.FilePath;
				return;
			}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0001C5B4 File Offset: 0x0001B5B4
		public void a(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType> A_0, global::System.Collections.Generic.List<int> A_1, global::System.Collections.Generic.List<uint> A_2, global::System.Collections.Generic.List<uint> A_3, global::System.Collections.Generic.List<string> A_4, string A_5, bool A_6 = true)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::Motorola.Common.Communication.Pba.UpdateDeviceData updateDeviceData = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
					int num = 0;
					int num2 = 7;
					for (;;)
					{
						global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage;
						string text;
						switch (num2)
						{
						case 0:
							if (updateDeviceData.MemoryImages.Count > 0)
							{
								num2 = 8;
								continue;
							}
							return;
						case 1:
							num2 = 0;
							continue;
						case 2:
							goto IL_8D;
						case 3:
							return;
						case 4:
							goto IL_428;
						case 5:
							goto IL_245;
						case 6:
						{
							pcrFileSystemMemoryImage = new global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage();
							pcrFileSystemMemoryImage.FileType = A_0[num];
							pcrFileSystemMemoryImage.PartitionId = A_1[num];
							pcrFileSystemMemoryImage.StartId = A_2[num];
							pcrFileSystemMemoryImage.EndId = A_3[num];
							pcrFileSystemMemoryImage.RadioPathName = A_4[num];
							pcrFileSystemMemoryImage.IsDirectory = A_6;
							global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings = new global::RegistryAccess.CPersistentApplicationSettings();
							text = string.Empty;
							persistentApplicationSettings.GetXferFolderPath(ref text);
							num2 = 12;
							continue;
						}
						case 7:
							goto IL_245;
						case 8:
							try
							{
								num2 = 3;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_3D4;
									case 1:
										this.c.CloseSession(this.b, true);
										this.b.ConnectionInfo.SessionID = 0;
										num2 = 5;
										continue;
									case 2:
										this.c.ValidateRemotePassword(this.b, "Motorola", A_5);
										num2 = 0;
										continue;
									case 4:
										goto IL_3F3;
									case 5:
										goto IL_331;
									case 6:
										if (!string.IsNullOrEmpty(A_5))
										{
											num2 = 2;
											continue;
										}
										goto IL_3D4;
									}
									if (this.b.ConnectionInfo.SessionID != 0)
									{
										num2 = 1;
										continue;
									}
									IL_331:
									this.b.ConnectionInfo.SessionID = this.c.OpenSession(this.b, this.r, null);
									num2 = 6;
									continue;
									IL_3D4:
									this.c.ReadImage(this.b, updateDeviceData);
									num2 = 4;
								}
								IL_3F3:
								goto IL_278;
							}
							catch (global::System.Exception ex)
							{
								global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
								throw global::UpdateController.CCustomExceptionHandler.a(2902U, base.GetType().ToString(), "ReadMemory2Buffer", ex.StackTrace.ToString());
							}
							goto IL_428;
							IL_278:
							this.e.MemoryImages.AddRange(updateDeviceData.MemoryImages);
							num2 = 3;
							continue;
						case 9:
							try
							{
								num2 = 6;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											continue;
										default:
										{
											if (false)
											{
											}
											global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage2;
											if (A_3[num] == pcrFileSystemMemoryImage2.EndId)
											{
												num2 = 4;
												continue;
											}
											break;
										}
										}
										break;
									case 1:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num2 = 11;
											continue;
										}
										global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage2 = (global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage)enumerator.Current;
										num2 = 12;
										continue;
									}
									case 2:
									{
										global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage2;
										pcrFileSystemMemoryImage = pcrFileSystemMemoryImage2;
										num2 = 10;
										continue;
									}
									case 3:
										goto IL_232;
									case 4:
										num2 = 8;
										continue;
									case 5:
										num2 = 0;
										continue;
									case 7:
										num2 = 9;
										continue;
									case 8:
									{
										global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage2;
										if (A_4[num] == pcrFileSystemMemoryImage2.RadioPathName)
										{
											num2 = 2;
											continue;
										}
										break;
									}
									case 9:
									{
										global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage2;
										if (A_2[num] == pcrFileSystemMemoryImage2.StartId)
										{
											num2 = 5;
											continue;
										}
										break;
									}
									case 10:
										goto IL_226;
									case 11:
										goto IL_226;
									case 12:
									{
										global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrFileSystemMemoryImage2;
										if (A_1[num] == pcrFileSystemMemoryImage2.PartitionId)
										{
											num2 = 7;
											continue;
										}
										break;
									}
									}
									IL_1C1:
									num2 = 1;
									continue;
									goto IL_1C1;
									IL_226:
									num2 = 3;
								}
								IL_232:
								goto IL_2C3;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_245;
							IL_2C3:
							num2 = 13;
							continue;
						case 10:
						{
							if (num >= A_0.Count)
							{
								num2 = 1;
								continue;
							}
							pcrFileSystemMemoryImage = null;
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator = this.e.MemoryImages.GetEnumerator();
							num2 = 9;
							continue;
						}
						case 11:
							text += global::System.IO.Path.DirectorySeparatorChar;
							num2 = 2;
							continue;
						case 12:
							if (text[text.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
							{
								num2 = 11;
								continue;
							}
							goto IL_8D;
						case 13:
							if (pcrFileSystemMemoryImage == null)
							{
								num2 = 6;
								continue;
							}
							goto IL_428;
						}
						break;
						IL_8D:
						pcrFileSystemMemoryImage.FilePath = text + global::System.Guid.NewGuid().ToString("D") + ".xml";
						updateDeviceData.MemoryImages.Add(pcrFileSystemMemoryImage);
						if (true)
						{
						}
						num2 = 4;
						continue;
						IL_245:
						num2 = 10;
						continue;
						IL_428:
						num++;
						num2 = 5;
					}
				}
				return;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0001CAF8 File Offset: 0x0001BAF8
		public void a(global::System.Collections.Generic.List<int> A_0, global::System.Collections.Generic.List<int> A_1, global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType> A_2)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::Motorola.Common.Communication.Pba.UpdateDeviceData updateDeviceData = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
					int num = 0;
					int num2 = 17;
					for (;;)
					{
						global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage;
						string text;
						global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage3;
						string text2;
						int startAddress2;
						int endAddress2;
						switch (num2)
						{
						case 0:
						{
							pcrMemoryImage = new global::Motorola.Common.Communication.Pba.PcrMemoryImage();
							int startAddress;
							pcrMemoryImage.StartAddress = startAddress;
							int endAddress;
							pcrMemoryImage.EndAddress = endAddress;
							int num3;
							pcrMemoryImage.FileType = A_2[num3];
							pcrMemoryImage.RemoteImage = true;
							global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings = new global::RegistryAccess.CPersistentApplicationSettings();
							text = string.Empty;
							persistentApplicationSettings.GetXferFolderPath(ref text);
							num2 = 13;
							continue;
						}
						case 1:
							try
							{
								num2 = 4;
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2;
										if (!pcrMemoryImage2.RemoteImage)
										{
											num2 = 3;
											continue;
										}
										break;
									}
									case 1:
										goto IL_653;
									case 2:
										goto IL_65F;
									case 3:
									{
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2;
										pcrMemoryImage3 = pcrMemoryImage2;
										num2 = 1;
										continue;
									}
									case 5:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num2 = 7;
											continue;
										}
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2 = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)enumerator.Current;
										num2 = 8;
										continue;
									}
									case 6:
										num2 = 0;
										continue;
									case 7:
										goto IL_653;
									case 8:
									{
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2;
										if (pcrMemoryImage2.FileType == A_2[num])
										{
											num2 = 6;
											continue;
										}
										break;
									}
									}
									IL_61E:
									num2 = 5;
									continue;
									goto IL_61E;
									IL_653:
									num2 = 2;
								}
								IL_65F:
								goto IL_43E;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_672;
							IL_43E:
							num2 = 12;
							continue;
						case 2:
							return;
						case 3:
							goto IL_672;
						case 4:
						{
							int num3;
							if (num3 >= A_0.Count)
							{
								num2 = 6;
								continue;
							}
							num2 = 7;
							continue;
						}
						case 5:
							if (updateDeviceData.MemoryImages.Count > 0)
							{
								num2 = 22;
								continue;
							}
							return;
						case 6:
							goto IL_35B;
						case 7:
						{
							int num3;
							if (A_2[num3] != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_APP)
							{
								num2 = 19;
								continue;
							}
							goto IL_672;
						}
						case 8:
							goto IL_582;
						case 9:
							goto IL_229;
						case 10:
							text2 += global::System.IO.Path.DirectorySeparatorChar;
							num2 = 18;
							continue;
						case 11:
						{
							if (num >= A_0.Count)
							{
								num2 = 24;
								continue;
							}
							startAddress2 = 201326592 + A_0[num];
							endAddress2 = 201326592 + A_1[num];
							pcrMemoryImage3 = null;
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator = this.e.MemoryImages.GetEnumerator();
							num2 = 1;
							continue;
						}
						case 12:
							if (pcrMemoryImage3 == null)
							{
								num2 = 26;
								continue;
							}
							goto IL_582;
						case 13:
							if (text[text.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
							{
								num2 = 28;
								continue;
							}
							goto IL_4D3;
						case 14:
						{
							if (true)
							{
							}
							int num3 = 0;
							num2 = 25;
							continue;
						}
						case 15:
							goto IL_462;
						case 16:
							if (pcrMemoryImage == null)
							{
								num2 = 0;
								continue;
							}
							goto IL_672;
						case 17:
							goto IL_462;
						case 18:
							goto IL_317;
						case 19:
						{
							int num3;
							int startAddress = 201326592 + A_0[num3];
							int endAddress = 201326592 + A_1[num3];
							pcrMemoryImage = null;
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator2 = this.e.MemoryImages.GetEnumerator();
							num2 = 27;
							continue;
						}
						case 20:
							if (this.o)
							{
								num2 = 14;
								continue;
							}
							goto IL_35B;
						case 21:
							if (text2[text2.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
							{
								num2 = 10;
								continue;
							}
							goto IL_317;
						case 22:
							try
							{
								this.c.ReadImage(this.b, updateDeviceData);
								goto IL_389;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
								throw global::UpdateController.CCustomExceptionHandler.a(2902U, base.GetType().ToString(), "ReadMemory2Buffer", ex.StackTrace.ToString());
							}
							goto IL_4D3;
							IL_389:
							this.e.MemoryImages.AddRange(updateDeviceData.MemoryImages);
							num2 = 2;
							continue;
						case 23:
							goto IL_4D3;
						case 24:
							num2 = 20;
							continue;
						case 25:
							goto IL_229;
						case 26:
							goto IL_1A4;
						case 27:
							try
							{
								num2 = 8;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_185;
									case 1:
										num2 = 7;
										continue;
									case 2:
										goto IL_191;
									case 3:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num2 = 0;
											continue;
										}
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage4 = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)enumerator2.Current;
										num2 = 6;
										continue;
									}
									case 4:
										goto IL_185;
									case 5:
									{
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage4;
										pcrMemoryImage = pcrMemoryImage4;
										num2 = 4;
										continue;
									}
									case 6:
									{
										int num3;
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage4;
										if (pcrMemoryImage4.FileType == A_2[num3])
										{
											num2 = 1;
											continue;
										}
										break;
									}
									case 7:
									{
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage4;
										if (pcrMemoryImage4.RemoteImage)
										{
											num2 = 5;
											continue;
										}
										break;
									}
									}
									IL_150:
									num2 = 3;
									continue;
									goto IL_150;
									IL_185:
									num2 = 2;
								}
								IL_191:
								goto IL_55E;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_1A4;
							IL_55E:
							num2 = 16;
							continue;
						case 28:
							text += global::System.IO.Path.DirectorySeparatorChar;
							num2 = 23;
							continue;
						}
						break;
						IL_1A4:
						pcrMemoryImage3 = new global::Motorola.Common.Communication.Pba.PcrMemoryImage();
						pcrMemoryImage3.StartAddress = startAddress2;
						pcrMemoryImage3.EndAddress = endAddress2;
						pcrMemoryImage3.FileType = A_2[num];
						pcrMemoryImage3.RemoteImage = false;
						global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings2 = new global::RegistryAccess.CPersistentApplicationSettings();
						text2 = string.Empty;
						persistentApplicationSettings2.GetXferFolderPath(ref text2);
						num2 = 21;
						continue;
						IL_229:
						num2 = 4;
						continue;
						IL_34A:
						num2 = 8;
						continue;
						IL_672:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_34A;
						default:
						{
							if (false)
							{
							}
							int num3;
							num3++;
							num2 = 9;
							continue;
						}
						}
						IL_317:
						pcrMemoryImage3.FilePath = text2 + global::System.Guid.NewGuid().ToString("D") + ".srec";
						updateDeviceData.MemoryImages.Add(pcrMemoryImage3);
						goto IL_34A;
						IL_35B:
						num2 = 5;
						continue;
						IL_462:
						num2 = 11;
						continue;
						IL_4D3:
						pcrMemoryImage.FilePath = text + global::System.Guid.NewGuid().ToString("D") + ".srec";
						updateDeviceData.MemoryImages.Add(pcrMemoryImage);
						num2 = 3;
						continue;
						IL_582:
						num++;
						num2 = 15;
					}
				}
				return;
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0001D1D4 File Offset: 0x0001C1D4
		public void a(out string A_0, bool A_1)
		{
			switch (0)
			{
			default:
			{
				global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage;
				for (;;)
				{
					int startAddress = 0;
					int endAddress = 0;
					pcrMemoryImage = null;
					string text = string.Empty;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage>.Enumerator enumerator = this.e.MemoryImages.GetEnumerator();
					int num = 9;
					for (;;)
					{
						string text2;
						global::Motorola.Common.Communication.Pba.UpdateDeviceData updateDeviceData;
						switch (num)
						{
						case 0:
							if (string.IsNullOrEmpty(text))
							{
								num = 5;
								continue;
							}
							pcrMemoryImage.FilePath = text;
							num = 7;
							continue;
						case 1:
							goto IL_21B;
						case 2:
							if (pcrMemoryImage == null)
							{
								num = 6;
								continue;
							}
							goto IL_321;
						case 3:
							goto IL_B8;
						case 4:
							goto IL_28B;
						case 5:
						{
							global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings = new global::RegistryAccess.CPersistentApplicationSettings();
							text2 = string.Empty;
							persistentApplicationSettings.GetXferFolderPath(ref text2);
							num = 8;
							continue;
						}
						case 6:
							pcrMemoryImage = new global::Motorola.Common.Communication.Pba.PcrMemoryImage();
							pcrMemoryImage.StartAddress = startAddress;
							pcrMemoryImage.EndAddress = endAddress;
							pcrMemoryImage.FileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT;
							num = 0;
							continue;
						case 7:
							goto IL_1FE;
						case 8:
							if (text2[text2.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
							{
								num = 3;
								continue;
							}
							goto IL_28B;
						case 9:
							try
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
										goto IL_1EE;
									case 2:
									{
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2;
										text = pcrMemoryImage2.FilePath;
										num = 4;
										continue;
									}
									case 3:
										goto IL_1E0;
									case 4:
									{
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2;
										if (pcrMemoryImage2.RemoteImage == A_1)
										{
											num = 8;
											continue;
										}
										break;
									}
									case 5:
									{
										if (!enumerator.MoveNext())
										{
											num = 3;
											continue;
										}
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2 = (global::Motorola.Common.Communication.Pba.PcrMemoryImage)enumerator.Current;
										num = 7;
										continue;
									}
									case 6:
										goto IL_1E2;
									case 7:
									{
										global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2;
										if (pcrMemoryImage2.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT)
										{
											num = 2;
											continue;
										}
										break;
									}
									case 8:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1E0;
										default:
										{
											if (false)
											{
											}
											global::Motorola.Common.Communication.Pba.PcrMemoryImage pcrMemoryImage2;
											pcrMemoryImage = pcrMemoryImage2;
											num = 6;
											continue;
										}
										}
										break;
									}
									IL_1BF:
									num = 5;
									continue;
									goto IL_1BF;
									IL_1E2:
									num = 1;
									continue;
									IL_1E0:
									goto IL_1E2;
								}
								IL_1EE:
								goto IL_26B;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_1FE;
							IL_26B:
							num = 2;
							continue;
						case 10:
							if (true)
							{
							}
							try
							{
								this.c.ReadImage(this.b, updateDeviceData);
								goto IL_1FE;
							}
							catch (global::System.Exception ex)
							{
								global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
								throw global::UpdateController.CCustomExceptionHandler.a(2902U, base.GetType().ToString(), "ReadPSDT", ex.StackTrace.ToString());
							}
							goto IL_B8;
						}
						break;
						IL_B8:
						text2 += global::System.IO.Path.DirectorySeparatorChar;
						num = 4;
						continue;
						IL_1FE:
						this.e.MemoryImages.Add(pcrMemoryImage);
						num = 1;
						continue;
						IL_28B:
						pcrMemoryImage.FilePath = text2 + global::System.Guid.NewGuid().ToString("D") + ".srec";
						updateDeviceData = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
						updateDeviceData.MemoryImages.Add(pcrMemoryImage);
						num = 10;
					}
				}
				IL_21B:
				IL_321:
				A_0 = pcrMemoryImage.FilePath;
				return;
			}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0001D528 File Offset: 0x0001C528
		public void i()
		{
			try
			{
				if (true)
				{
				}
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_8D:
					num = 2;
					break;
				default:
					if (false)
					{
					}
					num = 3;
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_8B;
					case 1:
						this.c.CloseSession(this.b, false);
						this.b.ConnectionInfo.SessionID = 0;
						num = 0;
						continue;
					case 2:
						goto IL_95;
					}
					if (this.b.ConnectionInfo.SessionID == 0)
					{
						break;
					}
					num = 1;
				}
				IL_8B:
				goto IL_8D;
				IL_95:;
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::UpdateController.CCustomExceptionHandler.a(2905U, base.GetType().ToString(), "ResetRadio", ex.StackTrace.ToString());
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0001D614 File Offset: 0x0001C614
		public void h()
		{
			try
			{
				for (;;)
				{
					IL_24:
					global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
					pbaObject.UpdateData = this.f;
					for (;;)
					{
						IL_36:
						int num = 1;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_11F;
							case 1:
								if (this.q == global::UpdateController.a.b.c)
								{
									num = 3;
									continue;
								}
								goto IL_102;
							case 2:
								goto IL_102;
							case 3:
								num = 4;
								continue;
							case 4:
								if (this.b.ConnectionInfo.SessionID != 0)
								{
									num = 6;
									continue;
								}
								goto IL_54;
							case 5:
								goto IL_54;
							case 6:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_36;
								default:
									if (false)
									{
									}
									this.c.CloseSession(this.b, true);
									this.b.ConnectionInfo.SessionID = 0;
									num = 5;
									continue;
								}
								break;
							}
							goto IL_24;
							IL_54:
							this.b.ConnectionInfo.SessionID = this.c.OpenSession(this.b, this.r, null);
							num = 2;
							continue;
							IL_102:
							this.c.UpdateDevice(this.b, pbaObject);
							num = 0;
						}
					}
				}
				IL_11F:;
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::UpdateController.CCustomExceptionHandler.a(2945U, base.GetType().ToString(), "UpdateDevice", ex.StackTrace.ToString());
			}
			if (true)
			{
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0001D7A0 File Offset: 0x0001C7A0
		public void c(string A_0)
		{
			try
			{
				for (;;)
				{
					global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
					pbaObject.UpdateData = this.f;
					int num = 9;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_16A;
						case 1:
							if (!string.IsNullOrEmpty(A_0))
							{
								num = 8;
								continue;
							}
							goto IL_14D;
						case 2:
							goto IL_5D;
						case 3:
							goto IL_14D;
						case 4:
							this.c.CloseSession(this.b, true);
							this.b.ConnectionInfo.SessionID = 0;
							num = 6;
							continue;
						case 5:
							num = 7;
							continue;
						case 6:
							goto IL_7A;
						case 7:
							if (this.b.ConnectionInfo.SessionID != 0)
							{
								num = 4;
								continue;
							}
							goto IL_7A;
						case 8:
							for (;;)
							{
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_EF;
								}
							}
							IL_EF:
							if (false)
							{
							}
							this.c.ValidateRemotePassword(this.b, "Motorola", A_0);
							num = 3;
							continue;
						case 9:
							if (this.q == global::UpdateController.a.b.c)
							{
								num = 5;
								continue;
							}
							goto IL_5D;
						}
						break;
						IL_5D:
						num = 1;
						continue;
						IL_7A:
						this.b.ConnectionInfo.SessionID = this.c.OpenSession(this.b, this.r, null);
						num = 2;
						continue;
						IL_14D:
						this.c.UpdateDevice(this.b, pbaObject);
						num = 0;
					}
				}
				IL_16A:;
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::UpdateController.CCustomExceptionHandler.a(2945U, base.GetType().ToString(), "UpdateDevice", ex.StackTrace.ToString());
			}
			if (true)
			{
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0001D974 File Offset: 0x0001C974
		public void a(global::constants.CCPTags.SetProgressBar A_0, int A_1)
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
			this.j = A_0;
			this.k = A_1;
		}

		// Token: 0x0400008C RID: 140
		private const string a = "{8442AEE9-C610-4FEB-8577-2977C98C6DE2}";

		// Token: 0x0400008D RID: 141
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

		// Token: 0x0400008E RID: 142
		private global::Motorola.Common.Communication.Service.IDeviceOperation c;

		// Token: 0x0400008F RID: 143
		private global::CommunicationController.CSerialTransportController.DeviceServiceHandler d;

		// Token: 0x04000090 RID: 144
		private global::Motorola.Common.Communication.Pba.UpdateDeviceData e;

		// Token: 0x04000091 RID: 145
		private global::Motorola.Common.Communication.Pba.UpdateDeviceData f;

		// Token: 0x04000092 RID: 146
		private global::Motorola.Common.Communication.Pba.PbaObject g;

		// Token: 0x04000093 RID: 147
		private global::Motorola.Common.Communication.Pba.PbaObject h;

		// Token: 0x04000094 RID: 148
		private int i;

		// Token: 0x04000095 RID: 149
		private global::constants.CCPTags.SetProgressBar j;

		// Token: 0x04000096 RID: 150
		private int k;

		// Token: 0x04000097 RID: 151
		private bool l;

		// Token: 0x04000098 RID: 152
		private bool m;

		// Token: 0x04000099 RID: 153
		private bool n;

		// Token: 0x0400009A RID: 154
		private bool o;

		// Token: 0x0400009B RID: 155
		private bool p;

		// Token: 0x0400009C RID: 156
		private global::UpdateController.a.b q;

		// Token: 0x0400009D RID: 157
		private global::Motorola.Common.Communication.CommonUtil.RadioOperation r = global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash;

		// Token: 0x02000018 RID: 24
		private enum b
		{
			// Token: 0x0400009F RID: 159
			a,
			// Token: 0x040000A0 RID: 160
			b,
			// Token: 0x040000A1 RID: 161
			c,
			// Token: 0x040000A2 RID: 162
			d
		}

		// Token: 0x02000019 RID: 25
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060000C0 RID: 192 RVA: 0x0001D9D4 File Offset: 0x0001C9D4
			public bool b(global::Motorola.Common.Communication.Pba.DataPartition A_0)
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
				return A_0.PartitionID == (byte)this.a;
			}

			// Token: 0x040000A3 RID: 163
			public global::constants.CCPTags.PcrPartition a;
		}
	}
}
