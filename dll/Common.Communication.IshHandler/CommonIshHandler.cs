using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000002 RID: 2
	public class CommonIshHandler
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public CommonIshHandler(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int maxPacketSize)
		{
			if (rcmpWrapper == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (maxPacketSize <= 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			this.m_RcmpWrapper = rcmpWrapper;
			this.m_MaxPacketSize = maxPacketSize;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000020FB File Offset: 0x000002FB
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002103 File Offset: 0x00000303
		public int MaxPacketSize
		{
			get
			{
				return this.m_MaxPacketSize;
			}
			set
			{
				this.m_MaxPacketSize = value;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000210C File Offset: 0x0000030C
		public void DeleteIshItem(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaderList, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			ishHeaderList.Sort();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>();
			global::Motorola.Common.Communication.Rcmp.RcmpDeleteIshIDs rcmpDeleteIshIDs = null;
			foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader in ishHeaderList)
			{
				if (rcmpDeleteIshIDs != null && rcmpDeleteIshIDs.IshType == ishHeader.IshType && rcmpDeleteIshIDs.EndID + 1 == ishHeader.IshID)
				{
					rcmpDeleteIshIDs.EndID = ishHeader.IshID;
				}
				else
				{
					rcmpDeleteIshIDs = new global::Motorola.Common.Communication.Rcmp.RcmpDeleteIshIDs(ishHeader.PartitionNumber, ishHeader.IshType, ishHeader.IshID, ishHeader.IshID);
					list.Add(rcmpDeleteIshIDs);
				}
			}
			this.BundleSendMessages(list, progressIndicator);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021C4 File Offset: 0x000003C4
		public void WriteIshItems(global::Motorola.Common.Communication.CommonUtil.IshItemCollection writeItems, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, bool WriteToDual = false)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> rcmpMessages = this.GenerateBundleWriteIshItemsMessages(writeItems, WriteToDual);
			this.BundleSendMessages(rcmpMessages, progressIndicator);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021E4 File Offset: 0x000003E4
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> GenerateBundleWriteIshItemsMessages(global::Motorola.Common.Communication.CommonUtil.IshItemCollection writeItems, bool WriteToDual)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>(writeItems.Count);
			ushort num = (ushort)(this.m_MaxPacketSize - (2 + global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle.HeaderSize) - (2 + global::Motorola.Common.Communication.Rcmp.RcmpWriteIshItem.HeaderSize));
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in writeItems)
			{
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(keyValuePair.Value.Data, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				if (keyValuePair.Value.ItemSize <= 0 || keyValuePair.Value.Data.Length <= 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
				}
				ushort num2 = 0;
				do
				{
					ushort num3 = (ushort)(keyValuePair.Value.ItemSize - (int)num2);
					if (num3 >= num)
					{
						num3 = num;
					}
					byte[] array = new byte[(int)num3];
					global::System.Buffer.BlockCopy(keyValuePair.Value.Data, (int)num2, array, 0, (int)num3);
					list.Add(new global::Motorola.Common.Communication.Rcmp.RcmpWriteIshItem(keyValuePair.Key.PartitionNumber, keyValuePair.Key.IshType, keyValuePair.Key.IshID, num3, num2, (ushort)keyValuePair.Value.ItemSize, array, WriteToDual));
					num2 += num3;
				}
				while ((int)num2 < keyValuePair.Value.ItemSize);
			}
			return list;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002358 File Offset: 0x00000558
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadCodeplug(byte[] partitions, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, global::System.Collections.Generic.List<ushort> typesFilter = null)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			this.ReadIshPartions(ishItemCollection, partitions, progressIndicator, typesFilter);
			return ishItemCollection;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002378 File Offset: 0x00000578
		public void ReadIshPartions(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItems, byte[] partitions, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, global::System.Collections.Generic.List<ushort> typesFilter = null)
		{
			double progressRate = 1.0 / (double)partitions.Length;
			foreach (byte partition in partitions)
			{
				this.ReadIshPartion(ishItems, partition, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, progressRate), typesFilter);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000023BC File Offset: 0x000005BC
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadIshPartion(byte partition, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, global::System.Collections.Generic.List<ushort> typesFilter = null)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			this.ReadIshPartion(ishItemCollection, partition, progressIndicator, typesFilter);
			return ishItemCollection;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000023DC File Offset: 0x000005DC
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadIshItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			ishHeaders = this.GetRealIshHeaders(ishHeaders);
			this.BundleReadIshItems(ishItemCollection, ishHeaders, progressIndicator);
			return ishItemCollection;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002404 File Offset: 0x00000604
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> GetRealIshHeaders(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
			foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader item in ishHeaders)
			{
				if (item.IshID == 65535)
				{
					global::System.Collections.Generic.List<ushort> list2 = this.ReadIshIdSet(item.PartitionNumber, item.IshType);
					using (global::System.Collections.Generic.List<ushort>.Enumerator enumerator2 = list2.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							ushort ishId = enumerator2.Current;
							list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(item.PartitionNumber, item.IshType, ishId));
						}
						continue;
					}
				}
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000024CC File Offset: 0x000006CC
		public void TryReadIshItems(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItems, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeadersToQuest, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>(ishHeadersToQuest.Count);
			global::System.Collections.Generic.Dictionary<ushort, global::System.Collections.Generic.List<ushort>> dictionary = new global::System.Collections.Generic.Dictionary<ushort, global::System.Collections.Generic.List<ushort>>();
			global::System.Collections.Generic.Dictionary<ushort, global::System.Collections.Generic.List<ushort>> dictionary2 = new global::System.Collections.Generic.Dictionary<ushort, global::System.Collections.Generic.List<ushort>>();
			foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader item in ishHeadersToQuest)
			{
				if (!dictionary.ContainsKey((ushort)item.PartitionNumber))
				{
					dictionary.Add((ushort)item.PartitionNumber, this.ReadIshTypeSet(item.PartitionNumber));
				}
				global::System.Collections.Generic.List<ushort> list2 = dictionary[(ushort)item.PartitionNumber];
				if (list2.Contains(item.IshType))
				{
					if (!dictionary2.ContainsKey(item.IshType))
					{
						dictionary2.Add(item.IshType, this.ReadIshIdSet(item.PartitionNumber, item.IshType));
					}
					global::System.Collections.Generic.List<ushort> list3 = dictionary2[item.IshType];
					if (list3.Contains(item.IshID))
					{
						list.Add(item);
					}
				}
			}
			this.BundleReadIshItems(ishItems, list, progressIndicator);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000025DC File Offset: 0x000007DC
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ReadIshTypeIdPairSet(byte partition, ushort[] types, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>(types.Length);
			foreach (ushort num in types)
			{
				global::System.Collections.Generic.List<ushort> list2 = this.ReadIshIdSet(partition, num);
				foreach (ushort ishId in list2)
				{
					list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, num, ishId));
				}
				if (progressIndicator != null)
				{
					progressIndicator.IncreaseProcess(1.0 / (double)types.Length);
				}
			}
			return list;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002678 File Offset: 0x00000878
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> BundleReadIshTypeIdPairSet(byte partition, global::System.Collections.Generic.List<ushort> types, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, global::System.Collections.Generic.List<ushort> typesFilter = null)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
			if (typesFilter == null)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> readIshTyesIdsCountMessages = this.BundleReadIshTypeIdsCount(partition, types, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, 0.2));
				list = this.BundleReadIshIds(readIshTyesIdsCountMessages, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, 0.8));
			}
			else
			{
				foreach (ushort num in types)
				{
					if (typesFilter.Contains(num))
					{
						list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, num, 0));
					}
					else
					{
						global::System.Collections.Generic.List<ushort> list2 = this.ReadIshIdSet(partition, num);
						foreach (ushort ishId in list2)
						{
							list.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(partition, num, ishId));
						}
					}
				}
			}
			list.Sort();
			return list;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002770 File Offset: 0x00000970
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ReadIshTypeIdPairSet(byte partition, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			global::System.Collections.Generic.List<ushort> types = this.ReadIshTypeSet(partition);
			return this.BundleReadIshTypeIdPairSet(partition, types, progressIndicator, null);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002790 File Offset: 0x00000990
		public global::System.Collections.Generic.List<ushort> ReadIshTypeSet(byte partition)
		{
			ushort typeCount = (ushort)((this.m_MaxPacketSize - (2 + global::Motorola.Common.Communication.Rcmp.RcmpReadIshTypeSet.HeaderSize)) / 2);
			ushort num = 0;
			global::System.Collections.Generic.List<ushort> list = new global::System.Collections.Generic.List<ushort>();
			for (;;)
			{
				global::Motorola.Common.Communication.Rcmp.RcmpReadIshTypeSet rcmpReadIshTypeSet = this.ReadIshTypeSet(partition, typeCount, num);
				if (rcmpReadIshTypeSet.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success || rcmpReadIshTypeSet.TotalTypeCount == 0)
				{
					break;
				}
				foreach (ushort item in rcmpReadIshTypeSet.Types)
				{
					list.Add(item);
				}
				num += (ushort)rcmpReadIshTypeSet.Types.Length;
				if (num >= rcmpReadIshTypeSet.TotalTypeCount)
				{
					return list;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshTypeSetFailure);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002820 File Offset: 0x00000A20
		public void BundleSendMessages(global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> rcmpMessages, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			int num = 0;
			foreach (global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage in rcmpMessages)
			{
				num += ((global::Motorola.Common.Communication.ISuperBundlerMessage)rcmpBaseMessage).MaxMessageSize + 2;
			}
			int num2 = 2 + global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle.HeaderSize;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle>();
			global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle = new global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle(true);
			list.Add(xcmpSuperBundle);
			int num3 = num2;
			foreach (global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage2 in rcmpMessages)
			{
				int num4 = ((global::Motorola.Common.Communication.ISuperBundlerMessage)rcmpBaseMessage2).MaxMessageSize + 2;
				if (num3 + num4 >= this.m_MaxPacketSize)
				{
					xcmpSuperBundle = new global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle(true);
					list.Add(xcmpSuperBundle);
					num3 = num2;
				}
				num3 += num4;
				xcmpSuperBundle.AddRcmpMessage(rcmpBaseMessage2);
			}
			foreach (global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle xcmpSuperBundle2 in list)
			{
				if (xcmpSuperBundle2.ChildCount > 0)
				{
					global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage3;
					if (xcmpSuperBundle2.ChildCount > 1)
					{
						rcmpBaseMessage3 = xcmpSuperBundle2;
					}
					else
					{
						rcmpBaseMessage3 = xcmpSuperBundle2[0];
					}
					this.m_RcmpWrapper.SendAndReceiveMessage(rcmpBaseMessage3);
					if (rcmpBaseMessage3.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.IshItemNotFound)
					{
						continue;
					}
					if (rcmpBaseMessage3.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.BundleMessageFailure);
					}
				}
				if (progressIndicator != null)
				{
					progressIndicator.IncreaseProcess(1.0 / (double)list.Count);
				}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000029BC File Offset: 0x00000BBC
		public void ReorgIshPartition(global::System.Collections.Generic.List<byte> partitionList)
		{
			for (int i = 0; i < partitionList.Count; i++)
			{
				global::Motorola.Common.Communication.Rcmp.RcmpIshReorgControl rcmpIshReorgControl = new global::Motorola.Common.Communication.Rcmp.RcmpIshReorgControl(partitionList[i], 1);
				this.m_RcmpWrapper.SendAndReceiveMessage(rcmpIshReorgControl);
				if (rcmpIshReorgControl.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_IshReorgFailure);
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002A08 File Offset: 0x00000C08
		public global::Motorola.Common.Communication.Rcmp.RcmpReadIshTypeSet ReadIshTypeSet(byte partition, ushort typeCount, ushort offset)
		{
			global::Motorola.Common.Communication.Rcmp.RcmpReadIshTypeSet rcmpReadIshTypeSet = new global::Motorola.Common.Communication.Rcmp.RcmpReadIshTypeSet(partition, typeCount, offset);
			this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadIshTypeSet);
			return rcmpReadIshTypeSet;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002A2C File Offset: 0x00000C2C
		private void ReadIshPartion(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItems, byte partition, global::Motorola.Common.Communication.IProgressIndicator progressIndicator, global::System.Collections.Generic.List<ushort> typesFilter)
		{
			global::System.Collections.Generic.List<ushort> types = this.ReadIshTypeSet(partition);
			double num = 1.0;
			if (progressIndicator != null)
			{
				progressIndicator.IncreaseProcess(0.05);
				num -= 0.05;
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders = this.BundleReadIshTypeIdPairSet(partition, types, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, 0.2), typesFilter);
			num -= 0.2;
			this.BundleReadIshItems(ishItems, ishHeaders, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, num));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002AA0 File Offset: 0x00000CA0
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> BundleReadIshItemsSize(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>();
			foreach (global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader in ishHeaders)
			{
				list.Add(new global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem(ishHeader.PartitionNumber, ishHeader.IshType, ishHeader.IshID, 0, 0));
			}
			this.BundleSendMessages(list, progressIndicator);
			return list;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002B14 File Offset: 0x00000D14
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> BundleReadIshItemsContent(global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> readIshItemsSizeMessages, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>(readIshItemsSizeMessages.Count);
			ushort num = (ushort)(this.m_MaxPacketSize - (2 + global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle.HeaderSize) - (2 + global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem.HeaderSize));
			foreach (global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage in readIshItemsSizeMessages)
			{
				global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem rcmpReadIshItem = (global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem)rcmpBaseMessage;
				ushort num2 = 0;
				do
				{
					ushort num3 = rcmpReadIshItem.ItemSize - num2;
					if (num3 >= num)
					{
						num3 = num;
					}
					list.Add(new global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem(rcmpReadIshItem.LogicalPartition, rcmpReadIshItem.IshType, rcmpReadIshItem.IshID, num3, num2));
					num2 += num3;
				}
				while (num2 < rcmpReadIshItem.ItemSize);
			}
			this.BundleSendMessages(list, progressIndicator);
			return list;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002BD4 File Offset: 0x00000DD4
		private void BundleReadIshItems(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItems, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			double num = 1.0;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> readIshItemsSizeMessages = this.BundleReadIshItemsSize(ishHeaders, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, 0.05));
			num -= 0.05;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = this.BundleReadIshItemsContent(readIshItemsSizeMessages, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, num));
			foreach (global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage in list)
			{
				global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem rcmpReadIshItem = (global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem)rcmpBaseMessage;
				if (rcmpReadIshItem.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.IshItemNotFound)
				{
					if (rcmpReadIshItem.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshItemFailure);
					}
					global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(rcmpReadIshItem.LogicalPartition, rcmpReadIshItem.IshType, rcmpReadIshItem.IshID);
					if (ishItems.ContainsHeader(ishHeader))
					{
						global::Motorola.Common.Communication.CommonUtil.IshItem ishItem = ishItems[ishHeader];
						global::System.Buffer.BlockCopy(rcmpReadIshItem.Data, 0, ishItem.Data, (int)rcmpReadIshItem.Offset, rcmpReadIshItem.Data.Length);
					}
					else
					{
						byte[] array;
						if (rcmpReadIshItem.Data.Length >= (int)rcmpReadIshItem.ItemSize)
						{
							array = rcmpReadIshItem.Data;
						}
						else
						{
							array = new byte[(int)rcmpReadIshItem.ItemSize];
							global::System.Buffer.BlockCopy(rcmpReadIshItem.Data, 0, array, 0, rcmpReadIshItem.Data.Length);
						}
						ishItems.AddItem(rcmpReadIshItem.LogicalPartition, rcmpReadIshItem.IshType, rcmpReadIshItem.IshID, (int)rcmpReadIshItem.ItemSize, array);
					}
				}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002D38 File Offset: 0x00000F38
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> BundleReadIshTypeIdsCount(byte partition, global::System.Collections.Generic.List<ushort> types, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>(types.Count);
			foreach (ushort type in types)
			{
				list.Add(new global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet(partition, type, 1, 0));
			}
			this.BundleSendMessages(list, progressIndicator);
			return list;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002DA4 File Offset: 0x00000FA4
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> BundleReadIshIds(global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> readIshTyesIdsCountMessages, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RcmpBaseMessage>(readIshTyesIdsCountMessages.Count);
			ushort num = (ushort)((this.m_MaxPacketSize - (2 + global::Motorola.Common.Communication.Rcmp.XcmpSuperBundle.HeaderSize) - (2 + global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet.HeaderSize)) / 2);
			foreach (global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage in readIshTyesIdsCountMessages)
			{
				global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet rcmpReadIshIDSet = (global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet)rcmpBaseMessage;
				ushort num2 = 0;
				do
				{
					ushort num3 = rcmpReadIshIDSet.TotalIdCount - num2;
					if (num3 >= num)
					{
						num3 = num;
					}
					list.Add(new global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet(rcmpReadIshIDSet.LogicalPartition, rcmpReadIshIDSet.IshType, num3, num2));
					num2 += num3;
				}
				while (num2 < rcmpReadIshIDSet.TotalIdCount);
			}
			this.BundleSendMessages(list, progressIndicator);
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>();
			foreach (global::Motorola.Common.Communication.RcmpBaseMessage rcmpBaseMessage2 in list)
			{
				global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet rcmpReadIshIDSet2 = (global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet)rcmpBaseMessage2;
				if (rcmpReadIshIDSet2.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshIdSetFailure);
				}
				foreach (ushort ishId in rcmpReadIshIDSet2.IDs)
				{
					list2.Add(new global::Motorola.Common.Communication.CommonUtil.IshHeader(rcmpReadIshIDSet2.LogicalPartition, rcmpReadIshIDSet2.IshType, ishId));
				}
			}
			return list2;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002EF8 File Offset: 0x000010F8
		private global::System.Collections.Generic.List<ushort> ReadIshIdSet(byte partition, ushort type)
		{
			ushort num = 0;
			ushort numberOfIDs = (ushort)((this.m_MaxPacketSize - (2 + global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet.HeaderSize)) / 2);
			global::System.Collections.Generic.List<ushort> list = new global::System.Collections.Generic.List<ushort>();
			for (;;)
			{
				global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet rcmpReadIshIDSet = new global::Motorola.Common.Communication.Rcmp.RcmpReadIshIDSet(partition, type, numberOfIDs, num);
				this.m_RcmpWrapper.SendAndReceiveMessage(rcmpReadIshIDSet);
				if (rcmpReadIshIDSet.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success || rcmpReadIshIDSet.TotalIdCount == 0)
				{
					break;
				}
				list.AddRange(rcmpReadIshIDSet.IDs);
				num += (ushort)rcmpReadIshIDSet.IDs.Length;
				if (num >= rcmpReadIshIDSet.TotalIdCount)
				{
					return list;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ReadIshIdSetFailure);
		}

		// Token: 0x04000001 RID: 1
		private global::Motorola.Common.Communication.IMessageExecutor m_RcmpWrapper;

		// Token: 0x04000002 RID: 2
		private int m_MaxPacketSize;
	}
}
