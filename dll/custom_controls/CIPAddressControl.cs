using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace custom_controls
{
	// Token: 0x0200005D RID: 93
	[global::System.ComponentModel.Designer(typeof(global::custom_controls.IPAddressControlDesigner))]
	public class CIPAddressControl : global::System.Windows.Forms.UserControl
	{
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060003D2 RID: 978 RVA: 0x0003FABC File Offset: 0x0003DCBC
		// (remove) Token: 0x060003D3 RID: 979 RVA: 0x0003FB54 File Offset: 0x0003DD54
		public event global::custom_controls.FieldChangedHandler FieldChangedHandlerEventHandler
		{
			add
			{
				for (;;)
				{
					global::custom_controls.FieldChangedHandler fieldChangedHandler = this.p;
					if (true)
					{
					}
					int num = 2;
					for (;;)
					{
						global::custom_controls.FieldChangedHandler fieldChangedHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							if (fieldChangedHandler == fieldChangedHandler2)
							{
								num = 0;
								continue;
							}
							goto IL_53;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								if (false)
								{
								}
								goto IL_53;
							}
							break;
						}
						break;
						IL_53:
						fieldChangedHandler2 = fieldChangedHandler;
						global::custom_controls.FieldChangedHandler value2 = (global::custom_controls.FieldChangedHandler)global::System.Delegate.Combine(fieldChangedHandler2, value);
						fieldChangedHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.FieldChangedHandler>(ref this.p, value2, fieldChangedHandler2);
						num = 1;
					}
				}
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.FieldChangedHandler fieldChangedHandler = this.p;
					if (true)
					{
					}
					int num = 2;
					for (;;)
					{
						global::custom_controls.FieldChangedHandler fieldChangedHandler2;
						switch (num)
						{
						case 0:
							if (fieldChangedHandler == fieldChangedHandler2)
							{
								num = 1;
								continue;
							}
							goto IL_53;
						case 1:
							return;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								if (false)
								{
								}
								goto IL_53;
							}
							break;
						}
						break;
						IL_53:
						fieldChangedHandler2 = fieldChangedHandler;
						global::custom_controls.FieldChangedHandler value2 = (global::custom_controls.FieldChangedHandler)global::System.Delegate.Remove(fieldChangedHandler2, value);
						fieldChangedHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.FieldChangedHandler>(ref this.p, value2, fieldChangedHandler2);
						num = 0;
					}
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x0003FBEC File Offset: 0x0003DDEC
		[global::System.ComponentModel.Browsable(true)]
		public bool AllowBlank
		{
			set
			{
				int num;
				int num2;
				global::custom_controls.l[] array;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					for (;;)
					{
						IL_1E:
						switch (num)
						{
						case 0:
						{
							if (num2 >= array.Length)
							{
								num = 3;
								continue;
							}
							if (true)
							{
							}
							global::custom_controls.l l = array[num2];
							l.b(value);
							num2++;
							num = 1;
							continue;
						}
						case 1:
							goto IL_51;
						case 2:
							goto IL_51;
						case 3:
							return;
						}
						goto IL_34;
						IL_51:
						num = 0;
					}
					return;
				default:
					if (false)
					{
					}
					break;
				}
				IL_34:
				array = this.f;
				num2 = 0;
				num = 2;
				goto IL_1E;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0003FC84 File Offset: 0x0003DE84
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x0003FCC8 File Offset: 0x0003DEC8
		[global::System.ComponentModel.Browsable(true)]
		public new bool AutoSize
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
				return this.i;
			}
			set
			{
				for (;;)
				{
					IL_00:
					for (;;)
					{
						IL_3A:
						this.i = value;
						int num = 2;
						for (;;)
						{
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								if (false)
								{
								}
								switch (num)
								{
								case 0:
									return;
								case 1:
									if (true)
									{
									}
									this.c();
									num = 0;
									continue;
								case 2:
									if (this.i)
									{
										num = 1;
										continue;
									}
									return;
								}
								goto IL_3A;
							}
						}
					}
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0003FD48 File Offset: 0x0003DF48
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x0003FD8C File Offset: 0x0003DF8C
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Description("used to indicate the  text is modified or not.")]
		public bool TextModified
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
				return this.h;
			}
			set
			{
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
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.h = value;
							base.Invalidate();
							num = 1;
							continue;
						case 1:
							return;
						case 2:
							if (true)
							{
							}
							break;
						}
						if (this.h == value)
						{
							break;
						}
						num = 0;
					}
					break;
				}
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0003FE10 File Offset: 0x0003E010
		public bool Blank
		{
			get
			{
				switch (0)
				{
				default:
					for (;;)
					{
						global::custom_controls.l[] array = this.f;
						int num = 0;
						int num2 = 0;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_47;
							case 1:
								return true;
							case 2:
							{
								bool result = false;
								num2 = 4;
								continue;
							}
							case 3:
								goto IL_47;
							case 4:
							{
								bool result;
								return result;
							}
							case 5:
								goto IL_50;
							case 6:
							{
								if (true)
								{
								}
								global::custom_controls.l l;
								if (l.s())
								{
									num++;
									num2 = 3;
									continue;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_50;
								default:
									if (false)
									{
									}
									num2 = 2;
									continue;
								}
								break;
							}
							}
							break;
							IL_47:
							num2 = 5;
							continue;
							IL_50:
							if (num >= array.Length)
							{
								num2 = 1;
							}
							else
							{
								global::custom_controls.l l = array[num];
								num2 = 6;
							}
						}
					}
					return true;
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0003FEF4 File Offset: 0x0003E0F4
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0003FF38 File Offset: 0x0003E138
		[global::System.ComponentModel.Browsable(true)]
		public new global::System.Windows.Forms.BorderStyle BorderStyle
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
				return this.j;
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
				this.j = value;
				this.b();
				base.Invalidate();
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0003FF88 File Offset: 0x0003E188
		public override bool Focused
		{
			get
			{
				switch (0)
				{
				default:
					if (true)
					{
					}
					for (;;)
					{
						global::custom_controls.l[] array = this.f;
						int num = 0;
						int num2 = 6;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								return false;
							case 1:
							{
								if (num >= array.Length)
								{
									num2 = 0;
									continue;
								}
								global::custom_controls.l l = array[num];
								num2 = 2;
								continue;
							}
							case 2:
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
									global::custom_controls.l l;
									if (l.Focused)
									{
										num2 = 3;
										continue;
									}
									num++;
									break;
								}
								}
								num2 = 4;
								continue;
							case 3:
							{
								bool result = true;
								num2 = 5;
								continue;
							}
							case 4:
								goto IL_59;
							case 5:
							{
								bool result;
								return result;
							}
							case 6:
								goto IL_59;
							}
							break;
							IL_59:
							num2 = 1;
						}
					}
					return false;
				}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0004006C File Offset: 0x0003E26C
		// (set) Token: 0x060003DE RID: 990 RVA: 0x000400B0 File Offset: 0x0003E2B0
		[global::System.ComponentModel.Browsable(true)]
		public bool ReadOnly
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
				return this.k;
			}
			set
			{
				switch (0)
				{
				default:
					for (;;)
					{
						IL_37:
						this.k = value;
						global::custom_controls.l[] array = this.f;
						int num = 0;
						for (;;)
						{
							IL_47:
							int num2 = 1;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_E8;
								case 1:
									goto IL_EA;
								case 2:
									switch ((1 == 1) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_47;
									default:
									{
										if (false)
										{
										}
										global::custom_controls.h[] array2 = this.g;
										int num3 = 0;
										num2 = 3;
										continue;
									}
									}
									break;
								case 3:
									goto IL_C5;
								case 4:
									goto IL_EA;
								case 5:
								{
									if (num >= array.Length)
									{
										num2 = 2;
										continue;
									}
									global::custom_controls.l l = array[num];
									l.ReadOnly = this.k;
									num++;
									num2 = 4;
									continue;
								}
								case 6:
								{
									global::custom_controls.h[] array2;
									int num3;
									if (num3 >= array2.Length)
									{
										num2 = 0;
										continue;
									}
									if (true)
									{
									}
									global::custom_controls.h h = array2[num3];
									h.b(this.k);
									num3++;
									num2 = 7;
									continue;
								}
								case 7:
									goto IL_C5;
								}
								goto IL_37;
								IL_C5:
								num2 = 6;
								continue;
								IL_EA:
								num2 = 5;
							}
						}
					}
					IL_E8:
					base.Invalidate();
					return;
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003DF RID: 991 RVA: 0x000401EC File Offset: 0x0003E3EC
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x0004038C File Offset: 0x0003E58C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(true)]
		public override string Text
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				try
				{
					for (;;)
					{
						int num = 0;
						int num2 = 11;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_F6;
								default:
									if (false)
									{
									}
									goto IL_EB;
								}
								break;
							case 1:
								if (true)
								{
								}
								if (this.f[num].TextLength > 0)
								{
									num2 = 3;
									continue;
								}
								stringBuilder.Append(this.f[num].w());
								num2 = 8;
								continue;
							case 2:
								goto IL_10E;
							case 3:
								stringBuilder.Append(this.f[num].Text);
								num2 = 2;
								continue;
							case 4:
								goto IL_160;
							case 5:
								stringBuilder.Append(this.g[num].Text);
								num2 = 7;
								continue;
							case 6:
								goto IL_F6;
							case 7:
								goto IL_70;
							case 8:
								goto IL_10E;
							case 9:
								if (num < this.g.Length)
								{
									num2 = 5;
									continue;
								}
								goto IL_70;
							case 10:
								num2 = 4;
								continue;
							case 11:
								goto IL_EB;
							}
							break;
							IL_70:
							num++;
							num2 = 0;
							continue;
							IL_F6:
							if (num >= this.f.Length)
							{
								num2 = 10;
								continue;
							}
							num2 = 1;
							continue;
							IL_EB:
							num2 = 6;
							continue;
							IL_10E:
							num2 = 9;
						}
					}
					IL_160:;
				}
				catch (global::System.Exception)
				{
					stringBuilder = null;
				}
				return stringBuilder.ToString();
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.a(value);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x000403D0 File Offset: 0x0003E5D0
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00040414 File Offset: 0x0003E614
		[global::System.ComponentModel.Description("used to indicate the value load from cp.")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ValuefromLoad
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
				return this.n;
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
				this.n = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00040458 File Offset: 0x0003E658
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x0004049C File Offset: 0x0003E69C
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Localizable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("Change to the right-to-left layout.")]
		[global::System.ComponentModel.Browsable(true)]
		public bool Mirrored
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
				return this.l;
			}
			set
			{
				int num = 2;
				for (;;)
				{
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						this.l = value;
						num = 1;
						continue;
					case 1:
						goto IL_52;
					case 2:
						IL_08:
						break;
					}
					if (this.l != value)
					{
						num = 0;
						continue;
					}
					IL_52:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_08;
					default:
						goto IL_68;
					}
				}
				IL_68:
				if (false)
				{
				}
				base.OnRightToLeftChanged(global::System.EventArgs.Empty);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00040524 File Offset: 0x0003E724
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x00040568 File Offset: 0x0003E768
		public global::custom_controls.AddressType AddressControlType
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
				return this.q;
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
				this.q = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x000405AC File Offset: 0x0003E7AC
		protected override global::System.Windows.Forms.CreateParams CreateParams
		{
			get
			{
				global::System.Windows.Forms.CreateParams createParams;
				for (;;)
				{
					IL_24:
					int num;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_8A:
						num = 0;
						break;
					default:
						if (false)
						{
						}
						createParams = base.CreateParams;
						num = 3;
						break;
					}
					for (;;)
					{
						if (true)
						{
						}
						switch (num)
						{
						case 0:
							if (!base.DesignMode)
							{
								num = 4;
								continue;
							}
							return createParams;
						case 1:
							goto IL_69;
						case 2:
							return createParams;
						case 3:
							if (this.Mirrored)
							{
								num = 1;
								continue;
							}
							return createParams;
						case 4:
							createParams.ExStyle |= 4194304;
							num = 2;
							continue;
						}
						goto IL_24;
					}
					IL_69:
					goto IL_8A;
				}
				return createParams;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00040664 File Offset: 0x0003E864
		public void Clear()
		{
			for (;;)
			{
				IL_18:
				global::custom_controls.l[] array;
				int num;
				int num2;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_8A:
					goto IL_47;
				default:
					if (false)
					{
					}
					array = this.f;
					num = 0;
					num2 = 1;
					break;
				}
				for (;;)
				{
					IL_02:
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_45;
					case 2:
						goto IL_8A;
					case 3:
					{
						if (num >= array.Length)
						{
							num2 = 0;
							continue;
						}
						if (true)
						{
						}
						global::custom_controls.l l = array[num];
						l.Clear();
						num++;
						num2 = 2;
						continue;
					}
					}
					goto IL_18;
				}
				IL_45:
				IL_47:
				num2 = 3;
				goto IL_02;
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00040700 File Offset: 0x0003E900
		public byte[] GetAddressBytes()
		{
			byte[] array;
			for (;;)
			{
				IL_28:
				int num;
				int num2;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_DA:
					array[num] = global::System.Convert.ToByte(this.f[num].Text, global::System.Globalization.CultureInfo.InvariantCulture);
					num2 = 7;
					break;
				default:
					if (false)
					{
					}
					array = new byte[this.f.Length];
					num = 0;
					num2 = 6;
					break;
				}
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_D8;
					case 1:
						if (this.f[num].TextLength > 0)
						{
							num2 = 3;
							continue;
						}
						array[num] = (byte)this.f[num].w();
						num2 = 4;
						continue;
					case 2:
						if (num >= array.Length)
						{
							num2 = 0;
							continue;
						}
						num2 = 1;
						continue;
					case 3:
						goto IL_BA;
					case 4:
						goto IL_5E;
					case 5:
						goto IL_BC;
					case 6:
						goto IL_BC;
					case 7:
						goto IL_5E;
					}
					goto IL_28;
					IL_5E:
					num++;
					num2 = 5;
					continue;
					IL_BC:
					num2 = 2;
				}
				IL_BA:
				goto IL_DA;
			}
			IL_D8:
			if (true)
			{
			}
			return array;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0004081C File Offset: 0x0003EA1C
		public void SetAddressBytes(byte[] bytes)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_BD:
				if (true)
				{
				}
				num = 0;
				break;
			default:
				if (false)
				{
				}
				num = 5;
				break;
			}
			for (;;)
			{
				int num2;
				int num3;
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_AE;
				case 2:
					if (num2 >= num3)
					{
						goto IL_BD;
					}
					this.f[num2].Text = bytes[num2].ToString(global::System.Globalization.CultureInfo.InvariantCulture);
					num2++;
					num = 4;
					continue;
				case 3:
					return;
				case 4:
					goto IL_AE;
				}
				if (bytes == null)
				{
					num = 3;
					continue;
				}
				this.Clear();
				num3 = global::System.Math.Min(this.f.Length, bytes.Length);
				num2 = 0;
				num = 1;
				continue;
				IL_AE:
				num = 2;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000408FC File Offset: 0x0003EAFC
		public void SetFieldFocus(int field)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_52:
				if (field < 0)
				{
					return;
				}
				num = 1;
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
					num = 4;
					continue;
				case 2:
					return;
				case 3:
					this.f[field].a(global::custom_controls.f.a, global::custom_controls.k.b);
					num = 2;
					continue;
				case 4:
					if (field < this.f.Length)
					{
						num = 3;
						continue;
					}
					return;
				}
				break;
			}
			goto IL_52;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000409A0 File Offset: 0x0003EBA0
		public void SetFieldRange(int field, int rangeLower, int rangeUpper)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					num = 3;
					continue;
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B;
					default:
						if (false)
						{
						}
						this.f[field].a(rangeLower);
						this.f[field].c(rangeUpper);
						num = 4;
						continue;
					}
					break;
				case 3:
					if (field < this.f.Length)
					{
						num = 2;
						continue;
					}
					return;
				case 4:
					return;
				}
				goto IL_24;
				IL_2B:
				num = 0;
				continue;
				IL_24:
				if (field >= 0)
				{
					goto IL_2B;
				}
				break;
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00040A5C File Offset: 0x0003EC5C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (false)
				{
				}
				stringBuilder = new global::System.Text.StringBuilder();
				try
				{
					for (;;)
					{
						int num = 0;
						int num2 = 3;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (num < this.g.Length)
								{
									num2 = 4;
									continue;
								}
								goto IL_D1;
							case 1:
								goto IL_93;
							case 2:
								if (num >= this.f.Length)
								{
									num2 = 7;
									continue;
								}
								stringBuilder.Append(this.f[num].ToString());
								num2 = 0;
								continue;
							case 3:
								goto IL_93;
							case 4:
								stringBuilder.Append(this.g[num].ToString());
								num2 = 5;
								continue;
							case 5:
								goto IL_D1;
							case 6:
								goto IL_ED;
							case 7:
								num2 = 6;
								continue;
							}
							break;
							IL_93:
							num2 = 2;
							continue;
							IL_D1:
							num++;
							num2 = 1;
						}
					}
					IL_ED:;
				}
				catch (global::System.Exception)
				{
					stringBuilder = null;
				}
				break;
			}
			if (true)
			{
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00040B7C File Offset: 0x0003ED7C
		public CIPAddressControl(global::System.Collections.ArrayList fieldNames, global::custom_controls.AddressType addressType)
		{
			this.q = addressType;
			if (this.q == global::custom_controls.AddressType.IPADDRESS)
			{
				this.f = new global::custom_controls.l[4];
				this.g = new global::custom_controls.h[3];
			}
			else
			{
				if (this.q != global::custom_controls.AddressType.MACADDRESS)
				{
					return;
				}
				this.f = new global::custom_controls.l[6];
				this.g = new global::custom_controls.h[5];
			}
			if (fieldNames != null)
			{
				if (fieldNames.Count == this.f.Length)
				{
					this.a();
					for (int i = 0; i < this.f.Length; i++)
					{
						this.f[i] = new global::custom_controls.l();
						if (fieldNames.Count != this.f.Length)
						{
							this.f[i].Name = base.Name + "_fieldControl" + i.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
						}
						else
						{
							this.f[i].Name = fieldNames[i].ToString();
						}
						this.f[i].CreateControl();
						if (this.q == global::custom_controls.AddressType.IPADDRESS)
						{
							this.f[i].MaxLength = 3;
							this.f[i].Text = "0";
						}
						else if (this.q == global::custom_controls.AddressType.MACADDRESS)
						{
							this.f[i].MaxLength = 2;
							this.f[i].Text = "00";
							this.f[i].a("0123456789ABCDEF");
						}
						this.f[i].a(this.q);
						this.f[i].Parent = this;
						this.f[i].b(i);
						this.f[i].a(new global::custom_controls.b(this.a));
						this.f[i].a(new global::custom_controls.e(this.a));
						this.f[i].SizeChanged += this.c;
						this.f[i].TextChanged += this.b;
						this.f[i].MouseUp += this.a;
						this.f[i].KeyUp += this.a;
						this.f[i].Enter += this.a;
						base.Controls.Add(this.f[i]);
					}
					for (int j = 0; j < this.g.Length; j++)
					{
						this.g[j] = new global::custom_controls.h();
						if (this.q == global::custom_controls.AddressType.IPADDRESS)
						{
							this.g[j].Text = ".";
						}
						else if (this.q == global::custom_controls.AddressType.MACADDRESS)
						{
							this.g[j].Text = ":";
						}
						this.g[j].Name = "dotControl" + j.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
						this.g[j].CreateControl();
						this.g[j].Parent = this;
						this.g[j].SizeChanged += this.c;
						base.Controls.Add(this.g[j]);
					}
					base.Size = this.MinimumSize;
					base.SetStyle(global::System.Windows.Forms.ControlStyles.ResizeRedraw, true);
					base.SetStyle(global::System.Windows.Forms.ControlStyles.UserPaint, true);
					base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
					base.SetStyle(global::System.Windows.Forms.ControlStyles.DoubleBuffer, true);
					this.m = null;
					this.n = false;
					this.b();
					return;
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00040F4C File Offset: 0x0003F14C
		public new global::System.Drawing.Size MinimumSize
		{
			get
			{
				switch (0)
				{
				default:
				{
					global::System.Drawing.Size result;
					for (;;)
					{
						result = new global::System.Drawing.Size(0, 0);
						global::custom_controls.l[] array = this.f;
						int num = 0;
						int num2 = 12;
						for (;;)
						{
							if (true)
							{
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								return result;
							}
							if (false)
							{
							}
							switch (num2)
							{
							case 0:
								goto IL_AB;
							case 1:
							{
								if (num >= array.Length)
								{
									num2 = 7;
									continue;
								}
								global::custom_controls.l l = array[num];
								result.Width += l.Size.Width;
								result.Height = global::System.Math.Max(result.Height, l.Size.Height);
								num++;
								num2 = 3;
								continue;
							}
							case 2:
								num2 = 10;
								continue;
							case 3:
								goto IL_D3;
							case 4:
								goto IL_AB;
							case 5:
							{
								global::System.Windows.Forms.BorderStyle borderStyle;
								switch (borderStyle)
								{
								case global::System.Windows.Forms.BorderStyle.FixedSingle:
									result.Width += 4;
									result.Height += 7;
									num2 = 6;
									continue;
								case global::System.Windows.Forms.BorderStyle.Fixed3D:
									result.Width += 6;
									result.Height += 7;
									num2 = 11;
									continue;
								default:
									num2 = 2;
									continue;
								}
								break;
							}
							case 6:
								return result;
							case 7:
							{
								global::custom_controls.h[] array2 = this.g;
								int num3 = 0;
								num2 = 0;
								continue;
							}
							case 8:
							{
								global::System.Windows.Forms.BorderStyle borderStyle = this.BorderStyle;
								num2 = 5;
								continue;
							}
							case 9:
							{
								global::custom_controls.h[] array2;
								int num3;
								if (num3 >= array2.Length)
								{
									num2 = 8;
									continue;
								}
								global::custom_controls.h h = array2[num3];
								result.Width += h.Size.Width;
								result.Height = global::System.Math.Max(result.Height, h.Size.Height);
								num3++;
								num2 = 4;
								continue;
							}
							case 10:
								return result;
							case 11:
								return result;
							case 12:
								goto IL_D3;
							}
							break;
							IL_AB:
							num2 = 9;
							continue;
							IL_D3:
							num2 = 1;
						}
					}
					return result;
				}
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x000411B8 File Offset: 0x0003F3B8
		public string GetFirstOctatVal
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
				return this.f[0].Text;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00041200 File Offset: 0x0003F400
		public string GetSeconOctatVal
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
				return this.f[1].Text;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00041248 File Offset: 0x0003F448
		public string GetThirdOctatVal
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
				return this.f[2].Text;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00041290 File Offset: 0x0003F490
		public string GetFourthctatVal
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
				return this.f[3].Text;
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000412D8 File Offset: 0x0003F4D8
		public void SelectOctet(int index)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			this.f[index].Select();
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00041320 File Offset: 0x0003F520
		public string GetTextSelected
		{
			get
			{
				string result;
				for (;;)
				{
					result = string.Empty;
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							return result;
						case 1:
							if (this.m != null)
							{
								goto IL_2A;
							}
							return result;
						case 2:
							if (true)
							{
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2A;
							default:
								if (false)
								{
								}
								result = this.m.SelectedText;
								num = 0;
								continue;
							}
							break;
						}
						break;
						IL_2A:
						num = 2;
					}
				}
				return result;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000413A8 File Offset: 0x0003F5A8
		private void c()
		{
			if (true)
			{
			}
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Drawing.Size minimumSize = this.MinimumSize;
					global::System.Drawing.Size size = base.Size;
					int num = 1;
					for (;;)
					{
						global::System.Drawing.Size size2;
						switch (num)
						{
						case 0:
							minimumSize = new global::System.Drawing.Size(base.Size.Width, minimumSize.Height);
							num = 4;
							continue;
						case 1:
							if (size.Width > minimumSize.Width)
							{
								num = 0;
								continue;
							}
							goto IL_122;
						case 2:
							if (!this.i)
							{
								base.Size = minimumSize;
								num = 3;
								continue;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_156;
							default:
								if (false)
								{
								}
								num = 5;
								continue;
							}
							break;
						case 3:
							goto IL_120;
						case 4:
							goto IL_122;
						case 5:
							base.Size = new global::System.Drawing.Size(minimumSize.Width, this.MinimumSize.Height);
							num = 8;
							continue;
						case 6:
							minimumSize = new global::System.Drawing.Size(minimumSize.Width, base.Size.Height);
							num = 9;
							continue;
						case 7:
							if (size2.Height > minimumSize.Height)
							{
								num = 6;
								continue;
							}
							goto IL_156;
						case 8:
							goto IL_A9;
						case 9:
							goto IL_156;
						}
						break;
						IL_122:
						size2 = base.Size;
						num = 7;
						continue;
						IL_156:
						num = 2;
					}
				}
				IL_A9:
				IL_120:
				this.b();
				return;
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00041554 File Offset: 0x0003F754
		private void b(object A_0, global::System.Windows.Forms.DragEventArgs A_1)
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
			this.Text = A_1.Data.GetData(global::System.Windows.Forms.DataFormats.Text).ToString();
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000415AC File Offset: 0x0003F7AC
		private void a(object A_0, global::System.Windows.Forms.DragEventArgs A_1)
		{
			if (A_1.Data.GetDataPresent(global::System.Windows.Forms.DataFormats.Text))
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
				A_1.Effect = global::System.Windows.Forms.DragDropEffects.Copy;
				return;
			}
			if (true)
			{
			}
			A_1.Effect = global::System.Windows.Forms.DragDropEffects.None;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0004160C File Offset: 0x0003F80C
		private void b()
		{
			switch (0)
			{
			default:
				for (;;)
				{
					base.SuspendLayout();
					int num = base.Size.Width - this.MinimumSize.Width;
					int num2 = this.f.Length + this.g.Length + 1;
					int num3 = num / num2;
					int num4 = num % num2;
					int[] array = new int[num2];
					int num5 = 0;
					int num6 = 1;
					for (;;)
					{
						int num7;
						int y;
						int num8;
						int num9;
						switch (num6)
						{
						case 0:
							goto IL_1B8;
						case 1:
							goto IL_1F2;
						case 2:
							goto IL_192;
						case 3:
							num6 = 17;
							continue;
						case 4:
						{
							global::System.Windows.Forms.BorderStyle borderStyle;
							switch (borderStyle)
							{
							case global::System.Windows.Forms.BorderStyle.FixedSingle:
								num7 = 2;
								y = 2;
								num6 = 8;
								continue;
							case global::System.Windows.Forms.BorderStyle.Fixed3D:
								goto IL_125;
							default:
								num6 = 3;
								continue;
							}
							break;
						}
						case 5:
							goto IL_1B8;
						case 6:
							goto IL_139;
						case 7:
							num7 += array[num8++];
							this.g[num9].Location = new global::System.Drawing.Point(num7, y);
							num7 += this.g[num9].Size.Width;
							num7 += array[num8++];
							num6 = 13;
							continue;
						case 8:
							goto IL_192;
						case 9:
							if (num9 >= this.f.Length)
							{
								num6 = 14;
								continue;
							}
							this.f[num9].Location = new global::System.Drawing.Point(num7, y);
							num7 += this.f[num9].Size.Width;
							if (true)
							{
							}
							num6 = 11;
							continue;
						case 10:
							if (num5 >= num2)
							{
								num6 = 15;
								continue;
							}
							array[num5] = num3;
							num6 = 16;
							continue;
						case 11:
							if (num9 < this.g.Length)
							{
								num6 = 7;
								continue;
							}
							goto IL_150;
						case 12:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_125;
							default:
								if (false)
								{
								}
								array[num5]++;
								num6 = 6;
								continue;
							}
							break;
						case 13:
							goto IL_150;
						case 14:
							goto IL_1DF;
						case 15:
						{
							num7 = 0;
							y = 0;
							global::System.Windows.Forms.BorderStyle borderStyle = this.BorderStyle;
							num6 = 4;
							continue;
						}
						case 16:
							if (num5 < num4)
							{
								num6 = 12;
								continue;
							}
							goto IL_139;
						case 17:
							goto IL_192;
						case 18:
							goto IL_1F2;
						}
						break;
						IL_125:
						num7 = 3;
						y = 3;
						num6 = 2;
						continue;
						IL_139:
						num5++;
						num6 = 18;
						continue;
						IL_150:
						num9++;
						num6 = 0;
						continue;
						IL_192:
						num8 = 0;
						num7 += array[num8++];
						num9 = 0;
						num6 = 5;
						continue;
						IL_1B8:
						num6 = 9;
						continue;
						IL_1F2:
						num6 = 10;
					}
				}
				IL_1DF:
				base.ResumeLayout(false);
				return;
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00041934 File Offset: 0x0003FB34
		private bool a(int A_0, global::custom_controls.f A_1, global::custom_controls.k A_2)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_87;
				case 1:
					goto IL_10D;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6D;
					default:
						if (false)
						{
						}
						num = 10;
						continue;
					}
					break;
				case 4:
					if (A_0 != 0)
					{
						num = 11;
						continue;
					}
					return false;
				case 5:
					A_0++;
					num = 9;
					continue;
				case 6:
					num = 4;
					continue;
				case 7:
					goto IL_6D;
				case 8:
					if (A_1 == global::custom_controls.f.a)
					{
						num = 5;
						continue;
					}
					A_0--;
					num = 0;
					continue;
				case 9:
					goto IL_BF;
				case 10:
					if (A_0 == this.f.Length - 1)
					{
						num = 1;
						continue;
					}
					goto IL_4E;
				case 11:
					goto IL_65;
				}
				if (A_1 == global::custom_controls.f.b)
				{
					num = 6;
					continue;
				}
				goto IL_65;
				IL_4E:
				num = 8;
				continue;
				IL_6D:
				if (A_1 == global::custom_controls.f.a)
				{
					num = 3;
					continue;
				}
				goto IL_4E;
				IL_65:
				num = 7;
			}
			return false;
			IL_87:
			if (true)
			{
			}
			IL_BF:
			goto IL_112;
			IL_10D:
			return false;
			IL_112:
			this.f[A_0].a(A_1, A_2);
			return true;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00041A64 File Offset: 0x0003FC64
		private void a(int A_0, string A_1)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_71;
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_24;
					}
					if (true)
					{
					}
					if (false)
					{
					}
					this.p(A_0, A_1);
					num = 0;
					continue;
				}
				goto IL_1C;
				IL_24:
				num = 2;
				continue;
				IL_1C:
				if (this.p != null)
				{
					goto IL_24;
				}
				break;
			}
			IL_71:
			this.OnTextChanged(global::System.EventArgs.Empty);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00041AF0 File Offset: 0x0003FCF0
		private void a(string A_0)
		{
			int num;
			int num2;
			for (;;)
			{
				this.Clear();
				num = 0;
				num2 = 0;
				int num3 = 1;
				for (;;)
				{
					int num4;
					switch (num3)
					{
					case 0:
						if (num4 >= 0)
						{
							num3 = 3;
							continue;
						}
						goto IL_F9;
					case 1:
						goto IL_36;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_72;
						default:
							goto IL_67;
						}
						break;
					case 3:
						goto IL_72;
					case 4:
						if (num2 >= this.g.Length)
						{
							num3 = 2;
							continue;
						}
						num4 = A_0.IndexOf(this.g[num2].Text, num, global::System.StringComparison.Ordinal);
						num3 = 0;
						continue;
					case 5:
						goto IL_36;
					}
					break;
					IL_36:
					num3 = 4;
					continue;
					IL_72:
					if (true)
					{
					}
					this.f[num2].Text = A_0.Substring(num, num4 - num);
					num = num4 + this.g[num2].Text.Length;
					num2++;
					num3 = 5;
				}
			}
			IL_67:
			if (false)
			{
			}
			IL_F9:
			this.f[num2].Text = A_0.Substring(num);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00041C0C File Offset: 0x0003FE0C
		protected override void OnBackColorChanged(global::System.EventArgs e)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::custom_controls.l[] array = this.f;
					int num = 0;
					int num2 = 3;
					for (;;)
					{
						int num3;
						global::custom_controls.l l;
						switch (num2)
						{
						case 0:
						{
							global::custom_controls.h h;
							if (h != null)
							{
								num2 = 7;
								continue;
							}
							goto IL_C6;
						}
						case 1:
						{
							global::custom_controls.h[] array2;
							if (num3 >= array2.Length)
							{
								num2 = 2;
								continue;
							}
							global::custom_controls.h h = array2[num3];
							num2 = 0;
							continue;
						}
						case 2:
							goto IL_14C;
						case 3:
							goto IL_14E;
						case 4:
							goto IL_A9;
						case 5:
							goto IL_12C;
						case 6:
							if (true)
							{
							}
							if (l != null)
							{
								num2 = 4;
								continue;
							}
							goto IL_190;
						case 7:
						{
							global::custom_controls.h h;
							h.BackColor = this.BackColor;
							h.Invalidate();
							num2 = 10;
							continue;
						}
						case 8:
							goto IL_14E;
						case 9:
							goto IL_12C;
						case 10:
							goto IL_C6;
						case 11:
							if (num >= array.Length)
							{
								num2 = 12;
								continue;
							}
							l = array[num];
							num2 = 6;
							continue;
						case 12:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_A9;
							default:
							{
								if (false)
								{
								}
								global::custom_controls.h[] array2 = this.g;
								num3 = 0;
								num2 = 5;
								continue;
							}
							}
							break;
						case 13:
							goto IL_190;
						}
						break;
						IL_A9:
						l.BackColor = this.BackColor;
						num2 = 13;
						continue;
						IL_C6:
						num3++;
						num2 = 9;
						continue;
						IL_12C:
						num2 = 1;
						continue;
						IL_14E:
						num2 = 11;
						continue;
						IL_190:
						num++;
						num2 = 8;
					}
				}
				IL_14C:
				base.OnBackColorChanged(e);
				base.Invalidate();
				return;
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00041DC8 File Offset: 0x0003FFC8
		protected override void OnFontChanged(global::System.EventArgs e)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::custom_controls.l[] array = this.f;
					int num = 0;
					int num2 = 4;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_D1;
						case 1:
						{
							int num3;
							global::custom_controls.h[] array2;
							if (num3 >= array2.Length)
							{
								num2 = 0;
								continue;
							}
							global::custom_controls.h h = array2[num3];
							h.a(this.Font);
							num3++;
							num2 = 2;
							continue;
						}
						case 2:
							goto IL_B1;
						case 3:
							goto IL_D3;
						case 4:
							goto IL_D3;
						case 5:
						{
							if (num >= array.Length)
							{
								num2 = 6;
								continue;
							}
							global::custom_controls.l l = array[num];
							l.a(this.Font);
							num++;
							num2 = 3;
							continue;
						}
						case 6:
						{
							global::custom_controls.h[] array2 = this.g;
							int num3 = 0;
							if (true)
							{
							}
							num2 = 7;
							continue;
						}
						case 7:
							IL_8D:
							goto IL_B1;
						}
						break;
						IL_B1:
						num2 = 1;
						continue;
						IL_D3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8D;
						default:
							if (false)
							{
							}
							num2 = 5;
							break;
						}
					}
				}
				IL_D1:
				base.OnFontChanged(e);
				this.c();
				return;
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00041F00 File Offset: 0x00040100
		protected override void OnForeColorChanged(global::System.EventArgs e)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::custom_controls.l[] array = this.f;
					int num = 0;
					int num2 = 3;
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::custom_controls.h[] array2 = this.g;
							int num3 = 0;
							if (true)
							{
							}
							num2 = 2;
							continue;
						}
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_B0;
							default:
								goto IL_F7;
							}
							break;
						case 2:
							goto IL_BE;
						case 3:
							goto IL_FF;
						case 4:
						{
							global::custom_controls.h[] array2;
							int num3;
							if (num3 >= array2.Length)
							{
								num2 = 1;
								continue;
							}
							global::custom_controls.h h = array2[num3];
							h.ForeColor = this.ForeColor;
							num3++;
							num2 = 6;
							continue;
						}
						case 5:
						{
							if (num >= array.Length)
							{
								num2 = 0;
								continue;
							}
							global::custom_controls.l l = array[num];
							l.ForeColor = this.ForeColor;
							num++;
							goto IL_B0;
						}
						case 6:
							goto IL_BE;
						case 7:
							goto IL_FF;
						}
						break;
						IL_B0:
						num2 = 7;
						continue;
						IL_BE:
						num2 = 4;
						continue;
						IL_FF:
						num2 = 5;
					}
				}
				IL_F7:
				if (false)
				{
				}
				base.OnForeColorChanged(e);
				base.Invalidate();
				return;
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0004203C File Offset: 0x0004023C
		protected override void OnGotFocus(global::System.EventArgs e)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			this.f[0].a(global::custom_controls.f.a, global::custom_controls.k.b);
			base.OnGotFocus(e);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00042090 File Offset: 0x00040290
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs e)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					IL_5F:
					int num;
					global::System.Drawing.SolidBrush solidBrush;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_1A6:
						num = 15;
						break;
					default:
						if (false)
						{
						}
						solidBrush = null;
						num = 11;
						break;
					}
					for (;;)
					{
						global::System.Windows.Forms.BorderStyle borderStyle;
						switch (num)
						{
						case 0:
							solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Control));
							num = 3;
							continue;
						case 1:
							solidBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Control));
							num = 16;
							continue;
						case 2:
						{
							if (true)
							{
							}
							global::System.Drawing.Color backColor = this.BackColor;
							num = 17;
							continue;
						}
						case 3:
							goto IL_125;
						case 4:
							if (this.ReadOnly)
							{
								num = 2;
								continue;
							}
							solidBrush = new global::System.Drawing.SolidBrush(this.BackColor);
							num = 12;
							continue;
						case 5:
							return;
						case 6:
							num = 4;
							continue;
						case 7:
							goto IL_1B7;
						case 8:
							solidBrush.Dispose();
							num = 7;
							continue;
						case 9:
							goto IL_125;
						case 10:
							switch (borderStyle)
							{
							case global::System.Windows.Forms.BorderStyle.FixedSingle:
								goto IL_254;
							case global::System.Windows.Forms.BorderStyle.Fixed3D:
								goto IL_157;
							default:
								num = 5;
								continue;
							}
							break;
						case 11:
						{
							if (base.Enabled)
							{
								num = 6;
								continue;
							}
							global::System.Drawing.Color backColor2 = this.BackColor;
							num = 13;
							continue;
						}
						case 12:
							goto IL_125;
						case 13:
						{
							global::System.Drawing.Color backColor2;
							if (backColor2.ToKnownColor() == global::System.Drawing.KnownColor.Window)
							{
								num = 0;
								continue;
							}
							solidBrush = new global::System.Drawing.SolidBrush(this.BackColor);
							num = 9;
							continue;
						}
						case 14:
							if (solidBrush != null)
							{
								num = 8;
								continue;
							}
							goto IL_1B7;
						case 15:
							goto IL_125;
						case 16:
							goto IL_125;
						case 17:
						{
							global::System.Drawing.Color backColor;
							if (backColor.ToKnownColor() == global::System.Drawing.KnownColor.Window)
							{
								num = 1;
								continue;
							}
							goto IL_19A;
						}
						}
						goto IL_5F;
						IL_125:
						e.Graphics.FillRectangle(solidBrush, base.ClientRectangle);
						num = 14;
						continue;
						IL_1B7:
						borderStyle = this.BorderStyle;
						num = 10;
					}
					IL_19A:
					solidBrush = new global::System.Drawing.SolidBrush(this.BackColor);
					goto IL_1A6;
				}
				IL_157:
				global::System.Windows.Forms.ControlPaint.DrawBorder3D(e.Graphics, base.ClientRectangle, global::System.Windows.Forms.Border3DStyle.Sunken);
				return;
				IL_254:
				global::System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, base.ClientRectangle, global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.WindowFrame), global::System.Windows.Forms.ButtonBorderStyle.Solid);
				return;
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0004230C File Offset: 0x0004050C
		protected override void OnSizeChanged(global::System.EventArgs e)
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
			base.OnSizeChanged(e);
			this.c();
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00042354 File Offset: 0x00040554
		private void c(object A_0, global::System.EventArgs A_1)
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
			this.c();
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00042398 File Offset: 0x00040598
		protected override void WndProc(ref global::System.Windows.Forms.Message m)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					int msg = m.Msg;
					int num = 3;
					for (;;)
					{
						global::custom_controls.p structure;
						switch (num)
						{
						case 0:
							goto IL_A7;
						case 1:
							goto IL_11F;
						case 2:
							if (structure.f < this.MinimumSize.Height)
							{
								num = 9;
								continue;
							}
							goto IL_A7;
						case 3:
							if (msg == 70)
							{
								num = 8;
								continue;
							}
							goto IL_235;
						case 4:
							if (structure.f != this.MinimumSize.Height)
							{
								goto IL_96;
							}
							goto IL_FE;
						case 5:
							goto IL_FE;
						case 6:
							structure.g |= 2U;
							structure.e = this.MinimumSize.Width;
							num = 7;
							continue;
						case 7:
							goto IL_200;
						case 8:
							structure = (global::custom_controls.p)m.GetLParam(typeof(global::custom_controls.p));
							num = 13;
							continue;
						case 9:
							structure.g |= 2U;
							structure.f = this.MinimumSize.Height;
							num = 0;
							continue;
						case 10:
							structure.g |= 2U;
							structure.f = this.MinimumSize.Height;
							num = 5;
							continue;
						case 11:
							if (this.i)
							{
								num = 12;
								continue;
							}
							goto IL_FE;
						case 12:
							num = 4;
							continue;
						case 13:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_96;
							default:
								if (false)
								{
								}
								if (structure.e < this.MinimumSize.Width)
								{
									num = 6;
									continue;
								}
								goto IL_200;
							}
							break;
						}
						break;
						IL_96:
						num = 10;
						continue;
						IL_A7:
						num = 11;
						continue;
						IL_FE:
						global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::custom_controls.p>(structure, m.LParam, true);
						if (true)
						{
						}
						num = 1;
						continue;
						IL_200:
						num = 2;
					}
				}
				IL_11F:
				IL_235:
				base.WndProc(ref m);
				return;
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000425E4 File Offset: 0x000407E4
		protected override void Dispose(bool disposing)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_68;
				case 1:
					if (this.o != null)
					{
						num = 2;
						continue;
					}
					goto IL_91;
				case 2:
					this.o.Dispose();
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						num = 0;
						continue;
					}
					break;
				case 4:
					num = 1;
					continue;
				}
				if (true)
				{
				}
				if (!disposing)
				{
					break;
				}
				num = 4;
			}
			IL_68:
			IL_91:
			base.Dispose(disposing);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0004268C File Offset: 0x0004088C
		private void a()
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
			this.BackColor = global::System.Drawing.SystemColors.Window;
			base.Name = "CIPAddressControl";
			base.DragEnter += this.a;
			base.DragDrop += this.b;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00042704 File Offset: 0x00040904
		private void b(object A_0, global::System.EventArgs A_1)
		{
			for (;;)
			{
				global::custom_controls.l l = (global::custom_controls.l)A_0;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_6B;
					case 1:
						this.GetSelText(this);
						num = 4;
						continue;
					case 2:
						if (this.n)
						{
							num = 3;
							continue;
						}
						goto IL_88;
					case 3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_88;
						default:
							if (false)
							{
							}
							this.h = false;
							l.d(false);
							num = 5;
							continue;
						}
						break;
					case 4:
						return;
					case 5:
						goto IL_6B;
					case 6:
						if (this.GetSelText != null)
						{
							num = 1;
							continue;
						}
						return;
					}
					break;
					IL_6B:
					num = 6;
					continue;
					IL_88:
					if (true)
					{
					}
					this.h = true;
					l.d(true);
					num = 0;
				}
			}
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000427F0 File Offset: 0x000409F0
		private void a(object A_0, global::System.Windows.Forms.MouseEventArgs A_1)
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 0:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_50;
					default:
						if (false)
						{
						}
						break;
					}
					break;
				case 1:
					return;
				case 2:
					goto IL_50;
				}
				if (true)
				{
				}
				if (this.GetSelText != null)
				{
					num = 2;
					continue;
				}
				break;
				IL_50:
				this.GetSelText(this);
				num = 1;
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00042870 File Offset: 0x00040A70
		private void a(object A_0, global::System.Windows.Forms.KeyEventArgs A_1)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.GetSelText(this);
					num = 2;
					continue;
				case 2:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_60;
					}
					break;
				}
				if (true)
				{
				}
				if (this.GetSelText == null)
				{
					return;
				}
				num = 0;
			}
			IL_60:
			if (false)
			{
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000428F0 File Offset: 0x00040AF0
		private void a(object A_0, global::System.EventArgs A_1)
		{
			if (true)
			{
			}
			for (;;)
			{
				base.OnEnter(A_1);
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_77;
					case 1:
						this.GetSelText(this);
						num = 0;
						continue;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_77;
						}
						if (false)
						{
						}
						if (this.GetSelText != null)
						{
							num = 1;
							continue;
						}
						goto IL_79;
					}
					break;
				}
			}
			IL_77:
			IL_79:
			this.m = null;
			this.m = (global::custom_controls.l)A_0;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0004298C File Offset: 0x00040B8C
		public void LoadMenuText(string cut, string copy, string paste, string delete, string undo)
		{
			int num = 9;
			for (;;)
			{
				int num2;
				switch (num)
				{
				case 0:
					goto IL_213;
				case 1:
					return;
				case 2:
					this.f[num2].l.Text = paste;
					num = 21;
					continue;
				case 3:
					goto IL_1CF;
				case 4:
					goto IL_237;
				case 5:
					goto IL_142;
				case 6:
					if (true)
					{
					}
					if (!string.IsNullOrEmpty(copy))
					{
						num = 7;
						continue;
					}
					goto IL_267;
				case 7:
					this.f[num2].k.Text = copy;
					num = 17;
					continue;
				case 8:
					if (!string.IsNullOrEmpty(delete))
					{
						num = 11;
						continue;
					}
					goto IL_1CF;
				case 10:
					this.f[num2].j.Text = cut;
					num = 15;
					continue;
				case 11:
					this.f[num2].m.Text = delete;
					num = 3;
					continue;
				case 12:
					if (!string.IsNullOrEmpty(cut))
					{
						num = 10;
						continue;
					}
					goto IL_23C;
				case 13:
					this.f[num2].h.Text = undo;
					num = 16;
					continue;
				case 14:
					if (num2 >= this.f.Length)
					{
						num = 1;
						continue;
					}
					num = 12;
					continue;
				case 15:
					goto IL_23C;
				case 16:
					goto IL_1BB;
				case 17:
					goto IL_267;
				case 18:
					if (this.f.Length <= 0)
					{
						num = 4;
						continue;
					}
					num2 = 0;
					num = 19;
					continue;
				case 19:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_213;
					default:
						if (false)
						{
						}
						goto IL_142;
					}
					break;
				case 20:
					if (!string.IsNullOrEmpty(paste))
					{
						num = 2;
						continue;
					}
					goto IL_11B;
				case 21:
					goto IL_11B;
				case 22:
					if (!string.IsNullOrEmpty(undo))
					{
						num = 13;
						continue;
					}
					goto IL_1BB;
				}
				if (this.f != null)
				{
					num = 0;
					continue;
				}
				break;
				IL_11B:
				num = 8;
				continue;
				IL_142:
				num = 14;
				continue;
				IL_1BB:
				num2++;
				num = 5;
				continue;
				IL_1CF:
				num = 22;
				continue;
				IL_213:
				num = 18;
				continue;
				IL_23C:
				num = 6;
				continue;
				IL_267:
				num = 20;
			}
			return;
			IL_237:;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00042C28 File Offset: 0x00040E28
		public void Cut()
		{
			int num = 0;
			for (;;)
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
					switch (num)
					{
					case 1:
						this.m.Cut();
						if (true)
						{
						}
						num = 2;
						continue;
					case 2:
						return;
					}
					break;
				}
				if (this.m == null)
				{
					break;
				}
				num = 1;
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00042CA8 File Offset: 0x00040EA8
		public void Copy()
		{
			if (true)
			{
			}
			int num = 0;
			for (;;)
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
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.m.Copy();
						num = 1;
						continue;
					}
					break;
				}
				if (this.m == null)
				{
					break;
				}
				num = 2;
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00042D28 File Offset: 0x00040F28
		public void Paste()
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.m.Paste();
					goto IL_67;
				case 1:
					return;
				}
				if (this.m == null)
				{
					break;
				}
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
					num = 0;
					continue;
				}
				IL_67:
				num = 1;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00042DA8 File Offset: 0x00040FA8
		public void Delete()
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.m.a(this.m);
					goto IL_65;
				case 1:
					return;
				}
				if (this.m == null)
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
					num = 0;
					continue;
				}
				IL_65:
				if (true)
				{
				}
				num = 1;
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00042E2C File Offset: 0x0004102C
		public void UndoText()
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.m.r();
					this.m.d(false);
					num = 2;
					continue;
				case 1:
					goto IL_08;
				case 2:
					return;
				}
				IL_2E:
				if (this.m == null)
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
					num = 0;
					continue;
				}
				IL_08:
				if (true)
				{
				}
				goto IL_2E;
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00042EB8 File Offset: 0x000410B8
		public bool CanUndoText()
		{
			bool result;
			for (;;)
			{
				result = false;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (true)
						{
						}
						result = this.m.u();
						goto IL_6A;
					case 1:
						return result;
					case 2:
						if (this.m == null)
						{
							return result;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6A;
						default:
							if (false)
							{
							}
							num = 0;
							continue;
						}
						break;
					}
					break;
					IL_6A:
					num = 1;
				}
			}
			return result;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00042F3C File Offset: 0x0004113C
		public bool CanDisiableUndoMenu()
		{
			bool result;
			for (;;)
			{
				IL_3A:
				if (true)
				{
				}
				result = false;
				for (;;)
				{
					IL_44:
					int num = 0;
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_44;
						}
						if (false)
						{
						}
						switch (num)
						{
						case 0:
							if (this.m != null)
							{
								num = 1;
								continue;
							}
							return result;
						case 1:
							result = this.m.f();
							num = 2;
							continue;
						case 2:
							return result;
						}
						goto IL_3A;
					}
				}
			}
			return result;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00042FC0 File Offset: 0x000411C0
		public void GetIndFieldIds(ref global::System.Collections.ArrayList fieldIds)
		{
			try
			{
				for (;;)
				{
					IL_00:
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_A7;
						case 2:
							goto IL_A7;
						case 3:
							num = 4;
							continue;
						case 4:
							goto IL_A5;
						case 5:
							goto IL_DD;
						case 6:
						{
							int num2;
							if (num2 >= this.f.Length)
							{
								num = 7;
								continue;
							}
							fieldIds.Add(this.f[num2].Name);
							num2++;
							num = 0;
							continue;
						}
						case 7:
							num = 5;
							continue;
						}
						if (fieldIds != null)
						{
							fieldIds.Add(base.Name);
							int num2 = 0;
							num = 2;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							if (false)
							{
							}
							num = 3;
							continue;
						}
						IL_A7:
						if (true)
						{
						}
						num = 6;
					}
				}
				IL_A5:
				IL_DD:;
			}
			catch
			{
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000430CC File Offset: 0x000412CC
		public void SetRangeForEachCell(string xml)
		{
			try
			{
				switch (0)
				{
				default:
				{
					int num = 7;
					for (;;)
					{
						int num2;
						int num3;
						global::System.Xml.XmlDocument xmlDocument;
						switch (num)
						{
						case 0:
							goto IL_2C9;
						case 1:
							goto IL_319;
						case 2:
							num = 9;
							continue;
						case 3:
							goto IL_141;
						case 4:
							num = 1;
							continue;
						case 5:
							goto IL_27B;
						case 6:
							goto IL_1C2;
						case 8:
							goto IL_2BB;
						case 9:
						{
							string name;
							if (!(name == "StepSize"))
							{
								num = 18;
								continue;
							}
							global::System.Xml.XmlNodeList childNodes;
							this.f[num2].d(int.Parse(childNodes[num3].InnerText, global::System.Globalization.CultureInfo.InvariantCulture));
							num = 23;
							continue;
						}
						case 10:
						{
							string name;
							global::System.Xml.XmlNodeList childNodes;
							if ((name = childNodes[num3].Name) != null)
							{
								num = 19;
								continue;
							}
							goto IL_27B;
						}
						case 11:
						{
							if (num2 >= this.f.Length)
							{
								num = 4;
								continue;
							}
							global::System.Xml.XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode(this.f[num2].Name + "/RANGE");
							global::System.Xml.XmlNodeList childNodes = xmlNode.ChildNodes;
							num3 = 0;
							num = 3;
							continue;
						}
						case 12:
						{
							string name;
							if (!(name == "Max"))
							{
								num = 2;
								continue;
							}
							global::System.Xml.XmlNodeList childNodes;
							this.f[num2].c(int.Parse(childNodes[num3].InnerText, global::System.Globalization.CultureInfo.InvariantCulture));
							num = 22;
							continue;
						}
						case 13:
						{
							string name;
							if (!(name == "Min"))
							{
								num = 8;
								continue;
							}
							global::System.Xml.XmlNodeList childNodes;
							this.f[num2].a(int.Parse(childNodes[num3].InnerText, global::System.Globalization.CultureInfo.InvariantCulture));
							num = 5;
							continue;
						}
						case 14:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2BB;
							default:
								if (false)
								{
								}
								num2++;
								num = 16;
								continue;
							}
							break;
						case 15:
						{
							global::System.Xml.XmlNodeList childNodes;
							if (num3 >= childNodes.Count)
							{
								num = 14;
								continue;
							}
							num = 10;
							continue;
						}
						case 16:
							goto IL_1C2;
						case 17:
							goto IL_27B;
						case 18:
							num = 17;
							continue;
						case 19:
							num = 13;
							continue;
						case 20:
							num = 0;
							continue;
						case 21:
							goto IL_141;
						case 22:
							goto IL_27B;
						case 23:
							goto IL_27B;
						}
						if (string.IsNullOrEmpty(xml))
						{
							num = 20;
							continue;
						}
						xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.LoadXml(xml);
						num2 = 0;
						num = 6;
						continue;
						IL_141:
						num = 15;
						continue;
						IL_1C2:
						num = 11;
						continue;
						IL_27B:
						num3++;
						num = 21;
						continue;
						IL_2BB:
						num = 12;
					}
					IL_2C9:
					IL_319:
					break;
				}
				}
			}
			catch
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00043428 File Offset: 0x00041628
		public void EnableDisableFields(string xml)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						bool enabled = false;
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.LoadXml(xml);
						string text = string.Empty;
						int num = 0;
						int num2 = 11;
						for (;;)
						{
							int num3;
							switch (num2)
							{
							case 0:
								goto IL_1BB;
							case 1:
								goto IL_D2;
							case 2:
								goto IL_7C;
							case 3:
								this.f[num3].Enabled = enabled;
								num2 = 1;
								continue;
							case 4:
								goto IL_D2;
							case 5:
								if (num3 >= this.f.Length)
								{
									num2 = 4;
									continue;
								}
								num2 = 10;
								continue;
							case 6:
								goto IL_221;
							case 7:
								goto IL_7C;
							case 8:
							{
								string value;
								if ("Enabled" == value)
								{
									if (true)
									{
									}
									num2 = 9;
									continue;
								}
								enabled = false;
								num2 = 0;
								continue;
							}
							case 9:
								IL_16F:
								enabled = true;
								num2 = 13;
								continue;
							case 10:
								if (this.f[num3].Name == text)
								{
									num2 = 3;
									continue;
								}
								num3++;
								num2 = 7;
								continue;
							case 11:
								goto IL_18B;
							case 12:
								goto IL_18B;
							case 13:
								goto IL_1BB;
							case 14:
							{
								if (num >= xmlDocument.DocumentElement.ChildNodes.Count)
								{
									num2 = 15;
									continue;
								}
								text = xmlDocument.DocumentElement.ChildNodes[num].Name;
								string value = xmlDocument.DocumentElement.ChildNodes[num].Attributes["Applicable"].Value;
								num2 = 8;
								continue;
							}
							case 15:
								num2 = 6;
								continue;
							}
							break;
							IL_7C:
							num2 = 5;
							continue;
							IL_D2:
							num++;
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_16F;
							default:
								if (false)
								{
								}
								num2 = 12;
								continue;
							}
							IL_18B:
							num2 = 14;
							continue;
							IL_1BB:
							num3 = 0;
							num2 = 2;
						}
					}
					IL_221:
					break;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00043684 File Offset: 0x00041884
		public void SetRangeFistOctat(int min, int max)
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
			this.f[0].a(min);
			this.f[0].c(max);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000436DC File Offset: 0x000418DC
		public void SetSecondFistOctat(int min, int max)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			this.f[1].a(min);
			this.f[1].c(max);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00043734 File Offset: 0x00041934
		public void SetThirdOctat(int min, int max)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			this.f[2].a(min);
			this.f[2].c(max);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0004378C File Offset: 0x0004198C
		public void SetFourthOctat(int min, int max)
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
			this.f[3].a(min);
			this.f[3].c(max);
		}

		// Token: 0x040002B4 RID: 692
		private const string a = "Min";

		// Token: 0x040002B5 RID: 693
		private const string b = "Max";

		// Token: 0x040002B6 RID: 694
		private const string c = "StepSize";

		// Token: 0x040002B7 RID: 695
		private const string d = "/";

		// Token: 0x040002B8 RID: 696
		private const string e = "RANGE";

		// Token: 0x040002B9 RID: 697
		public const int WS_EX_LAYOUTRTL = 4194304;

		// Token: 0x040002BA RID: 698
		public const int WS_EX_NOINHERITLAYOUT = 1048576;

		// Token: 0x040002BB RID: 699
		private global::custom_controls.l[] f;

		// Token: 0x040002BC RID: 700
		private global::custom_controls.h[] g;

		// Token: 0x040002BD RID: 701
		private bool h;

		// Token: 0x040002BE RID: 702
		private bool i;

		// Token: 0x040002BF RID: 703
		private global::System.Windows.Forms.BorderStyle j = global::System.Windows.Forms.BorderStyle.Fixed3D;

		// Token: 0x040002C0 RID: 704
		private bool k;

		// Token: 0x040002C1 RID: 705
		private bool l;

		// Token: 0x040002C2 RID: 706
		private global::custom_controls.l m;

		// Token: 0x040002C3 RID: 707
		private bool n;

		// Token: 0x040002C4 RID: 708
		private global::System.ComponentModel.Container o;

		// Token: 0x040002C5 RID: 709
		private global::custom_controls.FieldChangedHandler p;

		// Token: 0x040002C6 RID: 710
		private global::custom_controls.AddressType q;

		// Token: 0x040002C7 RID: 711
		public global::custom_controls.CIPAddressControl.GetSelectedText GetSelText;

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x0600041B RID: 1051
		public delegate void GetSelectedText(object sender);
	}
}
