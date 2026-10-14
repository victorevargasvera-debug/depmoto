namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x0200001F RID: 31
	internal partial class PnPMsgWnd : global::System.Windows.Forms.Form
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00006170 File Offset: 0x00004370
		private void InitializeComponent()
		{
			this._label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this._label1.AutoSize = true;
			this._label1.Location = new global::System.Drawing.Point(13, 30);
			this._label1.Name = "_label1";
			this._label1.Size = new global::System.Drawing.Size(314, 13);
			this._label1.TabIndex = 0;
			this._label1.Text = "This is invisible form. To see PnPMsgDetector code click View Code";
			base.ClientSize = new global::System.Drawing.Size(360, 80);
			base.Controls.Add(this._label1);
			base.Name = "PnPMsgForm";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Label _label1;
	}
}
