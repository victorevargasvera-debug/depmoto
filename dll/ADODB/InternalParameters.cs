using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000087 RID: 135
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public class InternalParameters : global::ADODB.Parameters, global::ADODB._DynaCollection, global::ADODB._Collection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000450 RID: 1104 RVA: 0x00005524 File Offset: 0x00004524
		internal InternalParameters(global::ADODB.Parameters parms)
		{
			this.m_parms = parms;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00005548 File Offset: 0x00004548
		internal global::System.IntPtr GetParms()
		{
			return global::System.Runtime.InteropServices.Marshal.GetIUnknownForObject(this.m_parms);
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00005564 File Offset: 0x00004564
		public int Count
		{
			get
			{
				return this.m_parms.Count;
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00005580 File Offset: 0x00004580
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return new global::ADODB.ParameterEnumerator(this.m_parms.GetEnumerator(), this);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000055A4 File Offset: 0x000045A4
		public void Refresh()
		{
			this.m_parms.Refresh();
		}

		// Token: 0x17000168 RID: 360
		public global::ADODB.Parameter this[object index]
		{
			get
			{
				return new global::ADODB.InternalParameter(this.m_parms[index])
				{
					m_parms = this
				};
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000055E8 File Offset: 0x000045E8
		public void Delete(object Index)
		{
			this.m_parms.Delete(Index);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00005604 File Offset: 0x00004604
		public void Append(object oParam)
		{
			this.m_parms.Append(((global::ADODB.InternalParameter)oParam).GetParm());
			((global::ADODB.InternalParameter)oParam).m_parms = this;
		}

		// Token: 0x04000201 RID: 513
		private global::ADODB.Parameters m_parms = null;
	}
}
