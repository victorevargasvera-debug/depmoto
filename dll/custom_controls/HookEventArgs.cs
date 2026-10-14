using System;

namespace custom_controls
{
	// Token: 0x0200007A RID: 122
	public class HookEventArgs : global::System.EventArgs
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0004DDC8 File Offset: 0x0004BFC8
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x0004DE0C File Offset: 0x0004C00C
		public global::System.IntPtr WParam
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return this.a;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0004DE50 File Offset: 0x0004C050
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x0004DE94 File Offset: 0x0004C094
		public global::System.IntPtr LParam
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return this.b;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x040003A2 RID: 930
		public int HookCode;

		// Token: 0x040003A3 RID: 931
		private global::System.IntPtr a;

		// Token: 0x040003A4 RID: 932
		private global::System.IntPtr b;
	}
}
