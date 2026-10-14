using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x0200009D RID: 157
	[global::System.Serializable]
	public class CustomTreeNode : global::System.Windows.Forms.TreeNode
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0005F7B0 File Offset: 0x0005D9B0
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x0005F7F4 File Offset: 0x0005D9F4
		public string Type
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
				return this.type;
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
				this.type = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x0005F838 File Offset: 0x0005DA38
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x0005F87C File Offset: 0x0005DA7C
		public string ID
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
				return this.id;
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
				this.id = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0005F8C0 File Offset: 0x0005DAC0
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x0005F904 File Offset: 0x0005DB04
		public int Position
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
				return this.position;
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
				this.position = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0005F948 File Offset: 0x0005DB48
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x0005F98C File Offset: 0x0005DB8C
		public string SortType
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
				return this.sortType;
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
				this.sortType = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0005F9D0 File Offset: 0x0005DBD0
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x0005FA14 File Offset: 0x0005DC14
		public bool IsInvisibleZone
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
				return this.isInvisibleZone;
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
				this.isInvisibleZone = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0005FA58 File Offset: 0x0005DC58
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x0005FA9C File Offset: 0x0005DC9C
		public bool IsCBZone
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
				return this.isCBZone;
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
				this.isCBZone = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0005FAE0 File Offset: 0x0005DCE0
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x0005FB24 File Offset: 0x0005DD24
		public bool Highlighted
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
				return this.highlighted;
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
							return;
						default:
							if (false)
							{
							}
							this.a("BackColor", global::System.Drawing.SystemColors.Highlight);
							this.a("ForeColor", global::System.Drawing.SystemColors.HighlightText);
							this.grayedSelected = !value;
							num = 6;
							continue;
						}
						break;
					case 2:
						if (value)
						{
							num = 0;
							continue;
						}
						if (true)
						{
						}
						this.a("BackColor", base.TreeView.BackColor);
						this.a("ForeColor", base.TreeView.ForeColor);
						num = 4;
						continue;
					case 3:
						num = 2;
						continue;
					case 4:
						goto IL_F1;
					case 5:
						return;
					case 6:
						goto IL_F1;
					}
					if (this.highlighted != value)
					{
						num = 3;
						continue;
					}
					break;
					IL_F1:
					base.TreeView.Invalidate(base.Bounds);
					this.highlighted = value;
					num = 5;
				}
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0005FC54 File Offset: 0x0005DE54
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x0005FC98 File Offset: 0x0005DE98
		public bool GrayedSelected
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
				return this.grayedSelected;
			}
			set
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						num = 2;
						continue;
					case 1:
						if (true)
						{
						}
						break;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							if (false)
							{
							}
							if (value)
							{
								num = 4;
								continue;
							}
							this.a("BackColor", base.TreeView.BackColor);
							this.a("ForeColor", base.TreeView.ForeColor);
							num = 6;
							continue;
						}
						break;
					case 3:
						goto IL_101;
					case 4:
						this.a("BackColor", global::System.Drawing.Color.Silver);
						this.a("ForeColor", base.TreeView.ForeColor);
						this.highlighted = !value;
						num = 3;
						continue;
					case 5:
						return;
					case 6:
						goto IL_101;
					}
					if (this.grayedSelected != value)
					{
						num = 0;
						continue;
					}
					break;
					IL_101:
					base.TreeView.Invalidate(base.Bounds);
					this.grayedSelected = value;
					num = 5;
				}
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0005FDCC File Offset: 0x0005DFCC
		public CustomTreeNode()
		{
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0005FDF4 File Offset: 0x0005DFF4
		protected CustomTreeNode(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0005FE1C File Offset: 0x0005E01C
		private void a(string A_0, global::System.Drawing.Color A_1)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Reflection.FieldInfo field = base.GetType().GetField("propBag", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
					int num = 4;
					for (;;)
					{
						global::System.Windows.Forms.OwnerDrawPropertyBag ownerDrawPropertyBag;
						global::System.Reflection.PropertyInfo property;
						switch (num)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_126;
							default:
								if (false)
								{
								}
								goto IL_72;
							}
							break;
						case 1:
							goto IL_132;
						case 2:
							ownerDrawPropertyBag = (global::System.Windows.Forms.OwnerDrawPropertyBag)field.GetValue(this);
							num = 7;
							continue;
						case 3:
						{
							global::System.Reflection.ConstructorInfo constructor;
							if (constructor != null)
							{
								num = 9;
								continue;
							}
							goto IL_72;
						}
						case 4:
							if (field != null)
							{
								num = 2;
								continue;
							}
							return;
						case 5:
							property.SetValue(ownerDrawPropertyBag, A_1, null);
							field.SetValue(this, ownerDrawPropertyBag);
							goto IL_126;
						case 6:
						{
							global::System.Reflection.ConstructorInfo constructor = typeof(global::System.Windows.Forms.OwnerDrawPropertyBag).GetConstructor(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic, null, new global::System.Type[0], null);
							num = 3;
							continue;
						}
						case 7:
							if (ownerDrawPropertyBag == null)
							{
								num = 6;
								continue;
							}
							goto IL_72;
						case 8:
							if (property != null)
							{
								num = 5;
								continue;
							}
							return;
						case 9:
						{
							global::System.Reflection.ConstructorInfo constructor;
							ownerDrawPropertyBag = (global::System.Windows.Forms.OwnerDrawPropertyBag)constructor.Invoke(null);
							num = 0;
							continue;
						}
						}
						break;
						IL_72:
						property = ownerDrawPropertyBag.GetType().GetProperty(A_0);
						num = 8;
						continue;
						IL_126:
						num = 1;
					}
				}
				IL_132:
				if (true)
				{
				}
				return;
			}
		}

		// Token: 0x040004EE RID: 1262
		private string type;

		// Token: 0x040004EF RID: 1263
		private string id;

		// Token: 0x040004F0 RID: 1264
		private int position = -1;

		// Token: 0x040004F1 RID: 1265
		private string sortType = "";

		// Token: 0x040004F2 RID: 1266
		private bool isInvisibleZone;

		// Token: 0x040004F3 RID: 1267
		private bool isCBZone;

		// Token: 0x040004F4 RID: 1268
		private bool highlighted;

		// Token: 0x040004F5 RID: 1269
		private bool grayedSelected;
	}
}
