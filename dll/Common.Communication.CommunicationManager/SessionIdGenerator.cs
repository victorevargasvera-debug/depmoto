using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000046 RID: 70
	public class SessionIdGenerator
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00007CFF File Offset: 0x00005EFF
		private SessionIdGenerator()
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00007D1D File Offset: 0x00005F1D
		public static global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator Instance
		{
			get
			{
				return global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.generator;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007D24 File Offset: 0x00005F24
		internal ushort GenerateNewUnqiueID(ushort differentSessionID = 0)
		{
			ushort result;
			lock (global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.sync)
			{
				int num = 0;
				ushort num2;
				do
				{
					num2 = (ushort)this.random.Next(1, 65535);
					num++;
				}
				while ((this.sessionIDs.Contains(num2) || num2 == differentSessionID) && num < 10000);
				if (num >= 10000)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerGenerateNewUnqiueIDFailure);
				}
				this.sessionIDs.Add(num2);
				result = num2;
			}
			return result;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00007DB8 File Offset: 0x00005FB8
		public void ReturnID(ushort ID)
		{
			lock (global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator.sync)
			{
				if (this.sessionIDs.Contains(ID))
				{
					this.sessionIDs.Remove(ID);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Session id {0} returned.", new object[]
					{
						ID
					});
				}
			}
		}

		// Token: 0x0400004F RID: 79
		private const int MaxRetry = 10000;

		// Token: 0x04000050 RID: 80
		private global::System.Collections.Generic.HashSet<ushort> sessionIDs = new global::System.Collections.Generic.HashSet<ushort>();

		// Token: 0x04000051 RID: 81
		private global::System.Random random = new global::System.Random();

		// Token: 0x04000052 RID: 82
		private static global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator generator = new global::Motorola.Common.Communication.CommunicationManager.SessionIdGenerator();

		// Token: 0x04000053 RID: 83
		private static object sync = new object();
	}
}
