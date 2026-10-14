using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200008F RID: 143
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public class InternalErrors : global::ADODB.Errors, global::ADODB._Collection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x00005D54 File Offset: 0x00004D54
		internal InternalErrors(global::ADODB.Errors errors)
		{
			this.m_Errors = errors;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00005D78 File Offset: 0x00004D78
		internal global::System.IntPtr GetErrors()
		{
			return global::System.Runtime.InteropServices.Marshal.GetIUnknownForObject(this.m_Errors);
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00005D94 File Offset: 0x00004D94
		public int Count
		{
			get
			{
				return this.m_Errors.Count;
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00005DB0 File Offset: 0x00004DB0
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return new global::ADODB.ErrorEnumerator(this.m_Errors.GetEnumerator(), this);
		}

		// Token: 0x1700017B RID: 379
		public global::ADODB.Error this[object index]
		{
			get
			{
				return new global::ADODB.InternalError(this.m_Errors[index])
				{
					m_Errors = this
				};
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00005E00 File Offset: 0x00004E00
		public void Clear()
		{
			this.m_Errors.Clear();
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00005E18 File Offset: 0x00004E18
		public void Refresh()
		{
			this.m_Errors.Refresh();
		}

		// Token: 0x0400020D RID: 525
		private global::ADODB.Errors m_Errors = null;
	}
}
