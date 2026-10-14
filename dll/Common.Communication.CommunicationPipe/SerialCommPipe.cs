using System;
using System.Globalization;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using Motorola.Common.CustomException;
using VerifyUtility;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000014 RID: 20
	internal class SerialCommPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe, global::System.IDisposable
	{
		// Token: 0x06000128 RID: 296 RVA: 0x00005209 File Offset: 0x00003409
		static SerialCommPipe()
		{
			global::VerifyUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00005211 File Offset: 0x00003411
		public SerialCommPipe(string portName, int baudRate, int receiveTimeout)
		{
			this.m_PortName = portName;
			this.m_BaudRate = baudRate;
			this.m_receiveTimeout = receiveTimeout;
			this.m_SerialPort = new global::System.IO.Ports.SerialPort();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00005239 File Offset: 0x00003439
		public SerialCommPipe(string portName, int baudRate) : this(portName, baudRate, 2000)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00005248 File Offset: 0x00003448
		~SerialCommPipe()
		{
			this.Dispose(false);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00005278 File Offset: 0x00003478
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00005280 File Offset: 0x00003480
		public int ReceiveTimeout
		{
			get
			{
				return this.m_receiveTimeout;
			}
			set
			{
				this.m_receiveTimeout = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00005289 File Offset: 0x00003489
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00005291 File Offset: 0x00003491
		public bool IsOpen { get; set; }

		// Token: 0x06000130 RID: 304 RVA: 0x0000529C File Offset: 0x0000349C
		public void OpenPort(int timeout)
		{
			if (!this.m_SerialPort.IsOpen)
			{
				this.m_SerialPort.PortName = this.m_PortName;
				this.m_SerialPort.NewLine = "\r\n";
				this.m_SerialPort.BaudRate = this.m_BaudRate;
				this.m_SerialPort.DataBits = 8;
				this.m_SerialPort.Parity = global::System.IO.Ports.Parity.None;
				this.m_SerialPort.StopBits = global::System.IO.Ports.StopBits.One;
				this.m_SerialPort.RtsEnable = true;
				this.m_SerialPort.DtrEnable = true;
				this.m_SerialPort.WriteBufferSize = 2048;
				this.m_SerialPort.ReadBufferSize = 2048;
				try
				{
					this.m_SerialPort.Open();
					goto IL_C3;
				}
				catch (global::System.Exception systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure, systemException);
				}
				goto IL_B8;
				IL_C3:
				this.IsOpen = true;
				return;
			}
			IL_B8:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeAlreadyOpened);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00005384 File Offset: 0x00003584
		public void ClosePort()
		{
			try
			{
				this.m_SerialPort.Close();
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeCloseFailure, systemException);
			}
			this.IsOpen = false;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000053C4 File Offset: 0x000035C4
		private void SendString(string buffer)
		{
			try
			{
				this.m_SerialPort.Write(buffer + "\r");
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure, systemException);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00005408 File Offset: 0x00003608
		private string ReceiveString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			try
			{
				try
				{
					string text;
					do
					{
						text = this.m_SerialPort.ReadLine();
						stringBuilder.AppendLine(text);
					}
					while (!(text.Trim() == "OK"));
				}
				catch (global::System.TimeoutException)
				{
					if (stringBuilder.Length == 0)
					{
						throw;
					}
				}
			}
			catch (global::System.TimeoutException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadTimeout, systemException);
			}
			catch (global::System.Exception systemException2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure, systemException2);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000549C File Offset: 0x0000369C
		private string RequestString(string sendBuffer)
		{
			this.SendString(sendBuffer);
			return this.ReceiveString();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000054AB File Offset: 0x000036AB
		public string SendATCommand(global::Motorola.Common.Communication.CommunicationPipe.ATCommand command, bool openClosePort, int timeout)
		{
			return this.SendATCommand(command, openClosePort, null, timeout);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000054B8 File Offset: 0x000036B8
		private string SendATCommand(global::Motorola.Common.Communication.CommunicationPipe.ATCommand command, bool openClosePort, string parameter, int timeout)
		{
			string text = "";
			if (openClosePort)
			{
				this.OpenPort(timeout);
			}
			string sendBuffer;
			switch (command)
			{
			case global::Motorola.Common.Communication.CommunicationPipe.ATCommand.AT_COMMAND_REQUEST_RADIO_INFORMAION:
				sendBuffer = "AT&V";
				break;
			case global::Motorola.Common.Communication.CommunicationPipe.ATCommand.AT_COMMAND_SET_FC_HW:
				sendBuffer = "AT&K3";
				break;
			case global::Motorola.Common.Communication.CommunicationPipe.ATCommand.AT_COMMAND_SET_FC_SW:
				sendBuffer = "AT&K4";
				break;
			case global::Motorola.Common.Communication.CommunicationPipe.ATCommand.AT_COMMAND_SET_FC_NONE:
				sendBuffer = "AT&K0";
				break;
			case global::Motorola.Common.Communication.CommunicationPipe.ATCommand.AT_COMMAND_SET_BR:
				if (parameter == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				}
				sendBuffer = "AT+IPR=" + parameter;
				break;
			case global::Motorola.Common.Communication.CommunicationPipe.ATCommand.AT_COMMAND_SET_IP_HOST:
				if (parameter == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				}
				sendBuffer = "AT+WV304=" + parameter;
				break;
			case global::Motorola.Common.Communication.CommunicationPipe.ATCommand.AT_COMMAND_SET_IP_CLIENT:
				if (parameter == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				}
				sendBuffer = "AT+WPNEI=" + parameter;
				break;
			case global::Motorola.Common.Communication.CommunicationPipe.ATCommand.AT_COMMAND_CONTEXT_ACT:
				sendBuffer = "AT#DATLCL=1";
				break;
			default:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			for (int i = 0; i < 3; i++)
			{
				text = this.RequestString(sendBuffer);
				if ((text.Contains("CARRIER") && !text.Contains("ERROR")) || text.Contains("OK"))
				{
					break;
				}
			}
			if (openClosePort)
			{
				this.ClosePort();
			}
			return text;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000055C5 File Offset: 0x000037C5
		// (set) Token: 0x06000138 RID: 312 RVA: 0x000055CD File Offset: 0x000037CD
		public int BaudRate
		{
			get
			{
				return this.m_BaudRate;
			}
			set
			{
				this.m_BaudRate = value;
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000055D6 File Offset: 0x000037D6
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000055E5 File Offset: 0x000037E5
		protected virtual void Dispose(bool isDisposing)
		{
			if (!this.m_IsDisposed)
			{
				if (isDisposing && this.m_SerialPort != null)
				{
					this.m_SerialPort.Dispose();
					this.m_SerialPort = null;
				}
				this.m_IsDisposed = true;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005614 File Offset: 0x00003814
		public void AutoInitBaudRate(int timeout)
		{
			string[] names = global::System.Enum.GetNames(typeof(global::Motorola.Common.Communication.CommunicationPipe.BaudRates));
			this.m_SerialPort.ReadTimeout = timeout;
			try
			{
				foreach (string text in names)
				{
					if (!(text == global::Motorola.Common.Communication.CommunicationPipe.BaudRates.NONE.ToString()))
					{
						this.m_BaudRate = int.Parse(text.Substring(7), global::System.Globalization.CultureInfo.InvariantCulture);
						try
						{
							this.OpenPort(timeout);
							for (int j = 0; j < 2; j++)
							{
								this.SendString("AT");
								try
								{
									string text2 = this.ReceiveString();
									if (text2.Contains("OK"))
									{
										return;
									}
								}
								catch (global::System.TimeoutException)
								{
								}
							}
						}
						finally
						{
							this.ClosePort();
						}
					}
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeBaudrateInitFail);
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeBaudrateInitFail, systemException);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00005708 File Offset: 0x00003908
		public static global::Motorola.Common.Communication.CommunicationPipe.RadioSerialInfo ParseRadioInfo(string input)
		{
			global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(input, "CARRIER:(?<CARRIER>\\d+).*FLOW:(?<FLOW>\\w+).*WV304:(?<WV304>[0-9\\.]+).*RADIO:(?<RADIO>[^\\r]+).*PORT:(?<PORT>[^\\r]+)", global::System.Text.RegularExpressions.RegexOptions.Singleline);
			if (match.Success)
			{
				int baudRate = int.Parse(match.Groups[1].Value, global::System.Globalization.CultureInfo.InvariantCulture);
				string value = match.Groups[3].Value;
				string text = match.Groups[4].Value.ToUpperInvariant();
				int radioType;
				if (text.Contains("ASTRO"))
				{
					radioType = 2;
				}
				else if (text.Contains("XTS"))
				{
					radioType = 1;
				}
				else if (text.Contains("HPD"))
				{
					radioType = 3;
				}
				else
				{
					radioType = 0;
				}
				string value2 = match.Groups[5].Value;
				int connectorPosition;
				if (value2.Contains("FRONT"))
				{
					connectorPosition = 1;
				}
				else if (value2.Contains("REAR"))
				{
					connectorPosition = 2;
				}
				else if (value2.Contains("SIDE"))
				{
					connectorPosition = 3;
				}
				else if (value2.Contains("HPD"))
				{
					connectorPosition = 0;
				}
				else
				{
					if (!value2.Contains("REMOTE"))
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeInvalidConnectorPosition);
					}
					connectorPosition = 4;
				}
				string value3 = match.Groups[2].Value;
				global::Motorola.Common.Communication.CommunicationPipe.FlowControls flowControl;
				if (value3.Contains("K0"))
				{
					flowControl = global::Motorola.Common.Communication.CommunicationPipe.FlowControls.NONE;
				}
				else if (value3.Contains("K3"))
				{
					flowControl = global::Motorola.Common.Communication.CommunicationPipe.FlowControls.HARDWARE_FLOW_CONTROL;
				}
				else
				{
					if (!value3.Contains("K4"))
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeInvalidFlowControl);
					}
					flowControl = global::Motorola.Common.Communication.CommunicationPipe.FlowControls.SOFTWARE_FLOW_CONTROL;
				}
				return new global::Motorola.Common.Communication.CommunicationPipe.RadioSerialInfo(radioType, connectorPosition, flowControl, baudRate, value);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeInvalidRadioReply);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000058A0 File Offset: 0x00003AA0
		public void SendData(byte[] buffer, int start, int length)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(length);
			this.m_SerialPort.Write(bytes, 1, 1);
			this.m_SerialPort.Write(bytes, 0, 1);
			this.m_SerialPort.Write(buffer, start, length);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000058DE File Offset: 0x00003ADE
		public byte[] ReceiveData()
		{
			return this.ReceiveData(this.ReceiveTimeout);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000058EC File Offset: 0x00003AEC
		public byte[] ReceiveData(int timeout)
		{
			this.m_SerialPort.ReadTimeout = timeout;
			byte[] array = new byte[2];
			int num = this.m_SerialPort.Read(array, 0, array.Length);
			if (num != array.Length)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeInvalidPacketHeader);
			}
			byte[] array2 = new byte[(int)array[0] * 256 + (int)array[1]];
			this.m_SerialPort.Read(array2, 0, array2.Length);
			return array2;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00005953 File Offset: 0x00003B53
		public byte[] RequestData(byte[] buffer, int start, int length)
		{
			return this.RequestData(buffer, start, length, this.ReceiveTimeout);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005964 File Offset: 0x00003B64
		public byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			((global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe)this).SendData(buffer, start, length);
			return ((global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe)this).ReceiveData(timeout);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005977 File Offset: 0x00003B77
		public int ReceiveData(byte[] buffer, int start)
		{
			return this.ReceiveData(buffer, start, this.ReceiveTimeout);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00005988 File Offset: 0x00003B88
		public int ReceiveData(byte[] buffer, int start, int timeout)
		{
			this.m_SerialPort.ReadTimeout = timeout;
			byte[] array = new byte[2];
			int num = this.m_SerialPort.Read(array, 0, array.Length);
			if (num != array.Length)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeInvalidPacketHeader);
			}
			int count = (int)array[0] * 256 + (int)array[1];
			return this.m_SerialPort.Read(buffer, start, count);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000059E6 File Offset: 0x00003BE6
		public int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000059EE File Offset: 0x00003BEE
		public byte[] PeekData(int length, int timeOut)
		{
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000059F6 File Offset: 0x00003BF6
		public int AvailableReadBytesCount
		{
			get
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
			}
		}

		// Token: 0x04000082 RID: 130
		private string m_PortName;

		// Token: 0x04000083 RID: 131
		private int m_BaudRate;

		// Token: 0x04000084 RID: 132
		private global::System.IO.Ports.SerialPort m_SerialPort;

		// Token: 0x04000085 RID: 133
		private int m_receiveTimeout;

		// Token: 0x04000086 RID: 134
		private bool m_IsDisposed;
	}
}
