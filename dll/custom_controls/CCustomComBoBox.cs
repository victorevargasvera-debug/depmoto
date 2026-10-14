using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x0200000F RID: 15
	public class CCustomComBoBox : global::System.Windows.Forms.ComboBox
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00007700 File Offset: 0x00005900
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00007744 File Offset: 0x00005944
		public string ResourceId
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
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						for (;;)
						{
							this.a = value;
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							}
							break;
						}
						IL_63:
						if (false)
						{
						}
						num = 1;
						continue;
						goto IL_63;
					case 1:
						return;
					}
					if (true)
					{
					}
					if (!(this.a != value))
					{
						break;
					}
					num = 0;
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000077C4 File Offset: 0x000059C4
		public CCustomComBoBox()
		{
			this.a();
			this.a = string.Empty;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000077E8 File Offset: 0x000059E8
		protected override void Dispose(bool disposing)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					goto IL_60;
				case 2:
					num = 3;
					continue;
				case 3:
					if (true)
					{
					}
					if (this.b != null)
					{
						num = 4;
						continue;
					}
					goto IL_91;
				case 4:
					goto IL_8F;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_8F:
					this.b.Dispose();
					num = 1;
					break;
				default:
					if (false)
					{
					}
					if (!disposing)
					{
						goto IL_91;
					}
					num = 2;
					break;
				}
			}
			IL_60:
			IL_91:
			base.Dispose(disposing);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00007890 File Offset: 0x00005A90
		private void a()
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
			this.b = new global::System.ComponentModel.Container();
		}

		// Token: 0x04000044 RID: 68
		private string a;

		// Token: 0x04000045 RID: 69
		private global::System.ComponentModel.IContainer b;
	}
}
