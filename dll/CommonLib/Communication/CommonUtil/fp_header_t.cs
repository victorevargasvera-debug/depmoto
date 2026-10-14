using System;
using System.Diagnostics.CodeAnalysis;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200002E RID: 46
	[global::System.Serializable]
	public class fp_header_t
	{
		// Token: 0x0600016F RID: 367 RVA: 0x000050E8 File Offset: 0x000032E8
		public void GetHeaderfromRawData(byte[] raw)
		{
			uint num = 0U;
			this.checksum = (uint)((int)raw[(int)((global::System.UIntPtr)(num + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(num + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(num + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)num)]);
			num += 4U;
			this.header_version = raw[(int)((global::System.UIntPtr)num)];
			this.pack_product_platform = raw[(int)((global::System.UIntPtr)(num + 1U))];
			this.pack_release_number = raw[(int)((global::System.UIntPtr)(num + 2U))];
			this.pack_revision_number = raw[(int)((global::System.UIntPtr)(num + 3U))];
			this.pack_sub_revision_num = raw[(int)((global::System.UIntPtr)(num + 4U))];
			this.pack_type = raw[(int)((global::System.UIntPtr)(num + 5U))];
			num += 8U;
			this.pack_size = (uint)((int)raw[(int)((global::System.UIntPtr)(num + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(num + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(num + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)num)]);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00005193 File Offset: 0x00003393
		public fp_header_t()
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000519C File Offset: 0x0000339C
		public fp_header_t(global::Motorola.Common.Communication.CommonUtil.fp_header_t fpHeader)
		{
			this.checksum = fpHeader.checksum;
			this.header_version = fpHeader.header_version;
			this.pack_product_platform = fpHeader.pack_product_platform;
			this.pack_release_number = fpHeader.pack_release_number;
			this.pack_revision_number = fpHeader.pack_revision_number;
			this.pack_sub_revision_num = fpHeader.pack_sub_revision_num;
			this.pack_type = fpHeader.pack_type;
			this.pack_size = fpHeader.pack_size;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00005210 File Offset: 0x00003410
		public byte[] GeneratellpHeaderData()
		{
			byte[] array = new byte[16];
			int num = 0;
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.StoreUint32(array, ref num, this.checksum);
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.StoreByte(array, ref num, this.header_version);
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.StoreByte(array, ref num, this.pack_product_platform);
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.StoreByte(array, ref num, this.pack_release_number);
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.StoreByte(array, ref num, this.pack_revision_number);
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.StoreByte(array, ref num, this.pack_sub_revision_num);
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.StoreByte(array, ref num, this.pack_type);
			num += 2;
			global::Motorola.Common.Communication.CommonUtil.fp_header_t.StoreUint32(array, ref num, this.pack_size);
			return array;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000529D File Offset: 0x0000349D
		private static void StoreByte(byte[] raw, ref int idx, byte value)
		{
			raw[idx] = value;
			idx++;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000052AC File Offset: 0x000034AC
		private static void StoreUint32(byte[] raw, ref int idx, uint value)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(value);
			global::System.Array.Copy(bytes, 0, raw, idx, bytes.Length);
			idx += 4;
		}

		// Token: 0x04000158 RID: 344
		public const uint FP_HEADER_SIZE = 16U;

		// Token: 0x04000159 RID: 345
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint checksum;

		// Token: 0x0400015A RID: 346
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public byte header_version;

		// Token: 0x0400015B RID: 347
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public byte pack_product_platform;

		// Token: 0x0400015C RID: 348
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public byte pack_release_number;

		// Token: 0x0400015D RID: 349
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public byte pack_revision_number;

		// Token: 0x0400015E RID: 350
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public byte pack_sub_revision_num;

		// Token: 0x0400015F RID: 351
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public byte pack_type;

		// Token: 0x04000160 RID: 352
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint pack_size;
	}
}
