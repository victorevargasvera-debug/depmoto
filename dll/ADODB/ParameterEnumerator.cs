using System;
using System.Collections;

namespace ADODB
{
	// Token: 0x02000089 RID: 137
	internal class ParameterEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x0600046D RID: 1133 RVA: 0x0000587C File Offset: 0x0000487C
		public ParameterEnumerator(global::System.Collections.IEnumerator list, global::ADODB.InternalParameters parms)
		{
			this.m_list = list;
			this.m_parms = parms;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000058AC File Offset: 0x000048AC
		public bool MoveNext()
		{
			return this.m_list.MoveNext();
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000058C8 File Offset: 0x000048C8
		public void Reset()
		{
			this.m_list.Reset();
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x000058E0 File Offset: 0x000048E0
		public object Current
		{
			get
			{
				return new global::ADODB.InternalParameter((global::ADODB.Parameter)this.m_list.Current)
				{
					m_parms = this.m_parms
				};
			}
		}

		// Token: 0x04000204 RID: 516
		private global::ADODB.InternalParameters m_parms = null;

		// Token: 0x04000205 RID: 517
		private global::System.Collections.IEnumerator m_list = null;
	}
}
