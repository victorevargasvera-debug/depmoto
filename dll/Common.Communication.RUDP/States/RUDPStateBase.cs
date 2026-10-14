using System;

namespace Motorola.Common.Communication.RUDP.States
{
	// Token: 0x02000023 RID: 35
	internal abstract class RUDPStateBase : global::Motorola.Common.Communication.RUDP.States.IRUDPState
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00006D2B File Offset: 0x00004F2B
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00006D33 File Offset: 0x00004F33
		public global::Motorola.Common.Communication.RUDP.RUDPSockState SockState
		{
			get
			{
				return this._sockState;
			}
			protected set
			{
				this._sockState = value;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00006D3C File Offset: 0x00004F3C
		public virtual bool ActiveOpen(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00006D43 File Offset: 0x00004F43
		public virtual void PassiveOpen(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00006D4A File Offset: 0x00004F4A
		public virtual void Close(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00006D51 File Offset: 0x00004F51
		public virtual void Synchronize(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00006D58 File Offset: 0x00004F58
		public virtual void Acknowledge(global::Motorola.Common.Communication.RUDP.RUDPConnection connection)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00006D5F File Offset: 0x00004F5F
		public virtual int Send(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00006D66 File Offset: 0x00004F66
		public virtual void Receive(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.RUDPPacket packet)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00006D6D File Offset: 0x00004F6D
		public virtual void ChangeState(global::Motorola.Common.Communication.RUDP.RUDPConnection connection, global::Motorola.Common.Communication.RUDP.States.IRUDPState state)
		{
			connection.ChangeState(state);
		}

		// Token: 0x040000E2 RID: 226
		private global::Motorola.Common.Communication.RUDP.RUDPSockState _sockState;
	}
}
