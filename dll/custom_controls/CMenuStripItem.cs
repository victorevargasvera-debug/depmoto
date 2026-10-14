using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;

namespace custom_controls
{
	// Token: 0x0200006C RID: 108
	public class CMenuStripItem : global::System.Windows.Forms.ToolStripMenuItem
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00048560 File Offset: 0x00046760
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x000485A4 File Offset: 0x000467A4
		public bool IsMenuSelectEvent
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
				return this.a;
			}
			set
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
				this.a = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x000485E8 File Offset: 0x000467E8
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x0004862C File Offset: 0x0004682C
		public bool IsMenuClickEvent
		{
			get
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
				return this.c;
			}
			set
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
				this.c = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00048670 File Offset: 0x00046870
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x000486B4 File Offset: 0x000468B4
		public new string Text
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
				return this.d;
			}
			set
			{
				this.d = value;
				if (base.Enabled)
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
						base.Text = this.d;
						return;
					}
				}
				if (true)
				{
				}
				base.Text = this.d.Replace("&", string.Empty);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00048728 File Offset: 0x00046928
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x0004876C File Offset: 0x0004696C
		public new bool Enabled
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
				return base.Enabled;
			}
			set
			{
				for (;;)
				{
					base.Enabled = value;
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (true)
							{
							}
							this.f.Enabled = base.Checked;
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_FC;
							default:
								if (false)
								{
								}
								num = 2;
								continue;
							}
							break;
						case 1:
							if (this.e != null)
							{
								num = 6;
								continue;
							}
							goto IL_E9;
						case 2:
							goto IL_92;
						case 3:
							goto IL_E7;
						case 4:
							if (value)
							{
								num = 0;
								continue;
							}
							this.f.Enabled = value;
							num = 3;
							continue;
						case 5:
							goto IL_E9;
						case 6:
							this.e.Enabled = value;
							num = 5;
							continue;
						case 7:
							if (this.f != null)
							{
								goto IL_FC;
							}
							goto IL_109;
						case 8:
							num = 4;
							continue;
						}
						break;
						IL_E9:
						num = 7;
						continue;
						IL_FC:
						num = 8;
					}
				}
				IL_92:
				IL_E7:
				IL_109:
				this.Text = this.d;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00048890 File Offset: 0x00046A90
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x000488D4 File Offset: 0x00046AD4
		public global::System.Windows.Forms.ToolStripButton LinkedTstrpButton
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
				return this.e;
			}
			set
			{
				for (;;)
				{
					IL_30:
					this.e = value;
					int num = 0;
					for (;;)
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
							switch (num)
							{
							case 0:
								if (this.e != null)
								{
									num = 1;
									continue;
								}
								return;
							case 1:
								this.e.Enabled = this.Enabled;
								goto IL_6C;
							case 2:
								return;
							}
							goto IL_30;
						}
						IL_6C:
						if (true)
						{
						}
						num = 2;
					}
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00048960 File Offset: 0x00046B60
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x000489A4 File Offset: 0x00046BA4
		public global::custom_controls.ToolStripIPAddressComboBox LinkedTSIPAddrComboBox
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.f;
			}
			set
			{
				for (;;)
				{
					this.f = value;
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_7D;
						case 1:
							num = 0;
							continue;
						case 2:
							if (this.f != null)
							{
								if (true)
								{
								}
								num = 1;
								continue;
							}
							return;
						case 3:
							goto IL_61;
						case 4:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_7D;
							default:
								goto IL_B0;
							}
							break;
						}
						break;
						IL_7D:
						if (this.Enabled)
						{
							num = 4;
						}
						else
						{
							this.f.Enabled = this.Enabled;
							num = 3;
						}
					}
				}
				IL_61:
				return;
				IL_B0:
				if (false)
				{
				}
				this.f.Enabled = base.Checked;
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00048A6C File Offset: 0x00046C6C
		public CMenuStripItem()
		{
			this.a = true;
			this.c = true;
			this.e = null;
			this.f = null;
			base.MergeIndex = 0;
			base.Checked = false;
			this.d = string.Empty;
			this.a();
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00048ABC File Offset: 0x00046CBC
		public CMenuStripItem(global::System.Xml.XmlNode node)
		{
			if (node == null)
			{
				return;
			}
			this.a = true;
			this.c = false;
			this.e = null;
			this.f = null;
			base.MergeIndex = 0;
			base.Checked = false;
			this.d = string.Empty;
			this.a();
			this.a(node);
			if (node.Attributes["OnSelect"] != null)
			{
				this.b(node.Attributes["OnSelect"].Value);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00048B48 File Offset: 0x00046D48
		public CMenuStripItem(global::System.Xml.XmlNode node, global::custom_controls.CShorcutHandler shortCutHndl)
		{
			if (node == null)
			{
				return;
			}
			this.a = true;
			this.c = true;
			this.e = null;
			this.f = null;
			this.d = string.Empty;
			base.MergeIndex = 0;
			this.a();
			this.a(node);
			if (node.Attributes["ShortCut"] != null)
			{
				base.ShortcutKeys = shortCutHndl.GetStandardMenuShortCut(node.Attributes["ShortCut"].Value);
			}
			if (node.Attributes["OnSelect"] != null)
			{
				this.b(node.Attributes["OnSelect"].Value);
			}
			if (node.Attributes["OnClick"] != null)
			{
				this.a(node.Attributes["OnClick"].Value);
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00048C40 File Offset: 0x00046E40
		public void EnableItem()
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
			this.Enabled = true;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00048C84 File Offset: 0x00046E84
		public void DisableItem()
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
			this.Enabled = false;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00048CC8 File Offset: 0x00046EC8
		internal global::System.Windows.Forms.ToolStripMenuItem b()
		{
			global::custom_controls.CMenuStripItem cmenuStripItem;
			for (;;)
			{
				cmenuStripItem = new global::custom_controls.CMenuStripItem();
				cmenuStripItem.Events.AddHandlers(base.Events);
				cmenuStripItem.IsMenuSelectEvent = this.IsMenuSelectEvent;
				cmenuStripItem.IsMenuClickEvent = this.IsMenuClickEvent;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_2FA;
					case 1:
						if (this.LinkedTstrpButton != null)
						{
							num = 8;
							continue;
						}
						goto IL_2FA;
					case 2:
						return cmenuStripItem;
					case 3:
						goto IL_266;
					case 4:
						if (this.LinkedTSIPAddrComboBox != null)
						{
							num = 7;
							continue;
						}
						goto IL_7B;
					case 5:
						cmenuStripItem.Size = this.Size;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_266;
						default:
							if (false)
							{
							}
							num = 2;
							continue;
						}
						break;
					case 6:
						goto IL_7B;
					case 7:
						cmenuStripItem.LinkedTSIPAddrComboBox = this.LinkedTSIPAddrComboBox;
						if (true)
						{
						}
						num = 6;
						continue;
					case 8:
						cmenuStripItem.LinkedTstrpButton = this.LinkedTstrpButton;
						num = 0;
						continue;
					}
					break;
					IL_7B:
					cmenuStripItem.AccessibleName = base.AccessibleName;
					cmenuStripItem.AccessibleRole = base.AccessibleRole;
					cmenuStripItem.Alignment = base.Alignment;
					cmenuStripItem.AllowDrop = this.AllowDrop;
					cmenuStripItem.Anchor = base.Anchor;
					cmenuStripItem.AutoSize = base.AutoSize;
					cmenuStripItem.AutoToolTip = base.AutoToolTip;
					cmenuStripItem.BackColor = this.BackColor;
					cmenuStripItem.BackgroundImage = this.BackgroundImage;
					cmenuStripItem.BackgroundImageLayout = this.BackgroundImageLayout;
					cmenuStripItem.Checked = base.Checked;
					cmenuStripItem.CheckOnClick = base.CheckOnClick;
					cmenuStripItem.CheckState = base.CheckState;
					cmenuStripItem.DisplayStyle = this.DisplayStyle;
					cmenuStripItem.Dock = base.Dock;
					cmenuStripItem.DoubleClickEnabled = base.DoubleClickEnabled;
					cmenuStripItem.Enabled = this.Enabled;
					cmenuStripItem.Font = this.Font;
					cmenuStripItem.ForeColor = this.ForeColor;
					cmenuStripItem.Image = this.Image;
					cmenuStripItem.ImageAlign = base.ImageAlign;
					cmenuStripItem.ImageScaling = base.ImageScaling;
					cmenuStripItem.ImageTransparentColor = base.ImageTransparentColor;
					cmenuStripItem.Margin = base.Margin;
					cmenuStripItem.MergeAction = base.MergeAction;
					cmenuStripItem.MergeIndex = base.MergeIndex;
					cmenuStripItem.Name = base.Name;
					cmenuStripItem.Overflow = base.Overflow;
					cmenuStripItem.Padding = this.Padding;
					cmenuStripItem.RightToLeft = this.RightToLeft;
					cmenuStripItem.Visible = base.Visible;
					cmenuStripItem.ShortcutKeys = base.ShortcutKeys;
					cmenuStripItem.ShowShortcutKeys = base.ShowShortcutKeys;
					cmenuStripItem.Tag = base.Tag;
					cmenuStripItem.Text = this.Text;
					cmenuStripItem.TextAlign = this.TextAlign;
					cmenuStripItem.TextDirection = this.TextDirection;
					cmenuStripItem.TextImageRelation = base.TextImageRelation;
					cmenuStripItem.ToolTipText = base.ToolTipText;
					cmenuStripItem.Available = base.Available;
					num = 3;
					continue;
					IL_266:
					if (!base.AutoSize)
					{
						num = 5;
						continue;
					}
					return cmenuStripItem;
					IL_2FA:
					num = 4;
				}
			}
			return cmenuStripItem;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00048FF8 File Offset: 0x000471F8
		private void f(string A_0)
		{
			if (true)
			{
			}
			if (!A_0.Equals("Y"))
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
					base.Visible = false;
					return;
				}
			}
			base.Visible = true;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00049054 File Offset: 0x00047254
		private void e(string A_0)
		{
			if (!A_0.Equals("Y"))
			{
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
					this.Enabled = false;
					return;
				}
			}
			this.Enabled = true;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000490B0 File Offset: 0x000472B0
		private void d(string A_0)
		{
			if (!A_0.Equals("Y"))
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
					base.Checked = false;
					return;
				}
			}
			if (true)
			{
			}
			base.Checked = true;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0004910C File Offset: 0x0004730C
		private void c(string A_0)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					if (!(A_0 == "Remove"))
					{
						goto IL_E1;
					}
					goto IL_C1;
				case 2:
					num = 7;
					continue;
				case 3:
					num = 8;
					continue;
				case 4:
					if (!(A_0 == "Add"))
					{
						num = 5;
						continue;
					}
					goto IL_B9;
				case 5:
					num = 10;
					continue;
				case 6:
					num = 4;
					continue;
				case 7:
					goto IL_68;
				case 8:
					if (A_0 == "MergeItems")
					{
						goto IL_8C;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E1;
					default:
						if (false)
						{
						}
						num = 9;
						continue;
					}
					break;
				case 9:
					num = 1;
					continue;
				case 10:
					if (!(A_0 == "Replace"))
					{
						num = 3;
						continue;
					}
					goto IL_58;
				}
				if (A_0 != null)
				{
					num = 6;
					continue;
				}
				goto IL_132;
				IL_E1:
				num = 2;
			}
			IL_58:
			base.MergeAction = global::System.Windows.Forms.MergeAction.Replace;
			return;
			IL_68:
			goto IL_132;
			IL_8C:
			base.MergeAction = global::System.Windows.Forms.MergeAction.MatchOnly;
			return;
			IL_B9:
			base.MergeAction = global::System.Windows.Forms.MergeAction.Append;
			return;
			IL_C1:
			base.MergeAction = global::System.Windows.Forms.MergeAction.Remove;
			return;
			IL_132:
			if (true)
			{
			}
			base.MergeAction = global::System.Windows.Forms.MergeAction.MatchOnly;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0004925C File Offset: 0x0004745C
		private void b(string A_0)
		{
			if (A_0.Equals("Y"))
			{
				if (true)
				{
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
					break;
				}
				this.a = true;
				return;
			}
			this.a = false;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000492B8 File Offset: 0x000474B8
		private void a(string A_0)
		{
			if (A_0.Equals("Y"))
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3D;
				}
				if (false)
				{
				}
				if (true)
				{
				}
				IL_3D:
				this.c = true;
				return;
			}
			this.a = false;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00049314 File Offset: 0x00047514
		private void a(global::System.Xml.XmlNode A_0)
		{
			int num = 10;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_77;
				case 1:
					this.f(A_0.Attributes["Visible"].Value);
					num = 0;
					continue;
				case 2:
					goto IL_CE;
				case 3:
					goto IL_72;
				case 4:
					if (true)
					{
					}
					goto IL_262;
				case 5:
					if (A_0.Attributes["MergeOrder"] != null)
					{
						num = 6;
						continue;
					}
					goto IL_262;
				case 6:
					base.MergeIndex = global::System.Convert.ToInt32(A_0.Attributes["MergeOrder"].Value, global::System.Globalization.NumberFormatInfo.InvariantInfo);
					num = 4;
					continue;
				case 7:
					if (A_0.Attributes["Visible"] != null)
					{
						num = 1;
						continue;
					}
					goto IL_77;
				case 8:
					goto IL_FE;
				case 9:
					goto IL_A1;
				case 11:
					return;
				case 12:
					if (A_0.Attributes["MergeType"] != null)
					{
						num = 13;
						continue;
					}
					goto IL_A1;
				case 13:
					this.c(A_0.Attributes["MergeType"].Value);
					num = 9;
					continue;
				case 14:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_72;
					default:
						if (false)
						{
						}
						this.e(A_0.Attributes["Enabled"].Value);
						num = 8;
						continue;
					}
					break;
				case 15:
					this.d(A_0.Attributes["Checked"].Value);
					num = 11;
					continue;
				case 16:
					if (A_0.Attributes["Enabled"] != null)
					{
						num = 14;
						continue;
					}
					goto IL_FE;
				case 17:
					if (A_0.Attributes["Checked"] != null)
					{
						num = 15;
						continue;
					}
					return;
				}
				if (A_0.Attributes["NAME"] != null)
				{
					num = 3;
					continue;
				}
				goto IL_CE;
				IL_72:
				base.Name = A_0.Attributes["NAME"].Value;
				num = 2;
				continue;
				IL_77:
				num = 16;
				continue;
				IL_A1:
				num = 7;
				continue;
				IL_CE:
				num = 5;
				continue;
				IL_FE:
				num = 17;
				continue;
				IL_262:
				num = 12;
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000495B4 File Offset: 0x000477B4
		private void a()
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			this.b = new global::System.Collections.Generic.Dictionary<int, global::System.Windows.Forms.ToolStripItem>();
			base.DropDownOpening += this.a;
			base.DropDownClosed += this.b;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00049620 File Offset: 0x00047820
		private void b(object A_0, global::System.EventArgs A_1)
		{
			using (global::System.Collections.Generic.Dictionary<int, global::System.Windows.Forms.ToolStripItem>.KeyCollection.Enumerator enumerator = this.b.Keys.GetEnumerator())
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = 3;
							continue;
						}
						int num2 = enumerator.Current;
						base.DropDownItems.Insert(num2, this.b[num2]);
						num = 4;
						continue;
					}
					case 2:
						goto IL_AF;
					case 3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							if (false)
							{
							}
							num = 2;
							continue;
						}
						break;
					}
					IL_6D:
					num = 0;
					continue;
					goto IL_6D;
				}
				IL_AF:;
			}
			if (true)
			{
			}
			this.b.Clear();
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00049710 File Offset: 0x00047910
		private void a(object A_0, global::System.EventArgs A_1)
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
				switch (0)
				{
				default:
				{
					this.b.Clear();
					int num = 0;
					global::System.Collections.IEnumerator enumerator = base.DropDownItems.GetEnumerator();
					try
					{
						int num2 = 6;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num2 = 3;
								continue;
							case 1:
							{
								global::System.Windows.Forms.ToolStripItem toolStripItem;
								if (!toolStripItem.Available)
								{
									num2 = 5;
									continue;
								}
								goto IL_113;
							}
							case 3:
								goto IL_18D;
							case 4:
								goto IL_113;
							case 5:
							{
								global::System.Windows.Forms.ToolStripItem toolStripItem;
								this.b.Add(num, toolStripItem);
								num2 = 4;
								continue;
							}
							case 7:
							{
								if (!enumerator.MoveNext())
								{
									num2 = 0;
									continue;
								}
								global::System.Windows.Forms.ToolStripItem toolStripItem = (global::System.Windows.Forms.ToolStripItem)enumerator.Current;
								num2 = 1;
								continue;
							}
							}
							goto IL_111;
							IL_113:
							num++;
							num2 = 2;
							continue;
							IL_14A:
							num2 = 7;
							continue;
							IL_111:
							goto IL_14A;
						}
						IL_18D:
						goto IL_C8;
					}
					finally
					{
						for (;;)
						{
							global::System.IDisposable disposable = enumerator as global::System.IDisposable;
							int num2 = 1;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num2 = 2;
									continue;
								case 1:
									if (disposable != null)
									{
										num2 = 0;
										continue;
									}
									goto IL_1D9;
								case 2:
									goto IL_1D7;
								}
								break;
							}
						}
						IL_1D7:
						IL_1D9:;
					}
					break;
					for (;;)
					{
						IL_C8:
						using (global::System.Collections.Generic.Dictionary<int, global::System.Windows.Forms.ToolStripItem>.ValueCollection.Enumerator enumerator2 = this.b.Values.GetEnumerator())
						{
							int num2 = 0;
							for (;;)
							{
								switch (num2)
								{
								case 2:
									goto IL_B5;
								case 3:
									num2 = 2;
									continue;
								case 4:
								{
									if (!enumerator2.MoveNext())
									{
										num2 = 3;
										continue;
									}
									global::System.Windows.Forms.ToolStripItem value = enumerator2.Current;
									base.DropDownItems.Remove(value);
									num2 = 1;
									continue;
								}
								}
								IL_70:
								num2 = 4;
								continue;
								goto IL_70;
							}
							IL_B5:
							break;
						}
					}
					break;
				}
				}
				break;
			}
			if (true)
			{
			}
		}

		// Token: 0x0400031F RID: 799
		private bool a;

		// Token: 0x04000320 RID: 800
		private global::System.Collections.Generic.Dictionary<int, global::System.Windows.Forms.ToolStripItem> b;

		// Token: 0x04000321 RID: 801
		private bool c;

		// Token: 0x04000322 RID: 802
		private string d;

		// Token: 0x04000323 RID: 803
		private global::System.Windows.Forms.ToolStripButton e;

		// Token: 0x04000324 RID: 804
		private global::custom_controls.ToolStripIPAddressComboBox f;
	}
}
