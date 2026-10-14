using System;

namespace Motorola.Common.Communication.Compression
{
	// Token: 0x0200000F RID: 15
	public class FastLZWrapper
	{
		// Token: 0x06000066 RID: 102 RVA: 0x0000BCCC File Offset: 0x0000B0CC
		public static void DataCompress(byte[] sourceData, byte[] outData, ref uint outLen)
		{
			ref byte source_data_ptr = ref sourceData[0];
			ref byte compres_data_ptr = ref outData[0];
			ref uint compres_len = ref outLen;
			global::<Module>.data_compress(ref source_data_ptr, sourceData.Length, ref compres_data_ptr, ref compres_len);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000BD24 File Offset: 0x0000B124
		public static void DataDecompress(byte[] sourceData, byte[] outData, ref uint outLen, int maxOut)
		{
			ref byte source_data_ptr = ref sourceData[0];
			ref byte compres_data_ptr = ref outData[0];
			ref uint compres_len = ref outLen;
			global::<Module>.data_decompress(ref source_data_ptr, sourceData.Length, ref compres_data_ptr, ref compres_len, maxOut);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000BCF8 File Offset: 0x0000B0F8
		public static void DataDecompress(byte[] sourceData, byte[] outData, ref uint outLen)
		{
			ref byte source_data_ptr = ref sourceData[0];
			ref byte compres_data_ptr = ref outData[0];
			ref uint compres_len = ref outLen;
			global::<Module>.data_decompress(ref source_data_ptr, sourceData.Length, ref compres_data_ptr, ref compres_len, outData.Length);
		}
	}
}
