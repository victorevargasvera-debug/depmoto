using System;
using SSLMangrComp.Connectors;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000005 RID: 5
	internal interface IClientServerConnector : global::SSLMangrComp.Connectors.IClientConnector, global::SSLMangrComp.ConnectionLayer.IServerListener
	{
		// Token: 0x0600000F RID: 15
		void SetTimeOutVal(int secsTime);
	}
}
