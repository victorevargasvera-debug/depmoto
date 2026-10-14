using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200002F RID: 47
	[global::System.Serializable]
	public class fp_version_t : global::System.ICloneable
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000052D3 File Offset: 0x000034D3
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000052DB File Offset: 0x000034DB
		public byte fp_product_platform { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000052E4 File Offset: 0x000034E4
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000052EC File Offset: 0x000034EC
		public byte fp_release_num { get; set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000052F5 File Offset: 0x000034F5
		// (set) Token: 0x0600017A RID: 378 RVA: 0x000052FD File Offset: 0x000034FD
		public byte fp_revision_num { get; set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00005306 File Offset: 0x00003506
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000530E File Offset: 0x0000350E
		public byte fp_sub_revision_num { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00005317 File Offset: 0x00003517
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0000531F File Offset: 0x0000351F
		public byte pack_type { get; set; }

		// Token: 0x0600017F RID: 383 RVA: 0x00005328 File Offset: 0x00003528
		public object Clone()
		{
			return new global::Motorola.Common.Communication.CommonUtil.fp_version_t
			{
				fp_product_platform = this.fp_product_platform,
				fp_release_num = this.fp_release_num,
				fp_revision_num = this.fp_revision_num,
				fp_sub_revision_num = this.fp_sub_revision_num,
				pack_type = this.pack_type
			};
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00005378 File Offset: 0x00003578
		public void GetDatafromRaw(byte[] raw, uint index)
		{
			this.fp_product_platform = raw[(int)((global::System.UIntPtr)index)];
			this.fp_release_num = raw[(int)((global::System.UIntPtr)(checked(index + 1U)))];
			this.fp_revision_num = raw[(int)((global::System.UIntPtr)(checked(index + 2U)))];
			this.fp_sub_revision_num = raw[(int)((global::System.UIntPtr)(checked(index + 3U)))];
			this.pack_type = raw[(int)((global::System.UIntPtr)(checked(index + 7U)))];
		}

		// Token: 0x04000161 RID: 353
		public const uint FP_VERSION_SIZE = 8U;
	}
}
