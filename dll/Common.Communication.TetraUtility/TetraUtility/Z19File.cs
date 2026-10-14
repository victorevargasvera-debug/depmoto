using System;
using System.Collections.Generic;
using System.IO;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200008C RID: 140
	public class Z19File
	{
		// Token: 0x060003B8 RID: 952 RVA: 0x00014F4A File Offset: 0x0001314A
		public Z19File()
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00014F52 File Offset: 0x00013152
		public Z19File(string archivePath)
		{
			this.LoadFile(archivePath);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00014F61 File Offset: 0x00013161
		public static void MakeZ19File(string fwS19File, string cpVer, string targetZ19File)
		{
			global::Motorola.Common.Communication.TetraUtility.Z19FileInternal.MakeZ19File(fwS19File, cpVer, targetZ19File);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00014F6B File Offset: 0x0001316B
		public void LoadFile(string archivePath)
		{
			this._archivePath = global::Motorola.Common.Communication.TetraUtility.Z19File.FormatArcheiveFilePath(archivePath);
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00014F7C File Offset: 0x0001317C
		public string CPVer
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.Z19FileInternal z19FileInternal = this.CreateOrGetCacheZ19File();
				return z19FileInternal.CPVer;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00014F98 File Offset: 0x00013198
		public string BootLoader2Ver
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.Z19FileInternal z19FileInternal = this.CreateOrGetCacheZ19File();
				return z19FileInternal.BootLoader2Ver;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00014FB4 File Offset: 0x000131B4
		public string BootLoader3Ver
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.Z19FileInternal z19FileInternal = this.CreateOrGetCacheZ19File();
				return z19FileInternal.BootLoader3Ver;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00014FD0 File Offset: 0x000131D0
		public string UpstartKernelVer
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.Z19FileInternal z19FileInternal = this.CreateOrGetCacheZ19File();
				return z19FileInternal.UpstartKernelVer;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00014FEC File Offset: 0x000131EC
		public bool ContainsBootLoader
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.Z19FileInternal z19FileInternal = this.CreateOrGetCacheZ19File();
				return z19FileInternal.ContainsBootLoader;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00015008 File Offset: 0x00013208
		public bool ContainsFuk
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.Z19FileInternal z19FileInternal = this.CreateOrGetCacheZ19File();
				return z19FileInternal.ContainsFuk;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00015024 File Offset: 0x00013224
		public bool ContainsHWComponent
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.Z19FileInternal z19FileInternal = this.CreateOrGetCacheZ19File();
				return z19FileInternal.ContainsHWComponent();
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00015040 File Offset: 0x00013240
		public global::Motorola.Common.Communication.TetraUtility.SRecord FirmwareRecord
		{
			get
			{
				global::Motorola.Common.Communication.TetraUtility.Z19FileInternal cacheZ19File = this.GetCacheZ19File();
				return cacheZ19File.FirmwareRecord;
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0001505C File Offset: 0x0001325C
		public global::Motorola.Common.Communication.TetraUtility.SRecord GetBootLoader2(string radioHWConfig)
		{
			global::Motorola.Common.Communication.TetraUtility.Z19FileInternal cacheZ19File = this.GetCacheZ19File();
			return cacheZ19File.GetBootLoader2(radioHWConfig);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00015078 File Offset: 0x00013278
		public global::Motorola.Common.Communication.TetraUtility.SRecord GetBootLoader3(string radioHWConfig)
		{
			global::Motorola.Common.Communication.TetraUtility.Z19FileInternal cacheZ19File = this.GetCacheZ19File();
			return cacheZ19File.GetBootLoader3Record(radioHWConfig);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00015094 File Offset: 0x00013294
		public global::Motorola.Common.Communication.TetraUtility.SRecord GetUpstartKernal(string radioHWConfig)
		{
			global::Motorola.Common.Communication.TetraUtility.Z19FileInternal cacheZ19File = this.GetCacheZ19File();
			return cacheZ19File.GetUpstartKernelRecord(radioHWConfig);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000150B0 File Offset: 0x000132B0
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.SRecord> FlashPacks(string hwConfig)
		{
			global::Motorola.Common.Communication.TetraUtility.Z19FileInternal cacheZ19File = this.GetCacheZ19File();
			return cacheZ19File.GetFlashPacks(hwConfig);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000150CC File Offset: 0x000132CC
		public byte[] GetFactoryUpstartKernal()
		{
			global::Motorola.Common.Communication.TetraUtility.Z19FileInternal cacheZ19File = this.GetCacheZ19File();
			return cacheZ19File.GetFactoryUpstartKernelRecord();
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000150E8 File Offset: 0x000132E8
		public global::System.Collections.Generic.List<string> HWComponentNames()
		{
			global::Motorola.Common.Communication.TetraUtility.Z19FileInternal cacheZ19File = this.GetCacheZ19File();
			return cacheZ19File.HWComponentNames;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00015104 File Offset: 0x00013304
		public global::Motorola.Common.Communication.TetraUtility.SRecord GetHwComponentByFileName(string fileName)
		{
			global::Motorola.Common.Communication.TetraUtility.Z19FileInternal cacheZ19File = this.GetCacheZ19File();
			return cacheZ19File.GetHwComponentByFileName(fileName);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00015120 File Offset: 0x00013320
		private global::Motorola.Common.Communication.TetraUtility.Z19FileInternal CreateOrGetCacheZ19File()
		{
			global::Motorola.Common.Communication.TetraUtility.Z19FileInternal result;
			lock (global::Motorola.Common.Communication.TetraUtility.Z19File._z19Cache)
			{
				if (global::Motorola.Common.Communication.TetraUtility.Z19File._z19Cache.ContainsKey(this._archivePath))
				{
					result = global::Motorola.Common.Communication.TetraUtility.Z19File._z19Cache[this._archivePath];
				}
				else
				{
					result = new global::Motorola.Common.Communication.TetraUtility.Z19FileInternal(this._archivePath);
				}
			}
			return result;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0001518C File Offset: 0x0001338C
		private global::Motorola.Common.Communication.TetraUtility.Z19FileInternal GetCacheZ19File()
		{
			global::Motorola.Common.Communication.TetraUtility.Z19FileInternal z19FileInternal;
			lock (global::Motorola.Common.Communication.TetraUtility.Z19File._z19Cache)
			{
				if (global::Motorola.Common.Communication.TetraUtility.Z19File._z19Cache.ContainsKey(this._archivePath))
				{
					z19FileInternal = global::Motorola.Common.Communication.TetraUtility.Z19File._z19Cache[this._archivePath];
				}
				else
				{
					z19FileInternal = new global::Motorola.Common.Communication.TetraUtility.Z19FileInternal(this._archivePath);
					this.CacheFile(this._archivePath, z19FileInternal);
				}
			}
			return z19FileInternal;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00015204 File Offset: 0x00013404
		private static string FormatArcheiveFilePath(string archeiveFile)
		{
			return global::System.IO.Path.GetFullPath(archeiveFile).ToLowerInvariant();
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00015214 File Offset: 0x00013414
		private void CacheFile(string archeiveFile, global::Motorola.Common.Communication.TetraUtility.Z19FileInternal z19File)
		{
			while (global::Motorola.Common.Communication.TetraUtility.Z19File._z19Cache.Count >= 4)
			{
				global::Motorola.Common.Communication.TetraUtility.Z19File._z19Cache.Remove(global::Motorola.Common.Communication.TetraUtility.Z19File._keyFIFO[0]);
				global::Motorola.Common.Communication.TetraUtility.Z19File._keyFIFO.RemoveAt(0);
			}
			global::Motorola.Common.Communication.TetraUtility.Z19File._z19Cache.Add(archeiveFile, z19File);
			global::Motorola.Common.Communication.TetraUtility.Z19File._keyFIFO.Add(archeiveFile);
		}

		// Token: 0x04000439 RID: 1081
		private const int CacheCount = 4;

		// Token: 0x0400043A RID: 1082
		private string _archivePath;

		// Token: 0x0400043B RID: 1083
		private static global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.Z19FileInternal> _z19Cache = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.TetraUtility.Z19FileInternal>();

		// Token: 0x0400043C RID: 1084
		private static global::System.Collections.Generic.List<string> _keyFIFO = new global::System.Collections.Generic.List<string>();
	}
}
