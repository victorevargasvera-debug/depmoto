using System;
using System.Diagnostics.CodeAnalysis;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000032 RID: 50
	[global::System.Serializable]
	public class fp_language_pack_info_t : global::Motorola.Common.Communication.CommonUtil.fp_any_pack_info_t
	{
		// Token: 0x06000186 RID: 390 RVA: 0x000054FC File Offset: 0x000036FC
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "i+4")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "i+1")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "i+2")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "i+3")]
		public void GetDatafromRaw(byte[] raw, uint i)
		{
			this.language_id = raw[(int)((global::System.UIntPtr)i)];
			i += 4U;
			this.size_prompt_data = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.size_decode_table = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.size_prompt_table = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.checksum = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.lang_font_id = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
		}

		// Token: 0x0400016B RID: 363
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public byte language_id;

		// Token: 0x0400016C RID: 364
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint size_prompt_data;

		// Token: 0x0400016D RID: 365
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint size_decode_table;

		// Token: 0x0400016E RID: 366
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint size_prompt_table;

		// Token: 0x0400016F RID: 367
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint checksum;

		// Token: 0x04000170 RID: 368
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint lang_font_id;
	}
}
