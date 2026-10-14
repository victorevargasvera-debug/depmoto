using System;
using System.Collections.Generic;
using System.Net;

namespace Motorola.Common.Communication.SequenceManager
{
	// Token: 0x02000004 RID: 4
	public class CSAVMHelper
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000259C File Offset: 0x0000079C
		public static global::System.Array GetAllVMTypes()
		{
			return global::System.Enum.GetValues(typeof(global::Motorola.Common.Communication.SequenceManager.CSAVMType));
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000025C0 File Offset: 0x000007C0
		public static void GetVMConnectionDetails(global::System.Net.IPAddress rootIP, global::Motorola.Common.Communication.SequenceManager.CSAVMType vmType, out global::System.Net.IPAddress vmIP, out int vmPort)
		{
			byte[] addressBytes = rootIP.GetAddressBytes();
			switch (vmType)
			{
			case global::Motorola.Common.Communication.SequenceManager.CSAVMType.TC_IM:
				vmIP = new global::System.Net.IPAddress(addressBytes);
				vmPort = 35000;
				break;
			case global::Motorola.Common.Communication.SequenceManager.CSAVMType.UEM:
			{
				byte[] array = addressBytes;
				int num = addressBytes.Length - 1;
				array[num] += 1;
				vmIP = new global::System.Net.IPAddress(addressBytes);
				vmPort = 35000;
				break;
			}
			case global::Motorola.Common.Communication.SequenceManager.CSAVMType.MNIS:
			{
				byte[] array2 = addressBytes;
				int num2 = addressBytes.Length - 1;
				array2[num2] += 2;
				vmIP = new global::System.Net.IPAddress(addressBytes);
				vmPort = 35000;
				break;
			}
			case global::Motorola.Common.Communication.SequenceManager.CSAVMType.VM4:
			{
				byte[] array3 = addressBytes;
				int num3 = addressBytes.Length - 1;
				array3[num3] += 4;
				vmIP = new global::System.Net.IPAddress(addressBytes);
				vmPort = 35000;
				break;
			}
			default:
				throw new global::System.ArgumentOutOfRangeException(string.Format("Unable to generate VM URL. VM ID {0} is not valid.", vmType));
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000269C File Offset: 0x0000089C
		public static global::System.Collections.Generic.List<string> GetSupportedConfigFiles(global::Motorola.Common.Communication.SequenceManager.CSAVMType vmType)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			switch (vmType)
			{
			case global::Motorola.Common.Communication.SequenceManager.CSAVMType.TC_IM:
				list.Add("TG");
				list.Add("SAC");
				list.Add("System");
				list.Add("License");
				list.Add("AdjSites");
				list.Add("SiteAnnounce");
				break;
			case global::Motorola.Common.Communication.SequenceManager.CSAVMType.MNIS:
				list.Add("MNIS");
				break;
			}
			return list;
		}

		// Token: 0x04000008 RID: 8
		public const int PROVPORT = 35000;
	}
}
