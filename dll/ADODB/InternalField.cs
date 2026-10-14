using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000083 RID: 131
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Reflection.DefaultMember("Value")]
	public class InternalField : global::ADODB.Field, global::ADODB.Field20, global::ADODB._ADO
	{
		// Token: 0x06000425 RID: 1061 RVA: 0x00004FDC File Offset: 0x00003FDC
		internal InternalField(global::ADODB.Field field)
		{
			this.m_field = field;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00004FF8 File Offset: 0x00003FF8
		public int Status
		{
			get
			{
				return this.m_field.Status;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00005014 File Offset: 0x00004014
		public int ActualSize
		{
			get
			{
				return this.m_field.ActualSize;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00005030 File Offset: 0x00004030
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0000504C File Offset: 0x0000404C
		public int Attributes
		{
			get
			{
				return this.m_field.Attributes;
			}
			set
			{
				this.m_field.Attributes = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00005068 File Offset: 0x00004068
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00005084 File Offset: 0x00004084
		public object DataFormat
		{
			get
			{
				return this.m_field.DataFormat;
			}
			set
			{
				this.m_field.DataFormat = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x000050A0 File Offset: 0x000040A0
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x000050BC File Offset: 0x000040BC
		public int DefinedSize
		{
			get
			{
				return this.m_field.DefinedSize;
			}
			set
			{
				this.m_field.DefinedSize = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x000050D8 File Offset: 0x000040D8
		public string Name
		{
			get
			{
				return this.m_field.Name;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x000050F4 File Offset: 0x000040F4
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00005110 File Offset: 0x00004110
		public byte NumericScale
		{
			get
			{
				return this.m_field.NumericScale;
			}
			set
			{
				this.m_field.NumericScale = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000512C File Offset: 0x0000412C
		public object OriginalValue
		{
			get
			{
				return this.m_field.OriginalValue;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00005148 File Offset: 0x00004148
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00005164 File Offset: 0x00004164
		public byte Precision
		{
			get
			{
				return this.m_field.Precision;
			}
			set
			{
				this.m_field.Precision = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00005180 File Offset: 0x00004180
		public global::ADODB.Properties Properties
		{
			get
			{
				return this.m_field.Properties;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0000519C File Offset: 0x0000419C
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x000051B8 File Offset: 0x000041B8
		public global::ADODB.DataTypeEnum Type
		{
			get
			{
				return this.m_field.Type;
			}
			set
			{
				this.m_field.Type = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x000051D4 File Offset: 0x000041D4
		public object UnderlyingValue
		{
			get
			{
				return this.m_field.UnderlyingValue;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x000051F0 File Offset: 0x000041F0
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0000520C File Offset: 0x0000420C
		[global::System.Runtime.CompilerServices.IndexerName("Value")]
		public object Value
		{
			get
			{
				return this.m_field.Value;
			}
			set
			{
				this.m_field.Value = value;
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00005228 File Offset: 0x00004228
		public void AppendChunk(object Data)
		{
			this.m_field.AppendChunk(Data);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00005244 File Offset: 0x00004244
		public object GetChunk(int Length)
		{
			return this.m_field.GetChunk(Length);
		}

		// Token: 0x040001FB RID: 507
		internal global::ADODB.InternalFields m_fields;

		// Token: 0x040001FC RID: 508
		internal global::ADODB.Field m_field;
	}
}
