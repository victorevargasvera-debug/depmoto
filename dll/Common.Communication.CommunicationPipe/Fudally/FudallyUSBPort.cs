using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32.SafeHandles;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationPipe.Fudally
{
	// Token: 0x02000007 RID: 7
	public class FudallyUSBPort
	{
		// Token: 0x0600002B RID: 43 RVA: 0x000028C1 File Offset: 0x00000AC1
		public FudallyUSBPort()
		{
			this.hRead = null;
			this.hWrite = null;
			this.isOpen = false;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000028E0 File Offset: 0x00000AE0
		internal bool Open(string path)
		{
			if (string.IsNullOrWhiteSpace(path))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			global::System.Text.StringBuilder inPipe = new global::System.Text.StringBuilder("0");
			global::System.Text.StringBuilder outPipe = new global::System.Text.StringBuilder("1");
			global::System.Text.StringBuilder devPath = new global::System.Text.StringBuilder(path);
			this.hRead = global::Motorola.Common.Communication.CommunicationPipe.Fudally.NativeMethods.fudallyUSB_openRead(devPath, outPipe);
			if (this.hRead.IsInvalid)
			{
				return false;
			}
			global::Motorola.Common.Communication.CommunicationPipe.Fudally.fudallyUSB_DEVICE_DESCRIPTOR fudallyUSB_DEVICE_DESCRIPTOR = default(global::Motorola.Common.Communication.CommunicationPipe.Fudally.fudallyUSB_DEVICE_DESCRIPTOR);
			if (global::Motorola.Common.Communication.CommunicationPipe.Fudally.NativeMethods.fudallyUSB_getDevDescriptor(this.hRead, ref fudallyUSB_DEVICE_DESCRIPTOR) != 0 || fudallyUSB_DEVICE_DESCRIPTOR.idVendor != 3245 || fudallyUSB_DEVICE_DESCRIPTOR.idProduct != 4096)
			{
				this.hRead.Close();
				return false;
			}
			this.hWrite = global::Motorola.Common.Communication.CommunicationPipe.Fudally.NativeMethods.fudallyUSB_openWrite(devPath, inPipe);
			if (this.hWrite.IsInvalid)
			{
				this.hRead.Close();
				return false;
			}
			this.isOpen = true;
			return true;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000029A8 File Offset: 0x00000BA8
		internal void Close()
		{
			if (!this.isOpen)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			}
			this.isOpen = false;
			if (!this.hRead.IsClosed)
			{
				this.hRead.Close();
			}
			this.hRead = null;
			if (!this.hWrite.IsClosed)
			{
				this.hWrite.Close();
			}
			this.hWrite = null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002A0D File Offset: 0x00000C0D
		internal int Read(byte[] buffer, uint timeout)
		{
			if (!this.isOpen)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			}
			if (buffer == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (buffer.Length <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			return global::Motorola.Common.Communication.CommunicationPipe.Fudally.NativeMethods.fudallyUSB_read(this.hRead, buffer, (uint)buffer.Length, timeout);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002A49 File Offset: 0x00000C49
		internal int Write(byte[] buffer, uint timeout)
		{
			if (!this.isOpen)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
			}
			if (buffer == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (buffer.Length <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			return global::Motorola.Common.Communication.CommunicationPipe.Fudally.NativeMethods.fudallyUSB_write(this.hWrite, buffer, (uint)buffer.Length, timeout);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002A88 File Offset: 0x00000C88
		public static global::System.Collections.Generic.List<string> ListConnectedDevices()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1024);
			int num = 0;
			while (global::Motorola.Common.Communication.CommunicationPipe.Fudally.NativeMethods.fudallyUSB_getFilename(num++, stringBuilder) == 0)
			{
				list.Add(stringBuilder.ToString());
			}
			return list;
		}

		// Token: 0x0400002C RID: 44
		private global::Microsoft.Win32.SafeHandles.SafeFileHandle hRead;

		// Token: 0x0400002D RID: 45
		private global::Microsoft.Win32.SafeHandles.SafeFileHandle hWrite;

		// Token: 0x0400002E RID: 46
		private bool isOpen;
	}
}
