using System;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200001B RID: 27
	internal class RUDP_PL_HANDSHAKE_DATA_SECTION : global::Motorola.Common.Communication.RUDP.RUDPPayload
	{
		// Token: 0x06000135 RID: 309 RVA: 0x000062F4 File Offset: 0x000044F4
		public override object[] GetObjectList()
		{
			object[] result;
			if (this.Content == global::Motorola.Common.Communication.RUDP.HandshakeContent.SESSION_PARAMS)
			{
				result = new object[]
				{
					this.SESSION_PARAMS_SECTION
				};
			}
			else if (this.Content == global::Motorola.Common.Communication.RUDP.HandshakeContent.SYN_WITH_SESSION_PARAMS)
			{
				result = new object[]
				{
					this.SYN_SECTION,
					this.SESSION_PARAMS_SECTION
				};
			}
			else
			{
				result = new object[]
				{
					this.SYN_SECTION
				};
			}
			return result;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006357 File Offset: 0x00004557
		public override void SetObjectList(object[] list)
		{
			this.SYN_SECTION = (global::Motorola.Common.Communication.RUDP.RUDP_PL_SYN_SECTION)list[0];
			if (list.Length == 2)
			{
				this.SESSION_PARAMS_SECTION = (global::Motorola.Common.Communication.RUDP.RUDP_PL_SESSION_PARAMS_SECTION)list[1];
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000637B File Offset: 0x0000457B
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00006384 File Offset: 0x00004584
		public global::Motorola.Common.Communication.RUDP.HandshakeContent HSContent
		{
			private get
			{
				return this.Content;
			}
			set
			{
				this.Content = value;
				if (this.Content == global::Motorola.Common.Communication.RUDP.HandshakeContent.SESSION_PARAMS)
				{
					this.PayloadLen = global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_PL_SESSION_PARAMS_SECTION_LEN;
					this.SESSION_PARAMS_SECTION = new global::Motorola.Common.Communication.RUDP.RUDP_PL_SESSION_PARAMS_SECTION();
					this.SESSION_PARAMS_SECTION.initialize_RUDP_PL_SESSION_PARAMS_SECTION();
					this.SYN_SECTION = null;
					return;
				}
				if (this.Content == global::Motorola.Common.Communication.RUDP.HandshakeContent.SYN_WITH_SESSION_PARAMS)
				{
					this.PayloadLen = global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_PL_SYN_SECTION_LEN + global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_PL_SESSION_PARAMS_SECTION_LEN;
					this.SYN_SECTION = new global::Motorola.Common.Communication.RUDP.RUDP_PL_SYN_SECTION();
					this.SYN_SECTION.initialize_RUDP_PL_SYN_SECTION();
					this.SESSION_PARAMS_SECTION = new global::Motorola.Common.Communication.RUDP.RUDP_PL_SESSION_PARAMS_SECTION();
					this.SESSION_PARAMS_SECTION.initialize_RUDP_PL_SESSION_PARAMS_SECTION();
					return;
				}
				this.PayloadLen = global::Motorola.Common.Communication.RUDP.RUDPConstants.RUDP_PL_SYN_SECTION_LEN;
				this.SYN_SECTION = new global::Motorola.Common.Communication.RUDP.RUDP_PL_SYN_SECTION();
				this.SYN_SECTION.initialize_RUDP_PL_SYN_SECTION();
				this.SESSION_PARAMS_SECTION = null;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00006442 File Offset: 0x00004642
		public void initialize_RUDP_PL_HANDSHAKE_DATA_SECTION(global::Motorola.Common.Communication.RUDP.HandshakeContent content)
		{
			this.HSContent = content;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000644B File Offset: 0x0000464B
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00006453 File Offset: 0x00004653
		public global::Motorola.Common.Communication.RUDP.RUDP_PL_SYN_SECTION SYN_SECTION { get; private set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000645C File Offset: 0x0000465C
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00006464 File Offset: 0x00004664
		public global::Motorola.Common.Communication.RUDP.RUDP_PL_SESSION_PARAMS_SECTION SESSION_PARAMS_SECTION { get; private set; }

		// Token: 0x040000C9 RID: 201
		private global::Motorola.Common.Communication.RUDP.HandshakeContent Content;
	}
}
