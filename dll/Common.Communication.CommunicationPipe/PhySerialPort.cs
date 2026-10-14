using System;
using System.IO.Ports;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x0200001C RID: 28
	internal class PhySerialPort : global::System.IO.Ports.SerialPort, global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00006973 File Offset: 0x00004B73
		int global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.get_BaudRate()
		{
			return base.BaudRate;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000697B File Offset: 0x00004B7B
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.set_BaudRate(int A_1)
		{
			base.BaudRate = A_1;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00006984 File Offset: 0x00004B84
		string global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.get_PortName()
		{
			return base.PortName;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000698C File Offset: 0x00004B8C
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.set_PortName(string A_1)
		{
			base.PortName = A_1;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00006995 File Offset: 0x00004B95
		int global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.get_DataBits()
		{
			return base.DataBits;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000699D File Offset: 0x00004B9D
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.set_DataBits(int A_1)
		{
			base.DataBits = A_1;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000069A6 File Offset: 0x00004BA6
		global::System.IO.Ports.Parity global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.get_Parity()
		{
			return base.Parity;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000069AE File Offset: 0x00004BAE
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.set_Parity(global::System.IO.Ports.Parity A_1)
		{
			base.Parity = A_1;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000069B7 File Offset: 0x00004BB7
		global::System.IO.Ports.StopBits global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.get_StopBits()
		{
			return base.StopBits;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000069BF File Offset: 0x00004BBF
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.set_StopBits(global::System.IO.Ports.StopBits A_1)
		{
			base.StopBits = A_1;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000069C8 File Offset: 0x00004BC8
		bool global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.get_RtsEnable()
		{
			return base.RtsEnable;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000069D0 File Offset: 0x00004BD0
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.set_RtsEnable(bool A_1)
		{
			base.RtsEnable = A_1;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000069D9 File Offset: 0x00004BD9
		bool global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.get_DtrEnable()
		{
			return base.DtrEnable;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000069E1 File Offset: 0x00004BE1
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.set_DtrEnable(bool A_1)
		{
			base.DtrEnable = A_1;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000069EA File Offset: 0x00004BEA
		int global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.get_WriteBufferSize()
		{
			return base.WriteBufferSize;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000069F2 File Offset: 0x00004BF2
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.set_WriteBufferSize(int A_1)
		{
			base.WriteBufferSize = A_1;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000069FB File Offset: 0x00004BFB
		int global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.get_ReadBufferSize()
		{
			return base.ReadBufferSize;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00006A03 File Offset: 0x00004C03
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.set_ReadBufferSize(int A_1)
		{
			base.ReadBufferSize = A_1;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00006A0C File Offset: 0x00004C0C
		int global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.get_WriteTimeout()
		{
			return base.WriteTimeout;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00006A14 File Offset: 0x00004C14
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.set_WriteTimeout(int A_1)
		{
			base.WriteTimeout = A_1;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006A1D File Offset: 0x00004C1D
		int global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.get_ReadTimeout()
		{
			return base.ReadTimeout;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00006A25 File Offset: 0x00004C25
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.set_ReadTimeout(int A_1)
		{
			base.ReadTimeout = A_1;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00006A2E File Offset: 0x00004C2E
		bool global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.get_IsOpen()
		{
			return base.IsOpen;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00006A36 File Offset: 0x00004C36
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.Open()
		{
			base.Open();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00006A3E File Offset: 0x00004C3E
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.Close()
		{
			base.Close();
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00006A46 File Offset: 0x00004C46
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.DiscardOutBuffer()
		{
			base.DiscardOutBuffer();
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00006A4E File Offset: 0x00004C4E
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.DiscardInBuffer()
		{
			base.DiscardInBuffer();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00006A56 File Offset: 0x00004C56
		int global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.Read(byte[] A_1, int A_2, int A_3)
		{
			return base.Read(A_1, A_2, A_3);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00006A61 File Offset: 0x00004C61
		void global::Motorola.Common.Communication.CommunicationPipe.ISerialCommPort.Write(byte[] A_1, int A_2, int A_3)
		{
			base.Write(A_1, A_2, A_3);
		}
	}
}
