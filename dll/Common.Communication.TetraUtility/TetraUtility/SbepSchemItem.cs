using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000020 RID: 32
	internal class SbepSchemItem
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00009260 File Offset: 0x00007460
		public SbepSchemItem(string name, string[] items)
		{
			this.Name = name;
			this.Items = items;
			this.Init();
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00009287 File Offset: 0x00007487
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000928F File Offset: 0x0000748F
		public string Name { get; private set; }

		// Token: 0x06000102 RID: 258 RVA: 0x00009298 File Offset: 0x00007498
		public bool IsMatch(byte[] buffer)
		{
			if (this.schemaSectionList.Count == 0)
			{
				return false;
			}
			global::Motorola.Common.Communication.TetraUtility.SbepSchemItem.SchemaSection schemaSection = this.schemaSectionList[this.schemaSectionList.Count - 1];
			if (buffer.Length < schemaSection.Offset + schemaSection.Len)
			{
				return false;
			}
			foreach (global::Motorola.Common.Communication.TetraUtility.SbepSchemItem.SchemaSection schemaSection2 in this.schemaSectionList)
			{
				if (schemaSection2.Data != null)
				{
					for (int i = 0; i < schemaSection2.Len; i++)
					{
						if (schemaSection2.Data[i] != buffer[schemaSection2.Offset + i])
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00009358 File Offset: 0x00007558
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00009360 File Offset: 0x00007560
		private string[] Items { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000936C File Offset: 0x0000756C
		public int Rank
		{
			get
			{
				int num = 0;
				foreach (global::Motorola.Common.Communication.TetraUtility.SbepSchemItem.SchemaSection schemaSection in this.schemaSectionList)
				{
					if (schemaSection.Data != null)
					{
						num += schemaSection.Len;
					}
				}
				return num;
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000093CC File Offset: 0x000075CC
		private void Init()
		{
			if (this.Items == null)
			{
				return;
			}
			int num = 0;
			foreach (string text in this.Items)
			{
				if (!string.IsNullOrEmpty(text))
				{
					global::Motorola.Common.Communication.TetraUtility.SbepSchemItem.SchemaSection schemaSection = new global::Motorola.Common.Communication.TetraUtility.SbepSchemItem.SchemaSection
					{
						Offset = num
					};
					string[] array = text.Split(new char[]
					{
						':'
					}, global::System.StringSplitOptions.RemoveEmptyEntries);
					if (array.Length < 2)
					{
						break;
					}
					schemaSection.Desc = array[0].Trim();
					string input = array[1].Trim();
					global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(input, "\\(\\s*(?<data>\\d+)\\s*\\)");
					if (match.Success)
					{
						schemaSection.Len = global::System.Convert.ToInt32(match.Groups["data"].Value);
						num += schemaSection.Len;
						this.schemaSectionList.Add(schemaSection);
					}
					else
					{
						global::System.Text.RegularExpressions.MatchCollection matchCollection = global::System.Text.RegularExpressions.Regex.Matches(input, "[\\d|(a-f)]{2}", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
						schemaSection.Len = matchCollection.Count;
						schemaSection.Data = new byte[matchCollection.Count];
						for (int j = 0; j < matchCollection.Count; j++)
						{
							schemaSection.Data[j] = global::System.Convert.ToByte(matchCollection[j].Value, 16);
						}
						num += schemaSection.Len;
						this.schemaSectionList.Add(schemaSection);
					}
				}
			}
		}

		// Token: 0x04000073 RID: 115
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.SbepSchemItem.SchemaSection> schemaSectionList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.SbepSchemItem.SchemaSection>();

		// Token: 0x02000021 RID: 33
		private class SchemaSection
		{
			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000107 RID: 263 RVA: 0x00009529 File Offset: 0x00007729
			// (set) Token: 0x06000108 RID: 264 RVA: 0x00009531 File Offset: 0x00007731
			public string Desc { get; set; }

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000109 RID: 265 RVA: 0x0000953A File Offset: 0x0000773A
			// (set) Token: 0x0600010A RID: 266 RVA: 0x00009542 File Offset: 0x00007742
			public int Offset { get; set; }

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x0600010B RID: 267 RVA: 0x0000954B File Offset: 0x0000774B
			// (set) Token: 0x0600010C RID: 268 RVA: 0x00009553 File Offset: 0x00007753
			public int Len { get; set; }

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600010D RID: 269 RVA: 0x0000955C File Offset: 0x0000775C
			// (set) Token: 0x0600010E RID: 270 RVA: 0x00009564 File Offset: 0x00007764
			public byte[] Data { get; set; }
		}
	}
}
