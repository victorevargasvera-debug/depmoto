using System;
using System.IO;
using System.Security.Cryptography;

namespace AcpCryptoLib
{
	// Token: 0x02000005 RID: 5
	public class AcpCryptoStream : global::AcpCryptoLib.AcpCryptoBase, global::AcpCryptoLib.IAcpCryptoStream, global::System.IDisposable
	{
		// Token: 0x0600000E RID: 14 RVA: 0x0000245C File Offset: 0x0000065C
		public global::System.IO.Stream GetWriter(global::System.IO.Stream stream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("Stream has a null reference.");
			}
			try
			{
				global::AcpCryptoLib.AcpCryptoHeader acpCryptoHeader = new global::AcpCryptoLib.AcpCryptoHeader();
				stream.Write(acpCryptoHeader.Data, 0, acpCryptoHeader.Data.Length);
				global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = (global::System.Security.Cryptography.SymmetricAlgorithm)acpCryptoHeader.Key;
				global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateEncryptor();
				if (this.cryptWriter != null)
				{
					this.cryptWriter.FlushFinalBlock();
					this.cryptWriter.Close();
				}
				this.cryptWriter = new global::System.Security.Cryptography.CryptoStream(stream, transform, global::System.Security.Cryptography.CryptoStreamMode.Write);
				byte[] array = global::AcpCryptoLib.AcpRNGenerator.GenerateSalt(7, 128);
				this.cryptWriter.Write(array, 0, array.Length);
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception("AcpCryptoStream.GetWriter - Exception: " + ex.Message);
			}
			return this.cryptWriter;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002520 File Offset: 0x00000720
		public global::System.IO.Stream GetReader(global::System.IO.Stream stream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("Stream has a null reference.");
			}
			try
			{
				byte[] encrytedData = base.ExtractHeader(stream);
				global::AcpCryptoLib.AcpCryptoHeader acpCryptoHeader = new global::AcpCryptoLib.AcpCryptoHeader(encrytedData);
				global::System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm = (global::System.Security.Cryptography.SymmetricAlgorithm)acpCryptoHeader.Key;
				global::System.Security.Cryptography.ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor();
				if (this.cryptReader != null)
				{
					this.cryptReader.Close();
				}
				this.cryptReader = new global::System.Security.Cryptography.CryptoStream(stream, transform, global::System.Security.Cryptography.CryptoStreamMode.Read);
				base.ExtractSalt(this.cryptReader);
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception("AcpCryptoStream.GetReader - Exception: " + ex.Message);
			}
			return this.cryptReader;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000025BC File Offset: 0x000007BC
		public void Dispose()
		{
			try
			{
				if (this.cryptReader != null)
				{
					this.cryptReader.Close();
				}
				if (this.cryptWriter != null)
				{
					this.cryptWriter.FlushFinalBlock();
					this.cryptWriter.Close();
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x04000004 RID: 4
		private global::System.Security.Cryptography.CryptoStream cryptWriter;

		// Token: 0x04000005 RID: 5
		private global::System.Security.Cryptography.CryptoStream cryptReader;
	}
}
