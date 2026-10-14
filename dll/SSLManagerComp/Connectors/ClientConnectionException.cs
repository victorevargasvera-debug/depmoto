using System;

namespace SSLMangrComp.Connectors
{
	// Token: 0x02000002 RID: 2
	internal class ClientConnectionException : global::System.Exception
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		public ClientConnectionException()
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		public ClientConnectionException(string message)
		{
			this.m_message = message;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000020E7 File Offset: 0x000002E7
		public override string Message
		{
			get
			{
				return this.m_message;
			}
		}

		// Token: 0x04000001 RID: 1
		private string m_message;
	}
}
