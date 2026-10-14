using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000088 RID: 136
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDispatch)]
	[global::System.Reflection.DefaultMember("Value")]
	public class InternalParameter : global::ADODB.Parameter, global::ADODB._Parameter, global::ADODB._ADO
	{
		// Token: 0x06000458 RID: 1112 RVA: 0x00005634 File Offset: 0x00004634
		internal InternalParameter(global::ADODB.Parameter parm)
		{
			this.m_parm = parm;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00005650 File Offset: 0x00004650
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x0000566C File Offset: 0x0000466C
		[global::System.Runtime.InteropServices.DispId(8)]
		public int Attributes
		{
			get
			{
				return this.m_parm.Attributes;
			}
			set
			{
				this.m_parm.Attributes = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00005688 File Offset: 0x00004688
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x000056A4 File Offset: 0x000046A4
		[global::System.Runtime.InteropServices.DispId(3)]
		public global::ADODB.ParameterDirectionEnum Direction
		{
			get
			{
				return this.m_parm.Direction;
			}
			set
			{
				this.m_parm.Direction = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x000056C0 File Offset: 0x000046C0
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x000056DC File Offset: 0x000046DC
		[global::System.Runtime.InteropServices.DispId(1)]
		public string Name
		{
			get
			{
				return this.m_parm.Name;
			}
			set
			{
				this.m_parm.Name = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x000056F8 File Offset: 0x000046F8
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00005714 File Offset: 0x00004714
		[global::System.Runtime.InteropServices.DispId(5)]
		public byte NumericScale
		{
			get
			{
				return this.m_parm.NumericScale;
			}
			set
			{
				this.m_parm.NumericScale = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00005730 File Offset: 0x00004730
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x0000574C File Offset: 0x0000474C
		[global::System.Runtime.InteropServices.DispId(4)]
		public byte Precision
		{
			get
			{
				return this.m_parm.Precision;
			}
			set
			{
				this.m_parm.Precision = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00005768 File Offset: 0x00004768
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00005784 File Offset: 0x00004784
		[global::System.Runtime.InteropServices.DispId(6)]
		public int Size
		{
			get
			{
				return this.m_parm.Size;
			}
			set
			{
				this.m_parm.Size = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000057A0 File Offset: 0x000047A0
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x000057BC File Offset: 0x000047BC
		[global::System.Runtime.InteropServices.DispId(2)]
		public global::ADODB.DataTypeEnum Type
		{
			get
			{
				return this.m_parm.Type;
			}
			set
			{
				this.m_parm.Type = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x000057D8 File Offset: 0x000047D8
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x000057F4 File Offset: 0x000047F4
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.IndexerName("Value")]
		public object Value
		{
			get
			{
				return this.m_parm.Value;
			}
			set
			{
				this.m_parm.Value = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00005810 File Offset: 0x00004810
		[global::System.Runtime.InteropServices.DispId(500)]
		public global::ADODB.Properties Properties
		{
			get
			{
				return this.m_parm.Properties;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000582C File Offset: 0x0000482C
		[global::System.Runtime.InteropServices.DispId(7)]
		public void AppendChunk(object Data)
		{
			this.m_parm.AppendChunk(Data);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00005848 File Offset: 0x00004848
		internal global::ADODB.Parameter GetParm()
		{
			return this.m_parm;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00005860 File Offset: 0x00004860
		internal global::System.IntPtr GetParam()
		{
			return global::System.Runtime.InteropServices.Marshal.GetIUnknownForObject(this.m_parm);
		}

		// Token: 0x04000202 RID: 514
		internal global::ADODB.InternalParameters m_parms;

		// Token: 0x04000203 RID: 515
		internal global::ADODB.Parameter m_parm;
	}
}
