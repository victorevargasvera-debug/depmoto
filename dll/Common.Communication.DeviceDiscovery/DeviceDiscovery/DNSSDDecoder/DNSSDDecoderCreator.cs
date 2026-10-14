using System;

namespace DeviceDiscovery.DNSSDDecoder
{
	// Token: 0x0200000E RID: 14
	internal class DNSSDDecoderCreator
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002D98 File Offset: 0x00000F98
		internal static global::DeviceDiscovery.DNSSDDecoder.DNSSDDecoderBase CreateDNSSDDecoder(string domainName)
		{
			global::DeviceDiscovery.DNSSDDecoder.DNSSDDecoderBase result = null;
			if (domainName.Contains("futon") || domainName.Contains("Fusion"))
			{
				result = new global::DeviceDiscovery.DNSSDDecoder.FutonDecoder();
			}
			else if (domainName.Contains("APX "))
			{
				result = new global::DeviceDiscovery.DNSSDDecoder.ASTRODecoder();
			}
			else if (domainName.Contains("MOTOTRBO_"))
			{
				result = new global::DeviceDiscovery.DNSSDDecoder.PCRDecoder();
			}
			return result;
		}

		// Token: 0x04000029 RID: 41
		private const string MOTOTRBO_Prefix = "MOTOTRBO_";

		// Token: 0x0400002A RID: 42
		private const string ASTRO_Prefix = "APX ";

		// Token: 0x0400002B RID: 43
		private const string FUTON_Prefix = "futon";

		// Token: 0x0400002C RID: 44
		private const string FUSION_Prefix = "Fusion";
	}
}
