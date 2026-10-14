using System;
using System.Windows.Forms;
using custom_controls;
using custom_exception;
using ErrorLogging;
using resource_handler;

namespace mototrbodepottool
{
	// Token: 0x02000008 RID: 8
	public class CustomExceptionHandler
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00004668 File Offset: 0x00003668
		public CustomExceptionHandler(global::resource_handler.CResourceHandler A_0, string A_1)
		{
			this.g = A_0;
			this.h = A_1;
			this.j = null;
			this.i = new global::ErrorLogging.CLogApplicationError("MOTOTRBO Depot Tool");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000046A0 File Offset: 0x000036A0
		public void a(global::System.Windows.Forms.Form A_0)
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
			this.j = A_0;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000046E4 File Offset: 0x000036E4
		public void a(uint A_0, bool A_1, global::System.Exception A_2)
		{
			try
			{
				switch (0)
				{
				default:
				{
					for (;;)
					{
						bool isRightToLeft = global::System.Convert.ToBoolean(global::System.Convert.ToInt16(this.g.GetString("MIRRORED")));
						uint num = 0U;
						string empty = string.Empty;
						string empty2 = string.Empty;
						string empty3 = string.Empty;
						int num2 = 5;
						for (;;)
						{
							global::custom_controls.CMsgDialog cmsgDialog;
							switch (num2)
							{
							case 0:
								goto IL_E4;
							case 1:
								goto IL_205;
							case 2:
								try
								{
									this.i.LogApplicationError(num, empty, empty2, empty3);
									goto IL_1A3;
								}
								catch (global::System.Exception)
								{
									goto IL_1A3;
								}
								goto IL_E4;
							case 3:
								if (true)
								{
								}
								if (cmsgDialog == null)
								{
									num2 = 10;
									continue;
								}
								num2 = 7;
								continue;
							case 4:
								try
								{
									global::custom_exception.CCustomException ex;
									this.i.LogApplicationError(num, ex.exSource, ex.exMessage, ex.exStackTrace);
								}
								catch (global::System.Exception)
								{
								}
								goto IL_1A3;
							case 5:
							{
								if (!A_2.GetType().FullName.Equals("custom_exception.CCustomException"))
								{
									num2 = 9;
									continue;
								}
								global::custom_exception.CCustomException ex = (global::custom_exception.CCustomException)A_2;
								num = ex.ErrorID;
								num2 = 4;
								continue;
							}
							case 6:
								goto IL_205;
							case 7:
								if (A_1)
								{
									num2 = 0;
									continue;
								}
								cmsgDialog.Show(this.j, false, global::System.Windows.Forms.DialogResult.OK, global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
								num2 = 6;
								continue;
							case 8:
								goto IL_211;
							case 9:
								IL_A2:
								global::custom_exception.CCustomException.ParseException(A_2, ref num, ref empty, ref empty2, ref empty3);
								num2 = 2;
								continue;
							case 10:
								goto IL_1DF;
							}
							break;
							IL_E4:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_A2;
							default:
								if (false)
								{
								}
								cmsgDialog.Show(null, false, global::System.Windows.Forms.DialogResult.OK, global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
								num2 = 1;
								continue;
							}
							IL_1A3:
							cmsgDialog = new global::custom_controls.CMsgDialog(isRightToLeft, this.g, (int)num, "DT_APP_TITLE", null);
							num2 = 3;
							continue;
							IL_205:
							num2 = 8;
						}
					}
					IL_1DF:
					global::custom_exception.CCustomException ex2 = global::mototrbodepottool.CustomExceptionHandler.a(1646U, base.GetType().ToString(), "ProcessErroMsg", global::System.Environment.StackTrace);
					throw ex2;
					IL_211:
					break;
				}
				}
			}
			catch (global::System.Exception ex3)
			{
				global::custom_exception.CCustomException.Rethrow(ex3);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004968 File Offset: 0x00003968
		public static uint a(string A_0)
		{
			uint result;
			for (;;)
			{
				result = 0U;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
				{
					if (false)
					{
					}
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
						{
							int length = A_0.IndexOf("\t", 0);
							result = uint.Parse(A_0.Substring(0, length));
							if (true)
							{
							}
							num = 1;
							continue;
						}
						case 1:
							return result;
						case 2:
							if (A_0.IndexOf("\t") != -1)
							{
								num = 0;
								continue;
							}
							return result;
						}
						break;
					}
					break;
				}
				}
			}
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004A04 File Offset: 0x00003A04
		private void a(string A_0, ref string A_1, ref string A_2)
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
			int num = A_0.IndexOf("at ", 0);
			int num2 = A_0.IndexOf("(", num);
			A_1 = A_0.Substring(num + 3, num2 - num - 3);
			num2 = A_1.LastIndexOf(".");
			A_2 = A_1.Substring(num2 + 1);
			A_1 = A_1.Substring(0, num2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004A90 File Offset: 0x00003A90
		public static global::custom_exception.CCustomException a(uint A_0, string A_1, string A_2, string A_3)
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
			return new global::custom_exception.CCustomException(A_0, "SNB GUI", A_1 + ", " + A_2, A_3);
		}

		// Token: 0x0400002A RID: 42
		private const string a = "\t";

		// Token: 0x0400002B RID: 43
		private const string b = "at ";

		// Token: 0x0400002C RID: 44
		private const string c = "(";

		// Token: 0x0400002D RID: 45
		private const string d = ".";

		// Token: 0x0400002E RID: 46
		private const int e = 0;

		// Token: 0x0400002F RID: 47
		private const int f = 3;

		// Token: 0x04000030 RID: 48
		private global::resource_handler.CResourceHandler g;

		// Token: 0x04000031 RID: 49
		public string h;

		// Token: 0x04000032 RID: 50
		private global::ErrorLogging.ILogApplicationError i;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Form j;
	}
}
