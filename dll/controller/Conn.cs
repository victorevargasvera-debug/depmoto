using System;
using CommunicationController;

namespace Controller
{
	// Token: 0x0200000D RID: 13
	public struct Conn
	{
		// Token: 0x040000C6 RID: 198
		public uint ST_Handle;

		// Token: 0x040000C7 RID: 199
		public global::CommunicationController.IRadioCodeplugController RCI;

		// Token: 0x040000C8 RID: 200
		public global::CommunicationController.ISerialTransportController ST;

		// Token: 0x040000C9 RID: 201
		public string IP_Address;

		// Token: 0x040000CA RID: 202
		public string UUID;

		// Token: 0x040000CB RID: 203
		public string ModelNumber;

		// Token: 0x040000CC RID: 204
		public string SerialNumber;

		// Token: 0x040000CD RID: 205
		public string RadioType;

		// Token: 0x040000CE RID: 206
		public string ProductType;

		// Token: 0x040000CF RID: 207
		public uint DB;

		// Token: 0x040000D0 RID: 208
		public object objDB;
	}
}
