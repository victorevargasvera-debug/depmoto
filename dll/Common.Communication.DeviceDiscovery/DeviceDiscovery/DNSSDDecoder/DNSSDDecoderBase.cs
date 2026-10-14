using System;
using Motorola.Common.Communication;
using Motorola.Common.Communication.DeviceDiscovery;

namespace DeviceDiscovery.DNSSDDecoder
{
	// Token: 0x0200000C RID: 12
	internal abstract class DNSSDDecoderBase
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000052 RID: 82
		public abstract string PID { get; }

		// Token: 0x06000053 RID: 83
		public abstract void Attach();

		// Token: 0x06000054 RID: 84
		public abstract void Detach();

		// Token: 0x04000026 RID: 38
		protected global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile;

		// Token: 0x04000027 RID: 39
		protected global::Motorola.Common.Communication.RecordPTR ptr;

		// Token: 0x04000028 RID: 40
		protected global::Motorola.Common.Communication.DnsResponseMessage response;
	}
}
