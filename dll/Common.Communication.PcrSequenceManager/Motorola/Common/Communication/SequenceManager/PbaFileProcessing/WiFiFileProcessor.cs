using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.SequenceManager.PbaFileProcessing
{
	// Token: 0x02000020 RID: 32
	public class WiFiFileProcessor
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00004E70 File Offset: 0x00003070
		private WiFiFileProcessor()
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00004E7C File Offset: 0x0000307C
		public static global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WiFiFileProcessor Instance
		{
			get
			{
				return global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WiFiFileProcessor._self;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004F04 File Offset: 0x00003104
		public global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFile GenerateManifestFileContent(global::Motorola.Common.Communication.Pba.PbaObject pba, global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WiFiFileProcessor.WifiFileFilter filter)
		{
			global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFileHeader header = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFileHeader();
			global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFile manifestFile = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFile(header);
			foreach (global::Motorola.Common.Communication.Pba.RadioImage radioImage in pba.UpdateData.MemoryImages)
			{
				global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrImage = radioImage as global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject> list = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WiFiFileProcessor.CreateObjectForImage(pcrImage);
				list.ForEach(delegate(global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject s)
				{
					manifestFile.AddManifestObject(s);
				});
			}
			this.CreateObjectForOBPackage(pba, manifestFile);
			this.CreateObjectForVA(pba, manifestFile);
			this.CreateObjectForLP(pba, manifestFile);
			this.CreateObjectForTTS(pba, manifestFile);
			this.CreateObjectForWelcomeBitmap(pba, manifestFile);
			if (filter != null)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject> filterObj = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject>();
				manifestFile.MOList.ForEach(delegate(global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject a)
				{
					if (filter(pba, a))
					{
						filterObj.Add(a);
					}
				});
				filterObj.ForEach(delegate(global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject a)
				{
					manifestFile.RemoveManifestObject(a);
				});
			}
			return manifestFile;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000050C8 File Offset: 0x000032C8
		private void CreateObjectForWelcomeBitmap(global::Motorola.Common.Communication.Pba.PbaObject pba, global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFile manifestFile)
		{
			if (manifestFile.MOList.Find((global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject s) => s.FileType == global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.MMI) == null)
			{
				global::Motorola.Common.Communication.Pba.FileSet fileSetBySet = pba.GetFileSetBySet("WelcomeBitmap");
				if (fileSetBySet != null && fileSetBySet.FileItemsList.Count<global::Motorola.Common.Communication.Pba.FileItem>() > 0)
				{
					string tempFolder = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.SharedUtility.GetTempFolder();
					string fileName = global::System.IO.Path.GetFileName(fileSetBySet.FileItemsList[0].FilePath);
					string text = global::System.IO.Path.Combine(tempFolder, fileName);
					global::System.IO.File.WriteAllBytes(text, fileSetBySet.FileItemsList[0].FileContent);
					global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject obj = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject
					{
						LocalPaths = new global::System.Collections.Generic.List<string>
						{
							text
						},
						FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.WB,
						ObjectID = 3407878U,
						ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem,
						ObjectPath = "/opt/pcr/rel/data/mmi",
						CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP
					};
					manifestFile.AddManifestObject(obj);
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005208 File Offset: 0x00003408
		private void CreateObjectForTTS(global::Motorola.Common.Communication.Pba.PbaObject pba, global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFile manifestFile)
		{
			if (pba.TTSLanguagePackData != null && pba.TTSLanguagePackData.LanguagePacks != null)
			{
				global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject tts = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject
				{
					LocalPaths = new global::System.Collections.Generic.List<string>(),
					FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.TTS,
					ObjectID = 3407877U,
					ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem,
					ObjectPath = "/opt/pcr/rel/data/tts/",
					CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP
				};
				manifestFile.AddManifestObject(tts);
				pba.TTSLanguagePackData.LanguagePacks.ForEach(delegate(global::Motorola.Common.Communication.Pba.LanguagePackBase s)
				{
					tts.LocalPaths.Add((s as global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo).PackFilePath);
				});
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00005304 File Offset: 0x00003504
		private void CreateObjectForLP(global::Motorola.Common.Communication.Pba.PbaObject pba, global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFile manifestFile)
		{
			if (pba.LanguagePackData != null && pba.LanguagePackData.LanguagePacks != null)
			{
				global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject lp = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject
				{
					LocalPaths = new global::System.Collections.Generic.List<string>(),
					FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.LP,
					ObjectID = 3407875U,
					ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem,
					ObjectPath = "/opt/pcr/rel/data/lp/",
					CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP
				};
				manifestFile.AddManifestObject(lp);
				pba.LanguagePackData.LanguagePacks.ForEach(delegate(global::Motorola.Common.Communication.Pba.LanguagePackBase s)
				{
					lp.LocalPaths.Add((s as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo).PackFilePath);
				});
				pba.LanguagePackData.LanguagePacks.ForEach(delegate(global::Motorola.Common.Communication.Pba.LanguagePackBase s)
				{
					lp.RemotePaths.Add("languagepack_" + (s as global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo).PackID + ".pack");
				});
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000540C File Offset: 0x0000360C
		private void CreateObjectForVA(global::Motorola.Common.Communication.Pba.PbaObject pba, global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFile manifestFile)
		{
			global::Motorola.Common.Communication.Pba.FileSet fileSetBySet = pba.GetFileSetBySet("VoiceAnnouncement");
			if (fileSetBySet != null && fileSetBySet.FileItemsList != null)
			{
				global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject va = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject
				{
					LocalPaths = new global::System.Collections.Generic.List<string>(),
					FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.VA,
					ObjectID = 3407874U,
					ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem,
					ObjectPath = "/opt/pcr/rel/data/va/",
					CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP
				};
				manifestFile.AddManifestObject(va);
				fileSetBySet.FileItemsList.ForEach(delegate(global::Motorola.Common.Communication.Pba.FileItem s)
				{
					va.LocalPaths.Add(s.URI);
				});
				fileSetBySet.FileItemsList.ForEach(delegate(global::Motorola.Common.Communication.Pba.FileItem s)
				{
					va.RemotePaths.Add(global::System.IO.Path.GetFileName(s.FilePath));
				});
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000550C File Offset: 0x0000370C
		private void CreateObjectForOBPackage(global::Motorola.Common.Communication.Pba.PbaObject pba, global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFile manifestFile)
		{
			global::Motorola.Common.Communication.Pba.FileSet fileSetBySet = pba.GetFileSetBySet("PBBProvisioningPackage");
			if (fileSetBySet != null && fileSetBySet.FileItemsList != null && fileSetBySet.FileItemsList.Count<global::Motorola.Common.Communication.Pba.FileItem>() > 0)
			{
				global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject ob = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject
				{
					LocalPaths = new global::System.Collections.Generic.List<string>(),
					FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.OB,
					ObjectID = 3407880U,
					ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem,
					ObjectPath = "/opt/pcr/rel/data/ob/",
					CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP
				};
				manifestFile.AddManifestObject(ob);
				fileSetBySet.FileItemsList.ForEach(delegate(global::Motorola.Common.Communication.Pba.FileItem s)
				{
					ob.LocalPaths.Add(s.URI);
				});
				fileSetBySet.FileItemsList.ForEach(delegate(global::Motorola.Common.Communication.Pba.FileItem s)
				{
					ob.RemotePaths.Add(global::System.IO.Path.GetFileName(s.FilePath));
				});
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000055DC File Offset: 0x000037DC
		internal static global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject> CreateObjectForImage(global::Motorola.Common.Communication.Pba.PcrFileSystemMemoryImage pcrImage)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject>();
			global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject manifestObject = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject
			{
				LocalPaths = new global::System.Collections.Generic.List<string>
				{
					pcrImage.FilePath
				},
				CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP,
				OptionFlag = pcrImage.OptionFlag
			};
			if (pcrImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.L2)
			{
				manifestObject.FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.FW;
				manifestObject.ObjectID = 1048577U;
				manifestObject.ObjectPath = "00100001.dat";
				manifestObject.ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.RawNAND;
			}
			else if (pcrImage.FileType == global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DATA_IMAGE)
			{
				global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject manifestObject2 = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject
				{
					LocalPaths = new global::System.Collections.Generic.List<string>
					{
						pcrImage.FilePath
					},
					FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.WC,
					OptionFlag = pcrImage.OptionFlag
				};
				manifestObject2.ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem;
				manifestObject2.ObjectID = 3407876U;
				manifestObject2.ObjectPath = "/opt/pcr/rel/data/wc/";
				manifestObject2.CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP;
				manifestObject2.AllowEmpty = true;
				list.Add(manifestObject2);
				global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject manifestObject3 = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject
				{
					LocalPaths = new global::System.Collections.Generic.List<string>
					{
						pcrImage.FilePath
					},
					FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.MMI,
					OptionFlag = pcrImage.OptionFlag
				};
				manifestObject3.ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem;
				manifestObject3.ObjectID = 3407878U;
				manifestObject3.ObjectPath = "/opt/pcr/rel/data/mmi/";
				manifestObject3.CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP;
				manifestObject3.AllowEmpty = true;
				list.Add(manifestObject3);
				manifestObject.ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem;
				manifestObject.ObjectID = 3407881U;
				manifestObject.ObjectPath = "/opt/pcr/rel/data/CH_upgrade/";
				manifestObject.CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP;
				manifestObject.FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.CH;
				manifestObject.AllowEmpty = true;
			}
			else
			{
				manifestObject.ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FTL;
				manifestObject.FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.FW;
				global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType = pcrImage.FileType;
				if (fileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CPG_APP)
				{
					switch (fileType)
					{
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT:
						manifestObject.ObjectID = 2162689U;
						manifestObject.ObjectPath = "00210001.dat";
						goto IL_435;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.SEC:
						manifestObject.ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem;
						manifestObject.FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.CP;
						manifestObject.CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP;
						manifestObject.ObjectID = 3342341U;
						manifestObject.ObjectPath = "/opt/pcr/rel/data/codeplug/app_security/";
						goto IL_435;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TUNE:
						manifestObject.ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem;
						manifestObject.FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.CP;
						manifestObject.CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP;
						manifestObject.ObjectID = 3276801U;
						manifestObject.ObjectPath = "/opt/pcr/rel/data/tuning/app_tuning/";
						goto IL_435;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.UCL:
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.TARGET_VERSION:
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CONTROLLER_FPGA:
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.WIRELINE_FPGA:
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FILESYSTEM:
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.FTL:
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.NAND:
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.L2:
						goto IL_42F;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CP_CFS:
						manifestObject.ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem;
						manifestObject.FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.CP;
						manifestObject.CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP;
						manifestObject.ObjectID = 3342340U;
						manifestObject.ObjectPath = "/opt/pcr/rel/data/codeplug/app_features/";
						goto IL_435;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CONFIGURATION:
						manifestObject.ObjectID = 2228225U;
						manifestObject.ObjectPath = "00220001.dat";
						goto IL_435;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.KERNEL:
						manifestObject.ObjectID = 2424833U;
						manifestObject.ObjectPath = "00250001.dat";
						goto IL_435;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.L3:
						manifestObject.ObjectID = 2359297U;
						manifestObject.ObjectPath = "00240001.dat";
						goto IL_435;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.RFS:
						manifestObject.ObjectID = 2490369U;
						manifestObject.ObjectPath = "00260001.dat";
						goto IL_435;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.APP:
						manifestObject.ObjectID = 2555905U;
						manifestObject.ObjectPath = "00270001.dat";
						goto IL_435;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.APP_UTILITIES:
						manifestObject.ObjectID = 3211265U;
						manifestObject.ObjectPath = "00310001.dat";
						goto IL_435;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PARTITION_TABLE:
						manifestObject.ObjectID = 3145729U;
						manifestObject.ObjectPath = "00300001.dat";
						goto IL_435;
					case global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.CONTROL_HEAD:
						break;
					default:
						if (fileType != global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSMARKER)
						{
							goto IL_42F;
						}
						break;
					}
					manifestObject.ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem;
					manifestObject.FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.PSMARKER;
					manifestObject.ObjectID = 3407882U;
					manifestObject.ObjectPath = "/opt/pcr/rel/data/upgrade/";
					goto IL_435;
					IL_42F:
					throw new global::Motorola.Common.CustomException.CommonException();
				}
				manifestObject.ObjectType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType.FileSystem;
				manifestObject.FileType = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType.CP;
				manifestObject.CompressionMethod = global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod.ZIP;
				manifestObject.ObjectID = 3342338U;
				manifestObject.ObjectPath = "/opt/pcr/rel/data/codeplug/app_codeplug/";
				IL_435:;
			}
			if (manifestObject != null)
			{
				list.Add(manifestObject);
			}
			return list;
		}

		// Token: 0x04000094 RID: 148
		private static global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WiFiFileProcessor _self = new global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.WiFiFileProcessor();

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600009B RID: 155
		public delegate bool WifiFileFilter(global::Motorola.Common.Communication.Pba.PbaObject pba, global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestObject obj);
	}
}
