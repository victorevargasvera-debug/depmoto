using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000062 RID: 98
	[global::System.Serializable]
	public class CustomerATMsg : global::System.ICloneable
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000792E File Offset: 0x00005B2E
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00007936 File Offset: 0x00005B36
		public string CustomerMsg
		{
			get
			{
				return this._customerMsg;
			}
			set
			{
				this._customerMsg = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000793F File Offset: 0x00005B3F
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00007947 File Offset: 0x00005B47
		public global::Motorola.Common.Communication.CommonUtil.CommRC OperationResult
		{
			get
			{
				return this._opResult;
			}
			set
			{
				this._opResult = value;
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00007950 File Offset: 0x00005B50
		public object Clone()
		{
			global::Motorola.Common.Communication.CommonUtil.CustomerATMsg customerATMsg = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.CustomerATMsg;
			customerATMsg.CustomerMsg = this.CustomerMsg;
			customerATMsg.OperationResult = this.OperationResult;
			return customerATMsg;
		}

		// Token: 0x04000356 RID: 854
		private string _customerMsg = string.Empty;

		// Token: 0x04000357 RID: 855
		private global::Motorola.Common.Communication.CommonUtil.CommRC _opResult;
	}
}
