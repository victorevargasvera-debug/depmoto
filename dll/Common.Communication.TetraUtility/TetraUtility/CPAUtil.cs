using System;
using System.Linq;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200000B RID: 11
	public static class CPAUtil
	{
		// Token: 0x06000046 RID: 70 RVA: 0x0000547A File Offset: 0x0000367A
		public static uint AMC(byte[] ARP, byte[] DUP, int homeMcc)
		{
			if (homeMcc == -1)
			{
				return (uint)homeMcc;
			}
			if (!global::Motorola.Common.Communication.TetraUtility.MCCConverter.IsHomeMccEncrypted((uint)homeMcc))
			{
				return (uint)homeMcc;
			}
			if (global::Motorola.Common.Communication.TetraUtility.CPAUtil.Co(ARP))
			{
				return global::Motorola.Common.Communication.TetraUtility.MCCConverter.DecrypteHomeMcc((uint)homeMcc);
			}
			if (DUP != null && ARP != null && global::Motorola.Common.Communication.TetraUtility.CPAUtil.Vr(ARP, DUP))
			{
				return global::Motorola.Common.Communication.TetraUtility.MCCConverter.DecrypteHomeMcc((uint)homeMcc);
			}
			return (uint)homeMcc;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000054B4 File Offset: 0x000036B4
		public static bool Vr(byte[] rpp, byte[] upp)
		{
			if (rpp == null || global::Motorola.Common.Communication.TetraUtility.CPAUtil.IsEmptyPassword(rpp))
			{
				return true;
			}
			if (upp == null)
			{
				return false;
			}
			byte[] upp2 = global::Motorola.Common.Communication.TetraUtility.CPAUtil.Gr(rpp);
			return global::Motorola.Common.Communication.TetraUtility.CPAUtil.IsArrayEqual(upp2, upp);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000054E4 File Offset: 0x000036E4
		public static byte[] Gr(byte[] rpp)
		{
			if (rpp == null)
			{
				return null;
			}
			byte[] array = new byte[global::Motorola.Common.Communication.TetraUtility.CPAUtil.rppByteLen];
			global::System.Array.Copy(rpp, global::Motorola.Common.Communication.TetraUtility.CPAUtil.rppHeadByteLen, array, 0, global::Motorola.Common.Communication.TetraUtility.CPAUtil.rppByteLen);
			return array;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005514 File Offset: 0x00003714
		private static bool Co(byte[] rpp)
		{
			if (rpp == null || global::Motorola.Common.Communication.TetraUtility.CPAUtil.IsEmptyPassword(rpp))
			{
				return true;
			}
			byte b = rpp[0];
			return b != 0 && (b & 2) == 0;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005540 File Offset: 0x00003740
		private static bool IsArrayEqual(byte[] upp, byte[] caPassword)
		{
			if (upp == null && caPassword == null)
			{
				return true;
			}
			if (upp == null || caPassword == null)
			{
				return false;
			}
			if (upp.Length != caPassword.Length)
			{
				return false;
			}
			for (int i = 0; i < upp.Length; i++)
			{
				if (caPassword[i] != upp[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005589 File Offset: 0x00003789
		public static bool IsEmptyPassword(byte[] buf)
		{
			if (buf == null)
			{
				return true;
			}
			return !buf.Any((byte x) => x != 0);
		}

		// Token: 0x0400001A RID: 26
		public static readonly int maxQuenSize = 5;

		// Token: 0x0400001B RID: 27
		public static readonly int rppByteLen = 32;

		// Token: 0x0400001C RID: 28
		public static readonly int rppHeadByteLen = 8;

		// Token: 0x0400001D RID: 29
		public static readonly int MaxAuthenTimes = 10;
	}
}
