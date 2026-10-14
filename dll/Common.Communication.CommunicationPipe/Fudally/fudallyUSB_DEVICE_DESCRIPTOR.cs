using System;

namespace Motorola.Common.Communication.CommunicationPipe.Fudally
{
	// Token: 0x02000006 RID: 6
	internal struct fudallyUSB_DEVICE_DESCRIPTOR
	{
		// Token: 0x0400001E RID: 30
		public byte bLength;

		// Token: 0x0400001F RID: 31
		public byte bDescriptorType;

		// Token: 0x04000020 RID: 32
		public ushort bdcUSB;

		// Token: 0x04000021 RID: 33
		public byte bDeviceClass;

		// Token: 0x04000022 RID: 34
		public byte bDeviceSubClass;

		// Token: 0x04000023 RID: 35
		public byte bDeviceProtocol;

		// Token: 0x04000024 RID: 36
		public byte bMaxPacketSize;

		// Token: 0x04000025 RID: 37
		public ushort idVendor;

		// Token: 0x04000026 RID: 38
		public ushort idProduct;

		// Token: 0x04000027 RID: 39
		public ushort bcdDevice;

		// Token: 0x04000028 RID: 40
		public byte iManufacturer;

		// Token: 0x04000029 RID: 41
		public byte iProduct;

		// Token: 0x0400002A RID: 42
		public byte iSerialNumber;

		// Token: 0x0400002B RID: 43
		public byte bNumConfigurations;
	}
}
