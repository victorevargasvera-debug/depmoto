using System;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200006B RID: 107
	public class OptionValueEventArgs : global::System.EventArgs
	{
		// Token: 0x06000277 RID: 631 RVA: 0x0000BFD9 File Offset: 0x0000A1D9
		public OptionValueEventArgs(string section_name, string value_name, object value)
		{
			this.section_name = section_name;
			this.value_name = value_name;
			this.value = value;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000BFF6 File Offset: 0x0000A1F6
		public string SectionName
		{
			get
			{
				return this.section_name;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000BFFE File Offset: 0x0000A1FE
		public string ValueName
		{
			get
			{
				return this.value_name;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000C006 File Offset: 0x0000A206
		public object Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x040002F2 RID: 754
		private string section_name;

		// Token: 0x040002F3 RID: 755
		private string value_name;

		// Token: 0x040002F4 RID: 756
		private object value;
	}
}
