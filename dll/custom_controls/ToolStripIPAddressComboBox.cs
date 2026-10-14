using System;
using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x0200006E RID: 110
	public class ToolStripIPAddressComboBox : global::System.Windows.Forms.ToolStripComboBox
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0004A858 File Offset: 0x00048A58
		public bool IsValidIPAddress
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
				return this.i;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0004A89C File Offset: 0x00048A9C
		public ToolStripIPAddressComboBox(string defaultIPAddr, string tagValue)
		{
			base.MaxLength = 15;
			this.h = defaultIPAddr;
			base.Tag = tagValue;
			this.Text = this.h;
			this.a(this.Text.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			this.g = new global::System.Collections.ArrayList(5);
			this.c();
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0004A8FC File Offset: 0x00048AFC
		public void AddUserInput()
		{
			for (;;)
			{
				string a_ = this.Text.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				if (true)
				{
				}
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.e(a_);
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							if (false)
							{
							}
							num = 1;
							continue;
						}
						break;
					case 1:
						return;
					case 2:
						if (this.a(a_))
						{
							num = 0;
							continue;
						}
						return;
					}
					break;
				}
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0004A988 File Offset: 0x00048B88
		public void DeleteDataSource()
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return;
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						if (false)
						{
						}
						this.g.Clear();
						this.g = null;
						if (true)
						{
						}
						num = 0;
						continue;
					}
					break;
				}
				if (this.g == null)
				{
					break;
				}
				num = 2;
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0004AA10 File Offset: 0x00048C10
		private void c()
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
			this.e(this.h);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0004AA58 File Offset: 0x00048C58
		private void e(string A_0)
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
			this.d(A_0);
			this.a();
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0004AAA0 File Offset: 0x00048CA0
		private void d(string A_0)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
					goto IL_5C;
				}
				if (true)
				{
				}
				if (string.IsNullOrEmpty(A_0))
				{
					break;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					num = 2;
					continue;
				}
				IL_5C:
				this.c(A_0);
				this.b();
				this.g.Insert(0, A_0);
				num = 1;
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0004AB30 File Offset: 0x00048D30
		private void c(string A_0)
		{
			for (;;)
			{
				int num = this.g.IndexOf(A_0);
				if (true)
				{
				}
				int num2 = 2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						this.g.RemoveAt(num);
						num2 = 0;
						continue;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							if (num == -1)
							{
								return;
							}
							break;
						}
						num2 = 1;
						continue;
					}
					break;
				}
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0004ABB8 File Offset: 0x00048DB8
		private void b()
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_4D;
				case 1:
				{
					int num2 = 4;
					num = 0;
					continue;
				}
				case 2:
					goto IL_87;
				case 4:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						if (false)
						{
						}
						int num2;
						if (num2 >= this.g.Count)
						{
							num = 2;
							continue;
						}
						this.g.RemoveAt(num2);
						num2--;
						num2++;
						num = 5;
						continue;
					}
					}
					break;
				case 5:
					goto IL_4D;
				}
				if (this.g.Count >= 5)
				{
					num = 1;
					continue;
				}
				return;
				IL_4D:
				num = 4;
			}
			IL_87:
			if (true)
			{
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0004AC88 File Offset: 0x00048E88
		private void a()
		{
			for (;;)
			{
				string text = string.Empty;
				base.Items.Clear();
				int num = 0;
				int num2 = 4;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (string.IsNullOrEmpty(text))
						{
							goto IL_44;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_67;
						default:
							if (false)
							{
							}
							num2 = 3;
							continue;
						}
						break;
					case 2:
						goto IL_44;
					case 3:
						base.Items.Add(text);
						goto IL_67;
					case 4:
						goto IL_C9;
					case 5:
						if (num >= this.g.Count)
						{
							num2 = 0;
							continue;
						}
						text = this.g[num].ToString();
						num2 = 1;
						continue;
					case 6:
						goto IL_C9;
					}
					break;
					IL_44:
					if (true)
					{
					}
					num++;
					num2 = 6;
					continue;
					IL_67:
					num2 = 2;
					continue;
					IL_C9:
					num2 = 5;
				}
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0004AD84 File Offset: 0x00048F84
		private bool b(char A_0)
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
			return global::System.Text.RegularExpressions.Regex.IsMatch(A_0.ToString(global::System.Globalization.CultureInfo.InvariantCulture), "[0-9.]");
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0004ADD8 File Offset: 0x00048FD8
		private bool a(char A_0)
		{
			if (true)
			{
			}
			if (!this.b(A_0))
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					break;
				}
				return char.IsControl(A_0);
			}
			return true;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0004AE28 File Offset: 0x00049028
		private string b(string A_0)
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
			return global::System.Text.RegularExpressions.Regex.Replace(A_0, "[^0-9.]", "");
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0004AE74 File Offset: 0x00049074
		private bool a(string A_0)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_6F:
				this.i = true;
				num = 2;
				break;
			default:
				if (false)
				{
				}
				num = 0;
				break;
			}
			for (;;)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 1:
					goto IL_6D;
				case 2:
					goto IL_7E;
				case 3:
					goto IL_AA;
				case 4:
					if (global::System.Text.RegularExpressions.Regex.IsMatch(A_0, "^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$"))
					{
						num = 3;
						continue;
					}
					goto IL_5E;
				case 5:
					num = 4;
					continue;
				}
				if (!string.IsNullOrEmpty(A_0))
				{
					num = 5;
					continue;
				}
				IL_5E:
				this.i = false;
				num = 1;
			}
			IL_6D:
			IL_7E:
			goto IL_AC;
			IL_AA:
			goto IL_6F;
			IL_AC:
			return this.i;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0004AF34 File Offset: 0x00049134
		protected override void OnKeyPress(global::System.Windows.Forms.KeyPressEventArgs e)
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
			base.OnKeyPress(e);
			e.Handled = !this.a(e.KeyChar);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0004AF8C File Offset: 0x0004918C
		protected override void OnTextChanged(global::System.EventArgs e)
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
			base.OnTextChanged(e);
			this.Text = this.b(this.Text.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0004AFEC File Offset: 0x000491EC
		protected override void OnKeyUp(global::System.Windows.Forms.KeyEventArgs e)
		{
			if (true)
			{
			}
			for (;;)
			{
				IL_1C:
				base.OnKeyUp(e);
				for (;;)
				{
					IL_23:
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (e.KeyCode == global::System.Windows.Forms.Keys.Return)
							{
								num = 1;
								continue;
							}
							return;
						case 1:
							this.AddUserInput();
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_23;
							default:
								if (false)
								{
								}
								num = 2;
								continue;
							}
							break;
						case 2:
							return;
						}
						goto IL_1C;
					}
				}
			}
		}

		// Token: 0x04000326 RID: 806
		private const int a = 5;

		// Token: 0x04000327 RID: 807
		private const int b = 15;

		// Token: 0x04000328 RID: 808
		private const char c = '.';

		// Token: 0x04000329 RID: 809
		private const string d = "[0-9.]";

		// Token: 0x0400032A RID: 810
		private const string e = "[^0-9.]";

		// Token: 0x0400032B RID: 811
		private const string f = "^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";

		// Token: 0x0400032C RID: 812
		private global::System.Collections.ArrayList g;

		// Token: 0x0400032D RID: 813
		private string h;

		// Token: 0x0400032E RID: 814
		private bool i;
	}
}
