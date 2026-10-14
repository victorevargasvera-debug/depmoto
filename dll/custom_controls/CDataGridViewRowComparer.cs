using System;
using System.Collections;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000032 RID: 50
	public class CDataGridViewRowComparer : global::System.Collections.IComparer
	{
		// Token: 0x0600020F RID: 527 RVA: 0x0002838C File Offset: 0x0002658C
		public CDataGridViewRowComparer(global::System.Windows.Forms.SortOrder sortOrder)
		{
			if (sortOrder == global::System.Windows.Forms.SortOrder.Descending)
			{
				global::custom_controls.CDataGridViewRowComparer.a = -1;
				return;
			}
			if (sortOrder == global::System.Windows.Forms.SortOrder.Ascending)
			{
				global::custom_controls.CDataGridViewRowComparer.a = 1;
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000283BC File Offset: 0x000265BC
		public int Compare(object x, object y)
		{
			int num;
			for (;;)
			{
				num = -1;
				try
				{
					global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow = (global::custom_controls.CCustomDataGridViewRow)x;
					global::custom_controls.CCustomDataGridViewRow ccustomDataGridViewRow2 = (global::custom_controls.CCustomDataGridViewRow)y;
					num = string.Compare(ccustomDataGridViewRow.HeaderCell.Tag.ToString(), ccustomDataGridViewRow2.HeaderCell.Tag.ToString());
				}
				catch (global::System.Exception)
				{
				}
				if (true)
				{
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_65;
				}
			}
			IL_65:
			if (false)
			{
			}
			return num * global::custom_controls.CDataGridViewRowComparer.a;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0002844C File Offset: 0x0002664C
		// Note: this type is marked as 'beforefieldinit'.
		static CDataGridViewRowComparer()
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
			global::custom_controls.CDataGridViewRowComparer.a = 1;
		}

		// Token: 0x04000158 RID: 344
		private static int a;
	}
}
