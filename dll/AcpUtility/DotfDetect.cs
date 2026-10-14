using System;
using System.Windows.Forms;

namespace AcpUtility
{
	// Token: 0x02000004 RID: 4
	public class DotfDetect
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002258 File Offset: 0x00000458
		public static void handle(bool isTampered)
		{
			if (isTampered)
			{
				try
				{
					global::System.Windows.Forms.MessageBox.Show("Some files are corrupted. Please un-install and re-install the application.", "CPS", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
					if (global::System.Windows.Forms.Application.MessageLoop)
					{
						global::System.Windows.Forms.Application.Exit();
					}
				}
				finally
				{
					global::System.Environment.Exit(1);
				}
			}
		}
	}
}
