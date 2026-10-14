using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;

namespace OpenSSL.Crypto
{
	// Token: 0x0200005C RID: 92
	public class RSA : global::OpenSSL.Core.Base, global::System.IDisposable
	{
		// Token: 0x060003CD RID: 973 RVA: 0x00006167 File Offset: 0x00004367
		internal RSA(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00006171 File Offset: 0x00004371
		public RSA() : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.RSA_new()), true)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00006184 File Offset: 0x00004384
		public static global::OpenSSL.Crypto.RSA FromPublicKey(global::OpenSSL.Core.BIO bio)
		{
			return global::OpenSSL.Crypto.RSA.FromPublicKey(bio, null, null);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000618E File Offset: 0x0000438E
		public static global::OpenSSL.Crypto.RSA FromPrivateKey(global::OpenSSL.Core.BIO bio)
		{
			return global::OpenSSL.Crypto.RSA.FromPrivateKey(bio, null, null);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00006198 File Offset: 0x00004398
		public static global::OpenSSL.Crypto.RSA FromPublicKey(global::OpenSSL.Core.BIO bio, global::OpenSSL.Core.PasswordHandler callback, object arg)
		{
			global::OpenSSL.Core.PasswordThunk passwordThunk = new global::OpenSSL.Core.PasswordThunk(callback, arg);
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.PEM_read_bio_RSA_PUBKEY(bio.Handle, global::System.IntPtr.Zero, passwordThunk.Callback, global::System.IntPtr.Zero);
			return new global::OpenSSL.Crypto.RSA(global::OpenSSL.Core.Native.ExpectNonNull(ptr), true);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000061D8 File Offset: 0x000043D8
		public static global::OpenSSL.Crypto.RSA FromPrivateKey(global::OpenSSL.Core.BIO bio, global::OpenSSL.Core.PasswordHandler callback, object arg)
		{
			global::OpenSSL.Core.PasswordThunk passwordThunk = new global::OpenSSL.Core.PasswordThunk(callback, arg);
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.PEM_read_bio_RSAPrivateKey(bio.Handle, global::System.IntPtr.Zero, passwordThunk.Callback, global::System.IntPtr.Zero);
			return new global::OpenSSL.Crypto.RSA(global::OpenSSL.Core.Native.ExpectNonNull(ptr), true);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00006215 File Offset: 0x00004415
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00006231 File Offset: 0x00004431
		private global::OpenSSL.Crypto.RSA.rsa_st Raw
		{
			get
			{
				return (global::OpenSSL.Crypto.RSA.rsa_st)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.Crypto.RSA.rsa_st));
			}
			set
			{
				global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::OpenSSL.Crypto.RSA.rsa_st>(value, this.ptr, false);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00006240 File Offset: 0x00004440
		public int Size
		{
			get
			{
				return global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RSA_size(this.ptr));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00006252 File Offset: 0x00004452
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00006255 File Offset: 0x00004455
		public bool ConstantTime
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00006257 File Offset: 0x00004457
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x0000626C File Offset: 0x0000446C
		public global::OpenSSL.Core.BigNumber PublicExponent
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.e, false);
			}
			set
			{
				global::OpenSSL.Crypto.RSA.rsa_st raw = this.Raw;
				raw.e = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00006299 File Offset: 0x00004499
		// (set) Token: 0x060003DB RID: 987 RVA: 0x000062AC File Offset: 0x000044AC
		public global::OpenSSL.Core.BigNumber PublicModulus
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.n, false);
			}
			set
			{
				global::OpenSSL.Crypto.RSA.rsa_st raw = this.Raw;
				raw.n = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000062D9 File Offset: 0x000044D9
		// (set) Token: 0x060003DD RID: 989 RVA: 0x000062EC File Offset: 0x000044EC
		public global::OpenSSL.Core.BigNumber PrivateExponent
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.d, false);
			}
			set
			{
				global::OpenSSL.Crypto.RSA.rsa_st raw = this.Raw;
				raw.d = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00006319 File Offset: 0x00004519
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0000632C File Offset: 0x0000452C
		public global::OpenSSL.Core.BigNumber SecretPrimeFactorP
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.p, false);
			}
			set
			{
				global::OpenSSL.Crypto.RSA.rsa_st raw = this.Raw;
				raw.p = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00006359 File Offset: 0x00004559
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0000636C File Offset: 0x0000456C
		public global::OpenSSL.Core.BigNumber SecretPrimeFactorQ
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.q, false);
			}
			set
			{
				global::OpenSSL.Crypto.RSA.rsa_st raw = this.Raw;
				raw.q = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00006399 File Offset: 0x00004599
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x000063AC File Offset: 0x000045AC
		public global::OpenSSL.Core.BigNumber DmodP1
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.dmp1, false);
			}
			set
			{
				global::OpenSSL.Crypto.RSA.rsa_st raw = this.Raw;
				raw.dmp1 = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x000063D9 File Offset: 0x000045D9
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x000063EC File Offset: 0x000045EC
		public global::OpenSSL.Core.BigNumber DmodQ1
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.dmq1, false);
			}
			set
			{
				global::OpenSSL.Crypto.RSA.rsa_st raw = this.Raw;
				raw.dmq1 = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00006419 File Offset: 0x00004619
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x0000642C File Offset: 0x0000462C
		public global::OpenSSL.Core.BigNumber IQmodP
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.iqmp, false);
			}
			set
			{
				global::OpenSSL.Crypto.RSA.rsa_st raw = this.Raw;
				raw.iqmp = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0000645C File Offset: 0x0000465C
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

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000649C File Offset: 0x0000469C
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

		// Token: 0x060003EA RID: 1002 RVA: 0x000064E0 File Offset: 0x000046E0
		public void GenerateKeys(int bits, global::OpenSSL.Core.BigNumber e, global::OpenSSL.Core.BigNumber.GeneratorHandler callback, object arg)
		{
			this.thunk = new global::OpenSSL.Core.BigNumber.GeneratorThunk(callback, arg);
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RSA_generate_key_ex(this.ptr, bits, e.Handle, this.thunk.CallbackStruct));
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00006514 File Offset: 0x00004714
		public byte[] PublicEncrypt(byte[] msg, global::OpenSSL.Crypto.RSA.Padding padding)
		{
			byte[] array = new byte[this.Size];
			int num = global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RSA_public_encrypt(msg.Length, msg, array, this.ptr, (int)padding));
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				global::System.Buffer.BlockCopy(array, 0, array2, 0, num);
				return array2;
			}
			return array;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00006560 File Offset: 0x00004760
		public byte[] PrivateEncrypt(byte[] msg, global::OpenSSL.Crypto.RSA.Padding padding)
		{
			byte[] array = new byte[this.Size];
			int num = global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RSA_private_encrypt(msg.Length, msg, array, this.ptr, (int)padding));
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				global::System.Buffer.BlockCopy(array, 0, array2, 0, num);
				return array2;
			}
			return array;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000065AC File Offset: 0x000047AC
		public byte[] PublicDecrypt(byte[] msg, global::OpenSSL.Crypto.RSA.Padding padding)
		{
			byte[] array = new byte[this.Size];
			int num = global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RSA_public_decrypt(msg.Length, msg, array, this.ptr, (int)padding));
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				global::System.Buffer.BlockCopy(array, 0, array2, 0, num);
				return array2;
			}
			return array;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000065F8 File Offset: 0x000047F8
		public byte[] PrivateDecrypt(byte[] msg, global::OpenSSL.Crypto.RSA.Padding padding)
		{
			byte[] array = new byte[this.Size];
			int num = global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RSA_private_decrypt(msg.Length, msg, array, this.ptr, (int)padding));
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				global::System.Buffer.BlockCopy(array, 0, array2, 0, num);
				return array2;
			}
			return array;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00006642 File Offset: 0x00004842
		public void WritePublicKey(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.PEM_write_bio_RSA_PUBKEY(bio.Handle, this.ptr));
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000665C File Offset: 0x0000485C
		public void WritePrivateKey(global::OpenSSL.Core.BIO bio, global::OpenSSL.Crypto.Cipher enc, global::OpenSSL.Core.PasswordHandler passwd, object arg)
		{
			global::OpenSSL.Core.PasswordThunk passwordThunk = new global::OpenSSL.Core.PasswordThunk(passwd, arg);
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.PEM_write_bio_RSAPrivateKey(bio.Handle, this.ptr, (enc == null) ? global::System.IntPtr.Zero : enc.Handle, null, 0, passwordThunk.Callback, global::System.IntPtr.Zero));
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000066A8 File Offset: 0x000048A8
		public bool Check()
		{
			int num = global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RSA_check_key(this.ptr));
			return num == 1;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000066CA File Offset: 0x000048CA
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RSA_print(bio.Handle, this.ptr, 0));
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000066E4 File Offset: 0x000048E4
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.RSA_free(this.ptr);
		}

		// Token: 0x04000263 RID: 611
		private const int FlagCacheMont_P = 1;

		// Token: 0x04000264 RID: 612
		private const int FlagNoExpConstTime = 2;

		// Token: 0x04000265 RID: 613
		private const int FlagNoConstTime = 256;

		// Token: 0x04000266 RID: 614
		private global::OpenSSL.Core.BigNumber.GeneratorThunk thunk;

		// Token: 0x0200005D RID: 93
		private struct rsa_st
		{
			// Token: 0x04000267 RID: 615
			public int pad;

			// Token: 0x04000268 RID: 616
			public int version;

			// Token: 0x04000269 RID: 617
			public global::System.IntPtr meth;

			// Token: 0x0400026A RID: 618
			public global::System.IntPtr engine;

			// Token: 0x0400026B RID: 619
			public global::System.IntPtr n;

			// Token: 0x0400026C RID: 620
			public global::System.IntPtr e;

			// Token: 0x0400026D RID: 621
			public global::System.IntPtr d;

			// Token: 0x0400026E RID: 622
			public global::System.IntPtr p;

			// Token: 0x0400026F RID: 623
			public global::System.IntPtr q;

			// Token: 0x04000270 RID: 624
			public global::System.IntPtr dmp1;

			// Token: 0x04000271 RID: 625
			public global::System.IntPtr dmq1;

			// Token: 0x04000272 RID: 626
			public global::System.IntPtr iqmp;

			// Token: 0x04000273 RID: 627
			public global::System.IntPtr ex_data_sk;

			// Token: 0x04000274 RID: 628
			public int ex_data_dummy;

			// Token: 0x04000275 RID: 629
			public int references;

			// Token: 0x04000276 RID: 630
			public int flags;

			// Token: 0x04000277 RID: 631
			public global::System.IntPtr _method_mod_n;

			// Token: 0x04000278 RID: 632
			public global::System.IntPtr _method_mod_p;

			// Token: 0x04000279 RID: 633
			public global::System.IntPtr _method_mod_q;

			// Token: 0x0400027A RID: 634
			public global::System.IntPtr bignum_data;

			// Token: 0x0400027B RID: 635
			public global::System.IntPtr blinding;

			// Token: 0x0400027C RID: 636
			public global::System.IntPtr mt_blinding;
		}

		// Token: 0x0200005E RID: 94
		public enum Padding
		{
			// Token: 0x0400027E RID: 638
			PKCS1 = 1,
			// Token: 0x0400027F RID: 639
			SSLv23,
			// Token: 0x04000280 RID: 640
			None,
			// Token: 0x04000281 RID: 641
			OAEP,
			// Token: 0x04000282 RID: 642
			X931
		}
	}
}
