using System;
using System.Text;
using System.Threading;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200004F RID: 79
	public sealed class ZipConstants
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x000106BC File Offset: 0x0000F6BC
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x000106C3 File Offset: 0x0000F6C3
		public static int DefaultCodePage
		{
			get
			{
				return global::ICSharpCode.SharpZipLib.Zip.ZipConstants.defaultCodePage;
			}
			set
			{
				global::ICSharpCode.SharpZipLib.Zip.ZipConstants.defaultCodePage = value;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000106CB File Offset: 0x0000F6CB
		public static string ConvertToString(byte[] data, int count)
		{
			if (data == null)
			{
				return string.Empty;
			}
			return global::System.Text.Encoding.GetEncoding(global::ICSharpCode.SharpZipLib.Zip.ZipConstants.DefaultCodePage).GetString(data, 0, count);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000106E8 File Offset: 0x0000F6E8
		public static string ConvertToString(byte[] data)
		{
			if (data == null)
			{
				return string.Empty;
			}
			return global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToString(data, data.Length);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000106FC File Offset: 0x0000F6FC
		public static string ConvertToStringExt(int flags, byte[] data, int count)
		{
			if (data == null)
			{
				return string.Empty;
			}
			if ((flags & 2048) != 0)
			{
				return global::System.Text.Encoding.UTF8.GetString(data, 0, count);
			}
			return global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToString(data, count);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00010725 File Offset: 0x0000F725
		public static string ConvertToStringExt(int flags, byte[] data)
		{
			if (data == null)
			{
				return string.Empty;
			}
			if ((flags & 2048) != 0)
			{
				return global::System.Text.Encoding.UTF8.GetString(data, 0, data.Length);
			}
			return global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToString(data, data.Length);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00010752 File Offset: 0x0000F752
		public static byte[] ConvertToArray(string str)
		{
			if (str == null)
			{
				return new byte[0];
			}
			return global::System.Text.Encoding.GetEncoding(global::ICSharpCode.SharpZipLib.Zip.ZipConstants.DefaultCodePage).GetBytes(str);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0001076E File Offset: 0x0000F76E
		public static byte[] ConvertToArray(int flags, string str)
		{
			if (str == null)
			{
				return new byte[0];
			}
			if ((flags & 2048) != 0)
			{
				return global::System.Text.Encoding.UTF8.GetBytes(str);
			}
			return global::ICSharpCode.SharpZipLib.Zip.ZipConstants.ConvertToArray(str);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00010795 File Offset: 0x0000F795
		private ZipConstants()
		{
		}

		// Token: 0x04000213 RID: 531
		public const int VersionMadeBy = 45;

		// Token: 0x04000214 RID: 532
		[global::System.Obsolete("Use VersionMadeBy instead")]
		public const int VERSION_MADE_BY = 45;

		// Token: 0x04000215 RID: 533
		public const int VersionStrongEncryption = 50;

		// Token: 0x04000216 RID: 534
		[global::System.Obsolete("Use VersionStrongEncryption instead")]
		public const int VERSION_STRONG_ENCRYPTION = 50;

		// Token: 0x04000217 RID: 535
		public const int VersionZip64 = 45;

		// Token: 0x04000218 RID: 536
		public const int LocalHeaderBaseSize = 30;

		// Token: 0x04000219 RID: 537
		[global::System.Obsolete("Use LocalHeaderBaseSize instead")]
		public const int LOCHDR = 30;

		// Token: 0x0400021A RID: 538
		public const int Zip64DataDescriptorSize = 24;

		// Token: 0x0400021B RID: 539
		public const int DataDescriptorSize = 16;

		// Token: 0x0400021C RID: 540
		[global::System.Obsolete("Use DataDescriptorSize instead")]
		public const int EXTHDR = 16;

		// Token: 0x0400021D RID: 541
		public const int CentralHeaderBaseSize = 46;

		// Token: 0x0400021E RID: 542
		[global::System.Obsolete("Use CentralHeaderBaseSize instead")]
		public const int CENHDR = 46;

		// Token: 0x0400021F RID: 543
		public const int EndOfCentralRecordBaseSize = 22;

		// Token: 0x04000220 RID: 544
		[global::System.Obsolete("Use EndOfCentralRecordBaseSize instead")]
		public const int ENDHDR = 22;

		// Token: 0x04000221 RID: 545
		public const int CryptoHeaderSize = 12;

		// Token: 0x04000222 RID: 546
		[global::System.Obsolete("Use CryptoHeaderSize instead")]
		public const int CRYPTO_HEADER_SIZE = 12;

		// Token: 0x04000223 RID: 547
		public const int LocalHeaderSignature = 67324752;

		// Token: 0x04000224 RID: 548
		[global::System.Obsolete("Use LocalHeaderSignature instead")]
		public const int LOCSIG = 67324752;

		// Token: 0x04000225 RID: 549
		public const int SpanningSignature = 134695760;

		// Token: 0x04000226 RID: 550
		[global::System.Obsolete("Use SpanningSignature instead")]
		public const int SPANNINGSIG = 134695760;

		// Token: 0x04000227 RID: 551
		public const int SpanningTempSignature = 808471376;

		// Token: 0x04000228 RID: 552
		[global::System.Obsolete("Use SpanningTempSignature instead")]
		public const int SPANTEMPSIG = 808471376;

		// Token: 0x04000229 RID: 553
		public const int DataDescriptorSignature = 134695760;

		// Token: 0x0400022A RID: 554
		[global::System.Obsolete("Use DataDescriptorSignature instead")]
		public const int EXTSIG = 134695760;

		// Token: 0x0400022B RID: 555
		[global::System.Obsolete("Use CentralHeaderSignature instead")]
		public const int CENSIG = 33639248;

		// Token: 0x0400022C RID: 556
		public const int CentralHeaderSignature = 33639248;

		// Token: 0x0400022D RID: 557
		public const int Zip64CentralFileHeaderSignature = 101075792;

		// Token: 0x0400022E RID: 558
		[global::System.Obsolete("Use Zip64CentralFileHeaderSignature instead")]
		public const int CENSIG64 = 101075792;

		// Token: 0x0400022F RID: 559
		public const int Zip64CentralDirLocatorSignature = 117853008;

		// Token: 0x04000230 RID: 560
		public const int ArchiveExtraDataSignature = 117853008;

		// Token: 0x04000231 RID: 561
		public const int CentralHeaderDigitalSignature = 84233040;

		// Token: 0x04000232 RID: 562
		[global::System.Obsolete("Use CentralHeaderDigitalSignaure instead")]
		public const int CENDIGITALSIG = 84233040;

		// Token: 0x04000233 RID: 563
		public const int EndOfCentralDirectorySignature = 101010256;

		// Token: 0x04000234 RID: 564
		[global::System.Obsolete("Use EndOfCentralDirectorySignature instead")]
		public const int ENDSIG = 101010256;

		// Token: 0x04000235 RID: 565
		private static int defaultCodePage = global::System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.OEMCodePage;
	}
}
