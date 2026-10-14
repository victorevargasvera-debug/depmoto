using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x0200009C RID: 156
	public class CCustomToolStripTextBox : global::System.Windows.Forms.ToolStripTextBox
	{
		// Token: 0x0600067C RID: 1660 RVA: 0x0005EE20 File Offset: 0x0005D020
		public CCustomToolStripTextBox()
		{
			this.a();
			this.b();
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0005EE40 File Offset: 0x0005D040
		private void b()
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
			this.e = new global::System.Windows.Forms.ToolStripMenuItem();
			this.e.MergeIndex = 3;
			this.e.ShortcutKeys = (global::System.Windows.Forms.Keys)131160;
			this.e.ShowShortcutKeys = false;
			this.e.Click += this.c;
			this.e.Text = "Cu&t";
			this.f = new global::System.Windows.Forms.ToolStripMenuItem();
			this.f.MergeIndex = 4;
			this.f.ShortcutKeys = (global::System.Windows.Forms.Keys)131139;
			this.f.ShowShortcutKeys = false;
			this.f.Click += this.e;
			this.f.Text = "&Copy";
			this.g = new global::System.Windows.Forms.ToolStripMenuItem();
			this.g.MergeIndex = 5;
			this.g.ShortcutKeys = (global::System.Windows.Forms.Keys)131158;
			this.g.ShowShortcutKeys = false;
			this.g.Click += this.d;
			this.g.Text = "&Paste1";
			this.i = new global::System.Windows.Forms.ToolStripSeparator();
			this.i.MergeIndex = 7;
			this.h = new global::System.Windows.Forms.ToolStripMenuItem();
			this.h.MergeIndex = 6;
			this.h.ShortcutKeys = global::System.Windows.Forms.Keys.Delete;
			this.h.ShowShortcutKeys = false;
			this.h.Click += this.b;
			this.h.Text = "&Delete";
			base.Control.ContextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip();
			base.Control.ContextMenuStrip.Items.Add(this.e);
			base.Control.ContextMenuStrip.Items.Add(this.f);
			base.Control.ContextMenuStrip.Items.Add(this.g);
			base.Control.ContextMenuStrip.Items.Add(this.i);
			base.Control.ContextMenuStrip.Items.Add(this.h);
			base.Control.ContextMenuStrip.Opened += this.a;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0005F0B0 File Offset: 0x0005D2B0
		private void e(object A_0, global::System.EventArgs A_1)
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
			base.TextBox.Copy();
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0005F0F8 File Offset: 0x0005D2F8
		private void d(object A_0, global::System.EventArgs A_1)
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
			this.Paste();
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0005F13C File Offset: 0x0005D33C
		public new void Paste()
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
			base.Paste();
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0005F180 File Offset: 0x0005D380
		private void c(object A_0, global::System.EventArgs A_1)
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
			base.TextBox.Cut();
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0005F1C8 File Offset: 0x0005D3C8
		private void b(object A_0, global::System.EventArgs A_1)
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
			this.DeleteText();
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0005F20C File Offset: 0x0005D40C
		public void DeleteText()
		{
			try
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						num = 8;
						continue;
					case 2:
					{
						int selectionStart = base.SelectionStart;
						this.Text = this.Text.Remove(base.SelectionStart, 1);
						base.SelectionStart = selectionStart;
						goto IL_FD;
					}
					case 3:
						goto IL_10A;
					case 4:
						if (!string.IsNullOrEmpty(this.Text))
						{
							if (true)
							{
							}
							num = 1;
							continue;
						}
						goto IL_10A;
					case 5:
						goto IL_115;
					case 6:
						goto IL_10A;
					case 7:
						base.SelectedText = string.Empty;
						num = 6;
						continue;
					case 8:
						if (base.SelectionStart < this.Text.Length)
						{
							num = 2;
							continue;
						}
						goto IL_10A;
					}
					if (string.IsNullOrEmpty(base.SelectedText))
					{
						num = 4;
						continue;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						num = 7;
						continue;
					}
					IL_FD:
					num = 3;
					continue;
					IL_10A:
					num = 5;
				}
				IL_115:;
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0005F35C File Offset: 0x0005D55C
		private void a(object A_0, global::System.EventArgs A_1)
		{
			int num = 2;
			for (;;)
			{
				string value;
				switch (num)
				{
				case 0:
					this.e.Enabled = false;
					this.g.Enabled = false;
					this.h.Enabled = false;
					num = 11;
					continue;
				case 1:
					goto IL_13A;
				case 3:
					goto IL_1EA;
				case 4:
					goto IL_103;
				case 5:
					this.e.Enabled = false;
					this.f.Enabled = false;
					this.h.Enabled = false;
					num = 4;
					continue;
				case 6:
					goto IL_E0;
				case 7:
					if (base.ReadOnly)
					{
						num = 0;
						continue;
					}
					num = 12;
					continue;
				case 8:
					goto IL_103;
				case 9:
					if (string.IsNullOrEmpty(value))
					{
						num = 1;
						continue;
					}
					goto IL_1F9;
				case 10:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						if (false)
						{
						}
						base.Focus();
						base.SelectAll();
						num = 6;
						continue;
					}
					break;
				case 11:
					if (string.IsNullOrEmpty(base.SelectedText))
					{
						num = 3;
						continue;
					}
					goto IL_1EC;
				case 12:
					if (string.IsNullOrEmpty(base.SelectedText))
					{
						num = 5;
						continue;
					}
					if (true)
					{
					}
					this.e.Enabled = true;
					this.f.Enabled = true;
					this.h.Enabled = true;
					num = 8;
					continue;
				}
				if (!this.Focused)
				{
					num = 10;
					continue;
				}
				IL_E0:
				num = 7;
				continue;
				IL_103:
				value = (string)global::System.Windows.Forms.Clipboard.GetDataObject().GetData(global::System.Windows.Forms.DataFormats.UnicodeText, true);
				num = 9;
			}
			IL_13A:
			this.g.Enabled = false;
			return;
			IL_1EA:
			this.f.Enabled = false;
			return;
			IL_1EC:
			this.f.Enabled = true;
			return;
			IL_1F9:
			this.g.Enabled = true;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0005F570 File Offset: 0x0005D770
		public void LoadMenuText(string cut, string copy, string paste, string delete, string undo)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					goto IL_82;
				case 2:
					this.e.Text = cut;
					num = 1;
					continue;
				case 3:
					return;
				case 4:
					if (!string.IsNullOrEmpty(delete))
					{
						num = 9;
						continue;
					}
					return;
				case 5:
					goto IL_68;
				case 6:
					this.f.Text = copy;
					num = 5;
					continue;
				case 7:
					this.g.Text = paste;
					num = 8;
					continue;
				case 8:
					goto IL_D8;
				case 9:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (true)
						{
						}
						if (false)
						{
						}
						this.h.Text = delete;
						num = 3;
						continue;
					}
					break;
				case 10:
					if (!string.IsNullOrEmpty(paste))
					{
						num = 7;
						continue;
					}
					goto IL_D8;
				case 11:
					if (!string.IsNullOrEmpty(copy))
					{
						num = 6;
						continue;
					}
					goto IL_68;
				}
				IL_40:
				if (!string.IsNullOrEmpty(cut))
				{
					num = 2;
					continue;
				}
				goto IL_82;
				goto IL_40;
				IL_68:
				num = 10;
				continue;
				IL_82:
				num = 11;
				continue;
				IL_D8:
				num = 4;
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0005F6C4 File Offset: 0x0005D8C4
		protected override void Dispose(bool disposing)
		{
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.j.Dispose();
					num = 2;
					continue;
				case 1:
					if (this.j != null)
					{
						goto IL_84;
					}
					goto IL_8E;
				case 2:
					goto IL_72;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_84;
					default:
						if (false)
						{
						}
						num = 1;
						continue;
					}
					break;
				case 4:
					if (true)
					{
					}
					break;
				}
				if (disposing)
				{
					num = 3;
					continue;
				}
				break;
				IL_84:
				num = 0;
			}
			IL_72:
			IL_8E:
			base.Dispose(disposing);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0005F768 File Offset: 0x0005D968
		private void a()
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
			this.j = new global::System.ComponentModel.Container();
		}

		// Token: 0x040004E4 RID: 1252
		private const string a = "Cu&t";

		// Token: 0x040004E5 RID: 1253
		private const string b = "&Copy";

		// Token: 0x040004E6 RID: 1254
		private const string c = "&Paste1";

		// Token: 0x040004E7 RID: 1255
		private const string d = "&Delete";

		// Token: 0x040004E8 RID: 1256
		private global::System.Windows.Forms.ToolStripMenuItem e;

		// Token: 0x040004E9 RID: 1257
		private global::System.Windows.Forms.ToolStripMenuItem f;

		// Token: 0x040004EA RID: 1258
		private global::System.Windows.Forms.ToolStripMenuItem g;

		// Token: 0x040004EB RID: 1259
		private global::System.Windows.Forms.ToolStripMenuItem h;

		// Token: 0x040004EC RID: 1260
		private global::System.Windows.Forms.ToolStripSeparator i;

		// Token: 0x040004ED RID: 1261
		private global::System.ComponentModel.IContainer j;
	}
}
