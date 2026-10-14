using System;
using System.Diagnostics.CodeAnalysis;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000033 RID: 51
	[global::System.Serializable]
	public class fp_font_pack_info_t : global::Motorola.Common.Communication.CommonUtil.fp_any_pack_info_t
	{
		// Token: 0x06000188 RID: 392 RVA: 0x000055F8 File Offset: 0x000037F8
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "i+1")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "i+4")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "i+3")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "i+2")]
		public void GetDatafromRaw(byte[] raw, uint i)
		{
			this.font_id = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.zoom_setting = raw[(int)((global::System.UIntPtr)i)];
			i += 4U;
			this.font_height = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.blk_char_width = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.unicode_to_glyph_data_size = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.glyph_data_size = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.lang_font_id = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
			i += 4U;
			this.device_id = (uint)((int)raw[(int)((global::System.UIntPtr)(i + 3U))] << 24 | (int)raw[(int)((global::System.UIntPtr)(i + 2U))] << 16 | (int)raw[(int)((global::System.UIntPtr)(i + 1U))] << 8 | (int)raw[(int)((global::System.UIntPtr)i)]);
		}

		// Token: 0x04000171 RID: 369
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint font_id;

		// Token: 0x04000172 RID: 370
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public byte zoom_setting;

		// Token: 0x04000173 RID: 371
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint font_height;

		// Token: 0x04000174 RID: 372
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint blk_char_width;

		// Token: 0x04000175 RID: 373
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint unicode_to_glyph_data_size;

		// Token: 0x04000176 RID: 374
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint glyph_data_size;

		// Token: 0x04000177 RID: 375
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint lang_font_id;

		// Token: 0x04000178 RID: 376
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public uint device_id;
	}
}
