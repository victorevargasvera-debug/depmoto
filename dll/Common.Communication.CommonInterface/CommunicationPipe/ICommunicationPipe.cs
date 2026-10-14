using System;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000007 RID: 7
	public interface ICommunicationPipe
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000027 RID: 39
		// (set) Token: 0x06000028 RID: 40
		int ReceiveTimeout { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000029 RID: 41
		// (set) Token: 0x0600002A RID: 42
		bool IsOpen { get; set; }

		// Token: 0x0600002B RID: 43
		void OpenPort(int timeout);

		// Token: 0x0600002C RID: 44
		void ClosePort();

		// Token: 0x0600002D RID: 45
		void SendData(byte[] buffer, int start, int length);

		// Token: 0x0600002E RID: 46
		byte[] ReceiveData();

		// Token: 0x0600002F RID: 47
		byte[] ReceiveData(int timeout);

		// Token: 0x06000030 RID: 48
		int ReceiveData(byte[] buffer, int start);

		// Token: 0x06000031 RID: 49
		int ReceiveData(byte[] buffer, int start, int timeout);

		// Token: 0x06000032 RID: 50
		int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength);

		// Token: 0x06000033 RID: 51
		byte[] RequestData(byte[] buffer, int start, int length);

		// Token: 0x06000034 RID: 52
		byte[] RequestData(byte[] buffer, int start, int length, int timeout);

		// Token: 0x06000035 RID: 53
		byte[] PeekData(int length, int timeOut);

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000036 RID: 54
		int AvailableReadBytesCount { get; }
	}
}
