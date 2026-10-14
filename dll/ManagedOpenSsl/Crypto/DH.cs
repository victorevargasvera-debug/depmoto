using System;
using System.Runtime.InteropServices;
using OpenSSL.Core;

namespace OpenSSL.Crypto
{
	// Token: 0x0200002C RID: 44
	public class DH : global::OpenSSL.Core.Base
	{
		// Token: 0x060000CF RID: 207 RVA: 0x000042AB File Offset: 0x000024AB
		internal DH(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000042B5 File Offset: 0x000024B5
		public DH(int primeLen, int generator) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.DH_generate_parameters(primeLen, generator, global::System.IntPtr.Zero, global::System.IntPtr.Zero)), true)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000042D4 File Offset: 0x000024D4
		public DH(int primeLen, int generator, global::OpenSSL.Core.BigNumber.GeneratorHandler callback, object arg) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.DH_new()), true)
		{
			this.thunk = new global::OpenSSL.Core.BigNumber.GeneratorThunk(callback, arg);
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.DH_generate_parameters_ex(this.ptr, primeLen, generator, this.thunk.CallbackStruct));
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004314 File Offset: 0x00002514
		public DH() : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.DH_new()), true)
		{
			global::OpenSSL.Crypto.DH.dh_st raw = this.Raw;
			raw.p = global::OpenSSL.Core.Native.BN_dup(global::OpenSSL.Core.BigNumber.One.Handle);
			raw.g = global::OpenSSL.Core.Native.BN_dup(global::OpenSSL.Core.BigNumber.One.Handle);
			this.Raw = raw;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000436C File Offset: 0x0000256C
		public DH(global::OpenSSL.Core.BigNumber p, global::OpenSSL.Core.BigNumber g) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.DH_new()), true)
		{
			global::OpenSSL.Crypto.DH.dh_st raw = this.Raw;
			raw.p = global::OpenSSL.Core.Native.BN_dup(p.Handle);
			raw.g = global::OpenSSL.Core.Native.BN_dup(g.Handle);
			this.Raw = raw;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000043BC File Offset: 0x000025BC
		public DH(global::OpenSSL.Core.BigNumber p, global::OpenSSL.Core.BigNumber g, global::OpenSSL.Core.BigNumber pub_key, global::OpenSSL.Core.BigNumber priv_key) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.DH_new()), true)
		{
			global::OpenSSL.Crypto.DH.dh_st raw = this.Raw;
			raw.p = global::OpenSSL.Core.Native.BN_dup(p.Handle);
			raw.g = global::OpenSSL.Core.Native.BN_dup(g.Handle);
			raw.pub_key = global::OpenSSL.Core.Native.BN_dup(pub_key.Handle);
			raw.priv_key = global::OpenSSL.Core.Native.BN_dup(priv_key.Handle);
			this.Raw = raw;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004431 File Offset: 0x00002631
		public static global::OpenSSL.Crypto.DH FromParameters(string pem)
		{
			return global::OpenSSL.Crypto.DH.FromParametersPEM(new global::OpenSSL.Core.BIO(pem));
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004440 File Offset: 0x00002640
		public static global::OpenSSL.Crypto.DH FromParametersPEM(global::OpenSSL.Core.BIO bio)
		{
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.PEM_read_bio_DHparams(bio.Handle, global::System.IntPtr.Zero, null, global::System.IntPtr.Zero));
			return new global::OpenSSL.Crypto.DH(ptr, true);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004470 File Offset: 0x00002670
		private static global::System.IntPtr Managed_DH_new()
		{
			return global::OpenSSL.Core.Native.DH_new();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004477 File Offset: 0x00002677
		private static global::System.IntPtr Managed_d2i_DHparams(out global::System.IntPtr a, global::System.IntPtr pp, int length)
		{
			return global::OpenSSL.Core.Native.d2i_DHparams(out a, pp, length);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00004484 File Offset: 0x00002684
		public static global::OpenSSL.Crypto.DH FromParametersDER(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Crypto.DH.DH_new_delegate d = new global::OpenSSL.Crypto.DH.DH_new_delegate(global::OpenSSL.Crypto.DH.Managed_DH_new);
			global::OpenSSL.Crypto.DH.d2i_DHparams_delegate d2 = new global::OpenSSL.Crypto.DH.d2i_DHparams_delegate(global::OpenSSL.Crypto.DH.Managed_d2i_DHparams);
			global::System.IntPtr functionPointerForDelegate = global::System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate<global::OpenSSL.Crypto.DH.DH_new_delegate>(d);
			global::System.IntPtr functionPointerForDelegate2 = global::System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate<global::OpenSSL.Crypto.DH.d2i_DHparams_delegate>(d2);
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.ASN1_d2i_bio(functionPointerForDelegate, functionPointerForDelegate2, bio.Handle, global::System.IntPtr.Zero));
			return new global::OpenSSL.Crypto.DH(ptr, true);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000044DE File Offset: 0x000026DE
		public void GenerateKeys()
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.DH_generate_key(this.ptr));
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000044F4 File Offset: 0x000026F4
		public byte[] ComputeKey(global::OpenSSL.Core.BigNumber pubkey)
		{
			int num = global::OpenSSL.Core.Native.DH_size(this.ptr);
			byte[] array = new byte[num];
			global::OpenSSL.Core.Native.DH_compute_key(array, pubkey.Handle, this.ptr);
			return array;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004528 File Offset: 0x00002728
		public void WriteParametersPEM(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.PEM_write_bio_DHparams(bio.Handle, this.ptr));
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004541 File Offset: 0x00002741
		private int Managed_i2d_DHparams(global::System.IntPtr a, global::System.IntPtr pp)
		{
			return global::OpenSSL.Core.Native.i2d_DHparams(a, pp);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000454C File Offset: 0x0000274C
		public void WriteParametersDER(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Crypto.DH.i2d_DHparams_delegate d = new global::OpenSSL.Crypto.DH.i2d_DHparams_delegate(this.Managed_i2d_DHparams);
			global::System.IntPtr functionPointerForDelegate = global::System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate<global::OpenSSL.Crypto.DH.i2d_DHparams_delegate>(d);
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.ASN1_i2d_bio(functionPointerForDelegate, bio.Handle, this.ptr));
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004585 File Offset: 0x00002785
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.DHparams_print(bio.Handle, this.ptr));
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000045A0 File Offset: 0x000027A0
		public global::OpenSSL.Crypto.DH.CheckCode Check()
		{
			int result = 0;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.DH_check(this.ptr, out result));
			return (global::OpenSSL.Crypto.DH.CheckCode)result;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000045C3 File Offset: 0x000027C3
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000045DF File Offset: 0x000027DF
		private global::OpenSSL.Crypto.DH.dh_st Raw
		{
			get
			{
				return (global::OpenSSL.Crypto.DH.dh_st)global::System.Runtime.InteropServices.Marshal.PtrToStructure(this.ptr, typeof(global::OpenSSL.Crypto.DH.dh_st));
			}
			set
			{
				global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::OpenSSL.Crypto.DH.dh_st>(value, this.ptr, false);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000045EE File Offset: 0x000027EE
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00004604 File Offset: 0x00002804
		public global::OpenSSL.Core.BigNumber P
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.p, false);
			}
			set
			{
				global::OpenSSL.Crypto.DH.dh_st raw = this.Raw;
				raw.p = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00004631 File Offset: 0x00002831
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00004644 File Offset: 0x00002844
		public global::OpenSSL.Core.BigNumber G
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.g, false);
			}
			set
			{
				global::OpenSSL.Crypto.DH.dh_st raw = this.Raw;
				raw.g = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00004671 File Offset: 0x00002871
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00004684 File Offset: 0x00002884
		public global::OpenSSL.Core.BigNumber PublicKey
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.pub_key, false);
			}
			set
			{
				global::OpenSSL.Crypto.DH.dh_st raw = this.Raw;
				raw.pub_key = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000046B1 File Offset: 0x000028B1
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000046C4 File Offset: 0x000028C4
		public global::OpenSSL.Core.BigNumber PrivateKey
		{
			get
			{
				return new global::OpenSSL.Core.BigNumber(this.Raw.priv_key, false);
			}
			set
			{
				global::OpenSSL.Crypto.DH.dh_st raw = this.Raw;
				raw.priv_key = global::OpenSSL.Core.Native.BN_dup(value.Handle);
				this.Raw = raw;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000046F4 File Offset: 0x000028F4
		public string PEM
		{
			get
			{
				string result;
				using (global::OpenSSL.Core.BIO bio = global::OpenSSL.Core.BIO.MemoryBuffer())
				{
					this.WriteParametersPEM(bio);
					result = bio.ReadString();
				}
				return result;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00004734 File Offset: 0x00002934
		public byte[] DER
		{
			get
			{
				byte[] array;
				using (global::OpenSSL.Core.BIO bio = global::OpenSSL.Core.BIO.MemoryBuffer())
				{
					this.WriteParametersDER(bio);
					array = bio.ReadBytes((int)bio.NumberWritten).Array;
				}
				return array;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00004780 File Offset: 0x00002980
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00004798 File Offset: 0x00002998
		public bool NoExpConstantTime
		{
			get
			{
				return (this.Raw.flags & 2) != 0;
			}
			set
			{
				global::OpenSSL.Crypto.DH.dh_st raw = this.Raw;
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

		// Token: 0x060000EF RID: 239 RVA: 0x000047D7 File Offset: 0x000029D7
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.DH_free(this.ptr);
		}

		// Token: 0x04000135 RID: 309
		public const int Generator2 = 2;

		// Token: 0x04000136 RID: 310
		public const int Generator5 = 5;

		// Token: 0x04000137 RID: 311
		private const int FlagCacheMont_P = 1;

		// Token: 0x04000138 RID: 312
		private const int FlagNoExpConstTime = 2;

		// Token: 0x04000139 RID: 313
		private global::OpenSSL.Core.BigNumber.GeneratorThunk thunk;

		// Token: 0x0200002D RID: 45
		[global::System.Flags]
		public enum CheckCode
		{
			// Token: 0x0400013B RID: 315
			CheckP_NotPrime = 1,
			// Token: 0x0400013C RID: 316
			CheckP_NotSafePrime = 2,
			// Token: 0x0400013D RID: 317
			UnableToCheckGenerator = 4,
			// Token: 0x0400013E RID: 318
			NotSuitableGenerator = 8
		}

		// Token: 0x0200002E RID: 46
		private struct dh_st
		{
			// Token: 0x0400013F RID: 319
			public int pad;

			// Token: 0x04000140 RID: 320
			public int version;

			// Token: 0x04000141 RID: 321
			public global::System.IntPtr p;

			// Token: 0x04000142 RID: 322
			public global::System.IntPtr g;

			// Token: 0x04000143 RID: 323
			public int length;

			// Token: 0x04000144 RID: 324
			public global::System.IntPtr pub_key;

			// Token: 0x04000145 RID: 325
			public global::System.IntPtr priv_key;

			// Token: 0x04000146 RID: 326
			public int flags;

			// Token: 0x04000147 RID: 327
			public global::System.IntPtr method_mont_p;

			// Token: 0x04000148 RID: 328
			public global::System.IntPtr q;

			// Token: 0x04000149 RID: 329
			public global::System.IntPtr j;

			// Token: 0x0400014A RID: 330
			public global::System.IntPtr seed;

			// Token: 0x0400014B RID: 331
			public int seedlen;

			// Token: 0x0400014C RID: 332
			public global::System.IntPtr counter;

			// Token: 0x0400014D RID: 333
			public int references;

			// Token: 0x0400014E RID: 334
			public global::System.IntPtr ex_data_sk;

			// Token: 0x0400014F RID: 335
			public int ex_data_dummy;

			// Token: 0x04000150 RID: 336
			public global::System.IntPtr meth;

			// Token: 0x04000151 RID: 337
			public global::System.IntPtr engine;
		}

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060000F1 RID: 241
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		private delegate global::System.IntPtr DH_new_delegate();

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x060000F5 RID: 245
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		private delegate global::System.IntPtr d2i_DHparams_delegate(out global::System.IntPtr a, global::System.IntPtr pp, int length);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x060000F9 RID: 249
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		private delegate int i2d_DHparams_delegate(global::System.IntPtr a, global::System.IntPtr pp);
	}
}
