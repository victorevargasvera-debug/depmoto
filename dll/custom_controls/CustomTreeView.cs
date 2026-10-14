using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x0200009F RID: 159
	public class CustomTreeView : global::System.Windows.Forms.TreeView
	{
		// Token: 0x060006AA RID: 1706
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SendMessage(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2, int A_3);

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00060374 File Offset: 0x0005E574
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x000603B8 File Offset: 0x0005E5B8
		public global::custom_controls.CustomTreeNode CurrentClickedNode
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
				return this.n;
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
				this.n = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x000603FC File Offset: 0x0005E5FC
		public global::System.Collections.ArrayList NodesForMultipleSelection
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
				return this.o;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00060440 File Offset: 0x0005E640
		public global::System.Collections.ArrayList CollectionOfNodes
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
				return this.p;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00060484 File Offset: 0x0005E684
		public global::System.Collections.ArrayList ExpandedIcons
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
				return this.q;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x000604C8 File Offset: 0x0005E6C8
		public global::System.Collections.ArrayList CollapsedIcons
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
				return this.r;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0006050C File Offset: 0x0005E70C
		public global::System.Collections.ArrayList NodesToBeDeleted
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
				return this.s;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00060550 File Offset: 0x0005E750
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00060594 File Offset: 0x0005E794
		public string RenameValidChars
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
				return this.t;
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
				this.t = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x000605D8 File Offset: 0x0005E7D8
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x0006061C File Offset: 0x0005E81C
		public bool RenameMessage
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
				return this.u;
			}
			set
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
				this.u = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00060660 File Offset: 0x0005E860
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x000606A4 File Offset: 0x0005E8A4
		public bool NodeChanged
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
				return this.v;
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
				this.v = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x000606E8 File Offset: 0x0005E8E8
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0006072C File Offset: 0x0005E92C
		public global::custom_controls.CustomTreeView.DeleOnMouseActivate DeleInstOnMouseActivate
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
				return this.ah;
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
				this.ah = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00060770 File Offset: 0x0005E970
		public global::custom_controls.CMenuItem RenameContextMenu
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
				return this.ai;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x000607B4 File Offset: 0x0005E9B4
		public global::custom_controls.CMenuItem RenameCutMenu
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
				return this.aj;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x000607F8 File Offset: 0x0005E9F8
		public global::custom_controls.CMenuItem RenameCopyMenu
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
				return this.ak;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0006083C File Offset: 0x0005EA3C
		public global::custom_controls.CMenuItem RenamePasteMenu
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
				return this.al;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00060880 File Offset: 0x0005EA80
		public global::custom_controls.CMenuItem RenameDeleteMenu
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
				return this.am;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x000608C4 File Offset: 0x0005EAC4
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("The collection of the selected nodes.")]
		public global::System.Collections.ArrayList SelectedNodes
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
				return this.CollectionOfNodes;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00060908 File Offset: 0x0005EB08
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x0006094C File Offset: 0x0005EB4C
		[global::System.ComponentModel.Description("The collection of the selected node.")]
		[global::System.ComponentModel.Category("Customization")]
		public new global::custom_controls.CustomTreeNode SelectedNode
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
				return this.CurrentClickedNode;
			}
			set
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
				this.CurrentClickedNode = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00060990 File Offset: 0x0005EB90
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x000609D4 File Offset: 0x0005EBD4
		[global::System.ComponentModel.Description("The first clicked node in a multiselection.")]
		[global::System.ComponentModel.Category("Customization")]
		public global::custom_controls.CustomTreeNode FirstSelectedNode
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
				return this.x;
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
				this.x = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00060A18 File Offset: 0x0005EC18
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00060A5C File Offset: 0x0005EC5C
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("The last clicked node in a multiselection.")]
		public global::custom_controls.CustomTreeNode LastSelectedNode
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
				return this.w;
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
				this.w = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00060AA0 File Offset: 0x0005ECA0
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00060AE4 File Offset: 0x0005ECE4
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Localizable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Description("Change to the right-to-left layout.")]
		public bool Mirrored
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
				return this.ab;
			}
			set
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2F;
						}
						goto Block_2;
					case 2:
						goto IL_2F;
					}
					if (this.ab != value)
					{
						num = 2;
						continue;
					}
					goto IL_6E;
					IL_2F:
					this.ab = value;
					num = 0;
				}
				Block_2:
				if (true)
				{
				}
				if (false)
				{
				}
				IL_6E:
				base.OnRightToLeftChanged(global::System.EventArgs.Empty);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00060B6C File Offset: 0x0005ED6C
		protected override global::System.Windows.Forms.CreateParams CreateParams
		{
			get
			{
				global::System.Windows.Forms.CreateParams createParams;
				for (;;)
				{
					IL_14:
					if (true)
					{
					}
					createParams = base.CreateParams;
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							createParams.ExStyle |= 4194304;
							num = 2;
							continue;
						case 1:
							if (this.Mirrored)
							{
								num = 0;
								continue;
							}
							goto IL_63;
						case 2:
							goto IL_61;
						}
						goto IL_14;
					}
					IL_63:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_79;
					}
					IL_61:
					goto IL_63;
				}
				IL_79:
				if (false)
				{
				}
				return createParams;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00060BFC File Offset: 0x0005EDFC
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00060C40 File Offset: 0x0005EE40
		[global::System.ComponentModel.Localizable(true)]
		[global::System.ComponentModel.Description("To determine if we allow multiple selection")]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Category("Appearance")]
		public bool MultipleSelection
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
				return this.ad;
			}
			set
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 2:
						this.ad = value;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_25;
						}
						if (true)
						{
						}
						if (false)
						{
						}
						num = 0;
						continue;
					}
					goto IL_1C;
					IL_25:
					num = 2;
					continue;
					IL_1C:
					if (this.ad != value)
					{
						goto IL_25;
					}
					break;
				}
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060006CB RID: 1739 RVA: 0x00060CBC File Offset: 0x0005EEBC
		// (remove) Token: 0x060006CC RID: 1740 RVA: 0x00060D54 File Offset: 0x0005EF54
		[global::System.ComponentModel.Description("The Click event of the menu item 'Add'.")]
		[global::System.ComponentModel.Category("Customization")]
		public event global::custom_controls.CustomTreeView.OperateEventHandler Add
		{
			add
			{
				for (;;)
				{
					int num;
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_7C:
						num = 2;
						break;
					default:
						if (true)
						{
						}
						if (false)
						{
						}
						operateEventHandler = this.an;
						num = 1;
						break;
					}
					for (;;)
					{
						global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
						switch (num)
						{
						case 0:
							if (operateEventHandler == operateEventHandler2)
							{
								goto IL_7C;
							}
							goto IL_53;
						case 1:
							goto IL_53;
						case 2:
							return;
						}
						break;
						IL_53:
						operateEventHandler2 = operateEventHandler;
						global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Combine(operateEventHandler2, value);
						operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.an, value2, operateEventHandler2);
						num = 0;
					}
				}
			}
			remove
			{
				for (;;)
				{
					int num;
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_7C:
						num = 0;
						break;
					default:
						if (false)
						{
						}
						operateEventHandler = this.an;
						if (true)
						{
						}
						num = 1;
						break;
					}
					for (;;)
					{
						global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_53;
						case 2:
							if (operateEventHandler == operateEventHandler2)
							{
								goto IL_7C;
							}
							goto IL_53;
						}
						break;
						IL_53:
						operateEventHandler2 = operateEventHandler;
						global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Remove(operateEventHandler2, value);
						operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.an, value2, operateEventHandler2);
						num = 2;
					}
				}
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060006CD RID: 1741 RVA: 0x00060DEC File Offset: 0x0005EFEC
		// (remove) Token: 0x060006CE RID: 1742 RVA: 0x00060E84 File Offset: 0x0005F084
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("The Click event of the menu item 'Delete'.")]
		public event global::custom_controls.CustomTreeView.OperateEventHandler Delete
		{
			add
			{
				for (;;)
				{
					IL_14:
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler = this.ao;
					for (;;)
					{
						IL_1B:
						int num = 1;
						for (;;)
						{
							global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
							switch (num)
							{
							case 0:
								if (true)
								{
								}
								if (operateEventHandler != operateEventHandler2)
								{
									goto IL_25;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1B;
								default:
									if (false)
									{
									}
									num = 2;
									continue;
								}
								break;
							case 1:
								goto IL_25;
							case 2:
								return;
							}
							goto IL_14;
							IL_25:
							operateEventHandler2 = operateEventHandler;
							global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Combine(operateEventHandler2, value);
							operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.ao, value2, operateEventHandler2);
							num = 0;
						}
					}
				}
			}
			remove
			{
				for (;;)
				{
					IL_38:
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler = this.ao;
					int num = 1;
					for (;;)
					{
						global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
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
							switch (num)
							{
							case 0:
								if (operateEventHandler == operateEventHandler2)
								{
									num = 2;
									continue;
								}
								goto IL_49;
							case 1:
								goto IL_47;
							case 2:
								return;
							}
							goto IL_38;
						}
						IL_49:
						operateEventHandler2 = operateEventHandler;
						global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Remove(operateEventHandler2, value);
						operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.ao, value2, operateEventHandler2);
						num = 0;
						continue;
						IL_47:
						goto IL_49;
					}
				}
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060006CF RID: 1743 RVA: 0x00060F18 File Offset: 0x0005F118
		// (remove) Token: 0x060006D0 RID: 1744 RVA: 0x00060FB0 File Offset: 0x0005F1B0
		[global::System.ComponentModel.Description("The Click event of the menu item 'Rename'.")]
		[global::System.ComponentModel.Category("Customization")]
		public event global::custom_controls.CustomTreeView.OperateEventHandler Rename
		{
			add
			{
				for (;;)
				{
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler = this.ap;
					if (true)
					{
					}
					int num = 0;
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						case 1:
							goto IL_22;
						default:
							goto IL_22;
						}
						IL_53:
						global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2 = operateEventHandler;
						global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Combine(operateEventHandler2, value);
						operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.ap, value2, operateEventHandler2);
						num = 2;
						continue;
						IL_51:
						goto IL_53;
						IL_22:
						if (false)
						{
						}
						switch (num)
						{
						case 0:
							goto IL_51;
						case 1:
							return;
						case 2:
							if (operateEventHandler == operateEventHandler2)
							{
								num = 1;
								continue;
							}
							goto IL_53;
						}
						break;
					}
				}
			}
			remove
			{
				if (true)
				{
				}
				for (;;)
				{
					IL_42:
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler = this.ap;
					int num = 1;
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_42;
						default:
						{
							if (false)
							{
							}
							global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
							switch (num)
							{
							case 0:
								return;
							case 1:
								goto IL_53;
							case 2:
								if (operateEventHandler == operateEventHandler2)
								{
									num = 0;
									continue;
								}
								goto IL_53;
							}
							goto IL_42;
							IL_53:
							operateEventHandler2 = operateEventHandler;
							global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Remove(operateEventHandler2, value);
							operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.ap, value2, operateEventHandler2);
							num = 2;
							break;
						}
						}
					}
				}
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x060006D1 RID: 1745 RVA: 0x00061044 File Offset: 0x0005F244
		// (remove) Token: 0x060006D2 RID: 1746 RVA: 0x000610DC File Offset: 0x0005F2DC
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("The Click event of the menu item 'Sort By Name'.")]
		public event global::custom_controls.CustomTreeView.OperateEventHandler SortByName
		{
			add
			{
				for (;;)
				{
					IL_14:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					case 1:
						goto IL_34;
					default:
						goto IL_34;
					}
					IL_49:
					int num = 0;
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler;
					for (;;)
					{
						global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
						switch (num)
						{
						case 0:
							goto IL_53;
						case 1:
							if (operateEventHandler == operateEventHandler2)
							{
								num = 2;
								continue;
							}
							goto IL_53;
						case 2:
							return;
						}
						goto IL_14;
						IL_53:
						operateEventHandler2 = operateEventHandler;
						global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Combine(operateEventHandler2, value);
						operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.aq, value2, operateEventHandler2);
						num = 1;
					}
					IL_34:
					if (true)
					{
					}
					if (false)
					{
					}
					operateEventHandler = this.aq;
					goto IL_49;
				}
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler = this.aq;
					int num = 2;
					for (;;)
					{
						global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
						switch (num)
						{
						case 0:
							if (operateEventHandler == operateEventHandler2)
							{
								goto IL_74;
							}
							goto IL_4B;
						case 1:
							goto IL_7C;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_74;
							default:
								if (false)
								{
								}
								goto IL_4B;
							}
							break;
						}
						break;
						IL_4B:
						operateEventHandler2 = operateEventHandler;
						global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Remove(operateEventHandler2, value);
						operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.aq, value2, operateEventHandler2);
						num = 0;
						continue;
						IL_74:
						num = 1;
					}
				}
				IL_7C:
				if (true)
				{
				}
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060006D3 RID: 1747 RVA: 0x00061170 File Offset: 0x0005F370
		// (remove) Token: 0x060006D4 RID: 1748 RVA: 0x00061208 File Offset: 0x0005F408
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("The Click event of the menu item 'Sort By Type'.")]
		public event global::custom_controls.CustomTreeView.OperateEventHandler SortByType
		{
			add
			{
				for (;;)
				{
					if (true)
					{
					}
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler = this.ar;
					int num = 2;
					for (;;)
					{
						global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
						switch (num)
						{
						case 0:
							if (operateEventHandler == operateEventHandler2)
							{
								goto IL_7C;
							}
							goto IL_53;
						case 1:
							return;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_7C;
							default:
								if (false)
								{
								}
								goto IL_53;
							}
							break;
						}
						break;
						IL_53:
						operateEventHandler2 = operateEventHandler;
						global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Combine(operateEventHandler2, value);
						operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.ar, value2, operateEventHandler2);
						num = 0;
						continue;
						IL_7C:
						num = 1;
					}
				}
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler = this.ar;
					int num = 1;
					for (;;)
					{
						global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_25;
						case 2:
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
								if (operateEventHandler != operateEventHandler2)
								{
									goto IL_25;
								}
								break;
							}
							num = 0;
							continue;
						}
						break;
						IL_25:
						operateEventHandler2 = operateEventHandler;
						global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Remove(operateEventHandler2, value);
						operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.ar, value2, operateEventHandler2);
						num = 2;
					}
				}
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060006D5 RID: 1749 RVA: 0x000612A0 File Offset: 0x0005F4A0
		// (remove) Token: 0x060006D6 RID: 1750 RVA: 0x00061338 File Offset: 0x0005F538
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("The event of the multiple Drag and Drop operation.")]
		public event global::custom_controls.CustomTreeView.OperateEventHandler MultipleDragDrop
		{
			add
			{
				for (;;)
				{
					IL_14:
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler;
					int num;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_49:
						operateEventHandler = operateEventHandler2;
						global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Combine(operateEventHandler, value);
						operateEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.@as, value2, operateEventHandler);
						num = 2;
						break;
					}
					default:
						if (false)
						{
						}
						operateEventHandler2 = this.@as;
						num = 1;
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_3F;
						case 2:
							if (operateEventHandler2 == operateEventHandler)
							{
								num = 0;
								continue;
							}
							goto IL_49;
						}
						goto IL_14;
					}
					IL_3F:
					if (true)
					{
					}
					goto IL_49;
				}
			}
			remove
			{
				for (;;)
				{
					IL_14:
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler = this.@as;
					for (;;)
					{
						int num = 1;
						for (;;)
						{
							global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
							switch (num)
							{
							case 0:
								goto IL_68;
							case 1:
								goto IL_25;
							case 2:
								if (true)
								{
								}
								if (operateEventHandler == operateEventHandler2)
								{
									num = 0;
									continue;
								}
								goto IL_25;
							}
							goto IL_14;
							IL_25:
							operateEventHandler2 = operateEventHandler;
							global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Remove(operateEventHandler2, value);
							operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.@as, value2, operateEventHandler2);
							num = 2;
						}
						IL_68:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_7E;
						}
					}
				}
				IL_7E:
				if (false)
				{
				}
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x060006D7 RID: 1751 RVA: 0x000613CC File Offset: 0x0005F5CC
		// (remove) Token: 0x060006D8 RID: 1752 RVA: 0x00061464 File Offset: 0x0005F664
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("The event of the cross Drag and Drop operation.")]
		public event global::custom_controls.CustomTreeView.OperateEventHandler CrossDragDrop
		{
			add
			{
				for (;;)
				{
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler = this.at;
					int num = 0;
					for (;;)
					{
						global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
						switch (num)
						{
						case 0:
							goto IL_25;
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
								if (operateEventHandler == operateEventHandler2)
								{
									num = 2;
									continue;
								}
								goto IL_25;
							}
							break;
						case 2:
							return;
						}
						break;
						IL_25:
						operateEventHandler2 = operateEventHandler;
						global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Combine(operateEventHandler2, value);
						operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.at, value2, operateEventHandler2);
						if (true)
						{
						}
						num = 1;
					}
				}
			}
			remove
			{
				for (;;)
				{
					IL_14:
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler = this.at;
					global::custom_controls.CustomTreeView.OperateEventHandler operateEventHandler2;
					int num;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_53:
						operateEventHandler2 = operateEventHandler;
						global::custom_controls.CustomTreeView.OperateEventHandler value2 = (global::custom_controls.CustomTreeView.OperateEventHandler)global::System.Delegate.Remove(operateEventHandler2, value);
						operateEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomTreeView.OperateEventHandler>(ref this.at, value2, operateEventHandler2);
						num = 0;
						break;
					}
					default:
						if (true)
						{
						}
						if (false)
						{
						}
						num = 2;
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (operateEventHandler == operateEventHandler2)
							{
								num = 1;
								continue;
							}
							goto IL_53;
						case 1:
							return;
						case 2:
							goto IL_51;
						}
						goto IL_14;
					}
					IL_51:
					goto IL_53;
				}
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000614FC File Offset: 0x0005F6FC
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
			this.aa = new global::System.ComponentModel.Container();
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00061544 File Offset: 0x0005F744
		public CustomTreeView()
		{
			this.b();
			this.q = new global::System.Collections.ArrayList();
			this.r = new global::System.Collections.ArrayList();
			this.p = new global::System.Collections.ArrayList();
			this.o = new global::System.Collections.ArrayList();
			this.s = new global::System.Collections.ArrayList();
			this.z = new global::custom_controls.CustomTreeNode();
			this.ai = new global::custom_controls.CMenuItem();
			this.ai.OwnerDraw = true;
			this.ak = new global::custom_controls.CMenuItem();
			this.al = new global::custom_controls.CMenuItem();
			this.aj = new global::custom_controls.CMenuItem();
			this.am = new global::custom_controls.CMenuItem();
			this.ai.MenuItems.AddRange(new global::custom_controls.CMenuItem[]
			{
				this.aj,
				this.ak,
				this.al,
				this.am
			});
			this.ak.Click -= this.d;
			this.al.Click -= this.c;
			this.aj.Click -= this.b;
			this.am.Click -= this.a;
			this.ak.Click += this.d;
			this.al.Click += this.c;
			this.aj.Click += this.b;
			this.am.Click += this.a;
			this.AllowDrop = true;
			base.Scrollable = true;
			this.y = global::System.Windows.Forms.Cursors.Default;
			this.NodeChanged = false;
			this.ag = 0L;
			this.DeleInstOnMouseActivate = null;
			this.ae = null;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00061720 File Offset: 0x0005F920
		protected override void Dispose(bool disposing)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (this.ae != null)
					{
						num = 6;
						continue;
					}
					goto IL_D2;
				case 1:
					goto IL_48;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_48;
					default:
						if (false)
						{
						}
						if (this.aa != null)
						{
							num = 4;
							continue;
						}
						goto IL_48;
					}
					break;
				case 4:
					this.aa.Dispose();
					num = 1;
					continue;
				case 5:
					num = 3;
					continue;
				case 6:
					this.ae.Dispose();
					num = 7;
					continue;
				case 7:
					goto IL_D0;
				}
				if (true)
				{
				}
				if (disposing)
				{
					num = 5;
					continue;
				}
				break;
				IL_48:
				num = 0;
			}
			IL_D0:
			IL_D2:
			base.Dispose(disposing);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00061808 File Offset: 0x0005FA08
		protected override void OnKeyDown(global::System.Windows.Forms.KeyEventArgs e)
		{
			switch (0)
			{
			default:
			{
				int num = 67;
				for (;;)
				{
					global::System.Windows.Forms.Keys keyCode;
					switch (num)
					{
					case 0:
						num = 3;
						continue;
					case 1:
						this.NodeChanged = true;
						num = 39;
						continue;
					case 2:
						if (this.CurrentClickedNode.Parent != null)
						{
							num = 33;
							continue;
						}
						goto IL_989;
					case 3:
						goto IL_495;
					case 4:
						num = 19;
						continue;
					case 5:
						if (this.x.PrevVisibleNode != null)
						{
							num = 26;
							continue;
						}
						goto IL_989;
					case 6:
						if (!e.Control)
						{
							num = 63;
							continue;
						}
						goto IL_989;
					case 7:
					{
						global::custom_controls.CustomTreeNode currentClickedNode = this.CurrentClickedNode;
						this.CurrentClickedNode = (global::custom_controls.CustomTreeNode)this.CurrentClickedNode.Parent;
						this.x = this.CurrentClickedNode;
						this.NodeChanged = true;
						this.RemovePaintFromNodes();
						this.CollectionOfNodes.Clear();
						this.CollectionOfNodes.Add(this.CurrentClickedNode);
						this.CurrentClickedNode.Highlighted = true;
						if (true)
						{
						}
						num = 68;
						continue;
					}
					case 8:
					{
						global::custom_controls.CustomTreeNode currentClickedNode2 = this.CurrentClickedNode;
						this.CurrentClickedNode = (global::custom_controls.CustomTreeNode)this.CurrentClickedNode.NextVisibleNode;
						this.x = this.CurrentClickedNode;
						this.NodeChanged = true;
						this.RemovePaintFromNodes();
						this.CollectionOfNodes.Clear();
						this.CollectionOfNodes.Add(this.CurrentClickedNode);
						this.CurrentClickedNode.Highlighted = true;
						num = 69;
						continue;
					}
					case 9:
						num = 62;
						continue;
					case 10:
						goto IL_1A7;
					case 11:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						if ((int)customTreeNode.Text[0] == e.KeyValue)
						{
							num = 53;
							continue;
						}
						customTreeNode = (global::custom_controls.CustomTreeNode)customTreeNode.NextVisibleNode;
						int num2;
						num2++;
						num = 36;
						continue;
					}
					case 12:
						if (!e.Control)
						{
							num = 61;
							continue;
						}
						goto IL_850;
					case 13:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						if (customTreeNode == null)
						{
							num = 35;
							continue;
						}
						goto IL_1A7;
					}
					case 14:
						if (!e.Control)
						{
							num = 4;
							continue;
						}
						goto IL_989;
					case 15:
						num = 66;
						continue;
					case 16:
						if (this.CurrentClickedNode.Parent != null)
						{
							num = 7;
							continue;
						}
						goto IL_547;
					case 17:
					{
						global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)this.CurrentClickedNode.NextVisibleNode;
						int num2 = 0;
						num = 54;
						continue;
					}
					case 18:
						this.CurrentClickedNode.Collapse();
						num = 38;
						continue;
					case 19:
						if (this.x.NextVisibleNode != null)
						{
							num = 27;
							continue;
						}
						goto IL_989;
					case 20:
						this.CurrentClickedNode.EnsureVisible();
						num = 45;
						continue;
					case 21:
						goto IL_58B;
					case 22:
						this.CurrentClickedNode.EnsureVisible();
						num = 57;
						continue;
					case 23:
						if (!this.MultipleSelection)
						{
							num = 30;
							continue;
						}
						goto IL_989;
					case 24:
						goto IL_152;
					case 25:
						if (this.CurrentClickedNode.GetNodeCount(false) > 0)
						{
							num = 56;
							continue;
						}
						goto IL_989;
					case 26:
						this.CurrentClickedNode = (global::custom_controls.CustomTreeNode)this.x.PrevVisibleNode;
						this.x = this.CurrentClickedNode;
						this.NodeChanged = true;
						this.RemovePaintFromNodes();
						this.CollectionOfNodes.Clear();
						this.CollectionOfNodes.Add(this.CurrentClickedNode);
						this.CurrentClickedNode.Highlighted = true;
						num = 59;
						continue;
					case 27:
						this.CurrentClickedNode = (global::custom_controls.CustomTreeNode)this.x.NextVisibleNode;
						this.x = this.CurrentClickedNode;
						this.NodeChanged = true;
						this.RemovePaintFromNodes();
						this.CollectionOfNodes.Clear();
						this.CollectionOfNodes.Add(this.CurrentClickedNode);
						this.CurrentClickedNode.Highlighted = true;
						num = 44;
						continue;
					case 28:
						if (!e.Control)
						{
							num = 29;
							continue;
						}
						goto IL_989;
					case 29:
						num = 5;
						continue;
					case 30:
						goto IL_828;
					case 31:
						goto IL_305;
					case 32:
						num = 37;
						continue;
					case 33:
					{
						global::custom_controls.CustomTreeNode currentClickedNode3 = this.CurrentClickedNode;
						this.CurrentClickedNode = (global::custom_controls.CustomTreeNode)this.CurrentClickedNode.Parent;
						this.x = this.CurrentClickedNode;
						this.NodeChanged = true;
						this.RemovePaintFromNodes();
						this.CollectionOfNodes.Clear();
						this.CollectionOfNodes.Add(this.CurrentClickedNode);
						this.CurrentClickedNode.Highlighted = true;
						num = 31;
						continue;
					}
					case 34:
						if (!e.Control)
						{
							num = 32;
							continue;
						}
						goto IL_989;
					case 35:
					{
						global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)base.TopNode;
						num = 10;
						continue;
					}
					case 36:
						goto IL_4EF;
					case 37:
						if (this.CurrentClickedNode.GetNodeCount(false) == 0)
						{
							num = 43;
							continue;
						}
						goto IL_547;
					case 38:
						goto IL_1F2;
					case 39:
						goto IL_39D;
					case 40:
						goto IL_6B0;
					case 41:
						goto IL_3E4;
					case 42:
					{
						global::custom_controls.CustomTreeNode customTreeNode;
						global::custom_controls.CustomTreeNode currentClickedNode4;
						if (currentClickedNode4 != customTreeNode)
						{
							num = 1;
							continue;
						}
						goto IL_39D;
					}
					case 43:
						num = 16;
						continue;
					case 44:
						if (!this.CurrentClickedNode.IsVisible)
						{
							num = 20;
							continue;
						}
						goto IL_989;
					case 45:
						goto IL_232;
					case 46:
						num = 21;
						continue;
					case 47:
						if (e.Shift)
						{
							num = 64;
							continue;
						}
						goto IL_6B0;
					case 48:
					{
						int num2;
						if (num2 >= base.VisibleCount)
						{
							num = 46;
							continue;
						}
						goto IL_37D;
					}
					case 49:
						num = 23;
						continue;
					case 50:
						if (e.Modifiers != global::System.Windows.Forms.Keys.Alt)
						{
							num = 9;
							continue;
						}
						goto IL_850;
					case 51:
						if (!this.MultipleSelection)
						{
							num = 40;
							continue;
						}
						goto IL_989;
					case 52:
						if (e.Shift)
						{
							num = 49;
							continue;
						}
						goto IL_828;
					case 53:
					{
						global::custom_controls.CustomTreeNode currentClickedNode4 = this.CurrentClickedNode;
						global::custom_controls.CustomTreeNode customTreeNode;
						this.CurrentClickedNode = customTreeNode;
						num = 42;
						continue;
					}
					case 54:
						goto IL_4EF;
					case 55:
						goto IL_32B;
					case 56:
						num = 58;
						continue;
					case 57:
						goto IL_27D;
					case 58:
						if (this.CurrentClickedNode.NextVisibleNode == this.CurrentClickedNode.FirstNode)
						{
							num = 8;
							continue;
						}
						this.CurrentClickedNode.Expand();
						num = 55;
						continue;
					case 59:
						if (!this.CurrentClickedNode.IsVisible)
						{
							num = 22;
							continue;
						}
						goto IL_989;
					case 60:
						if (this.CurrentClickedNode.NextVisibleNode == this.CurrentClickedNode.FirstNode)
						{
							num = 18;
							continue;
						}
						num = 2;
						continue;
					case 61:
						num = 50;
						continue;
					case 62:
						if (e.KeyValue >= 65)
						{
							num = 15;
							continue;
						}
						goto IL_850;
					case 63:
						num = 25;
						continue;
					case 64:
						num = 51;
						continue;
					case 65:
						switch (keyCode)
						{
						case global::System.Windows.Forms.Keys.Left:
							num = 34;
							continue;
						case global::System.Windows.Forms.Keys.Up:
							num = 47;
							continue;
						case global::System.Windows.Forms.Keys.Right:
							num = 6;
							continue;
						case global::System.Windows.Forms.Keys.Down:
							num = 52;
							continue;
						default:
							num = 0;
							continue;
						}
						break;
					case 66:
						if (e.KeyValue <= 90)
						{
							num = 17;
							continue;
						}
						goto IL_850;
					case 68:
						goto IL_484;
					case 69:
						goto IL_823;
					}
					if (this.CurrentClickedNode == null)
					{
						num = 24;
						continue;
					}
					num = 12;
					continue;
					IL_1A7:
					num = 11;
					continue;
					IL_37D:
					num = 13;
					continue;
					IL_850:
					keyCode = e.KeyCode;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_37D;
					default:
						if (false)
						{
						}
						num = 65;
						continue;
					}
					IL_39D:
					this.RemovePaintFromNodes();
					this.CollectionOfNodes.Clear();
					this.CollectionOfNodes.Add(this.CurrentClickedNode);
					this.CurrentClickedNode.Highlighted = true;
					this.x = this.CurrentClickedNode;
					num = 41;
					continue;
					IL_4EF:
					num = 48;
					continue;
					IL_547:
					num = 60;
					continue;
					IL_6B0:
					num = 28;
					continue;
					IL_828:
					num = 14;
				}
				IL_152:
				base.OnKeyDown(e);
				return;
				IL_1F2:
				IL_232:
				IL_27D:
				IL_305:
				IL_32B:
				IL_3E4:
				IL_484:
				IL_495:
				IL_58B:
				IL_823:
				IL_989:
				base.OnKeyDown(e);
				return;
			}
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000621A8 File Offset: 0x000603A8
		protected override bool ProcessCmdKey(ref global::System.Windows.Forms.Message msg, global::System.Windows.Forms.Keys keyData)
		{
			int num = 15;
			for (;;)
			{
				global::System.Windows.Forms.Keys keys;
				global::System.Windows.Forms.Keys keys3;
				switch (num)
				{
				case 0:
					if (keys == global::System.Windows.Forms.Keys.Shift)
					{
						num = 1;
						continue;
					}
					goto IL_12F;
				case 1:
				{
					global::System.Windows.Forms.Keys keys2 = keys3;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12F;
					default:
						if (false)
						{
						}
						num = 5;
						continue;
					}
					break;
				}
				case 2:
					this.a();
					num = 10;
					continue;
				case 3:
					goto IL_102;
				case 4:
					if (true)
					{
					}
					this.a();
					num = 3;
					continue;
				case 5:
				{
					global::System.Windows.Forms.Keys keys2;
					if (keys2 == global::System.Windows.Forms.Keys.F10)
					{
						num = 2;
						continue;
					}
					goto IL_1A6;
				}
				case 6:
					num = 14;
					continue;
				case 7:
					goto IL_BB;
				case 8:
					num = 0;
					continue;
				case 9:
					if (keys3 == global::System.Windows.Forms.Keys.Apps)
					{
						num = 4;
						continue;
					}
					goto IL_1A6;
				case 10:
					goto IL_78;
				case 11:
					if (msg.Msg == 260)
					{
						num = 7;
						continue;
					}
					goto IL_1A6;
				case 12:
					num = 11;
					continue;
				case 13:
					if (this.SelectedNode != null)
					{
						num = 6;
						continue;
					}
					goto IL_1A6;
				case 14:
					if (this.SelectedNode.IsEditing)
					{
						num = 8;
						continue;
					}
					goto IL_1A6;
				}
				if (msg.Msg != 256)
				{
					num = 12;
					continue;
				}
				IL_BB:
				keys = (keyData & global::System.Windows.Forms.Keys.Modifiers);
				keys3 = (keyData & global::System.Windows.Forms.Keys.KeyCode);
				num = 13;
				continue;
				IL_12F:
				num = 9;
			}
			IL_78:
			IL_102:
			IL_1A6:
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00062364 File Offset: 0x00060564
		protected override void OnLostFocus(global::System.EventArgs e)
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
			this.GraySelectedNodes();
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000623A8 File Offset: 0x000605A8
		public void GraySelectedNodes()
		{
			int num = 3;
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_142;
				default:
					if (false)
					{
					}
					switch (num)
					{
					case 0:
						goto IL_142;
					case 1:
						return;
					case 2:
						num = 0;
						continue;
					case 4:
						try
						{
							num = 4;
							for (;;)
							{
								if (true)
								{
								}
								switch (num)
								{
								case 0:
									num = 3;
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = 0;
										continue;
									}
									global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)enumerator.Current;
									customTreeNode.GrayedSelected = true;
									num = 2;
									continue;
								}
								case 3:
									goto IL_C5;
								}
								IL_86:
								num = 1;
								continue;
								goto IL_86;
							}
							IL_C5:
							goto IL_15D;
						}
						finally
						{
							for (;;)
							{
								global::System.IDisposable disposable = enumerator as global::System.IDisposable;
								num = 2;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_108;
									case 1:
										disposable.Dispose();
										num = 0;
										continue;
									case 2:
										if (disposable != null)
										{
											num = 1;
											continue;
										}
										goto IL_10A;
									}
									break;
								}
							}
							IL_108:
							IL_10A:;
						}
						goto IL_10B;
					}
					if (this.CollectionOfNodes != null)
					{
						num = 2;
						continue;
					}
					return;
				}
				IL_10B:
				base.BeginUpdate();
				enumerator = this.CollectionOfNodes.GetEnumerator();
				num = 4;
				continue;
				IL_142:
				if (this.CollectionOfNodes.Count != 0)
				{
					goto IL_10B;
				}
				num = 1;
			}
			return;
			IL_15D:
			base.EndUpdate();
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00062528 File Offset: 0x00060728
		protected override void OnGotFocus(global::System.EventArgs e)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (this.CollectionOfNodes.Count == 0)
					{
						num = 3;
						continue;
					}
					goto IL_78;
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_59;
					default:
						if (false)
						{
						}
						break;
					}
					break;
				case 2:
					goto IL_59;
				case 3:
					goto IL_76;
				}
				if (this.CollectionOfNodes != null)
				{
					num = 2;
					continue;
				}
				break;
				IL_59:
				num = 0;
			}
			return;
			IL_76:
			return;
			IL_78:
			if (true)
			{
			}
			base.BeginUpdate();
			this.PaintSelectedNodes();
			base.EndUpdate();
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000625C8 File Offset: 0x000607C8
		protected override void OnBeforeSelect(global::System.Windows.Forms.TreeViewCancelEventArgs e)
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
			e.Cancel = true;
			base.OnBeforeSelect(e);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00062614 File Offset: 0x00060814
		protected override void OnMouseDown(global::System.Windows.Forms.MouseEventArgs e)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)base.GetNodeAt(e.X, e.Y);
					int num = 85;
					for (;;)
					{
						int num2;
						bool flag;
						global::custom_controls.CustomTreeNode customTreeNode2;
						int num3;
						global::custom_controls.CustomTreeNode customTreeNode3;
						global::custom_controls.CustomTreeNode customTreeNode4;
						bool flag2;
						bool flag3;
						int num4;
						bool flag4;
						global::System.Collections.Queue queue;
						switch (num)
						{
						case 0:
							this.x = (global::custom_controls.CustomTreeNode)this.CollectionOfNodes[0];
							num2 = 0;
							num = 12;
							continue;
						case 1:
							if (!flag)
							{
								num = 9;
								continue;
							}
							goto IL_D30;
						case 2:
							if (customTreeNode2.IsCBZone)
							{
								goto IL_4FF;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_A40;
							default:
								if (false)
								{
								}
								num = 79;
								continue;
							}
							break;
						case 3:
							if (e.Button == global::System.Windows.Forms.MouseButtons.Right)
							{
								num = 38;
								continue;
							}
							this.CurrentClickedNode = customTreeNode;
							num = 54;
							continue;
						case 4:
							this.x = (global::custom_controls.CustomTreeNode)this.CollectionOfNodes[num2];
							num = 17;
							continue;
						case 5:
							goto IL_DAB;
						case 6:
							num = 51;
							continue;
						case 7:
							goto IL_6E9;
						case 8:
							goto IL_582;
						case 9:
							num = 36;
							continue;
						case 10:
							if (flag)
							{
								num = 71;
								continue;
							}
							num = 104;
							continue;
						case 11:
							goto IL_B88;
						case 12:
							goto IL_582;
						case 13:
							num = 81;
							continue;
						case 14:
							if (global::System.Windows.Forms.Control.ModifierKeys == global::System.Windows.Forms.Keys.Shift)
							{
								num = 6;
								continue;
							}
							num = 28;
							continue;
						case 15:
							num = 37;
							continue;
						case 16:
							goto IL_5EB;
						case 17:
							goto IL_C91;
						case 18:
							if (this.CollectionOfNodes.Contains(customTreeNode))
							{
								num = 78;
								continue;
							}
							goto IL_CA8;
						case 19:
							num = 20;
							continue;
						case 20:
							if (this.CollectionOfNodes.Count > 0)
							{
								num = 0;
								continue;
							}
							goto IL_8BC;
						case 21:
							if (!this.SelectedNodes.Contains(this.CurrentClickedNode))
							{
								num = 76;
								continue;
							}
							goto IL_DAB;
						case 22:
						{
							int index;
							if (num3 > index)
							{
								num = 16;
								continue;
							}
							num = 2;
							continue;
						}
						case 23:
							if (this.CollectionOfNodes != null)
							{
								num = 35;
								continue;
							}
							goto IL_80F;
						case 24:
							if (this.CollectionOfNodes.Count <= 0)
							{
								num = 88;
								continue;
							}
							num = 87;
							continue;
						case 25:
							if (this.CurrentClickedNode.Text.Equals(this.x.Text))
							{
								num = 19;
								continue;
							}
							goto IL_8BC;
						case 26:
							if (global::custom_controls.CustomTreeView.IsSibling(customTreeNode3, customTreeNode4))
							{
								num = 55;
								continue;
							}
							goto IL_5EB;
						case 27:
							if (!flag2)
							{
								num = 31;
								continue;
							}
							goto IL_717;
						case 28:
							flag3 = false;
							goto IL_66B;
						case 29:
							goto IL_C0B;
						case 30:
							goto IL_639;
						case 31:
							this.x = this.CurrentClickedNode;
							num = 45;
							continue;
						case 32:
							num = 52;
							continue;
						case 33:
							if ((this.CollectionOfNodes[num4] as global::custom_controls.CustomTreeNode).IsCBZone)
							{
								num = 80;
								continue;
							}
							goto IL_B88;
						case 34:
							flag4 = this.MultipleSelection;
							goto IL_EC6;
						case 35:
							num = 39;
							continue;
						case 36:
							if (flag2)
							{
								num = 30;
								continue;
							}
							goto IL_5B1;
						case 37:
							if (!this.CollectionOfNodes.Contains(customTreeNode))
							{
								num = 130;
								continue;
							}
							goto IL_80F;
						case 38:
							num = 60;
							continue;
						case 39:
							if (this.CollectionOfNodes.Count > 1)
							{
								num = 15;
								continue;
							}
							goto IL_80F;
						case 40:
							num = 1;
							continue;
						case 41:
							goto IL_C6B;
						case 42:
						{
							global::custom_controls.CustomTreeNode customTreeNode5 = customTreeNode3;
							customTreeNode3 = customTreeNode4;
							customTreeNode4 = customTreeNode5;
							num3 = customTreeNode3.Index;
							int index = customTreeNode4.Index;
							num = 117;
							continue;
						}
						case 43:
							num = 25;
							continue;
						case 44:
							flag4 = false;
							goto IL_EC6;
						case 45:
							goto IL_717;
						case 46:
							num = 34;
							continue;
						case 47:
							base.Focus();
							num = 116;
							continue;
						case 48:
							num = 24;
							continue;
						case 49:
							num = 126;
							continue;
						case 50:
							if (this.NodesForMultipleSelection.Count != 0)
							{
								num = 105;
								continue;
							}
							goto IL_DD3;
						case 51:
							flag3 = this.MultipleSelection;
							goto IL_66B;
						case 52:
							if (this.NodesForMultipleSelection.Contains(this.w.Parent))
							{
								num = 53;
								continue;
							}
							goto IL_3C1;
						case 53:
							goto IL_DD3;
						case 54:
							if (e.Button == global::System.Windows.Forms.MouseButtons.Left)
							{
								num = 118;
								continue;
							}
							goto IL_FFA;
						case 55:
						{
							num3 = customTreeNode3.Index;
							int index = customTreeNode4.Index;
							num = 56;
							continue;
						}
						case 56:
						{
							int index;
							if (index < num3)
							{
								num = 42;
								continue;
							}
							goto IL_73A;
						}
						case 57:
							goto IL_25C;
						case 58:
							num = 50;
							continue;
						case 59:
							num = 70;
							continue;
						case 60:
							if (!this.Focused)
							{
								num = 47;
								continue;
							}
							goto IL_E9E;
						case 61:
							goto IL_37A;
						case 62:
							if (this.CollectionOfNodes != null)
							{
								num = 13;
								continue;
							}
							goto IL_FC8;
						case 63:
							if (this.CollectionOfNodes.Count > 0)
							{
								num = 111;
								continue;
							}
							goto IL_776;
						case 64:
							this.NodeChanged = true;
							num = 98;
							continue;
						case 65:
							goto IL_6BC;
						case 66:
							goto IL_C6B;
						case 67:
							if (this.CollectionOfNodes != null)
							{
								num = 49;
								continue;
							}
							goto IL_D30;
						case 68:
							num = 113;
							continue;
						case 69:
							if (this.CurrentClickedNode.ID == this.x.ID)
							{
								num = 43;
								continue;
							}
							goto IL_8BC;
						case 70:
							if (global::custom_controls.CustomTreeView.IsSibling((global::custom_controls.CustomTreeNode)this.CollectionOfNodes[0], this.CurrentClickedNode))
							{
								num = 74;
								continue;
							}
							goto IL_69D;
						case 71:
							num = 89;
							continue;
						case 72:
							if (num4 >= this.CollectionOfNodes.Count)
							{
								num = 129;
								continue;
							}
							num = 33;
							continue;
						case 73:
							goto IL_31A;
						case 74:
							goto IL_A40;
						case 75:
							this.NodeChanged = true;
							this.CurrentClickedNode = customTreeNode;
							num = 97;
							continue;
						case 76:
							this.NodeChanged = true;
							num = 5;
							continue;
						case 77:
							goto IL_4FA;
						case 78:
							goto IL_883;
						case 79:
							queue.Enqueue(customTreeNode2);
							num = 86;
							continue;
						case 80:
							this.RemovePaintFromNodes();
							this.CollectionOfNodes.Remove(this.CollectionOfNodes[num4]);
							num = 11;
							continue;
						case 81:
							if (this.CollectionOfNodes.Count > 0)
							{
								num = 115;
								continue;
							}
							goto IL_FC8;
						case 82:
							num = 27;
							continue;
						case 83:
							num = 94;
							continue;
						case 84:
							if (this.CollectionOfNodes.Count == 1)
							{
								num = 112;
								continue;
							}
							this.NodeChanged = true;
							this.RemovePaintFromNodes();
							this.CollectionOfNodes.Remove(this.CurrentClickedNode);
							num = 69;
							continue;
						case 85:
							if (customTreeNode == null)
							{
								num = 57;
								continue;
							}
							num = 3;
							continue;
						case 86:
							goto IL_4FF;
						case 87:
							if (!this.CollectionOfNodes.Contains(this.CurrentClickedNode))
							{
								num = 101;
								continue;
							}
							num = 84;
							continue;
						case 88:
							goto IL_E3E;
						case 89:
							if (this.NodesForMultipleSelection != null)
							{
								num = 58;
								continue;
							}
							goto IL_DD3;
						case 90:
							if (this.CollectionOfNodes != null)
							{
								num = 99;
								continue;
							}
							goto IL_776;
						case 91:
							num4 = 0;
							num = 93;
							continue;
						case 92:
							if (this.CollectionOfNodes != null)
							{
								num = 103;
								continue;
							}
							goto IL_CA8;
						case 93:
							goto IL_6E9;
						case 94:
							if (this.CollectionOfNodes.Contains(this.CurrentClickedNode))
							{
								num = 61;
								continue;
							}
							goto IL_F67;
						case 95:
							if (((global::custom_controls.CustomTreeNode)this.CollectionOfNodes[num2]).Position < this.x.Position)
							{
								num = 4;
								continue;
							}
							goto IL_C91;
						case 96:
							if (true)
							{
							}
							num = 18;
							continue;
						case 97:
							goto IL_4A1;
						case 98:
							goto IL_F8C;
						case 99:
							num = 63;
							continue;
						case 100:
							if (this.NodesForMultipleSelection.Count > 0)
							{
								num = 32;
								continue;
							}
							goto IL_3C1;
						case 101:
							num = 106;
							continue;
						case 102:
							goto IL_5AC;
						case 103:
							num = 125;
							continue;
						case 104:
							if (this.CollectionOfNodes.Count > 1)
							{
								num = 83;
								continue;
							}
							goto IL_F67;
						case 105:
							num = 100;
							continue;
						case 106:
							if (this.NodesForMultipleSelection.Count > 0)
							{
								num = 68;
								continue;
							}
							goto IL_69D;
						case 107:
							goto IL_FC8;
						case 108:
							if (!flag)
							{
								num = 82;
								continue;
							}
							goto IL_717;
						case 109:
							goto IL_776;
						case 110:
							goto IL_795;
						case 111:
							this.RemovePaintFromNodes();
							this.CollectionOfNodes.Clear();
							num = 109;
							continue;
						case 112:
							goto IL_D61;
						case 113:
							if (this.NodesForMultipleSelection.Contains(this.CurrentClickedNode.Parent))
							{
								num = 59;
								continue;
							}
							goto IL_69D;
						case 114:
							if (global::System.Windows.Forms.Control.ModifierKeys == global::System.Windows.Forms.Keys.Control)
							{
								num = 46;
								continue;
							}
							num = 44;
							continue;
						case 115:
							num = 122;
							continue;
						case 116:
							goto IL_E9E;
						case 117:
							goto IL_73A;
						case 118:
							num = 114;
							continue;
						case 119:
							if (this.CurrentClickedNode != customTreeNode)
							{
								num = 75;
								continue;
							}
							goto IL_997;
						case 120:
							if (num2 >= this.CollectionOfNodes.Count)
							{
								num = 102;
								continue;
							}
							num = 95;
							continue;
						case 121:
							goto IL_FF8;
						case 122:
							if (!this.CollectionOfNodes.Contains(this.CurrentClickedNode))
							{
								num = 64;
								continue;
							}
							goto IL_F8C;
						case 123:
							if (flag2)
							{
								num = 48;
								continue;
							}
							num = 10;
							continue;
						case 124:
							if (this.CollectionOfNodes.Count > 1)
							{
								num = 91;
								continue;
							}
							goto IL_BF9;
						case 125:
							if (this.CollectionOfNodes.Count > 1)
							{
								num = 96;
								continue;
							}
							goto IL_CA8;
						case 126:
							if (this.CollectionOfNodes.Count == 0)
							{
								num = 40;
								continue;
							}
							goto IL_5B1;
						case 127:
							this.CurrentClickedNode.BackColor = this.CurrentClickedNode.TreeView.BackColor;
							this.CurrentClickedNode.ForeColor = this.CurrentClickedNode.TreeView.ForeColor;
							num = 77;
							continue;
						case 128:
							if (!this.CollectionOfNodes.Contains(this.CurrentClickedNode))
							{
								num = 127;
								continue;
							}
							goto IL_FFA;
						case 129:
							goto IL_BF9;
						case 130:
							this.NodeChanged = true;
							this.CurrentClickedNode = customTreeNode;
							num = 73;
							continue;
						}
						break;
						IL_3C1:
						num = 128;
						continue;
						IL_4FF:
						customTreeNode2 = (global::custom_controls.CustomTreeNode)customTreeNode2.NextNode;
						num3++;
						num = 66;
						continue;
						IL_582:
						num = 120;
						continue;
						IL_5B1:
						num = 108;
						continue;
						IL_5EB:
						num = 21;
						continue;
						IL_66B:
						flag = flag3;
						this.w = this.CurrentClickedNode;
						num = 67;
						continue;
						IL_69D:
						this.CurrentClickedNode.Highlighted = false;
						this.NodeChanged = false;
						num = 65;
						continue;
						IL_6E9:
						num = 72;
						continue;
						IL_717:
						num = 123;
						continue;
						IL_73A:
						customTreeNode2 = customTreeNode3;
						num = 41;
						continue;
						IL_776:
						this.CollectionOfNodes.AddRange(queue);
						this.PaintSelectedNodes();
						num = 110;
						continue;
						IL_80F:
						num = 119;
						continue;
						IL_A40:
						this.NodeChanged = true;
						this.CollectionOfNodes.Add(this.CurrentClickedNode);
						num = 124;
						continue;
						IL_B88:
						num4++;
						num = 7;
						continue;
						IL_BF9:
						this.PaintSelectedNodes();
						num = 29;
						continue;
						IL_C6B:
						num = 22;
						continue;
						IL_C91:
						num2++;
						num = 8;
						continue;
						IL_CA8:
						num = 23;
						continue;
						IL_DAB:
						num = 90;
						continue;
						IL_DD3:
						queue = new global::System.Collections.Queue();
						customTreeNode3 = this.x;
						customTreeNode4 = this.CurrentClickedNode;
						num = 26;
						continue;
						IL_E9E:
						num = 92;
						continue;
						IL_EC6:
						flag2 = flag4;
						num = 14;
						continue;
						IL_F67:
						num = 62;
						continue;
						IL_F8C:
						this.RemovePaintFromNodes();
						this.CollectionOfNodes.Clear();
						num = 107;
						continue;
						IL_FC8:
						this.CollectionOfNodes.Add(this.CurrentClickedNode);
						this.PaintSelectedNodes();
						this.x = this.CurrentClickedNode;
						num = 121;
					}
				}
				IL_25C:
				base.OnMouseDown(e);
				return;
				IL_31A:
				goto IL_997;
				IL_37A:
				this.ac = true;
				base.OnMouseDown(e);
				return;
				IL_4A1:
				goto IL_997;
				IL_4FA:
				goto IL_FFA;
				IL_5AC:
				goto IL_8BC;
				IL_639:
				goto IL_D30;
				IL_6BC:
				IL_795:
				goto IL_FFA;
				IL_883:
				base.OnMouseDown(e);
				return;
				IL_8BC:
				this.PaintSelectedNodes();
				base.OnMouseDown(e);
				return;
				IL_997:
				this.RemovePaintFromNodes();
				this.CollectionOfNodes.Clear();
				this.CollectionOfNodes.Add(this.CurrentClickedNode);
				this.x = this.CurrentClickedNode;
				this.PaintSelectedNodes();
				base.OnMouseDown(e);
				return;
				IL_C0B:
				goto IL_FFA;
				IL_D30:
				base.OnMouseDown(e);
				return;
				IL_D61:
				this.PaintSelectedNodes();
				base.OnMouseDown(e);
				return;
				IL_E3E:
				this.NodeChanged = true;
				this.CollectionOfNodes.Add(this.CurrentClickedNode);
				this.PaintSelectedNodes();
				base.OnMouseDown(e);
				return;
				IL_FF8:
				IL_FFA:
				base.OnMouseDown(e);
				return;
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00063624 File Offset: 0x00061824
		protected override void OnMouseUp(global::System.Windows.Forms.MouseEventArgs e)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_9B;
				case 1:
					this.ac = false;
					this.RemovePaintFromNodes();
					this.CollectionOfNodes.Clear();
					this.CollectionOfNodes.Add(this.CurrentClickedNode);
					this.PaintSelectedNodes();
					this.NodeChanged = true;
					num = 0;
					continue;
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9B;
					default:
						if (true)
						{
						}
						if (false)
						{
						}
						break;
					}
					break;
				}
				if (!this.ac)
				{
					break;
				}
				num = 1;
			}
			IL_9B:
			base.OnMouseUp(e);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000636D8 File Offset: 0x000618D8
		protected override void OnGiveFeedback(global::System.Windows.Forms.GiveFeedbackEventArgs gfbevent)
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
			gfbevent.UseDefaultCursors = false;
			global::System.Windows.Forms.Cursor.Current = this.y;
			base.OnGiveFeedback(gfbevent);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0006372C File Offset: 0x0006192C
		protected override void OnItemDrag(global::System.Windows.Forms.ItemDragEventArgs e)
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
			this.ac = false;
			base.DoDragDrop(e.Item, global::System.Windows.Forms.DragDropEffects.Copy);
			base.OnItemDrag(e);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00063784 File Offset: 0x00061984
		protected override void OnDragEnter(global::System.Windows.Forms.DragEventArgs e)
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
			e.Effect = global::System.Windows.Forms.DragDropEffects.Copy;
			base.OnDragEnter(e);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000637D0 File Offset: 0x000619D0
		protected override void OnDragOver(global::System.Windows.Forms.DragEventArgs drgevent)
		{
			for (;;)
			{
				drgevent.Effect = global::System.Windows.Forms.DragDropEffects.Copy;
				this.RemovePaintFromNodes();
				global::custom_controls.CustomTreeNode customTreeNode = this.ScrollTreeNode(drgevent.X, drgevent.Y);
				int num = 8;
				for (;;)
				{
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						goto IL_109;
					case 1:
						if (this.z != null)
						{
							num = 9;
							continue;
						}
						goto IL_F7;
					case 2:
						goto IL_F7;
					case 3:
						num = 6;
						continue;
					case 4:
						if (this.z.TreeView != null)
						{
							num = 3;
							continue;
						}
						goto IL_F7;
					case 5:
						customTreeNode.Highlighted = true;
						num = 1;
						continue;
					case 6:
						if (this.z != customTreeNode)
						{
							num = 7;
							continue;
						}
						goto IL_F7;
					case 7:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							this.z.Highlighted = false;
							num = 2;
							continue;
						}
						break;
					case 8:
						if (customTreeNode != null)
						{
							num = 5;
							continue;
						}
						goto IL_133;
					case 9:
						num = 4;
						continue;
					}
					break;
					IL_F7:
					this.z = customTreeNode;
					num = 0;
				}
			}
			IL_109:
			IL_133:
			base.OnDragOver(drgevent);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00063918 File Offset: 0x00061B18
		protected override void OnDragLeave(global::System.EventArgs e)
		{
			int num = 6;
			for (;;)
			{
				switch (num)
				{
				case 0:
				{
					global::System.Collections.ArrayList selectedNodes = this.SortNodesCollection(this.SelectedNodes);
					global::custom_controls.CustomTreeView.OperateEventArgs operateEventArgs = new global::custom_controls.CustomTreeView.OperateEventArgs(selectedNodes);
					this.OnCrossDragDrop(operateEventArgs);
					num = 7;
					continue;
				}
				case 1:
					if (this.SelectedNodes.Count > 0)
					{
						goto IL_5E;
					}
					goto IL_D3;
				case 2:
					if (true)
					{
					}
					goto IL_42;
				case 3:
					num = 4;
					continue;
				case 4:
					if (this.z.TreeView != null)
					{
						num = 5;
						continue;
					}
					goto IL_42;
				case 5:
					this.z.Highlighted = false;
					num = 2;
					continue;
				case 7:
					goto IL_D3;
				}
				if (this.z != null)
				{
					num = 3;
					continue;
				}
				IL_42:
				this.PaintSelectedNodes();
				num = 1;
				continue;
				IL_5E:
				num = 0;
				continue;
				IL_D3:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5E;
				}
				break;
			}
			if (false)
			{
			}
			base.OnDragLeave(e);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00063A28 File Offset: 0x00061C28
		protected override void OnDragDrop(global::System.Windows.Forms.DragEventArgs e)
		{
			int num = 1;
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
						num = 2;
						continue;
					case 2:
						if (true)
						{
						}
						if (this.z.TreeView != null)
						{
							num = 3;
							continue;
						}
						goto IL_9C;
					case 3:
						goto IL_52;
					case 4:
						goto IL_66;
					}
					if (this.z != null)
					{
						num = 0;
						continue;
					}
					goto IL_9C;
				}
				IL_52:
				this.z.Highlighted = false;
				num = 4;
			}
			IL_66:
			IL_9C:
			this.PaintSelectedNodes();
			base.OnDragDrop(e);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00063AE0 File Offset: 0x00061CE0
		protected override void OnAfterCollapse(global::System.Windows.Forms.TreeViewEventArgs e)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_08;
				case 1:
				{
					global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)e.Node;
					customTreeNode.ImageIndex = (int)this.CollapsedIcons[0];
					this.CollapsedIcons.Clear();
					num = 2;
					continue;
				}
				case 2:
					goto IL_81;
				case 3:
					if (this.CollapsedIcons.Count <= 0)
					{
						goto IL_C5;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_08;
					default:
						if (false)
						{
						}
						num = 1;
						continue;
					}
					break;
				case 4:
					num = 3;
					continue;
				}
				IL_2C:
				if (base.ImageList != null)
				{
					num = 4;
					continue;
				}
				break;
				IL_08:
				if (true)
				{
				}
				goto IL_2C;
			}
			IL_81:
			IL_C5:
			base.OnAfterCollapse(e);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00063BBC File Offset: 0x00061DBC
		protected override void OnAfterExpand(global::System.Windows.Forms.TreeViewEventArgs e)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					num = 3;
					continue;
				case 2:
				{
					global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)e.Node;
					customTreeNode.ImageIndex = (int)this.ExpandedIcons[0];
					this.ExpandedIcons.Clear();
					num = 4;
					continue;
				}
				case 3:
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
						if (this.ExpandedIcons.Count > 0)
						{
							num = 2;
							continue;
						}
						goto IL_C5;
					}
					break;
				case 4:
					goto IL_6F;
				}
				IL_24:
				if (base.ImageList != null)
				{
					num = 0;
					continue;
				}
				break;
				goto IL_24;
			}
			IL_6F:
			IL_C5:
			base.OnAfterExpand(e);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00063C98 File Offset: 0x00061E98
		protected override void OnBeforeLabelEdit(global::System.Windows.Forms.NodeLabelEditEventArgs e)
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
			base.OnBeforeLabelEdit(e);
			this.ag = (long)global::custom_controls.CustomTreeView.SendMessage(base.Handle, this.af, (global::System.IntPtr)0, 0);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00063CFC File Offset: 0x00061EFC
		protected virtual void OnAdd(global::custom_controls.CustomTreeView.OperateEventArgs e)
		{
			if (true)
			{
			}
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2C;
					default:
						if (false)
						{
						}
						this.an(this, e);
						num = 1;
						continue;
					}
					break;
				case 1:
					return;
				}
				goto IL_24;
				IL_2C:
				num = 0;
				continue;
				IL_24:
				if (this.an != null)
				{
					goto IL_2C;
				}
				break;
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00063D7C File Offset: 0x00061F7C
		protected virtual void OnDelete(global::custom_controls.CustomTreeView.OperateEventArgs e)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 0:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4A;
					default:
						if (false)
						{
						}
						break;
					}
					break;
				case 1:
					if (true)
					{
					}
					this.ao(this, e);
					num = 2;
					continue;
				case 2:
					return;
				}
				goto IL_42;
				IL_4A:
				num = 1;
				continue;
				IL_42:
				if (this.ao != null)
				{
					goto IL_4A;
				}
				break;
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00063DFC File Offset: 0x00061FFC
		protected virtual void OnRename(global::custom_controls.CustomTreeView.OperateEventArgs e)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 0:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4A;
					default:
						if (false)
						{
						}
						break;
					}
					break;
				case 1:
					return;
				case 2:
					if (true)
					{
					}
					this.ap(this, e);
					num = 1;
					continue;
				}
				goto IL_42;
				IL_4A:
				num = 2;
				continue;
				IL_42:
				if (this.ap != null)
				{
					goto IL_4A;
				}
				break;
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00063E7C File Offset: 0x0006207C
		protected virtual void OnSortByName(global::custom_controls.CustomTreeView.OperateEventArgs e)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.aq(this, e);
					num = 1;
					continue;
				case 1:
					goto IL_4D;
				}
				if (true)
				{
				}
				if (this.aq != null)
				{
					num = 0;
					continue;
				}
				IL_4D:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_63;
				}
			}
			IL_63:
			if (false)
			{
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00063EFC File Offset: 0x000620FC
		protected virtual void OnSortByType(global::custom_controls.CustomTreeView.OperateEventArgs e)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_4D;
				case 1:
					if (true)
					{
					}
					this.ar(this, e);
					num = 0;
					continue;
				}
				if (this.ar != null)
				{
					num = 1;
					continue;
				}
				IL_4D:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_63;
				}
			}
			IL_63:
			if (false)
			{
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00063F7C File Offset: 0x0006217C
		protected virtual void OnCrossDragDrop(global::custom_controls.CustomTreeView.OperateEventArgs e)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.at(this, e);
					num = 2;
					continue;
				case 2:
					goto IL_45;
				}
				IL_1C:
				if (this.at != null)
				{
					num = 0;
					continue;
				}
				IL_45:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1C;
				default:
					goto IL_5B;
				}
			}
			IL_5B:
			if (true)
			{
			}
			if (false)
			{
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00063FFC File Offset: 0x000621FC
		protected virtual void OnMultipleDragDrop(global::custom_controls.CustomTreeView.OperateEventArgs e)
		{
			if (true)
			{
			}
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_57;
				case 2:
					this.@as(this, e);
					num = 0;
					continue;
				}
				IL_24:
				if (this.@as != null)
				{
					num = 2;
					continue;
				}
				IL_57:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_24;
				default:
					goto IL_6D;
				}
			}
			IL_6D:
			if (false)
			{
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0006407C File Offset: 0x0006227C
		public bool ClickAdd(global::System.Collections.ArrayList treeNodes)
		{
			bool result;
			try
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
				global::custom_controls.CustomTreeView.OperateEventArgs operateEventArgs = new global::custom_controls.CustomTreeView.OperateEventArgs(treeNodes);
				this.OnAdd(operateEventArgs);
				result = true;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000640E0 File Offset: 0x000622E0
		public bool AddHelper(global::System.Windows.Forms.TreeNode parentNode, string text, string tag, string type, string id, int imageIndex, ref global::custom_controls.CustomTreeNode nodeAdded, bool isExpandParent, string sortType)
		{
			bool result;
			try
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						nodeAdded = new global::custom_controls.CustomTreeNode();
						num = 17;
						continue;
					case 2:
						goto IL_255;
					case 3:
						goto IL_248;
					case 4:
						if (isExpandParent)
						{
							num = 12;
							continue;
						}
						goto IL_248;
					case 5:
						num = 7;
						continue;
					case 6:
						if (imageIndex != -1)
						{
							num = 14;
							continue;
						}
						goto IL_77;
					case 7:
						if (base.ImageList.Images.Count <= imageIndex)
						{
							num = 18;
							continue;
						}
						goto IL_9C;
					case 8:
						goto IL_1A8;
					case 9:
						if (base.ImageList != null)
						{
							num = 5;
							continue;
						}
						goto IL_1C6;
					case 10:
						goto IL_9C;
					case 11:
						nodeAdded.IsCBZone = true;
						num = 15;
						continue;
					case 12:
						parentNode.Expand();
						num = 3;
						continue;
					case 13:
						goto IL_77;
					case 14:
						if (true)
						{
						}
						nodeAdded.ImageIndex = imageIndex;
						num = 13;
						continue;
					case 15:
						goto IL_D9;
					case 16:
						if ((parentNode as global::custom_controls.CustomTreeNode).IsCBZone)
						{
							num = 11;
							continue;
						}
						goto IL_D9;
					case 17:
						goto IL_1F5;
					case 18:
						goto IL_1C6;
					case 19:
						result = false;
						num = 8;
						continue;
					case 20:
						if (nodeAdded == null)
						{
							num = 0;
							continue;
						}
						goto IL_1F5;
					}
					if (parentNode == null)
					{
						num = 19;
						continue;
					}
					num = 20;
					continue;
					IL_77:
					num = 16;
					continue;
					IL_9C:
					num = 6;
					continue;
					IL_D9:
					nodeAdded.Position = parentNode.Nodes.Count + 1;
					parentNode.Nodes.Add(nodeAdded);
					num = 4;
					continue;
					IL_1C6:
					imageIndex = -1;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						num = 10;
						continue;
					}
					IL_1F5:
					nodeAdded.Text = text;
					nodeAdded.Tag = tag;
					nodeAdded.Type = type;
					nodeAdded.ID = id;
					nodeAdded.SortType = sortType;
					num = 9;
					continue;
					IL_248:
					result = true;
					num = 2;
				}
				IL_1A8:
				IL_255:;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00064370 File Offset: 0x00062570
		public bool ClickDelete(global::System.Collections.ArrayList treeNodes)
		{
			bool result;
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				global::custom_controls.CustomTreeView.OperateEventArgs operateEventArgs = new global::custom_controls.CustomTreeView.OperateEventArgs(treeNodes);
				this.OnDelete(operateEventArgs);
				result = true;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			if (true)
			{
			}
			return result;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000643D4 File Offset: 0x000625D4
		public bool DeleteHelper(global::System.Collections.ArrayList selectedNodes, global::custom_controls.CustomTreeNode highlightedAfterDelete, bool highlightGivenNodeOnly = false)
		{
			bool result;
			try
			{
				switch (0)
				{
				default:
				{
					int num = 10;
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						switch (num)
						{
						case 0:
							highlightedAfterDelete = new global::custom_controls.CustomTreeNode();
							num = 3;
							continue;
						case 1:
							if (!highlightGivenNodeOnly)
							{
								num = 11;
								continue;
							}
							goto IL_62;
						case 2:
							num = 9;
							continue;
						case 3:
							goto IL_78;
						case 4:
							this.CollectionOfNodes.Clear();
							num = 7;
							continue;
						case 5:
							if (this.CollectionOfNodes != null)
							{
								num = 2;
								continue;
							}
							goto IL_34F;
						case 6:
							try
							{
								num = 3;
								for (;;)
								{
									switch (num)
									{
									case 0:
									{
										if (!enumerator.MoveNext())
										{
											num = 2;
											continue;
										}
										global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)enumerator.Current;
										customTreeNode.Parent.Nodes.Remove(customTreeNode);
										num = 1;
										continue;
									}
									case 2:
										num = 4;
										continue;
									case 4:
										goto IL_1AB;
									}
									IL_185:
									num = 0;
									continue;
									goto IL_185;
								}
								IL_1AB:
								goto IL_D2;
							}
							finally
							{
								for (;;)
								{
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									num = 2;
									for (;;)
									{
										switch (num)
										{
										case 0:
											disposable.Dispose();
											num = 1;
											continue;
										case 1:
											goto IL_1F6;
										case 2:
											if (disposable != null)
											{
												num = 0;
												continue;
											}
											goto IL_1F8;
										}
										break;
									}
								}
								IL_1F6:
								IL_1F8:;
							}
							goto Block_7;
							IL_D2:
							num = 5;
							continue;
						case 7:
							goto IL_34F;
						case 8:
							goto IL_1F9;
						case 9:
							if (this.CollectionOfNodes.Count > 0)
							{
								num = 4;
								continue;
							}
							goto IL_34F;
						case 11:
						{
							global::System.Collections.ArrayList arrayList = this.SortNodesCollection(selectedNodes);
							global::System.Collections.IEnumerator enumerator2 = arrayList.GetEnumerator();
							num = 8;
							continue;
						}
						case 12:
							goto IL_38A;
						}
						if (highlightedAfterDelete == null)
						{
							num = 0;
							continue;
						}
						goto IL_78;
						IL_62:
						enumerator = selectedNodes.GetEnumerator();
						num = 6;
						continue;
						Block_7:
						try
						{
							IL_1F9:
							num = 0;
							for (;;)
							{
								switch (num)
								{
								case 1:
								{
									global::custom_controls.CustomTreeNode customTreeNode2;
									highlightedAfterDelete = (global::custom_controls.CustomTreeNode)customTreeNode2.NextNode;
									num = 8;
									continue;
								}
								case 2:
									goto IL_2E5;
								case 3:
									goto IL_2D9;
								case 4:
									num = 6;
									continue;
								case 5:
								{
									global::custom_controls.CustomTreeNode customTreeNode2;
									if (customTreeNode2.NextNode != null)
									{
										num = 4;
										continue;
									}
									highlightedAfterDelete = (global::custom_controls.CustomTreeNode)customTreeNode2.Parent;
									num = 3;
									continue;
								}
								case 6:
								{
									global::custom_controls.CustomTreeNode customTreeNode2;
									if (!selectedNodes.Contains(customTreeNode2.NextNode))
									{
										num = 1;
										continue;
									}
									break;
								}
								case 7:
								{
									global::System.Collections.IEnumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = 9;
										continue;
									}
									global::custom_controls.CustomTreeNode customTreeNode2 = (global::custom_controls.CustomTreeNode)enumerator2.Current;
									num = 5;
									continue;
								}
								case 8:
									goto IL_2D9;
								case 9:
									goto IL_2D9;
								}
								IL_29B:
								num = 7;
								continue;
								goto IL_29B;
								IL_2D9:
								num = 2;
							}
							IL_2E5:
							goto IL_62;
						}
						finally
						{
							for (;;)
							{
								for (;;)
								{
									global::System.Collections.IEnumerator enumerator2;
									global::System.IDisposable disposable2 = enumerator2 as global::System.IDisposable;
									num = 0;
									for (;;)
									{
										switch (num)
										{
										case 0:
											if (disposable2 != null)
											{
												num = 2;
												continue;
											}
											goto IL_34E;
										case 1:
											goto IL_34C;
										case 2:
											disposable2.Dispose();
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												if (false)
												{
												}
												num = 1;
												continue;
											}
											break;
										}
										break;
									}
								}
							}
							IL_34C:
							IL_34E:;
						}
						goto IL_34F;
						IL_78:
						num = 1;
						continue;
						IL_34F:
						this.CollectionOfNodes.Add(highlightedAfterDelete);
						this.CurrentClickedNode = highlightedAfterDelete;
						this.x = this.CurrentClickedNode;
						this.NodeChanged = true;
						this.PaintSelectedNodes();
						result = true;
						num = 12;
					}
					IL_38A:
					break;
				}
				}
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			if (true)
			{
			}
			return result;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000647D4 File Offset: 0x000629D4
		public bool ClickRename(global::System.Collections.ArrayList treeNodes)
		{
			bool result;
			try
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
				global::custom_controls.CustomTreeView.OperateEventArgs operateEventArgs = new global::custom_controls.CustomTreeView.OperateEventArgs(treeNodes);
				this.OnRename(operateEventArgs);
				result = true;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00064838 File Offset: 0x00062A38
		public bool RenameHelper(global::custom_controls.CustomTreeNode selectedNode, string validChars)
		{
			bool result;
			try
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						selectedNode.BeginEdit();
						num = 5;
						continue;
					case 2:
						goto IL_37;
					case 3:
						goto IL_B2;
					case 4:
						goto IL_51;
					case 5:
						goto IL_A5;
					case 6:
						if (selectedNode.IsEditing)
						{
							goto IL_A5;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37;
						default:
							if (false)
							{
							}
							num = 1;
							continue;
						}
						break;
					}
					if (validChars != null)
					{
						num = 2;
						continue;
					}
					goto IL_51;
					IL_37:
					if (true)
					{
					}
					this.RenameValidChars = validChars;
					num = 4;
					continue;
					IL_51:
					base.LabelEdit = true;
					num = 6;
					continue;
					IL_A5:
					result = true;
					num = 3;
				}
				IL_B2:;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0006491C File Offset: 0x00062B1C
		public bool ClickSortByName(global::System.Collections.ArrayList treeNodes)
		{
			bool result;
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				global::custom_controls.CustomTreeView.OperateEventArgs operateEventArgs = new global::custom_controls.CustomTreeView.OperateEventArgs(treeNodes);
				this.OnSortByName(operateEventArgs);
				result = true;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			if (true)
			{
			}
			return result;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00064980 File Offset: 0x00062B80
		public bool SortByNameHelper(global::custom_controls.CustomTreeNode folderNode)
		{
			bool result;
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						base.BeginUpdate();
						global::System.Collections.IEnumerator enumerator = folderNode.Nodes.GetEnumerator();
						global::System.Collections.SortedList sortedList = new global::System.Collections.SortedList(new global::custom_controls.CustomTreeView.CompareName());
						int num = 5;
						for (;;)
						{
							global::System.Collections.IEnumerator enumerator2;
							switch (num)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = 2;
									continue;
								}
								global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)enumerator.Current;
								sortedList.Add(customTreeNode.Text, customTreeNode);
								num = 3;
								continue;
							}
							case 1:
								try
								{
									num = 4;
									for (;;)
									{
										switch (num)
										{
										case 1:
										{
											if (!enumerator2.MoveNext())
											{
												num = 2;
												continue;
											}
											object obj = enumerator2.Current;
											folderNode.Nodes.Add(obj as global::custom_controls.CustomTreeNode);
											num = 0;
											continue;
										}
										case 2:
											num = 3;
											continue;
										case 3:
											goto IL_D1;
										}
										IL_84:
										num = 1;
										continue;
										goto IL_84;
									}
									IL_D1:
									goto IL_1B4;
								}
								finally
								{
									for (;;)
									{
										IL_EB:
										global::System.IDisposable disposable = enumerator2 as global::System.IDisposable;
										num = 2;
										for (;;)
										{
											switch (num)
											{
											case 0:
												disposable.Dispose();
												num = 1;
												continue;
											case 1:
												goto IL_11C;
											case 2:
												if (disposable != null)
												{
													num = 0;
													continue;
												}
												goto IL_11E;
											}
											goto IL_EB;
										}
										IL_11E:
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											continue;
										default:
											goto IL_134;
										}
										IL_11C:
										goto IL_11E;
									}
									IL_134:
									if (false)
									{
									}
								}
								goto IL_13B;
								IL_1B4:
								result = true;
								if (true)
								{
								}
								num = 4;
								continue;
							case 2:
								goto IL_13B;
							case 3:
								goto IL_192;
							case 4:
								goto IL_1CB;
							case 5:
								goto IL_192;
							}
							break;
							IL_13B:
							global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(sortedList.Values);
							folderNode.Nodes.Clear();
							enumerator2 = arrayList.GetEnumerator();
							num = 1;
							continue;
							IL_192:
							num = 0;
						}
					}
					IL_1CB:
					break;
				}
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			finally
			{
				base.EndUpdate();
			}
			return result;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00064BC0 File Offset: 0x00062DC0
		public bool SortByPositionHelper(global::custom_controls.CustomTreeNode tnFolder)
		{
			bool result;
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						base.BeginUpdate();
						int count = tnFolder.Nodes.Count;
						global::custom_controls.CustomTreeNode[] array = new global::custom_controls.CustomTreeNode[count];
						tnFolder.Nodes.CopyTo(array, 0);
						int[] array2 = new int[count];
						int num = 0;
						int num2 = 3;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_91;
							case 1:
								goto IL_1F0;
							case 2:
							{
								global::custom_controls.CustomTreeNode customTreeNode;
								if (array2[num] == customTreeNode.Position)
								{
									num2 = 15;
									continue;
								}
								int num3;
								num3++;
								num2 = 0;
								continue;
							}
							case 3:
								goto IL_D2;
							case 4:
								goto IL_91;
							case 5:
								goto IL_F3;
							case 6:
								goto IL_139;
							case 7:
								if (num >= count)
								{
									num2 = 9;
									continue;
								}
								array2[num] = array[num].Position;
								num++;
								num2 = 13;
								continue;
							case 8:
							{
								int num3;
								global::custom_controls.CustomTreeNode[] array3;
								if (num3 >= array3.Length)
								{
									num2 = 11;
									continue;
								}
								global::custom_controls.CustomTreeNode customTreeNode = array3[num3];
								num2 = 2;
								continue;
							}
							case 9:
								global::System.Array.Sort<int>(array2);
								tnFolder.Nodes.Clear();
								num = 0;
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1F0;
								default:
									if (false)
									{
									}
									num2 = 6;
									continue;
								}
								break;
							case 10:
								result = true;
								num2 = 1;
								continue;
							case 11:
								goto IL_F3;
							case 12:
							{
								if (num >= count)
								{
									num2 = 10;
									continue;
								}
								global::custom_controls.CustomTreeNode[] array3 = array;
								int num3 = 0;
								num2 = 4;
								continue;
							}
							case 13:
								goto IL_D2;
							case 14:
								goto IL_139;
							case 15:
							{
								global::custom_controls.CustomTreeNode customTreeNode;
								tnFolder.Nodes.Add(customTreeNode);
								num2 = 5;
								continue;
							}
							}
							break;
							IL_91:
							num2 = 8;
							continue;
							IL_D2:
							num2 = 7;
							continue;
							IL_F3:
							num++;
							num2 = 14;
							continue;
							IL_139:
							num2 = 12;
						}
					}
					IL_1F0:
					break;
				}
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			finally
			{
				if (true)
				{
				}
				base.EndUpdate();
			}
			return result;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00064E14 File Offset: 0x00063014
		public bool SortByIshIdHelper(global::custom_controls.CustomTreeNode tnFolder)
		{
			bool result;
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						base.BeginUpdate();
						int count = tnFolder.Nodes.Count;
						global::custom_controls.CustomTreeNode[] array = new global::custom_controls.CustomTreeNode[count];
						tnFolder.Nodes.CopyTo(array, 0);
						int[] array2 = new int[count];
						int num = 0;
						int num2 = 1;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_15F;
							case 1:
								goto IL_D2;
							case 2:
								result = true;
								num2 = 12;
								continue;
							case 3:
								goto IL_F3;
							case 4:
								goto IL_91;
							case 5:
								goto IL_194;
							case 6:
							{
								if (num >= count)
								{
									num2 = 2;
									continue;
								}
								global::custom_controls.CustomTreeNode[] array3 = array;
								int num3 = 0;
								num2 = 15;
								continue;
							}
							case 7:
							{
								global::custom_controls.CustomTreeNode customTreeNode;
								tnFolder.Nodes.Add(customTreeNode);
								num2 = 14;
								continue;
							}
							case 8:
								goto IL_15F;
							case 9:
								if (num >= count)
								{
									num2 = 5;
									continue;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_194;
								default:
									if (false)
									{
									}
									array2[num] = global::System.Convert.ToInt32(array[num].ID, global::System.Globalization.NumberFormatInfo.InvariantInfo);
									num++;
									num2 = 11;
									continue;
								}
								break;
							case 10:
							{
								global::custom_controls.CustomTreeNode[] array3;
								int num3;
								if (num3 >= array3.Length)
								{
									num2 = 3;
									continue;
								}
								global::custom_controls.CustomTreeNode customTreeNode = array3[num3];
								num2 = 13;
								continue;
							}
							case 11:
								goto IL_D2;
							case 12:
								goto IL_201;
							case 13:
							{
								global::custom_controls.CustomTreeNode customTreeNode;
								if (array2[num] == global::System.Convert.ToInt32(customTreeNode.ID, global::System.Globalization.NumberFormatInfo.InvariantInfo))
								{
									num2 = 7;
									continue;
								}
								int num3;
								num3++;
								num2 = 4;
								continue;
							}
							case 14:
								goto IL_F3;
							case 15:
								goto IL_91;
							}
							break;
							IL_91:
							num2 = 10;
							continue;
							IL_D2:
							num2 = 9;
							continue;
							IL_F3:
							num++;
							num2 = 8;
							continue;
							IL_15F:
							num2 = 6;
							continue;
							IL_194:
							global::System.Array.Sort<int>(array2);
							tnFolder.Nodes.Clear();
							num = 0;
							num2 = 0;
						}
					}
					IL_201:
					break;
				}
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			finally
			{
				if (true)
				{
				}
				base.EndUpdate();
			}
			return result;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0006507C File Offset: 0x0006327C
		public bool ClickSortByType(global::System.Collections.ArrayList treeNodes)
		{
			bool result;
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				global::custom_controls.CustomTreeView.OperateEventArgs operateEventArgs = new global::custom_controls.CustomTreeView.OperateEventArgs(treeNodes);
				this.OnSortByType(operateEventArgs);
				result = true;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			if (true)
			{
			}
			return result;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000650E0 File Offset: 0x000632E0
		public bool SortByTypeHelper(global::custom_controls.CustomTreeNode folderNode)
		{
			bool result;
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						IL_47:
						base.BeginUpdate();
						int count = folderNode.Nodes.Count;
						global::custom_controls.CustomTreeNode[] array = new global::custom_controls.CustomTreeNode[count];
						folderNode.Nodes.CopyTo(array, 0);
						global::System.Collections.IComparer comparer = new global::custom_controls.CustomTreeView.CompareType();
						global::System.Array.Sort(array, comparer);
						folderNode.Nodes.Clear();
						global::custom_controls.CustomTreeNode[] array2 = array;
						int num = 0;
						int num2 = 3;
						for (;;)
						{
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_47;
							default:
								if (false)
								{
								}
								switch (num2)
								{
								case 0:
									goto IL_F1;
								case 1:
								{
									if (num >= array2.Length)
									{
										num2 = 2;
										continue;
									}
									global::custom_controls.CustomTreeNode node = array2[num];
									folderNode.Nodes.Add(node);
									num++;
									num2 = 4;
									continue;
								}
								case 2:
									result = true;
									num2 = 0;
									continue;
								case 3:
									goto IL_99;
								case 4:
									goto IL_99;
								}
								goto IL_47;
								IL_99:
								num2 = 1;
								break;
							}
						}
					}
					IL_F1:
					break;
				}
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			finally
			{
				if (true)
				{
				}
				base.EndUpdate();
			}
			return result;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00065220 File Offset: 0x00063420
		public bool DropHelper(global::System.Collections.ArrayList nodesCollection, global::custom_controls.CustomTreeNode nodeOnDrop)
		{
			bool result;
			try
			{
				switch (0)
				{
				default:
				{
					int num = 3;
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						global::System.Collections.IEnumerator enumerator2;
						switch (num)
						{
						case 0:
							goto IL_24A;
						case 1:
							goto IL_166;
						case 2:
							goto IL_4E;
						case 4:
							try
							{
								num = 1;
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
										global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)enumerator.Current;
										nodeOnDrop.Nodes.Add((global::custom_controls.CustomTreeNode)customTreeNode.Clone());
										num = 4;
										continue;
									}
									case 2:
										goto IL_FD;
									case 3:
										num = 2;
										continue;
									}
									IL_AA:
									num = 0;
									continue;
									goto IL_AA;
								}
								IL_FD:
								goto IL_71;
							}
							finally
							{
								for (;;)
								{
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_165;
									default:
										if (false)
										{
										}
										num = 1;
										for (;;)
										{
											switch (num)
											{
											case 0:
												goto IL_163;
											case 1:
												if (disposable != null)
												{
													num = 2;
													continue;
												}
												goto IL_165;
											case 2:
												disposable.Dispose();
												num = 0;
												continue;
											}
											break;
										}
										break;
									}
								}
								IL_163:
								IL_165:;
							}
							goto IL_166;
							IL_71:
							nodeOnDrop.ExpandAll();
							num = 2;
							continue;
						case 5:
							try
							{
								num = 2;
								for (;;)
								{
									switch (num)
									{
									case 1:
										num = 3;
										continue;
									case 3:
										goto IL_1EB;
									case 4:
									{
										if (!enumerator2.MoveNext())
										{
											num = 1;
											continue;
										}
										global::custom_controls.CustomTreeNode customTreeNode2 = (global::custom_controls.CustomTreeNode)enumerator2.Current;
										customTreeNode2.Highlighted = false;
										num = 0;
										continue;
									}
									}
									IL_1A6:
									num = 4;
									continue;
									goto IL_1A6;
								}
								IL_1EB:;
							}
							finally
							{
								for (;;)
								{
									global::System.IDisposable disposable2 = enumerator2 as global::System.IDisposable;
									num = 1;
									for (;;)
									{
										switch (num)
										{
										case 0:
											disposable2.Dispose();
											num = 2;
											continue;
										case 1:
											if (disposable2 != null)
											{
												num = 0;
												continue;
											}
											goto IL_235;
										case 2:
											goto IL_233;
										}
										break;
									}
								}
								IL_233:
								IL_235:;
							}
							this.PaintSelectedNodes();
							result = true;
							num = 0;
							continue;
						}
						if (nodesCollection.Count != 0)
						{
							num = 1;
							continue;
						}
						IL_4E:
						if (true)
						{
						}
						enumerator2 = nodeOnDrop.Nodes.GetEnumerator();
						num = 5;
						continue;
						IL_166:
						enumerator = nodesCollection.GetEnumerator();
						num = 4;
					}
					IL_24A:
					break;
				}
				}
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000654D8 File Offset: 0x000636D8
		public global::System.Collections.ArrayList SortNodesCollection(global::System.Collections.ArrayList oldCollection)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
					int count = oldCollection.Count;
					int num = 0;
					int[] array = new int[count];
					int num2 = 8;
					for (;;)
					{
						int num3;
						switch (num2)
						{
						case 0:
							goto IL_16E;
						case 1:
							return oldCollection;
						case 2:
							if (count == 1)
							{
								num2 = 1;
								continue;
							}
							return arrayList;
						case 3:
							goto IL_16E;
						case 4:
							goto IL_9E;
						case 5:
						{
							global::custom_controls.CustomTreeNode customTreeNode;
							arrayList.Add(customTreeNode);
							if (true)
							{
							}
							num2 = 3;
							continue;
						}
						case 6:
							goto IL_C2;
						case 7:
							num2 = 17;
							continue;
						case 8:
							if (count > 1)
							{
								num2 = 19;
								continue;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_23C;
							default:
								if (false)
								{
								}
								num2 = 2;
								continue;
							}
							break;
						case 9:
							goto IL_C2;
						case 10:
						{
							if (num >= count)
							{
								num2 = 7;
								continue;
							}
							global::custom_controls.CustomTreeNode[] array3;
							global::custom_controls.CustomTreeNode[] array2 = array3;
							num3 = 0;
							num2 = 6;
							continue;
						}
						case 11:
							if (num >= count)
							{
								num2 = 15;
								continue;
							}
							array[num] = ((global::custom_controls.CustomTreeNode)oldCollection[num]).Index;
							num++;
							num2 = 16;
							continue;
						case 12:
						{
							global::custom_controls.CustomTreeNode[] array2;
							if (num3 >= array2.Length)
							{
								num2 = 0;
								continue;
							}
							global::custom_controls.CustomTreeNode customTreeNode = array2[num3];
							num2 = 14;
							continue;
						}
						case 13:
							goto IL_9E;
						case 14:
						{
							global::custom_controls.CustomTreeNode customTreeNode;
							if (array[num] == customTreeNode.Index)
							{
								num2 = 5;
								continue;
							}
							goto IL_23C;
						}
						case 15:
							global::System.Array.Sort<int>(array);
							num = 0;
							num2 = 4;
							continue;
						case 16:
							goto IL_EA;
						case 17:
							return arrayList;
						case 18:
							goto IL_EA;
						case 19:
						{
							global::custom_controls.CustomTreeNode[] array3 = new global::custom_controls.CustomTreeNode[count];
							oldCollection.CopyTo(array3, 0);
							num = 0;
							num2 = 18;
							continue;
						}
						}
						break;
						IL_9E:
						num2 = 10;
						continue;
						IL_C2:
						num2 = 12;
						continue;
						IL_EA:
						num2 = 11;
						continue;
						IL_16E:
						num++;
						num2 = 13;
						continue;
						IL_23C:
						num3++;
						num2 = 9;
					}
				}
				return oldCollection;
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00065744 File Offset: 0x00063944
		public void EditCut()
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
			global::custom_controls.CustomTreeView.SendMessage((global::System.IntPtr)this.ag, 768, (global::System.IntPtr)0, 0);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0006579C File Offset: 0x0006399C
		public void EditCopy()
		{
			for (;;)
			{
				if (true)
				{
				}
				global::custom_controls.CustomTreeView.SendMessage((global::System.IntPtr)this.ag, 769, (global::System.IntPtr)0, 0);
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (this.OnEditMessage != null)
						{
							num = 2;
							continue;
						}
						return;
					case 1:
						if (this.SelectedNode != null)
						{
							num = 4;
							continue;
						}
						return;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_70;
						default:
							if (false)
							{
							}
							this.OnEditMessage();
							num = 3;
							continue;
						}
						break;
					case 3:
						return;
					case 4:
						goto IL_70;
					}
					break;
					IL_70:
					num = 0;
				}
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0006585C File Offset: 0x00063A5C
		public void EditPaste()
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
			global::custom_controls.CustomTreeView.SendMessage((global::System.IntPtr)this.ag, 770, (global::System.IntPtr)0, 0);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000658B4 File Offset: 0x00063AB4
		public void EditDelete()
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
			global::custom_controls.CustomTreeView.SendMessage((global::System.IntPtr)this.ag, 771, (global::System.IntPtr)0, 0);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0006590C File Offset: 0x00063B0C
		public void EditUndo()
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
			global::custom_controls.CustomTreeView.SendMessage((global::System.IntPtr)this.ag, 772, (global::System.IntPtr)0, 0);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00065964 File Offset: 0x00063B64
		public bool EditCanPaste()
		{
			if (true)
			{
			}
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_3F;
			}
			if (false)
			{
			}
			if (global::System.Windows.Forms.Clipboard.GetDataObject().GetDataPresent(global::System.Windows.Forms.DataFormats.UnicodeText))
			{
				return true;
			}
			IL_3F:
			return global::System.Windows.Forms.Clipboard.GetDataObject().GetDataPresent(global::System.Windows.Forms.DataFormats.Text);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000659C4 File Offset: 0x00063BC4
		public bool IsSelectedText()
		{
			switch (0)
			{
			default:
			{
				bool result;
				for (;;)
				{
					long num = 0L;
					long num2 = 0L;
					long num3 = 0L;
					result = false;
					int num4 = 1;
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_98;
							default:
								if (false)
								{
								}
								result = true;
								num4 = 4;
								continue;
							}
							break;
						case 1:
							if (this.SelectedNode != null)
							{
								num4 = 7;
								continue;
							}
							goto IL_132;
						case 2:
							if (num != 0L)
							{
								num4 = 3;
								continue;
							}
							goto IL_132;
						case 3:
							num2 = (num & 65535L);
							num3 = (num >> 16 & 65535L);
							num4 = 6;
							continue;
						case 4:
							goto IL_130;
						case 5:
							if (this.SelectedNode.IsEditing)
							{
								num4 = 8;
								continue;
							}
							goto IL_132;
						case 6:
							if (num2 != num3)
							{
								num4 = 0;
								continue;
							}
							goto IL_132;
						case 7:
							num4 = 5;
							continue;
						case 8:
							goto IL_98;
						}
						break;
						IL_98:
						num = (long)global::custom_controls.CustomTreeView.SendMessage((global::System.IntPtr)this.ag, 176, (global::System.IntPtr)0, 0);
						num4 = 2;
					}
				}
				IL_130:
				IL_132:
				if (true)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00065B0C File Offset: 0x00063D0C
		private void a()
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_5B:
				num = 1;
				break;
			default:
				if (false)
				{
				}
				num = 3;
				break;
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_9C;
				case 1:
					num = 8;
					continue;
				case 2:
					if (!this.ae.IsSubclassed)
					{
						num = 0;
						continue;
					}
					return;
				case 4:
					return;
				case 5:
					num = 2;
					continue;
				case 6:
					num = 7;
					continue;
				case 7:
					if (this.ae != null)
					{
						num = 5;
						continue;
					}
					this.ae = new global::custom_controls.RenameEditControlListener(this);
					this.ae.AssignControlHandle(new global::System.IntPtr(this.ag));
					num = 4;
					continue;
				case 8:
					if (this.SelectedNode.IsEditing)
					{
						num = 6;
						continue;
					}
					return;
				}
				break;
			}
			if (this.SelectedNode != null)
			{
				goto IL_5B;
			}
			return;
			IL_9C:
			if (true)
			{
			}
			this.ae.AssignControlHandle(new global::System.IntPtr(this.ag));
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00065C40 File Offset: 0x00063E40
		protected override void WndProc(ref global::System.Windows.Forms.Message m)
		{
			int num = 13;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.DeleInstOnMouseActivate();
					num = 2;
					continue;
				case 1:
					if (true)
					{
					}
					if (m.Msg != 528)
					{
						goto IL_D2;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DD;
					default:
						if (false)
						{
						}
						num = 6;
						continue;
					}
					break;
				case 2:
					goto IL_CD;
				case 3:
					if (this.SelectedNode != null)
					{
						num = 11;
						continue;
					}
					return;
				case 4:
					this.OnEditMessage();
					num = 15;
					continue;
				case 5:
					num = 8;
					continue;
				case 6:
					num = 7;
					continue;
				case 7:
					if (m.WParam == (global::System.IntPtr)516)
					{
						num = 10;
						continue;
					}
					goto IL_D2;
				case 8:
					if (this.DeleInstOnMouseActivate != null)
					{
						num = 0;
						continue;
					}
					goto IL_193;
				case 9:
					num = 1;
					continue;
				case 10:
					goto IL_14F;
				case 11:
					num = 14;
					continue;
				case 12:
					goto IL_DD;
				case 14:
					if (this.SelectedNode.IsEditing)
					{
						num = 9;
						continue;
					}
					return;
				case 15:
					goto IL_16A;
				}
				if (m.Msg == 33)
				{
					num = 5;
					continue;
				}
				base.WndProc(ref m);
				num = 3;
				continue;
				IL_D2:
				num = 12;
				continue;
				IL_DD:
				if (this.OnEditMessage == null)
				{
					return;
				}
				num = 4;
			}
			IL_CD:
			goto IL_193;
			IL_14F:
			this.a();
			return;
			IL_16A:
			return;
			IL_193:
			base.WndProc(ref m);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00065E10 File Offset: 0x00064010
		protected global::custom_controls.CustomTreeNode ScrollTreeNode(int x, int y)
		{
			switch (0)
			{
			default:
			{
				global::custom_controls.CustomTreeNode customTreeNode;
				for (;;)
				{
					customTreeNode = this.CurrentClickedNode;
					global::System.Drawing.Point pt = new global::System.Drawing.Point(x, y);
					pt = base.PointToClient(pt);
					int num = 13;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_263;
						case 1:
							goto IL_122;
						case 2:
							global::custom_controls.CustomTreeView.SendMessage(base.Handle, 276, (global::System.IntPtr)0, 0);
							num = 9;
							continue;
						case 3:
							if (pt.X + 10 > base.ClientSize.Width)
							{
								num = 11;
								continue;
							}
							num = 6;
							continue;
						case 4:
							if (true)
							{
							}
							goto IL_122;
						case 5:
							if (customTreeNode.PrevVisibleNode != null)
							{
								num = 21;
								continue;
							}
							goto IL_248;
						case 6:
							if (pt.X < base.Left + 10)
							{
								num = 2;
								continue;
							}
							goto IL_D7;
						case 7:
						{
							if (customTreeNode == null)
							{
								num = 0;
								continue;
							}
							global::System.Drawing.Rectangle bounds = customTreeNode.Bounds;
							num = 10;
							continue;
						}
						case 8:
							global::custom_controls.CustomTreeView.SendMessage(base.Handle, 277, (global::System.IntPtr)0, 0);
							num = 1;
							continue;
						case 9:
							goto IL_D7;
						case 10:
						{
							global::System.Drawing.Rectangle bounds;
							if (bounds.Contains(pt))
							{
								num = 16;
								continue;
							}
							customTreeNode = (global::custom_controls.CustomTreeNode)customTreeNode.NextVisibleNode;
							num = 14;
							continue;
						}
						case 11:
							global::custom_controls.CustomTreeView.SendMessage(base.Handle, 276, (global::System.IntPtr)1, 0);
							num = 24;
							continue;
						case 12:
							global::custom_controls.CustomTreeView.SendMessage(base.Handle, 277, (global::System.IntPtr)1, 0);
							num = 4;
							continue;
						case 13:
							if (pt.Y + 10 > base.ClientSize.Height)
							{
								num = 12;
								continue;
							}
							num = 23;
							continue;
						case 14:
							goto IL_248;
						case 15:
						{
							global::System.Drawing.Rectangle bounds2;
							if (bounds2.Contains(pt))
							{
								num = 17;
								continue;
							}
							num = 5;
							continue;
						}
						case 16:
							return customTreeNode;
						case 17:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_F5;
							default:
								goto IL_330;
							}
							break;
						case 18:
							goto IL_D7;
						case 19:
						{
							if (customTreeNode == null)
							{
								num = 20;
								continue;
							}
							global::System.Drawing.Rectangle bounds2 = customTreeNode.Bounds;
							num = 15;
							continue;
						}
						case 20:
							goto IL_F5;
						case 21:
							customTreeNode = (global::custom_controls.CustomTreeNode)customTreeNode.PrevVisibleNode;
							num = 18;
							continue;
						case 22:
							goto IL_248;
						case 23:
							if (pt.Y < base.Top + 10)
							{
								num = 8;
								continue;
							}
							goto IL_122;
						case 24:
							goto IL_D7;
						}
						break;
						IL_D7:
						num = 19;
						continue;
						IL_F5:
						num = 22;
						continue;
						IL_122:
						num = 3;
						continue;
						IL_248:
						num = 7;
					}
				}
				return customTreeNode;
				IL_263:
				return null;
				IL_330:
				if (false)
				{
				}
				return customTreeNode;
			}
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00066174 File Offset: 0x00064374
		public static bool IsSibling(global::System.Windows.Forms.TreeNode n0, global::System.Windows.Forms.TreeNode n1)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_D9;
				case 1:
					num = 9;
					continue;
				case 2:
					if (n1.Parent == null)
					{
						num = 1;
						continue;
					}
					goto IL_D9;
				case 4:
					if (n1 != null)
					{
						num = 6;
						continue;
					}
					return true;
				case 5:
					return true;
				case 6:
					num = 2;
					continue;
				case 7:
					num = 4;
					continue;
				case 8:
					num = 11;
					continue;
				case 9:
					if (n0.Parent != null)
					{
						num = 0;
						continue;
					}
					return true;
				case 10:
					if (n1.Parent != null)
					{
						num = 8;
						continue;
					}
					goto IL_104;
				case 11:
					IL_55:
					if (n1.Parent.Nodes.Contains(n0))
					{
						num = 5;
						continue;
					}
					goto IL_104;
				}
				if (n0 != null)
				{
					num = 7;
					continue;
				}
				break;
				IL_104:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_55;
				default:
					goto IL_11A;
				}
				IL_D9:
				if (true)
				{
				}
				num = 10;
			}
			return true;
			IL_11A:
			if (false)
			{
			}
			return false;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000662A4 File Offset: 0x000644A4
		public void PaintSelectedNodes()
		{
			int num = 4;
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				switch (num)
				{
				case 0:
					return;
				case 1:
					num = 2;
					continue;
				case 2:
					if (this.CollectionOfNodes.Count <= 0)
					{
						num = 0;
						continue;
					}
					goto IL_115;
				case 3:
					try
					{
						num = 4;
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = 2;
									continue;
								}
								global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)enumerator.Current;
								customTreeNode.Highlighted = true;
								num = 3;
								continue;
							}
							case 1:
								goto IL_B3;
							case 2:
								num = 1;
								continue;
							}
							IL_74:
							num = 0;
							continue;
							goto IL_74;
						}
						IL_B3:
						return;
					}
					finally
					{
						for (;;)
						{
							global::System.IDisposable disposable = enumerator as global::System.IDisposable;
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									disposable.Dispose();
									num = 2;
									continue;
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
										if (disposable != null)
										{
											num = 0;
											continue;
										}
										goto IL_114;
									}
									break;
								case 2:
									goto IL_112;
								}
								break;
							}
						}
						IL_112:
						IL_114:;
					}
					goto IL_115;
				}
				if (this.CollectionOfNodes != null)
				{
					if (true)
					{
					}
					num = 1;
					continue;
				}
				break;
				IL_115:
				enumerator = this.CollectionOfNodes.GetEnumerator();
				num = 3;
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0006641C File Offset: 0x0006461C
		public void RemovePaintFromNodes()
		{
			int num = 3;
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator;
				switch (num)
				{
				case 0:
					try
					{
						num = 3;
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = 1;
									continue;
								}
								global::custom_controls.CustomTreeNode customTreeNode = (global::custom_controls.CustomTreeNode)enumerator.Current;
								customTreeNode.GrayedSelected = false;
								customTreeNode.Highlighted = false;
								num = 4;
								continue;
							}
							case 1:
								goto IL_82;
							case 2:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_82;
								default:
									goto IL_C6;
								}
								break;
							}
							IL_6A:
							num = 0;
							continue;
							goto IL_6A;
							IL_82:
							num = 2;
						}
						IL_C6:
						if (false)
						{
						}
						return;
					}
					finally
					{
						for (;;)
						{
							global::System.IDisposable disposable = enumerator as global::System.IDisposable;
							num = 0;
							for (;;)
							{
								switch (num)
								{
								case 0:
									if (disposable != null)
									{
										num = 1;
										continue;
									}
									goto IL_111;
								case 1:
									disposable.Dispose();
									num = 2;
									continue;
								case 2:
									goto IL_10F;
								}
								break;
							}
						}
						IL_10F:
						IL_111:;
					}
					goto IL_112;
				case 1:
					return;
				case 2:
					if (this.CollectionOfNodes.Count == 0)
					{
						num = 1;
						continue;
					}
					goto IL_112;
				case 4:
					if (true)
					{
					}
					num = 2;
					continue;
				}
				if (this.CollectionOfNodes != null)
				{
					num = 4;
					continue;
				}
				break;
				IL_112:
				enumerator = this.CollectionOfNodes.GetEnumerator();
				num = 0;
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00066598 File Offset: 0x00064798
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
			this.EditCopy();
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x000665DC File Offset: 0x000647DC
		private void c(object A_0, global::System.EventArgs A_1)
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
			this.EditPaste();
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00066620 File Offset: 0x00064820
		private void b(object A_0, global::System.EventArgs A_1)
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
			this.EditCut();
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00066664 File Offset: 0x00064864
		private void a(object A_0, global::System.EventArgs A_1)
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
			this.EditDelete();
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000666A8 File Offset: 0x000648A8
		public void UpdateRenameMenu()
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_13E;
				case 2:
					goto IL_74;
				case 3:
					goto IL_54;
				case 4:
					if (this.IsSelectedText())
					{
						num = 0;
						continue;
					}
					this.RenameCutMenu.Enabled = false;
					this.RenameCopyMenu.Enabled = false;
					this.RenameDeleteMenu.Enabled = false;
					num = 3;
					continue;
				case 5:
					if (this.EditCanPaste())
					{
						num = 2;
						continue;
					}
					this.RenamePasteMenu.Enabled = false;
					num = 8;
					continue;
				case 6:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13E;
					default:
						if (false)
						{
						}
						if (this.SelectedNode.IsEditing)
						{
							num = 7;
							continue;
						}
						return;
					}
					break;
				case 7:
					num = 4;
					continue;
				case 8:
					return;
				case 9:
					num = 6;
					continue;
				case 10:
					goto IL_54;
				}
				if (this.SelectedNode != null)
				{
					num = 9;
					continue;
				}
				return;
				IL_54:
				if (true)
				{
				}
				num = 5;
				continue;
				IL_13E:
				this.RenameCutMenu.Enabled = true;
				this.RenameCopyMenu.Enabled = true;
				this.RenameDeleteMenu.Enabled = true;
				num = 10;
			}
			IL_74:
			this.RenamePasteMenu.Enabled = true;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00066828 File Offset: 0x00064A28
		public bool SearchNode(string searchValue, bool searchByTag, out global::custom_controls.CustomTreeNode nodeFound)
		{
			global::custom_controls.CustomTreeNode customTreeNode;
			global::custom_controls.CustomTreeNode customTreeNode2;
			for (;;)
			{
				customTreeNode = null;
				nodeFound = null;
				int num = 1;
				for (;;)
				{
					bool flag;
					bool flag2;
					switch (num)
					{
					case 0:
						goto IL_22F;
					case 1:
						if (base.Nodes != null)
						{
							num = 41;
							continue;
						}
						return false;
					case 2:
						num = 13;
						continue;
					case 3:
						num = 24;
						continue;
					case 4:
						goto IL_291;
					case 5:
						customTreeNode2 = (global::custom_controls.CustomTreeNode)customTreeNode2.NextNode;
						num = 35;
						continue;
					case 6:
						if (customTreeNode.Nodes == null)
						{
							goto IL_36C;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A4;
						default:
							if (false)
							{
							}
							num = 10;
							continue;
						}
						break;
					case 7:
						if (!searchByTag)
						{
							num = 26;
							continue;
						}
						num = 16;
						continue;
					case 8:
						if (base.Nodes[0] == null)
						{
							num = 42;
							continue;
						}
						customTreeNode = (global::custom_controls.CustomTreeNode)base.Nodes[0];
						num = 7;
						continue;
					case 9:
						if (customTreeNode2 != null)
						{
							num = 3;
							continue;
						}
						return false;
					case 10:
						num = 32;
						continue;
					case 11:
					{
						global::custom_controls.CustomTreeNode customTreeNode3;
						if (customTreeNode2 != customTreeNode3.LastNode)
						{
							num = 20;
							continue;
						}
						num = 31;
						continue;
					}
					case 12:
						goto IL_419;
					case 13:
					{
						if (customTreeNode.Nodes.Count == 0)
						{
							num = 29;
							continue;
						}
						global::custom_controls.CustomTreeNode customTreeNode3 = customTreeNode;
						customTreeNode2 = (global::custom_controls.CustomTreeNode)customTreeNode.FirstNode;
						num = 38;
						continue;
					}
					case 14:
						flag = (customTreeNode2.Text == searchValue);
						goto IL_409;
					case 15:
						if (!searchByTag)
						{
							num = 34;
							continue;
						}
						num = 21;
						continue;
					case 16:
						flag2 = (customTreeNode.Tag.ToString() == searchValue);
						goto IL_281;
					case 17:
					{
						global::custom_controls.CustomTreeNode customTreeNode3 = customTreeNode2;
						customTreeNode2 = (global::custom_controls.CustomTreeNode)customTreeNode2.FirstNode;
						num = 30;
						continue;
					}
					case 18:
						customTreeNode2 = (global::custom_controls.CustomTreeNode)customTreeNode2.NextNode;
						num = 19;
						continue;
					case 19:
						goto IL_1A4;
					case 20:
						goto IL_1F0;
					case 21:
						flag = (customTreeNode2.Tag.ToString() == searchValue);
						goto IL_409;
					case 22:
					{
						global::custom_controls.CustomTreeNode customTreeNode3;
						if (customTreeNode2 != customTreeNode3.LastNode)
						{
							num = 5;
							continue;
						}
						goto IL_12E;
					}
					case 23:
						return false;
					case 24:
					{
						global::custom_controls.CustomTreeNode customTreeNode3;
						if (customTreeNode2 == customTreeNode3)
						{
							num = 0;
							continue;
						}
						goto IL_16C;
					}
					case 25:
						goto IL_12E;
					case 26:
						num = 43;
						continue;
					case 27:
					{
						global::custom_controls.CustomTreeNode customTreeNode3;
						if (customTreeNode2 != customTreeNode3)
						{
							num = 36;
							continue;
						}
						goto IL_1F0;
					}
					case 28:
						goto IL_12E;
					case 29:
						goto IL_2DA;
					case 30:
						goto IL_16C;
					case 31:
					{
						if (customTreeNode2 == customTreeNode.LastNode)
						{
							num = 23;
							continue;
						}
						global::custom_controls.CustomTreeNode customTreeNode3;
						customTreeNode2 = customTreeNode3;
						customTreeNode3 = (global::custom_controls.CustomTreeNode)customTreeNode3.Parent;
						num = 28;
						continue;
					}
					case 32:
						if (customTreeNode.Nodes[0] != null)
						{
							num = 2;
							continue;
						}
						goto IL_36C;
					case 33:
					{
						global::custom_controls.CustomTreeNode customTreeNode3;
						if (customTreeNode2 != customTreeNode3)
						{
							num = 18;
							continue;
						}
						goto IL_481;
					}
					case 34:
						num = 14;
						continue;
					case 35:
						goto IL_16C;
					case 36:
						num = 11;
						continue;
					case 37:
						if (customTreeNode2.Nodes.Count > 0)
						{
							num = 17;
							continue;
						}
						num = 22;
						continue;
					case 38:
						goto IL_481;
					case 39:
						num = 25;
						continue;
					case 40:
						if (customTreeNode2 == null)
						{
							num = 39;
							continue;
						}
						num = 15;
						continue;
					case 41:
						num = 8;
						continue;
					case 42:
						goto IL_27C;
					case 43:
						flag2 = (customTreeNode.Text == searchValue);
						goto IL_281;
					}
					break;
					IL_409:
					if (flag)
					{
						num = 12;
						continue;
					}
					num = 37;
					continue;
					IL_12E:
					num = 27;
					continue;
					IL_16C:
					num = 40;
					continue;
					IL_281:
					if (flag2)
					{
						num = 4;
						continue;
					}
					num = 6;
					continue;
					IL_1F0:
					num = 33;
					continue;
					IL_481:
					if (true)
					{
					}
					num = 9;
					continue;
					IL_1A4:
					goto IL_481;
				}
			}
			IL_22F:
			return false;
			IL_27C:
			return false;
			IL_291:
			nodeFound = customTreeNode;
			return true;
			IL_2DA:
			IL_36C:
			nodeFound = null;
			return false;
			IL_419:
			nodeFound = customTreeNode2;
			return true;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00066CE0 File Offset: 0x00064EE0
		public bool SearchNode(string searchText, string nodeId, string nodeTag, out global::custom_controls.CustomTreeNode nodeFound)
		{
			global::custom_controls.CustomTreeNode customTreeNode;
			global::custom_controls.CustomTreeNode customTreeNode2;
			for (;;)
			{
				customTreeNode = null;
				nodeFound = null;
				int num = 26;
				for (;;)
				{
					switch (num)
					{
					case 0:
						num = 33;
						continue;
					case 1:
					{
						global::custom_controls.CustomTreeNode customTreeNode3;
						if (customTreeNode2 != customTreeNode3)
						{
							num = 11;
							continue;
						}
						goto IL_225;
					}
					case 2:
						if (customTreeNode2.ID == nodeId)
						{
							num = 45;
							continue;
						}
						goto IL_1CE;
					case 3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13F;
						default:
							if (false)
							{
							}
							num = 2;
							continue;
						}
						break;
					case 4:
						num = 21;
						continue;
					case 5:
						goto IL_15A;
					case 6:
						goto IL_4BB;
					case 7:
						if (customTreeNode.Text == searchText)
						{
							num = 38;
							continue;
						}
						goto IL_134;
					case 8:
						goto IL_225;
					case 9:
					{
						if (customTreeNode2 == customTreeNode.LastNode)
						{
							num = 29;
							continue;
						}
						global::custom_controls.CustomTreeNode customTreeNode3;
						customTreeNode2 = customTreeNode3;
						customTreeNode3 = (global::custom_controls.CustomTreeNode)customTreeNode3.Parent;
						num = 5;
						continue;
					}
					case 10:
						goto IL_2C6;
					case 11:
						num = 42;
						continue;
					case 12:
						if (customTreeNode.Tag.ToString() == nodeTag)
						{
							num = 24;
							continue;
						}
						goto IL_134;
					case 13:
					{
						if (customTreeNode.Nodes[0] == null)
						{
							num = 30;
							continue;
						}
						global::custom_controls.CustomTreeNode customTreeNode3 = customTreeNode;
						customTreeNode2 = (global::custom_controls.CustomTreeNode)customTreeNode.FirstNode;
						num = 6;
						continue;
					}
					case 14:
						num = 12;
						continue;
					case 15:
						customTreeNode2 = (global::custom_controls.CustomTreeNode)customTreeNode2.NextNode;
						num = 19;
						continue;
					case 16:
						if (customTreeNode2 != null)
						{
							num = 0;
							continue;
						}
						return false;
					case 17:
						goto IL_473;
					case 18:
						num = 13;
						continue;
					case 19:
						goto IL_4BB;
					case 20:
					{
						global::custom_controls.CustomTreeNode customTreeNode3;
						if (customTreeNode2 != customTreeNode3)
						{
							num = 15;
							continue;
						}
						goto IL_4BB;
					}
					case 21:
						if (customTreeNode.Nodes.Count != 0)
						{
							num = 18;
							continue;
						}
						goto IL_2FF;
					case 22:
						if (customTreeNode.ID == nodeId)
						{
							num = 14;
							continue;
						}
						goto IL_134;
					case 23:
						num = 28;
						continue;
					case 24:
						goto IL_2FD;
					case 25:
						if (customTreeNode2 == null)
						{
							num = 23;
							continue;
						}
						num = 34;
						continue;
					case 26:
						if (base.Nodes != null)
						{
							num = 36;
							continue;
						}
						return false;
					case 27:
						goto IL_473;
					case 28:
						goto IL_15A;
					case 29:
						return false;
					case 30:
						goto IL_3E4;
					case 31:
						goto IL_13F;
					case 32:
						goto IL_39F;
					case 33:
					{
						global::custom_controls.CustomTreeNode customTreeNode3;
						if (customTreeNode2 == customTreeNode3)
						{
							num = 35;
							continue;
						}
						goto IL_473;
					}
					case 34:
						if (customTreeNode2.Text == searchText)
						{
							num = 3;
							continue;
						}
						goto IL_1CE;
					case 35:
						goto IL_264;
					case 36:
						num = 40;
						continue;
					case 37:
					{
						global::custom_controls.CustomTreeNode customTreeNode3;
						if (customTreeNode2 != customTreeNode3.LastNode)
						{
							num = 41;
							continue;
						}
						goto IL_15A;
					}
					case 38:
						num = 22;
						continue;
					case 39:
					{
						global::custom_controls.CustomTreeNode customTreeNode3 = customTreeNode2;
						customTreeNode2 = (global::custom_controls.CustomTreeNode)customTreeNode2.FirstNode;
						num = 17;
						continue;
					}
					case 40:
						if (base.Nodes[0] == null)
						{
							num = 10;
							continue;
						}
						if (true)
						{
						}
						customTreeNode = (global::custom_controls.CustomTreeNode)base.Nodes[0];
						num = 7;
						continue;
					case 41:
						customTreeNode2 = (global::custom_controls.CustomTreeNode)customTreeNode2.NextNode;
						num = 27;
						continue;
					case 42:
					{
						global::custom_controls.CustomTreeNode customTreeNode3;
						if (customTreeNode2 != customTreeNode3.LastNode)
						{
							num = 8;
							continue;
						}
						num = 9;
						continue;
					}
					case 43:
						if (customTreeNode2.Tag.ToString() == nodeTag)
						{
							num = 32;
							continue;
						}
						goto IL_1CE;
					case 44:
						if (customTreeNode2.Nodes.Count > 0)
						{
							num = 39;
							continue;
						}
						num = 37;
						continue;
					case 45:
						num = 43;
						continue;
					}
					break;
					IL_134:
					num = 31;
					continue;
					IL_13F:
					if (customTreeNode.Nodes != null)
					{
						num = 4;
						continue;
					}
					goto IL_2FF;
					IL_15A:
					num = 1;
					continue;
					IL_1CE:
					num = 44;
					continue;
					IL_225:
					num = 20;
					continue;
					IL_473:
					num = 25;
					continue;
					IL_4BB:
					num = 16;
				}
			}
			return false;
			IL_264:
			return false;
			IL_2C6:
			return false;
			IL_2FD:
			nodeFound = customTreeNode;
			return true;
			IL_2FF:
			nodeFound = null;
			return false;
			IL_39F:
			nodeFound = customTreeNode2;
			return true;
			IL_3E4:
			goto IL_2FF;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000671C8 File Offset: 0x000653C8
		public bool SelectTreeNode(global::custom_controls.CustomTreeNode destNode, ref bool alreadySelected)
		{
			bool result;
			try
			{
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_91;
						default:
							if (false)
							{
							}
							if (this.SelectedNodes.Contains(destNode))
							{
								num = 2;
								continue;
							}
							goto IL_91;
						}
						break;
					case 1:
						num = 0;
						continue;
					case 2:
						alreadySelected = true;
						result = true;
						num = 4;
						continue;
					case 4:
						goto IL_4D;
					case 5:
						goto IL_E3;
					}
					if (this.SelectedNodes.Count == 1)
					{
						num = 1;
						continue;
					}
					IL_91:
					alreadySelected = false;
					this.RemovePaintFromNodes();
					this.SelectedNodes.Clear();
					this.CurrentClickedNode = destNode;
					this.SelectedNodes.Add(destNode);
					this.LastSelectedNode = destNode;
					this.FirstSelectedNode = destNode;
					this.NodeChanged = true;
					this.PaintSelectedNodes();
					result = true;
					num = 5;
				}
				IL_4D:
				IL_E3:;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			if (true)
			{
			}
			return result;
		}

		// Token: 0x040004FD RID: 1277
		private const int a = 5;

		// Token: 0x040004FE RID: 1278
		private const int b = -1;

		// Token: 0x040004FF RID: 1279
		private const int c = 4194304;

		// Token: 0x04000500 RID: 1280
		private const int d = 4352;

		// Token: 0x04000501 RID: 1281
		private const int e = 1024;

		// Token: 0x04000502 RID: 1282
		private const int f = 768;

		// Token: 0x04000503 RID: 1283
		private const int g = 769;

		// Token: 0x04000504 RID: 1284
		private const int h = 770;

		// Token: 0x04000505 RID: 1285
		private const int i = 771;

		// Token: 0x04000506 RID: 1286
		private const int j = 772;

		// Token: 0x04000507 RID: 1287
		private const int k = 176;

		// Token: 0x04000508 RID: 1288
		private const int l = 277;

		// Token: 0x04000509 RID: 1289
		private const int m = 33;

		// Token: 0x0400050A RID: 1290
		private global::custom_controls.CustomTreeNode n;

		// Token: 0x0400050B RID: 1291
		private global::System.Collections.ArrayList o;

		// Token: 0x0400050C RID: 1292
		private global::System.Collections.ArrayList p;

		// Token: 0x0400050D RID: 1293
		private global::System.Collections.ArrayList q;

		// Token: 0x0400050E RID: 1294
		private global::System.Collections.ArrayList r;

		// Token: 0x0400050F RID: 1295
		private global::System.Collections.ArrayList s;

		// Token: 0x04000510 RID: 1296
		private string t;

		// Token: 0x04000511 RID: 1297
		private bool u;

		// Token: 0x04000512 RID: 1298
		private bool v;

		// Token: 0x04000513 RID: 1299
		private global::custom_controls.CustomTreeNode w;

		// Token: 0x04000514 RID: 1300
		private global::custom_controls.CustomTreeNode x;

		// Token: 0x04000515 RID: 1301
		private global::System.Windows.Forms.Cursor y;

		// Token: 0x04000516 RID: 1302
		private global::custom_controls.CustomTreeNode z;

		// Token: 0x04000517 RID: 1303
		private global::System.ComponentModel.Container aa;

		// Token: 0x04000518 RID: 1304
		private bool ab;

		// Token: 0x04000519 RID: 1305
		private bool ac;

		// Token: 0x0400051A RID: 1306
		private bool ad = true;

		// Token: 0x0400051B RID: 1307
		public global::custom_controls.CustomTreeView.EditMessageDelegate OnEditMessage;

		// Token: 0x0400051C RID: 1308
		public global::custom_controls.CustomTreeView.MenuDrawDelegate OnDrawMenu;

		// Token: 0x0400051D RID: 1309
		public global::custom_controls.CustomTreeView.MenuMeasureDelegate OnMeasureMenu;

		// Token: 0x0400051E RID: 1310
		private global::custom_controls.RenameEditControlListener ae;

		// Token: 0x0400051F RID: 1311
		private int af = 4367;

		// Token: 0x04000520 RID: 1312
		private long ag;

		// Token: 0x04000521 RID: 1313
		private global::custom_controls.CustomTreeView.DeleOnMouseActivate ah;

		// Token: 0x04000522 RID: 1314
		private global::custom_controls.CMenuItem ai;

		// Token: 0x04000523 RID: 1315
		private global::custom_controls.CMenuItem aj;

		// Token: 0x04000524 RID: 1316
		private global::custom_controls.CMenuItem ak;

		// Token: 0x04000525 RID: 1317
		private global::custom_controls.CMenuItem al;

		// Token: 0x04000526 RID: 1318
		private global::custom_controls.CMenuItem am;

		// Token: 0x04000527 RID: 1319
		private global::custom_controls.CustomTreeView.OperateEventHandler an;

		// Token: 0x04000528 RID: 1320
		private global::custom_controls.CustomTreeView.OperateEventHandler ao;

		// Token: 0x04000529 RID: 1321
		private global::custom_controls.CustomTreeView.OperateEventHandler ap;

		// Token: 0x0400052A RID: 1322
		private global::custom_controls.CustomTreeView.OperateEventHandler aq;

		// Token: 0x0400052B RID: 1323
		private global::custom_controls.CustomTreeView.OperateEventHandler ar;

		// Token: 0x0400052C RID: 1324
		private global::custom_controls.CustomTreeView.OperateEventHandler @as;

		// Token: 0x0400052D RID: 1325
		private global::custom_controls.CustomTreeView.OperateEventHandler at;

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x06000718 RID: 1816
		public delegate void EditMessageDelegate();

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x0600071C RID: 1820
		public delegate void MenuDrawDelegate(object sender, global::System.Windows.Forms.DrawItemEventArgs e);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x06000720 RID: 1824
		public delegate void MenuMeasureDelegate(object sender, global::System.Windows.Forms.MeasureItemEventArgs e);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x06000724 RID: 1828
		public delegate void DeleOnMouseActivate();

		// Token: 0x020000A4 RID: 164
		public class OperateEventArgs : global::System.EventArgs
		{
			// Token: 0x1700016C RID: 364
			// (get) Token: 0x06000727 RID: 1831 RVA: 0x000672E4 File Offset: 0x000654E4
			public global::System.Collections.ArrayList SelectedNodes
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
			}

			// Token: 0x06000728 RID: 1832 RVA: 0x00067328 File Offset: 0x00065528
			public OperateEventArgs(global::System.Collections.ArrayList selectedNodes)
			{
				this.a = selectedNodes;
			}

			// Token: 0x0400052E RID: 1326
			private global::System.Collections.ArrayList a;
		}

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x0600072A RID: 1834
		public delegate void OperateEventHandler(object sender, global::custom_controls.CustomTreeView.OperateEventArgs e);

		// Token: 0x020000A6 RID: 166
		public class CompareType : global::System.Collections.IComparer
		{
			// Token: 0x0600072D RID: 1837 RVA: 0x00067344 File Offset: 0x00065544
			int global::System.Collections.IComparer.Compare(object x, object y)
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
				return this.Compare(x, y);
			}

			// Token: 0x0600072E RID: 1838 RVA: 0x00067388 File Offset: 0x00065588
			protected int Compare(object x, object y)
			{
				int result;
				try
				{
					for (;;)
					{
						IL_34:
						int num = string.Compare((x as global::custom_controls.CustomTreeNode).Tag.ToString(), (y as global::custom_controls.CustomTreeNode).Tag.ToString(), global::System.StringComparison.Ordinal);
						int num2 = 0;
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
								switch (num2)
								{
								case 0:
									if (num == 0)
									{
										num2 = 2;
										continue;
									}
									goto IL_9A;
								case 1:
									goto IL_A7;
								case 2:
									num = string.Compare(x.ToString(), y.ToString(), global::System.StringComparison.Ordinal);
									num2 = 3;
									continue;
								case 3:
									if (true)
									{
									}
									goto IL_9A;
								}
								goto IL_34;
								IL_9A:
								result = num;
								break;
							}
							num2 = 1;
						}
					}
					IL_A7:;
				}
				catch (global::System.Exception)
				{
					throw;
				}
				return result;
			}
		}

		// Token: 0x020000A7 RID: 167
		public class CompareName : global::System.Collections.IComparer
		{
			// Token: 0x06000730 RID: 1840 RVA: 0x00067470 File Offset: 0x00065670
			int global::System.Collections.IComparer.Compare(object x, object y)
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
				return this.Compare(x, y);
			}

			// Token: 0x06000731 RID: 1841 RVA: 0x000674B4 File Offset: 0x000656B4
			protected int Compare(object x, object y)
			{
				int num2;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_57:
					int num = 2;
					for (;;)
					{
						if (true)
						{
						}
						switch (num)
						{
						case 0:
							return num2;
						case 1:
							num2 = -1;
							num = 0;
							continue;
						case 2:
							if (num2 == 0)
							{
								num = 1;
								continue;
							}
							return num2;
						}
						goto IL_42;
					}
					return num2;
				}
				default:
					if (false)
					{
					}
					break;
				}
				IL_42:
				num2 = 0;
				num2 = string.Compare(x.ToString(), y.ToString(), global::System.StringComparison.OrdinalIgnoreCase);
				goto IL_57;
			}
		}
	}
}
