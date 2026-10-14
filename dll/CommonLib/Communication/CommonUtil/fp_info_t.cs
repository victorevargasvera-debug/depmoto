using System;
using System.Diagnostics.CodeAnalysis;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000030 RID: 48
	[global::System.Serializable]
	public class fp_info_t : global::System.ICloneable
	{
		// Token: 0x06000182 RID: 386 RVA: 0x000053BC File Offset: 0x000035BC
		public fp_info_t()
		{
			this.pFPStartAdd = 0U;
			this.pFPEndAdd = 0U;
			this.fp_packs = new global::Motorola.Common.Communication.CommonUtil.fp_version_t[16];
			for (int i = 0; i < this.fp_packs.Length; i++)
			{
				this.fp_packs[i] = new global::Motorola.Common.Communication.CommonUtil.fp_version_t();
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000540C File Offset: 0x0000360C
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.fp_info_t fp_info_t = new global::Motorola.Common.Communication.CommonUtil.fp_info_t();
			fp_info_t.pFPStartAdd = this.pFPStartAdd;
			fp_info_t.pFPEndAdd = this.pFPEndAdd;
			for (int i = 0; i < this.fp_packs.Length; i++)
			{
				fp_info_t.fp_packs[i] = (global::Motorola.Common.Communication.CommonUtil.fp_version_t)this.fp_packs[i].Clone();
			}
			return fp_info_t;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00005468 File Offset: 0x00003668
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "index+2")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "index+3")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "index+4")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "index+8")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "index+1")]
		public void GetDatafromRaw(byte[] raw, uint index)
		{
			this.pFPStartAdd = (uint)((int)raw[(int)((global::System.UIntPtr)(index + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(index + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(index + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)index)]);
			index += 4U;
			this.pFPEndAdd = (uint)((int)raw[(int)((global::System.UIntPtr)(index + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(index + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(index + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)index)]);
			index += 4U;
			for (int i = 0; i < this.fp_packs.Length; i++)
			{
				this.fp_packs[i].GetDatafromRaw(raw, index);
				index += 8U;
			}
		}

		// Token: 0x04000167 RID: 359
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint pFPStartAdd;

		// Token: 0x04000168 RID: 360
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint pFPEndAdd;

		// Token: 0x04000169 RID: 361
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public global::Motorola.Common.Communication.CommonUtil.fp_version_t[] fp_packs;
	}
}
