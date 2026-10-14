using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace Motorola.Common.Communication.SequenceManager.PbaFileProcessing
{
	// Token: 0x02000022 RID: 34
	internal static class WiFiUtility
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00005A48 File Offset: 0x00003C48
		public static byte[] getHashSha256(byte[] bytes)
		{
			byte[] result;
			using (global::System.Security.Cryptography.SHA256Managed sha256Managed = new global::System.Security.Cryptography.SHA256Managed())
			{
				result = sha256Managed.ComputeHash(bytes);
			}
			return result;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00005A90 File Offset: 0x00003C90
		public static byte[] Encrypt(byte[] plainBytes)
		{
			string path = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\MetaData\\PCR\\resource\\msi_pcr.pem";
			byte[] result;
			using (global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider())
			{
				global::System.Security.Cryptography.RSAParameters parameters = rsacryptoServiceProvider.ExportParameters(false);
				parameters.Modulus = global::System.Convert.FromBase64String(global::System.IO.File.ReadAllText(path).Replace("-----BEGIN PUBLIC KEY-----", "").Replace("-----END PUBLIC KEY-----", ""));
				rsacryptoServiceProvider.ImportParameters(parameters);
				result = rsacryptoServiceProvider.Encrypt(plainBytes, false);
			}
			return result;
		}
	}
}
