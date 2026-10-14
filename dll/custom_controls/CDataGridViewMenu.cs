using System;
using System.Collections;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000028 RID: 40
	public class CDataGridViewMenu
	{
		// Token: 0x06000127 RID: 295 RVA: 0x0001AF18 File Offset: 0x00019118
		public CDataGridViewMenu(global::System.Collections.ArrayList menuItems, ref global::System.Windows.Forms.ContextMenuStrip contextmenu, string cascdeMenuType)
		{
			this.a(menuItems, ref contextmenu, cascdeMenuType);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0001AF34 File Offset: 0x00019134
		private void a(global::System.Collections.ArrayList A_0, ref global::System.Windows.Forms.ContextMenuStrip A_1, string A_2)
		{
			switch (0)
			{
			default:
			{
				global::System.Windows.Forms.ContextMenuStrip contextMenuStrip;
				for (;;)
				{
					global::System.Windows.Forms.ToolStripMenuItem value = null;
					global::System.Windows.Forms.ToolStripSeparator value2 = null;
					contextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip();
					int num = 0;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_138;
					default:
					{
						if (false)
						{
						}
						if (true)
						{
						}
						int num2 = 7;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_10F;
							case 1:
								goto IL_EE;
							case 2:
								goto IL_7C;
							case 3:
								goto IL_7C;
							case 4:
							{
								global::custom_controls.CCustomDataGridView.MenuInfo a_;
								if (a_.MenuText.Equals("-"))
								{
									num2 = 6;
									continue;
								}
								this.a(ref value, a_, num);
								contextMenuStrip.Items.Add(value);
								num2 = 3;
								continue;
							}
							case 5:
							{
								if (num >= A_0.Count)
								{
									num2 = 0;
									continue;
								}
								global::custom_controls.CCustomDataGridView.MenuInfo a_ = (global::custom_controls.CCustomDataGridView.MenuInfo)A_0[num];
								value = null;
								num2 = 4;
								continue;
							}
							case 6:
								this.a(ref value2, num);
								contextMenuStrip.Items.Add(value2);
								num2 = 2;
								continue;
							case 7:
								goto IL_EE;
							}
							break;
							IL_7C:
							num++;
							num2 = 1;
							continue;
							IL_EE:
							num2 = 5;
						}
						break;
					}
					}
				}
				IL_10F:
				IL_138:
				global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
				toolStripMenuItem.Name = "mnuEditUndo";
				toolStripMenuItem.Text = "mnuEditUndo";
				toolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131162;
				toolStripMenuItem.Visible = false;
				contextMenuStrip.Items.Add(toolStripMenuItem);
				global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
				toolStripMenuItem2.Name = "mnuEditRedo";
				toolStripMenuItem2.Text = "mnuEditRedo";
				toolStripMenuItem2.ShortcutKeys = (global::System.Windows.Forms.Keys)131161;
				toolStripMenuItem2.Visible = false;
				contextMenuStrip.Items.Add(toolStripMenuItem2);
				A_1 = contextMenuStrip;
				return;
			}
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0001B100 File Offset: 0x00019300
		private void a(ref global::System.Windows.Forms.ToolStripSeparator A_0, int A_1)
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
			A_0 = new global::System.Windows.Forms.ToolStripSeparator();
			A_0.MergeIndex = A_1;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0001B14C File Offset: 0x0001934C
		private void a(ref global::System.Windows.Forms.ToolStripMenuItem A_0, global::custom_controls.CCustomDataGridView.MenuInfo A_1, int A_2)
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
			A_0 = new global::System.Windows.Forms.ToolStripMenuItem();
			A_0.MergeIndex = A_2;
			A_0.Name = A_1.MenuID;
			A_0.Text = A_1.MenuText;
			A_0.ShortcutKeys = A_1.MenuShortCut;
		}
	}
}
