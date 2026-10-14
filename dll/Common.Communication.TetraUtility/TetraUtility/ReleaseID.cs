using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000018 RID: 24
	[global::System.Serializable]
	public class ReleaseID
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00006ED9 File Offset: 0x000050D9
		public bool HasFP
		{
			get
			{
				return this._init && this._hasFP;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00006EEB File Offset: 0x000050EB
		public global::Motorola.Common.Communication.TetraUtility.ByteOrder ByteOrder
		{
			get
			{
				if (this._init)
				{
					return this._byteOrder;
				}
				return global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00006EFD File Offset: 0x000050FD
		public global::Motorola.Common.Communication.CommonUtil.fp_info_t FPInfo
		{
			get
			{
				if (this._init && this._hasFP)
				{
					return this._data.flashPackInfo;
				}
				return null;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006F1C File Offset: 0x0000511C
		public bool GetPlatform(out ushort platform)
		{
			platform = 0;
			if (this._init)
			{
				try
				{
					if (this._resType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDWithFP || this._resType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDExtension)
					{
						platform = (ushort)(global::System.Convert.ToByte(this._data.releaseVersionData.Substring(1, 1)) * 16 + global::System.Convert.ToByte(this._data.releaseVersionData.Substring(2, 1)));
					}
					else if (!this._isFrodoRadio)
					{
						platform = global::System.Convert.ToUInt16(this._data.releaseVersionData.Substring(1, 2));
					}
					else
					{
						platform = global::System.Convert.ToUInt16(this._data.releaseVersionData.Substring(1, 2), 16);
					}
				}
				catch
				{
					platform = 0;
					return false;
				}
			}
			return this._init;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00006FE0 File Offset: 0x000051E0
		public bool GetSwVersion(out ushort swVer)
		{
			swVer = 0;
			if (this._init)
			{
				try
				{
					if (this._resType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDWithFP || this._resType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDExtension)
					{
						swVer = (ushort)((int)global::System.Convert.ToByte(this._data.releaseVersionData.Substring(8, 1)) * 4096 + (int)global::System.Convert.ToByte(this._data.releaseVersionData.Substring(9, 1)) * 256 + (int)(global::System.Convert.ToByte(this._data.releaseVersionData.Substring(10, 1)) * 16) + (int)global::System.Convert.ToByte(this._data.releaseVersionData.Substring(11, 1)));
					}
					else if (!this._isFrodoRadio)
					{
						swVer = (ushort)(((int)(((byte)this._data.releaseVersionData[4] - 48) * 10 + ((byte)this._data.releaseVersionData[5] - 48)) << 8) + (int)(((byte)this._data.releaseVersionData[7] - 48) * 10 + ((byte)this._data.releaseVersionData[8] - 48)));
					}
					else
					{
						swVer = (ushort)(((int)(((byte)this._data.releaseVersionData[8] - 48) * 16 + ((byte)this._data.releaseVersionData[9] - 48)) << 8) + (int)(((byte)this._data.releaseVersionData[10] - 48) * 16 + ((byte)this._data.releaseVersionData[11] - 48)));
					}
				}
				catch
				{
					swVer = 0;
					return false;
				}
			}
			return this._init;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00007188 File Offset: 0x00005388
		public bool GetStrSwInfo(out string swVer)
		{
			swVer = "";
			if (this._init)
			{
				try
				{
					if (this._resType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDWithFP || this._resType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDExtension)
					{
						swVer = this._data.releaseVersionData;
					}
					else
					{
						ushort num = 0;
						if (!this.GetSwVersion(out num))
						{
							return false;
						}
						swVer = string.Format("{0:X}", num);
					}
				}
				catch
				{
					swVer = "";
					return false;
				}
			}
			return this._init;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00007210 File Offset: 0x00005410
		public bool GetStrFullSwInfo(out string swVer)
		{
			swVer = "";
			if (this._init)
			{
				try
				{
					if (this._resType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDWithFP || this._resType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDExtension)
					{
						return this.GetStrSwInfo(out swVer);
					}
					string str = "";
					if (!this.GetStrSwInfo(out str))
					{
						return false;
					}
					if (!this._isFrodoRadio)
					{
						swVer = this._data.releaseVersionData.Substring(0, 1) + string.Format("{0:X}", global::System.Convert.ToUInt16(this._data.releaseVersionData.Substring(1, 2))) + ".???." + str;
					}
					else
					{
						swVer = this._data.releaseVersionData.Substring(0, 1) + this._data.releaseVersionData.Substring(1, 2) + ".???." + str;
					}
				}
				catch
				{
					swVer = "";
					return false;
				}
			}
			return this._init;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00007310 File Offset: 0x00005510
		public bool Init(global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder, uint modelType, string cpVer, byte[] imgData, out global::Motorola.Common.Communication.CommonUtil.CommRC rcCode)
		{
			rcCode = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
			bool result;
			try
			{
				if (modelType == 0U || string.IsNullOrEmpty(cpVer) || imgData == null)
				{
					rcCode = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter;
					result = false;
				}
				else
				{
					this._byteOrder = byteOrder;
					this._hasFP = global::Motorola.Common.Communication.TetraUtility.TetraUtil.CheckFPExisting(modelType, cpVer);
					global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel((int)modelType);
					if (model == null)
					{
						rcCode = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0026_RH_CanNotGetRadioModelInfoViaModelType;
						result = false;
					}
					else
					{
						this._resType = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetReleaseIDType(cpVer, model.UniqueModelNumber);
						if (this._resType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDNone)
						{
							rcCode = global::Motorola.Common.Communication.CommonUtil.CommRC.RD5075_FP_ReleaseIDTypeIsNone;
							result = false;
						}
						else
						{
							if (this._resType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDWithFP || this._resType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDExtension)
							{
								this._data.GetInfowithFPfromRaw(imgData);
							}
							else
							{
								this._data.GetInfowithoutFPfromRaw(imgData);
							}
							if (this.IsValidate())
							{
								if (this._hasFP && this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
								{
									global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref this._data.flashPackInfo.pFPEndAdd);
									global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref this._data.flashPackInfo.pFPStartAdd);
								}
								this._init = true;
							}
							else
							{
								rcCode = global::Motorola.Common.Communication.CommonUtil.CommRC.RD5076_FP_InvalidCopyRightStringInReleaseID;
							}
							result = this._init;
						}
					}
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				rcCode = global::Motorola.Common.Communication.CommonUtil.CommRC.RD5050_FP_CommErrFPInitError;
				result = false;
			}
			catch (global::System.NotImplementedException ex2)
			{
				if (ex2.Message.Equals("parse model.FlashPackSupport", global::System.StringComparison.InvariantCultureIgnoreCase))
				{
					rcCode = global::Motorola.Common.Communication.CommonUtil.CommRC.RG0001_CommMetadataNoRecordOfFPSupport;
				}
				result = false;
			}
			catch (global::System.Exception e)
			{
				rcCode = global::Motorola.Common.Communication.CommonUtil.CommRC.RD5050_FP_CommErrFPInitError;
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "Generic Error");
				result = false;
			}
			return result;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000074A8 File Offset: 0x000056A8
		private bool IsValidate()
		{
			return this._data != null && !string.IsNullOrEmpty(this._data.copyrightString) && (this._data.copyrightString.IndexOf("Motorola Inc", global::System.StringComparison.InvariantCulture) != -1 || this._data.copyrightString.IndexOf("Motorola Solutions", global::System.StringComparison.InvariantCulture) != -1);
		}

		// Token: 0x04000046 RID: 70
		private bool _init;

		// Token: 0x04000047 RID: 71
		private global::Motorola.Common.Communication.TetraUtility.ByteOrder _byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian;

		// Token: 0x04000048 RID: 72
		[global::System.NonSerialized]
		private global::Motorola.Common.Communication.TetraUtility.ReleaseIDData _data = new global::Motorola.Common.Communication.TetraUtility.ReleaseIDData();

		// Token: 0x04000049 RID: 73
		private bool _hasFP;

		// Token: 0x0400004A RID: 74
		private bool _isFrodoRadio;

		// Token: 0x0400004B RID: 75
		private global::Motorola.Common.Communication.TetraUtility.ReleaseIDType _resType;
	}
}
