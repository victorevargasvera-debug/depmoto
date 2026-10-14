using System;
using System.Runtime.InteropServices;
using System.Text;
using OpenSSL.Core;

namespace OpenSSL
{
	// Token: 0x02000063 RID: 99
	internal class SslCipher : global::OpenSSL.Core.Base, global::OpenSSL.Core.IStackable
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x00006973 File Offset: 0x00004B73
		public SslCipher() : this(global::System.IntPtr.Zero, false)
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00006981 File Offset: 0x00004B81
		public SslCipher(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
			this.Initialize();
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00006991 File Offset: 0x00004B91
		internal SslCipher(global::OpenSSL.Core.IStack stack, global::System.IntPtr ptr) : base(ptr, true)
		{
			this.Initialize();
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x000069A1 File Offset: 0x00004BA1
		public string Name
		{
			get
			{
				return global::OpenSSL.Core.Native.SSL_CIPHER_name(this.ptr);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x000069B0 File Offset: 0x00004BB0
		public string Description
		{
			get
			{
				byte[] array = new byte[512];
				global::OpenSSL.Core.Native.SSL_CIPHER_description(this.ptr, array, array.Length);
				return global::System.Text.Encoding.ASCII.GetString(array);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x000069E8 File Offset: 0x00004BE8
		public int Strength
		{
			get
			{
				this.Initialize();
				if (this.cipherStrength == 0)
				{
					int num = 0;
					return global::OpenSSL.Core.Native.SSL_CIPHER_get_bits(this.Handle, out num);
				}
				return this.cipherStrength;
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00006A19 File Offset: 0x00004C19
		private bool IsExport(uint algo_strength)
		{
			return (algo_strength & 2U) > 0U;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00006A21 File Offset: 0x00004C21
		private int ExportPrivateKeyLength(uint algo_strength)
		{
			if ((algo_strength & 8U) > 0U)
			{
				return 512;
			}
			return 1024;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00006A34 File Offset: 0x00004C34
		private int ExportKeyLength(uint algorithms, uint algo_strength)
		{
			if ((algo_strength & 8U) > 0U)
			{
				return 5;
			}
			if ((algorithms & 4095U) == 1U)
			{
				return 8;
			}
			return 7;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00006A4C File Offset: 0x00004C4C
		private void Initialize()
		{
			if (this.ptr == global::System.IntPtr.Zero || this.isInitialized)
			{
				return;
			}
			this.isInitialized = true;
			this.raw = (global::OpenSSL.SslCipher.SSL_CIPHER)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.SslCipher.SSL_CIPHER));
			bool flag = this.IsExport(this.raw.algo_strength);
			int num = this.ExportPrivateKeyLength(this.raw.algo_strength);
			int num2 = this.ExportKeyLength(this.raw.algorithm_enc, this.raw.algo_strength);
			if ((this.raw.algorithm_ssl & 1U) == 1U)
			{
				this.sslProtocol = global::OpenSSL.SslProtocols.Ssl2;
			}
			else if ((this.raw.algorithm_ssl & 2U) == 2U)
			{
				this.sslProtocol = global::OpenSSL.SslProtocols.Tls;
			}
			this.keyExchangeStrength = num;
			uint num3 = this.raw.algorithm_mkey & 1023U;
			if (num3 <= 16U)
			{
				switch (num3)
				{
				case 1U:
					this.keyExchangeAlgorithm = global::OpenSSL.ExchangeAlgorithmType.RsaKeyX;
					goto IL_12A;
				case 2U:
				case 4U:
					break;
				case 3U:
					goto IL_12A;
				default:
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_12A;
						}
						goto IL_11A;
					}
					break;
				}
				this.keyExchangeAlgorithm = global::OpenSSL.ExchangeAlgorithmType.DiffieHellman;
				goto IL_12A;
			}
			if (num3 != 48U)
			{
				if (num3 != 64U && num3 != 128U)
				{
					goto IL_12A;
				}
				this.keyExchangeAlgorithm = global::OpenSSL.ExchangeAlgorithmType.ECDiffieHellman;
				goto IL_12A;
			}
			IL_11A:
			this.keyExchangeAlgorithm = global::OpenSSL.ExchangeAlgorithmType.Kerberos;
			IL_12A:
			uint num4 = this.raw.algorithm_auth & 1023U;
			if (num4 <= 8U)
			{
				switch (num4)
				{
				case 1U:
					this.authMethod = global::OpenSSL.AuthenticationMethod.Rsa;
					break;
				case 2U:
					this.authMethod = global::OpenSSL.AuthenticationMethod.Dss;
					break;
				case 3U:
					break;
				case 4U:
					this.authMethod = global::OpenSSL.AuthenticationMethod.None;
					break;
				default:
					if (num4 == 8U)
					{
						this.authMethod = global::OpenSSL.AuthenticationMethod.DiffieHellman;
					}
					break;
				}
			}
			else if (num4 != 32U && num4 != 48U)
			{
				if (num4 == 64U)
				{
					this.authMethod = global::OpenSSL.AuthenticationMethod.ECDsa;
				}
			}
			else
			{
				this.authMethod = global::OpenSSL.AuthenticationMethod.Kerberos;
			}
			uint num5 = this.raw.algorithm_enc & 4095U;
			if (num5 <= 32U)
			{
				if (num5 <= 8U)
				{
					switch (num5)
					{
					case 1U:
						this.cipherAlgorithm = global::OpenSSL.CipherAlgorithmType.Des;
						if (flag && num2 == 5)
						{
							this.cipherStrength = 40;
						}
						else
						{
							this.cipherStrength = 56;
						}
						break;
					case 2U:
						this.cipherAlgorithm = global::OpenSSL.CipherAlgorithmType.TripleDes;
						this.cipherStrength = 168;
						break;
					case 3U:
						break;
					case 4U:
						this.cipherAlgorithm = global::OpenSSL.CipherAlgorithmType.Rc4;
						if (flag)
						{
							if (num2 == 5)
							{
								this.cipherStrength = 40;
							}
							else
							{
								this.cipherStrength = 56;
							}
						}
						else if ((this.raw.algorithm2 & 2U) == 2U)
						{
							this.cipherStrength = 64;
						}
						else
						{
							this.cipherStrength = 128;
						}
						break;
					default:
						if (num5 == 8U)
						{
							this.cipherAlgorithm = global::OpenSSL.CipherAlgorithmType.Rc2;
							if (flag)
							{
								if (num2 == 5)
								{
									this.cipherStrength = 40;
								}
								else
								{
									this.cipherStrength = 56;
								}
							}
							else
							{
								this.cipherStrength = 128;
							}
						}
						break;
					}
				}
				else if (num5 != 16U)
				{
					if (num5 == 32U)
					{
						this.cipherAlgorithm = global::OpenSSL.CipherAlgorithmType.None;
					}
				}
				else
				{
					this.cipherAlgorithm = global::OpenSSL.CipherAlgorithmType.Idea;
					this.cipherStrength = 128;
				}
			}
			else if (num5 <= 128U)
			{
				if (num5 == 64U || num5 == 128U)
				{
					int strength_bits = this.raw.strength_bits;
					if (strength_bits != 128)
					{
						if (strength_bits != 192)
						{
							if (strength_bits == 256)
							{
								this.cipherAlgorithm = global::OpenSSL.CipherAlgorithmType.Aes256;
							}
						}
						else
						{
							this.cipherAlgorithm = global::OpenSSL.CipherAlgorithmType.Aes192;
						}
					}
					else
					{
						this.cipherAlgorithm = global::OpenSSL.CipherAlgorithmType.Aes128;
					}
				}
			}
			else if (num5 != 256U && num5 != 512U)
			{
				if (num5 == 2048U)
				{
					this.cipherAlgorithm = global::OpenSSL.CipherAlgorithmType.Seed;
					this.cipherStrength = 128;
				}
			}
			else
			{
				int strength_bits2 = this.raw.strength_bits;
				if (strength_bits2 != 128)
				{
					if (strength_bits2 == 256)
					{
						this.cipherAlgorithm = global::OpenSSL.CipherAlgorithmType.Camellia256;
					}
				}
				else
				{
					this.cipherAlgorithm = global::OpenSSL.CipherAlgorithmType.Camellia128;
				}
			}
			switch (this.raw.algorithm_mac & 15U)
			{
			case 1U:
				this.hashAlgorithm = global::OpenSSL.HashAlgorithmType.Md5;
				return;
			case 2U:
				this.hashAlgorithm = global::OpenSSL.HashAlgorithmType.Sha1;
				return;
			default:
				this.hashAlgorithm = global::OpenSSL.HashAlgorithmType.None;
				return;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00006E60 File Offset: 0x00005060
		public global::OpenSSL.CipherAlgorithmType CipherAlgorithm
		{
			get
			{
				this.Initialize();
				return this.cipherAlgorithm;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00006E6E File Offset: 0x0000506E
		public global::OpenSSL.HashAlgorithmType HashAlgorithm
		{
			get
			{
				this.Initialize();
				return this.hashAlgorithm;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00006E7C File Offset: 0x0000507C
		public global::OpenSSL.ExchangeAlgorithmType KeyExchangeAlgorithm
		{
			get
			{
				this.Initialize();
				return this.keyExchangeAlgorithm;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00006E8A File Offset: 0x0000508A
		public int KeyExchangeStrength
		{
			get
			{
				this.Initialize();
				return this.keyExchangeStrength;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00006E98 File Offset: 0x00005098
		public global::OpenSSL.SslProtocols SslProtocol
		{
			get
			{
				this.Initialize();
				return this.sslProtocol;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00006EA6 File Offset: 0x000050A6
		public global::OpenSSL.AuthenticationMethod AuthenticateionMethod
		{
			get
			{
				this.Initialize();
				return this.authMethod;
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00006EB4 File Offset: 0x000050B4
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.OPENSSL_free(this.ptr);
		}

		// Token: 0x040002E2 RID: 738
		public const int SSL_EXPORT = 2;

		// Token: 0x040002E3 RID: 739
		public const int SSL_EXP40 = 8;

		// Token: 0x040002E4 RID: 740
		public const int SSL_EXP56 = 16;

		// Token: 0x040002E5 RID: 741
		public const int SSL_MKEY_MASK = 1023;

		// Token: 0x040002E6 RID: 742
		public const int SSL_kRSA = 1;

		// Token: 0x040002E7 RID: 743
		public const int SSL_kDHr = 2;

		// Token: 0x040002E8 RID: 744
		public const int SSL_kDHd = 4;

		// Token: 0x040002E9 RID: 745
		public const int SSL_kEDH = 8;

		// Token: 0x040002EA RID: 746
		public const int SSL_kKRB5 = 16;

		// Token: 0x040002EB RID: 747
		public const int SSL_kECDHr = 32;

		// Token: 0x040002EC RID: 748
		public const int SSL_kECDHe = 64;

		// Token: 0x040002ED RID: 749
		public const int SSL_kEECDH = 128;

		// Token: 0x040002EE RID: 750
		public const int SSL_kPSK = 256;

		// Token: 0x040002EF RID: 751
		public const int SSL_kGOST = 512;

		// Token: 0x040002F0 RID: 752
		public const int SSL_AUTH_MASK = 1023;

		// Token: 0x040002F1 RID: 753
		public const int SSL_aRSA = 1;

		// Token: 0x040002F2 RID: 754
		public const int SSL_aDSS = 2;

		// Token: 0x040002F3 RID: 755
		public const int SSL_aNULL = 4;

		// Token: 0x040002F4 RID: 756
		public const int SSL_aDH = 8;

		// Token: 0x040002F5 RID: 757
		public const int SSL_aECDH = 16;

		// Token: 0x040002F6 RID: 758
		public const int SSL_aKRB5 = 32;

		// Token: 0x040002F7 RID: 759
		public const int SSL_aECDSA = 64;

		// Token: 0x040002F8 RID: 760
		public const int SSL_aPSK = 128;

		// Token: 0x040002F9 RID: 761
		public const int SSL_aGOST94 = 256;

		// Token: 0x040002FA RID: 762
		public const int SSL_aGOST01 = 512;

		// Token: 0x040002FB RID: 763
		public const int SSL_NULL = 32;

		// Token: 0x040002FC RID: 764
		public const int SSL_ADH = 12;

		// Token: 0x040002FD RID: 765
		public const int SSL_RSA = 1;

		// Token: 0x040002FE RID: 766
		public const int SSL_DH = 14;

		// Token: 0x040002FF RID: 767
		public const int SSL_ECDH = 192;

		// Token: 0x04000300 RID: 768
		public const int SSL_KRB5 = 48;

		// Token: 0x04000301 RID: 769
		public const int SSL_ENC_MASK = 4095;

		// Token: 0x04000302 RID: 770
		public const int SSL_DES = 1;

		// Token: 0x04000303 RID: 771
		public const int SSL_3DES = 2;

		// Token: 0x04000304 RID: 772
		public const int SSL_RC4 = 4;

		// Token: 0x04000305 RID: 773
		public const int SSL_RC2 = 8;

		// Token: 0x04000306 RID: 774
		public const int SSL_IDEA = 16;

		// Token: 0x04000307 RID: 775
		public const int SSL_eNULL = 32;

		// Token: 0x04000308 RID: 776
		public const int SSL_AES128 = 64;

		// Token: 0x04000309 RID: 777
		public const int SSL_AES256 = 128;

		// Token: 0x0400030A RID: 778
		public const int SSL_CAMELLIA128 = 256;

		// Token: 0x0400030B RID: 779
		public const int SSL_CAMELLIA256 = 512;

		// Token: 0x0400030C RID: 780
		public const int SSL_eGOST2814789CNT = 1024;

		// Token: 0x0400030D RID: 781
		public const int SSL_SEED = 2048;

		// Token: 0x0400030E RID: 782
		public const int SSL_AES = 192;

		// Token: 0x0400030F RID: 783
		public const int SSL_CAMELLIA = 768;

		// Token: 0x04000310 RID: 784
		public const int SSL_MAC_MASK = 15;

		// Token: 0x04000311 RID: 785
		public const int SSL_MD5 = 1;

		// Token: 0x04000312 RID: 786
		public const int SSL_SHA1 = 2;

		// Token: 0x04000313 RID: 787
		public const int SSL_SHA = 2;

		// Token: 0x04000314 RID: 788
		public const int SSL_GOST94 = 4;

		// Token: 0x04000315 RID: 789
		public const int SSL_GOST89MAC = 8;

		// Token: 0x04000316 RID: 790
		public const int SSL_SSL_MASK = 3;

		// Token: 0x04000317 RID: 791
		public const int SSL_SSLV2 = 1;

		// Token: 0x04000318 RID: 792
		public const int SSL_SSLV3 = 2;

		// Token: 0x04000319 RID: 793
		public const int SSL_TLSV1 = 2;

		// Token: 0x0400031A RID: 794
		public const int SSL2_CF_5_BYTE_ENC = 1;

		// Token: 0x0400031B RID: 795
		public const int SSL2_CF_8_BYTE_ENC = 2;

		// Token: 0x0400031C RID: 796
		private bool isInitialized;

		// Token: 0x0400031D RID: 797
		private global::OpenSSL.SslCipher.SSL_CIPHER raw;

		// Token: 0x0400031E RID: 798
		private global::OpenSSL.CipherAlgorithmType cipherAlgorithm;

		// Token: 0x0400031F RID: 799
		private int cipherStrength;

		// Token: 0x04000320 RID: 800
		private global::OpenSSL.HashAlgorithmType hashAlgorithm;

		// Token: 0x04000321 RID: 801
		private global::OpenSSL.ExchangeAlgorithmType keyExchangeAlgorithm;

		// Token: 0x04000322 RID: 802
		private global::OpenSSL.AuthenticationMethod authMethod;

		// Token: 0x04000323 RID: 803
		private int keyExchangeStrength;

		// Token: 0x04000324 RID: 804
		private global::OpenSSL.SslProtocols sslProtocol;

		// Token: 0x02000064 RID: 100
		private struct SSL_CIPHER
		{
			// Token: 0x04000325 RID: 805
			public int valid;

			// Token: 0x04000326 RID: 806
			public global::System.IntPtr name;

			// Token: 0x04000327 RID: 807
			public uint id;

			// Token: 0x04000328 RID: 808
			public uint algorithm_mkey;

			// Token: 0x04000329 RID: 809
			public uint algorithm_auth;

			// Token: 0x0400032A RID: 810
			public uint algorithm_enc;

			// Token: 0x0400032B RID: 811
			public uint algorithm_mac;

			// Token: 0x0400032C RID: 812
			public uint algorithm_ssl;

			// Token: 0x0400032D RID: 813
			public uint algo_strength;

			// Token: 0x0400032E RID: 814
			public uint algorithm2;

			// Token: 0x0400032F RID: 815
			public int strength_bits;

			// Token: 0x04000330 RID: 816
			public int alg_bits;
		}
	}
}
