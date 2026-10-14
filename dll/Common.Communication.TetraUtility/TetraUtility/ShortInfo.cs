using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200008A RID: 138
	internal class ShortInfo
	{
		// Token: 0x0600039B RID: 923 RVA: 0x00014668 File Offset: 0x00012868
		public ShortInfo(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(stream))
			{
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("^\\s*CODEPLUG\\s*=\\s*(.*)\\s*$");
					global::System.Text.RegularExpressions.Match match = regex.Match(text);
					global::System.Text.RegularExpressions.Regex regex2 = new global::System.Text.RegularExpressions.Regex("^.*HWCOMPATIBLE:.*$");
					global::System.Text.RegularExpressions.Match match2 = regex2.Match(text);
					if (match != null && match.Success)
					{
						if (match.Groups.Count != 2)
						{
							throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("not formal z19 files");
						}
						this.CpVersion = match.Groups[1].Value.Replace(".", "");
					}
					else if ((match2 == null || !match2.Success) && !string.IsNullOrWhiteSpace(text))
					{
						this.ParseHWCompoentInfo(text.Trim());
					}
				}
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00014748 File Offset: 0x00012948
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00014750 File Offset: 0x00012950
		public string CpVersion { get; private set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00014759 File Offset: 0x00012959
		public bool ContainsBootLoader
		{
			get
			{
				return this._bl2Infos != null && this._bl2Infos.Count > 0;
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00014774 File Offset: 0x00012974
		public string GetBootLoader2(string radioHWConfig)
		{
			if (this._bl2Infos != null && this._bl2Infos.Count > 0)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> list = global::Motorola.Common.Communication.TetraUtility.ShortInfo.FilterPairedHWComponent(radioHWConfig, this._bl2Infos);
				if (list.Count >= 0)
				{
					return list.Last<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection>().Path;
				}
			}
			return null;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000147C0 File Offset: 0x000129C0
		public string GetBootLoader3(string radioHWConfig)
		{
			if (this._bl3Infos != null && this._bl3Infos.Count > 0)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> list = global::Motorola.Common.Communication.TetraUtility.ShortInfo.FilterPairedHWComponent(radioHWConfig, this._bl3Infos);
				if (list.Count >= 0)
				{
					return list.Last<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection>().Path;
				}
			}
			return null;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0001480C File Offset: 0x00012A0C
		public string GetUpstartKernel(string radioHWConfig)
		{
			if (this._ukInfos != null && this._ukInfos.Count > 0)
			{
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> list = global::Motorola.Common.Communication.TetraUtility.ShortInfo.FilterPairedHWComponent(radioHWConfig, this._ukInfos);
				if (list.Count >= 0)
				{
					return list.Last<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection>().Path;
				}
			}
			return null;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00014858 File Offset: 0x00012A58
		public string GetFactoryUpstartKernelName()
		{
			if (this._fukInfos != null && this._fukInfos.Count > 0)
			{
				return this._fukInfos[0].Path;
			}
			return null;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00014894 File Offset: 0x00012A94
		public string BootLoader2Ver
		{
			get
			{
				if (this._bl2Infos != null && this._bl2Infos.Count > 0)
				{
					return global::Motorola.Common.Communication.TetraUtility.ShortInfo.GetPlatFileVersion(this._bl2Infos[0].Path);
				}
				return null;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x000148D4 File Offset: 0x00012AD4
		public string BootLoader3Ver
		{
			get
			{
				if (this._bl3Infos != null && this._bl3Infos.Count > 0)
				{
					return global::Motorola.Common.Communication.TetraUtility.ShortInfo.GetPlatFileVersion(this._bl3Infos[0].Path);
				}
				return null;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00014914 File Offset: 0x00012B14
		public string UpstartKernelVer
		{
			get
			{
				if (this._ukInfos != null && this._ukInfos.Count > 0)
				{
					return global::Motorola.Common.Communication.TetraUtility.ShortInfo.GetPlatFileVersion(this._ukInfos[0].Path);
				}
				return null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00014952 File Offset: 0x00012B52
		public bool ContainsFuk
		{
			get
			{
				return this._fukInfos != null && this._fukInfos.Count > 0;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x0001496C File Offset: 0x00012B6C
		public bool ContainsHwComponents
		{
			get
			{
				return this._hwComponentInfos != null && this._hwComponentInfos.Count > 0;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00014988 File Offset: 0x00012B88
		public string HwComponentFolderName
		{
			get
			{
				if (this._hwComponentInfos != null && this._hwComponentInfos.Count > 0)
				{
					return this._hwComponentInfos[0].Path;
				}
				return null;
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000149C4 File Offset: 0x00012BC4
		public string[] GetFlashPack(string radioHWConfig)
		{
			if (this._fpInfos == null || this._fpInfos.Count == 0)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> list = global::Motorola.Common.Communication.TetraUtility.ShortInfo.FilterPairedHWComponent(radioHWConfig, this._fpInfos);
			string[] array = new string[list.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = list[i].Path;
			}
			return array;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00014A24 File Offset: 0x00012C24
		private static string GetPlatFileVersion(string fileName)
		{
			string fileNameWithoutExtension = global::System.IO.Path.GetFileNameWithoutExtension(fileName);
			string[] array = fileNameWithoutExtension.Split(new char[]
			{
				'-'
			});
			return array[1];
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00014A50 File Offset: 0x00012C50
		private void ParseHWCompoentInfo(string readLine)
		{
			string text;
			string[] hwConfigurationInfo;
			string text2;
			if (this.VerifyHWCompoentInfo(readLine, out text, out hwConfigurationInfo, out text2))
			{
				global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection item = new global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection(hwConfigurationInfo, text2);
				string key;
				switch (key = text)
				{
				case "DRM_PATH":
					if (this._fpInfos == null)
					{
						this._fpInfos = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection>();
					}
					this._fpInfos.Add(item);
					return;
				case "BL2":
					if (this._bl2Infos == null)
					{
						this._bl2Infos = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection>();
					}
					this._bl2Infos.Add(item);
					return;
				case "BL3":
					if (this._bl3Infos == null)
					{
						this._bl3Infos = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection>();
					}
					this._bl3Infos.Add(item);
					return;
				case "UK":
					if (this._ukInfos == null)
					{
						this._ukInfos = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection>();
					}
					this._ukInfos.Add(item);
					return;
				case "FUK":
					if (this._fukInfos == null)
					{
						this._fukInfos = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection>();
					}
					this._fukInfos.Add(item);
					return;
				case "HW_COMPONENTS":
					if (this._hwComponentInfos == null)
					{
						this._hwComponentInfos = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection>();
					}
					item.Path = text2.Replace("\\", "");
					this._hwComponentInfos.Add(item);
					return;

					return;
				}
				return;
			}
			throw new global::Motorola.Common.Communication.TetraUtility.CCustomException("not formal z19 files:" + readLine);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00014BFC File Offset: 0x00012DFC
		private bool VerifyHWCompoentInfo(string readLine, out string tag, out string[] hw_configuration_info, out string path)
		{
			global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(readLine, "^([a-zA-Z_][a-zA-Z0-9_]*)(\\[(\\s*[0-9]+:[0-9]+(\\s*,\\s*[0-9]+:[0-9]+)*\\s*)\\])?\\s*->\\s*((\\\\.*\\\\)|(\\S*))$");
			if (match == null || !match.Success)
			{
				tag = null;
				hw_configuration_info = null;
				path = null;
				return false;
			}
			tag = match.Groups[1].Value;
			string value = match.Groups[3].Value;
			path = match.Groups[5].Value;
			hw_configuration_info = value.Trim().Split(new char[]
			{
				','
			}, global::System.StringSplitOptions.RemoveEmptyEntries);
			return true;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00014C84 File Offset: 0x00012E84
		private static global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> FilterPairedHWComponent(string radioHWConfig, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> hwComponentInfos)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection>();
			string[] radioHWConfig2 = radioHWConfig.Split(new char[]
			{
				','
			});
			for (int i = 0; i < hwComponentInfos.Count; i++)
			{
				if (global::Motorola.Common.Communication.TetraUtility.ShortInfo.CompareHWConfiguration(radioHWConfig2, hwComponentInfos[i].HWConfigurationInfo))
				{
					list.Add(hwComponentInfos[i]);
				}
			}
			global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection item = new global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection(new string[0], "");
			list.Insert(0, item);
			global::Motorola.Common.Communication.TetraUtility.ShortInfo.SortHWComponentInfos(ref list);
			return list;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00014D08 File Offset: 0x00012F08
		private static bool CompareHWConfiguration(string[] radioHWConfig, string[] shortinfoHWConfig)
		{
			for (int i = 0; i < shortinfoHWConfig.Count<string>(); i++)
			{
				int num = 0;
				while (num < radioHWConfig.Count<string>() && !(shortinfoHWConfig[i].Trim() == radioHWConfig[num].Trim()))
				{
					if (num == radioHWConfig.Count<string>() - 1)
					{
						return false;
					}
					num++;
				}
			}
			return true;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00014D5C File Offset: 0x00012F5C
		private static void SortHWComponentInfos(ref global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> matchedHWComponentInfos)
		{
			for (int i = 0; i < matchedHWComponentInfos.Count - 1; i++)
			{
				for (int j = 0; j < matchedHWComponentInfos.Count - i - 1; j++)
				{
					if (matchedHWComponentInfos[j].HWConfigurationInfo.Count<string>() > matchedHWComponentInfos[j + 1].HWConfigurationInfo.Count<string>())
					{
						global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection value = default(global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection);
						value = matchedHWComponentInfos[j];
						matchedHWComponentInfos[j] = matchedHWComponentInfos[j + 1];
						matchedHWComponentInfos[j + 1] = value;
					}
				}
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00014E10 File Offset: 0x00013010
		internal bool IsBootLoader2S19(string fileName)
		{
			return this._bl2Infos != null && this._bl2Infos.FindIndex((global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection x) => x.Path == fileName) >= 0;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00014E70 File Offset: 0x00013070
		internal bool IsBootLoader3S19(string fileName)
		{
			return this._bl3Infos != null && this._bl3Infos.FindIndex((global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection x) => x.Path == fileName) >= 0;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00014ED0 File Offset: 0x000130D0
		internal bool IsUpstartKernelS19(string fileName)
		{
			return this._ukInfos != null && this._ukInfos.FindIndex((global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection x) => x.Path == fileName) >= 0;
		}

		// Token: 0x0400042A RID: 1066
		private const string TAG_DRM_PATH = "DRM_PATH";

		// Token: 0x0400042B RID: 1067
		private const string TAG_BL2 = "BL2";

		// Token: 0x0400042C RID: 1068
		private const string TAG_BL3 = "BL3";

		// Token: 0x0400042D RID: 1069
		private const string TAG_UK = "UK";

		// Token: 0x0400042E RID: 1070
		private const string TAG_FUK = "FUK";

		// Token: 0x0400042F RID: 1071
		private const string TAG_HWCOMPONENTS = "HW_COMPONENTS";

		// Token: 0x04000430 RID: 1072
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> _bl2Infos;

		// Token: 0x04000431 RID: 1073
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> _bl3Infos;

		// Token: 0x04000432 RID: 1074
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> _ukInfos;

		// Token: 0x04000433 RID: 1075
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> _fpInfos;

		// Token: 0x04000434 RID: 1076
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> _fukInfos;

		// Token: 0x04000435 RID: 1077
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection> _hwComponentInfos;

		// Token: 0x0200008B RID: 139
		private struct HWConfigurationInfoSection
		{
			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060003B3 RID: 947 RVA: 0x00014F11 File Offset: 0x00013111
			// (set) Token: 0x060003B4 RID: 948 RVA: 0x00014F19 File Offset: 0x00013119
			public string[] HWConfigurationInfo { get; set; }

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060003B5 RID: 949 RVA: 0x00014F22 File Offset: 0x00013122
			// (set) Token: 0x060003B6 RID: 950 RVA: 0x00014F2A File Offset: 0x0001312A
			public string Path { get; set; }

			// Token: 0x060003B7 RID: 951 RVA: 0x00014F33 File Offset: 0x00013133
			public HWConfigurationInfoSection(string[] hwConfigurationInfo, string path)
			{
				this = default(global::Motorola.Common.Communication.TetraUtility.ShortInfo.HWConfigurationInfoSection);
				this.HWConfigurationInfo = hwConfigurationInfo;
				this.Path = path;
			}
		}
	}
}
