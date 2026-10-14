using System;
using System.Text;

namespace OpenSSL.Core
{
	// Token: 0x02000008 RID: 8
	public class BigNumber : global::OpenSSL.Core.Base, global::System.IComparable<global::OpenSSL.Core.BigNumber>
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0000252B File Offset: 0x0000072B
		public static string Options
		{
			get
			{
				return global::OpenSSL.Core.Native.BN_options();
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002532 File Offset: 0x00000732
		internal BigNumber(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000253C File Offset: 0x0000073C
		public BigNumber() : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.BN_new()), true)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000254F File Offset: 0x0000074F
		public BigNumber(global::OpenSSL.Core.BigNumber rhs) : base(global::OpenSSL.Core.Native.BN_dup(rhs.ptr), true)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002563 File Offset: 0x00000763
		public BigNumber(uint value) : this()
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.BN_set_word(this.ptr, value));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002580 File Offset: 0x00000780
		public static global::OpenSSL.Core.BigNumber FromDecimalString(string str)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(str);
			global::System.IntPtr ptr;
			int num = global::OpenSSL.Core.Native.BN_dec2bn(out ptr, bytes);
			if (num <= 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
			return new global::OpenSSL.Core.BigNumber(ptr, true);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000025B4 File Offset: 0x000007B4
		public static global::OpenSSL.Core.BigNumber FromHexString(string str)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(str);
			global::System.IntPtr ptr;
			int num = global::OpenSSL.Core.Native.BN_hex2bn(out ptr, bytes);
			if (num <= 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
			return new global::OpenSSL.Core.BigNumber(ptr, true);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000025E8 File Offset: 0x000007E8
		public static global::OpenSSL.Core.BigNumber FromArray(byte[] buf)
		{
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.BN_bin2bn(buf, buf.Length, global::System.IntPtr.Zero);
			return new global::OpenSSL.Core.BigNumber(global::OpenSSL.Core.Native.ExpectNonNull(ptr), true);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002610 File Offset: 0x00000810
		public string ToDecimalString()
		{
			return global::OpenSSL.Core.Native.PtrToStringAnsi(global::OpenSSL.Core.Native.BN_bn2dec(this.ptr), true);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002623 File Offset: 0x00000823
		public string ToHexString()
		{
			return global::OpenSSL.Core.Native.PtrToStringAnsi(global::OpenSSL.Core.Native.BN_bn2hex(this.ptr), true);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002636 File Offset: 0x00000836
		public static implicit operator uint(global::OpenSSL.Core.BigNumber rhs)
		{
			return global::OpenSSL.Core.Native.BN_get_word(rhs.ptr);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002643 File Offset: 0x00000843
		public static implicit operator global::OpenSSL.Core.BigNumber(uint value)
		{
			return new global::OpenSSL.Core.BigNumber(value);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000264C File Offset: 0x0000084C
		public static implicit operator byte[](global::OpenSSL.Core.BigNumber rhs)
		{
			byte[] array = new byte[rhs.Bytes];
			global::OpenSSL.Core.Native.BN_bn2bin(rhs.ptr, array);
			return array;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002673 File Offset: 0x00000873
		public int Bits
		{
			get
			{
				return global::OpenSSL.Core.Native.BN_num_bits(this.ptr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002680 File Offset: 0x00000880
		public int Bytes
		{
			get
			{
				return (this.Bits + 7) / 8;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000268C File Offset: 0x0000088C
		public void Clear()
		{
			global::OpenSSL.Core.Native.BN_clear(this.ptr);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000269C File Offset: 0x0000089C
		public static global::OpenSSL.Core.BigNumber operator +(global::OpenSSL.Core.BigNumber lhs, global::OpenSSL.Core.BigNumber rhs)
		{
			global::OpenSSL.Core.BigNumber bigNumber = new global::OpenSSL.Core.BigNumber();
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.BN_add(bigNumber.Handle, lhs.Handle, rhs.Handle));
			return bigNumber;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000026D0 File Offset: 0x000008D0
		public static global::OpenSSL.Core.BigNumber operator -(global::OpenSSL.Core.BigNumber lhs, global::OpenSSL.Core.BigNumber rhs)
		{
			global::OpenSSL.Core.BigNumber bigNumber = new global::OpenSSL.Core.BigNumber();
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.BN_sub(bigNumber.Handle, lhs.Handle, rhs.Handle));
			return bigNumber;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002701 File Offset: 0x00000901
		public static bool operator ==(global::OpenSSL.Core.BigNumber lhs, global::OpenSSL.Core.BigNumber rhs)
		{
			return object.ReferenceEquals(lhs, rhs) || (lhs != null && rhs != null && lhs.Equals(rhs));
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000271D File Offset: 0x0000091D
		public static bool operator !=(global::OpenSSL.Core.BigNumber lhs, global::OpenSSL.Core.BigNumber rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000272C File Offset: 0x0000092C
		public override bool Equals(object obj)
		{
			global::OpenSSL.Core.BigNumber bigNumber = obj as global::OpenSSL.Core.BigNumber;
			return bigNumber != null && global::OpenSSL.Core.Native.BN_cmp(this.ptr, bigNumber.ptr) == 0;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002759 File Offset: 0x00000959
		public override int GetHashCode()
		{
			return this.ToDecimalString().GetHashCode();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002766 File Offset: 0x00000966
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.BN_print(bio.Handle, this.ptr));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000277F File Offset: 0x0000097F
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.BN_free(this.ptr);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000278C File Offset: 0x0000098C
		public int CompareTo(global::OpenSSL.Core.BigNumber other)
		{
			return global::OpenSSL.Core.Native.BN_cmp(this.ptr, other.ptr);
		}

		// Token: 0x04000005 RID: 5
		public static global::OpenSSL.Core.BigNumber One = new global::OpenSSL.Core.BigNumber(global::OpenSSL.Core.Native.BN_value_one(), false);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000044 RID: 68
		public delegate int GeneratorHandler(int p, int n, object arg);

		// Token: 0x0200000A RID: 10
		internal class GeneratorThunk
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000047 RID: 71 RVA: 0x000027B1 File Offset: 0x000009B1
			public global::OpenSSL.Core.Native.bn_gencb_st CallbackStruct
			{
				get
				{
					return this.gencb;
				}
			}

			// Token: 0x06000048 RID: 72 RVA: 0x000027BC File Offset: 0x000009BC
			public GeneratorThunk(global::OpenSSL.Core.BigNumber.GeneratorHandler client, object arg)
			{
				this.OnGenerator = client;
				this.arg = arg;
				this.gencb.ver = 2U;
				this.gencb.arg = global::System.IntPtr.Zero;
				this.gencb.cb = new global::OpenSSL.Core.Native.GeneratorHandler(this.OnGeneratorThunk);
			}

			// Token: 0x06000049 RID: 73 RVA: 0x0000281C File Offset: 0x00000A1C
			internal int OnGeneratorThunk(int p, int n, global::System.IntPtr arg)
			{
				if (this.OnGenerator != null)
				{
					try
					{
						return this.OnGenerator(p, n, this.arg);
					}
					catch (global::System.Exception)
					{
						return 0;
					}
					return 1;
				}
				return 1;
			}

			// Token: 0x04000006 RID: 6
			private global::OpenSSL.Core.Native.bn_gencb_st gencb = new global::OpenSSL.Core.Native.bn_gencb_st();

			// Token: 0x04000007 RID: 7
			private global::OpenSSL.Core.BigNumber.GeneratorHandler OnGenerator;

			// Token: 0x04000008 RID: 8
			private object arg;
		}
	}
}
