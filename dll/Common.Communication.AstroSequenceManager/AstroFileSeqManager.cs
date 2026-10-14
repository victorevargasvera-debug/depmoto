using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000007 RID: 7
	public class AstroFileSeqManager : global::Motorola.Common.Communication.AstroCpsSequenceManager, global::Motorola.Common.Communication.IDepotSequenceManager
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004A08 File Offset: 0x00002C08
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00004A10 File Offset: 0x00002C10
		public new global::Motorola.Common.Communication.CommonUtil.SessionParameter SessionParam
		{
			get
			{
				return this.m_SessionParameter;
			}
			set
			{
				this.m_SessionParameter = value;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004A19 File Offset: 0x00002C19
		public AstroFileSeqManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
			if (sessionParameter != null)
			{
				this.m_SessionParameter = sessionParameter;
				return;
			}
			this.m_SessionParameter = new global::Motorola.Common.Communication.CommonUtil.SessionParameter(0, false);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004A3C File Offset: 0x00002C3C
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			base.OpenSession(sessionID, operation);
			if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)
			{
				if (this.SessionParam.ArchiveSession)
				{
					ushort num;
					ushort num2;
					base.IOController.ComponentSession(7, sessionID, out num, out num2);
					if (base.IOController.SessionCommandReply.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter && base.IOController.RetryDifferentialWriteNotSupported)
					{
						base.IOController.ComponentSession(3, sessionID, out num, out num2);
						return;
					}
				}
				else
				{
					ushort num;
					ushort num2;
					base.IOController.ComponentSession(3, sessionID, out num, out num2);
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004AB8 File Offset: 0x00002CB8
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
			{
				if (this.SessionParam.ArchiveSession)
				{
					ushort num;
					ushort num2;
					base.IOController.ComponentSession(1025, sessionID, out num, out num2);
					if (base.IOController.SessionCommandReply.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter && base.IOController.RetryDifferentialWriteNotSupported)
					{
						base.IOController.ComponentSession(1, sessionID, out num, out num2);
					}
				}
				else
				{
					ushort num;
					ushort num2;
					base.IOController.ComponentSession(1, sessionID, out num, out num2);
				}
				this.ExitReadProgramMode();
				return;
			}
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
			{
				try
				{
					if (this.SessionParam.ArchiveSession)
					{
						if (!pendingDeploy)
						{
							ushort num;
							ushort num2;
							base.IOController.ComponentSession(1056, sessionID, out num, out num2);
							if (base.IOController.SessionCommandReply.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter && base.IOController.RetryDifferentialWriteNotSupported)
							{
								base.IOController.ComponentSession(32, sessionID, out num, out num2);
							}
						}
						else
						{
							ushort num;
							ushort num2;
							base.IOController.ComponentSession(1, sessionID, out num, out num2);
						}
					}
					else if (!pendingDeploy)
					{
						ushort num;
						ushort num2;
						base.IOController.ComponentSession(32, sessionID, out num, out num2);
					}
					else
					{
						ushort num;
						ushort num2;
						base.IOController.ComponentSession(1, sessionID, out num, out num2);
					}
					this.ExitWriteProgramMode();
				}
				catch (global::System.Exception)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CloseSession_Fail);
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004BF8 File Offset: 0x00002DF8
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			byte[] buffer = writePBA.SerializeToBytes();
			base.ValidateCodeplugVersion(writePBA);
			if (!base.DifferentialWriteCapableRadio)
			{
				base.WriteValidation(writePBA);
			}
			if (writePBA.LanguagePackData != null && writePBA.LanguagePackData.LanguagePacks.Count > 0)
			{
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.SetCurrentScope(0, 60);
				}
				this.WriteLanguagePacks(writePBA.LanguagePackData);
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.SetCurrentScope(61, 100);
				}
			}
			if (base.DifferentialWriteCapableRadio && writePBA.DifferetialCodeplugData != null)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Diff Write..", new object[0]);
				this.WriteRadioCodeplug(new global::Motorola.Common.Communication.Pba.PbaObject
				{
					CodeplugData = writePBA.DifferetialCodeplugData
				}, false);
			}
			else
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Full Write..", new object[0]);
				this.WriteRadioCodeplug(writePBA, false);
			}
			pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(buffer, false);
			pbaObject.CodeplugData.ArchiveSessionID = sessionID;
			return pbaObject;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004CF0 File Offset: 0x00002EF0
		public override void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
			}
			this.WriteRadioCodeplug(writePBA, true);
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004D3F File Offset: 0x00002F3F
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			return this.ReadDeviceEX(referencePba, sessionID);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004D4C File Offset: 0x00002F4C
		protected global::Motorola.Common.Communication.Pba.PbaObject ManagedReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			pbaObject = this.ReadDeviceEX(referencePba, sessionID);
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = this.ReadLanguagePacksInfo();
			if (languagePackData != null)
			{
				pbaObject.LanguagePackData = languagePackData;
			}
			return pbaObject;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004D88 File Offset: 0x00002F88
		private global::Motorola.Common.Communication.Pba.PbaObject ReadDeviceEX(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
			}
			string text = base.IOController.QueryCodeplugVersion();
			ushort compInstance = 2;
			uint num;
			string text2;
			base.IOController.ReadComponentFile(global::Motorola.Common.Communication.Rcmp.XcmpComponentRead.ComponentType.IshCodeplug, compInstance, out num, out text2);
			string text3 = 1U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "_" + compInstance.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "_1.cmp";
			string text4 = text2;
			char[] trimChars = new char[1];
			text2 = text4.Trim(trimChars);
			string filePath = string.IsNullOrEmpty(text2) ? text3 : ("/" + text3);
			ushort filePartition = 0;
			byte[] fileData = null;
			using (global::System.IO.MemoryStream memoryStream = base.IOController.FileRead(filePartition, filePath, base.ProgressIndicator))
			{
				fileData = memoryStream.ToArray();
			}
			global::Motorola.Common.Communication.CommonFile.PartitionCommonFile partitionCommonFile = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true);
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = partitionCommonFile.Deserialize(fileData);
			char[] trimChars2 = new char[]
			{
				'\0',
				' ',
				'\r',
				'\n'
			};
			pbaObject.CodeplugData.CPVersion = text.TrimEnd(trimChars2);
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
			}
			base.UpdatePINPasswordAfterRead(pbaObject);
			base.UpdateWiFiPasswordAfterRead(pbaObject);
			base.UpdateExternalDataModemPasswordAfterRead(pbaObject);
			pbaObject.CodeplugData.ArchiveSessionID = sessionID;
			return pbaObject;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004EEC File Offset: 0x000030EC
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			if (blockList != null && blockList.Any<T>())
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>(blockList.Count);
				try
				{
					foreach (T t in blockList)
					{
						object obj = t;
						list.Add((global::Motorola.Common.Communication.CommonUtil.IshHeader)obj);
					}
				}
				catch (global::System.InvalidCastException systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgumentType, systemException);
				}
				if (base.ProgressIndicator != null)
				{
					base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
				}
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = this.ReadIshItems(list);
				pbaObject.SetCodeplug(codeplug);
				base.UpdatePINPasswordAfterRead(pbaObject);
				base.UpdateWiFiPasswordAfterRead(pbaObject);
				base.UpdateExternalDataModemPasswordAfterRead(pbaObject);
				return pbaObject;
			}
			throw new global::System.ArgumentNullException();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004FC8 File Offset: 0x000031C8
		protected override global::Motorola.Common.Communication.CommonUtil.IshItemCollection ReadIshItems(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders)
		{
			string text;
			return base.IOController.ReadItemsByIshHeaders(ishHeaders, out text, null);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004FE4 File Offset: 0x000031E4
		public override global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo()
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list = base.IOController.ListDirectoryContents(0, "/LANGUAGE/");
			global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			foreach (global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct in list)
			{
				if (fileListItemStruct.FileType == global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile.File)
				{
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = new global::Motorola.Common.Communication.Pba.AstroFilePackInfo();
					astroFilePackInfo.radioFilePath = fileListItemStruct.FileName;
					astroFilePackInfo.radioFileSize = fileListItemStruct.FileSize;
					languagePackData.LanguagePacks.Add(astroFilePackInfo);
				}
			}
			languagePackData.AvailableSpace = base.IOController.GetFreeSpace(0, "/LANGUAGE/");
			return languagePackData;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00005098 File Offset: 0x00003298
		public override void DeleteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			if (langPackData != null)
			{
				if (!langPackData.LanguagePacks.Any((global::Motorola.Common.Communication.Pba.LanguagePackBase p) => p == null))
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list = base.IOController.ListDirectoryContents(0, "/LANGUAGE/");
					global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
					global::System.Collections.Generic.List<string> list3 = new global::System.Collections.Generic.List<string>();
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = new global::Motorola.Common.Communication.Pba.AstroFilePackInfo();
					bool flag = false;
					foreach (global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct in list)
					{
						list2.Add(fileListItemStruct.FileName);
					}
					foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in langPackData.LanguagePacks)
					{
						global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2 = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)languagePackBase;
						if (list2.Contains(global::System.IO.Path.GetFileName(astroFilePackInfo2.radioFilePath)))
						{
							if (astroFilePackInfo2.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
							{
								flag = true;
								astroFilePackInfo = astroFilePackInfo2;
								if (astroFilePackInfo.radioFilePath != null)
								{
									list3.Insert(0, "/LANGUAGE/" + astroFilePackInfo2.radioFilePath);
								}
							}
							else
							{
								list3.Add("/LANGUAGE/" + astroFilePackInfo2.radioFilePath);
							}
						}
						else if (astroFilePackInfo2.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
						{
							flag = true;
							astroFilePackInfo = astroFilePackInfo2;
						}
					}
					base.IOController.DeleteFilesOrDirectory(0, list3);
					if (flag && astroFilePackInfo.sourceFilePath != null)
					{
						global::Motorola.Common.Communication.AstroLanguagePack astroLanguagePack = new global::Motorola.Common.Communication.AstroLanguagePack();
						byte[] manifest = astroLanguagePack.GetManifest(astroFilePackInfo);
						if (manifest != null)
						{
							using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(manifest))
							{
								base.IOController.FileWrite(0, "/LANGUAGE/" + astroFilePackInfo.sourceFilePath, memoryStream, null, false);
								return;
							}
						}
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
					}
					return;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000527C File Offset: 0x0000347C
		public override void WriteLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData)
		{
			global::Motorola.Common.Communication.LPEngine lpengine = null;
			try
			{
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo extendedDeviceInfo = base.ExtendedDeviceInfo;
				string radioProductName = base.GetRadioProductName();
				global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = langPackData.LanguagePacks[0] as global::Motorola.Common.Communication.Pba.AstroFilePackInfo;
				lpengine = new global::Motorola.Common.Communication.LPEngine(radioProductName, langPackData.ModelType, astroFilePackInfo.sourceFilePath, astroFilePackInfo.languageUpgradeType);
				global::Motorola.Common.Communication.Pba.LanguagePackData radioLPData = this.ReadLanguagePacksInfo();
				global::Motorola.Common.Communication.Pba.LanguagePackData langPackData2;
				global::Motorola.Common.Communication.Pba.LanguagePackData langPackData3;
				switch (lpengine.PrepareWriteRadioLanguagePack(extendedDeviceInfo, radioLPData, out langPackData2, out langPackData3, astroFilePackInfo.isFlashPortUpgradeLP))
				{
				case global::Motorola.Common.Communication.LPUpdateType.OnlyWriteNoDeleteLP:
					this.WriteLanguagePack(langPackData3, false);
					break;
				case global::Motorola.Common.Communication.LPUpdateType.WriteThenDeletLP:
					this.WriteLanguagePack(langPackData3, false);
					this.DeleteLanguagePacks(langPackData2);
					break;
				case global::Motorola.Common.Communication.LPUpdateType.DeleteThenWriteLP:
					this.DeleteLanguagePacks(langPackData2);
					this.WriteLanguagePack(langPackData3, false);
					break;
				case global::Motorola.Common.Communication.LPUpdateType.DeleteAllLP:
					this.DeleteLanguagePacks(langPackData2);
					break;
				case global::Motorola.Common.Communication.LPUpdateType.NewLPWrite:
					this.WriteLanguagePack(langPackData3, true);
					break;
				}
				astroFilePackInfo.warningOTAPErrorCode = lpengine.warningOTAPMessage;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.AddLanguagePackFailure);
			}
			finally
			{
				if (lpengine != null)
				{
					lpengine.Cleanup();
				}
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000053A0 File Offset: 0x000035A0
		private void WriteLanguagePack(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData, bool isNewLPSupport)
		{
			if (langPackData != null)
			{
				if (!langPackData.LanguagePacks.Any((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => lp == null))
				{
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingLanguages);
					}
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.AstroFilePackInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.AstroFilePackInfo>(langPackData.LanguagePacks.Count);
					global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = null;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list3 = base.IOController.ListDirectoryContents(0, "/LANGUAGE/");
					bool flag = false;
					foreach (global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct in list3)
					{
						if (global::System.IO.Path.GetExtension(fileListItemStruct.FileName) == ".mnf")
						{
							flag = true;
						}
					}
					foreach (global::Motorola.Common.Communication.Pba.LanguagePackBase languagePackBase in langPackData.LanguagePacks)
					{
						global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo2 = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)languagePackBase;
						if (astroFilePackInfo2.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
						{
							astroFilePackInfo = astroFilePackInfo2;
							if (flag && astroFilePackInfo.radioFilePath != null)
							{
								string item = "/LANGUAGE/" + astroFilePackInfo2.radioFilePath;
								list2.Add(item);
								base.IOController.DeleteFilesOrDirectory(0, list2);
							}
						}
						else
						{
							list.Add(astroFilePackInfo2);
						}
					}
					if (astroFilePackInfo != null && astroFilePackInfo.sourceFilePath != null)
					{
						list.Insert(list.Count, astroFilePackInfo);
					}
					else if (astroFilePackInfo == null || (astroFilePackInfo.sourceFilePath == null && astroFilePackInfo.radioFilePath == null))
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
					}
					global::Motorola.Common.Communication.AstroLanguagePack astroLanguagePack = new global::Motorola.Common.Communication.AstroLanguagePack(langPackData);
					double progressRate = 1.0 / (double)langPackData.LanguagePacks.Count;
					foreach (global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo3 in list)
					{
						byte[] dataForLp = astroLanguagePack.GetDataForLp(astroFilePackInfo3);
						if (dataForLp != null)
						{
							using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(dataForLp))
							{
								if (astroFilePackInfo3.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
								{
									base.IOController.FileWrite(0, "/LANGUAGE/" + astroFilePackInfo3.sourceFilePath, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, progressRate), false);
								}
								else if (isNewLPSupport)
								{
									string str = astroFilePackInfo3.sourceFilePath.Replace(".lp", ".tlp");
									base.IOController.FileWrite(0, "/LANGUAGE/" + str, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, progressRate), true);
								}
								else
								{
									base.IOController.FileWrite(0, "/LANGUAGE/" + astroFilePackInfo3.sourceFilePath, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(base.ProgressIndicator, progressRate), true);
								}
								continue;
							}
						}
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
					}
					if (base.ProgressIndicator != null)
					{
						base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteLanguagesDone);
					}
					return;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000056C0 File Offset: 0x000038C0
		protected override void WriteRadioCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePBA, bool forceWrite)
		{
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
			}
			if (!forceWrite)
			{
				writePBA.CodeplugData.DataPartitions.RemoveAll((global::Motorola.Common.Communication.Pba.DataPartition x) => x.PartitionID == 212);
				base.UpdatePINPasswordBeforeWrite(writePBA);
				base.UpdateWiFiPasswordBeforeWrite(writePBA);
				base.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
			}
			global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader codeplugCommFileHeader = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader();
			codeplugCommFileHeader.HeaderVer = 16;
			codeplugCommFileHeader.FullDelta = (base.DifferentialWriteCapableRadio ? global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Delta : global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Full);
			codeplugCommFileHeader.Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData;
			global::Motorola.Common.Communication.CommonFile.PartitionCommonFile partitionCommonFile = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true);
			byte[] array = partitionCommonFile.Serialize(codeplugCommFileHeader, writePBA);
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				memoryStream.Write(array, 0, array.Length);
				base.IOController.FileWrite(0, "1_2_1.cmp", memoryStream, base.ProgressIndicator, false);
			}
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000057DC File Offset: 0x000039DC
		protected void WriteRadioDifferentialCodeplug(global::Motorola.Common.Communication.Pba.PbaObject writePBA, bool forceWrite)
		{
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
			}
			if (!forceWrite)
			{
				writePBA.CodeplugData.DataPartitions.RemoveAll((global::Motorola.Common.Communication.Pba.DataPartition x) => x.PartitionID == 212);
				base.UpdatePINPasswordBeforeWrite(writePBA);
				base.UpdateWiFiPasswordBeforeWrite(writePBA);
				base.UpdateExternalDataModemPasswordBeforeWrite(writePBA);
			}
			global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader codeplugCommFileHeader = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader();
			codeplugCommFileHeader.HeaderVer = 16;
			codeplugCommFileHeader.FullDelta = global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Delta;
			codeplugCommFileHeader.Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData;
			global::Motorola.Common.Communication.CommonFile.PartitionCommonFile partitionCommonFile = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(true);
			byte[] array = partitionCommonFile.Serialize(codeplugCommFileHeader, writePBA);
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				memoryStream.Write(array, 0, array.Length);
				base.IOController.FileWrite(0, "1_2_1.cmp", memoryStream, base.ProgressIndicator, false);
			}
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
			}
		}

		// Token: 0x04000018 RID: 24
		private const int MaxXcmpPacketSize = 1024;

		// Token: 0x04000019 RID: 25
		private global::Motorola.Common.Communication.CommonUtil.SessionParameter m_SessionParameter;
	}
}
