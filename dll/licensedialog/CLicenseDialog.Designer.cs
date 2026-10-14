namespace licensing
{
	// Token: 0x02000006 RID: 6
	public partial class CLicenseDialog : global::custom_controls.CFormTemplate
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002FE8 File Offset: 0x00001FE8
		protected override void Dispose(bool disposing)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.p.Dispose();
					num = 3;
					continue;
				case 2:
					if (this.p == null)
					{
						goto IL_91;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_58;
					default:
						if (false)
						{
						}
						num = 0;
						continue;
					}
					break;
				case 3:
					goto IL_56;
				case 4:
					goto IL_58;
				}
				if (disposing)
				{
					if (true)
					{
					}
					num = 4;
					continue;
				}
				break;
				IL_58:
				num = 2;
			}
			IL_56:
			IL_91:
			base.Dispose(disposing);
		}

		// Token: 0x04000028 RID: 40
		private global::System.ComponentModel.IContainer p;
	}
}
