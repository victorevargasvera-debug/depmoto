using System;
using System.Globalization;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using Motorola.Common.Communication.TetraUtility;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x0200001D RID: 29
	internal class VirtualSerialPort : global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort, global::System.IDisposable
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x00006A6C File Offset: 0x00004C6C
		public VirtualSerialPort(string portName, string usbHubInstance, uint usbHubPortNum)
		{
			this._portName = "";
			this._baudRate = 9600;
			this._stopBits = global::System.IO.Ports.StopBits.One;
			this._parity = global::System.IO.Ports.Parity.None;
			this._rtsEnable = false;
			this._dtrEnable = false;
			this._writeBufferSize = 1024;
			this._readBufferSize = 1024;
			this._bOpen = false;
			this._nativeAPISet = new global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper(portName);
			this._portName = portName;
			this._commTimeouts = this.CreateAndIniTimeouts(true);
			this._usbHubInstance = usbHubInstance;
			this._usbHubPortNum = usbHubPortNum;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00006B34 File Offset: 0x00004D34
		~VirtualSerialPort()
		{
			this.Dispose(false);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00006B64 File Offset: 0x00004D64
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00006B6C File Offset: 0x00004D6C
		public int BaudRate
		{
			get
			{
				return this._baudRate;
			}
			set
			{
				if (value <= 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				}
				this._baudRate = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00006B80 File Offset: 0x00004D80
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00006B88 File Offset: 0x00004D88
		public string PortName
		{
			get
			{
				return this._portName;
			}
			set
			{
				this.CheckPortNameFormat(value);
				this._portName = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00006B98 File Offset: 0x00004D98
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00006BA0 File Offset: 0x00004DA0
		public int DataBits
		{
			get
			{
				return this._dataBit;
			}
			set
			{
				if (value < 5 || value > 8)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				}
				this._dataBit = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00006BB8 File Offset: 0x00004DB8
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00006BC0 File Offset: 0x00004DC0
		public global::System.IO.Ports.Parity Parity
		{
			get
			{
				return this._parity;
			}
			set
			{
				if (value < global::System.IO.Ports.Parity.None || value > global::System.IO.Ports.Parity.Space)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				}
				this._parity = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00006BD8 File Offset: 0x00004DD8
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00006BE0 File Offset: 0x00004DE0
		public global::System.IO.Ports.StopBits StopBits
		{
			get
			{
				return this._stopBits;
			}
			set
			{
				if (value < global::System.IO.Ports.StopBits.One || value > global::System.IO.Ports.StopBits.OnePointFive)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				}
				this._stopBits = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00006BF8 File Offset: 0x00004DF8
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00006C00 File Offset: 0x00004E00
		public bool RtsEnable
		{
			get
			{
				return this._rtsEnable;
			}
			set
			{
				this._rtsEnable = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00006C09 File Offset: 0x00004E09
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00006C11 File Offset: 0x00004E11
		public bool DtrEnable
		{
			get
			{
				return this._dtrEnable;
			}
			set
			{
				this._dtrEnable = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00006C1A File Offset: 0x00004E1A
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00006C22 File Offset: 0x00004E22
		public int WriteBufferSize
		{
			get
			{
				return this._writeBufferSize;
			}
			set
			{
				if (value <= 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				}
				this._writeBufferSize = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00006C36 File Offset: 0x00004E36
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00006C3E File Offset: 0x00004E3E
		public int ReadBufferSize
		{
			get
			{
				return this._readBufferSize;
			}
			set
			{
				if (value <= 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				}
				this._readBufferSize = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00006C52 File Offset: 0x00004E52
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00006C5C File Offset: 0x00004E5C
		public int WriteTimeout
		{
			get
			{
				return this._writeTimeout;
			}
			set
			{
				if (value < 0 && value != -1)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				}
				if (this.IsOpen)
				{
					if (this.SetWriteTimeout((uint)value))
					{
						this._writeTimeout = value;
						return;
					}
				}
				else
				{
					this._writeTimeout = value;
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00006C9A File Offset: 0x00004E9A
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00006CA4 File Offset: 0x00004EA4
		public int ReadTimeout
		{
			get
			{
				return this._readTimeout;
			}
			set
			{
				if (value < 0 && value != -1)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				}
				if (this.IsOpen)
				{
					if (this.SetReadTimeout((uint)value))
					{
						this._readTimeout = value;
						return;
					}
				}
				else
				{
					this._readTimeout = value;
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00006CE4 File Offset: 0x00004EE4
		public bool IsOpen
		{
			get
			{
				bool bOpen;
				lock (this._openCloseLock)
				{
					bOpen = this._bOpen;
				}
				return bOpen;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00006D28 File Offset: 0x00004F28
		public void Open()
		{
			uint num = 0U;
			global::System.IntPtr intPtr = 0;
			if (string.IsNullOrEmpty(this._portName))
			{
				throw new global::System.ArgumentNullException("_portName", "Port Name is null");
			}
			bool flag = this._nativeAPISet.WrapperCreateFile("\\\\.\\" + this._portName, 3221225472U, 0U, 3U, 1073741824U, ref intPtr);
			if (flag)
			{
				flag = this._nativeAPISet.WrapperGetFileType(intPtr, ref num);
				if (flag && num != 2U && num != 0U)
				{
					flag = false;
				}
			}
			if (flag)
			{
				this._fileHandle = intPtr;
				flag = this._nativeAPISet.WrapperCreateEvent(true, false, ref this._readEvent);
			}
			if (flag)
			{
				flag = this._nativeAPISet.WrapperCreateEvent(true, false, ref this._writeEvent);
			}
			if (flag)
			{
				global::Motorola.Common.Communication.TetraUtility.NativeMethods.OVERLAPPED structure = new global::Motorola.Common.Communication.TetraUtility.NativeMethods.OVERLAPPED(global::System.UIntPtr.Zero, global::System.UIntPtr.Zero, 0U, 0U, this._readEvent);
				this._olRead = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(global::System.Runtime.InteropServices.Marshal.SizeOf<global::Motorola.Common.Communication.TetraUtility.NativeMethods.OVERLAPPED>(structure));
				global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.OVERLAPPED>(structure, this._olRead, false);
				global::Motorola.Common.Communication.TetraUtility.NativeMethods.OVERLAPPED structure2 = new global::Motorola.Common.Communication.TetraUtility.NativeMethods.OVERLAPPED(global::System.UIntPtr.Zero, global::System.UIntPtr.Zero, 0U, 0U, this._writeEvent);
				this._olWrite = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(global::System.Runtime.InteropServices.Marshal.SizeOf<global::Motorola.Common.Communication.TetraUtility.NativeMethods.OVERLAPPED>(structure));
				global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.TetraUtility.NativeMethods.OVERLAPPED>(structure2, this._olWrite, false);
			}
			if (flag)
			{
				this._dcb = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB);
				this._dcb.DCBLength = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB));
				this._dcb.BaudRate = (uint)this.BaudRate;
				this._dcb.StopBits = this.ConvertStopBitsFromEnumToByte(this._stopBits);
				if (this.RtsEnable)
				{
					this._dcb.RtsControl = global::Motorola.Common.Communication.TetraUtility.NativeMethods.RtsControl.Enable;
				}
				else
				{
					this._dcb.RtsControl = global::Motorola.Common.Communication.TetraUtility.NativeMethods.RtsControl.Disable;
				}
				if (this.DtrEnable)
				{
					this._dcb.DtrControl = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DtrControl.Enable;
				}
				else
				{
					this._dcb.DtrControl = global::Motorola.Common.Communication.TetraUtility.NativeMethods.DtrControl.Disable;
				}
				this._dcb.ByteSize = (byte)this.DataBits;
				this._dcb.Parity = (byte)this.Parity;
				flag = this._nativeAPISet.WrapperSetCommState(this._fileHandle, ref this._dcb);
			}
			if (flag)
			{
				flag = this._nativeAPISet.WrapperSetCommTimeouts(this._fileHandle, ref this._commTimeouts);
			}
			if (!flag)
			{
				this.ReleaseResource();
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenComPortFailure);
			}
			this._bOpen = true;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00006F58 File Offset: 0x00005158
		public void Close()
		{
			lock (this._rWLock)
			{
				lock (this._purgeLock)
				{
					lock (this._timeoutsLock)
					{
						this.ReleaseResource();
					}
				}
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00006FF0 File Offset: 0x000051F0
		public void DiscardOutBuffer()
		{
			if (!this.IsOpen)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			}
			uint purgeFlag = 5U;
			lock (this._purgeLock)
			{
				this._nativeAPISet.WrapperPurgeComm(this._fileHandle, purgeFlag);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00007054 File Offset: 0x00005254
		public void DiscardInBuffer()
		{
			if (!this.IsOpen)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			}
			uint purgeFlag = 10U;
			lock (this._purgeLock)
			{
				this._nativeAPISet.WrapperPurgeComm(this._fileHandle, purgeFlag);
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000070B8 File Offset: 0x000052B8
		public int Read(byte[] buffer, int offset, int count)
		{
			if (!this.IsOpen)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			}
			if (buffer == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (offset < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			if (count < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			if (buffer.Length - offset < count)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			int result;
			lock (this._rWLock)
			{
				result = this._nativeAPISet.ReadFileAsyn(this._fileHandle, buffer, (uint)offset, (uint)count, this._olRead, this._commTimeouts.ReadTotalTimeoutConstant);
			}
			return result;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000715C File Offset: 0x0000535C
		public void Write(byte[] buffer, int offset, int count)
		{
			if (!this.IsOpen)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			}
			if (buffer == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (offset < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			if (count < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			if (buffer.Length - offset < count)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			lock (this._rWLock)
			{
				this._nativeAPISet.WriteFileAsyn(this._fileHandle, buffer, (uint)offset, (uint)count, this._olWrite, this._writeEvent, this._commTimeouts.WriteTotalTimeoutConstant);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00007210 File Offset: 0x00005410
		public bool TriggerUSBAnalyzer()
		{
			byte[] command = new byte[]
			{
				128,
				6,
				234,
				3,
				9,
				4,
				byte.MaxValue,
				0
			};
			byte[] replyData = new byte[255];
			return global::Motorola.Common.Communication.TetraUtility.USBDiagnose.SendUSBCtrlRequest(this._fileHandle, this._olRead, string.Empty, command, replyData);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00007254 File Offset: 0x00005454
		public bool GetUSBPortStatus(out global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS status)
		{
			status = global::Motorola.Common.Communication.TetraUtility.USB_CONNECTION_STATUS.NoDeviceConnected;
			return !string.IsNullOrEmpty(this._usbHubInstance) && this._usbHubPortNum != 0U && global::Motorola.Common.Communication.TetraUtility.USBDiagnose.GetUSBPortStatus(this._usbHubInstance, this._usbHubPortNum, this.PortName, out status);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00007288 File Offset: 0x00005488
		public void ResetUSBPort()
		{
			global::Motorola.Common.Communication.TetraUtility.USBDiagnose.ResetUSBPort(this._fileHandle, this._olRead, this.PortName);
			this.Close();
			global::System.Threading.Thread.Sleep(3000);
			this.Open();
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000072B8 File Offset: 0x000054B8
		private void CheckPortNameFormat(string portName)
		{
			bool flag = true;
			if (portName == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (portName.Length == 0 || portName.Length > 6)
			{
				flag = false;
			}
			if (flag && !portName.StartsWith("COM", global::System.StringComparison.OrdinalIgnoreCase))
			{
				flag = false;
			}
			if (flag)
			{
				string text = "COM";
				string value = portName.Substring(text.Length);
				try
				{
					uint num = global::System.Convert.ToUInt32(value, global::System.Globalization.CultureInfo.InvariantCulture);
					if (num > 255U || num == 0U)
					{
						flag = false;
					}
				}
				catch (global::System.FormatException)
				{
					flag = false;
				}
			}
			if (flag && this._bOpen)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure);
			}
			if (!flag)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00007360 File Offset: 0x00005560
		private byte ConvertStopBitsFromEnumToByte(global::System.IO.Ports.StopBits value)
		{
			byte result;
			if (value == global::System.IO.Ports.StopBits.One)
			{
				result = 0;
			}
			else if (value == global::System.IO.Ports.StopBits.OnePointFive)
			{
				result = 1;
			}
			else
			{
				result = 2;
			}
			return result;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00007380 File Offset: 0x00005580
		private bool SetReadTimeout(uint readTimeout)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommTimeouts commTimeouts = this.CreateAndIniTimeouts(false);
			commTimeouts.ReadTotalTimeoutConstant = readTimeout;
			lock (this._timeoutsLock)
			{
				flag = this._nativeAPISet.WrapperSetCommTimeouts(this._fileHandle, ref commTimeouts);
			}
			if (flag)
			{
				this._commTimeouts.ReadTotalTimeoutConstant = readTimeout;
			}
			return flag;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000073F0 File Offset: 0x000055F0
		private bool SetWriteTimeout(uint writeTimeout)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommTimeouts commTimeouts = this.CreateAndIniTimeouts(false);
			commTimeouts.WriteTotalTimeoutConstant = writeTimeout;
			lock (this._timeoutsLock)
			{
				flag = this._nativeAPISet.WrapperSetCommTimeouts(this._fileHandle, ref commTimeouts);
			}
			if (flag)
			{
				this._commTimeouts.WriteTotalTimeoutConstant = writeTimeout;
			}
			return flag;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00007460 File Offset: 0x00005660
		private global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommTimeouts CreateAndIniTimeouts(bool bInit)
		{
			global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommTimeouts result = default(global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommTimeouts);
			if (bInit)
			{
				result.ReadIntervalTimeout = 0U;
				result.ReadTotalTimeoutConstant = 0U;
				result.ReadTotalTimeoutMultiplier = 0U;
				result.WriteTotalTimeoutConstant = 0U;
				result.WriteTotalTimeoutMultiplier = 0U;
			}
			else
			{
				result.ReadIntervalTimeout = this._commTimeouts.ReadIntervalTimeout;
				result.ReadTotalTimeoutConstant = this._commTimeouts.ReadTotalTimeoutConstant;
				result.ReadTotalTimeoutMultiplier = this._commTimeouts.ReadTotalTimeoutMultiplier;
				result.WriteTotalTimeoutConstant = this._commTimeouts.WriteTotalTimeoutConstant;
				result.WriteTotalTimeoutMultiplier = this._commTimeouts.WriteTotalTimeoutMultiplier;
			}
			return result;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000074FD File Offset: 0x000056FD
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000750C File Offset: 0x0000570C
		protected virtual void Dispose(bool isDisposing)
		{
			if (!this._disposed)
			{
				try
				{
					this.ReleaseResource();
				}
				finally
				{
					this._disposed = true;
				}
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00007544 File Offset: 0x00005744
		protected virtual void ReleaseResource()
		{
			lock (this._openCloseLock)
			{
				if ((int)this._fileHandle != -1)
				{
					this._nativeAPISet.WrapperCloseHandle(this._fileHandle);
					this._fileHandle = (global::System.IntPtr)(-1);
				}
				if ((int)this._writeEvent != -1)
				{
					this._nativeAPISet.WrapperCloseHandle(this._writeEvent);
					this._writeEvent = (global::System.IntPtr)(-1);
				}
				if ((int)this._readEvent != -1)
				{
					this._nativeAPISet.WrapperCloseHandle(this._readEvent);
					this._readEvent = (global::System.IntPtr)(-1);
				}
				if (this._olRead != global::System.IntPtr.Zero)
				{
					global::System.Runtime.InteropServices.Marshal.FreeHGlobal(this._olRead);
					this._olRead = global::System.IntPtr.Zero;
				}
				if (this._olWrite != global::System.IntPtr.Zero)
				{
					global::System.Runtime.InteropServices.Marshal.FreeHGlobal(this._olWrite);
					this._olWrite = global::System.IntPtr.Zero;
				}
				this._bOpen = false;
			}
		}

		// Token: 0x040000BA RID: 186
		private global::Motorola.Common.Communication.TetraUtility.WinAPIWrapper _nativeAPISet;

		// Token: 0x040000BB RID: 187
		private int _baudRate;

		// Token: 0x040000BC RID: 188
		private string _portName;

		// Token: 0x040000BD RID: 189
		private int _dataBit;

		// Token: 0x040000BE RID: 190
		private global::System.IO.Ports.Parity _parity;

		// Token: 0x040000BF RID: 191
		private global::System.IO.Ports.StopBits _stopBits;

		// Token: 0x040000C0 RID: 192
		private bool _rtsEnable;

		// Token: 0x040000C1 RID: 193
		private bool _dtrEnable;

		// Token: 0x040000C2 RID: 194
		private int _writeBufferSize;

		// Token: 0x040000C3 RID: 195
		private int _readBufferSize;

		// Token: 0x040000C4 RID: 196
		private int _writeTimeout;

		// Token: 0x040000C5 RID: 197
		private int _readTimeout;

		// Token: 0x040000C6 RID: 198
		private bool _bOpen;

		// Token: 0x040000C7 RID: 199
		private global::System.IntPtr _fileHandle;

		// Token: 0x040000C8 RID: 200
		private global::System.IntPtr _readEvent;

		// Token: 0x040000C9 RID: 201
		private global::System.IntPtr _writeEvent;

		// Token: 0x040000CA RID: 202
		private global::System.IntPtr _olRead;

		// Token: 0x040000CB RID: 203
		private global::System.IntPtr _olWrite;

		// Token: 0x040000CC RID: 204
		private global::Motorola.Common.Communication.TetraUtility.NativeMethods.DCB _dcb;

		// Token: 0x040000CD RID: 205
		private global::Motorola.Common.Communication.TetraUtility.NativeMethods.CommTimeouts _commTimeouts;

		// Token: 0x040000CE RID: 206
		private object _rWLock = new object();

		// Token: 0x040000CF RID: 207
		private object _purgeLock = new object();

		// Token: 0x040000D0 RID: 208
		private object _timeoutsLock = new object();

		// Token: 0x040000D1 RID: 209
		private object _openCloseLock = new object();

		// Token: 0x040000D2 RID: 210
		private bool _disposed;

		// Token: 0x040000D3 RID: 211
		private string _usbHubInstance = string.Empty;

		// Token: 0x040000D4 RID: 212
		private uint _usbHubPortNum;
	}
}
