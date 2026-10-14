using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000E RID: 14
	internal sealed class LPEngine
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000688A File Offset: 0x00004A8A
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00006881 File Offset: 0x00004A81
		public global::Motorola.Common.CustomException.CommonErrorCode warningOTAPMessage { get; private set; }

		// Token: 0x060000AE RID: 174 RVA: 0x00006894 File Offset: 0x00004A94
		public LPEngine(string productModId, global::Motorola.Common.Communication.CommonUtil.ModelType modelType, string packageFilePath, int upgradRadioLangSetting)
		{
			this.WriteLPData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			try
			{
				this.UpgradRadioLangSetting = upgradRadioLangSetting;
				this.langPackInfo = new global::Motorola.Common.Communication.LanguagePackInfo(productModId, modelType, packageFilePath);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000068F8 File Offset: 0x00004AF8
		public global::Motorola.Common.Communication.LPUpdateType PrepareWriteRadioLanguagePack(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.Pba.LanguagePackData radioLPData, out global::Motorola.Common.Communication.Pba.LanguagePackData delLPData, out global::Motorola.Common.Communication.Pba.LanguagePackData writeLPData, bool isFlashportProgramming)
		{
			this.RadioLPData = radioLPData;
			this.copyRadioDataToDeleteData();
			global::Motorola.Common.Communication.LPUpdateType radioLPUpdateType = this.GetRadioLPUpdateType(isFlashportProgramming, devInfo);
			delLPData = this.DeleteLPData;
			writeLPData = this.WriteLPData;
			return radioLPUpdateType;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00006930 File Offset: 0x00004B30
		private string GetRadioLanguage()
		{
			string text = "";
			if (this.RadioLPData != null && this.RadioLPData.LanguagePacks.Count > 0)
			{
				foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in this.RadioLPData.LanguagePacks)
				{
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)languagePackBase;
					text = astroFilePackInfo.radioFilePath;
					if (!string.IsNullOrEmpty(text) && text.StartsWith("dat_", global::System.StringComparison.Ordinal))
					{
						try
						{
							text = text.Substring(text.IndexOf("_", global::System.StringComparison.Ordinal) + 1, 5);
							break;
						}
						catch (global::System.Exception)
						{
						}
					}
				}
			}
			return text;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00006A2C File Offset: 0x00004C2C
		private global::Motorola.Common.Communication.LPUpdateType GetRadioLPUpdateType(bool isFlashportProgramming, global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::Motorola.Common.Communication.LanguagePackInfo.FileData> keyValuePair in this.langPackInfo.data)
			{
				string fileName = keyValuePair.Value.fileName;
				string lpkFilePath = this.langPackInfo.LpkFilePath;
				this.PopulateLPData(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.LanguagePack, keyValuePair.Key, fileName, lpkFilePath, keyValuePair.Value.fileSize, this.WriteLPData);
			}
			bool flag = false;
			foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in this.RadioLPData.LanguagePacks)
			{
				if (((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)languagePackBase).radioFilePath == this.langPackInfo.NewLPSupportFile)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				if (devInfo.ConnectionInfo != null && devInfo.ConnectionInfo.ConnectionType.Equals(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap))
				{
					if (this.langPackInfo.TargetLanguage.Equals("English"))
					{
						if (this.IsRadManifestMissing())
						{
							return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
						}
					}
					else if (string.Equals(this.GetRadioLanguage(), this.langPackInfo.LangPackLanguageId, global::System.StringComparison.Ordinal))
					{
						if (this.IsRadManifestMissing())
						{
							this.warningOTAPMessage = global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Missing_one_or_more_files_to_support_radio_language;
							return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
						}
						switch (this.UpgradRadioLangSetting)
						{
						case 0:
						{
							global::Motorola.Common.Communication.LPUpdateType lpupdateType = this.CompareLPFiles(flag);
							if (lpupdateType == global::Motorola.Common.Communication.LPUpdateType.DeleteThenWriteLP || lpupdateType == global::Motorola.Common.Communication.LPUpdateType.WriteThenDeletLP)
							{
								this.warningOTAPMessage = global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Recommended_radio_language_is_available;
							}
							break;
						}
						case 1:
							if (this.langPackInfo.GlobalCriticalFlag)
							{
								global::Motorola.Common.Communication.LPUpdateType lpupdateType2 = this.CompareLPFiles(flag);
								if (lpupdateType2 == global::Motorola.Common.Communication.LPUpdateType.DeleteThenWriteLP || lpupdateType2 == global::Motorola.Common.Communication.LPUpdateType.WriteThenDeletLP)
								{
									this.warningOTAPMessage = global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Recommended_radio_language_is_available;
								}
							}
							break;
						default:
							this.warningOTAPMessage = global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_LPK_update_is_not_support_via_POP25;
							break;
						}
						return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Cannot_be_changed_via_POP25);
				}
				if (this.langPackInfo.TargetLanguage.Equals("English"))
				{
					if (this.RadioLPData.LanguagePacks.Count < 1)
					{
						return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
					}
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.DeleteLPData.LanguagePacks.Find((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
					if (astroFilePackInfo != null)
					{
						astroFilePackInfo.fileType = global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest;
					}
					return global::Motorola.Common.Communication.LPUpdateType.DeleteAllLP;
				}
				else
				{
					if (this.IsRadManifestMissing())
					{
						return this.CalDeleteThenWrite(flag);
					}
					bool flag2 = false;
					if (this.UpgradRadioLangSetting == 1 && string.Equals(this.GetRadioLanguage(), this.langPackInfo.LangPackLanguageId, global::System.StringComparison.Ordinal) && !isFlashportProgramming)
					{
						flag2 = true;
					}
					if (flag2 && !this.langPackInfo.GlobalCriticalFlag)
					{
						return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
					}
					if (this.UpgradRadioLangSetting == 2 && !isFlashportProgramming)
					{
						return this.CalDeleteThenWrite(flag);
					}
					return this.CompareLPFiles(flag);
				}
			}
			else
			{
				if (devInfo.ConnectionInfo != null && devInfo.ConnectionInfo.ConnectionType.Equals(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap))
				{
					if (this.langPackInfo.TargetLanguage.Equals("English"))
					{
						if (this.IsRadManifestMissing())
						{
							return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
						}
					}
					else if (string.Equals(this.GetRadioLanguage(), this.langPackInfo.LangPackLanguageId, global::System.StringComparison.Ordinal))
					{
						if (this.IsRadManifestMissing())
						{
							this.warningOTAPMessage = global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Missing_one_or_more_files_to_support_radio_language;
							return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
						}
						switch (this.UpgradRadioLangSetting)
						{
						case 0:
						{
							global::Motorola.Common.Communication.LPUpdateType lpupdateType3 = this.CompareLPFiles(flag);
							if (lpupdateType3 == global::Motorola.Common.Communication.LPUpdateType.DeleteThenWriteLP || lpupdateType3 == global::Motorola.Common.Communication.LPUpdateType.WriteThenDeletLP)
							{
								this.warningOTAPMessage = global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Recommended_radio_language_is_available;
							}
							break;
						}
						case 1:
							if (this.langPackInfo.GlobalCriticalFlag)
							{
								global::Motorola.Common.Communication.LPUpdateType lpupdateType4 = this.CompareLPFiles(flag);
								if (lpupdateType4 == global::Motorola.Common.Communication.LPUpdateType.DeleteThenWriteLP || lpupdateType4 == global::Motorola.Common.Communication.LPUpdateType.WriteThenDeletLP)
								{
									this.warningOTAPMessage = global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Recommended_radio_language_is_available;
								}
							}
							break;
						default:
							this.warningOTAPMessage = global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_LPK_update_is_not_support_via_POP25;
							break;
						}
						return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Cannot_be_changed_via_POP25);
				}
				if (this.langPackInfo.TargetLanguage.Equals("English"))
				{
					if (this.RadioLPData.LanguagePacks.Count < 1)
					{
						return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
					}
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2 = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.DeleteLPData.LanguagePacks.Find((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
					if (astroFilePackInfo2 != null)
					{
						astroFilePackInfo2.fileType = global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest;
					}
					return global::Motorola.Common.Communication.LPUpdateType.DeleteAllLP;
				}
				else
				{
					if (this.IsRadManifestMissing())
					{
						return this.CalDeleteThenWrite(flag);
					}
					bool flag3 = false;
					if (this.UpgradRadioLangSetting == 1 && string.Equals(this.GetRadioLanguage(), this.langPackInfo.LangPackLanguageId, global::System.StringComparison.Ordinal) && !isFlashportProgramming)
					{
						flag3 = true;
					}
					if (flag3 && !this.langPackInfo.GlobalCriticalFlag)
					{
						return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
					}
					if (this.UpgradRadioLangSetting == 2 && !isFlashportProgramming)
					{
						return this.CalDeleteThenWrite(flag);
					}
					return this.CompareLPFiles(flag);
				}
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006EE8 File Offset: 0x000050E8
		private bool IsRadManifestMissing()
		{
			global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.RadioLPData.LanguagePacks.Find((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
			return astroFilePackInfo == null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00006F1C File Offset: 0x0000511C
		private global::Motorola.Common.Communication.LPUpdateType CalDeleteThenWrite(bool isNewLPSupport)
		{
			int num = this.GetLPDataSize(this.WriteLPData);
			num = num + global::System.Convert.ToInt32(new global::System.IO.FileInfo(this.langPackInfo.ManifestFilePath).Length) + this.iBuffer;
			int lpdataSize = this.GetLPDataSize(this.DeleteLPData);
			if ((long)num > (long)((ulong)this.RadioLPData.AvailableSpace + (ulong)((long)lpdataSize)))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Radio_does_not_have_enough_free_space);
			}
			if (isNewLPSupport)
			{
				this.PopulateManifestData(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest, this.langPackInfo.ManifestFile, this.langPackInfo.ManifestFilePath, 0, this.WriteLPData, global::Motorola.Common.Communication.LPUpdateType.OnlyWriteNoDeleteLP);
				return global::Motorola.Common.Communication.LPUpdateType.NewLPWrite;
			}
			this.PopulateManifestData(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest, this.langPackInfo.ManifestFile, this.langPackInfo.ManifestFilePath, 0, this.WriteLPData, global::Motorola.Common.Communication.LPUpdateType.DeleteThenWriteLP);
			return global::Motorola.Common.Communication.LPUpdateType.DeleteThenWriteLP;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00006FF4 File Offset: 0x000051F4
		private global::Motorola.Common.Communication.LPUpdateType CalculateLPUpdateType(bool isNewLPSupport)
		{
			int num = this.GetLPDataSize(this.WriteLPData);
			num = num + global::System.Convert.ToInt32(new global::System.IO.FileInfo(this.langPackInfo.ManifestFilePath).Length) + this.iBuffer;
			if ((long)num <= (long)((ulong)this.RadioLPData.AvailableSpace))
			{
				this.PopulateManifestData(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest, this.langPackInfo.ManifestFile, this.langPackInfo.ManifestFilePath, 0, this.WriteLPData, global::Motorola.Common.Communication.LPUpdateType.WriteThenDeletLP);
				global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.DeleteLPData.LanguagePacks.Find((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
				if (astroFilePackInfo != null)
				{
					astroFilePackInfo.fileType = global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest;
					astroFilePackInfo.sourceFilePath = this.langPackInfo.ManifestFile;
					astroFilePackInfo.radioFilePath = null;
					astroFilePackInfo.encFileName = this.langPackInfo.ManifestFilePath;
				}
				if (isNewLPSupport)
				{
					return global::Motorola.Common.Communication.LPUpdateType.NewLPWrite;
				}
				return global::Motorola.Common.Communication.LPUpdateType.WriteThenDeletLP;
			}
			else
			{
				int lpdataSize = this.GetLPDataSize(this.DeleteLPData);
				if ((long)num > (long)((ulong)this.RadioLPData.AvailableSpace + (ulong)((long)lpdataSize)))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Radio_does_not_have_enough_free_space);
				}
				this.PopulateManifestData(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest, this.langPackInfo.ManifestFile, this.langPackInfo.ManifestFilePath, 0, this.WriteLPData, global::Motorola.Common.Communication.LPUpdateType.DeleteThenWriteLP);
				if (isNewLPSupport)
				{
					return global::Motorola.Common.Communication.LPUpdateType.NewLPWrite;
				}
				return global::Motorola.Common.Communication.LPUpdateType.DeleteThenWriteLP;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000072FC File Offset: 0x000054FC
		private global::Motorola.Common.Communication.LPUpdateType CompareLPFiles(bool isNewPLSupport)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.WriteLPData.LanguagePacks);
			using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo afpi = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator.Current;
					if (this.DeleteLPData.LanguagePacks.RemoveAll((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == afpi.sourceFilePath) > 0)
					{
						this.WriteLPData.LanguagePacks.RemoveAll((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).sourceFilePath == afpi.sourceFilePath);
					}
				}
			}
			if (this.WriteLPData.LanguagePacks.Count.Equals(0))
			{
				if (isNewPLSupport)
				{
					if (this.DeleteLPData.LanguagePacks.Count.Equals(1))
					{
						bool flag = this.RadioLPData.LanguagePacks.Exists((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.NewLPSupportFile);
						if (flag)
						{
							return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
						}
					}
					if (this.DeleteLPData.LanguagePacks.Count.Equals(2))
					{
						bool flag2 = this.RadioLPData.LanguagePacks.Exists((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
						bool flag3 = this.RadioLPData.LanguagePacks.Exists((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.NewLPSupportFile);
						if (flag2 && flag3)
						{
							return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
						}
					}
				}
				else
				{
					if (this.DeleteLPData.LanguagePacks.Count.Equals(0))
					{
						return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
					}
					if (!this.DeleteLPData.LanguagePacks.Count.Equals(1))
					{
						bool flag4 = this.RadioLPData.LanguagePacks.Exists((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
						if (flag4)
						{
							this.DeleteLPData.LanguagePacks.RemoveAll((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
						}
						return global::Motorola.Common.Communication.LPUpdateType.DeleteAllLP;
					}
					bool flag5 = this.RadioLPData.LanguagePacks.Exists((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
					if (flag5)
					{
						return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
					}
					return global::Motorola.Common.Communication.LPUpdateType.DeleteAllLP;
				}
			}
			else
			{
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.WriteLPData.LanguagePacks);
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase> list2 = null;
				list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.DeleteLPData.LanguagePacks);
				list2.RemoveAll((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
				list2.RemoveAll((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.NewLPSupportFile);
				string text = null;
				foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in list)
				{
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)languagePackBase;
					text = astroFilePackInfo.sourceFilePath;
					foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase2 in list2)
					{
						global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2 = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)languagePackBase2;
						string radioFilePath = astroFilePackInfo2.radioFilePath;
						try
						{
							string a = text.Substring(0, text.LastIndexOf("_", global::System.StringComparison.Ordinal));
							try
							{
								string b = radioFilePath.Substring(0, radioFilePath.LastIndexOf("_", global::System.StringComparison.Ordinal));
								if (a == b)
								{
									global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("(\\d+\\.\\d+\\.\\d+)");
									global::System.Text.RegularExpressions.Match match = regex.Match(text);
									if (!match.Success)
									{
										throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
									}
									global::System.Text.RegularExpressions.Match match2 = regex.Match(radioFilePath);
									if (!match2.Success)
									{
										break;
									}
									global::System.Version version = new global::System.Version(match.Value);
									global::System.Version value = new global::System.Version(match2.Value);
									if (version.CompareTo(value) > 0)
									{
										break;
									}
									if (version.CompareTo(value) < 0)
									{
										this.WriteLPData.LanguagePacks.Remove(astroFilePackInfo);
										this.DeleteLPData.LanguagePacks.Remove(astroFilePackInfo2);
										break;
									}
								}
							}
							catch
							{
							}
						}
						catch
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
						}
					}
				}
			}
			if (isNewPLSupport)
			{
				if (this.WriteLPData.LanguagePacks.Count.Equals(0))
				{
					if (this.DeleteLPData.LanguagePacks.Count.Equals(1))
					{
						bool flag6 = this.RadioLPData.LanguagePacks.Exists((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.NewLPSupportFile);
						if (flag6)
						{
							return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
						}
					}
					if (this.DeleteLPData.LanguagePacks.Count.Equals(2))
					{
						bool flag7 = this.RadioLPData.LanguagePacks.Exists((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
						bool flag8 = this.RadioLPData.LanguagePacks.Exists((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.NewLPSupportFile);
						if (flag7 && flag8)
						{
							return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
						}
					}
				}
			}
			else if (this.WriteLPData.LanguagePacks.Count.Equals(0))
			{
				if (this.DeleteLPData.LanguagePacks.Count.Equals(0))
				{
					return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
				}
				if (!this.DeleteLPData.LanguagePacks.Count.Equals(1))
				{
					bool flag9 = this.RadioLPData.LanguagePacks.Exists((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
					if (flag9)
					{
						this.DeleteLPData.LanguagePacks.RemoveAll((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
					}
					return global::Motorola.Common.Communication.LPUpdateType.DeleteAllLP;
				}
				bool flag10 = this.RadioLPData.LanguagePacks.Exists((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).radioFilePath == this.langPackInfo.ManifestFile);
				if (flag10)
				{
					return global::Motorola.Common.Communication.LPUpdateType.NoLPUpdate;
				}
				return global::Motorola.Common.Communication.LPUpdateType.DeleteAllLP;
			}
			return this.CalculateLPUpdateType(isNewPLSupport);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00007984 File Offset: 0x00005B84
		private void PopulateLPData(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType LPType, string sLpFileId, string sLPFileName, string sEncFileName, int sSize, global::Motorola.Common.Communication.Pba.LanguagePackData LPData)
		{
			global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = new global::Motorola.Common.Communication.Pba.AstroFilePackInfo();
			astroFilePackInfo.fileType = LPType;
			astroFilePackInfo.sourceFilePath = sLPFileName;
			astroFilePackInfo.radioFileSize = sSize;
			astroFilePackInfo.encFileName = sEncFileName;
			astroFilePackInfo.sourceFileId = sLpFileId;
			LPData.LanguagePacks.Add(astroFilePackInfo);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000079CC File Offset: 0x00005BCC
		private void PopulateManifestData(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType LPType, string sLPFileName, string sEncFileName, int sSize, global::Motorola.Common.Communication.Pba.LanguagePackData LPData, global::Motorola.Common.Communication.LPUpdateType updateType)
		{
			global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = new global::Motorola.Common.Communication.Pba.AstroFilePackInfo();
			astroFilePackInfo.fileType = LPType;
			if (updateType == global::Motorola.Common.Communication.LPUpdateType.WriteThenDeletLP)
			{
				astroFilePackInfo.radioFilePath = sLPFileName;
			}
			else if (updateType == global::Motorola.Common.Communication.LPUpdateType.DeleteThenWriteLP || updateType == global::Motorola.Common.Communication.LPUpdateType.OnlyWriteNoDeleteLP)
			{
				astroFilePackInfo.sourceFilePath = sLPFileName;
			}
			astroFilePackInfo.radioFileSize = sSize;
			astroFilePackInfo.encFileName = sEncFileName;
			LPData.LanguagePacks.Add(astroFilePackInfo);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00007A2E File Offset: 0x00005C2E
		private int GetLPDataSize(global::Motorola.Common.Communication.Pba.LanguagePackData LPData)
		{
			return LPData.LanguagePacks.Sum((global::Motorola.Common.Communication.Pba.LanguagePackBase afp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)afp).radioFileSize);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00007A58 File Offset: 0x00005C58
		private void copyRadioDataToDeleteData()
		{
			this.DeleteLPData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			if (!this.RadioLPData.LanguagePacks.Count.Equals(0))
			{
				this.DeleteLPData = this.RadioLPData;
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00007A9C File Offset: 0x00005C9C
		public void Cleanup()
		{
			try
			{
				global::System.Collections.Generic.IEnumerable<string> enumerable = from file in global::System.IO.Directory.EnumerateFiles(this.langPackInfo.LangPackXferFolderPath, "*.lpk", global::System.IO.SearchOption.TopDirectoryOnly)
				select file;
				foreach (string text in enumerable)
				{
					if (text != null && global::System.IO.File.Exists(text))
					{
						global::System.IO.File.SetAttributes(text, global::System.IO.FileAttributes.Normal);
						global::System.IO.File.Delete(text);
					}
				}
				string text2 = global::System.IO.Directory.GetFiles(this.langPackInfo.LangPackXferFolderPath, "lang.mnfk", global::System.IO.SearchOption.TopDirectoryOnly).FirstOrDefault<string>();
				if (text2 != null && global::System.IO.File.Exists(text2))
				{
					global::System.IO.File.SetAttributes(text2, global::System.IO.FileAttributes.Normal);
					global::System.IO.File.Delete(text2);
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x04000029 RID: 41
		private global::Motorola.Common.Communication.Pba.LanguagePackData RadioLPData;

		// Token: 0x0400002A RID: 42
		private global::Motorola.Common.Communication.Pba.LanguagePackData DeleteLPData;

		// Token: 0x0400002B RID: 43
		private global::Motorola.Common.Communication.Pba.LanguagePackData WriteLPData;

		// Token: 0x0400002C RID: 44
		private global::Motorola.Common.Communication.LanguagePackInfo langPackInfo;

		// Token: 0x0400002D RID: 45
		private int iBuffer = 512000;

		// Token: 0x0400002E RID: 46
		private int UpgradRadioLangSetting;
	}
}
