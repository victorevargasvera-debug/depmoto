using System;
using System.Diagnostics.CodeAnalysis;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004F RID: 79
	[global::System.Serializable]
	public struct TestFDTCmdInfo
	{
		// Token: 0x04000243 RID: 579
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public global::Motorola.Common.Communication.CommonUtil.FDT_CMD _fdtCmd;

		// Token: 0x04000244 RID: 580
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public global::Motorola.Common.Communication.CommonUtil.FDTType _fdtType;

		// Token: 0x04000245 RID: 581
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public ushort _modelType;

		// Token: 0x04000246 RID: 582
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public string _unitVersion;

		// Token: 0x04000247 RID: 583
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public string _forceCpVer;
	}
}
