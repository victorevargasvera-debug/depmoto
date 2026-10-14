using System;
using System.Runtime.InteropServices;
using System.Text;
using OpenSSL.Core;

namespace OpenSSL.Crypto
{
	// Token: 0x02000014 RID: 20
	public class Cipher : global::OpenSSL.Core.Base
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0000320D File Offset: 0x0000140D
		internal Cipher(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
			this.raw = (global::OpenSSL.Crypto.Cipher.EVP_CIPHER)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.Crypto.Cipher.EVP_CIPHER));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003237 File Offset: 0x00001437
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			bio.Write(this.LongName);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003245 File Offset: 0x00001445
		protected override void OnDispose()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000324C File Offset: 0x0000144C
		public static global::OpenSSL.Crypto.Cipher CreateByName(string name)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(name);
			global::System.IntPtr intPtr = global::OpenSSL.Core.Native.EVP_get_cipherbyname(bytes);
			if (intPtr == global::System.IntPtr.Zero)
			{
				return null;
			}
			return new global::OpenSSL.Crypto.Cipher(intPtr, false);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00003282 File Offset: 0x00001482
		public static string[] AllNamesSorted
		{
			get
			{
				return new global::OpenSSL.Core.NameCollector(2, true).Result.ToArray();
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00003295 File Offset: 0x00001495
		public static string[] AllNames
		{
			get
			{
				return new global::OpenSSL.Core.NameCollector(2, false).Result.ToArray();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000032A8 File Offset: 0x000014A8
		public int KeyLength
		{
			get
			{
				return this.raw.key_len;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000032B5 File Offset: 0x000014B5
		public int IVLength
		{
			get
			{
				return this.raw.iv_len;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000032C2 File Offset: 0x000014C2
		public int BlockSize
		{
			get
			{
				return this.raw.block_size;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000032CF File Offset: 0x000014CF
		public uint Flags
		{
			get
			{
				return this.raw.flags;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000032DC File Offset: 0x000014DC
		public string LongName
		{
			get
			{
				return global::OpenSSL.Core.Native.PtrToStringAnsi(global::OpenSSL.Core.Native.OBJ_nid2ln(this.raw.nid), false);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000032F4 File Offset: 0x000014F4
		public string Name
		{
			get
			{
				return global::OpenSSL.Core.Native.PtrToStringAnsi(global::OpenSSL.Core.Native.OBJ_nid2sn(this.raw.nid), false);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000330C File Offset: 0x0000150C
		public int Type
		{
			get
			{
				return global::OpenSSL.Core.Native.EVP_CIPHER_type(this.ptr);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00003319 File Offset: 0x00001519
		public string TypeName
		{
			get
			{
				return global::OpenSSL.Core.Native.PtrToStringAnsi(global::OpenSSL.Core.Native.OBJ_nid2ln(this.Type), false);
			}
		}

		// Token: 0x04000023 RID: 35
		private global::OpenSSL.Crypto.Cipher.EVP_CIPHER raw;

		// Token: 0x04000024 RID: 36
		public static global::OpenSSL.Crypto.Cipher Null = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_enc_null(), false);

		// Token: 0x04000025 RID: 37
		public static global::OpenSSL.Crypto.Cipher DES_ECB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ecb(), false);

		// Token: 0x04000026 RID: 38
		public static global::OpenSSL.Crypto.Cipher DES_EDE = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ede(), false);

		// Token: 0x04000027 RID: 39
		public static global::OpenSSL.Crypto.Cipher DES_EDE3 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ede3(), false);

		// Token: 0x04000028 RID: 40
		public static global::OpenSSL.Crypto.Cipher DES_EDE_ECB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ede_ecb(), false);

		// Token: 0x04000029 RID: 41
		public static global::OpenSSL.Crypto.Cipher DES_EDE3_ECB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ede3_ecb(), false);

		// Token: 0x0400002A RID: 42
		public static global::OpenSSL.Crypto.Cipher DES_CFB64 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_cfb64(), false);

		// Token: 0x0400002B RID: 43
		public static global::OpenSSL.Crypto.Cipher DES_CFB1 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_cfb1(), false);

		// Token: 0x0400002C RID: 44
		public static global::OpenSSL.Crypto.Cipher DES_CFB8 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_cfb8(), false);

		// Token: 0x0400002D RID: 45
		public static global::OpenSSL.Crypto.Cipher DES_EDE_CFB64 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ede_cfb64(), false);

		// Token: 0x0400002E RID: 46
		public static global::OpenSSL.Crypto.Cipher DES_EDE3_CFB64 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ede3_cfb64(), false);

		// Token: 0x0400002F RID: 47
		public static global::OpenSSL.Crypto.Cipher DES_EDE3_CFB1 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ede3_cfb1(), false);

		// Token: 0x04000030 RID: 48
		public static global::OpenSSL.Crypto.Cipher DES_EDE3_CFB8 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ede3_cfb8(), false);

		// Token: 0x04000031 RID: 49
		public static global::OpenSSL.Crypto.Cipher DES_OFB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ofb(), false);

		// Token: 0x04000032 RID: 50
		public static global::OpenSSL.Crypto.Cipher DES_EDE_OFB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ede_ofb(), false);

		// Token: 0x04000033 RID: 51
		public static global::OpenSSL.Crypto.Cipher DES_EDE3_OFB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ede3_ofb(), false);

		// Token: 0x04000034 RID: 52
		public static global::OpenSSL.Crypto.Cipher DES_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_cbc(), false);

		// Token: 0x04000035 RID: 53
		public static global::OpenSSL.Crypto.Cipher DES_EDE_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ede_cbc(), false);

		// Token: 0x04000036 RID: 54
		public static global::OpenSSL.Crypto.Cipher DES_EDE3_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_des_ede3_cbc(), false);

		// Token: 0x04000037 RID: 55
		public static global::OpenSSL.Crypto.Cipher DESX_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_desx_cbc(), false);

		// Token: 0x04000038 RID: 56
		public static global::OpenSSL.Crypto.Cipher RC4 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_rc4(), false);

		// Token: 0x04000039 RID: 57
		public static global::OpenSSL.Crypto.Cipher RC4_40 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_rc4_40(), false);

		// Token: 0x0400003A RID: 58
		public static global::OpenSSL.Crypto.Cipher Idea_ECB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_idea_ecb(), false);

		// Token: 0x0400003B RID: 59
		public static global::OpenSSL.Crypto.Cipher Idea_CFB64 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_idea_cfb64(), false);

		// Token: 0x0400003C RID: 60
		public static global::OpenSSL.Crypto.Cipher Idea_OFB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_idea_ofb(), false);

		// Token: 0x0400003D RID: 61
		public static global::OpenSSL.Crypto.Cipher Idea_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_idea_cbc(), false);

		// Token: 0x0400003E RID: 62
		public static global::OpenSSL.Crypto.Cipher RC2_ECB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_rc2_ecb(), false);

		// Token: 0x0400003F RID: 63
		public static global::OpenSSL.Crypto.Cipher RC2_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_rc2_cbc(), false);

		// Token: 0x04000040 RID: 64
		public static global::OpenSSL.Crypto.Cipher RC2_40_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_rc2_40_cbc(), false);

		// Token: 0x04000041 RID: 65
		public static global::OpenSSL.Crypto.Cipher RC2_64_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_rc2_64_cbc(), false);

		// Token: 0x04000042 RID: 66
		public static global::OpenSSL.Crypto.Cipher RC2_CFB64 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_rc2_cfb64(), false);

		// Token: 0x04000043 RID: 67
		public static global::OpenSSL.Crypto.Cipher RC2_OFB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_rc2_ofb(), false);

		// Token: 0x04000044 RID: 68
		public static global::OpenSSL.Crypto.Cipher Blowfish_ECB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_bf_ecb(), false);

		// Token: 0x04000045 RID: 69
		public static global::OpenSSL.Crypto.Cipher Blowfish_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_bf_cbc(), false);

		// Token: 0x04000046 RID: 70
		public static global::OpenSSL.Crypto.Cipher Blowfish_CFB64 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_bf_cfb64(), false);

		// Token: 0x04000047 RID: 71
		public static global::OpenSSL.Crypto.Cipher Blowfish_OFB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_bf_ofb(), false);

		// Token: 0x04000048 RID: 72
		public static global::OpenSSL.Crypto.Cipher Cast5_ECB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_cast5_ecb(), false);

		// Token: 0x04000049 RID: 73
		public static global::OpenSSL.Crypto.Cipher Cast5_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_cast5_cbc(), false);

		// Token: 0x0400004A RID: 74
		public static global::OpenSSL.Crypto.Cipher Cast5_OFB64 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_cast5_cfb64(), false);

		// Token: 0x0400004B RID: 75
		public static global::OpenSSL.Crypto.Cipher Cast5_OFB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_cast5_ofb(), false);

		// Token: 0x0400004C RID: 76
		public static global::OpenSSL.Crypto.Cipher AES_128_ECB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_128_ecb(), false);

		// Token: 0x0400004D RID: 77
		public static global::OpenSSL.Crypto.Cipher AES_128_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_128_cbc(), false);

		// Token: 0x0400004E RID: 78
		public static global::OpenSSL.Crypto.Cipher AES_128_CFB1 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_128_cfb1(), false);

		// Token: 0x0400004F RID: 79
		public static global::OpenSSL.Crypto.Cipher AES_128_CFB8 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_128_cfb8(), false);

		// Token: 0x04000050 RID: 80
		public static global::OpenSSL.Crypto.Cipher AES_128_CFB128 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_128_cfb128(), false);

		// Token: 0x04000051 RID: 81
		public static global::OpenSSL.Crypto.Cipher AES_128_OFB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_128_ofb(), false);

		// Token: 0x04000052 RID: 82
		public static global::OpenSSL.Crypto.Cipher AES_192_ECB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_192_ecb(), false);

		// Token: 0x04000053 RID: 83
		public static global::OpenSSL.Crypto.Cipher AES_192_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_192_cbc(), false);

		// Token: 0x04000054 RID: 84
		public static global::OpenSSL.Crypto.Cipher AES_192_CFB1 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_192_cfb1(), false);

		// Token: 0x04000055 RID: 85
		public static global::OpenSSL.Crypto.Cipher AES_192_CFB8 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_192_cfb8(), false);

		// Token: 0x04000056 RID: 86
		public static global::OpenSSL.Crypto.Cipher AES_192_CFB128 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_192_cfb128(), false);

		// Token: 0x04000057 RID: 87
		public static global::OpenSSL.Crypto.Cipher AES_192_OFB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_192_ofb(), false);

		// Token: 0x04000058 RID: 88
		public static global::OpenSSL.Crypto.Cipher AES_256_ECB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_256_ecb(), false);

		// Token: 0x04000059 RID: 89
		public static global::OpenSSL.Crypto.Cipher AES_256_CBC = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_256_cbc(), false);

		// Token: 0x0400005A RID: 90
		public static global::OpenSSL.Crypto.Cipher AES_256_CFB1 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_256_cfb1(), false);

		// Token: 0x0400005B RID: 91
		public static global::OpenSSL.Crypto.Cipher AES_256_CFB8 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_256_cfb8(), false);

		// Token: 0x0400005C RID: 92
		public static global::OpenSSL.Crypto.Cipher AES_256_CFB128 = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_256_cfb128(), false);

		// Token: 0x0400005D RID: 93
		public static global::OpenSSL.Crypto.Cipher AES_256_OFB = new global::OpenSSL.Crypto.Cipher(global::OpenSSL.Core.Native.EVP_aes_256_ofb(), false);

		// Token: 0x02000015 RID: 21
		private struct EVP_CIPHER
		{
			// Token: 0x0400005E RID: 94
			public int nid;

			// Token: 0x0400005F RID: 95
			public int block_size;

			// Token: 0x04000060 RID: 96
			public int key_len;

			// Token: 0x04000061 RID: 97
			public int iv_len;

			// Token: 0x04000062 RID: 98
			public uint flags;

			// Token: 0x04000063 RID: 99
			public global::System.IntPtr init;

			// Token: 0x04000064 RID: 100
			public global::System.IntPtr do_cipher;

			// Token: 0x04000065 RID: 101
			public global::System.IntPtr cleanup;

			// Token: 0x04000066 RID: 102
			public int ctx_size;

			// Token: 0x04000067 RID: 103
			public global::System.IntPtr set_asn1_parameters;

			// Token: 0x04000068 RID: 104
			public global::System.IntPtr get_asn1_parameters;

			// Token: 0x04000069 RID: 105
			public global::System.IntPtr ctrl;

			// Token: 0x0400006A RID: 106
			public global::System.IntPtr app_data;
		}
	}
}
