using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace fxpcommunication
{
	// Token: 0x0200000D RID: 13
	internal class VersionMapping
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00003D24 File Offset: 0x00001F24
		private static global::System.Collections.Generic.Dictionary<global::fxpcommunication.ProtocolVersionEnum, global::System.Security.Cryptography.SymmetricAlgorithm> InitCryptoVersionMappingTable()
		{
			global::System.Collections.Generic.Dictionary<global::fxpcommunication.ProtocolVersionEnum, global::System.Security.Cryptography.SymmetricAlgorithm> dictionary = new global::System.Collections.Generic.Dictionary<global::fxpcommunication.ProtocolVersionEnum, global::System.Security.Cryptography.SymmetricAlgorithm>();
			global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = null;
			try
			{
				symmetricAlgorithm = new global::System.Security.Cryptography.AesCryptoServiceProvider();
				symmetricAlgorithm.BlockSize = 128;
				symmetricAlgorithm.KeySize = 256;
				symmetricAlgorithm.Padding = global::System.Security.Cryptography.PaddingMode.None;
				dictionary.Add(global::fxpcommunication.ProtocolVersionEnum.eAes256, symmetricAlgorithm);
				symmetricAlgorithm = null;
			}
			finally
			{
				if (symmetricAlgorithm != null)
				{
					symmetricAlgorithm.Dispose();
				}
			}
			return dictionary;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003DA0 File Offset: 0x00001FA0
		public static bool IsProtocolVersionSupport(global::fxpcommunication.ProtocolVersionEnum protocolVersion)
		{
			return global::fxpcommunication.VersionMapping.CryptoVersionMappingTable.ContainsKey(protocolVersion);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003DC0 File Offset: 0x00001FC0
		public static global::System.Security.Cryptography.SymmetricAlgorithm GetCryptoByProtocolVersion(global::fxpcommunication.ProtocolVersionEnum protocolVersion)
		{
			return global::fxpcommunication.VersionMapping.CryptoVersionMappingTable[protocolVersion];
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003DE0 File Offset: 0x00001FE0
		public static global::fxpcommunication.ProtocolVersionEnum GetProtocolVersionByFWVersion(string FWVersion)
		{
			global::fxpcommunication.ProtocolVersionEnum result;
			if (FWVersion.StartsWith("R", global::System.StringComparison.OrdinalIgnoreCase))
			{
				result = global::fxpcommunication.ProtocolVersionEnum.eAes256;
			}
			else
			{
				result = global::fxpcommunication.ProtocolVersionEnum.eAes256;
			}
			return result;
		}

		// Token: 0x04000059 RID: 89
		private static global::System.Collections.Generic.Dictionary<global::fxpcommunication.ProtocolVersionEnum, global::System.Security.Cryptography.SymmetricAlgorithm> CryptoVersionMappingTable = global::fxpcommunication.VersionMapping.InitCryptoVersionMappingTable();
	}
}
