using System;

namespace Motorola.Common.Communication.RUDP.States
{
	// Token: 0x02000022 RID: 34
	internal interface IRUDPState
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600018A RID: 394
		global::Motorola.Common.Communication.RUDP.RUDPSockState SockState { get; }

		// Token: 0x0600018B RID: 395
		bool ActiveOpen(global::Motorola.Common.Communication.RUDP.RUDPConnection connection);

		// Token: 0x0600018C RID: 396
		void PassiveOpen(global::Motorola.Common.Communication.RUDP.RUDPConnection connection);

		// Token: 0x0600018D RID: 397
		void Close(global::Motorola.Common.Communication.RUDP.RUDPConnection connection);

		// Token: 0x0600018E RID: 398
		void Synchronize(global::Motorola.Common.Communication.RUDP.RUDPConnection connection);

		// Token: 0x0600018F RID: 399
		void Acknowledge(global::Motorola.Common.Communication.RUDP.RUDPConnection connection);

		// Token: 0x06000190 RID: 400
		int Send(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket packet);

		// Token: 0x06000191 RID: 401
		void Receive(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket packet);

		// Token: 0x06000192 RID: 402
		void ChangeState(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.States.IRUDPState state);
	}
}
