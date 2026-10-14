using System;
using custom_exception;

namespace Controller
{
	// Token: 0x0200000A RID: 10
	internal class a
	{
		// Token: 0x0600010C RID: 268 RVA: 0x000149B4 File Offset: 0x000139B4
		internal a()
		{
			this.b = new global::Controller.a.a();
			this.a = 0U;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000149DC File Offset: 0x000139DC
		internal void a(ref object A_0, uint A_1, out uint A_2)
		{
			for (;;)
			{
				A_2 = 0U;
				global::Controller.a.a f = this.b;
				bool flag = false;
				int num = 6;
				for (;;)
				{
					switch (num)
					{
					case 0:
					{
						global::Controller.a.a a = new global::Controller.a.a();
						a.a = f.a + 1U;
						A_2 = a.a;
						a.b = A_1;
						a.c = A_0;
						a.f = f.f;
						f.f = a;
						this.a += 1U;
						flag = true;
						num = 8;
						continue;
					}
					case 1:
						if (flag)
						{
							num = 9;
							continue;
						}
						num = 4;
						continue;
					case 2:
						goto IL_AF;
					case 3:
						f.f = new global::Controller.a.a();
						f.f.a = f.a + 1U;
						A_2 = f.f.a;
						f.f.b = A_1;
						f.f.c = A_0;
						f.f.f = null;
						this.a += 1U;
						flag = true;
						num = 2;
						continue;
					case 4:
						if (f.f == null)
						{
							num = 3;
							continue;
						}
						goto IL_5A;
					case 5:
						if (f.f.a != f.a + 1U)
						{
							num = 0;
							continue;
						}
						f = f.f;
						num = 7;
						continue;
					case 6:
						goto IL_AF;
					case 7:
						goto IL_AF;
					case 8:
						goto IL_AF;
					case 9:
						return;
					}
					break;
					IL_5A:
					if (true)
					{
					}
					num = 5;
					continue;
					IL_AF:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
						if (false)
						{
						}
						num = 1;
						break;
					}
				}
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00014BB0 File Offset: 0x00013BB0
		internal void b(uint A_0)
		{
			switch (0)
			{
			default:
			{
				int num = 8;
				for (;;)
				{
					global::Controller.a.a f;
					global::Controller.a.a f2;
					bool flag;
					switch (num)
					{
					case 0:
						goto IL_CD;
					case 1:
						goto IL_58;
					case 2:
						if (f != null)
						{
							num = 10;
							continue;
						}
						goto IL_146;
					case 3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_191;
						default:
							goto IL_10C;
						}
						break;
					case 4:
						goto IL_CD;
					case 5:
						goto IL_CD;
					case 6:
						if (f.a == A_0)
						{
							goto IL_191;
						}
						f2 = f2.f;
						f = f.f;
						num = 5;
						continue;
					case 7:
						if (flag)
						{
							num = 3;
							continue;
						}
						num = 2;
						continue;
					case 9:
						if (true)
						{
						}
						f2.f = f.f;
						this.a -= 1U;
						flag = true;
						num = 0;
						continue;
					case 10:
						num = 6;
						continue;
					}
					if (A_0 == 0U)
					{
						num = 1;
						continue;
					}
					f2 = this.b;
					f = this.b.f;
					flag = false;
					num = 4;
					continue;
					IL_CD:
					num = 7;
					continue;
					IL_191:
					num = 9;
				}
				IL_58:
				uint num2 = 1364U;
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "DeleteElement", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_10C:
				if (false)
				{
				}
				return;
				IL_146:
				uint num3 = 1364U;
				global::custom_exception.CCustomException ex2 = global::Controller.CCustomExceptionHandler.CreateException(num3 & 65535U, base.GetType().ToString(), "DeleteElement", global::System.Environment.StackTrace.ToString());
				throw ex2;
			}
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00014D7C File Offset: 0x00013D7C
		internal void a(uint A_0, out object A_1, out uint A_2)
		{
			switch (0)
			{
			default:
			{
				global::Controller.a.a f;
				int num;
				bool flag;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A2:
					if (f.f != null)
					{
						num = 4;
					}
					else
					{
						flag = true;
						num = 3;
					}
					break;
				default:
					if (false)
					{
					}
					goto IL_63;
				}
				for (;;)
				{
					IL_2C:
					switch (num)
					{
					case 0:
						goto IL_C8;
					case 1:
						if (A_0 == 0U)
						{
							num = 9;
							continue;
						}
						flag = false;
						num = 8;
						continue;
					case 2:
						return;
					case 3:
						goto IL_C8;
					case 4:
						f = f.f;
						num = 0;
						continue;
					case 5:
						goto IL_A2;
					case 6:
						if (f.a == A_0)
						{
							num = 7;
							continue;
						}
						num = 5;
						continue;
					case 7:
						A_1 = f.c;
						A_2 = f.b;
						flag = true;
						if (true)
						{
						}
						num = 10;
						continue;
					case 8:
						goto IL_C8;
					case 9:
						goto IL_85;
					case 10:
						goto IL_C8;
					case 11:
						if (flag)
						{
							num = 2;
							continue;
						}
						num = 6;
						continue;
					}
					goto IL_63;
					IL_C8:
					num = 11;
				}
				IL_85:
				uint num2 = 1151U;
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetElement", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_63:
				A_1 = null;
				A_2 = 0U;
				f = this.b;
				num = 1;
				goto IL_2C;
			}
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00014F0C File Offset: 0x00013F0C
		internal void a(uint A_0, object A_1)
		{
			for (;;)
			{
				global::Controller.a.a f = this.b;
				bool flag = false;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_B3;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9D;
						default:
							if (false)
							{
							}
							goto IL_B3;
						}
						break;
					case 2:
						goto IL_9D;
					case 3:
						goto IL_B3;
					case 4:
						return;
					case 5:
						f.d = A_1;
						flag = true;
						num = 7;
						continue;
					case 6:
						if (f.f != null)
						{
							num = 9;
							continue;
						}
						flag = true;
						num = 3;
						continue;
					case 7:
						if (true)
						{
						}
						goto IL_B3;
					case 8:
						if (flag)
						{
							num = 4;
							continue;
						}
						num = 2;
						continue;
					case 9:
						f = f.f;
						num = 0;
						continue;
					}
					break;
					IL_9D:
					if (f.a == A_0)
					{
						num = 5;
						continue;
					}
					num = 6;
					continue;
					IL_B3:
					num = 8;
				}
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0001501C File Offset: 0x0001401C
		internal void a(uint A_0)
		{
			switch (0)
			{
			default:
			{
				int num = 0;
				for (;;)
				{
					global::Controller.a.a f;
					bool flag;
					switch (num)
					{
					case 1:
						f = f.f;
						num = 11;
						continue;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_E7;
						}
						break;
					case 3:
						goto IL_B3;
					case 4:
						if (f.f != null)
						{
							num = 1;
							continue;
						}
						flag = true;
						num = 3;
						continue;
					case 5:
						goto IL_B3;
					case 6:
						if (f.a == A_0)
						{
							num = 10;
							continue;
						}
						num = 4;
						continue;
					case 7:
						goto IL_B3;
					case 8:
						goto IL_66;
					case 9:
						if (flag)
						{
							num = 2;
							continue;
						}
						num = 6;
						continue;
					case 10:
						f.d = null;
						f.e = 0U;
						flag = true;
						num = 5;
						continue;
					case 11:
						goto IL_B3;
					}
					if (A_0 == 0U)
					{
						num = 8;
						continue;
					}
					f = this.b;
					flag = false;
					num = 7;
					continue;
					IL_B3:
					num = 9;
				}
				IL_66:
				if (true)
				{
				}
				uint num2 = 1U;
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "DeleteCommPath", global::System.Environment.StackTrace.ToString());
				throw ex;
				IL_E7:
				if (false)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000151A8 File Offset: 0x000141A8
		internal void a(uint A_0, out object A_1)
		{
			switch (0)
			{
			default:
			{
				int num = 8;
				for (;;)
				{
					bool flag;
					global::Controller.a.a f;
					switch (num)
					{
					case 0:
						if (flag)
						{
							num = 11;
							continue;
						}
						num = 7;
						continue;
					case 1:
						goto IL_D0;
					case 2:
						if (true)
						{
						}
						if (f.f != null)
						{
							num = 3;
							continue;
						}
						flag = true;
						num = 5;
						continue;
					case 3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5C;
						default:
							if (false)
							{
							}
							f = f.f;
							num = 4;
							continue;
						}
						break;
					case 4:
						goto IL_D0;
					case 5:
						goto IL_D0;
					case 6:
						A_1 = f.d;
						flag = true;
						num = 10;
						continue;
					case 7:
						if (f.a == A_0)
						{
							num = 6;
							continue;
						}
						num = 2;
						continue;
					case 9:
						goto IL_5C;
					case 10:
						goto IL_D0;
					case 11:
						return;
					}
					if (A_0 == 0U)
					{
						num = 9;
						continue;
					}
					A_1 = null;
					f = this.b;
					flag = false;
					num = 1;
					continue;
					IL_D0:
					num = 0;
				}
				IL_5C:
				uint num2 = 1U;
				global::custom_exception.CCustomException ex = global::Controller.CCustomExceptionHandler.CreateException(num2 & 65535U, base.GetType().ToString(), "GetCommPath", global::System.Environment.StackTrace.ToString());
				throw ex;
			}
			}
		}

		// Token: 0x040000BE RID: 190
		private uint a;

		// Token: 0x040000BF RID: 191
		private global::Controller.a.a b;

		// Token: 0x0200000B RID: 11
		private class a
		{
			// Token: 0x06000113 RID: 275 RVA: 0x00015328 File Offset: 0x00014328
			public uint b()
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

			// Token: 0x06000114 RID: 276 RVA: 0x0001536C File Offset: 0x0001436C
			public uint a()
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
				return this.b;
			}

			// Token: 0x040000C0 RID: 192
			internal uint a;

			// Token: 0x040000C1 RID: 193
			internal uint b;

			// Token: 0x040000C2 RID: 194
			internal object c;

			// Token: 0x040000C3 RID: 195
			internal object d;

			// Token: 0x040000C4 RID: 196
			internal uint e;

			// Token: 0x040000C5 RID: 197
			internal global::Controller.a.a f;
		}
	}
}
