using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200008B RID: 139
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public class InternalProperties : global::ADODB.Properties, global::ADODB._Collection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000479 RID: 1145 RVA: 0x00005A24 File Offset: 0x00004A24
		internal InternalProperties(global::ADODB.Properties fields)
		{
			this.m_props = fields;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00005A48 File Offset: 0x00004A48
		internal global::System.IntPtr GetProperties()
		{
			return global::System.Runtime.InteropServices.Marshal.GetIUnknownForObject(this.m_props);
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00005A64 File Offset: 0x00004A64
		public int Count
		{
			get
			{
				return this.m_props.Count;
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00005A80 File Offset: 0x00004A80
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return new global::ADODB.PropertyEnumerator(this.m_props.GetEnumerator(), this);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00005AA4 File Offset: 0x00004AA4
		public void Refresh()
		{
			this.m_props.Refresh();
		}

		// Token: 0x17000174 RID: 372
		public global::ADODB.Property this[object index]
		{
			get
			{
				return new global::ADODB.InternalProperty(this.m_props[index])
				{
					m_props = this
				};
			}
		}

		// Token: 0x04000207 RID: 519
		private global::ADODB.Properties m_props = null;
	}
}
