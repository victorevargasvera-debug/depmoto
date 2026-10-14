using System;
using System.IO.Ports;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TetraUtility;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000010 RID: 16
	public class TetraCommPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe, global::System.IDisposable
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00004070 File Offset: 0x00002270
		public TetraCommPipe(string portName, int baudRate, string location4Log, string usbHubInstance, uint usbHubPortNum, bool needCheckAckOnUSB)
		{
			this._needCheckAckOnUSB = needCheckAckOnUSB;
			this.BasicInit(portName, baudRate, location4Log, usbHubInstance, usbHubPortNum);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000409F File Offset: 0x0000229F
		public TetraCommPipe(string portName, int baudRate, string location4Log, bool isReliable, string usbHubInstance, uint usbHubPortNum)
		{
			this._isReliable = isReliable;
			this.BasicInit(portName, baudRate, location4Log, usbHubInstance, usbHubPortNum);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000040CE File Offset: 0x000022CE
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000040DB File Offset: 0x000022DB
		public int BaudRate
		{
			get
			{
				return this._mySerialPort.BaudRate;
			}
			set
			{
				if (this._isOpen)
				{
					this._mySerialPort.BaudRate = value;
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000040F1 File Offset: 0x000022F1
		public string PortName
		{
			get
			{
				return this._mySerialPort.PortName;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000040FE File Offset: 0x000022FE
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00004106 File Offset: 0x00002306
		public bool IsOpen
		{
			get
			{
				return this._isOpen;
			}
			set
			{
				this._isOpen = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000410F File Offset: 0x0000230F
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000411C File Offset: 0x0000231C
		public int ReadTimeout
		{
			get
			{
				return this._mySerialPort.ReadTimeout;
			}
			set
			{
				this._mySerialPort.ReadTimeout = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000412A File Offset: 0x0000232A
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00004137 File Offset: 0x00002337
		public int WriteTimeout
		{
			get
			{
				return this._mySerialPort.WriteTimeout;
			}
			set
			{
				this._mySerialPort.WriteTimeout = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00004145 File Offset: 0x00002345
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000414D File Offset: 0x0000234D
		public bool Reliable
		{
			get
			{
				return this._isReliable;
			}
			set
			{
				this._isReliable = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00004156 File Offset: 0x00002356
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000415E File Offset: 0x0000235E
		public bool SupressTriggerUSBAnalyzer
		{
			get
			{
				return this._supressTrigger;
			}
			set
			{
				this._supressTrigger = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00004167 File Offset: 0x00002367
		public bool NeedCheckAckOnUSB
		{
			get
			{
				return this._needCheckAckOnUSB;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004170 File Offset: 0x00002370
		public bool OpenPort()
		{
			bool flag = true;
			if (!this._mySerialPort.IsOpen)
			{
				try
				{
					this._mySerialPort.PortName = this._myPortName;
					this._mySerialPort.BaudRate = this._myBaudRate;
					this._mySerialPort.DataBits = 8;
					this._mySerialPort.Parity = global::System.IO.Ports.Parity.None;
					this._mySerialPort.StopBits = global::System.IO.Ports.StopBits.One;
					this._mySerialPort.RtsEnable = false;
					this._mySerialPort.DtrEnable = false;
					this._mySerialPort.WriteBufferSize = (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_WRITE_SIZE;
					this._mySerialPort.ReadBufferSize = (int)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE;
					if (this._mySerialPort is global::Motorola.Common.Communication.CommunicationPipe.PhySerialPort)
					{
						this._mySerialPort.RtsEnable = true;
						this._mySerialPort.DtrEnable = true;
						this._isRS232Port = true;
					}
					else
					{
						this._isRS232Port = false;
					}
					this._mySerialPort.Open();
					this._mySerialPort.BaudRate = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.BAUD_RATE_SBEP;
					this.ReadTimeout = global::System.Convert.ToInt32(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.DEFAULT_TIMEOUT);
					this.WriteTimeout = global::System.Convert.ToInt32(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.DEFAULT_TIMEOUT);
				}
				catch (global::System.Exception e)
				{
					string format = "Serial Port Open Failure";
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, this.PortName, format, new object[0]);
					flag = false;
				}
				if (flag)
				{
					this._needTriggerUSBAnalyzer = this.TriggerUSBAnalyzer;
					global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.DeviceDetached += this.SerialComm_deviceDetached;
				}
				else
				{
					this.BeginPortDiagnose();
				}
			}
			if (flag)
			{
				this._isOpen = true;
				if (this._isOpen && this._isRS232Port)
				{
					global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility.Instance.AddOpeningRS232Port(this._mySerialPort.PortName, this._mySerialPort as global::System.IO.Ports.SerialPort);
				}
			}
			return flag;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004318 File Offset: 0x00002518
		public void ClosePort()
		{
			if (!this._mySerialPort.IsOpen)
			{
				string text = "Can't Close An Unopend Serial Port";
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Error Message: {0}", new object[]
				{
					text
				});
				return;
			}
			try
			{
				this._mySerialPort.Close();
			}
			catch (global::System.Exception ex)
			{
				string text2 = "Serial Port Close Failure";
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception: {0}; Message: {1}", new object[]
				{
					ex,
					text2
				});
			}
			if (this._isRS232Port)
			{
				global::Motorola.Common.Communication.CommonUtil.RS232DevCreateUtility.Instance.RemoveOpeningRS232Port(this._mySerialPort.PortName);
			}
			global::Motorola.Common.Communication.TetraUtility.TetraPnPMonitor.Instance.DeviceDetached -= this.SerialComm_deviceDetached;
			this._needTriggerUSBAnalyzer = false;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000043D8 File Offset: 0x000025D8
		public int SendData(byte[] buffer, int start, int expectedLength)
		{
			uint num = 0U;
			bool flag = true;
			if (!this._mySerialPort.IsOpen)
			{
				string text = "Can't Send Data to An Unopend Serial Port";
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Error Message: {0}", new object[]
				{
					text
				});
				return -1;
			}
			if (buffer == null)
			{
				flag = false;
			}
			if (start < 0)
			{
				flag = false;
			}
			if (start >= buffer.Length)
			{
				flag = false;
			}
			if (expectedLength > buffer.Length - start)
			{
				flag = false;
			}
			if (flag)
			{
				uint num2 = global::System.Convert.ToUInt32(expectedLength);
				uint num3 = global::System.Convert.ToUInt32(expectedLength);
				bool flag2 = !this.Reliable && this._mySerialPort is global::Motorola.Common.Communication.CommunicationPipe.VirtualSerialPort && expectedLength % global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.FUK_MAX_DATA_TRANS_SIZE == 0;
				while (num2 > 0U)
				{
					try
					{
						uint num4;
						if (flag2)
						{
							num4 = ((num2 > global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_SPLIT_WRITE_SIZE) ? global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_SPLIT_WRITE_SIZE : num2);
						}
						else
						{
							num4 = ((num2 > global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_COMPRESS_WRITE_SIZE) ? global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_COMPRESS_WRITE_SIZE : num2);
						}
						this._mySerialPort.Write(buffer, start + global::System.Convert.ToInt32(num), global::System.Convert.ToInt32(num4));
						num += num4;
						num2 = num3 - num;
					}
					catch (global::System.TimeoutException)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Write(this.PortName, buffer, start, global::System.Convert.ToInt32(num), "Failed: Write Data >>> expectedLength[{0}]/bytesWritten[{1}]", new object[]
						{
							expectedLength,
							num
						});
						this.BeginPortDiagnose();
						return 0;
					}
					catch (global::System.InvalidOperationException)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Write(this.PortName, buffer, start, global::System.Convert.ToInt32(num), "Failed: Write Data >>> expectedLength[{0}]/bytesWritten[{1}]", new object[]
						{
							expectedLength,
							num
						});
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Write(this.PortName, buffer, start, global::System.Convert.ToInt32(num), "Failed: Write Data >>> expectedLength[{0}]/bytesWritten[{1}]", new object[]
						{
							expectedLength,
							num
						});
						this.BeginPortDiagnose();
						return -1;
					}
					catch (global::System.Exception)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Write(this.PortName, buffer, start, global::System.Convert.ToInt32(num), "Failed: Write Data >>> expectedLength[{0}]/bytesWritten[{1}]", new object[]
						{
							expectedLength,
							num
						});
						this.BeginPortDiagnose();
						return -1;
					}
				}
			}
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.Write(this.PortName, buffer, start, global::System.Convert.ToInt32(num), "Write Data >>> expectedLength[{0}]/bytesWritten[{1}]", new object[]
			{
				expectedLength,
				num
			});
			return global::System.Convert.ToInt32(num);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004640 File Offset: 0x00002840
		public int ReceiveDataOnce(byte[] buffer, int start)
		{
			if (buffer == null)
			{
				return -1;
			}
			return this.MyReceiveData(buffer, start, buffer.Length, true);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004653 File Offset: 0x00002853
		public int ReceiveData(byte[] buffer, int start, int expectedLength)
		{
			return this.MyReceiveData(buffer, start, expectedLength, false);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004660 File Offset: 0x00002860
		public void PurgeOutputBuffer()
		{
			if (!this._mySerialPort.IsOpen)
			{
				string log = "Can't Purge TX Data on An Unopend Serial Port";
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.PortName, log);
				return;
			}
			try
			{
				this._mySerialPort.DiscardOutBuffer();
			}
			catch (global::System.InvalidOperationException e)
			{
				string format = "The specified port is not open when try to purge serial port TX";
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, this.PortName, format, new object[0]);
			}
			catch (global::System.Exception e2)
			{
				string format2 = "Serial Port Purge TX Failure";
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e2, this.PortName, format2, new object[0]);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000046F0 File Offset: 0x000028F0
		public void PurgeInputBuffer()
		{
			if (!this._mySerialPort.IsOpen)
			{
				string log = "Can't Purge RX Data on An Unopend Serial Port";
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.PortName, log);
				return;
			}
			try
			{
				this._mySerialPort.DiscardInBuffer();
			}
			catch (global::System.InvalidOperationException e)
			{
				string format = "The specified port is not open when try to purge serial port RX";
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, this.PortName, format, new object[0]);
			}
			catch (global::System.Exception e2)
			{
				string format2 = "Serial Port Purge RX Failure";
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e2, this.PortName, format2, new object[0]);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00004780 File Offset: 0x00002980
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000478D File Offset: 0x0000298D
		public int ReceiveTimeout
		{
			get
			{
				return this._mySerialPort.ReadTimeout;
			}
			set
			{
				this._mySerialPort.ReadTimeout = value;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000479B File Offset: 0x0000299B
		public void OpenPort(int timeout)
		{
			this.OpenPort();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000047A4 File Offset: 0x000029A4
		void global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe.SendData(byte[] buffer, int start, int length)
		{
			this.SendData(buffer, start, length);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000047B0 File Offset: 0x000029B0
		public byte[] ReceiveData()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000047B7 File Offset: 0x000029B7
		public byte[] ReceiveData(int timeout)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000047BE File Offset: 0x000029BE
		public int ReceiveData(byte[] buffer, int start)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000047C8 File Offset: 0x000029C8
		public int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			int result = 0;
			if (this._mySerialPort.IsOpen)
			{
				this._mySerialPort.ReadTimeout = timeout;
				result = this.MyReceiveData(buffer, start, expectedlength, false);
			}
			return result;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000047FD File Offset: 0x000029FD
		public byte[] RequestData(byte[] buffer, int start, int length)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004804 File Offset: 0x00002A04
		public byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000480B File Offset: 0x00002A0B
		public byte[] PeekData(int length, int timeOut)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00004812 File Offset: 0x00002A12
		public int AvailableReadBytesCount
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000481C File Offset: 0x00002A1C
		private int MyReceiveData(byte[] buffer, int start, int expectedLength, bool readExisting)
		{
			int num = 0;
			bool flag = true;
			if (!this._mySerialPort.IsOpen)
			{
				string log = "Can't Receive Data from An Unopend Serial Port";
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.PortName, log);
				flag = false;
				num = -1;
			}
			if (buffer == null)
			{
				flag = false;
				num = -1;
			}
			if (start >= buffer.Length)
			{
				flag = false;
				num = -1;
			}
			if (expectedLength > buffer.Length - start)
			{
				flag = false;
				num = -1;
			}
			if (flag)
			{
				uint num2 = global::System.Convert.ToUInt32(expectedLength);
				int result;
				for (;;)
				{
					try
					{
						uint value = (num2 > global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE) ? global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.MAX_READ_SIZE : num2;
						int num3 = this._mySerialPort.Read(buffer, start + num, global::System.Convert.ToInt32(value));
						global::System.TimeSpan timeSpan = global::System.DateTime.Now - global::System.DateTime.Now;
						if (timeSpan.TotalMilliseconds > 1000.0)
						{
							string log = string.Format("mySerialPort.Read() spend time[{0}]ms on Port[{1}]", timeSpan.TotalMilliseconds, this.PortName);
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.PortName, log);
							log = string.Format("mySerialPort.Read() spend time[{0}]ms on Port[{1}]", timeSpan.TotalMilliseconds, this.PortName);
							global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.PortName, log);
						}
						num += num3;
						num2 = global::System.Convert.ToUInt32(expectedLength - num);
					}
					catch (global::System.TimeoutException e)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e, this.PortName, "Failed: Read() timeout[{0}]. expectedLength[{1}]/bytesRead[{2}]", new object[]
						{
							this.ReadTimeout,
							expectedLength,
							num
						});
						this.BeginPortDiagnose();
						result = 0;
						break;
					}
					catch (global::System.InvalidOperationException e2)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e2, this.PortName, "Failed: Read() timeout[{0}]. expectedLength[{1}]/bytesRead[{2}]", new object[]
						{
							this.ReadTimeout,
							expectedLength,
							num
						});
						this.BeginPortDiagnose();
						result = -1;
						break;
					}
					catch (global::System.Exception e3)
					{
						global::Motorola.Common.Communication.TetraUtility.TransportLogger.Error(e3, this.PortName, "Failed: Read() timeout[{0}]. expectedLength[{1}]/bytesRead[{2}]", new object[]
						{
							this.ReadTimeout,
							expectedLength,
							num
						});
						this.BeginPortDiagnose();
						result = -1;
						break;
					}
					if (readExisting || num2 <= 0U)
					{
						goto IL_1FB;
					}
				}
				return result;
			}
			IL_1FB:
			if (num > expectedLength)
			{
				global::Motorola.Common.Communication.TetraUtility.TransportLogger.Write(this.PortName, buffer, start, num, "Failed: Read Data <<< expectedLength[{0}]/bytesRead[{1}]", new object[]
				{
					expectedLength,
					num
				});
				this.BeginPortDiagnose();
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0015_RH_CommErrReceivedDataLengthGreaterThanExpectedLength.ToString(), "received data length greater than expected length");
			}
			global::Motorola.Common.Communication.TetraUtility.TransportLogger.Write(this.PortName, buffer, start, num, "Read Data <<< expectedLength[{0}]/bytesRead[{1}]", new object[]
			{
				expectedLength,
				num
			});
			return num;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004AD4 File Offset: 0x00002CD4
		private void BeginPortDiagnose()
		{
			if (this._mySerialPort is global::Motorola.Common.Communication.CommunicationPipe.VirtualSerialPort)
			{
				global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS usb_CONNECTION_STATUS = global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.NoDeviceConnected;
				global::Motorola.Common.Communication.CommunicationPipe.VirtualSerialPort virtualSerialPort = this._mySerialPort as global::Motorola.Common.Communication.CommunicationPipe.VirtualSerialPort;
				bool usbportStatus = virtualSerialPort.GetUSBPortStatus(out usb_CONNECTION_STATUS);
				if (usbportStatus)
				{
					string str = global::Motorola.Common.Communication.TetraUtility.USBDiagnose.ConnectionStatusCodeToStr(usb_CONNECTION_STATUS);
					string text = "USB Status is: ";
					text += str;
					global::Motorola.Common.Communication.TetraUtility.TransportLogger.WriteInfo(this.PortName, text);
					if (usb_CONNECTION_STATUS == global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.DeviceConnected && this._needTriggerUSBAnalyzer && !this.SupressTriggerUSBAnalyzer)
					{
						virtualSerialPort.TriggerUSBAnalyzer();
					}
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004B48 File Offset: 0x00002D48
		private void BasicInit(string portName, int baudRate, string location4Log, string usbHubInstance, uint usbHubPortNum)
		{
			this._location4Log = location4Log;
			this._myPortName = portName;
			this._myBaudRate = baudRate;
			if (this._isReliable)
			{
				this._mySerialPort = this.newOneVirtualSerialPort(portName, usbHubInstance, usbHubPortNum);
				return;
			}
			this._mySerialPort = this.newOnePhySerialPort();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004B88 File Offset: 0x00002D88
		private void SerialComm_deviceDetached(object obj, global::Motorola.Common.Communication.TetraUtility.TetraPnPMsgEventArgs args)
		{
			for (int i = 0; i < args.MsgList.Count; i++)
			{
				if (args.MsgList[i].PortNumber == this.PortName)
				{
					this.ClosePort();
					return;
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00004BD0 File Offset: 0x00002DD0
		private bool TriggerUSBAnalyzer
		{
			get
			{
				string value = global::Motorola.Common.Communication.TetraUtility.OptionsDatabaseSingleton.Instance.GetValue("Com_Raw_Data_Log", "Trigger_USB_Analyzer");
				return !string.IsNullOrEmpty(value) && global::System.Convert.ToBoolean(value);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004C02 File Offset: 0x00002E02
		private global::Motorola.Common.Communication.CommunicationPipe.VirtualSerialPort newOneVirtualSerialPort(string portName, string usbHubInstance, uint usbHubPortNum)
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.VirtualSerialPort(portName, usbHubInstance, usbHubPortNum);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004C0C File Offset: 0x00002E0C
		private global::Motorola.Common.Communication.CommunicationPipe.PhySerialPort newOnePhySerialPort()
		{
			return new global::Motorola.Common.Communication.CommunicationPipe.PhySerialPort();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004C13 File Offset: 0x00002E13
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004C24 File Offset: 0x00002E24
		private void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			try
			{
				if (disposing)
				{
					global::Motorola.Common.Communication.CommunicationPipe.PhySerialPort phySerialPort = this._mySerialPort as global::Motorola.Common.Communication.CommunicationPipe.PhySerialPort;
					if (phySerialPort != null)
					{
						phySerialPort.Dispose();
					}
					global::Motorola.Common.Communication.CommunicationPipe.VirtualSerialPort virtualSerialPort = this._mySerialPort as global::Motorola.Common.Communication.CommunicationPipe.VirtualSerialPort;
					if (virtualSerialPort != null)
					{
						virtualSerialPort.Dispose();
					}
				}
			}
			finally
			{
				this._disposed = true;
			}
		}

		// Token: 0x04000064 RID: 100
		private const string OPTIONS_COM_LOG_SECTION = "Com_Raw_Data_Log";

		// Token: 0x04000065 RID: 101
		private const string OPTIONS_COM_LOG_TRIGGER_USB_ANALYZER = "Trigger_USB_Analyzer";

		// Token: 0x04000066 RID: 102
		private string _location4Log = string.Empty;

		// Token: 0x04000067 RID: 103
		private string _myPortName;

		// Token: 0x04000068 RID: 104
		private int _myBaudRate;

		// Token: 0x04000069 RID: 105
		private global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort _mySerialPort;

		// Token: 0x0400006A RID: 106
		private bool _needCheckAckOnUSB;

		// Token: 0x0400006B RID: 107
		private bool _disposed;

		// Token: 0x0400006C RID: 108
		private bool _isReliable = true;

		// Token: 0x0400006D RID: 109
		private bool _needTriggerUSBAnalyzer;

		// Token: 0x0400006E RID: 110
		private bool _supressTrigger;

		// Token: 0x0400006F RID: 111
		private bool _isOpen;

		// Token: 0x04000070 RID: 112
		private bool _isRS232Port;
	}
}
