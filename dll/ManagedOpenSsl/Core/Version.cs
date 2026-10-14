using System;
using System.Text;

namespace OpenSSL.Core
{
	// Token: 0x02000075 RID: 117
	public class Version
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x000090A0 File Offset: 0x000072A0
		public static global::OpenSSL.Core.Version Library
		{
			get
			{
				return new global::OpenSSL.Core.Version(global::OpenSSL.Core.Native.SSLeay());
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x000090AC File Offset: 0x000072AC
		public static global::OpenSSL.Core.Version Wrapper
		{
			get
			{
				return new global::OpenSSL.Core.Version(268435456U);
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000090B8 File Offset: 0x000072B8
		public Version(uint raw)
		{
			this.raw = raw;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x000090C7 File Offset: 0x000072C7
		public uint Major
		{
			get
			{
				return (this.raw & 4026531840U) >> 28;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x000090D8 File Offset: 0x000072D8
		public uint Minor
		{
			get
			{
				return (this.raw & 267386880U) >> 20;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x000090E9 File Offset: 0x000072E9
		public uint Fix
		{
			get
			{
				return (this.raw & 1044480U) >> 12;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x000090FC File Offset: 0x000072FC
		public char Patch
		{
			get
			{
				uint num = (this.raw & 4080U) >> 4;
				byte b = global::System.Text.Encoding.ASCII.GetBytes("a")[0];
				uint num2 = (uint)b + num;
				return global::System.Text.Encoding.ASCII.GetString(new byte[]
				{
					(byte)num2
				})[0];
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00009150 File Offset: 0x00007350
		public global::OpenSSL.Core.Version.StatusType Status
		{
			get
			{
				uint rawStatus = this.RawStatus;
				if (rawStatus == 0U)
				{
					return global::OpenSSL.Core.Version.StatusType.Development;
				}
				if (rawStatus == 15U)
				{
					return global::OpenSSL.Core.Version.StatusType.Release;
				}
				return global::OpenSSL.Core.Version.StatusType.Beta;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00009171 File Offset: 0x00007371
		public uint Raw
		{
			get
			{
				return this.raw;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00009179 File Offset: 0x00007379
		public uint RawStatus
		{
			get
			{
				return this.raw & 15U;
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00009184 File Offset: 0x00007384
		public override string ToString()
		{
			return string.Format("{0}.{1}.{2}{3} {4}", new object[]
			{
				this.Major,
				this.Minor,
				this.Fix,
				this.Patch,
				this.Status
			});
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000091E9 File Offset: 0x000073E9
		public static string GetText(global::OpenSSL.Core.Version.Format format)
		{
			return global::OpenSSL.Core.Native.SSLeay_version((int)format);
		}

		// Token: 0x040003B4 RID: 948
		private uint raw;

		// Token: 0x02000076 RID: 118
		public enum StatusType
		{
			// Token: 0x040003B6 RID: 950
			Development,
			// Token: 0x040003B7 RID: 951
			Beta,
			// Token: 0x040003B8 RID: 952
			Release
		}

		// Token: 0x02000077 RID: 119
		public enum Format
		{
			// Token: 0x040003BA RID: 954
			Text,
			// Token: 0x040003BB RID: 955
			CompilerFlags = 2,
			// Token: 0x040003BC RID: 956
			BuildDate,
			// Token: 0x040003BD RID: 957
			Platform,
			// Token: 0x040003BE RID: 958
			BuildDirectory
		}
	}
}
