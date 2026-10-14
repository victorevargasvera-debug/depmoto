using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200000D RID: 13
	public class CultureSafeBackGroundWorker : global::System.ComponentModel.BackgroundWorker
	{
		// Token: 0x0600005A RID: 90 RVA: 0x0000580E File Offset: 0x00003A0E
		protected override void OnDoWork(global::System.ComponentModel.DoWorkEventArgs e)
		{
			this.ResetCurrentThreadCulture();
			base.OnDoWork(e);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000581D File Offset: 0x00003A1D
		private void ResetCurrentThreadCulture()
		{
			global::System.Threading.Thread.CurrentThread.CurrentCulture = global::System.Globalization.CultureInfo.InvariantCulture;
		}
	}
}
