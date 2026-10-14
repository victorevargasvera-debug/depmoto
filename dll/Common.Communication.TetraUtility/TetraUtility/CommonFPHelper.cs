using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.LogUtility;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200001A RID: 26
	public static class CommonFPHelper
	{
		// Token: 0x060000DD RID: 221 RVA: 0x00007873 File Offset: 0x00005A73
		public static bool IsRadioSupportFP(string modelNumber, string cpVersion)
		{
			return global::Motorola.Common.Communication.TetraUtility.TetraUtil.CheckFPExisting(modelNumber, cpVersion);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000787C File Offset: 0x00005A7C
		public static byte[] GetReleaseIDImageDataFromSoftwareFile(global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder, uint modelType, global::Motorola.Common.Communication.TetraUtility.Z19File swFile)
		{
			byte[] result;
			try
			{
				if (modelType == 0U || string.IsNullOrEmpty(swFile.CPVer) || swFile.FirmwareRecord.Image == null || byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.UnknowType)
				{
					result = null;
				}
				else
				{
					global::Motorola.Common.Communication.TetraUtility.TetraRadioModelInfo model = global::Motorola.Common.Communication.TetraUtility.CommConfigManager.Instance.GetModel((int)modelType);
					if (model == null)
					{
						result = null;
					}
					else if (global::Motorola.Common.Communication.TetraUtility.TetraUtil.IsGemstonePlatform(model))
					{
						byte[] array = null;
						global::Motorola.Common.Communication.TetraUtility.ReleaseIDType releaseIDType = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetReleaseIDType(swFile.CPVer, model.UniqueModelNumber);
						if (releaseIDType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDNone)
						{
							result = null;
						}
						else
						{
							uint num;
							if (releaseIDType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDWithFP || releaseIDType == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDExtension)
							{
								num = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RELEASE_ID_SIZE_WITH_FP;
							}
							else
							{
								num = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RELEASE_ID_SIZE_WITHOUT_FP;
							}
							uint addr = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetReleaseIDPointer(swFile.CPVer, model.UniqueModelNumber) + global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.GEMSTONE_KERNEL_HEADER;
							if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
							{
								global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref addr);
							}
							if (swFile.FirmwareRecord.Image.GetData(addr, num, out array) && (long)array.Length == (long)((ulong)num))
							{
								result = array;
							}
							else
							{
								result = null;
							}
						}
					}
					else
					{
						global::Motorola.Common.Communication.TetraUtility.ReleaseIDType releaseIDType2 = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetReleaseIDType(swFile.CPVer, model.UniqueModelNumber);
						if (releaseIDType2 == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDNone)
						{
							result = null;
						}
						else
						{
							uint[] array2 = new uint[]
							{
								global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetReleaseIDPointer(swFile.CPVer, model.UniqueModelNumber),
								201654336U,
								202506304U
							};
							byte[] array3 = null;
							foreach (uint addr2 in array2)
							{
								try
								{
									byte[] array5 = null;
									if (swFile.FirmwareRecord.Image.GetData(addr2, 4U, out array5))
									{
										if (array5.Length == 4)
										{
											uint addr3 = global::System.BitConverter.ToUInt32(array5, 0);
											if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
											{
												global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref addr3);
											}
											uint num2;
											if (releaseIDType2 == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDWithFP || releaseIDType2 == global::Motorola.Common.Communication.TetraUtility.ReleaseIDType.ReleaseIDExtension)
											{
												num2 = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RELEASE_ID_SIZE_WITH_FP;
											}
											else
											{
												num2 = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.RELEASE_ID_SIZE_WITHOUT_FP;
											}
											if (swFile.FirmwareRecord.Image.GetData(addr3, num2, out array3))
											{
												if ((long)array3.Length == (long)((ulong)num2))
												{
													break;
												}
											}
										}
									}
								}
								catch
								{
								}
							}
							result = array3;
						}
					}
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(ex, ex.ErrorID);
				result = null;
			}
			catch (global::System.Exception e)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.COMM_LOGGER_NAME).Error(e, "Generic Error");
				result = null;
			}
			return result;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007AE8 File Offset: 0x00005CE8
		public static global::Motorola.Common.Communication.TetraUtility.ReleaseID CreateReleaseIDFromSoftwareFile(global::Motorola.Common.Communication.TetraUtility.Z19File swFile, uint modelType, global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder, uint hwID)
		{
			global::Motorola.Common.Communication.TetraUtility.ReleaseID releaseID = null;
			global::Motorola.Common.Communication.TetraUtility.HwIDRecord hwIDConfig = global::Motorola.Common.Communication.TetraUtility.TetraUtil.GetHwIDConfig(hwID);
			if (hwID == 0U || hwIDConfig == null)
			{
				return releaseID;
			}
			if (hwIDConfig.ProductType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.BOROMIR || hwIDConfig.ProductType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.ARAGORN || hwIDConfig.ProductType == global::Motorola.Common.Communication.CommonUtil.GemstoneRadioType.FRODO)
			{
				if (modelType == 0U || byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.UnknowType)
				{
					modelType = 5603U;
					byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.LittleEndian;
				}
			}
			else
			{
				string text = "";
				string text2 = "";
				byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian;
				modelType = 0U;
				if (!global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.ParseTitleInfo(swFile.FirmwareRecord.Signature, out text, out text2, out byteOrder, out modelType) || modelType == 0U)
				{
					byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian;
					modelType = 65065U;
				}
			}
			byte[] releaseIDImageDataFromSoftwareFile = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.GetReleaseIDImageDataFromSoftwareFile(byteOrder, modelType, swFile);
			if (releaseIDImageDataFromSoftwareFile != null)
			{
				releaseID = new global::Motorola.Common.Communication.TetraUtility.ReleaseID();
				global::Motorola.Common.Communication.CommonUtil.CommRC commRC = global::Motorola.Common.Communication.CommonUtil.CommRC.RD0000_CommSuccess;
				if (!releaseID.Init(byteOrder, modelType, swFile.CPVer, releaseIDImageDataFromSoftwareFile, out commRC))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5050_FP_CommErrFPInitError.ToString(), "Internal Error is: " + commRC.ToString());
				}
			}
			return releaseID;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00007BC4 File Offset: 0x00005DC4
		public static void ScanInfo(global::Motorola.Common.Communication.TetraUtility.Z19File swFile, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, string hwConfigStr)
		{
			packs = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> dictionary = swFile.FlashPacks(hwConfigStr);
			if (dictionary == null)
			{
				return;
			}
			if (hwConfigStr == "ForiTM")
			{
				global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.ScanInfoForITM(packs, dictionary, resID);
				return;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::Motorola.Common.Communication.TetraUtility.SRecord> keyValuePair in dictionary)
			{
				global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.CreateInfoFromFPImage(keyValuePair.Value.Image, resID);
				if (packHeader != null)
				{
					packs.Add(packHeader);
				}
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00007C54 File Offset: 0x00005E54
		public static void ReadFlashPacksFromFile(string filePath, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, string swVer, global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder, uint modelType, uint hwID, string hwConfigStr)
		{
			packs = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			global::Motorola.Common.Communication.TetraUtility.Z19File z19File = global::Motorola.Common.Communication.TetraUtility.FPTools.LoadSoftwareFile(filePath);
			if (z19File == null)
			{
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.ReleaseID releaseID = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.CreateReleaseIDFromSoftwareFile(z19File, modelType, byteOrder, hwID);
			if (releaseID == null)
			{
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.ScanInfo(z19File, out packs, releaseID, hwConfigStr);
			for (int i = packs.Count - 1; i >= 0; i--)
			{
				packs[i].select = false;
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007CB4 File Offset: 0x00005EB4
		public static void ReadLanguagePacksFromFile(string filePath, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, string swVer, global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder, uint modelType, uint hwID, string hwConfigStr)
		{
			packs = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			global::Motorola.Common.Communication.TetraUtility.Z19File z19File = global::Motorola.Common.Communication.TetraUtility.FPTools.LoadSoftwareFile(filePath);
			if (z19File == null)
			{
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.ReleaseID releaseID = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.CreateReleaseIDFromSoftwareFile(z19File, modelType, byteOrder, hwID);
			if (releaseID == null)
			{
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.ScanInfo(z19File, out packs, releaseID, hwConfigStr);
			for (int i = packs.Count - 1; i >= 0; i--)
			{
				packs[i].select = false;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00007D14 File Offset: 0x00005F14
		public static bool AnalizeHeader(global::Motorola.Common.Communication.CommonUtil.fp_header_t header, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID, global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder)
		{
			bool flag = false;
			if (header.pack_type == 100)
			{
				flag = true;
			}
			bool result = false;
			if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.UnknowType)
			{
				return result;
			}
			global::Motorola.Common.Communication.TetraUtility.FPBase.HeaderByteReverse(header, byteOrder);
			for (int i = 0; i < resID.FPInfo.fp_packs.Length; i++)
			{
				if (header.pack_type == resID.FPInfo.fp_packs[i].pack_type)
				{
					if (flag)
					{
						if (header.pack_product_platform == resID.FPInfo.fp_packs[i].fp_product_platform && header.pack_release_number == resID.FPInfo.fp_packs[i].fp_release_num && header.pack_revision_number == resID.FPInfo.fp_packs[i].fp_revision_num)
						{
							result = true;
							break;
						}
					}
					else if (header.pack_product_platform == resID.FPInfo.fp_packs[i].fp_product_platform && header.pack_release_number == resID.FPInfo.fp_packs[i].fp_release_num && header.pack_revision_number == resID.FPInfo.fp_packs[i].fp_revision_num && header.pack_sub_revision_num >= resID.FPInfo.fp_packs[i].fp_sub_revision_num && header.pack_product_platform != 0)
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00007E4C File Offset: 0x0000604C
		public static global::Motorola.Common.Communication.CommonUtil.PackHeader CreateInfo(global::Motorola.Common.Communication.CommonUtil.fp_header_t header, byte[] data, global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder)
		{
			if (data == null || data.Length == 0 || header.pack_size == 0U)
			{
				return null;
			}
			global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader = new global::Motorola.Common.Communication.CommonUtil.PackHeader();
			packHeader.type = (global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t)header.pack_type;
			packHeader.size = header.pack_size;
			packHeader.productPlatform = (uint)header.pack_product_platform;
			packHeader.releaseNumber = (uint)header.pack_release_number;
			packHeader.revision = (uint)header.pack_revision_number;
			packHeader.subRevision = (uint)header.pack_sub_revision_num;
			uint byteAlignedAddress = global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(0U, 16U, 4);
			byte pack_type = header.pack_type;
			switch (pack_type)
			{
			case 1:
			{
				global::Motorola.Common.Communication.CommonUtil.fp_language_pack_info_t fp_language_pack_info_t = new global::Motorola.Common.Communication.CommonUtil.fp_language_pack_info_t();
				fp_language_pack_info_t.GetDatafromRaw(data, byteAlignedAddress);
				if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
				{
					global::Motorola.Common.Communication.TetraUtility.FPLanguagePack.InfoByteReverse(fp_language_pack_info_t);
				}
				packHeader.imageName = global::Motorola.Common.Communication.TetraUtility.FPLanguagePack.GetImageName(header, fp_language_pack_info_t);
				packHeader.packid = string.Format("L{0:D}", fp_language_pack_info_t.language_id);
				packHeader.compareID = (uint)fp_language_pack_info_t.language_id;
				packHeader.languageFontID = fp_language_pack_info_t.lang_font_id;
				break;
			}
			case 2:
			{
				global::Motorola.Common.Communication.CommonUtil.fp_font_pack_info_t fp_font_pack_info_t = new global::Motorola.Common.Communication.CommonUtil.fp_font_pack_info_t();
				fp_font_pack_info_t.GetDatafromRaw(data, byteAlignedAddress);
				if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
				{
					global::Motorola.Common.Communication.TetraUtility.FPFontPack.InfoByteReverse(fp_font_pack_info_t);
				}
				packHeader.imageName = global::Motorola.Common.Communication.TetraUtility.FPFontPack.GetImageName(header, fp_font_pack_info_t);
				packHeader.packid = string.Format("F{0:D}", fp_font_pack_info_t.font_id);
				packHeader.compareID = fp_font_pack_info_t.font_id;
				packHeader.languageFontID = fp_font_pack_info_t.lang_font_id;
				break;
			}
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
				packHeader.imageName = global::Motorola.Common.Communication.TetraUtility.FPMandatoryPack.GetImageName(header);
				packHeader.packid = string.Format("M{0:D}", header.pack_type);
				break;
			default:
				if (pack_type == 100)
				{
					global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t fp_lls_pack_info_t = new global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t();
					fp_lls_pack_info_t.GetDatafromRaw(data, byteAlignedAddress);
					if (byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
					{
						global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.InfoByteReverse(fp_lls_pack_info_t);
					}
					packHeader.imageName = global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.GetImageName(header, fp_lls_pack_info_t);
					packHeader.packid = "";
					packHeader.compareID = (uint)fp_lls_pack_info_t.pack_based_language;
					packHeader.languageFontID = 0U;
				}
				break;
			}
			return packHeader;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000802B File Offset: 0x0000622B
		public static bool IsMandatoryPack(global::Motorola.Common.Communication.CommonUtil.PackHeader pack)
		{
			return pack.type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.FONT_PACK && pack.type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LANGUAGE_PACK && pack.type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000804C File Offset: 0x0000624C
		public static void MergePackHeaders(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> radioPack, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> filePack, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> returnPack)
		{
			returnPack = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			if (radioPack == null || filePack == null)
			{
				return;
			}
			if (radioPack.Count > 0)
			{
				for (int i = filePack.Count - 1; i >= 0; i--)
				{
					if (global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.IsMandatoryPack(filePack[i]))
					{
						filePack.RemoveAt(i);
					}
				}
			}
			for (int j = 0; j < radioPack.Count; j++)
			{
				for (int k = filePack.Count - 1; k >= 0; k--)
				{
					if (string.Equals(radioPack[j].imageName, filePack[k].imageName))
					{
						filePack.RemoveAt(k);
					}
				}
			}
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader in radioPack)
			{
				returnPack.Add((global::Motorola.Common.Communication.CommonUtil.PackHeader)packHeader.Clone());
			}
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader2 in filePack)
			{
				returnPack.Add((global::Motorola.Common.Communication.CommonUtil.PackHeader)packHeader2.Clone());
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000817C File Offset: 0x0000637C
		public static bool CheckDependences(string imageName, bool selected, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> arrAffectedPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks)
		{
			bool flag = true;
			arrAffectedPacks = null;
			if (string.IsNullOrEmpty(imageName))
			{
				return false;
			}
			global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.FindInfo(imageName, allPacks);
			if (packHeader == null)
			{
				flag = false;
			}
			if (flag)
			{
				arrAffectedPacks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
				for (int i = 0; i < allPacks.Count; i++)
				{
					global::Motorola.Common.Communication.CommonUtil.FP_DEPENDENCE_E dependence = packHeader.GetDependence(allPacks[i], selected);
					if (dependence != global::Motorola.Common.Communication.CommonUtil.FP_DEPENDENCE_E.NONE)
					{
						global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader2 = (global::Motorola.Common.Communication.CommonUtil.PackHeader)allPacks[i].Clone();
						global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.TranslateDependenceAction(dependence, packHeader2);
						arrAffectedPacks.Add(packHeader2);
					}
				}
			}
			return flag;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000081FC File Offset: 0x000063FC
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> ConstructPackList(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packList, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks)
		{
			if (packList == null || allPacks == null)
			{
				return null;
			}
			bool flag = true;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = null;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			int num = 0;
			while (num < packList.Count && flag)
			{
				flag = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.CheckDependences(packList[num].imageName, true, out list, allPacks);
				if (flag && list != null && list.Count >= 1)
				{
					for (int i = 0; i < list.Count; i++)
					{
						int num2 = 0;
						while (num2 < list2.Count && !(list[i].imageName == list2[num2].imageName))
						{
							num2++;
						}
						if (num2 >= list2.Count)
						{
							list2.Add(list[i]);
						}
					}
				}
				num++;
			}
			if (flag)
			{
				for (int j = 0; j < packList.Count; j++)
				{
					int num3 = 0;
					while (num3 < list2.Count && !(packList[j].imageName == list2[num3].imageName))
					{
						num3++;
					}
					if (num3 >= list2.Count)
					{
						list2.Add((global::Motorola.Common.Communication.CommonUtil.PackHeader)packList[j].Clone());
					}
				}
				return list2;
			}
			return null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00008338 File Offset: 0x00006538
		public static global::Motorola.Common.Communication.CommonUtil.PackHeader FindInfo(string imageName, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks)
		{
			if (string.IsNullOrEmpty(imageName))
			{
				return null;
			}
			bool flag = false;
			global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader = null;
			for (int i = 0; i < allPacks.Count; i++)
			{
				packHeader = allPacks[i];
				if (string.Equals(packHeader.imageName, imageName, global::System.StringComparison.Ordinal))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				return packHeader;
			}
			return null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00008388 File Offset: 0x00006588
		public static bool VerifyLanguagePacks(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> returnPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> mandatoryPacks, uint fpSize)
		{
			if (returnPacks == null || allPacks == null || mandatoryPacks == null)
			{
				return false;
			}
			bool flag = true;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader in returnPacks)
			{
				list.Add(global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.FindInfo(packHeader.imageName, allPacks));
			}
			if ((long)(list.Count + mandatoryPacks.Count) > 39L)
			{
				flag = false;
			}
			if (flag)
			{
				uint num = 0U;
				for (int i = 0; i < list.Count; i++)
				{
					global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader2 = list[i];
					for (int j = i + 1; j < list.Count; j++)
					{
						global::Motorola.Common.Communication.CommonUtil.PackHeader pack = list[j];
						if (packHeader2.IsConflict(pack))
						{
							flag = false;
							break;
						}
					}
					if (packHeader2.type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LANGUAGE_PACK)
					{
						num += 1U;
					}
				}
				if (flag && num > 18U)
				{
					flag = false;
				}
				if (flag)
				{
					foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader item in mandatoryPacks)
					{
						list.Add(item);
					}
					uint num2 = 0U;
					for (int k = 0; k < list.Count; k++)
					{
						num2 += list[k].size;
					}
					if (num2 > fpSize)
					{
						flag = false;
					}
				}
			}
			return flag;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000084F8 File Offset: 0x000066F8
		public static bool VerifyGemstoneBMPLanguagePacks(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> allPacks, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> mandatoryPacks, uint flashPackMemorySize)
		{
			bool flag = true;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader in packs)
			{
				list.Add(global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.FindInfo(packHeader.imageName, allPacks));
			}
			for (int i = 0; i < list.Count; i++)
			{
				global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader2 = list[i];
				for (int j = i + 1; j < list.Count; j++)
				{
					global::Motorola.Common.Communication.CommonUtil.PackHeader pack = list[j];
					if (packHeader2.IsGemstoneBMPFPConflict(pack))
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				int num = list.Count + mandatoryPacks.Count;
				flag = (num <= 128);
				if (flag)
				{
					uint num2 = 0U;
					if (list != null && list.Count != 0)
					{
						foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader3 in list)
						{
							num2 += packHeader3.size + 32U;
						}
					}
					if (mandatoryPacks != null && mandatoryPacks.Count != 0)
					{
						foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader4 in mandatoryPacks)
						{
							num2 += packHeader4.size + 32U;
						}
					}
					flag = (num2 <= flashPackMemorySize);
				}
			}
			return flag;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00008690 File Offset: 0x00006890
		public static void SplitPacksFromFile(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> swPacks, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> mandatoryPacks, out global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> notMandatoryPacks)
		{
			mandatoryPacks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			notMandatoryPacks = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			if (swPacks == null || swPacks.Count == 0)
			{
				return;
			}
			foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader in swPacks)
			{
				if (global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.IsMandatoryPack(packHeader))
				{
					mandatoryPacks.Add(packHeader);
				}
				else
				{
					notMandatoryPacks.Add(packHeader);
				}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000870C File Offset: 0x0000690C
		private static bool ParseTitleInfo(string sig, out string owner, out string version, out global::Motorola.Common.Communication.TetraUtility.ByteOrder byteOrder, out uint modelType)
		{
			owner = "";
			version = "";
			byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian;
			modelType = 0U;
			if (string.IsNullOrEmpty(sig))
			{
				return false;
			}
			bool result = false;
			string[] array = sig.Split(new char[]
			{
				'^'
			});
			foreach (string text in array)
			{
				int num = text.IndexOf('=');
				if (num != -1)
				{
					string a = text.Substring(0, num);
					string text2 = text.Substring(num + 1);
					if (string.Equals(a, "v", global::System.StringComparison.OrdinalIgnoreCase))
					{
						version = text2;
						result = true;
					}
					else if (string.Equals(a, "o", global::System.StringComparison.OrdinalIgnoreCase))
					{
						uint num2 = global::System.Convert.ToUInt32(text2);
						if (num2 != 0U)
						{
							if (num2 != 3U)
							{
								byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian;
							}
							else
							{
								byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian;
							}
						}
						else
						{
							byteOrder = global::Motorola.Common.Communication.TetraUtility.ByteOrder.LittleEndian;
						}
						result = true;
					}
					else if (string.Equals(a, "s", global::System.StringComparison.OrdinalIgnoreCase))
					{
						owner = text2;
						result = true;
					}
					else if (string.Equals(a, "m", global::System.StringComparison.OrdinalIgnoreCase))
					{
						modelType = global::System.Convert.ToUInt32(text2);
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00008818 File Offset: 0x00006A18
		private static void ScanInfoForITM(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> packs, global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> flashPacks, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
			global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>>();
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::Motorola.Common.Communication.TetraUtility.SRecord> keyValuePair in flashPacks)
			{
				global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader = global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.CreateInfoFromFPImage(keyValuePair.Value.Image, resID);
				if (packHeader != null)
				{
					string text = keyValuePair.Key.Replace('/', '\\');
					int num = text.LastIndexOf('\\');
					if (num < 0)
					{
						list.Add(packHeader);
					}
					else
					{
						string key = text.Substring(0, num).Trim();
						if (dictionary.ContainsKey(key))
						{
							dictionary[key].Add(packHeader);
						}
						else
						{
							dictionary.Add(key, new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>
							{
								packHeader
							});
						}
					}
				}
			}
			packs.AddRange(list);
			if (dictionary.Count > 0)
			{
				foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader2 in list)
				{
					if (packHeader2.type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LANGUAGE_PACK)
					{
						uint num2 = 0U;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
						foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>> keyValuePair2 in dictionary)
						{
							uint num3 = 0U;
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list3 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
							foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader3 in keyValuePair2.Value)
							{
								if (packHeader3.type == global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.FONT_PACK && packHeader3.languageFontID == packHeader2.languageFontID)
								{
									list3.Add(packHeader3);
									num3 += packHeader3.size;
								}
							}
							if (num3 > num2)
							{
								num2 = num3;
								list2.Clear();
								list2.AddRange(list3);
							}
						}
						foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader item in list2)
						{
							if (!packs.Contains(item))
							{
								packs.Add(item);
							}
						}
					}
				}
				uint num4 = 0U;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list4 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>> keyValuePair3 in dictionary)
				{
					uint num5 = 0U;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader> list5 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.PackHeader>();
					foreach (global::Motorola.Common.Communication.CommonUtil.PackHeader packHeader4 in keyValuePair3.Value)
					{
						if (packHeader4.type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LANGUAGE_PACK && packHeader4.type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.FONT_PACK && packHeader4.type != global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t.LLS_PACK)
						{
							list5.Add(packHeader4);
							num5 += packHeader4.size;
						}
					}
					if (num5 > num4)
					{
						num4 = num5;
						list4.Clear();
						list4.AddRange(list5);
					}
				}
				packs.AddRange(list4);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00008BB4 File Offset: 0x00006DB4
		private static global::Motorola.Common.Communication.CommonUtil.PackHeader CreateInfoFromFPImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage fpImage, global::Motorola.Common.Communication.TetraUtility.ReleaseID resID)
		{
			if (fpImage == null || fpImage.Size == 0U)
			{
				return null;
			}
			fpImage.CompactUnits();
			global::Motorola.Common.Communication.CommonUtil.fp_header_t fp_header_t = new global::Motorola.Common.Communication.CommonUtil.fp_header_t();
			fp_header_t.GetHeaderfromRawData(fpImage[0].Data);
			if (global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.AnalizeHeader(fp_header_t, resID, resID.ByteOrder))
			{
				return global::Motorola.Common.Communication.TetraUtility.CommonFPHelper.CreateInfo(fp_header_t, fpImage[0].Data, resID.ByteOrder);
			}
			return null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00008C18 File Offset: 0x00006E18
		private static void TranslateDependenceAction(global::Motorola.Common.Communication.CommonUtil.FP_DEPENDENCE_E dependence, global::Motorola.Common.Communication.CommonUtil.PackHeader pInfo)
		{
			switch (dependence)
			{
			case global::Motorola.Common.Communication.CommonUtil.FP_DEPENDENCE_E.SELECT_DISABLE:
				pInfo.select = true;
				pInfo.enable = false;
				return;
			case global::Motorola.Common.Communication.CommonUtil.FP_DEPENDENCE_E.UNSELECT_ENABLE:
				pInfo.select = false;
				pInfo.enable = true;
				return;
			default:
				return;
			}
		}

		// Token: 0x0400005E RID: 94
		private const uint RELESE_ID_POINTER_NGCH_NMM = 201654336U;

		// Token: 0x0400005F RID: 95
		private const uint RELESE_ID_POINTER_NGCH_VNM = 202506304U;

		// Token: 0x04000060 RID: 96
		private const int FLASHPACK_SLOTS_NUMBER = 128;

		// Token: 0x04000061 RID: 97
		private const uint FLASHPACK_IMAGE_HEADER_SIZE = 32U;

		// Token: 0x04000062 RID: 98
		public const uint MAX_NUMBER_FLASH_PACKS_WITHOUT_LLP = 39U;

		// Token: 0x04000063 RID: 99
		public const uint MAX_NUMBER_LANGUAGE_PACKS = 18U;
	}
}
