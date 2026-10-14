using System;
using System.Collections;

namespace ADODB
{
	// Token: 0x02000091 RID: 145
	internal class ErrorEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x00005F10 File Offset: 0x00004F10
		public ErrorEnumerator(global::System.Collections.IEnumerator list, global::ADODB.InternalErrors Errors)
		{
			this.m_list = list;
			this.m_Errors = Errors;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00005F40 File Offset: 0x00004F40
		public bool MoveNext()
		{
			return this.m_list.MoveNext();
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00005F5C File Offset: 0x00004F5C
		public void Reset()
		{
			this.m_list.Reset();
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00005F74 File Offset: 0x00004F74
		public object Current
		{
			get
			{
				return new global::ADODB.InternalError((global::ADODB.Error)this.m_list.Current)
				{
					m_Errors = this.m_Errors
				};
			}
		}

		// Token: 0x04000210 RID: 528
		private global::ADODB.InternalErrors m_Errors = null;

		// Token: 0x04000211 RID: 529
		private global::System.Collections.IEnumerator m_list = null;
	}
}
