using System;
using System.Drawing;
using System.Windows.Forms;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x0200001F RID: 31
	internal partial class PnPMsgWnd : Form
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00006080 File Offset: 0x00004280
		public PnPMsgWnd(PnPDeviceDetectorBase receiver)
		{
			this._detector = receiver;
			base.MinimizeBox = false;
			base.MaximizeBox = false;
			base.ShowInTaskbar = false;
			base.ShowIcon = false;
			base.Visible = false;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Load += this.Load_Form;
			base.Activated += this.Form_Activated;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000060F8 File Offset: 0x000042F8
		protected override void WndProc(ref Message m)
		{
			if (this._processMessage || m.Msg == this.WM_PAINT)
			{
				base.WndProc(ref m);
			}
			else
			{
				m.Result = new IntPtr(1);
			}
			if (this._detector != null)
			{
				this._detector.WndProc(ref m);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00006144 File Offset: 0x00004344
		private void Load_Form(object sender, EventArgs e)
		{
			this.InitializeComponent();
			base.Size = new Size(1, 1);
			this._processMessage = false;
			base.Visible = false;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00006167 File Offset: 0x00004367
		private void Form_Activated(object sender, EventArgs e)
		{
			base.Visible = false;
		}

		// Token: 0x0400008B RID: 139
		private bool _processMessage = true;

		// Token: 0x0400008C RID: 140
		private PnPDeviceDetectorBase _detector;

		// Token: 0x0400008D RID: 141
		private readonly int WM_PAINT = 15;
	}
}
