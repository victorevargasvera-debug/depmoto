using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000092 RID: 146
	[global::System.Serializable]
	public class CListViewItem : global::System.Windows.Forms.ListViewItem
	{
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0005A9C8 File Offset: 0x00058BC8
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x0005AA0C File Offset: 0x00058C0C
		public string TreeNodeTag
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
				return this.nodeTag;
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
				this.nodeTag = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0005AA50 File Offset: 0x00058C50
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x0005AA94 File Offset: 0x00058C94
		public string ControlId
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

		// Token: 0x06000601 RID: 1537 RVA: 0x0005AAD8 File Offset: 0x00058CD8
		public CListViewItem()
		{
			this.nodeTag = string.Empty;
			this.id = string.Empty;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0005AB04 File Offset: 0x00058D04
		protected CListViewItem(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x040004A2 RID: 1186
		private string nodeTag;

		// Token: 0x040004A3 RID: 1187
		private string id;
	}
}
