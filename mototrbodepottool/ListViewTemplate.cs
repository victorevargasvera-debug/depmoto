using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace mototrbodepottool
{
	// Token: 0x0200000B RID: 11
	public class ListViewTemplate : global::System.Windows.Forms.ListView
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00004B10 File Offset: 0x00003B10
		protected virtual void a(bool A_0)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.a.Dispose();
					num = 2;
					continue;
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						num = 4;
						continue;
					}
					break;
				case 2:
					goto IL_56;
				case 4:
					if (this.a != null)
					{
						num = 0;
						continue;
					}
					goto IL_91;
				}
				IL_2E:
				if (A_0)
				{
					if (true)
					{
					}
					num = 1;
					continue;
				}
				break;
				goto IL_2E;
			}
			IL_56:
			IL_91:
			base.Dispose(A_0);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00004BB8 File Offset: 0x00003BB8
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00004BFC File Offset: 0x00003BFC
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Localizable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("Change to the right-to-left layout.")]
		public bool Mirrored
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
				return this.b;
			}
			set
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_6C;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6E;
						default:
							if (false)
							{
							}
							this.b = value;
							if (true)
							{
							}
							num = 0;
							continue;
						}
						break;
					}
					if (this.b == value)
					{
						break;
					}
					num = 2;
				}
				IL_6C:
				IL_6E:
				base.OnRightToLeftChanged(global::System.EventArgs.Empty);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00004C84 File Offset: 0x00003C84
		protected virtual global::System.Windows.Forms.CreateParams CreateParams
		{
			get
			{
				global::System.Windows.Forms.CreateParams createParams;
				for (;;)
				{
					createParams = base.CreateParams;
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								return createParams;
							default:
								if (false)
								{
								}
								createParams.ExStyle |= 4194304;
								if (true)
								{
								}
								num = 1;
								continue;
							}
							break;
						case 1:
							return createParams;
						case 2:
							if (this.Mirrored)
							{
								num = 0;
								continue;
							}
							return createParams;
						}
						break;
					}
				}
				return createParams;
			}
		}

		// Token: 0x04000100 RID: 256
		private global::System.ComponentModel.Container a;

		// Token: 0x04000101 RID: 257
		private bool b;
	}
}
