using System;
using System.Collections;

namespace ADODB
{
	// Token: 0x0200008D RID: 141
	internal class PropertyEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x00005BAC File Offset: 0x00004BAC
		public PropertyEnumerator(global::System.Collections.IEnumerator list, global::ADODB.InternalProperties props)
		{
			this.m_list = list;
			this.m_props = props;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00005BDC File Offset: 0x00004BDC
		public bool MoveNext()
		{
			return this.m_list.MoveNext();
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00005BF8 File Offset: 0x00004BF8
		public void Reset()
		{
			this.m_list.Reset();
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00005C10 File Offset: 0x00004C10
		public object Current
		{
			get
			{
				return new global::ADODB.InternalProperty((global::ADODB.Property)this.m_list.Current)
				{
					m_props = this.m_props
				};
			}
		}

		// Token: 0x0400020A RID: 522
		private global::ADODB.InternalProperties m_props = null;

		// Token: 0x0400020B RID: 523
		private global::System.Collections.IEnumerator m_list = null;
	}
}
