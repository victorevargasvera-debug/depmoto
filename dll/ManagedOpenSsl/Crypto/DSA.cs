using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;

namespace OpenSSL.Crypto
{
	// Token: 0x02000032 RID: 50
	public class DSA : global::OpenSSL.Core.Base
	{
		// Token: 0x060000FC RID: 252 RVA: 0x000047E4 File Offset: 0x000029E4
		internal DSA(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000047F0 File Offset: 0x000029F0
		public DSA(bool generateKeys) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.DSA_new()), true)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.DSA_generate_parameters_ex(this.ptr, 512, null, 0, out this.counter, out this.h, null));
			if (generateKeys)
			{
				this.GenerateKeys();
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000483C File Offset: 0x00002A3C
		public DSA(int bits, global::OpenSSL.Core.BigNumber.GeneratorHandler callback, object arg) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.DSA_new()), true)
		{
			this.thunk = new global::OpenSSL.Core.BigNumber.GeneratorThunk(callback, arg);
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.DSA_generate_parameters_ex(this.ptr, bits, null, 0, out this.counter, out this.h, this.thunk.CallbackStruct));
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004894 File Offset: 0x00002A94
		public DSA(int bits, byte[] seed, int counter, global::OpenSSL.Core.BigNumber.GeneratorHandler callback, object arg) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.DSA_new()), true)
		{
			this.counter = counter;
			this.thunk = new global::OpenSSL.Core.BigNumber.GeneratorThunk(callback, arg);
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.DSA_generate_parameters_ex(this.ptr, bits, seed, seed.Length, out this.counter, out this.h, this.thunk.CallbackStruct));
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000048F5 File Offset: 0x00002AF5
		public static global::OpenSSL.Crypto.DSA FromPublicKey(string pem)
		{
			return global::OpenSSL.Crypto.DSA.FromPublicKey(new global::OpenSSL.Core.BIO(pem));
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004902 File Offset: 0x00002B02
		public static global::OpenSSL.Crypto.DSA FromPublicKey(global::OpenSSL.Core.BIO bio)
		{
			return new global::OpenSSL.Crypto.DSA(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.PEM_read_bio_DSA_PUBKEY(bio.Handle, global::System.IntPtr.Zero, null, global::System.IntPtr.Zero)), true);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004925 File Offset: 0x00002B25
		public static global::OpenSSL.Crypto.DSA FromPrivateKey(string pem)
		{
			return global::OpenSSL.Crypto.DSA.FromPrivateKey(new global::OpenSSL.Core.BIO(pem));
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004932 File Offset: 0x00002B32
		public static global::OpenSSL.Crypto.DSA FromPrivateKey(global::OpenSSL.Core.BIO bio)
		{
			return new global::OpenSSL.Crypto.DSA(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.PEM_read_bio_DSAPrivateKey(bio.Handle, global::System.IntPtr.Zero, null, global::System.IntPtr.Zero)), true);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00004955 File Offset: 0x00002B55
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00004971 File Offset: 0x00002B71
		private global::OpenSSL.Crypto.DSA.dsa_st Raw
		{
			get
			{
				return (global::OpenSSL.Crypto.DSA.dsa_st)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.Crypto.DSA.dsa_st));
			}
			set
			{
				global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::OpenSSL.Crypto.DSA.dsa_st>(value, this.ptr, false);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00004980 File Offset: 0x00002B80
		public global::OpenSSL.Core.BigNumber P
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.p, false);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00004993 File Offset: 0x00002B93
		public global::OpenSSL.Core.BigNumber Q
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.q, false);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000049A6 File Offset: 0x00002BA6
		public global::OpenSSL.Core.BigNumber G
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.g, false);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000049B9 File Offset: 0x00002BB9
		public int Size
		{
			get
			{
				return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.DSA_size(this.ptr));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000049CB File Offset: 0x00002BCB
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000049E0 File Offset: 0x00002BE0
		public global::OpenSSL.Core.BigNumber PublicKey
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.pub_key, false);
			}
			set
			{
				global::OpenSSL.Crypto.DSA.dsa_st raw = this.Raw;
				raw.pub_key = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00004A10 File Offset: 0x00002C10
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00004A40 File Offset: 0x00002C40
		public global::OpenSSL.Core.BigNumber PrivateKey
		{
			get
			{
				global::System.IntPtr priv_key = this.Raw.priv_key;
				if (priv_key == global::System.IntPtr.Zero)
				{
					return null;
				}
				return new global::OpenSSL.Core.BigNumber(priv_key, false);
			}
			set
			{
				global::OpenSSL.Crypto.DSA.dsa_st raw = this.Raw;
				raw.priv_key = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00004A70 File Offset: 0x00002C70
		public string PublicKeyAsPEM
		{
			get
			{
				string result;
				using (global::OpenSSL.Core.BIO bio = global::OpenSSL.Core.BIO.MemoryBuffer())
				{
					this.WritePublicKey(bio);
					result = bio.ReadString();
				}
				return result;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00004AB0 File Offset: 0x00002CB0
		public string PrivateKeyAsPEM
		{
			get
			{
				string result;
				using (global::OpenSSL.Core.BIO bio = global::OpenSSL.Core.BIO.MemoryBuffer())
				{
					this.WritePrivateKey(bio, null, null, null);
					result = bio.ReadString();
				}
				return result;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00004AF4 File Offset: 0x00002CF4
		public int Counter
		{
			get
			{
				return this.counter;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00004AFC File Offset: 0x00002CFC
		public int H
		{
			get
			{
				return this.h;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00004B04 File Offset: 0x00002D04
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00004B1C File Offset: 0x00002D1C
		public bool ConstantTime
		{
			get
			{
				return (this.Raw.flags & 2) != 0;
			}
			set
			{
				global::OpenSSL.Crypto.DSA.dsa_st raw = this.Raw;
				if (value)
				{
					raw.flags |= 2;
				}
				else
				{
					raw.flags &= -3;
				}
				this.Raw = raw;
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004B5B File Offset: 0x00002D5B
		public void GenerateKeys()
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.DSA_generate_key(this.ptr));
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00004B70 File Offset: 0x00002D70
		public byte[] Sign(byte[] msg)
		{
			byte[] array = new byte[this.Size];
			uint num;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.DSA_sign(0, msg, msg.Length, array, out num, this.ptr));
			if ((long)array.Length != (long)((ulong)num))
			{
				byte[] array2 = new byte[num];
				global::System.Buffer.BlockCopy(array, 0, array2, 0, (int)num);
				return array2;
			}
			return array;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004BBF File Offset: 0x00002DBF
		public bool Verify(byte[] msg, byte[] sig)
		{
			return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.DSA_verify(0, msg, msg.Length, sig, sig.Length, this.ptr)) == 1;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004BDD File Offset: 0x00002DDD
		public void WritePublicKey(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.PEM_write_bio_DSA_PUBKEY(bio.Handle, this.ptr));
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004BF8 File Offset: 0x00002DF8
		public void WritePrivateKey(global::OpenSSL.Core.BIO bio, global::OpenSSL.Crypto.Cipher enc, global::OpenSSL.Core.PasswordHandler passwd, object arg)
		{
			global::OpenSSL.Core.PasswordThunk passwordThunk = new global::OpenSSL.Core.PasswordThunk(passwd, arg);
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.PEM_write_bio_DSAPrivateKey(bio.Handle, this.ptr, (enc == null) ? global::System.IntPtr.Zero : enc.Handle, null, 0, passwordThunk.Callback, global::System.IntPtr.Zero));
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00004C42 File Offset: 0x00002E42
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.DSA_print(bio.Handle, this.ptr, 0));
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004C5C File Offset: 0x00002E5C
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.DSA_free(this.ptr);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004C6C File Offset: 0x00002E6C
		public override bool Equals(object obj)
		{
			global::OpenSSL.Crypto.DSA dsa = obj as global::OpenSSL.Crypto.DSA;
			if (dsa == null)
			{
				return false;
			}
			if (!(this.P == dsa.P) || !(this.Q == dsa.Q) || !(this.G == dsa.G))
			{
				return false;
			}
			if (this.PublicKey != dsa.PublicKey)
			{
				return false;
			}
			global::OpenSSL.Core.BigNumber privateKey = this.PrivateKey;
			global::OpenSSL.Core.BigNumber privateKey2 = dsa.PrivateKey;
			return privateKey == null || privateKey2 == null || privateKey == privateKey2;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00004D04 File Offset: 0x00002F04
		public override int GetHashCode()
		{
			int num = this.P.GetHashCode() ^ this.Q.GetHashCode() ^ this.G.GetHashCode() ^ this.PublicKey.GetHashCode();
			if (this.PrivateKey != null)
			{
				num ^= this.PrivateKey.GetHashCode();
			}
			return num;
		}

		// Token: 0x04000152 RID: 338
		private const int FlagCacheMont_P = 1;

		// Token: 0x04000153 RID: 339
		private const int FlagNoExpConstTime = 2;

		// Token: 0x04000154 RID: 340
		private int counter;

		// Token: 0x04000155 RID: 341
		private int h;

		// Token: 0x04000156 RID: 342
		private global::OpenSSL.Core.BigNumber.GeneratorThunk thunk;

		// Token: 0x02000033 RID: 51
		private struct dsa_st
		{
			// Token: 0x04000157 RID: 343
			public int pad;

			// Token: 0x04000158 RID: 344
			public int version;

			// Token: 0x04000159 RID: 345
			public int write_params;

			// Token: 0x0400015A RID: 346
			public global::System.IntPtr p;

			// Token: 0x0400015B RID: 347
			public global::System.IntPtr q;

			// Token: 0x0400015C RID: 348
			public global::System.IntPtr g;

			// Token: 0x0400015D RID: 349
			public global::System.IntPtr pub_key;

			// Token: 0x0400015E RID: 350
			public global::System.IntPtr priv_key;

			// Token: 0x0400015F RID: 351
			public global::System.IntPtr kinv;

			// Token: 0x04000160 RID: 352
			public global::System.IntPtr r;

			// Token: 0x04000161 RID: 353
			public int flags;

			// Token: 0x04000162 RID: 354
			public global::System.IntPtr method_mont_p;

			// Token: 0x04000163 RID: 355
			public int references;

			// Token: 0x04000164 RID: 356
			public global::System.IntPtr ex_data_sk;

			// Token: 0x04000165 RID: 357
			public int ex_data_dummy;

			// Token: 0x04000166 RID: 358
			public global::System.IntPtr meth;

			// Token: 0x04000167 RID: 359
			public global::System.IntPtr engine;
		}
	}
}
