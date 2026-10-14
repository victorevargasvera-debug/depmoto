using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200008C RID: 140
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Reflection.DefaultMember("Value")]
	public class InternalProperty : global::ADODB.Property
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x00005AE8 File Offset: 0x00004AE8
		internal InternalProperty(global::ADODB.Property field)
		{
			this.m_prop = field;
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00005B04 File Offset: 0x00004B04
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00005B20 File Offset: 0x00004B20
		public int Attributes
		{
			get
			{
				return this.m_prop.Attributes;
			}
			set
			{
				this.m_prop.Attributes = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00005B3C File Offset: 0x00004B3C
		public string Name
		{
			get
			{
				return this.m_prop.Name;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00005B58 File Offset: 0x00004B58
		public global::ADODB.DataTypeEnum Type
		{
			get
			{
				return this.m_prop.Type;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00005B74 File Offset: 0x00004B74
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00005B90 File Offset: 0x00004B90
		[global::System.Runtime.CompilerServices.IndexerName("Value")]
		public object Value
		{
			get
			{
				return this.m_prop.Value;
			}
			set
			{
				this.m_prop.Value = value;
			}
		}

		// Token: 0x04000208 RID: 520
		internal global::ADODB.InternalProperties m_props;

		// Token: 0x04000209 RID: 521
		internal global::ADODB.Property m_prop;
	}
}
