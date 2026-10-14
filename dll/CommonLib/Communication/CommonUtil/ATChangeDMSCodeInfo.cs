using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000066 RID: 102
	[global::System.Serializable]
	public class ATChangeDMSCodeInfo : global::System.ICloneable
	{
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00007B82 File Offset: 0x00005D82
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00007B8A File Offset: 0x00005D8A
		public string AccessCode
		{
			get
			{
				return this._accessCode;
			}
			set
			{
				this._accessCode = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00007B93 File Offset: 0x00005D93
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00007B9B File Offset: 0x00005D9B
		public string DefaultAccessCode
		{
			get
			{
				return this._defaultAccessCode;
			}
			set
			{
				this._defaultAccessCode = value;
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00007BA4 File Offset: 0x00005DA4
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.ATChangeDMSCodeInfo atchangeDMSCodeInfo = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.ATChangeDMSCodeInfo;
			atchangeDMSCodeInfo.AccessCode = this.AccessCode;
			atchangeDMSCodeInfo.DefaultAccessCode = this.DefaultAccessCode;
			return atchangeDMSCodeInfo;
		}

		// Token: 0x0400035E RID: 862
		private string _accessCode = string.Empty;

		// Token: 0x0400035F RID: 863
		private string _defaultAccessCode = string.Empty;
	}
}
