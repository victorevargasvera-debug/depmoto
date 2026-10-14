using System;
using System.Windows.Forms.Design;

namespace custom_controls
{
	// Token: 0x0200005F RID: 95
	public class IPAddressControlDesigner : global::System.Windows.Forms.Design.ControlDesigner
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x000437E4 File Offset: 0x000419E4
		public override global::System.Windows.Forms.Design.SelectionRules SelectionRules
		{
			get
			{
				global::custom_controls.CIPAddressControl cipaddressControl = (global::custom_controls.CIPAddressControl)this.Control;
				if (!cipaddressControl.AutoSize)
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
						return global::System.Windows.Forms.Design.SelectionRules.Moveable | global::System.Windows.Forms.Design.SelectionRules.Visible | global::System.Windows.Forms.Design.SelectionRules.TopSizeable | global::System.Windows.Forms.Design.SelectionRules.BottomSizeable | global::System.Windows.Forms.Design.SelectionRules.LeftSizeable | global::System.Windows.Forms.Design.SelectionRules.RightSizeable;
					}
				}
				if (true)
				{
				}
				return global::System.Windows.Forms.Design.SelectionRules.Moveable | global::System.Windows.Forms.Design.SelectionRules.Visible | global::System.Windows.Forms.Design.SelectionRules.LeftSizeable | global::System.Windows.Forms.Design.SelectionRules.RightSizeable;
			}
		}
	}
}
