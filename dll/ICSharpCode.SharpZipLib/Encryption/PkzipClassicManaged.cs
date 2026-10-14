using System;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x02000024 RID: 36
	public sealed class PkzipClassicManaged : global::ICSharpCode.SharpZipLib.Encryption.PkzipClassic
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00007E3E File Offset: 0x00006E3E
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00007E41 File Offset: 0x00006E41
		public override int BlockSize
		{
			get
			{
				return 8;
			}
			set
			{
				if (value != 8)
				{
					throw new global::System.Security.Cryptography.CryptographicException("Block size is invalid");
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00007E54 File Offset: 0x00006E54
		public override global::System.Security.Cryptography.KeySizes[] LegalKeySizes
		{
			get
			{
				return new global::System.Security.Cryptography.KeySizes[]
				{
					new global::System.Security.Cryptography.KeySizes(96, 96, 0)
				};
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007E76 File Offset: 0x00006E76
		public override void GenerateIV()
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00007E78 File Offset: 0x00006E78
		public override global::System.Security.Cryptography.KeySizes[] LegalBlockSizes
		{
			get
			{
				return new global::System.Security.Cryptography.KeySizes[]
				{
					new global::System.Security.Cryptography.KeySizes(8, 8, 0)
				};
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00007E98 File Offset: 0x00006E98
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00007EB8 File Offset: 0x00006EB8
		public override byte[] Key
		{
			get
			{
				if (this.key_ == null)
				{
					this.GenerateKey();
				}
				return (byte[])this.key_.Clone();
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				if (value.Length != 12)
				{
					throw new global::System.Security.Cryptography.CryptographicException("Key size is illegal");
				}
				this.key_ = (byte[])value.Clone();
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007EEC File Offset: 0x00006EEC
		public override void GenerateKey()
		{
			this.key_ = new byte[12];
			global::System.Random random = new global::System.Random();
			random.NextBytes(this.key_);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007F18 File Offset: 0x00006F18
		public override global::System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			this.key_ = rgbKey;
			return new global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicEncryptCryptoTransform(this.Key);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00007F2C File Offset: 0x00006F2C
		public override global::System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			this.key_ = rgbKey;
			return new global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicDecryptCryptoTransform(this.Key);
		}

		// Token: 0x0400008A RID: 138
		private byte[] key_;
	}
}
