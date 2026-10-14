namespace custom_controls
{
	// Token: 0x02000044 RID: 68
	public partial class CFormTemplate : global::System.Windows.Forms.Form
	{
		// Token: 0x06000345 RID: 837 RVA: 0x00038EC8 File Offset: 0x000370C8
		protected override void Dispose(bool disposing)
		{
			for (;;)
			{
				IL_00:
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (this.c != null)
						{
							if (true)
							{
							}
							num = 1;
							continue;
						}
						goto IL_91;
					case 1:
						this.c.Dispose();
						num = 4;
						continue;
					case 3:
						num = 0;
						continue;
					case 4:
						goto IL_6A;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						if (false)
						{
						}
						if (!disposing)
						{
							goto IL_91;
						}
						num = 3;
						break;
					}
				}
			}
			IL_6A:
			IL_91:
			base.Dispose(disposing);
		}

		// Token: 0x0400025A RID: 602
		private global::System.ComponentModel.Container c;
	}
}
