using System;
using System.IO;
using System.Runtime.InteropServices;
using OpenSSL.Core;

namespace OpenSSL.Crypto
{
	// Token: 0x02000017 RID: 23
	public class CipherContext : global::OpenSSL.Core.Base, global::System.IDisposable
	{
		// Token: 0x06000096 RID: 150 RVA: 0x000036D9 File Offset: 0x000018D9
		public CipherContext(global::OpenSSL.Crypto.Cipher cipher) : base(global::OpenSSL.Core.Native.OPENSSL_malloc(global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::OpenSSL.Crypto.CipherContext.EVP_CIPHER_CTX))), true)
		{
			global::OpenSSL.Core.Native.EVP_CIPHER_CTX_init(this.ptr);
			this.cipher = cipher;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003708 File Offset: 0x00001908
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			bio.Write("CipherContext: " + this.cipher.LongName);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003728 File Offset: 0x00001928
		public byte[] Open(byte[] input, byte[] iv, global::OpenSSL.Crypto.CryptoKey pkey)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_OpenInit(this.ptr, this.cipher.Handle, input, input.Length, iv, pkey.Handle));
			int num;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_OpenFinal(this.ptr, null, out num));
			byte[] array = new byte[num];
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_OpenFinal(this.ptr, array, out num));
			return array;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000378C File Offset: 0x0000198C
		public global::OpenSSL.Crypto.Envelope Seal(global::OpenSSL.Crypto.CryptoKey[] pkeys, bool needsIV)
		{
			global::OpenSSL.Crypto.Envelope result = default(global::OpenSSL.Crypto.Envelope);
			byte[][] array = new byte[pkeys.Length][];
			int[] array2 = new int[pkeys.Length];
			global::System.IntPtr[] array3 = new global::System.IntPtr[pkeys.Length];
			result.Keys = new global::System.ArraySegment<byte>[pkeys.Length];
			for (int i = 0; i < pkeys.Length; i++)
			{
				array[i] = new byte[pkeys[i].Size];
				array2[i] = pkeys[i].Size;
				array3[i] = pkeys[i].Handle;
			}
			if (needsIV)
			{
				result.IV = new byte[this.cipher.IVLength];
			}
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_SealInit(this.ptr, this.cipher.Handle, array, array2, result.IV, array3, array3.Length));
			for (int j = 0; j < pkeys.Length; j++)
			{
				result.Keys[j] = new global::System.ArraySegment<byte>(array[j], 0, array2[j]);
			}
			int num;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_SealFinal(this.ptr, null, out num));
			result.Data = new byte[num];
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_SealFinal(this.ptr, result.Data, out num));
			return result;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000038C5 File Offset: 0x00001AC5
		public byte[] Crypt(byte[] input, byte[] key, byte[] iv, bool doEncrypt)
		{
			return this.Crypt(input, key, iv, doEncrypt, -1);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000038D4 File Offset: 0x00001AD4
		private byte[] SetupKey(byte[] key)
		{
			bool flag = (this.cipher.Flags & 983047U) == 0U;
			byte[] array;
			if (flag)
			{
				array = new byte[this.Cipher.KeyLength];
				if (key == null)
				{
					array.Initialize();
				}
				else
				{
					global::System.Buffer.BlockCopy(key, 0, array, 0, global::System.Math.Min(key.Length, array.Length));
				}
			}
			else if (key == null)
			{
				array = new byte[this.Cipher.KeyLength];
				array.Initialize();
			}
			else if (this.Cipher.KeyLength != key.Length)
			{
				array = new byte[this.Cipher.KeyLength];
				array.Initialize();
				global::System.Buffer.BlockCopy(key, 0, array, 0, global::System.Math.Min(key.Length, array.Length));
			}
			else
			{
				array = key;
			}
			return array;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003988 File Offset: 0x00001B88
		private byte[] SetupIV(byte[] iv)
		{
			if (this.cipher.IVLength > iv.Length)
			{
				byte[] array = new byte[this.cipher.IVLength];
				array.Initialize();
				global::System.Buffer.BlockCopy(iv, 0, array, 0, iv.Length);
				return array;
			}
			return iv;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000039CC File Offset: 0x00001BCC
		public byte[] Crypt(byte[] input, byte[] key, byte[] iv, bool doEncrypt, int padding)
		{
			int enc = doEncrypt ? 1 : 0;
			int num = input.Length;
			byte[] array = this.SetupKey(key);
			byte[] iv2 = this.SetupIV(iv);
			byte[] array2 = new byte[num];
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(num);
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CipherInit_ex(this.ptr, this.cipher.Handle, global::System.IntPtr.Zero, null, null, enc));
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CIPHER_CTX_set_key_length(this.ptr, array.Length));
			if (padding >= 0)
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CIPHER_CTX_set_padding(this.ptr, padding));
			}
			bool flag = (this.cipher.Flags & 983047U) == 0U;
			if (flag)
			{
				for (int i = 0; i < global::System.Math.Min(array.Length, iv.Length); i++)
				{
					byte[] array3 = array;
					int num2 = i;
					array3[num2] ^= iv[i];
				}
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CipherInit_ex(this.ptr, this.cipher.Handle, global::System.IntPtr.Zero, array, null, enc));
			}
			else
			{
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CipherInit_ex(this.ptr, this.cipher.Handle, global::System.IntPtr.Zero, array, iv2, enc));
			}
			int count = array2.Length;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CipherUpdate(this.ptr, array2, out count, input, input.Length));
			memoryStream.Write(array2, 0, count);
			count = array2.Length;
			global::OpenSSL.Core.Native.EVP_CipherFinal_ex(this.ptr, array2, ref count);
			memoryStream.Write(array2, 0, count);
			return memoryStream.ToArray();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003B41 File Offset: 0x00001D41
		public byte[] Encrypt(byte[] input, byte[] key, byte[] iv)
		{
			return this.Crypt(input, key, iv, true);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003B4D File Offset: 0x00001D4D
		public byte[] Decrypt(byte[] input, byte[] key, byte[] iv)
		{
			return this.Crypt(input, key, iv, false);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00003B59 File Offset: 0x00001D59
		public byte[] Encrypt(byte[] input, byte[] key, byte[] iv, int padding)
		{
			return this.Crypt(input, key, iv, true, padding);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003B67 File Offset: 0x00001D67
		public byte[] Decrypt(byte[] input, byte[] key, byte[] iv, int padding)
		{
			return this.Crypt(input, key, iv, false, padding);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003B78 File Offset: 0x00001D78
		public byte[] BytesToKey(global::OpenSSL.Crypto.MessageDigest md, byte[] salt, byte[] data, int count, out byte[] iv)
		{
			byte[] array = new byte[this.cipher.KeyLength];
			iv = new byte[this.cipher.IVLength];
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_BytesToKey(this.cipher.Handle, md.Handle, salt, data, data.Length, count, array, iv));
			return array;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003BD1 File Offset: 0x00001DD1
		public global::OpenSSL.Crypto.Cipher Cipher
		{
			get
			{
				return this.cipher;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00003BD9 File Offset: 0x00001DD9
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00003BF5 File Offset: 0x00001DF5
		private global::OpenSSL.Crypto.CipherContext.EVP_CIPHER_CTX Raw
		{
			get
			{
				return (global::OpenSSL.Crypto.CipherContext.EVP_CIPHER_CTX)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.Crypto.CipherContext.EVP_CIPHER_CTX));
			}
			set
			{
				global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::OpenSSL.Crypto.CipherContext.EVP_CIPHER_CTX>(value, this.ptr, false);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003C04 File Offset: 0x00001E04
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.EVP_CIPHER_CTX_cleanup(this.ptr);
			global::OpenSSL.Core.Native.OPENSSL_free(this.ptr);
		}

		// Token: 0x0400006E RID: 110
		private global::OpenSSL.Crypto.Cipher cipher;

		// Token: 0x02000018 RID: 24
		private struct EVP_CIPHER_CTX
		{
			// Token: 0x0400006F RID: 111
			public global::System.IntPtr cipher;

			// Token: 0x04000070 RID: 112
			public global::System.IntPtr engine;

			// Token: 0x04000071 RID: 113
			public int encrypt;

			// Token: 0x04000072 RID: 114
			public int buf_len;

			// Token: 0x04000073 RID: 115
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
			public byte[] oiv;

			// Token: 0x04000074 RID: 116
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
			public byte[] iv;

			// Token: 0x04000075 RID: 117
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
			public byte[] buf;

			// Token: 0x04000076 RID: 118
			public int num;

			// Token: 0x04000077 RID: 119
			public global::System.IntPtr app_data;

			// Token: 0x04000078 RID: 120
			public int key_len;

			// Token: 0x04000079 RID: 121
			public uint flags;

			// Token: 0x0400007A RID: 122
			public global::System.IntPtr cipher_data;

			// Token: 0x0400007B RID: 123
			public int final_used;

			// Token: 0x0400007C RID: 124
			public int block_mask;

			// Token: 0x0400007D RID: 125
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
			public byte[] final;
		}
	}
}
