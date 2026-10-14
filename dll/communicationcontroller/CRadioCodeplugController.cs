using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using constants;
using custom_exception;
using ErrorLogging;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Service;
using Motorola.Common.CustomException;
using RegistryAccess;

namespace CommunicationController
{
	// Token: 0x02000016 RID: 22
	public class CRadioCodeplugController : global::CommunicationController.IRadioCodeplugController
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00003044 File Offset: 0x00002044
		public static string Serialize(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devinfo)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				string result;
				try
				{
					global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
					binaryFormatter.Serialize(memoryStream, devinfo);
					string text = global::System.Convert.ToBase64String(memoryStream.ToArray());
					result = text;
				}
				finally
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_93;
						case 2:
							((global::System.IDisposable)memoryStream).Dispose();
							num = 1;
							continue;
						}
						if (memoryStream == null)
						{
							break;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_95;
						default:
							if (false)
							{
							}
							num = 2;
							break;
						}
					}
					IL_93:
					IL_95:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003104 File Offset: 0x00002104
		public static global::Motorola.Common.Communication.CommonUtil.DeviceInfo DeSerialize(string encodedData)
		{
			switch (0)
			{
			default:
			{
				if (true)
				{
				}
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Convert.FromBase64String(encodedData));
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo result;
				try
				{
					global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
					global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = binaryFormatter.Deserialize(memoryStream) as global::Motorola.Common.Communication.CommonUtil.DeviceInfo;
					result = deviceInfo;
				}
				finally
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							((global::System.IDisposable)memoryStream).Dispose();
							num = 2;
							continue;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_8C;
							}
							break;
						}
						if (memoryStream == null)
						{
							goto IL_94;
						}
						num = 1;
					}
					IL_8C:
					if (false)
					{
					}
					IL_94:;
				}
				return result;
			}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000031C4 File Offset: 0x000021C4
		public static bool IsDefaultEnUsLanguagePack(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo packInfo)
		{
			if (string.Equals(packInfo.PackID, "en-us", global::System.StringComparison.OrdinalIgnoreCase))
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
					break;
				}
				if (true)
				{
				}
				return string.Equals(packInfo.Name, "English", global::System.StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00003228 File Offset: 0x00002228
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000326C File Offset: 0x0000226C
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo DeviceInfo
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
				return this.b;
			}
			set
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
				this.b = (global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)value;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000032B4 File Offset: 0x000022B4
		public void ImportPBA(global::Motorola.Common.Communication.Pba.PbaObject pbaobject)
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
			this.d = new global::CommunicationController.CRadioCodeplugController.a();
			this.d.a(pbaobject);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003308 File Offset: 0x00002308
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000334C File Offset: 0x0000234C
		public global::Motorola.Common.Communication.Pba.PbaObject PbaOutput
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
				return this.g;
			}
			set
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
				this.g = value;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003390 File Offset: 0x00002390
		private void a(int A_0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus A_1)
		{
			for (;;)
			{
				uint num = 0U;
				int num2 = 13;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_9C;
					case 1:
					{
						int num3;
						if (num3 >= 1)
						{
							num2 = 11;
							continue;
						}
						return;
					}
					case 2:
						if (this.e == 100U)
						{
							num2 = 5;
							continue;
						}
						goto IL_74;
					case 3:
						num2 = 9;
						continue;
					case 4:
						return;
					case 5:
						this.e = num;
						num2 = 6;
						continue;
					case 6:
						goto IL_74;
					case 7:
						if (this.k != null)
						{
							num2 = 12;
							continue;
						}
						return;
					case 8:
						goto IL_9C;
					case 9:
						goto IL_116;
					case 10:
						goto IL_9C;
					case 11:
					{
						int num3;
						this.k(num3);
						this.f += num3;
						num2 = 4;
						continue;
					}
					case 12:
					{
						if (true)
						{
						}
						int num3 = global::System.Convert.ToInt32((long)A_0 * (long)((ulong)this.e) / 100L) - this.f;
						num2 = 1;
						continue;
					}
					case 13:
						switch (A_1)
						{
						case global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadImage:
							num = 200U;
							num2 = 0;
							continue;
						case global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage:
							num = 550U;
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_116;
							default:
								if (false)
								{
								}
								num2 = 8;
								continue;
							}
							break;
						default:
							num2 = 3;
							continue;
						}
						break;
					}
					break;
					IL_74:
					num2 = 7;
					continue;
					IL_9C:
					num2 = 2;
					continue;
					IL_116:
					num = 90U;
					num2 = 10;
				}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003538 File Offset: 0x00002538
		private void a()
		{
			int num = 1;
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
					{
						if (false)
						{
						}
						if (true)
						{
						}
						int num2;
						if (num2 >= 1)
						{
							num = 4;
							continue;
						}
						goto IL_A8;
					}
					}
					break;
				case 2:
				{
					int num2 = global::System.Convert.ToInt32((long)((ulong)this.e - (ulong)((long)this.f)));
					num = 0;
					continue;
				}
				case 3:
					goto IL_54;
				case 4:
				{
					int num2;
					this.k(num2);
					num = 3;
					continue;
				}
				}
				IL_24:
				if (this.k != null)
				{
					num = 2;
					continue;
				}
				break;
				goto IL_24;
			}
			IL_54:
			IL_A8:
			this.e = 100U;
			this.f = 0;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000035FC File Offset: 0x000025FC
		public void AddWriteMaskField(byte[] data)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (data.Length < 14)
					{
						goto IL_55;
					}
					goto IL_B0;
				case 1:
					num = 0;
					continue;
				case 2:
					return;
				case 3:
					this.g = new global::Motorola.Common.Communication.Pba.PbaObject();
					num = 4;
					continue;
				case 4:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_55;
					default:
						if (false)
						{
						}
						goto IL_5F;
					}
					break;
				case 5:
					if (true)
					{
					}
					break;
				case 6:
					if (data != null)
					{
						num = 1;
						continue;
					}
					return;
				}
				if (this.g == null)
				{
					num = 3;
					continue;
				}
				goto IL_5F;
				IL_55:
				num = 2;
				continue;
				IL_5F:
				num = 6;
			}
			return;
			IL_B0:
			global::Motorola.Common.Communication.Pba.ValidationField validationField = new global::Motorola.Common.Communication.Pba.ValidationField();
			validationField.PartitionID = data[0];
			validationField.BlockType = (ushort)global::System.BitConverter.ToInt16(data, 1);
			validationField.BlockID = (ushort)global::System.BitConverter.ToInt16(data, 3);
			validationField.OffsetInBits = (uint)global::System.BitConverter.ToInt32(data, 5);
			validationField.LengthInBits = (uint)global::System.BitConverter.ToInt32(data, 9);
			this.g.PerserveMasks.Add(validationField);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003710 File Offset: 0x00002710
		public CRadioCodeplugController()
		{
			this.h = null;
			this.c = null;
			this.b = null;
			this.e = 100U;
			this.f = 0;
			this.i = false;
			this.j = 0U;
			this.k = null;
			this.d = null;
			this.g = null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000376C File Offset: 0x0000276C
		public CRadioCodeplugController(global::constants.CCPTags.SetProgressBar pfSetProgressBar)
		{
			this.h = null;
			this.c = null;
			this.b = null;
			this.e = 100U;
			this.f = 0;
			this.i = false;
			this.j = 0U;
			this.k = pfSetProgressBar;
			this.d = null;
			this.g = null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000037C8 File Offset: 0x000027C8
		public uint GetSerialHandle()
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
			return this.j;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000380C File Offset: 0x0000280C
		public bool IsOpen()
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
			return this.i;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003850 File Offset: 0x00002850
		public void SetPBar(global::constants.CCPTags.SetProgressBar pfSetProgressBar)
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
			this.k = pfSetProgressBar;
			this.e = 100U;
			this.f = 0;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000038A4 File Offset: 0x000028A4
		public void Open(global::CommunicationController.ISerialTransportController pSerialTransport, uint uiHandleToSerial, global::ErrorLogging.ILogApplicationError objLogAppErr, uint uiTargetDevice, bool isRemoteConnection, global::constants.CCPTags.SetProgressBar pfSetProgressBar)
		{
			while (this.i)
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
					return;
				}
			}
			this.j = uiHandleToSerial;
			this.h = pSerialTransport[this.j];
			this.c = this.h.DSC;
			this.b = (this.h.DevInfo as global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo);
			this.d = new global::CommunicationController.CRadioCodeplugController.a();
			this.g = new global::Motorola.Common.Communication.Pba.PbaObject();
			this.i = true;
			this.k = pfSetProgressBar;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003950 File Offset: 0x00002950
		public void Close()
		{
			for (;;)
			{
				if (true)
				{
				}
				if (this.i)
				{
					goto IL_39;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_32;
				}
			}
			IL_32:
			if (false)
			{
			}
			return;
			IL_39:
			this.c = null;
			this.b = null;
			this.e = 100U;
			this.f = 0;
			this.i = false;
			this.d = null;
			this.g = null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000039C8 File Offset: 0x000029C8
		public T IoControl<T>(string strCommand)
		{
			switch (0)
			{
			default:
			{
				object obj = null;
				T result;
				try
				{
					int num = 27;
					for (;;)
					{
						object obj2;
						object obj3;
						object obj4;
						switch (num)
						{
						case 0:
							obj2 = "True";
							goto IL_619;
						case 1:
							goto IL_94A;
						case 2:
							goto IL_94A;
						case 3:
							goto IL_94A;
						case 4:
							goto IL_94A;
						case 5:
							goto IL_94A;
						case 6:
							num = 20;
							continue;
						case 7:
							goto IL_94A;
						case 8:
							global::g.a = new global::System.Collections.Generic.Dictionary<string, int>(35)
							{
								{
									"UNLOCKRADIO",
									0
								},
								{
									"DEFRAGMENTCODEPLUG",
									1
								},
								{
									"QUERYRADIOFLASHSIZETYPE",
									2
								},
								{
									"QUERYRADIOLOWBATTERY",
									3
								},
								{
									"QUERYBANDITISWIRELINEAVAIL",
									4
								},
								{
									"QUERYBANDITCONTROLLERFPGASTATUS",
									5
								},
								{
									"QUERYBANDITWIRELINEFPGASTATUS",
									6
								},
								{
									"QUERYBANDITWIRELINEACTIVEFPGAVERSION",
									7
								},
								{
									"QUERYBANDITCONTROLLERACTIVEFPGAVERSION",
									8
								},
								{
									"QUERYBANDITWIRELINEALTERNATIVEFPGAVERSION",
									9
								},
								{
									"QUERYBANDITCONTROLLERALTERNATIVEFPGAVERSION",
									10
								},
								{
									"QUERYBANDITCONTROLLERFACTORYFPGAVERSION",
									11
								},
								{
									"QUERYBANDITWIRELINEFPACTORYFPGAVERSION",
									12
								},
								{
									"QUERYRADIOBOOTLOADERVERSION",
									13
								},
								{
									"QUERYRADIOCODEPLUGVERSION",
									14
								},
								{
									"QUERYREPEATERMACADDRESS",
									15
								},
								{
									"QUERYREPEATERMACADDRESSES",
									16
								},
								{
									"QUERYREPEATERWIFIMACADDRESS",
									17
								},
								{
									"QUERYRADIOMODELNUMBER",
									18
								},
								{
									"QUERYRADIOPSDTVERSION",
									19
								},
								{
									"QUERYRADIOSOFTWAREVERSION",
									20
								},
								{
									"QUERYREPEATERRXBOARDSERIALNUMBER",
									21
								},
								{
									"QUERYREPEATERRXBRICKSERIALNUMBER",
									22
								},
								{
									"QUERYRADIOSERIALNUMBER",
									23
								},
								{
									"QUERYREPEATERSERIALNUMBER",
									24
								},
								{
									"QUERYREPEATERTXBOARDSERIALNUMBER",
									25
								},
								{
									"QUERYREPEATERTXBRICKSERIALNUMBER",
									26
								},
								{
									"QUERYRADIOPHYSICALSERIALNUMBER",
									27
								},
								{
									"QUERYRADIOUUID",
									28
								},
								{
									"QUERYL3BOOTLOADERVERSION",
									29
								},
								{
									"QUERYCONFIGURATIONVERSION",
									30
								},
								{
									"QUERYKERNELVERSION",
									31
								},
								{
									"QUERYDSPCAPABILITY",
									32
								},
								{
									"QUERYPASSWORDSTATUS",
									33
								},
								{
									"QUERYDTPCAPABILITY",
									34
								}
							};
							num = 39;
							continue;
						case 9:
							obj3 = "True";
							goto IL_876;
						case 10:
							goto IL_94A;
						case 11:
							num = 41;
							continue;
						case 12:
							goto IL_94A;
						case 13:
							if (!this.b.Is32MPlatform)
							{
								num = 29;
								continue;
							}
							num = 34;
							continue;
						case 14:
							goto IL_94A;
						case 15:
							if (global::g.a == null)
							{
								num = 8;
								continue;
							}
							goto IL_62B;
						case 16:
							if (this.b.FpgaInfo.FPGAControllerStatus != global::Motorola.Common.Communication.CommonUtil.FPGAStatus.Active)
							{
								num = 11;
								continue;
							}
							num = 9;
							continue;
						case 17:
							obj2 = "False";
							goto IL_619;
						case 18:
							goto IL_94A;
						case 19:
							num = 52;
							continue;
						case 20:
							goto IL_8E9;
						case 21:
							goto IL_94A;
						case 22:
							goto IL_94A;
						case 23:
							goto IL_94A;
						case 24:
							num = 17;
							continue;
						case 25:
						{
							int num2;
							if (global::g.a.TryGetValue(strCommand, out num2))
							{
								num = 19;
								continue;
							}
							goto IL_5F2;
						}
						case 26:
							goto IL_94A;
						case 28:
							goto IL_95D;
						case 29:
							num = 31;
							continue;
						case 30:
							goto IL_94A;
						case 31:
							obj4 = "3";
							goto IL_7DD;
						case 32:
							goto IL_94A;
						case 33:
							goto IL_94A;
						case 34:
							obj4 = "5";
							goto IL_7DD;
						case 35:
							goto IL_94A;
						case 36:
							goto IL_94A;
						case 37:
							goto IL_94A;
						case 38:
							goto IL_94A;
						case 39:
							goto IL_62B;
						case 40:
							if (this.b.FpgaInfo.FPGAWirelineStatus != global::Motorola.Common.Communication.CommonUtil.FPGAStatus.Active)
							{
								num = 24;
								continue;
							}
							num = 0;
							continue;
						case 41:
							obj3 = "False";
							goto IL_876;
						case 42:
							goto IL_94A;
						case 43:
							goto IL_94A;
						case 44:
							goto IL_94A;
						case 45:
							goto IL_94A;
						case 46:
							goto IL_94A;
						case 47:
							num = 15;
							continue;
						case 48:
							goto IL_94A;
						case 49:
							goto IL_94A;
						case 50:
							goto IL_94A;
						case 51:
							goto IL_94A;
						case 52:
						{
							int num2;
							switch (num2)
							{
							case 0:
							case 1:
								goto IL_94A;
							case 2:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_112;
								default:
									if (false)
									{
									}
									num = 13;
									continue;
								}
								break;
							case 3:
								obj = "False";
								num = 23;
								continue;
							case 4:
								obj = this.b.FpgaInfo.IsWirelineAvailable.ToString();
								num = 48;
								continue;
							case 5:
								num = 16;
								continue;
							case 6:
								num = 40;
								continue;
							case 7:
								obj = this.b.FpgaInfo.FPGAWirelineActiveVersion;
								num = 14;
								continue;
							case 8:
								obj = this.b.FpgaInfo.FPGAControllerActiveVersion;
								num = 7;
								continue;
							case 9:
								obj = this.b.FpgaInfo.FPGAWirelineAlternativeVersion;
								num = 30;
								continue;
							case 10:
								obj = this.b.FpgaInfo.FPGAControllerAlternativeVersion;
								num = 35;
								continue;
							case 11:
								obj = this.b.FpgaInfo.FPGAControllerFactoryVersion;
								num = 43;
								continue;
							case 12:
								obj = this.b.FpgaInfo.FPGAWirelineFactoryVersion;
								num = 2;
								continue;
							case 13:
								obj = this.b.BootloaderVersion;
								num = 5;
								continue;
							case 14:
								obj = this.b.CodeplugVersion;
								num = 12;
								continue;
							case 15:
								obj = this.b.MacAddress.Replace("-", "");
								num = 42;
								continue;
							case 16:
								obj = this.b.MacAddressPort1 + ','.ToString() + this.b.MacAddressPort2;
								num = 26;
								continue;
							case 17:
								obj = this.b.MacAddressWIFIPort1 + ','.ToString() + this.b.MacAddressWIFIPort2;
								num = 44;
								continue;
							case 18:
								obj = this.b.ModelNumber;
								num = 21;
								continue;
							case 19:
								obj = this.b.PsdtVersion;
								num = 33;
								continue;
							case 20:
								obj = this.b.SoftwareVersion;
								num = 38;
								continue;
							case 21:
								obj = this.b.RemoteSerialNumber;
								num = 49;
								continue;
							case 22:
								obj = this.b.BrickRXSerialNumber;
								num = 45;
								continue;
							case 23:
							case 24:
							case 25:
								obj = this.b.SerialNumber;
								num = 50;
								continue;
							case 26:
								obj = this.b.BrickTXSerialNumber;
								num = 32;
								continue;
							case 27:
								obj = this.b.PhysicalSerialNumber;
								num = 51;
								continue;
							case 28:
								obj = this.b.UUID;
								num = 4;
								continue;
							case 29:
								obj = this.b.L3BootloaderVersion;
								num = 3;
								continue;
							case 30:
								obj = this.b.ConfigurationVersion;
								num = 1;
								continue;
							case 31:
								obj = this.b.KernelVersion;
								num = 46;
								continue;
							case 32:
								obj = this.b.IsDSPEnabled;
								num = 37;
								continue;
							case 33:
								obj = this.b.PasswordStatus;
								num = 18;
								continue;
							case 34:
								obj = this.b.IsDTPEnabled;
								num = 22;
								continue;
							default:
								num = 6;
								continue;
							}
							break;
						}
						case 53:
							goto IL_94A;
						}
						goto IL_109;
						IL_112:
						num = 47;
						continue;
						IL_109:
						if (strCommand != null)
						{
							goto IL_112;
						}
						break;
						IL_619:
						obj = obj2;
						num = 10;
						continue;
						IL_62B:
						num = 25;
						continue;
						IL_7DD:
						obj = obj4;
						num = 53;
						continue;
						IL_876:
						obj = obj3;
						num = 36;
						continue;
						IL_94A:
						result = (T)((object)obj);
						num = 28;
					}
					IL_5F2:
					global::custom_exception.CCustomException ex = global::CommunicationController.CCustomExceptionHandler.CreateException(1053U, base.GetType().ToString(), "IoControl", global::System.Environment.StackTrace.ToString());
					throw ex;
					IL_8E9:
					goto IL_5F2;
					IL_95D:;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.Exception)
				{
					global::custom_exception.CCustomException ex2 = global::CommunicationController.CCustomExceptionHandler.CreateException(1100U, base.GetType().ToString(), "IoControl", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex2;
				}
				if (true)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000043A4 File Offset: 0x000033A4
		public void RefreshRadioCodeplug()
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			}
			if (false)
			{
			}
			if (this.c != null)
			{
				try
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							this.c.CloseSession(this.b, false);
							this.b.ConnectionInfo.SessionID = 0;
							num = 3;
							continue;
						case 2:
							goto IL_123;
						case 3:
							goto IL_118;
						case 4:
							num = 6;
							continue;
						case 5:
							goto IL_118;
						case 6:
							if (this.b.ConnectionInfo.SessionID != 0)
							{
								num = 1;
								continue;
							}
							goto IL_118;
						}
						if (this.b.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap)
						{
							num = 4;
							continue;
						}
						ushort sessionID = this.b.ConnectionInfo.SessionID;
						this.c.CloseSession(this.b, false);
						this.c.SwitchOver(this.b, sessionID, 0U, global::Motorola.Common.Communication.CommonUtil.SwitchOverOption.None);
						num = 5;
						continue;
						IL_118:
						num = 2;
					}
					IL_123:
					goto IL_153;
				}
				catch (global::System.Exception ex)
				{
					global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
					throw global::CommunicationController.CCustomExceptionHandler.CreateException(1161U, base.GetType().ToString(), "RefreshRadioCodeplug", ex.StackTrace.ToString());
				}
				return;
				IL_153:
				if (true)
				{
				}
				return;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000451C File Offset: 0x0000351C
		private void b(int A_0, out byte[] A_1, int A_2)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			}
			if (true)
			{
			}
			if (false)
			{
			}
			switch (0)
			{
			default:
				A_1 = null;
				try
				{
					for (;;)
					{
						int num = (int)global::System.Math.Ceiling(global::System.Math.Log((double)A_0, 256.0));
						int num2 = 2;
						for (;;)
						{
							int num4;
							switch (num2)
							{
							case 0:
								goto IL_111;
							case 1:
								goto IL_132;
							case 2:
								if (A_2 == -1)
								{
									num2 = 10;
									continue;
								}
								num2 = 3;
								continue;
							case 3:
								if (A_2 < num)
								{
									num2 = 7;
									continue;
								}
								goto IL_1D1;
							case 4:
								goto IL_193;
							case 5:
								goto IL_206;
							case 6:
								goto IL_1D1;
							case 7:
								goto IL_10F;
							case 8:
								goto IL_111;
							case 9:
							{
								int num3;
								if (num3 >= A_2)
								{
									num2 = 4;
									continue;
								}
								A_1[num3] = 0;
								num3++;
								num2 = 8;
								continue;
							}
							case 10:
								A_2 = num;
								num2 = 6;
								continue;
							case 11:
							{
								if (num4 >= A_2)
								{
									num2 = 13;
									continue;
								}
								int num5 = A_0 - A_0 / 256 * 256;
								A_0 /= 256;
								A_1[num4] = (byte)num5;
								num4++;
								num2 = 1;
								continue;
							}
							case 12:
							{
								int num3 = 0;
								num2 = 0;
								continue;
							}
							case 13:
								num2 = 5;
								continue;
							case 14:
								goto IL_132;
							case 15:
								if (A_2 > num)
								{
									num2 = 12;
									continue;
								}
								goto IL_193;
							}
							break;
							IL_111:
							num2 = 9;
							continue;
							IL_132:
							num2 = 11;
							continue;
							IL_193:
							num4 = 0;
							num2 = 14;
							continue;
							IL_1D1:
							A_1 = new byte[A_2];
							num2 = 15;
						}
					}
					IL_10F:
					global::custom_exception.CCustomException ex = global::CommunicationController.CCustomExceptionHandler.CreateException(1104U, base.GetType().ToString(), "LCvtIntToByteArray", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex;
					IL_206:;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.Exception)
				{
					global::custom_exception.CCustomException ex2 = global::CommunicationController.CCustomExceptionHandler.CreateException(1100U, base.GetType().ToString(), "LCvtIntToByteArray", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex2;
				}
				break;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004798 File Offset: 0x00003798
		private void a(int A_0, out byte[] A_1, int A_2)
		{
			switch (0)
			{
			default:
			{
				global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
				try
				{
					for (;;)
					{
						int num = A_2 - 1;
						int num2 = 3;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_DC;
							case 1:
								goto IL_4C;
							case 2:
							{
								if (num < 0)
								{
									num2 = 4;
									continue;
								}
								int num3 = A_0 / (int)global::System.Math.Pow(256.0, (double)num);
								A_0 -= num3 * (int)global::System.Math.Pow(256.0, (double)num);
								arrayList.Add((byte)num3);
								num--;
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_D0;
								default:
									if (false)
									{
									}
									num2 = 1;
									continue;
								}
								break;
							}
							case 3:
								goto IL_4C;
							case 4:
								goto IL_D0;
							}
							break;
							IL_4C:
							num2 = 2;
							continue;
							IL_D0:
							num2 = 0;
						}
					}
					IL_DC:;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch (global::System.Exception)
				{
					global::custom_exception.CCustomException ex = global::CommunicationController.CCustomExceptionHandler.CreateException(1100U, base.GetType().ToString(), "BCvtInt2ByteArray", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex;
				}
				if (true)
				{
				}
				A_1 = (byte[])arrayList.ToArray(typeof(byte));
				return;
			}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000048F0 File Offset: 0x000038F0
		private void a(byte[] A_0, out int A_1)
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
				A_1 = 0;
				try
				{
					int num = 3;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							goto IL_65;
						case 1:
							goto IL_67;
						case 2:
							goto IL_67;
						case 4:
							goto IL_F6;
						case 5:
							if (num2 >= A_0.Length)
							{
								num = 6;
								continue;
							}
							A_1 += (int)global::System.Math.Pow(256.0, (double)num2) * (int)A_0[num2];
							num2++;
							num = 2;
							continue;
						case 6:
							num = 4;
							continue;
						}
						if (A_0.Length <= 0)
						{
							num = 0;
							continue;
						}
						A_1 = 0;
						num2 = 0;
						num = 1;
						continue;
						IL_67:
						num = 5;
					}
					IL_65:
					global::custom_exception.CCustomException ex = global::CommunicationController.CCustomExceptionHandler.CreateException(1042U, base.GetType().ToString(), "LCvtByteArrayToInt", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex;
					IL_F6:;
				}
				catch (global::custom_exception.CCustomException)
				{
					throw;
				}
				catch
				{
					global::custom_exception.CCustomException ex2 = global::CommunicationController.CCustomExceptionHandler.CreateException(1100U, base.GetType().ToString(), "LCvtByteArrayToInt", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
					throw ex2;
				}
				break;
			}
			if (true)
			{
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004A4C File Offset: 0x00003A4C
		private void a(string A_0, out byte[] A_1, int A_2)
		{
			global::System.Text.Encoding unicode = global::System.Text.Encoding.Unicode;
			A_1 = null;
			try
			{
				for (;;)
				{
					A_1 = new byte[A_2];
					byte[] bytes = global::System.Text.Encoding.BigEndianUnicode.GetBytes(A_0);
					global::System.Array.Copy(bytes, 0, A_1, 0, bytes.Length);
					int num = bytes.Length;
					int num2 = 3;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_A6;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_7D;
							default:
								if (false)
								{
								}
								num2 = 0;
								continue;
							}
							break;
						case 2:
							if (num >= A_2)
							{
								num2 = 1;
								continue;
							}
							A_1[num] = 0;
							num++;
							num2 = 4;
							continue;
						case 3:
							goto IL_56;
						case 4:
							goto IL_7D;
						}
						break;
						IL_56:
						num2 = 2;
						continue;
						IL_7D:
						goto IL_56;
					}
				}
				IL_A6:;
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				global::custom_exception.CCustomException ex = global::CommunicationController.CCustomExceptionHandler.CreateException(1100U, base.GetType().ToString(), "BCvtUnicodeString2ByteArray", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004B60 File Offset: 0x00003B60
		private void a(byte[] A_0, out string A_1)
		{
			for (;;)
			{
				switch (0)
				{
				default:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_2E;
					}
					break;
				}
			}
			IL_2E:
			if (true)
			{
			}
			if (false)
			{
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(string.Empty);
			try
			{
				for (;;)
				{
					int num = 0;
					int num2 = 0;
					int num3 = 1;
					for (;;)
					{
						switch (num3)
						{
						case 0:
							stringBuilder.Append(((char)num).ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
							num2++;
							num3 = 3;
							continue;
						case 1:
							goto IL_7D;
						case 2:
							if (num != 0)
							{
								num3 = 0;
								continue;
							}
							goto IL_ED;
						case 3:
							goto IL_7D;
						case 4:
							goto IL_F9;
						case 5:
							goto IL_ED;
						case 6:
							if (num2 >= A_0.Length / 2)
							{
								num3 = 5;
								continue;
							}
							num = (int)A_0[num2 * 2] + (int)A_0[num2 * 2 + 1] * 256;
							num3 = 2;
							continue;
						}
						break;
						IL_7D:
						num3 = 6;
						continue;
						IL_ED:
						num3 = 4;
					}
				}
				IL_F9:;
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				global::custom_exception.CCustomException ex = global::CommunicationController.CCustomExceptionHandler.CreateException(1100U, base.GetType().ToString(), "LCvtByteArray2UnicodeString", global::System.Environment.StackTrace.ToString(global::System.Globalization.NumberFormatInfo.InvariantInfo));
				throw ex;
			}
			A_1 = stringBuilder.ToString();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004CBC File Offset: 0x00003CBC
		public void ReadPartition(byte btRegion, ref byte[] alDataList, ref uint pbarUpdates)
		{
			switch (0)
			{
			default:
			{
				for (;;)
				{
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = null;
					int num = 0;
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.CommonUtil.IshHeader> enumerator;
						int num2;
						global::Motorola.Common.Communication.Pba.PbaObject a_;
						switch (num)
						{
						case 0:
							if (!this.d.a(btRegion, out ishItemCollection))
							{
								num = 2;
								continue;
							}
							goto IL_69;
						case 1:
							goto IL_437;
						case 2:
							goto IL_242;
						case 3:
							if (!this.d.a(btRegion, out ishItemCollection))
							{
								num = 1;
								continue;
							}
							goto IL_69;
						case 4:
						{
							try
							{
								num = 4;
								for (;;)
								{
									switch (num)
									{
									case 1:
										num = 2;
										continue;
									case 2:
										goto IL_39F;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = 1;
											continue;
										}
										global::Motorola.Common.Communication.CommonUtil.IshHeader key = enumerator.Current;
										num2 += 6;
										num2 += ishItemCollection[key].ItemSize;
										num = 0;
										continue;
									}
									}
									IL_379:
									num = 3;
									continue;
									goto IL_379;
								}
								IL_39F:
								goto IL_279;
							}
							finally
							{
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_3F4:
									num = 0;
									break;
								default:
									if (false)
									{
									}
									num = 2;
									break;
								}
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_3FD;
									case 1:
										goto IL_3EB;
									}
									if (enumerator == null)
									{
										goto IL_3FF;
									}
									num = 1;
								}
								IL_3EB:
								enumerator.Dispose();
								goto IL_3F4;
								IL_3FD:
								IL_3FF:;
							}
							goto IL_400;
							IL_279:
							alDataList = new byte[num2];
							alDataList[0] = btRegion;
							byte[] array = null;
							this.b(ishItemCollection.Count, out array, 4);
							array.CopyTo(alDataList, 1);
							int num3 = 5;
							global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.CommonUtil.IshHeader> enumerator2 = ishItemCollection.Headers.GetEnumerator();
							num = 5;
							continue;
						}
						case 5:
							goto IL_EC;
						case 6:
							try
							{
								try
								{
									a_ = this.c.ReadDevice(this.b, null);
								}
								catch (global::System.Exception ex)
								{
									global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
									throw global::CommunicationController.CCustomExceptionHandler.CreateException(741U, base.GetType().ToString(), "ReadPartition", ex.StackTrace);
								}
								goto IL_400;
							}
							finally
							{
								this.h.DSH.OnProgressHandler -= this.a;
								this.a();
							}
							goto Block_3;
						}
						break;
						IL_69:
						num2 = 5;
						enumerator = ishItemCollection.Headers.GetEnumerator();
						num = 4;
						continue;
						IL_242:
						a_ = null;
						this.e = pbarUpdates;
						this.h.DSH.OnProgressHandler += this.a;
						num = 6;
						continue;
						Block_3:
						try
						{
							IL_EC:
							num = 4;
							for (;;)
							{
								switch (num)
								{
								case 0:
									num = 1;
									continue;
								case 1:
									goto IL_1FD;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.CommonUtil.IshHeader> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = 0;
										continue;
									}
									global::Motorola.Common.Communication.CommonUtil.IshHeader key2 = enumerator2.Current;
									byte[] array;
									this.b((int)key2.IshType, out array, 2);
									int num3;
									array.CopyTo(alDataList, num3);
									num3 += 2;
									this.b((int)key2.IshID, out array, 2);
									array.CopyTo(alDataList, num3);
									num3 += 2;
									this.b(ishItemCollection[key2].ItemSize, out array, 2);
									array.CopyTo(alDataList, num3);
									num3 += 2;
									ishItemCollection[key2].Data.CopyTo(alDataList, num3);
									num3 += ishItemCollection[key2].ItemSize;
									num = 2;
									continue;
								}
								}
								IL_1CB:
								num = 3;
								continue;
								goto IL_1CB;
							}
							IL_1FD:
							return;
						}
						finally
						{
							num = 0;
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.CommonUtil.IshHeader> enumerator2;
								switch (num)
								{
								case 1:
									goto IL_23F;
								case 2:
									enumerator2.Dispose();
									num = 1;
									continue;
								}
								if (enumerator2 == null)
								{
									break;
								}
								num = 2;
							}
							IL_23F:;
						}
						goto IL_242;
						IL_400:
						this.d.a(a_);
						num = 3;
					}
				}
				IL_437:
				if (true)
				{
				}
				global::custom_exception.CCustomException ex2 = global::CommunicationController.CCustomExceptionHandler.CreateException(1053U, base.GetType().ToString(), "ReadPartition", global::System.Environment.StackTrace.ToString());
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Partition: {0}", new object[]
				{
					btRegion.ToString()
				});
				ex2.AddErrorMessage(message);
				throw ex2;
			}
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000516C File Offset: 0x0000416C
		public void PSDTAccessCopy(byte region)
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

		// Token: 0x06000093 RID: 147 RVA: 0x000051A8 File Offset: 0x000041A8
		public void WritePartition(byte btRegion, ref byte[] alDataList, ref uint pbarUpdates)
		{
			switch (0)
			{
			default:
			{
				int num = 8;
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator;
					global::Motorola.Common.Communication.Pba.DataPartition dataPartition2;
					global::System.Collections.Hashtable hashtable;
					int num2;
					int num3;
					int num4;
					byte[] array;
					int num5;
					byte[] array2;
					byte[] array3;
					switch (num)
					{
					case 0:
						return;
					case 1:
						try
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
								num = 6;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_24C;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = 0;
											continue;
										}
										global::Motorola.Common.Communication.Pba.DataPartition dataPartition = enumerator.Current;
										byte partitionID = dataPartition.PartitionID;
										num = 3;
										continue;
									}
									case 2:
										goto IL_258;
									case 3:
									{
										byte partitionID;
										if (partitionID.Equals(btRegion))
										{
											num = 5;
											continue;
										}
										break;
									}
									case 4:
										goto IL_24C;
									case 5:
									{
										global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
										dataPartition2 = dataPartition;
										num = 4;
										continue;
									}
									}
									IL_22F:
									num = 1;
									continue;
									goto IL_22F;
									IL_24C:
									num = 2;
								}
								break;
							}
							IL_258:
							goto IL_331;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_26B;
						IL_331:
						num = 3;
						continue;
					case 2:
					{
						string key;
						hashtable.Add(key, true);
						global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
						dataPartition2.DataBlocks.Add(dataBlock);
						num = 5;
						continue;
					}
					case 3:
						if (dataPartition2 == null)
						{
							num = 13;
							continue;
						}
						dataPartition2.DataBlocks.Clear();
						num = 11;
						continue;
					case 4:
						goto IL_2AC;
					case 5:
						goto IL_26B;
					case 6:
						goto IL_30B;
					case 7:
						goto IL_30B;
					case 9:
					{
						string key;
						if (hashtable[key] == null)
						{
							num = 2;
							continue;
						}
						goto IL_26B;
					}
					case 10:
						goto IL_282;
					case 11:
						goto IL_2AC;
					case 12:
						if (true)
						{
						}
						this.g = new global::Motorola.Common.Communication.Pba.PbaObject();
						num = 10;
						continue;
					case 13:
						dataPartition2 = new global::Motorola.Common.Communication.Pba.DataPartition();
						dataPartition2.PartitionID = btRegion;
						this.g.CodeplugData.DataPartitions.Add(dataPartition2);
						num = 4;
						continue;
					case 14:
					{
						if (num2 >= num3)
						{
							num = 0;
							continue;
						}
						global::Motorola.Common.Communication.Pba.DataBlock dataBlock = new global::Motorola.Common.Communication.Pba.DataBlock();
						dataBlock.Offset = 0;
						global::System.Array.Copy(alDataList, num4, array, 0, array.Length);
						this.a(array, out num5);
						dataBlock.BlockType = (ushort)num5;
						num4 += array.Length;
						global::System.Array.Copy(alDataList, num4, array2, 0, array2.Length);
						this.a(array2, out num5);
						dataBlock.BlockID = (ushort)num5;
						num4 += array2.Length;
						global::System.Array.Copy(alDataList, num4, array3, 0, array3.Length);
						this.a(array3, out num5);
						dataBlock.LegthInBits = (int)((ushort)num5 * 8);
						num4 += array3.Length;
						dataBlock.PacketValue = new byte[num5];
						global::System.Array.Copy(alDataList, num4, dataBlock.PacketValue, 0, num5);
						num4 += num5;
						string key = dataBlock.BlockType.ToString() + "@" + dataBlock.BlockID;
						num = 9;
						continue;
					}
					}
					if (this.g == null)
					{
						num = 12;
						continue;
					}
					goto IL_282;
					IL_26B:
					num2++;
					num = 6;
					continue;
					IL_282:
					dataPartition2 = null;
					enumerator = this.g.CodeplugData.DataPartitions.GetEnumerator();
					num = 1;
					continue;
					IL_2AC:
					byte[] array4 = new byte[4];
					array = new byte[2];
					array2 = new byte[2];
					array3 = new byte[2];
					num4 = 1;
					global::System.Array.Copy(alDataList, num4, array4, 0, array4.Length);
					num5 = 0;
					num3 = 0;
					this.a(array4, out num3);
					num4 += 4;
					hashtable = new global::System.Collections.Hashtable();
					num2 = 0;
					num = 7;
					continue;
					IL_30B:
					num = 14;
				}
				return;
			}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000055A0 File Offset: 0x000045A0
		public void SendFPGAErase(string fpgaID)
		{
			for (;;)
			{
				global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.Unknown;
				int num = 2;
				for (;;)
				{
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						IL_4A:
						fileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CONTROLLER_FPGA;
						num = 3;
						continue;
					case 1:
						goto IL_8B;
					case 2:
						if (fpgaID.Equals("Controller"))
						{
							num = 0;
							continue;
						}
						num = 5;
						continue;
					case 3:
						goto IL_4C;
					case 4:
						goto IL_4C;
					case 5:
						if (fpgaID.Equals("Wireline"))
						{
							num = 1;
							continue;
						}
						goto IL_4C;
					}
					break;
					IL_8B:
					fileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.WIRELINE_FPGA;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4A;
					default:
						if (false)
						{
						}
						num = 4;
						continue;
					}
					try
					{
						IL_4C:
						this.c.SendFPGAErase(this.b, fileType);
						return;
					}
					catch (global::System.Exception ex)
					{
						global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
						throw global::CommunicationController.CCustomExceptionHandler.CreateException(2978U, base.GetType().ToString(), "SendFPGAErase", ex.StackTrace);
					}
					goto IL_8B;
				}
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000056B8 File Offset: 0x000046B8
		public void SendFPGAReset(string fpgaID)
		{
			for (;;)
			{
				IL_3C:
				global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.Unknown;
				int num = 0;
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
							if (fpgaID.Equals("Controller"))
							{
								num = 4;
								continue;
							}
							num = 1;
							continue;
						case 1:
							if (fpgaID.Equals("Wireline"))
							{
								num = 2;
								continue;
							}
							goto IL_5D;
						case 2:
							goto IL_9C;
						case 3:
							if (true)
							{
							}
							goto IL_5D;
						case 4:
							goto IL_5B;
						case 5:
							goto IL_5D;
						}
						goto IL_3C;
						IL_9C:
						fileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.WIRELINE_FPGA;
						num = 3;
						continue;
						try
						{
							IL_5D:
							this.c.SendFPGAReset(this.b, fileType);
							return;
						}
						catch (global::System.Exception ex)
						{
							global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
							throw global::CommunicationController.CCustomExceptionHandler.CreateException(2977U, base.GetType().ToString(), "SendFPGAReset", ex.StackTrace);
						}
						goto IL_9C;
					}
					IL_5B:
					fileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CONTROLLER_FPGA;
					num = 5;
				}
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000057CC File Offset: 0x000047CC
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password)
		{
			global::Motorola.Common.Communication.CommonUtil.PasswordStatus result;
			try
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
				result = this.c.ValidateLocalPassword(this.b, password);
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::CommunicationController.CCustomExceptionHandler.CreateException(1247U, base.GetType().ToString(), "ValidateLocalPassword", ex.StackTrace);
			}
			return result;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005858 File Offset: 0x00004858
		public void ReadISHTypeIDPairSet(byte btRegion, ref byte[] alDataList)
		{
			switch (0)
			{
			default:
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
					for (;;)
					{
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, ushort>> list = null;
						int num = 4;
						for (;;)
						{
							global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
							global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, ushort>>.Enumerator enumerator;
							int num2;
							switch (num)
							{
							case 0:
								if (!this.d.a(btRegion, out list))
								{
									num = 1;
									continue;
								}
								goto IL_81;
							case 1:
								goto IL_2A8;
							case 2:
								goto IL_16D;
							case 3:
								try
								{
									if (true)
									{
									}
									pbaObject = this.c.ReadBlocks(this.b, new object[]
									{
										new global::Motorola.Common.Communication.CommonUtil.IshHeader(btRegion, ushort.MaxValue, ushort.MaxValue)
									});
									goto IL_259;
								}
								catch (global::System.Exception ex)
								{
									global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
									throw global::CommunicationController.CCustomExceptionHandler.CreateException(741U, base.GetType().ToString(), "ReadISHTypeIDPairSet", ex.StackTrace.ToString());
								}
								goto IL_16D;
							case 4:
								if (!this.d.a(btRegion, out list))
								{
									num = 2;
									continue;
								}
								goto IL_81;
							case 5:
								try
								{
									num = 1;
									for (;;)
									{
										switch (num)
										{
										case 0:
											num = 3;
											continue;
										case 2:
										{
											if (!enumerator.MoveNext())
											{
												num = 0;
												continue;
											}
											global::System.Collections.Generic.KeyValuePair<ushort, ushort> keyValuePair = enumerator.Current;
											byte[] array = null;
											this.b((int)keyValuePair.Key, out array, 2);
											alDataList[num2++] = array[0];
											alDataList[num2++] = array[1];
											this.b((int)keyValuePair.Value, out array, 2);
											alDataList[num2++] = array[0];
											alDataList[num2++] = array[1];
											num = 4;
											continue;
										}
										case 3:
											goto IL_249;
										}
										IL_217:
										num = 2;
										continue;
										goto IL_217;
									}
									IL_249:
									return;
								}
								finally
								{
									((global::System.IDisposable)enumerator).Dispose();
								}
								goto IL_259;
							}
							break;
							IL_81:
							alDataList = new byte[list.Count * 4];
							num2 = 0;
							enumerator = list.GetEnumerator();
							num = 5;
							continue;
							IL_16D:
							pbaObject = null;
							num = 3;
							continue;
							IL_259:
							this.d.a(btRegion, pbaObject.CodeplugData.DataPartitions[0].DataBlocks, true, false);
							num = 0;
						}
					}
					IL_2A8:
					break;
				}
				global::custom_exception.CCustomException ex2 = global::CommunicationController.CCustomExceptionHandler.CreateException(1053U, base.GetType().ToString(), "ReadISHTypeIDPairSet", global::System.Environment.StackTrace.ToString());
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Partition: {0}", new object[]
				{
					btRegion.ToString()
				});
				ex2.AddErrorMessage(message);
				throw ex2;
			}
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00005B30 File Offset: 0x00004B30
		public bool IsEmeraldBlockExists()
		{
			switch (0)
			{
			default:
			{
				int num = 13;
				for (;;)
				{
					string text;
					bool flag2;
					int num2;
					byte partitionNumber;
					ushort ishType;
					string strB;
					global::System.Collections.Generic.List<ushort>.Enumerator enumerator2;
					switch (num)
					{
					case 0:
						if (text.Length >= 4)
						{
							num = 9;
							continue;
						}
						goto IL_219;
					case 1:
					{
						bool flag;
						if (flag)
						{
							num = 11;
							continue;
						}
						return flag2;
					}
					case 2:
						return false;
					case 3:
						goto IL_198;
					case 4:
					{
						if (true)
						{
						}
						bool flag3;
						if (flag3)
						{
							num = 3;
							continue;
						}
						return flag2;
					}
					case 5:
						if (num2 >= 0)
						{
							num = 10;
							continue;
						}
						goto IL_219;
					case 6:
						num = 0;
						continue;
					case 7:
						goto IL_219;
					case 8:
						try
						{
							for (;;)
							{
								global::Motorola.Common.Communication.Pba.PbaObject pbaObject = this.c.ReadBlocks(this.b, new object[]
								{
									new global::Motorola.Common.Communication.CommonUtil.IshHeader(partitionNumber, ishType, ushort.MaxValue)
								});
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock> dataBlocks = pbaObject.CodeplugData.DataPartitions[0].DataBlocks;
								num = 3;
								for (;;)
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator;
									switch (num)
									{
									case 0:
										goto IL_3EC;
									case 1:
										try
										{
											num = 3;
											for (;;)
											{
												switch (num)
												{
												case 0:
												{
													byte b;
													if (b == 8)
													{
														num = 1;
														continue;
													}
													break;
												}
												case 1:
													goto IL_3C0;
												case 2:
													goto IL_3D0;
												case 4:
													goto IL_3DC;
												case 5:
													num = 0;
													continue;
												case 6:
													goto IL_3D0;
												case 7:
												{
													byte b;
													if (b != 7)
													{
														num = 5;
														continue;
													}
													goto IL_3C0;
												}
												case 8:
												{
													if (!enumerator.MoveNext())
													{
														num = 2;
														continue;
													}
													global::Motorola.Common.Communication.Pba.DataBlock dataBlock = enumerator.Current;
													byte b2 = dataBlock.PacketValue[6];
													byte b3 = dataBlock.PacketValue[7];
													byte b = (byte)((int)(b2 & 7) | (int)(b3 & 1) << 3);
													num = 7;
													continue;
												}
												}
												IL_39D:
												num = 8;
												continue;
												goto IL_39D;
												IL_3C0:
												flag2 = true;
												num = 6;
												continue;
												IL_3D0:
												num = 4;
											}
											IL_3DC:
											goto IL_406;
										}
										finally
										{
											((global::System.IDisposable)enumerator).Dispose();
										}
										goto IL_3EC;
									case 2:
										goto IL_412;
									case 3:
										if (dataBlocks != null)
										{
											num = 0;
											continue;
										}
										goto IL_406;
									}
									break;
									IL_3EC:
									enumerator = dataBlocks.GetEnumerator();
									num = 1;
									continue;
									IL_406:
									num = 2;
								}
							}
							IL_412:
							return flag2;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							if (ex.Message != "ReadIshIdSetFailure")
							{
								for (;;)
								{
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_444;
									}
								}
								IL_444:
								if (false)
								{
								}
								throw ex;
							}
							return flag2;
						}
						goto IL_452;
					case 9:
						goto IL_452;
					case 10:
					{
						bool flag3 = true;
						num = 7;
						continue;
					}
					case 11:
					{
						text = this.b.CodeplugVersion;
						strB = "1001";
						bool flag3 = false;
						num = 14;
						continue;
					}
					case 12:
						if (!flag2)
						{
							num = 15;
							continue;
						}
						return flag2;
					case 14:
						if (!string.IsNullOrEmpty(text))
						{
							num = 6;
							continue;
						}
						goto IL_219;
					case 15:
					{
						global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>
						{
							"D105ADD323864E539B513A65076458D3",
							"06CE7B7163C0456A845A6E13421F0AE4",
							"AF5DAB63F4FC4926BB9000A6F18AF3DC"
						};
						bool flag = !list.Contains(this.b.UUID);
						num = 1;
						continue;
					}
					case 16:
						try
						{
							num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_185;
								case 1:
									try
									{
										ushort ishType2;
										global::Motorola.Common.Communication.Pba.PbaObject pbaObject = this.c.ReadBlocks(this.b, new object[]
										{
											new global::Motorola.Common.Communication.CommonUtil.IshHeader(partitionNumber, ishType2, ushort.MaxValue)
										});
										flag2 = true;
									}
									catch (global::Motorola.Common.CustomException.CommonException ex2)
									{
										if (ex2.Message != "ReadIshIdSetFailure")
										{
											throw ex2;
										}
									}
									break;
								case 3:
								{
									if (!enumerator2.MoveNext())
									{
										num = 4;
										continue;
									}
									ushort ishType2 = enumerator2.Current;
									num = 1;
									continue;
								}
								case 4:
									num = 0;
									continue;
								}
								IL_156:
								num = 3;
								continue;
								goto IL_156;
							}
							IL_185:
							goto IL_48E;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_198;
						IL_48E:
						num = 12;
						continue;
					}
					if ("06CE7B7163C0456A845A6E13421F0AE4".Equals(this.b.UUID, global::System.StringComparison.InvariantCulture))
					{
						num = 2;
						continue;
					}
					partitionNumber = 128;
					global::System.Collections.Generic.List<ushort> list2 = new global::System.Collections.Generic.List<ushort>
					{
						3960,
						149,
						3930,
						3935,
						3922
					};
					flag2 = false;
					enumerator2 = list2.GetEnumerator();
					num = 16;
					continue;
					IL_198:
					ishType = 4030;
					num = 8;
					continue;
					IL_219:
					num = 4;
					continue;
					IL_452:
					text = text.Substring(0, 4);
					num2 = string.Compare(text, strB, global::System.StringComparison.Ordinal);
					num = 5;
				}
				return false;
			}
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000060C8 File Offset: 0x000050C8
		public void ReadISHType(byte btRegion, ushort usTypeID, ref byte[] alDataList)
		{
			if (true)
			{
			}
			switch (0)
			{
			default:
			{
				for (;;)
				{
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> list = null;
					int num = 6;
					for (;;)
					{
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>>.Enumerator enumerator;
						int num2;
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
						switch (num)
						{
						case 0:
							goto IL_1F2;
						case 1:
						{
							try
							{
								num = 4;
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
										global::System.Collections.Generic.KeyValuePair<ushort, byte[]> keyValuePair = enumerator.Current;
										num2 += 6;
										num2 += keyValuePair.Value.Length;
										num = 0;
										continue;
									}
									case 2:
										goto IL_340;
									case 3:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											if (false)
											{
											}
											num = 2;
											continue;
										}
										break;
									}
									IL_2FB:
									num = 1;
									continue;
									goto IL_2FB;
								}
								IL_340:
								goto IL_205;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_353;
							IL_205:
							alDataList = new byte[num2];
							alDataList[0] = btRegion;
							byte[] array = null;
							this.b(list.Count, out array, 4);
							array.CopyTo(alDataList, 1);
							int num3 = 5;
							global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>>.Enumerator enumerator2 = list.GetEnumerator();
							num = 3;
							continue;
						}
						case 2:
							if (!this.d.a(btRegion, usTypeID, out list))
							{
								num = 4;
								continue;
							}
							goto IL_68;
						case 3:
							goto IL_EE;
						case 4:
							goto IL_3A3;
						case 5:
							try
							{
								pbaObject = this.c.ReadBlocks(this.b, new object[]
								{
									new global::Motorola.Common.Communication.CommonUtil.IshHeader(btRegion, usTypeID, ushort.MaxValue)
								});
								goto IL_353;
							}
							catch (global::System.Exception ex)
							{
								global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
								throw global::CommunicationController.CCustomExceptionHandler.CreateException(741U, base.GetType().ToString(), "ReadISHType", ex.StackTrace.ToString());
							}
							goto Block_3;
						case 6:
							if (!this.d.a(btRegion, usTypeID, out list))
							{
								num = 0;
								continue;
							}
							goto IL_68;
						}
						break;
						IL_68:
						num2 = 5;
						enumerator = list.GetEnumerator();
						num = 1;
						continue;
						IL_1F2:
						pbaObject = null;
						num = 5;
						continue;
						Block_3:
						try
						{
							IL_EE:
							num = 0;
							for (;;)
							{
								switch (num)
								{
								case 1:
									goto IL_1DF;
								case 2:
									num = 1;
									continue;
								case 4:
								{
									global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = 2;
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<ushort, byte[]> keyValuePair2 = enumerator2.Current;
									byte[] array;
									this.b((int)usTypeID, out array, 2);
									int num3;
									array.CopyTo(alDataList, num3);
									num3 += 2;
									this.b((int)keyValuePair2.Key, out array, 2);
									array.CopyTo(alDataList, num3);
									num3 += 2;
									this.b(keyValuePair2.Value.Length, out array, 2);
									array.CopyTo(alDataList, num3);
									num3 += 2;
									keyValuePair2.Value.CopyTo(alDataList, num3);
									num3 += keyValuePair2.Value.Length;
									num = 3;
									continue;
								}
								}
								IL_1AD:
								num = 4;
								continue;
								goto IL_1AD;
							}
							IL_1DF:
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_1F2;
						IL_353:
						this.d.a(btRegion, pbaObject.CodeplugData.DataPartitions[0].DataBlocks, false, true);
						num = 2;
					}
				}
				IL_3A3:
				global::custom_exception.CCustomException ex2 = global::CommunicationController.CCustomExceptionHandler.CreateException(1053U, base.GetType().ToString(), "ReadISHType", global::System.Environment.StackTrace.ToString());
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Partition: {0}; ISHType: {1}", new object[]
				{
					btRegion.ToString(),
					usTypeID.ToString()
				});
				ex2.AddErrorMessage(message);
				throw ex2;
			}
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000064A8 File Offset: 0x000054A8
		public void WriteISHType(byte btRegion, ushort usTypeID, ref byte[] alDataList)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::Motorola.Common.Communication.Pba.DataPartition dataPartition = null;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator = this.g.CodeplugData.DataPartitions.GetEnumerator();
					int num = 3;
					for (;;)
					{
						int num2;
						int num3;
						int num4;
						int num5;
						byte[] array;
						int num6;
						byte[] array2;
						byte[] array3;
						global::System.Collections.Hashtable hashtable;
						global::Motorola.Common.Communication.Pba.DataBlock dataBlock2;
						switch (num)
						{
						case 0:
							goto IL_306;
						case 1:
							if (num2 >= dataPartition.DataBlocks.Count)
							{
								num = 7;
								continue;
							}
							goto IL_40D;
						case 2:
							goto IL_90;
						case 3:
							try
							{
								num = 1;
								for (;;)
								{
									global::Motorola.Common.Communication.Pba.DataPartition dataPartition2;
									switch (num)
									{
									case 0:
										goto IL_3BE;
									case 2:
									{
										if (!enumerator.MoveNext())
										{
											num = 4;
											continue;
										}
										dataPartition2 = enumerator.Current;
										byte partitionID = dataPartition2.PartitionID;
										num = 6;
										continue;
									}
									case 3:
										goto IL_3FA;
									case 4:
										goto IL_3EE;
									case 5:
										goto IL_3EE;
									case 6:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_3BE;
										default:
										{
											if (false)
											{
											}
											byte partitionID;
											if (partitionID.Equals(btRegion))
											{
												num = 0;
												continue;
											}
											break;
										}
										}
										break;
									}
									goto IL_372;
									IL_3BE:
									dataPartition = dataPartition2;
									num = 5;
									continue;
									IL_3CB:
									num = 2;
									continue;
									IL_372:
									goto IL_3CB;
									IL_3EE:
									num = 3;
								}
								IL_3FA:
								goto IL_109;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_40D;
							IL_109:
							num = 10;
							continue;
						case 4:
						{
							if (num3 >= num4)
							{
								num = 16;
								continue;
							}
							global::Motorola.Common.Communication.Pba.DataBlock dataBlock = new global::Motorola.Common.Communication.Pba.DataBlock();
							dataBlock.Offset = 0;
							global::System.Array.Copy(alDataList, num5, array, 0, array.Length);
							this.a(array, out num6);
							dataBlock.BlockType = (ushort)num6;
							num5 += array.Length;
							global::System.Array.Copy(alDataList, num5, array2, 0, array2.Length);
							this.a(array2, out num6);
							dataBlock.BlockID = (ushort)num6;
							num5 += array2.Length;
							global::System.Array.Copy(alDataList, num5, array3, 0, array3.Length);
							this.a(array3, out num6);
							dataBlock.LegthInBits = (int)((ushort)num6 * 8);
							num5 += array3.Length;
							dataBlock.PacketValue = new byte[num6];
							global::System.Array.Copy(alDataList, num5, dataBlock.PacketValue, 0, num6);
							num5 += num6;
							string key = dataBlock.BlockType.ToString() + "@" + dataBlock.BlockID;
							num = 12;
							continue;
						}
						case 5:
							dataPartition = new global::Motorola.Common.Communication.Pba.DataPartition();
							dataPartition.PartitionID = btRegion;
							this.g.CodeplugData.DataPartitions.Add(dataPartition);
							num = 2;
							continue;
						case 6:
							goto IL_2EF;
						case 7:
							goto IL_90;
						case 8:
							goto IL_274;
						case 9:
							goto IL_274;
						case 10:
							if (dataPartition == null)
							{
								num = 5;
								continue;
							}
							num2 = 0;
							num = 14;
							continue;
						case 11:
							dataPartition.DataBlocks.RemoveAt(num2);
							num2--;
							num = 17;
							continue;
						case 12:
						{
							string key;
							if (hashtable[key] == null)
							{
								num = 15;
								continue;
							}
							goto IL_2EF;
						}
						case 13:
							if (dataBlock2.BlockType == usTypeID)
							{
								num = 11;
								continue;
							}
							goto IL_F4;
						case 14:
							goto IL_306;
						case 15:
						{
							string key;
							hashtable.Add(key, true);
							global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
							dataPartition.DataBlocks.Add(dataBlock);
							if (true)
							{
							}
							num = 6;
							continue;
						}
						case 16:
							return;
						case 17:
							goto IL_F4;
						}
						break;
						IL_90:
						byte[] array4 = new byte[4];
						array = new byte[2];
						array2 = new byte[2];
						array3 = new byte[2];
						num5 = 1;
						global::System.Array.Copy(alDataList, num5, array4, 0, array4.Length);
						num6 = 0;
						num4 = 0;
						this.a(array4, out num4);
						num5 += 4;
						hashtable = new global::System.Collections.Hashtable();
						num3 = 0;
						num = 8;
						continue;
						IL_F4:
						num2++;
						num = 0;
						continue;
						IL_274:
						num = 4;
						continue;
						IL_2EF:
						num3++;
						num = 9;
						continue;
						IL_306:
						num = 1;
						continue;
						IL_40D:
						dataBlock2 = dataPartition.DataBlocks[num2];
						num = 13;
					}
				}
				return;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00006908 File Offset: 0x00005908
		public void DeleteISHIDSet(byte partition, global::System.Collections.Generic.List<ushort> deletableTypeList, global::System.Collections.Generic.List<ushort> idDeletableTypeList)
		{
			global::CommunicationController.CRadioCodeplugController.b b;
			for (;;)
			{
				IL_00:
				if (true)
				{
				}
				for (;;)
				{
					b = new global::CommunicationController.CRadioCodeplugController.b();
					b.a = partition;
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_55;
						case 1:
							this.g = new global::Motorola.Common.Communication.Pba.PbaObject();
							num = 0;
							continue;
						case 2:
							if (this.g == null)
							{
								num = 1;
								continue;
							}
							goto IL_55;
						case 3:
							goto IL_D0;
						case 4:
						{
							if (global::CommunicationController.CRadioCodeplugController.l == null)
							{
								global::CommunicationController.CRadioCodeplugController.l = new global::System.Func<ushort, bool>(global::CommunicationController.CRadioCodeplugController.b);
							}
							global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.DataBlockType> collection = deletableTypeList.Where(global::CommunicationController.CRadioCodeplugController.l).Select(new global::System.Func<ushort, global::Motorola.Common.Communication.Pba.DataBlockType>(b.c));
							this.g.DeletableTypes.AddRange(collection);
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								if (false)
								{
								}
								num = 3;
								continue;
							}
							break;
						}
						}
						break;
						IL_55:
						num = 4;
					}
				}
			}
			IL_D0:
			if (global::CommunicationController.CRadioCodeplugController.m == null)
			{
				global::CommunicationController.CRadioCodeplugController.m = new global::System.Func<ushort, bool>(global::CommunicationController.CRadioCodeplugController.a);
			}
			global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.DataBlockType> collection2 = idDeletableTypeList.Where(global::CommunicationController.CRadioCodeplugController.m).Select(new global::System.Func<ushort, global::Motorola.Common.Communication.Pba.DataBlockType>(b.b));
			this.g.IDDeletableTypes.AddRange(collection2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006A44 File Offset: 0x00005A44
		public void ReadISHID(byte btRegion, ushort usTypeID, ushort usItemID, ref byte[] alDataList)
		{
			switch (0)
			{
			default:
			{
				byte[] array;
				for (;;)
				{
					IL_4F:
					array = null;
					int num = 2;
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B1;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							switch (num)
							{
							case 0:
							{
								global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
								try
								{
									pbaObject = this.c.ReadBlocks(this.b, new object[]
									{
										new global::Motorola.Common.Communication.CommonUtil.IshHeader(btRegion, usTypeID, usItemID)
									});
									goto IL_7A;
								}
								catch (global::System.Exception ex)
								{
									global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
									throw global::CommunicationController.CCustomExceptionHandler.CreateException(741U, base.GetType().ToString(), "ReadISHID", ex.StackTrace.ToString());
								}
								goto IL_1B1;
								IL_7A:
								this.d.a(btRegion, pbaObject.CodeplugData.DataPartitions[0].DataBlocks, false, false);
								num = 4;
								continue;
							}
							case 1:
								goto IL_D5;
							case 2:
								if (!this.d.a(btRegion, usTypeID, usItemID, out array))
								{
									num = 3;
									continue;
								}
								goto IL_1B1;
							case 3:
							{
								global::Motorola.Common.Communication.Pba.PbaObject pbaObject = null;
								num = 0;
								continue;
							}
							case 4:
								if (!this.d.a(btRegion, usTypeID, usItemID, out array))
								{
									num = 1;
									continue;
								}
								goto IL_1B1;
							}
							goto IL_4F;
						}
					}
				}
				IL_D5:
				global::custom_exception.CCustomException ex2 = global::CommunicationController.CCustomExceptionHandler.CreateException(741U, base.GetType().ToString(), "ReadISHID", global::System.Environment.StackTrace.ToString());
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Partition: {0}; ISHType: {1}; ISHID: {2}", new object[]
				{
					btRegion.ToString(),
					usTypeID.ToString(),
					usItemID.ToString()
				});
				ex2.AddErrorMessage(message);
				throw ex2;
				IL_1B1:
				int num2 = 5;
				num2 += 6;
				num2 += array.Length;
				alDataList = new byte[num2];
				alDataList[0] = btRegion;
				byte[] array2 = null;
				this.b(1, out array2, 4);
				array2.CopyTo(alDataList, 1);
				int num3 = 5;
				this.b((int)usTypeID, out array2, 2);
				array2.CopyTo(alDataList, num3);
				num3 += 2;
				this.b((int)usItemID, out array2, 2);
				array2.CopyTo(alDataList, num3);
				num3 += 2;
				this.b(array.Length, out array2, 2);
				array2.CopyTo(alDataList, num3);
				num3 += 2;
				array.CopyTo(alDataList, num3);
				return;
			}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00006CB0 File Offset: 0x00005CB0
		public void GetRadioLanguagePackInfo(ref byte[] alDataList)
		{
			switch (0)
			{
			default:
			{
				for (;;)
				{
					global::CommunicationController.CRadioCodeplugController.a.f f = null;
					int num = 3;
					for (;;)
					{
						global::System.Collections.Generic.Dictionary<string, global::CommunicationController.CRadioCodeplugController.a.b>.ValueCollection.Enumerator enumerator;
						byte[] array;
						int num2;
						global::Motorola.Common.Communication.Pba.LanguagePackData a_;
						switch (num)
						{
						case 0:
							if (!this.d.b(out f))
							{
								num = 5;
								continue;
							}
							goto IL_5A;
						case 1:
							goto IL_178;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_30A;
							default:
								if (false)
								{
								}
								try
								{
									num = 3;
									for (;;)
									{
										switch (num)
										{
										case 0:
											num = 4;
											continue;
										case 2:
										{
											if (!enumerator.MoveNext())
											{
												num = 0;
												continue;
											}
											global::CommunicationController.CRadioCodeplugController.a.b b = enumerator.Current;
											this.a(129, out array, 1);
											array.CopyTo(alDataList, num2);
											num2++;
											this.a(b.h(), out array, 16);
											array.CopyTo(alDataList, num2);
											num2 += 16;
											this.a((int)b.d(), out array, 4);
											array.CopyTo(alDataList, num2);
											num2 += 4;
											this.a((int)b.f(), out array, 4);
											array.CopyTo(alDataList, num2);
											num2 += 4;
											this.a((int)b.g(), out array, 4);
											array.CopyTo(alDataList, num2);
											num2 += 4;
											this.a(b.e(), out array, 100);
											array.CopyTo(alDataList, num2);
											num2 += 100;
											num = 1;
											continue;
										}
										case 4:
											goto IL_2C4;
										}
										IL_292:
										num = 2;
										continue;
										goto IL_292;
									}
									IL_2C4:
									return;
								}
								finally
								{
									((global::System.IDisposable)enumerator).Dispose();
								}
								goto IL_2D4;
							}
							break;
						case 3:
							if (!this.d.b(out f))
							{
								num = 1;
								continue;
							}
							goto IL_5A;
						case 4:
							try
							{
								a_ = this.c.ReadLanguagePacksInfo(this.b);
								goto IL_2D4;
							}
							catch (global::System.Exception ex)
							{
								global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
								throw global::CommunicationController.CCustomExceptionHandler.CreateException(1672U, base.GetType().ToString(), "GetRadioLanguagePackInfo", ex.StackTrace.ToString());
							}
							goto IL_178;
						case 5:
							goto IL_30A;
						}
						break;
						IL_5A:
						int num3 = 5 + 129 * f.b().Count;
						alDataList = new byte[num3];
						num2 = 0;
						array = null;
						this.a((int)f.a(), out array, 4);
						array.CopyTo(alDataList, num2);
						num2 += 4;
						this.a(f.b().Count, out array, 1);
						array.CopyTo(alDataList, num2);
						num2++;
						enumerator = f.b().Values.GetEnumerator();
						num = 2;
						continue;
						IL_178:
						a_ = null;
						num = 4;
						continue;
						IL_2D4:
						this.d.b(a_);
						num = 0;
					}
				}
				IL_30A:
				if (true)
				{
				}
				global::custom_exception.CCustomException ex2 = global::CommunicationController.CCustomExceptionHandler.CreateException(1672U, base.GetType().ToString(), "GetRadioLanguagePackInfo", global::System.Environment.StackTrace.ToString());
				throw ex2;
			}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000700C File Offset: 0x0000600C
		public void GetRadioAvailMemorySize(string strCommand, ref byte[] alDataList)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B3:
				num = 0;
				break;
			case 1:
				goto IL_20;
			default:
				goto IL_20;
			}
			for (;;)
			{
				IL_30:
				switch (num)
				{
				case 0:
					goto IL_BE;
				case 1:
					return;
				case 2:
					if (!(strCommand == "LANGPACKMEMORY"))
					{
						num = 1;
						continue;
					}
					goto IL_A0;
				case 4:
					if (!(strCommand == "TOTALMEMORY"))
					{
						if (true)
						{
						}
						num = 6;
						continue;
					}
					goto IL_64;
				case 5:
					num = 4;
					continue;
				case 6:
					num = 2;
					continue;
				}
				if (strCommand == null)
				{
					return;
				}
				num = 5;
			}
			IL_64:
			this.a(this.b.AvailableMemory, out alDataList, 4);
			return;
			IL_A0:
			this.a(this.b.AvailableLPSpace, out alDataList, 4);
			goto IL_B3;
			IL_BE:
			return;
			IL_20:
			if (false)
			{
			}
			num = 3;
			goto IL_30;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00007100 File Offset: 0x00006100
		public void AddLanguagePack(ref byte[] alDataList, ref uint pbarUpdates)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					int num = 0;
					byte[] array = new byte[1];
					global::System.Array.Copy(alDataList, num, array, 0, array.Length);
					num += array.Length;
					int num2 = 0;
					this.a(array, out num2);
					global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
					global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings = new global::RegistryAccess.CPersistentApplicationSettings();
					string text = string.Empty;
					persistentApplicationSettings.GetXferFolderPath(ref text);
					int num3 = 1;
					for (;;)
					{
						int num4;
						switch (num3)
						{
						case 0:
							if (num4 >= num2)
							{
								num3 = 2;
								continue;
							}
							goto IL_261;
						case 1:
							if (text[text.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
							{
								num3 = 4;
								continue;
							}
							goto IL_FD;
						case 2:
							this.e = pbarUpdates;
							this.h.DSH.OnProgressHandler += this.a;
							num3 = 6;
							continue;
						case 3:
							goto IL_DB;
						case 4:
							text += global::System.IO.Path.DirectorySeparatorChar;
							num3 = 7;
							continue;
						case 5:
							goto IL_DB;
						case 6:
							try
							{
								try
								{
									this.c.WriteLanguagePacks(this.b, languagePackData);
								}
								catch (global::System.Exception ex)
								{
									global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
									throw global::CommunicationController.CCustomExceptionHandler.CreateException(1676U, base.GetType().ToString(), "AddLanguagePack", ex.StackTrace.ToString());
								}
								return;
							}
							finally
							{
								this.h.DSH.OnProgressHandler -= this.a;
								this.a();
								using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator = languagePackData.LanguagePacks.GetEnumerator())
								{
									num3 = 2;
									for (;;)
									{
										switch (num3)
										{
										case 1:
											goto IL_250;
										case 3:
										{
											if (!enumerator.MoveNext())
											{
												num3 = 4;
												continue;
											}
											global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo = (global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)enumerator.Current;
											global::System.IO.File.Delete(pcrLanguagePackInfo.PackFilePath);
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_244;
											default:
												if (false)
												{
												}
												num3 = 0;
												continue;
											}
											break;
										}
										case 4:
											goto IL_244;
										}
										IL_1E6:
										num3 = 3;
										continue;
										goto IL_1E6;
										IL_244:
										num3 = 1;
									}
									IL_250:;
								}
							}
							goto IL_261;
						case 7:
							goto IL_FD;
						}
						break;
						IL_DB:
						num3 = 0;
						continue;
						IL_FD:
						if (true)
						{
						}
						num4 = 0;
						num3 = 5;
						continue;
						IL_261:
						global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo2 = new global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo();
						byte[] array2 = new byte[4];
						global::System.Array.Copy(alDataList, num, array2, 0, array2.Length);
						num += array2.Length;
						int num5 = 0;
						this.a(array2, out num5);
						pcrLanguagePackInfo2.Size = (uint)num5;
						byte[] array3 = new byte[16];
						global::System.Array.Copy(alDataList, num, array3, 0, array3.Length);
						num += array3.Length;
						string empty = string.Empty;
						this.a(array3, out empty);
						pcrLanguagePackInfo2.PackID = empty;
						byte[] array4 = new byte[num5];
						global::System.Array.Copy(alDataList, num, array4, 0, array4.Length);
						num += array4.Length;
						string packFilePath = text + global::System.Guid.NewGuid().ToString("D");
						pcrLanguagePackInfo2.PackFilePath = packFilePath;
						global::System.IO.File.WriteAllBytes(pcrLanguagePackInfo2.PackFilePath, array4);
						languagePackData.LanguagePacks.Add(pcrLanguagePackInfo2);
						num4++;
						num3 = 3;
					}
				}
				return;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00007480 File Offset: 0x00006480
		public void DeleteLanguagePack(ref byte[] alDataList, ref uint pbarUpdates)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					int num = 0;
					byte[] array = new byte[1];
					global::System.Array.Copy(alDataList, num, array, 0, array.Length);
					num += array.Length;
					int num2 = 0;
					this.a(array, out num2);
					int num3 = 2;
					for (;;)
					{
						global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData;
						int num4;
						switch (num3)
						{
						case 0:
							this.e = pbarUpdates;
							this.h.DSH.OnProgressHandler += this.a;
							num3 = 3;
							continue;
						case 1:
							return;
						case 2:
							if (num2 == 0)
							{
								goto IL_69;
							}
							languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
							num4 = 0;
							num3 = 4;
							continue;
						case 3:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_69;
							default:
								if (false)
								{
								}
								if (true)
								{
								}
								try
								{
									try
									{
										this.c.DeleteLanguagePacks(this.b, languagePackData);
									}
									catch (global::System.Exception ex)
									{
										global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
										throw global::CommunicationController.CCustomExceptionHandler.CreateException(1677U, base.GetType().ToString(), "DeleteLanguagePack", ex.StackTrace.ToString());
									}
									return;
								}
								finally
								{
									this.h.DSH.OnProgressHandler -= this.a;
									this.a();
								}
								goto IL_180;
							}
							break;
						case 4:
							goto IL_D7;
						case 5:
							if (num4 >= num2)
							{
								num3 = 0;
								continue;
							}
							goto IL_180;
						case 6:
							goto IL_D7;
						}
						break;
						IL_69:
						num3 = 1;
						continue;
						IL_D7:
						num3 = 5;
						continue;
						IL_180:
						global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo = new global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo();
						byte[] array2 = new byte[16];
						global::System.Array.Copy(alDataList, num, array2, 0, array2.Length);
						num += array2.Length;
						string empty = string.Empty;
						this.a(array2, out empty);
						pcrLanguagePackInfo.PackID = empty;
						languagePackData.LanguagePacks.Add(pcrLanguagePackInfo);
						num4++;
						num3 = 6;
					}
				}
				return;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00007690 File Offset: 0x00006690
		public void GetRadioTTSLanguagePackInfo(out global::CommunicationController.TTSPacks langPackInfo)
		{
			switch (0)
			{
			default:
			{
				for (;;)
				{
					global::CommunicationController.CRadioCodeplugController.a.f f = null;
					langPackInfo = null;
					int num = 5;
					for (;;)
					{
						global::Motorola.Common.Communication.Pba.LanguagePackData a_;
						global::System.Collections.Generic.Dictionary<string, global::CommunicationController.CRadioCodeplugController.a.b>.ValueCollection.Enumerator enumerator;
						switch (num)
						{
						case 0:
							goto IL_107;
						case 1:
							try
							{
								a_ = this.c.ReadTTSLanguagePacksInfo(this.b);
								goto IL_24B;
							}
							catch (global::System.Exception ex)
							{
								global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
								throw global::CommunicationController.CCustomExceptionHandler.CreateException(1672U, base.GetType().ToString(), "GetRadioTTSLanguagePackInfo", ex.StackTrace.ToString());
							}
							goto IL_107;
						case 2:
							if (!this.d.a(out f))
							{
								num = 3;
								continue;
							}
							goto IL_5D;
						case 3:
							goto IL_281;
						case 4:
							try
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
										goto IL_23B;
									case 3:
										num = 1;
										continue;
									case 4:
										if (!enumerator.MoveNext())
										{
											num = 3;
											continue;
										}
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
											global::CommunicationController.CRadioCodeplugController.a.a a = (global::CommunicationController.CRadioCodeplugController.a.a)enumerator.Current;
											global::CommunicationController.SingleTTSPack singleTTSPack = new global::CommunicationController.SingleTTSPack();
											singleTTSPack.ID = a.h();
											singleTTSPack.Name = a.e();
											singleTTSPack.Size = a.g();
											singleTTSPack.MajorVersion = a.d();
											singleTTSPack.MinorVersion = a.f();
											singleTTSPack.SpeakerName = a.c();
											singleTTSPack.VoiceGender = a.a();
											singleTTSPack.LangCode = a.b();
											langPackInfo.Packs.Add(singleTTSPack);
											num = 2;
											continue;
										}
										}
										break;
									}
									IL_209:
									num = 4;
									continue;
									IL_147:
									goto IL_209;
									goto IL_147;
								}
								IL_23B:
								return;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_24B;
						case 5:
							if (!this.d.a(out f))
							{
								num = 0;
								continue;
							}
							goto IL_5D;
						}
						break;
						IL_5D:
						langPackInfo = new global::CommunicationController.TTSPacks();
						langPackInfo.AvailSpace = f.a();
						enumerator = f.b().Values.GetEnumerator();
						if (true)
						{
						}
						num = 4;
						continue;
						IL_107:
						a_ = null;
						num = 1;
						continue;
						IL_24B:
						this.d.a(a_);
						num = 2;
					}
				}
				IL_281:
				global::custom_exception.CCustomException ex2 = global::CommunicationController.CCustomExceptionHandler.CreateException(1672U, base.GetType().ToString(), "GetRadioLanguagePackInfo", global::System.Environment.StackTrace.ToString());
				throw ex2;
			}
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00007958 File Offset: 0x00006958
		public void AddTTSLanguagePack(global::CommunicationController.SingleTTSPack pack)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
					global::RegistryAccess.IPersistentApplicationSettings persistentApplicationSettings = new global::RegistryAccess.CPersistentApplicationSettings();
					string text = string.Empty;
					persistentApplicationSettings.GetXferFolderPath(ref text);
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_170;
						case 1:
							try
							{
								try
								{
									this.c.WriteTTSLanguagePacks(this.b, languagePackData);
								}
								catch (global::System.Exception ex)
								{
									global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
									throw global::CommunicationController.CCustomExceptionHandler.CreateException(1676U, base.GetType().ToString(), "AddLanguagePack", ex.StackTrace.ToString());
								}
								return;
							}
							finally
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
									using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator = languagePackData.LanguagePacks.GetEnumerator())
									{
										num = 1;
										for (;;)
										{
											switch (num)
											{
											case 0:
												num = 3;
												continue;
											case 3:
												goto IL_15F;
											case 4:
											{
												if (!enumerator.MoveNext())
												{
													num = 0;
													continue;
												}
												global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo = (global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo)enumerator.Current;
												global::System.IO.File.Delete(ttslanguagePackInfo.PackFilePath);
												num = 2;
												continue;
											}
											}
											IL_114:
											num = 4;
											continue;
											goto IL_114;
										}
										IL_15F:;
									}
									break;
								}
							}
							goto IL_170;
						case 2:
							if (text[text.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
							{
								if (true)
								{
								}
								num = 3;
								continue;
							}
							goto IL_170;
						case 3:
							text += global::System.IO.Path.DirectorySeparatorChar;
							num = 0;
							continue;
						}
						break;
						IL_170:
						global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo2 = new global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo();
						ttslanguagePackInfo2.Size = pack.Size;
						ttslanguagePackInfo2.PackID = pack.ID;
						string packFilePath = text + global::System.Guid.NewGuid().ToString("D");
						ttslanguagePackInfo2.PackFilePath = packFilePath;
						global::System.IO.File.WriteAllBytes(ttslanguagePackInfo2.PackFilePath, pack.PackData);
						languagePackData.LanguagePacks.Add(ttslanguagePackInfo2);
						num = 1;
					}
				}
				return;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00007B98 File Offset: 0x00006B98
		public void DeleteTTSLanguagePack()
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			}
			if (true)
			{
			}
			if (false)
			{
			}
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo = new global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo();
			ttslanguagePackInfo.PackID = string.Empty;
			languagePackData.LanguagePacks.Add(ttslanguagePackInfo);
			try
			{
				this.c.DeleteTTSLanguagePacks(this.b, languagePackData);
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::CommunicationController.CCustomExceptionHandler.CreateException(1677U, base.GetType().ToString(), "DeleteLanguagePack", ex.StackTrace.ToString());
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007C4C File Offset: 0x00006C4C
		public void UpdateRadioSerialNumber(string newSerialNumber, uint uiTargetSN)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.c.UpdateSerialNumber(this.b, newSerialNumber);
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::CommunicationController.CCustomExceptionHandler.CreateException(1118U, base.GetType().ToString(), "UpdateRadioSerialNumber", global::System.Environment.StackTrace.ToString());
			}
			if (true)
			{
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007CD8 File Offset: 0x00006CD8
		public void UnkillRadio(byte[] Value)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.c.UnkillRadio(this.b, Value);
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::CommunicationController.CCustomExceptionHandler.CreateException(1118U, base.GetType().ToString(), "UnkillRadio", global::System.Environment.StackTrace.ToString());
			}
			if (true)
			{
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007D64 File Offset: 0x00006D64
		public byte[] ReadUnkillChallengeValue()
		{
			byte[] result;
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				result = this.c.ReadUnkillChallengeValue(this.b);
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::CommunicationController.CCustomExceptionHandler.CreateException(1118U, base.GetType().ToString(), "ReadUnkillChallengeValue", global::System.Environment.StackTrace.ToString());
			}
			if (true)
			{
			}
			return result;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00007DF0 File Offset: 0x00006DF0
		public void SendUpdateIMEType(byte ime)
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
			this.c.SendUpdateIMEType(this.b, ime);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00007E40 File Offset: 0x00006E40
		public void UpdateRadioMACAddress(byte[] newMacAddress, uint uiTargetMAC)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.c.UpdateMACAddress(this.b, newMacAddress);
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::CommunicationController.CCustomExceptionHandler.CreateException(2980U, base.GetType().ToString(), "UpdateRadioMACAddress", ex.StackTrace.ToString());
			}
			if (true)
			{
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00007ECC File Offset: 0x00006ECC
		public void GetDeviceInstance(ref string instance)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return;
				case 2:
				{
					string[] array = this.b.ConnectionInfo.DeviceInstance.Split(new char[]
					{
						'\\'
					});
					instance = array[2].ToLowerInvariant();
					goto IL_98;
				}
				}
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_98:
					num = 0;
					continue;
				}
				if (false)
				{
				}
				if (string.IsNullOrEmpty(this.b.ConnectionInfo.DeviceInstance))
				{
					break;
				}
				num = 2;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00007F80 File Offset: 0x00006F80
		public void SendEnterFZMode()
		{
			try
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
				this.c.SwitchRadioMode(this.b, global::Motorola.Common.Communication.CommonUtil.DeviceMode.FLASHSTRAP);
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::CommunicationController.CCustomExceptionHandler.CreateException(693U, base.GetType().ToString(), "SendEnterFZMode", ex.StackTrace.ToString());
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000800C File Offset: 0x0000700C
		public void XNLIsDualBoard(ref bool bISDualBoard)
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
			bISDualBoard = this.b.IsDualBoard;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00008054 File Offset: 0x00007054
		public void SendCommitUpdate()
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
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00008090 File Offset: 0x00007090
		public void SendUpdateControl(uint action, uint type)
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

		// Token: 0x060000AE RID: 174 RVA: 0x000080CC File Offset: 0x000070CC
		public void getIsRemote(ref bool isRemote)
		{
			for (;;)
			{
				isRemote = false;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							if (false)
							{
							}
							if (this.b.ConnectionInfo != null)
							{
								num = 2;
								continue;
							}
							return;
						}
						break;
					case 1:
						return;
					case 2:
						if (true)
						{
						}
						isRemote = (this.b.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork);
						num = 1;
						continue;
					}
					break;
				}
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000815C File Offset: 0x0000715C
		public void SendISHProgramMode(byte action)
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
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00008198 File Offset: 0x00007198
		public void SendRadioEnterProgramMode()
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

		// Token: 0x060000B1 RID: 177 RVA: 0x000081D4 File Offset: 0x000071D4
		public void SendRadioExitProgramMode()
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

		// Token: 0x060000B2 RID: 178 RVA: 0x00008210 File Offset: 0x00007210
		public void WriteCommit()
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					break;
				case 1:
					try
					{
						try
						{
							this.g.CodeplugData.CPVersion = this.b.CodeplugVersion;
							this.c.WriteDevice(this.b, this.g);
						}
						catch (global::System.Exception ex)
						{
							global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
							throw global::CommunicationController.CCustomExceptionHandler.CreateException(1118U, base.GetType().ToString(), "WriteCommit", global::System.Environment.StackTrace.ToString());
						}
						return;
					}
					finally
					{
						this.h.DSH.OnProgressHandler -= this.a;
						this.a();
					}
					goto IL_CD;
				case 2:
					goto IL_132;
				case 3:
					if (!global::CommunicationController.AppStartupMode.IsRMCCall)
					{
						goto IL_CD;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_132;
					default:
						if (false)
						{
						}
						num = 2;
						continue;
					}
					break;
				case 4:
					num = 3;
					continue;
				}
				if (global::CommunicationController.AppStartupMode.AppMode != global::CommunicationController.StartUpMode.Cruncher)
				{
					num = 4;
					continue;
				}
				break;
				IL_CD:
				this.h.DSH.OnProgressHandler += this.a;
				num = 1;
			}
			IL_132:
			this.g.CodeplugData.CPVersion = this.DeviceInfo.CodeplugVersion;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00008394 File Offset: 0x00007394
		public void UpdateDateCode(ref byte[] dataArray, ushort source)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.c.SendUpdateDateCode(this.b, dataArray, source);
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::CommunicationController.CCustomExceptionHandler.CreateException(743U, base.GetType().ToString(), "UpdateDateCode", ex.StackTrace.ToString());
			}
			if (true)
			{
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00008424 File Offset: 0x00007424
		public void UpdateDateCode(global::System.DateTime dateTime, ushort source)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_10E;
						case 2:
						{
							byte[] array;
							this.UpdateDateCode(ref array, source);
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_D4;
							default:
								if (false)
								{
								}
								num = 4;
								continue;
							}
							break;
						}
						case 3:
							goto IL_E2;
						case 4:
							goto IL_102;
						case 5:
						{
							byte[] array;
							int num2;
							if (num2 >= array.Length)
							{
								num = 2;
								continue;
							}
							int startIndex = num2 * 2;
							string text;
							array[num2] = global::System.Convert.ToByte(text.Substring(startIndex, 2), 16);
							num2++;
							goto IL_D4;
						}
						case 6:
						{
							string text = dateTime.ToString("yyMMddHHmmss");
							byte[] array = new byte[6];
							int num2 = 0;
							num = 3;
							continue;
						}
						case 7:
							goto IL_E2;
						}
						if (!this.b.UUID.Equals("06CE7B7163C0456A845A6E13421F0AE4", global::System.StringComparison.Ordinal))
						{
							num = 6;
							continue;
						}
						goto IL_102;
						IL_D4:
						num = 7;
						continue;
						IL_E2:
						num = 5;
						continue;
						IL_102:
						num = 1;
					}
					IL_10E:
					break;
				}
				}
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::CommunicationController.CCustomExceptionHandler.CreateException(743U, base.GetType().ToString(), "UpdateDateCode", ex.StackTrace.ToString());
			}
			if (true)
			{
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000085BC File Offset: 0x000075BC
		public void OpenProgrammingSession()
		{
			try
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_90;
					case 2:
						goto IL_BF;
					case 3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32;
						default:
							if (false)
							{
							}
							if (true)
							{
							}
							this.c.CloseSession(this.b, true);
							this.b.ConnectionInfo.SessionID = 0;
							num = 1;
							continue;
						}
						break;
					}
					goto IL_20;
					IL_32:
					num = 3;
					continue;
					IL_20:
					if (this.b.ConnectionInfo.SessionID != 0)
					{
						goto IL_32;
					}
					IL_90:
					this.b.ConnectionInfo.SessionID = this.c.OpenSession(this.b, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program, null);
					num = 2;
				}
				IL_BF:;
			}
			catch (global::System.Exception ex)
			{
				try
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_130;
						case 2:
							this.c.CloseSession(this.b, true);
							this.b.ConnectionInfo.SessionID = 0;
							num = 1;
							continue;
						case 3:
							goto IL_138;
						}
						if (this.b.ConnectionInfo.SessionID != 0)
						{
							num = 2;
							continue;
						}
						IL_130:
						num = 3;
					}
					IL_138:;
				}
				catch
				{
				}
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::CommunicationController.CCustomExceptionHandler.CreateException(743U, base.GetType().ToString(), "EnableRadioFeature", ex.StackTrace.ToString());
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00008758 File Offset: 0x00007758
		public void EnableFeatures(string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeList, bool isLocalMode)
		{
			bool flag = false;
			try
			{
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.c.CloseSession(this.b, true);
						this.b.ConnectionInfo.SessionID = 0;
						num = 6;
						continue;
					case 1:
						goto IL_C6;
					case 2:
						if (this.b.ConnectionInfo.SessionID != 0)
						{
							num = 0;
							continue;
						}
						goto IL_64;
					case 3:
						goto IL_E6;
					case 5:
						num = 2;
						continue;
					case 6:
						goto IL_64;
					}
					if (isLocalMode)
					{
						num = 5;
						continue;
					}
					goto IL_C6;
					IL_64:
					this.b.ConnectionInfo.SessionID = this.c.OpenSession(this.b, global::Motorola.Common.Communication.CommonUtil.RadioOperation.ChargingFeature, null);
					num = 1;
					continue;
					IL_C6:
					this.c.EnableFxFeature(this.b, xmlHashInput, featureCodeList);
					flag = true;
					num = 3;
				}
				IL_E6:;
			}
			catch (global::System.Exception ex)
			{
				global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
				throw global::CommunicationController.CCustomExceptionHandler.CreateException(743U, base.GetType().ToString(), "EnableRadioFeature", ex.StackTrace.ToString());
			}
			finally
			{
				if (!flag)
				{
					try
					{
						int num = 3;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_1A7;
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
									break;
								}
								this.c.CloseSession(this.b, true);
								this.b.ConnectionInfo.SessionID = 0;
								num = 0;
								continue;
							case 2:
								goto IL_1B2;
							}
							if (this.b.ConnectionInfo.SessionID != 0)
							{
								num = 1;
								continue;
							}
							IL_1A7:
							num = 2;
						}
						IL_1B2:;
					}
					catch
					{
					}
				}
			}
			if (true)
			{
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000897C File Offset: 0x0000797C
		public long GetFileOrDirSize(ushort partitionID, byte[] pathBuffer)
		{
			if (true)
			{
			}
			switch (0)
			{
			default:
			{
				string @string;
				for (;;)
				{
					for (;;)
					{
						long num = 0L;
						@string = global::System.Text.Encoding.UTF8.GetString(pathBuffer);
						int num2 = 2;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_C0;
							case 1:
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
									global::Motorola.Common.Communication.Pba.FileItem fileItem = new global::Motorola.Common.Communication.Pba.FileItem(partitionID, @string, 0, null, null, null);
									num2 = 3;
									continue;
								}
								}
								break;
							case 2:
								if (!this.d.a(@string, out num))
								{
									num2 = 1;
									continue;
								}
								return num;
							case 3:
							{
								global::Motorola.Common.Communication.Pba.FileItem fileItem;
								try
								{
									num = this.c.GetFileOrDirSize(this.b, fileItem);
									goto IL_73;
								}
								catch (global::System.Exception ex)
								{
									global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
									throw global::CommunicationController.CCustomExceptionHandler.CreateException(1927U, base.GetType().ToString(), "GetFileOrDirSize", ex.StackTrace.ToString());
								}
								return num;
								IL_73:
								fileItem.FileSize = (int)num;
								this.d.a(new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>
								{
									fileItem
								}, false);
								num2 = 4;
								continue;
							}
							case 4:
								if (!this.d.a(@string, out num))
								{
									num2 = 0;
									continue;
								}
								return num;
							}
							break;
						}
					}
				}
				IL_C0:
				global::custom_exception.CCustomException ex2 = global::CommunicationController.CCustomExceptionHandler.CreateException(1053U, base.GetType().ToString(), "GetFileOrDirSize", global::System.Environment.StackTrace.ToString());
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Path: {0}", new object[]
				{
					@string
				});
				ex2.AddErrorMessage(message);
				throw ex2;
			}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00008B2C File Offset: 0x00007B2C
		public void UploadFile(ushort partitionID, byte[] filePathBuffer, byte[] fileContentBuffer)
		{
			switch (0)
			{
			default:
			{
				global::Motorola.Common.Communication.Pba.FileItem fileItem;
				for (;;)
				{
					for (;;)
					{
						string @string = global::System.Text.Encoding.UTF8.GetString(filePathBuffer);
						fileItem = new global::Motorola.Common.Communication.Pba.FileItem(partitionID, @string, fileContentBuffer.Length, (byte[])fileContentBuffer.Clone(), null, null);
						int num = 2;
						for (;;)
						{
							if (true)
							{
							}
							int num2;
							switch (num)
							{
							case 0:
								goto IL_B7;
							case 1:
								num2 = 0;
								num = 4;
								continue;
							case 2:
								if (@string == "/opt/pcr/rel/data/mmi/welcome_bitmap")
								{
									num = 1;
									continue;
								}
								try
								{
									this.c.WriteFile(this.b, fileItem);
									return;
								}
								catch (global::System.Exception ex)
								{
									global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
									throw global::CommunicationController.CCustomExceptionHandler.CreateException(1928U, base.GetType().ToString(), "UploadFile", ex.StackTrace.ToString());
								}
								goto IL_194;
							case 3:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									if (false)
									{
									}
									if (num2 >= this.g.FileSetList.Count)
									{
										num = 8;
										continue;
									}
									num = 6;
									continue;
								}
								break;
							case 4:
								goto IL_B7;
							case 5:
								goto IL_1D0;
							case 6:
								if (this.g.FileSetList[num2].Name.Equals("WelcomeBitmap", global::System.StringComparison.OrdinalIgnoreCase))
								{
									num = 7;
									continue;
								}
								goto IL_194;
							case 7:
								this.g.FileSetList.RemoveAt(num2);
								num = 5;
								continue;
							case 8:
								goto IL_FE;
							}
							break;
							IL_B7:
							num = 3;
							continue;
							IL_194:
							num2++;
							num = 0;
						}
					}
				}
				IL_8E:
				global::Motorola.Common.Communication.Pba.FileSet fileSet = new global::Motorola.Common.Communication.Pba.FileSet("WelcomeBitmap");
				fileSet.FileItemsList.Add(fileItem);
				this.g.FileSetList.Add(fileSet);
				return;
				IL_FE:
				IL_1D0:
				goto IL_8E;
			}
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00008D20 File Offset: 0x00007D20
		public byte[] DownloadFile(ushort partitionID, byte[] filePathBuffer)
		{
			switch (0)
			{
			default:
			{
				byte[] result;
				string @string;
				for (;;)
				{
					result = null;
					@string = global::System.Text.Encoding.UTF8.GetString(filePathBuffer);
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (!this.d.a(@string, out result))
							{
								num = 4;
								continue;
							}
							goto IL_17E;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_B3;
							default:
							{
								if (false)
								{
								}
								global::Motorola.Common.Communication.Pba.FileItem fileItem;
								try
								{
									fileItem = this.c.ReadFile(this.b, fileItem);
									goto IL_60;
								}
								catch (global::System.Exception ex)
								{
									global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
									throw global::CommunicationController.CCustomExceptionHandler.CreateException(1929U, base.GetType().ToString(), "DownloadFile", ex.StackTrace.ToString());
								}
								goto IL_17E;
								IL_60:
								this.d.a(new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>
								{
									fileItem
								}, false);
								num = 3;
								continue;
							}
							}
							break;
						case 2:
							goto IL_A5;
						case 3:
							if (!this.d.a(@string, out result))
							{
								num = 2;
								continue;
							}
							goto IL_17E;
						case 4:
						{
							global::Motorola.Common.Communication.Pba.FileItem fileItem = new global::Motorola.Common.Communication.Pba.FileItem(partitionID, @string, 0, null, null, null);
							goto IL_B3;
						}
						}
						break;
						IL_B3:
						num = 1;
					}
				}
				IL_A5:
				global::custom_exception.CCustomException ex2 = global::CommunicationController.CCustomExceptionHandler.CreateException(1053U, base.GetType().ToString(), "DownloadFile", global::System.Environment.StackTrace.ToString());
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Path: {0}", new object[]
				{
					@string
				});
				ex2.AddErrorMessage(message);
				throw ex2;
				IL_17E:
				if (true)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00008EC4 File Offset: 0x00007EC4
		public void DeleteFile(ushort partitionID, byte[] filePathBuffer)
		{
			int num;
			int num2;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_C7:
				if (num >= this.g.FileSetList.Count)
				{
					num2 = 7;
				}
				else
				{
					num2 = 6;
				}
				break;
			default:
				if (false)
				{
				}
				if (true)
				{
				}
				switch (0)
				{
				default:
					goto IL_5F;
				}
				break;
			}
			string @string;
			global::Motorola.Common.Communication.Pba.FileItem file;
			for (;;)
			{
				IL_34:
				switch (num2)
				{
				case 0:
					goto IL_BB;
				case 1:
					goto IL_1B8;
				case 2:
					this.g.FileSetList.RemoveAt(num);
					num2 = 1;
					continue;
				case 3:
					num = 0;
					num2 = 8;
					continue;
				case 4:
					goto IL_C7;
				case 5:
					if (@string == "/opt/pcr/rel/data/mmi/welcome_bitmap")
					{
						num2 = 3;
						continue;
					}
					try
					{
						this.c.DeleteFile(this.b, file);
						return;
					}
					catch (global::System.Exception ex)
					{
						global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
						throw global::CommunicationController.CCustomExceptionHandler.CreateException(1931U, base.GetType().ToString(), "DeleteFile", ex.StackTrace.ToString());
					}
					goto IL_186;
				case 6:
					if (this.g.FileSetList[num].Name.Equals("WelcomeBitmap", global::System.StringComparison.OrdinalIgnoreCase))
					{
						num2 = 2;
						continue;
					}
					goto IL_186;
				case 7:
					goto IL_E6;
				case 8:
					goto IL_BB;
				}
				goto IL_5F;
				IL_BB:
				num2 = 4;
				continue;
				IL_186:
				num++;
				num2 = 0;
			}
			IL_9E:
			global::Motorola.Common.Communication.Pba.FileSet item = new global::Motorola.Common.Communication.Pba.FileSet("WelcomeBitmap");
			this.g.FileSetList.Add(item);
			return;
			IL_E6:
			IL_1B8:
			goto IL_9E;
			IL_5F:
			@string = global::System.Text.Encoding.UTF8.GetString(filePathBuffer);
			file = new global::Motorola.Common.Communication.Pba.FileItem(partitionID, @string, 0, null, null, null);
			num2 = 5;
			goto IL_34;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000090A0 File Offset: 0x000080A0
		public global::System.Collections.Generic.Dictionary<string, uint> GetFilesListInDir(ushort partitionID, byte[] dirPathBuffer)
		{
			switch (0)
			{
			default:
			{
				string text;
				for (;;)
				{
					text = global::System.Text.Encoding.UTF8.GetString(dirPathBuffer);
					int num = 2;
					for (;;)
					{
						global::System.Collections.Generic.Dictionary<string, uint> result;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> list;
						switch (num)
						{
						case 0:
							goto IL_97;
						case 1:
							if (!this.d.a(text, out result))
							{
								num = 9;
								continue;
							}
							return result;
						case 2:
							if (!text.EndsWith("/", global::System.StringComparison.Ordinal))
							{
								num = 4;
								continue;
							}
							goto IL_97;
						case 3:
							try
							{
								global::Motorola.Common.Communication.Pba.FileItem fileItem;
								list = this.c.ReadFilesListInDir(this.b, fileItem);
								goto IL_146;
							}
							catch (global::System.Exception ex)
							{
								global::CommunicationController.CommonExpToCustomExpHelper.ConvertCommonExceptionAndThrow(ex);
								throw global::CommunicationController.CCustomExceptionHandler.CreateException(1930U, base.GetType().ToString(), "GetFilesListInDir", ex.StackTrace.ToString());
							}
							goto IL_208;
							IL_146:
							num = 10;
							continue;
						case 4:
							text += "/";
							num = 0;
							continue;
						case 5:
							if (!this.d.a(text, out result))
							{
								num = 8;
								continue;
							}
							return result;
						case 6:
							goto IL_D3;
						case 7:
						{
							if (true)
							{
							}
							list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>();
							global::Motorola.Common.Communication.Pba.FileItem fileItem;
							list.Add(fileItem);
							num = 6;
							continue;
						}
						case 8:
							goto IL_208;
						case 9:
							goto IL_127;
						case 10:
							if (list.Count == 0)
							{
								num = 7;
								continue;
							}
							goto IL_D3;
						}
						break;
						IL_97:
						result = null;
						num = 5;
						continue;
						IL_D3:
						this.d.a(list, true);
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
						{
							IL_208:
							global::Motorola.Common.Communication.Pba.FileItem fileItem = new global::Motorola.Common.Communication.Pba.FileItem(partitionID, text, 0, null, null, null);
							list = null;
							num = 3;
							break;
						}
						default:
							if (false)
							{
							}
							num = 1;
							break;
						}
					}
				}
				IL_127:
				global::custom_exception.CCustomException ex2 = global::CommunicationController.CCustomExceptionHandler.CreateException(1053U, base.GetType().ToString(), "GetFilesListInDir", global::System.Environment.StackTrace.ToString());
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Path: {0}", new object[]
				{
					text
				});
				ex2.AddErrorMessage(message);
				throw ex2;
			}
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000092E4 File Offset: 0x000082E4
		private void a(uint A_0, string A_1)
		{
			if (A_0 != 0U)
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					if (true)
					{
					}
					if (false)
					{
					}
					global::custom_exception.CCustomException ex = global::CommunicationController.CCustomExceptionHandler.CreateException(A_0 & 65535U, base.GetType().ToString(), A_1, global::System.Environment.StackTrace.ToString());
					throw ex;
				}
				}
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000934C File Offset: 0x0000834C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool b(ushort A_0)
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
			return A_0 != 0;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00009390 File Offset: 0x00008390
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static bool a(ushort A_0)
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
			return A_0 != 0;
		}

		// Token: 0x04000041 RID: 65
		private const uint a = 100U;

		// Token: 0x04000042 RID: 66
		private global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo b;

		// Token: 0x04000043 RID: 67
		private global::Motorola.Common.Communication.Service.IDeviceOperation c;

		// Token: 0x04000044 RID: 68
		private global::CommunicationController.CRadioCodeplugController.a d;

		// Token: 0x04000045 RID: 69
		private uint e;

		// Token: 0x04000046 RID: 70
		private int f;

		// Token: 0x04000047 RID: 71
		private global::Motorola.Common.Communication.Pba.PbaObject g;

		// Token: 0x04000048 RID: 72
		private global::CommunicationController.CSerialTransportController.STCConnection h;

		// Token: 0x04000049 RID: 73
		private bool i;

		// Token: 0x0400004A RID: 74
		private uint j;

		// Token: 0x0400004B RID: 75
		private global::constants.CCPTags.SetProgressBar k;

		// Token: 0x0400004C RID: 76
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::System.Func<ushort, bool> l;

		// Token: 0x0400004D RID: 77
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::System.Func<ushort, bool> m;

		// Token: 0x02000017 RID: 23
		private class a
		{
			// Token: 0x060000BF RID: 191 RVA: 0x000093D4 File Offset: 0x000083D4
			public a()
			{
				this.a = new global::System.Collections.Generic.Dictionary<string, global::CommunicationController.CRadioCodeplugController.a.g>();
				this.b = null;
				this.c = null;
				this.d = new global::System.Collections.Generic.Dictionary<byte, global::CommunicationController.CRadioCodeplugController.a.h>();
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x0000940C File Offset: 0x0000840C
			public bool a(byte A_0, out global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, ushort>> A_1)
			{
				switch (0)
				{
				default:
				{
					bool result;
					for (;;)
					{
						A_1 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, ushort>>();
						result = true;
						int num = 5;
						for (;;)
						{
							global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.e>.ValueCollection.Enumerator enumerator2;
							switch (num)
							{
							case 0:
								try
								{
									num = 5;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_1C7;
										case 1:
											try
											{
												num = 1;
												for (;;)
												{
													switch (num)
													{
													case 2:
													{
														global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.c>.ValueCollection.Enumerator enumerator;
														if (!enumerator.MoveNext())
														{
															num = 3;
															continue;
														}
														global::CommunicationController.CRadioCodeplugController.a.c c = enumerator.Current;
														global::CommunicationController.CRadioCodeplugController.a.e e;
														A_1.Add(new global::System.Collections.Generic.KeyValuePair<ushort, ushort>(e.b(), c.b()));
														num = 0;
														continue;
													}
													case 3:
														num = 4;
														continue;
													case 4:
														goto IL_17C;
													}
													IL_156:
													num = 2;
													continue;
													goto IL_156;
												}
												IL_17C:
												break;
											}
											finally
											{
												global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.c>.ValueCollection.Enumerator enumerator;
												((global::System.IDisposable)enumerator).Dispose();
											}
											goto IL_18F;
										case 2:
										{
											if (!enumerator2.MoveNext())
											{
												num = 3;
												continue;
											}
											global::CommunicationController.CRadioCodeplugController.a.e e = enumerator2.Current;
											num = 6;
											continue;
										}
										case 3:
											goto IL_19F;
										case 4:
											goto IL_19F;
										case 6:
										{
											global::CommunicationController.CRadioCodeplugController.a.e e;
											if (!e.c())
											{
												num = 7;
												continue;
											}
											global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.c>.ValueCollection.Enumerator enumerator = e.a().Values.GetEnumerator();
											num = 1;
											continue;
										}
										case 7:
											goto IL_18F;
										}
										IL_9C:
										num = 2;
										continue;
										IL_9A:
										goto IL_9C;
										IL_18F:
										result = false;
										num = 4;
										continue;
										IL_19F:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_9A;
										default:
											if (false)
											{
											}
											num = 0;
											break;
										}
									}
									IL_1C7:
									return result;
								}
								finally
								{
									((global::System.IDisposable)enumerator2).Dispose();
								}
								goto IL_1DA;
							case 1:
								if (!this.d[A_0].b())
								{
									num = 3;
									continue;
								}
								goto IL_1DA;
							case 2:
								return result;
							case 3:
								goto IL_234;
							case 4:
								num = 1;
								continue;
							case 5:
								if (true)
								{
								}
								if (this.d.ContainsKey(A_0))
								{
									num = 4;
									continue;
								}
								goto IL_234;
							}
							break;
							IL_1DA:
							enumerator2 = this.d[A_0].c().Values.GetEnumerator();
							num = 0;
							continue;
							IL_234:
							result = false;
							num = 2;
						}
					}
					return result;
				}
				}
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x000096A0 File Offset: 0x000086A0
			public bool a(byte A_0, ushort A_1, ushort A_2, out byte[] A_3)
			{
				bool result;
				for (;;)
				{
					A_3 = null;
					result = true;
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (this.d[A_0].c()[A_1].a()[A_2].a() == null)
							{
								num = 3;
								continue;
							}
							A_3 = this.d[A_0].c()[A_1].a()[A_2].a();
							num = 4;
							continue;
						case 1:
							if (this.d[A_0].c()[A_1].a().ContainsKey(A_2))
							{
								num = 9;
								continue;
							}
							goto IL_7A;
						case 2:
							goto IL_3E;
						case 3:
							goto IL_7A;
						case 4:
							return result;
						case 5:
							return result;
						case 6:
							if (this.d[A_0].c().ContainsKey(A_1))
							{
								num = 7;
								continue;
							}
							goto IL_7A;
						case 7:
							num = 1;
							continue;
						case 8:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3E;
							default:
								if (true)
								{
								}
								if (false)
								{
								}
								num = 6;
								continue;
							}
							break;
						case 9:
							num = 0;
							continue;
						}
						break;
						IL_3E:
						if (this.d.ContainsKey(A_0))
						{
							num = 8;
							continue;
						}
						IL_7A:
						result = false;
						num = 5;
					}
				}
				return result;
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00009830 File Offset: 0x00008830
			public bool a(byte A_0, ushort A_1, out global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> A_2)
			{
				bool result;
				for (;;)
				{
					A_2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>>();
					result = true;
					int num = 4;
					for (;;)
					{
						switch (num)
						{
						case 0:
							return result;
						case 1:
						{
							if (!this.d[A_0].c()[A_1].c())
							{
								num = 6;
								continue;
							}
							global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.c>.ValueCollection.Enumerator enumerator = this.d[A_0].c()[A_1].a().Values.GetEnumerator();
							num = 5;
							continue;
						}
						case 2:
							if (this.d[A_0].c().ContainsKey(A_1))
							{
								num = 7;
								continue;
							}
							goto IL_13E;
						case 3:
							num = 2;
							continue;
						case 4:
							if (this.d.ContainsKey(A_0))
							{
								num = 3;
								continue;
							}
							goto IL_13E;
						case 5:
							try
							{
								num = 7;
								for (;;)
								{
									global::CommunicationController.CRadioCodeplugController.a.c c;
									switch (num)
									{
									case 0:
										goto IL_120;
									case 1:
										goto IL_120;
									case 2:
										goto IL_9B;
									case 4:
										goto IL_12B;
									case 5:
										if (c.a() == null)
										{
											num = 6;
											continue;
										}
										A_2.Add(new global::System.Collections.Generic.KeyValuePair<ushort, byte[]>(c.b(), c.a()));
										num = 3;
										continue;
									case 6:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_9B;
										default:
											if (false)
											{
											}
											result = false;
											num = 1;
											continue;
										}
										break;
									}
									IL_93:
									num = 2;
									continue;
									goto IL_93;
									IL_9B:
									global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.c>.ValueCollection.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = 0;
										continue;
									}
									c = enumerator.Current;
									num = 5;
									continue;
									IL_120:
									num = 4;
								}
								IL_12B:
								return result;
							}
							finally
							{
								global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.c>.ValueCollection.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_13E;
						case 6:
							if (true)
							{
							}
							goto IL_13E;
						case 7:
							num = 1;
							continue;
						}
						break;
						IL_13E:
						result = false;
						num = 0;
					}
				}
				return result;
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x00009A48 File Offset: 0x00008A48
			public bool a(byte A_0, out global::Motorola.Common.Communication.CommonUtil.IshItemCollection A_1)
			{
				switch (0)
				{
				default:
				{
					bool flag;
					for (;;)
					{
						IL_2F:
						A_1 = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
						flag = true;
						for (;;)
						{
							IL_38:
							int num = 5;
							for (;;)
							{
								global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.e>.ValueCollection.Enumerator enumerator;
								switch (num)
								{
								case 0:
									try
									{
										num = 0;
										for (;;)
										{
											switch (num)
											{
											case 1:
											{
												if (!enumerator.MoveNext())
												{
													num = 9;
													continue;
												}
												global::CommunicationController.CRadioCodeplugController.a.e e = enumerator.Current;
												num = 8;
												continue;
											}
											case 2:
												goto IL_25A;
											case 3:
											{
												global::CommunicationController.CRadioCodeplugController.a.e e;
												if (!e.c())
												{
													num = 7;
													continue;
												}
												global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.c>.ValueCollection.Enumerator enumerator2 = e.a().Values.GetEnumerator();
												num = 5;
												continue;
											}
											case 4:
												goto IL_24E;
											case 5:
												try
												{
													num = 6;
													for (;;)
													{
														switch (num)
														{
														case 0:
															goto IL_18F;
														case 1:
															goto IL_19B;
														case 3:
														{
															global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.c>.ValueCollection.Enumerator enumerator2;
															if (!enumerator2.MoveNext())
															{
																num = 4;
																continue;
															}
															global::CommunicationController.CRadioCodeplugController.a.c c = enumerator2.Current;
															num = 5;
															continue;
														}
														case 4:
															goto IL_18F;
														case 5:
														{
															global::CommunicationController.CRadioCodeplugController.a.c c;
															if (c.a() == null)
															{
																num = 7;
																continue;
															}
															global::CommunicationController.CRadioCodeplugController.a.e e;
															A_1.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(A_0, e.b(), c.b()), new global::Motorola.Common.Communication.CommonUtil.IshItem(c.a().Length, c.a(), global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined));
															num = 2;
															continue;
														}
														case 7:
															flag = false;
															num = 0;
															continue;
														}
														IL_169:
														num = 3;
														continue;
														goto IL_169;
														IL_18F:
														num = 1;
													}
													IL_19B:;
												}
												finally
												{
													global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.c>.ValueCollection.Enumerator enumerator2;
													((global::System.IDisposable)enumerator2).Dispose();
												}
												break;
											case 6:
												num = 3;
												continue;
											case 7:
												flag = false;
												num = 4;
												continue;
											case 8:
												if (flag)
												{
													num = 6;
													continue;
												}
												goto IL_24E;
											case 9:
												goto IL_24E;
											}
											IL_1AB:
											num = 1;
											continue;
											goto IL_1AB;
											IL_24E:
											num = 2;
										}
										IL_25A:
										return flag;
									}
									finally
									{
										((global::System.IDisposable)enumerator).Dispose();
									}
									goto IL_26D;
								case 1:
									goto IL_2C7;
								case 2:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_38;
									default:
										if (false)
										{
										}
										num = 4;
										continue;
									}
									break;
								case 3:
									return flag;
								case 4:
									if (!this.d[A_0].b())
									{
										num = 1;
										continue;
									}
									goto IL_26D;
								case 5:
									if (this.d.ContainsKey(A_0))
									{
										num = 2;
										continue;
									}
									goto IL_2C7;
								}
								goto IL_2F;
								IL_26D:
								enumerator = this.d[A_0].c().Values.GetEnumerator();
								num = 0;
								continue;
								IL_2C7:
								if (true)
								{
								}
								flag = false;
								num = 3;
							}
						}
					}
					return flag;
				}
				}
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x00009D6C File Offset: 0x00008D6C
			public bool b(out global::CommunicationController.CRadioCodeplugController.a.f A_0)
			{
				bool result;
				for (;;)
				{
					A_0 = null;
					result = true;
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
							return result;
						case 1:
							return result;
						case 2:
							result = false;
							num = 0;
							continue;
						case 3:
							if (this.b != null)
							{
								A_0 = this.b;
								if (true)
								{
								}
								num = 1;
								continue;
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
								num = 2;
								continue;
							}
							break;
						}
						break;
					}
				}
				return result;
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x00009E00 File Offset: 0x00008E00
			public bool a(out global::CommunicationController.CRadioCodeplugController.a.f A_0)
			{
				bool result;
				for (;;)
				{
					A_0 = null;
					result = true;
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (true)
							{
							}
							if (this.c == null)
							{
								num = 2;
								continue;
							}
							A_0 = this.c;
							num = 1;
							continue;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_77;
							default:
								goto IL_6F;
							}
							break;
						case 2:
							goto IL_77;
						case 3:
							return result;
						}
						break;
						IL_77:
						result = false;
						num = 3;
					}
				}
				IL_6F:
				if (false)
				{
				}
				return result;
			}

			// Token: 0x060000C6 RID: 198 RVA: 0x00009E94 File Offset: 0x00008E94
			public bool a(string A_0, out global::System.Collections.Generic.Dictionary<string, uint> A_1)
			{
				bool result;
				for (;;)
				{
					IL_3C:
					A_1 = new global::System.Collections.Generic.Dictionary<string, uint>();
					result = true;
					if (true)
					{
					}
					int num = 5;
					for (;;)
					{
						global::System.Collections.Generic.Dictionary<string, global::CommunicationController.CRadioCodeplugController.a.d>.ValueCollection.Enumerator enumerator;
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
								goto IL_18E;
							case 1:
								return result;
							case 2:
								num = 3;
								continue;
							case 3:
								if (!this.a[A_0].b())
								{
									num = 0;
									continue;
								}
								goto IL_12D;
							case 4:
								try
								{
									num = 7;
									for (;;)
									{
										switch (num)
										{
										case 0:
										{
											global::CommunicationController.CRadioCodeplugController.a.d d;
											if (d.a() == -1)
											{
												num = 2;
												continue;
											}
											A_1.Add(d.c(), (uint)d.a());
											num = 1;
											continue;
										}
										case 2:
											result = false;
											num = 3;
											continue;
										case 3:
											goto IL_10F;
										case 4:
											goto IL_10F;
										case 5:
										{
											if (!enumerator.MoveNext())
											{
												num = 4;
												continue;
											}
											global::CommunicationController.CRadioCodeplugController.a.d d = enumerator.Current;
											num = 0;
											continue;
										}
										case 6:
											goto IL_11A;
										}
										IL_C2:
										num = 5;
										continue;
										goto IL_C2;
										IL_10F:
										num = 6;
									}
									IL_11A:
									return result;
								}
								finally
								{
									((global::System.IDisposable)enumerator).Dispose();
								}
								goto IL_12D;
							case 5:
								if (this.a.ContainsKey(A_0))
								{
									num = 2;
									continue;
								}
								goto IL_18E;
							}
							goto IL_3C;
							IL_18E:
							result = false;
							num = 1;
							continue;
						}
						IL_12D:
						enumerator = this.a[A_0].c().Values.GetEnumerator();
						num = 4;
					}
				}
				return result;
			}

			// Token: 0x060000C7 RID: 199 RVA: 0x0000A050 File Offset: 0x00009050
			public bool a(string A_0, out long A_1)
			{
				bool result;
				for (;;)
				{
					A_1 = 0L;
					result = true;
					int num = 8;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							string key;
							string key2;
							if (this.a[key].c().ContainsKey(key2))
							{
								num = 6;
								continue;
							}
							goto IL_123;
						}
						case 1:
							if (this.a.ContainsKey(A_0))
							{
								num = 5;
								continue;
							}
							goto IL_1EA;
						case 2:
							goto IL_123;
						case 3:
							num = 1;
							continue;
						case 4:
							if (this.a[A_0].d() == -1)
							{
								num = 14;
								continue;
							}
							A_1 = (long)this.a[A_0].d();
							num = 9;
							continue;
						case 5:
							if (true)
							{
							}
							num = 4;
							continue;
						case 6:
							num = 11;
							continue;
						case 7:
							goto IL_166;
						case 8:
						{
							if (A_0.EndsWith("/", global::System.StringComparison.Ordinal))
							{
								num = 3;
								continue;
							}
							string key = A_0.Substring(0, A_0.LastIndexOf('/') + 1);
							string key2 = A_0.Substring(A_0.LastIndexOf('/') + 1);
							num = 13;
							continue;
						}
						case 9:
							return result;
						case 10:
							return result;
						case 11:
						{
							string key;
							string key2;
							if (this.a[key].c()[key2].a() == -1)
							{
								num = 2;
								continue;
							}
							A_1 = (long)this.a[key].c()[key2].a();
							num = 15;
							continue;
						}
						case 12:
							return result;
						case 13:
						{
							string key;
							if (this.a.ContainsKey(key))
							{
								num = 7;
								continue;
							}
							goto IL_123;
						}
						case 14:
							goto IL_1EA;
						case 15:
							return result;
						}
						break;
						IL_123:
						result = false;
						num = 10;
						continue;
						IL_166:
						num = 0;
						continue;
						IL_1EA:
						result = false;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_166;
						default:
							if (false)
							{
							}
							num = 12;
							break;
						}
					}
				}
				return result;
			}

			// Token: 0x060000C8 RID: 200 RVA: 0x0000A280 File Offset: 0x00009280
			public bool a(string A_0, out byte[] A_1)
			{
				bool result;
				for (;;)
				{
					IL_44:
					if (true)
					{
					}
					A_1 = null;
					result = true;
					string key = A_0.Substring(0, A_0.LastIndexOf('/') + 1);
					string key2 = A_0.Substring(A_0.LastIndexOf('/') + 1);
					int num = 1;
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_44;
						default:
							if (false)
							{
							}
							switch (num)
							{
							case 0:
								num = 4;
								continue;
							case 1:
								if (this.a.ContainsKey(key))
								{
									num = 0;
									continue;
								}
								goto IL_A1;
							case 2:
								goto IL_A1;
							case 3:
								if (this.a[key].c()[key2].b() == null)
								{
									num = 2;
									continue;
								}
								A_1 = this.a[key].c()[key2].b();
								num = 5;
								continue;
							case 4:
								if (this.a[key].c().ContainsKey(key2))
								{
									num = 6;
									continue;
								}
								goto IL_A1;
							case 5:
								return result;
							case 6:
								num = 3;
								continue;
							case 7:
								return result;
							}
							goto IL_44;
							IL_A1:
							result = false;
							num = 7;
							break;
						}
					}
				}
				return result;
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x0000A3D4 File Offset: 0x000093D4
			public void a(global::Motorola.Common.Communication.Pba.PbaObject A_0)
			{
				switch (0)
				{
				default:
					for (;;)
					{
						this.d.Clear();
						this.b = new global::CommunicationController.CRadioCodeplugController.a.f();
						this.a.Clear();
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator = A_0.CodeplugData.DataPartitions.GetEnumerator();
						int num = 1;
						for (;;)
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet>.Enumerator enumerator2;
							switch (num)
							{
							case 0:
								goto IL_10F;
							case 1:
								goto IL_603;
							case 2:
								try
								{
									num = 1;
									for (;;)
									{
										switch (num)
										{
										case 0:
											num = 4;
											continue;
										case 1:
											if (true)
											{
											}
											break;
										case 2:
										{
											if (!enumerator2.MoveNext())
											{
												num = 0;
												continue;
											}
											global::Motorola.Common.Communication.Pba.FileSet fileSet = enumerator2.Current;
											global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator3 = fileSet.FileItemsList.GetEnumerator();
											num = 3;
											continue;
										}
										case 3:
											try
											{
												num = 18;
												for (;;)
												{
													global::Motorola.Common.Communication.Pba.FileItem fileItem;
													string text;
													string text2;
													global::CommunicationController.CRadioCodeplugController.a.d d;
													switch (num)
													{
													case 0:
														num = 2;
														continue;
													case 1:
														num = 14;
														continue;
													case 2:
														switch ((1 == 1) ? 1 : 0)
														{
														case 0:
														case 2:
															goto IL_47C;
														default:
															if (false)
															{
															}
															if (fileItem.FileContent.Length == fileItem.FileSize)
															{
																num = 19;
																continue;
															}
															goto IL_461;
														}
														break;
													case 3:
													{
														global::CommunicationController.CRadioCodeplugController.a.g g = new global::CommunicationController.CRadioCodeplugController.a.g();
														g.a(fileItem.FilePath);
														g.a(true);
														g.a(fileItem.FileSize);
														this.a.Add(fileItem.FilePath, g);
														num = 9;
														continue;
													}
													case 5:
														if (fileItem.FilePath.EndsWith("/", global::System.StringComparison.Ordinal))
														{
															num = 1;
															continue;
														}
														text = fileItem.FilePath.Substring(0, fileItem.FilePath.LastIndexOf('/') + 1);
														text2 = fileItem.FilePath.Substring(fileItem.FilePath.LastIndexOf('/') + 1);
														num = 7;
														continue;
													case 6:
														num = 15;
														continue;
													case 7:
														if (!this.a.ContainsKey(text))
														{
															num = 12;
															continue;
														}
														this.a[text].a(true);
														num = 13;
														continue;
													case 10:
													{
														global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator3;
														if (!enumerator3.MoveNext())
														{
															num = 6;
															continue;
														}
														fileItem = enumerator3.Current;
														num = 5;
														continue;
													}
													case 11:
														if (fileItem.FileContent != null)
														{
															num = 0;
															continue;
														}
														goto IL_461;
													case 12:
													{
														global::CommunicationController.CRadioCodeplugController.a.g g2 = new global::CommunicationController.CRadioCodeplugController.a.g();
														g2.a(text);
														g2.a(true);
														g2.a(-1);
														this.a.Add(text, g2);
														num = 16;
														continue;
													}
													case 13:
														goto IL_396;
													case 14:
														if (!this.a.ContainsKey(fileItem.FilePath))
														{
															num = 3;
															continue;
														}
														this.a[fileItem.FilePath].a(fileItem.FileSize);
														num = 4;
														continue;
													case 15:
														goto IL_5AE;
													case 16:
														goto IL_396;
													case 17:
														goto IL_461;
													case 19:
														d.a((byte[])fileItem.FileContent.Clone());
														num = 17;
														continue;
													}
													goto IL_2D0;
													IL_396:
													d = new global::CommunicationController.CRadioCodeplugController.a.d();
													d.a(text2);
													d.a(fileItem.FileSize);
													num = 11;
													continue;
													IL_47C:
													num = 8;
													continue;
													IL_461:
													this.a[text].c().Add(text2, d);
													goto IL_47C;
													IL_52E:
													num = 10;
													continue;
													IL_2D0:
													goto IL_52E;
												}
												IL_5AE:;
											}
											finally
											{
												global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator3;
												((global::System.IDisposable)enumerator3).Dispose();
											}
											break;
										case 4:
											goto IL_5F0;
										}
										IL_5BE:
										num = 2;
										continue;
										goto IL_5BE;
									}
									IL_5F0:
									goto IL_90;
								}
								finally
								{
									((global::System.IDisposable)enumerator2).Dispose();
								}
								goto Block_5;
								IL_90:
								num = 9;
								continue;
							case 3:
								this.c = new global::CommunicationController.CRadioCodeplugController.a.f();
								global::CommunicationController.CRadioCodeplugController.a.a(A_0.TTSLanguagePackData, ref this.c);
								num = 4;
								continue;
							case 4:
								goto IL_C9;
							case 5:
								return;
							case 6:
							{
								global::CommunicationController.CRadioCodeplugController.a.g g3 = new global::CommunicationController.CRadioCodeplugController.a.g();
								g3.a("/opt/pcr/rel/data/va/");
								g3.a(true);
								g3.a(0);
								this.a.Add("/opt/pcr/rel/data/va/", g3);
								num = 5;
								continue;
							}
							case 7:
							{
								global::CommunicationController.CRadioCodeplugController.a.g g4 = new global::CommunicationController.CRadioCodeplugController.a.g();
								g4.a("/opt/pcr/rel/data/mmi/");
								g4.a(true);
								g4.a(0);
								this.a.Add("/opt/pcr/rel/data/mmi/", g4);
								num = 0;
								continue;
							}
							case 8:
								if (A_0.LanguagePackData != null)
								{
									num = 12;
									continue;
								}
								goto IL_819;
							case 9:
								if (!this.a.ContainsKey("/opt/pcr/rel/data/mmi/"))
								{
									num = 7;
									continue;
								}
								goto IL_10F;
							case 10:
								if (A_0.TTSLanguagePackData != null)
								{
									num = 3;
									continue;
								}
								goto IL_C9;
							case 11:
								goto IL_819;
							case 12:
								global::CommunicationController.CRadioCodeplugController.a.b(A_0.LanguagePackData, ref this.b);
								num = 11;
								continue;
							case 13:
								if (!this.a.ContainsKey("/opt/pcr/rel/data/va/"))
								{
									num = 6;
									continue;
								}
								return;
							}
							break;
							IL_C9:
							enumerator2 = A_0.FileSetList.GetEnumerator();
							num = 2;
							continue;
							Block_5:
							try
							{
								IL_603:
								num = 3;
								for (;;)
								{
									switch (num)
									{
									case 0:
									{
										global::CommunicationController.CRadioCodeplugController.a.h h;
										try
										{
											num = 4;
											for (;;)
											{
												global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
												switch (num)
												{
												case 0:
												{
													global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator4;
													if (!enumerator4.MoveNext())
													{
														num = 6;
														continue;
													}
													dataBlock = enumerator4.Current;
													num = 5;
													continue;
												}
												case 1:
												{
													global::CommunicationController.CRadioCodeplugController.a.e e = new global::CommunicationController.CRadioCodeplugController.a.e();
													e.a(dataBlock.BlockType);
													e.a(true);
													h.c().Add(dataBlock.BlockType, e);
													num = 7;
													continue;
												}
												case 2:
													goto IL_762;
												case 5:
													if (!h.c().ContainsKey(dataBlock.BlockType))
													{
														num = 1;
														continue;
													}
													goto IL_6F7;
												case 6:
													num = 2;
													continue;
												case 7:
													goto IL_6F7;
												}
												IL_6D1:
												num = 0;
												continue;
												goto IL_6D1;
												IL_6F7:
												global::CommunicationController.CRadioCodeplugController.a.c c = new global::CommunicationController.CRadioCodeplugController.a.c();
												c.a(dataBlock.BlockID);
												c.a((byte[])dataBlock.PacketValue.Clone());
												h.c()[dataBlock.BlockType].a().Add(dataBlock.BlockID, c);
												num = 3;
											}
											IL_762:
											goto IL_7D7;
										}
										finally
										{
											global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator4;
											((global::System.IDisposable)enumerator4).Dispose();
										}
										break;
										IL_7D7:
										global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
										this.d.Add(dataPartition.PartitionID, h);
										num = 4;
										continue;
									}
									case 1:
										num = 2;
										continue;
									case 2:
										goto IL_806;
									case 5:
									{
										if (!enumerator.MoveNext())
										{
											num = 1;
											continue;
										}
										global::Motorola.Common.Communication.Pba.DataPartition dataPartition = enumerator.Current;
										global::CommunicationController.CRadioCodeplugController.a.h h = new global::CommunicationController.CRadioCodeplugController.a.h();
										h.a(dataPartition.PartitionID);
										h.a(true);
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator4 = dataPartition.DataBlocks.GetEnumerator();
										num = 0;
										continue;
									}
									}
									IL_772:
									num = 5;
									continue;
									goto IL_772;
								}
								IL_806:
								goto IL_E7;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_819;
							IL_E7:
							num = 8;
							continue;
							IL_10F:
							num = 13;
							continue;
							IL_819:
							num = 10;
						}
					}
					return;
				}
			}

			// Token: 0x060000CA RID: 202 RVA: 0x0000AC88 File Offset: 0x00009C88
			public void a(string A_0)
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
				global::Motorola.Common.Communication.Pba.PbaObject a_ = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFrom(A_0);
				this.a(a_);
			}

			// Token: 0x060000CB RID: 203 RVA: 0x0000ACD4 File Offset: 0x00009CD4
			public void a(byte A_0, global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock> A_1, bool A_2, bool A_3)
			{
				switch (0)
				{
				default:
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_E5:
						goto IL_41F;
					default:
						if (false)
						{
						}
						goto IL_5D;
					}
					int num;
					global::CommunicationController.CRadioCodeplugController.a.h h2;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator;
					for (;;)
					{
						IL_36:
						global::CommunicationController.CRadioCodeplugController.a.h h;
						bool a_;
						switch (num)
						{
						case 0:
							goto IL_41A;
						case 1:
							if (A_2)
							{
								num = 3;
								continue;
							}
							goto IL_41F;
						case 2:
							h = h2;
							a_ = A_2;
							goto IL_3FC;
						case 3:
							h2.a(true);
							num = 5;
							continue;
						case 4:
							h2 = new global::CommunicationController.CRadioCodeplugController.a.h();
							h2.a(A_0);
							num = 2;
							continue;
						case 5:
							goto IL_E5;
						case 6:
							try
							{
								num = 4;
								for (;;)
								{
									global::CommunicationController.CRadioCodeplugController.a.c c;
									global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
									switch (num)
									{
									case 0:
										goto IL_3EC;
									case 1:
										c = new global::CommunicationController.CRadioCodeplugController.a.c();
										c.a(dataBlock.BlockID);
										num = 13;
										continue;
									case 2:
										goto IL_2E1;
									case 3:
										h2.c()[dataBlock.BlockType].a()[dataBlock.BlockID].a((byte[])dataBlock.PacketValue.Clone());
										num = 11;
										continue;
									case 5:
									{
										global::CommunicationController.CRadioCodeplugController.a.e e;
										e.a(A_2 || A_3);
										h2.c().Add(dataBlock.BlockType, e);
										num = 10;
										continue;
									}
									case 6:
										goto IL_24E;
									case 7:
										c.a((byte[])dataBlock.PacketValue.Clone());
										num = 2;
										continue;
									case 8:
										if (!h2.c()[dataBlock.BlockType].a().ContainsKey(dataBlock.BlockID))
										{
											num = 1;
											continue;
										}
										num = 16;
										continue;
									case 9:
										if (!A_2)
										{
											num = 14;
											continue;
										}
										goto IL_229;
									case 10:
										goto IL_24E;
									case 12:
										if (h2.c()[dataBlock.BlockType].a()[dataBlock.BlockID].a() == null)
										{
											num = 3;
											continue;
										}
										break;
									case 13:
										if (!A_2)
										{
											num = 7;
											continue;
										}
										goto IL_2E1;
									case 14:
										num = 17;
										continue;
									case 15:
										num = 0;
										continue;
									case 16:
										if (!A_2)
										{
											num = 22;
											continue;
										}
										break;
									case 17:
										if (A_3)
										{
											num = 20;
											continue;
										}
										goto IL_24E;
									case 18:
										if (!h2.c().ContainsKey(dataBlock.BlockType))
										{
											num = 23;
											continue;
										}
										num = 9;
										continue;
									case 19:
										if (!enumerator.MoveNext())
										{
											num = 15;
											continue;
										}
										dataBlock = enumerator.Current;
										num = 18;
										continue;
									case 20:
										goto IL_229;
									case 22:
										num = 12;
										continue;
									case 23:
									{
										global::CommunicationController.CRadioCodeplugController.a.e e = new global::CommunicationController.CRadioCodeplugController.a.e();
										e.a(dataBlock.BlockType);
										num = 5;
										continue;
									}
									}
									goto IL_162;
									IL_229:
									h2.c()[dataBlock.BlockType].a(true);
									num = 6;
									continue;
									IL_24E:
									num = 8;
									continue;
									IL_2E1:
									h2.c()[dataBlock.BlockType].a().Add(dataBlock.BlockID, c);
									num = 21;
									continue;
									IL_3BA:
									num = 19;
									continue;
									IL_162:
									goto IL_3BA;
								}
								IL_3EC:
								return;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_3FC;
						case 7:
							if (true)
							{
							}
							if (!this.d.ContainsKey(A_0))
							{
								num = 4;
								continue;
							}
							h2 = this.d[A_0];
							num = 1;
							continue;
						}
						goto IL_5D;
						IL_3FC:
						h.a(a_);
						this.d.Add(A_0, h2);
						num = 0;
					}
					IL_41A:
					goto IL_41F;
					IL_5D:
					h2 = null;
					num = 7;
					goto IL_36;
					IL_41F:
					enumerator = A_1.GetEnumerator();
					num = 6;
					goto IL_36;
				}
				}
			}

			// Token: 0x060000CC RID: 204 RVA: 0x0000B138 File Offset: 0x0000A138
			public void b(global::Motorola.Common.Communication.Pba.LanguagePackData A_0)
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
				this.b = new global::CommunicationController.CRadioCodeplugController.a.f();
				global::CommunicationController.CRadioCodeplugController.a.b(A_0, ref this.b);
			}

			// Token: 0x060000CD RID: 205 RVA: 0x0000B18C File Offset: 0x0000A18C
			private static void b(global::Motorola.Common.Communication.Pba.LanguagePackData A_0, ref global::CommunicationController.CRadioCodeplugController.a.f A_1)
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
					if (true)
					{
					}
					A_1.a(A_0.AvailableSpace);
					using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator = A_0.LanguagePacks.GetEnumerator())
					{
						int num = 4;
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_126;
							case 2:
							{
								global::CommunicationController.CRadioCodeplugController.a.b b = new global::CommunicationController.CRadioCodeplugController.a.b();
								global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo;
								b.b(pcrLanguagePackInfo.MajorVersion);
								b.a(pcrLanguagePackInfo.MinorVersion);
								b.c(pcrLanguagePackInfo.Name);
								b.d(pcrLanguagePackInfo.PackID);
								b.c(pcrLanguagePackInfo.Size);
								A_1.b().Add(pcrLanguagePackInfo.PackID, b);
								num = 1;
								continue;
							}
							case 3:
								num = 0;
								continue;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = 3;
									continue;
								}
								global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo = (global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)enumerator.Current;
								num = 6;
								continue;
							}
							case 6:
							{
								global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo pcrLanguagePackInfo;
								if (!global::CommunicationController.CRadioCodeplugController.IsDefaultEnUsLanguagePack(pcrLanguagePackInfo))
								{
									num = 2;
									continue;
								}
								break;
							}
							}
							IL_9E:
							num = 5;
							continue;
							goto IL_9E;
						}
						IL_126:;
					}
					break;
				}
			}

			// Token: 0x060000CE RID: 206 RVA: 0x0000B2E0 File Offset: 0x0000A2E0
			public void a(global::Motorola.Common.Communication.Pba.LanguagePackData A_0)
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
				this.c = new global::CommunicationController.CRadioCodeplugController.a.f();
				global::CommunicationController.CRadioCodeplugController.a.a(A_0, ref this.c);
			}

			// Token: 0x060000CF RID: 207 RVA: 0x0000B334 File Offset: 0x0000A334
			private static void a(global::Motorola.Common.Communication.Pba.LanguagePackData A_0, ref global::CommunicationController.CRadioCodeplugController.a.f A_1)
			{
				A_1.a(A_0.AvailableSpace);
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator = A_0.LanguagePacks.GetEnumerator())
				{
					int num = 7;
					for (;;)
					{
						global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo;
						global::CommunicationController.CRadioCodeplugController.a.a a;
						switch (num)
						{
						case 1:
							if (!enumerator.MoveNext())
							{
								num = 3;
								continue;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_143;
							default:
								if (false)
								{
								}
								ttslanguagePackInfo = (global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo)enumerator.Current;
								a = new global::CommunicationController.CRadioCodeplugController.a.a();
								a.b(ttslanguagePackInfo.MajorVersion);
								a.a(ttslanguagePackInfo.MinorVersion);
								a.c(ttslanguagePackInfo.Name);
								a.d(ttslanguagePackInfo.PackID);
								a.c(ttslanguagePackInfo.Size);
								a.b(ttslanguagePackInfo.LanguageCode);
								a.a(ttslanguagePackInfo.SpeakerName);
								a.a(ttslanguagePackInfo.VoiceGender);
								num = 4;
								continue;
							}
							break;
						case 2:
							goto IL_143;
						case 3:
							num = 5;
							continue;
						case 4:
							if (a.h() == null)
							{
								num = 6;
								continue;
							}
							goto IL_145;
						case 5:
							goto IL_170;
						case 6:
							a.d(string.Empty);
							num = 2;
							continue;
						}
						IL_109:
						num = 1;
						continue;
						goto IL_109;
						IL_145:
						A_1.b().Add(ttslanguagePackInfo.PackID, a);
						num = 0;
						continue;
						IL_143:
						goto IL_145;
					}
					IL_170:;
				}
				if (true)
				{
				}
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x0000B4E8 File Offset: 0x0000A4E8
			public void a(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> A_0, bool A_1)
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
					switch (0)
					{
					default:
						using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>.Enumerator enumerator = A_0.GetEnumerator())
						{
							int num = 6;
							for (;;)
							{
								string text;
								string text2;
								global::CommunicationController.CRadioCodeplugController.a.d d;
								switch (num)
								{
								case 0:
								{
									global::CommunicationController.CRadioCodeplugController.a.g g;
									g.a(A_1);
									g.a(-1);
									this.a.Add(text, g);
									num = 12;
									continue;
								}
								case 1:
									num = 3;
									continue;
								case 3:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									if (!this.a.ContainsKey(fileItem.FilePath))
									{
										num = 17;
										continue;
									}
									num = 11;
									continue;
								}
								case 4:
									if (this.a[text].c()[text2].b() == null)
									{
										num = 13;
										continue;
									}
									break;
								case 5:
									if (!this.a[text].c().ContainsKey(text2))
									{
										num = 29;
										continue;
									}
									num = 4;
									continue;
								case 7:
									if (!this.a.ContainsKey(text))
									{
										num = 14;
										continue;
									}
									this.a[text].a(true);
									num = 15;
									continue;
								case 8:
									goto IL_4E9;
								case 9:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									if (fileItem.FileContent != null)
									{
										num = 28;
										continue;
									}
									goto IL_108;
								}
								case 11:
									if (A_1)
									{
										num = 30;
										continue;
									}
									goto IL_3C4;
								case 12:
									goto IL_217;
								case 13:
									num = 19;
									continue;
								case 14:
								{
									global::CommunicationController.CRadioCodeplugController.a.g g = new global::CommunicationController.CRadioCodeplugController.a.g();
									g.a(text);
									num = 0;
									continue;
								}
								case 15:
									goto IL_217;
								case 16:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									this.a[text].c()[text2].a((byte[])fileItem.FileContent.Clone());
									num = 21;
									continue;
								}
								case 17:
								{
									global::CommunicationController.CRadioCodeplugController.a.g g2 = new global::CommunicationController.CRadioCodeplugController.a.g();
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									g2.a(fileItem.FilePath);
									num = 27;
									continue;
								}
								case 19:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									if (fileItem.FileContent != null)
									{
										num = 16;
										continue;
									}
									break;
								}
								case 20:
									num = 8;
									continue;
								case 22:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									if (fileItem.FilePath.EndsWith("/", global::System.StringComparison.Ordinal))
									{
										num = 1;
										continue;
									}
									text = fileItem.FilePath.Substring(0, fileItem.FilePath.LastIndexOf('/') + 1);
									text2 = fileItem.FilePath.Substring(fileItem.FilePath.LastIndexOf('/') + 1);
									num = 7;
									continue;
								}
								case 23:
									goto IL_3C4;
								case 24:
									goto IL_108;
								case 25:
								{
									if (!enumerator.MoveNext())
									{
										num = 20;
										continue;
									}
									global::Motorola.Common.Communication.Pba.FileItem fileItem = enumerator.Current;
									num = 22;
									continue;
								}
								case 26:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									if (this.a[fileItem.FilePath].d() == -1)
									{
										num = 31;
										continue;
									}
									break;
								}
								case 27:
								{
									global::CommunicationController.CRadioCodeplugController.a.g g2;
									g2.a(A_1);
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									g2.a(fileItem.FileSize);
									this.a.Add(fileItem.FilePath, g2);
									num = 18;
									continue;
								}
								case 28:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									d.a((byte[])fileItem.FileContent.Clone());
									num = 24;
									continue;
								}
								case 29:
								{
									d = new global::CommunicationController.CRadioCodeplugController.a.d();
									d.a(text2);
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									d.a(fileItem.FileSize);
									num = 9;
									continue;
								}
								case 30:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									this.a[fileItem.FilePath].a(true);
									num = 23;
									continue;
								}
								case 31:
								{
									global::Motorola.Common.Communication.Pba.FileItem fileItem;
									this.a[fileItem.FilePath].a(fileItem.FileSize);
									num = 2;
									continue;
								}
								}
								goto IL_DB;
								IL_108:
								this.a[text].c().Add(text2, d);
								num = 10;
								continue;
								IL_12F:
								num = 25;
								continue;
								IL_DB:
								goto IL_12F;
								IL_217:
								num = 5;
								continue;
								IL_3C4:
								num = 26;
							}
							IL_4E9:;
						}
						break;
					}
					break;
				}
			}

			// Token: 0x0400004E RID: 78
			private global::System.Collections.Generic.Dictionary<string, global::CommunicationController.CRadioCodeplugController.a.g> a;

			// Token: 0x0400004F RID: 79
			private global::CommunicationController.CRadioCodeplugController.a.f b;

			// Token: 0x04000050 RID: 80
			private global::CommunicationController.CRadioCodeplugController.a.f c;

			// Token: 0x04000051 RID: 81
			private global::System.Collections.Generic.Dictionary<byte, global::CommunicationController.CRadioCodeplugController.a.h> d;

			// Token: 0x02000018 RID: 24
			internal class d
			{
				// Token: 0x060000D1 RID: 209 RVA: 0x0000BA0C File Offset: 0x0000AA0C
				public string c()
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

				// Token: 0x060000D2 RID: 210 RVA: 0x0000BA50 File Offset: 0x0000AA50
				public void a(string A_0)
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
					this.a = A_0;
				}

				// Token: 0x060000D3 RID: 211 RVA: 0x0000BA94 File Offset: 0x0000AA94
				public int a()
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
					return this.b;
				}

				// Token: 0x060000D4 RID: 212 RVA: 0x0000BAD8 File Offset: 0x0000AAD8
				public void a(int A_0)
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
					this.b = A_0;
				}

				// Token: 0x060000D5 RID: 213 RVA: 0x0000BB1C File Offset: 0x0000AB1C
				public byte[] b()
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
					return this.c;
				}

				// Token: 0x060000D6 RID: 214 RVA: 0x0000BB60 File Offset: 0x0000AB60
				public void a(byte[] A_0)
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
					this.c = A_0;
				}

				// Token: 0x060000D7 RID: 215 RVA: 0x0000BBA4 File Offset: 0x0000ABA4
				public d()
				{
					this.a = string.Empty;
					this.b = -1;
					this.c = null;
				}

				// Token: 0x04000052 RID: 82
				private string a;

				// Token: 0x04000053 RID: 83
				private int b;

				// Token: 0x04000054 RID: 84
				private byte[] c;
			}

			// Token: 0x02000019 RID: 25
			internal class g
			{
				// Token: 0x060000D8 RID: 216 RVA: 0x0000BBD0 File Offset: 0x0000ABD0
				public string a()
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

				// Token: 0x060000D9 RID: 217 RVA: 0x0000BC14 File Offset: 0x0000AC14
				public void a(string A_0)
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
					this.a = A_0;
				}

				// Token: 0x060000DA RID: 218 RVA: 0x0000BC58 File Offset: 0x0000AC58
				public int d()
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
					return this.b;
				}

				// Token: 0x060000DB RID: 219 RVA: 0x0000BC9C File Offset: 0x0000AC9C
				public void a(int A_0)
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
					this.b = A_0;
				}

				// Token: 0x060000DC RID: 220 RVA: 0x0000BCE0 File Offset: 0x0000ACE0
				public global::System.Collections.Generic.Dictionary<string, global::CommunicationController.CRadioCodeplugController.a.d> c()
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
					return this.c;
				}

				// Token: 0x060000DD RID: 221 RVA: 0x0000BD24 File Offset: 0x0000AD24
				public bool b()
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
					return this.d;
				}

				// Token: 0x060000DE RID: 222 RVA: 0x0000BD68 File Offset: 0x0000AD68
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
					this.d = A_0;
				}

				// Token: 0x060000DF RID: 223 RVA: 0x0000BDAC File Offset: 0x0000ADAC
				public g()
				{
					this.a = string.Empty;
					this.b = -1;
					this.c = new global::System.Collections.Generic.Dictionary<string, global::CommunicationController.CRadioCodeplugController.a.d>();
					this.d = false;
				}

				// Token: 0x04000055 RID: 85
				private string a;

				// Token: 0x04000056 RID: 86
				private int b;

				// Token: 0x04000057 RID: 87
				private global::System.Collections.Generic.Dictionary<string, global::CommunicationController.CRadioCodeplugController.a.d> c;

				// Token: 0x04000058 RID: 88
				private bool d;
			}

			// Token: 0x0200001A RID: 26
			internal class c
			{
				// Token: 0x060000E0 RID: 224 RVA: 0x0000BDE4 File Offset: 0x0000ADE4
				public ushort b()
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

				// Token: 0x060000E1 RID: 225 RVA: 0x0000BE28 File Offset: 0x0000AE28
				public void a(ushort A_0)
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
					this.a = A_0;
				}

				// Token: 0x060000E2 RID: 226 RVA: 0x0000BE6C File Offset: 0x0000AE6C
				public byte[] a()
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
					return this.b;
				}

				// Token: 0x060000E3 RID: 227 RVA: 0x0000BEB0 File Offset: 0x0000AEB0
				public void a(byte[] A_0)
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
					this.b = A_0;
				}

				// Token: 0x060000E4 RID: 228 RVA: 0x0000BEF4 File Offset: 0x0000AEF4
				public c()
				{
					this.a = 0;
					this.b = null;
				}

				// Token: 0x04000059 RID: 89
				private ushort a;

				// Token: 0x0400005A RID: 90
				private byte[] b;
			}

			// Token: 0x0200001B RID: 27
			internal class e
			{
				// Token: 0x060000E5 RID: 229 RVA: 0x0000BF18 File Offset: 0x0000AF18
				public ushort b()
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

				// Token: 0x060000E6 RID: 230 RVA: 0x0000BF5C File Offset: 0x0000AF5C
				public void a(ushort A_0)
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
					this.a = A_0;
				}

				// Token: 0x060000E7 RID: 231 RVA: 0x0000BFA0 File Offset: 0x0000AFA0
				public global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.c> a()
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
					return this.b;
				}

				// Token: 0x060000E8 RID: 232 RVA: 0x0000BFE4 File Offset: 0x0000AFE4
				public bool c()
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

				// Token: 0x060000E9 RID: 233 RVA: 0x0000C028 File Offset: 0x0000B028
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
					this.c = A_0;
				}

				// Token: 0x060000EA RID: 234 RVA: 0x0000C06C File Offset: 0x0000B06C
				public e()
				{
					this.a = 0;
					this.b = new global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.c>();
					this.c = false;
				}

				// Token: 0x0400005B RID: 91
				private ushort a;

				// Token: 0x0400005C RID: 92
				private global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.c> b;

				// Token: 0x0400005D RID: 93
				private bool c;
			}

			// Token: 0x0200001C RID: 28
			internal class h
			{
				// Token: 0x060000EB RID: 235 RVA: 0x0000C098 File Offset: 0x0000B098
				public byte a()
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

				// Token: 0x060000EC RID: 236 RVA: 0x0000C0DC File Offset: 0x0000B0DC
				public void a(byte A_0)
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
					this.a = A_0;
				}

				// Token: 0x060000ED RID: 237 RVA: 0x0000C120 File Offset: 0x0000B120
				public global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.e> c()
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
					return this.b;
				}

				// Token: 0x060000EE RID: 238 RVA: 0x0000C164 File Offset: 0x0000B164
				public bool b()
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

				// Token: 0x060000EF RID: 239 RVA: 0x0000C1A8 File Offset: 0x0000B1A8
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
					this.c = A_0;
				}

				// Token: 0x060000F0 RID: 240 RVA: 0x0000C1EC File Offset: 0x0000B1EC
				public h()
				{
					this.a = 0;
					this.b = new global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.e>();
					this.c = false;
				}

				// Token: 0x0400005E RID: 94
				private byte a;

				// Token: 0x0400005F RID: 95
				private global::System.Collections.Generic.Dictionary<ushort, global::CommunicationController.CRadioCodeplugController.a.e> b;

				// Token: 0x04000060 RID: 96
				private bool c;
			}

			// Token: 0x0200001D RID: 29
			internal class b
			{
				// Token: 0x060000F1 RID: 241 RVA: 0x0000C218 File Offset: 0x0000B218
				public uint d()
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

				// Token: 0x060000F2 RID: 242 RVA: 0x0000C25C File Offset: 0x0000B25C
				public void b(uint A_0)
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
					this.a = A_0;
				}

				// Token: 0x060000F3 RID: 243 RVA: 0x0000C2A0 File Offset: 0x0000B2A0
				public uint f()
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
					return this.b;
				}

				// Token: 0x060000F4 RID: 244 RVA: 0x0000C2E4 File Offset: 0x0000B2E4
				public void a(uint A_0)
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
					this.b = A_0;
				}

				// Token: 0x060000F5 RID: 245 RVA: 0x0000C328 File Offset: 0x0000B328
				public uint g()
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
					return this.c;
				}

				// Token: 0x060000F6 RID: 246 RVA: 0x0000C36C File Offset: 0x0000B36C
				public void c(uint A_0)
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
					this.c = A_0;
				}

				// Token: 0x060000F7 RID: 247 RVA: 0x0000C3B0 File Offset: 0x0000B3B0
				public string e()
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
					return this.d;
				}

				// Token: 0x060000F8 RID: 248 RVA: 0x0000C3F4 File Offset: 0x0000B3F4
				public void c(string A_0)
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
					this.d = A_0;
				}

				// Token: 0x060000F9 RID: 249 RVA: 0x0000C438 File Offset: 0x0000B438
				public string h()
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
					return this.e;
				}

				// Token: 0x060000FA RID: 250 RVA: 0x0000C47C File Offset: 0x0000B47C
				public void d(string A_0)
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
					this.e = A_0;
				}

				// Token: 0x060000FB RID: 251 RVA: 0x0000C4C0 File Offset: 0x0000B4C0
				public b()
				{
					this.a = 0U;
					this.b = 0U;
					this.c = 0U;
					this.d = string.Empty;
					this.e = string.Empty;
				}

				// Token: 0x04000061 RID: 97
				private uint a;

				// Token: 0x04000062 RID: 98
				private uint b;

				// Token: 0x04000063 RID: 99
				private uint c;

				// Token: 0x04000064 RID: 100
				private string d;

				// Token: 0x04000065 RID: 101
				private string e;
			}

			// Token: 0x0200001E RID: 30
			internal class a : global::CommunicationController.CRadioCodeplugController.a.b
			{
				// Token: 0x060000FC RID: 252 RVA: 0x0000C500 File Offset: 0x0000B500
				public string b()
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

				// Token: 0x060000FD RID: 253 RVA: 0x0000C544 File Offset: 0x0000B544
				public void b(string A_0)
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
					this.a = A_0;
				}

				// Token: 0x060000FE RID: 254 RVA: 0x0000C588 File Offset: 0x0000B588
				public byte a()
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
					return this.b;
				}

				// Token: 0x060000FF RID: 255 RVA: 0x0000C5CC File Offset: 0x0000B5CC
				public void a(byte A_0)
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
					this.b = A_0;
				}

				// Token: 0x06000100 RID: 256 RVA: 0x0000C610 File Offset: 0x0000B610
				public string c()
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
					return this.c;
				}

				// Token: 0x06000101 RID: 257 RVA: 0x0000C654 File Offset: 0x0000B654
				public void a(string A_0)
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
					this.c = A_0;
				}

				// Token: 0x06000102 RID: 258 RVA: 0x0000C698 File Offset: 0x0000B698
				public a()
				{
					this.a = string.Empty;
					this.b = 0;
					this.c = string.Empty;
				}

				// Token: 0x04000066 RID: 102
				private string a;

				// Token: 0x04000067 RID: 103
				private byte b;

				// Token: 0x04000068 RID: 104
				private string c;
			}

			// Token: 0x0200001F RID: 31
			internal class f
			{
				// Token: 0x06000103 RID: 259 RVA: 0x0000C6C8 File Offset: 0x0000B6C8
				public uint a()
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

				// Token: 0x06000104 RID: 260 RVA: 0x0000C70C File Offset: 0x0000B70C
				public void a(uint A_0)
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
					this.a = A_0;
				}

				// Token: 0x06000105 RID: 261 RVA: 0x0000C750 File Offset: 0x0000B750
				public global::System.Collections.Generic.Dictionary<string, global::CommunicationController.CRadioCodeplugController.a.b> b()
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
					return this.b;
				}

				// Token: 0x06000106 RID: 262 RVA: 0x0000C794 File Offset: 0x0000B794
				public f()
				{
					this.a = 0U;
					this.b = new global::System.Collections.Generic.Dictionary<string, global::CommunicationController.CRadioCodeplugController.a.b>();
				}

				// Token: 0x04000069 RID: 105
				private uint a;

				// Token: 0x0400006A RID: 106
				private global::System.Collections.Generic.Dictionary<string, global::CommunicationController.CRadioCodeplugController.a.b> b;
			}
		}

		// Token: 0x02000020 RID: 32
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06000108 RID: 264 RVA: 0x0000C7D0 File Offset: 0x0000B7D0
			public global::Motorola.Common.Communication.Pba.DataBlockType c(ushort A_0)
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
				return new global::Motorola.Common.Communication.Pba.DataBlockType(this.a, A_0);
			}

			// Token: 0x06000109 RID: 265 RVA: 0x0000C818 File Offset: 0x0000B818
			public global::Motorola.Common.Communication.Pba.DataBlockType b(ushort A_0)
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
				return new global::Motorola.Common.Communication.Pba.DataBlockType(this.a, A_0);
			}

			// Token: 0x0400006B RID: 107
			public byte a;
		}
	}
}
