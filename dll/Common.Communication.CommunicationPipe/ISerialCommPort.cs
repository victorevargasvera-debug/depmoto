using System;
using System.IO.Ports;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000011 RID: 17
	internal interface ISerialCommPort
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000EC RID: 236
		// (set) Token: 0x060000ED RID: 237
		int BaudRate { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000EE RID: 238
		// (set) Token: 0x060000EF RID: 239
		string PortName { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000F0 RID: 240
		// (set) Token: 0x060000F1 RID: 241
		int DataBits { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000F2 RID: 242
		// (set) Token: 0x060000F3 RID: 243
		global::System.IO.Ports.Parity Parity { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000F4 RID: 244
		// (set) Token: 0x060000F5 RID: 245
		global::System.IO.Ports.StopBits StopBits { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F6 RID: 246
		// (set) Token: 0x060000F7 RID: 247
		bool RtsEnable { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F8 RID: 248
		// (set) Token: 0x060000F9 RID: 249
		bool DtrEnable { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000FA RID: 250
		// (set) Token: 0x060000FB RID: 251
		int WriteBufferSize { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000FC RID: 252
		// (set) Token: 0x060000FD RID: 253
		int ReadBufferSize { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000FE RID: 254
		// (set) Token: 0x060000FF RID: 255
		int WriteTimeout { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000100 RID: 256
		// (set) Token: 0x06000101 RID: 257
		int ReadTimeout { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000102 RID: 258
		bool IsOpen { get; }

		// Token: 0x06000103 RID: 259
		void Open();

		// Token: 0x06000104 RID: 260
		void Close();

		// Token: 0x06000105 RID: 261
		void DiscardOutBuffer();

		// Token: 0x06000106 RID: 262
		void DiscardInBuffer();

		// Token: 0x06000107 RID: 263
		int Read(byte[] buffer, int offset, int count);

		// Token: 0x06000108 RID: 264
		void Write(byte[] buffer, int offset, int count);
	}
}
