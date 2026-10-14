using System;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x0200001B RID: 27
	internal class ServerException : global::System.Exception
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x000058F2 File Offset: 0x00003AF2
		public ServerException()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000058FA File Offset: 0x00003AFA
		public ServerException(string message)
		{
			this.m_message = message;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00005909 File Offset: 0x00003B09
		public override string Message
		{
			get
			{
				return this.m_message;
			}
		}

		// Token: 0x04000078 RID: 120
		private string m_message;
	}
}
