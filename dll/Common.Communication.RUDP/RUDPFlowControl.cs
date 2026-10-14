using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200000C RID: 12
	internal class RUDPFlowControl
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00003FF0 File Offset: 0x000021F0
		public RUDPFlowControl(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPConfigParams configuration, global::Motorola.Common.Communication.RUDP.RUDPTimerController timeController)
		{
			this._connection = connection;
			this._configuration = configuration;
			this._timeController = timeController;
			this._rudpTimerPool = new global::Motorola.Common.Communication.RUDP.RUDPTimerPool(this._configuration, this, this._timeController);
			this.slidingWindowSize = configuration.SynNegociateParameters.maximal_number_of_outstanding_unacknowledged_fragment;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000040A4 File Offset: 0x000022A4
		public void ResetInactivityTimer()
		{
			this._rudpTimerPool.ResetInactivityTimer();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000040B1 File Offset: 0x000022B1
		public void StartInactivityTimer()
		{
			this._rudpTimerPool.StartInactivityTimer();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000040BE File Offset: 0x000022BE
		public void SetConfigParams(global::Motorola.Common.Communication.RUDP.RUDPConfigParams configuration)
		{
			this._configuration = configuration;
			this._rudpTimerPool.UpdateConfigParams(configuration);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000040D3 File Offset: 0x000022D3
		private int UnacknowledgePacketNumber
		{
			get
			{
				return this._unacknowledgeOutgoingPacketList.Count;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000040E0 File Offset: 0x000022E0
		private int IncomingPacketNumber
		{
			get
			{
				return this._incomingPacketList.Count;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000040ED File Offset: 0x000022ED
		private int OutgoingPacketNumber
		{
			get
			{
				return this._outgoingPacketList.Count;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000040FA File Offset: 0x000022FA
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00004102 File Offset: 0x00002302
		public global::Motorola.Common.Communication.RUDP.RUDPConnection Connection
		{
			get
			{
				return this._connection;
			}
			private set
			{
				this._connection = value;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000410C File Offset: 0x0000230C
		public void AddIncomingPacket(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			this._incomingPacketsLock.EnterWriteLock();
			this._unacknowledgeIncomingPacketsLock.EnterWriteLock();
			try
			{
				this._incomingPacketList.Add(packet);
				this._unacknowledgeIncomingPacketList.Add(packet);
			}
			finally
			{
				this._incomingPacketsLock.ExitWriteLock();
				this._unacknowledgeIncomingPacketsLock.ExitWriteLock();
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004170 File Offset: 0x00002370
		private void RemoveIncomingPacket(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			this._incomingPacketsLock.EnterWriteLock();
			try
			{
				this._incomingPacketList.Remove(packet);
			}
			finally
			{
				this._incomingPacketsLock.ExitWriteLock();
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000041B4 File Offset: 0x000023B4
		private void RemoveIncomingPacketRange(int count)
		{
			if (count <= 0)
			{
				return;
			}
			this._incomingPacketsLock.EnterWriteLock();
			try
			{
				this._incomingPacketList.RemoveRange(0, count);
			}
			finally
			{
				this._incomingPacketsLock.ExitWriteLock();
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000041FC File Offset: 0x000023FC
		private global::Motorola.Common.Communication.RUDP.RUDPPacket GetTheFirstUnackedIncomingPacket()
		{
			global::Motorola.Common.Communication.RUDP.RUDPPacket result = null;
			if (this._unacknowledgeIncomingPacketList.Count <= 0)
			{
				return null;
			}
			foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket in this._unacknowledgeIncomingPacketList)
			{
				if (!rudppacket.IsACKed)
				{
					rudppacket.IsACKed = true;
					result = rudppacket;
					break;
				}
			}
			return result;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004274 File Offset: 0x00002474
		private void AddOutgoingPacket(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			this._outgoingPacketsLock.EnterWriteLock();
			try
			{
				this._outgoingPacketList.Add(packet);
			}
			finally
			{
				this._outgoingPacketsLock.ExitWriteLock();
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000042B8 File Offset: 0x000024B8
		private void AddOutgoingPacketRange(global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> packetList)
		{
			this._outgoingPacketsLock.EnterWriteLock();
			try
			{
				this._outgoingPacketList.AddRange(packetList);
			}
			finally
			{
				this._outgoingPacketsLock.ExitWriteLock();
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000042FC File Offset: 0x000024FC
		private void RemoveOutgoingPacket(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			this._outgoingPacketsLock.EnterWriteLock();
			try
			{
				this._outgoingPacketList.Remove(packet);
			}
			finally
			{
				this._outgoingPacketsLock.ExitWriteLock();
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004340 File Offset: 0x00002540
		private void AddUnknowledgeOutgoingPacket(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			this._unacknowledgeOutgoingPacketList.Add(packet);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004350 File Offset: 0x00002550
		private void RemoveUnknowledgeOutgoingPacket(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			this._unacknowledgeOutgoingPacketsLock.EnterWriteLock();
			try
			{
				this._unacknowledgeOutgoingPacketList.Remove(packet);
				this._connection.LAST_SENT_SEQN = packet.Header.SequenceNumber;
			}
			finally
			{
				this._unacknowledgeOutgoingPacketsLock.ExitWriteLock();
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000043AC File Offset: 0x000025AC
		private void AddUnknowledgeIncomingPacket(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			this._unacknowledgeIncomingPacketsLock.EnterWriteLock();
			try
			{
				this._unacknowledgeIncomingPacketList.Add(packet);
			}
			finally
			{
				this._unacknowledgeIncomingPacketsLock.ExitWriteLock();
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000043F0 File Offset: 0x000025F0
		private void RemoveUnknowledgeIncomingPacket(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			this._unacknowledgeIncomingPacketsLock.EnterWriteLock();
			try
			{
				this._unacknowledgeIncomingPacketList.Remove(packet);
			}
			finally
			{
				this._unacknowledgeIncomingPacketsLock.ExitWriteLock();
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004434 File Offset: 0x00002634
		private void MoveFromOutgoing2Unknowledge(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			this.RemoveOutgoingPacket(packet);
			this.AddUnknowledgeOutgoingPacket(packet);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004444 File Offset: 0x00002644
		private void MoveFromIncoming2Unknowledge(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			this.RemoveIncomingPacket(packet);
			this.AddUnknowledgeIncomingPacket(packet);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004454 File Offset: 0x00002654
		public void Clean()
		{
			this._outgoingPacketsLock.EnterWriteLock();
			this._incomingPacketsLock.EnterWriteLock();
			this._unacknowledgeIncomingPacketsLock.EnterWriteLock();
			this._unacknowledgeOutgoingPacketsLock.EnterWriteLock();
			try
			{
				this._outgoingPacketList.Clear();
				this._incomingPacketList.Clear();
				this._unacknowledgeIncomingPacketList.Clear();
				this._unacknowledgeOutgoingPacketList.Clear();
			}
			finally
			{
				this._outgoingPacketsLock.ExitWriteLock();
				this._incomingPacketsLock.ExitWriteLock();
				this._unacknowledgeIncomingPacketsLock.ExitWriteLock();
				this._unacknowledgeOutgoingPacketsLock.ExitWriteLock();
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004523 File Offset: 0x00002723
		private void SortIncomingPacket()
		{
			this._incomingPacketsLock.EnterWriteLock();
			this._incomingPacketList.Sort((global::Motorola.Common.Communication.RUDP.RUDPPacket p1, global::Motorola.Common.Communication.RUDP.RUDPPacket p2) => p1.Header.SequenceNumber.CompareTo(p2.Header.SequenceNumber));
			this._incomingPacketsLock.ExitWriteLock();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004564 File Offset: 0x00002764
		public int Send(global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> packetList)
		{
			if (packetList != null)
			{
				this.AddOutgoingPacketRange(packetList);
			}
			int num = this.slidingWindowSize - this.UnacknowledgePacketNumber;
			this._outgoingPacketsLock.EnterReadLock();
			int count = this._outgoingPacketList.Count;
			int num2 = (count >= num) ? num : count;
			if (num2 > 0)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket>(this._outgoingPacketList.GetRange(0, num2));
				this._outgoingPacketsLock.ExitReadLock();
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket = enumerator.Current;
						this._unacknowledgeIncomingPacketsLock.EnterReadLock();
						this._unacknowledgeOutgoingPacketsLock.EnterWriteLock();
						try
						{
							this.CheckForSendWithDelayACK(rudppacket);
							this._connection.Send(rudppacket);
							global::Motorola.Common.Communication.RUDP.RUDPFlowControl.InstallSendTimers(rudppacket);
							if (rudppacket.PacketType != global::Motorola.Common.Communication.RUDP.RUDPACKFlags.ACK)
							{
								this.MoveFromOutgoing2Unknowledge(rudppacket);
							}
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Send Exception: " + ex.Message, new object[0]);
							throw;
						}
						finally
						{
							this._unacknowledgeOutgoingPacketsLock.ExitWriteLock();
							this._unacknowledgeIncomingPacketsLock.ExitReadLock();
						}
					}
					return num2;
				}
			}
			this._outgoingPacketsLock.ExitReadLock();
			return num2;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000046BC File Offset: 0x000028BC
		public int Receive(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			ushort packetLength = packet.PacketLength;
			int maximal_fragment_size = this._configuration.SynNegociateParameters.maximal_fragment_size;
			global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket = null;
			global::Motorola.Common.Communication.RUDP.WindowState windowState = this.CheckForWindow(packet, out rudppacket);
			if (windowState == global::Motorola.Common.Communication.RUDP.WindowState.IN_WINDOW)
			{
				long num = global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer.CurrentMicroSeconds - rudppacket.InitSendTime;
				if (this._connection.Benchmark.RUDP_MAX_SENT_PACKET_TIME < num)
				{
					this._connection.Benchmark.RUDP_MAX_SENT_PACKET_TIME = num;
				}
				this._connection.Benchmark.RUDP_TOTAL_SENT_PACKET_TIME += num;
				rudppacket.SetTransmissionCompleted();
				this.RemoveUnknowledgeOutgoingPacket(rudppacket);
				this.Send(null);
			}
			else if (windowState == global::Motorola.Common.Communication.RUDP.WindowState.OUT_WINDOW)
			{
				if (packet.PacketType != global::Motorola.Common.Communication.RUDP.RUDPACKFlags.DATA)
				{
				}
			}
			else if (windowState == global::Motorola.Common.Communication.RUDP.WindowState.OUT_WINDOW_REPEAT)
			{
				global::Motorola.Common.Communication.RUDP.RUDPACKFlags packetType = packet.PacketType;
			}
			this._connection.Receive(packet);
			return 1;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000477C File Offset: 0x0000297C
		private global::Motorola.Common.Communication.RUDP.WindowState CheckForWindow(global::Motorola.Common.Communication.RUDP.RUDPPacket packet, out global::Motorola.Common.Communication.RUDP.RUDPPacket ackPacket)
		{
			ackPacket = null;
			global::Motorola.Common.Communication.RUDP.WindowState windowState = global::Motorola.Common.Communication.RUDP.WindowState.OUT_WINDOW;
			if (packet.IsACKPacket)
			{
				int acknowledgementNumber = (int)packet.Header.AcknowledgementNumber;
				this._unacknowledgeOutgoingPacketsLock.EnterReadLock();
				foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket in this._unacknowledgeOutgoingPacketList)
				{
					if (acknowledgementNumber == (int)rudppacket.Header.SequenceNumber)
					{
						windowState = global::Motorola.Common.Communication.RUDP.WindowState.IN_WINDOW;
						ackPacket = rudppacket;
						rudppacket.IsACKed = true;
					}
				}
				this._unacknowledgeOutgoingPacketsLock.ExitReadLock();
				if (windowState != global::Motorola.Common.Communication.RUDP.WindowState.IN_WINDOW)
				{
					if (acknowledgementNumber >= (int)this._connection.INIT_SENT_SEQN && acknowledgementNumber <= (int)this._connection.LAST_SENT_SEQN)
					{
						windowState = global::Motorola.Common.Communication.RUDP.WindowState.OUT_WINDOW_REPEAT;
					}
					this._connection.Benchmark.RUDP_RCVD_DUPLICATED_PACKET_TIMES++;
				}
			}
			return windowState;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004850 File Offset: 0x00002A50
		public global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket CheckForIntegratedIncomingPacket()
		{
			this.SortIncomingPacket();
			global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket result = null;
			int num = 0;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> list = null;
			this._incomingPacketsLock.EnterReadLock();
			try
			{
				int num2 = (int)global::Motorola.Common.Communication.RUDP.RUDPConstants.DEFAULT_SEQ_ACK_NUM;
				foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket in this._incomingPacketList)
				{
					num++;
					if (num2 == (int)global::Motorola.Common.Communication.RUDP.RUDPConstants.DEFAULT_SEQ_ACK_NUM)
					{
						num2 = (int)rudppacket.Header.SequenceNumber;
					}
					else if ((int)rudppacket.Header.SequenceNumber != num2 + 1)
					{
						break;
					}
					if (rudppacket.IsFragmentEnd)
					{
						list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket>();
						list.AddRange(this._incomingPacketList.Take(num));
						result = new global::Motorola.Common.Communication.RUDP.RUDPUserDataPacket(list, null);
						break;
					}
					num2 = (int)rudppacket.Header.SequenceNumber;
				}
			}
			finally
			{
				this._incomingPacketsLock.ExitReadLock();
			}
			if (list != null)
			{
				this.RemoveIncomingPacketRange(num);
			}
			return result;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00004944 File Offset: 0x00002B44
		private void CheckForSendWithDelayACK(global::Motorola.Common.Communication.RUDP.RUDPPacket sendPacket)
		{
			global::Motorola.Common.Communication.RUDP.RUDPPacket theFirstUnackedIncomingPacket = this.GetTheFirstUnackedIncomingPacket();
			if (theFirstUnackedIncomingPacket != null)
			{
				sendPacket.Header.AcknowledgementNumber = theFirstUnackedIncomingPacket.Header.SequenceNumber;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00004974 File Offset: 0x00002B74
		private static void InstallSendTimers(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			long currentMicroSeconds = global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer.CurrentMicroSeconds;
			packet.LastSendTime = currentMicroSeconds;
			packet.RetriedTimes++;
			if (packet.InitSendTime == 0L)
			{
				packet.InitSendTime = currentMicroSeconds;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000049B0 File Offset: 0x00002BB0
		public static void InstallReceiveTimers(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			long currentMicroSeconds = global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer.CurrentMicroSeconds;
			packet.ReceivedTime = currentMicroSeconds;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000049CC File Offset: 0x00002BCC
		public void RetransmissionTimerCallback(object state)
		{
			global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer rudphighAccurateTimer = (global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer)state;
			long currentMicroSeconds = global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer.CurrentMicroSeconds;
			this._unacknowledgeOutgoingPacketsLock.EnterReadLock();
			try
			{
				foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket in this._unacknowledgeOutgoingPacketList)
				{
					if (!rudppacket.IsACKed && !rudppacket.IsObsoletedPacket)
					{
						long num = currentMicroSeconds - rudppacket.LastSendTime;
						if (num > (long)(this._configuration.TimeBetweenRetries * 1000))
						{
							if (rudppacket.RetriedTimes > this._connection.Benchmark.RUDP_MAX_RESEND_TIMES)
							{
								this._connection.Benchmark.RUDP_MAX_RESEND_TIMES = rudppacket.RetriedTimes;
							}
							if (rudppacket.RetriedTimes > this._configuration.MaxNumberofRetries)
							{
								rudppacket.SetTransmissionFailed();
							}
							else
							{
								this.Resend(rudppacket);
							}
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, new object[0]);
			}
			finally
			{
				this._unacknowledgeOutgoingPacketsLock.ExitReadLock();
			}
			this.ClearUnAckedOutgoingPackets();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004B00 File Offset: 0x00002D00
		public void DelayACKTimerCallback(object state)
		{
			long currentMicroSeconds = global::Motorola.Common.Communication.RUDP.RUDPHighAccurateTimer.CurrentMicroSeconds;
			this.ClearUnAckedIncomingPackets();
			this._unacknowledgeIncomingPacketsLock.EnterReadLock();
			try
			{
				foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket in this._unacknowledgeIncomingPacketList)
				{
					if (!rudppacket.IsACKed)
					{
						long num = currentMicroSeconds - rudppacket.ReceivedTime;
						if (rudppacket.Header.FRG)
						{
							this.SendACK(rudppacket);
							rudppacket.IsACKed = true;
						}
						else if (num > (long)(this._configuration.DelayedAckTimeout * 1000))
						{
							this.SendACK(rudppacket);
							rudppacket.IsACKed = true;
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, new object[0]);
			}
			finally
			{
				this._unacknowledgeIncomingPacketsLock.ExitReadLock();
			}
			this.ClearUnAckedIncomingPackets();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004BFC File Offset: 0x00002DFC
		public void StartCloseWaitTimer()
		{
			this._rudpTimerPool.StartCloseWaitTimer();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004C0C File Offset: 0x00002E0C
		private int Resend(global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			int num = this._connection.RUDPSendTo(packet);
			this._connection.Benchmark.RUDP_TOTAL_RESEND_TIMES++;
			this._connection.Benchmark.RUDP_TOTAL_RESEND_BYTES += num;
			this._connection.Benchmark.RUDP_TOTAL_RESEND_PACKETS++;
			global::Motorola.Common.Communication.RUDP.RUDPFlowControl.InstallSendTimers(packet);
			return num;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004C78 File Offset: 0x00002E78
		public void SendACK(global::Motorola.Common.Communication.RUDP.RUDPPacket unackedPacket)
		{
			global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket = global::Motorola.Common.Communication.RUDP.RUDPPacketHelper.MakeACKPacket(this._connection, unackedPacket);
			int num = this._connection.RUDPSendTo(rudppacket);
			unackedPacket.IsACKed = true;
			if (num != (int)rudppacket.PacketLength)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_SendIsNotCompleted);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004CBC File Offset: 0x00002EBC
		private void ClearUnAckedIncomingPackets()
		{
			this._unacknowledgeIncomingPacketsLock.EnterWriteLock();
			try
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> list = null;
				foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket in this._unacknowledgeIncomingPacketList)
				{
					if (rudppacket.IsACKed)
					{
						if (list == null)
						{
							list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket>();
						}
						list.Add(rudppacket);
					}
				}
				if (list != null)
				{
					foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket item in list)
					{
						this._unacknowledgeIncomingPacketList.Remove(item);
					}
				}
			}
			finally
			{
				this._unacknowledgeIncomingPacketsLock.ExitWriteLock();
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004D90 File Offset: 0x00002F90
		private void ClearUnAckedOutgoingPackets()
		{
			this._unacknowledgeOutgoingPacketsLock.EnterWriteLock();
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> list = null;
			try
			{
				foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket rudppacket in this._unacknowledgeOutgoingPacketList)
				{
					if (rudppacket.IsACKed || rudppacket.IsObsoletedPacket)
					{
						if (list == null)
						{
							list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket>();
						}
						list.Add(rudppacket);
					}
				}
			}
			catch (global::System.Exception)
			{
			}
			try
			{
				if (list != null)
				{
					foreach (global::Motorola.Common.Communication.RUDP.RUDPPacket item in list)
					{
						this._unacknowledgeOutgoingPacketList.Remove(item);
					}
				}
			}
			finally
			{
				this._unacknowledgeOutgoingPacketsLock.ExitWriteLock();
			}
		}

		// Token: 0x04000054 RID: 84
		private global::Motorola.Common.Communication.RUDP.RUDPConnection _connection;

		// Token: 0x04000055 RID: 85
		private global::Motorola.Common.Communication.RUDP.RUDPConfigParams _configuration;

		// Token: 0x04000056 RID: 86
		private global::Motorola.Common.Communication.RUDP.RUDPTimerPool _rudpTimerPool;

		// Token: 0x04000057 RID: 87
		private global::Motorola.Common.Communication.RUDP.RUDPTimerController _timeController;

		// Token: 0x04000058 RID: 88
		private int slidingWindowSize = global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_DEFAULT_SLIDING_WIN_SIZE;

		// Token: 0x04000059 RID: 89
		private global::System.Threading.ReaderWriterLockSlim _outgoingPacketsLock = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x0400005A RID: 90
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> _outgoingPacketList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket>();

		// Token: 0x0400005B RID: 91
		private global::System.Threading.ReaderWriterLockSlim _unacknowledgeOutgoingPacketsLock = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x0400005C RID: 92
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> _unacknowledgeOutgoingPacketList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket>();

		// Token: 0x0400005D RID: 93
		private global::System.Threading.ReaderWriterLockSlim _incomingPacketsLock = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x0400005E RID: 94
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> _incomingPacketList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket>();

		// Token: 0x0400005F RID: 95
		private global::System.Threading.ReaderWriterLockSlim _unacknowledgeIncomingPacketsLock = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x04000060 RID: 96
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket> _unacknowledgeIncomingPacketList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.RUDPPacket>();
	}
}
