using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200002A RID: 42
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class FpgaInfo
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00004E60 File Offset: 0x00003060
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00004E68 File Offset: 0x00003068
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.FPGAStatus FPGAControllerStatus { get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00004E71 File Offset: 0x00003071
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00004E79 File Offset: 0x00003079
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.FPGAStatus FPGAWirelineStatus { get; set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00004E82 File Offset: 0x00003082
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00004E8A File Offset: 0x0000308A
		[global::System.Runtime.Serialization.DataMember]
		public bool IsWirelineAvailable { get; set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00004E93 File Offset: 0x00003093
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00004E9B File Offset: 0x0000309B
		[global::System.Runtime.Serialization.DataMember]
		public string FPGAControllerAlternativeVersion { get; set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00004EA4 File Offset: 0x000030A4
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00004EAC File Offset: 0x000030AC
		[global::System.Runtime.Serialization.DataMember]
		public string FPGAControllerFactoryVersion { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00004EB5 File Offset: 0x000030B5
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00004EBD File Offset: 0x000030BD
		[global::System.Runtime.Serialization.DataMember]
		public string FPGAControllerActiveVersion { get; set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00004EC6 File Offset: 0x000030C6
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00004ECE File Offset: 0x000030CE
		[global::System.Runtime.Serialization.DataMember]
		public string FPGAWirelineAlternativeVersion { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00004ED7 File Offset: 0x000030D7
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00004EDF File Offset: 0x000030DF
		[global::System.Runtime.Serialization.DataMember]
		public string FPGAWirelineFactoryVersion { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00004EE8 File Offset: 0x000030E8
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00004EF0 File Offset: 0x000030F0
		[global::System.Runtime.Serialization.DataMember]
		public string FPGAWirelineActiveVersion { get; set; }
	}
}
