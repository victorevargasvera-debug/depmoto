using System;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200001A RID: 26
	[global::System.Serializable]
	public class LocalLanguagaePack
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002D4C File Offset: 0x00000F4C
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002D54 File Offset: 0x00000F54
		public byte[] LlpValue { get; set; }

		// Token: 0x060000B5 RID: 181 RVA: 0x00002D5D File Offset: 0x00000F5D
		public LocalLanguagaePack()
		{
			this.LlpValue = null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002D6C File Offset: 0x00000F6C
		public void Initialize(byte[] llpData)
		{
			this.LlpValue = new byte[llpData.Length];
			global::System.Array.Copy(llpData, this.LlpValue, llpData.Length);
		}
	}
}
