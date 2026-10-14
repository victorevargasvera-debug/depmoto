using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Compression
{
	// Token: 0x02000010 RID: 16
	public class LZMAWrapper
	{
		// Token: 0x0600006A RID: 106 RVA: 0x0000BD50 File Offset: 0x0000B150
		public static void DataCompress(byte[] sourceData, byte[] outData, ref uint outLen, int dictSize)
		{
			ref byte byte& = ref sourceData[0];
			ref byte byte&2 = ref outData[0];
			ref uint uint32& = ref outLen;
			if (global::<Module>.LZMA_Compress(ref byte&2, ref uint32&, ref byte&, (uint)sourceData.Length, dictSize) != null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_Compression_LZMA_Compress_Failed);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000BD88 File Offset: 0x0000B188
		public unsafe static void DataDecompress(byte[] sourceData, out byte[] outData, ref uint outLen)
		{
			ref byte byte& = ref sourceData[0];
			ref uint uint32& = ref outLen;
			byte* ptr = null;
			if (global::<Module>.LZMA_Uncompress(&ptr, ref uint32&, ref byte&, (uint)sourceData.Length) == null)
			{
				uint num = outLen;
				if (num > 0U)
				{
					outData = new byte[num];
					uint num2 = 0U;
					if (0U < outLen)
					{
						do
						{
							outData[(int)num2] = num2[ptr];
							num2 += 1U;
						}
						while (num2 < outLen);
					}
					return;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_Compression_LZMA_Decompress_Failed);
		}
	}
}
