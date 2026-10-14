using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200008D RID: 141
	internal class Z19FileInternal
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x0001527E File Offset: 0x0001347E
		public Z19FileInternal(string archivePath)
		{
			this._archivePath = this.FormatArcheiveFilePath(archivePath);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000152AC File Offset: 0x000134AC
		public static void MakeZ19File(string fwS19File, string cpVer, string targetZ19File)
		{
			if (!global::System.IO.Directory.Exists(global::System.IO.Path.GetDirectoryName(targetZ19File)))
			{
				global::System.IO.Directory.CreateDirectory(global::System.IO.Path.GetDirectoryName(targetZ19File));
			}
			global::System.IO.FileStream fileStream = null;
			global::System.IO.FileStream fileStream2 = null;
			global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = null;
			global::Motorola.Common.Communication.TetraUtility.Z19FileInternal.MemoryDataSource memoryDataSource = null;
			global::Motorola.Common.Communication.TetraUtility.Z19FileInternal.MemoryDataSource memoryDataSource2 = null;
			try
			{
				fileStream = new global::System.IO.FileStream(targetZ19File, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
				zipFile = global::ICSharpCode.SharpZipLib.Zip.ZipFile.Create(fileStream);
				zipFile.Password = "(gogol)";
				zipFile.BeginUpdate();
				fileStream2 = global::System.IO.File.OpenRead(fwS19File);
				byte[] array = new byte[fileStream2.Length];
				fileStream2.Read(array, 0, array.Length);
				memoryDataSource = new global::Motorola.Common.Communication.TetraUtility.Z19FileInternal.MemoryDataSource(array);
				zipFile.Add(memoryDataSource, global::System.IO.Path.GetFileName(fwS19File));
				memoryDataSource2 = new global::Motorola.Common.Communication.TetraUtility.Z19FileInternal.MemoryDataSource(global::System.Text.Encoding.ASCII.GetBytes(cpVer));
				zipFile.Add(memoryDataSource2, "short_info.txt");
				zipFile.CommitUpdate();
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
				if (fileStream2 != null)
				{
					fileStream2.Close();
				}
				if (zipFile != null)
				{
					zipFile.Close();
				}
				if (memoryDataSource != null)
				{
					memoryDataSource.Dispose();
				}
				if (memoryDataSource2 != null)
				{
					memoryDataSource2.Dispose();
				}
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000153A0 File Offset: 0x000135A0
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> GetFlashPacks(string hWConfig)
		{
			global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> result;
			lock (this.padLock)
			{
				string[] flashPack = this.ShortInfo.GetFlashPack(hWConfig);
				if (flashPack == null)
				{
					result = this.FlashPacks;
				}
				else if (hWConfig == "ForiTM")
				{
					result = this.FlashPacks;
				}
				else
				{
					result = global::Motorola.Common.Communication.TetraUtility.Z19FileInternal.GetFPByHWConfig(this.FlashPacks, flashPack);
				}
			}
			return result;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00015418 File Offset: 0x00013618
		public global::Motorola.Common.Communication.TetraUtility.SRecord GetHwComponentByFileName(string fileName)
		{
			if (this.HWComponentsNameValues != null && this.HWComponentsNameValues.Count > 0 && this.HWComponentsNameValues.ContainsKey(fileName))
			{
				return this.HWComponentsNameValues[fileName];
			}
			return null;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0001544C File Offset: 0x0001364C
		public bool ContainsBootLoader
		{
			get
			{
				bool containsBootLoader;
				lock (this.padLock)
				{
					containsBootLoader = this.ShortInfo.ContainsBootLoader;
				}
				return containsBootLoader;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00015494 File Offset: 0x00013694
		public bool ContainsFuk
		{
			get
			{
				bool containsFuk;
				lock (this.padLock)
				{
					containsFuk = this.ShortInfo.ContainsFuk;
				}
				return containsFuk;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x000154DC File Offset: 0x000136DC
		public string CPVer
		{
			get
			{
				string cpVersion;
				lock (this.padLock)
				{
					cpVersion = this.ShortInfo.CpVersion;
				}
				return cpVersion;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00015524 File Offset: 0x00013724
		public string BootLoader2Ver
		{
			get
			{
				string bootLoader2Ver;
				lock (this.padLock)
				{
					bootLoader2Ver = this.ShortInfo.BootLoader2Ver;
				}
				return bootLoader2Ver;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0001556C File Offset: 0x0001376C
		public string BootLoader3Ver
		{
			get
			{
				string bootLoader3Ver;
				lock (this.padLock)
				{
					bootLoader3Ver = this.ShortInfo.BootLoader3Ver;
				}
				return bootLoader3Ver;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x000155B4 File Offset: 0x000137B4
		public string UpstartKernelVer
		{
			get
			{
				string upstartKernelVer;
				lock (this.padLock)
				{
					upstartKernelVer = this.ShortInfo.UpstartKernelVer;
				}
				return upstartKernelVer;
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000155FC File Offset: 0x000137FC
		public bool ContainsHWComponent()
		{
			bool containsHwComponents;
			lock (this.padLock)
			{
				containsHwComponents = this.ShortInfo.ContainsHwComponents;
			}
			return containsHwComponents;
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00015644 File Offset: 0x00013844
		public global::Motorola.Common.Communication.TetraUtility.SRecord FirmwareRecord
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.SRecord result;
				lock (this.padLock)
				{
					if (this._firmwareRecord == null || this._firmwareRecord.Image == null || this._firmwareRecord.Image.Count == 0)
					{
						this._firmwareRecord = new global::Motorola.Common.Communication.TetraUtility.SRecord();
						if (this._archivePath == null)
						{
							result = null;
						}
						else
						{
							using (global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = new global::ICSharpCode.SharpZipLib.Zip.ZipFile(this._archivePath))
							{
								zipFile.Password = "(gogol)";
								string text = global::System.IO.Path.GetFileName(this._archivePath).ToLowerInvariant();
								if (string.IsNullOrEmpty(text) || !text.Contains("z19"))
								{
									result = null;
								}
								else
								{
									text = text.Replace("z19", "s19");
									global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = zipFile.GetEntry(text);
									if (entry == null || !entry.IsFile)
									{
										result = null;
									}
									else
									{
										using (global::Motorola.Common.Communication.TetraUtility.SharpZipWrapperInputStream sharpZipWrapperInputStream = new global::Motorola.Common.Communication.TetraUtility.SharpZipWrapperInputStream(zipFile, entry))
										{
											if (this._firmwareRecord.LoadFromPlainContentStream(sharpZipWrapperInputStream))
											{
												result = this._firmwareRecord;
											}
											else
											{
												result = null;
											}
										}
									}
								}
							}
						}
					}
					else
					{
						result = this._firmwareRecord;
					}
				}
				return result;
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000157B4 File Offset: 0x000139B4
		public global::Motorola.Common.Communication.TetraUtility.SRecord GetBootLoader2(string radioHWConfig)
		{
			global::Motorola.Common.Communication.TetraUtility.SRecord platFormSRecord;
			lock (this.padLock)
			{
				string bootLoader = this.ShortInfo.GetBootLoader2(radioHWConfig);
				platFormSRecord = this.GetPlatFormSRecord(bootLoader);
			}
			return platFormSRecord;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00015804 File Offset: 0x00013A04
		public global::Motorola.Common.Communication.TetraUtility.SRecord GetBootLoader3Record(string radioHWConfig)
		{
			string bootLoader = this.ShortInfo.GetBootLoader3(radioHWConfig);
			return this.GetPlatFormSRecord(bootLoader);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00015828 File Offset: 0x00013A28
		public global::Motorola.Common.Communication.TetraUtility.SRecord GetUpstartKernelRecord(string radioHWConfig)
		{
			string upstartKernel = this.ShortInfo.GetUpstartKernel(radioHWConfig);
			return this.GetPlatFormSRecord(upstartKernel);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0001584C File Offset: 0x00013A4C
		public byte[] GetFactoryUpstartKernelRecord()
		{
			byte[] result;
			lock (this.padLock)
			{
				if (this._fukImage != null)
				{
					result = this._fukImage;
				}
				else
				{
					string factoryUpstartKernelName = this.ShortInfo.GetFactoryUpstartKernelName();
					if (this._archivePath == null)
					{
						result = null;
					}
					else
					{
						using (global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = new global::ICSharpCode.SharpZipLib.Zip.ZipFile(this._archivePath))
						{
							zipFile.Password = "(gogol)";
							global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = zipFile.GetEntry(factoryUpstartKernelName);
							if (entry != null && entry.IsFile)
							{
								using (global::System.IO.Stream inputStream = zipFile.GetInputStream(entry))
								{
									using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
									{
										inputStream.CopyTo(memoryStream);
										this._fukImage = memoryStream.ToArray();
									}
								}
							}
						}
						result = this._fukImage;
					}
				}
			}
			return result;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00015960 File Offset: 0x00013B60
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> HWComponentsNameValues
		{
			get
			{
				global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> result;
				lock (this.padLock)
				{
					if (this._hwComponentNameValueList == null)
					{
						this._hwComponentNameValueList = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord>();
						if (this._archivePath == null)
						{
							result = null;
						}
						else
						{
							string hwComponentFolderName = this.ShortInfo.HwComponentFolderName;
							if (string.IsNullOrEmpty(hwComponentFolderName))
							{
								result = null;
							}
							else
							{
								string text = global::System.IO.Path.GetFileName(this._archivePath).ToLowerInvariant();
								if (string.IsNullOrEmpty(text) || !text.Contains(".z19"))
								{
									result = null;
								}
								else
								{
									using (global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = new global::ICSharpCode.SharpZipLib.Zip.ZipFile(this._archivePath))
									{
										zipFile.Password = "(gogol)";
										foreach (object obj2 in zipFile)
										{
											global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)obj2;
											if (global::System.IO.Path.GetDirectoryName(zipEntry.Name).ToLowerInvariant().Equals(hwComponentFolderName, global::System.StringComparison.Ordinal))
											{
												global::Motorola.Common.Communication.TetraUtility.SRecord srecord = new global::Motorola.Common.Communication.TetraUtility.SRecord();
												using (global::Motorola.Common.Communication.TetraUtility.SharpZipWrapperInputStream sharpZipWrapperInputStream = new global::Motorola.Common.Communication.TetraUtility.SharpZipWrapperInputStream(zipFile, zipEntry))
												{
													if (srecord.LoadFromPlainContentStream(sharpZipWrapperInputStream))
													{
														srecord.Image.CompactUnits();
														this._hwComponentNameValueList.Add(global::System.IO.Path.GetFileNameWithoutExtension(zipEntry.Name).ToLowerInvariant(), srecord);
													}
												}
											}
										}
										if (this._hwComponentNameValueList.Count != 0)
										{
											result = this._hwComponentNameValueList;
										}
										else
										{
											result = null;
										}
									}
								}
							}
						}
					}
					else if (this._hwComponentNameValueList.Count != 0)
					{
						result = this._hwComponentNameValueList;
					}
					else
					{
						result = null;
					}
				}
				return result;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00015B6C File Offset: 0x00013D6C
		public global::System.Collections.Generic.List<string> HWComponentNames
		{
			get
			{
				global::System.Collections.Generic.List<string> result;
				lock (this.padLock)
				{
					if (this._hwComponentNames == null)
					{
						this._hwComponentNames = new global::System.Collections.Generic.List<string>();
						if (this._archivePath == null)
						{
							result = null;
						}
						else
						{
							string hwComponentFolderName = this.ShortInfo.HwComponentFolderName;
							if (string.IsNullOrEmpty(hwComponentFolderName))
							{
								result = null;
							}
							else
							{
								global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this._archivePath);
								try
								{
									using (global::ICSharpCode.SharpZipLib.Zip.ZipInputStream zipInputStream = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream(fileStream))
									{
										zipInputStream.Password = "(gogol)";
										string text = global::System.IO.Path.GetFileName(this._archivePath).ToLowerInvariant();
										if (string.IsNullOrEmpty(text) || !text.Contains(".z19"))
										{
											result = null;
										}
										else
										{
											global::ICSharpCode.SharpZipLib.Zip.ZipEntry nextEntry;
											while ((nextEntry = zipInputStream.GetNextEntry()) != null)
											{
												if (global::System.IO.Path.GetDirectoryName(nextEntry.Name).ToLowerInvariant().Equals(hwComponentFolderName, global::System.StringComparison.Ordinal))
												{
													this._hwComponentNames.Add(global::System.IO.Path.GetFileNameWithoutExtension(nextEntry.Name));
												}
											}
											if (this._hwComponentNames.Count != 0)
											{
												result = this._hwComponentNames;
											}
											else
											{
												result = null;
											}
										}
									}
								}
								finally
								{
									fileStream.Dispose();
								}
							}
						}
					}
					else if (this._hwComponentNames.Count != 0)
					{
						result = this._hwComponentNames;
					}
					else
					{
						result = null;
					}
				}
				return result;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00015CFC File Offset: 0x00013EFC
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> FlashPacks
		{
			get
			{
				global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> result;
				lock (this.padLock)
				{
					if (this._flashPacks == null)
					{
						this._flashPacks = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord>();
						if (this._archivePath == null)
						{
							result = null;
						}
						else
						{
							string text = global::System.IO.Path.GetFileName(this._archivePath).ToLowerInvariant();
							if (string.IsNullOrEmpty(text) || !text.Contains(".z19"))
							{
								result = null;
							}
							else
							{
								using (global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = new global::ICSharpCode.SharpZipLib.Zip.ZipFile(this._archivePath))
								{
									zipFile.Password = "(gogol)";
									text = text.Replace("z19", "s19");
									foreach (object obj2 in zipFile)
									{
										global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)obj2;
										if (zipEntry.Name.ToLowerInvariant() != text.ToLowerInvariant() && zipEntry.Name.Contains(".s19") && !this.IsBootLoader2S19(zipEntry.Name) && !this.IsBootLoader3S19(zipEntry.Name) && !this.IsUpstartKernelS19(zipEntry.Name) && !this.IsHwComponentFile(zipEntry.Name))
										{
											using (global::Motorola.Common.Communication.TetraUtility.SharpZipWrapperInputStream sharpZipWrapperInputStream = new global::Motorola.Common.Communication.TetraUtility.SharpZipWrapperInputStream(zipFile, zipEntry))
											{
												global::Motorola.Common.Communication.TetraUtility.SRecord srecord = new global::Motorola.Common.Communication.TetraUtility.SRecord();
												if (srecord.LoadFromPlainContentStream(sharpZipWrapperInputStream))
												{
													srecord.Image.CompactUnits();
													this._flashPacks.Add(zipEntry.Name, srecord);
												}
											}
										}
									}
									if (this._flashPacks.Count != 0)
									{
										result = this._flashPacks;
									}
									else
									{
										result = null;
									}
								}
							}
						}
					}
					else if (this._flashPacks.Count != 0)
					{
						result = this._flashPacks;
					}
					else
					{
						result = null;
					}
				}
				return result;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00015F38 File Offset: 0x00014138
		private global::Motorola.Common.Communication.TetraUtility.ShortInfo ShortInfo
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.ShortInfo shortInfo;
				lock (this.padLock)
				{
					if (this._shortInfo == null)
					{
						using (global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = new global::ICSharpCode.SharpZipLib.Zip.ZipFile(this._archivePath))
						{
							zipFile.Password = "(gogol)";
							global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = zipFile.GetEntry("short_info.txt");
							this._shortInfo = new global::Motorola.Common.Communication.TetraUtility.ShortInfo(zipFile.GetInputStream(entry));
						}
					}
					shortInfo = this._shortInfo;
				}
				return shortInfo;
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00015FD4 File Offset: 0x000141D4
		private global::Motorola.Common.Communication.TetraUtility.SRecord GetPlatFormSRecord(string platformFileName)
		{
			global::Motorola.Common.Communication.TetraUtility.SRecord result;
			lock (this._platformRecords)
			{
				if (!this._platformRecords.ContainsKey(platformFileName))
				{
					using (global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = new global::ICSharpCode.SharpZipLib.Zip.ZipFile(this._archivePath))
					{
						zipFile.Password = "(gogol)";
						global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = zipFile.GetEntry(platformFileName);
						global::Motorola.Common.Communication.TetraUtility.SRecord srecord = new global::Motorola.Common.Communication.TetraUtility.SRecord();
						using (global::Motorola.Common.Communication.TetraUtility.SharpZipWrapperInputStream sharpZipWrapperInputStream = new global::Motorola.Common.Communication.TetraUtility.SharpZipWrapperInputStream(zipFile, entry))
						{
							srecord.LoadFromPlainContentStream(sharpZipWrapperInputStream);
						}
						srecord.Image.CompactUnits();
						this._platformRecords.Add(platformFileName, srecord);
					}
				}
				result = this._platformRecords[platformFileName];
			}
			return result;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000160B0 File Offset: 0x000142B0
		private static global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> GetFPByHWConfig(global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> fullFlashPacks, string[] fpPathList)
		{
			global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord>();
			foreach (string text in fpPathList)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Motorola.Common.Communication.TetraUtility.SRecord> keyValuePair in fullFlashPacks)
				{
					string fpFullName = keyValuePair.Key.Replace('/', '\\');
					string text2;
					string key;
					global::Motorola.Common.Communication.TetraUtility.Z19FileInternal.ParseFPName(fpFullName, out text2, out key);
					if (text2.ToLowerInvariant() == text.ToLowerInvariant())
					{
						if (dictionary.ContainsKey(key))
						{
							dictionary[key] = keyValuePair.Value;
						}
						else
						{
							dictionary.Add(key, keyValuePair.Value);
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0001617C File Offset: 0x0001437C
		private static void ParseFPName(string fpFullName, out string fpPath, out string fpName)
		{
			int num = fpFullName.LastIndexOf('\\');
			if (num < 0)
			{
				fpPath = "";
				fpName = fpFullName.Trim();
				return;
			}
			fpPath = fpFullName.Substring(0, num).Trim();
			fpName = fpFullName.Substring(num + 1).Trim();
			if (fpPath[0] != '\\')
			{
				fpPath = '\\' + fpPath;
			}
			if (fpPath[fpPath.Length - 1] != '\\')
			{
				fpPath += '\\';
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00016205 File Offset: 0x00014405
		private string FormatArcheiveFilePath(string archeiveFile)
		{
			return global::System.IO.Path.GetFullPath(archeiveFile).ToLowerInvariant();
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00016212 File Offset: 0x00014412
		private bool IsBootLoader2S19(string fileName)
		{
			return this.ShortInfo.IsBootLoader2S19(fileName);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00016220 File Offset: 0x00014420
		private bool IsBootLoader3S19(string fileName)
		{
			return this.ShortInfo.IsBootLoader3S19(fileName);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0001622E File Offset: 0x0001442E
		private bool IsUpstartKernelS19(string fileName)
		{
			return this.ShortInfo.IsUpstartKernelS19(fileName);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0001623C File Offset: 0x0001443C
		private bool IsHwComponentFile(string fileName)
		{
			return !string.IsNullOrEmpty(this.ShortInfo.HwComponentFolderName) && global::System.IO.Path.GetDirectoryName(fileName).ToLowerInvariant().Equals(this.ShortInfo.HwComponentFolderName.ToLowerInvariant(), global::System.StringComparison.Ordinal);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00016278 File Offset: 0x00014478
		private static string FindFileNameStartWith(string startStr, string archivePath)
		{
			string result = "";
			if (archivePath != null)
			{
				using (global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile = new global::ICSharpCode.SharpZipLib.Zip.ZipFile(archivePath))
				{
					zipFile.Password = "(gogol)";
					int num = 0;
					while ((long)num < zipFile.Count)
					{
						global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = zipFile[num];
						string text = global::System.IO.Path.GetFileNameWithoutExtension(zipEntry.Name).ToLowerInvariant();
						if (text.StartsWith(startStr, global::System.StringComparison.Ordinal))
						{
							string[] array = text.Split(new char[]
							{
								'_'
							});
							result = array[0].Trim();
							break;
						}
						num++;
					}
				}
			}
			return result;
		}

		// Token: 0x0400043D RID: 1085
		private const string PASSWORD = "(gogol)";

		// Token: 0x0400043E RID: 1086
		private const string SHORT_INFO_FILE = "short_info.txt";

		// Token: 0x0400043F RID: 1087
		private object padLock = new object();

		// Token: 0x04000440 RID: 1088
		private global::Motorola.Common.Communication.TetraUtility.SRecord _firmwareRecord;

		// Token: 0x04000441 RID: 1089
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> _flashPacks;

		// Token: 0x04000442 RID: 1090
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> _hwComponentNameValueList;

		// Token: 0x04000443 RID: 1091
		private global::System.Collections.Generic.List<string> _hwComponentNames;

		// Token: 0x04000444 RID: 1092
		private string _archivePath;

		// Token: 0x04000445 RID: 1093
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> _platformRecords = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord>();

		// Token: 0x04000446 RID: 1094
		private global::Motorola.Common.Communication.TetraUtility.ShortInfo _shortInfo;

		// Token: 0x04000447 RID: 1095
		private byte[] _fukImage;

		// Token: 0x0200008E RID: 142
		private class MemoryDataSource : global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource, global::System.IDisposable
		{
			// Token: 0x060003ED RID: 1005 RVA: 0x0001631C File Offset: 0x0001451C
			public MemoryDataSource(global::System.IO.Stream steam)
			{
				this.steam = steam;
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x0001632B File Offset: 0x0001452B
			public MemoryDataSource(byte[] buf)
			{
				this.steam = new global::System.IO.MemoryStream(buf);
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x0001633F File Offset: 0x0001453F
			public global::System.IO.Stream GetSource()
			{
				return this.steam;
			}

			// Token: 0x060003F0 RID: 1008 RVA: 0x00016347 File Offset: 0x00014547
			protected virtual void Dispose(bool disposing)
			{
				if (disposing && this.steam != null)
				{
					this.steam.Close();
					this.steam = null;
				}
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x00016366 File Offset: 0x00014566
			public void Dispose()
			{
				this.Dispose(true);
				global::System.GC.SuppressFinalize(this);
			}

			// Token: 0x04000448 RID: 1096
			private global::System.IO.Stream steam;
		}
	}
}
