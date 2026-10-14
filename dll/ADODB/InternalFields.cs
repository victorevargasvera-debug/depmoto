using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000082 RID: 130
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	public class InternalFields : global::ADODB.Fields, global::ADODB.Fields20, global::ADODB.Fields15, global::ADODB._Collection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000419 RID: 1049 RVA: 0x00004E70 File Offset: 0x00003E70
		internal InternalFields(global::ADODB.Fields fields)
		{
			this.m_fields = fields;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00004E94 File Offset: 0x00003E94
		internal global::System.IntPtr GetFields()
		{
			return global::System.Runtime.InteropServices.Marshal.GetIUnknownForObject(this.m_fields);
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00004EB0 File Offset: 0x00003EB0
		public int Count
		{
			get
			{
				return this.m_fields.Count;
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00004ECC File Offset: 0x00003ECC
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return new global::ADODB.InternalEnumerator(this.m_fields.GetEnumerator(), this);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00004EF0 File Offset: 0x00003EF0
		public void Refresh()
		{
			this.m_fields.Refresh();
		}

		// Token: 0x17000158 RID: 344
		public global::ADODB.Field this[object index]
		{
			get
			{
				return new global::ADODB.InternalField(this.m_fields[index])
				{
					m_fields = this
				};
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00004F34 File Offset: 0x00003F34
		public void _Append(string Name, global::ADODB.DataTypeEnum Type, int DefinedSize, global::ADODB.FieldAttributeEnum Attrib)
		{
			this.m_fields._Append(Name, Type, DefinedSize, Attrib);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00004F54 File Offset: 0x00003F54
		public void Delete(object Index)
		{
			this.m_fields.Delete(Index);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00004F70 File Offset: 0x00003F70
		public void Append(string Name, global::ADODB.DataTypeEnum Type, int DefinedSize, global::ADODB.FieldAttributeEnum Attrib, object FieldValue)
		{
			this.m_fields.Append(Name, Type, DefinedSize, Attrib, FieldValue);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00004F90 File Offset: 0x00003F90
		public void Update()
		{
			this.m_fields.Update();
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00004FA8 File Offset: 0x00003FA8
		public void Resync(global::ADODB.ResyncEnum ResyncValues)
		{
			this.m_fields.Resync(ResyncValues);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00004FC4 File Offset: 0x00003FC4
		public void CancelUpdate()
		{
			this.m_fields.CancelUpdate();
		}

		// Token: 0x040001FA RID: 506
		internal global::ADODB.Fields m_fields = null;
	}
}
