using System;
using System.Text;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000019 RID: 25
	[global::System.Serializable]
	public class ReleaseIDData
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00007520 File Offset: 0x00005720
		public void GetInfowithoutFPfromRaw(byte[] raw)
		{
			byte[] array = new byte["Copyright (C) 1996-2007 Motorola Inc. All rights reserved.".Length + 1];
			uint num = 0U;
			global::System.Array.Copy(raw, (long)((ulong)num), array, 0L, (long)("Copyright (C) 1996-2007 Motorola Inc. All rights reserved.".Length + 1));
			num += (uint)("Copyright (C) 1996-2007 Motorola Inc. All rights reserved.".Length + 1 + 1);
			global::System.Text.Encoding ascii = global::System.Text.Encoding.ASCII;
			this.copyrightString = ascii.GetString(array);
			int num2 = this.copyrightString.IndexOf('\0');
			if (num2 >= 1)
			{
				this.copyrightString = this.copyrightString.Substring(0, num2);
			}
			array = new byte[19];
			global::System.Array.Copy(raw, (long)((ulong)num), array, 0L, 19L);
			num += 19U;
			this.releaseVersionData = ascii.GetString(array);
			num2 = this.releaseVersionData.IndexOf('\0');
			if (num2 >= 1)
			{
				this.releaseVersionData = this.releaseVersionData.Substring(0, num2);
			}
			array = new byte["Sun Jul 13 18:00:44 EST 2003".Length + 1];
			global::System.Array.Copy(raw, (long)((ulong)num), array, 0L, (long)("Sun Jul 13 18:00:44 EST 2003".Length + 1));
			num += (uint)("Sun Jul 13 18:00:44 EST 2003".Length + 1 + 1);
			this.buildDateTag = ascii.GetString(array);
			num2 = this.buildDateTag.IndexOf('\0');
			if (num2 >= 1)
			{
				this.buildDateTag = this.buildDateTag.Substring(0, num2);
			}
			array = new byte[4];
			global::System.Array.Copy(raw, (long)((ulong)num), array, 0L, 4L);
			num += 7U;
			this.resetReasonSignature = ascii.GetString(array);
			num2 = this.resetReasonSignature.IndexOf('\0');
			if (num2 >= 1)
			{
				this.resetReasonSignature = this.resetReasonSignature.Substring(0, num2);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000076A8 File Offset: 0x000058A8
		public void GetInfowithFPfromRaw(byte[] raw)
		{
			byte[] array = new byte["Copyright (C) 1996,97,98,99,2002 Motorola Inc. All rights reserved.".Length + 1];
			uint num = 0U;
			global::System.Array.Copy(raw, (long)((ulong)num), array, 0L, (long)("Copyright (C) 1996,97,98,99,2002 Motorola Inc. All rights reserved.".Length + 1));
			num += (uint)("Copyright (C) 1996,97,98,99,2002 Motorola Inc. All rights reserved.".Length + 1 + 1);
			global::System.Text.Encoding ascii = global::System.Text.Encoding.ASCII;
			this.copyrightString = ascii.GetString(array);
			int num2 = this.copyrightString.IndexOf('\0');
			if (num2 >= 1)
			{
				this.copyrightString = this.copyrightString.Substring(0, num2);
			}
			array = new byte[22];
			global::System.Array.Copy(raw, (long)((ulong)num), array, 0L, 22L);
			num += 22U;
			this.releaseVersionData = ascii.GetString(array);
			num2 = this.releaseVersionData.IndexOf('\0');
			if (num2 >= 1)
			{
				if (num2 >= 13)
				{
					this.releaseVersionData = this.releaseVersionData.Substring(0, 13).TrimEnd(new char[0]);
				}
				else
				{
					this.releaseVersionData = this.releaseVersionData.Substring(0, num2);
				}
			}
			array = new byte["Sun Jul 13 18:00:44 EST 2003".Length + 1];
			global::System.Array.Copy(raw, (long)((ulong)num), array, 0L, (long)("Sun Jul 13 18:00:44 EST 2003".Length + 1));
			num += (uint)("Sun Jul 13 18:00:44 EST 2003".Length + 1 + 1);
			this.buildDateTag = ascii.GetString(array);
			num2 = this.buildDateTag.IndexOf('\0');
			if (num2 >= 1)
			{
				this.buildDateTag = this.buildDateTag.Substring(0, num2);
			}
			array = new byte[4];
			global::System.Array.Copy(raw, (long)((ulong)num), array, 0L, 4L);
			num += 7U;
			this.resetReasonSignature = ascii.GetString(array);
			num2 = this.resetReasonSignature.IndexOf('\0');
			if (num2 >= 1)
			{
				this.resetReasonSignature = this.resetReasonSignature.Substring(0, num2);
			}
			this.flashPackInfo.GetDatafromRaw(raw, num);
		}

		// Token: 0x0400004C RID: 76
		public const uint TETRA_REALEASE_VERSION_SIZE = 22U;

		// Token: 0x0400004D RID: 77
		public const string MOTOROLA_COPYRIGHT = "Copyright (C) 1996,97,98,99,2002 Motorola Inc. All rights reserved.";

		// Token: 0x0400004E RID: 78
		public const uint RESET_REASON_SIGNATURE = 402658055U;

		// Token: 0x0400004F RID: 79
		public const string TETRA_BUILD_DATE = "Sun Jul 13 18:00:44 EST 2003";

		// Token: 0x04000050 RID: 80
		public const string MOTOROLA_COPYRIGHT_MILAN2 = "Copyright (C) 1996-2007 Motorola Inc. All rights reserved.";

		// Token: 0x04000051 RID: 81
		public const uint MILAN2_TETRA_REALEASE_VERSION_SIZE = 19U;

		// Token: 0x04000052 RID: 82
		public const string MOTOROLA_INC = "Motorola Inc";

		// Token: 0x04000053 RID: 83
		public const string MOTOROLA_SOLUTION_INC = "Motorola Solutions";

		// Token: 0x04000054 RID: 84
		public const ushort UNKNOWN_PlATFORM = 0;

		// Token: 0x04000055 RID: 85
		public const ushort UNKNOWN_VERSION = 0;

		// Token: 0x04000056 RID: 86
		public const uint DEFAULT_FP_MODEL = 65065U;

		// Token: 0x04000057 RID: 87
		public const uint DEFAULT_FP_HWID = 1316U;

		// Token: 0x04000058 RID: 88
		public const uint BOROMIR_FP_MODEL = 5603U;

		// Token: 0x04000059 RID: 89
		public string copyrightString;

		// Token: 0x0400005A RID: 90
		public string releaseVersionData;

		// Token: 0x0400005B RID: 91
		public string buildDateTag;

		// Token: 0x0400005C RID: 92
		public string resetReasonSignature;

		// Token: 0x0400005D RID: 93
		public global::Motorola.Common.Communication.CommonUtil.fp_info_t flashPackInfo = new global::Motorola.Common.Communication.CommonUtil.fp_info_t();
	}
}
