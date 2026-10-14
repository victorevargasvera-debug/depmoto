using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using AcpCryptoLib;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000F RID: 15
	internal sealed class AstroLanguagePack
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00007B7C File Offset: 0x00005D7C
		public AstroLanguagePack(global::Motorola.Common.Communication.Pba.LanguagePackData lpData)
		{
			this._lpData = lpData;
			this.langPackDoc = null;
			this.manifest = null;
			this.LoadlpXml();
			this.LoadManifest();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00007BA5 File Offset: 0x00005DA5
		public AstroLanguagePack()
		{
			this._lpData = null;
			this.langPackDoc = null;
			this.manifest = null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00007BD8 File Offset: 0x00005DD8
		private void LoadlpXml()
		{
			if (this._lpData != null)
			{
				if (!this._lpData.LanguagePacks.Any((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => lp == null))
				{
					this.langPackDoc = null;
					try
					{
						global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this._lpData.LanguagePacks.Find((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.LanguagePack);
						if (astroFilePackInfo == null || string.IsNullOrEmpty(astroFilePackInfo.encFileName) || !global::System.IO.File.Exists(astroFilePackInfo.encFileName))
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
						}
						global::AcpCryptoLib.AcpXMLEncryptDecrypt acpXMLEncryptDecrypt = new global::AcpCryptoLib.AcpXMLEncryptDecrypt();
						this.langPackDoc = acpXMLEncryptDecrypt.DecryptXMLFile(astroFilePackInfo.encFileName);
					}
					catch
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
					}
					return;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00007CD8 File Offset: 0x00005ED8
		private void LoadManifest()
		{
			if (this._lpData != null)
			{
				if (!this._lpData.LanguagePacks.Any((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => lp == null))
				{
					this.manifest = null;
					try
					{
						global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this._lpData.LanguagePacks.Find((global::Motorola.Common.Communication.Pba.LanguagePackBase lp) => ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)lp).fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest);
						if (astroFilePackInfo == null || string.IsNullOrEmpty(astroFilePackInfo.encFileName) || !global::System.IO.File.Exists(astroFilePackInfo.encFileName))
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
						}
						this.ReadFile(out this.manifest, astroFilePackInfo.encFileName, true);
					}
					catch
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_MissingLangManifestFile);
					}
					return;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00007DB8 File Offset: 0x00005FB8
		public byte[] GetManifest(global::Motorola.Common.Communication.Pba.AstroFilePackInfo manifest)
		{
			if (manifest == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			byte[] result = null;
			try
			{
				if (!string.IsNullOrEmpty(manifest.encFileName) && global::System.IO.File.Exists(manifest.encFileName))
				{
					this.ReadFile(out result, manifest.encFileName, true);
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00007E14 File Offset: 0x00006014
		public byte[] GetDataForLp(global::Motorola.Common.Communication.Pba.AstroFilePackInfo lpfile)
		{
			if (lpfile == null || this.langPackDoc == null || this.manifest == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			byte[] array = null;
			try
			{
				if (lpfile.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.LanguagePack)
				{
					global::System.Xml.XmlNode xmlNode = this.langPackDoc.SelectSingleNode("//lpack/data/file[@id='" + lpfile.sourceFileId + "']");
					if (xmlNode == null)
					{
						goto IL_F9;
					}
					using (global::System.Collections.IEnumerator enumerator = xmlNode.ChildNodes.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj;
							if (xmlNode2.Name.Equals("filename") && !xmlNode2.InnerText.Equals(global::System.IO.Path.GetFileName(lpfile.sourceFilePath)))
							{
								break;
							}
							if (xmlNode2.Name.Equals("payload"))
							{
								string innerText = xmlNode2.InnerText;
								array = global::System.Convert.FromBase64String(innerText);
							}
						}
						goto IL_F9;
					}
				}
				if (lpfile.fileType == global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest)
				{
					array = new byte[this.manifest.Length];
					this.manifest.CopyTo(array, 0);
				}
				IL_F9:;
			}
			catch
			{
				array = null;
			}
			return array;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00007F40 File Offset: 0x00006140
		private void ReadFile(out byte[] readBuffer, string filePath, bool decrypt)
		{
			readBuffer = null;
			if (!string.IsNullOrEmpty(filePath) && global::System.IO.File.Exists(filePath))
			{
				using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read))
				{
					global::Motorola.Common.Communication.AstroLanguagePack.ReadData(out readBuffer, fileStream, decrypt);
				}
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00007F90 File Offset: 0x00006190
		private static void ReadData(out byte[] readBuffer, global::System.IO.FileStream fs, bool decrypt)
		{
			long num = fs.Length - fs.Position;
			using (global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(fs, global::System.Text.Encoding.UTF8))
			{
				byte[] array = new byte[num];
				binaryReader.Read(array, 0, (int)num);
				if (decrypt)
				{
					global::AcpCryptoLib.AcpEncryptDecrypt acpEncryptDecrypt = new global::AcpCryptoLib.AcpEncryptDecrypt();
					readBuffer = acpEncryptDecrypt.Decrypt(array);
				}
				else
				{
					readBuffer = array;
				}
			}
		}

		// Token: 0x04000032 RID: 50
		private global::System.Xml.XmlDocument langPackDoc;

		// Token: 0x04000033 RID: 51
		private global::Motorola.Common.Communication.Pba.LanguagePackData _lpData;

		// Token: 0x04000034 RID: 52
		private byte[] manifest;
	}
}
