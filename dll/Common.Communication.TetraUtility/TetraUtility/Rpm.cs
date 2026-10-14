using System;
using System.Collections.Generic;
using System.Linq;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000009 RID: 9
	public class Rpm
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000051C1 File Offset: 0x000033C1
		public static global::Motorola.Common.Communication.TetraUtility.Rpm Instance
		{
			get
			{
				return global::Motorola.Common.Communication.TetraUtility.Rpm._instance;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000051C8 File Offset: 0x000033C8
		public byte[] dfRp
		{
			get
			{
				byte[] result;
				lock (this.passwordCache)
				{
					result = this.passwordCache.LastOrDefault<byte[]>();
				}
				return result;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005210 File Offset: 0x00003410
		public void Cdp()
		{
			lock (this.passwordCache)
			{
				this.passwordCache.Clear();
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005258 File Offset: 0x00003458
		public int GetCaCount()
		{
			int count;
			lock (this.passwordCache)
			{
				count = this.passwordCache.Count;
			}
			return count;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000052A0 File Offset: 0x000034A0
		public void Adp(global::System.Collections.Generic.List<byte[]> usrpList)
		{
			if (usrpList == null || usrpList.Count == 0)
			{
				return;
			}
			lock (this.passwordCache)
			{
				this.passwordCache.Clear();
				foreach (byte[] item in usrpList)
				{
					while (this.passwordCache.Count >= global::Motorola.Common.Communication.TetraUtility.Rpm.maxQuenSize)
					{
						this.passwordCache.Dequeue();
					}
					this.passwordCache.Enqueue(item);
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005354 File Offset: 0x00003554
		public void Aca(byte[] rpp, ref byte[] upp)
		{
			if (rpp == null || global::Motorola.Common.Communication.TetraUtility.CPAUtil.IsEmptyPassword(rpp))
			{
				return;
			}
			if (this.Co(rpp))
			{
				if (upp == null)
				{
					upp = new byte[global::Motorola.Common.Communication.TetraUtility.CPAUtil.rppByteLen];
				}
				return;
			}
			lock (this.passwordCache)
			{
				foreach (byte[] array in this.passwordCache)
				{
					if (global::Motorola.Common.Communication.TetraUtility.CPAUtil.Vr(rpp, array))
					{
						if (upp == null)
						{
							upp = new byte[global::Motorola.Common.Communication.TetraUtility.CPAUtil.rppByteLen];
						}
						if (array != null && upp != null)
						{
							global::System.Array.Copy(array, upp, upp.Length);
							break;
						}
						break;
					}
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005420 File Offset: 0x00003620
		private bool Co(byte[] rpp)
		{
			if (rpp == null || global::Motorola.Common.Communication.TetraUtility.CPAUtil.IsEmptyPassword(rpp))
			{
				return true;
			}
			byte b = rpp[0];
			return b != 0 && (b & 2) == 0;
		}

		// Token: 0x04000011 RID: 17
		public static readonly int maxQuenSize = 5;

		// Token: 0x04000012 RID: 18
		public static readonly int MaxAuthenTimes = 10;

		// Token: 0x04000013 RID: 19
		private global::System.Collections.Generic.Queue<byte[]> passwordCache = new global::System.Collections.Generic.Queue<byte[]>(global::Motorola.Common.Communication.TetraUtility.Rpm.maxQuenSize);

		// Token: 0x04000014 RID: 20
		private static global::Motorola.Common.Communication.TetraUtility.Rpm _instance = new global::Motorola.Common.Communication.TetraUtility.Rpm();
	}
}
