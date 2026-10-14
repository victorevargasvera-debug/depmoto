using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace System.Data.SQLite
{
	// Token: 0x02000051 RID: 81
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal sealed class SR
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x00020C5C File Offset: 0x0002005C
		internal SR()
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00020C70 File Offset: 0x00020070
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(global::System.Data.SQLite.SR.resourceMan, null))
				{
					global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager("System.Data.SQLite.SR", typeof(global::System.Data.SQLite.SR).Assembly);
					global::System.Data.SQLite.SR.resourceMan = resourceManager;
				}
				return global::System.Data.SQLite.SR.resourceMan;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00020CB0 File Offset: 0x000200B0
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00020CC4 File Offset: 0x000200C4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::System.Data.SQLite.SR.resourceCulture;
			}
			set
			{
				global::System.Data.SQLite.SR.resourceCulture = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00020CD8 File Offset: 0x000200D8
		internal static string DataTypes
		{
			get
			{
				return global::System.Data.SQLite.SR.ResourceManager.GetString("DataTypes", global::System.Data.SQLite.SR.resourceCulture);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00020CFC File Offset: 0x000200FC
		internal static string Keywords
		{
			get
			{
				return global::System.Data.SQLite.SR.ResourceManager.GetString("Keywords", global::System.Data.SQLite.SR.resourceCulture);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00020D20 File Offset: 0x00020120
		internal static string MetaDataCollections
		{
			get
			{
				return global::System.Data.SQLite.SR.ResourceManager.GetString("MetaDataCollections", global::System.Data.SQLite.SR.resourceCulture);
			}
		}

		// Token: 0x040001C9 RID: 457
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x040001CA RID: 458
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
