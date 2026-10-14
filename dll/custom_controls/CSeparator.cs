using System;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;

namespace custom_controls
{
	// Token: 0x0200006A RID: 106
	public class CSeparator : global::System.Windows.Forms.ToolStripSeparator
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x00045C98 File Offset: 0x00043E98
		public CSeparator()
		{
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00045CAC File Offset: 0x00043EAC
		public CSeparator(global::System.Xml.XmlNode node)
		{
			if (node == null)
			{
				return;
			}
			if (node.Attributes["MergeOrder"] == null)
			{
				base.MergeIndex = 0;
			}
			else
			{
				base.MergeIndex = global::System.Convert.ToInt32(node.Attributes["MergeOrder"].Value, global::System.Globalization.NumberFormatInfo.InvariantInfo);
			}
			if (node.Attributes["MergeType"] != null)
			{
				this.c(node.Attributes["MergeType"].Value);
			}
			if (node.Attributes["NAME"] != null)
			{
				base.Name = node.Attributes["NAME"].Value;
			}
			if (node.Attributes["Visible"] != null)
			{
				this.b(node.Attributes["Visible"].Value);
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00045DA0 File Offset: 0x00043FA0
		internal global::custom_controls.CSeparator a()
		{
			global::custom_controls.CSeparator cseparator;
			for (;;)
			{
				for (;;)
				{
					cseparator = new global::custom_controls.CSeparator();
					cseparator.Events.AddHandlers(base.Events);
					cseparator.AccessibleName = base.AccessibleName;
					cseparator.AccessibleRole = base.AccessibleRole;
					cseparator.Alignment = base.Alignment;
					cseparator.AllowDrop = this.AllowDrop;
					cseparator.Anchor = base.Anchor;
					cseparator.AutoSize = base.AutoSize;
					cseparator.AutoToolTip = base.AutoToolTip;
					cseparator.BackColor = this.BackColor;
					cseparator.BackgroundImage = this.BackgroundImage;
					cseparator.BackgroundImageLayout = this.BackgroundImageLayout;
					cseparator.DisplayStyle = base.DisplayStyle;
					cseparator.Dock = base.Dock;
					cseparator.DoubleClickEnabled = base.DoubleClickEnabled;
					cseparator.Enabled = this.Enabled;
					cseparator.Font = this.Font;
					cseparator.ForeColor = this.ForeColor;
					cseparator.Image = this.Image;
					cseparator.ImageAlign = base.ImageAlign;
					cseparator.ImageScaling = base.ImageScaling;
					cseparator.ImageTransparentColor = base.ImageTransparentColor;
					cseparator.Margin = base.Margin;
					cseparator.MergeAction = base.MergeAction;
					cseparator.MergeIndex = base.MergeIndex;
					cseparator.Name = base.Name;
					cseparator.Overflow = base.Overflow;
					cseparator.Padding = this.Padding;
					cseparator.RightToLeft = this.RightToLeft;
					cseparator.Visible = base.Visible;
					cseparator.Tag = base.Tag;
					cseparator.Text = this.Text;
					cseparator.TextAlign = base.TextAlign;
					cseparator.TextDirection = this.TextDirection;
					cseparator.TextImageRelation = base.TextImageRelation;
					cseparator.ToolTipText = base.ToolTipText;
					cseparator.Available = base.Available;
					if (true)
					{
					}
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (!base.AutoSize)
							{
								num = 1;
								continue;
							}
							return cseparator;
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
								cseparator.Size = this.Size;
								num = 2;
								continue;
							}
							break;
						case 2:
							return cseparator;
						}
						break;
					}
				}
			}
			return cseparator;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00045FE4 File Offset: 0x000441E4
		private void c(string A_0)
		{
			int num = 9;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_5E;
				case 1:
					if (!(A_0 == "Add"))
					{
						num = 2;
						continue;
					}
					goto IL_E3;
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						if (true)
						{
						}
						num = 7;
						continue;
					}
					break;
				case 3:
					num = 0;
					continue;
				case 4:
					num = 1;
					continue;
				case 5:
					num = 10;
					continue;
				case 6:
					num = 8;
					continue;
				case 7:
					if (!(A_0 == "Replace"))
					{
						num = 5;
						continue;
					}
					goto IL_4E;
				case 8:
					if (!(A_0 == "Remove"))
					{
						num = 3;
						continue;
					}
					goto IL_EB;
				case 10:
					if (!(A_0 == "MergeItems"))
					{
						num = 6;
						continue;
					}
					goto IL_9A;
				}
				if (A_0 == null)
				{
					goto IL_143;
				}
				num = 4;
			}
			IL_4E:
			base.MergeAction = global::System.Windows.Forms.MergeAction.Replace;
			return;
			IL_5E:
			goto IL_143;
			IL_9A:
			base.MergeAction = global::System.Windows.Forms.MergeAction.MatchOnly;
			return;
			IL_E3:
			base.MergeAction = global::System.Windows.Forms.MergeAction.Append;
			return;
			IL_EB:
			base.MergeAction = global::System.Windows.Forms.MergeAction.Remove;
			return;
			IL_143:
			base.MergeAction = global::System.Windows.Forms.MergeAction.MatchOnly;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0004613C File Offset: 0x0004433C
		private void b(string A_0)
		{
			if (A_0.Equals("Y"))
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					if (true)
					{
					}
					base.Visible = true;
					return;
				}
			}
			base.Visible = false;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00046198 File Offset: 0x00044398
		private void a(string A_0)
		{
			while (A_0.Equals("Y"))
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					if (true)
					{
					}
					this.Enabled = true;
					return;
				}
			}
			this.Enabled = false;
		}
	}
}
