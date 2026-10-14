using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;

namespace OpenSSL.Crypto
{
	// Token: 0x02000029 RID: 41
	public class CryptoKey : global::OpenSSL.Core.BaseCopyableRef<global::OpenSSL.Crypto.CryptoKey>
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00003EBD File Offset: 0x000020BD
		internal CryptoKey(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003EC7 File Offset: 0x000020C7
		public CryptoKey() : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.EVP_PKEY_new()), true)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003EDC File Offset: 0x000020DC
		public static global::OpenSSL.Crypto.CryptoKey FromPublicKey(string pem, string password)
		{
			global::OpenSSL.Crypto.CryptoKey result;
			using (global::OpenSSL.Core.BIO bio = new global::OpenSSL.Core.BIO(pem))
			{
				result = global::OpenSSL.Crypto.CryptoKey.FromPublicKey(bio, password);
			}
			return result;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003F18 File Offset: 0x00002118
		public static global::OpenSSL.Crypto.CryptoKey FromPublicKey(global::OpenSSL.Core.BIO bio, string password)
		{
			global::OpenSSL.Core.PasswordCallback @object = new global::OpenSSL.Core.PasswordCallback(password);
			return global::OpenSSL.Crypto.CryptoKey.FromPublicKey(bio, new global::OpenSSL.Core.PasswordHandler(@object.OnPassword), null);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00003F40 File Offset: 0x00002140
		public static global::OpenSSL.Crypto.CryptoKey FromPublicKey(global::OpenSSL.Core.BIO bio, global::OpenSSL.Core.PasswordHandler handler, object arg)
		{
			global::OpenSSL.Core.PasswordThunk passwordThunk = new global::OpenSSL.Core.PasswordThunk(handler, arg);
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.PEM_read_bio_PUBKEY(bio.Handle, global::System.IntPtr.Zero, passwordThunk.Callback, global::System.IntPtr.Zero));
			return new global::OpenSSL.Crypto.CryptoKey(ptr, true);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003F80 File Offset: 0x00002180
		public static global::OpenSSL.Crypto.CryptoKey FromPrivateKey(string pem, string password)
		{
			global::OpenSSL.Crypto.CryptoKey result;
			using (global::OpenSSL.Core.BIO bio = new global::OpenSSL.Core.BIO(pem))
			{
				result = global::OpenSSL.Crypto.CryptoKey.FromPrivateKey(bio, password);
			}
			return result;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003FBC File Offset: 0x000021BC
		public static global::OpenSSL.Crypto.CryptoKey FromPrivateKey(global::OpenSSL.Core.BIO bio, string passwd)
		{
			global::OpenSSL.Core.PasswordCallback @object = new global::OpenSSL.Core.PasswordCallback(passwd);
			return global::OpenSSL.Crypto.CryptoKey.FromPrivateKey(bio, new global::OpenSSL.Core.PasswordHandler(@object.OnPassword), null);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003FE4 File Offset: 0x000021E4
		public static global::OpenSSL.Crypto.CryptoKey FromPrivateKey(global::OpenSSL.Core.BIO bio, global::OpenSSL.Core.PasswordHandler handler, object arg)
		{
			global::OpenSSL.Core.PasswordThunk passwordThunk = new global::OpenSSL.Core.PasswordThunk(handler, arg);
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.PEM_read_bio_PrivateKey(bio.Handle, global::System.IntPtr.Zero, passwordThunk.Callback, global::System.IntPtr.Zero));
			return new global::OpenSSL.Crypto.CryptoKey(ptr, true);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004021 File Offset: 0x00002221
		public CryptoKey(global::OpenSSL.Crypto.DSA dsa) : this()
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_PKEY_set1_DSA(this.ptr, dsa.Handle));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004040 File Offset: 0x00002240
		public CryptoKey(global::OpenSSL.Crypto.RSA rsa) : this()
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_PKEY_set1_RSA(this.ptr, rsa.Handle));
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000405F File Offset: 0x0000225F
		public CryptoKey(global::OpenSSL.Crypto.DH dh) : this()
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_PKEY_set1_DH(this.ptr, dh.Handle));
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000407E File Offset: 0x0000227E
		private global::OpenSSL.Crypto.CryptoKey.EVP_PKEY Raw
		{
			get
			{
				return (global::OpenSSL.Crypto.CryptoKey.EVP_PKEY)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.Crypto.CryptoKey.EVP_PKEY));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000409C File Offset: 0x0000229C
		public global::OpenSSL.Crypto.CryptoKey.KeyType Type
		{
			get
			{
				int num = global::OpenSSL.Core.Native.EVP_PKEY_type(this.Raw.type);
				int num2 = num;
				if (num2 <= 28)
				{
					if (num2 == 6)
					{
						return global::OpenSSL.Crypto.CryptoKey.KeyType.RSA;
					}
					if (num2 == 28)
					{
						return global::OpenSSL.Crypto.CryptoKey.KeyType.DH;
					}
				}
				else
				{
					if (num2 == 116)
					{
						return global::OpenSSL.Crypto.CryptoKey.KeyType.DSA;
					}
					if (num2 == 408)
					{
						return global::OpenSSL.Crypto.CryptoKey.KeyType.EC;
					}
				}
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x000040EC File Offset: 0x000022EC
		public int Bits
		{
			get
			{
				return global::OpenSSL.Core.Native.EVP_PKEY_bits(this.ptr);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000040F9 File Offset: 0x000022F9
		public int Size
		{
			get
			{
				return global::OpenSSL.Core.Native.EVP_PKEY_size(this.ptr);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004106 File Offset: 0x00002306
		public void Assign(int type, byte[] key)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_PKEY_assign(this.ptr, type, key));
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000411B File Offset: 0x0000231B
		public global::OpenSSL.Crypto.DSA GetDSA()
		{
			if (this.Type != global::OpenSSL.Crypto.CryptoKey.KeyType.DSA)
			{
				throw new global::System.InvalidOperationException();
			}
			return new global::OpenSSL.Crypto.DSA(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.EVP_PKEY_get1_DSA(this.ptr)), true);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004143 File Offset: 0x00002343
		public global::OpenSSL.Crypto.DH GetDH()
		{
			if (this.Type != global::OpenSSL.Crypto.CryptoKey.KeyType.DH)
			{
				throw new global::System.InvalidOperationException();
			}
			return new global::OpenSSL.Crypto.DH(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.EVP_PKEY_get1_DH(this.ptr)), false);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000416B File Offset: 0x0000236B
		public global::OpenSSL.Crypto.RSA GetRSA()
		{
			if (this.Type != global::OpenSSL.Crypto.CryptoKey.KeyType.RSA)
			{
				throw new global::System.InvalidOperationException();
			}
			return new global::OpenSSL.Crypto.RSA(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.EVP_PKEY_get1_RSA(this.ptr)), false);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004194 File Offset: 0x00002394
		public void WritePrivateKey(global::OpenSSL.Core.BIO bp, global::OpenSSL.Crypto.Cipher cipher, string password)
		{
			global::OpenSSL.Core.PasswordCallback @object = new global::OpenSSL.Core.PasswordCallback(password);
			this.WritePrivateKey(bp, cipher, new global::OpenSSL.Core.PasswordHandler(@object.OnPassword), null);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000041C0 File Offset: 0x000023C0
		public void WritePrivateKey(global::OpenSSL.Core.BIO bp, global::OpenSSL.Crypto.Cipher cipher, global::OpenSSL.Core.PasswordHandler handler, object arg)
		{
			global::OpenSSL.Core.PasswordThunk passwordThunk = new global::OpenSSL.Core.PasswordThunk(handler, null);
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.PEM_write_bio_PKCS8PrivateKey(bp.Handle, this.ptr, cipher.Handle, global::System.IntPtr.Zero, 0, passwordThunk.Callback, global::System.IntPtr.Zero));
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004203 File Offset: 0x00002403
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.EVP_PKEY_free(this.ptr);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004210 File Offset: 0x00002410
		public override bool Equals(object obj)
		{
			global::OpenSSL.Crypto.CryptoKey cryptoKey = obj as global::OpenSSL.Crypto.CryptoKey;
			return cryptoKey != null && global::OpenSSL.Core.Native.EVP_PKEY_cmp(this.ptr, cryptoKey.Handle) == 1;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000423D File Offset: 0x0000243D
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00004245 File Offset: 0x00002445
		internal override global::OpenSSL.Core.CryptoLockTypes LockType
		{
			get
			{
				return global::OpenSSL.Core.CryptoLockTypes.CRYPTO_LOCK_X509_PKEY;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00004248 File Offset: 0x00002448
		internal override global::System.Type RawReferenceType
		{
			get
			{
				return typeof(global::OpenSSL.Crypto.CryptoKey.EVP_PKEY);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004254 File Offset: 0x00002454
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Crypto.CryptoKey.KeyType type = this.Type;
			if (type <= global::OpenSSL.Crypto.CryptoKey.KeyType.DH)
			{
				if (type == global::OpenSSL.Crypto.CryptoKey.KeyType.RSA)
				{
					this.GetRSA().Print(bio);
					return;
				}
				if (type != global::OpenSSL.Crypto.CryptoKey.KeyType.DH)
				{
					return;
				}
				this.GetDH().Print(bio);
			}
			else
			{
				if (type == global::OpenSSL.Crypto.CryptoKey.KeyType.DSA)
				{
					this.GetDSA().Print(bio);
					return;
				}
				if (type != global::OpenSSL.Crypto.CryptoKey.KeyType.EC)
				{
					return;
				}
			}
		}

		// Token: 0x04000124 RID: 292
		private const int EVP_PKEY_RSA = 6;

		// Token: 0x04000125 RID: 293
		private const int EVP_PKEY_DSA = 116;

		// Token: 0x04000126 RID: 294
		private const int EVP_PKEY_DH = 28;

		// Token: 0x04000127 RID: 295
		private const int EVP_PKEY_EC = 408;

		// Token: 0x0200002A RID: 42
		public enum KeyType
		{
			// Token: 0x04000129 RID: 297
			RSA = 6,
			// Token: 0x0400012A RID: 298
			DSA = 116,
			// Token: 0x0400012B RID: 299
			DH = 28,
			// Token: 0x0400012C RID: 300
			EC = 408
		}

		// Token: 0x0200002B RID: 43
		private struct EVP_PKEY
		{
			// Token: 0x0400012D RID: 301
			public int type;

			// Token: 0x0400012E RID: 302
			private int save_type;

			// Token: 0x0400012F RID: 303
			private int references;

			// Token: 0x04000130 RID: 304
			private global::System.IntPtr ameth;

			// Token: 0x04000131 RID: 305
			private global::System.IntPtr engine;

			// Token: 0x04000132 RID: 306
			private global::System.IntPtr ptr;

			// Token: 0x04000133 RID: 307
			private int save_parameters;

			// Token: 0x04000134 RID: 308
			private global::System.IntPtr attributes;
		}
	}
}
