using System;
using System.Runtime.InteropServices;
using custom_datatypes;

namespace LEAdaptor
{
	// Token: 0x02000013 RID: 19
	public interface IMRemoteSystem : global::System.IDisposable
	{
		// Token: 0x06000104 RID: 260
		int Open();

		// Token: 0x06000105 RID: 261
		int Close();

		// Token: 0x06000106 RID: 262
		int SendProxyConnectRequest(uint targetPeerID, uint sourceIP, ushort sourcePort, byte connectionType, out ushort response);

		// Token: 0x06000107 RID: 263
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		bool GetPeerMapData(out global::custom_datatypes.MLEPeer[] peers);

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000108 RID: 264
		// (remove) Token: 0x06000109 RID: 265
		event global::LEAdaptor.StatusChangeHandler OnStatusChange;
	}
}
