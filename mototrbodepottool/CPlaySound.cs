using System;
using System.IO;
using System.Runtime.InteropServices;
using custom_exception;
using RegistryAccess;
using resource_handler;

namespace mototrbodepottool
{
	// Token: 0x02000013 RID: 19
	public class CPlaySound
	{
		// Token: 0x060000B3 RID: 179
		[global::System.Runtime.InteropServices.DllImport("winmm.dll", SetLastError = true)]
		private static extern bool PlaySound(string A_0, global::System.IntPtr A_1, global::mototrbodepottool.CPlaySound.SoundFlags A_2);

		// Token: 0x060000B4 RID: 180 RVA: 0x000175B8 File Offset: 0x000165B8
		public CPlaySound(bool A_0, global::RegistryAccess.IPersistentApplicationSettings A_1, global::resource_handler.CResourceHandler A_2)
		{
			this.d = A_0;
			this.e = A_1;
			this.f = A_2;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000175E0 File Offset: 0x000165E0
		public void b(global::mototrbodepottool.CPlaySound.SoundType A_0)
		{
			try
			{
				int num = 0;
				switch (num)
				{
				default:
				{
					string text;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						for (;;)
						{
							IL_2C:
							switch (num)
							{
							case 0:
								goto IL_E7;
							case 1:
								if (!global::mototrbodepottool.CPlaySound.PlaySound(text, global::System.IntPtr.Zero, global::mototrbodepottool.CPlaySound.SoundFlags.b | global::mototrbodepottool.CPlaySound.SoundFlags.g | global::mototrbodepottool.CPlaySound.SoundFlags.j))
								{
									num = 3;
									continue;
								}
								num = 0;
								continue;
							case 2:
								if (!global::System.IO.File.Exists(text))
								{
									num = 4;
									continue;
								}
								num = 1;
								continue;
							case 3:
								goto IL_D9;
							case 4:
								goto IL_69;
							}
							goto IL_47;
						}
						IL_69:
						global::custom_exception.CCustomException ex = global::mototrbodepottool.CustomExceptionHandler.a(1739U, base.GetType().ToString(), "PlayTheSound", global::System.Environment.StackTrace);
						throw ex;
						IL_D9:
						global::custom_exception.CCustomException ex2 = global::mototrbodepottool.CustomExceptionHandler.a(1740U, base.GetType().ToString(), "PlayTheSound", global::System.Environment.StackTrace);
						throw ex2;
						IL_E7:
						goto IL_112;
					}
					default:
						if (false)
						{
						}
						break;
					}
					IL_47:
					text = this.a(A_0);
					num = 2;
					goto IL_2C;
				}
				}
			}
			catch (global::custom_exception.CCustomException ex3)
			{
				this.a(ex3.ErrorID, ex3);
			}
			catch (global::System.Exception ex4)
			{
				global::custom_exception.CCustomException.GetErrorID(ex4);
				this.a(1740U, ex4);
			}
			IL_112:
			if (true)
			{
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00017730 File Offset: 0x00016730
		private void a(uint A_0, global::System.Exception A_1)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.e.SetSoundStatus(false);
				global::mototrbodepottool.CustomExceptionHandler customExceptionHandler = new global::mototrbodepottool.CustomExceptionHandler(this.f, string.Empty);
				customExceptionHandler.a(A_0, true, A_1);
			}
			catch (global::System.Exception)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000177A8 File Offset: 0x000167A8
		private string a(global::mototrbodepottool.CPlaySound.SoundType A_0)
		{
			switch (0)
			{
			default:
			{
				string result;
				for (;;)
				{
					result = string.Empty;
					string empty = string.Empty;
					this.e.GetInstallPath(ref empty);
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_AC;
						case 1:
							goto IL_85;
						case 2:
							goto IL_BA;
						case 3:
							switch (A_0)
							{
							case global::mototrbodepottool.CPlaySound.SoundType.a:
								result = empty + "\\ok.wav";
								num = 0;
								continue;
							case global::mototrbodepottool.CPlaySound.SoundType.b:
								result = empty + "\\bonk.wav";
								num = 1;
								continue;
							case global::mototrbodepottool.CPlaySound.SoundType.c:
								result = empty + "\\hellomoto1.wav";
								num = 5;
								continue;
							default:
								num = 4;
								continue;
							}
							break;
						case 4:
							num = 2;
							continue;
						case 5:
							goto IL_FE;
						}
						break;
					}
				}
				IL_85:
				IL_AC:
				return result;
				IL_BA:
				IL_BC:
				if (true)
				{
				}
				global::custom_exception.CCustomException ex = global::mototrbodepottool.CustomExceptionHandler.a(1741U, base.GetType().ToString(), "GetSoundFile", global::System.Environment.StackTrace);
				throw ex;
				IL_FE:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_BC;
				default:
					if (false)
					{
					}
					break;
				}
				return result;
			}
			}
		}

		// Token: 0x04000230 RID: 560
		private const string a = "hellomoto1.wav";

		// Token: 0x04000231 RID: 561
		private const string b = "ok.wav";

		// Token: 0x04000232 RID: 562
		private const string c = "bonk.wav";

		// Token: 0x04000233 RID: 563
		private bool d;

		// Token: 0x04000234 RID: 564
		private global::RegistryAccess.IPersistentApplicationSettings e;

		// Token: 0x04000235 RID: 565
		private global::resource_handler.CResourceHandler f;

		// Token: 0x02000014 RID: 20
		[global::System.Flags]
		public enum SoundFlags
		{
			// Token: 0x04000237 RID: 567
			a = 0,
			// Token: 0x04000238 RID: 568
			b = 1,
			// Token: 0x04000239 RID: 569
			c = 2,
			// Token: 0x0400023A RID: 570
			d = 4,
			// Token: 0x0400023B RID: 571
			e = 8,
			// Token: 0x0400023C RID: 572
			f = 16,
			// Token: 0x0400023D RID: 573
			g = 8192,
			// Token: 0x0400023E RID: 574
			h = 65536,
			// Token: 0x0400023F RID: 575
			i = 1114112,
			// Token: 0x04000240 RID: 576
			j = 131072,
			// Token: 0x04000241 RID: 577
			k = 262148
		}

		// Token: 0x02000015 RID: 21
		public enum SoundType
		{
			// Token: 0x04000243 RID: 579
			a,
			// Token: 0x04000244 RID: 580
			b,
			// Token: 0x04000245 RID: 581
			c
		}
	}
}
