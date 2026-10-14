using System;
using System.Collections;

namespace ADODB
{
	// Token: 0x02000084 RID: 132
	internal class InternalEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x00005264 File Offset: 0x00004264
		public InternalEnumerator(global::System.Collections.IEnumerator list, global::ADODB.InternalFields Fields)
		{
			this.m_list = list;
			this.m_fields = Fields;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00005294 File Offset: 0x00004294
		public bool MoveNext()
		{
			return this.m_list.MoveNext();
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000052B0 File Offset: 0x000042B0
		public void Reset()
		{
			this.m_list.Reset();
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x000052C8 File Offset: 0x000042C8
		public object Current
		{
			get
			{
				return new global::ADODB.InternalField((global::ADODB.Field)this.m_list.Current)
				{
					m_fields = this.m_fields
				};
			}
		}

		// Token: 0x040001FD RID: 509
		private global::ADODB.InternalFields m_fields = null;

		// Token: 0x040001FE RID: 510
		private global::System.Collections.IEnumerator m_list = null;
	}
}
