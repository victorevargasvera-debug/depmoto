using System;

namespace OpenSSL.X509
{
	// Token: 0x02000085 RID: 133
	public class X509V3ExtensionValue
	{
		// Token: 0x06000554 RID: 1364 RVA: 0x0000A0FC File Offset: 0x000082FC
		public X509V3ExtensionValue(string name, bool critical, string value)
		{
			this.name = name;
			this.critical = critical;
			this.value = value;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0000A119 File Offset: 0x00008319
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x0000A121 File Offset: 0x00008321
		public bool IsCritical
		{
			get
			{
				return this.critical;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0000A129 File Offset: 0x00008329
		public string Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x040003F6 RID: 1014
		private bool critical;

		// Token: 0x040003F7 RID: 1015
		private string value;

		// Token: 0x040003F8 RID: 1016
		private string name;
	}
}
