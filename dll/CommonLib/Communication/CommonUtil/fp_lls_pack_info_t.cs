using System;
using System.Diagnostics.CodeAnalysis;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000034 RID: 52
	[global::System.Serializable]
	public class fp_lls_pack_info_t : global::Motorola.Common.Communication.CommonUtil.fp_any_pack_info_t
	{
		// Token: 0x0600018A RID: 394 RVA: 0x0000574B File Offset: 0x0000394B
		public fp_lls_pack_info_t()
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00005754 File Offset: 0x00003954
		public fp_lls_pack_info_t(global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t packInfo)
		{
			this.pack_based_language = packInfo.pack_based_language;
			this.size_prompt_data = packInfo.size_prompt_data;
			this.size_decode_table = packInfo.size_decode_table;
			this.size_prompt_table = packInfo.size_prompt_table;
			this.size_prompt_string_ids_table = packInfo.size_prompt_string_ids_table;
			this.size_of_reserved_space = packInfo.size_of_reserved_space;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000057B0 File Offset: 0x000039B0
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "i+3")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "i+1")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "i+2")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "i+4")]
		public void GetDatafromRaw(byte[] raw, uint i)
		{
			this.pack_based_language = raw[(int)((global::System.UIntPtr)i)];
			i += 4U;
			this.size_prompt_data = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.size_decode_table = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.size_prompt_table = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.size_prompt_string_ids_table = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.size_of_reserved_space = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000058A8 File Offset: 0x00003AA8
		public byte[] GenerateRawData()
		{
			byte[] array = new byte[24];
			int num = 0;
			array[num] = this.pack_based_language;
			num += 4;
			global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t.StoreUint32(array, ref num, this.size_prompt_data);
			global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t.StoreUint32(array, ref num, this.size_decode_table);
			global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t.StoreUint32(array, ref num, this.size_prompt_table);
			global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t.StoreUint32(array, ref num, this.size_prompt_string_ids_table);
			global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t.StoreUint32(array, ref num, this.size_of_reserved_space);
			return array;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00005914 File Offset: 0x00003B14
		private static void StoreUint32(byte[] raw, ref int idx, uint value)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(value);
			global::System.Array.Copy(bytes, 0, raw, idx, bytes.Length);
			idx += 4;
		}

		// Token: 0x04000179 RID: 377
		public const uint FP_LLS_PACK_INFO_SIZE = 24U;

		// Token: 0x0400017A RID: 378
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public byte pack_based_language;

		// Token: 0x0400017B RID: 379
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint size_prompt_data;

		// Token: 0x0400017C RID: 380
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint size_decode_table;

		// Token: 0x0400017D RID: 381
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint size_prompt_table;

		// Token: 0x0400017E RID: 382
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint size_prompt_string_ids_table;

		// Token: 0x0400017F RID: 383
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint size_of_reserved_space;
	}
}
