using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Xml.Serialization;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200001E RID: 30
	[global::System.Serializable]
	public class PbaObject
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000039A6 File Offset: 0x00001BA6
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000039AE File Offset: 0x00001BAE
		[global::System.Xml.Serialization.XmlElement("Codeplug")]
		public global::Motorola.Common.Communication.Pba.PackedRadioData CodeplugData { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000039B7 File Offset: 0x00001BB7
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000039BF File Offset: 0x00001BBF
		[global::System.Xml.Serialization.XmlElement("DifferetialCodeplug")]
		public global::Motorola.Common.Communication.Pba.PackedRadioData DifferetialCodeplugData { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000039C8 File Offset: 0x00001BC8
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000039D0 File Offset: 0x00001BD0
		[global::System.Xml.Serialization.XmlElement("InterestTypes")]
		public global::System.Collections.Generic.List<ushort> InterestTypes { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000039D9 File Offset: 0x00001BD9
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000039E1 File Offset: 0x00001BE1
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType> DeletableTypes { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000039EA File Offset: 0x00001BEA
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000039F2 File Offset: 0x00001BF2
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType> IDDeletableTypes { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000039FB File Offset: 0x00001BFB
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00003A03 File Offset: 0x00001C03
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> ValidationFields { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00003A0C File Offset: 0x00001C0C
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00003A14 File Offset: 0x00001C14
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo> ValidationInfos { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00003A1D File Offset: 0x00001C1D
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00003A25 File Offset: 0x00001C25
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> PerserveMasks { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00003A2E File Offset: 0x00001C2E
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00003A36 File Offset: 0x00001C36
		public global::Motorola.Common.Communication.Pba.LocalLanguagaePack LocalLangaugePack { get; set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00003A3F File Offset: 0x00001C3F
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00003A47 File Offset: 0x00001C47
		public global::Motorola.Common.Communication.Pba.LanguagePackData LanguagePackData { get; set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00003A50 File Offset: 0x00001C50
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00003A58 File Offset: 0x00001C58
		public global::Motorola.Common.Communication.Pba.LanguagePackData PreservedLanguagePackInfos { get; set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00003A61 File Offset: 0x00001C61
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00003A69 File Offset: 0x00001C69
		public global::Motorola.Common.Communication.Pba.LanguagePackData TTSLanguagePackData { get; set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00003A72 File Offset: 0x00001C72
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00003A7A File Offset: 0x00001C7A
		public byte[] GeneralInputBuffer { get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00003A83 File Offset: 0x00001C83
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00003A8B File Offset: 0x00001C8B
		public byte[] GeneralOutputBuffer { get; set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00003A94 File Offset: 0x00001C94
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00003A9C File Offset: 0x00001C9C
		public global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode GeneralCommandCode { get; set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00003AA5 File Offset: 0x00001CA5
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00003AAD File Offset: 0x00001CAD
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData UpdateData { get; set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00003AB6 File Offset: 0x00001CB6
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00003ABE File Offset: 0x00001CBE
		public global::Motorola.Common.Communication.Pba.ValidationField TimeStamp { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00003AC7 File Offset: 0x00001CC7
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00003ACF File Offset: 0x00001CCF
		public string FWpath { get; set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00003AD8 File Offset: 0x00001CD8
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public string FlashStrapPath { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00003AE9 File Offset: 0x00001CE9
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00003AF1 File Offset: 0x00001CF1
		public bool IsRetoreJob { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00003AFA File Offset: 0x00001CFA
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00003B02 File Offset: 0x00001D02
		public bool IsFactoryResetOp { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00003B0B File Offset: 0x00001D0B
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00003B13 File Offset: 0x00001D13
		public bool IsStaged { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00003B1C File Offset: 0x00001D1C
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00003B24 File Offset: 0x00001D24
		public int RebootCount { get; set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00003B2D File Offset: 0x00001D2D
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00003B35 File Offset: 0x00001D35
		public string RadioUuid { get; set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00003B3E File Offset: 0x00001D3E
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00003B46 File Offset: 0x00001D46
		public global::Motorola.Common.Communication.Pba.PBBReadData PbbReadData { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00003B4F File Offset: 0x00001D4F
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00003B57 File Offset: 0x00001D57
		public global::Motorola.Common.Communication.Pba.DenaliCPValidationInfo DenaliValidInfo { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00003B60 File Offset: 0x00001D60
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00003B68 File Offset: 0x00001D68
		public global::Motorola.Common.Communication.Pba.CSAReadData CSAReadData { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00003B71 File Offset: 0x00001D71
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00003B79 File Offset: 0x00001D79
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationSpecialField> ValidationSpecialFields { get; set; }

		// Token: 0x06000121 RID: 289 RVA: 0x00003B84 File Offset: 0x00001D84
		public PbaObject()
		{
			this.CodeplugData = new global::Motorola.Common.Communication.Pba.PackedRadioData();
			this.InterestTypes = null;
			this.DifferetialCodeplugData = null;
			this.DeletableTypes = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType>();
			this.IDDeletableTypes = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType>();
			this.PerserveMasks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField>();
			this.ValidationFields = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField>();
			this.ValidationInfos = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo>();
			this.LocalLangaugePack = new global::Motorola.Common.Communication.Pba.LocalLanguagaePack();
			this.LanguagePackData = null;
			this.TTSLanguagePackData = null;
			this.FileSetList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet>();
			this.UpdateData = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
			this.PreUpdateData = new global::Motorola.Common.Communication.Pba.UpdateDeviceData();
			this.TimeStamp = null;
			this.IsStaged = false;
			this.RebootCount = 0;
			this.RadioUuid = null;
			this.PbbReadData = null;
			this.TTSLanguagePackData = null;
			this.ValidationSpecialFields = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationSpecialField>();
			this.GeneralInputBuffer = null;
			this.GeneralOutputBuffer = null;
			this.GeneralCommandCode = global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode.Undefined;
			this.IsRetoreJob = false;
			this.DenaliValidInfo = null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00003C79 File Offset: 0x00001E79
		public void SetCodeplug(global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(ishItemCollection, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			this.CodeplugData.Initialize(ishItemCollection);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00003C90 File Offset: 0x00001E90
		public global::Motorola.Common.Communication.CommonUtil.IshItemCollection GetCodeplugInIshItemCollection()
		{
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			foreach (global::Motorola.Common.Communication.Pba.DataPartition dataPartition in this.CodeplugData.DataPartitions)
			{
				foreach (global::Motorola.Common.Communication.Pba.DataBlock dataBlock in dataPartition.DataBlocks)
				{
					global::Motorola.Common.Communication.CommonUtil.IshHeader headers = new global::Motorola.Common.Communication.CommonUtil.IshHeader(dataPartition.PartitionID, dataBlock.BlockType, dataBlock.BlockID);
					global::Motorola.Common.Communication.CommonUtil.IshItem item = new global::Motorola.Common.Communication.CommonUtil.IshItem(dataBlock.LegthInBits / 8, dataBlock.PacketValue, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined);
					ishItemCollection.Add(headers, item);
				}
			}
			return ishItemCollection;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00003D64 File Offset: 0x00001F64
		public void SetCodeplug(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> fdiBlockList)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(fdiBlockList, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			this.CodeplugData.Initialize(fdiBlockList);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00003D7C File Offset: 0x00001F7C
		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> GetCodeplugInFbiBlockList()
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<ushort, byte[]>>();
			foreach (global::Motorola.Common.Communication.Pba.DataPartition dataPartition in this.CodeplugData.DataPartitions)
			{
				foreach (global::Motorola.Common.Communication.Pba.DataBlock dataBlock in dataPartition.DataBlocks)
				{
					ushort blockID = dataBlock.BlockID;
					byte[] array = new byte[dataBlock.PacketValue.Length];
					global::System.Array.Copy(dataBlock.PacketValue, array, dataBlock.PacketValue.Length);
					list.Add(new global::System.Collections.Generic.KeyValuePair<ushort, byte[]>(blockID, array));
				}
			}
			return list;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00003E50 File Offset: 0x00002050
		public void SetCodeplug(byte[] cpImage)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(cpImage, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			this.CodeplugData.Initialize(cpImage);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00003E68 File Offset: 0x00002068
		public byte[] GetCodeplugInImage()
		{
			byte[] array = null;
			foreach (global::Motorola.Common.Communication.Pba.DataPartition dataPartition in this.CodeplugData.DataPartitions)
			{
				foreach (global::Motorola.Common.Communication.Pba.DataBlock dataBlock in dataPartition.DataBlocks)
				{
					array = new byte[dataBlock.PacketValue.Length];
					global::System.Array.Copy(dataBlock.PacketValue, array, dataBlock.PacketValue.Length);
				}
			}
			return array;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00003F1C File Offset: 0x0000211C
		public void SetLpInfo(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(packs, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			if (this.LanguagePackData == null)
			{
				this.LanguagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			}
			this.LanguagePackData.LanguagePacks.Clear();
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader pack in packs)
			{
				global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo tetraLanguagePackInfo = new global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo();
				tetraLanguagePackInfo.Initialize(pack);
				this.LanguagePackData.LanguagePacks.Add(tetraLanguagePackInfo);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00003FAC File Offset: 0x000021AC
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> GetLPInfoToTetraLPInfo()
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			if (this.LanguagePackData == null)
			{
				this.LanguagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			}
			foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in this.LanguagePackData.LanguagePacks)
			{
				global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo tetraLanguagePackInfo = (global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo)languagePackBase;
				if (tetraLanguagePackInfo != null)
				{
					list.Add(new global::Motorola.Common.Communication.CommonUtil.PackHeader
					{
						compareID = (uint)global::System.Convert.ToInt32(tetraLanguagePackInfo.PackID, global::System.Globalization.CultureInfo.InvariantCulture),
						type = tetraLanguagePackInfo.PackType,
						imageName = tetraLanguagePackInfo.PackFilePath
					});
				}
			}
			return list;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000405C File Offset: 0x0000225C
		public void SetLpInfo(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> packs)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(packs, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			if (this.LanguagePackData == null)
			{
				this.LanguagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			}
			this.LanguagePackData.LanguagePacks.Clear();
			foreach (global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo item in packs)
			{
				this.LanguagePackData.LanguagePacks.Add(item);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000040E0 File Offset: 0x000022E0
		public void SetTTSLpInfo(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> packs)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(packs, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			if (this.TTSLanguagePackData == null)
			{
				this.TTSLanguagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			}
			this.TTSLanguagePackData.LanguagePacks.Clear();
			foreach (global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo item in packs)
			{
				this.TTSLanguagePackData.LanguagePacks.Add(item);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00004164 File Offset: 0x00002364
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> GetLPInfoToPCRLPInfo()
		{
			if (this.LanguagePackData == null)
			{
				this.LanguagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo>();
			global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo item = new global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo();
			foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in this.LanguagePackData.LanguagePacks)
			{
				if ((item = (languagePackBase as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)) != null)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000041E8 File Offset: 0x000023E8
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> GetTTSLPInfo()
		{
			if (this.TTSLanguagePackData == null)
			{
				this.TTSLanguagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo>();
			global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo item = new global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo();
			foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in this.TTSLanguagePackData.LanguagePacks)
			{
				if ((item = (languagePackBase as global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo)) != null)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000426C File Offset: 0x0000246C
		public void SetLlp(byte[] llpData)
		{
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(llpData, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			this.LocalLangaugePack.Initialize(llpData);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004281 File Offset: 0x00002481
		public byte[] GetLlpData()
		{
			return this.LocalLangaugePack.LlpValue;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004290 File Offset: 0x00002490
		public void Serialize(string pbaXmlFilePath)
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.PbaObject));
			using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(pbaXmlFilePath, global::System.IO.FileAccess.Write))
			{
				xmlSerializer.Serialize(stream, this);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000042E0 File Offset: 0x000024E0
		public byte[] Serialize()
		{
			byte[] result = null;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.PbaObject));
				using (global::System.Security.Cryptography.CryptoStream cryptoStream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(memoryStream, false) as global::System.Security.Cryptography.CryptoStream)
				{
					xmlSerializer.Serialize(cryptoStream, this);
					cryptoStream.Clear();
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004454 File Offset: 0x00002654
		public byte[] SerializeToBytes()
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(base.GetType());
			global::Motorola.Common.Communication.Pba.PackedRadioData codeplugData = this.CodeplugData;
			if (codeplugData != null && codeplugData.DataPartitions != null)
			{
				codeplugData.DataPartitions.Sort(delegate(global::Motorola.Common.Communication.Pba.DataPartition p1, global::Motorola.Common.Communication.Pba.DataPartition p2)
				{
					if (p1.PartitionID == p2.PartitionID)
					{
						return string.Compare(p1.PartitionName, p2.PartitionName, global::System.StringComparison.Ordinal);
					}
					return p1.PartitionID.CompareTo(p2.PartitionID);
				});
				foreach (global::Motorola.Common.Communication.Pba.DataPartition dataPartition in codeplugData.DataPartitions)
				{
					dataPartition.DataBlocks.Sort(delegate(global::Motorola.Common.Communication.Pba.DataBlock b1, global::Motorola.Common.Communication.Pba.DataBlock b2)
					{
						if (b1.BlockType == b2.BlockType)
						{
							return b1.BlockID.CompareTo(b2.BlockID);
						}
						return b1.BlockType.CompareTo(b2.BlockType);
					});
				}
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> validationFields = this.ValidationFields;
			if (validationFields != null)
			{
				validationFields.Sort(delegate(global::Motorola.Common.Communication.Pba.ValidationField f1, global::Motorola.Common.Communication.Pba.ValidationField f2)
				{
					if (f1.PartitionID != f2.PartitionID)
					{
						return f1.PartitionID.CompareTo(f2.PartitionID);
					}
					if (f1.BlockType == f2.BlockType)
					{
						return f1.BlockID.CompareTo(f2.BlockID);
					}
					return f1.BlockType.CompareTo(f2.BlockType);
				});
			}
			byte[] buffer;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				memoryStream.SetLength(0L);
				xmlSerializer.Serialize(memoryStream, this);
				buffer = memoryStream.GetBuffer();
			}
			return buffer;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004580 File Offset: 0x00002780
		public static global::Motorola.Common.Communication.Pba.PbaObject DeserializeFrom(string pbaXmlFilePath)
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.PbaObject));
			global::Motorola.Common.Communication.Pba.PbaObject result;
			using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(pbaXmlFilePath, global::System.IO.FileAccess.Read))
			{
				result = (global::Motorola.Common.Communication.Pba.PbaObject)xmlSerializer.Deserialize(stream);
			}
			return result;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000045D4 File Offset: 0x000027D4
		public static global::Motorola.Common.Communication.Pba.PbaObject DeserializeFrom(byte[] fileContent, bool xpba = false)
		{
			if (xpba)
			{
				return global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(fileContent, xpba);
			}
			global::Motorola.Common.Communication.Pba.PbaObject result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(fileContent))
			{
				global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.PbaObject));
				using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(memoryStream, true))
				{
					result = (global::Motorola.Common.Communication.Pba.PbaObject)xmlSerializer.Deserialize(stream);
				}
			}
			return result;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004650 File Offset: 0x00002850
		public static global::Motorola.Common.Communication.Pba.PbaObject DeserializeFromBytes(byte[] buffer, bool xpba = false)
		{
			if (xpba)
			{
				global::System.Collections.Generic.List<byte[]> list = global::Motorola.Common.CommonLib.CombineTool.Decode(buffer);
				buffer = list[0];
			}
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::Motorola.Common.Communication.Pba.PbaObject));
			global::Motorola.Common.Communication.Pba.PbaObject result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buffer))
			{
				result = (global::Motorola.Common.Communication.Pba.PbaObject)xmlSerializer.Deserialize(memoryStream);
			}
			return result;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000046B4 File Offset: 0x000028B4
		public void GenerateDifferetialCodeplug(global::Motorola.Common.Communication.Pba.PbaObject basePba)
		{
			if (basePba == null || basePba.CodeplugData == null || this.CodeplugData == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection = this.GetCodeplugInIshItemCollection();
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection2 = basePba.GetCodeplugInIshItemCollection();
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			global::System.Collections.Generic.HashSet<ushort> hashSet = new global::System.Collections.Generic.HashSet<ushort>();
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair in codeplugInIshItemCollection)
			{
				hashSet.Add(keyValuePair.Key.IshType);
				if (codeplugInIshItemCollection2.ContainsHeader(keyValuePair.Key))
				{
					global::Motorola.Common.Communication.CommonUtil.IshItem item = codeplugInIshItemCollection2[keyValuePair.Key];
					if (!keyValuePair.Value.Data.SequenceEqual(item.Data))
					{
						ishItemCollection.Add(keyValuePair.Key, keyValuePair.Value);
					}
					item.Result = global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success;
					codeplugInIshItemCollection2.Update(keyValuePair.Key, item);
				}
				else
				{
					ishItemCollection.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair2 in codeplugInIshItemCollection2)
			{
				if (keyValuePair2.Value.Result != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
				{
					if (hashSet.Contains(keyValuePair2.Key.IshType))
					{
						if (this.CanDeleteItemOfType(new global::Motorola.Common.Communication.Pba.DataBlockType(keyValuePair2.Key.PartitionNumber, keyValuePair2.Key.IshType)))
						{
							ishItemCollection.Add(keyValuePair2.Key, new global::Motorola.Common.Communication.CommonUtil.IshItem(0, null, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined));
						}
					}
					else if (this.CanDeleteType(new global::Motorola.Common.Communication.Pba.DataBlockType(keyValuePair2.Key.PartitionNumber, keyValuePair2.Key.IshType)))
					{
						global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(keyValuePair2.Key.PartitionNumber, keyValuePair2.Key.IshType, ushort.MaxValue);
						if (!ishItemCollection.ContainsHeader(ishHeader))
						{
							ishItemCollection.Add(ishHeader, new global::Motorola.Common.Communication.CommonUtil.IshItem(0, null, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined));
						}
					}
					else if (this.CanDeleteItemOfType(new global::Motorola.Common.Communication.Pba.DataBlockType(keyValuePair2.Key.PartitionNumber, keyValuePair2.Key.IshType)))
					{
						ishItemCollection.Add(keyValuePair2.Key, new global::Motorola.Common.Communication.CommonUtil.IshItem(0, null, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined));
					}
				}
			}
			if (ishItemCollection.Count > 0)
			{
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
				pbaObject.SetCodeplug(ishItemCollection);
				this.DifferetialCodeplugData = pbaObject.CodeplugData;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000497C File Offset: 0x00002B7C
		private bool CanDeleteType(global::Motorola.Common.Communication.Pba.DataBlockType dataType)
		{
			return this.DeletableTypes == null || this.DeletableTypes.Count == 0 || this.DeletableTypes.Contains(dataType);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000049A1 File Offset: 0x00002BA1
		private bool CanDeleteItemOfType(global::Motorola.Common.Communication.Pba.DataBlockType dataType)
		{
			return this.IDDeletableTypes == null || this.IDDeletableTypes.Count == 0 || this.IDDeletableTypes.Contains(dataType);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00004A20 File Offset: 0x00002C20
		public global::System.Collections.Generic.Dictionary<string, string> FindFiles()
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
			if (this.LanguagePackData != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in this.LanguagePackData.LanguagePacks)
				{
					if (languagePackBase is global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)
					{
						if (!string.IsNullOrEmpty(((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath) && !dictionary.ContainsKey(((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath))
						{
							dictionary.Add(((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath, "LanguagePackSet");
						}
					}
					else if (!string.IsNullOrEmpty(languagePackBase.sourceFilePath) && !dictionary.ContainsKey(languagePackBase.sourceFilePath))
					{
						dictionary.Add(languagePackBase.sourceFilePath, "LanguagePackSet");
					}
				}
			}
			if (this.TTSLanguagePackData != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase2 in this.TTSLanguagePackData.LanguagePacks)
				{
					global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo = (global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo)languagePackBase2;
					if (!string.IsNullOrEmpty(ttslanguagePackInfo.PackFilePath) && !dictionary.ContainsKey(ttslanguagePackInfo.PackFilePath))
					{
						dictionary.Add(ttslanguagePackInfo.PackFilePath, "TTSLanguagePackSet");
					}
				}
			}
			global::Motorola.Common.Communication.Pba.FileSet fileSet = this.FileSetList.Find((global::Motorola.Common.Communication.Pba.FileSet fs) => fs.Name == "VoiceAnnouncement");
			if (fileSet != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem in fileSet.FileItemsList)
				{
					if (!string.IsNullOrEmpty(fileItem.URI) && !dictionary.ContainsKey(fileItem.URI))
					{
						dictionary.Add(fileItem.URI, "VoiceAnnouncement");
					}
				}
			}
			fileSet = this.FileSetList.Find((global::Motorola.Common.Communication.Pba.FileSet fs) => fs.Name == "PBBApplicationInstall");
			if (fileSet != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem2 in fileSet.FileItemsList)
				{
					if (!string.IsNullOrEmpty(fileItem2.URI) && !dictionary.ContainsKey(fileItem2.URI))
					{
						dictionary.Add(fileItem2.URI, "PBBApplicationInstall");
					}
				}
			}
			fileSet = this.FileSetList.Find((global::Motorola.Common.Communication.Pba.FileSet fs) => fs.Name == "PBBCertificate");
			if (fileSet != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem3 in fileSet.FileItemsList)
				{
					if (!string.IsNullOrEmpty(fileItem3.URI) && !dictionary.ContainsKey(fileItem3.URI))
					{
						dictionary.Add(fileItem3.URI, "PBBCertificate");
					}
				}
			}
			fileSet = this.FileSetList.Find((global::Motorola.Common.Communication.Pba.FileSet fs) => fs.Name == "PBBProvisioningPackage");
			if (fileSet != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem4 in fileSet.FileItemsList)
				{
					if (!string.IsNullOrEmpty(fileItem4.URI) && !dictionary.ContainsKey(fileItem4.URI))
					{
						dictionary.Add(fileItem4.URI, "PBBProvisioningPackage");
					}
				}
			}
			fileSet = this.FileSetList.Find((global::Motorola.Common.Communication.Pba.FileSet fs) => fs.Name == "FactoryReset");
			if (fileSet != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem5 in fileSet.FileItemsList)
				{
					if (!string.IsNullOrEmpty(fileItem5.URI) && !dictionary.ContainsKey(fileItem5.URI))
					{
						dictionary.Add(fileItem5.URI, "FactoryReset");
					}
				}
			}
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in this.UpdateData.MemoryImages)
			{
				if (!string.IsNullOrEmpty(radioImage.FilePath) && !dictionary.ContainsKey(radioImage.FilePath) && (radioImage.fileData == null || radioImage.fileData.Count<byte>() == 0))
				{
					dictionary.Add(radioImage.FilePath, radioImage.FileType.ToString());
				}
			}
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage2 in this.PreUpdateData.MemoryImages)
			{
				if (!string.IsNullOrEmpty(radioImage2.FilePath) && !dictionary.ContainsKey(radioImage2.FilePath) && (radioImage2.fileData == null || radioImage2.fileData.Count<byte>() == 0))
				{
					dictionary.Add(radioImage2.FilePath, radioImage2.FileType.ToString());
				}
			}
			return dictionary;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004FF0 File Offset: 0x000031F0
		public void ReplaceFilesPath(global::System.Collections.Generic.Dictionary<string, string> files)
		{
			if (this.LanguagePackData != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in this.LanguagePackData.LanguagePacks)
				{
					if (languagePackBase is global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)
					{
						if (!string.IsNullOrEmpty(((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath) && files.ContainsKey(((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath))
						{
							((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath = files[((global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo)languagePackBase).PackFilePath];
						}
					}
					else if (!string.IsNullOrEmpty(languagePackBase.sourceFilePath) && files.ContainsKey(languagePackBase.sourceFilePath))
					{
						languagePackBase.sourceFilePath = files[languagePackBase.sourceFilePath];
					}
				}
			}
			if (this.TTSLanguagePackData != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase2 in this.TTSLanguagePackData.LanguagePacks)
				{
					global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo ttslanguagePackInfo = (global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo)languagePackBase2;
					if (!string.IsNullOrEmpty(ttslanguagePackInfo.PackFilePath) && files.ContainsKey(ttslanguagePackInfo.PackFilePath))
					{
						ttslanguagePackInfo.PackFilePath = files[ttslanguagePackInfo.PackFilePath];
					}
				}
			}
			global::Motorola.Common.Communication.Pba.FileSet fileSet = this.FileSetList.Find((global::Motorola.Common.Communication.Pba.FileSet fs) => fs.Name == "VoiceAnnouncement");
			if (fileSet != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem in fileSet.FileItemsList)
				{
					if (!string.IsNullOrEmpty(fileItem.URI) && files.ContainsKey(fileItem.URI))
					{
						fileItem.URI = files[fileItem.URI];
					}
				}
			}
			fileSet = this.FileSetList.Find((global::Motorola.Common.Communication.Pba.FileSet fs) => fs.Name == "PBBApplicationInstall");
			if (fileSet != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem2 in fileSet.FileItemsList)
				{
					if (!string.IsNullOrEmpty(fileItem2.URI) && files.ContainsKey(fileItem2.URI))
					{
						fileItem2.URI = files[fileItem2.URI];
					}
				}
			}
			fileSet = this.FileSetList.Find((global::Motorola.Common.Communication.Pba.FileSet fs) => fs.Name == "PBBCertificate");
			if (fileSet != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem3 in fileSet.FileItemsList)
				{
					if (!string.IsNullOrEmpty(fileItem3.URI) && files.ContainsKey(fileItem3.URI))
					{
						fileItem3.URI = files[fileItem3.URI];
					}
				}
			}
			fileSet = this.FileSetList.Find((global::Motorola.Common.Communication.Pba.FileSet fs) => fs.Name == "PBBProvisioningPackage");
			if (fileSet != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem4 in fileSet.FileItemsList)
				{
					if (!string.IsNullOrEmpty(fileItem4.URI) && files.ContainsKey(fileItem4.URI))
					{
						fileItem4.URI = files[fileItem4.URI];
					}
				}
			}
			fileSet = this.FileSetList.Find((global::Motorola.Common.Communication.Pba.FileSet fs) => fs.Name == "FactoryReset");
			if (fileSet != null)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileItem fileItem5 in fileSet.FileItemsList)
				{
					if (!string.IsNullOrEmpty(fileItem5.URI) && files.ContainsKey(fileItem5.URI))
					{
						fileItem5.URI = files[fileItem5.URI];
					}
				}
			}
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in this.UpdateData.MemoryImages)
			{
				if (!string.IsNullOrEmpty(radioImage.FilePath) && files.ContainsKey(radioImage.FilePath))
				{
					radioImage.FilePath = files[radioImage.FilePath];
				}
			}
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage2 in this.PreUpdateData.MemoryImages)
			{
				if (!string.IsNullOrEmpty(radioImage2.FilePath) && files.ContainsKey(radioImage2.FilePath))
				{
					radioImage2.FilePath = files[radioImage2.FilePath];
				}
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005548 File Offset: 0x00003748
		public void ReplaceFilesPathWithMemoryImages(global::System.Collections.Generic.Dictionary<string, string> files)
		{
			using (global::System.Collections.Generic.Dictionary<string, string>.KeyCollection.Enumerator enumerator = files.Keys.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string original = enumerator.Current;
					this.UpdateData.MemoryImages.RemoveAll((global::Motorola.Common.Communication.Pba.RadioImage x) => x.FilePath == original);
					global::Motorola.Common.Communication.Pba.AstroMemoryImage item = new global::Motorola.Common.Communication.Pba.AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FLASHTOFILESYSTEM, files[original]);
					this.UpdateData.MemoryImages.Add(item);
				}
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000055E8 File Offset: 0x000037E8
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> GetFileListBySetName(string setName)
		{
			if (this.FileSetList != null && this.FileSetList.Count > 0)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileSet fileSet in this.FileSetList)
				{
					if (fileSet.Name == setName)
					{
						return fileSet.FileItemsList;
					}
				}
			}
			return null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005664 File Offset: 0x00003864
		public global::Motorola.Common.Communication.Pba.FileSet GetFileSetBySet(string setName)
		{
			if (this.FileSetList != null && this.FileSetList.Count > 0)
			{
				foreach (global::Motorola.Common.Communication.Pba.FileSet fileSet in this.FileSetList)
				{
					if (fileSet.Name == setName)
					{
						return fileSet;
					}
				}
			}
			return null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000056DC File Offset: 0x000038DC
		public bool GenerateFileFromMemory(string fileFolder)
		{
			bool result = false;
			if (!global::System.IO.Directory.Exists(fileFolder))
			{
				global::System.IO.Directory.CreateDirectory(fileFolder);
			}
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in this.UpdateData.MemoryImages)
			{
				if (radioImage.fileData != null && radioImage.fileData.Count<byte>() > 0)
				{
					string text = global::System.IO.Path.Combine(fileFolder, global::System.Guid.NewGuid().ToString("D"));
					using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(text, global::System.IO.FileAccess.Write))
					{
						stream.Write(radioImage.fileData, 0, radioImage.fileData.Length);
					}
					radioImage.fileData = null;
					radioImage.FilePath = text;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00005818 File Offset: 0x00003A18
		public void ResetPBBJobRebootCount()
		{
			if (this.RebootCount > 0)
			{
				if (this.UpdateData.MemoryImages.Count == 0)
				{
					if (this.FileSetList.Count != this.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet m) => m.Name == "PBBProvisioningPackage"))
					{
						if (this.FileSetList.Count != this.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet m) => m.Name == "SimpleTouch"))
						{
							if (this.FileSetList.Count != this.FileSetList.Count((global::Motorola.Common.Communication.Pba.FileSet m) => m.Name == "Configuration"))
							{
								return;
							}
							if (this.FileSetList[0].FileItemsList.Count((global::Motorola.Common.Communication.Pba.FileItem m) => m.Name == "WiFiList" || m.Name == "Si500") <= 0)
							{
								return;
							}
						}
					}
					this.RebootCount = 0;
					return;
				}
				if (this.FileSetList.Count == 0)
				{
					this.RebootCount = 0;
				}
			}
		}

		// Token: 0x04000093 RID: 147
		[global::System.Runtime.Serialization.OptionalField]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> FileItemsList;

		// Token: 0x04000094 RID: 148
		[global::System.Runtime.Serialization.OptionalField]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileSet> FileSetList;

		// Token: 0x04000095 RID: 149
		[global::System.Runtime.Serialization.OptionalField]
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData PreUpdateData;

		// Token: 0x04000096 RID: 150
		public byte[] CodeplugBBFBuffer;

		// Token: 0x04000097 RID: 151
		public string AstroPurchasedFlashCode;
	}
}
