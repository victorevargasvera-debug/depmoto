using System;
using System.Collections.Generic;
using Motorola.Common.Communication.RUDP.Helper;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200000E RID: 14
	internal class RUDPUserDataPacket
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00005340 File Offset: 0x00003540
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00005348 File Offset: 0x00003548
		public global::System.IAsyncResult AsyncResult
		{
			private get
			{
				return this.asyncResult;
			}
			set
			{
				this.asyncResult = (value as global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], int>);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00005356 File Offset: 0x00003556
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00005360 File Offset: 0x00003560
		public bool IsObsoletedPacket
		{
			private get
			{
				return this.isObsoletedPacket;
			}
			set
			{
				this.isObsoletedPacket = value;
				if (!this.isObsoletedPacket)
				{
					foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket in this._rawPacketList)
					{
						rudppacket.IsObsoletedPacket = true;
					}
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000053C4 File Offset: 0x000035C4
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00005470 File Offset: 0x00003670
		public bool IsIntegratedPacket
		{
			get
			{
				if (this.isIntegratedPacket)
				{
					return true;
				}
				uint num = (uint)global::Motorola.Common.Communication.RUDP.RUDPConstants.DEFAULT_SEQ_ACK_NUM;
				foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket in this._rawPacketList)
				{
					if (num == (uint)global::Motorola.Common.Communication.RUDP.RUDPConstants.DEFAULT_SEQ_ACK_NUM)
					{
						num = (uint)rudppacket.Header.SequenceNumber;
					}
					else
					{
						if ((uint)rudppacket.Header.SequenceNumber != num + 1U)
						{
							return false;
						}
						num = (uint)rudppacket.Header.SequenceNumber;
					}
					if (rudppacket.IsFragmentEnd)
					{
						this.isIntegratedPacket = true;
						break;
					}
				}
				return this.isIntegratedPacket;
			}
			private set
			{
				this.isIntegratedPacket = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000549C File Offset: 0x0000369C
		private int DataLen
		{
			get
			{
				int len = 0;
				this._rawPacketList.ForEach(delegate(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
				{
					len += (int)packet.PayloadData.PayloadLen;
				});
				return len;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000054D3 File Offset: 0x000036D3
		private int RawPacketCount
		{
			get
			{
				if (this._rawPacketList != null)
				{
					return this._rawPacketList.Count;
				}
				return 0;
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005517 File Offset: 0x00003717
		private void SortIncomingPacket()
		{
			this._rawPacketList.Sort((global::Motorola.Common.Communication.RUDP.RUDPPacket p1, global::Motorola.Common.Communication.RUDP.RUDPPacket p2) => p1.Header.SequenceNumber.CompareTo(p2.Header.SequenceNumber));
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005588 File Offset: 0x00003788
		public int Serialze(byte[] buff, int offset, int size)
		{
			int offset2 = offset;
			if (size < this.DataLen)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_ReceiveSizeIsnotBigEnough);
			}
			this._rawPacketList.ForEach(delegate(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
			{
				global::System.Array.Copy(packet.Data, 0, buff, offset, (int)packet.PayloadData.PayloadLen);
				offset += (int)packet.PayloadData.PayloadLen;
			});
			return offset - offset2;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000055E4 File Offset: 0x000037E4
		public RUDPUserDataPacket(global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> packetList, global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			this._connection = connection;
			this._rawPacketList = packetList;
			foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket in packetList)
			{
				rudppacket.UserDataPacket = this;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005648 File Offset: 0x00003848
		public void SetTransmissionFailed()
		{
			this.asyncResult.SetAsFailed(0);
			this._connection.RemoveOutgoingUserData(this);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005664 File Offset: 0x00003864
		public void CheckForSendCompleted()
		{
			bool flag = true;
			foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket in this._rawPacketList)
			{
				if (!rudppacket.IsACKed)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.asyncResult.SetAsCompleted(this.DataLen);
				this._connection.RemoveOutgoingUserData(this);
			}
		}

		// Token: 0x04000062 RID: 98
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> _rawPacketList;

		// Token: 0x04000063 RID: 99
		private global::Motorola.Common.Communication.RUDP.Helper.AsynchronousResult<object[], int> asyncResult;

		// Token: 0x04000064 RID: 100
		private global::Motorola.Common.Communication.RUDP.RUDPConnection _connection;

		// Token: 0x04000065 RID: 101
		private bool isObsoletedPacket;

		// Token: 0x04000066 RID: 102
		private bool isIntegratedPacket;
	}
}
