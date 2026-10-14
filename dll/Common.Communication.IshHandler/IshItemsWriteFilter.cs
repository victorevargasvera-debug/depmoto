using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x0200000A RID: 10
	public class IshItemsWriteFilter
	{
		// Token: 0x06000097 RID: 151 RVA: 0x0000435C File Offset: 0x0000255C
		public IshItemsWriteFilter(global::System.Collections.Generic.IList<byte> writePartitions, global::System.Collections.Generic.IList<ushort> programmableTypes)
		{
			this.writePartitions = new global::System.Collections.Generic.List<ushort>();
			foreach (byte item in writePartitions)
			{
				this.writePartitions.Add((ushort)item);
			}
			this.programmableTypes = ((programmableTypes == null) ? null : new global::System.Collections.Generic.HashSet<ushort>(programmableTypes));
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000043CC File Offset: 0x000025CC
		public IshItemsWriteFilter(global::System.Collections.Generic.IList<ushort> writePartitions, global::System.Collections.Generic.IList<ushort> interestTypes)
		{
			this.writePartitions = writePartitions;
			this.programmableTypes = ((interestTypes == null) ? null : new global::System.Collections.Generic.HashSet<ushort>(interestTypes));
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000043F0 File Offset: 0x000025F0
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection GetCollectionToWrite(global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = pbaObject.GetCodeplugInIshItemCollection();
			return this.GetCollectionToWrite(codeplugInIshItemCollection);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000440C File Offset: 0x0000260C
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection GetCollectionToWrite(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItems)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in ishItems)
			{
				if (this.CanIshItemWrite(keyValuePair.Key))
				{
					ishItemCollection.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			return ishItemCollection;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004478 File Offset: 0x00002678
		protected bool CanIshItemWrite(global::Motorola.Common.Communication.CommonUtil.IshHeader header)
		{
			return this.writePartitions.Contains((ushort)header.PartitionNumber) && this.IsProgrammableTypes(header.IshType);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000044A2 File Offset: 0x000026A2
		private bool IsProgrammableTypes(ushort ishType)
		{
			return this.programmableTypes == null || this.programmableTypes.Count <= 0 || this.programmableTypes.Contains(ishType);
		}

		// Token: 0x0400000C RID: 12
		private global::System.Collections.Generic.IList<ushort> writePartitions;

		// Token: 0x0400000D RID: 13
		private global::System.Collections.Generic.HashSet<ushort> programmableTypes;
	}
}
