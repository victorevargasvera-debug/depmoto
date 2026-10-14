using System;
using System.Text;

namespace OpenSSL.Core
{
	// Token: 0x0200005B RID: 91
	public class Random
	{
		// Token: 0x060003BA RID: 954 RVA: 0x00005FAC File Offset: 0x000041AC
		public static void Seed(byte[] seed)
		{
			global::OpenSSL.Core.Native.RAND_seed(seed, seed.Length);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00005FB8 File Offset: 0x000041B8
		public static void Seed(string seed)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(seed);
			global::OpenSSL.Core.Native.RAND_seed(bytes, bytes.Length);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00005FDC File Offset: 0x000041DC
		public static byte[] PseudoBytes(int len)
		{
			byte[] array = new byte[len];
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RAND_pseudo_bytes(array, array.Length));
			return array;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00006000 File Offset: 0x00004200
		public static void Cleanup()
		{
			global::OpenSSL.Core.Native.RAND_cleanup();
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00006008 File Offset: 0x00004208
		public static byte[] Bytes(int len)
		{
			byte[] array = new byte[len];
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RAND_bytes(array, len));
			return array;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000602A File Offset: 0x0000422A
		public static void Add(byte[] buf, double entropy)
		{
			global::OpenSSL.Core.Native.RAND_add(buf, buf.Length, entropy);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00006036 File Offset: 0x00004236
		public static void LoadFile(string filename, int max_bytes)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RAND_load_file(filename, max_bytes));
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00006045 File Offset: 0x00004245
		public static void WriteFile(string filename)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RAND_write_file(filename));
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00006054 File Offset: 0x00004254
		public static string GetFilename()
		{
			byte[] array = new byte[1024];
			return global::OpenSSL.Core.Native.RAND_file_name(array, (uint)array.Length);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00006075 File Offset: 0x00004275
		public static int Status
		{
			get
			{
				return global::OpenSSL.Core.Native.RAND_status();
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000607C File Offset: 0x0000427C
		public static void GatherEntropy(string path, byte[] buf, int bytes)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RAND_query_egd_bytes(path, buf, bytes));
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000608C File Offset: 0x0000428C
		public static void GatherEntropy(string path)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RAND_egd(path));
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000609A File Offset: 0x0000429A
		public static void GatherEntropy(string path, int bytes)
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RAND_egd_bytes(path, bytes));
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000060A9 File Offset: 0x000042A9
		public static void Poll()
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.RAND_poll());
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000060B8 File Offset: 0x000042B8
		public static global::OpenSSL.Core.BigNumber Next(int bits, int top, int bottom)
		{
			global::OpenSSL.Core.BigNumber bigNumber = new global::OpenSSL.Core.BigNumber();
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.BN_rand(bigNumber.Handle, bits, top, bottom));
			return bigNumber;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000060E0 File Offset: 0x000042E0
		public static global::OpenSSL.Core.BigNumber NextRange(global::OpenSSL.Core.BigNumber range)
		{
			global::OpenSSL.Core.BigNumber bigNumber = new global::OpenSSL.Core.BigNumber();
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.BN_rand_range(bigNumber.Handle, range.Handle));
			return bigNumber;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000610C File Offset: 0x0000430C
		public static global::OpenSSL.Core.BigNumber PseudoNext(int bits, int top, int bottom)
		{
			global::OpenSSL.Core.BigNumber bigNumber = new global::OpenSSL.Core.BigNumber();
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.BN_pseudo_rand(bigNumber.Handle, bits, top, bottom));
			return bigNumber;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00006134 File Offset: 0x00004334
		public static global::OpenSSL.Core.BigNumber PseudoNextRange(global::OpenSSL.Core.BigNumber range)
		{
			global::OpenSSL.Core.BigNumber bigNumber = new global::OpenSSL.Core.BigNumber();
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.BN_pseudo_rand_range(bigNumber.Handle, range.Handle));
			return bigNumber;
		}
	}
}
