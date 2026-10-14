using System;
using System.Text;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200000E RID: 14
	public static class StrangeName
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00005836 File Offset: 0x00003A36
		public static byte[] DefOne
		{
			get
			{
				return global::System.Text.Encoding.ASCII.GetBytes("HAVNCPSCMTTUNERAIRTRACER");
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00005847 File Offset: 0x00003A47
		public static byte[] DefTwo
		{
			get
			{
				return global::System.Text.Encoding.ASCII.GetBytes("VEDKDJSP");
			}
		}

		// Token: 0x0400001F RID: 31
		private const string DefStrOne = "HAVNCPSCMTTUNERAIRTRACER";

		// Token: 0x04000020 RID: 32
		private const string DefStrTwo = "VEDKDJSP";
	}
}
