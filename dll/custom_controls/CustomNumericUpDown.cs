using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x0200002C RID: 44
	public class CustomNumericUpDown : global::System.Windows.Forms.NumericUpDown
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600018C RID: 396 RVA: 0x0001FC70 File Offset: 0x0001DE70
		// (remove) Token: 0x0600018D RID: 397 RVA: 0x0001FD08 File Offset: 0x0001DF08
		public event global::custom_controls.CustomNumericUpDown.ValueChangedDelegate SaveValue
		{
			add
			{
				for (;;)
				{
					global::custom_controls.CustomNumericUpDown.ValueChangedDelegate valueChangedDelegate = this.am;
					if (true)
					{
					}
					int num = 1;
					for (;;)
					{
						global::custom_controls.CustomNumericUpDown.ValueChangedDelegate valueChangedDelegate2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_37;
						case 2:
							if (valueChangedDelegate != valueChangedDelegate2)
							{
								goto IL_37;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_37;
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
						IL_37:
						valueChangedDelegate2 = valueChangedDelegate;
						global::custom_controls.CustomNumericUpDown.ValueChangedDelegate value2 = (global::custom_controls.CustomNumericUpDown.ValueChangedDelegate)global::System.Delegate.Combine(valueChangedDelegate2, value);
						valueChangedDelegate = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomNumericUpDown.ValueChangedDelegate>(ref this.am, value2, valueChangedDelegate2);
						num = 2;
					}
				}
			}
			remove
			{
				global::custom_controls.CustomNumericUpDown.ValueChangedDelegate valueChangedDelegate;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_3F:
					int num = 0;
					for (;;)
					{
						if (true)
						{
						}
						global::custom_controls.CustomNumericUpDown.ValueChangedDelegate valueChangedDelegate2;
						switch (num)
						{
						case 0:
							goto IL_49;
						case 1:
							return;
						case 2:
							if (valueChangedDelegate == valueChangedDelegate2)
							{
								num = 1;
								continue;
							}
							goto IL_49;
						}
						goto IL_38;
						IL_49:
						valueChangedDelegate2 = valueChangedDelegate;
						global::custom_controls.CustomNumericUpDown.ValueChangedDelegate value2 = (global::custom_controls.CustomNumericUpDown.ValueChangedDelegate)global::System.Delegate.Remove(valueChangedDelegate2, value);
						valueChangedDelegate = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.CustomNumericUpDown.ValueChangedDelegate>(ref this.am, value2, valueChangedDelegate2);
						num = 2;
					}
					return;
				}
				default:
					if (false)
					{
					}
					break;
				}
				IL_38:
				valueChangedDelegate = this.am;
				goto IL_3F;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0001FD9C File Offset: 0x0001DF9C
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0001FDE0 File Offset: 0x0001DFE0
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(1)]
		[global::System.ComponentModel.Description("Specifies the max  length for input chars.")]
		public int MaxInputLength
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
				return this.w;
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
				this.w = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0001FE24 File Offset: 0x0001E024
		// (set) Token: 0x06000191 RID: 401 RVA: 0x0001FE68 File Offset: 0x0001E068
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("used to indicate the  text is modified or not.")]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Bindable(true)]
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
				return this.ad;
			}
			set
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_35;
						default:
							goto IL_6C;
						}
						break;
					case 2:
						goto IL_35;
					}
					if (true)
					{
					}
					if (this.ad != value)
					{
						num = 2;
						continue;
					}
					return;
					IL_35:
					this.ad = value;
					base.Invalidate();
					num = 1;
				}
				IL_6C:
				if (false)
				{
				}
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0001FEEC File Offset: 0x0001E0EC
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0001FF38 File Offset: 0x0001E138
		public string StandardValue
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
				string empty = string.Empty;
				this.GetStandardValue(ref empty);
				return empty;
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
				this.SetStandardValue(value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0001FF7C File Offset: 0x0001E17C
		// (set) Token: 0x06000195 RID: 405 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		public string FormattedValue
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
				string empty = string.Empty;
				this.GetFormatValue(ref empty);
				return empty;
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
				this.g(value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0002000C File Offset: 0x0001E20C
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00020054 File Offset: 0x0001E254
		public string ControlText
		{
			get
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
				return this.EditControl.Text;
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
				this.EditControl.Text = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0002009C File Offset: 0x0001E29C
		public global::System.Windows.Forms.TextBox EditControl
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
				return (global::System.Windows.Forms.TextBox)base.Controls[1];
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000200E8 File Offset: 0x0001E2E8
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0002012C File Offset: 0x0001E32C
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("used to indicate the value load from cp.")]
		[global::System.ComponentModel.Bindable(true)]
		public bool LoadingValue
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
				return this.ae;
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
				this.ae = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00020170 File Offset: 0x0001E370
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000201B4 File Offset: 0x0001E3B4
		public bool IsForTxRx
		{
			get
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
				return this.isForTxRx;
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
				this.isForTxRx = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000201F8 File Offset: 0x0001E3F8
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0002023C File Offset: 0x0001E43C
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Description("used to indicate min/max is loaded or not.")]
		[global::System.ComponentModel.Category("Customization")]
		public bool LoadingRange
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
				return this.af;
			}
			set
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.af = value;
						base.Invalidate();
						num = 2;
						continue;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_5A;
						}
						break;
					}
					IL_1C:
					if (this.af != value)
					{
						num = 1;
						continue;
					}
					goto IL_6C;
					goto IL_1C;
				}
				IL_5A:
				if (false)
				{
				}
				IL_6C:
				if (true)
				{
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000202C0 File Offset: 0x0001E4C0
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00020304 File Offset: 0x0001E504
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("used to indicate if blank is allowed in the control.")]
		[global::System.ComponentModel.Category("Customization")]
		public bool BlankAllowed
		{
			get
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
				return this.ab;
			}
			set
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.ab = value;
						base.Invalidate();
						num = 2;
						continue;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							if (false)
							{
							}
							break;
						}
						break;
					case 2:
						return;
					}
					if (this.ab == value)
					{
						break;
					}
					if (true)
					{
					}
					num = 0;
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00020388 File Offset: 0x0001E588
		public global::System.Globalization.NumberFormatInfo NumberFormatInfo
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
				this.LoadNumberFormatInfo();
				return this.x;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x000203D0 File Offset: 0x0001E5D0
		public global::System.Globalization.NumberFormatInfo InvariantNumberFormat
		{
			get
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
				this.LoadNumberFormatInfo();
				return this.y;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00020418 File Offset: 0x0001E618
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00020460 File Offset: 0x0001E660
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("used to indicate an infinity value if allowed.")]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Bindable(true)]
		public string Infinity
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
				return this.aj.c;
			}
			set
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_7A;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							this.a(value, ref this.aj);
							base.Invalidate();
							num = 0;
							continue;
						}
						break;
					}
					IL_26:
					if (this.aj.c != value)
					{
						num = 1;
						continue;
					}
					break;
					goto IL_26;
				}
				IL_7A:
				if (true)
				{
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x000204F4 File Offset: 0x0001E6F4
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0002053C File Offset: 0x0001E73C
		[global::System.ComponentModel.Description("used to indicate a none value if allowed.")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Category("Customization")]
		public string None
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
				return this.ak.c;
			}
			set
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_67;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_67;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							break;
						}
						break;
					}
					if (this.ak.c != value)
					{
						num = 1;
						continue;
					}
					break;
					IL_67:
					this.a(value, ref this.ak);
					base.Invalidate();
					num = 0;
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000205D0 File Offset: 0x0001E7D0
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("used to indicate if an infinity value exists.")]
		[global::System.ComponentModel.Bindable(true)]
		protected bool HasInfinity
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
				return this.aj.a;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00020618 File Offset: 0x0001E818
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00020660 File Offset: 0x0001E860
		protected string InfinityText
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
				return this.aj.d;
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
				this.aj.d = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000206A8 File Offset: 0x0001E8A8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("used to indicate a decimal infinity value if allowed.")]
		[global::System.ComponentModel.Category("Customization")]
		protected decimal InfinityValue
		{
			get
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
				return this.aj.b;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000206F0 File Offset: 0x0001E8F0
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00020738 File Offset: 0x0001E938
		public string SpecialDisplay
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
				return this.ak.c;
			}
			set
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							if (false)
							{
							}
							this.a(value, ref this.ak);
							base.Invalidate();
							num = 0;
							continue;
						}
						break;
					}
					if (true)
					{
					}
					if (!(this.ak.c != value))
					{
						break;
					}
					num = 1;
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000207CC File Offset: 0x0001E9CC
		public decimal SpecialDisplayValue
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
				return this.ak.b;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00020814 File Offset: 0x0001EA14
		[global::System.ComponentModel.Description("used to indicate if an infinity value exists.")]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Bindable(true)]
		protected bool HasSpecialDisplay
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
				return this.ak.a;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0002085C File Offset: 0x0001EA5C
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x000208A4 File Offset: 0x0001EAA4
		public string SpecialDisplayText
		{
			get
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
				return this.ak.d;
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
				this.ak.d = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000208EC File Offset: 0x0001EAEC
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00020930 File Offset: 0x0001EB30
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("used to indicate the value load from cp.")]
		public bool CanUndoText
		{
			get
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
				return this.ag;
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
				this.ag = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00020974 File Offset: 0x0001EB74
		public bool IsUndoDisabled
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
				return this.ah;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000209B8 File Offset: 0x0001EBB8
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x000209FC File Offset: 0x0001EBFC
		public bool IsGridColumnFixed
		{
			get
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
				return this.ai;
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
				this.ai = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00020A40 File Offset: 0x0001EC40
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00020A84 File Offset: 0x0001EC84
		public bool IsDynamicRange
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
				return this.an;
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
				this.an = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00020AC8 File Offset: 0x0001ECC8
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00020B0C File Offset: 0x0001ED0C
		public string ResourceId
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
				return this.ao;
			}
			set
			{
				int num = 2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						this.ao = value;
						num = 1;
						continue;
					case 1:
						return;
					}
					while (this.ao != value)
					{
						if (true)
						{
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
							goto IL_0A;
						}
					}
					break;
				}
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00020B8C File Offset: 0x0001ED8C
		public CustomNumericUpDown()
		{
			this.b();
			this.TextModified = false;
			this.ac = false;
			this.IsForTxRx = false;
			this.ae = false;
			this.ab = false;
			this.EditControl.TextChanged += this.a;
			this.SetMenuProperties();
			this.LoadNumberFormatInfo();
			this.x.PositiveInfinitySymbol = "∞";
			this.InfinityText = this.x.PositiveInfinitySymbol;
			this.z += this.x.PositiveInfinitySymbol;
			this.aa += this.x.PositiveInfinitySymbol;
			this.aa += this.al.a;
			this.aa += this.al.c;
			this.ag = false;
			this.ah = false;
			this.ai = false;
			this.ao = string.Empty;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		protected override void Dispose(bool disposing)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_72;
				case 1:
					goto IL_74;
				case 2:
					if (this.components != null)
					{
						num = 4;
						continue;
					}
					goto IL_91;
				case 4:
					if (true)
					{
					}
					this.components.Dispose();
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_74;
					}
					if (false)
					{
					}
					num = 0;
					continue;
				}
				if (disposing)
				{
					num = 1;
					continue;
				}
				break;
				IL_74:
				num = 2;
			}
			IL_72:
			IL_91:
			base.Dispose(disposing);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00020D68 File Offset: 0x0001EF68
		private void b()
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
			this.components = new global::System.ComponentModel.Container();
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00020DB0 File Offset: 0x0001EFB0
		public override void UpButton()
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						decimal num = 0m;
						this.LoadNumberFormatInfo();
						this.ac = false;
						this.CanUndoText = false;
						string text = this.ControlText;
						text = this.f(text);
						int num2 = 8;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_10C;
								default:
									if (false)
									{
									}
									num2 = 16;
									continue;
								}
								break;
							case 1:
								goto IL_236;
							case 2:
								num2 = 6;
								continue;
							case 3:
								num = base.Maximum - base.Increment;
								num2 = 9;
								continue;
							case 4:
								goto IL_250;
							case 5:
								goto IL_236;
							case 6:
								if (num == this.InfinityValue)
								{
									num2 = 11;
									continue;
								}
								goto IL_1D3;
							case 7:
								if (this.InfinityValue == base.Maximum)
								{
									num2 = 3;
									continue;
								}
								goto IL_1D3;
							case 8:
								if (text.Trim() == string.Empty)
								{
									num2 = 14;
									continue;
								}
								num2 = 13;
								continue;
							case 9:
								goto IL_1D3;
							case 10:
								goto IL_236;
							case 11:
								num2 = 7;
								continue;
							case 12:
								if (this.HasInfinity)
								{
									num2 = 0;
									continue;
								}
								goto IL_1D3;
							case 13:
								if (this.HasInvalidChars(this.ControlText))
								{
									num2 = 15;
									continue;
								}
								num = this.h(this.ControlText);
								num2 = 12;
								continue;
							case 14:
							{
								decimal a_ = 0m;
								this.a(1, ref a_);
								this.a(a_, 1);
								num2 = 10;
								continue;
							}
							case 15:
								this.a();
								num2 = 5;
								continue;
							case 16:
								goto IL_10C;
							}
							break;
							IL_10C:
							if (this.ControlText.Equals(this.Infinity))
							{
								num2 = 2;
								continue;
							}
							IL_1D3:
							this.ac = true;
							this.b(num, 1);
							num2 = 1;
							continue;
							IL_236:
							this.TextModified = false;
							this.CanUndoText = false;
							num2 = 4;
						}
					}
					IL_250:
					break;
				}
			}
			catch (global::System.Exception a_2)
			{
				this.a(a_2);
			}
			if (true)
			{
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00021048 File Offset: 0x0001F248
		public override void DownButton()
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						this.LoadNumberFormatInfo();
						decimal num = 0m;
						this.ac = false;
						this.CanUndoText = false;
						string text = this.ControlText;
						text = this.f(text);
						int num2 = 7;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								this.a();
								num2 = 11;
								continue;
							case 1:
								num2 = 13;
								continue;
							case 2:
								goto IL_236;
							case 3:
							{
								decimal a_ = 0m;
								this.a(2, ref a_);
								this.a(a_, 1);
								num2 = 16;
								continue;
							}
							case 4:
								if (this.HasInfinity)
								{
									num2 = 1;
									continue;
								}
								goto IL_1D3;
							case 5:
								num2 = 14;
								continue;
							case 6:
								goto IL_1D3;
							case 7:
								if (text.Trim() == string.Empty)
								{
									num2 = 3;
									continue;
								}
								num2 = 10;
								continue;
							case 8:
								num = base.Minimum + base.Increment;
								num2 = 6;
								continue;
							case 9:
								goto IL_250;
							case 10:
								if (this.HasInvalidChars(this.ControlText))
								{
									num2 = 0;
									continue;
								}
								num = this.h(this.ControlText);
								num2 = 4;
								continue;
							case 11:
								goto IL_236;
							case 12:
								num2 = 15;
								continue;
							case 13:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									if (false)
									{
									}
									if (!this.ControlText.Equals(this.Infinity))
									{
										goto IL_1D3;
									}
									break;
								}
								num2 = 5;
								continue;
							case 14:
								if (num == this.InfinityValue)
								{
									num2 = 12;
									continue;
								}
								goto IL_1D3;
							case 15:
								if (this.InfinityValue == base.Minimum)
								{
									num2 = 8;
									continue;
								}
								goto IL_1D3;
							case 16:
								goto IL_236;
							}
							break;
							IL_1D3:
							this.ac = true;
							this.b(num, 2);
							num2 = 2;
							continue;
							IL_236:
							this.TextModified = false;
							this.CanUndoText = false;
							num2 = 9;
						}
					}
					IL_250:
					break;
				}
			}
			catch (global::System.Exception a_2)
			{
				this.a(a_2);
			}
			if (true)
			{
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000212E0 File Offset: 0x0001F4E0
		protected override void OnLeave(global::System.EventArgs e)
		{
			try
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.CanUndoText = false;
				this.ah = false;
				this.CommitUserChanges();
				base.OnLeave(e);
				this.CanUndoText = false;
			}
			catch (global::System.Exception a_)
			{
				this.a(a_);
			}
			if (true)
			{
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0002135C File Offset: 0x0001F55C
		protected override void OnKeyPress(global::System.Windows.Forms.KeyPressEventArgs e)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						this.LoadNumberFormatInfo();
						int num = 29;
						for (;;)
						{
							string text;
							int num2;
							string text2;
							switch (num)
							{
							case 0:
								if (!base.Hexadecimal)
								{
									num = 3;
									continue;
								}
								text = "0123456789ABCDEFabcdef";
								num = 17;
								continue;
							case 1:
								text = null;
								num2 = 0;
								text2 = null;
								num = 0;
								continue;
							case 2:
								e.Handled = true;
								num = 20;
								continue;
							case 3:
								text = this.aa;
								num = 5;
								continue;
							case 4:
							{
								char keyChar;
								if (keyChar != ' ')
								{
									num = 23;
									continue;
								}
								goto IL_363;
							}
							case 5:
								goto IL_20E;
							case 6:
								goto IL_300;
							case 7:
								goto IL_47D;
							case 8:
								if (this.HasInvalidFormat(num2, text2, e.KeyChar))
								{
									num = 15;
									continue;
								}
								this.ControlText = text2.Insert(num2, global::System.Convert.ToString(e.KeyChar));
								this.EditControl.AppendText("");
								num = 33;
								continue;
							case 9:
								goto IL_2A3;
							case 10:
							{
								char keyChar;
								switch (keyChar)
								{
								case '(':
									num = 34;
									continue;
								case ')':
									goto IL_363;
								default:
									num = 35;
									continue;
								}
								break;
							}
							case 11:
								if (text2.Length >= this.MaxInputLength)
								{
									num = 26;
									continue;
								}
								num = 27;
								continue;
							case 12:
								this.CommitUserChanges();
								num = 6;
								continue;
							case 13:
								goto IL_47D;
							case 14:
								if (!char.IsControl(e.KeyChar))
								{
									num = 1;
									continue;
								}
								goto IL_47D;
							case 15:
								e.Handled = true;
								num = 13;
								continue;
							case 16:
								goto IL_2A3;
							case 17:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_20E;
								default:
									if (false)
									{
									}
									goto IL_20E;
								}
								break;
							case 18:
								goto IL_47D;
							case 19:
								goto IL_47D;
							case 20:
								goto IL_47D;
							case 21:
								if (this.HasInvalidFormat(num2, text2, e.KeyChar))
								{
									num = 2;
									continue;
								}
								goto IL_47D;
							case 22:
								num = 21;
								continue;
							case 23:
								num = 10;
								continue;
							case 24:
								goto IL_490;
							case 25:
								e.Handled = true;
								num = 30;
								continue;
							case 26:
								e.Handled = true;
								num = 18;
								continue;
							case 27:
							{
								if (text.IndexOf(e.KeyChar) == -1)
								{
									num = 28;
									continue;
								}
								char keyChar = e.KeyChar;
								num = 4;
								continue;
							}
							case 28:
								e.Handled = true;
								num = 7;
								continue;
							case 29:
								if (e.KeyChar == '\r')
								{
									num = 12;
									continue;
								}
								num = 14;
								continue;
							case 30:
								goto IL_47D;
							case 31:
								num2 = this.EditControl.SelectionStart;
								num = 9;
								continue;
							case 32:
								if (this.EditControl.SelectedText == "")
								{
									num = 31;
									continue;
								}
								num2 = this.ControlText.IndexOf(this.EditControl.SelectedText, global::System.StringComparison.Ordinal);
								num = 16;
								continue;
							case 33:
								goto IL_47D;
							case 34:
								if (this.HasInvalidFormat(num2, text2, e.KeyChar))
								{
									num = 25;
									continue;
								}
								this.ControlText = text2.Insert(0, global::System.Convert.ToString(e.KeyChar));
								this.EditControl.AppendText("");
								num = 19;
								continue;
							case 35:
								num = 22;
								continue;
							}
							break;
							IL_20E:
							text = text.Insert(0, " ");
							num = 32;
							continue;
							IL_2A3:
							text2 = this.ControlText.Remove(num2, this.EditControl.SelectedText.Length);
							num = 11;
							continue;
							IL_363:
							num = 8;
							continue;
							IL_47D:
							base.OnKeyPress(e);
							num = 24;
						}
					}
					IL_300:
					IL_490:
					break;
				}
			}
			catch (global::System.Exception a_)
			{
				this.a(a_);
			}
			if (true)
			{
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00021834 File Offset: 0x0001FA34
		private void a(object A_0, global::System.EventArgs A_1)
		{
			try
			{
				switch (0)
				{
				default:
					for (;;)
					{
						string text = this.Text;
						bool flag = false;
						string text2 = null;
						int num = 5;
						for (;;)
						{
							int num2;
							int numberNegativePattern;
							switch (num)
							{
							case 0:
								num = 19;
								continue;
							case 1:
								if (this.MaxInputLength > 0)
								{
									num = 24;
									continue;
								}
								goto IL_4B8;
							case 2:
								if (this.ac)
								{
									num = 9;
									continue;
								}
								num = 26;
								continue;
							case 3:
								if (!base.Hexadecimal)
								{
									num = 27;
									continue;
								}
								text2 = "0123456789ABCDEFabcdef";
								num = 32;
								continue;
							case 4:
								num2 = num2;
								num = 11;
								continue;
							case 5:
								if (!this.ae)
								{
									num = 30;
									continue;
								}
								goto IL_499;
							case 6:
								goto IL_4B3;
							case 7:
								goto IL_115;
							case 8:
								goto IL_115;
							case 9:
								goto IL_499;
							case 10:
								num = 4;
								continue;
							case 11:
								goto IL_115;
							case 12:
								num = 3;
								continue;
							case 13:
								num = 1;
								continue;
							case 14:
								if (this.Text.Length > num2)
								{
									num = 13;
									continue;
								}
								goto IL_4B8;
							case 15:
								goto IL_29A;
							case 16:
								goto IL_4B8;
							case 17:
								if (!this.Text.Equals(this.SpecialDisplayText, global::System.StringComparison.Ordinal))
								{
									num = 23;
									continue;
								}
								goto IL_4B8;
							case 18:
								if (flag)
								{
									num = 22;
									continue;
								}
								goto IL_44C;
							case 19:
								if (!text.Equals(this.SpecialDisplayText, global::System.StringComparison.Ordinal))
								{
									num = 29;
									continue;
								}
								goto IL_42C;
							case 20:
								switch (numberNegativePattern)
								{
								case 0:
								case 2:
								case 4:
									num2++;
									num = 7;
									continue;
								case 1:
								case 3:
									num2 = num2;
									num = 8;
									continue;
								default:
									num = 10;
									continue;
								}
								break;
							case 21:
								try
								{
									num = 4;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_3E1;
										case 1:
										{
											char c;
											if (text2.IndexOf(char.ToString(c), global::System.StringComparison.Ordinal) == -1)
											{
												num = 5;
												continue;
											}
											break;
										}
										case 3:
											num = 0;
											continue;
										case 5:
										{
											char c;
											text = text.Replace(c.ToString(), "");
											flag = true;
											num = 2;
											continue;
										}
										case 6:
										{
											global::System.Collections.IEnumerator enumerator;
											if (enumerator.MoveNext())
											{
												char c = (char)enumerator.Current;
												num = 1;
												continue;
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
												num = 3;
												continue;
											}
											break;
										}
										}
										IL_376:
										num = 6;
										continue;
										goto IL_376;
									}
									IL_3E1:;
								}
								finally
								{
									for (;;)
									{
										global::System.Collections.IEnumerator enumerator;
										global::System.IDisposable disposable = enumerator as global::System.IDisposable;
										num = 2;
										for (;;)
										{
											switch (num)
											{
											case 0:
												disposable.Dispose();
												num = 1;
												continue;
											case 1:
												goto IL_429;
											case 2:
												if (disposable != null)
												{
													num = 0;
													continue;
												}
												goto IL_42B;
											}
											break;
										}
									}
									IL_429:
									IL_42B:;
								}
								goto IL_42C;
							case 22:
								this.Text = text;
								num = 28;
								continue;
							case 23:
								num = 14;
								continue;
							case 24:
								this.Text = this.Text.Substring(0, num2);
								this.EditControl.SelectionStart = this.Text.Length;
								this.OnTextChanged(A_1);
								num = 16;
								continue;
							case 25:
								goto IL_4D2;
							case 26:
								if (!this.BlankAllowed)
								{
									num = 12;
									continue;
								}
								goto IL_4B8;
							case 27:
								text2 = this.aa;
								num = 15;
								continue;
							case 28:
								goto IL_44C;
							case 29:
							{
								global::System.Array array = text.ToCharArray();
								global::System.Collections.IEnumerator enumerator = array.GetEnumerator();
								num = 21;
								continue;
							}
							case 30:
								num = 2;
								continue;
							case 31:
								if (text != null)
								{
									num = 0;
									continue;
								}
								goto IL_42C;
							case 32:
								goto IL_29A;
							}
							break;
							IL_115:
							num = 17;
							continue;
							IL_29A:
							num = 31;
							continue;
							IL_42C:
							num = 18;
							continue;
							IL_44C:
							num2 = this.MaxInputLength;
							numberNegativePattern = this.x.NumberNegativePattern;
							num = 20;
							continue;
							IL_499:
							this.TextModified = false;
							this.CanUndoText = false;
							num = 6;
							continue;
							IL_4B8:
							this.TextModified = true;
							this.CanUndoText = true;
							num = 25;
						}
					}
					IL_4B3:
					IL_4D2:
					break;
				}
			}
			catch (global::System.Exception a_)
			{
				this.a(a_);
			}
			if (true)
			{
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00021D68 File Offset: 0x0001FF68
		public void CommitUserChanges()
		{
			for (;;)
			{
				this.CanUndoText = false;
				this.ah = false;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (base.UserEdit)
						{
							num = 11;
							continue;
						}
						return;
					case 1:
					{
						if (this.HasInvalidChars(this.ControlText))
						{
							num = 3;
							continue;
						}
						decimal a_ = this.h(this.ControlText);
						this.ac = true;
						this.b(a_, 0);
						num = 8;
						continue;
					}
					case 2:
						return;
					case 3:
						goto IL_18B;
					case 4:
					{
						string text;
						if (text.Equals(""))
						{
							num = 14;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18B;
						default:
							if (false)
							{
							}
							num = 1;
							continue;
						}
						break;
					}
					case 5:
						goto IL_190;
					case 6:
					{
						string text = this.f(this.ControlText);
						num = 4;
						continue;
					}
					case 7:
						goto IL_190;
					case 8:
						goto IL_190;
					case 9:
					{
						decimal a_2;
						if (this.a(0, ref a_2))
						{
							num = 16;
							continue;
						}
						this.a(a_2, 1);
						if (true)
						{
						}
						num = 7;
						continue;
					}
					case 10:
						if (this.TextModified)
						{
							num = 6;
							continue;
						}
						return;
					case 11:
						num = 10;
						continue;
					case 12:
						this.am(this, new global::System.EventArgs());
						num = 5;
						continue;
					case 13:
						goto IL_190;
					case 14:
					{
						decimal a_2 = 0m;
						num = 9;
						continue;
					}
					case 15:
						if (this.am != null)
						{
							num = 12;
							continue;
						}
						goto IL_190;
					case 16:
						num = 15;
						continue;
					}
					break;
					IL_18B:
					this.a();
					num = 13;
					continue;
					IL_190:
					base.UserEdit = false;
					num = 2;
				}
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00021F84 File Offset: 0x00020184
		private bool a(int A_0, ref decimal A_1)
		{
			bool result;
			for (;;)
			{
				if (true)
				{
				}
				result = false;
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return result;
					case 1:
						num = 7;
						continue;
					case 2:
						return result;
					case 3:
						switch (A_0)
						{
						case 0:
							num = 18;
							continue;
						case 1:
							num = 6;
							continue;
						case 2:
							num = 20;
							continue;
						default:
							num = 11;
							continue;
						}
						break;
					case 4:
						return result;
					case 5:
						num = 14;
						continue;
					case 6:
						if (this.HasInfinity)
						{
							num = 5;
							continue;
						}
						goto IL_14A;
					case 7:
						if (this.InfinityValue == base.Minimum)
						{
							num = 13;
							continue;
						}
						goto IL_182;
					case 8:
						return result;
					case 9:
						A_1 = this.InfinityValue;
						num = 16;
						continue;
					case 10:
						return result;
					case 11:
						num = 8;
						continue;
					case 12:
						return result;
					case 13:
						A_1 = base.Minimum + base.Increment;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							if (false)
							{
							}
							num = 10;
							continue;
						}
						break;
					case 14:
						if (this.InfinityValue == base.Minimum)
						{
							num = 19;
							continue;
						}
						goto IL_14A;
					case 15:
						return result;
					case 16:
						return result;
					case 17:
						if (this.HasInfinity)
						{
							num = 1;
							continue;
						}
						goto IL_182;
					case 18:
						if (this.BlankAllowed)
						{
							num = 21;
							continue;
						}
						num = 17;
						continue;
					case 19:
						A_1 = base.Minimum + base.Increment;
						num = 15;
						continue;
					case 20:
						if (this.HasInfinity)
						{
							num = 9;
							continue;
						}
						A_1 = base.Maximum;
						num = 0;
						continue;
					case 21:
						this.ControlText = string.Empty;
						result = true;
						num = 2;
						continue;
					}
					break;
					IL_14A:
					A_1 = base.Minimum;
					num = 4;
					continue;
					IL_182:
					A_1 = base.Minimum;
					num = 12;
				}
			}
			return result;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0002221C File Offset: 0x0002041C
		private void b(decimal A_0, int A_1)
		{
			switch (0)
			{
			default:
			{
				decimal num;
				for (;;)
				{
					num = 0m;
					this.ac = true;
					int num2 = 172;
					for (;;)
					{
						decimal num3;
						decimal num4;
						bool flag;
						bool flag2;
						switch (num2)
						{
						case 0:
							if (A_0 >= base.Maximum)
							{
								num2 = 157;
								continue;
							}
							num2 = 52;
							continue;
						case 1:
							num2 = 35;
							continue;
						case 2:
							goto IL_C53;
						case 3:
							goto IL_1219;
						case 4:
							if ((A_0 - base.Minimum) % base.Increment != 0m)
							{
								num2 = 93;
								continue;
							}
							num2 = 82;
							continue;
						case 5:
							if (A_0 > base.Maximum)
							{
								num2 = 8;
								continue;
							}
							num2 = 177;
							continue;
						case 6:
							if (A_0 == base.Minimum)
							{
								num2 = 131;
								continue;
							}
							num2 = 205;
							continue;
						case 7:
							if (A_0 == base.Maximum)
							{
								num2 = 109;
								continue;
							}
							num2 = 197;
							continue;
						case 8:
							num = base.Maximum;
							num2 = 74;
							continue;
						case 9:
							if (this.ControlText.Equals(this.SpecialDisplayText))
							{
								num2 = 58;
								continue;
							}
							goto IL_151B;
						case 10:
							goto IL_16F4;
						case 11:
							if (A_0 >= base.Minimum)
							{
								num2 = 199;
								continue;
							}
							goto IL_1A6F;
						case 12:
							goto IL_42A;
						case 13:
							if (!(A_0 < num3))
							{
								num2 = 119;
								continue;
							}
							goto IL_F73;
						case 14:
							this.IncrementValue(A_0, A_1, ref num);
							num2 = 223;
							continue;
						case 15:
							if (A_0 >= base.Minimum)
							{
								num2 = 214;
								continue;
							}
							goto IL_1A6F;
						case 16:
							if (this.ak.b == base.Minimum)
							{
								num2 = 31;
								continue;
							}
							goto IL_42A;
						case 17:
							if (A_0 <= base.Minimum)
							{
								num2 = 67;
								continue;
							}
							num2 = 85;
							continue;
						case 18:
							if ((A_0 - base.Minimum) % base.Increment != 0m)
							{
								num2 = 189;
								continue;
							}
							num = A_0;
							num2 = 64;
							continue;
						case 19:
							if (!(A_0 > base.Maximum))
							{
								num2 = 233;
								continue;
							}
							goto IL_16CD;
						case 20:
							goto IL_103B;
						case 21:
							if (A_0 == this.InfinityValue)
							{
								num2 = 210;
								continue;
							}
							num2 = 13;
							continue;
						case 22:
							if (A_0 <= base.Minimum)
							{
								num2 = 204;
								continue;
							}
							num2 = 190;
							continue;
						case 23:
							if (A_0 == base.Minimum)
							{
								num2 = 234;
								continue;
							}
							goto IL_18B7;
						case 24:
							goto IL_4CC;
						case 25:
							num2 = 147;
							continue;
						case 26:
							if (A_0 <= base.Maximum)
							{
								num2 = 69;
								continue;
							}
							goto IL_1A6F;
						case 27:
							num = num4;
							num2 = 129;
							continue;
						case 28:
							if (!(A_0 <= base.Minimum))
							{
								num2 = 121;
								continue;
							}
							goto IL_DBB;
						case 29:
							num2 = 21;
							continue;
						case 30:
							num = base.Maximum;
							num2 = 124;
							continue;
						case 31:
							flag = true;
							num3 += base.Increment;
							num2 = 12;
							continue;
						case 32:
							num = this.InfinityValue;
							num2 = 188;
							continue;
						case 33:
							goto IL_8AF;
						case 34:
							num = A_0 - base.Increment;
							num2 = 97;
							continue;
						case 35:
							if (!this.HasSpecialDisplay)
							{
								num2 = 55;
								continue;
							}
							goto IL_11C6;
						case 36:
							if (A_0 > base.Minimum)
							{
								num2 = 66;
								continue;
							}
							goto IL_1A6F;
						case 37:
							if (flag2)
							{
								num2 = 77;
								continue;
							}
							goto IL_1689;
						case 38:
							num = base.Minimum;
							num2 = 163;
							continue;
						case 39:
							goto IL_6D5;
						case 40:
							goto IL_1036;
						case 41:
							if (flag2)
							{
								num2 = 225;
								continue;
							}
							goto IL_103B;
						case 42:
							if (flag)
							{
								num2 = 217;
								continue;
							}
							goto IL_FA6;
						case 43:
							goto IL_4DF;
						case 44:
							if (A_0 < base.Minimum)
							{
								num2 = 169;
								continue;
							}
							num2 = 226;
							continue;
						case 45:
							goto IL_16E0;
						case 46:
							goto IL_1900;
						case 47:
							goto IL_59F;
						case 48:
							goto IL_17A5;
						case 49:
							num = num3;
							num2 = 201;
							continue;
						case 50:
							num2 = 62;
							continue;
						case 51:
							num2 = 117;
							continue;
						case 52:
							if ((A_0 - base.Minimum) % base.Increment != 0m)
							{
								num2 = 59;
								continue;
							}
							num2 = 78;
							continue;
						case 53:
							goto IL_1669;
						case 54:
							num = A_0 + base.Increment;
							num2 = 194;
							continue;
						case 55:
							num2 = 229;
							continue;
						case 56:
							goto IL_FA1;
						case 57:
							if (A_0 < num3)
							{
								num2 = 88;
								continue;
							}
							goto IL_1689;
						case 58:
							goto IL_FA6;
						case 59:
							this.IncrementValue(A_0, A_1, ref num);
							num2 = 227;
							continue;
						case 60:
							num2 = 37;
							continue;
						case 61:
							if (A_0 > base.Maximum)
							{
								num2 = 115;
								continue;
							}
							num2 = 142;
							continue;
						case 62:
							goto IL_1772;
						case 63:
							if (flag2)
							{
								num2 = 224;
								continue;
							}
							goto IL_B89;
						case 64:
							goto IL_713;
						case 65:
							num2 = 221;
							continue;
						case 66:
							num2 = 26;
							continue;
						case 67:
							num = base.Minimum;
							num2 = 111;
							continue;
						case 68:
							num = A_0 + base.Increment;
							num2 = 165;
							continue;
						case 69:
							num = A_0 - base.Increment;
							num2 = 101;
							continue;
						case 70:
							this.IncrementValue(A_0, A_1, ref num);
							num2 = 33;
							continue;
						case 71:
							if (A_0 == this.InfinityValue)
							{
								num2 = 32;
								continue;
							}
							num2 = 118;
							continue;
						case 72:
							if (A_0 == base.Maximum)
							{
								num2 = 120;
								continue;
							}
							num2 = 61;
							continue;
						case 73:
							goto IL_FB9;
						case 74:
							goto IL_128D;
						case 75:
							goto IL_630;
						case 76:
							if ((A_0 - base.Minimum) % base.Increment != 0m)
							{
								num2 = 144;
								continue;
							}
							num2 = 191;
							continue;
						case 77:
							num2 = 57;
							continue;
						case 78:
							if (A_0 >= base.Minimum)
							{
								num2 = 203;
								continue;
							}
							goto IL_1A6F;
						case 79:
							if (A_0 == base.Maximum)
							{
								num2 = 38;
								continue;
							}
							num2 = 228;
							continue;
						case 80:
							goto IL_1516;
						case 81:
							if ((A_0 - base.Minimum) % base.Increment != 0m)
							{
								num2 = 70;
								continue;
							}
							num = A_0;
							num2 = 192;
							continue;
						case 82:
							if (A_0 > base.Minimum)
							{
								num2 = 99;
								continue;
							}
							goto IL_1A6F;
						case 83:
							goto IL_F86;
						case 84:
							goto IL_64B;
						case 85:
							if ((A_0 - base.Minimum) % base.Increment != 0m)
							{
								num2 = 125;
								continue;
							}
							num = A_0;
							num2 = 180;
							continue;
						case 86:
							num = this.ak.b;
							num2 = 158;
							continue;
						case 87:
							num3 += base.Increment;
							num4 -= base.Increment;
							num2 = 174;
							continue;
						case 88:
							goto IL_7F7;
						case 89:
							if (A_0 > base.Minimum)
							{
								num2 = 108;
								continue;
							}
							goto IL_1A6F;
						case 90:
							goto IL_C6E;
						case 91:
							num = base.Maximum;
							num2 = 24;
							continue;
						case 92:
							goto IL_1214;
						case 93:
							this.IncrementValue(A_0, A_1, ref num);
							num2 = 84;
							continue;
						case 94:
							goto IL_104E;
						case 95:
							this.IncrementValue(A_0, A_1, ref num);
							num2 = 114;
							continue;
						case 96:
							goto IL_1574;
						case 97:
							goto IL_1592;
						case 98:
							num = A_0 - base.Increment;
							num2 = 153;
							continue;
						case 99:
							num2 = 208;
							continue;
						case 100:
							goto IL_DBB;
						case 101:
							goto IL_1A3C;
						case 102:
							if (A_0 >= base.Minimum)
							{
								num2 = 138;
								continue;
							}
							goto IL_1A6F;
						case 103:
							goto IL_B5B;
						case 104:
							goto IL_5B7;
						case 105:
							goto IL_1219;
						case 106:
							if ((A_0 - base.Minimum) % base.Increment != 0m)
							{
								num2 = 164;
								continue;
							}
							num2 = 11;
							continue;
						case 107:
							goto IL_BE6;
						case 108:
							num2 = 170;
							continue;
						case 109:
							num = base.Minimum;
							num2 = 143;
							continue;
						case 110:
							if (!(A_0 > base.Maximum))
							{
								num2 = 145;
								continue;
							}
							goto IL_101E;
						case 111:
							goto IL_8C7;
						case 112:
							switch (A_1)
							{
							case 0:
								num2 = 206;
								continue;
							case 1:
								num2 = 72;
								continue;
							case 2:
								num2 = 133;
								continue;
							default:
								num2 = 50;
								continue;
							}
							break;
						case 113:
							num = base.Minimum;
							num2 = 184;
							continue;
						case 114:
							goto IL_F28;
						case 115:
							num = this.InfinityValue;
							num2 = 39;
							continue;
						case 116:
							switch (A_1)
							{
							case 0:
								num2 = 195;
								continue;
							case 1:
								num2 = 211;
								continue;
							case 2:
								num2 = 19;
								continue;
							default:
								num2 = 146;
								continue;
							}
							break;
						case 117:
							if (flag)
							{
								num2 = 159;
								continue;
							}
							goto IL_130C;
						case 118:
							if (A_0 == this.ak.b)
							{
								num2 = 200;
								continue;
							}
							goto IL_1900;
						case 119:
							num2 = 63;
							continue;
						case 120:
							num = base.Minimum;
							num2 = 96;
							continue;
						case 121:
							num2 = 173;
							continue;
						case 122:
							goto IL_5D5;
						case 123:
							num2 = 141;
							continue;
						case 124:
							goto IL_110E;
						case 125:
							this.IncrementValue(A_0, A_1, ref num);
							num2 = 47;
							continue;
						case 126:
							num = base.Minimum;
							num2 = 187;
							continue;
						case 127:
							if (A_0 <= base.Maximum)
							{
								num2 = 34;
								continue;
							}
							goto IL_1A6F;
						case 128:
							goto IL_1684;
						case 129:
							goto IL_1708;
						case 130:
							num = num3;
							num2 = 162;
							continue;
						case 131:
							num = base.Maximum;
							num2 = 222;
							continue;
						case 132:
							if (this.HasInfinity)
							{
								num2 = 1;
								continue;
							}
							goto IL_11C6;
						case 133:
							if (A_0 > base.Maximum)
							{
								num2 = 27;
								continue;
							}
							num2 = 23;
							continue;
						case 134:
							goto IL_101E;
						case 135:
							if ((A_0 - base.Minimum) % base.Increment != 0m)
							{
								num2 = 151;
								continue;
							}
							num2 = 89;
							continue;
						case 136:
							goto IL_18FB;
						case 137:
							if (A_0 < base.Minimum)
							{
								num2 = 113;
								continue;
							}
							num2 = 4;
							continue;
						case 138:
							num2 = 212;
							continue;
						case 139:
							num2 = 42;
							continue;
						case 140:
							goto IL_81B;
						case 141:
							if (A_0 < base.Maximum)
							{
								num2 = 156;
								continue;
							}
							goto IL_1A6F;
						case 142:
							if (A_0 < base.Minimum)
							{
								num2 = 49;
								continue;
							}
							num2 = 106;
							continue;
						case 143:
							goto IL_EA1;
						case 144:
							this.IncrementValue(A_0, A_1, ref num);
							num2 = 75;
							continue;
						case 145:
							num2 = 183;
							continue;
						case 146:
							num2 = 220;
							continue;
						case 147:
							if (this.HasSpecialDisplay)
							{
								num2 = 232;
								continue;
							}
							num2 = 116;
							continue;
						case 148:
							num = A_0 - base.Increment;
							num2 = 107;
							continue;
						case 149:
							switch (A_1)
							{
							case 0:
								num2 = 110;
								continue;
							case 1:
								num2 = 79;
								continue;
							case 2:
								num2 = 5;
								continue;
							default:
								num2 = 176;
								continue;
							}
							break;
						case 150:
							goto IL_17C5;
						case 151:
							this.IncrementValue(A_0, A_1, ref num);
							num2 = 56;
							continue;
						case 152:
							if (!(A_0 < num3))
							{
								num2 = 51;
								continue;
							}
							goto IL_17A5;
						case 153:
							goto IL_7F2;
						case 154:
							if ((A_0 - base.Minimum) % base.Increment != 0m)
							{
								num2 = 230;
								continue;
							}
							num2 = 36;
							continue;
						case 155:
							goto IL_19C2;
						case 156:
							num = A_0 + base.Increment;
							num2 = 103;
							continue;
						case 157:
							goto IL_1656;
						case 158:
							goto IL_1156;
						case 159:
							num2 = 196;
							continue;
						case 160:
							if (this.HasInfinity)
							{
								num2 = 215;
								continue;
							}
							goto IL_7B1;
						case 161:
							if (!(A_0 <= base.Minimum))
							{
								num2 = 60;
								continue;
							}
							goto IL_7F7;
						case 162:
							goto IL_9B0;
						case 163:
							goto IL_F6E;
						case 164:
							this.IncrementValue(A_0, A_1, ref num);
							num2 = 90;
							continue;
						case 165:
							goto IL_181B;
						case 166:
							if (this.HasSpecialDisplay)
							{
								num2 = 87;
								continue;
							}
							goto IL_7B1;
						case 167:
							num = base.Maximum;
							num2 = 80;
							continue;
						case 168:
							if ((A_0 - base.Minimum) % base.Increment != 0m)
							{
								num2 = 171;
								continue;
							}
							num = A_0;
							num2 = 155;
							continue;
						case 169:
							num = num3;
							num2 = 43;
							continue;
						case 170:
							if (A_0 <= base.Maximum)
							{
								num2 = 148;
								continue;
							}
							goto IL_1A6F;
						case 171:
							this.IncrementValue(A_0, A_1, ref num);
							num2 = 136;
							continue;
						case 172:
							if (!this.HasInfinity)
							{
								num2 = 25;
								continue;
							}
							goto IL_FBE;
						case 173:
							if (flag)
							{
								num2 = 65;
								continue;
							}
							goto IL_67E;
						case 174:
							switch (A_1)
							{
							case 0:
								num2 = 71;
								continue;
							case 1:
								num2 = 7;
								continue;
							case 2:
								num2 = 6;
								continue;
							default:
								num2 = 219;
								continue;
							}
							break;
						case 175:
							num = base.Maximum;
							num2 = 104;
							continue;
						case 176:
							num2 = 2;
							continue;
						case 177:
							if (A_0 == base.Minimum)
							{
								num2 = 139;
								continue;
							}
							goto IL_151B;
						case 178:
							if (A_0 < base.Minimum)
							{
								num2 = 130;
								continue;
							}
							num2 = 76;
							continue;
						case 179:
							goto IL_F73;
						case 180:
							goto IL_1193;
						case 181:
							goto IL_80A;
						case 182:
							if (A_0 < num3)
							{
								num2 = 126;
								continue;
							}
							num2 = 168;
							continue;
						case 183:
							if (A_0 == this.ak.b)
							{
								num2 = 134;
								continue;
							}
							num2 = 152;
							continue;
						case 184:
							goto IL_759;
						case 185:
							num2 = 0;
							continue;
						case 186:
							flag2 = true;
							num3 += base.Increment;
							num2 = 105;
							continue;
						case 187:
							goto IL_15F5;
						case 188:
							goto IL_1900;
						case 189:
							this.IncrementValue(A_0, A_1, ref num);
							num2 = 128;
							continue;
						case 190:
							if ((A_0 - base.Minimum) % base.Increment != 0m)
							{
								num2 = 14;
								continue;
							}
							num2 = 15;
							continue;
						case 191:
							if (A_0 >= base.Minimum)
							{
								num2 = 123;
								continue;
							}
							goto IL_1A6F;
						case 192:
							goto IL_F0D;
						case 193:
							goto IL_155C;
						case 194:
							goto IL_1307;
						case 195:
							if (A_0 >= base.Maximum)
							{
								num2 = 30;
								continue;
							}
							num2 = 17;
							continue;
						case 196:
							if (A_0 < num3)
							{
								num2 = 48;
								continue;
							}
							goto IL_130C;
						case 197:
							if (A_0 > base.Maximum)
							{
								num2 = 91;
								continue;
							}
							num2 = 178;
							continue;
						case 198:
							if (!(A_0 < base.Maximum))
							{
								goto IL_1A6F;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_17A5;
							default:
								if (false)
								{
								}
								num2 = 218;
								continue;
							}
							break;
						case 199:
							num2 = 198;
							continue;
						case 200:
							num = this.ak.b;
							num2 = 46;
							continue;
						case 201:
							goto IL_14FE;
						case 202:
							if (A_0 > num4)
							{
								num2 = 167;
								continue;
							}
							num2 = 182;
							continue;
						case 203:
							num2 = 209;
							continue;
						case 204:
							goto IL_16CD;
						case 205:
							if (A_0 > base.Maximum)
							{
								num2 = 231;
								continue;
							}
							num2 = 137;
							continue;
						case 206:
							if (!(A_0 > num4))
							{
								num2 = 29;
								continue;
							}
							goto IL_1549;
						case 207:
							if (A_0 < num3)
							{
								num2 = 179;
								continue;
							}
							goto IL_B89;
						case 208:
							if (A_0 <= base.Maximum)
							{
								num2 = 98;
								continue;
							}
							goto IL_1A6F;
						case 209:
							if (A_0 <= base.Maximum)
							{
								num2 = 68;
								continue;
							}
							goto IL_1A6F;
						case 210:
							goto IL_1549;
						case 211:
							if (!(A_0 < base.Minimum))
							{
								num2 = 185;
								continue;
							}
							goto IL_1656;
						case 212:
							if (A_0 < base.Maximum)
							{
								num2 = 54;
								continue;
							}
							goto IL_1A6F;
						case 213:
							if (this.ControlText.Equals(this.InfinityText))
							{
								num2 = 20;
								continue;
							}
							goto IL_18B7;
						case 214:
							num2 = 127;
							continue;
						case 215:
							num2 = 166;
							continue;
						case 216:
							goto IL_DD3;
						case 217:
							num2 = 9;
							continue;
						case 218:
							num = A_0 + base.Increment;
							num2 = 122;
							continue;
						case 219:
							num2 = 140;
							continue;
						case 220:
							goto IL_A98;
						case 221:
							if (A_0 < num3)
							{
								num2 = 100;
								continue;
							}
							goto IL_67E;
						case 222:
							goto IL_615;
						case 223:
							if (num < base.Minimum)
							{
								num2 = 175;
								continue;
							}
							goto IL_1A6F;
						case 224:
							num2 = 207;
							continue;
						case 225:
							num2 = 213;
							continue;
						case 226:
							if ((A_0 - base.Minimum) % base.Increment != 0m)
							{
								num2 = 95;
								continue;
							}
							num2 = 102;
							continue;
						case 227:
							goto IL_975;
						case 228:
							if (A_0 > base.Maximum)
							{
								num2 = 86;
								continue;
							}
							num2 = 44;
							continue;
						case 229:
							if (this.InfinityValue == base.Minimum)
							{
								num2 = 186;
								continue;
							}
							num4 -= base.Increment;
							num2 = 3;
							continue;
						case 230:
							this.IncrementValue(A_0, A_1, ref num);
							num2 = 92;
							continue;
						case 231:
							num = num4;
							num2 = 10;
							continue;
						case 232:
							goto IL_FBE;
						case 233:
							num2 = 22;
							continue;
						case 234:
							num2 = 41;
							continue;
						}
						break;
						IL_42A:
						num2 = 149;
						continue;
						IL_67E:
						num2 = 154;
						continue;
						IL_7B1:
						num2 = 132;
						continue;
						IL_7F7:
						num = this.InfinityValue;
						num2 = 181;
						continue;
						IL_B89:
						num2 = 81;
						continue;
						IL_DBB:
						num = this.ak.b;
						num2 = 216;
						continue;
						IL_F73:
						num = this.InfinityValue;
						num2 = 83;
						continue;
						IL_FA6:
						num = base.Maximum;
						num2 = 73;
						continue;
						IL_FBE:
						flag2 = false;
						flag = false;
						num3 = base.Minimum;
						num4 = base.Maximum;
						num2 = 160;
						continue;
						IL_101E:
						num = this.ak.b;
						num2 = 40;
						continue;
						IL_103B:
						num = base.Maximum;
						num2 = 94;
						continue;
						IL_11C6:
						num2 = 16;
						continue;
						IL_1219:
						num2 = 112;
						continue;
						IL_130C:
						num2 = 18;
						continue;
						IL_151B:
						num2 = 28;
						continue;
						IL_1549:
						num = this.InfinityValue;
						num2 = 193;
						continue;
						IL_1656:
						num = base.Minimum;
						num2 = 53;
						continue;
						IL_1689:
						num2 = 135;
						continue;
						IL_16CD:
						num = base.Maximum;
						num2 = 45;
						continue;
						IL_17A5:
						if (true)
						{
						}
						num = this.ak.b;
						num2 = 150;
						continue;
						IL_18B7:
						num2 = 161;
						continue;
						IL_1900:
						num2 = 202;
					}
				}
				IL_4CC:
				IL_4DF:
				IL_59F:
				IL_5B7:
				IL_5D5:
				IL_615:
				IL_630:
				IL_64B:
				IL_6D5:
				IL_713:
				IL_759:
				IL_7F2:
				IL_80A:
				IL_81B:
				IL_8AF:
				IL_8C7:
				IL_975:
				IL_9B0:
				IL_A98:
				IL_B5B:
				IL_BE6:
				IL_C53:
				IL_C6E:
				IL_DD3:
				IL_EA1:
				IL_F0D:
				IL_F28:
				IL_F6E:
				IL_F86:
				IL_FA1:
				IL_FB9:
				IL_1036:
				IL_104E:
				IL_110E:
				IL_1156:
				IL_1193:
				IL_1214:
				IL_128D:
				IL_1307:
				IL_14FE:
				IL_1516:
				IL_155C:
				IL_1574:
				IL_1592:
				IL_15F5:
				IL_1669:
				IL_1684:
				IL_16E0:
				IL_16F4:
				IL_1708:
				IL_1772:
				IL_17C5:
				IL_181B:
				IL_18FB:
				IL_19C2:
				IL_1A3C:
				IL_1A6F:
				this.a(num, 1);
				this.ac = false;
				return;
			}
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00023CA8 File Offset: 0x00021EA8
		private void a(decimal A_0, int A_1)
		{
			for (;;)
			{
				this.UpdateText(A_0);
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (base.Value != A_0)
						{
							num = 5;
							continue;
						}
						goto IL_65;
					case 1:
						this.am(this, new global::System.EventArgs());
						num = 3;
						continue;
					case 2:
						if (this.am != null)
						{
							num = 1;
							continue;
						}
						goto IL_A9;
					case 3:
						if (true)
						{
						}
						goto IL_A9;
					case 4:
						num = 2;
						continue;
					case 5:
						goto IL_49;
					case 6:
						if (A_1 == 1)
						{
							num = 4;
							continue;
						}
						goto IL_A9;
					}
					break;
					IL_65:
					num = 6;
					continue;
					IL_A9:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_65;
					}
					goto Block_4;
				}
			}
			IL_49:
			base.Value = A_0;
			return;
			Block_4:
			if (false)
			{
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00023D84 File Offset: 0x00021F84
		private void a()
		{
			decimal a_;
			for (;;)
			{
				a_ = 0m;
				int num = 5;
				for (;;)
				{
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						if (this.InfinityValue == base.Minimum)
						{
							num = 2;
							continue;
						}
						goto IL_65;
					case 1:
						num = 0;
						continue;
					case 2:
						a_ = base.Minimum + base.Increment;
						goto IL_88;
					case 3:
						goto IL_93;
					case 4:
						goto IL_74;
					case 5:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_88;
						default:
							if (false)
							{
							}
							if (this.HasInfinity)
							{
								num = 1;
								continue;
							}
							goto IL_65;
						}
						break;
					}
					break;
					IL_65:
					a_ = base.Minimum;
					num = 4;
					continue;
					IL_88:
					num = 3;
				}
			}
			IL_74:
			IL_93:
			this.a(a_, 1);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00023E64 File Offset: 0x00022064
		public void UpdateText(decimal updateValue)
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
			this.ControlText = this.ConvertToFormatText(updateValue);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00023EAC File Offset: 0x000220AC
		protected virtual void IncrementValue(decimal inputValue, int direction, ref decimal outputValue)
		{
			for (;;)
			{
				switch (direction)
				{
				case 0:
					goto IL_66;
				case 1:
					goto IL_1C;
				case 2:
					goto IL_DC;
				default:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_C3;
					}
					break;
				}
			}
			IL_1C:
			long num = (long)global::System.Math.Floor((double)((inputValue - base.Minimum) / base.Increment));
			outputValue = base.Minimum + base.Increment * (num + 1L);
			return;
			IL_66:
			num = (long)global::System.Math.Floor((double)((inputValue - base.Minimum) / base.Increment));
			outputValue = base.Minimum + base.Increment * num;
			return;
			IL_C3:
			if (false)
			{
			}
			if (true)
			{
			}
			return;
			IL_DC:
			num = (long)global::System.Math.Ceiling((double)((inputValue - base.Minimum) / base.Increment));
			outputValue = base.Minimum + base.Increment * (num - 1L);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00023FE0 File Offset: 0x000221E0
		public bool HasInvalidFormat(int selectionStart, string currentText, char keyChar)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_60;
				case 1:
					if (keyChar != ' ')
					{
						num = 7;
						continue;
					}
					goto IL_6C;
				case 2:
					num = 8;
					continue;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D6;
					default:
						if (false)
						{
						}
						if (keyChar == this.al.c[0])
						{
							num = 6;
							continue;
						}
						num = 9;
						continue;
					}
					break;
				case 4:
					goto IL_C0;
				case 6:
					goto IL_11C;
				case 7:
					num = 10;
					continue;
				case 8:
					goto IL_D6;
				case 9:
					if (keyChar == char.Parse(this.al.a))
					{
						num = 4;
						continue;
					}
					goto IL_16A;
				case 10:
					switch (keyChar)
					{
					case '(':
					case ')':
						goto IL_160;
					default:
						num = 2;
						continue;
					}
					break;
				}
				if (true)
				{
				}
				if (keyChar == this.al.c[0])
				{
					num = 0;
					continue;
				}
				num = 1;
				continue;
				IL_D6:
				num = 3;
			}
			IL_60:
			return this.HasNegativeSignError(selectionStart, currentText, keyChar);
			IL_6C:
			return this.HasNegativeSpaceError(selectionStart, currentText);
			IL_C0:
			return this.HasDecimalSeparatorError(selectionStart, currentText);
			IL_11C:
			return this.HasNegativeSignError(selectionStart, currentText, keyChar);
			IL_160:
			return this.HasNegativeSignError(selectionStart, currentText, keyChar);
			IL_16A:
			return this.HasInputNumberError(selectionStart, currentText);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00024160 File Offset: 0x00022360
		public bool HasNegativeSignError(int selectionStart, string currentText, char negativeSign)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (selectionStart == 0)
					{
						num = 9;
						continue;
					}
					return true;
				case 1:
					num = 28;
					continue;
				case 2:
					goto IL_12C;
				case 3:
					if (selectionStart != currentText.Length)
					{
						num = 27;
						continue;
					}
					return false;
				case 4:
					goto IL_304;
				case 6:
					if (selectionStart != currentText.Length)
					{
						num = 19;
						continue;
					}
					return false;
				case 7:
					num = 11;
					continue;
				case 8:
					goto IL_156;
				case 9:
					num = 23;
					continue;
				case 10:
					num = 17;
					continue;
				case 11:
					if (currentText.IndexOf(")", global::System.StringComparison.Ordinal) != -1)
					{
						num = 8;
						continue;
					}
					num = 22;
					continue;
				case 12:
					goto IL_2DC;
				case 13:
					if (currentText.IndexOf(")", global::System.StringComparison.Ordinal) == -1)
					{
						num = 10;
						continue;
					}
					return true;
				case 14:
					num = 24;
					continue;
				case 15:
					num = 21;
					continue;
				case 16:
					num = 13;
					continue;
				case 17:
					if (currentText.IndexOf(this.x.NegativeSign, global::System.StringComparison.Ordinal) != -1)
					{
						num = 2;
						continue;
					}
					num = 3;
					continue;
				case 18:
					switch (negativeSign)
					{
					case '(':
						num = 0;
						continue;
					case ')':
						num = 26;
						continue;
					default:
						num = 1;
						continue;
					}
					break;
				case 19:
					goto IL_267;
				case 20:
					num = 6;
					continue;
				case 21:
					if (currentText.IndexOf(this.x.NegativeSign, global::System.StringComparison.Ordinal) == -1)
					{
						num = 14;
						continue;
					}
					return true;
				case 22:
					if (selectionStart != 0)
					{
						num = 20;
						continue;
					}
					return false;
				case 23:
					if (currentText.IndexOf(this.x.NegativeSign, global::System.StringComparison.Ordinal) == -1)
					{
						num = 12;
						continue;
					}
					return true;
				case 24:
					if (currentText.IndexOf("(", global::System.StringComparison.Ordinal) == -1)
					{
						num = 7;
						continue;
					}
					return true;
				case 25:
					if (currentText.IndexOf("(", global::System.StringComparison.Ordinal) != -1)
					{
						num = 4;
						continue;
					}
					return false;
				case 26:
					if (selectionStart != 0)
					{
						num = 16;
						continue;
					}
					return true;
				case 27:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2DC;
					default:
						goto IL_192;
					}
					break;
				case 28:
					goto IL_2A9;
				}
				if (negativeSign == this.x.NegativeSign[0])
				{
					num = 15;
					continue;
				}
				num = 18;
				continue;
				IL_2DC:
				num = 25;
			}
			return true;
			IL_12C:
			return true;
			IL_156:
			return true;
			IL_192:
			if (false)
			{
			}
			return true;
			IL_267:
			if (true)
			{
			}
			return true;
			IL_2A9:
			return false;
			IL_304:
			return true;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00024474 File Offset: 0x00022674
		public bool HasNegativeSpaceError(int selectionStart, string currentText)
		{
			int num = 2;
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
					case 0:
						if (selectionStart != 0)
						{
							num = 9;
							continue;
						}
						return true;
					case 1:
						if (selectionStart >= currentText.IndexOf(")", global::System.StringComparison.Ordinal) + 1)
						{
							if (true)
							{
							}
							num = 6;
							continue;
						}
						return false;
					case 3:
						if (currentText.IndexOf(")", global::System.StringComparison.Ordinal) != -1)
						{
							num = 4;
							continue;
						}
						return false;
					case 4:
						goto IL_C3;
					case 5:
						num = 3;
						continue;
					case 6:
						return true;
					case 7:
						if (selectionStart != 0)
						{
							num = 5;
							continue;
						}
						goto IL_EE;
					case 8:
						return true;
					case 9:
						num = 1;
						continue;
					}
					if (currentText.IndexOf(" ", global::System.StringComparison.Ordinal) != -1)
					{
						num = 8;
						continue;
					}
					num = 7;
					continue;
				}
				IL_EE:
				num = 0;
				continue;
				IL_C3:
				goto IL_EE;
			}
			return true;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00024590 File Offset: 0x00022790
		public bool HasDecimalSeparatorError(int selectionStart, string currentText)
		{
			int num = 10;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return true;
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B9;
					default:
						if (false)
						{
						}
						if (selectionStart == 0)
						{
							num = 0;
							continue;
						}
						goto IL_67;
					}
					break;
				case 2:
					if (selectionStart > currentText.IndexOf(")", global::System.StringComparison.Ordinal))
					{
						num = 4;
						continue;
					}
					return false;
				case 3:
					num = 1;
					continue;
				case 4:
					return true;
				case 5:
					if (currentText.IndexOf("(", global::System.StringComparison.Ordinal) != -1)
					{
						num = 3;
						continue;
					}
					goto IL_67;
				case 6:
					if (base.DecimalPlaces == 0)
					{
						num = 8;
						continue;
					}
					num = 5;
					continue;
				case 7:
					num = 2;
					continue;
				case 8:
					goto IL_B9;
				case 9:
					num = 6;
					continue;
				case 10:
					if (true)
					{
					}
					break;
				case 11:
					if (currentText.IndexOf(")", global::System.StringComparison.Ordinal) != -1)
					{
						num = 7;
						continue;
					}
					return false;
				}
				if (currentText.IndexOf(this.al.a, global::System.StringComparison.Ordinal) == -1)
				{
					num = 9;
					continue;
				}
				break;
				IL_67:
				num = 11;
			}
			return true;
			IL_B9:
			return true;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000246E8 File Offset: 0x000228E8
		public bool HasInputNumberError(int selectionStart, string currentText)
		{
			int num = 6;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (currentText.IndexOf(this.al.a, global::System.StringComparison.Ordinal) != -1)
					{
						num = 2;
						continue;
					}
					return false;
				case 1:
					return true;
				case 2:
					num = 11;
					continue;
				case 3:
				{
					string text = currentText;
					text = this.d(text);
					text = this.c(text);
					num = 5;
					continue;
				}
				case 4:
					if (currentText.IndexOf(")", global::System.StringComparison.Ordinal) + 1 == selectionStart)
					{
						num = 9;
						continue;
					}
					goto IL_197;
				case 5:
				{
					string text;
					if (text.Length - text.IndexOf(this.al.a, global::System.StringComparison.Ordinal) - 1 >= this.x.NumberDecimalDigits)
					{
						num = 10;
						continue;
					}
					return false;
				}
				case 7:
					num = 4;
					continue;
				case 8:
					if (true)
					{
					}
					num = 12;
					continue;
				case 9:
					return true;
				case 10:
					goto IL_EB;
				case 11:
					if (selectionStart > currentText.IndexOf(this.al.a, global::System.StringComparison.Ordinal))
					{
						num = 3;
						continue;
					}
					return false;
				case 12:
					if (selectionStart == 0)
					{
						num = 1;
						continue;
					}
					goto IL_135;
				case 13:
					if (currentText.IndexOf("(", global::System.StringComparison.Ordinal) != -1)
					{
						num = 8;
						continue;
					}
					goto IL_135;
				}
				if (currentText.IndexOf(")", global::System.StringComparison.Ordinal) != -1)
				{
					num = 7;
					continue;
				}
				goto IL_197;
				IL_135:
				num = 0;
				continue;
				IL_197:
				num = 13;
			}
			IL_EB:
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
				if (false)
				{
				}
				return true;
			}
			return true;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000248B4 File Offset: 0x00022AB4
		protected bool HasInvalidChars(string textString)
		{
			switch (0)
			{
			default:
			{
				bool flag;
				for (;;)
				{
					string text = null;
					flag = false;
					int num = 24;
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						switch (num)
						{
						case 0:
							num = 52;
							continue;
						case 1:
							num = 34;
							continue;
						case 2:
							flag = true;
							num = 58;
							continue;
						case 3:
							flag = true;
							num = 59;
							continue;
						case 4:
							goto IL_28A;
						case 5:
							flag = true;
							num = 23;
							continue;
						case 6:
							if (!this.BlankAllowed)
							{
								num = 35;
								continue;
							}
							goto IL_65F;
						case 7:
							if (textString.IndexOf(")", global::System.StringComparison.Ordinal) != -1)
							{
								num = 1;
								continue;
							}
							goto IL_247;
						case 8:
							num = 16;
							continue;
						case 9:
						{
							string a_;
							if (a_ == "")
							{
								num = 31;
								continue;
							}
							goto IL_1F8;
						}
						case 10:
							goto IL_843;
						case 11:
							goto IL_6E7;
						case 12:
							text = this.z;
							num = 11;
							continue;
						case 13:
							goto IL_247;
						case 14:
							if (!flag)
							{
								num = 63;
								continue;
							}
							return flag;
						case 15:
							num = 40;
							continue;
						case 16:
							if (textString.IndexOf("(", global::System.StringComparison.Ordinal) > 0)
							{
								num = 39;
								continue;
							}
							num = 46;
							continue;
						case 17:
							goto IL_513;
						case 18:
							goto IL_1F8;
						case 19:
							if (!this.HasInfinity)
							{
								num = 0;
								continue;
							}
							goto IL_65F;
						case 20:
							num = 28;
							continue;
						case 21:
							flag = true;
							num = 13;
							continue;
						case 22:
							num = 42;
							continue;
						case 23:
							goto IL_65F;
						case 24:
							if (!base.Hexadecimal)
							{
								num = 12;
								continue;
							}
							text = "0123456789ABCDEFabcdef";
							num = 38;
							continue;
						case 25:
							flag = true;
							goto IL_14C;
						case 26:
							flag = false;
							num = 62;
							continue;
						case 27:
							if (this.HasInfinity)
							{
								num = 64;
								continue;
							}
							goto IL_389;
						case 28:
							if (this.HasSpecialDisplay)
							{
								num = 32;
								continue;
							}
							goto IL_227;
						case 29:
							num = 6;
							continue;
						case 30:
							num = 37;
							continue;
						case 31:
							flag = true;
							num = 18;
							continue;
						case 32:
							num = 43;
							continue;
						case 33:
							if (textString.IndexOf("(", global::System.StringComparison.Ordinal) == textString.LastIndexOf("(", global::System.StringComparison.Ordinal))
							{
								num = 8;
								continue;
							}
							goto IL_7DD;
						case 34:
							if (textString.IndexOf(")", global::System.StringComparison.Ordinal) != textString.LastIndexOf(")", global::System.StringComparison.Ordinal))
							{
								goto IL_513;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_14C;
							default:
								if (false)
								{
								}
								num = 22;
								continue;
							}
							break;
						case 35:
							goto IL_6E2;
						case 36:
							try
							{
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 1:
										flag = true;
										num = 2;
										continue;
									case 2:
										goto IL_4BC;
									case 3:
										goto IL_4C8;
									case 4:
										goto IL_4BC;
									case 5:
									{
										if (!enumerator.MoveNext())
										{
											num = 4;
											continue;
										}
										char c = (char)enumerator.Current;
										num = 6;
										continue;
									}
									case 6:
									{
										char c;
										if (text.IndexOf(char.ToString(c), global::System.StringComparison.Ordinal) == -1)
										{
											num = 1;
											continue;
										}
										break;
									}
									}
									IL_492:
									num = 5;
									continue;
									goto IL_492;
									IL_4BC:
									num = 3;
								}
								IL_4C8:
								goto IL_526;
							}
							finally
							{
								for (;;)
								{
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									num = 1;
									for (;;)
									{
										switch (num)
										{
										case 0:
											disposable.Dispose();
											num = 2;
											continue;
										case 1:
											if (disposable != null)
											{
												num = 0;
												continue;
											}
											goto IL_512;
										case 2:
											goto IL_510;
										}
										break;
									}
								}
								IL_510:
								IL_512:;
							}
							goto IL_513;
							IL_526:
							num = 49;
							continue;
						case 37:
							if (textString.IndexOf(this.al.c, global::System.StringComparison.Ordinal) != textString.LastIndexOf(this.al.c, global::System.StringComparison.Ordinal))
							{
								num = 2;
								continue;
							}
							goto IL_682;
						case 38:
							goto IL_6E7;
						case 39:
							goto IL_7DD;
						case 40:
							if (textString.IndexOf(this.al.a, global::System.StringComparison.Ordinal) != textString.LastIndexOf(this.al.a, global::System.StringComparison.Ordinal))
							{
								num = 60;
								continue;
							}
							return flag;
						case 41:
							if (textString.Length > 1)
							{
								num = 5;
								continue;
							}
							goto IL_65F;
						case 42:
							if (textString.IndexOf(")", global::System.StringComparison.Ordinal) != textString.Length - 1)
							{
								num = 17;
								continue;
							}
							num = 54;
							continue;
						case 43:
							if (textString.Equals(this.SpecialDisplayText))
							{
								num = 26;
								continue;
							}
							goto IL_227;
						case 44:
							num = 27;
							continue;
						case 45:
							if (textString != null)
							{
								num = 20;
								continue;
							}
							goto IL_65F;
						case 46:
							if (textString.IndexOf(")", global::System.StringComparison.Ordinal) == -1)
							{
								num = 25;
								continue;
							}
							goto IL_843;
						case 47:
							num = 33;
							continue;
						case 48:
							if (textString == "")
							{
								num = 29;
								continue;
							}
							num = 45;
							continue;
						case 49:
							if (!flag)
							{
								num = 44;
								continue;
							}
							goto IL_65F;
						case 50:
							if (textString.IndexOf(this.InfinityText, global::System.StringComparison.Ordinal) >= 0)
							{
								num = 51;
								continue;
							}
							goto IL_389;
						case 51:
							num = 41;
							continue;
						case 52:
							if (textString.IndexOf(this.InfinityText, global::System.StringComparison.Ordinal) != -1)
							{
								num = 3;
								continue;
							}
							goto IL_65F;
						case 53:
							goto IL_247;
						case 54:
							if (textString.IndexOf("(", global::System.StringComparison.Ordinal) == -1)
							{
								num = 21;
								continue;
							}
							goto IL_247;
						case 55:
							goto IL_843;
						case 56:
							if (textString.IndexOf(this.al.c, global::System.StringComparison.Ordinal) != -1)
							{
								num = 30;
								continue;
							}
							goto IL_682;
						case 57:
							if (textString.IndexOf("(", global::System.StringComparison.Ordinal) != -1)
							{
								num = 47;
								continue;
							}
							goto IL_843;
						case 58:
							goto IL_682;
						case 59:
							goto IL_65F;
						case 60:
							flag = true;
							num = 4;
							continue;
						case 61:
							if (textString.IndexOf(this.al.a, global::System.StringComparison.Ordinal) != -1)
							{
								num = 15;
								continue;
							}
							return flag;
						case 62:
							goto IL_65F;
						case 63:
						{
							string a_ = textString;
							a_ = this.d(a_);
							a_ = this.e(a_);
							num = 9;
							continue;
						}
						case 64:
							num = 50;
							continue;
						}
						break;
						IL_14C:
						num = 10;
						continue;
						IL_1F8:
						num = 57;
						continue;
						IL_227:
						global::System.Array array = textString.ToCharArray();
						enumerator = array.GetEnumerator();
						num = 36;
						continue;
						IL_247:
						num = 56;
						continue;
						IL_389:
						num = 19;
						continue;
						IL_513:
						flag = true;
						num = 53;
						continue;
						IL_65F:
						num = 14;
						continue;
						IL_682:
						if (true)
						{
						}
						num = 61;
						continue;
						IL_6E7:
						text = text.Insert(0, "()");
						text = text.Insert(0, this.al.c);
						text = text.Insert(0, this.al.a);
						text = text.Insert(0, this.al.b);
						text = text.Insert(0, " ");
						num = 48;
						continue;
						IL_7DD:
						flag = true;
						num = 55;
						continue;
						IL_843:
						num = 7;
					}
				}
				IL_28A:
				return flag;
				IL_6E2:
				flag = true;
				return flag;
			}
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00025144 File Offset: 0x00023344
		protected override void ValidateEditText()
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
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00025180 File Offset: 0x00023380
		protected override void UpdateEditText()
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
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000251BC File Offset: 0x000233BC
		protected override bool ProcessCmdKey(ref global::System.Windows.Forms.Message msg, global::System.Windows.Forms.Keys keyData)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (this.HasInfinity)
					{
						num = 7;
						continue;
					}
					return true;
				case 1:
					num = 3;
					continue;
				case 3:
					if (msg.Msg == 260)
					{
						goto IL_240;
					}
					goto IL_284;
				case 4:
					if (keyData != (global::System.Windows.Forms.Keys)262267)
					{
						goto IL_284;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_240;
					default:
						if (false)
						{
						}
						num = 5;
						continue;
					}
					break;
				case 5:
					num = 0;
					continue;
				case 6:
					goto IL_1D8;
				case 7:
					try
					{
						for (;;)
						{
							string data = string.Empty;
							global::System.Windows.Forms.IDataObject dataObject = global::System.Windows.Forms.Clipboard.GetDataObject();
							num = 2;
							for (;;)
							{
								switch (num)
								{
								case 0:
									if (dataObject.GetDataPresent(global::System.Windows.Forms.DataFormats.Text, false))
									{
										num = 4;
										continue;
									}
									goto IL_10E;
								case 1:
									if ((string)dataObject.GetData(global::System.Windows.Forms.DataFormats.Text, true) != null)
									{
										num = 10;
										continue;
									}
									goto IL_10E;
								case 2:
									if (dataObject != null)
									{
										num = 8;
										continue;
									}
									goto IL_10E;
								case 3:
									if ((string)dataObject.GetData(global::System.Windows.Forms.DataFormats.Text, true) != "")
									{
										num = 7;
										continue;
									}
									goto IL_10E;
								case 4:
									num = 1;
									continue;
								case 5:
									goto IL_1B9;
								case 6:
									goto IL_1C4;
								case 7:
									data = (string)dataObject.GetData(global::System.Windows.Forms.DataFormats.Text, false);
									num = 11;
									continue;
								case 8:
									num = 0;
									continue;
								case 9:
									global::System.Windows.Forms.Clipboard.SetDataObject(data, true);
									num = 5;
									continue;
								case 10:
									num = 3;
									continue;
								case 11:
									goto IL_10E;
								case 12:
									if (data != string.Empty)
									{
										num = 9;
										continue;
									}
									goto IL_1B9;
								}
								break;
								IL_10E:
								global::System.Windows.Forms.Clipboard.SetDataObject(this.InfinityText, false);
								this.EditControl.SelectAll();
								this.EditControl.Paste();
								num = 12;
								continue;
								IL_1B9:
								num = 6;
							}
						}
						IL_1C4:
						goto IL_24D;
					}
					catch
					{
						this.UpdateText(this.InfinityValue);
						goto IL_24D;
					}
					goto IL_1D8;
				}
				if (msg.Msg != 256)
				{
					num = 1;
					continue;
				}
				IL_1D8:
				num = 4;
				continue;
				IL_240:
				num = 6;
			}
			return true;
			IL_24D:
			if (true)
			{
			}
			this.CanUndoText = true;
			return true;
			IL_284:
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00025474 File Offset: 0x00023674
		public void GetStandardValue(ref string standardText)
		{
			try
			{
				for (;;)
				{
					string text;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						text = this.b(this.ControlText);
						break;
					}
					int num = 6;
					for (;;)
					{
						if (true)
						{
						}
						switch (num)
						{
						case 0:
							if (text.Equals(string.Empty))
							{
								num = 1;
								continue;
							}
							goto IL_6F;
						case 1:
							standardText = string.Empty;
							num = 5;
							continue;
						case 2:
							num = 0;
							continue;
						case 3:
							goto IL_C9;
						case 4:
							goto IL_D4;
						case 5:
							goto IL_C9;
						case 6:
							if (this.ab)
							{
								num = 2;
								continue;
							}
							goto IL_6F;
						}
						break;
						IL_6F:
						this.LoadNumberFormatInfo();
						standardText = this.a(base.Value);
						num = 3;
						continue;
						IL_C9:
						num = 4;
					}
				}
				IL_D4:;
			}
			catch (global::System.Exception)
			{
				standardText = base.Minimum.ToString("N", this.y);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00025590 File Offset: 0x00023790
		protected void GetFormatValue(ref string formatText)
		{
			try
			{
				for (;;)
				{
					string text = this.b(this.ControlText);
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (text.Equals(string.Empty))
							{
								num = 2;
								continue;
							}
							goto IL_67;
						case 1:
							goto IL_CC;
						case 2:
							formatText = string.Empty;
							num = 4;
							continue;
						case 3:
							if (this.ab)
							{
								num = 5;
								continue;
							}
							goto IL_67;
						case 4:
							goto IL_C1;
						case 5:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_67;
							default:
								if (false)
								{
								}
								num = 0;
								continue;
							}
							break;
						case 6:
							goto IL_C1;
						}
						break;
						IL_67:
						this.LoadNumberFormatInfo();
						formatText = this.ConvertToFormatText(base.Value);
						num = 6;
						continue;
						IL_C1:
						num = 1;
					}
				}
				IL_CC:;
			}
			catch (global::System.Exception)
			{
				formatText = this.ConvertToFormatText(base.Minimum);
			}
			if (true)
			{
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000256A0 File Offset: 0x000238A0
		private decimal h(string A_0)
		{
			decimal result;
			for (;;)
			{
				for (;;)
				{
					if (true)
					{
					}
					result = 0m;
					int num = 5;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (!base.Hexadecimal)
							{
								num = 7;
								continue;
							}
							result = global::System.Convert.ToInt32(A_0, 16);
							num = 8;
							continue;
						case 1:
							if (A_0 == this.SpecialDisplayText)
							{
								num = 6;
								continue;
							}
							goto IL_11B;
						case 2:
							num = 10;
							continue;
						case 3:
							if (this.HasSpecialDisplay)
							{
								num = 9;
								continue;
							}
							goto IL_11B;
						case 4:
							return result;
						case 5:
							if (this.HasInfinity)
							{
								num = 2;
								continue;
							}
							goto IL_182;
						case 6:
							goto IL_A1;
						case 7:
							try
							{
								return decimal.Parse(A_0, this.GetNumberFlags(), this.x);
							}
							catch
							{
								return decimal.Parse(this.c(A_0), this.GetNumberFlags(), this.x);
							}
							goto IL_A1;
						case 8:
							return result;
						case 9:
							num = 1;
							continue;
						case 10:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								if (false)
								{
								}
								if (A_0 == this.InfinityText)
								{
									num = 12;
									continue;
								}
								goto IL_182;
							}
							break;
						case 11:
							return result;
						case 12:
							result = this.InfinityValue;
							num = 11;
							continue;
						}
						break;
						IL_A1:
						result = this.SpecialDisplayValue;
						num = 4;
						continue;
						IL_11B:
						num = 0;
						continue;
						IL_182:
						num = 3;
					}
				}
			}
			return result;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00025860 File Offset: 0x00023A60
		public void SetStandardValue(string valueText)
		{
			try
			{
				for (;;)
				{
					base.UserEdit = false;
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_C9;
						case 1:
							goto IL_D4;
						case 2:
							goto IL_C9;
						case 3:
							if (!valueText.Equals(string.Empty))
							{
								goto IL_6E;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_84;
							default:
								if (false)
								{
								}
								num = 6;
								continue;
							}
							break;
						case 4:
							if (this.ab)
							{
								num = 5;
								continue;
							}
							goto IL_6E;
						case 5:
							this.ControlText = string.Empty;
							num = 0;
							continue;
						case 6:
							if (true)
							{
							}
							num = 4;
							continue;
						}
						break;
						IL_84:
						num = 2;
						continue;
						IL_6E:
						this.LoadNumberFormatInfo();
						decimal a_ = this.ConvertToStandardDecimal(valueText);
						this.a(a_, 0);
						goto IL_84;
						IL_C9:
						num = 1;
					}
				}
				IL_D4:;
			}
			catch (global::System.Exception a_2)
			{
				this.a(a_2);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00025968 File Offset: 0x00023B68
		private void g(string A_0)
		{
			try
			{
				for (;;)
				{
					IL_40:
					base.UserEdit = false;
					this.LoadNumberFormatInfo();
					string text = this.b(A_0);
					int num = 6;
					for (;;)
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
							switch (num)
							{
							case 0:
								goto IL_D1;
							case 1:
								this.ControlText = string.Empty;
								num = 5;
								continue;
							case 2:
								goto IL_DC;
							case 3:
								goto IL_72;
							case 4:
								if (this.ab)
								{
									num = 1;
									continue;
								}
								goto IL_74;
							case 5:
								goto IL_D1;
							case 6:
								if (text.Equals(string.Empty))
								{
									num = 3;
									continue;
								}
								goto IL_74;
							}
							goto IL_40;
							IL_74:
							decimal a_ = this.h(text);
							this.a(a_, 0);
							if (true)
							{
							}
							num = 0;
							continue;
							IL_D1:
							num = 2;
							continue;
						}
						}
						IL_72:
						num = 4;
					}
				}
				IL_DC:;
			}
			catch (global::System.Exception a_2)
			{
				this.a(a_2);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00025A78 File Offset: 0x00023C78
		protected decimal ConvertToStandardDecimal(string standardText)
		{
			decimal result;
			for (;;)
			{
				result = 0m;
				string text = standardText;
				text = this.c(text);
				int num = 7;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (standardText == this.InfinityText)
						{
							num = 12;
							continue;
						}
						goto IL_17D;
					case 1:
						if (this.HasSpecialDisplay)
						{
							num = 2;
							continue;
						}
						goto IL_116;
					case 2:
						num = 5;
						continue;
					case 3:
						goto IL_116;
					case 4:
						if (!base.Hexadecimal)
						{
							num = 11;
							continue;
						}
						result = global::System.Convert.ToInt32(text, 16);
						num = 8;
						continue;
					case 5:
						if (standardText == this.SpecialDisplayText)
						{
							num = 10;
							continue;
						}
						goto IL_116;
					case 6:
						num = 0;
						continue;
					case 7:
						if (this.HasInfinity)
						{
							num = 6;
							continue;
						}
						goto IL_17D;
					case 8:
						return result;
					case 9:
						if (true)
						{
						}
						goto IL_116;
					case 10:
						goto IL_A4;
					case 11:
						try
						{
							return decimal.Parse(text, this.GetNumberFlags(), this.y);
						}
						catch
						{
							return decimal.Parse(this.c(text), this.GetNumberFlags(), this.y);
						}
						goto IL_A4;
					case 12:
						result = this.InfinityValue;
						num = 9;
						continue;
					}
					break;
					for (;;)
					{
						IL_A4:
						result = this.SpecialDisplayValue;
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_C1;
						}
					}
					IL_C1:
					if (false)
					{
					}
					num = 3;
					continue;
					IL_116:
					num = 4;
					continue;
					IL_17D:
					num = 1;
				}
			}
			return result;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00025C40 File Offset: 0x00023E40
		protected string ConvertToFormatText(decimal number)
		{
			string text;
			for (;;)
			{
				text = string.Empty;
				if (true)
				{
				}
				int num = 12;
				for (;;)
				{
					switch (num)
					{
					case 0:
						text = this.InfinityText;
						num = 6;
						continue;
					case 1:
						if (!base.Hexadecimal)
						{
							num = 2;
							continue;
						}
						num = 14;
						continue;
					case 2:
						text = number.ToString("N", this.x);
						num = 3;
						continue;
					case 3:
						return text;
					case 4:
						if (number == this.SpecialDisplayValue)
						{
							num = 9;
							continue;
						}
						goto IL_9B;
					case 5:
						if (this.HasSpecialDisplay)
						{
							num = 7;
							continue;
						}
						goto IL_9B;
					case 6:
						return text;
					case 7:
						num = 4;
						continue;
					case 8:
						return text;
					case 9:
						text = this.SpecialDisplayText;
						num = 16;
						continue;
					case 10:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							return text;
						default:
							if (false)
							{
							}
							num = 13;
							continue;
						}
						break;
					case 11:
						return text;
					case 12:
						if (this.HasInfinity)
						{
							num = 10;
							continue;
						}
						goto IL_1B3;
					case 13:
						if (number == this.InfinityValue)
						{
							num = 0;
							continue;
						}
						goto IL_1B3;
					case 14:
						if (this.w > 0)
						{
							num = 15;
							continue;
						}
						text = string.Empty;
						num = 11;
						continue;
					case 15:
						text = ((int)number).ToString("X");
						text.PadLeft(this.MaxInputLength, '0');
						num = 8;
						continue;
					case 16:
						return text;
					}
					break;
					IL_9B:
					num = 1;
					continue;
					IL_1B3:
					num = 5;
				}
			}
			return text;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00025E38 File Offset: 0x00024038
		private string a(decimal A_0)
		{
			string text;
			for (;;)
			{
				text = string.Empty;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (this.w > 0)
						{
							num = 3;
							continue;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32;
						default:
							if (false)
							{
							}
							text = string.Empty;
							num = 6;
							continue;
						}
						break;
					case 1:
						text = A_0.ToString("N", this.InvariantNumberFormat);
						num = 4;
						continue;
					case 2:
						goto IL_32;
					case 3:
						if (true)
						{
						}
						text = ((int)A_0).ToString("X");
						text.PadLeft(this.MaxInputLength, '0');
						num = 5;
						continue;
					case 4:
						return text;
					case 5:
						return text;
					case 6:
						return text;
					}
					break;
					IL_32:
					if (!base.Hexadecimal)
					{
						num = 1;
					}
					else
					{
						num = 0;
					}
				}
			}
			return text;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00025F38 File Offset: 0x00024138
		public global::System.Globalization.NumberStyles GetNumberFlags()
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
			return global::System.Globalization.NumberStyles.AllowLeadingSign | global::System.Globalization.NumberStyles.AllowTrailingSign | global::System.Globalization.NumberStyles.AllowParentheses | global::System.Globalization.NumberStyles.AllowDecimalPoint;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00025F78 File Offset: 0x00024178
		protected void SetMenuProperties()
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
			this.menuUndo = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuUndo.MergeIndex = 1;
			this.menuUndo.Click += this.MenuUndoClick;
			this.menuUndo.Text = "&Undo";
			this.menuSep1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.menuSep1.MergeIndex = 2;
			this.menuCut = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuCut.MergeIndex = 3;
			this.menuCut.ShortcutKeys = (global::System.Windows.Forms.Keys)131160;
			this.menuCut.ShowShortcutKeys = false;
			this.menuCut.Click += this.MenuCutClick;
			this.menuCut.Text = "Cu&t";
			this.menuCopy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuCopy.MergeIndex = 4;
			this.menuCopy.ShortcutKeys = (global::System.Windows.Forms.Keys)131139;
			this.menuCopy.ShowShortcutKeys = false;
			this.menuCopy.Click += this.MenuCopyClick;
			this.menuCopy.Text = "&Copy";
			this.menuPaste = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuPaste.MergeIndex = 5;
			this.menuPaste.ShortcutKeys = (global::System.Windows.Forms.Keys)131158;
			this.menuPaste.ShowShortcutKeys = false;
			this.menuPaste.Click += this.MenuPasteClick;
			this.menuPaste.Text = "&Paste";
			this.menuDelete = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuDelete.MergeIndex = 6;
			this.menuDelete.ShortcutKeys = global::System.Windows.Forms.Keys.Delete;
			this.menuDelete.ShowShortcutKeys = false;
			this.menuDelete.Click += this.MenuDeleteClick;
			this.menuDelete.Text = "&Delete";
			this.menuSep2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.menuSep2.MergeIndex = 7;
			this.menuSelectAll = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuSelectAll.MergeIndex = 8;
			this.menuSelectAll.ShortcutKeys = (global::System.Windows.Forms.Keys)131137;
			this.menuSelectAll.ShowShortcutKeys = false;
			this.menuSelectAll.Click += this.MenuSelectAllClick;
			this.menuSelectAll.Text = "Select &All";
			this.ContextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip();
			this.ContextMenuStrip.Items.Add(this.menuUndo);
			this.ContextMenuStrip.Items.Add(this.menuSep1);
			this.ContextMenuStrip.Items.Add(this.menuCut);
			this.ContextMenuStrip.Items.Add(this.menuCopy);
			this.ContextMenuStrip.Items.Add(this.menuPaste);
			this.ContextMenuStrip.Items.Add(this.menuDelete);
			this.ContextMenuStrip.Opened += this.ContextMenuPopup;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0002628C File Offset: 0x0002448C
		public void MenuUndoClick(object sender, global::System.EventArgs e)
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
			this.UndoText();
			this.ah = true;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000262D4 File Offset: 0x000244D4
		public void MenuCopyClick(object sender, global::System.EventArgs e)
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
			this.EditControl.Copy();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0002631C File Offset: 0x0002451C
		public void MenuPasteClick(object sender, global::System.EventArgs e)
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
			this.EditControl.Paste();
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00026364 File Offset: 0x00024564
		public void MenuCutClick(object sender, global::System.EventArgs e)
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
			this.EditControl.Cut();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000263AC File Offset: 0x000245AC
		public void MenuDeleteClick(object sender, global::System.EventArgs e)
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
			this.DeleteText();
			this.CanUndoText = false;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000263F4 File Offset: 0x000245F4
		public void DeleteText()
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
				{
					int selectionStart = this.EditControl.SelectionStart;
					this.ControlText = this.ControlText.Remove(this.EditControl.SelectionStart, 1);
					this.EditControl.SelectionStart = selectionStart;
					goto IL_110;
				}
				case 1:
					goto IL_11B;
				case 2:
					if (this.EditControl.SelectionStart < this.Text.Length)
					{
						num = 0;
						continue;
					}
					return;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_110;
					default:
						goto IL_C4;
					}
					break;
				case 4:
					num = 2;
					continue;
				case 6:
					if (!this.ControlText.Equals(string.Empty))
					{
						num = 4;
						continue;
					}
					return;
				}
				if (!this.EditControl.SelectedText.Equals(string.Empty))
				{
					num = 3;
					continue;
				}
				num = 6;
				continue;
				IL_110:
				num = 1;
			}
			IL_C4:
			if (false)
			{
			}
			this.EditControl.SelectedText = string.Empty;
			return;
			IL_11B:
			if (true)
			{
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00026528 File Offset: 0x00024728
		public void MenuSelectAllClick(object sender, global::System.EventArgs e)
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
			this.EditControl.SelectAll();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00026570 File Offset: 0x00024770
		public void UndoText()
		{
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_08;
				case 1:
					return;
				case 2:
					this.EditControl.Undo();
					this.CanUndoText = false;
					num = 1;
					continue;
				}
				IL_24:
				if (!this.CanUndoText)
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
				IL_08:
				if (true)
				{
				}
				goto IL_24;
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000265F8 File Offset: 0x000247F8
		public void ContextMenuPopup(object sender, global::System.EventArgs e)
		{
			int num = 8;
			for (;;)
			{
				string value;
				switch (num)
				{
				case 0:
					goto IL_6F;
				case 1:
					if (true)
					{
					}
					if (this.CanUndoText)
					{
						num = 9;
						continue;
					}
					goto IL_1E0;
				case 2:
					this.menuCut.Enabled = false;
					this.menuCopy.Enabled = false;
					this.menuDelete.Enabled = false;
					num = 6;
					continue;
				case 3:
					goto IL_DD;
				case 4:
					if (string.IsNullOrEmpty(value))
					{
						num = 11;
						continue;
					}
					this.menuPaste.Enabled = true;
					num = 3;
					continue;
				case 5:
					goto IL_DD;
				case 6:
					goto IL_6F;
				case 7:
					if (this.EditControl.SelectedText == string.Empty)
					{
						num = 2;
						continue;
					}
					this.menuCut.Enabled = true;
					this.menuCopy.Enabled = true;
					this.menuDelete.Enabled = true;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_114;
					default:
						if (false)
						{
						}
						num = 0;
						continue;
					}
					break;
				case 9:
					goto IL_112;
				case 10:
					goto IL_114;
				case 11:
					this.menuPaste.Enabled = false;
					num = 5;
					continue;
				case 12:
					goto IL_A8;
				}
				if (!this.Focused)
				{
					num = 10;
					continue;
				}
				goto IL_A8;
				IL_6F:
				value = (string)global::System.Windows.Forms.Clipboard.GetDataObject().GetData(global::System.Windows.Forms.DataFormats.UnicodeText, true);
				num = 4;
				continue;
				IL_A8:
				num = 7;
				continue;
				IL_DD:
				this.menuSelectAll.Enabled = true;
				num = 1;
				continue;
				IL_114:
				base.Focus();
				this.EditControl.SelectAll();
				num = 12;
			}
			IL_112:
			this.menuUndo.Enabled = true;
			return;
			IL_1E0:
			this.menuUndo.Enabled = false;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000267FC File Offset: 0x000249FC
		public void LoadMenuText(string cut, string copy, string paste, string delete, string undo)
		{
			int num;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_68:
				if (string.IsNullOrEmpty(cut))
				{
					goto IL_A7;
				}
				num = 9;
				break;
			default:
				if (false)
				{
				}
				num = 6;
				break;
			}
			for (;;)
			{
				IL_26:
				switch (num)
				{
				case 0:
					this.menuPaste.Text = paste;
					num = 2;
					continue;
				case 1:
					this.menuCopy.Text = copy;
					num = 7;
					continue;
				case 2:
					goto IL_10A;
				case 3:
					return;
				case 4:
					if (true)
					{
					}
					if (!string.IsNullOrEmpty(paste))
					{
						num = 0;
						continue;
					}
					goto IL_10A;
				case 5:
					this.menuUndo.Text = undo;
					num = 3;
					continue;
				case 7:
					goto IL_148;
				case 8:
					if (!string.IsNullOrEmpty(undo))
					{
						num = 5;
						continue;
					}
					return;
				case 9:
					this.menuCut.Text = cut;
					num = 13;
					continue;
				case 10:
					if (!string.IsNullOrEmpty(copy))
					{
						num = 1;
						continue;
					}
					goto IL_148;
				case 11:
					if (!string.IsNullOrEmpty(delete))
					{
						num = 12;
						continue;
					}
					goto IL_CD;
				case 12:
					this.menuDelete.Text = delete;
					num = 14;
					continue;
				case 13:
					goto IL_108;
				case 14:
					goto IL_CD;
				}
				break;
				IL_CD:
				num = 8;
				continue;
				IL_10A:
				num = 11;
				continue;
				IL_148:
				num = 4;
			}
			goto IL_68;
			IL_108:
			IL_A7:
			num = 10;
			goto IL_26;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000269A0 File Offset: 0x00024BA0
		protected void LoadNumberFormatInfo()
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
			this.x = (global::System.Globalization.NumberFormatInfo)global::System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.Clone();
			this.x.NumberDecimalDigits = base.DecimalPlaces;
			this.y = (global::System.Globalization.NumberFormatInfo)global::System.Globalization.NumberFormatInfo.InvariantInfo.Clone();
			this.y.NumberDecimalDigits = base.DecimalPlaces;
			this.a(this.x, ref this.al);
			this.x.NumberGroupSeparator = "";
			this.y.NumberGroupSeparator = "";
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00026A64 File Offset: 0x00024C64
		private void a(string A_0, ref global::custom_controls.CustomNumericUpDown.a A_1)
		{
			int num = 0;
			decimal num2;
			for (;;)
			{
				switch (num)
				{
				case 1:
					if (!decimal.TryParse(A_0, this.GetNumberFlags(), this.y, out num2))
					{
						num = 2;
						continue;
					}
					goto IL_39;
				case 2:
					if (true)
					{
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_08;
					}
					if (false)
					{
					}
					num2 = decimal.Parse(this.c(A_0), this.GetNumberFlags(), this.y);
					num = 3;
					continue;
				case 3:
					goto IL_62;
				case 4:
					A_1.a = true;
					A_1.c = A_0;
					num2 = 0m;
					num = 1;
					continue;
				}
				IL_24:
				if (!string.IsNullOrEmpty(A_0))
				{
					num = 4;
					continue;
				}
				goto IL_D5;
				IL_08:
				goto IL_24;
			}
			IL_39:
			A_1.b = num2;
			return;
			IL_62:
			goto IL_39;
			IL_D5:
			A_1.a = false;
			A_1.c = this.ak.c;
			A_1.b = this.ak.b;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00026B70 File Offset: 0x00024D70
		private void a(decimal A_0, ref global::custom_controls.CustomNumericUpDown.a A_1)
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
			A_1.a = true;
			A_1.c = this.a(A_0);
			A_1.b = A_0;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00026BC8 File Offset: 0x00024DC8
		private void a(global::System.Globalization.NumberFormatInfo A_0, ref global::custom_controls.CustomNumericUpDown.b A_1)
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
			A_1.a = A_0.NumberDecimalSeparator;
			A_1.c = A_0.NegativeSign;
			A_1.b = A_0.NumberGroupSeparator;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00026C28 File Offset: 0x00024E28
		private string f(string A_0)
		{
			if (true)
			{
			}
			if (!string.IsNullOrEmpty(A_0))
			{
				for (;;)
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_28;
					}
				}
				IL_28:
				if (false)
				{
				}
				string a_ = this.e(A_0);
				a_ = this.d(a_);
				return this.c(a_);
			}
			return A_0;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00026C8C File Offset: 0x00024E8C
		private string e(string A_0)
		{
			while (!string.IsNullOrEmpty(A_0))
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
					return A_0.Replace(this.al.a, "");
				}
			}
			return A_0;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00026CF0 File Offset: 0x00024EF0
		private string d(string A_0)
		{
			while (!string.IsNullOrEmpty(A_0))
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
					if (true)
					{
					}
					string text = A_0.Replace("(", "");
					text = text.Replace(")", "");
					return text.Replace(this.al.c, "");
				}
				}
			}
			return A_0;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00026D74 File Offset: 0x00024F74
		private string c(string A_0)
		{
			if (string.IsNullOrEmpty(A_0))
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
					return A_0;
				}
			}
			if (true)
			{
			}
			return A_0.Replace(" ", "");
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00026DD0 File Offset: 0x00024FD0
		private string b(string A_0)
		{
			int num = 2;
			string text;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return text;
				case 1:
					goto IL_154;
				case 3:
					goto IL_D4;
				case 4:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D4;
					default:
					{
						if (false)
						{
						}
						string[] array;
						if (array.Length > 1)
						{
							num = 7;
							continue;
						}
						text = text.Replace(this.al.b, "");
						num = 6;
						continue;
					}
					}
					break;
				case 5:
					if (text != "")
					{
						num = 10;
						continue;
					}
					return text;
				case 6:
					return text;
				case 7:
				{
					text = text.Replace(this.al.b, "");
					string[] array;
					text = text.Insert(text.Length - array[array.Length - 1].Length, this.al.a);
					num = 0;
					continue;
				}
				case 8:
				{
					char[] separator = this.al.a.ToCharArray();
					string[] array = text.Split(separator);
					num = 4;
					continue;
				}
				case 9:
					text = A_0;
					text = this.c(text);
					num = 5;
					continue;
				case 10:
					num = 3;
					continue;
				}
				if (true)
				{
				}
				if (!string.IsNullOrEmpty(A_0))
				{
					num = 9;
					continue;
				}
				return A_0;
				IL_D4:
				if (this.al.b.Equals(this.al.a))
				{
					num = 8;
				}
				else
				{
					text = text.Replace(this.al.b, "");
					num = 1;
				}
			}
			return text;
			IL_154:
			return text;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00026F98 File Offset: 0x00025198
		private bool a(string A_0)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_33;
				case 1:
					goto IL_7A;
				case 2:
					if (!(string.Empty == A_0))
					{
						return false;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_33;
					default:
						if (false)
						{
						}
						num = 1;
						continue;
					}
					break;
				}
				if (true)
				{
				}
				if (A_0 != null)
				{
					num = 0;
					continue;
				}
				break;
				IL_33:
				num = 2;
			}
			return true;
			IL_7A:
			return true;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00027024 File Offset: 0x00025224
		private void a(global::System.Exception A_0)
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
			this.a();
		}

		// Token: 0x04000114 RID: 276
		private const string a = "&Undo";

		// Token: 0x04000115 RID: 277
		private const string b = "Cu&t";

		// Token: 0x04000116 RID: 278
		private const string c = "&Copy";

		// Token: 0x04000117 RID: 279
		private const string d = "&Paste";

		// Token: 0x04000118 RID: 280
		private const string e = "&Delete";

		// Token: 0x04000119 RID: 281
		private const string f = "Select &All";

		// Token: 0x0400011A RID: 282
		private const string g = "∞";

		// Token: 0x0400011B RID: 283
		private const string h = "";

		// Token: 0x0400011C RID: 284
		private const string i = " ";

		// Token: 0x0400011D RID: 285
		private const string j = "(";

		// Token: 0x0400011E RID: 286
		private const string k = ")";

		// Token: 0x0400011F RID: 287
		public const char FRONTPARENTHESIS_CHAR = '(';

		// Token: 0x04000120 RID: 288
		public const char LASTPARENTHESIS_CHAR = ')';

		// Token: 0x04000121 RID: 289
		public const char BLANK_SPACE_CHAR = ' ';

		// Token: 0x04000122 RID: 290
		private const string l = "()";

		// Token: 0x04000123 RID: 291
		private const string m = "N";

		// Token: 0x04000124 RID: 292
		private const string n = "X";

		// Token: 0x04000125 RID: 293
		private const string o = "0";

		// Token: 0x04000126 RID: 294
		private const char p = '0';

		// Token: 0x04000127 RID: 295
		private const string q = "0123456789ABCDEFabcdef";

		// Token: 0x04000128 RID: 296
		private const int r = 13;

		// Token: 0x04000129 RID: 297
		private const int s = 256;

		// Token: 0x0400012A RID: 298
		private const int t = 260;

		// Token: 0x0400012B RID: 299
		protected const int NO_PRESS = 0;

		// Token: 0x0400012C RID: 300
		protected const int UP_PRESS = 1;

		// Token: 0x0400012D RID: 301
		protected const int DOWN_PRESS = 2;

		// Token: 0x0400012E RID: 302
		private const int u = 0;

		// Token: 0x0400012F RID: 303
		private const int v = 1;

		// Token: 0x04000130 RID: 304
		protected global::System.ComponentModel.Container components;

		// Token: 0x04000131 RID: 305
		private int w;

		// Token: 0x04000132 RID: 306
		private global::System.Globalization.NumberFormatInfo x = new global::System.Globalization.NumberFormatInfo();

		// Token: 0x04000133 RID: 307
		private global::System.Globalization.NumberFormatInfo y;

		// Token: 0x04000134 RID: 308
		private string z = "0123456789";

		// Token: 0x04000135 RID: 309
		private string aa = "0123456789() ";

		// Token: 0x04000136 RID: 310
		private bool ab;

		// Token: 0x04000137 RID: 311
		private bool ac;

		// Token: 0x04000138 RID: 312
		private bool ad;

		// Token: 0x04000139 RID: 313
		private bool ae;

		// Token: 0x0400013A RID: 314
		private bool af;

		// Token: 0x0400013B RID: 315
		protected bool isForTxRx;

		// Token: 0x0400013C RID: 316
		private bool ag;

		// Token: 0x0400013D RID: 317
		private bool ah;

		// Token: 0x0400013E RID: 318
		private bool ai;

		// Token: 0x0400013F RID: 319
		public global::System.Windows.Forms.ToolStripMenuItem menuUndo;

		// Token: 0x04000140 RID: 320
		public global::System.Windows.Forms.ToolStripSeparator menuSep1;

		// Token: 0x04000141 RID: 321
		public global::System.Windows.Forms.ToolStripMenuItem menuCut;

		// Token: 0x04000142 RID: 322
		public global::System.Windows.Forms.ToolStripMenuItem menuCopy;

		// Token: 0x04000143 RID: 323
		public global::System.Windows.Forms.ToolStripMenuItem menuPaste;

		// Token: 0x04000144 RID: 324
		public global::System.Windows.Forms.ToolStripMenuItem menuDelete;

		// Token: 0x04000145 RID: 325
		public global::System.Windows.Forms.ToolStripSeparator menuSep2;

		// Token: 0x04000146 RID: 326
		public global::System.Windows.Forms.ToolStripMenuItem menuSelectAll;

		// Token: 0x04000147 RID: 327
		private global::custom_controls.CustomNumericUpDown.a aj;

		// Token: 0x04000148 RID: 328
		private global::custom_controls.CustomNumericUpDown.a ak;

		// Token: 0x04000149 RID: 329
		private global::custom_controls.CustomNumericUpDown.b al;

		// Token: 0x0400014A RID: 330
		private global::custom_controls.CustomNumericUpDown.ValueChangedDelegate am;

		// Token: 0x0400014B RID: 331
		private bool an;

		// Token: 0x0400014C RID: 332
		private string ao;

		// Token: 0x0200002D RID: 45
		private struct a
		{
			// Token: 0x0400014D RID: 333
			public bool a;

			// Token: 0x0400014E RID: 334
			public decimal b;

			// Token: 0x0400014F RID: 335
			public string c;

			// Token: 0x04000150 RID: 336
			public string d;
		}

		// Token: 0x0200002E RID: 46
		private struct b
		{
			// Token: 0x04000151 RID: 337
			public string a;

			// Token: 0x04000152 RID: 338
			public string b;

			// Token: 0x04000153 RID: 339
			public string c;
		}

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060001F2 RID: 498
		public delegate void ValueChangedDelegate(object sender, global::System.EventArgs e);
	}
}
