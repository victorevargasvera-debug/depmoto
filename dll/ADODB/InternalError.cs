using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000090 RID: 144
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Reflection.DefaultMember("Description")]
	public class InternalError : global::ADODB.Error
	{
		// Token: 0x06000499 RID: 1177 RVA: 0x00005E30 File Offset: 0x00004E30
		internal InternalError(global::ADODB.Error error)
		{
			this.m_Error = error;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00005E4C File Offset: 0x00004E4C
		[global::System.Runtime.CompilerServices.IndexerName("Description")]
		public string Description
		{
			get
			{
				return this.m_Error.Description;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00005E68 File Offset: 0x00004E68
		public int NativeError
		{
			get
			{
				return this.m_Error.NativeError;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00005E84 File Offset: 0x00004E84
		public string SQLState
		{
			get
			{
				return this.m_Error.SQLState;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00005EA0 File Offset: 0x00004EA0
		public string Source
		{
			get
			{
				return this.m_Error.Source;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00005EBC File Offset: 0x00004EBC
		public int Number
		{
			get
			{
				return this.m_Error.Number;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00005ED8 File Offset: 0x00004ED8
		public string HelpFile
		{
			get
			{
				return this.m_Error.HelpFile;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00005EF4 File Offset: 0x00004EF4
		public int HelpContext
		{
			get
			{
				return this.m_Error.HelpContext;
			}
		}

		// Token: 0x0400020E RID: 526
		internal global::ADODB.InternalErrors m_Errors;

		// Token: 0x0400020F RID: 527
		internal global::ADODB.Error m_Error;
	}
}
