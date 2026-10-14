using System;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x0200000A RID: 10
	public interface IServerWorker
	{
		// Token: 0x06000040 RID: 64
		void Close();

		// Token: 0x06000041 RID: 65
		void Read();
	}
}
