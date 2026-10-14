using System;

namespace RegistryAccess
{
	// Token: 0x02000005 RID: 5
	public struct NoShowWarning
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000021BC File Offset: 0x000011BC
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002200 File Offset: 0x00001200
		public string ID
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return this.a;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002244 File Offset: 0x00001244
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002288 File Offset: 0x00001288
		public int Value
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return this.b;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000022CC File Offset: 0x000012CC
		public override bool Equals(object obj)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					num = 7;
					continue;
				case 4:
					return true;
				case 5:
				{
					global::RegistryAccess.NoShowWarning noShowWarning;
					if (noShowWarning.b == this.b)
					{
						num = 3;
						continue;
					}
					goto IL_C9;
				}
				case 6:
				{
					if (!(obj is global::RegistryAccess.NoShowWarning))
					{
						num = 2;
						continue;
					}
					if (true)
					{
					}
					global::RegistryAccess.NoShowWarning noShowWarning = (global::RegistryAccess.NoShowWarning)obj;
					num = 5;
					continue;
				}
				case 7:
				{
					global::RegistryAccess.NoShowWarning noShowWarning;
					if (noShowWarning.a == this.a)
					{
						num = 4;
						continue;
					}
					goto IL_C9;
				}
				}
				if (obj == null)
				{
					num = 1;
				}
				else
				{
					num = 6;
				}
			}
			return false;
			IL_C9:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			default:
				if (false)
				{
				}
				return false;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000023C0 File Offset: 0x000013C0
		public override int GetHashCode()
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
			return base.GetHashCode();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000240C File Offset: 0x0000140C
		public static bool operator ==(global::RegistryAccess.NoShowWarning obj1, global::RegistryAccess.NoShowWarning obj2)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (true)
				{
				}
				if (false)
				{
				}
				if (!object.Equals(obj1, null))
				{
					return obj1.Equals(obj2);
				}
				break;
			}
			return object.Equals(obj2, null);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002478 File Offset: 0x00001478
		public static bool operator !=(global::RegistryAccess.NoShowWarning obj1, global::RegistryAccess.NoShowWarning obj2)
		{
			switch (1 == 1)
			{
			}
			if (true)
			{
			}
			if (false)
			{
			}
			return !(obj1 == obj2);
		}

		// Token: 0x04000006 RID: 6
		private string a;

		// Token: 0x04000007 RID: 7
		private int b;
	}
}
