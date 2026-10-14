using System;

namespace Motorola.Common.Communication.RUDP.Helper
{
	// Token: 0x02000004 RID: 4
	internal interface IObjectSerializer
	{
		// Token: 0x06000016 RID: 22
		object[] GetObjectList();

		// Token: 0x06000017 RID: 23
		void SetObjectList(object[] list);

		// Token: 0x06000018 RID: 24
		int Serialize(byte[] buffer, int offset);

		// Token: 0x06000019 RID: 25
		int Deserialize(byte[] buffer, int start, int len);
	}
}
