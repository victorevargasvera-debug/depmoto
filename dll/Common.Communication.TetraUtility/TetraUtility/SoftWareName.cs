using System;
using System.IO;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200006F RID: 111
	public class SoftWareName
	{
		// Token: 0x06000295 RID: 661 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
		public SoftWareName(string fullname)
		{
			try
			{
				fullname = global::System.IO.Path.GetFileName(fullname).Trim();
				fullname = string.Format("{0}{1}", fullname.Substring(0, 1).ToUpperInvariant(), fullname.Substring(1, fullname.Length - 1));
				if (fullname.ToUpperInvariant().EndsWith(".Z19", global::System.StringComparison.Ordinal) || fullname.ToUpperInvariant().EndsWith(".S19", global::System.StringComparison.Ordinal))
				{
					fullname = fullname.Substring(0, fullname.Length - 4);
				}
				if (!fullname.Contains("."))
				{
					fullname = string.Format("{0}.{1}.{2}", fullname.Substring(0, 3), fullname.Substring(3, 3), fullname.Substring(6));
				}
				fullname = global::System.Text.RegularExpressions.Regex.Replace(fullname, "[^\\u0000-\\u007F]", "").Trim();
				global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("^(?<release_type>[a-zA-Z]{1})(?<platform_id>\\d{2})\\.?(?<e2e_type>\\d{1})(?<tea_type>\\d{1})\\d{1}\\.?(?<sw_version>\\d{4}[a-zA-Z]?)$");
				global::System.Text.RegularExpressions.Match match = regex.Match(fullname);
				if (!match.Success)
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "software name is invalid,3!");
				}
				this.SWVersion = fullname;
				this.ReleaseType = match.Groups["release_type"].Value;
				this.PlatformID = match.Groups["platform_id"].Value;
				this.E2EType = match.Groups["e2e_type"].Value;
				this.TEAType = match.Groups["tea_type"].Value;
				this.VersionStr = match.Groups["sw_version"].Value;
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD0005_RH_CommErrInvalidParameter.ToString(), "software name is invalid,4!", innerException);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000C9BC File Offset: 0x0000ABBC
		public static bool IsEqual(string appImageX, string appImageY)
		{
			global::Motorola.Common.Communication.TetraUtility.SoftWareName softWareName = global::Motorola.Common.Communication.TetraUtility.SoftWareName.ValidateSoftWareName(appImageX);
			global::Motorola.Common.Communication.TetraUtility.SoftWareName softWareName2 = global::Motorola.Common.Communication.TetraUtility.SoftWareName.ValidateSoftWareName(appImageY);
			return softWareName != null && softWareName2 != null && softWareName.SWVersion == softWareName2.SWVersion;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		public static global::Motorola.Common.Communication.TetraUtility.SoftWareName ValidateSoftWareName(string fullname)
		{
			global::Motorola.Common.Communication.TetraUtility.SoftWareName result;
			try
			{
				if (string.IsNullOrEmpty(fullname))
				{
					result = null;
				}
				else
				{
					global::Motorola.Common.Communication.TetraUtility.SoftWareName softWareName = new global::Motorola.Common.Communication.TetraUtility.SoftWareName(fullname);
					result = softWareName;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000CA2C File Offset: 0x0000AC2C
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0000CA34 File Offset: 0x0000AC34
		public string SWVersion { get; private set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000CA3D File Offset: 0x0000AC3D
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0000CA45 File Offset: 0x0000AC45
		public string ReleaseType { get; private set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000CA4E File Offset: 0x0000AC4E
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0000CA56 File Offset: 0x0000AC56
		public string PlatformID { get; private set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000CA5F File Offset: 0x0000AC5F
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0000CA67 File Offset: 0x0000AC67
		public string E2EType { get; private set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000CA70 File Offset: 0x0000AC70
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0000CA78 File Offset: 0x0000AC78
		public string TEAType { get; private set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000CA81 File Offset: 0x0000AC81
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0000CA89 File Offset: 0x0000AC89
		public string VersionStr { get; private set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000CA92 File Offset: 0x0000AC92
		public uint PureVersion
		{
			get
			{
				return uint.Parse(this.PureVersionStr);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000CA9F File Offset: 0x0000AC9F
		public string PureVersionStr
		{
			get
			{
				return this.VersionStr.Substring(0, 4);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000CAAE File Offset: 0x0000ACAE
		public string SWVersionNoDot
		{
			get
			{
				return this.SWVersion.Replace(".", "");
			}
		}

		// Token: 0x04000301 RID: 769
		private const int PRODUCT_LINE_NAME_LENGTH = 3;

		// Token: 0x04000302 RID: 770
		private const int SOFTWARE_E2E_TYPE_LENGTH = 3;

		// Token: 0x04000303 RID: 771
		private const int SOFTWARE_VERSION_LENGTH = 4;

		// Token: 0x04000304 RID: 772
		private const string SOFTWARE_VERSION_PATTERN = "(?<release_type>[a-zA-Z]{1})(?<platform_id>\\d{2})\\.?(?<e2e_type>\\d{1})(?<tea_type>\\d{1})\\d{1}\\.?(?<sw_version>\\d{4}[a-zA-Z]?)";

		// Token: 0x04000305 RID: 773
		private const string SOFTWARE_VERSION_RELEASE_TYPE_GROUP = "release_type";

		// Token: 0x04000306 RID: 774
		private const string SOFTWARE_VERSION_PLATFORM_ID_GROUP = "platform_id";

		// Token: 0x04000307 RID: 775
		private const string SOFTWARE_VERSION_E2E_TYPE_GROUP = "e2e_type";

		// Token: 0x04000308 RID: 776
		private const string SOFTWARE_VERSION_TEA_TYPE_GROUP = "tea_type";

		// Token: 0x04000309 RID: 777
		private const string SOFTWARE_VERSION_VERSION_GROUP = "sw_version";
	}
}
