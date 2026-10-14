using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using custom_exception;

namespace custom_controls
{
	// Token: 0x02000066 RID: 102
	public class CCommandMgmt : global::System.ComponentModel.Component, global::System.ComponentModel.IExtenderProvider
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00044898 File Offset: 0x00042A98
		public global::System.Collections.Hashtable Dictionary
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

		// Token: 0x0600043C RID: 1084 RVA: 0x000448DC File Offset: 0x00042ADC
		public CCommandMgmt()
		{
			this.a = new global::System.Collections.Hashtable();
			if (this.a == null)
			{
				global::custom_exception.CCustomException ex = new global::custom_exception.CCustomException(global::System.Convert.ToUInt32(global::custom_exception.CCustomException.HRESULT.FAIL_TO_CREATE_INS), "CCommandMgmt", base.GetType().ToString(), global::System.Environment.StackTrace.ToString());
				throw ex;
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00044938 File Offset: 0x00042B38
		public void MapToolbarClickEvent(global::System.ComponentModel.Component component, global::custom_controls.CMenuStripItem menuItem)
		{
			int num = 4;
			global::System.Windows.Forms.ToolStripButton toolStripButton;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_C9;
				case 1:
					if (true)
					{
					}
					goto IL_80;
				case 2:
					goto IL_59;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					default:
						if (false)
						{
						}
						if (toolStripButton != null)
						{
							num = 0;
							continue;
						}
						return;
					}
					break;
				}
				if (!this.a.Contains(component))
				{
					num = 1;
					continue;
				}
				this.a[component] = menuItem;
				num = 2;
				continue;
				IL_80:
				this.a.Add(component, menuItem);
				toolStripButton = (component as global::System.Windows.Forms.ToolStripButton);
				num = 3;
			}
			IL_59:
			return;
			IL_C9:
			toolStripButton.Click -= this.a;
			toolStripButton.Click += this.a;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00044A1C File Offset: 0x00042C1C
		public bool CanExtend(object component)
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
			return component is global::System.Windows.Forms.ToolBarButton;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00044A60 File Offset: 0x00042C60
		private void a(object A_0, global::System.EventArgs A_1)
		{
			try
			{
				for (;;)
				{
					global::System.Windows.Forms.ToolStripButton key = (global::System.Windows.Forms.ToolStripButton)A_0;
					int num = 0;
					for (;;)
					{
						global::custom_controls.CMenuStripItem cmenuStripItem;
						switch (num)
						{
						case 0:
							if (this.a.Contains(key))
							{
								num = 2;
								continue;
							}
							goto IL_9A;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_6E;
							default:
								if (false)
								{
								}
								goto IL_9A;
							}
							break;
						case 2:
							cmenuStripItem = (global::custom_controls.CMenuStripItem)this.a[key];
							num = 5;
							continue;
						case 3:
							goto IL_6E;
						case 4:
							goto IL_A5;
						case 5:
							if (cmenuStripItem != null)
							{
								num = 3;
								continue;
							}
							goto IL_9A;
						}
						break;
						IL_6E:
						cmenuStripItem.PerformClick();
						num = 1;
						continue;
						IL_9A:
						num = 4;
					}
				}
				IL_A5:;
			}
			catch (global::custom_exception.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::custom_exception.CCustomException.Rethrow(ex);
			}
			if (true)
			{
			}
		}

		// Token: 0x040002DB RID: 731
		private global::System.Collections.Hashtable a;
	}
}
